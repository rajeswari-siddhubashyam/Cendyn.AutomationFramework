using TestData;
using NUnit.Framework;
using System;
using InfoMessageLogger;
using eMenus.AppModule.MainAdminApp;
using BaseUtility.Utility;
using OpenQA.Selenium;
using System.Threading;
using eMenus.Utility;

namespace ePlanner.TestPlan.HotelOrigami
{
    class ePlanner_TP_231900_PropertyAdmin : eMenus.Utility.Setup
    {
        public ePlanner_TP_231900_PropertyAdmin(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            //Initialize the test case set up.
            InitializeSetup(Constants.TP_231900, Enums.ClientName.ePlanner, Enums.TestDataType.Controller, Enums.CaseType.NA, "ePlanner");

            //Navigate to the URL

            Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
        }

        /// <summary>
        /// This test case will Validate user is able to add menu item with choices. 
        /// </summary>

        [Test, Category("Hotel Origami TP_231900 Property Admin End to End Automation")]
        public static void TC_232780()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232780, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231900();

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
        /// Validate user is able to add item by uploading image from eGallery. 
        /// </summary>

        [Test, Category("Hotel Origami TP_231900 Property Admin End to End Automation")]
        public static void TC_232781()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232781, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231900();

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
        ///  Validate user is able to add item by uploading image (other than egallery). 
        /// </summary>

        [Test, Category("Hotel Origami TP_231900 Property Admin End to End Automation")]
        public static void TC_232782()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232782, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231900();

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
        /// Validate user is able to add item by uploading a file. 
        /// </summary>

        [Test, Category("Hotel Origami TP_231900 Property Admin End to End Automation")]
        public static void TC_232783()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232783, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231900();

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
        /// This test case will Validate user is able to edit item. 
        /// </summary>

        [Test, Category("Hotel Origami TP_231900 Property Admin End to End Automation")]
        public static void TC_232921()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232921, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231900();

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
        /// This test case will Validate user is able to delete item. 
        /// </summary>

        [Test, Category("Hotel Origami TP_231900 Property Admin End to End Automation")]
        public static void TC_232922()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232922, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231900();

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
        /// This test case will Validate that added menu item is displayed in preview mode but not in published view. 
        /// </summary>

        [Test, Category("Hotel Origami TP_231900 Property Admin End to End Automation")]
        public static void TC_232784()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232784, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231900();

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
        /// This test case will Validate that added menu item is displayed in published view. 
        /// </summary>

        [Test, Category("Hotel Origami TP_231900 Property Admin End to End Automation")]
        public static void TC_232785()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232785, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231900();

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
        /// This test case will Validate user is able to move up and down item.
        /// </summary>

        [Test, Category("Hotel Origami TP_231900 Property Admin End to End Automation")]
        public static void TC_232923()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232923, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231900();

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
        /// This test case will Validate user able to add/edit category description
        /// </summary>

        [Test, Category("Hotel Origami TP_231900 Property Admin End to End Automation")]
        public static void TC_232925()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232925, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231900();

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
        /// This test case will Validate user able to add category image from eGallery
        /// </summary>

        [Test, Category("Hotel Origami TP_231900 Property Admin End to End Automation")]
        public static void TC_232926()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232926, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231900();

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
        /// This test case will Validate Find and replace functionality
        /// </summary>

        [Test, Category("Hotel Origami TP_231900 Property Admin End to End Automation")]
        public static void TC_233769()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_233769, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231900();

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
