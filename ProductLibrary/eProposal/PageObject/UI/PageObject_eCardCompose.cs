using System.Reflection;
using eProposal.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eProposal.PageObject.UI
{
    public class PageObject_eCardCompose : Setup
    {
        public static string PageName = Constants.eCardCompose;

        public static IWebElement Button_EmployeeNameCendynQA()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_Button_EmployeeNameCendynQA);
        }

        public static IWebElement Button_Send()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.eCardCompose_Button_Send);
        }

        public static IWebElement Button_YesProceed()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.eCardCompose_Button_YesProceed);
        }

        public static IWebElement Dropdown_Language()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_Dropdown_Language);
        }

        public static IWebElement RadioButton_eCardType_Ackowledgement()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_RadioButton_eCardType_Ackowledgement);
        }

        public static IWebElement RadioButton_eCardType_TurnDown()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_RadioButton_eCardType_TurnDown);
        }

        public static IWebElement DropDown_SelectCard()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_DropDown_SelectCard);
        }

        public static IWebElement DropDown_From()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_DropDown_From);
        }


        public static IWebElement Click_Client_SearchLink()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_Click_Client_SearchLink);
        }

        public static IWebElement Click_Client_AddNewLink()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_Click_Client_AddNewLink);
        }

        public static IWebElement Click_Client_Search_Search()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_Text_Client_Search_Search);
        }

        public static IWebElement Click_Client_Search_SearchButton()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_Text_Client_Search_SearchButton);
        }

        public static IWebElement Click_Client_Search_FirstResultLink()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_Click_Client_Search_FirstResultLink);
        }

        public static IWebElement Click_Client_Seartch_Close()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_Click_Client_Seartch_Close);
        }

        public static IWebElement TextBox_Client_AddNew_FirstName()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_TextBox_Client_AddNew_FirstName);
        }

        public static IWebElement TextBox_Client_AddNew_LastName()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_TextBox_Client_AddNew_LastName);
        }

        public static IWebElement TextBox_Client_AddNew_Company()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_TextBox_Client_AddNew_Company);
        }

        public static IWebElement TextBox_Client_AddNew_EmailAddress()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_TextBox_Client_AddNew_EmailAddress);
        }

        public static IWebElement TextBox_Client_AddNew_PhoneNumber()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_TextBox_Client_AddNew_PhoneNumber);
        }

        public static IWebElement TextBox_Client_AddNew_Address()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_TextBox_Client_AddNew_Address);
        }

        public static IWebElement TextBox_Client_AddNew_City()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_TextBox_Client_AddNew_City);
        }

        public static IWebElement TextBox_Client_AddNew_State()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_TextBox_Client_AddNew_State);
        }

        public static IWebElement TextBox_Client_AddNew_Zip()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_TextBox_Client_AddNew_Zip);
        }

        public static IWebElement DropDown_Client_AddNew_Country()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_DropDown_Client_AddNew_Country);
        }

        public static IWebElement Link_Client_AddNew_HideShowAddress()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_Link_Client_AddNew_HideShowAddress);
        }

        public static IWebElement Button_Client_AddNew_Save()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_Button_Client_AddNew_Save);
        }

        public static IWebElement Button_Client_AddNew_Cancel()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_Button_Client_AddNew_Cancel);
        }

        public static IWebElement TextBox_CC()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_TextBox_CC);
        }

        public static IWebElement TextBox_BCC()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_TextBox_BCC);
        }

        public static IWebElement TextBox_EmailSubject()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_TextBox_EmailSubject);
        }

        public static IWebElement TextBox_Message()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_TextBox_Message);
        }

        public static IWebElement Link_StoredContent1()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_Link_StoredContent1);
        }

        public static IWebElement Link_StoredContent2()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_Link_StoredContent2);
        }

        public static IWebElement Link_StoredContent3()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_Link_StoredContent3);
        }

        public static IWebElement Link_StoredContent4()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_Link_StoredContent4);
        }

        public static IWebElement TextBox_MessageClosing()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_TextBox_MessageClosing);
        }

        public static IWebElement Button_Next()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_Button_Next);
        }

        public static IWebElement Image_CustomSignatureImage()
        {
            ScanPage(Constants.eCardCompose);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.eCardCompose_Image_CustomSignatureImage);
        }
    }
}