//using BaseUtility.Utility;
using eLoyaltyV3.AppModule.UI;
using eLoyaltyV3.Entity;
using eLoyaltyV3.PageObject.UI;
using eLoyaltyV3.Utility;
using InfoMessageLogger;
using TestData;
using NUnit.Framework;
using OpenQA.Selenium;
using BaseUtility.Utility;
using Queries = eLoyaltyV3.Utility.Queries;
using System;
using eLoyaltyV3.PageObject.Admin;
using MongoDB.Bson;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region TP_218533 - FrontEnd - SmokeEndToEndCases
        public static void TC_218534()
        {

            if (TestCaseId == Constants.TC_218534)
            {
                Users data = new Users();
                string recoveryEmail, setPassword, recoveryValidation, userName, password, newPassword;
                //1.URL is available in master testplan run description
                //2.Data Requirement: None
                //3.Navigate to Sign in page
                //4.Click on Forget Password
                // Added this code as per changes for R#208647 for HotelIcon Client //               
                SignIn.Click_Link_ForgotYourLogin(ProjectName);
                Logger.WriteDebugMessage("user landed on forget password page");

                //if (Driver.Url == ForgotPasswordURL)
                if (Driver.Url.Contains("PasswordRecovery"))
                {
                    //5. Enter Email address 
                    Queries.GetActiveMemberEmail(data);
                    userName = data.MemberEmail;
                    recoveryEmail = userName;
                    recoveryValidation = Constants.ConfirmRecovery;
                    ForgotPassword.UpdateEmail(recoveryEmail, recoveryValidation, 1);
                    Logger.WriteDebugMessage("Confirmation msg regarding  password reset is sent  to  entered email address ");

                    //6. Logged into Catchall Account
                    Email.LogIntoCatchAll();
                    Email.CatchAll_SearchEmailAndOpenLatestMessage(recoveryEmail); // Searched for the email
                    Email.ForgotPasswordEmail_Check();
                    Logger.WriteDebugMessage("email available in catchall");

                    //7. Click on the link to change the password
                    Email.ActivationForgotPassword_CLick(ProjectName);
                    SwitchToSpecificWindow("Password Recovery Confirm - Club Rewards");
                    Logger.WriteDebugMessage("user landed on password reset page");

                    //8. Enter in New Password and Confirm Password Field.
                    newPassword = TestData.ExcelData.TestDataReader.ReadData(1, "NewPassword");
                    setPassword = newPassword;
                    ForgotPassword.ForgotPasswordNew(setPassword, Constants.ForgotPassword_PassRecoverySuccess, 0);
                    Logger.WriteDebugMessage("Message confirming that password has reset Successfully should be displayed");

                    //10. Navigate to sign in page
                    Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
                    Logger.WriteDebugMessage("User landed on sign in page");

                    //11.Enter the login credential with new password
                    if (ProjectName.Equals("HotelIcon"))
                        Navigation.Click_Button_SignIn();
                    LoginCredentials(recoveryEmail, setPassword, ProjectName);
                    string title = Helper.Driver.Title;
                    SignIn.VerifyLandingPage(ProjectName, title);
                    Logger.WriteDebugMessage("User sign in should be successful");

                    //Reset back the Password.
                    Navigation.ClickMySettings(ProjectName);
                    password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                    MySettings.UpdateUserPasswordwithCase(setPassword, password, Constants.UpdateSettingsMessage, 1, ProjectName);

                }
                else
                {
                    Logger.WriteDebugMessage("SignUp not successful");
                    TestHandling.TestFailed(new Exception("User was unable to register using email address: " + email));
                }
            }
        }


        public static void TC_218535()
        {
            if (TestCaseId == Constants.TC_218535)
            {
                string SuccessUpdate = Constants.UpdateSettingsMessage;
                string userName, password, newPassword, newUserName;
                Users data = new Users();
                Random randomnumber = new Random();
                //1. URL and database detail available in master test plan  run 
                Logger.WriteDebugMessage("user landed on login page");

                //2. Log into  front end 
                Queries.GetActiveMemberEmail(data);
                userName = data.MemberEmail;
                password = ProjectDetails.CommonFrontendPassword;
                if (ProjectName.Equals("HotelIcon"))
                    Navigation.Click_Button_SignIn();
                LoginCredentials(userName, password, ProjectName);
                Logger.WriteDebugMessage("Sign in should be successful");

                //3.Click on My Setting
                Navigation.ClickMySettings(ProjectName);
                if (Driver.Url.Contains(MySettingsURL))
                {
                    Logger.WriteDebugMessage("Landed on the My Settings page.");
                }

                //4.Enter current password under update password section 
                //5.Enter New password into "New Password *" field
                //6. Enter same password into Confirm Password field 
                //7. Click Update Password 
                newPassword = String.Concat(password, randomnumber.Next().ToString());
                MySettings.UpdateUserPasswordwithCase(password, newPassword, SuccessUpdate, 1, ProjectName);
                Logger.WriteDebugMessage("Password gets  updated successfully with message displayed about update on screen");

                //8.Enter different Username into New User Name field under Update user section 
                //9.Enter current password into "Please provide your current password *" field 
                //10.Click Update User 
                //Change UserName
                if (ProjectName.Equals("IndependentCollection"))
                {
                    LoginCredentials(data.MemberEmail, newPassword, ProjectName);
                    Logger.WriteDebugMessage("Sign in should be successful");

                    //3.Click on My Setting
                    Navigation.ClickMySettings(ProjectName);
                    if (Driver.Url.Contains(MySettingsURL))
                    {
                        Logger.WriteDebugMessage("Landed on the My Settings page.");
                    }
                }

                newUserName = String.Concat("QATest" + randomnumber.Next().ToString() + "@cendyn17.com");
                MySettings.UpdateUserEmail(newUserName, newPassword, 1, ProjectName);
                Logger.WriteDebugMessage("New username gets updated successfully and message displayed on screen about changed successful ");

                //11.logout and Login back using updated user name and password 
                if (ProjectName.Equals("IndependentCollection"))
                {
                    Logger.WriteInfoMessage("IndependentCollectionnde");
                }
                else
                {
                    Navigation.ClickSignOut(ProjectName);
                    Logger.WriteDebugMessage("Signed Out from User's Account");
                }
                Logger.WriteDebugMessage("Signed Out from User's Account");

                if (ProjectName.Equals("HotelIcon"))
                    Navigation.Click_Button_SignIn();
                else
                    Helper.ElementWait(PageObject_SignIn.Text_Email(), 60);

                if (Helper.IsElementVisible(PageObject_SignIn.Text_Email()))
                {
                    LoginCredentials(newUserName, newPassword, ProjectName);
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
                    MySettings.UpdateUserEmail(userName, newPassword, 1, ProjectName);
                    if (ProjectName.Equals("IndependentCollection"))
                    {
                        LoginCredentials(userName, newPassword, ProjectName);
                        Logger.WriteDebugMessage("Sign in should be successful");

                        //3.Click on My Setting
                        Navigation.ClickMySettings(ProjectName);
                        if (Driver.Url.Contains(MySettingsURL))
                        {
                            Logger.WriteDebugMessage("Landed on the My Settings page.");
                        }
                    }
                    MySettings.UpdateUserPasswordwithCase(newPassword, password, SuccessUpdate, 1, ProjectName);
                }
                else
                {
                    Assert.Fail("Did not land on SignIn Page.");
                }
            }
        }

        public static void TC_218540(string ProjectName)
        {
            if (TestCaseId == Constants.TC_218540)
            {
                if (TestCaseId == Constants.TC_218540)
                {
                    string subject, subject1;
                    Users data = new Users();
                    // 1.URL and database detail available in master test plan run 
                    // 2 Navigate to sign in page of guest portal
                    // 3 Enter valid credentials and click on login button
                    Logger.WriteDebugMessage("user landed on login page");
                    //Navigate to sign in page of guest portal 
                    //userName = TestData.ExcelData.TestDataReader.ReadData(1, "Registered Email");
                    Queries.GetActiveMemberEmail(data);

                    if (ProjectName.Equals("HotelIcon"))
                        Navigation.Click_Button_SignIn();
                    LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    //4 Navigate to the Contact Us page. 
                    Navigation.Click_Link_ContactUs(ProjectName);
                    Logger.WriteDebugMessage("Landed on the Contact Us page.");

                    //5 Observe Contact Us page to verify content 
                    //6 Verify  by  changing the subject  dynamic fields are  displaying
                    subject = TestData.ExcelData.TestDataReader.ReadData(1, "Subject").Trim();
                    Helper.ScrollToElement(PageObject_ContactUs.DropDownSelect_Authentication_Subject());
                    ContactUs.DropDownSelect_Authentication_Subject(subject);
                    VerifyTextOnPageAndHighLight("Name of Property");
                    VerifyTextOnPageAndHighLight("Confirmation Number");
                    VerifyTextOnPageAndHighLight("Check-In Date");
                    VerifyTextOnPageAndHighLight("Check-Out Date");
                    Logger.WriteDebugMessage("Dynamic fields are  displaying on page");
                    if (!ProjectName.Equals("HotelIcon"))
                    {
                        subject1 = TestData.ExcelData.TestDataReader.ReadData(1, "Subject1").Trim();
                        Helper.ScrollToElement(PageObject_ContactUs.DropDownSelect_Authentication_Subject());
                        ContactUs.DropDownSelect_Authentication_Subject(subject1);
                    }

                    //7.Observe the screen to verify that user is not able to edit Name, E-mail id and Membership number fields
                    ContactUs.VerifyUneditableFields(ProjectName);
                    Logger.WriteDebugMessage("Fields are uneditable on the Contact Us page!");

                }
                else
                {
                    Logger.WriteDebugMessage("Verification of contact page not successful");
                    TestHandling.TestFailed(new Exception("Verification of contact page Failed"));
                }
            }
        }

        public static void TC_218547()
        {
            if (TestCaseId == Constants.TC_218547)
            {

                string userName, password;
                Users data = new Users();
                //1.Navigate to login page
                Logger.WriteDebugMessage("user landed on login page");

                //2.Enter valid credential and click on sign in 
                userName = TestData.ExcelData.TestDataReader.ReadData(1, "Registered Email");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                Queries.GetActiveMemberEmail(data);
                email = data.MemberEmail;
                if (ProjectName.Equals("HotelIcon"))
                    Navigation.Click_Button_SignIn();
                LoginCredentials(email, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("Sign in should be successful");

                //3.Verify the Landing Page
                string landingPageTitle = Helper.Driver.Title;
                SignIn.VerifyLandingPage(ProjectName, landingPageTitle);
                Logger.WriteDebugMessage("User Logged in and Landed on Overview Page");
            }
        }

        public static void TC_185011()
        {
            if (TestCaseId == Constants.TC_185011)
            {
                Users data = new Users();
                //1.Navigate to login page
                Logger.WriteDebugMessage("user landed on login page");

                //2.Enter valid credential and click on sign in 
                Queries.GetActiveMemberEmail(data);
                if (ProjectName.Equals("HotelIcon"))
                    Navigation.Click_Button_SignIn();
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("Sign in should be successful");

                //Click and navigate to each page available on site
                Navigation.VerifyMenuLinks("After", ProjectName);
            }
        }

        public static void TC_185012()
        {
            if (TestCaseId == Constants.TC_185012)
            {
                //1.Navigate to login page
                Logger.WriteDebugMessage("user landed on login page");

                //Click and navigate to each page available on site
                Navigation.VerifyMenuLinks("Before", ProjectName);
            }
        }
       
        public static void TC_223757()
        {
            if (TestCaseId == Constants.TC_223757)
            {
                Users data = new Users();
                string invalidPasword = TestData.ExcelData.TestDataReader.ReadData(1, "wrongPasswordPassword");
                string newPassword = TestData.ExcelData.TestDataReader.ReadData(1, "NewPassword");
                string ReturnResult = Constants.InvalidEmailErrorMessage;
                Logger.WriteDebugMessage("User Landed on FrontEnd Login Page");
                Queries.GetActiveMemberEmail(data);
                Queries.GetMaxLockOutCounter(data);
                int lockcounter = Int16.Parse(data.Configurationvalue);
                for (int i = 1; i <= lockcounter; i++)
                {
                    LoginCredentials(data.MemberEmail, invalidPasword, ProjectName);
                    Helper.ValitionMessage(ReturnResult);
                }
                //5.Verify account status"
                ReturnResult = Constants.AccountLockedMessage;
                Helper.ValitionMessage(ReturnResult);
                Logger.WriteDebugMessage("Account should be locked");

                //6. login to catchall and look for Forget password email
                // Logged into Hotmail Account
                Email.LogIntoCatchAll();
                //Email.CatchAll_SearchEmailAndOpenLatestMessage(data.MemberEmail); // Searched for the email
                Time.AddDelay(10000);
                Helper.ReloadPage();
                Hotmail.CheckOutLook();
                Hotmail.SearchEmail(data.MemberEmail);
                try
                {
                    if (IsElementPresent(By.XPath("//div[@id='groupHeaderAll results']/parent::div/div[2]")))
                    {
                        ElementWait(Driver.FindElement(By.XPath("//div[@id='groupHeaderAll results']/parent::div/div[2]")), 240);
                        ElementClick(Driver.FindElement(By.XPath("//div[@id='groupHeaderAll results']/parent::div/div[2]")));
                    }
                    else
                    {
                        ElementClick(Driver.FindElement(By.XPath("//div[@class='S2NDX']")));
                    }
                }
                catch (NoSuchElementException)
                {
                    ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][3]")));

                }
                catch (Exception)
                {
                    ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][1]")));

                }

                Email.ForgotPasswordEmail_Check();
                Email.ForgotPasswordEmail_Check();
                Logger.WriteDebugMessage("Password reset email should sent automatically to the email address for the user");

                //7. Login to database
                //8. Verify account counter under Users table .
                Queries.GetLockedCount(data.MemberEmail, data);
                string lockCount = data.LockCount;

                if (!(0).Equals(data.LockCount))
                {
                    try
                    {
                        Logger.WriteDebugMessage("Counter should updated as max login attempts limit and should NOT get restet to 0");
                    }
                    catch
                    {
                        Assert.Fail("Could not updated as max login attempts limit and should NOT get restet to 0 ");
                        throw;
                    }
                }

                //9.Now reset password through password reset email
                // Click on the link to change the password
                Email.ActivationForgotPassword_CLick(ProjectName);
                SwitchToSpecificWindow("Password Recovery Confirm - Club Rewards");
                Logger.WriteDebugMessage("User should be landed on password reset page");

                //Enter new password in "New Password" and "Confirm new password" field.
                //Click "Reset Password.
                ForgotPassword.ForgotPasswordNew(newPassword, Constants.ForgotPassword_PassRecoverySuccess, 0);

                //10. Login to portal with updated password
                LoginCredentials(data.MemberEmail, newPassword, ProjectName);

                //11. Login to database
                //12. Verify account counter under Users table .
                Queries.GetLockedCount(data.MemberEmail, data);
                lockCount = data.LockCount;

                if (lockCount.Equals("0"))
                {
                    Logger.WriteDebugMessage("Counter should updated as max login attempts limit and should NOT get restet to 0");
                }
                else
                {
                    Assert.Fail("Could not updated as max login attempts limit and should NOT get restet to 0 ");

                }
                //reset previous password
                MySettingWait(ProjectName);
                if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()))
                {
                    string PageTitle = Driver.Title;
                    Helper.RegexFunction(PageTitle, pattern);
                }


                //Navigate to Update Password screen
                Navigation.ClickMySettings(ProjectName);
                if (Driver.Url.Contains(MySettingsURL))
                    Logger.WriteDebugMessage("User navigate to Update Password page");
                else
                    Assert.Fail("User Landed on Wrong Page: " + Driver.Url);

                MySettings.UpdateUserPasswordwithCase(newPassword, CommomPassword, "", 1, ProjectName);

            }
        }

        public static void TC_217847()
        { 
            if (TestCaseId == Constants.TC_217847)
            {
                //1.Navigate to login page
                //2.Enter valid credentials.Click on SIgn In
                Users data = new Users();
                Queries.GetRedeemeGift_Award(data);
                string balance = TestData.ExcelData.TestDataReader.ReadData(1, "Balance");
                string AwardName = TestData.ExcelData.TestDataReader.ReadData(1, "AwardName");
                string todaydate = DateTime.Today.ToString("MM/dd/yyyy");
                //Navigate to Admin and Identify EGift Balance
                Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
                Logger.WriteDebugMessage("Landed on Admin Login Page");
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                Admin.Click_LoyaltyeGift();
                Admin.Click_LoyaltyeGift_AccountBalance();
                Logger.WriteDebugMessage("Note down the Tango Account Balance");

                Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
                Logger.WriteDebugMessage("Landed on Front End page");
                Queries.GetMemberEmailWithSufficientBalance(data, balance);
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("user should land on Overview page");
                //4.verify user should have sufficient point to redeem eGift voucher
                string page = Driver.Title;
                Helper.ScrollToElement(PageObject_Redeem.Lable_TotalPoints());
                string ActualPoint = PageObject_Redeem.Lable_TotalPoints().Text;
                Logger.WriteDebugMessage("User have sufficient point to Redeem eGift voucher is :" + ActualPoint);
                PageUp();
                //Helper.ElementWait(PageObject_Redeem.Navigation_Link_Redeem(), 20);
                //3. Click on Redeem tab
                Redeem.Click_Button_Redeem();
                Logger.WriteDebugMessage("user should land on Redeem page");

                //6 Click on Redeem button
                Redeem.Click_RedeemeGift_Award(data.AwardName);
                ElementWait(PageObject_Redeem.Ok_Button_On_EGift(), 200);
                Logger.WriteDebugMessage("User should see the pop up to confirm");

                //7 Click on Ok.
                Redeem.Click_Ok_Button_On_EGift();
                ElementWait(PageObject_Redeem.Select_AwardImage(), 200);
                Logger.WriteDebugMessage("User should land on eGift catalog selection page");

                //8 Select eGift catalog and click on Continue
                Redeem.Select_AwardImage();
                //click on reedim button
                ScrollToElement(PageObject_Redeem.Click_Redeem_eGiftCart());
                Redeem.Click_Redeem_eGiftCart();
                ElementWait(PageObject_Redeem.Click_Conform_eGiftCart(), 100);
                Logger.WriteDebugMessage("User should see the Confirmation pop up with reference number and user details");

                //9.Click on Confirm.
                Redeem.Click_Conform_eGiftCart();
                string currentTime = DateTime.Today.ToString();
                ElementWait(PageObject_Redeem.Click_Close_eGiftCart(), 120);
                //click on close button of egiftPopup
                Redeem.Click_Close_eGiftCart();
                Logger.WriteDebugMessage("user should land on Overview page");

                //10.Verify in sidebar if points is deducted for current balance.
                //11 Verify Tango Account balance If account balance is 350, and face value of egift voucher is $5 then after redeem Account balance should get updated to 345
                Helper.ScrollToElement(PageObject_Redeem.Lable_TotalPoints());
                String UpdatedPoint = PageObject_Redeem.Lable_TotalPoints().Text;
                double PointBeforeRedeem = Convert.ToDouble(ActualPoint);
                double PointAfterReddem = Convert.ToDouble(UpdatedPoint);
                double ExpectedUpdatedPoint = PointBeforeRedeem - PointAfterReddem;
                Logger.WriteDebugMessage("Account balance should get updated correctly" + ExpectedUpdatedPoint);

                //12 Verify Award status is updated to Redeem under Member Award.
                Awards.Click_Award_Tab();
                Awards.Click_Redemptions_SubTab();
                Helper.ScrollToElement(PageObject_Awards.Award_Filter());
                Awards.Award_Filter(todaydate);
                Logger.WriteDebugMessage("Award status should get updated to redeemed");

                //13.Verify Award status is updated to Redeemed under member Award tab in Admin
                Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                Admin.EnterEmail(data.MemberEmail);
                Admin.Click_Button_MemberSearch();
                Admin.Click_Icon_View(ProjectName);
                ElementWait(PageObject_Admin.Tab_MemberAwards(), 120);
                Helper.PageDown();
                Logger.WriteDebugMessage("Profile gets displayed ");
                Admin.Click_Tab_MemberAwards();
                Admin.MemberAwards_Text_Filter(AwardName.Trim());
                ElementWait(PageObject_Admin.Admin_Menu_LoyaltyEgift(), 120);
                Logger.WriteDebugMessage("Award status should get updated to Redeemed");

                Admin.Click_LoyaltyeGift();
                Admin.Click_LoyaltyeGift_AccountBalance();
                Logger.WriteDebugMessage("Again note down the Tango Account Balance");

                //14.verify user is receiving email from Tango for detail about Redemption.
                Email.LogIntoCatchAll();
                Logger.WriteDebugMessage("User should be Logged in Catchall Account");
                //Email.CatchAll_SearchEmailAndOpenLatestMessage(data.MemberEmail);
                Hotmail.OutLookSearchEmail(data.MemberEmail);
                Hotmail.OpenLatestEmailSingleClick();
                Logger.WriteDebugMessage("Catchall mailbox should be opened");
                Driver.Manage().Window.Maximize();
                Helper.ScrollDown();
                Logger.WriteDebugMessage("User should receive email once done with successful redemption");
            }
        }



        public static void TC_109958()
        {
            if (TestCaseId == Constants.TC_109958)
            {
                //Pre-requisites
                string DOB_Error, FirstName_Error, LastName_Error, Email_Error, Card_Error, Password_Error, ConfirmPassword_Error, Captcha_Error, Fieldvalidation, Captchavalidation, FirstName, LastName, Email, Card, Password, Confirm;

                Fieldvalidation =  TestData.ExcelData.TestDataReader.ReadData(1, "Validationmessage");
                Captchavalidation = TestData.ExcelData.TestDataReader.ReadData(1, "CaptchaValidation");
                FirstName = TestData.ExcelData.TestDataReader.ReadData(1, "FirstName");
                LastName = TestData.ExcelData.TestDataReader.ReadData(1, "LastName");
                Email = TestData.ExcelData.TestDataReader.ReadData(1, "Email");
                Card = TestData.ExcelData.TestDataReader.ReadData(1, "Card");
                Password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                Confirm = TestData.ExcelData.TestDataReader.ReadData(1, "Confirm");

                Logger.WriteDebugMessage("Landed on Front-end Sign in page");

                // Navigate to Sign up page
                Helper.ElementWait(PageObject_Navigation.Button_JoinNow(), 120);
                Navigation.Click_Button_JoinNow();
                ElementWait(PageObject_Navigation.SignUp_Button_Join(), 120);
                Logger.WriteDebugMessage("Landed on Sign Up Page");

                
                // Retrieve all the Validation Message
                for (int i = 0; i < 8; i++)
                {
                    // Enter Values in Sign Up Fields
                    SignUp.SignUpEnterdetails(FirstName, LastName, Email, Card, Password, Confirm, i);
                    Helper.ScrollToElement(PageObject_Navigation.SignUp_Button_Join());
                    Navigation.SignUp_Button_Join();

                    // Retrieved Validation messages
                    DOB_Error = Navigation.DOB_Error();
                    FirstName_Error = Navigation.FirstName_Error();
                    LastName_Error = Navigation.LastName_Error();
                    Email_Error = Navigation.Email_Error();
                    Card_Error = Navigation.Card_Error();
                    Password_Error = Navigation.Password_Error();
                    ConfirmPassword_Error = Navigation.ConfirmPassword_Error();
                    Captcha_Error = Navigation.Captcha_Error();

                    //Validate Validation messages
                    SignUp.SignUpVerifyErrorMessage(i, Fieldvalidation, Captchavalidation, DOB_Error, FirstName_Error, LastName_Error, Email_Error, Card_Error, Password_Error, ConfirmPassword_Error, Captcha_Error);
                }

            }
        }

        public static void TC_109959()
        {
            if (TestCaseId == Constants.TC_109959)
            {
                // Pre-Requisites
                string FirstName, LastName, Email, Card, Password, ConfirmPassword, ExpectedEmailValidationErrorMessage, Email_Error;

                //Retrieved data
                ExpectedEmailValidationErrorMessage = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage");
                FirstName = TestData.ExcelData.TestDataReader.ReadData(1, "FirstName");
                LastName = TestData.ExcelData.TestDataReader.ReadData(1, "LastName");
                Card = TestData.ExcelData.TestDataReader.ReadData(1, "CardName");
                Password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                ConfirmPassword = TestData.ExcelData.TestDataReader.ReadData(1, "ConformPassword");

                Logger.WriteDebugMessage("Landed on Front-end Sign in page");
                Logger.LogTestData(TestPlanId, TestCaseId, "FirstName", FirstName);
                Logger.LogTestData(TestPlanId, TestCaseId, "LastName", LastName);
                Logger.LogTestData(TestPlanId, TestCaseId, "Card", Card);
                Logger.LogTestData(TestPlanId, TestCaseId, "Password", Password);
                Logger.LogTestData(TestPlanId, TestCaseId, "ConfirmPassword", ConfirmPassword);
                // Navigate to Sign Up Page
                Navigation.Click_Button_JoinNow();
                
                // Verify the validation message with different combination of Email

                for (int i=1;i<=20;i++)
                {
                    Email = TestData.ExcelData.TestDataReader.ReadData(i, "Email");
                    ElementWait(PageObject_Navigation.SignUp_Button_Join(), 120);
                    Logger.WriteDebugMessage("Landed on Sign Up Page");
                    // Enter All mandatory Fields
                    SignUp.EnterAllMandatoryFields(FirstName, LastName, Email, Card, Password, ConfirmPassword, ProjectName);
                    Logger.WriteDebugMessage("Entered All Mandatory Fields");
                   if(i==20)
                     Logger.LogTestData(TestPlanId, TestCaseId, "Email "+i, Email, true);
                   else
                      Logger.LogTestData(TestPlanId, TestCaseId, "Email "+i, Email);

                    // Click on Join Now
                    Helper.ScrollToElement(PageObject_Navigation.SignUp_Button_Join());
                    Navigation.SignUp_Button_Join();

                    // Validate the Validation message for password field
                    Email_Error = Navigation.Email_Error();
                    SignUp.VerifyValidationMessage( Email_Error, ExpectedEmailValidationErrorMessage);
                    Helper.ReloadPage();
                }
            }
        }
        public static void TC_113317()
        {
            if (TestCaseId == Constants.TC_113317)
            {
                Logger.WriteDebugMessage("Landed on Front-end Sign in page");

                // Navigate to Join Now Button
                Navigation.Click_Button_JoinNow();
                Logger.WriteDebugMessage("Landed on Sign Up Page");

                SignUp.SignUpVerificationwithhLessThan18Years();



            }
        }

        public static void TC_112091()
        {
            if (TestCaseId == Constants.TC_112091)
            {
                //Pre-requisites
                string InviteFriendsActuallValidationmessage, InviteFriendsExpectedValidationmessage;
                InviteFriendsExpectedValidationmessage = TestData.ExcelData.TestDataReader.ReadData(1, "InviteFriendsValidation");
                Users data = new Users();

                // Login with Active Member
                Queries.GetActiveMemberEmail(data, ProjectName);
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("Logged in Successfully with valid Credentials :" +data.MemberEmail);

                // Navigate to IInvite My Friend Page
                Navigation.Click_Link_InviteFriends();
                Helper.ScrollToElement(PageObject_InviteFriends.Text_InviteFriends());
                Logger.WriteDebugMessage("Landed on Invite Friends Page");
                // Click on Sent My Invitation button without entering any value.
                InviteFriends.Button_SendMyInvitation();

                //Capture the Validation message
                InviteFriendsActuallValidationmessage = InviteFriends.InviteFriendValidation_Error();

                //Compare Actual Validation message with Expected Validation message
                if (InviteFriendsActuallValidationmessage.Equals(InviteFriendsExpectedValidationmessage))
                {
                    VerifyTextOnPageAndHighLight(InviteFriendsActuallValidationmessage);
                    Logger.WriteDebugMessage("Required Field validation message is getting displayed");
                }
                else
                    Assert.Fail("Validation Message is not displaying");
            }
        }

        public static void TC_112093()
        {
            if (TestCaseId == Constants.TC_112093)
            {
                //Pre-requisites
                string InvitationEmail, InviteFriendsActualCaptchaValidationmessage, InviteFriendsExpectedCaptchaValidationmessage;
                InvitationEmail = TestData.ExcelData.TestDataReader.ReadData(1, "InvitationEmail");
                InviteFriendsExpectedCaptchaValidationmessage = TestData.ExcelData.TestDataReader.ReadData(1, "InviteFriendsExpectedValidationmessage");
                Users data = new Users();

                //Login with Active user
                Queries.GetActiveMemberEmail(data, ProjectName);
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("Logged in Successfully with valid Credentials :" + data.MemberEmail);

                //Navigate to Invite My Friend Page
                Navigation.Click_Link_InviteFriends();
                Helper.ScrollToElement(PageObject_InviteFriends.Text_InviteFriends());
                Logger.WriteDebugMessage("Navigated to Invite Friends Page");

                // Enter email and Click on Sent My Invitation button
                InviteFriends.EnterText_SendInvitation(InvitationEmail);
                InviteFriends.Button_SendMyInvitation();

                //Capture the Validation message
                InviteFriendsActualCaptchaValidationmessage = InviteFriends.InviteFriendValidation_CaptchaError();

                //Compare Actual Validation message with Expected Validation message
                if (InviteFriendsActualCaptchaValidationmessage.Equals(InviteFriendsExpectedCaptchaValidationmessage))
                {
                    VerifyTextOnPageAndHighLight(InviteFriendsActualCaptchaValidationmessage);
                    Logger.WriteDebugMessage("Required Field validation message is getting displayed");
                }
                else
                    Assert.Fail("Validation Message is not displaying");
            }
        }

        public static void TC_112270()
        {
            if (TestCaseId == Constants.TC_112270)
            {
                //Pre-requisites
                string Subject;
                Users data = new Users();


                // Login with Active Member       
                Queries.GetActiveMemberEmail(data);
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("Logged in successfully.");

                // Navigate to the Contact Us page.
                Navigation.Click_Link_ContactUs(ProjectName);
                Logger.WriteDebugMessage("Landed on the Contact Us page.");

                // Click on subject drop down 
                for (int i = 1; i <= 6; i++)
                {
                    Subject = TestData.ExcelData.TestDataReader.ReadData(i, "Subject");
                    Helper.ScrollToElement(PageObject_ContactUs.DropDownSelect_Authentication_Subject());
                    ContactUs.DropDownSelect_Authentication_Subject(Subject);
                    Logger.WriteDebugMessage("user should be able to select values from drop down");
                    ReloadPage();
                }

            }
            
        }
        
        public static void TC_112269(string ProjectName)
        {
            if (TestCaseId == Constants.TC_112269)
            {
                //Pre-requisites
                string validationMessage, captchaErrorMessage, subject;
                Users data = new Users();
                
                //Login with valid credentials
                Queries.GetActiveMemberEmail(data);
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Navigate to the Contact Us page
                Navigation.Click_Link_ContactUs(ProjectName);
                Logger.WriteDebugMessage("Landed on the Contact Us page.");

                //Click on Submit button and validated required fields validation message
                Helper.ScrollToElement(PageObject_ContactUs.Button_Send());
                ContactUs.Click_Button_Send();
                validationMessage = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage").Trim();
                captchaErrorMessage = TestData.ExcelData.TestDataReader.ReadData(1, "CaptchaValidationMessage").Trim();
                VerifyTextOnPageAndHighLight(validationMessage);
                AddDelay(3000);
                VerifyTextOnPageAndHighLight(captchaErrorMessage);
                Logger.WriteDebugMessage("Validation message should get displayed");

                //Verify the validation message for all Subject available
                for (int subjectNumber = 1; subjectNumber < 7; subjectNumber++)
                {
                    Helper.ReloadPage();
                    subject = TestData.ExcelData.TestDataReader.ReadData(subjectNumber, "Subject").Trim();
                    ContactUs.DropDownSelect_Authentication_Subject(subject);
                    ContactUs.Click_Button_Send();
                    VerifyTextOnPageAndHighLight(validationMessage);
                    Logger.WriteDebugMessage("Validation message should get displayed");
                    AddDelay(3000);
                    VerifyTextOnPageAndHighLight(captchaErrorMessage);
                    Logger.WriteDebugMessage("Validation message should get displayed");
                    
                }
                Logger.WriteDebugMessage("Test case passed successfully");
            }
        }

        public static void TC_112275()
        {
            if (TestCaseId == Constants.TC_112275)
            {
                //Prerqusite
                string specialCharater_Text, subject;
                specialCharater_Text = TestData.ExcelData.TestDataReader.ReadData(1, "Text");
                Users data = new Users();
                Queries.GetActiveMemberEmail(data);

                // Log in to Frontend
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("Logged in successfully.");

                // Navigate to the Contact Us page.
                Navigation.Click_Link_ContactUs(ProjectName);

                // Scroll down page.
                Helper.ScrollToElement(PageObject_ContactUs.Text_PhoneNumber());
                Logger.WriteDebugMessage("Landed on the Contact Us page.");

                //Try to Enter Special Characters in Phone number and Confirmation number text filed.
                for (int i = 1; i <= 6; i++)
                {
                    subject = TestData.ExcelData.TestDataReader.ReadData(i, "Subject").Trim();
                    Helper.ScrollToElement(PageObject_ContactUs.DropDownSelect_Authentication_Subject());
                    ContactUs.InsertSpecialCharacterInPhone(specialCharater_Text, ProjectName);
                    ContactUs.DropDownSelect_Authentication_Subject(subject);
                    if (Helper.IsElementDisplayed(PageObject_ContactUs.EnterText_Text_Confirmation_Number()))
                    {
                        ContactUs.InsertSpecialCharacterInConfirmationField(specialCharater_Text);
                    }
                    ContactUs.EnterText_Text_Message(specialCharater_Text);
                    Logger.WriteDebugMessage("User should be able to enter special characters in only Message/comment field");
                    Helper.ReloadPage();
                }
            }
        }
        
        public static void TC_112423()
        {
            if (TestCaseId == Constants.TC_112423)
            {
                //Prerequisite
                string email, actualemailvalidationmesssage, expectedemailvalidationmesssage, validEmailAddress;
                Users data = new Users();
                expectedemailvalidationmesssage = TestData.ExcelData.TestDataReader.ReadData(1, "EmailAddressValidation");
                Queries.GetActiveMemberEmail(data);

                // Log in to Front-end
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Navigate to Invite Friend Page
                Navigation.Click_Link_InviteFriends();
                ScrollToElement(PageObject_InviteFriends.EnterText_SendInvitation());
                Logger.WriteDebugMessage("Landed on Invite Friend Page.");

                //Enter different combination of invalid email address and verify the validation message
                for (int invalidemail = 1; invalidemail <= 11; invalidemail++)
                {
                    //Retrieve the invalid email
                    email = TestData.ExcelData.TestDataReader.ReadData(invalidemail, "EmailAddress");
                    //Enter Email address into Email text box
                    InviteFriends.EnterText_SendInvitation(email);
                    Logger.WriteDebugMessage(email + " Invalid email address is entered");
                    //Click on Send My Invitation button
                    InviteFriends.Button_SendMyInvitation();
                    //Get validation message from the screen
                    actualemailvalidationmesssage = InviteFriends.InviteFriendValidation_Error();

                    //Compare Actual vs expected validation message 
                    if (actualemailvalidationmesssage.Equals(expectedemailvalidationmesssage))
                        Logger.WriteDebugMessage("Proper Validation message is getting displayed for invalid email address");
                    else
                        Assert.Fail("Proper Validation message is not getting displayed for invalid email address");
                    Helper.ReloadPage();
                }

                //Enter Different combination of Valid Email Address and Verify the Validation message
                for (int validemail = 2; validemail <= 10; validemail++)
                {
                    //Retrieve the invalid email
                    validEmailAddress = TestData.ExcelData.TestDataReader.ReadData(validemail, "ValidEmailAddress");
                    //Enter Email address into Email text box
                    InviteFriends.EnterText_SendInvitation(validEmailAddress);
                    Logger.WriteDebugMessage(validEmailAddress + " Valid email address is entered");
                    //Click on Send My Invitation button
                    InviteFriends.Button_SendMyInvitation();
                    //Get validation message from the screen
                    actualemailvalidationmesssage = InviteFriends.InviteFriendValidation_Error();

                    //Compare Actual vs expected validation message 
                    if (!(actualemailvalidationmesssage.Equals(expectedemailvalidationmesssage)))
                        Logger.WriteDebugMessage("Invalid Email Validation Message for Valid email is not getting displayed");
                    else
                    {
                        Logger.WriteInfoMessage("Invalid Email Validation message is getting displayed for Valid email address");
                        Assert.Fail("Invalid Email Validation message is getting displayed for Valid email address");
                    }
                    Helper.ReloadPage();
                }
                
            }
        }
        public static void TC_112426()
        {
            if (TestCaseId == Constants.TC_112426)
            {
                //Pre-requisites
                string InviteFriendsActuallValidationmessage, InviteFriendsExpectedValidationmessage, InvitationEmail,InviteMailContent,
                       InviteMailContentActuallValidationmessage,InviteMailContentExpectedValidationmessage;

                InviteFriendsExpectedValidationmessage = TestData.ExcelData.TestDataReader.ReadData(1, "InviteFriendsExpectedValidationmessage");
                InviteMailContentExpectedValidationmessage = TestData.ExcelData.TestDataReader.ReadData(1, "InviteMailContentExpectedValidationmessage");
                Users data = new Users();

                // Login with Active Member
                Queries.GetActiveMemberEmail(data, ProjectName);
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("Logged in Successfully with valid Credentials :" + data.MemberEmail);

                // Navigate to Invite My Friend Page
                Navigation.Click_Link_InviteFriends();
                Helper.ScrollToElement(PageObject_InviteFriends.Text_InviteFriends());
                Logger.WriteDebugMessage("Landed on Invite Friends Page");

                // Enter text in all text fields to check character limit.
                for (int i = 1; i <= 5; i++)
                {
                    InvitationEmail = TestData.ExcelData.TestDataReader.ReadData(i, "InvitationEmail").Trim();
                    InviteFriends.EnterText_SendInvitation(InvitationEmail);                   
                    int EmailLength = InvitationEmail.Length;
                    InviteFriends.Button_SendMyInvitation();

                    if (EmailLength <= 200 && Helper.IsElementDisplayed(PageObject_InviteFriends.InviteFriendEmailValidation_Error()))
                    {
                        Assert.Fail("An email address has incorrect format, please fix before continuing.");
                    }

                    Logger.WriteDebugMessage("User should be able to enter email in Email text box");
                    Helper.AddDelay(5000);

                    if (Helper.IsElementDisplayed(PageObject_InviteFriends.InviteFriendEmailValidation_Error()))                     
                    {
                        
                        InviteFriendsActuallValidationmessage = InviteFriends.InviteFriendEmailValidation_Error();
                        Logger.WriteDebugMessage("User should be able to enter text in all given text fields");
                        
                        //Compare Actual Validation message with Expected Validation message
                        if (InviteFriendsActuallValidationmessage.Equals(InviteFriendsExpectedValidationmessage))
                        {
                           
                            Logger.WriteDebugMessage("Required Field validation message is getting displayed");
                        }
                        else
                            Assert.Fail("Validation Message is not displaying");
                    }
                    Helper.ReloadPage();

                }
                //  Verify  field email Content must be a string with a maximum length of 500. 
                if (ProjectName.Equals("Fraser"))
                {
                    InviteMailContent = TestData.ExcelData.TestDataReader.ReadData(1, "InviteMailContent");
                    InviteFriends.EnterText_SendInvitationMailContent(InviteMailContent);
                    InviteMailContentActuallValidationmessage = InviteFriends.EnterText_SendInvitationMailContent_Error();
                    Logger.WriteDebugMessage("User should be able to enter text in all given text fields");
                    //Compare Actual Validation message with Expected Validation message
                    if (InviteMailContentActuallValidationmessage.Equals(InviteMailContentExpectedValidationmessage))
                    {
                        VerifyTextOnPageAndHighLight(InviteMailContentExpectedValidationmessage);
                        Logger.WriteDebugMessage("Required Field validation message is getting displayed");
                    }
                    else
                        Assert.Fail("Validation Message is not displaying");
                }
           
            }
        }
        public static void TC_223768()
        {
            if (TestCaseId == Constants.TC_223768)
            {
                //Prerequisite
                string validationMesssage;
                Users data = new Users();
                validationMesssage = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMesssage");
                Queries.GetDeactivedMemberEmail(data);

                // Login with Deactivated Member
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                VerifyTextOnPageAndHighLight(validationMesssage);
                Logger.WriteDebugMessage(validationMesssage + " - Validation message should get displayed");

                // Navigate to Admin
                Driver.Url = ProjectDetails.CommonAdminURL;
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                Admin.EnterEmail(data.MemberEmail);
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage(" Deactivated Member got Searched on the page");
                Admin.Click_Icon_View(ProjectName);
                ElementWait(PageObject_Admin.Admin_MemberInfo_MemberStays(), 180);
                VerifyTextOnPageAndHighLight("Deactivated");
                Logger.WriteDebugMessage("Deactivated user got displayed on Member Information Page");

                Logger.LogTestData(TestPlanId, TestCaseId, "Deactivated User Email", data.MemberEmail, true);

            }
        }
        public static void TC_223767()
        {
            try
            {
                if (TestCaseId == Constants.TC_223767)
                {
                    string memberEmail, memberType, emailStatus, memberStatus;

                    memberType = TestData.ExcelData.TestDataReader.ReadData(1, "MemberType");
                    emailStatus = TestData.ExcelData.TestDataReader.ReadData(1, "EmailStatus");
                    memberStatus = TestData.ExcelData.TestDataReader.ReadData(1, "MemberStatus");
                    Driver.Url = ProjectDetails.CommonAdminURL;
                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    Admin.SelectMemberType(memberType);
                    Admin.SelectMemberStatus(memberStatus);
                    Admin.SelectEmailStatus(emailStatus);
                    Admin.Click_Button_MemberSearch();
                    Logger.WriteDebugMessage("Members got Searched on the page");
                    memberEmail = PageObject_Admin.Admin_Value_EmailId().GetAttribute("innerHTML");
                    Admin.Click_Icon_View(ProjectName);
                    ElementWait(PageObject_Admin.Admin_MemberInfo_MemberStays(), 240);
                    VerifyTextOnPageAndHighLight(emailStatus);
                    Logger.WriteDebugMessage("Active Member  with Pending Member Status is Displayed on the Page ");


                    //Navigate to Frontend and verify the validation message
                    Admin.Click_MemberInformation_Value_MemberPortal();
                    AddDelay(10000);
                    ControlToNewWindow();
                    Driver.Manage().Window.Maximize();
                    VerifyTextOnPageAndHighLight("Is not possible to impersonate the user " + memberEmail);
                    Logger.WriteDebugMessage("Validation message for Active Member with Pending Status got diaplyed on the page");

                    //Log test data
                    Logger.LogTestData(TestPlanId, TestCaseId, "Member Type", memberType);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Email Status", emailStatus);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Member Status", memberStatus);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Active User Email with Pending Email", memberEmail, true);

                }
            }catch(Exception e)
            {

            }
        }
        public static void TC_223760()
        {
            if (TestCaseId == Constants.TC_223760)
                {
                    Users data = new Users();
                    string invalidPasword, validationMessage, setPassword;
                    invalidPasword = TestData.ExcelData.TestDataReader.ReadData(1, "WrongPasswordPassword");
                    validationMessage = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage");
                    setPassword = TestData.ExcelData.TestDataReader.ReadData(1, "SetPassword");
                    Queries.GetActiveMemberEmail(data);
                    Queries.GetMaxLockOutCounter(data);
                    int lockcounter = Int16.Parse(data.Configurationvalue);

                    //Verify the login with Invalid password
                    for (int i = 1; i <= lockcounter; i++)
                    {
                        LoginCredentials(data.MemberEmail, invalidPasword, ProjectName);
                        if (i < lockcounter)
                        {
                            VerifyTextOnPageAndHighLight(validationMessage);
                            Queries.GetLockedCount(data.MemberEmail, data);
                            Logger.WriteDebugMessage("Validation message got displayed and lock counter = " + data.LockCount + " is less than maximum attempt = " + lockcounter);
                        }
                        else
                        {
                            VerifyTextOnPageAndHighLight(Constants.AccountLockedMessage);
                            Queries.GetLockedCount(data.MemberEmail, data);
                            Logger.WriteDebugMessage("Validation message got displayed and lock counter = " + data.LockCount + " is equal to maximum attempt = " + lockcounter);
                        }
                    }
                    //Navigate to CatchAll and Verify the email
                    OpenNewTab();
                    Logger.WriteDebugMessage("Navigated to new Tab");
                    Email.LogIntoCatchAll();
                    Time.AddDelay(10000);
                    Helper.ReloadPage();
                    Hotmail.CheckOutLook();
                    Hotmail.SearchEmail(data.MemberEmail);
                    try
                    {
                        if (IsElementPresent(By.XPath("//div[@id='groupHeaderAll results']/parent::div/div[2]")))
                        {
                            //ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][4]")));
                            ElementWait(Driver.FindElement(By.XPath("//div[@id='groupHeaderAll results']/parent::div/div[2]")), 240);
                            ElementClick(Driver.FindElement(By.XPath("//div[@id='groupHeaderAll results']/parent::div/div[2]")));
                        }
                        else
                        {
                            ElementClick(Driver.FindElement(By.XPath("//div[@class='S2NDX']")));
                        }
                    } 
                    catch
                    {
                        ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][1]")));
                    }
                    Helper.PageDown();
                    Email.ForgotPasswordEmail_Check();
                    Logger.WriteDebugMessage("Email available in catchall Automatically");

                    //Navigate to Admin and try to send the Forgot Password email Succesfully
                    ControlToPreviousWindow();
                    Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
                    Logger.WriteDebugMessage("Landed on Admin Login Page");
                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    //Search for the User and Navigate to Member Search Page
                    Admin.EnterEmail(data.MemberEmail);
                    Logger.WriteDebugMessage("Emaill Entered into text box");
                    Admin.Click_Button_MemberSearch();
                    Logger.WriteDebugMessage("Member should get displayed under Member result table");
                    Admin.Click_Icon_View(ProjectName);
                    Logger.WriteDebugMessage("User should get landed on Member Information page");

                    //Send the forgot password email from Admin
                    Admin.SendResetLogin(data.MemberEmail);
                    VerifyTextOnPage("Reset successful.");
                    AddDelay(1500);
                    Logger.WriteDebugMessage("'Reset successful' message is displayed.");

                    //Search for the Forgot password Email which is send from Admin
                    ControlToNextWindow();
                    ReloadPage();
                    Logger.WriteDebugMessage("Navigate to CatchAll and page Refreshed");
                    Hotmail.SearchEmail(data.MemberEmail);
                    try
                    {
                        if (IsElementPresent(By.XPath("//div[@id='groupHeaderAll results']/parent::div/div[2]")))
                        {
                            //ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][4]")));
                            ElementWait(Driver.FindElement(By.XPath("//div[@id='groupHeaderAll results']/parent::div/div[2]")), 240);
                            ElementClick(Driver.FindElement(By.XPath("//div[@id='groupHeaderAll results']/parent::div/div[2]")));
                        }
                        else
                        {
                            ElementClick(Driver.FindElement(By.XPath("//div[@class='S2NDX']")));
                        }
                    }
                    catch
                    {
                        ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][1]")));
                    }
                    Helper.PageDown();
                    Email.ForgotPasswordEmail_Check();
                    Logger.WriteDebugMessage("Email available in catchall sent from Admin");                    
                    //ReloadPage();
                    AddDelay(30000);
                    //Verify the Password email Link from 1st triggred email
                    ElementClick(Driver.FindElement(By.XPath("//div[@id='groupHeaderAll results']/parent::div/parent::div/following-sibling::div[1]")));
                    Email.ForgotPasswordEmail_Check();
                    Logger.WriteDebugMessage("Password recovery email should have appeared.");
                    Email.ActivationForgotPassword_CLick(ProjectName);
                    Helper.ControlToNewWindow();
                    VerifyTextOnPageAndHighLight(Constants.ForgotPassword_RecoveryLinkExpired2);
                    Logger.WriteDebugMessage("User should be landed on password reset page and Invalid Token Validation message got displayed");

                    //Verify the Password email Link from 2nd triggred email
                    CloseCurrentTab();
                    ControlToNextWindow();
                    if (IsElementPresent(By.XPath("//div[@id='groupHeaderAll results']/parent::div/div[2]")))
                    {
                        //ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][4]")));
                        ElementWait(Driver.FindElement(By.XPath("//div[@id='groupHeaderAll results']/parent::div/div[2]")), 240);
                        ElementClick(Driver.FindElement(By.XPath("//div[@id='groupHeaderAll results']/parent::div/div[2]")));
                    }
                    else
                    {
                        ElementClick(Driver.FindElement(By.XPath("//div[@class='S2NDX']")));
                    }
                    //ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][1]")));
                    Email.ForgotPasswordEmail_Check();
                    Logger.WriteDebugMessage("Password recovery email should have appeared.");
                    Email.ActivationForgotPassword_CLick(ProjectName);
                    Helper.ControlToNewWindow();
                    Logger.WriteDebugMessage("User should be landed on password reset page");
                    ForgotPassword.ForgotPasswordNew(setPassword, Constants.ForgotPassword_PassRecoverySuccess, 0);
                    Logger.WriteDebugMessage("User should be able to reset password sucesfully");

                    ///Try to Login with Valid Crentials
                    LoginCredentials(data.MemberEmail, setPassword, ProjectName);
                    if (PageObject_Navigation.Link_SignOut(ProjectName).Displayed)
                        Logger.WriteDebugMessage("Logged in Succesful to frontend");
                    else
                        Assert.Fail("Unable to log in to frontend");

                    //Log test data
                    Logger.LogTestData(TestPlanId, TestCaseId, "Member Email", data.MemberEmail);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Maximum Lock Counter", lockcounter.ToString());
                    Logger.LogTestData(TestPlanId, TestCaseId, "Wrong Credential Validation Message", validationMessage);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Account Lock Validation Message", Constants.AccountLockedMessage, true);
                
            }
        }
        public static void TC_223762()
        {
            if (TestCaseId == Constants.TC_223762)
            {
                Users data = new Users();
                string invalidPasword, validationMessage;
                invalidPasword = TestData.ExcelData.TestDataReader.ReadData(1, "WrongPasswordPassword");
                validationMessage = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage");
                Queries.GetActiveMemberEmail(data);
                Queries.GetMaxLockOutCounter(data);
                int lockcounter = Int16.Parse(data.Configurationvalue);
                
                //Verify the login with Invalid password
                for (int i = 1; i < lockcounter; i++)
                {
                    LoginCredentials(data.MemberEmail, invalidPasword, ProjectName);
                    VerifyTextOnPageAndHighLight(validationMessage);
                    Queries.GetLockedCount(data.MemberEmail, data);
                    if (data.LockCount == i.ToString())
                    { 
                        Logger.WriteDebugMessage("Validation message got displayed and lock counter = "+data.LockCount+" is less than maximum attempt = "+lockcounter);
                    }
                    else
                        Assert.Fail("Lock counter is greater than maximum attempt");
                    
                }
                Queries.GetLockedCount(data.MemberEmail, data);
                if (data.LockCount == 0.ToString())
                    Assert.Fail("Counter is Reset to Zero before account got lock out");
                else
                    Logger.WriteInfoMessage("Counter is not reset to zero");
                //Log test data
                Logger.LogTestData(TestPlanId, TestCaseId, "Member Email", data.MemberEmail);
                Logger.LogTestData(TestPlanId, TestCaseId, "Maximum Lock Counter", lockcounter.ToString());
                Logger.LogTestData(TestPlanId, TestCaseId, "Wrong Credential Validation Message", validationMessage, true);
                

            }
        }
        #endregion TP_218533
    }
}