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
    class eMenu_TP_231898_Cendynadmin : eMenus.Utility.Setup
    {
        public eMenu_TP_231898_Cendynadmin(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            //Initialize the test case set up.
            InitializeSetup(Constants.TP_231898, Enums.ClientName.CendynAdmin, Enums.TestDataType.Controller, Enums.CaseType.NA, "eMenus");

            //Navigate to the URL

            Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
        }


        /// <summary>
        /// This test case will Validate user is able to Sign In successfully. 
        /// </summary>
        
        [Test, Category("HotelOrigami_TP_231898_Cendynadmin")]
        public static void TC_232154()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232154, "Excel", Enums.ClientName.All, Enums.TestDataType.CendynAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231898();

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
        /// This test case will Validate user is able to Logout successfully.
        /// </summary>
        
        [Test, Category("HotelOrigami_TP_231898_Cendynadmin")]
        public static void TC_232156()
        {

            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232156, "Excel", Enums.ClientName.All, Enums.TestDataType.CendynAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231898();

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
        /// This test case will Validate user is able to Logout successfully.
        /// </summary>
        
        [Test, Category("HotelOrigami_TP_231898_Cendynadmin")]
        public static void TC_232159()
        {

            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232159, "Excel", Enums.ClientName.All, Enums.TestDataType.CendynAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231898();

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
        /// This test case will  Verify user can edit category/sub category/ sub sub category with category type as Menu/content. Verify it's impact on property admin and front end before and after publish.
        /// </summary>
        
        [Test, Category("HotelOrigami_TP_231898_Cendynadmin")]
        public static void TC_232160()
        {

            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232160, "Excel", Enums.ClientName.All, Enums.TestDataType.CendynAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231898();

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
        /// This test case will  Verify user can edit category/sub category/ sub sub category with category type as Menu/content. Verify it's impact on property admin and front end before and after publish.
        /// </summary>
        
        [Test, Category("HotelOrigami_TP_231898_Cendynadmin")]
        public static void TC_232161()
        {

            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232161, "Excel", Enums.ClientName.All, Enums.TestDataType.CendynAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231898();

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
        /// This test case will Validate impact of basic setting in property admin
        /// </summary>
        
        [Test, Category("HotelOrigami_TP_231898_Cendynadmin")]
        public static void TC_232157()
        {

            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232157, "Excel", Enums.ClientName.All, Enums.TestDataType.CendynAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231898();

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
        /// This test case will Validate impact of Advance setting in property admin and front end
        /// </summary>
        
       [Test, Category("HotelOrigami_TP_231898_Cendynadmin")]
        public static void TC_232158()
        {

            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232158, "Excel", Enums.ClientName.All, Enums.TestDataType.CendynAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231898();

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
