using BaseUtility.Utility;
using InfoMessageLogger;
using MarketingAutomation.AppModule.MainAdminApp;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TestData;
using Constants = MarketingAutomation.Utility.Constants;

namespace MarketingAutomation.TestPlan.CreateTemplate
{
    class MA_TP_325454_Create_Template_Settings : MarketingAutomation.Utility.Setup
    {
        public MA_TP_325454_Create_Template_Settings()
        {

        }

        public MA_TP_325454_Create_Template_Settings(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_325454;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_325454, Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "MarketingAuto");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
        }

        /*Create Template - Validate Field names/types display in Settings Step*/
        [Test, Category("Regression - QA")]
        public static void TC_325458()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_325458, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_325454();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*Create Template - Validate Field - Name in Settings Step*/
        [Test, Category("Regression - QA")]
        public static void TC_325790()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_325790, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_325454();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*Create Template - Validate Field - Tags, selected from list in Settings Step*/
        [Test, Category("Regression - QA")]
        public static void TC_325792()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_325792, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_325454();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*Create Template - Validate Field - Description in Settings Step*/
        [Test, Category("Regression - QA")]
        public static void TC_325804()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_325804, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_325454();

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
