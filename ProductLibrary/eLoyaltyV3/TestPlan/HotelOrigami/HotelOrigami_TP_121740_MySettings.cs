using eLoyaltyV3.AppModule.MainAdminApp;
using Common;
using TestData.ExcelData;
using eLoyaltyV3.Utility;
using NUnit.Framework;
using System;
using Constants = eLoyaltyV3.Utility.Constants;
using TestData;
using BaseUtility.Utility;
using InfoMessageLogger;
using OpenQA.Selenium;
using System.Threading;

namespace HotelOrigami
{
    class HotelOrigami_TP_121740_MySettings : eLoyaltyV3.Utility.Setup
    {
        //public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public HotelOrigami_TP_121740_MySettings(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_121740;

            //Initialize the test case set up.
           
            InitializeSetup(Constants.TP_121740, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_121740;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);            
            AddDelay(1500);
        }

        //[Test, Category("Regression")]
        //public static void TC_120126()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase_POC(Constants.TC_120126, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

        //        Logger.DeleteOldFolder();

        //        /**Start**/
        //        MainAdminApp.TP_121740(GetProjectName);

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();

        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}

        //[Test, Category("Regression")]
        //public static void TC_120127()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase_POC(Constants.TC_120127, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

        //        Logger.DeleteOldFolder();

        //        /**Start**/
        //        MainAdminApp.TP_121740(GetProjectName);

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();

        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}

        //[Test, Category("Regression")]
        //public static void TC_120128()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase_POC(Constants.TC_120128, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

        //        Logger.DeleteOldFolder();

        //        /**Start**/
        //        MainAdminApp.TP_121740(GetProjectName);

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();

        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}

        //[Test, Category("Regression")]
        //public static void TC_120129()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase_POC(Constants.TC_120129, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

        //        Logger.DeleteOldFolder();

        //        /**Start**/
        //        MainAdminApp.TP_121740(GetProjectName);

        //        //string GetCurrentEmailAddress = Helper.Getdata(PageObject_MySettings.MySettings_CurrentEmailAddress());

        //        TestHandling.TestEnd();


        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}

        //[Test, Category("Regression")]
        //public static void TC_120130()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase_POC(Constants.TC_120130, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

        //        Logger.DeleteOldFolder();

        //        /**Start**/
        //        MainAdminApp.TP_121740(GetProjectName);

        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}

        //[Test, Category("Regression")]
        //public static void TC_120131()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase_POC(Constants.TC_120131, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

        //        Logger.DeleteOldFolder();

        //        /**Start**/
        //        MainAdminApp.TP_121740(GetProjectName);

        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}

        //[Test, Category("Regression")]
        //public static void TC_120132()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase_POC(Constants.TC_120132, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

        //        Logger.DeleteOldFolder();

        //        /**Start**/
        //        MainAdminApp.TP_121740(GetProjectName);

        //        TestHandling.TestEnd();


        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}

        //[Test, Category("Regression")]
        //public static void TC_120133()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase_POC(Constants.TC_120133, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

        //        Logger.DeleteOldFolder();

        //        /**Start**/
        //        MainAdminApp.TP_121740(GetProjectName);

        //        TestHandling.TestEnd();


        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}

        //[Test, Category("Regression")]
        //public static void TC_120134()
        //{
        //    string ReturnResult = Constants.ValidationMessageInvalidFormat;
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase_POC(Constants.TC_120134, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

        //        Logger.DeleteOldFolder();

        //        /**Start**/
        //        MainAdminApp.TP_121740(GetProjectName);

        //        TestHandling.TestEnd();


        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}

        //[Test, Category("Regression")]
        //public static void TC_120135()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase_POC(Constants.TC_120135, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

        //        Logger.DeleteOldFolder();

        //        /**Start**/
        //        MainAdminApp.TP_121740(GetProjectName);

        //        TestHandling.TestEnd();


        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}

        //[Test, Category("Regression")]
        //public static void TC_120136()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase_POC(Constants.TC_120136, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

        //        Logger.DeleteOldFolder();

        //        /**Start**/
        //        MainAdminApp.TP_121740(GetProjectName);

        //        TestHandling.TestEnd();


        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}

        //[Test, Category("Regression")]
        //public static void TC_120137()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase_POC(Constants.TC_120137, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

        //        Logger.DeleteOldFolder();

        //        /**Start**/
        //        MainAdminApp.TP_121740(GetProjectName);

        //        TestHandling.TestEnd();


        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}

        //[Test, Category("Regression")]
        //public static void TC_120138()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase_POC(Constants.TC_120138, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

        //        Logger.DeleteOldFolder();

        //        /**Start**/
        //        MainAdminApp.TP_121740(GetProjectName);

        //        TestHandling.TestEnd();


        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}

        [Test, Category("Regression")]        
        public static void TC_219436()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_219436, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);
                              

                Logger.DeleteOldFolder();

                /**Start**/
                MainAdminApp.TP_121740(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();

            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Regression")]
        public static void TC_219459()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_219459, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                /**Start**/
                MainAdminApp.TP_121740(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();

            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Regression")]
        public static void TC_219517()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_219517, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                /**Start**/
                MainAdminApp.TP_121740(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();

            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Regression")]
        public static void TC_120138()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_120138, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                /**Start**/
                MainAdminApp.TP_121740(ProjectName);

                TestHandling.TestEnd();

            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        [Test, Category("Regression")]
        public static void TC_124899()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_124899, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                /**Start**/
                MainAdminApp.TP_121740(ProjectName);

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
