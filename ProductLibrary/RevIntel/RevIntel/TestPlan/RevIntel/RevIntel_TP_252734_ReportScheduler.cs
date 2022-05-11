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
    class RevIntel_TP_252734_ReportScheduler : RevIntel.Utility.Setup
    {
        public RevIntel_TP_252734_ReportScheduler(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        /// <summary>
        /// Method is used to initialised the test plan
        /// </summary>
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_252734;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_252734, Enums.ClientName.RevIntel, Enums.TestDataType.Controller, Enums.CaseType.NA, "RevIntel");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_121734;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            AddDelay(1500);
        }


        /// <summary>
        /// This test case will Verify the Relative dates and its offset gets enabled when absolute dates are cleared
        /// </summary>
        [Test, Category("RevIntel_TP_252734_ReportScheduler")]
        public static void TC_265412()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_265412, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252734();

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
        /// This test case will Verify the absolute dates gets enabled when relative dates are cleared
        /// </summary>
        [Test, Category("RevIntel_TP_252734_ReportScheduler")]
        public static void TC_265413()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_265413, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252734();

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
        /// This test case will Verify user should be able to edit the report report in manage schedule
        /// </summary>
        [Test, Category("RevIntel_TP_252734_ReportScheduler")]
        public static void TC_265416()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_265416, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252734();

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
        /// This test case will Verify user should be able to edit the report report in Subscription center
        /// </summary>
        [Test, Category("RevIntel_TP_252734_ReportScheduler")]
        public static void TC_265417()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_265417, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252734();

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
        /// This test case will verify When setting the Static or Relative As of Date > Today's date, an error message should populate when saving a report
        /// </summary>
        [Test, Category("RevIntel_TP_252734_ReportScheduler")]
        public static void TC_265421()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_265421, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252734();

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
        /// This test case will verify When setting the Static or Relative End Date < Start date, an error message should populate when saving a report
        /// </summary>
        [Test, Category("RevIntel_TP_252734_ReportScheduler")]
        public static void TC_265422()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_265422, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252734();

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
        /// This test case will verify user should be able to delete the report in manage schedule
        /// </summary>
        [Test, Category("RevIntel_TP_252734_ReportScheduler")]
        public static void TC_265418()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_265418, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252734();

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
        /// This test case will verify Pace Report gets generated when scheduled Daily with out stop schedule date
        /// </summary>
        [Test, Category("RevIntel_TP_252734_ReportScheduler")]
        public static void TC_265361()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_265361, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252734();

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
        /// This test case will verify Rate Code Pace report generated when scheduled Monthly
        /// </summary>
        [Test, Category("RevIntel_TP_252734_ReportScheduler")]
        public static void TC_265367()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_265367, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252734();

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
        /// This test case will verify Monthly Pickup generated when scheduled Once
        /// </summary>
        [Test, Category("RevIntel_TP_252734_ReportScheduler")]
        public static void TC_265368()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_265368, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252734();

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
        /// This test case will verify Report gets generated when scheduled Daily for timeZone other than EST
        /// </summary>
        [Test, Category("RevIntel_TP_252734_ReportScheduler")]
        public static void TC_265380()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_265380, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252734();

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
        /// This test case will verify Report gets generated when scheduled Daily for timeZone other than EST
        /// </summary>
        [Test, Category("RevIntel_TP_252734_ReportScheduler")]
        public static void TC_265385()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_265385, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252734();

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
        /// This test case will verify the obsolute dates gets disabled when relative dates are entered
        /// </summary>
        [Test, Category("RevIntel_TP_252734_ReportScheduler")]
        public static void TC_265386()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_265386, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252734();

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
        /// This test case will verify when Quick dates are selected for absolute date , relative date and offset gets disabled
        /// </summary>
        [Test, Category("RevIntel_TP_252734_ReportScheduler")]
        public static void TC_265396()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_265396, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252734();

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
        /// This test case will verify when Quick dates are selected for Relative dates , absolute date disabled
        /// </summary>
        [Test, Category("RevIntel_TP_252734_ReportScheduler")]
        public static void TC_265397()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_265397, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252734();

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
        /// This test case will verify the value rendered for Relative - Quick dates
        /// </summary>
        
        public static void TC_282043()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_282043, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252734();

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
        /// This test case will Verify the value rendered for Obsolute - Quick dates
        /// </summary>
        [Test, Category("RevIntel_TP_252734_ReportScheduler")]
        public static void TC_282049()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_282049, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252734();

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
        /// This test case will Verify the value rendered for Obsolute - Quick dates
        /// </summary>
        [Test, Category("RevIntel_TP_252734_ReportScheduler")]
        public static void TC_265430()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_265430, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252734();

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
        /// This test case will Verify Report Delivery Scheduler loads for all available Report types w/o throwing a page error
        /// </summary>
        [Test, Category("RevIntel_TP_252734_ReportScheduler")]
        public static void TC_265431()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_265431, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252734();

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
        /// This test case will Verify Portfolio reports should not have Hotel name selections.
        /// </summary>
        [Test, Category("RevIntel_TP_252734_ReportScheduler")]
        public static void TC_265427()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_265427, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252734();

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
        /// This test case will Verify Report gets generated when scheduled Daily for hotel in timeZone other than EST
        /// </summary>
        [Test, Category("RevIntel_TP_252734_ReportScheduler")]
        public static void TC_265426()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_265426, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252734();

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
        /// This test case will Verify preference set up should reflect as default value in report scheduler
        /// </summary>
        [Test, Category("RevIntel_TP_252734_ReportScheduler")]
        public static void TC_265424()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_265424, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252734();

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
        /// This test case will Verify preference set up should reflect as default value in report scheduler
        /// </summary>
        [Test, Category("RevIntel_TP_252734_ReportScheduler")]
        public static void TC_265415()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_265415, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252734();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        ///// <summary>
        ///// This test case will Verify Schedule report with parameter and compare the report with application
        ///// </summary>
        //[Test, Category("RevIntel_TP_252734_ReportScheduler")]
        //public static void TC_265408()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_265408, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_252734();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
        ///// <summary>
        /// This test case will Verify after choosing 'Portfolio' SelectType, if none are configured, UI indicates w/ message and disables dropdown
        /// </summary>
        [Test, Category("RevIntel_TP_252734_ReportScheduler")]
        public static void TC_265401()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_265401, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252734();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        [Test, Category("RevIntel_TP_252734_ReportScheduler")]
        public static void TC_265398()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_265398, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252734();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        ///// <summary>
        ///// This test case will Verify upon selecting a hotel from list value corresponding report parameter gets populated in list value
        ///// </summary>
        //[Test, Category("RevIntel_TP_252734_ReportScheduler")]
        //public static void TC_265402()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_265402, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_252734();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
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
