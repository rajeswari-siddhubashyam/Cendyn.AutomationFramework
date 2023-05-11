using Common;
using InfoMessageLogger;
using InfoMessageLogger.ReportGeneration;
using BaseUtility.Utility;
using TestData;
using System;
using System.Configuration;
using System.IO;
using System.Reflection;
using SqlWarehouse;

namespace eInsight.Utility
{
    public class Setup : BaseUtility.Utility.Setup
    {
        public static string RootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);

        public Setup()
        {
        }

        public Setup(string browser, string version, string os, string resoltion) : base(browser, version, os, resoltion)
        {

        }

        //ProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;

        public static void InitializeSetup(string testPlanId, string projectName = null)
        {
            Enum clientName = null;
            Enum testDataType = null;
            Enum caseType = null;

            TestPlanId = testPlanId;
            //Set Connection String
            SetupConnectionString();
            //Import XML data to Common XML
            SqlWarehouseQuery.GetCommonXMLData(projectName);

            SetupApplicationPath();

            //Assign the common test data
            LegacyTestData.ReadData(Constants.ModuleCommon);

            //Assign the browser type
            BrowserType = LegacyTestData.CommonBrowserType;

            //Initialize the test case set up.
            //Setup.LocalMachineExecution = Convert.ToInt32(LegacyTestData.LambdaExecution);
            Setup.LT_USERNAME = LegacyTestData.LambdaUserName;
            Setup.LT_ACCESS_KEY = LegacyTestData.LambdaAccessKey;
            Setup.build = Environment.GetEnvironmentVariable("LT_BUILD") == null ? "eInsight_LambdaTestExecution_" + DateTime.Now.ToString("MM") + DateTime.Now.ToString("dd") + DateTime.Now.ToString("yyyy") : Environment.GetEnvironmentVariable("LT_BUILD");
            Setup.seleniumUri = LegacyTestData.LambdaHub;
            
            SetupTestPlan(eProduct.eInsight, clientName, testDataType, caseType, projectName);

            //Create instance of the test browser
            //TestHandling.BrowserSetup();

            //Navigate to the URL
            //Driver.Navigate().GoToUrl(url);

            //Can use this to update the URL Manually
            //LegacyTestData.CommonFrontendURL = "https://poceinsight.cendyn.com/";
        }

        //Assign a ConnectionString                    
        public static void SetupConnectionString()
        {
            ProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            ConnectionString = ConfigurationManager.ConnectionStrings[ProjectName].ConnectionString;
            ConnectionString2 = ConfigurationManager.ConnectionStrings["AppDB"].ConnectionString;
            ConnectionString3 = ConfigurationManager.ConnectionStrings["ProdAppDB"].ConnectionString;
            ConnectionString4 = ConfigurationManager.ConnectionStrings["POCAppDB"].ConnectionString;
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
            TestDataFile = String.Concat(RootPath, ConfigurationManager.AppSettings["CommonTestData"]);
            //Assign the location of the ScreenShot file path
            //ScreenShotPath = Constants.ScreenshotPath;

            //Assign the location of the log file path
            //LogFilePath = Constants.LogFilePath;
        }

        public static void Legacy_SetupTestCase(string testID)
        {
            //Assign test case ID
            TestCaseId = testID;

            //Define the extent report.   
            MyExtent = ExtentedReport.ExtentManager.GetInstance(Constants.ReportPath, ProjectName);

            //Obtain variables for the test case
            //TestData.ReadData(TestCaseId);

            //Create a log file
            TestHandling.CreateLog();

            if (testCategory == "PostDeployment")
            {
                LegacyTestData.CommonFrontendURL = LegacyTestData.CommonFrontendProdURL;
            }
            else if (testCategory == "EU02_PostDeployment")
            {
                LegacyTestData.CommonFrontendURL = LegacyTestData.CommonFrontendEU02URL;
            }else if (testCategory == "EU01_PostDeployment")
            {
                LegacyTestData.CommonFrontendURL = LegacyTestData.CommonFrontendEU01URL;
            }
            else if (LegacyTestData.CommonFrontendURL.Contains("poceinsight.cendyn.com"))
            {
                testCategory = "POC";
            }
            else
            {
                testCategory = "QA";
            }
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
