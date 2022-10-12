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
    class TP_334571_View_UserDetails_Reg : CHC_Config.Utility.Setup
    {
        #region[TP_334571]
        public static void TC_334578()
        {
            if (TestCaseId == Constants.TC_334578)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                 SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                 SignIn.EnterPassword(Constants.CommonPassword);
                 SignIn.ClickOnSignInButton();
                 WaitTillBrowserLoad();
                 Navigation.Click_Configurations_App();
                // WaitTillBrowserLoad();

                //CreateUser.Clickon_Organizations_tab();

                CreateUser.Clickon_Users_SideNav();

                CreateUser.Createuser_Enter_Txt_on_Username("kam");

                CreateUser.Createuser_Cick_On_Search_Icon();

                CreateUser.ClickonProfilerecord();

                CreateUser.User_Dashboard_Clickon_Property_tab();

                CreateUser.User_Dashboard_Clickon_Chain_tab();

                CreateUser.User_Dashboard_Clickon_Brand_tab();

                CreateUser.User_Dashboard_Clickon_Apps_Roles_tab();

                CreateUser.User_Dashboard_Clickon_History_tab();
            }
        }

        public static void TC_334579()
        {
            if (TestCaseId == Constants.TC_334579)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                CreateUser.Clickon_Users_SideNav();

                CreateUser.Createuser_Enter_Txt_on_Username("kam");

                CreateUser.Createuser_Cick_On_Search_Icon();

                CreateUser.ClickonProfilerecord();
            }
        }

        public static void TC_334603()
        {
            if (TestCaseId == Constants.TC_334603)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                CreateUser.Clickon_Users_SideNav();

                CreateUser.Createuser_Enter_Txt_on_Username("kam");

                CreateUser.Createuser_Cick_On_Search_Icon();

                CreateUser.ClickonProfilerecord();
                               
                CreateUser.UserDashboard_Propertytab_Click_On_ID_filter();

                CreateUser.UserDashboard_Enter_FilterValues("Equal");

                CreateUser.Userdashboard_Enter_value_on_Filter("97");

                CreateUser.Userdashboard_Property_filter_clickon_Apply_button();
            }
        }

        public static void TC_334604()
        {
            if (TestCaseId == Constants.TC_334604)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                CreateUser.Clickon_Users_SideNav();

                CreateUser.Createuser_Enter_Txt_on_Username("kam");

                CreateUser.Createuser_Cick_On_Search_Icon();

                CreateUser.ClickonProfilerecord();

                CreateUser.UserDashboard_Propertytab_Click_On_Name_filter();

                CreateUser.UserDashboard_Enter_FilterValues("Equal");

                CreateUser.Userdashboard_Enter_value_on_Filter("Hotel Origami Boca Raton");

                CreateUser.Userdashboard_Property_filter_clickon_Apply_button();
            }
        }

        public static void TC_335003()
        {
            if (TestCaseId == Constants.TC_335003)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                CreateUser.Clickon_Users_SideNav();

                CreateUser.Createuser_Enter_Txt_on_Username("kam");

                CreateUser.Createuser_Cick_On_Search_Icon();

                CreateUser.ClickonProfilerecord();

                CreateUser.User_Dashboard_Clickon_Chain_tab();

                CreateUser.UserDashboard_Chaintab_Click_On_ID_filter();

                CreateUser.UserDashboard_Enter_FilterValues("Equal");

                CreateUser.Userdashboard_Enter_value_on_Filter("224");

                CreateUser.Userdashboard_Property_filter_clickon_Apply_button();
            }
        }

        public static void TC_335004()
        {
            if (TestCaseId == Constants.TC_335004)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                CreateUser.Clickon_Users_SideNav();

                CreateUser.Createuser_Enter_Txt_on_Username("kam");

                CreateUser.Createuser_Cick_On_Search_Icon();

                CreateUser.ClickonProfilerecord();

                CreateUser.User_Dashboard_Clickon_Chain_tab();

                CreateUser.UserDashboard_Chaintab_Click_On_Name_filter();

                CreateUser.UserDashboard_Enter_FilterValues("Equal");

                CreateUser.Userdashboard_Enter_value_on_Filter("Ikigai Hotel Group");

                CreateUser.Userdashboard_Property_filter_clickon_Apply_button();
            }
        }

        public static void TC_335005()
        {
            if (TestCaseId == Constants.TC_335005)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                CreateUser.Clickon_Users_SideNav();

                CreateUser.Createuser_Enter_Txt_on_Username("kam");

                CreateUser.Createuser_Cick_On_Search_Icon();

                CreateUser.ClickonProfilerecord();

                CreateUser.User_Dashboard_Clickon_Brand_tab();

                CreateUser.UserDashboard_Brandtab_Click_On_ID_filter();

                CreateUser.UserDashboard_Enter_FilterValues("Equal");

                CreateUser.Userdashboard_Enter_value_on_Filter("225");

                CreateUser.Userdashboard_Property_filter_clickon_Apply_button();
            }
        }

        public static void TC_335006()
        {
            if (TestCaseId == Constants.TC_335006)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                CreateUser.Clickon_Users_SideNav();

                CreateUser.Createuser_Enter_Txt_on_Username("kam");

                CreateUser.Createuser_Cick_On_Search_Icon();

                CreateUser.ClickonProfilerecord();

                CreateUser.User_Dashboard_Clickon_Brand_tab();

                CreateUser.UserDashboard_Brandtab_Click_On_Name_filter();

                CreateUser.UserDashboard_Enter_FilterValues("Equal");

                CreateUser.Userdashboard_Enter_value_on_Filter("Wabi-Sabi Hotels");

                CreateUser.Userdashboard_Property_filter_clickon_Apply_button();
            }
        }
        #endregion[TP_334571]        
    }
}
