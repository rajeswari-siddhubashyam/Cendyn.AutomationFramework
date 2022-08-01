using BaseUtility.Utility;
using InfoMessageLogger;
using CHC.AppModule.MainAdminApp;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TestData;
using Constants = CHC.Utility.Constants;

namespace CHC.TestPlan.Profile
{
    public class STR_TP_352298_Profile_QA : CHC.Utility.Setup
    {
        public STR_TP_352298_Profile_QA(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_352298;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_352298, Constants.clientEnv.CHCAutoQA, Enums.TestDataType.Controller, Enums.CaseType.NA, "CHCAuto");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            Thread.Sleep(6000);
        }

        /*  */
        [Test, Category("Smoke - QA")]
        public static void TC_314420()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_314420, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_352298();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  */
        [Test, Category("Smoke - QA")]
        public static void TC_314421()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_314421, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_352298();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  */
        [Test, Category("Smoke - QA")]
        public static void TC_314422()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_314422, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_352298();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  */
        [Test, Category("Smoke - QA")]
        public static void TC_314423()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_314423, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_352298();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  */
        [Test, Category("Smoke - QA")]
        public static void TC_314424()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_314424, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_352298();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  */
        [Test, Category("Smoke - QA")]
        public static void TC_314425()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_314425, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_352298();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  */
        [Test, Category("Smoke - QA")]
        public static void TC_314426()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_314426, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_352298();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  */
        [Test, Category("Smoke - QA")]
        public static void TC_314427()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_314427, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_352298();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /*  */
        //[Test, Category("Smoke - QA")]
        //public static void TC_314430()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_314430, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_352298();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}

        ///*  */
        //[Test, Category("Smoke - QA")]
        //public static void TC_329642()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_329642, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_352298();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}

        ///*  */
        //[Test, Category("Smoke - QA")]
        //public static void TC_326065()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_326065, "Excel", CHC.Utility.Constants.clientEnv.CHCAutoQA, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_352298();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}

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

