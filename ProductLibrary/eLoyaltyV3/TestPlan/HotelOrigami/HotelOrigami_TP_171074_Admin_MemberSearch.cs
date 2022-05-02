using TestData;
using NUnit.Framework;
using System;
using InfoMessageLogger;
using eLoyaltyV3.AppModule.MainAdminApp;
using BaseUtility.Utility;
using TestData.ExcelData;
using eLoyaltyV3.Utility;
using System.Threading;
using OpenQA.Selenium;

namespace HotelOrigami
{
    class HotelOrigami_TP_171074_Admin_MemberSearch : eLoyaltyV3.Utility.Setup
    {
        //public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public HotelOrigami_TP_171074_Admin_MemberSearch(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_171074;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_171074, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");
            

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_171074;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
            
        }

        /* This test case will Validate the Search Criteria from Member Search for Single value */
        [Test, Category("Regression")]
        public static void TC_221090()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_221090, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_171074();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will Validate the search result filter dropdown*/
       // [Test, Category("Regression")]
        public static void TC_113764()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_113764, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_171074();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }


        /* This test case will Validate the search result for member search icon with no search value */
        [Test, Category("Regression")]
        public static void TC_113756()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_113756, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_171074();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will Validate the Search Criteria from Member Search for MemberType, Status, Country and State*/
        [Test, Category("Regression")]
        public static void TC_221395()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_221395, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_171074();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }


        /* This Test Case Validate the Search Criteria from Member Search for Multiple values */
        [Test, Category("Regression")]
        public static void TC_221385()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_221385, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_171074();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }


        /* This case will Validate the Search Criteria from Member Search for Single value for Address*/
        [Test, Category("Regression")]
        public static void TC_221277()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_221277, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_171074();

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

