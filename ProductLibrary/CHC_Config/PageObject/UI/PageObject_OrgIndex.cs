using BaseUtility.PageObject;
using CHC_Config.Utility;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Reflection;


namespace CHC_Config.PageObject.UI
{
    class PageObject_OrgIndex : Setup
    {
        public static string PageName = CHC_Config.Utility.Constants.OrgIndex;

        public static IWebElement Org_Table()
        {
            ScanPage(Constants.OrgIndex);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.OrgIndex_table);
        }
        public static IList<IWebElement> OrgIndex_Columns()
        {
            ScanPage(Constants.OrgIndex);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return Driver.FindElements(By.CssSelector(ObjectRepository.OrgIndex_th_td));
        }
        public static IWebElement Filter_PropertyName()
        {
            ScanPage(Constants.OrgIndex);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Filter_PropertyName);
        }
        public static IWebElement Filter_PropertyName_Search()
        {
            ScanPage(Constants.OrgIndex);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Filter_PropertyName_Search);
        }
        public static IWebElement SearchResults_Row()
        {
            ScanPage(Constants.OrgIndex);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SearchResults_Row);
        }
        public static IWebElement SearchResults_PropertyName()
        {
            ScanPage(Constants.OrgIndex);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SearchResults_PropertyName);
        }
        public static IWebElement SearchResults_Brand()
        {
            ScanPage(Constants.OrgIndex);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SearchResults_Brand);
        }
        public static IWebElement SearchResults_Chain()
        {
            ScanPage(Constants.OrgIndex);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SearchResults_Chain);
        }
        public static IWebElement OrgIndex_loading()
        {
            ScanPage(Constants.OrgIndex);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.OrgIndex_loading);
        }
        public static IList<IWebElement> Create_list()
        {
            ScanPage(Constants.OrgIndex);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Create_List);
        }
        

    }
}
