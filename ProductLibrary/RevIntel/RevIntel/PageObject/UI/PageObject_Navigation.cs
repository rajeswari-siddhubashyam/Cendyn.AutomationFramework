using RevIntel.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;
using System.Reflection;

namespace RevIntel.PageObject.UI
{
    class PageObject_Navigation : Setup
    {
        public static string PageName = Utility.Constants.Navigation;

        public static IWebElement Link_ClientName(string clientName)
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementLinkText(clientName);
        }
        public static IWebElement Click_UAT()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Click_UAT);
        }
        public static IWebElement Ocean_House()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Ocean_House);
        }

        public static IWebElement Tenant_21C()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Tenant_21C);
        }

        public static IWebElement Link_MainMenu()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.BusinessSource);
        }

        public static IWebElement AgentAnalysis()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AgentAnalysis);
        }
        public static IWebElement Portfolio()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Portfolio);
        }
        public static IWebElement Portfolio_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Portfolio_Report);
        }

        public static IWebElement Agent_Summary()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Agent_Summary);
        }

        public static IWebElement BusinessSource()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.BusinessSource);
        }

        public static IWebElement Hotel()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Hotel);
        }
        public static IWebElement Market()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Market);
        }
        public static IWebElement Booking_Trends()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//span[contains(text(),'Booking Trends')]");
        }
        public static IWebElement Channel()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Channel);
        }
        public static IWebElement Forecast_and_Budget()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Forecast_and_Budget);
        }
        public static IWebElement Adhoc()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Adhoc);
        }
        public static IWebElement Geo_Source()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Geo_Source);
        }
        public static IWebElement Click_Hamburger_Icon()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Hamburger_Icon);
        }
        public static IWebElement user_preferences()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.user_preferences);
        }
        public static IWebElement user_preferences_Hotel()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.user_preferences_Hotel);
        }
        public static IWebElement user_preferences_Hotel_select()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.user_preferences_Hotel_select);
        }
        public static IWebElement user_preferences_Currency()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.user_preferences_Currency);
        }
        public static IWebElement user_preferences_Currency_Select()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.user_preferences_Currency_Select);
        }
        public static IWebElement user_preferences_Save()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.user_preferences_Save);
        }
        public static IWebElement Iframe_user_preferences()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Iframe_user_preferences);
        }
        public static IWebElement user_preferences_Close()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.user_preferences_Close);
        }

        public static IWebElement Portal()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Portal);
        }

        public static IWebElement Help_Menu()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Help_Menu);
        }
        public static IWebElement Release_note()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Release_note);
        }
        public static IWebElement Training()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Training);
        }
        public static IWebElement user_preferences_Currency_Default()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.user_preferences_Currency_Default);
        }
        public static IWebElement user_preferences_Hotel_Default()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.user_preferences_Hotel_Default);
        }
        public static IWebElement Administration()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Administration);
        }
        public static IWebElement User_Maintenance()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Maintenance);
        }
        public static IWebElement Add_New_User()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Add_New_User);
        }
        public static IWebElement Iframe_user_Maintenance()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Iframe_user_Maintenance);
        }
        public static IWebElement user_Maintenance_Save()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.user_Maintenance_Save);
        }
        public static IWebElement user_Maintenance_Close()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.user_Maintenance_Close);
        }
        public static IWebElement user_Id()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.user_Id);
        }
        public static IWebElement Add_User_Email()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Add_User_Email);
        }
        public static IWebElement Add_User_FirstName()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Add_User_FirstName);
        }
        public static IWebElement Add_User_LastName()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Add_User_LastName);
        }

        public static IWebElement Select_Available_Hotels()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_Available_Hotels);
        }
        public static IWebElement Iframe_Add_User()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Iframe_Add_User);
        }
        public static IWebElement Corporate_Portfolio()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Corporate_Portfolio);
        }
        public static IWebElement Add_New_Portfolio()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Add_New_Portfolio);
        }
        public static IWebElement iframe_New_Portfolio()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_New_Portfolio);
        }
        public static IWebElement Portfolio_name()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Portfolio_name);
        }
        public static IWebElement Pace_Forecast_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Pace_Forecast_Report);
        }
        public static IWebElement iFrame_Pace_Forecast_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iFrame_Pace_Forecast_Report);
        }
        public static IWebElement Parent_Company_Analysis()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Parent_Company_Analysis);
        }
        public static IWebElement Parent_Travel_Agent_Analysis()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Parent_Travel_Agent_Analysis);
        }
        public static IWebElement Company_Period_Summary()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Company_Period_Summary);
        }
        public static IWebElement Agent_Period_Summary()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Agent_Period_Summary);
        }
        public static IWebElement Agent_Trend_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Agent_Trend_Report);
        }
        public static IWebElement Company_Trend_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Company_Trend_Report);
        }

        public static IWebElement Agent_By_Hotel()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Agent_By_Hotel);
        }
        public static IWebElement Channel_By_Hotel()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Channel_By_Hotel);
        }

        public static IWebElement Company_By_Hotel()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Company_By_Hotel);
        }

        public static IWebElement Market_By_Hotel_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Market_By_Hotel_Report);
        }
        public static IWebElement Province_and_State_By_Hotel()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Province_and_State_By_Hotel);
        }
        public static IWebElement Room_Type_By_Hotel()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Room_Type_By_Hotel);
        }
        public static IWebElement Source_Market_By_Hotel()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Source_Market_By_Hotel);
        }
        public static IWebElement Pace_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Pace_Report);
        }
        public static IWebElement Pace_Trend()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Pace_Trend);
        }
        public static IWebElement Daily_Pace_and_Pickup_Analysis()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Daily_Pace_and_Pickup_Analysis);
        }
        public static IWebElement Pace_and_Pickup_Analysis()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Pace_and_Pickup_Analysis);
        }
        public static IWebElement Rate_Code_Pace_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Rate_Code_Pace_Report);
        }
        public static IWebElement Channel_By_Room_Type_Pace()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Channel_By_Room_Type_Pace);
        }
        public static IWebElement Channel_Pace_Analysis()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Channel_Pace_Analysis);
        }
        public static IWebElement Pickup_By_Day()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Pickup_By_Day);
        }
        public static IWebElement Room_Type()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Room_Type);
        }
        public static IWebElement Room_Rate()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Room_Rate);
        }
        public static IWebElement Rainmaker()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Rainmaker);
        }
        public static IWebElement Annual_Pickup_by_Day()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Annual_Pickup_by_Day);
        }
        public static IWebElement Length_of_Stay_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Length_of_Stay_Report);
        }
        public static IWebElement Rooms_Lead_Time()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Rooms_Lead_Time);
        }
        public static IWebElement Pickup_By_Day_Detailed()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Pickup_By_Day_Detailed);
        }
        public static IWebElement Production_Patterns()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Production_Patterns);
        }
        public static IWebElement Monthly_Pickup()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Monthly_Pickup);
        }
        public static IWebElement High_Occupancy_Night_By_Day()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.High_Occupancy_Night_By_Day);
        }
        public static IWebElement Sold_Out_Night_Analysis()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Sold_Out_Night_Analysis);
        }
        public static IWebElement Cancellation_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Cancellation_Report);
        }

        public static IWebElement Click_Automation()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='AutomationTab']");
        }
        public static IWebElement Click_TA()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_TA);
        }

        public static IWebElement Click_change_password()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_change_password);
        }

        public static IWebElement Change_password_Cancel_button()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Change_password_Cancel_button);
        }
        public static IWebElement Enter_Current_Password()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Current_Password);
        }
        public static IWebElement Enter_New_Password()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_New_Password);
        }
        public static IWebElement Enter_Confirm_Password()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Confirm_Password);
        }

        public static IWebElement Click_Change_Password_button()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Change_Password_button);
        }

        public static IWebElement incorrect_current_password_validation()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.incorrect_current_password_validation);
        }

        public static IWebElement Hotel_Event_Calendar()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Hotel_Event_Calendar);
        }

        public static IWebElement Market_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Market_Report);
        }

        public static IWebElement Channel_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Channel_Report);
        }

        public static IWebElement Pace_and_Forecast_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Pace_and_Forecast_Report);
        }

        public static IWebElement Stay_Graph()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Stay_Graph);
        }

        public static IWebElement Source_Market_Trend()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Source_Market_Trend);
        }

        public static IWebElement Room_Type_Analysis()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Room_Type_Analysis);
        }

        public static IWebElement Time_Period()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Time_Period);
        }

        public static IWebElement Day_of_Week_Statistics()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Day_of_Week_Statistics);
        }

        public static IWebElement Total_Revenue_Analysis()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Total_Revenue_Analysis);
        }
        public static IWebElement Custom()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Custom);
        }
        public static IWebElement OTB_Comparison_for_All_Segments()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.OTB_Comparison_for_All_Segments);
        }
        public static IWebElement Role_Maintenance()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Role_Maintenance);
        }
        public static IWebElement Click_RS()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_RS);
        }
        public static IWebElement Click_Help_Icon()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Help_Icon);
        }
        public static IWebElement Enter_Help_Text()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Help_Text);
        }
        public static IWebElement Click_Contact_us_Icon()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Contact_us_Icon);
        }
        public static IWebElement Click_Portal_Update_Button()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Portal_Update_Button);
        }
        public static IWebElement Click_Link_Portal()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Link_Portal);
        }
        public static IWebElement Click_Link_Hotel_Dashboard()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Link_Hotel_Dashboard);
        }
        public static IWebElement Hotel_Dashboard_iFrame()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Hotel_Dashboard_iFrame);
        }
        public static IWebElement Click_Help_Icon_Minimize()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Help_Icon_Minimize);
        }
        public static IWebElement Verify_Help_Top_Suggestion(string value)
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='Embed']//li[" + value + "]/a[contains(@href,'https://help.cendyn.com')]");
        }
        public static IWebElement Enter_Contact_Name()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Contact_Name);
        }
        public static IWebElement Enter_Contact_Email()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Contact_Email);
        }
        public static IWebElement Enter_Contact_Subject()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Contact_Subject);
        }
        public static IWebElement Enter_Contact_Property()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Contact_Property);
        }
        public static IWebElement Enter_Contact_Description()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Contact_Description);
        }
        public static IWebElement Click_Contact_Send()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Contact_Send);
        }
        //***************************** Change **************************************
        public static IWebElement Click_SubmitRequest()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            //return PageAction.Find_ElementXPath(ObjectRepository.Click_SubmitRequest);
            return PageAction.Find_ElementXPath("//button[contains(text(),'Submit a Request')]");
            
        }
        public static IWebElement Click_Contact_Support_Dropdown()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Contact_Support_Dropdown);
        }
        public static IWebElement Click_Contact_Support_Services(string value)
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[contains(text(),'" + value + "')]");
        }
        public static IWebElement Click_Contact_Support_Sub_Services(string value)
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[contains(text(),'" + value + "')]");
        }

        public static IWebElement Market_Performance()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Market_Performance);
        }
        public static IWebElement Market_Trend_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Market_Trend_Report);
        }
        public static IWebElement Market_Segment_by_Day()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Market_Segment_by_Day);
        }
        public static IWebElement Market_Segment_by_Day_Summary()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Market_Segment_by_Day_Summary);
        }
        public static IWebElement Annual_Market_Analysis_by_Month()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Annual_Market_Analysis_by_Month);
        }
        public static IWebElement Rate_Code_Analysis()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Rate_Code_Analysis);
        }
        public static IWebElement Market_Analysis_by_Year()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Market_Analysis_by_Year);
        }
        public static IWebElement Monthly_Market_Segment_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Monthly_Market_Segment_Report);
        }
        public static IWebElement Rate_Code_Trend_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Rate_Code_Trend_Report);
        }
        public static IWebElement Click_Forecast_Budget_Upload_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Forecast_Budget_Upload_Report);
        }
        public static IWebElement Click_Source_Market_Analysis_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Source_Market_Analysis_Report);
        }
        public static IWebElement Click_Source_Market_Trend_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Source_Market_Trend_Report);
        }
        public static IWebElement Click_Province_and_State_Analysis_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Province_and_State_Analysis_Report);
        }
        public static IWebElement Click_United_States_Trend_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_United_States_Trend_Report);
        }
        public static IWebElement Click_Room_Type_Analysis_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Room_Type_Analysis_Report);
        }
        public static IWebElement Click_Room_Type_and_Up_Grade_Statistics_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Room_Type_and_Up_Grade_Statistics_Report);
        }

        public static IWebElement Click_Booked_Room_Materialization_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Booked_Room_Materialization_Report);
        }

        public static IWebElement Click_Detailed_Room_Type_Availability_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Detailed_Room_Type_Availability_Report);
        }

        public static IWebElement Click_UserMenu()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_UserMenu);
        }
        public static IWebElement Click_UserMenu_ReportScheduler()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_UserMenu_ReportScheduler);
        }
        public static IWebElement Click_UserMenu_ManageReportSchedules()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_UserMenu_ManageReportSchedules);
        }
        public static IWebElement Click_RainMaker_MoreButton()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_RainMaker_MoreButton);
        }
        public static IWebElement Click_RainMaker()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_RainMaker);
        }
        public static IWebElement Click_SubscriptionSupport()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_SubscriptionSupport);
        }
        public static IWebElement Click_Time_Period_Menu()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Time_Period_Menu);
        }
        public static IWebElement Click_Annual_Trends_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Annual_Trends_Report);
        }

        public static IWebElement Click_Daily_Analysis_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Daily_Analysis_Report);
        }
        public static IWebElement Click_Day_of_Week_Statistics_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Day_of_Week_Statistics_Report);
        }
        public static IWebElement Click_Monthly_Summary_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Monthly_Summary_Report);
        }
        public static IWebElement Click_Day_of_Week_Analysis_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Day_of_Week_Analysis_Report);
        }
        public static IWebElement Click_Daily_Analysis_PerPerson_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Daily_Analysis_PerPerson_Report);
        }
        public static IWebElement Click_OTB_Comparison_by_Segment_Reports()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_OTB_Comparison_by_Segment_Reports);
        }
        public static IWebElement Click_Custom_Menu()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Custom_Menu);
        }
        public static IWebElement Click_Daily_Pick_Up_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Daily_Pick_Up_Report);
        }
        public static IWebElement Click_Revenue_By_Room_Product_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Revenue_By_Room_Product_Report);
        }
        public static IWebElement Click_Pickup_by_Market_Segment_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Pickup_by_Market_Segment_Report);
        }
        public static IWebElement Click_OTB_Comparison_for_All_Segments_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_OTB_Comparison_for_All_Segments_Report);
        }
        public static IWebElement Click_OTB_vs_Budget_by_Segment_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_OTB_vs_Budget_by_Segment_Report);
        }
        public static IWebElement Click_OTB_vs_Forecast_by_Segment_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_OTB_vs_Forecast_by_Segment_Report);
        }

        public static IWebElement Click_Room_Type_Booked_vs_Occupied()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Room_Type_Booked_vs_Occupied);
        }

        public static IWebElement Click_Access_Log()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Access_Log);
        }

        public static IWebElement Click_Parent_Company()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Parent_Company);
        }

        public static IWebElement Click_User_Access_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_User_Access_Report);
        }

        public static IWebElement Click_Room_Rate_Menu()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Room_Rate_Menu);
        }
        public static IWebElement Best_Available_Rate_Contribution_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Best_Available_Rate_Contribution_Report);
        }
        public static IWebElement Click_Total_Revenue_Analysis_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Total_Revenue_Analysis_Report);
        }
        public static IWebElement Filament()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Filament);
        }

        public static IWebElement Click_Hotel_Dashboard()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Hotel_Dashboard);
        }

        public static IWebElement Click_Agent_Dashboard()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Agent_Dashboard);
        }

        public static IWebElement Click_Company_Dashboard()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Company_Dashboard);
        }
        public static IWebElement Click_Market_Dashboard()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Market_Dashboard);
        }
        public static IWebElement Click_Channel_Dashboard()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Channel_Dashboard);
        }
        public static IWebElement Click_Room_Type_Dashboard()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Room_Type_Dashboard);
        }
        public static IWebElement Click_Negotiated_Dashboard()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Negotiated_Dashboard);
        }
        public static IWebElement Click_Pace_Dashboard()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Pace_Dashboard);
        }
        public static IWebElement Click_Channel_Trend_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Channel_Trend_Report);
        }
        public static IWebElement Click_Daily_Channel_by_Room_Type()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Daily_Channel_by_Room_Type);
        }
        public static IWebElement user_preferences_BusinessUnit()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.user_preferences_BusinessUnit);
        }
        public static IWebElement Click_Stay_Graph_Report()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Stay_Graph_Report);
        }
        public static IWebElement Click_Menu_Market()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Menu_Market);
        }
        public static IWebElement Click_User_Preference_Portfolio_Toggle_button()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_User_Preference_Portfolio_Toggle_button);
        }
        public static IWebElement Click_change_tenant()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_change_tenant);
        }
        public static IWebElement Benchmark_Hospitality()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Benchmark_Hospitality);
        }
        public static IWebElement Click_Role_Maintenance()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Role_Maintenance);
        }
        public static IWebElement Click_Business_Unit_Grouping()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Business_Unit_Grouping);
        }
        public static IWebElement Click_Add_New_Business_Unit_Group()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Add_New_Business_Unit_Group);
        }
        public static IWebElement Click_Channel_Mapping()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Channel_Mapping);
        }
        public static IWebElement Click_Room_Type_Mapping()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Room_Type_Mapping);
        }
        public static IWebElement Click_Market_Mapping()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Market_Mapping);
        }
    }

}