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
    class RevIntel_TP_251469_SmokePlan : RevIntel.Utility.Setup
    {
      
        public RevIntel_TP_251469_SmokePlan(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        public RevIntel_TP_251469_SmokePlan() { }
        /// <summary>
        /// Method is used to initialised the test plan
        /// </summary>
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_251469;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_251469, Enums.ClientName.RevIntel, Enums.TestDataType.Controller, Enums.CaseType.NA, "RevIntel");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_121734;

            //Navigate to the URL
            Driver.Navigate().GoToUrl("https://revintelrhbi.godevcendyn.com");
            AddDelay(1500);
        }


        /// <summary>
        /// This test case will Verify Login and Log out is successful and URL is pointing to right database
        /// </summary>
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_251470()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_251470, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_251469();

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
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_252390()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252390, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_251469();


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
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_252394()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252394, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_251469();


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
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_252401()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252401, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_251469();


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
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_252482()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252482, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_251469();


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
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_252494()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252494, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_251469();


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
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_252496()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252496, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_251469();


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
        /// This test case will Verify Upon selecting Cancel user landed on Monthly Pickup page
        /// </summary>
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_266463()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_266463, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_251469();


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
        /// This test case will  Verify Change Password functionality will not be successful when Current password is incorrect
        /// </summary>
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_266464()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_266464, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_251469();


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
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_266466()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_266466, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_251469();


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
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_266467()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_266467, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_251469();


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
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_266468()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_266468, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_251469();


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
