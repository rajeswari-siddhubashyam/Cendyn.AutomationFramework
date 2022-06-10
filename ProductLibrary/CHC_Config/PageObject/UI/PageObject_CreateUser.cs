﻿using BaseUtility.PageObject;
using CHC_Config.Utility;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Reflection;

namespace CHC_Config.PageObject.UI
{
    public class PageObject_CreateUser : Setup
    {
        public static string PageName = CHC_Config.Utility.Constants.CreateUser;
        public static IWebElement Users_Tab()
        {
            ScanPage(Constants.Create);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Tab_Leftnav);
        }

        public static IWebElement Craete_User_Button()
        {
            ScanPage(Constants.Create);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_Button);
        }

        public static IWebElement Create_User_Proceed_Button()
        {
            ScanPage(Constants.Create);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Popup_Proceed);
        }

        public static IWebElement Create_User_Cancel_Button()
        {
            ScanPage(Constants.Create);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Popup_Cancel);
        }

        public static IWebElement Create_User_Email()
        {
            ScanPage(Constants.Create);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Popup_Enter_Email);
        }

        public static IWebElement Create_User_Email_Error()
        {
            ScanPage(Constants.Create);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Popup_Enter_Email_Error);
        }

        public static IWebElement Create_User_FirstName()
        {
            ScanPage(Constants.Create);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_FirstName);
        }

        public static IWebElement Create_User_LastName()
        {
            ScanPage(Constants.Create);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_LastName);
        }

        public static IWebElement Create_User_Email_Disabled()
        {
            ScanPage(Constants.Create);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_Email);
        }

        public static IWebElement Create_User_JobTitle()
        {
            ScanPage(Constants.Create);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_JobTitle);
        }

        public static IWebElement Create_User_FirstName_Error_Msg()
        {
            ScanPage(Constants.Create);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_FirstName_ErrorMsg);
        }

        public static IWebElement Create_User_LastName_Error_Msg()
        {
            ScanPage(Constants.Create);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_LastName_ErrorMsg);
        }

        public static IWebElement Create_User_Continue_Button()
        {
            ScanPage(Constants.Create);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_Continue_Button);
        }

    }
}