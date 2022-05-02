using System.Reflection;
using eNgage.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eNgage.PageObject.UI
{
    public class PageObject_Profile : Setup
    {



        private static string PageName = Constants.Profile;

        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/

        public static IWebElement Nav_Profile()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementLinkText(ObjectRepository.Profile_page);
        }
        public static IWebElement Profile_Frame()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Profile_Frame);
        }
        /*public static IWebElement Profile_RevenueDetails()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return(ObjectRepository.Profile_Frame);
            revenueDetailsPopupBtn
        }*/




    }
}