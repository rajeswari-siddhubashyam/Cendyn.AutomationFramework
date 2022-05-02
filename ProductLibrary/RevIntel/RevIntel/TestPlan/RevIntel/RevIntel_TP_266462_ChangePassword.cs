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
    class RevIntel_TP_266462_ChangePassword : RevIntel.Utility.Setup
    {
        //public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public RevIntel_TP_266462_ChangePassword(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_266462;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_266462, Enums.ClientName.RevIntel, Enums.TestDataType.Controller, Enums.CaseType.NA, "RevIntel");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_121734;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            AddDelay(1500);
        }

        /// <summary>
        /// This test case will  Validate Upon selecting Cancel user landed on Monthly Pickup page
        /// </summary>
        [Test, Category("RevIntel_TP_266462_ChangePassword")]
        public static void TC_266463()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_266463, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_266462();


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
        [Test, Category("RevIntel_TP_266462_ChangePassword")]
        public static void TC_266464()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_266464, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_266462();


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
        /// This test case will  Verify Change Password functionality will not be successful when New and Confirm password are not matching
        /// </summary>
        [Test, Category("RevIntel_TP_266462_ChangePassword")]
        public static void TC_266466()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_266466, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_266462();


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
        /// This test case will  Verify Change Password functionality will not be successful when entered detail is not meeting the Password requirement criteria
        /// </summary>
        [Test, Category("RevIntel_TP_266462_ChangePassword")]
        public static void TC_266467()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_266467, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_266462();


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
        /// This test case will  Verify Change Password functionality will be successful when entered detail met Password requirements
        /// </summary>
        [Test, Category("RevIntel_TP_266462_ChangePassword")]
        public static void TC_266468()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_266468, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_266462();


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
