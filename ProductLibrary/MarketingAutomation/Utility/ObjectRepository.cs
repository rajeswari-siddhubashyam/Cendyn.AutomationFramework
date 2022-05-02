using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MarketingAutomation.Utility
{
    class ObjectRepository
    {


        #region[SignIn]
        public static string SignIn_Email { get; set; }
        public static string SignIn_Password { get; set; }
        public static string SignIn_Submit { get; set; }
        #endregion[SignIn]

        #region[Home]
        public static string Home_Applications { get; set; }
        public static string Home_Org_Popup { get; set; }
        public static string Home_Org_Popup_Cancel { get; set; }
        public static string Home_Org_Popup_Choose { get; set; }
        public static string Home_Sidebar_Org_Popup_Choose { get; set; }
        public static string Home_Sidebar_Home { get; set; }
        #endregion[Home]

        #region[Navigation]
        public static string Navigation_Button_Campaigns { get; set; }
        public static string Navigation_text_MAutomation { get; set; }
        public static string Navigation_Button_Campaigns_Sidebar { get; set; }
        public static string Navigation_Button_Templates { get; set; }
        //-TODOPK: Remove it later
        public static string Navigation_Button_Audiences { get; set; }
        public static string Navigation_To_MAutomation_FromCHC { get; set; }
        public static string TotalNavigatingNavbar { get; set; }
        #endregion[Navigation]


        #region[CreateCampaign]
        public static string Campaign_Button_CreateCampaign { get; set; }
        public static string Campaign_Button_Marketing { get; set; }
        public static string Campaign_Button_Automated { get; set; }
        public static string Campaign_Button_ApplicationCards { get; set; }
        public static string Campaign_Create_Wizard_Settings { get; set; }
        public static string Campaign_Create_Wizard_Back_Button { get; set; }
        public static string Campaign_Create_Wizard_Audience { get; set; }
        public static string Campaign_Create_Campaign_Name_Input { get; set; }
        public static string Campaign_Create_Campaign_Name_Error_Text { get; set; }
        public static string Campaign_Create_Campaign_Subject_Input { get; set; }
        public static string Campaign_Create_Campaign_Subject_Error_Text { get; set; }
        public static string Campaign_Create_Campaign_Subject_InLine_Text { get; set; }
        public static string Campaign_Create_Campaign_From_Dropdown { get; set; }
        public static string Campaign_Create_Campaign_From_Error_Text { get; set; }
        public static string Campaign_Create_Campaign_Form_Search_Input { get; set; }
        public static string Campaign_Create_Campaign_Form_DropDownList { get; set; }
        public static string Campaign_Create_Campaign_Form_RemoveSelection_Button { get; set; }
        public static string Campaign_Create_Campaign_Reply_Dropdown { get; set; }
        public static string Campaign_Create_Campaign_Reply_Search_Input { get; set; }
        public static string Campaign_Create_Campaign_Reply_DropDownList { get; set; }
        public static string Campaign_Create_Campaign_Reply_RemoveSelection_Button { get; set; }
        public static string Campaign_Create_Campaign_Tip_Text { get; set; }
        public static string Campaign_Create_Campaign_SaveAndContinue_Button { get; set; }
        public static string Campaign_Create_Campaign_From_Dropdown_Input { get; set; }
        public static string Campaign_Create_Campaign_Reply_Dropdown_Input { get; set; }

        public static string Campaign_Create_Audience_Grid_button { get; set; }
        public static string Campaign_Create_Audience_List_button { get; set; }
        public static string Campaign_Create_Audience_Sort_button { get; set; }
        public static string Campaign_Create_Audience_Sort_Options { get; set; }
        public static string Campaign_Create_Audience_Card_Menu_Ellipses { get; set; }
        public static string Campaign_Create_Audience_Card_SelectAndContinue_Button { get; set; }
        public static string Campaign_Create_Audience_Cards_Title { get; set; }
        public static string Campaign_Create_Audience_Cards_SubTitles { get; set; }
        public static string Campaign_Create_Audience_Card_ToolTip_Text { get; set; }
        public static string Campaign_Create_Audience_Cards_Tag_List { get; set; }
        public static string Campaign_Create_Audience_List_Cards_Tag_List { get; set; }
        public static string Campaign_Create_Audience_Cards_Tag_More_Count { get; set; }
        public static string Campaign_Create_Audience_Cards_More_Tag_List { get; set; }
        public static string Campaign_Create_Audience_Cards_Users_Count { get; set; }
        public static string Campaign_Create_Audience_Cards_Email_Count { get; set; }
        public static string Campaign_Create_Audience_Cards_Dates { get; set; }
        public static string Campaign_Create_Audience_Previous_Page_Button { get; set; }
        public static string Campaign_Create_Audience_Next_Page_Button { get; set; }
        public static string Campaign_Create_Audience_Paggination_Page_Numbers { get; set; }
        public static string Campaign_Create_Audience_Card_Border { get; set; }
        public static string Campaign_Create_Audience_Cards_Truncated { get; set; }
        public static string Campaign_Create_Audience_Preview_Audience_Name { get; set; }
        public static string Campaign_Create_Audience_Preview_Audience_Description { get; set; }
        public static string Campaign_Create_Audience_Preview_Criteria_Text { get; set; }
        public static string Campaign_Create_Wizard_Settings_Checked { get; set; }
        public static string Campaign_Create_Wizard_Audience_Checked { get; set; }
        public static string Campaign_Create_Audience_Preview_Total_Count { get; set; }
        public static string Campaign_Create_Audience_Preview_Campaigns_Count { get; set; }
        public static string Campaign_Create_Audience_Preview_Created_Date { get; set; }
        public static string Campaign_Create_Audience_Preview_Loader { get; set; }
        public static string Campaign_Create_Audience_ListView_Column_Header { get; set; }
        public static string Campaign_Create_Audience_ListView_Cell_Data { get; set; }
        public static string Campaign_Create_Audience_ListView_Previous_Page_Button { get; set; }
        public static string Campaign_Create_Audience_ListView_Next_Page_Button { get; set; }
        public static string Campaign_Create_Audience_ListView_Page_Numbers { get; set; }
        public static string Campaign_Create_Design_New_Button { get; set; }
        public static string Campaign_Create_Design_ListView_Button { get; set; }
        public static string Campaign_Create_Design_GridView_Button { get; set; }
        public static string Campaign_Create_Design_Card_Clone_Button { get; set; }
        public static string Campaign_Create_Design_Cards_Images { get; set; }
        public static string Campaign_Create_Design_Cards_Title { get; set; }
        public static string Campaign_Create_Design_Card_Border { get; set; }
        public static string Campaign_Create_Design_Cards_Tag_List { get; set; }
        public static string Campaign_Create_Design_Cards_Users_Name { get; set; }
        public static string Campaign_Create_Design_Preview_Page_Loader { get; set; }
        public static string Campaign_Create_Design_Preview_Edit_Text { get; set; }
        public static string Campaign_Create_Design_Preview_Edit_Design_Button { get; set; }
        public static string Campaign_Create_Design_Preview_Created_Date { get; set; }
        public static string Campaign_Create_Design_Preview_Updated_Date { get; set; }
        public static string Campaign_Create_Design_Preview_Campaign_Count { get; set; }
        public static string Campaign_Create_Design_Preview_Tag_Count { get; set; }

        public static string Campaign_Create_Wizard_Design { get; set; }
        public static string Campaign_Create_Wizard_Design_Checked { get; set; }
        public static string Campaign_Create_Design_Preview_Design_Title { get; set; }
        public static string Campaign_Create_Design_Preview_ViewIn_Browser { get; set; }
        public static string Campaign_Create_Design_List_Truncated { get; set; }
        public static string Campaign_Create_Wizard_Confirm { get; set; }
        public static string Campaign_Create_Wizard_Confirm_Checked { get; set; }
        public static string Campaign_Create_Wizard_Confirm_Finish { get; set; }
        public static string Campaign_Create_Confirm_Card_Title { get; set; }
        public static string Campaign_Create_Confirm_Card_Description { get; set; }
        public static string Campaign_Create_Confirm_From_Name { get; set; }
        public static string Campaign_Create_Confirm_From_Email { get; set; }
        public static string Campaign_Create_Confirm_Audience_Name { get; set; }
        public static string Campaign_Create_Confirm_Audience_Count { get; set; }
        public static string Campaign_Create_Confirm_Self_Approve { get; set; }
        public static string Campaign_Create_Confirm_Send_Request { get; set; }//
        public static string Campaign_Create_Confirm_Schedule_Text { get; set; }
        public static string Campaign_Create_Confirm_Send_Clear_Value { get; set; }
        public static string Campaign_Create_Confirm_Send_Input { get; set; }
        public static string Campaign_Create_Success_Message { get; set; }
        public static string Campaign_Create_Success_Manage_Campaigns_Button { get; set; }
        public static string Campaign_Create_Success_Edit_Schedule_Link { get; set; }
        public static string Campaign_Create_Confirm_Start_On_Picker_Icon { get; set; }
        public static string Campaign_Create_Confirm_Start_On_Clear_Icon { get; set; }
        public static string Campaign_Create_Confirm_Days_From_Picker_Icon { get; set; }
        public static string Campaign_Create_Confirm_Days_From_Clear_Icon { get; set; }
        public static string Campaign_Create_Confirm_Until_Picker_Icon { get; set; }
        public static string Campaign_Create_Confirm_Until_Clear_Icon { get; set; }
        public static string Campaign_Create_Confirm_At_Time_Icon { get; set; }
        public static string Campaign_Create_Confirm_Time_Zone_Input { get; set; }
        public static string Campaign_Create_Confirm_Time_Zone_Clear_Icon { get; set; }
        public static string Campaign_Create_Confirm_Days_From_Input { get; set; }
        public static string Campaign_Create_Confirm_Start_On_Input { get; set; }
        public static string Campaign_Create_Confirm_Until_Input { get; set; }
        public static string Campaign_Create_Confirm_At_Time_Input { get; set; }
        public static string Campaign_Create_Confirm_Every_Input { get; set; }
        public static string Campaign_Create_Confirm_Send_Input_DropDown { get; set; }
        public static string Campaign_Create_Confirm_Send_List { get; set; }
        public static string Campaign_Create_Confirm_Send_Input_ToEnter { get; set; }
        public static string Campaign_Create_Confirm_On_Input { get; set; }
        public static string Campaign_Create_Confirm_On_Picker_Icon { get; set; }
        public static string Campaign_Create_Confirm_FutureDates { get; set; }
        public static string Campaign_Create_Confirm_At_Time_List { get; set; }
        public static string Campaign_Create_Confirm_Time_Zone_Down_Arrow { get; set; }
        public static string Campaign_Create_Confirm_Time_Zone_Search_Input { get; set; }
        public static string Campaign_Create_Confirm_Time_Zone_Options_List { get; set; }
        public static string Campaign_Create_Success_Text { get; set; }
        public static string Campaign_Create_Confirm_Every_Arrow { get; set; }
        public static string Campaign_Create_Confirm_Every_Search_Input { get; set; }
        public static string Campaign_Create_Confirm_Every_List { get; set; }

        public static string Campaign_Create_Design_Click_SendMail { get; set; }
        public static string Campaign_Create_Design_SeedList_value { get; set; }
        public static string Campaign_Create_Design_SeedList_DDL { get; set; }
        public static string Campaign_Create_Design_SendTest_Send_Button { get; set; }
        public static string Recipients_Text_Box { get; set; }
        public static string Campaign_Create_Design_Enter_SeedList { get; set; }
        public static string Enter_Recipients { get; set; }
        public static string Campaign_Create_Confirm_Calendar_Next { get; set; }
        public static string Campaign_Create_Confirm_Calendar_Previous { get; set; }
        public static string Campaign_Create_Confirm_Months_From_Input { get; set; }
        public static string Campaign_Create_Confirm_Months_From_Picker_Icon { get; set; }
        public static string Campaign_Create_Confirm_Every_Monthly_Arrow { get; set; }
        public static string Campaign_Create_Confirm_Every_Month_Input { get; set; }
        public static string Campaign_Create_Confirm_Every_Search_Month_Input { get; set; }
        public static string Campaign_Create_Confirm_Every_Monthly_List { get; set; }
        public static string Campaign_Create_Confirm_Every_Minute_Input { get; set; }
        public static string Campaign_Create_Confirm_Every_Minute_Arrow { get; set; }
        public static string Campaign_Create_Confirm_Every_Minute_Search_Input { get; set; }
        public static string Campaign_Create_Confirm_Every_Minute_List { get; set; }
        public static string Campaign_Create_Confirm_Every_Hourly_Input { get; set; }
        public static string Campaign_Create_Confirm_Every_Hourly_Arrow { get; set; }
        public static string Campaign_Create_Confirm_Every_Hourly_Search_Input { get; set; }
        public static string Campaign_Create_Confirm_Every_Hourly_List { get; set; }
        public static string Campaign_Create_Confirm_Hourly_From_Picker_Icon { get; set; }
        public static string Campaign_Create_Confirm_Hourly_From_Clear_Icon { get; set; }
        public static string Campaign_Create_Confirm_Hourly_From_Input { get; set; }
        public static string Campaign_Create_Confirm_Minutes_From_Picker_Icon { get; set; }
        public static string Campaign_Create_Confirm_Minutes_From_Clear_Icon { get; set; }
        public static string Campaign_Create_Confirm_Minutes_From_Input { get; set; }
        public static string Campaign_Create_Confirm_Todays_Dates { get; set; }
        public static string Campaign_Create_Confirm_Hours_From_Picker_Icon { get; set; }
        public static string Campaign_Create_Confirm_Hours_From_Input { get; set; }
        public static string Campaign_Create_Confirm_Hours_From_Clear_Icon { get; set; }
        public static string Campaign_Create_Confirm_Every_Hours_Input { get; set; }
        public static string Campaign_Create_Confirm_Every_Hours_Arrow { get; set; }
        public static string Campaign_Create_Confirm_Every_Hours_Search_Input { get; set; }
        public static string Campaign_Create_Confirm_Every_Hours_List { get; set; }

        public static string Campaign_Create_Confirm_Weekly_From_Picker_Icon { get; set; }
        public static string Campaign_Create_Confirm_Weekly_From_Input { get; set; }
        public static string Campaign_Create_Confirm_Weekly_Day { get; set; }

        public static string Campaign_Create_Confirm_grid3x3_Card { get; set; }
        public static string Campaign_Create_Confirm_TwoButtons { get; set; }
        public static string Confirm_Icon_AtTop { get; set; }
        public static string SelectionOTabVerify { get; set; }
        public static string Logout_Button { get; set; }

        public static string Campaign_Click_Filter { get; set; }
        public static string Campaign_Click_Filter_Name_ddL { get; set; }
        public static string Campaign_Click_Filter_Name_ddL_Value { get; set; }
        public static string Campaign_Click_Filter_Name_Enter_CampaignName { get; set; }
        public static string Campaign_Click_Filter_Apply_Button { get; set; }
        public static string Campaign_Filter_Enter_ID { get; set; }
        public static string Campaign_Click_Filter_ID_ddL { get; set; }
        public static string Campaign_Click_Filter_Audience_DDl { get; set; }
        public static string Campaign_Click_Filter_Enter_Audience { get; set; }

        public static string Campaign_Click_Approval_SendRequest_Button { get; set; }
        public static string Campaign_Click_Approval_SendRequest_Approve_Button { get; set; }
        public static string Campaign_Click_Approval_SendRequest_Reject_Button { get; set; }
        public static string Campaign_Click_Approval_Click_SelfApprove_Button { get; set; }
        public static string Click_design_SelfApprove_Send_DDL { get; set; }
        public static string Click_design_SelfApprove_TimeZone_DDL { get; set; }
        public static string Click_design_SelfApprove_On_Value { get; set; }
        public static string Click_design_SelfApprove_Enter_Send_Value { get; set; }
        public static string RejectApproval__popUp_Reject_button { get; set; }
        public static string RejectApproval__popUp_Enter_text { get; set; }
        
        public static string Campaign_Card_Ellipses { get; set; }
        public static string Campaign_Card_Titles { get; set; }
        public static string Campaign_Card_Campaign_IDs { get; set; }
        public static string Campaign_Card_Campaign_Ellipse_Clone { get; set; }
        public static string Campaign_Filter { get; set; }
        public static string Campaign_Filter_Name { get; set; }
        public static string Campaign_Filter_Name_Search_Text { get; set; }
        public static string Campaign_Filter_Button_Apply { get; set; }
        public static string Campaign_Filter_Name_Value { get; set; }
        public static string Campaign_Filter_Name_Value_List { get; set; }
        public static string Campaign_Click_Filter_Clear_Button { get; set; }
        public static string Campaign_SendEmail_SeedLists { get; set; }

        public static string Create_Campaign_Automated_Button { get; set; }

        public static string Verify_Approval_Card_Title { get; set; }
        public static string Verify_Approval_Card_Text { get; set; }
        public static string Verify_Approval_Left_Button { get; set; }
        public static string Verify_Approval_Right_Button { get; set; }

        public static string Verify_DesignPage_ApprovalCard_Title { get; set; }
        public static string Verify_DesignPage_ApprovalCard_Text { get; set; }
        public static string Verify_DesignPage_ApprovalCard_SelfApprove_Button { get; set; }
        public static string Verify_DesignPage_ApprovalCard_SendRequest_Button { get; set; }
        public static string RejectApproval__popUp_Cancel_button { get; set; }
        public static string Verify_SchedulePage_Schedule_Title { get; set; }
        public static string CreateCampaign_Audience_Selection { get; set; }

        public static string Deactivate_Schedule_Dialog_Contains_Title { get; set; }
        public static string Deactivate_Schedule_Dialog_Contains_Text { get; set; }
        public static string Deactivate_Schedule_Dialog_Contains_Cancel { get; set; }
        public static string Deactivate_Schedule_Dialog_Contains_Deactivate { get; set; }
        public static string Schedule_Campaign_details_Status { get; set; }
        public static string Schedule_Campaign_details_Send_Field { get; set; }
        public static string Schedule_Campaign_details_ScheduledBy_Field { get; set; }
        
        public static string Schedule_Campaign_Activate_Button { get; set; }
        public static string Activate_Schedule_Dialog_Contains_Activate_Button { get; set; }
        public static string Campaign_Card_Campaign_Ellipse_Edit { get; set; }
        public static string Campaign_Card_Campaign_Ellipse_ViewDetails { get; set; }
        public static string Campaign_Card_Campaign_Reject_textarea { get; set; }
        public static string Campaign_Card_Campaign_Reject_AutoMessage { get; set; }
        public static string Campaign_Card_Campaign_Reject_Comments { get; set; }

        #endregion[CreateCampaign]

        #region[ManageCampaign]
        public static string Card_View { get; set; }
        public static string List_View { get; set; }
        public static string Marketing_Toggle_Button { get; set; }
        public static string Automated_Toggle_Button { get; set; }
        public static string Hover_ListView_CampaignName { get; set; }
        public static string Hover_ListView_CampaignAudience { get; set; }
        public static string Campaign_ID { get; set; }
        public static string ManageCapaign_Audience_Name { get; set; }
        public static string ManageCapaign_Update_By { get; set; }
        public static string ManageCapaign_Updated_ON { get; set; }
        public static string ManageCapaign_Status { get; set; }
        public static string Click_Approved_from_listGrid { get; set; }
        public static string Campaign_Cards { get; set; }
        
        public static string Manage_Campaign_Name_Truncated { get; set; }
        public static string Click_ToVerifyLogout { get; set; }
        public static string VerifyLoggedinDashboard { get; set; }
        public static string Click_ManageCampaign_Ellipse { get; set; }
        public static string Click_ManageCampaign_Ellipse_Edit { get; set; }
        public static string Click_ManageCampaign_Ellipse_ViewDetails { get; set; }
        public static string Click_ManageCampaign_Ellipse_ViewDetails_Subject { get; set; }
        public static string CardView_Campaign_ID { get; set; }
        public static string CardView_Campaign_Status { get; set; }
        public static string Manage_Campaign_Cards_Title { get; set; }
        public static string Manage_Campaign_Cards_Audience_Name { get; set; }
        public static string Manage_Campaign_Cards_Subtitle_Name { get; set; }
        public static string Manage_Campaign_Cards_Status { get; set; }
        public static string Manage_Campaign_Cards_Avatar { get; set; }
        public static string Manage_Campaign_Cards_Update_Date { get; set; }
        public static string Manage_Campaign_Filter_DropDown_FilterOptions { get; set; }
        public static string Manage_Campaign_Filter_Status_DropDown_Arrow { get; set; }
        public static string Manage_Campaign_Filter_Status_DropDown_Input { get; set; }
        public static string Manage_Campaign_Filter_Status_DropDown_Options { get; set; }
        public static string Manage_Campaign_Filter_UpdatedOn_Input { get; set; }
        public static string Manage_Campaign_Filter_ID_Text { get; set; }
        public static string Manage_Campaign_Sort_Button { get; set; }
        public static string Manage_Campaign_Sort_Clear { get; set; }
        public static string Manage_Campaign_Sort_Apply { get; set; }
        public static string Manage_Campaign_Sort_DropDown_Arrows { get; set; }
        public static string Manage_Campaign_List_View_Loader { get; set; }

        public static string Click_ManageCampaign_cardView_StatusArrow { get; set; }
        public static string Check_ManageCampaign_cardView_Status_RequestApprove_button { get; set; }
        public static string Check_ManageCampaign_cardView_Status_SelfApprove_button { get; set; }
        public static string Check_ManageCampaign_cardView_Status_Schedule_button { get; set; }

        public static string Scheduled_Active_Edit_Button { get; set; }
        public static string Scheduled_Active_Deactivate_Button { get; set; }
        public static string Scheduled_InActive_Activate_Button { get; set; }
        public static string Click_ManageCampaign_ListView_StatusArrow { get; set; }
        public static string Approved_Campaign_details_ApprovedOn_Field { get; set; }
        public static string Approved_Campaign_details_Approvedby_Field { get; set; }
        public static string ListView_Campaign_Status { get; set; }
        public static string Approved_Campaign_details_Approvedby_Field_Value { get; set; }
        public static string Approved_Campaign_details_ApprovedOn_Field_Value { get; set; }
        public static string Click_On_Code_Editor { get; set; }
        public static string Enter_HTML_Code { get; set; }
        public static string Click_CSS { get; set; }
        public static string Enter_CSS_Code { get; set; }
        public static string Click_On_Code_Editor_Save_Button { get; set; }
        public static string View_Campaign_Summary_Tab { get; set; }
        public static string View_Campaign_Summary_General_Text { get; set; }
        public static string View_Campaign_Design_Tab { get; set; }
        public static string View_Campaign_Design_General_Text { get; set; }
        public static string View_Campaign_Audience_Tab { get; set; }
        public static string View_Campaign_Audience_Criteria_Text { get; set; }

        #endregion[ManageCampaign]

        #region[CreateTemplate]
        public static string Template_switchViewBtn_Verification { get; set; }
        public static string Template_switchViewBtn_Verification_List_OptionSelected { get; set; }
        public static string Template_Button_CreateTemplate { get; set; }
        public static string Template_Create_Cards { get; set; }
        public static string Template_Create_Template_Name_Input { get; set; }
        public static string Template_Create_Template_SaveAndContinue_Button { get; set; }
        public static string Template_Create_Template_Tag_Input { get; set; }
        public static string Template_Create_Template_Tag_Input_expansion { get; set; }
        public static string Template_Create_Template_desc_Input { get; set; }
        public static string Template_Create_Confirm_Tag_Input { get; set; }
        public static string Template_Create_Confirm_Tag_Arrow { get; set; }
        public static string Template_Create_Confirm_Tag_List { get; set; }
        public static string Template_Create_Verify_Selected { get; set; }
        public static string Template_Grid_Cards_Breadcrumb { get; set; }
        public static string Template_Grid_Cards_Image { get; set; }
        public static string Template_Grid_Cards_Title { get; set; }
        public static string Template_Grid_Cards_Status { get; set; }
        public static string Template_Grid_Cards_Tags_List { get; set; }
        public static string Template_Grid_Cards_Tags_More_Count { get; set; }
        public static string Template_Grid_Cards_Editor { get; set; }
        public static string Template_Grid_Cards_Update_Date { get; set; }
        public static string Template_Create_Share_Template_Text { get; set; }
        public static string Template_Create_Share_Template_On { get; set; }
        public static string Template_Create_Share_Template_Off { get; set; }
        public static string Template_Create_Cancel_Button { get; set; }
        public static string Template_Create_Prev_Button { get; set; }
        public static string Template_Create_Name_Error { get; set; }
        public static string Template_Grid_Cards_Tooltip { get; set; }
        public static string Template_Create_Confirm_grid3x3_Card { get; set; }

        public static string Template_Grid_Header_Name { get; set; }
        public static string Template_Grid_Header_Tags { get; set; }
        public static string Template_Grid_Header_Status { get; set; }
        public static string Template_Grid_Header_Camapigns { get; set; }
        public static string Template_Grid_Header_Updated_By { get; set; }
        public static string Template_Grid_Header_Updated_On { get; set; }

        public static string Click_TemplatePage_Ellipses { get; set; }
        public static string Click_TemplatePage_Ellipses_ViewDetails { get; set; }
        public static string Click_TemplatePage_Ellipses_ViewDetails_SummaryTab { get; set; }
        public static string Click_TemplatePage_SummaryTab { get; set; }
        public static string Click_ListView_FirstTemplate { get; set; }
        public static string Template_Create_Template_View_In_Browser_Link { get; set; }
        public static string Template_Create_Template_Unsubsribe_Link { get; set; }
        public static string Template_Create_Template_Design_Elements { get; set; }
        public static string Create_Template_Name_red { get; set; }
        public static string Create_Template_DesignPage_SelectElement { get; set; }
        public static string Create_Template_DesignPage_body { get; set; }
        public static string iframe_Create_Template_DesignPage_body { get; set; }
        
        #endregion[CreateTemplate]

        #region[CreateAudience]
        public static string Audience_Breadcrumb { get; set; }
        public static string Audience_Create_Button { get; set; }
        public static string Audience_Cards { get; set; }
        public static string Click_Audience_Name { get; set; }
        public static string Verify_CriteriaTab_AudiencePage { get; set; }
        public static string Get_Audience_Name { get; set; }
        public static string Get_Audience_Status { get; set; }
        public static string Get_Audience_Tag { get; set; }
        public static string Get_Audience_UpdatedDate { get; set; }
        public static string Click_ManageAudience_CampaignTab { get; set; }
        public static string Audience_Details_Campaign_Tab { get; set; }
        public static string AudienceOrSegmentButton { get; set; }
        public static string HeaderTitle { get; set; }
        public static string Create_Button { get; set; }
        public static string Create_Audience_Button { get; set; }
        public static string Create_Segment_Button { get; set; }
        public static string Create_Audience_Name { get; set; }
        public static string Create_Audience_Tag_input { get; set; }
        public static string Create_Audience_Tag_List { get; set; }
        public static string Create_Audience_Description { get; set; }
        public static string Audience_Cards_Title { get; set; }
        public static string Create_Segment_Name { get; set; }
        public static string Create_Segment_Tag_input { get; set; }
        public static string Create_Segment_Tag_List { get; set; }
        public static string Create_Segment_Description { get; set; }
        public static string Create_Segment_Domain_Arrow { get; set; }   
        public static string Create_Segment_DomainOrField_List { get; set; }   
        public static string Create_Segment_AddRow { get; set; }   
        public static string Create_Segment_Save { get; set; }   
        public static string Create_Segment_Field_Arrow { get; set; }   
        public static string Create_Segment_Operation_Arrow { get; set; }   
        public static string Create_Segment_Finish { get; set; }   
        public static string Segment_Cards_Title { get; set; }   
        public static string Audience_Cards_Status { get; set; }   
        public static string Segment_Cards { get; set; }   
        public static string Create_Segment_CriteriaValue { get; set; }   
        public static string Segment_Creation_MSG { get; set; }   
        public static string Segment_Cards_Status { get; set; }   

        #endregion[CreateAudience]

        #region[ManageTemplate]
        public static string Manage_Template_Column_Filter_Options_Arrow { get; set; }
        public static string Manage_Template_Filter_Options_List { get; set; }
        public static string Manage_Template_Filter_Input { get; set; }
        public static string Manage_Template_Filter_Text { get; set; }
        public static string Manage_Template_Clear_Filters_No_Result { get; set; }
        public static string Manage_Template_List_View_Details { get; set; }
        public static string Manage_Template_Filter_Input_Dates { get; set; }
        public static string Audience_Summary_Tabs { get; set; }

        #endregion[ManageTemplate]
        #region[Email]
        public static string Outlook_Email_Heading { get; set; }
        public static string Outlook_Yahoo_Email_Body { get; set; }
        public static string Yahoo_Email_Username { get; set; }
        public static string Yahoo_Email_Next { get; set; }
        public static string Yahoo_Email_Password { get; set; }
        public static string Yahoo_Email_Submit { get; set; }
        public static string Yahoo_Email_Search_Input { get; set; }
        public static string Yahoo_Email_Searched_Result_Li { get; set; }
        public static string Outlook_Email_No_Result { get; set; }
        public static string Yahoo_Email_Sign_In_Link { get; set; }


        #endregion[Email]

        public static ObjectRepository ReadElement(string location, string nodeModule)
        {
            ObjectRepository obj = new ObjectRepository();
            XDocument doc = XDocument.Load(location);
            var query = doc.Descendants(nodeModule).Elements().ToDictionary(x => x.Attribute("key").Value, x => x.Value);

            foreach (KeyValuePair<string, string> pair in query)
            {
                #region[Login]

                if (nodeModule == Constants.SignIn)
                {
                    if (pair.Key == "SignIn_Email")
                        SignIn_Email = pair.Value;
                    else if (pair.Key == "SignIn_Password")
                        SignIn_Password = pair.Value;
                    else if (pair.Key == "SignIn_Submit")
                        SignIn_Submit = pair.Value;
                }

                #endregion[Login]
                #region[Home]

                if (nodeModule == Constants.Home)
                {
                    if (pair.Key == "Home_Applications")
                        Home_Applications = pair.Value;
                    else if (pair.Key == "Home_Org_Popup")
                        Home_Org_Popup = pair.Value;
                    else if (pair.Key == "Home_Org_Popup_Cancel")
                        Home_Org_Popup_Cancel = pair.Value;
                    else if (pair.Key == "Home_Org_Popup_Choose")
                        Home_Org_Popup_Choose = pair.Value;
                    else if (pair.Key == "Home_Sidebar_Org_Popup_Choose")
                        Home_Sidebar_Org_Popup_Choose = pair.Value;
                    else if (pair.Key == "Home_Sidebar_Home")
                        Home_Sidebar_Home = pair.Value;
                }

                #endregion[Home]

                #region[Navigation]
                if (nodeModule == Constants.Navigation)
                {
                    if (pair.Key == "Navigation_Button_Campaigns")
                        Navigation_Button_Campaigns = pair.Value;
                    else if (pair.Key == "Navigation_text_MAutomation")
                        Navigation_text_MAutomation = pair.Value;
                    else if (pair.Key == "Navigation_Button_Campaigns_Sidebar")
                        Navigation_Button_Campaigns_Sidebar = pair.Value;
                    else if (pair.Key == "Navigation_Button_Templates")
                        Navigation_Button_Templates = pair.Value;
                    else if (pair.Key == "Navigation_Button_Audiences")
                        Navigation_Button_Audiences = pair.Value;
                    else if (pair.Key == "Navigation_To_MAutomation_FromCHC")
                        Navigation_To_MAutomation_FromCHC = pair.Value;
                    else if (pair.Key == "TotalNavigatingNavbar")
                        TotalNavigatingNavbar = pair.Value;
                }
                #endregion[Navigation]

                #region[CreateCampaign]
                if (nodeModule == Constants.CreateCampaign)
                {
                    if (pair.Key == "Campaign_Button_CreateCampaign")
                        Campaign_Button_CreateCampaign = pair.Value;
                    else if (pair.Key == "Campaign_Button_Marketing")
                        Campaign_Button_Marketing = pair.Value;
                    else if (pair.Key == "Campaign_Button_Automated")
                        Campaign_Button_Automated = pair.Value;
                    else if (pair.Key == "Campaign_Button_ApplicationCards")
                        Campaign_Button_ApplicationCards = pair.Value;
                    else if (pair.Key == "Campaign_Create_Wizard_Settings")
                        Campaign_Create_Wizard_Settings = pair.Value;
                    else if (pair.Key == "Campaign_Create_Wizard_Back_Button")
                        Campaign_Create_Wizard_Back_Button = pair.Value;
                    else if (pair.Key == "Campaign_Create_Wizard_Audience")
                        Campaign_Create_Wizard_Audience = pair.Value;
                    else if (pair.Key == "Campaign_Create_Campaign_Name_Input")
                        Campaign_Create_Campaign_Name_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Campaign_Name_Error_Text")
                        Campaign_Create_Campaign_Name_Error_Text = pair.Value;
                    else if (pair.Key == "Campaign_Create_Campaign_Subject_Input")
                        Campaign_Create_Campaign_Subject_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Campaign_Subject_Error_Text")
                        Campaign_Create_Campaign_Subject_Error_Text = pair.Value;
                    else if (pair.Key == "Campaign_Create_Campaign_Subject_InLine_Text")
                        Campaign_Create_Campaign_Subject_InLine_Text = pair.Value;
                    else if (pair.Key == "Campaign_Create_Campaign_From_Dropdown")
                        Campaign_Create_Campaign_From_Dropdown = pair.Value;
                    else if (pair.Key == "Campaign_Create_Campaign_From_Error_Text")
                        Campaign_Create_Campaign_From_Error_Text = pair.Value;
                    else if (pair.Key == "Campaign_Create_Campaign_Form_Search_Input")
                        Campaign_Create_Campaign_Form_Search_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Campaign_Form_DropDownList")
                        Campaign_Create_Campaign_Form_DropDownList = pair.Value;
                    else if (pair.Key == "Campaign_Create_Campaign_Form_RemoveSelection_Button")
                        Campaign_Create_Campaign_Form_RemoveSelection_Button = pair.Value;
                    else if (pair.Key == "Campaign_Create_Campaign_Reply_Dropdown")
                        Campaign_Create_Campaign_Reply_Dropdown = pair.Value;
                    else if (pair.Key == "Campaign_Create_Campaign_Reply_Search_Input")
                        Campaign_Create_Campaign_Reply_Search_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Campaign_Reply_DropDownList")
                        Campaign_Create_Campaign_Reply_DropDownList = pair.Value;
                    else if (pair.Key == "Campaign_Create_Campaign_Reply_RemoveSelection_Button")
                        Campaign_Create_Campaign_Reply_RemoveSelection_Button = pair.Value;
                    else if (pair.Key == "Campaign_Create_Campaign_Tip_Text")
                        Campaign_Create_Campaign_Tip_Text = pair.Value;
                    else if (pair.Key == "Campaign_Create_Campaign_SaveAndContinue_Button")
                        Campaign_Create_Campaign_SaveAndContinue_Button = pair.Value;
                    else if (pair.Key == "Campaign_Create_Campaign_From_Dropdown_Input")
                        Campaign_Create_Campaign_From_Dropdown_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Campaign_Reply_Dropdown_Input")
                        Campaign_Create_Campaign_Reply_Dropdown_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_Grid_button")
                        Campaign_Create_Audience_Grid_button = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_List_button")
                        Campaign_Create_Audience_List_button = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_Sort_button")
                        Campaign_Create_Audience_Sort_button = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_Sort_Options")
                        Campaign_Create_Audience_Sort_Options = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_Card_Menu_Ellipses")
                        Campaign_Create_Audience_Card_Menu_Ellipses = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_Card_SelectAndContinue_Button")
                        Campaign_Create_Audience_Card_SelectAndContinue_Button = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_Cards_Title")
                        Campaign_Create_Audience_Cards_Title = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_Cards_SubTitles")
                        Campaign_Create_Audience_Cards_SubTitles = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_Card_ToolTip_Text")
                        Campaign_Create_Audience_Card_ToolTip_Text = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_Cards_Tag_List")
                        Campaign_Create_Audience_Cards_Tag_List = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_List_Cards_Tag_List")
                        Campaign_Create_Audience_List_Cards_Tag_List = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_Cards_Tag_More_Count")
                        Campaign_Create_Audience_Cards_Tag_More_Count = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_Cards_More_Tag_List")
                        Campaign_Create_Audience_Cards_More_Tag_List = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_Cards_Users_Count")
                        Campaign_Create_Audience_Cards_Users_Count = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_Cards_Email_Count")
                        Campaign_Create_Audience_Cards_Email_Count = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_Cards_Dates")
                        Campaign_Create_Audience_Cards_Dates = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_Previous_Page_Button")
                        Campaign_Create_Audience_Previous_Page_Button = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_Next_Page_Button")
                        Campaign_Create_Audience_Next_Page_Button = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_Paggination_Page_Numbers")
                        Campaign_Create_Audience_Paggination_Page_Numbers = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_Card_Border")
                        Campaign_Create_Audience_Card_Border = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_Cards_Truncated")
                        Campaign_Create_Audience_Cards_Truncated = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_Preview_Audience_Name")
                        Campaign_Create_Audience_Preview_Audience_Name = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_Preview_Audience_Description")
                        Campaign_Create_Audience_Preview_Audience_Description = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_Preview_Criteria_Text")
                        Campaign_Create_Audience_Preview_Criteria_Text = pair.Value;
                    else if (pair.Key == "Campaign_Create_Wizard_Settings_Checked")
                        Campaign_Create_Wizard_Settings_Checked = pair.Value;
                    else if (pair.Key == "Campaign_Create_Wizard_Audience_Checked")
                        Campaign_Create_Wizard_Audience_Checked = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_Preview_Total_Count")
                        Campaign_Create_Audience_Preview_Total_Count = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_Preview_Created_Date")
                        Campaign_Create_Audience_Preview_Created_Date = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_Preview_Campaigns_Count")
                        Campaign_Create_Audience_Preview_Campaigns_Count = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_Preview_Loader")
                        Campaign_Create_Audience_Preview_Loader = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_ListView_Column_Header")
                        Campaign_Create_Audience_ListView_Column_Header = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_ListView_Cell_Data")
                        Campaign_Create_Audience_ListView_Cell_Data = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_ListView_Previous_Page_Button")
                        Campaign_Create_Audience_ListView_Previous_Page_Button = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_ListView_Next_Page_Button")
                        Campaign_Create_Audience_ListView_Next_Page_Button = pair.Value;
                    else if (pair.Key == "Campaign_Create_Audience_ListView_Page_Numbers")
                        Campaign_Create_Audience_ListView_Page_Numbers = pair.Value;
                    else if (pair.Key == "Campaign_Create_Design_New_Button")
                        Campaign_Create_Design_New_Button = pair.Value;
                    else if (pair.Key == "Campaign_Create_Design_ListView_Button")
                        Campaign_Create_Design_ListView_Button = pair.Value;
                    else if (pair.Key == "Campaign_Create_Design_GridView_Button")
                        Campaign_Create_Design_GridView_Button = pair.Value;
                    else if (pair.Key == "Campaign_Create_Design_Card_Clone_Button")
                        Campaign_Create_Design_Card_Clone_Button = pair.Value;
                    else if (pair.Key == "Campaign_Create_Design_Cards_Images")
                        Campaign_Create_Design_Cards_Images = pair.Value;
                    else if (pair.Key == "Campaign_Create_Design_Cards_Title")
                        Campaign_Create_Design_Cards_Title = pair.Value;
                    else if (pair.Key == "Campaign_Create_Design_Card_Border")
                        Campaign_Create_Design_Card_Border = pair.Value;
                    else if (pair.Key == "Campaign_Create_Design_Cards_Tag_List")
                        Campaign_Create_Design_Cards_Tag_List = pair.Value;
                    else if (pair.Key == "Campaign_Create_Design_Cards_Users_Name")
                        Campaign_Create_Design_Cards_Users_Name = pair.Value;
                    else if (pair.Key == "Campaign_Create_Design_Preview_Page_Loader")
                        Campaign_Create_Design_Preview_Page_Loader = pair.Value;
                    else if (pair.Key == "Campaign_Create_Design_Preview_Edit_Text")
                        Campaign_Create_Design_Preview_Edit_Text = pair.Value;
                    else if (pair.Key == "Campaign_Create_Design_Preview_Edit_Design_Button")
                        Campaign_Create_Design_Preview_Edit_Design_Button = pair.Value;
                    else if (pair.Key == "Campaign_Create_Design_Preview_Created_Date")
                        Campaign_Create_Design_Preview_Created_Date = pair.Value;
                    else if (pair.Key == "Campaign_Create_Design_Preview_Updated_Date")
                        Campaign_Create_Design_Preview_Updated_Date = pair.Value;
                    else if (pair.Key == "Campaign_Create_Design_Preview_Campaign_Count")
                        Campaign_Create_Design_Preview_Campaign_Count = pair.Value;
                    else if (pair.Key == "Campaign_Create_Design_Preview_Tag_Count")
                        Campaign_Create_Design_Preview_Tag_Count = pair.Value;
                    else if (pair.Key == "Campaign_Create_Wizard_Design")
                        Campaign_Create_Wizard_Design = pair.Value;
                    else if (pair.Key == "Campaign_Create_Wizard_Design_Checked")
                        Campaign_Create_Wizard_Design_Checked = pair.Value;
                    else if (pair.Key == "Campaign_Create_Design_Preview_Design_Title")
                        Campaign_Create_Design_Preview_Design_Title = pair.Value;
                    else if (pair.Key == "Campaign_Create_Design_Preview_ViewIn_Browser")
                        Campaign_Create_Design_Preview_ViewIn_Browser = pair.Value;
                    else if (pair.Key == "Campaign_Create_Design_List_Truncated")
                        Campaign_Create_Design_List_Truncated = pair.Value;
                    else if (pair.Key == "Campaign_Create_Wizard_Confirm")
                        Campaign_Create_Wizard_Confirm = pair.Value;
                    else if (pair.Key == "Campaign_Create_Wizard_Confirm_Checked")
                        Campaign_Create_Wizard_Confirm_Checked = pair.Value;
                    else if (pair.Key == "Campaign_Create_Wizard_Confirm_Finish")
                        Campaign_Create_Wizard_Confirm_Finish = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Card_Title")
                        Campaign_Create_Confirm_Card_Title = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Card_Description")
                        Campaign_Create_Confirm_Card_Description = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_From_Name")
                        Campaign_Create_Confirm_From_Name = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_From_Email")
                        Campaign_Create_Confirm_From_Email = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Audience_Name")
                        Campaign_Create_Confirm_Audience_Name = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Audience_Count")
                        Campaign_Create_Confirm_Audience_Count = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Self_Approve")
                        Campaign_Create_Confirm_Self_Approve = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Send_Request")
                        Campaign_Create_Confirm_Send_Request = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Schedule_Text")
                        Campaign_Create_Confirm_Schedule_Text = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Send_Clear_Value")
                        Campaign_Create_Confirm_Send_Clear_Value = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Send_Input")
                        Campaign_Create_Confirm_Send_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Success_Message")
                        Campaign_Create_Success_Message = pair.Value;
                    else if (pair.Key == "Campaign_Create_Success_Manage_Campaigns_Button")
                        Campaign_Create_Success_Manage_Campaigns_Button = pair.Value;
                    else if (pair.Key == "Campaign_Create_Success_Edit_Schedule_Link")
                        Campaign_Create_Success_Edit_Schedule_Link = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Start_On_Picker_Icon")
                        Campaign_Create_Confirm_Start_On_Picker_Icon = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Start_On_Clear_Icon")
                        Campaign_Create_Confirm_Start_On_Clear_Icon = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Days_From_Picker_Icon")
                        Campaign_Create_Confirm_Days_From_Picker_Icon = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Days_From_Clear_Icon")
                        Campaign_Create_Confirm_Days_From_Clear_Icon = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Until_Picker_Icon")
                        Campaign_Create_Confirm_Until_Picker_Icon = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Until_Clear_Icon")
                        Campaign_Create_Confirm_Until_Clear_Icon = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_At_Time_Icon")
                        Campaign_Create_Confirm_At_Time_Icon = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Time_Zone_Input")
                        Campaign_Create_Confirm_Time_Zone_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Time_Zone_Clear_Icon")
                        Campaign_Create_Confirm_Time_Zone_Clear_Icon = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Days_From_Input")
                        Campaign_Create_Confirm_Days_From_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Start_On_Input")
                        Campaign_Create_Confirm_Start_On_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Until_Input")
                        Campaign_Create_Confirm_Until_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_At_Time_Input")
                        Campaign_Create_Confirm_At_Time_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Every_Input")
                        Campaign_Create_Confirm_Every_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Send_Input_DropDown")
                        Campaign_Create_Confirm_Send_Input_DropDown = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Send_List")
                        Campaign_Create_Confirm_Send_List = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Send_Input_ToEnter")
                        Campaign_Create_Confirm_Send_Input_ToEnter = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_On_Input")
                        Campaign_Create_Confirm_On_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_On_Picker_Icon")
                        Campaign_Create_Confirm_On_Picker_Icon = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_FutureDates")
                        Campaign_Create_Confirm_FutureDates = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_At_Time_List")
                        Campaign_Create_Confirm_At_Time_List = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Time_Zone_Down_Arrow")
                        Campaign_Create_Confirm_Time_Zone_Down_Arrow = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Time_Zone_Search_Input")
                        Campaign_Create_Confirm_Time_Zone_Search_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Time_Zone_Options_List")
                        Campaign_Create_Confirm_Time_Zone_Options_List = pair.Value;
                    else if (pair.Key == "Campaign_Create_Success_Text")
                        Campaign_Create_Success_Text = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Every_Arrow")
                        Campaign_Create_Confirm_Every_Arrow = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Every_Search_Input")
                        Campaign_Create_Confirm_Every_Search_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Every_List")
                        Campaign_Create_Confirm_Every_List = pair.Value;
                    else if (pair.Key == "Campaign_Create_Design_Click_SendMail")
                        Campaign_Create_Design_Click_SendMail = pair.Value;
                    else if (pair.Key == "Campaign_Create_Design_SeedList_value")
                        Campaign_Create_Design_SeedList_value = pair.Value;
                    else if (pair.Key == "Campaign_Create_Design_SeedList_DDL")
                        Campaign_Create_Design_SeedList_DDL = pair.Value;
                    else if (pair.Key == "Campaign_Create_Design_SendTest_Send_Button")
                        Campaign_Create_Design_SendTest_Send_Button = pair.Value;
                    else if (pair.Key == "Recipients_Text_Box")
                        Recipients_Text_Box = pair.Value;
                    else if (pair.Key == "Campaign_Create_Design_Enter_SeedList")
                        Campaign_Create_Design_Enter_SeedList = pair.Value;
                    else if (pair.Key == "Enter_Recipients")
                        Enter_Recipients = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Calendar_Next")
                        Campaign_Create_Confirm_Calendar_Next = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Calendar_Previous")
                        Campaign_Create_Confirm_Calendar_Previous = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Months_From_Picker_Icon")
                        Campaign_Create_Confirm_Months_From_Picker_Icon = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Months_From_Input")
                        Campaign_Create_Confirm_Months_From_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Every_Month_Input")
                        Campaign_Create_Confirm_Every_Month_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Every_Monthly_Arrow")
                        Campaign_Create_Confirm_Every_Monthly_Arrow = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Every_Search_Month_Input")
                        Campaign_Create_Confirm_Every_Search_Month_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Every_Monthly_List")
                        Campaign_Create_Confirm_Every_Monthly_List = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Every_Minute_Input")
                        Campaign_Create_Confirm_Every_Minute_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Every_Minute_Arrow")
                        Campaign_Create_Confirm_Every_Minute_Arrow = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Every_Minute_Search_Input")
                        Campaign_Create_Confirm_Every_Minute_Search_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Every_Minute_List")
                        Campaign_Create_Confirm_Every_Minute_List = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Minutes_From_Picker_Icon")
                        Campaign_Create_Confirm_Minutes_From_Picker_Icon = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Minutes_From_Clear_Icon")
                        Campaign_Create_Confirm_Minutes_From_Clear_Icon = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Minutes_From_Input")
                        Campaign_Create_Confirm_Minutes_From_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Todays_Dates")
                        Campaign_Create_Confirm_Todays_Dates = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Hours_From_Picker_Icon")
                        Campaign_Create_Confirm_Hours_From_Picker_Icon = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Hours_From_Input")
                        Campaign_Create_Confirm_Hours_From_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Hours_From_Clear_Icon")
                        Campaign_Create_Confirm_Hours_From_Clear_Icon = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Every_Hours_Input")
                        Campaign_Create_Confirm_Every_Hours_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Every_Hours_Arrow")
                        Campaign_Create_Confirm_Every_Hours_Arrow = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Every_Hours_Search_Input")
                        Campaign_Create_Confirm_Every_Hours_Search_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Every_Hours_List")
                        Campaign_Create_Confirm_Every_Hours_List = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Every_Hourly_Input")
                        Campaign_Create_Confirm_Every_Hourly_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Every_Hourly_Arrow")
                        Campaign_Create_Confirm_Every_Hourly_Arrow = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Every_Hourly_Search_Input")
                        Campaign_Create_Confirm_Every_Hourly_Search_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Every_Hourly_List")
                        Campaign_Create_Confirm_Every_Hourly_List = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Weekly_From_Picker_Icon")
                        Campaign_Create_Confirm_Weekly_From_Picker_Icon = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Weekly_From_Input")
                        Campaign_Create_Confirm_Weekly_From_Input = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_Weekly_Day")
                        Campaign_Create_Confirm_Weekly_Day = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_grid3x3_Card")
                        Campaign_Create_Confirm_grid3x3_Card = pair.Value;
                    else if (pair.Key == "Campaign_Create_Confirm_TwoButtons")
                        Campaign_Create_Confirm_TwoButtons = pair.Value;
                    else if (pair.Key == "Confirm_Icon_AtTop")
                        Confirm_Icon_AtTop = pair.Value;
                    else if (pair.Key == "SelectionOTabVerify")
                        SelectionOTabVerify = pair.Value;
                    else if (pair.Key == "Logout_Button")
                        Logout_Button = pair.Value;
                    else if (pair.Key == "Campaign_Card_Ellipses")
                        Campaign_Card_Ellipses = pair.Value;
                    else if (pair.Key == "Campaign_Card_Titles")
                        Campaign_Card_Titles = pair.Value;
                    else if (pair.Key == "Campaign_Card_Campaign_IDs")
                        Campaign_Card_Campaign_IDs = pair.Value;
                    else if (pair.Key == "Campaign_Card_Campaign_Ellipse_Clone")
                        Campaign_Card_Campaign_Ellipse_Clone = pair.Value;
                    else if (pair.Key == "Campaign_Filter")
                        Campaign_Filter = pair.Value;
                    else if (pair.Key == "Campaign_Filter_Name")
                        Campaign_Filter_Name = pair.Value;
                    else if (pair.Key == "Campaign_Filter_Name_Search_Text")
                        Campaign_Filter_Name_Search_Text = pair.Value;
                    else if (pair.Key == "Campaign_Filter_Button_Apply")
                        Campaign_Filter_Button_Apply = pair.Value;
                    else if (pair.Key == "Campaign_Filter_Name_Value") 
                       Campaign_Filter_Name_Value = pair.Value;
                    else if (pair.Key == "Campaign_Filter_Name_Value_List") 
                      Campaign_Filter_Name_Value_List = pair.Value;


                    else if (pair.Key == "Campaign_Click_Filter")
                        Campaign_Click_Filter = pair.Value;
                    else if (pair.Key == "Campaign_Click_Filter_Name_ddL")
                        Campaign_Click_Filter_Name_ddL = pair.Value;
                    else if (pair.Key == "Campaign_Click_Filter_Name_ddL_Value")
                        Campaign_Click_Filter_Name_ddL_Value = pair.Value;
                    else if (pair.Key == "Campaign_Click_Filter_Name_Enter_CampaignName")
                        Campaign_Click_Filter_Name_Enter_CampaignName = pair.Value;
                    else if (pair.Key == "Campaign_Click_Filter_Apply_Button")
                        Campaign_Click_Filter_Apply_Button = pair.Value;
                    else if (pair.Key == "Campaign_Filter_Enter_ID")
                        Campaign_Filter_Enter_ID = pair.Value;
                    else if (pair.Key == "Campaign_Click_Filter_ID_ddL")
                        Campaign_Click_Filter_ID_ddL = pair.Value;
                    else if (pair.Key == "Campaign_Click_Filter_Audience_DDl")
                        Campaign_Click_Filter_Audience_DDl = pair.Value;
                    else if (pair.Key == "Campaign_Click_Filter_Enter_Audience")
                        Campaign_Click_Filter_Enter_Audience = pair.Value;
                    else if (pair.Key == "Campaign_Click_Approval_SendRequest_Button")
                        Campaign_Click_Approval_SendRequest_Button = pair.Value;
                    else if (pair.Key == "Campaign_Click_Approval_SendRequest_Approve_Button")
                        Campaign_Click_Approval_SendRequest_Approve_Button = pair.Value;
                    else if (pair.Key == "Campaign_Click_Approval_SendRequest_Reject_Button")
                        Campaign_Click_Approval_SendRequest_Reject_Button = pair.Value;
                    else if (pair.Key == "Campaign_Click_Approval_Click_SelfApprove_Button")
                        Campaign_Click_Approval_Click_SelfApprove_Button = pair.Value;
                    else if (pair.Key == "Click_design_SelfApprove_Send_DDL")
                        Click_design_SelfApprove_Send_DDL = pair.Value;
                    else if (pair.Key == "Click_design_SelfApprove_TimeZone_DDL")
                        Click_design_SelfApprove_TimeZone_DDL = pair.Value;
                    else if (pair.Key == "Click_design_SelfApprove_On_Value")
                        Click_design_SelfApprove_On_Value = pair.Value;
                    else if (pair.Key == "Click_design_SelfApprove_Enter_Send_Value")
                        Click_design_SelfApprove_Enter_Send_Value = pair.Value;
                    else if (pair.Key == "RejectApproval__popUp_Reject_button")
                        RejectApproval__popUp_Reject_button = pair.Value;
                    else if (pair.Key == "RejectApproval__popUp_Enter_text")
                        RejectApproval__popUp_Enter_text = pair.Value;
                    else if (pair.Key == "Create_Campaign_Automated_Button")
                        Create_Campaign_Automated_Button = pair.Value;
                    
                    else if (pair.Key == "Campaign_Click_Filter_Clear_Button")
                        Campaign_Click_Filter_Clear_Button = pair.Value;

                    else if (pair.Key == "Verify_Approval_Card_Title")
                        Verify_Approval_Card_Title = pair.Value;
                    else if (pair.Key == "Verify_Approval_Card_Text")
                        Verify_Approval_Card_Text = pair.Value;
                    else if (pair.Key == "Verify_Approval_Left_Button")
                        Verify_Approval_Left_Button = pair.Value;
                    else if (pair.Key == "Verify_Approval_Right_Button")
                        Verify_Approval_Right_Button = pair.Value;

                    else if (pair.Key == "Verify_DesignPage_ApprovalCard_Title")
                        Verify_DesignPage_ApprovalCard_Title = pair.Value;
                    else if (pair.Key == "Verify_DesignPage_ApprovalCard_Text")
                        Verify_DesignPage_ApprovalCard_Text = pair.Value;
                    else if (pair.Key == "Verify_DesignPage_ApprovalCard_SelfApprove_Button")
                        Verify_DesignPage_ApprovalCard_SelfApprove_Button = pair.Value;
                    else if (pair.Key == "Verify_DesignPage_ApprovalCard_SendRequest_Button")
                        Verify_DesignPage_ApprovalCard_SendRequest_Button = pair.Value;
                    else if (pair.Key == "RejectApproval__popUp_Cancel_button")
                        RejectApproval__popUp_Cancel_button = pair.Value;
                    else if (pair.Key == "Verify_SchedulePage_Schedule_Title")
                        Verify_SchedulePage_Schedule_Title = pair.Value;
                    else if (pair.Key == "CreateCampaign_Audience_Selection")
                        CreateCampaign_Audience_Selection = pair.Value;
                    else if (pair.Key == "Deactivate_Schedule_Dialog_Contains_Title")
                        Deactivate_Schedule_Dialog_Contains_Title = pair.Value;
                    else if (pair.Key == "Deactivate_Schedule_Dialog_Contains_Text")
                        Deactivate_Schedule_Dialog_Contains_Text = pair.Value;
                    else if (pair.Key == "Deactivate_Schedule_Dialog_Contains_Cancel")
                        Deactivate_Schedule_Dialog_Contains_Cancel = pair.Value;
                    else if (pair.Key == "Deactivate_Schedule_Dialog_Contains_Deactivate")
                        Deactivate_Schedule_Dialog_Contains_Deactivate = pair.Value;
                    else if (pair.Key == "Schedule_Campaign_details_Status")
                        Schedule_Campaign_details_Status = pair.Value;
                    else if (pair.Key == "Schedule_Campaign_details_Send_Field")
                        Schedule_Campaign_details_Send_Field = pair.Value;
                    else if (pair.Key == "Schedule_Campaign_details_ScheduledBy_Field")
                        Schedule_Campaign_details_ScheduledBy_Field = pair.Value;
                    else if (pair.Key == "Schedule_Campaign_Activate_Button")
                        Schedule_Campaign_Activate_Button = pair.Value;
                    else if (pair.Key == "Activate_Schedule_Dialog_Contains_Activate_Button")
                        Activate_Schedule_Dialog_Contains_Activate_Button = pair.Value;
                    else if (pair.Key == "Campaign_Card_Campaign_Ellipse_Edit")
                        Campaign_Card_Campaign_Ellipse_Edit = pair.Value;
                    else if (pair.Key == "Campaign_Card_Campaign_Ellipse_ViewDetails")
                        Campaign_Card_Campaign_Ellipse_ViewDetails = pair.Value;
                    else if (pair.Key == "Campaign_Card_Campaign_Reject_textarea")
                        Campaign_Card_Campaign_Reject_textarea = pair.Value;
                    else if (pair.Key == "Campaign_Card_Campaign_Reject_Comments")
                        Campaign_Card_Campaign_Reject_Comments = pair.Value;
                    else if (pair.Key == "Campaign_Card_Campaign_Reject_AutoMessage")
                        Campaign_Card_Campaign_Reject_AutoMessage = pair.Value;
                }

                #endregion[CreateCampaign]

                #region[CreateTemplate]
                if (nodeModule == Constants.CreateTemplate)
                {
                    if (pair.Key == "Template_Button_CreateTemplate")
                        Template_Button_CreateTemplate = pair.Value;
                    else if (pair.Key == "Template_switchViewBtn_Verification_List_OptionSelected")
                        Template_switchViewBtn_Verification_List_OptionSelected = pair.Value;
                    else if (pair.Key == "Template_switchViewBtn_Verification")
                        Template_switchViewBtn_Verification = pair.Value;
                    else if (pair.Key == "Template_Create_Cards")
                        Template_Create_Cards = pair.Value;
                    else if (pair.Key == "Template_Create_Template_Name_Input")
                        Template_Create_Template_Name_Input = pair.Value;
                    else if (pair.Key == "Template_Create_Template_SaveAndContinue_Button")
                        Template_Create_Template_SaveAndContinue_Button = pair.Value;
                    else if (pair.Key == "Template_Create_Template_Tag_Input")
                        Template_Create_Template_Tag_Input = pair.Value;
                    else if (pair.Key == "Template_Create_Template_Tag_Input_expansion")
                        Template_Create_Template_Tag_Input_expansion = pair.Value;
                    else if (pair.Key == "Template_Create_Template_desc_Input")
                        Template_Create_Template_desc_Input = pair.Value;
                    else if (pair.Key == "Template_Create_Confirm_Tag_Input")
                        Template_Create_Confirm_Tag_Input = pair.Value;
                    else if (pair.Key == "Template_Create_Confirm_Tag_Arrow")
                        Template_Create_Confirm_Tag_Arrow = pair.Value;
                    else if (pair.Key == "Template_Create_Confirm_Tag_List")
                        Template_Create_Confirm_Tag_List = pair.Value;
                    else if (pair.Key == "Template_Create_Verify_Selected")
                        Template_Create_Verify_Selected = pair.Value;
                    else if (pair.Key == "Template_Grid_Cards_Breadcrumb")
                        Template_Grid_Cards_Breadcrumb = pair.Value;
                    else if (pair.Key == "Template_Grid_Cards_Image")
                        Template_Grid_Cards_Image = pair.Value;
                    else if (pair.Key == "Template_Grid_Cards_Title")
                        Template_Grid_Cards_Title = pair.Value;
                    else if (pair.Key == "Template_Grid_Cards_Status")
                        Template_Grid_Cards_Status = pair.Value;
                    else if (pair.Key == "Template_Grid_Cards_Tags_List")
                        Template_Grid_Cards_Tags_List = pair.Value;
                    else if (pair.Key == "Template_Grid_Cards_Tags_More_Count")
                        Template_Grid_Cards_Tags_More_Count = pair.Value;
                    else if (pair.Key == "Template_Grid_Cards_Editor")
                        Template_Grid_Cards_Editor = pair.Value;
                    else if (pair.Key == "Template_Create_Share_Template_Text")
                        Template_Create_Share_Template_Text = pair.Value;
                    else if (pair.Key == "Template_Create_Share_Template_On")
                        Template_Create_Share_Template_On = pair.Value;
                    else if (pair.Key == "Template_Create_Share_Template_Off")
                        Template_Create_Share_Template_Off = pair.Value;
                    else if (pair.Key == "Template_Create_Cancel_Button")
                        Template_Create_Cancel_Button = pair.Value;
                    else if (pair.Key == "Template_Create_Prev_Button")
                        Template_Create_Prev_Button = pair.Value;
                    else if (pair.Key == "Template_Create_Name_Error")
                        Template_Create_Name_Error = pair.Value;
                    else if (pair.Key == "Template_Grid_Cards_Tooltip")
                        Template_Grid_Cards_Tooltip = pair.Value;
                    else if (pair.Key == "Template_Create_Confirm_grid3x3_Card")
                        Template_Create_Confirm_grid3x3_Card = pair.Value;

                    else if (pair.Key == "Template_Grid_Header_Name")
                        Template_Grid_Header_Name = pair.Value;
                    else if (pair.Key == "Template_Grid_Header_Tags")
                        Template_Grid_Header_Tags = pair.Value;
                    else if (pair.Key == "Template_Grid_Header_Status")
                        Template_Grid_Header_Status = pair.Value;
                    else if (pair.Key == "Template_Grid_Header_Camapigns")
                        Template_Grid_Header_Camapigns = pair.Value;
                    else if (pair.Key == "Template_Grid_Header_Updated_By")
                        Template_Grid_Header_Updated_By = pair.Value;
                    else if (pair.Key == "Template_Grid_Header_Updated_On")
                        Template_Grid_Header_Updated_On = pair.Value;
                    else if (pair.Key == "Click_TemplatePage_Ellipses")
                        Click_TemplatePage_Ellipses = pair.Value;
                    else if (pair.Key == "Click_TemplatePage_Ellipses_ViewDetails")
                        Click_TemplatePage_Ellipses_ViewDetails = pair.Value;
                    else if (pair.Key == "Click_TemplatePage_Ellipses_ViewDetails_SummaryTab")
                        Click_TemplatePage_Ellipses_ViewDetails_SummaryTab = pair.Value;
                    else if (pair.Key == "Click_TemplatePage_SummaryTab")
                        Click_TemplatePage_SummaryTab = pair.Value;
                    else if (pair.Key == "Click_ListView_FirstTemplate")
                        Click_ListView_FirstTemplate = pair.Value;
                    else if (pair.Key == "Template_Create_Template_View_In_Browser_Link")
                        Template_Create_Template_View_In_Browser_Link = pair.Value;
                    else if (pair.Key == "Template_Create_Template_Unsubsribe_Link")
                        Template_Create_Template_Unsubsribe_Link = pair.Value;
                    else if (pair.Key == "Template_Create_Template_Design_Elements")
                        Template_Create_Template_Design_Elements = pair.Value;
                    else if (pair.Key == "Create_Template_Name_red")
                        Create_Template_Name_red = pair.Value;
                    else if (pair.Key == "Create_Template_DesignPage_SelectElement")
                        Create_Template_DesignPage_SelectElement = pair.Value;
                    else if (pair.Key == "Create_Template_DesignPage_body")
                        Create_Template_DesignPage_body = pair.Value;
                    else if (pair.Key == "iframe_Create_Template_DesignPage_body")
                        iframe_Create_Template_DesignPage_body = pair.Value;
                    
                }
                #endregion[CreateTemplate]

                #region[ManageCampaign]
                if (nodeModule == Constants.ManageCampaign)
                {
                    if (pair.Key == "Card_View")
                        Card_View = pair.Value;
                    else if (pair.Key == "List_View")
                        List_View = pair.Value;
                    else if (pair.Key == "Marketing_Toggle_Button")
                        Marketing_Toggle_Button = pair.Value;
                    else if (pair.Key == "Automated_Toggle_Button")
                        Automated_Toggle_Button = pair.Value;
                    else if (pair.Key == "Hover_ListView_CampaignName")
                        Hover_ListView_CampaignName = pair.Value;
                    else if (pair.Key == "Hover_ListView_CampaignAudience")
                        Hover_ListView_CampaignAudience = pair.Value;
                    else if (pair.Key == "Campaign_ID")
                        Campaign_ID = pair.Value;
                    else if (pair.Key == "ManageCapaign_Audience_Name")
                        ManageCapaign_Audience_Name = pair.Value;
                    else if (pair.Key == "ManageCapaign_Update_By")
                        ManageCapaign_Update_By = pair.Value;
                    else if (pair.Key == "ManageCapaign_Updated_ON")
                        ManageCapaign_Updated_ON = pair.Value;
                    else if (pair.Key == "ManageCapaign_Status")
                        ManageCapaign_Status = pair.Value;
                    else if (pair.Key == "Click_Approved_from_listGrid")
                        Click_Approved_from_listGrid = pair.Value;
                    else if (pair.Key == "Campaign_Cards")
                        Campaign_Cards = pair.Value;
                    else if (pair.Key == "Click_ToVerifyLogout")
                        Click_ToVerifyLogout = pair.Value;
                    else if (pair.Key == "VerifyLoggedinDashboard")
                        VerifyLoggedinDashboard = pair.Value;
                    else if (pair.Key == "Click_ManageCampaign_Ellipse")
                        Click_ManageCampaign_Ellipse = pair.Value;
                    else if (pair.Key == "Click_ManageCampaign_Ellipse_Edit")
                        Click_ManageCampaign_Ellipse_Edit = pair.Value;
                    else if (pair.Key == "Click_ManageCampaign_Ellipse_ViewDetails")
                        Click_ManageCampaign_Ellipse_ViewDetails = pair.Value;
                    else if (pair.Key == "Click_ManageCampaign_Ellipse_ViewDetails_Subject")
                        Click_ManageCampaign_Ellipse_ViewDetails_Subject = pair.Value;
                    else if (pair.Key == "CardView_Campaign_ID")
                        CardView_Campaign_ID = pair.Value;
                    else if (pair.Key == "CardView_Campaign_Status")
                        CardView_Campaign_Status = pair.Value;
                    else if (pair.Key == "Manage_Campaign_Cards_Title")
                        Manage_Campaign_Cards_Title = pair.Value;
                    else if (pair.Key == "Manage_Campaign_Cards_Audience_Name")
                        Manage_Campaign_Cards_Audience_Name = pair.Value;
                    else if (pair.Key == "Manage_Campaign_Cards_Subtitle_Name")
                        Manage_Campaign_Cards_Subtitle_Name = pair.Value;
                    else if (pair.Key == "Manage_Campaign_Cards_Status")
                        Manage_Campaign_Cards_Status = pair.Value;
                    else if (pair.Key == "Manage_Campaign_Cards_Avatar")
                        Manage_Campaign_Cards_Avatar = pair.Value;
                    else if (pair.Key == "Manage_Campaign_Cards_Update_Date")
                        Manage_Campaign_Cards_Update_Date = pair.Value;
                    else if (pair.Key == "Manage_Campaign_Filter_DropDown_FilterOptions")
                        Manage_Campaign_Filter_DropDown_FilterOptions = pair.Value;
                    else if (pair.Key == "Manage_Campaign_Filter_Status_DropDown_Arrow")
                        Manage_Campaign_Filter_Status_DropDown_Arrow = pair.Value;
                    else if (pair.Key == "Manage_Campaign_Filter_Status_DropDown_Input")
                        Manage_Campaign_Filter_Status_DropDown_Input = pair.Value;
                    else if (pair.Key == "Manage_Campaign_Filter_Status_DropDown_Options")
                        Manage_Campaign_Filter_Status_DropDown_Options = pair.Value;
                    else if (pair.Key == "Manage_Campaign_Filter_UpdatedOn_Input")
                        Manage_Campaign_Filter_UpdatedOn_Input = pair.Value;
                    else if (pair.Key == "Manage_Campaign_Filter_ID_Text")
                        Manage_Campaign_Filter_ID_Text = pair.Value;
                    else if (pair.Key == "Manage_Campaign_Sort_Button")
                        Manage_Campaign_Sort_Button = pair.Value;
                    else if (pair.Key == "Manage_Campaign_Sort_Clear")
                        Manage_Campaign_Sort_Clear = pair.Value;
                    else if (pair.Key == "Manage_Campaign_Sort_Apply")
                        Manage_Campaign_Sort_Apply = pair.Value;
                    else if (pair.Key == "Manage_Campaign_Sort_DropDown_Arrows")
                        Manage_Campaign_Sort_DropDown_Arrows = pair.Value;
                    else if (pair.Key == "Manage_Campaign_List_View_Loader")
                        Manage_Campaign_List_View_Loader = pair.Value;

                    else if (pair.Key == "Click_ManageCampaign_cardView_StatusArrow")
                        Click_ManageCampaign_cardView_StatusArrow = pair.Value;
                    else if (pair.Key == "Check_ManageCampaign_cardView_Status_RequestApprove_button")
                        Check_ManageCampaign_cardView_Status_RequestApprove_button = pair.Value;
                    else if (pair.Key == "Check_ManageCampaign_cardView_Status_SelfApprove_button")
                        Check_ManageCampaign_cardView_Status_SelfApprove_button = pair.Value;
                    else if (pair.Key == "Check_ManageCampaign_cardView_Status_Schedule_button")
                        Check_ManageCampaign_cardView_Status_Schedule_button = pair.Value;

                    else if (pair.Key == "Scheduled_Active_Edit_Button")
                        Scheduled_Active_Edit_Button = pair.Value;
                    else if (pair.Key == "Scheduled_Active_Deactivate_Button")
                        Scheduled_Active_Deactivate_Button = pair.Value;
                    else if (pair.Key == "Scheduled_InActive_Activate_Button")
                        Scheduled_InActive_Activate_Button = pair.Value;
                    else if (pair.Key == "Click_ManageCampaign_ListView_StatusArrow")
                        Click_ManageCampaign_ListView_StatusArrow = pair.Value;
                    else if (pair.Key == "Approved_Campaign_details_Approvedby_Field")
                        Approved_Campaign_details_Approvedby_Field = pair.Value;
                    else if (pair.Key == "Approved_Campaign_details_ApprovedOn_Field")
                        Approved_Campaign_details_ApprovedOn_Field = pair.Value;
                    else if (pair.Key == "ListView_Campaign_Status")
                        ListView_Campaign_Status = pair.Value;
                    else if (pair.Key == "Approved_Campaign_details_ApprovedOn_Field_Value")
                        Approved_Campaign_details_ApprovedOn_Field_Value = pair.Value;
                    else if (pair.Key == "Approved_Campaign_details_Approvedby_Field_Value")
                        Approved_Campaign_details_Approvedby_Field_Value = pair.Value;
                    else if (pair.Key == "Click_On_Code_Editor")
                        Click_On_Code_Editor = pair.Value;
                    else if (pair.Key == "Enter_HTML_Code")
                        Enter_HTML_Code = pair.Value;
                    else if (pair.Key == "Click_CSS")
                        Click_CSS = pair.Value;
                    else if (pair.Key == "Enter_CSS_Code")
                        Enter_CSS_Code = pair.Value;
                    else if (pair.Key == "Click_On_Code_Editor_Save_Button")
                        Click_On_Code_Editor_Save_Button = pair.Value;
                    else if (pair.Key == "View_Campaign_Summary_Tab")
                        View_Campaign_Summary_Tab = pair.Value;
                    else if (pair.Key == "View_Campaign_Summary_General_Text")
                        View_Campaign_Summary_General_Text = pair.Value;
                    else if (pair.Key == "View_Campaign_Design_Tab")
                        View_Campaign_Design_Tab = pair.Value;
                    else if (pair.Key == "View_Campaign_Design_General_Text")
                        View_Campaign_Design_General_Text = pair.Value;
                    else if (pair.Key == "View_Campaign_Audience_Tab")
                        View_Campaign_Audience_Tab = pair.Value;
                    else if (pair.Key == "View_Campaign_Audience_Criteria_Text")
                        View_Campaign_Audience_Criteria_Text = pair.Value;


                }
                #endregion[ManageCampaign]

                #region[CreateAudience]
                if (nodeModule == Constants.CreateAudience)
                {
                    if (pair.Key == "Audience_Breadcrumb")
                        Audience_Breadcrumb = pair.Value;
                    else if (pair.Key == "Audience_Create_Button")
                        Audience_Create_Button = pair.Value;
                    else if (pair.Key == "Audience_Cards")
                        Audience_Cards = pair.Value;
                    else if (pair.Key == "Click_Audience_Name")
                        Click_Audience_Name = pair.Value;
                    else if (pair.Key == "Verify_CriteriaTab_AudiencePage")
                        Verify_CriteriaTab_AudiencePage = pair.Value;
                    else if (pair.Key == "Get_Audience_Name")
                        Get_Audience_Name = pair.Value;
                    else if (pair.Key == "Get_Audience_Status")
                        Get_Audience_Status = pair.Value;
                    else if (pair.Key == "Get_Audience_Tag")
                        Get_Audience_Tag = pair.Value;
                    else if (pair.Key == "Get_Audience_UpdatedDate")
                        Get_Audience_UpdatedDate = pair.Value;
                    else if (pair.Key == "Click_ManageAudience_CampaignTab")
                        Click_ManageAudience_CampaignTab = pair.Value;
                    else if (pair.Key == "Audience_Details_Campaign_Tab")
                        Audience_Details_Campaign_Tab = pair.Value;
                    else if (pair.Key == "AudienceOrSegmentButton")
                        AudienceOrSegmentButton = pair.Value;
                    else if (pair.Key == "HeaderTitle")
                        HeaderTitle = pair.Value;
                    else if (pair.Key == "Create_Button")
                        Create_Button = pair.Value;
                    else if (pair.Key == "Create_Audience_Button")
                        Create_Audience_Button = pair.Value;
                    else if (pair.Key == "Create_Segment_Button")
                        Create_Segment_Button = pair.Value;
                    else if (pair.Key == "Create_Audience_Name")
                        Create_Audience_Name = pair.Value;
                    else if (pair.Key == "Create_Audience_Tag_input")
                        Create_Audience_Tag_input = pair.Value;
                    else if (pair.Key == "Create_Audience_Tag_List")
                        Create_Audience_Tag_List = pair.Value;
                    else if (pair.Key == "Create_Audience_Description")
                        Create_Audience_Description = pair.Value;
                    else if (pair.Key == "Audience_Cards_Title")
                        Audience_Cards_Title = pair.Value;
                    else if (pair.Key == "Create_Segment_Name")
                        Create_Segment_Name = pair.Value;
                    else if (pair.Key == "Create_Segment_Tag_input")
                        Create_Segment_Tag_input = pair.Value;
                    else if (pair.Key == "Create_Segment_Tag_List")
                        Create_Segment_Tag_List = pair.Value;
                    else if (pair.Key == "Create_Segment_Description")
                        Create_Segment_Description = pair.Value;
                    else if (pair.Key == "Create_Segment_Domain_Arrow")
                        Create_Segment_Domain_Arrow = pair.Value;
                    else if (pair.Key == "Create_Segment_DomainOrField_List")
                        Create_Segment_DomainOrField_List = pair.Value;
                    else if (pair.Key == "Create_Segment_AddRow")
                        Create_Segment_AddRow = pair.Value;
                    else if (pair.Key == "Create_Segment_Save")
                        Create_Segment_Save = pair.Value;
                    else if (pair.Key == "Create_Segment_Field_Arrow")
                        Create_Segment_Field_Arrow = pair.Value;
                    else if (pair.Key == "Create_Segment_Operation_Arrow")
                        Create_Segment_Operation_Arrow = pair.Value;
                    else if (pair.Key == "Create_Segment_Finish")
                        Create_Segment_Finish = pair.Value;
                    else if (pair.Key == "Segment_Cards_Title")
                        Segment_Cards_Title = pair.Value;
                    else if (pair.Key == "Audience_Cards_Status")
                        Audience_Cards_Status = pair.Value;
                    else if (pair.Key == "Segment_Cards")
                        Segment_Cards = pair.Value;
                    else if (pair.Key == "Create_Segment_CriteriaValue")
                        Create_Segment_CriteriaValue = pair.Value;
                    else if (pair.Key == "Segment_Creation_MSG")
                        Segment_Creation_MSG = pair.Value;
                    else if (pair.Key == "Segment_Cards_Status")
                        Segment_Cards_Status = pair.Value;
                    else if (pair.Key == "Audience_Summary_Tabs")
                        Audience_Summary_Tabs = pair.Value;
                    
                }
                #endregion[CreateAudience]

                #region[ManageTemplate]
                if (nodeModule == Constants.ManageTemplate)
                {
                    if (pair.Key == "Manage_Template_Column_Filter_Options_Arrow")
                        Manage_Template_Column_Filter_Options_Arrow = pair.Value;
                    else if (pair.Key == "Manage_Template_Filter_Options_List")
                        Manage_Template_Filter_Options_List = pair.Value;
                    else if (pair.Key == "Manage_Template_Filter_Input")
                        Manage_Template_Filter_Input = pair.Value;
                    else if (pair.Key == "Manage_Template_Filter_Text")
                        Manage_Template_Filter_Text = pair.Value;
                    else if (pair.Key == "Manage_Template_Clear_Filters_No_Result")
                        Manage_Template_Clear_Filters_No_Result = pair.Value;
                    else if (pair.Key == "Manage_Template_List_View_Details")
                        Manage_Template_List_View_Details = pair.Value;
                    else if (pair.Key == "Manage_Template_Filter_Input_Dates")
                        Manage_Template_Filter_Input_Dates = pair.Value;
                }
                #endregion[ManageTemplate]

                #region[Email]
                if (nodeModule == Constants.Email)
                {
                    if (pair.Key == "Outlook_Email_Heading")
                        Outlook_Email_Heading = pair.Value;
                    else if (pair.Key == "Outlook_Yahoo_Email_Body")
                        Outlook_Yahoo_Email_Body = pair.Value;
                    else if (pair.Key == "Yahoo_Email_Username")
                        Yahoo_Email_Username = pair.Value;
                    else if (pair.Key == "Yahoo_Email_Next")
                        Yahoo_Email_Next = pair.Value;
                    else if (pair.Key == "Yahoo_Email_Password")
                        Yahoo_Email_Password = pair.Value;
                    else if (pair.Key == "Yahoo_Email_Submit")
                        Yahoo_Email_Submit = pair.Value;
                    else if (pair.Key == "Yahoo_Email_Search_Input")
                        Yahoo_Email_Search_Input = pair.Value;
                    else if (pair.Key == "Yahoo_Email_Searched_Result_Li")
                        Yahoo_Email_Searched_Result_Li = pair.Value;
                    else if (pair.Key == "Outlook_Email_No_Result")
                        Outlook_Email_No_Result = pair.Value;
                    else if (pair.Key == "Yahoo_Email_Sign_In_Link")
                        Yahoo_Email_Sign_In_Link = pair.Value;
                }
                #endregion[Email]


            }
            return obj;
        }
    }
}
