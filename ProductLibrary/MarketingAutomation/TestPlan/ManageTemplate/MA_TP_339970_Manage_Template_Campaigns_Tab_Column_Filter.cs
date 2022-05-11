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
    class MA_TP_339970_Manage_Template_Campaigns_Tab_Column_Filter : MarketingAutomation.Utility.Setup
    {
        public MA_TP_339970_Manage_Template_Campaigns_Tab_Column_Filter(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_339970;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_339970, Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "MarketingAuto");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
        }

        /*MA - Manage Template - Campaigns Tab (With Column Search) - Verify ID (Search By) Column-Search By Equals and Contains.*/
        [Test, Category("Regression - QA")]
        public static void TC_330363()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_330363, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_339970();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Manage Template - Campaigns Tab (With Column Search) - Verify Name (Search By) Column.*/
        [Test, Category("Regression - QA")]
        public static void TC_330364()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_330364, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_339970();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Manage Template - Campaigns Tab (With Column Search) - Verify Status Column.*/
        [Test, Category("Regression - QA")]
        public static void TC_330365()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_330365, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_339970();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Manage Template - Campaigns Tab (With Column Search) - Verify Updated On (Search By Date) Column.*/
        [Test, Category("Regression - QA")]
        public static void TC_330366()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_330366, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_339970();

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
