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
    class RevIntel_TP_252864_Administration_Menu : RevIntel.Utility.Setup
    {

        public RevIntel_TP_252864_Administration_Menu(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_252864;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_252864, Enums.ClientName.RevIntel, Enums.TestDataType.Controller, Enums.CaseType.NA, "RevIntel");


            //Navigate to the URL

            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            AddDelay(1500);
        }

        /// <summary>
        /// This test case will  Verify the Access log
        /// </summary>
        [Test, Category("RevIntel_TP_252864_Administration_Menu")]
        public static void TC_252870()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252870, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252864();


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
        /// This test case will Verify the Corporate Portfolio
        /// </summary>
        [Test, Category("RevIntel_TP_252864_Administration_Menu")]
        public static void TC_252871()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252871, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252864();


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
        /// Verify User Maintenence - SSO- Make sure the window/screen closes after clicking the [Save] button to create a new user)
        /// Verify User Maintenence - SSO- Verify attempting to create a new user with an existing email or userid should fail
        /// </summary>
        [Test, Category("RevIntel_TP_252864_Administration_Menu")]
        public static void TC_252877()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252877, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252864();


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
        /// Parent Company - No duplicate Parent name is allowed and a warning displays
        /// </summary>
        [Test, Category("RevIntel_TP_252864_Administration_Menu")]
        public static void TC_252879()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252879, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252864();


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
        /// Administration menu/ User Access report - Verify the user access report
        /// </summary>
        [Test, Category("RevIntel_TP_252864_Administration_Menu")]
        public static void TC_252894()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252894, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252864();


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
        /// A user with Property Admin role should only see a list of hotels that he/she was given access to
        /// </summary>
        [Test, Category("RevIntel_TP_252864_Administration_Menu")]
        public static void TC_252878()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252878, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252864();


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
