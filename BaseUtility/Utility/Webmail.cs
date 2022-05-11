using Common;
using InfoMessageLogger;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace BaseUtility.Utility
{
    public class Webmail : Helper
    {
        /// <summary>
        /// Clicks the Sign In button.
        /// </summary>
        public static void ClickGoBackToOldOne()
        {
            try
            {
                Driver.FindElement(By.Id("uxOptOutLink")).Click();
                AddDelay(3500);
                Logger.WriteInfoMessage("Clicked GoBackToOldOne on the Webmail page.");
            }
            catch (Exception)
            {
                Logger.WriteWarnMessage("Unable to click the Sign In button. Probably already logged into Webmail.");
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
                Driver.FindElement(By.XPath("//input[@type='email']")).SendKeys(email);
                AddDelay(2500);
                Logger.WriteInfoMessage("Entered the email on the Webmail page.");
            }
            catch (Exception)
            {
                Logger.WriteWarnMessage("Unable to enter the Webmail email. Probably already logged into Webmail.");
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
                Driver.FindElement(By.XPath("//input[@type='password']")).SendKeys(password);
                AddDelay(2500);
                Logger.WriteInfoMessage("Entered the Password on the Webmail page.");
            }
            catch (Exception)
            {
                Logger.WriteWarnMessage("Unable to enter the Webmail password. Probably already logged into Webmail.");
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
                Driver.FindElement(By.XPath("//input[@type='submit']")).Click();
                AddDelay(3500);
                Logger.WriteInfoMessage("Clicked Sign In on the Webmail page.");
            }
            catch (Exception)
            {
                Logger.WriteWarnMessage("Unable to click the Sign In button. Probably already logged into Webmail.");
                throw;
            }
        }


        /// <summary>
        /// Clicks the Mail button.
        /// </summary>
        public static void ClickMail()
        {
            try
            {
                Driver.FindElement(By.XPath("//*[@id='ShellMail_link']/div")).Click();
                AddDelay(3500);
                Logger.WriteInfoMessage("Clicked Sign In on the Webmail page.");
            }
            catch (Exception)
            {
                Logger.WriteWarnMessage("Unable to click the Sign In button. Probably already logged into Webmail.");
                throw;
            }
        }

        /// <summary>
        /// Enters the mail title in Searchfield
        /// </summary>
        /// <param name="title"></param>
        public static void EnterSearchText(string title)
        {
            try
            {
                AddDelay(180000);
                Actions action = new Actions(Helper.Driver);
                Driver.FindElement(By.XPath("//*[@id='primaryContainer']/div[4]/div/div[1]/div/div[1]/div[1]/div/div/div[1]/div[1]/div[1]/div[2]/div[2]/button")).Click();
                AddDelay(5000);
                ElementClearText(Driver.FindElement(By.XPath("//*[@id='primaryContainer']/div[4]/div/div[1]/div/div[1]/div[1]/div/div/div[1]/div[1]/div[1]/div[2]/div[2]/div/div[1]/div/form/div/input")));
                AddDelay(5000);
                Driver.FindElement(By.XPath("//*[@id='primaryContainer']/div[4]/div/div[1]/div/div[1]/div[1]/div/div/div[1]/div[1]/div[1]/div[2]/div[2]/div/div[1]/div/form/div/input")).SendKeys(title);
                AddDelay(5000);
                action.SendKeys(Keys.Enter).Build().Perform();
                AddDelay(2500);
                Logger.WriteInfoMessage("Entered the Password on the Webmail page.");
            }
            catch (Exception)
            {
                Logger.WriteWarnMessage("Unable to enter the Webmail password. Probably already logged into Webmail.");
                throw;
            }
        }

        /// <summary>
        /// This will open the first email message.
        /// Email must have the filters turned off
        /// </summary>
        public static void OpenFirstMessage()
        {
            AddDelay(10000);
            try
            {
                Driver.FindElement(By.XPath("html/body/div[2]/div/div[4]/div[4]/div/div[1]/div/div[4]/div[3]/div/div[2]/div/div/div/div[5]/div[3]/div[1]/div[3]/div[1]/div/div/div[2]/div[2]/div[2]")).Click();
                //DoubleClickElement("html/body/div[2]/div/div[3]/div[5]/div/div[1]/div/div[4]/div[3]/div/div[2]/div/div/div/div[5]/div[3]/div[1]/div[3]/div[1]/div/div/div[2]/div[2]/div[2]");
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
        /// This will enter the email and password and click the appropiate buttons to log into Webmail.
        /// </summary>
        /// <param name="email">email</param>
        /// <param name="password">password</param>
        public static void LogIn(string email, string password)
        {
            try
            {
                //if(Helper.Driver.FindElement(By.Id("cred_userid_inputtext")).Displayed)
                //{
                //    goto email;
                //}
                //else
                //{
                //    ClickGoBackToOldOne();
                //}              
                //email:
                EnterEmail(email);
                ClickSignIn();
                EnterPassword(password);
                ClickSignIn();
                ClickSignIn();
            }
            catch (Exception)
            {
                Logger.WriteWarnMessage("Already logged into Webmail.");
            }
        }

        /// <summary>
        /// Method to navigate to Webmail
        /// </summary>
        public static void NavigateToWebmail()
        {
            AddDelay(10000);
            Driver.Navigate().GoToUrl("https://outlook.office.com/");
            AddDelay(1500);
        }

        /// <summary>
        /// Clicks a link on the email with the entered text and opens in a new window. 
        /// </summary>
        /// <param name="text">Link text to click</param>
        public static void ClickLinkByText(string text)
        {
            AddDelay(5000);
            try
            {               
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
    }
}
