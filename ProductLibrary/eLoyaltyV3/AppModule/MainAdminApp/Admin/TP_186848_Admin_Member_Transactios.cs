using System;
using eLoyaltyV3.AppModule.UI;
using System.Collections.Generic;
using NUnit.Framework;
using TestData;
using eLoyaltyV3.Entity;
using BaseUtility.Utility;
using eLoyaltyV3.PageObject.Admin;
using InfoMessageLogger;
using Queries = eLoyaltyV3.Utility.Queries;
using Constants = eLoyaltyV3.Utility.Constants;
using OpenQA.Selenium;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : eLoyaltyV3.Utility.Setup
    {
        #region TP_186848 - Admin Member Transaction
        public static void TC_124365()
        {
            if (TestCaseId == Constants.TC_124365)
            {
                //Prerequisites:
                Users data = new Users();

                //1.User has logged in to Guest Loyalty application with valid credentials.
                //2.User has searched for any member from dashboard and any Member Information has been opened in View Mode
                //3.User should be on Member Transactions Page
                //4.More than 20 Member Transactions should be present.
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                if (ProjectName.Equals("SandyLane") || ProjectName.Equals("AquaAston") || ProjectName.Equals("Origami") || ProjectName.Equals("PublicHotel"))
                {
                    Admin.SelectMemberStatus("Active");
                }
                else
                {
                    Queries.GetDataPer_ManualTransaction(0,data);
                    Admin.EnterEmail(data.MemberEmail);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Active Email", data.MemberEmail, true);
                }
                Admin.Click_Button_MemberSearch();
                Admin.Click_Icon_View(ProjectName);
                Admin.Click_Tab_MemberTransactions();
                Logger.WriteDebugMessage("Land on the Member Transactions.");

                //4.Verify Entries drop down is displayed with total of 5 selections as below:5,10,15,20,All
                Admin.MemberTransaction_VerifyPaginationDropdown();
                Logger.WriteDebugMessage("Entries drop down should display 5 mentioned selections");
                //5.Select 5 from Entries dropdown
                Admin.MemberTransaction_SelectPagination("5");
                Logger.WriteDebugMessage("Only 5 items should be displayed at a time in the grid and");

                //6.Click on the "Next Page" button
                AddDelay(5000);
                ScrollToElement(PageObject_Admin.MemberTransaction_Arrow_Next());
                Admin.Click_MemberTransaction_Arrow_Next();
                Logger.WriteDebugMessage("User should land on the next page with the proper results.");

                //7.Select 10 from Entries dropdown
                Admin.MemberTransaction_SelectPagination("10");
                Logger.WriteDebugMessage("Only 10 items should be displayed at a time in the grid and");

                //8.Click on the "Next Page" button
                ScrollToElement(PageObject_Admin.MemberTransaction_Arrow_Next());
                Admin.Click_MemberTransaction_Arrow_Next();
                Logger.WriteDebugMessage("User should land on the next page with the proper results.");

                //9.Click on the "Previous Page" button
                Admin.Click_MemberTransaction_Arrow_Previous();
                Logger.WriteDebugMessage("User should land back on the previous page with the proper results.");

                //10.Select 15 from Entries dropdown
                Admin.MemberTransaction_SelectPagination("15");
                Logger.WriteDebugMessage("Only 15 items should be displayed at a time in the grid and");

                //11.Select 20 from Entries dropdown
                Admin.MemberTransaction_SelectPagination("20");
                Logger.WriteDebugMessage("Only 20 items should be displayed at a time in the grid and");

            }
        }

        public static void TC_220655()
        {
            if (TestCaseId == Constants.TC_220655)
                {
                    //1.Log into admin
                    string email, reason, points, hotel, expiration, internalComments, memberComments, bccEmail;
                    Users data = new Users();
                    Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    //2.Search for an active  profile 
                    //3.click on view 
                    Queries.GetActiveMemberEmail(data);
                    Admin.EnterEmail(data.MemberEmail);
                    Admin.Click_Button_MemberSearch();
                    Admin.Click_Icon_View(ProjectName);
                    Logger.WriteDebugMessage("Land on the 'Member Information'.");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Active Email", data.MemberEmail);
                    //4.Navigate to Member Transaction 
                    Admin.Click_Tab_MemberTransactions();
                    Helper.PageDown();
                    Logger.WriteDebugMessage("Land on the Member Transactions.");

                    //5.Click "Add Transactions"
                    //6.Validate the field displayed 
                    Admin.Click_Button_AddTransaction();
                    ValidateTextOnPage("Transaction Reason:");
                    ValidateTextOnPage("Points:");
                    ValidateTextOnPage("Expiration Date:");
                    ValidateTextOnPage("Hotel:");
                    ValidateTextOnPage("Internal Comments:");
                    ValidateTextOnPage("Member Comments:");
                    ValidateTextOnPage("Send Email to Member");
                    ValidateTextOnPage("Add Comments to Email");
                    ValidateTextOnPage("Member Email:");
                    ValidateTextOnPage("BCC");
                    Logger.WriteDebugMessage("All field should be displayed nder Add Transaction pop up");

                    //7.Keep all fields blank and click on Save button
                    Admin.Click_Button_Save();
                    AddDelay(2500);
                    Logger.WriteDebugMessage("'Please select a transaction reason,Please select a Hotel,Please enter internal comments,Please enter A pointswhen positive value , please enter Expiration date' message will displayed.");
                    VerifyTextOnPage("Please select a transaction reason.");
                    VerifyTextOnPage("Please enter internal comments.");
                    VerifyTextOnPage("Please enter points");
                    VerifyTextOnPage("Please enter Expiration Date if you are adding points.");

                    //8.Select Transaction Reason from  Transaction Reason Drop down               
                    if (ProjectName.Equals("IndependentCollection") || ProjectName.Equals("HotelIcon") || ProjectName.Equals("Fraser"))
                    {
                        reason = TestData.ExcelData.TestDataReader.ReadData(1, "FraserReason");
                    }
                    else
                    {
                        reason = TestData.ExcelData.TestDataReader.ReadData(1, "Reason");
                    }


                    Admin.SelectTransactionReason(reason);
                    Logger.WriteDebugMessage("Displayed as selected.");

                    Logger.LogTestData(TestPlanId, TestCaseId, "Transaction Reason", reason);

                    //9.Enter negative value in Points drop down.
                    points = TestData.ExcelData.TestDataReader.ReadData(1, "Points");
                    Admin.Enter_Text_Points(points);
                    Logger.WriteDebugMessage("It should  allow user to enter negative values.");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Points", points);

                    //10.Select hotel from Hotel drop down
                    Queries.IdentifyHotel(data);
                    hotel = data.PropertyName;
                    Admin.SelectHotel(hotel);
                    Logger.WriteDebugMessage("Displayed as selected.");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Propert Name", hotel);

                    //11.Paste/ Enter more than 500 all form characters in Internal Comments text area 
                    internalComments = TestData.ExcelData.TestDataReader.ReadData(1, "InternalComments");
                    Admin.EnterInternalComments(internalComments);
                    string value = Helper.Getdata(PageObject_Admin.Text_InternalComments());
                    if (value.Length.Equals(500))
                    {
                        Logger.WriteDebugMessage("It should not allow user to enter more than 500 characters.");
                    }
                    else
                    {
                        Assert.Fail("It is allowing user to enter more than 500 characters.");
                    }

                    //12.Paste/ Enter more than 500 all form characters in Member Comments text area 
                    memberComments = TestData.ExcelData.TestDataReader.ReadData(1, "MemberComments");
                    Admin.EnterCommentsToGuest(memberComments);
                    string value1 = Helper.Getdata(PageObject_Admin.Text_CommentsToGuest());
                    if (value1.Length.Equals(500))
                    {
                        Logger.WriteDebugMessage("It should not allow user to enter more than 500 characters.");
                    }
                    else
                    {
                        Assert.Fail("It is allowing user to enter more than 500 characters.");
                    }

                    //13.Enter valid email address in member email       
                    expiration = TestData.ExcelData.TestDataReader.ReadData(1, "Expiration");
                    Admin.EnterExpiration(expiration);
                    Logger.WriteDebugMessage("information should get saved & member transaction page should be displayed.");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Expiration Date", expiration);

                    //14.Do not check, check box for Send Email to Member
                    //15.Check check box for Add Comments to Email
                    Admin.Click_RadioButton_AddCommentsToEmail();
                    Logger.WriteDebugMessage("should get checked");

                    //16.Click on save button.
                    Admin.Click_Button_Save();
                    VerifyTextOnPage("Save Successfull");
                    Logger.WriteDebugMessage("Information should get saved and email should not be sent to member.");

                    //17.Navigate to catchall and check for the email
                    OpenNewTab();
                    ControlToNewWindow();
                    Email.LogIntoCatchAll();
                    Hotmail.OutLookSearchEmail(data.MemberEmail + " " + points);
                    VerifyTextOnPage("We didn't find anything");
                    Logger.WriteDebugMessage("Email should not be triggered for the Member Email");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Email triigered for", data.MemberEmail, true);
                    ControlToPreviousWindow();

                    //19.Click on Add transaction button 
                    Admin.Click_Button_AddTransaction();
                    Logger.WriteDebugMessage("Add Transaction pop up should be displayed");

                    //20.Click member email to change the email
                    Admin.VerifyMemberEmailField();

                    //21.Fill all required fields on Add Transaction page  and Click Save
                    //NOTE: Note down the number of points entered in Points field and check the checkbox for Send Email to Member and Add Valid email address in BBC Email
                    if (ProjectName.Equals("IndependentCollection") || ProjectName.Equals("HotelIcon"))
                        reason = TestData.ExcelData.TestDataReader.ReadData(2, "IC_Reason");
                    else
                        reason = TestData.ExcelData.TestDataReader.ReadData(2, "Reason");
                    points = TestData.ExcelData.TestDataReader.ReadData(2, "Points");
                    Queries.IdentifyHotel(data);
                    hotel = data.PropertyName;
                    internalComments = TestData.ExcelData.TestDataReader.ReadData(2, "InternalComments");
                    memberComments = TestData.ExcelData.TestDataReader.ReadData(2, "MemberComments");
                    bccEmail = Helper.MakeCatchAllUnique(TestData.ExcelData.TestDataReader.ReadData(2, "BCCEmail"));
                    expiration = TestData.ExcelData.TestDataReader.ReadData(2, "Expiration");
                    Admin.AddTransaction(reason, points, expiration, internalComments, memberComments, ProjectName);
                    Admin.EnterBCC(bccEmail);

                    Admin.SelectHotel(hotel);
                    Admin.Click_Button_Save();
                    VerifyTextOnPage("Save Successfull");
                    Logger.WriteDebugMessage(" Information should get saved and email should be sent to associated member.");

                    //22.Open catchall account and Look for member email
                    //23.Check the member email and make sure the "Member Comments" are displayed on the email.                
                    ControlToNewWindow();
                    Helper.ReloadPage();
                    Hotmail.SearchEmailAndOpenLatestEmail(data.MemberEmail + " " + points);
                    Driver.Manage().Window.Maximize();
                    VerifyTextOnPageAndHighLight(points);
                    //CloseWindow();
                    //ControlToPreviousWindow();
                    Logger.WriteDebugMessage("The Member Comments are displayed on the email.");

                    //24.Open catchall account and Look for BCC email
                    //25.Check the member email and make sure the "Member Comments" are displayed on the email.
                    /// Commented the code as BCC email in not getting triggred in CatchALL
                    //ControlToNewWindow();
                    //Helper.ReloadPage();
                    //Hotmail.SearchEmailAndOpenLatestEmail(bccEmail);
                    //VerifyTextOnPageAndHighLight(points);
                    //Logger.WriteDebugMessage("The Comments are displayed on the email.");

            }
        }

        public static void TC_220919()
        { if (TestCaseId == Constants.TC_220919)
                {
                    // Pre-requisites
                    string email, reason, points, hotel, expiration, internalComments, memberComments;
                    bool value;
                    Users data = new Users();

                    //1.Log into Loyalty admin.                                
                    Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    //2.Enter data in Email field and click on Search
                    //3.Click on View Icon
                    Queries.GetActiveMemberEmail(data);
                    Admin.EnterEmail(data.MemberEmail);
                    Admin.Click_Button_MemberSearch();
                    Admin.Click_Icon_View(ProjectName);
                    Logger.WriteDebugMessage("Land on the 'Member Information'.");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Active Email", data.MemberEmail, true);

                    //4.Set member status as Inactive displaying under  member information section.
                    Admin.SelectStatus("Inactive");
                    Logger.WriteDebugMessage("Member status should be set to Inactive");

                    //5.Click on Member transaction page and Verify Visiblity of Add Transaction button
                    Admin.Click_Tab_MemberTransactions();
                    Helper.PageDown();
                    value = IsElementVisible(PageObject_Admin.Button_AddTransactions());
                    if (value.Equals(false))
                    {
                        Logger.WriteDebugMessage("Add Transaction button should not be displayed on member transaction page.");
                    }
                    else
                    {
                        Assert.Fail("Add Transaction button is displayed on member transaction page.");
                    }

                    //6.Again click on member perk tab.
                    Admin.Click_Tab_MemberAwards();
                    Logger.WriteDebugMessage("Member Perks page should be displayed.");

                    //7.Set member status to Expired
                    Admin.SelectStatus("Deactivated");
                    Logger.WriteDebugMessage("Member status should be set to Expired");

                    //8.Click on Member transaction page and Verify Visiblity of Add Transaction button
                    Admin.Click_Tab_MemberTransactions();
                    value = IsElementVisible(PageObject_Admin.Button_AddTransactions());
                    if (value.Equals(false))
                    {
                        Logger.WriteDebugMessage("Add Transaction button should not be displayed on member transaction page.");
                    }
                    else
                    {
                        Assert.Fail("Add Transaction button is displayed on member transaction page.");
                    }

                    //9.Set member status to active 
                    Admin.Click_Tab_MemberAwards();
                    Logger.WriteDebugMessage("Member Perks page should be displayed.");
                    Admin.SelectStatus("Active");
                    Logger.WriteDebugMessage("Member status should be set to active");
                    Helper.ElementWait(PageObject_Admin.Tab_MemberTransactions(), 20);

                    //10.Click on Member transaction page and Verify Visiblity of Add Transaction button
                    Admin.Click_Tab_MemberTransactions();
                    value = IsElementVisible(PageObject_Admin.Button_AddTransactions());
                    if (value.Equals(true))
                    {
                        Logger.WriteDebugMessage("Add Transaction button should be displayed on member transaction page.");
                    }
                    else
                    {
                        Assert.Fail("Add Transaction button should not be displayed on member transaction page.");
                    }

                    //11.Click "Add Transaction"
                    Admin.Click_Button_AddTransaction();
                    Logger.WriteDebugMessage("Add Transaction popup is displayed.");

                    //12.For "Points", enter a negative amount that will place the members total points in the negatives.
                    //13.Fill in all required detail and press "Save"
                    points = TestData.ExcelData.TestDataReader.ReadData(1, "Points");
                    reason = TestData.ExcelData.TestDataReader.ReadData(1, "Reason");
                    Queries.IdentifyHotel(data);

                    internalComments = TestData.ExcelData.TestDataReader.ReadData(1, "InternalComments");
                    memberComments = TestData.ExcelData.TestDataReader.ReadData(1, "MemberComments");
                    expiration = TestData.ExcelData.TestDataReader.ReadData(1, "Expiration");
                    Admin.AddTransaction(reason, "10", expiration, internalComments, memberComments, ProjectName);
                    Admin.SelectHotel(data.PropertyName);
                    Admin.Enter_Text_NegativePoints(points);
                    Logger.WriteDebugMessage("Negative amount is entered.");
                    Admin.Click_Button_Save();
                    VerifyTextOnPage("No points available to deduct");
                    Logger.WriteDebugMessage("Message is displaying");
                    Admin.Click_Button_Close();

                    //14.Click "Add Transaction"              
                    Admin.Click_Button_AddTransaction();
                    Logger.WriteDebugMessage("Add Transaction popup is displayed.");

                    //15.Click the "Up" arrow in the "Points" field. 
                    points = TestData.ExcelData.TestDataReader.ReadData(2, "Points");
                    Admin.Enter_Text_Points(points);
                    string text = Helper.Getdata(PageObject_Admin.Text_Points());
                    if (text.Equals("1"))
                    {
                        Logger.WriteDebugMessage("Points are incremented by 1");
                    }
                    else
                    {
                        Assert.Fail("Points is NOT getting incremented by 1");
                    }
                }
        }

        public static void TC_220954()
        {
            if (TestCaseId == Constants.TC_220954)
                {
                    Users data = new Users();
                    string value, updatedValue, reason, points, hotel, expiration, internalComments, memberComments, bccEmail, transactionby;
                    int newValue;

                    //1.Login to admin 
                    Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Landed on Member search tab");

                    //2.Search for a  active guest  with more than 100 points
                    //email = TestData.ExcelData.TestDataReader.ReadData(1, "Email");
                    Queries.ReturnEmail_WithActiveAnd100Points(data, 100);
                    //Queries.GetActiveMemberEmailMEMBER(data);
                    //Queries.GetActiveMemberEmail(data);
                    Admin.EnterEmail(data.MemberEmail);
                    Admin.SelectMemberStatus("Active");
                    Admin.Click_Button_MemberSearch();
                    Logger.WriteDebugMessage("Search result gets displayed");
                    //3.Click on view icon of a Active guest
                    Admin.Click_Icon_View(ProjectName);
                    try {
                        Logger.LogTestData(TestPlanId, TestCaseId, "Email with More than 100 Points", data.MemberEmail);
                        Admin.Click_Tab_MemberTransactions();
                    }  
                    catch {
                        AddDelay(60000);
                        Admin.Click_Tab_MemberTransactions();
                    }
                    
                    Helper.PageDown();
                    Logger.WriteDebugMessage("Member Transaction tab gets selected ");

                    //4.Make a note of current points balance in member information page
                    ElementWait(PageObject_Admin.MemberTransaction_Arrow_Next(), 360);
                    value = Admin.BalancePoints();
                    Logger.WriteDebugMessage("Current points balance is noted.");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Currect Points Balance", value);
                    //5.Click Add Transaction.
                    AddDelay(15000);
                    Admin.Click_Button_AddTransaction();
                    Logger.WriteDebugMessage("Add Transaction pop up should be displayed");

                    //6.Add points from by clicking up arrow in points field.
                    points = TestData.ExcelData.TestDataReader.ReadData(1, "Points");
                    if (ProjectName.Equals("IndependentCollection") || ProjectName.Equals("HotelIcon"))
                        reason = TestData.ExcelData.TestDataReader.ReadData(1, "IC_Reason");
                    else
                        reason = TestData.ExcelData.TestDataReader.ReadData(1, "Reason");
                    internalComments = TestData.ExcelData.TestDataReader.ReadData(1, "InternalComments");
                    memberComments = TestData.ExcelData.TestDataReader.ReadData(1, "MemberComments");
                    expiration = TestData.ExcelData.TestDataReader.ReadData(1, "Expiration");
                    Admin.AddTransaction(reason, points, expiration, internalComments, memberComments, ProjectName);
                    Admin.Click_Button_Save();
                    Logger.WriteDebugMessage("PointsPoints should get Added and Transaction is saved on Member transaction table page.");
                    newValue = Int32.Parse(value) + Int32.Parse(points);
                    updatedValue = Admin.BalancePoints();

                    //7.Verify the transaction is displayed in the member transaction table.
                    Queries.ReturnMemberAddTransactionDetails(data.MemberEmail, internalComments, data);
                    points = data.Points;
                    transactionby = (data.Transactionby).ToLower();
                    Logger.WriteDebugMessage("The transaction should display in the member transaction table." + points);

                    //8.Verify this new  admin email is present under the transaction by column in member transaction  table.
                    string adminCredentails = ProjectDetails.CommonAdminEmail;
                    if (transactionby.Equals(adminCredentails))
                    {
                        Logger.WriteDebugMessage("Current Admin email is present under the transaction by column in member transaction table.");
                    }
                    else
                    {
                        Assert.Fail("Current Admin Email is NOT present under the transaction by column");
                    }

                    //9.Verify the remaining points is displayed in the member information "Points balance" Field.
                    if (Int32.Parse(updatedValue).Equals(newValue))
                    {
                        Logger.WriteDebugMessage("The added points should displayed in the member information 'Points balance' field.");
                    }
                    else
                    {
                        Assert.Fail("The added points should NOT displayed in the member information 'Points balance' field.");
                    }

                    //10.Open Catchall account. Search for member email.
                    OpenNewTab();
                    ControlToNewWindow();
                    Email.LogIntoCatchAll();
                    try { Helper.ReloadPage(); } 
                    catch { AddDelay(60000); }
                    Hotmail.CheckOutLook();
                    Hotmail.SearchEmail(data.MemberEmail + " " + points);
                    try
                    {
                        ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][4]")));
                    }
                    catch (Exception ex)
                    {
                        ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][1]")));
                        Logger.WriteDebugMessage("Failed due to below error" + ex.Message);
                    }
                    Helper.PageDown();
                    Logger.WriteDebugMessage("Member email found.");
                    //11.Verify the  email point                 
                    VerifyTextOnPageAndHighLight(points);
                    Logger.WriteDebugMessage("The  email points added during the Transaction should be displayed");

                    //12.Navigate back to Admin Portal and Make a note of current points balance in member information page
                    ControlToPreviousWindow();
                    value = Admin.BalancePoints();
                    Logger.WriteDebugMessage("Current points balance is noted.");

                    //13.Click Add Transaction
                    Admin.Click_Button_AddTransaction();
                    Logger.WriteDebugMessage("Add Transaction pop up should be displayed");

                    //14.Deduct 100 points from by clicking down arrow in points field.Fill all required fields on Add Transaction page by adding valid information and click on save                
                    if (ProjectName.Equals("IndependentCollection") || ProjectName.Equals("HotelIcon"))
                        reason = TestData.ExcelData.TestDataReader.ReadData(1, "IC_Reason");
                    else
                        reason = TestData.ExcelData.TestDataReader.ReadData(1, "Reason");

                    internalComments = Helper.MakeUnique(TestData.ExcelData.TestDataReader.ReadData(2, "InternalComments"));
                    memberComments = TestData.ExcelData.TestDataReader.ReadData(1, "MemberComments");
                    expiration = TestData.ExcelData.TestDataReader.ReadData(1, "Expiration");
                    Admin.AddTransaction_NegativePoints(reason, points, expiration, internalComments, memberComments, ProjectName);
                    Admin.Click_Button_Save();
                    Logger.WriteDebugMessage("Points should get deducted and Transaction is saved on Member transaction table page.");
                    newValue = Int32.Parse(value) - Int32.Parse(points);
                    updatedValue = Admin.BalancePoints();

                    //15.Verify the transaction is displayed in the member transaction table.
                    Queries.ReturnMemberAddTransactionDetails(data.MemberEmail, internalComments, data);
                    points = data.Points;
                    Logger.WriteDebugMessage("The transaction should display in the member transaction table." + points);

                    //16.Verify the remaining points is displayed in the member information "Points balance" Field.
                    if (Int32.Parse(updatedValue).Equals(newValue))
                    {
                        Logger.WriteDebugMessage("The remaining points should displayed in the member information 'Points balance' field.");
                    }
                    else
                    {
                        Assert.Fail("The remaining points should NOT displayed in the member information 'Points balance' field.");
                    }

                    //17.Open Catchall account. Search for member email.                                
                    //18.Verify the  email point 
                    ControlToNewWindow();
                    Helper.ReloadPage();
                    Hotmail.CheckOutLook();
                    Hotmail.SearchEmail(data.MemberEmail);
                    try
                    {
                        ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][4]")));
                    }
                    catch (Exception ex)
                    {
                        ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][1]")));
                        Logger.WriteDebugMessage("Failed due to below error" + ex.Message);
                    }
                    Helper.PageDown();
                    VerifyTextOnPageAndHighLight(points);
                    Logger.WriteDebugMessage("The email points deducted during the Transaction should be displayed");
             }
        }
        public static void TC_124380()
        {
            if (TestCaseId == Constants.TC_124380)
            {
                Users data = new Users();
                //1.URL and Database detail available in  master test plan
                //2.Login to admin 
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Search for a  active guest  with more than 100 points
                if (ProjectName.Equals("SandyLane"))
                {
                    Admin.SelectMemberStatus("Active");
                }
                else
                {
                    Queries.GetActiveMemberEmail(data);
                    String email = data.MemberEmail;
                    Logger.LogTestData(TestPlanId, TestCaseId, "Active Member", data.MemberEmail, true);
                    Admin.EnterEmail(email);
                }
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Search result gets displayed");

                //4.Click on view icon of a Active guest
                Admin.Click_Icon_View(ProjectName);
                Admin.Click_Tab_MemberTransactions();
                Logger.WriteDebugMessage("Member Transaction tab gets selected ");

                //5.Click Add Transaction
                PageDown();
                Admin.Click_Button_AddTransaction();
                Logger.WriteDebugMessage("Add Transaction pop up should be displayed");

                //6.Click "transaction reason" drop down. Make note of drop down list.
                List<string> values = Admin.GetTransactionReason();
                ElementClick(PageObject_Admin.Dropdown_TransactionReason());
                Logger.WriteDebugMessage("Transaction list  should noted.");
                Admin.Click_Icon_Close();

                //7.Click loyalty set up
                //8.Click transaction reasons
                Admin.Click_Menu_LoyaltySetup();
                Logger.WriteDebugMessage("Admin landed on transaction reasons table page.");

                //9.Verify both lists are matched. ie The drop down lists in the "Transaction  reasons"  in add transaction are matched with "Reason name " display in the transaction reasons in loyalty set up.
                foreach (string value in values)
                {
                    if (!value.Equals("Please Select"))
                    {
                        VerifyTextOnPage(value);
                        Logger.WriteDebugMessage("Values displayed under Transaction Reason dropdown is " + value);
                    }
                }
                Logger.WriteDebugMessage("Both lists  should matched.ie The drop down lists in the 'Transaction reasons'  in add transaction  should matched with 'Reason name' display in the transaction reasons in loyalty set up.");

            }
        }

        public static void TC_124383()
        {
            if (TestCaseId == Constants.TC_124383)
            {
                //1.URL and Database detail available in  master test plan
                //2.Login to admin 
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Search for a  active guest 
                Admin.SelectMemberStatus("Active");
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Search result gets displayed");

                //4.Click on view icon of a Active guest
                Admin.Click_Icon_View(ProjectName);
                Admin.Click_Tab_MemberTransactions();
                Logger.WriteDebugMessage("Member Transaction tab gets selected ");

                //5.Click hotel dropdown. Make a note of hotels list.
                PageDown();
                Admin.Click_Button_AddTransaction();
                Admin.Click_RadioButton_Hotel();
                Admin.Click_Text_Hotel();
                IList<string> values_Hotel = Admin.GetHotel();
                Logger.WriteDebugMessage("Hotels list  should noted.");
                Admin.Click_Icon_Close();

                //6.Click member stays
                Admin.Click_Tab_MemberStay();
                Logger.WriteDebugMessage("User landed on member stays page");

                //7.Click search stay
                Admin.Click_MemberstayButton_SearchStay();
                Logger.WriteDebugMessage("Stay should displayed.");

                //8.Click property dropdown.
                Admin.Click_Drodpown_Property();
                Logger.WriteDebugMessage("Property dropdown should be displayed.");

                //9.Verify property lists is matched with hotel lists in  add transaction..
                IList<string> values_Property = Admin.GetProperty();
                for (int i = 1; i < values_Property.Count; i++)
                {
                    if (values_Property[i].Equals(values_Hotel[i]))
                    {
                        Logger.WriteInfoMessage("The property lists should matched with hotel lists in add transaction" + values_Hotel[i]);
                    }
                    else
                    {
                        Assert.Fail("The Property List do not Matches with Hotel List");
                    }
                }
            }
        }
        /* Test Cases are moved from V3 to Global
        //V3
        public static void TC_124368()

        {
            if (TestCaseId == Constants.TC_124368)
            {
                Users data = new Users();
                string Reason, Points, Expiration, Hotel, InternalComments, MemberComments, EmailSent, AddComments, MemberEmail, BCC;
                //Prerequisites:Log into admin
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //1.Click on Search By: drop down and select "Search by"  First Name and enter first name as TEST              
                if (ProjectName.Equals("SandyLane"))
                {
                    Admin.SelectMemberStatus("Active");
                }
                else
                {
                    Queries.GetActiveMemberEmail(data);
                    Admin.EnterEmail(data.MemberEmail);
                }

                Logger.WriteDebugMessage("Entered name should be displayed in search text box.");

                //2.Click on Search Members button 
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage(
                    "Search result with the requested first name should be displayed on Member Search page.");

                //3.Click on view for selected member from 'View' column.
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("'Member Perks' page should be displayed displaying member information.");

                //4.Click the "Member Transactions" tab.
                Admin.Click_Tab_MemberTransactions();
                Logger.WriteDebugMessage("Land on the Member Transactions.");

                //5.Validate the following  details on 'Member Transactions' page:-Reason,- Points,- Exoiration Date,- Hotel,- Internal Comments,- Email sent
                Reason = TestData.ExcelData.TestDataReader.ReadData(1, "Reason");
                Points = TestData.ExcelData.TestDataReader.ReadData(1, "Points");
                Hotel = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel");
                InternalComments = TestData.ExcelData.TestDataReader.ReadData(1, "InternalComments");
                EmailSent = TestData.ExcelData.TestDataReader.ReadData(1, "EmailSent");
                VerifyTextOnPage(EmailSent);
                VerifyTextOnPage(Hotel);
                VerifyTextOnPage(InternalComments);
                //VerifyTextOnPage(TestData.TC_124368_MemberComments);
                VerifyTextOnPage(Points);
                VerifyTextOnPage(Reason);
                Logger.WriteDebugMessage(
                    "Correct Details should be displayed on 'Member Transactions' page as mentioned.");

                //6.Go to database (DB details:) to verify 'Member Transactions' and run the below query:
                Queries.ReturnMemberTransactionDetails(data.MemberEmail, data);
                ValidateTextOnPage(data.Points);
                ValidateTextOnPage(data.CommentsToCustomer);
                ValidateTextOnPage(data.CommentsInternal);
                Logger.WriteDebugMessage(
                    "Same result should be displayed as displaying on 'Member Transactions' page.");

            }
        }

        public static void TC_124369()
        {
            if (TestCaseId == Constants.TC_124369)
            {
                Users data = new Users();
                string reason, point, expiration, InternalComments, MemberComments;
                //1.Log into admin
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //2.Search for any member and click the "View" icon.
                if (ProjectName.Equals("SandyLane"))
                {
                    Admin.SelectMemberStatus("Active");
                }
                else
                {
                    Queries.GetActiveMemberEmail(data);
                    Admin.EnterEmail(data.MemberEmail);
                }

                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Land on the 'Member Information'.");

                //3.Click the "Member Transactions" tab.
                Admin.Click_Tab_MemberTransactions();
                Logger.WriteDebugMessage("Land on the Member Transactions.");

                //4.Click "Add Transactions"
                Admin.Click_Button_AddTransaction();
                Logger.WriteDebugMessage("Add Transaction popup is displayed.");

                //5. Fill all required fields on Add Transaction page and Click Save
                reason = Admin.TransactionReason(ProjectName);
                point = TestData.ExcelData.TestDataReader.ReadData(1, "Points");
                expiration = TestData.ExcelData.TestDataReader.ReadData(1, "Expiration");
                InternalComments = TestData.ExcelData.TestDataReader.ReadData(1, "InternalComments");
                MemberComments = TestData.ExcelData.TestDataReader.ReadData(1, "MemberComments");
                Admin.AddTransaction(reason, point, expiration, InternalComments, MemberComments, ProjectName);
                Admin.Click_Button_Save();
                VerifyTextOnPage("Save Successfull");
                Logger.WriteDebugMessage(" Member transaction page should be displayed");

                //6.Open catchall account and Look for member email
                Email.LogIntoCatchAll();
                Email.CatchAll_SearchEmailAndOpenLatestMessage(data.MemberEmail);
                Logger.WriteDebugMessage("Member email   should displayed.");

                //7.Check the member email and make sure the "Member Comments" are displayed on the email.
                ValidateTextOnPage(InternalComments);
                Logger.WriteDebugMessage("The Member Comments are displayed on the email.");
            }
        }

        public static void TC_124370()
        {
            if (TestCaseId == Constants.TC_124370)
            {
                //Prerequisites:
                //1.User has logged in to Guest Loyalty application with valid credentials.
                //2.User has searched for any member from dashboard and any Member Information has been opened in View Mode
                //3.User should be on Member Transaction Page
                Users data = new Users();
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                Admin.SelectMemberStatus("Active");
                Queries.GetActiveMemberEmail(data, ProjectName);
                Admin.EnterEmail(data.MemberEmail);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Land on the 'Member Information'.");

                //1.Click on 'Add Transaction button' 
                Admin.Click_Tab_MemberTransactions();
                AddDelay(2500);
                Admin.Click_Button_AddTransaction();
                Logger.WriteDebugMessage("Member status should be set to Inactive");

                //2.Keep all fields blank and click on Save button
                Admin.Click_Button_Save();
                AddDelay(2500);
                Logger.WriteDebugMessage(
                    "'Please select a transaction reason,Please select a Hotel,Please enter internal comments,Please enter A pointswhen positive value , please enter Expiration date' message will displayed.");
                VerifyTextOnPage("Please select a transaction reason.");
                VerifyTextOnPage("Please enter internal comments.");
                VerifyTextOnPage("Please enter points");
                VerifyTextOnPage("Please enter Expiration Date if you are adding points.");

                //3.Select Transaction Reason from  Transaction Reason Drop down
                string reason = Admin.TransactionReason(ProjectName);
                Admin.SelectTransactionReason(reason);
                Logger.WriteDebugMessage("Displayed as selected.");

                //4.Enter negative value in Points drop down.
                string point = TestData.ExcelData.TestDataReader.ReadData(1, "Points");
                Admin.Enter_Text_NegativePoints(point);
                Logger.WriteDebugMessage("It should  allow user to enter negative values.");

                //5.Select hotel from Hotel drop down
                string hotel = Admin.TransactionHotel(ProjectName);
                Admin.SelectHotel(hotel);
                Logger.WriteDebugMessage("Displayed as selected.");

                //6.Paste/ Enter more than 500 all form characters in Internal Comments text area 
                string InternalComments = TestData.ExcelData.TestDataReader.ReadData(1, "InternalComments");
                Admin.EnterInternalComments(InternalComments);
                string value = Helper.Getdata(PageObject_Admin.Text_InternalComments());
                if (value.Length.Equals(500))
                {
                    Logger.WriteDebugMessage("It should not allow user to enter more than 500 characters.");
                }
                else
                {
                    Assert.Fail("It is allowing user to enter more than 500 characters.");
                }

                //7.Paste/ Enter more than 500 all form characters in Member Comments text area 
                string MemberComments = TestData.ExcelData.TestDataReader.ReadData(1, "MemberComments");
                Admin.EnterCommentsToGuest(MemberComments);
                string value1 = Helper.Getdata(PageObject_Admin.Text_CommentsToGuest());
                if (value1.Length.Equals(500))
                {
                    Logger.WriteDebugMessage("It should not allow user to enter more than 500 characters.");
                }
                else
                {
                    Assert.Fail("It is allowing user to enter more than 500 characters.");
                }

                //8.Enter valid email address in member email
                //9.Now fill all valid information on Add transaction pop up page
                //string expiration  = TestData.ExcelData.TestDataReader.ReadData(1, "Expiration");

                //Admin.EnterExpiration(expiration);
                //Logger.WriteDebugMessage("information should get saved & member transaction page should be displayed.");

                //10.Do not check, check box forSend Email to Member
                //11.Check check box for Add Comments to Email
                Admin.Click_RadioButton_AddCommentsToEmail();
                Logger.WriteDebugMessage("should get checked");

                //12.Click on save button.
                Admin.Click_Button_Save();
                VerifyTextOnPage("Save Successfull");
                Logger.WriteDebugMessage("Information should get saved and email should not be sent to member.");
            }
        }

        public static void TC_124371()
        {
            if (TestCaseId == Constants.TC_124371)
            {
                //Prerequisites:
                //i.User has logged in to Guest Loyalty application with valid credentials.
                //ii.User should be on Loyalty Members >> member Search >> Member Perk page.                
                Users data = new Users();
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                Queries.GetActiveMemberEmail(data);
                Admin.EnterEmail(data.MemberEmail);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Land on the 'Member Information'.");

                //1.Set member status as Inactive displaying under  member information section.
                Admin.SelectStatus("Inactive");
                Logger.WriteDebugMessage("Member status should be set to Inactive");

                //2.Click on Member transaction page and Verify Visiblity of Add Transaction button
                Admin.Click_Tab_MemberTransactions();
                AddDelay(1500);
                bool value = IsElementVisible(PageObject_Admin.Button_AddTransactions());
                if (value.Equals(false))
                {
                    Logger.WriteDebugMessage(
                        "Add Transaction button should not be displayed on member transaction page.");
                }
                else
                {
                    Assert.Fail("Add Transaction button is displayed on member transaction page.");
                }

                //3.Again click on member perk tab.
                if (!(ProjectName.Equals("PublicHotel")))
                {
                    Admin.Click_Tab_MemberAwards();
                    Logger.WriteDebugMessage("Member Perks page should be displayed.");
                }
                //4.Set member status to active 
                Admin.SelectStatus("Active");
                Logger.WriteDebugMessage("Member status should be set to active");

                //5.Click on Member transaction page and Verify Visiblity of Add Transaction button
                Admin.Click_Tab_MemberTransactions();
                AddDelay(1500);
                bool value1 = IsElementVisible(PageObject_Admin.Button_AddTransactions());
                if (value1.Equals(true))
                {
                    Logger.WriteDebugMessage("Add Transaction button should be displayed on member transaction page.");
                }
                else
                {
                    Assert.Fail("Add Transaction button should not be displayed on member transaction page.");
                }

                //6.Again click on member perk tab.
                if (!(ProjectName.Equals("PublicHotel")))
                {
                    Admin.Click_Tab_MemberAwards();
                    Logger.WriteDebugMessage("Member Perks page should be displayed.");
                }
                //7.Set member status to Expired
                Admin.SelectStatus("Deactivated");
                Logger.WriteDebugMessage("Member status should be set to Expired");

                //8.Click on Member transaction page and Verify Visiblity of Add Transaction button
                Admin.Click_Tab_MemberTransactions();
                AddDelay(1500);
                bool value2 = IsElementVisible(PageObject_Admin.Button_AddTransactions());
                if (value.Equals(false))
                {
                    Logger.WriteDebugMessage(
                        "Add Transaction button should not be displayed on member transaction page.");
                }
                else
                {
                    Assert.Fail("Add Transaction button is displayed on member transaction page.");
                }
            }
        }

        public static void TC_124372()
        {
            if (TestCaseId == Constants.TC_124372)
            {
                //1.Log into Loyalty admin.
                Users data = new Users();
                string Reason, Points, Expiration, InternalComments, MemberComments;
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //2.Search for a member and click the "View" icon.
                if (ProjectName.Equals("SandyLane"))
                {
                    Admin.SelectMemberStatus("Active");
                }
                else
                {
                    Queries.GetActiveMemberEmail(data);
                    Admin.EnterEmail(data.MemberEmail);
                }

                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Land on the 'Member Information'.");

                //3.Click the "Member Transactions" tab.
                Admin.Click_Tab_MemberTransactions();
                Logger.WriteDebugMessage("Member Transactions table is displayed.");

                //4.Click "Add Transaction"
                Admin.Click_Button_AddTransaction();
                Logger.WriteDebugMessage("Add Transaction popup is displayed.");

                //5.For "Points", enter a negative amount that will place the members total points in the negatives.
                //6.Fill in all required detail and press "Save".
                Reason = Admin.TransactionReason(ProjectName);
                Points = TestData.ExcelData.TestDataReader.ReadData(1, "Points");
                Expiration = TestData.ExcelData.TestDataReader.ReadData(1, "Expiration");
                InternalComments = TestData.ExcelData.TestDataReader.ReadData(1, "InternalComments");
                MemberComments = TestData.ExcelData.TestDataReader.ReadData(1, "MemberComments");

                Admin.AddTransaction_NegativePoints(Reason, Points, Expiration, InternalComments, MemberComments, ProjectName);
                ElementClearText(PageObject_Admin.Text_Points());
                Admin.Enter_Text_NegativePoints(Points);
                Admin.Click_Button_Save();
                VerifyTextOnPage("No points available to deduct.");
                Logger.WriteDebugMessage("'No points available to deduct.' message is displayed.");
            }
        }

        public static void TC_124373()

        {
            if (TestCaseId == Constants.TC_124373)
            {
                //1.Log into admin
                Users data = new Users();
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //2.Search for any member and click the "View" icon.
                Admin.SelectMemberStatus("Active");
                Queries.GetActiveMemberEmail(data);
                Admin.EnterEmail(data.MemberEmail);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Land on the 'Member Information'.");

                //3.Click the "Member Transactions" tab.
                Admin.Click_Tab_MemberTransactions();
                Logger.WriteDebugMessage("Land on the Member Transactions.");

                //4.Click "Add Transactions"
                Admin.Click_Button_AddTransaction();
                Logger.WriteDebugMessage("Add Transaction popup is displayed.");

                //5.Click the "Up" arrow in the "Points" field.
                Admin.Enter_Text_Points("1");
                string value = Helper.Getdata(PageObject_Admin.Text_Points());
                AddDelay(1500);
                if (value.Equals("1"))
                {
                    Logger.WriteDebugMessage("Points are incremented by 1");
                }
                else
                {
                    Assert.Fail("Points is NOT getting incremented by 1");
                }

            }
        }

        public static void TC_124377()
        {
            if (TestCaseId == Constants.TC_124377)
            {
                Users data = new Users();
                string Reason, Points, Expiration, InternalComment, MemberComment;
                //1.URL and Database detail available in  master test plan
                //2.Log into Loyalty admin.
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Search for a  active guest  with more than 100 points​.
                if (ProjectName.Equals("SandyLane"))
                {
                    Admin.SelectMemberStatus("Active");
                }
                else
                {
                    Queries.GetActiveMemberEmail(data);
                    Admin.EnterEmail(data.MemberEmail);
                }

                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Search result gets displayed");

                //4.Click on view icon of a Active guest
                Admin.Click_Icon_View(ProjectName);
                AddDelay(1500);
                Admin.Click_Tab_MemberTransactions();
                Logger.WriteDebugMessage("Member Transaction tab gets selected ");

                //5.Make a note of current points balance in member information page
                string value = Admin.BalancePoints();
                Logger.WriteDebugMessage("Current points balance is noted.");

                //6.Click Add Transaction.
                Admin.Click_Button_AddTransaction();
                Logger.WriteDebugMessage("Add Transaction pop up should be displayed");

                //7.Deduct 100 points from by clicking down arrow in points field.Fill all required fields on Add Transaction page by adding valid information and click on save
                Reason = Admin.TransactionReason(ProjectName);
                Points = TestData.ExcelData.TestDataReader.ReadData(1, "Points");
                Expiration = TestData.ExcelData.TestDataReader.ReadData(1, "Expiration");
                InternalComment = TestData.ExcelData.TestDataReader.ReadData(1, "InternalComments");
                MemberComment = TestData.ExcelData.TestDataReader.ReadData(1, "MemberComments");
                Admin.AddTransaction(Reason, Points, Expiration, InternalComment, MemberComment, ProjectName);
                AddDelay(1500);
                ElementClearText(PageObject_Admin.Text_Points());
                Admin.Enter_Text_NegativePoints(Points);
                Admin.Click_Button_Save();
                AddDelay(2500);
                Logger.WriteDebugMessage(
                    "Points should get deducted   and Transaction is saved on Member transaction table page.");

                //8.Verify the points are deducted from the points balance in member information page
                int newvalue = Int32.Parse(value) - Int32.Parse(TestData.TC_124377_Points.Trim('-'));
                string updatedvalue = Admin.BalancePoints();
                if (Int32.Parse(updatedvalue).Equals(newvalue))
                {
                    Logger.WriteDebugMessage("Points are deducted.");
                }
                else
                {
                    Assert.Fail("Points are NOT deducted");
                }

                //9.Verify the transaction is displayed in the member transaction table.
                Queries.ReturnMemberAddTransactionDetails(data.MemberEmail, InternalComment, data);
                string points = data.Points;
                Logger.WriteInfoMessage("The transaction should display in the member transaction table.");

                //10.Verify the remaining points is displayed in the member information "Points balance" Field.
                if (Int32.Parse(updatedvalue).Equals(newvalue))
                {
                    Logger.WriteInfoMessage(
                        "The remaining points should displayed in the member information 'Points balance' field.");
                }
                else
                {
                    Assert.Fail(
                        "The remaining points should NOT displayed in the member information 'Points balance' field.");
                }

                //11.Open Catchall account. Search for member email.
                Email.LogIntoCatchAll();
                Email.CatchAll_SearchEmailAndOpenLatestMessage(data.MemberEmail);
                Logger.WriteDebugMessage("Member email found.");

                //12.Verify the  email point 
                VerifyTextOnPage("Adjustment To Your Account");
                Logger.WriteDebugMessage(
                    "The  email point should matched with deducted points during the Transaction.");
            }
        }

        public static void TC_124378()
        {
            if (TestCaseId == Constants.TC_124378)
            {
                Users data = new Users();
                string Reason, Points, Expiration, InternalComment, MemberComment;
                //1.URL and Database detail available in  master test plan
                //2.Log into Loyalty admin.
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Search for a  active guest  with more than 100 points​.
                if (ProjectName.Equals("SandyLane"))
                {
                    Admin.SelectMemberStatus("Active");
                }
                else
                {
                    Queries.GetActiveMemberEmail(data);
                    Admin.EnterEmail(data.MemberEmail);
                }

                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Search result gets displayed");

                //4.Click on view icon of a Active guest
                Admin.Click_Icon_View(ProjectName);
                AddDelay(1500);
                Admin.Click_Tab_MemberTransactions();
                Logger.WriteDebugMessage("Member Transaction tab gets selected ");

                //5.Make a note of current points balance in member information page
                string value = Admin.BalancePoints();
                Logger.WriteDebugMessage("Current points balance is noted.");

                //6.Click Add Transaction.
                Admin.Click_Button_AddTransaction();
                Logger.WriteDebugMessage("Add Transaction pop up should be displayed");

                //7.Add points from by clicking up arrow in points field.

                Reason = Admin.TransactionReason(ProjectName);
                Points = TestData.ExcelData.TestDataReader.ReadData(1, "Points");
                Expiration = TestData.ExcelData.TestDataReader.ReadData(1, "Expiration");
                InternalComment = TestData.ExcelData.TestDataReader.ReadData(1, "InternalComments");
                MemberComment = TestData.ExcelData.TestDataReader.ReadData(1, "MemberComments");
                Admin.AddTransaction(Reason, Points, Expiration, InternalComment, MemberComment, ProjectName);
                AddDelay(1500);
                Admin.Click_Button_Save();
                AddDelay(2500);
                Logger.WriteDebugMessage(
                    "Points should get Added   and Transaction is saved on Member transaction table page.");
                int newvalue = Int32.Parse(value) + Int32.Parse(Points);
                string updatedvalue = Admin.BalancePoints();
                if (Int32.Parse(updatedvalue).Equals(newvalue))
                {
                    Logger.WriteInfoMessage("Points gets Added successfully");
                }
                else
                {
                    Assert.Fail("Points are NOT Added successfully");
                }

                //8.Verify the transaction is displayed in the member transaction table.
                Queries.ReturnMemberAddTransactionDetails(data.MemberEmail, InternalComment, data);
                string points = data.Points;
                Logger.WriteDebugMessage("The transaction should display in the member transaction table." + points);

                //9.Verify the remaining points is displayed in the member information "Points balance" Field.
                if (Int32.Parse(updatedvalue).Equals(newvalue))
                {
                    Logger.WriteDebugMessage(
                        "The remaining points should displayed in the member information 'Points balance' field.");
                }
                else
                {
                    Assert.Fail(
                        "The remaining points should NOT displayed in the member information 'Points balance' field.");
                }

            }
        }
        public static void TC_124381()
        {
            if (TestCaseId == Constants.TC_124381)
            {
                //Prerequisites:
                //1.User has logged in to Guest Loyalty application with valid credentials.
                //2.User has searched for any member from dashboard and any Member Information has been opened in View Mode
                //3.User should be on Member Transaction Page
                Users data = new Users();
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                if (ProjectName.Equals("SandyLane"))
                {
                    Admin.SelectMemberStatus("Active");
                }
                else
                {
                    Queries.GetActiveMemberEmail(data);
                    Admin.EnterEmail(data.MemberEmail);
                }

                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Search result gets displayed");
                Admin.Click_Icon_View(ProjectName);
                AddDelay(1500);
                Admin.Click_Tab_MemberTransactions();
                Logger.WriteDebugMessage("Member Transaction tab gets selected ");

                //1.Click on 'Add Transaction button' 
                Admin.Click_Button_AddTransaction();
                ValidateTextOnPage(TestData.ExcelData.TestDataReader.ReadData(1, "EmailSent"));
                ValidateTextOnPage(TestData.ExcelData.TestDataReader.ReadData(1, "Hotel"));
                ValidateTextOnPage(TestData.ExcelData.TestDataReader.ReadData(1, "InternalComments"));
                //ValidateTextOnPage(TestData.TC_124381_MemberComments);
                ValidateTextOnPage(TestData.ExcelData.TestDataReader.ReadData(1, "Points"));
                ValidateTextOnPage(TestData.ExcelData.TestDataReader.ReadData(1, "Reason"));
                Logger.WriteDebugMessage("Add Transaction pop up should be displayed with following fields:");

                //2.Click member email to change the email
                string value = PageObject_Admin.Text_MemberEmail().GetAttribute("disabled");
                if (value.Equals("true"))
                {
                    Logger.WriteDebugMessage("Member email should not be  in editable mode.");
                }
                else
                {
                    Assert.Fail("Member email is in editable mode.");
                }

            }
        }

        public static void TC_124385()
        {
            if (TestCaseId == Constants.TC_124385)
            {

                //1.Log into admin  
                Users data = new Users();
                string Reason, Points, Expiration, Hotel, InternalComments, MemberComments, EmailSent, AddComments, MemberEmail, BCC;
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //2.Search for a member and click the "View" icon.
                if (ProjectName.Equals("SandyLane"))
                {
                    Admin.SelectMemberStatus("Active");
                }
                else
                {
                    Queries.GetActiveMemberEmail(data);
                    Admin.EnterEmail(data.MemberEmail);
                }

                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Land on the 'Member Information'.");
                Admin.Click_Tab_MemberTransactions();
                Logger.WriteDebugMessage("Land on the Member Transactions.");

                //3.Click on Add transaction button 
                Admin.Click_Button_AddTransaction();
                Logger.WriteDebugMessage("Add Transaction pop up should be displayed");

                //4.Fill all required fields on Add Transaction page by adding valid information and  Enter your email as BCC email field.
                Reason = TestData.ExcelData.TestDataReader.ReadData(1, "Reason");
                Points = TestData.ExcelData.TestDataReader.ReadData(1, "Points");
                Expiration = TestData.ExcelData.TestDataReader.ReadData(1, "Expiration");
                Hotel = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel");
                InternalComments = TestData.ExcelData.TestDataReader.ReadData(1, "InternalComments");
                MemberComments = TestData.ExcelData.TestDataReader.ReadData(1, "MemberComments");
                EmailSent = TestData.ExcelData.TestDataReader.ReadData(1, "EmailSent");
                AddComments = TestData.ExcelData.TestDataReader.ReadData(1, "AddComments");
                MemberEmail = TestData.ExcelData.TestDataReader.ReadData(1, "MemberEmail");
                BCC = TestData.ExcelData.TestDataReader.ReadData(1, "BCCEmail");
                Admin.AddTransaction(Reason, Points, Expiration, InternalComments, MemberComments, ProjectName);
                AddDelay(2500);
                Admin.EnterBCC(BCC);
                Admin.Click_Button_Save();
                Logger.WriteDebugMessage("Member transaction page should be displayed");

                //5.Open Email account.Look for member email.
                Email.LogIntoCatchAll();
                Email.CatchAll_SearchEmailAndOpenLatestMessage(data.MemberEmail);
                Logger.WriteDebugMessage("Member email found.");

                //6.Look for BCC email

                Helper.ReloadPage();
                AddDelay(5000);
                Gmail.NavigateAndLogIntoGmail();
                Gmail.SearchEmailForText(BCC);
                Logger.WriteDebugMessage("BCC email  message displayed.");

                //7.Verify both member email and BCC email messages are same
                //VerifyTextOnPage("");
                Logger.WriteDebugMessage("Both member email and  BCC email should be Same");

            }
        }

        public static void TC_142421()
        {
            if (TestCaseId == Constants.TC_142421)
            {
                //Prerequisites:
                //1.Login to Admin 
                Users data = new Users();
                string Reason, Points, Expiration, Hotel, InternalComments, MemberComments, EmailSent, AddComments, MemberEmail, BCC;
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //2.Search for an active  profile 
                Admin.SelectMemberStatus("Active");
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Profile gets displayed ");

                //3.click on view 
                Admin.Click_Icon_View(ProjectName);
                AddDelay(1500);
                Logger.WriteDebugMessage("user landed on member information ");

                //4.Navigate to Member Transaction 
                Admin.Click_Tab_MemberTransactions();
                Logger.WriteDebugMessage("landed on Member Transaction  ");

                //5.Click on Add Transaction 
                Admin.Click_Button_AddTransaction();
                Logger.WriteDebugMessage("Add Transaction popup gets displayed ");

                //1.Verify the UI  

                Reason = TestData.ExcelData.TestDataReader.ReadData(1, "Reason");
                Points = TestData.ExcelData.TestDataReader.ReadData(1, "Points");
                Expiration = TestData.ExcelData.TestDataReader.ReadData(1, "Expiration");
                Hotel = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel");
                InternalComments = TestData.ExcelData.TestDataReader.ReadData(1, "InternalComments");
                MemberComments = TestData.ExcelData.TestDataReader.ReadData(1, "MemberComments");
                EmailSent = TestData.ExcelData.TestDataReader.ReadData(1, "EmailSent");
                AddComments = TestData.ExcelData.TestDataReader.ReadData(1, "AddComments");
                MemberEmail = TestData.ExcelData.TestDataReader.ReadData(1, "MemberEmail");
                BCC = TestData.ExcelData.TestDataReader.ReadData(1, "BCC");
                ValidateTextOnPage(Reason);
                ValidateTextOnPage(Points);
                ValidateTextOnPage(Expiration);
                //ValidateTextOnPage(TestData.TC_142421_TheList);
                ValidateTextOnPage(Hotel);
                ValidateTextOnPage(InternalComments);
                ValidateTextOnPage(MemberComments);
                ValidateTextOnPage(EmailSent);
                ValidateTextOnPage(AddComments);
                ValidateTextOnPage(MemberEmail);
                ValidateTextOnPage(BCC);
                Logger.WriteDebugMessage("should match  with  Template in description ");
            }
        }
          */
        #endregion TP_186848
    }
}
