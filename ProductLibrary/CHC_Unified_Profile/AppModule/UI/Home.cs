using BaseUtility.Utility;
using CHC_Unified_Profile.PageObject.UI;
using InfoMessageLogger;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CHC_Unified_Profile.AppModule.UI
{
    class Home : Helper
    {
        /// <summary>
        /// This method will enter the email address on the CHC SignIn page.
        /// </summary>
        /// <param name="email">email to enter</param>
        public static void VerifyApplications()
        {
            IList<IWebElement> ele_Applications = PageObject_Home.Ele_Applications();

            foreach (IWebElement ele_Application in ele_Applications)
            {
                Assert.IsNotNull(GetText(ele_Application), "Applications are not loaded");
            }
        }

        /// <summary>
        /// This method will click on SignIn button on the  CHC SignIn page.
        /// </summary>
        public static void ClickOnStarlingApp()
        {
            Helper.ElementWait(PageObject_Home.Ele_StarlingApp(), 10);
            ElementClick(PageObject_Home.Ele_StarlingApp());

        }

        public static void VerifyPopup()
        {
            Assert.IsTrue(IsElementVisible(PageObject_Home.Btn_PopupChoose()), "Choose button not present in popup");
            Assert.IsTrue(IsElementVisible(PageObject_Home.Btn_PopupCancel()), "Cancel button not present in popup");
        }
        public static void ClickOnChooseOnPopup()
        {
            ElementClick(PageObject_Home.Btn_PopupChoose());
        }

        public static void VerifyAccounts()
        {
            Assert.IsTrue(IsElementDisplayed(PageObject_Home.Lnk_Accounts()[0]), "Accounts are not loaded");
        }
        public static void ClickUserLogout()
        {
            DynamicScroll(Helper.Driver, PageObject_Home.Ele_MouseOverLogout());
            ElementHover(PageObject_Home.Ele_MouseOverLogout());
            Logger.WriteDebugMessage("User should Logged out");
            Helper.ElementWait(PageObject_Home.Btn_UserLogout(), 10);
            ElementClick(PageObject_Home.Btn_UserLogout());
        }

        public static void ClickExpandIcons()
        {
            while (PageObject_Home.Icon_Expandable() != null)
            {
                ElementClick(PageObject_Home.Icon_Expandable());
            }
        }

        public static void Click_Accounts(string accountName)
        {
            foreach (IWebElement ele_Account in PageObject_Home.Lnk_Accounts())
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
            Helper.ElementWait(PageObject_Home.Ele_AccountPageName(), 30);
            Assert.IsTrue(GetText(PageObject_Home.Ele_AccountPageName()).Contains(accountName), "Account page name not loaded properly");
        }
    
    }
}
