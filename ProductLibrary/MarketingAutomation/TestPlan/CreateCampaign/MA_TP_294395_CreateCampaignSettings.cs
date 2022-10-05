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
    class MA_TP_294395_CreateCampaignSettings : MarketingAutomation.Utility.Setup
    {
        public MA_TP_294395_CreateCampaignSettings()
        { }
            
        public MA_TP_294395_CreateCampaignSettings(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_294395;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_294395, Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "MarketingAuto");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);

        }

        /* MA - Create Campaign/Settings - Validate Settings page upon load */
        [Test, Category("Regression - QA")]
        public static void TC_293201()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_293201, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);
                
                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_294395();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }


        /* MA - Create Campaign/Settings - Verify field validation */
        [Test, Category("Regression - QA")]
        public static void TC_293202()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_293202, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_294395();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }


        /* MA - Create Campaign/Settings - Validate creating a campaign with only required fields */
        [Test, Category("Regression - QA")]
        public static void TC_293203()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_293203, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_294395();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Create Campaign/Settings - Validate creating a campaign with all fields */
        [Test, Category("Regression - QA")]
        public static void TC_293204()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_293204, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_294395();

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
