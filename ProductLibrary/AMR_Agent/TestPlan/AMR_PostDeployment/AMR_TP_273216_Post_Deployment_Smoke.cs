using AMR_Agent.AppModule.MainAdminApp;
using AMR_Agent.Utility;
using BaseUtility.Utility;
using InfoMessageLogger;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TestData;

/*
 * @Description: This contain test method for each test case defined inside a try catch block to handle exception
 *               and also method also contains steps which set execution result as pass and fail in the extend report.
 */

namespace AMR_Agent.TestPlans
{
    //[TestFixture]
    public class AMR_TP_273216_Post_Deployment_Smoke : AMR_Agent.Utility.Setup
    {
        public AMR_TP_273216_Post_Deployment_Smoke(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        /*
         * Method that is executed before every test.
         */
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_273216;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_273216, Enums.ClientName.AMR_Agent_Production, Enums.TestDataType.Controller, Enums.CaseType.NA, "AMR_Agent_Production");

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            HandleUnSafeWindows();
            AddDelay(1500);
        }

        
        /* Loyalty_Registration_CA_To verify Welcome to AMREWARDS email got generated successfully */
        [Test, NUnit.Framework.Category("AMR TP 38859 Smoke Tests"), NUnit.Framework.Category("Post Deployment")]
        public static void TC_281327()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_281327, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_273216();

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
