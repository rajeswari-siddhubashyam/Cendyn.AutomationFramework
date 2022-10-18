    using InfoMessageLogger;
using InfoMessageLogger.ReportGeneration;
using TestData;
using TestData.ExcelData;
using AventStack.ExtentReports;
using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;

using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

namespace BaseUtility.Utility
{
    public class TestHandling : Helper
    {
        public static string RootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static ILog log = LogManager.GetLogger(typeof(Logger));
        public static ArrayList exceptionCapture = new ArrayList();

        public static void BrowserSetup()
        {
            if (BrowserType == "Chrome")
            {
                ChromeOptions chromeOptions = new ChromeOptions();
                chromeOptions.AddArgument("--start-maximized");
                chromeOptions.AddArgument("enable-automation");
                chromeOptions.AddArgument("--disable-infobars");
                chromeOptions.AddArgument("no-sandbox");
                //chromeOptions.AddArgument("--window-size=1600, 900");

                
                //chromeOptions.AddArgument("--no-sandbox");                
                Driver = new ChromeDriver(chromeOptions);
                //Driver.Manage().Window.Size = new Size(1600, 900);
                ((IJavaScriptExecutor)Driver).ExecuteScript("document.body.style.transform='scale(0.8)';");
            }
            if (BrowserType == "Firefox")
            {
                //var profile = new FirefoxProfile();
                //profile.AcceptUntrustedCertificates = true;
                FirefoxOptions options = new FirefoxOptions();
                options.AcceptInsecureCertificates = true;
                //FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(RootPath, "geckodriver.exe");
                ////service.FirefoxBinaryPath = String.Concat(RootPath, "\firefox.exe");
                //FirefoxDriver Driver = new FirefoxDriver(service);
                ////Driver = new FirefoxDriver(new FirefoxOptions { AcceptInsecureCertificates = true });
                ////Driver = new FirefoxDriver();
                Driver = new FirefoxDriver(options);
                //Driver.Manage().Window.Size = new Size(1366, 768);
                //Driver.Manage().Window.Maximize();
            }
            if (BrowserType == "InternetExplorer")
            {
                //Driver = new InternetExplorerDriver(RootPath);
                //var ieOptions = new InternetExplorerOptions()
                //{
                //    //InitialBrowserUrl = "https://hoteliconguestloyaltyqa.cendyn.com/en-US/Login?ReturnUrl=%2Fen-US",
                //    IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                //    IgnoreZoomLevel = true,
                //    EnableNativeEvents = true,
                //   // EnsureCleanSession = true
                //};
                var options = new InternetExplorerOptions();
                options.EnsureCleanSession = true;
                Driver = new InternetExplorerDriver();
                Driver.Manage().Window.Maximize();
            }
            if (BrowserType != "Firefox")
            {
                //Set wait times for Selenium 3.0.0
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            }

            //Setup Action obj
            if (BrowserType != "Firefox")
            {
                Actions = new Actions(Driver);
            }
        }

        public static void BrowserSetup_MultipleBrowser(string BrowserType)
        {

            if (BrowserType == "Chrome")
            {
                ChromeOptions chromeOptions = new ChromeOptions();
                chromeOptions.AddArgument("--start-maximized");
                chromeOptions.AddArgument("enable-automation");
                chromeOptions.AddArgument("--disable-infobars");
                chromeOptions.AddArgument("--ignore-ssl-errors=yes");
                chromeOptions.AddArgument("--ignore-certificate-errors");
                chromeOptions.AddArgument("--AcceptInsecureCertificates=yes");
                chromeOptions.AddArgument("no-sandbox");
                Driver = new ChromeDriver(chromeOptions);
            }
            if (BrowserType == "Firefox")
            {
                //var profile = new FirefoxProfile();
                //profile.AcceptUntrustedCertificates = true;
                FirefoxOptions options = new FirefoxOptions();
                options.AcceptInsecureCertificates = true;
                //FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(RootPath, "geckodriver.exe");
                ////service.FirefoxBinaryPath = String.Concat(RootPath, "\firefox.exe");
                //FirefoxDriver Driver = new FirefoxDriver(service);
                ////Driver = new FirefoxDriver(new FirefoxOptions { AcceptInsecureCertificates = true });
                ////Driver = new FirefoxDriver();
                Driver = new FirefoxDriver(options);
                Driver.Manage().Window.Maximize();
            }
            if (BrowserType == "InternetExplorer")
            {
                //Driver = new InternetExplorerDriver(RootPath);
                //var ieOptions = new InternetExplorerOptions()
                //{
                //    //InitialBrowserUrl = "https://hoteliconguestloyaltyqa.cendyn.com/en-US/Login?ReturnUrl=%2Fen-US",
                //    IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                //    IgnoreZoomLevel = true,
                //    EnableNativeEvents = true,
                //   // EnsureCleanSession = true
                //};
                Driver = new InternetExplorerDriver();
                Driver.Manage().Window.Maximize();
            }

            if (BrowserType != "Firefox")
            {
                //Set wait times for Selenium 3.0.0
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            }

            //Setup Action obj
            if (BrowserType != "Firefox")
            {
                Actions = new Actions(Driver);
            }
        }

        public static void CreateLog()
        {
            //Header for the test case on the log file
            MyExtentTest = MyExtent.CreateTest(ProjectName, "-------Execution of " + ProjectName + " - " + TestCaseId + " Test Begin Script-----");
            GetLogger.GetLog(TestCaseId, LogFilePath);
            Logger.StartExecution();
            Logger.Environmentdetails();

            //Update the log file to display the current test case
            Time.TestCaseLog(TestCaseId);

            //Set StepCount to 1.
            StepCount = 1;
        }

        /// <summary>
        /// Method is executed after every LogInNoConfirm Script.
        /// </summary>
        public static void TearDown()
        {
            /* This will close the browser immediately after the execution is completed */
            Driver.Quit();
            Logger.EndExecution();
            //MyExtent.(MyExtentTest);
            MyExtent.Flush();
            CaptureScreenshot.DeleteUnwantedFolders();
            Driver.Dispose();
        }

        public static void TestEnd()
        {
            /**Execution - End**/
            Logger.WriteInfoMessage(ProjectName + ":: Script ::Passed");
            MyExtentTest.Log(Status.Pass, "Script succesfully executed");
            if (Setup.LocalMachineExecution == 0 && TestPlanId != "TP_AutoIT")
            {
                ((IJavaScriptExecutor)Driver).ExecuteScript("lambda-status=passed");
            }
            if(TestDataReader.openExcel())
            {
                TestDataReader.closeExcel();
            }
        }

        public static void EndTest()
        {
            /* This will close the browser immediately after the execution is completed */
            // Driver.Quit();
            Logger.EndExecution();
            //MyExtent.EndTest(MyExtentTest);
            MyExtent.Flush();
            CaptureScreenshot.DeleteUnwantedFolders();
        }

        public static void TestFailed(Exception ex)
        {
            /**Handle the exception and capture screebshot in case of test script failure- Begin**/
            if(Setup.LocalMachineExecution == 0 && TestPlanId != "TP_AutoIT")
            {
                exceptionCapture.Add(ex.Message);
                ((IJavaScriptExecutor)Driver).ExecuteScript("lambda-exceptions", exceptionCapture);
                ((IJavaScriptExecutor)Driver).ExecuteScript("lambda-status=failed");
            }
            Logger.WriteErrorMessage(Assembly.GetCallingAssembly().GetName().Name + "_Flow :: Script::Failed", ex);
            CaptureImage.TakeScreenShot(ProjectName, ScreenShotPath);
            String screenshot = CaptureScreenshot.CapturescreenShot(ProjectName);
            var image = MyExtentTest.AddScreenCaptureFromPath(screenshot);
            MyExtentTest.Log(Status.Fail, ex.Message + " Script failed");
            MyExtentTest.Fail("Screenshot").AddScreenCaptureFromPath(screenshot);
            AddDelay(3500);
        }

        public static void SetupTestCase()
        {

        }

        public static IEnumerable<String> BrowserToRunWith()
        {
            String[] browser = { "Chrome", "InternetExplorer", "Firefox" };
            foreach (String b in browser)
            {
                yield return b;
            }
        }
        
        public static ChromeOptions ScreenMinimize()
        {
            //((IJavaScriptExecutor)Driver).ExecuteScript("document.body.style.transform='scale(0.8)';");
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArgument("Zoom 80%");
            return options;
        }

        public static void ScreenMimimize()
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("document.body.style.transform='scale(1)';");

        }
        
}
}