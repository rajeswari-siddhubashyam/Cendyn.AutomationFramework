using AMR_Agent.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace AMR_Agent.PageObject.UI
{
    class PageObject_Login : Setup
    {
        /*
        / These methods will return the element on the page by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
        */
        public static IWebElement LoginEmail()
        {
            ScanPage(Constants.ModuleLogin);
            return PageAction.Find_ElementId(ObjectRepository.LoginEmail);
        }

        public static IWebElement LoginPassword()
        {
            ScanPage(Constants.ModuleLogin);
            return PageAction.Find_ElementId(ObjectRepository.LoginPassword);
        }

        public static IWebElement LoginSignIn()
        {
            ScanPage(Constants.ModuleLogin);
            return PageAction.Find_ElementClassName(ObjectRepository.LoginSignIn);
        }

        public static IWebElement LoginForgotPassword()
        {
            ScanPage(Constants.ModuleLogin);
            return PageAction.Find_ElementId(ObjectRepository.LoginForgotPassword);
        }

        public static IWebElement LoginRegisterNow()
        {
            ScanPage(Constants.ModuleLogin);
            return PageAction.Find_ElementClassName(ObjectRepository.LoginRegisterNow);
        }

        public static IWebElement LoginAcceptConsentToCookies()
        {
            ScanPage(Constants.ModuleLogin);
            return PageAction.Find_ElementLinkText(ObjectRepository.LoginRegisterNow);
        }

        public static IWebElement LoginClose()
        {
            ScanPage(Constants.ModuleLogin);
            return PageAction.Find_ElementLinkText(ObjectRepository.Login_Close);
        }



    }
}
