using BaseUtility.PageObject;
using CMS.Utility;
using OpenQA.Selenium;
using System.Reflection;

namespace CMS.PageObject.UI
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

        public static IWebElement Input_Password()
        {
            ScanPage(Constants.SignIn);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignIn_Password);
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
