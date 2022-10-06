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
    class HotelOrigami_TP_276897_Service_Scenario_Validation : eLoyaltyV3.Utility.Setup
    {
        public HotelOrigami_TP_276897_Service_Scenario_Validation()
        { }
        public HotelOrigami_TP_276897_Service_Scenario_Validation(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_276897;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_276897, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami_Service");
                    
        }
        /// <summary>
        /// This test case will Create User Using Batch Registration
        /// </summary>

        // [Test, Category("Service Testing")]
        public static void TC_CreateUser_UpdateRegistrationDate()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_CreateUser_UpdateRegistrationDate, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

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
        /// <summary>
        /// This test case will Update Existing Qualifying Rule
        /// </summary>

        [Test, Category("Service Testing"),Order(2)]
        public static void TC_UpdateQualifyingRuleFor_1to12()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_UpdateQualifyingRuleFor_1to12, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

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
        /// <summary>
        /// This test case will Update Existing Qualifying Rule
        /// </summary>

        [Test, Category("Service Testing"), Order(17)]
        public static void TC_UpdateQualifyingRuleFor_13to29()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_UpdateQualifyingRuleFor_13to29, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

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
        /// <summary>
        /// This test case will Insert Points Earning Rule in Loyalty Rule Table
        /// </summary>

        [Test, Category("Service Testing"), Order(3)]
        public static void TC_InsertRule()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_InsertRule, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

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
        /// <summary>
        /// This test case will Insert Stay and Night for Scenario 1-12
        /// </summary>

        [Test, Category("Service Testing"), Order(4)]
        public static void TC_InsertStay01_12()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_InsertStay01_12, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

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
        /// <summary>
        /// LOY - Service/Points Earning Rule - Scenario_01 Verify Profile with 1 stay
        /// </summary>

        [Test, Category("Service Testing"), Order(5)]
        public static void TC_276900()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276900, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// LOY - Service/Points Earning Rule - Scenario_02 Verify Profile with 2 stay
        /// </summary>

        [Test, Category("Service Testing"), Order(6)]
        public static void TC_276901()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276901, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// LOY - Service/Points Earning Rule - Scenario_03 Verify Profile with 4 stay
        /// </summary>

        [Test, Category("Service Testing"), Order(7)]
        public static void TC_276902()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276902, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// LOY - Service/Points Earning Rule - Scenario_04 Verify Consecutive Stay
        /// </summary>

        [Test, Category("Service Testing"), Order(8)]
        public static void TC_276903()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276903, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// LOY - Service/Points Earning Rule - Scenario_05 Verify Parallel Stay
        /// </summary>

        [Test, Category("Service Testing"), Order(9)]
        public static void TC_276904()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276904, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// LOY - Service/Points Earning Rule - Scenario_06 Verify Qualify Stay/Night _Min Revenue
        /// </summary>

        [Test, Category("Service Testing"), Order(10)]
        public static void TC_276905()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276905, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// LOY - Service/Points Earning Rule - Scenario_07 Verify Qualify Stay/Night _Market Code
        /// </summary>

        [Test, Category("Service Testing"), Order(11)]
        public static void TC_276906()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276906, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// LOY - Service/Points Earning Rule - Scenario_08 Verify Qualify Stay/Night _Source Of Business
        /// </summary>

        [Test, Category("Service Testing"), Order(12)]
        public static void TC_276907()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276907, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// LOY - Service/Points Earning Rule - Scenario_09 Verify Qualify Stay/Night _Channel Code
        /// </summary>

        [Test, Category("Service Testing"), Order(13)]
        public static void TC_276908()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276908, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// LOY - Service/Points Earning Rule - Scenario_10 Verify Qualify Stay/Night_Hotel
        /// </summary>

        [Test, Category("Service Testing"), Order(14)]
        public static void TC_276909()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276909, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// LOY - Service/Points Earning Rule - Scenario_11 Verify Qualify Stay/Night _Rate Code
        /// </summary>

        [Test, Category("Service Testing"), Order(15)]
        public static void TC_276910()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276910, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// LOY - Service/Points Earning Rule - Scenario_12 Verify Qualify Stay/Night _Market Rate Combo
        /// </summary>

        [Test, Category("Service Testing"), Order(16)]
        public static void TC_276911()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276911, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// This test case will Create User Using Batch Registration
        /// </summary>

        [Test, Category("Service Testing"), Order(18)]
        public static void TC_InsertStay13_30()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_InsertStay13_30, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

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
        /// <summary>
        /// LOY - Service/Points Earning Rule - Scenario_13 Verify Revenue
        /// </summary>

        [Test, Category("Service Testing"), Order(19)]
        public static void TC_276912()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276912, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// LOY - Service/Points Earning Rule - Scenario_14 Verify Revenue
        /// </summary>

        [Test, Category("Service Testing"), Order(20)]
        public static void TC_276913()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276913, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// LOY - Service/Points Earning Rule - Scenario_15 Verify Revenue
        /// </summary>

        [Test, Category("Service Testing"), Order(21)]
        public static void TC_276914()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276914, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// LOY - Service/Points Earning Rule - Scenario_16 Verify Revenue
        /// </summary>

        [Test, Category("Service Testing"), Order(22)]
        public static void TC_276915()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276915, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// LOY - Service/Points Earning Rule - Scenario_17 Verify Revenue_Only Room Revenue
        /// </summary>

        [Test, Category("Service Testing"), Order(23)]
        public static void TC_276916()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276916, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// LOY - Service/Points Earning Rule - Scenario_18 Verify Revenue_Only Other
        /// </summary>

        [Test, Category("Service Testing"), Order(24)]
        public static void TC_276917()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276917, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// LOY - Service/Points Earning Rule - Scenario_20 Verify Criteria (With all 3 Revenues)
        /// </summary>

        [Test, Category("Service Testing"), Order(25)]
        public static void TC_276919()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276919, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// LOY - Service/Points Earning Rule - Scenario_21
        /// </summary>

        [Test, Category("Service Testing"), Order(26)]
        public static void TC_276920()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276920, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// LOY - Service/Points Earning Rule - Scenario_22
        /// </summary>

        [Test, Category("Service Testing"), Order(27)]
        public static void TC_276921()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276921, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// LOY - Service/Points Earning Rule - Scenario_23
        /// </summary>

        [Test, Category("Service Testing"), Order(28)]
        public static void TC_276922()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276922, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// LOY - Service/Points Earning Rule - Scenario_24
        /// </summary>

        [Test, Category("Service Testing"), Order(29)]
        public static void TC_276923()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276923, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// LOY - Service/Points Earning Rule - Scenario_25
        /// </summary>

        [Test, Category("Service Testing"), Order(30)]
        public static void TC_276924()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276924, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// LOY - Service/Points Earning Rule - Scenario_26
        /// </summary>

        [Test, Category("Service Testing"), Order(31)]
        public static void TC_276925()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276925, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// LOY - Service/Points Earning Rule - Scenario_27
        /// </summary>

        [Test, Category("Service Testing"), Order(32)]
        public static void TC_276926()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276926, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// LOY - Service/Points Earning Rule - Scenario_28
        /// </summary>

        [Test, Category("Service Testing"), Order(33)]
        public static void TC_276927()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276927, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// LOY - Service/Points Earning Rule - Scenario_29 Verify Start Date Criteria
        /// </summary>

        [Test, Category("Service Testing"), Order(34)]
        public static void TC_276928()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276928, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
        /// LOY - Service/Points Earning Rule - Scenario_30 Verify End Date Criteria
        /// </summary>

        [Test, Category("Service Testing"), Order(35)]
        public static void TC_276929()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_276929, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_276897();

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
