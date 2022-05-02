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
    class HotelOrigami_TP_186921_Admin_SearchStay : eLoyaltyV3.Utility.Setup
    {
        //public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public HotelOrigami_TP_186921_Admin_SearchStay(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_186921;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_186921, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");


            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_186921;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
            
        }
                
        [Test, Category("Regression")]
        public static void TC_221383()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_221383, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_186921();

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
        public static void TC_146642()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_146642, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_186921();

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
        public static void TC_221400()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_221400, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_186921();

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
        public static void TC_221412()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_221412, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_186921();

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
        public static void TC_147010()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_147010, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_186921();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        //Below test cases are removed from regression as those needs Service intervention

        //[Test, Category("Regression")]
        //public static void TC_147013()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_147013, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_186921();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}    

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
