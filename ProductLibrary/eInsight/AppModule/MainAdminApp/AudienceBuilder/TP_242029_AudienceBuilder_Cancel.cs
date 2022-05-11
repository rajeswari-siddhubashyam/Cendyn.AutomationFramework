using System;
using eInsight.Utility;
using eInsight.AppModule.UI;
using Common;
using Constants = eInsight.Utility.Constants;
using InfoMessageLogger;
using BaseUtility.Utility;
using BaseUtility.Utility.Hotmail;
using TestData;
using SqlWarehouse;
using OpenQA.Selenium;
using NUnit.Framework;
using eInsight.AppModule.UI;
using eInsight.PageObject.UI;
using System.Text.RegularExpressions;

namespace eInsight.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        #region[TP_242029]
        public static void TC_237158()
        {
            //Profile.SelectClient(CompanyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");

            AudienceBuilder.Click_AB_AddNewAudience();
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            if (IsElementVisible(PageObject_AudienceBuilder.Click_ABEdit_CancelButton()))
            {
                Logger.WriteDebugMessage("Landed on Add/Edit Audience.");
                AudienceBuilder.Click_ABEdit_CancelButton();
                if (IsElementVisible(Driver.FindElement(By.Id("selectField"))))
                {
                    Logger.WriteDebugMessage("Landed on Audience Builder Search Grid.");
                }
            }
            else
            {
                Assert.Fail("Didnot land on Add/Edit Audience.");
            }
        }
        public static void TC_237159()
        {
            //Profile.SelectClient(CompanyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");

            AudienceBuilder.Click_AB_AddNewAudience();
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
            Driver.FindElement(By.XPath("(//input[@type='text'])[3]")).SendKeys(Keys.Enter);
            Logger.WriteDebugMessage("Added Property List.");

            AudienceBuilder.Click_ABEdit_CancelButton();
            if (VerifyTextOnPage("If you close your Audience now, your changes will be lost."))
            {
                Logger.WriteDebugMessage("Landed on confirmation to cancel. Verified that Confirmation message exist on the page" + "\n If you close your Audience now, your changes will be lost.");
                AudienceBuilder.Click_ABEdit_StayOnPage();
            }
            else
            {
                Assert.Fail("Did not land on confirmation page.");
            }
        }
        public static void TC_237161()
        {
            //Profile.SelectClient(CompanyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");

            AudienceBuilder.Click_AB_AddNewAudience();
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
            Driver.FindElement(By.XPath("(//input[@type='text'])[3]")).SendKeys(Keys.Enter);
            Logger.WriteDebugMessage("Added Property List.");

            AudienceBuilder.Click_ABEdit_CancelButton();
            if (VerifyTextOnPage("If you close your Audience now, your changes will be lost."))
            {
                Logger.WriteDebugMessage("Landed on confirmation to cancel.");
                AudienceBuilder.Click_ABEdit_LeavePage();
            }
            else
            {
                Assert.Fail("Did not land on confirmation page.");
            }
        }

    }
}
#endregion[TP_242029]