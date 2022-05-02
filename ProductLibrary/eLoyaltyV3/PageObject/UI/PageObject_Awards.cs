using System.Reflection;
using BaseUtility.PageObject;
using eLoyaltyV3.Utility;
using OpenQA.Selenium;

namespace eLoyaltyV3.PageObject.UI
{
    class PageObject_Awards : Setup
    {
        public static string PageName = Constants.Admin;
        public static IWebElement Award_Name()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Award_Name);
        }

        public static IWebElement Click_Award_Tab()
        {
            ScanPage(Constants.Awards);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Award_Tab);
        }

        public static IWebElement Award_Filter()
        {
            ScanPage(Constants.Awards);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Award_Filter);
        }

        public static IWebElement Click_Redemptions_SubTab()
        {
            ScanPage(Constants.Awards);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Redemptions_SubTab);
        }

    }
}
