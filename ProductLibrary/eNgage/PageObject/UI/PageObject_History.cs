using System.Reflection;
using eNgage.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;
using System.Collections.Generic;


namespace eNgage.PageObject.UI
{
    class PageObject_History : Setup
    {
        private static string PageName = Constants.History;

        public static IWebElement Nav_History()
        {
            ScanPage(Constants.History);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementLinkText(ObjectRepository.History_page);
        }
        public static IWebElement History_Container()
        {
            ScanPage(Constants.History);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.History_Container);
        }
        public static IWebElement History_Results_Table()
        {
            ScanPage(Constants.History);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.History_Results_Table);
        }

    }
}
