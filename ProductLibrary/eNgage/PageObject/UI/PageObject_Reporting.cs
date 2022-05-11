using System.Reflection;
using eNgage.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;
using System.Collections.Generic;


namespace eNgage.PageObject.UI
{
    class PageObject_Reporting : Setup
    {
        private static string PageName = Constants.Reporting;

        public static IWebElement Nav_Reporting()
        {
            ScanPage(Constants.Reporting);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementLinkText(ObjectRepository.Reporting_page);
        }
        public static IWebElement Reporting_Container()
        {
            ScanPage(Constants.Reporting);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementClassName(ObjectRepository.Reporting_Container);
        }
        public static IWebElement Reporting_Results_Table()
        {
            ScanPage(Constants.Reporting);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementClassName(ObjectRepository.Reporting_Results_Table);
        }
        
    }
}
