using BaseUtility.Utility;
using InfoMessageLogger;
using NUnit.Framework;
using OpenQA.Selenium;
using RevIntel.PageObject.UI;

namespace RevIntel.AppModule.UI
{
    class Navigation
    {
        public static void Click_UAT()
        {
            Helper.ElementClick(PageObject_Navigation.Click_UAT());
        }
        public static void Tenant_21C()
        {
            Helper.ElementClick(PageObject_Navigation.Tenant_21C());
        }
        public static void Ocean_House()
        {
            Helper.ElementClick(PageObject_Navigation.Ocean_House());
        }

        public static void Click_ClientName(string clientName)
        {
            Helper.ElementClick(PageObject_Navigation.Link_ClientName(clientName));
        }
        public static void Link_MainMenu()
        {
            Helper.ElementClick(PageObject_Navigation.Link_MainMenu());
        }

        public static void AgentAnalysis()
        {
            Helper.ElementClick(PageObject_Navigation.AgentAnalysis());
        }
        public static void Agent_Summary()
        {
            Helper.ElementClick(PageObject_Navigation.Agent_Summary());
        }

        public static void BusinessSource()
        {
            Helper.DoubleClickElement(PageObject_Navigation.BusinessSource());
        }
        public static void Hotel()
        {
            Helper.DoubleClickElement(PageObject_Navigation.Hotel());
        }
        public static void Market()
        {
            Helper.DoubleClickElement(PageObject_Navigation.Market());
        }
        public static void Booking_Trends()
        {
            Helper.DoubleClickElement(PageObject_Navigation.Booking_Trends());
        }
        public static void Channel()
        {
            Helper.ElementClick(PageObject_Navigation.Channel());
        }
        public static void Forecast_and_Budget()
        {
            Helper.DoubleClickElement(PageObject_Navigation.Forecast_and_Budget());
            Logger.WriteDebugMessage("Click on Forecast and Bugest Menu.");
        }
        public static void Adhoc()
        {
            Helper.ElementClick(PageObject_Navigation.Adhoc());
        }
        public static void Geo_Source()
        {
            Helper.ElementClick(PageObject_Navigation.Geo_Source());
        }

        public static void Portfolio()
        {
            Helper.ElementClick(PageObject_Navigation.Portfolio());
        }

        public static void Portfolio_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Portfolio_Report());
        }
        public static void Click_Menu_Room_Type()
        {
            Helper.ElementClick(PageObject_Navigation.Room_Type());
        }
        public static void Click_Menu_Room_Type_Analysis()
        {
            Helper.ElementClick(PageObject_Navigation.Room_Type_Analysis());
        }
        public static void Click_Hamburger_Icon()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Hamburger_Icon());
        }
        public static void Select_Client(string client)
        {
            Click_Automation();
            Logger.WriteDebugMessage("user landed on the Automation RevIntel client selection page");
            Helper.PageDown();
            Logger.WriteDebugMessage("Client displayed");
            Click_ClientName(client);
            Logger.WriteDebugMessage(client + " selected");
            Helper.AddDelay(10000);
            Logger.WriteDebugMessage("User landed on Montly pickup Dashboard page");
        }
        public static void Select_Client_UAT(string client)
        {

            Navigation.Click_UAT();
            Logger.WriteDebugMessage("user landed on the UAT RevIntel client selection page");
            Helper.PageDown();
            Logger.WriteDebugMessage("Client displayed");
            Navigation.Click_ClientName(client);
            Logger.WriteDebugMessage(client + " selected");
            Helper.AddDelay(10000);
            Logger.WriteDebugMessage("User landed on Montly pickup Dashboard page");
        }
        public static void Select_AgentAnalysis()
        {
            Helper.ElementHover(PageObject_Navigation.BusinessSource());
            Navigation.AgentAnalysis();
            Logger.WriteDebugMessage("Agent Analysis report selected");
            Navigation.BusinessSource();
            Helper.AddDelay(1000);
            Logger.WriteDebugMessage("Agent Analysis gets displayed");
        }

        public static void Menu_Reports()
        {

            Helper.DoubleClickElement(PageObject_Navigation.Hotel());
            Logger.WriteDebugMessage("Hotel Dropdown displayed");

            Helper.DoubleClickElement(PageObject_Navigation.BusinessSource());
            Logger.WriteDebugMessage("Click_BusinessSource_menu DropDown displayed");

            Helper.DoubleClickElement(PageObject_Navigation.Market());
            Logger.WriteDebugMessage("Market DropDown displayed");

            Helper.DoubleClickElement(PageObject_Navigation.Booking_Trends());
            Logger.WriteDebugMessage("Booking_Trends Dropdown displayed");

            Helper.DoubleClickElement(PageObject_Navigation.Channel());
            Logger.WriteDebugMessage("Channel Dropdown displayed");

            Helper.DoubleClickElement(PageObject_Navigation.Forecast_and_Budget());
            Logger.WriteDebugMessage("Forecast_and_Budget Dropdown displayed");

            Helper.DoubleClickElement(PageObject_Navigation.Adhoc());
            Logger.WriteDebugMessage("Adhoc Dropdown displayed");

            Navigation.Click_Hamburger_Icon();
            Logger.WriteDebugMessage("All reports under Hamburger_Icon dropdown Displayed");
        }
        public static void user_preferences()
        {
            Helper.ElementClick(PageObject_Navigation.user_preferences());
        }
        public static void user_preferences_Hotel()
        {
            Helper.ElementClick(PageObject_Navigation.user_preferences_Hotel());
        }
        public static void user_preferences_Hotel_select()
        {
            Helper.ElementClick(PageObject_Navigation.user_preferences_Hotel_select());
        }
        public static void user_preferences_Currency()
        {
            Helper.ElementClick(PageObject_Navigation.user_preferences_Currency());
        }
        public static void user_preferences_Currency_Select()
        {
            Helper.ElementClick(PageObject_Navigation.user_preferences_Currency_Select());
        }
        public static void user_preferences_Save()
        {
            Helper.ElementClick(PageObject_Navigation.user_preferences_Save());
        }
        public static void Iframe_user_preferences()
        {
            Helper.ElementClick(PageObject_Navigation.Iframe_user_preferences());
        }
        public static void user_preferences_Close()
        {
            Helper.ElementClick(PageObject_Navigation.user_preferences_Close());
        }

        public static void Portal()
        {
            Helper.ElementClick(PageObject_Navigation.Portal());
        }

        public static void Help_Menu()
        {
            Helper.DoubleClickElement(PageObject_Navigation.Help_Menu());
            Logger.WriteDebugMessage("Help menu displayed");
            Navigation.Training();
            Helper.AddDelay(20000);
            Logger.WriteDebugMessage("Landed on Taining page");
            
            Helper.DoubleClickElement(PageObject_Navigation.Help_Menu());
            Logger.WriteDebugMessage("Help menu displayed");
            Navigation.Release_note();
            Helper.AddDelay(20000);
            Logger.WriteDebugMessage("Landed on Release note page");
        }
        public static void Training()
        {
            Helper.ElementClick(PageObject_Navigation.Training());
        }
        public static void Release_note()
        {
            Helper.ElementClick(PageObject_Navigation.Release_note());
        }
        public static void user_preferences_Hotel_Default()
        {
            Helper.ElementClick(PageObject_Navigation.user_preferences_Hotel_Default());
        }
        public static void user_preferences_Currency_Default()
        {
            Helper.ElementClick(PageObject_Navigation.user_preferences_Currency_Default());
        }
        public static void Administration()
        {
            Helper.ElementClick(PageObject_Navigation.Administration());
        }
        public static void User_Maintenance()
        {
            Helper.ElementClick(PageObject_Navigation.User_Maintenance());
        }
        public static void Add_New_User()
        {
            Helper.ElementClick(PageObject_Navigation.Add_New_User());
        }
        public static void Iframe_user_Maintenance()
        {
            Helper.ElementClick(PageObject_Navigation.Iframe_user_Maintenance());
        }
        public static void user_Maintenance_Save()
        {
            Helper.ElementClick(PageObject_Navigation.user_Maintenance_Save());
        }
        public static void user_Maintenance_Close()
        {
            Helper.ElementClick(PageObject_Navigation.user_Maintenance_Close());
        }

        public static void user_Id(string str)
        {
            Helper.ElementEnterText(PageObject_Navigation.user_Id(), str);
        }
        public static void Add_User_Email(string str)
        {
            Helper.ElementEnterText(PageObject_Navigation.Add_User_Email(), str);
        }
        public static void Add_User_FirstName(string str)
        {
            Helper.ElementEnterText(PageObject_Navigation.Add_User_FirstName(), str);
        }
        public static void Add_User_LastName(string str)
        {
            Helper.ElementEnterText(PageObject_Navigation.Add_User_LastName(), str);
        }

        public static void Select_Available_Hotels()
        {
            Helper.ElementClick(PageObject_Navigation.Select_Available_Hotels());
        }
        public static void Iframe_Add_User()
        {
            Helper.ElementClick(PageObject_Navigation.Iframe_Add_User());
        }
        public static void Corporate_Portfolio()
        {
            Helper.ElementClick(PageObject_Navigation.Corporate_Portfolio());
        }
        public static void Add_New_Portfolio()
        {
            Helper.ElementClick(PageObject_Navigation.Add_New_Portfolio());
        }
        public static void iframe_New_Portfolio()
        {
            Helper.ElementClick(PageObject_Navigation.iframe_New_Portfolio());
        }
        public static void Portfolio_name(string str)
        {
            Helper.ElementEnterText(PageObject_Navigation.Portfolio_name(), str);
        }
        public static void Pace_Forecast_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Pace_Forecast_Report());
            Logger.WriteDebugMessage("Clicked on Forecast and Pace Report.");
        }
        public static void iFrame_Pace_Forecast_Report()
        {
            Helper.ElementClick(PageObject_Navigation.iFrame_Pace_Forecast_Report());
        }

        public static void Parent_Company_Analysis()
        {
            Helper.ElementClick(PageObject_Navigation.Parent_Company_Analysis());
        }

        public static void Parent_Travel_Agent_Analysis()
        {
            Helper.ElementClick(PageObject_Navigation.Parent_Travel_Agent_Analysis());
        }
        public static void Company_Period_Summary()
        {
            Helper.ElementClick(PageObject_Navigation.Company_Period_Summary());
        }
        public static void Agent_Period_Summary()
        {
            Helper.ElementClick(PageObject_Navigation.Agent_Period_Summary());
        }
        public static void Agent_Trend_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Agent_Trend_Report());
        }
        public static void Company_Trend_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Company_Trend_Report());
        }
        public static void Agent_By_Hotel()
        {
            Helper.ElementClick(PageObject_Navigation.Agent_By_Hotel());
        }

        public static void Channel_By_Hotel()
        {
            Helper.ElementClick(PageObject_Navigation.Channel_By_Hotel());
        }

        public static void Company_By_Hotel()
        {
            Helper.ElementClick(PageObject_Navigation.Company_By_Hotel());
        }

        public static void Market_By_Hotel_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Market_By_Hotel_Report());
        }
        public static void Province_and_State_By_Hotel()
        {
            Helper.ElementClick(PageObject_Navigation.Province_and_State_By_Hotel());
        }
        public static void Room_Type_By_Hotel()
        {
            Helper.ElementClick(PageObject_Navigation.Room_Type_By_Hotel());
        }
        public static void Source_Market_By_Hotel()
        {
            Helper.ElementClick(PageObject_Navigation.Source_Market_By_Hotel());
        }
        public static void Pace_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Pace_Report());
        }
        public static void Pace_Trend()
        {
            Helper.ElementClick(PageObject_Navigation.Pace_Trend());
        }
        public static void Daily_Pace_and_Pickup_Analysis()
        {
            Helper.ElementClick(PageObject_Navigation.Daily_Pace_and_Pickup_Analysis());
        }
        public static void Pace_and_Pickup_Analysis()
        {
            Helper.ElementClick(PageObject_Navigation.Pace_and_Pickup_Analysis());
        }
        public static void Rate_Code_Pace_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Rate_Code_Pace_Report());
        }
        public static void Channel_By_Room_Type_Pace()
        {
            Helper.ElementClick(PageObject_Navigation.Channel_By_Room_Type_Pace());
        }
        public static void Channel_Pace_Analysis()
        {
            Helper.ElementClick(PageObject_Navigation.Channel_Pace_Analysis());
        }
        public static void Pickup_By_Day()
        {
            Helper.ElementClick(PageObject_Navigation.Pickup_By_Day());
        }


        public static void Annual_Pickup_by_Day()
        {
            Helper.ElementClick(PageObject_Navigation.Annual_Pickup_by_Day());
        }
        public static void Length_of_Stay_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Length_of_Stay_Report());
        }
        public static void Rooms_Lead_Time()
        {
            Helper.ElementClick(PageObject_Navigation.Rooms_Lead_Time());
        }
        public static void Pickup_By_Day_Detailed()
        {
            Helper.ElementClick(PageObject_Navigation.Pickup_By_Day_Detailed());
        }
        public static void Monthly_Pickup()
        {
            Helper.ElementClick(PageObject_Navigation.Monthly_Pickup());
        }
        public static void Production_Patterns()
        {
            Helper.ElementClick(PageObject_Navigation.Production_Patterns());
        }
        public static void High_Occupancy_Night_By_Day()
        {
            Helper.ElementClick(PageObject_Navigation.High_Occupancy_Night_By_Day());
        }
        public static void Sold_Out_Night_Analysis()
        {
            Helper.ElementClick(PageObject_Navigation.Sold_Out_Night_Analysis());
        }
        public static void Cancellation_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Cancellation_Report());
        }

        public static void Click_Automation()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Automation());
        }

        public static void Click_TA()
        {
            Helper.ElementClick(PageObject_Navigation.Click_TA());
        }
        public static void Click_change_password()
        {
            Helper.ElementClick(PageObject_Navigation.Click_change_password());
        }
        public static void Change_password_Cancel_button()
        {
            Helper.ElementClick(PageObject_Navigation.Change_password_Cancel_button());
        }
        public static void Enter_Current_Password(string str)
        {
            Helper.ElementEnterText(PageObject_Navigation.Enter_Current_Password(), str);
        }
        public static void Enter_New_Password(string str)
        {
            Helper.ElementEnterText(PageObject_Navigation.Enter_New_Password(), str);
        }
        public static void Enter_Confirm_Password(string str)
        {
            Helper.ElementEnterText(PageObject_Navigation.Enter_Confirm_Password(), str);
        }
        public static void Click_Change_Password_button()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Change_Password_button());
        }

        public static void Check_Change_Password_button_Disable()
        {
            
            if (PageObject_Navigation.Click_Change_Password_button().Displayed)
            {
                Click_Change_Password_button();
                Logger.WriteDebugMessage("Change Password button is in disabled  mode ");
            }
            else
                Assert.Fail("Change Password button is in Eabled  mode ");
        }

        public static string incorrect_current_password_validation()
        {
            return Helper.GetText(PageObject_Navigation.incorrect_current_password_validation());

        }

        public static void Click_RS()
        {
            Helper.ElementClick(PageObject_Navigation.Click_RS());
        }

        public static void Market_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Market_Report());
        }
        public static void Click_Help_Icon()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Help_Icon());
        }
        public static void Enter_Help_Text(string value)
        {
            Helper.ElementEnterText(PageObject_Navigation.Enter_Help_Text(), value);
            Helper.Keyboard_Enter();

        }
        public static void Click_Contact_us_Icon()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Contact_us_Icon());
        }
        public static void Click_Portal_Update_Button()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Portal_Update_Button());
        }
        public static void Click_Link_Portal()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Link_Portal());
        }
        public static void Click_Menu_Portfolio()
        {
            Helper.DoubleClickElement(PageObject_Navigation.Portfolio());
        }
        public static void Click_Portfolio_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Portfolio_Report());
        }

        public static void Click_AgentAnalysis_Report()
        {
            Helper.ElementClick(PageObject_Navigation.AgentAnalysis());
        }
        public static void Click_Menu_Hotel()
        {
            Helper.DoubleClickElement(PageObject_Navigation.Hotel());
        }
        public static void Click_Hotel_Event_Calendar_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Hotel_Event_Calendar());
        }
        public static void Click_Menu_Market()
        {
            Helper.DoubleClickElement(PageObject_Navigation.Click_Menu_Market());
        }
        public static void Click_Market_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Market_Report());
        }
        public static void Click_Menu_Booking_Trends()
        {
            Helper.DoubleClickElement(PageObject_Navigation.Booking_Trends());
        }
        public static void Click_Length_of_Stay_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Length_of_Stay_Report());
        }
        public static void Click_Menu_Channel()
        {
            Helper.DoubleClickElement(PageObject_Navigation.Channel());
        }
        public static void Click_Channel_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Channel_Report());
        }
        public static void Click_Menu_Forecast_and_Budget()
        {
            Helper.DoubleClickElement(PageObject_Navigation.Forecast_and_Budget());
        }
        public static void Click_Pace_and_Forecast_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Pace_and_Forecast_Report());
        }
        public static void Click_Menu_Adhoc()
        {
            Helper.DoubleClickElement(PageObject_Navigation.Adhoc());
        }
        public static void Click_Menu_Adhoc_SingleClick()
        {
            Helper.ElementClick(PageObject_Navigation.Adhoc());
        }

        public static void Click_Stay_Graph_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Stay_Graph());
        }
        public static void Click_Link_Hotel_Dashboard()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Link_Hotel_Dashboard());
        }
        public static void Click_Help_Icon_Minimize()
        {
            Helper.EnterFrame("webWidget");
            Helper.ElementClick(PageObject_Navigation.Click_Help_Icon_Minimize());
            Helper.ExitFrame();
        }

        public static void VerifyHelpIcon(string PageName)
        {
            Helper.EnterFrame("launcher");
            if (PageObject_Navigation.Click_Help_Icon().Displayed)
            {
                Click_Help_Icon();
                Logger.WriteDebugMessage("Landed on " + PageName + " Page and Help Icon is present");
                Helper.ExitFrame();
                Click_Help_Icon_Minimize();
            }
            else
                Assert.Fail("Help Icon is not present on the page");
        }
        public static bool Verify_Help_Top_Suggestion(string value)
        {
            return PageObject_Navigation.Verify_Help_Top_Suggestion(value).Displayed;
        }
        public static void Enter_Contact_Name(string str)
        {
            Helper.ElementEnterText(PageObject_Navigation.Enter_Contact_Name(), str);
        }
        public static void Enter_Contact_Email(string str)
        {
            Helper.ElementEnterText(PageObject_Navigation.Enter_Contact_Email(), str);
        }
        public static void Enter_Contact_Subject(string str)
        {
            Helper.ElementEnterText(PageObject_Navigation.Enter_Contact_Subject(), str);
        }
        public static void Enter_Contact_Property(string str)
        {
            Helper.ElementEnterText(PageObject_Navigation.Enter_Contact_Property(), str);
        }
        public static void Enter_Contact_Description(string str)
        {
            Helper.ElementEnterText(PageObject_Navigation.Enter_Contact_Description(), str);
        }
        public static void Click_Contact_Send()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Contact_Send());
        }
        public static void Click_Contact_Support_Dropdown()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Contact_Support_Dropdown());
        }
        public static void Click_Contact_Support_Services(string value)
        {
            Helper.ElementClick(PageObject_Navigation.Click_Contact_Support_Services(value));
        }
        public static void Click_Contact_Support_Sub_Services(string value)
        {
            Helper.ElementClick(PageObject_Navigation.Click_Contact_Support_Sub_Services(value));
        }

       
        public static void Click_SubmitRequest()
        {
            Helper.ElementClick(PageObject_Navigation.Click_SubmitRequest());
        }
        public static void Sent_Contact_us_Email(string name, string email, string subject, string services, string sub_services, string property, string description)
        {
            Click_Contact_us_Icon();
            Logger.WriteDebugMessage("Clicked on Contact Us icon");
            Click_SubmitRequest();
            Enter_Contact_Name(name);
            Enter_Contact_Email(email);
            Enter_Contact_Subject(subject);
            Logger.WriteDebugMessage("Entered First Name, Email and Subject");
            Click_Contact_Support_Dropdown();
            Logger.WriteDebugMessage("Clicked on Support Dropdown");
            Click_Contact_Support_Services(services);
            Logger.WriteDebugMessage("Clicked on Services");
            Click_Contact_Support_Sub_Services(sub_services);
            Enter_Contact_Property(property);
            Enter_Contact_Description(description);
            Logger.WriteDebugMessage("Selected Support and Entered property and description");
            Click_Contact_Send();
            Logger.WriteDebugMessage("Clicked on Contact Send button");
        }

        public static void Market_Performance()
        {
            Helper.ElementClick(PageObject_Navigation.Market_Performance());
        }

        public static void Market_Trend_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Market_Trend_Report());
        }
        public static void Market_Segment_by_Day()
        {
            Helper.ElementClick(PageObject_Navigation.Market_Segment_by_Day());
        }
        public static void Market_Segment_by_Day_Summary()
        {
            Helper.ElementClick(PageObject_Navigation.Market_Segment_by_Day_Summary());
        }

        public static void Annual_Market_Analysis_by_Month()
        {
            Helper.ElementClick(PageObject_Navigation.Annual_Market_Analysis_by_Month());
        }
        public static void Rate_Code_Analysis()
        {
            Helper.ElementClick(PageObject_Navigation.Rate_Code_Analysis());
        }
        public static void Market_Analysis_by_Year()
        {
            Helper.ElementClick(PageObject_Navigation.Market_Analysis_by_Year());
        }
        public static void Monthly_Market_Segment_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Monthly_Market_Segment_Report());
        }
        public static void Rate_Code_Trend_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Rate_Code_Trend_Report());
        }
        public static void Click_Forecast_Budget_Upload_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Forecast_Budget_Upload_Report());
        }
        public static void Click_Source_Market_Analysis_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Source_Market_Analysis_Report());
        }
        public static void Click_Source_Market_Trend_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Source_Market_Trend_Report());
        }
        public static void Click_Province_and_State_Analysis_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Province_and_State_Analysis_Report());
        }
        public static void Click_United_States_Trend_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Click_United_States_Trend_Report());
        }
        public static void Click_Room_Type_Analysis_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Room_Type_Analysis_Report());
        }
        public static void Click_Room_Type_and_Up_Grade_Statistics_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Room_Type_and_Up_Grade_Statistics_Report());
        }
        public static void Click_Booked_Room_Materialization_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Booked_Room_Materialization_Report());
        }
        public static void Click_Detailed_Room_Type_Availability_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Detailed_Room_Type_Availability_Report());
        }
        public static void Click_UserMenu()
        {
            Helper.ElementClick(PageObject_Navigation.Click_UserMenu());
        }
        public static void Click_UserMenu_ReportScheduler()
        {
            Helper.ElementClick(PageObject_Navigation.Click_UserMenu_ReportScheduler());
        }
        public static void Click_UserMenu_ManageReportSchedules()
        {
            Helper.ElementClick(PageObject_Navigation.Click_UserMenu_ManageReportSchedules());
        }
        public static void Click_RainMaker_MoreButton()
        {
            Helper.ElementClick(PageObject_Navigation.Click_RainMaker_MoreButton());
        }
        public static void Click_RainMaker()
        {
            Helper.ElementClick(PageObject_Navigation.Click_RainMaker());
        }
        public static void Click_SubscriptionSupport()
        {
            Helper.ElementClick(PageObject_Navigation.Click_SubscriptionSupport());
        }
        public static void Click_Time_Period_Menu()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Time_Period_Menu());
        }
        public static void Click_Annual_Trends_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Annual_Trends_Report());
        }
        public static void Click_Daily_Analysis_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Daily_Analysis_Report());
        }
        public static void Click_Day_of_Week_Statistics_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Day_of_Week_Statistics_Report());
        }
        public static void Click_Monthly_Summary_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Monthly_Summary_Report());
        }
        public static void Click_Day_of_Week_Analysis_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Day_of_Week_Analysis_Report());
        }
        public static void Click_Daily_Analysis_PerPerson_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Daily_Analysis_PerPerson_Report());
        }

        public static void Click_OTB_Comparison_by_Segment_Reports()
        {
            Helper.ElementClick(PageObject_Navigation.Click_OTB_Comparison_by_Segment_Reports());
        }

        public static void Click_Custom_Menu()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Custom_Menu());
        }

        public static void Click_Daily_Pick_Up_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Daily_Pick_Up_Report());
        }
        public static void Click_Revenue_By_Room_Product_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Revenue_By_Room_Product_Report());
        }
        public static void Click_Pickup_by_Market_Segment_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Pickup_by_Market_Segment_Report());
        }
        public static void Click_OTB_Comparison_for_All_Segments_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Click_OTB_Comparison_for_All_Segments_Report());
        }
        public static void Click_OTB_vs_Budget_by_Segment_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Click_OTB_vs_Budget_by_Segment_Report());
        }
        public static void Click_OTB_vs_Forecast_by_Segment_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Click_OTB_vs_Forecast_by_Segment_Report());
        }

        public static void Click_Room_Type_Booked_vs_Occupied()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Room_Type_Booked_vs_Occupied());
        }
        public static void Click_Access_Log()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Access_Log());
        }
        public static void Click_Parent_Company()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Parent_Company());
        }
        public static void Click_User_Access_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Click_User_Access_Report());
        }
        public static void Click_Room_Rate_Menu()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Room_Rate_Menu());
        }
        public static void Best_Available_Rate_Contribution_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Best_Available_Rate_Contribution_Report());
        }

        public static void Click_Total_Revenue_Analysis_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Total_Revenue_Analysis_Report());
        }
        public static void Filament()
        {
            Helper.ElementClick(PageObject_Navigation.Filament());
        }
        public static void Click_Hotel_Dashboard()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Hotel_Dashboard());
        }
        public static void Click_Agent_Dashboard()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Agent_Dashboard());
        }
        public static void Click_Company_Dashboard()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Company_Dashboard());
        }
        public static void Click_Market_Dashboard()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Market_Dashboard());
        }
        public static void Click_Channel_Dashboard()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Channel_Dashboard());
        }
        public static void Click_Room_Type_Dashboard()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Room_Type_Dashboard());
        }
        public static void Click_Negotiated_Dashboard()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Negotiated_Dashboard());
        }
        public static void Click_Pace_Dashboard()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Pace_Dashboard());
        }
        public static void Click_Channel_Trend_Report()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Channel_Trend_Report());
        }
        public static void Click_Daily_Channel_by_Room_Type()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Daily_Channel_by_Room_Type());
        }
     
        public static void GetUserPreferencesValue(string hotel, string businessUnit, string currency)
        {
            Login.Select_DropDown();
            Logger.WriteDebugMessage("Drop down displayed");
            user_preferences();
            Login.Select_DropDown();
            Logger.WriteDebugMessage("User landed on User preference page");

            Helper.EnterFrameByxPath(PageObject_Navigation.Iframe_user_preferences());
            IJavaScriptExecutor js = (IJavaScriptExecutor)Helper.Driver;
            js.ExecuteScript("arguments[0].setAttribute('value', '"+hotel+"')", PageObject_Navigation.user_preferences_Hotel());
            js.ExecuteScript("arguments[0].setAttribute('value', '" + businessUnit + "')", PageObject_Navigation.user_preferences_BusinessUnit());
            js.ExecuteScript("arguments[0].setAttribute('value', '" + currency + "')", PageObject_Navigation.user_preferences_Currency());
            Logger.WriteDebugMessage("Updated User Preferences with Hotel = "+hotel+", Business Unit = " + businessUnit + " and Currency = " + currency);
            user_preferences_Save();
            Helper.ExitFrame();
            user_preferences_Close();
        }

        public static void VerifyUserPreferencesValue(string hotel, string businessUnit, string currency)
        {

        }
        public static void Click_User_Preference_Portfolio_Toggle_button()
        {
            Helper.ElementClick(PageObject_Navigation.Click_User_Preference_Portfolio_Toggle_button());
        }
        public static void Click_change_tenant()
        {
            Helper.ElementClick(PageObject_Navigation.Click_change_tenant());
        }
        public static void Benchmark_Hospitality()
        {
            Helper.ElementClick(PageObject_Navigation.Benchmark_Hospitality());
        }
        public static void Click_Role_Maintenance()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Role_Maintenance());
        }
        public static void Click_Business_Unit_Grouping()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Business_Unit_Grouping());
        }
        public static void Click_Add_New_Business_Unit_Group()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Add_New_Business_Unit_Group());
        }

        public static void Click_Channel_Mapping()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Channel_Mapping());
        }
        public static void Click_Room_Type_Mapping()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Room_Type_Mapping());
        }
        public static void Click_Market_Mapping()
        {
            Helper.ElementClick(PageObject_Navigation.Click_Market_Mapping());
        }

    }
    
}

