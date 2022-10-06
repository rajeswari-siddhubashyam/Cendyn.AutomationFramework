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

namespace eNgageHomePrompts
{
    class eNg_TP_242772_Prompts : eNgageSetup
    {
        public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public eNg_TP_242772_Prompts(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public eNg_TP_242772_Prompts() { }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_242772;

            //Initialize the test case set up.
            InitializeSetup(TestPlanId, GetProjectName);

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.TP_242772;

            AddDelay(4000);
        }
        // add emoticons
        [Test, Category("Smoke"), Order(1)]
        public static void TC_243245()
        {
            try
            {
                 /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_243245);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);
                //Login.LoginTestCase(URL);
                MainAdminApp.TP_242772();
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
        //welcome prompt
        [Test, Category("Smoke"), Order(2)]
        public static void TC_242784()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_242784);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);
                //Login.LoginTestCase(URL);
                MainAdminApp.TP_242772();
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
        //welcome back
        [Test, Category("Smoke"), Order(3)]
        public static void TC_242805()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_242805);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);
                //Login.LoginTestCase(URL);
                MainAdminApp.TP_242772();
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
        //email collection prompt
        [Test, Category("Smoke"), Order(4)]
        public static void TC_242789()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_242789);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);
                //Login.LoginTestCase(URL);
                MainAdminApp.TP_242772();
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
        //Email Verification prompt
        [Test, Category("Smoke"), Order(4)]
        public static void TC_242812()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_242812);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);
                //Login.LoginTestCase(URL);
                MainAdminApp.TP_242772();
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
        /*Birthday Prompt
        [Test, Category("Smoke"), Order(4)]
        public static void TC_242816()
        {
            try
            {
                
                Legacy_SetupTestCase(Constants.TC_242816);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);
                
                MainAdminApp.TP_242772();
                
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }*/

        [TearDown]
        public void Quit()
        {
            TestHandling.TearDown();
        }
    }
}
