using BaseUtility.Utility;
using RevIntel.Utility;
using NUnit.Framework;
using TestData;
using System;
using InfoMessageLogger;
using RevIntel.AppModule.MainAdminApp;
using OpenQA.Selenium;
using System.Threading;

namespace RevIntelExchangeRate
{
    class RevIntel_TP_274136_ExchangeRate : RevIntel.Utility.Setup
    {

        public RevIntel_TP_274136_ExchangeRate(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        /// <summary>
        /// Method is used to initialised the test plan
        /// </summary>
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_251469;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_251469, Enums.ClientName.RevIntel, Enums.TestDataType.Controller, Enums.CaseType.NA, "RevIntel");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_121734;

            //Navigate to the URL
            Driver.Navigate().GoToUrl("https://devrhbi.revintel.co/");
            AddDelay(1500);
        }

        [Test, Category("Exchange Rate")]
        public static void TC_269916()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_269916, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");


                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_274136();


                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Exchange Rate")]
        public static void TC_269917()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_269917, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");


                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_274136();


                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Exchange Rate")]
        public static void TC_269918()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_269918, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");


                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_274136();


                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Exchange Rate")]
        public static void TC_269919()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_269919, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");


                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_274136();


                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Exchange Rate")]
        public static void TC_269925()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_269925, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");


                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_274136();


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
