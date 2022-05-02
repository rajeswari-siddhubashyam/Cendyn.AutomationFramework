using System;
using NUnit.Framework;
using eInsight.AppModule.MainAdminApp;
using BaseUtility.Utility;
using eInsight.AppModule.UI;
using System.Text.RegularExpressions;
using InfoMessageLogger;
using Constants = eInsight.Utility.Constants;
using LegacyTestData = eInsight.Utility.LegacyTestData;
using eInsightSetup = eInsight.Utility.Setup;
using OpenQA.Selenium;
using System.Threading;

namespace eInsightCASLSend
{
    class eIn_TP_128226_CASLNotification : eInsightSetup
    {
        public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public eIn_TP_128226_CASLNotification(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_128226;

            //Initialize the test case set up.
            InitializeSetup(TestPlanId,GetProjectName);

            //Assign the test data test plan file location
            //TestDataFile = TestDataLocation.TP_128226;

            AddDelay(8000);

            //Can use this to update the URL Manually
            //LegacyTestData.CommonFrontendURL = "https://poceinsight.cendyn.com/";
        }

        [Test, Category("Regression")]
        public static void TC_128429()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_128429);

                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_128226();

                    RenewDriver();
                }
                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Regression")]
        public static void TC_128430()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_128430);

                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_128226();

                    RenewDriver();
                }

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Regression")]
        public static void TC_128432()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_128432);

                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_128226();

                    RenewDriver();
                }

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Regression")]
        public static void TC_257224()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_257224);

                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_128226();

                    RenewDriver();
                }

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
