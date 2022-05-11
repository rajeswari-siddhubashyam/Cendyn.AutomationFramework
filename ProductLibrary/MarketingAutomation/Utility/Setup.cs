using Common;
using InfoMessageLogger;
using NUnit.Framework;
using System;
using System.Configuration;
using System.IO;
using System.Reflection;
using TestData;

namespace MarketingAutomation.Utility

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

            if (clientName.Equals(MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoDev))
            {
                Constants.FrontEndEmail = Constants.FrontEndEmailDev;
                Constants.CommonPassword = Constants.CommonPasswordDev;
                Constants.OrgNameQA = Constants.OrgNameDev;
            }

            TestPlanId = testPlanId;
            SetupApplicationPath();
            Setup.build = Environment.GetEnvironmentVariable("LT_BUILD") == null ? "MA_LambdaTestExecution_" + DateTime.Now.ToString("MM") + DateTime.Now.ToString("dd") + DateTime.Now.ToString("yyyy") : Environment.GetEnvironmentVariable("LT_BUILD");
            //Initialize the test case set up.
            SetupTestPlan(eProduct.MarketingAuto, clientName, testDataType, caseType, projectName);

            //Set Connection String
            SetupConnectionString(clientName);

            //Navigate to the URL
            //Driver.Navigate().GoToUrl(url);
       
        }

        //Assign a ConnectionString                    
        public static void SetupConnectionString(Enum clientName)
        {   
            ConnectionString = ConfigurationManager.ConnectionStrings[GetEnumDescription(clientName)].ConnectionString;
            ConnectionString2 = ConfigurationManager.ConnectionStrings["MarketingAutoQA_MDM"].ConnectionString;
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
    }
}
