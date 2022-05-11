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
    class MA_TP_326093_Manage_Audience_Campaigns_Column_Filter : MarketingAutomation.Utility.Setup
    {
            public MA_TP_326093_Manage_Audience_Campaigns_Column_Filter(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
            {
                Drivers = new ThreadLocal<IWebDriver>();
            }

            [SetUp]
            public static void Initialize()
            {
                TestPlanId = Constants.TP_326093;

                //Initialize the test case set up.
                InitializeSetup(Constants.TP_326093, Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "MarketingAuto");

                //Assign the test data test plan file location
                TestDataFile = TestDataLocation.POCExcel;

                //Navigate to the URL
                Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            }

         /*MA - Manage Audience - Campaigns (With Column Filter) - Validate Filter/Search for ID column - Search By Contains and Equal Filter.*/
         [Test, Category("Regression - QA")]
            public static void TC_326096()
            {
                try
                {

                    /**Test execution - Start**/
                    SetupTestCase(Constants.TC_326096, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                    Logger.DeleteOldFolder();

                    //Start
                    MainAdminApp.TP_326093();

                    /**Test execution - End**/
                    TestHandling.TestEnd();
                }
                catch (Exception e)
                {
                    TestHandling.TestFailed(e);
                    throw;
                }
            }

        /*MA - Manage Audience - Campaigns (With Column Filter) - Validate Filter/Search for Name column*/
        [Test, Category("Regression - QA")]
        public static void TC_326097()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_326097, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_326093();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Manage Audience - Campaigns (With Column Filter) - Validate Filter/Search for Status column*/
        [Test, Category("Regression - QA")]
        public static void TC_326098()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_326098, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_326093();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Manage Audience - Campaigns (With Column Filter) - Validate Filter/Search for Updated On column*/
        [Test, Category("Regression - QA")]
        public static void TC_326100()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_326100, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_326093();

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
