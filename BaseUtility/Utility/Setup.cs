using Common;
using InfoMessageLogger;
using InfoMessageLogger.ReportGeneration;
using TestData;
using TestData.ExcelData;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using System;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;

namespace BaseUtility.Utility
{
    //Chrome
    [TestFixture(Helper.BROWSER_CHROME, "100", "Windows 10", "1366x768")]
    //[TestFixture("Chrome", "78", "Windows 10", "1280x1024")]
    //[TestFixture("Chrome", "89", "Windows 8.1", "1280x1024")]
    //Firefox
    //[TestFixture(Helper.BROWSER_FIREFOX, "99", "Windows 10", "1366x768")]
    // [TestFixture("Firefox", "85", "Windows 10", "1280x800")]
    // [TestFixture("Firefox", "86", "Windows 8.1", "1280x1024")]
    //Internet Explorer
    //[TestFixture(Helper.BROWSER_INTERNETEXPLORER, "11.0", "Windows 10", "1366x768")]
    // [TestFixture("Internet Explorer", "11", "Windows 8.1", "1280x800")]
    //Microsoft Edge
    //  [TestFixture("MicrosoftEdge", "88", "Windows 10", "1680x1050")]
    //[TestFixture(Helper.BROWSER_MICROSOFTEDGE, "99", "Windows 10", "1280x800")]

    public class Setup : Helper
    {
        public static int LocalMachineExecution = 0; //1 means local & 0 means Lambdatest
        public static string LT_USERNAME = "sborade";
        //Environment.GetEnvironmentVariable("LT_USERNAME") ==null ? "your username" : Environment.GetEnvironmentVariable("LT_USERNAME");
        public static string LT_ACCESS_KEY = "KjfLHzAi54WQDIWauYpwEE8wx9NPdAmyldXzx3h3apEqaQD9jw";
        //Environment.GetEnvironmentVariable("LT_ACCESS_KEY") == null ? "your accessKey" : Environment.GetEnvironmentVariable("LT_ACCESS_KEY");
        public static bool tunnel = Boolean.Parse(Environment.GetEnvironmentVariable("LT_TUNNEL") == null ? "False" : Environment.GetEnvironmentVariable("LT_TUNNEL"));
        public static string build = Environment.GetEnvironmentVariable("LT_BUILD") == null ? "LambdaTestExecution_" + DateTime.Now.ToString("MM") + DateTime.Now.ToString("dd") + DateTime.Now.ToString("yyyy") : Environment.GetEnvironmentVariable("LT_BUILD");
        public static string seleniumUri = "https://sborade:KjfLHzAi54WQDIWauYpwEE8wx9NPdAmyldXzx3h3apEqaQD9jw@hub.lambdatest.com/wd/hub";
        //ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();
        public static String _browser;// r= "Firefox";
        public static String _version;//="71.0";
        public static String _os;//="windows";
        public static String _resolution;
        static string defGroupNo = "1";
        static eProduct _product;
        /// <summary>
        /// POC excel
        /// </summary>
        /// <param name="clientName"></param>
        /// <param name="testDataType"></param>
        /// <param name="caseType"></param>
        public static void SetupTestPlan(eProduct product, Enum clientName, Enum testDataType, Enum caseType, string projectName = null)
        {
            _product = product;
            //Assign the project name    
            if (String.IsNullOrEmpty(projectName))
            {
                ProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
            }
            else
            {
                ProjectName = projectName;
                if (ProjectName != "eInsight" && ProjectName != "eNgage" && ProjectName != "eProposal")
                {
                    TestDataReader.ProjectDetails(product, ProjectName, clientName, testDataType, caseType);

                    //Assign the common test data                       
                    TestDataReader.GetProjectDetails(product, clientName, caseType);

                    //Assign the browser type
                    BrowserType = TestDataReader.browsertype;

                    //Assign a ConnectionString            
                    //ConnectionString = ConfigurationManager.ConnectionStrings[ProjectName].ConnectionString;
                    TestDataReader.closeExcel();
                }
                if (ProjectName.Equals("eProposal"))
                {
                    //Assign the location of the ScreenShot file path
                    ScreenShotPath = ScreenShotPath;

                    //Assign the location of the log file path
                    LogFilePath = LogFilePath;
                }
                else
                {
                    //Assign the location of the ScreenShot file path
                    ScreenShotPath = Constants.ScreenshotPath;

                    //Assign the location of the log file path
                    LogFilePath = Constants.LogFilePath;
                }

                //Local or Lambda Test Execution
                if (LocalMachineExecution == 1 || TestPlanId == "TP_AutoIT")
                    TestHandling.BrowserSetup();
                else
                    InitializeLambdaSeleniumFour();
                    //InitializeLambda();
            }
        }
        //public static void SetupTestPlan_WithooutLamda(eProduct product, Enum clientName, Enum testDataType, Enum caseType, string projectName = null)
        //{
        //    _product = product;
        //    //Assign the project name    
        //    if (String.IsNullOrEmpty(projectName))
        //        ProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        //    else
        //        ProjectName = projectName;

        //    TestDataReader.ProjectDetails(product, ProjectName, clientName, testDataType, caseType);

        //    //Assign the common test data                       
        //    TestDataReader.GetProjectDetails(product, clientName, caseType);

        //    //Assign the browser type
        //    BrowserType = TestDataReader.browsertype;

        //    //Assign the location of the ScreenShot file path
        //    ScreenShotPath = Constants.ScreenshotPath;

        //    //Assign the location of the log file path
        //    LogFilePath = Constants.LogFilePath;

        //    //Create instance of the test browser
        //    TestHandling.BrowserSetup();

        //    //Assign a ConnectionString            
        //    //ConnectionString = ConfigurationManager.ConnectionStrings[ProjectName].ConnectionString;
     
        //    TestDataReader.closeExcel();
            
        //}

        public Setup()
        {
        }
        
        public Setup(string browser, string version, string os, string resolution)
        {
            _browser = browser;
            _version = version;
            _os = os;
            _resolution = resolution;
        }
       /* public static void InitializeLambda()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(CapabilityType.BrowserName, _browser);
            capabilities.SetCapability(CapabilityType.Version, _version);
            capabilities.SetCapability(CapabilityType.Platform, _os);
            capabilities.SetCapability("resolution", _resolution);
            capabilities.SetCapability("idleTimeout", "1800"); //extends idle timeout 
            capabilities.SetCapability("console", true);
            capabilities.SetCapability("network", false);
            //Requires a named tunnel.
            if (tunnel)
            {
                capabilities.SetCapability("tunnel", tunnel);
            }
            if (build != null)
            {
                capabilities.SetCapability("build", build);
            }

            capabilities.SetCapability("user", LT_USERNAME);
            capabilities.SetCapability("accessKey", LT_ACCESS_KEY);
            capabilities.SetCapability("name", String.Format("{0}:{1}", TestContext.CurrentContext.Test.ClassName, TestContext.CurrentContext.Test.MethodName));
            Driver = new RemoteWebDriver(new Uri(seleniumUri), capabilities, TimeSpan.FromSeconds(600));
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            Driver.Manage().Timeouts().PageLoad= TimeSpan.FromSeconds(40);
            Console.Out.WriteLine(Driver);
        } */
        /// <summary>
        /// POC excel
        /// </summary>
        /// <param name="testID"></param>
        /// <param name="fileType"></param>
        /// <param name="clientName"></param>
        /// <param name="testDataType"></param>
        /// <param name="caseType"></param>
        public static void SetupTestCase(string testID, string fileType, Enum clientName, Enum testDataType, Enum caseType)
        {
            //Assign test case ID
            TestCaseId = testID;

            //Define the extent report.   
            MyExtent = ExtentedReport.ExtentManager.GetInstance(Constants.ReportPath, ProjectName);
            TestDataReader.PopulateInCollectionExcel(_product ,Helper.GetEnumDescription(clientName), Helper.GetEnumDescription(testDataType), Helper.GetEnumDescription(caseType), TestCaseId, defGroupNo);
            
            ProjectDetails.ReadDataExcel(TestDataReader.KeyValuePair, TestCaseId);
            
            //Create a log file
            TestHandling.CreateLog();
            Logger.WriteInfoMessage("Window Size is: " + Driver.Manage().Window.Size.ToString());
        }

        public static string regexfunction(string source)
        {
            string pattern1 = "@(.*)";
            AddDelay(500);
            string RegexEmail = Regex.Replace(source, pattern1, "");
            return RegexEmail;
        }
        
        public static void InitializeLambdaSeleniumFour()
        {
            var capabilities = Helper.GetBrowserDriverOptions(_browser);
            capabilities.BrowserVersion = _version;
            Dictionary<string, object> ltOptions = new Dictionary<string, object>();
            ltOptions.Add("user", LT_USERNAME);
            ltOptions.Add("accessKey", LT_ACCESS_KEY);
            ltOptions.Add("platformName", _os);
            ltOptions.Add("resolution", _resolution);
            ltOptions.Add("idleTimeout", "1800"); //extends idle timeout 
            ltOptions.Add("console", true);
            ltOptions.Add("network", false);
            ltOptions.Add("name", String.Format("{0}:{1}", TestContext.CurrentContext.Test.ClassName, TestContext.CurrentContext.Test.MethodName));
            //Requires a named tunnel.
            if (tunnel)
            {
                ltOptions.Add("tunnel", tunnel);
            }
            if (build != null)
            {
                ltOptions.Add("build", build);
            }
            capabilities.AddAdditionalOption("LT:Options", ltOptions);

            Driver = new RemoteWebDriver(new Uri("https://" + LT_USERNAME + ":" + LT_ACCESS_KEY + "@hub.lambdatest.com/wd/hub"), capabilities);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(40);
            Console.Out.WriteLine(Driver);
        }
    }
}

