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
using eLoyaltyV3.AppModule.UI;

namespace HotelOrigami
{
    class HotelOrigami_TP_109658_Admin_Offers : eLoyaltyV3.Utility.Setup
    {
        public HotelOrigami_TP_109658_Admin_Offers(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_109658;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_109658, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");


            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_190877;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
            
        }

        /// <summary>
        /// This test case will Verify user is able to add duplicate Promo code across Offer
        /// </summary>
        ///

        [Test, Category("Regression")]
        public static void TC_110850()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_110850, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_267462();

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
