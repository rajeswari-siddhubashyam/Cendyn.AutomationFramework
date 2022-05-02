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

namespace eProposalSignatures
{
    internal class ePFull_TP_120217_SIGNATURES : eProposalSetup
    {
        public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public ePFull_TP_120217_SIGNATURES(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

//        [SetUp]
//        public static void Initialize()
//        {
//            TestPlanId = Constants.TP_120217;

//            //Initialize the test case set up.
//            InitializeSetup(TestPlanId, GetProjectName);

//            //Assign the test data test plan file location
//            //TestDataFile = TestDataLocation.TP_120217;

//            //Navigate to the URL
//            Driver.Navigate().GoToUrl(LegacyTestData.CommonDemoURL);
//            AddDelay(1500);
//        }

//        /* Testing in the ePFull project. */

//        /* This test case will Validate when a "Custom Signature" is uploaded to a regular property.  */

//        [Test, Category("ePFull TP 120217 MySettings Signatures")]
//        public static void TC_120218()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_120218);

//                //Start
//                MainAdminApp.TP_120217();

//                /**Test execution - End**/
//                TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//        /* This test case will Validate when a "Custom Signature" is uploaded to a cluster property.  */

//        [Test, Category("ePFull TP 120217 MySettings Signatures")]
//        public static void TC_120219()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_120219);

//                //Start
//                MainAdminApp.TP_120217();

//                /**Test execution - End**/
//                TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//        /* This test case will Validate when a "Custom Signature" is uploaded to a CVB property. */

//        [Test, Category("ePFull TP 120217 MySettings Signatures")]
//        public static void TC_120220()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_120220);

//                //Start
//                MainAdminApp.TP_120217();

//                /**Test execution - End**/
//                TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//        /* This test case will Validate when a "Custom Signature" is uploaded to a GSO property. */

//        [Test, Category("ePFull TP 120217 MySettings Signatures")]
//        public static void TC_120221()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_120221);

//                //Start
//                MainAdminApp.TP_120217();

//                /**Test execution - End**/
//                TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//        /* This test case will Validate when a "Custom Signature" is uploaded to a SSO property. */

//        [Test, Category("ePFull TP 120217 MySettings Signatures")]
//        public static void TC_120222()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_120222);

//                //Start
//                MainAdminApp.TP_120217();

//                /**Test execution - End**/
//                TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//        /* Verify the "Custom Signature" on the eProposal preview and sent eProposal pages for a regular property. */

//        [Test, Category("ePFull TP 120217 MySettings Signatures")]
//        public static void TC_120223()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_120223);

//                //Start
//                MainAdminApp.TP_120217();

//                /**Test execution - End**/
//                TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//        /* Verify the "Custom Signature" on the eProposal preview and sent eProposal pages for a Cluster property. */

//        [Test, Category("ePFull TP 120217 MySettings Signatures")]
//        public static void TC_120224()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_120224);

//                //Start
//                MainAdminApp.TP_120217();

//                /**Test execution - End**/
//                TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//        /* Verify the "Custom Signature" on the eProposal preview and sent eProposal pages for a CVB property. */

//        [Test, Category("ePFull TP 120217 MySettings Signatures")]
//        public static void TC_120225()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_120225);

//                //Start
//                MainAdminApp.TP_120217();

//                /**Test execution - End**/
//                TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//        /* Verify the "Custom Signature" on the eProposal preview and sent eProposal pages for a SSO property. */

//        [Test, Category("ePFull TP 120217 MySettings Signatures")]
//        public static void TC_120227()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_120227);
//                //Start
//                MainAdminApp.TP_120217();

//                /**Test execution - End**/
//                TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//        /* Validate removing the "Custom Signature" */

//        [Test, Category("ePFull TP 120217 MySettings Signatures")]
//        public static void TC_120228()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_120228);

//                //Start
//                MainAdminApp.TP_120217();

//                /**Test execution - End**/
//                TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//        /* Validate removing the "Custom Signature" */

//        [Test, Category("ePFull TP 120217 MySettings Signatures")]
//        public static void TC_120229()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_120229);

//                //Start
//                MainAdminApp.TP_120217();

//                /**Test execution - End**/
//                TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//        /* Validate updating "Custom Signature" from the "View All" tab. */

//        [Test, Category("ePFull TP 120217 MySettings Signatures")]
//        public static void TC_120230()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_120230);

//                //Start
//                MainAdminApp.TP_120217();

//                /**Test execution - End**/
//                TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//        /* Validate when a "Custom Signature" is uploaded. (Foreign Language) */

//        [Test, Category("ePFull TP 120217 MySettings Signatures")]
//        public static void TC_120231()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_120231);

//                //Start
//                MainAdminApp.TP_120217();

//                /**Test execution - End**/
//                TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//        /* Validate when a "Custom Signature" is NOT uploaded. (Foreign Language) */

//        [Test, Category("ePFull TP 120217 MySettings Signatures")]
//        public static void TC_120232()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_120232);

//                //Start
//                MainAdminApp.TP_120217();

//                /**Test execution - End**/
//                TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//        /* Verify when no "Custom Signature" is used on backend and frontend. */

//        [Test, Category("ePFull TP 120217 MySettings Signatures")]
//        public static void TC_120233()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_120233);

//                //Start
//                MainAdminApp.TP_120217();

//                /**Test execution - End**/
//                TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//        /* Validate "Custom Signature" size. */

//        [Test, Category("ePFull TP 120217 MySettings Signatures")]
//        public static void TC_120234()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_120234);

//                //Start
//                MainAdminApp.TP_120217();

//                /**Test execution - End**/
//                TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//        /* Verify the auto-signatures generate when changed on admin */

//        [Test, Category("ePFull TP 120217 MySettings Signatures")]
//        public static void TC_120235()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_120235);

//                //Start
//                MainAdminApp.TP_120217();

//                /**Test execution - End**/
//                TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//        /* Verify the custom-signatures generate when changed on admin */

//        [Test, Category("ePFull TP 120217 MySettings Signatures")]
//        public static void TC_120236()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_120236);

//                //Start
//                MainAdminApp.TP_120217();

//                /**Test execution - End**/
//                TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//        /*  Verify the auto-signatures on eCard */

//        [Test, Category("ePFull TP 120217 MySettings Signatures")]
//        public static void TC_120237()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_120237);

//                //Start
//                MainAdminApp.TP_120217();

//                /**Test execution - End**/
//                TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//        /*   Verify the custom-signatures on eCard. */

//        [Test, Category("ePFull TP 120217 MySettings Signatures")]
//        public static void TC_120238()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_120238);

//                //Start
//                MainAdminApp.TP_120217();

//                /**Test execution - End**/
//                TestHandling.TestEnd();
//            }
//            catch (Exception e)
//            {
//                TestHandling.TestFailed(e);
//                throw;
//            }
//        }

//        /* Validate uploading an invalid file type to "Custom Signature" */

//        [Test, Category("ePFull TP 120217 MySettings Signatures")]
//        public static void TC_120239()
//        {
//            try
//            {
//                /**Test execution - Start**/
//                Legacy_SetupTestCase(Constants.TC_120239);

//                //Start
//                MainAdminApp.TP_120217();

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
//        ///     Method is executed after every Test Script.
//        /// </summary>
//        [TearDown]
//        public void Close()
//        {
//            TestHandling.TearDown();
//        }
    }
}