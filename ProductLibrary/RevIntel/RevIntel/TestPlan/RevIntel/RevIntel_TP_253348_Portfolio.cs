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
    class RevIntel_TP_253348_Portfolio : RevIntel.Utility.Setup
    {
        //public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public RevIntel_TP_253348_Portfolio(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_253348;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_253348, Enums.ClientName.RevIntel, Enums.TestDataType.Controller, Enums.CaseType.NA, "RevIntel");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_121734;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            AddDelay(1500);
        }

        /// <summary>
        /// This test case will  Validate the Portfolio Report
        /// </summary>
        [Test, Category("RevIntel_TP_TP_253348_Portfolio")]
        public static void TC_253349()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_253349, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_253348();


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
        /// This test case will  Validate the Agent By Hotel
        /// </summary>
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_253350()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_253350, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_253348();


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
        /// This test case will  Validate the channel By Hotel
        /// </summary>
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_253351()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_253351, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_253348();


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
        /// This test case will  Validate the Company By Hotel
        /// </summary>
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_253352()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_253352, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_253348();


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
        /// This test case will  Validate the Market By Hotel Report
        /// </summary>
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_253353()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_253353, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_253348();


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
        /// This test case will  Validate the Province and State By Hotel
        /// </summary>
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_253354()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_253354, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_253348();


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
        /// This test case will  Validate the Room Type by Hotel
        /// </summary>
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_253355()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_253355, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_253348();


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
        /// This test case will Validate the Source Market By Hotel
        /// </summary>
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_253356()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_253356, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_253348();


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
