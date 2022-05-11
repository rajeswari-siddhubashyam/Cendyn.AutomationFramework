using TestData;
using NUnit.Framework;
using System;
using InfoMessageLogger;
using eMenus.AppModule.MainAdminApp;
using BaseUtility.Utility;
using TestData.ExcelData;
using OpenQA.Selenium;
using System.Threading;
using eMenus.Utility;

namespace eMenus.TestPlan.ClientName
{
    class HotelOrigami_TP_231896_FrontEnd : eMenus.Utility.Setup
    {
        public HotelOrigami_TP_231896_FrontEnd(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            //Initialize the test case set up.
            InitializeSetup(Constants.TP_231896, Enums.ClientName.eMenusAdmin, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");

            //Navigate to the URL
            //Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
        }
        /* This test case will Validate user is able to Create Account successfully. */
        [Test, Category("Hotel Origami TP_231896 Frontend")]
        public static void TC_231915()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_231915, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231896();

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
