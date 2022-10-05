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
    class RevIntel_TP_292748_Pace_and_Forecast_YOY_Comparision : RevIntel.Utility.Setup
    {
        public RevIntel_TP_292748_Pace_and_Forecast_YOY_Comparision(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        public RevIntel_TP_292748_Pace_and_Forecast_YOY_Comparision() { }

        /// <summary>
        /// Method is used to initialised the test plan
        /// </summary>
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_292748;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_292748, Enums.ClientName.RevIntel, Enums.TestDataType.Controller, Enums.CaseType.NA, "RevIntel");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_121734;

            //Navigate to the URL
            Driver.Navigate().GoToUrl("https://devrhbi.revintel.co/");
            AddDelay(1500);
        }


        /// <summary>
         //Validate Pace and Forecast Report Current year data
        /// </summary>
        [Test, Category("RevIntel_TP_292748_Pace_and_Forecast_YOY_Comparision")]
        public static void TC_279694()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_279694, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_292748();

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
        //Validate Pace and Forecast Report when comparison year is 3 at hotel Level
        /// </summary>
        [Test, Category("RevIntel_TP_292748_Pace_and_Forecast_YOY_Comparision")]
        public static void TC_279691()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_279691, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_292748();


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
        //Validate Pace and Forecast Report when comparison year is 2 at hotel Level
        /// </summary>
        [Test, Category("RevIntel_TP_292748_Pace_and_Forecast_YOY_Comparision")]
        public static void TC_279690()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_279690, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_292748();


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
        //Validate Pace and Forecast Report when comparison year is 1 at hotel Level
        /// </summary>
        [Test, Category("RevIntel_TP_292748_Pace_and_Forecast_YOY_Comparision")]
        public static void TC_279689()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_279689, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_292748();


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

