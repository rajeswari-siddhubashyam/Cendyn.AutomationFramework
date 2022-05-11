using eLoyaltyV3.AppModule.MainAdminApp;
using Common;
using TestData.ExcelData;
using eLoyaltyV3.Utility;
using NUnit.Framework;
using System;
using Constants = eLoyaltyV3.Utility.Constants;
using TestData;
using BaseUtility.Utility;
using InfoMessageLogger;
using OpenQA.Selenium;
using System.Threading;

namespace HotelOrigami
{
    class HotelOrigami_TP_111453_LoyaltyRules_PointEarningRule_UpdateRule : eLoyaltyV3.Utility.Setup
    {
        public HotelOrigami_TP_111453_LoyaltyRules_PointEarningRule_UpdateRule(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_113453;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_113453, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
            
        }
        /// <summary>
        /// This test case will Verify Name (Title) should be unique for each Rule
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_113457()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_113457, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_111963();

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
        /// This test case will Verify no two rule should have same priority
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_116140()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_116140, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_111963();

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
        /// This test case will Verify updating any active rule
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_113454()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_113454, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_111963();

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
        /// This test case will Verify updating Future rule (Scheduled rule)
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_116328()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_116328, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_111963();

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
        /// This test case will Verify updating Past rule (Inactive rule)
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_116329()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_116329, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_111963();

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
        /// This test case will Verify Updating active rule with inactive rule Priority
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_219503()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_219503, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_111963();

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
        /// This test case will Verify user is able to edit Priority value of any active/schedule/expired priority rule
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_220672()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_220672, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_111963();

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
