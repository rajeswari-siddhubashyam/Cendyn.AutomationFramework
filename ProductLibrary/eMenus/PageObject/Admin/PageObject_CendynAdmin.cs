using BaseUtility.PageObject;
using eMenus.Utility;
using OpenQA.Selenium;
using System.Reflection;

namespace eMenus.PageObject.Admin
{
    class PageObject_CendynAdmin : Setup
    {
        public static string PageName = Utility.Constants.CendynAdmin;

        public static IWebElement Click_Property_BasicSettings_Tab()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Property_BasicSettings_Tab);
        }
        public static IWebElement Click_DynamicPrice_YesButton()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_DynamicPrice_YesButton);
        }
        public static IWebElement Click_DynamicPrice_NoButton()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_DynamicPrice_NoButton);
        }
        public static IWebElement Click_Property_UpdateButton()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Click_Property_UpdateButton);
        }


        public static IWebElement Verificationcode()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Verificationcode);
        }
        public static IWebElement Click_Dropdown()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Click_Dropdown);
        }

        public static IWebElement Cendynadmin_Verificationcode()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Cendynadmin_Verificationcode);
        }
        public static IWebElement Click_LogOut()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_LogOut);
        }

        public static IWebElement Property_Tab()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Property_Tab);
        }
        public static IWebElement Supplier_Tab()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Supplier_Tab);
        }
        public static IWebElement Cendyn_Property_Dropdown()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Cendyn_Property_Dropdown);
        }
        public static IWebElement Cendyn_select_Property()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Cendyn_select_Property);
        }
        public static IWebElement Enter_Email_Address()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Enter_Email_Address);
        }
        public static IWebElement Next_Button()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Next_Button);
        }
        public static IWebElement Enter_Email_Password()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Enter_Email_Password);
        }
        public static IWebElement Login_Button()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Login_Button);

        }
        public static IWebElement Verification_Login()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Verification_Login);

        }
        public static IWebElement Click_category()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_category);

        }
        public static IWebElement Clone_category()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clone_category);

        }
        public static IWebElement Add_category()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Add_category);

        }
        public static IWebElement Add_category_Save()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Add_category_Save);

        }
        public static IWebElement Enter_Category_Name()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Category_Name);

        }
        public static IWebElement Click_Property_Admin()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Property_Admin);

        }
        public static IWebElement Click_Published_View()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Published_View);

        }
        public static IWebElement Click_Publish()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Publish);

        }
        public static IWebElement Popup_Publish()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Popup_Publish);

        }
        public static IWebElement Click_addSub_category(string categoryName)
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='category']//input[@value = '" + categoryName + "']//following::button[3]");

        }
        public static IWebElement Click_Addnav(string categoryName)
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("(//*[@id='category']//input[@value = '" + categoryName + "']//following::a)[1]");

        }
        public static IWebElement Click_Sub_Addnav(string sub_categoryName)
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("(//*[@id='category']//input[@value = '" + sub_categoryName + "']//following::a)[1]");

        }

        public static IWebElement Sub_category_Save()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Sub_category_Save);

        }
        public static IWebElement Sub_Sub_category_Save()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Sub_Sub_category_Save);

        }

        public static IWebElement Enter_Sub_Category_Name()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Sub_Category_Name);

        }
        public static IWebElement Click_addSub_sub_category(string Sub_Category)
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='category']//input[@value = '" + Sub_Category + "']//following::button[3]");

        }

        public static IWebElement Enter_Sub_Sub_Category()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Sub_Sub_Category);

        }
        public static IWebElement Added_CategoryDropDown(string categoryName)
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("(//*[@id='Wrapper']//a[contains(text(),'" + categoryName + "')])[1]");
        }
        public static IWebElement Enter_EditCategory_CategoryName()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_EditCategory_CategoryName);
        }

        public static IWebElement Click_EditCategory_SaveButton()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_EditCategory_SaveButton);
        }
        public static IWebElement Click_Category_Popup_DeleteButton()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Category_Popup_DeleteButton);
        }
        public static IWebElement Click_EditCategory_Button(string categoryName)
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='category']//input[@value = '" + categoryName + "']//following::button[1]");
        }
        public static IWebElement Click_DeleteCategory_Button(string categoryName)
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='category']//input[@value = '" + categoryName + "']//following::button[2]");
        }
        public static IWebElement Click_NavCategory_Button(string categoryName)
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='category']//input[@value = '" + categoryName + "']//following::button[3]");
        }
        public static IWebElement Cancel_Overlay()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Cancel_Overlay);
        }
        public static IWebElement Click_Delete_Category_Confrmation()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Delete_Category_Confrmation);
        }

        public static IWebElement Click_ShareMenu_YesButton()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_ShareMenu_YesButton);
        }
        public static IWebElement Click_ShareMenu_NoButton()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_ShareMenu_NoButton);
        }

        public static IWebElement Click_BasicSettings_UpdateButton()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Click_BasicSettings_UpdateButton);
        }
        public static IWebElement Click_MyMenu_ShareTab()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MyMenu_ShareTab);
        }
        public static IWebElement Click_AdvancedSettings_Tab()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AdvancedSettings_Tab);
        }
        public static IWebElement Click_MenuImage_YesButton()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MenuImage_YesButton);
        }
        public static IWebElement Click_MenuImage_NoButton()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_MenuImage_NoButton);
        }
        public static IWebElement Click_AdvancedSettings_UpdateButton()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AdvancedSettings_UpdateButton);
        }
        public static IWebElement Click_AddNewMenu_UploadImageButton()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AddNewMenu_UploadImageButton);
        }
        public static IWebElement Click_ePlannerCendynAdmin_Select_PropertyDropdown()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_ePlannerCendynAdmin_Select_PropertyDropdown);
        }
        public static IWebElement Enter_ePlannerCendynAdmin_Property_TextBox()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_ePlannerCendynAdmin_Property_TextBox);
        }
        public static IWebElement Select_ePlannerCendynAdmin_Property_Dropdown()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_ePlannerCendynAdmin_Property_Dropdown);
        }
        public static IWebElement Click_Supplier_Category_HomeEdit()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Supplier_Category_HomeEdit);
        }
        public static IWebElement Click_Supplier_Category_InformationEdit()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Supplier_Category_InformationEdit);
        }
        public static IWebElement Select_CategoryType_Dropdown()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Select_CategoryType_Dropdown);
        }
    
    
        public static IWebElement Click_SupplierSettings_Tab()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_SupplierSettings_Tab);
        }
        public static IWebElement Click_LogoImage_Delete()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Click_LogoImage_Delete);
        }
        public static IWebElement Click_SupplierSettings_UpdateButton()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Click_SupplierSettings_UpdateButton);
        }
        public static IWebElement Click_Logo_UploadButton()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Click_Logo_UploadButton);
        }
        public static IWebElement Click_ePlanner_SupplierTab()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_ePlanner_SupplierTab);
        }
        public static IWebElement Click_ePlanner_CategoryTab()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_ePlanner_CategoryTab);
        }
        public static IWebElement Click_ePlanner_AddCategory()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_ePlanner_AddCategory);
        }
        public static IWebElement Enter_ePlanner_CategoryName()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_ePlanner_CategoryName);
        }
        public static IWebElement Click_ePlanner_AddCategory_SaveButton()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_ePlanner_AddCategory_SaveButton);
        }
        public static IWebElement CategoryName(int num)
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//ul[@class='cat-main']/li[" + num + "]//input[@type = 'text' and @class='form-control' and @placeholder='Label']");
        }

        public static IWebElement Select_Supplier_DDM()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Select_Supplier_DDM);
        }
        public static IWebElement Click_Category_CloneCategoryButton()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Category_CloneCategoryButton);
        }
        public static IWebElement Enter_CloneCategory_FromSupplier()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Enter_CloneCategory_FromSupplier);
        }
        public static IWebElement Click_CloneCategory_PDF_Checkbox()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Click_CloneCategory_PDF_Checkbox);
        }
        public static IWebElement Click_CloneCategory_SocialMedia_Checkbox()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Click_CloneCategory_SocialMedia_Checkbox);
        }
        public static IWebElement Click_CloneCategory_SaveButton()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_CloneCategory_SaveButton);
        }
        public static IWebElement Click_Category_DeleteCategoryButton()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Category_DeleteCategoryButton);
        }

        public static IWebElement Click_Contacts_Tab()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Contacts_Tab);
        }
        public static IWebElement Click_Contact_AddNewButton()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Contact_AddNewButton);
        }
        public static IWebElement Enter_AddContact_Name()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_AddContact_Name);
        }
        public static IWebElement Enter_AddContact_Title()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_AddContact_Title);
        }
        public static IWebElement Enter_AddContact_Email()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_AddContact_Email);
        }
        public static IWebElement Enter_AddContact_PhoneNumber()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_AddContact_PhoneNumber);
        }
        public static IWebElement Check_AddContact_CarbonCopy()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Check_AddContact_CarbonCopy);
        }
        public static IWebElement Check_AddContact_SelectAsManager()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Check_AddContact_SelectAsManager);
        }
        public static IWebElement Click_AddContact_CloseButton()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AddContact_CloseButton);
        }
        public static IWebElement Click_AddContact_SaveChangesButton()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AddContact_SaveChangesButton);
        }

        public static IWebElement Delete_Contact(string contactEmail)
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[contains(text(),'"+ contactEmail + "')] //following:: button[@data-target='#delContactModal']");
        }

        public static IWebElement Delete_Confirm()
        {
            ScanPage(Utility.Constants.CendynAdmin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Delete_Confirm);
        }
    }
}



