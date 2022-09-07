using CHC_Config.AppModule.UI;
using CHC_Config.Entity;
using CHC_Config.Utility;
using BaseUtility.Utility;
using Queries = CHC_Config.Utility.Queries;
using System.Collections.Generic;
using InfoMessageLogger;
using TestData;
using OpenQA.Selenium;
using System.Threading;
using CHC.PageObject.UI;

namespace CHC_Config.AppModule.MainAdminApp
{
    public class TP_422702_Users_Edit_Index_Dashboard : CHC_Config.Utility.Setup
    {
        #region[TP_422702]
        public static void TC_335464()
        {
            if (TestCaseId == Constants.TC_335464)
            {
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

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
            if (TestCaseId == Constants.TC_335464)
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
            if (TestCaseId == Constants.TC_335464)
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
            if (TestCaseId == Constants.TC_335464)
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

        #endregion[TP_422702]
    }

}

