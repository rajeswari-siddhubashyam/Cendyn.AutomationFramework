using BaseUtility.Utility;
using InfoMessageLogger;
using CMS.AppModule.MainAdminApp;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TestData;
using Constants = CMS.Utility.Constants;

namespace CMS.TestPlan.QA
{
    class ClientName_TP_000000_ModuleName : CMS.Utility.Setup
    {
        public ClientName_TP_000000_ModuleName(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_000000;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_000000, Constants.clientEnv.CMSQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "CMS");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);

        }
        
        [Test, Category("Regression - QA")]
        public static void TC_000001()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_000001, "Excel", CMS.Utility.Constants.clientEnv.CMSQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

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
