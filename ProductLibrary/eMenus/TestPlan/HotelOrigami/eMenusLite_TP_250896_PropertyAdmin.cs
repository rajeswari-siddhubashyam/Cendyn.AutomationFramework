using TestData;
using NUnit.Framework;
using System;
using InfoMessageLogger;
using eMenus.AppModule.MainAdminApp;
using BaseUtility.Utility;
using OpenQA.Selenium;
using System.Threading;
using eMenus.Utility;

namespace eMenusLite.TestPlan.HotelOrigami
{
    class eMenusLite_TP_250896_PropertyAdmin : eMenus.Utility.Setup
    {
        public eMenusLite_TP_250896_PropertyAdmin(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            //Initialize the test case set up.
            InitializeSetup(Constants.TP_250896, Enums.ClientName.eMenusLite, Enums.TestDataType.Controller, Enums.CaseType.NA, "eMenusLite");

            //Navigate to the URL
            
            Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
        }
        /*This test case will Validate  */
        
        //[Test, Category("HotelOrigami_TP_250896_eMenusLITE")]
        //public static void TC_231048()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_231048, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_250896();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
        ///*This test case will Validate  */
        //[Test, Category("HotelOrigami_TP_250896_eMenusLITE")]
        //public static void TC_232423()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_232423, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_250896();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
        ///*This test case will Validate  */
        //[Test, Category("HotelOrigami_TP_250896_eMenusLITE")]
        //public static void TC_231050()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_231050, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_250896();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
        ///*This test case will Validate  */
        //[Test, Category("HotelOrigami_TP_250896_eMenusLITE")]
        //public static void TC_231214()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_231214, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_250896();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
        ///*This test case will Validate  */
        //[Test, Category("HotelOrigami_TP_250896_eMenusLITE")]
        //public static void TC_231215()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_231215, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_250896();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
        ///*This test case will Validate  */
        //[Test, Category("HotelOrigami_TP_250896_eMenusLITE")]
        //public static void TC_231216()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_231216, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_250896();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
        ///*This test case will Validate  */
        //[Test, Category("HotelOrigami_TP_250896_eMenusLITE")]
        //public static void TC_261318()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_261318, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_250896();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
        ///*This test case will Validate  */
        //[Test, Category("HotelOrigami_TP_250896_eMenusLITE")]
        //public static void TC_231219()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_231219, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_250896();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
        ///*This test case will Validate  */
        //[Test, Category("HotelOrigami_TP_250896_eMenusLITE")]
        //public static void TC_231473()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_231473, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_250896();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
        ///*This test case will Validate  */
        //[Test, Category("HotelOrigami_TP_250896_eMenusLITE")]
        //public static void TC_233030()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_233030, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_250896();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
        ///*This test case will Validate  */
        //[Test, Category("HotelOrigami_TP_250896_eMenusLITE")]
        //public static void TC_256953()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_256953, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_250896();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
        ///*This test case will Validate  */
        //[Test, Category("HotelOrigami_TP_250896_eMenusLITE")]
        //public static void TC_260414()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_260414, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_250896();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
        ///*This test case will Validate  */
        //[Test, Category("HotelOrigami_TP_250896_eMenusLITE")]
        //public static void TC_260420()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_260420, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_250896();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
        ///*This test case will Validate  */
        //[Test, Category("HotelOrigami_TP_250896_eMenusLITE")]
        //public static void TC_260415()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_260415, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_250896();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
        ///*This test case will Validate  */
        //[Test, Category("HotelOrigami_TP_250896_eMenusLITE")]
        //public static void TC_260417()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_260417, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_250896();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
        ///*This test case will Validate  */
        //[Test, Category("HotelOrigami_TP_250896_eMenusLITE")]
        //public static void TC_260418()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_260418, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_250896();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
        ///*This test case will Validate  */
        //[Test, Category("HotelOrigami_TP_250896_eMenusLITE")]
        //public static void TC_260419()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_260419, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_250896();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
        ///*This test case will Validate  */
        //[Test, Category("HotelOrigami_TP_250896_eMenusLITE")]
        //public static void TC_261125()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_261125, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_250896();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
        ///*This test case will Validate  */
        //[Test, Category("HotelOrigami_TP_250896_eMenusLITE")]
        //public static void TC_261127()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_261127, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_250896();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
        ///*This test case will Validate  */
        //[Test, Category("HotelOrigami_TP_250896_eMenusLITE")]
        //public static void TC_261130()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_261130, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_250896();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
        ///*This test case will Validate  */
        //[Test, Category("HotelOrigami_TP_250896_eMenusLITE")]
        //public static void TC_261131()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_261131, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_250896();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
        ///*This test case will Validate  */
        //[Test, Category("HotelOrigami_TP_250896_eMenusLITE")]
        //public static void TC_260422()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_260422, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_250896();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
        ///*This test case will Validate  */
        //[Test, Category("HotelOrigami_TP_250896_eMenusLITE")]
        //public static void TC_261133()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_261133, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_250896();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}

        ///*This test case will Validate  */
        //[Test, Category("HotelOrigami_TP_250896_eMenusLITE")]
        //public static void TC_260421()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_260421, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_250896();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
        ///*This test case will Validate  */
        //[Test, Category("HotelOrigami_TP_250896_eMenusLITE")]
        //public static void TC_261132()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_261132, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_250896();

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}        /*This test case will Validate  */
        //[Test, Category("HotelOrigami_TP_250896_eMenusLITE")]
        //public static void TC_232406()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_232406, "Excel", Enums.ClientName.All, Enums.TestDataType.PropertyAdmin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_250896();

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
