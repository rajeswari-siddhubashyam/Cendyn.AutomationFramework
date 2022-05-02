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
using System.Threading;
using OpenQA.Selenium;

namespace eInsightProfile
{
    public class eIn_TP_106791_Profile : eInsightSetup
    {
        public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public eIn_TP_106791_Profile(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_10679;

            //Initialize the test case set up.
            InitializeSetup(TestPlanId,GetProjectName);

            //Assign the test data test plan file location
            //TestDataFile = TestDataLocation.TP_106791;

            AddDelay(8000);

            //Can use this to update the URL Manually
            //LegacyTestData.CommonFrontendURL = "https://poceinsight.cendyn.com/";
        }

        [Test, Category("Smoke"), Order(5)]
        public static void TC_63959()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_63959);

                Logger.DeleteOldFolder();
                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_106791();

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
        
        [Test, Category("Smoke"), Order(1)]
        public static void TC_68068()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_68068);

                Logger.DeleteOldFolder();
                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_106791();

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

        [Test, Category("Smoke"), Order(3)]
        public static void TC_80078()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_80078);

                Logger.DeleteOldFolder();
                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_106791();

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

        [Test, Category("Smoke"), Order(4)]
        public static void TC_80080()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_80080);

                Logger.DeleteOldFolder();
                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_106791();

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

        // Unable to automate as mentioned in TP
        //[Test, Category("Smoke"), Order(6)]
        //public static void TC_95717()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        Legacy_SetupTestCase(Constants.TC_95717);

        //        Logger.DeleteOldFolder();
        //        string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
        //        foreach (string frontendURL in eachFrontEndURL)
        //        {
        //            Login.CommonLogin(frontendURL);

        //            //Start
        //            MainAdminApp.TP_106791();

        //            RenewDriver();
        //        }

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
        
        public static void TC_196973()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_196973);

                Logger.DeleteOldFolder();
                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_106791();

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
        
        [Test, Category("Smoke"), Order(2)]
        public static void TC_74653()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_74653);

                Logger.DeleteOldFolder();
                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);

                    //Start
                    MainAdminApp.TP_106791();

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
