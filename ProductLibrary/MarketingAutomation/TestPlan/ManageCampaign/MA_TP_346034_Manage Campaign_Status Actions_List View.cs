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

    class MA_TP_346034_Manage_Campaign_Status_Actions_List_View : MarketingAutomation.Utility.Setup
    {
        public MA_TP_346034_Manage_Campaign_Status_Actions_List_View()
        { }

        public MA_TP_346034_Manage_Campaign_Status_Actions_List_View(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_346034;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_346034, Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "MarketingAuto");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
        }

        /*MA - Manage Campaign - Status Actions - List View - Validate the Draft status when there is no audience and template attached to the campaign*/
        [Test, Category("Regression - QA")]
        public static void TC_346059()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_346059, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_346034();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Manage Campaign - Status Actions - List View - Approved status*/
        [Test, Category("Regression - QA")]
        public static void TC_346051()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_346051, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_346034();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Manage Campaign - Status Actions - List View - Rejected status*/
        [Test, Category("Regression - QA")]
        public static void TC_346055()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_346055, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_346034();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Manage Campaign - Status Actions - List View - Schedule Active status*/
        [Test, Category("Regression - QA")]
        public static void TC_346056()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_346056, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_346034();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Manage Campaign - Status Actions - List View - Schedule Inactive status*/
        [Test, Category("Regression - QA")]
        public static void TC_346057()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_346057, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_346034();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*MA - Manage Campaign - Status Actions - List View - Validate the Draft status when audience and template attached to the campaign*/
        [Test, Category("Regression - QA")]
        public static void TC_346058()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_346058, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_346034();

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
