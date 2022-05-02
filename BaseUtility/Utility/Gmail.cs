using System;
using Common;
using OpenQA.Selenium;
using InfoMessageLogger;

namespace BaseUtility.Utility.Gmail
{
    public class Gmail : Helper
    {

        private static string commonEmail = "cendynautomationqa@gmail.com";
        private static string commonPassword = "Cendyn123$";


        private static void ClickShowContentButton()
        {
            try
            {
                if (
                    Driver.FindElement(By.XPath("//img[@class='ajT']"))
                        .Displayed)
                {

                    Driver.FindElement(By.XPath("//img[@class='ajT']"))
                        .Click();
                }
            }
            catch (Exception)
            {

            }
        
        }

        /// <summary>
        /// Returns the user to the Gmail inbox.
        /// </summary>
        public static void ReturnToInbox()
        {
            AddDelay(15000);
            try
            {
                Driver.FindElement(By.XPath("/html/body/div[7]/div[3]/div/div[1]/div[4]/div[1]/div[1]/div[2]/div/a/span"))
                    .Click();
                AddDelay(3000);
                Logger.WriteInfoMessage("Returned to the Inbox.");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("Unable to return to the inbox.");
                throw;
            }
        }

        /// <summary>
        /// Enters the email.
        /// </summary>
        /// <param name="email"></param>
        private static void EnterEmail(string email)
        {
            try
            {
                Driver.FindElement(By.XPath("//*[@id='identifierId']")).SendKeys(email);
                AddDelay(2500);
                Logger.WriteInfoMessage("Entered the email on the Gmail page.");
            }
            catch (Exception)
            {
                Logger.WriteWarnMessage("Unable to enter the Gmail email. Probably already logged into Gmail.");
                throw;
            }
        }

        /// <summary>
        /// Clicks the Next button.
        /// </summary>
        private static void ClickNext()
        {
            try
            {
                AddDelay(2500);
                Driver.FindElement(By.XPath("//span[contains(.,'Next')]")).Click();
                AddDelay(2000);
                Logger.WriteInfoMessage("Clicked Next on the Gmail page.");
            }
            catch (Exception)
            {
                Logger.WriteWarnMessage("Already logged into Gmail.");
                throw;
            }
        }

        /// <summary>
        /// Enters the password.
        /// </summary>
        /// <param name="password"></param>
        private static void EnterPassword(string password)
        {
            try
            {
                Driver.FindElement(By.XPath("//*[@id='password']/div[1]/div/div[1]/input")).SendKeys(password);
                AddDelay(2500);
                Logger.WriteInfoMessage("Entered the Password on the Gmail page.");
            }
            catch (Exception)
            {
                Logger.WriteWarnMessage("Unable to enter the Gmail password. Probably already logged into Gmail.");
                throw;
            }
        }

        /// <summary>
        /// Clicks the Sign In button.
        /// </summary>
        private static void ClickSignIn()
        {
            try
            {
                Driver.FindElement(By.Id("signIn")).Click();
                AddDelay(3500);
                Logger.WriteInfoMessage("Clicked Sign In on the Gmail page.");
            }
            catch (Exception)
            {
                Logger.WriteWarnMessage("Unable to click the Sign In button. Probably already logged into Gmail.");
                throw;
            }
        }

        /// <summary>
        /// This will enter the email and password and click the appropiate buttons to log into GMail.
        /// </summary>
        /// <param name="email">Gmail email</param>
        /// <param name="password">Gmail password</param>
        public static void LogIn(string email, string password)
        {
            try
            {
                EnterEmail(email);
                ClickNext();
                EnterPassword(password);
                ClickNext();
            }
            catch (Exception)
            {
                Logger.WriteWarnMessage("Already logged into Gmail.");
            }
        }

        /// <summary>
        /// This will log into gmail using the common email.
        /// cendynautomationqa@gmail.com
        /// </summary>
        /// <param name="email">Gmail email</param>
        /// <param name="password">Gmail password</param>
        public static void LogIn()
        {
            try
            {
                EnterEmail(commonEmail);
                ClickNext();
                EnterPassword(commonPassword);
                ClickNext();
            }
            catch (Exception)
            {
                Logger.WriteWarnMessage("Already logged into Gmail.");
            }
        }

        /// <summary>
        /// This will open the first email message.
        /// Email must have the filters turned off
        /// </summary>
        public static void OpenFirstEmail()
        {
            AddDelay(10000);
            try
            {
                Driver.FindElement(
                    By.XPath(
                        "/html/body/div[7]/div[3]/div/div[2]/div[1]/div[2]/div/div/div/div/div[2]/div[1]/div[1]/div/div/div[3]/div[1]/div/table/tbody/tr[1]/td[6]"))
                    .Click();
                AddDelay(1500);
                Logger.WriteInfoMessage("Opened the first email on the Gmail page.");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("Unable to select the first email message.");
                throw;
            }
        }

        /// <summary>
        /// Clicks a link on the email with the entered text and opens in a new window. 
        /// </summary>
        /// <param name="text">Link text to click</param>
        public static void GmailClickLinkByText(string text)
        {
            AddDelay(5000);
            try
            {
                ClickShowContentButton();
                OpenPopUpWindow(Driver.FindElement(By.PartialLinkText(text)));
                AddDelay(7500);
                Logger.WriteInfoMessage("Clicked the link on the email by text on the Gmail page.");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("Unable to locate the text to click on the email.");
                throw;
            }
        }

        /// <summary>
        /// Clicks a link on the email with the entered text and opens in a new window. 
        /// </summary>
        /// <param name="element">Element text to click</param>
        public static void GmailClickLinkByElement(IWebElement element)
        {
            AddDelay(5000);
            try
            {
                //ClickShowContentButton();
                OpenPopUpWindow(element);
                AddDelay(7500);
                Logger.WriteInfoMessage("Clicked the link on the email by text on the Gmail page.");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("Unable to locate the text to click on the email.");
                throw;
            }
        }

        /// <summary>
        /// Closes the email popup and returns to Gmail.
        /// </summary>
        public static void CloseEmailPopup()
        {
            AddDelay(5000);
            ClosePopUpWindow();
            AddDelay(2500);
        }

        /// <summary>
        /// Checks the email for a certain text
        /// </summary>
        /// <param name="text">Text to search for on the email.</param>
        public static void SearchEmailForText(string text)
        {
            AddDelay(5000);
            try
            {
                if (VerifyTextOnPage(text))
                    Logger.WriteInfoMessage("Found the email text.");
                
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("Did not find the email text.");
                throw;
            }
        }

        public static void NavigateToGmail()
        {
            AddDelay(10000);
            Driver.Navigate().GoToUrl("https://www.gmail.com");
            AddDelay(1500);
        }

        /// <summary>
        /// This method will navigate and log into Gmail
        /// </summary>
        public static void NavigateAndLogIntoGmail(string email, string password)
        {
            NavigateToGmail();
            LogIn(email, password);
        }

        /// <summary>
        /// This method will navigate and log into Gmail
        /// </summary>
        public static void NavigateAndLogIntoGmail()
        {
            NavigateToGmail();
            LogIn(commonEmail, commonPassword);
        }

        public static void LogOut()
        {
            Driver.FindElement(By.XPath("//span[@class='gb_bb gbii']")).Click();
            AddDelay(1000);
            Driver.FindElement(By.XPath("//a[contains(.,'Sign out')]")).Click();
            AddDelay(1500);
        }

        /// <summary>
        /// This method will navigate to the "Use another account" page from the Log In page.
        /// </summary>
        public static void SelectAnotherAccount()
        {
            Driver.Quit();
            TestHandling.BrowserSetup();

            //Click the Gmail user drop down
            Driver.FindElement(By.XPath("//path[@d='M7.41 7.84L12 12.42l4.59-4.58L18 9.25l-6 6-6-6z']")).Click();
            AddDelay(1500);

            //Click "Use another account"
            Driver.FindElement(By.XPath("//p[contains(.,'Use another account')]")).Click();
            AddDelay(1500);

        }
    }
}
