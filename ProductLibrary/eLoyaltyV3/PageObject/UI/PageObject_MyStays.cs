using System.Reflection;
using BaseUtility.PageObject;
using eLoyaltyV3.Utility;
using OpenQA.Selenium;

namespace eLoyaltyV3.PageObject.UI
{
    public class PageObject_MyStays : eLoyaltyV3.Utility.Setup
    {


        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/
        public static string PageName = Constants.MyStays;

        public static IWebElement DropDown_UpcomingStays()
        {
            ScanPage(Constants.MyStays);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyStays_DropDown_UpcomingStays);
        }

        public static IWebElement DropDown_PastStays()
        {
            ScanPage(Constants.MyStays);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyStays_DropDown_PastStays);
        }

        public static IWebElement Text_UpcomingStays_Filter()
        {
            ScanPage(Constants.MyStays);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyStays_Text_UpcomingStays_Filter);
        }

        public static IWebElement Text_PastStays_Filter()
        {
            ScanPage(Constants.MyStays);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyStays_Text_PastStays_Filter);
        }





        
    }
}