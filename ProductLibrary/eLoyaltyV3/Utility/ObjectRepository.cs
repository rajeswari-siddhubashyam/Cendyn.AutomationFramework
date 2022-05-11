using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace eLoyaltyV3.Utility
{
    public class ObjectRepository
    {
        #region[Admin]
        public static string Admin_Text_UserName { get; set; }
        public static string Admin_Text_Password { get; set; }
        public static string Admin_Button_Login { get; set; }
        public static string Admin_Text_SearchEmail { get; set; }
        public static string Admin_Button_MemberSearch { get; set; }
        public static string Admin_Button_ClearSearch { get; set; }
        public static string Admin_Button_ViewMember { get; set; }
        public static string Admin_Text_ViewMember { get; set; }
        public static string Admin_Link_ActivationEmail { get; set; }
        public static string Admin_Link_WelcomeEmail { get; set; }
        public static string Admin_Button_Activation_Save { get; set; }
        public static string Admin_Button_Welcome_Save { get; set; }
        public static string Admin_Dropdown_MemberType { get; set; }
        public static string Admin_Textbox_MemberNumber { get; set; }
        public static string Admin_Textbox_Lastname { get; set; }
        public static string Admin_Textbox_Firstname { get; set; }
        public static string Admin_Textbox_First_Name { get; set; }
        public static string Admin_Textbox_Last_Name { get; set; }
        public static string Admin_Textbox_Email { get; set; }
        public static string Admin_Textbox_Street { get; set; }
        public static string Admin_Textbox_City { get; set; }
        public static string Admin_Textbox_Zip { get; set; }
        public static string Admin_Textbox_Phone { get; set; }
        public static string Admin_Dropdown_Country { get; set; }
        public static string Admin_Dropdown_State { get; set; }
        public static string Admin_Dropdown_State_2 { get; set; }
        public static string Admin_Dropdown_AwardName { get; set; }
        public static string Admin_Textbox_AwardNumber { get; set; }
        public static string Admin_Textbox_CardName { get; set; }
        public static string Admin_Textbox_Company { get; set; }
        public static string Admin_Dropdown_MemberStatus { get; set; }
        public static string Admin_Value_MemberType { get; set; }
        public static string Admin_Value_MemberNumber { get; set; }
        public static string Admin_Value_Email { get; set; }
        public static string Admin_Value_FullName { get; set; }
        public static string Admin_Value_Address { get; set; }
        public static string Admin_Value_Phone { get; set; }
        public static string Admin_Value_CardName { get; set; }
        public static string Admin_Value_MemberLevel { get; set; }
        public static string Admin_Value_Company { get; set; }
        public static string Admin_Value_Status { get; set; }
        public static string Admin_Textbox_Filter { get; set; }
        public static string Admin_Dropdown_Pagination { get; set; }
        public static string Admin_MemberInfo_MemberStays { get; set; }
        public static string Admin_MemberInfo_SearchMemberStays { get; set; }
        public static string Admin_Arrow_Next { get; set; }
        public static string Admin_Arrow_Previous { get; set; }
        public static string Admin_Menu_LoyaltyAwards { get; set; }
        public static string Admin_Button_Awards_Add { get; set; }
        public static string Admin_Text_Award_Name { get; set; }
        public static string Admin_Text_Award_Search { get; set; }
        public static string Admin_Text_Award_Code { get; set; }
        public static string Admin_Text_Award_StartDate { get; set; }
        public static string Admin_Text_Award_EndDate { get; set; }
        public static string Admin_DropDown_Awardtype { get; set; }
        public static string Admin_Text_DaysActive { get; set; }
        public static string Admin_Text_AdvanceDeliveryDays { get; set; }
        public static string Admin_DropDown_MinQualifiedStay { get; set; }
        public static string Admin_DropDown_MemberLevel { get; set; }
        public static string Admin_DropDown_EmailName { get; set; }
        public static string Admin_Award_Savebtn { get; set; }
        public static string Admin_Button_Close { get; set; }
        public static string Admin_DropDown_NightCycle { get; set; }
        public static string Admin_DropDown_NightAwarded { get; set; }
        public static string Admin_DropDown_NightExpMonth { get; set; }
        public static string Admin_DropDown_NightHotels { get; set; }
        public static string Enter_Text_MaxAwardperMember { get; set; }

        public static string Dropdown_Value_Country { get; set; }
        public static string DropDown_value_State { get; set; }
        public static string Admin_Attribute_state { get; set; }
        public static string Admin_MemberInformation_Send_Email_Popup_Close { get; set; }
        public static string ClickOnLogin { get; set; }
        public static string Admin_Users_Text_Password { get; set; }
        public static string Admin_ForgotPassword_LinkText { get; set; }
        public static string Admin_Recovery_Email { get; set; }
        public static string Admin_ForgotPassword_Recover { get; set; }
        public static string Admin_NewPassword { get; set; }
        public static string Admin_NewPasswordConfirm { get; set; }
        public static string SubmitNewPassword { get; set; }
        public static string Admin_MemberBatchUpload_Tab { get; set; }
        public static string Click_MemberBatchUpdate { get; set; }
        public static string BatchUpdate_DownloadTemplete { get; set; }
        public static string BatchUpload_DownloadTemplete { get; set; }
        public static string BatchUpdate_UploadTemplete { get; set; }
        public static string BatchUpdate_UpdateTemplete { get; set; }
        public static string BatchUpdate_UploadFile { get; set; }
        public static string BatchUpload_UploadFile { get; set; }
        public static string Refreshbutton { get; set; }
        public static string MemberUploadedDetails { get; set; }
        public static string BatchUpload_ClickonUpload { get; set; }
        public static string BatchUploadRegistraion_Upload { get; set; }
        public static string Click_CloseButton_OnMemberBatchUpdateDetailsPopup { get; set; }
        public static string BatchUpdate_UploadFiles { get; set; }    
       
        public static string UpdateRefreshbutton { get; set; }
        public static string MemberUpdateDetails { get; set; }
        public static string Click_MemberSearchTab { get; set; }
        public static string Text_MemberShipId { get; set; }
        public static string Admin_Value_MemberNumber_Almanac { get; set; }
        public static string Admin_MemberInformation_Tab { get; set; }
        public static string Admin_LoyaltyMapping_UploadLog_SubTab { get; set; }
        public static string LoyaltyeGift_RemainingBalance { get; set; }
        public static string Admin_MemberAward_Previous_button { get; set; }
        public static string Click_Member_Level_Email_No_Button { get; set; }

        public static string MemberLevel_CrossButton { get; set; }
        public static string MemberLevel_Email_Overlay { get; set; }
        public static string Admin_Update_View_Overlay_Close { get; set; }

        public static string Click_MembershipSetup_Tab { get; set; }
        public static string Click_MemberLevel_SubTab { get; set; }
        public static string MembershipSetup_AddMemershipLevel_Button { get; set; }
        public static string AddMemershipLevel_MembershipLevel { get; set; }
        public static string AddMemershipLevel_MembershipCode { get; set; }
        public static string AddMemershipLevel_LevelOrder { get; set; }
        public static string AddMemershipLevel_CanBeProcessedByService_DDM { get; set; }
        public static string Click_AddMemershipLevel_CancelButton { get; set; }
        public static string Click_AddMemershipLevel_SaveButton { get; set; }
        public static string Click_DeleteMemershipLevel_SubmitButton { get; set; }
        public static string Click_DeleteMemershipLevel_CancelButton { get; set; }
        
        public static string Click_AddMemershipLevel_Close { get; set; }
        public static string Click_Memberlevelrule_Tab { get; set; }
        public static string Click_AddRule_Button { get; set; }
        public static string Select_MemberLevel_Dropdown { get; set; }
        public static string Select_RuleType_Dropdown { get; set; }
        public static string Select_StayType_Dropdown { get; set; }
        public static string Select_DefaultRule_Dropdown { get; set; }
        public static string Enter_MonthPeriod_TextBox { get; set; }
        public static string Enter_QualifyingNight_TextBox { get; set; }
        public static string Enter_StayProperties_TextBox { get; set; }
        public static string Enter_QualifiedStay_TextBox { get; set; }
        public static string Enter_CheckedOutStay_TextBox { get; set; }
        public static string Enter_Points_TextBox { get; set; }
        public static string Enter_Revenue_TextBox { get; set; }
        public static string Click_MembershipLevelSave_Button { get; set; }
        public static string Click_MembershipLevelCancel_Button { get; set; }
        public static string Click_MembershipLevelClose_Icon { get; set; }
        public static string Enter_MemberLevelRule_Filter { get; set; }
        public static string Click_MemberLevelRuleEdit_Button { get; set; }
        public static string Click_LoyaltyRules_AwardEarningRules { get; set; }
        public static string Click_AwardEarningRules_AddRuleButton { get; set; }
        public static string Click_AwardEarningRules_AddRule_IncludeMemberLevel { get; set; }
        public static string Click_AwardEarningRules_AddRule_CancelButton { get; set; }
        public static string Click_MemberLevelRule_AddRuleButton { get; set; }
        public static string Click_MemberLevelRule_AddRuleButton_NewLevel { get; set; }
        public static string Click_MemberLevelRule_AddRuleButton_CancelButton { get; set; }
        public static string Click_DeleteMemershipLevelRule_SubmitButton { get; set; }
        public static string Click_DeleteMemershipLevelRule_CancelButton { get; set; }
        public static string Click_DeleteMemberLevelRule_Button { get; set; }
        public static string Click_EditMemberLevelRule_Button { get; set; }

        public static string Admin_MemberBatchUpload_BtachRegistration_SubTab { get; set; }
        public static string Click_LoyaltyRules_MemberLevelRules_Tab { get; set; }
        public static string Click_LoyaltyRules_MemberLevelRules_AddRule { get; set; }
        public static string Click_LoyaltyRules_MemberLevelRules_Filters { get; set; }
        public static string Click_LoyaltyRules_MemberLevelRules_AddRule_RefferalCode { get; set; }
        public static string Click_LoyaltyRules_MemberLevelRules_AddRule_QualifyingNights { get; set; }
        public static string Click_LoyaltyRules_MemberLevelRules_AddRule_StayType { get; set; }
        public static string Click_LoyaltyRules_MemberLevelRules_AddRule_NewLevel { get; set; }
        public static string Click_LoyaltyRules_MemberLevelRules_AddRule_CancelButton { get; set; }
        public static string Click_LoyaltyRules_MemberLevelRules_AddRule_SaveButton { get; set; }
        public static string Click_LoyaltyRules_MemberLevelRules_EditButton { get; set; }
        public static string Click_LoyaltyRules_MemberLevelRules_DeleteButton { get; set; }
        public static string Click_LoyaltyRules_MemberLevelRules_PrevButton { get; set; }
        public static string Click_LoyaltyRules_MemberLevelRules_NextButton { get; set; }
        public static string Click_LoyaltyRules_MemberLevelRules_DeleteConfirmButton { get; set; }
        public static string Click_LoyaltyRules_MemberLevelRules_PaginationDropdown { get; set; }
        public static string Click_LoyaltyRules_MemberLevelRules_DeleteCancle { get; set; }
        public static string Click_LoyaltyRules_PointsEarningRule_RuleRestriction { get; set; }
        public static string Click_LoyaltyRules_PointsEarningRule_RuleRestriction_ChannelCodeValue { get; set; }
        
        public static string Click_MemberBatchUpdate_UploadDateAndTime { get; set; }
        public static string Get_PointsEarningRule_GridName { get; set; }
        public static string Get_PointsEarningRule_GridPriority { get; set; }
        public static string Select_MembershipLevel_Entries { get; set; }
        public static string Enter_MembershipLevel_Filter { get; set; }
        



        public static string Enter_AddMemershipLevel_Filter { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Button_EditPromotion { get; set; }
        public static string Click_Member_Level_Email_Yes_Button { get; set; }

        #endregion[Admin]

        #region[Admin_Navigations]
        public static string Admin_Tab_MemberTransactions { get; set; }
        public static string Admin_Tab_PointsHistory { get; set; }
        public static string Admin_Tab_MemberAwards { get; set; }
        public static string Admin_Tab_Invites { get; set; }
        public static string Admin_Tab_Redemptions { get; set; }
        public static string Admin_Tab_MemberStays { get; set; }
        public static string Admin_Tab_AdminUpdates { get; set; }
        public static string Click_AdminUpdates_Button_Close { get; set; }
        
        public static string Admin_Menu_LoyaltySetup { get; set; }
        public static string Admin_Menu_Home { get; set; }
        public static string Admin_Menu_Users { get; set; }
        public static string Admin_submenu_Users_setting { get; set; }
        public static string Admin_Menu_EmailSetup { get; set; }
        public static string Admin_Menu_ManualMerge { get; set; }

        public static string Admin_Menu_Redeem { get; set; }

        public static string Admin_Menu_LoyaltyeGifts { get; set; }



        public static string Admin_Menu_LoyaltyRules { get; set; }
        public static string Admin_LoyaltySetup_SubTab_TransactionReason { get; set; }
        public static string Admin_LoyaltySetup_SubTab_SignUpSources { get; set; }
        public static string Admin_LoyaltySetup_SubTab_TermsAndConditions { get; set; }
        public static string Admin_LoyaltySetup_SubTab_Offers { get; set; }
        public static string Admin_LoyaltyRules_SubTab_QualifyingRules { get; set; }
        public static string Admin_LoyaltyRules_SubTab_PointsEarningRules { get; set; }
        public static string Admin_Menu_ContentManagment_Tab { get; set; }
        public static string Admin_Menu_LoyaltyMapping_Tab { get; set; }
        public static string Click_AddAward { get; set; }

        #endregion[Admin_Navigations]

        #region[Admin_MemberInformation]
        public static string Admin_MemberInformation_Dropdown_MemberStatus { get; set; }
        public static string Admin_MemberInformation_Value_MemberStatus { get; set; }
        public static string Admin_MemberInformation_Value_MemberLevel { get; set; }
        public static string Admin_MemberInformation_Icon_Right { get; set; }
        public static string Admin_MemberInformation_Icon_Cross { get; set; }
        public static string Admin_MemberInformation_Value_PointsBalance { get; set; }
        public static string Admin_MemberInformation_Value_MemberLogin { get; set; }
        public static string Admin_MemberInformation_Text_UserLogin { get; set; }
        public static string Admin_MemberInformation_Button_Update { get; set; }
        public static string Admin_MemberInformation_ResetLogin_Icon_Close { get; set; }
        public static string Admin_MemberInformation_Value_ActivationEmail { get; set; }
        public static string Admin_MemberInformation_ActivationEmail_UserLogin { get; set; }
        public static string Admin_MemberInformation_Value_WelcomeEmail { get; set; }
        public static string Admin_ActivationEmail_Icon_Close { get; set; }
        public static string Admin_WelcomeEmail_Icon_Close { get; set; }
        public static string Admin_MemberInformation_WelcomeEmail_UserLogin { get; set; }
        public static string Admin_MemberInformation_Value_MemberPortal { get; set; }
        public static string Admin_MemberInformation_Value_EmailStatus { get; set; }
        public static string Admin_MemberInformation_Value_ActivatedDate { get; set; }
        public static string Admin_MemberInformation_Activation_Button_SendEmail { get; set; }
        public static string Admin_MemberInformation_Welcome_Button_SendEmail { get; set; }
        public static string Admin_MemberInformation_Dropdown_EmailStatus { get; set; }
        public static string Admin_MemberInformation_Value_Email { get; set; }
        #endregion[Admin_MemberInformation]

        #region[Admin_MemberTransaction]
        public static string Admin_MemberTransaction_Button_AddTransactions { get; set; }
        public static string Admin_MemberTransaction_Text_FilterSearch { get; set; }
        public static string Admin_MemberTransaction_Dropdown_Entries { get; set; }
        public static string Admin_MemberTransaction_Dropdown_TransactionReason { get; set; }
        public static string Admin_MemberTransaction_Text_Points { get; set; }
        public static string Admin_MemberTransaction_Text_InternalComments { get; set; }
        public static string Admin_MemberTransaction_DatePicker_ExpirationDate { get; set; }
        public static string Admin_MemberTransaction_Text_ExpirationDate { get; set; }
        public static string Admin_MemberTransaction_Text_CommentsToGuest { get; set; }
        public static string Admin_MemberTransaction_RadioButton_SendEmailToMember { get; set; }
        public static string Admin_MemberTransaction_RadioButton_AddCommentsToEmail { get; set; }
        public static string Admin_MemberTransaction_Text_MemberEmail { get; set; }
        public static string Admin_MemberTransaction_Text_BCC { get; set; }
        public static string Admin_MemberTransaction_RadioButton_FraserHospitality { get; set; }
        public static string Admin_MemberTransaction_RadioButton_Hotel { get; set; }
        public static string Admin_MemberTransaction_Button_Save { get; set; }
        public static string Admin_MemberTransaction_Text_Hotel { get; set; }
        public static string Admin_MemberTransaction_Dropdown_Hotel { get; set; }
        public static string Admin_MemberTransaction_Icon_Close { get; set; }
        public static string Admin_MemberTransaction_Dropdown_Pagination { get; set; }
        public static string Admin_MemberTransaction_Arrow_Next { get; set; }
        public static string Admin_MemberTransaction_Arrow_Previous { get; set; }
        public static string Click_On_Close { get; set; }
        #endregion[Admin_MemberTransaction]

        #region[Admin_MemberStay]
        public static string Admin_Dropdown_Entries { get; set; }
        public static string Admin_MemberStay_Button_SearchStay { get; set; }
        public static string Admin_MemberStay_Dropdown_Property { get; set; }
        public static string Admin_MemberStay_Value_Property { get; set; }
        public static string Admin_MemberStay_Button_Search { get; set; }
        public static string Admin_MemberStay_Value_DepartureFrom { get; set; }
        public static string Admin_MemberStay_Value_DepartureTo { get; set; }
        public static string Admin_MemberStay_Text_FirstName { get; set; }
        public static string Admin_MemberStay_Text_LastName { get; set; }
        public static string Admin_MemberStay_Text_ReservationNumber { get; set; }
        public static string Admin_MemberStay_Data_ReservationNumber { get; set; }
        public static string Admin_MemberStay_Data_Arrival { get; set; }
        public static string Admin_MemberStay_Data_Departure { get; set; }
        public static string Admin_MemberStay_Data_Hotel { get; set; }
        public static string Admin_MemberStay_Tab_MemberID { get; set; }
        public static string Admin_MemberStay_Checkbox_Select { get; set; }
        public static string Admin_MemberStay_Button_Save { get; set; }
        public static string Admin_MemberStay_Button_Back { get; set; }
        public static string Enter_ReservationNumber { get; set; }
        public static string Admin_Icon_Next { get; set; }
        public static string Admin_Icon_Previous { get; set; }
        public static string Admin_MemberStay_Text_Filter { get; set; }
        public static string Admin_Memberupload_Text_Filter { get; set; }
        public static string Admin_Memberupdate_Text_Filter { get; set; }
        public static string PropertyName { get; set; }

        public static string Admin_Bartell_MemberStay_Data_Arrival { get; set; }
        #endregion[Admin_MemberStay]

        #region[Admin_AdminUpdates]
        public static string Admin_AdminUpdates_Dropdown_Entries { get; set; }
        public static string Admin_AdminUpdates_Text_Filter { get; set; }
        public static string Admin_AdminUpdates_Icon_View1 { get; set; }
        public static string Admin_AdminUpdates_Button_Next { get; set; }
        public static string Admin_AdminUpdates_Button_Last { get; set; }
        public static string Admin_AdminUpdates_Button_Prev { get; set; }
        public static string Admin_AdminUpdates_Button_First { get; set; }
        #endregion[Admin_AdminUpdates]

        #region[Admin_MemberAwards]
        public static string Admin_MemberAwards_Button_AddAward { get; set; }
        public static string Admin_MemberAwards_Dropdown_SelectAward { get; set; }
        public static string Admin_MemberAwards_Text_Comment { get; set; }
        public static string Admin_MemberAwards_Button_Save { get; set; }
        public static string Admin_MemberAwards_Icon_Close { get; set; }
        public static string Admin_MemberAwards_Text_Filter { get; set; }
        public static string Admin_Click_ExpirationDate { get; set; }
        public static string Admin_Click_ExpirationDateSubmit { get; set; }
        public static string Click_MemberAwardStatus { get; set; }
        public static string Click_AdminSendResend { get; set; }
        public static string click_ResendAwardEmail_Close { get; set; }
        public static string Dropdown_SelectStatus { get; set; }
        public static string SelectStatusCheck { get; set; }
        public static string DeleteSelectedStatus { get; set; }

        #endregion[Admin_MemberAwards]

        #region[LoyaltySetUp_TransactionReason]
        public static string Admin_LoyaltySetUp_TransactionReason_Button_AddReason { get; set; }
        public static string Admin_LoyaltySetUp_TransactionReason_Text_Code { get; set; }
        public static string Admin_LoyaltySetUp_TransactionReason_Text_Filter { get; set; }
        public static string Admin_LoyaltySetUp_TransactionReason_Text_ReasonName { get; set; }
        public static string Admin_LoyaltySetUp_TransactionReason_Button_Save { get; set; }
        public static string Admin_LoyaltySetUp_TransactionReason_Button_Cancel { get; set; }
        public static string Admin_LoyaltySetUp_TransactionReason_Icon_Close { get; set; }
        public static string Admin_LoyaltySetUp_TransactionReason_Icon_Edit { get; set; }
        #endregion[LoyaltySetUp_TransactionReason]

        #region[LoyaltySetUp_SignUpSource]
        public static string Admin_LoyaltySetUp_SignUpSource_Text_Filter { get; set; }
        public static string Admin_LoyaltySetUp_SignUpSource_Icon_Edit { get; set; }
        public static string Admin_LoyaltySetUp_SignUpSource_Text_SignUpSourceCode { get; set; }
        public static string Admin_LoyaltySetUp_SignUpSource_Text_SignUpSourceName { get; set; }
        public static string Admin_LoyaltySetUp_SignUpSource_Button_Save { get; set; }
        public static string Admin_LoyaltySetUp_SignUpSource_Button_Cancel { get; set; }
        public static string Admin_LoyaltySetUp_SignUpSource_Button_Close { get; set; }
        public static string Admin_LoyaltySetUp_SignUpSource_Button_AddSource { get; set; }
        #endregion[LoyaltySetUp_SignUpSource]

        #region[LoyaltySetUp_TermsAndCondition]
        public static string Admin_LoyaltySetUp_TermsAndCondition_Button_AddTermsAndCondition { get; set; }
        public static string Admin_LoyaltySetUp_TermsAndCondition_Text_Filter { get; set; }
        public static string Admin_LoyaltySetUp_TermsAndCondition_Icon_Edit { get; set; }
        public static string Admin_LoyaltySetUp_TermsAndCondition_Icon_Delete { get; set; }
        public static string Admin_LoyaltySetUp_TermsAndCondition_Icon_Close { get; set; }
        public static string Admin_LoyaltySetUp_TermsAndCondition_Text_Title { get; set; }
        public static string Admin_LoyaltySetUp_TermsAndCondition_Button_Save { get; set; }
        public static string Admin_LoyaltySetUp_TermsAndCondition_Button_Cancel { get; set; }
        public static string Admin_LoyaltySetUp_TermsAndCondition_Button_Yes { get; set; }
        public static string Admin_LoyaltySetUp_TermsAndCondition_Button_No { get; set; }
        public static string Admin_LoyaltySetUp_TermsAndCondition_Add_TermsAndCondition { get; set; }
        public static string Admin_LoyaltySetUp_TermsAndCondition_Description { get; set; }
        public static string Click_Redeem_Button_In_My_Awards { get; set; }


        #endregion[LoyaltySetUp_TermsAndCondition]

        #region[LoyaltySetUp_Offers]
        public static string Admin_LoyaltySetUp_Offers_Button_AddOffers { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Text_Filter { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Icon_Edit { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Text_Title { get; set; }
        public static string Admin_AdminUpdates_Search_Clear { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Text_Description { get; set; }
        public static string Admin_LoyaltySetUp_IFrame_ShortDescription { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Text_VisibilityStart { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Text_VisibilityEnd { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Text_PromotionStart { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Text_PromotionEnd { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Icon_Image { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Button_Save { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Button_Cancel { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Icon_Close { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Button_Yes { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Button_No { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Dropdown_MemberLevel { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Button_SelectAll { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Button_DeselectAll { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Text_MemberLevel { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Button_BrowseImage { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Button_SaveImage { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Button_CancelImage { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Button_AddAnotherPromotion { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Text_PromotionCode { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Text_ButtonText { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Iframe_Description { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Button_SavePromotion { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Dropdown_HotelSelection { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Value_HotelSelection { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Button_CancelPromotion { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Button_SavePromotionConfirm { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Button_SavePromotionCancel { get; set; }
        
        public static string Admin_LoyaltySetUp_Offers_Button_DeletePromotion { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Button_DeleteYes { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Button_DeleteNo { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Icon_PromotionDeleteClose { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Pagination_Dropdown { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Pagination_Prev_Button { get; set; }
        public static string Admin_LoyaltySetUp_Offers_Pagination_Next_Button { get; set; }
        public static string Click_LoyaltySetUp_Promotion_Filter { get; set; }
        #endregion[LoyaltySetUp_Offers]

        #region[LoyaltyRules_PointsEarningRules]
        public static string Admin_LoyaltyRules_PointsEarningRules_Button_AddRule { get; set; }
        public static string Admin_LoyaltyRules_PointsEarningRules_Text_Filter { get; set; }
        public static string Admin_LoyaltyRules_PointsEarningRules_Icon_Edit { get; set; }
        public static string Admin_LoyaltyRules_PointsEarningRules_Text_Name { get; set; }
        public static string Admin_LoyaltyRules_PointsEarningRules_Text_DisplayName { get; set; }
        public static string Admin_LoyaltyRules_PointsEarningRules_Text_Description { get; set; }
        public static string Admin_LoyaltyRules_PointsEarningRules_Dropdown_BasedOn { get; set; }
        public static string Admin_LoyaltyRules_PointsEarningRules_Text_StartDate { get; set; }
        public static string Admin_LoyaltyRules_PointsEarningRules_Text_EndDate { get; set; }
        public static string Admin_LoyaltyRules_PointsEarningRules_Text_Priority { get; set; }
        public static string Admin_LoyaltyRules_PointsEarningRules_Dropdown_RuleType { get; set; }
        public static string Admin_LoyaltyRules_PointsEarningRules_Dropdown_For { get; set; }
        public static string Admin_LoyaltyRules_PointsEarningRules_Text_PointsEarned { get; set; }
        public static string Admin_LoyaltyRules_PointsEarningRules_Text_Per { get; set; }
        public static string Admin_LoyaltyRules_PointsEarningRules_Dropdown_CaculatedOn { get; set; }
        public static string Admin_LoyaltyRules_PointsEarningRules_Dropdown_RevenueType { get; set; }
        public static string Admin_LoyaltyRules_PointsEarningRules_Text_IncludeMemberLevel { get; set; }
        public static string Admin_LoyaltyRules_PointsEarningRules_Button_Save { get; set; }
        public static string Admin_LoyaltyRules_PointsEarningRules_Button_Cancel { get; set; }
        public static string Admin_LoyaltyRules_PointsEarningRules_Icon_Close { get; set; }
        public static string Admin_LoyaltyRules_PointsEarningRules_Dropdown_IncludeMemberLevel { get; set; }
        public static string Admin_LoyaltyRules_PointsEarningRules_Text_PointsExpiryMonth { get; set; }
        public static string Admin_LoyaltyRules_PointsEarningRules_Text_IncludeMemberLevel1 { get; set; }
        #endregion[LoyaltyRules_PointsEarningRules]

        #region[Admin_LoyaltyAwards]
        public static string Admin_LoyaltyAwards_Button_Add { get; set; }
        public static string Admin_LoyaltyAwards_Text_Filter { get; set; }
        public static string Admin_LoyaltyAwards_Icon_Edit { get; set; }
        public static string Admin_LoyaltyAwards_Text_AwardName { get; set; }
        public static string Admin_LoyaltyAwards_Text_AwardCode { get; set; }
        public static string Admin_LoyaltyAwards_Text_StartDate { get; set; }
        public static string Admin_LoyaltyAwards_Text_EndDate { get; set; }
        public static string Admin_LoyaltyAwards_Dropdown_AwardType { get; set; }
        public static string Admin_LoyaltyAwards_Dropdown_ExpMonth { get; set; }
        public static string Admin_LoyaltyAwards_Dropdown_ExpDay { get; set; }
        public static string Admin_LoyaltyAwards_Dropdown_ExpYear { get; set; }
        public static string Admin_LoyaltyAwards_Dropdown_AdminMemberStatus { get; set; }
        public static string Admin_LoyaltyAwards_Button_Save { get; set; }
        public static string Admin_LoyaltyAwards_Button_Cancel { get; set; }
        public static string Admin_LoyaltyAwards_Icon_Close { get; set; }
        public static string Admin_LoyaltyAwards_BirthdayAward_Text_DaysActive { get; set; }
        public static string Admin_LoyaltyAwards_BirthdayAward_Text_AdvanceDeliveryDays { get; set; }
        public static string Admin_LoyaltyAwards_BirthdayAward_Text_MinQualifiedStay { get; set; }
        public static string Admin_LoyaltyAwards_BirthdayAward_Dropdown_MemberLevel { get; set; }
        public static string Admin_LoyaltyAwards_BirthdayAward_Text_MemberLevel { get; set; }
        public static string Admin_LoyaltyAwards_BirthdayAward_Dropdown_EmailName { get; set; }
        public static string Admin_LoyaltyAwards_NightBasedAward_Text_NightCycle { get; set; }
        public static string Admin_LoyaltyAwards_NightBasedAward_Dropdown_NightAwarded { get; set; }
        public static string Admin_LoyaltyAwards_NightBasedAward_Text_NightAwarded { get; set; }
        public static string Admin_LoyaltyAwards_NightBasedAward_Dropdown_AwardExpMonth { get; set; }
        public static string Admin_LoyaltyAwards_NightBasedAward_Dropdown_MemberLevel { get; set; }
        public static string Admin_LoyaltyAwards_NightBasedAward_Text_MemberLevel { get; set; }
        public static string Admin_LoyaltyAwards_NightBasedAward_Text_MaxAwardPerNight { get; set; }
        public static string Admin_LoyaltyAwards_NightBasedAward_Dropdown_Hotel { get; set; }
        public static string Admin_LoyaltyAwards_NightBasedAward_Text_Hotel { get; set; }
        public static string Admin_Text_PointsCost { get; set; }
        public static string Admin_CheckBox_Use_As_EGift { get; set; }
        public static string Admin_DropDown_AwardExpMonth { get; set; }
        public static string Admin_LoyaltyAwards_Member_Level { get; set; }
        public static string Click_Admin_AutomatedSwitch { get; set; }
        public static string Click_Admin_AwardStatusSwitch { get; set; }
        public static string Admin_LoyaltyAwards_Member_Level_DeselectAll { get; set; }
        public static string Admin_LoyaltyAwards_Member_Level_SelectAll { get; set; }
        public static string Admin_LoyaltyAwards_Member_Level_ClickDDM { get; set; }
        public static string Admin_LoyaltyAwards_Text_Points { get; set; }
        #endregion[Admin_LoyaltyAwards]

        #region[Admin_EmailSetUp]
        public static string Admin_EmailSetUp_Text_Filter { get; set; }
        public static string Admin_EmailSetUp_Icon_Edit { get; set; }
        public static string Admin_EmailSetUp_Text_EmailName { get; set; }
        public static string Admin_EmailSetUp_Text_EmailSubject { get; set; }
        public static string Admin_EmailSetUp_IFrame_EmailContent { get; set; }
        public static string Admin_EmailSetUp_Text_EmailContent { get; set; }
        public static string Admin_EmailSetUp_IFrame_TermsAndCondition { get; set; }
        public static string Admin_EmailSetUp_Text_TermsAndCondition { get; set; }
        public static string Admin_EmailSetUp_RadioButton_EmailStatus_Active { get; set; }
        public static string Admin_EmailSetUp_RadioButton_EmailStatus_InActive { get; set; }
        public static string Admin_EmailSetUp_Button_Save { get; set; }
        public static string Admin_EmailSetUp_Button_Cancel { get; set; }
        public static string Activation_Email_Link_Button { get; set; }
        public static string Activation_Email_Link { get; set; }
        public static string ForgotPassword_Email_Link { get; set; }
        #endregion[Admin_EmailSetUp]
        #region[Admin Redeem]
        public static string Button_Add_Redemption { get; set; }
        public static string Name_InputBox_Add_Redemption { get; set; }
        public static string ConnectTo_InputBox_Add_Redemption { get; set; }
        public static string Button_InputBox_Add_Redemption { get; set; }

        public static string Redeem_FilterSearch { get; set; }
        public static string Get_RedeemptionName { get; set; }
        public static string Get_AwardLinkName { get; set; }



        #endregion[Admin Redeem]

        #region[Admin_Users]
        public static string Admin_Users_Text_Search { get; set; }
        public static string Admin_Users_Text_Firstname { get; set; }
        public static string Admin_Users_Text_Lastname { get; set; }
        public static string Admin_Users_Dropdown_UserTitle { get; set; }
        public static string Admin_Users_Dropdown_PropertyName { get; set; }
        public static string Admin_Users_Dropdown_UserPermission { get; set; }
        public static string AdminorgotPassword_Recovery { get; set; }
        public static string Admin_Users_Text_UserLogin { get; set; }
        public static string Admin_Users_Button_Save { get; set; }
        public static string Admin_Users_Button_Close { get; set; }
        public static string Admin_Users_Button_Edit { get; set; }
        public static string Admin_Users_Button_Delete { get; set; }
        public static string Admin_Users_Button_AddUsers { get; set; }
        #endregion[Admin_Users]

        #region[Admin_ManualMerge]
        public static string Admin_ManualMerge_Text_MemberID { get; set; }
        public static string Admin_ManualMerge_Text_Firstname { get; set; }
        public static string Admin_ManualMerge_Text_Lastname { get; set; }
        public static string Admin_ManualMerge_Text_Email { get; set; }
        public static string Admin_ManualMerge_Text_Street { get; set; }
        public static string Admin_ManualMerge_Text_City { get; set; }
        public static string Admin_ManualMerge_Text_Zip { get; set; }
        public static string Admin_ManualMerge_Button_SearchMember { get; set; }
        public static string Admin_ManualMerge_Button_ClearSearch { get; set; }
        public static string Admin_ManualMerge_Button_Review { get; set; }
        public static string Admin_ManualMerge_Button_Cancel { get; set; }
        public static string Admin_ManualMerge_Button_Merge { get; set; }
        public static string Admin_ManualMerge_Icon_Select1 { get; set; }
        public static string Admin_ManualMerge_Tab_AccountWinner1 { get; set; }
        public static string Admin_ManualMerge_RadioButton_AccountWinner1 { get; set; }
        public static string Admin_ManualMerge_RadioButton_AccountWinner2 { get; set; }
        public static string Admin_ManualMerge_Tab_AccountWinner1_Points { get; set; }
        public static string Admin_ManualMerge_Tab_AccountWinner2_Points { get; set; }
        public static string Admin_ManualMerge_Button_Back { get; set; }
        public static string Admin_ManualMergeReview_Button_Merge { get; set; }
        public static string Admin_ManualMergeReview_Button_Confirm { get; set; }
        public static string Admin_ManualMergeReview_Button_Cancel { get; set; }
        public static string Admin_ManualMerge_SubTab_ManualMerge { get; set; }
        public static string Admin_ManualMerge_Value_AccountWinner1_Email { get; set; }
        public static string Admin_ManualMerge_Value_AccountWinner2_Email { get; set; }
        public static string MembershipLevel { get; set; }
        public static string Admin_ManualMerge_Value_Status { get; set; }
        public static string Admin_ManualMerge_MemberMerge_SubTab { get; set; }
        #endregion[Admin_ManualMerge]

        #region[UI]

        #region[SignIn]
        public static string SignIn_Text_Email { get; set; }
        public static string SignIn_Text_Password { get; set; }
        public static string Login_SSO { get; set; }
        public static string SignIn_Button_LogIn { get; set; }
        public static string SignIn_Button_LogIn2 { get; set; }
        public static string SignIn_Button_LogIn3 { get; set; }
        public static string SignIn_Link_ForgotYourLogin { get; set; }
        public static string SignIn_Link_ForgotYourLogin2 { get; set; }
        public static string SignIn_Link_SignInFacebook { get; set; }
        public static string SignIn_Link_SignInTwitter { get; set; }
        public static string SignIn_Button_SignUp { get; set; }
        public static string SignIn_Button_PasswordRecovery { get; set; }
        public static string SignIn_Link_ChangePassword { get; set; }
        public static string SignIn_Text_ConfirmNewPassword { get; set; }
        public static string SignIn_Button_ResetPassword { get; set; }
        public static string SignIn_LinkText_Clickhere { get; set; }
        public static string SignIn_ValidationMessage { get; set; }
        public static string SignIn_Link_ForgotYourPassword { get; set; }

        public static string SignIn_Email_Error_Message { get; set; }

        public static string SignIn_Footer { get; set; }
        public static string TFE_SignIn_iFrame { get; set; }
        
        #endregion[SignIn]

        #region[SignUp]
        public static string Click_SignIn { get; set; }
        public static string SignUp_DropDown_Salutation { get; set; }
        public static string SignUp_Text_FirstName { get; set; }
        public static string SignUp_Text_LastName { get; set; }
        public static string SignUp_Text_Email { get; set; }
        public static string SignUp_Text_Password { get; set; }
        public static string SignUp_Text_ConfirmPassword { get; set; }
        public static string SignUp_CheckBox_TermsAndConditions { get; set; }
        public static string SignUp_Text_PreferredCardName { get; set; }
        public static string SignUp_Button_Join { get; set; }
        public static string SignUp_Icon_Close { get; set; }
        public static string SignInButton_ActivationPage { get; set; }
        public static string SignUp_TermsandCondition_Accept { get; set; }
        public static string SignUp_TermsandCondition_Close { get; set; }
        public static string SignUp_Button_ActivationPage { get; set; }
        public static string SignUp_DateOfBirth { get; set; }

        public static string SignUp_Date_Picker { get; set; }

        public static string SignUp_Footer { get; set; }
        public static string SignUp_Facebook_Link { get; set; }
        public static string SignUp_Twitter_Link { get; set; }

        public static string Facebook_UserName { get; set; }
        public static string Facebook_Password { get; set; }
        public static string Facebook_Login { get; set; }
        public static string Twitter_UserName { get; set; }
        public static string Twitter_Password { get; set; }
        public static string Twitter_Login { get; set; }
        public static string Allow_On_Twitter { get; set; }
        public static string DOB_Error { get; set; }
        public static string FirstName_Error { get; set; }
        public static string LastName_Error { get; set; }
        public static string Email_Error { get; set; }
        public static string Card_Error { get; set; }
        public static string Password_Error { get; set; }
        public static string ConfirmPassword_Error { get; set; }
        public static string Captcha_Error { get; set; }
        public static string Password_Eye_Ball { get; set; }
        public static string ConfirmPassword_Eye_Ball { get; set; }

        #endregion[SignUp]

        #region[Reedem]
        public static string Reedem_Button_Redeem { get; set; }
        //public static string Navigation_Link_Redeem { get; set; }
        public static string Redeem_Button_Frontend { get; set; }
        public static string Image_On_Redeem_Button_Frontend { get; set; }
        public static string Ok_Button_On_EGift { get; set; }
        public static string Lable_TotalPoints { get; set; }

        public static string Select_AwardImage { get; set; }

        public static string Click_Redeem_eGiftCart { get; set; }

        public static string Click_Conform_eGiftCart { get; set; }

        public static string Click_Close_eGiftCart { get; set; }

        public static string Click_Redeem_CancelButton { get; set; }
        public static string Get_TotalPoints { get; set; }
        public static string Get_RedeemedAwardName { get; set; }
        public static string Click_RequestSubmitted_OkButton { get; set; }
        public static string Click_Redeem_Ok { get; set; }
        public static string Click_Redeem_Cancel { get; set; }

        #endregion[Reedem]

        #region[InviteFriends]
        public static string InviteFriends_Text_InviteFriends { get; set; }
        public static string InviteFriends_Button_SendMyInvitation { get; set; }
        public static string InviteFriends_Error_Message { get; set; }
        public static string EnterText_SendInvitation { get; set; }
        public static string InviteFriendValidation_CaptchaError { get; set; }
        public static string InviteFriendEmailValidation_Error { get; set; }
        public static string EnterText_SendInvitationMailContent { get; set; }
        public static string EnterText_SendInvitationMailContent_Error { get; set; }
        #endregion[InviteFriends]

        #region[SpecialOffers]
        public static string SpecialOffers_Text_Exclusive { get; set; }
        public static string Specialoffers_LastButton { get; set; }
        
        
        #endregion[SpecialOffers]

        #region[Navigation]
        public static string Navigation_Button_SignIn { get; set; }
        public static string Navigation_Button_Back { get; set; }
        public static string Navigation_Button_JoinNow { get; set; }
        public static string Navigation_Button_JoinNow1 { get; set; }
        public static string Navigation_Link_SignIn { get; set; }
        public static string Navigation_Link_Sign_In { get; set; }
        public static string Navigation_Link_Join { get; set; }
        public static string Navigation_Link_Join2 { get; set; }
        public static string Navigation_Link_MyStays { get; set; }
        public static string Navigation_Link_MyStays2 { get; set; }
        public static string Navigation_Link_MyProfile { get; set; }
        public static string Navigation_Link_MyProfile1 { get; set; }
        public static string Navigation_Link_Summary { get; set; }
        public static string Navigation_Link_Benefits { get; set; }
        public static string Navigation_Link_FAQ { get; set; }
        public static string Navigation_Link_ContactUs { get; set; }
        public static string Navigation_Link_Un_Authenticated_ContactUs { get; set; }
        
        public static string Navigation_Link_ContactUs2 { get; set; }
        public static string Navigation_Link_Redeem { get; set; }
        public static string Navigation_Link_MyActivity { get; set; }
        public static string Navigation_Link_SignOut { get; set; }
        public static string Navigation_Link_SignOut2 { get; set; }
        public static string Navigation_Link_UpdateMyPreferences { get; set; }
        public static string Navigation_Link_UpdateMyProfile { get; set; }
        public static string Navigation_Link_MySettings { get; set; }
        public static string Navigation_LinkText_MySettings { get; set; }
        public static string Navigation_Link_Facebook { get; set; }
        public static string Navigation_Link_Twitter { get; set; }

        public static string Navigation_Link_MyAccount { get; set; }
        public static string Navigation_Button_ExpandCollapse { get; set; }
        public static string Overview_MemberSinceDate { get; set; }
        public static string Overview_MemberShipLevel { get; set; }
        public static string Navigation_Link_Exclusives { get; set; }
        public static string Navigation_Link_LoginExclusives { get; set; }
        public static string Navigation_Link_MyAward { get; set; }
        public static string Navigation_Link_MyAward_Filter { get; set; }
        public static string Navigation_Button_MyAward_Redeem { get; set; }
        public static string Navigation_SpecialOffer { get; set; }
        public static string Navigation_Link_ProgramOverview { get; set; }
        public static string Navigation_Link_Enroll { get; set; }
        public static string Navigation_Link_FAQ1 { get; set; }
        public static string Navigation_Link_InviteFriends { get; set; }
        public static string SignIn_Frequently_Asked_Questions { get; set; }
        public static string Navigation_Link_MyAccount_Dropdown { get; set; }
        public static string Click_Contact_Link { get; set; }


        #endregion[Navigation]

        #region[MyStays]
        public static string MyStays_DropDown_UpcomingStays { get; set; }
        public static string MyStays_DropDown_PastStays { get; set; }
        public static string MyStays_Text_UpcomingStays_Filter { get; set; }
        public static string MyStays_Text_PastStays_Filter { get; set; }
        #endregion[MyStays]

        #region[Award]
        public static string Click_Award_Name { get; set; }

        public static string Click_Award_Tab { get; set; }

        public static string Award_Filter { get; set; }

        public static string Click_Redemptions_SubTab { get; set; }
        #endregion[Award]

        #region[Summary]
        public static string Summary_Text_MembershipNo { get; set; }
        public static string Summary_Text_MembershipType { get; set; }
        public static string Summary_Click_MembershipCard { get; set; }
        public static string Summary_MembershipCard_Name { get; set; }
        public static string Summary_MembershipCard_Number { get; set; }
        public static string Summary_MembershipCard_SinceDate { get; set; }
        public static string Summary_MembershipCard_Close { get; set; }

        #endregion[Summary]

        #region[ContactUs]
        public static string ContactUs_Text_YourName { get; set; }
        public static string ContactUs_Text_EmailAddress { get; set; }
        public static string ContactUs_Text_PhoneNumber { get; set; }
        public static string ContactUs_Text_IndependentCMembershipNo { get; set; }
        public static string ContactUs_DDM_Subject { get; set; }
        public static string ContactUs_Text_Message { get; set; }
        public static string ContactUs_Button_Captcha { get; set; }
        public static string ContactUs_Button_Send { get; set; }
        public static string EnterText_Text_Confirmation_Number { get; set; }
        public static string Select_Contact_US_File { get; set; }

        public static string DropDownSelect_Authentication_Subject { get; set; }

        #endregion[ContactUs]

        #region[MyProfile]
        public static string MyProfile_Link_MyPersonalProfile_MyProfile { get; set; }
        public static string MyProfile_Link_MyPersonalProfile_YourPreferences { get; set; }
        public static string MyProfile_Text_MembershipNumber { get; set; }
        public static string MyProfile_Text_MembershipType { get; set; }
        public static string MyProfile_DropDown_Title { get; set; }
        public static string MyProfile_Text_FirstName { get; set; }
        public static string MyProfile_Text_LastName { get; set; }
        public static string MyProfile_Text_CardName { get; set; }
        public static string MyProfile_DropDown_Gender { get; set; }
        public static string MyProfile_DropDown_Nationality { get; set; }
        public static string MyProfile_DropDown_DateOfBirth { get; set; }
        public static string MyProfile_DropDown_Month { get; set; }
        public static string MyProfile_DropDown_Year { get; set; }
        public static string MyProfile_Text_CompanyName { get; set; }
        public static string MyProfile_Text_MobilePhoneNumber { get; set; }
        public static string MyProfile_Text_HomePhoneNumber { get; set; }
        public static string MyProfile_Text_OfficePhoneNumber { get; set; }
        public static string MyProfile_Text_FaxPhoneNumber { get; set; }
        public static string MyProfile_Text_Address1 { get; set; }
        public static string MyProfile_Text_Address2 { get; set; }
        public static string MyProfile_Text_City { get; set; }
        public static string MyProfile_DropDown_StateProvince { get; set; }
        public static string MyProfile_DropDown_Country { get; set; }
        public static string MyProfile_Text_Zip { get; set; }
        public static string MyProfile_Text_ZipExtension { get; set; }
        public static string MyProfile_DropDown_PreferredLanguage { get; set; }
        public static string MyProfile_DropDown_RecommendedBy { get; set; }
        public static string MyProfile_Button_Next { get; set; }
        public static string MyProfile_Link_FraserSuites { get; set; }
        public static string MyProfile_Link_FraserPlace { get; set; }
        public static string MyProfile_Link_FraserResidence { get; set; }
        public static string MyProfile_Link_Modena { get; set; }
        public static string MyProfile_Link_Capri { get; set; }
        public static string MyProfile_Link_Malmaison { get; set; }
        public static string MyProfile_Link_HotelDuVin { get; set; }
        public static string MyProfile_Link_TermsAndCondition { get; set; }
        public static string MyProfile_Link_FrequentlyAskedQuestions { get; set; }
        public static string MyProfile_Link_ContactUs { get; set; }
        public static string MyProfile_Link_TermsOfUse { get; set; }
        public static string MyProfile_Link_PrivacyPolicy { get; set; }
        public static string MyProfile_Link_BestRateGuarantee { get; set; }
        public static string MyProfile_FAQ_Icon_Close { get; set; }
        public static string MyProfile_Icon_Close { get; set; }

        #endregion[MyProfile]

        #region[MyProfile_Partner]
        public static string MyProfile_Partner_Icon_Partner { get; set; }
        public static string MyProfile_Partner_Checkbox_Partner { get; set; }
        public static string MyProfile_Partner_Text_FirstnameLastname { get; set; }
        public static string MyProfile_Partner_Text_DateOfBirth { get; set; }
        public static string MyProfile_Partner_Text_AnniversaryDate { get; set; }
        public static string MyProfile_Partner_Dropdown_Children { get; set; }
        public static string MyProfile_Partner_Dropdown_Month { get; set; }
        public static string MyProfile_Partner_Dropdown_Year { get; set; }
        public static string MyProfile_Partner_Button_Previous { get; set; }
        public static string MyProfile_Partner_Button_Next { get; set; }
        #endregion[MyProfile_Partner]

        #region[MyProfile_PassionAndInterests]
        public static string MyProfile_PassionAndInterests_Checkbox_ArtsandEntertainment { get; set; }
        public static string MyProfile_PassionAndInterests_Checkbox_FitnessandWellness { get; set; }
        public static string MyProfile_PassionAndInterests_Checkbox_FoodandWine { get; set; }
        public static string MyProfile_PassionAndInterests_Checkbox_Golf { get; set; }
        public static string MyProfile_PassionAndInterests_Checkbox_CultureAndHeritage { get; set; }
        public static string MyProfile_PassionAndInterests_Checkbox_Nature { get; set; }
        public static string MyProfile_PassionAndInterests_Checkbox_Nightlife { get; set; }
        public static string MyProfile_PassionAndInterests_Checkbox_ShoopingandLifestyle { get; set; }
        public static string MyProfile_PassionAndInterests_Checkbox_TechandGadgets { get; set; }
        public static string MyProfile_PassionAndInterests_Checkbox_Travel { get; set; }
        public static string MyProfile_PassionAndInterests_Checkbox_Family { get; set; }
        public static string MyProfile_PassionAndInterests_Checkbox_Sports { get; set; }
        public static string MyProfile_PassionAndInterests_Button_Previous { get; set; }
        public static string MyProfile_PassionAndInterests_Button_Next { get; set; }
        #endregion[MyProfile_PassionAndInterests]

        #region[MyProfile_MySubscriptions]
        public static string MyProfile_MySubscriptions_Button_Previous { get; set; }
        public static string MyProfile_MySubscriptions_Icon_MySubscriptions { get; set; }
        public static string MyProfile_MySubscriptions_Button_Update { get; set; }
        public static string MyProfile_MySubscriptions_Button_Submit { get; set; }
        public static string MyProfile_MySubscriptions_RadioButton_SubscribeAllAvailableLists { get; set; }
        public static string MyProfile_MySubscriptions_RadioButton_SubscribeSelectedLists { get; set; }
        public static string MyProfile_MySubscriptions_RadioButton_UnsubscribeEmailCampaigns { get; set; }
        public static string MyProfile_MySubscriptions_CheckBox_MonthlyEStatement { get; set; }
        public static string MyProfile_MySubscriptions_CheckBox_QuarterlyEStatement { get; set; }
        public static string MyProfile_MySubscriptions_CheckBox_MarketingAndPromotionalMaterials { get; set; }
        public static string MyProfile_MySubscriptions_CheckBox_eCacheAndeNewsletter { get; set; }
        public static string MyProfile_MySubscriptions_CheckBox_LifestyleArticlesAndAdvertorial { get; set; }
        public static string MyProfile_MySubscriptions_CheckBox_NotValuableOrRelevant { get; set; }
        public static string MyProfile_MySubscriptions_CheckBox_DonNotRememberSigningUp { get; set; }
        #endregion[MyProfile_MySubscriptions]

        #region [MySettings]
        public static string MySettings_NewEmailAddress { get; set; }
        public static string MySettings_Password { get; set; }
        public static string MySettings_UpdateUser { get; set; }
        public static string MySettings_UpdateLogin { get; set; }
        public static string MySettings_CurrentPassword { get; set; }
        public static string MySettings_NewPassword { get; set; }
        public static string MySettings_ConfirmPassword { get; set; }
        public static string MySettings_UpdatePassword { get; set; }
        public static string MySettings_CurrentEmailAddress { get; set; }
        public static string MySettings_PasswordUpdationConformationPopup { get; set; }
        public static string MySettings_EmailUpdationConformationPopup { get; set; }
        #endregion [MySettings]

        #region[ForgotPassword]
        public static string ForgotPassword_LinkText { get; set; }
        public static string ForgotPassword_Email { get; set; }
        public static string ForgotPassword_Recover { get; set; }
        public static string ForgotPassword_Recovery { get; set; }
        public static string ForgotPassword_TermsandCondition_Accept { get; set; }
        public static string ForgotPassword_Cancel { get; set; }
        public static string ForgotPassword_Back { get; set; }
        public static string ForgotPassword_NewPassword { get; set; }
        public static string ForgotPassword_NewPasswordConfirm { get; set; }
        #endregion[ForgotPassword]

        #region [Exclusives]
        public static string Exclusives_Text_ReadMore { get; set; }
        public static string Exclusives_Button_BookNow { get; set; }
        public static string Exclusives_Link_ShareNow { get; set; }
        #endregion [Exclusives]

        #region[Kiosk]
        public static string Kiosk_DropDown_Salutation { get; set; }
        public static string Kiosk_Text_FirstName { get; set; }
        public static string Kiosk_Text_LastName { get; set; }
        public static string Kiosk_Text_Email { get; set; }
        public static string Kiosk_Text_SignerName { get; set; }
        public static string Kiosk_Text_SignUpSource { get; set; }
        public static string Kiosk_DropDown_SignupCode { get; set; }
        public static string DropDown_SignupCode_Text { get; set; }
        public static string Kiosk_CheckBox_TermsAndConditions { get; set; }
        public static string Kiosk_Button_JoinNow { get; set; }
        #endregion[Kiosk]

        #region[Test]
        public static string CRMAPI_btnprimary { get; set; }
        public static string CRMAPI_LoyaltyVersion_1 { get; set; }
        public static string CRMAPI_LoyaltyVersion_2 { get; set; }
        public static string CRMAPI_LoyaltyVersion_3 { get; set; }
        public static string APICredentials { get; set; }
        public static string CRMAPI_btnExplore { get; set; }
        public static string CRMAPI_ParentAccList { get; set; }
        public static string CRMAPI_AccountLogin { get; set; }
        public static string CRMAPI_AccountLogin_Authentication { get; set; }
        public static string CRMAPI_AccountLogin_MasterPropertyCode { get; set; }
        public static string CRMAPI_AccountLogin_SubmitButton { get; set; }
        public static string CRMAPI_AccountRegister { get; set; }
        public static string CRMAPI_AccountRegister_RegisterAcc { get; set; }
        public static string CRMAPI_AccountRegister_MasterPropertyCode { get; set; }
        public static string CRMAPI_AccountRegister_RegisterButton { get; set; }
        #endregion[Test]

        #endregion[UI]

        #region [Admin_LoyaltyeGifts]
        public static string Admin_LoyaltyeGifts_Button_AddeGift { get; set; }
        public static string Admin_LoyaltyeGifts_Name { get; set; }
        public static string Admin_LoyaltyeGifts_Marketing_Partner { get; set; }
        public static string Admin_LoyaltyeGifts_Marketing_Partner_Input { get; set; }
        public static string Admin_LoyaltyeGifts_Award { get; set; }
        public static string Admin_LoyaltyeGifts_Choose_Catalog { get; set; }
        public static string Admin_LoyaltyeGifts_Card_Amount { get; set; }
        public static string Admin_LoyaltyeGifts_Button_Add { get; set; }
        public static string Admin_LoyaltyeGifts_Marketing_Partner_Tab { get; set; }
        public static string Admin_LoyaltyeGifts_Marketing_Partner_Edit { get; set; }
        public static string Admin_LoyaltyeGifts_Marketing_Partner_Notify { get; set; }
        public static string Admin_LoyaltyeGifts_Marketing_Partner_Notify_Save { get; set; }
        public static string Admin_Loyalty_Egift_tab { get; set; }
        public static string Admin_Loyalty_Egift_Account_Balance { get; set; }



        #endregion[Admin_LoyaltyeGifts]

        #region[Admin_Redeem]
        public static string Admin_Menu_Redeem_Edit { get; set; }

        public static string Admin_Menu_Redeem_Dropdown_Connect_To { get; set; }

        public static string Admin_Menu_Redeem_Button_Save { get; set; }
        #endregion[Admin_Redeem]

        #region[IndependentCollection]
        public static string Next_Link_IndependentCollection { get; set; }
        #endregion[IndependentCollection]

        #region[IndependentCollection]
        public static string SignIn_Email_Next_Button { get; set; }
        #endregion[IndependentCollection]
        #region[Admin_LoyaltyRule_QualifyingRule]
        public static string Loyalty_Rule_QualifyingRule_General_RuleName { get; set; }
        public static string Loyalty_Rule_QualifyingRule_General_Description { get; set; }
        public static string Loyalty_Rule_QualifyingRule_General_MinRevenue { get; set; }
        public static string Loyalty_Rule_QualifyingRule_General_ParallelStay { get; set; }
        public static string Loyalty_Rule_QualifyingRule_General_MarketCode { get; set; }
        public static string Loyalty_Rule_QualifyingRule_General_SourceOfBusiness { get; set; }
        public static string Loyalty_Rule_QualifyingRule_General_ChannelCode { get; set; }
        public static string Loyalty_Rule_QualifyingRule_General_ConsecutiveStays { get; set; }
        public static string Loyalty_Rule_QualifyingRule_General_SaveButton { get; set; }
        public static string Loyalty_Rule_QualifyingRule_Night_RuleName { get; set; }
        public static string Loyalty_Rule_QualifyingRule_Night_Description { get; set; }
        public static string Loyalty_Rule_QualifyingRule_Night_MinRevenue { get; set; }
        public static string Loyalty_Rule_QualifyingRule_Night_MarketCode { get; set; }
        public static string Loyalty_Rule_QualifyingRule_Night_Hotel { get; set; }
        public static string Loyalty_Rule_QualifyingRule_Night_RatesCodes { get; set; }
        public static string Loyalty_Rule_QualifyingRule_Night_MarketCombo { get; set; }
        public static string Loyalty_Rule_QualifyingRule_Night_RateCombo { get; set; }
        public static string Loyalty_Rule_QualifyingRule_Night_Include_Market_RateCombo { get; set; }
        public static string Loyalty_Rule_QualifyingRule_Night_SourceOfBusiness { get; set; }
        public static string Loyalty_Rule_QualifyingRule_Night_ChannelCode { get; set; }
        public static string Loyalty_Rule_QualifyingRule_Night_SaveButton { get; set; }
        public static string Loyalty_Rule_QualifyingRule_General_ChannelCode_Text { get; set; }
        public static string Loyalty_Rule_QualifyingRule_General_MarketCode_Text { get; set; }
        public static string Loyalty_Rule_QualifyingRule_General_SourceOfBusiness_Text { get; set; }
        public static string Loyalty_Rule_QualifyingRule_Night_MarketCode_Text { get; set; }
        public static string Loyalty_Rule_QualifyingRule_Night_Hotel_Text { get; set; }
        public static string Loyalty_Rule_QualifyingRule_Night_RatesCodes_Text { get; set; }
        public static string Loyalty_Rule_QualifyingRule_Night_SourceOfBusiness_Text { get; set; }
        public static string Loyalty_Rule_QualifyingRule_Night_ChannelCode_Text { get; set; }
        public static string Loyalty_Rule_QualifyingRule_General_SaveButton_Confirm { get; set; }
        public static string Loyalty_Rule_QualifyingRule_Night_SaveButton_Confirm { get; set; }

        #endregion[Admin_LoyaltyRule_QualifyingRule]
        #region[Admin_EmailSetup]
        public static string Button_EmailSetup_Add_Email { get; set; }
        public static string Filter_EmailSetup_SearchEmail { get; set; }
        public static string Button_EmailSetup_EditEmail { get; set; }
        public static string Input_EmailSetup_FromEmail { get; set; }
        public static string Button_EmailSetup_Save { get; set; }
        public static string Button_EmailSetup_Cancel { get; set; }
        #endregion[Admin_EmailSetup]

        #region[Admin_LoyaltyRule_RuleRestriction]
        public static string Enter_Rule_Restrict_MinRevenue { get; set; }
        public static string Enter_Rule_Restrict_MinRoomRevenue { get; set; }
        public static string Enter_Rule_Restrict_MinFandBRevenue { get; set; }
        public static string Enter_Rule_Restrict_MinotherRevenue { get; set; }
        public static string Enter_Rule_Restrict_MinNight { get; set; }
        public static string Enter_Rule_Restrict_MinStay { get; set; }
        public static string Enter_Rule_Restrict_MaxStay { get; set; }
        public static string Click_Rule_Restrict_MarketCode { get; set; }
        public static string Select_Rule_Restrict_MarketCode { get; set; }
        public static string Click_Rule_Restrict_RateCode { get; set; }
        public static string Select_Rule_Restrict_RateCode { get; set; }
        public static string Click_Rule_Restrict_Hotel { get; set; }
        public static string Select_Rule_Restrict_Hotel { get; set; }
        public static string Click_Rule_Restrict_RoomType { get; set; }
        public static string Select_Rule_Restrict_RoomType { get; set; }
        public static string Click_Rule_Restrict_SourceOfBusiness { get; set; }
        public static string Select_Rule_Restrict_SourceOfBusiness { get; set; }
        public static string Click_Rule_Restrict_ChannelCode { get; set; }
        public static string Select_Rule_Restrict_ChannelCode { get; set; }
        public static string Select_Rule_Restrict_BookingDate { get; set; }
        public static string Select_Rule_Restrict_BookingEndDate { get; set; }
        public static string Select_Rule_Restrict_JoinDate { get; set; }
        public static string Select_Rule_Restrict_JoinEndDate { get; set; }
        public static string Click_Rule_Restrict_MarketCombo { get; set; }
        public static string Select_Rule_Restrict_MarketCombo { get; set; }
        public static string Click_Rule_Restrict_RateCombo { get; set; }
        public static string Select_Rule_Restrict_RateCombo { get; set; }
        public static string Click_Rule_Restrict_SaveButton { get; set; }
        public static string Click_Rule_Restrict_CancelButton { get; set; }


        #endregion[Admin_LoyaltyRule_RuleRestriction]
        public static ObjectRepository ReadElement(string location, string nodeModule)
        {
            ObjectRepository obj = new ObjectRepository();
            XDocument doc = XDocument.Load(location);
            var query = doc.Descendants(nodeModule).Elements()
              .ToDictionary(x => x.Attribute("key").Value,
                  x => x.Value);

            foreach (KeyValuePair<string, string> pair in query)
            {
                #region[UI]

                #region[Admin]
                if (nodeModule == Constants.Admin)
                {
                    #region[Admin]
                    if (pair.Key == "Admin_Text_UserName")
                        Admin_Text_UserName = pair.Value;
                    else if (pair.Key == "Admin_Text_Password")
                        Admin_Text_Password = pair.Value;
                    else if (pair.Key == "Admin_Button_Login")
                        Admin_Button_Login = pair.Value;
                    else if (pair.Key == "Admin_Text_SearchEmail")
                        Admin_Text_SearchEmail = pair.Value;
                    else if (pair.Key == "Admin_Button_MemberSearch")
                        Admin_Button_MemberSearch = pair.Value;
                    else if (pair.Key == "Admin_Button_ClearSearch")
                        Admin_Button_ClearSearch = pair.Value;
                    else if (pair.Key == "Admin_Button_ViewMember")
                        Admin_Button_ViewMember = pair.Value;
                    else if (pair.Key == "Admin_Text_ViewMember")
                        Admin_Text_ViewMember = pair.Value;
                    else if (pair.Key == "Admin_Link_ActivationEmail")
                        Admin_Link_ActivationEmail = pair.Value;
                    else if (pair.Key == "Admin_Link_WelcomeEmail")
                        Admin_Link_WelcomeEmail = pair.Value;
                    else if (pair.Key == "Admin_Button_Activation_Save")
                        Admin_Button_Activation_Save = pair.Value;
                    else if (pair.Key == "Admin_Button_Welcome_Save")
                        Admin_Button_Welcome_Save = pair.Value;
                    else if (pair.Key == "Admin_Dropdown_MemberType")
                        Admin_Dropdown_MemberType = pair.Value;
                    else if (pair.Key == "Admin_Textbox_MemberNumber")
                        Admin_Textbox_MemberNumber = pair.Value;
                    else if (pair.Key == "Admin_Textbox_Lastname")
                        Admin_Textbox_Lastname = pair.Value;
                    else if (pair.Key == "Admin_Textbox_Firstname")
                        Admin_Textbox_Firstname = pair.Value;
                    else if (pair.Key == "Admin_Textbox_Last_Name")
                        Admin_Textbox_Last_Name = pair.Value;
                    else if (pair.Key == "Admin_Textbox_First_Name")
                        Admin_Textbox_First_Name = pair.Value;
                    else if (pair.Key == "Admin_Textbox_Email")
                        Admin_Textbox_Email = pair.Value;
                    else if (pair.Key == "Admin_Textbox_Street")
                        Admin_Textbox_Street = pair.Value;
                    else if (pair.Key == "Admin_Textbox_City")
                        Admin_Textbox_City = pair.Value;
                    else if (pair.Key == "Admin_Textbox_Zip")
                        Admin_Textbox_Zip = pair.Value;
                    else if (pair.Key == "Admin_Dropdown_Country")
                        Admin_Dropdown_Country = pair.Value;
                    else if (pair.Key == "Admin_Dropdown_State")
                        Admin_Dropdown_State = pair.Value;
                    else if (pair.Key == "Admin_Dropdown_AwardName")
                        Admin_Dropdown_AwardName = pair.Value;
                    else if (pair.Key == "Admin_Textbox_AwardNumber	")
                        Admin_Textbox_AwardNumber = pair.Value;
                    else if (pair.Key == "Admin_Textbox_CardName")
                        Admin_Textbox_CardName = pair.Value;
                    else if (pair.Key == "Admin_Textbox_Company")
                        Admin_Textbox_Company = pair.Value;
                    else if (pair.Key == "Admin_Textbox_Phone")
                        Admin_Textbox_Phone = pair.Value;
                    else if (pair.Key == "Admin_Dropdown_MemberStatus")
                        Admin_Dropdown_MemberStatus = pair.Value;
                    else if (pair.Key == "Admin_Value_MemberType")
                        Admin_Value_MemberType = pair.Value;
                    else if (pair.Key == "Admin_Value_MemberNumber")
                        Admin_Value_MemberNumber = pair.Value;
                    else if (pair.Key == "Admin_Value_Email")
                        Admin_Value_Email = pair.Value;
                    else if (pair.Key == "Admin_Value_FullName")
                        Admin_Value_FullName = pair.Value;
                    else if (pair.Key == "Admin_Value_Address")
                        Admin_Value_Address = pair.Value;
                    else if (pair.Key == "Admin_Value_Phone")
                        Admin_Value_Phone = pair.Value;
                    else if (pair.Key == "Admin_Value_CardName")
                        Admin_Value_CardName = pair.Value;
                    else if (pair.Key == "Admin_Value_MemberLevel")
                        Admin_Value_MemberLevel = pair.Value;
                    else if (pair.Key == "Admin_Value_Company")
                        Admin_Value_Company = pair.Value;
                    else if (pair.Key == "Admin_Value_Status")
                        Admin_Value_Status = pair.Value;
                    else if (pair.Key == "Admin_Textbox_Filter")
                        Admin_Textbox_Filter = pair.Value;
                    else if (pair.Key == "Admin_Dropdown_Pagination")
                        Admin_Dropdown_Pagination = pair.Value;
                    else if (pair.Key == "Admin_MemberInfo_MemberStays")
                        Admin_MemberInfo_MemberStays = pair.Value;
                    else if (pair.Key == "Admin_MemberInfo_SearchMemberStays")
                        Admin_MemberInfo_SearchMemberStays = pair.Value;
                    else if (pair.Key == "Admin_Arrow_Next")
                        Admin_Arrow_Next = pair.Value;
                    else if (pair.Key == "Admin_Arrow_Previous")
                        Admin_Arrow_Previous = pair.Value;
                    else if (pair.Key == "Admin_Menu_LoyaltyAwards")
                        Admin_Menu_LoyaltyAwards = pair.Value;
                    else if (pair.Key == "Admin_Button_Awards_Add")
                        Admin_Button_Awards_Add = pair.Value;
                    else if (pair.Key == "Admin_Text_Award_Name")
                        Admin_Text_Award_Name = pair.Value;
                    else if (pair.Key == "Admin_Text_Award_Search")
                        Admin_Text_Award_Search = pair.Value;
                    else if (pair.Key == "Admin_Text_Award_Code")
                        Admin_Text_Award_Code = pair.Value;
                    else if (pair.Key == "Admin_Text_Award_StartDate")
                        Admin_Text_Award_StartDate = pair.Value;
                    else if (pair.Key == "Admin_Text_Award_EndDate")
                        Admin_Text_Award_EndDate = pair.Value;
                    else if (pair.Key == "Admin_DropDown_Awardtype")
                        Admin_DropDown_Awardtype = pair.Value;
                    else if (pair.Key == "Admin_Text_DaysActive")
                        Admin_Text_DaysActive = pair.Value;
                    else if (pair.Key == "Admin_Text_AdvanceDeliveryDays")
                        Admin_Text_AdvanceDeliveryDays = pair.Value;
                    else if (pair.Key == "Admin_DropDown_MinQualifiedStay")
                        Admin_DropDown_MinQualifiedStay = pair.Value;
                    else if (pair.Key == "Admin_DropDown_MemberLevel")
                        Admin_DropDown_MemberLevel = pair.Value;
                    else if (pair.Key == "Admin_DropDown_EmailName")
                        Admin_DropDown_EmailName = pair.Value;
                    else if (pair.Key == "Admin_Award_Savebtn")
                        Admin_Award_Savebtn = pair.Value;
                    else if (pair.Key == "Admin_Button_Close")
                        Admin_Button_Close = pair.Value;
                    else if (pair.Key == "Admin_DropDown_NightCycle")
                        Admin_DropDown_NightCycle = pair.Value;
                    else if (pair.Key == "Admin_DropDown_NightAwarded")
                        Admin_DropDown_NightAwarded = pair.Value;
                    else if (pair.Key == "Admin_DropDown_NightExpMonth")
                        Admin_DropDown_NightExpMonth = pair.Value;
                    else if (pair.Key == "Admin_DropDown_NightHotels")
                        Admin_DropDown_NightHotels = pair.Value;
                    else if (pair.Key == "Enter_Text_MaxAwardperMember")
                        Enter_Text_MaxAwardperMember = pair.Value;
                    else if (pair.Key == "Dropdown_Value_Country")
                        Dropdown_Value_Country = pair.Value;
                    else if (pair.Key == "DropDown_value_State")
                        DropDown_value_State = pair.Value;
                    else if (pair.Key == "Admin_Attribute_state")
                        Admin_Attribute_state = pair.Value;
                    else if (pair.Key == "Admin_MemberInformation_Send_Email_Popup_Close")
                        Admin_MemberInformation_Send_Email_Popup_Close = pair.Value;
                    else if (pair.Key == "ClickOnLogin")
                        ClickOnLogin = pair.Value;
                    else if (pair.Key == "Click_On_Close")
                        Click_On_Close = pair.Value;
                    else if (pair.Key == "Admin_Dropdown_State_2")
                        Admin_Dropdown_State_2 = pair.Value;
                    else if (pair.Key == "Admin_Users_Text_Password")
                        Admin_Users_Text_Password = pair.Value;
                    else if (pair.Key == "Admin_ForgotPassword_LinkText")
                        Admin_ForgotPassword_LinkText = pair.Value;
                    else if (pair.Key == "Admin_Recovery_Email")
                        Admin_Recovery_Email = pair.Value;
                    else if (pair.Key == "Admin_ForgotPassword_Recover")
                        Admin_ForgotPassword_Recover = pair.Value;
                    else if (pair.Key == "Admin_NewPassword")
                        Admin_NewPassword = pair.Value;
                    else if (pair.Key == "Admin_NewPasswordConfirm")
                        Admin_NewPasswordConfirm = pair.Value;
                    else if (pair.Key == "SubmitNewPassword")
                        SubmitNewPassword = pair.Value;
                    else if (pair.Key == "Admin_MemberBatchUpload_Tab")
                        Admin_MemberBatchUpload_Tab = pair.Value;
                    else if (pair.Key == "Click_MemberBatchUpdate")
                        Click_MemberBatchUpdate = pair.Value;
                    else if (pair.Key == "Click_MemberBatchUpdate_UploadDateAndTime")
                        Click_MemberBatchUpdate_UploadDateAndTime = pair.Value;
                    else if (pair.Key == "BatchUpdate_DownloadTemplete")
                        BatchUpdate_DownloadTemplete = pair.Value;
                    else if (pair.Key == "BatchUpload_DownloadTemplete")
                        BatchUpload_DownloadTemplete = pair.Value;
                    else if (pair.Key == "BatchUpdate_UploadTemplete")
                        BatchUpdate_UploadTemplete = pair.Value;
                    else if (pair.Key == "BatchUpdate_UpdateTemplete")
                        BatchUpdate_UpdateTemplete = pair.Value;
                    else if (pair.Key == "BatchUpdate_UploadFile")
                        BatchUpdate_UploadFile = pair.Value;
                    else if (pair.Key == "BatchUpload_UploadFile")
                        BatchUpload_UploadFile = pair.Value;
                    else if (pair.Key == "BatchUpload_ClickonUpload")
                        BatchUpload_ClickonUpload = pair.Value;
                    else if (pair.Key == "Refreshbutton")
                        Refreshbutton = pair.Value;
                    else if (pair.Key == "MemberUploadedDetails")
                        MemberUploadedDetails = pair.Value;
                    else if (pair.Key == "BatchUploadRegistraion_Upload")
                        BatchUploadRegistraion_Upload = pair.Value;

                    else if (pair.Key == "Click_CloseButton_OnMemberBatchUpdateDetailsPopup")
                        Click_CloseButton_OnMemberBatchUpdateDetailsPopup = pair.Value;
                    else if (pair.Key == "BatchUpdate_UploadFiles")
                        BatchUpdate_UploadFiles = pair.Value;
                    else if (pair.Key == "UpdateRefreshbutton")
                        UpdateRefreshbutton = pair.Value;
                    else if (pair.Key == "MemberUpdateDetails")
                        MemberUpdateDetails = pair.Value;
                    else if (pair.Key == "Click_MemberSearchTab")
                        Click_MemberSearchTab = pair.Value;
                    else if (pair.Key == "Text_MemberShipId")
                        Text_MemberShipId = pair.Value;
                    else if (pair.Key == "Admin_Value_MemberNumber_Almanac")
                        Admin_Value_MemberNumber_Almanac = pair.Value;
                    else if (pair.Key == "Admin_MemberInformation_Tab")
                        Admin_MemberInformation_Tab = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyMapping_UploadLog_SubTab")
                        Admin_LoyaltyMapping_UploadLog_SubTab = pair.Value;
                    else if (pair.Key == "Dropdown_SelectStatus")
                        Dropdown_SelectStatus = pair.Value;
                    else if (pair.Key == "Click_AddAward")
                        Click_AddAward = pair.Value;
                    else if (pair.Key == "SelectStatusCheck")
                        SelectStatusCheck = pair.Value;
                    else if (pair.Key == "DeleteSelectedStatus")
                        DeleteSelectedStatus = pair.Value;
                    else if (pair.Key == "LoyaltyeGift_RemainingBalance")
                        LoyaltyeGift_RemainingBalance = pair.Value;
                    else if (pair.Key == "Click_Admin_AutomatedSwitch")
                        Click_Admin_AutomatedSwitch = pair.Value;
                    else if (pair.Key == "Click_Admin_AwardStatusSwitch")
                        Click_Admin_AwardStatusSwitch = pair.Value;
                    else if (pair.Key == "Admin_MemberAward_Previous_button")
                        Admin_MemberAward_Previous_button = pair.Value;
                    else if (pair.Key == "Click_Member_Level_Email_No_Button")
                        Click_Member_Level_Email_No_Button = pair.Value;
                    else if (pair.Key == "MemberLevel_CrossButton")
                        MemberLevel_CrossButton = pair.Value;
                    else if (pair.Key == "MemberLevel_Email_Overlay")
                        MemberLevel_Email_Overlay = pair.Value;
                    else if (pair.Key == "Admin_Update_View_Overlay_Close")
                        Admin_Update_View_Overlay_Close = pair.Value;
                    else if (pair.Key == "Click_MembershipSetup_Tab")
                        Click_MembershipSetup_Tab = pair.Value;
                    else if (pair.Key == "Click_MemberLevel_SubTab")
                        Click_MemberLevel_SubTab = pair.Value;
                    else if (pair.Key == "MembershipSetup_AddMemershipLevel_Button")
                        MembershipSetup_AddMemershipLevel_Button = pair.Value;
                    else if (pair.Key == "AddMemershipLevel_MembershipLevel")
                        AddMemershipLevel_MembershipLevel = pair.Value;
                    else if (pair.Key == "AddMemershipLevel_MembershipCode")
                        AddMemershipLevel_MembershipCode = pair.Value;
                    else if (pair.Key == "AddMemershipLevel_LevelOrder")
                        AddMemershipLevel_LevelOrder = pair.Value;
                    else if (pair.Key == "AddMemershipLevel_CanBeProcessedByService_DDM")
                        AddMemershipLevel_CanBeProcessedByService_DDM = pair.Value;
                    else if (pair.Key == "Click_AddMemershipLevel_CancelButton")
                        Click_AddMemershipLevel_CancelButton = pair.Value;
                    else if (pair.Key == "Click_AddMemershipLevel_SaveButton")
                        Click_AddMemershipLevel_SaveButton = pair.Value;
                    else if (pair.Key == "Click_DeleteMemershipLevel_SubmitButton")
                        Click_DeleteMemershipLevel_SubmitButton = pair.Value;
                    else if (pair.Key == "Click_AddMemershipLevel_Close")
                        Click_AddMemershipLevel_Close = pair.Value;
                    else if (pair.Key == "Click_DeleteMemershipLevel_CancelButton")
                        Click_DeleteMemershipLevel_CancelButton = pair.Value;
                    else if (pair.Key == "Click_Memberlevelrule_Tab")
                        Click_Memberlevelrule_Tab = pair.Value;
                    else if (pair.Key == "Click_AddRule_Button")
                        Click_AddRule_Button = pair.Value;
                    else if (pair.Key == "Select_MemberLevel_Dropdown")
                        Select_MemberLevel_Dropdown = pair.Value;
                    else if (pair.Key == "Select_RuleType_Dropdown")
                        Select_RuleType_Dropdown = pair.Value;
                    else if (pair.Key == "Select_StayType_Dropdown")
                        Select_StayType_Dropdown = pair.Value;
                    else if (pair.Key == "Select_DefaultRule_Dropdown")
                        Select_DefaultRule_Dropdown = pair.Value;
                    else if (pair.Key == "Enter_MonthPeriod_TextBox")
                        Enter_MonthPeriod_TextBox = pair.Value;
                    else if (pair.Key == "Enter_QualifyingNight_TextBox")
                        Enter_QualifyingNight_TextBox = pair.Value;
                    else if (pair.Key == "Enter_StayProperties_TextBox")
                        Enter_StayProperties_TextBox = pair.Value;
                    else if (pair.Key == "Enter_QualifiedStay_TextBox")
                        Enter_QualifiedStay_TextBox = pair.Value;
                    else if (pair.Key == "Enter_CheckedOutStay_TextBox")
                        Enter_CheckedOutStay_TextBox = pair.Value;
                    else if (pair.Key == "Enter_Points_TextBox")
                        Enter_Points_TextBox = pair.Value;
                    else if (pair.Key == "Enter_Revenue_TextBox")
                        Enter_Revenue_TextBox = pair.Value;
                    else if (pair.Key == "Click_MembershipLevelSave_Button")
                        Click_MembershipLevelSave_Button = pair.Value;
                    else if (pair.Key == "Click_MembershipLevelCancel_Button")
                        Click_MembershipLevelCancel_Button = pair.Value;
                    else if (pair.Key == "Click_MembershipLevelClose_Icon")
                        Click_MembershipLevelClose_Icon = pair.Value;
                    else if (pair.Key == "Enter_MemberLevelRule_Filter")
                        Enter_MemberLevelRule_Filter = pair.Value;
                    else if (pair.Key == "Click_MemberLevelRuleEdit_Button")
                        Click_MemberLevelRuleEdit_Button = pair.Value;
                    else if (pair.Key == "Click_LoyaltyRules_AwardEarningRules")
                        Click_LoyaltyRules_AwardEarningRules = pair.Value;
                    else if (pair.Key == "Click_AwardEarningRules_AddRuleButton")
                        Click_AwardEarningRules_AddRuleButton = pair.Value;
                    else if (pair.Key == "Click_AwardEarningRules_AddRule_IncludeMemberLevel")
                        Click_AwardEarningRules_AddRule_IncludeMemberLevel = pair.Value;
                    else if (pair.Key == "Click_AwardEarningRules_AddRule_CancelButton")
                        Click_AwardEarningRules_AddRule_CancelButton = pair.Value;
                    else if (pair.Key == "Click_MemberLevelRule_AddRuleButton")
                        Click_MemberLevelRule_AddRuleButton = pair.Value;
                    else if (pair.Key == "Click_MemberLevelRule_AddRuleButton_NewLevel")
                        Click_MemberLevelRule_AddRuleButton_NewLevel = pair.Value;
                    else if (pair.Key == "Click_MemberLevelRule_AddRuleButton_CancelButton")
                        Click_MemberLevelRule_AddRuleButton_CancelButton = pair.Value;

                    else if (pair.Key == "Click_DeleteMemershipLevelRule_SubmitButton")
                        Click_DeleteMemershipLevelRule_SubmitButton = pair.Value;
                    else if (pair.Key == "Click_DeleteMemberLevelRule_Button")
                        Click_DeleteMemberLevelRule_Button = pair.Value;
                    else if (pair.Key == "Click_DeleteMemershipLevelRule_CancelButton")
                        Click_DeleteMemershipLevelRule_CancelButton = pair.Value;
                    else if (pair.Key == "Click_EditMemberLevelRule_Button")
                        Click_EditMemberLevelRule_Button = pair.Value;

                    else if (pair.Key == "Admin_MemberBatchUpload_BtachRegistration_SubTab")
                        Admin_MemberBatchUpload_BtachRegistration_SubTab = pair.Value;

                    else if (pair.Key == "Admin_LoyaltyAwards_Member_Level_DeselectAll")
                        Admin_LoyaltyAwards_Member_Level_DeselectAll = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_Member_Level_SelectAll")
                        Admin_LoyaltyAwards_Member_Level_SelectAll = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_Member_Level_ClickDDM")
                        Admin_LoyaltyAwards_Member_Level_ClickDDM = pair.Value;
                    else if (pair.Key == "Click_LoyaltyRules_MemberLevelRules_Tab")
                        Click_LoyaltyRules_MemberLevelRules_Tab = pair.Value;
                    else if (pair.Key == "Click_LoyaltyRules_MemberLevelRules_AddRule")
                        Click_LoyaltyRules_MemberLevelRules_AddRule = pair.Value;
                    else if (pair.Key == "Click_LoyaltyRules_MemberLevelRules_Filters")
                        Click_LoyaltyRules_MemberLevelRules_Filters = pair.Value;
                    else if (pair.Key == "Click_LoyaltyRules_MemberLevelRules_AddRule_RefferalCode")
                        Click_LoyaltyRules_MemberLevelRules_AddRule_RefferalCode = pair.Value;
                    else if (pair.Key == "Click_LoyaltyRules_MemberLevelRules_AddRule_QualifyingNights")
                        Click_LoyaltyRules_MemberLevelRules_AddRule_QualifyingNights = pair.Value;
                    else if (pair.Key == "Click_LoyaltyRules_MemberLevelRules_AddRule_StayType")
                        Click_LoyaltyRules_MemberLevelRules_AddRule_StayType = pair.Value;
                    else if (pair.Key == "Click_LoyaltyRules_MemberLevelRules_AddRule_NewLevel")
                        Click_LoyaltyRules_MemberLevelRules_AddRule_NewLevel = pair.Value;
                    else if (pair.Key == "Click_LoyaltyRules_MemberLevelRules_AddRule_CancelButton")
                        Click_LoyaltyRules_MemberLevelRules_AddRule_CancelButton = pair.Value;
                    else if (pair.Key == "Click_LoyaltyRules_MemberLevelRules_AddRule_SaveButton")
                        Click_LoyaltyRules_MemberLevelRules_AddRule_SaveButton = pair.Value;
                    else if (pair.Key == "Click_LoyaltyRules_MemberLevelRules_EditButton")
                        Click_LoyaltyRules_MemberLevelRules_EditButton = pair.Value;
                    else if (pair.Key == "Click_LoyaltyRules_MemberLevelRules_DeleteButton")
                        Click_LoyaltyRules_MemberLevelRules_DeleteButton = pair.Value;
                    else if (pair.Key == "Click_LoyaltyRules_MemberLevelRules_PrevButton")
                        Click_LoyaltyRules_MemberLevelRules_PrevButton = pair.Value;
                    else if (pair.Key == "Click_LoyaltyRules_MemberLevelRules_NextButton")
                        Click_LoyaltyRules_MemberLevelRules_NextButton = pair.Value;
                    else if (pair.Key == "Click_LoyaltyRules_MemberLevelRules_DeleteConfirmButton")
                        Click_LoyaltyRules_MemberLevelRules_DeleteConfirmButton = pair.Value;
                    else if (pair.Key == "Click_LoyaltyRules_MemberLevelRules_PaginationDropdown")
                        Click_LoyaltyRules_MemberLevelRules_PaginationDropdown = pair.Value;
                    else if (pair.Key == "Click_LoyaltyRules_MemberLevelRules_DeleteCancle")
                        Click_LoyaltyRules_MemberLevelRules_DeleteCancle = pair.Value;
                    else if (pair.Key == "Click_LoyaltyRules_PointsEarningRule_RuleRestriction")
                        Click_LoyaltyRules_PointsEarningRule_RuleRestriction = pair.Value;
                    else if (pair.Key == "Click_LoyaltyRules_PointsEarningRule_RuleRestriction_ChannelCodeValue")
                        Click_LoyaltyRules_PointsEarningRule_RuleRestriction_ChannelCodeValue = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_Text_Points")
                        Admin_LoyaltyAwards_Text_Points = pair.Value;
                    else if (pair.Key == "Get_PointsEarningRule_GridName")
                        Get_PointsEarningRule_GridName = pair.Value;
                    else if (pair.Key == "Get_PointsEarningRule_GridPriority")
                        Get_PointsEarningRule_GridPriority = pair.Value;
                    else if (pair.Key == "Enter_Rule_Restrict_MinRevenue")
                        Enter_Rule_Restrict_MinRevenue = pair.Value;
                    else if (pair.Key == "Enter_Rule_Restrict_MinRoomRevenue")
                        Enter_Rule_Restrict_MinRoomRevenue = pair.Value;
                    else if (pair.Key == "Enter_Rule_Restrict_MinFandBRevenue")
                        Enter_Rule_Restrict_MinFandBRevenue = pair.Value;
                    else if (pair.Key == "Enter_Rule_Restrict_MinotherRevenue")
                        Enter_Rule_Restrict_MinotherRevenue = pair.Value;
                    else if (pair.Key == "Enter_Rule_Restrict_MinNight")
                        Enter_Rule_Restrict_MinNight = pair.Value;
                    else if (pair.Key == "Enter_Rule_Restrict_MinStay")
                        Enter_Rule_Restrict_MinStay = pair.Value;
                    else if (pair.Key == "Enter_Rule_Restrict_MaxStay")
                        Enter_Rule_Restrict_MaxStay = pair.Value;
                    else if (pair.Key == "Click_Rule_Restrict_MarketCode")
                        Click_Rule_Restrict_MarketCode = pair.Value;
                    else if (pair.Key == "Select_Rule_Restrict_MarketCode")
                        Select_Rule_Restrict_MarketCode = pair.Value;
                    else if (pair.Key == "Click_Rule_Restrict_RateCode")
                        Click_Rule_Restrict_RateCode = pair.Value;
                    else if (pair.Key == "Select_Rule_Restrict_RateCode")
                        Select_Rule_Restrict_RateCode = pair.Value;
                    else if (pair.Key == "Click_Rule_Restrict_Hotel")
                        Click_Rule_Restrict_Hotel = pair.Value;
                    else if (pair.Key == "Select_Rule_Restrict_Hotel")
                        Select_Rule_Restrict_Hotel = pair.Value;
                    else if (pair.Key == "Click_Rule_Restrict_RoomType")
                        Click_Rule_Restrict_RoomType = pair.Value;
                    else if (pair.Key == "Select_Rule_Restrict_RoomType")
                        Select_Rule_Restrict_RoomType = pair.Value;
                    else if (pair.Key == "Click_Rule_Restrict_SourceOfBusiness")
                        Click_Rule_Restrict_SourceOfBusiness = pair.Value;
                    else if (pair.Key == "Select_Rule_Restrict_SourceOfBusiness")
                        Select_Rule_Restrict_SourceOfBusiness = pair.Value;
                    else if (pair.Key == "Click_Rule_Restrict_ChannelCode")
                        Click_Rule_Restrict_ChannelCode = pair.Value;
                    else if (pair.Key == "Select_Rule_Restrict_ChannelCode")
                        Select_Rule_Restrict_ChannelCode = pair.Value;
                    else if (pair.Key == "Select_Rule_Restrict_BookingDate")
                        Select_Rule_Restrict_BookingDate = pair.Value;
                    else if (pair.Key == "Select_Rule_Restrict_BookingEndDate")
                        Select_Rule_Restrict_BookingEndDate = pair.Value;
                    else if (pair.Key == "Select_Rule_Restrict_JoinDate")
                        Select_Rule_Restrict_JoinDate = pair.Value;
                    else if (pair.Key == "Select_Rule_Restrict_JoinEndDate")
                        Select_Rule_Restrict_JoinEndDate = pair.Value;
                    else if (pair.Key == "Click_Rule_Restrict_MarketCombo")
                        Click_Rule_Restrict_MarketCombo = pair.Value;
                    else if (pair.Key == "Select_Rule_Restrict_MarketCombo")
                        Select_Rule_Restrict_MarketCombo = pair.Value;
                    else if (pair.Key == "Click_Rule_Restrict_RateCombo")
                        Click_Rule_Restrict_RateCombo = pair.Value;
                    else if (pair.Key == "Select_Rule_Restrict_RateCombo")
                        Select_Rule_Restrict_RateCombo = pair.Value;
                    else if (pair.Key == "Click_Rule_Restrict_SaveButton")
                        Click_Rule_Restrict_SaveButton = pair.Value;
                    else if (pair.Key == "Click_Rule_Restrict_CancelButton")
                        Click_Rule_Restrict_CancelButton = pair.Value;
                    else if (pair.Key == "Select_MembershipLevel_Entries")
                        Select_MembershipLevel_Entries = pair.Value;
                    else if (pair.Key == "Enter_MembershipLevel_Filter")
                        Enter_MembershipLevel_Filter = pair.Value;
                    else if (pair.Key == "Enter_AddMemershipLevel_Filter")
                        Enter_AddMemershipLevel_Filter = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Button_EditPromotion")
                        Admin_LoyaltySetUp_Offers_Button_EditPromotion = pair.Value;
                    else if (pair.Key == "Click_Member_Level_Email_Yes_Button")
                        Click_Member_Level_Email_Yes_Button = pair.Value;

                    #endregion[Admin]

                    #region[Admin_Navigations]
                    else if (pair.Key == "Admin_Tab_MemberTransactions")
                        Admin_Tab_MemberTransactions = pair.Value;
                    else if (pair.Key == "Admin_Tab_PointsHistory")
                        Admin_Tab_PointsHistory = pair.Value;
                    else if (pair.Key == "Admin_Tab_MemberAwards")
                        Admin_Tab_MemberAwards = pair.Value;
                    else if (pair.Key == "Admin_Tab_Invites")
                        Admin_Tab_Invites = pair.Value;
                    else if (pair.Key == "Admin_Tab_Redemptions")
                        Admin_Tab_Redemptions = pair.Value;
                    else if (pair.Key == "Admin_Tab_MemberStays")
                        Admin_Tab_MemberStays = pair.Value;
                    else if (pair.Key == "Admin_Tab_AdminUpdates")
                        Admin_Tab_AdminUpdates = pair.Value;
                    else if (pair.Key == "Click_AdminUpdates_Button_Close")
                        Click_AdminUpdates_Button_Close = pair.Value;
                    
                    else if (pair.Key == "Admin_Menu_LoyaltySetup")
                        Admin_Menu_LoyaltySetup = pair.Value;
                    else if (pair.Key == "Admin_Menu_Home")
                        Admin_Menu_Home = pair.Value;
                    else if (pair.Key == "Admin_Menu_Users")
                        Admin_Menu_Users = pair.Value;
                    else if (pair.Key == "Admin_submenu_Users_setting")
                        Admin_submenu_Users_setting = pair.Value;
                    else if (pair.Key == "Admin_Menu_EmailSetup")
                        Admin_Menu_EmailSetup = pair.Value;
                    else if (pair.Key == "Admin_Menu_ManualMerge")
                        Admin_Menu_ManualMerge = pair.Value;
                    else if (pair.Key == "Admin_Menu_LoyaltyRules")
                        Admin_Menu_LoyaltyRules = pair.Value;

                    else if (pair.Key == "Admin_LoyaltySetup_SubTab_TransactionReason")
                        Admin_LoyaltySetup_SubTab_TransactionReason = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetup_SubTab_SignUpSources")
                        Admin_LoyaltySetup_SubTab_SignUpSources = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetup_SubTab_TermsAndConditions")
                        Admin_LoyaltySetup_SubTab_TermsAndConditions = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetup_SubTab_Offers")
                        Admin_LoyaltySetup_SubTab_Offers = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyRules_SubTab_QualifyingRules")
                        Admin_LoyaltyRules_SubTab_QualifyingRules = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyRules_SubTab_PointsEarningRules")
                        Admin_LoyaltyRules_SubTab_PointsEarningRules = pair.Value;

                    else if (pair.Key == "Admin_Menu_LoyaltyeGifts")
                        Admin_Menu_LoyaltyeGifts = pair.Value;
                    else if (pair.Key == "Admin_Menu_ContentManagment_Tab")
                        Admin_Menu_ContentManagment_Tab = pair.Value;
                    else if (pair.Key == "Admin_Menu_LoyaltyMapping_Tab")
                        Admin_Menu_LoyaltyMapping_Tab = pair.Value;


                    #endregion

                    #region[Admin_MemberStay]
                    else if (pair.Key == "Admin_Dropdown_Entries")
                        Admin_Dropdown_Entries = pair.Value;
                    else if (pair.Key == "Admin_MemberStay_Button_Search")
                        Admin_MemberStay_Button_Search = pair.Value;
                    else if (pair.Key == "Admin_MemberStay_Dropdown_Property")
                        Admin_MemberStay_Dropdown_Property = pair.Value;
                    else if (pair.Key == "Admin_MemberStay_Value_Property")
                        Admin_MemberStay_Value_Property = pair.Value;
                    else if (pair.Key == "Admin_MemberStay_Button_SearchStay")
                        Admin_MemberStay_Button_SearchStay = pair.Value;
                    else if (pair.Key == "Admin_MemberStay_Value_DepartureFrom")
                        Admin_MemberStay_Value_DepartureFrom = pair.Value;
                    else if (pair.Key == "Admin_MemberStay_Value_DepartureTo")
                        Admin_MemberStay_Value_DepartureTo = pair.Value;
                    else if (pair.Key == "Admin_MemberStay_Text_FirstName")
                        Admin_MemberStay_Text_FirstName = pair.Value;
                    else if (pair.Key == "Admin_MemberStay_Text_LastName")
                        Admin_MemberStay_Text_LastName = pair.Value;
                    else if (pair.Key == "Admin_MemberStay_Text_ReservationNumber")
                        Admin_MemberStay_Text_ReservationNumber = pair.Value;
                    else if (pair.Key == "Admin_MemberStay_Data_ReservationNumber")
                        Admin_MemberStay_Data_ReservationNumber = pair.Value;
                    else if (pair.Key == "Admin_MemberStay_Data_Arrival")
                        Admin_MemberStay_Data_Arrival = pair.Value;
                    else if (pair.Key == "Admin_MemberStay_Data_Departure")
                        Admin_MemberStay_Data_Departure = pair.Value;
                    else if (pair.Key == "Admin_MemberStay_Data_Hotel")
                        Admin_MemberStay_Data_Hotel = pair.Value;
                    else if (pair.Key == "Admin_MemberStay_Tab_MemberID")
                        Admin_MemberStay_Tab_MemberID = pair.Value;
                    else if (pair.Key == "Admin_MemberStay_Checkbox_Select")
                        Admin_MemberStay_Checkbox_Select = pair.Value;
                    else if (pair.Key == "Admin_MemberStay_Button_Save")
                        Admin_MemberStay_Button_Save = pair.Value;
                    else if (pair.Key == "Admin_MemberStay_Button_Back")
                        Admin_MemberStay_Button_Back = pair.Value;
                    else if (pair.Key == "Enter_ReservationNumber")
                        Enter_ReservationNumber = pair.Value;
                    else if (pair.Key == "Admin_Icon_Next")
                        Admin_Icon_Next = pair.Value;
                    else if (pair.Key == "Admin_Icon_Previous")
                        Admin_Icon_Previous = pair.Value;
                    else if (pair.Key == "Admin_MemberStay_Text_Filter")
                        Admin_MemberStay_Text_Filter = pair.Value;
                    else if (pair.Key == "Admin_Memberupload_Text_Filter")
                        Admin_Memberupload_Text_Filter = pair.Value;

                    else if (pair.Key == "PropertyName")
                        PropertyName = pair.Value;
                    else if (pair.Key == "Admin_Memberupdate_Text_Filter")
                        Admin_Memberupdate_Text_Filter = pair.Value;
                    else if (pair.Key == "Admin_Bartell_MemberStay_Data_Arrival")
                        Admin_Bartell_MemberStay_Data_Arrival = pair.Value;

                    #endregion

                    #region[Admin_MemberInformation]
                    else if (pair.Key == "Admin_MemberInformation_Dropdown_MemberStatus")
                        Admin_MemberInformation_Dropdown_MemberStatus = pair.Value;
                    else if (pair.Key == "Admin_MemberInformation_Value_MemberStatus")
                        Admin_MemberInformation_Value_MemberStatus = pair.Value;
                    else if (pair.Key == "Admin_MemberInformation_Value_MemberLevel")
                        Admin_MemberInformation_Value_MemberLevel = pair.Value;
                    else if (pair.Key == "Admin_MemberInformation_Icon_Right")
                        Admin_MemberInformation_Icon_Right = pair.Value;
                    else if (pair.Key == "Admin_MemberInformation_Icon_Cross")
                        Admin_MemberInformation_Icon_Cross = pair.Value;
                    else if (pair.Key == "Admin_MemberInformation_Value_PointsBalance")
                        Admin_MemberInformation_Value_PointsBalance = pair.Value;
                    else if (pair.Key == "Admin_MemberInformation_Value_MemberLogin")
                        Admin_MemberInformation_Value_MemberLogin = pair.Value;
                    else if (pair.Key == "Admin_MemberInformation_Text_UserLogin")
                        Admin_MemberInformation_Text_UserLogin = pair.Value;
                    else if (pair.Key == "Admin_MemberInformation_Button_Update")
                        Admin_MemberInformation_Button_Update = pair.Value;
                    else if (pair.Key == "Admin_MemberInformation_ResetLogin_Icon_Close")
                        Admin_MemberInformation_ResetLogin_Icon_Close = pair.Value;
                    else if (pair.Key == "Admin_MemberInformation_Value_ActivationEmail")
                        Admin_MemberInformation_Value_ActivationEmail = pair.Value;
                    else if (pair.Key == "Admin_MemberInformation_ActivationEmail_UserLogin")
                        Admin_MemberInformation_ActivationEmail_UserLogin = pair.Value;
                    else if (pair.Key == "Admin_MemberInformation_Value_WelcomeEmail")
                        Admin_MemberInformation_Value_WelcomeEmail = pair.Value;
                    else if (pair.Key == "Admin_ActivationEmail_Icon_Close")
                        Admin_ActivationEmail_Icon_Close = pair.Value;
                    else if (pair.Key == "Admin_WelcomeEmail_Icon_Close")
                        Admin_WelcomeEmail_Icon_Close = pair.Value;
                    else if (pair.Key == "Admin_MemberInformation_WelcomeEmail_UserLogin")
                        Admin_MemberInformation_WelcomeEmail_UserLogin = pair.Value;
                    else if (pair.Key == "Admin_MemberInformation_Value_MemberPortal")
                        Admin_MemberInformation_Value_MemberPortal = pair.Value;
                    else if (pair.Key == "Admin_MemberInformation_Value_EmailStatus")
                        Admin_MemberInformation_Value_EmailStatus = pair.Value;
                    else if (pair.Key == "Admin_MemberInformation_Value_ActivatedDate")
                        Admin_MemberInformation_Value_ActivatedDate = pair.Value;
                    else if (pair.Key == "Admin_MemberInformation_Activation_Button_SendEmail")
                        Admin_MemberInformation_Activation_Button_SendEmail = pair.Value;
                    else if (pair.Key == "Admin_MemberInformation_Welcome_Button_SendEmail")
                        Admin_MemberInformation_Welcome_Button_SendEmail = pair.Value;
                    else if (pair.Key == "Admin_MemberInformation_Dropdown_EmailStatus")
                        Admin_MemberInformation_Dropdown_EmailStatus = pair.Value;
                    else if (pair.Key == "Admin_MemberInformation_Value_Email")
                        Admin_MemberInformation_Value_Email = pair.Value;
                    #endregion

                    #region[Admin_MemberTransaction]
                    else if (pair.Key == "Admin_MemberTransaction_Button_AddTransactions")
                        Admin_MemberTransaction_Button_AddTransactions = pair.Value;
                    else if (pair.Key == "Admin_MemberTransaction_Text_FilterSearch")
                        Admin_MemberTransaction_Text_FilterSearch = pair.Value;
                    else if (pair.Key == "Admin_MemberTransaction_Dropdown_Entries")
                        Admin_MemberTransaction_Dropdown_Entries = pair.Value;
                    else if (pair.Key == "Admin_MemberTransaction_Dropdown_TransactionReason")
                        Admin_MemberTransaction_Dropdown_TransactionReason = pair.Value;
                    else if (pair.Key == "Admin_MemberTransaction_Text_Points")
                        Admin_MemberTransaction_Text_Points = pair.Value;
                    else if (pair.Key == "Admin_MemberTransaction_Text_InternalComments")
                        Admin_MemberTransaction_Text_InternalComments = pair.Value;
                    else if (pair.Key == "Admin_MemberTransaction_DatePicker_ExpirationDate")
                        Admin_MemberTransaction_DatePicker_ExpirationDate = pair.Value;
                    else if (pair.Key == "Admin_MemberTransaction_Text_ExpirationDate")
                        Admin_MemberTransaction_Text_ExpirationDate = pair.Value;
                    else if (pair.Key == "Admin_MemberTransaction_Text_CommentsToGuest")
                        Admin_MemberTransaction_Text_CommentsToGuest = pair.Value;
                    else if (pair.Key == "Admin_MemberTransaction_RadioButton_SendEmailToMember")
                        Admin_MemberTransaction_RadioButton_SendEmailToMember = pair.Value;
                    else if (pair.Key == "Admin_MemberTransaction_RadioButton_AddCommentsToEmail")
                        Admin_MemberTransaction_RadioButton_AddCommentsToEmail = pair.Value;
                    else if (pair.Key == "Admin_MemberTransaction_Text_MemberEmail")
                        Admin_MemberTransaction_Text_MemberEmail = pair.Value;
                    else if (pair.Key == "Admin_MemberTransaction_Text_BCC")
                        Admin_MemberTransaction_Text_BCC = pair.Value;
                    else if (pair.Key == "Admin_MemberTransaction_RadioButton_FraserHospitality")
                        Admin_MemberTransaction_RadioButton_FraserHospitality = pair.Value;
                    else if (pair.Key == "Admin_MemberTransaction_RadioButton_Hotel")
                        Admin_MemberTransaction_RadioButton_Hotel = pair.Value;
                    else if (pair.Key == "Admin_MemberTransaction_Button_Save")
                        Admin_MemberTransaction_Button_Save = pair.Value;
                    else if (pair.Key == "Admin_MemberTransaction_Text_Hotel")
                        Admin_MemberTransaction_Text_Hotel = pair.Value;
                    else if (pair.Key == "Admin_MemberTransaction_Dropdown_Hotel")
                        Admin_MemberTransaction_Dropdown_Hotel = pair.Value;
                    else if (pair.Key == "Admin_MemberTransaction_Icon_Close")
                        Admin_MemberTransaction_Icon_Close = pair.Value;
                    else if (pair.Key == "Admin_MemberTransaction_Dropdown_Pagination")
                        Admin_MemberTransaction_Dropdown_Pagination = pair.Value;
                    else if (pair.Key == "Admin_MemberTransaction_Arrow_Next")
                        Admin_MemberTransaction_Arrow_Next = pair.Value;
                    else if (pair.Key == "Admin_MemberTransaction_Arrow_Previous")
                        Admin_MemberTransaction_Arrow_Previous = pair.Value;
                    #endregion

                    #region[Admin_AdminUpdates]
                    else if (pair.Key == "Admin_AdminUpdates_Dropdown_Entries")
                        Admin_AdminUpdates_Dropdown_Entries = pair.Value;
                    else if (pair.Key == "Admin_AdminUpdates_Text_Filter")
                        Admin_AdminUpdates_Text_Filter = pair.Value;
                    else if (pair.Key == "Admin_AdminUpdates_Icon_View1")
                        Admin_AdminUpdates_Icon_View1 = pair.Value;
                    else if (pair.Key == "Admin_AdminUpdates_Button_Next")
                        Admin_AdminUpdates_Button_Next = pair.Value;
                    else if (pair.Key == "Admin_AdminUpdates_Button_Last")
                        Admin_AdminUpdates_Button_Last = pair.Value;
                    else if (pair.Key == "Admin_AdminUpdates_Button_Prev")
                        Admin_AdminUpdates_Button_Prev = pair.Value;
                    else if (pair.Key == "Admin_AdminUpdates_Button_First")
                        Admin_AdminUpdates_Button_First = pair.Value;
                    else if (pair.Key == "Admin_AdminUpdates_Search_Clear")
                        Admin_AdminUpdates_Search_Clear = pair.Value;
                    #endregion

                    #region[Admin_MemberAwards]
                    else if (pair.Key == "Admin_MemberAwards_Button_AddAward")
                        Admin_MemberAwards_Button_AddAward = pair.Value;
                    else if (pair.Key == "Admin_MemberAwards_Dropdown_SelectAward")
                        Admin_MemberAwards_Dropdown_SelectAward = pair.Value;
                    else if (pair.Key == "Admin_MemberAwards_Text_Comment")
                        Admin_MemberAwards_Text_Comment = pair.Value;
                    else if (pair.Key == "Admin_MemberAwards_Button_Save")
                        Admin_MemberAwards_Button_Save = pair.Value;
                    else if (pair.Key == "Admin_MemberAwards_Icon_Close")
                        Admin_MemberAwards_Icon_Close = pair.Value;
                    else if (pair.Key == "Admin_MemberAwards_Text_Filter")
                        Admin_MemberAwards_Text_Filter = pair.Value;
                    else if (pair.Key == "Admin_Click_ExpirationDate")
                        Admin_Click_ExpirationDate = pair.Value;
                    else if (pair.Key == "Admin_Click_ExpirationDateSubmit")
                        Admin_Click_ExpirationDateSubmit = pair.Value;
                    else if (pair.Key == "Click_MemberAwardStatus")
                        Click_MemberAwardStatus = pair.Value;
                    else if (pair.Key == "Click_AdminSendResend")
                        Click_AdminSendResend = pair.Value;
                    else if (pair.Key == "click_ResendAwardEmail_Close")
                        click_ResendAwardEmail_Close = pair.Value;
                    #endregion

                    #region[LoyaltySetUp_TransactionReason]
                    else if (pair.Key == "Admin_LoyaltySetUp_TransactionReason_Button_AddReason")
                        Admin_LoyaltySetUp_TransactionReason_Button_AddReason = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_TransactionReason_Text_Code")
                        Admin_LoyaltySetUp_TransactionReason_Text_Code = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_TransactionReason_Text_Filter")
                        Admin_LoyaltySetUp_TransactionReason_Text_Filter = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_TransactionReason_Text_ReasonName")
                        Admin_LoyaltySetUp_TransactionReason_Text_ReasonName = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_TransactionReason_Button_Save")
                        Admin_LoyaltySetUp_TransactionReason_Button_Save = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_TransactionReason_Button_Cancel")
                        Admin_LoyaltySetUp_TransactionReason_Button_Cancel = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_TransactionReason_Icon_Close")
                        Admin_LoyaltySetUp_TransactionReason_Icon_Close = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_TransactionReason_Icon_Edit")
                        Admin_LoyaltySetUp_TransactionReason_Icon_Edit = pair.Value;
                    #endregion

                    #region[LoyaltySetUp_SignUpSource]
                    else if (pair.Key == "Admin_LoyaltySetUp_SignUpSource_Text_Filter")
                        Admin_LoyaltySetUp_SignUpSource_Text_Filter = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_SignUpSource_Icon_Edit")
                        Admin_LoyaltySetUp_SignUpSource_Icon_Edit = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_SignUpSource_Text_SignUpSourceCode")
                        Admin_LoyaltySetUp_SignUpSource_Text_SignUpSourceCode = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_SignUpSource_Text_SignUpSourceName")
                        Admin_LoyaltySetUp_SignUpSource_Text_SignUpSourceName = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_SignUpSource_Button_Save")
                        Admin_LoyaltySetUp_SignUpSource_Button_Save = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_SignUpSource_Button_Cancel")
                        Admin_LoyaltySetUp_SignUpSource_Button_Cancel = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_SignUpSource_Button_Close")
                        Admin_LoyaltySetUp_SignUpSource_Button_Close = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_SignUpSource_Button_AddSource")
                        Admin_LoyaltySetUp_SignUpSource_Button_AddSource = pair.Value;
                    #endregion

                    #region[LoyaltySetUp_TermsAndCondition]
                    else if (pair.Key == "Admin_LoyaltySetUp_TermsAndCondition_Button_AddTermsAndCondition")
                        Admin_LoyaltySetUp_TermsAndCondition_Button_AddTermsAndCondition = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_TermsAndCondition_Text_Filter")
                        Admin_LoyaltySetUp_TermsAndCondition_Text_Filter = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_TermsAndCondition_Icon_Edit")
                        Admin_LoyaltySetUp_TermsAndCondition_Icon_Edit = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_TermsAndCondition_Icon_Delete")
                        Admin_LoyaltySetUp_TermsAndCondition_Icon_Delete = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_TermsAndCondition_Text_Title")
                        Admin_LoyaltySetUp_TermsAndCondition_Text_Title = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_TermsAndCondition_Button_Save")
                        Admin_LoyaltySetUp_TermsAndCondition_Button_Save = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_TermsAndCondition_Button_Cancel")
                        Admin_LoyaltySetUp_TermsAndCondition_Button_Cancel = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_TermsAndCondition_Icon_Close")
                        Admin_LoyaltySetUp_TermsAndCondition_Icon_Close = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_TermsAndCondition_Button_Yes")
                        Admin_LoyaltySetUp_TermsAndCondition_Button_Yes = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_TermsAndCondition_Button_No")
                        Admin_LoyaltySetUp_TermsAndCondition_Button_No = pair.Value;
                    #endregion

                    #region[LoyaltyRules_PointsEarningRules]
                    else if (pair.Key == "Admin_LoyaltyRules_PointsEarningRules_Button_AddRule")
                        Admin_LoyaltyRules_PointsEarningRules_Button_AddRule = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyRules_PointsEarningRules_Text_Filter")
                        Admin_LoyaltyRules_PointsEarningRules_Text_Filter = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyRules_PointsEarningRules_Icon_Edit")
                        Admin_LoyaltyRules_PointsEarningRules_Icon_Edit = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyRules_PointsEarningRules_Text_Name")
                        Admin_LoyaltyRules_PointsEarningRules_Text_Name = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyRules_PointsEarningRules_Text_DisplayName")
                        Admin_LoyaltyRules_PointsEarningRules_Text_DisplayName = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyRules_PointsEarningRules_Text_Description")
                        Admin_LoyaltyRules_PointsEarningRules_Text_Description = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyRules_PointsEarningRules_Dropdown_BasedOn")
                        Admin_LoyaltyRules_PointsEarningRules_Dropdown_BasedOn = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyRules_PointsEarningRules_Text_StartDate")
                        Admin_LoyaltyRules_PointsEarningRules_Text_StartDate = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyRules_PointsEarningRules_Text_EndDate")
                        Admin_LoyaltyRules_PointsEarningRules_Text_EndDate = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyRules_PointsEarningRules_Text_Priority")
                        Admin_LoyaltyRules_PointsEarningRules_Text_Priority = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyRules_PointsEarningRules_Dropdown_RuleType")
                        Admin_LoyaltyRules_PointsEarningRules_Dropdown_RuleType = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyRules_PointsEarningRules_Dropdown_For")
                        Admin_LoyaltyRules_PointsEarningRules_Dropdown_For = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyRules_PointsEarningRules_Text_PointsEarned")
                        Admin_LoyaltyRules_PointsEarningRules_Text_PointsEarned = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyRules_PointsEarningRules_Text_Per")
                        Admin_LoyaltyRules_PointsEarningRules_Text_Per = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyRules_PointsEarningRules_Button_Cancel")
                        Admin_LoyaltyRules_PointsEarningRules_Button_Cancel = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyRules_PointsEarningRules_Icon_Close")
                        Admin_LoyaltyRules_PointsEarningRules_Icon_Close = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyRules_PointsEarningRules_Dropdown_IncludeMemberLevel")
                        Admin_LoyaltyRules_PointsEarningRules_Dropdown_IncludeMemberLevel = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyRules_PointsEarningRules_Dropdown_CaculatedOn")
                        Admin_LoyaltyRules_PointsEarningRules_Dropdown_CaculatedOn = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyRules_PointsEarningRules_Dropdown_RevenueType")
                        Admin_LoyaltyRules_PointsEarningRules_Dropdown_RevenueType = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyRules_PointsEarningRules_Text_IncludeMemberLevel")
                        Admin_LoyaltyRules_PointsEarningRules_Text_IncludeMemberLevel = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyRules_PointsEarningRules_Text_IncludeMemberLevel1")
                        Admin_LoyaltyRules_PointsEarningRules_Text_IncludeMemberLevel1 = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyRules_PointsEarningRules_Button_Save")
                        Admin_LoyaltyRules_PointsEarningRules_Button_Save = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyRules_PointsEarningRules_Text_PointsExpiryMonth")
                        Admin_LoyaltyRules_PointsEarningRules_Text_PointsExpiryMonth = pair.Value;
                    #endregion

                    #region[LoyaltySetUp_Offers]
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Button_AddOffers")
                        Admin_LoyaltySetUp_Offers_Button_AddOffers = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Text_Filter")
                        Admin_LoyaltySetUp_Offers_Text_Filter = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Icon_Edit")
                        Admin_LoyaltySetUp_Offers_Icon_Edit = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Text_Title")
                        Admin_LoyaltySetUp_Offers_Text_Title = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Text_Description")
                        Admin_LoyaltySetUp_Offers_Text_Description = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_IFrame_ShortDescription")
                        Admin_LoyaltySetUp_IFrame_ShortDescription = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Text_VisibilityStart")
                        Admin_LoyaltySetUp_Offers_Text_VisibilityStart = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Text_VisibilityEnd")
                        Admin_LoyaltySetUp_Offers_Text_VisibilityEnd = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Text_PromotionStart")
                        Admin_LoyaltySetUp_Offers_Text_PromotionStart = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Text_PromotionEnd")
                        Admin_LoyaltySetUp_Offers_Text_PromotionEnd = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Icon_Image")
                        Admin_LoyaltySetUp_Offers_Icon_Image = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Button_Save")
                        Admin_LoyaltySetUp_Offers_Button_Save = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Button_Cancel")
                        Admin_LoyaltySetUp_Offers_Button_Cancel = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Icon_Close")
                        Admin_LoyaltySetUp_Offers_Icon_Close = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Button_Yes")
                        Admin_LoyaltySetUp_Offers_Button_Yes = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Button_No")
                        Admin_LoyaltySetUp_Offers_Button_No = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Dropdown_MemberLevel")
                        Admin_LoyaltySetUp_Offers_Dropdown_MemberLevel = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Text_MemberLevel")
                        Admin_LoyaltySetUp_Offers_Text_MemberLevel = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Button_SelectAll")
                        Admin_LoyaltySetUp_Offers_Button_SelectAll = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Button_DeselectAll")
                        Admin_LoyaltySetUp_Offers_Button_DeselectAll = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Button_BrowseImage")
                        Admin_LoyaltySetUp_Offers_Button_BrowseImage = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Button_SaveImage")
                        Admin_LoyaltySetUp_Offers_Button_SaveImage = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Button_CancelImage")
                        Admin_LoyaltySetUp_Offers_Button_CancelImage = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Button_AddAnotherPromotion")
                        Admin_LoyaltySetUp_Offers_Button_AddAnotherPromotion = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Text_PromotionCode")
                        Admin_LoyaltySetUp_Offers_Text_PromotionCode = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Text_ButtonText")
                        Admin_LoyaltySetUp_Offers_Text_ButtonText = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Iframe_Description")
                        Admin_LoyaltySetUp_Offers_Iframe_Description = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Button_SavePromotion")
                        Admin_LoyaltySetUp_Offers_Button_SavePromotion = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Dropdown_HotelSelection")
                        Admin_LoyaltySetUp_Offers_Dropdown_HotelSelection = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Value_HotelSelection")
                        Admin_LoyaltySetUp_Offers_Value_HotelSelection = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Button_CancelPromotion")
                        Admin_LoyaltySetUp_Offers_Button_CancelPromotion = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Button_SavePromotionConfirm")
                        Admin_LoyaltySetUp_Offers_Button_SavePromotionConfirm = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Button_SavePromotionCancel")
                        Admin_LoyaltySetUp_Offers_Button_SavePromotionCancel = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Button_DeletePromotion")
                        Admin_LoyaltySetUp_Offers_Button_DeletePromotion = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Button_DeleteYes")
                        Admin_LoyaltySetUp_Offers_Button_DeleteYes = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Button_DeleteNo")
                        Admin_LoyaltySetUp_Offers_Button_DeleteNo = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Icon_PromotionDeleteClose")
                        Admin_LoyaltySetUp_Offers_Icon_PromotionDeleteClose = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Pagination_Dropdown")
                        Admin_LoyaltySetUp_Offers_Pagination_Dropdown = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Pagination_Prev_Button")
                        Admin_LoyaltySetUp_Offers_Pagination_Prev_Button = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_Offers_Pagination_Next_Button")
                        Admin_LoyaltySetUp_Offers_Pagination_Next_Button = pair.Value;
                    else if (pair.Key == "Click_LoyaltySetUp_Promotion_Filter")
                        Click_LoyaltySetUp_Promotion_Filter = pair.Value;
                    #endregion

                    #region[Admin_LoyaltyAwards]
                    else if (pair.Key == "Admin_LoyaltyAwards_Button_Add")
                        Admin_LoyaltyAwards_Button_Add = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_Text_Filter")
                        Admin_LoyaltyAwards_Text_Filter = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_Icon_Edit")
                        Admin_LoyaltyAwards_Icon_Edit = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_Text_AwardName")
                        Admin_LoyaltyAwards_Text_AwardName = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_Text_AwardCode")
                        Admin_LoyaltyAwards_Text_AwardCode = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_Text_StartDate")
                        Admin_LoyaltyAwards_Text_StartDate = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_Text_EndDate")
                        Admin_LoyaltyAwards_Text_EndDate = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_Dropdown_AwardType")
                        Admin_LoyaltyAwards_Dropdown_AwardType = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_Button_Cancel")
                        Admin_LoyaltyAwards_Button_Cancel = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_Button_Save")
                        Admin_LoyaltyAwards_Button_Save = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_Icon_Close")
                        Admin_LoyaltyAwards_Icon_Close = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_BirthdayAward_Text_DaysActive")
                        Admin_LoyaltyAwards_BirthdayAward_Text_DaysActive = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_BirthdayAward_Text_AdvanceDeliveryDays")
                        Admin_LoyaltyAwards_BirthdayAward_Text_AdvanceDeliveryDays = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_BirthdayAward_Text_MinQualifiedStay")
                        Admin_LoyaltyAwards_BirthdayAward_Text_MinQualifiedStay = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_BirthdayAward_Dropdown_MemberLevel")
                        Admin_LoyaltyAwards_BirthdayAward_Dropdown_MemberLevel = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_BirthdayAward_Text_MemberLevel")
                        Admin_LoyaltyAwards_BirthdayAward_Text_MemberLevel = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_BirthdayAward_Dropdown_EmailName")
                        Admin_LoyaltyAwards_BirthdayAward_Dropdown_EmailName = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_NightBasedAward_Text_NightCycle")
                        Admin_LoyaltyAwards_NightBasedAward_Text_NightCycle = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_NightBasedAward_Dropdown_NightAwarded")
                        Admin_LoyaltyAwards_NightBasedAward_Dropdown_NightAwarded = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_NightBasedAward_Text_NightAwarded")
                        Admin_LoyaltyAwards_NightBasedAward_Text_NightAwarded = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_NightBasedAward_Dropdown_AwardExpMonth")
                        Admin_LoyaltyAwards_NightBasedAward_Dropdown_AwardExpMonth = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_NightBasedAward_Dropdown_MemberLevel")
                        Admin_LoyaltyAwards_NightBasedAward_Dropdown_MemberLevel = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_NightBasedAward_Text_MemberLevel")
                        Admin_LoyaltyAwards_NightBasedAward_Text_MemberLevel = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_NightBasedAward_Text_MaxAwardPerNight")
                        Admin_LoyaltyAwards_NightBasedAward_Text_MaxAwardPerNight = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_NightBasedAward_Dropdown_Hotel")
                        Admin_LoyaltyAwards_NightBasedAward_Dropdown_Hotel = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyAwards_NightBasedAward_Text_Hotel")
                        Admin_LoyaltyAwards_NightBasedAward_Text_Hotel = pair.Value;

                    else if (pair.Key == "Admin_CheckBox_Use_As_EGift")
                        Admin_CheckBox_Use_As_EGift = pair.Value;
                    else if (pair.Key == "Admin_Text_PointsCost")
                        Admin_Text_PointsCost = pair.Value;
                    else if (pair.Key == "Admin_DropDown_AwardExpMonth")
                        Admin_DropDown_AwardExpMonth = pair.Value;

                    else if (pair.Key == "Admin_LoyaltyAwards_Member_Level")
                        Admin_LoyaltyAwards_Member_Level = pair.Value;

                    else if (pair.Key == "Admin_LoyaltyAwards_Dropdown_ExpMonth")
                        Admin_LoyaltyAwards_Dropdown_ExpMonth = pair.Value;

                    else if (pair.Key == "Admin_LoyaltyAwards_Dropdown_ExpDay")
                        Admin_LoyaltyAwards_Dropdown_ExpDay = pair.Value;

                    else if (pair.Key == "Admin_LoyaltyAwards_Dropdown_ExpYear")
                        Admin_LoyaltyAwards_Dropdown_ExpYear = pair.Value;

                    else if (pair.Key == "Admin_LoyaltyAwards_Dropdown_AdminMemberStatus")
                        Admin_LoyaltyAwards_Dropdown_AdminMemberStatus = pair.Value;


                    #endregion[Admin_LoyaltyAwards]

                    #region[Admin_LoyaltyeGifts]
                    else if (pair.Key == "Admin_LoyaltyeGifts_Button_AddeGift")
                        Admin_LoyaltyeGifts_Button_AddeGift = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyeGifts_Name")
                        Admin_LoyaltyeGifts_Name = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyeGifts_Marketing_Partner")
                        Admin_LoyaltyeGifts_Marketing_Partner = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyeGifts_Marketing_Partner_Input")
                        Admin_LoyaltyeGifts_Marketing_Partner_Input = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyeGifts_Award")
                        Admin_LoyaltyeGifts_Award = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyeGifts_Choose_Catalog")
                        Admin_LoyaltyeGifts_Choose_Catalog = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyeGifts_Card_Amount")
                        Admin_LoyaltyeGifts_Card_Amount = pair.Value;
                    else if (pair.Key == "Admin_LoyaltyeGifts_Button_Add")
                        Admin_LoyaltyeGifts_Button_Add = pair.Value;
                    else if (pair.Key == "Admin_Loyalty_Egift_tab")
                        Admin_Loyalty_Egift_tab = pair.Value;
                    else if (pair.Key == "Admin_Loyalty_Egift_Account_Balance")
                        Admin_Loyalty_Egift_Account_Balance = pair.Value;
                    #endregion[Admin_LoyaltyeGifts]

                    #region[Admin_Redeem]
                    else if (pair.Key == "Admin_Menu_Redeem")
                        Admin_Menu_Redeem = pair.Value;
                    else if (pair.Key == "Admin_Menu_Redeem_Edit")
                        Admin_Menu_Redeem_Edit = pair.Value;
                    else if (pair.Key == "Admin_Menu_Redeem_Dropdown_Connect_To")
                        Admin_Menu_Redeem_Dropdown_Connect_To = pair.Value;
                    else if (pair.Key == "Admin_Menu_Redeem_Button_Save")
                        Admin_Menu_Redeem_Button_Save = pair.Value;
                    else if (pair.Key == "Button_Add_Redemption")
                        Button_Add_Redemption = pair.Value;
                    else if (pair.Key == "Name_InputBox_Add_Redemption")
                        Name_InputBox_Add_Redemption = pair.Value;
                    else if (pair.Key == "ConnectTo_InputBox_Add_Redemption")
                        ConnectTo_InputBox_Add_Redemption = pair.Value;
                    else if (pair.Key == "Button_InputBox_Add_Redemption")
                        Button_InputBox_Add_Redemption = pair.Value;

                    else if (pair.Key == "Redeem_FilterSearch")
                        Redeem_FilterSearch = pair.Value;
                    else if (pair.Key == "Get_RedeemptionName")
                        Get_RedeemptionName = pair.Value;
                    else if (pair.Key == "Get_AwardLinkName")
                        Get_AwardLinkName = pair.Value;


                    #endregion[Admin_Redeem]

                    #region[Admin_EmailSetUp]
                    else if (pair.Key == "Admin_EmailSetUp_Text_Filter")
                        Admin_EmailSetUp_Text_Filter = pair.Value;
                    else if (pair.Key == "Admin_EmailSetUp_Icon_Edit")
                        Admin_EmailSetUp_Icon_Edit = pair.Value;
                    else if (pair.Key == "Admin_EmailSetUp_Text_EmailName")
                        Admin_EmailSetUp_Text_EmailName = pair.Value;
                    else if (pair.Key == "Admin_EmailSetUp_Text_EmailSubject")
                        Admin_EmailSetUp_Text_EmailSubject = pair.Value;
                    else if (pair.Key == "Admin_EmailSetUp_IFrame_EmailContent")
                        Admin_EmailSetUp_IFrame_EmailContent = pair.Value;
                    else if (pair.Key == "Admin_EmailSetUp_Text_EmailContent")
                        Admin_EmailSetUp_Text_EmailContent = pair.Value;
                    else if (pair.Key == "Admin_EmailSetUp_IFrame_TermsAndCondition")
                        Admin_EmailSetUp_IFrame_TermsAndCondition = pair.Value;
                    else if (pair.Key == "Admin_EmailSetUp_Text_TermsAndCondition")
                        Admin_EmailSetUp_Text_TermsAndCondition = pair.Value;
                    else if (pair.Key == "Admin_EmailSetUp_RadioButton_EmailStatus_Active")
                        Admin_EmailSetUp_RadioButton_EmailStatus_Active = pair.Value;
                    else if (pair.Key == "Admin_EmailSetUp_RadioButton_EmailStatus_InActive")
                        Admin_EmailSetUp_RadioButton_EmailStatus_InActive = pair.Value;
                    else if (pair.Key == "Admin_EmailSetUp_Button_Save")
                        Admin_EmailSetUp_Button_Save = pair.Value;
                    else if (pair.Key == "Admin_EmailSetUp_Button_Cancel")
                        Admin_EmailSetUp_Button_Cancel = pair.Value;
                    else if (pair.Key == "Activation_Email_Link_Button")
                        Activation_Email_Link_Button = pair.Value;
                    else if (pair.Key == "Activation_Email_Link")
                        Activation_Email_Link = pair.Value;
                    else if (pair.Key == "ForgotPassword_Email_Link")
                        ForgotPassword_Email_Link = pair.Value;
                    #endregion

                    #region[Admin_Users]
                    else if (pair.Key == "Admin_Users_Text_Search")
                        Admin_Users_Text_Search = pair.Value;
                    else if (pair.Key == "Admin_Users_Text_Firstname")
                        Admin_Users_Text_Firstname = pair.Value;
                    else if (pair.Key == "Admin_Users_Text_Lastname")
                        Admin_Users_Text_Lastname = pair.Value;
                    else if (pair.Key == "Admin_Users_Dropdown_UserTitle")
                        Admin_Users_Dropdown_UserTitle = pair.Value;
                    else if (pair.Key == "Admin_Users_Dropdown_UserPermission")
                        Admin_Users_Dropdown_UserPermission = pair.Value;
                    else if (pair.Key == "AdminorgotPassword_Recovery")
                        AdminorgotPassword_Recovery = pair.Value;
                    else if (pair.Key == "Admin_Users_Text_UserLogin")
                        Admin_Users_Text_UserLogin = pair.Value;
                    else if (pair.Key == "Admin_Users_Dropdown_PropertyName")
                        Admin_Users_Dropdown_PropertyName = pair.Value;
                    else if (pair.Key == "Admin_Users_Button_Save")
                        Admin_Users_Button_Save = pair.Value;
                    else if (pair.Key == "Admin_Users_Button_Close")
                        Admin_Users_Button_Close = pair.Value;
                    else if (pair.Key == "Admin_Users_Button_Edit")
                        Admin_Users_Button_Edit = pair.Value;
                    else if (pair.Key == "Admin_Users_Button_Delete")
                        Admin_Users_Button_Delete = pair.Value;
                    else if (pair.Key == "Admin_Users_Button_AddUsers")
                        Admin_Users_Button_AddUsers = pair.Value;
                    #endregion

                    #region[Admin_ManualMerge]
                    else if (pair.Key == "Admin_ManualMerge_Text_MemberID")
                        Admin_ManualMerge_Text_MemberID = pair.Value;
                    else if (pair.Key == "Admin_ManualMerge_Text_Firstname")
                        Admin_ManualMerge_Text_Firstname = pair.Value;
                    else if (pair.Key == "Admin_ManualMerge_Text_Lastname")
                        Admin_ManualMerge_Text_Lastname = pair.Value;
                    else if (pair.Key == "Admin_ManualMerge_Text_Email")
                        Admin_ManualMerge_Text_Email = pair.Value;
                    else if (pair.Key == "Admin_ManualMerge_Text_Street")
                        Admin_ManualMerge_Text_Street = pair.Value;
                    else if (pair.Key == "Admin_ManualMerge_Text_City")
                        Admin_ManualMerge_Text_City = pair.Value;
                    else if (pair.Key == "Admin_ManualMerge_Text_Zip")
                        Admin_ManualMerge_Text_Zip = pair.Value;
                    else if (pair.Key == "Admin_ManualMerge_Button_SearchMember")
                        Admin_ManualMerge_Button_SearchMember = pair.Value;
                    else if (pair.Key == "Admin_ManualMerge_Button_ClearSearch")
                        Admin_ManualMerge_Button_ClearSearch = pair.Value;
                    else if (pair.Key == "Admin_ManualMerge_Button_Review")
                        Admin_ManualMerge_Button_Review = pair.Value;
                    else if (pair.Key == "Admin_ManualMerge_Button_Cancel")
                        Admin_ManualMerge_Button_Cancel = pair.Value;
                    else if (pair.Key == "Admin_ManualMerge_Button_Merge")
                        Admin_ManualMerge_Button_Merge = pair.Value;
                    else if (pair.Key == "Admin_ManualMerge_Icon_Select1")
                        Admin_ManualMerge_Icon_Select1 = pair.Value;
                    else if (pair.Key == "Admin_ManualMerge_Tab_AccountWinner1")
                        Admin_ManualMerge_Tab_AccountWinner1 = pair.Value;
                    else if (pair.Key == "Admin_ManualMerge_RadioButton_AccountWinner1")
                        Admin_ManualMerge_RadioButton_AccountWinner1 = pair.Value;
                    else if (pair.Key == "Admin_ManualMerge_RadioButton_AccountWinner2")
                        Admin_ManualMerge_RadioButton_AccountWinner2 = pair.Value;
                    else if (pair.Key == "Admin_ManualMerge_Tab_AccountWinner1_Points")
                        Admin_ManualMerge_Tab_AccountWinner1_Points = pair.Value;
                    else if (pair.Key == "Admin_ManualMerge_Tab_AccountWinner2_Points")
                        Admin_ManualMerge_Tab_AccountWinner2_Points = pair.Value;
                    else if (pair.Key == "Admin_ManualMerge_Button_Back")
                        Admin_ManualMerge_Button_Back = pair.Value;
                    else if (pair.Key == "Admin_ManualMergeReview_Button_Merge")
                        Admin_ManualMergeReview_Button_Merge = pair.Value;
                    else if (pair.Key == "Admin_ManualMergeReview_Button_Confirm")
                        Admin_ManualMergeReview_Button_Confirm = pair.Value;
                    else if (pair.Key == "Admin_ManualMergeReview_Button_Cancel")
                        Admin_ManualMergeReview_Button_Cancel = pair.Value;
                    else if (pair.Key == "Admin_ManualMerge_SubTab_ManualMerge")
                        Admin_ManualMerge_SubTab_ManualMerge = pair.Value;
                    else if (pair.Key == "Admin_ManualMerge_Value_AccountWinner1_Email")
                        Admin_ManualMerge_Value_AccountWinner1_Email = pair.Value;
                    else if (pair.Key == "Admin_ManualMerge_Value_AccountWinner2_Email")
                        Admin_ManualMerge_Value_AccountWinner2_Email = pair.Value;
                    else if (pair.Key == "Admin_ManualMerge_Value_Status")
                        Admin_ManualMerge_Value_Status = pair.Value;
                    else if (pair.Key == "MembershipLevel")
                        MembershipLevel = pair.Value;
                    else if (pair.Key == "Admin_ManualMerge_MemberMerge_SubTab")
                        Admin_ManualMerge_MemberMerge_SubTab = pair.Value;


                    #endregion[Admin_ManualMerge]

                    #region[Admi LoyaltySetup]
                    else if (pair.Key == "Admin_LoyaltySetUp_TermsAndCondition_Description")
                        Admin_LoyaltySetUp_TermsAndCondition_Description = pair.Value;
                    else if (pair.Key == "Admin_LoyaltySetUp_TermsAndCondition_Add_TermsAndCondition")
                        Admin_LoyaltySetUp_TermsAndCondition_Add_TermsAndCondition = pair.Value;
                    #endregion[Admi LoyaltySetup]

                    #region[Admin_LoyaltyRule_QualifyingRule]
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_General_RuleName")
                        Loyalty_Rule_QualifyingRule_General_RuleName = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_General_Description")
                        Loyalty_Rule_QualifyingRule_General_Description = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_General_MinRevenue")
                        Loyalty_Rule_QualifyingRule_General_MinRevenue = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_General_ParallelStay")
                        Loyalty_Rule_QualifyingRule_General_ParallelStay = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_General_MarketCode")
                        Loyalty_Rule_QualifyingRule_General_MarketCode = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_General_SourceOfBusiness")
                        Loyalty_Rule_QualifyingRule_General_SourceOfBusiness = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_General_ChannelCode")
                        Loyalty_Rule_QualifyingRule_General_ChannelCode = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_General_ConsecutiveStays")
                        Loyalty_Rule_QualifyingRule_General_ConsecutiveStays = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_General_SaveButton")
                        Loyalty_Rule_QualifyingRule_General_SaveButton = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_Night_RuleName")
                        Loyalty_Rule_QualifyingRule_Night_RuleName = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_Night_Description")
                        Loyalty_Rule_QualifyingRule_Night_Description = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_Night_MinRevenue")
                        Loyalty_Rule_QualifyingRule_Night_MinRevenue = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_Night_MarketCode")
                        Loyalty_Rule_QualifyingRule_Night_MarketCode = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_Night_Hotel")
                        Loyalty_Rule_QualifyingRule_Night_Hotel = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_Night_RatesCodes")
                        Loyalty_Rule_QualifyingRule_Night_RatesCodes = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_Night_MarketCombo")
                        Loyalty_Rule_QualifyingRule_Night_MarketCombo = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_Night_RateCombo")
                        Loyalty_Rule_QualifyingRule_Night_RateCombo = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_Night_Include_Market_RateCombo")
                        Loyalty_Rule_QualifyingRule_Night_Include_Market_RateCombo = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_Night_SourceOfBusiness")
                        Loyalty_Rule_QualifyingRule_Night_SourceOfBusiness = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_Night_ChannelCode")
                        Loyalty_Rule_QualifyingRule_Night_ChannelCode = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_General_ChannelCode_Text")
                        Loyalty_Rule_QualifyingRule_General_ChannelCode_Text = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_General_MarketCode_Text")
                        Loyalty_Rule_QualifyingRule_General_MarketCode_Text = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_General_SourceOfBusiness_Text")
                        Loyalty_Rule_QualifyingRule_General_SourceOfBusiness_Text = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_Night_MarketCode_Text")
                        Loyalty_Rule_QualifyingRule_Night_MarketCode_Text = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_Night_Hotel_Text")
                        Loyalty_Rule_QualifyingRule_Night_Hotel_Text = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_Night_RatesCodes_Text")
                        Loyalty_Rule_QualifyingRule_Night_RatesCodes_Text = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_Night_SourceOfBusiness_Text")
                        Loyalty_Rule_QualifyingRule_Night_SourceOfBusiness_Text = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_Night_ChannelCode_Text")
                        Loyalty_Rule_QualifyingRule_Night_ChannelCode_Text = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_General_SaveButton_Confirm")
                        Loyalty_Rule_QualifyingRule_General_SaveButton_Confirm = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_Night_SaveButton_Confirm")
                        Loyalty_Rule_QualifyingRule_Night_SaveButton_Confirm = pair.Value;
                    else if (pair.Key == "Loyalty_Rule_QualifyingRule_Night_SaveButton")
                        Loyalty_Rule_QualifyingRule_Night_SaveButton = pair.Value;
                    #endregion[Admin_LoyaltyRule_QualifyingRule]

                    #region[Admin_EmailSetup]
                    else if (pair.Key == "Button_EmailSetup_Add_Email")
                        Button_EmailSetup_Add_Email = pair.Value;
                    else if (pair.Key == "Filter_EmailSetup_SearchEmail")
                        Filter_EmailSetup_SearchEmail = pair.Value;
                    else if (pair.Key == "Button_EmailSetup_EditEmail")
                        Button_EmailSetup_EditEmail = pair.Value;
                    else if (pair.Key == "Input_EmailSetup_FromEmail")
                        Input_EmailSetup_FromEmail = pair.Value;
                    else if (pair.Key == "Button_EmailSetup_Save")
                        Button_EmailSetup_Save = pair.Value;
                    else if (pair.Key == "Button_EmailSetup_Cancel")
                        Button_EmailSetup_Cancel = pair.Value;
                    #endregion[Admin_EmailSetup]
                }

                #endregion[Admin]                           

                #region[SignIn]
                if (nodeModule == Constants.SignIn)
                {
                    if (pair.Key == "SignIn_Text_Email")
                        SignIn_Text_Email = pair.Value;
                    else if (pair.Key == "SignIn_Text_Password")
                        SignIn_Text_Password = pair.Value;
                    else if (pair.Key == "Login_SSO")
                        Login_SSO = pair.Value;
                    else if (pair.Key == "SignIn_Button_LogIn")
                        SignIn_Button_LogIn = pair.Value;
                    else if (pair.Key == "SignIn_Button_LogIn2")
                        SignIn_Button_LogIn2 = pair.Value;
                    else if (pair.Key == "SignIn_Button_LogIn3")
                        SignIn_Button_LogIn3 = pair.Value;
                    else if (pair.Key == "SignIn_Link_ForgotYourLogin")
                        SignIn_Link_ForgotYourLogin = pair.Value;
                    else if (pair.Key == "SignIn_Link_ForgotYourLogin2")
                        SignIn_Link_ForgotYourLogin2 = pair.Value;
                    else if (pair.Key == "SignIn_Link_SignInFacebook")
                        SignIn_Link_SignInFacebook = pair.Value;
                    else if (pair.Key == "SignIn_Link_SignInTwitter")
                        SignIn_Link_SignInTwitter = pair.Value;
                    else if (pair.Key == "SignIn_Button_SignUp")
                        SignIn_Button_SignUp = pair.Value;
                    else if (pair.Key == "SignIn_Button_PasswordRecovery")
                        SignIn_Button_PasswordRecovery = pair.Value;
                    else if (pair.Key == "SignIn_Link_ChangePassword")
                        SignIn_Link_ChangePassword = pair.Value;
                    else if (pair.Key == "SignIn_Text_ConfirmNewPassword")
                        SignIn_Text_ConfirmNewPassword = pair.Value;
                    else if (pair.Key == "SignIn_Button_ResetPassword")
                        SignIn_Button_ResetPassword = pair.Value;
                    else if (pair.Key == "SignIn_LinkText_Clickhere")
                        SignIn_LinkText_Clickhere = pair.Value;
                    else if (pair.Key == "SignIn_ValidationMessage")
                        SignIn_ValidationMessage = pair.Value;
                    else if (pair.Key == "SignIn_Email_Error_Message")
                        SignIn_Email_Error_Message = pair.Value;
                    else if (pair.Key == "SignIn_Frequently_Asked_Questions")
                        SignIn_Frequently_Asked_Questions = pair.Value;
                    else if (pair.Key == "Navigation_Link_MyAccount_Dropdown")
                        Navigation_Link_MyAccount_Dropdown = pair.Value;
                    else if (pair.Key == "SignIn_Footer")
                        SignIn_Footer = pair.Value;
                    else if (pair.Key == "SignIn_Email_Next_Button")
                        SignIn_Email_Next_Button = pair.Value;
                    else if (pair.Key == "Navigation_Button_Back")
                        Navigation_Button_Back = pair.Value;
                    else if (pair.Key == "TFE_SignIn_iFrame")
                        TFE_SignIn_iFrame = pair.Value;


                }
                #endregion[SignIn]

                #region[SignUp]
                if (nodeModule == Constants.SignUp)
                {
                    if (pair.Key == "Click_SignIn")
                        Click_SignIn = pair.Value;
                    else if (pair.Key == "SignUp_DropDown_Salutation")
                        SignUp_DropDown_Salutation = pair.Value;
                    else if (pair.Key == "SignUp_Text_FirstName")
                        SignUp_Text_FirstName = pair.Value;
                    else if (pair.Key == "SignUp_Text_LastName")
                        SignUp_Text_LastName = pair.Value;
                    else if (pair.Key == "SignUp_Text_Email")
                        SignUp_Text_Email = pair.Value;
                    else if (pair.Key == "SignUp_Text_Password")
                        SignUp_Text_Password = pair.Value;
                    else if (pair.Key == "SignUp_Text_ConfirmPassword")
                        SignUp_Text_ConfirmPassword = pair.Value;
                    else if (pair.Key == "SignUp_CheckBox_TermsAndConditions")
                        SignUp_CheckBox_TermsAndConditions = pair.Value;
                    else if (pair.Key == "SignUp_Text_PreferredCardName")
                        SignUp_Text_PreferredCardName = pair.Value;
                    else if (pair.Key == "SignUp_Button_Join")
                        SignUp_Button_Join = pair.Value;
                    else if (pair.Key == "SignUp_Icon_Close")
                        SignUp_Icon_Close = pair.Value;
                    else if (pair.Key == "SignInButton_ActivationPage")
                        SignInButton_ActivationPage = pair.Value;
                    else if (pair.Key == "SignUp_TermsandCondition_Accept")
                        SignUp_TermsandCondition_Accept = pair.Value;
                    else if (pair.Key == "SignUp_TermsandCondition_Close")
                        SignUp_TermsandCondition_Close = pair.Value;
                    else if (pair.Key == "SignUp_Date_Picker")
                        SignUp_Date_Picker = pair.Value;
                    else if (pair.Key == "SignUp_DateOfBirth")
                        SignUp_DateOfBirth = pair.Value;
                    else if (pair.Key == "SignUp_Footer")
                        SignUp_Footer = pair.Value;

                    else if (pair.Key == "SignUp_Facebook_Link")
                        SignUp_Facebook_Link = pair.Value;
                    else if (pair.Key == "SignUp_Twitter_Link")
                        SignUp_Twitter_Link = pair.Value;
                    else if (pair.Key == "Facebook_UserName")
                        Facebook_UserName = pair.Value;

                    else if (pair.Key == "Facebook_Password")
                        Facebook_Password = pair.Value;
                    else if (pair.Key == "Facebook_Login")
                        Facebook_Login = pair.Value;
                    else if (pair.Key == "Twitter_UserName")
                        Twitter_UserName = pair.Value;
                    else if (pair.Key == "Twitter_Password")
                        Twitter_Password = pair.Value;
                    else if (pair.Key == "Twitter_Login")
                        Twitter_Login = pair.Value;
                    else if (pair.Key == "Allow_On_Twitter")
                        Allow_On_Twitter = pair.Value;
                    else if (pair.Key == "DOB_Error")
                        DOB_Error = pair.Value;
                    else if (pair.Key == "FirstName_Error")
                        FirstName_Error = pair.Value;
                    else if (pair.Key == "LastName_Error")
                        LastName_Error = pair.Value;
                    else if (pair.Key == "Email_Error")
                        Email_Error = pair.Value;
                    else if (pair.Key == "Card_Error")
                        Card_Error = pair.Value;
                    else if (pair.Key == "Password_Error")
                        Password_Error = pair.Value;
                    else if (pair.Key == "ConfirmPassword_Error")
                        ConfirmPassword_Error = pair.Value;
                    else if (pair.Key == "Captcha_Error")
                        Captcha_Error = pair.Value;
                    else if (pair.Key == "Password_Eye_Ball")
                        Password_Eye_Ball = pair.Value;
                    else if (pair.Key == "ConfirmPassword_Eye_Ball")
                        ConfirmPassword_Eye_Ball = pair.Value;
                }
                #endregion[SignUp]

                #region[Reedem]
                if (nodeModule == Constants.Reedem)
                {
                    if (pair.Key == "Reedem_Button_Redeem")
                        Reedem_Button_Redeem = pair.Value;
                    else if (pair.Key == "Navigation_Link_Redeem")
                        Navigation_Link_Redeem = pair.Value;
                    else if (pair.Key == "Redeem_Button_Frontend")
                        Redeem_Button_Frontend = pair.Value;
                    else if (pair.Key == "Image_On_Redeem_Button_Frontend")
                        Image_On_Redeem_Button_Frontend = pair.Value;
                    else if (pair.Key == "Ok_Button_On_EGift")
                        Ok_Button_On_EGift = pair.Value;
                    else if (pair.Key == "Lable_TotalPoints")
                        Lable_TotalPoints = pair.Value;
                    else if (pair.Key == "Select_AwardImage")
                        Select_AwardImage = pair.Value;
                    else if (pair.Key == "Click_Redeem_eGiftCart")
                        Click_Redeem_eGiftCart = pair.Value;
                    else if (pair.Key == "Click_Conform_eGiftCart")
                        Click_Conform_eGiftCart = pair.Value;
                    else if (pair.Key == "Click_Close_eGiftCart")
                        Click_Close_eGiftCart = pair.Value;

                    else if (pair.Key == "Click_Redeem_CancelButton")
                        Click_Redeem_CancelButton = pair.Value;
                    else if (pair.Key == "Get_TotalPoints")
                        Get_TotalPoints = pair.Value;
                    else if (pair.Key == "Get_RedeemedAwardName")
                        Get_RedeemedAwardName = pair.Value;
                    else if (pair.Key == "Click_RequestSubmitted_OkButton")
                        Click_RequestSubmitted_OkButton = pair.Value;
                    else if (pair.Key == "Click_Redeem_Ok")
                        Click_Redeem_Ok = pair.Value;
                    else if (pair.Key == "Click_Redeem_Cancel")
                        Click_Redeem_Cancel = pair.Value;

                }
                #endregion[Reedem]

                #region[InviteFriends]
                if (nodeModule == Constants.InviteFriends)
                {
                    if (pair.Key == "InviteFriends_Text_InviteFriends")
                        InviteFriends_Text_InviteFriends = pair.Value;
                    else if (pair.Key == "InviteFriends_Button_SendMyInvitation")
                        InviteFriends_Button_SendMyInvitation = pair.Value;
                    else if (pair.Key == "InviteFriends_Error_Message")
                        InviteFriends_Error_Message = pair.Value;
                    else if (pair.Key == "EnterText_SendInvitation")
                        EnterText_SendInvitation = pair.Value;
                    else if (pair.Key == "InviteFriendValidation_CaptchaError")
                        InviteFriendValidation_CaptchaError = pair.Value;
                    else if (pair.Key == "InviteFriendEmailValidation_Error")
                        InviteFriendEmailValidation_Error = pair.Value;
                    else if (pair.Key == "EnterText_SendInvitationMailContent")
                        EnterText_SendInvitationMailContent = pair.Value;
                    else if (pair.Key == "EnterText_SendInvitationMailContent_Error")
                        EnterText_SendInvitationMailContent_Error = pair.Value;
                }
                #endregion[InviteFriends]

                #region[SpecialOffers]
                if (nodeModule == Constants.SpecialOffers)
                {
                    if (pair.Key == "SpecialOffers_Text_Exclusive")
                        SpecialOffers_Text_Exclusive = pair.Value;

                    if (pair.Key == "Specialoffers_LastButton")
                        Specialoffers_LastButton = pair.Value;
                    
                    
                }

                #endregion[SpecialOffers]

                #region[ForgotPassword]

                if (nodeModule == Constants.ForgotPassword)
                {
                    if (pair.Key == "ForgotPassword_LinkText")
                    {
                        ForgotPassword_LinkText = pair.Value;
                    }
                    else if (pair.Key == "ForgotPassword_Email")
                    {
                        ForgotPassword_Email = pair.Value;
                    }
                    else if (pair.Key == "ForgotPassword_Recover")
                    {
                        ForgotPassword_Recover = pair.Value;
                    }
                    else if (pair.Key == "ForgotPassword_Cancel")
                    {
                        ForgotPassword_Cancel = pair.Value;
                    }
                    else if (pair.Key == "ForgotPassword_Back")
                    {
                        ForgotPassword_Back = pair.Value;
                    }
                    else if (pair.Key == "ForgotPassword_NewPassword")
                    {
                        ForgotPassword_NewPassword = pair.Value;
                    }
                    else if (pair.Key == "ForgotPassword_NewPasswordConfirm")
                    {
                        ForgotPassword_NewPasswordConfirm = pair.Value;
                    }
                    else if (pair.Key == "ForgotPassword_Recovery")
                    {
                        ForgotPassword_Recovery = pair.Value;
                    }
                    else if (pair.Key == "ForgotPassword_TermsandCondition_Accept")
                    {
                        ForgotPassword_TermsandCondition_Accept = pair.Value;
                    }
                }

                #endregion[ForgotPassword]

                #region[Navigation]
                if (nodeModule == Constants.Navigation)
                {
                    if (pair.Key == "Navigation_Link_SignIn")
                        Navigation_Link_SignIn = pair.Value;
                    else if (pair.Key == "Navigation_Link_Sign_In")
                        Navigation_Link_Sign_In = pair.Value;
                    else if (pair.Key == "Navigation_Button_SignIn")
                        Navigation_Button_SignIn = pair.Value;
                    else if (pair.Key == "Navigation_Button_JoinNow")
                        Navigation_Button_JoinNow = pair.Value;
                    else if (pair.Key == "Navigation_Button_JoinNow1")
                        Navigation_Button_JoinNow1 = pair.Value;
                    else if (pair.Key == "Navigation_Link_Join")
                        Navigation_Link_Join = pair.Value;
                    else if (pair.Key == "Navigation_Link_Join2")
                        Navigation_Link_Join2 = pair.Value;
                    else if (pair.Key == "Navigation_Link_MyStays")
                        Navigation_Link_MyStays = pair.Value;
                    else if (pair.Key == "Navigation_Link_MyStays2")
                        Navigation_Link_MyStays2 = pair.Value;
                    else if (pair.Key == "Navigation_Link_MyProfile")
                        Navigation_Link_MyProfile = pair.Value;
                    else if (pair.Key == "Navigation_Link_MyProfile1")
                        Navigation_Link_MyProfile1 = pair.Value;
                    else if (pair.Key == "Navigation_Link_Summary")
                        Navigation_Link_Summary = pair.Value;
                    else if (pair.Key == "Navigation_Link_Benefits")
                        Navigation_Link_Benefits = pair.Value;
                    else if (pair.Key == "Navigation_Link_FAQ")
                        Navigation_Link_FAQ = pair.Value;
                    else if (pair.Key == "Navigation_Link_ContactUs")
                        Navigation_Link_ContactUs = pair.Value;
                    else if (pair.Key == "Navigation_Link_ContactUs2")
                        Navigation_Link_ContactUs2 = pair.Value;
                    else if (pair.Key == "Navigation_Link_Un_Authenticated_ContactUs")
                        Navigation_Link_Un_Authenticated_ContactUs = pair.Value;
                    
                    else if (pair.Key == "Navigation_Link_Redeem")
                        Navigation_Link_Redeem = pair.Value;
                    else if (pair.Key == "Navigation_Link_MyActivity")
                        Navigation_Link_MyActivity = pair.Value;
                    else if (pair.Key == "Navigation_Link_SignOut")
                        Navigation_Link_SignOut = pair.Value;
                    else if (pair.Key == "Navigation_Link_SignOut2")
                        Navigation_Link_SignOut2 = pair.Value;
                    else if (pair.Key == "Navigation_Link_UpdateMyPreferences")
                        Navigation_Link_UpdateMyPreferences = pair.Value;
                    else if (pair.Key == "Navigation_Link_UpdateMyProfile")
                        Navigation_Link_UpdateMyProfile = pair.Value;
                    else if (pair.Key == "Navigation_Link_MySettings")
                        Navigation_Link_MySettings = pair.Value;
                    else if (pair.Key == "Navigation_Link_MyAccount")
                        Navigation_Link_MyAccount = pair.Value;
                    else if (pair.Key == "Navigation_LinkText_MySettings")
                        Navigation_LinkText_MySettings = pair.Value;
                    else if (pair.Key == "Navigation_Button_ExpandCollapse")
                        Navigation_Button_ExpandCollapse = pair.Value;
                    else if (pair.Key == "Overview_MemberSinceDate")
                        Overview_MemberSinceDate = pair.Value;
                    else if (pair.Key == "Overview_MemberShipLevel")
                        Overview_MemberShipLevel = pair.Value;
                    else if (pair.Key == "Navigation_Link_Facebook")
                        Navigation_Link_Facebook = pair.Value;
                    else if (pair.Key == "Navigation_Link_Exclusives")
                        Navigation_Link_Exclusives = pair.Value;
                    else if (pair.Key == "Navigation_Link_LoginExclusives")
                        Navigation_Link_LoginExclusives = pair.Value;
                    else if (pair.Key == "Navigation_Link_ProgramOverview")
                        Navigation_Link_ProgramOverview = pair.Value;
                    else if (pair.Key == "Navigation_Link_MyAward_Filter")
                        Navigation_Link_MyAward_Filter = pair.Value;
                    else if (pair.Key == "Navigation_Button_MyAward_Redeem")
                        Navigation_Button_MyAward_Redeem = pair.Value;

                    else if (pair.Key == "Navigation_Link_MyAward")
                        Navigation_Link_MyAward = pair.Value;
                    else if (pair.Key == "Navigation_SpecialOffer")
                        Navigation_SpecialOffer = pair.Value;
                    else if (pair.Key == "Navigation_Link_Enroll")
                        Navigation_Link_Enroll = pair.Value;
                    else if (pair.Key == "Navigation_Link_FAQ1")
                        Navigation_Link_FAQ1 = pair.Value;
                    else if (pair.Key == "Navigation_Link_InviteFriends")
                        Navigation_Link_InviteFriends = pair.Value;
                    else if (pair.Key == "Navigation_Link_Twitter")
                        Navigation_Link_Twitter = pair.Value;
                    if (pair.Key == "Click_Contact_Link")
                        Click_Contact_Link = pair.Value;

                }
                #endregion[Navigation]

                #region[Exclusives]
                if (nodeModule == Constants.Exclusives)
                {
                    if (pair.Key == "Exclusives_Text_ReadMore")
                        Exclusives_Text_ReadMore = pair.Value;
                    else if (pair.Key == "Exclusives_Button_BookNow")
                        Exclusives_Button_BookNow = pair.Value;
                    else if (pair.Key == "Exclusives_Link_ShareNow")
                        Exclusives_Link_ShareNow = pair.Value;
                }
                #endregion[Exclusives]

                #region[ContactUs]
                if (nodeModule == Constants.ContactUs)
                {
                    if (pair.Key == "ContactUs_Text_YourName")
                        ContactUs_Text_YourName = pair.Value;
                    else if (pair.Key == "ContactUs_Text_EmailAddress")
                        ContactUs_Text_EmailAddress = pair.Value;
                    else if (pair.Key == "ContactUs_Text_PhoneNumber")
                        ContactUs_Text_PhoneNumber = pair.Value;
                    else if (pair.Key == "ContactUs_Text_FraserWorldMembershipNo")
                        ContactUs_Text_IndependentCMembershipNo = pair.Value;
                    else if (pair.Key == "ContactUs_DDM_Subject")
                        ContactUs_DDM_Subject = pair.Value;
                    else if (pair.Key == "ContactUs_Text_Message")
                        ContactUs_Text_Message = pair.Value;
                    else if (pair.Key == "ContactUs_Button_Captcha")
                        ContactUs_Button_Captcha = pair.Value;
                    else if (pair.Key == "ContactUs_Button_Send")
                        ContactUs_Button_Send = pair.Value;
                    else if (pair.Key == "EnterText_Text_Confirmation_Number")
                        EnterText_Text_Confirmation_Number = pair.Value;
                    else if (pair.Key == "Select_Contact_US_File")
                        Select_Contact_US_File = pair.Value;
                    else if (pair.Key == "DropDownSelect_Authentication_Subject")
                        DropDownSelect_Authentication_Subject = pair.Value;

                }
                #endregion[ContactUs]

                #region[MyStays]
                if (nodeModule == Constants.MyStays)
                {
                    if (pair.Key == "MyStays_DropDown_UpcomingStays")
                        MyStays_DropDown_UpcomingStays = pair.Value;
                    else if (pair.Key == "MyStays_DropDown_PastStays")
                        MyStays_DropDown_PastStays = pair.Value;
                    else if (pair.Key == "MyStays_Text_UpcomingStays_Filter")
                        MyStays_Text_UpcomingStays_Filter = pair.Value;
                    else if (pair.Key == "MyStays_Text_PastStays_Filter")
                        MyStays_Text_PastStays_Filter = pair.Value;
                    else if (pair.Key == "Navigation_Link_MyStays")
                        Navigation_Link_MyStays = pair.Value;
                    else if (pair.Key == "Navigation_Link_MyProfile")
                        Navigation_Link_MyProfile = pair.Value;
                    else if (pair.Key == "Navigation_Link_Benefits")
                        Navigation_Link_Benefits = pair.Value;
                    else if (pair.Key == "Navigation_Link_FAQ")
                        Navigation_Link_FAQ = pair.Value;
                    else if (pair.Key == "Navigation_Link_ContactUs")
                        Navigation_Link_ContactUs = pair.Value;
                    else if (pair.Key == "Navigation_Link_Redeem")
                        Navigation_Link_Redeem = pair.Value;
                    else if (pair.Key == "Navigation_Link_SignOut")
                        Navigation_Link_SignOut = pair.Value;
                    else if (pair.Key == "Navigation_Link_UpdateMyPreferences")
                        Navigation_Link_UpdateMyPreferences = pair.Value;
                    else if (pair.Key == "Navigation_Link_MySettings")
                        Navigation_Link_MySettings = pair.Value;
                    else if (pair.Key == "Navigation_Button_ExpandCollapse")
                        Navigation_Button_ExpandCollapse = pair.Value;
                }
                #endregion[MyStays]

                #region[Summary]
                if (nodeModule == Constants.Summary)
                {
                    if (pair.Key == "Summary_Text_MembershipNo")
                        Summary_Text_MembershipNo = pair.Value;
                    else if (pair.Key == "Summary_Text_MembershipType")
                        Summary_Text_MembershipType = pair.Value;
                    else if (pair.Key == "Summary_Click_MembershipCard")
                        Summary_Click_MembershipCard = pair.Value;
                    else if (pair.Key == "Summary_MembershipCard_Name")
                        Summary_MembershipCard_Name = pair.Value;
                    else if (pair.Key == "Summary_MembershipCard_Number")
                        Summary_MembershipCard_Number = pair.Value;
                    else if (pair.Key == "Summary_MembershipCard_SinceDate")
                        Summary_MembershipCard_SinceDate = pair.Value;
                    else if (pair.Key == "Summary_MembershipCard_Close")
                        Summary_MembershipCard_Close = pair.Value;

                }
                #endregion[Summary]

                #region[MyProfile]
                if (nodeModule == Constants.MyProfile)
                {
                    if (pair.Key == "MyProfile_Link_MyPersonalProfile_MyProfile")
                        MyProfile_Link_MyPersonalProfile_MyProfile = pair.Value;
                    else if (pair.Key == "MyProfile_Link_MyPersonalProfile_YourPreferences")
                        MyProfile_Link_MyPersonalProfile_YourPreferences = pair.Value;
                    else if (pair.Key == "MyProfile_Text_MembershipNumber")
                        MyProfile_Text_MembershipNumber = pair.Value;
                    else if (pair.Key == "MyProfile_Text_MembershipType")
                        MyProfile_Text_MembershipType = pair.Value;
                    else if (pair.Key == "MyProfile_DropDown_Title")
                        MyProfile_DropDown_Title = pair.Value;
                    else if (pair.Key == "MyProfile_Text_FirstName")
                        MyProfile_Text_FirstName = pair.Value;
                    else if (pair.Key == "MyProfile_Text_LastName")
                        MyProfile_Text_LastName = pair.Value;
                    else if (pair.Key == "MyProfile_Text_CardName")
                        MyProfile_Text_CardName = pair.Value;
                    else if (pair.Key == "MyProfile_DropDown_Gender")
                        MyProfile_DropDown_Gender = pair.Value;
                    else if (pair.Key == "MyProfile_DropDown_Nationality")
                        MyProfile_DropDown_Nationality = pair.Value;
                    else if (pair.Key == "MyProfile_DropDown_DateOfBirth")
                        MyProfile_DropDown_DateOfBirth = pair.Value;
                    else if (pair.Key == "MyProfile_DropDown_Month")
                        MyProfile_DropDown_Month = pair.Value;
                    else if (pair.Key == "MyProfile_DropDown_Year")
                        MyProfile_DropDown_Year = pair.Value;
                    else if (pair.Key == "MyProfile_Text_CompanyName")
                        MyProfile_Text_CompanyName = pair.Value;
                    else if (pair.Key == "MyProfile_Text_MobilePhoneNumber")
                        MyProfile_Text_MobilePhoneNumber = pair.Value;
                    else if (pair.Key == "MyProfile_Text_HomePhoneNumber")
                        MyProfile_Text_HomePhoneNumber = pair.Value;
                    else if (pair.Key == "MyProfile_Text_OfficePhoneNumber")
                        MyProfile_Text_OfficePhoneNumber = pair.Value;
                    else if (pair.Key == "MyProfile_Text_FaxPhoneNumber")
                        MyProfile_Text_FaxPhoneNumber = pair.Value;
                    else if (pair.Key == "MyProfile_Text_Address1")
                        MyProfile_Text_Address1 = pair.Value;
                    else if (pair.Key == "MyProfile_Text_Address2")
                        MyProfile_Text_Address2 = pair.Value;
                    else if (pair.Key == "MyProfile_Text_City")
                        MyProfile_Text_City = pair.Value;
                    else if (pair.Key == "MyProfile_DropDown_StateProvince")
                        MyProfile_DropDown_StateProvince = pair.Value;
                    else if (pair.Key == "MyProfile_DropDown_Country")
                        MyProfile_DropDown_Country = pair.Value;
                    else if (pair.Key == "MyProfile_Text_Zip")
                        MyProfile_Text_Zip = pair.Value;
                    else if (pair.Key == "MyProfile_Text_ZipExtension")
                        MyProfile_Text_ZipExtension = pair.Value;
                    else if (pair.Key == "MyProfile_DropDown_PreferredLanguage")
                        MyProfile_DropDown_PreferredLanguage = pair.Value;
                    else if (pair.Key == "MyProfile_DropDown_RecommendedBy")
                        MyProfile_DropDown_RecommendedBy = pair.Value;
                    else if (pair.Key == "MyProfile_Button_Next")
                        MyProfile_Button_Next = pair.Value;
                    else if (pair.Key == "MyProfile_Link_FraserSuites")
                        MyProfile_Link_FraserSuites = pair.Value;
                    else if (pair.Key == "MyProfile_Link_FraserPlace")
                        MyProfile_Link_FraserPlace = pair.Value;
                    else if (pair.Key == "MyProfile_Link_FraserResidence")
                        MyProfile_Link_FraserResidence = pair.Value;
                    else if (pair.Key == "MyProfile_Link_Modena")
                        MyProfile_Link_Modena = pair.Value;
                    else if (pair.Key == "MyProfile_Link_Capri")
                        MyProfile_Link_Capri = pair.Value;
                    else if (pair.Key == "MyProfile_Link_Malmaison")
                        MyProfile_Link_Malmaison = pair.Value;
                    else if (pair.Key == "MyProfile_Link_HotelDuVin")
                        MyProfile_Link_HotelDuVin = pair.Value;
                    else if (pair.Key == "MyProfile_Link_TermsAndCondition")
                        MyProfile_Link_TermsAndCondition = pair.Value;
                    else if (pair.Key == "MyProfile_Link_FrequentlyAskedQuestions")
                        MyProfile_Link_FrequentlyAskedQuestions = pair.Value;
                    else if (pair.Key == "MyProfile_Link_ContactUs")
                        MyProfile_Link_ContactUs = pair.Value;
                    else if (pair.Key == "MyProfile_Link_TermsOfUse")
                        MyProfile_Link_TermsOfUse = pair.Value;
                    else if (pair.Key == "MyProfile_Link_PrivacyPolicy")
                        MyProfile_Link_PrivacyPolicy = pair.Value;
                    else if (pair.Key == "MyProfile_Link_BestRateGuarantee")
                        MyProfile_Link_BestRateGuarantee = pair.Value;
                    else if (pair.Key == "MyProfile_Icon_Close")
                        MyProfile_Icon_Close = pair.Value;
                    else if (pair.Key == "MyProfile_FAQ_Icon_Close")
                        MyProfile_FAQ_Icon_Close = pair.Value;
                }
                #endregion[MyProfile]

                #region[MyProfile_Partner]
                if (nodeModule == Constants.MyProfile_Partner)
                {
                    if (pair.Key == "MyProfile_Partner_Checkbox_Partner")
                        MyProfile_Partner_Checkbox_Partner = pair.Value;
                    else if (pair.Key == "MyProfile_Partner_Icon_Partner")
                        MyProfile_Partner_Icon_Partner = pair.Value;
                    else if (pair.Key == "MyProfile_Partner_Text_FirstnameLastname")
                        MyProfile_Partner_Text_FirstnameLastname = pair.Value;
                    else if (pair.Key == "MyProfile_Partner_Text_DateOfBirth")
                        MyProfile_Partner_Text_DateOfBirth = pair.Value;
                    else if (pair.Key == "MyProfile_Partner_Text_AnniversaryDate")
                        MyProfile_Partner_Text_AnniversaryDate = pair.Value;
                    else if (pair.Key == "MyProfile_Partner_Dropdown_Children")
                        MyProfile_Partner_Dropdown_Children = pair.Value;
                    else if (pair.Key == "MyProfile_Partner_Button_Previous")
                        MyProfile_Partner_Button_Previous = pair.Value;
                    else if (pair.Key == "MyProfile_Partner_Button_Next")
                        MyProfile_Partner_Button_Next = pair.Value;
                    else if (pair.Key == "MyProfile_Partner_Dropdown_Month")
                        MyProfile_Partner_Dropdown_Month = pair.Value;
                    else if (pair.Key == "MyProfile_Partner_Dropdown_Year")
                        MyProfile_Partner_Dropdown_Year = pair.Value;
                }
                #endregion[MyProfile_Partner]

                #region[MyProfile_PassionAndInterests]
                if (nodeModule == Constants.MyProfile_PassionAndInterests)
                {
                    if (pair.Key == "MyProfile_PassionAndInterests_Checkbox_ArtsandEntertainment")
                        MyProfile_PassionAndInterests_Checkbox_ArtsandEntertainment = pair.Value;
                    else if (pair.Key == "MyProfile_PassionAndInterests_Checkbox_FitnessandWellness")
                        MyProfile_PassionAndInterests_Checkbox_FitnessandWellness = pair.Value;
                    else if (pair.Key == "MyProfile_PassionAndInterests_Checkbox_FoodandWine")
                        MyProfile_PassionAndInterests_Checkbox_FoodandWine = pair.Value;
                    else if (pair.Key == "MyProfile_PassionAndInterests_Checkbox_Golf")
                        MyProfile_PassionAndInterests_Checkbox_Golf = pair.Value;
                    else if (pair.Key == "MyProfile_PassionAndInterests_Checkbox_CultureAndHeritage")
                        MyProfile_PassionAndInterests_Checkbox_CultureAndHeritage = pair.Value;
                    else if (pair.Key == "MyProfile_PassionAndInterests_Checkbox_Nature")
                        MyProfile_PassionAndInterests_Checkbox_Nature = pair.Value;
                    else if (pair.Key == "MyProfile_PassionAndInterests_Checkbox_Nightlife")
                        MyProfile_PassionAndInterests_Checkbox_Nightlife = pair.Value;
                    else if (pair.Key == "MyProfile_PassionAndInterests_Checkbox_ShoopingandLifestyle")
                        MyProfile_PassionAndInterests_Checkbox_ShoopingandLifestyle = pair.Value;
                    else if (pair.Key == "MyProfile_PassionAndInterests_Checkbox_TechandGadgets")
                        MyProfile_PassionAndInterests_Checkbox_TechandGadgets = pair.Value;
                    else if (pair.Key == "MyProfile_PassionAndInterests_Checkbox_Travel")
                        MyProfile_PassionAndInterests_Checkbox_Travel = pair.Value;
                    else if (pair.Key == "MyProfile_PassionAndInterests_Checkbox_Family")
                        MyProfile_PassionAndInterests_Checkbox_Family = pair.Value;
                    else if (pair.Key == "MyProfile_PassionAndInterests_Checkbox_Sports")
                        MyProfile_PassionAndInterests_Checkbox_Sports = pair.Value;
                    else if (pair.Key == "MyProfile_PassionAndInterests_Button_Previous")
                        MyProfile_PassionAndInterests_Button_Previous = pair.Value;
                    else if (pair.Key == "MyProfile_PassionAndInterests_Button_Next")
                        MyProfile_PassionAndInterests_Button_Next = pair.Value;
                }
                #endregion[MyProfile_PassionAndInterests]

                #region[MyProfile_MySubscriptions]
                if (nodeModule == Constants.MyProfile_MySubscriptions)
                {
                    if (pair.Key == "MyProfile_MySubscriptions_Button_Previous")
                        MyProfile_MySubscriptions_Button_Previous = pair.Value;
                    else if (pair.Key == "MyProfile_MySubscriptions_Icon_MySubscriptions")
                        MyProfile_MySubscriptions_Icon_MySubscriptions = pair.Value;
                    else if (pair.Key == "MyProfile_MySubscriptions_Button_Update")
                        MyProfile_MySubscriptions_Button_Update = pair.Value;
                    else if (pair.Key == "MyProfile_MySubscriptions_Button_Submit")
                        MyProfile_MySubscriptions_Button_Submit = pair.Value;
                    else if (pair.Key == "MyProfile_MySubscriptions_RadioButton_SubscribeAllAvailableLists")
                        MyProfile_MySubscriptions_RadioButton_SubscribeAllAvailableLists = pair.Value;
                    else if (pair.Key == "MyProfile_MySubscriptions_RadioButton_SubscribeSelectedLists")
                        MyProfile_MySubscriptions_RadioButton_SubscribeSelectedLists = pair.Value;
                    else if (pair.Key == "MyProfile_MySubscriptions_RadioButton_UnsubscribeEmailCampaigns")
                        MyProfile_MySubscriptions_RadioButton_UnsubscribeEmailCampaigns = pair.Value;
                    else if (pair.Key == "MyProfile_MySubscriptions_CheckBox_MonthlyEStatement")
                        MyProfile_MySubscriptions_CheckBox_MonthlyEStatement = pair.Value;
                    else if (pair.Key == "MyProfile_MySubscriptions_CheckBox_QuarterlyEStatement")
                        MyProfile_MySubscriptions_CheckBox_QuarterlyEStatement = pair.Value;
                    else if (pair.Key == "MyProfile_MySubscriptions_CheckBox_MarketingAndPromotionalMaterials")
                        MyProfile_MySubscriptions_CheckBox_MarketingAndPromotionalMaterials = pair.Value;
                    else if (pair.Key == "MyProfile_MySubscriptions_CheckBox_eCacheAndeNewsletter")
                        MyProfile_MySubscriptions_CheckBox_eCacheAndeNewsletter = pair.Value;
                    else if (pair.Key == "MyProfile_MySubscriptions_CheckBox_LifestyleArticlesAndAdvertorial")
                        MyProfile_MySubscriptions_CheckBox_LifestyleArticlesAndAdvertorial = pair.Value;
                    else if (pair.Key == "MyProfile_MySubscriptions_CheckBox_NotValuableOrRelevant")
                        MyProfile_MySubscriptions_CheckBox_NotValuableOrRelevant = pair.Value;
                    else if (pair.Key == "MyProfile_MySubscriptions_CheckBox_DonNotRememberSigningUp")
                        MyProfile_MySubscriptions_CheckBox_DonNotRememberSigningUp = pair.Value;
                }
                #endregion[MyProfile_MySubscriptions]

                #region[MySettings]
                if (nodeModule == Constants.MySettings)
                {
                    if (pair.Key == "MySettings_NewEmailAddress")
                    {
                        MySettings_NewEmailAddress = pair.Value;
                    }
                    else if (pair.Key == "MySettings_Password")
                    {
                        MySettings_Password = pair.Value;
                    }
                    else if (pair.Key == "MySettings_UpdateUser")
                    {
                        MySettings_UpdateUser = pair.Value;
                    }
                    else if (pair.Key == "MySettings_UpdateLogin")
                    {
                        MySettings_UpdateLogin = pair.Value;
                    }
                    else if (pair.Key == "MySettings_CurrentPassword")
                    {
                        MySettings_CurrentPassword = pair.Value;
                    }
                    else if (pair.Key == "MySettings_NewPassword")
                    {
                        MySettings_NewPassword = pair.Value;
                    }
                    else if (pair.Key == "MySettings_ConfirmPassword")
                    {
                        MySettings_ConfirmPassword = pair.Value;
                    }
                    else if (pair.Key == "MySettings_UpdatePassword")
                    {
                        MySettings_UpdatePassword = pair.Value;
                    }
                    else if (pair.Key == "MySettings_CurrentEmailAddress")
                    {
                        MySettings_CurrentEmailAddress = pair.Value;
                    }

                    else if (pair.Key == "MySettings_PasswordUpdationConformationPopup")
                    {
                        MySettings_PasswordUpdationConformationPopup = pair.Value;
                    }
                    else if (pair.Key == "MySettings_EmailUpdationConformationPopup")
                    {
                        MySettings_EmailUpdationConformationPopup = pair.Value;
                    }

                }
                #endregion[MySettings]

                #region[Kiosk]
                if (nodeModule == Constants.Kiosk)
                {
                    if (pair.Key == "Kiosk_DropDown_Salutation")
                        Kiosk_DropDown_Salutation = pair.Value;
                    else if (pair.Key == "Kiosk_Text_FirstName")
                        Kiosk_Text_FirstName = pair.Value;
                    else if (pair.Key == "Kiosk_Text_LastName")
                        Kiosk_Text_LastName = pair.Value;
                    else if (pair.Key == "Kiosk_Text_Email")
                        Kiosk_Text_Email = pair.Value;
                    else if (pair.Key == "Kiosk_Text_SignerName")
                        Kiosk_Text_SignerName = pair.Value;
                    else if (pair.Key == "Kiosk_DropDown_SignupCode")
                        Kiosk_DropDown_SignupCode = pair.Value;
                    else if (pair.Key == "Kiosk_Text_SignUpSource")
                        Kiosk_Text_SignUpSource = pair.Value;
                    else if (pair.Key == "Kiosk_CheckBox_TermsAndConditions")
                        Kiosk_CheckBox_TermsAndConditions = pair.Value;
                    else if (pair.Key == "Kiosk_Button_JoinNow")
                        Kiosk_Button_JoinNow = pair.Value;
                }
                #endregion[Kiosk]

                #region[CRMAPI]
                if (nodeModule == Constants.CRMAPI)
                {
                    if (pair.Key == "CRMAPI_btnprimary")
                        CRMAPI_btnprimary = pair.Value;
                    else if (pair.Key == "CRMAPI_LoyaltyVersion_1")
                        CRMAPI_LoyaltyVersion_1 = pair.Value;
                    else if (pair.Key == "CRMAPI_LoyaltyVersion_2")
                        CRMAPI_LoyaltyVersion_2 = pair.Value;
                    else if (pair.Key == "CRMAPI_LoyaltyVersion_3")
                        CRMAPI_LoyaltyVersion_3 = pair.Value;
                    else if (pair.Key == "APICredentials")
                        APICredentials = pair.Value;
                    else if (pair.Key == "CRMAPI_btnExplore")
                        CRMAPI_btnExplore = pair.Value;
                    else if (pair.Key == "CRMAPI_ParentAccList")
                        CRMAPI_ParentAccList = pair.Value;
                    else if (pair.Key == "CRMAPI_AccountLogin")
                        CRMAPI_AccountLogin = pair.Value;
                    else if (pair.Key == "CRMAPI_AccountLogin_Authentication")
                        CRMAPI_AccountLogin_Authentication = pair.Value;
                    else if (pair.Key == "CRMAPI_AccountLogin_MasterPropertyCode")
                        CRMAPI_AccountLogin_MasterPropertyCode = pair.Value;
                    else if (pair.Key == "CRMAPI_AccountLogin_SubmitButton")
                        CRMAPI_AccountLogin_SubmitButton = pair.Value;
                    else if (pair.Key == "CRMAPI_AccountRegister")
                        CRMAPI_AccountRegister = pair.Value;
                    else if (pair.Key == "CRMAPI_AccountRegister_RegisterAcc")
                        CRMAPI_AccountRegister_RegisterAcc = pair.Value;
                    else if (pair.Key == "CRMAPI_AccountRegister_MasterPropertyCode")
                        CRMAPI_AccountRegister_MasterPropertyCode = pair.Value;
                    else if (pair.Key == "CRMAPI_AccountRegister_RegisterButton")
                        CRMAPI_AccountRegister_RegisterButton = pair.Value;



                }
                #endregion[CRMAPI]
                #region[Awards]
                if (nodeModule == Constants.Awards)
                {
                    if (pair.Key == "Click_Redeem_Button_In_My_Awards")
                        Click_Redeem_Button_In_My_Awards = pair.Value;
                    else if (pair.Key == "Click_Award_Name")
                        Click_Award_Name = pair.Value;
                    else if (pair.Key == "Click_Award_Tab")
                        Click_Award_Tab = pair.Value;
                    else if (pair.Key == "Award_Filter")
                        Award_Filter = pair.Value;
                    else if (pair.Key == "Click_Redemptions_SubTab")
                        Click_Redemptions_SubTab = pair.Value;
                }
                #endregion[Awards]



                #endregion[UI]

            }
            return obj;
        }
    }
}
