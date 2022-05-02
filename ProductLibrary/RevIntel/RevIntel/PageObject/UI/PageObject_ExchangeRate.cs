using RevIntel.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;
using System.Reflection;

namespace RevIntel.PageObject.UI
{
    class PageObject_ExchangeRate : Setup
    {
        public static string PageName = Utility.Constants.ExchangeRate;

        public static IWebElement Click_ViewAnalysis()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Click_ViewAnalysis);
        }
    }
}

