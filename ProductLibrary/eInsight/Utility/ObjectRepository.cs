using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace eInsight.Utility
{
    class ObjectRepository
    {
        #region[UI]

        #region[Admin]
        public static string Click_Open_SpecificPropertySetting { get; set; }
        public static string Click_AllTabs { get; set; }
        public static string Click_Tab_CompanySettings { get; set; }
        public static string Admin_CompanySetting_Textbox_SettingValue { get; set; }
        public static string Admin_CompanySetting_Button_Submit { get; set; }
        #endregion[Admin]

        #region[Login]
        public static string Login_IFrame { get; set; }
        public static string Login_IFrame_AgreeProceed { get; set; }
        public static string Login_IFrame_AgreeProceed_Close { get; set; }
        public static string Login_Email { get; set; }
        public static string Login_NextButton { get; set; }
        public static string Login_Password { get; set; }
        
        public static string Login_Submit { get; set; }
        public static string Login_ForgotPassword { get; set; }
        public static string Login_ResetPassword { get; set; }
        public static string Login_Text_ForgotPassword_Email { get; set; }
        public static string Login_Button_ForgotPassword_Submit { get; set; }
        public static string Login_NewPassword { get; set; }
        public static string Login_NewConfirmPassword { get; set; }
        public static string Login_ResetPassword_Submit { get; set; }
        #endregion[Login]

        #region[Navigation]
        public static string UserProfileIcon { get; set; }
        public static string AdminLink { get; set; }
        public static string SettingsLink { get; set; }
        public static string MyPreferenceLink { get; set; }
        public static string Navigation_Home { get; set; }
        public static string Navigation_Profile { get; set; }
        public static string Navigation_Audiences { get; set; }
        public static string Navigation_CreateCampaign { get; set; }
        public static string Navigation_ManageCampaign { get; set; }
        public static string Navigation_Calendar { get; set; }
        public static string Navigation_eGallery { get; set; }
        public static string Navigation_Reports { get; set; }
        public static string Navigation_Survey { get; set; }
        public static string Navigation_Link_Monitoring { get; set; }
        public static string Navigation_Link_Settings { get; set; }
        public static string Navigation_Link_Admin { get; set; }
        public static string Navigation_Link_MainMenu { get; set; }
        public static string Navigation_Link_Help { get; set; }
        public static string Navigation_Link_LogOut { get; set; }
        public static string Navigation_Link_ProductList_Show { get; set; }
        public static string Navigation_Link_ProductList_eInsight { get; set; }
        public static string Navigation_Link_ProductList_eConcierge { get; set; }
        public static string Navigation_Link_ProductList_eSurvey { get; set; }
        public static string Navigation_Link_ProductList_Loyalty { get; set; }
        public static string Navigation_Link_ProductList_eInsightReports { get; set; }
        public static string AudienceBuilder { get; set; }
        #endregion[Navigation]

        #region[Profile]
        public static string Profile_Client { get; set; }
        public static string Profile_Sub_Client { get; set; }
        public static string Profile_Sub_Client_SearchField { get; set; }
        public static string Profile_Company { get; set; }
        public static string Profile_SearchGuestsTab { get; set; }
        public static string Profile_AddGuestsTab { get; set; }
        public static string Profile_UnsubscribesTab { get; set; }
        public static string Profile_MergeGuestRecordsTab { get; set; }

        public static string Profile_SearchGuestsSearchExpression { get; set; }
        public static string Profile_SearchGuestsSearchBy { get; set; }
        public static string Profile_SearchGuestsSearchFor { get; set; }
        public static string Profile_SearchGuestsSearch { get; set; }
        public static string Profile_SearchGuestsCancel { get; set; }
        public static string Profile_SearchByCustomerPresent { get; set; }
        public static string Profile_SearchGuestsFirstResult { get; set; }

        public static string Profile_AddGuestsUploadNewFileTab { get; set; }
        public static string Profile_AddGuestsManuallyAddGuestTab { get; set; }
        public static string Profile_AddGuestsUploadNewFileCreateNewSourceRb { get; set; }
        public static string Profile_AddGuestsUploadNewFileCreateNewSourceName { get; set; }
        public static string Profile_AddGuestsUploadNewFileCreateNewSourceChooseFile { get; set; }
        public static string Profile_AddGuestsUploadNewFileCreateNewSourceSubmit { get; set; }
        public static string Profile_AddGuestsUploadNewFileCreateNewSourceReset { get; set; }
        public static string Profile_AddGuestsUploadNewFileUpdateExistingSourceRb { get; set; }
        public static string Profile_AddGuestsUploadNewFileUpdateExistingSourceName { get; set; }
        public static string Profile_AddGuestsUploadNewFileUpdateExistingSourceName_SelectSource { get; set; }
        public static string Profile_AddGuestsUploadNewFileUpdateExistingSourceChooseFile { get; set; }
        public static string Profile_AddGuestsUploadNewFileUpdateExistingSourceSubmit { get; set; }
        public static string Profile_AddGuestsUploadNewFileUpdateExistingSourceReset { get; set; }

        public static string Profile_AddGuestsManuallyAddGuestPrefix { get; set; }
        public static string Profile_AddGuestsManuallyAddGuestFirstName { get; set; }
        public static string Profile_AddGuestsManuallyAddGuestLastName { get; set; }
        public static string Profile_AddGuestsManuallyAddGuestAddress1 { get; set; }
        public static string Profile_AddGuestsManuallyAddGuestAddress2 { get; set; }
        public static string Profile_AddGuestsManuallyAddGuestCity { get; set; }
        public static string Profile_AddGuestsManuallyAddGuestState { get; set; }
        public static string Profile_AddGuestsManuallyAddGuestZip { get; set; }
        public static string Profile_AddGuestsManuallyAddGuestCountryCode { get; set; }
        public static string Profile_AddGuestsManuallyAddGuestNewSourceNameRb { get; set; }
        public static string Profile_AddGuestsManuallyAddGuestNewSourceNameText { get; set; }
        public static string Profile_AddGuestsManuallyAddGuestExistingSourceRb { get; set; }
        public static string Profile_AddGuestsManuallyAddGuestExistingSourceDropdown { get; set; }
        public static string Profile_AddGuestsManuallyAddGuestEmail { get; set; }
        public static string Profile_AddGuestsManuallyAddGuestCompany { get; set; }
        public static string Profile_AddGuestsManuallyAddGuestTitle { get; set; }
        public static string Profile_AddGuestsManuallyAddGuestWorkPhone { get; set; }
        public static string Profile_AddGuestsManuallyAddGuestWorkExt { get; set; }
        public static string Profile_AddGuestsManuallyAddGuestFax { get; set; }
        public static string Profile_AddGuestsManuallyAddGuestMobile { get; set; }
        public static string Profile_AddGuestsManuallyAddGuestHome { get; set; }
        public static string Profile_AddGuestsManuallyAddGuestSourceOfBusiness { get; set; }
        public static string Profile_AddGuestsManuallyAddGuestNext { get; set; }
        public static string Profile_AddGuestsManuallyAddGuestReset { get; set; }

        public static string Profile_UnsubscribesFileUploadTab { get; set; }
        public static string Profile_UnsubscribesOneAtATimeTab { get; set; }
        public static string Profile_UnsubscribesFileUploadSearchUnsubscribedTab { get; set; }
        public static string Profile_UnsubscribesFileUploadBrowse { get; set; }
        public static string Profile_UnsubscribesFileUploadSubmit { get; set; }
        public static string Profile_UnsubscribesFileUploadCancel { get; set; }
        public static string Profile_UnsubscribesOneAtATimeEmail { get; set; }
        public static string Profile_UnsubscribesOneAtATimeProjectId { get; set; }
        public static string Profile_UnsubscribesOneAtATimeMethod { get; set; }
        public static string Profile_UnsubscribesOneAtATimeComments { get; set; }
        public static string Profile_UnsubscribesOneAtATimeSubmit { get; set; }
        public static string Profile_UnsubscribesOneAtATimeCancel { get; set; }
        public static string Profile_UnsubscribesSearchUnsubscribedSearchExpression { get; set; }
        public static string Profile_UnsubscribesSearchUnsubscribedSearchBy { get; set; }
        public static string Profile_UnsubscribesSearchUnsubscribedSearchFor { get; set; }
        public static string Profile_UnsubscribesSearchUnsubscribedSearch { get; set; }
        public static string Profile_UnsubscribesSearchUnsubscribedCancel { get; set; }

        public static string Profile_MergeGuestRecordsManualMergeTab { get; set; }
        public static string Profile_MergeGuestRecordsPotentialMergeTab { get; set; }
        public static string Profile_MergeGuestRecordsMergeHistoryTab { get; set; }
        public static string Profile_MergeGuestRecordsManualMergeFirstName { get; set; }
        public static string Profile_MergeGuestRecordsManualMergeLastName { get; set; }
        public static string Profile_MergeGuestRecordsManualMergeEmail { get; set; }
        public static string Profile_MergeGuestRecordsManualMergeZipCode { get; set; }
        public static string Profile_MergeGuestRecordsManualMergeCity { get; set; }
        public static string Profile_MergeGuestRecordsManualMergeState { get; set; }
        public static string Profile_MergeGuestRecordsManualMergeCompany { get; set; }
        public static string Profile_MergeGuestRecordsManualMergeSalutation { get; set; }
        public static string Profile_MergeGuestRecordsManualMergeSearchGuest { get; set; }
        public static string Profile_MergeGuestRecordsManualMergeCancel { get; set; }
        public static string Profile_MergeGuestRecordsManualMergeAddToMergeProcess { get; set; }
        public static string Profile_MergeGuestRecordsManualMergeRecordsToMerge { get; set; }
        public static string Profile_MergeGuestRecordsManualMergeCompare { get; set; }
        public static string Profile_CustomerProfileImage { get; set; }
        public static string Profile_CampaignHistory { get; set; }
        public static string Profile_StayTab { get; set; }
        public static string Profile_StayTabReservationPresent { get; set; }
        public static string Profile_RevenueDetails { get; set; }
        public static string Profile_Select_CampaignName { get; set; }
        public static string Profile_Grid_ReservationNumber { get; set; }
        public static string Profile_Grid_CampaignHistory_NumberofRows { get; set; }

        #endregion[Profile]

        #region[Home]
        public static string Home_Vertical_Nav_Profile { get; set; }
        public static string Home_Tab_AtAGlance_AllActivity { get; set; }
        public static string Home_Tab_AtAGlance_Created { get; set; }
        public static string Home_Tab_AtAGlance_CriteriaChanged { get; set; }
        public static string Home_Tab_AtAGlance_TemplateChanged { get; set; }
        public static string Home_Tab_AtAGlance_SentToTestEmailsHistory { get; set; }
        public static string Home_Tab_AtAGlance_DeliveryReportRequested { get; set; }
        public static string Home_Tab_AtAGlance_DeliveryReportReceived { get; set; }
        public static string Home_Tab_AtAGlance_ProceedForApproval { get; set; }
        public static string Home_Tab_AtAGlance_ApprovalRequested { get; set; }
        public static string Home_Tab_AtAGlance_Approved { get; set; }
        public static string Home_Tab_AtAGlance_Disapproved { get; set; }
        public static string Home_Tab_AtAGlance_Scheduled { get; set; }
        public static string Home_Tab_AtAGlance_Rescheduled { get; set; }
        public static string Home_Tab_AtAGlance_ScheduleDeactivated { get; set; }
        public static string Home_Tab_AtAGlance_Sent { get; set; }
        public static string Home_Tab_AtAGlance_Cancelled { get; set; }
        public static string Home_Tab_AtAGlance_Previous { get; set; }
        public static string Home_Tab_AtAGlance_Next { get; set; }
        public static string Home_Link_AtAGlance_GoToTab_Menu { get; set; }
        public static string Home_Link_AtAGlance_GoToTab_Created { get; set; }
        public static string Home_Link_AtAGlance_GoToTab_CriteriaChanged { get; set; }
        public static string Home_Link_AtAGlance_GoToTab_TemplateChanged { get; set; }
        public static string Home_Link_AtAGlance_GoToTab_SentToTestEmailsHistory { get; set; }
        public static string Home_Link_AtAGlance_GoToTab_DeliveryReportRequested { get; set; }
        public static string Home_Link_AtAGlance_GoToTab_DeliveryReportReceived { get; set; }
        public static string Home_Link_AtAGlance_GoToTab_ProceedForApproval { get; set; }
        public static string Home_Link_AtAGlance_GoToTab_ApprovalRequested { get; set; }
        public static string Home_Link_AtAGlance_GoToTab_Approved { get; set; }
        public static string Home_Link_AtAGlance_GoToTab_Disapproved { get; set; }
        public static string Home_Link_AtAGlance_GoToTab_Scheduled { get; set; }
        public static string Home_Link_AtAGlance_GoToTab_Rescheduled { get; set; }
        public static string Home_Link_AtAGlance_GoToTab_ScheduleDeactivated { get; set; }
        public static string Home_Link_AtAGlance_GoToTab_Sent { get; set; }
        public static string Home_Link_AtAGlance_GoToTab_Cancelled { get; set; }
        public static string Home_Link_AtAGlance_Campaign_1 { get; set; }
        public static string Home_Link_AtAGlance_Campaign_2 { get; set; }
        public static string Home_Link_AtAGlance_Campaign_3 { get; set; }
        public static string Home_Link_AtAGlance_ViewAllActivity { get; set; }
        public static string Home_Tab_RecentCampaigns { get; set; }
        public static string Home_Tab_Dashboard { get; set; }
        public static string Home_RecentlySentCampaign_DateRange_Marketing { get; set; }
        public static string Home_RecentlySentCampaign_DateRange_Trigger { get; set; }
        public static string Home_RecentlySentCampaign_DateRange_Transactionals { get; set; }
        public static string Home_DropDown_RecentlySentCampaigns_SelectClient { get; set; }
        public static string Home_DropDown_RecentlySentCampaigns_SelectCompany { get; set; }
        public static string Home_Tab_RecentlySentCampaigns_Email { get; set; }
        public static string Home_Tab_RecentlySentCampaigns_RealTime { get; set; }
        public static string Home_Tab_RecentlySentCampaigns_TextMessage { get; set; }
        public static string Home_Tab_RecentlySentCampaigns_KeywordTextMessage { get; set; }
        public static string Home_Tab_RecentlySentCampaigns_TextMessageResponses { get; set; }
        public static string Home_DropDown_RecentlySentCampaigns_ShowLast { get; set; }
        public static string Home_Button_RecentlySentCampaigns_CalendarFrom { get; set; }
        public static string Home_Button_RecentlySentCampaigns_CalendarThrough { get; set; }
        public static string Home_Button_RecentlySentCampaigns_Merge { get; set; }
        public static string Home_Button_RecentlySentCampaigns_FirstPage { get; set; }
        public static string Home_Button_RecentlySentCampaigns_PreviousPage { get; set; }
        public static string Home_Button_RecentlySentCampaigns_NextPage { get; set; }
        public static string Home_Button_RecentlySentCampaigns_LastPage { get; set; }
        public static string Home_Text_RecentlySentCampaigns_PageNumber { get; set; }
        public static string Home_DropDown_RecentlySentCampaigns_DisplayResultsNumber { get; set; }
        public static string Home_Button_RecentlySentCampaigns_ExcelReport { get; set; }
        public static string Home_Link_AtAGlance_GoToTab_AllActivity { get; set; }
        public static string Home_Option_DatatableLength_Marketing { get; set; }
        public static string Home_Option_DatatableLength_Trigger { get; set; }
        public static string Home_Option_DatatableLength_Transactional { get; set; }

        public static string Home_RecentlySentCampaign_DateRange_Trigger_NoResult { get; set; }

        #endregion[Home]

        #region[UserActions]
        public static string User_UserActions { get; set; }
        public static string UserAction_MyPreference { get; set; }
        public static string UserAction_MyPreference_Region { get; set; }
        public static string UserAction_MyPreference_Currency { get; set; }
        public static string UserAction_MyPreference_Save { get; set; }
        #endregion[UserActions]

        #region[ManageCampaign]
        public static string ManageCampaign_ClientDDM { get; set; }
        public static string ManageCampaign_CompanyDDM { get; set; }
        public static string ManageCampaign_AllTab { get; set; }
        public static string ManageCampaign_DraftTab { get; set; }
        public static string ManageCampaign_DeliverabilityTab { get; set; }
        public static string ManageCampaign_AwaitingApprovalTab { get; set; }
        public static string ManageCampaign_ApprovedTab { get; set; }
        public static string ManageCampaign_RecurringTab { get; set; }
        public static string ManageCampaign_ScheduledTab { get; set; }
        public static string ManageCampaign_DisapprovedTab { get; set; }
        public static string ManageCampaign_SearchTab { get; set; }
        public static string ManageCampaign_Search_SearchFieldDDM { get; set; }
        public static string ManageCampaign_Search_ConditionDDM { get; set; }
        public static string ManageCampaign_Search_Input { get; set; }
        public static string ManageCampaign_Search_SearchDateDDM { get; set; }
        public static string ManageCampaign_Search_BetweenFirst { get; set; }
        public static string ManageCampaign_Search_BetweenSecond { get; set; }
        public static string ManageCampaign_Search_SearchButton { get; set; }
        public static string ManageCampaign_Search_PreviewLink { get; set; }
        public static string ManageCampaign_Search_CriteriaLink { get; set; }
        public static string ManageCampaign_Search_CustomerDetails { get; set; }
        public static string ManageCampaign_Search_DynamicContentLink { get; set; }
        public static string ManageCampaign_Search_HistoryLink { get; set; }
        public static string ManageCampaign_Search_ReportsLink { get; set; }
        public static string ManageCampaign_Search_MultiLanguageLink { get; set; }
        public static string ManageCampaign_Clone { get; set; }

        public static string ManageCampaign_Search_PreviewClose { get; set; }
        public static string ManageCampaign_Search_CriteriaClose { get; set; }
        public static string ManageCampaign_Search_CustomerDetailsClose { get; set; }
        public static string ManageCampaign_Search_DynamicContentClose { get; set; }
        public static string ManageCampaign_Search_HistoryClose { get; set; }
        public static string ManageCampaign_Search_ReportsClose { get; set; }
        public static string ManageCampaign_MultiLanguageClose { get; set; }

        public static string ManageCampaign_Tab_Sent { get; set; }
        public static string ManageCampaign_Tab_Disapproved { get; set; }
        public static string ManageCampaign_Button_First { get; set; }
        public static string ManageCampaign_Button_Previous { get; set; }
        public static string ManageCampaign_Button_Next { get; set; }
        public static string ManageCampaign_Button_Last { get; set; }
        public static string ManageCampaign_Button_Help { get; set; }
        public static string ManageCampaign_Link_FirstCampaign_Preview { get; set; }
        public static string ManageCampaign_Link_FirstCampaign_Criteria { get; set; }
        public static string ManageCampaign_Link_FirstCampaign_CustomerDetails { get; set; }
        public static string ManageCampaign_Link_FirstCampaign_DynamicContent { get; set; }
        public static string ManageCampaign_Link_FirstCampaign_History { get; set; }
        public static string ManageCampaign_Link_FirstCampaign_Reports { get; set; }
        public static string ManageCampaign_Link_FirstCampaign_MultiLanguage { get; set; }
        public static string ManageCampaign_Link_FirstCampaign_ApprovalDashboard { get; set; }
        public static string ManageCampaign_Button_Campaign_BasicValidationReport { get; set; }
        public static string ManageCampaign_Button_Campaign_ScheduleCampaign { get; set; }
        public static string ManageCampaign_Button_FirstCampaign_AdvancedDeliverability { get; set; }
        public static string ManageCampaign_Button_FirstCampaign_SendToTestEmails { get; set; }
        public static string ManageCampaign_Button_FirstCampaign_RequestResponsive { get; set; }
        public static string ManageCampaign_Button_FirstCampaign_SendForTranslation { get; set; }
        public static string ManageCampaign_Button_FirstCampaign_DeleteCampaign { get; set; }
        public static string ManageCampaign_Button_FirstCampaign_Edit { get; set; }
        public static string ManageCampaign_ContinueDraft { get; set; }
        public static string ManageCampaign_Button_FirstCampaign_ProceedForApproval { get; set; }
        public static string ManageCampaign_Button_FirstCampaign_SaveAsTemplate { get; set; }
        public static string ManageCampaign_Button_FirstCampaign_SaveAsResent { get; set; }
        public static string ManageCampaign_Button_FirstCampaign_Clone { get; set; }
        public static string ManageCampaign_Link_FirstCampaign_Status { get; set; }
        public static string ManageCampaign_Button_CDetails_ViewCampaignRecipients { get; set; }
        public static string ManageCampaign_DDM_SearchBy { get; set; }
        public static string ManageCampaign_DDM_SearchExpression { get; set; }
        public static string ManageCampaign_DDM_SearchValue { get; set; }
        public static string ManageCampaign_CustomerDetailsVRD_ClickSearch { get; set; }
        public static string CASL_checkbox { get; set; }
        public static string SubmitSendToTestEmail { get; set; }
        public static string QuickSend_EmailtoSelf { get; set; }
        public static string ManageCampaign_EditSchedule { get; set; }
        public static string ManageCampaign_EditSchedule_Confirm { get; set; }
        public static string ManageCampaign_EditCampaign { get; set; }
        public static string ManageCampaign_ScheduleCampaign { get; set; }
        public static string ManageCampaign_Button_Campaign_InactivateSchedule { get; set; }
        public static string ManageCampaign_Button_Campaign_InactivateScheduleConfirm { get; set; }
        public static string ManageCampaign_Button_Campaign_ActivateSchedule { get; set; }
        public static string ManageCampaign_Button_Campaign_ActivateScheduleConfirm { get; set; }
        public static string ManageCampaign_SendToTest_GroupSeedList { get; set; }
        public static string ManageCampaign_QuickSend_ReservationSelect { get; set; }
        public static string ProjectID_Search { get; set; }
        public static string ProjectID_SearchExpression { get; set; }
        public static string ProjectID_TextSearch { get; set; }
        public static string ProjectID_TextSearchs { get; set; }
        public static string ProjectID_TextSearch_Filter { get; set; }
        public static string ProjectID_TextSearch_Filters { get; set; }
        public static string ProjectID_CampaignDetails_Testing { get; set; }
        public static string ProjectID_CampaignDetails_Testing_Advanced { get; set; }
        public static string ProjectID_CampaignDetails_Testing_Advanced_InboxPreview { get; set; }
        public static string ProjectID_CampaignDetails_Testing_Advanced_InboxForecaster { get; set; }
        public static string ProjectID_CampaignDetails_Actions { get; set; }
        public static string CampaignDetails_Actions_Edit { get; set; }
        public static string CampaignDetails_Actions_Clone { get; set; }
        public static string CampaignDetails_Actions_Delete { get; set; }
        public static string CampaignDetails_Actions_SaveAsResend { get; set; }
        public static string CampaignDetails_Actions_SaveAsTemplate { get; set; }
        #endregion[ManageCampaign]

        #region[Settings]
        public static string Settings_AccessControl_MergeGuestCheckbox { get; set; }
        public static string Settings_AccessControl { get; set; }
        public static string Settings_AccessControl_MergeGuest { get; set; }
        public static string Settings_AccessControl_Save { get; set; }
        #endregion[Settings]

        #region[CreateCampaign]
        public static string CreateCampaign_Button_Save { get; set; }
        public static string CreateCampaign_Button_SaveAndContinue { get; set; }
        public static string CreateCampaign_Button_Continue { get; set; }
        public static string CreateCampaign_Button_SaveAndContinue_Submit { get; set; }
        public static string CreateCampaign_Link_CriteriaTab { get; set; }
        public static string CreateCampaign_Link_CriteriaTab_TotalArrow { get; set; }
        public static string CreateCampaign_Link_CriteriaTab_Loader { get; set; }
        public static string CreateCampaign_Link_CriteriaTab_Generate { get; set; }

        public static string CreateCampaign_CriteriaTab_ForecastTargetAudience { get; set; }
        public static string CreateCampaign_Link_TemplateTab { get; set; }
        public static string CreateCampaign_Button_ChangeTemplate { get; set; }
        public static string CreateCampaign_Link_TestingTab { get; set; }
        public static string CreateCampaign_Link_ApprovalTab { get; set; }
        public static string CreateCampaign_Link_ScheduleTab { get; set; }
        public static string CreateCampaign_Link_AMResorts { get; set; }
        public static string CreateCampaign_Link_ { get; set; }
        public static string CreateCampaign_Text_Filter { get; set; }
        public static string CreateCampaign_Link_CendynHotel { get; set; }
        public static string CreateCampaign_Link_CendynHotelResort { get; set; }
        public static string CreateCampaign_Button_TestingSendtoTest { get; set; }
        public static string CreateCampaign_Testing_SendForApproval { get; set; }
        public static string CreateCampaign_Link_Campaign_Approve { get; set; }
        public static string CreateCampaign_Link_Campaign_ApproveConfirmation { get; set; }
        public static string CreateCampaign_Link_Campaign_Disapprove { get; set; }
        public static string CreateCampaign_Link_Campaign_DisapproveConfirmation { get; set; }
        public static string CreateCampaign_DropDown_Schedule_Hours { get; set; }
        public static string CreateCampaign_DropDown_Schedule_Minutes { get; set; }
        public static string CreateCampaign_DropDown_Schedule_TimeType { get; set; }
        public static string CreateCampaign_Button_Campaign_ScheduleandCompleteCampaign { get; set; }
        public static string CreateCampaign_Button_Campaign_UpdateSchedule { get; set; }
        public static string CreateCampaign_EditTemplate_Subject { get; set; }
        public static string CreateCampaign_EditTemplate_LinkSubjectTag { get; set; }
        public static string CreateCampaign_EditTemplate_LinkSubjectTag_Map { get; set; }
        public static string CreateCampaign_EditTemplate_FromName { get; set; }
        public static string CreateCampaign_EditTemplate_ReplyEmail { get; set; }
        public static string CreateCampaign_AudienceName_ApprovalPage { get; set; }
        public static string CreateCampaign_AudienceName_SchedulePage { get; set; }
        public static string CreateCampaign_CriteriaPage_Save { get; set; }
        public static string CreateCampaign_CriteriaPage_SaveandContinue { get; set; }
        public static string CreateCampaign_CriteriaPage_Clear { get; set; }
        public static string CreateCampaign_TemplatePage_Save { get; set; }
        public static string CreateCampaign_TemplateAndTestingPage_SaveandContinue { get; set; }

        public static string CreateCampaign_Templates_ListView_Btn { get; set; }
        public static string CreateCampaign_Templates_ListView_Loader { get; set; }

        public static string CreateCampaign_Templates_ListView_NameFilterIcon { get; set; }
        public static string CreateCampaign_Templates_ListView_FilterSelection { get; set; }
        public static string CreateCampaign_Templates_ListView_Filter_Btn { get; set; }
        public static string CreateCampaign_Templates_ListView_Input_Filter_Txt { get; set; }
        public static string CreateCampaign_Templates_SaveAndContinue_Btn { get; set; }
        
        #endregion[CreateCampaign]

        #region[CreateCampaign_Criteria]
        public static string CreateCampaign_Criteria_Text_CampaignName { get; set; }
        public static string CreateCampaign_Criteria_Text_Brand { get; set; }
        public static string CreateCampaign_Criteria_Button_Brand_RemoveFirstBrand { get; set; }
        public static string CreateCampaign_Criteria_Button_Save { get; set; }
        //public static string CreateCampaign_Criteria_Button_SaveAndContinue { get; set; }
        public static string CreateCampaign_Criteria_Button_Clear { get; set; }
        public static string CreateCampaign_Criteria_Text_PropertyList { get; set; }
        public static string CreateCampaign_Criteria_Button_PropertyList_RemoveFirstPropertyList { get; set; }
        public static string CreateCampaign_Criteria_Text_SeedList { get; set; }
        public static string CreateCampaign_Criteria_Button_SeedList_RemoveFirstSeedList { get; set; }
        public static string CreateCampaign_Criteria_Button_ForecastTargetAudience { get; set; }
        public static string CreateCampaign_Criteria_Button_NewSegment_Top { get; set; }
        public static string CreateCampaign_Criteria_Button_NewSegment_Bottom { get; set; }
        public static string CreateCampaign_Criteria_Button_TransactionalSettings_HideShow { get; set; }
        public static string CreateCampaign_Criteria_DropDown_TransactionalSettings_ReservationEvent { get; set; }
        public static string CreateCampaign_Criteria_CheckBox_TransactionalSettings_EmailType_Email { get; set; }
        public static string CreateCampaign_Criteria_CheckBox_TransactionalSettings_EmailType_RESERVATIONEMAIL { get; set; }
        public static string CreateCampaign_Criteria_CheckBox_TransactionalSettings_UseFirstAvailableSelectedEmailType { get; set; }
        public static string CreateCampaign_Criteria_CheckBox_TransactionalSettings_IncludeUnsubscribe { get; set; }
        public static string CreateCampaign_Criteria_Button_CollapseAll { get; set; }
        public static string CreateCampaign_Criteria_Button_ExpandAll { get; set; }
        public static string CreateCampaign_Criteria_Text_Segment_SegmentDescription { get; set; }
        public static string CreateCampaign_Criteria_DropDown_Segment_Include { get; set; }
        public static string CreateCampaign_Criteria_DropDown_Segment_AndOrNandNor { get; set; }
        public static string CreateCampaign_Criteria_Button_Segment_CollapseExpand { get; set; }
        public static string CreateCampaign_Criteria_Button_Segment_Close { get; set; }
        public static string CreateCampaign_Criteria_Button_Segment_First_SelectAll { get; set; }
        public static string CreateCampaign_Criteria_Button_Segment_First_Clone { get; set; }
        public static string CreateCampaign_Criteria_Button_Segment_First_Remove { get; set; }
        public static string CreateCampaign_Criteria_Text_Segment_DataSource { get; set; }
        #endregion[CreateCampaign_Criteria]
        
        #region[AudienceBuilder]
        public static string AB_Button_Add { get; set; }
        public static string AB_Button_AddSearchField { get; set; }
        public static string AB_Checkbox_ShowInactive { get; set; }
        public static string AB_Button_Reset { get; set; }
        public static string AB_Button_Search { get; set; }
        public static string AB_CustomerDetailsSearchContent { get; set; }
        public static string AB_Grid_LastPublished { get; set; }
        public static string AB_Grid_LastSaved { get; set; }
        public static string AB_Grid_ButtonAction { get; set; }
        public static string AB_Grid_EditAudience { get; set; }
        public static string Click_TotalCounts_Audience { get; set; }
        public static string Click_ABEdit_StayOnPage { get; set; }
        public static string Click_ABEdit_LeavePage { get; set; }
        public static string AB_Listbox_selectField { get; set; }
        public static string AB_TextBox_FieldValue { get; set; }
        public static string Click_ABGrid_ButtonDetail { get; set; }
        public static string Click_ABGrid_AudienceClone { get; set; }
        public static string Click_ABEdit_SavePublishButton { get; set; }
        public static string Click_ABEdit_CancelButton { get; set; }
        public static string Click_ABEdit_FirstTime_TotalRecords { get; set; }
        public static string Click_ABEdit_TotalRecords { get; set; }
        public static string AB_IFrame { get; set; }
        #endregion[AudienceBuilder]

        #region[PriorityQ]
        public static string PriorityQ_SearchFor { get; set; }
        public static string PriorityQ_Reset { get; set; }
        public static string PriorityQ_Submit { get; set; }
        public static string PriorityQ_Filter { get; set; }
        public static string PriorityQ_ToEmail { get; set; }
        public static string PriorityQ_CampaignContainer { get; set; }
        public static string PriorityQ_CampaignContainer_filter { get; set; }
        public static string PriorityQ_SendtoTest { get; set; }
        public static string PriorityQ_SendtoTestButton { get; set; }
        public static string PriorityQ_SendEmail_Cancel { get; set; }
        public static string PriorityQ_SendEmail_Prompt_Cancel { get; set; }
        #endregion[PriorityQ]

        #region[TemplateBuilder]
            public static string TemplateBuilder_SearchTemplate { get; set; }

        #endregion[TemplateBuilder]

        #endregion[UI]

        public static ObjectRepository ReadElement(string location, string nodeModule)
        {
            ObjectRepository obj = new ObjectRepository();
            XDocument doc = XDocument.Load(location);
            var query = doc.Descendants(nodeModule).Elements()
                .ToDictionary(x => x.Attribute("key").Value,
                    x => x.Value);

            foreach (KeyValuePair<string, string> pair in query)
            {
                #region[Admin]

                if (nodeModule == Constants.Admin)
                {
                    if (pair.Key == "Click_AllTabs")
                        Click_AllTabs = pair.Value;
                    if (pair.Key == "Click_Open_SpecificPropertySetting")
                        Click_Open_SpecificPropertySetting = pair.Value;
                    if (pair.Key == "Click_Tab_CompanySettings")
                        Click_Tab_CompanySettings = pair.Value;
                    if (pair.Key == "Admin_CompanySetting_Textbox_SettingValue")
                        Admin_CompanySetting_Textbox_SettingValue = pair.Value;
                    if (pair.Key == "Admin_CompanySetting_Button_Submit")
                        Admin_CompanySetting_Button_Submit = pair.Value;
                }
                #endregion[Admin]

                #region[Login]

                if (nodeModule == Constants.Login)
                {
                    if (pair.Key == "Login_IFrame")
                        Login_IFrame = pair.Value;
                    else if (pair.Key == "Login_IFrame_AgreeProceed")
                        Login_IFrame_AgreeProceed = pair.Value;
                    else if (pair.Key == "Login_IFrame_AgreeProceed_Close")
                        Login_IFrame_AgreeProceed_Close = pair.Value;
                    else if (pair.Key == "Login_Email")
                        Login_Email = pair.Value;
                    else if (pair.Key == "Login_Password")
                        Login_Password = pair.Value;
                    else if (pair.Key == "Login_Submit")
                        Login_Submit = pair.Value;
                    else if (pair.Key == "Login_ForgotPassword")
                        Login_ForgotPassword = pair.Value;
                    else if (pair.Key == "Login_ResetPassword")
                        Login_ResetPassword = pair.Value;
                    else if (pair.Key == "Login_Text_ForgotPassword_Email")
                        Login_Text_ForgotPassword_Email = pair.Value;
                    else if (pair.Key == "Login_Button_ForgotPassword_Submit")
                        Login_Button_ForgotPassword_Submit = pair.Value;
                    else if (pair.Key == "Login_NewPassword")
                        Login_NewPassword = pair.Value;
                    else if (pair.Key == "Login_NewConfirmPassword")
                        Login_NewConfirmPassword = pair.Value;
                    else if (pair.Key == "Login_ResetPassword_Submit")
                        Login_ResetPassword_Submit = pair.Value;
                }

                #endregion[Login]

                #region[Navigation]

                if (nodeModule == Constants.Navigation)
                {
                    if (pair.Key == "UserProfileIcon")
                    {
                        UserProfileIcon = pair.Value;
                    }
                    else if (pair.Key == "AdminLink")
                    {
                        AdminLink = pair.Value;
                    }
                    else if (pair.Key == "SettingsLink")
                    {
                        SettingsLink = pair.Value;
                    }
                    else if (pair.Key == "MyPreferenceLink")
                    {
                        MyPreferenceLink = pair.Value;
                    }
                    else if (pair.Key == "Navigation_Home")
                    {
                        Navigation_Home = pair.Value;
                    }
                    else if (pair.Key == "Navigation_Profile")
                    {
                        Navigation_Profile = pair.Value;
                    }
                    else if (pair.Key == "Navigation_Audiences")
                    {
                        Navigation_Audiences = pair.Value;
                    }
                    else if (pair.Key == "Navigation_CreateCampaign")
                    {
                        Navigation_CreateCampaign = pair.Value;
                    }
                    else if (pair.Key == "Navigation_ManageCampaign")
                    {
                        Navigation_ManageCampaign = pair.Value;
                    }
                    else if (pair.Key == "Navigation_Calendar")
                    {
                        Navigation_Calendar = pair.Value;
                    }
                    else if (pair.Key == "Navigation_eGallery")
                    {
                        Navigation_eGallery = pair.Value;
                    }
                    else if (pair.Key == "Navigation_Reports")
                    {
                        Navigation_Reports = pair.Value;
                    }
                    else if (pair.Key == "Navigation_Survey")
                    {
                        Navigation_Survey = pair.Value;
                    }
                    else if (pair.Key == "Navigation_Link_Monitoring")
                        Navigation_Link_Monitoring = pair.Value;
                    else if (pair.Key == "Navigation_Link_Settings")
                        Navigation_Link_Settings = pair.Value;
                    else if (pair.Key == "Navigation_Link_Admin")
                        Navigation_Link_Admin = pair.Value;
                    else if (pair.Key == "Navigation_Link_MainMenu")
                        Navigation_Link_MainMenu = pair.Value;
                    else if (pair.Key == "Navigation_Link_Help")
                        Navigation_Link_Help = pair.Value;
                    else if (pair.Key == "Navigation_Link_LogOut")
                        Navigation_Link_LogOut = pair.Value;
                    else if (pair.Key == "Navigation_Link_ProductList_Show")
                        Navigation_Link_ProductList_Show = pair.Value;
                    else if (pair.Key == "Navigation_Link_ProductList_eInsight")
                        Navigation_Link_ProductList_eInsight = pair.Value;
                    else if (pair.Key == "Navigation_Link_ProductList_eConcierge")
                        Navigation_Link_ProductList_eConcierge = pair.Value;
                    else if (pair.Key == "Navigation_Link_ProductList_eSurvey")
                        Navigation_Link_ProductList_eSurvey = pair.Value;
                    else if (pair.Key == "Navigation_Link_ProductList_Loyalty")
                        Navigation_Link_ProductList_Loyalty = pair.Value;
                    else if (pair.Key == "Navigation_Link_ProductList_eInsightReports")
                        Navigation_Link_ProductList_eInsightReports = pair.Value;
                    else if (pair.Key == "AudienceBuilder")
                        AudienceBuilder = pair.Value;
                }

                #endregion[Navigation]

                #region[Profile]

                if (nodeModule == Constants.Profile)
                {
                    if (pair.Key == "Profile_Client")
                    {
                        Profile_Client = pair.Value;
                    }
                    if (pair.Key == "Profile_Sub_Client")
                    {
                        Profile_Sub_Client = pair.Value;
                    }
                    if (pair.Key == "Profile_Sub_Client_SearchField")
                    {
                        Profile_Sub_Client_SearchField = pair.Value;
                    }
                    else if (pair.Key == "Profile_Company")
                    {
                        Profile_Company = pair.Value;
                    }
                    else if (pair.Key == "Profile_SearchGuestsTab")
                    {
                        Profile_SearchGuestsTab = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsTab")
                    {
                        Profile_AddGuestsTab = pair.Value;
                    }
                    else if (pair.Key == "Profile_UnsubscribesTab")
                    {
                        Profile_UnsubscribesTab = pair.Value;
                    }
                    else if (pair.Key == "Profile_MergeGuestRecordsTab")
                    {
                        Profile_MergeGuestRecordsTab = pair.Value;
                    }
                    else if (pair.Key == "Profile_SearchGuestsSearchExpression")
                    {
                        Profile_SearchGuestsSearchExpression = pair.Value;
                    }
                    else if (pair.Key == "Profile_SearchGuestsSearchBy")
                    {
                        Profile_SearchGuestsSearchBy = pair.Value;
                    }
                    else if (pair.Key == "Profile_SearchGuestsSearchFor")
                    {
                        Profile_SearchGuestsSearchFor = pair.Value;
                    }
                    else if (pair.Key == "Profile_SearchGuestsSearch")
                    {
                        Profile_SearchGuestsSearch = pair.Value;
                    }
                    else if (pair.Key == "Profile_SearchGuestsCancel")
                    {
                        Profile_SearchGuestsCancel = pair.Value;
                    }
                    else if (pair.Key == "Profile_SearchByCustomerPresent")
                    {
                        Profile_SearchByCustomerPresent = pair.Value;
                    }
                    else if (pair.Key == "Profile_SearchGuestsFirstResult")
                    {
                        Profile_SearchGuestsFirstResult = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsUploadNewFileTab")
                    {
                        Profile_AddGuestsUploadNewFileTab = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsManuallyAddGuestTab")
                    {
                        Profile_AddGuestsManuallyAddGuestTab = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsUploadNewFileCreateNewSourceRb")
                    {
                        Profile_AddGuestsUploadNewFileCreateNewSourceRb = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsUploadNewFileCreateNewSourceName")
                    {
                        Profile_AddGuestsUploadNewFileCreateNewSourceName = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsUploadNewFileCreateNewSourceChooseFile")
                    {
                        Profile_AddGuestsUploadNewFileCreateNewSourceChooseFile = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsUploadNewFileCreateNewSourceSubmit")
                    {
                        Profile_AddGuestsUploadNewFileCreateNewSourceSubmit = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsUploadNewFileCreateNewSourceReset")
                    {
                        Profile_AddGuestsUploadNewFileCreateNewSourceReset = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsUploadNewFileUpdateExistingSourceRb")
                    {
                        Profile_AddGuestsUploadNewFileUpdateExistingSourceRb = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsUploadNewFileUpdateExistingSourceName")
                    {
                        Profile_AddGuestsUploadNewFileUpdateExistingSourceName = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsUploadNewFileUpdateExistingSourceName_SelectSource")
                    {
                        Profile_AddGuestsUploadNewFileUpdateExistingSourceName_SelectSource = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsUploadNewFileUpdateExistingSourceChooseFile")
                    {
                        Profile_AddGuestsUploadNewFileUpdateExistingSourceChooseFile = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsUploadNewFileUpdateExistingSourceSubmit")
                    {
                        Profile_AddGuestsUploadNewFileUpdateExistingSourceSubmit = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsUploadNewFileUpdateExistingSourceReset")
                    {
                        Profile_AddGuestsUploadNewFileUpdateExistingSourceReset = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsManuallyAddGuestPrefix")
                    {
                        Profile_AddGuestsManuallyAddGuestPrefix = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsManuallyAddGuestFirstName")
                    {
                        Profile_AddGuestsManuallyAddGuestFirstName = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsManuallyAddGuestLastName")
                    {
                        Profile_AddGuestsManuallyAddGuestLastName = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsManuallyAddGuestAddress1")
                    {
                        Profile_AddGuestsManuallyAddGuestAddress1 = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsManuallyAddGuestAddress2")
                    {
                        Profile_AddGuestsManuallyAddGuestAddress2 = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsManuallyAddGuestCity")
                    {
                        Profile_AddGuestsManuallyAddGuestCity = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsManuallyAddGuestState")
                    {
                        Profile_AddGuestsManuallyAddGuestState = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsManuallyAddGuestZip")
                    {
                        Profile_AddGuestsManuallyAddGuestZip = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsManuallyAddGuestCountryCode")
                    {
                        Profile_AddGuestsManuallyAddGuestCountryCode = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsManuallyAddGuestNewSourceNameRb")
                    {
                        Profile_AddGuestsManuallyAddGuestNewSourceNameRb = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsManuallyAddGuestNewSourceNameText")
                    {
                        Profile_AddGuestsManuallyAddGuestNewSourceNameText = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsManuallyAddGuestExistingSourceRb")
                    {
                        Profile_AddGuestsManuallyAddGuestExistingSourceRb = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsManuallyAddGuestExistingSourceDropdown")
                    {
                        Profile_AddGuestsManuallyAddGuestExistingSourceDropdown = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsManuallyAddGuestEmail")
                    {
                        Profile_AddGuestsManuallyAddGuestEmail = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsManuallyAddGuestCompany")
                    {
                        Profile_AddGuestsManuallyAddGuestCompany = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsManuallyAddGuestTitle")
                    {
                        Profile_AddGuestsManuallyAddGuestTitle = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsManuallyAddGuestWorkPhone")
                    {
                        Profile_AddGuestsManuallyAddGuestWorkPhone = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsManuallyAddGuestWorkExt")
                    {
                        Profile_AddGuestsManuallyAddGuestWorkExt = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsManuallyAddGuestFax")
                    {
                        Profile_AddGuestsManuallyAddGuestFax = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsManuallyAddGuestMobile")
                    {
                        Profile_AddGuestsManuallyAddGuestMobile = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsManuallyAddGuestHome")
                    {
                        Profile_AddGuestsManuallyAddGuestHome = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsManuallyAddGuestSourceOfBusiness")
                    {
                        Profile_AddGuestsManuallyAddGuestSourceOfBusiness = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsManuallyAddGuestNext")
                    {
                        Profile_AddGuestsManuallyAddGuestNext = pair.Value;
                    }
                    else if (pair.Key == "Profile_AddGuestsManuallyAddGuestReset")
                    {
                        Profile_AddGuestsManuallyAddGuestReset = pair.Value;
                    }
                    else if (pair.Key == "Profile_UnsubscribesFileUploadTab")
                    {
                        Profile_UnsubscribesFileUploadTab = pair.Value;
                    }
                    else if (pair.Key == "Profile_UnsubscribesOneAtATimeTab")
                    {
                        Profile_UnsubscribesOneAtATimeTab = pair.Value;
                    }
                    else if (pair.Key == "Profile_UnsubscribesFileUploadSearchUnsubscribedTab")
                    {
                        Profile_UnsubscribesFileUploadSearchUnsubscribedTab = pair.Value;
                    }
                    else if (pair.Key == "Profile_UnsubscribesFileUploadBrowse")
                    {
                        Profile_UnsubscribesFileUploadBrowse = pair.Value;
                    }
                    else if (pair.Key == "Profile_UnsubscribesFileUploadSubmit")
                    {
                        Profile_UnsubscribesFileUploadSubmit = pair.Value;
                    }
                    else if (pair.Key == "Profile_UnsubscribesFileUploadCancel")
                    {
                        Profile_UnsubscribesFileUploadCancel = pair.Value;
                    }
                    else if (pair.Key == "Profile_UnsubscribesOneAtATimeEmail")
                    {
                        Profile_UnsubscribesOneAtATimeEmail = pair.Value;
                    }
                    else if (pair.Key == "Profile_UnsubscribesOneAtATimeProjectId")
                    {
                        Profile_UnsubscribesOneAtATimeProjectId = pair.Value;
                    }
                    else if (pair.Key == "Profile_UnsubscribesOneAtATimeMethod")
                    {
                        Profile_UnsubscribesOneAtATimeMethod = pair.Value;
                    }
                    else if (pair.Key == "Profile_UnsubscribesOneAtATimeComments")
                    {
                        Profile_UnsubscribesOneAtATimeComments = pair.Value;
                    }
                    else if (pair.Key == "Profile_UnsubscribesOneAtATimeSubmit")
                    {
                        Profile_UnsubscribesOneAtATimeSubmit = pair.Value;
                    }
                    else if (pair.Key == "Profile_UnsubscribesOneAtATimeCancel")
                    {
                        Profile_UnsubscribesOneAtATimeCancel = pair.Value;
                    }
                    else if (pair.Key == "Profile_UnsubscribesSearchUnsubscribedSearchExpression")
                    {
                        Profile_UnsubscribesSearchUnsubscribedSearchExpression = pair.Value;
                    }
                    else if (pair.Key == "Profile_UnsubscribesSearchUnsubscribedSearchBy")
                    {
                        Profile_UnsubscribesSearchUnsubscribedSearchBy = pair.Value;
                    }
                    else if (pair.Key == "Profile_UnsubscribesSearchUnsubscribedSearchFor")
                    {
                        Profile_UnsubscribesSearchUnsubscribedSearchFor = pair.Value;
                    }
                    else if (pair.Key == "Profile_UnsubscribesSearchUnsubscribedSearch")
                    {
                        Profile_UnsubscribesSearchUnsubscribedSearch = pair.Value;
                    }
                    else if (pair.Key == "Profile_UnsubscribesSearchUnsubscribedCancel")
                    {
                        Profile_UnsubscribesSearchUnsubscribedCancel = pair.Value;
                    }
                    else if (pair.Key == "Profile_MergeGuestRecordsManualMergeTab")
                    {
                        Profile_MergeGuestRecordsManualMergeTab = pair.Value;
                    }
                    else if (pair.Key == "Profile_MergeGuestRecordsPotentialMergeTab")
                    {
                        Profile_MergeGuestRecordsPotentialMergeTab = pair.Value;
                    }
                    else if (pair.Key == "Profile_MergeGuestRecordsMergeHistoryTab")
                    {
                        Profile_MergeGuestRecordsMergeHistoryTab = pair.Value;
                    }
                    else if (pair.Key == "Profile_MergeGuestRecordsManualMergeFirstName")
                    {
                        Profile_MergeGuestRecordsManualMergeFirstName = pair.Value;
                    }
                    else if (pair.Key == "Profile_MergeGuestRecordsManualMergeLastName")
                    {
                        Profile_MergeGuestRecordsManualMergeLastName = pair.Value;
                    }
                    else if (pair.Key == "Profile_MergeGuestRecordsManualMergeEmail")
                    {
                        Profile_MergeGuestRecordsManualMergeEmail = pair.Value;
                    }
                    else if (pair.Key == "Profile_MergeGuestRecordsManualMergeZipCode")
                    {
                        Profile_MergeGuestRecordsManualMergeZipCode = pair.Value;
                    }
                    else if (pair.Key == "Profile_MergeGuestRecordsManualMergeCity")
                    {
                        Profile_MergeGuestRecordsManualMergeCity = pair.Value;
                    }
                    else if (pair.Key == "Profile_MergeGuestRecordsManualMergeState")
                    {
                        Profile_MergeGuestRecordsManualMergeState = pair.Value;
                    }
                    else if (pair.Key == "Profile_MergeGuestRecordsManualMergeCompany")
                    {
                        Profile_MergeGuestRecordsManualMergeCompany = pair.Value;
                    }
                    else if (pair.Key == "Profile_MergeGuestRecordsManualMergeSalutation")
                    {
                        Profile_MergeGuestRecordsManualMergeSalutation = pair.Value;
                    }
                    else if (pair.Key == "Profile_MergeGuestRecordsManualMergeSearchGuest")
                    {
                        Profile_MergeGuestRecordsManualMergeSearchGuest = pair.Value;
                    }
                    else if (pair.Key == "Profile_MergeGuestRecordsManualMergeCancel")
                    {
                        Profile_MergeGuestRecordsManualMergeCancel = pair.Value;
                    }
                    else if (pair.Key == "Profile_MergeGuestRecordsManualMergeAddToMergeProcess")
                    {
                        Profile_MergeGuestRecordsManualMergeAddToMergeProcess = pair.Value;
                    }
                    else if (pair.Key == "Profile_MergeGuestRecordsManualMergeRecordsToMerge")
                    {
                        Profile_MergeGuestRecordsManualMergeRecordsToMerge = pair.Value;
                    }
                    else if (pair.Key == "Profile_MergeGuestRecordsManualMergeCompare")
                    {
                        Profile_MergeGuestRecordsManualMergeCompare = pair.Value;
                    }
                    else if (pair.Key == "Profile_CustomerProfileImage")
                    {
                        Profile_CustomerProfileImage = pair.Value;
                    }
                    else if (pair.Key == "Profile_CampaignHistory")
                    {
                        Profile_CampaignHistory = pair.Value;
                    }
                    else if (pair.Key == "Profile_StayTab")
                    {
                        Profile_StayTab = pair.Value;
                    }
                    else if (pair.Key == "Profile_StayTabReservationPresent")
                    {
                        Profile_StayTabReservationPresent = pair.Value;
                    }
                    else if (pair.Key == "Profile_RevenueDetails")
                    {
                        Profile_RevenueDetails = pair.Value;
                    }
                    else if (pair.Key == "Profile_Select_CampaignName")
                    {
                        Profile_Select_CampaignName = pair.Value;
                    }
                    else if (pair.Key == "Profile_Grid_ReservationNumber")
                    {
                        Profile_Grid_ReservationNumber = pair.Value;
                    }
                    else if (pair.Key == "Profile_Grid_CampaignHistory_NumberofRows")
                    {
                        Profile_Grid_CampaignHistory_NumberofRows = pair.Value;
                    }
                }

                #endregion[Profile]

                #region[Home]
                if (nodeModule == Constants.Home)
                {
                    if (pair.Key == "Home_Vertical_Nav_Profile")
                        Home_Vertical_Nav_Profile = pair.Value;
                    else if (pair.Key == "Home_Tab_AtAGlance_AllActivity")
                        Home_Tab_AtAGlance_AllActivity = pair.Value;
                    else if (pair.Key == "Home_Tab_AtAGlance_Created")
                        Home_Tab_AtAGlance_Created = pair.Value;
                    else if (pair.Key == "Home_Tab_AtAGlance_CriteriaChanged")
                        Home_Tab_AtAGlance_CriteriaChanged = pair.Value;
                    else if (pair.Key == "Home_Tab_AtAGlance_TemplateChanged")
                        Home_Tab_AtAGlance_TemplateChanged = pair.Value;
                    else if (pair.Key == "Home_Tab_AtAGlance_SentToTestEmailsHistory")
                        Home_Tab_AtAGlance_SentToTestEmailsHistory = pair.Value;
                    else if (pair.Key == "Home_Tab_AtAGlance_DeliveryReportRequested")
                        Home_Tab_AtAGlance_DeliveryReportRequested = pair.Value;
                    else if (pair.Key == "Home_Tab_AtAGlance_DeliveryReportReceived")
                        Home_Tab_AtAGlance_DeliveryReportReceived = pair.Value;
                    else if (pair.Key == "Home_Tab_AtAGlance_ProceedForApproval")
                        Home_Tab_AtAGlance_ProceedForApproval = pair.Value;
                    else if (pair.Key == "Home_Tab_AtAGlance_ApprovalRequested")
                        Home_Tab_AtAGlance_ApprovalRequested = pair.Value;
                    else if (pair.Key == "Home_Tab_AtAGlance_Approved")
                        Home_Tab_AtAGlance_Approved = pair.Value;
                    else if (pair.Key == "Home_Tab_AtAGlance_Disapproved")
                        Home_Tab_AtAGlance_Disapproved = pair.Value;
                    else if (pair.Key == "Home_Tab_AtAGlance_Scheduled")
                        Home_Tab_AtAGlance_Scheduled = pair.Value;
                    else if (pair.Key == "Home_Tab_AtAGlance_Rescheduled")
                        Home_Tab_AtAGlance_Rescheduled = pair.Value;
                    else if (pair.Key == "Home_Tab_AtAGlance_ScheduleDeactivated")
                        Home_Tab_AtAGlance_ScheduleDeactivated = pair.Value;
                    else if (pair.Key == "Home_Tab_AtAGlance_Sent")
                        Home_Tab_AtAGlance_Sent = pair.Value;
                    else if (pair.Key == "Home_Tab_AtAGlance_Cancelled")
                        Home_Tab_AtAGlance_Cancelled = pair.Value;
                    else if (pair.Key == "Home_Tab_AtAGlance_Previous")
                        Home_Tab_AtAGlance_Previous = pair.Value;
                    else if (pair.Key == "Home_Tab_AtAGlance_Next")
                        Home_Tab_AtAGlance_Next = pair.Value;
                    else if (pair.Key == "Home_Link_AtAGlance_GoToTab_Menu")
                        Home_Link_AtAGlance_GoToTab_Menu = pair.Value;
                    else if (pair.Key == "Home_Link_AtAGlance_GoToTab_Created")
                        Home_Link_AtAGlance_GoToTab_Created = pair.Value;
                    else if (pair.Key == "Home_Link_AtAGlance_GoToTab_CriteriaChanged")
                        Home_Link_AtAGlance_GoToTab_CriteriaChanged = pair.Value;
                    else if (pair.Key == "Home_Link_AtAGlance_GoToTab_TemplateChanged")
                        Home_Link_AtAGlance_GoToTab_TemplateChanged = pair.Value;
                    else if (pair.Key == "Home_Link_AtAGlance_GoToTab_SentToTestEmailsHistory")
                        Home_Link_AtAGlance_GoToTab_SentToTestEmailsHistory = pair.Value;
                    else if (pair.Key == "Home_Link_AtAGlance_GoToTab_DeliveryReportRequested")
                        Home_Link_AtAGlance_GoToTab_DeliveryReportRequested = pair.Value;
                    else if (pair.Key == "Home_Link_AtAGlance_GoToTab_DeliveryReportReceived")
                        Home_Link_AtAGlance_GoToTab_DeliveryReportReceived = pair.Value;
                    else if (pair.Key == "Home_Link_AtAGlance_GoToTab_ProceedForApproval")
                        Home_Link_AtAGlance_GoToTab_ProceedForApproval = pair.Value;
                    else if (pair.Key == "Home_Link_AtAGlance_GoToTab_ApprovalRequested")
                        Home_Link_AtAGlance_GoToTab_ApprovalRequested = pair.Value;
                    else if (pair.Key == "Home_Link_AtAGlance_GoToTab_Approved")
                        Home_Link_AtAGlance_GoToTab_Approved = pair.Value;
                    else if (pair.Key == "Home_Link_AtAGlance_GoToTab_Disapproved")
                        Home_Link_AtAGlance_GoToTab_Disapproved = pair.Value;
                    else if (pair.Key == "Home_Link_AtAGlance_GoToTab_Scheduled")
                        Home_Link_AtAGlance_GoToTab_Scheduled = pair.Value;
                    else if (pair.Key == "Home_Link_AtAGlance_GoToTab_Rescheduled")
                        Home_Link_AtAGlance_GoToTab_Rescheduled = pair.Value;
                    else if (pair.Key == "Home_Link_AtAGlance_GoToTab_ScheduleDeactivated")
                        Home_Link_AtAGlance_GoToTab_ScheduleDeactivated = pair.Value;
                    else if (pair.Key == "Home_Link_AtAGlance_GoToTab_Sent")
                        Home_Link_AtAGlance_GoToTab_Sent = pair.Value;
                    else if (pair.Key == "Home_Link_AtAGlance_GoToTab_Cancelled")
                        Home_Link_AtAGlance_GoToTab_Cancelled = pair.Value;
                    else if (pair.Key == "Home_Link_AtAGlance_Campaign_1")
                        Home_Link_AtAGlance_Campaign_1 = pair.Value;
                    else if (pair.Key == "Home_Link_AtAGlance_Campaign_2")
                        Home_Link_AtAGlance_Campaign_2 = pair.Value;
                    else if (pair.Key == "Home_Link_AtAGlance_Campaign_3")
                        Home_Link_AtAGlance_Campaign_3 = pair.Value;
                    else if (pair.Key == "Home_Link_AtAGlance_ViewAllActivity")
                        Home_Link_AtAGlance_ViewAllActivity = pair.Value;
                    else if (pair.Key == "Home_Tab_RecentCampaigns")
                        Home_Tab_RecentCampaigns = pair.Value;
                    else if (pair.Key == "Home_Tab_Dashboard")
                        Home_Tab_Dashboard = pair.Value;
                    else if (pair.Key == "Home_RecentlySentCampaign_DateRange_Marketing")
                        Home_RecentlySentCampaign_DateRange_Marketing = pair.Value;
                    else if (pair.Key == "Home_RecentlySentCampaign_DateRange_Trigger")
                        Home_RecentlySentCampaign_DateRange_Trigger = pair.Value;
                    else if (pair.Key == "Home_RecentlySentCampaign_DateRange_Transactionals")
                        Home_RecentlySentCampaign_DateRange_Transactionals = pair.Value;
                    else if (pair.Key == "Home_DropDown_RecentlySentCampaigns_SelectClient")
                        Home_DropDown_RecentlySentCampaigns_SelectClient = pair.Value;
                    else if (pair.Key == "Home_DropDown_RecentlySentCampaigns_SelectCompany")
                        Home_DropDown_RecentlySentCampaigns_SelectCompany = pair.Value;
                    else if (pair.Key == "Home_Tab_RecentlySentCampaigns_Email")
                        Home_Tab_RecentlySentCampaigns_Email = pair.Value;
                    else if (pair.Key == "Home_Tab_RecentlySentCampaigns_RealTime")
                        Home_Tab_RecentlySentCampaigns_RealTime = pair.Value;
                    else if (pair.Key == "Home_Tab_RecentlySentCampaigns_TextMessage")
                        Home_Tab_RecentlySentCampaigns_TextMessage = pair.Value;
                    else if (pair.Key == "Home_Tab_RecentlySentCampaigns_KeywordTextMessage")
                        Home_Tab_RecentlySentCampaigns_KeywordTextMessage = pair.Value;
                    else if (pair.Key == "Home_Tab_RecentlySentCampaigns_TextMessageResponses")
                        Home_Tab_RecentlySentCampaigns_TextMessageResponses = pair.Value;
                    else if (pair.Key == "Home_DropDown_RecentlySentCampaigns_ShowLast")
                        Home_DropDown_RecentlySentCampaigns_ShowLast = pair.Value;
                    else if (pair.Key == "Home_Button_RecentlySentCampaigns_CalendarFrom")
                        Home_Button_RecentlySentCampaigns_CalendarFrom = pair.Value;
                    else if (pair.Key == "Home_Button_RecentlySentCampaigns_CalendarThrough")
                        Home_Button_RecentlySentCampaigns_CalendarThrough = pair.Value;
                    else if (pair.Key == "Home_Button_RecentlySentCampaigns_Merge")
                        Home_Button_RecentlySentCampaigns_Merge = pair.Value;
                    else if (pair.Key == "Home_Button_RecentlySentCampaigns_FirstPage")
                        Home_Button_RecentlySentCampaigns_FirstPage = pair.Value;
                    else if (pair.Key == "Home_Button_RecentlySentCampaigns_PreviousPage")
                        Home_Button_RecentlySentCampaigns_PreviousPage = pair.Value;
                    else if (pair.Key == "Home_Button_RecentlySentCampaigns_NextPage")
                        Home_Button_RecentlySentCampaigns_NextPage = pair.Value;
                    else if (pair.Key == "Home_Button_RecentlySentCampaigns_LastPage")
                        Home_Button_RecentlySentCampaigns_LastPage = pair.Value;
                    else if (pair.Key == "Home_Text_RecentlySentCampaigns_PageNumber")
                        Home_Text_RecentlySentCampaigns_PageNumber = pair.Value;
                    else if (pair.Key == "Home_DropDown_RecentlySentCampaigns_DisplayResultsNumber")
                        Home_DropDown_RecentlySentCampaigns_DisplayResultsNumber = pair.Value;
                    else if (pair.Key == "Home_Button_RecentlySentCampaigns_ExcelReport")
                        Home_Button_RecentlySentCampaigns_ExcelReport = pair.Value;
                    else if (pair.Key == "Home_Link_AtAGlance_GoToTab_AllActivity")
                        Home_Link_AtAGlance_GoToTab_AllActivity = pair.Value;
                    else if (pair.Key == "Home_Option_DatatableLength_Marketing")
                        Home_Option_DatatableLength_Marketing = pair.Value;
                    else if (pair.Key == "Home_Option_DatatableLength_Trigger")
                        Home_Option_DatatableLength_Trigger = pair.Value;
                    else if (pair.Key == "Home_Option_DatatableLength_Transactional")
                        Home_Option_DatatableLength_Transactional = pair.Value;
                    else if (pair.Key == "Home_RecentlySentCampaign_DateRange_Trigger_NoResult")
                        Home_RecentlySentCampaign_DateRange_Trigger_NoResult = pair.Value;
                }
                #endregion[Home]

                #region[ManageCampaign]
                if (nodeModule == Constants.ManageCampaign)
                {
                    if (pair.Key == "ManageCampaign_AllTab")
                    {
                        ManageCampaign_AllTab = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_DraftTab")
                    {
                        ManageCampaign_DraftTab = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_ClientDDM")
                    {
                        ManageCampaign_ClientDDM = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_CompanyDDM")
                    {
                        ManageCampaign_CompanyDDM = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_DeliverabilityTab")
                    {
                        ManageCampaign_DeliverabilityTab = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_AwaitingApprovalTab")
                    {
                        ManageCampaign_AwaitingApprovalTab = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_ApprovedTab")
                    {
                        ManageCampaign_ApprovedTab = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_RecurringTab")
                    {
                        ManageCampaign_RecurringTab = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_ScheduledTab")
                    {
                        ManageCampaign_ScheduledTab = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_DisapprovedTab")
                    {
                        ManageCampaign_DisapprovedTab = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_SearchTab")
                    {
                        ManageCampaign_SearchTab = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_Search_SearchFieldDDM")
                    {
                        ManageCampaign_Search_SearchFieldDDM = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_Search_ConditionDDM")
                    {
                        ManageCampaign_Search_ConditionDDM = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_Search_Input")
                    {
                        ManageCampaign_Search_Input = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_Search_SearchDateDDM")
                    {
                        ManageCampaign_Search_SearchDateDDM = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_Search_BetweenFirst")
                    {
                        ManageCampaign_Search_BetweenFirst = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_Search_BetweenSecond")
                    {
                        ManageCampaign_Search_BetweenSecond = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_Search_SearchButton")
                    {
                        ManageCampaign_Search_SearchButton = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_Search_CriteriaLink")
                    {
                        ManageCampaign_Search_CriteriaLink = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_Search_PreviewLink")
                    {
                        ManageCampaign_Search_PreviewLink = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_Search_CustomerDetails")
                    {
                        ManageCampaign_Search_CustomerDetails = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_Search_DynamicContentLink")
                    {
                        ManageCampaign_Search_DynamicContentLink = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_Search_HistoryLink")
                    {
                        ManageCampaign_Search_HistoryLink = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_Search_ReportsLink")
                    {
                        ManageCampaign_Search_ReportsLink = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_Search_MultiLanguageLink")
                    {
                        ManageCampaign_Search_MultiLanguageLink = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_Clone")
                    {
                        ManageCampaign_Clone = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_Search_PreviewClose")
                    {
                        ManageCampaign_Search_PreviewClose = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_Search_CriteriaClose")
                    {
                        ManageCampaign_Search_CriteriaClose = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_Search_CustomerDetailsClose")
                    {
                        ManageCampaign_Search_CustomerDetailsClose = pair.Value;
                    }
                    else if (pair.Key == "ManageCampaign_Search_DynamicContentClose")
                        ManageCampaign_Search_DynamicContentClose = pair.Value;
                    else if (pair.Key == "ManageCampaign_Search_HistoryClose")
                        ManageCampaign_Search_HistoryClose = pair.Value;
                    else if (pair.Key == "ManageCampaign_Search_ReportsClose")
                        ManageCampaign_Search_ReportsClose = pair.Value;
                    else if (pair.Key == "ManageCampaign_MultiLanguageClose")
                        ManageCampaign_MultiLanguageClose = pair.Value;
                    else if (pair.Key == "ManageCampaign_Tab_Sent")
                        ManageCampaign_Tab_Sent = pair.Value;
                    else if (pair.Key == "ManageCampaign_Tab_Disapproved")
                        ManageCampaign_Tab_Disapproved = pair.Value;
                    else if (pair.Key == "ManageCampaign_Button_First")
                        ManageCampaign_Button_First = pair.Value;
                    else if (pair.Key == "ManageCampaign_Button_Previous")
                        ManageCampaign_Button_Previous = pair.Value;
                    else if (pair.Key == "ManageCampaign_Button_Next")
                        ManageCampaign_Button_Next = pair.Value;
                    else if (pair.Key == "ManageCampaign_Button_Last")
                        ManageCampaign_Button_Last = pair.Value;
                    else if (pair.Key == "ManageCampaign_Button_Help")
                        ManageCampaign_Button_Help = pair.Value;
                    else if (pair.Key == "ManageCampaign_Link_FirstCampaign_Preview")
                        ManageCampaign_Link_FirstCampaign_Preview = pair.Value;
                    else if (pair.Key == "ManageCampaign_Link_FirstCampaign_Criteria")
                        ManageCampaign_Link_FirstCampaign_Criteria = pair.Value;
                    else if (pair.Key == "ManageCampaign_Link_FirstCampaign_CustomerDetails")
                        ManageCampaign_Link_FirstCampaign_CustomerDetails = pair.Value;
                    else if (pair.Key == "ManageCampaign_Link_FirstCampaign_DynamicContent")
                        ManageCampaign_Link_FirstCampaign_DynamicContent = pair.Value;
                    else if (pair.Key == "ManageCampaign_Link_FirstCampaign_History")
                        ManageCampaign_Link_FirstCampaign_History = pair.Value;
                    else if (pair.Key == "ManageCampaign_Link_FirstCampaign_Reports")
                        ManageCampaign_Link_FirstCampaign_Reports = pair.Value;
                    else if (pair.Key == "ManageCampaign_Link_FirstCampaign_MultiLanguage")
                        ManageCampaign_Link_FirstCampaign_MultiLanguage = pair.Value;
                    else if (pair.Key == "ManageCampaign_Link_FirstCampaign_ApprovalDashboard")
                        ManageCampaign_Link_FirstCampaign_ApprovalDashboard = pair.Value;
                    else if (pair.Key == "ManageCampaign_Button_Campaign_BasicValidationReport")
                        ManageCampaign_Button_Campaign_BasicValidationReport = pair.Value;
                    else if (pair.Key == "ManageCampaign_Button_Campaign_ScheduleCampaign")
                        ManageCampaign_Button_Campaign_ScheduleCampaign = pair.Value;
                    else if (pair.Key == "ManageCampaign_Button_FirstCampaign_AdvancedDeliverability")
                        ManageCampaign_Button_FirstCampaign_AdvancedDeliverability = pair.Value;
                    else if (pair.Key == "ManageCampaign_Button_FirstCampaign_SendToTestEmails")
                        ManageCampaign_Button_FirstCampaign_SendToTestEmails = pair.Value;
                    else if (pair.Key == "ManageCampaign_Button_FirstCampaign_RequestResponsive")
                        ManageCampaign_Button_FirstCampaign_RequestResponsive = pair.Value;
                    else if (pair.Key == "ManageCampaign_Button_FirstCampaign_SendForTranslation")
                        ManageCampaign_Button_FirstCampaign_SendForTranslation = pair.Value;
                    else if (pair.Key == "ManageCampaign_Button_FirstCampaign_DeleteCampaign")
                        ManageCampaign_Button_FirstCampaign_DeleteCampaign = pair.Value;
                    else if (pair.Key == "ManageCampaign_Button_FirstCampaign_Edit")
                        ManageCampaign_Button_FirstCampaign_Edit = pair.Value;
                    else if (pair.Key == "ManageCampaign_ContinueDraft")
                        ManageCampaign_ContinueDraft = pair.Value;
                    else if (pair.Key == "ManageCampaign_Button_FirstCampaign_ProceedForApproval")
                        ManageCampaign_Button_FirstCampaign_ProceedForApproval = pair.Value;
                    else if (pair.Key == "ManageCampaign_Button_FirstCampaign_SaveAsTemplate")
                        ManageCampaign_Button_FirstCampaign_SaveAsTemplate = pair.Value;
                    else if (pair.Key == "ManageCampaign_Button_FirstCampaign_SaveAsResent")
                        ManageCampaign_Button_FirstCampaign_SaveAsResent = pair.Value;
                    else if (pair.Key == "ManageCampaign_Button_FirstCampaign_Clone")
                        ManageCampaign_Button_FirstCampaign_Clone = pair.Value;
                    else if (pair.Key == "ManageCampaign_Link_FirstCampaign_Status")
                        ManageCampaign_Link_FirstCampaign_Status = pair.Value;
                    else if (pair.Key == "ManageCampaign_Button_CDetails_ViewCampaignRecipients")
                        ManageCampaign_Button_CDetails_ViewCampaignRecipients = pair.Value;
                    else if (pair.Key == "ManageCampaign_DDM_SearchBy")
                        ManageCampaign_DDM_SearchBy = pair.Value;
                    else if (pair.Key == "ManageCampaign_DDM_SearchExpression")
                        ManageCampaign_DDM_SearchExpression = pair.Value;
                    else if (pair.Key == "ManageCampaign_DDM_SearchValue")
                        ManageCampaign_DDM_SearchValue = pair.Value;
                    else if (pair.Key == "ManageCampaign_CustomerDetailsVRD_ClickSearch")
                        ManageCampaign_CustomerDetailsVRD_ClickSearch = pair.Value;
                    else if (pair.Key == "CASL_checkbox")
                        CASL_checkbox = pair.Value;
                    else if (pair.Key == "SubmitSendToTestEmail")
                        SubmitSendToTestEmail = pair.Value;
                    else if (pair.Key == "QuickSend_EmailtoSelf")
                        QuickSend_EmailtoSelf = pair.Value;
                    else if (pair.Key == "ManageCampaign_EditSchedule")
                        ManageCampaign_EditSchedule = pair.Value;
                    else if (pair.Key == "ManageCampaign_EditSchedule_Confirm")
                        ManageCampaign_EditSchedule_Confirm = pair.Value;
                    else if (pair.Key == "ManageCampaign_EditCampaign")
                        ManageCampaign_EditCampaign = pair.Value;
                    else if (pair.Key == "ManageCampaign_ScheduleCampaign")
                        ManageCampaign_ScheduleCampaign = pair.Value;
                    else if (pair.Key == "ManageCampaign_Button_Campaign_InactivateSchedule")
                        ManageCampaign_Button_Campaign_InactivateSchedule = pair.Value;
                    else if (pair.Key == "ManageCampaign_Button_Campaign_InactivateScheduleConfirm")
                        ManageCampaign_Button_Campaign_InactivateScheduleConfirm = pair.Value;
                    else if (pair.Key == "ManageCampaign_Button_Campaign_ActivateSchedule")
                        ManageCampaign_Button_Campaign_ActivateSchedule = pair.Value;
                    else if (pair.Key == "ManageCampaign_Button_Campaign_ActivateScheduleConfirm")
                        ManageCampaign_Button_Campaign_ActivateScheduleConfirm = pair.Value;
                    else if (pair.Key == "ManageCampaign_SendToTest_GroupSeedList")
                        ManageCampaign_SendToTest_GroupSeedList = pair.Value;
                    else if (pair.Key == "ManageCampaign_QuickSend_ReservationSelect")
                        ManageCampaign_QuickSend_ReservationSelect = pair.Value;
                    else if (pair.Key == "ProjectID_Search")
                        ProjectID_Search = pair.Value;
                    else if (pair.Key == "ProjectID_SearchExpression")
                        ProjectID_SearchExpression = pair.Value;
                    else if (pair.Key == "ProjectID_TextSearch")
                        ProjectID_TextSearch = pair.Value;
                    else if (pair.Key == "ProjectID_TextSearchs")
                        ProjectID_TextSearchs = pair.Value;
                    else if (pair.Key == "ProjectID_TextSearch_Filter")
                        ProjectID_TextSearch_Filter = pair.Value;
                    else if (pair.Key == "ProjectID_TextSearch_Filters")
                        ProjectID_TextSearch_Filters = pair.Value;
                    else if (pair.Key == "ProjectID_CampaignDetails_Testing")
                        ProjectID_CampaignDetails_Testing = pair.Value;
                    else if (pair.Key == "ProjectID_CampaignDetails_Testing_Advanced")
                        ProjectID_CampaignDetails_Testing_Advanced = pair.Value;
                    else if (pair.Key == "ProjectID_CampaignDetails_Testing_Advanced_InboxPreview")
                        ProjectID_CampaignDetails_Testing_Advanced_InboxPreview = pair.Value;
                    else if (pair.Key == "ProjectID_CampaignDetails_Testing_Advanced_InboxForecaster")
                        ProjectID_CampaignDetails_Testing_Advanced_InboxForecaster = pair.Value;
                    else if (pair.Key == "ProjectID_CampaignDetails_Actions")
                        ProjectID_CampaignDetails_Actions = pair.Value;
                    else if (pair.Key == "CampaignDetails_Actions_Edit")
                        CampaignDetails_Actions_Edit = pair.Value;
                    else if (pair.Key == "CampaignDetails_Actions_Clone")
                        CampaignDetails_Actions_Clone = pair.Value;
                    else if (pair.Key == "CampaignDetails_Actions_Delete")
                        CampaignDetails_Actions_Delete = pair.Value;
                    else if (pair.Key == "CampaignDetails_Actions_SaveAsResend")
                        CampaignDetails_Actions_SaveAsResend = pair.Value;
                    else if (pair.Key == "CampaignDetails_Actions_SaveAsTemplate")
                        CampaignDetails_Actions_SaveAsTemplate = pair.Value;
                }
                #endregion[ManageCampaign]

                #region[Settings]

                if (nodeModule == Constants.Settings)
                {
                    if (pair.Key == "Settings_AccessControl_MergeGuestCheckbox")
                    {
                        Settings_AccessControl_MergeGuestCheckbox = pair.Value;
                    }
                    else if (pair.Key == "Settings_AccessControl_Save")
                    {
                        Settings_AccessControl_Save = pair.Value;
                    }
                }

                #endregion[Settings]

                #region[CreateCampaign]
                if (nodeModule == Constants.CreateCampaign)
                {
                    if (pair.Key == "CreateCampaign_Button_Save")
                        CreateCampaign_Button_Save = pair.Value;
                    if (pair.Key == "CreateCampaign_Button_SaveAndContinue")
                        CreateCampaign_Button_SaveAndContinue = pair.Value;
                    if (pair.Key == "CreateCampaign_Button_Continue")
                        CreateCampaign_Button_Continue = pair.Value;
                    if (pair.Key == "CreateCampaign_Button_SaveAndContinue_Submit")
                        CreateCampaign_Button_SaveAndContinue_Submit = pair.Value;
                    else if (pair.Key == "CreateCampaign_Link_CriteriaTab")
                        CreateCampaign_Link_CriteriaTab = pair.Value;
                    else if (pair.Key == "CreateCampaign_CriteriaTab_ForecastTargetAudience")
                        CreateCampaign_CriteriaTab_ForecastTargetAudience = pair.Value;
                    else if (pair.Key == "CreateCampaign_Link_TemplateTab")
                        CreateCampaign_Link_TemplateTab = pair.Value;
                    else if (pair.Key == "CreateCampaign_Button_ChangeTemplate")
                        CreateCampaign_Button_ChangeTemplate = pair.Value;
                    else if (pair.Key == "CreateCampaign_Link_TestingTab")
                        CreateCampaign_Link_TestingTab = pair.Value;
                    else if (pair.Key == "CreateCampaign_Link_ApprovalTab")
                        CreateCampaign_Link_AMResorts = pair.Value;
                    else if (pair.Key == "CreateCampaign_Link_ScheduleTab")
                        CreateCampaign_Link_ScheduleTab = pair.Value;
                    else if (pair.Key == "CreateCampaign_Link_")
                        CreateCampaign_Link_ = pair.Value;
                    else if (pair.Key == "CreateCampaign_Text_Filter")
                        CreateCampaign_Text_Filter = pair.Value;
                    else if (pair.Key == "CreateCampaign_Link_CendynHotel")
                        CreateCampaign_Link_CendynHotel = pair.Value;
                    else if (pair.Key == "CreateCampaign_Link_CendynHotelResort")
                        CreateCampaign_Link_CendynHotelResort = pair.Value;
                    else if (pair.Key == "CreateCampaign_Button_TestingSendtoTest")
                        CreateCampaign_Button_TestingSendtoTest = pair.Value;
                    else if (pair.Key == "CreateCampaign_Testing_SendForApproval")
                        CreateCampaign_Testing_SendForApproval = pair.Value;
                    else if (pair.Key == "CreateCampaign_Link_Campaign_Approve")
                        CreateCampaign_Link_Campaign_Approve = pair.Value;
                    else if (pair.Key == "CreateCampaign_Link_Campaign_ApproveConfirmation")
                        CreateCampaign_Link_Campaign_ApproveConfirmation = pair.Value;
                    else if (pair.Key == "CreateCampaign_Link_Campaign_Disapprove")
                        CreateCampaign_Link_Campaign_Disapprove = pair.Value;
                    else if (pair.Key == "CreateCampaign_Link_Campaign_DisapproveConfirmation")
                        CreateCampaign_Link_Campaign_DisapproveConfirmation = pair.Value;
                    else if (pair.Key == "CreateCampaign_DropDown_Schedule_Hours")
                        CreateCampaign_DropDown_Schedule_Hours = pair.Value;
                    else if (pair.Key == "CreateCampaign_DropDown_Schedule_Minutes")
                        CreateCampaign_DropDown_Schedule_Minutes = pair.Value;
                    else if (pair.Key == "CreateCampaign_DropDown_Schedule_TimeType")
                        CreateCampaign_DropDown_Schedule_TimeType = pair.Value;
                    else if (pair.Key == "CreateCampaign_Button_Campaign_ScheduleandCompleteCampaign")
                        CreateCampaign_Button_Campaign_ScheduleandCompleteCampaign = pair.Value;
                    else if (pair.Key == "CreateCampaign_Button_Campaign_UpdateSchedule")
                        CreateCampaign_Button_Campaign_UpdateSchedule = pair.Value;
                    else if (pair.Key == "CreateCampaign_EditTemplate_Subject")
                        CreateCampaign_EditTemplate_Subject = pair.Value;
                    else if (pair.Key == "CreateCampaign_EditTemplate_LinkSubjectTag")
                        CreateCampaign_EditTemplate_LinkSubjectTag = pair.Value;
                    else if (pair.Key == "CreateCampaign_EditTemplate_LinkSubjectTag_Map")
                        CreateCampaign_EditTemplate_LinkSubjectTag_Map = pair.Value;
                    else if (pair.Key == "CreateCampaign_EditTemplate_FromName")
                        CreateCampaign_EditTemplate_FromName = pair.Value;
                    else if (pair.Key == "CreateCampaign_EditTemplate_ReplyEmail")
                        CreateCampaign_EditTemplate_ReplyEmail = pair.Value;
                    else if (pair.Key == "CreateCampaign_AudienceName_ApprovalPage")
                        CreateCampaign_AudienceName_ApprovalPage = pair.Value;
                    else if (pair.Key == "CreateCampaign_AudienceName_SchedulePage")
                        CreateCampaign_AudienceName_SchedulePage = pair.Value;
                    else if (pair.Key == "CreateCampaign_CriteriaPage_Save")
                        CreateCampaign_CriteriaPage_Save = pair.Value;
                    else if (pair.Key == "CreateCampaign_CriteriaPage_SaveandContinue")
                        CreateCampaign_CriteriaPage_SaveandContinue = pair.Value;
                    else if (pair.Key == "CreateCampaign_CriteriaPage_Clear")
                        CreateCampaign_CriteriaPage_Clear = pair.Value;
                    else if (pair.Key == "CreateCampaign_TemplatePage_Save")
                        CreateCampaign_TemplatePage_Save = pair.Value;
                    else if (pair.Key == "CreateCampaign_TemplateAndTestingPage_SaveandContinue")
                        CreateCampaign_TemplateAndTestingPage_SaveandContinue = pair.Value;
                    else if (pair.Key == "CreateCampaign_Link_CriteriaTab_TotalArrow")
                        CreateCampaign_Link_CriteriaTab_TotalArrow = pair.Value;
                    else if (pair.Key == "CreateCampaign_Link_CriteriaTab_Loader")
                        CreateCampaign_Link_CriteriaTab_Loader = pair.Value;
                    else if (pair.Key == "CreateCampaign_Link_CriteriaTab_Generate")
                        CreateCampaign_Link_CriteriaTab_Generate = pair.Value;
                    else if (pair.Key == "CreateCampaign_Templates_ListView_Btn")
                        CreateCampaign_Templates_ListView_Btn = pair.Value;
                    else if (pair.Key == "CreateCampaign_Templates_ListView_Loader")
                        CreateCampaign_Templates_ListView_Loader = pair.Value;
                    else if (pair.Key == "CreateCampaign_Templates_ListView_NameFilterIcon")
                        CreateCampaign_Templates_ListView_NameFilterIcon = pair.Value;
                    else if (pair.Key == "CreateCampaign_Templates_ListView_FilterSelection")
                        CreateCampaign_Templates_ListView_FilterSelection = pair.Value;
                    else if (pair.Key == "CreateCampaign_Templates_ListView_Filter_Btn")
                        CreateCampaign_Templates_ListView_Filter_Btn = pair.Value;
                    else if (pair.Key == "CreateCampaign_Templates_ListView_Input_Filter_Txt")
                        CreateCampaign_Templates_ListView_Input_Filter_Txt = pair.Value;
                    else if (pair.Key == "CreateCampaign_Templates_SaveAndContinue_Btn")
                        CreateCampaign_Templates_SaveAndContinue_Btn = pair.Value;
                }
                #endregion[CreateCampaign]

                #region[CreateCampaign_Criteria]
                if (nodeModule == Constants.CreateCampaign_Criteria)
                {
                    if (pair.Key == "CreateCampaign_Criteria_Text_CampaignName")
                        CreateCampaign_Criteria_Text_CampaignName = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_Text_Brand")
                        CreateCampaign_Criteria_Text_Brand = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_Button_Brand_RemoveFirstBrand")
                        CreateCampaign_Criteria_Button_Brand_RemoveFirstBrand = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_Button_Save")
                        CreateCampaign_Criteria_Button_Save = pair.Value;
                    //else if (pair.Key == "CreateCampaign_Criteria_Button_SaveAndContinue")
                    //    CreateCampaign_Criteria_Button_SaveAndContinue = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_Button_Clear")
                        CreateCampaign_Criteria_Button_Clear = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_Text_PropertyList")
                        CreateCampaign_Criteria_Text_PropertyList = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_Button_PropertyList_RemoveFirstPropertyList")
                        CreateCampaign_Criteria_Button_PropertyList_RemoveFirstPropertyList = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_Text_SeedList")
                        CreateCampaign_Criteria_Text_SeedList = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_Button_SeedList_RemoveFirstSeedList")
                        CreateCampaign_Criteria_Button_SeedList_RemoveFirstSeedList = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_Button_ForecastTargetAudience")
                        CreateCampaign_Criteria_Button_ForecastTargetAudience = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_Button_NewSegment_Top")
                        CreateCampaign_Criteria_Button_NewSegment_Top = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_Button_NewSegment_Bottom")
                        CreateCampaign_Criteria_Button_NewSegment_Bottom = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_Button_TransactionalSettings_HideShow")
                        CreateCampaign_Criteria_Button_TransactionalSettings_HideShow = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_DropDown_TransactionalSettings_ReservationEvent")
                        CreateCampaign_Criteria_DropDown_TransactionalSettings_ReservationEvent = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_CheckBox_TransactionalSettings_EmailType_Email")
                        CreateCampaign_Criteria_CheckBox_TransactionalSettings_EmailType_Email = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_CheckBox_TransactionalSettings_EmailType_RESERVATIONEMAIL")
                        CreateCampaign_Criteria_CheckBox_TransactionalSettings_EmailType_RESERVATIONEMAIL = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_CheckBox_TransactionalSettings_UseFirstAvailableSelectedEmailType")
                        CreateCampaign_Criteria_CheckBox_TransactionalSettings_UseFirstAvailableSelectedEmailType = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_CheckBox_TransactionalSettings_IncludeUnsubscribe")
                        CreateCampaign_Criteria_CheckBox_TransactionalSettings_IncludeUnsubscribe = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_Button_CollapseAll")
                        CreateCampaign_Criteria_Button_CollapseAll = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_Button_ExpandAll")
                        CreateCampaign_Criteria_Button_ExpandAll = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_Text_Segment_SegmentDescription")
                        CreateCampaign_Criteria_Text_Segment_SegmentDescription = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_DropDown_Segment_Include")
                        CreateCampaign_Criteria_DropDown_Segment_Include = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_DropDown_Segment_AndOrNandNor")
                        CreateCampaign_Criteria_DropDown_Segment_AndOrNandNor = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_Button_Segment_CollapseExpand")
                        CreateCampaign_Criteria_Button_Segment_CollapseExpand = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_Button_Segment_Close")
                        CreateCampaign_Criteria_Button_Segment_Close = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_Button_Segment_First_SelectAll")
                        CreateCampaign_Criteria_Button_Segment_First_SelectAll = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_Button_Segment_First_Clone")
                        CreateCampaign_Criteria_Button_Segment_First_Clone = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_Button_Segment_First_Remove")
                        CreateCampaign_Criteria_Button_Segment_First_Remove = pair.Value;
                    else if (pair.Key == "CreateCampaign_Criteria_Text_Segment_DataSource")
                        CreateCampaign_Criteria_Text_Segment_DataSource = pair.Value;
                }
                #endregion[CreateCampaign_Criteria]

                #region[AdminNavigation]
                if (nodeModule == Constants.Admin)
                {
                    if (pair.Key == "Login_Email")
                        Login_Email = pair.Value;
                    else if (pair.Key == "Login_Password")
                        Login_Password = pair.Value;
                    else if (pair.Key == "Login_Submit")
                        Login_Submit = pair.Value;
                    else if (pair.Key == "Login_ForgotPassword")
                        Login_ForgotPassword = pair.Value;
                    else if (pair.Key == "Login_Text_ForgotPassword_Email")
                        Login_Text_ForgotPassword_Email = pair.Value;
                    else if (pair.Key == "Login_Button_ForgotPassword_Submit")
                        Login_Button_ForgotPassword_Submit = pair.Value;
                }
                #endregion[AdminNavigation]

                #region[Settings]
                if (nodeModule == Constants.Settings)
                {
                    if (pair.Key == "Settings_AccessControl_MergeGuestCheckbox")
                        Settings_AccessControl_MergeGuestCheckbox = pair.Value;
                    else if (pair.Key == "Settings_AccessControl_Save")
                        Settings_AccessControl_Save = pair.Value;
                    else if (pair.Key == "Settings_AccessControl")
                        Settings_AccessControl = pair.Value;
                    else if (pair.Key == "Settings_AccessControl_MergeGuest")
                        Settings_AccessControl_MergeGuest = pair.Value;
                }
                #endregion[Settings]

                #region[UserActions]
                if (nodeModule == Constants.UserActions)
                {
                    if (pair.Key == "User_UserActions")
                        User_UserActions = pair.Value;
                    else if (pair.Key == "UserAction_MyPreference")
                        UserAction_MyPreference = pair.Value;
                    else if (pair.Key == "UserAction_MyPreference_Region")
                        UserAction_MyPreference_Region = pair.Value;
                    else if (pair.Key == "UserAction_MyPreference_Currency")
                        UserAction_MyPreference_Currency = pair.Value;
                    else if (pair.Key == "UserAction_MyPreference_Save")
                        UserAction_MyPreference_Save = pair.Value;
                }
                #endregion[UserActions]

                #region[AudienceBuilder]
                if (nodeModule == Constants.AudienceBuilder)
                {
                    if (pair.Key == "AB_Button_Add")
                        AB_Button_Add = pair.Value;
                    else if (pair.Key == "AB_Button_AddSearchField")
                        AB_Button_AddSearchField = pair.Value;
                    else if (pair.Key == "AB_Checkbox_ShowInactive")
                        AB_Checkbox_ShowInactive = pair.Value;
                    else if (pair.Key == "AB_Button_Reset")
                        AB_Button_Reset = pair.Value;
                    else if (pair.Key == "AB_Button_Search")
                        AB_Button_Search = pair.Value;
                    else if (pair.Key == "AB_CustomerDetailsSearchContent")
                        AB_CustomerDetailsSearchContent = pair.Value;
                    else if (pair.Key == "AB_Grid_LastPublished")
                        AB_Grid_LastPublished = pair.Value;
                    else if (pair.Key == "AB_Grid_LastSaved")
                        AB_Grid_LastSaved = pair.Value;
                    else if (pair.Key == "AB_Grid_ButtonAction")
                        AB_Grid_ButtonAction = pair.Value;
                    else if (pair.Key == "AB_Grid_EditAudience")
                        AB_Grid_EditAudience = pair.Value;
                    else if (pair.Key == "Click_TotalCounts_Audience")
                        Click_TotalCounts_Audience = pair.Value;
                    else if (pair.Key == "Click_ABEdit_StayOnPage")
                        Click_ABEdit_StayOnPage = pair.Value;
                    else if (pair.Key == "Click_ABEdit_LeavePage")
                        Click_ABEdit_LeavePage = pair.Value;
                    else if (pair.Key == "AB_Listbox_selectField")
                        AB_Listbox_selectField = pair.Value;
                    else if (pair.Key == "AB_TextBox_FieldValue")
                        AB_TextBox_FieldValue = pair.Value;
                    else if (pair.Key == "Click_ABGrid_ButtonDetail")
                        Click_ABGrid_ButtonDetail = pair.Value;
                    else if (pair.Key == "Click_ABGrid_AudienceClone")
                        Click_ABGrid_AudienceClone = pair.Value;
                    else if (pair.Key == "Click_ABEdit_SavePublishButton")
                        Click_ABEdit_SavePublishButton = pair.Value;
                    else if (pair.Key == "Click_ABEdit_CancelButton")
                        Click_ABEdit_CancelButton = pair.Value;
                    else if (pair.Key == "Click_ABEdit_FirstTime_TotalRecords")
                        Click_ABEdit_FirstTime_TotalRecords = pair.Value;
                    else if (pair.Key == "Click_ABEdit_TotalRecords")
                        Click_ABEdit_TotalRecords = pair.Value;
                    else if (pair.Key == "AB_IFrame")
                        AB_IFrame = pair.Value;
                }
                #endregion[AudienceBuilder]

                #region[PriorityQ]
                if (nodeModule == Constants.PriorityQ)
                {
                    if (pair.Key == "PriorityQ_SearchFor")
                        PriorityQ_SearchFor = pair.Value;
                    else if (pair.Key == "PriorityQ_Reset")
                        PriorityQ_Reset = pair.Value;
                    else if (pair.Key == "PriorityQ_Submit")
                        PriorityQ_Submit = pair.Value;
                    else if (pair.Key == "PriorityQ_Filter")
                        PriorityQ_Filter = pair.Value;
                    else if (pair.Key == "PriorityQ_ToEmail")
                        PriorityQ_ToEmail = pair.Value;
                    else if (pair.Key == "PriorityQ_CampaignContainer")
                        PriorityQ_CampaignContainer = pair.Value;
                    else if (pair.Key == "PriorityQ_CampaignContainer_filter")
                        PriorityQ_CampaignContainer_filter = pair.Value;
                    else if (pair.Key == "PriorityQ_SendtoTest")
                        PriorityQ_SendtoTest = pair.Value;
                    else if (pair.Key == "PriorityQ_SendtoTestButton")
                        PriorityQ_SendtoTestButton = pair.Value;
                    else if (pair.Key == "PriorityQ_SendEmail_Cancel")
                        PriorityQ_SendEmail_Cancel = pair.Value;
                    else if (pair.Key == "PriorityQ_SendEmail_Prompt_Cancel")
                        PriorityQ_SendEmail_Prompt_Cancel = pair.Value;
                }
                #endregion[PriorityQ]

                #region[TemplateBuilder]
                if (nodeModule == Constants.TemplateBuilder)
                {
                    if (pair.Key == "TemplateBuilder_SearchTemplate")
                        TemplateBuilder_SearchTemplate = pair.Value;
                }
                #endregion[TemplateBuilder]
            }
            return obj;
        }
    }
}
