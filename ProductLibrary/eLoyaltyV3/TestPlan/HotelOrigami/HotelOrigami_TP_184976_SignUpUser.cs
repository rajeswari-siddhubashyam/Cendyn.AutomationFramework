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
    class HotelOrigami_TP_184976_SignUpUser : eLoyaltyV3.Utility.Setup
    {
        //public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public HotelOrigami_TP_184976_SignUpUser(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public HotelOrigami_TP_184976_SignUpUser()
        { }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_184976;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_184976, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_184976;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);            
            AddDelay(1500);
        }

        /* This test case will validate signing up for a new account with a guest with a "Reserved" stay. */
        [Test, Category("Regression")]
        public static void TC_184988()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_184988, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_184976();

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
