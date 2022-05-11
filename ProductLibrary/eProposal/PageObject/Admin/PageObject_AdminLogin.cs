using System.Reflection;
using eProposal.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eProposal.PageObject.Admin
{
    public class PageObject_AdminLogin : Setup
    {
        public static string PageName = Constants.AdminLogin;

        public static IWebElement Text_UserName()
        {
            ScanPage(Constants.AdminLogin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminLogin_Text_UserName);
        }

        public static IWebElement Text_Password()
        {
            ScanPage(Constants.AdminLogin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminLogin_Text_Password);
        }

        public static IWebElement Button_LogIn()
        {
            ScanPage(Constants.AdminLogin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminLogin_Button_LogIn);
        }
    }
}