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
    class RevIntel_TP_252700_Business_source : RevIntel.Utility.Setup
    {
        //public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public RevIntel_TP_252700_Business_source(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_252700;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_252700, Enums.ClientName.RevIntel, Enums.TestDataType.Controller, Enums.CaseType.NA, "RevIntel");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_121734;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            AddDelay(1500);
        }
       
        /// <summary>
        /// This test case will Validate the Agent Analysis report (no filter)
        /// </summary>
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_252718()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252718, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252700();
           

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
        /// This test case will  Validate the Agent Summary report
        /// </summary>
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_252719()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252719, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252700();


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
        /// This test case will Validate the Agent Room Type Analysis report
        /// </summary>
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_252720()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252720, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252700();


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
        /// This test case will Validate the Annual Agent Analysis by Month report
        /// </summary>
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_252721()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252721, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252700();


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
        /// This test case will Validate the Company Analysis report
        /// </summary>
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_252722()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252722, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252700();


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
        /// This test case will Validate the Annual Company Analysis by Month report
        /// </summary>
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_252723()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252723, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252700();


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
        /// This test case will  Validate the Company Summary report
        /// </summary>
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_252724()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252724, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252700();


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
        /// This test case will Validate the Agent Analysis report (one filter)
        /// </summary>
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_256851()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_256851, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252700();


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
        /// This test case will Validate the Agent Analysis report (multiple filter)
        /// </summary>
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_256852()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_256852, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252700();


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
        /// Validate the Parent Company Analysis report
        /// </summary>
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_252725()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252725, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252700();


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
        /// Validate the Parent Travel Agent Analysis report
        /// </summary>
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_252726()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252726, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252700();


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
        ///  Validate the Agent Period Summary (RHBI) report
        /// </summary>
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_252727()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252727, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252700();


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
        /// Validate the Company Period Summary (RHBI) report
        /// </summary>
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_252728()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252728, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252700();


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
        /// Validate the Agent Trend Report
        /// </summary>
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_252729()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252729, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252700();


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
        /// Validate the Company Trend Report
        /// </summary>
        [Test, Category("RevIntel_TP_251469_SmokeTest")]
        public static void TC_264418()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_264418, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252700();


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
