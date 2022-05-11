using BaseUtility.PageObject;
using CHC_Unified_Profile.Utility;
using OpenQA.Selenium;
using System.Reflection;

namespace CHC_Unified_Profile.PageObject.UI
{
    public class PageObject_SignIn : Setup
    {
        public static string PageName = Utility.Constants.SignIn;

        public static IWebElement Input_Email()
        {
            ScanPage(Constants.SignIn);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignIn_Email);
        }

        public static IWebElement Login_Signin_Text()
        {
            ScanPage(Constants.SignIn);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignIn_Text);
        }

        public static IWebElement Input_Password()
        {
            ScanPage(Constants.SignIn);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignIn_Password);
        }

        public static IWebElement Input_Email_Test()
        {
            ScanPage(Constants.SignIn);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignIn_Email_Testuser);
        }

        public static IWebElement Input_Password_Test()
        {
            ScanPage(Constants.SignIn);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignIn_Password_Testuser);
        }

        public static IWebElement Button_SignIn()
        {
            ScanPage(Constants.SignIn);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignIn_Submit);
        }
    }
}

