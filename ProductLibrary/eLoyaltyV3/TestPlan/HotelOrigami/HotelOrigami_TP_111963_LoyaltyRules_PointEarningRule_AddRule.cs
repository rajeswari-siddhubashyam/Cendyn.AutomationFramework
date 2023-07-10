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
    class HotelOrigami_TP_111963_LoyaltyRules_PointEarningRule_AddRule : eLoyaltyV3.Utility.Setup
    {
        public HotelOrigami_TP_111963_LoyaltyRules_PointEarningRule_AddRule(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public HotelOrigami_TP_111963_LoyaltyRules_PointEarningRule_AddRule()
        { }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_111963;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_111963, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
            
        }
        /// <summary>
        /// This test case will Verify fields available under Member level Rules tab
        /// </summary>
       
        [Test, Category("Regression")]
        public static void TC_114486()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_114486, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

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
        /// This test case will Verify Name should be unique
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_114488()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_114488, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

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
        /// This test case will Verify No two rule should have same priority
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_114489()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_114489, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

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
        ///   <summary>
        /// This test case will Verify Start Date = End Date & Start Date < End Date & Start date > End Date
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_114490()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_114490, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

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
        /// This test case will Verify add Point earning rule functionality with Channel Code blank
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_224606()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_224606, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

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
        /// This test case will Validate when Calculated On is selected as Stay then Revenue Type field should not act as mandatory field
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_188991()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_188991, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

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
