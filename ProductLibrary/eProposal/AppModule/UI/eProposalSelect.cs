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
    internal class eProposalSelect : Helper
    {
        public static void Click_Link_CheckAll()
        {
            ElementClick(PageObject_ProposalSelect.Link_CheckAll());
        }

        public static void Click_Link_Clear()
        {
            ElementClick(PageObject_ProposalSelect.Link_Clear());
        }

        public static void Click_Link_AddContract()
        {
            ElementClick(PageObject_ProposalSelect.Link_AddContract());
        }

        public static void Click_Link_SelectVideo()
        {
            ElementClick(PageObject_ProposalSelect.Link_SelectVideo());
        }

        public static void Click_Button_Browse_Attachment1()
        {
            ElementClick(PageObject_ProposalSelect.Button_Browse_Attachment1());
        }

        public static void Click_Button_Browse_Attachment2()
        {
            ElementClick(PageObject_ProposalSelect.Button_Browse_Attachment2());
        }

        public static void Click_Button_Browse_Attachment3()
        {
            ElementClick(PageObject_ProposalSelect.Button_Browse_Attachment3());
        }

        public static void Click_Button_Browse_Attachment4()
        {
            ElementClick(PageObject_ProposalSelect.Button_Browse_Attachment4());
        }

        public static void Click_Button_Browse_Attachment5()
        {
            ElementClick(PageObject_ProposalSelect.Button_Browse_Attachment5());
        }

        public static void Click_Button_Browse_Attachment6()
        {
            ElementClick(PageObject_ProposalSelect.Button_Browse_Attachment6());
        }

        public static void Click_Button_Upload()
        {
            ElementClick(PageObject_ProposalSelect.Button_Upload());
        }

        public static void Click_Button_Back()
        {
            ElementClick(PageObject_ProposalSelect.Button_Back());
        }

        public static void Click_Button_Next()
        {
            //If this is step 4, click Next and make the popup window the focus.
            if (Project.IsThisStep4(eProposalConstants.SELECT))
                OpenPopUpWindow(PageObject_ProposalSelect.Button_Next());
            else
                ElementClick(PageObject_ProposalSelect.Button_Next());
        }

        public static void EnterText_TextBox_Attachment1(string text)
        {
            ElementEnterText(PageObject_ProposalSelect.TextBox_Attachment1(), text);
        }

        public static void EnterText_TextBox_Attachment2(string text)
        {
            ElementEnterText(PageObject_ProposalSelect.TextBox_Attachment2(), text);
        }

        public static void EnterText_TextBox_Attachment3(string text)
        {
            ElementEnterText(PageObject_ProposalSelect.TextBox_Attachment3(), text);
        }

        public static void EnterText_TextBox_Attachment4(string text)
        {
            ElementEnterText(PageObject_ProposalSelect.TextBox_Attachment4(), text);
        }

        public static void EnterText_TextBox_Attachment5(string text)
        {
            ElementEnterText(PageObject_ProposalSelect.TextBox_Attachment5(), text);
        }

        public static void EnterText_TextBox_Attachment6(string text)
        {
            ElementEnterText(PageObject_ProposalSelect.TextBox_Attachment6(), text);
        }

        public static void Select_CheckBox_Navigation_Honors()
        {
            ElementSelected(PageObject_ProposalSelect.CheckBox_Navigation_Honors());
        }

        public static void UnSelect_CheckBox_Navigation_Honors()
        {
            ElementNOTSelected(PageObject_ProposalSelect.CheckBox_Navigation_Honors());
        }

        public static void Click_Link_ViewYourVideo()
        {
            ElementClick(PageObject_ProposalSelect.Link_ViewYourVideo());
        }

        public static void Click_Button_Cancel()
        {
            ElementClick(PageObject_ProposalSelect.Button_Cancel());
        }
        
        /// <summary>
        ///     This method will check to make sure the navs do not contain the old Hilton Honors branding nav name (Hilton
        ///     HHonors).
        ///     This method will check to make sure a nav does contain the new Hilton Honors branding nav name (Honors).
        /// </summary>
        public static void VerifyHiltonRebranding()
        {
            try
            {
                if (PageObject_ProposalSelect.CheckBox_Navigation_Honors().Text == eProposalConstants.NewHiltonHonors)
                    Logger.WriteInfoMessage("The new Hilton Honors branding navigation was found on the Select page.");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("The new Hilton Honors branding navigation was not found on the Select page.");
                throw;
            }
        }

        /// <summary>
        /// Method to verify the URL contents
        /// </summary>
        public static void VerifyAttachedVideoURL()
        {
            try
            {
                string url = CommonMethod.Driver.Url;
                if(url.Contains("eft-dev.vidcomdev.com"))
                {
                    Logger.WriteDebugMessage("The URL contain'eft-dev.vidcomdev.com'.");
                }
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("The URL does not contain'eft-dev.vidcomdev.com'.");
                throw;
            }
        }
    }
}