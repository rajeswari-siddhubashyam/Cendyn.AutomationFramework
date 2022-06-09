using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Common;
using InfoMessageLogger;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace BaseUtility.Utility.Hotmail
{
    public class Hotmail : Helper
    {
        private static string SignIn_Email = "//input[@type='email']";
        public static string SignIn_Button = "//input[@type='submit']";
        private static string SignIn_Password = "//input[@name='passwd']";
        private static string SignIn_DontShowAgainCheckBox = "//input[@name='DontShowAgain']";
        private static string SignIn_YesButton = "//input[@value='Yes']";
        //private static string SearchIcon = "//button[@aria-label='Activate Search Textbox']";
        private static string SearchIcon = "//i[@data-icon-name='Search']";
        //private static string SearchBox = "//input[contains(@role,'combobox')]";
        private static string SearchBox = "//input[@aria-label='Search']";
        //private static string Search = "//span[contains(@class,'_n_m owaimg ms-Icon--search ms-icon-font-size-20 ms-fcl-ts-b')]";
        private static string Search = "//span[contains(@class,'_fc_3 owaimg ms-Icon--search ms-icon-font-size-20 ms-fcl-ts-b')]";
        //private static string OutLookIcon = "ShellMail_link_text";
        private static string OutLookIcon = "//div[@class='___thwl1f0 f1022m68'][4]";
        private static string FirstMessage = "//div[@role='heading'][@tabindex='-1']/following-sibling::div[@data-convid][1]";
        //private static string OutLookIconXPath = "//*[@id='ShellMail_link']";//"//a[@id='app-gallery-ShellMail-workspace-0-all']"
        private static string OutLookIconXPath = "//button[@aria-label='Go to your Outlook']";
        private static string OutlookAllAppsIcon = "//i[@data-icon-name='allAppsLogo']";
        //private static string FirstMessageAlt = "/html/body/div[2]/div/div[3]/div[5]/div/div[1]/div/div[4]/div[3]/div/div[2]/div/div/div/div[5]/div[4]/div[1]/div[3]/div[1]/div/div/div[2]/div[2]/div[2]/div[4]/div[3]/div/span";
        private static string FirstMessageAlt = "div[@role='heading'][@tabindex='-1']/following-sibling::div[@data-convid][1]";
        private static string ReceivedTimestamp = "//div[@id='ReadingPaneContainerId']/descendant::div[contains(text(),'AM') or contains(text(),'PM')][last()]";
        
        /// <summary>
        /// This method will navigate and log into the Catchall account, search by the email provided and open the latest email.
        /// </summary>
        public static void LogIntoCatchAllAndOpenFirstMessageByEmail(string email, string url)
        {
            NavigateAndLogIntoCatchAll(url);
            SearchEmail(email);
            OpenLatestEmail();
        }

        public static void ClickOutLook()
        {
            ElementClick(Driver.FindElement(By.XPath(OutLookIcon)));
        }

        public static void NavigateToWebmail(string URL)
        {
            Driver.Navigate().GoToUrl(URL);
        }
        public static void HandleUnSafeWindows()
        {
            string catchalladvancebutton = "//*[@id='details-button']";
            string catchallproceedbutton = "//*[@id='proceed-link']";
            try
            {
                if (Driver.FindElement(By.XPath(catchalladvancebutton)).Displayed)
                {
                    Driver.FindElement(By.XPath(catchalladvancebutton)).Click();
                    Driver.FindElement(By.XPath(catchallproceedbutton)).Click();
                }

            }
            catch (Exception)
            {
                Logger.WriteDebugMessage("Landed on SignIn Page");
            }

        }
        public static void SignIn()
        {
            ElementEnterText(Driver.FindElement(By.XPath(SignIn_Email)), Constants.CatchAllEmail);
            ElementClick(Driver.FindElement(By.XPath(SignIn_Button)));
            AddDelay(5000);
            ElementEnterText(Driver.FindElement(By.XPath(SignIn_Password)), Constants.CatchAllPassword);
            Logger.WriteDebugMessage("Entered Catchall UserName and Password");
            ElementClick(Driver.FindElement(By.XPath(SignIn_Button)));

            try
            {
                if (IsElementVisible(Driver.FindElement(By.XPath(SignIn_DontShowAgainCheckBox))))
                {
                    MakeSureIsChecked(Driver.FindElement(By.XPath(SignIn_DontShowAgainCheckBox)));
                }
                if (IsElementVisible(Driver.FindElement(By.XPath(SignIn_YesButton))))
                {
                    ElementClick(Driver.FindElement(By.XPath(SignIn_YesButton)));
                }
            }
            catch (Exception)
            {
            }

            //Navigate to the mailbox
            //Had to use the URL since the landing page randomly changes.
            Driver.Navigate().GoToUrl("https://outlook.office365.com/owa/?realm=cendyn17.com&exsvurl=1&ll-cc=1033&modurl=0");
        }

        public static void CendynAutomationUserSignIn()
        {
            ElementEnterText(Driver.FindElement(By.XPath(SignIn_Email)), "cendynautomation@cendyn.com");
            ElementClick(Driver.FindElement(By.XPath(SignIn_Button)));
            AddDelay(5000);
            ElementEnterText(Driver.FindElement(By.XPath(SignIn_Password)), "DevAuto.12346$");
            Logger.WriteDebugMessage("Entered Catchall UserName and Password");
            ElementClick(Driver.FindElement(By.XPath(SignIn_Button)));

            try
            {
                if (IsElementVisible(Driver.FindElement(By.XPath(SignIn_DontShowAgainCheckBox))))
                {
                    MakeSureIsChecked(Driver.FindElement(By.XPath(SignIn_DontShowAgainCheckBox)));
                }
                if (IsElementVisible(Driver.FindElement(By.XPath(SignIn_YesButton))))
                {
                    ElementClick(Driver.FindElement(By.XPath(SignIn_YesButton)));
                }
            }
            catch (Exception)
            {
            }

            //Navigate to the mailbox
            //Had to use the URL since the landing page randomly changes.
            Driver.Navigate().GoToUrl("https://outlook.office365.com/owa/?realm=cendyn17.com&exsvurl=1&ll-cc=1033&modurl=0");
        }

        public static void AutomationWebmailAcc(string Email, string Password, string SearchString)
        {
            AutomationAcc_SignIn(Email, Password);
            SearchEmailAndOpenLatestEmail(SearchString, 0);
        }

        public static void AutomationAcc_SignIn(string Email, string Password)
        {
            AddDelay(10000);
            ElementEnterText(Driver.FindElement(By.XPath(SignIn_Email)), Email);
            ElementClick(Driver.FindElement(By.XPath(SignIn_Button)));
            AddDelay(25000);
            ElementEnterText(Driver.FindElement(By.XPath(SignIn_Password)), Password);
            Logger.WriteDebugMessage("Entered Catchall UserName and Password");
            ElementClick(Driver.FindElement(By.XPath(SignIn_Button)));

            try
            {
                if (IsElementVisible(Driver.FindElement(By.XPath(SignIn_DontShowAgainCheckBox))))
                {
                    MakeSureIsChecked(Driver.FindElement(By.XPath(SignIn_DontShowAgainCheckBox)));
                }
                if (IsElementVisible(Driver.FindElement(By.XPath(SignIn_YesButton))))
                {
                    ElementClick(Driver.FindElement(By.XPath(SignIn_YesButton)));
                }
            }
            catch (Exception)
            {
            }

            //Navigate to the mailbox
            //Had to use the URL since the landing page randomly changes.
            //PageLoadWait(60, "https://www.office.com/?auth=2");
            try
            {
                AddDelay(10000);
                Helper.Driver.FindElement(By.Id("idSubmit_ProofUp_Redirect")).Submit();
                Helper.Driver.FindElement(By.Id("CancelLinkButton")).Click();
                AddDelay(10000);
                if (IsElementVisible(Driver.FindElement(By.XPath(SignIn_DontShowAgainCheckBox))))
                {
                    MakeSureIsChecked(Driver.FindElement(By.XPath(SignIn_DontShowAgainCheckBox)));
                }
                if (IsElementVisible(Driver.FindElement(By.XPath(SignIn_YesButton))))
                {
                    ElementClick(Driver.FindElement(By.XPath(SignIn_YesButton)));
                }
            }
            catch (Exception) { }
            
            ElementWait(Driver.FindElement(By.XPath(OutLookIconXPath)), 180);
            //ElementClick(Driver.FindElement(By.XPath(OutlookAllAppsIcon)));
            //AddDelay(5000);
            ElementClick(Driver.FindElement(By.XPath(OutLookIconXPath)));
            ControlToNewWindow();
            try
            {
                AddDelay(10000);
                Helper.Driver.FindElement(By.Id("idSubmit_ProofUp_Redirect")).Submit();
                Helper.Driver.FindElement(By.Id("CancelLinkButton")).Click();
                AddDelay(10000);
                if (IsElementVisible(Driver.FindElement(By.XPath(SignIn_DontShowAgainCheckBox))))
                {
                    MakeSureIsChecked(Driver.FindElement(By.XPath(SignIn_DontShowAgainCheckBox)));
                }
                if (IsElementVisible(Driver.FindElement(By.XPath(SignIn_YesButton))))
                {
                    ElementClick(Driver.FindElement(By.XPath(SignIn_YesButton)));
                }
            }
            catch (Exception) { }
        }

        public static void GetWebmailAccount()
        {
            ElementEnterText(Driver.FindElement(By.XPath(SignIn_Email)), "CendynAutomation@cendyn.com");
            ElementClick(Driver.FindElement(By.XPath(SignIn_Button)));
            AddDelay(1000);
            ElementEnterText(Driver.FindElement(By.XPath(SignIn_Password)), "JayS1234$");
            Logger.WriteDebugMessage("Entered Catchall UserName and Password");
            ElementClick(Driver.FindElement(By.XPath(SignIn_Button)));

            try
            {
                MakeSureIsChecked(Driver.FindElement(By.XPath(SignIn_DontShowAgainCheckBox)));
                ElementClick(Driver.FindElement(By.XPath(SignIn_YesButton)));
            }
            catch (Exception)
            {
            }

            //Navigate to the mailbox
            //Had to use the URL since the landing page randomly changes.
            Driver.Navigate().GoToUrl("https://outlook.office365.com/owa/?realm=cendyn17.com&exsvurl=1&ll-cc=1033&modurl=0");
        }

        /// <summary>
        /// This method will navigate to Cendyn Webmail and log into the CatchAll account
        /// </summary>
        public static void NavigateAndLogIntoCatchAll(string url)
        {
            NavigateToWebmail(url);
            HandleUnSafeWindows();
            SignIn();
        }

        //public static void NavigateAndLogIntoCendynAutomationUser(string url)
        //{
        //    NavigateToWebmail(url);
        //    HandleUnSafeWindows();
        //    CendynAutomationUserSignIn();
        //    SearchEmailAndOpenLatestEmail("Your Audience Customer Details File Export for Audience");
        //}

        /// <summary>
        /// This method will use the search filter
        /// </summary>
        public static void SearchEmail(string search)
        {
            try
            {
                IWebElement SearchElement = Driver.FindElement(By.XPath(SearchIcon));
                IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
                js.ExecuteScript("arguments[0].click();", SearchElement);
                //ElementClick(Driver.FindElement(By.XPath(SearchIcon)));
                ElementEnterText(Driver.FindElement(By.XPath(SearchBox)), search);
                AddDelay(5000);
                Driver.FindElement(By.XPath(SearchBox)).SendKeys(Keys.Enter);
                AddDelay(5000);
            }
            catch (Exception e)
            {
                Assert.Fail("" + e);
            }
        }

        /// <summary>
        /// This method will use the advanced search filter for subject
        /// </summary>
        public static void SearchEmailBySubject(string subject)
        {
            try
            {
                IWebElement SearchElement = Driver.FindElement(By.XPath(SearchIcon));
                IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
                js.ExecuteScript("arguments[0].click();", SearchElement);
                //ElementClick(Driver.FindElement(By.Id(SearchIcon)));
                ElementClick(Driver.FindElement(By.Id("filtersButtonId")));
                ElementClick(Driver.FindElement(By.Id("Subject-ID")));
                ElementEnterText(Driver.FindElement(By.Id("Subject-ID")), subject);
                AddDelay(5000);
                Driver.FindElement(By.XPath(SearchBox)).SendKeys(Keys.Enter);
                try
                {
                    ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'Search')]")));
                }
                catch (Exception){           
                }
                AddDelay(5000);
            }
            catch (Exception e)
            {
                Assert.Fail("" + e);
            }
        }

        /// <summary>
        /// This will open the first email message.
        /// Email must have the filters turned off
        /// </summary>
        public static void OpenLatestEmail()
        {
            try
            {
                //IWebElement element = Driver.FindElement(By.CssSelector("._lvv_11"));
                //((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].removeAttribute('style')", element);
                //AddDelay(2500);
                //ElementClick(Driver.FindElement(By.XPath("//div[@role='heading'][@tabindex='-1']/following-sibling::div[@data-convid][1]")));                
                //ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][1]")));
                try
                {
                    Helper.Driver.FindElement(By.XPath("//div[@role='button']/child::div[contains(.,'Filter')]")).Click();
                    Helper.AddDelay(15000);
                    Helper.Driver.FindElement(By.XPath("//ul[@role='presentation']/descendant::button[@name='Unread']")).Click();
                    Helper.AddDelay(15000);
                }
                catch (Exception) { }
                if (IsElementPresent(By.XPath("//div[contains(text(), 'All results')]/following::div[@data-convid][1]")))
                {
                    ElementClick(Driver.FindElement(By.XPath("//div[contains(text(), 'All results')]/following::div[@data-convid][1]")));
                }
                else if (IsElementPresent(By.XPath("//div[contains(text(), 'results')]/following::div[@data-convid][1]")))
                {
                    ElementClick(Driver.FindElement(By.XPath("//div[contains(text(), 'results')]/following::div[@data-convid][1]")));
                }
                else if (IsElementPresent(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][1]")))
                {
                    ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][1]")));
                }
                else if (IsElementPresent(By.XPath("//div[@role='region'][@tabindex='-1']/following::div[@data-convid][1]")))
                {
                    ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']/following::div[@data-convid][1]")));
                }
                else if (IsElementPresent(By.XPath("//div[@role='region']//div[@data-convid][1]")))
                {
                    ElementClick(Driver.FindElement(By.XPath("//div[@role='region']//div[@data-convid][1]")));
                }
                if (IsElementPresent(By.XPath("//a[contains(text(), 'Show blocked content')]")))
                {
                    ElementClick(Driver.FindElement(By.XPath("//a[contains(text(), 'Show blocked content')]")));
                }

            }
            catch (Exception ex)
            {
                //ElementClick(Driver.FindElement(By.XPath("//div[@role='heading'][@tabindex='-1']/following-sibling::div[@data-convid][1]")));
                Logger.WriteDebugMessage("Failed due to below error" + ex.Message);
            }
        }

        /// <summary>
        /// Method to turn on the old outlook view
        /// </summary>
        private static void CheckOutLook()
        {
            try
            {
                string url = Driver.Url;
                if (url.Contains("owa"))
                {
                    TryNewOutLook();
                    Logger.WriteInfoMessage("User redirected to new outlook view");
                }
                else
                {
                    Logger.WriteInfoMessage("User redirected to new outlook view");
                }
            }
            catch (Exception)
            {
                Logger.WriteInfoMessage("User redirected to new outlook view");

            }
        }

        /// <summary>
        /// Method to turn on the new outlook view
        /// </summary>
        private static void TryNewOutLook()
        {
            ElementClick(Driver.FindElement(By.XPath("//*[@id='primaryContainer']/div[4]/div/div[1]/div/div[4]/div[1]/div/div[1]/div/div/div[1]/div/button/span[1]")));
        }


        public static void SearchEmailAndOpenLatestEmail(string value, int searchType)
        {
            switch (searchType)
            {
                /* Default by value*/
                case 0:
                    AddDelay(2500);
                    CheckOutLook();
                    SearchEmail(value);
                    OpenLatestEmail();
                    Logger.WriteDebugMessage("Opened Latest Email with Search Value Contains - " + value);
                    break;
                /*By Subject*/
                case 1:
                    AddDelay(2500);
                    //CheckOutLook();
                    //SearchEmailBySubject(value);
                    //OpenLatestEmail();
                    //Logger.WriteDebugMessage("Opened Latest Email.");
                    //Helper.ScrollToElement(Driver.FindElement(By.XPath("//*[@id='app']/div/div[2]/div[1]/div/div/div/div[1]/div[2]/div/div[1]/div/div[2]/div[11]/div/span[1]")));
                    Helper.ElementClick(Driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[2]/div/div/div/div[1]/div[2]/div/div/div/div[2]/div[11]/div/span[1]")));
                    Helper.ReloadPage();
                    OpenLatestEmail();
                    Logger.WriteDebugMessage("Opened Latest Email with SubjectName Contains - " + value);
                    break;
                    
            }

        }

        public static void OpenLatestEmailReceived()
        {
            AddDelay(2500);
            CheckOutLook();
            OpenLatestEmail();
            Logger.WriteDebugMessage("Opened Latest Email.");
        }

        public static void Clear_SearchBox()
        {
            Actions action = new Actions(Driver);
            ElementClearText(Driver.FindElement(By.XPath(SearchIcon)));
            action.SendKeys(Keys.Tab).Build().Perform();
        }

        public static void OutlookSignOut()
        {
            AddDelay(15000);
            IJavaScriptExecutor jsscript = (IJavaScriptExecutor)Driver;
            IWebElement SearchElement = Driver.FindElement(By.Id("meInitialsButton"));
            jsscript.ExecuteScript("arguments[0].click();", SearchElement);
            AddDelay(25000);
            ElementClick(Driver.FindElement(By.Id("mectrl_body_signOut")));
            AddDelay(10000);
        }

        public static void VerifyEmailReceivedSpan(int maxMinutes)
        {
            Logger.WriteInfoMessage("Begin verification of that email was received within the last " + maxMinutes + " minutes.");
            

            //Get email received date in EST and converting to UCT
            DateTime emailReceivedEST = DateTime.Parse(Driver.FindElement(By.XPath(ReceivedTimestamp)).Text);
            TimeZoneInfo EST = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            DateTime emailReceivedUCT = TimeZoneInfo.ConvertTimeToUtc(emailReceivedEST, EST);

            //Gets current user/server date and timezone info and converts to UCT
            DateTime nowLocal = new DateTime(DateTime.Now.Ticks, DateTimeKind.Unspecified);
            TimeZoneInfo localTimeZone = TimeZoneInfo.FindSystemTimeZoneById(TimeZone.CurrentTimeZone.StandardName);
            DateTime nowUTC = TimeZoneInfo.ConvertTimeToUtc(nowLocal, localTimeZone);
          
            //Verify difference is within specified amount of time
            if ((nowUTC - emailReceivedUCT).TotalMinutes > maxMinutes)
            {
                Assert.Fail("The email received was over " + maxMinutes + " minutes old.");
            }
            else
            {
                Logger.WriteDebugMessage("The email was received within the last " + maxMinutes + " minutes.");
            }


        }

        public static void SearchEmailAndOpenLatestEmails(string value, int searchType)
        {
            switch (searchType)
            {
                /* Default by value*/
                case 0:
                    AddDelay(2500);
                    CheckOutLook();
                    SearchEmail(value);
                    OpenLatestEmail();
                    Logger.WriteDebugMessage("Opened Latest Email with Search Value Contains - " + value);
                    break;
                /*By Subject*/
                case 1:
                    AddDelay(2500);
                    CheckOutLook();
                    SearchEmailBySubject(value);
                    OpenLatestEmail();
                    Logger.WriteDebugMessage("Opened Latest Email.");
                    break;

            }

        }

    }
}
