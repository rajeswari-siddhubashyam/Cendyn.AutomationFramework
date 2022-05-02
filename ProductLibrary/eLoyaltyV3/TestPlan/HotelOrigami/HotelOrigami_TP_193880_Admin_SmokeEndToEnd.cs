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
    class HotelOrigami_TP_193880_Admin_SmokeEndToEnd : eLoyaltyV3.Utility.Setup
    {
        //public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public HotelOrigami_TP_193880_Admin_SmokeEndToEnd(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_193880;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_193880, Enums.ClientName.HotelOrigami, Enums.TestDataType.Controller, Enums.CaseType.NA, "HotelOrigami");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_193880;

            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
            
        }

        /* This test case will Add/Update Rule - Verify Creation and Updation of Rule with all Details */
        [Test, Category("Smoke")]
        public static void TC_194035()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_194035, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_193880(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will Add/Update Rule - Verify Add/Update Birthday based Award with all Details*/
        [Test, Category("Smoke")]
        public static void TC_194195()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_194195, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_193880(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will Verify Add/Update Transaction Reasons with all Details */
        [Test, Category("Smoke")]
        public static void TC_194218()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_194218, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_193880(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will Verify Add/Update sign Up Sources with all Details */
        [Test, Category("Smoke")]
        public static void TC_194219()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_194219, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_193880(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will Verify Add/Update/Remove Terms & Condition with all Details */
        [Test, Category("Smoke")]
        public static void TC_194221()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_194221, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_193880(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will Verify edit emails with all Details */
        [Test, Category("Smoke")]
        public static void TC_194231()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_194231, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_193880(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will  Verify manual merge functionality with active users*/
        [Test, Category("Smoke")]
        public static void TC_194235()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_194235, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_193880(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will  Verify manual merge functionality with InActive users*/
        [Test, Category("Smoke")]
        public static void TC_194240()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_194240, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_193880(ProjectName);

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
        [Test, Category("Smoke")]
        public static void TC_194242()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_194242, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_193880(ProjectName);

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
        [Test, Category("Smoke")]
        public static void TC_141476()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_141476, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase); 

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_193880(ProjectName);

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
        [Test, Category("Smoke")]
        public static void TC_222075()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_222075, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_193880(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /* This test case will  Verify Forgot Password Functionality for Admin Users*/
        [Test, Category("Smoke")]
        public static void TC_222092()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_222092, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_193880(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /* This test case will  Verify Account Lock Functionality for Admin Users*/
        [Test, Category("Smoke")]
        public static void TC_209620()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_209620, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_193880(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }

        /* This test case will  Verify admin is able to send Activation,Welcome and password Recovery email.*/
        [Test, Category("Smoke")]
        public static void TC_189006()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_189006, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_193880(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        
        /* This test case will  Verify user is able to edit first name and last name from member information page - [Origami]*/
        [Test, Category("Smoke")]
        public static void TC_221131()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_221131, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_193880(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /*This test case will Verify navigation to all Admin modules/tabs - [Origami] */
        [Test, Category("Smoke")]
        public static void TC_194749()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_194749, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_193880(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /* This test case will Verify Terms and conditions functionality in Admin */
        [Test, Category("Smoke")]
        public static void TC_242619()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_242619, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_193880(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /* This test case will Validate the Redemption functionality when Client Account balance is not sufficient */
        //[Test, Category("Smoke")]
        //public static void TC_208722()
        //{
        //    try
        //    {
        //        /**Test execution - Start**/
        //        SetupTestCase(Constants.TC_208722, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

        //        Logger.DeleteOldFolder();

        //        //Start
        //        MainAdminApp.TP_193880(ProjectName);

        //        /**Test execution - End**/
        //        TestHandling.TestEnd();
        //    }
        //    catch (Exception e)
        //    {
        //        TestHandling.TestFailed(e);
        //        throw;
        //    }
        //}
        /* This test case will Verify clicking on close, No and Yes from 'Send Member Level Up email' Pop-up */
        [Test, Category("Smoke")]
        public static void TC_226427()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_226427, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_193880(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }


        /* This test case will Verify edited Member email (Reset Login) details under Admin update log */
        [Test, Category("Smoke")]
        public static void TC_237408()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_237408, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_193880(ProjectName);

                /**Test execution - End**/
                TestHandling.TestEnd();
            }
            catch (Exception e)
            {
                TestHandling.TestFailed(e);
                throw;
            }
        }
        /* This test case will Validate when admin downgrades the member level */
        [Test, Category("Smoke")]
        public static void TC_226431()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_226431, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_193880(ProjectName);

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
        /// /* This test case will  Verify All Fields on Rule Restrictions Page for Award Earning Rule and Points Earning Rule*/
        /// </summary>

        [Test, Category("Smoke")]
        public static void TC_272803()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_272803, "Excel", Enums.ClientName.All, Enums.TestDataType.Admin, Enums.CaseType.TestCase);

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_193880(ProjectName);

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
