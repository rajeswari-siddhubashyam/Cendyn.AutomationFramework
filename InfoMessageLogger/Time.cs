using Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Diagnostics.Contracts;
using System.Threading;

namespace InfoMessageLogger
{
    public class Time : CommonMethod
    {
        /// <summary>
        /// Method to Add TimeStamp
        /// </summary>
        public static string GetTimestamp()
        {
            return DateTime.Now.ToString("MMM-dd-yyyy HH-mm-ss-tt");
        }

        /// <summary>
        /// Method to chech whether element is Clickable or not.
        /// </summary>
        /// <param name="element">element to be checked</param>
        /// <param name="time">Time until which it have to check</param>
        /// <returns></returns>
        public static IWebElement ElementWait(IWebElement element, int time)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(time));
#pragma warning disable CS0618 // Type or member is obsolete
            return wait.Until(ExpectedConditions.ElementToBeClickable(element));
#pragma warning restore CS0618 // Type or member is obsolete
        }

        public static bool PageLoadWait(int time, string Url)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(time));
            //bool GetURL = Driver.Url.Contains(urlcontains);
#pragma warning disable CS0618 // Type or member is obsolete
            return wait.Until(ExpectedConditions.UrlContains(Url));
#pragma warning restore CS0618 // Type or member is obsolete
        }

        /// <summary>
        /// Method for displaying the test case ID on the log file.
        /// </summary>
        /// <param name="testCase"></param>
        public static void TestCaseLog(string testCase)
        {
            //Header before starting the test on the log file
            Logger.WriteInfoMessage("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Logger.WriteInfoMessage("XXXXXXXXXXXXXXXXX      " + "S.T.A.R.T." + "     XXXXXXXXXXXXXXXX");
            Logger.WriteInfoMessage("XXXXXXXXXXXXXXXXX      " + testCase + "         XXXXXXXXXXXXXXXX");
            Logger.WriteInfoMessage("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }

        /// <summary>
        /// Method for Wait.
        /// </summary>
        /// <param name="time">Wait time</param>
        public static void AddDelay(int time)
        {
            Thread.Sleep(time);
        }

        /// <summary>
        ///  Recursive method for wait till element is visible
        /// </summary>
        /// <param name="data">element for which the visibility have to be checked</param>
        public static void WaittillElementDisplay(IWebElement data)
        {
            while (true)
            {
                bool visible = IsElementVisible(data);
                if (visible)
                {
                    {
                        data.Click();
                    }
                }
                else
                {
                    ElementWait(data, 2000);
                    continue;
                }
                break;
            }
        }

        /// <summary>
        /// Method to check if the element is Displayed
        /// </summary>
        /// <param name="element"></param>
        public static bool IsElementVisible(IWebElement element)
        {
            return element.Displayed;
        }

        public static bool Exists(IWebElement element)
        {
            return element == null ? false : element.Displayed;
        }

        /// <summary>
        ///  Method for ScrollToElement using Javascript.
        /// </summary>
        ///  ///
        /// <param name="driver"></param>
        /// <param name="lenght">Length till which we need to scroll</param>
        public static void ScrollDownUsingJavaScript(IWebDriver driver, int lenght)
        {
            if (driver == null) throw new ArgumentNullException("driver");
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0," + lenght + ")");
        }

        /// <summary>
        ///  Method for ScrollToElement in upward direction using Javascript.
        /// </summary>
        ///  ///
        /// <param name="driver"></param>
        /// <param name="lenght">Length till which we need to scroll</param>
        public static void ScrollUpUsingJavaScript(IWebDriver driver, int lenght)
        {
            if (driver == null) throw new ArgumentNullException("driver");
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(" + lenght + ",0)");
        }

        /// <summary>
        ///  Method to Add time to user input custom time field
        /// </summary>
        public static void CustomTimeField(IWebElement element, int hours, int minutes, string timeUnit, bool checkCall)
        {
            Actions action = new Actions(Driver);
            action.SendKeys(Keys.Tab);
            action.MoveToElement(element);
            AddDelay(500);
            action.Click();
            if (checkCall.Equals(true))
            {
                for (int i = 0; i < 7; i++)
                {
                    action.SendKeys(Keys.ArrowRight);
                }
            }
            for (int i = 0; i < 6; i++)
            {
                action.SendKeys(Keys.Backspace);
            }
            for (int i = 1; i <= hours; i++)
            {
                action.SendKeys(Keys.ArrowUp);
            }
            AddDelay(500);
            for (int i = 0; i < 3; i++)
            {
                action.SendKeys(Keys.ArrowRight);
            }
            AddDelay(500);
            for (int i = 1; i <= minutes; i++)
            {
                action.SendKeys(Keys.ArrowUp);
            }
            AddDelay(500);
            for (int i = 0; i < 4; i++)
            {
                action.SendKeys(Keys.ArrowRight);
            }
            AddDelay(500);
            if (timeUnit.Equals("PM"))
            {
                action.SendKeys(Keys.ArrowDown);
            }
            action.Build().Perform();
        }

        /// <summary>
        ///  Method to Add Date to user input custom time field
        /// </summary>
        public static void CustomAddDateField(IWebElement element, string date)
        {
            string dd, mm, yyyy;
            String[] datesplit = date.Split('/');
            dd = datesplit[0].ToString();
            mm = datesplit[1].ToString();
            yyyy = datesplit[2].ToString();

            //Lines commentes as it does not work due to changes in Date calender UI.
            Actions action = new Actions(Driver);
            action.MoveToElement(element);
            AddDelay(500);
            action.Click();
            action.Build().Perform();
            ////action.SendKeys(Keys.Control_+ "a");
            //action.SendKeys(Keys.Control + "A").Perform();
            ////action.Build().Perform();
            for (int i = 0; i <= 10; i++)
            {
                action.SendKeys(Keys.ArrowLeft);
                AddDelay(100);
            }
            //AddDelay(500);
            //for (int i = 0; i < 9; i++)
            //{
            //    action.SendKeys(Keys.Backspace);
            //    AddDelay(100);
            //}
            //AddDelay(500);
            action.Build().Perform();
            element.SendKeys(mm);
            AddDelay(2000);
            element.SendKeys(dd);
            AddDelay(2000);
            element.SendKeys(yyyy);
            AddDelay(2000);
        }

        /// <summary>
        /// Method to get month name in three letter 
        /// </summary>
        /// <param name="date"></param>
        public static string GetMonth(string date)
        {
            var D1 = Convert.ToDateTime(date).ToString("MMM.dd,yyyy");
            string[] D2 = D1.Split('.');
            return D2[0];
        }

        /// <summary>
        /// Method to get Year from string with any format
        /// </summary>
        /// <param name="date"></param>
        public static string GetYear(string date)
        {
            var D1 = Convert.ToDateTime(date).ToString("MMM.dd,yyyy");
            string[] D2 = D1.Split(',');
            return D2[1];
        }

        /// <summary>
        /// Method to get Date from string with any format
        /// </summary>
        /// <param name="date"></param>
        public static string GetDate(string date)
        {
            var D1 = Convert.ToDateTime(date).ToString("MMM.dd,yyyy");
            string[] D2 = D1.Split('.');
            string[] D3 = D2[1].Split(',');
            return D3[0];
        }

        /// <summary>
        /// Method to get data field using jquery
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static string Getdata(IWebElement element)
        {
            Contract.Requires(element != null);
            Contract.Assert(String.IsNullOrWhiteSpace(element.GetAttribute("id")) == false, "Empty element 'id' attribute");

            //Build selector to get the element by the browser
            var cssSelector = String.Format("{0}#{1}",
            element.TagName, element.GetAttribute("id"));

            //Get WebDriver to look for elements and execute javaScript
            var webDriver = ((RemoteWebElement)element).WrappedDriver;

            //Build and execute the javaScript
            var script = String.Format(@"return $(""{0}"").val()", cssSelector);
            return ((IJavaScriptExecutor)webDriver).ExecuteScript(script) as string;
        }

        ///// <summary>
        ///// This method will get Page Title.
        ///// </summary>
        ///// <param name="element">Element to insert the text</param>
        //public static void RegexFunction(string PageTitle, string patternstyle)
        //{
        //    try
        //    {
        //        string pattern = patternstyle;
        //        AddDelay(500);
        //        string PageName = Regex.Replace(PageTitle, pattern, "");
        //        Logger.WriteDebugMessage("Landed on " + PageName + " page.");
        //    }
        //    catch (Exception)
        //    {
        //        Logger.WriteFatalMessage("Unable to click the " + CurrentElementName + " element on the " + CurrentPageName + " page.");
        //        throw;
        //    }
        //}

        public static void ValitionMessage(string message)
        {
            try
            {
                if (VerifyTextOnPage(message))
                {
                    Logger.WriteInfoMessage("Received Proper Validation Message on the page - " + message);
                }
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("Could not find valid validation message on the screen - " + message);
                throw;
            }
        }
    }
}
