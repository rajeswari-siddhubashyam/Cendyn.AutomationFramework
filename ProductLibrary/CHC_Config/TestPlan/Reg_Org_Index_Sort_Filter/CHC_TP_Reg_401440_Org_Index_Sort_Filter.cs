using BaseUtility.Utility;
using InfoMessageLogger;
using CHC_Config.AppModule.MainAdminApp;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TestData;
using Constants = CHC_Config.Utility.Constants;

namespace CHC_Config.TestPlan.Reg_Org_Index_Sort_Filter
{
    class CHC_TP_Reg_401440_Org_Index_Sort_Filter : CHC_Config.Utility.Setup
    {
        public CHC_TP_Reg_401440_Org_Index_Sort_Filter(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [OneTimeSetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_401440;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_401440, Constants.clientEnv.CHC_ConfigQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "CHC_Config");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            Thread.Sleep(6000);
        }

        /* Users - Users management smoke test */
        [Test, Category("Regression - QA")]
        public static void TC_326760()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_326760, "Excel", CHC_Config.Utility.Constants.clientEnv.CHC_ConfigQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_401440();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Regression - QA")]
        public static void TC_326761()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_326761, "Excel", CHC_Config.Utility.Constants.clientEnv.CHC_ConfigQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_401440();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [TearDown]
        public void End()
        {
            TestHandling.EndTest();
        }
        [OneTimeTearDown]
        public void Close()
        {
            TestHandling.TearDown();
        }

    }
}
