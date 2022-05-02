using System;
using System.Collections.Generic;
using BaseUtility.Utility;
using InfoMessageLogger;
using MarketingAutomation.AppModule.MainAdminApp;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TestData;
using Constants = MarketingAutomation.Utility.Constants;

namespace MarketingAutomation.TestPlan.QA
{

    class MA_TP_332222_E2E_Campaign : MarketingAutomation.Utility.Setup
    {
        public MA_TP_332222_E2E_Campaign(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_332222;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_332222, Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "MarketingAuto");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
        }

        /*MA - E2E - Create Campaign - Marketing - Validate create campaign with draft status*/
        [Test, Category("Regression - QA")]
        public static void TC_333349()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333349, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - E2E - Create Campaign - Marketing - Validate create campaign with Pending status*/
        [Test, Category("Regression - QA")]
        public static void TC_333350()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333350, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - E2E - Create Campaign - Marketing - Validate create campaign with Approved status*/
        [Test, Category("Regression - QA")]
        public static void TC_333351()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333351, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - E2E - Create Campaign - Marketing - Validate create campaign with Scheduled status*/
        [Test, Category("Regression - QA")]
        public static void TC_333352()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333352, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        
        /*MA - E2E - Create Campaign - Marketing - Validate create campaign with Rejected status*/
        [Test, Category("Regression - QA")]
        public static void TC_333354()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333354, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

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

