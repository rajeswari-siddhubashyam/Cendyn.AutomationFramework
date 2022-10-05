using System;
using NUnit.Framework;
using eProposal.AppModule.MainAdminApp;
using BaseUtility.Utility;
using eProposal.AppModule.UI;
using System.Text.RegularExpressions;
using InfoMessageLogger;
using Constants = eProposal.Utility.Constants;
using LegacyTestData = eProposal.Utility.LegacyTestData;
using eProposalSetup = eProposal.Utility.Setup;
using OpenQA.Selenium;
using System.Threading;

namespace eProposaleFaceTime
{

    class ePFull_TP_89339_eFacetime : eProposalSetup
    {
        public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public ePFull_TP_89339_eFacetime(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public ePFull_TP_89339_eFacetime() { }
 //       [SetUp]
 //        public static void Initialize()
 //        {
 //            TestPlanId = Constants.TP_89339;

        //            //Initialize the test case set up.
        //            InitializeSetup(TestPlanId, GetProjectName);

        //            //Assign the test data test plan file location
        //            //TestDataFile = TestDataLocation.TP_89339;

        //            //Navigate to the URL
        //            //Driver.Navigate().GoToUrl(LegacyTestData.CommonDemoURL);
        //            AddDelay(1500);
        //        }

        //        /* Testing in the ePFull project. */

        //        /* This test case will Verify eFacetime uses the correct VIPE link without using a database */

        //        [Test, Category("ePFull TP 89339 eFacetime")]
        //        public static void TC_87928()
        //        {
        //            try
        //            {
        //                /**Test execution - Start**/
        //                Legacy_SetupTestCase(Constants.TC_87928);

        //                //Start
        //                MainAdminApp.TP_89339();

        //                /**Test execution - End**/
        //                TestHandling.TestEnd();
        //            }
        //            catch (Exception e)
        //            {
        //                TestHandling.TestFailed(e);
        //                throw;
        //            }
        //        }

        //        /* This test case will Verify eFacetime uses the correct VIPE link by checking the database. */

        //        [Test, Category("ePFull TP 89339 eFacetime")]
        //        public static void TC_89354()
        //        {
        //            try
        //            {
        //                /**Test execution - Start**/
        //                Legacy_SetupTestCase(Constants.TC_89354);

        //                //Start
        //                MainAdminApp.TP_89339();

        //                /**Test execution - End**/
        //                TestHandling.TestEnd();
        //            }
        //            catch (Exception e)
        //            {
        //                TestHandling.TestFailed(e);
        //                throw;
        //            }
        //        }

        //        /* This test case will Validate adding one eFaceTime video to an existing folder. */

        //        [Test, Category("ePFull TP 89339 eFacetime")]
        //        public static void TC_90245()
        //        {
        //            try
        //            {
        //                /**Test execution - Start**/
        //                Legacy_SetupTestCase(Constants.TC_90245);

        //                //Start
        //                MainAdminApp.TP_89339();

        //                /**Test execution - End**/
        //                TestHandling.TestEnd();
        //            }
        //            catch (Exception e)
        //            {
        //                TestHandling.TestFailed(e);
        //                throw;
        //            }
        //        }

        //        /* This test case will Validate adding multiple eFaceTime videos to an existing folder. */

        //        [Test, Category("ePFull TP 89339 eFacetime")]
        //        public static void TC_90246()
        //        {
        //            try
        //            {
        //                /**Test execution - Start**/
        //                Legacy_SetupTestCase(Constants.TC_90246);

        //                //Start
        //                MainAdminApp.TP_89339();

        //                /**Test execution - End**/
        //                TestHandling.TestEnd();
        //            }
        //            catch (Exception e)
        //            {
        //                TestHandling.TestFailed(e);
        //                throw;
        //            }
        //        }

        //        /// <summary>
        //        /// Method is executed after every Test Script.
        //        /// </summary>
        //        [TearDown]
        //        public void Close()
        //        {
        //            TestHandling.TearDown();
        //        }
    }
}
