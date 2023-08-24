using System;
using eLoyaltyV3.AppModule.UI;
using NUnit.Framework;
using eLoyaltyV3.Entity;
using InfoMessageLogger;
using BaseUtility.Utility;
using Queries = eLoyaltyV3.Utility.Queries;
using Constants = eLoyaltyV3.Utility.Constants;
using TestData;
using OpenQA.Selenium;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : eLoyaltyV3.Utility.Setup
    {
        #region TP_121737 - Forgot Password Page
        public static void TC_124896()
        {
            if (TestCaseId == Constants.TC_124896)
            {
                Users data = new Users();
                string recoveryEmail, setPassword, validationMessage, LinkExpiredValidation;
                //1.Click "Forgot Your Login?" 

                SignIn.Click_Link_ForgotYourLogin(ProjectName);
                Logger.WriteDebugMessage("user landed on forget password page");

                //2.Enter existing/new catchall email into "Email" field.
                //3.Click "Recover."
                Queries.GetActiveMemberEmail(data, ProjectName);
                validationMessage = TestData.ExcelData.TestDataReader.ReadData(1, "Validation Message");
                setPassword = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Password"), DateTime.Now.Millisecond);
                ForgotPassword.UpdateEmail(data.MemberEmail, validationMessage, 1);
                Logger.WriteDebugMessage("Forget Password Confirmation Message should be displays.");
                Logger.LogTestData(TestPlanId, TestCaseId, "Validation Message", validationMessage);
                Logger.LogTestData(TestPlanId, TestCaseId, "Password", setPassword);

                //4.Check catchall for the recovery email.
                Email.LogIntoCatchAll();
                //Helper.ReloadPage();
                //Hotmail.CheckOutLook();
                Hotmail.SearchEmail(data.MemberEmail);
                Hotmail.OpenLatestEmailSingleClick();
                /*try
                {
                    //IWebElement element = Driver.FindElement(By.CssSelector("._lvv_11"));
                    //((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].removeAttribute('style')", element);
                    //AddDelay(2500);
                    //ElementClick(Driver.FindElement(By.XPath("//div[@role='heading'][@tabindex='-1']/following-sibling::div[@data-convid][1]")));                
                    ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][4]")));
                }
                catch (Exception ex)
                {
                    ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][1]")));
                    bool flag=Helper.VerifyTextOnPage("RESET YOUR PASSWORD");
                    if (!flag)
                        ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][2]")));
                    bool flag1 = Helper.VerifyTextOnPage("RESET YOUR PASSWORD");
                    if (!flag1)
                        ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][3]")));
                    Logger.WriteDebugMessage("Failed due to below error" + ex.Message);
                }*/
                
                Helper.PageDown();
                Logger.WriteDebugMessage("Opened Latest Email.");
                Email.ForgotPasswordEmail_Check();
                Logger.WriteDebugMessage("Password recovery email should have appeared.");
                Logger.LogTestData(TestPlanId, TestCaseId, "Test Data", data.MemberEmail);
                //5. Click on the link to change the password
                Email.ActivationForgotPassword_CLick(ProjectName);
              
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("User should be landed on password reset page");

                //6.Enter new password in "New Password" and "Confirm new password" field.
                //7.Click "Reset Password.
                ForgotPassword.ForgotPasswordNew(setPassword, Constants.ForgotPassword_PassRecoverySuccess, 0);
                Logger.WriteDebugMessage("User should be able to reset password sucesfully");

                //9.Click on the same link in catchall. 
                CloseCurrentTab();
                ControlToPreviousWindow();
                //Email.CatchAll_SearchEmailAndOpenLatestMessage(recoveryEmail + "Reset");
                Logger.WriteDebugMessage("Opened Latest Email.");
                Email.ActivationForgotPassword_CLick(ProjectName);
                LinkExpiredValidation = TestData.ExcelData.TestDataReader.ReadData(1, "LinkExpiredValidation");
                ControlToNewWindow();
                VerifyTextOnPageAndHighLight(LinkExpiredValidation);
                Logger.WriteDebugMessage("Validation message 'Wrong password recovery token' should display.");
                Logger.LogTestData(TestPlanId, TestCaseId, "Expired Link Validation", LinkExpiredValidation, true);
                CloseCurrentTab();
                ControlToPreviousWindow();

                //10.Enter the login credential with new password
                Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }
                LoginCredentials(data.MemberEmail, setPassword, ProjectName);
                Navigation.ClickMySettings(ProjectName);
                Logger.WriteDebugMessage("User sign in should be successful");

                //Reset back the Password.
                MySettings.UpdateUserPasswordwithCase(setPassword, "Cendyn123$", Constants.UpdateSettingsMessage, 1, ProjectName);
            }
        }

        public static void TC_219285()
        {
            if (TestCaseId == Constants.TC_219285)
            {
                //1.Navigate to Sign in page
                //2.Click on Forget Password
                //* Added this code as per changes for R#208647 for HotelIcon Client *//               
                SignIn.Click_Link_ForgotYourLogin(ProjectName);
                Logger.WriteDebugMessage("user landed on forget password page");

                //3.Without entering email click on Submit
                ForgotPassword.ClickRecover();
                string ReturnResult = Constants.InvalidEmailErrorMessage;
                Helper.ValitionMessage(ReturnResult);
                Logger.WriteDebugMessage("Validation msg requesting user to key in email address should display");

                //4.Enter white space in email field
                //5.Enter below invalid email format in Email Address fields.
                //6.Enter an email address that is not yet registered and click on Submit
                //7.Enter a email that has spacing in front and behind into the "Email" field and click on Submit
                //if (Driver.Url == ForgotPasswordURL)
                if (Driver.Url.Contains("PasswordRecovery"))
                {
                    for (int i = 1; i <= 17; i++)
                    {
                        string emailAddress = TestData.ExcelData.TestDataReader.ReadData(i, "Email Address");
                        string validationMessage = TestData.ExcelData.TestDataReader.ReadData(i, "Validation Message");
                        ForgotPassword.EnterEmail(emailAddress);
                        Logger.WriteDebugMessage("Enter Email Address :" + emailAddress);
                        ForgotPassword.ClickRecover();
                        Helper.ValitionMessage(validationMessage);
                        AddDelay(1500);
                        Logger.WriteDebugMessage("Validated Message display correctly:" + validationMessage);
                        AddDelay(1500);
                    }
                }
                else
                {
                    Logger.WriteDebugMessage("SignUp not successful");
                    TestHandling.TestFailed(new Exception("User was unable to register using email address: " + email));
                }
            }
        }

        public static void TC_219287()
        {
            if (TestCaseId == Constants.TC_219287)
            {
                Users data = new Users();
                Queries.GetActiveMemberEmail(data, ProjectName);
                string recoveryEmail, setPassword, recoveryValidation;
                //1.Navigate to Sign in page
                //2.Click on Forget Password
                //* Added this code as per changes for R#208647 for HotelIcon Client *//               
                SignIn.Click_Link_ForgotYourLogin(ProjectName);
                Logger.WriteDebugMessage("user landed on forget password page");

                //3. Click on  Cancel button 
                ForgotPassword.ClickCancel();
                if (Driver.Url.Contains(ReturntoLogin))
                    Logger.WriteDebugMessage("user landed on Sign in page");
                else
                    Assert.Fail("User is NOT Redirected to Login Page");

                //4.Click on Forget Password
                SignIn.Click_Link_ForgotYourLogin(ProjectName, data.MemberEmail);
                Logger.WriteDebugMessage("user landed on forget password page");
                Logger.LogTestData(TestPlanId, TestCaseId, "Test_Data", data.MemberEmail);

                //if (Driver.Url == ForgotPasswordURL)
                if (Driver.Url.Contains("PasswordRecovery"))
                {
                    //5. Enter an email address that is registered and click on Submit
                    recoveryValidation = TestData.ExcelData.TestDataReader.ReadData(1, "Validation Message");
                    ForgotPassword.UpdateEmail(data.MemberEmail, recoveryValidation, 1);
                    Logger.WriteDebugMessage("Forget Password Confirmation Message should be displays.");
                    Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId+"_Validation Message", recoveryValidation, true);

                    //6. Logged into Catchall Account
                    Email.LogIntoCatchAll();
                    Logger.WriteDebugMessage("User should be Logged in Catchall Account");
                    Email.CatchAll_SearchEmailAndOpenLatestMessage(data.MemberEmail); // Searched for the email                    
                    Email.ForgotPasswordEmail_Check();
                    Logger.WriteDebugMessage("Email available in catchall");

                    //7. Click on the link to change the password            
                    Email.ActivationForgotPassword_CLick(ProjectName);
                    //Helper.ControlToNewWindow();
                    //ControlToNewWindow();
                    //CloseWindow();
                    ControlToNewWindow();
                    Logger.WriteDebugMessage("User should be landed on password reset page");

                    //8. Enter Password in New Password and Confirm Password Field.
                    setPassword = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                    ForgotPassword.ForgotPasswordNew(setPassword,Constants.ForgotPassword_PassRecoverySuccess, 0);

                    //9. Navigate to sign in page
                    Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
                    Logger.WriteDebugMessage("User landed on sign in page");

                    //10.Enter the login credential with new password
                    if (ProjectName.Equals("Hotelicon"))
                    {
                        Navigation.Click_Button_SignIn();
                    }

                    LoginCredentials(data.MemberEmail, setPassword, ProjectName);
                    string title = Helper.Driver.Title;
                    SignIn.VerifyLandingPage(ProjectName, title);
                    Logger.WriteDebugMessage("User sign in should be successful");
                    
                    //Reset back the Password.
                    Navigation.ClickMySettings(ProjectName);
                    MySettings.UpdateUserPasswordwithCase(setPassword, ProjectDetails.CommonFrontendPassword, Constants.UpdateSettingsMessage, 1, ProjectName);

                }
                else
                {
                    Logger.WriteDebugMessage("SignUp not successful");
                    TestHandling.TestFailed(new Exception("User was unable to register using email address: " + email));
                }
            }
        }

        public static void TC_219288()
        {
            if (TestCaseId == Constants.TC_219288)
            {
                Users data = new Users();
                string recoveryEmail, setPassword, validationMessage, scenario;
                //1.Navigate to Sign in page
                //2.Click on Forget Password
                //* Added this code as per changes for R#208647 for HotelIcon Client *//               
                SignIn.Click_Link_ForgotYourLogin(ProjectName);
                Logger.WriteDebugMessage("user landed on forget password page");

                //3.Enter a registered email as click on submit
                Queries.GetActiveMemberEmail(data, ProjectName);
                string recoveryValidation = Constants.ConfirmRecovery;
                ForgotPassword.UpdateEmail(data.MemberEmail, recoveryValidation, 1);
                Logger.WriteDebugMessage("user landed on forget password page");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId+"_Test_Data", data.MemberEmail);

                //4.Verify the application triggered forget password email and email is available in catchall
                Email.LogIntoCatchAll(); //  Logged into Hotmail Account
                Email.CatchAll_SearchEmailAndOpenLatestMessage(data.MemberEmail); // Searched for the email
                Email.ForgotPasswordEmail_Check();
                Logger.WriteDebugMessage("Email available in catchall");

                //5.click on the link to change the password
                Email.ActivationForgotPassword_CLick(ProjectName);
                //Helper.ControlToNewWindow();
                //ControlToNewWindow();
                //CloseWindow();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("user landed on password reset page");

                //6. Enter mismatch details in New Password and Confirm Password Field.
                scenario = TestData.ExcelData.TestDataReader.ReadData(1, "Scenario");
                setPassword = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                validationMessage = TestData.ExcelData.TestDataReader.ReadData(1, "Validation Message");
                Logger.WriteDebugMessage(scenario + "is tested");
                ForgotPassword.ForgotPasswordNew(setPassword, validationMessage, 2);


                //7.Enter password and Confirm Password as old password Click on submit
                scenario = TestData.ExcelData.TestDataReader.ReadData(2, "Scenario");
                setPassword = TestData.ExcelData.TestDataReader.ReadData(2, "Password");
                Logger.WriteDebugMessage(scenario + "is tested");
                validationMessage = TestData.ExcelData.TestDataReader.ReadData(2, "Validation Message");
                ForgotPassword.ForgotPasswordNew(setPassword, validationMessage, 1);

                //8.Enter Invalid data in Password and Confirm Password Field
                if (Driver.Url.Contains("PasswordRecoveryConfirm"))
                {
                    for (int i = 3; i <= 6; i++)
                    {
                        setPassword = TestData.ExcelData.TestDataReader.ReadData(i, "Password");
                        validationMessage = TestData.ExcelData.TestDataReader.ReadData(i, "Validation Message");
                        scenario = TestData.ExcelData.TestDataReader.ReadData(i, "Scenario");
                        Logger.WriteDebugMessage(scenario + "is tested");
                        ForgotPassword.ForgotPasswordNew(setPassword, validationMessage, 1);
                        Logger.LogTestData(TestPlanId, TestCaseId, i+" Password", setPassword);
                        if (i == 6)
                            Logger.LogTestData(TestPlanId, TestCaseId, i + " Validation Message", validationMessage, true);
                        else
                            Logger.LogTestData(TestPlanId, TestCaseId, i + " Validation Message", validationMessage);
                    }
                }
            }
        }

        //Commented the Test cases as related to V3 and not added in Global test plan
        //V3
        /*
        public static void TC_119830()
        {

            string pwdToken = "";
            string PaswwordRecoveryLink = ProjectDetails.CommonFrontendURL + "/en-US/Login/PasswordRecoveryConfirm?token=";

            Users data = new Users();

            if (TestCaseId == Constants.TC_119830)
            {
                //1.URL is available in master testplan run description
                //2.Data Requirement: None
                //3.Navigate to Sign in page
                //4.Click on Forget Password
                //*Added this code as per changes for R#208647 for HotelIcon Client/
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }
                else if (ProjectName.Equals("IndependentCollection"))
                {
                    SignIn.EnterText_Text_Email(ProjectDetails.CommonFrontendEmail);
                    SignIn.Click_Button_Next();
                }

                SignIn.Click_Link_ForgotYourLogin(ProjectName);
                AddDelay(3000);
                Logger.WriteDebugMessage("user landed on forget password page");

                //if (Driver.Url == ForgotPasswordURL)
                if (Driver.Url.Contains("PasswordRecovery"))
                {
                    Logger.WriteDebugMessage("Landed on the Password Recovery page.");

                    //5.Without entering email click on Submit
                    ForgotPassword.ClickRecover();
                    string ReturnResult = Constants.InvalidEmailErrorMessage;
                    Helper.ValitionMessage(ReturnResult);
                    Logger.WriteDebugMessage("Validated Message display correctly:" + ReturnResult);

                    //6.Enter white space in email field 
                    ForgotPassword.EnterEmail(" ");
                    Helper.ValitionMessage(ReturnResult);
                    Logger.WriteDebugMessage("Validated Message display correctly:" + ReturnResult);
                }
                else
                {
                    Logger.WriteDebugMessage("SignUp not successful");
                    TestHandling.TestFailed(new Exception("User was unable to register using email address: " + email));
                }
            }
        }

        public static void TC_119831()
        {
            if (TestCaseId == Constants.TC_119831)
            {
                //1.URL is available in master testplan run description
                //2.Data Requirement: Registered email and its password
                //3.Navigate to Sign in page
                //4.Click on Forget Password
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }
                else if (ProjectName.Equals("IndependentCollection"))
                {
                    SignIn.EnterText_Text_Email(ProjectDetails.CommonFrontendEmail);
                    SignIn.Click_Button_Next();
                }

                ForgotPassword.ForgotPassword_LinkText();
                Helper.ElementWait(PageObject_ForgotPassword.ForgotPassword_Recover(), 60);
                string emailaddress = Queries.ReturnLoyaltyEmail();
                if (Driver.Url.Contains("PasswordRecovery"))
                {
                    Logger.WriteDebugMessage("Landed on the Password Recovery page.");

                    //5.Enter registered email and click on submit
                    string recoveryEmail = Constants.ConfirmRecovery;
                    ForgotPassword.UpdateEmail(emailaddress, recoveryEmail, 1);
                }
                else
                {
                    Logger.WriteDebugMessage("Page did not land on Password Recovery Page.");
                    TestHandling.TestFailed(new Exception("Page did not land on Password Recovery Page."));
                }

                //6.Verify the application triggered forget password email and email is available in catchall
                Email.LogIntoCatchAll(); //  Logged into Hotmail Account
                Email.CatchAll_SearchEmailAndOpenLatestMessage(emailaddress); // Searched for the email
                Logger.WriteDebugMessage("Email available in catchall");

                //7.click on the link to change the password
                Email.ForgotPasswordEmail_Check();
                Email.ActivationForgotPassword_CLick(ProjectName);
                AddDelay(5000);

                //8.Enter password and Confirm Password as old password Click on submit
                Helper.ControlToNewWindow();
                Helper.ElementWait(PageObject_ForgotPassword.ForgotPassword_Recovery(), 60);
                if (Driver.Url.Contains("PasswordRecoveryConfirm"))
                {
                    Logger.WriteDebugMessage("Landed on Reset Password Page.");
                    ForgotPassword.ForgotPasswordNew(ProjectDetails.CommonFrontendPassword,
                        Constants.NewPasswordCannotBeSameMessage, 1);
                }
                else
                {
                    Logger.WriteDebugMessage("Page did not land on Reset Password Page.");
                    TestHandling.TestFailed(new Exception("Page did not land on Reset Password Page."));
                }
            }
        }

        public static void TC_119832()
        {
            if (TestCaseId == Constants.TC_119832)
            {
                //1.URL is available in master testplan run description
                //2.Data Requirement: email that got registered and email that is not registered
                //3.Navigate to Sign in page
                //4.Click on Forget password
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }
                else if (ProjectName.Equals("IndependentCollection"))
                {
                    SignIn.EnterText_Text_Email(ProjectDetails.CommonFrontendEmail);
                    SignIn.Click_Button_Next();
                }

                ForgotPassword.ForgotPassword_LinkText();
                Helper.ElementWait(PageObject_ForgotPassword.ForgotPassword_Recover(), 60);
                if (Driver.Url.Contains("PasswordRecovery"))
                {
                    Logger.WriteDebugMessage("Landed on the Password Recovery page.");

                    //5.Enter an email address that is not yet registered and click on Submit:Say test@Cendyn17.com
                    string recoveryEmail = Constants.ConfirmationMessage_InvalidEmail;
                    ForgotPassword.UpdateEmail(TestData.TC_119832_UnregisteredEmail, recoveryEmail, 2);
                    Helper.ReloadPage();
                    AddDelay(5000);
                    //6.Enter an email address that is registered and click on Submit: If you don't have one register an email and use that email
                    recoveryEmail = Constants.ConfirmRecovery;
                    Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
                    AddDelay(5000);
                    //*Added this code as per changes for R#208647 for HotelIcon Client*
                    if (ProjectName.Equals("HotelIcon"))
                    {
                        Navigation.Click_Button_SignIn();
                    }
                    else if (ProjectName.Equals("IndependentCollection"))
                    {
                        SignIn.EnterText_Text_Email(ProjectDetails.CommonFrontendEmail);
                        SignIn.Click_Button_Next();
                    }

                    ForgotPassword.ForgotPassword_LinkText();
                    AddDelay(5000);
                    ForgotPassword.UpdateEmail(ProjectDetails.TC_119832_RegisteredEmail, recoveryEmail, 1);
                    Logger.WriteDebugMessage(
                         "Confirmation msg regarding  password reset is sent  to  entered email address");
                }
                else
                {
                    Logger.WriteDebugMessage("Page did not land on Password Recovery Page.");
                    TestHandling.TestFailed(new Exception("Page did not land on Password Recovery Page."));
                }

                //7.click link in the mail
                Email.LogIntoCatchAll(); //  Logged into Hotmail Account
                Email.CatchAll_SearchEmailAndOpenLatestMessage(ProjectDetails.TC_119832_RegisteredEmail); // Searched for the email
                Email.ForgotPasswordEmail_Check();
                AddDelay(2500);
                Email.ActivationForgotPassword_CLick(ProjectName);
                AddDelay(5000);
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Option to enter Password and Confirm Password gets displayed");

                //8.Enter a valid password in both the field
                //9.Click on submit
                Helper.ElementWait(PageObject_ForgotPassword.ForgotPassword_Recovery(), 60);
                if (Driver.Url.Contains("PasswordRecoveryConfirm"))
                {
                    Logger.WriteDebugMessage("Landed on Reset Password Page.");
                    ForgotPassword.ForgotPasswordNew(ProjectDetails.CommonFrontendPassword,
                        Constants.NewPasswordCannotBeSameMessage, 1);
                    Logger.WriteDebugMessage("Confirmation msg on successful password reset gets displayed");
                }

                //10.Navigate to sign in page
                Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
                AddDelay(2500);
                Logger.WriteDebugMessage("User landed on sign in page");

                //11.Enter the login credential with new password
                LoginCredentials(ProjectDetails.TC_119832_RegisteredEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("User sign in should be successful");

                if (Driver.Url == LoginLand || Helper.IsElementVisible(PageObject_Navigation.Link_MySettings()) ||
                    Helper.IsElementVisible(PageObject_Navigation.LinkText_MySettings(ProjectName)))
                {
                    string PageTitle = Driver.Title;
                    Helper.RegexFunction(PageTitle, pattern);
                }


            }
        }

        public static void TC_119833()
        {
            if (TestCaseId == Constants.TC_119833)
            {
                //1.URL is available in master testplan run description
                //2.Data Requirement: none
                //3.Navigate to Sign in page
                //4.Click on Forget password
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }
                else if (ProjectName.Equals("IndependentCollection"))
                {
                    SignIn.EnterText_Text_Email(ProjectDetails.CommonFrontendEmail);
                    SignIn.Click_Button_Next();
                }

                ForgotPassword.ForgotPassword_LinkText();
                Helper.ElementWait(PageObject_ForgotPassword.ForgotPassword_Recover(), 60);
                if (Driver.Url.Contains("PasswordRecovery"))
                {
                    Logger.WriteDebugMessage("Landed on the Password Recovery page.");
                }

                //5.Enter email as plainaddress and click on submit
                //6.Enter email as #@%^%#$@#$@#.com and click on submit
                string recoveryEmail = Constants.EmailFormat;
                ForgotPassword.UpdateEmail(ProjectDetails.TC_119833_EmailAddress1, recoveryEmail, 2);
                Logger.WriteDebugMessage("Email is not acceptable as Garbage");

                //7.Enter email as @domain.com and click on submit
                ForgotPassword.UpdateEmail(ProjectDetails.TC_119833_EmailAddress2, recoveryEmail, 2);
                Logger.WriteDebugMessage("Email is not acceptable as Missing username");

                //8.Enter email as Joe Smith and click on submit
                ForgotPassword.UpdateEmail(ProjectDetails.TC_119833_EmailAddress3, recoveryEmail, 2);
                Logger.WriteDebugMessage("Email is not acceptable as Encoded html within email is invalid");

                //9.Enter email as email.domain.com and click on submit
                ForgotPassword.UpdateEmail(ProjectDetails.TC_119833_EmailAddress4, recoveryEmail, 2);
                Logger.WriteDebugMessage("Email is not acceptable as Missing @");

                //10.Enter email as email@domain@domain.com and click on submit
                ForgotPassword.UpdateEmail(ProjectDetails.TC_119833_EmailAddress5, recoveryEmail, 2);
                Logger.WriteDebugMessage("Email is not acceptable as two @ sign");

                //11.Enter email as .email@domain.com and click on submit
                ForgotPassword.UpdateEmail(ProjectDetails.TC_119833_EmailAddress6, recoveryEmail, 2);
                Logger.WriteDebugMessage("Email is not acceptable as Leading dot in address is not allowed");

                //12.Enter email as email.@domain.com and click on submit
                ForgotPassword.UpdateEmail(ProjectDetails.TC_119833_EmailAddress7, recoveryEmail, 2);
                Logger.WriteDebugMessage("Email is not acceptable as Trailing dot in address is not allowed");

                //13.Enter email as email..email@domain.com and click on submit
                ForgotPassword.UpdateEmail(ProjectDetails.TC_119833_EmailAddress8, recoveryEmail, 2);
                Logger.WriteDebugMessage("Email is not acceptable as Multiple dots");

                //14.Enter email as email@domain.com (Joe Smith) and click on submit
                ForgotPassword.UpdateEmail(ProjectDetails.TC_119833_EmailAddress9, recoveryEmail, 2);
                Logger.WriteDebugMessage("Email is not acceptable as Text followed email is not allowed");

                //15.Enter email as email@domain and click on submit    
                ForgotPassword.UpdateEmail(ProjectDetails.TC_119833_EmailAddress10, recoveryEmail, 2);
                Logger.WriteDebugMessage("Email is not acceptable as Missing top level domain (.com/.net/.org/etc.)");

                //16.Enter email as email@-domain.com and click on submit   
                ForgotPassword.UpdateEmail(ProjectDetails.TC_119833_EmailAddress11, recoveryEmail, 2);
                Logger.WriteDebugMessage("Email is not acceptable as Leading dash in front of domain is invalid");

                //17.Enter email as email@domain.web and click on submit
                //recoveryEmail = Constants.ConfirmationMessage_InvalidEmail;
                //ForgotPassword.UpdateEmail(TestData.TC_119833_EmailAddress12, recoveryEmail, 2);
                //Logger.WriteDebugMessage("Email is not acceptable as .web is not a valid top level domain");

                //18.Enter email as email@111.222.333.44444 and click on submit
                recoveryEmail = Constants.EmailFormat;
                ForgotPassword.UpdateEmail(ProjectDetails.TC_119833_EmailAddress13, recoveryEmail, 2);
                Logger.WriteDebugMessage("Email is not acceptable as Invalid IP format");

                //19.Enter email as email@domain..com and click on submit
                ForgotPassword.UpdateEmail(ProjectDetails.TC_119833_EmailAddress14, recoveryEmail, 2);
                Logger.WriteDebugMessage("Email is not acceptable as Multiple dot in the domain portion is invalid");


            }
        }

        public static void TC_119836()
        {
            if (TestCaseId == Constants.TC_119836)
            {
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }
                else if (ProjectName.Equals("IndependentCollection"))
                {
                    SignIn.EnterText_Text_Email(ProjectDetails.CommonFrontendEmail);
                    SignIn.Click_Button_Next();
                }

                ForgotPassword.ForgotPassword_LinkText();
                Helper.ElementWait(PageObject_ForgotPassword.ForgotPassword_Recover(), 60);
                if (Driver.Url.Contains("PasswordRecovery"))
                {
                    Logger.WriteDebugMessage("Landed on the Password Recovery page.");
                }

                string recoveryEmail = Constants.ConfirmRecovery;
                ForgotPassword.UpdateEmail("jshah@cendyn.com", recoveryEmail, 1);

                //Gmail.NavigateAndLogIntoGmail();

                //Email.LogIntoCatchAll();      //  Logged into Hotmail Account
                //Email.CatchAll_SearchEmailAndOpenLatestMessage(TestData.TC_119831_Email); // Searched for the email

                //Email.ForgotPasswordEmail_Check();

                //Email.ActivationForgotPassword_CLick(ProjectName);
                //bool GetURL = Driver.Url.Contains("PasswordRecoveryConfirm");
                //if (GetURL == true)
                //{
                //    Logger.WriteDebugMessage("Landed on Reset Password Page.");

                //    ForgotPassword.ForgotPasswordNew(TestData.CommonFrontendPassword, Constants.NewPasswordCannotBeSameMessage, 1);
                //}

            }
        }

        public static void TC_119837()
        {
            if (TestCaseId == Constants.TC_119837)
            {
                //1.URL is available in master testplan run description
                //2.Data Requirement: Registered email
                //3.Navigate to Sign in page
                //4.Click on Forget Password
                //*Added this code as per changes for R#208647 for HotelIcon Client
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }
                else if (ProjectName.Equals("IndependentCollection"))
                {
                    SignIn.EnterText_Text_Email(ProjectDetails.CommonFrontendEmail);
                    SignIn.Click_Button_Next();
                }

                ForgotPassword.ForgotPassword_LinkText();
                Helper.ElementWait(PageObject_ForgotPassword.ForgotPassword_Recover(), 60);
                if (Driver.Url.Contains("PasswordRecovery"))
                {
                    Logger.WriteDebugMessage("Landed on the Password Recovery page.");
                }

                //5.Enter a registered email as click on submit
                string recoveryEmail = Constants.ConfirmRecovery;
                ForgotPassword.UpdateEmail(ProjectDetails.TC_119837_RegisteredEmail, recoveryEmail, 1);
                Logger.WriteDebugMessage(
                    "Confirmation msg regarding  password reset is sent  to  entered email address ");
                AddDelay(7000);

                //6.Verify the application triggered forget password email and email is available in catchall
                Email.LogIntoCatchAll(); //  Logged into Hotmail Account
                Email.CatchAll_SearchEmailAndOpenLatestMessage(ProjectDetails.TC_119837_RegisteredEmail); // Searched for the email
                Email.ForgotPasswordEmail_Check();
                Logger.WriteDebugMessage("email available in catchall");

                //7.click on the link to change the password
                Email.ActivationForgotPassword_CLick(ProjectName);
                AddDelay(5000);
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("user landed on password reset page");

                //8.Enter Password and Confirm password as 'ccendyn1' ( no upper case)
                Helper.ElementWait(PageObject_ForgotPassword.ForgotPassword_Recovery(), 60);
                if (Driver.Url.Contains("PasswordRecoveryConfirm"))
                {
                    Logger.WriteDebugMessage("Landed on Reset Password Page.");
                    ForgotPassword.ForgotPasswordNew(ProjectDetails.CommonFrontendPassword, Constants.PassworddonotMatch, 2);
                    Logger.WriteDebugMessage("Message confirming that password fields are not matching should display");
                }
            }
        }

        public static void TC_119838()
        {
            if (TestCaseId == Constants.TC_119838)
            {
                //1.URL is available in master testplan run description
                //2.Data Requirement: Registered email
                //3.Navigate to Sign in page
                //4.Click on Forget Password
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }
                else if (ProjectName.Equals("IndependentCollection"))
                {
                    SignIn.EnterText_Text_Email(ProjectDetails.CommonFrontendEmail);
                    SignIn.Click_Button_Next();
                }

                ForgotPassword.ForgotPassword_LinkText();
                Helper.ElementWait(PageObject_ForgotPassword.ForgotPassword_Recover(), 60);
                if (Driver.Url.Contains("PasswordRecovery"))
                {
                    Logger.WriteDebugMessage("Landed on the Password Recovery page.");
                }

                //5.Enter a registered email as click on submit
                string recoveryEmail = Constants.ConfirmRecovery;
                ForgotPassword.UpdateEmail(ProjectDetails.TC_119838_RegisteredEmail, recoveryEmail, 1);
                Logger.WriteDebugMessage(
                    "Confirmation msg regarding  password reset is sent  to  entered email address Note: email should be available in Catchall");
                AddDelay(7000);

                //6.Verify the application triggered forget password email and email is available in catchall
                Email.LogIntoCatchAll(); //  Logged into Hotmail Account
                Email.CatchAll_SearchEmailAndOpenLatestMessage(ProjectDetails.TC_119838_RegisteredEmail); // Searched for the email
                Email.ForgotPasswordEmail_Check();
                Logger.WriteDebugMessage("Email available in catchall");

                //7.click on the link to change the password
                Email.ActivationForgotPassword_CLick(ProjectName);
                AddDelay(5000);
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("user landed on password reset page");

                Helper.ElementWait(PageObject_ForgotPassword.ForgotPassword_Recovery(), 60);
                if (Driver.Url.Contains("PasswordRecoveryConfirm"))
                {
                    Logger.WriteDebugMessage("Landed on Reset Password Page.");
                    //8.Enter Password and Confirm password as 'ccendyn1' ( no upper case)
                    ForgotPassword.ForgotPasswordNew(ProjectDetails.TC_119838_NewPassword1,
                        Constants.PasswordValidationMessage, 1);
                    Logger.WriteDebugMessage(
                        "Change Password is not successful. Validation msg 'The new password does not meet the password requirements.'");

                    //9.Enter Password and Confirm password as 'CCENDYN1' ( no lowercase case)
                    ForgotPassword.ForgotPasswordNew(ProjectDetails.TC_119838_NewPassword2,
                        Constants.PasswordValidationMessage, 1);
                    Logger.WriteDebugMessage(
                        "Change Password is not successful. Validation msg 'The new password does not meet the password requirements.'");

                    //10.Enter Password and Confirm password as 'cCCENDYN' ( no digit)
                    ForgotPassword.ForgotPasswordNew(ProjectDetails.TC_119838_NewPassword3,
                        Constants.PasswordValidationMessage, 1);
                    Logger.WriteDebugMessage(
                        "Change Password is not successful. Validation msg 'The new password does not meet the password requirements.'");

                    //11.Enter Password and Confirm password as 'Cendyn1' ( not 8 character )
                    ForgotPassword.ForgotPasswordNew(ProjectDetails.TC_119838_NewPassword4,
                        Constants.PasswordValidationMessage, 1);
                    Logger.WriteDebugMessage(
                        "Change Password is not successful. Validation msg 'The new password does not meet the password requirements.'");
                }
            }
        }

        public static void TC_119840()
        {
            if (TestCaseId == Constants.TC_119840)
            {
                //1.URL is available in master testplan run description
                //2.Navigate to Sign in page
                //3.Click on Forget Password
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }
                else if (ProjectName.Equals("IndependentCollection"))
                {
                    SignIn.EnterText_Text_Email(ProjectDetails.CommonFrontendEmail);
                    SignIn.Click_Button_Next();
                }

                ForgotPassword.ForgotPassword_LinkText();
                Helper.ElementWait(PageObject_ForgotPassword.ForgotPassword_Recover(), 60);
                if (Driver.Url.Contains("PasswordRecovery"))
                {
                    Logger.WriteDebugMessage("Landed on the Password Recovery page.");
                }

                //4. Click on  Cancel button 
                ForgotPassword.ClickCancel();
                if (Driver.Url == ReturntoLogin)
                {
                    Logger.WriteDebugMessage("user landed on Sign in page");
                }
            }
        }

        public static void TC_124897()
        {
            if (TestCaseId == Constants.TC_124897)
            {
                //1.Click "Forgot Your Login?"
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }
                else if (ProjectName.Equals("IndependentCollection"))
                {
                    SignIn.EnterText_Text_Email(ProjectDetails.CommonFrontendEmail);
                    SignIn.Click_Button_Next();
                }

                ForgotPassword.ForgotPassword_LinkText();
                Helper.ElementWait(PageObject_ForgotPassword.ForgotPassword_Recover(), 60);
                if (Driver.Url.Contains("PasswordRecovery"))
                {
                    Logger.WriteDebugMessage("Landed on the Password Recovery page.");
                }

                //2.Enter existing/new catchall email into email field.
                //3.Click "Recover."
                string recoveryEmail = Constants.ConfirmRecovery;
                ForgotPassword.UpdateEmail("jshah@cendyn.com", recoveryEmail, 2);
                Logger.WriteDebugMessage("Confirmation page displays.");

                //4.Check catchall for the recovery email.
                Email.LogIntoCatchAll(); //  Logged into Hotmail Account
                Email.CatchAll_SearchEmailAndOpenLatestMessage("jshah@cendyn.com"); // Searched for the email
                Email.ForgotPasswordEmail_Check();
                Email.ActivationForgotPassword_CLick(ProjectName);
                AddDelay(5000);

                Helper.ControlToNewWindow();
                Helper.ElementWait(PageObject_ForgotPassword.ForgotPassword_Recovery(), 60);
                if (Driver.Url.Contains("PasswordRecoveryConfirm"))
                {
                    Logger.WriteDebugMessage("Landed on Reset Password Page.");
                    ForgotPassword.ForgotPasswordNew(ProjectDetails.CommonFrontendPassword,
                        Constants.ForgotPassword_PassRecoverySuccess, 2);
                }

                if (Driver.Url == ProjectDetails.CommonFrontendURL + "/en-US/Login")
                {
                    Logger.WriteDebugMessage("Landed on SignIn Page after successfully recovery new password.");
                    Helper.ControlToPreviousWindow();
                    Email.ActivationForgotPassword_CLick(ProjectName);
                    string ValidationMessage = Constants.ForgotPassword_RecoveryLinkExpired2;
                    Helper.ValitionMessage(ValidationMessage);
                }
            }
        }

        public static void TC_124898()
        {
            if (TestCaseId == Constants.TC_124898)
            {
                //1.Click "Forgot Your Login?"
                string recoveryEmail;
                //*Added this code as per changes for R#208647 for HotelIcon Client*
                if (ProjectName.Equals("HotelIcon"))
                {
                    Navigation.Click_Button_SignIn();
                }
                else if (ProjectName.Equals("IndependentCollection"))
                {
                    SignIn.EnterText_Text_Email(ProjectDetails.CommonFrontendEmail);
                    SignIn.Click_Button_Next();
                }

                ForgotPassword.ForgotPassword_LinkText();
                Helper.ElementWait(PageObject_ForgotPassword.ForgotPassword_Recover(), 60);
                if (Driver.Url.Contains("PasswordRecovery"))
                {
                    Logger.WriteDebugMessage("Landed on the Password Recovery page.");
                }

                //2.Enter a email that has spacing in front and behind into the "Email" field.
                //3.Click "Recover."
                if (ProjectName.Equals("Sarova"))
                {
                    recoveryEmail =
                        "An email with instructions has been sent to you. Please check your email to reset your password.";
                }
                else
                {
                    recoveryEmail = Constants.ConfirmRecovery;
                }

                ForgotPassword.UpdateEmail(ProjectDetails.TC_124898_Email, recoveryEmail, 3);
                Logger.WriteDebugMessage("Confirmation page displays.");

                //Email.LogIntoCatchAll();      //  Logged into Hotmail Account
                //Email.CatchAll_SearchEmailAndOpenLatestMessage(TestData.TC_124898_Email); // Searched for the email
                //Email.ForgotPasswordEmail_Check();
            }
        }
        */
        #endregion TP_121737
    }
}
