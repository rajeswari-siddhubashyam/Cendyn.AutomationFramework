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
    class STR_TP_344217_Profile_E2E_QA : CHC.Utility.Setup
    {
        public STR_TP_344217_Profile_E2E_QA(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        public STR_TP_344217_Profile_E2E_QA() { }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_344217;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_344217, Constants.clientEnv.CHCAutoQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "CHCAuto");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            Thread.Sleep(6000);
        }

        /*  */
        [Test, Category("End2End - QA")]
        public static void TC_344018()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_344018, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_344217();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        
        [Test, Category("End2End - QA")]
        public static void TC_344019()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_344019, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_344217();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        
        [Test, Category("End2End - QA")]
        public static void TC_344020()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_344020, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_344217();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("End2End - QA")]
        public static void TC_344024()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_344024, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_344217();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("End2End - QA")]
        public static void TC_343794()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_343794, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_344217();

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