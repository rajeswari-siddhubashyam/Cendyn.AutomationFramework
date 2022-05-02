using BaseUtility.Utility;
using InfoMessageLogger;
using CHC_Config.PageObject.UI;
using NUnit.Framework;
using OpenQA.Selenium;

namespace CHC_Config.AppModule.UI
{
    public class Navigation : Setup
    {
        public static void Click_Configurations_App()
        {
            Logger.WriteDebugMessage("Home tab");
            Helper.WaitTillBrowserLoad();
            //WaittillElementDisplay(PageObject_Navigation.Configuration_App());
            ElementWait(PageObject_Navigation.Configuration_App(), 10);
            Helper.ElementClick(PageObject_Navigation.Configuration_App());
            Helper.WaitTillBrowserLoad();
        }
        public static void VerifyPopup()
        {
            Assert.IsTrue(IsElementVisible(PageObject_Navigation.Btn_PopupChoose()), "Choose button not present in popup");
            Assert.IsTrue(IsElementVisible(PageObject_Navigation.Btn_PopupCancel()), "Cancel button not present in popup");
        }
        public static void ClickOnChooseOnPopup()
        {
            ElementClick(PageObject_Navigation.Btn_PopupChoose());
        }

        public static void VerifyAccounts()
        {
            Assert.IsTrue(IsElementDisplayed(PageObject_Navigation.Lnk_Accounts()[0]), "Accounts are not loaded");
        }
        public static void ClickExpandIcons()
        {
            while (PageObject_Navigation.Icon_Expandable() != null)
            {
                ElementClick(PageObject_Navigation.Icon_Expandable());
            }
        }

        public static void Click_Accounts(string accountName)
        {
            foreach (IWebElement ele_Account in PageObject_Navigation.Lnk_Accounts())
            {
                if (GetText(ele_Account).Contains(accountName))
                {
                    ElementClick(ele_Account);
                    break;
                }
            }
        }

        public static void VerifyAccountPage(string accountName)
        {
            AddDelay(7000);
            Helper.ElementWait(PageObject_Navigation.Ele_AccountPageName(), 30);
            Assert.IsTrue(GetText(PageObject_Navigation.Ele_AccountPageName()).Contains(accountName), "Account page name not loaded properly");
        }
    }
}
