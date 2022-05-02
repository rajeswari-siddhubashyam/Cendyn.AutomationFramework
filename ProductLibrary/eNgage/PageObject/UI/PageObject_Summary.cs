using System.Reflection;
using eNgage.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eNgage.PageObject.UI
{
    class PageObject_Summary : Setup
    {
        private static string PageName = Constants.Summary;

        public static IWebElement Nav_Summary()
        {
            ScanPage(Constants.Summary);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementLinkText(ObjectRepository.Summary_page);
        }
    }
}
