using BaseUtility.PageObject;
using eLoyaltyV3.Utility;
using OpenQA.Selenium;
using System.Reflection;

namespace eLoyaltyV3.PageObject.UI
{
    class PageObject_Exclusives : Setup
    {

        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/
        public static string PageName = Constants.Exclusives;
        
        public static IWebElement Text_ReadMore()
        {
            ScanPage(Constants.Exclusives);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Exclusives_Text_ReadMore);
        }

        public static IWebElement Button_BookNow()
        {
            ScanPage(Constants.Exclusives);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Exclusives_Button_BookNow);
        }

        public static IWebElement Link_ShareNow()
        {
            ScanPage(Constants.Exclusives);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Exclusives_Link_ShareNow);
        }

    }
}
