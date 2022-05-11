using System.Reflection;
using BaseUtility.PageObject;
using eMenus.Utility;
using OpenQA.Selenium;

namespace eMenus.PageObject.UI
{
    class PageObject_MyOrders : Setup
    {
        public static string PageName = Utility.Constants.MyOrders;
        public static IWebElement Click_CreateNewOrder()
        {
            ScanPage(Utility.Constants.MyOrders);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Click_CreateNewOrder);
        }
        public static IWebElement Enter_EventName()
        {
            ScanPage(Utility.Constants.MyOrders);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_EventName);
        }
        public static IWebElement FromDate()
        {
            ScanPage(Utility.Constants.MyOrders);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.FromDate);
        }
        public static IWebElement ToDate()
        {
            ScanPage(Utility.Constants.MyOrders);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ToDate);
        }
        public static IWebElement Click_CancelButton()
        {
            ScanPage(Utility.Constants.MyOrders);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_CancelButton);
        }
        public static IWebElement Click_SaveButton()
        {
            ScanPage(Utility.Constants.MyOrders);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Click_SaveButton);
        }
        public static IWebElement Search_Filter()
        {
            ScanPage(Utility.Constants.MyOrders);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Search_Filter);
        }
        
    }
}
