using BaseUtility.Utility;
using InfoMessageLogger;
using CHC_Config.PageObject.UI;
using NUnit.Framework;
using System.Collections.Generic;
using System.Reflection;
using OpenQA.Selenium;
using System;
using CHC_Config.Entity;
using System.Web.UI;
using CHC_Config.Utility;

namespace CHC_Config.AppModule.UI
{
    public class CreateUser : Helper
    {
        /// <summary>
        /// This method is to click on Users tab from left nav in Configuration app
        /// </summary>
        public static void Clickon_Users_SideNav()
        {
            //WaitTillBrowserLoad();
            //ElementClick(PageObject_CreateUser.Users_Tab());            

            Logger.WriteDebugMessage( "Users tab" );
            Helper.WaitTillBrowserLoad();            
            ElementWait(PageObject_CreateUser.Users_Tab(), 20);
            AddDelay(2000);
            Helper.ElementClick(PageObject_CreateUser.Users_Tab());
            Helper.WaitTillBrowserLoad();
            Logger.WriteDebugMessage( "User clicked on Users tab & Users tab should display" );
        }

        /// <summary>
        /// This method is to create a new user with CraeteUser button
        /// </summary>
        public static void Clickon_CreateUser_Button()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.Craete_User_Button());
            Logger.WriteDebugMessage( "User clicked on Create User button & Should display the Email popup to validate email" );
        }

        /// <summary>
        /// This method is to verify the Proceed & Cancel button on Popup
        /// </summary>
        public static void VerifyProceed_CancelPopup()
        {
            Assert.IsTrue(IsElementVisible(PageObject_CreateUser.Create_User_Proceed_Button()), "Proceed button not present in popup");
            Assert.IsTrue(IsElementVisible(PageObject_CreateUser.Create_User_Cancel_Button()), "Cancel button not present in popup");
        }

        public static void Click_On_Proceed_Button()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.Create_User_Proceed_Button());
            Logger.WriteDebugMessage( "User clicked on Proceed button " );
        }

        /// <summary>
        /// This method is to enter the email in email text box in Popup
        /// </summary>
        /// <param name="email"></param>
        public static void Verify_Email_Txt(string email)
        {
            WaitTillBrowserLoad();
            ElementEnterText(PageObject_CreateUser.Create_User_Email(),email);
            Logger.WriteDebugMessage("User entered Email  " + email + "  in Email text box");
        }

        /// <summary>
        /// This method to verify the email validation
        /// </summary>
        public static void Verify_Email_Txt_Error_Msg(string text)
        {
            WaitTillBrowserLoad();            
            //Logger.WriteDebugMessage( "User entered wrong Email in Email text box" );
            Assert.IsTrue(GetText(PageObject_CreateUser.Create_User_Email_Error()).Contains(text), "Wrong email not showing validation message");            
        }

        /// <summary>
        /// This method is to enter the users first name in general section
        /// </summary>
        /// <param name="firstname"></param>
        public static void Txt_FirstName(string firstname)
        {
            WaitTillBrowserLoad();
            ElementEnterText(PageObject_CreateUser.Create_User_FirstName(), firstname);
            Logger.WriteDebugMessage( "User entered Firstname " + firstname + " in Firstname text box" );
        }

        /// <summary>
        /// This method is to enter the users last name in general section
        /// </summary>
        /// <param name="lastname"></param>
        public static void Txt_LastName(string lastname)
        {
            WaitTillBrowserLoad();
            ElementEnterText(PageObject_CreateUser.Create_User_LastName(), lastname);
            Logger.WriteDebugMessage("User entered Lastname " + lastname + " in Lastname text box");
        }

        /// <summary>
        /// This method to validate the Email filed is disabled or not
        /// </summary>
        public static void Verify_Email_field_Disabled()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.Create_User_Email_Disabled());
            Logger.WriteDebugMessage( "User entered Email in Email text box" );
        }

        /// <summary>
        /// This method is to enter the Users job title in general section
        /// </summary>
        /// <param name="jobtitle"></param>
        public static void Txt_JobTitle(string jobtitle)
        {
            WaitTillBrowserLoad();
            ElementEnterText(PageObject_CreateUser.Create_User_JobTitle(), jobtitle);
            Logger.WriteDebugMessage("User entered Jobtitle " + jobtitle + " in Job Title text box");
        }

        /// <summary>
        /// This method to verify the first name validation
        /// </summary>
        public static void Verify_FirstName_Error()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.Create_User_FirstName_Error_Msg());
            Logger.WriteDebugMessage( "User entered Email in Email text box" );
        }

        /// <summary>
        /// This method to verify the last name validation
        /// </summary>
        public static void Verify_LastName_Error()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.Create_User_LastName_Error_Msg());
            Logger.WriteDebugMessage( "User entered Email in Email text box" );
        }

        /// <summary>
        /// This method to verify continue button is disabled or not until we enter the first&Last names
        /// </summary>
        public static void Verify_Continue_Btn_Disabled()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.Create_User_Continue_Button());
            Logger.WriteDebugMessage( "User entered Email in Email text box" );
        }

        /// <summary>
        /// This method to click on Continue button to move to next section
        /// </summary>
        public static void Clickon_Continue_Button()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.Create_User_Continue_Button());
            //Logger.WriteDebugMessage("User click on Continue button & should lands on Organizations scetion step");
        }

        public static void Click_Org_Accounts(string accountName)
        {
            foreach (IWebElement ele_Account in PageObject_CreateUser.CreateUser_Org_Accounts())
            {
                //if (GetText(ele_Account).Contains(accountName))
                //{
                ElementClick(ele_Account);
                    //break;
                }
            //}
        }

        public static void Select_Org_ToUser(string accountname)
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.Create_User_AssignOrg());
            Logger.WriteDebugMessage( "User select the Organization to the User" );
        }

        public static void Select_SelectAll_Org_ToUser()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.Create_User_Select_All());
            Logger.WriteDebugMessage( "User click on SelectAll button" );
        }

        public static void Assign_App_ToUser()
        {
            WaitTillBrowserLoad();
            ElementClickUsingJavascript(PageObject_CreateUser.Create_User_AssignApp());
            Logger.WriteDebugMessage( "Assign the Configuration application to the User" );
        }

        public static void Assign_App_Roles_Config_SuperAdmin_ToUser()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.Create_User_AssignRoles());
            Logger.WriteDebugMessage( "Assign the Cendyn Super Admin role to the User" );
        }

        public static void Assign_App_Roles_Starling_Readonly_ToUser()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.Create_User_AssignRoles_Starling_Readonly());
            Logger.WriteDebugMessage("Assign the Read Only role to the User");
        }

        public static void Verify_Users_On_IndexUser()
        {
            Assert.IsTrue(IsElementVisible(PageObject_CreateUser.Verify_Indexpage_Title()), "User Index page not displayed");
        }

    }
}

