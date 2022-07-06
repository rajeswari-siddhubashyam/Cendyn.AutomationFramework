using BaseUtility.PageObject;
using CHC_Config.Utility;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Reflection;
using NUnit.Framework;

namespace CHC_Config.PageObject.UI
{
    public class PageObject_CreateUser : Setup
    {
        public static string PageName = CHC_Config.Utility.Constants.CreateUser;
        public static IWebElement Users_Tab()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Tab_Leftnav);
        }

        public static IList<IWebElement> CreateUser_Org_Accounts()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Org_Accounts);
        }

        public static IWebElement Craete_User_Button()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_Button);
        }

        public static IWebElement Create_User_Proceed_Button()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Popup_Proceed);
        }

        public static IWebElement Create_User_Cancel_Button()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Popup_Cancel);
        }

        public static IWebElement Create_User_Email()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Popup_Enter_Email);
        }

        public static IWebElement Create_User_Email_Error()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Popup_Enter_Email_Error);
        }

        public static IWebElement Create_User_FirstName()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_FirstName);
        }

        public static IWebElement Create_User_LastName()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_LastName);
        }

        public static IWebElement Create_User_Email_Disabled()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_Email);
        }

        public static IWebElement Create_User_JobTitle()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_JobTitle);
        }

        public static IWebElement Create_User_FirstName_Error_Msg()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_FirstName_ErrorMsg);
        }

        public static IWebElement Create_User_LastName_Error_Msg()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_LastName_ErrorMsg);
        }

        public static IWebElement Create_User_Continue_Button()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_Continue_Button);
        }

        public static IWebElement Create_User_AssignOrg()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Org_Accounts);
        }

        public static IWebElement Create_User_Select_All()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_Select_All);
        }

        public static IWebElement Create_User_AssignApp()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_CreateUser_AssignApp);
        }

        public static IWebElement Create_User_AssignRoles()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_AssignRoles);
        }

        public static IWebElement Create_User_AssignRoles_Starling_Readonly()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_Roles_Starling_Readonly);
        }

        public static IWebElement Verify_Indexpage_Title()
        {            
                ScanPage(Constants.CreateUser);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath(ObjectRepository.User_Index);
            }
        }

    }

