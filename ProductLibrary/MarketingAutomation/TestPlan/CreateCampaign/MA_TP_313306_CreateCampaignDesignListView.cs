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

    class MA_TP_313306_CreateCampaignDesignListView: MarketingAutomation.Utility.Setup
    {
        public MA_TP_313306_CreateCampaignDesignListView(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_313306;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_313306, Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "MarketingAuto");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
        }

        

        /*MA - Create Campaign - Design - List View - without sort and filter - Validate List view*/
        [Test, Category("Regression - QA")]
        public static void TC_313308()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_313308, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_313306();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }


        /*MA - Create Campaign - Design - List View - without sort and filter - Validate Hover over functionality*/
        [Test, Category("Regression - QA")]
        public static void TC_313309()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_313309, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_313306();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Create Campaign - Design - List View - without sort and filter - Validate default load*/
        [Test, Category("Regression - QA")]
        public static void TC_313310()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_313310, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_313306();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

       

        /*MA - Create Campaign - Design - List View - without sort and filter - Validate pagination for list view*/
        [Test, Category("Regression - QA")]
        public static void TC_313311()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_313311, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_313306();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Create Campaign - Design - List View - without sort and filter - Validate Name column*/
        [Test, Category("Regression - QA")]
        public static void TC_313312()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_313312, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_313306();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Create Campaign - Design - List View - without sort and filter - Validate Tags column*/
        [Test, Category("Regression - QA")]
        public static void TC_313313()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_313313, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_313306();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Create Campaign - Design - List View - without sort and filter - Validate Tags label*/
        [Test, Category("Regression - QA")]
        public static void TC_313314()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_313314, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_313306();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Create Campaign - Design - List View - without sort and filter - Validate Campaign column*/
        [Test, Category("Regression - QA")]
        public static void TC_313315()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_313315, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_313306();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Create Campaign - Design - List View - without sort and filter - Validate List view*/
        [Test, Category("Regression - QA")]
        public static void TC_313307()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_313307, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_313306();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Create Campaign - Design - List View - without sort and filter - Validate Updated by column*/
        [Test, Category("Regression - QA")]
        public static void TC_313316()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_313316, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_313306();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Create Campaign - Design - List View - without sort and filter - Validate Updated On column*/
        [Test, Category("Regression - QA")]
        public static void TC_313317()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_313317, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_313306();

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
