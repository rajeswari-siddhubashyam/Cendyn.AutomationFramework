using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RevIntel.Utility
{
    class ObjectRepository
    {
        #region[Login]
        public static string Enter_EmailAddress { get; set; }
        public static string Enter_Password { get; set; }
        public static string Click_SignIn_Button { get; set; }
        public static string Select_DropDown { get; set; }
        public static string LogOut_Button { get; set; }
        public static string Click_Next_Button { get; set; }
        
        #endregion[Login]


        #region[Navigation]
        public static string Click_UAT { get; set; }
        public static string Click_Automation { get; set; }
        public static string Click_TA { get; set; }
        public static string Click_change_password { get; set; }
        public static string Change_password_Cancel_button { get; set; }
        public static string Enter_Current_Password { get; set; }
        public static string Enter_New_Password { get; set; }
        public static string Enter_Confirm_Password { get; set; }
        public static string Click_Change_Password_button { get; set; }
        public static string incorrect_current_password_validation { get; set; }
        public static string Kerzner { get; set; }
        public static string Tenant_21C { get; set; }
        public static string D_Rock { get; set; }
        public static string Hotel { get; set; }
        public static string Benchmark_Hospitality { get; set; }
        public static string Ocean_House { get; set; }
        public static string Portal { get; set; }
        public static string BusinessSource { get; set; }
        public static string AgentAnalysis { get; set; }
        public static string Market { get; set; }
        public static string Booking_Trends { get; set; }
        public static string Channel { get; set; }
        public static string Forecast_and_Budget { get; set; }
        public static string Adhoc { get; set; }
        public static string Geo_Source { get; set; }
        public static string Portfolio { get; set; }
        public static string Portfolio_Report { get; set; }
        public static string Click_Hamburger_Icon { get; set; }
        public static string user_preferences { get; set; }
        public static string user_preferences_Hotel { get; set; }
        public static string user_preferences_Hotel_select { get; set; }
        public static string user_preferences_Currency { get; set; }
        public static string user_preferences_Currency_Select { get; set; }
        public static string user_preferences_Save { get; set; }
        public static string user_Maintenance_Close { get; set; }
        public static string Iframe_user_preferences { get; set; }
        public static string user_preferences_Close { get; set; }
        public static string Help_Menu { get; set; }
        public static string Training { get; set; }
        public static string Release_note { get; set; }
        public static string user_preferences_Currency_Default { get; set; }
        public static string user_preferences_Hotel_Default { get; set; }
        public static string Administration { get; set; }
        public static string User_Maintenance { get; set; }
        public static string Add_New_User { get; set; }
        public static string Iframe_user_Maintenance { get; set; }
        public static string user_Maintenance_Save { get; set; }
        public static string user_Id { get; set; }
        public static string Add_User_Email { get; set; }
        public static string Add_User_FirstName { get; set; }
        public static string Add_User_LastName { get; set; }
        public static string Select_Available_Hotels { get; set; }
        public static string Iframe_Add_User { get; set; }
        public static string Corporate_Portfolio { get; set; }
        public static string Add_New_Portfolio { get; set; }
        public static string iframe_New_Portfolio { get; set; }
        public static string Portfolio_name { get; set; }
        public static string Pace_Forecast_Report { get; set; }
        public static string iFrame_Pace_Forecast_Report { get; set; }
        public static string Agent_Summary { get; set; }
        public static string Parent_Company_Analysis { get; set; }
        public static string Parent_Travel_Agent_Analysis { get; set; }
        public static string Company_Period_Summary { get; set; }
        public static string Agent_Period_Summary { get; set; }
        public static string Agent_Trend_Report { get; set; }
        public static string Company_Trend_Report { get; set; }
        public static string Agent_By_Hotel { get; set; }
        public static string Channel_By_Hotel { get; set; }
        public static string Company_By_Hotel { get; set; }
        public static string Market_By_Hotel_Report { get; set; }
        public static string Province_and_State_By_Hotel { get; set; }
        public static string Room_Type_By_Hotel { get; set; }
        public static string Source_Market_By_Hotel { get; set; }
        public static string Pace_Report { get; set; }
        public static string Pace_Trend { get; set; }
        public static string Daily_Pace_and_Pickup_Analysis { get; set; }
        public static string Pace_and_Pickup_Analysis { get; set; }
        public static string Rate_Code_Pace_Report { get; set; }
        public static string Channel_By_Room_Type_Pace { get; set; }
        public static string Channel_Pace_Analysis { get; set; }
        public static string Pickup_By_Day { get; set; }
        public static string Room_Type { get; set; }
        public static string Room_Rate { get; set; }
        public static string Rainmaker { get; set; }
        public static string Annual_Pickup_by_Day { get; set; }
        public static string Length_of_Stay_Report { get; set; }
        public static string Rooms_Lead_Time { get; set; }
        public static string Pickup_By_Day_Detailed { get; set; }
        public static string Monthly_Pickup { get; set; }
        public static string Production_Patterns { get; set; }
        public static string High_Occupancy_Night_By_Day { get; set; }
        public static string Sold_Out_Night_Analysis { get; set; }
        public static string Cancellation_Report { get; set; }
        public static string Hotel_Event_Calendar { get; set; }
        public static string Market_Report { get; set; }
        public static string Channel_Report { get; set; }
        public static string Pace_and_Forecast_Report { get; set; }
        public static string Stay_Graph { get; set; }
        public static string Source_Market_Trend { get; set; }
        public static string Room_Type_Analysis { get; set; }
        public static string Time_Period { get; set; }
        public static string Day_of_Week_Statistics { get; set; }
        public static string Total_Revenue_Analysis { get; set; }
        public static string Custom { get; set; }
        public static string OTB_Comparison_for_All_Segments { get; set; }
        public static string Role_Maintenance { get; set; }
        public static string Click_RS { get; set; }
        public static string Click_Help_Icon { get; set; }
        public static string Enter_Help_Text { get; set; }
        public static string Click_Contact_us_Icon { get; set; }
        public static string Click_Portal_Update_Button { get; set; }
        public static string Click_Link_Portal { get; set; }
        public static string Click_Link_Hotel_Dashboard { get; set; }
        public static string Hotel_Dashboard_iFrame { get; set; }
        public static string Click_Help_Icon_Minimize { get; set; }
        public static string Click_Help_ContactUs { get; set; }
        public static string Enter_Contact_Name { get; set; }
        public static string Enter_Contact_Email { get; set; }
        public static string Enter_Contact_Subject { get; set; }
        public static string Enter_Contact_Property { get; set; }
        public static string Enter_Contact_Description { get; set; }
        public static string Click_Contact_Send { get; set; }
        //******************Change************* 
        public static string Click_SubmitRequest { get; set; }
        public static string Click_Contact_Support_Dropdown { get; set; }
        public static string Click_Contact_Support_Services { get; set; }
        public static string Click_Contact_Support_Sub_Services { get; set; }
        public static string Market_Performance { get; set; }
        public static string Market_Trend_Report { get; set; }
        public static string Market_Segment_by_Day { get; set; }
        public static string Market_Segment_by_Day_Summary { get; set; }
        public static string Annual_Market_Analysis_by_Month { get; set; }
        public static string Rate_Code_Analysis { get; set; }
        public static string Market_Analysis_by_Year { get; set; }
        public static string Monthly_Market_Segment_Report { get; set; }
        public static string Rate_Code_Trend_Report { get; set; }
        public static string Click_Forecast_Budget_Upload_Report { get; set; }
        public static string Click_Source_Market_Analysis_Report { get; set; }
        public static string Click_Source_Market_Trend_Report { get; set; }
        public static string Click_United_States_Trend_Report { get; set; }
        public static string Click_Province_and_State_Analysis_Report { get; set; }
        public static string Click_Room_Type_Analysis_Report { get; set; }
        public static string Click_Room_Type_and_Up_Grade_Statistics_Report { get; set; }
        public static string Click_Booked_Room_Materialization_Report { get; set; }
        public static string Click_Detailed_Room_Type_Availability_Report { get; set; }
        public static string Click_UserMenu { get; set; }
        public static string Click_UserMenu_ReportScheduler { get; set; }
        public static string Click_UserMenu_ManageReportSchedules { get; set; }
        public static string Click_RainMaker_MoreButton { get; set; }
        public static string Click_RainMaker { get; set; }
        public static string Click_SubscriptionSupport { get; set; }
        public static string Click_Time_Period_Menu { get; set; }
        public static string Click_Annual_Trends_Report { get; set; }
        public static string Click_Daily_Analysis_Report { get; set; }
        public static string Click_Day_of_Week_Statistics_Report { get; set; }
        public static string Click_Monthly_Summary_Report { get; set; }
        public static string Click_Day_of_Week_Analysis_Report { get; set; }
        public static string Click_Daily_Analysis_PerPerson_Report { get; set; }
        public static string Click_OTB_Comparison_by_Segment_Reports { get; set; }
        public static string Click_Custom_Menu { get; set; }
        public static string Click_Daily_Pick_Up_Report { get; set; }
        public static string Click_Revenue_By_Room_Product_Report { get; set; }
        public static string Click_Pickup_by_Market_Segment_Report { get; set; }
        public static string Click_OTB_Comparison_for_All_Segments_Report { get; set; }
        public static string Click_OTB_vs_Budget_by_Segment_Report { get; set; }
        public static string Click_OTB_vs_Forecast_by_Segment_Report { get; set; }
        public static string Click_Room_Type_Booked_vs_Occupied { get; set; }
        public static string Click_Access_Log { get; set; }
        public static string Click_Parent_Company { get; set; }
        public static string Click_User_Access_Report { get; set; }
        public static string Click_Room_Rate_Menu { get; set; }
        public static string Best_Available_Rate_Contribution_Report { get; set; }
        public static string Click_Total_Revenue_Analysis_Report { get; set; }
        public static string Filament { get; set; }
        public static string Click_Hotel_Dashboard { get; set; }
        public static string Click_Agent_Dashboard { get; set; }
        public static string Click_Company_Dashboard { get; set; }
        public static string Click_Market_Dashboard { get; set; }
        public static string Click_Channel_Dashboard { get; set; }
        public static string Click_Room_Type_Dashboard { get; set; }
        public static string Click_Negotiated_Dashboard { get; set; }
        public static string Click_Pace_Dashboard { get; set; }
        public static string Click_Channel_Trend_Report { get; set; }
        public static string Click_Daily_Channel_by_Room_Type { get; set; }
        public static string user_preferences_BusinessUnit { get; set; }
        public static string Click_Stay_Graph_Report { get; set; }
        public static string Click_Menu_Market { get; set; }
        public static string Click_User_Preference_Portfolio_Toggle_button { get; set; }
        public static string Click_change_tenant { get; set; }
        public static string Click_Business_Unit_Grouping { get; set; }
        public static string Click_Add_New_Business_Unit_Group { get; set; }

        public static string Click_Channel_Mapping { get; set; }
        public static string Click_Room_Type_Mapping { get; set; }
        public static string Click_Market_Mapping { get; set; }

        #endregion[Navigation]


        #region[ReportParameter]
        public static string Select_Hotel { get; set; }
        public static string Select_Hotel_DDL { get; set; }
        public static string Select_Hotel_value { get; set; }
        public static string Portfolio_RadioButton { get; set; }
        public static string HotelorPortfolio_DDL { get; set; }
        public static string HotelorPortfolio_Dropdown_Arrow { get; set; }
        public static string HotelorPortfolio_ListValue { get; set; }
        public static string StartDate_Text { get; set; }
        public static string EndDate_Text { get; set; }
        public static string ViewAnalysis_Button { get; set; }
        public static string Save_Button { get; set; }
        public static string ReportHeading_Label { get; set; }
        public static string Click_View_Analysis { get; set; }
        public static string IFrame_Agent_Analysis { get; set; }
        public static string Export_Menu { get; set; }
        public static string Excel { get; set; }
        public static string Word { get; set; }
        public static string TIFF { get; set; }
        public static string PDF { get; set; }
        public static string PowerPoint { get; set; }
        public static string MHTML { get; set; }
        public static string CSV { get; set; }
        public static string XML { get; set; }
        public static string Data_Feed { get; set; }
        public static string Parameter_market { get; set; }
        public static string Parameter_market_Direct { get; set; }
        public static string Select_Dropdown_Hotel { get; set; }
        public static string Parameter_Channel { get; set; }
        public static string Parameter_channel_Hotel_Direct { get; set; }
        public static string Parent_Travel_Agent_Analysis_Close { get; set; }
        public static string Parameter_Agent { get; set; }
        public static string Parameter_Agent_Enter { get; set; }
        public static string Parameter_Agent_value { get; set; }
        public static string iframe_Parent_Travel_Agent_Analysis { get; set; }
        public static string iframe_Company_Period_Summary { get; set; }
        public static string Company_Period_Summary_Close { get; set; }
        public static string Agent_Period_Summary_Close { get; set; }
        public static string iframe_Agent_Period_Summary { get; set; }
        public static string iframe_Agent_Trend_Report { get; set; }
        public static string Agent_Trend_Report_Close { get; set; }
        public static string Compare_Start_Date { get; set; }
        public static string Compare_End_Date { get; set; }
        public static string iframe_Company_Trend_Report { get; set; }
        public static string iframe_Portfolio { get; set; }
        public static string Portfolio_DDL { get; set; }
        public static string Portfolio_DDL_value { get; set; }
        public static string iframe_Agent_By_Hotel { get; set; }
        public static string Memberships_value_MemberOnly { get; set; }
        public static string iframe_channel_By_Hotel { get; set; }
        public static string Portfolio_Selection_DDL { get; set; }
        public static string iframe_company_By_Hotel { get; set; }
        public static string Parameter_market_Corporate { get; set; }
        public static string iframe_Market_By_Hotel_Report { get; set; }
        public static string Select_SourceMarket_DDL { get; set; }
        public static string Select_SourceMarket_value { get; set; }
        public static string Select_RoomProduct_DDL { get; set; }
        public static string Select_RoomProduct_value { get; set; }
        public static string iframe_Province_and_State_By_Hotel { get; set; }
        public static string iframe_Room_Type_By_Hotel { get; set; }
        public static string iframe_Source_Market_By_Hotel { get; set; }
        public static string Click_expand_sign { get; set; }
        public static string Click_collapse_sign { get; set; }
        public static string Click_Source_Market_By_Hotel_expand_sign { get; set; }
        public static string Click_Source_Market_By_Hotel_collapse_sign { get; set; }
        public static string iframe_Pace_report { get; set; }
        public static string Enter_As_Of_Date { get; set; }
        public static string Select_Portfolio_value { get; set; }
        public static string iframe_Pace_Trend { get; set; }
        public static string Enter_Pace_Trend_Start_Month { get; set; }
        public static string iframe_Daily_Pace_and_Pickup_Analysis { get; set; }
        public static string iframe_Pace_and_Pickup_Analysis { get; set; }
        public static string Parameter_Rate_code_DDL { get; set; }
        public static string Parmeter_Rate_code_value { get; set; }
        public static string iframe_Rate_Code_Pace_Report { get; set; }
        public static string iframe_Channel_By_Room_Type_Pace { get; set; }
        public static string iframe_Channel_Pace_Analysis { get; set; }
        public static string iframe_Pickup_By_Day { get; set; }
        public static string Pickup_startDate { get; set; }
        public static string Pickup_enddate { get; set; }
        public static string PaceReport_Expand { get; set; }
        public static string PaceReport_Collapse { get; set; }
        public static string Monthly_PickupStart { get; set; }
        public static string Monthly_PickupEnd { get; set; }
        public static string Monthly_Start { get; set; }
        public static string Monthly_End { get; set; }
        public static string iframe_Annual_Pickup_by_Day { get; set; }
        public static string iframe_Lenght_of_stay_Report { get; set; }
        public static string iframe_Rooms_Lead_Time { get; set; }
        public static string iframe_Pickup_By_Day_Detailed { get; set; }
        public static string iframe_Production_Patterns { get; set; }
        public static string iframe_High_Occupancy_Night_By_Day { get; set; }
        public static string iframe_Sold_Out_Night_Analysis { get; set; }
        public static string iframe_Cancellation_Report { get; set; }
        public static string Monthly_Pickup_Excel { get; set; }
        public static string Market_Report_Expand_Level { get; set; }
        public static string iframe_Market_Report { get; set; }
        public static string iframe_Market_Performance { get; set; }
        public static string iframe_Market_Trend_Report { get; set; }
        public static string iframe_Market_Segment_by_Day { get; set; }
        public static string iframe_Market_Segment_by_Day_Summary { get; set; }
        public static string iframe_Annual_Market_Analysis_by_Month { get; set; }
        public static string iframe_Rate_Code_Analysis { get; set; }
        public static string iframe_Market_Analysis_by_Year { get; set; }
        public static string iframe_Monthly_Market_Segment_Report { get; set; }
        public static string iframe_Rate_Code_Trend_Report { get; set; }
        public static string iframe_Pace_and_Forecast_Report { get; set; }
        public static string iframe_Source_Market_Analysis_Report { get; set; }
        public static string iframe_Source_Market_Trend_Report { get; set; }
        public static string iframe_Province_and_State_Analysis_Report { get; set; }
        public static string iframe_United_States_Trend_Report { get; set; }
        public static string iframe_Room_Type_Analysis_Report { get; set; }
        public static string iframe_Room_Type_and_Up_Grade_Statistics_Report { get; set; }
        public static string iframe_Booked_Room_Materialization_Report { get; set; }
        public static string iframe_Detailed_Room_Type_Availability_Report { get; set; }
        public static string iframe_Annual_Trends_Report { get; set; }
        public static string iframe_Daily_Analysis_Report { get; set; }
        public static string iframe_Monthly_Summary_Report { get; set; }
        public static string Click_Currency_Dropdown { get; set; }
        public static string Select_Currency_Value { get; set; }
        public static string Click_Business_Unit_Dropdown { get; set; }
        public static string Select_Business_Unit_Value { get; set; }
        public static string iframe_Day_of_Week_Statistics_Report { get; set; }
        public static string iframe_Day_of_Week_Analysis_Report { get; set; }
        public static string iframe_Daily_Analysis_PerPerson_Report { get; set; }
        public static string iframe_OTB_Comparison_by_Segment_Report { get; set; }
        public static string iframe_Daily_Pick_Up_Report { get; set; }
        public static string iframe_Revenue_By_Room_Product_Report { get; set; }
        public static string iframe_Pickup_by_Market_Segment_Report { get; set; }
        public static string iframe_OTB_Comparison_for_All_Segments_Report { get; set; }
        public static string iframe_OTB_vs_Budget_by_Segment_Report { get; set; }
        public static string iframe_OTB_vs_Forecast_by_Segment_Report { get; set; }
        public static string iframe_Room_Type_Booked_vs_Occupied { get; set; }
        public static string iframe_Access_Log { get; set; }
        public static string iframe_Parent_Company { get; set; }
        public static string Click_Add_New_Parent_Company { get; set; }
        public static string Click_Add_New_Parent_Company_Save_Button { get; set; }
        public static string Enter_Parent_Company_Name { get; set; }
        public static string Click_Parent_Company_Name_Edit_Link { get; set; }
        public static string Click_Add_New_Parent_Company_Close_Button { get; set; }
        public static string iframe_Add_Parent_Company_PopUp { get; set; }
        public static string iframe_User_Access_Report { get; set; }
        public static string iframe_Best_Available_Rate_Contribution_Report { get; set; }
        public static string iframe_Total_Revenue_Analysis_Report { get; set; }
        public static string iframe_User_Maintenance { get; set; }
        public static string Click_User_Maintenance_Edit_Link { get; set; }
        public static string Click_User_Role_Test_Role { get; set; }
        public static string Click_Role_Maintenance { get; set; }
        public static string Click_Role_Maintenance_Edit_Link_for_Test_Custom { get; set; }
        public static string Click_Role_Report_Tab { get; set; }
        public static string Click_Role_Tenants_Tab { get; set; }
        public static string iframe_Maintain_User { get; set; }
        public static string iframe_Role_Maintenance_PopUp { get; set; }
        public static string iframe_Role_Maintenance { get; set; }
        public static string iframe_Hotel_Dashboard { get; set; }
        public static string Dashboard_Hotel_RadioButton { get; set; }
        public static string Dashboard_Portfolio_RadioButton { get; set; }
        public static string Hotel_Dashboard_Summary { get; set; }
        public static string Hotel_Dashboard_Detail { get; set; }
        public static string Hotel_Dashboard_ADR_Radio_button { get; set; }
        public static string Hotel_Dashboard_Room_Revenue_Radio_button { get; set; }
        public static string Hotel_Dashboard_Room_Sold_button { get; set; }
        public static string iframe_Agent_Dashboard { get; set; }
        public static string Click_Dashboard_Update_Button { get; set; }
        public static string Enter_Dashboard_Pickup_Start { get; set; }
        public static string Enter_Dashboard_Pickup_End { get; set; }
        public static string Click_Dashboard_Excel_Icon { get; set; }
        public static string iframe_Monthly_Pickup { get; set; }
        public static string Click_Dashboard_Currency_DDL { get; set; }
        public static string Click_Dashboard_Hotel_OR_Portfolio_DDL { get; set; }
        public static string Click_Dashboard_Business_DDL { get; set; }
        public static string Dashboard_Enter_StartDate { get; set; }
        public static string Dashboard_Enter_EndDate { get; set; }
        public static string iframe_Company_Dashboard { get; set; }
        public static string CompanyDashboard_Enter_StartDate { get; set; }
        public static string CompanyDashboard_Enter_EndDate { get; set; }
        public static string Click_CompanyDashboard_Update_Button { get; set; }
        public static string iframe_Market_Dashboard { get; set; }
        public static string iframe_Channel_Dashboard { get; set; }
        public static string iframe_Room_Type_Dashboard { get; set; }
        public static string iframe_Negotiated_Dashboard { get; set; }
        public static string iframe_Pace_Dashboard { get; set; }
        public static string Pace_Dashboard_StartDate { get; set; }
        public static string Pace_Dashboard_EndDate { get; set; }
        public static string Pace_Dashboard_Update_Button { get; set; }
        public static string iframe_Channel_Report { get; set; }
        public static string iframe_Channel_Trend_Report { get; set; }
        public static string iframe_Daily_Channel_by_Room_Type_Report { get; set; }
        
        public static string UserPreference_GetHotel { get; set; }
        public static string UserPreference_GetBusinessUnit { get; set; }
        public static string UserPreference_GetCurrency { get; set; }

        public static string Monthly_Pickup_Hotel_Value { get; set; }
        public static string Monthly_Pickup_Currency_Value { get; set; }
        public static string Monthly_Pickup_Business_Unit_Value { get; set; }
        public static string Hotel_Portfolio_Dropdown { get; set; }
        public static string Business_Dropdown { get; set; }
        public static string Currency_Dropdown { get; set; }
        
        public static string iframe_Business_Unit_Grouping { get; set; }
        public static string Enter_Business_Unit_Grouping_Code { get; set; }
        public static string Enter_Business_Unit_Grouping_Name { get; set; }
        public static string Saved_Business_Unit_Grouping { get; set; }
        public static string Click_Business_Unit_Grouping_TransferAllFrom_Button { get; set; }
        public static string Click_Edit_Business_Unit_Grouping_button { get; set; }
        public static string Delete_Business_Unit_Grouping_button { get; set; }
        public static string iframe_Add_Business_Unit_Group { get; set; }
        
        public static string iframe_Room_Type_Mapping { get; set; }
        public static string Click_Room_Type_Code { get; set; }
        public static string Click_Room_Type_Name { get; set; }
        public static string Click_Rooms_Counted { get; set; }
        public static string Click_Rooms_Product { get; set; }
        public static string Click_Business_Unit { get; set; }

        public static string iframe_Market_Mapping { get; set; }
        public static string Click_PMS_Market_Code { get; set; }
        public static string Click_revintel_Market_1 { get; set; }
        public static string Click_revintel_Market_2 { get; set; }

        public static string iframe_Channel_Mapping { get; set; }
        public static string Click_PMS_Channel_Code { get; set; }
        public static string Click_revintel_Channel_1 { get; set; }
        public static string Click_revintel_Channel_2 { get; set; }

        public static string Rainmaker_Hotel_Dropdown { get; set; }
        public static string Rainmaker_Hotel_Value { get; set; }
        public static string Click_Business_Unit_Group_Sort { get; set; }

        public static string Maintenance_Edit_testaccess { get; set; }

        public static string Enter_Room_Type_Name { get; set; }
        public static string Click_Filter_Icon_Room_Type_Name { get; set; }
        public static string Filter_with_statsWith { get; set; }
        public static string Enter_Market_Name { get; set; }
        public static string Click_Filter_Icon_Market_Name { get; set; }
        public static string Enter_Channel_Name { get; set; }
        public static string Click_Filter_Icon_Channel_Name { get; set; }
        public static string Click_RoomTypeAnalysis_ComparisonYear_DDM { get; set; }
        public static string Select_RoomTypeAnalysis_ComparisonYear1 { get; set; }
        public static string Select_RoomTypeAnalysis_ComparisonYear2 { get; set; }
        public static string Select_RoomTypeAnalysis_ComparisonYear3 { get; set; }

        public static string Click_Compose_Menu { get; set; }
        public static string Click_Compose_new_report{ get; set; }
        public static string Click_Compose_Create_New_Report_Close_Icon { get; set; }
        public static string Click_Compose_Create_New_Report_Cancel_button { get; set; }
        public static string iframe_Compose { get; set; }
        public static string Click_Compose_FullscreenButton { get; set; }
        public static string Click_Compose_NewReport_Create_button { get; set; }
        public static string Compose_Users_Report { get; set; }
        public static string Compose_Users_Report_HeaderName { get; set; }
        public static string Compose_Users_Report_HeaderName_Edit { get; set; }
        public static string Compose_Users_Report_HeaderName_Edit_CancelButton { get; set; }
        public static string Compose_Users_Report_HeaderName_CloseButton { get; set; }
        public static string Compose_Enter_NewReport_Name { get; set; }
        public static string Compose_UserReport_Delete { get; set; }
        public static string Compose_UserReport_DeleteReport_Delete_Button { get; set; }
        public static string Compose_Rename_Button { get; set; }
        public static string Update_compose_report_Name { get; set; }

        public static string Enter_Start_Month { get; set; }
        
        #endregion[ReportParameter]

        #region BusinessSource

        public static string iframe_AgentSummary { get; set; }
        public static string Click_AgentRoomTypeAnalysis { get; set; }
        public static string iframe_Agent_Room_Type_Analysis { get; set; }
        public static string BookingStartDate { get; set; }
        public static string BookingEndDate { get; set; }
        public static string Click_Annual_Agent_Analysis_by_Month { get; set; }
        public static string iframe_Annual_Agent_Analysis_by_Month { get; set; }
        public static string Year_DDL { get; set; }
        public static string Year_value { get; set; }
        public static string Click_Company_Analysis { get; set; }
        public static string iframe_Company_Analysis { get; set; }
        public static string kerner_Portfolio { get; set; }
        public static string Click_Annual_Company_Analysis_by_Month { get; set; }
        public static string iframe_Annual_Company_Analysis_by_Month { get; set; }
        public static string Annual_Company_Analysis_by_Month_CompanyDDL { get; set; }
        public static string Annual_Company_Analysis_by_Month_Company_Select { get; set; }
        public static string Click_Company_Summary { get; set; }
        public static string iframe_Company_Summary { get; set; }
        public static string Company_Summary_Portfolio { get; set; }
        public static string iframe_Parent_Company_Analysis { get; set; }
        public static string Parent_Company_Analysis_Close { get; set; }
        public static string Paremeter_Memberships { get; set; }
        public static string Paremeter_Memberships_value { get; set; }

        #endregion BusinessSource

        #region ReportScheduler
        public static string Click_BookingTrends { get; set; }
        public static string Click_BookingTrends_ChannelPaceAnalysis { get; set; }
        public static string Click_BookingTrends_PickUpByDayDetailed { get; set; }
        public static string Enter_ChannelPaceAnalysis_RelativeStartDate { get; set; }
        public static string Enter_ChannelPaceAnalysis_RelativeEndDate { get; set; }
        public static string Enter_ChannelPaceAnalysis_StartDate { get; set; }
        public static string Enter_ChannelPaceAnalysis_EndDate { get; set; }
        public static string Enter_PickUpByDayDetailed_RelativeStartDate { get; set; }
        public static string Enter_PickUpByDayDetailed_RelativeEndDate { get; set; }
        public static string Enter_PickUpByDayDetailed_RelativePickupStartDate { get; set; }
        public static string Enter_PickUpByDayDetailed_RelativePickupEndDate { get; set; }
        public static string Enter_PickUpByDayDetailed_StartDate { get; set; }
        public static string Enter_PickUpByDayDetailed_EndDate { get; set; }
        public static string Enter_PickUpByDayDetailed_PickupStartDate { get; set; }
        public static string Enter_PickUpByDayDetailed_PickupEndDate { get; set; }
        public static string Click_BusinessSource { get; set; }
        public static string Click_BusinessSource_RoomTypeAnalysis { get; set; }
        public static string Click_BusinessSource_MarketReport { get; set; }
        public static string Enter_ReportDescription { get; set; }
        public static string Click_Tuesday { get; set; }
        public static string Click_Wednesday { get; set; }
        public static string Click_Thursday { get; set; }
        public static string Click_Friday { get; set; }
        public static string Enter_StartTimeHours { get; set; }
        public static string Enter_StartTimeMinutes { get; set; }
        public static string Enter_RendorFormat { get; set; }
        public static string Enter_EmailTo { get; set; }
        public static string Enter_EmailSubject { get; set; }
        public static string Enter_RelativeStartDateOffset { get; set; }
        public static string Enter_RelativeEndDateOffset { get; set; }
        public static string Click_RoomTypeAnalysis_SaveButton { get; set; }
        public static string Enter_AsOfDate { get; set; }
        public static string Enter_RelativeAsOfDate { get; set; }
        public static string Click_BookingTrends_PaceReport { get; set; }
        public static string Click_ManageReportSchedule_DeleteButton { get; set; }

        public static string Click_CurrentDate_RelativeSatrtDate { get; set; }
        public static string Click_CurrentDate_RelativeEndDate { get; set; }
        public static string Click_CurrentDate_RelativePickupSatrtDate { get; set; }
        public static string Click_CurrentDate_RelativePickupEndDate { get; set; }
        public static string Click_SelectDate_RelativeStartDate { get; set; }
        public static string Click_SelectDate_RelativeEndDate { get; set; }
        public static string Click_SelectDate_RelativePickupStartDate { get; set; }
        public static string Click_SelectDate_RelativePickupEndDate { get; set; }
        public static string Click_ReportType_Excel { get; set; }
        public static string Click_SaveSchedule_OkButton { get; set; }
        public static string Click_ManageReportSchedule_EditButton { get; set; }

        public static string Click_RelativeAsOfDate_Currentmonth { get; set; }
        public static string Click_RelativeAsOfDate_Offset { get; set; }
        public static string Enter_RelativePickUpStartDateOffset { get; set; }
        public static string Enter_RelativePickUpEndDateOffset { get; set; }

        public static string Click_Month { get; set; }
        public static string Click_Once { get; set; }
        public static string Click_OnCalendarDays { get; set; }
        public static string Click_Quick_RelativeDate { get; set; }
        public static string Click_Quick_RelativeDateToday { get; set; }
        public static string Click_Quick_RelativePickupDate { get; set; }
        public static string Click_Quick_RelativePickupDateToday { get; set; }
        public static string Click_Quick_AbsoluteDate { get; set; }
        public static string Click_Quick_AbsoluteDateToday { get; set; }
        public static string Click_Quick_AbsolutePickupDate { get; set; }
        public static string Click_Quick_AbsolutePickupDateToday { get; set; }
        public static string Enter_OnCalendarDays { get; set; }
        public static string Click_Quick_AbsoluteDateYesterday { get; set; }
        public static string Click_Quick_AbsoluteDateMTM { get; set; }
        public static string Click_Quick_AbsoluteDateYTD { get; set; }
        public static string Click_Quick_AbsoluteDateLastMonth { get; set; }
        public static string Click_Quick_AbsoluteDateThisMonth { get; set; }
        public static string Click_Quick_AbsoluteDateNextMonth { get; set; }
        public static string Click_Quick_AbsoluteDateLastYear { get; set; }
        public static string Click_Quick_AbsoluteDateThisYear { get; set; }
        public static string Click_Quick_AbsoluteDateEndOfYear { get; set; }
        public static string Click_Quick_AbsolutePickupDateYesterday { get; set; }
        public static string Click_Quick_AbsolutePickupDateMTM { get; set; }
        public static string Click_Quick_AbsolutePickupDateYTD { get; set; }
        public static string Click_Quick_AbsolutePickupDateLastMonth { get; set; }
        public static string Click_Quick_AbsolutePickupDateThisMonth { get; set; }
        public static string Click_Quick_AbsolutePickupDateNextMonth { get; set; }
        public static string Click_Quick_AbsolutePickupDateLastYear { get; set; }
        public static string Click_Quick_AbsolutePickupDateThisYear { get; set; }
        public static string Click_Quick_AbsolutePickupDateEndOfYear { get; set; }
        public static string Click_Quick_RelativeDateYesteraday { get; set; }
        public static string Click_Quick_RelativeDateLastMonth { get; set; }
        public static string Click_Quick_RelativeDateThisMonth { get; set; }
        public static string Click_Quick_RelativeDateNextMonth { get; set; }
        public static string Click_Quick_RelativeDateLastYear { get; set; }
        public static string Click_Quick_RelativeDateThisYear { get; set; }
        public static string Click_Quick_RelativePickupDateYesteraday { get; set; }
        public static string Click_Quick_RelativePickupDateLastMonth { get; set; }
        public static string Click_Quick_RelativePickupDateThisMonth { get; set; }
        public static string Click_Quick_RelativePickupDateNextMonth { get; set; }
        public static string Click_Quick_RelativePickupDateLastYear { get; set; }
        public static string Click_Quick_RelativePickupDateThisYear { get; set; }
        public static string Click_Portfolio { get; set; }
        public static string Click_BookingTrends_AgentByHotel { get; set; }
        public static string Click_SelectType { get; set; }
        public static string ReportScheduler_GetHotel { get; set; }
        public static string ReportScheduler_GetBusinessUnit { get; set; }
        public static string ReportScheduler_GetCurrency { get; set; }
        public static string Select_Blank_RelativeAsOfDate { get; set; }



        public static string Click_ReportParameter_Market { get; set; }
        public static string Click_Market_MarketReport { get; set; }
        public static string Click_SelectType_Hotel { get; set; }
        public static string Select_SelectType_Portfolio { get; set; }
        public static string Click_InvalidSelection_OkButton { get; set; }
        public static string Select_SelectType_Hotel { get; set; }
        public static string Click_HotelOrPortfolio { get; set; }

        #endregion ReportScheduler
        #region[ExchangeRate]
        public static string Click_ViewAnalysis { get; set; }
        
        #endregion[ExchangeRate]
        public static ObjectRepository ReadElement(string location, string nodeModule)
        {
            ObjectRepository obj = new ObjectRepository();
            XDocument doc = XDocument.Load(location);
            var query = doc.Descendants(nodeModule).Elements().ToDictionary(x => x.Attribute("key").Value, x => x.Value);

            foreach (KeyValuePair<string, string> pair in query)
            {
                if (nodeModule == Constants.Login)
                {
                    if (pair.Key == "Enter_EmailAddress")
                        Enter_EmailAddress = pair.Value;
                    else if (pair.Key == "Enter_Password")
                        Enter_Password = pair.Value;
                    else if (pair.Key == "Click_SignIn_Button")
                        Click_SignIn_Button = pair.Value;
                    else if (pair.Key == "Select_DropDown")
                        Select_DropDown = pair.Value;
                    else if (pair.Key == "LogOut_Button")
                        LogOut_Button = pair.Value;
                    else if (pair.Key == "Click_Next_Button")
                        Click_Next_Button = pair.Value;
                }

                else if (nodeModule == Constants.Navigation)
                {
                    if (pair.Key == "Kerzner")
                        Kerzner = pair.Value;
                    else if (pair.Key == "Tenant_21C")
                        Tenant_21C = pair.Value;
                    else if (pair.Key == "Click_UAT")
                        Click_UAT = pair.Value;
                    else if (pair.Key == "Click_TA")
                        Click_TA = pair.Value;
                    else if (pair.Key == "Click_RS")
                        Click_RS = pair.Value;
                    else if (pair.Key == "Click_Automation")
                        Click_Automation = pair.Value;
                    else if (pair.Key == "Click_change_password")
                        Click_change_password = pair.Value;
                    else if (pair.Key == "Change_password_Cancel_button")
                        Change_password_Cancel_button = pair.Value;
                    else if (pair.Key == "incorrect_current_password_validation")
                        incorrect_current_password_validation = pair.Value;
                    else if (pair.Key == "Enter_Current_Password")
                        Enter_Current_Password = pair.Value;
                    else if (pair.Key == "Enter_New_Password")
                        Enter_New_Password = pair.Value;
                    else if (pair.Key == "Enter_Confirm_Password")
                        Enter_Confirm_Password = pair.Value;
                    else if (pair.Key == "Click_Change_Password_button")
                        Click_Change_Password_button = pair.Value;
                    else if (pair.Key == "Hotel")
                        Hotel = pair.Value;
                    else if (pair.Key == "D_Rock")
                        D_Rock = pair.Value;
                    else if (pair.Key == "Benchmark_Hospitality")
                        Benchmark_Hospitality = pair.Value;
                    else if (pair.Key == "Ocean_House")
                        Ocean_House = pair.Value;
                    else if (pair.Key == "Portal")
                        Portal = pair.Value;
                    else if (pair.Key == "Filament")
                        Filament = pair.Value;
                    else if (pair.Key == "BusinessSource")
                        BusinessSource = pair.Value;
                    else if (pair.Key == "Portfolio")
                        Portfolio = pair.Value;
                    else if (pair.Key == "Portfolio_Report")
                        Portfolio_Report = pair.Value;
                    else if (pair.Key == "AgentAnalysis")
                        AgentAnalysis = pair.Value;
                    else if (pair.Key == "Market")
                        Market = pair.Value;
                    else if (pair.Key == "Booking_Trends")
                        Booking_Trends = pair.Value;
                    else if (pair.Key == "Channel")
                        Channel = pair.Value;
                    else if (pair.Key == "Forecast_and_Budget")
                        Forecast_and_Budget = pair.Value;
                    else if (pair.Key == "Adhoc")
                        Adhoc = pair.Value;
                    else if (pair.Key == "Geo_Source")
                        Geo_Source = pair.Value;
                    else if (pair.Key == "Click_Hamburger_Icon")
                        Click_Hamburger_Icon = pair.Value;
                    else if (pair.Key == "user_preferences")
                        user_preferences = pair.Value;
                    else if (pair.Key == "user_preferences_Hotel")
                        user_preferences_Hotel = pair.Value;
                    else if (pair.Key == "user_preferences_Hotel_select")
                        user_preferences_Hotel_select = pair.Value;
                    else if (pair.Key == "user_preferences_Currency")
                        user_preferences_Currency = pair.Value;
                    else if (pair.Key == "user_preferences_Currency_Select")
                        user_preferences_Currency_Select = pair.Value;
                    else if (pair.Key == "user_preferences_Save")
                        user_preferences_Save = pair.Value;
                    else if (pair.Key == "Iframe_user_preferences")
                        Iframe_user_preferences = pair.Value;
                    else if (pair.Key == "user_preferences_Close")
                        user_preferences_Close = pair.Value;
                    else if (pair.Key == "Help_Menu")
                        Help_Menu = pair.Value;
                    else if (pair.Key == "Training")
                        Training = pair.Value;
                    else if (pair.Key == "Release_note")
                        Release_note = pair.Value;
                    else if (pair.Key == "user_preferences_Hotel_Default")
                        user_preferences_Hotel_Default = pair.Value;
                    else if (pair.Key == "user_preferences_Currency_Default")
                        user_preferences_Currency_Default = pair.Value;
                    else if (pair.Key == "Administration")
                        Administration = pair.Value;
                    else if (pair.Key == "User_Maintenance")
                        User_Maintenance = pair.Value;
                    else if (pair.Key == "Add_New_User")
                        Add_New_User = pair.Value;
                    else if (pair.Key == "Iframe_user_Maintenance")
                        Iframe_user_Maintenance = pair.Value;
                    else if (pair.Key == "user_Maintenance_Save")
                        user_Maintenance_Save = pair.Value;
                    else if (pair.Key == "user_Maintenance_Close")
                        user_Maintenance_Close = pair.Value;
                    else if (pair.Key == "user_Id")
                        user_Id = pair.Value;
                    else if (pair.Key == "Add_User_Email")
                        Add_User_Email = pair.Value;
                    else if (pair.Key == "Add_User_FirstName")
                        Add_User_FirstName = pair.Value;
                    else if (pair.Key == "Add_User_LastName")
                        Add_User_LastName = pair.Value;
                    else if (pair.Key == "Select_Available_Hotels")
                        Select_Available_Hotels = pair.Value;
                    else if (pair.Key == "Iframe_Add_User")
                        Iframe_Add_User = pair.Value;
                    else if (pair.Key == "Corporate_Portfolio")
                        Corporate_Portfolio = pair.Value;
                    else if (pair.Key == "Add_New_Portfolio")
                        Add_New_Portfolio = pair.Value;
                    else if (pair.Key == "iframe_New_Portfolio")
                        iframe_New_Portfolio = pair.Value;
                    else if (pair.Key == "Portfolio_name")
                        Portfolio_name = pair.Value;
                    else if (pair.Key == "Pace_Forecast_Report")
                        Pace_Forecast_Report = pair.Value;
                    else if (pair.Key == "iFrame_Pace_Forecast_Report")
                        iFrame_Pace_Forecast_Report = pair.Value;
                    else if (pair.Key == "Agent_Summary")
                        Agent_Summary = pair.Value;
                    else if (pair.Key == "Parent_Company_Analysis")
                        Parent_Company_Analysis = pair.Value;
                    else if (pair.Key == "Parent_Travel_Agent_Analysis")
                        Parent_Travel_Agent_Analysis = pair.Value;
                    else if (pair.Key == "Company_Period_Summary")
                        Company_Period_Summary = pair.Value;
                    else if (pair.Key == "Agent_Period_Summary")
                        Agent_Period_Summary = pair.Value;
                    else if (pair.Key == "Agent_Trend_Report")
                        Agent_Trend_Report = pair.Value;
                    else if (pair.Key == "Company_Trend_Report")
                        Company_Trend_Report = pair.Value;
                    else if (pair.Key == "Agent_By_Hotel")
                        Agent_By_Hotel = pair.Value;
                    else if (pair.Key == "Channel_By_Hotel")
                        Channel_By_Hotel = pair.Value;
                    else if (pair.Key == "Company_By_Hotel")
                        Company_By_Hotel = pair.Value;
                    else if (pair.Key == "Market_By_Hotel_Report")
                        Market_By_Hotel_Report = pair.Value;
                    else if (pair.Key == "Province_and_State_By_Hotel")
                        Province_and_State_By_Hotel = pair.Value;
                    else if (pair.Key == "Room_Type_By_Hotel")
                        Room_Type_By_Hotel = pair.Value;
                    else if (pair.Key == "Source_Market_By_Hotel")
                        Source_Market_By_Hotel = pair.Value;
                    else if (pair.Key == "Pace_Report")
                        Pace_Report = pair.Value;
                    else if (pair.Key == "Pace_Trend")
                        Pace_Trend = pair.Value;
                    else if (pair.Key == "Daily_Pace_and_Pickup_Analysis")
                        Daily_Pace_and_Pickup_Analysis = pair.Value;
                    else if (pair.Key == "Pace_and_Pickup_Analysis")
                        Pace_and_Pickup_Analysis = pair.Value;
                    else if (pair.Key == "Rate_Code_Pace_Report")
                        Rate_Code_Pace_Report = pair.Value;
                    else if (pair.Key == "Channel_By_Room_Type_Pace")
                        Channel_By_Room_Type_Pace = pair.Value;
                    else if (pair.Key == "Channel_Pace_Analysis")
                        Channel_Pace_Analysis = pair.Value;
                    else if (pair.Key == "Pickup_By_Day")
                        Pickup_By_Day = pair.Value;
                    else if (pair.Key == "Room_Type")
                        Room_Type = pair.Value;
                    else if (pair.Key == "Room_Rate")
                        Room_Rate = pair.Value;
                    else if (pair.Key == "Rainmaker")
                        Rainmaker = pair.Value;
                    else if (pair.Key == "Annual_Pickup_by_Day")
                        Annual_Pickup_by_Day = pair.Value;
                    else if (pair.Key == "Length_of_Stay_Report")
                        Length_of_Stay_Report = pair.Value;
                    else if (pair.Key == "Rooms_Lead_Time")
                        Rooms_Lead_Time = pair.Value;
                    else if (pair.Key == "Pickup_By_Day_Detailed")
                        Pickup_By_Day_Detailed = pair.Value;
                    else if (pair.Key == "Monthly_Pickup")
                        Monthly_Pickup = pair.Value;
                    else if (pair.Key == "Production_Patterns")
                        Production_Patterns = pair.Value;
                    else if (pair.Key == "High_Occupancy_Night_By_Day")
                        High_Occupancy_Night_By_Day = pair.Value;
                    else if (pair.Key == "Sold_Out_Night_Analysis")
                        Sold_Out_Night_Analysis = pair.Value;
                    else if (pair.Key == "Cancellation_Report")
                        Cancellation_Report = pair.Value;
                    else if (pair.Key == "Hotel_Event_Calendar")
                        Hotel_Event_Calendar = pair.Value;
                    else if (pair.Key == "Market_Report")
                        Market_Report = pair.Value;
                    else if (pair.Key == "Channel_Report")
                        Channel_Report = pair.Value;
                    else if (pair.Key == "Pace_and_Forecast_Report")
                        Pace_and_Forecast_Report = pair.Value;
                    else if (pair.Key == "Stay_Graph")
                        Stay_Graph = pair.Value;
                    else if (pair.Key == "Source_Market_Trend")
                        Source_Market_Trend = pair.Value;
                    else if (pair.Key == "Room_Type_Analysis")
                        Room_Type_Analysis = pair.Value;
                    else if (pair.Key == "Time_Period")
                        Time_Period = pair.Value;
                    else if (pair.Key == "Day_of_Week_Statistics")
                        Day_of_Week_Statistics = pair.Value;
                    else if (pair.Key == "Total_Revenue_Analysis")
                        Total_Revenue_Analysis = pair.Value;
                    else if (pair.Key == "Custom")
                        Custom = pair.Value;
                    else if (pair.Key == "OTB_Comparison_for_All_Segments")
                        OTB_Comparison_for_All_Segments = pair.Value;
                    else if (pair.Key == "Role_Maintenance")
                        Role_Maintenance = pair.Value;
                    else if (pair.Key == "Click_Help_Icon")
                        Click_Help_Icon = pair.Value;
                    else if (pair.Key == "Enter_Help_Text")
                        Enter_Help_Text = pair.Value;
                    else if (pair.Key == "Click_Contact_us_Icon")
                        Click_Contact_us_Icon = pair.Value;
                    else if (pair.Key == "Click_Portal_Update_Button")
                        Click_Portal_Update_Button = pair.Value;
                    else if (pair.Key == "Click_Link_Portal")
                        Click_Link_Portal = pair.Value;
                    else if (pair.Key == "Click_Link_Hotel_Dashboard")
                        Click_Link_Hotel_Dashboard = pair.Value;
                    else if (pair.Key == "Hotel_Dashboard_iFrame")
                        Hotel_Dashboard_iFrame = pair.Value;
                    else if (pair.Key == "Click_Help_Icon_Minimize")
                        Click_Help_Icon_Minimize = pair.Value;
                    else if (pair.Key == "Enter_Contact_Name")
                        Enter_Contact_Name = pair.Value;
                    else if (pair.Key == "Enter_Contact_Email")
                        Enter_Contact_Email = pair.Value;
                    else if (pair.Key == "Enter_Contact_Subject")
                        Enter_Contact_Subject = pair.Value;
                    else if (pair.Key == "Enter_Contact_Property")
                        Enter_Contact_Property = pair.Value;
                    else if (pair.Key == "Enter_Contact_Description")
                        Enter_Contact_Description = pair.Value;
                    else if (pair.Key == "Click_Contact_Send")
                        Click_Contact_Send = pair.Value;
                    else if (pair.Key == "Click_Contact_Support_Dropdown")
                        Click_Contact_Support_Dropdown = pair.Value;
                    else if (pair.Key == "Click_Contact_Support_Services")
                        Click_Contact_Support_Services = pair.Value;
                    else if (pair.Key == "Click_Contact_Support_Sub_Services")
                        Click_Contact_Support_Sub_Services = pair.Value;
                    else if (pair.Key == "Market_Performance")
                        Market_Performance = pair.Value;
                    else if (pair.Key == "Market_Trend_Report")
                        Market_Trend_Report = pair.Value;
                    else if (pair.Key == "Market_Segment_by_Day")
                        Market_Segment_by_Day = pair.Value;
                    else if (pair.Key == "Market_Segment_by_Day_Summary")
                        Market_Segment_by_Day_Summary = pair.Value;
                    else if (pair.Key == "Annual_Market_Analysis_by_Month")
                        Annual_Market_Analysis_by_Month = pair.Value;
                    else if (pair.Key == "Rate_Code_Analysis")
                        Rate_Code_Analysis = pair.Value;
                    else if (pair.Key == "Market_Analysis_by_Year")
                        Market_Analysis_by_Year = pair.Value;
                    else if (pair.Key == "Monthly_Market_Segment_Report")
                        Monthly_Market_Segment_Report = pair.Value;
                    else if (pair.Key == "Rate_Code_Trend_Report")
                        Rate_Code_Trend_Report = pair.Value;
                    else if (pair.Key == "Click_Forecast_Budget_Upload_Report")
                        Click_Forecast_Budget_Upload_Report = pair.Value;
                    else if (pair.Key == "Click_Source_Market_Analysis_Report")
                        Click_Source_Market_Analysis_Report = pair.Value;
                    else if (pair.Key == "Click_Source_Market_Trend_Report")
                        Click_Source_Market_Trend_Report = pair.Value;
                    else if (pair.Key == "Click_United_States_Trend_Report")
                        Click_United_States_Trend_Report = pair.Value;
                    else if (pair.Key == "Click_Province_and_State_Analysis_Report")
                        Click_Province_and_State_Analysis_Report = pair.Value;
                    else if (pair.Key == "Click_Room_Type_Analysis_Report")
                        Click_Room_Type_Analysis_Report = pair.Value;
                    else if (pair.Key == "Click_Room_Type_and_Up_Grade_Statistics_Report")
                        Click_Room_Type_and_Up_Grade_Statistics_Report = pair.Value;
                    else if (pair.Key == "Click_Booked_Room_Materialization_Report")
                        Click_Booked_Room_Materialization_Report = pair.Value;
                    else if (pair.Key == "Click_Detailed_Room_Type_Availability_Report")
                        Click_Detailed_Room_Type_Availability_Report = pair.Value;
                    else if (pair.Key == "Click_UserMenu")
                        Click_UserMenu = pair.Value;
                    else if (pair.Key == "Click_UserMenu_ReportScheduler")
                        Click_UserMenu_ReportScheduler = pair.Value;
                    else if (pair.Key == "Click_UserMenu_ManageReportSchedules")
                        Click_UserMenu_ManageReportSchedules = pair.Value;
                    else if (pair.Key == "Click_RainMaker_MoreButton")
                        Click_RainMaker_MoreButton = pair.Value;
                    else if (pair.Key == "Click_RainMaker")
                        Click_RainMaker = pair.Value;
                    else if (pair.Key == "Click_SubscriptionSupport")
                        Click_SubscriptionSupport = pair.Value;
                    else if (pair.Key == "Click_Time_Period_Menu")
                        Click_Time_Period_Menu = pair.Value;
                    else if (pair.Key == "Click_Annual_Trends_Report")
                        Click_Annual_Trends_Report = pair.Value;
                    else if (pair.Key == "Click_Daily_Analysis_Report")
                        Click_Daily_Analysis_Report = pair.Value;
                    else if (pair.Key == "Click_Day_of_Week_Statistics_Report")
                        Click_Day_of_Week_Statistics_Report = pair.Value;
                    else if (pair.Key == "Click_Monthly_Summary_Report")
                        Click_Monthly_Summary_Report = pair.Value;
                    else if (pair.Key == "Click_Day_of_Week_Analysis_Report")
                        Click_Day_of_Week_Analysis_Report = pair.Value;
                    else if (pair.Key == "Click_Daily_Analysis_PerPerson_Report")
                        Click_Daily_Analysis_PerPerson_Report = pair.Value;
                    else if (pair.Key == "Click_OTB_Comparison_by_Segment_Reports")
                        Click_OTB_Comparison_by_Segment_Reports = pair.Value;
                    else if (pair.Key == "Click_Custom_Menu")
                        Click_Custom_Menu = pair.Value;
                    else if (pair.Key == "Click_Daily_Pick_Up_Report")
                        Click_Daily_Pick_Up_Report = pair.Value;
                    else if (pair.Key == "Click_Revenue_By_Room_Product_Report")
                        Click_Revenue_By_Room_Product_Report = pair.Value;
                    else if (pair.Key == "Click_Pickup_by_Market_Segment_Report")
                        Click_Pickup_by_Market_Segment_Report = pair.Value;
                    else if (pair.Key == "Click_OTB_Comparison_for_All_Segments_Report")
                        Click_OTB_Comparison_for_All_Segments_Report = pair.Value;
                    else if (pair.Key == "Click_OTB_vs_Budget_by_Segment_Report")
                        Click_OTB_vs_Budget_by_Segment_Report = pair.Value;
                    else if (pair.Key == "Click_OTB_vs_Forecast_by_Segment_Report")
                        Click_OTB_vs_Forecast_by_Segment_Report = pair.Value;
                    else if (pair.Key == "Click_Room_Type_Booked_vs_Occupied")
                        Click_Room_Type_Booked_vs_Occupied = pair.Value;
                    else if (pair.Key == "Click_Access_Log")
                        Click_Access_Log = pair.Value;
                    else if (pair.Key == "Click_Parent_Company")
                        Click_Parent_Company = pair.Value;
                    else if (pair.Key == "Click_User_Access_Report")
                        Click_User_Access_Report = pair.Value;
                    else if (pair.Key == "Click_Room_Rate_Menu")
                        Click_Room_Rate_Menu = pair.Value;
                    else if (pair.Key == "Best_Available_Rate_Contribution_Report")
                        Best_Available_Rate_Contribution_Report = pair.Value;
                    else if (pair.Key == "Click_Total_Revenue_Analysis_Report")
                        Click_Total_Revenue_Analysis_Report = pair.Value;
                    else if (pair.Key == "Click_Hotel_Dashboard")
                        Click_Hotel_Dashboard = pair.Value;
                    else if (pair.Key == "Click_Agent_Dashboard")
                        Click_Agent_Dashboard = pair.Value;
                    else if (pair.Key == "Click_Company_Dashboard")
                        Click_Company_Dashboard = pair.Value;
                    else if (pair.Key == "Click_Market_Dashboard")
                        Click_Market_Dashboard = pair.Value;
                    else if (pair.Key == "Click_Channel_Dashboard")
                        Click_Channel_Dashboard = pair.Value;
                    else if (pair.Key == "Click_Room_Type_Dashboard")
                        Click_Room_Type_Dashboard = pair.Value;
                    else if (pair.Key == "Click_Negotiated_Dashboard")
                        Click_Negotiated_Dashboard = pair.Value;
                    else if (pair.Key == "Click_Pace_Dashboard")
                        Click_Pace_Dashboard = pair.Value;
                    else if (pair.Key == "Click_Channel_Trend_Report")
                        Click_Channel_Trend_Report = pair.Value;
                    else if (pair.Key == "Click_Daily_Channel_by_Room_Type")
                        Click_Daily_Channel_by_Room_Type = pair.Value;
                    else if (pair.Key == "user_preferences_BusinessUnit")
                        user_preferences_BusinessUnit = pair.Value;
                    else if (pair.Key == "Click_Stay_Graph_Report")
                        Click_Stay_Graph_Report = pair.Value;
                    else if (pair.Key == "Click_Menu_Market")
                        Click_Menu_Market = pair.Value;
                    else if (pair.Key == "Click_change_tenant")
                        Click_change_tenant = pair.Value;
                    else if (pair.Key == "Click_User_Preference_Portfolio_Toggle_button")
                        Click_User_Preference_Portfolio_Toggle_button = pair.Value;
                    else if (pair.Key == "Click_Business_Unit_Grouping")
                        Click_Business_Unit_Grouping = pair.Value;
                    else if (pair.Key == "Click_Add_New_Business_Unit_Group")
                        Click_Add_New_Business_Unit_Group = pair.Value;

                    else if (pair.Key == "Click_Channel_Mapping")
                        Click_Channel_Mapping = pair.Value;
                    else if (pair.Key == "Click_Room_Type_Mapping")
                        Click_Room_Type_Mapping = pair.Value;
                    else if (pair.Key == "Click_Market_Mapping")
                        Click_Market_Mapping = pair.Value;

                    else if (pair.Key == "Rainmaker_Hotel_Dropdown")
                        Rainmaker_Hotel_Dropdown = pair.Value;
                    else if (pair.Key == "Rainmaker_Hotel_Value")
                        Rainmaker_Hotel_Value = pair.Value;

                }

                else if (nodeModule == Constants.ReportParameter)
                {
                    if (pair.Key == "Select_Hotel")
                        Select_Hotel = pair.Value;
                    else if (pair.Key == "Select_Hotel_DDL")
                        Select_Hotel_DDL = pair.Value;
                    else if (pair.Key == "Select_Hotel_value")
                        Select_Hotel_value = pair.Value;
                    else if (pair.Key == "Click_Currency_Dropdown")
                        Click_Currency_Dropdown = pair.Value;
                    else if (pair.Key == "Select_Currency_Value")
                        Select_Currency_Value = pair.Value;
                    else if (pair.Key == "Click_Business_Unit_Dropdown")
                        Click_Business_Unit_Dropdown = pair.Value;
                    else if (pair.Key == "Select_Business_Unit_Value")
                        Select_Business_Unit_Value = pair.Value;
                    else if (pair.Key == "Portfolio_RadioButton")
                        Portfolio_RadioButton = pair.Value;
                    else if (pair.Key == "HotelorPortfolio_DDL")
                        HotelorPortfolio_DDL = pair.Value;
                    else if (pair.Key == "HotelorPortfolio_Dropdown_Arrow")
                        HotelorPortfolio_Dropdown_Arrow = pair.Value;
                    else if (pair.Key == "HotelorPortfolio_ListValue")
                        HotelorPortfolio_ListValue = pair.Value;
                    else if (pair.Key == "StartDate_Text")
                        StartDate_Text = pair.Value;
                    else if (pair.Key == "EndDate_Text")
                        EndDate_Text = pair.Value;
                    else if (pair.Key == "Save_Button")
                        Save_Button = pair.Value;
                    else if (pair.Key == "ReportHeading_Label")
                        ReportHeading_Label = pair.Value;
                    else if (pair.Key == "Click_View_Analysis")
                        Click_View_Analysis = pair.Value;
                    else if (pair.Key == "IFrame_Agent_Analysis")
                        IFrame_Agent_Analysis = pair.Value;
                    else if (pair.Key == "Export_Menu")
                        Export_Menu = pair.Value;
                    else if (pair.Key == "Excel")
                        Excel = pair.Value;
                    else if (pair.Key == "Word")
                        Word = pair.Value;
                    else if (pair.Key == "PDF")
                        PDF = pair.Value;
                    else if (pair.Key == "TIFF")
                        TIFF = pair.Value;
                    else if (pair.Key == "PowerPoint")
                        PowerPoint = pair.Value;
                    else if (pair.Key == "MHTML")
                        MHTML = pair.Value;
                    else if (pair.Key == "CSV")
                        CSV = pair.Value;
                    else if (pair.Key == "XML")
                        XML = pair.Value;
                    else if (pair.Key == "Data_Feed")
                        Data_Feed = pair.Value;
                    else if (pair.Key == "Parameter_market_Direct")
                        Parameter_market_Direct = pair.Value;
                    else if (pair.Key == "Parameter_market")
                        Parameter_market = pair.Value;
                    else if (pair.Key == "Select_Dropdown_Hotel")
                        Select_Dropdown_Hotel = pair.Value;
                    else if (pair.Key == "Parameter_Channel")
                        Parameter_Channel = pair.Value;
                    else if (pair.Key == "Parameter_channel_Hotel_Direct")
                        Parameter_channel_Hotel_Direct = pair.Value;
                    else if (pair.Key == "iframe_Parent_Company_Analysis")
                        iframe_Parent_Company_Analysis = pair.Value;
                    else if (pair.Key == "Parent_Company_Analysis_Close")
                        Parent_Company_Analysis_Close = pair.Value;
                    else if (pair.Key == "Paremeter_Memberships")
                        Paremeter_Memberships = pair.Value;
                    else if (pair.Key == "Paremeter_Memberships_value")
                        Paremeter_Memberships_value = pair.Value;
                    else if (pair.Key == "Parent_Travel_Agent_Analysis_Close")
                        Parent_Travel_Agent_Analysis_Close = pair.Value;
                    else if (pair.Key == "Parameter_Agent")
                        Parameter_Agent = pair.Value;
                    else if (pair.Key == "Parameter_Agent_Enter")
                        Parameter_Agent_Enter = pair.Value;
                    else if (pair.Key == "Parameter_Agent_value")
                        Parameter_Agent_value = pair.Value;
                    else if (pair.Key == "iframe_Parent_Travel_Agent_Analysis")
                        iframe_Parent_Travel_Agent_Analysis = pair.Value;
                    else if (pair.Key == "iframe_Company_Period_Summary")
                        iframe_Company_Period_Summary = pair.Value;
                    else if (pair.Key == "Company_Period_Summary_Close")
                        Company_Period_Summary_Close = pair.Value;
                    else if (pair.Key == "Agent_Period_Summary_Close")
                        Agent_Period_Summary_Close = pair.Value;
                    else if (pair.Key == "iframe_Agent_Period_Summary")
                        iframe_Agent_Period_Summary = pair.Value;
                    else if (pair.Key == "iframe_Agent_Trend_Report")
                        iframe_Agent_Trend_Report = pair.Value;
                    else if (pair.Key == "Agent_Trend_Report_Close")
                        Agent_Trend_Report_Close = pair.Value;
                    else if (pair.Key == "Compare_Start_Date")
                        Compare_Start_Date = pair.Value;
                    else if (pair.Key == "Compare_End_Date")
                        Compare_End_Date = pair.Value;
                    else if (pair.Key == "iframe_Company_Trend_Report")
                        iframe_Company_Trend_Report = pair.Value;
                    else if (pair.Key == "iframe_Portfolio")
                        iframe_Portfolio = pair.Value;
                    else if (pair.Key == "Portfolio_DDL")
                        Portfolio_DDL = pair.Value;
                    else if (pair.Key == "Portfolio_DDL_value")
                        Portfolio_DDL_value = pair.Value;
                    else if (pair.Key == "iframe_Agent_By_Hotel")
                        iframe_Agent_By_Hotel = pair.Value;
                    else if (pair.Key == "Memberships_value_MemberOnly")
                        Memberships_value_MemberOnly = pair.Value;
                    else if (pair.Key == "iframe_channel_By_Hotel")
                        iframe_channel_By_Hotel = pair.Value;
                    else if (pair.Key == "Portfolio_Selection_DDL")
                        Portfolio_Selection_DDL = pair.Value;
                    else if (pair.Key == "iframe_company_By_Hotel")
                        iframe_company_By_Hotel = pair.Value;
                    else if (pair.Key == "Parameter_market_Corporate")
                        Parameter_market_Corporate = pair.Value;
                    else if (pair.Key == "iframe_Market_By_Hotel_Report")
                        iframe_Market_By_Hotel_Report = pair.Value;
                    else if (pair.Key == "Select_SourceMarket_value")
                        Select_SourceMarket_value = pair.Value;
                    else if (pair.Key == "Select_RoomProduct_DDL")
                        Select_RoomProduct_DDL = pair.Value;
                    else if (pair.Key == "Select_RoomProduct_value")
                        Select_RoomProduct_value = pair.Value;
                    else if (pair.Key == "Select_SourceMarket_DDL")
                        Select_SourceMarket_DDL = pair.Value;
                    else if (pair.Key == "iframe_Province_and_State_By_Hotel")
                        iframe_Province_and_State_By_Hotel = pair.Value;
                    else if (pair.Key == "iframe_Room_Type_By_Hotel")
                        iframe_Room_Type_By_Hotel = pair.Value;
                    else if (pair.Key == "iframe_Source_Market_By_Hotel")
                        iframe_Source_Market_By_Hotel = pair.Value;
                    else if (pair.Key == "Click_expand_sign")
                        Click_expand_sign = pair.Value;
                    else if (pair.Key == "Click_collapse_sign")
                        Click_collapse_sign = pair.Value;
                    else if (pair.Key == "Click_Source_Market_By_Hotel_expand_sign")
                        Click_Source_Market_By_Hotel_expand_sign = pair.Value;
                    else if (pair.Key == "Click_Source_Market_By_Hotel_collapse_sign")
                        Click_Source_Market_By_Hotel_collapse_sign = pair.Value;
                    else if (pair.Key == "iframe_Pace_report")
                        iframe_Pace_report = pair.Value;
                    else if (pair.Key == "Enter_As_Of_Date")
                        Enter_As_Of_Date = pair.Value;
                    else if (pair.Key == "Select_Portfolio_value")
                        Select_Portfolio_value = pair.Value;
                    else if (pair.Key == "iframe_Pace_Trend")
                        iframe_Pace_Trend = pair.Value;
                    else if (pair.Key == "Enter_Pace_Trend_Start_Month")
                        Enter_Pace_Trend_Start_Month = pair.Value;
                    else if (pair.Key == "iframe_Daily_Pace_and_Pickup_Analysis")
                        iframe_Daily_Pace_and_Pickup_Analysis = pair.Value;
                    else if (pair.Key == "iframe_Pace_and_Pickup_Analysis")
                        iframe_Pace_and_Pickup_Analysis = pair.Value;
                    else if (pair.Key == "Parameter_Rate_code_DDL")
                        Parameter_Rate_code_DDL = pair.Value;
                    else if (pair.Key == "Parmeter_Rate_code_value")
                        Parmeter_Rate_code_value = pair.Value;
                    else if (pair.Key == "iframe_Rate_Code_Pace_Report")
                        iframe_Rate_Code_Pace_Report = pair.Value;
                    else if (pair.Key == "iframe_Channel_By_Room_Type_Pace")
                        iframe_Channel_By_Room_Type_Pace = pair.Value;
                    else if (pair.Key == "iframe_Channel_Pace_Analysis")
                        iframe_Channel_Pace_Analysis = pair.Value;
                    else if (pair.Key == "iframe_Pickup_By_Day")
                        iframe_Pickup_By_Day = pair.Value;
                    else if (pair.Key == "Pickup_startDate")
                        Pickup_startDate = pair.Value;
                    else if (pair.Key == "Pickup_enddate")
                        Pickup_enddate = pair.Value;
                    else if (pair.Key == "PaceReport_Expand")
                        PaceReport_Expand = pair.Value;
                    else if (pair.Key == "PaceReport_Collapse")
                        PaceReport_Collapse = pair.Value;
                    else if (pair.Key == "Monthly_PickupStart")
                        Monthly_PickupStart = pair.Value;
                    else if (pair.Key == "Monthly_PickupEnd")
                        Monthly_PickupEnd = pair.Value;
                    else if (pair.Key == "Monthly_Start")
                        Monthly_Start = pair.Value;
                    else if (pair.Key == "Monthly_End")
                        Monthly_End = pair.Value;
                    else if (pair.Key == "iframe_Annual_Pickup_by_Day")
                        iframe_Annual_Pickup_by_Day = pair.Value;
                    else if (pair.Key == "iframe_Lenght_of_stay_Report")
                        iframe_Lenght_of_stay_Report = pair.Value;
                    else if (pair.Key == "iframe_Rooms_Lead_Time")
                        iframe_Rooms_Lead_Time = pair.Value;
                    else if (pair.Key == "iframe_Pickup_By_Day_Detailed")
                        iframe_Pickup_By_Day_Detailed = pair.Value;
                    else if (pair.Key == "iframe_Production_Patterns")
                        iframe_Production_Patterns = pair.Value;
                    else if (pair.Key == "iframe_High_Occupancy_Night_By_Day")
                        iframe_High_Occupancy_Night_By_Day = pair.Value;
                    else if (pair.Key == "iframe_Sold_Out_Night_Analysis")
                        iframe_Sold_Out_Night_Analysis = pair.Value;
                    else if (pair.Key == "iframe_Cancellation_Report")
                        iframe_Cancellation_Report = pair.Value;
                    else if (pair.Key == "Monthly_Pickup_Excel")
                        Monthly_Pickup_Excel = pair.Value;
                    else if (pair.Key == "Market_Report_Expand_Level")
                        Market_Report_Expand_Level = pair.Value;
                    else if (pair.Key == "iframe_Market_Report")
                        iframe_Market_Report = pair.Value;
                    else if (pair.Key == "iframe_Market_Performance")
                        iframe_Market_Performance = pair.Value;
                    else if (pair.Key == "iframe_Market_Trend_Report")
                        iframe_Market_Trend_Report = pair.Value;
                    else if (pair.Key == "iframe_Market_Segment_by_Day")
                        iframe_Market_Segment_by_Day = pair.Value;
                    else if (pair.Key == "iframe_Market_Segment_by_Day_Summary")
                        iframe_Market_Segment_by_Day_Summary = pair.Value;
                    else if (pair.Key == "iframe_Annual_Market_Analysis_by_Month")
                        iframe_Annual_Market_Analysis_by_Month = pair.Value;
                    else if (pair.Key == "iframe_Rate_Code_Analysis")
                        iframe_Rate_Code_Analysis = pair.Value;
                    else if (pair.Key == "iframe_Market_Analysis_by_Year")
                        iframe_Market_Analysis_by_Year = pair.Value;
                    else if (pair.Key == "iframe_Monthly_Market_Segment_Report")
                        iframe_Monthly_Market_Segment_Report = pair.Value;
                    else if (pair.Key == "iframe_Rate_Code_Trend_Report")
                        iframe_Rate_Code_Trend_Report = pair.Value;
                    else if (pair.Key == "iframe_Pace_and_Forecast_Report")
                        iframe_Pace_and_Forecast_Report = pair.Value;
                    else if (pair.Key == "iframe_Source_Market_Analysis_Report")
                        iframe_Source_Market_Analysis_Report = pair.Value;
                    else if (pair.Key == "iframe_Source_Market_Trend_Report")
                        iframe_Source_Market_Trend_Report = pair.Value;
                    else if (pair.Key == "iframe_Province_and_State_Analysis_Report")
                        iframe_Province_and_State_Analysis_Report = pair.Value;
                    else if (pair.Key == "iframe_United_States_Trend_Report")
                        iframe_United_States_Trend_Report = pair.Value;
                    else if (pair.Key == "iframe_Room_Type_Analysis_Report")
                        iframe_Room_Type_Analysis_Report = pair.Value;
                    else if (pair.Key == "iframe_Room_Type_and_Up_Grade_Statistics_Report")
                        iframe_Room_Type_and_Up_Grade_Statistics_Report = pair.Value;
                    else if (pair.Key == "iframe_Booked_Room_Materialization_Report")
                        iframe_Booked_Room_Materialization_Report = pair.Value;
                    else if (pair.Key == "iframe_Detailed_Room_Type_Availability_Report")
                        iframe_Detailed_Room_Type_Availability_Report = pair.Value;
                    else if (pair.Key == "iframe_Annual_Trends_Report")
                        iframe_Annual_Trends_Report = pair.Value;
                    else if (pair.Key == "iframe_Daily_Analysis_Report")
                        iframe_Daily_Analysis_Report = pair.Value;
                    else if (pair.Key == "iframe_Monthly_Summary_Report")
                        iframe_Monthly_Summary_Report = pair.Value;
                    else if (pair.Key == "iframe_Day_of_Week_Statistics_Report")
                        iframe_Day_of_Week_Statistics_Report = pair.Value;
                    else if (pair.Key == "iframe_Day_of_Week_Analysis_Report")
                        iframe_Day_of_Week_Analysis_Report = pair.Value;
                    else if (pair.Key == "iframe_Daily_Analysis_PerPerson_Report")
                        iframe_Daily_Analysis_PerPerson_Report = pair.Value;
                    else if (pair.Key == "iframe_OTB_Comparison_by_Segment_Report")
                        iframe_OTB_Comparison_by_Segment_Report = pair.Value;
                    else if (pair.Key == "iframe_Daily_Pick_Up_Report")
                        iframe_Daily_Pick_Up_Report = pair.Value;
                    else if (pair.Key == "iframe_Revenue_By_Room_Product_Report")
                        iframe_Revenue_By_Room_Product_Report = pair.Value;
                    else if (pair.Key == "iframe_Pickup_by_Market_Segment_Report")
                        iframe_Pickup_by_Market_Segment_Report = pair.Value;
                    else if (pair.Key == "iframe_OTB_Comparison_for_All_Segments_Report")
                        iframe_OTB_Comparison_for_All_Segments_Report = pair.Value;
                    else if (pair.Key == "iframe_OTB_vs_Budget_by_Segment_Report")
                        iframe_OTB_vs_Budget_by_Segment_Report = pair.Value;
                    else if (pair.Key == "iframe_OTB_vs_Forecast_by_Segment_Report")
                        iframe_OTB_vs_Forecast_by_Segment_Report = pair.Value;
                    else if (pair.Key == "iframe_Room_Type_Booked_vs_Occupied")
                        iframe_Room_Type_Booked_vs_Occupied = pair.Value;
                    else if (pair.Key == "iframe_Access_Log")
                        iframe_Access_Log = pair.Value;
                    else if (pair.Key == "iframe_Parent_Company")
                        iframe_Parent_Company = pair.Value;
                    else if (pair.Key == "Click_Add_New_Parent_Company")
                        Click_Add_New_Parent_Company = pair.Value;
                    else if (pair.Key == "Click_Add_New_Parent_Company_Save_Button")
                        Click_Add_New_Parent_Company_Save_Button = pair.Value;
                    else if (pair.Key == "Enter_Parent_Company_Name")
                        Enter_Parent_Company_Name = pair.Value;
                    else if (pair.Key == "Click_Parent_Company_Name_Edit_Link")
                        Click_Parent_Company_Name_Edit_Link = pair.Value;
                    else if (pair.Key == "Click_Add_New_Parent_Company_Close_Button")
                        Click_Add_New_Parent_Company_Close_Button = pair.Value;
                    else if (pair.Key == "iframe_Add_Parent_Company_PopUp")
                        iframe_Add_Parent_Company_PopUp = pair.Value;
                    else if (pair.Key == "iframe_User_Access_Report")
                        iframe_User_Access_Report = pair.Value;
                    else if (pair.Key == "iframe_Best_Available_Rate_Contribution_Report")
                        iframe_Best_Available_Rate_Contribution_Report = pair.Value;
                    else if (pair.Key == "iframe_Total_Revenue_Analysis_Report")
                        iframe_Total_Revenue_Analysis_Report = pair.Value;
                    else if (pair.Key == "iframe_User_Maintenance")
                        iframe_User_Maintenance = pair.Value;
                    else if (pair.Key == "Click_User_Maintenance_Edit_Link")
                        Click_User_Maintenance_Edit_Link = pair.Value;
                    else if (pair.Key == "Click_User_Role_Test_Role")
                        Click_User_Role_Test_Role = pair.Value;
                    else if (pair.Key == "Click_Role_Maintenance")
                        Click_Role_Maintenance = pair.Value;
                    else if (pair.Key == "Click_Role_Maintenance_Edit_Link_for_Test_Custom")
                        Click_Role_Maintenance_Edit_Link_for_Test_Custom = pair.Value;
                    else if (pair.Key == "Click_Role_Report_Tab")
                        Click_Role_Report_Tab = pair.Value;
                    else if (pair.Key == "Click_Role_Tenants_Tab")
                        Click_Role_Tenants_Tab = pair.Value;
                    else if (pair.Key == "iframe_Maintain_User")
                        iframe_Maintain_User = pair.Value;
                    else if (pair.Key == "iframe_Role_Maintenance_PopUp")
                        iframe_Role_Maintenance_PopUp = pair.Value;
                    else if (pair.Key == "iframe_Role_Maintenance")
                        iframe_Role_Maintenance = pair.Value;
                    else if (pair.Key == "iframe_Hotel_Dashboard")
                        iframe_Hotel_Dashboard = pair.Value;
                    else if (pair.Key == "Dashboard_Hotel_RadioButton")
                        Dashboard_Hotel_RadioButton = pair.Value;
                    else if (pair.Key == "Dashboard_Portfolio_RadioButton")
                        Dashboard_Portfolio_RadioButton = pair.Value;
                    else if (pair.Key == "Hotel_Dashboard_Summary")
                        Hotel_Dashboard_Summary = pair.Value;
                    else if (pair.Key == "Hotel_Dashboard_Detail")
                        Hotel_Dashboard_Detail = pair.Value;
                    else if (pair.Key == "Hotel_Dashboard_ADR_Radio_button")
                        Hotel_Dashboard_ADR_Radio_button = pair.Value;
                    else if (pair.Key == "Hotel_Dashboard_Room_Revenue_Radio_button")
                        Hotel_Dashboard_Room_Revenue_Radio_button = pair.Value;
                    else if (pair.Key == "Hotel_Dashboard_Room_Sold_button")
                        Hotel_Dashboard_Room_Sold_button = pair.Value;
                    else if (pair.Key == "iframe_Agent_Dashboard")
                        iframe_Agent_Dashboard = pair.Value;
                    else if (pair.Key == "Click_Dashboard_Update_Button")
                        Click_Dashboard_Update_Button = pair.Value;
                    else if (pair.Key == "Enter_Dashboard_Pickup_Start")
                        Enter_Dashboard_Pickup_Start = pair.Value;
                    else if (pair.Key == "Enter_Dashboard_Pickup_End")
                        Enter_Dashboard_Pickup_End = pair.Value;
                    else if (pair.Key == "Click_Dashboard_Excel_Icon")
                        Click_Dashboard_Excel_Icon = pair.Value;
                    else if (pair.Key == "iframe_Monthly_Pickup")
                        iframe_Monthly_Pickup = pair.Value;
                    else if (pair.Key == "Click_Dashboard_Currency_DDL")
                        Click_Dashboard_Currency_DDL = pair.Value;
                    else if (pair.Key == "Click_Dashboard_Hotel_OR_Portfolio_DDL")
                        Click_Dashboard_Hotel_OR_Portfolio_DDL = pair.Value;
                    else if (pair.Key == "Click_Dashboard_Business_DDL")
                        Click_Dashboard_Business_DDL = pair.Value;
                    else if (pair.Key == "Dashboard_Enter_StartDate")
                        Dashboard_Enter_StartDate = pair.Value;
                    else if (pair.Key == "Dashboard_Enter_EndDate")
                        Dashboard_Enter_EndDate = pair.Value;
                    else if (pair.Key == "iframe_Company_Dashboard")
                        iframe_Company_Dashboard = pair.Value;
                    else if (pair.Key == "CompanyDashboard_Enter_StartDate")
                        CompanyDashboard_Enter_StartDate = pair.Value;
                    else if (pair.Key == "CompanyDashboard_Enter_EndDate")
                        CompanyDashboard_Enter_EndDate = pair.Value;
                    else if (pair.Key == "Click_CompanyDashboard_Update_Button")
                        Click_CompanyDashboard_Update_Button = pair.Value;
                    else if (pair.Key == "iframe_Market_Dashboard")
                        iframe_Market_Dashboard = pair.Value;
                    else if (pair.Key == "iframe_Channel_Dashboard")
                        iframe_Channel_Dashboard = pair.Value;
                    else if (pair.Key == "iframe_Room_Type_Dashboard")
                        iframe_Room_Type_Dashboard = pair.Value;
                    else if (pair.Key == "iframe_Negotiated_Dashboard")
                        iframe_Negotiated_Dashboard = pair.Value;
                    else if (pair.Key == "iframe_Pace_Dashboard")
                        iframe_Pace_Dashboard = pair.Value;
                    else if (pair.Key == "Pace_Dashboard_StartDate")
                        Pace_Dashboard_StartDate = pair.Value;
                    else if (pair.Key == "Pace_Dashboard_EndDate")
                        Pace_Dashboard_EndDate = pair.Value;
                    else if (pair.Key == "Pace_Dashboard_Update_Button")
                        Pace_Dashboard_Update_Button = pair.Value;
                    else if (pair.Key == "iframe_Channel_Report")
                        iframe_Channel_Report = pair.Value;
                    else if (pair.Key == "iframe_Channel_Trend_Report")
                        iframe_Channel_Trend_Report = pair.Value;
                    else if (pair.Key == "iframe_Daily_Channel_by_Room_Type_Report")
                        iframe_Daily_Channel_by_Room_Type_Report = pair.Value;

                    else if (pair.Key == "UserPreference_GetHotel")
                        UserPreference_GetHotel = pair.Value;
                    else if (pair.Key == "UserPreference_GetBusinessUnit")
                        UserPreference_GetBusinessUnit = pair.Value;
                    else if (pair.Key == "UserPreference_GetCurrency")
                        UserPreference_GetCurrency = pair.Value;

                    else if (pair.Key == "Monthly_Pickup_Hotel_Value")
                        Monthly_Pickup_Hotel_Value = pair.Value;
                    else if (pair.Key == "Monthly_Pickup_Currency_Value")
                        Monthly_Pickup_Currency_Value = pair.Value;
                    else if (pair.Key == "Monthly_Pickup_Business_Unit_Value")
                        Monthly_Pickup_Business_Unit_Value = pair.Value;
                    else if (pair.Key == "Hotel_Portfolio_Dropdown")
                        Hotel_Portfolio_Dropdown = pair.Value;
                    else if (pair.Key == "Business_Dropdown")
                        Business_Dropdown = pair.Value;
                    else if (pair.Key == "Currency_Dropdown")
                        Currency_Dropdown = pair.Value;
                    else if (pair.Key == "iframe_Business_Unit_Grouping")
                        iframe_Business_Unit_Grouping = pair.Value;
                    else if (pair.Key == "Enter_Business_Unit_Grouping_Code")
                        Enter_Business_Unit_Grouping_Code = pair.Value;
                    else if (pair.Key == "Enter_Business_Unit_Grouping_Name")
                        Enter_Business_Unit_Grouping_Name = pair.Value;
                    else if (pair.Key == "Saved_Business_Unit_Grouping")
                        Saved_Business_Unit_Grouping = pair.Value;
                    else if (pair.Key == "Click_Business_Unit_Grouping_TransferAllFrom_Button")
                        Click_Business_Unit_Grouping_TransferAllFrom_Button = pair.Value;
                    else if (pair.Key == "Click_Edit_Business_Unit_Grouping_button")
                        Click_Edit_Business_Unit_Grouping_button = pair.Value;
                    else if (pair.Key == "Delete_Business_Unit_Grouping_button")
                        Delete_Business_Unit_Grouping_button = pair.Value;
                    else if (pair.Key == "iframe_Add_Business_Unit_Group")
                        iframe_Add_Business_Unit_Group = pair.Value;

                    else if (pair.Key == "iframe_Room_Type_Mapping")
                        iframe_Room_Type_Mapping = pair.Value;
                    else if (pair.Key == "Click_Room_Type_Code")
                        Click_Room_Type_Code = pair.Value;
                    else if (pair.Key == "Click_Room_Type_Name")
                        Click_Room_Type_Name = pair.Value;
                    else if (pair.Key == "Click_Rooms_Counted")
                        Click_Rooms_Counted = pair.Value;
                    else if (pair.Key == "Click_Rooms_Product")
                        Click_Rooms_Product = pair.Value;
                    else if (pair.Key == "Click_Business_Unit")
                        Click_Business_Unit = pair.Value;

                    else if (pair.Key == "iframe_Market_Mapping")
                        iframe_Market_Mapping = pair.Value;
                    else if (pair.Key == "Click_PMS_Market_Code")
                        Click_PMS_Market_Code = pair.Value;
                    else if (pair.Key == "Click_revintel_Market_1")
                        Click_revintel_Market_1 = pair.Value;
                    else if (pair.Key == "Click_revintel_Market_2")
                        Click_revintel_Market_2 = pair.Value;

                    else if (pair.Key == "iframe_Channel_Mapping")
                        iframe_Channel_Mapping = pair.Value;
                    else if (pair.Key == "Click_PMS_Channel_Code")
                        Click_PMS_Channel_Code = pair.Value;
                    else if (pair.Key == "Click_revintel_Channel_1")
                        Click_revintel_Channel_1 = pair.Value;
                    else if (pair.Key == "Click_revintel_Channel_2")
                        Click_revintel_Channel_2 = pair.Value;

                    else if (pair.Key == "Rainmaker_Hotel_Dropdown")
                        Rainmaker_Hotel_Dropdown = pair.Value;
                    else if (pair.Key == "Rainmaker_Hotel_Value")
                        Rainmaker_Hotel_Value = pair.Value;
                    else if (pair.Key == "Click_Business_Unit_Group_Sort")
                        Click_Business_Unit_Group_Sort = pair.Value;
                    else if (pair.Key == "Maintenance_Edit_testaccess")
                        Maintenance_Edit_testaccess = pair.Value;

                    else if (pair.Key == "Enter_Room_Type_Name")
                        Enter_Room_Type_Name = pair.Value;
                    else if (pair.Key == "Click_Filter_Icon_Room_Type_Name")
                        Click_Filter_Icon_Room_Type_Name = pair.Value;
                    else if (pair.Key == "Filter_with_statsWith")
                        Filter_with_statsWith = pair.Value;
                    else if (pair.Key == "Enter_Market_Name")
                        Enter_Market_Name = pair.Value;
                    else if (pair.Key == "Click_Filter_Icon_Market_Name")
                        Click_Filter_Icon_Market_Name = pair.Value;
                    else if (pair.Key == "Enter_Channel_Name")
                        Enter_Channel_Name = pair.Value;
                    else if (pair.Key == "Click_Filter_Icon_Channel_Name")
                        Click_Filter_Icon_Channel_Name = pair.Value;

                    else if (pair.Key == "Click_RoomTypeAnalysis_ComparisonYear_DDM")
                        Click_RoomTypeAnalysis_ComparisonYear_DDM = pair.Value;
                    else if (pair.Key == "Select_RoomTypeAnalysis_ComparisonYear1")
                        Select_RoomTypeAnalysis_ComparisonYear1 = pair.Value;
                    else if (pair.Key == "Select_RoomTypeAnalysis_ComparisonYear2")
                        Select_RoomTypeAnalysis_ComparisonYear2 = pair.Value;
                    else if (pair.Key == "Select_RoomTypeAnalysis_ComparisonYear3")
                        Select_RoomTypeAnalysis_ComparisonYear3 = pair.Value;
                    
                    else if (pair.Key == "Click_Compose_Menu")
                        Click_Compose_Menu = pair.Value;
                    else if (pair.Key == "Click_Compose_new_report")
                        Click_Compose_new_report = pair.Value;
                    else if (pair.Key == "Click_Compose_Create_New_Report_Close_Icon")
                        Click_Compose_Create_New_Report_Close_Icon = pair.Value;
                    else if (pair.Key == "Click_Compose_Create_New_Report_Cancel_button")
                        Click_Compose_Create_New_Report_Cancel_button = pair.Value;
                    else if (pair.Key == "iframe_Compose")
                        iframe_Compose = pair.Value;
                    else if (pair.Key == "Click_Compose_FullscreenButton")
                        Click_Compose_FullscreenButton = pair.Value;
                    else if (pair.Key == "Click_Compose_NewReport_Create_button")
                        Click_Compose_NewReport_Create_button = pair.Value;
                    else if (pair.Key == "Compose_Users_Report")
                        Compose_Users_Report = pair.Value;
                    else if (pair.Key == "Compose_Users_Report_HeaderName")
                        Compose_Users_Report_HeaderName = pair.Value;
                    else if (pair.Key == "Compose_Users_Report_HeaderName_Edit")
                        Compose_Users_Report_HeaderName_Edit = pair.Value;
                    else if (pair.Key == "Compose_Users_Report_HeaderName_Edit_CancelButton")
                        Compose_Users_Report_HeaderName_Edit_CancelButton = pair.Value;
                    else if (pair.Key == "Compose_Users_Report_HeaderName_CloseButton")
                        Compose_Users_Report_HeaderName_CloseButton = pair.Value;
                    else if (pair.Key == "Compose_Enter_NewReport_Name")
                        Compose_Enter_NewReport_Name = pair.Value;
                    else if (pair.Key == "Compose_UserReport_Delete")
                        Compose_UserReport_Delete = pair.Value;
                    else if (pair.Key == "Compose_UserReport_DeleteReport_Delete_Button")
                        Compose_UserReport_DeleteReport_Delete_Button = pair.Value;
                    else if (pair.Key == "Compose_Rename_Button")
                        Compose_Rename_Button = pair.Value;
                    else if (pair.Key == "Update_compose_report_Name")
                        Update_compose_report_Name = pair.Value;
                    else if (pair.Key == "Click_SubmitRequest") 
                        Click_SubmitRequest = pair.Value;

                    else if (pair.Key == "Enter_Start_Month") 
                        Enter_Start_Month = pair.Value;
                    


                }


                else if (nodeModule == Constants.BusinessSource)
                {
                    if (pair.Key == "Click_AgentRoomTypeAnalysis")
                        Click_AgentRoomTypeAnalysis = pair.Value;
                    else if (pair.Key == "iframe_Agent_Room_Type_Analysis")
                        iframe_Agent_Room_Type_Analysis = pair.Value;
                    else if (pair.Key == "BookingStartDate")
                        BookingStartDate = pair.Value;
                    else if (pair.Key == "BookingEndDate")
                        BookingEndDate = pair.Value;
                    else if (pair.Key == "Click_Annual_Agent_Analysis_by_Month")
                        Click_Annual_Agent_Analysis_by_Month = pair.Value;
                    else if (pair.Key == "iframe_Annual_Agent_Analysis_by_Month")
                        iframe_Annual_Agent_Analysis_by_Month = pair.Value;
                    else if (pair.Key == "Year_DDL")
                        Year_DDL = pair.Value;
                    else if (pair.Key == "Year_value")
                        Year_value = pair.Value;
                    else if (pair.Key == "Click_Company_Analysis")
                        Click_Company_Analysis = pair.Value;
                    else if (pair.Key == "iframe_Company_Analysis")
                        iframe_Company_Analysis = pair.Value;
                    else if (pair.Key == "kerner_Portfolio")
                        kerner_Portfolio = pair.Value;
                    else if (pair.Key == "Click_Annual_Company_Analysis_by_Month")
                        Click_Annual_Company_Analysis_by_Month = pair.Value;
                    else if (pair.Key == "iframe_Annual_Company_Analysis_by_Month")
                        iframe_Annual_Company_Analysis_by_Month = pair.Value;
                    else if (pair.Key == "Annual_Company_Analysis_by_Month_CompanyDDL")
                        Annual_Company_Analysis_by_Month_CompanyDDL = pair.Value;
                    else if (pair.Key == "Annual_Company_Analysis_by_Month_Company_Select")
                        Annual_Company_Analysis_by_Month_Company_Select = pair.Value;
                    else if (pair.Key == "Click_Company_Summary")
                        Click_Company_Summary = pair.Value;
                    else if (pair.Key == "iframe_Company_Summary")
                        iframe_Company_Summary = pair.Value;
                    else if (pair.Key == "Company_Summary_Portfolio")
                        Company_Summary_Portfolio = pair.Value;
                    else if (pair.Key == "iframe_AgentSummary")
                        iframe_AgentSummary = pair.Value;
                }

                else if (nodeModule == Constants.ReportScheduler)
                {
                    if (pair.Key == "Click_BookingTrends")
                        Click_BookingTrends = pair.Value;
                    else if (pair.Key == "Click_BookingTrends_ChannelPaceAnalysis")
                        Click_BookingTrends_ChannelPaceAnalysis = pair.Value;
                    else if (pair.Key == "Click_BookingTrends_PickUpByDayDetailed")
                        Click_BookingTrends_PickUpByDayDetailed = pair.Value;
                    else if (pair.Key == "Enter_ChannelPaceAnalysis_RelativeStartDate")
                        Enter_ChannelPaceAnalysis_RelativeStartDate = pair.Value;
                    else if (pair.Key == "Enter_ChannelPaceAnalysis_RelativeEndDate")
                        Enter_ChannelPaceAnalysis_RelativeEndDate = pair.Value;
                    else if (pair.Key == "Enter_ChannelPaceAnalysis_StartDate")
                        Enter_ChannelPaceAnalysis_StartDate = pair.Value;
                    else if (pair.Key == "Enter_ChannelPaceAnalysis_EndDate")
                        Enter_ChannelPaceAnalysis_EndDate = pair.Value;
                    else if (pair.Key == "Enter_PickUpByDayDetailed_RelativeStartDate")
                        Enter_PickUpByDayDetailed_RelativeStartDate = pair.Value;
                    else if (pair.Key == "Enter_PickUpByDayDetailed_RelativeEndDate")
                        Enter_PickUpByDayDetailed_RelativeEndDate = pair.Value;
                    else if (pair.Key == "Enter_PickUpByDayDetailed_RelativePickupStartDate")
                        Enter_PickUpByDayDetailed_RelativePickupStartDate = pair.Value;
                    else if (pair.Key == "Enter_PickUpByDayDetailed_RelativePickupEndDate")
                        Enter_PickUpByDayDetailed_RelativePickupEndDate = pair.Value;
                    else if (pair.Key == "Enter_PickUpByDayDetailed_StartDate")
                        Enter_PickUpByDayDetailed_StartDate = pair.Value;
                    else if (pair.Key == "Enter_PickUpByDayDetailed_EndDate")
                        Enter_PickUpByDayDetailed_EndDate = pair.Value;
                    else if (pair.Key == "Enter_PickUpByDayDetailed_PickupStartDate")
                        Enter_PickUpByDayDetailed_PickupStartDate = pair.Value;
                    else if (pair.Key == "Enter_PickUpByDayDetailed_PickupEndDate")
                        Enter_PickUpByDayDetailed_PickupEndDate = pair.Value;
                    else if (pair.Key == "Click_BusinessSource")
                        Click_BusinessSource = pair.Value;
                    else if (pair.Key == "Click_BusinessSource_RoomTypeAnalysis")
                        Click_BusinessSource_RoomTypeAnalysis = pair.Value;
                    else if (pair.Key == "Click_BusinessSource_MarketReport")
                        Click_BusinessSource_MarketReport = pair.Value;
                    else if (pair.Key == "Enter_ReportDescription")
                        Enter_ReportDescription = pair.Value;
                    else if (pair.Key == "Click_Tuesday")
                        Click_Tuesday = pair.Value;
                    else if (pair.Key == "Click_Wednesday")
                        Click_Wednesday = pair.Value;
                    else if (pair.Key == "Click_Thursday")
                        Click_Thursday = pair.Value;
                    else if (pair.Key == "Click_Friday")
                        Click_Friday = pair.Value;
                    else if (pair.Key == "Enter_StartTimeHours")
                        Enter_StartTimeHours = pair.Value;
                    else if (pair.Key == "Enter_StartTimeMinutes")
                        Enter_StartTimeMinutes = pair.Value;
                    else if (pair.Key == "Enter_RendorFormat")
                        Enter_RendorFormat = pair.Value;
                    else if (pair.Key == "Enter_EmailTo")
                        Enter_EmailTo = pair.Value;
                    else if (pair.Key == "Enter_EmailSubject")
                        Enter_EmailSubject = pair.Value;
                    else if (pair.Key == "Enter_RelativeStartDateOffset")
                        Enter_RelativeStartDateOffset = pair.Value;
                    else if (pair.Key == "Enter_RelativeEndDateOffset")
                        Enter_RelativeEndDateOffset = pair.Value;
                    else if (pair.Key == "Click_RoomTypeAnalysis_SaveButton")
                        Click_RoomTypeAnalysis_SaveButton = pair.Value;
                    else if (pair.Key == "Enter_AsOfDate")
                        Enter_AsOfDate = pair.Value;
                    else if (pair.Key == "Enter_RelativeAsOfDate")
                        Enter_RelativeAsOfDate = pair.Value;
                    else if (pair.Key == "Click_CurrentDate_RelativeSatrtDate")
                        Click_CurrentDate_RelativeSatrtDate = pair.Value;
                    else if (pair.Key == "Click_CurrentDate_RelativeEndDate")
                        Click_CurrentDate_RelativeEndDate = pair.Value;
                    else if (pair.Key == "Click_CurrentDate_RelativePickupSatrtDate")
                        Click_CurrentDate_RelativePickupSatrtDate = pair.Value;
                    else if (pair.Key == "Click_CurrentDate_RelativePickupEndDate")
                        Click_CurrentDate_RelativePickupEndDate = pair.Value;
                    else if (pair.Key == "Click_SelectDate_RelativeStartDate")
                        Click_SelectDate_RelativeStartDate = pair.Value;
                    else if (pair.Key == "Click_SelectDate_RelativeEndDate")
                        Click_SelectDate_RelativeEndDate = pair.Value;
                    else if (pair.Key == "Click_SelectDate_RelativePickupStartDate")
                        Click_SelectDate_RelativePickupStartDate = pair.Value;
                    else if (pair.Key == "Click_SelectDate_RelativePickupEndDate")
                        Click_SelectDate_RelativePickupEndDate = pair.Value;
                    else if (pair.Key == "Click_ReportType_Excel")
                        Click_ReportType_Excel = pair.Value;
                    else if (pair.Key == "Enter_OnCalendarDays")
                        Enter_OnCalendarDays = pair.Value;
                    else if (pair.Key == "Click_SaveSchedule_OkButton")
                        Click_SaveSchedule_OkButton = pair.Value;
                    else if (pair.Key == "Click_ManageReportSchedule_EditButton")
                        Click_ManageReportSchedule_EditButton = pair.Value;

                    else if (pair.Key == "Click_Month")
                        Click_Month = pair.Value;
                    else if (pair.Key == "Click_Once")
                        Click_Once = pair.Value;
                    else if (pair.Key == "Click_OnCalendarDays")
                        Click_OnCalendarDays = pair.Value;
                    else if (pair.Key == "Click_Quick_RelativeDate")
                        Click_Quick_RelativeDate = pair.Value;
                    else if (pair.Key == "Click_Quick_RelativeDateToday")
                        Click_Quick_RelativeDateToday = pair.Value;
                    else if (pair.Key == "Click_Quick_RelativePickupDate")
                        Click_Quick_RelativePickupDate = pair.Value;
                    else if (pair.Key == "Click_Quick_RelativePickupDateToday")
                        Click_Quick_RelativePickupDateToday = pair.Value;
                    else if (pair.Key == "Click_Quick_AbsoluteDate")
                        Click_Quick_AbsoluteDate = pair.Value;
                    else if (pair.Key == "Click_Quick_AbsoluteDateToday")
                        Click_Quick_AbsoluteDateToday = pair.Value;
                    else if (pair.Key == "Click_Quick_AbsolutePickupDate")
                        Click_Quick_AbsolutePickupDate = pair.Value;
                    else if (pair.Key == "Click_Quick_AbsolutePickupDateToday")
                        Click_Quick_AbsolutePickupDateToday = pair.Value;


                    else if (pair.Key == "Click_RelativeAsOfDate_Currentmonth")
                        Click_RelativeAsOfDate_Currentmonth = pair.Value;
                    else if (pair.Key == "Click_RelativeAsOfDate_Offset")
                        Click_RelativeAsOfDate_Offset = pair.Value;
                    else if (pair.Key == "Enter_RelativePickUpStartDateOffset")
                        Enter_RelativePickUpStartDateOffset = pair.Value;
                    else if (pair.Key == "Enter_RelativePickUpEndDateOffset")
                        Enter_RelativePickUpEndDateOffset = pair.Value;
                    else if (pair.Key == "Click_BookingTrends_PaceReport")
                        Click_BookingTrends_PaceReport = pair.Value;
                    else if (pair.Key == "Click_ManageReportSchedule_DeleteButton")
                        Click_ManageReportSchedule_DeleteButton = pair.Value;

                    else if (pair.Key == "Click_Quick_AbsoluteDateYesterday")
                        Click_Quick_AbsoluteDateYesterday = pair.Value;
                    else if (pair.Key == "Click_Quick_AbsoluteDateMTM")
                        Click_Quick_AbsoluteDateMTM = pair.Value;
                    else if (pair.Key == "Click_Quick_AbsoluteDateYTD")
                        Click_Quick_AbsoluteDateYTD = pair.Value;
                    else if (pair.Key == "Click_Quick_AbsoluteDateLastMonth")
                        Click_Quick_AbsoluteDateLastMonth = pair.Value;
                    else if (pair.Key == "Click_Quick_AbsoluteDateThisMonth")
                        Click_Quick_AbsoluteDateThisMonth = pair.Value;
                    else if (pair.Key == "Click_Quick_AbsoluteDateNextMonth")
                        Click_Quick_AbsoluteDateNextMonth = pair.Value;
                    else if (pair.Key == "Click_Quick_AbsoluteDateLastYear")
                        Click_Quick_AbsoluteDateLastYear = pair.Value;
                    else if (pair.Key == "Click_Quick_AbsoluteDateThisYear")
                        Click_Quick_AbsoluteDateThisYear = pair.Value;
                    else if (pair.Key == "Click_Quick_AbsoluteDateEndOfYear")
                        Click_Quick_AbsoluteDateEndOfYear = pair.Value;
                    else if (pair.Key == "Click_Quick_AbsolutePickupDateYesterday")
                        Click_Quick_AbsolutePickupDateYesterday = pair.Value;
                    else if (pair.Key == "Click_Quick_AbsolutePickupDateMTM")
                        Click_Quick_AbsolutePickupDateMTM = pair.Value;
                    else if (pair.Key == "Click_Quick_AbsolutePickupDateYTD")
                        Click_Quick_AbsolutePickupDateYTD = pair.Value;
                    else if (pair.Key == "Click_Quick_AbsolutePickupDateLastMonth")
                        Click_Quick_AbsolutePickupDateLastMonth = pair.Value;
                    else if (pair.Key == "Click_Quick_AbsolutePickupDateThisMonth")
                        Click_Quick_AbsolutePickupDateThisMonth = pair.Value;
                    else if (pair.Key == "Click_Quick_AbsolutePickupDateNextMonth")
                        Click_Quick_AbsolutePickupDateNextMonth = pair.Value;
                    else if (pair.Key == "Click_Quick_AbsolutePickupDateLastYear")
                        Click_Quick_AbsolutePickupDateLastYear = pair.Value;
                    else if (pair.Key == "Click_Quick_AbsolutePickupDateThisYear")
                        Click_Quick_AbsolutePickupDateThisYear = pair.Value;
                    else if (pair.Key == "Click_Quick_AbsolutePickupDateEndOfYear")
                        Click_Quick_AbsolutePickupDateEndOfYear = pair.Value;

                    else if (pair.Key == "Click_Quick_RelativeDateYesteraday")
                        Click_Quick_RelativeDateYesteraday = pair.Value;
                    else if (pair.Key == "Click_Quick_RelativeDateLastMonth")
                        Click_Quick_RelativeDateLastMonth = pair.Value;
                    else if (pair.Key == "Click_Quick_RelativeDateThisMonth")
                        Click_Quick_RelativeDateThisMonth = pair.Value;
                    else if (pair.Key == "Click_Quick_RelativeDateNextMonth")
                        Click_Quick_RelativeDateNextMonth = pair.Value;
                    else if (pair.Key == "Click_Quick_RelativeDateLastYear")
                        Click_Quick_RelativeDateLastYear = pair.Value;
                    else if (pair.Key == "Click_Quick_RelativeDateThisYear")
                        Click_Quick_RelativeDateThisYear = pair.Value;
                    else if (pair.Key == "Click_Quick_RelativePickupDateYesteraday")
                        Click_Quick_RelativePickupDateYesteraday = pair.Value;
                    else if (pair.Key == "Click_Quick_RelativePickupDateLastMonth")
                        Click_Quick_RelativePickupDateLastMonth = pair.Value;
                    else if (pair.Key == "Click_Quick_RelativePickupDateThisMonth")
                        Click_Quick_RelativePickupDateThisMonth = pair.Value;
                    else if (pair.Key == "Click_Quick_RelativePickupDateNextMonth")
                        Click_Quick_RelativePickupDateNextMonth = pair.Value;
                    else if (pair.Key == "Click_Quick_RelativePickupDateLastYear")
                        Click_Quick_RelativePickupDateLastYear = pair.Value;
                    else if (pair.Key == "Click_Quick_RelativePickupDateThisYear")
                        Click_Quick_RelativePickupDateThisYear = pair.Value;
                    else if (pair.Key == "Click_Portfolio")
                        Click_Portfolio = pair.Value;
                    else if (pair.Key == "Click_BookingTrends_AgentByHotel")
                        Click_BookingTrends_AgentByHotel = pair.Value;
                    else if (pair.Key == "Click_SelectType")
                        Click_SelectType = pair.Value;
                    else if (pair.Key == "ReportScheduler_GetHotel")
                        ReportScheduler_GetHotel = pair.Value;
                    else if (pair.Key == "ReportScheduler_GetBusinessUnit")
                        ReportScheduler_GetBusinessUnit = pair.Value;
                    else if (pair.Key == "ReportScheduler_GetCurrency")
                        ReportScheduler_GetCurrency = pair.Value;
                    else if (pair.Key == "Select_Blank_RelativeAsOfDate")
                        Select_Blank_RelativeAsOfDate = pair.Value;



                    else if (pair.Key == "Click_ReportParameter_Market")
                        Click_ReportParameter_Market = pair.Value;
                    else if (pair.Key == "Click_Market_MarketReport")
                        Click_Market_MarketReport = pair.Value;
                    else if (pair.Key == "Click_SelectType_Hotel")
                        Click_SelectType_Hotel = pair.Value;
                    else if (pair.Key == "Select_SelectType_Portfolio")
                        Select_SelectType_Portfolio = pair.Value;
                    else if (pair.Key == "Click_InvalidSelection_OkButton")
                        Click_InvalidSelection_OkButton = pair.Value;
                    else if (pair.Key == "Select_SelectType_Hotel")
                        Select_SelectType_Hotel = pair.Value;
                    else if (pair.Key == "Click_HotelOrPortfolio")
                        Click_HotelOrPortfolio = pair.Value;

                }
                else if (nodeModule == Constants.ExchangeRate)
                {
                    if (pair.Key == "Click_ViewAnalysis")
                        Click_ViewAnalysis = pair.Value;
                }
            }
            return obj;
        }
    }

}