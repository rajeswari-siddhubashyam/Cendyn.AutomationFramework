using System;
using eLoyaltyV3.AppModule.UI;
using NUnit.Framework;
using TestData;
using InfoMessageLogger;
using eLoyaltyV3.PageObject.Admin;
using eLoyaltyV3.Entity;
using BaseUtility.Utility;
using Queries = eLoyaltyV3.Utility.Queries;
using Constants = eLoyaltyV3.Utility.Constants;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : eLoyaltyV3.Utility.Setup
    {
        #region TP_166488 - Admin - Manual Merge                
        public static void TC_161117()
        {
            if (TestCaseId == Constants.TC_161117)
            {
                //Pre - condition : 
                string validationMessage1, validationMessage2, validationMessage3;

                //retrive data from test data file
                validationMessage1 = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage1");
                validationMessage2 = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage2");
                validationMessage3 = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage3");

                //1.Login to Database
                //2.Login to Admin with valid credentials
                //3.Target Profile is active                
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");


                //1.Click on Manual Merge Tab
                Admin.Click_Menu_ManualMerge();
                Logger.WriteDebugMessage("User Should get landed on Membership merge tab");

                //2.Search for Active member to merge                           
                Admin.ManualMerge_Text_Email("Test");
                Admin.Click_ManualMerge_Button_SearchMember();
                AddDelay(5000);
                Logger.WriteDebugMessage("Member should get displayed");

                //3.Select only 1 profile to merge 
                Admin.SelectMembersToMerge(1);
                Logger.WriteDebugMessage("Member should get selected");

                //4.Click on Member merged
                Admin.Click_ManualMerge_SubTab_ManualMerge();
                Admin.SelectMembersToMerge(1);
                Logger.WriteDebugMessage("User should not be able to click member merged.");

                //5.Select more then 6  profile to merge 
                Admin.SelectMembersToMerge(7);
                VerifyTextOnPageAndHighLight(validationMessage1);
                Logger.WriteDebugMessage("Validation message should get displays as ''There are more than 6 accounts please reduce your selections''.");

                //6.Verify user is able to delete a profile
                //7.Now, Select 2 to 6 profile to merge
                Admin.SelectMembersToMerge(4);
                Logger.WriteDebugMessage("Member should get selected");

                //8.Verify selected member on merge tab
                Admin.Click_ManualMerge_SubTab_ManualMerge();
                Logger.WriteDebugMessage("The merge tab title will show the number of members added to be merged.");

                //9.Selects a winner record and clicks on Merge button
                Admin.Click_ManualMerge_RadioButton_AccountWinner1();
                Admin.Click_ManualMerge_Button_Merge();
                AddDelay(2000);
                Logger.WriteDebugMessage("Third tab 'Member Merge Review' will display the target member record");

                //10.Click on Merge button
                Admin.Click_ManualMergeReview_Button_Merge();
                VerifyTextOnPageAndHighLight(validationMessage2);
                Logger.WriteDebugMessage("''Once confirmed this merge cannot be undone. Please confirm to continue''.msg gets displayed ");

                //11.Click on Cancel 
                Admin.Click_ManualMergeReview_Button_Cancel();
                Logger.WriteDebugMessage("popup gets closed ");

                //12.Click on Merge button 
                Admin.Click_ManualMergeReview_Button_Merge();
                VerifyTextOnPageAndHighLight(validationMessage2);
                Logger.WriteDebugMessage("Validation message should be displayed");

                //13.Click on Confirm
                //Admin.Click_ManualMergeReview_Button_Cancel();
                Admin.Click_ManualMerge_Button_Confirm();
                VerifyTextOnPage(validationMessage3);
                Logger.WriteDebugMessage("Confirmation message should displays as 'These accounts have now been merged successfully.All accounts Stays and Benefits have been moved to this account.The other accounts have been deleted from the system.'");
            }
        }

        public static void TC_161135()
        {
            if (TestCaseId == Constants.TC_161135)
            {
                Users data = new Users();

                //Pre - condition : 
                //1.Login to Database
                //2.Login to Admin with valid credentials
                //3.Target Profile is active
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                string level1 = "", level2 = "";
                Queries.GetMemberLevel(data, 1);
                string MemberLevel1 = data.MembershipLevel;
                Queries.GetMemberLevel(data, 2);
                string MemberLevel2 = data.MembershipLevel;
                if (ProjectName.Equals("MyStay") || ProjectName.Equals("HotelIcon") || ProjectName.Equals("HotelOrigami"))
                {
                    if (MemberLevel1.Equals("Loyal Member Level 1"))
                    {
                        level1 = "Loyal_LVL1";
                        level2 = "Loyal_LVL2";
                    }
                    else if (MemberLevel1.Equals("Engage Explorer"))
                    {
                        level1 = "Explorer";
                        level2 = "Highflyers";
                    }
                    else if (MemberLevel1.Equals("Club Member"))
                    {
                        level1 = "MEMBER";
                        level2 = "ELITE";
                    }

                    Queries.GetDataAsPerMemberLevel(level1, data);
                }
                else
                {
                    Queries.GetDataAsPerMemberLevel(MemberLevel1, data);
                }

                string email1 = data.MemberEmail;
                if (ProjectName.Equals("MyStay") || ProjectName.Equals("HotelIcon") || ProjectName.Equals("HotelOrigami"))
                {
                    Queries.GetDataAsPerMemberLevel(level2, data);
                }
                else
                {
                    Queries.GetDataAsPerMemberLevel(MemberLevel2, data);
                }

                //1.Click on Manual Merge Tab
                Admin.Click_Menu_ManualMerge();
                Logger.WriteDebugMessage("Landed on the Manual Merge page");
                Logger.LogTestData(TestPlanId, TestCaseId, "Member Level 1", MemberLevel1);
                Logger.LogTestData(TestPlanId, TestCaseId, "Member Level 2", MemberLevel2);
                Logger.LogTestData(TestPlanId, TestCaseId, "Member Email for" +MemberLevel1, email1);
                //2.Search for Profiles which different member level
                //3.Select profiles to merge
                string email2 = data.MemberEmail;
                Admin.ManualMerge_Text_Email(email1);
                Admin.Click_ManualMerge_Button_SearchMember();
                Admin.Click_ManualMerge_Icon_Select1();
                Admin.Click_ManualMerge_Button_ClearSearch();
                Admin.ManualMerge_Text_Email(email2);
                Logger.LogTestData(TestPlanId, TestCaseId, "Member Email for" + MemberLevel2, email2, true);
                Admin.Click_ManualMerge_Button_SearchMember();
                Admin.Click_ManualMerge_Icon_Select1();
                Logger.WriteDebugMessage("Member should get selected");

                //3.Click on review button
                Admin.Click_ManualMerge_Button_Review();
                Logger.WriteDebugMessage("Member information should be displayed of selected member with account winner radio button");

                //4.Select any one account for account winner member              
                Admin.Click_ManualMerge_RadioButton_AccountWinner1();
                string accountWinnerEmail1 = PageObject_Admin.Admin_ManualMerge_Value_AccountWinner1_Email().GetAttribute("innerHTML");
                Logger.WriteDebugMessage("Third tab 'Member Merge Review' will display the target member record");

                //5.Click on Merge button and Click on save
                Admin.Click_ManualMerge_Button_Merge();
                Logger.WriteDebugMessage("Member merge review page should be displayed");

                //6.Search target profile
                //8.Verify Member level of Target Profile
                if (ProjectName.Equals("MyStay") || ProjectName.Equals("HotelIcon") || ProjectName.Equals("HotelOrigami"))
                {
                    VerifyTextOnPageAndHighLight(level2.ToUpper());
                }
                else
                {
                    VerifyTextOnPageAndHighLight(MemberLevel2.ToUpper());
                }

                Logger.WriteDebugMessage("Highest member Level gets retained");
            }
        }

        public static void TC_161136()
        {
            if (TestCaseId == Constants.TC_161136)
                {
                    Users data = new Users();

                    //Pre - condition : 
                    //1.Login to Database
                    //2.Login to Admin with valid credentials
                    //3.Target Profile is active
                    string date;
                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    //1.Click on Manual Merge Tab
                    Admin.Click_Menu_ManualMerge();
                    Helper.PageDown();
                    Logger.WriteDebugMessage("User Should get landed on Membership merge tab");

                    //2.Search for profiles with different join date 
                    //3.Select profiles to merge 
                    Queries.GetDataPer_JoiningDate(DateTime.Today.ToShortDateString(), 0, data);                    
                    string profile1 = data.MemberEmail;
                    Queries.GetProfileIDByMemberEmail(data, profile1);
                    DateTime profile1_Joiningdate = DateTime.Parse(data.RegistrationTime);
                    string profile1_Expirationdate = data.ExpirationDate;
                    Queries.GetDataPer_JoiningDate(DateTime.Now.ToShortDateString(), 1, data, profile1);
                    string profile2 = data.MemberEmail;
                    DateTime profile2_Joiningdate = DateTime.Parse(data.RegistrationTime);
                    string profile2_Expirationdate = data.ExpirationDate;
                    Admin.ManualMerge_Text_Email(profile1);
                    Admin.Click_ManualMerge_Button_SearchMember();
                    Admin.Click_ManualMerge_Icon_Select1();
                    Logger.WriteDebugMessage("First Member get selected");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Profile 1", profile1);
                    Admin.Click_ManualMerge_Button_ClearSearch();
                    Admin.ManualMerge_Text_Email(profile2);
                    Admin.Click_ManualMerge_Button_SearchMember();
                    Admin.Click_ManualMerge_Icon_Select1();
                    Logger.WriteDebugMessage("Second Member get selected");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Profile 2", profile2, true);

                    //4.Click on Member merge tab
                    Admin.Click_ManualMerge_Button_Review();
                    Logger.WriteDebugMessage("User should get landed on Member merge page");

                    //5.Selects a winner record and clicks on Merge button               
                    Admin.Click_ManualMerge_RadioButton_AccountWinner1();
                    Logger.WriteDebugMessage("First Account got selected");
                    Admin.Click_ManualMerge_Button_Merge();

                    DateTime verifyProfileDate = (profile1_Joiningdate < profile2_Joiningdate) ? profile1_Joiningdate : profile2_Joiningdate;
                    date = verifyProfileDate.ToString(String.Format("{0}/{1}/{2}", ((verifyProfileDate.Month < 10) ? "M" : "MM"), ((verifyProfileDate.Day < 10) ? "d" : "dd"), "yyyy"));

                    VerifyTextOnPageAndHighLight(date);
                    Logger.WriteDebugMessage("Member merge review page should be displayed");

                    //6.Click on Merge button and Click on save
                    Admin.Click_ManualMergeReview_Button_Merge();
                    Logger.WriteDebugMessage("''Once confirmed this merge cannot be undone. Please confirm to continue''.msg gets displayed ");
                    Admin.Click_ManualMerge_Button_Confirm();
                    Logger.WriteDebugMessage("Users Merged successfully");

                    //7.Search target profile
                    //8.Verify  join date for Target Profile
                    Admin.Click_Menu_Home();
                    Admin.EnterEmail(profile1);
                    Admin.Click_Button_MemberSearch();
                    Admin.Click_Icon_View(ProjectName);
                    Helper.PageDown();
                    VerifyTextOnPage(date);
                    Logger.WriteDebugMessage("Oldest Join date and Latest expiration date from child gets updated in target profile");

                }
        }

        public static void TC_161137()
        {try
            {
                if (TestCaseId == Constants.TC_161137)
                {
                    Users data = new Users();

                    //Pre - condition : 
                    //1.Login to Database
                    //2.Login to Admin with valid credentials
                    //3.Target Profile is active                
                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    //1.Click on Manual Merge Tab
                    Admin.Click_Menu_ManualMerge();
                    Logger.WriteDebugMessage("User Should get landed on Membership merge tab");

                    //2.Search for profiles with different join date 
                    //3.Select profiles to merge 
                    Queries.GetDataPer_ManualTransaction(1, data);
                    string profile1 = data.MemberEmail;
                    Queries.GetAdminAccountTransactionCount(data, data.MemberEmail);
                    int profile1_TransactionCount = int.Parse(data.NoOfTransaction);
                    Queries.GetDataPer_ManualTransaction(1, data, profile1);
                    string profile2 = data.MemberEmail;
                    Queries.GetAdminAccountTransactionCount(data, data.MemberEmail);
                    int profile2_TransactionCount = int.Parse(data.NoOfTransaction);
                    Admin.ManualMerge_Text_Email(profile1);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Profile 1", profile1);
                    Admin.Click_ManualMerge_Button_SearchMember();
                    Admin.Click_ManualMerge_Icon_Select1();
                    Admin.Click_ManualMerge_Button_ClearSearch();
                    Admin.ManualMerge_Text_Email(profile2);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Profile 2", profile2);
                    Admin.Click_ManualMerge_Button_SearchMember();
                    Admin.Click_ManualMerge_Icon_Select1();
                    Logger.WriteDebugMessage("Member should get selected");

                    //4.Click on Member merge tab
                    Admin.Click_ManualMerge_Button_Review();
                    Logger.WriteDebugMessage("User should get landed on Member merge page");

                    //5.Selects a winner record and clicks on Merge button               
                    Admin.Click_ManualMerge_RadioButton_AccountWinner1();
                    Admin.Click_ManualMerge_Button_Merge();
                    Logger.WriteDebugMessage("Member merge review page should be displayed");

                    //6.Click on Merge button and Click on save
                    Admin.Click_ManualMergeReview_Button_Merge();
                    VerifyTextOnPage("Once confirmed this merge cannot be undone. Please confirm to continue");
                    Admin.Click_ManualMerge_Button_Confirm();
                    Logger.WriteDebugMessage("Users Merged successfully");

                    //7.Search target profile
                    //8.Verify Manual Transaction for Target Profile
                    Queries.GetAdminAccountTransactionCount(data, profile1);
                    int mergedprofile_TransactionCount = int.Parse(data.NoOfTransaction);
                    PageUp();
                    Admin.Click_Menu_Home();
                    Logger.WriteDebugMessage("Home tab clicked");
                    Admin.EnterEmail(profile1);
                    Admin.Click_Button_MemberSearch();
                    Logger.WriteDebugMessage("Member found on page");
                    Admin.Click_Icon_View(ProjectName);
                    Logger.WriteDebugMessage("Member information page for member" + profile1 + "is displayed");
                    if (!(ProjectName.Equals("HotelIcon") || ProjectName.Equals("Virgin") || ProjectName.Equals("Sarova") || ProjectName.Equals("Sacher")))
                    {
                        Admin.Click_Tab_MemberTransactions();
                        if (mergedprofile_TransactionCount.Equals(profile1_TransactionCount + profile2_TransactionCount))
                        {
                            PageDown();
                            Logger.WriteDebugMessage("Manual Transaction from child profile gets moved to target profile");
                        }
                        else
                        {
                            Assert.Fail("Manual Transaction from child profile is NOT moved to target profile");
                        }
                    }
                }
            } catch (Exception e)
            { }        }

        public static void TC_161150()
        {
            if (TestCaseId == Constants.TC_161150)
                {
                    // Pre-requisites
                    string validationMessage1, validationMessage2, validationMessage3;
                    Users data = new Users();

                    //retrive data from test data file
                    validationMessage1 = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage1");
                    validationMessage2 = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage2");
                    validationMessage3 = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage3");

                    //Pre - condition : 
                    //1.Login to Database
                    //2.Login to Admin with valid credentials
                    //3.Target Profile is Inactive or Deactive and user click
                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    //1.Click on Manual Merge Tab
                    Admin.Click_Menu_ManualMerge();
                    Logger.WriteDebugMessage("User Should get landed on Membership merge tab");

                    //2.Search for  Profile to merge
                    Queries.GetDataPerStatus_DCustomer("Inactive", 1, data);
                    string email1 = data.eMail;
                    Queries.GetDataPerStatus_DCustomer("Active", 1, data, email1);
                    string email2 = data.eMail;
                    Admin.ManualMerge_Text_Email(email1);
                    Admin.Click_ManualMerge_Button_SearchMember();
                    Admin.Click_ManualMerge_Icon_Select1();
                    Logger.WriteDebugMessage("First member got Selected");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Inactive_Member", email1);
                    Admin.Click_ManualMerge_Button_ClearSearch();
                    Admin.ManualMerge_Text_Email(email2);
                    Admin.Click_ManualMerge_Button_SearchMember();
                    Admin.Click_ManualMerge_Icon_Select1();
                    Logger.WriteDebugMessage("Second member got Selected");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Active Member", email2);
                    Logger.WriteDebugMessage("Review button should be displayed and manual merge tab should be activated");

                    //3.Verify selected member on merge tab
                    //4.Click on Member merge tab/Member Merge Review
                    Admin.Click_ManualMerge_Button_Review();
                    Logger.WriteDebugMessage("User should get landed on Member merge page");

                    //5.Select a Inactive Profile as  winner record                
                    Admin.Click_ManualMerge_RadioButton_AccountWinner1();
                    Logger.WriteDebugMessage("Winner Profile got Selected");
                    string accountWinnerEmail1 = PageObject_Admin.Admin_ManualMerge_Value_AccountWinner1_Email().GetAttribute("innerHTML");
                    string accountWinnerEmail2 = PageObject_Admin.Admin_ManualMerge_Value_AccountWinner2_Email().GetAttribute("innerHTML");
                    Admin.Click_ManualMerge_Button_Merge();
                    VerifyTextOnPageAndHighLight("Inactive");
                    Logger.WriteDebugMessage("Member merge review page should be displayed");

                    //6.Click on merge
                    string status = PageObject_Admin.Admin_ManualMerge_Value_Status().GetAttribute("innerHTML");
                    Admin.Click_ManualMergeReview_Button_Merge();
                    VerifyTextOnPage(validationMessage1);
                    Logger.WriteDebugMessage("Message to alert the profile is currently inactive and will become active if user proceeds should be displayed ");
                    VerifyTextOnPage(validationMessage2);
                    Admin.Click_ManualMerge_Button_Confirm();
                    Logger.WriteDebugMessage("Users Merged successfully");

                    //7.Search for Child Profile using Email
                    Admin.Click_Menu_Home();
                    Admin.EnterEmail(accountWinnerEmail2);
                    Admin.Click_Button_MemberSearch();
                    VerifyTextOnPage(validationMessage3);
                    Logger.WriteDebugMessage("Child profile using email, should yield 0 records");

                    //8.Verify Target Profile status
                    Admin.EnterEmail(accountWinnerEmail1);
                    Admin.Click_Button_MemberSearch();
                    Logger.WriteDebugMessage("Target Profile status becomes active");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Winner Account Email", accountWinnerEmail1, true);
                    //[Avinash] : As per comment recived from Lucy on Defect #236899, skiping the below steps

                    //9.Verify Target Profile Log for Memberstatus
                    //Admin.Click_Icon_View(ProjectName);
                    //AddDelay(2500);
                    //string date = DateTime.Now.ToString("yyyy-MM-dd");
                    //Queries.GetMemberStatusChange_Log(data, date, accountWinnerEmail1);
                    //string status_Database = data.Status;
                    //if (status_Database.Equals("Active"))
                    //{
                    //    Logger.WriteDebugMessage("Member status should be updated to the log.");
                    //}
                    //else
                    //{
                    //    Assert.Fail("Member status should be updated to the log.");
                    //}
                }
        }
        #endregion TP_166488
    }
}
