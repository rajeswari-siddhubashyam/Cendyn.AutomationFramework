using System.Reflection;
using eNgage.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eNgage.PageObject.UI
{
    public class PageObject_Login : Setup
    {

        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/
        private static string PageName = Constants.Login;

        public static IWebElement Email()
        {
            ScanPage(Constants.Login);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Login_Email);
        }

        public static IWebElement Password()
        {
            ScanPage(Constants.Login);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Login_Password);
        }

        public static IWebElement Submit()
        {
            ScanPage(Constants.Login);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Login_Submit);
        }

        public static IWebElement ForgotPassword()
        {
            ScanPage(Constants.Login);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Login_ForgotPassword);
        }

        public static IWebElement Text_ForgotPassword_Email()
        {
            ScanPage(Constants.Login);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Login_Text_ForgotPassword_Email);
        }

        public static IWebElement Button_ForgotPassword_Submit()
        {
            ScanPage(Constants.Login);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Login_Button_ForgotPassword_Submit);
        }
        public static IWebElement Login_LandingPage()
        {
            ScanPage(Constants.Login);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementCssSelector(ObjectRepository.Login_LandingPage);
        }

        public static IWebElement CreateAccount()
        {
            ScanPage(Constants.Login);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Login_RegisterAccount);
        }


    }
}