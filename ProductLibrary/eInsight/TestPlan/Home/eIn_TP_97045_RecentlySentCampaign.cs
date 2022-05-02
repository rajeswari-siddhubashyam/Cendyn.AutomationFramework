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

namespace eInsightRecentlySentCampaign
{
    
    class eIn_TP_97045_RecentlySentCampaign : eInsightSetup
    {
        public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public eIn_TP_97045_RecentlySentCampaign(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_97045;

            //Initialize the test case set up.
            InitializeSetup(TestPlanId,GetProjectName);

            //Assign the test data test plan file location
            //TestDataFile = TestDataLocation.TP_97045;

            AddDelay(8000);

            //Can use this to update the URL Manually
            //LegacyTestData.CommonFrontendURL = "https://poceinsight.cendyn.com/";
        }

        [Test, Category("Smoke")]
        public static void TC_85789()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_85789);

                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_97045();

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
        public static void TC_129807()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_129807);

                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_97045();

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
        public static void TC_251644()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_251644);

                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_97045();

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
        public static void TC_251645()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_251645);

                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_97045();

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
        public static void TC_251646()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_251646);

                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_97045();

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
        public static void TC_251699()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_251699);

                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_97045();

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
        public static void TC_251662()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_251662);

                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_97045();

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
        public static void TC_251664()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_251664);

                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_97045();

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
        public static void TC_251666()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_251666);

                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_97045();

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
        public static void TC_251667()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_251667);

                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_97045();

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
        public static void TC_251668()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_251668);

                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_97045();

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
        public static void TC_251700()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_251700);

                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_97045();

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
        public static void TC_98348()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_98348);

                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_97045();

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
        public static void TC_98234()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_98234);

                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_97045();

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
        public static void TC_98111()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_98111);

                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_97045();

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
        public static void TC_130057()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_130057);

                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_97045();

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
        public static void TC_251656()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_251656);

                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_97045();

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
        public static void TC_251924()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_251924);

                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_97045();

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
