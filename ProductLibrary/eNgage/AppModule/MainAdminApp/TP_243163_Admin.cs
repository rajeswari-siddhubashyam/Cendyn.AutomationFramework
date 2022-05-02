using System;
using eNgage.Utility;
using eNgage.AppModule.UI;
using Common;
using Constants = eNgage.Utility.Constants;
using InfoMessageLogger;
using BaseUtility.Utility;
using TestData;
using OpenQA.Selenium;
using NUnit.Framework;
using eNgage.AppModule.UI;
using eNgage.PageObject.UI;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Support.UI;

namespace eNgage.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        public static WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
        #region[TP_243163]
        public static void TC_243294()
        {
            PageObject_Home.Nav_OtherTabs().Click();
            PageObject_Admin.Nav_Admin().Click();
            var tabs = Driver.WindowHandles;
            if (tabs.Count > 1)
            {
                Driver.SwitchTo().Window(tabs[1]);
                Admin.checkAdminLoad(Driver, wait);
                AddDelay(1000);
                Driver.Close();
                Driver.SwitchTo().Window(tabs[0]);
            }
            else
            {
                Logger.WriteFatalMessage("Unable to open Admin Page");
            }
        }
        public static void TC_243417()
        {
            PageObject_Home.Nav_OtherTabs().Click();
            PageObject_Reporting.Nav_Reporting().Click();
            var tabs = Driver.WindowHandles;
            if (tabs.Count > 1)
            {
                Driver.SwitchTo().Window(tabs[1]);
                Reporting.checkReportingLoad(Driver, wait);
                AddDelay(1000);
                Driver.Close();
                Driver.SwitchTo().Window(tabs[0]);
            }
            else
            {
                Logger.WriteFatalMessage("Unable to open Reporting Page");
            }
        }
        #endregion[TP_243163]

    }
}
