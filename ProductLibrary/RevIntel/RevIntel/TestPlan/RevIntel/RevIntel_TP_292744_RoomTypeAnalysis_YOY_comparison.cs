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
    class RevIntel_TP_292744_RoomTypeAnalysis_YOY_comparison : RevIntel.Utility.Setup
    {
        public RevIntel_TP_292744_RoomTypeAnalysis_YOY_comparison(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        /// <summary>
        /// Method is used to initialised the test plan
        /// </summary>
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_292744;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_292744, Enums.ClientName.RevIntel, Enums.TestDataType.Controller, Enums.CaseType.NA, "RevIntel");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_121734;

            //Navigate to the URL
            Driver.Navigate().GoToUrl("https://devrhbi.revintel.co/");
            AddDelay(1500);
        }


        /// <summary>
         //Validate Room Type analysis when comparison year is 1 at portfolio level and a filter
        /// </summary>
        [Test, Category("TP_292744_YOY_comparison")]
        public static void TC_279700()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_279700, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_292744();

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
        //Validate Room Type analysis Current year data
        /// </summary>
        [Test, Category("TP_292744_YOY_comparison")]
        public static void TC_279701()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_279701, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_292744();


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
        // Validate Room Type analysis when comparison year is 1 at hotel Level
        /// </summary>
        [Test, Category("TP_292744_YOY_comparison")]
        public static void TC_279696()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_279696, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_292744();


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
        //Validate Room Type analysis when comparison year is 2 at hotel Level
        /// </summary>
        [Test, Category("TP_292744_YOY_comparison")]
        public static void TC_279697()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_279697, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_292744();


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
        //Validate Room Type analysis when comparison year is 3 at hotel Level
        /// </summary>
        [Test, Category("TP_292744_YOY_comparison")]
        public static void TC_279698()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_279698, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_292744();


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
        //Validate Room Type analysis when comparison year is 1 at hotel Level and DOW filter
        /// </summary>
        [Test, Category("TP_292744_YOY_comparison")]
        public static void TC_279699()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_279699, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_292744();


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
