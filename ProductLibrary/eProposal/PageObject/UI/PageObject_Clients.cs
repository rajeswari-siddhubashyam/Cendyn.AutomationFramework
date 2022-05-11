using System.Reflection;
using eProposal.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eProposal.PageObject.UI
{
    public class PageObject_Clients : Setup
    {
        public static string PageName = Constants.Clients;

        public static IWebElement AddNewClient_FirstNameText()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_AddNewClient_FirstNameText);
        }

        public static IWebElement AddNewClient_LastNameText()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_AddNewClient_LastNameText);
        }

        public static IWebElement AddNewClient_CompanyText()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_AddNewClient_CompanyText);
        }

        public static IWebElement AddNewClient_EmailText()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_AddNewClient_EmailText);
        }

        public static IWebElement AddNewClient_PhoneText()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_AddNewClient_PhoneText);
        }

        public static IWebElement AddNewClient_AddressText()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_AddNewClient_AddressText);
        }

        public static IWebElement AddNewClient_CityText()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_AddNewClient_CityText);
        }

        public static IWebElement AddNewClient_StateText()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_AddNewClient_StateText);
        }

        public static IWebElement AddNewClient_ZipText()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_AddNewClient_ZipText);
        }

        public static IWebElement AddNewClient_CountryDropDown()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_AddNewClient_CountryDropDown);
        }

        public static IWebElement AddNewClient_ShowHideAddressLink()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_AddNewClient_ShowHideAddressLink);
        }

        public static IWebElement AddNewClient_AddClientButton()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_AddNewClient_AddClientButton);
        }

        public static IWebElement AddNewClientTab()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_AddNewClientTab);
        }

        public static IWebElement SearchEditTab()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_SearchEditTab);
        }

        public static IWebElement SearchEdit_LastNameRadioButton()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_SearchEdit_LastNameRadioButton);
        }

        public static IWebElement SearchEdit_EmailRadioButton()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_SearchEdit_EmailRadioButton);
        }

        public static IWebElement SearchEdit_CompanyRadioButton()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_SearchEdit_CompanyRadioButton);
        }

        public static IWebElement SearchEdit_SearchText()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_SearchEdit_SearchText);
        }

        public static IWebElement SearchEdit_SearchButton()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_SearchEdit_SearchButton);
        }

        public static IWebElement SearchEdit_EditFirstLink()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_SearchEdit_EditFirstLink);
        }

        public static IWebElement SearchEdit_ExpandFirstButton()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_SearchEdit_ExpandFirstButton);
        }

        public static IWebElement SearchEdit_FirstResultLink()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_SearchEdit_FirstResultLink);
        }

        public static IWebElement SearchEdit_Edit_FirstNameText()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_SearchEdit_Edit_FirstNameText);
        }

        public static IWebElement SearchEdit_Edit_LastNameText()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_SearchEdit_Edit_LastNameText);
        }

        public static IWebElement SearchEdit_Edit_CompanyText()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_SearchEdit_Edit_CompanyText);
        }

        public static IWebElement SearchEdit_Edit_EmailText()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_SearchEdit_Edit_EmailText);
        }

        public static IWebElement SearchEdit_Edit_PhoneText()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_SearchEdit_Edit_PhoneText);
        }

        public static IWebElement SearchEdit_Edit_AddressText()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_SearchEdit_Edit_AddressText);
        }

        public static IWebElement SearchEdit_Edit_CityText()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_SearchEdit_Edit_CityText);
        }

        public static IWebElement SearchEdit_Edit_StateText()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_SearchEdit_Edit_StateText);
        }

        public static IWebElement SearchEdit_Edit_ZipText()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_SearchEdit_Edit_ZipText);
        }

        public static IWebElement SearchEdit_Edit_CountryDropDown()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_SearchEdit_Edit_CountryDropDown);
        }

        public static IWebElement SearchEdit_Edit_ShowHideAddressLink()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_SearchEdit_Edit_ShowHideAddressLink);
        }

        public static IWebElement SearchEdit_Edit_SaveButton()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_SearchEdit_Edit_SaveButton);
        }

        public static IWebElement SearchEdit_Edit_CancelButton()
        {
            ScanPage(Constants.Clients);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clients_SearchEdit_Edit_CancelButton);
        }
    }
}