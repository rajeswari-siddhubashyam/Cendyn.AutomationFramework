using eLoyaltyV3.AppModule.MainAdminApp;
using Common;
using TestData.ExcelData;
using eLoyaltyV3.Utility;
using NUnit.Framework;
using System;
using Constants = eLoyaltyV3.Utility.Constants;
using TestData;
using BaseUtility.Utility;
using OpenQA.Selenium;
using System.Threading;
using InfoMessageLogger;

namespace HotelOrigami
{
    class HotelOrigami_TP_166488_Admin_ManualMerge : eLoyaltyV3.Utility.Setup
    {
        public HotelOrigami_TP_166488_Admin_ManualMerge(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        public HotelOrigami_TP_166488_Admin_ManualMerge()
        { }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_166488;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_166488, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");
            

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_166488;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
            
        }

        /* This test case will  Verify merging when target Profile is Inactive */
        [Test, Category("Regression")]
        public static void TC_161150()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_161150, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_166488(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will Verify profiles of different Member Level */
        [Test, Category("Regression")]
        public static void TC_161135()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_161135, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_166488(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will Verify profiles with different join date gets merged */
        [Test, Category("Regression")]
        public static void TC_161136()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_161136, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_166488(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will Verify profiles which has manual transaction gets merged */
        [Test, Category("Regression")]
        public static void TC_161137()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_161137, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_166488(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will Verify user should be able to merge 2 to 6 profile */
        [Test, Category("Regression")]
        public static void TC_161117()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_161117, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_166488(ProjectName);

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
