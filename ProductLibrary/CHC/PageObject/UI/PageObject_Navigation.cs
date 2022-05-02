using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BaseUtility.PageObject;
using CHC.Utility;

namespace CHC.PageObject.UI
{
    class PageObject_Navigation : Setup
    {
        public static string PageName = Utility.Constants.Home;

        public static IWebElement Configuration_App()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Configuration_App);

        }

        public static IWebElement Marketing_Automation_App()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Marketing_Automation_App);

        }

        public static IWebElement Starling_App()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Starling_App);
        }

        

        public static IWebElement getCardBody_App()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_GetCardBody_App);
        }
        public static IWebElement Unified_Profile_App()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Unified_Profile_App);

        }
       
    }
}
