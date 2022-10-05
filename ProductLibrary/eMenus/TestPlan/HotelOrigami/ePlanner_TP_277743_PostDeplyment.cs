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
    class ePlanner_TP_277743_PostDeplyment : eMenus.Utility.Setup
    {
        public ePlanner_TP_277743_PostDeplyment(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public ePlanner_TP_277743_PostDeplyment() { }
        [SetUp]
        public static void Initialize()
        {
            //Initialize the test case set up.
            InitializeSetup(Constants.TP_277743, Enums.ClientName.ePlanner, Enums.TestDataType.Controller, Enums.CaseType.NA, "ePlanner");

            //Navigate to the URL

            Driver.Navigate().GoToUrl("https://www.cendynaccess.com/");
        }

        /// <summary>
        /// Post deployment 
        /// </summary>

        [Test, Category("ePlanner TP_277743 Post deployment")]
        public static void TC_278095()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_278095, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_277743();

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
        /// Post deployment 
        /// </summary>

        [Test, Category("ePlanner TP_277743 Post deployment")]
        public static void TC_278096()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_278096, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_277743();

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
        /// Post deployment 
        /// </summary>

        [Test, Category("ePlanner TP_277743 Post deployment")]
        public static void TC_278097()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_278097, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_277743();

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
        /// Post deployment 
        /// </summary>

        [Test, Category("ePlanner TP_277743 Post deployment")]
        public static void TC_278099()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_278099, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_277743();

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
        /// Post deployment 
        /// </summary>

        [Test, Category("ePlanner TP_277743 Post deployment")]
        public static void TC_278100()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_278100, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_277743();

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
        /// Post deployment 
        /// </summary>

        [Test, Category("ePlanner TP_277743 Post deployment")]
        public static void TC_278101()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_278101, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_277743();

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
        /// Post deployment 
        /// </summary>

        [Test, Category("ePlanner TP_277743 Post deployment")]
        public static void TC_278094()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_278094, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_277743();

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
        /// Post deployment 
        /// </summary>


        /// <summary>
        /// Verify if the Global search functionality is working in the front end
        /// </summary>

        [Test, Category("ePlanner TP_277743 Post deployment")]
        public static void TC_195393()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_195393, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_277743();

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
