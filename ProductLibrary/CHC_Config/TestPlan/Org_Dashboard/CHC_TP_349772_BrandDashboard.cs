using BaseUtility.Utility;
using InfoMessageLogger;
using CHC_Config.AppModule.MainAdminApp;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TestData;
using Constants = CHC_Config.Utility.Constants;

namespace CHC_Config.TestPlan.Org_Dashboard
{
    class CHC_TP_349772_BrandDashboard : CHC_Config.Utility.Setup
    {
        public CHC_TP_349772_BrandDashboard(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        public CHC_TP_349772_BrandDashboard()
        { }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_349772;
            
            //Initialize the test case set up.
            InitializeSetup(Constants.TP_349772, Constants.clientEnv.CHC_ConfigQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "CHC_Config");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;
          
            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            Thread.Sleep(6000);
        }

        /* Config - Brand Dashboard Verify Property Tab Details table */
        [Test, Category("Smoke - QA"), Order(3)]
        public static void TC_314618()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_314618, "Excel", CHC_Config.Utility.Constants.clientEnv.CHC_ConfigQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_349772();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        // Verify Localization , Phone number, links
        [Test, Category("Smoke - QA"), Order(2)]
        public static void TC_314610()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_314610, "Excel", CHC_Config.Utility.Constants.clientEnv.CHC_ConfigQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_349772();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /* Config - Static details on Brand Dashboard */
        [Test, Category("Smoke - QA"), Order(1)]
        public static void TC_314590()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_314590, "Excel", CHC_Config.Utility.Constants.clientEnv.CHC_ConfigQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_349772();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /* Config - Basic Edit Brand */
        [Test, Category("Smoke - QA"), Order(4)]
        public static void TC_349764()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_349764, "Excel", CHC_Config.Utility.Constants.clientEnv.CHC_ConfigQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_349772();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        [TearDown]
        public void End()
        {
            TestHandling.EndTest();
        }
        [OneTimeTearDown]
        public void Close()
        {
        //    Driver.Manage().Cookies.DeleteAllCookies();
         //   Driver.Navigate().GoToUrl("chrome://settings/clearBrowserData");
            //Driver.FindElement(By.XPath("//settings-ui")).SendKeys(OpenQA.Selenium.Keys.Enter);
            TestHandling.TearDown();
        }

    }
}
