using BaseUtility.PageObject;
using eMenus.Utility;
using OpenQA.Selenium;
using System.Reflection;

namespace eMenus.PageObject.UI
{
    public class PageObject_SignIn : Setup
    {
        public static string PageName = Utility.Constants.SignIn;

        public static IWebElement TextBox_Username()
        {
            ScanPage(Utility.Constants.SignIn);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignIn_UserName);
        }
        public static IWebElement TextBox_Password()
        {
            ScanPage(Utility.Constants.SignIn);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignIn_Password);
        }
        public static IWebElement Button_SignIn()
        {
            ScanPage(Utility.Constants.SignIn);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignIn_Button);
        }
        public static IWebElement Validation_Message()
        {
            ScanPage(Utility.Constants.SignIn);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Validation_Message);
        }
        public static IWebElement Next_Button()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Next_Button);
        }
        public static IWebElement Enter_Email_Password()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Enter_Email_Password);
        }
        public static IWebElement Login_Button()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Login_Button);
        }

        public static IWebElement Enter_Email_Address()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Enter_Email_Address);
        }

    }
}
