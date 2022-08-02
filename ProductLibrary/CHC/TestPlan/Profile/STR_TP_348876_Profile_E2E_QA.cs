using BaseUtility.Utility;
using InfoMessageLogger;
using CHC.AppModule.MainAdminApp;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TestData;
using Constants = CHC.Utility.Constants;

namespace CHC.TestPlan.Profile
{
    public class STR_TP_348876_Profile_E2E_QA : CHC.Utility.Setup
    {
        public STR_TP_348876_Profile_E2E_QA(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_348876;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_348876, Constants.clientEnv.CHCAutoQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "CHCAuto");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            Thread.Sleep(6000);
        }

        /*  */
        [Test, Category("Regression - QA")]
        public static void TC_348879()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_348879, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_348876();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  */
        [Test, Category("Regression - QA")]
        public static void TC_348890()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_348890, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_348876();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  */
        [Test, Category("Regression - QA")]
        public static void TC_348889()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_348889, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_348876();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  */
        [Test, Category("Regression - QA")]
        public static void TC_348888()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_348888, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_348876();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  */
        [Test, Category("Regression - QA")]
        public static void TC_348887()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_348887, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_348876();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  */
        [Test, Category("Regression - QA")]
        public static void TC_348886()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_348886, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_348876();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  */
        [Test, Category("Regression - QA")]
        public static void TC_348885()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_348885, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_348876();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  */
        [Test, Category("Smoke - QA")]
        public static void TC_348882()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_348882, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_348876();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  */
        [Test, Category("Regression - QA")]
        public static void TC_348881()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_348881, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_348876();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  */
        [Test, Category("Regression - QA")]
        public static void TC_348880()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_348880, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_348876();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  */
        [Test, Category("Regression - QA")]
        public static void TC_348878()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_348878, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_348876();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  */
        [Test, Category("Regression - QA")]
        public static void TC_311423()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_311423, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_348876();

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
