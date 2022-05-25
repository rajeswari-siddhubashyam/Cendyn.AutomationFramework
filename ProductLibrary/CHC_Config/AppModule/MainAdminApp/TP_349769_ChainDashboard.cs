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
        #region[TP_349769]
        public static void TC_314165()
        {
            if (TestCaseId == Constants.TC_314165)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user


            }
        }
        public static void TC_314185()
        {
            if (TestCaseId == Constants.TC_314185)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
               /*  SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                 SignIn.EnterPassword(Constants.CommonPassword);
                 SignIn.ClickOnSignInButton();
                 WaitTillBrowserLoad();
                 Navigation.Click_Configurations_App();
                 WaitTillBrowserLoad();


                  Navigation.VerifyPopup();

                //Click on Choose button
                Navigation.ClickOnChooseOnPopup();


                //Step5  Verify the Accounts listed & Select the Org
                Navigation.VerifyAccounts();
                Navigation.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Navigation.Click_Accounts(accountName);
                Navigation.VerifyAccountPage(accountName);


                OrgIndex.SearchPropertyName();
                OrgIndex.ViewChainDashboard();*/
                /* Verify Localization - TC314185*/
                string searchText = TestData.ExcelData.TestDataReader.ReadData(6, "chain_name");
                Logger.WriteDebugMessage("Chain Name - " + searchText);
                AccountInfo account = new AccountInfo();
                Queries.GetAccountDetails(account, searchText);
                AccountLocalization localization = new AccountLocalization();
                Queries.GetLocalization(localization, account.AccountID);
                Dashboard.LogText("Chain", "Localization fields");
                Dashboard.verifyAccountLocalizationDetails("chain",localization);

                /* Verify Phone Numbers */
                Dashboard.LogText("Chain", "Phone numbers");
                List<AccountPhone> ph = new List<AccountPhone>();
                Queries.GetAccountPhone(ph, account.AccountID);
                Dashboard.VerifyPhone("chain", ph);

                /*Verify links*/
                Dashboard.LogText("Chain", "Links");
                List<AccountLinks> links = new List<AccountLinks>();
                Queries.GetLinks(links, account.AccountID);
                Dashboard.VerifyLinks("chain", links);

                //  Verify Account details & Release & status - 363907 
                Dashboard.LogText("Chain", "Basic info");
                Dashboard.verifyAccountdetails("chain", account);

            }
        }
             
       
        public static void TC_314190()
        {
            if (TestCaseId == Constants.TC_314190)
            {  /* Verify Properties */
               
                /*SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                Navigation.VerifyPopup();

                //Click on Choose button
                Navigation.ClickOnChooseOnPopup();


                //Step5  Verify the Accounts listed & Select the Org
                Navigation.VerifyAccounts();
                Navigation.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Navigation.Click_Accounts(accountName);
                Navigation.VerifyAccountPage(accountName);


                OrgIndex.SearchPropertyName();
                OrgIndex.ViewChainDashboard();*/

                string searchText = TestData.ExcelData.TestDataReader.ReadData(6, "chain_name");
                Logger.WriteDebugMessage("Chain Name - " + searchText);
                AccountInfo account = new AccountInfo();
                Queries.GetAccountDetails(account, searchText);
                List<AccountInfo> properties = new List<AccountInfo>();
                Queries.GetPropertiesForChain(properties, account.AccountID);
                Dashboard.VerifyProperties(properties);
                string propertyName = Dashboard.ClickBrandProp("property");
                Dashboard.ViewDashboard("property", propertyName);

            }
        }
        public static void TC_314192()
        {
            if (TestCaseId == Constants.TC_314192)
            {   /* Verify Brands */
                
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

               /* Navigation.VerifyPopup();

                //Click on Choose button
                Navigation.ClickOnChooseOnPopup();

                WaitTillBrowserLoad();
                //Step5  Verify the Accounts listed & Select the Org
                Navigation.VerifyAccounts();
                Navigation.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Navigation.Click_Accounts(accountName);*/
                // Navigation.VerifyAccountPage(accountName);

                WaitTillBrowserLoad();
               
                // OrgIndex.SearchPropertyName();
                Driver.Navigate().Refresh();
                OrgIndex.Filter_Options_ByPropertyName();
                OrgIndex.ViewChainDashboard();

                string searchText = TestData.ExcelData.TestDataReader.ReadData(6, "chain_name");
                Logger.WriteDebugMessage("Chain Name - " + searchText);
                AccountInfo account = new AccountInfo();
                Queries.GetAccountDetails(account, searchText);
                List<AccountInfo> brands = new List<AccountInfo>();
                Queries.GetBrandsForChain(brands, account.AccountID);
                Dashboard.VerifyBrands(brands);
                string brandName = Dashboard.ClickBrandProp("brand");
                Dashboard.ViewDashboard("brand", brandName);
            }
        }

        #endregion[TP_349769]
    }
}
