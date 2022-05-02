using System.Reflection;
using eProposal.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eProposal.PageObject.Admin
{
    internal class PageObject_AdminUsers : Setup
    {
        /*
        / These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
       */

        public static string PageName = Constants.AdminUsers;

        public static IWebElement AdminUsers_View_ShowAll_Signature()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_View_ShowAll_Signature);
        }

        public static IWebElement AdminUsers_Button_Yes()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_Button_Yes);
        }

        public static IWebElement AdminUsers_Button_No()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_Button_No);
        }

        public static IWebElement AdminUsers_View_CustomSignatureValidator()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_View_CustomSignatureValidator);
        }

        public static IWebElement AdminUsers_Button_Update()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_Button_Update);
        }

        public static IWebElement AdminUsers_Link_Remove()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_Link_Remove);
        }

        public static IWebElement AdminUsers_Link_EditFirstUser()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_Link_EditFirstUser);
        }

        public static IWebElement AdminUsers_Link_LogIn()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_Link_LogIn);
        }

        public static IWebElement AdminUsers_Text_Search()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_Text_Search);
        }

        public static IWebElement AdminUsers_Button_Search()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_Button_Search);
        }

        public static IWebElement AdminUsers_Link_Search()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_Link_Search);
        }

        public static IWebElement AdminUsers_Dropdown_Option1()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_Dropdown_Option1);
        }

        public static IWebElement AdminUsers_Dropdown_Option2()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_Dropdown_Option2);
        }

        public static IWebElement AdminUsers_Input_Searchbox()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_Input_Searchbox);
        }

        public static IWebElement AdminUsers_Link_Edit()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_Link_Edit);
        }

        public static IWebElement AdminUsers_Button_ChooseFile()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_Button_ChooseFile);
        }

        public static IWebElement AdminUsers_EmployeeUpdate_CustomSignatureImage()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_EmployeeUpdate_CustomSignatureImage);
        }

        public static IWebElement AdminUsers_Link_LoginShowAll()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminUsers_Link_LoginShowAll);
        }

        public static IWebElement AdminUsers_Link_AddNewUser()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_Link_AddNewUser);
        }

        public static IWebElement AdminUsers_Text_Firstname()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_Text_Firstname);
        }

        public static IWebElement AdminUsers_Text_Lastname()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_Text_Lastname);
        }

        public static IWebElement AdminUsers_Text_Email()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_Text_Email);
        }

        public static IWebElement AdminUsers_Text_Password()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_Text_Password);
        }

        public static IWebElement AdminUsers_Link_UserRole()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminUsers_Link_UserRole);
        }

        public static IWebElement AdminUsers_Dropdown_SelectLevel()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_Dropdown_SelectLevel);
        }

        public static IWebElement AdminUsers_Text_PropertyName()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_Text_PropertyName);
        }

        public static IWebElement AdminUsers_Button_SearchProperty()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_Button_SearchProperty);
        }

        public static IWebElement AdminUsers_Checkbox_Property()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_Checkbox_Property);
        }

        public static IWebElement AdminUsers_Arrow_AddToRight()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_Arrow_AddToRight);
        }

        public static IWebElement AdminUsers_Button_Submit()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_Button_Submit);
        }

        public static IWebElement AdminUsers_Button_Save()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_Button_Save);
        }

        public static IWebElement AdminUsers_RadioButton_AccessSetting()
        {
            ScanPage(Constants.AdminUsers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminUsers_RadioButton_AccessSetting);
        }
    }
}