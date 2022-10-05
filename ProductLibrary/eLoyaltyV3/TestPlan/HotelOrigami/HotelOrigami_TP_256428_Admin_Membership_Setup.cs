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
    class HotelOrigami_TP_256428_Admin_Membership_Setup : eLoyaltyV3.Utility.Setup
    {
        //public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public HotelOrigami_TP_256428_Admin_Membership_Setup(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public HotelOrigami_TP_256428_Admin_Membership_Setup()
        { }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_256428;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_256428, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");


            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_190877;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
            
        }

        /// <summary>
        /// This test case will Verify adding 'Membership level' without required field
        /// </summary>
        
        [Test, Category("Regression")]
        public static void TC_255553()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_255553, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_256428();

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
        /// This test case will Verify adding 'Membership level' with only required field
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_255554()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_255554, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_256428();

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
        /// This test case will Verify adding 'Membership level' with all fields & cancel button functionality
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_255556()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_255556, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_256428();

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
        /// This test case will Verify deleting 'Membership level' which is not allocated to any member
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_255563()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_255563, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_256428();

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
        /// This test case will Validate fields on add/edit membership level.
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_255557()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_255557, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_256428();

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
        /// This test case will Verify add/edit membership level with duplicate data. 
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_255559()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_255559, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_256428();

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
        /// This test case will Verify deleting 'Member Level Rules'
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_255578()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_255578, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_256428();

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
        /// This test case will Verify adding 'Member Level Rules' with only required fields
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_255574()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_255574, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_256428();

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
        /// This test case will Verify adding 'Member Level Rules' with all fields & cancel button functionality
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_255573()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_255573, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_256428();

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
        /// This test case will Verify adding 'Member Level Rules' without required field
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_255572()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_255572, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_256428();

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
        /// This test case will Validate fields on add/edit membership level rule.
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_255575()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_255575, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_256428();

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
        /// This test case will Verify added Membership levels throughout admin & portal. 
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_255561()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_255561, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_256428();

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
        /// This test case will Verify editing 'Membership level'. 
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_255562()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_255562, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_256428();

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
        /// This test case will Verify deleting 'Membership level' which is allocated to member. 
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_255564()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_255564, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_256428();

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
        /// This test case will Verify creating duplicate 'Member Level Rules'. 
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_255576()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_255576, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_256428();

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
        /// This test case will Verify editing 'Member Level Rules'. 
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_255577()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_255577, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_256428();

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
