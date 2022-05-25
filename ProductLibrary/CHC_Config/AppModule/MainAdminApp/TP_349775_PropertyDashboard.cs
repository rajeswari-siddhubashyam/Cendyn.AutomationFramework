using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHC_Config.AppModule.UI;
using CHC_Config.Utility;
using Queries = CHC_Config.Utility.Queries;
using CHC_Config.Entity;
using InfoMessageLogger;


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
        #endregion[TP_349775]
    }
    }
