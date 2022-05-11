using BaseUtility.Utility;
using RevIntel.Utility;
using NUnit.Framework;
using TestData;
using System;
using InfoMessageLogger;
using RevIntel.AppModule.MainAdminApp;
using OpenQA.Selenium;
using System.Threading;

namespace RevIntel
{
    class RevIntel_TP_274130_Zendesk : RevIntel.Utility.Setup
    {
        
        public RevIntel_TP_274130_Zendesk(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_274130;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_274130, Enums.ClientName.RevIntel, Enums.TestDataType.Controller, Enums.CaseType.NA, "RevIntel");


            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            AddDelay(1500);
        }

        /// <summary>
        /// This test case will  Verify the Help tool is displaying in all authenticated page
        /// </summary>
        [Test, Category("RevIntel_TP_274130_ri - Zendesk")]
        public static void TC_271062()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_271062, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_274130();


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
        /// This test case will Verify by default more than top 3 suggestion gets displayed
        /// </summary>
        [Test, Category("RevIntel_TP_274130_ri - Zendesk")]
        public static void TC_271063()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_271063, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_274130();


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
        /// This test case will Verify only the help that belongs to the product gets displayed in suggestion when searched for a text
        /// </summary>
        [Test, Category("RevIntel_TP_274130_ri - Zendesk")]
        public static void TC_271064()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_271064, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_274130();


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
        /// This test case will  Verify the contact us functionality
        /// </summary>
        [Test, Category("RevIntel_TP_274130_ri - Zendesk")]
        public static void TC_271065()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_271065, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_274130();


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
        /// This test case will Verify only the help that belongs to the product gets displayed in suggestion when searched for a text
        /// </summary>
        [Test, Category("RevIntel_TP_274130_ri - Zendesk")]
        public static void TC_271066()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_271066, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_274130();


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
