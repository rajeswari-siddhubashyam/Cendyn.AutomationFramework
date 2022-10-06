using BaseUtility.Utility;
using RevIntel.Utility;
using NUnit.Framework;
using TestData;
using System;
using InfoMessageLogger;
using RevIntel.AppModule.MainAdminApp;
using OpenQA.Selenium;
using System.Threading;

namespace RevIntel
{
    class RevIntel_TP_290735_Compose : RevIntel.Utility.Setup
    {
        public RevIntel_TP_290735_Compose(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        public RevIntel_TP_290735_Compose() { }

        /// <summary>
        /// Method is used to initialised the test plan
        /// </summary>
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_290735;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_290735, Enums.ClientName.RevIntel, Enums.TestDataType.Controller, Enums.CaseType.NA, "RevIntel");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_121734;

            //Navigate to the URL
            Driver.Navigate().GoToUrl("https://devrhbi.revintel.co/");
            AddDelay(1500);
        }


        /// <summary>
         // Verify full screen functionality
        /// </summary>
        [Test, Category("TP_290735_Compose")]
        public static void TC_290742()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_290742, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_290735();

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
         //Verify the Cancel and close icon functionality in Create New Report popup
        /// </summary>
        [Test, Category("TP_290735_Compose")]
        public static void TC_290745()
        { 
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_290745, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_290735();

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
         //Verify the Create Report fails when Report name is empty
        /// </summary>
        [Test, Category("TP_290735_Compose")]
        public static void TC_290743()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_290743, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_290735();

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
         //Compose/New Report - Verify the Create Report fails when Report name is less than 3 characters
        /// </summary>
        [Test, Category("TP_290735_Compose")]
        public static void TC_290744()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_290744, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_290735();

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
         //Verify the Cancel and close icon functionality in Rename Report popup
        /// </summary>
        [Test, Category("TP_290735_Compose")]
        public static void TC_290751()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_290751, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_290735();

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
        //Verify the Rename functionality with out entering Report name
        /// </summary>
        [Test, Category("TP_290735_Compose")]
        public static void TC_290752()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_290752, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_290735();

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
        //Verify the Rename functionality by entering report name less than 3 characters
        /// </summary>
        [Test, Category("TP_290735_Compose")]
        public static void TC_290753()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_290753, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_290735();

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
        //Verify the Rename functionality and delete Functinality
        /// </summary>
        [Test, Category("TP_290735_Compose")]
        public static void TC_290754()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_290754, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_290735();

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
         //Verify the Cancel and close icon functionality in Rename Report popup
        /// </summary>
        [Test, Category("TP_290735_Compose")]
        public static void TC_290739()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_290739, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_290735();

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
        //Verify the Copy Report functionality
        /// </summary>
        [Test, Category("TP_290735_Compose")]
        public static void TC_290757()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_290757, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_290735();

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
