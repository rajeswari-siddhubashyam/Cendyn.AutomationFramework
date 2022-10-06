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
    public class AMR_TP_38859_SMOKETESTS : AMR_Agent.Utility.Setup
    {
        public AMR_TP_38859_SMOKETESTS()
        { }

        /*
         * Method that is executed before every test.
         */
        public AMR_TP_38859_SMOKETESTS(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_38859;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_38859, Enums.ClientName.AMR_Agent, Enums.TestDataType.Controller, Enums.CaseType.NA, "AMR_Agent");
            
            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            HandleUnSafeWindows();
            AddDelay(1500);
        }

        /* Loyalty_Registration_US_Verify Successful registrant of a US agent_Smoke
         * Verify  and US Agent is able to  register and login Successfully 
         */
        [Test, NUnit.Framework.Category("AMR TP 38859 Smoke Tests")]
        public static void TC_27838()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_27838, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_38859();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will verify that the Password is recovered successfully using security question. */
        [Test, NUnit.Framework.Category("AMR TP 38859 Smoke Tests")]
        public static void TC_37518()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_37518, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_38859();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* AMR Loyality_To Verify Popup should be display for W9 Completion request when agent tries to navigate to My Redemption Page */
        [Test, NUnit.Framework.Category("AMR TP 38859 Smoke Tests")]
        public static void TC_37539()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_37539, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_38859();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* AMR Loyality_To verify user should able to Submit Booking successfully for Not Yet Traveled  */
        [Test, NUnit.Framework.Category("AMR TP 38859 Smoke Tests")]
        public static void TC_37548()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_37548, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_38859();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* AMR Loyality_To verify user should able to Edit Booking is successful. */
        [Test, NUnit.Framework.Category("AMR TP 38859 Smoke Tests")]
        public static void TC_37550()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_37550, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_38859();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* AMR Loyality_To verify User not able to enter booking that already exists should confirmation popup */
        [Test, NUnit.Framework.Category("AMR TP 38859 Smoke Tests")]
        public static void TC_37553()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_37553, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_38859();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* AMR Loyality_To verify all Links in AMRewards Page should be working right */
        [Test, NUnit.Framework.Category("AMR TP 38859 Smoke Tests")]
        public static void TC_37604()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_37604, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);
                
                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_38859();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* AMR Loyality_To verify successfully SSN should be update for newly registered agent */
        [Test, NUnit.Framework.Category("AMR TP 38859 Smoke Tests")]
        public static void TC_37609()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_37609, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_38859();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* Loyalty_Registration_CA_To verifies that Canada agent with TIDS and TICO affiliation is registered successfully. */
        [Test, NUnit.Framework.Category("AMR TP 38859 Smoke Tests")]
        public static void TC_37513()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_37513, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_38859();

                /**Test execution - End**/
                TestHandling.TestEnd();
                
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* Loyalty_Registration_CA_To To verify Password is recover successfully using verification code received through email_smoke. */
        [Test, NUnit.Framework.Category("AMR TP 38859 Smoke Tests")]
        public static void TC_37522()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_37522, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_38859();

                /**Test execution - End**/
                TestHandling.TestEnd();

            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* Loyalty_Registration_CA_To verify Welcome to AMREWARDS email got generated successfully */
        [Test, NUnit.Framework.Category("AMR TP 38859 Smoke Tests")]
        public static void TC_37649()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_37649, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_38859();

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
