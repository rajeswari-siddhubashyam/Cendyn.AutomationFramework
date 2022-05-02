using Common;
using InfoMessageLogger;
using TestData;
using System;
using System.Configuration;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using AMR_Agent.PageObject.UI;

namespace AMR_Agent.Utility
{
    public class Setup : BaseUtility.Utility.Setup
    {
        public Setup()
        {
        }

        public Setup(string browser, string version, string os, string resoltion) : base(browser, version, os, resoltion)
        {

        }

        public static void InitializeSetup(string testPlanId, Enum clientName, Enum testDataType, Enum caseType, string projectName = null)
        {
            TestPlanId = testPlanId;
            SetupApplicationPath();

            //Initialize the test case set up.
            Setup.build = Environment.GetEnvironmentVariable("LT_BUILD") == null ? "AMR_Agent_LambdaTestExecution_" + DateTime.Now.ToString("MM") + DateTime.Now.ToString("dd") + DateTime.Now.ToString("yyyy") : Environment.GetEnvironmentVariable("LT_BUILD");
            SetupTestPlan(eProduct.AMR_Agent, clientName, testDataType, caseType, projectName);

            //Set Connection String
            //SetupConnectionString();

            //Navigate to the URL
            //Driver.Navigate().GoToUrl(url);
        }

        //Assign a ConnectionString                    
        public static void SetupConnectionString()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings[ProjectName].ConnectionString;
        }

        public static void SetupApplicationPath()
        {
            //ConnectionString = ConfigurationManager.ConnectionStrings[ProjectName].ConnectionString;
            Constants.RootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            Constants.GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            Constants.actualPath = CommonMethod.GetProjectPath("1");
            Constants.image_ActualPath = CommonMethod.GetProjectPath("0");
            Constants.ObjectRepofile = String.Concat(Constants.actualPath, ConfigurationManager.AppSettings["ObjectRepofile"]);
            CommonMethod.ScreenShotPath = Constants.ScreenshotPath = String.Concat(Constants.actualPath, ConfigurationManager.AppSettings["ScreenshotPath"]);
            Constants.ReportPath = String.Concat(Constants.actualPath, ConfigurationManager.AppSettings["ReportPath"]);
            CommonMethod.LogFilePath = Constants.LogFilePath = String.Concat(Constants.actualPath, ConfigurationManager.AppSettings["LoggerFile"]);
            Constants.ImagePath = String.Concat(Constants.image_ActualPath, ConfigurationManager.AppSettings["ImagePath"]);

            //Assign the location of the ScreenShot file path
            //ScreenShotPath = Constants.ScreenshotPath;

            //Assign the location of the log file path
            //LogFilePath = Constants.LogFilePath;
        }

        /// <summary>
        /// This method will scan the page for elements
        /// </summary>
        /// <param name="module">Module to assign elements to strings</param>
        public static void ScanPage(string module)
        {
            try
            {
                //Pass in the OR.XML directory and the Module to scan for elements.
                ObjectRepository.ReadElement(Constants.ObjectRepofile, module);
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage("The " + module
                    + " module was not found on the navigation.\n Check to make sure you're scanning the correct module!!!",
                    ex);
            }
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
                //                Logger.WriteInfoMessage("Landed on SignIn Page");
            }

        }
        public static void AMRCalendar(string month, string day, string year)
        {
            //Select the year
            PageObject_SubmitBooking.SubmitBooking_DatePickerYear().Click();
            PageObject_SubmitBooking.SubmitBooking_DatePickerYear().SendKeys(year);
            PageObject_SubmitBooking.SubmitBooking_DatePickerYear().SendKeys(Keys.Enter);
            Time.AddDelay(2000);
            //Select the month          
            PageObject_SubmitBooking.SubmitBooking_DatePickerMonth().Click();
            PageObject_SubmitBooking.SubmitBooking_DatePickerMonth().SendKeys(month);
            PageObject_SubmitBooking.SubmitBooking_DatePickerMonth().SendKeys(Keys.Enter);
            Time.AddDelay(1000);

            //Select the day by link name
            Driver.FindElement(By.LinkText(day)).Click();

            
        }
        public static bool ValidatePageURL(string URLtoCheck)
        {
            //obtain the current URL
            string pageURL = Driver.Url;

            if (pageURL == URLtoCheck)
                return true;

            return false;
        }
    }
}
