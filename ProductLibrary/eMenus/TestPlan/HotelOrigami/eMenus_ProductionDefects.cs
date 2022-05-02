using System;
using System.Threading;
using BaseUtility.Utility;
using eMenus.AppModule.MainAdminApp;
using eMenus.Utility;
using InfoMessageLogger;
using NUnit.Framework;
using OpenQA.Selenium;
using TestData;

namespace eMenus.TestPlan.HotelOrigami
{
    class eMenus_ProductionDefects : eMenus.Utility.Setup
    {
        public eMenus_ProductionDefects(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }

        [SetUp]
        public static void Initialize()
        {
            //Initialize the test case set up.
            InitializeSetup(Constants.Production_Defects, Enums.ClientName.eMenus, Enums.TestDataType.Controller, Enums.CaseType.NA, "eMenus");

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
            
        }

        /// <summary>
        /// This defect will validate User should not be allowed to share menu with blank space only in name
        /// </summary>

        [Test, Category("HotelOrigami_Production_Defects")]
        public static void D_233380()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.D_233380, "Excel", Enums.ClientName.All, Enums.TestDataType.ProductionDefect, Enums.CaseType.Defect);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.Production_Defects();

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
        /// This defect will validate Choices not able to be edited after altering choice orders 
        /// </summary>
        
        [Test, Category("HotelOrigami_Production_Defects")]
        public static void D_234734()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.D_234734, "Excel", Enums.ClientName.All, Enums.TestDataType.ProductionDefect, Enums.CaseType.Defect);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.Production_Defects();

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
        /// This defect will validate user is not receiving a sign in pop up box while switching languages 
        /// </summary>

        [Test, Category("HotelOrigami_Production_Defects")]
        public static void D_248778()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.D_248778, "Excel", Enums.ClientName.All, Enums.TestDataType.ProductionDefect, Enums.CaseType.Defect);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.Production_Defects();

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
        /// This defect will validate menu filters clone functionality
        /// </summary>

        [Test, Category("HotelOrigami_Production_Defects")]
        public static void D_250928()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.D_250928, "Excel", Enums.ClientName.All, Enums.TestDataType.ProductionDefect, Enums.CaseType.Defect);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.Production_Defects();

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
        /// This defect will validate add-on reordering 
        /// </summary>

        [Test, Category("HotelOrigami_Production_Defects")]
        public static void D_261817()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.D_261817, "Excel", Enums.ClientName.All, Enums.TestDataType.ProductionDefect, Enums.CaseType.Defect);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.Production_Defects();

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
        /// This defect will validate save menu failed 
        /// </summary>

        [Test, Category("HotelOrigami_Production_Defects")]
        public static void D_260067()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.D_260067, "Excel", Enums.ClientName.All, Enums.TestDataType.ProductionDefect, Enums.CaseType.Defect);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.Production_Defects();

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
