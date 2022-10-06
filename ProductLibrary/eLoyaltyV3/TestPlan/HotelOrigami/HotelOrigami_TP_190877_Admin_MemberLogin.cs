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
    class HotelOrigami_TP_190877_Admin_MemberLogin : eLoyaltyV3.Utility.Setup
    {
        //public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public HotelOrigami_TP_190877_Admin_MemberLogin(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public HotelOrigami_TP_190877_Admin_MemberLogin()
        { }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_190877;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_190877, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");


            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_190877;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
            
        }

        /* This test case will Verify the Auto login feature for for profile who signed in using social media, Kiosk and Loyalty Sign up */
        [Test, Category("Regression")]
        public static void TC_147736()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_147736, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_190877();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will Verify Admin should be able to access only one profile at a time */
        [Test, Category("Regression")]
        public static void TC_147743()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_147743, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_190877();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will Verify admin should not be able to auto login to guest portal for profile who didn't activate their account */
        [Test, Category("Regression")]
        public static void TC_147747()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_147747, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_190877();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will  Verify admin should be able to auto login to guest portal for a PMS profile*/
        [Test, Category("Regression")]
        public static void TC_147748()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_147748, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_190877();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will Verify admin should be able to auto login to guest portal for Inactive and Deactivate profile*/
        [Test, Category("Regression")]
        public static void TC_147758()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_147758, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_190877();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will Verify admin should be able to auto login to guest portal for all member level*/
        [Test, Category("Regression")]
        public static void TC_147759()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_147759, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_190877();

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
