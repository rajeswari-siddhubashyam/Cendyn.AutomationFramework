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
    class HotelOrigami_Production_SmokeTest : eLoyaltyV3.Utility.Setup
    {
        public HotelOrigami_Production_SmokeTest(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_ProductionSmokeTest;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_ProductionSmokeTest, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA,  "HotelOrigami");

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
          
        }

        /// <summary>
        /// Verify user should be able to Signin with valid credential and the landing page
        /// </summary>
        [Test, Category("Post Deployment")]
        //[Test, Category("Production Smoke Test")]
        public static void TC_119819()
        {            
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_119819, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.Production_SmokeTestPlan();

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
        /// Verify the Forgot Password Functionality for Registered Email and reset the password - Cancel Functionality
        /// </summary>
        /// 
        [Test, Category("Post Deployment")]
        //[Test, Category("Production Smoke Test")]
        public static void TC_219287()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_219287, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.Production_SmokeTestPlan();

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
        /// Verify the sign out link works in all page
        /// </summary>
        /// 
        [Test, Category("Post Deployment")]
        //[Test, Category("Production Smoke Test")]
        public static void TC_128801()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_128801, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.Production_SmokeTestPlan();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /* This test case will validate guest who has multiple records in PMS source with same name and email. */
        [Test, Category("Post Deployment")]
        //[Test, Category("Production Smoke Test")]
        public static void TC_184988()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_184988, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.Production_SmokeTestPlan();

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
