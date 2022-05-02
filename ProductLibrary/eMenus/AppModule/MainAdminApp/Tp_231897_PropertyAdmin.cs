using AventStack.ExtentReports.Model;
using BaseUtility.Utility;
using eMenus.AppModule.Admin;
using eMenus.AppModule.UI;
using eMenus.Entity;
using eMenus.PageObject.Admin;
using eMenus.PageObject.UI;
using InfoMessageLogger;
using NUnit.Framework;
using System;
using System.Drawing.Printing;
using TestData;
using Queries = eMenus.Utility.Queries;

namespace eMenus.AppModule.MainAdminApp
{
    public partial class MainAdminApp : eMenus.Utility.Setup
    {
        public static void TC_232900()
        {
            if (TestCaseId == Utility.Constants.TC_232900)
            {
                //Pre-Requisites
                string username, propertyAdmin_Username, password, propertyName, menuName, menuDescription, choiceName, choiceDescription, option1Name, option1Price, option2Name, option2price;
                Users data = new Users();
                Random no = new Random();
                //Retrieve data from test Data
                Queries.GetActiveMemberEmail(data);
                username = data.email;
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                menuName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuName"), no.Next().ToString()); ;
                menuDescription = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");
                choiceName = TestData.ExcelData.TestDataReader.ReadData(1, "ChoiceName");
                choiceDescription = TestData.ExcelData.TestDataReader.ReadData(1, "ChoiceDesciption");
                option1Name = TestData.ExcelData.TestDataReader.ReadData(1, "Option1Name");
                option1Price = TestData.ExcelData.TestDataReader.ReadData(1, "Option1Price");
                option2Name = TestData.ExcelData.TestDataReader.ReadData(1, "Option2Name");
                option2price = TestData.ExcelData.TestDataReader.ReadData(1, "Option2Price");

                //Login to Cendyn Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoProperty(propertyName);

                //Navigate to Menu
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Breakfast drop-down should get clicked");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                Logger.WriteDebugMessage("Navigated to Menu Page");

                //Add Menu with the choices
                PropertyAdmin.Menu_WithChoices(menuName, menuDescription, choiceName, choiceDescription, option1Name, option1Price, option2Name, option2price);

                //View Menu on PDF Mode
                PropertyAdmin.Preview_PDF_View("Continental Breakfast", menuName);

                //Preview the Changes on Preview Page
                PropertyAdmin.Preview_Changes(menuName, choiceName, option1Name, option2Name);

                //Publish the changes
                Helper.SwitchToSpecificWindow("My Menus - eMenus");
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end and Verify the Added Menu with Choices
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigate to Home page");
                PropertyAdmin.VerifyBrkfastMenuonFrontend(menuName, choiceName, option1Name, option2Name);

                //Log test data into log file as well as extent report

                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end User-name", data.email);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Admin Username", propertyAdmin_Username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Description", menuDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Choice Name", choiceName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Choice Description", choiceDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_1 Name", option1Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_1 Price", option1Price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_2 Name", option2Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_2 Price", option2price, true);
            }
        }
        public static void TC_232899()
        {
            if (TestCaseId == Utility.Constants.TC_232899)
            {
                //Pre-Requisites
                string username, propertyAdmin_Username, password, propertyName, menuName, menuDescription, add_On_Title, add_On1_Name, add_On1_Description, add_On1_Price, add_On2_Name, add_On2_Description, add_On2_Price;
                Users data = new Users();
                Random no = new Random();
                //Retrieve data from test Data
                Queries.GetActiveMemberEmail(data);
                username = data.email;
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                menuName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuName"), no.Next().ToString()); ;
                menuDescription = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");
                add_On_Title = TestData.ExcelData.TestDataReader.ReadData(1, "Title");
                add_On1_Name = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On1_Name");
                add_On1_Description = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On1_Description");
                add_On1_Price = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On1_Price");
                add_On2_Name = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On2_Name");
                add_On2_Description = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On2_Description");
                add_On2_Price = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On2_Price");

                //Login to Cendyn Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoProperty(propertyName);

                //Navigate to Menu
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Breakfast drop-down should get clicked");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                Logger.WriteDebugMessage("Navigated to Menu Page");

                //Add Menu with Add on
                PropertyAdmin.Menu_WithAddOn(menuName, menuDescription, add_On_Title, add_On1_Name, add_On1_Description, add_On1_Price, add_On2_Name, add_On2_Description, add_On2_Price);

                //View Menu on PDF Mode
                PropertyAdmin.Preview_PDF_View("Continental Breakfast", menuName);

                //Preview the Changes on Preview Page
                PropertyAdmin.Preview_Changes(menuName, add_On_Title, add_On1_Name, add_On2_Name);

                //Publish the changes
                Helper.SwitchToSpecificWindow("My Menus - eMenus");
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end and Verify the Added Menu with Choices
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigate to Home page");
                PropertyAdmin.VerifyBrkfastMenuonFrontend(menuName, add_On_Title, add_On1_Name, add_On2_Name);

                //Log test data into log file as well as extent report

                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end User-name", data.email);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Admin Username", propertyAdmin_Username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Description", menuDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On Tile", add_On_Title);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 1 Name", add_On1_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 1 Description", add_On1_Description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add on 1 Price", add_On1_Price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 2 Name", add_On2_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 2 Description", add_On2_Description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add on 2 Price", add_On2_Price, true);
            }
        }
        public static void TC_232888()
        {
            if (TestCaseId == Utility.Constants.TC_232888)
            {
                //Pre-Requisite
                string password, propertyName, propertyAdmin_Username, email_validation,
                    password_validation, invalid_email_validation, invalid_password_validation, invalid_email, invalid_password;
                Users data = new Users();

                //Retrieve data from Test data
                Queries.GetActiveMemberEmail(data);
                password = ProjectDetails.CommonFrontendPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                email_validation = TestData.ExcelData.TestDataReader.ReadData(1, "EmailValidationMessage");
                password_validation = TestData.ExcelData.TestDataReader.ReadData(1, "PasswordValidationMessage");
                invalid_email_validation = TestData.ExcelData.TestDataReader.ReadData(1, "Invalid_Email_Validation");
                invalid_password_validation = TestData.ExcelData.TestDataReader.ReadData(1, "Invalid_Credential_Validation");
                invalid_email = TestData.ExcelData.TestDataReader.ReadData(1, "Invalid_Email");
                invalid_password = TestData.ExcelData.TestDataReader.ReadData(1, "Invalid_Password");

                //Open Catchall
                //Email.LogIntoCatchAll();
                //Logger.WriteDebugMessage("User should be Logged in Catchall Account");
                //Helper.OpenNewTab();
                //Helper.Driver.Url = ProjectDetails.CommonAdminURL;
                //Logger.WriteDebugMessage("Landed on Admin Login Page");

                //Click on Next button and verify the Validation for Email
                PropertyAdmin.Click_NextButton();
                Navigation.VerifyValidationMessage(PropertyAdmin.Validation_Message(), email_validation);

                //Enter invalid email and click Next to verify invalid email validation
                Helper.ReloadPage();
                PropertyAdmin.PropertyAdmin_Username(invalid_email);
                Logger.WriteDebugMessage("Entered Invalid Email id = " + invalid_email);
                PropertyAdmin.Click_NextButton();
                Navigation.VerifyValidationMessage(PropertyAdmin.Validation_Message(), invalid_email_validation);

                //Enter valid email and click Next to proceed
                PropertyAdmin.PropertyAdmin_Username(propertyAdmin_Username);
                Logger.WriteDebugMessage("Entered Valid Email id = " + propertyAdmin_Username);
                PropertyAdmin.Click_NextButton();
                Logger.WriteDebugMessage("User submits valid email and proceeds.");

                //Click on Login button and verify the Validation for Password
                PropertyAdmin.Click_LoginButton();
                Navigation.VerifyValidationMessage(PropertyAdmin.Validation_Message(), password_validation);

                //Enter invalid password and click Login to verify invalid email validation
                Helper.ReloadPage();
                PropertyAdmin.PropertyAdmin_Username(propertyAdmin_Username);
                Logger.WriteDebugMessage("Entered Valid Email id = " + propertyAdmin_Username);
                PropertyAdmin.Click_NextButton();
                PropertyAdmin.PropertyAdmin_Password(invalid_password);
                Logger.WriteDebugMessage("Entered InValid Password = " + invalid_password);
                PropertyAdmin.Click_LoginButton();
                VerifyTextOnPageAndHighLight(invalid_password_validation);

                //Login successfully
                Helper.ReloadPage();
                PropertyAdmin.PropertyAdmin_Username(propertyAdmin_Username);
                Logger.WriteDebugMessage("Entered Valid Email id = " + propertyAdmin_Username);
                PropertyAdmin.Click_NextButton();
                PropertyAdmin.PropertyAdmin_Password(password);
                Logger.WriteDebugMessage("Entered Valid Password = " + password);
                PropertyAdmin.Click_LoginButton();
                //Logger.WriteDebugMessage("Landed on Enter Verification Code Page");
                //Helper.ControlToPreviousWindow();
                //Email.CatchAll_SearchEmailAndOpenLatestMessage(propertyAdmin_Username);
                //Helper.AddDelay(10000);
                //Helper.ScrollToElement(PageObject_PropertyAdmin.GetVerificationCode());
                //string code = PropertyAdmin.GetVerificationCode();
                //Logger.WriteDebugMessage("Verification  Code = " + code + " Captured");
                //Helper.CloseCurrentTab();
                //Helper.ControlToNextWindow();
                //Logger.WriteDebugMessage("Landed on Admin Enter Verification Code Page");
                //PropertyAdmin.Propertyadmin_Verificationcode(code);
                //Logger.WriteDebugMessage("Verification Code is Entered");
                //PropertyAdmin.Click_LoginButton();
                //Logger.WriteDebugMessage("User should able to navigate to admin page");

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoProperty(propertyName);
                Logger.WriteDebugMessage("User was able to log in successfully.");


                //Log test data in Test data file
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Admin User", propertyAdmin_Username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Email Validation", email_validation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Invalid Email Validation", invalid_email_validation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password Validation", password_validation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Invalid Credential Validation", invalid_password_validation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Invalid Email", invalid_email);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Invalid Password", invalid_password, true);


            }
        }
        public static void TC_232889()
        {
            if (TestCaseId == Utility.Constants.TC_232889)
            {
                //Pre-Requisite
                string password, propertyName, propertyAdmin_Username;
                Users data = new Users();

                //Retrieve data from Test data
                Queries.GetActiveMemberEmail(data);
                password = ProjectDetails.CommonFrontendPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                propertyAdmin_Username = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyAdmin_Username");


                //Navigate to catchAll and Login to Cendyn Admin
                //PropertyAdmin.PropertyAdmin_SSO(propertyAdmin_Username, password);

                //Login to Cendyn Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoProperty(propertyName);

                //Check for options for utility nav
                PropertyAdmin.Click_Settings_Dropdown();

                for (int i = 0; i < 6; i++)
                {
                    //Stores expected navigation option
                    string navigationoption = TestData.ExcelData.TestDataReader.ReadData(i, "CendynAdmin_UtilityNav");
                    PropertyAdmin.VerifyUtilityNav(navigationoption);
                }

                Logger.WriteDebugMessage("All elements found in Utility Nav");
                PropertyAdmin.Click_Settings_Dropdown();

                //Logout
                PropertyAdmin.PropertyAdmin_LogOut();

                //Log test data in Test data file
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Admin User", propertyAdmin_Username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName, true);


            }
        }
        public static void TC_232890()
        {
            if (TestCaseId == Utility.Constants.TC_232890)
            {
                //pre-requisite   
                string username,password, propertyName, social_Media_Type, social_Media_Url, social_Media_Url_Edit, type_Vaidation, url_Validation, invalid_Url, invalid_Url_Validation;

                //Retrieve data from Test data
                username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonFrontendPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                social_Media_Type = TestData.ExcelData.TestDataReader.ReadData(1, "Social_Media_Type");
                social_Media_Url = TestData.ExcelData.TestDataReader.ReadData(1, "Social_Media_Url");
                social_Media_Url_Edit = TestData.ExcelData.TestDataReader.ReadData(1, "Social_Media_Url_Edit");
                type_Vaidation = TestData.ExcelData.TestDataReader.ReadData(1, "Type_Vaidation");
                url_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "Url_Validation");
                invalid_Url = TestData.ExcelData.TestDataReader.ReadData(1, "Invalid_Url");
                invalid_Url_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "InValid_Url_Validation");

                //Login to Cendyn Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoProperty(propertyName);

                //Navigate to Social Media Tab
                PropertyAdmin.Click_MyMenu_Settings();
                ElementWait(PageObject_PropertyAdmin.Click_Social_Media_Tab(), 30);
                Logger.WriteDebugMessage("Navigate to Advance settings page");
                PropertyAdmin.Click_Social_Media_Tab();
                ElementWait(PageObject_PropertyAdmin.Click_Add_New_Social_Media(), 30);
                Logger.WriteDebugMessage("Navigate to Social Media Page");

                //Required Fields Validation for Social Media Overlay
                PropertyAdmin.Social_Media_Validation(social_Media_Type, type_Vaidation, url_Validation, invalid_Url, invalid_Url_Validation);

                //Add new Social Media
                PropertyAdmin.Add_New_Social_Media(social_Media_Type, social_Media_Url);

                //Navigate to My Menus and Verify the Added Social Media
                PropertyAdmin.Click_MyMenus();
                Logger.WriteDebugMessage("Navigated to My Menu Page");
                Helper.EnterFrame("frontendEditorIframe");
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Social_Media(social_Media_Type));
                Logger.WriteDebugMessage("Added Social Media is displaying on the Admin");
                PropertyAdmin.Click_Social_Media(social_Media_Type);
                Helper.ExitFrame();
                Helper.ControlToNextWindow();
                if (social_Media_Url.Equals(Helper.Driver.Url))
                    Logger.WriteDebugMessage("Navigated to = " + social_Media_Type + " Social Media");
                else
                    Assert.Fail("Navigated to incorrect URL");
                CloseCurrentTab();

                //Navigate to Front-end and Verify the Social Media
                SwitchToSpecificWindow("My Menus - eMenus");
                PropertyAdmin.Click_PublishedView();
                ControlToNextWindow();
                Logger.WriteDebugMessage("Navigate to Front-end");
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Social_Media(social_Media_Type));
                Logger.WriteDebugMessage("Added Social Media is displaying on the Front-end");
                PropertyAdmin.Click_Social_Media(social_Media_Type);
                Helper.ControlToNextWindow();
                if (social_Media_Url.Equals(Helper.Driver.Url))
                    Logger.WriteDebugMessage("Navigated to = " + social_Media_Type + " Social Media");
                else
                    Assert.Fail("Navigated to incorrect URL");
                CloseCurrentTab();


                //Navigate back to Admin and Edit the Social Media
                PropertyAdmin.Click_MyMenu_Settings();
                ElementWait(PageObject_PropertyAdmin.Click_Social_Media_Tab(), 30);
                Logger.WriteDebugMessage("Navigate to Advance settings page");
                PropertyAdmin.Click_Social_Media_Tab();
                ElementWait(PageObject_PropertyAdmin.Click_Add_New_Social_Media(), 30);
                Logger.WriteDebugMessage("Navigate to Social Media Page");
                PropertyAdmin.Edit_Social_Media(social_Media_Type, social_Media_Url_Edit);

                //Navigate to My Menus and Verify the Edited Social Media
                PropertyAdmin.Click_MyMenus();
                Logger.WriteDebugMessage("Navigated to My Menu Page");
                Helper.EnterFrame("frontendEditorIframe");
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Social_Media(social_Media_Type));
                Logger.WriteDebugMessage("Added Social Media is displaying on the Admin");
                PropertyAdmin.Click_Social_Media(social_Media_Type);
                Helper.ExitFrame();
                Helper.ControlToNextWindow();
                if (social_Media_Url_Edit.Equals(Helper.Driver.Url))
                    Logger.WriteDebugMessage("Navigated to = " + social_Media_Type + " Social Media");
                else
                    Assert.Fail("Navigated to incorrect URL");
                CloseCurrentTab();

                //Navigate to Front-end and Verify the Edited Social Media
                ControlToNextWindow();
                Logger.WriteDebugMessage("Navigate to Front-end");
                Helper.ReloadPage();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Social_Media(social_Media_Type));
                Logger.WriteDebugMessage("Added Social Media is displaying on the Front-end");
                PropertyAdmin.Click_Social_Media(social_Media_Type);
                Helper.ControlToNextWindow();
                if (social_Media_Url_Edit.Equals(Helper.Driver.Url))
                    Logger.WriteDebugMessage("Navigated to = " + social_Media_Type + " Social Media");
                else
                    Assert.Fail("Navigated to incorrect URL");
                CloseCurrentTab();

                //Delete the Social Media and Verify the Social Media on Admin
                PropertyAdmin.Click_MyMenu_Settings();
                ElementWait(PageObject_PropertyAdmin.Click_Social_Media_Tab(), 30);
                Logger.WriteDebugMessage("Navigate to Advance settings page");
                PropertyAdmin.Click_Social_Media_Tab();
                ElementWait(PageObject_PropertyAdmin.Click_Add_New_Social_Media(), 30);
                Logger.WriteDebugMessage("Navigate to Social Media Page");
                PropertyAdmin.Delete_Social_Media(social_Media_Type);
                PropertyAdmin.Click_MyMenus();
                Helper.EnterFrame("frontendEditorIframe");
                PageDown();
                if (Helper.IsElementRemoved(social_Media_Type))
                    Assert.Fail(social_Media_Type + " Social Media is not get deleted");
                else
                    Logger.WriteDebugMessage(social_Media_Type + " Social Media got deleted successfully");
                Helper.ExitFrame();

                //Navigate to Front-end and Verify the Social Media
                ControlToNextWindow();
                Helper.ReloadPage();
                if (Helper.IsElementRemoved(social_Media_Type))
                    Assert.Fail(social_Media_Type + " Social Media is not get deleted");
                else
                    Logger.WriteDebugMessage(social_Media_Type + " Social Media got deleted successfully");

                //Log test data into log file as well as extent report

                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Admin User-name", ProjectDetails.CommonAdminEmail);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Admin Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Social Media Type", social_Media_Type);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Social Media URL", social_Media_Url);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Social Media Edited URL", social_Media_Url_Edit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Social Media Type Validation", type_Vaidation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Social Media URL Validation", url_Validation, true);
            }
        }
        public static void TC_232891()
        {
            if (TestCaseId == Utility.Constants.TC_232891)
            {
                //Pre-requisites
                string propertyAdmin_Username, password, propertyName, menuName, menuDescription, tagName;

                //Retrieve data from test data
                Random no = new Random();
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                menuName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuName"), no.Next().ToString());
                menuDescription = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");
                tagName = TestData.ExcelData.TestDataReader.ReadData(1, "TagName");

                //Login to Cendyn Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoProperty(propertyName);

                //Navigate to Settings
                PropertyAdmin.Click_MyMenu_Settings();
                Logger.WriteDebugMessage("Settings should get clicked");
                PropertyAdmin.Settings_MenuFilter_Tab();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Settings_MenuFilter_AddTag());
                Logger.WriteDebugMessage("Navigated on Menu Filter Page");

                //Add tag in Property Admin
                PropertyAdmin.Add_Tag(tagName);

                //Verify Added tag displayed in pop-up
                PropertyAdmin.Click_MyMenus();
                Logger.WriteDebugMessage("Navigated to my menu page");
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast Menus");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                Logger.WriteDebugMessage("Landed on Continental Breakfast page and Add New Menu button should get displayed");
                PropertyAdmin.Click_MyMenu_AddNewMenu();
                Logger.WriteDebugMessage("Add new menu modal should get displayed");
                Helper.ExitFrame();
                PropertyAdmin.AddNewMenu_MenuName(menuName);
                Helper.EnterFrame("cdescription_ifr");
                PropertyAdmin.AddNewMenu_AddChoice_Description("cdescription", menuDescription);
                Logger.WriteDebugMessage("Name and description should get entered");
                Helper.ExitFrame();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_AddNewMenu_AddedTag_Filter());
                Logger.WriteDebugMessage("Added tag should get displayed on filter section");
                PropertyAdmin.Click_AddNewMenu_AddedTag_Filter();
                Logger.WriteDebugMessage("Added tag should get selected");
                PropertyAdmin.Click_AddNewMenu_SaveButton();
                Helper.EnterFrame("frontendEditorIframe");
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Logger.WriteDebugMessage("Menu Got Added Successfully");
                Helper.ExitFrame();

                //View Menu on PDF Mode
                PropertyAdmin.Preview_PDF_View("Continental Breakfast", menuName);

                //Publish the Changes
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end and Verify the Added Tag
                PropertyAdmin.Click_PublishedView();
                ControlToNewWindow();
                Logger.WriteDebugMessage("Landed on eMenus Front-end");
                HomePage.HomePage_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast menu");
                HomePage.HomePage_Select_ContinentalBreakfast();
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Logger.WriteDebugMessage("Navigated to Continental Breakfast Sub-menu and Added Menu is displaying");
                HomePage.HomePage_ActionStations_MenuInfoButton();
                Logger.WriteDebugMessage("Clicked on Menu Info button");
                if (tagName.Equals(PropertyAdmin.Get_Menu_TagName(tagName)))
                {
                    Logger.WriteDebugMessage("Added Tag is Displaying on Front-end Page");
                }
                else
                    Assert.Fail("Added tag is not Displaying on Front-end Page");

                //Click on settings and delete tag
                SwitchToSpecificWindow("My Menus - eMenus");
                PropertyAdmin.Click_MyMenu_Settings();
                Logger.WriteDebugMessage("Settings should get clicked");
                PropertyAdmin.Settings_MenuFilter_Tab();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Settings_MenuFilter_AddTag());
                Logger.WriteDebugMessage("Navigated on Menu Filter Page");
                PropertyAdmin.Delete_Tag(tagName);

                //Verify added tag is deleted or not 
                PropertyAdmin.Click_MyMenus();
                Logger.WriteDebugMessage("My menu page should get displayed");
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast Menus");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                Logger.WriteDebugMessage("Landed on Continental Breakfast page and Add New Menu button should get displayed");
                PropertyAdmin.Click_MyMenu_AddNewMenu();
                Logger.WriteDebugMessage("Add new menu modal should get displayed");
                Helper.ExitFrame();
                Helper.ScrollToElement(PageObject_PropertyAdmin.Click_AddNewMenu_BottomSaveButton());
                if (Helper.IsElementRemoved(tagName))
                    Assert.Fail("Tag name displayed on the page");
                else
                    Logger.WriteDebugMessage("Added tag should get deleted and not displayed");


                //Verify the Tag on Front-end
                SwitchToSpecificWindow("Welcome to eMenus");
                ReloadPage();
                Logger.WriteDebugMessage("Landed on eMenus Front-end");
                HomePage.HomePage_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast menu");
                HomePage.HomePage_Select_ContinentalBreakfast();
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Logger.WriteDebugMessage("Navigated to Continental Breakfast Sub-menu and Added Menu is displaying");
                if (IsWebElementRemoved(PageObject_HomePage.HomePage_ActionStations_MenuInfoButton()))
                {
                    Logger.WriteDebugMessage("Added Tag is Removed from Front-end Page");
                }
                else
                    Assert.Fail("Added tag is not Removed from the Front-end Page");


                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_User-name", propertyAdmin_Username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Description", menuDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Tag Name", tagName, true);
            }
        }

        public static void TC_232897()
        {
            if (TestCaseId == Utility.Constants.TC_232897)
            {
                //Pre-Requisite
                string password, propertyName, propertyAdmin_Username, menuName, menuDescription, price, priceDescription;
                Random radno = new Random();

                //Retrieve data from Database or test data file
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonFrontendPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                menuName = String.Concat("Menu_", radno.Next().ToString());
                menuDescription = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");
                price = TestData.ExcelData.TestDataReader.ReadData(1, "Price");
                priceDescription = TestData.ExcelData.TestDataReader.ReadData(1, "PriceDescription");

                //Login to Cendyn Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoProperty(propertyName);

                //Navigate to My Menu Page and Add New Menu with Dynamic Price
                PropertyAdmin.Click_MyMenus();
                Logger.WriteDebugMessage("Navigated to My Menu Page");
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast Menu ");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                PropertyAdmin.AddNewMenuWithPrice(menuName, menuDescription, price, priceDescription);

                //View Menu on PDF Mode
                //PropertyAdmin.Preview_PDF_View("Continental Breakfast", menuName);

                //Verify the Price for added Menu
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast Menu ");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                if (Helper.IsWebElementRemoved(PageObject_PropertyAdmin.First_Menu_Price_Admin(menuName)))
                    Assert.Fail("Menu Price is Getting Displayed on Admin Page");
                else
                {
                    Logger.WriteDebugMessage("Menu Price is not Displaying on Admin Page");
                    VerifyTextOnPageAndHighLight(menuName);
                }
                Helper.ExitFrame();
                //Preview the changes and Verify the added Menu
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Sub-menu for Breakfast is Displaying");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Logger.WriteDebugMessage("Added Menu got displayed on Preview Page");
                if (Helper.IsWebElementRemoved(PageObject_PropertyAdmin.First_Menu_Price_Preview(menuName)))
                    Assert.Fail("Menu Price is Getting Displayed on Preview Page");
                else
                {
                    Logger.WriteDebugMessage("Menu Price is not Displaying on Preview Page");
                    VerifyTextOnPageAndHighLight(menuName);
                }

                CloseCurrentTab();

                //Publish the changes
                Helper.SwitchToSpecificWindow("My Menus - eMenus");
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end 
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigated to Front-end Site");


                //Navigate to Specific Menu
                HomePage.HomePage_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast menu");
                HomePage.HomePage_Select_ContinentalBreakfast();
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Logger.WriteDebugMessage("Navigated to Continental Breakfast Sub-menu and Added Menu is displaying");

                if (Helper.IsWebElementRemoved(PageObject_HomePage.First_Menu_Price_Frontend(menuName)))
                    Assert.Fail("Menu Price is Getting Displayed on Front-end Page");
                else
                {
                    Logger.WriteDebugMessage("Menu Price is not Displaying on Front-end Page");
                    VerifyTextOnPageAndHighLight(menuName);
                }

                //Log test data in Test data file
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Admin Username", propertyAdmin_Username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Login Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Description", menuDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Default Price", price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Default Price Description", priceDescription, true);

            }
        }
        public static void TC_232898()
        {
            if (TestCaseId == Utility.Constants.TC_232898)
            {
                //Pre-Requisite
                string password, propertyName, propertyAdmin_Username, menuName, menuDescription, price, priceDescription, menuprice;
                Random radno = new Random();

                //Retrieve data from Database or test data file
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonFrontendPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                menuName = String.Concat("Menu_", radno.Next().ToString());
                menuDescription = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");
                price = TestData.ExcelData.TestDataReader.ReadData(1, "Price");
                priceDescription = TestData.ExcelData.TestDataReader.ReadData(1, "PriceDescription");

                //Login to Cendyn Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoProperty(propertyName);

                //Navigate to My Menu Page and Add New Menu with Dynamic Price
                PropertyAdmin.Click_MyMenus();
                Logger.WriteDebugMessage("Navigated to My Menu Page");
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast Menu ");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                PropertyAdmin.AddNewMenuWithPrice(menuName, menuDescription, price, priceDescription);

                //View Menu on PDF Mode
                PropertyAdmin.Preview_PDF_View("Continental Breakfast", menuName);

                //Verify the Price for added Menu
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast Menu ");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                menuprice = PropertyAdmin.Get_Admin_Menu_Price(menuName);
                if (menuprice.Contains(price))
                    Logger.WriteDebugMessage("Default Price is getting Displayed on Admin Page");
                else
                    Assert.Fail("Default Price is not getting Displayed ");
                Helper.ExitFrame();

                //Preview the changes and Verify the added Menu
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Sub-menu for Breakfast is Displaying");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Logger.WriteDebugMessage("Added Menu got displayed on Preview Page");
                menuprice = PropertyAdmin.Get_Preview_Menu_Price(menuName);
                if (menuprice.Contains(price))
                    Logger.WriteDebugMessage("Default Price is getting Displayed on Admin Page");
                else
                    Assert.Fail("Default Price is not getting Displayed ");
                CloseCurrentTab();
                Helper.SwitchToSpecificWindow("My Menus - eMenus");

                //Publish the changes
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end 
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigated to Front-end Site");


                //Navigate to Specific Menu
                HomePage.HomePage_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast menu");
                HomePage.HomePage_Select_ContinentalBreakfast();
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Logger.WriteDebugMessage("Navigated to Continental Breakfast Sub-menu and Added Menu is displaying");
                menuprice = HomePage.First_Menu_Price_Frontend(menuName);
                if (menuprice.Contains(price))
                    Logger.WriteDebugMessage("Default Price is getting Displayed on Admin Page");

                else
                    Assert.Fail("Default Price is not getting Displayed ");

                //Log test data in Test data file
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Admin Username", propertyAdmin_Username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Login Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Description", menuDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Default Price", price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Default Price Description", priceDescription, true);

            }
        }
        public static void TC_232911()
        {
            if (TestCaseId == Utility.Constants.TC_232911)
            {
                //Pre-Requisites
                string propertyAdmin_Username, password, no, find, replace, propertyName, menuNameAddOns,
                    menuDescriptionAddOns, add_On_Title, add_On1_Name, add_On1_Description,
                    add_On1_Price, add_On2_Name, add_On2_Description, add_On2_Price, success, after;
                Random radno = new Random();
                //Retrieve data from test Data
                no = radno.Next().ToString();
                find = no;
                after = "_after";
                replace = no + after;

                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                success = TestData.ExcelData.TestDataReader.ReadData(1, "FindReplace_SuccessMessage");
                menuNameAddOns = TestData.ExcelData.TestDataReader.ReadData(1, "MenuNameAddOns") + find;
                menuDescriptionAddOns = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescriptionAddOns") + find;
                add_On_Title = TestData.ExcelData.TestDataReader.ReadData(1, "Title") + find;
                add_On1_Name = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On1_Name") + find;
                add_On1_Description = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On1_Description") + find;
                add_On1_Price = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On1_Price");
                add_On2_Name = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On2_Name") + find;
                add_On2_Description = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On2_Description") + find;
                add_On2_Price = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On2_Price");

                //Login to Cendyn Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoProperty(propertyName);

                //Navigate to Menu
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Breakfast drop-down should get clicked");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                Logger.WriteDebugMessage("Navigated to Menu Page");

                //Add Menu with Add on
                PropertyAdmin.Menu_WithAddOn(menuNameAddOns, menuDescriptionAddOns, add_On_Title, add_On1_Name, add_On1_Description, add_On1_Price, add_On2_Name, add_On2_Description, add_On2_Price);

                //View Menu on PDF Mode
                PropertyAdmin.Preview_PDF_View("Continental Breakfast", menuNameAddOns);

                //Perform Find and Replace
                PropertyAdmin.FindAndReplace(find, replace, success);
                Helper.AddDelay(5000);

                //Verify Find and Replace on Property Admin
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Breakfast drop-down should get clicked");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                Helper.ExitFrame();
                PropertyAdmin.VerifyFindAndReplace_PropertyAdmin(after, menuNameAddOns, menuDescriptionAddOns, add_On_Title, add_On1_Name, add_On1_Description, add_On2_Name, add_On2_Description);

                //Publish Changes
                PropertyAdmin.Publish_Changes();
                Helper.AddDelay(5000);

                //Navigate to Front-end and Verify the Added Menu with Choices
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigate to Home page");
                HomePage.HomePage_BreakfastDropdown();
                Logger.WriteDebugMessage("Sub-menu for Breakfast is Displaying");
                HomePage.HomePage_Select_ContinentalBreakfast();

                //Verify Find and Replace on Front End
                PropertyAdmin.VerifyFindAndReplace_FrontEnd(after, menuNameAddOns, menuDescriptionAddOns, add_On_Title, add_On1_Name, add_On1_Description, add_On2_Name, add_On2_Description);

                // Navigate to Back to Property Admin and Delete Newly Added Menu
                Helper.CloseCurrentTab();
                Helper.SwitchToSpecificWindow("My Menus - eMenus");
                Logger.WriteDebugMessage("Landed on Property Admin Page");
                PropertyAdmin.Delete_Menu(menuNameAddOns + after);

                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Admin User", propertyAdmin_Username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuNameAddOns);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Description", menuDescriptionAddOns);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On Tile", add_On_Title);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 1 Name", add_On1_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 1 Description", add_On1_Description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add on 1 Price", add_On1_Price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 2 Name", add_On2_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 2 Description", add_On2_Description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add on 2 Price", add_On2_Price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Find", find);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Replace", replace);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Find & Replace Success Message", success, true);

            }
        }
        public static void TC_232892()
        {
            if (TestCaseId == Utility.Constants.TC_232892)
            {
                //Pre-requisites
                string propertyAdmin_Username, password, propertyName, dynamicPriceName, startdate, enddate, startdate_edit, enddate_edit, lastaddedDynamicPrice, dynamic_Pricing_Name,
                   start_Date, end_Date, actions, add_New;

                //Retrieve data from test data
                Random randomNumber = new Random();
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                dynamicPriceName = String.Concat("DynamicPriceName_", randomNumber.Next().ToString());
                startdate = DateTime.Now.ToString("MM/dd/yyyy");
                enddate = DateTime.Now.AddDays(3).ToString("MM/dd/yyyy");
                startdate_edit = DateTime.Now.AddDays(3).ToString("MM/dd/yyyy");
                enddate_edit = DateTime.Now.AddDays(6).ToString("MM/dd/yyyy");
                dynamic_Pricing_Name = TestData.ExcelData.TestDataReader.ReadData(1, "Dynamic_Pricing_Name");
                start_Date = TestData.ExcelData.TestDataReader.ReadData(1, "Start_Date");
                end_Date = TestData.ExcelData.TestDataReader.ReadData(1, "End_Date");
                actions = TestData.ExcelData.TestDataReader.ReadData(1, "Actions");
                add_New = TestData.ExcelData.TestDataReader.ReadData(1, "Add_New");

                //Login to Cendyn Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoProperty(propertyName);

                //Click on dynamic pricing tab and verify dynamic pricing grid
                PropertyAdmin.Click_MyMenu_Settings();
                PropertyAdmin.Click_Settings_DynamicPricing();
                VerifyTextOnPageAndHighLight(dynamic_Pricing_Name);
                VerifyTextOnPageAndHighLight(start_Date);
                VerifyTextOnPageAndHighLight(end_Date);
                VerifyTextOnPageAndHighLight(actions);
                if (PageObject_PropertyAdmin.Click_DynamicPricing_AddNewButton().Displayed)
                    VerifyTextOnPageAndHighLight(add_New);
                else
                    Assert.Fail("Add new button is not present on the page");
                Logger.WriteDebugMessage("Dynamic pricing grid displayed on the page");

                //Search and Remove Existing Dynamic Pricing for Target Range
                PropertyAdmin.SearchAndRemoveDynamicPricing(startdate, enddate_edit);
               

                //Add Dynamic Price
                PropertyAdmin.AddNewDynamicPricing(dynamicPriceName, startdate, enddate);

                //Edit the Existing Dynamic Price
                PropertyAdmin.EditDynamicPricing(dynamicPriceName, startdate_edit, enddate_edit);

                //Delete the Added Dynamic Price
                PropertyAdmin.Delete_DyanamicPrice(dynamicPriceName);

                //Log test data into log file as well as extent report

                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_User-name", propertyAdmin_Username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Dynamic Price Name", dynamicPriceName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Dynamic Price Start Date", startdate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Dynamic Price End Date", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Dynamic Price Edited Start Date", startdate_edit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Dynamic Price Edited End Date", enddate_edit, true);
            }
        }
        public static void TC_232893()
        {
            if (TestCaseId == Utility.Constants.TC_232893)
            {
                //Pre-requisites
                string propertyAdmin_Username, password, propertyName, dynamicPriceName, startdate, enddate, menuName, price, priceDescription, dynamicPrice, dynamicPriceDescription;

                //Retrive data from test data
                Random randomNumber = new Random();
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                dynamicPriceName = String.Concat("DynamicPriceName_", randomNumber.Next().ToString());
                startdate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                enddate = DateTime.Now.AddDays(4).ToString("MM/dd/yyyy");
                menuName = String.Concat("Menu_", randomNumber.Next().ToString());
                price = TestData.ExcelData.TestDataReader.ReadData(1, "Price");
                priceDescription = TestData.ExcelData.TestDataReader.ReadData(1, "PriceDescription");
                dynamicPrice = TestData.ExcelData.TestDataReader.ReadData(1, "DynamicPrice");
                dynamicPriceDescription = TestData.ExcelData.TestDataReader.ReadData(1, "DynamicPriceDescription");

                //Login to Cendyn Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoProperty(propertyName);

                //Search and Remove Existing Dynamic Pricing for Target Range
                PropertyAdmin.SearchAndRemoveDynamicPricing(startdate, enddate);

                //Add Dynamic Price
                PropertyAdmin.Click_MyMenu_Settings();
                Logger.WriteDebugMessage("Landed on Settings Page");
                PropertyAdmin.Click_Settings_DynamicPricing();
                Logger.WriteDebugMessage("Landed on Dynamic Price Page");
                PropertyAdmin.AddNewDynamicPricing(dynamicPriceName, startdate, enddate);

                //Navigate to My Menu Page and Add New Menu with Dynamic Price
                PropertyAdmin.Click_MyMenus();
                Logger.WriteDebugMessage("Navigated to My Menu Page");
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast Menu ");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                PropertyAdmin.AddNewMenu(menuName, price, priceDescription, dynamicPrice, dynamicPriceDescription);

                //Verify the Menu in PDF View
                PropertyAdmin.Preview_PDF_View("Continental Breakfast", menuName);

                //Publish the changes
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end 
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigated to Front-end Site");

                //Navigate to Specific Menu
                HomePage.HomePage_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast menu");
                HomePage.HomePage_Select_ContinentalBreakfast();
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Logger.WriteDebugMessage("Navigated to Continental Breakfast Sub-menu and Added Menu is displaying");

                HomePage.Select_Event_date(enddate);

                //Verify the Display of Dynamic Price 
                AddDelay(10000);
                string menuPrice = HomePage.Get_Continental_Menu_Price(menuName);
                if (menuPrice.Contains(dynamicPrice) && menuPrice.Contains(dynamicPriceDescription))
                {
                    Logger.WriteDebugMessage("Dynamic Price is displaying for the Menu");
                }
                else
                {
                    Assert.Fail("Default Price is displaying for the Menu");
                }

                //Navigate Back to Prperty Admin and Delete the Dynamic Price
                Helper.SwitchToSpecificWindow("My Menus - eMenus");
                Logger.WriteDebugMessage("Navigate Back to Property Admin Page");
                PropertyAdmin.Delete_DyanamicPrice(dynamicPriceName);

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_User-name", propertyAdmin_Username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Dynamic Price Name", dynamicPriceName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Dynamic Price Start Date", startdate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Dynamic Price End Date", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Menu Name", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Default Price", price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Default Price Description", priceDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Dynamic Price", dynamicPrice);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Dynamic Price Description", dynamicPriceDescription, true);
            }
        }
        public static void TC_232894()
        {
            if (TestCaseId == Utility.Constants.TC_232894)
            {
                //Pre-requisites
                string propertyAdmin_Username, password, propertyName, passedDate_Name;

                //Retrive data from test data
                Random no = new Random();
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");

                //Login to Cendyn Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoProperty(propertyName);

                //Add tag and verify added tag is displayed under add/edit menu item popup for menu filters
                PropertyAdmin.Click_MyMenu_Settings();
                Logger.WriteDebugMessage("Navigated to Advance Setting Page");
                PropertyAdmin.Click_Settings_DynamicPricing();
                Logger.WriteDebugMessage("Navigated to Dynamic Pricing Page");

                passedDate_Name = PropertyAdmin.PassedDate_Name_DynamicPrice();
                Logger.WriteInfoMessage("Captured the Past Date Dynamic price = " + passedDate_Name);
                PropertyAdmin.Click_MyMenus();
                Logger.WriteDebugMessage("Navigated to My Menu Page");
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast Menu ");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                //PropertyAdmin.Click_MyMenu_EditMenu();
                PropertyAdmin.Click_MyMenu_AddNewMenu();
                ExitFrame();

                if (Helper.IsElementRemoved(passedDate_Name))
                    Assert.Fail("Dynamic price = " + passedDate_Name + " is displayed on the page");
                else
                    Logger.WriteDebugMessage("Dynamic price = " + passedDate_Name + " with passed date is not displayed on the page");
                PropertyAdmin.Click_AddNewMenu_CancelButton();
                Logger.WriteDebugMessage("Navigate back to My Menu Page");

                //Log test data into log file as well as extent report

                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_User-name", propertyAdmin_Username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName, true);
            }
        }
        public static void TC_232895()
        {
            if (TestCaseId == Utility.Constants.TC_232895)
            {
                //Pre-requisites
                string propertyAdmin_Username, password, propertyName, dynamicPriceName, startdate, enddate, menuName, price, priceDescription, dynamicPrice, dynamicPriceDescription;

                //Retrive data from test data
                Random randomNumber = new Random();
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                dynamicPriceName = String.Concat("DynamicPriceName_", randomNumber.Next().ToString());
                startdate = DateTime.Now.ToString("MM/dd/yyyy");
                enddate = DateTime.Now.AddDays(3).ToString("MM/dd/yyyy");
                menuName = String.Concat("Menu_", randomNumber.Next().ToString());
                price = TestData.ExcelData.TestDataReader.ReadData(1, "Price");
                priceDescription = TestData.ExcelData.TestDataReader.ReadData(1, "PriceDescription");
                dynamicPrice = TestData.ExcelData.TestDataReader.ReadData(1, "DynamicPrice");
                dynamicPriceDescription = TestData.ExcelData.TestDataReader.ReadData(1, "DynamicPriceDescription");

                //Login to Cendyn Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoProperty(propertyName);

                //Search and Remove Existing Dynamic Pricing for Target Range
                PropertyAdmin.Click_MyMenu_Settings();
                PropertyAdmin.Click_Settings_DynamicPricing();
                PropertyAdmin.SearchAndRemoveDynamicPricing(startdate, enddate);

                //Add Dynamic Price
                PropertyAdmin.AddNewDynamicPricing(dynamicPriceName, startdate, enddate);

                //Navigate to My Menu Page and Add New Menu with Dynamic Price
                PropertyAdmin.Click_MyMenus();
                Logger.WriteDebugMessage("Navigated to My Menu Page");
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast Menu ");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                PropertyAdmin.AddNewMenu(menuName, price, priceDescription, dynamicPrice, dynamicPriceDescription);

                //Verify the Menu in PDF View
                PropertyAdmin.Preview_PDF_View("Continental Breakfast", menuName);

                //Verify the Menu in Preview mode
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Sub-menu for Breakfast is Displaying");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Helper.VerifyTextOnPageAndHighLight(menuName);
                Helper.VerifyTextOnPageAndHighLight(dynamicPrice);
                Logger.WriteDebugMessage("Dynamic Price is displaying on Preview Page");
                CloseCurrentTab();
                Helper.SwitchToSpecificWindow("My Menus - eMenus");

                //Publish the changes
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end 
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigated to Front-end Site");

                //Navigate to Specific Menu
                HomePage.HomePage_BreakfastDropdown();
                Logger.WriteDebugMessage("Clicked on Breakfast menu");
                HomePage.HomePage_Select_ContinentalBreakfast();
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Logger.WriteDebugMessage("Navigated to Continental Breakfast Sub-menu and Added Menu is displaying");

                HomePage.Select_Event_date(startdate);

                //Verify the Display of Dynamic Price 
                AddDelay(10000);
                string menuPrice = HomePage.Get_Continental_Menu_Price(menuName);
                if (menuPrice.Contains(dynamicPrice) && menuPrice.Contains(dynamicPriceDescription))
                {
                    Logger.WriteDebugMessage("Dynamic Price = " + dynamicPrice + " is displaying for the Menu");
                }
                else
                {
                    Assert.Fail("Default Price = " + price + " is displaying for the Menu");
                }

                //Delete Dynamic Price
                Helper.SwitchToSpecificWindow("My Menus - eMenus");
                PropertyAdmin.Delete_DyanamicPrice(dynamicPriceName);

                //Log test data into log file as well as extent report

                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_User-name", propertyAdmin_Username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Password", password);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Dynamic Price Name", dynamicPriceName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Dynamic Price Start Date", startdate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Dynamic Price End Date", enddate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Menu Name", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Default Price", price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Default Price Description", priceDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Dynamic Price", dynamicPrice);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Dynamic Price Description", dynamicPriceDescription, true);
            }
        }
        public static void TC_232913()
        {
            if (TestCaseId == Utility.Constants.TC_232913)
            {
                //Pre-requisites
                string propertyAdmin_Username, password, propertyName, menuname, search_ClientName, firstName, lastName, companyName, email, messageContent, randomNumber, menuName1, menuName2, menuName3, email2;

                //Retrieve data from test data
                Random radNum = new Random();
                randomNumber = radNum.Next().ToString();
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                menuname = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuName"), randomNumber.Substring(0, 3));
                search_ClientName = TestData.ExcelData.TestDataReader.ReadData(1, "Search_ClientName");
                firstName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "First_Name"), randomNumber.Substring(0,3));
                lastName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Last_Name"), randomNumber.Substring(0, 3));
                companyName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Company_Name"), randomNumber.Substring(0, 3));
                email = String.Concat("Test_Share", randomNumber, "@cendyn17.com");
                menuName1 = TestData.ExcelData.TestDataReader.ReadData(1, "First_MenuName");
                menuName2 = TestData.ExcelData.TestDataReader.ReadData(1, "Second_MenuName");
                menuName3 = TestData.ExcelData.TestDataReader.ReadData(1, "Third_MenuName");

                //Login to Cendyn Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoProperty(propertyName);

                //Navigate to Share Menu Page
                PropertyAdmin.Click_Link_Share();
                Helper.ElementWait(PageObject_PropertyAdmin.Enter_ShareMenu_Name(), 60);
                Logger.WriteDebugMessage("Landed on Share Menu Page");

                //Enter Details on Set Up and Navigate to Choose Menu Page
                PropertyAdmin.Enter_ShareMenu_Name(menuname);
                PropertyAdmin.Check_Pricing_Checkbox();
                Logger.WriteDebugMessage("All Details are entered into Set Up Page ");
                PropertyAdmin.Click_Continue_Button();

                //Entered Details for Choose Menu Page and Navigate to Send Page
                PropertyAdmin.Check_Menu_For_Pages(menuName1);
                PropertyAdmin.Check_Menu_For_Pages(menuName2);
                Logger.WriteDebugMessage("Selected Menu Items on Choose Menu Page");
                DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Continue_Button());
                PropertyAdmin.Click_Continue_Button();
                Helper.ElementWait(PageObject_PropertyAdmin.Click_Search_Client_Button(), 60);
                Logger.WriteDebugMessage("Navigated on Send email Page");

                //Select the Existing Client and Verify the Name is displaying on Message Content
                PropertyAdmin.Search_Existing_Client(search_ClientName, firstName, lastName, companyName, email);
                Logger.WriteDebugMessage("Client got Displayed on the page");
                EnterFrame("textAreaContent_ifr");
                messageContent = PropertyAdmin.Share_Message_Content();
                ExitFrame();
                if (messageContent.Contains(search_ClientName) || messageContent.Contains(firstName))
                    Logger.WriteDebugMessage(" Client Name is Present on the Message content");
                else
                    Assert.Fail("Client Name is not displayed on the message content");

                //Verify the Preview Functionality and Send Email to Client
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Preview_Button());
                Logger.WriteDebugMessage("Preview Button got displayed");
                PropertyAdmin.Click_Preview_Button();
                ControlToNextWindow();
                Logger.WriteDebugMessage("Navigated to Preview Page");
                HomePage.Added_CategoryDropDown(menuName1);
                Logger.WriteDebugMessage("Clicked on "+menuName1+" Menu");
                HomePage.Added_CategoryDropDown(menuName2);
                Logger.WriteDebugMessage("Clicked on " + menuName2 + " Menu");
                CloseCurrentTab();
                Helper.SwitchToSpecificWindow("Share - eMenus");
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Send_Email());
                Logger.WriteDebugMessage("Send Button got displayed");
                PropertyAdmin.Click_Send_Email();
                Logger.WriteDebugMessage("Go To Activity Page button Overlay got Displayed");

                //Click on Goto Activity and Verify the Share Menu on the Activity Page
                PropertyAdmin.Click_GoToActivity_Button();
                Logger.WriteDebugMessage("Navigated to Activity Page");
                PropertyAdmin.Search_Menu_Filter(menuname);
                VerifyTextOnPageAndHighLight(menuname);
                Logger.WriteDebugMessage("Menu Name got Displayed");
                

                //Verify the Clone Functionality 
                PropertyAdmin.Click_Action_Button();
                Logger.WriteDebugMessage("Action Button got clicked");
                PropertyAdmin.Click_Clone_Link();
                Logger.WriteDebugMessage("Clone Confirmation Overlay got Displayed");
                PropertyAdmin.Click_Clone_Button();
                Logger.WriteDebugMessage("Navigated to Share Menu Page");
                PropertyAdmin.Enter_ShareMenu_Name(menuname+"_Clone");
                PropertyAdmin.Check_Format_Checkbox();
                Logger.WriteDebugMessage("All Details are entered into Clone Share Menu Page ");
                PropertyAdmin.Click_Continue_Button();

                //Entered Details for Choose Menu Page and Navigate to Send Page
                PropertyAdmin.Check_Menu_For_Pages(menuName3);
                Logger.WriteDebugMessage("Selected Menu Items on Choose Menu Page");
                PropertyAdmin.Click_Continue_Button();
                Helper.ElementWait(PageObject_PropertyAdmin.Click_Search_Client_Button(), 60);
                Logger.WriteDebugMessage("Navigated on Send email Page");

                //Add New Client and Search for the name in Message content
                email2 = String.Concat("Test_Share", randomNumber + 1, "@cendyn17.com");
                PropertyAdmin.Add_New_Client(firstName, lastName, companyName, email2);
                Helper.EnterFrame("textAreaContent_ifr");
                messageContent = PropertyAdmin.Share_Message_Content();
                Helper.ExitFrame();
                if (messageContent.Contains(search_ClientName) || messageContent.Contains(firstName))
                    Logger.WriteDebugMessage(" Client Name is Present on the Message content");
                else
                    Assert.Fail("Client Name is not displayed on the message content");
                
                //Sent Email to Client and verify the Clone Menu on Activity Page
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Send_Email());
                Logger.WriteDebugMessage("Send button is displayed");
                PropertyAdmin.Click_Send_Email();
                Helper.ElementWait(PageObject_PropertyAdmin.Click_GoToActivity_Button(), 60);
                Logger.WriteDebugMessage("Menu Email Send Successfully and Go to Activity Overlay got Displayed");
                PropertyAdmin.Click_GoToActivity_Button();
                Logger.WriteDebugMessage("Navigated to Activity Page");
                PropertyAdmin.Search_Menu_Filter(menuname+ "_Clone");
                VerifyTextOnPageAndHighLight(menuname+"_Clone");
                Logger.WriteDebugMessage("Menu Name got Displayed");

                //Navigate to CatchAll and Verify the email in catchAll
                Helper.OpenNewTab();
                Helper.ControlToNewWindow();
                Email.LogIntoCatchAll();
                Email.CatchAll_SearchEmailAndOpenLatestMessage(email2);
                ElementWait(PageObject_Email.Share_Menu_Email(), 60);
                Email.Click_Share_Menu_Link();
                ControlToNextWindow();
                Logger.WriteDebugMessage("Email got Displayed in CatchAll of Clone Share menu = " + menuname + "_Clone");
                
            }
        }
    }
}
