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

    class MA_TP_320503_ManageCampaign_Grid_View_without_Filter_and_sort : MarketingAutomation.Utility.Setup
    {
        public MA_TP_320503_ManageCampaign_Grid_View_without_Filter_and_sort(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_320503;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_320503, Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "MarketingAuto");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
        }

        /*Manage Campaign - Grid View - Validate the toggle to switch between Card and Grid view*/
        [Test, Category("Regression - QA")]
        public static void TC_320504()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_320504, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_320503();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*Manage Campaign - Grid View - Validate the toggle to switch between Marketing and Automated*/
        [Test, Category("Regression - QA")]
        public static void TC_320505()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_320505, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_320503();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }


        /*MA - Manage Campaign - Grid View - If the text is long then Name should have hover over and ...*/
        [Test, Category("Regression - QA")]
        public static void TC_320506()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_320506, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_320503();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*Grid View - If the text is long then Audience should have hover over and ...*/
        [Test, Category("Regression - QA")]
        public static void TC_320507()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_320507, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_320503();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Manage Campaign - Grid View - Validate the Campaign Name is clickable*/
        [Test, Category("Regression - QA")]
        public static void TC_320508()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_320508, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_320503();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Manage Campaign - Grid View - Validate the columns in grid*/
        [Test, Category("Regression - QA")]
        public static void TC_320509()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_320509, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_320503();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Manage Campaign - Grid View - Validate the ID column*/
        [Test, Category("Regression - QA")]
        public static void TC_320510()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_320510, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_320503();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Manage Campaign - Grid View - Validate the Name column*/
        [Test, Category("Regression - QA")]
        public static void TC_320511()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_320511, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_320503();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Manage Campaign - Grid View - Validate the Status column*/
        [Test, Category("Regression - QA")]
        public static void TC_320512()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_320512, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_320503();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Manage Campaign - Grid View - Validate the Audience column*/
        [Test, Category("Regression - QA")]
        public static void TC_320513()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_320513, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_320503();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Manage Campaign - Grid View - Validate the Updated By column*/
        [Test, Category("Regression - QA")]
        public static void TC_320514()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_320514, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_320503();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Manage Campaign - Grid View - Validate the Updated On column*/
        [Test, Category("Regression - QA")]
        public static void TC_320515()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_320515, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_320503();

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

