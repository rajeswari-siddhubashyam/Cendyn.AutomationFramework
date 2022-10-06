using BaseUtility.Utility;
using RevIntel.Utility;
using NUnit.Framework;
using TestData;
using System;
using InfoMessageLogger;
using RevIntel.AppModule.MainAdminApp;
using OpenQA.Selenium;
using System.Threading;

namespace RevIntel
{
    class RevIntel_TP_278124_Post_Deployment : RevIntel.Utility.Setup
    {

        public RevIntel_TP_278124_Post_Deployment(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        public RevIntel_TP_278124_Post_Deployment() { }
        /// <summary>
        /// Method is used to initialised the test plan
        /// </summary>
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_278124;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_278124, Enums.ClientName.RevIntel, Enums.TestDataType.Controller, Enums.CaseType.NA, "RevIntel");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_121734;

            //Navigate to the URL
            Driver.Navigate().GoToUrl("https://salesdemo.revintel.co");
            AddDelay(1500);
        }


        /// <summary>
        /// This test case will Verify Login and Log out is successful and URL is pointing to right database
        /// </summary>
        [Test, Category("TP_276187_Post_Deployment")]
        public static void TC_283459()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_283459, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_278124();

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
        /// This test case will Verify the default filter value and eyeball on calculated field in report
        /// </summary>
        [Test, Category("TP_276187_Post_Deployment")]
        public static void TC_283461()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_283461, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_278124();


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
        /// This test case will Verify logged in user is able to navigate to all menu and generate random reports
        /// </summary>
        [Test, Category("TP_276187_Post_Deployment")]
        public static void TC_283460()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_283460, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_278124();


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
        /// This test case will Verify user should be able to export the Pace report data in all format
        /// </summary>
        [Test, Category("TP_276187_Post_Deployment")]
        public static void TC_283458()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_283458, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_278124();


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
        /// This test case will Verify the Other Links
        /// </summary>
        [Test, Category("TP_276187_Post_Deployment")]
        public static void TC_283475()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_283475, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_278124();


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
        /// This test case will Verify attempting to create a new user with an existing email or userid should fail
        /// </summary>
        [Test, Category("TP_276187_Post_Deployment")]
        public static void TC_283457()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_283457, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_278124();


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
        /// This test case will Verify attempting to create a new portfolia with same name should fail
        /// </summary>
        [Test, Category("TP_276187_Post_Deployment")]
        public static void TC_283456()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_283456, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_278124();


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
        /// This test case will Upon selecting Cancel user landed on Monthly Pickup page
        /// </summary>
        [Test, Category("TP_276187_Post_Deployment")]
        public static void TC_283468()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_283468, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_278124();


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
        /// This test case will Verify Change Password functionality will not be successful when Current password is incorrect
        /// </summary>
        [Test, Category("TP_276187_Post_Deployment")]
        public static void TC_283470()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_283470, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_278124();


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
        /// This test case will Verify Change Password functionality will not be successful when New and Confirm password are not matching
        /// </summary>
        [Test, Category("TP_276187_Post_Deployment")]
        public static void TC_283472()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_283472, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_278124();


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
        /// This test case will Verify Change Password functionality will not be successful when entered detail is not meeting the Password requirement criteria
        /// </summary>
        [Test, Category("TP_276187_Post_Deployment")]
        public static void TC_283471()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_283471, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_278124();


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
        /// This test case will Verify Change Password functionality will be successful when entered detail met Password requirements
        /// </summary>
        [Test, Category("TP_276187_Post_Deployment")]
        public static void TC_283469()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_283469, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_278124();


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

