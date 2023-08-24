using System;
using eLoyaltyV3.Utility;
using eLoyaltyV3.AppModule.UI;
using NUnit.Framework;
using Constants = eLoyaltyV3.Utility.Constants;
using eLoyaltyV3.Entity;
using InfoMessageLogger;
using TestData;
using eLoyaltyV3.PageObject.Admin;
using BaseUtility.Utility;
using Queries = eLoyaltyV3.Utility.Queries;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : eLoyaltyV3.Utility.Setup
    {
        #region TP_156796 - Admin Admin Update

        public static void TC_221208()
        {
            if (TestCaseId == Constants.TC_221208)
            {
                Users data = new Users();
                //1.Log into Guest Loyalty Admin with valid credentials.
                string email, status, emailStatus, numbericData, noMatchData;
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("User should get land on Admin Home page");

                //2.On Member Search page, search for member    
                //email = ExcelData.ExcelDataReader.ReadData(1, "Email");
                status = TestData.ExcelData.TestDataReader.ReadData(1, "Status");
                emailStatus = TestData.ExcelData.TestDataReader.ReadData(1, "EmailStatus");
                noMatchData = TestData.ExcelData.TestDataReader.ReadData(1, "NoDataMatch");
                numbericData = TestData.ExcelData.TestDataReader.ReadData(1, "NumbericData");
                Queries.GetMemberForAdminUpdates(data);
                Admin.EnterEmail(data.MemberEmail);
                Admin.SelectMemberStatus(status);
                if (!ProjectName.Equals("AMR"))
                {
                    Admin.SelectEmailStatus(emailStatus);
                }

                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Member should get displayed under Member result table");
                Logger.LogTestData(TestPlanId, TestCaseId, "Email", data.MemberEmail);
                //3.Click on view icon to see member information page
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("User should get landed on Member Information page");

                //4.Verify 'Admin Update' tab
                VerifyTextOnPage("Admin Updates");
                Helper.PageDown();
                Logger.WriteDebugMessage("User should see 'Admin Update' tab.");

                //5.Click on Admin Update tab
                Admin.Click_Tab_AdminUpdates();
                Logger.WriteDebugMessage("Admin Update grid should get displayed");

                //6.Verify all the columns present in Admin Update tab.User is able to see below columns:
                Admin.AdminUpdates_Text_Filter(ProjectDetails.CommonAdminEmail);
                VerifyTextOnPage("Log Date");
                VerifyTextOnPage("Action");
                VerifyTextOnPage("By");
                VerifyTextOnPage("View");
                Logger.WriteDebugMessage("In the new tab display a grid with the following columns:Log Date, Action, By, View");

                //7.Click on View icon
                Admin.Click_AdminUpdates_Icon_View1();
                VerifyTextOnPage("Change Type");
                VerifyTextOnPage("Original Data");
                VerifyTextOnPage("New Data");
                Logger.WriteDebugMessage("System should display a modal window with details for the specific action");
                Admin.Admin_Update_View_Overlay_Close();

                //8.Verify search by entering first 3 alphabets/last 3 alphabets in 'Search' column.
                if (!ProjectName.Equals("Sarova"))
                {
                    Queries.GetAdminUpdatesData(data);
                    string setby = data.SetBy.Substring(0, 3);
                    Admin.AdminUpdates_Text_Filter(setby);
                    Logger.WriteDebugMessage("Page should get searched by first 3 alphabets");
                }

                //9.Verify search by entering invalid data which is not present in Admin Update tab
                Admin.AdminUpdates_Text_Filter(noMatchData);
                VerifyTextOnPage("No matching records found");
                Logger.WriteDebugMessage("No record should be displayed for invalid email address");

                //10.Verify search by special characters.For e.g: '@', '/', '-', ','
                Admin.AdminUpdates_Text_Filter("@");
                Logger.WriteDebugMessage("User should be able to search by entering" +"@");
                Admin.AdminUpdates_Text_Filter("/");
                Logger.WriteDebugMessage("User should be able to search by entering" + "/");
                Admin.AdminUpdates_Text_Filter("-");
                Logger.WriteDebugMessage("User should be able to search by entering" + "-");

                //11.Verify search with only numeric characters.
                Admin.AdminUpdates_Text_Filter(numbericData);
                Logger.WriteDebugMessage("User should be able to search by numeric characters.");
                Logger.LogTestData(TestPlanId, TestCaseId, "Numberic Data", numbericData, true);

                //12.Verify Search message for no matching data
                Admin.AdminUpdates_Text_Filter(noMatchData);
                VerifyTextOnPage("No matching records found");
                Logger.WriteDebugMessage("'No Matching Records found' message should be displayed in case of no matching data");

                //13.Verify message if matching data found as per Search
                if (!ProjectName.Equals("Sarova"))
                {
                    Admin.AdminUpdates_Text_Filter(data.SetBy);
                    Logger.WriteDebugMessage("Data should be displayed as per applied filter and the bottom message displays ");
                }
            }
        }

        public static void TC_221217()
        {try
            {
                if (TestCaseId == Constants.TC_221217)
                {
                    //Pre-requisites:.Log into Admin. 
                    Users data = new Users();
                    string level1 = "", level2 = "", MemberLevel1, MemberLevel2, email;

                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    //1.On Member Search page, search for member                
                    Queries.GetMemberLevel(data, 1);
                    MemberLevel1 = data.MembershipLevel;

                    Queries.GetMemberLevel(data, 2);
                    MemberLevel2 = data.MembershipLevel;
                    Logger.LogTestData(TestPlanId, TestCaseId, "Member Level 2", MemberLevel2);
                    if (MemberLevel1.Equals("Loyal Member Level 1"))
                    {
                        level1 = "Loyal_LVL1";
                        level2 = "Loyal_LVL2";
                    }
                    else if (MemberLevel1.Equals("Engage Explorer"))
                    {
                        level1 = "EXPLORER";
                        level2 = "HIGHFLYERS";
                    }
                    else if (MemberLevel1.Equals("Club Member"))
                    {
                        level1 = "ELITE";
                        level2 = "PREFERRED";
                    }
                    else
                    {
                        level1 = MemberLevel1;
                        level2 = MemberLevel2;
                    }
                    Queries.Return_AutoUpgradeDowngrade_Status(data, "Auto", level2, level1);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Member Level 1", level1);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Member Level 2 New", level2);

                    Queries.GetActiveMemberEmail(data);
                    Admin.EnterEmail(data.MemberEmail);
                    Admin.Click_Button_MemberSearch();
                    Logger.WriteDebugMessage("Member should get displayed under Member result table");

                    //2.Click on view icon to see member information page
                    Admin.Click_Icon_View(ProjectName);
                    Logger.WriteDebugMessage("User should get landed on Member Information page");
                    AddDelay(60000);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Active User Email", data.MemberEmail);

                    //3.Click on Admin Update tab
                    Admin.Click_Tab_AdminUpdates();
                    Logger.WriteDebugMessage("Admin Update grid should get displayed");

                    //4.Search for Auto downgraded member level under Admin Upgrade log
                    Helper.PageDown();
                    VerifyTextOnPage("No matching records found");
                    Logger.WriteDebugMessage("Auto downgraded member level record should NOT get reflected under Admin Update log");
                    try { Helper.ReloadPage(); }
                    catch { AddDelay(60000); };

                    //5.On Member Search page, search for member                
                    Queries.GetMemberLevel(data, 1);
                    MemberLevel1 = data.MembershipLevel;
                    Queries.GetMemberLevel(data, 2);
                    MemberLevel2 = data.MembershipLevel;

                    if (MemberLevel1.Equals("Loyal Member Level 1"))
                    {
                        level1 = "Loyal_LVL1";
                        level2 = "Loyal_LVL2";
                    }
                    else if (MemberLevel1.Equals("Engage Explorer"))
                    {
                        level1 = "EXPLORER";
                        level2 = "HIGHFLYERS";
                    }
                    else if (MemberLevel1.Equals("Club Member"))
                    {
                        level1 = "Member";
                        level2 = "PREFERRED";
                    }
                    Queries.Return_AutoUpgradeDowngrade_Status(data, "Auto", level1, level2);

                    Admin.EnterEmail(data.MemberEmail);
                    Admin.Click_Button_MemberSearch();
                    Logger.WriteDebugMessage("Member should get displayed under Member result table");

                    //6.Click on view icon to see member information page
                    Admin.Click_Icon_View(ProjectName);
                    Logger.WriteDebugMessage("User should get landed on Member Information page");
                    AddDelay(60000);
                    //7.Click on Admin Update tab
                    Admin.Click_Tab_AdminUpdates();
                    Helper.PageDown();
                    Logger.WriteDebugMessage("Admin Update grid should get displayed");

                    //8.Search for Auto downgraded member level under Admin Upgrade log                 
                    Admin.AdminUpdates_Text_Filter("Auto");
                    VerifyTextOnPage("No matching records found");
                    Logger.WriteDebugMessage("Auto downgraded member level record should NOT get reflected under Admin Update log");
                    try { Helper.ReloadPage(); }
                    catch { AddDelay(60000); };

                    //9.On Member Search page, search for member
                    Queries.GetAutoAddedUsers(data);
                    Admin.EnterEmail(data.eMail);
                    Admin.Click_Button_MemberSearch();
                    Logger.WriteDebugMessage("Member should get displayed under Member result table");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Auto Added User", data.eMail, true);

                    //3.Click on view icon to see member information page
                    Admin.Click_Icon_View(ProjectName);
                    Logger.WriteDebugMessage("User should get landed on Member Information page");

                    //4.Click on Admin Update tab
                    Admin.Click_Tab_AdminUpdates();
                    Helper.PageDown();
                    Logger.WriteDebugMessage("Admin Update grid should get displayed");
                    Admin.AdminUpdates_Text_Filter("Auto");

                    //5.Search for Auto added stay under Admin Update log    
                    if (ProjectName.Equals("ALH"))
                        VerifyTextOnPage("No data available in table");
                    else
                        VerifyTextOnPage("No matching record found");
                    Logger.WriteDebugMessage("Auto added stay should NOT get reflected under Admin Update log");
                }
            }
            catch { }
        }

        public static void TC_151546()
        {
            if (TestCaseId == Constants.TC_151546)
            {
                Users data = new Users();
                //Pre-requisites:
                //1.User has logged in to Guest Loyalty Admin  with valid credentials
                //2.User should be on Member Information  >> Admin Update Tab
                //3.More than 30 Entries should be present.               
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                Queries.ReturnEmail_WithMaximumAdminUpdates(data);
                Admin.EnterEmail(data.MemberEmail);
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Member should get displayed under Member result table");
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("User should get landed on Member Information page");
                Logger.LogTestData(TestPlanId, TestCaseId, "User with Maximum Admin Update", data.MemberEmail);
                Admin.Click_Tab_AdminUpdates();
                Logger.WriteDebugMessage("There are at least 30 records in grid.");

                //1.Make sure there is at least 30 records in grid.
                Admin.VerifyEntriesAdminUpdates_Dropdown(ProjectName);
                Logger.WriteDebugMessage("Entries drop down should display 4 mentioned selections");

                //2.Select 5 from Entries dropdown
                int runningNumber = 5;
                for (int i = 1; i < 5; i++)
                {
                    string noOfRecord = runningNumber.ToString();
                    Admin.AdminUpdates_SelectEntries(noOfRecord);               
                    Logger.WriteDebugMessage("Only " + noOfRecord + " items should be displayed at a time in the grid and ");
                    if(i==4)

                        Logger.LogTestData(TestPlanId, TestCaseId, "No of Records Displayed in Admin Update "+i, noOfRecord, true);
                    else
                        Logger.LogTestData(TestPlanId, TestCaseId, "No of Records Displayed in Admin Update " + i, noOfRecord);
                    Admin.Click_AdminUpdates_Button_Next();                    
                    Admin.Click_AdminUpdates_Button_Prev(ProjectName);                    

                    Logger.WriteDebugMessage("'Next' and 'Previous' work with no issues.");
                    runningNumber = runningNumber + 5;
                }
            }
        }

        public static void TC_151548()
        {
            if (TestCaseId == Constants.TC_151548)
                {
                    Users data = new Users();
                    //Pre-requisites:
                    //1.User has logged in to Guest Loyalty Admin  with valid credentials                                            
                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);

                    Logger.WriteDebugMessage("Logged in successfully.");
                    Queries.GetAutoAddedUsers(data);
                    Admin.EnterEmail(data.eMail);

                    //2.On Member Search page, search for member
                    Admin.Click_Button_MemberSearch();
                    Logger.WriteDebugMessage("Member should get displayed under Member result table");

                    //3.Click on view icon to see member information page
                    Admin.Click_Icon_View(ProjectName);
                    Logger.WriteDebugMessage("User should get landed on Member Information page");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Auto Added User", data.eMail);
                    AddDelay(60000);
                    //4.Click on Add Award on Member Awards.
                    Admin.Click_Tab_MemberAwards();
                    PageDown();
                    Admin.Click_MemberAwards_Button_AddAward();
                    Logger.WriteDebugMessage("User to land on Choose Perk pop up.");

                    //5.Select Award from drop down.
                    //6.Enter Comment.Click on Save.
                    Queries.GetRandomAwardName(data);
                    Admin.AddMemberAward("points $10", "test");
                    Logger.WriteDebugMessage("User should be able to see Newly added record in Grid.");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Award Name", data.AwardName, true);

                    //7.Go to the Admin Update tab.
                    Helper.ScrollToElement(PageObject_Admin.Tab_AdminUpdates());
                    Admin.Click_Tab_AdminUpdates();
                    Admin.AdminUpdates_Text_Filter("Add Award");
                    Logger.WriteDebugMessage("User should see newly added Award change log with below details Award Code,Award Name,Voucher Number,Comment");

                    //8.Login to database
                    //9.Validate changes in LOYAdminChange_Log
                    //Logger.WriteDebugMessage("Changes should get reflected in db ");
            }
        }

        public static void TC_151552()
        {
            if (TestCaseId == Constants.TC_151552)
            {
                Users data = new Users();
                //1.Login to Admin                                           
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //2.On Member Search page, search  for PMS user having stay
                //Queries.ReturnSignUpPMSCustomerWithStay(data);
                Queries.GetActiveMemberEmail(data);
                Admin.EnterEmail(data.MemberEmail);
                Admin.Click_Button_MemberSearch();                
                Logger.WriteDebugMessage("Member should get displayed under Member result table");

                //3.Click on view icon to see member information page
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("User should get landed on Member Information page");
                Logger.LogTestData(TestPlanId, TestCaseId, "PMS User with Stay", data.eMail);

                //4.Click on Member Stay tab
                Admin.Click_Tab_MemberStay();
                Helper.PageDown();
                //string DepartureTo = PageObject_Admin.Admin_MemberStay_Data_Departure().GetAttribute("innerHTML");
                //Queries.IdentifyHotel(data);
                Admin.Click_MemberstayButton_SearchStay();

                Logger.WriteDebugMessage("Member Search page should be displayed");
                Queries.Return_ReservationNumberOfPMSUser(data);
                //Admin.SelectProperty(data.PropertyName);
                Admin.Enter_ReservationNumber(data.ReservationNumber);
                Admin.Click_MemberstayButton_Search();
                ElementWait(PageObject_Admin.Admin_MemberStay_Checkbox_Select(), 500);
                Logger.LogTestData(TestPlanId, TestCaseId, "Property Name", data.PropertyName);
                Admin.Click_CheckBox_Select();
                Logger.WriteDebugMessage("Stay should be selected");               
                Admin.Click_MemberStay_Button_Save();
                Helper.ScrollToElement(PageObject_Admin.Admin_MemberStay_Button_Back());
                Admin.Click_Button_Back();
                Logger.WriteDebugMessage("Stay should get displayed");

                //5.Go to the Admin Update tab.
                Admin.Click_Tab_AdminUpdates();
                string date = DateTime.Now.Date.ToString("yyyy-MM-dd");
                Admin.AdminUpdates_Text_Filter(date);
                VerifyTextOnPage("Add stay");
                Logger.WriteDebugMessage("User should see added stay under Award change log with below details Res #,Status,Arrival,Departure.Hotel,Rate Code");
                Admin.Click_AdminUpdates_Icon_View1();
                Logger.WriteDebugMessage("User should see added stay under Award change log with below details Res #,Status,Arrival,Departure.Hotel,Rate Code");
                Logger.LogTestData(TestPlanId, TestCaseId, "Date Searched", date, true);
            }
        }

        public static void TC_151553()
        {
            if (TestCaseId == Constants.TC_151553)
                {
                    Users data = new Users();
                    //Pre - requisites:User has logged in to Guest Loyalty Admin with valid credentials
                    string email, reason, points, hotel, expiration, internalComments, memberComments;
                    email = TestData.ExcelData.TestDataReader.ReadData(1, "Email");
                    reason = TestData.ExcelData.TestDataReader.ReadData(1, "Reason");
                    points = TestData.ExcelData.TestDataReader.ReadData(1, "Points");
                    Queries.IdentifyHotel(data);
                    hotel = data.PropertyName;
                    internalComments = TestData.ExcelData.TestDataReader.ReadData(1, "InternalComments");
                    memberComments = TestData.ExcelData.TestDataReader.ReadData(1, "MemberComments");
                    expiration = TestData.ExcelData.TestDataReader.ReadData(1, "Expiration");
                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    //1.On Member Search page, search  for PMS user having stay 
                    Admin.SelectMemberStatus("Active");
                    Admin.EnterEmail(email);
                    Admin.Click_Button_MemberSearch();
                    Logger.WriteDebugMessage("Member should get displayed under Member result table");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Email", email, true);

                    //2.Click on view icon to see member information page
                    Admin.Click_Icon_View(ProjectName);
                    email = Admin.GetValueEmailAddress(ProjectName).Replace(" ", String.Empty);
                    Logger.WriteDebugMessage("User should get landed on Member Information page");

                    //3.Click on Member Transaction Tab               
                    Admin.Click_Tab_MemberTransactions();
                    Logger.WriteDebugMessage("User to land on Member transaction grid.");

                    //4.Click on Add Transaction button
                    PageDown();
                    Admin.Click_Button_AddTransaction();
                    Logger.WriteDebugMessage("Add Transaction pop - up should get displayed");

                    //5.Enter all mandatory field and click on save
                    string TransactionReason = Admin.TransactionReason(ProjectName);
                    Admin.AddTransaction(TransactionReason, points, expiration, internalComments, memberComments, ProjectName);
                    Admin.Click_Button_Save();

                    VerifyTextOnPage("Save Successful");
                    Logger.WriteDebugMessage(" Member transaction page should be displayed");

                    //6.Go to the Admin Update tab and search for any duplicate records.
                    Admin.Click_Tab_AdminUpdates();
                    Admin.AdminUpdates_Text_Filter("Add Transaction");
                    Admin.Click_AdminUpdates_Icon_View1();
                    VerifyTextOnPage("Add Transaction");
                    Logger.WriteDebugMessage("User should see newly added Award change log with below details");

                    //7.Login to database
                    //8.Validate changes in LOYAdminChange_Log
                    Queries.GetAdminChange_Type(data, "Add Transaction");
                    string id = data.ID;
                    Queries.GetAdminChange_Log(data, email);
                    if (data.ChangeTypeId.Equals(id))
                    {
                        Logger.WriteDebugMessage("Changes should get reflected in db");
                    }
                    else
                    {
                        Assert.Fail("Changes are NOT reflected in db");
                    }
                }
        }

        public static void TC_151554()
        {
            try
            {
                if (TestCaseId == Constants.TC_151554)
                {
                    Users data = new Users();
                    //Pre - requisites:User has logged in to Guest Loyalty Admin with valid credentials
                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    //1. On Member Search page, search for member                
                    Queries.GetMemberLevel(data, 1);
                    string MemberLevel1 = data.MembershipLevel;
                    Queries.GetMemberLevel(data, 2);
                    string MemberLevel2 = data.MembershipLevel;
                    if (MemberLevel1.Equals("Club Member"))
                    {
                        string Level1 = "MEMBER";
                        string Level2 = "ELITE";
                        Queries.GetDataAsPerMemberLevel(Level1, data);
                    }
                    else
                    {
                        Queries.GetDataAsPerMemberLevel(MemberLevel1, data);
                    }
                    string email = data.MemberEmail;
                    Admin.EnterEmail(email);
                    Admin.SelectEmailStatus("Confirmed");
                    Admin.Click_Button_MemberSearch();
                    Logger.WriteDebugMessage("Member should get displayed under Member result table");

                    //2.Click on view icon to see member information page
                    Admin.Click_Icon_View(ProjectName);
                    Logger.WriteDebugMessage("User should get landed on Member Information page");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Member Level 1", MemberLevel1);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Member Level 2", MemberLevel2);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Email as per Member Level", data.MemberEmail, true);

                    //3.Click on Member level from member information section Tab
                    //4.Change member level and click on save
                    Admin.SelectLevel(MemberLevel2);
                    Logger.WriteDebugMessage(MemberLevel2 + " Member Level Selected");
                    try
                    {
                        Admin.Click_Member_Level_Email_Yes_Button();
                    }
                    catch (Exception e)
                    {
                        Logger.WriteDebugMessage("Membership Upgrade overlay is not displaying");
                    }
                    Logger.WriteDebugMessage("Member level should get changed");

                    //Click on close if send email popup is displayed
                    if (PageObject_Admin.Admin_MemberInformation_Send_Email_Popup_Close().Displayed)
                    {
                        PageObject_Admin.Admin_MemberInformation_Send_Email_Popup_Close().Click();
                    }
                    //5.Go to the Admin Update tab.
                    Admin.Click_Tab_AdminUpdates();
                    Logger.WriteDebugMessage("Landed on Admin update Tab");
                    Admin.AdminUpdates_Text_Filter("Update Level");
                    VerifyTextOnPage("Update Level");
                    Admin.Click_AdminUpdates_Icon_View1();
                    Logger.WriteDebugMessage("User should see newly added Award change log with below details");

                    //6.Login to database
                    //7.Validate changes in LOYAdminChange_Log
                    string change = Admin.AssignChangeType(ProjectName);
                    Queries.GetAdminChange_Type(data, change);
                    Queries.GetAdminChange_Log(data, data.MemberEmail);
                    if (data.ChangeTypeId.Equals(data.ID))
                    {
                        Logger.WriteDebugMessage("Changes should get reflected in db");
                    }
                    else
                    {
                        Assert.Fail("Changes are NOT reflected in db");
                    }
                }
            }
            catch(Exception e) { }
        }

        public static void TC_155521()
        {
            try
            {
                if (TestCaseId == Constants.TC_155521)
                {
                    //Pre - requisites:User has logged in to Guest Loyalty Admin with valid credentials
                    Users data = new Users();
                    string id, email, status, updateStatus;

                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully.");
                    status = TestData.ExcelData.TestDataReader.ReadData(1, "Status");
                    updateStatus = TestData.ExcelData.TestDataReader.ReadData(1, "UpdateStatus");

                    //1.On Member Search page, search for member
                    Queries.GetActiveMemberEmail(data);
                    Admin.EnterEmail(data.MemberEmail);
                    Admin.SelectMemberStatus(status);
                    Admin.Click_Button_MemberSearch();
                    Logger.WriteDebugMessage("Member should get displayed under Member result table");

                    //2.Click on view icon to see member information page
                    Admin.Click_Icon_View(ProjectName);
                    Logger.WriteDebugMessage("User should get landed on Member Information page");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Active Email", data.MemberEmail, true);
                    AddDelay(60000);
                    //3.Change the Member Status from Active to InActive.                
                    email = Admin.GetValueEmailAddress(ProjectName).Replace(" ", String.Empty);
                    Admin.SelectStatus(updateStatus);
                    Logger.WriteDebugMessage("User should be able to Change the status.");

                    //4.Go to the Admin Update tab.
                    Admin.Click_Tab_AdminUpdates();
                    //PageDown();
                    Logger.WriteDebugMessage("User should see Edited Member Status log with below details");

                    //5.Login to database
                    //6.Validate changes in LOYAdminChange_Log
                    Queries.GetAdminChange_Type(data, "Update Member Status");
                    id = data.ID;
                    Queries.GetAdminChange_Log(data, email);
                    if (data.ChangeTypeId.Equals(id))
                    {
                        Logger.WriteDebugMessage("Changes should get reflected in db");
                    }
                    else
                    {
                        Assert.Fail("Changes are NOT reflected in db");
                    }

                    //7.Change the Member Status from InActive to Active.
                    Admin.SelectStatus(status);
                    Logger.WriteDebugMessage("User should be able to Change the status.");

                    //8.Repeat Step 4 to 6.
                    Admin.Click_Tab_AdminUpdates();
                    PageDown();
                    Queries.GetAdminChange_Type(data, "Update Member Status");
                    id = data.ID;
                    Queries.GetAdminChange_Log(data, email);
                    if (data.ChangeTypeId.Equals(id))
                    {
                        Logger.WriteDebugMessage("Changes should get reflected in db");
                    }
                    else
                    {
                        Assert.Fail("Changes are NOT reflected in db");
                    }

                    //9.Change the Member Status from InActive to Active.
                    Admin.SelectStatus("Deactivated");
                    Logger.WriteDebugMessage("User should be able to Change the status.");

                    //10.Repeat Step 4 to 6.
                    Admin.Click_Tab_AdminUpdates();
                    PageDown();
                    Queries.GetAdminChange_Type(data, "Update Member Status");
                    id = data.ID;
                    Queries.GetAdminChange_Log(data, email);
                    if (data.ChangeTypeId.Equals(id))
                    {
                        Logger.WriteDebugMessage("Changes should get reflected in db");
                    }
                    else
                    {
                        Assert.Fail("Changes are NOT reflected in db");
                    }
                }
            }
            catch (Exception e) { }
        }
        //Test cases are moved from V3 to Global
        //V3
        /*
        public static void TC_151536()
        {
            Users data = new Users();
            if (TestCaseId == Constants.TC_151536)
            {
                //1.Log into Admin.              
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //2.On Member Search page, search for member
                string level1 = "", level2 = "";
                Queries.GetMemberLevel(data, 1);
                string MemberLevel1 = data.MembershipLevel;
                Queries.GetMemberLevel(data, 2);
                string MemberLevel2 = data.MembershipLevel;
                if (ProjectName.Equals("MyStay") || ProjectName.Equals("HotelIcon") || ProjectName.Equals("Origami"))
                {
                    if (MemberLevel1.Equals("Loyal Member Level 1"))
                    {
                        level1 = "Loyal_LVL1";
                        level2 = "Loyal_LVL2";
                    }
                    else if (MemberLevel1.Equals("Engage Explore"))
                    {
                        level1 = "Explorer";
                        level2 = "Highflyers";
                    }
                    else if (MemberLevel1.Equals("Club Member"))
                    {
                        level1 = "PREFERRED";
                        level2 = "ELITE";
                    }

                    Queries.Return_AutoUpgradeDowngrade_Status(data, "Auto", level1, level2);
                }
                else
                {
                    Queries.Return_AutoUpgradeDowngrade_Status(data, "Auto", MemberLevel1, MemberLevel2);
                }


                Admin.EnterEmail(data.MemberEmail);
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Member should get displayed under Member result table");

                //3.Click on view icon to see member information page
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("User should get landed on Member Information page");

                //4.Click on Admin Update tab
                Admin.Click_Tab_AdminUpdates();
                Logger.WriteDebugMessage("Admin Update grid should get displayed");

                //5.Search for Auto downgraded member level under Admin Upgrade log
                VerifyTextOnPage("No matching records found");
                Logger.WriteDebugMessage(
                    "Auto downgraded member level record should NOT get reflected under Admin Update log");
            }
        }

        public static void TC_151537()
        {
            if (TestCaseId == Constants.TC_151537)
            {
                //1.Log into Guest Loyalty Admin with valid credentials.              
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("User should get land on Admin Home page");

                //2.On Member Search page, search for member     
                Users data = new Users();
                Queries.GetActiveMemberEmail(data);

                Admin.EnterEmail(data.MemberEmail);

                Admin.SelectMemberStatus(TestData.TC_151537_Status);
                if (!ProjectName.Equals("AMR"))
                {
                    Admin.SelectEmailStatus(TestData.TC_151537_EmailStatus);
                }

                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Member should get displayed under Member result table");

                //3.Click on view icon to see member information page
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("User should get landed on Member Information page");

                //4.Verify 'Admin Update' tab
                VerifyTextOnPage("Admin Updates");
                Logger.WriteDebugMessage("User should see 'Admin Update' tab.");
            }
        }

        public static void TC_151538()
        {
            if (TestCaseId == Constants.TC_151538)
            {
                Users data = new Users();
                //1.Log into Admin.              
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //2.On Member Search page, search for member
                string level1 = "", level2 = "";
                Queries.GetMemberLevel(data, 1);
                string MemberLevel1 = data.MembershipLevel;
                Queries.GetMemberLevel(data, 2);
                string MemberLevel2 = data.MembershipLevel;
                if (ProjectName.Equals("MyStay") || ProjectName.Equals("HotelIcon") || ProjectName.Equals("Origami"))
                {
                    if (MemberLevel1.Equals("Loyal Member Level 1"))
                    {
                        level1 = "Loyal_LVL1";
                        level2 = "Loyal_LVL2";
                    }
                    else if (MemberLevel1.Equals("Engage Explore"))
                    {
                        level1 = "Explorer";
                        level2 = "Highflyers";
                    }
                    else if (MemberLevel1.Equals("Club Member"))
                    {
                        level1 = "PREFERRED";
                        level2 = "Member";
                    }

                    Queries.Return_AutoUpgradeDowngrade_Status(data, "Auto", level1, level2);
                }
                else
                {
                    Queries.Return_AutoUpgradeDowngrade_Status(data, "Auto", MemberLevel1, MemberLevel2);
                }

                string email = data.MemberEmail;
                Admin.EnterEmail(email);
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Member should get displayed under Member result table");

                //3.Click on view icon to see member information page
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("User should get landed on Member Information page");

                //4.Click on Admin Update tab
                Admin.Click_Tab_AdminUpdates();
                Logger.WriteDebugMessage("Admin Update grid should get displayed");

                //5.Search for Auto downgraded member level under Admin Upgrade log  
                Admin.AdminUpdates_Text_Filter("Auto");
                VerifyTextOnPage("No matching records found");
                Logger.WriteDebugMessage(
                    "Auto downgraded member level record should NOT get reflected under Admin Update log");
            }
        }

        public static void TC_151539()
        {
            if (TestCaseId == Constants.TC_151539)
            {
                Users data = new Users();
                //Pre-requisites:
                //1.Log into Admin.              
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //1.On Member Search page, search for member                
                Queries.GetAutoAddedUsers(data);
                string email = data.eMail;
                Admin.EnterEmail(email);
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Member should get displayed under Member result table");

                //3.Click on view icon to see member information page
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("User should get landed on Member Information page");

                //4.Click on Admin Update tab
                Admin.Click_Tab_AdminUpdates();
                Logger.WriteDebugMessage("Admin Update grid should get displayed");

                //5.Search for Auto added stay under Admin Update log    
                if (ProjectName.Equals("ALH"))
                {
                    VerifyTextOnPage("No data available in table");
                }
                else
                {
                    VerifyTextOnPage("No member data available");
                }

                Logger.WriteDebugMessage("Auto added stay should NOT get reflected under Admin Update log");
            }
        }

        public static void TC_151542()
        {
            if (TestCaseId == Constants.TC_151542)
            {
                Users data = new Users();
                //1.Log into Admin.              
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //2.On Member Search page, search for member
                Queries.GetMemberLevel(data, 1);
                string level1 = data.MembershipLevel;
                Queries.GetMemberLevel(data, 2);
                string level2 = data.MembershipLevel;
                if (ProjectName.Equals("Origami"))
                {
                    level1 = "ELITE";
                    level2 = "MEMBER";
                }

                Queries.Return_AutoUpgradeDowngrade_Status(data, "Auto", level1, level2);
                string email = data.MemberEmail;
                Admin.EnterEmail(email);
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Member should get displayed under Member result table");

                //3.Click on view icon to see member information page
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("User should get landed on Member Information page");

                //4.Click on Admin Update tab
                Admin.Click_Tab_AdminUpdates();
                Logger.WriteDebugMessage("Admin Update grid should get displayed");

                //5.Verify all the columns present in Admin Update tab.User is able to see below columns:
                Admin.AdminUpdates_Text_Filter(TestData.CommonAdminEmail);
                VerifyTextOnPage(TestData.TC_151542_Action);
                VerifyTextOnPage(TestData.TC_151542_By);
                VerifyTextOnPage(TestData.TC_151542_LogDate);
                VerifyTextOnPage(TestData.TC_151542_View);
                Logger.WriteDebugMessage(
                    "In the new tab display a grid with the following columns:Log Date, Action, By, View");

                //6.Click on View icon
                Admin.Click_AdminUpdates_Icon_View1();
                VerifyTextOnPage(TestData.TC_151542_ChangeType);
                VerifyTextOnPage(TestData.TC_151542_OriginalData);
                VerifyTextOnPage(TestData.TC_151542_NewData);
                Logger.WriteDebugMessage("System should display a modal window with details for the specific action");
            }
        }
        public static void TC_151547()
        {
            if (TestCaseId == Constants.TC_151547)
            {
                Users data = new Users();
                //Pre-requisites:
                //1.User has logged in to Guest Loyalty Admin  with valid credentials
                //2.User should be on Member Information  >> Admin Update Tab
                //3.More than 30 Entries should be present.                              
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                Queries.ReturnEmail_WithMaximumAdminUpdates(data);

                Admin.EnterEmail(data.MemberEmail);
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Member should get displayed under Member result table");
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("User should get landed on Member Information page");
                Admin.Click_Tab_AdminUpdates();
                Logger.WriteDebugMessage("There are at least 30 records in grid.");

                //1.Verify search by entering first 3 alphabets/last 3 alphabets in 'Search' column.
                if (!ProjectName.Equals("Sarova"))
                {
                    Queries.GetAdminUpdatesData(data);
                    string setby = data.SetBy.Substring(0, 3);
                    Admin.AdminUpdates_Text_Filter(setby);
                    Logger.WriteDebugMessage("Page should get searched by first 3 alphabets");
                }

                //2.Verify search by entering invalid data which is not present in Admin Update tab
                Admin.AdminUpdates_Text_clear();
                Admin.AdminUpdates_Text_Filter(TestData.TC_151547_NoDataMatch);
                VerifyTextOnPage("No matching records found");
                Logger.WriteDebugMessage("No record should be displayed for invalid email address");
                Admin.AdminUpdates_Text_clear();

                Admin.AdminUpdates_Text_Filter("@");
                Logger.WriteDebugMessage("User should be able to search by entering @ Special characters.");
                Admin.AdminUpdates_Text_clear();
                Admin.AdminUpdates_Text_Filter("/");
                Logger.WriteDebugMessage("User should be able to search by entering / Special characters.");
                Admin.AdminUpdates_Text_clear();
                Admin.AdminUpdates_Text_Filter("-");
                Admin.AdminUpdates_Text_clear();
                Logger.WriteDebugMessage("User should be able to search by entering _ Special characters.");

                //4.Verify search with only numeric characters.
                Admin.AdminUpdates_Text_Filter(TestData.TC_151547_NumbericData);
                Logger.WriteDebugMessage("User should be able to search by numeric characters.");
                Admin.AdminUpdates_Text_clear();

                //5.Verify Search message for no matching data
                Admin.AdminUpdates_Text_Filter(TestData.TC_151547_NoDataMatch);
                VerifyTextOnPage("No matching records found");
                Logger.WriteDebugMessage("No Matching Records found' message should be displayed in case of no matching data");
                Admin.AdminUpdates_Text_clear();

                //6.Verify message if matching data found as per Search
                if (!ProjectName.Equals("Sarova"))
                {
                    Admin.AdminUpdates_Text_Filter(data.SetBy);
                    Logger.WriteDebugMessage(
                        "Data should be displayed as per applied filter ​and the bottom message displays ");
                }

            }
        }

        public static void TC_151555()
        {
            if (TestCaseId == Constants.TC_151555)
            {
                //Pre - requisites:User has logged in to Guest Loyalty Admin with valid credentials
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //1.On Member Search page, search  for PMS user having stay   
                Admin.SelectMemberStatus("Active");
                AddDelay(2500);
                Admin.EnterEmail(TestData.TC_151555_Email);
                Admin.Click_Button_MemberSearch();
                AddDelay(2500);
                Logger.WriteDebugMessage("Member should get displayed under Member result table");

                //2.Click on view icon to see member information page
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("User should get landed on Member Information page");

                //3.Click on Member Transaction Tab
                AddDelay(2500);
                Admin.Click_Tab_MemberTransactions();
                Logger.WriteDebugMessage("User to land on Member transaction grid.");

                //4.Click on Add Transaction button
                Admin.Click_Button_AddTransaction();
                Logger.WriteDebugMessage("Add Transaction pop - up should get displayed");

                //5.Enter all mandatory field and click on save  
                string TransactionReason = Admin.TransactionReason(ProjectName);
                Admin.AddTransaction(TransactionReason, TestData.TC_151555_Points, TestData.TC_151555_Expiration,
                    TestData.TC_151555_Comments, TestData.TC_151555_InternalComments, ProjectName);
                Admin.Click_Button_Save();
                VerifyTextOnPage("Save Successfull");
                AddDelay(15000);
                Logger.WriteDebugMessage(" Member transaction page should be displayed");

                //6.Go to the Admin Update tab and search for any duplicate records.
                Admin.Click_Tab_AdminUpdates();
                AddDelay(5000);
                Admin.AdminUpdates_Text_Filter("Add Transaction");
                Admin.Click_AdminUpdates_Icon_View1();
                VerifyTextOnPage("Add Transaction");
                Logger.WriteDebugMessage("User should not be able to view duplicate records.");
            }
        }
        */
        #endregion TP_156796
    }
}
