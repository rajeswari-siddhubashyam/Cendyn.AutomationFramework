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
    class MA_TP_313012_CreateCampaignClone : MarketingAutomation.Utility.Setup
    {
        public MA_TP_313012_CreateCampaignClone(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_313012;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_313012, Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "MarketingAuto");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);

        }

        /* MA - Create Campaign - Clone - Validate clone campaign on setting page */
        [Test, Category("Regression - QA")]
        public static void TC_325735()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_325735, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);
                
                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_313012();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* MA - Create Campaign - Clone - Validate clone campaign name on Manage Campaign page from Setting page */
        [Test, Category("Regression - QA")]
        public static void TC_313016()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_313016, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_313012();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* MA - Create Campaign - Clone - Validate clone campaign name on Manage Campaign page after Self-Approve */
        [Test, Category("Regression - QA")]
        public static void TC_325734()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_325734, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_313012();

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
