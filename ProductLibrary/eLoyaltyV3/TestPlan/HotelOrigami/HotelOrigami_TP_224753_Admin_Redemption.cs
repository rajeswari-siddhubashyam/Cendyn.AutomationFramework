using TestData;
using NUnit.Framework;
using System;
using InfoMessageLogger;
using eLoyaltyV3.AppModule.MainAdminApp;
using BaseUtility.Utility;
using TestData.ExcelData;
using eLoyaltyV3.Utility;
using System.Threading;
using OpenQA.Selenium;

namespace HotelOrigami
{
    class HotelOrigami_TP_224753_Admin_Redemption : eLoyaltyV3.Utility.Setup
    {
        public HotelOrigami_TP_224753_Admin_Redemption(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            //Initialize the test case set up.
            InitializeSetup(Constants.TP_224753, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            //  Drivers.Value.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
        }

        /* This test case To erify that Awards with past date doesn't displays on front end. */
        [Test, Category("Regression")]
        public static void TC_146567()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_146567, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                //Start
                MainAdminApp.TP_224753();

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
        /// This test case To Validate clicking cancel from confirm pop-up
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_146564()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_146564, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                //Start
                MainAdminApp.TP_224753();

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
        /// This test case To Verify that Awards with past date doesn't displays on front end
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_149354()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_149354, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                //Start
                MainAdminApp.TP_224753();

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
        /// This test case To Verify redemption for same award multiple times
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_146568()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_146568, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                //Start
                MainAdminApp.TP_224753();

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
        /// This test case To Validate successful redemption of any award
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_146563()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_146563, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                //Start
                MainAdminApp.TP_224753();

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
        /// This test case To Validate Award created for one member level
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_149352()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_149352, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                //Start
                MainAdminApp.TP_224753();

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
        /// This test case To Validate Award created for multiple member level
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_149351()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_149351, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                //Start
                MainAdminApp.TP_224753();

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
        /// This test case To Validate Award created for all member level
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_149349()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_149349, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                //Start
                MainAdminApp.TP_224753();

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
        /// This test case To Validate Cancel for Redeemed Award
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_149357()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_149357, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                //Start
                MainAdminApp.TP_224753();

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
        /// This test case To Validate Redemption when Award Point > Points Balance
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_124627()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_124627, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                //Start
                MainAdminApp.TP_224753();

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
        /// This test case To Validate Redemption when Award Point = Points Balance
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_124625()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_124625, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                //Start
                MainAdminApp.TP_224753();

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
        /// This test case To Validate Redemption when Award Point < Points Balance
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_124626()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_124626, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                //Start
                MainAdminApp.TP_224753();

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
        /// This test case To Verify voucher details email template received after redemption
        /// </summary>

        [Test, Category("Regression")]
        public static void TC_175101()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_175101, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                //Start
                MainAdminApp.TP_224753();

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
