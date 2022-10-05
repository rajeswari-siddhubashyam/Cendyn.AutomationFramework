using BaseUtility.Utility;
using eMenus.AppModule.MainAdminApp;
using eMenus.Utility;
using InfoMessageLogger;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestData;

namespace ePlanner.TestPlan.HotelOrigami
{
    class ePlanner_TP_231899_Frontend : eMenus.Utility.Setup
    {
        public ePlanner_TP_231899_Frontend(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public ePlanner_TP_231899_Frontend() { }
        [SetUp]
        public static void Initialize()
        {
            //Initialize the test case set up.
            InitializeSetup(Constants.TP_231899, Enums.ClientName.ePlanner, Enums.TestDataType.Controller, Enums.CaseType.NA, "ePlanner");

            //Navigate to the URL

            Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
        }

        /// <summary>
        /// This test case will validate user is able to search with content from item title. 
        /// </summary>

        [Test, Category("Hotel Origami TP_231899 Front End")]
        public static void TC_232759()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232759, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231899();

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
        /// This test case will validate user is able to search with content from item description.
        /// </summary>

        [Test, Category("Hotel Origami TP_231899 Front End")]
        public static void TC_232761()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232761, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231899();

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
        /// This test case will validate user is able to search Home page content in letter. 
        /// </summary>

        [Test, Category("Hotel Origami TP_231899 Front End")]
        public static void TC_232763()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232763, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231899();

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
        /// This test case will validate when user enter a content with combination of "&#","<>" and "<" then user will get a validation message verbiage as 'You have entered invalid characters such as "&#", "<>". Please re-enter.' 
        /// </summary>

        [Test, Category("Hotel Origami TP_231899 Front End")]
        public static void TC_232764()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232764, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231899();

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
        /// This test case will Validate when user enters less than 4 characters in search field, then user will get a validation message verbiage as 'Your search was too vague. Please be more specific.' 
        /// </summary>

        [Test, Category("Hotel Origami TP_231899 Front End")]
        public static void TC_232795()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232795, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231899();

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
        /// This test case will validate that search result is not displayed when user search with category description and disclaimer' 
        /// </summary>

        [Test, Category("Hotel Origami TP_231899 Front End")]
        public static void TC_232975()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232975, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231899();

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
        /// This test case will validate Manager profile/headshot/signature should display only for category type home letter. 
        /// </summary>

        [Test, Category("Hotel Origami TP_231900 Property Admin End to End Automation")]
        public static void TC_232765()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_232765, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_231899();

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
