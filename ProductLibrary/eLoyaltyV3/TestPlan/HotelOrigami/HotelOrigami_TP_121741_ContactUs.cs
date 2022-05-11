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

namespace HotelOrigami
{
    class HotelOrigami_TP_121741_ContactUs : eLoyaltyV3.Utility.Setup
    {
        //public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public HotelOrigami_TP_121741_ContactUs(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

   
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_121741;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_121741, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_121741;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            AddDelay(1500);
        }

        /* This test case will verify that Name, email id and membership fields are not editable. */
        [Test, Category("Regression")]
        public static void TC_120118()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_120118, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                //Start
                MainAdminApp.TP_121741(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will verify that user enters special characters in Phone number. */
        [Test, Category("Regression")]
        public static void TC_120119()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_120119, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                //Start
                MainAdminApp.TP_121741(ProjectName);

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
        /// This test case will Verify Upload Supporting Documents section is available on both Authenticated & Un- Authenticated version of Contact Us page.
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_216107()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_216107, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                //Start
                MainAdminApp.TP_239393();

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
