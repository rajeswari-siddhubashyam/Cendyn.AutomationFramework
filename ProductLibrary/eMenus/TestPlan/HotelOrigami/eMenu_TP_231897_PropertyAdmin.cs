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
    class eMenu_TP_231897_PropertyAdmin : eMenus.Utility.Setup
    {
        public eMenu_TP_231897_PropertyAdmin(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public eMenu_TP_231897_PropertyAdmin() { }
        [SetUp]
        public static void Initialize()
        {
            //Initialize the test case set up.
            InitializeSetup(Constants.TP_231897, Enums.ClientName.eMenus, Enums.TestDataType.Controller, Enums.CaseType.NA, "eMenus");

            //Navigate to the URL
            
            Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
        }

        /// <summary>
        /// This test case will Validate user is able to add menu item with choices. 
        /// </summary>
        
        [Test, Category("Hotel Origami TP 231897 Property Admin End to End Automation")]
        public static void TC_232900()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232900, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231897();

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
        /// This test case will Validate user is able to add menu item with add ons.  
        /// </summary>
        
        [Test, Category("Hotel Origami TP 231897 Property Admin End to End Automation")]
        public static void TC_232899()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232899, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231897();

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
        /// This test case will Validate user is able to Sign In successfully. 
        /// </summary>
        
        [Test, Category("Hotel Origami TP 231897 Front end End to End Automation")]
        public static void TC_232888()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232888, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231897();

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
        /// This test case will Validate user is able to Sign Out successfully. 
        /// </summary>
        
        [Test, Category("Hotel Origami TP 231897 Front end End to End Automation")]
        public static void TC_232889()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232889, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231897();

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
        /// This test case will Validate user is able to Sign Out successfully.
        /// </summary>
        
        [Test, Category("Hotel Origami TP 231897 Front end End to End Automation")]
        public static void TC_232890()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232890, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231897();

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
        /// This test case will Verify a User can add/delete tags on the Menu Filter settings page 
        /// </summary>
        
        [Test, Category("Hotel Origami TP 231897 Property Admin End to End Automation")]
        public static void TC_232891()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232891, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231897();

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
        /// This test case will Validate Find & Replace. 
        /// </summary>
        
        [Test, Category("Hotel Origami TP 231897 Front end End to End Automation")]
        public static void TC_232911()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232911, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231897();

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
        /// This test case will Validate when default price is set as 0 for any menu item then price "0" should not display for menu item in My Menus and in front end.
        /// </summary>

        
        [Test, Category("Hotel Origami TP 231897 Property Admin End to End Automation")]
        public static void TC_232897()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232897, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231897();

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
        /// This test case will Validate user is able to add menu item with default price.
        /// </summary>
        
        [Test, Category("Hotel Origami TP 231897 Property Admin End to End Automation")]
        public static void TC_232898()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232898, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231897();

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
        /// This test case will Verify a User can add/edit/delete dynamic pricing date ranges in settings 
        /// </summary>
        [Test, Category("Hotel Origami TP 231897 Property Admin End to End Automation")]
        public static void TC_232892()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232892, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231897();

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
        /// This test case will Validate user is able to add dynamic price for a date range in My Menus >> Add New menu
        /// </summary>

        [Test, Category("Hotel Origami TP 231897 Property Admin End to End Automation")]
        public static void TC_232893()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232893, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231897();

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
        /// This test case will Verify Field for dynamic price should not display in add/edit menu when the date of the dynamic pricing has passed  
        /// </summary>
        
        [Test, Category("Hotel Origami TP 231897 Property Admin End to End Automation")]
        public static void TC_232894()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232894, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231897();

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
        /// This test case will Verify that dynamic price overwrites the default price if the date range is set for the menu 
        /// </summary>
        
        [Test, Category("Hotel Origami TP 231897 Property Admin End to End Automation")]
        public static void TC_232895()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232895, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231897();

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
        /// This test case will Validate share Menu functionality. 
        /// </summary>

        [Test, Category("Hotel Origami TP 231897 Property Admin End to End Automation")]
        public static void TC_232913()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232913, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231897();

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
