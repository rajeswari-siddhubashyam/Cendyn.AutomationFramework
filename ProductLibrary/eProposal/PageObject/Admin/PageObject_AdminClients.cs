using System.Reflection;
using eProposal.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eProposal.PageObject.Admin
{
    public class PageObject_AdminClients : Setup
    {
        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/

        public static string PageName = Constants.AdminClients;

        public static IWebElement Link_ShowAll()
        {
            ScanPage(Constants.AdminClients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Link_ShowAll);
        }

        public static IWebElement Link_AddNew()
        {
            ScanPage(Constants.AdminClients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Link_AddNew);
        }

        public static IWebElement Link_Search()
        {
            ScanPage(Constants.AdminClients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Link_Search);
        }

        public static IWebElement Button_Top_FirstPage()
        {
            ScanPage(Constants.AdminClients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Button_Top_FirstPage);
        }

        public static IWebElement Button_Top_PreviousPage()
        {
            ScanPage(Constants.AdminClients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Button_Top_PreviousPage);
        }

        public static IWebElement Button_Top_NextPage()
        {
            ScanPage(Constants.AdminClients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Button_Top_NextPage);
        }

        public static IWebElement Button_Top_LastPage()
        {
            ScanPage(Constants.AdminClients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Button_Top_LastPage);
        }

        public static IWebElement DropDown_Top_GoToPage()
        {
            ScanPage(Constants.AdminClients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_DropDown_Top_GoToPage);
        }

        public static IWebElement Button_Bottom_FirstPage()
        {
            ScanPage(Constants.AdminClients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Button_Bottom_FirstPage);
        }

        public static IWebElement Button_Bottom_PreviousPage()
        {
            ScanPage(Constants.AdminClients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Button_Bottom_PreviousPage);
        }

        public static IWebElement Button_Bottom_NextPage()
        {
            ScanPage(Constants.AdminClients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Button_Bottom_NextPage);
        }

        public static IWebElement Button_Bottom_LastPage()
        {
            ScanPage(Constants.AdminClients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Button_Bottom_LastPage);
        }

        public static IWebElement DropDown_Bottom_GoToPage()
        {
            ScanPage(Constants.AdminClients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_DropDown_Bottom_GoToPage);
        }
    }
}