using BaseUtility.PageObject;
using CHC_Config.Utility;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Reflection;

namespace CHC_Config.PageObject.UI
{
    class PageObject_Navigation : Setup
    {
        public static string PageName = CHC_Config.Utility.Constants.Home;
        public static IWebElement Configuration_App()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Configuration_App);
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
