using System;
using eLoyaltyV3.AppModule.MainAdminApp;
using NUnit.Framework;
using OpenQA.Selenium;
using BaseUtility.Utility;
using TestData;
using InfoMessageLogger;
using System.Threading;
using Constants = eLoyaltyV3.Utility.Constants;

namespace HotelOrigami
{
    
    public class HotelOrigami_TP_121735_SignUpNonPMSUser : eLoyaltyV3.Utility.Setup
    {
        public HotelOrigami_TP_121735_SignUpNonPMSUser(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public HotelOrigami_TP_121735_SignUpNonPMSUser()
        { }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_121735;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_121735, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_121734;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            AddDelay(1500);
        }

        /* This test case will validate signing up with a valid/invalid email. */
        [Test, Category("Regression")]
        public static void TC_119760()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_119760, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_121735(ProjectName);

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