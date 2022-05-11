using System.Reflection;
using eProposal.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eProposal.PageObject.Admin
{
    internal class PageObject_AdminProperties : Setup
    {
        /*
       / These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
       */

        public static string PageName = Constants.AdminProperties;

        public static IWebElement AdminProperties_PropertyDropDown_Button()
        {
            ScanPage(Constants.AdminProperties);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminProperties_PropertyDropDown_Button);
        }

        public static IWebElement Tab_RoomBlock()
        {
            ScanPage(Constants.AdminProperties);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminProperties_Tab_RoomBlock);
        }

        public static IWebElement AdminProperties_PropertyDropDown_Text()
        {
            ScanPage(Constants.AdminProperties);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminProperties_PropertyDropDown_Text);
        }

        public static IWebElement AdminProperties_Button_Features()
        {
            ScanPage(Constants.AdminProperties);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminProperties_Button_Features);
        }


        public static IWebElement Tab_Actions()
        {
            ScanPage(Constants.AdminProperties);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminProperties_Tab_Actions);
        }
    }
}