using eLoyaltyV3.AppModule.MainAdminApp;
using NUnit.Framework;
using System;
using Constants = eLoyaltyV3.Utility.Constants;
using TestData;
using BaseUtility.Utility;
using InfoMessageLogger;
using OpenQA.Selenium;
using System.Threading;
using eLoyaltyV3.Utility;

namespace HotelOrigami
{
    class HotelOrigami_TP_240750_LoyaltyRules_Qualifying_Rules : eLoyaltyV3.Utility.Setup
    {
        public HotelOrigami_TP_240750_LoyaltyRules_Qualifying_Rules(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public HotelOrigami_TP_240750_LoyaltyRules_Qualifying_Rules()
        { }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_240750;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_240750, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
            
        }
        /// <summary>
        /// This test case will Validate all fields save correctly.
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_122056()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_122056, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_240750();

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
        /// This test case will Verify Loyalty Rule Log when updated Qualifying Stay Rule
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_209606()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_209606, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_240750();

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
        /// This test case will Validate all fields save correctly.
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_240753()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_240753, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_240750();

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
        /// This test case will Verify Loyalty Rule Log when updated Qualifying Night Rule
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_209605()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_209605, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_240750();

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
