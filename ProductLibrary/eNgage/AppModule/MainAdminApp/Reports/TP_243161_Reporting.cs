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
        #region[TP_243161]
        public static void TC_243419()
        {
            PageObject_Home.Nav_OtherTabs().Click();
            PageObject_Reporting.Nav_Reporting().Click();
            var tabs = Driver.WindowHandles;
            if (tabs.Count > 1)
            {
                Driver.SwitchTo().Window(tabs[1]);
                Reporting.checkReportingLoad(Driver, wait);
                AddDelay(1000);
                var date = DateTime.Today.AddDays(0);
                string getDate = date.ToString("dddd, MMM d, yyyy");
                
                if (VerifyTextOnPage(getDate))
                {
                    Logger.WriteDebugMessage("Have latest reports");
                }
                else
                {
                    Assert.Fail("Did not have latest reports");
                }
            }
            else
            {
                Logger.WriteFatalMessage("Unable to open Reporting Page");
            }
        }
        #endregion[TP_243161]

    }
}
