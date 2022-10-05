using TestData;
using NUnit.Framework;
using System;
using InfoMessageLogger;
using eMenus.AppModule.MainAdminApp;
using BaseUtility.Utility;
using OpenQA.Selenium;
using System.Threading;
using eMenus.Utility;

namespace eMenus.TestPlan.HotelOrigami
{
    class eMenu_TP_277741_PostDeployment : eMenus.Utility.Setup
    {
        public eMenu_TP_277741_PostDeployment(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public eMenu_TP_277741_PostDeployment() { }
        [SetUp]
        public static void Initialize()
        {
            //Initialize the test case set up.
            InitializeSetup(Constants.TP_277741, Enums.ClientName.eMenus, Enums.TestDataType.Controller, Enums.CaseType.NA, "eMenus");

            //Navigate to the URL

            Driver.Navigate().GoToUrl("https://www.cendynaccess.com/");
        }


        /// <summary>
        /// Verify user is able to login successfully. 
        /// </summary>
        [Test, Category("TP 277741 eMenu Post Deployment")]
        public static void TC_278050()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_278050, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_277741();

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
        /// Verify Cendyn Admin user is able to navigate to Cendyn Admin from Property Admin.
        /// </summary>
        [Test, Category("TP 277741 eMenu Post Deployment")]
        public static void TC_278051()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_278051, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_277741();

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
        /// Verify user is able to logout successfully.
        /// </summary>
        [Test, Category("TP 277741 eMenu Post Deployment")]
        public static void TC_278052()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_278052, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_277741();

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
        /// Verify user is able to navigate to PDF view.
        /// </summary>
        [Test, Category("TP 277741 eMenu Post Deployment")]
        public static void TC_278054()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_278054, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_277741();

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
        /// Verify user is able to navigate between categories
        /// </summary>
        [Test, Category("TP 277741 eMenu Post Deployment")]
        public static void TC_278055()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_278055, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_277741();

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
        /// Validate navigation to Preview
        /// </summary>
        [Test, Category("TP 277741 eMenu Post Deployment")]
        public static void TC_278056()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_278056, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_277741();

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
        /// Validate navigation to Publish view
        /// </summary>
        [Test, Category("TP 277741 eMenu Post Deployment")]
        public static void TC_278057()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_278057, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_277741();

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
        /// Verify user is able to navigate between categories
        /// </summary>
        [Test, Category("TP 277741 eMenu Post Deployment")]
        public static void TC_278058()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_278058, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_277741();

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
        /// Validate user is able to navigate to Print page menu
        /// </summary>
        [Test, Category("TP 277741 eMenu Post Deployment")]
        public static void TC_278059()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_278059, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_277741();

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
        public void Close()
        {
            TestHandling.TearDown();
        }
    }
}
