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
    class MA_TP_309532_CreateCampaignSuccess : MarketingAutomation.Utility.Setup
    {
        public MA_TP_309532_CreateCampaignSuccess()
        { }

        public MA_TP_309532_CreateCampaignSuccess(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_309532;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_309532, Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "MarketingAuto");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
        }

        /*MA - Create Campaign - Success Page - Validate schedule card displayed in Confirm page*/
        [Test, Category("Regression - QA")]
        public static void TC_309801()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_309801, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_309532();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Create Campaign - ScheduleCard/Success Page - Validate send ddm*/
        [Test, Category("Regression - QA")]
        public static void TC_309802()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_309802, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_309532();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }


        /*MA - Create Campaign - ScheduleCard/Success Page - Validate campaign when Once selected from Send ddm*/
        [Test, Category("Regression - QA")]
        public static void TC_309803()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_309803, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_309532();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Create Campaign - ScheduleCard/Success Page - Validate campaign when Daily selected from Send ddm*/
        [Test, Category("Regression - QA")]
        public static void TC_309804()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_309804, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_309532();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Create Campaign - ScheduleCard/Success Page - Validate campaign when Weekly selected from Send ddm*/
        [Test, Category("Regression - QA")]
        public static void TC_309805()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_309805, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_309532();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }


        /*MA - Create Campaign - ScheduleCard/Success Page - Validate campaign when Monthly selected from Send ddm*/
        [Test, Category("Regression - QA")]
        public static void TC_309806()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_309806, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_309532();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }


        /*MA - Create Campaign - ScheduleCard/Success Page - Validate campaign when x-Minutes selected from Send ddm*/
        [Test, Category("Regression - QA")]
        public static void TC_309812()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_309812, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_309532();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }

        /*MA - Create Campaign - ScheduleCard/Success Page - Validate minute ddm when x-Minutes selected from send ddm*/
        [Test, Category("Regression - QA")]
        public static void TC_309816()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_309816, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_309532();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw e;
            }
        }

        /*MA - Create Campaign - ScheduleCard/Success Page - Validate campaign when Immediate (real time) selected from Send ddm*/
        [Test, Category("Regression - QA")]
        public static void TC_309809()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_309809, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_309532();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }

        /*MA - Create Campaign - ScheduleCard/Success Page - Validate campaign when Hourly selected from Send ddm*/
        [Test, Category("Regression - QA")]
        public static void TC_309810()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_309810, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_309532();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }

        /*MA - Create Campaign - ScheduleCard/Success Page - Validate hours ddm when Hourly selected from send ddm*/
        [Test, Category("Regression - QA")]
        public static void TC_309811()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_309811, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_309532();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }

        /*MA - Create Campaign - ScheduleCard/Success Page - Validate edit campaign when Once selected from send ddm*/
        [Test, Category("Regression - QA")]
        public static void TC_309817()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_309817, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_309532();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }

        /*MA - Create Campaign - ScheduleCard/Success Page - Validate edit campaign when Daily selected from send ddm*/
        [Test, Category("Regression - QA")]
        public static void TC_309819()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_309819, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_309532();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }

        /*MA - Create Campaign - ScheduleCard/Success Page - Validate edit campaign when Weekly selected from send ddm*/
        [Test, Category("Regression - QA")]
        public static void TC_309821()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_309821, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_309532();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }

        /*MA - Create Campaign - ScheduleCard/Success Page - Validate edit campaign when Monthly selected from send ddm*/
        [Test, Category("Regression - QA")]
        public static void TC_309825()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_309825, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_309532();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
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
