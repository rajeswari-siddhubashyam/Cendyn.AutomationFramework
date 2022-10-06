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
    class HotelOrigami_TP_218533_FrontEnd_SmokeEndToEnd : eLoyaltyV3.Utility.Setup
    {
        //public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public HotelOrigami_TP_218533_FrontEnd_SmokeEndToEnd(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public HotelOrigami_TP_218533_FrontEnd_SmokeEndToEnd()
        { }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_218533;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_218533, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_218533;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            AddDelay(1500);
        }

        /* This test case will Verify the Sign In Functionality for Front End */
        [Test, Category("Smoke")]
        public static void TC_218547()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_218547, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_218533(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will Verify MySetting functionality for Front End */
        [Test, Category("Smoke")]
        public static void TC_218535()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_218535, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_218533(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* Verfify the content on Contacts Us Page */
        [Test, Category("Smoke")]
        public static void TC_218540()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_218540, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_218533(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* Verify forgot password functionality for FrontEnd */
        [Test, Category("Smoke")]
        public static void TC_218534()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_218534, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_218533(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* Verify all pages across portal after Login */
        [Test, Category("Smoke")]
        public static void TC_185011()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_185011, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_218533(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* Verify all pages across portal before Login */
        [Test, Category("Smoke")]
        public static void TC_185012()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_185012, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_218533(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        
        [Test, Category("Smoke")]
        public static void TC_223757()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_223757, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_218533(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Smoke")]
        public static void TC_217847()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_217847, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_218533(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        // Test Case to Verify the validation messages on Sign Up page
        [Test, Category("Smoke")]
        public static void TC_109958()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_109958, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_218533(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        // Test Case to Verify the validation messages on Sign Up page when user tries Signup using invalid password
        [Test, Category("Smoke")]
        public static void TC_119763()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_119763, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_218533(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        // Test Case to Verify the validation messages for Invailid Email id on Sign Up page
        [Test, Category("Smoke")]
        public static void TC_109959()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_109959, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_218533(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        // Test Case to Verify Sign up with member having age < 18 years
        [Test, Category("Smoke")]
        public static void TC_113317()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_113317, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_218533(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        // Test Case to Verify Sign up using all valid email format
        /*Moved to file 121735*/
        //[Test, Category("Smoke")]
        //public static void TC_119760()
        //{
        //    try
        //    {

        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_119760, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_218533(ProjectName);

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}

        // Test Case To verify that when user does not enter details in mandatory fiields and click on SEND MY INVITATION button then system displays validation message
        [Test, Category("Smoke")]
        public static void TC_112091()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_112091, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_218533(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        // To verify that user is not able to send invitation without verifying captcha
        [Test, Category("Smoke")]
        public static void TC_112093()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_112093, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_218533(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /* This test case To verify that when user does not enter any details in required fields and click on submit button then some validation message appears on the screen - [Origami] */
        [Test, Category("Smoke")]
        public static void TC_112269()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_112269, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                //Start
                MainAdminApp.TP_218533(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case To verify that when user clicks on subject field drop down then drop down displays list of option and user is able to select values from drop down list. */
        [Test, Category("Smoke")]
        public static void TC_112270()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_112270, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_218533(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case To verify that system shows validation message when user enters special characters in text fields - [Origami]. */
        [Test, Category("Smoke")]
        public static void TC_112275()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_112275, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_218533(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /* This test case To verify that when user enter invalid email address and click on SEND MY INVITATION button then system should display validation message.. */
        [Test, Category("Smoke")]
        public static void TC_112423()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_112423, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_218533(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        
        /* This test case To verify the character limit of the text fields. */
        [Test, Category("Smoke")]
        public static void TC_112426()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_112426, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                //Start
                MainAdminApp.TP_218533(ProjectName);

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
        /// This test case will Verify when deactivated account tries to login
        /// </summary>

        [Test, Category("Smoke")]
        public static void TC_223768()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_223768, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_218533(ProjectName);

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
        /// This test case will Verify when deactivated account tries to login
        /// </summary>

        [Test, Category("Smoke")]
        public static void TC_223767()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_223767, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_218533(ProjectName);

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
        /// This test case will Verify when member failed to login before reaching the max number of retry and closed the portal page
        /// </summary>

        [Test, Category("Smoke")]
        public static void TC_223762()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_223762, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_218533(ProjectName);

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
        /// This test case will Verify When reset password emails get triggered via automation and manual
        /// </summary>

        [Test, Category("Smoke")]
        public static void TC_223760()
        {
            try
            {

                /**Test execution - Start**/
                SetupTestCase(Constants.TC_223760, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_218533(ProjectName);

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
