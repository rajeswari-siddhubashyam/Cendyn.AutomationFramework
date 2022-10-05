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
    class HotelOrigami_TP_109659_Admin_Update_Offers : eLoyaltyV3.Utility.Setup
    {
        public HotelOrigami_TP_109659_Admin_Update_Offers()
        { }
        public HotelOrigami_TP_109659_Admin_Update_Offers(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_109659;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_109659, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");


            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_190877;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
            
        }

        /// <summary>
        /// This test case will Verify required field functionality for Update Offers
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_109696()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_109696, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_109659();

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
        /// This test case will Verify Max Character Limit
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_109697()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_109697, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_109659();

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
        /// This test case will Verify Asci code validation
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_109698()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_109698, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_109659();

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
        /// This test case will Verify Successful update of Offer with only mandatory fields
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_109699()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_109699, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_109659();

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
        /// This test case will Verify Successful update of Offer with only mandatory fields
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_109700()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_109700, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_109659();

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
        /// This test case will Verify Cancel button functionality while updating an offer
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_109701()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_109701, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_109659();

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
        /// This test case will Verify filter functionality
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_109665()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_109665, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_109659();

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
        /// This test case will Verify Pagination functionality
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_109666()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_109666, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_109659();

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
