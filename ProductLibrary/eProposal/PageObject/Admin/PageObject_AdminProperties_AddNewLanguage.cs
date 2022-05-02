using System.Reflection;
using eProposal.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eProposal.PageObject.Admin
{
    public class PageObject_AdminProperties_AddNewLanguage : Setup
    {
        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/

        public static string PageName = Constants.AdminProperties_AddNewLanguage;

        public static IWebElement DropDown_Language()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminProperties_AddNewLanguage_DropDown_Language);
        }

        public static IWebElement Text_PropertyName()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminProperties_AddNewLanguage_Text_PropertyName);
        }

        public static IWebElement Text_AlternativePropertyName()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .AdminProperties_AddNewLanguage_Text_AlternativePropertyName);
        }

        public static IWebElement Text_Address()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminProperties_AddNewLanguage_Text_Address);
        }

        public static IWebElement Text_City()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminProperties_AddNewLanguage_Text_City);
        }

        public static IWebElement Text_State()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminProperties_AddNewLanguage_Text_State);
        }

        public static IWebElement Text_ZipCode()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminProperties_AddNewLanguage_Text_ZipCode);
        }

        public static IWebElement DropDown_Country()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminProperties_AddNewLanguage_DropDown_Country);
        }

        public static IWebElement Text_CountryDisplayName()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .AdminProperties_AddNewLanguage_Text_CountryDisplayName);
        }

        public static IWebElement Text_MainPhone()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminProperties_AddNewLanguage_Text_MainPhone);
        }

        public static IWebElement Text_GroupSalesPhone()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminProperties_AddNewLanguage_Text_GroupSalesPhone);
        }

        public static IWebElement Text_Fax()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminProperties_AddNewLanguage_Text_Fax);
        }

        public static IWebElement Text_Email()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminProperties_AddNewLanguage_Text_Email);
        }

        public static IWebElement Text_WelcomeTag()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminProperties_AddNewLanguage_Text_WelcomeTag);
        }

        public static IWebElement Text_Website()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminProperties_AddNewLanguage_Text_Website);
        }

        public static IWebElement DropDown_Currency()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminProperties_AddNewLanguage_DropDown_Currency);
        }

        public static IWebElement Link_RoomBlockAddNew()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminProperties_AddNewLanguage_Link_RoomBlockAddNew);
        }

        public static IWebElement Text_RoomBlockColumnLabel1()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .AdminProperties_AddNewLanguage_Text_RoomBlockColumnLabel1);
        }

        public static IWebElement Text_RoomBlockColumnLabel2()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .AdminProperties_AddNewLanguage_Text_RoomBlockColumnLabel2);
        }

        public static IWebElement Text_RoomBlockColumnLabel3()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .AdminProperties_AddNewLanguage_Text_RoomBlockColumnLabel3);
        }

        public static IWebElement Text_RoomBlockColumnLabel4()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .AdminProperties_AddNewLanguage_Text_RoomBlockColumnLabel4);
        }

        public static IWebElement Text_RoomBlockColumnLabel5()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .AdminProperties_AddNewLanguage_Text_RoomBlockColumnLabel5);
        }

        public static IWebElement Link_RoomBlockColumnDelete1()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .AdminProperties_AddNewLanguage_Link_RoomBlockColumnDelete1);
        }

        public static IWebElement Link_RoomBlockColumnDelete2()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .AdminProperties_AddNewLanguage_Link_RoomBlockColumnDelete2);
        }

        public static IWebElement Link_RoomBlockColumnDelete3()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .AdminProperties_AddNewLanguage_Link_RoomBlockColumnDelete3);
        }

        public static IWebElement Link_RoomBlockColumnDelete4()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .AdminProperties_AddNewLanguage_Link_RoomBlockColumnDelete4);
        }

        public static IWebElement Link_RoomBlockColumnDelete5()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository
                .AdminProperties_AddNewLanguage_Link_RoomBlockColumnDelete5);
        }

        public static IWebElement Text_EmailBody()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminProperties_AddNewLanguage_Text_EmailBody);
        }

        public static IWebElement Text_EmailBodyBCC()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminProperties_AddNewLanguage_Text_EmailBodyBCC);
        }

        public static IWebElement Button_Save()
        {
            ScanPage(Constants.AdminProperties_AddNewLanguage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminProperties_AddNewLanguage_Button_Save);
        }
    }
}