using TestData;
using NUnit.Framework;
using System;
using InfoMessageLogger;
using eLoyaltyV3.AppModule.MainAdminApp;
using BaseUtility.Utility;
using TestData.ExcelData;
using OpenQA.Selenium;
using System.Threading;
using eLoyaltyV3.Utility;

namespace HotelOrigami
{
    class HotelOrigami_TP_121746_SignIn : eLoyaltyV3.Utility.Setup
    {
        public HotelOrigami_TP_121746_SignIn(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            //Initialize the test case set up.
            InitializeSetup(Constants.TP_121746, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA,  "HotelOrigami");

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
          //  Drivers.Value.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
        }


        /* This test case will verify added a custom date field on a form. */
        [Test, Category("Regression")]
        public static void TC_119819()
        {            
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_119819, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_121746();

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
        public static void TC_119820()
        {
            string ReturnResult = Constants.ValidationMessageIncorrectCredentials;

            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_119820, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_121746();

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
        public static void TC_119821()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_119821, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_121746();

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
        public static void TC_119822()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_119822, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_121746();

                TestHandling.TestEnd();

            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Regression")]
        public static void TC_119823()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_119823, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_121746();

                TestHandling.TestEnd();

            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Regression")]
        public static void TC_153344()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_153344, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_121746();

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
