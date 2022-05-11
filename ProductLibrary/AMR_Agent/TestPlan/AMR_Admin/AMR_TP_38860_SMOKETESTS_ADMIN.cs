using AMR_Agent.AppModule.MainAdminApp;
using AMR_Agent.Utility;
using BaseUtility.Utility;
using InfoMessageLogger;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TestData;

namespace AMR_Agent.TestPlans
{
    //[TestFixture]
    class AMR_TP_38860_SMOKETESTS_ADMIN : AMR_Agent.Utility.Setup
    {
        public AMR_TP_38860_SMOKETESTS_ADMIN(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        /*
         * Method that is executed before every test.
         */
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_38860;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_38860, Enums.ClientName.AMR_Agent, Enums.TestDataType.Controller, Enums.CaseType.NA, "AMR_Agent");

            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL); //Constants.Common_AdminURL
            HandleUnSafeWindows();
            AddDelay(1500);
        }

        /*
         * To Verify the Update Agent Name in Admin Dashboard
         */
        [Test, Category("AMR TP 38860 Smoke Tests Admin")]
        public static void TC_37501()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_37501, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_38860();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*
         * To Admin Dashboard_To Verify Password reset to Amr$1234
         */
        [Test, Category("AMR TP 38860 Smoke Tests Admin")]
        public static void TC_37502()
        {
            try
            {
                /**Test execution - Start**/
                
                SetupTestCase(Constants.TC_37502, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);
                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_38860();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*
         * To Admin Dashboard_To Verify Password reset to Resorts6 or user defined
        */
        [Test, Category("AMR TP 38860 Smoke Tests Admin")]
        public static void TC_37504()
        {
            try
            {
                /**Test execution - Start**/
                
                SetupTestCase(Constants.TC_37504, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);
                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_38860();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*
      * To Admin Dashboard_To Verify Password reset to Resorts6 or user defined
     */
        [Test, Category("AMR TP 38860 Smoke Tests Admin")]
        public static void TC_37509()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_37509, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);
                
                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_38860();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*
        * To Admin Dashboard_To Verify the Inactivate an agent profile
        */
        [Test, Category("AMR TP 38860 Smoke Tests Admin")]
        public static void TC_37514()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_37514, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_38860();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        
        /*
        * To Admin Dashboard_To Verify the Reactivate an agent profile
        */
        [Test, Category("AMR TP 38860 Smoke Tests Admin")]
        public static void TC_37515()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_37515, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_38860();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*
         * Admin Dashboard_To Verify the Click of Action items in Manage Profile ,View Profile ,Edit Profile , Points History
        */
        [Test, Category("AMR TP 38860 Smoke Tests Admin")]
        public static void TC_37516()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_37516, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_38860();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*
        * Admin Dashboard_To Verify the Delete the test account created by QA (Agents with no Booking )
       */
        [Test, Category("AMR TP 38860 Smoke Tests Admin")]
        public static void TC_37519()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_37519, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_38860();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        
        /*
        * Admin Dashboard_To_Verify admin will be able to resend the certificate to an email entered
        */
        [Test, Category("AMR TP 38860 Smoke Tests Admin")]
        public static void TC_42271()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_42271, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_38860();

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
