using System.Reflection;
using eInsight.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eInsight.PageObject.UI
{
    class PageObject_Admin : Setup
    {
        public static string PageName = Constants.Admin;

        public static IWebElement Click_Open_SpecificPropertySetting(string settingName)
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Open_SpecificPropertySetting.Replace("[SettingName]", settingName));
        }
        public static IWebElement Click_AllTabs()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AllTabs);
        }
        public static IWebElement Click_Tab_CompanySettings()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Tab_CompanySettings);
        }
        public static IWebElement Element_SettingValue()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_CompanySetting_Textbox_SettingValue);
        }
        public static IWebElement Admin_CompanySetting_Button_Submit()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Admin_CompanySetting_Button_Submit);
        }

    }
}
