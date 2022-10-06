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
    class RevIntel_TP_252578_Booking_Trends : RevIntel.Utility.Setup
    {
        //public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public RevIntel_TP_252578_Booking_Trends(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        public RevIntel_TP_252578_Booking_Trends() { }
        [SetUp]
        public static void Initialize()
        {
            TestPlanId = Constants.TP_252578;

            //Initialize the test case set up.
            InitializeSetup(Constants.TP_252578, Enums.ClientName.RevIntel, Enums.TestDataType.Controller, Enums.CaseType.NA, "RevIntel");

            //Assign the test data test plan file location
            TestDataFile = TestDataLocation.POCExcel;// TestDataLocation.TP_121734;


            //Navigate to the URL
            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            AddDelay(1500);
        }

        /// <summary>
        /// This test case will Validate Pace Report
        /// </summary>
        [Test, Category("RevIntel_TP_252578_Booking_Trends")]
        public static void TC_252597()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252597, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252578();


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
        /// This test case will  Validate Pace Trend
        /// </summary>
        [Test, Category("RevIntel_TP_252578_Booking_Trends")]
        public static void TC_252598()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252598, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252578();


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
        /// This test case will  Validate Daily Pace and Pickup analysis
        /// </summary>
        [Test, Category("RevIntel_TP_252578_Booking_Trends")]
        public static void TC_252599()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252599, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252578();


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
        /// This test case will  Validate Pace and Pickup Analysis
        /// </summary>
        [Test, Category("RevIntel_TP_252578_Booking_Trends")]
        public static void TC_252600()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252600, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252578();


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
        /// This test case will  Validate Rate Code Pace Report
        /// </summary>
        [Test, Category("RevIntel_TP_252578_Booking_Trends")]
        public static void TC_252601()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252601, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252578();


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
        /// This test case will  Validate Channel by Room Type Pace
        /// </summary>
        [Test, Category("RevIntel_TP_252578_Booking_Trends")]
        public static void TC_252602()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252602, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252578();


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
        /// This test case will  Validate Channel Pace Analysis
        /// 
        [Test, Category("RevIntel_TP_252578_Booking_Trends")]
        public static void TC_252603()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252603, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252578();


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
        /// This test case will  Validate Pickup by Day
        /// 
        [Test, Category("RevIntel_TP_252578_Booking_Trends")]
        public static void TC_252604()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252604, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252578();


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
        /// This test case will   Validate Annual Pickup by Day
        /// 
        [Test, Category("RevIntel_TP_252578_Booking_Trends")]
        public static void TC_252643()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252643, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252578();


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
        /// This test case will Validate Length of Stay Report
        /// 
        [Test, Category("RevIntel_TP_252578_Booking_Trends")]
        public static void TC_252644()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252644, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252578();


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
        /// This test case will Validate Rooms Lead time
        /// 
        [Test, Category("RevIntel_TP_252578_Booking_Trends")]
        public static void TC_252645()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252645, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252578();


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
        /// This test case will Validate Pickup by Day Detailed
        /// 
        [Test, Category("RevIntel_TP_252578_Booking_Trends")]
        public static void TC_252605()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252605, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252578();


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
        /// This test case will Validate Monthly Pick up
        /// 
        [Test, Category("RevIntel_TP_252578_Booking_Trends")]
        public static void TC_252606()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252606, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252578();


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
        /// This test case will Validate Production Pattern Report
        /// 
        [Test, Category("RevIntel_TP_252578_Booking_Trends")]
        public static void TC_252607()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252607, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252578();


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
        /// This test case will Validate High Occupancy Night By Day
        /// 
        [Test, Category("RevIntel_TP_252578_Booking_Trends")]
        public static void TC_252608()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252608, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252578();


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
        /// This test case will Validate Sold Out Night Analysis
        /// 
        [Test, Category("RevIntel_TP_252578_Booking_Trends")]
        public static void TC_252609()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252609, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252578();


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
        /// This test case will Validate Cancellation Report
        /// 
        [Test, Category("RevIntel_TP_252578_Booking_Trends")]
        public static void TC_252610()
        {
            try
            {
                /**Test execution - Start**/
                SetupTestCase(Constants.TC_252610, "Excel", Enums.ClientName.All, Enums.TestDataType.FrontEnd, Enums.CaseType.TestCase);  //, "XML");

                Logger.DeleteOldFolder();

                //Start
                MainAdminApp.TP_252578();


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

