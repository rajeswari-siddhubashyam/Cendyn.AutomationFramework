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

        public static IWebElement Manage_Property()
        {
            ScanPage(Constants.Create);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Manage_Property);
        }
        public static IWebElement Manage_Brand()
        {
            ScanPage(Constants.Create);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Manage_Brand);
        }
        public static IWebElement Edit_Details()
        {
            ScanPage(Constants.Create);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Edit_Details);
        }
        public static IWebElement input_chain()
        {
            ScanPage(Constants.Create);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.input_chain);
        }
        public static IWebElement input_brand()
        {
            ScanPage(Constants.Create);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.input_brand);
        }
        public static IWebElement input_property()
        {
            ScanPage(Constants.Create);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.input_property);
        }

    }
}
