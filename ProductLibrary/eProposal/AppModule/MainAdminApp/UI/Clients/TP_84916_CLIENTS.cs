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
using eProposal.AppModule.Admin;
using eProposal.PageObject.UI;
using System.Text.RegularExpressions;

namespace eProposal.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        #region[TP_84916]

        #region[TC_120548]

        public static void TC_120548()
        {
            //1 Log into eProposal
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select a property.
            string Property = "Cendyn – DEV - BBQ HIlton";
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);

            //3 Click the "Clients" nav..
            EmployeeHome.Click_ClientsButton();

            //4 Add a new Client

            //5 Try to enter more than 100 characters into the First Name field.
            Clients.VerifyFirstNameLength();
            Logger.WriteDebugMessage("Unable to enter more than 100 characters.");

            //6 Try to enter more than 100 characters into the Last Name field.
            Clients.VerifyLastNameLength();
            Logger.WriteDebugMessage("Unable to enter more than 100 characters.");

            //7 Try to enter more than 250 characters into the Company field.
            Clients.VerifyCompanyNameLength();
            Logger.WriteDebugMessage("Unable to enter more than 250 characters.");

            //8 Try to enter more than 300 characters into the Email field.
            Clients.VerifyEmailNameLength();
            Logger.WriteDebugMessage("Unable to enter more than 300 characters.");

            //9 Try to enter more than 50 characters into the Phone field.
            Clients.VerifyPhoneNumberLength();
            Logger.WriteDebugMessage("Unable to enter more than 50 characters.");

            //10 Click "Show Address"
            Clients.AddNewClient_ExpandAddNewClientAddressFields();
            Logger.WriteDebugMessage("The address fields are displayed.");

            //11 Click "Hide Address"
            Clients.AddNewClient_CollapseAddNewClientAddressFields();
            Logger.WriteDebugMessage("The address fields are hidden.");

            //12 Click "Show Address"
            Clients.AddNewClient_ExpandAddNewClientAddressFields();
            Logger.WriteDebugMessage("The address fields are displayed.");

            //13 Try to enter more than 200 characters in the Address field.
            Clients.VerifyAddressLength();
            Logger.WriteDebugMessage("Unable to enter more than 200 characters.");

            //14 Try to enter more than 100 characters in the City field.
            Clients.VerifyCityLength();
            Logger.WriteDebugMessage("Unable to enter more than 100 characters.");

            //15 Try to enter more than 50 characters in the State field.
            Clients.VerifyStateLength();
            Logger.WriteDebugMessage("Unable to enter more than 50 characters.");

            //16 Try to enter more than 50 characters in the Zip field.
            Clients.VerifyZipLength();
            Logger.WriteDebugMessage("Unable to enter more than 50 characters.");

            //Reset and enter valid data for a fields
            Clients.AddNewClient_ClearAllFields();

            //17 Enter valid new client data
            //17- Make first name, last name, company and email a unique value so it will work when searching.
            firstName = "";
            firstName = MakeUnique(firstName);
            lastName = MakeUnique(lastName);
            company = MakeUnique(company);
            email = MakeGmailUnique(email);
            Clients.AddNewClient_EnterAllValidFields(firstName, lastName,
                company,
                email, phone, address,
                city, state,
                zip, country);
            Logger.WriteDebugMessage("Valid data is entered is selected.");

            //18 Click the "Add Client" button.
            Clients.VerifySuccessfulAddClient();
            Logger.WriteDebugMessage("'Your client X X has been added.' message is displayed.");
        }

        #endregion[TC_120548]

        #region[TC_120549]

        public static void TC_120549()
        {
            //1 Log into eProposal
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select a property.
            string Property = "Cendyn – DEV - BBQ HIlton";
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);

            //3 Click "Create/Edit eProposal."
            EmployeeHome.Click_CreateEdit_eProposalButton();
            Logger.WriteDebugMessage("Landed on the eProposal Step 1 page.");

            //4 Add a new client.
            eProposalCompose.Click_Client_AddNewLink();
            Logger.WriteDebugMessage("Add Client popup is displayed.");

            //5 Try to enter more than 100 characters into the First Name field.
            eProposalCompose.VerifyFirstNameLength();
            Logger.WriteDebugMessage("Unable to enter more than 100 characters.");

            //6 Try to enter more than 100 characters into the Last Name field.
            eProposalCompose.VerifyLastNameLength();
            Logger.WriteDebugMessage("Unable to enter more than 100 characters.");

            //7 Try to enter more than 250 characters into the Company field.
            eProposalCompose.VerifyCompanyNameLength();
            Logger.WriteDebugMessage("Unable to enter more than 250 characters.");

            //8 Try to enter more than 300 characters into the Email field.
            eProposalCompose.VerifyEmailNameLength();
            Logger.WriteDebugMessage("Unable to enter more than 300 characters.");

            //9 Try to enter more than 50 characters into the Phone field.
            eProposalCompose.VerifyPhoneNumberLength();
            Logger.WriteDebugMessage("Unable to enter more than 50 characters.");

            //10 Click "Show Address"
            eProposalCompose.ExpandAddNewClientAddressFields();
            Logger.WriteDebugMessage("The address fields are displayed.");

            //11 Click "Hide Address"
            eProposalCompose.CollapseExpandAddNewClientAddressFields();
            Logger.WriteDebugMessage("The address fields are hidden.");

            //12 Click "Show Address"
            eProposalCompose.ExpandAddNewClientAddressFields();
            Logger.WriteDebugMessage("The address fields are displayed.");

            //13 Try to enter more than 200 characters in the Address field.
            eProposalCompose.VerifyAddressLength();
            Logger.WriteDebugMessage("Unable to enter more than 200 characters.");

            //14 Try to enter more than 100 characters in the City field.
            eProposalCompose.VerifyCityLength();
            Logger.WriteDebugMessage("Unable to enter more than 100 characters.");

            //15 Try to enter more than 50 characters in the State field.
            eProposalCompose.VerifyStateLength();
            Logger.WriteDebugMessage("Unable to enter more than 50 characters.");

            //16 Try to enter more than 50 characters in the Zip field.
            eProposalCompose.VerifyZipLength();
            Logger.WriteDebugMessage("Unable to enter more than 50 characters.");

            //Reset and enter valid data for a fields
            eProposalCompose.AddNewClient_ClearAllFields();

            //17 Enter valid new client data
            //17- Make first name, last name, company and email a unique value so it will work when searching.
            firstName = MakeUnique(firstName);
            lastName = MakeUnique(lastName);
            company = MakeUnique(company);
            email = MakeGmailUnique(email);
            eProposalCompose.AddNewClient_EnterAllValidFields(firstName,
                lastName, company,
                email, phone, address,
                city, state,
                zip, country);
            Logger.WriteDebugMessage("Valid data is entered is selected.");

            //18 Click the "Add Client" button.
            eProposalCompose.Click_Client_AddNew_SaveButton();
            Logger.WriteDebugMessage("'Your client X X has been added.' message is displayed.");

            //19 Click the "Clients -> Search/Edit" tab..
            EmployeeHome.Click_ClientsButton();
            Clients.Click_SearchEditTab();
            Logger.WriteDebugMessage("Land on the Search/Edit Clients tab.");

            //20 Search for the client by "Last Name".
            Clients.ValidateClientSearchByLastName(firstName, lastName,
                email);
            Logger.WriteDebugMessage("The client is displayed.");

            //21 Search for the client by "Email".
            Clients.ValidateClientSearchByEmail(firstName, lastName,
                email);
            Logger.WriteDebugMessage("The client is displayed.");

            //22 Search for the client by "Company".
            Clients.ValidateClientSearchByCompany(firstName, lastName,
                email, company);
            Logger.WriteDebugMessage("The client is displayed.");

            //23 Click "Edit" and verify all information is displayed correctly.
            //Clients.Click_SearchEdit_EditFirstLink();
            //Clients.EditClient_VerifyClientData(firstName, lastName,
            //    company, email,
            //    phone, address, city,
            //    state, zip, country);
            //Logger.WriteDebugMessage("All Client information is displayed correctly.");

            //24 Make an edit to the client and verify the changes are saved.
            //Update all client values
            //firstName = MakeUnique(firstName);
            //lastName = MakeUnique(lastName);
            //company = MakeUnique(company);
            //phone = MakeUnique(phone);
            //address = MakeUnique(address);
            //city = city + "1";
            //state = state + "2";
            //zip = zip + "3";
            //Clients.EditClient_EnterAllValidFields(firstName, lastName,
            //    company,
            //    phone, address, city,
            //    state, zip, country);
            //Clients.Click_SearchEdit_Edit_SaveButton();
            //Logger.WriteDebugMessage("The changes are saved.");

            //25 Search for the client when making an eCard.
            EmployeeHome.Click_WelcomeButton();
            EmployeeHome.Click_CreateEdit_eCardButton();
            AddDelay(3500);
            eProposalCompose.Click_Client_SearchLink();
            eProposalCompose.SearchAndClickClient(firstName);
            Logger.WriteDebugMessage("The client displayed when searching by First Name.");
            eProposalCompose.Click_Client_SearchLink();
            eProposalCompose.SearchAndClickClient(lastName);
            Logger.WriteDebugMessage("The client displayed when searching by Last Name.");
            eProposalCompose.Click_Client_SearchLink();
            eProposalCompose.SearchAndClickClient(email);
            Logger.WriteDebugMessage("The client displayed when searching by Email.");
            Logger.WriteDebugMessage("The client displayed when searching by First Name, Last Name and Email.");

            //26 Log into eProposal Admin
            Driver.Navigate().GoToUrl("http://qaadmin.proposalaccess.com/");
            AdminLogin.LogInCommon();
            Logger.WriteDebugMessage("Logged in successfully.");

            //27 Click the "Clients" tab.
            AdminNavigation.Click_Button_Clients();
            Logger.WriteDebugMessage("Land on the Clients page.");

            //28 Select the property you added the client to.
            AdminClients.Click_Link_Search();
            AdminNavigation.SearchForRegularProperty(Property);
            Logger.WriteDebugMessage("Page is refreshed and the property is selected.");

            //29 Search for the client you added.
            AdminClients_Search.SearchClientFirstName(firstName);
            AdminClients_Search.SearchClientLastName(lastName);
            AdminClients_Search.SearchClientEmail(Email);
            Logger.WriteDebugMessage("The client is displayed.");
        }

        #endregion[TC_120549]

        #region[TC_120550]

        public static void TC_120550()
        {
            //1 Log into eProposal
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select a property.
            string Property = "Cendyn – DEV - BBQ HIlton";
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);

            //3 Click "Create/Edit eCard."
            EmployeeHome.Click_CreateEdit_eCardButton();
            Logger.WriteDebugMessage("Landed on the eCard Step 1 page.");

            //4 Add a new client.
            eProposalCompose.Click_Client_AddNewLink();
            Logger.WriteDebugMessage("Add Client popup is displayed.");

            //5 Try to enter more than 100 characters into the First Name field.
            eProposalCompose.VerifyFirstNameLength();
            Logger.WriteDebugMessage("Unable to enter more than 100 characters.");

            //6 Try to enter more than 100 characters into the Last Name field.
            eProposalCompose.VerifyLastNameLength();
            Logger.WriteDebugMessage("Unable to enter more than 100 characters.");

            //7 Try to enter more than 250 characters into the Company field.
            eProposalCompose.VerifyCompanyNameLength();
            Logger.WriteDebugMessage("Unable to enter more than 250 characters.");

            //8 Try to enter more than 300 characters into the Email field.
            eProposalCompose.VerifyEmailNameLength();
            Logger.WriteDebugMessage("Unable to enter more than 300 characters.");

            //9 Try to enter more than 50 characters into the Phone field.
            eProposalCompose.VerifyPhoneNumberLength();
            Logger.WriteDebugMessage("Unable to enter more than 50 characters.");

            //10 Click "Show Address"
            eProposalCompose.ExpandAddNewClientAddressFields();
            Logger.WriteDebugMessage("The address fields are displayed.");

            //11 Click "Hide Address"
            eProposalCompose.CollapseExpandAddNewClientAddressFields();
            Logger.WriteDebugMessage("The address fields are hidden.");

            //12 Click "Show Address"
            eProposalCompose.ExpandAddNewClientAddressFields();
            Logger.WriteDebugMessage("The address fields are displayed.");

            //13 Try to enter more than 200 characters in the Address field.
            eProposalCompose.VerifyAddressLength();
            Logger.WriteDebugMessage("Unable to enter more than 200 characters.");

            //14 Try to enter more than 100 characters in the City field.
            eProposalCompose.VerifyCityLength();
            Logger.WriteDebugMessage("Unable to enter more than 100 characters.");

            //15 Try to enter more than 50 characters in the State field.
            eProposalCompose.VerifyStateLength();
            Logger.WriteDebugMessage("Unable to enter more than 50 characters.");

            //16 Try to enter more than 50 characters in the Zip field.
            eProposalCompose.VerifyZipLength();
            Logger.WriteDebugMessage("Unable to enter more than 50 characters.");

            //Reset and enter valid data for a fields
            eProposalCompose.AddNewClient_ClearAllFields();

            //17 Enter valid new client data
            //17- Make first name, last name, company and email a unique value so it will work when searching.
            firstName = MakeUnique(firstName);
            lastName = MakeUnique(lastName);
            company = MakeUnique(company);
            email = MakeGmailUnique(email);
            eProposalCompose.AddNewClient_EnterAllValidFields(firstName,
                lastName, company,
                email, phone, address,
                city, state,
                zip, country);
            Logger.WriteDebugMessage("Valid data is entered is selected.");

            //18 Click the "Add Client" button.
            eProposalCompose.Click_Client_AddNew_SaveButton();
            Logger.WriteDebugMessage("'Your client X X has been added.' message is displayed.");

            //19 Click the "Clients -> Search/Edit" tab..
            EmployeeHome.Click_ClientsButton();
            Clients.Click_SearchEditTab();
            Logger.WriteDebugMessage("Land on the Search/Edit Clients tab.");

            //20 Search for the client by "Last Name".
            Clients.ValidateClientSearchByLastName( firstName, lastName,
                email);
            Logger.WriteDebugMessage("The client is displayed.");

            //21 Search for the client by "Email".
            Clients.ValidateClientSearchByEmail(firstName, lastName,
                email);
            Logger.WriteDebugMessage("The client is displayed.");

            //22 Search for the client by "Company".
            Clients.ValidateClientSearchByCompany(firstName, lastName,
                email, company);
            Logger.WriteDebugMessage("The client is displayed.");

            ////23 Click "Edit" and verify all information is displayed correctly.
            //Clients.Click_SearchEdit_EditFirstLink();
            //Clients.EditClient_VerifyClientData(firstName, lastName,
            //    company, email,
            //    phone, address, city,
            //    state, zip, country);
            //Logger.WriteDebugMessage("All Client information is displayed correctly.");

            ////24 Make an edit to the client and verify the changes are saved.
            ////Update all client values
            //firstName = MakeUnique(firstName);
            //lastName = MakeUnique(lastName);
            //company = MakeUnique(company);
            //phone = MakeUnique(phone);
            //address = MakeUnique(address);
            //city = city + "1";
            //state = state + "2";
            //zip = zip + "3";
            //Clients.EditClient_EnterAllValidFields(firstName, lastName,
            //    company,
            //    phone, address, city,
            //    state, zip, country);
            //Clients.Click_SearchEdit_Edit_SaveButton();
            //Logger.WriteDebugMessage("The changes are saved.");

            //25 Search for the client when making an eProposal.
            EmployeeHome.Click_WelcomeButton();
            EmployeeHome.Click_CreateEdit_eProposalButton();
            AddDelay(3500);
            eProposalCompose.Click_Client_SearchLink();
            eProposalCompose.SearchAndClickClient(firstName);
            Logger.WriteDebugMessage("The client displayed when searching by First Name.");
            eProposalCompose.Click_Client_SearchLink();
            eProposalCompose.SearchAndClickClient(lastName);
            Logger.WriteDebugMessage("The client displayed when searching by Last Name.");
            eProposalCompose.Click_Client_SearchLink();
            eProposalCompose.SearchAndClickClient(email);
            Logger.WriteDebugMessage("The client displayed when searching by Email.");
            Logger.WriteDebugMessage("The client displayed when searching by First Name, Last Name and Email.");

            //26 Log into eProposal Admin
            Driver.Navigate().GoToUrl("http://qaadmin.proposalaccess.com/");
            AdminLogin.LogInCommon();
            Logger.WriteDebugMessage("Logged in successfully.");

            //27 Click the "Clients" tab.
            AdminNavigation.Click_Button_Clients();
            Logger.WriteDebugMessage("Land on the Clients page.");

            //28 Select the property you added the client to.
            AdminClients.Click_Link_Search();
            AdminNavigation.SearchForRegularProperty(Property);
            Logger.WriteDebugMessage("Page is refreshed and the property is selected.");
            Helper.AddDelay(5000);

            //29 Search for the client you added.
            AdminClients_Search.SearchClientFirstName(firstName);
            AdminClients_Search.SearchClientLastName(lastName);
            AdminClients_Search.SearchClientEmail(email);
            Logger.WriteDebugMessage("The client is displayed.");
        }

        #endregion[TC_120550]

        #region[TC_120554]

        public static void TC_120554()
        {
            //1 Log into eProposal
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select a property.
            string Property = "Cendyn – DEV - BBQ HIlton";
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);

            //3 Click the "Clients" nav..
            EmployeeHome.Click_ClientsButton();

            //4 Add a client with an email that already exists
            Clients.AddNewClient_EnterAllValidFields(firstName, lastName,
                company,
                email, phone, address,
                city, state,
                zip, country);
            Clients.VerifyClientAlreadyExists();

            //5 Add a client with an email that already exists while creating an eProposal
            EmployeeHome.Click_WelcomeButton();
            EmployeeHome.Click_CreateEdit_eProposalButton();
            eProposalCompose.Click_Client_AddNewLink();
            eProposalCompose.AddNewClient_EnterAllValidFields(firstName,
                lastName, company,
                email, phone, address,
                city, state,
                zip, country);
            eProposalCompose.Click_Client_AddNew_SaveButton();
            eProposalCompose.VerifyClientAlreadyExists();
            eProposalCompose.Click_Client_AddNew_CancelButton();

            //6 Add a client with an email that already exists while creating an eCard
            EmployeeHome.Click_WelcomeButton();
            EmployeeHome.Click_CreateEdit_eCardButton();
            AddDelay(7000);
            eProposalCompose.Click_Client_AddNewLink();
            eProposalCompose.AddNewClient_EnterAllValidFields(firstName,
                lastName, company,
                email, phone, address,
                city, state,
                zip, country);
            eProposalCompose.Click_Client_AddNew_SaveButton();
            eProposalCompose.VerifyClientAlreadyExists();
            eProposalCompose.Click_Client_AddNew_CancelButton();
        }

        #endregion[TC_120554]

        #endregion[TP_84916]

    }
}
