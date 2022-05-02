using RevIntel.Utility;
using BaseUtility.PageObject;
using System.Reflection;
using OpenQA.Selenium;

namespace RevIntel.PageObject.UI
{
    class PageObject_Login : Setup
    {
        public static string PageName = Utility.Constants.Login;

        public static IWebElement Enter_EmailAddress()
        {
            ScanPage(Utility.Constants.Login);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_EmailAddress);
        }
        public static IWebElement Enter_Password()
        {
            ScanPage(Utility.Constants.Login);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Password);
        }
        public static IWebElement Click_SignIn_Button()
        {
            ScanPage(Utility.Constants.Login);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_SignIn_Button);
        }
        public static IWebElement Select_DropDown()
        {
            ScanPage(Utility.Constants.Login);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_DropDown);
        }
        public static IWebElement LogOut_Button()
        {
            ScanPage(Utility.Constants.Login);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.LogOut_Button);
        }
        public static IWebElement Click_Next_Button()
        {
            ScanPage(Utility.Constants.Login);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Next_Button);
        }
        
    }
}
