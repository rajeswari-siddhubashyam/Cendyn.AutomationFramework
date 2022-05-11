using System.Reflection;
using eProposal.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eProposal.PageObject.UI
{
    public class PageObject_ProposalPreview : Setup
    {
        public static string PageName = Constants.ProposalPreview;

        public static IWebElement Button_Send()
        {
            ScanPage(Constants.ProposalPreview);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalPreview_Button_Send);
        }

        public static IWebElement CheckBox_SaveAsMyFavorite()
        {
            ScanPage(Constants.ProposalPreview);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalPreview_CheckBox_SaveAsMyFavorite);
        }

        public static IWebElement Button_Preview()
        {
            ScanPage(Constants.ProposalPreview);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalPreview_Button_Preview);
        }

        public static IWebElement Link_SelfSend()
        {
            ScanPage(Constants.ProposalPreview);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalPreview_Link_SelfSend);
        }

        public static IWebElement DropDown_AnotherLanguage()
        {
            ScanPage(Constants.ProposalPreview);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalPreview_DropDown_AnotherLanguage);
        }

        public static IWebElement View_CustomSignature()
        {
            ScanPage(Constants.ProposalPreview);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalPreview_View_CustomSignature);
        }

        public static IWebElement Link_PDF()
        {
            ScanPage(Constants.ProposalPreview);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalPreview_Link_PDF);
        }

        public static IWebElement PopUpButton_Preview()
        {
            ScanPage(Constants.ProposalPreview);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalPreview_PopUpButton_Preview);
        }

        public static IWebElement Iframe_SelectPage()
        {
            ScanPage(Constants.ProposalPreview);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementClassName(ObjectRepository.ProposalPreview_Iframe_SelectPage);
        }

        public static IWebElement Image_PreviewClientLogo()
        {
            ScanPage(Constants.ProposalPreview);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementClassName(ObjectRepository.ProposalPreview_Image_ClientLogo);
        }
    }
}