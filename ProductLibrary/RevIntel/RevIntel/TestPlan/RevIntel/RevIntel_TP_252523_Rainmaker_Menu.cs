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
    class RevIntel_TP_252523_Rainmaker_Menu : RevIntel.Utility.Setup
    {
        public RevIntel_TP_252523_Rainmaker_Menu(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        public RevIntel_TP_252523_Rainmaker_Menu() { }
        /// <summary>
        /// Method is used to initialised the test plan
        /// </summary>
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_252523;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_252523, Enums.ClientName.RevIntel, Enums.TestDataType.Controller, Enums.CaseType.NA, "RevIntel");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_121734;

            //Navigate to the URL
            Driver.Navigate().GoToUrl("https://revintelrhbi.godevcendyn.com");
            AddDelay(1500);
        }


        /// <summary>
        /// Verify the Role Maintenance only lists the roles that are available to the Tenant you logged in as
        /// </summary>
        [Test, Category("TP_252523_Rainmaker_Menu")]
        public static void TC_252552()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252552, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252523();

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
        /// Verify logged in user have access only to those reports that are accessible for the Role you logged in as
        /// </summary>
        [Test, Category("TP_252523_Rainmaker_Menu")]
        public static void TC_252553()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252553, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252523();


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
        /// Verify Subscription Support
        /// </summary>
        [Test, Category("TP_252523_Rainmaker_Menu")]
        public static void TC_252554()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252554, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252523();


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
        /// Verify the Sorting and filter functonality
        /// </summary>
        [Test, Category("TP_252523_Rainmaker_Menu")]
        public static void TC_253552()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_253552, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252523();


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
        /// Business Unit - Verify no duplicate classification name or code is allowed
        /// </summary>
        [Test, Category("TP_252523_Rainmaker_Menu")]
        public static void TC_254239()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_254239, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252523();


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
