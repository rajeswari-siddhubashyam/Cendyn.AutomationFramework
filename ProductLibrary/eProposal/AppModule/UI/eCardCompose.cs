using System;
using Common;
using BaseUtility.Utility;
using eProposal.PageObject.UI;
using OpenQA.Selenium;
using eProposal.Utility;
using eProposalConstants = eProposal.Utility.Constants;
using InfoMessageLogger;

namespace eProposal.AppModule.UI
{
    internal class eCardCompose
    {
        private static readonly string ClientExists = "A client with the same email address already exists.";

        public static void Click_Button_Send()
        {
            Helper.ElementClick(PageObject_eCardCompose.Button_Send());
        }

        // 08/04 Marc : Commenting this out due to failing cases not finding this on DEMO site.
        public static void Click_Button_YesProceed()
        {
            
            Helper.ElementClick(PageObject_eCardCompose.Button_YesProceed());
        }

        public static void Click_RadioButton_eCardType_Ackowledgement()
        {
            Helper.ElementClick(PageObject_eCardCompose.RadioButton_eCardType_Ackowledgement());
        }

        public static void Click_RadioButton_eCardType_TurnDown()
        {
            Helper.ElementClick(PageObject_eCardCompose.RadioButton_eCardType_TurnDown());
        }

        public static void Click_Client_SearchLink()
        {
            Helper.ElementClick(PageObject_eCardCompose.Click_Client_SearchLink());
        }

        public static void Click_Client_AddNewLink()
        {
            Helper.ElementClick(PageObject_eCardCompose.Click_Client_AddNewLink());
        }

        public static void Click_Client_Search_SearchButton()
        {
            Helper.ElementClick(PageObject_eCardCompose.Click_Client_Search_SearchButton());
        }

        public static void Click_Client_Search_FirstResultLink()
        {
            Helper.ElementClick(PageObject_eCardCompose.Click_Client_Search_FirstResultLink());
        }

        public static void Click_Link_Client_AddNew_HideShowAddress()
        {
            Helper.ElementClick(PageObject_eCardCompose.Link_Client_AddNew_HideShowAddress());
        }

        public static void Click_Button_Client_AddNew_Save()
        {
            Helper.ElementClick(PageObject_eCardCompose.Button_Client_AddNew_Save());
        }

        public static void Click_Button_Client_AddNew_Cancel()
        {
            Helper.ElementClick(PageObject_eCardCompose.Button_Client_AddNew_Cancel());
        }

        public static void Click_Link_StoredContent1()
        {
            Helper.ElementClick(PageObject_eCardCompose.Link_StoredContent1());
        }

        public static void Click_Link_StoredContent2()
        {
            Helper.ElementClick(PageObject_eCardCompose.Link_StoredContent2());
        }

        public static void Click_Link_StoredContent3()
        {
            Helper.ElementClick(PageObject_eCardCompose.Link_StoredContent3());
        }

        public static void Click_Link_StoredContent4()
        {
            Helper.ElementClick(PageObject_eCardCompose.Link_StoredContent4());
        }

        public static void Click_Button_Next()
        {
            Helper.ElementClick(PageObject_eCardCompose.Button_Next());
        }

        public static void EnterText_eCardCompose_Text_Client_Search_Search(string text)
        {
            Helper.ElementEnterText(PageObject_eCardCompose.Click_Client_Search_Search(), text);
        }

        public static void EnterText_TextBox_Client_AddNew_FirstName(string text)
        {
            Helper.ElementEnterText(PageObject_eCardCompose.TextBox_Client_AddNew_FirstName(), text);
        }

        public static void EnterText_TextBox_Client_AddNew_LastName(string text)
        {
            Helper.ElementEnterText(PageObject_eCardCompose.TextBox_Client_AddNew_LastName(), text);
        }

        public static void EnterText_TextBox_Client_AddNew_Company(string text)
        {
            Helper.ElementEnterText(PageObject_eCardCompose.TextBox_Client_AddNew_Company(), text);
        }

        public static void EnterText_TextBox_Client_AddNew_EmailAddress(string Email)
        {
            var UniqueEmail = Helper.MakeGmailUnique(Email);
            Helper.ElementEnterText(PageObject_eCardCompose.TextBox_Client_AddNew_EmailAddress(), UniqueEmail);
        }

        public static void EnterText_TextBox_Client_AddNew_UniqueEmailAddress(string Email)
        {
            var UniqueEmail = Helper.MakeGmailUnique(Email);
            Helper.ElementEnterText(PageObject_eCardCompose.TextBox_Client_AddNew_EmailAddress(), UniqueEmail);
        }

        public static void EnterText_TextBox_Client_AddNew_PhoneNumber(string text)
        {
            Helper.ElementEnterText(PageObject_eCardCompose.TextBox_Client_AddNew_PhoneNumber(), text);
        }

        public static void EnterText_TextBox_Client_AddNew_Address(string text)
        {
            Helper.ElementEnterText(PageObject_eCardCompose.TextBox_Client_AddNew_Address(), text);
        }

        public static void EnterText_TextBox_Client_AddNew_City(string text)
        {
            Helper.ElementEnterText(PageObject_eCardCompose.TextBox_Client_AddNew_City(), text);
        }

        public static void EnterText_TextBox_Client_AddNew_State(string text)
        {
            Helper.ElementEnterText(PageObject_eCardCompose.TextBox_Client_AddNew_State(), text);
        }

        public static void EnterText_TextBox_Client_AddNew_Zip(string text)
        {
            Helper.ElementEnterText(PageObject_eCardCompose.TextBox_Client_AddNew_Zip(), text);
        }

        public static void EnterText_TextBox_CC(string text)
        {
            Helper.ElementEnterText(PageObject_eCardCompose.TextBox_CC(), text);
        }

        public static void EnterText_TextBox_BCC(string text)
        {
            Helper.ElementEnterText(PageObject_eCardCompose.TextBox_BCC(), text);
        }

        public static void EnterText_TextBox_EmailSubject(string text)
        {
            Helper.ElementEnterText(PageObject_eCardCompose.TextBox_EmailSubject(), text);
        }

        public static void EnterText_TextBox_Message(string text)
        {
            Helper.ElementEnterText(PageObject_eCardCompose.TextBox_Message(), text);
        }

        public static void EnterText_TextBox_MessageClosing(string text)
        {
            Helper.ElementEnterText(PageObject_eCardCompose.TextBox_MessageClosing(), text);
        }

        public static void SelectFromDropDown_DropDown_SelectCard(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_eCardCompose.DropDown_SelectCard(), text);
        }

        public static void SelectFromDropDown_DropDown_From(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_eCardCompose.DropDown_From(), text);
        }

        public static void SelectFromDropDown_DropDown_Client_AddNew_Country(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_eCardCompose.DropDown_Client_AddNew_Country(), text);
        }

        /// <summary>
        ///     This method will validate the first name only accepts 100 characters.
        /// </summary>
        public static void VerifyFirstNameLength()
        {
            EnterText_TextBox_Client_AddNew_FirstName(eProposalConstants.LongString);
            var testString = PageObject_eCardCompose.TextBox_Client_AddNew_FirstName().GetAttribute("value");

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
            EnterText_TextBox_Client_AddNew_LastName(eProposalConstants.LongString);
            var testString = PageObject_eCardCompose.TextBox_Client_AddNew_LastName().GetAttribute("value");

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
            EnterText_TextBox_Client_AddNew_Company(eProposalConstants.LongString);
            var testString = PageObject_eCardCompose.TextBox_Client_AddNew_Company().GetAttribute("value");

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
            EnterText_TextBox_Client_AddNew_EmailAddress(eProposalConstants.LongString);
            var testString = PageObject_eCardCompose.TextBox_Client_AddNew_EmailAddress().GetAttribute("value");

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
            EnterText_TextBox_Client_AddNew_PhoneNumber(eProposalConstants.LongString);
            var testString = PageObject_eCardCompose.TextBox_Client_AddNew_PhoneNumber().GetAttribute("value");

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
            EnterText_TextBox_Client_AddNew_Address(eProposalConstants.LongString);
            var testString = PageObject_eCardCompose.TextBox_Client_AddNew_Address().GetAttribute("value");

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
            EnterText_TextBox_Client_AddNew_City(eProposalConstants.LongString);
            var testString = PageObject_eCardCompose.TextBox_Client_AddNew_City().GetAttribute("value");

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
            EnterText_TextBox_Client_AddNew_State(eProposalConstants.LongString);
            var testString = PageObject_eCardCompose.TextBox_Client_AddNew_State().GetAttribute("value");

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
            EnterText_TextBox_Client_AddNew_Zip(eProposalConstants.LongString);
            var testString = PageObject_eCardCompose.TextBox_Client_AddNew_Zip().GetAttribute("value");

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
                PageObject_eCardCompose.TextBox_Client_AddNew_FirstName().Clear();
                PageObject_eCardCompose.TextBox_Client_AddNew_LastName().Clear();
                PageObject_eCardCompose.TextBox_Client_AddNew_Company().Clear();
                PageObject_eCardCompose.TextBox_Client_AddNew_EmailAddress().Clear();
                PageObject_eCardCompose.TextBox_Client_AddNew_PhoneNumber().Clear();
                PageObject_eCardCompose.TextBox_Client_AddNew_Address().Clear();
                PageObject_eCardCompose.TextBox_Client_AddNew_City().Clear();
                PageObject_eCardCompose.TextBox_Client_AddNew_State().Clear();
                PageObject_eCardCompose.TextBox_Client_AddNew_Zip().Clear();
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
                Click_Link_Client_AddNew_HideShowAddress();

                if (PageObject_eCardCompose.TextBox_Client_AddNew_Address().Displayed)
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
                Click_Link_Client_AddNew_HideShowAddress();

                if (!PageObject_eCardCompose.TextBox_Client_AddNew_Address().Displayed)
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
            EnterText_TextBox_Client_AddNew_FirstName(firstName);
            EnterText_TextBox_Client_AddNew_LastName(lastName);
            EnterText_TextBox_Client_AddNew_Company(company);
            EnterText_TextBox_Client_AddNew_EmailAddress(email);
            EnterText_TextBox_Client_AddNew_PhoneNumber(phoneNumber);

            if (!PageObject_eCardCompose.TextBox_Client_AddNew_Address().Displayed)
                ExpandAddNewClientAddressFields();

            EnterText_TextBox_Client_AddNew_Address(address);
            EnterText_TextBox_Client_AddNew_City(city);
            EnterText_TextBox_Client_AddNew_State(state);
            EnterText_TextBox_Client_AddNew_Zip(zip);
            SelectFromDropDown_DropDown_Client_AddNew_Country(country);
        }

        /// <summary>
        ///     This method will search for the client in the search and click the first result.
        /// </summary>
        /// <param name="client"></param>
        public static void SearchAndClickClient(string client)
        {
            EnterText_eCardCompose_Text_Client_Search_Search(client);
            Time.AddDelay(1500);
            Click_Client_Search_SearchButton();
            Time.AddDelay(1500);
            VerifyClientSearchResult(client);
            Click_Client_Search_FirstResultLink();
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
        ///     This method will verify the "Client already exists..." message is displayed when trying to add a client with an
        ///     existing email.
        /// </summary>
        public static void VerifyClientAlreadyExists()
        {
            try
            {
                Click_Button_Client_AddNew_Save();
                Time.AddDelay(5000);
                if (ClientExists == CommonMethod.Driver.FindElement(By.XPath("//p[@class='warning']")).Text)
                    Logger.WriteDebugMessage("The Client Already Exists... message was displayed properly.");
                else
                    throw new Exception(
                        "The Client Already Exists... message was not displayed when adding an existing client to an eCard.");
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage(e);
                throw;
            }
        }

        /// <summary>
        ///     Method to add Client with Mandatory fields only.
        /// </summary>
        public static void AddNewClient_MandatoryField(string firstName, string lastName, string company, string email)
        {
            eProposalCompose.Click_Client_AddNewLink();
            EnterText_TextBox_Client_AddNew_FirstName(firstName);
            EnterText_TextBox_Client_AddNew_LastName(lastName);
            EnterText_TextBox_Client_AddNew_Company(company);
            EnterText_TextBox_Client_AddNew_EmailAddress(email);
            if (PageObject_eCardCompose.Button_YesProceed().Displayed)
            {
                Click_Button_YesProceed();
                Click_Button_Client_AddNew_Save();
            }
            else
            {
                Click_Button_Client_AddNew_Save();
            }
        }


        /// <summary>
        ///     Check Employee Name CendynQA is in Bold
        /// </summary>
        public static void CheckEmployeeNameCendynQABold()
        {
            Time.AddDelay(3000);
            Helper.EnterFrame("ctl00_ctl00_MainContent_MainContent_ifmContent");
            var ActualFontWeight = PageObject_eCardCompose.Button_EmployeeNameCendynQA().GetCssValue("font-weight");
            Helper.ExitFrame();
            var ExpextedFontWeight = "bold";
            if (ActualFontWeight == ExpextedFontWeight)
                Logger.WriteDebugMessage("Text is in Bold");
            else
                Logger.WriteDebugMessage("Text is not in Bold");
            Time.AddDelay(3000);
        }

        /// <summary>
        ///     Method to redirect back to Compose page.
        /// </summary>
        public static void RedirectSendPage()
        {
            Click_Button_Next();
            Time.AddDelay(5000);
            Click_Button_Next();
            Time.AddDelay(5000);
            Click_Button_Next();
            Time.AddDelay(5000);
        }
    }
}