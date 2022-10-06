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

namespace ePFullActivity
{
    public class ePFull_TP_120480_ACTIVITY : eProposalSetup
    {
        public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public ePFull_TP_120480_ACTIVITY(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public ePFull_TP_120480_ACTIVITY()
        { }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_120480;

            //Initialize the test case set up.
            InitializeSetup(TestPlanId, GetProjectName);

            //Assign the test data test plan file location
            //TestDataFile = TestDataLocation.TP_120480;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL);
            AddDelay(1500);
        }


        /// <summary>
        ///     Method is executed after every Test Script.
        /// </summary>
        [TearDown]
        public void Close()
        {
            TestHandling.TearDown();
        }

        /* ePFull UI - Automation - Activity - Validate adding and editing clients when creating an eCard.. */
        
        [Test, Category("ePFull TP 120480 Activity")]
        public static void TC_120482()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_120482);

                //Start
                MainAdminApp.TP_120480();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* ePFull UI - Automation - Activity - Validate the eProposal columns "sort" correctly.*/
        
        [Test, Category("ePFull TP 120480 Activity")]
        public static void TC_120483()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_120483);

                //Start
                MainAdminApp.TP_120480();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* ePFull UI - Automation - Activity - Validate the eProposal columns "sort" correctly.*/
        
        [Test, Category("ePFull TP 120480 Activity")]
        public static void TC_120484()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_120484);

                //Start
                MainAdminApp.TP_120480();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* ePFull UI - Automation - Activity - Validate the eProposal columns "sort" correctly.*/
        
        [Test, Category("ePFull TP 120480 Activity")]
        public static void TC_120485()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_120485);

                //Start
                MainAdminApp.TP_120480();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* ePFull UI - Automation - Activity - Validate the eProposal columns "sort" correctly.*/
        
        [Test, Category("ePFull TP 120480 Activity")]
        public static void TC_120486()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_120486);

                //Start
                MainAdminApp.TP_120480();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* ePFull UI - Automation - Activity - Validate the eProposal columns "sort" correctly.*/
        
        [Test, Category("ePFull TP 120480 Activity")]
        public static void TC_120487()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_120487);

                //Start
                MainAdminApp.TP_120480();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* ePFull UI - Automation - Activity - Validate the eProposal columns "sort" correctly.*/
        
        [Test, Category("ePFull TP 120480 Activity")]
        public static void TC_120488()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_120488);

                //Start
                MainAdminApp.TP_120480();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* eProposal "Activity" Regression - Verify the "Currently Viewing" drop down menu.*/
        
        [Test, Category("ePFull TP 120480 Activity")]
        public static void TC_120489()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_120489);

                //Start
                MainAdminApp.TP_120480();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* eProposal "Activity" Regression - Verify the "Currently Viewing" drop down menu.
        
        [Test, Category("ePFull TP 120480 Activity")]
        public static void TC_120490()
        {
            try
            {
                /**Test execution - Start*
                Legacy_SetupTestCase(Constants.TC_120490);

                //Start
                MainAdminApp.TP_120480();

                /**Test execution - End*
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        } */

        /* ePFull UI - Automation - Activity - Validate the eProposal columns "sort" correctly.*/
        
        [Test, Category("ePFull TP 120480 Activity")]
        public static void TC_120491()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_120491);

                //Start
                MainAdminApp.TP_120480();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* ePFull UI - Automation - Activity - Validate the eProposal columns "sort" correctly.*/
        
        [Test, Category("ePFull TP 120480 Activity")]
        public static void TC_120492()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_120492);

                //Start
                MainAdminApp.TP_120480();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
    }
}