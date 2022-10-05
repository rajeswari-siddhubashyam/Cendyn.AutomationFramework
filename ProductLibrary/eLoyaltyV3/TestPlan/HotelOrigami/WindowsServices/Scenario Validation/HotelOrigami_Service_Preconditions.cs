using OpenQA.Selenium;
using System;
using System.Threading;
using NUnit.Framework;
using eLoyaltyV3.Utility;
using InfoMessageLogger;
using TestData;
using eLoyaltyV3.AppModule.MainAdminApp;
using BaseUtility.Utility;


namespace eLoyaltyV3.TestPlan.HotelOrigami.WindowsServices.Scenario_Validation
{
    class HotelOrigami_Service_Preconditions : eLoyaltyV3.Utility.Setup
    {
        public HotelOrigami_Service_Preconditions()
        { }
        public HotelOrigami_Service_Preconditions(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_Service_Preconditions;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_Service_Preconditions, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami_DB_Backup");

        }
        // <summary>
        // This test case will Restore DB_Origami_004
        // </summary>
        //[Test, Category("Service Testing"), Order(1)]
        //public static void TC_Restore_DB()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_Restore_DB, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);
        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_Service_Preconditions();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
        //[Test, Category("Service Testing"), Order(60)]
        //public static void TC_Backup_DB()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_Backup_DB, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);
        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_Service_Preconditions();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
    }
}
