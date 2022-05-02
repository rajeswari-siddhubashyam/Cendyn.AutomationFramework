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
    class MA_TP_296600_CreateCampaignAudience: MarketingAutomation.Utility.Setup
    {
        public MA_TP_296600_CreateCampaignAudience(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_296600;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_296600, Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "MarketingAuto");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);

        }

        /*MA - Create Campaign/Audience Card View - Verify hover over shows when text is truncated  */
        [Test, Category("Regression - QA")]
        public static void TC_294729()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294729, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_296600();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }


        /*MA - Create Campaign/Audience Card View - Verify tags display on card when more than can fit on the card  */
        [Test, Category("Regression - QA")]
        public static void TC_294730()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294730, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_296600();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }


        /*MA - Create Campaign/Audience Card View - Verify Ellipses > Select & Continue option without selected audience*/
        [Test, Category("Regression - QA")]
        public static void TC_294733()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294733, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_296600();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Create Campaign/Audience Card View - Verify Ellipses > Select & Continue option with different audience selected*/
        [Test, Category("Regression - QA")]
        public static void TC_294734()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294734, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_296600();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }


        /*MA - Create Campaign/Audience Card View - Verify Ellipses > Select & Continue option with different audience selected*/
        [Test, Category("Regression - QA")]
        public static void TC_303959()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_303959, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_296600();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }


        /*MA - Create Campaign/Audience Card View - Validate Audience Card View*/
        [Test, Category("Regression - QA")]
        public static void TC_294727()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294727, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_296600();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        } 

        /*MA - Create Campaign/Audience Card View - Validate Audience Card View*/
        [Test, Category("Regression - QA")]
        public static void TC_294731()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294731, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_296600();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Create Campaign/Audience Card View - Verify Audience counts when counts are 0*/
        [Test, Category("Regression - QA")]
        public static void TC_298413()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_298413, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_296600();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Create Campaign/Audience Card View - Verify card data for Audience is correct*/
        [Test, Category("Regression - QA")]
        public static void TC_294732()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294732, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_296600();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Create Campaign/Audience Card View - Verify card display when Audience Counts don't exist (not run)*/
        [Test, Category("Regression - QA")]
        public static void TC_295387()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_295387, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_296600();

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
