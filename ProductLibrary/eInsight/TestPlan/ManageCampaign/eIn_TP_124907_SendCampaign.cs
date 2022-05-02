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
using System.Reflection;
using System.Collections.Generic;

namespace eInsightSendCampaign
{
    public class eIn_TP_124907_SendCampaign : eInsightSetup
    {
        public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public eIn_TP_124907_SendCampaign(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_124907;

            //Initialize the test case set up.
            InitializeSetup(TestPlanId,GetProjectName);

            //Assign the test data test plan file location
            //TestDataFile = TestDataLocation.TP_124907;

            AddDelay(8000);

            //Can use this to update the URL Manually
            //LegacyTestData.CommonFrontendURL = "https://poceinsight.cendyn.com/";
        }

        public static void TC_73959()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_73959);

                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);
                    
                    //Start
                    MainAdminApp.TP_124907();

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

        [Test, Category("Smoke")]
        public static void TC_102002()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_102002);

                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_124907();

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

        [Test, Category("Smoke")]
        public static void TC_124537()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_124537);

                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_124907();

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

        [Test, Category("Smoke")]
        public static void TC_131671()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_131671);

                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_124907();

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
