using System.Reflection;
using eProposal.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eProposal.PageObject.UI
{
    internal class PageObject_Reports : Setup
    {
        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/
        public static string PageName = Constants.Reports;

        public static IWebElement Reports_Link_ToDate()
        {
            ScanPage(Constants.Reports);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Reports_Link_ToDate);
        }

        public static IWebElement Reports_Link_ByYear()
        {
            ScanPage(Constants.Reports);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Reports_Link_ByYear);
        }

        public static IWebElement Reports_Link_ByUser()
        {
            ScanPage(Constants.Reports);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Reports_Link_ByUser);
        }

        public static IWebElement Reports_Link_ByDateRange()
        {
            ScanPage(Constants.Reports);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Reports_Link_ByDateRange);
        }

        public static IWebElement Reports_Link_PerClient()
        {
            ScanPage(Constants.Reports);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Reports_Link_PerClient);
        }

        public static IWebElement Reports_Dropdown_SelectModule()
        {
            ScanPage(Constants.Reports);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Reports_Dropdown_SelectModule);
        }

        public static IWebElement Reports_Dropdown_ProposalStatus()
        {
            ScanPage(Constants.Reports);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Reports_Dropdown_ProposalStatus);
        }

        public static IWebElement Reports_Dropdown_UserStatus()
        {
            ScanPage(Constants.Reports);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Reports_Dropdown_UserStatus);
        }

        public static IWebElement Reports_Button_Submit()
        {
            ScanPage(Constants.Reports);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Reports_Button_Submit);
        }

        public static IWebElement Reports_Dropdown_Year()
        {
            ScanPage(Constants.Reports);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Reports_Dropdown_Year);
        }

        public static IWebElement Reports_DatePicker_StartDate()
        {
            ScanPage(Constants.Reports);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Reports_DatePicker_StartDate);
        }

        public static IWebElement Reports_DatePicker_EndDate()
        {
            ScanPage(Constants.Reports);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Reports_DatePicker_EndDate);
        }

        public static IWebElement Reports_Dropdown_DatepickerMonth()
        {
            ScanPage(Constants.Reports);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Reports_Dropdown_DatepickerMonth);
        }

        public static IWebElement Reports_Dropdown_DatepickerYear()
        {
            ScanPage(Constants.Reports);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Reports_Dropdown_DatepickerYear);
        }

        public static IWebElement Reports_Link_Date(string text)
        {
            ScanPage(Constants.Reports);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementLinkText(text);
        }

        public static IWebElement Reports_Dropdown_Username()
        {
            ScanPage(Constants.Reports);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Reports_Dropdown_Username);
        }

        public static IWebElement Reports_RadioButton_Company()
        {
            ScanPage(Constants.Reports);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Reports_RadioButton_Company);
        }

        public static IWebElement Reports_RadioButton_Lastname()
        {
            ScanPage(Constants.Reports);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Reports_RadioButton_Lastname);
        }
    }
}