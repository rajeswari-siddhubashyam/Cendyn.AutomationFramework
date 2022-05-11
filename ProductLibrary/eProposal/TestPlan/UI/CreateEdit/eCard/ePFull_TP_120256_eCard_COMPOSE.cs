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


namespace eProposaleCard
{
    internal class ePFull_TP_120256_eCard_COMPOSE : eProposalSetup
    {
        public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public ePFull_TP_120256_eCard_COMPOSE(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_120256;

            //Initialize the test case set up.
            InitializeSetup(TestPlanId, GetProjectName);

            //Assign the test data test plan file location
            //TestDataFile = TestDataLocation.TP_120256;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL);
            AddDelay(1500);
        }

        /* Testing in the ePFull project. */

        /* This test case will Verify eCard media displays correctly and "Forward eCard" works correctly.  */
        
        [Test, Category("ePFull TP 120256 eCard Compose")]
        public static void TC_120257()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_120257);

                //Start                
                MainAdminApp.TP_120256();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will Verify Validate eCard.  */
        
        [Test, Category("ePFull TP 120256 eCard Compose")]
        public static void TC_120258()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_120258);

                //Start
                MainAdminApp.TP_120256();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* Disable Client Email update throughout the site - Verify email address is disabled under Create/Edit eProposal Edit client*/
        
        [Test, Category("ePFull TP 120256 eCard Compose")]
        public static void TC_120259()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_120259);

                //Start
                MainAdminApp.TP_120256();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* Disable Client Email update throughout the site - Verify email address is disabled under Create/Edit eCard Edit client*/
        
        [Test, Category("ePFull TP 120256 eCard Compose")]
        public static void TC_120260()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_120260);

                //Start
                MainAdminApp.TP_120256();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* Verify the auto-signatures on eCard.*/
        
        [Test, Category("ePFull TP 120256 eCard Compose")]
        public static void TC_120261()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_120261);

                //Start
                MainAdminApp.TP_120256();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* Verify the custom-signatures on eCard */
        
        [Test, Category("ePFull TP 120256 eCard Compose")]
        public static void TC_120262()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_120262);

                //Start
                MainAdminApp.TP_120256();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* Verify the "From" drop down is in alphabetical order.*/
        
        [Test, Category("ePFull TP 120256 eCard Compose")]
        public static void TC_120263()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_120263);

                //Start
                MainAdminApp.TP_120256();

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