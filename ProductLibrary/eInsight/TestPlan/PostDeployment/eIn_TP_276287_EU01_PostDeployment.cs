using System;
using NUnit.Framework;
using eInsight.AppModule.MainAdminApp;
using BaseUtility.Utility;
using eInsight.AppModule.UI;
using System.Text.RegularExpressions;
using InfoMessageLogger;
using Constants = eInsight.Utility.Constants;
using LegacyTestData = eInsight.Utility.LegacyTestData;
using eInsightSetup = eInsight.Utility.Setup;
using OpenQA.Selenium;
using System.Threading;

namespace eInsightEU01PostDeployment
{
    class eIn_TP_276287_EU01_PostDeployment : eInsightSetup
    {

        public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;

        public eIn_TP_276287_EU01_PostDeployment(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_276287;

            //Initialize the test case set up.
            InitializeSetup(TestPlanId, GetProjectName);

        }

      
        [Category("EU01_PostDeployment")]
        [Test]
        public static void TC_129807()
        {
            try
            {
                testCategory = "EU01_PostDeployment";

                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_129807);


                Logger.DeleteOldFolder();
                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);


                    //Start
                    MainAdminApp.TP_276287();


                    RenewDriver();
                }


                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        //eIn - Global - Realtime Tab - Show All - Verify the show all functionality
        [Test, Category("EU01_PostDeployment")]
        public static void TC_130057()
        {
            try
            {
                testCategory = "EU01_PostDeployment";

                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_130057);


                Logger.DeleteOldFolder();
                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);


                    //Start
                    MainAdminApp.TP_276287();


                    RenewDriver();
                }


                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }


        [Test, Category("EU01_PostDeployment")]
        public static void TC_251664()
        {
            try
            {
                testCategory = "EU01_PostDeployment";

                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_251664);


                Logger.DeleteOldFolder();
                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);


                    //Start
                    MainAdminApp.TP_276287();


                    RenewDriver();
                }


                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }


        [Test, Category("EU01_PostDeployment")]
        public static void TC_276301()
        {
            try
            {
                testCategory = "EU01_PostDeployment";

                /**Test execution - Start**/
                Legacy_SetupTestCase(Constants.TC_276301);


                Logger.DeleteOldFolder();
                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");
                foreach (string frontendURL in eachFrontEndURL)
                {
                    Login.CommonLogin(frontendURL);


                    //Start
                    MainAdminApp.TP_276287();


                    RenewDriver();
                }


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
        public void Quit()
        {
            TestHandling.TearDown();
        }

    }
}
