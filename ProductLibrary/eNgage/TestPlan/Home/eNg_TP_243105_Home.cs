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

namespace eNgageHome
{
    public class eNg_TP_243105_Home : eNgageSetup
    {

        public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public eNg_TP_243105_Home(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public eNg_TP_243105_Home() { }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_243105;

            //Initialize the test case set up.
            InitializeSetup(TestPlanId, GetProjectName);

            //Assign the test data test plan file location
            //TestDataFile = TestDataLocation.TP_243105;

            AddDelay(4000);

        }
        //ALL Search List
        
        [Test, Category("Smoke"), Order(1)]
        public static void TC_243109()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_243109);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);

                MainAdminApp.TP_243105();
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
        //Members Search List
        
        [Test, Category("Smoke"), Order(2)]
        public static void TC_243110()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_243110);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);
                MainAdminApp.TP_243105();
                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        //VIP Search List
        
        [Test, Category("Smoke"), Order(3)]
        public static void TC_243112()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_243112);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);
                MainAdminApp.TP_243105();
                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        //Arrivals Search List
        
        [Test, Category("Smoke"), Order(4)]
        public static void TC_243113()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_243113);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);
                MainAdminApp.TP_243105();
                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        //Departures List
        
        [Test, Category("Smoke"), Order(5)]
        public static void TC_243114()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_243114);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);
                MainAdminApp.TP_243105();
                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        //In House Search List
        
        [Test, Category("Smoke"), Order(6)]
        public static void TC_243118()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_243118);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);
                MainAdminApp.TP_243105();
                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        // verify total Count in each tile matches number of search results
        
        [Test, Category("Smoke"), Order(7)]
        public static void TC_243608()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_243608);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);
                //Start
                MainAdminApp.TP_243105();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        // Verify page flow from Home to summary
        
        [Test, Category("Smoke"), Order(8)]
        public static void TC_244589()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_244589);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);
                //Start
                MainAdminApp.TP_243105();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        //Change hotel dropdown,search a hotel, change date, refresh,verify percentage
        [Test, Category("Smoke"), Order(9)]
        public static void TC_243120()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_243120);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);
                //Start
                MainAdminApp.TP_243105();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        // verify icon & text are displaying for Home 
        [Test, Category("Smoke"), Order(10)]
        public static void TC_243996()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_243996);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);
                //Start
                MainAdminApp.TP_243105();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        //Check user landing page 
        [Test, Category("Smoke"), Order(11)]
        public static void TC_160133()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_160133);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);
                //Start
                MainAdminApp.TP_243105();

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
