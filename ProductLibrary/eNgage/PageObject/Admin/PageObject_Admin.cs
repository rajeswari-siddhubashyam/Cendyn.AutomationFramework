using System.Reflection;
using eNgage.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;
using System.Collections.Generic;


namespace eNgage.PageObject.UI
{
    class PageObject_Admin : Setup
    {
        private static string PageName = Constants.Admin;

        public static IWebElement Nav_Admin()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementLinkText(ObjectRepository.Admin_page);
        }
        public static IWebElement Admin_Container()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementClassName(ObjectRepository.Admin_Container);
        }
        public static IList<IWebElement> Admin_Tiles()
        {
            ScanPage(Constants.Admin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return Driver.FindElements(By.ClassName(ObjectRepository.Admin_Tiles));
        }
    }
}
