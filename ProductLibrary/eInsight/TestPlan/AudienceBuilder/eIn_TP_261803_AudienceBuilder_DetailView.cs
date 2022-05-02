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

namespace eInsightAudienceBuilderDetailView
{
    class eIn_TP_261803_AudienceBuilder_DetailView : eInsightSetup
    {
        public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public eIn_TP_261803_AudienceBuilder_DetailView(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {

            TestPlanId = Constants.TP_261803;

            //Initialize the test case set up.

            InitializeSetup(TestPlanId, GetProjectName);

            AddDelay(8000);

            //Can use this to update the URL Manually
            //LegacyTestData.CommonFrontendURL = "https://poceinsight.cendyn.com/";
        }

        [Test, Category("Regression")]
        public static void TC_261806()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_261806);


                Logger.DeleteOldFolder();
                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);


                    //Start
                    MainAdminApp.TP_261803();


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
        public static void TC_262015()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_262015);


                Logger.DeleteOldFolder();
                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);


                    //Start
                    MainAdminApp.TP_261803();


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
        public static void TC_262347()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_262347);


                Logger.DeleteOldFolder();
                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);


                    //Start
                    MainAdminApp.TP_261803();


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
        public static void TC_274525()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_274525);


                Logger.DeleteOldFolder();
                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);


                    //Start
                    MainAdminApp.TP_261803();


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
