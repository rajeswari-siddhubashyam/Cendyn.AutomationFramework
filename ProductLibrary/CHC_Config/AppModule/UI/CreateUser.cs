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
using System.Threading;
using BaseUtility.PageObject;

namespace CHC_Config.AppModule.UI
{
    public class CreateUser : Helper
    {
        /// <summary>
        /// This method is to click on Users tab from left nav in Configuration app
        /// </summary>
        public static void Clickon_Users_SideNav()
        {           
            //Helper.WaitTillBrowserLoad();
            //ElementWait(PageObject_CreateUser.Users_Tab(), 80);
            Thread.Sleep(8000);
            Helper.ElementClick(PageObject_CreateUser.Users_Tab());
            //Helper.WaitTillBrowserLoad();
            Logger.WriteDebugMessage("User clicked on Users tab & Users tab should display");
        }

        /// <summary>
        /// This method will Check the list of profiles in the first page of the table.
        /// </summary>
        /// <param name="lst_ProfileDb"></param>
        public static void VerifyTableData(List<Users> lst_ProfileDb)
        {
            for (int i = 0; i < lst_ProfileDb.Count; i++)
            {
                Users profileDb = lst_ProfileDb[i];
                string profileId = profileDb.UserId;

                VerifyTextOnPageAndHighLight(profileId, "//table[@class='e-table']//tr[" + (i + 1) + "]/td[1]");
                Logger.WriteDebugMessage("User verify the profile id is " + profileId + " ");
            }
        }

        /// <summary>
        /// This method is to create a new user with CraeteUser button
        /// </summary>
        public static void Clickon_CreateUser_Button()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.Craete_User_Button());
            Logger.WriteDebugMessage("User clicked on Create User button & Should display the Email popup to validate email");
        }

        public static void Clickon_Organizations_tab()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.Organizations_Tab());
            Logger.WriteDebugMessage("User clicked on Create User button & Should display the Email popup to validate email");
        }
        
            public static void Userdashboard_Property_filter_clickon_Apply_button()
        {
            //WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.Userdashboard_Property_filter_Apply_button());
            Logger.WriteDebugMessage("User clicked on Apply button");
            AddDelay(6000);
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
            Logger.WriteDebugMessage("User clicked on Proceed button ");
        }

        public static void UserDashboard_Propertytab_Click_On_ID_filter()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.UserDashboard_Propertytab_ID_filter());
            Logger.WriteDebugMessage("User clicked on Property ID filter ");
        }

        public static void UserDashboard_Propertytab_Click_On_Name_filter()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.UserDashboard_Propertytab_Name_filter());
            Logger.WriteDebugMessage("User clicked on Property Name filter ");
        }

        public static void UserDashboard_Chaintab_Click_On_ID_filter()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.UserDashboard_Chaintab_ID_filter());
            Logger.WriteDebugMessage("User clicked on Chain ID filter ");
        }

        public static void UserDashboard_Chaintab_Click_On_Name_filter()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.UserDashboard_Chaintab_Name_filter());
            Logger.WriteDebugMessage("User clicked on Chain Name filter ");
        }

        public static void UserDashboard_Brandtab_Click_On_ID_filter()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.UserDashboard_Brandtab_ID_filter());
            Logger.WriteDebugMessage("User clicked on Brand ID filter ");
        }

        public static void UserDashboard_Brandtab_Click_On_Name_filter()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.UserDashboard_Brandtab_Name_filter());
            Logger.WriteDebugMessage("User clicked on Brand Name filter ");
        }

        /// <summary>
        /// This method is to enter the email in email text box in Popup
        /// </summary>
        /// <param name="email"></param>
        public static void Verify_Email_Txt(string email)
        {
            WaitTillBrowserLoad();
            ElementEnterText(PageObject_CreateUser.Create_User_Email(), email);
            Logger.WriteDebugMessage("User entered Email in Email text box");
        }

        /// <summary>
        /// This method to verify the email validation
        /// </summary>
        public static void Verify_Email_Txt_Error_Msg(string text)
        {
            WaitTillBrowserLoad();
            Logger.WriteDebugMessage("User entered wrong Email in Email text box");
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
            Logger.WriteDebugMessage("User entered Firstname in Firstname text box");
        }

        /// <summary>
        /// This method is to enter the users last name in general section
        /// </summary>
        /// <param name="lastname"></param>
        public static void Txt_LastName(string lastname)
        {
            WaitTillBrowserLoad();
            ElementEnterText(PageObject_CreateUser.Create_User_LastName(), lastname);
            Logger.WriteDebugMessage("User entered Lastname in Lastname text box");
        }

        /// <summary>
        /// This method to validate the Email filed is disabled or not
        /// </summary>
        public static void Verify_Email_field_Disabled()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.Create_User_Email_Disabled());
            Logger.WriteDebugMessage("User entered Email in Email text box");
        }

        /// <summary>
        /// This method is to enter the Users job title in general section
        /// </summary>
        /// <param name="jobtitle"></param>
        public static void Txt_JobTitle(string jobtitle)
        {
            WaitTillBrowserLoad();
            ElementEnterText(PageObject_CreateUser.Create_User_JobTitle(), jobtitle);
            Logger.WriteDebugMessage("User entered Jobtitle in Job Title text box");
        }

        /// <summary>
        /// This method to verify the first name validation
        /// </summary>
        public static void Verify_FirstName_Error()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.Create_User_FirstName_Error_Msg());
            Logger.WriteDebugMessage("User entered Email in Email text box");
        }

        /// <summary>
        /// This method to verify the last name validation
        /// </summary>
        public static void Verify_LastName_Error()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.Create_User_LastName_Error_Msg());
            Logger.WriteDebugMessage("User entered Email in Email text box");
        }

        /// <summary>
        /// This method to verify continue button is disabled or not until we enter the first&Last names
        /// </summary>
        public static void Verify_Continue_Btn_Disabled()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.Create_User_Continue_Button());
            Logger.WriteDebugMessage("User entered Email in Email text box");
        }

        /// <summary>
        /// This method to click on Continue button to move to next section
        /// </summary>
        public static void Clickon_Continue_Button()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.Create_User_Continue_Button());
            Logger.WriteDebugMessage("User click on Continue button & should lands on Organizations scetion step");
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
            Logger.WriteDebugMessage("User select the Organization to the User");
        }

        public static void Select_SelectAll_Org_ToUser()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.Create_User_Select_All());
            Logger.WriteDebugMessage("User click on SelectAll button");
        }

        public static void Assign_App_ToUser()
        {
            WaitTillBrowserLoad();
            ElementClickUsingJavascript(PageObject_CreateUser.Create_User_AssignApp());
            Logger.WriteDebugMessage("Assign the Configuration application to the User");
        }

        public static void Assign_App_Roles_Config_SuperAdmin_ToUser()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.Create_User_AssignRoles());
            Logger.WriteDebugMessage("Assign the Cendyn Super Admin role to the User");
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

        public static void Createuser_Enter_Txt_on_Username(string username)
        {
            WaitTillBrowserLoad();
            ElementEnterText(PageObject_CreateUser.Txt_User_searchbox(), username);
            Logger.WriteDebugMessage("User enter the User name  " + username + "  in search box");
        }

        public static void Createuser_Cick_On_Search_Icon()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.Create_User_Index_Search_Icon());
            Logger.WriteDebugMessage("User clicked on Search icon");
        }

        public static void ClickonFilterbutton()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.CreateUser_Filter());
            Logger.WriteDebugMessage("Filter popup displayed with Clear and Choose buttons");
        }

        public static void Enter_txt_on_ProfileidfieldFilter_Contains(string userid)
        {
            ElementEnterText(PageObject_CreateUser.Txt_Profileidfieldcontainsfilter(), userid);
            Logger.WriteDebugMessage("User enter the profileid " + userid);
            ElementClick(PageObject_CreateUser.Lnk_clickon_Applybutton());

            Helper.WaitForAjaxControls(30);
        }

        public static void Clickon_Clearbutton_on_Filter()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.Clear_Filter());
            Logger.WriteDebugMessage("User cleared the filter value");
        }

        /// <summary>
        /// This method will Check the list of profiles in the first page of the table.
        /// </summary>
        /// <param name="lst_ProfileDb"></param>
        //public static void VerifyTableData(List<Users> lst_ProfileDb)
        //{
        //    for (int i = 0; i < lst_ProfileDb.Count; i++)
        //    {
        //        Users profileDb = lst_ProfileDb[i];
        //        string profileId = profileDb.UserId;

        //        VerifyTextOnPageAndHighLight(profileId, "//table[@class='e-table']//tr[" + (i + 1) + "]/td[1]");
        //        Logger.WriteDebugMessage("User verify the profile id is " + profileId + " ");
        //    }
        //}

        /// <summary>
        /// This method will Check the Profile - Headers in a unified profile table
        /// </summary>
        public static void Verify_TableHeaders()
        {
            string[] tableHeaders = { "User ID", "Name", "Email", "Job Title", "Status" };
            IList<IWebElement> lst_TableHeaders = PageObject_CreateUser.AllColumns_OnTable();

            for (int i = 0; i < lst_TableHeaders.Count - 1; i++)
            {
                if (Helper.GetText(lst_TableHeaders[i]).ToLower().Equals(tableHeaders[i].ToLower()))
                {
                    Logger.WriteInfoMessage("Table Header columns matched successfully " + tableHeaders[i]);
                    Logger.WriteDebugMessage("Table Header columns " + tableHeaders[i]);
                }
                else
                {
                    Logger.WriteInfoMessage("Table Header columns not matched successfully " + tableHeaders[i]);
                    Logger.WriteDebugMessage("Table Header columns not matches");
                }
            }
        }

        public static void ClickonSortbutton()
        {
            WaitTillBrowserLoad();
            ElementClick(PageObject_CreateUser.CreateUser_Btn_Sort());
            Logger.WriteDebugMessage("Sort popup displayed with Clear and Choose buttons");
        }

        public static void Enter_SortValues(string propertyName, string propertyValue)
        {
            if (propertyName.Equals("Order By"))
            {
                Thread.Sleep(3000);
                //WaittillElementDisplay(PageAction.Find_ElementXPath("//*[contains(@aria-owns,'-sort-field_options')]"));
                ElementClick(PageAction.Find_ElementXPath("//*[contains(@aria-owns,'-sort-field_options')]"));
                Thread.Sleep(3000);

                ElementClick(PageAction.Find_ElementXPath("//*[contains(@class,'e-popup-open')]//*[contains(text(),'" + propertyValue + "')]"));
                Logger.WriteDebugMessage("User select the " + propertyValue + " from Order By drop down");
            }
            else if (propertyName.Equals("Direction"))
            {
                Thread.Sleep(3000);
                //WaittillElementDisplay(PageAction.Find_ElementXPath("//*[contains(@aria-owns,'-sort-order_options')]"));
                ElementClick(PageAction.Find_ElementXPath("//*[contains(@aria-owns,'-sort-order_options')]"));
                Thread.Sleep(3000);
                ElementClick(PageAction.Find_ElementXPath("//*[contains(@class,'e-popup-open')]//*[text()='" + propertyValue + "']"));
                Logger.WriteDebugMessage("User select the " + propertyValue + " from Direction drop down");
            }
        }

        public static void ClickonProfilerecord()
        {
            ElementClick(PageObject_CreateUser.Lnk_clickonProfilerecord());
            Logger.WriteDebugMessage("User click on User id URl and navigates to User Dash board page");
            Helper.WaitForAjaxControls(30);
        }

        /// <summary>
        /// This method will Check the Verify text on page and Highlight - data with DB values.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="xpath"></param>
        public static void VerifyTextOnPageAndHighLight(string text, string xpath)
        {
            if (string.IsNullOrEmpty(text))
            {
                text = "--";
            }
            ElementWaitByLocator(xpath, 30);
            IList<IWebElement> list = Helper.Driver.FindElements(By.XPath(xpath));
            int count = 0;
            foreach (IWebElement value in list)
            {
                if (count == 2)
                    break;
                if (value.Text.Contains(text.Trim()))
                {
                    HighlightElement(value);
                    count++;
                    Logger.WriteInfoMessage(text + " Found on the page");
                }
            }
            if (count == 0)
            {
                Assert.Fail(text + "Text not found");
            }
        }

        public static void User_Dashboard_Clickon_Property_tab()
        {
            ElementClick(PageObject_CreateUser.User_Dashboard_Property_tab());
            Logger.WriteDebugMessage("User default navigates to Property tab page");
            Helper.WaitForAjaxControls(30);
        }

        public static void User_Dashboard_Clickon_Chain_tab()
        {
            ElementClick(PageObject_CreateUser.User_Dashboard_Chain_tab());
            Logger.WriteDebugMessage("User click on Chain tab and navigates to list of Chains page");
            Helper.WaitForAjaxControls(30);
        }

        public static void User_Dashboard_Clickon_Brand_tab()
        {
            ElementClick(PageObject_CreateUser.User_Dashboard_Brandy_tab());
            Logger.WriteDebugMessage("User click on Brand tab and navigates to list of Brands page");
            Helper.WaitForAjaxControls(30);
        }

        public static void User_Dashboard_Clickon_Apps_Roles_tab()
        {
            ElementClick(PageObject_CreateUser.User_Dashboard_Apps_Roles_tab());
            Logger.WriteDebugMessage("User click on Apps & Roles tab and navigates to list of Apps & Roles page");
            Helper.WaitForAjaxControls(30);
        }

        public static void User_Dashboard_Clickon_History_tab()
        {
            ElementClick(PageObject_CreateUser.CreateUser_Dashboard_History_tab());
            Logger.WriteDebugMessage("User click on History tab and navigates to User Created & updated information page");
            Helper.WaitForAjaxControls(30);
        }

        public static void Verify_Propertyid_testpresenton_Userdashboard()
        {
            Assert.IsTrue(IsElementDisplayed(PageObject_CreateUser.Txt_Proeprty_ChecktextonUser_Dashboard()), "Property Id text not displayed in User dashboard page");
            Logger.WriteDebugMessage("Property Id text displayed in User dashboard page");
        }

        public static void Createuser_Dashboard_Clickon_Chaintab()
        {
            ElementClick(PageObject_CreateUser.CreateUser_Clickon_Chaintab());
            Logger.WriteDebugMessage("User click on Chain tab and navigates to list of chains page");
            Helper.WaitForAjaxControls(30);
        }

        public static void Verify_Chainid_testpresenton_Userdashboard()
        {
            Assert.IsTrue(IsElementDisplayed(PageObject_CreateUser.Txt_Chainid_ChecktextonUser_Dashboard()), "Chain Id text not displayed in User dashboard page");
            Logger.WriteDebugMessage("Property Id text displayed in User dashboard page");
        }

        public static void Createuser_Dashboard_Clickon_Brandtab()
        {
            ElementClick(PageObject_CreateUser.CreateUser_Clickon_Brandtab());
            Logger.WriteDebugMessage("User click on Brand tab and navigates to list of Brands page");
            Helper.WaitForAjaxControls(30);
        }

        public static void Verify_Brandid_testpresenton_Userdashboard()
        {
            Assert.IsTrue(IsElementDisplayed(PageObject_CreateUser.Txt_Brandid_ChecktextonUser_Dashboard()), "Brand Id text not displayed in User dashboard page");
            Logger.WriteDebugMessage("Brand Id text displayed in User dashboard page");
        }

        public static void Createuser_Dashboard_Clickon_Application_Rolestab()
        {
            ElementClick(PageObject_CreateUser.CreateUser_Clickon_App_Rolestab());
            Logger.WriteDebugMessage("User click on Application & Roles tab and navigates to list of applications  & Roles page");
            Helper.WaitForAjaxControls(30);
        }

        public static void Verify_User_Dashboard_Application_Config()
        {
            Assert.IsTrue(IsElementDisplayed(PageObject_CreateUser.CreateUser_Dashboard_Rolestab_Home()), "Configuration App not displayed in applications & roles page");
            Logger.WriteDebugMessage("Configuration application is displayed in application & roles page");
        }

        //public static void User_Dashboard_Clickon_History_tab()
        //{
        //    ElementClick(PageObject_CreateUser.UserDashboard_Historytab());
        //    Logger.WriteDebugMessage("User click on History tab and navigates to History page");
        //    Helper.WaitForAjaxControls(30);
        //}

        public static void Verify_CreatedUser_testpresenton_History()
        {
            Assert.IsTrue(IsElementDisplayed(PageObject_CreateUser.CreateUser_History_Created()), "Profile Created text not displayed in History page");
            Logger.WriteDebugMessage("Profile Created Label displayed in History page");
        }

        public static void Verify_UpdatedUser_testpresenton_History()
        {
            Assert.IsTrue(IsElementDisplayed(PageObject_CreateUser.CreateUser_History_Updated()), "Profile Updated Label not displayed in History page");
            Logger.WriteDebugMessage("Profile Updated Label displayed in History page");
        }

        public static void UserIndex_Clickon_Moredetails()
        {
            ElementClick(PageObject_CreateUser.Lnx_UserIndex_Moredetails());
            Logger.WriteDebugMessage("User click on Three dots to select the Edit the User");
            Helper.WaitForAjaxControls(30);
        }

        public static void UserIndex_Clickon_Moredetails_Edit()
        {
            ElementClick(PageObject_CreateUser.Lnx_UserIndex_Moredetails_Edit());
            Logger.WriteDebugMessage("User click on Edit tab to navigates to Edit details page");
            Helper.WaitForAjaxControls(30);
        }
        public static void UserDashbaord_Clickon_EditDetails_Button()
        {
            ElementClick(PageObject_CreateUser.btn_Userdashboard_Edit_User());
            Logger.WriteDebugMessage("User click on Edit tab to navigates to Edit details page");
            Helper.WaitForAjaxControls(30);
        }
        
        public static void Edit_User_Details()
        {
            Assert.IsTrue(IsElementDisplayed(PageObject_CreateUser.Txt_Edit_User()), "Edit User page is not displayed");
            Logger.WriteDebugMessage("Edit USer details page displayed");
        }

        public static void EditUser_Access_Roles_tab()
        {
            ElementClick(PageObject_CreateUser.Txt_Edit_User_Access_Role_tab());
            Logger.WriteDebugMessage("User click on Access & Roles tab to navigates to Edit User details page");
            Helper.WaitForAjaxControls(30);
        }

        public static void Userdashboard_Enter_value_on_Filter(string propertyid_value)
        {         
            ElementEnterText(PageObject_CreateUser.Userdashboard_Property_filter_enter_value(), propertyid_value);
            Logger.WriteDebugMessage("User enter the profileid " + propertyid_value);
            //ElementClick(PageObject_CreateUser.Lnk_clickon_Applybutton());

            Helper.WaitForAjaxControls(30);
        }
        

        public static void UserDashBoard_Clickon_EditUser_tab()
        {
            ElementClick(PageObject_CreateUser.UserDashboard_EditUser_tab());
            Logger.WriteDebugMessage("User click on Edit User tab to navigates to Edit User details page");
            Helper.WaitForAjaxControls(30);
        }
        public static void EditUser_Clickon_Assign_Org()
        {
            ElementClick(PageObject_CreateUser.EditUser_Assign_Org());
            Logger.WriteDebugMessage("User Selected the org to the user");
            Helper.WaitForAjaxControls(30);
        }

        public static void UserIndex_Clickon_Sort_Apply_button()
        {
            ElementClick(PageObject_CreateUser.UserIndex_Sort_Apply_button());
            //Logger.WriteDebugMessage("User click on Apply button in sort");
            Helper.WaitForAjaxControls(30);
        }

        public static void UserIndex_Clickon_Filter_Apply_button()
        {
            ElementClick(PageObject_CreateUser.UserIndex_Filter_Apply_button());
            Logger.WriteDebugMessage("User click on Apply button in Filter");
            Helper.WaitForAjaxControls(30);
        }

        public static string GetPropertyLocatorName(string propertyName)
        {
            if (propertyName.Equals("Property ID"))
            {
                propertyName = "accountId";
            }
            else if (propertyName.Equals("Property"))
            {
                propertyName = "property";
            }
            else if (propertyName.Equals("Brand"))
            {
                propertyName = "brand";
            }
            else if (propertyName.Equals("Chain"))
            {
                propertyName = "chain";
            }
            else if (propertyName.Equals("Status"))
            {
                propertyName = "statusId";
            }

            return propertyName;
        }

        public static void Enter_FilterValues(string propertyName, string condition, string propertyValue)
        {
            //Get UI locator name
            string propertyLocatorName = GetPropertyLocatorName(propertyName);

            //Select the condition
            ElementClick(PageAction.Find_ElementXPath("//*[starts-with(@aria-describedby,'operator-" + propertyLocatorName + "')]"));
            Logger.WriteDebugMessage("User selected the Column " + propertyName + " ");
            Thread.Sleep(3000);
            //ElementClickUsingJavascript(PageAction.Find_ElementXPath("//*[starts-with(@id,'operator-" + propertyLocatorName + "')]//*[text()='" + condition + "']"));
            ElementClickUsingJavascript(PageAction.Find_ElementXPath("//*[contains(@class,'e-popup-open')]//*[text()='" + condition + "']"));

            Logger.WriteDebugMessage("User selected the Column " + propertyName + " and selected the " + condition + " from drop down ");
            Helper.WaitForAjaxControls(30);

            //Enter value
            if (propertyName.Equals("Property ID") || propertyName.Equals("Profile Id"))
            {
                ElementEnterText(PageAction.Find_ElementXPath("//input[starts-with(@id,'string-" + propertyLocatorName + "')]"), propertyValue);
            }
            else if (propertyName.Equals("Check In") || propertyName.Equals("Check Out") || propertyName.Equals("Date"))
            {
                ElementEnterText(PageAction.Find_ElementXPath("//input[starts-with(@id,'date-" + propertyLocatorName + "')]"), propertyValue);
            }
            else if (propertyName.Equals("Status") || propertyName.Equals("Source"))
            {
                ElementClick(PageAction.Find_ElementXPath("//*[starts-with(@aria-labelledby,'dropdown-" + propertyLocatorName + "')]"));
                ElementClick(PageAction.Find_ElementXPath("//*[contains(@class,'e-popup-open')]//*[text()='" + propertyValue + "']"));
            }
            else
            {
                //Enter value
                ElementEnterText(PageAction.Find_ElementXPath("//input[starts-with(@id,'string-" + propertyLocatorName + "')]"), propertyValue);
            }

            Logger.WriteDebugMessage("User selected the Column " + propertyName + " and selected the " + condition + " from drop down and enter the value " + propertyValue + " in text box ");

            //ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());
            Helper.WaitForAjaxControls(30);
        }


        public static void UserDashboard_Enter_FilterValues(string condition)
        {
           
            Thread.Sleep(3000);            
            ElementClick(PageAction.Find_ElementXPath("//*[contains(@class,'e-popup-flmenu')]"));
            ElementClickUsingJavascript(PageAction.Find_ElementXPath("//*[contains(@class,'e-popup-open')]//*[text()='" + condition + "']"));            

            Logger.WriteDebugMessage("User selected the " + condition + " from drop down ");
            Helper.WaitForAjaxControls(30);

            
        }

    }

}