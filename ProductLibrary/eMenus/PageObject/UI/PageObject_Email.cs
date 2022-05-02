using System.Reflection;
using BaseUtility.PageObject;
using eMenus.Utility;
using OpenQA.Selenium;

namespace eMenus.PageObject.UI
{
    class PageObject_Email : Setup
    {
        public static string PageName = Utility.Constants.CatchAll;

        public static IWebElement Activation_Email_Link()
        {
            ScanPage(Utility.Constants.CatchAll);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activation_Email_Link);
        }
        public static IWebElement Reset_Password_Button()
        {
            ScanPage(Utility.Constants.CatchAll);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementLinkText(ObjectRepository.Reset_Password_Button);
        }
        public static IWebElement Forgot_Password_Button()
        {
            ScanPage(Utility.Constants.CatchAll);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Forgot_Password_Button);
        }
        public static IWebElement CatchAll_Outlook()
        {
            ScanPage(Utility.Constants.CatchAll);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.OutLookIcon);
        }
        public static IWebElement Catchall_SignIn_Yes_Button()
        {
            ScanPage(Utility.Constants.CatchAll);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SignIn_YesButton);
        }
        public static IWebElement CatchALl_SignIn_DontShowAgain()
        {
            ScanPage(Utility.Constants.CatchAll);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SignIn_DontShowAgainCheckBox);
        }
        public static IWebElement CatchAll_SignIn_Email()
        {
            ScanPage(Utility.Constants.CatchAll);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.catchAll_SignIn_Email);
        }
        public static IWebElement CatchAll_SignIn_Password()
        {
            ScanPage(Utility.Constants.CatchAll);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.catchAll_SignIn_Password);
        }
        public static IWebElement CatchAll_SignIn_Button()
        {
            ScanPage(Utility.Constants.CatchAll);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.catchAll_SignIn_Button);
        }
        public static IWebElement CatchAll_Email()
        {
            ScanPage(Utility.Constants.CatchAll);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CatchAll_Recent_Email);
        }
        public static IWebElement CatchAll_Recent_Email()
        {
            ScanPage(Utility.Constants.CatchAll);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CatchAll_Recent_Email1);
        }
        public static IWebElement CatchAll_SupportEmail()
        {
            ScanPage(Utility.Constants.CatchAll);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Support_Email);
        }
        public static IWebElement Share_Menu_Email()
        {
            ScanPage(Utility.Constants.CatchAll);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Share_Menu_Email);
        }
        public static IWebElement Login_Cendyn_Access()
        {
            ScanPage(Utility.Constants.CatchAll);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Login_Cendyn_Access);
        }
    }
}
