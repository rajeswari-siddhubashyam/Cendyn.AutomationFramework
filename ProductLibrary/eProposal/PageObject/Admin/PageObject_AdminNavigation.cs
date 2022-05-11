using System.Reflection;
using eProposal.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eProposal.PageObject.Admin
{
    public class PageObject_AdminNavigation : Setup
    {
        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/


        public static string PageName = Constants.AdminNavigation;

        public static IWebElement Button_Home()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_Button_Home);
        }

        public static IWebElement Button_Properties()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_Button_Properties);
        }

        public static IWebElement Button_eProposal()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_Button_eProposal);
        }

        public static IWebElement Button_eCard()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_Button_eCard);
        }

        public static IWebElement Button_Users()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_Button_Users);
        }

        public static IWebElement Button_Clients()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_Button_Clients);
        }

        public static IWebElement Button_Brand()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_Button_Brand);
        }

        public static IWebElement Button_Global()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_Button_Global);
        }

        public static IWebElement Dropdown_Property()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_Dropdown_Property);
        }

        public static IWebElement Text_PropertyDD()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_Text_PropertyDD);
        }

        public static IWebElement Link_Search()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_Link_Search);
        }

        public static IWebElement Link_ClearSearch()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_Link_ClearSearch);
        }

        public static IWebElement Tab_Search_Regular()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_Tab_Search_Regular);
        }

        public static IWebElement Tab_Search_SSO()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_Tab_Search_SSO);
        }

        public static IWebElement Tab_Search_CVB()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_Tab_Search_CVB);
        }

        public static IWebElement Tab_Search_Master()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_Tab_Search_Master);
        }

        public static IWebElement Tab_Search_Cluster()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_Tab_Search_Cluster);
        }

        public static IWebElement Tab_Search_GSO()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_Tab_Search_GSO);
        }

        public static IWebElement Tab_Search_Convert()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_Tab_Search_Convert);
        }

        public static IWebElement Tab_Search_Upgrade()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_Tab_Search_Upgrade);
        }

        public static IWebElement Text_Search_ID()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_Text_Search_ID);
        }

        public static IWebElement RadioButton_Search_ExternalLinkID()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_RadioButton_Search_ExternalLinkID);
        }

        public static IWebElement DropDown_Search_Brand()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_DropDown_Search_Brand);
        }

        public static IWebElement Text_Search_BrandDD()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_Text_Search_BrandDD);
        }

        public static IWebElement Text_Name()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_Text_Name);
        }

        public static IWebElement Button_Search_Search()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_Button_Search_Search);
        }

        public static IWebElement Button_Search_ClearSearch()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_Button_Search_ClearSearch);
        }

        public static IWebElement Button_Search_Close()
        {
            ScanPage(Constants.AdminNavigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminNavigation_Button_Search_Close);
        }
    }
}