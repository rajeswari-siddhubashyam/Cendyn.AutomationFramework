using BaseUtility.Utility;
using RevIntel.Utility;
using NUnit.Framework;
using TestData;
using System;
using InfoMessageLogger;
using RevIntel.AppModule.MainAdminApp;
using OpenQA.Selenium;
using System.Threading;

namespace RevIntel
{
    class RevIntel_TP_252858_Room_Rate_Menu : RevIntel.Utility.Setup
    {

        public RevIntel_TP_252858_Room_Rate_Menu(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public RevIntel_TP_252858_Room_Rate_Menu() { }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_252858;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_252858, Enums.ClientName.RevIntel, Enums.TestDataType.Controller, Enums.CaseType.NA, "RevIntel");


            //Navigate to the URL

            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            AddDelay(1500);
        }

        /// <summary>
        /// Validate the Best Available Rate Contribution
        /// </summary>
        [Test, Category("RevIntel_TP_252858_Room_Rate_Menu")]
        public static void TC_252860()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252860, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252858();


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
        /// Validate the Total Revenue Analysis
        /// </summary>
        [Test, Category("RevIntel_TP_252858_Room_Rate_Menu")]
        public static void TC_252861()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252861, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252858();


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
