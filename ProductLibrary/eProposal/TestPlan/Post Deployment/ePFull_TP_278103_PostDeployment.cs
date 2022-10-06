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


namespace eProposalPostDeployment
{
    public class ePFull_TP_278103_PostDeployment : eProposalSetup
    {
        public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public ePFull_TP_278103_PostDeployment(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        public ePFull_TP_278103_PostDeployment() { }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_278103;

            //Initialize the test case set up.
            InitializeSetup(TestPlanId, GetProjectName);

            //Assign the test data test plan file location
            //TestDataFile = TestDataLocation.TP_84916;

            //Open Catchall
            //Driver.Navigate().GoToUrl("https://login.microsoftonline.com/");

            //OpenNewTab();
            //ControlToNewWindow();
            //Navigate to the URL
            Driver.Navigate().GoToUrl("https://cendynaccess.com/");
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

        /* ePFull - eProposal Post deployment plan */

        /* ePFull - eProposal - Employee Login - Verify user is able to login successfully. */

        [Test, Category("ePFull TP 278103 Post Deployment")]
        public static void TC_278105()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_278105);

                //Start
                MainAdminApp.TP_278103();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* ePFull - eProposal - Employee Login - Verify user is able to logout successfully. */

        [Test, Category("ePFull TP 278103 Clients")]
        public static void TC_278106()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_278106);

                //Start
                MainAdminApp.TP_278103();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* ePFull - eProposal - Employee Login - Validate navigation - Validate navigation to Create/Edit eProposal */

        [Test, Category("ePFull TP 278103 Clients")]
        public static void TC_278107()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_278107);

                //Start
                MainAdminApp.TP_278103();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* ePFull - eProposal - Employee Login - Validate navigation - Validate navigation to Create/Edit eCard */

        [Test, Category("ePFull TP 278103 Clients")]
        public static void TC_278108()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_278108);

                //Start
                MainAdminApp.TP_278103();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* ePFull - eProposal - Employee Login - Validate navigation - Validate navigation to Create/Edit Video. */

        [Test, Category("ePFull TP 278103 Clients")]
        public static void TC_278109()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_278109);

                //Start
                MainAdminApp.TP_278103();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* ePFull - eProposal - Employee Login - Validate navigation - Validate navigation to Client. */

        [Test, Category("ePFull TP 278103 Clients")]
        public static void TC_278110()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_278110);

                //Start
                MainAdminApp.TP_278103();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* ePFull - eProposal - Employee Login - Create/Edit eProposal */

        [Test, Category("ePFull TP 278103 Clients")]
        public static void TC_99106()
        {
            try
            {
                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_99106);

                //Start
                MainAdminApp.TP_278103();

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