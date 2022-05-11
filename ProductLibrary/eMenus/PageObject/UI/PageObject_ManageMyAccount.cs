using System.Reflection;
using BaseUtility.PageObject;
using eMenus.Utility;
using OpenQA.Selenium;

namespace eMenus.PageObject.UI
{
    class PageObject_ManageMyAccount : Setup
    {
        public static string PageName = Utility.Constants.ManageMyAccount;
        public static IWebElement Click_MyOrder_ManageMyAccount()
        {
            ScanPage(Utility.Constants.ManageMyAccount);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MyOrder_ManageMyAccount);
        }
        public static IWebElement Click_MyOrder_MyOrder()
        {
            ScanPage(Utility.Constants.ManageMyAccount);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MyOrder_MyOrder);
        }
        
        public static IWebElement ManageMyAccount_FirstName()
        {
            ScanPage(Utility.Constants.ManageMyAccount);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageMyAccount_FirstName);
        }
        public static IWebElement ManageMyAccount_LastName()
        {
            ScanPage(Utility.Constants.ManageMyAccount);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageMyAccount_LastName);
        }
        public static IWebElement ManageMyAccount_Address()
        {
            ScanPage(Utility.Constants.ManageMyAccount);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageMyAccount_Address);
        }
        public static IWebElement ManageMyAccount_Address2()
        {
            ScanPage(Utility.Constants.ManageMyAccount);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageMyAccount_Address2);
        }
        public static IWebElement ManageMyAccount_Country()
        {
            ScanPage(Utility.Constants.ManageMyAccount);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageMyAccount_Country);
        }
        public static IWebElement ManageMyAccount_State()
        {
            ScanPage(Utility.Constants.ManageMyAccount);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageMyAccount_State);
        }
        public static IWebElement ManageMyAccount_City()
        {
            ScanPage(Utility.Constants.ManageMyAccount);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageMyAccount_City);
        }
        public static IWebElement ManageMyAccount_PostalCode()
        {
            ScanPage(Utility.Constants.ManageMyAccount);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageMyAccount_PostalCode);
        }
        public static IWebElement ManageMyAccount_Phone()
        {
            ScanPage(Utility.Constants.ManageMyAccount);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageMyAccount_Phone);
        }
        public static IWebElement ManageMyAccount_Company()
        {
            ScanPage(Utility.Constants.ManageMyAccount);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageMyAccount_Company);
        }
        public static IWebElement ManageMyAccount_BackButton()
        {
            ScanPage(Utility.Constants.ManageMyAccount);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageMyAccount_BackButton);
        }
        public static IWebElement ManageMyAccount_UpdateButton()
        {
            ScanPage(Utility.Constants.ManageMyAccount);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementName(ObjectRepository.ManageMyAccount_UpdateButton);
        }
        public static IWebElement ManageMyAccount_PhoneValidation()
        {
            ScanPage(Utility.Constants.ManageMyAccount);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageMyAccount_PhoneValidation);
        }
        public static IWebElement ManageMyAccount_FirstnameValidation()
        {
            ScanPage(Utility.Constants.ManageMyAccount);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageMyAccount_FirstName_Validation);
        }
        public static IWebElement ManageMyAccount_LastNameValidation()
        {
            ScanPage(Utility.Constants.ManageMyAccount);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageMyAccount_LastName_Validation);
        }
        public static IWebElement ManageMyAccount_Update_Password_Checkbox()
        {
            ScanPage(Utility.Constants.ManageMyAccount);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Update_Password_Checkbox);
        }
        public static IWebElement ManageMyAccount_Update_Password()
        {
            ScanPage(Utility.Constants.ManageMyAccount);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Update_Password);
        }
        public static IWebElement ManageMyAccount_Update_Confirm_Password()
        {
            ScanPage(Utility.Constants.ManageMyAccount);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Update_Confirm_Password);
        }
    }
}
