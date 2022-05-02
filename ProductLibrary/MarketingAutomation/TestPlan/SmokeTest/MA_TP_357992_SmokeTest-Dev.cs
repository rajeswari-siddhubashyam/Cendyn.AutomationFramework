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
    class MA_TP_357992_SmokeTest_Dev : MarketingAutomation.Utility.Setup
    {
        public MA_TP_357992_SmokeTest_Dev(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_357992;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_357992, Constants.clientEnv.MarketingAutoDev, Enums.TestDataType.Controller, Enums.CaseType.NA, "MarketingAuto");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
        }


        /*MA - Create Marketing Campaign*/
        [Test, Category("Smoke - Dev")]
        public static void TC_333249()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333249, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoDev, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_357992();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw e;
            }
        }

        /*MA - Create Automated Campaign*/
        [Test, Category("Smoke - Dev")]
        public static void TC_357987()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_357987, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoDev, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_357992();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw e;
            }
        }

        /*MA - Create Audience*/
        [Test, Category("Smoke - Dev")]
        public static void TC_357988()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_357988, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoDev, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_357992();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw e;
            }
        }

        /*MA - Manage Campaign Edit and Clone - Card/List View.*/
        [Test, Category("Smoke - Dev")]
        public static void TC_357993()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_357993, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoDev, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_357992();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw e;
            }
        }

        /*MA - Manage Campaign Edit and Clone - Card/List View.*/
        [Test, Category("Smoke - Dev")]
        public static void TC_357994()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_357994, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoDev, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_357992();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw e;
            }
        }


        /*MA - Manage Audience*/
        [Test, Category("Smoke - Dev")]
        public static void TC_357995()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_357995, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoDev, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_357992();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw e;
            }
        }

        /*MA - Manage Template*/
        [Test, Category("Smoke - Dev")]
        public static void TC_357996()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_357996, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoDev, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_357992();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw e;
            }
        }


        /**MA - Create Segment*/
        [Test, Category("Smoke - Dev")]
        public static void TC_357997()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_357997, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoDev, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_357992();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw e;
            }
        }
        /**MA - Create Segment*/
        [Test, Category("Smoke - Dev")]
        public static void TC_359105()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_359105, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoDev, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_357992();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw e;
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