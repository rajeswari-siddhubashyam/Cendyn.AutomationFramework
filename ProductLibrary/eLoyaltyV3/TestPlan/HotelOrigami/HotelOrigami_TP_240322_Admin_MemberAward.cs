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
    class HotelOrigami_TP_240322_Admin_MemberAward : eLoyaltyV3.Utility.Setup
    {
        
        public HotelOrigami_TP_240322_Admin_MemberAward(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public HotelOrigami_TP_240322_Admin_MemberAward()
        { }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_240322;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_240322, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");

            
            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
            
        }
        /// <summary>
        /// Test Case to Verify My Award - Sent via email status (Admin status) award should get displayed in front end.
        /// </summary>
        [Test, Category("Regression")]
        public static void TC_116979()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_116979, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_240322();

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
        /// Test Case to Verify My Award - Redeemed status (Admin status) award should get displayed in front end.
        /// </summary>
        [Test, Category("Regression")]
        public static void TC_116403()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_116403, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_240322();

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
        /// Test Case to Verify My Award - Resend via email status (Admin status) award should get displayed in front end.
        /// </summary>
        [Test, Category("Regression")]
        public static void TC_116980()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_116980, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_240322();

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
        /// Verify My Award - Ordered status (Admin status) should not get displayed in front end.
        /// </summary>
        [Test, Category("Regression")]
        public static void TC_116978()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_116978, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_240322();

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
        /// Verify My Award - Expired status (Admin status) award should get displayed in front end.
        /// </summary>
        [Test, Category("Regression")]
        public static void TC_116401()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_116401, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_240322();

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
        /// Verify My Award - Issued status (Admin status) award should not get displayed in front end.
        /// </summary>
        [Test, Category("Regression")]
        public static void TC_116402()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_116402, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_240322();

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
        /// Verify My Award - Cancelled status (Admin status) award should get displayed in front end.
        /// </summary>
        [Test, Category("Regression")]
        public static void TC_116404()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_116404, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_240322();

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
        /// Verify My Award - Cancelled status (Admin status) award should get displayed in front end.
        /// </summary>
        [Test, Category("Regression")]
        public static void TC_264758()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_264758, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_240322();

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
        /// My Award Page Verification.
        /// </summary>
        [Test, Category("Regression")]
        public static void TC_130237()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_130237, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_240322();

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
