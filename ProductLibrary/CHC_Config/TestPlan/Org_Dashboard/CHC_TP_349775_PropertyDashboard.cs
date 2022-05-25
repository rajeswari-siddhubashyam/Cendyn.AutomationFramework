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
    class CHC_TP_349775_PropertyDashboard : CHC_Config.Utility.Setup
    {
        public CHC_TP_349775_PropertyDashboard(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [OneTimeSetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_349775;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_349775, Constants.clientEnv.CHC_ConfigQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "CHC_Config");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            Thread.Sleep(6000);
        }

        /* Config - Property Dashboard Advanced COnfig */
        [Test, Category("Smoke - QA"), Order(3)]
        public static void TC_314581()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_314581, "Excel", CHC_Config.Utility.Constants.clientEnv.CHC_ConfigQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_349775();

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
        public static void TC_314570()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_314570, "Excel", CHC_Config.Utility.Constants.clientEnv.CHC_ConfigQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_349775();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /* Config - Static details on Property Dashboard */
        [Test, Category("Smoke - QA"), Order(1)]
        public static void TC_314204()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_314204, "Excel", CHC_Config.Utility.Constants.clientEnv.CHC_ConfigQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_349775();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /* Config - Basic Edit Property */
        [Test, Category("Smoke - QA"), Order(4)]
        public static void TC_349765()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_349765, "Excel", CHC_Config.Utility.Constants.clientEnv.CHC_ConfigQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_349775();

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
            TestHandling.TearDown();
        }

    }
}
