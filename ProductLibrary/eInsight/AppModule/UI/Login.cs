using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseUtility.Utility;
using InfoMessageLogger;
using Common;
using OpenQA.Selenium;
using eInsight.PageObject.UI;
using eInsight.Utility;
using BaseUtility.Utility.Hotmail;
using NUnit.Framework;

namespace eInsight.AppModule.UI
{
    class Login : Helper
    {

        /// <summary>
        /// This method will enter the user name on the eInsight login page.
        /// </summary>
        /// <param name="username">Username to enter.</param>
        public static void EnterUserName(string username)
        {
            ElementEnterText(PageObject_Login.Email(), username);
        }

        /// <summary>
        /// This method will enter the password on the eInsight login page.
        /// </summary>
        /// <param name="password">Password to enter.</param>
        public static void EnterPassword(string password)
        {
            ElementEnterText(PageObject_Login.Password(), password);
        }

        /// <summary>
        /// This method will click the Forgot Password link on the eInsight login page.
        /// </summary>
        public static void ClickForgotPassword()
        {
            ElementClick(PageObject_Login.ForgotPassword());
        }

        public static void Click_Button_ForgotPassword_Submit()
        {
            ElementClick(PageObject_Login.Button_ForgotPassword_Submit());
        }

        public static void EnterText_Text_ForgotPassword_Email(string text)
        {
            ElementEnterText(PageObject_Login.Text_ForgotPassword_Email(), text);
        }
        public static void Click_ResetPassword()
        {
            ScrollToElement(PageObject_Login.ResetPassword());
            Logger.WriteDebugMessage("Clicking on Reset Password.");
            ElementClick(PageObject_Login.ResetPassword());
            ControlToNewWindow();
            if (Driver.Url.Contains("ForgotPassword.mvc/ForgotPassword"))
            {
                Logger.WriteDebugMessage("Landed on Reset Password Page.");
            }
        }
        private static void EnterText_NewPassword(string password)
        {
            ElementEnterText(PageObject_Login.NewPassword(), password);
        }
        private static void EnterText_NewConfirmPassword(string password)
        {
            ElementEnterText(PageObject_Login.ConfirmPassword(), password);
        }

        public static void EnterNewPasswords(string password)
        {
            EnterText_NewPassword(password);
            Logger.WriteDebugMessage("Entered New Password - " + password);
            EnterText_NewConfirmPassword(password);
            Logger.WriteDebugMessage("Entered New Confirm Password - " + password);
            ElementClick(PageObject_Login.ResetPassword_Submit());
            Logger.WriteDebugMessage("New Password Submitted");
            if (IsElementPresent(By.Id("Submit")))
            {
                Logger.WriteDebugMessage("Landed on Login Page.");
            }
            else if (IsElementPresent(By.Id("submit")))
            {
                Logger.WriteDebugMessage("Landed on Login Page.");
            }
            else
            {
                Assert.Fail("Did not land on Login Page after submitting new Password.");
            }
        }

        /// <summary>
        /// This method will click the Submit button on the eInsight login page.
        /// </summary>
        public static void ClickSubmit()
        {
            if (IsElementPresent(By.Id("Submit")))
            {
                ElementClick(Driver.FindElement(By.Id("Submit")));
            }
            else
            {
                ElementClick(Driver.FindElement(By.Id("submit")));
            }
        }


        public static void CommonLogin(string CommonFrontendURL)
        {
            Driver.Navigate().GoToUrl(CommonFrontendURL);
            AddDelay(1000);
            if (CommonFrontendURL != "https://qa2einsight.cendyn.com/")
            {
                string IFrame = "//iframe[@title='TrustArc Cookie Consent Manager']";
                if (IsElementPresent(By.XPath(IFrame)))
                {
                    Driver.SwitchTo().Frame(Driver.FindElement(By.XPath(IFrame)));

                    ElementWait(PageObject_Login.Login_IFrame_AgreeProceed(), 180);
                    ElementClick(PageObject_Login.Login_IFrame_AgreeProceed());
                    ElementWait(PageObject_Login.Login_IFrame_AgreeProceed_Close(), 180);
                    ElementClick(PageObject_Login.Login_IFrame_AgreeProceed_Close());

                    Driver.SwitchTo().DefaultContent();
                   
                }
            }
            ElementWait(PageObject_Login.Email(), 10);
            EnterUserName(LegacyTestData.CommonFrontendEmail);
            Profile.ClickAddGuestsNext();
            EnterPassword(LegacyTestData.CommonFrontendPassword);
            ClickSubmit();

            PageLoadWait(240, CommonFrontendURL + "home.mvc/home");
            if (Driver.Url.Contains("home.mvc/home"))
            {
                if (IsElementPresent(By.Id("helpiq_tb_closeWindowButton")))
                {
                    ElementClick(Driver.FindElement(By.Id("helpiq_tb_closeWindowButton")));
                }

                Logger.WriteDebugMessage("Logged in to URL: " + CommonFrontendURL + " with UserName - " + LegacyTestData.CommonFrontendEmail + " and Password " + LegacyTestData.CommonFrontendPassword + ". Landed on eInsight Home Page.");
            }
            else
            {
                Assert.Fail("Unable to land on Home Page.");
            }

        }

        public static void Login_Test(string CommonFrontendURL, string caseType, int isDisabled)
        {
            Driver.Navigate().GoToUrl(CommonFrontendURL);
            if (isDisabled == 0)
            {
                if (CommonFrontendURL != "https://qa2einsight.cendyn.com/")
                {
                    Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//iframe[@title='TrustArc Cookie Consent Manager']")));
                    AddDelay(8000);
                    if (IsElementPresent(By.XPath("//a[contains(text(),'Accept all Cookies')]")))
                    {
                        ElementClick(PageObject_Login.Login_IFrame_AgreeProceed());
                        if (IsElementPresent(By.XPath("//a[contains(text(),'Close')]")))
                        {
                            ElementClick(Driver.FindElement(By.XPath("//a[contains(text(),'Close')]")));
                        }

                    }
                    Driver.SwitchTo().ParentFrame();
                }
            }

            ElementWait(Driver.FindElement(By.Id("Username")), 60);

            switch (caseType)
            {
                case "fakepass":
                    for (int j = 4; j >= 0; --j)
                    {
                        EnterUserName(LegacyTestData.CommonFrontendEmail);
                        EnterPassword(LegacyTestData.CommonFrontendPassword + "1");
                        ClickSubmit();
                        if (VerifyTextOnPage("Username or password incorrect. You will be locked after " + j + " times"))
                        {
                            Logger.WriteDebugMessage("Received Error Message." + "Username or password incorrect. You will be locked after " + j + " times");
                        }
                        if (VerifyTextOnPage("This account is locked, please check your email for further instruction. For support please contact Cendyn at 1-800-656-9114."))
                        {
                            Logger.WriteDebugMessage("Received Error message." + "This account is locked, please check your email for further instruction. For support please contact Cendyn at 1-800-656-9114.");
                        }
                    }
                    break;
                case "originalpass":
                    EnterUserName(LegacyTestData.CommonFrontendEmail);
                    EnterPassword(LegacyTestData.CommonFrontendPassword);
                    ClickSubmit();
                    ElementWait(Driver.FindElement(By.Id("profile")), 60);
                    if (Driver.Url.Contains("home.mvc/home"))
                    {
                        if (IsElementPresent(By.Id("helpiq_tb_closeWindowButton")))
                        {
                            ElementClick(Driver.FindElement(By.Id("helpiq_tb_closeWindowButton")));
                        }
                        AddDelay(8000);
                        Logger.WriteDebugMessage("Logged in to URL: " + CommonFrontendURL + " with UserName - " + LegacyTestData.CommonFrontendEmail + " and Password " + LegacyTestData.CommonFrontendPassword + ". Landed on eInsight Home Page.");
                    }
                    else
                    {
                        Assert.Fail("Unable to land on Home Page.");
                    }
                    break;
            }
        }

        public static void AutoAcc_login(string Email, int typeofLogin, int typeofNavigation, string webURL, int searchEmailtype)
        {
            Hotmail.NavigateToWebmail(webURL);
            ControlToNewWindow();
            if (IsElementPresent(By.Id("otherTileText")))
            {
                ElementClick(Driver.FindElement(By.Id("otherTileText")));
            }
            switch (typeofLogin)
            {
                case 1:
                    Hotmail.AutomationAcc_SignIn(LegacyTestData.CommonCatchallUserName, LegacyTestData.CommonCatchallPassword);
                    break;
                case 2:
                    Hotmail.AutomationAcc_SignIn(LegacyTestData.CommonFrontendEmail, LegacyTestData.CommonAutomationPassword);
                    break;
            }
            //ControlToPreviousWindow();
            //CloseCurrentTab();
            ControlToNewWindow();
            switch (typeofNavigation)
            {
                case 0:
                    Hotmail.SearchEmailAndOpenLatestEmail(Email, searchEmailtype);
                    break;
                case 1:
                    Hotmail.OpenLatestEmailReceived();
                    break;
                default:
                    break;
            }
            //Verify an email exists
            if (Helper.VerifyTextOnPage("We didn't find anything.") && Helper.VerifyTextOnPage("Try a different keyword."))
                Assert.Fail("No email matches search.");

            //Verify Email Recency
            Hotmail.VerifyEmailReceivedSpan(15);
        }

        public static void AccLogout()
        {
            UserActions.Click_Button_UserrAction();
            ElementClick(Driver.FindElement(By.XPath("//a[contains(text(), 'Log Out')]")));
            Logger.WriteDebugMessage("Logged out from Account.");
        }

        public static void CatchallSignout(string email)
        {
            ElementClick(Driver.FindElement(By.Id("meInitialsButton")));
            ElementClick(Driver.FindElement(By.Id("mectrl_body_signOut")));
            Logger.WriteDebugMessage("Logged out from Account.");
        }

        public static void ReLogin()
        {
            ElementWait(Driver.FindElement(By.Id("Username")), 60);
            EnterUserName(LegacyTestData.CommonFrontendEmail);
            EnterPassword(LegacyTestData.CommonFrontendPassword);
            ClickSubmit();
            ElementWait(Driver.FindElement(By.Id("profile")), 60);
        }

        public static void AutoAcc_logins(string Email, int typeofLogin, int typeofNavigation, string webURL, int searchEmailtype)
        {
            Hotmail.NavigateToWebmail(webURL);
            ControlToNewWindow();
            if (IsElementPresent(By.Id("otherTileText")))
            {
                ElementClick(Driver.FindElement(By.Id("otherTileText")));
            }
            switch (typeofLogin)
            {
                case 1:
                    Hotmail.AutomationAcc_SignIn(LegacyTestData.CommonCatchallUserName, LegacyTestData.CommonCatchallPassword);
                    break;
                case 2:
                    Hotmail.AutomationAcc_SignIn(LegacyTestData.CommonFrontendEmail, LegacyTestData.CommonAutomationPassword);
                    break;
            }
            //ControlToPreviousWindow();
            //CloseCurrentTab();
            ControlToNewWindow();
            switch (typeofNavigation)
            {
                case 0:
                    Hotmail.SearchEmailAndOpenLatestEmails(Email, searchEmailtype);
                    break;
                case 1:
                    Hotmail.OpenLatestEmailReceived();
                    break;
                default:
                    break;
            }
            //Verify an email exists
            if (Helper.VerifyTextOnPage("We didn't find anything.") && Helper.VerifyTextOnPage("Try a different keyword."))
                Assert.Fail("No email matches search.");
            //Verify Email Recency
            Hotmail.VerifyEmailReceivedSpan(15);
        }

        public static void AutoAccount_logins(string Email,string Password, int typeofLogin, int typeofNavigation, string webURL, string searchEmail, int searchEmailtype)
        {
            Hotmail.NavigateToWebmail(webURL);
            ControlToNewWindow();
            if (IsElementPresent(By.Id("otherTileText")))
            {
                ElementClick(Driver.FindElement(By.Id("otherTileText")));
            }
            switch (typeofLogin)
            {
                case 1:
                    Hotmail.AutomationCatchAll_SignIn(Email, Password);
                    break;
                case 2:
                    Hotmail.AutomationAcc_SignIn(LegacyTestData.CommonFrontendEmail, LegacyTestData.CommonAutomationPassword);
                    break;
            }
            //ControlToPreviousWindow();
            //CloseCurrentTab();
            ControlToNewWindow();
            switch (typeofNavigation)
            {
                case 0:
                    Hotmail.SearchEmailAndOpenLatestEmails(searchEmail, searchEmailtype);
                    break;
                case 1:
                    Hotmail.OpenLatestEmailReceived();
                    break;
                default:
                    break;
            }
            //Verify an email exists
            if (Helper.VerifyTextOnPage("We didn't find anything.") && Helper.VerifyTextOnPage("Try a different keyword."))
                Assert.Fail("No email matches search.");
            //Verify Email Recency
            Hotmail.VerifyEmailReceivedSpan(15);
        }

        public static void AutoAcc_loginForLockTest(string Email, int typeofLogin, int typeofNavigation, string webURL, int searchEmailtype)
        {
            Hotmail.NavigateToWebmail(webURL);
            ControlToNewWindow();
            if (IsElementPresent(By.Id("otherTileText")))
            {
                ElementClick(Driver.FindElement(By.Id("otherTileText")));
            }
            switch (typeofLogin)
            {
                case 1:
                    Hotmail.AutomationAcc_SignIn(LegacyTestData.CommonCatchallUserName, LegacyTestData.CommonCatchallPassword);
                    break;
                case 2:
                    Hotmail.AutomationAcc_SignIn(LegacyTestData.CommonFrontendEmail, LegacyTestData.CommonAutomationPassword);
                    break;
            }
            ControlToNewWindow();
            switch (typeofNavigation)
            {
                case 0:
                    Hotmail.SearchEmailAndOpenLatestEmails(Email, searchEmailtype);
                    break;
                case 1:
                    Hotmail.OpenLatestEmailReceived();
                    break;
                default:
                    break;
            }
            //Verify an email exists
            if (Helper.VerifyTextOnPage("We didn't find anything.") && Helper.VerifyTextOnPage("Try a different keyword."))
                Assert.Fail("No email matches search.");
        }

    }
}
