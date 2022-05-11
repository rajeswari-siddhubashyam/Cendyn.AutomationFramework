using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace eMenus.Utility
{
    class ObjectRepository
    {
        #region[SignUp]
        public static string SignUp_CreateAccount { get; set; }
        public static string SignUp_FirstName { get; set; }
        public static string SignUp_LastName { get; set; }
        public static string SignUp_Phone { get; set; }
        public static string SignUp_Email { get; set; }
        public static string SignUp_Password { get; set; }
        public static string SignUp_Confirm_Password { get; set; }
        public static string SignUp_Button { get; set; }
        public static string FirstName_Validation { get; set; }
        public static string LastName_Validation { get; set; }
        public static string Phone_Validation { get; set; }
        public static string Email_Validation { get; set; }
        public static string Password_Validation { get; set; }
        public static string ConfirmPassword_Validation { get; set; }
        public static string CreateSuccess_Signin { get; set; }
        public static string Existing_Email_Validation { get; set; }
        #endregion[SignUp]

        #region[SignIn]

        public static string SignIn_UserName { get; set; }
        public static string SignIn_Password { get; set; }
        public static string SignIn_Button { get; set; }
        public static string Validation_Message { get; set; }
        



        #endregion[SignIn]

        #region[CatchAll]
        public static string catchaAll_GetStarted { get; set; }
        public static string Activation_Email_Link { get; set; }
        public static string Reset_Password_Button { get; set; }
        public static string Forgot_Password_Button { get; set; }
        public static string catchAll_SignIn_Email { get; set; }
        public static string catchAll_SignIn_Password { get; set; }
        public static string catchAll_SignIn_Button { get; set; }
        public static string SignIn_DontShowAgainCheckBox { get; set; }
        public static string SignIn_YesButton { get; set; }
        public static string OutLookIcon { get; set; }
        public static string CatchAll_Recent_Email { get; set; }
        public static string CatchAll_Recent_Email1 { get; set; }
        public static string Support_Email { get; set; }
        public static string Share_Menu_Email { get; set; }
        public static string Login_Cendyn_Access { get; set; }
        

        #endregion[CatchAll]

        #region[Navigation]
        public static string Create_NewOrder { get; set; }
        public static string SignIn_Link { get; set; }
        public static string Click_Button_MyAccount { get; set; }
        public static string Click_MyAccount_SignOut { get; set; }
        #endregion[Navigation]

        #region[Forget Password]

        public static string Click_ForgetPassword { get; set; }
        public static string Click_ForgetPassword_BackButton { get; set; }
        public static string ForgetPassword_Email { get; set; }
        public static string Click_ForgetPassword_SendButton { get; set; }
        public static string Forget_Password_Validation { get; set; }
        public static string ForgetPassword_Confirmation_Back { get; set; }
        public static string ResetPassword_Email { get; set; }
        public static string ResetPassword_Password { get; set; }
        public static string ResetPassword_ConfirmPassword { get; set; }
        public static string ResetPassword_Button { get; set; }



        #endregion[Forget Password]

        #region[Manage My Account]

        public static string Click_MyOrder_ManageMyAccount { get; set; }
        public static string Click_MyOrder_MyOrder { get; set; }
        public static string ManageMyAccount_FirstName { get; set; }
        public static string ManageMyAccount_LastName { get; set; }
        public static string ManageMyAccount_Address { get; set; }
        public static string ManageMyAccount_Address2 { get; set; }
        public static string ManageMyAccount_Country { get; set; }
        public static string ManageMyAccount_State { get; set; }
        public static string ManageMyAccount_City { get; set; }
        public static string ManageMyAccount_PostalCode { get; set; }
        public static string ManageMyAccount_Phone { get; set; }
        public static string ManageMyAccount_Company { get; set; }
        public static string ManageMyAccount_BackButton { get; set; }
        public static string ManageMyAccount_UpdateButton { get; set; }
        public static string ManageMyAccount_FirstName_Validation { get; set; }
        public static string ManageMyAccount_LastName_Validation { get; set; }
        public static string ManageMyAccount_PhoneValidation { get; set; }

        public static string Update_Password_Checkbox { get; set; }
        public static string Update_Password { get; set; }
        public static string Update_Confirm_Password { get; set; }
        #endregion[Manage My Account]

        #region[My Order]
        public static string EventName { get; set; }
        public static string Event_StartDate { get; set; }
        public static string Event_EndDate { get; set; }
        public static string Click_CreateOrder { get; set; }
        public static string Click_AddFunction { get; set; }
        public static string FunctionName { get; set; }
        public static string NoOfGuest { get; set; }
        public static string FunctionRoom { get; set; }
        public static string FunctionType { get; set; }
        public static string SetupType { get; set; }
        public static string Click_CreateFunction { get; set; }
        public static string AddMenu { get; set; }

        public static string SelectMenu { get; set; }
        public static string GotoMenu { get; set; }
        public static string AddMenuItem { get; set; }
        public static string AddMenuItemNext { get; set; }
        public static string CheckChoice { get; set; }
        public static string AddMenuChoice { get; set; }
        public static string Click_GoToEventDetails { get; set; }
        public static string Click_ReviewOrder { get; set; }
        public static string Event_Payment_Method { get; set; }

        public static string Customer_FirstName { get; set; }
        public static string Customer_LastName { get; set; }
        public static string Customer_Address { get; set; }
        public static string Customer_Address2 { get; set; }
        public static string Customer_City { get; set; }
        public static string Customer_State { get; set; }
        public static string Customer_PostalCode { get; set; }
        public static string Customer_Country { get; set; }
        public static string Customer_Phone { get; set; }
        public static string Customer_Email { get; set; }
        public static string Customer_Company { get; set; }
        public static string Select_Contact { get; set; }
        public static string Click_Continue { get; set; }
        public static string Click_Save_Order { get; set; }
        public static string Click_MyOrder { get; set; }
        public static string Search_Filter { get; set; }
        public static string Click_EditOrder { get; set; }
        public static string Click_SendOrder { get; set; }
        public static string Click_SendOrder_Confirmation { get; set; }


        #endregion[My Order]

        #region[My Orders]

        public static string Click_CreateNewOrder { get; set; }
        public static string Enter_EventName { get; set; }
        public static string FromDate { get; set; }
        public static string ToDate { get; set; }
        public static string Click_CancelButton { get; set; }
        public static string Click_SaveButton { get; set; }
        public static string SearchFilter { get; set; }



        #endregion[My Orders]

        #region[Event Details]

        public static string ClickAddFunction { get; set; }
        public static string FunctionDate { get; set; }
        public static string Function_Name { get; set; }
        public static string NumberOfGuests { get; set; }
        public static string Function_Room { get; set; }
        public static string Function_Type { get; set; }
        public static string SetupStyle { get; set; }
        public static string StartTime { get; set; }
        public static string EndTime { get; set; }
        public static string CancelButton { get; set; }
        public static string SaveButton { get; set; }
        public static string Click_AddMenu { get; set; }
        public static string MenuName { get; set; }
        public static string AddMenu_CancelButton { get; set; }
        public static string GoToMenu_Button { get; set; }
        public static string AddMenu_AddClick { get; set; }
        public static string AddMenuModal_CancelButton { get; set; }
        public static string AddMenuModal_AddButton { get; set; }
        public static string GoToEventDetails { get; set; }
        public static string ClickReviewOrder { get; set; }
        public static string OrderInformation_Contact { get; set; }
        public static string OrderInformation_PaymentMothod { get; set; }
        public static string OrderInformation_ContinueButton { get; set; }
        public static string ReviewOrder_SaveButton { get; set; }
        public static string MyOrders_Button { get; set; }
        public static string Click_AddMenuModal_CancelButton { get; set; }
        public static string ReviewOrder_SendButton { get; set; }
        public static string ReviewOrder_SendOrder_SendButton { get; set; }
        public static string SendOrdersMyOrders_Button { get; set; }

        public static string Click_Comment_Function { get; set; }
        public static string EnterComments { get; set; }
        public static string Click_AddComment { get; set; }
        public static string Click_Edit_Function { get; set; }
        public static string Click_Copy_Function { get; set; }
        public static string Enter_CloneFunctionName { get; set; }
        public static string Select_CloneFunctionDate { get; set; }
        public static string Click_CloneSaveFunction { get; set; }
        public static string Click_Delete_Function { get; set; }
        public static string Click_DeleteFunctionbutton { get; set; }

        public static string Click_Edit_Menu { get; set; }
        public static string Click_Copy_Menu { get; set; }
        public static string Click_Delete_Menu { get; set; }
        public static string Enter_EditMenu_Menu_Quantity { get; set; }
        public static string Enter_EditMenu_Menu_Special_Request { get; set; }
        public static string Click_EditMenu_Menu_Save_Button { get; set; }
        public static string Select_CopyMenu_FunctionList { get; set; }
        public static string Click_CopyMenu_FunctionList_Save { get; set; }
        public static string Click_Delete_Menu_Button { get; set; }





        #endregion[Event Details]

        #region[Property Admin]

        public static string Click_Select_PropertyDropdown { get; set; }
        public static string Select_Property { get; set; }
        public static string Click_uOrder { get; set; }
        public static string uOrder_OrderSearchBox { get; set; }
        public static string PropertyAdmin_Username { get; set; }
        public static string PropertyAdmin_Password { get; set; }
        public static string Propertyadmin_Verificationcode { get; set; }
        public static string GetVerificationcode { get; set; }

        public static string Click_BackButton { get; set; }
        public static string Click_LoginButton { get; set; }
        public static string Click_NextButton { get; set; }
        public static string Click_Prperty { get; set; }
        public static string Navigation_eMenus { get; set; }
        public static string Settings_Dropdown { get; set; }
        public static string Cendyn_Admin { get; set; }
        public static string Advance_Settings { get; set; }
        public static string Uorder_Contact { get; set; }
        public static string Uorder_Update_Contact { get; set; }
        public static string Property_Dropdown { get; set; }
        public static string Property_TextBox { get; set; }
        public static string Property_Origami { get; set; }
        public static string Published_View { get; set; }
        public static string Home_Menu { get; set; }
        public static string Home_Menu_eMenu { get; set; }
        public static string Click_MyMenu_Settings { get; set; }
        public static string Click_Settings_DynamicPricing { get; set; }
        public static string Click_DynamicPricing_AddNewButton { get; set; }
        public static string AddDynamicPricing_DynamicPricingName { get; set; }
        public static string AddDynamicPricing_StartDate { get; set; }
        public static string AddDynamicPricing_EndDate { get; set; }
        public static string AddDynamicPricing_SaveChangesButton { get; set; }
        public static string AddDynamicPricing_SaveChangesYesButton { get; set; }

        public static string AddDynamicPricing_CancelButton { get; set; }
        public static string Click_AddDynamicPricing_OkButton { get; set; }
        public static string Click_MyMenu_BreakfastDropdown { get; set; }
        public static string MyMenu_BreakfastDropdown_ContinentalBreakfast { get; set; }
        public static string Click_MyMenu_AddNewMenu { get; set; }
        public static string Click_AddNewMenu_CancelButton { get; set; }
        public static string Click_AddNewMenu_SaveButton { get; set; }
        public static string AddNewMenu_MenuName { get; set; }
        public static string AddNewMenu_Price { get; set; }
        public static string AddNewMenu_DynamiPrice { get; set; }
        public static string AddNewMenu_Description { get; set; }
        public static string Click_MyMenus { get; set; }
        public static string Select_Price_Description { get; set; }
        public static string Select_DynamicPrice_Description { get; set; }
        public static string Click_Publish_Button { get; set; }
        public static string Select_Property_Dropdown { get; set; }
        public static string Click_Form_Publish_Button { get; set; }
        public static string Click_Delete_Dynamic_Price_Confirmation { get; set; }
        public static string Click_Delete_Dynamic_Price_Confirmation_OK { get; set; }
        public static string Click_MyMenu_EditMenu { get; set; }
        public static string Existing_MenuPrice { get; set; }
        public static string EditDynamicPricing_StartDate { get; set; }
        public static string EditDynamicPricing_EndDate { get; set; }
        public static string EditDynamicPricing_SaveChangesButton { get; set; }
        public static string EditDynamicPricing_DynamicPricingName { get; set; }
        public static string Click_AddNewMenu_AddChoiceButton { get; set; }
        public static string AddNewMenu_AddChoice_Name { get; set; }
        public static string AddNewMenu_AddChoice_Description { get; set; }
        public static string Click_AddNewMenu_NewOptionButton { get; set; }
        public static string AddNewMenu_AddChoice_Option { get; set; }
        public static string AddNewMenu_AddChoice_Price { get; set; }
        public static string Click_AddNewMenu_NewOptionButton2 { get; set; }
        public static string AddNewMenu_AddChoice_Option2 { get; set; }
        public static string AddNewMenu_AddChoice_Price2 { get; set; }
        public static string Click_AddNewMenu_BottomSaveButton { get; set; }
        public static string Click_MyMenu_PreviewButton { get; set; }
        public static string Click_Preview_BreakfastDropdown { get; set; }
        public static string Click_Preview_ContinentalBreakfast { get; set; }
        public static string Click_MyMenu_PublishButton { get; set; }
        public static string Click_MyMenu_PublishSaveButton { get; set; }
        public static string GetDescriptionId_AddChoices { get; set; }
        public static string Enter_Add_On_Title { get; set; }
        public static string Click_New_Add_On { get; set; }
        public static string Enter_Add_On_Price1 { get; set; }
        public static string Enter_Add_On_Price2 { get; set; }
        public static string SSO_Validation_Message { get; set; }
        public static string Log_Out { get; set; }
        public static string Social_Media_Tab { get; set; }
        public static string Add_New_Social_Media { get; set; }
        public static string Social_Media_Dropdown { get; set; }
        public static string Social_Media_Type_Validation { get; set; }
        public static string Social_Media_URL { get; set; }
        public static string Social_Media_URL_Validation { get; set; }
        public static string Social_Media_Save_Changes { get; set; }
        public static string Social_Media_Close { get; set; }
        public static string OK_Button { get; set; }
        public static string Yes_Button { get; set; }
        
        public static string Edit_Social_Media_Dropdown { get; set; }
        public static string Edit_Social_Media_URL { get; set; }
        public static string Edit_Social_Media_Save_Changes { get; set; }
        public static string Settings_MenuFilter_Tab { get; set; }
        public static string Settings_MenuFilter_AddTag { get; set; }
        public static string Settings_MenuFilter_AddTag_Name { get; set; }
        public static string Settings_MenuFilter_AddTag_DeleteButton { get; set; }
        public static string Settings_MenuFilter_AddTag_SaveButton { get; set; }
        public static string Click_AddNewMenu_AddedTag_Filter { get; set; }
        public static string Settings_MenuFilter_DeleteTag_ContinueButton { get; set; }
        public static string Click_Menu_Info_Button { get; set; }
        public static string First_Menu_Price_Preview { get; set; }
        public static string First_Menu_Price_Admin { get; set; }
        
        public static string Click_FindReplace { get; set; }
        public static string Enter_FindText { get; set; }
        public static string Enter_ReplaceText { get; set; }
        public static string Click_FindReplace_Find { get; set; }
        public static string Click_FindReplace_ReplaceAll { get; set; }
        public static string Click_FindReplace_Done { get; set; }
        public static string Click_MyMenu_DeleteMenu { get; set; }
        public static string Click_MyMenu_DeleteMenu_Confirm { get; set; }
        public static string Click_Main_Navigation_Dropdown { get; set; }
        public static string Click_Link_PDF_View { get; set; }
        public static string Click_Link_Web_View { get; set; }
        public static string PassedDate_Name_DynamicPrice { get; set; }

        public static string Click_Link_Share { get; set; }
        public static string Enter_ShareMenu_Name { get; set; }
        public static string Check_Format_Checkbox { get; set; }
        public static string Check_Pricing_Checkbox { get; set; }
        public static string Click_Continue_Button { get; set; }
        public static string Click_Search_Client_Button { get; set; }
        public static string Enter_Search_Client_Name { get; set; }
        public static string Click_SearchOverlay_Client_Button { get; set; }
        public static string Select_Searched_Client_Record { get; set; }
        public static string Cancel_Search_Client { get; set; }
        
        public static string Share_Message_Content { get; set; }
        public static string Click_Send_Email { get; set; }
        public static string Click_GoToActivity_Button { get; set; }
        public static string Search_Menu_Filter { get; set; }
        public static string Click_Action_Button { get; set; }
        public static string Click_Clone_Link { get; set; }
        public static string Click_Clone_Button { get; set; }
        public static string Click_Add_New_Client { get; set; }
        public static string Enter_Client_First_Name { get; set; }
        public static string Enter_Client_Last_Name { get; set; }
        public static string Enter_Client_Company { get; set; }
        public static string Enter_Client_Email { get; set; }
        public static string Click_Save_Save { get; set; }
        public static string Click_Generate_Link { get; set; }
        public static string Get_ShareMenu_Link { get; set; }
        public static string Click_Preview_Button { get; set; }
        public static string Click_Menu_FoodAndBeverages { get; set; }
        public static string Click_Button_Add_Item { get; set; }
        public static string Enter_Text_Title { get; set; }
        public static string Click_Button_Save { get; set; }
        public static string Navigation_ePlanner { get; set; }
        public static string Click_Button_Delete { get; set; }
        public static string Click_AddNewMenu_AddChoiceButton2 { get; set; }
        public static string AddNewMenu_AddChoice2_Name { get; set; }
        public static string Click_AddNewMenu2_NewOptionButton { get; set; }
        public static string Click_ChoiceMoveUp_Button { get; set; }
        public static string Click_Button_UploadFromeGallery { get; set; }
        public static string Click_Image_eGallery { get; set; }
        public static string Click_Button_SelectImage { get; set; }
        public static string Click_Upload_Image { get; set; }
        public static string Click_Select_File { get; set; }
        public static string Click_Upload_File { get; set; }
        public static string Click_Image_File { get; set; }
        


        public static string Navigation_eMenusLITE { get; set; }
        public static string Click_MyMenu_Breaks { get; set; }
        public static string Click_EditCategoryDesc { get; set; }
        public static string CategoryDesc { get; set; }
        public static string Click_CategoryDesc_Save { get; set; }
        public static string Click_Publish_Close_Button { get; set; }
        public static string Click_Filter_GlutenFree { get; set; }
        public static string Click_Filter_MilkAvoidance { get; set; }
        public static string Click_Tag_MostPopular { get; set; }
        public static string Click_Form_Cancel_Button { get; set; }
        public static string Click_AddItem_CancelButton { get; set; }
        public static string Click_Menu_EditButton { get; set; }
        public static string Click_Item_Delete_Cancel { get; set; }
        public static string Click_MyPlanner_Edit { get; set; }
        public static string Enter_Category_editor { get; set; }
        public static string Click_Category_editor_save { get; set; }

        public static string Click_Menu_Item_Down { get; set; }
        public static string Click_Menu_Item_Up { get; set; }
        public static string Get_First_Item_Title_PA { get; set; }
        public static string Get_Second_Item_Title_PA { get; set; }
        public static string Get_First_Item_Title_FE { get; set; }
        public static string Get_Second_Item_Title_FE { get; set; }
        public static string Get_First_Item_Title_PM { get; set; }
        public static string Get_Second_Item_Title_PM { get; set; }
        public static string Enter_Category_Description { get; set; }
        public static string Click_Button_Category_Description_Cancel { get; set; }
        public static string Click_Button_Category_Description_Save { get; set; }
        public static string Click_Here_for_eGallery { get; set; }
        public static string Verify_eGallery_Image { get; set; }
        public static string Click_Category_Home { get; set; }
        public static string Click_Category_Information { get; set; }
        public static string ManagerProfile_Name { get; set; }
        public static string Click_Edit_Desclaimer { get; set; }
        public static string Enter_Desclaimer_Description { get; set; }

        public static string Click_Desclaimer_SaveButton { get; set; }
        public static string Click_Category_Decsription { get; set; }
        public static string Click_CategoryDescription_SaveButton { get; set; }
        public static string Click_Fronend_HomeCategory { get; set; }

        public static string Click_MyMenu_SpecialOffers { get; set; }
        public static string Property_Logo { get; set; }
        public static string Click_Link_FindAndReplace { get; set; }
        public static string Enter_Find_TextBox { get; set; }
        public static string Enter_Replace_TextBox { get; set; }
        public static string Click_Button_Find { get; set; }
        public static string Click_Button_ReplaceAll { get; set; }
        public static string Click_Button_Done { get; set; }
        public static string Get_AlertBox_Title { get; set; }
        public static string Get_Validation_Message { get; set; }
        public static string Get_Success_Validation_Message { get; set; }
        
        public static string Click_MyMenu_BreakMenu { get; set; }
        public static string BreakMenu_EditIcon { get; set; }

        public static string Click_AddOnMoveDown_Button { get; set; }
        public static string Get_AddOn1_Text { get; set; }

        public static string Click_Option_DeleteButton { get; set; }


        public static string Menu_Disclaimer { get; set; }
        #endregion[Property Admin]





        #region[Home Page]

        public static string Click_HotelOrogami_Logo { get; set; }
        public static string Click_HomePage_Filter { get; set; }
        public static string HomePage_ClearFilter { get; set; }
        public static string HomePage_ApplyFilter { get; set; }
        public static string HomePage_Search { get; set; }
        public static string HomePage_FilterBy_GlutenFree { get; set; }
        public static string HomePage_FilterBy_Egg { get; set; }
        public static string HomePage_FilterBy_Milk { get; set; }
        public static string HomePage_FilterBy_MostPopular { get; set; }
        public static string HomePage_DinnerDropdown { get; set; }
        public static string HomePage_Select_DinnerTable { get; set; }
        public static string HomePage_DinnerTable_MenuInfoButton { get; set; }
        public static string HomePage_BreakfastDropdown { get; set; }
        public static string HomePage_Select_BreakfastBuffet { get; set; }
        public static string HomePage_Select_ContinentalBreakfast { get; set; }
        public static string HomePage_BreakfastBuffet_MenuInfoButton { get; set; }
        
            
        public static string HomePage_ReceptionDropdown { get; set; }
        public static string HomePage_Select_ActionStations { get; set; }
        public static string HomePage_ActionStations_MenuInfoButton { get; set; }
        public static string Click_HomePage_MoreButton { get; set; }
        public static string HomePage_FilterBy_Favorite { get; set; }
        public static string Click_HomePage_LessButton { get; set; }
        public static string GlutenFree_MenuName { get; set; }
        public static string Egg_MenuName { get; set; }
        public static string MostPopular_MenuName { get; set; }
        public static string Continental_brkfast_MenuPrice { get; set; }
        public static string Select_Event_date { get; set; }
        public static string First_Menu_Price_Frontend { get; set; }
        public static string Click_Link_Home { get; set; }
        public static string Click_PrintIcon { get; set; }
        public static string HomePage_Breakfast { get; set; }
        public static string HomePage_Break { get; set; }


        public static string Click_GlobeIcon { get; set; }
        public static string Click_Globe_CloseIcon { get; set; }
        public static string Click_Globe_EnglishLanguage { get; set; }
        public static string Click_Globe_FrançaisLanguage { get; set; }


        #endregion[Home Page]

        #region[Cendyn Admin]
        public static string Click_Property_BasicSettings_Tab { get; set; }
        public static string Click_DynamicPrice_YesButton { get; set; }
        public static string Click_DynamicPrice_NoButton { get; set; }
        public static string Click_Property_UpdateButton { get; set; }
        public static string Verificationcode { get; set; }
      
        public static string Click_Dropdown { get; set; }
        public static string Click_LogOut { get; set; }
        public static string Property_Tab { get; set; }
        public static string Supplier_Tab { get; set; }
        public static string Cendyn_Property_Dropdown { get; set; }
        public static string Cendyn_select_Property { get; set; }
        public static string Cendyn_property_click { get; set; }
        public static string Enter_Email_Address { get; set; }
        public static string Next_Button { get; set; }
        public static string Enter_Email_Password { get; set; }
        public static string Login_Button { get; set; }
        public static string Cendynadmin_Verificationcode { get; set; }
        public static string Verification_Login { get; set; }
        public static string Click_category { get; set; }
        public static string Clone_category { get; set; }
        public static string Add_category { get; set; }
        public static string Add_category_Save { get; set; }
        public static string Enter_Category_Name { get; set; }
        public static string Click_Property_Admin { get; set; }
        public static string Click_Published_View { get; set; }
        public static string Click_Publish { get; set; }
        public static string Popup_Publish { get; set; }
        public static string Click_addSub_category { get; set; }
        public static string Click_Addnav { get; set; }
        public static string Click_Sub_Addnav { get; set; }
        
        public static string Sub_category_Save { get; set; }
        public static string Enter_Sub_Category_Name { get; set; }
        public static string Click_addSub_sub_category { get; set; }
        
        public static string Added_CategoryDropDown { get; set; }
        public static string Sub_Sub_category_Save { get; set; }
        public static string Enter_Sub_Sub_Category { get; set; }

        public static string Enter_EditCategory_CategoryName { get; set; }
        public static string Click_EditCategory_SaveButton { get; set; }
        public static string Click_Category_Popup_DeleteButton { get; set; }
        public static string Cancel_Overlay { get; set; }
        public static string Click_Delete_Category_Confrmation { get; set; }
        public static string Click_ShareMenu_YesButton { get; set; }
        public static string Click_ShareMenu_NoButton { get; set; }
        public static string Click_BasicSettings_UpdateButton { get; set; }
        public static string Click_MyMenu_ShareTab { get; set; }
        public static string Click_AdvancedSettings_Tab { get; set; }
        public static string Click_MenuImage_YesButton { get; set; }
        public static string Click_MenuImage_NoButton { get; set; }
        public static string Click_AdvancedSettings_UpdateButton { get; set; }
        public static string Click_AddNewMenu_UploadImageButton { get; set; }
        public static string Click_SupplierSettings_Tab { get; set; }
        public static string Click_LogoImage_Delete { get; set; }
        public static string Click_SupplierSettings_UpdateButton { get; set; }
        public static string Click_Logo_UploadButton { get; set; }

        public static string Click_ePlannerCendynAdmin_Select_PropertyDropdown { get; set; }
        public static string Enter_ePlannerCendynAdmin_Property_TextBox { get; set; }
        public static string Select_ePlannerCendynAdmin_Property_Dropdown { get; set; }
        public static string Click_Supplier_Category_HomeEdit { get; set; }
        public static string Click_Supplier_Category_InformationEdit { get; set; }
        public static string Select_CategoryType_Dropdown { get; set; }
        public static string CategoryName { get; set; }

        public static string Click_ePlanner_SupplierTab { get; set; }
        public static string Click_ePlanner_CategoryTab { get; set; }
        public static string Click_ePlanner_AddCategory { get; set; }
        public static string Enter_ePlanner_CategoryName { get; set; }
        public static string Click_ePlanner_AddCategory_SaveButton { get; set; }
        public static string Select_Supplier_DDM { get; set; }
        public static string Click_Category_CloneCategoryButton { get; set; }
        public static string Enter_CloneCategory_FromSupplier { get; set; }
        public static string Click_CloneCategory_PDF_Checkbox { get; set; }
        public static string Click_CloneCategory_SocialMedia_Checkbox { get; set; }
        public static string Click_CloneCategory_SaveButton { get; set; }
        public static string Click_Category_DeleteCategoryButton { get; set; }

        public static string Click_Contacts_Tab { get; set; }
        public static string Click_Contact_AddNewButton { get; set; }
        public static string Enter_AddContact_Name { get; set; }
        public static string Enter_AddContact_Title { get; set; }
        public static string Enter_AddContact_Email { get; set; }
        public static string Enter_AddContact_PhoneNumber { get; set; }
        public static string Check_AddContact_CarbonCopy { get; set; }
        public static string Check_AddContact_SelectAsManager { get; set; }
        public static string Click_AddContact_CloseButton { get; set; }
        public static string Click_AddContact_SaveChangesButton { get; set; }
        public static string Delete_Confirm { get; set; }


        #endregion[Cendyn Admin]

        #region[ePlannerFrontEndHome]
        public static string Home_SearchBox { get; set; }
        #endregion[ePlannerFrontEndHome]



        public static ObjectRepository ReadElement(string location, string nodeModule)
        {
            ObjectRepository obj = new ObjectRepository();
            XDocument doc = XDocument.Load(location);
            var query = doc.Descendants(nodeModule).Elements().ToDictionary(x => x.Attribute("key").Value, x => x.Value);

            foreach (KeyValuePair<string, string> pair in query)
            {
                if (nodeModule == Constants.SignUp)
                {
                    if (pair.Key == "SignUp_CreateAccount")
                        SignUp_CreateAccount = pair.Value;
                    else if (pair.Key == "SignUp_FirstName")
                        SignUp_FirstName = pair.Value;
                    else if (pair.Key == "SignUp_LastName")
                        SignUp_LastName = pair.Value;
                    else if (pair.Key == "SignUp_Phone")
                        SignUp_Phone = pair.Value;
                    else if (pair.Key == "SignUp_Email")
                        SignUp_Email = pair.Value;
                    else if (pair.Key == "SignUp_Password")
                        SignUp_Password = pair.Value;
                    else if (pair.Key == "SignUp_Confirm_Password")
                        SignUp_Confirm_Password = pair.Value;
                    else if (pair.Key == "SignUp_Button")
                        SignUp_Button = pair.Value;
                    else if (pair.Key == "FirstName_Validation")
                        FirstName_Validation = pair.Value;
                    else if (pair.Key == "LastName_Validation")
                        LastName_Validation = pair.Value;
                    else if (pair.Key == "Phone_Validation")
                        Phone_Validation = pair.Value;
                    else if (pair.Key == "Email_Validation")
                        Email_Validation = pair.Value;
                    else if (pair.Key == "Password_Validation")
                        Password_Validation = pair.Value;
                    else if (pair.Key == "ConfirmPassword_Validation")
                        ConfirmPassword_Validation = pair.Value;
                    else if (pair.Key == "CreateSuccess_Signin")
                        CreateSuccess_Signin = pair.Value;
                    else if (pair.Key == "Existing_Email_Validation")
                        Existing_Email_Validation = pair.Value;

                }
                else if (nodeModule == Constants.CatchAll)
                {
                    if (pair.Key == "catchaAll_GetStarted")
                        catchaAll_GetStarted = pair.Value;
                    else if (pair.Key == "Activation_Email_Link")
                        Activation_Email_Link = pair.Value;
                    else if (pair.Key == "Reset_Password_Button")
                        Reset_Password_Button = pair.Value;
                    else if (pair.Key == "Forgot_Password_Button")
                        Forgot_Password_Button = pair.Value;
                    else if (pair.Key == "catchAll_SignIn_Email")
                        catchAll_SignIn_Email = pair.Value;
                    else if (pair.Key == "catchAll_SignIn_Password")
                        catchAll_SignIn_Password = pair.Value;
                    else if (pair.Key == "catchAll_SignIn_Button")
                        catchAll_SignIn_Button = pair.Value;
                    else if (pair.Key == "SignIn_DontShowAgainCheckBox")
                        SignIn_DontShowAgainCheckBox = pair.Value;
                    else if (pair.Key == "SignIn_YesButton")
                        SignIn_YesButton = pair.Value;
                    else if (pair.Key == "OutLookIcon")
                        OutLookIcon = pair.Value;
                    else if (pair.Key == "CatchAll_Recent_Email")
                        CatchAll_Recent_Email = pair.Value;
                    else if (pair.Key == "CatchAll_Recent_Email1")
                        CatchAll_Recent_Email1 = pair.Value;
                    else if (pair.Key == "Support_Email")
                        Support_Email = pair.Value;
                    else if (pair.Key == "Share_Menu_Email")
                        Share_Menu_Email = pair.Value;
                    else if (pair.Key == "Login_Cendyn_Access")
                        Login_Cendyn_Access = pair.Value;



                }
                else if (nodeModule == Constants.SignIn)
                {

                    if (pair.Key == "SignIn_UserName")
                        SignIn_UserName = pair.Value;
                    else if (pair.Key == "SignIn_Password")
                        SignIn_Password = pair.Value;
                    else if (pair.Key == "SignIn_Button")
                        SignIn_Button = pair.Value;
                    else if (pair.Key == "Validation_Message")
                        Validation_Message = pair.Value;




                }
                else if (nodeModule == Constants.Navigation)
                {
                    if (pair.Key == "Create_NewOrder")
                        Create_NewOrder = pair.Value;
                    else if (pair.Key == "SignIn_Link")
                        SignIn_Link = pair.Value;
                    else if (pair.Key == "Click_Button_MyAccount")
                        Click_Button_MyAccount = pair.Value;
                    else if (pair.Key == "Click_MyAccount_SignOut")
                        Click_MyAccount_SignOut = pair.Value;
                }
                else if (nodeModule == Constants.ForgetPassword)
                {
                    if (pair.Key == "Click_ForgetPassword")
                        Click_ForgetPassword = pair.Value;
                    else if (pair.Key == "Click_ForgetPassword_BackButton")
                        Click_ForgetPassword_BackButton = pair.Value;
                    else if (pair.Key == "ForgetPassword_Email")
                        ForgetPassword_Email = pair.Value;
                    else if (pair.Key == "Click_ForgetPassword_SendButton")
                        Click_ForgetPassword_SendButton = pair.Value;
                    else if (pair.Key == "Forget_Password_Validation")
                        Forget_Password_Validation = pair.Value;
                    else if (pair.Key == "ForgetPassword_Confirmation_Back")
                        ForgetPassword_Confirmation_Back = pair.Value;
                    else if (pair.Key == "ResetPassword_Email")
                        ResetPassword_Email = pair.Value;
                    else if (pair.Key == "ResetPassword_Password")
                        ResetPassword_Password = pair.Value;
                    else if (pair.Key == "ResetPassword_ConfirmPassword")
                        ResetPassword_ConfirmPassword = pair.Value;
                    else if (pair.Key == "ResetPassword_Button")
                        ResetPassword_Button = pair.Value;

                }
                else if (nodeModule == Constants.ManageMyAccount)
                {
                    if (pair.Key == "Click_MyOrder_ManageMyAccount")
                        Click_MyOrder_ManageMyAccount = pair.Value;
                    else if (pair.Key == "Click_MyOrder_MyOrder")
                        Click_MyOrder_MyOrder = pair.Value;
                    else if (pair.Key == "ManageMyAccount_FirstName")
                        ManageMyAccount_FirstName = pair.Value;
                    else if (pair.Key == "ManageMyAccount_LastName")
                        ManageMyAccount_LastName = pair.Value;
                    else if (pair.Key == "ManageMyAccount_Address")
                        ManageMyAccount_Address = pair.Value;
                    else if (pair.Key == "ManageMyAccount_Address2")
                        ManageMyAccount_Address2 = pair.Value;
                    else if (pair.Key == "ManageMyAccount_Country")
                        ManageMyAccount_Country = pair.Value;
                    else if (pair.Key == "ManageMyAccount_State")
                        ManageMyAccount_State = pair.Value;
                    else if (pair.Key == "ManageMyAccount_City")
                        ManageMyAccount_City = pair.Value;
                    else if (pair.Key == "ManageMyAccount_PostalCode")
                        ManageMyAccount_PostalCode = pair.Value;
                    else if (pair.Key == "ManageMyAccount_Phone")
                        ManageMyAccount_Phone = pair.Value;
                    else if (pair.Key == "ManageMyAccount_Company")
                        ManageMyAccount_Company = pair.Value;
                    else if (pair.Key == "ManageMyAccount_BackButton")
                        ManageMyAccount_BackButton = pair.Value;
                    else if (pair.Key == "ManageMyAccount_UpdateButton")
                        ManageMyAccount_UpdateButton = pair.Value;
                    else if (pair.Key == "ManageMyAccount_FirstName_Validation")
                        ManageMyAccount_FirstName_Validation = pair.Value;
                    else if (pair.Key == "ManageMyAccount_LastName_Validation")
                        ManageMyAccount_LastName_Validation = pair.Value;
                    else if (pair.Key == "ManageMyAccount_PhoneValidation")
                        ManageMyAccount_PhoneValidation = pair.Value;
                    else if (pair.Key == "Update_Password_Checkbox")
                        Update_Password_Checkbox = pair.Value;
                    else if (pair.Key == "Update_Password")
                        Update_Password = pair.Value;
                    else if (pair.Key == "Update_Confirm_Password")
                        Update_Confirm_Password = pair.Value;
                }
                else if (nodeModule == Constants.MyOrder)
                {
                    if (pair.Key == "EventName")
                        EventName = pair.Value;
                    else if (pair.Key == "Event_StartDate")
                        Event_StartDate = pair.Value;
                    else if (pair.Key == "Event_EndDate")
                        Event_EndDate = pair.Value;
                    else if (pair.Key == "Click_CreateOrder")
                        Click_CreateOrder = pair.Value;
                    else if (pair.Key == "Click_AddFunction")
                        Click_AddFunction = pair.Value;
                    else if (pair.Key == "FunctionName")
                        FunctionName = pair.Value;
                    else if (pair.Key == "NoOfGuest")
                        NoOfGuest = pair.Value;
                    else if (pair.Key == "FunctionRoom")
                        FunctionRoom = pair.Value;
                    else if (pair.Key == "FunctionType")
                        FunctionType = pair.Value;
                    else if (pair.Key == "SetupType")
                        SetupType = pair.Value;
                    else if (pair.Key == "Click_CreateFunction")
                        Click_CreateFunction = pair.Value;
                    else if (pair.Key == "AddMenu")
                        AddMenu = pair.Value;
                    else if (pair.Key == "SelectMenu")
                        SelectMenu = pair.Value;
                    else if (pair.Key == "GotoMenu")
                        GotoMenu = pair.Value;
                    else if (pair.Key == "AddMenuItem")
                        AddMenuItem = pair.Value;
                    else if (pair.Key == "AddMenuItemNext")
                        AddMenuItemNext = pair.Value;
                    else if (pair.Key == "CheckChoice")
                        CheckChoice = pair.Value;
                    else if (pair.Key == "AddMenuChoice")
                        AddMenuChoice = pair.Value;
                    else if (pair.Key == "Click_GoToEventDetails")
                        Click_GoToEventDetails = pair.Value;
                    else if (pair.Key == "Click_ReviewOrder")
                        Click_ReviewOrder = pair.Value;
                    else if (pair.Key == "Event_Payment_Method")
                        Event_Payment_Method = pair.Value;
                    else if (pair.Key == "Customer_FirstName")
                        Customer_FirstName = pair.Value;
                    else if (pair.Key == "Customer_LastName")
                        Customer_LastName = pair.Value;
                    else if (pair.Key == "Customer_Address")
                        Customer_Address = pair.Value;
                    else if (pair.Key == "Customer_Address2")
                        Customer_Address2 = pair.Value;
                    else if (pair.Key == "Customer_City")
                        Customer_City = pair.Value;
                    else if (pair.Key == "Customer_State")
                        Customer_State = pair.Value;
                    else if (pair.Key == "Customer_PostalCode")
                        Customer_PostalCode = pair.Value;
                    else if (pair.Key == "Customer_Country")
                        Customer_Country = pair.Value;
                    else if (pair.Key == "Customer_Phone")
                        Customer_Phone = pair.Value;
                    else if (pair.Key == "Customer_Email")
                        Customer_Email = pair.Value;
                    else if (pair.Key == "Customer_Company")
                        Customer_Company = pair.Value;
                    else if (pair.Key == "Select_Contact")
                        Select_Contact = pair.Value;
                    else if (pair.Key == "Click_Continue")
                        Click_Continue = pair.Value;
                    else if (pair.Key == "Click_Save_Order")
                        Click_Save_Order = pair.Value;
                    else if (pair.Key == "Click_MyOrder")
                        Click_MyOrder = pair.Value;
                    else if (pair.Key == "Search_Filter")
                        Search_Filter = pair.Value;
                    else if (pair.Key == "Click_EditOrder")
                        Click_EditOrder = pair.Value;
                    else if (pair.Key == "Click_SendOrder")
                        Click_SendOrder = pair.Value;
                    else if (pair.Key == "Click_SendOrder_Confirmation")
                        Click_SendOrder_Confirmation = pair.Value;
                }
                else if (nodeModule == Constants.MyOrders)
                {
                    if (pair.Key == "Click_CreateNewOrder")
                        Click_CreateNewOrder = pair.Value;
                    else if (pair.Key == "Enter_EventName")
                        Enter_EventName = pair.Value;
                    else if (pair.Key == "FromDate")
                        FromDate = pair.Value;
                    else if (pair.Key == "ToDate")
                        ToDate = pair.Value;
                    else if (pair.Key == "Click_CancelButton")
                        Click_CancelButton = pair.Value;
                    else if (pair.Key == "Click_SaveButton")
                        Click_SaveButton = pair.Value;
                    else if (pair.Key == "SearchFilter")
                        SearchFilter = pair.Value;
                }
                else if (nodeModule == Constants.EventDetails)
                {
                    if (pair.Key == "ClickAddFunction")
                        ClickAddFunction = pair.Value;
                    else if (pair.Key == "FunctionDate")
                        FunctionDate = pair.Value;
                    else if (pair.Key == "Function_Name")
                        Function_Name = pair.Value;
                    else if (pair.Key == "NumberOfGuests")
                        NumberOfGuests = pair.Value;
                    else if (pair.Key == "Function_Room")
                        Function_Room = pair.Value;
                    else if (pair.Key == "Function_Type")
                        Function_Type = pair.Value;
                    else if (pair.Key == "SetupStyle")
                        SetupStyle = pair.Value;
                    else if (pair.Key == "StartTime")
                        StartTime = pair.Value;
                    else if (pair.Key == "EndTime")
                        EndTime = pair.Value;
                    else if (pair.Key == "CancelButton")
                        CancelButton = pair.Value;
                    else if (pair.Key == "SaveButton")
                        SaveButton = pair.Value;
                    else if (pair.Key == "Click_AddMenu")
                        Click_AddMenu = pair.Value;
                    else if (pair.Key == "MenuName")
                        MenuName = pair.Value;
                    else if (pair.Key == "AddMenu_CancelButton")
                        AddMenu_CancelButton = pair.Value;
                    else if (pair.Key == "GoToMenu_Button")
                        GoToMenu_Button = pair.Value;
                    else if (pair.Key == "AddMenu_AddClick")
                        AddMenu_AddClick = pair.Value;
                    else if (pair.Key == "AddMenuModal_CancelButton")
                        AddMenuModal_CancelButton = pair.Value;
                    else if (pair.Key == "AddMenuModal_AddButton")
                        AddMenuModal_AddButton = pair.Value;
                    else if (pair.Key == "GoToEventDetails")
                        GoToEventDetails = pair.Value;
                    else if (pair.Key == "ClickReviewOrder")
                        ClickReviewOrder = pair.Value;
                    else if (pair.Key == "OrderInformation_Contact")
                        OrderInformation_Contact = pair.Value;
                    else if (pair.Key == "OrderInformation_PaymentMothod")
                        OrderInformation_PaymentMothod = pair.Value;
                    else if (pair.Key == "OrderInformation_ContinueButton")
                        OrderInformation_ContinueButton = pair.Value;
                    else if (pair.Key == "ReviewOrder_SaveButton")
                        ReviewOrder_SaveButton = pair.Value;
                    else if (pair.Key == "MyOrders_Button")
                        MyOrders_Button = pair.Value;
                    else if (pair.Key == "Click_AddMenuModal_CancelButton")
                        Click_AddMenuModal_CancelButton = pair.Value;
                    else if (pair.Key == "ReviewOrder_SendButton")
                        ReviewOrder_SendButton = pair.Value;
                    else if (pair.Key == "ReviewOrder_SendOrder_SendButton")
                        ReviewOrder_SendOrder_SendButton = pair.Value;
                    else if (pair.Key == "SendOrdersMyOrders_Button")
                        SendOrdersMyOrders_Button = pair.Value;
                    else if (pair.Key == "Click_Comment_Function")
                        Click_Comment_Function = pair.Value;
                    else if (pair.Key == "EnterComments")
                        EnterComments = pair.Value;
                    else if (pair.Key == "Click_AddComment")
                        Click_AddComment = pair.Value;
                    else if (pair.Key == "Click_Edit_Function")
                        Click_Edit_Function = pair.Value;
                    else if (pair.Key == "Click_Copy_Function")
                        Click_Copy_Function = pair.Value;
                    else if (pair.Key == "Enter_CloneFunctionName")
                        Enter_CloneFunctionName = pair.Value;
                    else if (pair.Key == "Select_CloneFunctionDate")
                        Select_CloneFunctionDate = pair.Value;
                    else if (pair.Key == "Click_CloneSaveFunction")
                        Click_CloneSaveFunction = pair.Value;
                    else if (pair.Key == "Click_Delete_Function")
                        Click_Delete_Function = pair.Value;
                    else if (pair.Key == "Click_DeleteFunctionbutton")
                        Click_DeleteFunctionbutton = pair.Value;
                    else if (pair.Key == "Click_Edit_Menu")
                        Click_Edit_Menu = pair.Value;
                    else if (pair.Key == "Enter_EditMenu_Menu_Quantity")
                        Enter_EditMenu_Menu_Quantity = pair.Value;
                    else if (pair.Key == "Enter_EditMenu_Menu_Special_Request")
                        Enter_EditMenu_Menu_Special_Request = pair.Value;
                    else if (pair.Key == "Click_EditMenu_Menu_Save_Button")
                        Click_EditMenu_Menu_Save_Button = pair.Value;
                    else if (pair.Key == "Click_Copy_Menu")
                        Click_Copy_Menu = pair.Value;
                    else if (pair.Key == "Select_CopyMenu_FunctionList")
                        Select_CopyMenu_FunctionList = pair.Value;
                    else if (pair.Key == "Click_CopyMenu_FunctionList_Save")
                        Click_CopyMenu_FunctionList_Save = pair.Value;
                    else if (pair.Key == "Click_Delete_Menu")
                        Click_Delete_Menu = pair.Value;
                    else if (pair.Key == "Click_Delete_Menu_Button")
                        Click_Delete_Menu_Button = pair.Value;



                }
                else if (nodeModule == Constants.PropertyAdmin)
                {
                    if (pair.Key == "Click_Select_PropertyDropdown")
                        Click_Select_PropertyDropdown = pair.Value;
                    else if (pair.Key == "Select_Property")
                        Select_Property = pair.Value;
                    else if (pair.Key == "Click_uOrder")
                        Click_uOrder = pair.Value;
                    else if (pair.Key == "uOrder_OrderSearchBox")
                        uOrder_OrderSearchBox = pair.Value;
                    else if (pair.Key == "PropertyAdmin_Username")
                        PropertyAdmin_Username = pair.Value;
                    else if (pair.Key == "PropertyAdmin_Password")
                        PropertyAdmin_Password = pair.Value;
                    else if (pair.Key == "Propertyadmin_Verificationcode")
                        Propertyadmin_Verificationcode = pair.Value;
                    else if (pair.Key == "Verificationcode")
                        Verificationcode = pair.Value;
                    else if (pair.Key == "GetVerificationcode")
                        GetVerificationcode = pair.Value;


                    else if (pair.Key == "Click_BackButton")
                        Click_BackButton = pair.Value;
                    else if (pair.Key == "Click_LoginButton")
                        Click_LoginButton = pair.Value;
                    else if (pair.Key == "Click_NextButton")
                        Click_NextButton = pair.Value;
                    else if (pair.Key == "Click_Prperty")
                        Click_Prperty = pair.Value;
                    else if (pair.Key == "Navigation_eMenus")
                        Navigation_eMenus = pair.Value;
                    else if (pair.Key == "Settings_Dropdown")
                        Settings_Dropdown = pair.Value;
                    else if (pair.Key == "Cendyn_Admin")
                        Cendyn_Admin = pair.Value;
                    else if (pair.Key == "Advance_Settings")
                        Advance_Settings = pair.Value;
                    else if (pair.Key == "Uorder_Contact")
                        Uorder_Contact = pair.Value;
                    else if (pair.Key == "Uorder_Update_Contact")
                        Uorder_Update_Contact = pair.Value;
                    else if (pair.Key == "Property_Dropdown")
                        Property_Dropdown = pair.Value;
                    else if (pair.Key == "Property_TextBox")
                        Property_TextBox = pair.Value;
                    else if (pair.Key == "Property_Origami")
                        Property_Origami = pair.Value;
                    else if (pair.Key == "Published_View")
                        Published_View = pair.Value;
                    else if (pair.Key == "Home_Menu_eMenu")
                        Home_Menu_eMenu = pair.Value;
                    else if (pair.Key == "Home_Menu")
                        Home_Menu = pair.Value;
                    else if (pair.Key == "Click_MyMenu_Settings")
                        Click_MyMenu_Settings = pair.Value;
                    else if (pair.Key == "Click_Settings_DynamicPricing")
                        Click_Settings_DynamicPricing = pair.Value;
                    else if (pair.Key == "Click_DynamicPricing_AddNewButton")
                        Click_DynamicPricing_AddNewButton = pair.Value;
                    else if (pair.Key == "AddDynamicPricing_DynamicPricingName")
                        AddDynamicPricing_DynamicPricingName = pair.Value;
                    else if (pair.Key == "AddDynamicPricing_StartDate")
                        AddDynamicPricing_StartDate = pair.Value;
                    else if (pair.Key == "AddDynamicPricing_EndDate")
                        AddDynamicPricing_EndDate = pair.Value;
                    else if (pair.Key == "AddDynamicPricing_SaveChangesButton")
                        AddDynamicPricing_SaveChangesButton = pair.Value;
                    else if (pair.Key == "AddDynamicPricing_SaveChangesYesButton")
                        AddDynamicPricing_SaveChangesYesButton = pair.Value;
                    else if (pair.Key == "AddDynamicPricing_CancelButton")
                        AddDynamicPricing_CancelButton = pair.Value;
                    else if (pair.Key == "Click_AddDynamicPricing_OkButton")
                        Click_AddDynamicPricing_OkButton = pair.Value;

                    else if (pair.Key == "Click_MyMenu_BreakfastDropdown")
                        Click_MyMenu_BreakfastDropdown = pair.Value;
                    else if (pair.Key == "MyMenu_BreakfastDropdown_ContinentalBreakfast")
                        MyMenu_BreakfastDropdown_ContinentalBreakfast = pair.Value;
                    else if (pair.Key == "Click_MyMenu_AddNewMenu")
                        Click_MyMenu_AddNewMenu = pair.Value;
                    else if (pair.Key == "Click_AddNewMenu_CancelButton")
                        Click_AddNewMenu_CancelButton = pair.Value;
                    else if (pair.Key == "Click_AddNewMenu_SaveButton")
                        Click_AddNewMenu_SaveButton = pair.Value;
                    else if (pair.Key == "AddNewMenu_MenuName")
                        AddNewMenu_MenuName = pair.Value;
                    else if (pair.Key == "AddNewMenu_Price")
                        AddNewMenu_Price = pair.Value;
                    else if (pair.Key == "AddNewMenu_DynamiPrice")
                        AddNewMenu_DynamiPrice = pair.Value;
                    else if (pair.Key == "AddNewMenu_Description")
                        AddNewMenu_Description = pair.Value;
                    else if (pair.Key == "Click_MyMenus")
                        Click_MyMenus = pair.Value;
                    else if (pair.Key == "Select_Price_Description")
                        Select_Price_Description = pair.Value;
                    else if (pair.Key == "Select_DynamicPrice_Description")
                        Select_DynamicPrice_Description = pair.Value;
                    else if (pair.Key == "Click_Publish_Button")
                        Click_Publish_Button = pair.Value;
                    else if (pair.Key == "Select_Property_Dropdown")
                        Select_Property_Dropdown = pair.Value;
                    else if (pair.Key == "Click_Form_Publish_Button")
                        Click_Form_Publish_Button = pair.Value;
                    else if (pair.Key == "Click_Delete_Dynamic_Price_Confirmation")
                        Click_Delete_Dynamic_Price_Confirmation = pair.Value;
                    else if (pair.Key == "Click_Delete_Dynamic_Price_Confirmation_OK")
                        Click_Delete_Dynamic_Price_Confirmation_OK = pair.Value;
                    else if (pair.Key == "Click_MyMenu_EditMenu")
                        Click_MyMenu_EditMenu = pair.Value;
                    else if (pair.Key == "Existing_MenuPrice")
                        Existing_MenuPrice = pair.Value;
                    else if (pair.Key == "EditDynamicPricing_StartDate")
                        EditDynamicPricing_StartDate = pair.Value;
                    else if (pair.Key == "EditDynamicPricing_EndDate")
                        EditDynamicPricing_EndDate = pair.Value;
                    else if (pair.Key == "EditDynamicPricing_SaveChangesButton")
                        EditDynamicPricing_SaveChangesButton = pair.Value;
                    else if (pair.Key == "EditDynamicPricing_DynamicPricingName")
                        EditDynamicPricing_DynamicPricingName = pair.Value;
                    else if (pair.Key == "Click_AddNewMenu_AddChoiceButton")
                        Click_AddNewMenu_AddChoiceButton = pair.Value;
                    else if (pair.Key == "AddNewMenu_AddChoice_Name")
                        AddNewMenu_AddChoice_Name = pair.Value;
                    else if (pair.Key == "AddNewMenu_AddChoice_Description")
                        AddNewMenu_AddChoice_Description = pair.Value;
                    else if (pair.Key == "Click_AddNewMenu_NewOptionButton")
                        Click_AddNewMenu_NewOptionButton = pair.Value;
                    else if (pair.Key == "AddNewMenu_AddChoice_Option")
                        AddNewMenu_AddChoice_Option = pair.Value;
                    else if (pair.Key == "AddNewMenu_AddChoice_Price")
                        AddNewMenu_AddChoice_Price = pair.Value;
                    else if (pair.Key == "Click_AddNewMenu_NewOptionButton2")
                        Click_AddNewMenu_NewOptionButton2 = pair.Value;
                    else if (pair.Key == "AddNewMenu_AddChoice_Option2")
                        AddNewMenu_AddChoice_Option2 = pair.Value;
                    else if (pair.Key == "AddNewMenu_AddChoice_Price2")
                        AddNewMenu_AddChoice_Price2 = pair.Value;
                    else if (pair.Key == "Click_AddNewMenu_BottomSaveButton")
                        Click_AddNewMenu_BottomSaveButton = pair.Value;
                    else if (pair.Key == "Click_MyMenu_PreviewButton")
                        Click_MyMenu_PreviewButton = pair.Value;
                    else if (pair.Key == "Click_Preview_BreakfastDropdown")
                        Click_Preview_BreakfastDropdown = pair.Value;
                    else if (pair.Key == "Click_Preview_ContinentalBreakfast")
                        Click_Preview_ContinentalBreakfast = pair.Value;
                    else if (pair.Key == "Click_MyMenu_PublishButton")
                        Click_MyMenu_PublishButton = pair.Value;
                    else if (pair.Key == "Click_MyMenu_PublishSaveButton")
                        Click_MyMenu_PublishSaveButton = pair.Value;
                    else if (pair.Key == "GetDescriptionId_AddChoices")
                        GetDescriptionId_AddChoices = pair.Value;
                    else if (pair.Key == "Enter_Add_On_Title")
                        Enter_Add_On_Title = pair.Value;
                    else if (pair.Key == "Click_New_Add_On")
                        Click_New_Add_On = pair.Value;
                    else if (pair.Key == "Enter_Add_On_Price1")
                        Enter_Add_On_Price1 = pair.Value;
                    else if (pair.Key == "Enter_Add_On_Price2")
                        Enter_Add_On_Price2 = pair.Value;
                    else if (pair.Key == "SSO_Validation_Message")
                        SSO_Validation_Message = pair.Value;
                    else if (pair.Key == "Log_Out")
                        Log_Out = pair.Value;
                    else if (pair.Key == "Social_Media_Tab")
                        Social_Media_Tab = pair.Value;
                    else if (pair.Key == "Add_New_Social_Media")
                        Add_New_Social_Media = pair.Value;
                    else if (pair.Key == "Social_Media_Dropdown")
                        Social_Media_Dropdown = pair.Value;
                    else if (pair.Key == "Social_Media_Type_Validation")
                        Social_Media_Type_Validation = pair.Value;
                    else if (pair.Key == "Social_Media_URL")
                        Social_Media_URL = pair.Value;
                    else if (pair.Key == "Social_Media_URL_Validation")
                        Social_Media_URL_Validation = pair.Value;
                    else if (pair.Key == "Social_Media_Save_Changes")
                        Social_Media_Save_Changes = pair.Value;
                    else if (pair.Key == "Social_Media_Close")
                        Social_Media_Close = pair.Value;
                    else if (pair.Key == "OK_Button")
                        OK_Button = pair.Value;
                    else if (pair.Key == "Yes_Button")
                        Yes_Button = pair.Value;
                    else if (pair.Key == "Edit_Social_Media_Dropdown")
                        Edit_Social_Media_Dropdown = pair.Value;
                    else if (pair.Key == "Edit_Social_Media_URL")
                        Edit_Social_Media_URL = pair.Value;
                    else if (pair.Key == "Edit_Social_Media_Save_Changes")
                        Edit_Social_Media_Save_Changes = pair.Value;
                    else if (pair.Key == "Settings_MenuFilter_Tab")
                        Settings_MenuFilter_Tab = pair.Value;
                    else if (pair.Key == "Settings_MenuFilter_AddTag")
                        Settings_MenuFilter_AddTag = pair.Value;
                    else if (pair.Key == "Settings_MenuFilter_AddTag_Name")
                        Settings_MenuFilter_AddTag_Name = pair.Value;
                    else if (pair.Key == "Settings_MenuFilter_AddTag_DeleteButton")
                        Settings_MenuFilter_AddTag_DeleteButton = pair.Value;
                    else if (pair.Key == "Settings_MenuFilter_AddTag_SaveButton")
                        Settings_MenuFilter_AddTag_SaveButton = pair.Value;
                    else if (pair.Key == "Click_AddNewMenu_AddedTag_Filter")
                        Click_AddNewMenu_AddedTag_Filter = pair.Value;
                    else if (pair.Key == "Settings_MenuFilter_DeleteTag_ContinueButton")
                        Settings_MenuFilter_DeleteTag_ContinueButton = pair.Value;
                    else if (pair.Key == "Click_Menu_Info_Button")
                        Click_Menu_Info_Button = pair.Value;
                    else if (pair.Key == "First_Menu_Price_Preview")
                        First_Menu_Price_Preview = pair.Value;
                    else if (pair.Key == "First_Menu_Price_Admin")
                        First_Menu_Price_Admin = pair.Value;

                    else if (pair.Key == "Click_FindReplace")
                        Click_FindReplace = pair.Value;
                    else if (pair.Key == "Enter_FindText")
                        Enter_FindText = pair.Value;
                    else if (pair.Key == "Enter_ReplaceText")
                        Enter_ReplaceText = pair.Value;
                    else if (pair.Key == "Click_FindReplace_Find")
                        Click_FindReplace_Find = pair.Value;
                    else if (pair.Key == "Click_FindReplace_ReplaceAll")
                        Click_FindReplace_ReplaceAll = pair.Value;
                    else if (pair.Key == "Click_FindReplace_Done")
                        Click_FindReplace_Done = pair.Value;
                    else if (pair.Key == "Click_MyMenu_DeleteMenu")
                        Click_MyMenu_DeleteMenu = pair.Value;
                    else if (pair.Key == "Click_MyMenu_DeleteMenu_Confirm")
                        Click_MyMenu_DeleteMenu_Confirm = pair.Value;
                    else if (pair.Key == "Click_Main_Navigation_Dropdown")
                        Click_Main_Navigation_Dropdown = pair.Value;
                    else if (pair.Key == "Click_Link_Web_View")
                        Click_Link_Web_View = pair.Value;
                    else if (pair.Key == "Click_Link_PDF_View")
                        Click_Link_PDF_View = pair.Value;
                    else if (pair.Key == "PassedDate_Name_DynamicPrice")
                        PassedDate_Name_DynamicPrice = pair.Value;
                    else if (pair.Key == "Click_Link_Share")
                        Click_Link_Share = pair.Value;
                    else if (pair.Key == "Enter_ShareMenu_Name")
                        Enter_ShareMenu_Name = pair.Value;
                    else if (pair.Key == "Check_Format_Checkbox")
                        Check_Format_Checkbox = pair.Value;
                    else if (pair.Key == "Check_Pricing_Checkbox")
                        Check_Pricing_Checkbox = pair.Value;
                    else if (pair.Key == "Click_Continue_Button")
                        Click_Continue_Button = pair.Value;
                    else if (pair.Key == "Click_Search_Client_Button")
                        Click_Search_Client_Button = pair.Value;
                    else if (pair.Key == "Enter_Search_Client_Name")
                        Enter_Search_Client_Name = pair.Value;
                    else if (pair.Key == "Click_SearchOverlay_Client_Button")
                        Click_SearchOverlay_Client_Button = pair.Value;
                    else if (pair.Key == "Select_Searched_Client_Record")
                        Select_Searched_Client_Record = pair.Value;
                    else if (pair.Key == "Cancel_Search_Client")
                        Cancel_Search_Client = pair.Value;

                    else if (pair.Key == "Share_Message_Content")
                        Share_Message_Content = pair.Value;
                    else if (pair.Key == "Click_Send_Email")
                        Click_Send_Email = pair.Value;
                    else if (pair.Key == "Click_GoToActivity_Button")
                        Click_GoToActivity_Button = pair.Value;
                    else if (pair.Key == "Search_Menu_Filter")
                        Search_Menu_Filter = pair.Value;
                    else if (pair.Key == "Click_Action_Button")
                        Click_Action_Button = pair.Value;
                    else if (pair.Key == "Click_Clone_Link")
                        Click_Clone_Link = pair.Value;
                    else if (pair.Key == "Click_Clone_Button")
                        Click_Clone_Button = pair.Value;
                    else if (pair.Key == "Click_Add_New_Client")
                        Click_Add_New_Client = pair.Value;
                    else if (pair.Key == "Enter_Client_First_Name")
                        Enter_Client_First_Name = pair.Value;
                    else if (pair.Key == "Enter_Client_Last_Name")
                        Enter_Client_Last_Name = pair.Value;
                    else if (pair.Key == "Enter_Client_Company")
                        Enter_Client_Company = pair.Value;
                    else if (pair.Key == "Enter_Client_Email")
                        Enter_Client_Email = pair.Value;
                    else if (pair.Key == "Click_Save_Save")
                        Click_Save_Save = pair.Value;
                    else if (pair.Key == "Click_Generate_Link")
                        Click_Generate_Link = pair.Value;
                    else if (pair.Key == "Get_ShareMenu_Link")
                        Get_ShareMenu_Link = pair.Value;
                    else if (pair.Key == "Click_Preview_Button")
                        Click_Preview_Button = pair.Value;
                    else if (pair.Key == "Click_Menu_FoodAndBeverages")
                        Click_Menu_FoodAndBeverages = pair.Value;
                    else if (pair.Key == "Click_Button_Add_Item")
                        Click_Button_Add_Item = pair.Value;
                    else if (pair.Key == "Enter_Text_Title")
                        Enter_Text_Title = pair.Value;
                    else if (pair.Key == "Click_Button_Save")
                        Click_Button_Save = pair.Value;
                    else if (pair.Key == "Navigation_ePlanner")
                        Navigation_ePlanner = pair.Value;
                    else if (pair.Key == "Click_Button_Delete")
                        Click_Button_Delete = pair.Value;
                    else if (pair.Key == "Click_AddNewMenu_AddChoiceButton2")
                        Click_AddNewMenu_AddChoiceButton2 = pair.Value;
                    else if (pair.Key == "AddNewMenu_AddChoice2_Name")
                        AddNewMenu_AddChoice2_Name = pair.Value;
                    else if (pair.Key == "Click_AddNewMenu2_NewOptionButton")
                        Click_AddNewMenu2_NewOptionButton = pair.Value;
                    else if (pair.Key == "Click_ChoiceMoveUp_Button")
                        Click_ChoiceMoveUp_Button = pair.Value;
                    else if (pair.Key == "Click_Button_UploadFromeGallery")
                        Click_Button_UploadFromeGallery = pair.Value;
                    else if (pair.Key == "Click_Image_eGallery")
                        Click_Image_eGallery = pair.Value;
                    else if (pair.Key == "Click_Button_SelectImage")
                        Click_Button_SelectImage = pair.Value;
                    else if (pair.Key == "Click_Upload_Image")
                        Click_Upload_Image = pair.Value;
                    else if (pair.Key == "Click_Select_File")
                        Click_Select_File = pair.Value;
                    else if (pair.Key == "Click_Upload_File")
                        Click_Upload_File = pair.Value;
                    else if (pair.Key == "Click_Image_File")
                        Click_Image_File = pair.Value;



                    else if (pair.Key == "Navigation_eMenusLITE")
                        Navigation_eMenusLITE = pair.Value;
                    else if (pair.Key == "Click_MyMenu_Breaks")
                        Click_MyMenu_Breaks = pair.Value;
                    else if (pair.Key == "Click_EditCategoryDesc")
                        Click_EditCategoryDesc = pair.Value;
                    else if (pair.Key == "CategoryDesc")
                        CategoryDesc = pair.Value;
                    else if (pair.Key == "Click_CategoryDesc_Save")
                        Click_CategoryDesc_Save = pair.Value;
                    else if (pair.Key == "Click_Publish_Close_Button")
                        Click_Publish_Close_Button = pair.Value;
                    else if (pair.Key == "Click_Filter_GlutenFree")
                        Click_Filter_GlutenFree = pair.Value;
                    else if (pair.Key == "Click_Filter_MilkAvoidance")
                        Click_Filter_MilkAvoidance = pair.Value;
                    else if (pair.Key == "Click_Tag_MostPopular")
                        Click_Tag_MostPopular = pair.Value;
                    else if (pair.Key == "Click_Form_Cancel_Button")
                        Click_Form_Cancel_Button = pair.Value;

                    else if (pair.Key == "Click_AddItem_CancelButton")
                        Click_AddItem_CancelButton = pair.Value;
                    else if (pair.Key == "Click_Menu_EditButton")
                        Click_Menu_EditButton = pair.Value;
                    else if (pair.Key == "Click_Item_Delete_Cancel")
                        Click_Item_Delete_Cancel = pair.Value;

                    else if (pair.Key == "Click_MyPlanner_Edit")
                        Click_MyPlanner_Edit = pair.Value;
                    else if (pair.Key == "Enter_Category_editor")
                        Enter_Category_editor = pair.Value;
                    else if (pair.Key == "Click_Category_editor_save")
                        Click_Category_editor_save = pair.Value;

                    else if (pair.Key == "Click_Menu_Item_Down")
                        Click_Menu_Item_Down = pair.Value;
                    else if (pair.Key == "Click_Menu_Item_Up")
                        Click_Menu_Item_Up = pair.Value;
                    else if (pair.Key == "Get_First_Item_Title_PA")
                        Get_First_Item_Title_PA = pair.Value;
                    else if (pair.Key == "Get_Second_Item_Title_PA")
                        Get_Second_Item_Title_PA = pair.Value;
                    else if (pair.Key == "Get_First_Item_Title_FE")
                        Get_First_Item_Title_FE = pair.Value;
                    else if (pair.Key == "Get_Second_Item_Title_FE")
                        Get_Second_Item_Title_FE = pair.Value;
                    else if (pair.Key == "Get_First_Item_Title_PM")
                        Get_First_Item_Title_PM = pair.Value;
                    else if (pair.Key == "Get_Second_Item_Title_PM")
                        Get_Second_Item_Title_PM = pair.Value;
                    else if (pair.Key == "Enter_Category_Description")
                        Enter_Category_Description = pair.Value;
                    else if (pair.Key == "Click_Button_Category_Description_Cancel")
                        Click_Button_Category_Description_Cancel = pair.Value;
                    else if (pair.Key == "Click_Button_Category_Description_Save")
                        Click_Button_Category_Description_Save = pair.Value;
                    else if (pair.Key == "Click_Here_for_eGallery")
                        Click_Here_for_eGallery = pair.Value;
                    else if (pair.Key == "Verify_eGallery_Image")
                        Verify_eGallery_Image = pair.Value;
                    else if (pair.Key == "Click_Category_Home")
                        Click_Category_Home = pair.Value;
                    else if (pair.Key == "Click_Category_Information")
                        Click_Category_Information = pair.Value;
                    else if (pair.Key == "ManagerProfile_Name")
                        ManagerProfile_Name = pair.Value;

                    else if (pair.Key == "Click_Edit_Desclaimer")
                        Click_Edit_Desclaimer = pair.Value;
                    else if (pair.Key == "Enter_Desclaimer_Description")
                        Enter_Desclaimer_Description = pair.Value;
                    else if (pair.Key == "Click_Desclaimer_SaveButton")
                        Click_Desclaimer_SaveButton = pair.Value;
                    else if (pair.Key == "Click_Category_Decsription")
                        Click_Category_Decsription = pair.Value;
                    else if (pair.Key == "Click_CategoryDescription_SaveButton")
                        Click_CategoryDescription_SaveButton = pair.Value;
                    else if (pair.Key == "Click_Fronend_HomeCategory")
                        Click_Fronend_HomeCategory = pair.Value;

                    else if (pair.Key == "Click_MyMenu_SpecialOffers")
                        Click_MyMenu_SpecialOffers = pair.Value;
                    else if (pair.Key == "Property_Logo")
                        Property_Logo = pair.Value;
                    else if (pair.Key == "Click_Link_FindAndReplace")
                        Click_Link_FindAndReplace = pair.Value;
                    else if (pair.Key == "Enter_Find_TextBox")
                        Enter_Find_TextBox = pair.Value;
                    else if (pair.Key == "Enter_Replace_TextBox")
                        Enter_Replace_TextBox = pair.Value;
                    else if (pair.Key == "Click_Button_Find")
                        Click_Button_Find = pair.Value;
                    else if (pair.Key == "Click_Button_ReplaceAll")
                        Click_Button_ReplaceAll = pair.Value;
                    else if (pair.Key == "Click_Button_Done")
                        Click_Button_Done = pair.Value;
                    else if (pair.Key == "Get_AlertBox_Title")
                        Get_AlertBox_Title = pair.Value;
                    else if (pair.Key == "Get_Validation_Message")
                        Get_Validation_Message = pair.Value;
                    else if (pair.Key == "Get_Success_Validation_Message")
                        Get_Success_Validation_Message = pair.Value;


                    else if (pair.Key == "Click_MyMenu_BreakMenu")
                        Click_MyMenu_BreakMenu = pair.Value;
                    else if (pair.Key == "BreakMenu_EditIcon")
                        BreakMenu_EditIcon = pair.Value;

                    else if (pair.Key == "Click_AddOnMoveDown_Button")
                        Click_AddOnMoveDown_Button = pair.Value;
                    else if (pair.Key == "Get_AddOn1_Text")
                        Get_AddOn1_Text = pair.Value;

                    else if (pair.Key == "Click_Option_DeleteButton")
                        Click_Option_DeleteButton = pair.Value;

                    else if (pair.Key == "Menu_Disclaimer")
                        Menu_Disclaimer = pair.Value;
                }
                else if (nodeModule == Constants.HomePage)
                {
                    if (pair.Key == "Click_HotelOrogami_Logo")
                        Click_HotelOrogami_Logo = pair.Value;
                    else if (pair.Key == "Click_HomePage_Filter")
                        Click_HomePage_Filter = pair.Value;
                    else if (pair.Key == "HomePage_ClearFilter")
                        HomePage_ClearFilter = pair.Value;
                    else if (pair.Key == "HomePage_ApplyFilter")
                        HomePage_ApplyFilter = pair.Value;
                    else if (pair.Key == "HomePage_Search")
                        HomePage_Search = pair.Value;
                    else if (pair.Key == "HomePage_FilterBy_GlutenFree")
                        HomePage_FilterBy_GlutenFree = pair.Value;
                    else if (pair.Key == "HomePage_FilterBy_Egg")
                        HomePage_FilterBy_Egg = pair.Value;
                    else if (pair.Key == "HomePage_FilterBy_Milk")
                        HomePage_FilterBy_Milk = pair.Value;
                    else if (pair.Key == "HomePage_FilterBy_MostPopular")
                        HomePage_FilterBy_MostPopular = pair.Value;
                    else if (pair.Key == "HomePage_DinnerDropdown")
                        HomePage_DinnerDropdown = pair.Value;
                    else if (pair.Key == "HomePage_Select_DinnerTable")
                        HomePage_Select_DinnerTable = pair.Value;
                    else if (pair.Key == "HomePage_DinnerTable_MenuInfoButton")
                        HomePage_DinnerTable_MenuInfoButton = pair.Value;
                    else if (pair.Key == "HomePage_BreakfastDropdown")
                        HomePage_BreakfastDropdown = pair.Value;
                    else if (pair.Key == "HomePage_Select_BreakfastBuffet")
                        HomePage_Select_BreakfastBuffet = pair.Value;
                    else if (pair.Key == "HomePage_Select_ContinentalBreakfast")
                        HomePage_Select_ContinentalBreakfast = pair.Value;
                    else if (pair.Key == "HomePage_BreakfastBuffet_MenuInfoButton")
                        HomePage_BreakfastBuffet_MenuInfoButton = pair.Value;
                    else if (pair.Key == "HomePage_ReceptionDropdown")
                        HomePage_ReceptionDropdown = pair.Value;
                    else if (pair.Key == "HomePage_Select_ActionStations")
                        HomePage_Select_ActionStations = pair.Value;
                    else if (pair.Key == "HomePage_ActionStations_MenuInfoButton")
                        HomePage_ActionStations_MenuInfoButton = pair.Value;
                    else if (pair.Key == "Click_HomePage_MoreButton")
                        Click_HomePage_MoreButton = pair.Value;
                    else if (pair.Key == "HomePage_FilterBy_Favorite")
                        HomePage_FilterBy_Favorite = pair.Value;
                    else if (pair.Key == "Click_HomePage_LessButton")
                        Click_HomePage_LessButton = pair.Value;
                    else if (pair.Key == "GlutenFree_MenuName")
                        GlutenFree_MenuName = pair.Value;
                    else if (pair.Key == "Egg_MenuName")
                        Egg_MenuName = pair.Value;
                    else if (pair.Key == "MostPopular_MenuName")
                        MostPopular_MenuName = pair.Value;
                    else if (pair.Key == "Continental_brkfast_MenuPrice")
                        Continental_brkfast_MenuPrice = pair.Value;
                    else if (pair.Key == "Select_Event_date")
                        Select_Event_date = pair.Value;
                    else if (pair.Key == "First_Menu_Price_Frontend")
                        First_Menu_Price_Frontend = pair.Value;
                    else if (pair.Key == "Click_Link_Home")
                        Click_Link_Home = pair.Value;
                    else if (pair.Key == "Click_PrintIcon")
                        Click_PrintIcon = pair.Value;
                    else if (pair.Key == "HomePage_Breakfast")
                        HomePage_Breakfast = pair.Value;
                    else if (pair.Key == "HomePage_Break")
                        HomePage_Break = pair.Value;


                    else if (pair.Key == "Click_GlobeIcon")
                        Click_GlobeIcon = pair.Value;
                    else if (pair.Key == "Click_Globe_CloseIcon")
                        Click_Globe_CloseIcon = pair.Value;
                    else if (pair.Key == "Click_Globe_EnglishLanguage")
                        Click_Globe_EnglishLanguage = pair.Value;
                    else if (pair.Key == "Click_Globe_FrançaisLanguage")
                        Click_Globe_FrançaisLanguage = pair.Value;

                }
                else if (nodeModule == Constants.CendynAdmin)
                {
                    if (pair.Key == "Click_Property_BasicSettings_Tab")
                        Click_Property_BasicSettings_Tab = pair.Value;
                    else if (pair.Key == "Click_DynamicPrice_YesButton")
                        Click_DynamicPrice_YesButton = pair.Value;
                    else if (pair.Key == "Click_DynamicPrice_NoButton")
                        Click_DynamicPrice_NoButton = pair.Value;
                    else if (pair.Key == "Click_Property_UpdateButton")
                        Click_Property_UpdateButton = pair.Value;
                    else if (pair.Key == "Verificationcode")
                        Verificationcode = pair.Value;
                    else if (pair.Key == "Click_Dropdown")
                        Click_Dropdown = pair.Value;
                    else if (pair.Key == "Click_LogOut")
                        Click_LogOut = pair.Value;
                    else if (pair.Key == "Property_Tab")
                        Property_Tab = pair.Value;
                    else if (pair.Key == "Supplier_Tab")
                        Supplier_Tab = pair.Value;
                    else if (pair.Key == "Cendyn_Property_Dropdown")
                        Cendyn_Property_Dropdown = pair.Value;
                    else if (pair.Key == "Cendyn_select_Property")
                        Cendyn_select_Property = pair.Value;
                    else if (pair.Key == "Cendyn_property_click")
                        Cendyn_property_click = pair.Value;
                    else if (pair.Key == "Next_Button")
                        Next_Button = pair.Value;
                    else if (pair.Key == "Enter_Email_Address")
                        Enter_Email_Address = pair.Value;
                    else if (pair.Key == "Enter_Email_Password")
                        Enter_Email_Password = pair.Value;
                    else if (pair.Key == "Login_Button")
                        Login_Button = pair.Value;
                    else if (pair.Key == "Verificationcode")
                        Verificationcode = pair.Value;
                    else if (pair.Key == "Verification_Login")
                        Verification_Login = pair.Value;
                    else if (pair.Key == "Click_category")
                        Click_category = pair.Value;
                    else if (pair.Key == "Clone_category")
                        Clone_category = pair.Value;
                    else if (pair.Key == "Add_category")
                        Add_category = pair.Value;
                    else if (pair.Key == "Add_category_Save")
                        Add_category_Save = pair.Value;
                    else if (pair.Key == "Enter_Category_Name")
                        Enter_Category_Name = pair.Value;
                    else if (pair.Key == "Click_Property_Admin")
                        Click_Property_Admin = pair.Value;
                    else if (pair.Key == "Click_Published_View")
                        Click_Published_View = pair.Value;
                    else if (pair.Key == "Click_Publish")
                        Click_Publish = pair.Value;
                    else if (pair.Key == "Popup_Publish")
                        Popup_Publish = pair.Value;
                    else if (pair.Key == "Click_addSub_category")
                        Click_addSub_category = pair.Value;
                    else if (pair.Key == "Click_Addnav")
                        Click_Addnav = pair.Value;
                    else if (pair.Key == "Click_Sub_Addnav")
                        Click_Sub_Addnav = pair.Value;
                    else if (pair.Key == "Sub_category_Save")
                        Sub_category_Save = pair.Value;
                    else if (pair.Key == "Enter_Sub_Category_Name")
                        Enter_Sub_Category_Name = pair.Value;
                    else if (pair.Key == "Added_CategoryDropDown")
                        Added_CategoryDropDown = pair.Value;
                    else if (pair.Key == "Click_addSub_sub_category")
                        Added_CategoryDropDown = pair.Value;
                    else if (pair.Key == "Sub_Sub_category_Save")
                        Sub_Sub_category_Save = pair.Value;
                    else if (pair.Key == "Enter_Sub_Sub_Category")
                        Enter_Sub_Sub_Category = pair.Value;
                    else if (pair.Key == "Enter_EditCategory_CategoryName")
                        Enter_EditCategory_CategoryName = pair.Value;
                    else if (pair.Key == "Click_EditCategory_SaveButton")
                        Click_EditCategory_SaveButton = pair.Value;
                    else if (pair.Key == "Click_Category_Popup_DeleteButton")
                        Click_Category_Popup_DeleteButton = pair.Value;
                    else if (pair.Key == "Cancel_Overlay")
                        Cancel_Overlay = pair.Value;
                    else if (pair.Key == "Click_Delete_Category_Confrmation")
                        Click_Delete_Category_Confrmation = pair.Value;
                    else if (pair.Key == "Click_ShareMenu_YesButton")
                        Click_ShareMenu_YesButton = pair.Value;
                    else if (pair.Key == "Click_ShareMenu_NoButton")
                        Click_ShareMenu_NoButton = pair.Value;
                    else if (pair.Key == "Click_BasicSettings_UpdateButton")
                        Click_BasicSettings_UpdateButton = pair.Value;
                    else if (pair.Key == "Click_MyMenu_ShareTab")
                        Click_MyMenu_ShareTab = pair.Value;
                    else if (pair.Key == "Click_AdvancedSettings_Tab")
                        Click_AdvancedSettings_Tab = pair.Value;
                    else if (pair.Key == "Click_MenuImage_YesButton")
                        Click_MenuImage_YesButton = pair.Value;
                    else if (pair.Key == "Click_MenuImage_NoButton")
                        Click_MenuImage_NoButton = pair.Value;
                    else if (pair.Key == "Click_AdvancedSettings_UpdateButton")
                        Click_AdvancedSettings_UpdateButton = pair.Value;
                    else if (pair.Key == "Click_AddNewMenu_UploadImageButton")
                        Click_AddNewMenu_UploadImageButton = pair.Value;
                    else if (pair.Key == "Click_ePlannerCendynAdmin_Select_PropertyDropdown")
                        Click_ePlannerCendynAdmin_Select_PropertyDropdown = pair.Value;
                    else if (pair.Key == "Enter_ePlannerCendynAdmin_Property_TextBox")
                        Enter_ePlannerCendynAdmin_Property_TextBox = pair.Value;
                    else if (pair.Key == "Select_ePlannerCendynAdmin_Property_Dropdown")
                        Select_ePlannerCendynAdmin_Property_Dropdown = pair.Value;
                    else if (pair.Key == "Click_Supplier_Category_HomeEdit")
                        Click_Supplier_Category_HomeEdit = pair.Value;
                    else if (pair.Key == "Click_Supplier_Category_InformationEdit")
                        Click_Supplier_Category_InformationEdit = pair.Value;
                    else if (pair.Key == "Select_CategoryType_Dropdown")
                        Select_CategoryType_Dropdown = pair.Value;
                    else if (pair.Key == "Click_ePlanner_SupplierTab")
                        Click_ePlanner_SupplierTab = pair.Value;
                    else if (pair.Key == "Click_ePlanner_CategoryTab")
                        Click_ePlanner_CategoryTab = pair.Value;
                    else if (pair.Key == "Click_ePlanner_AddCategory")
                        Click_ePlanner_AddCategory = pair.Value;
                    else if (pair.Key == "Enter_ePlanner_CategoryName")
                        Enter_ePlanner_CategoryName = pair.Value;
                    else if (pair.Key == "Click_ePlanner_AddCategory_SaveButton")
                        Click_ePlanner_AddCategory_SaveButton = pair.Value;
                    else if (pair.Key == "CategoryName")
                        CategoryName = pair.Value;
                    else if (pair.Key == "Click_SupplierSettings_Tab")
                        Click_SupplierSettings_Tab = pair.Value;
                    else if (pair.Key == "Click_LogoImage_Delete")
                        Click_LogoImage_Delete = pair.Value;
                    else if (pair.Key == "Click_SupplierSettings_UpdateButton")
                        Click_SupplierSettings_UpdateButton = pair.Value;
                    else if (pair.Key == "Click_Logo_UploadButton")
                        Click_Logo_UploadButton = pair.Value;

                    else if (pair.Key == "Select_Supplier_DDM")
                        Select_Supplier_DDM = pair.Value;
                    else if (pair.Key == "Click_Category_CloneCategoryButton")
                        Click_Category_CloneCategoryButton = pair.Value;
                    else if (pair.Key == "Enter_CloneCategory_FromSupplier")
                        Enter_CloneCategory_FromSupplier = pair.Value;
                    else if (pair.Key == "Click_CloneCategory_PDF_Checkbox")
                        Click_CloneCategory_PDF_Checkbox = pair.Value;
                    else if (pair.Key == "Click_CloneCategory_SocialMedia_Checkbox")
                        Click_CloneCategory_SocialMedia_Checkbox = pair.Value;
                    else if (pair.Key == "Click_CloneCategory_SaveButton")
                        Click_CloneCategory_SaveButton = pair.Value;
                    else if (pair.Key == "Click_Category_DeleteCategoryButton")
                        Click_Category_DeleteCategoryButton = pair.Value;

                    else if (pair.Key == "Click_Contacts_Tab")
                        Click_Contacts_Tab = pair.Value;
                    else if (pair.Key == "Click_Contact_AddNewButton")
                        Click_Contact_AddNewButton = pair.Value;
                    else if (pair.Key == "Enter_AddContact_Name")
                        Enter_AddContact_Name = pair.Value;
                    else if (pair.Key == "Enter_AddContact_Title")
                        Enter_AddContact_Title = pair.Value;
                    else if (pair.Key == "Enter_AddContact_Email")
                        Enter_AddContact_Email = pair.Value;
                    else if (pair.Key == "Enter_AddContact_PhoneNumber")
                        Enter_AddContact_PhoneNumber = pair.Value;
                    else if (pair.Key == "Check_AddContact_CarbonCopy")
                        Check_AddContact_CarbonCopy = pair.Value;
                    else if (pair.Key == "Check_AddContact_SelectAsManager")
                        Check_AddContact_SelectAsManager = pair.Value;
                    else if (pair.Key == "Click_AddContact_CloseButton")
                        Click_AddContact_CloseButton = pair.Value;
                    else if (pair.Key == "Click_AddContact_SaveChangesButton")
                        Click_AddContact_SaveChangesButton = pair.Value;
                    else if (pair.Key == "Delete_Confirm")
                        Delete_Confirm = pair.Value;
                }

                else if (nodeModule == Constants.ePlannerFrontEndHome)
                {
                    if (pair.Key == "Home_SearchBox")
                        Home_SearchBox = pair.Value;
                    else if (pair.Key == "Click_SupplierSettings_Tab")
                        Click_SupplierSettings_Tab = pair.Value;
                    else if (pair.Key == "Click_LogoImage_Delete")
                        Click_LogoImage_Delete = pair.Value;
                    else if (pair.Key == "Click_SupplierSettings_UpdateButton")
                        Click_SupplierSettings_UpdateButton = pair.Value;
                    else if (pair.Key == "Click_Logo_UploadButton")
                        Click_Logo_UploadButton = pair.Value;
                }

            }

                return obj;
            }
        }
    
}
