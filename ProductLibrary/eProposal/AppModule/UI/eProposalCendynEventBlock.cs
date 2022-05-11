using System;
using Common;
using BaseUtility.Utility;
using eProposal.PageObject.UI;
using eProposal.Utility;
using eProposalConstants = eProposal.Utility.Constants;
using InfoMessageLogger;

namespace eProposal.AppModule.UI
{
    internal class eProposalCendynEventBlock
    {
        public static void Click_Link_EventDate()
        {
            Helper.ElementClick(PageObject_ProposalCendynEventBlock.Link_EventDate());
        }

        public static void Click_Button_Submit()
        {
            Helper.ElementClick(PageObject_ProposalCendynEventBlock.Button_Submit());
        }

        public static void Click_Button_Cancel()
        {
            Helper.ElementClick(PageObject_ProposalCendynEventBlock.Button_Cancel());
        }

        public static void Click_Link_EventBlockStoredContent1()
        {
            Helper.ElementClick(PageObject_ProposalCendynEventBlock.Link_EventBlockStoredContent1());
        }

        public static void Click_Link_EventBlockStoredContent2()
        {
            Helper.ElementClick(PageObject_ProposalCendynEventBlock.Link_EventBlockStoredContent2());
        }

        public static void Click_Link_AddEstimatedCosts()
        {
            Helper.ElementClick(PageObject_ProposalCendynEventBlock.Link_AddEstimatedCosts());
        }

        public static void Click_RadioButton_EstimatedCosts_Include()
        {
            Helper.ElementClick(PageObject_ProposalCendynEventBlock.RadioButton_EstimatedCosts_Include());
        }

        public static void Click_RadioButton_AdditionalFields_Include()
        {
            Helper.ElementClick(PageObject_ProposalCendynEventBlock.RadioButton_AdditionalFields_Include());
        }

        public static void Click_Button_Back()
        {
            Helper.ElementClick(PageObject_ProposalCendynEventBlock.Button_Back());
        }

        public static void Click_Button_Next()
        {
            try
            {
                Helper.PageDown();
                if (Project.IsThisStep4(eProposalConstants.EVENTBLOCK))
                    Helper.OpenPopUpWindow(PageObject_ProposalSelect.Button_Next());
                else
                    Helper.ElementClick(PageObject_ProposalSelect.Button_Next());
            }
            catch (Exception)
            {
                Helper.PageDown();
                if (Project.IsThisStep4(eProposalConstants.EVENTBLOCK))
                    Helper.OpenPopUpWindow(PageObject_ProposalCendynEventBlock.Button_Next());
                else
                    Helper.ElementClick(PageObject_ProposalCendynEventBlock.Button_Next());
            }
        }

        public static void EnterText_Text_StartTime(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCendynEventBlock.Text_StartTime(), text);
        }

        public static void EnterText_Text_EndTime(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCendynEventBlock.Text_EndTime(), text);
        }

        public static void EnterText_Text_Name(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCendynEventBlock.Text_Name(), text);
        }

        public static void EnterText_Text_Room(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCendynEventBlock.Text_Room(), text);
        }

        public static void EnterText_Text_Type(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCendynEventBlock.Text_Type(), text);
        }

        public static void EnterText_Text_RentalFee(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCendynEventBlock.Text_RentalFee(), text);
        }

        public static void EnterText_Text_Guests(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCendynEventBlock.Text_Guests(), text);
        }

        public static void EnterText_Text_Setup(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCendynEventBlock.Text_Setup(), text);
        }

        public static void EnterText_Text_Notes(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCendynEventBlock.Text_Notes(), text);
        }

        private static void EnterText_Text_EventBlockComments(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCendynEventBlock.Text_EventBlockComments(), text);
        }

        public static void EnterText_Text_EstimatedCosts_Item(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCendynEventBlock.Text_EstimatedCosts_Item(), text);
        }

        public static void EnterText_Text_EstimatedCosts_PricePerItems(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCendynEventBlock.Text_EstimatedCosts_PricePerItems(), text);
        }

        public static void EnterText_Text_EstimatedCosts_NumberOfItems(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCendynEventBlock.Text_EstimatedCosts_NumberOfItems(), text);
        }

        public static void EnterText_Text_EstimatedCosts_NumberOfDays(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCendynEventBlock.Text_EstimatedCosts_NumberOfDays(), text);
        }

        public static void EnterText_Text_AdditionalFields_Item(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCendynEventBlock.Text_AdditionalFields_Item(), text);
        }

        public static void EnterText_Text_AdditionalFields_Amount(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCendynEventBlock.Text_AdditionalFields_Amount(), text);
        }

        public static void Select_CheckBox_IncludeEventBlockInProposal()
        {
            Helper.ElementSelected(PageObject_ProposalCendynEventBlock.CheckBox_IncludeEventBlockInProposal());
        }

        public static void UnSelect_CheckBox_IncludeEventBlockInProposal()
        {
            Helper.ElementNOTSelected(PageObject_ProposalCendynEventBlock.CheckBox_IncludeEventBlockInProposal());
        }

        /// <summary>
        ///     This method will display and enter text in the Event Block Comments section.
        /// </summary>
        /// <param name="eventBlockComments">Text to enter</param>
        public static void EnterEventBlockComments(string eventBlockComments)
        {
            //Enter Event Block Intro iFrame
            Helper.EnterFrame("CE_ctl00_ctl00_MainContent_MainContent_edOtherComments2Editor_editor_ID_Frame");

            //Enter Welcome Message
            EnterText_Text_EventBlockComments(eventBlockComments);

            //Exit the iFrame
            Helper.ExitFrame();
        }

        /// <summary>
        ///     This method will return the Event Block comments value.
        /// </summary>
        /// <returns>Event Block Comments text.</returns>
        public static string GetEventBlockComments()
        {
            //Enter the iFrame
            Helper.EnterFrame("CE_ctl00_ctl00_MainContent_MainContent_edOtherComments2Editor_editor_ID_Frame");

            //Return the Welcome Message value
            var EventBlockComments = PageObject_ProposalCendynEventBlock.Text_EventBlockComments().Text;

            //Exit the iFrame
            Helper.ExitFrame();

            return EventBlockComments;
        }

        /// <summary>
        ///     This method will validate the Event Block Comments text matches the passed text.
        /// </summary>
        /// <param name="eventBlock">Text to match</param>
        public static void ValidateEventBlockComments(string eventBlock)
        {
            //Enter the iFrame
            Helper.EnterFrame("CE_ctl00_ctl00_MainContent_MainContent_edOtherComments2Editor_editor_ID_Frame");
            try
            {
                if (PageObject_ProposalCendynEventBlock.Text_EventBlockComments().Text == eventBlock)
                    Logger.WriteInfoMessage("The Event Block Comments text matches the passed text.");
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("The Event Block Comments did not match the passed text.");
                throw;
            }
            //Exit the iFrame
            Helper.ExitFrame();
        }
    }
}