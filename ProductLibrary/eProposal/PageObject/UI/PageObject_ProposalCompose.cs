using System.Reflection;
using eProposal.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eProposal.PageObject.UI
{
    public class PageObject_ProposalCompose : Setup
    {
        private static readonly string PageName = Constants.ProposalCompose;

        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/


        public static IWebElement View_Email()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_View_Email);
        }

        public static IWebElement Tab_Navigation_eCard()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCompose_Navigation_eCard);
        }

        public static IWebElement LanguageDropDown()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_LanguageDropDown);
        }

        public static IWebElement CheckBox_IncludeOfferAtBottomOfWelcomeLetter()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository
                .ProposalCompose_CheckBox_IncludeOfferAtBottomOfWelcomeLetter);
        }

        public static IWebElement SelectProposalDropDown()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_SelectProposalDropDown);
        }

        public static IWebElement ProposalNameText()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_ProposalNameText);
        }

        public static IWebElement EmployeeFromDropDown()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_EmployeeFromDropDown);
        }

        public static IWebElement Client_SearchLink()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_Client_SearchLink);
        }

        public static IWebElement Client_AddNewLink()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_Client_AddNewLink);
        }

        public static IWebElement Client_AddNew_FirstNameText()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_Client_AddNew_FirstNameText);
        }

        public static IWebElement Client_AddNew_LastNameText()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_Client_AddNew_LastNameText);
        }

        public static IWebElement Client_AddNew_CompanyText()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_Client_AddNew_CompanyText);
        }

        public static IWebElement Client_AddNew_EmailText()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_Client_AddNew_EmailText);
        }

        public static IWebElement Client_AddNew_PhoneNumberText()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCompose_Client_AddNew_PhoneNumberText);
        }

        public static IWebElement Client_AddNew_HideShowAddressLink()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCompose_Client_AddNew_HideShowAddressLink);
        }

        public static IWebElement Client_AddNew_AddressText()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_Client_AddNew_AddressText);
        }

        public static IWebElement Client_AddNew_CityText()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_Client_AddNew_CityText);
        }

        public static IWebElement Client_AddNew_StateText()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_Client_AddNew_StateText);
        }

        public static IWebElement Client_AddNew_ZipText()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_Client_AddNew_ZipText);
        }

        public static IWebElement Client_AddNew_CountryDropDown()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_Client_AddNew_CountryDropDown);
        }

        public static IWebElement Client_AddNew_SaveButton()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_Client_AddNew_SaveButton);
        }

        public static IWebElement Client_AddNew_CancelButton()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_Client_AddNew_CancelButton);
        }

        public static IWebElement CCText()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_CCText);
        }

        public static IWebElement BCCText()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_BCCText);
        }

        public static IWebElement EventDate()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_EventDate);
        }

        public static IWebElement ExpirationDate()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_ExpirationDate);
        }

        public static IWebElement WelcomeMessageText()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCompose_WelcomeMessageText);
        }

        public static IWebElement WelcomeMessage_StoredContent1Link()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_WelcomeMessage_StoredContent1Link);
        }

        public static IWebElement WelcomeMessage_StoredContent2Link()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_WelcomeMessage_StoredContent2Link);
        }

        public static IWebElement WelcomeMessage_StoredContent3Link()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_WelcomeMessage_StoredContent3Link);
        }

        public static IWebElement WelcomeMessage_StoredContent4Link()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_WelcomeMessage_StoredContent4Link);
        }

        public static IWebElement MessageClosingText()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_MessageClosingText);
        }

        public static IWebElement SeniorStaffMessageText()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCompose_SeniorStaffMessageText);
        }

        public static IWebElement UploadLogoLink()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCompose_UploadLogoLink);
        }

        public static IWebElement Client_UneditableTextBox()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_Client_UneditableTextBox);
        }

        public static IWebElement Client_SearchText()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_Client_SearchText);
        }

        public static IWebElement Client_EditLink()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_Client_EditLink);
        }

        public static IWebElement Calendar_MonthDropDown()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCompose_Calendar_MonthDropDown);
        }

        public static IWebElement Calendar_YearDropDown()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCompose_Calendar_YearDropDown);
        }

        public static IWebElement Calendar_NextMonthButton()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCompose_Calendar_NextMonthButton);
        }

        public static IWebElement Calendar_PreviousMonthButton()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCompose_Calendar_PreviousMonthButton);
        }

        public static IWebElement RadioButton_Module1()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCompose_RadioButton_Module1);
        }

        public static IWebElement RadioButton_Module2()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCompose_RadioButton_Module2);
        }

        public static IWebElement Button_ClientSearchResult()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCompose_Button_ClientSearchResult);
        }

        public static IWebElement RadioButton_Module3()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCompose_RadioButton_Module3);
        }

        public static IWebElement RadioButton_Module4()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCompose_RadioButton_Module4);
        }

        public static IWebElement CheckBox_UseMyFavoriteSettings()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_CheckBox_UseMyFavoriteSettings);
        }

        public static IWebElement Button_Next()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_Button_Next);
        }

        public static IWebElement Button_Client_Search_Search()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_Button_Client_Search_Search);
        }

        public static IWebElement Tab_Navigation_CreateEdit()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_Navigation_CreateEditTab);
        }

        public static IWebElement Tab_Navigation_eProposal()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCompose_Navigation_eProposal);
        }

        public static IWebElement Link_AddAContact()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_Link_AddAContact);
        }

        public static IWebElement Link_SearchResult()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCompose_Link_SearchResult);
        }

        public static IWebElement Button_Browse()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProposalCompose_Button_Browse);
        }

        public static IWebElement Button_Upload()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_Button_Upload);
        }

        public static IWebElement Image_ClientLogo()
        {
            ScanPage(Constants.ProposalCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ProposalCompose_Image_ClientLogo);
        }
    }
}