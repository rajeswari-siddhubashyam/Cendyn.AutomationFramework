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
    class RevIntel_TP_252636_Portaland_Dashboard : RevIntel.Utility.Setup
    {
        //public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public RevIntel_TP_252636_Portaland_Dashboard(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public RevIntel_TP_252636_Portaland_Dashboard() { }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_252636;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_252636, Enums.ClientName.RevIntel, Enums.TestDataType.Controller, Enums.CaseType.NA, "RevIntel");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_121734;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            AddDelay(1500);
        }

        /// <summary>
        /// This test case will Validate Monthly Pickup Report
        /// </summary>
        [Test, Category("RevIntel_TP_252636_Portaland_Dashboard")]
        public static void TC_252648()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252648, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252636();


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
        /// This test case will Dashboard - Validate the Hotel -> Hotel Dashboard
        /// </summary>
        [Test, Category("RevIntel_TP_252636_Portaland_Dashboard")]
        public static void TC_252649()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252649, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252636();


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
        /// This test case will Dashboard - Validate the Business Source -> Agent Dashboard
        /// </summary>
        [Test, Category("RevIntel_TP_252636_Portaland_Dashboard")]
        public static void TC_252650()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252650, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252636();


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
        /// This test case will Dashboard - Validate the Business Source -> Company Dashboard
        /// </summary>
        [Test, Category("RevIntel_TP_252636_Portaland_Dashboard")]
        public static void TC_252651()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252651, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252636();


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
        /// This test case will  Dashboard - Validate the Business Source -> Negotiated Dashboard   
        /// </summary>
        [Test, Category("RevIntel_TP_252636_Portaland_Dashboard")]
        public static void TC_252652()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252652, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252636();


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
        /// This test case will Dashboard - Validate the Market -> Market Dashboard
        /// </summary>
        [Test, Category("RevIntel_TP_252636_Portaland_Dashboard")]
        public static void TC_252653()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252653, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252636();


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
        /// This test case will Dashboard - Validate the Booking Trends -> Pace Dashboard
        /// </summary>
        [Test, Category("RevIntel_TP_252636_Portaland_Dashboard")]
        public static void TC_252654()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252654, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252636();


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
        /// This test case will Dashboard - Validate the Channel -> Channel Dashboard
        /// </summary>
        [Test, Category("RevIntel_TP_252636_Portaland_Dashboard")]
        public static void TC_252655()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252655, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252636();


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
        /// This test case will Dashboard - Validate the Room Type -> Room Type Dashboard
        /// </summary>
        [Test, Category("RevIntel_TP_252636_Portaland_Dashboard")]
        public static void TC_252656()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252656, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252636();


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
