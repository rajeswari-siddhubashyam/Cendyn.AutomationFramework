using AMR_Agent.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace AMR_Agent.PageObject.UI
{
    class PageObject_AdminLogin : Setup
    {
        /*
        / These methods will return the element on the page by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
        */

        public static IWebElement AdminLoginEmail()
        {
            ScanPage(Constants.ModuleAdminLogin);
            return PageAction.Find_ElementId(ObjectRepository.AdminLoginEmail);
        }

        public static IWebElement AdminLoginPassword()
        {
            ScanPage(Constants.ModuleAdminLogin);
            return PageAction.Find_ElementId(ObjectRepository.AdminLoginPassword);
        }

        public static IWebElement AdminLoginForgotPassword()
        {
            ScanPage(Constants.ModuleAdminLogin);
            return PageAction.Find_ElementClassName(ObjectRepository.AdminLoginForgotPassword);
        }

        public static IWebElement AdminLoginSignIn()
        {
            ScanPage(Constants.ModuleAdminLogin);
            return PageAction.Find_ElementClassName(ObjectRepository.AdminLoginSignIn);
        }


    }
}
