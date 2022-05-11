using System.Reflection;
using eProposal.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eProposal.PageObject.UI
{
    internal class PageObject_Profile : Setup
    {
        private static readonly string PageName = Constants.Profile;

        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/

        public static IWebElement Profile_Link_EditFirstProfile()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Profile_Link_EditFirstProfile);
        }

        public static IWebElement Profile_Button_ViewAll()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Profile_Button_ViewAll);
        }

        public static IWebElement Profile_Button_No()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Profile_Button_No);
        }

        public static IWebElement Profile_Button_ChooseFile()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Profile_Button_ChooseFile);
        }

        public static IWebElement Profile_Button_Save()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Profile_Button_Save);
        }

        public static IWebElement Profile_Link_Remove()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Profile_Link_Remove);
        }

        public static IWebElement Profile_Button_Ok()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Profile_Button_Ok);
        }

        public static IWebElement Profile_Image_CustomSignature()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Profile_Image_CustomSignature);
        }

        public static IWebElement Profile_Field_CustomSignature()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_Field_CustomSignature);
        }

        public static IWebElement Profile_Button_Cancel()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Profile_Button_Cancel);
        }

        public static IWebElement Profile_Link_ContinueToeProposal()
        {
            ScanPage(Constants.Profile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Profile_Link_ContinueToeProposal);
        }
    }
}