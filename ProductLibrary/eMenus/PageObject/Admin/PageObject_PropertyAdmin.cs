using System.Reflection;
using BaseUtility.PageObject;
using eMenus.Utility;
using OpenQA.Selenium;

namespace eMenus.PageObject.Admin
{
    class PageObject_PropertyAdmin : Setup
    {
        public static string PageName = Utility.Constants.PropertyAdmin;
        public static IWebElement Click_Select_PropertyDropdown()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Select_PropertyDropdown);
        }
        public static IWebElement Select_Property()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_Property);
        }
        public static IWebElement Click_uOrder()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_uOrder);
        }
        public static IWebElement Click_Uorder_Update_Contact()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Uorder_Update_Contact);
        }
        public static IWebElement uOrder_OrderSearchBox()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.uOrder_OrderSearchBox);
        }
        public static IWebElement PropertyAdmin_Username()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.PropertyAdmin_Username);
        }
        public static IWebElement PropertyAdmin_Password()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.PropertyAdmin_Password);
        }
        public static IWebElement Propertyadmin_Verificationcode()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Propertyadmin_Verificationcode);
        }
        public static IWebElement GetVerificationCode()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.GetVerificationcode);
        }
        public static IWebElement Click_BackButton()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_BackButton);
        }
        public static IWebElement Click_LoginButton()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_LoginButton);
        }
        public static IWebElement Click_NextButton()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_NextButton);
        }

        public static IWebElement Click_Prperty()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Click_Prperty);
        }
        public static IWebElement Click_eMenus()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_eMenus);
        }
        public static IWebElement Click_Settings_Dropdown()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Settings_Dropdown);
        }
        public static IWebElement Click_Cendyn_Admin()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Cendyn_Admin);
        }
        public static IWebElement Click_Advance_Settings()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Advance_Settings);
        }
        public static IWebElement Click_Uorder_Contact()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Uorder_Contact);
        }
        public static IWebElement Click_Property_Dropdown()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Property_Dropdown);
        }
        public static IWebElement Enter_Property_TextBox()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Property_TextBox);
        }
        public static IWebElement Click_Property_Origami()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Property_Origami);
        }
        public static IWebElement Click_Published_View()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Published_View);
        }
        public static IWebElement Click_Home_Menu()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Menu);
        }
        public static IWebElement Click_Home_Menu_eMenu()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Menu_eMenu);
        }
        public static IWebElement Click_MyMenu_Settings()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MyMenu_Settings);
        }
        public static IWebElement Click_Settings_DynamicPricing()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Click_Settings_DynamicPricing);
        }
        public static IWebElement Click_DynamicPricing_AddNewButton()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_DynamicPricing_AddNewButton);
        }
        public static IWebElement AddDynamicPricing_DynamicPricingName()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AddDynamicPricing_DynamicPricingName);
        }
        public static IWebElement AddDynamicPricing_StartDate()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AddDynamicPricing_StartDate);
        }
        public static IWebElement AddDynamicPricing_EndDate()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AddDynamicPricing_EndDate);
        }
        public static IWebElement AddDynamicPricing_SaveChangesButton()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AddDynamicPricing_SaveChangesButton);
        }
        public static IWebElement AddDynamicPricing_CancelButton()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AddDynamicPricing_CancelButton);
        }
        public static IWebElement Click_AddDynamicPricing_OkButton()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AddDynamicPricing_OkButton);
        }


        public static IWebElement Click_MyMenu_BreakfastDropdown()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MyMenu_BreakfastDropdown);
        }
        public static IWebElement MyMenu_BreakfastDropdown_ContinentalBreakfast()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyMenu_BreakfastDropdown_ContinentalBreakfast);
        }
        public static IWebElement Click_MyMenu_AddNewMenu()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MyMenu_AddNewMenu);
        }
        public static IWebElement Click_AddNewMenu_CancelButton()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Click_AddNewMenu_CancelButton);
        }
        public static IWebElement Click_AddNewMenu_SaveButton()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AddNewMenu_SaveButton);
        }
        public static IWebElement AddNewMenu_MenuName()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AddNewMenu_MenuName);
        }
        public static IWebElement AddNewMenu_Price()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.AddNewMenu_Price);
        }
        public static IWebElement AddNewMenu_DynamiPrice()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AddNewMenu_DynamiPrice);
        }
        public static IWebElement AddNewMenu_Description()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AddNewMenu_Description);
        }
        public static IWebElement Click_MyMenus()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MyMenus);
        }
        public static IWebElement Select_Price_Description()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_Price_Description);
        }
        public static IWebElement Select_DynamicPrice_Description()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_DynamicPrice_Description);
        }
        public static IWebElement Click_Publish_Button()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Publish_Button);
        }
        public static IWebElement Select_Property_Dropdown()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_Property_Dropdown);
        }
        public static IWebElement Click_Form_Publish_Button()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Form_Publish_Button);
        }
        public static IWebElement DynamicPricing_SaveChangesYesButton()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AddDynamicPricing_SaveChangesYesButton);
        }
        public static IWebElement DynamicPricing_Delete_button(string dynamicpricename)
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//td[contains(text(),'" + dynamicpricename + "')]//following::button[contains(text(),'Delete')]");
        }
        public static IWebElement DynamicPricing_Edit_button(string dynamicpricename)
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//td[contains(text(),'" + dynamicpricename + "')]//following::button[contains(text(),'Edit')]");
        }
        public static IWebElement Click_Delete_Dynamic_Price_Confirmation()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Delete_Dynamic_Price_Confirmation);
        }
        public static IWebElement Click_Delete_Dynamic_Price_Confirmation_OK()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Delete_Dynamic_Price_Confirmation_OK);
        }
        public static IWebElement Click_MyMenu_EditMenu()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MyMenu_EditMenu);
        }
        public static IWebElement Existing_MenuPrice()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Existing_MenuPrice);
        }
        public static IWebElement Edit_DynamicPrice_StartDate()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.EditDynamicPricing_StartDate);
        }
        public static IWebElement Edit_DynamicPrice_EndDate()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.EditDynamicPricing_EndDate);
        }
        public static IWebElement EditDynamicPricing_SaveChangesButton()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.EditDynamicPricing_SaveChangesButton);
        }
        public static IWebElement EditDynamicPricing_DynamicPricingName()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.EditDynamicPricing_DynamicPricingName);
        }

        //public static IWebElement AddNewMenu_MenuName()
        //{
        //    ScanPage(Utility.Constants.PropertyAdmin);
        //    CurrentPageName = PageName;
        //    CurrentElementName = MethodBase.GetCurrentMethod().Name;
        //    return PageAction.Find_ElementXPath(ObjectRepository.AddNewMenu_MenuName);
        //}


        //public static IWebElement AddNewMenu_Description()
        //{
        //    ScanPage(Utility.Constants.PropertyAdmin);
        //    CurrentPageName = PageName;
        //    CurrentElementName = MethodBase.GetCurrentMethod().Name;
        //    return PageAction.Find_ElementXPath(ObjectRepository.AddNewMenu_Description);
        //}


        public static IWebElement Click_AddNewMenu_AddChoiceButton()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AddNewMenu_AddChoiceButton);
        }
        public static IWebElement AddNewMenu_AddChoice_Name()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AddNewMenu_AddChoice_Name);
        }
        public static IWebElement AddNewMenu_AddChoice_Description(string dataid)
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("(//*[@id='tinymce' and //*[contains(@data-id, '" + dataid + "')]])");
        }
        public static IWebElement Click_AddNewMenu_NewOptionButton()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AddNewMenu_NewOptionButton);
        }
        public static IWebElement AddNewMenu_AddChoice_Option(string dataid)
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("(//*[@id='tinymce' and //*[contains(@data-id, '" + dataid + "')]])");
        }
        public static IWebElement AddNewMenu_AddChoice_Price()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AddNewMenu_AddChoice_Price);
        }
        public static IWebElement Click_AddNewMenu_NewOptionButton2()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AddNewMenu_NewOptionButton2);
        }
        public static IWebElement AddNewMenu_AddChoice_Option2()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AddNewMenu_AddChoice_Option2);
        }
        public static IWebElement AddNewMenu_AddChoice_Price2()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AddNewMenu_AddChoice_Price2);
        }
        public static IWebElement Click_AddNewMenu_BottomSaveButton()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AddNewMenu_BottomSaveButton);
        }

        public static IWebElement Click_MyMenu_PreviewButton()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MyMenu_PreviewButton);
        }
        public static IWebElement Click_Preview_BreakfastDropdown()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Preview_BreakfastDropdown);
        }
        public static IWebElement Click_Preview_ContinentalBreakfast()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Preview_ContinentalBreakfast);
        }
        public static IWebElement Click_MyMenu_PublishButton()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MyMenu_PublishButton);
        }
        public static IWebElement Click_MyMenu_PublishSaveButton()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MyMenu_PublishSaveButton);
        }
        public static IWebElement GetDescriptionId_AddChoices(string no)
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("(//*[contains(@id, 'mceu')]/iframe)[" + no + "]");
        }
        public static IWebElement Enter_Add_On_Title()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Add_On_Title);
        }
        public static IWebElement Click_New_Add_On()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_New_Add_On);
        }
        public static IWebElement Enter_Add_On_Price1()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Add_On_Price1);
        }
        public static IWebElement Enter_Add_On_Price2()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Add_On_Price2);
        }
        public static IWebElement Validation_Message()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SSO_Validation_Message);
        }
        public static IWebElement Click_Log_Out()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Log_Out);
        }
        public static IWebElement Click_Social_Media_Tab()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Social_Media_Tab);
        }
        public static IWebElement Click_Add_New_Social_Media()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Add_New_Social_Media);
        }
        public static IWebElement Select_Social_Media_Dropdown()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Social_Media_Dropdown);
        }
        public static IWebElement Edit_Social_Media_Dropdown()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Edit_Social_Media_Dropdown);
        }
        public static IWebElement Social_Media_Type_Validation()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Social_Media_Type_Validation);
        }
        public static IWebElement Enter_Social_Media_URL()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Social_Media_URL);
        }
        public static IWebElement Edit_Social_Media_URL()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Edit_Social_Media_URL);
        }
        public static IWebElement Social_Media_URL_Validation()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Social_Media_URL_Validation);
        }
        public static IWebElement Click_Social_Media_Save_Changes()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Social_Media_Save_Changes);
        }
        public static IWebElement Click_Edit_Social_Media_Save_Changes()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Edit_Social_Media_Save_Changes);
        }
        public static IWebElement Click_Social_Media_Close()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Social_Media_Close);
        }
        public static IWebElement Edit_Social_Media(string value)
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("(//td[contains(text(),'" + value + "')]//following::button[contains(text(),'Edit')])[1]");
        }
        public static IWebElement Delete_Social_Media(string value)
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("(//td[contains(text(),'" + value + "')]//following::button[contains(text(),'Delete')])[1]");
        }
        public static IWebElement Click_Social_Media(string value)
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='Wrapper']//a[contains(@href , '" + value.ToLower() + "')]");
        }
        public static IWebElement Click_OK_Button()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.OK_Button);
        }
        public static IWebElement Click_Yes_Button()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Yes_Button);
        }
        public static IWebElement Settings_MenuFilter_Tab()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Settings_MenuFilter_Tab);
        }
        public static IWebElement Settings_MenuFilter_AddTag()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Settings_MenuFilter_AddTag);
        }
        public static IWebElement Settings_MenuFilter_AddTag_Name()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Settings_MenuFilter_AddTag_Name);
        }
        public static IWebElement Settings_MenuFilter_AddTag_DeleteButton()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Settings_MenuFilter_AddTag_DeleteButton);
        }
        public static IWebElement Settings_MenuFilter_AddTag_SaveButton()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Settings_MenuFilter_AddTag_SaveButton);
        }
        public static IWebElement Click_AddNewMenu_AddedTag_Filter()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AddNewMenu_AddedTag_Filter);
        }
        public static IWebElement Settings_MenuFilter_DeleteTag_ContinueButton()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Settings_MenuFilter_DeleteTag_ContinueButton);
        }
        public static IWebElement Click_Menu_Info_Button()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Menu_Info_Button);
        }
        public static IWebElement Menu_Tag_Name(string tagname)
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='Content']//li[contains(text(),'"+tagname+"')]");
        }
        public static IWebElement First_Menu_Price_Admin(string menuname)
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='Content']//div[contains(text(),'"+ menuname + "')]//following-sibling::div[@class='price']");
        }
        public static IWebElement First_Menu_Price_Preview(string menuname)
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='Content']//div[contains(text(),'" + menuname + "')]//following-sibling::div[@class='price']");
        }

        public static IWebElement Click_FindReplace()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_FindReplace);
        }
        public static IWebElement Enter_FindText()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Enter_FindText);
        }
        public static IWebElement Enter_ReplaceText()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Enter_ReplaceText);
        }
        public static IWebElement Click_FindReplace_Find()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_FindReplace_Find);
        }
        public static IWebElement Click_FindReplace_ReplaceAll()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_FindReplace_ReplaceAll);
        }
        public static IWebElement Click_FindReplace_Done()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_FindReplace_Done);
        }
        public static IWebElement Click_MyMenu_DeleteMenu(string menuName)
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("(//div[contains(text(),'"+ menuName + "')]//following::span[contains(@class, 'delete-this')])[1]");
        }
        public static IWebElement Click_MyMenu_DeleteMenu_Confirm()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MyMenu_DeleteMenu_Confirm);
        }
        public static IWebElement Click_Main_Navigation_Dropdown()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Main_Navigation_Dropdown);
        }
        public static IWebElement Click_Navigation_Dropdown_Value(string value)
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//a[contains(@href,'" + value + "')]");
        }
        public static IWebElement Click_Link_PDF_View()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Link_PDF_View);
        }
        public static IWebElement Click_Link_Web_View()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Link_Web_View);
        }
        public static IWebElement PassedDate_Name_DynamicPrice()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.PassedDate_Name_DynamicPrice);
        }
        public static IWebElement Click_Link_Share()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Link_Share);
        }
        public static IWebElement Enter_ShareMenu_Name()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_ShareMenu_Name);
        }
        public static IWebElement Check_Format_Checkbox()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Check_Format_Checkbox);
        }
        public static IWebElement Check_Pricing_Checkbox()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Check_Pricing_Checkbox);
        }
        public static IWebElement Click_Continue_Button()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Continue_Button);
        }
        public static IWebElement Check_Menu_For_Pages(string menuName)
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='headingOne']//span[contains(text(),'" + menuName + "')]//preceding::input[1]");
        }
        public static IWebElement Click_Search_Client_Button()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Search_Client_Button);
        }
        public static IWebElement Enter_Search_Client_Name()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Search_Client_Name);
        }
        public static IWebElement Click_SearchOverlay_Client_Button()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_SearchOverlay_Client_Button);
        }
        public static IWebElement Select_Searched_Client_Record()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_Searched_Client_Record);
        }
        public static IWebElement Cancel_Search_Client()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Cancel_Search_Client);
        }
        
        public static IWebElement Share_Message_Content()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Share_Message_Content);
        }
        public static IWebElement Click_Send_Email()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Send_Email);
        }
        public static IWebElement Click_GoToActivity_Button()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_GoToActivity_Button);
        }
        public static IWebElement Search_Menu_Filter()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Search_Menu_Filter);
        }
        public static IWebElement Click_Action_Button()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Action_Button);
        }
        public static IWebElement Click_Clone_Link()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Clone_Link);
        }
        public static IWebElement Click_Clone_Button()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Clone_Button);
        }
        public static IWebElement Click_Add_New_Client()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Add_New_Client);
        }
        public static IWebElement Enter_Client_First_Name()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Client_First_Name);
        }
        public static IWebElement Enter_Client_Last_Name()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Client_Last_Name);
        }
        public static IWebElement Enter_Client_Company()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Client_Company);
        }
        public static IWebElement Enter_Client_Email()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Client_Email);
        }
        public static IWebElement Click_Save_Save()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Save_Save);
        }
        public static IWebElement Click_Generate_Link()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Generate_Link);
        }
        public static IWebElement Get_ShareMenu_Link()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Get_ShareMenu_Link);
        }
        public static IWebElement Click_Preview_Button()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Preview_Button);
        }
        public static IWebElement Click_Menu_FoodAndBeverages()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Menu_FoodAndBeverages);
        }
        public static IWebElement Click_Button_Add_Item()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Button_Add_Item);
        }
        public static IWebElement Enter_Text_Title()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Text_Title);
        }
        public static IWebElement Click_Button_Save()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Button_Save);
        }
        public static IWebElement Click_Category_Sub_Menu(string value)
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//a[contains(text(),'"+value+"')]");
        }
        public static IWebElement Click_Added_Category_Menu()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("/html/body/div[2]/div/div[2]/div/div[1]/a[last()]");
        }


        public static IWebElement Navigation_ePlanner()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_ePlanner);
        }
        public static IWebElement Click_Button_Delete()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Button_Delete);
        }
        public static IWebElement Click_Icon_Delete()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='Content']/div/div[3]/div[1]/div/div[2]/div[3]/span[4]");
        }
        public static IWebElement Click_AddNewMenu_AddChoiceButton2()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AddNewMenu_AddChoiceButton2);
        }
        public static IWebElement AddNewMenu_AddChoice2_Name()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AddNewMenu_AddChoice2_Name);
        }
        public static IWebElement Click_AddNewMenu2_NewOptionButton()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AddNewMenu2_NewOptionButton);
        }
        public static IWebElement Click_ChoiceMoveUp_Button()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_ChoiceMoveUp_Button);
        }
        public static IWebElement Click_Button_UploadFromeGallery()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Button_UploadFromeGallery);
        }
        public static IWebElement Click_Image_eGallery()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Image_eGallery);
        }
        public static IWebElement Click_Button_SelectImage()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Button_SelectImage);
        }
        public static IWebElement Click_Item_Image(string title)
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='Content']//div[contains(text(),'"+ title + "')]//following-sibling::div[contains(@class, 'menu-image')]");
        }
        public static IWebElement Click_Upload_Image()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Upload_Image);
        }
        public static IWebElement Click_Select_File()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Select_File);
        }
        public static IWebElement Click_Upload_File()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Upload_File);
        }
        public static IWebElement Click_Image_File()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Image_File);
        }
        
        public static IWebElement Click_eMenusLITE()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_eMenusLITE);
        }
        public static IWebElement Click_MyMenu_Breaks()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MyMenu_Breaks);
        }
        public static IWebElement Click_EditCategoryDesc()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_EditCategoryDesc);
        }
        public static IWebElement CategoryDesc()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CategoryDesc);
        }
        public static IWebElement Click_CategoryDesc_Save()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_CategoryDesc_Save);
        }
        public static IWebElement Click_Publish_Close_Button()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Publish_Close_Button);
        }
        public static IWebElement Click_EditMenu_Button(string menuName)
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//div[@class='menu_name' and contains(text(), '" + menuName + "')]/parent::div//span[@class='edit-this']");
            
        }
        public static IWebElement Hover_MenuName(string menuName)
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;   //div[@class='menu_name' and contains(text(), 'Charcuterie Break')]
            return PageAction.Find_ElementXPath("//div[@class='menu_name' and contains(text(),  '" + menuName + "')]");

        }
        public static IWebElement Click_Filter_GlutenFree()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Filter_GlutenFree);
        }
        public static IWebElement Click_Filter_MilkAvoidance()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Filter_MilkAvoidance);
        }
        public static IWebElement Click_Tag_MostPopular()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Tag_MostPopular);
        }
        public static IWebElement Menu_Filter(string menuName)
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//div[@class='menu_name' and contains(text(), '"+ menuName +"')]/parent::div//div[@class='menu-info']");
        }
        public static IWebElement Click_Form_Cancel_Button()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Form_Cancel_Button);
        }
        public static IWebElement Click_AddItem_CancelButton()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AddItem_CancelButton);
        }
        public static IWebElement Click_Menu_EditButton()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Menu_EditButton);
        }
        public static IWebElement Click_Item_Delete_Cancel()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Item_Delete_Cancel);
        }

        public static IWebElement Click_MyPlanner_Edit()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MyPlanner_Edit);
        }

        public static IWebElement Enter_Category_editor()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Enter_Category_editor);
        }

        public static IWebElement Click_Category_editor_save()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Category_editor_save);
        }

        public static IWebElement Click_Menu_Item_Down()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Menu_Item_Down);
        }
        public static IWebElement Click_Menu_Item_Up()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Menu_Item_Up);
        }
        public static IWebElement Get_First_Item_Title_PA()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Get_First_Item_Title_PA);
        }
        public static IWebElement Get_Second_Item_Title_PA()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Get_Second_Item_Title_PA);
        }
        public static IWebElement Get_First_Item_Title_FE()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Get_First_Item_Title_FE);
        }
        public static IWebElement Get_Second_Item_Title_FE()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Get_Second_Item_Title_FE);
        }
        public static IWebElement Get_First_Item_Title_PM()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Get_First_Item_Title_PM);
        }
        public static IWebElement Get_Second_Item_Title_PM()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Get_Second_Item_Title_PM);
        }
        public static IWebElement Click_Button_Category_Description_Cancel()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Button_Category_Description_Cancel);
        }
        public static IWebElement Click_Button_Category_Description_Save()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Button_Category_Description_Save);
        }
        public static IWebElement Click_Link_Edit_Category(string subcategoryName)
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("(//*[@id='Content']//div[contains(text(), '"+subcategoryName+"')]//following::span[@class = 'edit-this'])[1]");
        }
        public static IWebElement Click_Here_for_eGallery()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Here_for_eGallery);
        }
        public static IWebElement Select_Image_from_eGallery(string no)
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='grid']/div[2]/div["+no+"]/a");
        }
        public static IWebElement Verify_eGallery_Image()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Verify_eGallery_Image);
        }
        public static IWebElement Click_Category_Home()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Category_Home);
        }
        public static IWebElement Click_Category_Information()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Category_Information);
        }
        public static IWebElement ManagerProfile_Name()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManagerProfile_Name);
        }
        public static IWebElement Click_Edit_Desclaimer()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Edit_Desclaimer);
        }
        public static IWebElement Enter_Desclaimer_Description()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Enter_Desclaimer_Description);
        }
        public static IWebElement Click_Desclaimer_SaveButton()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Desclaimer_SaveButton);
        }
        public static IWebElement Click_Category_Decsription()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Category_Decsription);
        }
        public static IWebElement Enter_Category_Description()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Enter_Category_Description);
        }
        public static IWebElement Click_CategoryDescription_SaveButton()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_CategoryDescription_SaveButton);
        }
        public static IWebElement Click_Fronend_HomeCategory()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Fronend_HomeCategory);
        }

        public static IWebElement Click_MyMenu_SpecialOffers()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MyMenu_SpecialOffers);
        }
        public static IWebElement Property_Logo()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Property_Logo);
        }
        public static IWebElement Click_Link_FindAndReplace()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Link_FindAndReplace);
        }
        public static IWebElement Enter_Find_TextBox()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Find_TextBox);
        }
        public static IWebElement Enter_Replace_TextBox()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Replace_TextBox);
        }
        public static IWebElement Click_Button_Find()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Button_Find);
        }
        public static IWebElement Click_Button_ReplaceAll()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Button_ReplaceAll);
        }
        public static IWebElement Click_Button_Done()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Button_Done);
        }
        public static IWebElement Get_AlertBox_Title()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Get_AlertBox_Title);
        }
        public static IWebElement Get_Validation_Message()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Get_Validation_Message);
        }
        public static IWebElement Get_Success_Validation_Message()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Get_Success_Validation_Message);
        }
        
        public static IWebElement Click_MyMenu_MainCategory(string categoryName)
        {
            //ScanPage(Utility.Constants.PropertyAdmin);
            //CurrentPageName = PageName;
            //CurrentElementName = MethodBase.GetCurrentMethod().Name;   
            return PageAction.Find_ElementXPath("//div[@class='container']//a[contains(text() , '" + categoryName + "')]");

        }

        public static IWebElement Click_GlobeIcon()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_GlobeIcon);
        }
        public static IWebElement Click_Globe_CloseIcon()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Globe_CloseIcon);
        }
        public static IWebElement Click_Globe_EnglishLanguage()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Globe_EnglishLanguage);
        }
        public static IWebElement Click_Globe_FrançaisLanguage()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Globe_FrançaisLanguage);
        }

        public static IWebElement Click_MyMenu_BreakMenu()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MyMenu_BreakMenu);
        }
        public static IWebElement BreakMenu_EditIcon()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.BreakMenu_EditIcon);
        }

        public static IWebElement Click_AddOnMoveDown_Button()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AddOnMoveDown_Button);
        }
        public static IWebElement Get_AddOn1_Text(string name)
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[contains(text(),'"+name+"')]//following::span[2]");
        }

        
        public static IWebElement Click_MyMenu_EditButton(string menuName)
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("(//div[contains(text(),'" + menuName + "')]//following::span[contains(@class, 'edit-this')])");
        }

        public static IWebElement Click_Option_DeleteButton()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Option_DeleteButton);
        }
        public static IWebElement Menu_Disclaimer()
        {
            ScanPage(Utility.Constants.PropertyAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Menu_Disclaimer);
        }
        public static IWebElement DynamicPricingGrid_Name(int num)
        {
          //  ScanPage(Utility.Constants.PropertyAdmin);
           // CurrentPageName = PageName;
           // CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//table[@id='dynamicPricingTable']//tr[" + num + "]/td[1]");
        }
        public static IWebElement DynamicPricingGrid_StartDate(int num)
        {
          //  ScanPage(Utility.Constants.PropertyAdmin);
          //  CurrentPageName = PageName;
          //  CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//table[@id='dynamicPricingTable']//tr[" + num + "]/td[2]");
        }
        public static IWebElement DynamicPricingGrid_EndDate(int num)
        {
         //    ScanPage(Utility.Constants.PropertyAdmin);
          //  CurrentPageName = PageName;
          //  CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//table[@id='dynamicPricingTable']//tr[" + num + "]/td[3]");
        }
    }
}
