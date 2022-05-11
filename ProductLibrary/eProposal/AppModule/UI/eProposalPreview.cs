using System;
using System.Globalization;
using System.Linq;
using Common;
using BaseUtility.Utility;
using eProposal.PageObject.UI;
using OpenQA.Selenium;
using eProposal.Utility;
using InfoMessageLogger;
using eProposalConstants = eProposal.Utility.Constants;

namespace eProposal.AppModule.UI
{
    internal class eProposalPreview
    {
        public static void Click_PopUpButton_Preview()
        {
            Helper.ElementClickUsingJavascript(PageObject_ProposalPreview.PopUpButton_Preview());
            Time.AddDelay(3500);
        }

        public static void Click_Link_PDF()
        {
            Helper.ElementClick(PageObject_ProposalPreview.Link_PDF());
            Time.AddDelay(3500);
        }

        public static void VerifyCustomSignature()
        {
            Helper.VerifyElementOnPage(PageObject_ProposalPreview.View_CustomSignature());
            Time.AddDelay(3500);
        }

        public static void Click_Button_Send()
        {
            Helper.ElementClick(PageObject_ProposalPreview.Button_Send());
            Time.AddDelay(2500);
        }

        public static void Click_Button_Preview()
        {
            Helper.ElementClick(PageObject_ProposalPreview.Button_Preview());
        }

        public static void Click_Link_SelfSend()
        {
            Helper.ElementClick(PageObject_ProposalPreview.Link_SelfSend());
        }

        public static void SelectFromDropDown_DropDown_AnotherLanguage(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_ProposalPreview.DropDown_AnotherLanguage(), text);
        }

        public static void Select_CheckBox_SaveAsMyFavorite()
        {
            Helper.ElementSelected(PageObject_ProposalPreview.CheckBox_SaveAsMyFavorite());
        }

        public static void UnSelect_CheckBox_SaveAsMyFavorite()
        {
            Helper.ElementNOTSelected(PageObject_ProposalPreview.CheckBox_SaveAsMyFavorite());
        }

        public static void ClosePreview()
        {
            Helper.ClosePopUpWindow();
        }
    }
}