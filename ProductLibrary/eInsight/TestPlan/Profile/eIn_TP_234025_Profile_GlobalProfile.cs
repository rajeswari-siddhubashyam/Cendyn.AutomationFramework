using System;
using NUnit.Framework;
using eInsight.AppModule.MainAdminApp;
using BaseUtility.Utility;
using eInsight.AppModule.UI;
using System.Text.RegularExpressions;
using InfoMessageLogger;
using Constants = eInsight.Utility.Constants;
using LegacyTestData = eInsight.Utility.LegacyTestData;
using eInsightSetup = eInsight.Utility.Setup;
using OpenQA.Selenium;
using System.Threading;


namespace eInsightGlobalProfile
{
    public class eIn_TP_234025_Profile_GlobalProfile : eInsightSetup
    {
        public static string GetProjectName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
        public eIn_TP_234025_Profile_GlobalProfile()
        { }
        public eIn_TP_234025_Profile_GlobalProfile(string browser, string version, string os, string resolution) : base(browser, version, os, resolution)
        {
            Drivers = new ThreadLocal<IWebDriver>();
        }
        [SetUp]
        public static void Initialize()
        {
            //TestPlanId = Constants.TP_86435;
            TestPlanId = Constants.TP_234025;

            InitializeSetup(TestPlanId,GetProjectName);

            AddDelay(8000);

            //Can use this to update the URL Manually
            //LegacyTestData.CommonFrontendURL = "https://poceinsight.cendyn.com/";
        }

        [Test, Category("Smoke")]
        public static void TC_234161()
        {
            Legacy_SetupTestCase(Constants.TC_234161);

            Logger.DeleteOldFolder();

            string[] eachFrontEndURL = Regex.Split(LegacyTestData.CommonFrontendURL, ",");
            foreach (string frontendURL in eachFrontEndURL)
            {
                Login.CommonLogin(frontendURL);
                MainAdminApp.TP_234025();
                RenewDriver();
            }
        }

        [TearDown]
        public void Quit()
        {
            TestHandling.TearDown();
        }
    }
}
