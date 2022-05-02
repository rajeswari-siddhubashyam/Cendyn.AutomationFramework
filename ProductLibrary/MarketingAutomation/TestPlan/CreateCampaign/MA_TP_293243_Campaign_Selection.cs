using TestData;
using NUnit.Framework;
using System;
using InfoMessageLogger;
using Marketing_Automation.AppModule.MainAdminApp;
using BaseUtility.Utility;
using TestData.ExcelData;
using OpenQA.Selenium;
using System.Threading;
using Marketing_Automation.Utility;

namespace Marketing_Automation.TestPlan.ClientName
{
    class MA_TP_293243_Campaign_Selection : Marketing_Automation.Utility.Setup
    {
        public MA_TP_293243_Campaign_Selection(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_293243;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_293243, Enums.ClientName.MarketingAuto, Enums.TestDataType.Controller, Enums.CaseType.NA, "MarketingAuto");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_218533;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            
        }
        /* This test case will Verify the Sign In Functionality for Front End */
        [Test, Category("Smoke")]
        public static void TC_292525()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_292525, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_293243();

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
