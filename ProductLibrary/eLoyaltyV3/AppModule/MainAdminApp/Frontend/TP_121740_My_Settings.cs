using System;
using eLoyaltyV3.Utility;
using eLoyaltyV3.PageObject.UI;
using eLoyaltyV3.AppModule.UI;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Globalization;
using NUnit.Framework;
using Common;
using OpenQA.Selenium;
using TestData.ExcelData;
using System.Net;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Constants = eLoyaltyV3.Utility.Constants;
using eLoyaltyV3.Entity;
using TestData;
using BaseUtility.Utility;
using Queries = eLoyaltyV3.Utility.Queries;
using InfoMessageLogger;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : eLoyaltyV3.Utility.Setup
    {
        #region TP_121740 - My Settings Page
        public static void TC_120138()
        {
            if (TestCaseId == Constants.TC_120138)
            {
                string ReturnResult;
                //1.URL is available in description
                //2.Data Requirement: Registered user Credential
                //3.Navigate to Sign in page
                //4.Enter the credential and Sign in   
                Users data = new Users();
                string username, password, validationMessage;
                ReturnResult = Constants.UpdateSettingsMessage;
                //*Added this code as per changes for R#208647 for HotelIcon Client*//
                Queries.GetActiveMemberEmail(data, ProjectName);
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }
                password = TestData.ExcelData.ExcelDataReader.ReadData(1, "Password");
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                MySettingWait(ProjectName);
                if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                {
                    string PageTitle = Driver.Title;
                    Helper.RegexFunction(PageTitle, pattern);
                }

                Logger.WriteDebugMessage("User should be able to Login Successfully");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Test_Data", data.MemberEmail);

                //5.Navigate to Update Password screen
                Navigation.ClickMySettings(ProjectName);
                Logger.WriteDebugMessage("Landed on the My Settings page.");

                //6.Without entering Password click on Submit
                string FieldReq = Constants.UpdateUserEmailMessage;
                //Only Submit Button.
                MySettings.UpdateUserPasswordwithCase(ProjectDetails.CommonFrontendPassword, ProjectDetails.CommonFrontendPassword, FieldReq, 0, ProjectName);
                Logger.WriteDebugMessage("Validation msg requesting user to enter mandatory field should display");

                //7.Enter  single  whitespace in password field
                validationMessage = Constants.WhiteSpacePassword;
                //White Space for all field.
                Helper.ReloadPage();
                MySettings.UpdateUserPasswordwithCase(" ", " ", validationMessage, 1, ProjectName);
                Logger.WriteDebugMessage("Validation msg requesting user to enter mandatory field should display");

                //8.Logger.WriteDebugMessage("Validation msg requesting user to enter mandatory field should display");
                FieldReq = Constants.UpdateUserEmailMessage;
                for (int i = 3; i < 11; i++)
                {
                    var runningCase = (i > 8) ? 1 : i;
                    var currentPassword = (i != 9) ? ProjectDetails.CommonFrontendPassword : password;
                    var newPassword = (i != 9) ? password : ProjectDetails.CommonFrontendPassword;
                    Helper.ReloadPage();
                    MySettings.UpdateUserPasswordwithCase(currentPassword, newPassword, FieldReq, runningCase, ProjectName);
                    Helper.AddDelay(2000);
                    Logger.WriteDebugMessage("Validation msg requesting user to enter mandatory field should display");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Current Password "+i, currentPassword);
                    if(i==10)
                        Logger.LogTestData(TestPlanId, TestCaseId, "New Password "+i, newPassword, true);
                    else
                        Logger.LogTestData(TestPlanId, TestCaseId, "New Password " + i, newPassword);
                }
                
            }
        }

        public static void TC_124899()
        {
            if (TestCaseId == Constants.TC_124899)
            {
                string SuccessUpdate = Constants.UpdateSettingsMessage;
                //1.URL and database detail available in master test plan  run 
                //2.Log into  front end  as   PMS User                
                string PMSCustomerEmail = Queries.ReturnPMSCustomerEmail();
                string password = TestData.ExcelData.ExcelDataReader.ReadData(1, "Password");
                string newPassword = TestData.ExcelData.ExcelDataReader.ReadData(1, "NewPassword");          
                password = ProjectDetails.CommonFrontendPassword;
                newPassword = ProjectDetails.CommonFrontendPassword.Substring(0, 9) + ".";
                //*Added this code as per changes for R#208647 for HotelIcon Client*//
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }
                LoginCredentials(PMSCustomerEmail, ProjectDetails.CommonFrontendPassword, ProjectName);              
               
                MySettingWait(ProjectName);
                if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                {
                    string PageTitle = Driver.Title;
                    Helper.RegexFunction(PageTitle, pattern);
                }
                Logger.LogTestData(TestPlanId, TestCaseId, "PMS User", PMSCustomerEmail);

                //3.Click on My Setting 
                Navigation.ClickMySettings(ProjectName);
                if (Driver.Url.Contains(MySettingsURL))
                {
                    Logger.WriteDebugMessage("Landed on the My Settings page.");
                }

                //4.Enter current password under update password section  
                //5.Enter New password into "New Password *" field  
                //6.Enter same password into Confirm Password field 
                //7.Click Update User 
                MySettings.UpdateUserPasswordwithCase(password, newPassword, SuccessUpdate, 1, ProjectName);
                Logger.WriteDebugMessage("Password gets  updated successfully with message displayed about update on screen");
                if (ProjectName.Equals("IndependentCollection"))
                {
                    LoginCredentials(PMSCustomerEmail, newPassword, ProjectName);
                    MySettingWait(ProjectName);
                    Logger.WriteDebugMessage("Signin successfully with new password");
                    Navigation.ClickMySettings(ProjectName);
                }

                //8.Enter different Username into New User Name field under Update user section 
                //9.Enter current password into "Please provide your current password *" field 
                //10.Click Update User 
                string GetDate = DateTime.Now.ToString("MMddyyHHmm");
                string PMSCustomerEmailNew = (regexfunction(PMSCustomerEmail) + GetDate + "@cendyn17.com");
                MySettings.UpdateUserEmail(PMSCustomerEmailNew, newPassword, 1, ProjectName);
                Logger.WriteDebugMessage("New username gets updated successfully and message displayed on screen about changed successful ");
                Logger.LogTestData(TestPlanId, TestCaseId, "New PMS User", PMSCustomerEmailNew, true);
                if (ProjectName.Equals("AMR"))
                {
                    Helper.Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
                }
                else
                {
                    Navigation.ClickSignOut(ProjectName);
                    Logger.WriteDebugMessage("Signed Out from User's Account");
                }
                
                //*Added this code as per changes for R#208647 for HotelIcon Client*//
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }

                Helper.ElementWait(PageObject_SignIn.Text_Email(), 60);

                if (Helper.IsElementVisible(PageObject_SignIn.Text_Email()))
                {
                    LoginCredentials(PMSCustomerEmailNew, newPassword, ProjectName);
                    MySettingWait(ProjectName);
                    if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                    {
                        string PageTitle = Driver.Title;
                        Helper.RegexFunction(PageTitle, pattern);
                    }

                    Navigation.ClickMySettings(ProjectName);
                    if (Driver.Url.Contains(MySettingsURL))
                    {
                        Logger.WriteDebugMessage("Landed on the My Settings page.");
                    }

                    //Change UserName to previously existing UserName
                    MySettings.UpdateUserEmail(PMSCustomerEmail, newPassword, 1, ProjectName);
                    if (ProjectName.Equals("IndependentCollection"))
                    {
                        LoginCredentials(PMSCustomerEmail, newPassword, ProjectName);
                        MySettingWait(ProjectName);
                        Logger.WriteDebugMessage("Signin successfully");
                        Navigation.ClickMySettings(ProjectName);
                    }
                    if (ProjectName.Equals("AMR"))
                    {
                        Helper.Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
                        LoginCredentials(PMSCustomerEmail, newPassword, ProjectName);
                        MySettingWait(ProjectName);
                        Logger.WriteDebugMessage("Signin successfully with new password");
                        Navigation.ClickMySettings(ProjectName);
                    }
                   
                    MySettings.UpdateUserPasswordwithCase(newPassword, password, SuccessUpdate, 1, ProjectName);
                }
                else
                {
                    Assert.Fail("Did not land on SignIn Page.");
                }
            }
        }

        public static void TC_219436()
        {
            if (TestCaseId == Constants.TC_219436)
            {
                Users data = new Users();
                Random rannom = new Random();

                //string ReturnResult;
                string SuccessUpdate = Constants.UpdateSettingsMessage;
                //1.Log into   front end                 
                string username, password, newUsername, newPassword, scenario, validationMessage, profileId;
                Queries.GetActiveMemberEmail(data, ProjectName);
                username = data.MemberEmail;
                password = TestData.ExcelData.ExcelDataReader.ReadData(1, "Password");

                newUsername = String.Concat("QA", rannom.Next().ToString(), "@cendyn17.com");
                newPassword = TestData.ExcelData.ExcelDataReader.ReadData(1, "NewPassword");
                scenario = TestData.ExcelData.ExcelDataReader.ReadData(1, "Scenario");
                Queries.ReturnProfileData(username, data);
                profileId = data.ProfileId;
                // LoginCredentials(username, password, ProjectName);

                Queries.GetActiveMemberEmail(data);
                string email = data.MemberEmail;
                Queries.ReturnProfileData(email, data);
                profileId = data.ProfileId;

                password = ProjectDetails.CommonFrontendPassword;
                newPassword = String.Concat(ProjectDetails.CommonFrontendPassword, rannom.Next().ToString());
                scenario = TestData.ExcelData.ExcelDataReader.ReadData(1, "Scenario");
                if (ProjectName.Equals("HotelIcon"))
                    Navigation.Click_Button_SignIn();
                LoginCredentials(email, ProjectDetails.CommonFrontendPassword, ProjectName);
                MySettingWait(ProjectName);
                if (Driver.Url.Contains(LoginLand) || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                {
                    string PageTitle = Driver.Title;
                    Helper.RegexFunction(PageTitle, pattern);
                }

                Logger.WriteDebugMessage("User should be able to Login Successfully");
                Logger.LogTestData(TestPlanId, TestCaseId, "Test Data", username);
                Logger.LogTestData(TestPlanId, TestCaseId, "Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, "New Password", newPassword);

                //2.Click on My Setting 
                Navigation.ClickMySettings(ProjectName);
                if (Driver.Url.Contains(MySettingsURL))
                    Logger.WriteDebugMessage("Landed on the My Settings page.");
                else
                    Assert.Fail("User Landed on Wrong Page: " + Driver.Url);

                //3.Enter different Username into New User Name field under Update user section 
                //4.Enter current password into "Please provide your current password *" field
                //5.Click Update User
                string ranNo = rannom.Next().ToString();
                newUsername = String.Concat("qa", ranNo, "@cendyn17.com");
                MySettings.UpdateUserEmail(newUsername, password, 1, ProjectName);
                Logger.WriteDebugMessage("New username update successful and message displayed on screen about changed successful ");
                Logger.LogTestData(TestPlanId, TestCaseId, "New Email", newUsername);
                if (ProjectName.Equals("AMR"))
                {
                    Helper.Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
                    LoginCredentials(newUsername, password, ProjectName);
                    MySettingWait(ProjectName);
                    Logger.WriteDebugMessage("Signin successfully with new password");
                    Navigation.ClickMySettings(ProjectName);
                }
                if (ProjectName.Equals("IndependentCollection"))
                {
                    LoginCredentials(newUsername, ProjectDetails.CommonFrontendPassword, ProjectName);
                    MySettingWait(ProjectName);
                    Navigation.ClickMySettings(ProjectName);
                    Logger.WriteDebugMessage("New username update successful");
                }

                //6.Enter current password under update password section  
                //7.Enter New password into "New Password *" field 
                //8.Enter same password into Confirm Password field 
                //9.Click Update Password 
                MySettings.UpdateUserPasswordwithCase(password, newPassword, SuccessUpdate, 1, ProjectName);
                Logger.WriteDebugMessage("Password gets  updated successfully with message displayed about update on screen");

                //10.Logout from application and navigated back to login screen 
                if (!ProjectName.Equals("IndependentCollection"))
                {
                    Navigation.ClickSignOut(ProjectName);
                }
                Logger.WriteDebugMessage(" User is navigated to login screen ");

                //11.Try login to Application with Old Username and Password
                validationMessage = TestData.ExcelData.ExcelDataReader.ReadData(1, "Validation Message");
                if (ProjectName.Equals("HotelIcon"))
                    Navigation.Click_Button_SignIn();
                LoginCredentials(email, password, ProjectName);
                VerifyTextOnPage(validationMessage);
                Logger.WriteDebugMessage("User should not be able to Login and a validation message should be displayed");
                Logger.LogTestData(TestPlanId, TestCaseId, "Incorrect Credential Validation Message", validationMessage, true);
                if (ProjectName.Equals("IndependentCollection"))
                {
                    Navigation.Click_Button_Back();
                }

                //12.Verify the Email address is updated in Users, Memberships and D_Customer Table
                MySettings.VerifyEmailUpdateDatabase(newUsername, "User", profileId);
                MySettings.VerifyEmailUpdateDatabase(newUsername, "MemberShips", profileId);
                MySettings.VerifyEmailUpdateDatabase(newUsername, "D_Customer", profileId);
                Logger.WriteInfoMessage("Email Address should get Updated");

                //13.Login with the updated Username and password
                LoginCredentials(newUsername, newPassword, ProjectName);
                Logger.WriteDebugMessage("User should be able to Login Successfully");

                //14.Navigate to Contact Us
                Navigation.Click_Link_ContactUs(ProjectName);
                Logger.WriteDebugMessage("User should be navigated to Contact us Page");

                //15.verify the email is the new updated email address  in email content 
                VerifyTextOnPage(newUsername);
                Logger.WriteDebugMessage("email  in content should be the updated email address");

                //16.Click on My Settings
                Navigation.ClickMySettings(ProjectName);
                if (Driver.Url.Contains(MySettingsURL))
                    Logger.WriteDebugMessage("Landed on the My Settings page.");
                else
                    Assert.Fail("User Landed on Wrong Page: " + Driver.Url);

                //17.Enter the old username into New Username Field and Enter current Password
                //18.Click on Update User
                MySettings.UpdateUserEmail(email, newPassword, 1, ProjectName);
                Logger.WriteDebugMessage("User is able to enter the old user name ");

                if (ProjectName.Equals("AMR"))
                {
                    Helper.Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
                    LoginCredentials(newUsername, newPassword, ProjectName);
                    MySettingWait(ProjectName);
                    Logger.WriteDebugMessage("Signin successfully with new password");
                    Navigation.ClickMySettings(ProjectName);
                }
                if (ProjectName.Equals("IndependentCollection"))
                {
                    LoginCredentials(email, newPassword, ProjectName);
                    MySettingWait(ProjectName);
                    Navigation.ClickMySettings(ProjectName);
                    Logger.WriteDebugMessage("New username update successful");
                }

                //19.Enter current password under update password section  
                //20.Enter Old password into "New Password *" and "Confirm Password" field 
                //21.Click on Update Password
                MySettings.UpdateUserPasswordwithCase(newPassword, password, SuccessUpdate, 1, ProjectName);
                Logger.WriteDebugMessage("Password gets  updated successfully with message displayed about update on screen");

                //22.Logout from application and navigated back to login screen 
                if (!ProjectName.Equals("IndependentCollection"))
                {
                    Navigation.ClickSignOut(ProjectName);
                }
                Logger.WriteDebugMessage("User is navigated to login screen ");

                //23.Try login to Application with Old Username and Password
                if (ProjectName.Equals("HotelIcon"))
                    Navigation.Click_Button_SignIn();
                LoginCredentials(email, password, ProjectName);
                Logger.WriteDebugMessage("User should be able to Login Successfully");
            }
        }

        public static void TC_219459()
        {
            if (TestCaseId == Constants.TC_219459)
            {
                Users data = new Users();

                //1.Navigate to Sign in page
                //2.Enter the credential and Sign in
                string newPassword, scenario, validationMessage;
                Queries.GetActiveMemberEmail(data);
                string email = data.MemberEmail;
                if (ProjectName.Equals("HotelIcon"))
                    Navigation.Click_Button_SignIn();
                LoginCredentials(email, ProjectDetails.CommonFrontendPassword, ProjectName);
                string currentPassword = ProjectDetails.CommonFrontendPassword;
                MySettingWait(ProjectName);
                if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                {
                    string PageTitle = Driver.Title;
                    Helper.RegexFunction(PageTitle, pattern);
                }

                Logger.WriteDebugMessage("User should be able to Login Successfully");
                Logger.LogTestData(TestPlanId, TestCaseId, "Email", email);
                Logger.LogTestData(TestPlanId, TestCaseId, "Old Password", ProjectDetails.CommonFrontendPassword);

                //2.Navigate to Update Password screen
                Navigation.ClickMySettings(ProjectName);
                if (Driver.Url.Contains(MySettingsURL))
                    Logger.WriteDebugMessage("User navigate to Update Password page");
                else
                    Assert.Fail("User Landed on Wrong Page: " + Driver.Url);

                //6.Enter mismatch detail in New password and Confirm Password Click on submit
                scenario = TestData.ExcelData.ExcelDataReader.ReadData(1, "Scenario1");
                newPassword = TestData.ExcelData.ExcelDataReader.ReadData(1, "Password1");
                validationMessage = TestData.ExcelData.ExcelDataReader.ReadData(1, "Validation Message1");
                Logger.WriteDebugMessage(scenario + "is tested");
                Logger.LogTestData(TestPlanId, TestCaseId, 1+ "New Password", newPassword);
                Logger.LogTestData(TestPlanId, TestCaseId, 1 + "Validation Message", validationMessage);

                MySettings.UpdateUserPasswordwithCase(currentPassword, newPassword, validationMessage, 2, ProjectName);

                //7.Enter password and Confirm Password as old password Click on submit
                scenario = TestData.ExcelData.ExcelDataReader.ReadData(2, "Scenario2");
                newPassword = TestData.ExcelData.ExcelDataReader.ReadData(2, "Password2");
                validationMessage = TestData.ExcelData.ExcelDataReader.ReadData(2, "Validation Message2");
                Logger.WriteDebugMessage(scenario + "is tested");
                MySettings.UpdateUserPasswordwithCase(currentPassword, newPassword, validationMessage, 1, ProjectName);
                Logger.LogTestData(TestPlanId, TestCaseId, 2 + "New Password", newPassword);
                Logger.LogTestData(TestPlanId, TestCaseId, 2 + "Validation Message", validationMessage);

                //8.Enter Invalid data in Password and Confirm Password Field
                if (Driver.Url.Contains("Settings"))
                {
                    for (int i = 3; i <= 6; i++)
                    {
                        scenario = TestData.ExcelData.ExcelDataReader.ReadData(i, "Scenario");
                        newPassword = TestData.ExcelData.ExcelDataReader.ReadData(i, "Password");
                        validationMessage = TestData.ExcelData.ExcelDataReader.ReadData(i, "Validation Message");
                        Logger.WriteDebugMessage(scenario + "is tested");
                        MySettings.UpdateUserPasswordwithCase(currentPassword, newPassword, validationMessage, 2, ProjectName);
                        Logger.LogTestData(TestPlanId, TestCaseId, 3 + "New Password "+i, newPassword);
                        if(i==6)
                            Logger.LogTestData(TestPlanId, TestCaseId, 3 + "Validation Message " + i, validationMessage, true);
                        else
                            Logger.LogTestData(TestPlanId, TestCaseId, 3 + "Validation Message "+i, validationMessage);
                    }
                }
            }
        }

        public static void TC_219517()
        {
            if (TestCaseId == Constants.TC_219517)
            {
                Users data = new Users();
                //string ReturnResult;
                //string SuccessUpdate = Constants.UpdateSettingsMessage;
                //Random randomnumber = new Random();
                string username, password, newUsername, newPassword, scenario, validationMessage, confirmationMessage;
                username = TestData.ExcelData.ExcelDataReader.ReadData(1, "UserName");
                password = TestData.ExcelData.ExcelDataReader.ReadData(1, "Password");
                newPassword = TestData.ExcelData.ExcelDataReader.ReadData(1, "NewPassword");
                scenario = TestData.ExcelData.ExcelDataReader.ReadData(1, "Scenario");
                Random random = new Random();
                newUsername = string.Concat("QATest", random.Next().ToString(), "@cendyn17.com");
                //loginCredentials(username, password, ProjectName);
                Queries.GetActiveMemberEmail(data);
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                MySettingWait(ProjectName);
                if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                {
                    string PageTitle = Driver.Title;
                    Helper.RegexFunction(PageTitle, pattern);
                }

                Logger.WriteDebugMessage("User should be able to Login Successfully");
                Logger.LogTestData(TestPlanId, TestCaseId, "Email", data.MemberEmail);
                Logger.LogTestData(TestPlanId, TestCaseId, "Password New", ProjectDetails.CommonFrontendPassword);

                //2.Click on My Setting 
                Navigation.ClickMySettings(ProjectName);
                if (Driver.Url.Contains(MySettingsURL))
                    Logger.WriteDebugMessage("Landed on the My Settings page.");
                else
                    Assert.Fail("User Landed on Wrong Page: " + Driver.Url);

                //3.Enter different Username into New User Name field under Update user section 
                //4.Enter current password into "Please provide your current password *" field 
                //5.Click Update User 
                Logger.WriteInfoMessage(scenario + "is being testing");
                Random ran = new Random();
                int ranNo = ran.Next();
                newUsername = String.Concat("qa", ranNo.ToString(), "@cendyn17.com");
                MySettings.UpdateUserEmail(newUsername, ProjectDetails.CommonFrontendPassword, 1, ProjectName);
                Logger.WriteDebugMessage("New username update successful and message displayed on screen about changed successful ");
                Logger.LogTestData(TestPlanId, TestCaseId, "New Username", newUsername);

                ////6.Logout from application and navigated back to login screen
                Navigation.ClickSignOut(ProjectName);
                Logger.WriteInfoMessage("User is navigated to login screen ");

                //7.Click on forget password,Enter the old user name and,Click on Recover
                validationMessage = TestData.ExcelData.ExcelDataReader.ReadData(2, "ValidationMessage");
                SignIn.Click_Link_ForgotYourLogin(ProjectName);
                AddDelay(3000);
                ForgotPassword.EnterEmail(data.MemberEmail);
                Logger.WriteDebugMessage("Enter Email Address :" + data.MemberEmail);
                ForgotPassword.ClickRecover();
                Helper.ValitionMessage(validationMessage);
                Logger.WriteInfoMessage("Msg should  display that email doesn't exist. ");
                Logger.LogTestData(TestPlanId, TestCaseId, "Validation Message", validationMessage);

                //8.Enter the updated user name  and click on recover 
                confirmationMessage = TestData.ExcelData.ExcelDataReader.ReadData(2, "ConfirmationMessage");
                ForgotPassword.EnterEmail(newUsername);
                Logger.WriteDebugMessage("Enter Email Address :" + username);
                ForgotPassword.ClickRecover();
                Helper.ValitionMessage(confirmationMessage);
                Logger.WriteInfoMessage("Confirmation msg  on should get displayed");
                Logger.LogTestData(TestPlanId, TestCaseId, "Confirmation Message", confirmationMessage, true);
                //9. Password recovery email sent to guest  and should be available in catchall 
                Email.LogIntoCatchAll();
                Email.CatchAll_SearchEmailAndOpenLatestMessage(newUsername + "  Password"); // Searched for the email
                Email.ForgotPasswordEmail_Check();
                CloseWindow();
                Logger.WriteDebugMessage("Email should be available in catchall");

                //10.In new tab login  to admin 
                ControlToNewWindow();
                Helper.OpenNewTab();
                ControlToNewWindow();
                Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("member search page gets displayed ");

                //11.Search for old  user name 
                validationMessage = TestData.ExcelData.ExcelDataReader.ReadData(3, "ValidationMessage");
                Admin.EnterEmail(data.MemberEmail);
                Admin.Click_Button_MemberSearch();
                AddDelay(2500);
                VerifyTextOnPageAndHighLight(validationMessage);
                Logger.WriteDebugMessage("Result set should not get displayed");

                //12.Search for new email address  
                //13.Click on view icon 
                Admin.EnterEmail(newUsername);
                Admin.Click_Button_MemberSearch();
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("user landed on member information page ");

                //14. Verify the email address 
                VerifyTextOnPageAndHighLight(newUsername);
                Logger.WriteDebugMessage("Email address should be the updated email address ");

                //15 Verify the email  that display on click of  Activation email - Resend link 
                Admin.Click_MemberInformation_Value_ActivationEmail();
                VerifyTextOnPageAndHighLight(newUsername);
                Logger.WriteDebugMessage("updated user name should get displayed ");
                Admin.Click_ActivationEmail_Icon_Close();


                //16. Verify the email  that display on click of Welcome email resend
                if (!ProjectName.Equals("ESPC") && !ProjectName.Equals("Sacher"))
                {
                    Admin.Click_MemberInformation_Value_WelcomeEmail();
                    VerifyTextOnPageAndHighLight(newUsername);
                    Logger.WriteDebugMessage(" on click updated user name should get displayed ");
                    Admin.Click_WelcomeEmail_Icon_Close();
                }

                //17. Verify the email  that display on click of Member Login  Reset ​
                Admin.Click_MemberInformation_Value_MemberLogin();
                VerifyTextOnPageAndHighLight(newUsername);
                Logger.WriteDebugMessage("user gets auto logged in to the portal  in a new tab ");
                Admin.Click_MemberInformation_Icon_Close();

                //Reset email back to original
                Admin.SendResetLogin(data.MemberEmail);
            }
        }

        //Commented the Test cases as related to V3 and not added in Global test plan
        /*
        public static void TC_120126()
        {
            Users data = new Users();
            string ReturnResult;

            string SuccessUpdate = Constants.UpdateSettingsMessage;
            if (TestCaseId == Constants.TC_120126)
            {
                //1.URL and database detail available in master test plan  run 
                //2.Log into  front end  as  non PMS User 
                string NonPMSCustomerEmail = Queries.ReturnNonPMSCustomerEmail();
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }

                LoginCredentials(NonPMSCustomerEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                MySettingWait(ProjectName);
                if (Driver.Url.Contains(LoginLand) || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                {
                    string PageTitle = Driver.Title;
                    Helper.RegexFunction(PageTitle, pattern);
                }

                //3.Click on My Setting 
                Navigation.ClickMySettings(ProjectName);
                if (Driver.Url == MySettingsURL)
                {
                    Logger.WriteDebugMessage("Landed on the My Settings page.");
                }

                //4.Enter current password under update password section  
                //5.Enter New password into "New Password *" field 
                //6.Enter same password into Confirm Password field 
                //7.Click Update Password 
                MySettings.UpdateUserPasswordwithCase(ProjectDetails.CommonFrontendPassword, TestData.TC_120126_NewPassword,
                    SuccessUpdate, 1, ProjectName);
                Logger.WriteDebugMessage(
                    "Password gets  updated successfully with message displayed about update on screen");

                //8.Enter different Username into New User Name field under Update user section 
                //9.Enter current password into "Please provide your current password *" field 
                //10.Click Update User 
                string PMSCustomerEmail = Queries.ReturnPMSCustomerEmail();
                string GetDate = DateTime.Now.ToString("MMddyyHHmm");
                string NonPMSCustomerEmailNew = (regexfunction(NonPMSCustomerEmail) + GetDate + "@cendyn17.com");
                //Change UserName
                MySettings.UpdateUserEmail(NonPMSCustomerEmailNew, TestData.TC_120126_NewPassword, 1, ProjectName);
                Logger.WriteDebugMessage(
                    "New username gets updated successfully and message displayed on screen about changed successful ");

                //11.logout and Login back using updated user name and password 
                Navigation.ClickSignOut(ProjectName);
                Logger.WriteDebugMessage("Signed Out from User's Account");
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }

                Helper.ElementWait(PageObject_SignIn.Text_Email(), 60);

                if (Helper.IsElementVisible(PageObject_SignIn.Text_Email()))
                {
                    LoginCredentials(NonPMSCustomerEmailNew, TestData.TC_120126_NewPassword, ProjectName);
                    MySettingWait(ProjectName);
                    if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                    {
                        string PageTitle = Driver.Title;
                        Helper.RegexFunction(PageTitle, pattern);
                    }

                    Navigation.ClickMySettings(ProjectName);
                    if (Driver.Url == MySettingsURL)
                    {
                        Logger.WriteDebugMessage("Landed on the My Settings page.");
                    }

                    //Change UserName to previously existing UserName
                    MySettings.UpdateUserEmail(NonPMSCustomerEmail, TestData.TC_120126_NewPassword, 1, ProjectName);
                    MySettings.UpdateUserPasswordwithCase(TestData.TC_120126_NewPassword,
                        TestData.CommonFrontendPassword, SuccessUpdate, 1, ProjectName);
                }
                else
                {
                    Assert.Fail("Did not land on SignIn Page.");
                }
            }
        }

        public static void TC_120127()
        {
            if (TestCaseId == Constants.TC_120127)
            {
                string successmessage = Constants.KioskJoinSuccess;
                string SuccessUpdate = Constants.UpdateSettingsMessage;
                //1.URL and database detail available in master test plan  run 
                //2.Log into   front end 
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }

                LoginCredentials(TestData.TC_120127_Email, TestData.CommonFrontendPassword, ProjectName);
                MySettingWait(ProjectName);
                if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                {
                    string PageTitle = Driver.Title;
                    Helper.RegexFunction(PageTitle, pattern);
                }

                //3.Click on My Setting 
                Navigation.ClickMySettings(ProjectName);
                if (Driver.Url == MySettingsURL)
                {
                    Logger.WriteDebugMessage("Landed on the My Settings page.");
                }

                //4.Enter current password under update password section  
                //5.Enter New password into "New Password *" field 
                //6.Enter same password into Confirm Password field 
                //7.Click Update Password 
                //MySettings.UpdateEmailAddressandPasswordfield(TestData.TC_120126_InvalidEmail, TestData.TC_120126_UpdateEmail, TestData.TC_120126_Password, TestData.TC_120126_InvalidCurrentPassword, TestData.TC_120126_NewPassword, TestData.TC_120126_NewPassword_Confirm);
                MySettings.UpdateUserPasswordwithCase(TestData.CommonFrontendPassword, TestData.TC_120127_NewPassword,
                    SuccessUpdate, 1, ProjectName);
                Logger.WriteDebugMessage(
                    "Password gets  updated successfully with message displayed about update on screen");

                //8.Logout from application and navigated back to login screen 
                Navigation.ClickSignOut(ProjectName);
                Logger.WriteDebugMessage("Signed Out from User's Account");
                //*Added this code as per changes for R#208647 for HotelIcon Client
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }
                Helper.ElementWait(PageObject_SignIn.Text_Email(), 60);

                //11.Try login to Application with Old Username and Password
                LoginCredentials(email, TestData.CommonFrontendPassword, ProjectName);
                string validationMessage = ExcelData.ExcelDataReader.ReadData(1, "Validation Message");
                LoginCredentials(email, TestData.CommonFrontendPassword, ProjectName);
                AddDelay(2500);
                VerifyTextOnPage(validationMessage);
                Logger.WriteDebugMessage("User should not be able to Login and a validation message should be displayed");

                if (Helper.IsElementVisible(PageObject_SignIn.Text_Email()))
                {
                    //9.Enter current Username into username field 
                    //11.Enter new password 
                    //12.Click Login or sign-in                   
                    LoginCredentials(TestData.TC_120127_Email, TestData.TC_120127_NewPassword, ProjectName);
                    MySettingWait(ProjectName);
                    if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                    {
                        string PageTitle = Driver.Title;
                        Helper.RegexFunction(PageTitle, pattern);
                    }

                    //Reset Password to original 
                    Navigation.ClickMySettings(ProjectName);
                    if (Driver.Url == MySettingsURL)
                    {
                        Logger.WriteDebugMessage("Landed on the My Settings page.");
                    }

                    MySettings.UpdateUserPasswordwithCase(TestData.TC_120127_NewPassword,
                        TestData.CommonFrontendPassword, SuccessUpdate, 1, ProjectName);
                }
                else
                {
                    Assert.Fail("Did not land on SignIn Page.");
                }
            }
        }

        public static void TC_120128()

        {
            if (TestCaseId == Constants.TC_120128)
            {
                Users data = new Users();
                //1.URL and database detail available in master test plan  run 
                //2.Log into   front end   
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }

                Queries.GetActiveMemberEmail(data);
                LoginCredentials(data.MemberEmail, TestData.CommonFrontendPassword, ProjectName);
                MySettingWait(ProjectName);
                if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                {
                    string PageTitle = Driver.Title;
                    Helper.RegexFunction(PageTitle, pattern);
                }

                //3.Click on My Setting 
                Navigation.ClickMySettings(ProjectName);
                if (Driver.Url == MySettingsURL)
                {
                    Logger.WriteDebugMessage("Landed on the My Settings page.");
                }

                //4.Enter different Username into New User Name field under Update user section 
                //5.Enter current password into "Please provide your current password *" field 
                //6.Click Update User 
                string getDate = DateTime.Now.ToString("MMddyyHHmm");
                string emailAdd = TestData.TC_120128_NewEmail + getDate + "@cendyn17.com";
                MySettings.UpdateUserEmail(emailAdd, TestData.CommonFrontendPassword, 1,
                    ProjectName);
                Logger.WriteDebugMessage(
                    "New username update successful and message displayed on screen about changed successful ");

                //7.Logout from application and navigated back to login screen 
                Navigation.ClickSignOut(ProjectName);
                Logger.WriteDebugMessage("Signed Out from User's Account");
                //*Added this code as per changes for R#208647 for HotelIcon Client
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }

                Helper.ElementWait(PageObject_SignIn.Text_Email(), 60);

                if (Helper.IsElementVisible(PageObject_SignIn.Text_Email()))
                {
                    //8.Enter new Username into username field 
                    //9.Enter current password 
                    //10.Click Login or sign-in                   
                    LoginCredentials(emailAdd, TestData.CommonFrontendPassword, ProjectName);
                    MySettingWait(ProjectName);
                    //if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                    //{
                    Logger.WriteDebugMessage("Landed on Overview Page with new credentials");
                    Navigation.ClickSignOut(ProjectName);
                    Logger.WriteDebugMessage("Signed Out from User's Account");
                    //}

                    //11.Logout and  try to login using old  user name 
                    if (ProjectName.Equals("HotelIcon"))
                    {
                        Navigation.Click_Button_SignIn();
                    }

                    LoginCredentials(data.MemberEmail, TestData.CommonFrontendPassword, ProjectName);
                    Helper.ValitionMessage(Constants.SignIn_InValidEmail);
                    Logger.WriteDebugMessage("Login should not be successful ");

                    //12.Click on forget password Enter the old user name and Click on Recover
                    SignIn.Click_Link_ForgotYourLogin(ProjectName);
                    ForgotPassword.EnterEmail(data.MemberEmail);
                    Helper.ValitionMessage(Constants.ForgotPassword_EmailNotFound);
                    Logger.WriteDebugMessage("Msg should  display that email doesn't exist. ");

                    //Reset to original Email address
                    Driver.Navigate().GoToUrl(TestData.CommonFrontendURL);
                    if (ProjectName.Equals("HotelIcon"))
                    {
                        Navigation.Click_Button_SignIn();
                    }

                    LoginCredentials(emailAdd, TestData.CommonFrontendPassword, ProjectName);
                    MySettingWait(ProjectName);
                    if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                    {
                        string PageTitle = Driver.Title;
                        Helper.RegexFunction(PageTitle, pattern);
                    }

                    Navigation.ClickMySettings(ProjectName);
                    if (Driver.Url == MySettingsURL)
                    {
                        Logger.WriteDebugMessage("Landed on the My Settings page.");
                    }

                    MySettings.UpdateUserEmail(data.MemberEmail, TestData.CommonFrontendPassword, 1,
                        ProjectName);
                }
                else
                {
                    Assert.Fail("Did not land on SignIn Page.");
                }
            }
        }

        public static void TC_120129()
        {
            if (TestCaseId == Constants.TC_120129)
            {
                Users data = new Users();
                string SuccessUpdate = Constants.UpdateSettingsMessage;
                //1.URL and database detail available in master test plan  run 
                //2.Log into   front end   
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }
                Queries.GetActiveMemberEmail(data);

                LoginCredentials(data.MemberEmail, TestData.CommonFrontendPassword, ProjectName);
                MySettingWait(ProjectName);
                if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                {
                    string PageTitle = Driver.Title;
                    Helper.RegexFunction(PageTitle, pattern);
                }

                //3.Click on My Setting 
                Navigation.ClickMySettings(ProjectName);
                {
                    Logger.WriteDebugMessage("Landed on the My Settings page.");
                }

                //4.Enter current password under update password section  
                //5.Enter New password into "New Password *" field 
                //6.Enter same password into Confirm Password field 
                //7.Click Update Password 
                //MySettings.UpdateEmailAddressandPasswordfield(TestData.TC_120126_InvalidEmail, TestData.TC_120126_UpdateEmail, TestData.TC_120126_Password, TestData.TC_120126_InvalidCurrentPassword, TestData.TC_120126_NewPassword, TestData.TC_120126_NewPassword_Confirm);
                MySettings.UpdateUserPasswordwithCase(TestData.CommonFrontendPassword, TestData.TC_120129_NewPassword,
                    SuccessUpdate, 1, ProjectName);
                Logger.WriteDebugMessage(
                    "Password gets  updated successfully with message displayed about update on screen");

                //8.Now, logout and login back to Guest Loyalty Frontend Portal and Click on My Setting 
                Navigation.ClickSignOut(ProjectName);
                Logger.WriteDebugMessage("Signed Out from User's Account");
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }

                Helper.ElementWait(PageObject_SignIn.Text_Email(), 60);

                if (Helper.IsElementVisible(PageObject_SignIn.Text_Email()))
                {
                    LoginCredentials(data.MemberEmail, TestData.TC_120129_NewPassword, ProjectName);
                    MySettingWait(ProjectName);
                    if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                    {
                        string PageTitle = Driver.Title;
                        Helper.RegexFunction(PageTitle, pattern);
                    }

                    Navigation.ClickMySettings(ProjectName);
                    {
                        Logger.WriteDebugMessage("Landed on the My Settings page.");
                    }

                    //9.Enter original Password into New  Password and confirm password  field under Update password section  
                    //10.Click Update Password 
                    MySettings.UpdateUserPasswordwithCase(TestData.TC_120129_NewPassword,
                        TestData.CommonFrontendPassword, SuccessUpdate, 1, ProjectName);
                    Logger.WriteDebugMessage(
                        "Password update successfully with message displayed about update on screen");

                    //11.Logout and login back in using the updated password  
                    Navigation.ClickSignOut(ProjectName);
                    Logger.WriteDebugMessage("Signed Out from User's Account");
                    //*Added this code as per changes for R#208647 for HotelIcon Client*
                    if (ProjectName.Equals("HotelIcon"))
                    {
                        Navigation.Click_Button_SignIn();
                    }

                    LoginCredentials(data.MemberEmail, TestData.CommonFrontendPassword, ProjectName);
                    MySettingWait(ProjectName);
                    if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                    {
                        string PageTitle = Driver.Title;
                        Helper.RegexFunction(PageTitle, pattern);
                    }
                }
                else
                {
                    Assert.Fail("Did not land on SignIn Page.");
                }
            }
        }

        public static void TC_120130()
        {
            if (TestCaseId == Constants.TC_120130)
            {
                Users data = new Users();
                //1.URL and database detail available in master test plan  run 
                //2.Log into   front end  
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }
                Queries.GetActiveMemberEmail(data);
                LoginCredentials(data.MemberEmail, TestData.CommonFrontendPassword, ProjectName);
                MySettingWait(ProjectName);
                if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                {
                    string PageTitle = Driver.Title;
                    Helper.RegexFunction(PageTitle, pattern);
                }

                //3.Click on My Settings
                Navigation.ClickMySettings(ProjectName);
                Logger.WriteDebugMessage("Landed on the My Settings page.");

                //4.Enter different Username into New User Name field under Update user section 
                //5.Enter current password into "Please provide your current password *" field 
                //6.Click Update User 
                string getDate = DateTime.Now.ToString("MMddyyHHmm");
                string emailAdd = TestData.TC_120130_NewEmail + getDate + "@cendyn17.com";
                MySettings.UpdateUserEmail(emailAdd, TestData.CommonFrontendPassword, 1,
                    ProjectName);
                Logger.WriteDebugMessage(
                    "New username gets updated successfully  and message displayed on screen about changed successful ");

                Navigation.ClickSignOut(ProjectName);
                Logger.WriteDebugMessage("Signed Out from User's Account");
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }

                Helper.ElementWait(PageObject_SignIn.Text_Email(), 60);

                if (Helper.IsElementVisible(PageObject_SignIn.Text_Email()))
                {
                    //7.Verify the  user name email address in  users table 
                    //8.Verify the email in memberships table 
                    //9.Verify the email in D_customer table 
                    //string DCEmail = Queries.ReturnDCustomerEmail(TestData.MySettingsFrontendEmail);
                    Queries.ReturnDCustomerEmail_Test(emailAdd, data);
                    string MSEmail = Queries.ReturnMSCustomerEmail(emailAdd);
                    string UEmail = Queries.ReturnUCustomerEmail(emailAdd);

                    if (data.eMail == emailAdd && MSEmail == emailAdd &&
                        UEmail == emailAdd)
                    {
                        Logger.WriteDebugMessage("Landed on the My Settings page.");
                    }
                    else
                    {
                        Logger.WriteDebugMessage("Email Address didn't match in one the table.");
                        TestHandling.TestEnd();
                    }

                    //Reset to Original Credentials                                        
                    LoginCredentials(emailAdd, TestData.CommonFrontendPassword, ProjectName);
                    MySettingWait(ProjectName);
                    if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                    {
                        string PageTitle = Driver.Title;
                        Helper.RegexFunction(PageTitle, pattern);
                    }

                    Navigation.ClickMySettings(ProjectName);
                    Logger.WriteDebugMessage("Landed on the My Settings page.");
                    MySettings.UpdateUserEmail(TestData.TC_120130_Email, TestData.CommonFrontendPassword, 1,
                        ProjectName);
                }
                else
                {
                    Assert.Fail("Did not land on SignIn Page.");
                }
            }
        }

        public static void TC_120131()
        {
            if (TestCaseId == Constants.TC_120131)
            {
                //1.URL and database detail available in master test plan  run 
                //2.Log into   front end  
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }

                LoginCredentials(TestData.TC_120131_Email, TestData.CommonFrontendPassword, ProjectName);
                MySettingWait(ProjectName);
                if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                {
                    string PageTitle = Driver.Title;
                    Helper.RegexFunction(PageTitle, pattern);
                }

                //3.Click on My Setting 
                Navigation.ClickMySettings(ProjectName);
                Logger.WriteDebugMessage("Landed on the My Settings page.");

                //4.Enter different Username into New User Name field under Update user section 
                //5.Enter current password into "Please provide your current password *" field 
                //6.Click Update User 
                MySettings.UpdateUserEmail(TestData.TC_120131_NewEmail, TestData.CommonFrontendPassword, 1,
                    ProjectName);
                Logger.WriteDebugMessage(
                    "New username update successful and message displayed on screen about changed successful ");

                //7.Logout from application and navigated back  using new username                 
                Navigation.ClickSignOut(ProjectName);
                Logger.WriteDebugMessage("Signed Out from User's Account");
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }

                Helper.ElementWait(PageObject_SignIn.Text_Email(), 60);

                if (Helper.IsElementVisible(PageObject_SignIn.Text_Email()))
                {
                    LoginCredentials(TestData.TC_120131_NewEmail, TestData.CommonFrontendPassword, ProjectName);
                    MySettingWait(ProjectName);
                    if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                    {
                        string PageTitle = Driver.Title;
                        Helper.RegexFunction(PageTitle, pattern);
                    }

                    if (ProjectName != "AdareManor")
                    {
                        //8.Navigate to Contact Us page and send an email
                        //9.verify the email is the new updated email address  in email content  
                        Navigation.Click_Link_ContactUs(ProjectName);
                        Logger.WriteDebugMessage("Landed on Contact Us Page.");
                        string GetCurrentEmailAddress = Helper.Getdata(PageObject_ContactUs.Text_EmailAddress());
                        if (TestData.TC_120131_NewEmail == GetCurrentEmailAddress)
                        {
                            Logger.WriteDebugMessage("Email Address is updated successfully.");
                        }
                        else
                        {
                            Logger.WriteDebugMessage("Email Address didn't match with the text box.");
                            TestHandling.TestEnd();
                        }
                    }

                    //Reset to Original Credentials
                    Navigation.ClickMySettings(ProjectName);
                    Logger.WriteDebugMessage("Landed on the My Settings page.");

                    MySettings.UpdateUserEmail(TestData.TC_120131_Email, TestData.CommonFrontendPassword, 1,
                        ProjectName);
                }
                else
                {
                    Assert.Fail("Did not land on SignIn Page.");
                }
            }
        }

        public static void TC_120132()
        {
            if (TestCaseId == Constants.TC_120132)
            {
                Users data = new Users();
                //1.URL and database detail available in master test plan  run 
                //2.Log into   front end
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon")
                {
                    Navigation.Click_Button_SignIn();
                }

                Queries.GetActiveMemberEmail(data);
                LoginCredentials(data.MemberEmail, TestData.CommonFrontendPassword, ProjectName);
                MySettingWait(ProjectName);
                if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                {
                    string PageTitle = Driver.Title;
                    Helper.RegexFunction(PageTitle, pattern);
                }

                //3.Click on My Setting 
                Navigation.ClickMySettings(ProjectName);
                Logger.WriteDebugMessage("Landed on the My Settings page.");

                //4.Enter different Username into New User Name field under Update user section 
                //5.Enter current password into "Please provide your current password *" field 
                //6.Click Update User 
                string getDate = DateTime.Now.ToString("MMddyyHHmm");
                string emailAdd = TestData.TC_120132_NewEmail + getDate + "@cendyn17.com";
                MySettings.UpdateUserEmail(emailAdd, TestData.CommonFrontendPassword, 1,
                    ProjectName);
                Logger.WriteDebugMessage(
                    "New username update successful and message displayed on screen about changed successful ");

                //7.Logout from application and navigated back to login screen 
                Navigation.ClickSignOut(ProjectName);
                Logger.WriteDebugMessage("Signed Out from User's Account");
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }

                Helper.ElementWait(PageObject_SignIn.Text_Email(), 60);

                if (Helper.IsElementVisible(PageObject_SignIn.Text_Email()))
                {

                    //8.Click on forget password. Enter the old user name and Click on Recover
                    SignIn.Click_Link_ForgotYourLogin(ProjectName);
                    if (!Driver.Url.Contains("PasswordRecovery"))
                    {
                        AddDelay(10000);
                    }
                    else if (Driver.Url.Contains("PasswordRecovery"))
                    {
                        Logger.WriteDebugMessage("Landed on the Password Recovery page.");

                        string ValidationMessage = "Email not found, try another email";
                        //9.Enter the updated user name  and click on recover 
                        //10.Password recovery email sent to guest  and should be available in catchall 
                        ForgotPassword.UpdateEmail(data.MemberEmail, ValidationMessage, 2);

                        AddDelay(7000);
                        ForgotPassword.ClickCancel();
                        SignIn.Click_Link_ForgotYourLogin(ProjectName);

                        if (!Helper.IsElementVisible(PageObject_ForgotPassword.ForgotPassword_Recover()))
                        {
                            Helper.ElementWait(PageObject_ForgotPassword.ForgotPassword_Recover(), 60);
                        }
                        else if (Helper.IsElementVisible(PageObject_ForgotPassword.ForgotPassword_Recover()))
                        {
                            ValidationMessage =
                                "Email with instructions has been sent to you. Please check your email to reset your new password.";
                            ForgotPassword.UpdateEmail(emailAdd, ValidationMessage, 1);

                            AddDelay(15000);
                            Email.LogIntoCatchAll(); //  Logged into Hotmail Account
                            Email.CatchAll_SearchEmailAndOpenLatestMessage(emailAdd); // Searched for the email

                            Email.ForgotPasswordEmail_Check();

                            //Reset to Original Credentials
                            TestHandling.NavigateToURL(TestData.CommonFrontendURL);
                            //*Added this code as per changes for R#208647 for HotelIcon Client*
                            if (ProjectName.Equals("HotelIcon"))
                            {
                                Navigation.Click_Button_SignIn();
                            }

                            LoginCredentials(emailAdd, TestData.CommonFrontendPassword, ProjectName);
                            MySettingWait(ProjectName);
                            if (Driver.Url == LoginLand ||
                                Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                            {
                                string PageTitle = Driver.Title;
                                Helper.RegexFunction(PageTitle, pattern);
                            }

                            Navigation.ClickMySettings(ProjectName);
                            Logger.WriteDebugMessage("Landed on the My Settings page.");
                            MySettings.UpdateUserEmail(data.MemberEmail, TestData.CommonFrontendPassword, 1,
                                ProjectName);
                        }
                        else
                        {
                            Assert.Fail("Did not land on ForgotPassword Page.");
                        }
                    }
                }
                else
                {
                    TestHandling.TestFailed(new Exception("Did not land on Password Reset Page."));
                }
            }
        }

        public static void TC_120133()
        {
            if (TestCaseId == Constants.TC_120133)
            {
                Users data = new Users();
                //1.URL and database detail available in master test plan  run 
                //2.Log into   front end  
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }

                Queries.GetActiveMemberEmail(data);
                LoginCredentials(data.MemberEmail, TestData.CommonFrontendPassword, ProjectName);
                MySettingWait(ProjectName);
                if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                {
                    string PageTitle = Driver.Title;
                    Helper.RegexFunction(PageTitle, pattern);
                }

                //3.Click on My Setting 
                Navigation.ClickMySettings(ProjectName);
                Logger.WriteDebugMessage("Landed on the My Settings page.");

                //4.Enter different Username into New User Name field under Update user section 
                //5.Enter current password into "Please provide your current password *" field 
                //6.Click Update User 
                //MySettings.UpdateEmailAddressandPasswordfield(TestData.TC_120126_InvalidEmail, TestData.TC_120126_UpdateEmail, TestData.TC_120126_Password, TestData.TC_120126_InvalidCurrentPassword, TestData.TC_120126_NewPassword, TestData.TC_120126_NewPassword_Confirm);
                int ranNo = randomNumber.Next();
                string UserName = String.Concat("qa", ranNo.ToString(), "@cendyn17.com");
                MySettings.UpdateUserEmail(UserName, TestData.CommonFrontendPassword, 1,
                    ProjectName);
                Logger.WriteDebugMessage(
                    "New username update successful and message displayed on screen about changed successful ");

                //22.Logout from application and navigated back to login screen 
                //Navigation.ClickSignOut(ProjectName);
                //AddDelay(3000);
                //Logger.WriteDebugMessage("User is navigated to login screen ");
                Navigation.ClickSignOut(ProjectName);
                Logger.WriteDebugMessage("Signed Out from User's Account");
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }

                Helper.ElementWait(PageObject_SignIn.Text_Email(), 60);

                if (Helper.IsElementVisible(PageObject_SignIn.Text_Email()))
                {

                    if ((ProjectName != "HotelIcon"))
                        if ((ProjectName != "Loews"))
                        {
                            TestHandling.NavigateToURL(TestData.CommonAdminURL);
                            Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                            //7.In new tab login  to admin  
                            AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                            AddDelay(15000);
                            Logger.WriteDebugMessage("member search page gets displayed ");

                            if (Driver.Url.Contains(TestData.CommonAdminURL))
                            {
                                //8.Search for old  user name 
                                Admin.SearchOldEmail(data.MemberEmail, ProjectName);
                                VerifyTextOnPageAndHighLight("No member data available, please update search.");
                                Logger.WriteDebugMessage("Email Address with " + data.MemberEmail +
                                                         " does not exist.");

                                //9.Search for new email address  
                                //10.Click on view icon 
                                Admin.SearchEmail(UserName, ProjectName);
                                Logger.WriteDebugMessage("New Email Address with " + UserName +
                                                         " found in database.");
                                if (Driver.Url.Contains(TestData.CommonAdminURL))
                                {
                                    Helper.ValitionMessage(UserName);
                                    if (PageObject_Admin.Admin_Button_ViewMember(ProjectName).Displayed)
                                    {
                                        Admin.Click_Icon_View(ProjectName);
                                    }

                                    AddDelay(2500);
                                    Logger.WriteDebugMessage("Landed on Member information.");
                                    Admin.Admin_ActivationEmail(UserName);
                                    Admin.Admin_Button_Activation_Save();
                                    Logger.WriteDebugMessage(
                                        "Activation Email sent to " + UserName + ".");
                                }

                                Helper.OpenNewTab();
                                Driver.Navigate().GoToUrl(TestData.CommonAdminURL);

                                //11. Verify the email address 
                                //12. Verify the email  that display on click of  Activation email - Resend link 
                                Email.LogIntoCatchAll(); //  Logged into Hotmail Account
                                Email.CatchAll_SearchEmailAndOpenLatestMessage(UserName); // Searched for the email
                                                                                          // Email.ActivationEmail_Check(ProjectName);
                                Logger.WriteDebugMessage("updated user name should get displayed ");
                                Helper.CloseCurrentTab();
                                Helper.ControlToPreviousWindow();

                                if (Driver.Url.Contains(TestData.CommonAdminURL))
                                {
                                    Admin.Admin_WelcomeEmail(UserName);
                                    Admin.Admin_Button_Welcome_Save();
                                    Logger.WriteDebugMessage(
                                        "Welcome Email sent to " + UserName + ".");
                                }

                                //13. Verify the email  that display on click of Welcome email resend 
                                //14. Verify the email  that display on click of Member Login  Reset ​
                                Helper.OpenNewTab();
                                Driver.Navigate()
                                    .GoToUrl(
                                        "https://outlook.office365.com/owa/?realm=cendyn17.com&exsvurl=1&ll-cc=1033&modurl=0");
                                Email.CatchAll_SearchEmailAndOpenLatestMessage(UserName); // Searched for the email
                                Email.WelcomeEmail_Check(ProjectName);
                                Logger.WriteDebugMessage("user gets auto logged in to the portal  in a new tab ");
                                Helper.CloseCurrentTab();
                                Helper.ControlToPreviousWindow();
                            }
                        }

                    //Reset to Original Credentials
                    Helper.ReloadPage();
                    AddDelay(5000);
                    Driver.Navigate().GoToUrl(TestData.CommonFrontendURL);
                    //*Added this code as per changes for R#208647 for HotelIcon Client*
                    if (ProjectName.Equals("HotelIcon"))
                    {
                        Navigation.Click_Button_SignIn();
                    }

                    LoginCredentials(UserName, TestData.CommonFrontendPassword, ProjectName);
                    MySettingWait(ProjectName);
                    if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                    {
                        string PageTitle = Driver.Title;
                        Helper.RegexFunction(PageTitle, pattern);
                    }

                    Navigation.ClickMySettings(ProjectName);
                    Logger.WriteDebugMessage("Landed on the My Settings page.");
                    MySettings.UpdateUserEmail(data.MemberEmail, TestData.CommonFrontendPassword, 1,
                        ProjectName);
                }
                else
                {
                    Assert.Fail("Did not land on SignIn Page.");
                }

            }
        }

        public static void TC_120134()
        {
            if (TestCaseId == Constants.TC_120134)
            {
                string ReturnResult;
                //1.URL is available in Test plan description
                //2.Data Requirement: Registered email
                //3.Navigate to Sign in page
                //4.Enter the credential and Sign in
                ReturnResult = Constants.ValidationMessageInvalidFormat;
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }

                LoginCredentials(TestData.TC_120134_Email, TestData.CommonFrontendPassword, ProjectName);
                MySettingWait(ProjectName);
                if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                {
                    string PageTitle = Driver.Title;
                    Helper.RegexFunction(PageTitle, pattern);
                }

                Navigation.ClickMySettings(ProjectName);
                Logger.WriteDebugMessage("Landed on the My Settings page.");

                //5.Navigate to Update Password screen
                //6.Enter Old password New Password and Confirm password as 'ccendyn1' ( no upper case) and submit
                string ValidationMessage = Constants.PasswordValidationMessage;
                MySettings.UpdateUserPasswordwithCase(TestData.CommonFrontendPassword, TestData.TC_120134_NewPassword1,
                    ValidationMessage, 1, ProjectName);
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage(
                    "Update Password should not be successful. Validation msg 'The password is case sensitive and must contain eight or more characters, one uppercase letter, one lowercase letter, and one digit.'");

                //7.Enter Password and Confirm password as 'CCENDYN1' ( no lowercase case) and submit
                Helper.ReloadPage();
                MySettings.UpdateUserPasswordwithCase(TestData.CommonFrontendPassword, TestData.TC_120134_NewPassword2,
                    ValidationMessage, 1, ProjectName);
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage(
                    "Update Password should not be successful. Validation msg 'The password is case sensitive and must contain eight or more characters, one uppercase letter, one lowercase letter, and one digit.'");

                //8.Enter Password and Confirm password as 'cCCENDYN' ( no digit) and submit
                Helper.ReloadPage();
                MySettings.UpdateUserPasswordwithCase(TestData.CommonFrontendPassword, TestData.TC_120134_NewPassword3,
                    ValidationMessage, 1, ProjectName);
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage(
                    "Update Password should not be successful. Validation msg 'The password is case sensitive and must contain eight or more characters, one uppercase letter, one lowercase letter, and one digit.'");

                //9.Enter Password and Confirm password as 'Cendyn1' ( not 8 character ) and submit
                Helper.ReloadPage();
                MySettings.UpdateUserPasswordwithCase(TestData.CommonFrontendPassword, TestData.TC_120134_NewPassword4,
                    ValidationMessage, 1, ProjectName);
                Helper.AddDelay(5000);
                Logger.WriteDebugMessage(
                    "Update Password should not be successful. Validation msg 'The password is case sensitive and must contain eight or more characters, one uppercase letter, one lowercase letter, and one digit.'");
            }

        }

        public static void TC_120135()
        {
            if (TestCaseId == Constants.TC_120135)
            {
                string ReturnResult;
                //1.URL is available in Test plan description
                //2.Data Requirement: Registered email
                //3.Navigate to Sign in page
                //4.Enter the credential and Sign in   
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }

                LoginCredentials(TestData.TC_120135_Email, TestData.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("Sign in was successful");
                MySettingWait(ProjectName);
                if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                {
                    string PageTitle = Driver.Title;
                    Helper.RegexFunction(PageTitle, pattern);
                }

                //5.Navigate to Update Password screen
                Navigation.ClickMySettings(ProjectName);
                Logger.WriteDebugMessage("Landed on the My Settings page.");
                Logger.WriteDebugMessage("User navigate to Update Password page");

                //6.Enter mismatch detail in New password and Confirm Password Click on submit
                ReturnResult = Constants.MySettingPasswordMismatch;

                MySettings.UpdateUserPasswordwithCase(TestData.CommonFrontendPassword, TestData.TC_120135_Password,
                    ReturnResult, 2, ProjectName);
                Logger.WriteDebugMessage("Message confirming that password fields are not matching should display.");
            }
        }

        public static void TC_120136()
        {
            if (TestCaseId == Constants.TC_120136)
            {
                string ReturnResult;
                //1.URL is available in Test plan description
                //2.Data Requirement: Registered email
                //3.Navigate to Sign in page
                //4.Enter the credential and Sign in 
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }

                LoginCredentials(TestData.TC_120136_Email, TestData.TC_120136_Password, ProjectName);
                MySettingWait(ProjectName);
                if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                {
                    string PageTitle = Driver.Title;
                    Helper.RegexFunction(PageTitle, pattern);
                }

                //5.Navigate to Update Password screen
                Navigation.ClickMySettings(ProjectName);
                Logger.WriteDebugMessage("Landed on the My Settings page.");

                //6.Enter Old Password - Enter Password and Confirm password as 'Cendyn123$'(with sp character) and Click on update
                ReturnResult = Constants.UpdateSettingsMessage;
                MySettings.UpdateUserPasswordwithCase(TestData.TC_120136_Password, TestData.CommonFrontendPassword,
                    ReturnResult, 1, ProjectName);
                Logger.WriteDebugMessage("Password Reset should be successful");

                //7.Logout and Log back using old credential
                Navigation.ClickSignOut(ProjectName);
                Logger.WriteDebugMessage("Signed Out from User's Account");
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }

                Helper.ElementWait(PageObject_SignIn.Text_Email(), 60);
                if (Helper.IsElementVisible(PageObject_SignIn.Text_Email()))
                {
                    LoginCredentials(TestData.TC_120136_Email, TestData.TC_120136_Password, ProjectName);
                    AddDelay(1500);
                    if (!Helper.VerifyTextOnPage(Constants.SignIn_InValidPass))
                    {
                        throw new Exception("Wrong Validation message when entering with old password in login page. ");
                    }
                    else
                    {
                        //8.Login in using new credential
                        LoginCredentials(TestData.TC_120136_Email, TestData.CommonFrontendPassword, ProjectName);
                        MySettingWait(ProjectName);
                        if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                        {
                            string PageTitle = Driver.Title;
                            Helper.RegexFunction(PageTitle, pattern);
                        }

                        //9.Navigate to Update Password screen
                        Navigation.ClickMySettings(ProjectName);
                        Logger.WriteDebugMessage("Landed on the My Settings page.");

                        //10.update password by entering the new and confirm password as 'CCendyn1'
                        MySettings.UpdateUserPasswordwithCase(TestData.CommonFrontendPassword,
                            TestData.TC_120136_NewPassword, ReturnResult, 1, ProjectName);
                        Logger.WriteDebugMessage("Password Reset should be successful");

                        //Reset to Original Password
                        MySettings.UpdateUserPasswordwithCase(TestData.TC_120136_NewPassword,
                            TestData.TC_120136_Password, ReturnResult, 1, ProjectName);
                    }
                }
                else
                {
                    Assert.Fail("Did not land on SignIn Page.");
                }
            }
        }

        public static void TC_120137()
        {
            if (TestCaseId == Constants.TC_120137)
            {
                Users data = new Users();
                //1.URL is available in Test plan description
                //2.Data Requirement: Registered email and its password
                //3.Navigate to Sign in page 
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }

                Queries.GetActiveMemberEmail(data);
                LoginCredentials(data.MemberEmail, TestData.CommonFrontendPassword, ProjectName);
                MySettingWait(ProjectName);
                if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                {
                    string PageTitle = Driver.Title;
                    Helper.RegexFunction(PageTitle, pattern);
                }

                //4.Navigate to Update Password screen
                Navigation.ClickMySettings(ProjectName);
                Logger.WriteDebugMessage("Landed on the My Settings page.");

                //5.Enter Old , New and Confirm password as credential used while logging in and Click on update
                string ReturnResultSamePass = Constants.NewPasswordCannotBeSameMessage;
                MySettings.UpdateUserPasswordwithCase(TestData.CommonFrontendPassword, TestData.CommonFrontendPassword,
                    ReturnResultSamePass, 1, ProjectName);
                Logger.WriteDebugMessage("Password update should not be successful");
            }
        }

        public static void TC_125818()
        {
            if (TestCaseId == Constants.TC_125818)
            {
                Users data = new Users();
                //Data Condition:
                //1.Identify PMS profile who has stay
                //2.Navigate to Sign in page
                //3.Click on Sign up
                //4.Enter all mandatory fields by keying in the data identified with same name but different email
                //5.Click on Sign up
                //6.Verify the activation email is available in catchall
                //8.Click on the link  provided to confirm the link               
                Queries.ReturnGuestEmailInPMSProfileisNotMember(data);
                Navigation.Navigation_SignUpbtn();
                AddDelay(2500);
                string email = MakeCatchAllUnique(TestData.TC_125818_Email);
                SignUp.SucessfulSignUp(data.firstName, data.lastName, email, TestData.TC_125818_Password, ProjectName);
                Email.LogIntoCatchAll();
                Email.CatchAll_SearchEmailAndOpenLatestMessage(email);
                Email.ActivationEmail_Check(ProjectName);
                Logger.WriteDebugMessage("The activation email was received.");
                Email.ActivationEmail_ClickLink(ProjectName);
                AddDelay(7000);
                Logger.WriteDebugMessage("Confirmation message regarding account being confirmed is displayed.");
                ControlToNewWindow();

                //9.Log into  front end  as user conditioned as explained in Description                 
                LoginCredentials(email, TestData.TC_125818_Password, ProjectName);
                MySettingWait(ProjectName);
                if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                {
                    string PageTitle = Driver.Title;
                    Helper.RegexFunction(PageTitle, pattern);
                }

                //10.Click on My Setting 
                Navigation.ClickMySettings(ProjectName);
                if (Driver.Url == MySettingsURL)
                {
                    Logger.WriteDebugMessage("Landed on the My Settings page.");
                }

                //11. Update the email so that it matches with PMS  email identified in step 2               
                MySettings.UpdateUserEmail(data.eMail, TestData.TC_125818_Password, 1, ProjectName);
                Logger.WriteDebugMessage(
                    "New username gets updated successfully and message displayed on screen about changed successful ");

                //12.Wait for 20 mins and then navigate to My Stay Page
                Navigation.ClickSignOut(ProjectName);
                Logger.WriteDebugMessage("Signed Out from User's Account");
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }

                Helper.ElementWait(PageObject_SignIn.Text_Email(), 60);

                if (Helper.IsElementVisible(PageObject_SignIn.Text_Email()))
                {
                    LoginCredentials(data.eMail, TestData.TC_125818_Password, ProjectName);
                    MySettingWait(ProjectName);
                    if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                    {
                        string PageTitle = Driver.Title;
                        Helper.RegexFunction(PageTitle, pattern);
                    }

                    Navigation.ClickMySettings(ProjectName);
                    if (Driver.Url == MySettingsURL)
                    {
                        Logger.WriteDebugMessage("Landed on the My Settings page.");
                    }


                    //8.Verify stays gets displayed in My stay
                    confirmationNumber =
                        Queries.ReturnValueFromColumnByCustomerID(data.CustomerID, "ReservationNumber");
                    Navigation.Click_Link_MyStays();
                    Time.AddDelay(1500000);
                    MyStays.UpcomingStays_VerifyConfirmationNumberDisplays(confirmationNumber, "", 0);
                    Logger.WriteDebugMessage("Stays should be displayed in My Stay grid depending on departure date");
                }
                else
                {
                    Assert.Fail("Did not land on SignIn Page.");
                }
            }
        }

        public static void TC_166273()
        {
            if (TestCaseId == Constants.TC_166273)
            {
                //1.URL and database detail available in master test plan  run 
                //2.Log into  front end  as   PMS User 
                string PMSCustomerEmail = Queries.ReturnPMSCustomerEmail();
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }

                LoginCredentials(PMSCustomerEmail, TestData.CommonFrontendPassword, ProjectName);
                MySettingWait(ProjectName);
                if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                {
                    string PageTitle = Driver.Title;
                    Helper.RegexFunction(PageTitle, pattern);
                }

                //3.Click on My Setting 
                Navigation.ClickMySettings(ProjectName);
                if (Driver.Url == MySettingsURL)
                {
                    Logger.WriteDebugMessage("Landed on the My Settings page.");
                }

                //4.Enter  Username  that is linked to another memberid into New User Name field under Update user section                           
                MySettings.UpdateUserEmail(TestData.TC_166273_AlreadyExistsEmail, TestData.CommonFrontendPassword, 2, ProjectName);
                Logger.WriteDebugMessage(
                    "Validation msg is expected to get displayed. Saying  that email is already in use and is tied to another member");
            }
        }

        public static void TC_166274()
        {
            if (TestCaseId == Constants.TC_166274)
            {
                //1.URL and database detail available in master test plan  run 
                //2.Log into  front end  as   PMS User 
                string invalidEmail = "Cendyn";
                string invalidEmail1 = "Cendyn.gmail.com";
                string invalidEmail2 = "Cendyn2gmail.com";
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }

                LoginCredentials(TestData.TC_166274_Email, TestData.TC_166274_Password, ProjectName);
                MySettingWait(ProjectName);
                if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                {
                    string PageTitle = Driver.Title;
                    Helper.RegexFunction(PageTitle, pattern);
                }

                //3.Click on My Setting 
                Navigation.ClickMySettings(ProjectName);
                if (Driver.Url == MySettingsURL)
                {
                    Logger.WriteDebugMessage("Landed on the My Settings page.");
                }

                //4.Enter  Username  that is linked to another memberid into New User Name field under Update user section                           
                MySettings.UpdateUserEmail(invalidEmail, TestData.CommonFrontendPassword, 3, ProjectName);
                MySettings.UpdateUserEmail(invalidEmail1, TestData.CommonFrontendPassword, 3, ProjectName);
                MySettings.UpdateUserEmail(invalidEmail2, TestData.CommonFrontendPassword, 3, ProjectName);
                Logger.WriteDebugMessage(
                    "Validation msg is expected to get displayed. Saying  that email is already in use and is tied to another member");
            }
        }

        public static void TC_166279()
        {
            if (TestCaseId == Constants.TC_166279)
            {
                //1.URL and database detail available in master test plan  run 
                //2.Log into  front end  as   PMS User 
                string PMSCustomerEmail = Queries.ReturnPMSCustomerEmail();
                string GetDate = DateTime.Now.ToString("MMddyyHHmm");
                string PMSCustomerEmailNew =
                    "   " + (regexfunction(PMSCustomerEmail) + GetDate + "@cendyn17.com") + "   ";
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }
                PMSCustomerEmail = Queries.ReturnPMSCustomerEmail();
                LoginCredentials(PMSCustomerEmail, TestData.CommonFrontendPassword, ProjectName);
                MySettingWait(ProjectName);
                if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                {
                    string PageTitle = Driver.Title;
                    Helper.RegexFunction(PageTitle, pattern);
                }

                //3.Click on My Setting 
                Navigation.ClickMySettings(ProjectName);
                if (Driver.Url == MySettingsURL)
                {
                    Logger.WriteDebugMessage("Landed on the My Settings page.");
                }

                //4. Enter different Username  with leading space and trial space into New User Name field under Update user section 
                //5. Enter current password into "Please provide your current password *" field 
                //6. Click Update User                
                PMSCustomerEmailNew = (regexfunction(PMSCustomerEmail) + GetDate + "@cendyn17.com");
                MySettings.UpdateUserEmail(PMSCustomerEmailNew, TestData.CommonFrontendPassword, 1, ProjectName);
                Logger.WriteDebugMessage(
                    "New username gets updated successfully and message displayed on screen about changed successful ");

                //7.logout and Login back using updated user name and password 
                Navigation.ClickSignOut(ProjectName);
                Logger.WriteDebugMessage("Signed Out from User's Account");
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }

                Helper.ElementWait(PageObject_SignIn.Text_Email(), 60);
                PMSCustomerEmailNew = (regexfunction(PMSCustomerEmail) + GetDate + "@cendyn17.com");
                if (Helper.IsElementVisible(PageObject_SignIn.Text_Email()))
                {
                    LoginCredentials(PMSCustomerEmailNew, TestData.CommonFrontendPassword, ProjectName);
                    MySettingWait(ProjectName);
                    if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                    {
                        string PageTitle = Driver.Title;
                        Helper.RegexFunction(PageTitle, pattern);
                    }

                    Navigation.ClickMySettings(ProjectName);
                    if (Driver.Url == MySettingsURL)
                    {
                        Logger.WriteDebugMessage("Landed on the My Settings page.");
                    }
                }
                else
                {
                    Assert.Fail("Did not land on SignIn Page.");
                }
            }
        }

        public static void TC_166283()
        {
            if (TestCaseId == Constants.TC_166283)
            {
                Users data = new Users();
                //Data Condition:
                //1.Identify PMS profile who has stay   and is not a member
                //2.Register with same name but different email 
                Queries.ReturnGuestEmailInPMSProfileisNotMember(data);
                Navigation.Navigation_SignUpbtn();
                AddDelay(2500);
                string email = MakeCatchAllUnique(TestData.TC_166283_Email);
                SignUp.SucessfulSignUp(data.firstName, data.lastName, email, TestData.TC_166283_Password, ProjectName);
                Email.LogIntoCatchAll();
                Email.CatchAll_SearchEmailAndOpenLatestMessage(email);
                Email.ActivationEmail_Check(ProjectName);
                Logger.WriteDebugMessage("The activation email was received.");
                Email.ActivationEmail_ClickLink(ProjectName);
                AddDelay(7000);
                Logger.WriteDebugMessage("Confirmation message regarding account being confirmed is displayed.");
                ControlToNewWindow();

                //1.URL and database detail available in master test plan  run 
                //2.Log into  front end  as user conditioned as explained in Description 
                //SignIn.Click_Link_Login();
                LoginCredentials(email, TestData.TC_166283_Password, ProjectName);
                MySettingWait(ProjectName);
                if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                {
                    string PageTitle = Driver.Title;
                    Helper.RegexFunction(PageTitle, pattern);
                }

                //3.Click on My Setting 
                Navigation.ClickMySettings(ProjectName);
                if (Driver.Url == MySettingsURL)
                {
                    Logger.WriteDebugMessage("Landed on the My Settings page.");
                }

                //4. Enter  email Username   that is identified in query in description into New User Name field under Update user section 
                //5. Enter current password into "Please provide your current password *" field 
                //6. Click Update User                
                MySettings.UpdateUserEmail(data.eMail, TestData.TC_166283_Password, 1, ProjectName);
                Logger.WriteDebugMessage(
                    "New username gets updated successfully and message displayed on screen about changed successful ");

                //7.logout and Login back using updated user name and password 
                Navigation.ClickSignOut(ProjectName);
                Logger.WriteDebugMessage("Signed Out from User's Account");
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                /*if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }*

                //Helper.ElementWait(PageObject_SignIn.Text_Email(), 60);

                if (Helper.IsElementVisible(PageObject_SignIn.Text_Email()))
                {
                    LoginCredentials(data.eMail, TestData.TC_166283_Password, ProjectName);
                    MySettingWait(ProjectName);
                    if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                    {
                        string PageTitle = Driver.Title;
                        Helper.RegexFunction(PageTitle, pattern);
                    }

                    Navigation.ClickMySettings(ProjectName);
                    if (Driver.Url == MySettingsURL)
                    {
                        Logger.WriteDebugMessage("Landed on the My Settings page.");
                    }


                    //8.After 20 to 30 minutes verify the stay is linked to the  account 
                    confirmationNumber =
                        Queries.ReturnValueFromColumnByCustomerID(data.CustomerID, "ReservationNumber");
                    Navigation.Click_Link_MyStays();
                    Time.AddDelay(1500000);
                    MyStays.UpcomingStays_VerifyConfirmationNumberDisplays(confirmationNumber, "", 0);
                    Logger.WriteDebugMessage("The stay is displayed!");
                }
                else
                {
                    Assert.Fail("Did not land on SignIn Page.");
                }
            }
        }

        public static void TC_166288()
        {
            if (TestCaseId == Constants.TC_166288)
            {
                //1.URL and database detail available in master test plan run
                //2.Log into  front end  as  non PMS User        
                Navigation.Click_Link_Facebook();
                ControlToNewWindow();
                AddDelay(5000);
                SignIn.LogInUsingFacebook(TestData.TC_166288_Email, TestData.TC_166288_Password);
                AddDelay(20000);
                ControlToPreviousWindow();
                MySettingWait(ProjectName);
                if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                {
                    Logger.WriteDebugMessage("Landed on Benifit Page.");
                }

                //3.Click on My Setting 
                Navigation.ClickMySettings(ProjectName);
                if (Driver.Url == MySettingsURL)
                {
                    Logger.WriteDebugMessage("Landed on the My Settings page.");
                }

                //4.Enter current password under update password section
                ValidateTextAbsentOnPage("Update Password");
                Logger.WriteDebugMessage("Section should not get displayed or the fields should greyed out");

                //5.Enter different Username into New User Name field under Update user section 
                string email = MakeCatchAllUnique(TestData.TC_166288_Email);
                MySettings.UpdateUserEmail(email, TestData.TC_166288_Password, 4, ProjectName);
                Logger.WriteDebugMessage("Section should not get displayed or the field should get greyed out ");
            }
        }
        */
        #endregion
    }
}
