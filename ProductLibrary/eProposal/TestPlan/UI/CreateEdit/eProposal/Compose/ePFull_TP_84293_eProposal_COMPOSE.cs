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


namespace eProposalCreateCompose
{
    
    public class ePFull_TP_84293_eProposal_COMPOSE : eProposalSetup
    {
        public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public ePFull_TP_84293_eProposal_COMPOSE(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public ePFull_TP_84293_eProposal_COMPOSE()
        { }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_84293;

            //Initialize the test case set up.
            InitializeSetup(TestPlanId, GetProjectName);

            //Assign the test data test plan file location
            //TestDataFile = TestDataLocation.TP_84293;

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


        /* Testing in the ePFull project. */

        /* This test case will validate the Event Date and Proposal Expires fields and verify they display correctly on the proposal.    */
        
        [Test, Category("ePFull TP 84293 eProposal Compose")]
        public static void TC_120442()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_120442);

                //Start
                MainAdminApp.TP_84293();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will validate the "Use My Favorite Settings" feature.    */
        
        [Test, Category("ePFull TP 84293 eProposal Compose")]
        public static void TC_120443()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_120443);

                //Start
                MainAdminApp.TP_84293();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* On click, the stored data should be inserted into the "Welcome Message" text box.   */
        
        [Test, Category("ePFull TP 84293 eProposal Compose")]
        public static void TC_120446()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_120446);

                //Start
                MainAdminApp.TP_84293();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will validate the features that are displayed on the eProposal.   
         * Offer at bottom of letter
         * Welcome message
         * Message closing
         * Add Client Logo
         */
        
        [Test, Category("ePFull TP 84293 eProposal Compose")]
        public static void TC_120447()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_120447);

                //Start
                MainAdminApp.TP_84293();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* The language field should be a label with the correct language displayed. */
        
        [Test, Category("ePFull TP 84293 eProposal Compose")]
        public static void TC_120454()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_120454);

                //Start
                MainAdminApp.TP_84293();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will cover all features and functions of the eProposal Compose page. 
         * "eProposal Name" field only accepts up to 250 characters.
         * "From" field displays the current logged in client by default.
         * "From" field is in alphabetical order.
         * BCC field only accepts up to 1024 characters.
         * CC field only accepts up to 1024 characters.
         */
        
        [Test, Category("ePFull TP 84293 eProposal Compose")]
        public static void TC_123287()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_123287);

                //Start
                MainAdminApp.TP_84293();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  Validate the "Proposal Expires On". */
        
        [Test, Category("ePFull TP 84293 eProposal Compose")]
        public static void TC_84289()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_84289);

                //Start
                MainAdminApp.TP_84293();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }       

        /*  Validate the "Event Date" Validate the "Event Date" */
        
        [Test, Category("ePFull TP 84293 eProposal Compose")]
        public static void TC_84277()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_84277);

                //Start
                MainAdminApp.TP_84293();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  Validate the "Add Client's Logo" upload button. */
        
        [Test, Category("ePFull TP 84293 eProposal Compose")]
        public static void TC_84288()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_84288);

                //Start
                MainAdminApp.TP_84293();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  Validate the "Message Closing" field with custom message. */
        
        [Test, Category("ePFull TP 84293 eProposal Compose")]
        public static void TC_84287()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_84287);

                //Start
                MainAdminApp.TP_84293();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        
        [Test, Category("ePFull TP 84293 eProposal Compose")]
        public static void TC_84274()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_84274);

                //Start
                MainAdminApp.TP_84293();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        
        [Test, Category("ePFull TP 84293 eProposal Compose")]
        public static void TC_84272()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_84272);

                //Start
                MainAdminApp.TP_84293();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        
        [Test, Category("ePFull TP 84293 eProposal Compose")]
        public static void TC_84273()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_84273);

                //Start
                MainAdminApp.TP_84293();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        
        
        [Test, Category("ePFull TP 84293 eProposal Compose")]
        public static void TC_84275()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_84275);

                //Start
                MainAdminApp.TP_84293();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        
        [Test, Category("ePFull TP 84293 eProposal Compose")]
        public static void TC_84276()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_84276);

                //Start
                MainAdminApp.TP_84293();

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