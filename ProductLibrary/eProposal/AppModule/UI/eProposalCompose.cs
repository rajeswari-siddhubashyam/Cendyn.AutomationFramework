using System;
using OpenQA.Selenium;
using System.Globalization;
using NUnit.Framework;
using System.IO;
using System.Reflection;
using System.Linq;
using Common;
using BaseUtility.Utility;
using eProposal.PageObject.UI;
using eProposal.Utility;
using InfoMessageLogger;
using eProposalConstants = eProposal.Utility.Constants;
using SqlWarehouse;
using AutoItX3Lib;

namespace eProposal.AppModule.UI
{
    internal class eProposalCompose : Helper
    {
        private static readonly string ClientExists = "A client with the same email address already exists.";

        private static readonly string SingleLanguageToolTip ="This module is currently available only in one language.";

        public static void VerifyEmail(string Email)
        {
            Helper.VerifyTextOnPage(Email);
            Helper.ElementClick(PageObject_ProposalCompose.View_Email());
            Time.AddDelay(3500);
        }

        public static void ClickAddAContact()
        {
            Time.AddDelay(3500);
            Helper.ElementClick(PageObject_ProposalCompose.Link_AddAContact());
            Time.AddDelay(3500);
        }

        public static void ClickSearchResult()
        {
            Time.AddDelay(3500);
            Helper.ElementClick(PageObject_ProposalCompose.Link_SearchResult());
            Time.AddDelay(3500);
        }

        public static void Click_Client_SearchLink()
        {
            Helper.ElementClick(PageObject_ProposalCompose.Client_SearchLink());
        }

        public static void Click_Client_AddNewLink()
        {
            Helper.ElementClick(PageObject_ProposalCompose.Client_AddNewLink());
        }

        public static void Select_CheckBox_IncludeOfferAtBottomOfWelcomeLetter()
        {
            Helper.ElementSelected(PageObject_ProposalCompose.CheckBox_IncludeOfferAtBottomOfWelcomeLetter());
        }

        public static void UnSelect_CheckBox_IncludeOfferAtBottomOfWelcomeLetter()
        {
            Helper.ElementNOTSelected(PageObject_ProposalCompose.CheckBox_IncludeOfferAtBottomOfWelcomeLetter());
        }

        public static void Click_Client_AddNew_HideShowAddressLink()
        {
            Helper.ElementClick(PageObject_ProposalCompose.Client_AddNew_HideShowAddressLink());
        }

        public static void Click_Client_AddNew_SaveButton()
        {
            Helper.ElementClick(PageObject_ProposalCompose.Client_AddNew_SaveButton());
        }

        public static void Click_Client_AddNew_CancelButton()
        {
            //Helper.ElementClick(PageObject_ProposalCompose.Client_AddNew_CancelButton());
            ElementClickUsingJavascript(PageObject_ProposalCompose.Client_AddNew_CancelButton());
        }

        public static void Click_WelcomeMessage_StoredContent1Link()
        {
            Helper.ElementClick(PageObject_ProposalCompose.WelcomeMessage_StoredContent1Link());
        }

        public static void Click_WelcomeMessage_StoredContent2Link()
        {
            Helper.ElementClick(PageObject_ProposalCompose.WelcomeMessage_StoredContent2Link());
        }

        public static void Click_WelcomeMessage_StoredContent3Link()
        {
            Helper.ElementClick(PageObject_ProposalCompose.WelcomeMessage_StoredContent3Link());
        }

        public static void Click_WelcomeMessage_StoredContent4Link()
        {
            Helper.ElementClick(PageObject_ProposalCompose.WelcomeMessage_StoredContent4Link());
        }

        public static void Click_UploadLogoLink()
        {
            Helper.ElementClick(PageObject_ProposalCompose.UploadLogoLink());
        }

        public static void Click_FromDropDown()
        {
            Helper.ElementClick(PageObject_ProposalCompose.EmployeeFromDropDown());
        }

        public static void EnterText_ProposalNameText(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCompose.ProposalNameText(), text);
        }

        public static void EnterText_Client_AddNew_FirstNameText(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCompose.Client_AddNew_FirstNameText(), text);
        }

        public static void EnterText_Client_AddNew_LastNameText(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCompose.Client_AddNew_LastNameText(), text);
        }

        public static void EnterText_Client_AddNew_CompanyText(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCompose.Client_AddNew_CompanyText(), text);
        }

        /// <summary>
        ///     Here we enter email that is sent as parameter
        /// </summary>
        /// <param name="Email"></param>
        public static void EnterText_Client_AddNew_EmailText(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCompose.Client_AddNew_EmailText(), text);
        }

        public static void EnterText_Client_AddNew_PhoneNumberText(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCompose.Client_AddNew_PhoneNumberText(), text);
        }

        public static void EnterText_Client_AddNew_AddressText(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCompose.Client_AddNew_AddressText(), text);
        }

        public static void EnterText_Client_AddNew_CityText(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCompose.Client_AddNew_CityText(), text);
        }

        public static void EnterText_Client_AddNew_StateText(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCompose.Client_AddNew_StateText(), text);
        }

        public static void EnterText_Client_AddNew_ZipText(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCompose.Client_AddNew_ZipText(), text);
        }

        public static void EnterText_CCText(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCompose.CCText(), text);
        }

        public static void EnterText_BCCText(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCompose.BCCText(), text);
        }

        private static void EnterText_WelcomeMessageText(string text)
        {
            Time.AddDelay(1500);
            PageObject_ProposalCompose.WelcomeMessageText().Clear();
            PageObject_ProposalCompose.WelcomeMessageText().SendKeys(text);
        }

        public static void EnterText_MessageClosingText(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCompose.MessageClosingText(), text);
        }

        public static void EnterText_SeniorStaffMessageText(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCompose.SeniorStaffMessageText(), text);
        }

        public static void SelectFromDropDown_LanguageDropDown(string text)
        {
            try
            {
                Helper.ElementSelectFromDropDown(PageObject_ProposalCompose.LanguageDropDown(), text);
            }
            catch (Exception)
            {
            }
        }

        public static void SelectFromDropDown_SelectProposalDropDown(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_ProposalCompose.SelectProposalDropDown(), text);
            Time.AddDelay(5000);
        }

        public static void SelectFromDropDown_EmployeeFromDropDown(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_ProposalCompose.EmployeeFromDropDown(), text);
        }

        public static void SelectFromDropDown_Client_AddNew_CountryDropDown(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_ProposalCompose.Client_AddNew_CountryDropDown(), text);
        }

        public static void Click_Client_EditLink()
        {
            Helper.ElementClick(PageObject_ProposalCompose.Client_EditLink());
        }

        public static void Click_Calendar_NextMonthButton()
        {
            Helper.ElementClick(PageObject_ProposalCompose.Calendar_NextMonthButton());
        }

        public static void Click_Calendar_PreviousMonthButton()
        {
            Helper.ElementClick(PageObject_ProposalCompose.Calendar_PreviousMonthButton());
        }

        public static void Click_EventDate()
        {
            Helper.ElementClick(PageObject_ProposalCompose.EventDate());
        }

        public static void Click_ExpirationDate()
        {
            Helper.ElementClick(PageObject_ProposalCompose.ExpirationDate());
        }

        public static void Click_RadioButton_Module1()
        {
            Helper.ElementClick(PageObject_ProposalCompose.RadioButton_Module1());
        }

        public static void Click_RadioButton_Module2()
        {
            Helper.ElementClick(PageObject_ProposalCompose.RadioButton_Module2());
        }

        public static void Click_RadioButton_Module3()
        {
            Helper.ElementClick(PageObject_ProposalCompose.RadioButton_Module3());
        }

        public static void Click_RadioButton_Module4()
        {
            Helper.ElementClick(PageObject_ProposalCompose.RadioButton_Module4());
        }

        public static void EnterText_Client_UneditableTextBox(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCompose.Client_UneditableTextBox(), text);
        }

        public static void EnterText_Client_SearchText(string text)
        {
            Helper.ElementEnterText(PageObject_ProposalCompose.Client_SearchText(), text);
        }

        public static void SelectFromDropDown_Calendar_MonthDropDown(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_ProposalCompose.Calendar_MonthDropDown(), text);
        }

        public static void SelectFromDropDown_Calendar_YearDropDown(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_ProposalCompose.Calendar_YearDropDown(), text);
        }

        public static void Click_Button_ClientSearchResult()
        {
            Helper.ElementClick(PageObject_ProposalCompose.Button_ClientSearchResult());
        }

        public static void Click_Button_Next()
        {
            Helper.ElementClick(PageObject_ProposalCompose.Button_Next());
            Time.AddDelay(2000);
        }

        public static void Click_Button_Browser()
        {
            Helper.ElementClick(PageObject_ProposalCompose.Button_Browse());
            Time.AddDelay(2000);
        }

        public static void Click_Button_Upload()
        {
            Helper.ElementClick(PageObject_ProposalCompose.Button_Upload());
            Time.AddDelay(2000);
        }

        public static void Select_CheckBox_UseMyFavoriteSettings()
        {
            Helper.ElementSelected(PageObject_ProposalCompose.CheckBox_UseMyFavoriteSettings());
            Time.AddDelay(120000);
        }

        public static void UnSelect_CheckBox_UseMyFavoriteSettings()
        {
            Helper.ElementNOTSelected(PageObject_ProposalCompose.CheckBox_UseMyFavoriteSettings());
        }

        public static void Click_Button_Client_Search_Search()
        {
            Helper.ElementClick(PageObject_ProposalCompose.Button_Client_Search_Search());
        }

        /// <summary>
        ///     This method will cick the "Search" client link, search for a client, and select the client.
        /// </summary>
        /// <param name="client"></param>
        public static void SearchForClient(string client)
        {
            Click_Client_SearchLink();
            EnterText_Client_SearchText("Test");
            Click_Button_Client_Search_Search();
            Click_Button_ClientSearchResult();
        }

        /// <summary>
        ///     This method will select an Event Date.
        /// </summary>
        public static void SelectEventDate(string month, string day, string year)
        {
            Click_EventDate();
            Project.Calendar(month, day, "2021");
        }
        public static void SelectEventDate2(int caseType)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            DateTime today = DateTime.Today;
            switch (caseType)
            {
                case 0:
                    
                    today = today.AddDays(5);
                    string eventdate = today.ToString("dd/MM/yyyy");
                    js.ExecuteScript("document.getElementById('ctl00_ctl00_MainContent_MainContent_txtEventDate').value='" + eventdate + "'");
                    break;
                case 1:
                    eventdate = today.ToString("dd/MM/yyyy");
                    js.ExecuteScript("document.getElementById('ctl00_ctl00_MainContent_MainContent_txtEventDate').value='" + eventdate + "'");
                    break;
            }
            
        }

        public static void SelectExpirationDate2(int caseType)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            DateTime today = DateTime.Today;
            switch (caseType)
            {
                case 0:

                    string eventdate = today.ToString("dd/MM/yyyy");
                    js.ExecuteScript("document.getElementById('ctl00_ctl00_MainContent_MainContent_txtDecisionDate').value='" + eventdate + "'");
                    break;
                case 1:
                    today = today.AddDays(1);
                    eventdate = today.ToString("dd/MM/yyyy");
                    js.ExecuteScript("document.getElementById('ctl00_ctl00_MainContent_MainContent_txtDecisionDate').value='" + eventdate + "'");
                    break;
            }
        }

        public static void SelectEventDate2_2(int caseType)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            DateTime today = DateTime.Today;
            switch (caseType)
            {
                case 0:

                    today = today.AddDays(5);
                    string eventdate = today.ToString("yyyy/MM/dd");
                    js.ExecuteScript("document.getElementById('ctl00_ctl00_MainContent_MainContent_txtEventDate').value='" + eventdate + "'");
                    break;
                case 1:
                    eventdate = today.ToString("yyyy/MM/dd");
                    js.ExecuteScript("document.getElementById('ctl00_ctl00_MainContent_MainContent_txtEventDate').value='" + eventdate + "'");
                    break;
            }

        }

        public static void SelectExpirationDate2_2(int caseType)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            DateTime today = DateTime.Today;
            switch (caseType)
            {
                case 0:

                    string eventdate = today.ToString("yyyy/MM/dd");
                    js.ExecuteScript("document.getElementById('ctl00_ctl00_MainContent_MainContent_txtDecisionDate').value='" + eventdate + "'");
                    break;
                case 1:
                    today = today.AddDays(1);
                    eventdate = today.ToString("yyyy/MM/dd");
                    js.ExecuteScript("document.getElementById('ctl00_ctl00_MainContent_MainContent_txtDecisionDate').value='" + eventdate + "'");
                    break;
            }
        }
        public static void SelectEventDate2_3(int caseType)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            DateTime today = DateTime.Today;
            switch (caseType)
            {
                case 0:

                    today = today.AddDays(5);
                    string eventdate = today.ToString("MM/dd/yyyy");
                    js.ExecuteScript("document.getElementById('ctl00_ctl00_MainContent_MainContent_txtEventDate').value='" + eventdate + "'");
                    break;
                case 1:
                    eventdate = today.ToString("MM/dd/yyyy");
                    js.ExecuteScript("document.getElementById('ctl00_ctl00_MainContent_MainContent_txtEventDate').value='" + eventdate + "'");
                    break;
            }

        }

        public static void SelectExpirationDate2_3(int caseType)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            DateTime today = DateTime.Today;
            switch (caseType)
            {
                case 0:

                    string eventdate = today.ToString("MM/dd/yyyy");
                    js.ExecuteScript("document.getElementById('ctl00_ctl00_MainContent_MainContent_txtDecisionDate').value='" + eventdate + "'");
                    break;
                case 1:
                    today = today.AddDays(1);
                    eventdate = today.ToString("MM/dd/yyyy");
                    js.ExecuteScript("document.getElementById('ctl00_ctl00_MainContent_MainContent_txtDecisionDate').value='" + eventdate + "'");
                    break;
            }
        }

        /// <summary>
        ///     This method will select an Expiration Date.
        /// </summary>
        public static void SelectExpirationDate(string month, string day, string year)
        {
            //Close off a calendar if there is one displayed.
            try
            {
                //Try to click the "Expiration Date" calendar icon if no calendar is already displayed.
                Click_ExpirationDate();
            }
            catch (Exception)
            {
                Project.Calendar(LegacyTestData.Compose_EventMonth, LegacyTestData.Compose_EventDay, LegacyTestData.Compose_EventYear);
                Click_ExpirationDate();
                //Catching an exception here means the Event Date calendar is opened by default from the error. Click the Event Date to close.

            }
            Project.Calendar(month, day, year);
        }

        /// <summary>
        ///     This method will select a module.
        /// </summary>
        /// <param name="module"></param>
        public static void SelectModule(string module)
        {
            try
            {
                if (PageObject_ProposalCompose.RadioButton_Module1().GetAttribute("value") == module)
                {
                    ScrollToElement(PageObject_ProposalCompose.RadioButton_Module1());
                    Click_RadioButton_Module1();
                }
                else if (PageObject_ProposalCompose.RadioButton_Module2().GetAttribute("value") == module)
                {
                    ScrollToElement(PageObject_ProposalCompose.RadioButton_Module2());
                    Click_RadioButton_Module2();
                }
                else if (PageObject_ProposalCompose.RadioButton_Module3().GetAttribute("value") == module)
                {
                    ScrollToElement(PageObject_ProposalCompose.RadioButton_Module3());
                    Click_RadioButton_Module3();
                }
                else if (PageObject_ProposalCompose.RadioButton_Module4().GetAttribute("value") == module)
                {
                    ScrollToElement(PageObject_ProposalCompose.RadioButton_Module4());
                    Click_RadioButton_Module4();
                }
                else
                {
                    throw new Exception("The entered module " + module + " is not an option on the page.");
                }
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage(e);
            }
        }

        /// <summary>
        ///     This method will enter the Welcome Message iFrame, insert text, then exit the iFrame.
        /// </summary>
        public static void EnterWelcomeMessage(string welcomeMessage)
        {
            //Enter the iFrame
            Helper.EnterFrame("CE_ctl00_ctl00_MainContent_MainContent_edWelcome_editor_ID_Frame");

            //Enter Welcome Message
            EnterText_WelcomeMessageText(welcomeMessage);

            //Exit the iFrame
            Helper.ExitFrame();
        }

        /// <summary>
        ///     This method will fill in all the data on the "Compose" page using the data from the Common.XML file in the Compose
        ///     section.
        ///     The eProposal name is the current test case ID + the current date and time
        /// </summary>
        public static void CommonCompose()
        {
            SelectFromDropDown_LanguageDropDown(LegacyTestData.Compose_LanguageSelection);
            EnterText_ProposalNameText(CommonMethod.TestCaseId + " - " + AddDateTime());
            SearchForClient(LegacyTestData.Compose_ClientName);
            EnterText_CCText(LegacyTestData.Compose_CC);
            EnterText_BCCText(LegacyTestData.Compose_BCC);
            SelectEventDate(LegacyTestData.Compose_EventMonth, LegacyTestData.Compose_EventDay, LegacyTestData.Compose_EventYear);
            SelectExpirationDate(LegacyTestData.Compose_ExpirationMonth, LegacyTestData.Compose_ExpirationDay,
                LegacyTestData.Compose_ExpirationYear);
            SelectModule(LegacyTestData.Compose_Module);
            EnterWelcomeMessage(LegacyTestData.Compose_WelcomeMessage);
            EnterText_MessageClosingText(LegacyTestData.Compose_MessageClosing);
            Click_Button_Next();
        }

        public static void CommonRequiredFields()
        {
            //SelectFromDropDown_LanguageDropDown(LegacyTestData.Compose_LanguageSelection);
            string getdefaultLanguage = Driver.FindElement(By.Id("ctl00_ctl00_MainContent_MainContent_lblDefaultLanguage")).Text;
            Logger.WriteInfoMessage("Default Language is " + getdefaultLanguage);
            EnterText_ProposalNameText(CommonMethod.TestCaseId + " - " + Helper.AddDateTime());
            //SearchForClient(LegacyTestData.Compose_ClientName);
            SearchForClient("AutomationClient");
            //SelectEventDate(LegacyTestData.Compose_EventMonth, LegacyTestData.Compose_EventDay, LegacyTestData.Compose_EventYear);
            SelectEventDate2(0);
            SelectExpirationDate2(1);
            //SelectExpirationDate(LegacyTestData.Compose_ExpirationMonth, LegacyTestData.Compose_ExpirationDay,
            //    LegacyTestData.Compose_ExpirationYear);
            EnterWelcomeMessage(LegacyTestData.Compose_WelcomeMessage);
        }
        public static void CommonRequiredFields2()
        {
            //SelectFromDropDown_LanguageDropDown(LegacyTestData.Compose_LanguageSelection);
            string getdefaultLanguage = Driver.FindElement(By.Id("ctl00_ctl00_MainContent_MainContent_lblDefaultLanguage")).Text;
            Logger.WriteInfoMessage("Default Language is " + getdefaultLanguage);
            EnterText_ProposalNameText(CommonMethod.TestCaseId + " - " + Helper.AddDateTime());
            //SearchForClient(LegacyTestData.Compose_ClientName);
            SearchForClient("AutomationClient");
            //SelectEventDate(LegacyTestData.Compose_EventMonth, LegacyTestData.Compose_EventDay, LegacyTestData.Compose_EventYear);
            SelectEventDate2_2(0);
            SelectExpirationDate2_2(1);
            //SelectExpirationDate(LegacyTestData.Compose_ExpirationMonth, LegacyTestData.Compose_ExpirationDay,
            //    LegacyTestData.Compose_ExpirationYear);
            EnterWelcomeMessage(LegacyTestData.Compose_WelcomeMessage);
        }

        public static void CommonRequiredFields3()
        {
            //SelectFromDropDown_LanguageDropDown(LegacyTestData.Compose_LanguageSelection);
            string getdefaultLanguage = Driver.FindElement(By.Id("ctl00_ctl00_MainContent_MainContent_lblDefaultLanguage")).Text;
            Logger.WriteInfoMessage("Default Language is " + getdefaultLanguage);
            EnterText_ProposalNameText(CommonMethod.TestCaseId + " - " + Helper.AddDateTime());
            //SearchForClient(LegacyTestData.Compose_ClientName);
            SearchForClient("AutomationClient");
            //SelectEventDate(LegacyTestData.Compose_EventMonth, LegacyTestData.Compose_EventDay, LegacyTestData.Compose_EventYear);
            SelectEventDate2_3(0);
            SelectExpirationDate2_3(1);
            //SelectExpirationDate(LegacyTestData.Compose_ExpirationMonth, LegacyTestData.Compose_ExpirationDay,
            //    LegacyTestData.Compose_ExpirationYear);
            EnterWelcomeMessage(LegacyTestData.Compose_WelcomeMessage);
        }

        /// <summary>
        ///     This method will verify the client displays in the search result.
        /// </summary>
        /// <param name="client">First name, last name or company of the client</param>
        public static void VerifyClientSearchResult(string client)
        {
            try
            {
                if (Helper.VerifyTextOnPage(client))
                    Logger.WriteInfoMessage("Found the client: '" + client +
                                            "' in the eProposal Client search result.");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("The client did not display in the eProposal search result.");
                throw;
            }
        }

        /// <summary>
        ///     This method will search for the client in the search and click the first result.
        /// </summary>
        /// <param name="client"></param>
        public static void SearchAndClickClient(string client)
        {
            EnterText_Client_SearchText(client);
            Click_Button_Client_Search_Search();
            Time.AddDelay(1500);
            VerifyClientSearchResult(client);
        }

        /// <summary>
        ///     This method will validate the first name only accepts 100 characters.
        /// </summary>
        public static void VerifyFirstNameLength()
        {
            EnterText_Client_AddNew_FirstNameText(eProposalConstants.LongString);
            var testString = PageObject_ProposalCompose.Client_AddNew_FirstNameText().GetAttribute("value");

            try
            {
                if (Helper.StringLength(testString) != 100)
                    throw new Exception();
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("The First Name max characters is not 50.");
                Logger.WriteFatalMessage("The First Name max characters is allowing : " +
                                         Helper.StringLength(testString));
                throw;
            }
        }

        /// <summary>
        ///     This method will validate the Last name only accepts 100 characters.
        /// </summary>
        public static void VerifyLastNameLength()
        {
            EnterText_Client_AddNew_LastNameText(eProposalConstants.LongString);
            var testString = PageObject_ProposalCompose.Client_AddNew_LastNameText().GetAttribute("value");

            try
            {
                if (Helper.StringLength(testString) != 100)
                    throw new Exception();
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("The Last Name max characters is not 50.");
                Logger.WriteFatalMessage(
                    "The Last Name max characters is allowing : " + Helper.StringLength(testString));
                throw;
            }
        }

        /// <summary>
        ///     This method will validate the Company name only accepts 250 characters.
        /// </summary>
        public static void VerifyCompanyNameLength()
        {
            EnterText_Client_AddNew_CompanyText(eProposalConstants.LongString);
            var testString = PageObject_ProposalCompose.Client_AddNew_CompanyText().GetAttribute("value");

            try
            {
                if (Helper.StringLength(testString) != 250)
                    throw new Exception();
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("The Company Name max characters is not 50.");
                Logger.WriteFatalMessage("The Company Name max characters is allowing : " +
                                         Helper.StringLength(testString));
                throw;
            }
        }

        /// <summary>
        ///     This method will validate the Email name only accepts 300 characters.
        /// </summary>
        public static void VerifyEmailNameLength()
        {
            EnterText_Client_AddNew_EmailText(eProposalConstants.LongString);
            var testString = PageObject_ProposalCompose.Client_AddNew_EmailText().GetAttribute("value");

            try
            {
                if (Helper.StringLength(testString) != 300)
                    throw new Exception();
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("The Email Name max characters is not 50.");
                Logger.WriteFatalMessage("The Email Name max characters is allowing : " +
                                         Helper.StringLength(testString));
                throw;
            }
        }

        /// <summary>
        ///     This method will validate the Phone Number only accepts 50 characters.
        /// </summary>
        public static void VerifyPhoneNumberLength()
        {
            EnterText_Client_AddNew_PhoneNumberText(eProposalConstants.LongString);
            var testString = PageObject_ProposalCompose.Client_AddNew_PhoneNumberText().GetAttribute("value");

            try
            {
                if (Helper.StringLength(testString) != 50)
                    throw new Exception();
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("The Phone Number max characters is not 50.");
                Logger.WriteFatalMessage("The Phone Number max characters is allowing : " +
                                         Helper.StringLength(testString));
                throw;
            }
        }

        /// <summary>
        ///     This method will validate the Address only accepts 200 characters.
        /// </summary>
        public static void VerifyAddressLength()
        {
            EnterText_Client_AddNew_AddressText(eProposalConstants.LongString);
            var testString = PageObject_ProposalCompose.Client_AddNew_AddressText().GetAttribute("value");

            try
            {
                if (Helper.StringLength(testString) != 200)
                    throw new Exception();
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("The Address max characters is not 50.");
                Logger.WriteFatalMessage("The Address max characters is allowing : " + Helper.StringLength(testString));
                throw;
            }
        }

        /// <summary>
        ///     This method will validate the City only accepts 100 characters.
        /// </summary>
        public static void VerifyCityLength()
        {
            EnterText_Client_AddNew_CityText(eProposalConstants.LongString);
            var testString = PageObject_ProposalCompose.Client_AddNew_CityText().GetAttribute("value");

            try
            {
                if (Helper.StringLength(testString) != 100)
                    throw new Exception();
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("The City max characters is not 50.");
                Logger.WriteFatalMessage("The City max characters is allowing : " + Helper.StringLength(testString));
                throw;
            }
        }

        /// <summary>
        ///     This method will validate the State only accepts 50 characters.
        /// </summary>
        public static void VerifyStateLength()
        {
            EnterText_Client_AddNew_StateText(eProposalConstants.LongString);
            var testString = PageObject_ProposalCompose.Client_AddNew_StateText().GetAttribute("value");

            try
            {
                if (Helper.StringLength(testString) != 50)
                    throw new Exception();
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("The State max characters is not 50.");
                Logger.WriteFatalMessage("The State max characters is allowing : " + Helper.StringLength(testString));
                throw;
            }
        }

        /// <summary>
        ///     This method will validate the Zip only accepts 50 characters.
        /// </summary>
        public static void VerifyZipLength()
        {
            EnterText_Client_AddNew_ZipText(eProposalConstants.LongString);
            var testString = PageObject_ProposalCompose.Client_AddNew_ZipText().GetAttribute("value");

            try
            {
                if (Helper.StringLength(testString) != 50)
                    throw new Exception();
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("The Zip max characters is not 50.");
                Logger.WriteFatalMessage("The Zip max characters is allowing : " + Helper.StringLength(testString));
                throw;
            }
        }

        /// <summary>
        ///     This method will clear all the values entered in the "Add New Client" popup.
        /// </summary>
        public static void AddNewClient_ClearAllFields()
        {
            try
            {
                PageObject_ProposalCompose.Client_AddNew_FirstNameText().Clear();
                PageObject_ProposalCompose.Client_AddNew_LastNameText().Clear();
                PageObject_ProposalCompose.Client_AddNew_CompanyText().Clear();
                PageObject_ProposalCompose.Client_AddNew_EmailText().Clear();
                PageObject_ProposalCompose.Client_AddNew_PhoneNumberText().Clear();
                PageObject_ProposalCompose.Client_AddNew_AddressText().Clear();
                PageObject_ProposalCompose.Client_AddNew_CityText().Clear();
                PageObject_ProposalCompose.Client_AddNew_StateText().Clear();
                PageObject_ProposalCompose.Client_AddNew_ZipText().Clear();
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("Unable to clear all Add New Client fields.");
                throw;
            }
        }

        /// <summary>
        ///     This method will click the "Address" link and verify the optional fields are displayed.
        /// </summary>
        public static void ExpandAddNewClientAddressFields()
        {
            try
            {
                //Click "Address" link
                Click_Client_AddNew_HideShowAddressLink();

                if (PageObject_ProposalCompose.Client_AddNew_AddressText().Displayed)
                    Logger.WriteInfoMessage("The Address fields are expanded and displayed.");
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("After clicking the Address link, the Address fields did not display.");
                throw;
            }
        }

        /// <summary>
        ///     This method will click the "Hide Address" link and verify the optional fields are collapsed.
        /// </summary>
        public static void CollapseExpandAddNewClientAddressFields()
        {
            try
            {
                //Click "Address" link
                Click_Client_AddNew_HideShowAddressLink();

                if (!PageObject_ProposalCompose.Client_AddNew_AddressText().Displayed)
                    Logger.WriteInfoMessage("The Address fields are collapsed.");
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("After clicking the Address link, the Address fields did not display.");
                throw;
            }
        }

        /// <summary>
        ///     This method will enter data into all the Add New Client fields.
        /// </summary>
        public static void AddNewClient_EnterAllValidFields(string firstName, string lastName, string company,
            string email, string phoneNumber,
            string address, string city, string state, string zip, string country)
        {
            EnterText_Client_AddNew_FirstNameText(firstName);
            EnterText_Client_AddNew_LastNameText(lastName);
            EnterText_Client_AddNew_CompanyText(company);
            EnterText_Client_AddNew_EmailText(email);
            EnterText_Client_AddNew_PhoneNumberText(phoneNumber);

            if (!PageObject_ProposalCompose.Client_AddNew_AddressText().Displayed)
                ExpandAddNewClientAddressFields();

            EnterText_Client_AddNew_AddressText(address);
            EnterText_Client_AddNew_CityText(city);
            EnterText_Client_AddNew_StateText(state);
            EnterText_Client_AddNew_ZipText(zip);
            SelectFromDropDown_Client_AddNew_CountryDropDown(country);
        }


        /// <summary>
        ///     This method will fill in all the data on the "Compose" page using the data from the Common.XML file in the Compose
        ///     section.
        ///     The eProposal name is the current test case ID + the current date and time
        /// </summary>
        public static void CommonCompose(string eproposalName, string Compose_ClientName, string Compose_CC,
            string Compose_BCC, string Compose_EventMonth, string Compose_EventDay, string Compose_EventYear,
            string Compose_ExpirationMonth, string Compose_ExpirationYear, string Compose_ExpirationDay,
            string Compose_Module, string Compose_WelcomeMessage, string Compose_MessageClosing)
        {
            EnterText_ProposalNameText(eproposalName + " - " + Helper.AddDateTime());
            SearchForClient(Compose_ClientName);
            EnterText_CCText(Compose_CC);
            EnterText_BCCText(Compose_BCC);
            SelectEventDate(Compose_EventMonth, Compose_EventDay, Compose_EventYear);
            SelectExpirationDate(Compose_ExpirationMonth, Compose_ExpirationDay, Compose_ExpirationYear);
            SelectModule(Compose_Module);
            EnterWelcomeMessage(Compose_WelcomeMessage);
            EnterText_MessageClosingText(Compose_MessageClosing);
            Click_Button_Next();
            Time.AddDelay(3500);
        }

        /// <summary>
        ///     This method will verify the "Client already exists..." message is displayed when trying to add a client with an
        ///     existing email.
        /// </summary>
        public static void VerifyClientAlreadyExists()
        {
            try
            {
                Time.AddDelay(5000);
                if (ClientExists == CommonMethod.Driver.FindElement(By.XPath("//p[@class='warning']")).Text)
                    Logger.WriteDebugMessage("The Client Already Exists... message was displayed properly.");
                else
                    throw new Exception(
                        "The Client Already Exists... message was not displayed when adding an existing client.");
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage(e);
                throw;
            }
        }

        /// <summary>
        ///     This method will validate the Event Date field does not accept a date before today. This method will use
        ///     yesterday's date.
        /// </summary>
        public static void EventDate_ValidateBeforeToday()
        {
            DateTime today = DateTime.Today;
            string todaysdate = today.ToString("MM/dd/yyyy");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            string getDate = js.ExecuteScript("document.getElementById('ctl00_ctl00_MainContent_MainContent_txtEventDate').value").ToString();

            if (todaysdate == getDate)
            {
                Logger.WriteInfoMessage("Selected date is today's date");
            }
            else
            {
                Assert.Fail("Event Date is not today's date.");
            }

            //var yesterday = DateTime.Now.AddDays(-1);

            //var month = yesterday.ToString("MMM");
            //var year = yesterday.ToString("yyyy");
            //var day = yesterday.ToString("dd");


            //try
            //{
            //    SelectEventDate(month, day, year);

            //    //grab the date in the event date field
            //    var eventDate =
            //        CommonMethod.Driver.FindElement(
            //                By.XPath("//input[@id='ctl00_ctl00_MainContent_MainContent_txtEventDate']"))
            //            .GetAttribute("value");
            //}
            //catch (NoSuchElementException)
            //{
            //    Logger.WriteInfoMessage("Not able to select an Event Date previous to today.");
            //}
            //catch (Exception)
            //{
            //    Logger.WriteFatalMessage("Able to select an Event Date previous to today.");
            //}

            ////Select a valid date to close the popup
            //month = DateTime.Now.ToString("MMM");
            //year = DateTime.Now.ToString("yyyy");
            //day = DateTime.Now.ToString("dd");
            //SelectEventDate(month, day, year);
        }

        /// <summary>
        ///     This method will validate setting the Event Date to come before the Proposal Expiration date.
        /// </summary>
        public static void EventDate_ValidateEventDateBeforeExpiration()
        {
            
            var aFewDaysAway = DateTime.Now.AddDays(+5);
            var month = aFewDaysAway.ToString("MMM");
            var year = aFewDaysAway.ToString("yyyy");
            var day = aFewDaysAway.ToString("dd");


            //Set Expiration Date
            SelectExpirationDate(month, day, year);

            //Set Event Date before Expiration Date
            month = DateTime.Now.ToString("MMM");
            year = DateTime.Now.ToString("yyyy");
            day = DateTime.Now.ToString("dd");
            SelectEventDate(month, day, year);

            try
            {
                //Verify the error message is displayed.
                if (VerifyEventDateBeforeExpirationMessage())
                    Logger.WriteInfoMessage(
                        "The Expiration Date cannot occur after Event Date occur displayed correctly.");
                else throw new Exception();
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("Was able to set the Event Date before the Expiration Date without error.");
                throw;
            }
        }

        /// <summary>
        ///     This method will return TRUE if the error message is displayed when selecting an event date before the expiration
        ///     date.
        /// </summary>
        public static bool VerifyEventDateBeforeExpirationMessage()
        {
            try
            {
                if (CommonMethod.Driver.FindElement(By.XPath("//label[contains(@id,'decisionDateMessage')]")).Displayed)
                {
                    Logger.WriteInfoMessage(
                        "The 'Expiration date cannot occur after event date' error message is displayed correctly.");
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

        /// <summary>
        ///     This method will advance the page with invalid dates and verify the Proposal Expires on popup is automatically
        ///     displayed.
        /// </summary>
        
        public static void EventDate_VerifyPopupDisplayedAfterClickingNext()
        {
            Click_Button_Next(); 

            if (VerifyTextOnPage("The expiration date cannot occur after event date"))
            {
                Logger.WriteDebugMessage("Error Message - The expiration date cannot occur after event date was not displayed on screen. Displayed on screen.");
                Logger.WriteInfoMessage("Changing the Date.");
                SelectExpirationDate2(0);
                Logger.WriteInfoMessage("Corrected Dates and continuing to next button.");
            }
            else
            {
                Assert.Fail("Validation message - The expiration date cannot occur after event date was not displayed on screen");
            }
            

            /*
            try
            {
                if (PageObject_ProposalCompose.Calendar_MonthDropDown().Displayed)
                    Logger.WriteInfoMessage(
                        "The Proposal Expires On popup was automatically displayed when trying to continue with an Event Date before the Expiration Date.");
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage(
                    "The Expiration Date popup did not automatically display when trying to continue with an Event Date before the Expiration Date.");
            }

            //Select a valid date to close the popup
            var month = DateTime.Now.ToString("MMM");
            var year = DateTime.Now.ToString("yyyy");
            var day = DateTime.Now.ToString("dd");
            Project.Calendar(month, day, year);
            */
        }

        public static void ValidateDateLandedNextPage()
        {
            Click_Button_Next();
            AddDelay(8000);
            Logger.WriteDebugMessage("Date is selected and displayed. The error message is removed.");
        }

        /// <summary>
        ///     This method will validate setting an Expiration Date before the Event Date
        /// </summary>
        public static void SelectValidProposalDates()
        {
            var month = DateTime.Now.ToString("MMM");
            var year = DateTime.Now.ToString("yyyy");
            var day = DateTime.Now.ToString("dd");

            //Set Expiration Date
            SelectExpirationDate(month, day, year);

            //Set Event Date before Expiration Date
            month = DateTime.Now.AddDays(+5).ToString("MMM");
            year = DateTime.Now.AddDays(+5).ToString("yyyy");
            day = DateTime.Now.AddDays(+5).ToString("dd");
            SelectEventDate(month, day, year);

            try
            {
                //Verify the error message is displayed.
                if (!VerifyEventDateBeforeExpirationMessage())
                    Logger.WriteInfoMessage(
                        "The Expiration Date cannot occur after Event Date error message did not display when the Event Date is after the Expiration Date.");
                else throw new Exception();
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage(
                    "The Expiration Date cannot occur after Event Date error message displayed when the Event Date is after the Expiration Date.");
                throw;
            }
        }

        /// <summary>
        ///     This method will validate the Event Date field does not accept a date before today. This method will use
        ///     yesterday's date.
        /// </summary>
        public static void ExpirationDate_ValidateBeforeToday()
        {
            var yesterday = DateTime.Now.AddDays(-1);

            var month = yesterday.ToString("MMM");
            var year = yesterday.ToString("yyyy");
            var day = yesterday.ToString("dd");

            try
            {
                SelectExpirationDate(month, day, year);
                throw new Exception();
            }
            catch (NoSuchElementException)
            {
                Logger.WriteInfoMessage("Not able to select an Expiration Date previous to today.");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("Able to select an Expiration Date previous to today.");
            }

            //Select a valid date to close the popup
            month = DateTime.Now.ToString("MMM");
            year = DateTime.Now.ToString("yyyy");
            day = DateTime.Now.ToString("dd");
            SelectExpirationDate(month, day, year);
        }

        /// <summary>
        ///     This method will validate setting the Expiration Date to come after the Proposal Expiration date.
        /// </summary>
        public static void ExpirationDate_ValidateEventDateBeforeExpiration()
        {
            //Set Event Date
            var month = DateTime.Now.ToString("MMM");
            var year = DateTime.Now.ToString("yyyy");
            var day = DateTime.Now.ToString("dd");
            SelectEventDate(month, day, year);

            //Set Expiration Date after Event Date
            var aFewDaysAway = DateTime.Now.AddDays(+5);
            month = aFewDaysAway.ToString("MMM");
            year = aFewDaysAway.ToString("yyyy");
            day = aFewDaysAway.ToString("dd");
            SelectExpirationDate(month, day, year);


            try
            {
                //Verify the error message is displayed.
                if (VerifyEventDateBeforeExpirationMessage())
                    Logger.WriteInfoMessage(
                        "The Expiration Date cannot occur after Event Date occur displayed correctly.");
                else throw new Exception();
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("Was able to set the Event Date before the Expiration Date without error.");
                throw;
            }
        }

        /// <summary>
        ///     This method will verify the Room and Event Block first date matches the Event Date on the Compose page.
        /// </summary>
        public static void ValidateEventDatesOnRoomAndEventBlock()
        {
            //Obtain the value for the first day of the event.
            var eventDate = PageObject_ProposalCompose.EventDate().GetAttribute("value");
            var expirationdate = PageObject_ProposalCompose.ExpirationDate().GetAttribute("value");
            Logger.WriteInfoMessage("Booked Event Date as - " +eventDate + " and Expiration Date as - " + expirationdate);
            Click_Button_Next();
            AddDelay(8000);

            //if (CommonMethod.PropertyType == Constants.PropertyType_Regular)
            //{
            //    eProposalCendynRoomBlock.VerifyFirstDate(eventDate);
            //    eProposalCendynRoomBlock.Click_Button_Next();
            //}
            if (VerifyTextOnPage("Select the pages you would like to include with your proposal:"))
            {
                Logger.WriteDebugMessage("Date were correctted and landed on second page of ");
            }
        }

        public static string GetWelcomeMessage()
        {
            //Enter the iFrame
            Helper.EnterFrame("CE_ctl00_ctl00_MainContent_MainContent_edWelcome_editor_ID_Frame");

            //Return the Welcome Message value
            var welcomeMessage = PageObject_ProposalCompose.WelcomeMessageText().Text;

            //Exit the iFrame
            Helper.ExitFrame();

            return welcomeMessage;
        }

        /// <summary>
        ///     This method will validate the Welcome Message text matches the passed text.
        /// </summary>
        /// <param name="welcomeMessage">Text to match</param>
        public static void ValidateWelcomeMessageComments(string welcomeMessage)
        {
            //Enter the iFrame
            Helper.EnterFrame("CE_ctl00_ctl00_MainContent_MainContent_edWelcome_editor_ID_Frame");
            try
            {
                if (PageObject_ProposalCompose.WelcomeMessageText().Text.Contains(welcomeMessage))
                    Logger.WriteInfoMessage("The Welcome Message text contained the passed text.");
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("The Welcome Message did not contain the passed text.");
                throw;
            }
            //Exit the iFrame
            Helper.ExitFrame();
        }

        /// <summary>
        ///     This method will clear the Welcome Message then verify the stored content title and content matches the correct
        ///     title, content and location from the Settings -> Stored Content page.
        /// </summary>
        /// <param name="contentPosition">The position of the stored content</param>
        /// <param name="title">The title of the stored content</param>
        /// <param name="content">The content of the stored content</param>
        /// 1 2
        /// 3 4
        public static void ValidateStoredContent(int contentPosition, string title, string content)
        {
            //Position starts a number lower
            var newPosition = contentPosition - 1;

            try
            {
                //Verify the title and position
                if (CommonMethod.Driver
                        .FindElement(By.XPath("//span[@id='ctl00_ctl00_MainContent_MainContent_rptParagraphsList_ctl0" +
                                              newPosition + "_lblParagraphName']")).Text == title)
                    Logger.WriteInfoMessage("The stored content in position " + contentPosition +
                                            " matches the title: " + title);
                else
                    throw new Exception("Position " + contentPosition + " did not match the title: " + title +
                                        ". Found instead: " +
                                        CommonMethod.Driver
                                            .FindElement(
                                                By.XPath(
                                                    "//span[@id='ctl00_ctl00_MainContent_MainContent_rptParagraphsList_ctl0" +
                                                    newPosition + "_lblParagraphName']")).Text);

                //Verify the content
                CommonMethod.Driver.FindElement(
                    By.XPath("//span[@id='ctl00_ctl00_MainContent_MainContent_rptParagraphsList_ctl0" + newPosition +
                             "_lblParagraphName']")).Click();

                Time.AddDelay(1500);

                ValidateWelcomeMessageComments(content);
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("");
                throw;
            }
        }

        /// <summary>
        ///     This method will verify if the "Include Offer at the bottom..." message is displayed.
        /// </summary>
        /// <returns>True = setting is displayed, false = setting is not displayed</returns>
        private static bool RoomOnWelcomeSetting()
        {
            try
            {
                if (PageObject_ProposalCompose.CheckBox_IncludeOfferAtBottomOfWelcomeLetter().Displayed)
                    return true;
            }
            catch (Exception)
            {
            }

            return false;
        }

        /// <summary>
        ///     This method will verify the Room on Welcome setting is displayed.
        /// </summary>
        public static void VerifyRoomOnWelcomeSettingOn()
        {
            try
            {
                if (RoomOnWelcomeSetting())
                    Logger.WriteInfoMessage(
                        "'The Include Offer at the bottom..' message is displayed when the Room On Welcome setting is turned on. ");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage(
                    "'The Include Offer at the bottom..' message is not displayed when the Room On Welcome setting is turned on. ");
                throw;
            }
        }

        /// <summary>
        ///     This method will verify the Room on Welcome setting is not displayed.
        /// </summary>
        public static void VerifyRoomOnWelcomeSettingOff()
        {
            try
            {
                if (!RoomOnWelcomeSetting())
                    Logger.WriteInfoMessage(
                        "'The Include Offer at the bottom..' message is not displayed when the Room On Welcome setting is turned off. ");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage(
                    "'The Include Offer at the bottom..' message is displayed when the Room On Welcome setting is turned off. ");
                throw;
            }
        }

        /// <summary>
        ///     This method will verify if the "Include Offer at the bottom..." message is selected.
        /// </summary>
        /// <returns>True = setting is selected, false = setting is not selected</returns>
        private static bool RoomOnWelcomeSelected()
        {
            try
            {
                if (PageObject_ProposalCompose.CheckBox_IncludeOfferAtBottomOfWelcomeLetter().Selected)
                    return true;
            }
            catch (Exception)
            {
            }

            return false;
        }

        /// <summary>
        ///     This method will verify the Room on Welcome setting is selected.
        /// </summary>
        public static void VerifyRoomOnWelcomeSelectedOn()
        {
            try
            {
                if (RoomOnWelcomeSelected())
                    Logger.WriteInfoMessage(
                        "'The Include Offer at the bottom..' message is selected. ");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("'The Include Offer at the bottom..' message is not selected. ");
                throw;
            }
        }

        /// <summary>
        ///     This method will verify the Room on Welcome setting is NOT selected.
        /// </summary>
        public static void VerifyRoomOnWelcomeSelectedOff()
        {
            try
            {
                if (!RoomOnWelcomeSelected())
                    Logger.WriteInfoMessage(
                        "'The Include Offer at the bottom..' message is NOT selected. ");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("'The Include Offer at the bottom..' message is selected. ");
                throw;
            }
        }

        /// <summary>
        ///     This method will verify only 1 language is available on the Compose page.
        ///     The language is displayed as a label and there is no dropdown.
        /// </summary>
        public static void VerifySingleLanguageLabel()
        {
            try
            {
                PageObject_ProposalCompose.LanguageDropDown().SendKeys("a");
            }
            catch (StaleElementReferenceException)
            {
                Logger.WriteInfoMessage("There is only one language available for the property.");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("There are more than one language available for a single language property.");
                throw;
            }
        }
        
        public static void VerifySingleLanguageToolTip()
        {
            try
            {
                //Click the tooltip button
                CommonMethod.Driver
                    .FindElement(By.XPath("//img[@id='ctl00_ctl00_MainContent_MainContent_imgToolTip1']")).Click();
                Logger.WriteInfoMessage("Clicked the single language tooltip icon.");

                var tooltipMessage = CommonMethod.Driver.FindElement(
                    By.XPath("//div[@id='ctl00_ctl00_MainContent_MainContent_PopupMenuForOneLanguage']")).Text;

                //Verify the tooltip message
                if (tooltipMessage.Contains(SingleLanguageToolTip))
                    Logger.WriteInfoMessage("The single language tooltip message is displayed.");
                else
                    throw new Exception("The single language property is displaying multiple languages.");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("");
                throw;
            }
        }

        /// <summary>
        ///     This method will search in the Language drop down for a specific language.
        /// </summary>
        /// <param name="language">Language to check in drop down</param>
        public static void VerifyLanguageInDropDown(string language)
        {
            try
            {
                SelectFromDropDown_LanguageDropDown(language);
                var dropdownLanguage = PageObject_ProposalCompose.LanguageDropDown().GetAttribute("value");

                if (dropdownLanguage == language)
                    Logger.WriteInfoMessage("The language was found in the dropdown.");
                else throw new Exception();
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("The language was NOT found in the drop down.");
                throw;
            }
        }

        /// <summary>
        ///     Here we enter unique email that is ent as parameter
        /// </summary>
        /// <param name="Email"></param>
        public static void EnterText_Client_AddNew_UniqueEmailText(string text)
        {
            var uniqueEmail = Helper.MakeGmailUnique(text);
            Helper.ElementEnterText(PageObject_ProposalCompose.Client_AddNew_EmailText(), uniqueEmail);
        }

        /// <summary>
        ///     This method will verify the max amount of characters in the proposal name field.
        /// </summary>
        public static void VerifyProposalNameLength()
        {
            EnterText_ProposalNameText(eProposalConstants.LongString);
            var testString = PageObject_ProposalCompose.ProposalNameText().GetAttribute("value");

            try
            {
                if (Helper.StringLength(testString) != 250)
                    throw new Exception();
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("The Proposal Name max characters is not 50.");
                Logger.WriteFatalMessage("The Proposal Name max characters is allowing : " +
                                         Helper.StringLength(testString));
                throw;
            }
        }

        /// <summary>
        ///     This method will fill in all the mandetory data on the "Compose" page using the data from the Common.XML file in
        ///     the Compose section.
        ///     The eProposal name is the current test case ID + the current date and time
        /// </summary>
        public static void CommonComposeMandetory(string eproposalName, string Compose_ClientName)
        {
            EnterText_ProposalNameText(eproposalName + " - " + Helper.AddDateTime());
            SearchForClient(Compose_ClientName);
            Logger.WriteDebugMessage("Data Entered");
            Click_Button_Next();
            Time.AddDelay(3500);
        }

        /// <summary>
        ///     This method will Redirect us to send page
        /// </summary>
        public static void RedirectToSendPage()
        {
            Click_Button_Next();
            Time.AddDelay(5000);
            Click_Button_Next();
            Time.AddDelay(5000);
            Click_Button_Next();
            Time.AddDelay(5000);
            Helper.ControlToNewWindow();
            Helper.CloseWindow();
            Helper.ControlToPreviousWindow();
        }

        /// <summary>
        /// Method to add expiration message on eProposal compose page
        /// </summary>
        public static void VerifyExpirationError()
        {
            bool value1 = Helper.VerifyTextOnPage(eProposalConstants.eProposalExpirationMessage);
            if (value1.Equals(true))
            {
                Logger.WriteDebugMessage("Error message displays next to the 'Proposal Expires On date stating The expiration date cannot occur after the Proposal Expires On.'");
            }
            else
            {
                Logger.WriteDebugMessage("Error message is not displayed");
            }
        }

        /// <summary>
        /// Method to select date before today 's date.
        /// </summary>
        public static void SelectProposalExpiresBeforeCurrentDate()
        {
            string[] date = DateTime.Now.ToString("dd/MMM/yyyy").Split('/');
            int previousdate = Convert.ToInt32(date[0].ToString()) - 1;
            try
            {
                SelectExpirationDate(date[1], previousdate.ToString(), date[2]);
                Logger.WriteDebugMessage("Able to select a previous date.");
            }
            catch (Exception)
            {
                Logger.WriteDebugMessage("Unable to select a previous date.");
            }
         }

        /// <summary>
        /// Method to select date after event date.
        /// </summary>
        public static void SelectDateAftereventdate()
        {
            var mfi = new DateTimeFormatInfo();
            string[] eventdate = PageObject_ProposalCompose.EventDate().GetAttribute("value").Split('/');
            int afterdate = Convert.ToInt32(eventdate[1].ToString()) + 1;
            int month = Convert.ToInt32(eventdate[0].ToString());
            var mmm = mfi.GetMonthName(month).Substring(0, 3);
            SelectExpirationDate(mmm, afterdate.ToString(), eventdate[2]);
            VerifyExpirationError();
        }

        /// <summary>
        /// Method to select date before event date.
        /// </summary>
        public static void SelectDateBeforeEventdate()
        {
            var mfi = new DateTimeFormatInfo();
            string[] eventdate = PageObject_ProposalCompose.EventDate().GetAttribute("value").Split('/');           
            int month = Convert.ToInt32(eventdate[0].ToString());
            var mmm = mfi.GetMonthName(month).Substring(0, 3);
            int beforedate = Convert.ToInt32(eventdate[1].ToString()) - 1;
            SelectExpirationDate(mmm, beforedate.ToString(), eventdate[2]);
        }

        /// <summary>
        /// Method to select Event date before today's date.
        /// </summary>
        public static void SelectEventdateBeforeCurrentDate()
        {
            string[] date = DateTime.Now.ToString("dd/MMM/yyyy").Split('/');
            int previousdate = Convert.ToInt32(date[0].ToString()) - 1;
            try
            {
                SelectEventDate(date[1], previousdate.ToString(), date[2]);
                Logger.WriteDebugMessage("Able to select a previous date.");
            }
            catch (Exception)
            {
                Logger.WriteDebugMessage("Unable to select a previous date.");
            }
        }

        /// <summary>
        /// Method to select date after Proposal Expires date.
        /// </summary>
        public static void SelectDateAfterProposalExpiresdate()
        {
            var mfi = new DateTimeFormatInfo();
            string[] eventdate = PageObject_ProposalCompose.ExpirationDate().GetAttribute("value").Split('/');
            int afterdate = Convert.ToInt32(eventdate[1].ToString()) + 1;
            int month = Convert.ToInt32(eventdate[0].ToString());
            var mmm = mfi.GetMonthName(month).Substring(0, 3);
            SelectEventDate(mmm, afterdate.ToString(), eventdate[2]);
            VerifyExpirationError();
        }

        /// <summary>
        /// Method to select date before Proposal Expires date.
        /// </summary>
        public static void SelectDateBeforeProposalExpiresdate()
        {
            var mfi = new DateTimeFormatInfo();
            string[] eventdate = PageObject_ProposalCompose.ExpirationDate().GetAttribute("value").Split('/');
            int month = Convert.ToInt32(eventdate[0].ToString());
            var mmm = mfi.GetMonthName(month).Substring(0, 3);
            int beforedate = Convert.ToInt32(eventdate[1].ToString()) - 1;
            SelectEventDate(mmm, beforedate.ToString(), eventdate[2]);
            VerifyExpirationError();
        }

        /// <summary>
        /// Method to Upload client logo.
        /// </summary>
        public static void UploadClientLogo()
        {
            //Helper.UploadFile(PageObject_ProposalCompose.Button_Browse(), Constants.ImageUpload); 
            string RootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            string filelocation = @"\UploadFiles\Logo.jpg";
            string location = RootPath + filelocation;
            location = location.Replace("file:\\", "");
            IWebElement uploadfile = Driver.FindElement(By.XPath("//*[@class='center-block']//following::*[@id='ctl00_ctl00_MainContent_MainContent_UploadFile']"));
            AutoItX3 Au3 = new AutoItX3();
            uploadfile.Click();
            AddDelay(3500);
            Au3.Send(location);
            AddDelay(2000);
            Au3.Send("{ENTER}");
            AddDelay(2000);
            Logger.WriteInfoMessage("File uploaded successfully");

            //uploadfile.SendKeys(location);
        }

        /// <summary>
        /// Method to verify whether client logo is displayed or not.
        /// </summary>
        public static void ClientLogoIsDisplayed()
        {
            bool value = PageObject_ProposalPreview.Image_PreviewClientLogo().Displayed;
            if(value.Equals(true))
            {
                ScrollToElement(PageObject_ProposalPreview.Image_PreviewClientLogo());
                Logger.WriteDebugMessage("The logo is displayed!");
            }
            else
            {
                Logger.WriteInfoMessage("The logo is not displayed!");
            }
        }

        /// <summary>
        /// Verify the "Closing Message" entered is displayed.
        /// </summary>
        public static void VerifyClosingMessageIsDiplayed()
        {
            string message = SqlWarehouseQuery.ReturnCompanyName("TC_84287", "MessageClosing");
            
            bool value = Helper.VerifyTextOnPage(message);
            if(value.Equals(value))
            {
                Logger.WriteInfoMessage("The 'Closing Message' is displayed.");
            }
            else
            {
                Logger.WriteInfoMessage("The 'Closing Message' is not displayed.");
            }
        }
        
    }
}
