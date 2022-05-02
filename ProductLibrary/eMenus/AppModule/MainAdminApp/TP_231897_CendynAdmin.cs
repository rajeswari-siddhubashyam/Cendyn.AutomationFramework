using BaseUtility.Utility;
using eMenus.AppModule.Admin;
using eMenus.AppModule.UI;
using eMenus.Entity;
using eMenus.PageObject.Admin;
using eMenus.PageObject.UI;
using InfoMessageLogger;
using MongoDB.Driver.Core.Events;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Drawing.Design;
using TestData;
using Queries = eMenus.Utility.Queries;

namespace eMenus.AppModule.MainAdminApp
{
    public partial class MainAdminApp : eMenus.Utility.Setup
    {

        public static void TC_232154()
        {
            if (TestCaseId == Utility.Constants.TC_232154)
            {
                //Pre-Requisite
                string password, username, email_Validation, invalid_Username, invalid_Username_validation, password_Validation, invalid_password_Validation, invalid_password;
                Users data = new Users();

                //Retrieve data from Test data
                Queries.GetActiveMemberEmail(data);
                email_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "Email_Validation");
                invalid_Username = TestData.ExcelData.TestDataReader.ReadData(1, "invalid_Username");
                invalid_Username_validation = TestData.ExcelData.TestDataReader.ReadData(1, "invalid_Username_validation");
                username = TestData.ExcelData.TestDataReader.ReadData(1, "username");
                password_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "password_Validation");
                invalid_password_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "invalid_password_Validation");
                invalid_password = TestData.ExcelData.TestDataReader.ReadData(1, "invalid_password");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");


                //Navigate to Sign In button
                Logger.WriteDebugMessage("Landed on Login Page");
                Email.LogIntoCatchAll();
                Helper.OpenNewTab();
                Helper.Driver.Url = ProjectDetails.CommonAdminURL;

                //Click on Next Button without email 
                SignIn.Next_Button();
                Helper.VerifyTextOnPageAndHighLight(email_Validation);
                Logger.WriteDebugMessage("Validation message is displayed for blank email Field");

                //Click on Next Button by entering invalid email
                SignIn.Enter_Email_Address(invalid_Username);
                SignIn.Next_Button();
                VerifyTextOnPageAndHighLight(invalid_Username_validation);
                Logger.WriteDebugMessage("Validation message for invalid email is Displayed");

                //Enter valid email and click on next button
                Helper.ReloadPage();
                SignIn.Enter_Email_Address(username);
                SignIn.Next_Button(); ;
                Logger.WriteDebugMessage("Landed on password page");

                //Click on Next Button without password 
                SignIn.Login_Button();
                Helper.VerifyTextOnPageAndHighLight(password_Validation);
                Logger.WriteDebugMessage("Validation message is displayed for blank password Field");

                //Click on Next Button without invalid password 
                SignIn.Enter_Email_Password(invalid_password);
                SignIn.Login_Button();
                Helper.VerifyTextOnPageAndHighLight(invalid_password_Validation);
                Logger.WriteDebugMessage("Validation message is displayed for Invalid password ");

                //Enter valid password and click on Login button 
                SignIn.Enter_Email_Password(password);
                SignIn.Login_Button();
                //Logger.WriteDebugMessage("Landed on Verification code page");

                //Login to catch and search for email
                //Helper.ControlToPreviousWindow();
                //Email.CatchAll_SearchEmailAndOpenLatestMessage(username);
                //Helper.AddDelay(10000);
                //Helper.ScrollToElement(PageObject_PropertyAdmin.GetVerificationCode());
                //string code = PropertyAdmin.GetVerificationCode();
                //Logger.WriteDebugMessage("Verification  Code = " + code + " Captured");
                //Helper.CloseCurrentTab();
                //Helper.ControlToNextWindow();
                //Logger.WriteDebugMessage("Landed on Admin Enter Verification Code Page");
                //CendynAdmin.Verificationcode(code);
                //Logger.WriteDebugMessage("Verification Code Entered");
                //CendynAdmin.Verification_Login();
                CendynAdmin.Property_Tab();
                Logger.WriteDebugMessage("Landed on home page");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Valid User Email", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_email Validation", email_Validation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password Validation", password_Validation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_InValid Username", invalid_Username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_InValid Password", invalid_password, true);


            }
        }

        public static void TC_232156()
        {
            if (TestCaseId == Utility.Constants.TC_232156)
            {
                //Pre-Requisite
                string password, username;
                Users data = new Users();

                //Retrieve data from Test data
                username = TestData.ExcelData.TestDataReader.ReadData(1, "Username");
                password = TestData.ExcelData.TestDataReader.ReadData(1, "password");


                //Login to catch and search for email
                //PropertyAdmin.PropertyAdmin_SSO(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);

                //Login to Cendyn Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Click on Dropdown and verify dropdown element
                CendynAdmin.Click_Dropdown();
                Helper.AddDelay(10000);
                Logger.WriteDebugMessage("Dropdown item is displayed");

                //Click Log out button
                CendynAdmin.Click_LogOut();
                Logger.WriteDebugMessage("user log out successfully");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Valid User Email", username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);


            }
        }
        public static void TC_232159()
        {
            if (TestCaseId == Utility.Constants.TC_232159)
            {
                //Pre-Requisite
                string propertyName, categoryName, categoryValidation, sub_sub_categoryName, sub_categoryName, ranno, username,password;
                Random rno = new Random();
                ranno = (rno.Next().ToString()).Substring(0,3);

                //Retrieve data from Test data
                username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                categoryName = TestData.ExcelData.TestDataReader.ReadData(1, "categoryName")+ ranno;
                sub_categoryName = TestData.ExcelData.TestDataReader.ReadData(1, "sub_categoryName")+ ranno;
                sub_sub_categoryName = TestData.ExcelData.TestDataReader.ReadData(1, "sub_sub_categoryName")+ ranno;
                categoryValidation = TestData.ExcelData.TestDataReader.ReadData(1, "categoryValidation");

                //Login to Cendyn Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                CendynAdmin.NavigatetoCendynProperty(propertyName);

                //Click Supplier tab
                CendynAdmin.Supplier_Tab();
                Logger.WriteDebugMessage("landed on supplier page");
                CendynAdmin.Click_category();
                Logger.WriteDebugMessage("Landed on Category page");

                //Verify the Clone button
                
                //if (CendynAdmin.Clone_category().Contains("disabled"))
                //    Logger.WriteDebugMessage("Clone button disabled");
                //else
                //    Assert.Fail("Clone button is enabled");

                //Add Specif Category
                CendynAdmin.AddCategory(categoryName, sub_categoryName, sub_sub_categoryName, categoryValidation);

                //Navigate to Cendyn Admin
                CendynAdmin.NavigateToPropertyAdmin();

                //Select Specific Property from drop-down and verify added category
                PropertyAdmin.Click_Select_PropertyDropdown();
                Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
                PropertyAdmin.Enter_Property_TextBox(propertyName);
                Logger.WriteDebugMessage("Entered Property");
                PropertyAdmin.Select_Property_Dropdown(propertyName);
                Logger.WriteDebugMessage(propertyName + " Property got Selected");

                //Verify added category on property admin page
                Helper.EnterFrame("frontendEditorIframe");
                Helper.ValidateTextOnPage(categoryName);
                Logger.WriteDebugMessage("Added category displayed on property admin page");
                CendynAdmin.Added_CategoryDropDown(categoryName);
                Logger.WriteDebugMessage("Category displayed with sub categories");
                CendynAdmin.Added_CategoryDropDown(sub_categoryName);
                Logger.WriteDebugMessage("Category displayed with sub categories");
                Helper.ExitFrame();


                //Click on Publish button
                PropertyAdmin.Publish_Changes();

                //Verify the Menu on Preview Mode
                PropertyAdmin.Click_MyMenu_PreviewButton();
                ControlToNextWindow();
                Helper.VerifyTextOnPageAndHighLight(categoryName);
                Logger.WriteDebugMessage("Added category displayed on Preview Page");
                HomePage.Added_CategoryDropDown(categoryName);
                Logger.WriteDebugMessage("Sub categories displayed");
                HomePage.Added_CategoryDropDown(sub_categoryName);
                Logger.WriteDebugMessage("Category displayed with sub categories are displayed on Preview page");
                CloseCurrentTab();
                Logger.WriteDebugMessage("Landed Back on Property Admin Page");

                //Click Published_View
                ControlToNewWindow();
                CendynAdmin.Click_Published_View();
                Helper.ControlToNextWindow();
                Helper.VerifyTextOnPageAndHighLight(categoryName);
                Logger.WriteDebugMessage("Added category displayed on Front-end");
                HomePage.Added_CategoryDropDown(categoryName);
                Logger.WriteDebugMessage("Sub categories displayed on Front-end");
                HomePage.Added_CategoryDropDown(sub_categoryName);
                Logger.WriteDebugMessage("Category displayed with sub categories on Front-end");
                CloseCurrentTab();

                //Delete Added Category
                ControlToNewWindow();
                Logger.WriteDebugMessage("Landed on Property Admin Page");
                PropertyAdmin.Click_Main_Navigation_Dropdown();
                Logger.WriteDebugMessage("Drop-down item is displayed");
                PropertyAdmin.Click_Navigation_Dropdown_Value("cendynadmin");
                Logger.WriteDebugMessage("Navigated to Cendyn Admin");
                CendynAdmin.Supplier_Tab();
                Logger.WriteDebugMessage("landed on supplier page");
                CendynAdmin.Click_category();
                Logger.WriteDebugMessage("Landed on Category page");
                CendynAdmin.DeleteCategory(categoryName);

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_category Name", categoryName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Sub category Name", sub_categoryName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Sub Sub category Name", sub_sub_categoryName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_categoryValidation", categoryValidation, true);

            }
        }
        public static void TC_232160()
        {
            if (TestCaseId == Utility.Constants.TC_232160)
            {
                //Pre-Requisite
                string propertyName, categoryName, categoryValidation, sub_sub_categoryName, sub_categoryName, ranno, edit = "_edit",username,password;
                Random rno = new Random();
                ranno = (rno.Next().ToString()).Substring(0, 2);

                //Retrieve data from Test data
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                categoryName = TestData.ExcelData.TestDataReader.ReadData(1, "categoryName")+ ranno;
                sub_categoryName = TestData.ExcelData.TestDataReader.ReadData(1, "sub_categoryName")+ ranno;
                sub_sub_categoryName = TestData.ExcelData.TestDataReader.ReadData(1, "sub_sub_categoryName")+ ranno;
                categoryValidation = TestData.ExcelData.TestDataReader.ReadData(1, "categoryValidation");
                username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;

                //Login to Cendyn Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                CendynAdmin.NavigatetoCendynProperty(propertyName);

                //Click Supplier tab
                CendynAdmin.Supplier_Tab();
                Logger.WriteDebugMessage("landed on supplier page");
                CendynAdmin.Click_category();
                Logger.WriteDebugMessage("Landed on Category page");

                //Add Specif Category
                CendynAdmin.AddCategory(categoryName, sub_categoryName, sub_sub_categoryName, categoryValidation);

                //Edit Category
                CendynAdmin.Edit_Category(categoryName, sub_categoryName, sub_sub_categoryName);

                //Navigate to Cendyn Admin
                CendynAdmin.NavigateToPropertyAdmin();

                //Select Specific Property from drop-down and verify added category
                PropertyAdmin.Click_Select_PropertyDropdown();
                Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
                PropertyAdmin.Enter_Property_TextBox(propertyName);
                Logger.WriteDebugMessage("Entered Property");
                PropertyAdmin.Select_Property_Dropdown(propertyName);
                Logger.WriteDebugMessage(propertyName + " Property got Selected");

                //Verify added category on property admin page
                Helper.EnterFrame("frontendEditorIframe");
                Helper.ValidateTextOnPage(categoryName+edit);
                Logger.WriteDebugMessage("Added category displayed on property admin page");
                CendynAdmin.Added_CategoryDropDown(categoryName + edit);
                Logger.WriteDebugMessage("Category displayed with sub categories");
                CendynAdmin.Added_CategoryDropDown(sub_categoryName+edit);
                Logger.WriteDebugMessage("Category displayed with sub categories");
                CendynAdmin.Added_CategoryDropDown(categoryName + edit);
                Helper.ExitFrame();


                //Click on Publish button
                PropertyAdmin.Publish_Changes();

                //Verify the Menu on Preview Mode
                PropertyAdmin.Click_MyMenu_PreviewButton();
                ControlToNextWindow();
                Helper.VerifyTextOnPageAndHighLight(categoryName+edit);
                Logger.WriteDebugMessage("Added category displayed on Preview Page");
                HomePage.Added_CategoryDropDown(categoryName+edit);
                Logger.WriteDebugMessage("Sub categories displayed");
                HomePage.Added_CategoryDropDown(sub_categoryName+edit);
                Logger.WriteDebugMessage("Category displayed with sub categories are displayed on Preview page");
                CloseCurrentTab();
                Logger.WriteDebugMessage("Landed Back on Property Admin Page");

                //Click Published_View
                ControlToNextWindow();
                CendynAdmin.Click_Published_View();
                Helper.ControlToNextWindow();
                Helper.VerifyTextOnPageAndHighLight(categoryName+edit);
                Logger.WriteDebugMessage("Added category displayed on Front-end");
                HomePage.Added_CategoryDropDown(categoryName+edit);
                Logger.WriteDebugMessage("Sub categories displayed on Front-end");
                HomePage.Added_CategoryDropDown(sub_categoryName+edit);
                Logger.WriteDebugMessage("Category displayed with sub categories on Front-end");
                CloseCurrentTab();

                //Delete Added Category
                ControlToNewWindow();
                Logger.WriteDebugMessage("Landed on Property Admin Page");
                PropertyAdmin.Click_Main_Navigation_Dropdown();
                Logger.WriteDebugMessage("Drop-down item is displayed");
                PropertyAdmin.Click_Navigation_Dropdown_Value("cendynadmin");
                Logger.WriteDebugMessage("Navigated to Cendyn Admin");
                CendynAdmin.Supplier_Tab();
                Logger.WriteDebugMessage("landed on supplier page");
                CendynAdmin.Click_category();
                Logger.WriteDebugMessage("Landed on Category page");
                CendynAdmin.DeleteCategory(categoryName + edit);

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_category Name", categoryName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Sub category Name", sub_categoryName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Sub Sub category Name", sub_sub_categoryName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Edited Category Name", categoryName+edit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Edited Sub category Name", sub_categoryName+edit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Edited Sub Sub category Name", sub_sub_categoryName+edit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_categoryValidation", categoryValidation, true);



            }
        }
        public static void TC_232161()
        {
            if (TestCaseId == Utility.Constants.TC_232161)
            {
                //Pre-Requisite
                string propertyName, categoryName, categoryValidation, sub_sub_categoryName, sub_categoryName, ranno,username,password;
                Random rno = new Random();
                ranno = (rno.Next().ToString()).Substring(0, 2);

                //Retrieve data from Test data
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                categoryName = TestData.ExcelData.TestDataReader.ReadData(1, "categoryName") + ranno;
                sub_categoryName = TestData.ExcelData.TestDataReader.ReadData(1, "sub_categoryName") + ranno;
                sub_sub_categoryName = TestData.ExcelData.TestDataReader.ReadData(1, "sub_sub_categoryName") + ranno;
                categoryValidation = TestData.ExcelData.TestDataReader.ReadData(1, "categoryValidation");
                username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;

                //Login to Cendyn Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                CendynAdmin.NavigatetoCendynProperty(propertyName);

                //Click Supplier tab
                CendynAdmin.Supplier_Tab();
                Logger.WriteDebugMessage("landed on supplier page");
                CendynAdmin.Click_category();
                Logger.WriteDebugMessage("Landed on Category page");

                //Add Specif Category
                CendynAdmin.AddCategory(categoryName, sub_categoryName, sub_sub_categoryName, categoryValidation);

                //Navigate to Cendyn Admin
                CendynAdmin.NavigateToPropertyAdmin();

                //Select Specific Property from drop-down and verify added category
                PropertyAdmin.Click_Select_PropertyDropdown();
                Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
                PropertyAdmin.Enter_Property_TextBox(propertyName);
                Logger.WriteDebugMessage("Entered Property");
                PropertyAdmin.Select_Property_Dropdown(propertyName);
                Logger.WriteDebugMessage(propertyName + " Property got Selected");
                Helper.EnterFrame("frontendEditorIframe");
                if (Helper.IsWebElementRemoved(PageObject_CendynAdmin.Added_CategoryDropDown(categoryName)))
                {
                    CendynAdmin.Added_CategoryDropDown(categoryName);
                    Logger.WriteDebugMessage(categoryName + " = Category is Displaying on the Page");
                }
                else
                {
                    Logger.WriteInfoMessage(categoryName + " = Category is not Displaying on the page");
                    Assert.Fail(categoryName + " = Category is not Displaying on the page");
                }
                Helper.ExitFrame();

                //Click on Publish button
                PropertyAdmin.Publish_Changes();

                //Verify the Category on Preview Mode
                PropertyAdmin.Click_MyMenu_PreviewButton();
                ControlToNextWindow();
                if (Helper.IsWebElementRemoved(PageObject_HomePage.Added_CategoryDropDown(categoryName)))
                {
                    HomePage.Added_CategoryDropDown(categoryName);
                    Logger.WriteDebugMessage(categoryName + " = Category is displaying on the Page");
                    
                }
                else
                {
                    Logger.WriteInfoMessage(categoryName + " = Category is not displaying on the page");
                    Assert.Fail(categoryName + " = Category is not displaying on the page");
                }
                CloseCurrentTab();
                Logger.WriteDebugMessage("Landed Back on Property Admin Page");


                //Click Published_View and Verify the Category
                Helper.ControlToNewWindow();
                CendynAdmin.Click_Published_View();
                Helper.ControlToNextWindow();
                if (Helper.IsWebElementRemoved(PageObject_HomePage.Added_CategoryDropDown(categoryName)))
                {
                    HomePage.Added_CategoryDropDown(categoryName);
                    Logger.WriteDebugMessage(categoryName + " = Category is displaying on the Page");
                }
                else
                {
                    Logger.WriteInfoMessage(categoryName + " = Category is not displaying on the page");
                    Assert.Fail(categoryName + " = Category is not displaying on the page");
                }
                Helper.CloseCurrentTab();
                Logger.WriteDebugMessage("Navigate back to Admin Page");

                // Delete Added Category
                Helper.ControlToNewWindow();
                PropertyAdmin.Click_Main_Navigation_Dropdown();
                Logger.WriteDebugMessage("Drop-down item is displayed");
                PropertyAdmin.Click_Navigation_Dropdown_Value("cendynadmin");
                Logger.WriteDebugMessage("Navigated to Cendyn Admin");
                CendynAdmin.Supplier_Tab();
                Logger.WriteDebugMessage("landed on supplier page");
                CendynAdmin.Click_category();
                Logger.WriteDebugMessage("Landed on Category page");
                CendynAdmin.DeleteCategory(categoryName);

                //Navigate to Cendyn Admin
                CendynAdmin.NavigateToPropertyAdmin();

                //Select Specific Property from drop-down and verify added category
                PropertyAdmin.Click_Select_PropertyDropdown();
                Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
                PropertyAdmin.Enter_Property_TextBox(propertyName);
                Logger.WriteDebugMessage("Entered Property");
                PropertyAdmin.Select_Property_Dropdown(propertyName);
                Logger.WriteDebugMessage(propertyName + " Property got Selected");

                //Verify added category on property admin page
                Helper.EnterFrame("frontendEditorIframe");
                if (Helper.IsWebElementRemoved(PageObject_CendynAdmin.Added_CategoryDropDown(categoryName)))
                {
                    Logger.WriteInfoMessage(categoryName + " = Category is Displaying on the page");
                    Assert.Fail(categoryName + " = Category is Displaying on the page");
                }
                else
                    Logger.WriteDebugMessage(categoryName + " = Category is Not Displaying on the Page");
                Helper.ExitFrame();


                //Click on Publish button
                //PropertyAdmin.Publish_Changes();

                //Verify the Menu on Preview Mode
                PropertyAdmin.Click_MyMenu_PreviewButton();
                ControlToNextWindow();
                if (Helper.IsWebElementRemoved(PageObject_HomePage.Added_CategoryDropDown(categoryName)))
                {
                    Logger.WriteInfoMessage(categoryName + " = Category is Displaying on the page");
                    Assert.Fail(categoryName + " = Category is Displaying on the page");
                }
                else
                    Logger.WriteDebugMessage(categoryName + " = Category is Not Displaying on the Page");
                CloseCurrentTab();
                Logger.WriteDebugMessage("Landed Back on Property Admin Page");

                //Click Published_View
                Helper.ControlToNextWindow();
                CendynAdmin.Click_Published_View();
                Helper.ControlToNextWindow();
                if (Helper.IsWebElementRemoved(PageObject_HomePage.Added_CategoryDropDown(categoryName)))
                {
                    Logger.WriteInfoMessage(categoryName + " = Category is Displaying on the page");
                    Assert.Fail(categoryName + " = Category is Displaying on the page");
                }
                else
                    Logger.WriteDebugMessage(categoryName + " = Category is Not Displaying on the Page");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_category Name", categoryName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Sub category Name", sub_categoryName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Sub Sub category Name", sub_sub_categoryName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_categoryValidation", categoryValidation, true);
            }
        }
        public static void TC_232157()
        {
            if (TestCaseId == Utility.Constants.TC_232157)
            {
                
                //Pre-Requisite
                string propertyName, shareMenu, dynamicPricing, propertyUrl,username,password;

                //Retrieve data from Test data
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                shareMenu = TestData.ExcelData.TestDataReader.ReadData(1, "ShareMenu");
                dynamicPricing = TestData.ExcelData.TestDataReader.ReadData(1, "DynamicPricing");
                propertyUrl = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyUrl");
                username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;

                //Login to Cendyn Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Select Property for cendyn admin
                CendynAdmin.NavigatetoCendynProperty(propertyName);

                //Navigate to property admin
                Helper.OpenNewTab();
                Helper.ControlToNewWindow();
                Helper.Driver.Url = propertyUrl;
                Logger.WriteDebugMessage("Landed on Property admin page");


                //Select Property for property admin
                PropertyAdmin.Click_Select_PropertyDropdown();
                Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
                PropertyAdmin.Enter_Property_TextBox(propertyName);
                Logger.WriteDebugMessage("Entered Property");
                PropertyAdmin.Select_Property_Dropdown(propertyName);
                Logger.WriteDebugMessage(propertyName + " Property got Selected");

                //Check basic setting for Share menu
                Helper.SwitchToSpecificWindow("Property - eMenus");
                CendynAdmin.Click_Property_BasicSettings_Tab();
                Logger.WriteDebugMessage("Landed on Basic Setting Page");
                CendynAdmin.Click_ShareMenu_NoButton();
                Logger.WriteDebugMessage("No button selected for share menu");
                PageDown();
                CendynAdmin.Click_BasicSettings_UpdateButton();
                Logger.WriteDebugMessage("No button selected for share menu and Setting should get updated");
                SwitchToSpecificWindow("My Menus - eMenus");
                ReloadPage();
                if (IsWebElementRemoved(PageObject_CendynAdmin.Click_MyMenu_ShareTab()))
                    Assert.Fail("Share menu tab still present on the page");
                else
                    Logger.WriteDebugMessage("Share menu tab removed from the property admin");


                Helper.SwitchToSpecificWindow("Property - eMenus");
                CendynAdmin.Click_Property_BasicSettings_Tab();
                Logger.WriteDebugMessage("Landed on Basic Setting Page");
                CendynAdmin.Click_ShareMenu_YesButton();
                CendynAdmin.Click_BasicSettings_UpdateButton();
                Logger.WriteDebugMessage("Yes button selected for share menu and Setting should get updateds");
                SwitchToSpecificWindow("My Menus - eMenus");
                ReloadPage();
                ElementWait(PageObject_PropertyAdmin.Click_Select_PropertyDropdown(), 60);
                VerifyTextOnPageAndHighLight(shareMenu);
                Logger.WriteDebugMessage("Share menu tab displayed on the page");

                // Check basic setting for dynamic price
                Helper.SwitchToSpecificWindow("Property - eMenus");
                CendynAdmin.Click_Property_BasicSettings_Tab();
                Logger.WriteDebugMessage("Landed on Basic Setting Page");
                CendynAdmin.Click_DynamicPrice_NoButton();
                PageDown();
                CendynAdmin.Click_BasicSettings_UpdateButton();
                Logger.WriteDebugMessage("No button selected for Dynamic pricing and Setting should get updated");
                SwitchToSpecificWindow("My Menus - eMenus");
                ReloadPage();
                Logger.WriteDebugMessage("Landed on Property Admin Page");
                PropertyAdmin.Click_MyMenu_Settings();
                if (IsWebElementRemoved(PageObject_PropertyAdmin.Click_Settings_DynamicPricing()))
                    Assert.Fail("Dynamic Pricing tab still present on the page");
                else
                    Logger.WriteDebugMessage("Dynamic Pricing tab removed from the property admin");


                Helper.SwitchToSpecificWindow("Property - eMenus");
                CendynAdmin.Click_Property_BasicSettings_Tab();
                Logger.WriteDebugMessage("Landed on Basic Setting Page");
                CendynAdmin.Click_DynamicPrice_YesButton();
                CendynAdmin.Click_BasicSettings_UpdateButton();
                Logger.WriteDebugMessage("Yes button selected for Dynamic pricing and Setting should get updated");
                SwitchToSpecificWindow("My Menus - eMenus");
                ReloadPage();
                Logger.WriteDebugMessage("Landed on Property Admin Page");
                PropertyAdmin.Click_MyMenu_Settings();
                VerifyTextOnPageAndHighLight(dynamicPricing);
                Logger.WriteDebugMessage("Dynamic pricing tab should get displayed");


                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName, true);
                

            }
        }
        public static void TC_232158()
        {
            if (TestCaseId == Utility.Constants.TC_232158)
            {
                //Pre-Requisite
                string propertyName, menuImage_Text, propertyUrl,username,password;

                //Retrieve data from Test data
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                menuImage_Text = TestData.ExcelData.TestDataReader.ReadData(1, "MenuImage_Text");
                propertyUrl = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyUrl");
                username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;

                //Login to Cendyn Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Select Property for Cendyn admin
                CendynAdmin.NavigatetoCendynProperty(propertyName);

                //Navigate to property admin
                Helper.OpenNewTab();
                Helper.ControlToNewWindow();
                Helper.Driver.Url = propertyUrl;
                Logger.WriteDebugMessage("Landed on Property admin page");


                //Select Property for property admin
                PropertyAdmin.Click_Select_PropertyDropdown();
                Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
                PropertyAdmin.Enter_Property_TextBox(propertyName);
                Logger.WriteDebugMessage("Entered Property");
                PropertyAdmin.Select_Property_Dropdown(propertyName);
                Logger.WriteDebugMessage(propertyName + " Property got Selected");

                //Check advance settings for menu image as Yes
                Helper.SwitchToSpecificWindow("Property - eMenus");
                CendynAdmin.Click_AdvancedSettings_Tab();
                CendynAdmin.Click_MenuImage_YesButton();
                Logger.WriteDebugMessage("Menu image button selected as Yes");
                Helper.ScrollToElement(PageObject_CendynAdmin.Click_AdvancedSettings_UpdateButton());
                CendynAdmin.Click_AdvancedSettings_UpdateButton();
                Logger.WriteDebugMessage("Menu image setting updated successfully");

                // Verify menu image field in Property admin 
                SwitchToSpecificWindow("My Menus - eMenus");
                ReloadPage();
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Breakfast drop-down should get clicked");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                Logger.WriteDebugMessage("Navigated to Menu Page");
                PropertyAdmin.Click_MyMenu_AddNewMenu();
                ExitFrame();
                VerifyTextOnPageAndHighLight(menuImage_Text);
                Logger.WriteDebugMessage("Menu Image field displayed on the page");
                PropertyAdmin.Click_AddNewMenu_CancelButton();


                //Check advance settings for menu image as No
                Helper.SwitchToSpecificWindow("Property - eMenus");
                PageUp();
                CendynAdmin.Click_AdvancedSettings_Tab();
                CendynAdmin.Click_MenuImage_NoButton();
                Logger.WriteDebugMessage("Menu image button selected as No");
                Helper.ScrollToElement(PageObject_CendynAdmin.Click_AdvancedSettings_UpdateButton());
                CendynAdmin.Click_AdvancedSettings_UpdateButton();
                Logger.WriteDebugMessage("Menu image setting updated successfully");

                // Verify menu image field in Property admin 
                SwitchToSpecificWindow("My Menus - eMenus");
                ReloadPage();
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Breakfast drop-down should get clicked");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                Logger.WriteDebugMessage("Navigated to Menu Page");
                PropertyAdmin.Click_MyMenu_AddNewMenu();
                ExitFrame();
                if (IsWebElementRemoved(PageObject_CendynAdmin.Click_AddNewMenu_UploadImageButton()))
                    Assert.Fail("Menu Image field displayed on the page ");
                else
                    Logger.WriteDebugMessage("Menu Image field removed from the page");


                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Image Text", menuImage_Text, true);


            }
        }
    }
}



