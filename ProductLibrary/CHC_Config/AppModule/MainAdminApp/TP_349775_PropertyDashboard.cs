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

        public static void TC_335464()
        {
            if (TestCaseId == Constants.TC_335464)
            {
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();               

                CreateUser.Clickon_Users_SideNav();

                CreateUser.Createuser_Enter_Txt_on_Username("Test QA");

                CreateUser.Createuser_Cick_On_Search_Icon();                
            }
        }

        public static void TC_335441()
        {
            if (TestCaseId == Constants.TC_335441)
            {
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                CreateUser.Clickon_Users_SideNav();

                CreateUser.ClickonFilterbutton();

                Users user = new Users();
                Queries.GetUser(user);

                CreateUser.Enter_txt_on_ProfileidfieldFilter_Contains(user.UserId.ToString());

                CreateUser.ClickonFilterbutton();

                CreateUser.Clickon_Clearbutton_on_Filter();

                //ElementClick(PageObject_CreateUser.VerifyApplybuttononfilter());
            }
        }

        public static void TC_335444()
        {
            if (TestCaseId == Constants.TC_335444)
            {
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                CreateUser.Clickon_Users_SideNav();
               
                CreateUser.ClickonSortbutton();

                CreateUser.Enter_SortValues("Order By", "User ID");
                CreateUser.Enter_SortValues("Direction", "Least - Most");

                CreateUser.UserIndex_Clickon_Sort_Apply_button();

                Users user = new Users();
                Queries.GetUser(user);

                //Step - Verify List of profiles with DB values
                List<Users> profilelist = new List<Users>();

                Queries.GetListfrom_Usersetable(profilelist);
                CreateUser.VerifyTableData(profilelist);
            }
        }

        public static void TC_334574()
        {
            if (TestCaseId == Constants.TC_334574)
            {
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                CreateUser.Clickon_Users_SideNav();

                CreateUser.Verify_TableHeaders();
            }
        }

        public static void TC_334582()
        {
            if (TestCaseId == Constants.TC_334582)
            {
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                CreateUser.Clickon_Users_SideNav();

                Users user = new Users();
                Queries.GetUser(user);

                CreateUser.ClickonFilterbutton();

                CreateUser.Enter_txt_on_ProfileidfieldFilter_Contains(user.UserId.ToString());

                CreateUser.ClickonProfilerecord();

                CreateUser.Verify_Propertyid_testpresenton_Userdashboard();
            }
        }

        public static void TC_334583()
        {
            if (TestCaseId == Constants.TC_334583)
            {
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                CreateUser.Clickon_Users_SideNav();

                Users user = new Users();
                Queries.GetUser(user);

                CreateUser.ClickonFilterbutton();

                CreateUser.Enter_txt_on_ProfileidfieldFilter_Contains(user.UserId.ToString());

                CreateUser.ClickonProfilerecord();

                CreateUser.Createuser_Dashboard_Clickon_Chaintab();

                CreateUser.Verify_Chainid_testpresenton_Userdashboard();
            }
        }

        public static void TC_334597()
        {
            if (TestCaseId == Constants.TC_334597)
            {
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                CreateUser.Clickon_Users_SideNav();

                Users user = new Users();
                Queries.GetUser(user);

                CreateUser.ClickonFilterbutton();

                CreateUser.Enter_txt_on_ProfileidfieldFilter_Contains(user.UserId.ToString());

                CreateUser.ClickonProfilerecord();

                CreateUser.Createuser_Dashboard_Clickon_Brandtab();

                CreateUser.Verify_Brandid_testpresenton_Userdashboard();
            }
        }

        public static void TC_334598()
        {
            if (TestCaseId == Constants.TC_334598)
            {
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                CreateUser.Clickon_Users_SideNav();

                Users user = new Users();
                Queries.GetUser(user);

                CreateUser.ClickonFilterbutton();

                CreateUser.Enter_txt_on_ProfileidfieldFilter_Contains(user.UserId.ToString());

                CreateUser.ClickonProfilerecord();

                CreateUser.User_Dashboard_Clickon_History_tab();

                CreateUser.Createuser_Dashboard_Clickon_Application_Rolestab();

                CreateUser.Verify_User_Dashboard_Application_Config();
            }
        }

        public static void TC_380075()
        {
            if (TestCaseId == Constants.TC_380075)
            {
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                CreateUser.Clickon_Users_SideNav();

                Users user = new Users();
                Queries.GetUser(user);

                CreateUser.ClickonFilterbutton();

                CreateUser.Enter_txt_on_ProfileidfieldFilter_Contains(user.UserId.ToString());

                CreateUser.ClickonProfilerecord();

                CreateUser.User_Dashboard_Clickon_History_tab();

                CreateUser.Verify_CreatedUser_testpresenton_History();
            }
        }

        public static void TC_380077()
        {
            if (TestCaseId == Constants.TC_380077)
            {
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                CreateUser.Clickon_Users_SideNav();

                Users user = new Users();
                Queries.GetUser(user);

                CreateUser.ClickonFilterbutton();

                CreateUser.Enter_txt_on_ProfileidfieldFilter_Contains(user.UserId.ToString());

                CreateUser.ClickonProfilerecord();

                CreateUser.User_Dashboard_Clickon_History_tab();

                CreateUser.Verify_UpdatedUser_testpresenton_History();
            }
        }

        public static void TC_372371()
        {
            if (TestCaseId == Constants.TC_372371)
            {
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                CreateUser.Clickon_Users_SideNav();

                CreateUser.UserIndex_Clickon_Moredetails();

                CreateUser.UserIndex_Clickon_Moredetails_Edit();

                CreateUser.Edit_User_Details();
            }
        }

        public static void TC_422391()
        {
            if (TestCaseId == Constants.TC_422391)
            {
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                CreateUser.Clickon_Users_SideNav();

                Users user = new Users();
                Queries.GetUser(user);

                CreateUser.ClickonFilterbutton();

                CreateUser.Enter_txt_on_ProfileidfieldFilter_Contains(user.UserId.ToString());

                CreateUser.ClickonProfilerecord();

                CreateUser.UserDashBoard_Clickon_EditUser_tab();

                CreateUser.EditUser_Access_Roles_tab();

                CreateUser.EditUser_Clickon_Assign_Org();

                CreateUser.Clickon_Continue_Button();

                //CreateUser.Select_Org_ToUser("Kam's Chain");
                //Logger.WriteDebugMessage("User select the Kam's Chain Organization to the User");
            }
        }

        public static void TC_326760()
        {
            if (TestCaseId == Constants.TC_326760)
            {
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Property ID", "Equal", "329");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Property", "Equal", "Property Hotel23");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Property", "Not Equal", "Property Hotel23");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Property", "Starts With", "p");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Property", "Ends With", "3");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Property", "Contains", "perty");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Brand", "Equal", "Cendyn Property Brand");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Brand", "Not Equal", "Cendyn Property Brand");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Brand", "Starts With", "C");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Brand", "Ends With", "d");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Brand", "Contains", "perty");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Chain", "Equal", "Cendyn Property Chain");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Chain", "Not Equal", "Cendyn Property Chain");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Chain", "Starts With", "c");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Chain", "Ends With", "n");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Chain", "Contains", "operty");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Status", "Is", "Live");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();
            }
        }

        public static void TC_326761()
        {
            if (TestCaseId == Constants.TC_326761)
            {
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                CreateUser.ClickonSortbutton();
                CreateUser.Enter_SortValues("Order By", "Property ID");
                CreateUser.Enter_SortValues("Direction", "Least - Most");
                CreateUser.UserIndex_Clickon_Sort_Apply_button();

                CreateUser.ClickonSortbutton();
                CreateUser.Enter_SortValues("Order By", "Property ID");
                CreateUser.Enter_SortValues("Direction", "Most - Least");
                CreateUser.UserIndex_Clickon_Sort_Apply_button();

                //CreateUser.ClickonSortbutton();
                //CreateUser.Enter_SortValues("Order By", "Property");
                //CreateUser.Enter_SortValues("Direction", "A - Z");
                //CreateUser.UserIndex_Clickon_Sort_Apply_button();

                //CreateUser.ClickonSortbutton();
                //CreateUser.Enter_SortValues("Order By", "Property");
                //CreateUser.Enter_SortValues("Direction", "Z - A");
                //CreateUser.UserIndex_Clickon_Sort_Apply_button();

                CreateUser.ClickonSortbutton();
                CreateUser.Enter_SortValues("Order By", "Brand");
                CreateUser.Enter_SortValues("Direction", "A - Z");
                CreateUser.UserIndex_Clickon_Sort_Apply_button();

                CreateUser.ClickonSortbutton();
                CreateUser.Enter_SortValues("Order By", "Brand");
                CreateUser.Enter_SortValues("Direction", "Z - A");
                CreateUser.UserIndex_Clickon_Sort_Apply_button();

                CreateUser.ClickonSortbutton();
                CreateUser.Enter_SortValues("Order By", "Chain");
                CreateUser.Enter_SortValues("Direction", "A - Z");
                CreateUser.UserIndex_Clickon_Sort_Apply_button();

                CreateUser.ClickonSortbutton();
                CreateUser.Enter_SortValues("Order By", "Chain");
                CreateUser.Enter_SortValues("Direction", "Z - A");
                CreateUser.UserIndex_Clickon_Sort_Apply_button();
                
            }
        }

        #endregion[TP_349775]
    }
    
}
