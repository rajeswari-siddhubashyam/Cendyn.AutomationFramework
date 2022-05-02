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
    class STR_UP_TP_356196_Profile_QA : CHC_Unified_Profile.Utility.Setup
    {
        public STR_UP_TP_356196_Profile_QA(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_356196;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_356196, Constants.clientEnv.CHCAutoQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "CHCAuto");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            Thread.Sleep(6000);
        }

        /*  */
        [Test, Category("Smoke - QA")]
        public static void TC_340276()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_340276, "Excel", CHC_Unified_Profile.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_356196();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  */
        [Test, Category("Smoke - QA")]
        public static void TC_340278()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_340278, "Excel", CHC_Unified_Profile.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_356196();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  */
        [Test, Category("Smoke - QA")]
        public static void TC_340284()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_340284, "Excel", CHC_Unified_Profile.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_356196();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  */
        [Test, Category("Smoke - QA")]
        public static void TC_340283()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_340283, "Excel", CHC_Unified_Profile.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_356196();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  */
        [Test, Category("Smoke - QA")]
        public static void TC_340280()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_340280, "Excel", CHC_Unified_Profile.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_356196();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  */
        [Test, Category("Smoke - QA")]
        public static void TC_340291()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_340291, "Excel", CHC_Unified_Profile.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_356196();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  */
        [Test, Category("Smoke - QA")]
        public static void TC_340281()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_340281, "Excel", CHC_Unified_Profile.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_356196();

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
