using BaseUtility.PageObject;
using eMenus.Utility;
using OpenQA.Selenium;
using System.Reflection;

namespace eMenus.PageObject.UI
{
    class PageObject_Navigation : Setup
    {
        public static string PageName = Utility.Constants.Navigation;
        public static IWebElement Create_NewOrder()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Create_NewOrder);
        }

        public static IWebElement Link_SignIn()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SignIn_Link);
        }

        public static IWebElement Click_Button_MyAccount()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Button_MyAccount);
        }
        public static IWebElement Click_MyAccount_SignOut()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MyAccount_SignOut);
        }
    }
}
