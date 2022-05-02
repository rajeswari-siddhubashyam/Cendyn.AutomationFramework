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
    class RevIntel_TP_252770_Market_Menu : RevIntel.Utility.Setup
    {
        //public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public RevIntel_TP_252770_Market_Menu(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_252770;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_252770, Enums.ClientName.RevIntel, Enums.TestDataType.Controller, Enums.CaseType.NA, "RevIntel");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_121734;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            AddDelay(1500);
        }

        /// <summary>
        /// This test case will  Validate the Market-> Market Report
        /// </summary>
        [Test, Category("RevIntel_TP_266462_ChangePassword")]
        public static void TC_252810()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252810, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252770();


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
        /// This test case will Validate the Market-> Market Performance
        /// </summary>
        [Test, Category("RevIntel_TP_266462_ChangePassword")]
        public static void TC_252811()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252811, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252770();


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
        /// This test case will  Validate the Market-> Market Trend Report
        /// </summary>
        [Test, Category("RevIntel_TP_266462_ChangePassword")]
        public static void TC_252812()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252812, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252770();


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
        /// This test case will Validate the Market-> Market Segment by Day
        /// </summary>
        [Test, Category("RevIntel_TP_266462_ChangePassword")]
        public static void TC_252813()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252813, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252770();


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
        /// This test case will Validate the Market-> Market Segment by Day Summary
        /// </summary>
        [Test, Category("RevIntel_TP_266462_ChangePassword")]
        public static void TC_252814()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252814, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252770();


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
        /// This test case will Validate the Market-> Annual Market Analysis by Month
        /// </summary>
        [Test, Category("RevIntel_TP_252770_Market_Menu")]
        public static void TC_252815()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252815, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252770();


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
        /// This test case will Validate the Market-> Rate Code Analysis
        /// </summary>
        [Test, Category("RevIntel_TP_252770_Market_Menu")]
        public static void TC_252816()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252816, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252770();


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
        /// This test case will Validate the Market-> Market Analysis by Year
        /// </summary>
        [Test, Category("RevIntel_TP_252770_Market_Menu")]
        public static void TC_252817()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252817, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252770();


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
        /// This test case will Validate the Market-> Monthly Market Segment Report
        /// </summary>
        [Test, Category("RevIntel_TP_252770_Market_Menu")]
        public static void TC_252818()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252818, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252770();


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
        /// This test case will Validate the Market-> Rate Code Trend Report (RHBI)
        /// </summary>
        [Test, Category("RevIntel_TP_252770_Market_Menu")]
        public static void TC_252819()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252819, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252770();


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
