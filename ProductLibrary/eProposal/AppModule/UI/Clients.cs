using System;
using Common;
using BaseUtility.Utility;
using eProposal.PageObject.UI;
using OpenQA.Selenium;
using eProposal.Utility;
using InfoMessageLogger;
using eProposalConstants = eProposal.Utility.Constants;

namespace eProposal.AppModule.UI
{
    internal class Clients : Helper
    {
        private static readonly string ClientExists =
                "A client with the same email address already exists. Try SEARCH/EDIT tab for the existing client by email."
            ;

        public static void Click_AddNewClient_ShowHideAddressLink()
        {
            Helper.ElementClick(PageObject_Clients.AddNewClient_ShowHideAddressLink());
        }

        private static void Click_AddNewClient_AddClientButton()
        {
            Helper.ElementClick(PageObject_Clients.AddNewClient_AddClientButton());
        }

        public static void Click_AddNewClientTab()
        {
            Helper.ElementClick(PageObject_Clients.AddNewClientTab());
        }

        public static void Click_SearchEditTab()
        {
            Helper.ElementClick(PageObject_Clients.SearchEditTab());
        }

        public static void Click_SearchEdit_LastNameRadioButton()
        {
            Helper.ElementClick(PageObject_Clients.SearchEdit_LastNameRadioButton());
        }

        public static void Click_SearchEdit_EmailRadioButton()
        {
            Helper.ElementClick(PageObject_Clients.SearchEdit_EmailRadioButton());
        }

        public static void Click_SearchEdit_CompanyRadioButton()
        {
            Helper.ElementClick(PageObject_Clients.SearchEdit_CompanyRadioButton());
        }

        public static void Click_SearchEdit_SearchButton()
        {
            Helper.ElementClick(PageObject_Clients.SearchEdit_SearchButton());
        }

        public static void Click_SearchEdit_EditFirstLink()
        {
            Helper.ElementClick(PageObject_Clients.SearchEdit_EditFirstLink());
        }

        public static void Click_SearchEdit_ExpandFirstButton()
        {
            Helper.ElementClick(PageObject_Clients.SearchEdit_ExpandFirstButton());
        }

        public static void Click_SearchEdit_FirstResultLink()
        {
            Helper.ElementClick(PageObject_Clients.SearchEdit_FirstResultLink());
        }

        public static void Click_SearchEdit_Edit_ShowHideAddressLink()
        {
            Helper.ElementClick(PageObject_Clients.SearchEdit_Edit_ShowHideAddressLink());
        }

        public static void Click_SearchEdit_Edit_SaveButton()
        {
            //Helper.ElementClick(PageObject_Clients.SearchEdit_Edit_SaveButton());
            ElementClickUsingJavascript(PageObject_Clients.SearchEdit_Edit_SaveButton());
        }

        public static void Click_SearchEdit_Edit_CancelButton()
        {
            Helper.ElementClick(PageObject_Clients.SearchEdit_Edit_CancelButton());
        }

        public static void EnterText_AddNewClient_FirstNameText(string text)
        {
            Helper.ElementEnterText(PageObject_Clients.AddNewClient_FirstNameText(), text);
        }

        public static void EnterText_AddNewClient_LastNameText(string text)
        {
            Helper.ElementEnterText(PageObject_Clients.AddNewClient_LastNameText(), text);
        }

        public static void EnterText_AddNewClient_CompanyText(string text)
        {
            Helper.ElementEnterText(PageObject_Clients.AddNewClient_CompanyText(), text);
        }

        public static void EnterText_AddNewClient_EmailText(string text)
        {
            Helper.ElementEnterText(PageObject_Clients.AddNewClient_EmailText(), text);
        }

        public static void EnterText_AddNewClient_PhoneText(string text)
        {
            Helper.ElementEnterText(PageObject_Clients.AddNewClient_PhoneText(), text);
        }

        public static void EnterText_AddNewClient_AddressText(string text)
        {
            Helper.ElementEnterText(PageObject_Clients.AddNewClient_AddressText(), text);
        }

        public static void EnterText_AddNewClient_CityText(string text)
        {
            Helper.ElementEnterText(PageObject_Clients.AddNewClient_CityText(), text);
        }

        public static void EnterText_AddNewClient_StateText(string text)
        {
            Helper.ElementEnterText(PageObject_Clients.AddNewClient_StateText(), text);
        }

        public static void EnterText_AddNewClient_ZipText(string text)
        {
            Helper.ElementEnterText(PageObject_Clients.AddNewClient_ZipText(), text);
        }

        public static void EnterText_SearchEdit_SearchText(string text)
        {
            Helper.ElementEnterText(PageObject_Clients.SearchEdit_SearchText(), text);
        }

        public static void EnterText_SearchEdit_Edit_FirstNameText(string text)
        {
            Helper.ElementEnterText(PageObject_Clients.SearchEdit_Edit_FirstNameText(), text);
        }

        public static void EnterText_SearchEdit_Edit_LastNameText(string text)
        {
            Helper.ElementEnterText(PageObject_Clients.SearchEdit_Edit_LastNameText(), text);
        }

        public static void EnterText_SearchEdit_Edit_CompanyText(string text)
        {
            Helper.ElementEnterText(PageObject_Clients.SearchEdit_Edit_CompanyText(), text);
        }

        public static void EnterText_SearchEdit_Edit_EmailText(string text)
        {
            Helper.ElementEnterText(PageObject_Clients.SearchEdit_Edit_EmailText(), text);
        }

        public static void EnterText_SearchEdit_Edit_PhoneText(string text)
        {
            Helper.ElementEnterText(PageObject_Clients.SearchEdit_Edit_PhoneText(), text);
        }

        public static void EnterText_SearchEdit_Edit_AddressText(string text)
        {
            Helper.ElementEnterText(PageObject_Clients.SearchEdit_Edit_AddressText(), text);
        }

        public static void EnterText_SearchEdit_Edit_CityText(string text)
        {
            Helper.ElementEnterText(PageObject_Clients.SearchEdit_Edit_CityText(), text);
        }

        public static void EnterText_SearchEdit_Edit_StateText(string text)
        {
            Helper.ElementEnterText(PageObject_Clients.SearchEdit_Edit_StateText(), text);
        }

        public static void EnterText_SearchEdit_Edit_ZipText(string text)
        {
            Helper.ElementEnterText(PageObject_Clients.SearchEdit_Edit_ZipText(), text);
        }

        public static void SelectFromDropDown_AddNewClient_CountryDropDown(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_Clients.AddNewClient_CountryDropDown(), text);
        }

        public static void SelectFromDropDown_SearchEdit_Edit_CountryDropDown(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_Clients.SearchEdit_Edit_CountryDropDown(), text);
        }

        /// <summary>
        ///     This method will verify the searched client is displayed in the results.
        /// </summary>
        /// <param name="firstName">First name of client</param>
        /// <param name="lastName">Last name of client</param>
        /// <param name="email">email of client</param>
        private static void VerifySearchResult(string firstName, string lastName, string email)
        {
            var fullName = lastName + ", " + firstName;

            try
            {
                if (Helper.VerifyTextOnPage(fullName))
                    Logger.WriteInfoMessage("The client full name is displayed in the search result.");
                else
                    throw new Exception("The client name did not display in the search results.");

                Click_SearchEdit_ExpandFirstButton();

                if (Helper.VerifyTextOnPage(email))
                    Logger.WriteInfoMessage("The client email is displayed in the search resut");
                else
                    throw new Exception("The client email did not display in the search result.");
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage(e);
                throw;
            }
        }

        /// <summary>
        ///     This method will validate searching for a client by their last name and verify the results
        /// </summary>
        /// <param name="firstName">First name of client</param>
        /// <param name="lastName">Last name of client</param>
        /// <param name="email">email of client</param>
        public static void ValidateClientSearchByLastName(string firstName, string lastName, string email)
        {
            Click_SearchEdit_LastNameRadioButton();
            EnterText_SearchEdit_SearchText(lastName);
            Click_SearchEdit_SearchButton();
            Helper.AddDelay(7000);

            VerifySearchResult(firstName, lastName, email);
            Logger.WriteInfoMessage("Successfully searched for the client by their Last Name.");
        }

        /// <summary>
        ///     This method will validate searching for a client by their email and verify the results
        /// </summary>
        /// <param name="firstName">First name of client</param>
        /// <param name="lastName">Last name of client</param>
        /// <param name="email">email of client</param>
        public static void ValidateClientSearchByEmail(string firstName, string lastName, string email)
        {
            Click_SearchEdit_EmailRadioButton();
            EnterText_SearchEdit_SearchText(email);
            Click_SearchEdit_SearchButton();
            Helper.AddDelay(7000);

            VerifySearchResult(firstName, lastName, email);
            Logger.WriteInfoMessage("Successfully searched for the client by their email.");
        }

        /// <summary>
        ///     This method will validate searching for a client by their company name and verify the results
        /// </summary>
        /// <param name="firstName">First name of client</param>
        /// <param name="lastName">Last name of client</param>
        /// <param name="email">email of client</param>
        /// <param name="company">company of client</param>
        public static void ValidateClientSearchByCompany(string firstName, string lastName, string email,
            string company)
        {
            Click_SearchEdit_CompanyRadioButton();
            EnterText_SearchEdit_SearchText(company);
            Click_SearchEdit_SearchButton();
            Helper.AddDelay(7000);

            VerifySearchResult(firstName, lastName, email);
            Logger.WriteInfoMessage("Successfully searched for the client by their email.");
        }

        /// <summary>
        ///     This method will click the "Address" link and verify the optional fields are displayed on the Edit Client popup.
        /// </summary>
        public static void EditClient_ExpandAddNewClientAddressFields()
        {
            try
            {
                //Click "Address" link
                Click_SearchEdit_Edit_ShowHideAddressLink();

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
        public static void EditClient_CollapseExpandAddNewClientAddressFields()
        {
            try
            {
                //Click "Address" link
                Click_SearchEdit_Edit_ShowHideAddressLink();

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
        ///     This method will enter data into all the Edit Client fields.
        /// </summary>
        public static void EditClient_EnterAllValidFields(string firstName, string lastName, string company,
            string phoneNumber,
            string address, string city, string state, string zip, string country)
        {
            EnterText_SearchEdit_Edit_FirstNameText(firstName);
            EnterText_SearchEdit_Edit_LastNameText(lastName);
            EnterText_SearchEdit_Edit_CompanyText(company);
            EnterText_SearchEdit_Edit_PhoneText(phoneNumber);

            if (!PageObject_Clients.SearchEdit_Edit_AddressText().Displayed)
                EditClient_ExpandAddNewClientAddressFields();

            EnterText_SearchEdit_Edit_AddressText(address);
            EnterText_SearchEdit_Edit_CityText(city);
            EnterText_SearchEdit_Edit_StateText(state);
            EnterText_SearchEdit_Edit_ZipText(zip);
            SelectFromDropDown_SearchEdit_Edit_CountryDropDown(country);
        }

        /// <summary>
        ///     This method will verify the correct client information is displayed on the Edit Client popup.
        /// </summary>
        public static void EditClient_VerifyClientData(string firstName, string lastName, string company, string email,
            string phone,
            string address, string city, string state, string zip, string country)
        {
            EditClient_VerifyFirstName(firstName);
            EditClient_VerifyLastName(lastName);
            EditClient_VerifyCompany(company);
            EditClient_VerifyEmail(email);
            EditClient_VerifyPhone(phone);
            EditClient_VerifyAddress(address);
            EditClient_VerifyState(state);
            EditClient_VerifyCity(city);
            EditClient_VerifyZip(zip);
            EditClient_VerifyCompany(company);
        }

        /// <summary>
        ///     This method will verify the First Name displayed matches the data that was used
        /// </summary>
        /// <param name="firstName">First Name to test if it matches the displayed First Name</param>
        private static void EditClient_VerifyFirstName(string firstName)
        {
            try
            {
                if (PageObject_Clients.SearchEdit_Edit_FirstNameText().Text == firstName)
                    Logger.WriteInfoMessage("The First Name " + firstName + " was found in the First Name text box.");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("The client First Name displayed did not match the First Name text box.");
                Logger.WriteFatalMessage("Was looking for: " + firstName);
                Logger.WriteFatalMessage("But found: " + PageObject_Clients.SearchEdit_Edit_FirstNameText().Text);
                throw;
            }
        }

        /// <summary>
        ///     This method will verify the Last Name displayed matches the data that was used
        /// </summary>
        /// <param name="lastName">Last Name to test if it matches the displayed Last Name</param>
        private static void EditClient_VerifyLastName(string lastName)
        {
            try
            {
                if (PageObject_Clients.SearchEdit_Edit_LastNameText().Text == lastName)
                    Logger.WriteInfoMessage("The Last Name " + lastName + " was found in the Last Name text box.");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("The client Last Name displayed did not match the Last Name text box.");
                Logger.WriteFatalMessage("Was looking for: " + lastName);
                Logger.WriteFatalMessage("But found: " + PageObject_Clients.SearchEdit_Edit_LastNameText().Text);
                throw;
            }
        }

        /// <summary>
        ///     This method will verify the company displayed matches the data that was used
        /// </summary>
        /// <param name="company">company to test if it matches the displayed company</param>
        private static void EditClient_VerifyCompany(string company)
        {
            try
            {
                if (PageObject_Clients.SearchEdit_Edit_CompanyText().Text == company)
                    Logger.WriteInfoMessage("The company " + company + " was found in the company text box.");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("The client company displayed did not match the company text box.");
                Logger.WriteFatalMessage("Was looking for: " + company);
                Logger.WriteFatalMessage("But found: " + PageObject_Clients.SearchEdit_Edit_CompanyText().Text);
                throw;
            }
        }

        /// <summary>
        ///     This method will verify the Email displayed matches the data that was used
        /// </summary>
        /// <param name="Email">Email to test if it matches the displayed Email</param>
        private static void EditClient_VerifyEmail(string Email)
        {
            try
            {
                if (PageObject_Clients.SearchEdit_Edit_EmailText().Text == Email)
                    Logger.WriteInfoMessage("The Email " + Email + " was found in the Email text box.");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("The client Email displayed did not match the Email text box.");
                Logger.WriteFatalMessage("Was looking for: " + Email);
                Logger.WriteFatalMessage("But found: " + PageObject_Clients.SearchEdit_Edit_EmailText().Text);
                throw;
            }
        }

        /// <summary>
        ///     This method will verify the Phone displayed matches the data that was used
        /// </summary>
        /// <param name="Phone">Phone to test if it matches the displayed Phone</param>
        private static void EditClient_VerifyPhone(string Phone)
        {
            try
            {
                if (PageObject_Clients.SearchEdit_Edit_PhoneText().Text == Phone)
                    Logger.WriteInfoMessage("The Phone " + Phone + " was found in the Phone text box.");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("The client Phone displayed did not match the Phone text box.");
                Logger.WriteFatalMessage("Was looking for: " + Phone);
                Logger.WriteFatalMessage("But found: " + PageObject_Clients.SearchEdit_Edit_PhoneText().Text);
                throw;
            }
        }

        /// <summary>
        ///     This method will verify the Address displayed matches the data that was used
        /// </summary>
        /// <param name="Address">Address to test if it matches the displayed Address</param>
        private static void EditClient_VerifyAddress(string Address)
        {
            try
            {
                if (PageObject_Clients.SearchEdit_Edit_AddressText().Text == Address)
                    Logger.WriteInfoMessage("The Address " + Address + " was found in the Address text box.");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("The client Address displayed did not match the Address text box.");
                Logger.WriteFatalMessage("Was looking for: " + Address);
                Logger.WriteFatalMessage("But found: " + PageObject_Clients.SearchEdit_Edit_AddressText().Text);
                throw;
            }
        }

        /// <summary>
        ///     This method will verify the City displayed matches the data that was used
        /// </summary>
        /// <param name="City">City to test if it matches the displayed City</param>
        private static void EditClient_VerifyCity(string City)
        {
            try
            {
                if (PageObject_Clients.SearchEdit_Edit_CityText().Text == City)
                    Logger.WriteInfoMessage("The City " + City + " was found in the City text box.");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("The client City displayed did not match the City text box.");
                Logger.WriteFatalMessage("Was looking for: " + City);
                Logger.WriteFatalMessage("But found: " + PageObject_Clients.SearchEdit_Edit_CityText().Text);
                throw;
            }
        }

        /// <summary>
        ///     This method will verify the State displayed matches the data that was used
        /// </summary>
        /// <param name="State">State to test if it matches the displayed State</param>
        private static void EditClient_VerifyState(string State)
        {
            try
            {
                if (PageObject_Clients.SearchEdit_Edit_StateText().Text == State)
                    Logger.WriteInfoMessage("The State " + State + " was found in the State text box.");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("The client State displayed did not match the State text box.");
                Logger.WriteFatalMessage("Was looking for: " + State);
                Logger.WriteFatalMessage("But found: " + PageObject_Clients.SearchEdit_Edit_StateText().Text);
                throw;
            }
        }

        /// <summary>
        ///     This method will verify the Zip displayed matches the data that was used
        /// </summary>
        /// <param name="Zip">Zip to test if it matches the displayed Zip</param>
        private static void EditClient_VerifyZip(string Zip)
        {
            try
            {
                if (PageObject_Clients.SearchEdit_Edit_ZipText().Text == Zip)
                    Logger.WriteInfoMessage("The Zip " + Zip + " was found in the Zip text box.");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("The client Zip displayed did not match the Zip text box.");
                Logger.WriteFatalMessage("Was looking for: " + Zip);
                Logger.WriteFatalMessage("But found: " + PageObject_Clients.SearchEdit_Edit_ZipText().Text);
                throw;
            }
        }


        /// <summary>
        ///     This method will validate the first name only accepts 100 characters.
        /// </summary>
        public static void VerifyFirstNameLength()
        {
            EnterText_AddNewClient_FirstNameText(eProposalConstants.LongString);
            var testString = PageObject_Clients.AddNewClient_FirstNameText().GetAttribute("value");

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
            EnterText_AddNewClient_LastNameText(eProposalConstants.LongString);
            var testString = PageObject_Clients.AddNewClient_LastNameText().GetAttribute("value");

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
            EnterText_AddNewClient_CompanyText(eProposalConstants.LongString);
            var testString = PageObject_Clients.AddNewClient_CompanyText().GetAttribute("value");

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
            EnterText_AddNewClient_EmailText(eProposalConstants.LongString);
            var testString = PageObject_Clients.AddNewClient_EmailText().GetAttribute("value");

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
            EnterText_AddNewClient_PhoneText(eProposalConstants.LongString);
            var testString = PageObject_Clients.AddNewClient_PhoneText().GetAttribute("value");

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
            EnterText_AddNewClient_AddressText(eProposalConstants.LongString);
            var testString = PageObject_Clients.AddNewClient_AddressText().GetAttribute("value");

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
            EnterText_AddNewClient_CityText(eProposalConstants.LongString);
            var testString = PageObject_Clients.AddNewClient_CityText().GetAttribute("value");

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
            EnterText_AddNewClient_StateText(eProposalConstants.LongString);
            var testString = PageObject_Clients.AddNewClient_StateText().GetAttribute("value");

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
            EnterText_AddNewClient_ZipText(eProposalConstants.LongString);
            var testString = PageObject_Clients.AddNewClient_ZipText().GetAttribute("value");

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
                PageObject_Clients.AddNewClient_FirstNameText().Clear();
                PageObject_Clients.AddNewClient_LastNameText().Clear();
                PageObject_Clients.AddNewClient_CompanyText().Clear();
                PageObject_Clients.AddNewClient_EmailText().Clear();
                PageObject_Clients.AddNewClient_PhoneText().Clear();
                PageObject_Clients.AddNewClient_AddressText().Clear();
                PageObject_Clients.AddNewClient_CityText().Clear();
                PageObject_Clients.AddNewClient_StateText().Clear();
                PageObject_Clients.AddNewClient_ZipText().Clear();
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
        public static void AddNewClient_ExpandAddNewClientAddressFields()
        {
            try
            {
                //Click "Address" link
                Click_AddNewClient_ShowHideAddressLink();

                if (PageObject_Clients.AddNewClient_AddressText().Displayed)
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
        public static void AddNewClient_CollapseAddNewClientAddressFields()
        {
            try
            {
                //Click "Address" link
                Click_AddNewClient_ShowHideAddressLink();

                if (!PageObject_Clients.AddNewClient_AddressText().Displayed)
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
            Helper.AddDelay(7000);
            EnterText_AddNewClient_FirstNameText(firstName);
            EnterText_AddNewClient_LastNameText(lastName);
            EnterText_AddNewClient_CompanyText(company);
            EnterText_AddNewClient_EmailText(email);
            EnterText_AddNewClient_PhoneText(phoneNumber);

            Helper.AddDelay(7000);
            if (!PageObject_Clients.AddNewClient_AddressText().Displayed)
                EditClient_ExpandAddNewClientAddressFields();

            EnterText_AddNewClient_AddressText(address);
            EnterText_AddNewClient_CityText(city);
            EnterText_AddNewClient_StateText(state);
            EnterText_AddNewClient_ZipText(zip);
            SelectFromDropDown_AddNewClient_CountryDropDown(country);
        }

        /// <summary>
        ///     This method will click the "Add Client" button and verify the confirmation message.
        /// </summary>
        public static void VerifySuccessfulAddClient()
        {
            var firstName = PageObject_Clients.AddNewClient_FirstNameText().GetAttribute("value");
            var lastName = PageObject_Clients.AddNewClient_LastNameText().GetAttribute("value");
            var confirmationMessage = "Your client" + firstName + " " + lastName + " has been added.";

            try
            {
                //Click the Add Client button
                Click_AddNewClient_AddClientButton();

                //Verify the "Your client X X has been added." message
                if (confirmationMessage == CommonMethod.Driver
                        .FindElement(By.Id("ctl00_ctl00_MainContent_MainContent_lbMessage")).Text)
                    Logger.WriteInfoMessage("The add client confirmation message was displayed correctly: " +
                                            confirmationMessage);
                else
                    throw new Exception("The client was not added successfully.");
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage("Was looking for message: " + confirmationMessage);
                Logger.WriteFatalMessage("But found : " + CommonMethod.Driver
                                             .FindElement(By.Id("ctl00_ctl00_MainContent_MainContent_lbMessage")).Text);
                Logger.WriteFatalMessage(e);
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
                Click_AddNewClient_AddClientButton();
                Time.AddDelay(5000);
                if (ClientExists == CommonMethod.Driver
                        .FindElement(By.Id("ctl00_ctl00_MainContent_MainContent_lbMessage")).Text)
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
    }
}