using TestData;
using NUnit.Framework;
using System;
using InfoMessageLogger;
using CHC_Config.AppModule.MainAdminApp;
using BaseUtility.Utility;
using TestData.ExcelData;
using OpenQA.Selenium;
using System.Threading;
using CHC_Config.Utility;

namespace CHC_Config.TestPlan.ClientName
{
    class ClientName_TP_000000_ModuleName : CHC_Config.Utility.Setup
    {
        public ClientName_TP_000000_ModuleName(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public ClientName_TP_000000_ModuleName()
        { }

        [SetUp]
        public static void Initialize()
        {
            //Initialize the test case set up.
            InitializeSetup(Constants.TP_000000, Constants.clientEnv.CHC_ConfigQA , Enums.TestDataType.Controller, Enums.CaseType.NA, "CHC_Config");

            //Navigate to the URL
            //Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
        }

        [Test, Category("Regression")]
        public static void TC_000000()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_000000, "Excel", CHC_Config.Utility.Constants.clientEnv.CHC_ConfigQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_000000();

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
