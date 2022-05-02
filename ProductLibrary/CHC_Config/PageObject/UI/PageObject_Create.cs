using BaseUtility.PageObject;
using CHC_Config.Utility;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Reflection;


namespace CHC_Config.PageObject.UI
{
    class PageObject_Create : Setup
    {
        public static string PageName = CHC_Config.Utility.Constants.Create;
        public static IWebElement Create_Button()
        {
            ScanPage(Constants.Create);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Create_Button);
        }
        
        public static IWebElement createPage_header()
        {
            ScanPage(Constants.Create);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.createPage_header);
        }
        public static IWebElement create_cancel()
        {
            ScanPage(Constants.Create);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.create_cancel);
        }
        

    }
}
