using System;
using eLoyaltyV3.AppModule.MainAdminApp;
using NUnit.Framework;
using OpenQA.Selenium;
using BaseUtility.Utility;
using TestData;
using InfoMessageLogger;
using System.Threading;
using Constants = eLoyaltyV3.Utility.Constants;

namespace HotelOrigami
{
    class HotelOrigami_TP_121734_SignUpPMSUser : eLoyaltyV3.Utility.Setup
    {
        //public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public HotelOrigami_TP_121734_SignUpPMSUser(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public HotelOrigami_TP_121734_SignUpPMSUser()
        { }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_121734;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_121734, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_121734;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);            
            AddDelay(1500);
        }

        /* This test case will validate signing up for a new account with a guest with a "Reserved" stay. */
        [Test, Category("Regression")]
        public static void TC_119748()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_119748, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_121734(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will validate signing up for a new account with a guest with a "In-house" stay. */
        [Test, Category("Regression")]
        public static void TC_119749()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_119749, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_121734(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will validate signing up for a new account with a guest with a "Cancelled" stay. */
        [Test, Category("Regression")]
        public static void TC_119750()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_119750, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_121734(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will validate signing up for a new account with a guest with a "No Showed" stay. */
        [Test, Category("Regression")]
        public static void TC_119751()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_119751, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_121734(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will validate guest who has multiple records in PMS source with same name and email. */
        [Test, Category("Regression")]
        public static void TC_119752()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_119752, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_121734(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will validate guest who has multiple records in PMS source with different name and same email. */
        [Test, Category("Regression")]
        public static void TC_119753()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_119753, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_121734(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will validate guest sign up using different name but matching email in crm. */
        [Test, Category("Regression")]
        public static void TC_119754()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_119754, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_121734(ProjectName);

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
