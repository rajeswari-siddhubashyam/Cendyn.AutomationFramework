using System.Reflection;
using eInsight.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eInsight.PageObject.UI
{
    public class PageObject_Settings : Setup
    {


        private static string PageName = Constants.Settings;

        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/

        public static IWebElement Settings_AccessControl_MergeGuestCheckbox()
        {
            ScanPage(Constants.Settings);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Settings_AccessControl_MergeGuestCheckbox);
        }
        public static IWebElement Settings_AccessControl()
        {
            ScanPage(Constants.Settings);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Settings_AccessControl);
        }

        public static IWebElement Settings_AccessControl_MergeGuest()
        {
            ScanPage(Constants.Settings);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Settings_AccessControl_MergeGuest);
        }

        public static IWebElement Settings_AccessControl_Save()
        {
            ScanPage(Constants.Settings);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Settings_AccessControl_Save);
        }
    }
}