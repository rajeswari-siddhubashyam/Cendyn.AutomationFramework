using System;
using NUnit.Framework;
using eInsight.AppModule.MainAdminApp;
using BaseUtility.Utility;
using eInsight.AppModule.UI;
using System.Text.RegularExpressions;
using InfoMessageLogger;
using Constants = eInsight.Utility.Constants;
using LegacyTestData = eInsight.Utility.LegacyTestData;

namespace eInsightGlobalProfileSearch
{
    public class eIn_TP_69664_Profile_GlobalProfile_Search : eInsight.Utility.Setup
    {
        public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;

        [SetUp]
        public static void Initialize()
        {
            //TestPlanId = Constants.TP_86435;
            TestPlanId = Constants.TP_69664;

            InitializeSetup(TestPlanId,GetProjectName);

            AddDelay(8000);

        }

        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69781()
        {
            Legacy_SetupTestCase(Constants.TC_69781);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69781);
                RenewDriver();
            }
        }

        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69785()
        {
            Legacy_SetupTestCase(Constants.TC_69785);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69785);
                RenewDriver();
            }
        }

        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69798()
        {
            Legacy_SetupTestCase(Constants.TC_69798);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69798);
                RenewDriver();
            }
        }

        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69799()
        {
            Legacy_SetupTestCase(Constants.TC_69799);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69799);
                RenewDriver();
            }
        }

        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69701()
        {
            Legacy_SetupTestCase(Constants.TC_69701);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69701);
                RenewDriver();
            }
        }

        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69702()
        {
            Legacy_SetupTestCase(Constants.TC_69702);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69702);
                RenewDriver();
            }
        }

        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69703()
        {
            Legacy_SetupTestCase(Constants.TC_69703);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69703);
                RenewDriver();
            }
        }

        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69704()
        {
            Legacy_SetupTestCase(Constants.TC_69704);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69704);
                RenewDriver();
            }
        }

        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69708()
        {
            Legacy_SetupTestCase(Constants.TC_69708);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69708);
                RenewDriver();
            }
        }

        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69709()
        {
            Legacy_SetupTestCase(Constants.TC_69709);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69709);
                RenewDriver();
            }
        }

        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69710()
        {
            Legacy_SetupTestCase(Constants.TC_69710);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69710);
                RenewDriver();
            }
        }

        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69711()
        {
            Legacy_SetupTestCase(Constants.TC_69711);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69711);
                RenewDriver();
            }
        }

        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69712()
        {
            Legacy_SetupTestCase(Constants.TC_69712);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69712);
                RenewDriver();
            }
        }

        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69716()
        {
            Legacy_SetupTestCase(Constants.TC_69716);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69716);
                RenewDriver();
            }
        }

        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69717()
        {
            Legacy_SetupTestCase(Constants.TC_69717);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69717);
                RenewDriver();
            }
        }

        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69718()
        {
            Legacy_SetupTestCase(Constants.TC_69718);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69718);
                RenewDriver();
            }
        }

        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69719()
        {
            Legacy_SetupTestCase(Constants.TC_69719);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69719);
                RenewDriver();
            }
        }


        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69720()
        {
            Legacy_SetupTestCase(Constants.TC_69720);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69720);
                RenewDriver();
            }
        }

        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69724()
        {
            Legacy_SetupTestCase(Constants.TC_69724);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69724);
                RenewDriver();
            }
        }

        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69726()
        {
            Legacy_SetupTestCase(Constants.TC_69726);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69726);
                RenewDriver();
            }
        }

        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69727()
        {
            Legacy_SetupTestCase(Constants.TC_69727);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69727);
                RenewDriver();
            }
        }
        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69728()
        {
            Legacy_SetupTestCase(Constants.TC_69728);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69728);
                RenewDriver();
            }
        }
        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69729()
        {
            Legacy_SetupTestCase(Constants.TC_69729);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69729);
                RenewDriver();
            }
        }
        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69731()
        {
            Legacy_SetupTestCase(Constants.TC_69731);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69731);
                RenewDriver();
            }
        }
        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69732()
        {
            Legacy_SetupTestCase(Constants.TC_69732);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69732);
                RenewDriver();
            }
        }

        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69733()
        {
            Legacy_SetupTestCase(Constants.TC_69733);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69733);
                RenewDriver();
            }
        }
        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69734()
        {
            Legacy_SetupTestCase(Constants.TC_69734);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69734);
                RenewDriver();
            }
        }
        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69741()
        {
            Legacy_SetupTestCase(Constants.TC_69741);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69741);
                RenewDriver();
            }
        }
        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69742()
        {
            Legacy_SetupTestCase(Constants.TC_69742);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69742);
                RenewDriver();
            }
        }
        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69743()
        {
            Legacy_SetupTestCase(Constants.TC_69743);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69743);
                RenewDriver();
            }
        }

        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69744()
        {
            Legacy_SetupTestCase(Constants.TC_69744);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69744);
                RenewDriver();
            }
        }
        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69746()
        {
            Legacy_SetupTestCase(Constants.TC_69746);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69746);
                RenewDriver();
            }
        }
        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69748()
        {
            Legacy_SetupTestCase(Constants.TC_69748);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69748);
                RenewDriver();
            }
        }
        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69749()
        {
            Legacy_SetupTestCase(Constants.TC_69749);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69749);
                RenewDriver();
            }
        }

        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69750()
        {
            Legacy_SetupTestCase(Constants.TC_69750);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69750);
                RenewDriver();
            }
        }
        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69751()
        {
            Legacy_SetupTestCase(Constants.TC_69751);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69751);
                RenewDriver();
            }
        }

        [Category("Regression")]
        [Test, Category("eInsight TP_69664")]
        public static void TC_69753()
        {
            Legacy_SetupTestCase(Constants.TC_69753);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_69664(Constants.TC_69753);
                RenewDriver();
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
