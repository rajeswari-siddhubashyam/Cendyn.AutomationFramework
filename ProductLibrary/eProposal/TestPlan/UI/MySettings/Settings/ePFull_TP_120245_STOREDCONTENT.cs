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

namespace eProposalStoredContent
{
    internal class ePFull_TP_120245_STOREDCONTENT : eProposalSetup
    {
        public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public ePFull_TP_120245_STOREDCONTENT(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public ePFull_TP_120245_STOREDCONTENT()
        { }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_120245;

            //Initialize the test case set up.
            InitializeSetup(TestPlanId, GetProjectName);

            //Assign the test data test plan file location
            //TestDataFile = TestDataLocation.TP_120245;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL);
            AddDelay(1500);
        }

        /* Testing in the ePFull project. */

        /* This test case will  Verify the module display names display correctly on the Stored Content.  */
        
        [Test, Category("ePFull TP 120245 MySettings Stored Content")]
        public static void TC_120246()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_120246);

                //Start
                MainAdminApp.TP_120245();

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
        ///     Method is executed after every Test Script.
        /// </summary>
        [TearDown]
        public void Close()
        {
            TestHandling.TearDown();
        }
    }
}