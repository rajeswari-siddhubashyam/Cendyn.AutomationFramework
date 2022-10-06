using System;
using System.Threading;
using BaseUtility.Utility;
using eMenus.AppModule.MainAdminApp;
using eMenus.Utility;
using InfoMessageLogger;
using NUnit.Framework;
using OpenQA.Selenium;
using TestData;

namespace ePlanner.TestPlan.HotelOrigami
{
    class ePlanner_TP_231901_CendynAdmin : eMenus.Utility.Setup
    {
        public ePlanner_TP_231901_CendynAdmin(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public ePlanner_TP_231901_CendynAdmin() { }
        [SetUp]
        public static void Initialize()
        {
            //Initialize the test case set up.
            InitializeSetup(Constants.TP_231901, Enums.ClientName.ePlanner, Enums.TestDataType.Controller, Enums.CaseType.NA, "ePlanner");

            //Navigate to the URL

            Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
        }

        /// <summary>
        /// This test case will Validate by adding a Regular Category with sub levels in Cendyn admin and it's impact on property admin and front end. 
        /// </summary>

        [Test, Category("Hotel Origami TP_231901 Cendyn Admin")]
        public static void TC_232790()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232790, "Excel", Enums.ClientName.All, Enums.TestDataType.CendynAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231901();

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
        /// This test case will Validate by adding a Regular Category without sub levels in Cendyn admin and it's impact on property admin and front end. 
        /// </summary>

        [Test, Category("Hotel Origami TP_231901 Cendyn Admin")]
        public static void TC_232791()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232791, "Excel", Enums.ClientName.All, Enums.TestDataType.CendynAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231901();

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
        /// This test case will Validate user is able to add a category with category type as Home Letter and it's impact in property admin and front end. 
        /// </summary>

        [Test, Category("Hotel Origami TP_231901 Cendyn Admin")]
        public static void TC_232792()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232792, "Excel", Enums.ClientName.All, Enums.TestDataType.CendynAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231901();

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
        /// This test case will Validate user is able to add a category with category type as Home No Letter and it's impact in property admin and front end. 
        /// </summary>

        [Test, Category("Hotel Origami TP_231901 Cendyn Admin")]
        public static void TC_232793()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232793, "Excel", Enums.ClientName.All, Enums.TestDataType.CendynAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231901();

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
        /// This test case will Validate user is able to add Manger per property. 
        /// </summary>
        [Test, Category("Hotel Origami TP_231901 Cendyn Admin")]
        public static void TC_232794()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232794, "Excel", Enums.ClientName.All, Enums.TestDataType.CendynAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231901();

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
