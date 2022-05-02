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
    class HotelOrigami_TP_186848_Admin_MemberTransaction : eLoyaltyV3.Utility.Setup
    {
        //public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public HotelOrigami_TP_186848_Admin_MemberTransaction(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_186848;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_186848, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");


            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_186848;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
            
        }
               
        [Test, Category("Regression")]
        public static void TC_124365()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_124365, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_186848();

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
        public static void TC_124380()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_124380, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_186848();

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
        public static void TC_124383()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_124383, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_186848();

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
        public static void TC_220655()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_220655, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_186848();

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
        public static void TC_220919()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_220919, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_186848();

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
        public static void TC_220954()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_220954, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_186848();

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
