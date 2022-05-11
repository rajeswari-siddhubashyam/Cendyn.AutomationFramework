using System.Reflection;
using eProposal.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eProposal.PageObject.UI
{
    public class PageObject_Settings_StoredContent : Setup
    {
        public static string PageName = Constants.Settings_StoredContent;

        public static IWebElement DropDown_SelectModule()
        {
            ScanPage(Constants.Settings_StoredContent);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Settings_StoredContent_DropDown_SelectModule);
        }

        public static IWebElement DropDown_SelectLanguage()
        {
            ScanPage(Constants.Settings_StoredContent);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Settings_StoredContent_DropDown_SelectLanguage);
        }

        public static IWebElement Link_eProposal()
        {
            ScanPage(Constants.Settings_StoredContent);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Settings_StoredContent_Link_eProposal);
        }

        public static IWebElement Link_eCard()
        {
            ScanPage(Constants.Settings_StoredContent);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Settings_StoredContent_Link_eCard);
        }

        public static IWebElement Button_AddNew()
        {
            ScanPage(Constants.Settings_StoredContent);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Settings_StoredContent_Button_AddNew);
        }

        public static IWebElement Link_FirstStoredContent_Edit()
        {
            ScanPage(Constants.Settings_StoredContent);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Settings_StoredContent_Link_FirstStoredContent_Edit);
        }

        public static IWebElement Link_FirstStoredContent_Delete()
        {
            ScanPage(Constants.Settings_StoredContent);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Settings_StoredContent_Link_FirstStoredContent_Delete);
        }
    }
}