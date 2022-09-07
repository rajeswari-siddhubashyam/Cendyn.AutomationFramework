using BaseUtility.Utility;
using InfoMessageLogger;
using CHC_Config.PageObject.UI;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace CHC_Config.AppModule.UI
{
    public class Navigation : Setup
    {
        public static void Click_Configurations_App()
        {
            Thread.Sleep(9000);
            Logger.WriteDebugMessage("Home tab");
            //Thread.Sleep(5000);
            //Helper.WaitTillBrowserLoad();            
            //ElementWait(PageObject_Navigation.Configuration_App(), 40);
            //AddDelay(5000);
            Helper.ElementClick(PageObject_Navigation.Configuration_App());
            Helper.WaitTillBrowserLoad();
            Thread.Sleep(9000);
            Logger.WriteDebugMessage("User Clicked on Configuration App & Navigates to Org Index page");
        }
        public static void VerifyPopup()
        {
            Helper.ElementWait(PageObject_Navigation.Btn_PopupChoose(), 10);
            Assert.IsTrue(IsElementVisible(PageObject_Navigation.Btn_PopupChoose()), "Choose button not present in popup");
            Assert.IsTrue(IsElementVisible(PageObject_Navigation.Btn_PopupCancel()), "Cancel button not present in popup");
        }
        public static void ClickOnChooseOnPopup()
        {
            ElementClick(PageObject_Navigation.Btn_PopupChoose());
        }

        public static void VerifyAccounts()
        {
            Helper.ElementWait(PageObject_Navigation.Lnk_Accounts()[0], 10);
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
