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
    class MA_TP_342879_Create_Template_Settings_Step : MarketingAutomation.Utility.Setup
    {
        public MA_TP_342879_Create_Template_Settings_Step(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_342879;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_342879, Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "MarketingAuto");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
        }

        /*MA - Template - Add Unsubscribe flag and Click link - Create Template - Verify Unsubscribe and BrowserLink fields 
         * in TemplateVersion table when both on Setting page is enabled*/
        [Test, Category("Regression - QA")]
        public static void TC_335991()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_335991, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_342879();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Template - Add Unsubscribe flag and Click link - Create Template - Verify Unsubscribe and BrowserLink fields in 
         * TemplateVersion table when both on Setting page is disabled*/
        [Test, Category("Regression - QA")]
        public static void TC_335994()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_335994, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_342879();

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
