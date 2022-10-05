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
    class HotelOrigami_TP_AutoIT_TestCases : eLoyaltyV3.Utility.Setup
    {
        public HotelOrigami_TP_AutoIT_TestCases(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public HotelOrigami_TP_AutoIT_TestCases()
        {
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_AutoIT;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_AutoIT, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");


            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
            AddDelay(1500);
        }

        /// <summary>
        /// This test case will Verify required field functionality
        /// </summary>

        [Test, Category("AutoIT")]
        public static void TC_109684()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_109684, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_AutoIT();

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
        /// This test case will Verify Asci code validation
        /// </summary>

        [Test, Category("AutoIT")]
        public static void TC_109686()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_109686, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_AutoIT();

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
        /// This test case will Validate Successful addition of Offer with only mandatory fields
        /// </summary>

        [Test, Category("AutoIT")]
        public static void TC_109688()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_109688, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_AutoIT();

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
        /// This test case will Validate Cancel button functionality while adding a offer
        /// </summary>

        [Test, Category("AutoIT")]
        public static void TC_109689()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_109689, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_AutoIT();

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
        /// This test case will Validate message when Start Date > End Date
        /// </summary>

        [Test, Category("AutoIT")]
        public static void TC_109750()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_109750, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_AutoIT();

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
        /// This test case will Verify Max Character Limit
        /// </summary>

        [Test, Category("AutoIT")]
        public static void TC_109685()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_109685, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_AutoIT();

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
        /// This test case will Verify the offer status
        /// </summary>

        [Test, Category("AutoIT")]
        public static void TC_109667()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_109667, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_AutoIT();

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
        /// This test case will Verify the File Name on Contact US page.
        /// </summary>

        [Test, Category("AutoIT")]
        public static void TC_224924()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_224924, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                //Start
                MainAdminApp.TP_AutoIT();

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
        /// This test case will Verify file upload functionality when User select file size more than 2 MB
        /// </summary>

        [Test, Category("AutoIT")]
        public static void TC_238611()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_238611, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                //Start
                MainAdminApp.TP_AutoIT();

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
        /// This test case will Verify that user is getting validation message when tries to upload more than 5 files
        /// </summary>

        [Test, Category("AutoIT")]
        public static void TC_237552()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_237552, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                //Start
                MainAdminApp.TP_AutoIT();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /*This test case will Verify Successful addition and Updte Offer with all fields - [Origami] Mergin of TC_109687, TC_109699, TC_119992 */
        [Test, Category("AutoIT")]
        public static void TC_109687()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_109687, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_AutoIT();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }


        /* This test case will Verify PII encryption information in emails - [Origami] */
        [Test, Category("AutoIT")]
        public static void TC_239389()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_239389, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_AutoIT();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /* This test case will verify the email in catchall after successfully uploaded the member via member batch upload */
        [Test, Category("AutoIT")]
        public static void TC_218599()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_218599, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_AutoIT();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /* This test case will validate the member batch upload functionality */
        [Test, Category("AutoIT")]
        public static void TC_218604()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_218604, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_AutoIT();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /* This test case will  Verify add user with all details of the users*/
        [Test, Category("AutoIT")]
        public static void TC_227232()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_227232, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_AutoIT();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /* This test case will Verify that added promotion from the admin wil be displayed in frontend Exclusive offer page for Authenticated */
        [Test, Category("AutoIT")]
        public static void TC_116201()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_116201, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_AutoIT();

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
