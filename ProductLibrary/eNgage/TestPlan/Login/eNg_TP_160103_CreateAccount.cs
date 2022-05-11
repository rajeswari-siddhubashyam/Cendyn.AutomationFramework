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

namespace eNgageCreateAccount
{
    class eNg_TP_160103_CreateAccount : eNgageSetup
    {
        public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public eNg_TP_160103_CreateAccount(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {

            TestPlanId = Constants.TP_160103;

            //Initialize the test case set up.

            InitializeSetup(TestPlanId, GetProjectName);

            AddDelay(8000);

        }

        
        [Test, Category("Smoke")]
        public static void TC_160960()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_160960);


                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Driver.Navigate().GoToUrl(URL);

                //Start
                MainAdminApp.TP_160103();

                RenewDriver();

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
        public static void TC_160961()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_160961);


                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Driver.Navigate().GoToUrl(URL);

                //Start
                MainAdminApp.TP_160103();

                RenewDriver();

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
        public static void TC_160962()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_160962);


                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Driver.Navigate().GoToUrl(URL);

                //Start
                MainAdminApp.TP_160103();

                RenewDriver();

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
        public void Quit()
        {
            TestHandling.TearDown();
        }

    }
}
