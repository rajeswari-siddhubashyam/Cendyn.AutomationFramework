using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace eProposal.Utility
{
    class ObjectRepository
    {
        #region[UI]

        #region[EmployeeLogin]

        public static string EmployeeLogin_EmailText { get; set; }
        public static string EmployeeLogin_LoginButtonNextStep { get; set; }
        public static string EmployeeLogin_PasswordText { get; set; }
        public static string EmployeeLogin_SubmitButton { get; set; }
        public static string EmployeeLogin_ForgotPasswordLink { get; set; }
        public static string EmployeeLogin_ForgotPasswordEmailText { get; set; }
        public static string EmployeeLogin_ForgotPasswordSubmitButton { get; set; }
        public static string EmployeeLogin_ForgotPasswordLoginLink { get; set; }
        public static string EmployeeLogin_DefaultSubmitButton { get; set; }
        public static string SSOLogin_Email { get; set; }
        public static string SSOLogin_Password { get; set; }
        public static string SSOLogin_Next { get; set; }
        public static string SSOLogin_Submit { get; set; }
        public static string SSOLogin_VerificationCode { get; set; }
        public static string SSOLogin_Login { get; set; }
        public static string Login_IFrame_AgreeProceed { get; set; }
        public static string Login_IFrame_AgreeProceed_Close { get; set; }
        #endregion[EmployeeLogin]

        #region[EmployeeHome]
        public static string EmployeeHome_CreateEditButton { get; set; }
        public static string EmployeeHome_CreateEdit_eProposalButton { get; set; }
        public static string EmployeeHome_CreateEdit_eCardButton { get; set; }
        public static string EmployeeHome_CreateEdit_eFacetimeButton { get; set; }
        public static string EmployeeHome_PropertyDropDown_Button { get; set; }
        public static string EmployeeHome_PropertyDropDown_Text { get; set; }
        public static string EmployeeHome_WelcomeButton { get; set; }
        public static string EmployeeHome_ViewAllLink { get; set; }
        public static string EmployeeHome_HelpLink { get; set; }
        public static string EmployeeHome_EditProfileLink { get; set; }
        public static string EmployeeHome_ClientsButton { get; set; }
        public static string EmployeeHome_ReportsButton { get; set; }

        public static string EmployeeHome_ActivityTab { get; set; }

        //public static string EmployeeHome_CreateEdit_eProposalButton2 { get; set; }
        public static string EmployeeHome_Link_UpdateMySettings { get; set; }

        public static string EmployeeHome_MySettings { get; set; }
        public static string EmployeeHome_MySettings_Demo { get; set; }
        public static string EmployeeHome_MySettings_Click_Demo { get; set; }
        public static string EmployeeHome_MySettings_New { get; set; }
        public static string EmployeeHome_MySettings_Click_New { get; set; }
        public static string EmployeeHome_Profile { get; set; }
        public static string EmployeeHome_AddEditProfile { get; set; }
        public static string EmployeeHome_CreateEdit_eProposalButton2 { get; set; }

        #endregion[EmployeeHome]

        #region[Profile]

        public static string Profile_Button_ChooseFile { get; set; }
        public static string Profile_Button_Save { get; set; }
        public static string Profile_Link_Remove { get; set; }
        public static string Profile_Button_Ok { get; set; }
        public static string Profile_Image_CustomSignature { get; set; }
        public static string Profile_Field_CustomSignature { get; set; }
        public static string Profile_Button_No { get; set; }
        public static string Profile_Button_Cancel { get; set; }
        public static string Profile_Button_ViewAll { get; set; }
        public static string Profile_Link_EditFirstProfile { get; set; }
        public static string Profile_Link_ContinueToeProposal { get; set; }

        #endregion[Profile]

        #region[ProposalCompose]

        public static string ProposalCompose_LanguageDropDown { get; set; }
        public static string ProposalCompose_SelectProposalDropDown { get; set; }
        public static string ProposalCompose_ProposalNameText { get; set; }
        public static string ProposalCompose_EmployeeFromDropDown { get; set; }
        public static string ProposalCompose_Client_SearchLink { get; set; }
        public static string ProposalCompose_Client_AddNewLink { get; set; }
        public static string ProposalCompose_Client_AddNew_FirstNameText { get; set; }
        public static string ProposalCompose_Client_AddNew_LastNameText { get; set; }
        public static string ProposalCompose_Client_AddNew_CompanyText { get; set; }
        public static string ProposalCompose_Client_AddNew_EmailText { get; set; }
        public static string ProposalCompose_Client_AddNew_PhoneNumberText { get; set; }
        public static string ProposalCompose_Client_AddNew_HideShowAddressLink { get; set; }
        public static string ProposalCompose_Client_AddNew_AddressText { get; set; }
        public static string ProposalCompose_Client_AddNew_CityText { get; set; }
        public static string ProposalCompose_Client_AddNew_StateText { get; set; }
        public static string ProposalCompose_Client_AddNew_ZipText { get; set; }
        public static string ProposalCompose_Client_AddNew_CountryDropDown { get; set; }
        public static string ProposalCompose_Client_AddNew_SaveButton { get; set; }
        public static string ProposalCompose_Client_AddNew_CancelButton { get; set; }
        public static string ProposalCompose_CCText { get; set; }
        public static string ProposalCompose_BCCText { get; set; }
        public static string ProposalCompose_EventDate { get; set; }
        public static string ProposalCompose_ExpirationDate { get; set; }
        public static string ProposalCompose_WelcomeMessageText { get; set; }
        public static string ProposalCompose_WelcomeMessage_StoredContent1Link { get; set; }
        public static string ProposalCompose_WelcomeMessage_StoredContent2Link { get; set; }
        public static string ProposalCompose_WelcomeMessage_StoredContent3Link { get; set; }
        public static string ProposalCompose_WelcomeMessage_StoredContent4Link { get; set; }
        public static string ProposalCompose_MessageClosingText { get; set; }
        public static string ProposalCompose_SeniorStaffMessageText { get; set; }
        public static string ProposalCompose_UploadLogoLink { get; set; }
        public static string ProposalCompose_Client_UneditableTextBox { get; set; }
        public static string ProposalCompose_Client_SearchText { get; set; }
        public static string ProposalCompose_Client_EditLink { get; set; }
        public static string ProposalCompose_Calendar_MonthDropDown { get; set; }
        public static string ProposalCompose_Calendar_YearDropDown { get; set; }
        public static string ProposalCompose_Calendar_NextMonthButton { get; set; }
        public static string ProposalCompose_Calendar_PreviousMonthButton { get; set; }
        public static string ProposalCompose_RadioButton_Module1 { get; set; }
        public static string ProposalCompose_RadioButton_Module2 { get; set; }
        public static string ProposalCompose_RadioButton_Module3 { get; set; }
        public static string ProposalCompose_RadioButton_Module4 { get; set; }
        public static string ProposalCompose_CheckBox_UseMyFavoriteSettings { get; set; }
        public static string ProposalCompose_Button_ClientSearchResult { get; set; }
        public static string ProposalCompose_CheckBox_IncludeOfferAtBottomOfWelcomeLetter { get; set; }
        public static string ProposalCompose_Button_Next { get; set; }
        public static string ProposalCompose_Button_Client_Search_Search { get; set; }
        public static string ProposalCompose_Navigation_CreateEditTab { get; set; }
        public static string ProposalCompose_Navigation_eProposal { get; set; }
        public static string ProposalCompose_Link_AddAContact { get; set; }
        public static string ProposalCompose_Link_SearchResult { get; set; }
        public static string ProposalCompose_Navigation_eCard { get; set; }
        public static string ProposalCompose_View_Email { get; set; }
        public static string ProposalCompose_Button_Browse { get; set; }
        public static string ProposalCompose_Button_Upload { get; set; }
        public static string ProposalCompose_Image_ClientLogo { get; set; }
        #endregion[ProposalCompose]

        #region[ProposalCendynRoomBlock]

        public static string ProposalCendynRoomBlock_Button_Back { get; set; }
        public static string ProposalCendynRoomBlock_Button_Next { get; set; }
        public static string ProposalCendynRoomBlock_CheckBox_IncludeRoomBlockInProposal { get; set; }
        public static string ProposalCendynRoomBlock_CheckBox_AddIntroductionToRoomBlock { get; set; }
        public static string ProposalCendynRoomBlock_Text_RoomBlockIntroductionText { get; set; }
        public static string ProposalCendynRoomBlock_Text_RoomBlock_Category { get; set; }
        public static string ProposalCendynRoomBlock_Text_RoomBlock_RoomType1 { get; set; }
        public static string ProposalCendynRoomBlock_Text_RoomBlock_RoomType2 { get; set; }
        public static string ProposalCendynRoomBlock_Text_RoomBlock_RoomType3 { get; set; }
        public static string ProposalCendynRoomBlock_Text_RoomBlock_RoomType4 { get; set; }
        public static string ProposalCendynRoomBlock_Text_RoomBlock_Qty1 { get; set; }
        public static string ProposalCendynRoomBlock_Text_RoomBlock_Qty2 { get; set; }
        public static string ProposalCendynRoomBlock_Text_RoomBlock_Qty3 { get; set; }
        public static string ProposalCendynRoomBlock_Text_RoomBlock_Qty4 { get; set; }
        public static string ProposalCendynRoomBlock_Text_RoomBlock_Rate1 { get; set; }
        public static string ProposalCendynRoomBlock_Text_RoomBlock_Rate2 { get; set; }
        public static string ProposalCendynRoomBlock_Text_RoomBlock_Rate3 { get; set; }
        public static string ProposalCendynRoomBlock_Text_RoomBlock_Rate4 { get; set; }
        public static string ProposalCendynRoomBlock_Button_RoomBlock_Copy1 { get; set; }
        public static string ProposalCendynRoomBlock_Button_RoomBlock_Copy2 { get; set; }
        public static string ProposalCendynRoomBlock_Button_RoomBlock_Copy3 { get; set; }
        public static string ProposalCendynRoomBlock_Button_RoomBlock_Copy4 { get; set; }
        public static string ProposalCendynRoomBlock_Button_RoomBlock_ClearData1 { get; set; }
        public static string ProposalCendynRoomBlock_Button_RoomBlock_ClearData2 { get; set; }
        public static string ProposalCendynRoomBlock_Button_RoomBlock_ClearData3 { get; set; }
        public static string ProposalCendynRoomBlock_Button_RoomBlock_ClearData4 { get; set; }
        public static string ProposalCendynRoomBlock_Button_RoomBlock_Submit { get; set; }
        public static string ProposalCendynRoomBlock_Button_RoomBlock_Cancel { get; set; }
        public static string ProposalCendynRoomBlock_Button_RoomBlock_AddNewCategory { get; set; }
        public static string ProposalCendynRoomBlock_Button_RoomBlock_AddNewCategory_Copy { get; set; }
        public static string ProposalCendynRoomBlock_Button_RoomBlock_AddNewCategory_ClearData { get; set; }
        public static string ProposalCendynRoomBlock_Button_RoomBlock_AddNewCategory_Save { get; set; }
        public static string ProposalCendynRoomBlock_Button_RoomBlock_AddNewCategory_Cancel { get; set; }
        public static string ProposalCendynRoomBlock_Text_RoomBlock_AddNewCategory_Type { get; set; }
        public static string ProposalCendynRoomBlock_Text_RoomBlock_AddNewCategory_Qty { get; set; }
        public static string ProposalCendynRoomBlock_Text_RoomBlock_AddNewCategory_Rate { get; set; }
        public static string ProposalCendynRoomBlock_Button_AddAdditionalOptions { get; set; }
        public static string ProposalCendynRoomBlock_Text_AddAdditionalOptions_DateRangeAdditionalHotel { get; set; }
        public static string ProposalCendynRoomBlock_Text_AddAdditionalOptions_Category1 { get; set; }
        public static string ProposalCendynRoomBlock_Text_AddAdditionalOptions_Rate1 { get; set; }
        public static string ProposalCendynRoomBlock_Text_AddAdditionalOptions_Comments1 { get; set; }
        public static string ProposalCendynRoomBlock_Button_AddAdditionalOptions_Submit { get; set; }
        public static string ProposalCendynRoomBlock_Button_AddAdditionalOptions_Cancel { get; set; }
        public static string ProposalCendynRoomBlock_Text_RoomBlock_Comments { get; set; }

        #endregion[ProposalCendynRoomBlock]

        #region[ProposalCendynEventBlock]

        public static string ProposalCendynEventBlock_CheckBox_IncludeEventBlockInProposal { get; set; }
        public static string ProposalCendynEventBlock_Link_EventDate { get; set; }
        public static string ProposalCendynEventBlock_Text_StartTime { get; set; }
        public static string ProposalCendynEventBlock_Text_EndTime { get; set; }
        public static string ProposalCendynEventBlock_Text_Name { get; set; }
        public static string ProposalCendynEventBlock_Text_Room { get; set; }
        public static string ProposalCendynEventBlock_Text_Type { get; set; }
        public static string ProposalCendynEventBlock_Text_RentalFee { get; set; }
        public static string ProposalCendynEventBlock_Text_Guests { get; set; }
        public static string ProposalCendynEventBlock_Text_Setup { get; set; }
        public static string ProposalCendynEventBlock_Text_Notes { get; set; }
        public static string ProposalCendynEventBlock_Button_Submit { get; set; }
        public static string ProposalCendynEventBlock_Button_Cancel { get; set; }
        public static string ProposalCendynEventBlock_Text_EventBlockComments { get; set; }
        public static string ProposalCendynEventBlock_Link_EventBlockStoredContent1 { get; set; }
        public static string ProposalCendynEventBlock_Link_EventBlockStoredContent2 { get; set; }
        public static string ProposalCendynEventBlock_Link_AddEstimatedCosts { get; set; }
        public static string ProposalCendynEventBlock_RadioButton_EstimatedCosts_Include { get; set; }
        public static string ProposalCendynEventBlock_Text_EstimatedCosts_Item { get; set; }
        public static string ProposalCendynEventBlock_Text_EstimatedCosts_PricePerItems { get; set; }
        public static string ProposalCendynEventBlock_Text_EstimatedCosts_NumberOfItems { get; set; }
        public static string ProposalCendynEventBlock_Text_EstimatedCosts_NumberOfDays { get; set; }
        public static string ProposalCendynEventBlock_RadioButton_AdditionalFields_Include { get; set; }
        public static string ProposalCendynEventBlock_Text_AdditionalFields_Item { get; set; }
        public static string ProposalCendynEventBlock_Text_AdditionalFields_Amount { get; set; }
        public static string ProposalCendynEventBlock_Button_Back { get; set; }
        public static string ProposalCendynEventBlock_Button_Next { get; set; }

        #endregion[ProposalCendynEventBlock]

        #region[ProposalSelect]
        public static string ProposalSelect_Link_CheckAll { get; set; }
        public static string ProposalSelect_Link_Clear { get; set; }
        public static string ProposalSelect_Link_AddContract { get; set; }
        public static string ProposalSelect_Link_SelectVideo { get; set; }
        public static string ProposalSelect_TextBox_Attachment1 { get; set; }
        public static string ProposalSelect_Button_Browse_Attachment1 { get; set; }
        public static string ProposalSelect_TextBox_Attachment2 { get; set; }
        public static string ProposalSelect_Button_Browse_Attachment2 { get; set; }
        public static string ProposalSelect_TextBox_Attachment3 { get; set; }
        public static string ProposalSelect_Button_Browse_Attachment3 { get; set; }
        public static string ProposalSelect_TextBox_Attachment4 { get; set; }
        public static string ProposalSelect_Button_Browse_Attachment4 { get; set; }
        public static string ProposalSelect_TextBox_Attachment5 { get; set; }
        public static string ProposalSelect_Button_Browse_Attachment5 { get; set; }
        public static string ProposalSelect_TextBox_Attachment6 { get; set; }
        public static string ProposalSelect_Button_Browse_Attachment6 { get; set; }
        public static string ProposalSelect_Button_Upload { get; set; }
        public static string ProposalSelect_Button_Back { get; set; }
        public static string ProposalSelect_Button_Next { get; set; }
        public static string ProposalSelect_CheckBox_Navigation_Honors { get; set; }
        public static string ProposalSelect_Link_ViewYourVideo { get; set; }
        public static string ProposalSelect_Button_Cancel { get; set; }


        #endregion[ProposalSelect]

        #region[ProposalPreview]
        public static string ProposalPreview_Button_Send { get; set; }
        public static string ProposalPreview_CheckBox_SaveAsMyFavorite { get; set; }
        public static string ProposalPreview_Button_Preview { get; set; }
        public static string ProposalPreview_Link_SelfSend { get; set; }
        public static string ProposalPreview_DropDown_AnotherLanguage { get; set; }
        public static string ProposalPreview_View_CustomSignature { get; set; }
        public static string ProposalPreview_Link_PDF { get; set; }
        public static string ProposalPreview_PopUpButton_Preview { get; set; }
        public static string ProposalPreview_Iframe_SelectPage { get; set; }
        public static string ProposalPreview_Image_ClientLogo { get; set; }
        #endregion[ProposalPreview]

        #region[ProposalView]

        public static string ProposalView_Link_Navigation_Honors { get; set; }

        #endregion[ProposalView]

        #region[ClientEmail]

        public static string ClientEmail_Link_OpenYourProposal { get; set; }
        public static string ClientEmail_Link_DownloadPDF { get; set; }
        public static string ClientEmail_Link_TechnicalDifficulties { get; set; }
        public static string ClientEmail_Link_EmployeeEmail { get; set; }
        public static string ClientEmail_HiltonHeader { get; set; }
        public static string ClientEmail_HiltonFooter { get; set; }

        public static string ClientEmail_Text_EmployeeNameCendynQA { get; set; }
        public static string ClientEmail_Link_Forward { get; set; }
        public static string ClientEmail_Text_FirstName { get; set; }
        public static string ClientEmail_Text_LastName { get; set; }
        public static string ClientEmail_Text_Email { get; set; }
        public static string ClientEmail_Link_Submit { get; set; }
        public static string ClientEmail_Link_ViewInBrowser { get; set; }
        public static string ClientEmail_Image_CustomSignature { get; set; }
        public static string ClientEmail_Frame_ReviewAndResend { get; set; }
        public static string ClientEmail_Link_ViewProposal { get; set; }
        public static string ClientEmail_Dropdown_Language { get; set; }

        #endregion[ClientEmail]

        #region[Clients]

        public static string Clients_AddNewClient_FirstNameText { get; set; }
        public static string Clients_AddNewClient_LastNameText { get; set; }
        public static string Clients_AddNewClient_CompanyText { get; set; }
        public static string Clients_AddNewClient_EmailText { get; set; }
        public static string Clients_AddNewClient_PhoneText { get; set; }
        public static string Clients_AddNewClient_AddressText { get; set; }
        public static string Clients_AddNewClient_CityText { get; set; }
        public static string Clients_AddNewClient_StateText { get; set; }
        public static string Clients_AddNewClient_ZipText { get; set; }
        public static string Clients_AddNewClient_CountryDropDown { get; set; }
        public static string Clients_AddNewClient_ShowHideAddressLink { get; set; }
        public static string Clients_AddNewClient_AddClientButton { get; set; }
        public static string Clients_AddNewClientTab { get; set; }
        public static string Clients_SearchEditTab { get; set; }
        public static string Clients_SearchEdit_LastNameRadioButton { get; set; }
        public static string Clients_SearchEdit_EmailRadioButton { get; set; }
        public static string Clients_SearchEdit_CompanyRadioButton { get; set; }
        public static string Clients_SearchEdit_SearchText { get; set; }
        public static string Clients_SearchEdit_SearchButton { get; set; }
        public static string Clients_SearchEdit_EditFirstLink { get; set; }
        public static string Clients_SearchEdit_ExpandFirstButton { get; set; }
        public static string Clients_SearchEdit_FirstResultLink { get; set; }
        public static string Clients_SearchEdit_Edit_FirstNameText { get; set; }
        public static string Clients_SearchEdit_Edit_LastNameText { get; set; }
        public static string Clients_SearchEdit_Edit_CompanyText { get; set; }
        public static string Clients_SearchEdit_Edit_EmailText { get; set; }
        public static string Clients_SearchEdit_Edit_PhoneText { get; set; }
        public static string Clients_SearchEdit_Edit_AddressText { get; set; }
        public static string Clients_SearchEdit_Edit_CityText { get; set; }
        public static string Clients_SearchEdit_Edit_StateText { get; set; }
        public static string Clients_SearchEdit_Edit_ZipText { get; set; }
        public static string Clients_SearchEdit_Edit_CountryDropDown { get; set; }
        public static string Clients_SearchEdit_Edit_ShowHideAddressLink { get; set; }
        public static string Clients_SearchEdit_Edit_SaveButton { get; set; }
        public static string Clients_SearchEdit_Edit_CancelButton { get; set; }

        #endregion[Clients]

        #region[eCardCompose]

        public static string eCardCompose_Dropdown_Language { get; set; }
        public static string eCardCompose_RadioButton_eCardType_Ackowledgement { get; set; }
        public static string eCardCompose_RadioButton_eCardType_TurnDown { get; set; }
        public static string eCardCompose_DropDown_SelectCard { get; set; }
        public static string eCardCompose_DropDown_From { get; set; }
        public static string eCardCompose_Click_Client_SearchLink { get; set; }
        public static string eCardCompose_Click_Client_AddNewLink { get; set; }
        public static string eCardCompose_Text_Client_Search_Search { get; set; }
        public static string eCardCompose_Text_Client_Search_SearchButton { get; set; }
        public static string eCardCompose_Click_Client_Search_FirstResultLink { get; set; }
        public static string eCardCompose_Click_Client_Seartch_Close { get; set; }
        public static string eCardCompose_TextBox_Client_AddNew_FirstName { get; set; }
        public static string eCardCompose_TextBox_Client_AddNew_LastName { get; set; }
        public static string eCardCompose_TextBox_Client_AddNew_Company { get; set; }
        public static string eCardCompose_TextBox_Client_AddNew_EmailAddress { get; set; }
        public static string eCardCompose_TextBox_Client_AddNew_PhoneNumber { get; set; }
        public static string eCardCompose_TextBox_Client_AddNew_Address { get; set; }
        public static string eCardCompose_TextBox_Client_AddNew_City { get; set; }
        public static string eCardCompose_TextBox_Client_AddNew_State { get; set; }
        public static string eCardCompose_TextBox_Client_AddNew_Zip { get; set; }
        public static string eCardCompose_DropDown_Client_AddNew_Country { get; set; }
        public static string eCardCompose_Link_Client_AddNew_HideShowAddress { get; set; }
        public static string eCardCompose_Button_Client_AddNew_Save { get; set; }
        public static string eCardCompose_Button_Client_AddNew_Cancel { get; set; }
        public static string eCardCompose_TextBox_CC { get; set; }
        public static string eCardCompose_TextBox_BCC { get; set; }
        public static string eCardCompose_TextBox_EmailSubject { get; set; }
        public static string eCardCompose_TextBox_Message { get; set; }
        public static string eCardCompose_Link_StoredContent1 { get; set; }
        public static string eCardCompose_Link_StoredContent2 { get; set; }
        public static string eCardCompose_Link_StoredContent3 { get; set; }
        public static string eCardCompose_Link_StoredContent4 { get; set; }
        public static string eCardCompose_TextBox_MessageClosing { get; set; }
        public static string eCardCompose_Button_Next { get; set; }
        public static string eCardCompose_Button_YesProceed { get; set; }
        public static string eCardCompose_Button_Send { get; set; }
        public static string eCardCompose_Button_EmployeeNameCendynQA { get; set; }

        public static string eCardCompose_Image_CustomSignatureImage { get; set; }

        #endregion[eCardCompose]

        #region[Activity]

        public static string Activity_Navigation_ActivityTab { get; set; }
        public static string Activity_Link_From { get; set; }
        public static string Activity_Link_To { get; set; }
        public static string Activity_Link_eProposal { get; set; }
        public static string Activity_Link_Views { get; set; }
        public static string Activity_Link_SendingStatus { get; set; }
        public static string Activity_Link_SendOn { get; set; }
        public static string Activity_Link_EventDate { get; set; }
        public static string Activity_Link_CreatedOn { get; set; }
        public static string Activity_Link_ExpirationDate { get; set; }
        public static string Activity_Button_eCard { get; set; }
        public static string Activity_Link_eCard { get; set; }
        public static string Activity_Link_Preview { get; set; }
        public static string Activity_Link_GetLink { get; set; }
        public static string ActivityPreview_Button_Forward { get; set; }
        public static string Activity_GetLink_URL { get; set; }
        public static string Activity_Link_Resend { get; set; }
        public static string Activity_ResendLink_OK { get; set; }
        public static string Activity_ResendLink_Cancel { get; set; }
        public static string Activity_Button_Close { get; set; }
        public static string Activity_Link_Clone { get; set; }
        public static string Activity_Link_Status { get; set; }
        public static string Activity_StatusLink_Cancel { get; set; }
        public static string Activity_Link_DownloadPDF { get; set; }
        public static string Activity_DatePicker_ExpirationDate { get; set; }
        public static string Activity_Text_EventDate { get; set; }
        public static string Activity_Dropdown_ExpirationMonth { get; set; }
        public static string Activity_Dropdown_ExpirationYear { get; set; }
        public static string Activity_Text_ExpirationDate { get; set; }
        public static string Activity_Text_CreatedOnDate { get; set; }
        public static string Activity_Text_SendingStatus { get; set; }
        public static string Activity_Link_ReviewSend { get; set; }
        public static string Activity_Button_Send { get; set; }
        public static string Activity_Button_Search { get; set; }
        public static string Activity_Text_Search { get; set; }
        public static string Activity_Dropdown_CurrentlyViewing { get; set; }
        public static string Activity_Dropdown_Status { get; set; }
        public static string Activity_Button_Save { get; set; }
        public static string Activity_Text_Comment { get; set; }
        public static string Activity_Button_GetLinkClose { get; set; }
        public static string Activity_Link_AdvanceSearch { get; set; }
        public static string Activity_Dropdown_AdvanceSearch { get; set; }
        public static string Activity_Textbox_From { get; set; }
        public static string Activity_Textbox_To { get; set; }
        public static string Activity_Dropdown_In { get; set; }
        public static string Activity_Textbox_WiththeWords { get; set; }
        public static string Activity_Dropdown_With { get; set; }
        public static string ActivityAdvanceSearch_Button_Search { get; set; }
        public static string Activity_Icon_eCard { get; set; }
        public static string Activity_Icon_eProposal { get; set; }
        public static string Activity_Icon_ExpirationEndDate { get; set; }
        public static string Activity_Icon_ExpirationStartDate { get; set; }
        public static string Activity_Dropdown_ViewContracts { get; set; }
        public static string Activity_Link_ClickHere { get; set; }
        public static string Activity_Text_SignHere { get; set; }
        public static string Activity_Text_SignHere2 { get; set; }
        public static string Activity_Button_SubmitElectronically { get; set; }
        public static string Activity_Link_SignNow { get; set; }
        public static string Activity_Preview_CustomSignature { get; set; }
        public static string Activity_Preview_CustomSignatureImage { get; set; }
        public static string Activity_Search_Textbox { get; set; }
        public static string Activity_Search_Button { get; set; }

        #endregion[Activity]

        #region[Settings]

        public static string Settings_Tab_PropertyInfo { get; set; }
        public static string Settings_Tab_General { get; set; }
        public static string Settings_Tab_SeniorStaffInfo { get; set; }
        public static string Settings_Tab_StoredContent { get; set; }
        public static string Settings_Tab_RoomEventBlockComments { get; set; }
        public static string Settings_Tab_SpecialOffers { get; set; }
        public static string Settings_Tab_CustomizePDF { get; set; }
        public static string Settings_Tab_SocialMedia { get; set; }
        public static string Settings_SeniorStaffInfo_Dropdown_Module { get; set; }
        public static string Settings_CustomizePDF_Dropdown_Module { get; set; }
        public static string Settings_SpecialOffer_Dropdown_Module { get; set; }

        #endregion[Settings]

        #region[Settings_StoredContent]

        public static string Settings_StoredContent_DropDown_SelectModule { get; set; }
        public static string Settings_StoredContent_DropDown_SelectLanguage { get; set; }
        public static string Settings_StoredContent_Link_eProposal { get; set; }
        public static string Settings_StoredContent_Link_eCard { get; set; }
        public static string Settings_StoredContent_Button_AddNew { get; set; }
        public static string Settings_StoredContent_Link_FirstStoredContent_Edit { get; set; }
        public static string Settings_StoredContent_Link_FirstStoredContent_Delete { get; set; }

        #endregion[Settings_StoredContent]

        #region[Reports]

        public static string Reports_Link_ToDate { get; set; }
        public static string Reports_Link_ByYear { get; set; }
        public static string Reports_Link_ByDateRange { get; set; }
        public static string Reports_Link_ByUser { get; set; }
        public static string Reports_Link_PerClient { get; set; }
        public static string Reports_Dropdown_SelectModule { get; set; }
        public static string Reports_Dropdown_ProposalStatus { get; set; }
        public static string Reports_Dropdown_UserStatus { get; set; }
        public static string Reports_Button_Submit { get; set; }
        public static string Reports_Dropdown_Year { get; set; }
        public static string Reports_DatePicker_StartDate { get; set; }
        public static string Reports_DatePicker_EndDate { get; set; }
        public static string Reports_Dropdown_DatepickerMonth { get; set; }
        public static string Reports_Dropdown_DatepickerYear { get; set; }
        public static string Reports_Dropdown_Username { get; private set; }
        public static string Reports_RadioButton_Company { get; private set; }
        public static string Reports_RadioButton_Lastname { get; private set; }

        #endregion

        #region[eFaceTime]
        public static string eFaceTime_Link_Folder1 { get; set; }
        public static string eFaceTime_Link_Preview { get; set; }
        public static string eFaceTime_Link_Delete { get; set; }
        public static string eFaceTime_Button_AddVideo { get; set; }
        public static string eFaceTime_Text_NameYourVideo { get; set; }
        public static string eFaceTime_Dropdown_SelectFolder { get; set; }
        public static string eFaceTime_Button_YouTubeLink { get; set; }
        public static string eFaceTime_Text_PasteLink { get; set; }
        public static string eFaceTime_Button_SubmitLink { get; set; }
        public static string eFaceTime_Button_OkButton { get; set; }
        public static string eFaceTime_Link_Select { get; set; }
        public static string eFaceTime_Button_AttachYourVideo { get; set; }
        public static string eFaceTime_Button_UploadVideo { get; set; }
        public static string eFaceTime_Button_SelectVideos { get; set; }
        public static string eFaceTime_Button_ChooseFile { get; set; }
        #endregion

        #endregion[UI]

        #region[Admin]

        #region[AdminLogin]

        public static string AdminLogin_Text_UserName { get; set; }
        public static string AdminLogin_Text_Password { get; set; }
        public static string AdminLogin_Button_LogIn { get; set; }

        #endregion[AdminLogin]

        #region[AdminNavigation]

        public static string AdminNavigation_Button_Home { get; set; }
        public static string AdminNavigation_Button_Properties { get; set; }
        public static string AdminNavigation_Button_eProposal { get; set; }
        public static string AdminNavigation_Button_eCard { get; set; }
        public static string AdminNavigation_Button_Users { get; set; }
        public static string AdminNavigation_Button_Clients { get; set; }
        public static string AdminNavigation_Button_Brand { get; set; }
        public static string AdminNavigation_Button_Global { get; set; }
        public static string AdminNavigation_Dropdown_Property { get; set; }
        public static string AdminNavigation_Text_PropertyDD { get; set; }
        public static string AdminNavigation_Link_Search { get; set; }
        public static string AdminNavigation_Link_ClearSearch { get; set; }
        public static string AdminNavigation_Tab_Search_Regular { get; set; }
        public static string AdminNavigation_Tab_Search_SSO { get; set; }
        public static string AdminNavigation_Tab_Search_CVB { get; set; }
        public static string AdminNavigation_Tab_Search_Master { get; set; }
        public static string AdminNavigation_Tab_Search_Cluster { get; set; }
        public static string AdminNavigation_Tab_Search_GSO { get; set; }
        public static string AdminNavigation_Tab_Search_Convert { get; set; }
        public static string AdminNavigation_Tab_Search_Upgrade { get; set; }
        public static string AdminNavigation_Text_Search_ID { get; set; }
        public static string AdminNavigation_RadioButton_Search_ExternalLinkID { get; set; }
        public static string AdminNavigation_DropDown_Search_Brand { get; set; }
        public static string AdminNavigation_Text_Search_BrandDD { get; set; }
        public static string AdminNavigation_Text_Name { get; set; }
        public static string AdminNavigation_Button_Search_Search { get; set; }
        public static string AdminNavigation_Button_Search_ClearSearch { get; set; }
        public static string AdminNavigation_Button_Search_Close { get; set; }

        #endregion[AdminNavigation]

        #region[AdminClients]

        public static string AdminClients_Link_ShowAll { get; set; }
        public static string AdminClients_Link_AddNew { get; set; }
        public static string AdminClients_Link_Search { get; set; }
        public static string AdminClients_Button_Top_FirstPage { get; set; }
        public static string AdminClients_Button_Top_PreviousPage { get; set; }
        public static string AdminClients_Button_Top_NextPage { get; set; }
        public static string AdminClients_Button_Top_LastPage { get; set; }
        public static string AdminClients_DropDown_Top_GoToPage { get; set; }
        public static string AdminClients_Button_Bottom_FirstPage { get; set; }
        public static string AdminClients_Button_Bottom_PreviousPage { get; set; }
        public static string AdminClients_Button_Bottom_NextPage { get; set; }
        public static string AdminClients_Button_Bottom_LastPage { get; set; }
        public static string AdminClients_DropDown_Bottom_GoToPage { get; set; }

        #endregion[AdminClients]

        #region[AdminClients_Search]

        public static string AdminClients_Search_Tab_Global { get; set; }
        public static string AdminClients_Search_Tab_Property { get; set; }
        public static string AdminClients_Search_DropDown_SearchByName { get; set; }
        public static string AdminClients_Search_DropDown_SearchByWith { get; set; }
        public static string AdminClients_Search_Text_Search { get; set; }
        public static string AdminClients_Search_Button_Search { get; set; }
        public static string AdminClients_Search_Tab_Chain { get; set; }
        public static string AdminClients_Search_Tab_ChainBrand { get; set; }
        public static string AdminClients_Search_Tab_Independent { get; set; }
        public static string AdminClients_Search_Button_Top_FirstPage { get; set; }
        public static string AdminClients_Search_Button_Top_PreviousPage { get; set; }
        public static string AdminClients_Search_Button_Top_NextPage { get; set; }
        public static string AdminClients_Search_Button_Top_LastPage { get; set; }
        public static string AdminClients_Search_DropDown_Top_GoToPage { get; set; }
        public static string AdminClients_Search_Button_Bottom_FirstPage { get; set; }
        public static string AdminClients_Search_Button_Bottom_PreviousPage { get; set; }
        public static string AdminClients_Search_Button_Bottom_NextPage { get; set; }
        public static string AdminClients_Search_Button_Bottom_LastPage { get; set; }
        public static string AdminClients_Search_DropDown_Bottom_GoToPage { get; set; }
        public static string AdminClients_Search_Button_FirstClient_Edit { get; set; }

        #endregion[AdminClients_Search]

        #region [AdminUsers]

        public static string AdminUsers_Link_Search { get; set; }
        public static string AdminUsers_Dropdown_Option1 { get; set; }
        public static string AdminUsers_Dropdown_Option2 { get; set; }
        public static string AdminUsers_Button_Search { get; set; }
        public static string AdminUsers_Input_Searchbox { get; set; }
        public static string AdminUsers_Text_Search { get; set; }
        public static string AdminUsers_Link_LogIn { get; set; }
        public static string AdminUsers_Link_Edit { get; set; }
        public static string AdminUsers_EmployeeUpdate_CustomSignatureImage { get; set; }
        public static string AdminUsers_Button_ChooseFile { get; set; }
        public static string AdminUsers_Button_Update { get; set; }
        public static string AdminUsers_Link_EditFirstUser { get; set; }
        public static string AdminUsers_Link_Remove { get; set; }
        public static string AdminUsers_Link_LoginShowAll { get; set; }
        public static string AdminUsers_View_CustomSignatureValidator { get; set; }
        public static string AdminUsers_Button_No { get; set; }
        public static string AdminUsers_Link_AddNewUser { get; set; }
        public static string AdminUsers_Text_Firstname { get; set; }
        public static string AdminUsers_Text_Lastname { get; set; }
        public static string AdminUsers_Text_Email { get; set; }
        public static string AdminUsers_Text_Password { get; set; }
        public static string AdminUsers_Link_UserRole { get; set; }
        public static string AdminUsers_Dropdown_SelectLevel { get; set; }
        public static string AdminUsers_Text_PropertyName { get; set; }
        public static string AdminUsers_Checkbox_Property { get; set; }
        public static string AdminUsers_Arrow_AddToRight { get; set; }
        public static string AdminUsers_Button_Submit { get; set; }
        public static string AdminUsers_Button_Save { get; set; }
        public static string AdminUsers_Button_SearchProperty { get; set; }
        public static string AdminUsers_RadioButton_AccessSetting { get; set; }
        public static string AdminUsers_Button_Yes { get; set; }
        public static string AdminUsers_View_ShowAll_Signature { get; set; }

        #endregion [AdminUsers]

        #region[AdmineCard]

        public static string AdmineCard_Link_FooterLinks { get; set; }

        public static string AdmineCard_Link_AddMediaLink { get; set; }
        public static string AdmineCard_Input_LinkName { get; set; }
        public static string AdmineCard_Button_Save { get; set; }
        public static string AdmineCard_Button_UploadMediaFiles { get; set; }
        public static string AdmineCard_Button_Browse { get; set; }
        public static string AdmineCard_Button_UploadButton { get; set; }
        public static string AdmineCard_Button_CancelButton { get; set; }
        public static string AdmineCard_Link_GeneratedLinks { get; set; }
        public static string AdmineCard_Text_SkinName { get; set; }
        public static string AdmineCard_Button_ChooseFile { get; set; }
        public static string AdmineCard_Image_Preview { get; set; }
        public static string AdmineCard_Button_Addnew { get; set; }
        public static string AdmineCard_Button_UploadImage { get; set; }
        public static string AdmineCard_Button_UploadLogo { get; set; }
        public static string AdmineCard_Button_PopUpUpload { get; set; }
        public static string AdmineCard_Iframe_Upload { get; set; }

        #endregion[AdmineCard]

        #region [AdminProperties]

        public static string AdminProperties_PropertyDropDown_Button { get; set; }
        public static string AdminProperties_PropertyDropDown_Text { get; set; }
        public static string AdminProperties_Button_Features { get; set; }
        public static string AdminProperties_Button_Update { get; set; }
        public static string AdminProperties_Tab_RoomBlock { get; set; }
        public static string AdminProperties_Tab_Actions { get; set; }

        #endregion[AdminProperties]

        #region[AdminProperties_UpdateProperty_Features]

        public static string AdminProperties_UpdateProperty_Features_RadioButton_eCard_On { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_eCard_Off { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_eCard_Step1Link_On { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_eCard_Step1Link_Off { get; set; }

        public static string AdminProperties_UpdateProperty_Features_RadioButton_eCard_Default_AckOffwledgement
        {
            get;
            set;
        }

        public static string AdminProperties_UpdateProperty_Features_RadioButton_eCard_Default_TurnDown { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_eProposal_On { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_eProposal_Off { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_eMenus_On { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_eMenus_Off { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_Referral_On { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_Referral_Off { get; set; }
        public static string AdminProperties_UpdateProperty_Features_DropDown_PropertyRoll { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_eFaceTime_On { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_eFaceTime_Off { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_eFaceTime_Trial_On { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_eFaceTime_Trial_Off { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_SocialMedia_On { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_SocialMedia_Off { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_SocialMediaText_On { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_SocialMediaText_Off { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_VideoOnWelcomeMessage_On { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_VideoOnWelcomeMessage_Off { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_DateFormat_MMDDYYYY { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_DateFormat_DDMMYYYY { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_DateFormat_YYYYMMDD { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_IncludeDaylightSavings_On { get; set; }

        public static string AdminProperties_UpdateProperty_Features_RadioButton_IncludeDaylightSavings_Off
        {
            get;
            set;
        }

        public static string AdminProperties_UpdateProperty_Features_RadioButton_MilitaryTime_On { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_MilitaryTime_Off { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_HasDateSelection_On { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_HasDateSelection_Off { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_Attachment_On { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_Attachment_Off { get; set; }
        public static string AdminProperties_UpdateProperty_Features_DropDown_UploadNumber { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_HasSpecialOffer_On { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_HasSpecialOffer_Off { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_ClientLogo_On { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_ClientLogo_Off { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_BypassClientHomePage_On { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_BypassClientHomePage_Off { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_BCCGlobalSales_On { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_BCCGlobalSales_Off { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_DefaultComposerBCC_On { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_DefaultComposerBCC_Off { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_PDFSetting_On { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_PDFSetting_Off { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_CustomizePDF_On { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_CustomizePDF_Off { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_DocTypeSettings_On { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_DocTypeSettings_Off { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_eContract_On { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_eContract_Off { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_HeaderImages_On { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_HeaderImages_Off { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_eProposalDraftRemoval_On { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_eProposalDraftRemoval_Off { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_eProposalFavorite_On { get; set; }
        public static string AdminProperties_UpdateProperty_Features_RadioButton_eProposalFavorite_Off { get; set; }

        public static string AdminProperties_UpdateProperty_Features_RadioButton_eProposalBrochureIntegration_On
        {
            get;
            set;
        }

        public static string AdminProperties_UpdateProperty_Features_RadioButton_eProposalBrochureIntegration_Off
        {
            get;
            set;
        }

        public static string AdminProperties_UpdateProperty_Features_TextBox_FileShareLevel { get; set; }
        public static string AdminProperties_UpdateProperty_Features_Button_Update { get; set; }

        #endregion[AdminProperties_UpdateProperty_Features]

        #region[AdminProperties_UpdateProperty_RoomBlock]

        public static string AdminProperties_UpdateProperty_RoomBlock_RadioButton_RoomOnWelcome_On { get; set; }

        public static string AdminProperties_UpdateProperty_RoomBlock_RadioButton_RoomOnWelcome_DefaultChecked_On
        {
            get;
            set;
        }

        public static string AdminProperties_UpdateProperty_RoomBlock_RadioButton_RoomOnWelcome_ReadOnly_On
        {
            get;
            set;
        }

        public static string AdminProperties_UpdateProperty_RoomBlock_RadioButton_RoomOnWelcome_Off { get; set; }

        public static string AdminProperties_UpdateProperty_RoomBlock_RadioButton_RoomOnWelcome_DefaultChecked_Off
        {
            get;
            set;
        }

        public static string AdminProperties_UpdateProperty_RoomBlock_RadioButton_RoomOnWelcome_ReadOnly_Off
        {
            get;
            set;
        }

        public static string AdminProperties_UpdateProperty_RoomBlock_Button_Submit { get; set; }

        #endregion[AdminProperties_UpdateProperty_RoomBlock]

        #region[AdminProperties_AddNewLanguage]

        public static string AdminProperties_AddNewLanguage_DropDown_Language { get; set; }
        public static string AdminProperties_AddNewLanguage_Text_PropertyName { get; set; }
        public static string AdminProperties_AddNewLanguage_Text_AlternativePropertyName { get; set; }
        public static string AdminProperties_AddNewLanguage_Text_Address { get; set; }
        public static string AdminProperties_AddNewLanguage_Text_City { get; set; }
        public static string AdminProperties_AddNewLanguage_Text_State { get; set; }
        public static string AdminProperties_AddNewLanguage_Text_ZipCode { get; set; }
        public static string AdminProperties_AddNewLanguage_DropDown_Country { get; set; }
        public static string AdminProperties_AddNewLanguage_Text_CountryDisplayName { get; set; }
        public static string AdminProperties_AddNewLanguage_Text_MainPhone { get; set; }
        public static string AdminProperties_AddNewLanguage_Text_GroupSalesPhone { get; set; }
        public static string AdminProperties_AddNewLanguage_Text_Fax { get; set; }
        public static string AdminProperties_AddNewLanguage_Text_Email { get; set; }
        public static string AdminProperties_AddNewLanguage_Text_WelcomeTag { get; set; }
        public static string AdminProperties_AddNewLanguage_Text_Website { get; set; }
        public static string AdminProperties_AddNewLanguage_DropDown_Currency { get; set; }
        public static string AdminProperties_AddNewLanguage_Link_RoomBlockAddNew { get; set; }
        public static string AdminProperties_AddNewLanguage_Text_RoomBlockColumnLabel1 { get; set; }
        public static string AdminProperties_AddNewLanguage_Text_RoomBlockColumnLabel2 { get; set; }
        public static string AdminProperties_AddNewLanguage_Text_RoomBlockColumnLabel3 { get; set; }
        public static string AdminProperties_AddNewLanguage_Text_RoomBlockColumnLabel4 { get; set; }
        public static string AdminProperties_AddNewLanguage_Text_RoomBlockColumnLabel5 { get; set; }
        public static string AdminProperties_AddNewLanguage_Link_RoomBlockColumnDelete1 { get; set; }
        public static string AdminProperties_AddNewLanguage_Link_RoomBlockColumnDelete2 { get; set; }
        public static string AdminProperties_AddNewLanguage_Link_RoomBlockColumnDelete3 { get; set; }
        public static string AdminProperties_AddNewLanguage_Link_RoomBlockColumnDelete4 { get; set; }
        public static string AdminProperties_AddNewLanguage_Link_RoomBlockColumnDelete5 { get; set; }
        public static string AdminProperties_AddNewLanguage_Text_EmailBody { get; set; }
        public static string AdminProperties_AddNewLanguage_Text_EmailBodyBCC { get; set; }
        public static string AdminProperties_AddNewLanguage_Button_Save { get; set; }

        #endregion[AdminProperties_AddNewLanguage]

        #region[AdminProperties_UpdateProperty_Actions]

        public static string AdminProperties_UpdateProperty_Actions_RadioButton_MergeProperty_On { get; set; }
        public static string AdminProperties_UpdateProperty_Actions_RadioButton_MergeProperty_Off { get; set; }
        public static string AdminProperties_UpdateProperty_Actions_RadioButton_DisableProperty_On { get; set; }
        public static string AdminProperties_UpdateProperty_Actions_RadioButton_DisableProperty_Off { get; set; }
        public static string AdminProperties_UpdateProperty_Actions_RadioButton_MultiLanguageProperty_On { get; set; }
        public static string AdminProperties_UpdateProperty_Actions_RadioButton_MultiLanguageProperty_Off { get; set; }
        public static string AdminProperties_UpdateProperty_Actions_Button_Update { get; set; }

        #endregion[AdminProperties_UpdateProperty_Actions]

        #region[AdminEProposal]

        public static string AdminEProposal_Link_SetupModuleSettings { get; set; }
        public static string AdminEProposal_Link_SetupTemplates { get; set; }
        public static string AdminEProposal_Link_NavigationAndContent { get; set; }
        public static string AdminEProposal_Link_Paragraphs { get; set; }
        public static string AdminEProposal_Link_RoomEventBlockParagraph { get; set; }
        public static string AdminEProposal_Link_PropertyGMLetter { get; set; }
        public static string AdminEProposal_Link_ImageCaptionStyles { get; set; }
        public static string AdminEProposal_Link_MediaSetup { get; set; }
        public static string AdminEProposal_Link_HeaderGallery { get; set; }

        #endregion[AdminEProposal]

        #region[AdminEProposal_SetupModuleSettings]
        public static string AdminEProposal_SetupModuleSettings_Text_SubDomain_Module1 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Text_SubDomain_Module2 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Text_SubDomain_Module3 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Text_SubDomain_Module4 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Text_SubDomain_Module5 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_DropDown_ParentDomain_Module1 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_DropDown_ParentDomain_Module2 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_DropDown_ParentDomain_Module3 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_DropDown_ParentDomain_Module4 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_DropDown_ParentDomain_Module5 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Button_SetupProposalPreview_Update { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_InsertNewModuleSetting { get; set; }
        public static string AdminEProposal_SetupModuleSettings_DropDown_Module { get; set; }
        public static string AdminEProposal_SetupModuleSettings_DropDown_Market { get; set; }
        public static string AdminEProposal_SetupModuleSettings_DropDown_Theme { get; set; }
        public static string AdminEProposal_SetupModuleSettings_DropDown_Content { get; set; }
        public static string AdminEProposal_SetupModuleSettings_DropDown_Link { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Button_Search { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Button_UpdateActive { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Button_Delete_Module1 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Button_Delete_Module2 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Button_Delete_Module3 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Button_Delete_Module4 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Button_Delete_Module5 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Button_Delete_OK { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Button_Delete_Cancel { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Active_Module1 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Active_Module2 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Active_Module3 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Active_Module4 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Active_Module5 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Button_DisplayNameEdit_Module1 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Button_DisplayNameEdit_Module2 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Button_DisplayNameEdit_Module3 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Button_DisplayNameEdit_Module4 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Button_DisplayNameEdit_Module5 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Button_DisplayName_Save { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Button_DisplayName_Cancel { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_Preview_Module1 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_Preview_Module2 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_Preview_Module3 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_Preview_Module4 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_Preview_Module5 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Button_Javascript_Delete_Yes { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Button_Javascript_Delete_Cancel { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_StyleSheet_Brand_Module1 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_StyleSheet_Property_Module1 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_Javascript_Brand_Module1 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_Javascript_Property_Module1 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_Javascript_Upload_Module1 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_Javascript_Delete_Module1 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Language1_Module1 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Language2_Module1 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Language3_Module1 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Language4_Module1 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Language5_Module1 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_StyleSheet_Brand_Module2 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_StyleSheet_Property_Module2 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_Javascript_Brand_Module2 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_Javascript_Property_Module2 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_Javascript_Upload_Module2 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_Javascript_Delete_Module2 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Language1_Module2 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Language2_Module2 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Language3_Module2 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Language4_Module2 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Language5_Module2 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_StyleSheet_Brand_Module3 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_StyleSheet_Property_Module3 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_Javascript_Brand_Module3 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_Javascript_Property_Module3 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_Javascript_Upload_Module3 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_Javascript_Delete_Module3 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Language1_Module3 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Language2_Module3 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Language3_Module3 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Language4_Module3 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Language5_Module3 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_StyleSheet_Brand_Module4 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_StyleSheet_Property_Module4 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_Javascript_Brand_Module4 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_Javascript_Property_Module4 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_Javascript_Upload_Module4 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_Javascript_Delete_Module4 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Language1_Module4 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Language2_Module4 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Language3_Module4 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Language4_Module4 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Language5_Module4 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_StyleSheet_Brand_Module5 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_StyleSheet_Property_Module5 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_Javascript_Brand_Module5 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_Javascript_Property_Module5 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_Javascript_Upload_Module5 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Link_Javascript_Delete_Module5 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Language1_Module5 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Language2_Module5 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Language3_Module5 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Language4_Module5 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_CheckBox_Language5_Module5 { get; set; }
        public static string AdminEProposal_SetupModuleSettings_Button_UpdatePropertyResources_Save { get; set; }
        #endregion[AdminEProposal_SetupModuleSettings]

        #endregion[Admin]

        public static ObjectRepository ReadElement(string location, string nodeModule)
        {
            var obj = new ObjectRepository();
            var doc = XDocument.Load(location);
            var query = doc.Descendants(nodeModule).Elements()
                .ToDictionary(x => x.Attribute("key").Value,
                    x => x.Value);

            foreach (var pair in query)
            {
                #region[UI]

                #region[EmployeeLogin]

                if (nodeModule == Constants.EmployeeLogin)
                    if (pair.Key == "EmployeeLogin_EmailText")
                        EmployeeLogin_EmailText = pair.Value;
                    else if (pair.Key == "EmployeeLogin_LoginButtonNextStep")
                        EmployeeLogin_LoginButtonNextStep = pair.Value;
                    else if (pair.Key == "EmployeeLogin_PasswordText")
                        EmployeeLogin_PasswordText = pair.Value;
                    else if (pair.Key == "EmployeeLogin_SubmitButton")
                        EmployeeLogin_SubmitButton = pair.Value;
                    else if (pair.Key == "EmployeeLogin_ForgotPasswordLink")
                        EmployeeLogin_ForgotPasswordLink = pair.Value;
                    else if (pair.Key == "EmployeeLogin_ForgotPasswordEmailText")
                        EmployeeLogin_ForgotPasswordEmailText = pair.Value;
                    else if (pair.Key == "EmployeeLogin_ForgotPasswordSubmitButton")
                        EmployeeLogin_ForgotPasswordSubmitButton = pair.Value;
                    else if (pair.Key == "EmployeeLogin_ForgotPasswordLoginLink")
                        EmployeeLogin_ForgotPasswordLoginLink = pair.Value;
                    else if (pair.Key == "EmployeeLogin_DefaultSubmitButton")
                        EmployeeLogin_DefaultSubmitButton = pair.Value;
                    else if (pair.Key == "SSOLogin_Email")
                        SSOLogin_Email = pair.Value;
                    else if (pair.Key == "SSOLogin_Password")
                        SSOLogin_Password = pair.Value;
                    else if (pair.Key == "SSOLogin_Next")
                        SSOLogin_Next = pair.Value;
                    else if (pair.Key == "SSOLogin_Submit")
                        SSOLogin_Submit = pair.Value;
                    else if (pair.Key == "SSOLogin_VerificationCode")
                        SSOLogin_VerificationCode = pair.Value;
                    else if (pair.Key == "Login_IFrame_AgreeProceed")
                        Login_IFrame_AgreeProceed = pair.Value;
                    else if (pair.Key == "Login_IFrame_AgreeProceed_Close")
                        Login_IFrame_AgreeProceed_Close = pair.Value;


                #endregion[EmployeeLogin]

                #region[EmployeeHome]

                if (nodeModule == Constants.EmployeeHome)
                    if (pair.Key == "EmployeeHome_CreateEditButton")
                        EmployeeHome_CreateEditButton = pair.Value;
                    else if (pair.Key == "EmployeeHome_CreateEdit_eProposalButton")
                        EmployeeHome_CreateEdit_eProposalButton = pair.Value;
                    else if (pair.Key == "EmployeeHome_CreateEdit_eCardButton")
                        EmployeeHome_CreateEdit_eCardButton = pair.Value;
                    else if (pair.Key == "EmployeeHome_CreateEdit_eFacetimeButton")
                        EmployeeHome_CreateEdit_eFacetimeButton = pair.Value;
                    else if (pair.Key == "EmployeeHome_PropertyDropDown_Button")
                        EmployeeHome_PropertyDropDown_Button = pair.Value;
                    else if (pair.Key == "EmployeeHome_PropertyDropDown_Text")
                        EmployeeHome_PropertyDropDown_Text = pair.Value;
                    else if (pair.Key == "EmployeeHome_WelcomeButton")
                        EmployeeHome_WelcomeButton = pair.Value;
                    else if (pair.Key == "EmployeeHome_ViewAllLink")
                        EmployeeHome_ViewAllLink = pair.Value;
                    else if (pair.Key == "EmployeeHome_HelpLink")
                        EmployeeHome_HelpLink = pair.Value;
                    else if (pair.Key == "EmployeeHome_EditProfileLink")
                        EmployeeHome_EditProfileLink = pair.Value;
                    else if (pair.Key == "EmployeeHome_ClientsButton")
                        EmployeeHome_ClientsButton = pair.Value;
                    else if (pair.Key == "EmployeeHome_ReportsButton")
                        EmployeeHome_ReportsButton = pair.Value;
                    else if (pair.Key == "EmployeeHome_ActivityTab")
                        EmployeeHome_ActivityTab = pair.Value;
                    else if (pair.Key == "EmployeeHome_CreateEdit_eProposalButton2")
                        EmployeeHome_CreateEdit_eProposalButton2 = pair.Value;
                    else if (pair.Key == "EmployeeHome_MySettings")
                        EmployeeHome_MySettings = pair.Value;
                    else if (pair.Key == "EmployeeHome_MySettings_Demo")
                        EmployeeHome_MySettings_Demo = pair.Value;
                    else if (pair.Key == "EmployeeHome_MySettings_Click_Demo")
                        EmployeeHome_MySettings_Click_Demo = pair.Value;
                    else if (pair.Key == "EmployeeHome_MySettings_New")
                        EmployeeHome_MySettings_New = pair.Value;
                    else if (pair.Key == "EmployeeHome_MySettings_Click_New")
                        EmployeeHome_MySettings_Click_New = pair.Value;
                    else if (pair.Key == "EmployeeHome_Profile")
                        EmployeeHome_Profile = pair.Value;
                    else if (pair.Key == "EmployeeHome_AddEditProfile")
                        EmployeeHome_AddEditProfile = pair.Value;
                    else if (pair.Key == "EmployeeHome_Link_UpdateMySettings")
                        EmployeeHome_Link_UpdateMySettings = pair.Value;

                #endregion[EmployeeHome]

                #region[Profile]

                if (nodeModule == Constants.Profile)
                    if (pair.Key == "Profile_Button_ChooseFile")
                        Profile_Button_ChooseFile = pair.Value;
                    else if (pair.Key == "Profile_Button_Save")
                        Profile_Button_Save = pair.Value;
                    else if (pair.Key == "Profile_Link_Remove")
                        Profile_Link_Remove = pair.Value;
                    else if (pair.Key == "Profile_Button_Ok")
                        Profile_Button_Ok = pair.Value;
                    else if (pair.Key == "Profile_Image_CustomSignature")
                        Profile_Image_CustomSignature = pair.Value;
                    else if (pair.Key == "Profile_Field_CustomSignature")
                        Profile_Field_CustomSignature = pair.Value;
                    else if (pair.Key == "Profile_Button_No")
                        Profile_Button_No = pair.Value;
                    else if (pair.Key == "Profile_Button_Cancel")
                        Profile_Button_Cancel = pair.Value;
                    else if (pair.Key == "Profile_Button_ViewAll")
                        Profile_Button_ViewAll = pair.Value;
                    else if (pair.Key == "Profile_Link_EditFirstProfile")
                        Profile_Link_EditFirstProfile = pair.Value;
                    else if (pair.Key == "Profile_Link_ContinueToeProposal")
                        Profile_Link_ContinueToeProposal = pair.Value;

                #endregion[Profile]              

                #region[ProposalCompose]

                if (nodeModule == Constants.ProposalCompose)
                    if (pair.Key == "ProposalCompose_LanguageDropDown")
                        ProposalCompose_LanguageDropDown = pair.Value;
                    else if (pair.Key == "ProposalCompose_SelectProposalDropDown")
                        ProposalCompose_SelectProposalDropDown = pair.Value;
                    else if (pair.Key == "ProposalCompose_ProposalNameText")
                        ProposalCompose_ProposalNameText = pair.Value;
                    else if (pair.Key == "ProposalCompose_EmployeeFromDropDown")
                        ProposalCompose_EmployeeFromDropDown = pair.Value;
                    else if (pair.Key == "ProposalCompose_Client_SearchLink")
                        ProposalCompose_Client_SearchLink = pair.Value;
                    else if (pair.Key == "ProposalCompose_Client_AddNewLink")
                        ProposalCompose_Client_AddNewLink = pair.Value;
                    else if (pair.Key == "ProposalCompose_Client_AddNew_FirstNameText")
                        ProposalCompose_Client_AddNew_FirstNameText = pair.Value;
                    else if (pair.Key == "ProposalCompose_Client_AddNew_LastNameText")
                        ProposalCompose_Client_AddNew_LastNameText = pair.Value;
                    else if (pair.Key == "ProposalCompose_Client_AddNew_CompanyText")
                        ProposalCompose_Client_AddNew_CompanyText = pair.Value;
                    else if (pair.Key == "ProposalCompose_Client_AddNew_EmailText")
                        ProposalCompose_Client_AddNew_EmailText = pair.Value;
                    else if (pair.Key == "ProposalCompose_Client_AddNew_PhoneNumberText")
                        ProposalCompose_Client_AddNew_PhoneNumberText = pair.Value;
                    else if (pair.Key == "ProposalCompose_Client_AddNew_HideShowAddressLink")
                        ProposalCompose_Client_AddNew_HideShowAddressLink = pair.Value;
                    else if (pair.Key == "ProposalCompose_Client_AddNew_AddressText")
                        ProposalCompose_Client_AddNew_AddressText = pair.Value;
                    else if (pair.Key == "ProposalCompose_Client_AddNew_CityText")
                        ProposalCompose_Client_AddNew_CityText = pair.Value;
                    else if (pair.Key == "ProposalCompose_Client_AddNew_StateText")
                        ProposalCompose_Client_AddNew_StateText = pair.Value;
                    else if (pair.Key == "ProposalCompose_Client_AddNew_ZipText")
                        ProposalCompose_Client_AddNew_ZipText = pair.Value;
                    else if (pair.Key == "ProposalCompose_Client_AddNew_CountryDropDown")
                        ProposalCompose_Client_AddNew_CountryDropDown = pair.Value;
                    else if (pair.Key == "ProposalCompose_Client_AddNew_SaveButton")
                        ProposalCompose_Client_AddNew_SaveButton = pair.Value;
                    else if (pair.Key == "ProposalCompose_Client_AddNew_CancelButton")
                        ProposalCompose_Client_AddNew_CancelButton = pair.Value;
                    else if (pair.Key == "ProposalCompose_CCText")
                        ProposalCompose_CCText = pair.Value;
                    else if (pair.Key == "ProposalCompose_BCCText")
                        ProposalCompose_BCCText = pair.Value;
                    else if (pair.Key == "ProposalCompose_EventDate")
                        ProposalCompose_EventDate = pair.Value;
                    else if (pair.Key == "ProposalCompose_ExpirationDate")
                        ProposalCompose_ExpirationDate = pair.Value;
                    else if (pair.Key == "ProposalCompose_WelcomeMessageText")
                        ProposalCompose_WelcomeMessageText = pair.Value;
                    else if (pair.Key == "ProposalCompose_WelcomeMessage_StoredContent1Link")
                        ProposalCompose_WelcomeMessage_StoredContent1Link = pair.Value;
                    else if (pair.Key == "ProposalCompose_WelcomeMessage_StoredContent2Link")
                        ProposalCompose_WelcomeMessage_StoredContent2Link = pair.Value;
                    else if (pair.Key == "ProposalCompose_WelcomeMessage_StoredContent3Link")
                        ProposalCompose_WelcomeMessage_StoredContent3Link = pair.Value;
                    else if (pair.Key == "ProposalCompose_WelcomeMessage_StoredContent4Link")
                        ProposalCompose_WelcomeMessage_StoredContent4Link = pair.Value;
                    else if (pair.Key == "ProposalCompose_MessageClosingText")
                        ProposalCompose_MessageClosingText = pair.Value;
                    else if (pair.Key == "ProposalCompose_SeniorStaffMessageText")
                        ProposalCompose_SeniorStaffMessageText = pair.Value;
                    else if (pair.Key == "ProposalCompose_UploadLogoLink")
                        ProposalCompose_UploadLogoLink = pair.Value;
                    else if (pair.Key == "ProposalCompose_Client_UneditableTextBox")
                        ProposalCompose_Client_UneditableTextBox = pair.Value;
                    else if (pair.Key == "ProposalCompose_Client_SearchText")
                        ProposalCompose_Client_SearchText = pair.Value;
                    else if (pair.Key == "ProposalCompose_Client_EditLink")
                        ProposalCompose_Client_EditLink = pair.Value;
                    else if (pair.Key == "ProposalCompose_Calendar_MonthDropDown")
                        ProposalCompose_Calendar_MonthDropDown = pair.Value;
                    else if (pair.Key == "ProposalCompose_Calendar_YearDropDown")
                        ProposalCompose_Calendar_YearDropDown = pair.Value;
                    else if (pair.Key == "ProposalCompose_Calendar_NextMonthButton")
                        ProposalCompose_Calendar_NextMonthButton = pair.Value;
                    else if (pair.Key == "ProposalCompose_Calendar_PreviousMonthButton")
                        ProposalCompose_Calendar_PreviousMonthButton = pair.Value;
                    else if (pair.Key == "ProposalCompose_RadioButton_Module1")
                        ProposalCompose_RadioButton_Module1 = pair.Value;
                    else if (pair.Key == "ProposalCompose_RadioButton_Module2")
                        ProposalCompose_RadioButton_Module2 = pair.Value;
                    else if (pair.Key == "ProposalCompose_RadioButton_Module3")
                        ProposalCompose_RadioButton_Module3 = pair.Value;
                    else if (pair.Key == "ProposalCompose_RadioButton_Module4")
                        ProposalCompose_RadioButton_Module4 = pair.Value;
                    else if (pair.Key == "ProposalCompose_CheckBox_UseMyFavoriteSettings")
                        ProposalCompose_CheckBox_UseMyFavoriteSettings = pair.Value;
                    else if (pair.Key == "ProposalCompose_Button_ClientSearchResult")
                        ProposalCompose_Button_ClientSearchResult = pair.Value;
                    else if (pair.Key == "ProposalCompose_CheckBox_IncludeOfferAtBottomOfWelcomeLetter")
                        ProposalCompose_CheckBox_IncludeOfferAtBottomOfWelcomeLetter = pair.Value;
                    else if (pair.Key == "ProposalCompose_Button_Next")
                        ProposalCompose_Button_Next = pair.Value;
                    else if (pair.Key == "ProposalCompose_Button_Client_Search_Search")
                        ProposalCompose_Button_Client_Search_Search = pair.Value;
                    else if (pair.Key == "ProposalCompose_Navigation_CreateEditTab")
                        ProposalCompose_Navigation_CreateEditTab = pair.Value;
                    else if (pair.Key == "ProposalCompose_Navigation_eProposal")
                        ProposalCompose_Navigation_eProposal = pair.Value;
                    else if (pair.Key == "ProposalCompose_Link_AddAContact")
                        ProposalCompose_Link_AddAContact = pair.Value;
                    else if (pair.Key == "ProposalCompose_Link_SearchResult")
                        ProposalCompose_Link_SearchResult = pair.Value;
                    else if (pair.Key == "ProposalCompose_Navigation_eCard")
                        ProposalCompose_Navigation_eCard = pair.Value;
                    else if (pair.Key == "ProposalCompose_View_Email")
                        ProposalCompose_View_Email = pair.Value;
                    else if (pair.Key == "ProposalCompose_Button_Browse")
                        ProposalCompose_Button_Browse = pair.Value;
                    else if (pair.Key == "ProposalCompose_Button_Upload")
                        ProposalCompose_Button_Upload = pair.Value;
                    else if (pair.Key == "ProposalCompose_Image_ClientLogo")
                        ProposalCompose_Image_ClientLogo = pair.Value;

                #endregion[ProposalCompose]

                #region[ProposalCendynRoomBlock]

                if (nodeModule == Constants.ProposalCendynRoomBlock)
                    if (pair.Key == "ProposalCendynRoomBlock_Button_Back")
                        ProposalCendynRoomBlock_Button_Back = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Button_Next")
                        ProposalCendynRoomBlock_Button_Next = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_CheckBox_IncludeRoomBlockInProposal")
                        ProposalCendynRoomBlock_CheckBox_IncludeRoomBlockInProposal = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_CheckBox_AddIntroductionToRoomBlock")
                        ProposalCendynRoomBlock_CheckBox_AddIntroductionToRoomBlock = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Text_RoomBlockIntroductionText")
                        ProposalCendynRoomBlock_Text_RoomBlockIntroductionText = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Text_RoomBlock_Category")
                        ProposalCendynRoomBlock_Text_RoomBlock_Category = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Text_RoomBlock_RoomType1")
                        ProposalCendynRoomBlock_Text_RoomBlock_RoomType1 = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Text_RoomBlock_RoomType2")
                        ProposalCendynRoomBlock_Text_RoomBlock_RoomType2 = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Text_RoomBlock_RoomType3")
                        ProposalCendynRoomBlock_Text_RoomBlock_RoomType3 = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Text_RoomBlock_RoomType4")
                        ProposalCendynRoomBlock_Text_RoomBlock_RoomType4 = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Text_RoomBlock_Qty1")
                        ProposalCendynRoomBlock_Text_RoomBlock_Qty1 = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Text_RoomBlock_Qty2")
                        ProposalCendynRoomBlock_Text_RoomBlock_Qty2 = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Text_RoomBlock_Qty3")
                        ProposalCendynRoomBlock_Text_RoomBlock_Qty3 = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Text_RoomBlock_Qty4")
                        ProposalCendynRoomBlock_Text_RoomBlock_Qty4 = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Text_RoomBlock_Rate1")
                        ProposalCendynRoomBlock_Text_RoomBlock_Rate1 = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Text_RoomBlock_Rate2")
                        ProposalCendynRoomBlock_Text_RoomBlock_Rate2 = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Text_RoomBlock_Rate3")
                        ProposalCendynRoomBlock_Text_RoomBlock_Rate3 = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Text_RoomBlock_Rate4")
                        ProposalCendynRoomBlock_Text_RoomBlock_Rate4 = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Button_RoomBlock_Copy1")
                        ProposalCendynRoomBlock_Button_RoomBlock_Copy1 = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Button_RoomBlock_Copy2")
                        ProposalCendynRoomBlock_Button_RoomBlock_Copy2 = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Button_RoomBlock_Copy3")
                        ProposalCendynRoomBlock_Button_RoomBlock_Copy3 = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Button_RoomBlock_Copy4")
                        ProposalCendynRoomBlock_Button_RoomBlock_Copy4 = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Button_RoomBlock_ClearData1")
                        ProposalCendynRoomBlock_Button_RoomBlock_ClearData1 = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Button_RoomBlock_ClearData2")
                        ProposalCendynRoomBlock_Button_RoomBlock_ClearData2 = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Button_RoomBlock_ClearData3")
                        ProposalCendynRoomBlock_Button_RoomBlock_ClearData3 = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Button_RoomBlock_ClearData4")
                        ProposalCendynRoomBlock_Button_RoomBlock_ClearData4 = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Button_RoomBlock_Submit")
                        ProposalCendynRoomBlock_Button_RoomBlock_Submit = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Button_RoomBlock_Cancel")
                        ProposalCendynRoomBlock_Button_RoomBlock_Cancel = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Button_RoomBlock_AddNewCategory")
                        ProposalCendynRoomBlock_Button_RoomBlock_AddNewCategory = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Button_RoomBlock_AddNewCategory_Copy")
                        ProposalCendynRoomBlock_Button_RoomBlock_AddNewCategory_Copy = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Button_RoomBlock_AddNewCategory_ClearData")
                        ProposalCendynRoomBlock_Button_RoomBlock_AddNewCategory_ClearData = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Button_RoomBlock_AddNewCategory_Save")
                        ProposalCendynRoomBlock_Button_RoomBlock_AddNewCategory_Save = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Button_RoomBlock_AddNewCategory_Cancel")
                        ProposalCendynRoomBlock_Button_RoomBlock_AddNewCategory_Cancel = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Text_RoomBlock_AddNewCategory_Type")
                        ProposalCendynRoomBlock_Text_RoomBlock_AddNewCategory_Type = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Text_RoomBlock_AddNewCategory_Qty")
                        ProposalCendynRoomBlock_Text_RoomBlock_AddNewCategory_Qty = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Text_RoomBlock_AddNewCategory_Rate")
                        ProposalCendynRoomBlock_Text_RoomBlock_AddNewCategory_Rate = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Button_AddAdditionalOptions")
                        ProposalCendynRoomBlock_Button_AddAdditionalOptions = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Text_AddAdditionalOptions_DateRangeAdditionalHotel")
                        ProposalCendynRoomBlock_Text_AddAdditionalOptions_DateRangeAdditionalHotel = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Text_AddAdditionalOptions_Category1")
                        ProposalCendynRoomBlock_Text_AddAdditionalOptions_Category1 = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Text_AddAdditionalOptions_Rate1")
                        ProposalCendynRoomBlock_Text_AddAdditionalOptions_Rate1 = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Text_AddAdditionalOptions_Comments1")
                        ProposalCendynRoomBlock_Text_AddAdditionalOptions_Comments1 = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Button_AddAdditionalOptions_Submit")
                        ProposalCendynRoomBlock_Button_AddAdditionalOptions_Submit = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Button_AddAdditionalOptions_Cancel")
                        ProposalCendynRoomBlock_Button_AddAdditionalOptions_Cancel = pair.Value;
                    else if (pair.Key == "ProposalCendynRoomBlock_Text_RoomBlock_Comments")
                        ProposalCendynRoomBlock_Text_RoomBlock_Comments = pair.Value;

                #endregion[ProposalCendynRoomBlock]

                #region[ProposalCendynEventBlock]

                if (nodeModule == Constants.ProposalCendynEventBlock)
                    if (pair.Key == "ProposalCendynEventBlock_CheckBox_IncludeEventBlockInProposal")
                        ProposalCendynEventBlock_CheckBox_IncludeEventBlockInProposal = pair.Value;
                    else if (pair.Key == "ProposalCendynEventBlock_Link_EventDate")
                        ProposalCendynEventBlock_Link_EventDate = pair.Value;
                    else if (pair.Key == "ProposalCendynEventBlock_Text_StartTime")
                        ProposalCendynEventBlock_Text_StartTime = pair.Value;
                    else if (pair.Key == "ProposalCendynEventBlock_Text_EndTime")
                        ProposalCendynEventBlock_Text_EndTime = pair.Value;
                    else if (pair.Key == "ProposalCendynEventBlock_Text_Name")
                        ProposalCendynEventBlock_Text_Name = pair.Value;
                    else if (pair.Key == "ProposalCendynEventBlock_Text_Room")
                        ProposalCendynEventBlock_Text_Room = pair.Value;
                    else if (pair.Key == "ProposalCendynEventBlock_Text_Type")
                        ProposalCendynEventBlock_Text_Type = pair.Value;
                    else if (pair.Key == "ProposalCendynEventBlock_Text_RentalFee")
                        ProposalCendynEventBlock_Text_RentalFee = pair.Value;
                    else if (pair.Key == "ProposalCendynEventBlock_Text_Guests")
                        ProposalCendynEventBlock_Text_Guests = pair.Value;
                    else if (pair.Key == "ProposalCendynEventBlock_Text_Setup")
                        ProposalCendynEventBlock_Text_Setup = pair.Value;
                    else if (pair.Key == "ProposalCendynEventBlock_Text_Notes")
                        ProposalCendynEventBlock_Text_Notes = pair.Value;
                    else if (pair.Key == "ProposalCendynEventBlock_Button_Submit")
                        ProposalCendynEventBlock_Button_Submit = pair.Value;
                    else if (pair.Key == "ProposalCendynEventBlock_Button_Cancel")
                        ProposalCendynEventBlock_Button_Cancel = pair.Value;
                    else if (pair.Key == "ProposalCendynEventBlock_Text_EventBlockComments")
                        ProposalCendynEventBlock_Text_EventBlockComments = pair.Value;
                    else if (pair.Key == "ProposalCendynEventBlock_Link_EventBlockStoredContent1")
                        ProposalCendynEventBlock_Link_EventBlockStoredContent1 = pair.Value;
                    else if (pair.Key == "ProposalCendynEventBlock_Link_EventBlockStoredContent2")
                        ProposalCendynEventBlock_Link_EventBlockStoredContent2 = pair.Value;
                    else if (pair.Key == "ProposalCendynEventBlock_Link_AddEstimatedCosts")
                        ProposalCendynEventBlock_Link_AddEstimatedCosts = pair.Value;
                    else if (pair.Key == "ProposalCendynEventBlock_RadioButton_EstimatedCosts_Include")
                        ProposalCendynEventBlock_RadioButton_EstimatedCosts_Include = pair.Value;
                    else if (pair.Key == "ProposalCendynEventBlock_Text_EstimatedCosts_Item")
                        ProposalCendynEventBlock_Text_EstimatedCosts_Item = pair.Value;
                    else if (pair.Key == "ProposalCendynEventBlock_Text_EstimatedCosts_PricePerItems")
                        ProposalCendynEventBlock_Text_EstimatedCosts_PricePerItems = pair.Value;
                    else if (pair.Key == "ProposalCendynEventBlock_Text_EstimatedCosts_NumberOfItems")
                        ProposalCendynEventBlock_Text_EstimatedCosts_NumberOfItems = pair.Value;
                    else if (pair.Key == "ProposalCendynEventBlock_Text_EstimatedCosts_NumberOfDays")
                        ProposalCendynEventBlock_Text_EstimatedCosts_NumberOfDays = pair.Value;
                    else if (pair.Key == "ProposalCendynEventBlock_RadioButton_AdditionalFields_Include")
                        ProposalCendynEventBlock_RadioButton_AdditionalFields_Include = pair.Value;
                    else if (pair.Key == "ProposalCendynEventBlock_Text_AdditionalFields_Item")
                        ProposalCendynEventBlock_Text_AdditionalFields_Item = pair.Value;
                    else if (pair.Key == "ProposalCendynEventBlock_Text_AdditionalFields_Amount")
                        ProposalCendynEventBlock_Text_AdditionalFields_Amount = pair.Value;
                    else if (pair.Key == "ProposalCendynEventBlock_Button_Back")
                        ProposalCendynEventBlock_Button_Back = pair.Value;
                    else if (pair.Key == "ProposalCendynEventBlock_Button_Next")
                        ProposalCendynEventBlock_Button_Next = pair.Value;

                #endregion[ProposalCendynEventBlock]

                #region[ProposalSelect]

                if (nodeModule == Constants.ProposalSelect)
                    if (pair.Key == "ProposalSelect_Link_CheckAll")
                        ProposalSelect_Link_CheckAll = pair.Value;
                    else if (pair.Key == "ProposalSelect_Link_Clear")
                        ProposalSelect_Link_Clear = pair.Value;
                    else if (pair.Key == "ProposalSelect_Link_AddContract")
                        ProposalSelect_Link_AddContract = pair.Value;
                    else if (pair.Key == "ProposalSelect_Link_SelectVideo")
                        ProposalSelect_Link_SelectVideo = pair.Value;
                    else if (pair.Key == "ProposalSelect_TextBox_Attachment1")
                        ProposalSelect_TextBox_Attachment1 = pair.Value;
                    else if (pair.Key == "ProposalSelect_Button_Browse_Attachment1")
                        ProposalSelect_Button_Browse_Attachment1 = pair.Value;
                    else if (pair.Key == "ProposalSelect_TextBox_Attachment2")
                        ProposalSelect_TextBox_Attachment2 = pair.Value;
                    else if (pair.Key == "ProposalSelect_Button_Browse_Attachment2")
                        ProposalSelect_Button_Browse_Attachment2 = pair.Value;
                    else if (pair.Key == "ProposalSelect_TextBox_Attachment3")
                        ProposalSelect_TextBox_Attachment3 = pair.Value;
                    else if (pair.Key == "ProposalSelect_Button_Browse_Attachment3")
                        ProposalSelect_Button_Browse_Attachment3 = pair.Value;
                    else if (pair.Key == "ProposalSelect_TextBox_Attachment4")
                        ProposalSelect_TextBox_Attachment4 = pair.Value;
                    else if (pair.Key == "ProposalSelect_Button_Browse_Attachment4")
                        ProposalSelect_Button_Browse_Attachment4 = pair.Value;
                    else if (pair.Key == "ProposalSelect_TextBox_Attachment5")
                        ProposalSelect_TextBox_Attachment5 = pair.Value;
                    else if (pair.Key == "ProposalSelect_Button_Browse_Attachment5")
                        ProposalSelect_Button_Browse_Attachment5 = pair.Value;
                    else if (pair.Key == "ProposalSelect_TextBox_Attachment6")
                        ProposalSelect_TextBox_Attachment6 = pair.Value;
                    else if (pair.Key == "ProposalSelect_Button_Browse_Attachment6")
                        ProposalSelect_Button_Browse_Attachment6 = pair.Value;
                    else if (pair.Key == "ProposalSelect_Button_Upload")
                        ProposalSelect_Button_Upload = pair.Value;
                    else if (pair.Key == "ProposalSelect_Button_Back")
                        ProposalSelect_Button_Back = pair.Value;
                    else if (pair.Key == "ProposalSelect_Button_Next")
                        ProposalSelect_Button_Next = pair.Value;
                    else if (pair.Key == "ProposalSelect_CheckBox_Navigation_Honors")
                        ProposalSelect_CheckBox_Navigation_Honors = pair.Value;
                    else if (pair.Key == "ProposalSelect_Link_ViewYourVideo")
                        ProposalSelect_Link_ViewYourVideo = pair.Value;
                    else if (pair.Key == "ProposalSelect_Button_Cancel")
                        ProposalSelect_Button_Cancel = pair.Value;

                #endregion[ProposalSelect]

                #region[ProposalPreview]

                if (nodeModule == Constants.ProposalPreview)
                    if (pair.Key == "ProposalPreview_Button_Send")
                        ProposalPreview_Button_Send = pair.Value;
                    else if (pair.Key == "ProposalPreview_CheckBox_SaveAsMyFavorite")
                        ProposalPreview_CheckBox_SaveAsMyFavorite = pair.Value;
                    else if (pair.Key == "ProposalPreview_Button_Preview")
                        ProposalPreview_Button_Preview = pair.Value;
                    else if (pair.Key == "ProposalPreview_Link_SelfSend")
                        ProposalPreview_Link_SelfSend = pair.Value;
                    else if (pair.Key == "ProposalPreview_DropDown_AnotherLanguage")
                        ProposalPreview_DropDown_AnotherLanguage = pair.Value;
                    else if (pair.Key == "ProposalPreview_View_CustomSignature")
                        ProposalPreview_View_CustomSignature = pair.Value;
                    else if (pair.Key == "ProposalPreview_Link_PDF")
                        ProposalPreview_Link_PDF = pair.Value;
                    else if (pair.Key == "ProposalPreview_PopUpButton_Preview")
                        ProposalPreview_PopUpButton_Preview = pair.Value;
                    else if (pair.Key == "ProposalPreview_Iframe_SelectPage")
                        ProposalPreview_Iframe_SelectPage = pair.Value;
                    else if (pair.Key == "ProposalPreview_Image_ClientLogo")
                        ProposalPreview_Image_ClientLogo = pair.Value;

                #endregion[ProposalPreview]

                #region[ProposalView]

                if (nodeModule == Constants.ProposalView)
                    if (pair.Key == "ProposalView_Link_Navigation_Honors")
                        ProposalView_Link_Navigation_Honors = pair.Value;

                #endregion[ProposalView]

                #region[ClientEmail]

                if (nodeModule == Constants.ClientEmail)
                    if (pair.Key == "ClientEmail_Link_OpenYourProposal")
                        ClientEmail_Link_OpenYourProposal = pair.Value;
                    else if (pair.Key == "ClientEmail_Link_DownloadPDF")
                        ClientEmail_Link_DownloadPDF = pair.Value;
                    else if (pair.Key == "ClientEmail_Link_TechnicalDifficulties")
                        ClientEmail_Link_TechnicalDifficulties = pair.Value;
                    else if (pair.Key == "ClientEmail_Link_EmployeeEmail")
                        ClientEmail_Link_EmployeeEmail = pair.Value;
                    else if (pair.Key == "ClientEmail_HiltonHeader")
                        ClientEmail_HiltonHeader = pair.Value;
                    else if (pair.Key == "ClientEmail_HiltonFooter")
                        ClientEmail_HiltonFooter = pair.Value;
                    else if (pair.Key == "ClientEmail_Link_ViewInBrowser")
                        ClientEmail_Link_ViewInBrowser = pair.Value;
                    else if (pair.Key == "ClientEmail_Text_EmployeeNameCendynQA")
                        ClientEmail_Text_EmployeeNameCendynQA = pair.Value;
                    else if (pair.Key == "ClientEmail_Image_CustomSignature")
                        ClientEmail_Image_CustomSignature = pair.Value;
                    else if (pair.Key == "ClientEmail_Link_Forward")
                        ClientEmail_Link_Forward = pair.Value;
                    else if (pair.Key == "ClientEmail_Text_FirstName")
                        ClientEmail_Text_FirstName = pair.Value;
                    else if (pair.Key == "ClientEmail_Text_LastName")
                        ClientEmail_Text_LastName = pair.Value;
                    else if (pair.Key == "ClientEmail_Link_Submit")
                        ClientEmail_Link_Submit = pair.Value;
                    else if (pair.Key == "ClientEmail_Text_Email")
                        ClientEmail_Text_Email = pair.Value;
                    else if (pair.Key == "ClientEmail_Frame_ReviewAndResend")
                        ClientEmail_Frame_ReviewAndResend = pair.Value;
                    else if (pair.Key == "ClientEmail_Link_ViewProposal")
                        ClientEmail_Link_ViewProposal = pair.Value;
                    else if (pair.Key == "ClientEmail_Dropdown_Language")
                        ClientEmail_Dropdown_Language = pair.Value;

                #endregion[ClientEmail]

                #region[Clients]

                if (nodeModule == Constants.Clients)
                    if (pair.Key == "Clients_AddNewClient_FirstNameText")
                        Clients_AddNewClient_FirstNameText = pair.Value;
                    else if (pair.Key == "Clients_AddNewClient_LastNameText")
                        Clients_AddNewClient_LastNameText = pair.Value;
                    else if (pair.Key == "Clients_AddNewClient_CompanyText")
                        Clients_AddNewClient_CompanyText = pair.Value;
                    else if (pair.Key == "Clients_AddNewClient_EmailText")
                        Clients_AddNewClient_EmailText = pair.Value;
                    else if (pair.Key == "Clients_AddNewClient_PhoneText")
                        Clients_AddNewClient_PhoneText = pair.Value;
                    else if (pair.Key == "Clients_AddNewClient_AddressText")
                        Clients_AddNewClient_AddressText = pair.Value;
                    else if (pair.Key == "Clients_AddNewClient_CityText")
                        Clients_AddNewClient_CityText = pair.Value;
                    else if (pair.Key == "Clients_AddNewClient_StateText")
                        Clients_AddNewClient_StateText = pair.Value;
                    else if (pair.Key == "Clients_AddNewClient_ZipText")
                        Clients_AddNewClient_ZipText = pair.Value;
                    else if (pair.Key == "Clients_AddNewClient_CountryDropDown")
                        Clients_AddNewClient_CountryDropDown = pair.Value;
                    else if (pair.Key == "Clients_AddNewClient_ShowHideAddressLink")
                        Clients_AddNewClient_ShowHideAddressLink = pair.Value;
                    else if (pair.Key == "Clients_AddNewClient_AddClientButton")
                        Clients_AddNewClient_AddClientButton = pair.Value;
                    else if (pair.Key == "Clients_AddNewClientTab")
                        Clients_AddNewClientTab = pair.Value;
                    else if (pair.Key == "Clients_SearchEditTab")
                        Clients_SearchEditTab = pair.Value;
                    else if (pair.Key == "Clients_SearchEdit_LastNameRadioButton")
                        Clients_SearchEdit_LastNameRadioButton = pair.Value;
                    else if (pair.Key == "Clients_SearchEdit_EmailRadioButton")
                        Clients_SearchEdit_EmailRadioButton = pair.Value;
                    else if (pair.Key == "Clients_SearchEdit_CompanyRadioButton")
                        Clients_SearchEdit_CompanyRadioButton = pair.Value;
                    else if (pair.Key == "Clients_SearchEdit_SearchText")
                        Clients_SearchEdit_SearchText = pair.Value;
                    else if (pair.Key == "Clients_SearchEdit_SearchButton")
                        Clients_SearchEdit_SearchButton = pair.Value;
                    else if (pair.Key == "Clients_SearchEdit_EditFirstLink")
                        Clients_SearchEdit_EditFirstLink = pair.Value;
                    else if (pair.Key == "Clients_SearchEdit_ExpandFirstButton")
                        Clients_SearchEdit_ExpandFirstButton = pair.Value;
                    else if (pair.Key == "Clients_SearchEdit_FirstResultLink")
                        Clients_SearchEdit_FirstResultLink = pair.Value;
                    else if (pair.Key == "Clients_SearchEdit_Edit_FirstNameText")
                        Clients_SearchEdit_Edit_FirstNameText = pair.Value;
                    else if (pair.Key == "Clients_SearchEdit_Edit_LastNameText")
                        Clients_SearchEdit_Edit_LastNameText = pair.Value;
                    else if (pair.Key == "Clients_SearchEdit_Edit_CompanyText")
                        Clients_SearchEdit_Edit_CompanyText = pair.Value;
                    else if (pair.Key == "Clients_SearchEdit_Edit_EmailText")
                        Clients_SearchEdit_Edit_EmailText = pair.Value;
                    else if (pair.Key == "Clients_SearchEdit_Edit_PhoneText")
                        Clients_SearchEdit_Edit_PhoneText = pair.Value;
                    else if (pair.Key == "Clients_SearchEdit_Edit_AddressText")
                        Clients_SearchEdit_Edit_AddressText = pair.Value;
                    else if (pair.Key == "Clients_SearchEdit_Edit_CityText")
                        Clients_SearchEdit_Edit_CityText = pair.Value;
                    else if (pair.Key == "Clients_SearchEdit_Edit_StateText")
                        Clients_SearchEdit_Edit_StateText = pair.Value;
                    else if (pair.Key == "Clients_SearchEdit_Edit_ZipText")
                        Clients_SearchEdit_Edit_ZipText = pair.Value;
                    else if (pair.Key == "Clients_SearchEdit_Edit_CountryDropDown")
                        Clients_SearchEdit_Edit_CountryDropDown = pair.Value;
                    else if (pair.Key == "Clients_SearchEdit_Edit_ShowHideAddressLink")
                        Clients_SearchEdit_Edit_ShowHideAddressLink = pair.Value;
                    else if (pair.Key == "Clients_SearchEdit_Edit_SaveButton")
                        Clients_SearchEdit_Edit_SaveButton = pair.Value;
                    else if (pair.Key == "Clients_SearchEdit_Edit_CancelButton")
                        Clients_SearchEdit_Edit_CancelButton = pair.Value;

                #endregion[Clients]                               

                #region[eCardCompose]

                if (nodeModule == Constants.eCardCompose)
                    if (pair.Key == "eCardCompose_Dropdown_Language")
                        eCardCompose_Dropdown_Language = pair.Value;
                    else if (pair.Key == "eCardCompose_RadioButton_eCardType_Ackowledgement")
                        eCardCompose_RadioButton_eCardType_Ackowledgement = pair.Value;
                    else if (pair.Key == "eCardCompose_RadioButton_eCardType_TurnDown")
                        eCardCompose_RadioButton_eCardType_TurnDown = pair.Value;
                    else if (pair.Key == "eCardCompose_DropDown_SelectCard")
                        eCardCompose_DropDown_SelectCard = pair.Value;
                    else if (pair.Key == "eCardCompose_DropDown_From")
                        eCardCompose_DropDown_From = pair.Value;
                    else if (pair.Key == "eCardCompose_Click_Client_SearchLink")
                        eCardCompose_Click_Client_SearchLink = pair.Value;
                    else if (pair.Key == "eCardCompose_Click_Client_AddNewLink")
                        eCardCompose_Click_Client_AddNewLink = pair.Value;
                    else if (pair.Key == "eCardCompose_Text_Client_Search_Search")
                        eCardCompose_Text_Client_Search_Search = pair.Value;
                    else if (pair.Key == "eCardCompose_Text_Client_Search_SearchButton")
                        eCardCompose_Text_Client_Search_SearchButton = pair.Value;
                    else if (pair.Key == "eCardCompose_Click_Client_Search_FirstResultLink")
                        eCardCompose_Click_Client_Search_FirstResultLink = pair.Value;
                    else if (pair.Key == "eCardCompose_Click_Client_Seartch_Close")
                        eCardCompose_Click_Client_Seartch_Close = pair.Value;
                    else if (pair.Key == "eCardCompose_TextBox_Client_AddNew_FirstName")
                        eCardCompose_TextBox_Client_AddNew_FirstName = pair.Value;
                    else if (pair.Key == "eCardCompose_TextBox_Client_AddNew_LastName")
                        eCardCompose_TextBox_Client_AddNew_LastName = pair.Value;
                    else if (pair.Key == "eCardCompose_TextBox_Client_AddNew_Company")
                        eCardCompose_TextBox_Client_AddNew_Company = pair.Value;
                    else if (pair.Key == "eCardCompose_TextBox_Client_AddNew_EmailAddress")
                        eCardCompose_TextBox_Client_AddNew_EmailAddress = pair.Value;
                    else if (pair.Key == "eCardCompose_TextBox_Client_AddNew_PhoneNumber")
                        eCardCompose_TextBox_Client_AddNew_PhoneNumber = pair.Value;
                    else if (pair.Key == "eCardCompose_TextBox_Client_AddNew_Address")
                        eCardCompose_TextBox_Client_AddNew_Address = pair.Value;
                    else if (pair.Key == "eCardCompose_TextBox_Client_AddNew_City")
                        eCardCompose_TextBox_Client_AddNew_City = pair.Value;
                    else if (pair.Key == "eCardCompose_TextBox_Client_AddNew_State")
                        eCardCompose_TextBox_Client_AddNew_State = pair.Value;
                    else if (pair.Key == "eCardCompose_TextBox_Client_AddNew_Zip")
                        eCardCompose_TextBox_Client_AddNew_Zip = pair.Value;
                    else if (pair.Key == "eCardCompose_DropDown_Client_AddNew_Country")
                        eCardCompose_DropDown_Client_AddNew_Country = pair.Value;
                    else if (pair.Key == "eCardCompose_Link_Client_AddNew_HideShowAddress")
                        eCardCompose_Link_Client_AddNew_HideShowAddress = pair.Value;
                    else if (pair.Key == "eCardCompose_Button_Client_AddNew_Save")
                        eCardCompose_Button_Client_AddNew_Save = pair.Value;
                    else if (pair.Key == "eCardCompose_Button_Client_AddNew_Cancel")
                        eCardCompose_Button_Client_AddNew_Cancel = pair.Value;
                    else if (pair.Key == "eCardCompose_TextBox_CC")
                        eCardCompose_TextBox_CC = pair.Value;
                    else if (pair.Key == "eCardCompose_TextBox_BCC")
                        eCardCompose_TextBox_BCC = pair.Value;
                    else if (pair.Key == "eCardCompose_TextBox_EmailSubject")
                        eCardCompose_TextBox_EmailSubject = pair.Value;
                    else if (pair.Key == "eCardCompose_TextBox_Message")
                        eCardCompose_TextBox_Message = pair.Value;
                    else if (pair.Key == "eCardCompose_Link_StoredContent1")
                        eCardCompose_Link_StoredContent1 = pair.Value;
                    else if (pair.Key == "eCardCompose_Link_StoredContent2")
                        eCardCompose_Link_StoredContent2 = pair.Value;
                    else if (pair.Key == "eCardCompose_Link_StoredContent3")
                        eCardCompose_Link_StoredContent3 = pair.Value;
                    else if (pair.Key == "eCardCompose_Link_StoredContent4")
                        eCardCompose_Link_StoredContent4 = pair.Value;
                    else if (pair.Key == "eCardCompose_TextBox_MessageClosing")
                        eCardCompose_TextBox_MessageClosing = pair.Value;
                    else if (pair.Key == "eCardCompose_Button_Next")
                        eCardCompose_Button_Next = pair.Value;
                    else if (pair.Key == "eCardCompose_Button_YesProceed")
                        eCardCompose_Button_YesProceed = pair.Value;
                    else if (pair.Key == "eCardCompose_Button_Send")
                        eCardCompose_Button_Send = pair.Value;
                    else if (pair.Key == "eCardCompose_Button_EmployeeNameCendynQA")
                        eCardCompose_Button_EmployeeNameCendynQA = pair.Value;
                    else if (pair.Key == "eCardCompose_Image_CustomSignatureImage")
                        eCardCompose_Image_CustomSignatureImage = pair.Value;

                #endregion[eCardCompose]

                #region[eFaceTime]

                if (nodeModule == Constants.eFaceTime)
                    if (pair.Key == "eFaceTime_Link_Folder1")
                        eFaceTime_Link_Folder1 = pair.Value;
                    else if (pair.Key == "eFaceTime_Link_Preview")
                        eFaceTime_Link_Preview = pair.Value;
                    else if (pair.Key == "eFaceTime_Link_Delete")
                        eFaceTime_Link_Delete = pair.Value;
                    else if (pair.Key == "eFaceTime_Button_AddVideo")
                        eFaceTime_Button_AddVideo = pair.Value;
                    else if (pair.Key == "eFaceTime_Text_NameYourVideo")
                        eFaceTime_Text_NameYourVideo = pair.Value;
                    else if (pair.Key == "eFaceTime_Dropdown_SelectFolder")
                        eFaceTime_Dropdown_SelectFolder = pair.Value;
                    else if (pair.Key == "eFaceTime_Button_YouTubeLink")
                        eFaceTime_Button_YouTubeLink = pair.Value;
                    else if (pair.Key == "eFaceTime_Text_PasteLink")
                        eFaceTime_Text_PasteLink = pair.Value;
                    else if (pair.Key == "eFaceTime_Button_SubmitLink")
                        eFaceTime_Button_SubmitLink = pair.Value;
                    else if (pair.Key == "eFaceTime_Button_OkButton")
                        eFaceTime_Button_OkButton = pair.Value;
                    else if (pair.Key == "eFaceTime_Link_Select")
                        eFaceTime_Link_Select = pair.Value;
                    else if (pair.Key == "eFaceTime_Button_AttachYourVideo")
                        eFaceTime_Button_AttachYourVideo = pair.Value;
                    else if (pair.Key == "eFaceTime_Button_UploadVideo")
                        eFaceTime_Button_UploadVideo = pair.Value;
                    else if (pair.Key == "eFaceTime_Button_SelectVideos")
                        eFaceTime_Button_SelectVideos = pair.Value;
                    else if (pair.Key == "eFaceTime_Button_ChooseFile")
                        eFaceTime_Button_ChooseFile = pair.Value;

                #endregion

                #region[Activity]

                if (nodeModule == Constants.Activity)
                    if (pair.Key == "Activity_Navigation_ActivityTab")
                        Activity_Navigation_ActivityTab = pair.Value;
                    else if (pair.Key == "Activity_Link_From")
                        Activity_Link_From = pair.Value;
                    else if (pair.Key == "Activity_Link_To")
                        Activity_Link_To = pair.Value;
                    else if (pair.Key == "Activity_Link_eProposal")
                        Activity_Link_eProposal = pair.Value;
                    else if (pair.Key == "Activity_Link_Views")
                        Activity_Link_Views = pair.Value;
                    else if (pair.Key == "Activity_Link_SendingStatus")
                        Activity_Link_SendingStatus = pair.Value;
                    else if (pair.Key == "Activity_Link_SendOn")
                        Activity_Link_SendOn = pair.Value;
                    else if (pair.Key == "Activity_Link_EventDate")
                        Activity_Link_EventDate = pair.Value;
                    else if (pair.Key == "Activity_Link_ExpirationDate")
                        Activity_Link_ExpirationDate = pair.Value;
                    else if (pair.Key == "Activity_Link_CreatedOn")
                        Activity_Link_CreatedOn = pair.Value;
                    else if (pair.Key == "Activity_Button_eCard")
                        Activity_Button_eCard = pair.Value;
                    else if (pair.Key == "Activity_Link_eCard")
                        Activity_Link_eCard = pair.Value;
                    else if (pair.Key == "Activity_Link_Preview")
                        Activity_Link_Preview = pair.Value;
                    else if (pair.Key == "Activity_Link_GetLink")
                        Activity_Link_GetLink = pair.Value;
                    else if (pair.Key == "ActivityPreview_Button_Forward")
                        ActivityPreview_Button_Forward = pair.Value;
                    else if (pair.Key == "Activity_GetLink_URL")
                        Activity_GetLink_URL = pair.Value;
                    else if (pair.Key == "Activity_Link_Resend")
                        Activity_Link_Resend = pair.Value;
                    else if (pair.Key == "Activity_ResendLink_OK")
                        Activity_ResendLink_OK = pair.Value;
                    else if (pair.Key == "Activity_ResendLink_Cancel")
                        Activity_ResendLink_Cancel = pair.Value;
                    else if (pair.Key == "Activity_Button_Close")
                        Activity_Button_Close = pair.Value;
                    else if (pair.Key == "Activity_Link_Clone")
                        Activity_Link_Clone = pair.Value;
                    else if (pair.Key == "Activity_Link_Status")
                        Activity_Link_Status = pair.Value;
                    else if (pair.Key == "Activity_StatusLink_Cancel")
                        Activity_StatusLink_Cancel = pair.Value;
                    else if (pair.Key == "Activity_Link_DownloadPDF")
                        Activity_Link_DownloadPDF = pair.Value;
                    else if (pair.Key == "Activity_DatePicker_ExpirationDate")
                        Activity_DatePicker_ExpirationDate = pair.Value;
                    else if (pair.Key == "Activity_Text_EventDate")
                        Activity_Text_EventDate = pair.Value;
                    else if (pair.Key == "Activity_Dropdown_ExpirationMonth")
                        Activity_Dropdown_ExpirationMonth = pair.Value;
                    else if (pair.Key == "Activity_Dropdown_ExpirationYear")
                        Activity_Dropdown_ExpirationYear = pair.Value;
                    else if (pair.Key == "Activity_Text_ExpirationDate")
                        Activity_Text_ExpirationDate = pair.Value;
                    else if (pair.Key == "Activity_Text_CreatedOnDate")
                        Activity_Text_CreatedOnDate = pair.Value;
                    else if (pair.Key == "Activity_Text_SendingStatus")
                        Activity_Text_SendingStatus = pair.Value;
                    else if (pair.Key == "Activity_Link_ReviewSend")
                        Activity_Link_ReviewSend = pair.Value;
                    else if (pair.Key == "Activity_Button_Send")
                        Activity_Button_Send = pair.Value;
                    else if (pair.Key == "Activity_Text_Search")
                        Activity_Text_Search = pair.Value;
                    else if (pair.Key == "Activity_Button_Search")
                        Activity_Button_Search = pair.Value;
                    else if (pair.Key == "Activity_Dropdown_CurrentlyViewing")
                        Activity_Dropdown_CurrentlyViewing = pair.Value;
                    else if (pair.Key == "Activity_Dropdown_Status")
                        Activity_Dropdown_Status = pair.Value;
                    else if (pair.Key == "Activity_Button_Save")
                        Activity_Button_Save = pair.Value;
                    else if (pair.Key == "Activity_Text_Comment")
                        Activity_Text_Comment = pair.Value;
                    else if (pair.Key == "Activity_Button_GetLinkClose")
                        Activity_Button_GetLinkClose = pair.Value;
                    else if (pair.Key == "Activity_Link_AdvanceSearch")
                        Activity_Link_AdvanceSearch = pair.Value;
                    else if (pair.Key == "Activity_Dropdown_AdvanceSearch")
                        Activity_Dropdown_AdvanceSearch = pair.Value;
                    else if (pair.Key == "Activity_Textbox_From")
                        Activity_Textbox_From = pair.Value;
                    else if (pair.Key == "Activity_Textbox_To")
                        Activity_Textbox_To = pair.Value;
                    else if (pair.Key == "Activity_Dropdown_In")
                        Activity_Dropdown_In = pair.Value;
                    else if (pair.Key == "Activity_Textbox_WiththeWords")
                        Activity_Textbox_WiththeWords = pair.Value;
                    else if (pair.Key == "Activity_Dropdown_With")
                        Activity_Dropdown_With = pair.Value;
                    else if (pair.Key == "ActivityAdvanceSearch_Button_Search")
                        ActivityAdvanceSearch_Button_Search = pair.Value;
                    else if (pair.Key == "Activity_Icon_eCard")
                        Activity_Icon_eCard = pair.Value;
                    else if (pair.Key == "Activity_Icon_eProposal")
                        Activity_Icon_eProposal = pair.Value;
                    else if (pair.Key == "Activity_Icon_ExpirationStartDate")
                        Activity_Icon_ExpirationStartDate = pair.Value;
                    else if (pair.Key == "Activity_Icon_ExpirationEndDate")
                        Activity_Icon_ExpirationEndDate = pair.Value;
                    else if (pair.Key == "Activity_Dropdown_ViewContracts")
                        Activity_Dropdown_ViewContracts = pair.Value;
                    else if (pair.Key == "Activity_Link_ClickHere")
                        Activity_Link_ClickHere = pair.Value;
                    else if (pair.Key == "Activity_Text_SignHere")
                        Activity_Text_SignHere = pair.Value;
                    else if (pair.Key == "Activity_Button_SubmitElectronically")
                        Activity_Button_SubmitElectronically = pair.Value;
                    else if (pair.Key == "Activity_Link_SignNow")
                        Activity_Link_SignNow = pair.Value;
                    else if (pair.Key == "Activity_Text_SignHere2")
                        Activity_Text_SignHere2 = pair.Value;
                    else if (pair.Key == "Activity_Preview_CustomSignature")
                        Activity_Preview_CustomSignature = pair.Value;
                    else if (pair.Key == "Activity_Preview_CustomSignatureImage")
                        Activity_Preview_CustomSignatureImage = pair.Value;
                    else if (pair.Key == "Activity_Search_Textbox")
                        Activity_Search_Textbox = pair.Value;
                    else if (pair.Key == "Activity_Search_Button")
                        Activity_Search_Button = pair.Value;

                #endregion[Activity]

                #region[Settings]

                if (nodeModule == Constants.Settings)
                    if (pair.Key == "Settings_Tab_PropertyInfo")
                        Settings_Tab_PropertyInfo = pair.Value;
                    else if (pair.Key == "Settings_Tab_General")
                        Settings_Tab_General = pair.Value;
                    else if (pair.Key == "Settings_Tab_SeniorStaffInfo")
                        Settings_Tab_SeniorStaffInfo = pair.Value;
                    else if (pair.Key == "Settings_Tab_StoredContent")
                        Settings_Tab_StoredContent = pair.Value;
                    else if (pair.Key == "Settings_Tab_RoomEventBlockComments")
                        Settings_Tab_RoomEventBlockComments = pair.Value;
                    else if (pair.Key == "Settings_Tab_SpecialOffers")
                        Settings_Tab_SpecialOffers = pair.Value;
                    else if (pair.Key == "Settings_Tab_CustomizePDF")
                        Settings_Tab_CustomizePDF = pair.Value;
                    else if (pair.Key == "Settings_Tab_SocialMedia")
                        Settings_Tab_SocialMedia = pair.Value;
                    else if (pair.Key == "Settings_SeniorStaffInfo_Dropdown_Module")
                        Settings_SeniorStaffInfo_Dropdown_Module = pair.Value;
                    else if (pair.Key == "Settings_CustomizePDF_Dropdown_Module")
                        Settings_CustomizePDF_Dropdown_Module = pair.Value;
                    else if (pair.Key == "Settings_SpecialOffer_Dropdown_Module")
                        Settings_SpecialOffer_Dropdown_Module = pair.Value;

                #endregion[Settings]

                #region[Settings_StoredContent]

                if (nodeModule == Constants.Settings_StoredContent)
                    if (pair.Key == "Settings_StoredContent_DropDown_SelectModule")
                        Settings_StoredContent_DropDown_SelectModule = pair.Value;
                    else if (pair.Key == "Settings_StoredContent_DropDown_SelectLanguage")
                        Settings_StoredContent_DropDown_SelectLanguage = pair.Value;
                    else if (pair.Key == "Settings_StoredContent_Link_eProposal")
                        Settings_StoredContent_Link_eProposal = pair.Value;
                    else if (pair.Key == "Settings_StoredContent_Link_eCard")
                        Settings_StoredContent_Link_eCard = pair.Value;
                    else if (pair.Key == "Settings_StoredContent_Button_AddNew")
                        Settings_StoredContent_Button_AddNew = pair.Value;
                    else if (pair.Key == "Settings_StoredContent_Link_FirstStoredContent_Edit")
                        Settings_StoredContent_Link_FirstStoredContent_Edit = pair.Value;
                    else if (pair.Key == "Settings_StoredContent_Link_FirstStoredContent_Delete")
                        Settings_StoredContent_Link_FirstStoredContent_Delete = pair.Value;

                #endregion[Settings_StoredContent]

                #region[Reports]

                if (nodeModule == Constants.Reports)
                    if (pair.Key == "Reports_Link_ToDate")
                        Reports_Link_ToDate = pair.Value;
                    else if (pair.Key == "Reports_Link_ByYear")
                        Reports_Link_ByYear = pair.Value;
                    else if (pair.Key == "Reports_Link_ByDateRange")
                        Reports_Link_ByDateRange = pair.Value;
                    else if (pair.Key == "Reports_Link_ByUser")
                        Reports_Link_ByUser = pair.Value;
                    else if (pair.Key == "Reports_Link_PerClient")
                        Reports_Link_PerClient = pair.Value;
                    else if (pair.Key == "Reports_Dropdown_SelectModule")
                        Reports_Dropdown_SelectModule = pair.Value;
                    else if (pair.Key == "Reports_Dropdown_ProposalStatus")
                        Reports_Dropdown_ProposalStatus = pair.Value;
                    else if (pair.Key == "Reports_Dropdown_UserStatus")
                        Reports_Dropdown_UserStatus = pair.Value;
                    else if (pair.Key == "Reports_Button_Submit")
                        Reports_Button_Submit = pair.Value;
                    else if (pair.Key == "Reports_Dropdown_Year")
                        Reports_Dropdown_Year = pair.Value;
                    else if (pair.Key == "Reports_DatePicker_StartDate")
                        Reports_DatePicker_StartDate = pair.Value;
                    else if (pair.Key == "Reports_DatePicker_EndDate")
                        Reports_DatePicker_EndDate = pair.Value;
                    else if (pair.Key == "Reports_Dropdown_DatepickerMonth")
                        Reports_Dropdown_DatepickerMonth = pair.Value;
                    else if (pair.Key == "Reports_Dropdown_DatepickerYear")
                        Reports_Dropdown_DatepickerYear = pair.Value;
                    else if (pair.Key == "Reports_Dropdown_Username")
                        Reports_Dropdown_Username = pair.Value;
                    else if (pair.Key == "Reports_RadioButton_Company")
                        Reports_RadioButton_Company = pair.Value;
                    else if (pair.Key == "Reports_RadioButton_Lastname")
                        Reports_RadioButton_Lastname = pair.Value;

                #endregion[Reports]

                #endregion[UI]

                #region[Admin]

                #region[AdminLogin]

                if (nodeModule == Constants.AdminLogin)
                    if (pair.Key == "AdminLogin_Text_UserName")
                        AdminLogin_Text_UserName = pair.Value;
                    else if (pair.Key == "AdminLogin_Text_Password")
                        AdminLogin_Text_Password = pair.Value;
                    else if (pair.Key == "AdminLogin_Button_LogIn")
                        AdminLogin_Button_LogIn = pair.Value;

                #endregion[AdminLogin]

                #region[AdminNavigation]

                if (nodeModule == Constants.AdminNavigation)
                    if (pair.Key == "AdminNavigation_Button_Home")
                        AdminNavigation_Button_Home = pair.Value;
                    else if (pair.Key == "AdminNavigation_Button_Properties")
                        AdminNavigation_Button_Properties = pair.Value;
                    else if (pair.Key == "AdminNavigation_Button_eProposal")
                        AdminNavigation_Button_eProposal = pair.Value;
                    else if (pair.Key == "AdminNavigation_Button_eCard")
                        AdminNavigation_Button_eCard = pair.Value;
                    else if (pair.Key == "AdminNavigation_Button_Users")
                        AdminNavigation_Button_Users = pair.Value;
                    else if (pair.Key == "AdminNavigation_Button_Clients")
                        AdminNavigation_Button_Clients = pair.Value;
                    else if (pair.Key == "AdminNavigation_Button_Brand")
                        AdminNavigation_Button_Brand = pair.Value;
                    else if (pair.Key == "AdminNavigation_Button_Global")
                        AdminNavigation_Button_Global = pair.Value;
                    else if (pair.Key == "AdminNavigation_Dropdown_Property")
                        AdminNavigation_Dropdown_Property = pair.Value;
                    else if (pair.Key == "AdminNavigation_Text_PropertyDD")
                        AdminNavigation_Text_PropertyDD = pair.Value;
                    else if (pair.Key == "AdminNavigation_Link_Search")
                        AdminNavigation_Link_Search = pair.Value;
                    else if (pair.Key == "AdminNavigation_Link_ClearSearch")
                        AdminNavigation_Link_ClearSearch = pair.Value;
                    else if (pair.Key == "AdminNavigation_Tab_Search_Regular")
                        AdminNavigation_Tab_Search_Regular = pair.Value;
                    else if (pair.Key == "AdminNavigation_Tab_Search_SSO")
                        AdminNavigation_Tab_Search_SSO = pair.Value;
                    else if (pair.Key == "AdminNavigation_Tab_Search_CVB")
                        AdminNavigation_Tab_Search_CVB = pair.Value;
                    else if (pair.Key == "AdminNavigation_Tab_Search_Master")
                        AdminNavigation_Tab_Search_Master = pair.Value;
                    else if (pair.Key == "AdminNavigation_Tab_Search_Cluster")
                        AdminNavigation_Tab_Search_Cluster = pair.Value;
                    else if (pair.Key == "AdminNavigation_Tab_Search_GSO")
                        AdminNavigation_Tab_Search_GSO = pair.Value;
                    else if (pair.Key == "AdminNavigation_Tab_Search_Convert")
                        AdminNavigation_Tab_Search_Convert = pair.Value;
                    else if (pair.Key == "AdminNavigation_Tab_Search_Upgrade")
                        AdminNavigation_Tab_Search_Upgrade = pair.Value;
                    else if (pair.Key == "AdminNavigation_Text_Search_ID")
                        AdminNavigation_Text_Search_ID = pair.Value;
                    else if (pair.Key == "AdminNavigation_RadioButton_Search_ExternalLinkID")
                        AdminNavigation_RadioButton_Search_ExternalLinkID = pair.Value;
                    else if (pair.Key == "AdminNavigation_DropDown_Search_Brand")
                        AdminNavigation_DropDown_Search_Brand = pair.Value;
                    else if (pair.Key == "AdminNavigation_Text_Search_BrandDD")
                        AdminNavigation_Text_Search_BrandDD = pair.Value;
                    else if (pair.Key == "AdminNavigation_Text_Name")
                        AdminNavigation_Text_Name = pair.Value;
                    else if (pair.Key == "AdminNavigation_Button_Search_Search")
                        AdminNavigation_Button_Search_Search = pair.Value;
                    else if (pair.Key == "AdminNavigation_Button_Search_ClearSearch")
                        AdminNavigation_Button_Search_ClearSearch = pair.Value;
                    else if (pair.Key == "AdminNavigation_Button_Search_Close")
                        AdminNavigation_Button_Search_Close = pair.Value;

                #endregion[AdminNavigation]

                #region[AdminClients]

                if (nodeModule == Constants.AdminClients)
                    if (pair.Key == "AdminClients_Link_ShowAll")
                        AdminClients_Link_ShowAll = pair.Value;
                    else if (pair.Key == "AdminClients_Link_AddNew")
                        AdminClients_Link_AddNew = pair.Value;
                    else if (pair.Key == "AdminClients_Link_Search")
                        AdminClients_Link_Search = pair.Value;
                    else if (pair.Key == "AdminClients_Button_Top_FirstPage")
                        AdminClients_Button_Top_FirstPage = pair.Value;
                    else if (pair.Key == "AdminClients_Button_Top_PreviousPage")
                        AdminClients_Button_Top_PreviousPage = pair.Value;
                    else if (pair.Key == "AdminClients_Button_Top_NextPage")
                        AdminClients_Button_Top_NextPage = pair.Value;
                    else if (pair.Key == "AdminClients_Button_Top_LastPage")
                        AdminClients_Button_Top_LastPage = pair.Value;
                    else if (pair.Key == "AdminClients_DropDown_Top_GoToPage")
                        AdminClients_DropDown_Top_GoToPage = pair.Value;
                    else if (pair.Key == "AdminClients_Button_Bottom_FirstPage")
                        AdminClients_Button_Bottom_FirstPage = pair.Value;
                    else if (pair.Key == "AdminClients_Button_Bottom_PreviousPage")
                        AdminClients_Button_Bottom_PreviousPage = pair.Value;
                    else if (pair.Key == "AdminClients_Button_Bottom_NextPage")
                        AdminClients_Button_Bottom_NextPage = pair.Value;
                    else if (pair.Key == "AdminClients_Button_Bottom_LastPage")
                        AdminClients_Button_Bottom_LastPage = pair.Value;
                    else if (pair.Key == "AdminClients_DropDown_Bottom_GoToPage")
                        AdminClients_DropDown_Bottom_GoToPage = pair.Value;

                #endregion[AdminClients]

                #region[AdmineCard]

                if (nodeModule == Constants.AdmineCard)
                    if (pair.Key == "AdmineCard_Link_FooterLinks")
                        AdmineCard_Link_FooterLinks = pair.Value;
                    else if (pair.Key == "AdmineCard_Link_AddMediaLink")
                        AdmineCard_Link_AddMediaLink = pair.Value;
                    else if (pair.Key == "AdmineCard_Input_LinkName")
                        AdmineCard_Input_LinkName = pair.Value;
                    else if (pair.Key == "AdmineCard_Button_Save")
                        AdmineCard_Button_Save = pair.Value;
                    else if (pair.Key == "AdmineCard_Button_UploadMediaFiles")
                        AdmineCard_Button_UploadMediaFiles = pair.Value;
                    else if (pair.Key == "AdmineCard_Button_Browse")
                        AdmineCard_Button_Browse = pair.Value;
                    else if (pair.Key == "AdmineCard_Button_UploadButton")
                        AdmineCard_Button_UploadButton = pair.Value;
                    else if (pair.Key == "AdmineCard_Button_CancelButton")
                        AdmineCard_Button_CancelButton = pair.Value;
                    else if (pair.Key == "AdmineCard_Link_GeneratedLinks")
                        AdmineCard_Link_GeneratedLinks = pair.Value;
                    else if (pair.Key == "AdmineCard_Text_SkinName")
                        AdmineCard_Text_SkinName = pair.Value;
                    else if (pair.Key == "AdmineCard_Button_ChooseFile")
                        AdmineCard_Button_ChooseFile = pair.Value;
                    else if (pair.Key == "AdmineCard_Image_Preview")
                        AdmineCard_Image_Preview = pair.Value;
                    else if (pair.Key == "AdmineCard_Button_Addnew")
                        AdmineCard_Button_Addnew = pair.Value;
                    else if (pair.Key == "AdmineCard_Button_UploadImage")
                        AdmineCard_Button_UploadImage = pair.Value;
                    else if (pair.Key == "AdmineCard_Button_UploadLogo")
                        AdmineCard_Button_UploadLogo = pair.Value;
                    else if (pair.Key == "AdmineCard_Button_PopUpUpload")
                        AdmineCard_Button_PopUpUpload = pair.Value;
                    else if (pair.Key == "AdmineCard_Iframe_Upload")
                        AdmineCard_Iframe_Upload = pair.Value;

                #endregion[AdmineCards]

                #region[AdminUsers]

                if (nodeModule == Constants.AdminUsers)
                    if (pair.Key == "AdminUsers_Link_Search")
                        AdminUsers_Link_Search = pair.Value;
                    else if (pair.Key == "AdminUsers_Dropdown_Option1")
                        AdminUsers_Dropdown_Option1 = pair.Value;
                    else if (pair.Key == "AdminUsers_Dropdown_Option2")
                        AdminUsers_Dropdown_Option2 = pair.Value;
                    else if (pair.Key == "AdminUsers_Button_Search")
                        AdminUsers_Button_Search = pair.Value;
                    else if (pair.Key == "AdminUsers_Input_Searchbox")
                        AdminUsers_Input_Searchbox = pair.Value;
                    else if (pair.Key == "AdminUsers_Text_Search")
                        AdminUsers_Text_Search = pair.Value;
                    else if (pair.Key == "AdminUsers_Link_LogIn")
                        AdminUsers_Link_LogIn = pair.Value;
                    else if (pair.Key == "AdminUsers_Link_Edit")
                        AdminUsers_Link_Edit = pair.Value;
                    else if (pair.Key == "AdminUsers_EmployeeUpdate_CustomSignatureImage")
                        AdminUsers_EmployeeUpdate_CustomSignatureImage = pair.Value;
                    else if (pair.Key == "AdminUsers_Button_ChooseFile")
                        AdminUsers_Button_ChooseFile = pair.Value;
                    else if (pair.Key == "AdminUsers_Button_Update")
                        AdminUsers_Button_Update = pair.Value;
                    else if (pair.Key == "AdminUsers_Link_EditFirstUser")
                        AdminUsers_Link_EditFirstUser = pair.Value;
                    else if (pair.Key == "AdminUsers_Link_Remove")
                        AdminUsers_Link_Remove = pair.Value;
                    else if (pair.Key == "AdminUsers_Link_LoginShowAll")
                        AdminUsers_Link_LoginShowAll = pair.Value;
                    else if (pair.Key == "AdminUsers_View_CustomSignatureValidator")
                        AdminUsers_View_CustomSignatureValidator = pair.Value;
                    else if (pair.Key == "AdminUsers_Button_No")
                        AdminUsers_Button_No = pair.Value;
                    else if (pair.Key == "AdminUsers_Link_AddNewUser")
                        AdminUsers_Link_AddNewUser = pair.Value;
                    else if (pair.Key == "AdminUsers_Text_Firstname")
                        AdminUsers_Text_Firstname = pair.Value;
                    else if (pair.Key == "AdminUsers_Text_Lastname")
                        AdminUsers_Text_Lastname = pair.Value;
                    else if (pair.Key == "AdminUsers_Text_Email")
                        AdminUsers_Text_Email = pair.Value;
                    else if (pair.Key == "AdminUsers_Text_Password")
                        AdminUsers_Text_Password = pair.Value;
                    else if (pair.Key == "AdminUsers_Link_UserRole")
                        AdminUsers_Link_UserRole = pair.Value;
                    else if (pair.Key == "AdminUsers_Dropdown_SelectLevel")
                        AdminUsers_Dropdown_SelectLevel = pair.Value;
                    else if (pair.Key == "AdminUsers_Text_PropertyName")
                        AdminUsers_Text_PropertyName = pair.Value;
                    else if (pair.Key == "AdminUsers_Button_SearchProperty")
                        AdminUsers_Button_SearchProperty = pair.Value;
                    else if (pair.Key == "AdminUsers_Checkbox_Property")
                        AdminUsers_Checkbox_Property = pair.Value;
                    else if (pair.Key == "AdminUsers_Arrow_AddToRight")
                        AdminUsers_Arrow_AddToRight = pair.Value;
                    else if (pair.Key == "AdminUsers_Button_Submit")
                        AdminUsers_Button_Submit = pair.Value;
                    else if (pair.Key == "AdminUsers_Button_Save")
                        AdminUsers_Button_Save = pair.Value;
                    else if (pair.Key == "AdminUsers_Button_Yes")
                        AdminUsers_Button_Yes = pair.Value;
                    else if (pair.Key == "AdminUsers_View_ShowAll_Signature")
                        AdminUsers_View_ShowAll_Signature = pair.Value;
                    else if (pair.Key == "AdminUsers_RadioButton_AccessSetting")
                        AdminUsers_RadioButton_AccessSetting = pair.Value;

                #endregion

                #region[AdminClients_Search]

                if (nodeModule == Constants.AdminClients_Search)
                    if (pair.Key == "AdminClients_Search_Tab_Global")
                        AdminClients_Search_Tab_Global = pair.Value;
                    else if (pair.Key == "AdminClients_Search_Tab_Property")
                        AdminClients_Search_Tab_Property = pair.Value;
                    else if (pair.Key == "AdminClients_Search_DropDown_SearchByName")
                        AdminClients_Search_DropDown_SearchByName = pair.Value;
                    else if (pair.Key == "AdminClients_Search_DropDown_SearchByWith")
                        AdminClients_Search_DropDown_SearchByWith = pair.Value;
                    else if (pair.Key == "AdminClients_Search_Text_Search")
                        AdminClients_Search_Text_Search = pair.Value;
                    else if (pair.Key == "AdminClients_Search_Button_Search")
                        AdminClients_Search_Button_Search = pair.Value;
                    else if (pair.Key == "AdminClients_Search_Tab_Chain")
                        AdminClients_Search_Tab_Chain = pair.Value;
                    else if (pair.Key == "AdminClients_Search_Tab_ChainBrand")
                        AdminClients_Search_Tab_ChainBrand = pair.Value;
                    else if (pair.Key == "AdminClients_Search_Tab_Independent")
                        AdminClients_Search_Tab_Independent = pair.Value;
                    else if (pair.Key == "AdminClients_Search_Button_Top_FirstPage")
                        AdminClients_Search_Button_Top_FirstPage = pair.Value;
                    else if (pair.Key == "AdminClients_Search_Button_Top_PreviousPage")
                        AdminClients_Search_Button_Top_PreviousPage = pair.Value;
                    else if (pair.Key == "AdminClients_Search_Button_Top_NextPage")
                        AdminClients_Search_Button_Top_NextPage = pair.Value;
                    else if (pair.Key == "AdminClients_Search_Button_Top_LastPage")
                        AdminClients_Search_Button_Top_LastPage = pair.Value;
                    else if (pair.Key == "AdminClients_Search_DropDown_Top_GoToPage")
                        AdminClients_Search_DropDown_Top_GoToPage = pair.Value;
                    else if (pair.Key == "AdminClients_Search_Button_Bottom_FirstPage")
                        AdminClients_Search_Button_Bottom_FirstPage = pair.Value;
                    else if (pair.Key == "AdminClients_Search_Button_Bottom_PreviousPage")
                        AdminClients_Search_Button_Bottom_PreviousPage = pair.Value;
                    else if (pair.Key == "AdminClients_Search_Button_Bottom_NextPage")
                        AdminClients_Search_Button_Bottom_NextPage = pair.Value;
                    else if (pair.Key == "AdminClients_Search_Button_Bottom_LastPage")
                        AdminClients_Search_Button_Bottom_LastPage = pair.Value;
                    else if (pair.Key == "AdminClients_Search_DropDown_Bottom_GoToPage")
                        AdminClients_Search_DropDown_Bottom_GoToPage = pair.Value;
                    else if (pair.Key == "AdminClients_Search_Button_FirstClient_Edit")
                        AdminClients_Search_Button_FirstClient_Edit = pair.Value;

                #endregion[AdminClients_Search]

                #region[AdminProperties]

                if (nodeModule == Constants.AdminProperties)
                    if (pair.Key == "AdminProperties_PropertyDropDown_Button")
                        AdminProperties_PropertyDropDown_Button = pair.Value;
                    else if (pair.Key == "AdminProperties_PropertyDropDown_Text")
                        AdminProperties_PropertyDropDown_Text = pair.Value;
                    else if (pair.Key == "AdminProperties_Button_Features")
                        AdminProperties_Button_Features = pair.Value;
                    else if (pair.Key == "AdminProperties_Button_Update")
                        AdminProperties_Button_Update = pair.Value;
                    else if (pair.Key == "AdminProperties_Tab_RoomBlock")
                        AdminProperties_Tab_RoomBlock = pair.Value;
                    else if (pair.Key == "AdminProperties_Tab_Actions")
                        AdminProperties_Tab_Actions = pair.Value;

                #endregion[AdminClients_Search]

                #region[AdminProperties_UpdateProperty_Features]

                if (nodeModule == Constants.AdminProperties_UpdateProperty_Features)
                    if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_eCard_On")
                        AdminProperties_UpdateProperty_Features_RadioButton_eCard_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_eCard_Off")
                        AdminProperties_UpdateProperty_Features_RadioButton_eCard_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_eCard_Step1Link_On")
                        AdminProperties_UpdateProperty_Features_RadioButton_eCard_Step1Link_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_eCard_Step1Link_Off")
                        AdminProperties_UpdateProperty_Features_RadioButton_eCard_Step1Link_Off = pair.Value;
                    else if (pair.Key ==
                             "AdminProperties_UpdateProperty_Features_RadioButton_eCard_Default_AckOffwledgement")
                        AdminProperties_UpdateProperty_Features_RadioButton_eCard_Default_AckOffwledgement = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_eCard_Default_TurnDown")
                        AdminProperties_UpdateProperty_Features_RadioButton_eCard_Default_TurnDown = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_eProposal_On")
                        AdminProperties_UpdateProperty_Features_RadioButton_eProposal_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_eProposal_Off")
                        AdminProperties_UpdateProperty_Features_RadioButton_eProposal_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_eMenus_On")
                        AdminProperties_UpdateProperty_Features_RadioButton_eMenus_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_eMenus_Off")
                        AdminProperties_UpdateProperty_Features_RadioButton_eMenus_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_Referral_On")
                        AdminProperties_UpdateProperty_Features_RadioButton_Referral_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_Referral_Off")
                        AdminProperties_UpdateProperty_Features_RadioButton_Referral_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_DropDown_PropertyRoll")
                        AdminProperties_UpdateProperty_Features_DropDown_PropertyRoll = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_eFaceTime_On")
                        AdminProperties_UpdateProperty_Features_RadioButton_eFaceTime_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_eFaceTime_Off")
                        AdminProperties_UpdateProperty_Features_RadioButton_eFaceTime_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_eFaceTime_Trial_On")
                        AdminProperties_UpdateProperty_Features_RadioButton_eFaceTime_Trial_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_eFaceTime_Trial_Off")
                        AdminProperties_UpdateProperty_Features_RadioButton_eFaceTime_Trial_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_SocialMedia_On")
                        AdminProperties_UpdateProperty_Features_RadioButton_SocialMedia_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_SocialMedia_Off")
                        AdminProperties_UpdateProperty_Features_RadioButton_SocialMedia_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_SocialMediaText_On")
                        AdminProperties_UpdateProperty_Features_RadioButton_SocialMediaText_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_SocialMediaText_Off")
                        AdminProperties_UpdateProperty_Features_RadioButton_SocialMediaText_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_VideoOnWelcomeMessage_On")
                        AdminProperties_UpdateProperty_Features_RadioButton_VideoOnWelcomeMessage_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_VideoOnWelcomeMessage_Off"
                    )
                        AdminProperties_UpdateProperty_Features_RadioButton_VideoOnWelcomeMessage_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_DateFormat_MMDDYYYY")
                        AdminProperties_UpdateProperty_Features_RadioButton_DateFormat_MMDDYYYY = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_DateFormat_DDMMYYYY")
                        AdminProperties_UpdateProperty_Features_RadioButton_DateFormat_DDMMYYYY = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_DateFormat_YYYYMMDD")
                        AdminProperties_UpdateProperty_Features_RadioButton_DateFormat_YYYYMMDD = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_IncludeDaylightSavings_On"
                    )
                        AdminProperties_UpdateProperty_Features_RadioButton_IncludeDaylightSavings_On = pair.Value;
                    else if (pair.Key ==
                             "AdminProperties_UpdateProperty_Features_RadioButton_IncludeDaylightSavings_Off")
                        AdminProperties_UpdateProperty_Features_RadioButton_IncludeDaylightSavings_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_MilitaryTime_On")
                        AdminProperties_UpdateProperty_Features_RadioButton_MilitaryTime_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_MilitaryTime_Off")
                        AdminProperties_UpdateProperty_Features_RadioButton_MilitaryTime_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_HasDateSelection_On")
                        AdminProperties_UpdateProperty_Features_RadioButton_HasDateSelection_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_HasDateSelection_Off")
                        AdminProperties_UpdateProperty_Features_RadioButton_HasDateSelection_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_Attachment_On")
                        AdminProperties_UpdateProperty_Features_RadioButton_Attachment_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_Attachment_Off")
                        AdminProperties_UpdateProperty_Features_RadioButton_Attachment_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_DropDown_UploadNumber")
                        AdminProperties_UpdateProperty_Features_DropDown_UploadNumber = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_HasSpecialOffer_On")
                        AdminProperties_UpdateProperty_Features_RadioButton_HasSpecialOffer_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_HasSpecialOffer_Off")
                        AdminProperties_UpdateProperty_Features_RadioButton_HasSpecialOffer_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_ClientLogo_On")
                        AdminProperties_UpdateProperty_Features_RadioButton_ClientLogo_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_ClientLogo_Off")
                        AdminProperties_UpdateProperty_Features_RadioButton_ClientLogo_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_BypassClientHomePage_On")
                        AdminProperties_UpdateProperty_Features_RadioButton_BypassClientHomePage_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_BypassClientHomePage_Off")
                        AdminProperties_UpdateProperty_Features_RadioButton_BypassClientHomePage_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_BCCGlobalSales_On")
                        AdminProperties_UpdateProperty_Features_RadioButton_BCCGlobalSales_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_BCCGlobalSales_Off")
                        AdminProperties_UpdateProperty_Features_RadioButton_BCCGlobalSales_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_DefaultComposerBCC_On")
                        AdminProperties_UpdateProperty_Features_RadioButton_DefaultComposerBCC_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_DefaultComposerBCC_Off")
                        AdminProperties_UpdateProperty_Features_RadioButton_DefaultComposerBCC_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_PDFSetting_On")
                        AdminProperties_UpdateProperty_Features_RadioButton_PDFSetting_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_PDFSetting_Off")
                        AdminProperties_UpdateProperty_Features_RadioButton_PDFSetting_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_CustomizePDF_On")
                        AdminProperties_UpdateProperty_Features_RadioButton_CustomizePDF_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_CustomizePDF_Off")
                        AdminProperties_UpdateProperty_Features_RadioButton_CustomizePDF_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_DocTypeSettings_On")
                        AdminProperties_UpdateProperty_Features_RadioButton_DocTypeSettings_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_DocTypeSettings_Off")
                        AdminProperties_UpdateProperty_Features_RadioButton_DocTypeSettings_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_eContract_On")
                        AdminProperties_UpdateProperty_Features_RadioButton_eContract_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_eContract_Off")
                        AdminProperties_UpdateProperty_Features_RadioButton_eContract_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_HeaderImages_On")
                        AdminProperties_UpdateProperty_Features_RadioButton_HeaderImages_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_HeaderImages_Off")
                        AdminProperties_UpdateProperty_Features_RadioButton_HeaderImages_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_eProposalDraftRemoval_On")
                        AdminProperties_UpdateProperty_Features_RadioButton_eProposalDraftRemoval_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_eProposalDraftRemoval_Off"
                    )
                        AdminProperties_UpdateProperty_Features_RadioButton_eProposalDraftRemoval_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_eProposalFavorite_On")
                        AdminProperties_UpdateProperty_Features_RadioButton_eProposalFavorite_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_RadioButton_eProposalFavorite_Off")
                        AdminProperties_UpdateProperty_Features_RadioButton_eProposalFavorite_Off = pair.Value;
                    else if (pair.Key ==
                             "AdminProperties_UpdateProperty_Features_RadioButton_eProposalBrochureIntegration_On")
                        AdminProperties_UpdateProperty_Features_RadioButton_eProposalBrochureIntegration_On =
                            pair.Value;
                    else if (pair.Key ==
                             "AdminProperties_UpdateProperty_Features_RadioButton_eProposalBrochureIntegration_Off")
                        AdminProperties_UpdateProperty_Features_RadioButton_eProposalBrochureIntegration_Off =
                            pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_TextBox_FileShareLevel")
                        AdminProperties_UpdateProperty_Features_TextBox_FileShareLevel = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Features_Button_Update")
                        AdminProperties_UpdateProperty_Features_Button_Update = pair.Value;

                #endregion[AdminProperties_UpdateProperty_Features]

                #region[AdminProperties_UpdateProperty_RoomBlock]

                if (nodeModule == Constants.AdminProperties_UpdateProperty_RoomBlock)
                    if (pair.Key == "AdminProperties_UpdateProperty_RoomBlock_RadioButton_RoomOnWelcome_On")
                        AdminProperties_UpdateProperty_RoomBlock_RadioButton_RoomOnWelcome_On = pair.Value;
                    else if (pair.Key ==
                             "AdminProperties_UpdateProperty_RoomBlock_RadioButton_RoomOnWelcome_DefaultChecked_On")
                        AdminProperties_UpdateProperty_RoomBlock_RadioButton_RoomOnWelcome_DefaultChecked_On =
                            pair.Value;
                    else if (pair.Key ==
                             "AdminProperties_UpdateProperty_RoomBlock_RadioButton_RoomOnWelcome_ReadOnly_On")
                        AdminProperties_UpdateProperty_RoomBlock_RadioButton_RoomOnWelcome_ReadOnly_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_RoomBlock_RadioButton_RoomOnWelcome_Off")
                        AdminProperties_UpdateProperty_RoomBlock_RadioButton_RoomOnWelcome_Off = pair.Value;
                    else if (pair.Key ==
                             "AdminProperties_UpdateProperty_RoomBlock_RadioButton_RoomOnWelcome_DefaultChecked_Off")
                        AdminProperties_UpdateProperty_RoomBlock_RadioButton_RoomOnWelcome_DefaultChecked_Off =
                            pair.Value;
                    else if (pair.Key ==
                             "AdminProperties_UpdateProperty_RoomBlock_RadioButton_RoomOnWelcome_ReadOnly_Off")
                        AdminProperties_UpdateProperty_RoomBlock_RadioButton_RoomOnWelcome_ReadOnly_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_RoomBlock_Button_Submit")
                        AdminProperties_UpdateProperty_RoomBlock_Button_Submit = pair.Value;

                #endregion[AdminProperties_UpdateProperty_RoomBlock]

                #region[AdminProperties_AddNewLanguage]

                if (nodeModule == Constants.AdminProperties_AddNewLanguage)
                    if (pair.Key == "AdminProperties_AddNewLanguage_DropDown_Language")
                        AdminProperties_AddNewLanguage_DropDown_Language = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_Text_PropertyName")
                        AdminProperties_AddNewLanguage_Text_PropertyName = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_Text_AlternativePropertyName")
                        AdminProperties_AddNewLanguage_Text_AlternativePropertyName = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_Text_Address")
                        AdminProperties_AddNewLanguage_Text_Address = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_Text_City")
                        AdminProperties_AddNewLanguage_Text_City = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_Text_State")
                        AdminProperties_AddNewLanguage_Text_State = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_Text_ZipCode")
                        AdminProperties_AddNewLanguage_Text_ZipCode = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_DropDown_Country")
                        AdminProperties_AddNewLanguage_DropDown_Country = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_Text_CountryDisplayName")
                        AdminProperties_AddNewLanguage_Text_CountryDisplayName = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_Text_MainPhone")
                        AdminProperties_AddNewLanguage_Text_MainPhone = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_Text_GroupSalesPhone")
                        AdminProperties_AddNewLanguage_Text_GroupSalesPhone = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_Text_Fax")
                        AdminProperties_AddNewLanguage_Text_Fax = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_Text_Email")
                        AdminProperties_AddNewLanguage_Text_Email = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_Text_WelcomeTag")
                        AdminProperties_AddNewLanguage_Text_WelcomeTag = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_Text_Website")
                        AdminProperties_AddNewLanguage_Text_Website = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_DropDown_Currency")
                        AdminProperties_AddNewLanguage_DropDown_Currency = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_Link_RoomBlockAddNew")
                        AdminProperties_AddNewLanguage_Link_RoomBlockAddNew = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_Text_RoomBlockColumnLabel1")
                        AdminProperties_AddNewLanguage_Text_RoomBlockColumnLabel1 = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_Text_RoomBlockColumnLabel2")
                        AdminProperties_AddNewLanguage_Text_RoomBlockColumnLabel2 = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_Text_RoomBlockColumnLabel3")
                        AdminProperties_AddNewLanguage_Text_RoomBlockColumnLabel3 = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_Text_RoomBlockColumnLabel4")
                        AdminProperties_AddNewLanguage_Text_RoomBlockColumnLabel4 = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_Text_RoomBlockColumnLabel5")
                        AdminProperties_AddNewLanguage_Text_RoomBlockColumnLabel5 = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_Link_RoomBlockColumnDelete1")
                        AdminProperties_AddNewLanguage_Link_RoomBlockColumnDelete1 = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_Link_RoomBlockColumnDelete2")
                        AdminProperties_AddNewLanguage_Link_RoomBlockColumnDelete2 = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_Link_RoomBlockColumnDelete3")
                        AdminProperties_AddNewLanguage_Link_RoomBlockColumnDelete3 = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_Link_RoomBlockColumnDelete4")
                        AdminProperties_AddNewLanguage_Link_RoomBlockColumnDelete4 = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_Link_RoomBlockColumnDelete5")
                        AdminProperties_AddNewLanguage_Link_RoomBlockColumnDelete5 = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_Text_EmailBody")
                        AdminProperties_AddNewLanguage_Text_EmailBody = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_Text_EmailBodyBCC")
                        AdminProperties_AddNewLanguage_Text_EmailBodyBCC = pair.Value;
                    else if (pair.Key == "AdminProperties_AddNewLanguage_Button_Save")
                        AdminProperties_AddNewLanguage_Button_Save = pair.Value;

                #endregion[AdminProperties_AddNewLanguage]

                #region[AdminProperties_UpdateProperty_Actions]

                if (nodeModule == Constants.AdminProperties_UpdateProperty_Actions)
                    if (pair.Key == "AdminProperties_UpdateProperty_Actions_RadioButton_MergeProperty_On")
                        AdminProperties_UpdateProperty_Actions_RadioButton_MergeProperty_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Actions_RadioButton_MergeProperty_Off")
                        AdminProperties_UpdateProperty_Actions_RadioButton_MergeProperty_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Actions_RadioButton_DisableProperty_On")
                        AdminProperties_UpdateProperty_Actions_RadioButton_DisableProperty_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Actions_RadioButton_DisableProperty_Off")
                        AdminProperties_UpdateProperty_Actions_RadioButton_DisableProperty_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Actions_RadioButton_MultiLanguageProperty_On")
                        AdminProperties_UpdateProperty_Actions_RadioButton_MultiLanguageProperty_On = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Actions_RadioButton_MultiLanguageProperty_Off")
                        AdminProperties_UpdateProperty_Actions_RadioButton_MultiLanguageProperty_Off = pair.Value;
                    else if (pair.Key == "AdminProperties_UpdateProperty_Actions_Button_Update")
                        AdminProperties_UpdateProperty_Actions_Button_Update = pair.Value;

                #endregion[AdminProperties_UpdateProperty_Actions]

                #region[AdminEProposal]

                if (nodeModule == Constants.AdminEProposal)
                    if (pair.Key == "AdminEProposal_Link_SetupModuleSettings")
                        AdminEProposal_Link_SetupModuleSettings = pair.Value;
                    else if (pair.Key == "AdminEProposal_Link_SetupTemplates")
                        AdminEProposal_Link_SetupTemplates = pair.Value;
                    else if (pair.Key == "AdminEProposal_Link_NavigationAndContent")
                        AdminEProposal_Link_NavigationAndContent = pair.Value;
                    else if (pair.Key == "AdminEProposal_Link_Paragraphs")
                        AdminEProposal_Link_Paragraphs = pair.Value;
                    else if (pair.Key == "AdminEProposal_Link_RoomEventBlockParagraph")
                        AdminEProposal_Link_RoomEventBlockParagraph = pair.Value;
                    else if (pair.Key == "AdminEProposal_Link_PropertyGMLetter")
                        AdminEProposal_Link_PropertyGMLetter = pair.Value;
                    else if (pair.Key == "AdminEProposal_Link_ImageCaptionStyles")
                        AdminEProposal_Link_ImageCaptionStyles = pair.Value;
                    else if (pair.Key == "AdminEProposal_Link_MediaSetup")
                        AdminEProposal_Link_MediaSetup = pair.Value;
                    else if (pair.Key == "AdminEProposal_Link_HeaderGallery")
                        AdminEProposal_Link_HeaderGallery = pair.Value;

                #endregion[AdminEProposal]

                #region[AdminEProposal_SetupModuleSettings]

                if (nodeModule == Constants.AdminEProposal_SetupModuleSettings)
                    if (pair.Key == "AdminEProposal_SetupModuleSettings_Text_SubDomain_Module1")
                        AdminEProposal_SetupModuleSettings_Text_SubDomain_Module1 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Text_SubDomain_Module2")
                        AdminEProposal_SetupModuleSettings_Text_SubDomain_Module2 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Text_SubDomain_Module3")
                        AdminEProposal_SetupModuleSettings_Text_SubDomain_Module3 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Text_SubDomain_Module4")
                        AdminEProposal_SetupModuleSettings_Text_SubDomain_Module4 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Text_SubDomain_Module5")
                        AdminEProposal_SetupModuleSettings_Text_SubDomain_Module5 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_DropDown_ParentDomain_Module1")
                        AdminEProposal_SetupModuleSettings_DropDown_ParentDomain_Module1 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_DropDown_ParentDomain_Module2")
                        AdminEProposal_SetupModuleSettings_DropDown_ParentDomain_Module2 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_DropDown_ParentDomain_Module3")
                        AdminEProposal_SetupModuleSettings_DropDown_ParentDomain_Module3 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_DropDown_ParentDomain_Module4")
                        AdminEProposal_SetupModuleSettings_DropDown_ParentDomain_Module4 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_DropDown_ParentDomain_Module5")
                        AdminEProposal_SetupModuleSettings_DropDown_ParentDomain_Module5 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Button_SetupProposalPreview_Update")
                        AdminEProposal_SetupModuleSettings_Button_SetupProposalPreview_Update = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_InsertNewModuleSetting")
                        AdminEProposal_SetupModuleSettings_Link_InsertNewModuleSetting = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_DropDown_Module")
                        AdminEProposal_SetupModuleSettings_DropDown_Module = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_DropDown_Market")
                        AdminEProposal_SetupModuleSettings_DropDown_Market = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_DropDown_Theme")
                        AdminEProposal_SetupModuleSettings_DropDown_Theme = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_DropDown_Content")
                        AdminEProposal_SetupModuleSettings_DropDown_Content = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_DropDown_Link")
                        AdminEProposal_SetupModuleSettings_DropDown_Link = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Button_Search")
                        AdminEProposal_SetupModuleSettings_Button_Search = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Button_UpdateActive")
                        AdminEProposal_SetupModuleSettings_Button_UpdateActive = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Button_Delete_Module1")
                        AdminEProposal_SetupModuleSettings_Button_Delete_Module1 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Button_Delete_Module2")
                        AdminEProposal_SetupModuleSettings_Button_Delete_Module2 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Button_Delete_Module3")
                        AdminEProposal_SetupModuleSettings_Button_Delete_Module3 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Button_Delete_Module4")
                        AdminEProposal_SetupModuleSettings_Button_Delete_Module4 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Button_Delete_Module5")
                        AdminEProposal_SetupModuleSettings_Button_Delete_Module5 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Button_Delete_OK")
                        AdminEProposal_SetupModuleSettings_Button_Delete_OK = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Button_Delete_Cancel")
                        AdminEProposal_SetupModuleSettings_Button_Delete_Cancel = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Active_Module1")
                        AdminEProposal_SetupModuleSettings_CheckBox_Active_Module1 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Active_Module2")
                        AdminEProposal_SetupModuleSettings_CheckBox_Active_Module2 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Active_Module3")
                        AdminEProposal_SetupModuleSettings_CheckBox_Active_Module3 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Active_Module4")
                        AdminEProposal_SetupModuleSettings_CheckBox_Active_Module4 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Active_Module5")
                        AdminEProposal_SetupModuleSettings_CheckBox_Active_Module5 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Button_DisplayNameEdit_Module1")
                        AdminEProposal_SetupModuleSettings_Button_DisplayNameEdit_Module1 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Button_DisplayNameEdit_Module2")
                        AdminEProposal_SetupModuleSettings_Button_DisplayNameEdit_Module2 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Button_DisplayNameEdit_Module3")
                        AdminEProposal_SetupModuleSettings_Button_DisplayNameEdit_Module3 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Button_DisplayNameEdit_Module4")
                        AdminEProposal_SetupModuleSettings_Button_DisplayNameEdit_Module4 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Button_DisplayNameEdit_Module5")
                        AdminEProposal_SetupModuleSettings_Button_DisplayNameEdit_Module5 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Button_DisplayName_Save")
                        AdminEProposal_SetupModuleSettings_Button_DisplayName_Save = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Button_DisplayName_Cancel")
                        AdminEProposal_SetupModuleSettings_Button_DisplayName_Cancel = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_Preview_Module1")
                        AdminEProposal_SetupModuleSettings_Link_Preview_Module1 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_Preview_Module2")
                        AdminEProposal_SetupModuleSettings_Link_Preview_Module2 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_Preview_Module3")
                        AdminEProposal_SetupModuleSettings_Link_Preview_Module3 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_Preview_Module4")
                        AdminEProposal_SetupModuleSettings_Link_Preview_Module4 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_Preview_Module5")
                        AdminEProposal_SetupModuleSettings_Link_Preview_Module5 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Button_Javascript_Delete_Yes")
                        AdminEProposal_SetupModuleSettings_Button_Javascript_Delete_Yes = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Button_Javascript_Delete_Cancel")
                        AdminEProposal_SetupModuleSettings_Button_Javascript_Delete_Cancel = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_StyleSheet_Brand_Module1")
                        AdminEProposal_SetupModuleSettings_Link_StyleSheet_Brand_Module1 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_StyleSheet_Property_Module1")
                        AdminEProposal_SetupModuleSettings_Link_StyleSheet_Property_Module1 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_Javascript_Brand_Module1")
                        AdminEProposal_SetupModuleSettings_Link_Javascript_Brand_Module1 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_Javascript_Property_Module1")
                        AdminEProposal_SetupModuleSettings_Link_Javascript_Property_Module1 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_Javascript_Upload_Module1")
                        AdminEProposal_SetupModuleSettings_Link_Javascript_Upload_Module1 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_Javascript_Delete_Module1")
                        AdminEProposal_SetupModuleSettings_Link_Javascript_Delete_Module1 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Language1_Module1")
                        AdminEProposal_SetupModuleSettings_CheckBox_Language1_Module1 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Language2_Module1")
                        AdminEProposal_SetupModuleSettings_CheckBox_Language2_Module1 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Language3_Module1")
                        AdminEProposal_SetupModuleSettings_CheckBox_Language3_Module1 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Language4_Module1")
                        AdminEProposal_SetupModuleSettings_CheckBox_Language4_Module1 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Language5_Module1")
                        AdminEProposal_SetupModuleSettings_CheckBox_Language5_Module1 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_StyleSheet_Brand_Module2")
                        AdminEProposal_SetupModuleSettings_Link_StyleSheet_Brand_Module2 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_StyleSheet_Property_Module2")
                        AdminEProposal_SetupModuleSettings_Link_StyleSheet_Property_Module2 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_Javascript_Brand_Module2")
                        AdminEProposal_SetupModuleSettings_Link_Javascript_Brand_Module2 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_Javascript_Property_Module2")
                        AdminEProposal_SetupModuleSettings_Link_Javascript_Property_Module2 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_Javascript_Upload_Module2")
                        AdminEProposal_SetupModuleSettings_Link_Javascript_Upload_Module2 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_Javascript_Delete_Module2")
                        AdminEProposal_SetupModuleSettings_Link_Javascript_Delete_Module2 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Language1_Module2")
                        AdminEProposal_SetupModuleSettings_CheckBox_Language1_Module2 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Language2_Module2")
                        AdminEProposal_SetupModuleSettings_CheckBox_Language2_Module2 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Language3_Module2")
                        AdminEProposal_SetupModuleSettings_CheckBox_Language3_Module2 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Language4_Module2")
                        AdminEProposal_SetupModuleSettings_CheckBox_Language4_Module2 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Language5_Module2")
                        AdminEProposal_SetupModuleSettings_CheckBox_Language5_Module2 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_StyleSheet_Brand_Module3")
                        AdminEProposal_SetupModuleSettings_Link_StyleSheet_Brand_Module3 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_StyleSheet_Property_Module3")
                        AdminEProposal_SetupModuleSettings_Link_StyleSheet_Property_Module3 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_Javascript_Brand_Module3")
                        AdminEProposal_SetupModuleSettings_Link_Javascript_Brand_Module3 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_Javascript_Property_Module3")
                        AdminEProposal_SetupModuleSettings_Link_Javascript_Property_Module3 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_Javascript_Upload_Module3")
                        AdminEProposal_SetupModuleSettings_Link_Javascript_Upload_Module3 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_Javascript_Delete_Module3")
                        AdminEProposal_SetupModuleSettings_Link_Javascript_Delete_Module3 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Language1_Module3")
                        AdminEProposal_SetupModuleSettings_CheckBox_Language1_Module3 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Language2_Module3")
                        AdminEProposal_SetupModuleSettings_CheckBox_Language2_Module3 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Language3_Module3")
                        AdminEProposal_SetupModuleSettings_CheckBox_Language3_Module3 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Language4_Module3")
                        AdminEProposal_SetupModuleSettings_CheckBox_Language4_Module3 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Language5_Module3")
                        AdminEProposal_SetupModuleSettings_CheckBox_Language5_Module3 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_StyleSheet_Brand_Module4")
                        AdminEProposal_SetupModuleSettings_Link_StyleSheet_Brand_Module4 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_StyleSheet_Property_Module4")
                        AdminEProposal_SetupModuleSettings_Link_StyleSheet_Property_Module4 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_Javascript_Brand_Module4")
                        AdminEProposal_SetupModuleSettings_Link_Javascript_Brand_Module4 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_Javascript_Property_Module4")
                        AdminEProposal_SetupModuleSettings_Link_Javascript_Property_Module4 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_Javascript_Upload_Module4")
                        AdminEProposal_SetupModuleSettings_Link_Javascript_Upload_Module4 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_Javascript_Delete_Module4")
                        AdminEProposal_SetupModuleSettings_Link_Javascript_Delete_Module4 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Language1_Module4")
                        AdminEProposal_SetupModuleSettings_CheckBox_Language1_Module4 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Language2_Module4")
                        AdminEProposal_SetupModuleSettings_CheckBox_Language2_Module4 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Language3_Module4")
                        AdminEProposal_SetupModuleSettings_CheckBox_Language3_Module4 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Language4_Module4")
                        AdminEProposal_SetupModuleSettings_CheckBox_Language4_Module4 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Language5_Module4")
                        AdminEProposal_SetupModuleSettings_CheckBox_Language5_Module4 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_StyleSheet_Brand_Module5")
                        AdminEProposal_SetupModuleSettings_Link_StyleSheet_Brand_Module5 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_StyleSheet_Property_Module5")
                        AdminEProposal_SetupModuleSettings_Link_StyleSheet_Property_Module5 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_Javascript_Brand_Module5")
                        AdminEProposal_SetupModuleSettings_Link_Javascript_Brand_Module5 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_Javascript_Property_Module5")
                        AdminEProposal_SetupModuleSettings_Link_Javascript_Property_Module5 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_Javascript_Upload_Module5")
                        AdminEProposal_SetupModuleSettings_Link_Javascript_Upload_Module5 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Link_Javascript_Delete_Module5")
                        AdminEProposal_SetupModuleSettings_Link_Javascript_Delete_Module5 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Language1_Module5")
                        AdminEProposal_SetupModuleSettings_CheckBox_Language1_Module5 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Language2_Module5")
                        AdminEProposal_SetupModuleSettings_CheckBox_Language2_Module5 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Language3_Module5")
                        AdminEProposal_SetupModuleSettings_CheckBox_Language3_Module5 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Language4_Module5")
                        AdminEProposal_SetupModuleSettings_CheckBox_Language4_Module5 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_CheckBox_Language5_Module5")
                        AdminEProposal_SetupModuleSettings_CheckBox_Language5_Module5 = pair.Value;
                    else if (pair.Key == "AdminEProposal_SetupModuleSettings_Button_UpdatePropertyResources_Save")
                        AdminEProposal_SetupModuleSettings_Button_UpdatePropertyResources_Save = pair.Value;

                #endregion[AdminEProposal_SetupModuleSettings]

                #endregion[Admin]
            }
            return obj;
        }
    }
}
