using System.Reflection;
using eProposal.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace eProposal.PageObject.UI
{
    public class PageObject_Settings : Setup
    {
        public static string PageName = Constants.Settings;

        public static IWebElement Tab_PropertyInfo()
        {
            ScanPage(Constants.Settings);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Settings_Tab_PropertyInfo);
        }

        public static IWebElement Tab_General()
        {
            ScanPage(Constants.Settings);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Settings_Tab_General);
        }

        public static IWebElement Tab_SeniorStaffInfo()
        {
            ScanPage(Constants.Settings);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Settings_Tab_SeniorStaffInfo);
        }

        public static IWebElement Tab_StoredContent()
        {
            ScanPage(Constants.Settings);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Settings_Tab_StoredContent);
        }

        public static IWebElement Tab_RoomEventBlockComments()
        {
            ScanPage(Constants.Settings);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Settings_Tab_RoomEventBlockComments);
        }

        public static IWebElement Tab_SpecialOffers()
        {
            ScanPage(Constants.Settings);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Settings_Tab_SpecialOffers);
        }

        public static IWebElement Tab_CustomizePDF()
        {
            ScanPage(Constants.Settings);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Settings_Tab_CustomizePDF);
        }

        public static IWebElement Tab_SocialMedia()
        {
            ScanPage(Constants.Settings);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Settings_Tab_SocialMedia);
        }

        public static SelectElement Dropdown_Module()
        {
            ScanPage(Constants.Settings_StoredContent);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            //return new SelectElement(
            //    Driver.FindElement(By.Id(ObjectRepository.Settings_SeniorStaffInfo_Dropdown_Module)));
            return new SelectElement(
                Driver.FindElement(By.XPath(ObjectRepository.Settings_StoredContent_DropDown_SelectModule)));
        }

        public static SelectElement Customize_Dropdown_Module()
        {
            ScanPage(Constants.Settings);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return new SelectElement(Driver.FindElement(By.Id(ObjectRepository.Settings_CustomizePDF_Dropdown_Module)));
        }

        public static SelectElement SpecialOffer_Dropdown_Module()
        {
            ScanPage(Constants.Settings);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return new SelectElement(Driver.FindElement(By.Id(ObjectRepository.Settings_SpecialOffer_Dropdown_Module)));
        }
    }
}