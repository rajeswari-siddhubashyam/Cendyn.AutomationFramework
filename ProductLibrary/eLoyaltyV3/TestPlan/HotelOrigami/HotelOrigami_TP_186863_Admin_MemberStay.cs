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
    class HotelOrigami_TP_186863_Admin_MemberStay : eLoyaltyV3.Utility.Setup
    {
        //public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public HotelOrigami_TP_186863_Admin_MemberStay(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_186863;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_186863, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_186851;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
            
        }

        /* This test case will Validate correct information displays on Member Transaction page */
        [Test, Category("Regression")]
        public static void TC_124508()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_124508, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_186863();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will Validate Pagination */
     //   [Test, Category("HotelOrigami TP 186848 Admin Member Transaction")]
        public static void TC_124511()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_124511, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_186863();

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
