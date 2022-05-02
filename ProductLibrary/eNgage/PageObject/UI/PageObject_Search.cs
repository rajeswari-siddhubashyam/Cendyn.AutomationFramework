using System.Reflection;
using eNgage.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace eNgage.PageObject.UI
{
    class PageObject_Search : Setup
    {
        private static string PageName = Constants.Search;

        public static IWebElement Nav_Search()
        {
            ScanPage(Constants.Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementLinkText(ObjectRepository.Search_page);
        }

        public static IWebElement Search_Div()
        {
            ScanPage(Constants.Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Search_Div);
        }
        public static IWebElement Search_Results()
        {
            ScanPage(Constants.Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Search_Results).FindElement(By.TagName("tbody"));
        }

        public static IWebElement Search_Select()
        {
            ScanPage(Constants.Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return Search_Div().FindElement(By.Name(ObjectRepository.Search_Select));
        }

        public static IList<IWebElement> Search_Input()
        {
            ScanPage(Constants.Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return Search_Div().FindElements(By.Name(ObjectRepository.Search_Input));
        }
       
        public static IWebElement Search_submit()
        {
            ScanPage(Constants.Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return Search_Div().FindElement(By.XPath(ObjectRepository.Search_submit));
        }
        public static IWebElement Search_Button_MoreValues()
        {
            ScanPage(Constants.Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return Search_Div().FindElement(By.CssSelector(ObjectRepository.Search_Type_button));
        }
        public static IList<IWebElement> Search_Button_Listed_Values()
        {
            ScanPage(Constants.Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return Search_Div().FindElements(By.ClassName(ObjectRepository.Search_Type_button_values));
        }

    }
}
