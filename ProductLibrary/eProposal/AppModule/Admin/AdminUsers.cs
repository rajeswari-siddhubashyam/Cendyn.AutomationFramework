using Common;
using BaseUtility.Utility;
using eProposal.PageObject.Admin;
using NUnit.Framework;
using InfoMessageLogger;

namespace eProposal.AppModule.Admin
{
    internal class AdminUsers : Helper
    {
        public static void Click_Button_Yes()
        {
            Helper.ElementClick(PageObject_AdminUsers.AdminUsers_Button_Yes());
        }

        public static void Click_Button_No()
        {
            Helper.ElementClick(PageObject_AdminUsers.AdminUsers_Button_No());
        }

        public static void Click_View_CustomSignatureValidator()
        {
            if (PageObject_AdminUsers.AdminUsers_View_CustomSignatureValidator().Displayed)
                Logger.WriteInfoMessage("Error appeared stating to upload a valid image file.");
            else
                Assert.Fail("Error not appeared stating to upload a valid image file.");
        }

        public static void Click_Link_LoginShowAll()
        {
            Helper.ElementClick(PageObject_AdminUsers.AdminUsers_Link_LoginShowAll());
        }

        public static void Click_Button_Update()
        {
            Helper.ElementClick(PageObject_AdminUsers.AdminUsers_Button_Update());
        }

        public static void Click_Link_Remove()
        {
            Helper.ElementClick(PageObject_AdminUsers.AdminUsers_Link_Remove());
        }

        public static void Click_Link_EditFirstUser()
        {
            Helper.ElementClick(PageObject_AdminUsers.AdminUsers_Link_EditFirstUser());
        }

        public static void Click_Link_Search()
        {
            Helper.ElementClick(PageObject_AdminUsers.AdminUsers_Link_Search());
        }

        public static void Enter_Text_Search(string Text)
        {
            Helper.ElementEnterText(PageObject_AdminUsers.AdminUsers_Text_Search(), Text);
        }

        public static void Click_Link_LogIn()
        {
            Helper.ElementClick(PageObject_AdminUsers.AdminUsers_Link_LogIn());
        }

        public static void Select_Dropdown_Option1(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_AdminUsers.AdminUsers_Dropdown_Option1(), text);
            Time.AddDelay(2500);
        }

        public static void Select_Dropdown_Option2(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_AdminUsers.AdminUsers_Dropdown_Option2(), text);
            Time.AddDelay(2500);
        }

        public static void Enter_Input_Searchbox(string text)
        {
            Helper.ElementEnterText(PageObject_AdminUsers.AdminUsers_Input_Searchbox(), text);
            Time.AddDelay(2500);
        }

        public static void Click_Button_Search()
        {
            Helper.ElementClick(PageObject_AdminUsers.AdminUsers_Button_Search());
        }

        public static void Click_Link_Edit()
        {
            Helper.ElementClick(PageObject_AdminUsers.AdminUsers_Link_Edit());
        }

        public static void Upload_Button_ChooseFile(string location)
        {
            UploadFile(PageObject_AdminUsers.AdminUsers_Button_ChooseFile(), location);
        }

        public static void Click_Link_AddNewUser()
        {
            Helper.ElementClick(PageObject_AdminUsers.AdminUsers_Link_AddNewUser());
        }

        public static void Enter_Input_Firstname(string text)
        {
            Helper.ElementEnterText(PageObject_AdminUsers.AdminUsers_Text_Firstname(), text);
            Time.AddDelay(2500);
        }

        public static void Enter_Input_Lastname(string text)
        {
            Helper.ElementEnterText(PageObject_AdminUsers.AdminUsers_Text_Lastname(), text);
            Time.AddDelay(2500);
        }

        public static void Enter_Input_Email(string text)
        {
            Helper.ElementEnterText(PageObject_AdminUsers.AdminUsers_Text_Email(), text);
            Time.AddDelay(2500);
        }

        public static void Enter_Input_Password(string text)
        {
            Helper.ElementEnterText(PageObject_AdminUsers.AdminUsers_Text_Password(), text);
            Time.AddDelay(2500);
        }

        public static void Click_Link_UserRole()
        {
            Helper.ElementClick(PageObject_AdminUsers.AdminUsers_Link_UserRole());
        }

        public static void Enter_Dropdown_SelectLevel(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_AdminUsers.AdminUsers_Dropdown_SelectLevel(), text);
            Time.AddDelay(2500);
        }

        public static void Enter_Input_PropertyName(string text)
        {
            Helper.ElementEnterText(PageObject_AdminUsers.AdminUsers_Text_PropertyName(), text);
            Time.AddDelay(2500);
        }

        public static void Click_Button_SearchProperty()
        {
            Helper.ElementClick(PageObject_AdminUsers.AdminUsers_Button_SearchProperty());
            Time.AddDelay(2500);
        }

        public static void Click_Checkbox_Property()
        {
            Helper.ElementClick(PageObject_AdminUsers.AdminUsers_Checkbox_Property());
            Time.AddDelay(2500);
        }

        public static void Click__Arrow_AddToRight()
        {
            Helper.ElementClick(PageObject_AdminUsers.AdminUsers_Arrow_AddToRight());
            Time.AddDelay(2500);
        }

        public static void Click_Arrow_AddToRight()
        {
            Helper.ElementClick(PageObject_AdminUsers.AdminUsers_Arrow_AddToRight());
            Time.AddDelay(2500);
        }

        public static void Click_Button_Submit()
        {
            Helper.ElementClick(PageObject_AdminUsers.AdminUsers_Button_Submit());
            Time.AddDelay(2500);
        }

        public static void Click_Button_Save()
        {
            Helper.ElementClick(PageObject_AdminUsers.AdminUsers_Button_Save());
            Time.AddDelay(2500);
        }

        public static void Click_RadioButton_AccessSetting()
        {
            Helper.ElementClick(PageObject_AdminUsers.AdminUsers_RadioButton_AccessSetting());
            Time.AddDelay(2500);
        }

        /// <summary>
        ///     Method to Add New User under Users tab.
        /// </summary>
        public static void AddNewUser(string firstname, string lastname, string email, string password, string userRole,
            string propertyName)
        {
            Click_Link_AddNewUser();
            Enter_Input_Firstname(firstname);
            Enter_Input_Lastname(lastname);
            Enter_Input_Email(email);
            Enter_Input_Password(password);
            Click_RadioButton_AccessSetting();
            Time.ScrollDownUsingJavaScript(CommonMethod.Driver, 2500);
            Click_Link_UserRole();
            Enter_Dropdown_SelectLevel(userRole);
            Enter_Input_PropertyName(propertyName);
            Click_Button_SearchProperty();
            Click_Checkbox_Property();
            Click_Arrow_AddToRight();
            Click_Button_Submit();
        }

        /// <summary>
        ///     Method to Search User under Users tab.
        /// </summary>
        public static void SearchUser(string option1, string option2, string searchtext)
        {
            Click_Link_Search();
            Select_Dropdown_Option1(option1);
            Select_Dropdown_Option2(option2);
            Enter_Input_Searchbox(searchtext);
            Click_Button_Search();
            Time.AddDelay(5000);
        }

        /// <summary>
        ///     Method will return the scr file details on Signature uploaded.
        /// </summary>
        /// <returns></returns>
        public static string Get_CustomSignature_Name()
        {
            var CustomSignatureSRC = PageObject_AdminUsers.AdminUsers_EmployeeUpdate_CustomSignatureImage()
                .GetAttribute("src");
            var CustomSignatureSplit = CustomSignatureSRC.Split('/');
            var CustomSignatureInitial = CustomSignatureSplit[5];
            var Custom = CustomSignatureInitial.Split('?');
            var imageName = Custom[0];
            return imageName;
        }
    }
}