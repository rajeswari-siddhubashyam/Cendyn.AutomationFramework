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

namespace eInsightAudienceBuilderEdit
{
    
    public class eIn_TP_242047_AudienceBuilder_Edit : eInsightSetup
    {
        public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public eIn_TP_242047_AudienceBuilder_Edit(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_242047;

            //Initialize the test case set up.
            InitializeSetup(TestPlanId,GetProjectName);

            //Assign the test data test plan file location
            //TestDataFile = TestDataLocation.TP_242047;

            AddDelay(8000);

            //Can use this to update the URL Manually
            //LegacyTestData.CommonFrontendURL = "https://poceinsight.cendyn.com/";
        }


        [Test, Category("Regression"), Order(1)]
        public static void TC_240153()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_240153);

                Logger.DeleteOldFolder();
                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_242047();

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

        
        [Test, Category("Regression"), Order(2)]
        public static void TC_240154()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_240154);

                Logger.DeleteOldFolder();
                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_242047();

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

        
        [Test, Category("Regression"), Order(3)]
        public static void TC_240155()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_240155);

                Logger.DeleteOldFolder();
                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_242047();

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

        
        [Test, Category("Regression"), Order(4)]
        public static void TC_240156()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_240156);

                Logger.DeleteOldFolder();
                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_242047();

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

        
        [Test, Category("Regression"), Order(5)]
        public static void TC_240157()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_240157);

                Logger.DeleteOldFolder();
                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_242047();

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

        
        [Test, Category("Regression"), Order(6)]
        public static void TC_240144()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_240144);

                Logger.DeleteOldFolder();
                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_242047();

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

        
        [Test, Category("Regression"), Order(7)]
        public static void TC_240145()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_240145);

                Logger.DeleteOldFolder();
                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_242047();

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

        
        [Test, Category("Regression"), Order(8)]
        public static void TC_240146()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_240146);

                Logger.DeleteOldFolder();
                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_242047();

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

        
        [Test, Category("Regression"), Order(9)]
        public static void TC_240847()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_240847);

                Logger.DeleteOldFolder();
                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    LegacyTestData.CommonFrontendEmail = "EdgewaterAdmin@cendyn17.com";
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_242047();

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
