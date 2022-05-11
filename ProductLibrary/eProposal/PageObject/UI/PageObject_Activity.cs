using System.Reflection;
using eProposal.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eProposal.PageObject.UI
{
    internal class PageObject_Activity : Setup
    {
        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/
        public static string PageName = Constants.Activity;

        public static IWebElement Activity_Link_SignNow()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Link_SignNow);
        }

        public static IWebElement Activity_Button_SubmitElectronically()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Button_SubmitElectronically);
        }

        public static IWebElement Activity_Text_SignHere()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activity_Text_SignHere);
        }

        public static IWebElement Activity_Text_SignHere2()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Text_SignHere2);
        }

        public static IWebElement Activity_Link_ClickHere()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activity_Link_ClickHere);
        }

        public static IWebElement Activity_Navigation_ActivityTab()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activity_Navigation_ActivityTab);
        }

        public static IWebElement Activity_Link_From()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activity_Link_From);
        }

        public static IWebElement Activity_Link_To()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activity_Link_To);
        }

        public static IWebElement Activity_Link_eProposal()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activity_Link_eProposal);
        }

        public static IWebElement Activity_Link_Views()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activity_Link_Views);
        }

        public static IWebElement Activity_Link_SendingStatus()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activity_Link_SendingStatus);
        }

        public static IWebElement Activity_Link_SendOn()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activity_Link_SendOn);
        }

        public static IWebElement Activity_Link_EventDate()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activity_Link_EventDate);
        }

        public static IWebElement Activity_Link_ExpirationDate()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activity_Link_ExpirationDate);
        }

        public static IWebElement Activity_Link_CreatedOn()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activity_Link_CreatedOn);
        }

        public static IWebElement Activity_Button_eCard()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activity_Button_eCard);
        }

        public static IWebElement Activity_Link_eCard()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activity_Link_eCard);
        }

        public static IWebElement Activity_Link_Preview()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activity_Link_Preview);
        }

        public static IWebElement ActivityPreview_Button_Forward()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ActivityPreview_Button_Forward);
        }

        public static IWebElement Activity_Link_GetLink()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Link_GetLink);
        }

        public static IWebElement Activity_GetLink_URL()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_GetLink_URL);
        }

        public static IWebElement Activity_Link_Resend()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activity_Link_Resend);
        }

        public static IWebElement Activity_ResendLink_Cancel()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_ResendLink_Cancel);
        }

        public static IWebElement Activity_ResendLink_OK()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_ResendLink_OK);
        }

        public static IWebElement Activity_Button_Close()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Button_Close);
        }

        public static IWebElement Activity_Link_Clone()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Link_Clone);
        }

        public static IWebElement Activity_Link_Status()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activity_Link_Status);
        }

        public static IWebElement Activity_StatusLink_Cancel()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_StatusLink_Cancel);
        }

        public static IWebElement Activity_Link_DownloadPDF()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Link_DownloadPDF);
        }

        public static IWebElement Activity_DatePicker_ExpirationDate()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activity_DatePicker_ExpirationDate);
        }

        public static IWebElement Activity_Text_EventDate()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Text_EventDate);
        }

        public static IWebElement Activity_dropdown_ExpirationMonth()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activity_Dropdown_ExpirationMonth);
        }

        public static IWebElement Activity_dropdown_ExpirationYear()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activity_Dropdown_ExpirationYear);
        }

        public static IWebElement Activity_Text_ExpirationDate()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Text_ExpirationDate);
        }

        public static IWebElement Activity_Text_CreatedOnDate()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Text_CreatedOnDate);
        }

        public static IWebElement Activity_Text_SendingStatus()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Text_SendingStatus);
        }

        public static IWebElement Activity_Link_ReviewSend()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activity_Link_ReviewSend);
        }

        public static IWebElement Activity_Button_Send()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Button_Send);
        }

        public static IWebElement Activity_Text_Search()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Text_Search);
        }

        public static IWebElement Activity_button_Search()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activity_Button_Search);
        }

        public static IWebElement Activity_dropdown_CurrentlyViewing()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Dropdown_CurrentlyViewing);
        }

        public static IWebElement Activity_dropdown_Status()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Dropdown_Status);
        }

        public static IWebElement Activity_Button_Save()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Button_Save);
        }

        public static IWebElement Activity_Text_Comment()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Text_Comment);
        }

        public static IWebElement Activity_Button_GetLinkClose()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Button_GetLinkClose);
        }

        public static IWebElement Activity_Link_AdvanceSearch()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Link_AdvanceSearch);
        }

        public static IWebElement Activity_Dropdown_AdvanceSearch()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Dropdown_AdvanceSearch);
        }

        public static IWebElement Activity_Textbox_From()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Textbox_From);
        }

        public static IWebElement Activity_Textbox_To()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Textbox_To);
        }

        public static IWebElement Activity_Dropdown_In()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Dropdown_In);
        }

        public static IWebElement Activity_Textbox_WiththeWords()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Textbox_WiththeWords);
        }

        public static IWebElement Activity_Dropdown_With()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Dropdown_With);
        }

        public static IWebElement ActivityAdvanceSearch_Button_Search()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ActivityAdvanceSearch_Button_Search);
        }

        public static IWebElement Activity_Icon_eCard()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Icon_eCard);
        }

        public static IWebElement Activity_Icon_eProposal()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Icon_eProposal);
        }

        public static IWebElement Activity_Icon_ExpirationStartDate()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activity_Icon_ExpirationStartDate);
        }

        public static IWebElement Activity_Dropdown_ViewContracts()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Dropdown_ViewContracts);
        }

        public static IWebElement Activity_Icon_ExpirationEndDate()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activity_Icon_ExpirationEndDate);
        }

        public static IWebElement Activity_Preview_CustomSignature()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activity_Preview_CustomSignature);
        }

        public static IWebElement Activity_Preview_CustomSignatureImage()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            //< !--// Created by Divya 14 Aug 2017 : Modified locator from Xpath to Id-->
            return PageAction.Find_ElementId(ObjectRepository.Activity_Preview_CustomSignatureImage);
        }
        public static IWebElement Activity_Search_Textbox()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Search_Textbox);
        }
        public static IWebElement Activity_Search_Button()
        {
            ScanPage(Constants.Activity);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Activity_Search_Button);
        }
    }
}