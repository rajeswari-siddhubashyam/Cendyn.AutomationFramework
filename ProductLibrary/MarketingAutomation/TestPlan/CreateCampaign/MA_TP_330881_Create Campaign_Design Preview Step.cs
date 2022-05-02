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

    class MA_TP_330881_Create_Campaign_Design_Preview_Step : MarketingAutomation.Utility.Setup
    {
        public MA_TP_330881_Create_Campaign_Design_Preview_Step(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_330881;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_330881, Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "MarketingAuto");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
        }

        /*MA - Create Campaign - Design Preview Step - Send Test Button - Validate incorrect email*/
        [Test, Category("Regression - QA")]
        public static void TC_307250()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_307250, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_330881();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Create Campaign - Design Preview Step - Send Test Button - Send test email by keeping Recipient field empty*/
        [Test, Category("Regression - QA")]
        public static void TC_307251()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_307251, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_330881();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }


        /*MA - Create Campaign - Design Preview Step - Send Test Button - Send test email by keeping Seed List field empty*/
        [Test, Category("Regression - QA")]
        public static void TC_307252()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_307252, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_330881();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Create Campaign - Design Preview Step - Send Test Button - Send test email by entering proper value Recipient and Seed List*/
        [Test, Category("Regression - QA")]
        public static void TC_307253()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_307253, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_330881();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }



        /*MA - Create Campaign - Design Preview Step - Send Test Button - Send test email by entering multiple recipients emails*/
        [Test, Category("Regression - QA")]
        public static void TC_307254()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_307254, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_330881();

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

