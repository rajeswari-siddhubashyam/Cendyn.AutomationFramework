using System.Reflection;
using eNgage.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace eNgage.PageObject.UI
{
    class PageObject_Preferences : Setup
    {
        private static string PageName = Constants.Preferences;

        public static IWebElement Nav_Preferences()
        {
            ScanPage(Constants.Preferences);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementLinkText(ObjectRepository.Preferences_page);
        }

        public static IWebElement Preferences_Div()
        {
            ScanPage(Constants.Preferences);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Preferences_div);
        }

        public static IList<IWebElement> Preferences_SelectElements()
        {
            ScanPage(Constants.Preferences);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return Preferences_Div().FindElements(By.ClassName(ObjectRepository.Preferences_SelectElements));
        }
        public static IList<IWebElement> Preferences_CheckBox()
        {
            ScanPage(Constants.Preferences);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return Preferences_Div().FindElements(By.XPath(ObjectRepository.Preferences_checkbox));
        }
        public static IWebElement Preferences_Save()
        {
            ScanPage(Constants.Preferences);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return Preferences_Div().FindElement(By.XPath(ObjectRepository.Preferences_save));
        }
          public static IWebElement Preferences_SavedText()
        {
            ScanPage(Constants.Preferences);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return Preferences_Div().FindElement(By.Id(ObjectRepository.Preferences_SavedText));
        }


    }
}
