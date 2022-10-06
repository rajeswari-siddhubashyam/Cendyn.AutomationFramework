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

    class MA_TP_333579_Manage_Common_Grid_List : MarketingAutomation.Utility.Setup
    {
        public MA_TP_333579_Manage_Common_Grid_List()
        { }

        public MA_TP_333579_Manage_Common_Grid_List(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_333579;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_333579, Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "MarketingAuto");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
        }
                      

        /*MA - Direct Campaign Login of Marketing Manager User*/
        [Test, Category("Regression - QA")]
        public static void TC_333143()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333143, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_333579();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Direct Audience Login of CRM Analyst user*/
        [Test, Category("Regression - QA")]
        public static void TC_333159()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333159, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_333579();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Direct Templates Login of Designer User*/
        [Test, Category("Regression - QA")]
        public static void TC_333163()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333163, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_333579();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
           catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Direct Templates Login of Marketing Co-ordinator user*/
        [Test, Category("Regression - QA")]
        public static void TC_333170()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333170, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_333579();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - CHC Login to MA- Campaigns / Audience / Templates for Admin user*/
        [Test, Category("Regression - QA")]
        public static void TC_333179()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333179, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_333579();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        

        /*MA - Direct Templates Login of Admin user*/
        [Test, Category("Regression - QA")]
        public static void TC_333160()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333160, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_333579();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw e;
            }
        }

        /*MA - Direct Audience Login of Admin User*/
        [Test, Category("Regression - QA")]
        public static void TC_333146()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333146, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_333579();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw e;
            }
        }

        /*MA - Direct Campaign Login of Admin user*/
        //[Test, Category("Smoke - QA")]
        [Test, Category("Regression - QA")]
        public static void TC_333134()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333134, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();


                //Start
                MainAdminApp.TP_333579();

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

