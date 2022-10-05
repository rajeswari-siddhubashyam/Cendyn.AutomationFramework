using System;
using NUnit.Framework;
using eNgage.AppModule.MainAdminApp;
using BaseUtility.Utility;
using eNgage.AppModule.UI;
using System.Text.RegularExpressions;
using InfoMessageLogger;
using Constants = eNgage.Utility.Constants;
using LegacyTestData = eNgage.Utility.LegacyTestData;
using eNgageSetup = eNgage.Utility.Setup;
using OpenQA.Selenium;
using System.Threading;

namespace eNgageAdmin
{
    class eNg_TP_243163_Admin : eNgageSetup
    {
        public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;

        public eNg_TP_243163_Admin(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public eNg_TP_243163_Admin() { }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_243163;

            //Initialize the test case set up.
            InitializeSetup(TestPlanId, GetProjectName);

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.TP_243163;

            AddDelay(4000);
        }
        
        [Test, Category("Smoke"), Order(1)]
        public static void TC_243294()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_243294);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);

                MainAdminApp.TP_243163();
                //RenewDriver();
                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        
        [Test, Category("Smoke"), Order(2)]
        public static void TC_243417()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_243417);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);

                MainAdminApp.TP_243163();
                //RenewDriver();
                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [TearDown]
        public void Quit()
        {
            TestHandling.TearDown();
        }
    }
}
