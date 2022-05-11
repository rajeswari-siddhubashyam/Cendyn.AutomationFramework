using BaseUtility.PageObject;
using CHC_Unified_Profile.Utility;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Reflection;

namespace CHC_Unified_Profile.PageObject.UI
{
    public class PageObject_Home : Setup
    {
        public static string PageName = Utility.Constants.Home;

        public static IList<IWebElement> Ele_Applications()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Home_Applications);
        }

        public static IWebElement Ele_StarlingApp()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Starling_App);
        }

        public static IWebElement Ele_UnifiedProfileApp()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Unified_Profile_App);
        }

        public static IWebElement Btn_PopupChoose()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_PopupChoose);
        }
        public static IWebElement Btn_PopupCancel()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_PopupCancel);
        }

        public static IWebElement Ele_MouseOverLogout()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.UserAccountMouseover);
        }

        public static IWebElement Btn_UserLogout()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Logout);
        }

        public static IWebElement Icon_Expandable()
        {
            try
            {
                ScanPage(Constants.Home);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return Driver.FindElement(By.XPath(ObjectRepository.ExpandableIcon));
                //return PageAction.Find_ElementXPath(ObjectRepository.ExpandableIcon);
            }
            catch
            {
                return null;
            }
        }

        public static IList<IWebElement> Lnk_Accounts()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Accounts);
        }
        public static IWebElement Ele_AccountPageName()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AccountPageName);
        }
    }
}

