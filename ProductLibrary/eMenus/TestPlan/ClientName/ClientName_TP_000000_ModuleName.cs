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
    class ClientName_TP_000000_ModuleName : eMenus.Utility.Setup
    {
        public ClientName_TP_000000_ModuleName(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            //Initialize the test case set up.
            InitializeSetup(Constants.TP_000000, Enums.ClientName.eMenusAdmin, Enums.TestDataType.Controller, Enums.CaseType.NA, "ClientName");

            //Navigate to the URL
            //Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            Drivers.Value.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
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
