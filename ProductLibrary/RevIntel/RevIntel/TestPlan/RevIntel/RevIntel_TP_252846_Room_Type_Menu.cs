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
    class RevIntel_TP_252846_Room_Type_Menu : RevIntel.Utility.Setup
    {
        //public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public RevIntel_TP_252846_Room_Type_Menu(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public RevIntel_TP_252846_Room_Type_Menu() { }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_252846;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_252846, Enums.ClientName.RevIntel, Enums.TestDataType.Controller, Enums.CaseType.NA, "RevIntel");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_121734;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            AddDelay(1500);
        }

        /// <summary>
        /// This test case will  Validate the Room type Analysis
        /// </summary>
        [Test, Category("RevInte_TP_252846_Room_Type_Menu")]
        public static void TC_252847()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252847, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252846();


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
        /// This test case will  Validate the Room Type and Up Grade Statistics
        /// </summary>
        [Test, Category("RevInte_TP_252846_Room_Type_Menu")]
        public static void TC_252848()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252848, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252846();


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
        /// This test case will  Validate the Booked Room Materialization
        /// </summary>
        [Test, Category("RevIntel_TP_252840_Geo_Source")]
        public static void TC_252849()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252849, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252846();


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
        /// This test case will  Validate the Detailed Room Type Availability
        /// </summary>
        [Test, Category("RevIntel_TP_252840_Geo_Source")]
        public static void TC_252850()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252850, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252846();


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

