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
    class HotelOrigami_TP_240447_Portal_MembershipCard : eLoyaltyV3.Utility.Setup
    {
        //public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public HotelOrigami_TP_240447_Portal_MembershipCard(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_240447;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_240447, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");



            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            AddDelay(1500);
        }

        [Test, Category("Regression")]
        public static void TC_112899()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_112899, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.Defect);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_240447(ProjectName);

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
        public static void TC_113079()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_113079, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.Defect);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_240447(ProjectName);

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
