using eLoyaltyV3.AppModule.MainAdminApp;
using Common;
using TestData.ExcelData;
using eLoyaltyV3.Utility;
using NUnit.Framework;
using System;
using OpenQA.Selenium;
using BaseUtility.Utility;
using Constants = eLoyaltyV3.Utility.Constants;
using TestData;
using InfoMessageLogger;
using System.Threading;

namespace HotelOrigami
{
    class HotelOrigami_TP_121737_ForgotPassword : eLoyaltyV3.Utility.Setup
    {
        //public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public HotelOrigami_TP_121737_ForgotPassword(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public HotelOrigami_TP_121737_ForgotPassword() { }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_121737;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_121737, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_121737;
            //TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_121737_Excel;            

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            AddDelay(1500);
        }
        
        [Test, Category("Regression")]
        public static void TC_124896()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_124896, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_121737();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Regression")]
        public static void TC_219285()
        {
            try
            {               

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_219285, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_121737();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Regression")]
        public static void TC_219287()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_219287, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_121737();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Regression")]
        public static void TC_219288()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_219288, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_121737();

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
