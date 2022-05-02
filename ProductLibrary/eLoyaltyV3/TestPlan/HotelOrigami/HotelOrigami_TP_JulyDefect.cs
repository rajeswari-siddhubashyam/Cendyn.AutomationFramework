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
    class HotelOrigami_TP_JulyDefect : eLoyaltyV3.Utility.Setup
    {
        public HotelOrigami_TP_JulyDefect(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_JulyDefect;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_JulyDefect, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");

            //Assign the test data test plan file location
            //TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_121737;
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_JulyDefect;            

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            AddDelay(1500);
        }

      ///  [Test, Category("Hotel Origami July Defect")]
        public static void D_220805()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.D_220805, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.Defect);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_JulyDefect();

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

        public static void D_221118()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.D_221118, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.Defect);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_JulyDefect();

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
        public static void D_221461()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.D_221461, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.Defect);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_JulyDefect();

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
        public static void D_221237()
        {
            try
            {
                SetupTestCase(Constants.D_221237, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.Defect);
                Logger.DeleteOldFolder();
                //start
                MainAdminApp.TP_JulyDefect();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }
        [Test, Category("Regression")]
        //[Test, Category("Defect")]
        public static void D_221661()
        {
            try
            {
                SetupTestCase(Constants.D_221661, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.Defect);
                Logger.DeleteOldFolder();
                //start
                MainAdminApp.TP_JulyDefect();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }
        [Test, Category("Regression")]
        //[Test, Category("Defect")]
        public static void D_221720()
        {
            try
            {
                SetupTestCase(Constants.D_221720, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.Defect);
                Logger.DeleteOldFolder();
                //start
                MainAdminApp.TP_JulyDefect();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }
        [Test, Category("Regression")]
        //[Test, Category("Defect")]

        public static void D_221663()
        {
            try
            {
                SetupTestCase(Constants.D_221663, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.Defect);
                Logger.DeleteOldFolder();
                //start
                MainAdminApp.TP_JulyDefect();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
            }
        }
        [Test, Category("Regression")]
        //[Test, Category("Defect")]
        public static void D_221403()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.D_221403, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.Defect);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_JulyDefect();

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
        public static void D_221120()
        {
            try
            {
                /**Test execution - Start**/

                SetupTestCase(Constants.D_221120, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.Defect);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_JulyDefect();

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
