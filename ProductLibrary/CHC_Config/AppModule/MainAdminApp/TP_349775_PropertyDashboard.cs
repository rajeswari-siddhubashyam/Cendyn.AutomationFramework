using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHC_Config.AppModule.UI;
using CHC_Config.Utility;
using BaseUtility.Utility;
using Queries = CHC_Config.Utility.Queries;
using CHC_Config.Entity;
using InfoMessageLogger;
using System.Threading;

namespace CHC_Config.AppModule.MainAdminApp
{
    public partial class MainAdminApp : CHC_Config.Utility.Setup
    {
        #region[TP_349775]
        public static void TC_314581()
        {
            if (TestCaseId == Constants.TC_314581)
            {
                /*SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                //Driver.Navigate().Refresh();
                OrgIndex.Filter_Options_ByPropertyName();
                OrgIndex.ViewPropertyDashboard();*/
                string searchText = TestData.ExcelData.TestDataReader.ReadData(7, "property_name");
                Logger.WriteDebugMessage("Property Name - " + searchText);

                AccountInfo account = new AccountInfo();
                Queries.GetAccountDetails(account, searchText);

                PropertyAdvancedConfig ac = new PropertyAdvancedConfig();
                Queries.GetPropertyAdvancedConfig(ac, account.AccountID);
                Dashboard.VerifyMetadata(ac);
                Dashboard.VerifyAdvancedConfig(ac);
                Dashboard.VerifyNumberOfRooms(ac);
                List<string> facilities = new List<string>();
                Queries.GetFacilities(facilities, account.AccountID);
                Dashboard.VerifyFacilities(facilities);
            }
        }
        public static void TC_314204()
        {
            if (TestCaseId == Constants.TC_314204)
            {
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                //Driver.Navigate().Refresh();
                OrgIndex.Filter_Options_ByPropertyName();
                OrgIndex.ViewPropertyDashboard();
                string searchText = TestData.ExcelData.TestDataReader.ReadData(7, "property_name");
                Logger.WriteDebugMessage("Property Name - " + searchText);

                AccountInfo account = new AccountInfo();
                Queries.GetAccountDetails(account, searchText);

                //  Verify Account details & Release & status - 363907 
                Dashboard.LogText("Property", "Basic info");
                AccountInfo brand = new AccountInfo();
                AccountInfo chain = new AccountInfo();
                Queries.GetParentAccount(brand, account.AccountID);
                account.Brand = brand.Name;
                Queries.GetParentAccount(chain, brand.AccountID);
                account.Chain = chain.Name;
                Dashboard.verifyAccountdetails("property", account);
            }
        }


        public static void TC_314570()
        {
            if (TestCaseId == Constants.TC_314570)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
              /*  SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                //Driver.Navigate().Refresh();
                OrgIndex.Filter_Options_ByPropertyName();
                OrgIndex.ViewBrandDashboard(); */

                /* Verify Localization TC 314610*/
                string searchText = TestData.ExcelData.TestDataReader.ReadData(7, "property_name");
                Logger.WriteDebugMessage("Property Name - " + searchText);
                AccountInfo account = new AccountInfo();
                Queries.GetAccountDetails(account, searchText);
                AccountLocalization localization = new AccountLocalization();
                Queries.GetLocalization(localization, account.AccountID);
                Dashboard.LogText("Property", "Localization fields");
                Dashboard.verifyAccountLocalizationDetails("property", localization);

                /* Verify Phone Numbers */
                Dashboard.LogText("Property", "Phone numbers");
                List<AccountPhone> ph = new List<AccountPhone>();
                Queries.GetAccountPhone(ph, account.AccountID);
                Dashboard.VerifyPhone("property", ph);

                /*Verify links*/
                Dashboard.LogText("Property", "Links");
                List<AccountLinks> links = new List<AccountLinks>();
                Queries.GetLinks(links, account.AccountID);
                Dashboard.VerifyLinks("property", links);

            }
        }
        public static void TC_349765()
        {
            if (TestCaseId == Constants.TC_349765)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                /*SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                //Driver.Navigate().Refresh();
                OrgIndex.Filter_Options_ByPropertyName();
                OrgIndex.ViewPropertyDashboard();*/

                string searchText = TestData.ExcelData.TestDataReader.ReadData(5, "property_name");
                string expectedHeaderText = TestData.ExcelData.TestDataReader.ReadData(3, "edit_property");
                Logger.WriteDebugMessage("Property Name - " + searchText);
                AccountInfo account = new AccountInfo();
                Queries.GetAccountDetails(account, searchText);
                AccountInfo brand = new AccountInfo();
                AccountInfo chain = new AccountInfo();
                Queries.GetParentAccount(brand, account.AccountID);
                account.Brand = brand.Name;
                Queries.GetParentAccount(chain, brand.AccountID);
                account.Chain = chain.Name;
                Create.clickManageProperty();
                Create.EditPropertyPage(account, expectedHeaderText);

            }
        }

        public static void TC_336529()
        {
            if (TestCaseId == Constants.TC_336529)
            {
                //Step1 : User login CHC application with valid credentials
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();

                //Step2: User click on Configuration app
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                //Step3: User clicked on Users tab from side nav
                CreateUser.Clickon_Users_SideNav();

                //Step4: Click on Craete User button
                CreateUser.Clickon_CreateUser_Button();

                //Step6: Enter Email in email text box                
                CreateUser.Verify_Email_Txt("abcd@cendyn17.");
                Logger.WriteDebugMessage("User entered Wrong Email address in Email text box");

                CreateUser.Verify_Email_Txt_Error_Msg("The Email field format is invalid");

                //Step7: Verify Enter wrong Email in email text box
                CreateUser.Verify_Email_Txt( "Jsmith7@cendyn17.com" );

                //Step8: Click on Proceed button
                CreateUser.Click_On_Proceed_Button();

                //Step9: Enter First name
                CreateUser.Txt_FirstName( "John" );

                //Step10: Enter Last name
                CreateUser.Txt_LastName( "Smith" );

                //Step11: Enter Job Title
                CreateUser.Txt_JobTitle( "Manager" );

                //Step12: Click on Continue button
                CreateUser.Clickon_Continue_Button();

                //Step13: User select the Organization to user
                string accountName = "Brand Hotel" ;
                Thread.Sleep(5000);
                CreateUser.Click_Org_Accounts(accountName);
                Logger.WriteDebugMessage( "User Selected the Origami(Brand) Organization" );
                Logger.WriteDebugMessage( "User click on Continue button & should lands on Organizations scetion step" );

                //Step14: User click on Continue button
                CreateUser.Clickon_Continue_Button();
                Logger.WriteDebugMessage( "User click on Continue button & should lands on Assign Application scetion step" );

                //Step15: Assign application to User
                CreateUser.Assign_App_ToUser();

                //Step16: Assign application roles to user
                CreateUser.Assign_App_Roles_Starling_Readonly_ToUser();

                //Step17: Click on Continue button
                CreateUser.Clickon_Continue_Button();
                Logger.WriteDebugMessage( "User click on Continue button & should lands on Summary scetion step" );

                //Step18: User click on Create user button
                CreateUser.Clickon_Continue_Button();
                Logger.WriteDebugMessage( "User click on Create User button & should lands on User Index page" );

                //Step19: User navigates to index page after user is created
                CreateUser.Verify_Users_On_IndexUser();
                
            }
        }

        #endregion[TP_349775]


            }
    }
