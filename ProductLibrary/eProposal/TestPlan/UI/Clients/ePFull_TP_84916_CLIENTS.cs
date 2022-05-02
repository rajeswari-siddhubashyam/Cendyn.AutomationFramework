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


namespace eProposalClients
{
    public class ePFull_TP_84916_CLIENTS : eProposalSetup
    {
        public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public ePFull_TP_84916_CLIENTS(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_84916;

            //Initialize the test case set up.
            InitializeSetup(TestPlanId, GetProjectName);

            //Assign the test data test plan file location
            //TestDataFile = TestDataLocation.TP_84916;

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

        /* ePFull UI - Automation - Clients - Validate adding and editing clients through the Clients tab. */
        
        [Test, Category("ePFull TP 84916 Clients")]
        public static void TC_120548()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_120548);

                //Start
                MainAdminApp.TP_84916();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* ePFull UI - Automation - Clients - Validate adding and editing clients when creating an eProposal. */
        
        [Test, Category("ePFull TP 84916 Clients")]
        public static void TC_120549()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_120549);

                //Start
                MainAdminApp.TP_84916();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* ePFull UI - Automation - Clients - Validate adding and editing clients when creating an eCard. */
        
        [Test, Category("ePFull TP 84916 Clients")]
        public static void TC_120550()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_120550);

                //Start
                MainAdminApp.TP_84916();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* ePFull UI - Automation - Clients - Validate adding a client that already exist through an eProposal, eCard and the Clients tab. */
        
        [Test, Category("ePFull TP 84916 Clients")]
        public static void TC_120554()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_120554);

                //Start
                MainAdminApp.TP_84916();

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