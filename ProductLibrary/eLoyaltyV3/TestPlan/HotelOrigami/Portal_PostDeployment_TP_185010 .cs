using BaseUtility.Utility;
using eLoyaltyV3.AppModule.MainAdminApp;
using InfoMessageLogger;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TestData;
using Constants = eLoyaltyV3.Utility.Constants;

namespace HotelOrigami
{
    class Portal_PostDeployment_TP_185010 : eLoyaltyV3.Utility.Setup
    {
        //public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public Portal_PostDeployment_TP_185010(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_185010;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_185010, Enums.ClientName.HotelOrigami_Production, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami_Production");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_121734;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            AddDelay(1500);
        }

        /* This test case will  Click on Reset Password link twice. */
        [Test, Category("Post Deployment")]
        public static void TC_124896()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_124896, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_185010(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will Verify Required field validation for setting page. */
        [Test, Category("Post Deployment")]
        public static void TC_120138()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_120138, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_185010(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will verify verify that when user does not enter any details in required fields and click on submit button then some validation message appears on the screen.. */
        [Test, Category("Post Deployment")]
        public static void TC_254265()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_254265, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_185010(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will Verify required fields on Sign In Page. */
        [Test, Category("Post Deployment")]
        public static void TC_254266()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_254266, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_185010(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will Verify all pages across portal after Login. */
        [Test, Category("Post Deployment")]
        public static void TC_185011()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_185011, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_185010(ProjectName);
                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }

        }
        /* This test case will Verify all pages across portal before Login. */
        [Test, Category("Post Deployment")]
        public static void TC_185012()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_185012, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_185010(ProjectName);

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

