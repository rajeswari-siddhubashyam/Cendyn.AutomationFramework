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

namespace eLoyaltyV3.TestPlan.HotelOrigami.WindowsServices.Scenario_Validation
{
    class HotelOrigami_TP_294919_Service_Scenario_Validation : eLoyaltyV3.Utility.Setup
    {
        public HotelOrigami_TP_294919_Service_Scenario_Validation(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_294919;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_294919, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami_Service");

        }

        /// <summary>
        /// Inactive rules from 1 to 4
        /// </summary>
        [Test, Category("Service Testing"), Order(36)]
        public static void TC_InactiveRules1_4()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_InactiveRules1_4, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.Service_Pre_Requisite();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }


        [Test, Category("Service Testing"), Order(37)]
        public static void TC_InsertStay21_42()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_InsertStay21_42, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.Service_Pre_Requisite();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Service Testing"), Order(38)]
        public static void TC_294921()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294921, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_294919();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Service Testing"), Order(39)]
        public static void TC_294922()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294922, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_294919();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Service Testing"), Order(40)]
        public static void TC_294923()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294923, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_294919();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }


        [Test, Category("Service Testing"), Order(41)]
        public static void TC_294924()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294924, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_294919();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Service Testing"), Order(42)]
        public static void TC_294925()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294925, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_294919();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Service Testing"), Order(43)]
        public static void TC_294926()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294926, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_294919();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Service Testing"), Order(44)]
        public static void TC_294927()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294927, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_294919();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Service Testing"), Order(45)]
        public static void TC_294928()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294928, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_294919();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Service Testing"), Order(46)]
        public static void TC_294929()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294929, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_294919();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Service Testing"), Order(47)]
        public static void TC_294930()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294930, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_294919();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Service Testing"), Order(48)]
        public static void TC_294931()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294931, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_294919();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Service Testing"), Order(49)]
        public static void TC_294932()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294932, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_294919();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Service Testing"), Order(50)]
        public static void TC_294933()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294933, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_294919();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Service Testing"), Order(51)]
        public static void TC_294935()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294935, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_294919();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        [Test, Category("Service Testing"), Order(52)]
        public static void TC_294934()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294934, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_294919();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        [Test, Category("Service Testing"), Order(53)]
        public static void TC_294936()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294936, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_294919();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Service Testing"), Order(54)]
        public static void TC_294937()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294937, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_294919();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Service Testing"), Order(55)]
        public static void TC_294938()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294938, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_294919();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }


        [Test, Category("Service Testing"), Order(56)]
        public static void TC_294939()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294939, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_294919();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }


        [Test, Category("Service Testing"), Order(57)]
        public static void TC_294940()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294940, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_294919();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Service Testing"), Order(58)]
        public static void TC_294941()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294941, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_294919();

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Service Testing"), Order(59)]
        public static void TC_294942()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_294942, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_294919();

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