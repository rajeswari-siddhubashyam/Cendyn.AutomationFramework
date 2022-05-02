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
    class CHC_TP_349769_ChainDashboard : CHC_Config.Utility.Setup
    {
        public CHC_TP_349769_ChainDashboard(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [OneTimeSetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_349769;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_349769, Constants.clientEnv.CHC_ConfigQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "CHC_Config");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            Thread.Sleep(6000);
        }

        /* Config - Org Index - Verify Property Details table */
        [Test, Category("Smoke - QA"), Order(3)]
        public static void TC_314185()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_314185, "Excel", CHC_Config.Utility.Constants.clientEnv.CHC_ConfigQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_349769();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        
        [Test, Category("Smoke - QA"), Order(1)]
        public static void TC_314192()
        {
            try
            {
                SetupTestCase(Constants.TC_314192, "Excel", CHC_Config.Utility.Constants.clientEnv.CHC_ConfigQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_349769();

                //Test execution - End
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        [Test, Category("Smoke - QA"), Order(2)]
        public static void TC_314190()
        {
            try
            {
                SetupTestCase(Constants.TC_314190, "Excel", CHC_Config.Utility.Constants.clientEnv.CHC_ConfigQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_349769();

                //Test execution - End
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /// Method is executed after every Test Script.
        /// </summary>
        /// 
        [TearDown]
        public void End()
        {
            TestHandling.EndTest();
        }
        [OneTimeTearDown]
        public void Close()
        {
            TestHandling.TearDown();
        }
    }
}
