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

namespace eInsightCampaignSubjectLine
{
    
    public class eIn_TP_174295_Campaign_SubjectLine : eInsightSetup
    {
        public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public eIn_TP_174295_Campaign_SubjectLine(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {

            TestPlanId = Constants.TP_174295;

            //Initialize the test case set up.

            InitializeSetup(TestPlanId,GetProjectName);

            //TestDataFile = TestDataLocation.TP_174295;

            AddDelay(8000);

            //Can use this to update the URL Manually
            //LegacyTestData.CommonFrontendURL = "https://poceinsight.cendyn.com/";
        }

        [Test, Category("Regression"), Order(1)]

        public static void TC_174296()

        {

            try

            {

                /**Test execution - Start**/

                Legacy_SetupTestCase(Constants.TC_174296);



                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");

                foreach (string frontendURL in eachFrontEndURL)

                {

                    Login.CommonLogin(frontendURL);



                    //Start

                    MainAdminApp.TP_174295();



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

        [Test, Category("Regression"), Order(4)]

        public static void TC_174312()

        {

            try

            {

                /**Test execution - Start**/

                Legacy_SetupTestCase(Constants.TC_174312);



                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");

                foreach (string frontendURL in eachFrontEndURL)

                {

                    Login.CommonLogin(frontendURL);



                    //Start

                    MainAdminApp.TP_174295();



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

        [Test, Category("Regression"), Order(2)]

        public static void TC_174320()

        {

            try

            {

                /**Test execution - Start**/

                Legacy_SetupTestCase(Constants.TC_174320);



                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");

                foreach (string frontendURL in eachFrontEndURL)

                {

                    Login.CommonLogin(frontendURL);



                    //Start

                    MainAdminApp.TP_174295();



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

        [Test, Category("Regression"), Order(3)]

        public static void TC_174328()

        {

            try

            {

                /**Test execution - Start**/

                Legacy_SetupTestCase(Constants.TC_174328);



                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");

                foreach (string frontendURL in eachFrontEndURL)

                {

                    Login.CommonLogin(frontendURL);



                    //Start

                    MainAdminApp.TP_174295();



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

        public static void TC_174338()

        {

            try

            {

                /**Test execution - Start**/

                Legacy_SetupTestCase(Constants.TC_174338);



                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");

                foreach (string frontendURL in eachFrontEndURL)

                {

                    Login.CommonLogin(frontendURL);



                    //Start

                    MainAdminApp.TP_174295();



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

        public static void TC_174345()

        {

            try

            {

                /**Test execution - Start**/

                Legacy_SetupTestCase(Constants.TC_174345);



                Logger.DeleteOldFolder();

                string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ", ");

                foreach (string frontendURL in eachFrontEndURL)

                {

                    Login.CommonLogin(frontendURL);



                    //Start

                    MainAdminApp.TP_174295();



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
