using BaseUtility.Utility;
using InfoMessageLogger;
using CHC_Config.AppModule.MainAdminApp;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TestData;
using Constants = CHC_Config.Utility.Constants;

namespace CHC_Config.TestPlan.Create_User
{
    class CHC_TP_389110_CreateUser_QA : CHC_Config.Utility.Setup
    {
        public CHC_TP_389110_CreateUser_QA(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [OneTimeSetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_389110;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_389110, Constants.clientEnv.CHC_ConfigQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "CHC_Config");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            Thread.Sleep(6000);
        }

        /* Config - Org Index - Verify Property Details table */
        [Test, Category("Regression - QA")]
        public static void TC_336529()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_336529, "Excel", CHC_Config.Utility.Constants.clientEnv.CHC_ConfigQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_389110();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /// <summary>
        /// Method is executed after every Test Script.
        /// </summary>
        [TearDown]
        public void Close()
        {
            TestHandling.TearDown();
        }
    }
 }

