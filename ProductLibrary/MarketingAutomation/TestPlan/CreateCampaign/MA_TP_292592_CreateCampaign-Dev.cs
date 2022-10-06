using BaseUtility.Utility;
using InfoMessageLogger;
using MarketingAutomation.AppModule.MainAdminApp;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TestData;
using Constants = MarketingAutomation.Utility.Constants;

namespace MarketingAutomation.TestPlan.Dev
{
    class MA_TP_292592_CreateCampaign : MarketingAutomation.Utility.Setup
    {
        public MA_TP_292592_CreateCampaign()
        { }

        public MA_TP_292592_CreateCampaign(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_292592;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_292592, Constants.clientEnv.MarketingAutoDev, Enums.TestDataType.Controller, Enums.CaseType.NA, "MarketingAuto");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);

        }
        /* This test case will  Verify merging when target Profile is Inactive */
        //[Test, Category("Regression - DEV")]
        //public static void TC_292525()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_292525, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoDev, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_292592();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
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
