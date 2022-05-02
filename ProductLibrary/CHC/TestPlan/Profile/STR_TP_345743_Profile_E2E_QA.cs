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
    class STR_TP_345743_Profile_E2E_QA : CHC.Utility.Setup
    {
        public STR_TP_345743_Profile_E2E_QA(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_345743;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_345743, Constants.clientEnv.CHCAutoQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "CHCAuto");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            Thread.Sleep(6000);
        }

        /*  */
        [Test, Category("End2End - QA")]
        public static void TC_345744()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_345744, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_345743();

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
        [Test, Category("End2End - QA")]
        public static void TC_345746()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_345746, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_345743();

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
        [Test, Category("End2End - QA")]
        public static void TC_345747()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_345747, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_345743();

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
        [Test, Category("End2End - QA")]
        public static void TC_345748()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_345748, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_345743();

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
        [Test, Category("End2End - QA")]
        public static void TC_345749()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_345749, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_345743();

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
        [Test, Category("End2End - QA")]
        public static void TC_348626()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_348626, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_345743();

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
        [Test, Category("End2End - QA")]
        public static void TC_348628()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_348628, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_345743();

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
