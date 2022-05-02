
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
    class HotelOrigami_TP_268973_LoyaltyRules_MemberLevelRule : eLoyaltyV3.Utility.Setup
    {
        public HotelOrigami_TP_268973_LoyaltyRules_MemberLevelRule(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_268973;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_268973, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
            
        }
        /// <summary>
        /// This test case will Verify fields available under Member level Rules tab
        /// </summary>
       
      //  [Test, Category("HotelOrigami  TP_268973 Admin LoyaltyRule/Member Level Rule")]
        public static void TC_217871()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_217871, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_268973();

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
        /// This test case will Verify Cancel functionality for Add member level rule
        /// </summary>

      //  [Test, Category("HotelOrigami  TP_268973 Admin LoyaltyRule/Member Level Rule")]
        public static void TC_217877()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_217877, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_268973();

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
        /// This test case will Verify Edit functionality for Member Level Rule
        /// </summary>

     //   [Test, Category("HotelOrigami  TP_268973 Admin LoyaltyRule/Member Level Rule")]
        public static void TC_217878()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_217878, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_268973();

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
        /// This test case will Verify fields available under Member level Rules tab
        /// </summary>

     //   [Test, Category("HotelOrigami  TP_268973 Admin LoyaltyRule/Member Level Rule")]
        public static void TC_217879()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_217879, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_268973();

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
        /// This test case will Verify fields available under Member level Rules tab
        /// </summary>

      //  [Test, Category("HotelOrigami  TP_268973 Admin LoyaltyRule/Member Level Rule")]
        public static void TC_218238()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_218238, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_268973();

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
        /// This test case will Verify Save functionality for Add member level rule
        /// </summary>

      //  [Test, Category("HotelOrigami  TP_268973 Admin LoyaltyRule/Member Level Rule")]
        public static void TC_217874()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_217874, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_268973();

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
