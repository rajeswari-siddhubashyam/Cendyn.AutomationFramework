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
    class HotelOrigami_TP_186887_Admin_MemberLevel : eLoyaltyV3.Utility.Setup
    {
        //public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public HotelOrigami_TP_186887_Admin_MemberLevel(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public HotelOrigami_TP_186887_Admin_MemberLevel()
        { }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_186887;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_186887, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");

            //Assign the test data test plan file location
            //TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_186887;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
            
        }

        /* This test case will Admin updates Crystal to Sapphire */
        [Test, Category("Regression")]
        public static void TC_114355()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_114355, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_186887();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will Admin updates Crystal to Diamond */
        [Test, Category("Regression")]
        public static void TC_114356()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_114356, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_186887();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        //Not Applicable for HotelOrigami
        ///* This test case will Admin downgrade platinum to sapphire */
        //[Test, Category("HotelOrigami TP 186887 Admin Member Level")]
        //public static void TC_114357()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase_POC(Constants.TC_114357);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_186887();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}

        /* This test case will Admin updates Diamond to Crystal */
        [Test, Category("Regression")]
        public static void TC_114358()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_114358, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_186887();

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
