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
    class Admin_PostDeployment_TP_189000 : eLoyaltyV3.Utility.Setup
    {
        //public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public Admin_PostDeployment_TP_189000(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_189000;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_189000, Enums.ClientName.HotelOrigami_Production, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami_Production");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_121734;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
            AddDelay(1500);
        }

        /* This test case will Verify admin is able to update the member level. */
        [Test, Category("Post Deployment")]
        public static void TC_189002()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_189002, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_189000(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will Verify admin is able to update the member status. */
        [Test, Category("Post Deployment")]
        public static void TC_189003()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_189003, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_189000(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will Verify admin is able to send Activation,Welcome and password Recovery email. */
        [Test, Category("Post Deployment")]
        public static void TC_189006()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_189006, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_189000(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will Verify navigation to all Admin modules/tabs */
        [Test, Category("Post Deployment")]
        public static void TC_194749()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_194749, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_189000(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will Validate the Search Criteria from Member Search for Multiple values. */
        [Test, Category("Post Deployment")]
        public static void TC_221385()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_221385, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_189000(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /* This test case will Verify the Member Login Reset function. */
        [Test, Category("Post Deployment")]
        public static void TC_115262()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_115262, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_189000(ProjectName);

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

