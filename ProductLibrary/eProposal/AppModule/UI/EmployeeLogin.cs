using BaseUtility.Utility;
using eProposal.PageObject.UI;
using eProposal.Utility;
using BaseUtility.Utility.Hotmail;
using InfoMessageLogger;
using OpenQA.Selenium;
using NUnit.Framework;

namespace eProposal.AppModule.UI
{
    internal class EmployeeLogin : Helper
    {
        public static void Click_DefaultSubmitButton()
        {
            Helper.ElementClick(PageObject_EmployeeLogin.DefaultSubmitButton());
        }

        public static void Click_SubmitButton()
        {
            Helper.ElementClick(PageObject_EmployeeLogin.SubmitButton());
        }

        public static void Click_ForgotPasswordLink()
        {
            Helper.ElementClick(PageObject_EmployeeLogin.ForgotPasswordLink());
        }

        public static void Click_ForgotPasswordSubmitButton()
        {
            Helper.ElementClick(PageObject_EmployeeLogin.ForgotPasswordSubmitButton());
        }

        public static void Click_ForgotPasswordLoginLink()
        {
            Helper.ElementClick(PageObject_EmployeeLogin.ForgotPasswordLoginLink());
        }

        public static void EnterText_EmailText(string text)
        {
            Helper.ElementEnterText(PageObject_EmployeeLogin.EmailText(), text);
        }

        public static void EnterText_PasswordText(string text)
        {
            Helper.ElementEnterText(PageObject_EmployeeLogin.PasswordText(), text);
        }

        public static void EnterText_SSOLogin_Email(string text)
        {
            ElementEnterText(PageObject_EmployeeLogin.SSOLogin_Email(), text);
        }
        public static void EnterText_SSOLogin_Password(string text)
        {
            ElementEnterText(PageObject_EmployeeLogin.SSOLogin_Password(), text);
        }
        public static void Click_SSOLogin_Next()
        {
            ElementClick(PageObject_EmployeeLogin.SSOLogin_Next());
        }
        public static void CLick_SSOLogin_Submit()
        {
            ElementClick(PageObject_EmployeeLogin.SSOLogin_Submit());
        }
        public static void Enter_SSOLogin_VerificationCode(string code)
        {
            //ElementEnterText(PageObject_EmployeeLogin.SSOLogin_VerificationCode(), code);
            ElementEnterText(Driver.FindElement(By.Id("TwoFactorCode")), code);
        }
        public static void Click_SSOLogin_Login()
        {
            ElementClick(PageObject_EmployeeLogin.SSOLogin_Login());
        }

        public static void DemoLogIn(string email, string password)
        {
            string IFrame = "//iframe[@title='TrustArc Cookie Consent Manager']";
            if (IsElementPresent(By.XPath(IFrame)))
            {
                Driver.SwitchTo().Frame(Driver.FindElement(By.XPath(IFrame)));

                AddDelay(8000);
                if (IsElementPresent(By.XPath("//a[contains(text(),'Agree and Proceed')]")))
                {
                    ElementClick(PageObject_EmployeeLogin.Login_IFrame_AgreeProceed());
                    //if (IsElementPresent(By.XPath("//a[contains(text(),'Close')]")))
                    if (IsElementPresent(By.XPath("//a[contains(text(),'Close')]")))
                    {
                        ElementClick(PageObject_EmployeeLogin.Login_IFrame_AgreeProceed_Close());
                    }

                }
                Driver.SwitchTo().ParentFrame();
            }
            //EnterText_EmailText(email);
            ElementEnterText(Driver.FindElement(By.Id("txtUserID")), email);
            ElementClick(Driver.FindElement(By.XPath("//input[contains(@value, 'Next')]")));
            //Click_SSOLogin_Next();
            //EnterText_PasswordText(password);
            ElementEnterText(Driver.FindElement(By.Id("txtPassword")), password);
            //Click_SubmitButton();
            //CLick_SSOLogin_Submit();
            ElementClick(Driver.FindElement(By.XPath("//input[contains(@value, 'Login')]")));
            AddDelay(8000);
            if (VerifyTextOnPage("Verification code"))
            {
                ControlToPreviousWindow();
                CloseCurrentTab();
                AddDelay(30000);
                Hotmail.SearchEmailAndOpenLatestEmail(email, 1);
                Hotmail.OpenLatestEmail();
                AddDelay(10000);
                Helper.ScrollToElement(Driver.FindElement(By.XPath("//td[contains(@style, 'color:#24245A;')]")));

                string verificationCode = Driver.FindElement(By.XPath("//td[contains(@style, 'color:#24245A;')]")).Text;
                CloseCurrentTab();
                ControlToPreviousWindow();
                Enter_SSOLogin_VerificationCode(verificationCode);
                ElementClick(Driver.FindElement(By.XPath("//input[contains(@value, 'Login')]")));
            }
        }

        /// <summary>
        ///     This method will log the user into ePFull Employee Login with the entered email and password.
        /// </summary>
        /// <param name="email">Employee email</param>
        /// <param name="password">Employee password</param>
        public static void LogIn(string email, string password)
        {
            string IFrame = "//iframe[@title='TrustArc Cookie Consent Manager']";
            if (IsElementPresent(By.XPath(IFrame)))
            {
                Driver.SwitchTo().Frame(Driver.FindElement(By.XPath(IFrame)));

                AddDelay(8000);
                if (IsElementPresent(By.XPath("//a[contains(text(),'Agree and Proceed')]")))
                {
                    ElementClick(PageObject_EmployeeLogin.Login_IFrame_AgreeProceed());
                    //if (IsElementPresent(By.XPath("//a[contains(text(),'Close')]")))
                    if (IsElementPresent(By.XPath("//a[contains(text(),'Close')]")))
                    {
                        ElementClick(PageObject_EmployeeLogin.Login_IFrame_AgreeProceed_Close());
                    }

                }
                Driver.SwitchTo().ParentFrame();
            }
            //EnterText_EmailText(email);
            ElementEnterText(Driver.FindElement(By.Id("Email")), email);
            ElementClick(Driver.FindElement(By.XPath("//input[contains(@value, 'Next')]")));
            //Click_SSOLogin_Next();
            //EnterText_PasswordText(password);
            ElementEnterText(Driver.FindElement(By.Id("Password")), password);
            //Click_SubmitButton();
            //CLick_SSOLogin_Submit();
            ElementClick(Driver.FindElement(By.XPath("//input[contains(@value, 'Login')]")));
            AddDelay(8000);
            if(VerifyTextOnPage("Verification code"))
            {
                ControlToPreviousWindow();
                CloseCurrentTab();
                AddDelay(30000);
                Hotmail.SearchEmailAndOpenLatestEmail(email, 1);
                Hotmail.OpenLatestEmail();
                AddDelay(10000);
                Helper.ScrollToElement(Driver.FindElement(By.XPath("//td[contains(@style, 'color:#24245A;')]")));

                string verificationCode = Driver.FindElement(By.XPath("//td[contains(@style, 'color:#24245A;')]")).Text;
                CloseCurrentTab();
                ControlToPreviousWindow();
                Enter_SSOLogin_VerificationCode(verificationCode);
                ElementClick(Driver.FindElement(By.XPath("//input[contains(@value, 'Login')]")));
            }
        }
        public static void EnterVerificationCode(string email = null, string password = null)
        {
            Logger.WriteDebugMessage("Landed on Verification Code Page to verify credentials.");
            Driver.SwitchTo().DefaultContent();
            Driver.FindElement(By.CssSelector("body")).SendKeys(Keys.Control + "t");
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("window.open('http://www.google.com');");
            ControlToNewWindow();
            Login.AutoAcc_login("Verify your identity", 1, 0);
            AddDelay(10000);
            Helper.ScrollToElement(Driver.FindElement(By.XPath("//td[contains(@style, 'color:#24245A;')]")));

            string verificationCode = Driver.FindElement(By.XPath("//td[contains(@style, 'color:#24245A;')]")).Text;
            CloseCurrentTab();
            ControlToPreviousWindow();
            Enter_SSOLogin_VerificationCode(verificationCode);
            AddDelay(5000);
            if (IsElementVisible(Driver.FindElement(By.XPath("Product Nav Dropdown"))))
            {
                ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'proposal')]")));
            }
        }

        /// <summary>
        ///     This method will log the user into the ePFull Employee Login with the CommonEmployeeEmail and
        ///     CommonEmployeePassword data in the Common.xml
        /// </summary>
        public static void CommonLogin()
        {
            LogIn(LegacyTestData.CommonDemoEmail, LegacyTestData.CommonDemoPassword);
        }

        public static void CommonLogin_SSO()
        {
            string IFrame = "//iframe[@title='TrustArc Cookie Consent Manager']";
            if (IsElementPresent(By.XPath(IFrame)))
            {
                Driver.SwitchTo().Frame(Driver.FindElement(By.XPath(IFrame)));

                AddDelay(8000);
                if (IsElementPresent(By.XPath("//a[contains(text(),'Agree and Proceed')]")))
                {
                    ElementClick(PageObject_EmployeeLogin.Login_IFrame_AgreeProceed());
                    //if (IsElementPresent(By.XPath("//a[contains(text(),'Close')]")))
                    if (IsElementPresent(By.XPath("//a[contains(text(),'Close')]")))
                    {
                        ElementClick(PageObject_EmployeeLogin.Login_IFrame_AgreeProceed_Close());
                    }

                }
                Driver.SwitchTo().ParentFrame();
            }
            EnterText_SSOLogin_Email("qacendynautomation@cendyn17.com");
            Logger.WriteDebugMessage("Entered UserName");
            Click_SSOLogin_Next();
            EnterText_SSOLogin_Password("Cendyn123$");
            Logger.WriteDebugMessage("Clicked on Next button and entered password.");
            CLick_SSOLogin_Submit();
            Logger.WriteDebugMessage("Clicked on Subimt button.");
            if (VerifyTextOnPage("Verification code"))
            {
                Logger.WriteDebugMessage("Landed on Verification Code Page to verify credentials.");
                //OpenNewTab();
                ControlToPreviousWindow();
                //ControlToNewWindow();
                Login.AutoAcc_login("Verify your identity", 1, 0);
                AddDelay(10000);
                Helper.ScrollToElement(Driver.FindElement(By.XPath("//td[contains(@style, 'color:#24245A;')]")));

                string verificationCode = Driver.FindElement(By.XPath("//td[contains(@style, 'color:#24245A;')]")).Text;
                CloseCurrentTab();
                CloseCurrentTab();
                //ControlToPreviousWindow();
                Enter_SSOLogin_VerificationCode(verificationCode);
                ElementClick(Driver.FindElement(By.XPath("//input[@value='Login']")));
                AddDelay(5000);
                //if (IsElementVisible(Driver.FindElement(By.XPath("Product Nav Dropdown"))))
                //{
                //ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'proposal')]")));
                //}
                if (VerifyTextOnPage("Welcome to the Cendyn Hospitality Cloud"))
                {
                    ElementClick(Driver.FindElement(By.XPath("(//li[contains(@class, 'EPFULL')]/a[contains(@href, 'proposalaccess')])[2]")));
                    //AddDelay(10000);
                    //Driver.SwitchTo().Frame(Driver.FindElement(By.XPath(IFrame)));
                    //if (IsElementPresent(By.XPath("(//*[contains(text(),'Agree and Proceed')])[2]")))
                    //{
                    //    ElementClick(Driver.FindElement(By.XPath("/html/body/div[8]/div[1]/div/div[3]/a[1]")));
                    //    if (IsElementPresent(By.XPath("//a[contains(text(),'Close')]")))
                    //    {
                    //        ElementClick(Driver.FindElement(By.XPath("//a[contains(text(),'Close')]")));
                    //    }

                    //}
                    //Driver.SwitchTo().ParentFrame();
                }
            }
            else if (!VerifyTextOnPage("Verification code"))
            {
                if (VerifyTextOnPage("Welcome to the Cendyn Hospitality Cloud"))
                {
                    ElementClick(Driver.FindElement(By.XPath("(//li[contains(@class, 'EPFULL')]/a[contains(@href, 'proposalaccess')])[2]")));
                    AddDelay(10000);
                    try
                    {
                        if (Driver.FindElement(By.XPath(IFrame)).Displayed)
                        {
                            Driver.SwitchTo().Frame(Driver.FindElement(By.XPath(IFrame)));
                            if (IsElementPresent(By.XPath("(//*[contains(text(),'Agree and Proceed')])[2]")))
                            {
                                ElementClick(Driver.FindElement(By.XPath("/html/body/div[8]/div[1]/div/div[3]/a[1]")));
                                if (IsElementPresent(By.XPath("//a[contains(text(),'Close')]")))
                                {
                                    ElementClick(Driver.FindElement(By.XPath("//a[contains(text(),'Close')]")));
                                }

                            }
                            Driver.SwitchTo().ParentFrame();
                        }
                    }
                    catch
                    {
                        Logger.WriteDebugMessage("");
                    }
                    
                }
                else
                {
                    Assert.Fail("Did not land on Cendyn Meny Access.");
                }
            }
            
        }


        /// <summary>
        ///     This method will log the user into the ePFull Employee Login with the CommonDemomail and
        ///     CommonDemoPassword data in the Common.xml
        /// </summary>
        public static void CommonDemoLogin()
        {
            //Driver.SwitchTo().Frame(0);
            //if (IsElementPresent(By.XPath("//a[contains(text(),'Agree and Proceed')]")))
            //{
            //    ElementClick(Driver.FindElement(By.XPath("//a[contains(text(),'Agree and Proceed')]")));
            //    if (IsElementPresent(By.XPath("//a[contains(text(),'Close')]")))
            //    {
            //        ElementClick(Driver.FindElement(By.XPath("//a[contains(text(),'Close')]")));
            //    }

            //}
            LogIn(LegacyTestData.CommonDemoEmail, LegacyTestData.CommonDemoPassword);
        }
        public static void precatchallLogin()
        {
            Login.AutoAcc_login("", 2, 0);
            AddDelay(10000);
        }
    }
}