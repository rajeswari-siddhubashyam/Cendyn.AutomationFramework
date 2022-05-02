using BaseUtility.Utility;
using eMenus.AppModule.UI;
using eMenus.PageObject.Admin;
using InfoMessageLogger;
using NUnit.Framework;
using System;
using TestData;
using System.Collections.Generic;

namespace eMenus.AppModule.Admin
{
    class CendynAdmin
    {
        public static void Click_Property_BasicSettings_Tab()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_Property_BasicSettings_Tab());
        }
        public static void Click_DynamicPrice_YesButton()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_DynamicPrice_YesButton());
        }
        public static void Click_DynamicPrice_NoButton()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_DynamicPrice_NoButton());
        }
        public static void Click_Property_UpdateButton()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_Property_UpdateButton());
        }
        public static void Click_Yes_InDynamicPricing()
        {
            Click_Property_BasicSettings_Tab();
            Helper.AddDelay(3000);
            Helper.ScrollToElement(PageObject_CendynAdmin.Click_DynamicPrice_YesButton());
            if (PageObject_CendynAdmin.Click_DynamicPrice_YesButton().Selected)
            {
                Logger.WriteDebugMessage("Yes button selected");
            }
            else
            {
                Click_DynamicPrice_YesButton();
                Logger.WriteDebugMessage("Yes button selected");
            }
            Click_Property_UpdateButton();
        }

        public static void Verificationcode(string value)
        {
            Helper.ElementEnterText(PageObject_CendynAdmin.Verificationcode(), value);
        }
        public static void Click_Dropdown()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_Dropdown());
        }
        public static void Click_LogOut()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_LogOut());
        }
        public static void Property_Tab()
        {
            Helper.VerifyElementOnPage(PageObject_CendynAdmin.Property_Tab());
        }
        public static void Supplier_Tab()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Supplier_Tab());
        }

        public static void Cendyn_Property_Dropdown()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Cendyn_Property_Dropdown());
        }
        public static void Cendyn_select_Property(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_CendynAdmin.Cendyn_select_Property(), text);
        }
        public static void Login_Button()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Login_Button());
        }

        public static void Verification_Login()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Verification_Login());
        }
        public static void Click_category()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_category());
        }
        public static string Clone_category()
        {
            return PageObject_CendynAdmin.Clone_category().GetAttribute("class");

        }
        public static void Add_category()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Add_category());
        }
        public static void Add_category_Save()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Add_category_Save());
        }
        public static void Enter_Category_Name(string value)
        {
            Helper.ElementEnterText(PageObject_CendynAdmin.Enter_Category_Name(), value);
        }
        public static void Click_Property_Admin()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_Property_Admin());
        }
        public static void Click_Published_View()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_Published_View());
        }
        public static void Click_Publish()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_Publish());
        }
        public static void Popup_Publish()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Popup_Publish());
        }
        public static void NavigatetoCendynProperty(string property)
        {

            CendynAdmin.Cendyn_Property_Dropdown();
            Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
            PropertyAdmin.Enter_Property_TextBox(property);
            Logger.WriteDebugMessage("Entered Property");
            CendynAdmin.Cendyn_select_Property(property);
            Logger.WriteDebugMessage(property + " Property got Selected");
        }
        public static void Click_addSub_category(string categoryName)
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_addSub_category(categoryName));
        }
        public static void Click_addSub_sub_category(string sub_CategoryName)
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_addSub_sub_category(sub_CategoryName));
        }
        public static void Click_Addnav(string categoryName)
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_Addnav(categoryName));
        }
        public static void Click_Sub_Addnav(string sub_categoryName)
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_Sub_Addnav(sub_categoryName));
        }

        public static void Sub_category_Save()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Sub_category_Save());
        }
        public static void Sub_Sub_category_Save()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Sub_Sub_category_Save());
        }


        public static void Enter_Sub_Category_Name(string value)
        {
            Helper.ElementEnterText(PageObject_CendynAdmin.Enter_Sub_Category_Name(), value);
        }
        public static void Enter_Sub_Sub_Category(string value)
        {
            Helper.ElementEnterText(PageObject_CendynAdmin.Enter_Sub_Sub_Category(), value);
        }
        public static void Added_CategoryDropDown(string categoryName)
        {
            Helper.ElementClick(PageObject_CendynAdmin.Added_CategoryDropDown(categoryName));
        }
        public static void AddCategory(string categoryname, string sub_CategoryName, string sub_sub_CategoryName, string categoryValidation)
        {
            //Click on Add Category
            Add_category();
            Helper.VerifyTextOnPageAndHighLight("Add Category");
            Logger.WriteDebugMessage("Add category pop up is displayed");
            Add_category_Save();
            Helper.VerifyTextOnPageAndHighLight(categoryValidation);
            Logger.WriteDebugMessage("Validation message is displayed for required field");
            Enter_Category_Name(categoryname);
            Logger.WriteDebugMessage("Entered the Category Details");
            Add_category_Save();
            Logger.WriteDebugMessage("Category should get added successfully");
            Helper.PageDown();
            Logger.WriteDebugMessage("Added category displayed");

            //Add sub category
            Click_addSub_category(categoryname);
            Logger.WriteDebugMessage("Sub category drop-down displayed");
            Click_Addnav(categoryname);
            Logger.WriteDebugMessage("Sub category pop up displayed");
            Sub_category_Save();
            Helper.VerifyTextOnPageAndHighLight(categoryValidation);
            Logger.WriteDebugMessage("Validation message displayed for required filed");
            Enter_Sub_Category_Name(sub_CategoryName);
            Logger.WriteDebugMessage("Entered Sub category name");
            Sub_category_Save();
            Logger.WriteDebugMessage("Sub category added successfully");


            //Add Sub sub category
            Click_addSub_sub_category(sub_CategoryName);
            Logger.WriteDebugMessage("Sub-sub category drop-down displayed");
            Click_Sub_Addnav(sub_CategoryName);
            Logger.WriteDebugMessage("Sub-sub category pop up displayed");
            Sub_Sub_category_Save();
            Helper.VerifyTextOnPageAndHighLight(categoryValidation);
            Logger.WriteDebugMessage("Validation message displayed for required filed");
            Enter_Sub_Sub_Category(sub_sub_CategoryName);
            Logger.WriteDebugMessage("Enter Sub-sub category name");
            Sub_Sub_category_Save();
            Logger.WriteDebugMessage("Sub-Sub category added successfully");
        }

        public static void NavigateToPropertyAdmin()
        {
            Helper.PageUp();
            Click_Dropdown();
            Logger.WriteDebugMessage("Dropdown item is displayed");
            Click_Property_Admin();
            Logger.WriteDebugMessage("Click Property admin");
            Helper.AddDelay(1000);
            Logger.WriteDebugMessage("Landed on property admin page");
        }
        public static void Click_EditCategory_Button(string categoryName)
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_EditCategory_Button(categoryName));
        }
        public static void Click_DeleteCategory_Button(string categoryName)
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_DeleteCategory_Button(categoryName));
        }
        public static void Click_NavCategory_Button(string categoryName)
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_NavCategory_Button(categoryName));
        }

        public static void Enter_EditCategory_CategoryName(string text)
        {
            Helper.ElementClearText(PageObject_CendynAdmin.Enter_EditCategory_CategoryName());
            Helper.ElementEnterText(PageObject_CendynAdmin.Enter_EditCategory_CategoryName(), text);
        }

        public static void Click_EditCategory_SaveButton()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_EditCategory_SaveButton());
        }
        public static void Click_Category_Popup_DeleteButton()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_Category_Popup_DeleteButton());
        }
        public static void Cancel_Overlay()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Cancel_Overlay());
        }
        public static void Click_Delete_Category_Confrmation()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_Delete_Category_Confrmation());
        }


        public static void Edit_Category(string category, string sub_Category, string sub_sub_Caterogy)
        {
            string edit = "_edit";
            // Edit main category
            Helper.PageDown();
            Click_EditCategory_Button(category);
            Helper.PageUp();
            Logger.WriteDebugMessage("Main category edit button clicked");
            Enter_EditCategory_CategoryName(category + edit);
            Logger.WriteDebugMessage("Category name entered");
            Click_EditCategory_SaveButton();
            Cancel_Overlay();
            Helper.PageDown();
            Logger.WriteDebugMessage("Edited category saved successfully");

            //Edit sub category
            Click_EditCategory_Button(sub_Category);
            Helper.PageUp();
            Logger.WriteDebugMessage("Sub category edit button clicked");
            Enter_EditCategory_CategoryName(sub_Category + edit);
            Logger.WriteDebugMessage("Category name entered");
            Click_EditCategory_SaveButton();
            Cancel_Overlay();
            Helper.PageDown();
            Logger.WriteDebugMessage("Edited category saved successfully");

            //Edit sub to sub category
            Click_EditCategory_Button(sub_sub_Caterogy);
            Helper.PageUp();
            Logger.WriteDebugMessage("Sub sub category edit button clicked");
            Enter_EditCategory_CategoryName(sub_sub_Caterogy + edit);
            Logger.WriteDebugMessage("Category name entered");
            Click_EditCategory_SaveButton();
            Cancel_Overlay();
            Helper.PageDown();
            Logger.WriteDebugMessage("Edited category saved successfully");
        }
        public static void DeleteCategory(string categoryName)
        {
            Helper.PageDown();
            Click_DeleteCategory_Button(categoryName);
            Logger.WriteDebugMessage("Delete Category Confirmation Overlay got Displayed");
            Click_Delete_Category_Confrmation();
            if (Helper.IsWebElementRemoved(PageObject_CendynAdmin.Click_DeleteCategory_Button(categoryName)))
            {
                Logger.WriteInfoMessage(categoryName + " = Category is not Got Deleted");
                Assert.Fail(categoryName + " = Category is not Got Deleted");
            }
            else
                Logger.WriteDebugMessage(categoryName + " = Category got Deleted Successfully");
        }
        public static void Click_ShareMenu_YesButton()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_ShareMenu_YesButton());
        }
        public static void Click_ShareMenu_NoButton()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_ShareMenu_NoButton());
        }
        public static void Click_BasicSettings_UpdateButton()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_BasicSettings_UpdateButton());
        }
        public static void Click_AdvancedSettings_Tab()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_AdvancedSettings_Tab());
        }
        public static void Click_MenuImage_YesButton()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_MenuImage_YesButton());
        }
        public static void Click_MenuImage_NoButton()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_MenuImage_NoButton());
        }
        public static void Click_AdvancedSettings_UpdateButton()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_AdvancedSettings_UpdateButton());
        }
        public static void AddSingleCategory(string categoryname)
        {
            //Click on Add Category
            Add_category();
            Helper.VerifyTextOnPageAndHighLight("Add Category");
            Logger.WriteDebugMessage("Add category pop up is displayed");
            Enter_Category_Name(categoryname);
            Logger.WriteDebugMessage("Entered the Category Details");
            Add_category_Save();
            Logger.WriteDebugMessage("Category should get added successfully");
            Helper.PageDown();
            Logger.WriteDebugMessage("Added category displayed");
        }
        public static void Edit_SingleCategory(string category, string update)
        {

            Helper.PageDown();
            Click_EditCategory_Button(category);
            Helper.PageUp();
            Logger.WriteDebugMessage("Main category edit button clicked");
            Enter_EditCategory_CategoryName(category + update);
            Logger.WriteDebugMessage("Category name entered");
            Click_EditCategory_SaveButton();
            Cancel_Overlay();
            Helper.PageDown();
            Logger.WriteDebugMessage("Edited category saved successfully");
        }
        public static void ePlanner_NavigatetoProperty_CendynAdmin(string propertyName)
        {
            Click_ePlannerCendynAdmin_Select_PropertyDropdown();
            Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
            Enter_ePlannerCendynAdmin_Property_TextBox(propertyName);
            Logger.WriteDebugMessage("Entered Property");
            Select_ePlannerCendynAdmin_Property_Dropdown(propertyName);
            Logger.WriteDebugMessage(propertyName + " Property got Selected");
        }
        public static void Click_ePlannerCendynAdmin_Select_PropertyDropdown()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_ePlannerCendynAdmin_Select_PropertyDropdown());
        }
        public static void Enter_ePlannerCendynAdmin_Property_TextBox(string hotel)
        {
            Helper.ElementEnterText(PageObject_CendynAdmin.Enter_ePlannerCendynAdmin_Property_TextBox(), hotel);
        }
        public static void Select_ePlannerCendynAdmin_Property_Dropdown(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_CendynAdmin.Select_ePlannerCendynAdmin_Property_Dropdown(), text);
        }
        public static void Click_Supplier_Category_HomeEdit()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_Supplier_Category_HomeEdit());
        }
        public static void Click_Supplier_Category_InformationEdit()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_Supplier_Category_InformationEdit());
        }
        public static void Select_CategoryType_Dropdown(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_CendynAdmin.Select_CategoryType_Dropdown(), text);
        }
        public static void Click_SupplierSettings_Tab()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_SupplierSettings_Tab());
        }
        public static void Click_LogoImage_Delete()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_LogoImage_Delete());
        }
        public static void Click_SupplierSettings_UpdateButton()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_SupplierSettings_UpdateButton());
        }
        public static void Click_Logo_UploadButton()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_Logo_UploadButton());
        }
        public static void Click_ePlanner_SupplierTab()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_ePlanner_SupplierTab());
        }
        public static void Click_ePlanner_CategoryTab()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_ePlanner_CategoryTab());
        }
        public static void Click_ePlanner_AddCategory()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_ePlanner_AddCategory());
        }
        public static void Enter_ePlanner_CategoryName(string text)
        {
            Helper.ElementEnterText(PageObject_CendynAdmin.Enter_ePlanner_CategoryName(), text);
        }
        public static void Click_ePlanner_AddCategory_SaveButton()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_ePlanner_AddCategory_SaveButton());
        }

        public static void ePlanner_AddCategory(string categoryname, string sub_CategoryName, string sub_sub_CategoryName, string categoryValidation)
        {
            //Click on Add Category
            Click_ePlanner_AddCategory();
            Helper.VerifyTextOnPageAndHighLight("Add Category");
            Logger.WriteDebugMessage("Add category pop up is displayed");
            Click_ePlanner_AddCategory_SaveButton();
            Helper.VerifyTextOnPageAndHighLight(categoryValidation);
            Logger.WriteDebugMessage("Validation message is displayed for required field");
            Enter_ePlanner_CategoryName(categoryname);
            Logger.WriteDebugMessage("Entered the Category Details");
            Click_ePlanner_AddCategory_SaveButton();
            Logger.WriteDebugMessage("Category should get added successfully");
            Helper.PageDown();
            Logger.WriteDebugMessage("Added category displayed");

            //Add sub category
            Click_addSub_category(categoryname);
            Logger.WriteDebugMessage("Sub category drop-down displayed");
            Click_Addnav(categoryname);
            Logger.WriteDebugMessage("Sub category pop up displayed");
            Sub_category_Save();
            Helper.VerifyTextOnPageAndHighLight(categoryValidation);
            Logger.WriteDebugMessage("Validation message displayed for required filed");
            Enter_Sub_Category_Name(sub_CategoryName);
            Logger.WriteDebugMessage("Entered Sub category name");
            Sub_category_Save();
            Logger.WriteDebugMessage("Sub category added successfully");


            //Add Sub sub category
            Click_addSub_sub_category(sub_CategoryName);
            Logger.WriteDebugMessage("Sub-sub category drop-down displayed");
            Click_Sub_Addnav(sub_CategoryName);
            Logger.WriteDebugMessage("Sub-sub category pop up displayed");
            Sub_Sub_category_Save();
            Helper.VerifyTextOnPageAndHighLight(categoryValidation);
            Logger.WriteDebugMessage("Validation message displayed for required filed");
            Enter_Sub_Sub_Category(sub_sub_CategoryName);
            Logger.WriteDebugMessage("Enter Sub-sub category name");
            Sub_Sub_category_Save();
            Logger.WriteDebugMessage("Sub-Sub category added successfully");
        }
        public static void ePlanner_AddCategory(string categoryname, string categoryValidation)
        {
            //Click on Add Category
            Click_ePlanner_AddCategory();
            Helper.VerifyTextOnPageAndHighLight("Add Category");
            Logger.WriteDebugMessage("Add category pop up is displayed");
            Click_ePlanner_AddCategory_SaveButton();
            Helper.VerifyTextOnPageAndHighLight(categoryValidation);
            Logger.WriteDebugMessage("Validation message is displayed for required field");
            Enter_ePlanner_CategoryName(categoryname);
            Logger.WriteDebugMessage("Entered the Category Details");
            Click_ePlanner_AddCategory_SaveButton();
            Logger.WriteDebugMessage("Category should get added successfully");
            Helper.PageDown();
            Logger.WriteDebugMessage("Added category displayed");
        }
        public static void ePlanner_AddCategory_With_HomeLetter(string categoryname, string sub_CategoryName, string sub_sub_CategoryName, string category_type,string categoryValidation)
        {
            //Click on Add Category
            Click_ePlanner_AddCategory();
            Helper.VerifyTextOnPageAndHighLight("Add Category");
            Logger.WriteDebugMessage("Add category pop up is displayed");
            Click_ePlanner_AddCategory_SaveButton();
            Helper.VerifyTextOnPageAndHighLight(categoryValidation);
            Logger.WriteDebugMessage("Validation message is displayed for required field");
            Enter_ePlanner_CategoryName(categoryname);
            Select_CategoryType_Dropdown(category_type);
            Logger.WriteDebugMessage("Entered the Category Details");
            Click_ePlanner_AddCategory_SaveButton();
            Logger.WriteDebugMessage("Category should get added successfully");
            Helper.PageDown();
            Logger.WriteDebugMessage("Added category displayed");

            //Add sub category
            Click_addSub_category(categoryname);
            Logger.WriteDebugMessage("Sub category drop-down displayed");
            Click_Addnav(categoryname);
            Logger.WriteDebugMessage("Sub category pop up displayed");
            Sub_category_Save();
            Helper.VerifyTextOnPageAndHighLight(categoryValidation);
            Logger.WriteDebugMessage("Validation message displayed for required filed");
            Enter_ePlanner_CategoryName(sub_CategoryName);
            Select_CategoryType_Dropdown(category_type);
            Logger.WriteDebugMessage("Entered Sub category name and Category Type");
            Sub_category_Save();
            Logger.WriteDebugMessage("Sub category added successfully");


            //Add Sub sub category
            Click_addSub_sub_category(sub_CategoryName);
            Logger.WriteDebugMessage("Sub-sub category drop-down displayed");
            Click_Sub_Addnav(sub_CategoryName);
            Logger.WriteDebugMessage("Sub-sub category pop up displayed");
            Sub_Sub_category_Save();
            Helper.VerifyTextOnPageAndHighLight(categoryValidation);
            Logger.WriteDebugMessage("Validation message displayed for required filed");
            Enter_ePlanner_CategoryName(sub_sub_CategoryName);
            Select_CategoryType_Dropdown(category_type);
            Logger.WriteDebugMessage("Enter Sub-sub category name and Category Type");
            Sub_Sub_category_Save();
            Logger.WriteDebugMessage("Sub-Sub category added successfully");
        }
        public static List<string> GetListOfCategories()
        {
            int categoryCount = 1;
            //Create list for category names
            List<string> categories = new List<string>();
            while (Helper.IsWebElementRemoved(PageObject_CendynAdmin.CategoryName(categoryCount)))
            {
                categories.Add(PageObject_CendynAdmin.CategoryName(categoryCount).GetAttribute("value"));
                categoryCount++;
            }
            return categories;
        }


        public static void Select_Supplier_DDM(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_CendynAdmin.Select_Supplier_DDM(), text);
        }
        public static void Click_Category_CloneCategoryButton()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_Category_CloneCategoryButton());
        }
        public static void Enter_CloneCategory_FromSupplier(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_CendynAdmin.Enter_CloneCategory_FromSupplier(), text);
        }
        public static void Click_CloneCategory_PDF_Checkbox()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_CloneCategory_PDF_Checkbox());
        }
        public static void Click_CloneCategory_SocialMedia_Checkbox()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_CloneCategory_SocialMedia_Checkbox());
        }
        public static void Click_CloneCategory_SaveButton()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_CloneCategory_SaveButton());
        }
        public static void Click_Category_DeleteCategoryButton()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_Category_DeleteCategoryButton());
        }

        public static void Click_Contacts_Tab()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_Contacts_Tab());
        }
        public static void Click_Contact_AddNewButton()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_Contact_AddNewButton());
        }
        public static void Enter_AddContact_Name(string text)
        {
            Helper.ElementEnterText(PageObject_CendynAdmin.Enter_AddContact_Name(), text);
        }
        public static void Enter_AddContact_Title(string text)
        {
            Helper.ElementEnterText(PageObject_CendynAdmin.Enter_AddContact_Title(), text);
        }
        public static void Enter_AddContact_Email(string text)
        {
            Helper.ElementEnterText(PageObject_CendynAdmin.Enter_AddContact_Email(), text);
        }
        public static void Enter_AddContact_PhoneNumber(string text)
        {
            Helper.ElementEnterText(PageObject_CendynAdmin.Enter_AddContact_PhoneNumber(), text);
        }
        public static void Check_AddContact_CarbonCopy()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Check_AddContact_CarbonCopy());
        }
        public static void Check_AddContact_SelectAsManager()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Check_AddContact_SelectAsManager());
        }
        public static void Click_AddContact_CloseButton()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_AddContact_CloseButton());
        }
        public static void Click_AddContact_SaveChangesButton()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Click_AddContact_SaveChangesButton());
        }

        public static void Delete_Contact(string contactEmail)
        {
            Helper.ElementClick(PageObject_CendynAdmin.Delete_Contact(contactEmail));
        }

        public static void Delete_Confirm()
        {
            Helper.ElementClick(PageObject_CendynAdmin.Delete_Confirm());
        }

    }
}
