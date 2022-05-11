using System.Reflection;
using eProposal.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eProposal.PageObject.Admin
{
    public class PageObject_AdminEProposal : Setup
    {
        public static string PageName = Constants.AdminEProposal;

        public static IWebElement Link_SetupModuleSettings()
        {
            ScanPage(Constants.AdminEProposal);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminEProposal_Link_SetupModuleSettings);
        }

        public static IWebElement Link_SetupTemplates()
        {
            ScanPage(Constants.AdminEProposal);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminEProposal_Link_SetupTemplates);
        }

        public static IWebElement Link_NavigationAndContent()
        {
            ScanPage(Constants.AdminEProposal);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminEProposal_Link_NavigationAndContent);
        }

        public static IWebElement Link_Paragraphs()
        {
            ScanPage(Constants.AdminEProposal);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminEProposal_Link_Paragraphs);
        }

        public static IWebElement Link_RoomEventBlockParagraph()
        {
            ScanPage(Constants.AdminEProposal);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminEProposal_Link_RoomEventBlockParagraph);
        }

        public static IWebElement Link_PropertyGMLetter()
        {
            ScanPage(Constants.AdminEProposal);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminEProposal_Link_PropertyGMLetter);
        }

        public static IWebElement Link_ImageCaptionStyles()
        {
            ScanPage(Constants.AdminEProposal);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminEProposal_Link_ImageCaptionStyles);
        }

        public static IWebElement Link_MediaSetup()
        {
            ScanPage(Constants.AdminEProposal);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminEProposal_Link_MediaSetup);
        }

        public static IWebElement Link_HeaderGallery()
        {
            ScanPage(Constants.AdminEProposal);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminEProposal_Link_HeaderGallery);
        }
    }
}