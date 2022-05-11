using System.Reflection;
using BaseUtility.PageObject;
using eMenus.Utility;
using OpenQA.Selenium;

namespace eMenus.PageObject.UI
{
    class PageObject_ForgetPassword : Setup
    {
        public static string PageName = Utility.Constants.ForgetPassword;
        public static IWebElement Click_ForgetPassword()
        {
            ScanPage(Utility.Constants.ForgetPassword);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_ForgetPassword);
        }
        public static IWebElement Click_ForgetPassword_BackButton()
        {
            ScanPage(Utility.Constants.ForgetPassword);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_ForgetPassword_BackButton);
        }
        public static IWebElement ForgetPassword_Email()
        {
            ScanPage(Utility.Constants.ForgetPassword);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ForgetPassword_Email);
        }
        public static IWebElement Click_ForgetPassword_SendButton()
        {
            ScanPage(Utility.Constants.ForgetPassword);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Click_ForgetPassword_SendButton);
        }
        public static IWebElement Forget_Password_Validation()
        {
            ScanPage(Utility.Constants.ForgetPassword);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Forget_Password_Validation);
        }
        public static IWebElement Forget_Password_Confirmation_Back()
        {
            ScanPage(Utility.Constants.ForgetPassword);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ForgetPassword_Confirmation_Back);
        }
        public static IWebElement ResetPassword_Email()
        {
            ScanPage(Utility.Constants.ForgetPassword);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ResetPassword_Email);
        }
        public static IWebElement ResetPassword_Password()
        {
            ScanPage(Utility.Constants.ForgetPassword);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ResetPassword_Password);
        }
        public static IWebElement ResetPassword_ConfirmPassword()
        {
            ScanPage(Utility.Constants.ForgetPassword);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ResetPassword_ConfirmPassword);
        }
        public static IWebElement ResetPassword_Button()
        {
            ScanPage(Utility.Constants.ForgetPassword);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ResetPassword_Button);
        }
    }
}
