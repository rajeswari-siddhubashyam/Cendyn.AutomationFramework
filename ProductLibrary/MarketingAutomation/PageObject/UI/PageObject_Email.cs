using BaseUtility.PageObject;
using MarketingAutomation.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace MarketingAutomation.PageObject.UI
{
    class PageObject_Email : Setup
    {
        public static string PageName = Utility.Constants.Email;

        public static IWebElement Outlook_Email_Heading()
        {
            ScanPage(Constants.Email);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Outlook_Email_Heading);
        }

        public static IWebElement Outlook_Yahoo_Email_Body()
        {
            ScanPage(Constants.Email);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Outlook_Yahoo_Email_Body);
        }
        public static IWebElement Yahoo_Email_Username()
        {
            ScanPage(Constants.Email);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Yahoo_Email_Username);
        }

        public static IWebElement Yahoo_Email_Next()
        {
            ScanPage(Constants.Email);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Yahoo_Email_Next);
        }

        public static IWebElement Yahoo_Email_Password()
        {
            ScanPage(Constants.Email);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Yahoo_Email_Password);
        }
        public static IWebElement Yahoo_Email_Submit()
        {
            ScanPage(Constants.Email);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Yahoo_Email_Submit);
        }
        public static IWebElement Yahoo_Email_Search_Input()
        {
            ScanPage(Constants.Email);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Yahoo_Email_Search_Input);
        }
        public static IWebElement Yahoo_Email_Searched_Result_Li()
        {
            ScanPage(Constants.Email);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Yahoo_Email_Searched_Result_Li);
        }
        public static IWebElement Outlook_Email_No_Result()
        {
            ScanPage(Constants.Email);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Outlook_Email_No_Result);
        }
        public static IWebElement Yahoo_Email_Sign_In_Link()
        {
            ScanPage(Constants.Email);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Yahoo_Email_Sign_In_Link);
        }
    }
}
    
