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

namespace eNgageSearch
{
    class eNg_TP_160101_Search : eNgageSetup
    {
        public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public eNg_TP_160101_Search(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_160101;

            //Initialize the test case set up.
            InitializeSetup(TestPlanId, GetProjectName);

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.TP_160101;

            AddDelay(4000);
        }
        //Search by Name 
        
        [Test, Category("Smoke"), Order(1)]
        public static void TC_160144()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_160144);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);

                MainAdminApp.TP_160101();
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
        //Search by Profile ID 
        
        [Test, Category("Smoke"), Order(2)]
        public static void TC_160143()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_160143);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);
                MainAdminApp.TP_160101();
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
        //Search by Email 
        
        [Test, Category("Smoke"), Order(3)]
        public static void TC_160147()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_160147);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);
                MainAdminApp.TP_160101();
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
        //Search by Member ID 
        
        [Test, Category("Smoke"), Order(4)]
        public static void TC_160149()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_160149);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);
                MainAdminApp.TP_160101();
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
        //Search by Reservation  
        
        [Test, Category("Smoke"), Order(5)]
        public static void TC_243421()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_243421);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);
                MainAdminApp.TP_160101();
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
        //Search by Phone 
        
        [Test, Category("Smoke"), Order(6)]
        public static void TC_160146()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_160146);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);
                MainAdminApp.TP_160101();
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
        //Search by Name & Zip 
        
        [Test, Category("Smoke"), Order(7)]
        public static void TC_243423()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_243423);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);
                MainAdminApp.TP_160101();
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
        //Search by Network , brand, hotel
        [Test, Category("Smoke"), Order(8)]
        public static void TC_243411()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_243411);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);

                MainAdminApp.TP_160101();
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
        //Search invalid data
        [Test, Category("Smoke"), Order(9)]
        public static void TC_160193()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_160193);
                Logger.DeleteOldFolder();
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);

                MainAdminApp.TP_160101();
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
        //Verify Search fields
        [Test, Category("Smoke"), Order(10)]
        public static void TC_160134()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_160134);
                Logger.DeleteOldFolder();
                //Login.CommonLogin(TestData.CommonFrontendURL);
                string URL = Login.LoginURL();
                Login.CommonLogin(URL);
                MainAdminApp.TP_160101();


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
