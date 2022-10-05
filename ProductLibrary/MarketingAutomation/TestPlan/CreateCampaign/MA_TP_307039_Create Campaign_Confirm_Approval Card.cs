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
    class MA_TP_307039_Create_Campaign_Confirm_Approval_Card : MarketingAutomation.Utility.Setup
    {
        public MA_TP_307039_Create_Campaign_Confirm_Approval_Card()
        { }

        public MA_TP_307039_Create_Campaign_Confirm_Approval_Card(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_307039;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_307039, Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "MarketingAuto");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
        }

        /*MA - Create Campaign/Confirm - Approval Card - Validate when user click on Self Approve*/
        [Test, Category("E2E - Campaign")]
        public static void TC_307093()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_307093, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_307039();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }

        /*MA - Create Campaign/Confirm - Approval Card - Validate when user click on Send Request*/
        [Test, Category("E2E - Campaign")]
        public static void TC_307094()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_307094, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_307039();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }

        /*MA - Create Campaign/Confirm - Approval Card - Validate the Approval Card*/
        [Test, Category("E2E - Campaign")]
        public static void TC_307095()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_307095, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_307039();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }

        /*MA - Create Campaign/Confirm - Approval Card - Validate when user click on Approve*/
        [Test, Category("E2E - Campaign")]
        public static void TC_307096()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_307096, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_307039();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }

        /*MA - Create Campaign/Confirm - Approval Card -  Validate when user click Reject*/
        [Test, Category("E2E - Campaign")]
        public static void TC_307097()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_307097, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_307039();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }

        /*MA - Create Campaign/Confirm - Approval Card -  Validate Reject Approval Modal*/
        [Test, Category("E2E - Campaign")]
        public static void TC_307098()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_307098, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_307039();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }

        /*MA - Create Campaign/Confirm - Approval Card - Validate Cancel in Reject Approval Modal*/
        [Test, Category("E2E - Campaign")]
        public static void TC_312228()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_312228, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_307039();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }

        /*MA - Create Campaign/Confirm - Approval Card - Validate Reject in Reject Approval Modal*/
        [Test, Category("E2E - Campaign")]
        public static void TC_312229()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_312229, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_307039();

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
