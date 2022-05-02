using System;
using eProposal.Utility;
using eProposal.AppModule.UI;
using Common;
using Constants = eProposal.Utility.Constants;
using InfoMessageLogger;
using BaseUtility.Utility;
using TestData;
using SqlWarehouse;
using OpenQA.Selenium;
using NUnit.Framework;
using eProposal.AppModule.UI;
using eProposal.PageObject.UI;
using System.Text.RegularExpressions;

namespace eProposal.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        #region[TP_120480]
        
        private static string eProposalName = CommonMethod.TestCaseId + " - " + DateTime.Now.ToString(@"MMdd") + " " + thisDay.Hour + thisDay.Minute;
        private static string Property = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Property");
        private static string Module = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Module");
        private static string ProposalName = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "ProposalName");
        private static string KeywordSearch = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "KeywordSearch");
        private static string ClientSearch = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "ClientSearch");
        private static string ComposeCC = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "ComposeCC");
        private static string Email = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Email");
        private static string Password = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Password");
        private static string ClientName = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "ClientName");
        private static string ComposeBCC = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "ComposeBCC");
        private static string EventMonth = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "EventMonth");
        private static string EventDay = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "EventDay");
        private static string EventYear = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "EventYear");
        private static string ExpirationMonth = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "ExpirationMonth");
        private static string ExpirationDay = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "ExpirationDay");
        private static string ExpirationYear = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "ExpirationYear");
        private static string WelcomeMessage = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "WelcomeMessage");
        private static string MessageClosing = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "MessageClosing");
        
        #region[TC_120482]
        public static void TC_120482()
        {
            //1. Log into eP UI (employee).                
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select a property.                
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);

            //3. Click "Create/Edit -> eProposal"
            EmployeeHome.Click_CreateEdit_eProposalButton();
            AddDelay(6000);
            Logger.WriteDebugMessage("Landed on the Compose page.");

            //4. Fill in the eProposal name.
            eProposalCompose.SelectModule(Module);
            eProposalCompose.EnterText_ProposalNameText(eProposalName);
            Logger.WriteDebugMessage("eProposal name is entered.");

            //5. Use your own email as the "Client".
            eProposalCompose.SearchForClient(LegacyTestData.CommonEmployeeEmail);
            Logger.WriteDebugMessage("Client is added. ");

            //6. Select the "EZ" module.                            
            eProposalCompose.Click_Button_Next();
            Logger.WriteDebugMessage("EZ module is selected. Landed on Next Page.");

            //7. Do NOT select the "Include eBrochure" checkbox.
            //8. Continue filling out the eProposal and reach the "SELECT" step.
            //9. Verify the "Navigation" buttons are displayed. 
            Activity.RedirecttoNavigationButton();
            Logger.WriteDebugMessage("They are displayed ");

            //10. Click the "Activity" tab.
            //11. Look for the proposal you were just creating and verify "eBrochure" is NOT listed next to the module name.
            Activity.ClickActivityTab();
            Logger.WriteDebugMessage("Land on the Activity page.");

            //12.  Click "Create/Edit -> eProposal"
            EmployeeHome.Click_WelcomeButton();
            EmployeeHome.Click_CreateEdit_eProposalButton();
            Logger.WriteDebugMessage("Land on the eProposal page.");

            //13.Select the eProposal you were creating from the "Select eProposal" drop down.
            eProposalCompose.SelectFromDropDown_SelectProposalDropDown(eProposalName);
            Logger.WriteDebugMessage("Page refreshes with the eProposal information.");

            //14.Repeat steps 7-14 for all remaining modules. 
        }

        #endregion[TC_120481]

        #region[TC_120483]

        public static void TC_120483()
        {
            //1. Log into eP UI (employee).                
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select a property that has sent multiple eProposals.
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);

            //3. Click "Activity"
            Activity.ClickActivityTab();
            Logger.WriteDebugMessage("Land on the Activity page.");

            //4. Click "From"
            Activity.ClickLinkFrom();
            Logger.WriteDebugMessage("The column is sorted in alphabetical order.");

            //5. Click "From" again.
            Activity.ClickLinkFrom();
            Logger.WriteDebugMessage("The column is sorted in reverse alphabetical order.");

            //6. Click "To"
            Activity.ClickLinkTO();
            Logger.WriteDebugMessage("The column is sorted in alphabetical order.");

            //7. Click "To" again.
            Activity.ClickLinkTO();
            Logger.WriteDebugMessage("The column is sorted in reverse alphabetical order.");

            //8. Click "eProposal"
            Activity.ClickLinkeProposal();
            Logger.WriteDebugMessage("The column is sorted in alphabetical order.");

            //9. Click "eProposal" again.
            Helper.AddDelay(5000);
            Activity.ClickLinkeProposal();
            Logger.WriteDebugMessage("The column is sorted in reverse alphabetical order.");

            //10. Click "Views"
            Activity.ClickLinkViews();
            Logger.WriteDebugMessage("The column is sorted in alphabetical order.");

            //11. Click "Views" again.
            Activity.ClickLinkViews();
            Logger.WriteDebugMessage("The column is sorted in reverse alphabetical order.");

            //12. Click "Sending Status"
            Activity.ClickLinkSendingStatus();
            Logger.WriteDebugMessage("The column is sorted in alphabetical order.");

            //13. Click "Sending Status" again.
            Activity.ClickLinkSendingStatus();
            Logger.WriteDebugMessage("The column is sorted in reverse alphabetical order.");

            //14. Click "Sent On".
            Activity.ClickLinkSendOn();
            Logger.WriteDebugMessage("The column is sorted in alphabetical order.");

            //15. Click "Sent On" again.
            Activity.ClickLinkSendOn();
            Logger.WriteDebugMessage("The column is sorted in reverse alphabetical order.");

            //16. Click "Event Date".
            Activity.ClickLinkEventDate();
            Logger.WriteDebugMessage("The column is sorted in alphabetical order.");

            //17. Click "Event Date" again.
            Activity.ClickLinkEventDate();
            Logger.WriteDebugMessage("The column is sorted in reverse alphabetical order.");

            //18. Click "Expiration Date".
            Activity.ClickLinkExpirationDate();
            Logger.WriteDebugMessage("The column is sorted in alphabetical order.");

            //19. Click "Expiration Date" again.
            Activity.ClickLinkExpirationDate();
            Logger.WriteDebugMessage("The column is sorted in reverse alphabetical order.");

            //20. Click "Created On".
            Activity.ClickLinkCreatedOn();
            Logger.WriteDebugMessage("The column is sorted in alphabetical order.");

            //21. Click "Created On" again.
            Activity.ClickLinkCreatedOn();
            Logger.WriteDebugMessage("The column is sorted in reverse alphabetical order.");
        }

        #endregion[TC_120483]

        #region[TC_120484]

        public static void TC_120484()
        {
            //1. Log into eP UI (employee).                
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select a property that has sent multiple eProposals.
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);

            //3. Click "Activity"
            Activity.ClickActivityTab();
            Logger.WriteDebugMessage("Land on the Activity page.");

            //4. Click the "eCard" tab.
            Activity.ClickButtoneCard();
            Logger.WriteDebugMessage("Land on the eCard proposals.");

            ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollBy(0,500)", "");
            //5.  Click "From"
            Activity.ClickLinkFrom();
            Logger.WriteDebugMessage("The column is sorted in alphabetical order.");

            //6. Click "From" again.
            Helper.AddDelay(5000);
            Activity.ClickLinkFrom();
            Logger.WriteDebugMessage("The column is sorted in reverse alphabetical order.");

            //7. Click "To"
            Activity.ClickLinkTO();
            Logger.WriteDebugMessage("The column is sorted in alphabetical order.");

            //8. Click "To" again.
            Activity.ClickLinkTO();
            Logger.WriteDebugMessage("The column is sorted in reverse alphabetical order.");

            //9. Click "eCard"
            Activity.ClickLinkeCard();
            Logger.WriteDebugMessage("The column is sorted in alphabetical order.");

            //10. Click "eCard" again.
            Activity.ClickLinkeCard();
            Logger.WriteDebugMessage("The column is sorted in reverse alphabetical order.");

            //11. Click "Views"
            Activity.ClickLinkViews();
            Logger.WriteDebugMessage("The column is sorted in alphabetical order.");

            //12. Click "Views" again.
            Activity.ClickLinkViews();
            Logger.WriteDebugMessage("The column is sorted in reverse alphabetical order.");

            //13. Click "Sending Status"
            Activity.ClickLinkSendingStatus();
            Logger.WriteDebugMessage("The column is sorted in alphabetical order.");

            //14. Click "Sending Status" again.
            Activity.ClickLinkSendingStatus();
            Logger.WriteDebugMessage("The column is sorted in reverse alphabetical order.");

            //15. Click "Sent On".
            Activity.ClickLinkSendOn();
            Logger.WriteDebugMessage("The column is sorted in alphabetical order.");

            //16. Click "Sent On" again.
            Activity.ClickLinkSendOn();
            Logger.WriteDebugMessage("The column is sorted in reverse alphabetical order.");

            //17. Click "Created On".
            Activity.ClickLinkCreatedOn();
            Logger.WriteDebugMessage("The column is sorted in alphabetical order.");

            //18. Click "Created On" again.
            Activity.ClickLinkCreatedOn();
            Logger.WriteDebugMessage("The column is sorted in reverse alphabetical order.");
        }

        #endregion

        #region[TC_120485]

        public static void TC_120485()
        {
            string datetimegstring = DateTime.Now.ToShortDateString().Replace("/", "").ToString();
            string proposalName = ProposalName + " - " + datetimegstring;

            //1. Log into eP UI (employee).                
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select a property that has sent multiple eProposals.
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);

            // These steps are to ensure there is a proposal that can be used for remaining of test case //
            // *****************************************************************************************
            EmployeeHome.Click_CreateEdit_eProposalButton();
            Logger.WriteDebugMessage("Land on the eProposal page.");
            eProposalCompose.EnterText_ProposalNameText(proposalName);
            eProposalCompose.Click_Client_SearchLink();
            eProposalCompose.SearchForClient(ClientSearch);
            eProposalCompose.EnterText_CCText(ComposeCC);
            AddDelay(1000);
            eProposalCompose.Click_Button_Next();
            //Reach Step 2
            eProposalCompose.Click_Button_Next();
            //Reach Step 3
            eProposalCompose.Click_Button_Next();
            //Reach Step 4
            eProposalCompose.Click_Button_Next();
            Logger.WriteDebugMessage("Filled in all required eProposal fields and reached the 'Select' step");
            //Finish and send the eProposal.
            ControlToNewWindow();
            Driver.Close();
            ControlToPreviousWindow();
            Activity.ClickSend();
            Logger.WriteDebugMessage("Finished and sent for eProposal");


            //3. Click "Activity"
            Activity.ClickActivityTab();
            Logger.WriteDebugMessage("Land on the Activity page.");

            //Search for Created eProposal
            //Activity.Enter_Text_ActivityKeyword(TestData.TC_120485_KeywordSearch);
            //Activity.Click_ActivitySearchButton();
            Activity.SearchKeywords("Test Automation");
            Logger.WriteDebugMessage("A Search Results tab is displayed with proposals matching the keyword that was searched");
            //4. Click "Preview" on an eProposal.
            Activity.ClickLinkPreview();
            Logger.WriteDebugMessage("The eProposal preview opens in a new window/tab.");

            //5. On the eProposal, click the "Forward" button.
            Activity.clickForwardButtononeProposal();
            Logger.WriteDebugMessage(
                "Pop up is displayed with validation as This information is disabled in preview mode.");

            //6.Click "Get Link"
            ControlToPreviousWindow();
            Activity.ClickButtonGetLink();
            Logger.WriteDebugMessage("A popup is displayed with a URL.");

            //7.Copy and paste the URL into a browser.            
            //8. On the eProposal, click the "Forward" button.
            //9. Close the eProposal tab/window.
            Activity.GetURLandCopyPasteNewBrowser();

            //10. Click "Resend"
            Activity.ClickLinkResend();
            VerifyTextOnPage(Constants.Resend_Text);
            Logger.WriteDebugMessage("Popup is displayed asking Are you sure you want to resend the eProposal?");

            //11. Click "Yes".
            Activity.ClickbuttonResendOK();
            Logger.WriteDebugMessage(
                "Email is sent to the client. Another popup is displayed. The eProposal has been resent.");
            VerifyTextOnPage(Constants.Resend_Confirmation);
            Activity.ClickbuttonClose();

            //12. Click "Clone"
            Activity.ClickLinkClone();
            Logger.WriteDebugMessage("Land on the Compose page with information already filled in.");
            Activity.ClickActivityTab();

            //13.Click "Status"
            Helper.ElementEnterText(Driver.FindElement(By.Id("ctl00_MainContent_SearchField")), "Test Automation");
            Helper.ElementClick(Driver.FindElement(By.Id("ctl00_MainContent_btnSearch1")));
            Activity.ClickLinkStatus();
            Logger.WriteDebugMessage("eProposal Status popup is displayed.");

            //14. Click "Cancel"
            Activity.ClickStatusCancel();
            Logger.WriteDebugMessage("The popup closes.");

            //15.Click "Download PDF"
            //Activity.ClickLinkDownloadPDF();
            //Logger.WriteDebugMessage(
            //    "Depending on the property settings, the PDF will either begin downloading or a popup will display to select which pages to include in the PDF THEN it will download.");
        }

        #endregion

        #region[TC_120486]

        public static void TC_120486()
        {
            //1. Log into eP UI (employee).                
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select a property that has sent multiple eProposals.
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);

            //3. Click "Activity"
            Activity.ClickActivityTab();
            Logger.WriteDebugMessage("Land on the Activity page.");

            Activity.SearchKeywords("Test");
            Logger.WriteDebugMessage("A Search Results tab is displayed with proposals matching the keyword that was searched");

            //4. Click the "Expiration Date" calender.
            Activity.ClickExpirationDateIcon();
            Logger.WriteDebugMessage("Calender is displayed");

            //5. Set the date before today.
            Activity.Setdatebeforetoday();
            Logger.WriteDebugMessage("Error message is displayed Expiration date cannot occur before today.");
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollBy(0,15)", "");
            ElementClick(Driver.FindElement(By.Id("ctl00_MainContent_GridProposal_ctl02_btnMsgClose")));
            //6. Set the date after the "Event Date".
            Activity.SetdateafterEventDate();
            Logger.WriteDebugMessage(
                "Error message is displayed Expiration date cannot occur after the event date.");

            //7.Change the date to a date after today and before the "Event Date".
            //Activity.SetdateafterTodaybeforeEventDate();
            //Logger.WriteDebugMessage("The date changes with no error messages.");

            //8.Refresh the page.
            //9.Verify the changed date is the correct value.
            Driver.Navigate().Refresh();
            AddDelay(3000);
            Logger.WriteDebugMessage("The page is refreshed.");
        }

        #endregion

        #region[TC_120487]

        public static void TC_120487()
        {
            //1. Log into eP UI (employee).                
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select a property that has sent multiple eProposals.
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);

            //3. Click "Create/Edit -> eProposal"
            EmployeeHome.Click_CreateEdit_eProposalButton();
            AddDelay(6000);
            Logger.WriteDebugMessage("Land on the Compose page.");

            //4. Fill in all required information and make note of the "Event Date" and the "Expiration" date.
            //5. Click "Next".
            eProposalCompose.CommonCompose(eProposalName, ClientName,
                ComposeCC, ComposeBCC, EventMonth,
                EventDay, EventYear, ExpirationMonth,
                ExpirationYear, ExpirationDay, Module,
                WelcomeMessage, MessageClosing);
            Logger.WriteDebugMessage("Dates are noted. Information is filled in.");

            //6. Click "Activity"
            Activity.ClickActivityTab();
            Logger.WriteDebugMessage("Land on the Activity page.");

            //7. Verify the "Event Date" matches the date you selected.
            Activity.VerifyEventDate(EventMonth, EventYear,
                EventDay);
            Logger.WriteDebugMessage("It does matches");

            //8. Verify the "Expiration Date" matches the date you used.
            Activity.VerifyExpirationDate(ExpirationMonth, ExpirationYear,
                ExpirationDay);
            Logger.WriteDebugMessage("It does matches");

            //9. Verify the "Created On" date matches todays day.
            Activity.VerifyCreatedonDate();
            Logger.WriteDebugMessage("It does matches");
        }

        #endregion

        #region[TC_120488]

        public static void TC_120488()
        {

            string Property2 = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Property2");
            //1 Log into eProposal
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select a property that has sent multiple eProposals.
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);

            //3. Click "Create/Edit -> eProposal"
            EmployeeHome.Click_CreateEdit_eProposalButton();
            Logger.WriteDebugMessage("Land on the Compose page.");

            //4.Fill in all required information.
            //5.Click "Next"
            eProposalCompose.CommonComposeMandetory(eProposalName,
                ClientName);
            Logger.WriteDebugMessage("Land on the Step 2 page.");

            //6.Click "Activity"
            Activity.ClickActivityTab();
            Logger.WriteDebugMessage("Land on the Activity page.");

            //7.Verify the "Sending Status" for this eProposal states "Not Sent".
            Activity.VerifySendingStatus();
            Logger.WriteDebugMessage("Its is not sent");

            //8.Repeat steps 5-7 for the remaining eProposal steps.
            EmployeeHome.Click_WelcomeButton();
            EmployeeHome.SelectProperty(Property2);
            EmployeeHome.Click_CreateEdit_eProposalButton();
            eProposalCompose.CommonComposeMandetory(eProposalName,
                ClientName);
            Logger.WriteDebugMessage("Land on the Step 2 page.");

            //9. Repeat steps 5-7 for the remaining eProposal steps.
            //10. On Step 5, click "Send".
            eProposalCompose.RedirectToSendPage();

            //11.Click "Activity"
            Activity.ClickActivityTab();
            Logger.WriteDebugMessage("Land on the Activity page.");

            //12.Verify the "Sending Status" for this eProposal states "Sent" in green text.
            Activity.VerifySendingStatusSent();
            Logger.WriteDebugMessage("It is sent");
        }

        #endregion

        #region[TC_120489]

        public static void TC_120489()
        {
            string tentative = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "tentative");
            string comment = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "comment");
            string GeneralInquiry = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "comment");
            string definite = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Definite");
            string contracted = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Contracted");
            string pending = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Completed");
            string completed = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "comment");
            string canceled = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Canceled");
            string turnDown = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Lost");
            string lost = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "comment");
            string actualize = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Actualize");
            string viewed = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Viewed");
            string metron_RFP = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Metron_RFP");
            string archived = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Archived");
            
            //1 Log into eProposal
            //1. Log into eP UI (employee).                
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select a property that has sent multiple eProposals.
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);

            //3. Click "Activity"
            Activity.ClickActivityTab();
            Logger.WriteDebugMessage("Land on the Activity page.");

            //4. Open the "Currently Viewing" drop down menu.
            Activity.ClickCurrentlyViewing();
            Logger.WriteDebugMessage("Currently Viewing dropdown is dislayed");

            //5. Verify the following options are displayed : Prospect Tentative General Inquiry Definite Contracted Pending Completed Canceled Turn Down Lost Actualized Archived Viewed Metron - RFP All
            Activity.VerifyCurrentlyViewing();
            Logger.WriteDebugMessage("Error message is displayed Expiration date cannot occur before today.");

            //6. Click "Status" for an eProposal.
            Activity.ClickLinkStatus();
            Logger.WriteDebugMessage("Status pop up displayed");

            //7. Select "Tentative" and enter a comment.
            Activity.SelectStatus(tentative);
            Logger.WriteDebugMessage(tentative + " Status selected");
            Activity.EnterComment(comment);
            Logger.WriteDebugMessage(comment + " comment entered");

            //8. Click "Save"
            Activity.ClickSave();
            Logger.WriteDebugMessage("Save button clicked");

            //9. Click "Status" again and verify your comment is still displayed.
            Activity.SelectStatus(tentative);
            Logger.WriteDebugMessage(tentative + " Status selected");
            Activity.VerifyComment(comment);
            Logger.WriteDebugMessage(comment + " comment verified");

            //10. Click the "eCard" tab.
            Activity.ClickButtoneCard();
            Logger.WriteDebugMessage("eCard button clicked");

            //11. Repeat steps 6-10 for all remaining statuses in the "eProposal Status" popup.
            Activity.ClickLinkStatus();
            Logger.WriteDebugMessage("Status pop up displayed");
            Activity.SelectStatus(GeneralInquiry);
            Logger.WriteDebugMessage(GeneralInquiry + " Status selected");
            Activity.EnterComment(comment);
            Logger.WriteDebugMessage(comment + " comment entered");
            Activity.ClickSave();
            Logger.WriteDebugMessage("Save button clicked");
            Activity.SelectStatus(GeneralInquiry);
            Logger.WriteDebugMessage(GeneralInquiry + " Status selected");
            Activity.VerifyComment(comment);
            Logger.WriteDebugMessage(comment + " comment verified");
            Activity.ClickButtoneCard();
            Logger.WriteDebugMessage("eCard button clicked");

            Activity.ClickLinkStatus();
            Logger.WriteDebugMessage("Status pop up displayed");
            Activity.SelectStatus(definite);
            Logger.WriteDebugMessage(definite + " Status selected");
            Activity.EnterComment(comment);
            Logger.WriteDebugMessage(comment + " comment entered");
            Activity.ClickSave();
            Logger.WriteDebugMessage("Save button clicked");
            Activity.SelectStatus(definite);
            Logger.WriteDebugMessage(definite + " Status selected");
            Activity.VerifyComment(comment);
            Logger.WriteDebugMessage(comment + " comment verified");
            Activity.ClickButtoneCard();
            Logger.WriteDebugMessage("eCard button clicked");

            Activity.ClickLinkStatus();
            Logger.WriteDebugMessage("Status pop up displayed");
            Activity.SelectStatus(contracted);
            Logger.WriteDebugMessage(contracted + " Status selected");
            Activity.EnterComment(comment);
            Logger.WriteDebugMessage(comment + " comment entered");
            Activity.ClickSave();
            Logger.WriteDebugMessage("Save button clicked");
            Activity.SelectStatus(contracted);
            Logger.WriteDebugMessage(contracted + " Status selected");
            Activity.VerifyComment(comment);
            Logger.WriteDebugMessage(comment + " comment verified");
            Activity.ClickButtoneCard();
            Logger.WriteDebugMessage("eCard button clicked");

            Activity.ClickLinkStatus();
            Logger.WriteDebugMessage("Status pop up displayed"); 
            Activity.SelectStatus(pending);
            Logger.WriteDebugMessage(pending + " Status selected");
            Activity.EnterComment(comment);
            Logger.WriteDebugMessage(comment + " comment entered");
            Activity.ClickSave();
            Logger.WriteDebugMessage("Save button clicked");
            Activity.SelectStatus(pending);
            Logger.WriteDebugMessage(pending + " Status selected");
            Activity.VerifyComment(comment);
            Logger.WriteDebugMessage(comment + " comment verified");
            Activity.ClickButtoneCard();
            Logger.WriteDebugMessage("eCard button clicked");

            Activity.ClickLinkStatus();
            Logger.WriteDebugMessage("Status pop up displayed"); 
            Activity.SelectStatus(completed);
            Logger.WriteDebugMessage(completed + " Status selected");
            Activity.EnterComment(comment);
            Logger.WriteDebugMessage(comment + " comment entered");
            Activity.ClickSave();
            Logger.WriteDebugMessage("Save button clicked");
            Activity.SelectStatus(completed);
            Logger.WriteDebugMessage(completed + " Status selected");
            Activity.VerifyComment(comment);
            Logger.WriteDebugMessage(comment + " comment verified");
            Activity.ClickButtoneCard();
            Logger.WriteDebugMessage("eCard button clicked");

            Activity.ClickLinkStatus();
            Logger.WriteDebugMessage("Status pop up displayed"); 
            Activity.SelectStatus(canceled);
            Logger.WriteDebugMessage(canceled + " Status selected");
            Activity.EnterComment(comment);
            Logger.WriteDebugMessage(comment + " comment entered");
            Activity.ClickSave();
            Logger.WriteDebugMessage("Save button clicked");
            Activity.SelectStatus(canceled);
            Logger.WriteDebugMessage(canceled + " Status selected");
            Activity.VerifyComment(comment);
            Logger.WriteDebugMessage(comment + " comment verified");
            Activity.ClickButtoneCard();
            Logger.WriteDebugMessage("eCard button clicked");

            Activity.ClickLinkStatus();
            Logger.WriteDebugMessage("Status pop up displayed"); 
            Activity.SelectStatus(turnDown);
            Logger.WriteDebugMessage(turnDown + " Status selected");
            Activity.EnterComment(comment);
            Logger.WriteDebugMessage(comment + " comment entered");
            Activity.ClickSave();
            Logger.WriteDebugMessage("Save button clicked");
            Activity.SelectStatus(turnDown);
            Logger.WriteDebugMessage(turnDown + " Status selected");
            Activity.VerifyComment(comment);
            Logger.WriteDebugMessage(comment + " comment verified");
            Activity.ClickButtoneCard();
            Logger.WriteDebugMessage("eCard button clicked");

            Activity.ClickLinkStatus();
            Logger.WriteDebugMessage("Status pop up displayed");
            Activity.SelectStatus(lost);
            Logger.WriteDebugMessage(lost + " Status selected");
            Activity.EnterComment(comment);
            Logger.WriteDebugMessage(comment + " comment entered");
            Activity.ClickSave();
            Logger.WriteDebugMessage("Save button clicked");
            Activity.SelectStatus(lost);
            Logger.WriteDebugMessage(lost + " Status selected");
            Activity.VerifyComment(comment);
            Logger.WriteDebugMessage(comment + " comment verified");
            Activity.ClickButtoneCard();
            Logger.WriteDebugMessage("eCard button clicked");
            
            //12. Select "Actualized" drop the drop down.
            Activity.SelectCurrentlyViewing(actualize);
            Logger.WriteDebugMessage(actualize + " selected from currntly viewing dropdown");

            //13. Select "Archived" from the drop down.
            Activity.SelectCurrentlyViewing(archived);
            Logger.WriteDebugMessage(archived + " selected from currntly viewing dropdown");
            
            //14. Select "Viewed" from the drop down.
            Activity.SelectCurrentlyViewing(viewed);
            Logger.WriteDebugMessage(viewed + " selected from currntly viewing dropdown");
            AddDelay(8000);
            EmployeeHome.SelectProperty(Property);
            Activity.ClickActivityTab();

            //15. Select "Metron - RFP" from the drop down.
            Activity.SelectCurrentlyViewing(metron_RFP);
            Logger.WriteDebugMessage(metron_RFP + " selected from currntly viewing dropdown");
        }

        #endregion[TC_120489]

        #region[TC_120490]

        public static void TC_120490()
        {
            string pending = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "pending");
            string partiallySigned = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "partiallySigned");
            string datetimegstring = DateTime.Now.ToShortDateString().Replace("/", "").ToString();
            string proposalName = ProposalName + " - " + datetimegstring;
            //1. Log into eP UI (employee).                
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select a property that has "eContracts" turned on. (Admin -> Property -> Features).
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);

            //3. Click "Create/Edit -> eProposal"
            EmployeeHome.Click_CreateEdit_eProposalButton();
            Logger.WriteDebugMessage("Land on the eProposal page.");

            //4. Fill in all required eProposal fields and continue until you reach the "Select" step.
            eProposalCompose.EnterText_ProposalNameText(proposalName);
            eProposalCompose.Click_Client_SearchLink();
            eProposalCompose.SearchForClient(ClientSearch);
            //eProposalCompose.ClickSearchResult();
            eProposalCompose.EnterText_CCText(ComposeCC);
            AddDelay(1000);
            eProposalCompose.Click_Button_Next();
            //Reach Step 2
            if (Project.IsStep2Select())
            {
                eProposalSelect.Click_Link_AddContract();
                Logger.WriteDebugMessage("A Contract selected");
            }
            eProposalCompose.Click_Button_Next();
            //Reach Step 3
            eProposalCompose.Click_Button_Next();
            //Reach Step 4
            if (Project.IsStep4Select())
            {
                eProposalSelect.Click_Link_AddContract();
                Logger.WriteDebugMessage("A Contract selected");
            }
            eProposalCompose.Click_Button_Next();
            Logger.WriteDebugMessage("Filled in all required eProposal fields and reached the 'Select' step");


            //6. Finish and send the eProposal.
            ControlToNewWindow();
            Driver.Close();
            ControlToPreviousWindow();
            Activity.ClickSend();
            Logger.WriteDebugMessage("Finised and sent for eProposal");

            //7. Click "Activity".
            Activity.ClickActivityTab();
            Logger.WriteDebugMessage("Land on the Activity page.");

            Activity.SearchKeywords(proposalName);
            Logger.WriteDebugMessage("A Search Results tab is displayed with proposals matching the keyword that was searched");

            //8. Under "View Contracts", select "Pending".
            //Activity.ClickCurrentlyViewing();
            //Activity.SelectCurrentlyViewing(TestData.TC_120490_All);
            Activity.ClickViewContracts();
            Activity.SelectViewContracts(pending);
            Logger.WriteDebugMessage("Pending selected from View Contract");

            //9. Check the "Client" email and open the eProposal.
            Activity.ClickButtonGetLink();
            Activity.GetURLandCopyPasteNewWindow();

            //10. Sign the eContract as the client.
            ControlToNewWindow();
            eProposalView.OpenAndSignContractAsClient(ProposalName + "CLIENT");


            //11. Return to the "Activity" page and select "Partially Signed"
            ControlToPreviousWindow();
            //Activity.ClickCurrentlyViewing();
            //Activity.SelectCurrentlyViewing(TestData.TC_120490_All);
            Activity.ClickViewContracts();
            Activity.SelectViewContracts(partiallySigned);
            Logger.WriteDebugMessage("Partially Signed selected from View Contract");

            //12. Click and Sign the eContract.                
            Activity.OpenAndSignContractAsEmployee(ProposalName + "EMPLOYEE");
            Logger.WriteDebugMessage("Signed the contract successfully as both the client and the hotel employee.");
        }

        #endregion[TC_120489]

        #region[TC_120491]

        public static void TC_120491()
        {
            //1. Log into eP UI (employee).                
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2.Select a property that has sent multiple eProposals.
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);

            //3.Click "Activity"
            Activity.ClickActivityTab();
            Logger.WriteDebugMessage("Land on the Activity page.");

            //4.Enter a "keyword" (client name, employee name, proposal name, etc…) and click "Search".
            Activity.SearchKeywords(eProposalName);
            Logger.WriteDebugMessage(
                "A Search Results tab is displayed with proposals matching the keyword that was searched");
        }

        #endregion

        #region[TC_120492]

        public static void TC_120492()
        {
            string searchOption = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "SearchOption");
            string from = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "From");
            string to = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "From");
            string tentative = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Tentative");
            string GeneralInquiry = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "GeneralInquiry");
            string definite = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Definite");
            string contracted = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Contracted");
            string pending = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Completed");
            string completed = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "comment");
            string canceled = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Canceled");
            string turnDown = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Lost");
            string lost = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "comment");
            string metron_RFP = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Metron_RFP");
            string archived = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Archived");
            string actualize = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Actualize");
            string data = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "Data");
            string with = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "With");
            string startDate = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "StartDate");
            string endDate = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "EndDate");

            //1. Log into eP UI (employee).                
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2. Select a property that has sent multiple eProposals.
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);

            //3. Click "Activity"
            Activity.ClickActivityTab();
            Logger.WriteDebugMessage("Land on the Activity page.");

            //4. Click "Advanced Search"
            Activity.ClickAdvanceSearchLink();
            Logger.WriteDebugMessage("Advanced Search Option is displayed.");

            //5. Select "Both eProposals and eCards" and click "Search".
            Activity.SelectSearchOption(searchOption);
            Logger.WriteDebugMessage("All eProposals and eCards are displayed.");

            //6. Verify "eProposals" display a blue "eP" icon.
            Activity.VerifyeProposalIconColour();
            Logger.WriteDebugMessage("They do display as blue eP icon.");

            //7.Verify "eCards" display a green "eC" icon.
            Activity.VerifyeCardIconColour();
            Logger.WriteDebugMessage("They do display as green eC icon.");

            //8. Enter a "From" name and search.
            Activity.EnterFrom(from);
            Logger.WriteDebugMessage("All eProposals and eCards sent by that employee are displayed.");

            //9. Clear the "From" field.
            ElementClearText(PageObject_Activity.Activity_Textbox_From());
            Logger.WriteDebugMessage("Field is cleared.");

            //10. Enter a "To" name and search.
            Activity.EnterTo(to);
            Logger.WriteDebugMessage("All eProposals and eCards sent by that employee are displayed.");

            //11. Clear the "To" field.
            ElementClearText(PageObject_Activity.Activity_Textbox_To());
            Logger.WriteDebugMessage("Field is cleared.");

            //12. Select each "Status" and click "Search".
            Activity.ClickAdvanceSearchButton();
            Activity.SelectIn(tentative);
            Activity.ClickAdvanceSearchButton();
            Logger.WriteDebugMessage("All eProposals and eCards in the selected status are displayed.");

            //13.Repeat the previous step for all statuses.
            Activity.SelectIn(GeneralInquiry);
            Activity.ClickAdvanceSearchButton();
            Activity.SelectIn(definite);
            Activity.ClickAdvanceSearchButton();
            Activity.SelectIn(contracted);
            Activity.ClickAdvanceSearchButton();
            Activity.SelectIn(pending);
            Activity.ClickAdvanceSearchButton();
            Activity.SelectIn(completed);
            Activity.ClickAdvanceSearchButton();
            Activity.SelectIn(canceled);
            Activity.ClickAdvanceSearchButton();
            Activity.SelectIn(turnDown);
            Activity.ClickAdvanceSearchButton();
            Activity.SelectIn(lost);
            Activity.ClickAdvanceSearchButton();
            Activity.SelectIn(actualize);
            Activity.ClickAdvanceSearchButton();
            //Activity.SelectIn(Archived);
            //Activity.ClickAdvanceSearchButton();
            //Activity.SelectIn(Viewed);
            //Activity.ClickAdvanceSearchButton();
            Activity.SelectIn(metron_RFP);
            Activity.ClickAdvanceSearchButton();
            Logger.WriteDebugMessage("All eProposals and eCards in the selected status are displayed.");

            //14. Enter in a keyword and click "Search"
            Activity.EnterWiththeWords(data);
            Logger.WriteDebugMessage(
                "All eProposals and eCards are are displayed that match the keyword that was searched.");

            //15. Clear the keyword.
            ElementClearText(PageObject_Activity.Activity_Textbox_WiththeWords());
            Logger.WriteDebugMessage("Field is cleared.");

            //16. Select "Expiration Date" from the "With" dropdown.
            Activity.SelectWith(with);
            Logger.WriteDebugMessage("Start Date and End Date are displayed.");

            //17.Select a date range and click "Search".
            Activity.EnterText_StartDate(startDate);
            Activity.EnterText_EndDate(endDate);
            Activity.ClickAdvanceSearchButton();
        }

        #endregion[TP_120480]

        #endregion[TP_120480]
    }
}
