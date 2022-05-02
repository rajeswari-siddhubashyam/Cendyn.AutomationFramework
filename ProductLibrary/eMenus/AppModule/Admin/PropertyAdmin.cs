using System;
using System.Collections.Generic;
using AutoItX3Lib;
using System.Linq;
using BaseUtility.Utility;
using eMenus.AppModule.UI;
using eMenus.PageObject.Admin;
using eMenus.PageObject.UI;
using InfoMessageLogger;
using NUnit.Framework;
using OpenQA.Selenium;
using TestData;

namespace eMenus.AppModule.Admin
{
    class PropertyAdmin
    {
        public static void Click_Select_PropertyDropdown()
        {
            Helper.ElementWait(PageObject_PropertyAdmin.Click_Select_PropertyDropdown(),120);
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Select_PropertyDropdown());
        }
        public static void Select_Property(string value)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.Select_Property(), value);
        }
        public static void Click_uOrder()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_uOrder());
        }
        public static void Click_Uorder_Update_Contact()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Uorder_Update_Contact());
        }
        public static void uOrder_OrderSearchBox(string value)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.uOrder_OrderSearchBox(), value);
        }
        public static void PropertyAdmin_Username(string value)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.PropertyAdmin_Username(), value);
        }
        public static void PropertyAdmin_Password(string value)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.PropertyAdmin_Password(), value);
        }
        public static void Propertyadmin_Verificationcode(string value)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.Propertyadmin_Verificationcode(), value);
        }
        public static string GetVerificationCode()
        {
            return PageObject_PropertyAdmin.GetVerificationCode().GetAttribute("innerHTML");
        }
        public static void Click_BackButton()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_BackButton());
        }
        public static void Click_LoginButton()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_LoginButton());
        }
        public static void Click_NextButton()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_NextButton());
        }
        public static void Click_Prperty()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Prperty());
        }
        public static void Click_Navigation_eMenus()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_eMenus());
        }
        public static void Click_Navigation_ePlanner()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Navigation_ePlanner());
        }
        public static void Click_Navigation_eMenusLITE()
        {
            Helper.ElementWait(PageObject_PropertyAdmin.Click_eMenusLITE(), 120);
            Helper.ElementClick(PageObject_PropertyAdmin.Click_eMenusLITE());
        }
        public static void Click_Settings_Dropdown()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Settings_Dropdown());
        }
        public static void Click_Cendyn_Admin()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Cendyn_Admin());
        }
        public static void Click_Advance_Settings()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Advance_Settings());
        }
        public static void Click_Uorder_Contact()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Uorder_Contact());
        }
        public static void Click_Property_Dropdown()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Property_Dropdown());
        }
        public static void Select_Property_Dropdown(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_PropertyAdmin.Select_Property_Dropdown(), text);
        }
        public static void Enter_Property_TextBox(string hotel)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.Enter_Property_TextBox(), hotel);
        }
        public static void Click_Property_Origami()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Property_Origami());
        }


        public static void Click_PublishedView()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Published_View());
        }
        public static void Click_Home_Menu()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Home_Menu());
        }
        public static void Click_Home_Menu_eMenu()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Home_Menu_eMenu());
        }
        public static void Select_Price_Description(string value)
        {
            Helper.ElementSelectFromDropDown(PageObject_PropertyAdmin.Select_Price_Description(), value);
        }
        public static void Select_DynamicPrice_Description(string value)
        {
            Helper.ElementSelectFromDropDown(PageObject_PropertyAdmin.Select_DynamicPrice_Description(), value);
        }
        public static void Click_FindReplace()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_FindReplace());
        }
        public static void Click_FindReplace_Find()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_FindReplace_Find());
        }
        public static void Click_FindReplace_ReplaceAll()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_FindReplace_ReplaceAll());
        }
        public static void Click_FindReplace_Done()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_FindReplace_Done());
        }
        public static void VerifyUtilityNav(string option)
        {
            //Confirm option is found in nav
            Helper.VerifyTextOnPageAndHighLight(option);
        }
        public static void Click_Log_Out()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Log_Out());
        }
        public static void Click_Social_Media_Tab()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Social_Media_Tab());
        }
        public static void Click_Add_New_Social_Media()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Add_New_Social_Media());
        }
        public static void Select_Social_Media_Dropdown(string value)
        {
            Helper.ElementSelectFromDropDown(PageObject_PropertyAdmin.Select_Social_Media_Dropdown(), value);
        }
        public static void Edit_Social_Media_Dropdown(string value)
        {
            Helper.ElementSelectFromDropDown(PageObject_PropertyAdmin.Edit_Social_Media_Dropdown(), value);
        }
        public static string Get_Social_Media_Type_Validation()
        {
            return Helper.GetText(PageObject_PropertyAdmin.Social_Media_Type_Validation());
        }
        public static void Enter_Social_Media_URL(string value)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.Enter_Social_Media_URL(), value);
        }
        public static void Edit_Social_Media_URL(string value)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.Edit_Social_Media_URL(), value);
        }
        public static string Get_Social_Media_URL_Validation()
        {
            return Helper.GetText(PageObject_PropertyAdmin.Social_Media_URL_Validation());
        }
        public static void Click_Social_Media_Save_Changes()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Social_Media_Save_Changes());
        }
        public static void Click_Social_Media_Close()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Social_Media_Close());
        }
        public static void Click_Social_Media(string value)
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Social_Media(value));
        }
        public static void Click_OK_Button()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_OK_Button());
        }
        public static void Click_Yes_Button()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Yes_Button());
        }
        public static void Click_Edit_SocialMedia(string value)
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Edit_Social_Media(value));
        }
        public static void Click_Delete_SocialMedia(string value)
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Delete_Social_Media(value));
        }
        public static void Click_Admin_Social_Media(string value)
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Social_Media(value));
        }
        public static void PropertyAdmin_LogOut()
        {
            Click_Settings_Dropdown();
            Logger.WriteDebugMessage("Clicked on Setting Drop-down");
            //want to verify options 

            Click_Log_Out();
            Logger.WriteDebugMessage("Clicked on Log Out");
            Helper.VerifyTextOnPageAndHighLight("Sign In");
            Helper.VerifyTextOnPageAndHighLight("With Your Cendyn Account");
            Logger.WriteDebugMessage("User landed on Sign In page");
        }
        public static void Navigate_CendynAdmin()
        {
            Click_Settings_Dropdown();
            Logger.WriteDebugMessage("Clicked on Setting Drop-down");
            Click_Cendyn_Admin();
            Helper.ElementWait(PageObject_PropertyAdmin.Click_Advance_Settings(), 60);
            Logger.WriteDebugMessage("Navigated to Cendyn Admin Page");

        }
        public static void Navigate_CendynAdminLite()
        {
            Click_Settings_Dropdown();
            Logger.WriteDebugMessage("Clicked on Setting Drop-down");
            Click_Cendyn_Admin();
            Logger.WriteDebugMessage("Navigated to Cendyn Admin Page");

        }
        public static void VerifyContacts()
        {
            Click_Advance_Settings();
            Logger.WriteDebugMessage("Navigated on Advance Setting page");
            Helper.ScrollToElement(PageObject_PropertyAdmin.Click_Uorder_Contact());
            if (PageObject_PropertyAdmin.Click_Uorder_Contact().Selected)
                Logger.WriteDebugMessage("Contact page is displayed");
            else
            {
                Click_Uorder_Contact();
                Logger.WriteDebugMessage("Contact page is Selected");
                Click_Uorder_Update_Contact();
                Logger.WriteDebugMessage("Settings Updated Successfully");
            }

        }
        public static void NavigatetoProperty(string Property)
        {
            Helper.Driver.Url = ProjectDetails.CommonAdminURL;
            Logger.WriteDebugMessage("Landed on Select Product Page ");
            Click_Navigation_eMenus();
            Logger.WriteDebugMessage("eMenus Product got Selected ");
            Click_Select_PropertyDropdown();
            Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
            Enter_Property_TextBox(Property);
            Logger.WriteDebugMessage("Entered Property");
            Select_Property_Dropdown(Property);
            Logger.WriteDebugMessage(Property + " Property got Selected");
        }
        public static void ePlanner_NavigatetoProperty(string Property)
        {
            Helper.Driver.Url = ProjectDetails.CommonAdminURL;
            Click_Navigation_ePlanner();
            Logger.WriteDebugMessage("ePlanner Product got Selected ");
            Click_Select_PropertyDropdown();
            Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
            Enter_Property_TextBox(Property);
            Logger.WriteDebugMessage("Entered Property");
            Select_Property_Dropdown(Property);
            Logger.WriteDebugMessage(Property + " Property got Selected");
        }
        public static void NavigatetoPropertyLITE(string Property)
        {
            Helper.Driver.Url = ProjectDetails.CommonAdminURL;
            Logger.WriteDebugMessage("Landed on Select Product Page ");
            Click_Navigation_eMenusLITE();
            Logger.WriteDebugMessage("eMenus Lite Product got Selected ");
            Click_Select_PropertyDropdown();
            Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
            Enter_Property_TextBox(Property);
            Logger.WriteDebugMessage("Entered Property");
            Select_Property_Dropdown(Property);
            Logger.WriteDebugMessage(Property + " Property got Selected");
        }
        public static void PropertyAdmin_SSO(string username, string password)
        {
            Email.LogIntoCatchAll();
            Logger.WriteDebugMessage("User should be Logged in Catchall Account");
            Helper.OpenNewTab();
            Helper.Driver.Url = ProjectDetails.CommonAdminURL;
            Logger.WriteDebugMessage("Landed on Admin Login Page");
            PropertyAdmin_Username(username);
            Click_NextButton();
            PropertyAdmin.PropertyAdmin_Password(password);
            Logger.WriteDebugMessage("Entered Username =" + username + " and Password =" + password);
            Click_LoginButton();
            Logger.WriteDebugMessage("Landed on Enter Verification Code Page");
            Helper.ControlToPreviousWindow();

            //Check the Credentials email on Login Cendyn Access Folder
            Time.AddDelay(25000);
            Helper.DynamicScroll(Helper.Driver, PageObject_Email.Login_Cendyn_Access());
            Email.Login_Cendyn_Access();
            Helper.ReloadPage();
            Logger.WriteDebugMessage("Navigated to Login Cendyn Access Folder");
            Helper.ElementClick(PageObject_Email.CatchAll_Recent_Email());
            Logger.WriteDebugMessage("Opened Latest Email.");
            Helper.PageDown();
            
            //Capture the Verification Code
            Helper.ScrollToElement(PageObject_PropertyAdmin.GetVerificationCode());
            string code = PropertyAdmin.GetVerificationCode();
            Logger.WriteDebugMessage("Verification  Code = " + code + " Captured");
            Helper.ControlToNextWindow();
            Logger.WriteDebugMessage("Landed on Admin Enter Verification Code Page");
            PropertyAdmin.Propertyadmin_Verificationcode(code);
            Logger.WriteDebugMessage("Verification Code is Entered");
            Click_LoginButton();
            Logger.WriteDebugMessage("User should able to navigate to admin page");
        }
        public static void SwitchProperty(string propertyName)
        {
            //Navigate to Home Page and Select Property
            PropertyAdmin.Click_Select_PropertyDropdown();
            Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
            PropertyAdmin.Enter_Property_TextBox(propertyName);
            Logger.WriteDebugMessage("Entered Property");
            PropertyAdmin.Select_Property_Dropdown(propertyName);
            Logger.WriteDebugMessage(propertyName + " Property got Selected");
            Helper.AddDelay(9000);
        }
        public static void Click_MyMenu_Settings()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_MyMenu_Settings());
        }
        public static void Click_Settings_DynamicPricing()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Settings_DynamicPricing());
        }
        public static void Click_DynamicPricing_AddNewButton()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_DynamicPricing_AddNewButton());
        }
        public static void AddDynamicPricing_DynamicPricingName(string text)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.AddDynamicPricing_DynamicPricingName(), text);
        }
        public static void AddDynamicPricing_StartDate(string startdate)
        {
            Helper.ElementClick(PageObject_PropertyAdmin.AddDynamicPricing_StartDate());
            Helper.ElementEnterTextUsingJQuery(PageObject_PropertyAdmin.AddDynamicPricing_StartDate(), startdate);

        }
        public static void AddDynamicPricing_EndDate(string enddate)
        {
            Helper.ElementClick(PageObject_PropertyAdmin.AddDynamicPricing_EndDate());
            Helper.ElementEnterTextUsingJQuery(PageObject_PropertyAdmin.AddDynamicPricing_EndDate(), enddate);
            Helper.ElementClick(PageObject_PropertyAdmin.AddDynamicPricing_DynamicPricingName());
        }
        public static void EditDynamicPricing_StartDate(string startdate)
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Edit_DynamicPrice_StartDate());
            Helper.ElementEnterTextUsingJQuery(PageObject_PropertyAdmin.Edit_DynamicPrice_StartDate(), startdate);

        }
        public static void EditDynamicPricing_EndDate(string enddate)
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Edit_DynamicPrice_EndDate());
            Helper.ElementEnterTextUsingJQuery(PageObject_PropertyAdmin.Edit_DynamicPrice_EndDate(), enddate);
            Helper.ElementClick(PageObject_PropertyAdmin.EditDynamicPricing_DynamicPricingName());
        }
        public static void AddDynamicPricing_SaveChangesButton()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.AddDynamicPricing_SaveChangesButton());
        }
        public static void EditDynamicPricing_SaveChangesButton()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.EditDynamicPricing_SaveChangesButton());
        }
        public static void AddDynamicPricing_CancelButton()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.AddDynamicPricing_CancelButton());
        }
        public static void Click_AddDynamicPricing_OkButton()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_AddDynamicPricing_OkButton());
        }
        public static void Click_MyMenus()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_MyMenus());
        }
        public static string Recentlyadded_DynamicPrice()
        {
            IList<IWebElement> dynamicPriceList = Helper.Driver.FindElements(By.XPath("//*[@id='dynamicPricingTable']//tr/td[1]"));
            return dynamicPriceList.Last().GetAttribute("innerHTML");
        }
        public static void EditDynamicPricing(string value, string startdate, string enddate)
        {
            EditDynamicPrice(value);
            Logger.WriteDebugMessage("Edit Dynamic Price Overlay got displayed");
            EditDynamicPricing_StartDate(startdate);
            EditDynamicPricing_EndDate(enddate);
            Logger.WriteDebugMessage("Start Date and End dates are Updated");
            EditDynamicPricing_SaveChangesButton();
            Logger.WriteDebugMessage("Edit Dynamic Price Confirmation Overlay got Displayed");
            Click_AddDynamicPricing_OkButton();
            Helper.VerifyTextOnPageAndHighLight(value);
            Logger.WriteDebugMessage("Dynamic Price with data range is Edited Successfully");
        }
        public static void AddNewDynamicPricing(string value, string startdate, string enddate)
        {
            Click_DynamicPricing_AddNewButton();
            Logger.WriteDebugMessage("Add Dynamic Price Overlay got displayed");
            AddDynamicPricing_DynamicPricingName(value);
            AddDynamicPricing_StartDate(startdate);
            AddDynamicPricing_EndDate(enddate);
            Logger.WriteDebugMessage("Entered all Details");
            AddDynamicPricing_SaveChangesButton();
            Logger.WriteDebugMessage("Add Dynamic Price Confirmation Overlay got Displayed");
            Click_AddDynamicPricing_OkButton();
            Helper.VerifyTextOnPageAndHighLight(value);
            Logger.WriteDebugMessage("Dynamic Price with data range is added");
        }
        public static void Click_MyMenu_BreakfastDropdown()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_MyMenu_BreakfastDropdown());
        }
        public static void MyMenu_BreakfastDropdown_ContinentalBreakfast()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast());
        }
        public static void Click_MyMenu_AddNewMenu()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
        }
        public static void Click_AddNewMenu_CancelButton()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_AddNewMenu_CancelButton());
        }
        public static void Click_AddNewMenu_SaveButton()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_AddNewMenu_SaveButton());
        }
        public static void AddNewMenu_MenuName(string text)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.AddNewMenu_MenuName(), text);
        }
        public static void AddNewMenu_Price(string value)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.AddNewMenu_Price(), value);
        }
        public static void AddNewMenu_DynamiPrice(string value)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.AddNewMenu_DynamiPrice(), value);
        }
        public static void AddNewMenu_Description(string text)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.AddNewMenu_Description(), text);
        }
        public static void Click_Publish_Button()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Publish_Button());
        }
        public static void Click_Form_Publish_Button()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Form_Publish_Button());
        }
        public static void DynamicPricing_SaveChangesYesButton()
        {
            Helper.ElementWait(PageObject_PropertyAdmin.DynamicPricing_SaveChangesYesButton(), 120);
            Helper.ElementClick(PageObject_PropertyAdmin.DynamicPricing_SaveChangesYesButton());
        }
        public static void Click_MyMenu_EditMenu()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_MyMenu_EditMenu());
        }

        public static void AddNewMenu(string menuName, string price, string pricedescription, string dynamicPrice, string dynamicPriceDescription)
        {
            Click_MyMenu_AddNewMenu();
            Logger.WriteDebugMessage("Add Menu Popup got Displayed");
            Helper.ExitFrame();
            AddNewMenu_MenuName(menuName);
            AddNewMenu_Price(price);
            Select_Price_Description(pricedescription);
            AddNewMenu_DynamiPrice(dynamicPrice);
            Select_DynamicPrice_Description(dynamicPriceDescription);
            Logger.WriteDebugMessage("All the details are entered successfully");
            Click_AddNewMenu_SaveButton();
            Logger.WriteDebugMessage("Menu Confirmation Overlay is Displayed");
            DynamicPricing_SaveChangesYesButton();
            Helper.EnterFrame("frontendEditorIframe");
            Helper.VerifyTextOnPageAndHighLight(menuName);
            Helper.DynamicScrollToText(Helper.Driver, menuName);
            Logger.WriteDebugMessage("Menu added Successfully");
            Helper.ExitFrame();
        }
        public static void AddNewMenuWithPrice(string menuName, string menuDescription, string price, string pricedescription)
        {
            Click_MyMenu_AddNewMenu();
            Logger.WriteDebugMessage("Add Menu Popup got Displayed");
            Helper.ExitFrame();
            AddNewMenu_MenuName(menuName);
            Helper.EnterFrame("cdescription_ifr");
            AddNewMenu_AddChoice_Description("cdescription", menuDescription);
            Helper.ExitFrame();
            AddNewMenu_Price(price);
            Select_Price_Description(pricedescription);
            Logger.WriteDebugMessage("All the details are entered successfully");
            Click_AddNewMenu_SaveButton();
            Helper.EnterFrame("frontendEditorIframe");
            Helper.VerifyTextOnPageAndHighLight(menuName);
            Helper.DynamicScrollToText(Helper.Driver, menuName);
            Logger.WriteDebugMessage("Menu added Successfully");
            Helper.ExitFrame();
        }
        public static void EditMenu(string menuName, string price, string pricedescription, string dynamicPrice, string dynamicPriceDescription)
        {

            Logger.WriteDebugMessage("Edit Menu Popup got Displayed");
            Helper.ExitFrame();
            AddNewMenu_MenuName(menuName);
            AddNewMenu_Price(price);
            Select_Price_Description(pricedescription);
            AddNewMenu_DynamiPrice(dynamicPrice);
            Select_DynamicPrice_Description(dynamicPriceDescription);
            Logger.WriteDebugMessage("All the details are entered successfully");
            Click_AddNewMenu_SaveButton();
            Logger.WriteDebugMessage("Menu Confirmation Overlay is Displayed");
            if (Helper.VerifyTextOnPage("Description Alert"))
                 DynamicPricing_SaveChangesYesButton();
            Helper.EnterFrame("frontendEditorIframe");
            Helper.VerifyTextOnPageAndHighLight(menuName);
            Helper.DynamicScrollToText(Helper.Driver, menuName);
            Logger.WriteDebugMessage("Menu added Successfully");
            Helper.ExitFrame();
        }
        public static void Verify_DeleteMenu(string menuName, string price, string pricedescription, string dynamicPrice, string dynamicPriceDescription)
        {
            Click_MyMenu_EditMenu();
            Logger.WriteDebugMessage("Edit Menu Popup got Displayed");
            Helper.ExitFrame();
            AddNewMenu_MenuName(menuName);
            AddNewMenu_Price(price);
            Select_Price_Description(pricedescription);
            try
            {
                AddNewMenu_DynamiPrice(dynamicPrice);
                Assert.Fail("Dynamic Price field is Displaying");
            }
            catch
            {
                Logger.WriteDebugMessage("Dynamic Price field is not Displaying");
                Logger.WriteInfoMessage("Dynamic Price Description field is not Displaying");
            }

            Click_AddNewMenu_CancelButton();
            Logger.WriteDebugMessage("Navigate back to My Menu Page");

        }
        public static void Publish_Changes()
        {
            Click_Publish_Button();
            Logger.WriteDebugMessage("Changes are displaying on Overlay and Needs to Publish");
            Click_Form_Publish_Button();
            Helper.AddDelay(5000);
            if (Helper.VerifyTextOnPage("Success! You have successfully published your changes."))
            {
                Logger.WriteDebugMessage("Success message found on page");
            }
            else
            {
                Helper.AddDelay(6000);
                PropertyAdmin.VerifyPublishAll();
                Logger.WriteDebugMessage("Changes are Published successfully");
            }

        }

        public static void Delete_DyanamicPrice(string dynamicpriceName)
        {
            Click_MyMenu_Settings();
            Helper.ElementWait(PageObject_PropertyAdmin.Click_Settings_DynamicPricing(), 30);
            Logger.WriteDebugMessage("Navigate to Advance settings page");
            PropertyAdmin.Click_Settings_DynamicPricing();
            Helper.ElementWait(PageObject_PropertyAdmin.Click_DynamicPricing_AddNewButton(), 30);
            Logger.WriteDebugMessage("Navigate to Advance settings page");
            Helper.DynamicScrollToText(Helper.Driver, dynamicpriceName);
            DeleteDynamicPrice(dynamicpriceName);
            Logger.WriteDebugMessage("Delete Dynamic Price Overlay got Displayed");
            DeleteDynamicPriceConfirmation();
            Logger.WriteDebugMessage("Dynamic Price got deleted Confirmation Overlay");
            DeleteDynamicPriceConfirmation_OK();
            if (Helper.IsElementRemoved(dynamicpriceName))
                Assert.Fail(dynamicpriceName + " Dynamic Price is not get deleted");
            else
                Logger.WriteDebugMessage(dynamicpriceName + " Dynamic Price got deleted successfully");
        }
        public static void DeleteDynamicPrice(string name)
        {
            Helper.ElementClick(PageObject_PropertyAdmin.DynamicPricing_Delete_button(name));
        }
        public static void DeleteDynamicPriceConfirmation()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Delete_Dynamic_Price_Confirmation());
        }
        public static void DeleteDynamicPriceConfirmation_OK()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Delete_Dynamic_Price_Confirmation_OK());
        }
        public static void EditDynamicPrice(string name)
        {
            Helper.ElementClick(PageObject_PropertyAdmin.DynamicPricing_Edit_button(name));
        }
        public static string Existing_MenuPrice()
        {
            return Helper.GetText(PageObject_PropertyAdmin.Existing_MenuPrice());
        }

        public static void Click_AddNewMenu_AddChoiceButton()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_AddNewMenu_AddChoiceButton());
        }
        public static void AddNewMenu_AddChoice_Name(string text)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.AddNewMenu_AddChoice_Name(), text);
        }

        public static void AddNewMenu_AddChoice_Description(string dataId, string text)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.AddNewMenu_AddChoice_Description(dataId), text);
        }
        public static void Click_AddNewMenu_NewOptionButton()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_AddNewMenu_NewOptionButton());
        }
        public static void AddNewMenu_AddChoice_Option(string dataid, string text)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.AddNewMenu_AddChoice_Option(dataid), text);
        }
        public static void AddNewMenu_AddChoice_Price(string text)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.AddNewMenu_AddChoice_Price(), text);
        }
        public static void Click_AddNewMenu_NewOptionButton2()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_AddNewMenu_NewOptionButton2());
        }
        public static void AddNewMenu_AddChoice_Option2(string text)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.AddNewMenu_AddChoice_Option2(), text);
        }
        public static void AddNewMenu_AddChoice_Price2(string text)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.AddNewMenu_AddChoice_Price2(), text);
        }
        public static void Click_AddNewMenu_BottomSaveButton()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_AddNewMenu_BottomSaveButton());
        }


        public static void Click_MyMenu_PreviewButton()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_MyMenu_PreviewButton());
        }
        public static void Click_Preview_BreakfastDropdown()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Preview_BreakfastDropdown());
        }
        public static void Click_Preview_ContinentalBreakfast()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Preview_ContinentalBreakfast());
        }
        public static void Click_MyMenu_PublishButton()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_MyMenu_PublishButton());
        }
        public static void Click_MyMenu_PublishSaveButton()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_MyMenu_PublishSaveButton());
        }
        public static void Click_MyMenu_DeleteMenu(string menuName)
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_MyMenu_DeleteMenu(menuName));
        }
        public static void Click_MyMenu_DeleteMenu_Confirm()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_MyMenu_DeleteMenu_Confirm());
        }
        public static string GetFrameId(string no)
        {
            return PageObject_PropertyAdmin.GetDescriptionId_AddChoices(no).GetAttribute("id");
        }
        public static void Click_New_Add_On()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_New_Add_On());
        }
        public static void Enter_Add_On_Title(string title)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.Enter_Add_On_Title(), title);
        }
        public static void Enter_Add_On_Price1(string price)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.Enter_Add_On_Price1(), price);
        }
        public static void Enter_Add_On_Price2(string price)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.Enter_Add_On_Price2(), price);
        }
        public static string Validation_Message()
        {
            return Helper.GetText(PageObject_PropertyAdmin.Validation_Message());
        }
        public static void Click_Edit_Social_Media_Save_Changes()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Edit_Social_Media_Save_Changes());
        }

        public static void Enter_FindText(string find)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.Enter_FindText(), find);
        }
        public static void Enter_ReplaceText(string replace)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.Enter_ReplaceText(), replace);
        }
        public static void Menu_WithChoices(string menuName, string menuDescription, string choiceName, string choiceDescription, string option1Name, string option1price, string option2Name, string option2Price)
        {
            Click_MyMenu_AddNewMenu();
            Logger.WriteDebugMessage("Add new menu modal should get displayed");
            Helper.ExitFrame();
            AddNewMenu_MenuName(menuName);
            Helper.EnterFrame("cdescription_ifr");
            AddNewMenu_AddChoice_Description("cdescription", menuDescription);
            Logger.WriteDebugMessage("Name and description should get added");
            Helper.ExitFrame();

            //Add Specific Choice
            Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_AddNewMenu_AddChoiceButton());
            Click_AddNewMenu_AddChoiceButton();
            AddNewMenu_AddChoice_Name(choiceName);
            string desId = GetFrameId("2");
            Helper.EnterFrame(desId);
            AddNewMenu_AddChoice_Description(desId.Substring(0, 16), choiceDescription);
            Logger.WriteDebugMessage("Name and description should get added");
            Helper.ExitFrame();

            //Add First Option
            Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_AddNewMenu_NewOptionButton());
            Click_AddNewMenu_NewOptionButton();
            desId = GetFrameId("3");
            Helper.EnterFrame(desId);
            AddNewMenu_AddChoice_Option(desId.Substring(0, 16), option1Name);
            Helper.ExitFrame();
            AddNewMenu_AddChoice_Price(option1price);
            Logger.WriteDebugMessage("Entered the Choice First Option");

            //Add Second Option
            Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_AddNewMenu_NewOptionButton2());
            Click_AddNewMenu_NewOptionButton2();
            desId = GetFrameId("4");
            Helper.EnterFrame(desId);
            AddNewMenu_AddChoice_Option(desId.Substring(0, 16), option2Name);
            Helper.ExitFrame();
            AddNewMenu_AddChoice_Price2(option2Price);
            Logger.WriteDebugMessage("Entered the Choice Second Option");

            //Save the Details and Verify the Details on Property Admin
            Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_AddNewMenu_BottomSaveButton());
            Click_AddNewMenu_BottomSaveButton();
            Helper.EnterFrame("frontendEditorIframe");
            Helper.VerifyTextOnPageAndHighLight(menuName);
            Helper.VerifyTextOnPageAndHighLight(choiceName);
            Helper.VerifyTextOnPageAndHighLight(option1Name);
            Helper.VerifyTextOnPageAndHighLight(option2Name);
            Helper.DynamicScrollToText(Helper.Driver, menuName);
            Logger.WriteDebugMessage("Menu Added Successfully");
            Helper.ExitFrame();


        }
        public static void Preview_Changes(string Menu_Name, string choice_name, string option1, string option2)
        {
            Click_MyMenu_PreviewButton();
            Helper.ControlToNewWindow();
            Logger.WriteDebugMessage("Preview window should get displayed");
            Click_MyMenu_BreakfastDropdown();
            Logger.WriteDebugMessage("Sub-menu for Breakfast is Displaying");
            MyMenu_BreakfastDropdown_ContinentalBreakfast();
            Helper.VerifyTextOnPageAndHighLight(Menu_Name);
            Helper.VerifyTextOnPageAndHighLight(choice_name);
            Helper.VerifyTextOnPageAndHighLight(option1);
            Helper.VerifyTextOnPageAndHighLight(option2);
            Helper.DynamicScrollToText(Helper.Driver, Menu_Name);
            Logger.WriteDebugMessage("Entered Menu is Displaying");
            Helper.CloseWindow();
            Helper.ControlToPreviousWindow();
        }
        public static void VerifyBrkfastMenuonFrontend(string menuName, string menuChoice, string Option1, string Option2)
        {
            HomePage.HomePage_BreakfastDropdown();
            Logger.WriteDebugMessage("Sub-menu for Breakfast is Displaying");
            HomePage.HomePage_Select_ContinentalBreakfast();
            Helper.VerifyTextOnPageAndHighLight(menuName);
            Helper.VerifyTextOnPageAndHighLight(menuChoice);
            Helper.VerifyTextOnPageAndHighLight(Option1);
            Helper.VerifyTextOnPageAndHighLight(Option2);
            Helper.DynamicScrollToText(Helper.Driver, menuName);
            Logger.WriteDebugMessage("Add Menu  with Choice and Option is Displaying");
        }
        public static void Menu_WithAddOn(string menuName, string menuDescription, string Title, string add_On1_Name, string add_On1_Description, string add_On1_Price, string add_On2_Name, string add_On2_Description, string add_On2_Price)
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
            Click_MyMenu_AddNewMenu();
            Logger.WriteDebugMessage("Add new menu modal should get displayed");
            Helper.ExitFrame();
            AddNewMenu_MenuName(menuName);
            Helper.EnterFrame("cdescription_ifr");
            AddNewMenu_AddChoice_Description("cdescription", menuDescription);
            Logger.WriteDebugMessage("Name and description should get added");
            Helper.ExitFrame();

            //Enter Title
            Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Enter_Add_On_Title());
            Enter_Add_On_Title(Title);

            //Add 1st Add On 
            Click_New_Add_On();
            Logger.WriteDebugMessage("Clicked on Add New Add on button");
            string desId = GetFrameId("2");
            Helper.EnterFrame(desId);
            AddNewMenu_AddChoice_Description(desId.Substring(0, 14), add_On1_Name);
            Helper.ExitFrame();
            desId = GetFrameId("3");
            Helper.EnterFrame(desId);
            AddNewMenu_AddChoice_Description(desId.Substring(0, 20), add_On1_Description);
            Helper.ExitFrame();
            Enter_Add_On_Price1(add_On1_Price);
            Logger.WriteDebugMessage("Name, description  and Price should get added for 1st Add on");


            //Add 2nd Add On
            Click_New_Add_On();
            Logger.WriteDebugMessage("Clicked on Add New Add on button");
            desId = GetFrameId("4");
            Helper.EnterFrame(desId);
            AddNewMenu_AddChoice_Description(desId.Substring(0, 14), add_On2_Name);
            Helper.ExitFrame();
            desId = GetFrameId("5");
            Helper.EnterFrame(desId);
            AddNewMenu_AddChoice_Description(desId.Substring(0, 20), add_On2_Description);
            Helper.ExitFrame();
            Enter_Add_On_Price2(add_On2_Price);
            Logger.WriteDebugMessage("Name, description  and Price should get added for 2st Add on");


            //Save the Details and Verify the Details on Property Admin
            Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_AddNewMenu_BottomSaveButton());
            Click_AddNewMenu_BottomSaveButton();
            Helper.EnterFrame("frontendEditorIframe");
            Helper.ElementWait(PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu(), 60);
            Helper.VerifyTextOnPageAndHighLight(menuName);
            Helper.VerifyTextOnPageAndHighLight(Title);
            Helper.VerifyTextOnPageAndHighLight(add_On1_Name);
            Helper.VerifyTextOnPageAndHighLight(add_On2_Name);
            Helper.DynamicScrollToText(Helper.Driver, menuName);
            Logger.WriteDebugMessage("Menu Added Successfully");
            Helper.ExitFrame();
        }
        public static void FindAndReplace(string findText, string replaceText, string replaceSuccess)
        {

            Click_FindReplace();
            Logger.WriteDebugMessage("User landed on Find & Replace modal");
            Enter_FindText(findText);
            Enter_ReplaceText(replaceText);
            Logger.WriteDebugMessage("Text entered in Find and Replace fields");
            Click_FindReplace_Find();
            Click_FindReplace_ReplaceAll();
            Helper.AddDelay(1000);
            Helper.VerifyTextOnPage(replaceSuccess);
            Logger.WriteDebugMessage("Find and Replace was successful.");
            Click_FindReplace_Done();
        }

        public static void VerifyFindAndReplace_PropertyAdmin(string replaceText, string name, string desc, string title, string addon1, string addondesc1, string addon2, string addondesc2)
        {
            Helper.ScrollDown(0, 600);
            Helper.EnterFrame("frontendEditorIframe");
            Helper.VerifyTextOnPageAndHighLight(string.Concat(name + replaceText));
            Helper.VerifyTextOnPageAndHighLight(string.Concat(desc + replaceText));
            Helper.VerifyTextOnPageAndHighLight(string.Concat(title + replaceText));
            Helper.VerifyTextOnPageAndHighLight(string.Concat(addon1 + replaceText));
            Helper.VerifyTextOnPageAndHighLight(string.Concat(addondesc1 + replaceText));
            Helper.VerifyTextOnPageAndHighLight(string.Concat(addon2 + replaceText));
            Helper.VerifyTextOnPageAndHighLight(string.Concat(addondesc2 + replaceText));
            Logger.WriteDebugMessage("Name, Description, Title, and Add On details text were replaced successfully on Property Admin.");
            Helper.ExitFrame();
        }

        public static void VerifyFindAndReplace_FrontEnd(string replaceText, string name, string desc, string title, string addon1, string addondesc1, string addon2, string addondesc2)
        {
            Helper.ScrollDown(0, 2000);
            Helper.VerifyTextOnPageAndHighLight(string.Concat(name + replaceText));
            Helper.VerifyTextOnPageAndHighLight(string.Concat(desc + replaceText));
            Helper.VerifyTextOnPageAndHighLight(string.Concat(title + replaceText));
            Helper.VerifyTextOnPageAndHighLight(string.Concat(addon1 + replaceText));
            Helper.VerifyTextOnPageAndHighLight(string.Concat(addondesc1 + replaceText));
            Helper.VerifyTextOnPageAndHighLight(string.Concat(addon2 + replaceText));
            Helper.VerifyTextOnPageAndHighLight(string.Concat(addondesc2 + replaceText));
            Logger.WriteDebugMessage("Name, Description, Title, and Add On details text were replaced successfully on Front End.");
        }

        public static void Social_Media_Validation(string social_Type, string type_Validation, string url_Validation, string invalid_Url, string invalid_Url_Validation)
        {
            Click_Add_New_Social_Media();
            Logger.WriteDebugMessage("Add New Social Media Pop-up got Displayed");
            Click_Social_Media_Save_Changes();
            Navigation.VerifyValidationMessage(Get_Social_Media_Type_Validation(), type_Validation);
            Select_Social_Media_Dropdown(social_Type);
            Logger.WriteDebugMessage("Social Media is Selected from drop-down");
            Click_Social_Media_Save_Changes();
            Navigation.VerifyValidationMessage(Get_Social_Media_URL_Validation(), url_Validation);
            Enter_Social_Media_URL(invalid_Url);
            Click_Social_Media_Save_Changes();
            Navigation.VerifyValidationMessage(Get_Social_Media_URL_Validation(), invalid_Url_Validation);
            Click_Social_Media_Close();
            Logger.WriteDebugMessage("Landed back to Add Social Media Page");
        }

        public static void Add_New_Social_Media(string social_Type, string social_URL)
        {
            Click_Add_New_Social_Media();
            Logger.WriteDebugMessage("Add New Social Media Pop-up got Displayed");
            Select_Social_Media_Dropdown(social_Type);
            Enter_Social_Media_URL(social_URL);
            Logger.WriteDebugMessage("All the details are entered correctly");
            Click_Social_Media_Save_Changes();
            Helper.ElementWait(PageObject_PropertyAdmin.Click_OK_Button(), 30);
            Logger.WriteDebugMessage("Social Media Add confirmation overlay is displaying");
            Click_OK_Button();
            Helper.VerifyTextOnPageAndHighLight(social_Type);
            Logger.WriteDebugMessage("Social Media is added successfully on the page");
        }
        public static void Edit_Social_Media(string social_Type, string social_URL)
        {
            Click_Edit_SocialMedia(social_Type);
            Logger.WriteDebugMessage("Edit Social Media Pop-up got Displayed");
            Edit_Social_Media_Dropdown(social_Type);
            Edit_Social_Media_URL(social_URL);
            Logger.WriteDebugMessage("All the details are entered correctly");
            Click_Edit_Social_Media_Save_Changes();
            Helper.ElementWait(PageObject_PropertyAdmin.Click_OK_Button(), 30);
            Logger.WriteDebugMessage("Social Media Add confirmation overlay is displaying");
            Click_OK_Button();
            Helper.VerifyTextOnPageAndHighLight(social_Type);
            Logger.WriteDebugMessage("Social Media is Updated successfully on the page");
        }
        public static void Delete_Social_Media(string social_type)
        {
            Click_Delete_SocialMedia(social_type);
            Logger.WriteDebugMessage("Delete Social Media Overlay is got Displayed");
            Click_Yes_Button();
            Logger.WriteDebugMessage("Delete Social Media Confirmation Overlay is got Displayed");
            Click_OK_Button();
            if (Helper.IsElementRemoved(social_type))
                Assert.Fail(social_type + " Social Media is not get deleted");
            else
                Logger.WriteDebugMessage(social_type + " Social Media got deleted successfully");

        }
        public static void Settings_MenuFilter_Tab()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Settings_MenuFilter_Tab());
        }
        public static void Settings_MenuFilter_AddTag()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Settings_MenuFilter_AddTag());
        }
        public static void Settings_MenuFilter_AddTag_Name(string text)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.Settings_MenuFilter_AddTag_Name(), text);
        }
        public static void Settings_MenuFilter_AddTag_DeleteButton()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Settings_MenuFilter_AddTag_DeleteButton());
        }
        public static void Settings_MenuFilter_AddTag_SaveButton()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Settings_MenuFilter_AddTag_SaveButton());
        }
        public static void Click_AddNewMenu_AddedTag_Filter()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_AddNewMenu_AddedTag_Filter());
        }
        public static void Settings_MenuFilter_DeleteTag_ContinueButton()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Settings_MenuFilter_DeleteTag_ContinueButton());
        }
        public static void Click_Menu_Info_Button()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Menu_Info_Button());
        }
        public static string Get_Menu_TagName(string tagname)
        {
            return PageObject_PropertyAdmin.Menu_Tag_Name(tagname).GetAttribute("innerHTML");
        }
        public static string Get_Admin_Menu_Price(string menuname)
        {
            return PageObject_PropertyAdmin.First_Menu_Price_Admin(menuname).GetAttribute("innerHTML");
        }
        public static string Get_Preview_Menu_Price(string menuname)
        {
            return PageObject_PropertyAdmin.First_Menu_Price_Preview(menuname).GetAttribute("innerHTML");
        }
        public static void Add_Tag(string tagName)
        {
            //Add tag
            Settings_MenuFilter_AddTag();
            Settings_MenuFilter_AddTag_Name(tagName);
            Logger.WriteDebugMessage("Tag name should get entered");
            Settings_MenuFilter_AddTag_SaveButton();
            if (Helper.VerifyTextOnPage("Tag name already exists."))
            {
                Click_OK_Button();
                Settings_MenuFilter_AddTag_Name("REMOVE");
                Settings_MenuFilter_AddTag_DeleteButton();
                Logger.WriteDebugMessage("Tag already existed.");
                Settings_MenuFilter_AddTag_SaveButton();
                Click_OK_Button();
            }
            else
            {
                Logger.WriteDebugMessage("Tag save confirmation pop-up should get displayed");
                Click_OK_Button();
            }
            Logger.WriteDebugMessage("Tag Added Successfully");
            Helper.PageUp();

        }
        public static void Delete_Tag(string tagName)
        {

            Settings_MenuFilter_AddTag_DeleteButton();
            Logger.WriteDebugMessage("Continue deleting tag pop-up should get displayed");
            Settings_MenuFilter_DeleteTag_ContinueButton();
            Logger.WriteDebugMessage("Confirmation pop-up should displayed");
            Click_OK_Button();
            if (Helper.IsElementRemoved(tagName))
                Assert.Fail("Tag name displayed on the page");
            else
                Logger.WriteDebugMessage("Added tag should get deleted and not displayed");

        }
        public static void Delete_Menu(string menuName)

        {
            Helper.EnterFrame("frontendEditorIframe");
            Helper.ScrollDown(0, 2000);
            Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_DeleteMenu(menuName));
            Click_MyMenu_DeleteMenu(menuName);
            Logger.WriteDebugMessage("Delete Menu Pop-Up Got Displayed");
            Helper.ExitFrame();
            Helper.VerifyTextOnPageAndHighLight("Are you sure about this?");
            Click_MyMenu_DeleteMenu_Confirm();
            Helper.AddDelay(5000);

            //Verify menu got deleted
            Helper.EnterFrame("frontendEditorIframe");
            Helper.ScrollDown(0, 2000);
            Helper.VerifyTextNOTOnPage(menuName);
            Logger.WriteDebugMessage("Menu got deleted.");

        }
        public static void Click_Main_Navigation_Dropdown()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Main_Navigation_Dropdown());
        }
        public static void Click_Navigation_Dropdown_Value(string value)
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Navigation_Dropdown_Value(value));
        }
        public static void Click_Link_PDF_View()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Link_PDF_View());
        }
        public static void Click_Link_Web_View()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Link_Web_View());
        }
        public static void Preview_PDF_View(string caterogyName, string menuName)
        {
            Click_Link_PDF_View();
            Logger.WriteDebugMessage("PDF View is displayed");
            Helper.EnterFrame("frontendEditorIframe");
            Helper.VerifyTextOnPageAndHighLight(caterogyName);
            Helper.VerifyTextOnPageAndHighLight(menuName);
            Helper.DynamicScrollToText(Helper.Driver, menuName);
            Logger.WriteDebugMessage("Menu Name is Displaying on PDF View");
            Helper.ExitFrame();
            Click_Link_Web_View();
            Logger.WriteDebugMessage("Navigated back to Web View");
        }
        public static string PassedDate_Name_DynamicPrice()
        {
            return PageObject_PropertyAdmin.PassedDate_Name_DynamicPrice().GetAttribute("innerHTML");
        }
        public static void Click_Link_Share()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Link_Share());
        }
        public static void Enter_ShareMenu_Name(string value)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.Enter_ShareMenu_Name(), value);
        }
        public static void Check_Format_Checkbox()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Check_Format_Checkbox());
        }
        public static void Check_Pricing_Checkbox()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Check_Pricing_Checkbox());
        }
        public static void Click_Continue_Button()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Continue_Button());
        }
        public static void Check_Menu_For_Pages(string value)
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Check_Menu_For_Pages(value));
        }
        public static void Click_Search_Client_Button()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Search_Client_Button());
        }
        public static void Enter_Search_Client_Name(string value)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.Enter_Search_Client_Name(), value);
        }
        public static void Click_SearchOverlay_Client_Button()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_SearchOverlay_Client_Button());
        }
        public static void Select_Searched_Client_Record()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Select_Searched_Client_Record());
        }
        public static void Cancel_Search_Client()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Cancel_Search_Client());
        }
        
        public static string Share_Message_Content()
        {
            return PageObject_PropertyAdmin.Share_Message_Content().GetAttribute("innerHTML");
        }
        public static void Click_Send_Email()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Send_Email());
        }
        public static void Click_GoToActivity_Button()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_GoToActivity_Button());
        }
        public static void Search_Menu_Filter(string value)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.Search_Menu_Filter(), value);
        }
        public static void Click_Action_Button()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Action_Button());
        }
        public static void Click_Clone_Link()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Clone_Link());
        }
        public static void Click_Clone_Button()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Clone_Button());
        }
        public static void Click_Add_New_Client()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Add_New_Client());
        }
        public static void Enter_Client_First_Name(string value)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.Enter_Client_First_Name(), value);
        }
        public static void Enter_Client_Last_Name(string value)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.Enter_Client_Last_Name(), value);
        }
        public static void Enter_Client_Company(string value)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.Enter_Client_Company(), value);
        }
        public static void Enter_Client_Email(string value)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.Enter_Client_Email(), value);
        }
        public static void Click_Save_Button()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Save_Save());
        }
        public static void Add_New_Client(string firstName, string lastName, string companyName, string email)
        {
            Click_Add_New_Client();
            Logger.WriteDebugMessage("Add New Client Overlay got Displayed");
            Enter_Client_First_Name(firstName);
            Enter_Client_Last_Name(lastName);
            Enter_Client_Company(companyName);
            Enter_Client_Email(email);
            Logger.WriteDebugMessage("All the Details are Entered successfully");
            Click_Save_Button();
            Logger.WriteDebugMessage("New Client got Added Successfully");
        }
        public static void Search_Existing_Client(string clientName, string firstName, string lastName, string companyName, string email)
        {
            Click_Search_Client_Button();
            Logger.WriteDebugMessage("Search Existing Client Overlay got Displayed");
            Enter_Search_Client_Name(clientName);
            Logger.WriteDebugMessage("Entered Name of the client");
            Click_SearchOverlay_Client_Button();
            if (Helper.IsElementDisplayed(PageObject_PropertyAdmin.Select_Searched_Client_Record()))
            {
                Logger.WriteDebugMessage("Searched Client got displayed on the Page");
                Select_Searched_Client_Record();
            }
            else
            {
                Cancel_Search_Client();
                Logger.WriteDebugMessage("Client is not present in database");
                Add_New_Client(firstName, lastName, companyName, email);
            }
        }
        public static void Click_Generate_Link()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Generate_Link());
        }
        public static string Get_ShareMenu_Link()
        {
            return PageObject_PropertyAdmin.Get_ShareMenu_Link().GetAttribute("href");
        }
        public static void Click_Preview_Button()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Preview_Button());
        }
        public static void Click_Menu_FoodAndBeverages()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Menu_FoodAndBeverages());
        }
        public static void Click_Category_Sub_Menu(string menuName)
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Category_Sub_Menu(menuName));
        }
        public static void Click_Added_Category_Menu()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Added_Category_Menu());
        }
        
        public static void Click_Button_Add_Item()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Button_Add_Item());
        }
        public static void Click_Button_Save()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Button_Save());
        }
        public static void Enter_Text_Title(string value)
        {
            PageObject_PropertyAdmin.Enter_Text_Title().Clear();
            Helper.ElementEnterText(PageObject_PropertyAdmin.Enter_Text_Title(), value);
        }
        public static void AddItem_Title_Description(string title, string description)
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Button_Add_Item());
            Logger.WriteDebugMessage("Landed on Add Item Page");
            Click_Button_Add_Item();
            Logger.WriteDebugMessage("Add New Item Overlay got Open");
            Helper.ExitFrame();
            Enter_Text_Title(title);
            Helper.EnterFrame("cdescription_ifr");
            AddNewMenu_AddChoice_Description("cdescription", description);
            Helper.ExitFrame();
            Logger.WriteDebugMessage("Title and Description are added successfully");
            Click_Button_Save();
            Helper.EnterFrame("frontendEditorIframe");
            Helper.VerifyTextOnPageAndHighLight(title);
            Helper.DynamicScrollToText(Helper.Driver, title);
            Logger.WriteDebugMessage("Item got added successfully");
            Helper.ExitFrame();
        }
        public static void Click_Button_Delete()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Button_Delete());
        }
        public static void Click_Icon_Delete()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Icon_Delete());
        }
        public static void Delete_Item(string titlename)
        {
            Helper.EnterFrame("frontendEditorIframe");
            Helper.DynamicScrollToText(Helper.Driver, titlename);
            Logger.WriteDebugMessage("Added Menu got displayed on Property Admin Page for Delete");
            Helper.HoverOverText(titlename);
            Click_Icon_Delete();
            Logger.WriteDebugMessage("Clicked on Delete Icon for Item = "+ titlename);
            Helper.ExitFrame();
            Click_Button_Delete();
            Helper.AddDelay(3000);
            Helper.EnterFrame("frontendEditorIframe");
            if (Helper.IsElementRemoved(titlename))
                Assert.Fail("Title = "+titlename+" is not got deleted");
            else
                Logger.WriteDebugMessage("Title = "+titlename+" got deleted successfully");
            Helper.ExitFrame();
            Publish_Changes();
        }
        public static void Click_AddNewMenu_AddChoiceButton2()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_AddNewMenu_AddChoiceButton2());
        }
        public static void AddNewMenu_AddChoice2_Name(string text)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.AddNewMenu_AddChoice2_Name(), text);
        }
        public static void Click_AddNewMenu2_NewOptionButton()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_AddNewMenu2_NewOptionButton());
        }
        public static void Click_ChoiceMoveUp_Button()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_ChoiceMoveUp_Button());
        }
        public static void Click_Button_UploadFromeGallery()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Button_UploadFromeGallery());
        }
        public static void Click_Image_eGallery()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Image_eGallery());
        }
        public static void Click_Button_SelectImage()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Button_SelectImage());
        }
        public static void Click_Item_Image(string title)
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Item_Image(title));
        }
        
        public static void AddItem_Image_eGallery(string title, string description)
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Button_Add_Item());
            Logger.WriteDebugMessage("Landed on Add Item Page");
            Click_Button_Add_Item();
            Logger.WriteDebugMessage("Add New Item Overlay got Open");
            Helper.ExitFrame();
            Enter_Text_Title(title);
            Helper.EnterFrame("cdescription_ifr");
            AddNewMenu_AddChoice_Description("cdescription", description);
            Helper.ExitFrame();
            Logger.WriteDebugMessage("Title and Description are added successfully");
            Click_Button_UploadFromeGallery();
            Helper.ControlToNextWindow();
            Logger.WriteDebugMessage("Landed on eGallery");
            Click_Image_eGallery();
            Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Button_SelectImage());
            Logger.WriteDebugMessage("Image got Selected from eGallery");
            Click_Button_SelectImage();
            Helper.ControlToPreviousWindow();
            Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Button_UploadFromeGallery());
            Logger.WriteDebugMessage("Image got Successfully Updated in Add Item Overlay");
            Click_Button_Save();
            Helper.EnterFrame("frontendEditorIframe");
            Helper.VerifyTextOnPageAndHighLight(title);
            Helper.DynamicScrollToText(Helper.Driver, title);
            Logger.WriteDebugMessage("Item got added successfully");
            Helper.ExitFrame();
        }
        public static void Click_Upload_Image()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Upload_Image());
        }
        public static void Click_Select_File()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Select_File());
        }
        public static void Click_Upload_File()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Upload_File());
        }
        public static void Click_Image_File()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Image_File());
        }
        
        public static void AddItem_Image_Upload(string title, string description, string imagePath)
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Button_Add_Item());
            Logger.WriteDebugMessage("Landed on Add Item Page");
            Click_Button_Add_Item();
            Logger.WriteDebugMessage("Add New Item Overlay got Open");
            Helper.ExitFrame();
            Enter_Text_Title(title);
            Helper.EnterFrame("cdescription_ifr");
            AddNewMenu_AddChoice_Description("cdescription", description);
            Helper.ExitFrame();
            Logger.WriteDebugMessage("Title and Description are added successfully");
            Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Upload_Image());
            Click_Upload_Image();
            UploadImage(imagePath);
            Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Button_UploadFromeGallery());
            Logger.WriteDebugMessage("Image Uploaded Successfully");
            Click_Button_Save();
            Helper.EnterFrame("frontendEditorIframe");
            Helper.VerifyTextOnPageAndHighLight(title);
            Helper.DynamicScrollToText(Helper.Driver, title);
            Logger.WriteDebugMessage("Item got added successfully");
            Helper.ExitFrame();
        }

        public static void UploadImage(string location)
        {
            Logger.WriteDebugMessage("File Upload Box got Opened");
            Helper.AddDelay(2500);
            AutoItX3 AutoIt = new AutoItX3();
            AutoIt.WinActivate("Open");
            Helper.AddDelay(2000);
            AutoIt.Send(location);
            Helper.AddDelay(3000);
            AutoIt.Send("{ENTER}");
            Helper.AddDelay(5000);
        }

        public static void AddItem_File_Upload(string title, string description, string imagePath)
        {
            Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Button_Add_Item());
            Logger.WriteDebugMessage("Landed on Add Item Page");
            Click_Button_Add_Item();
            Logger.WriteDebugMessage("Add New Item Overlay got Open");
            Helper.ExitFrame();
            Enter_Text_Title(title);
            Helper.EnterFrame("cdescription_ifr");
            AddNewMenu_AddChoice_Description("cdescription", description);
            Helper.ExitFrame();
            Logger.WriteDebugMessage("Title and Description are added successfully");
            Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Upload_Image());
            Click_Select_File();
            UploadImage(imagePath);
            Logger.WriteDebugMessage("File got Selected Successfully");
            Click_Upload_File();
            Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Button_UploadFromeGallery());
            Logger.WriteDebugMessage("Image Uploaded Successfully");
            Click_Button_Save();
            Helper.EnterFrame("frontendEditorIframe");
            Helper.VerifyTextOnPageAndHighLight(title);
            Helper.DynamicScrollToText(Helper.Driver, title);
            Logger.WriteDebugMessage("Item got added successfully");
            Helper.ExitFrame();
        }
        public static void Click_MyMenu_Breaks()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_MyMenu_Breaks());
        }
        public static void Click_EditCategoryDesc()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_EditCategoryDesc());
        }
        public static void Click_CategoryDesc_Save()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_CategoryDesc_Save());
        }
        public static void CategoryDesc_Edit(string text)
        {
            Helper.EnterFrame("description_ifr");
            // Helper.ElementClearText(PageObject_PropertyAdmin.CategoryDesc());
            Helper.ElementEnterText(PageObject_PropertyAdmin.CategoryDesc(), text);
            Logger.WriteDebugMessage("Category Description name has been entered.");
            Helper.ExitFrame();
        }
        public static void editCategoryDesc(string categoryDesc)
        {
            Click_EditCategoryDesc();
            Helper.ExitFrame();
            Helper.VerifyTextOnPageAndHighLight("Edit Category Description");
            Logger.WriteDebugMessage("User lands on the Edit Category Description modal.");

            CategoryDesc_Edit(categoryDesc);
            Click_CategoryDesc_Save();
            Helper.AddDelay(5000);
            Helper.VerifyTextNOTOnPage("Edit Category Description");
            Logger.WriteDebugMessage("Category Description saved.");
            Helper.EnterFrame("frontendEditorIframe");
            Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_EditCategoryDesc());
            Helper.VerifyTextOnPageAndHighLight(categoryDesc);
        }

        public static void EditMenuChoices(string menuName, string menuDescription, string choiceName, string choiceDescription, string option1Name, string option1price, string option2Name, string option2Price)
        {
            Logger.WriteDebugMessage("Edit Menu Popup got Displayed");
            Helper.ExitFrame();
            AddNewMenu_MenuName(menuName);
            Helper.EnterFrame("cdescription_ifr");
            AddNewMenu_AddChoice_Description("cdescription", menuDescription);
            Logger.WriteDebugMessage("Name and description should get added");
            Helper.ExitFrame();

            //Edit Specific Choice
            Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_AddNewMenu_AddChoiceButton());
            AddNewMenu_AddChoice_Name(choiceName);
            string desId = GetFrameId("2");
            Helper.EnterFrame(desId);
            AddNewMenu_AddChoice_Description(desId.Substring(0, 16), choiceDescription);
            Logger.WriteDebugMessage("Name and description should get added");
            Helper.ExitFrame();

            //Edot First Option
            Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_AddNewMenu_NewOptionButton());
            desId = GetFrameId("3");
            Helper.EnterFrame(desId);
            AddNewMenu_AddChoice_Option(desId.Substring(0, 16), option1Name);
            Helper.ExitFrame();
            AddNewMenu_AddChoice_Price(option1price);
            Logger.WriteDebugMessage("Entered the Choice First Option");

            //Edit Second Option
            Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_AddNewMenu_NewOptionButton2());
            desId = GetFrameId("4");
            Helper.EnterFrame(desId);
            AddNewMenu_AddChoice_Option(desId.Substring(0, 16), option2Name);
            Helper.ExitFrame();
            AddNewMenu_AddChoice_Price2(option2Price);
            Logger.WriteDebugMessage("Entered the Choice Second Option");

            //Add Menu Filters
            Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Filter_GlutenFree());
            Click_Filter_GlutenFree();
            Click_Filter_MilkAvoidance();
            Click_Tag_MostPopular();
            Logger.WriteDebugMessage("Filters were added.");

            //Save the Details and Verify the Details on Property Admin
            Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_AddNewMenu_BottomSaveButton());
            Click_AddNewMenu_BottomSaveButton();
            Helper.EnterFrame("frontendEditorIframe");
            Helper.VerifyTextOnPageAndHighLight(menuName);
            Helper.VerifyTextOnPageAndHighLight(choiceName);
            Helper.VerifyTextOnPageAndHighLight(option1Name);
            Helper.VerifyTextOnPageAndHighLight(option2Name);
            Helper.DynamicScrollToText(Helper.Driver, menuName);
            Logger.WriteDebugMessage("Menu Edited Successfully");
            Helper.ExitFrame();
        }
        public static void EditMenuAddOns(string menuName, string menuDescription, string Title, string add_On1_Name, string add_On1_Description, string add_On1_Price, string add_On2_Name, string add_On2_Description, string add_On2_Price)
        {

            Logger.WriteDebugMessage("Edit Menu Popup got Displayed");
            Helper.ExitFrame();
            AddNewMenu_MenuName(menuName);
            Helper.EnterFrame("cdescription_ifr");
            AddNewMenu_AddChoice_Description("cdescription", menuDescription);
            Logger.WriteDebugMessage("Name and description should get added");
            Helper.ExitFrame();

            //Enter Title
            Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Enter_Add_On_Title());
            Enter_Add_On_Title(Title);

            //Edit 1st Add On 
            string desId = GetFrameId("2");
            Helper.EnterFrame(desId);
            AddNewMenu_AddChoice_Description(desId.Substring(0, 14), add_On1_Name);
            Helper.ExitFrame();
            desId = GetFrameId("3");
            Helper.EnterFrame(desId);
            AddNewMenu_AddChoice_Description(desId.Substring(0, 20), add_On1_Description);
            Helper.ExitFrame();
            Enter_Add_On_Price1(add_On1_Price);
            Logger.WriteDebugMessage("Name, description  and Price should get updated for 1st Add on");


            //Edit 2nd Add On
            desId = GetFrameId("4");
            Helper.EnterFrame(desId);
            AddNewMenu_AddChoice_Description(desId.Substring(0, 14), add_On2_Name);
            Helper.ExitFrame();
            desId = GetFrameId("5");
            Helper.EnterFrame(desId);
            AddNewMenu_AddChoice_Description(desId.Substring(0, 20), add_On2_Description);
            Helper.ExitFrame();
            Enter_Add_On_Price2(add_On2_Price);
            Logger.WriteDebugMessage("Name, description  and Price should get updated for 2nd Add on");


            //Save the Details and Verify the Details on Property Admin
            Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_AddNewMenu_BottomSaveButton());
            Click_AddNewMenu_BottomSaveButton();
            Helper.EnterFrame("frontendEditorIframe");
            Helper.ElementWait(PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu(), 60);
            Helper.VerifyTextOnPageAndHighLight(menuName);
            Helper.VerifyTextOnPageAndHighLight(Title);
            Helper.VerifyTextOnPageAndHighLight(add_On1_Name);
            Helper.VerifyTextOnPageAndHighLight(add_On2_Name);
            Helper.DynamicScrollToText(Helper.Driver, menuName);
            Logger.WriteDebugMessage("Menu Added Successfully");

        }
        public static void VerifyPublishAll()
        {
            Helper.AddDelay(10000);
            Click_Publish_Button();
            Helper.VerifyTextOnPageAndHighLight("There is nothing new to publish");
            Click_Publish_Close_Button();


        }
        public static void Click_Publish_Close_Button()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Publish_Close_Button());
        }
        public static void Click_EditMenu_Button(string menuName)
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_EditMenu_Button(menuName));
        }
        public static void Click_Filter_GlutenFree()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Filter_GlutenFree());
        }
        public static void Click_Filter_MilkAvoidance()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Filter_MilkAvoidance());
        }
        public static void Click_Tag_MostPopular()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Tag_MostPopular());
        }
        public static void Verify_LITE_SyncToLite(params string[] parameters) // should I use an array?
        {
           
           foreach (var p in parameters)
            {
                Helper.VerifyTextOnPageAndHighLight(p);
            }
            Logger.WriteDebugMessage("All menu items on page");
        }

        public static void Verify_LITE_NoSyncToLite(string update)
        {
            Helper.VerifyTextNOTOnPage(update);
        }

        public static void Verify_Menu_NoFilter(string menuName)
        {
            if (Helper.IsElementPresent(By.XPath("//div[@class='menu_name' and contains(text(), '" + menuName + "')]/parent::div//div[@class='menu-info']")))
            {
                Assert.Fail("Menu filter is showing on page.");
                Logger.WriteFatalMessage("Menu filter updates without publish to Lite");  
            }
            else
            {
                Logger.WriteDebugMessage("Menu filter is not showing on page");
            }

        }
        public static void Click_MyMenu_SpecialOffers()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_MyMenu_SpecialOffers());
        }

        public static void Verify_Menu_Filter(string menuName)
        {
            Helper.ScrollToElement(PageObject_PropertyAdmin.Menu_Filter(menuName));
            Logger.WriteDebugMessage("Menu filter is present on menu item");
        }
        public static void Click_Form_Cancel_Button()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Form_Cancel_Button());
        }
        public static void Click_AddItem_CancelButton()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_AddItem_CancelButton());
        }
        public static void Click_Menu_EditButton()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Menu_EditButton());
        }
        public static void Click_Item_Delete_Cancel()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Item_Delete_Cancel());
        }

        public static void Click_MyPlanner_Edit()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_MyPlanner_Edit());
        }
        public static void Enter_Category_editor(string homeContent)
        {
            Helper.ElementClearText(PageObject_PropertyAdmin.Enter_Category_editor());
            Helper.ElementEnterText(PageObject_PropertyAdmin.Enter_Category_editor(), homeContent);
        }
        public static void Click_Category_editor_save()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Category_editor_save());
        }

        public static void Click_Edit_Desclaimer()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Edit_Desclaimer());
        }
        public static void Enter_Desclaimer_Description(string text)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.Enter_Desclaimer_Description(), text);
        }
        public static void Click_Desclaimer_SaveButton()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Desclaimer_SaveButton());
        }
        public static void Click_Category_Decsription()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Category_Decsription());
        }
        public static void Enter_Category_Description(string text)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.Enter_Category_Description(), text);
        }
        public static void Click_CategoryDescription_SaveButton()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_CategoryDescription_SaveButton());
        }
        public static void Click_Fronend_HomeCategory()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Fronend_HomeCategory());
        }


        public static void Click_Menu_Item_Down()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Menu_Item_Down());
        }
        public static void Click_Menu_Item_Up()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Menu_Item_Up());
        }
        public static string Get_First_Item_Title_PA()
        {
            return PageObject_PropertyAdmin.Get_First_Item_Title_PA().GetAttribute("innerHTML");
        }
        public static string Get_Second_Item_Title_PA()
        {
            return PageObject_PropertyAdmin.Get_Second_Item_Title_PA().GetAttribute("innerHTML");
        }
        public static string Get_First_Item_Title_FE()
        {
            return PageObject_PropertyAdmin.Get_First_Item_Title_FE().GetAttribute("innerHTML");
        }
        public static string Get_Second_Item_Title_FE()
        {
            return PageObject_PropertyAdmin.Get_Second_Item_Title_FE().GetAttribute("innerHTML");
        }
        public static string Get_First_Item_Title_PM()
        {
            return PageObject_PropertyAdmin.Get_First_Item_Title_PM().GetAttribute("innerHTML");
        }
        public static string Get_Second_Item_Title_PM()
        {
            return PageObject_PropertyAdmin.Get_Second_Item_Title_PM().GetAttribute("innerHTML");
        }
        public static void Click_Link_Edit_Category(string subCategoryName)
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Link_Edit_Category(subCategoryName));
        }
        public static void Click_Button_Category_Description_Cancel()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Button_Category_Description_Cancel());
        }
        public static void Click_Button_Category_Description_Save()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Button_Category_Description_Save());
        }
        public static void Click_Here_for_eGallery()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Here_for_eGallery());
        }
        public static void Select_Image_from_eGallery(string no)
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Select_Image_from_eGallery(no));
        }
        public static void Click_Category_Home()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Category_Home());
        }
        public static void Click_Category_Information()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Category_Information());
        }
        public static void Click_Link_FindAndReplace()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Link_FindAndReplace());
        }
        public static void Click_Button_Find()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Button_Find());
        }
        public static void Click_Button_ReplaceAll()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Button_ReplaceAll());
        }
        public static void Click_Button_Done()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Button_Done());
        }
        public static string Get_AlertBox_Title()
        {
            return PageObject_PropertyAdmin.Get_AlertBox_Title().GetAttribute("innerHTML");
        }
        public static string Get_Validation_Message()
        {
            return PageObject_PropertyAdmin.Get_Validation_Message().GetAttribute("innerHTML");
        }
        public static string Get_Success_Validation_Message()
        {
            return PageObject_PropertyAdmin.Get_Success_Validation_Message().GetAttribute("innerHTML");
        }
        
        public static void Enter_Find_TextBox(string text)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.Enter_Find_TextBox(), text);
        }
        public static void Enter_Replace_TextBox(string text)
        {
            Helper.ElementEnterText(PageObject_PropertyAdmin.Enter_Replace_TextBox(), text);
        }
        public static void VerifyCategoryNotPresent(string categoryName)
        {
            if (Helper.IsWebElementRemoved(PageObject_PropertyAdmin.Click_MyMenu_MainCategory(categoryName)))
                Assert.Fail("Unpublished categories from Corporate should not display.");
            else
                Logger.WriteDebugMessage("Unpublished category " + categoryName + " is not displaying as expected.");
        }
        public static void VerifyCategoryPresentFromList(List<string> categories)
        {
            foreach (var cat in categories)
            {
                Helper.VerifyElementOnPage(PageObject_PropertyAdmin.Click_MyMenu_MainCategory(cat));
                Logger.WriteInfoMessage("Published category " + cat + " is inherited by Lite Property");
            }
        }

        public static void Click_GlobeIcon()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_GlobeIcon());
        }
        public static void Click_Globe_CloseIcon()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Globe_CloseIcon());
        }
        public static void Click_Globe_EnglishLanguage()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Globe_EnglishLanguage());
        }
        public static void Click_Globe_FrançaisLanguage()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Globe_FrançaisLanguage());
        }

        public static void Click_MyMenu_BreakMenu()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_MyMenu_BreakMenu());
        }
        public static void BreakMenu_EditIcon()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.BreakMenu_EditIcon());
        }
        public static void EditMenuPrice(string menuName, string price, string pricedescription)
        {

            Logger.WriteDebugMessage("Edit Menu Popup got Displayed");
            Helper.ExitFrame();
            AddNewMenu_Price(price);
            Select_Price_Description(pricedescription);
            Logger.WriteDebugMessage("All the details are entered successfully");
            Click_AddNewMenu_SaveButton();
            Logger.WriteDebugMessage("Menu Confirmation Overlay is Displayed");
            Helper.EnterFrame("frontendEditorIframe");
            Helper.VerifyTextOnPageAndHighLight(menuName);
            Helper.DynamicScrollToText(Helper.Driver, menuName);
            Logger.WriteDebugMessage("Menu price updated Successfully");
            Helper.ExitFrame();
        }
        public static void Click_MyMenu_MainCategory(string category)
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_MyMenu_MainCategory(category));
        }
        public static void EditDisclaimer(string disclaimer)
        {
            Helper.EnterFrame("frontendEditorIframe");
            Helper.ScrollToElement(PageObject_PropertyAdmin.Click_Edit_Desclaimer());
            PropertyAdmin.Click_Edit_Desclaimer();
            Logger.WriteDebugMessage("Clicked on declaimer edit button");
            Helper.ExitFrame();
            Helper.EnterFrame("disclaimer_ifr");
            PropertyAdmin.Enter_Desclaimer_Description(disclaimer);
            Logger.WriteDebugMessage("Disclaimer description added");
            Helper.ExitFrame();
            PropertyAdmin.Click_Desclaimer_SaveButton();
            Logger.WriteDebugMessage("Clicked on save button");
            Helper.EnterFrame("frontendEditorIframe");
            Helper.ScrollToElement(PageObject_PropertyAdmin.Click_Edit_Desclaimer());
            Logger.WriteDebugMessage("Disclaimer updated to " + disclaimer);
            Helper.ExitFrame();
        }
        public static void PropertyAdmin_Non2Factor()
        {
            Helper.Driver.Url = ProjectDetails.CommonAdminURL;
            Logger.WriteDebugMessage("Landed on Admin Login Page");
            PropertyAdmin_Username(ProjectDetails.CommonAdminEmail);
            Click_NextButton();
            PropertyAdmin.PropertyAdmin_Password(ProjectDetails.CommonAdminPassword);
            Logger.WriteDebugMessage("Entered Username =" + Utility.Constants.Non2FactorEmail + " and Password =" + Utility.Constants.CommonPassword);
            Click_LoginButton();
            //Time.AddDelay(25000);
            }
        public static void PropertyAdmin_SSOProd(string username, string password)
        {
            Email.LogIntoCatchAll();
            Logger.WriteDebugMessage("User should be Logged in Catchall Account");
            Helper.OpenNewTab();
            Helper.Driver.Url = "https://www.cendynaccess.com/";
            Logger.WriteDebugMessage("Landed on Admin Login Page");
            PropertyAdmin_Username(username);
            Click_NextButton();
            PropertyAdmin.PropertyAdmin_Password(password);
            Logger.WriteDebugMessage("Entered Username =" + username + " and Password =" + password);
            Click_LoginButton();
            Logger.WriteDebugMessage("Landed on Enter Verification Code Page");
            Helper.ControlToPreviousWindow();

            //Check the Credentials email on Login Cendyn Access Folder
            Time.AddDelay(25000);
            Helper.DynamicScroll(Helper.Driver, PageObject_Email.Login_Cendyn_Access());
            Email.Login_Cendyn_Access();
            Helper.ReloadPage();
            Logger.WriteDebugMessage("Navigated to Login Cendyn Access Folder");
            Helper.ElementClick(PageObject_Email.CatchAll_Recent_Email());
            Logger.WriteDebugMessage("Opened Latest Email.");
            Helper.PageDown();

            //Capture the Verification Code
            Helper.ScrollToElement(PageObject_PropertyAdmin.GetVerificationCode());
            string code = PropertyAdmin.GetVerificationCode();
            Logger.WriteDebugMessage("Verification  Code = " + code + " Captured");
            Helper.ControlToNextWindow();
            Logger.WriteDebugMessage("Landed on Admin Enter Verification Code Page");
            PropertyAdmin.Propertyadmin_Verificationcode(code);
            Logger.WriteDebugMessage("Verification Code is Entered");
            Click_LoginButton();
            Logger.WriteDebugMessage("User should able to navigate to admin page");
        }
        public static void Verify_Menu_Price(string menuName, string price, string priceDescription, string area)
        {
            Helper.AddDelay(9000);
            Helper.DynamicScrollToText(Helper.Driver, menuName);
            if ((PropertyAdmin.Get_Admin_Menu_Price(menuName).Trim()) == ("$" + price + ".00 " + priceDescription))
                Logger.WriteDebugMessage(PropertyAdmin.Get_Admin_Menu_Price(menuName).Trim() + " price is shown on " + area);
            else
                Assert.Fail("Price is not showing properly on " + area);
        }
        public static void Click_AddOnMoveDown_Button()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_AddOnMoveDown_Button());
        }

        public static void Click_MyMenu_EditButton(string menuName)
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_MyMenu_EditButton(menuName));
        }

        public static void Click_Option_DeleteButton()
        {
            Helper.ElementClick(PageObject_PropertyAdmin.Click_Option_DeleteButton());
        }
        public static void BreaksVerify_MenuPrice_AcrossPages(string menuName, string price, string priceDescription)
        { 
            Helper.EnterFrame("frontendEditorIframe");
            PropertyAdmin.Click_MyMenu_Breaks();
            PropertyAdmin.Verify_Menu_Price(menuName, price, priceDescription, "Web View");

            //Navigate to PDF View and verify new item shows with price and price description
            Helper.ExitFrame();
            PropertyAdmin.Click_Link_PDF_View();
            Helper.EnterFrame("frontendEditorIframe");
            PropertyAdmin.Click_MyMenu_Breaks();
            PropertyAdmin.Verify_Menu_Price(menuName, price, priceDescription, "PDF View");
            Helper.ExitFrame();

            //Navigate to Preview
            PropertyAdmin.Click_MyMenu_PreviewButton();
            Helper.ControlToNewWindow();
            Logger.WriteDebugMessage("Preview window should get displayed");
            PropertyAdmin.Click_MyMenu_Breaks();
            PropertyAdmin.Verify_Menu_Price(menuName, price, priceDescription, "Preview");
            Helper.CloseWindow();
            Helper.ControlToPreviousWindow();

            //Navigate to Front End
            PropertyAdmin.Click_PublishedView();
            Helper.ControlToNewWindow();
            Logger.WriteDebugMessage("Published View window should get displayed");
            PropertyAdmin.Click_MyMenu_Breaks();
            PropertyAdmin.Verify_Menu_Price(menuName, price, priceDescription, "Front End");
            Helper.CloseWindow();
            Helper.ControlToPreviousWindow();
        }

        public static void Verify_Disclaimer_AcrossPages(string categoryname, string disclaimer)
        {
            Helper.EnterFrame("frontendEditorIframe");
            PropertyAdmin.Click_MyMenu_MainCategory(categoryname);
            Helper.ScrollToElement(PageObject_PropertyAdmin.Menu_Disclaimer());
            Helper.VerifyTextOnPage(disclaimer);
            Logger.WriteDebugMessage(disclaimer + " found on Web View.");

            //Navigate to PDF View and verify new item shows with price and price description
            Helper.ExitFrame();
            PropertyAdmin.Click_Link_PDF_View();
            Helper.EnterFrame("frontendEditorIframe");
            PropertyAdmin.Click_MyMenu_MainCategory(categoryname);
            Helper.ScrollToElement(PageObject_PropertyAdmin.Menu_Disclaimer());
            Helper.VerifyTextOnPage(disclaimer);
            Logger.WriteDebugMessage(disclaimer + " found on PDF View.");
            Helper.ExitFrame();

            /*//Navigate to Preview
            PropertyAdmin.Click_MyMenu_PreviewButton();
            Helper.ControlToNewWindow();
            Logger.WriteDebugMessage("Preview window should get displayed");
            PropertyAdmin.Click_MyMenu_MainCategory(categoryname);
            Helper.ScrollToElement(PageObject_PropertyAdmin.Menu_Disclaimer());
            Helper.VerifyTextOnPage(disclaimer);
            Logger.WriteDebugMessage(disclaimer + " found on Preview.");
            Helper.CloseWindow();
            Helper.ControlToPreviousWindow();*/

            //Navigate to Front End
            PropertyAdmin.Click_PublishedView();
            Helper.ControlToNewWindow();
            Logger.WriteDebugMessage("Published View window should get displayed");
            PropertyAdmin.Click_MyMenu_MainCategory(categoryname);
            Helper.ScrollToElement(PageObject_PropertyAdmin.Menu_Disclaimer());
            Helper.VerifyTextOnPage(disclaimer);
            Logger.WriteDebugMessage(disclaimer + " found on Front End.");
            Helper.CloseWindow();
            Helper.ControlToPreviousWindow();
        }
        public static void VerifyMenu(string mainCategory, string subCategory, string menuName, string menuChoice, string Option1, string Option2)
        {
            PropertyAdmin.Click_MyMenu_MainCategory(mainCategory);
            Logger.WriteDebugMessage(mainCategory + " main category was selected.");
            if (subCategory != null)
            {
                PropertyAdmin.Click_Category_Sub_Menu(subCategory);
                Logger.WriteDebugMessage(mainCategory + " sub category was selected.");
            }
            Helper.VerifyTextOnPageAndHighLight(menuName);
            Helper.VerifyTextOnPageAndHighLight(menuChoice);
            Helper.VerifyTextOnPageAndHighLight(Option1);
            Helper.VerifyTextOnPageAndHighLight(Option2);
            Helper.DynamicScrollToText(Helper.Driver, menuName);
            Logger.WriteDebugMessage("Add Menu  with Choice and Option is Displaying");
        }
        public static void AddNewMenuWithGlutenFreeFilter(string menuName)
        {
            Click_MyMenu_AddNewMenu();
            Logger.WriteDebugMessage("Add new menu modal should get displayed");
            Helper.ExitFrame();
            AddNewMenu_MenuName(menuName);
            Helper.EnterFrame("cdescription_ifr");
            AddNewMenu_AddChoice_Description("cdescription", "Sample Description");
            Helper.ExitFrame();
            Click_Filter_GlutenFree();
            Click_AddNewMenu_SaveButton();
            Helper.EnterFrame("frontendEditorIframe");
            Helper.VerifyTextOnPageAndHighLight(menuName);
            Helper.DynamicScrollToText(Helper.Driver, menuName);
            Logger.WriteDebugMessage("Menu added Successfully");
        }
        public static void AddNewMenuAsMilkAvoidance(string menuName)
        {
            Click_MyMenu_AddNewMenu();
            Logger.WriteDebugMessage("Add new menu modal should get displayed");
            Helper.ExitFrame();
            AddNewMenu_MenuName(menuName);
            Helper.EnterFrame("cdescription_ifr");
            AddNewMenu_AddChoice_Description("cdescription", "Sample Description");
            Helper.ExitFrame();
            Click_Filter_MilkAvoidance();
            Click_AddNewMenu_SaveButton();
            Helper.EnterFrame("frontendEditorIframe");
            Helper.VerifyTextOnPageAndHighLight(menuName);
            Helper.DynamicScrollToText(Helper.Driver, menuName);
            Logger.WriteDebugMessage("Menu added Successfully");
        }
        public static void AddNewMenuAsMostPopular(string menuName)
        {
            Click_MyMenu_AddNewMenu();
            Logger.WriteDebugMessage("Add new menu modal should get displayed");
            Helper.ExitFrame();
            AddNewMenu_MenuName(menuName);
            Helper.EnterFrame("cdescription_ifr");
            AddNewMenu_AddChoice_Description("cdescription", "Sample Description");
            Helper.ExitFrame();
            Click_Tag_MostPopular();
            Click_AddNewMenu_SaveButton();
            Helper.EnterFrame("frontendEditorIframe");
            Helper.VerifyTextOnPageAndHighLight(menuName);
            Helper.DynamicScrollToText(Helper.Driver, menuName);
            Logger.WriteDebugMessage("Menu added Successfully");
        }
        public static void SearchAndRemoveDynamicPricing(string startdate, string enddate)
        {
            int i = 1;
            string gridName;
            DateTime gridStart;
            DateTime gridEnd;

            while (Helper.IsWebElementRemoved(PageObject_PropertyAdmin.DynamicPricingGrid_Name(i)))
            {
                gridStart = Convert.ToDateTime(PageObject_PropertyAdmin.DynamicPricingGrid_StartDate(i).GetAttribute("innerHTML"));
                gridEnd = Convert.ToDateTime(PageObject_PropertyAdmin.DynamicPricingGrid_EndDate(i).GetAttribute("innerHTML"));

                if (Convert.ToDateTime(enddate) < gridStart)
                {
                    break;
                }
                else if (Convert.ToDateTime(startdate) > gridEnd)
                {
                    i++;
                }
                else
                {
                    gridName = PageObject_PropertyAdmin.DynamicPricingGrid_Name(i).GetAttribute("innerHTML");
                    Helper.DynamicScrollToText(Helper.Driver, gridName);
                    DeleteDynamicPrice(gridName);
                    DeleteDynamicPriceConfirmation();
                    DeleteDynamicPriceConfirmation_OK();
                    Logger.WriteDebugMessage("Dynamic Price conflict got deleted");
                }


            }
        }
    }
}


        

