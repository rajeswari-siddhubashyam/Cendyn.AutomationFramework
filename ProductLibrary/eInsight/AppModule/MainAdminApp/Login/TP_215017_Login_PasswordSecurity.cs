using System;
using eInsight.Utility;
using eInsight.AppModule.UI;
using Common;
using Constants = eInsight.Utility.Constants;
using InfoMessageLogger;
using BaseUtility.Utility;
using TestData;
using SqlWarehouse;
using OpenQA.Selenium;
using NUnit.Framework;
using eInsight.AppModule.UI;
using eInsight.PageObject.UI;
using System.Text.RegularExpressions;
using BaseUtility.Utility.Hotmail;

namespace eInsight.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        #region[TP_215017]
        public static void TC_215019()
        {
            Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL);
            OpenNewTab();
            ControlToNewWindow();
            Login.AutoAcc_loginForLockTest("", 2, 0, LegacyTestData.CommonCatchallURL, 0);
            Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            
            Login.Login_Test(LegacyTestData.CommonFrontendURL, "fakepass", 0);

            Driver.SwitchTo().Window(Driver.WindowHandles[2]);
            Hotmail.SearchEmail("eInsight - Account Lockout");
            Hotmail.OpenLatestEmail();

            Logger.WriteDebugMessage("Opened Latest Email.");
            if (VerifyTextOnPage("eInsight - Account Lockout"))
            {
                Login.Click_ResetPassword();
                Login.EnterNewPasswords(LegacyTestData.CommonFrontendPassword);
            }
            Login.Login_Test(LegacyTestData.CommonFrontendURL, "originalpass", 1);
        }
        #endregion[TP_215017]

    }
}
