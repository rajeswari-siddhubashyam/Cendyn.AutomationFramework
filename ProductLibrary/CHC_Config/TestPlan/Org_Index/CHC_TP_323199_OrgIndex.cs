using BaseUtility.Utility;
using InfoMessageLogger;
using CHC_Config.AppModule.MainAdminApp;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TestData;
using Constants = CHC_Config.Utility.Constants;

namespace CHC_Config.TestPlan.Org_Index
{
    class CHC_TP_323199_OrgIndex : CHC_Config.Utility.Setup
    {
        public CHC_TP_323199_OrgIndex(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        public CHC_TP_323199_OrgIndex()
        { }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_323199;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_323199, Constants.clientEnv.CHC_ConfigQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "CHC_Config");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            Thread.Sleep(6000);
        }

        /* Config - Org Index - Verify Property Details table */
        [Test, Category("Smoke - QA")]
        public static void TC_353241()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_353241, "Excel", CHC_Config.Utility.Constants.clientEnv.CHC_ConfigQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();
                
                //Start
                MainAdminApp.TP_323199();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /* Config - Org Index - Verify Search filter with Property Name */
        [Test, Category("Smoke - QA")]
        public static void TC_326759()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_326759, "Excel", CHC_Config.Utility.Constants.clientEnv.CHC_ConfigQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_323199();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /* Config - Org Index - Click on Property Name, brand, Chain */
        [Test, Category("Smoke - QA")]
        public static void TC_309597()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_309597, "Excel", CHC_Config.Utility.Constants.clientEnv.CHC_ConfigQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_323199();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /* Config - Org Index - Click on Create button */
        [Test, Category("Smoke - QA")]
        public static void TC_309602()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_309602, "Excel", CHC_Config.Utility.Constants.clientEnv.CHC_ConfigQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_323199();

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
