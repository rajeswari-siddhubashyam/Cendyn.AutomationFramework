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
        #region[TP_349772]
        public static void TC_314618()
        {
            if (TestCaseId == Constants.TC_314618)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
               /* SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                //Driver.Navigate().Refresh();
                OrgIndex.Filter_Options_ByPropertyName();
                OrgIndex.ViewBrandDashboard();*/

                string searchText = TestData.ExcelData.TestDataReader.ReadData(5, "brand_name");
                Logger.WriteDebugMessage("Brand Name - " + searchText);

                AccountInfo account = new AccountInfo();
                Queries.GetAccountDetails(account, searchText);
                List<AccountInfo> properties = new List<AccountInfo>();
                Queries.GetPropertiesForBrand(properties, account.AccountID);
                Dashboard.VerifyProperties(properties);
                
            }
        }
        public static void TC_314590()
        {
            if (TestCaseId == Constants.TC_314590)
            {
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                //Driver.Navigate().Refresh();
                OrgIndex.Filter_Options_ByPropertyName();
                OrgIndex.ViewBrandDashboard();
                string searchText = TestData.ExcelData.TestDataReader.ReadData(5, "brand_name");
                Logger.WriteDebugMessage("Brand Name - " + searchText);

                AccountInfo account = new AccountInfo();
                Queries.GetAccountDetails(account, searchText);
                
                //  Verify Account details & Release & status - 363907 
                Dashboard.LogText("Brand", "Basic info");
                AccountInfo chain = new AccountInfo();
                Queries.GetParentAccount(chain, account.AccountID);
                account.Chain = chain.Name;
                Dashboard.verifyAccountdetails("brand", account);
            }
        }

        
        public static void TC_314610()
        {
            if (TestCaseId == Constants.TC_314610)
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
                OrgIndex.ViewBrandDashboard(); */

                /* Verify Localization TC 314610*/
                string searchText = TestData.ExcelData.TestDataReader.ReadData(5, "brand_name");
                Logger.WriteDebugMessage("Brand Name - " + searchText);
                AccountInfo account = new AccountInfo();
                Queries.GetAccountDetails(account, searchText);
                AccountLocalization localization = new AccountLocalization();
                Queries.GetLocalization(localization, account.AccountID);
                Dashboard.LogText("Brand", "Localization fields");
                Dashboard.verifyAccountLocalizationDetails("brand", localization);

                /* Verify Phone Numbers */
                Dashboard.LogText("Brand", "Phone numbers");
                List<AccountPhone> ph = new List<AccountPhone>();
                Queries.GetAccountPhone(ph, account.AccountID);
                Dashboard.VerifyPhone("brand", ph);

                /*Verify links*/
                Dashboard.LogText("Brand", "Links");
                List<AccountLinks> links = new List<AccountLinks>();
                Queries.GetLinks(links, account.AccountID);
                Dashboard.VerifyLinks("brand", links);

            }
        }
        //Edit Brand Basic
        public static void TC_349764()
        {
            if (TestCaseId == Constants.TC_349764)
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
                OrgIndex.ViewBrandDashboard(); */

                string searchText = TestData.ExcelData.TestDataReader.ReadData(5, "brand_name");
                string expectedHeaderText = TestData.ExcelData.TestDataReader.ReadData(2, "edit_brand");
                Logger.WriteDebugMessage("Brand Name - " + searchText);
                AccountInfo account = new AccountInfo();
                Queries.GetAccountDetails(account, searchText);
                AccountInfo chain = new AccountInfo();
                Queries.GetParentAccount(chain, account.AccountID);
                account.Chain = chain.Name;
                Create.clickManageBrand();
                Create.EditBrandPage(account, expectedHeaderText);

            }
        }
        #endregion[TP_349772]
    }

}