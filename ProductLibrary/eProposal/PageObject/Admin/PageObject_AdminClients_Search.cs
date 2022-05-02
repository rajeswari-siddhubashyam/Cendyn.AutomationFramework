using System.Reflection;
using eProposal.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eProposal.PageObject.Admin
{
    public class PageObject_AdminClients_Search : Setup
    {
        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/


        public static string PageName = Constants.AdminClients_Search;

        public static IWebElement Tab_Global()
        {
            ScanPage(Constants.AdminClients_Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Search_Tab_Global);
        }

        public static IWebElement Tab_Property()
        {
            ScanPage(Constants.AdminClients_Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Search_Tab_Property);
        }

        public static IWebElement DropDown_SearchByName()
        {
            ScanPage(Constants.AdminClients_Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Search_DropDown_SearchByName);
        }

        public static IWebElement DropDown_SearchByWith()
        {
            ScanPage(Constants.AdminClients_Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Search_DropDown_SearchByWith);
        }

        public static IWebElement Text_Search()
        {
            ScanPage(Constants.AdminClients_Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Search_Text_Search);
        }

        public static IWebElement Button_Search()
        {
            ScanPage(Constants.AdminClients_Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AdminClients_Search_Button_Search);
        }

        public static IWebElement Tab_Chain()
        {
            ScanPage(Constants.AdminClients_Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Search_Tab_Chain);
        }

        public static IWebElement Tab_ChainBrand()
        {
            ScanPage(Constants.AdminClients_Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Search_Tab_ChainBrand);
        }

        public static IWebElement Tab_Independent()
        {
            ScanPage(Constants.AdminClients_Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Search_Tab_Independent);
        }

        public static IWebElement Button_Top_FirstPage()
        {
            ScanPage(Constants.AdminClients_Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Search_Button_Top_FirstPage);
        }

        public static IWebElement Button_Top_PreviousPage()
        {
            ScanPage(Constants.AdminClients_Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Search_Button_Top_PreviousPage);
        }

        public static IWebElement Button_Top_NextPage()
        {
            ScanPage(Constants.AdminClients_Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Search_Button_Top_NextPage);
        }

        public static IWebElement Button_Top_LastPage()
        {
            ScanPage(Constants.AdminClients_Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Search_Button_Top_LastPage);
        }

        public static IWebElement DropDown_Top_GoToPage()
        {
            ScanPage(Constants.AdminClients_Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Search_DropDown_Top_GoToPage);
        }

        public static IWebElement Button_Bottom_FirstPage()
        {
            ScanPage(Constants.AdminClients_Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Search_Button_Bottom_FirstPage);
        }

        public static IWebElement Button_Bottom_PreviousPage()
        {
            ScanPage(Constants.AdminClients_Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Search_Button_Bottom_PreviousPage);
        }

        public static IWebElement Button_Bottom_NextPage()
        {
            ScanPage(Constants.AdminClients_Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Search_Button_Bottom_NextPage);
        }

        public static IWebElement Button_Bottom_LastPage()
        {
            ScanPage(Constants.AdminClients_Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Search_Button_Bottom_LastPage);
        }

        public static IWebElement DropDown_Bottom_GoToPage()
        {
            ScanPage(Constants.AdminClients_Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Search_DropDown_Bottom_GoToPage);
        }

        public static IWebElement Button_FirstClient_Edit()
        {
            ScanPage(Constants.AdminClients_Search);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminClients_Search_Button_FirstClient_Edit);
        }
    }
}