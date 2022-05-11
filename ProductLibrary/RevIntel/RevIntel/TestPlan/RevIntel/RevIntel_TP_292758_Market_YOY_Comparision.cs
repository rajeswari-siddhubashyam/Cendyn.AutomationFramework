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
    class RevIntel_TP_292758_Market_YOY_Comparision : RevIntel.Utility.Setup
    {
        public RevIntel_TP_292758_Market_YOY_Comparision(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        /// <summary>
        /// Method is used to initialised the test plan
        /// </summary>
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_292758;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_292758, Enums.ClientName.RevIntel, Enums.TestDataType.Controller, Enums.CaseType.NA, "RevIntel");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_121734;

            //Navigate to the URL
            Driver.Navigate().GoToUrl("https://devrhbi.revintel.co/");
            AddDelay(1500);
        }


        /// <summary>
         //Validate the Market->Market Report when comparison year is 1 at hotel Level
        /// </summary>
        [Test, Category("TP_292758_Market_YOY_Comparision")]
        public static void TC_269887()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_269887, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_292758();

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
        //Validate the Market->Market Report when comparison year is 2 at hotel Level
        /// </summary>
        [Test, Category("TP_292758_Market_YOY_Comparision")]
        public static void TC_269888()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_269888, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_292758();


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
        //Validate the Market->Market Report when comparison year is 3 at hotel Level
        /// </summary>
        [Test, Category("TP_292758_Market_YOY_Comparision")]
        public static void TC_269889()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_269889, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_292758();


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
        //Validate the Market->Market Report when comparison year is 1 at hotel Level and DOW filter
        /// </summary>
        [Test, Category("TP_292758_Market_YOY_Comparision")]
        public static void TC_269890()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_269890, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_292758();


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
        //Validate the Market->Market Report when comparison year is 1 at portfolio level and a filter
        /// </summary>
        [Test, Category("TP_292758_Market_YOY_Comparision")]
        public static void TC_269891()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_269891, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_292758();


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
        // Validate the Market->Market Report Current year data
        /// </summary>
        [Test, Category("TP_292758_Market_YOY_Comparision")]
        public static void TC_269892()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_269892, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_292758();


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
