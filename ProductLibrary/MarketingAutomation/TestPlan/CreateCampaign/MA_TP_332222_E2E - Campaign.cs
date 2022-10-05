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
    class MA_TP_332222_E2E___Campaign : MarketingAutomation.Utility.Setup
    {
        public MA_TP_332222_E2E___Campaign()
        { }

        public MA_TP_332222_E2E___Campaign(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_332222;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_332222, Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "MarketingAuto");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
        }

        /*MA - Validate create campaign with draft status*/
        [Test, Category("E2E - Campaign")]
        public static void TC_333349()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333349, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }

        /*MA - Validate create campaign with Pending status*/
        [Test, Category("E2E - Campaign")]
        public static void TC_333350()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333350, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }

        /*MA - Validate create campaign with Approved status*/
        [Test, Category("E2E - Campaign")]
        public static void TC_333351()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333351, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }

        /*MA - Validate create campaign with Scheduled status*/
        [Test, Category("E2E - Campaign")]
        public static void TC_333352()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333352, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }

        /*MA - Validate create campaign with Rejected status*/
        [Test, Category("E2E - Campaign")]
        public static void TC_333354()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333354, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }

        /*MA - Manage Campaign - Marketing - Validate the clone campaign functionality*/
        [Test, Category("E2E - Campaign")]
        public static void TC_333356()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333356, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }

        /*MA - Marketing - Validate the campaign view details*/
        [Test, Category("E2E - Campaign")]
        public static void TC_333358()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333358, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }

        /*MA - Manage campaign - Automated - Validate the clone campaign functionality*/
        [Test, Category("E2E - Campaign")]
        public static void TC_333369()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333369, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }

        /*MA - Manage campaign - Automated - Validate the clone campaign functionality*/
        [Test, Category("E2E - Campaign")]
        public static void TC_333371()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333371, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }

        /*MA - Manage Campaign - Marketing - Validate the edit campaign functionality*/
        [Test, Category("E2E - Campaign")]
        public static void TC_333357()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333357, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }

        /*MA -  Manage campaign - Automated - Validate the edit campaign functionality*/
        [Test, Category("E2E - Campaign")]
        public static void TC_333370()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333370, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }

        /*MA - E2E - Manage Campaign - Marketing - Validate the card view with filters and sort*/
        [Test, Category("E2E - Campaign")]
        public static void TC_333359()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333359, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw e;
            }
        }

        /*MA - E2E - Manage Campaign - Marketing - Validate the list view with filters and sort*/
        [Test, Category("E2E - Campaign")]
        public static void TC_333360()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333360, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw e;
            }
        }

        /*MA - E2E - Manage campaign - Automated - Validate the card view with filters and sort*/
        [Test, Category("E2E - Campaign")]
        public static void TC_333372()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333372, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw e;
            }
        }

        /*MA - E2E - Manage campaign - Automated - Validate the list view with filters and sort*/
        [Test, Category("E2E - Campaign")]
        public static void TC_333374()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_333374, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw e;
            }
        }

        /*MA - E2E - Manage Audience - Card View - Validate the Card View.*/
        [Test, Category("E2E - Campaign")]
        public static void TC_335955()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_335955, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw e;
            }
        }

        /*MA - E2E - Manage Audience - Validate the Audience View Details - Summary.*/
        [Test, Category("E2E - Campaign")]
        public static void TC_335956()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_335956, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw e;
            }
        }

        /*MA - E2E - Manage Template - Card View - Validate Card View.*/
        [Test, Category("E2E - Campaign")]
        public static void TC_335938()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_335938, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw e;
            }
        }

        /*MA - E2E - Manage Template - Validate the Template View Details - Summary.*/
        [Test, Category("E2E - Campaign")]
        public static void TC_335945()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_335945, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw e;
            }
        }

        /*MA - E2E - Manage Template - Validate the Campaign Tab - Summary Page.*/
        [Test, Category("E2E - Campaign")]
        public static void TC_335946()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_335946, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw e;
            }
        }


        /*MA - E2E - Manage Template - List View - Validate the List View.*/
        [Test, Category("E2E - Campaign")]
        public static void TC_335948()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_335948, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw e;
            }
        }

        /*MA - E2E - Manage Audience - List View - Validate the List View.*/
        [Test, Category("E2E - Campaign")]
        public static void TC_335958()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_335958, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw e;
            }
        }


        /*MA - E2E - Manage Audience - Validate the Campaign Tab - Summary Page.*/
        [Test, Category("E2E - Campaign")]
        public static void TC_335957()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_335957, "Excel", MarketingAutomation.Utility.Constants.clientEnv.MarketingAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_332222();

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
