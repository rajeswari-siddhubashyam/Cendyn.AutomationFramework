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
    class HotelOrigami_TP_ProductionDefect : eLoyaltyV3.Utility.Setup
    {
        //public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public HotelOrigami_TP_ProductionDefect(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_ProductionDefect;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_ProductionDefect, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");



            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            AddDelay(1500);
        }

        [Test, Category("Regression")]
        //[Test, Category("Defect")]
        public static void D_222631()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.D_222631, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.Defect);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_ProductionDefect();

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
        //[Test, Category("Defect")]
        public static void D_222706()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.D_222706, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.Defect);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_ProductionDefect();

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
        //[Test, Category("Defect")]
        public static void D_222707()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.D_222707, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.Defect);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_ProductionDefect();

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
