using System.Reflection;
using eProposal.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eProposal.PageObject.Admin
{
    internal class PageObject_AdmineCard : Setup
    {
        /*
        / These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
        */

        public static string PageName = Constants.AdmineCard;

        public static IWebElement AdmineCard_Iframe_Upload()
        {
            ScanPage(Constants.AdmineCard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdmineCard_Iframe_Upload);
        }

        public static IWebElement AdmineCard_Button_PopUpUpload()
        {
            ScanPage(Constants.AdmineCard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdmineCard_Button_PopUpUpload);
        }

        public static IWebElement AdmineCard_Button_UploadImage()
        {
            ScanPage(Constants.AdmineCard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdmineCard_Button_UploadImage);
        }

        public static IWebElement AdmineCard_Button_UploadLogo()
        {
            ScanPage(Constants.AdmineCard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdmineCard_Button_UploadLogo);
        }

        public static IWebElement AdmineCard_Button_Addnew()
        {
            ScanPage(Constants.AdmineCard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdmineCard_Button_Addnew);
        }

        public static IWebElement AdmineCard_Link_FooterLinks()
        {
            ScanPage(Constants.AdmineCard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdmineCard_Link_FooterLinks);
        }

        public static IWebElement AdmineCard_Link_AddMediaLink()
        {
            ScanPage(Constants.AdmineCard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdmineCard_Link_AddMediaLink);
        }

        public static IWebElement AdmineCard_Input_LinkName()
        {
            ScanPage(Constants.AdmineCard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdmineCard_Input_LinkName);
        }

        public static IWebElement AdmineCard_Button_Save()
        {
            ScanPage(Constants.AdmineCard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdmineCard_Button_Save);
        }

        public static IWebElement AdmineCard_Button_UploadMediaFiles()
        {
            ScanPage(Constants.AdmineCard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdmineCard_Button_UploadMediaFiles);
        }

        public static IWebElement AdmineCard_Button_Browse()
        {
            ScanPage(Constants.AdmineCard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdmineCard_Button_Browse);
        }

        public static IWebElement AdmineCard_Button_UploadButton()
        {
            ScanPage(Constants.AdmineCard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdmineCard_Button_UploadButton);
        }

        public static IWebElement AdmineCard_Text_SkinName()
        {
            ScanPage(Constants.AdmineCard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdmineCard_Text_SkinName);
        }

        public static IWebElement AdmineCard_Button_ChooseFile()
        {
            ScanPage(Constants.AdmineCard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdmineCard_Button_ChooseFile);
        }

        public static IWebElement AdmineCard_Image_Preview()
        {
            ScanPage(Constants.AdmineCard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdmineCard_Image_Preview);
        }

        public static IWebElement AdmineCard_Button_CancelButton()
        {
            ScanPage(Constants.AdmineCard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdmineCard_Button_CancelButton);
        }

        public static IWebElement AdmineCard_Link_GeneratedLinks()
        {
            ScanPage(Constants.AdmineCard);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdmineCard_Link_GeneratedLinks);
        }
    }
}