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

namespace eProposalRoomEventBlockComments
{
    
    public class ePFull_TP_84921_RoomEventBlockComments : eProposalSetup
    {
        public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public ePFull_TP_84921_RoomEventBlockComments(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_84921;

            //Initialize the test case set up.
            InitializeSetup(TestPlanId, GetProjectName);

            //Assign the test data test plan file location
            //TestDataFile = TestDataLocation.TP_84921;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL);
            AddDelay(1500);
        }


        /* Module Display Name - Verify the module display names display correctly on the Room/Event Block Comments */
        [Test, Category("ePFull TP 84921 MySettings Room and Event Block Comments")]
        public static void TC_61367()
        {
            try
            {
                LegacyTestData.CommonAdminEmail = "cendynautomation@cendyn.com";
                LegacyTestData.CommonAdminPassword = "Cendyn123$";
                LegacyTestData.CommonAdminURL = "https://demoadmin.proposalaccess.com/SiteAdminLogin.aspx";

                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_61367);

                //Start
                MainAdminApp.TP_84921();

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