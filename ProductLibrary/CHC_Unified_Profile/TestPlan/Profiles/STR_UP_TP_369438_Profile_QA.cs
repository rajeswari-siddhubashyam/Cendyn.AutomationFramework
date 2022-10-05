using BaseUtility.Utility;
using InfoMessageLogger;
using CHC_Unified_Profile.AppModule.MainAdminApp;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TestData;
using Constants = CHC_Unified_Profile.Utility.Constants;

namespace CHC_Unified_Profile.TestPlan.Profiles
{
    class STR_UP_TP_369438_Profile_QA : CHC_Unified_Profile.Utility.Setup
    {
        public STR_UP_TP_369438_Profile_QA(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        public STR_UP_TP_369438_Profile_QA() { }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_369438;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_369438, Constants.clientEnv.CHC_UP_AutoQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "CHCUPAuto");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            Thread.Sleep(6000);
        }

        /*  */
        [Test, Category("Smoke - QA")]
        public static void TC_332462()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_332462, "Excel", CHC_Unified_Profile.Utility.Constants.clientEnv.CHC_UP_AutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_369438();

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
