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
    class eMenu_TP_231896_Frontend : eMenus.Utility.Setup
    {
        public eMenu_TP_231896_Frontend(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            //Initialize the test case set up.
            InitializeSetup(Constants.TP_231896, Enums.ClientName.eMenus, Enums.TestDataType.Controller, Enums.CaseType.NA, "eMenus");

            //Navigate to the URL
            
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
        }

       
        /*This test case will Validate user is able to Create Account successfully. */
        [Test, Category("Hotel Origami TP 231896 Front end End to End Automation")]
        public static void TC_231915()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_231915, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231896();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*This test case will Validate user is able to Sign In successfully. */
        [Test, Category("Hotel Origami TP 231896 Front end End to End Automation")]
        public static void TC_231918()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_231918, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231896();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*This test case will Validate user is able to Logout successfully.*/
        [Test, Category("Hotel Origami TP 231896 Front end End to End Automation")]
        public static void TC_231942()
        {

            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_231942, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231896();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will Validate Forget Password functionality */
        [Test, Category("Hotel Origami TP 231896 FrontEnd")]
        public static void TC_231919()
        {

            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_231919, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231896();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* Validate user can update Account information */
        [Test, Category("Hotel Origami TP 231896 FrontEnd")]
        public static void TC_231943()
        {

            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_231943, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231896();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* Validate user can change their password. */
        [Test, Category("Hotel Origami TP 231896 FrontEnd")]
        public static void TC_231944()
        {

            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_231944, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231896();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /*This test case will Validate user is able to Create and Save the order successfully.*/
        [Test, Category("Hotel Origami TP 231896 Front end End to End Automation")]
        public static void TC_231928()
        {

            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_231928, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231896();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }

            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /*This test case will Validate user is able to Create and Send the order successfully.*/
        [Test, Category("Hotel Origami TP 231896 Front end End to End Automation")]
        public static void TC_231929()
        {

            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_231929, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231896();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }

            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /*This test case will Validate filter functionality.*/
        [Test, Category("Hotel Origami TP 231896 Front end End to End Automation")]
        public static void TC_233084()
        {

            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_233084, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231896();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /*This test case will Validate user can add, edit, copy, delete and comment in a function.*/
        [Test, Category("Hotel Origami TP 231896 Front end End to End Automation")]
        public static void TC_232085()
        {

            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232085, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231896();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*This test case will Validate user can add, edit, copy and delete menu items from a function.*/
        [Test, Category("Hotel Origami TP 231896 Front end End to End Automation")]
        public static void TC_232083()
        {

            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232083, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231896();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /*This test case will Validate user is able to add dynamic price for a date range in My Menus >> Add New menu and it's impact in front end menu prices after selecting a date in event calendar.*/
        [Test, Category("Hotel Origami TP 231896 Front end End to End Automation")]
        public static void TC_231935()
        {

            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_231935, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231896();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /*This test case will Validate user is able to edit dynamic price for a date range in My Menus and it's impact in front end menu prices after selecting a date in event calendar..*/
        [Test, Category("Hotel Origami TP 231896 Front end End to End Automation")]
        public static void TC_231936()
        {

            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_231936, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231896();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /*This test case will Verify when dynamic pricing is deleted then existing menu using the dynamic pricing is displaying the default price or the new price.*/
        [Test, Category("Hotel Origami TP 231896 Front end End to End Automation")]
        public static void TC_231937()
        {

            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_231937, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231896();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /*This test case will Verify the dynamic price overwrites the default price if the valid date range is set for the menu.*/
        [Test, Category("Hotel Origami TP 231896 Front end End to End Automation")]
        public static void TC_231938()
        {

            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_231938, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231896();

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
