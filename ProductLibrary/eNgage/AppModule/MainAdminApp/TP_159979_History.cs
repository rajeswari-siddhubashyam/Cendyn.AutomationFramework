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
        #region[TP_159979]
        public static void TC_244590()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));

            PageObject_Home.Nav_OtherTabs().Click();
            PageObject_History.Nav_History().Click();
            History.checkHistoryLoad(Driver, wait);
            History.ViewHistoryProfile(Driver, wait);
        }
        #endregion[TP_159979]

    }
}
