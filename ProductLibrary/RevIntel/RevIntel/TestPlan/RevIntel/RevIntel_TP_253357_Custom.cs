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
    class RevIntel_TP_253357_Custom : RevIntel.Utility.Setup
    {
        //public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public RevIntel_TP_253357_Custom(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_253357;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_253357, Enums.ClientName.RevIntel, Enums.TestDataType.Controller, Enums.CaseType.NA, "RevIntel");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_121734;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            AddDelay(1500);
        }

        /// <summary>
        /// This test case will   Validate the OTB Comparison By Segment (Kerzner)
        /// </summary>
        [Test, Category("RevIntel_TP_253357_Custom")]
        public static void TC_253358()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_253358, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_253357();


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
        /// This test case will Validate the Daily Pickup (Kerzner)
        /// </summary>
        [Test, Category("RevIntel_TP_253357_Custom")]
        public static void TC_253359()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_253359, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_253357();


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
        /// This test case will   Validate the Revenue by Room Product
        /// </summary>
        [Test, Category("RevIntel_TP_253357_Custom")]
        public static void TC_253360()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_253360, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_253357();


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
        /// This test case will  Validate the Pickup by Market Segment
        /// </summary>
        [Test, Category("RevIntel_TP_253357_Custom")]
        public static void TC_253361()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_253361, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_253357();


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
        /// This test case will  Validate the OTB Comparison for All Segments
        /// </summary>
        [Test, Category("RevIntel_TP_253357_Custom")]
        public static void TC_253362()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_253362, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_253357();


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
        /// This test case will  Validate the OTB vs Budget by Segment
        /// </summary>
        [Test, Category("RevIntel_TP_253357_Custom")]
        public static void TC_253363()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_253363, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_253357();


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
        /// This test case will  Validate the OTB vs Forecast by Segment
        /// </summary>
        [Test, Category("RevIntel_TP_253357_Custom")]
        public static void TC_253364()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_253364, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_253357();


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
        /// This test case will  Validate the Room Type Booked Vs Occupied
        /// </summary>
        [Test, Category("RevIntel_TP_253357_Custom")]
        public static void TC_280393()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_280393, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_253357();


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
        /// This test case will Validate Room type booked VS occupied (Kerzner)
        /// </summary>
        [Test, Category("RevIntel_TP_253357_Custom")]
        public static void TC_265676()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_265676, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_253357();


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
