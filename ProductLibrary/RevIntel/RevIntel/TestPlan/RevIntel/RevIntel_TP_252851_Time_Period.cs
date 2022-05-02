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
    class RevIntel_TP_252851_Time_Period : RevIntel.Utility.Setup
    {
        //public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public RevIntel_TP_252851_Time_Period(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_252851;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_252851, Enums.ClientName.RevIntel, Enums.TestDataType.Controller, Enums.CaseType.NA, "RevIntel");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_121734;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            AddDelay(1500);
        }

        /// <summary>
        /// This test case will  Validate the Annual Trends Analysis
        /// </summary>
        [Test, Category("RevIntel_TP_252851_Time_Period")]
        public static void TC_252852()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252852, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252851();


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
        /// This test case will Validate the Daily Analysis
        /// </summary>
        [Test, Category("RevIntel_TP_252851_Time_Period")]
        public static void TC_252853()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252853, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252851();


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
        /// This test case will  Validate the Day of Week Statistics
        /// </summary>
        [Test, Category("RevIntel_TP_252851_Time_Period")]
        public static void TC_252854()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252854, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252851();


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
        /// This test case will  Validate the Day of Week Analysis
        /// </summary>
        [Test, Category("RevIntel_TP_252851_Time_Period")]
        public static void TC_252855()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252855, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252851();


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
        /// This test case will  Validate the Monthly Summary (RHBI)
        /// </summary>
        [Test, Category("RevIntel_TP_252851_Time_Period")]
        public static void TC_252856()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252856, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252851();


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
        /// This test case will  Validate the Daily Analysis with Sleeper Data
        /// </summary>
        [Test, Category("RevIntel_TP_252851_Time_Period")]
        public static void TC_252857()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252857, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252851();


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
