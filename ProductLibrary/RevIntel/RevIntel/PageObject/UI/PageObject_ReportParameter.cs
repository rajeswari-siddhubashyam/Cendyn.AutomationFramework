using BaseUtility.PageObject;
using RevIntel.Utility;
using OpenQA.Selenium;
using System.Reflection;

namespace RevIntel.PageObject.UI
{
    public class PageObject_ReportParameter : Setup
    {
        public static string PageName = Utility.Constants.ReportParameter;

        public static IWebElement Select_Hotel()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_Hotel);
        }
        public static IWebElement Select_Hotel_DDL()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_Hotel_DDL);
        }
        public static IWebElement Select_Hotel_value()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_Hotel_value);
        }

        public static IWebElement Portfolio_RadioButton()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Portfolio_RadioButton);
        }
        public static IWebElement HotelorPortfolio_DDL()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.HotelorPortfolio_DDL);
        }
        public static IWebElement HotelorPortfolio_Dropdown_Arrow()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.HotelorPortfolio_Dropdown_Arrow);
        }

        public static IWebElement ListValue_HotelorPortfolio()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.HotelorPortfolio_ListValue);
        }
        public static IWebElement Select_SourceMarket_DDL()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_SourceMarket_DDL);
        }

        public static IWebElement Select_SourceMarket_value()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_SourceMarket_value);
        }
        public static IWebElement Select_RoomProduct_DDL()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_RoomProduct_DDL);
        }
        public static IWebElement Select_RoomProduct_value()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_RoomProduct_value);
        }
        public static IWebElement Text_StartDate()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.StartDate_Text);
        }

        public static IWebElement Text_EndDate()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.EndDate_Text);
        }

        public static IWebElement Button_Save()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Save_Button);
        }

        public static IWebElement Label_ReportHeading()
        {
            ScanPage(Utility.Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ReportHeading_Label);
        }
        public static IWebElement Click_View_Analysis()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_View_Analysis);
        }

        public static IWebElement IFrame_Agent_Analysis()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.IFrame_Agent_Analysis);
        }
        public static IWebElement Export_Menu()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//a[@id='rptViewer_ctl09_ctl04_ctl00_ButtonLink']");
        }
        public static IWebElement Excel()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Excel);
        }
        public static IWebElement Word()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Word);
        }
        public static IWebElement PDF()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.PDF);
        }
        public static IWebElement TIFF()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.TIFF);
        }
        public static IWebElement Parameter_market()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Parameter_market);
        }
        public static IWebElement Parameter_market_Direct()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Parameter_market_Direct);
        }
        public static IWebElement Select_Dropdown_Hotel()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_Dropdown_Hotel);
        }
        public static IWebElement Parameter_Channel()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Parameter_Channel);
        }

        public static IWebElement Parameter_channel_Hotel_Direct()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Parameter_channel_Hotel_Direct);
        }
        public static IWebElement iframe_Parent_Company_Analysis()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Parent_Company_Analysis);
        }
        public static IWebElement Parent_Company_Analysis_Close()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Parent_Company_Analysis_Close);
        }
        public static IWebElement Paremeter_Memberships()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Paremeter_Memberships);
        }
        public static IWebElement Paremeter_Memberships_value()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Paremeter_Memberships_value);
        }
        public static IWebElement Parent_Travel_Agent_Analysis_Close()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Parent_Travel_Agent_Analysis_Close);
        }

        public static IWebElement Parameter_Agent()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Parameter_Agent);
        }
        public static IWebElement Parameter_Agent_Enter()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Parameter_Agent_Enter);
        }
        public static IWebElement Parameter_Agent_value()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Parameter_Agent_value);
        }
        public static IWebElement iframe_Parent_Travel_Agent_Analysis()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Parent_Travel_Agent_Analysis);
        }
        public static IWebElement iframe_Company_Period_Summary()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Company_Period_Summary);
        }
        public static IWebElement Company_Period_Summary_Close()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Company_Period_Summary_Close);
        }
        public static IWebElement Agent_Period_Summary_Close()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Agent_Period_Summary_Close);
        }
        public static IWebElement iframe_Agent_Period_Summary()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Agent_Period_Summary);
        }
        public static IWebElement iframe_Agent_Trend_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Agent_Trend_Report);
        }
        public static IWebElement Agent_Trend_Report_Close()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Agent_Trend_Report_Close);
        }
        public static IWebElement Compare_Start_Date()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Compare_Start_Date);
        }
        public static IWebElement Compare_End_Date()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Compare_End_Date);
        }

        public static IWebElement iframe_Company_Trend_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Company_Trend_Report);
        }

        public static IWebElement iframe_Portfolio()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Portfolio);
        }
        public static IWebElement Portfolio_DDL()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Portfolio_DDL);
        }

        public static IWebElement Portfolio_DDL_value(string value)
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Portfolio_DDL_value);
            //return PageAction.Find_ElementXPath("//span[contains(text(),'"+ value + "')]");
        }

        public static IWebElement iframe_Agent_By_Hotel()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Agent_By_Hotel);
        }

        public static IWebElement Memberships_value_MemberOnly()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Memberships_value_MemberOnly);
        }
        public static IWebElement iframe_channel_By_Hotel()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_channel_By_Hotel);
        }

        public static IWebElement Portfolio_Selection_DDL()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Portfolio_Selection_DDL);
        }
        public static IWebElement iframe_company_By_Hotel()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_company_By_Hotel);
        }
        public static IWebElement Parameter_market_Corporate()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Parameter_market_Corporate);
        }
        public static IWebElement iframe_Market_By_Hotel_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Market_By_Hotel_Report);
        }
        public static IWebElement iframe_Province_and_State_By_Hotel()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Province_and_State_By_Hotel);
        }

        public static IWebElement iframe_Room_Type_By_Hotel()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Room_Type_By_Hotel);
        }

        public static IWebElement iframe_Source_Market_By_Hotel()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Source_Market_By_Hotel);
        }
        public static IWebElement Click_expand_sign()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_expand_sign);
        }
        public static IWebElement Click_collapse_sign()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_collapse_sign);
        }

        public static IWebElement Click_Source_Market_By_Hotel_expand_sign()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Source_Market_By_Hotel_expand_sign);
        }
        public static IWebElement Click_Source_Market_By_Hotel_collapse_sign()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Source_Market_By_Hotel_collapse_sign);
        }

        public static IWebElement iframe_Pace_report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Pace_report);
        }

        public static IWebElement Enter_As_Of_Date()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_As_Of_Date);
        }
        public static IWebElement Select_Portfolio_value()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_Portfolio_value);
        }

        public static IWebElement iframe_Pace_Trend()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Pace_Trend);
        }

        public static IWebElement Enter_Pace_Trend_Start_Month()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Pace_Trend_Start_Month);
        }
        public static IWebElement iframe_Daily_Pace_and_Pickup_Analysis()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Daily_Pace_and_Pickup_Analysis);
        }

        public static IWebElement iframe_Pace_and_Pickup_Analysis()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Pace_and_Pickup_Analysis);
        }
        public static IWebElement Parameter_Rate_code_DDL()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Parameter_Rate_code_DDL);
        }
        public static IWebElement Parmeter_Rate_code_value()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Parmeter_Rate_code_value);
        }
        public static IWebElement iframe_Rate_Code_Pace_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Rate_Code_Pace_Report);
        }

        public static IWebElement iframe_Channel_By_Room_Type_Pace()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Channel_By_Room_Type_Pace);
        }

        public static IWebElement iframe_Channel_Pace_Analysis()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Channel_Pace_Analysis);
        }

        public static IWebElement iframe_Pickup_By_Day()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Pickup_By_Day);
        }
        public static IWebElement Pickup_startDate()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Pickup_startDate);
        }
        public static IWebElement Pickup_enddate()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Pickup_enddate);
        }
        public static IWebElement PaceReport_Expand()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.PaceReport_Expand);
        }
        public static IWebElement PaceReport_Collapse()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.PaceReport_Collapse);
        }
        public static IWebElement Monthly_PickupStart()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Monthly_PickupStart);
        }
        public static IWebElement Monthly_PickupEnd()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Monthly_PickupEnd);
        }
        public static IWebElement Monthly_Start()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Monthly_Start);
        }
        public static IWebElement Monthly_End()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Monthly_End);
        }
        public static IWebElement iframe_Annual_Pickup_by_Day()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Annual_Pickup_by_Day);
        }

        public static IWebElement iframe_Lenght_of_stay_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Lenght_of_stay_Report);
        }
        public static IWebElement iframe_Rooms_Lead_Time()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Rooms_Lead_Time);
        }
        public static IWebElement iframe_Pickup_By_Day_Detailed()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Pickup_By_Day_Detailed);
        }
        public static IWebElement iframe_Production_Patterns()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Production_Patterns);
        }
        public static IWebElement iframe_High_Occupancy_Night_By_Day()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_High_Occupancy_Night_By_Day);
        }
        public static IWebElement iframe_Sold_Out_Night_Analysis()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Sold_Out_Night_Analysis);
        }
        public static IWebElement iframe_Cancellation_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Cancellation_Report);
        }
        public static IWebElement Monthly_Pickup_Excel()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Monthly_Pickup_Excel);
        }
        public static IWebElement Market_Report_Expand_Level()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Market_Report_Expand_Level);
        }

        public static IWebElement iframe_Market_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Market_Report);
        }

        public static IWebElement iframe_Market_Performance()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Market_Performance);
        }
        public static IWebElement iframe_Market_Trend_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Market_Trend_Report);
        }
        public static IWebElement iframe_Market_Segment_by_Day()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Market_Segment_by_Day);
        }
        public static IWebElement iframe_Market_Segment_by_Day_Summary()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Market_Segment_by_Day_Summary);
        }
        public static IWebElement iframe_Annual_Market_Analysis_by_Month()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Annual_Market_Analysis_by_Month);
        }
        public static IWebElement iframe_Rate_Code_Analysis()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Rate_Code_Analysis);
        }
        public static IWebElement iframe_Market_Analysis_by_Year()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Market_Analysis_by_Year);
        }
        public static IWebElement iframe_Monthly_Market_Segment_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Monthly_Market_Segment_Report);
        }
        public static IWebElement iframe_Rate_Code_Trend_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Rate_Code_Trend_Report);
        }
        public static IWebElement iframe_Pace_and_Forecast_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Pace_and_Forecast_Report);
        }
        public static IWebElement iframe_Source_Market_Analysis_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Source_Market_Analysis_Report);
        }
        public static IWebElement iframe_Source_Market_Trend_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Source_Market_Trend_Report);
        }
        public static IWebElement iframe_Province_and_State_Analysis_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Province_and_State_Analysis_Report);
        }
        public static IWebElement iframe_United_States_Trend_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_United_States_Trend_Report);
        }
        public static IWebElement iframe_Room_Type_Analysis_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Room_Type_Analysis_Report);
        }
        public static IWebElement iframe_Room_Type_and_Up_Grade_Statistics_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Room_Type_and_Up_Grade_Statistics_Report);
        }

        public static IWebElement iframe_Booked_Room_Materialization_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Booked_Room_Materialization_Report);
        }
        public static IWebElement iframe_Detailed_Room_Type_Availability_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Detailed_Room_Type_Availability_Report);
        }
        public static IWebElement iframe_Annual_Trends_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Annual_Trends_Report);
        }
        public static IWebElement iframe_Daily_Analysis_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Daily_Analysis_Report);
        }
        public static IWebElement iframe_Monthly_Summary_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Monthly_Summary_Report);
        }
        public static IWebElement Click_Currency_Dropdown()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Currency_Dropdown);
        }
        public static IWebElement Select_Currency_Value()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_Currency_Value);
        }
        public static IWebElement Click_Business_Unit_Dropdown()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Business_Unit_Dropdown);
        }
        public static IWebElement Select_Business_Unit_Value()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_Business_Unit_Value);
        }
        public static IWebElement iframe_Day_of_Week_Statistics_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Day_of_Week_Statistics_Report);
        }
        public static IWebElement iframe_Day_of_Week_Analysis_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Day_of_Week_Analysis_Report);
        }
        public static IWebElement iframe_Daily_Analysis_PerPerson_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Daily_Analysis_PerPerson_Report);
        }
        public static IWebElement iframe_OTB_Comparison_by_Segment_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_OTB_Comparison_by_Segment_Report);
        }
        public static IWebElement iframe_Daily_Pick_Up_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Daily_Pick_Up_Report);
        }
        public static IWebElement iframe_Revenue_By_Room_Product_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Revenue_By_Room_Product_Report);
        }
        public static IWebElement iframe_Pickup_by_Market_Segment_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Pickup_by_Market_Segment_Report);
        }
        public static IWebElement iframe_OTB_Comparison_for_All_Segments_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_OTB_Comparison_for_All_Segments_Report);
        }
        public static IWebElement iframe_OTB_vs_Budget_by_Segment_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_OTB_vs_Budget_by_Segment_Report);
        }
        public static IWebElement iframe_OTB_vs_Forecast_by_Segment_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_OTB_vs_Forecast_by_Segment_Report);
        }
        public static IWebElement iframe_Room_Type_Booked_vs_Occupied()
        {
                ScanPage(Utility.Constants.ReportParameter);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath(ObjectRepository.iframe_Room_Type_Booked_vs_Occupied);
        }
        public static IWebElement iframe_Access_Log()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Access_Log);
        }

        public static IWebElement iframe_Parent_Company()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Parent_Company);
        }
        
        public static IWebElement Click_Add_New_Parent_Company()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Add_New_Parent_Company);
        }
        public static IWebElement Click_Add_New_Parent_Company_Save_Button()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Add_New_Parent_Company_Save_Button);
        }
        public static IWebElement Enter_Parent_Company_Name()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Parent_Company_Name);
        }
        public static IWebElement Click_Parent_Company_Name_Edit_Link()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Parent_Company_Name_Edit_Link);
        }
        public static IWebElement Click_Add_New_Parent_Company_Close_Button()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Add_New_Parent_Company_Close_Button);
        }
        public static IWebElement iframe_Add_Parent_Company_PopUp()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Add_Parent_Company_PopUp);
        }
        public static IWebElement iframe_User_Access_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_User_Access_Report);
        }
        public static IWebElement iframe_Best_Available_Rate_Contribution_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Best_Available_Rate_Contribution_Report);
        }
        public static IWebElement iframe_Total_Revenue_Analysis_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Total_Revenue_Analysis_Report);
        }
        public static IWebElement iframe_User_Maintenance()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_User_Maintenance);
        }
        public static IWebElement Click_User_Maintenance_Edit_Link()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_User_Maintenance_Edit_Link);
        }
        public static IWebElement Click_User_Role_Test_Role()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_User_Role_Test_Role);
        }
        public static IWebElement Click_Role_Maintenance()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Role_Maintenance);
        }
        public static IWebElement Click_Role_Maintenance_Edit_Link_for_Test_Custom()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Role_Maintenance_Edit_Link_for_Test_Custom);
        }
        public static IWebElement Click_Role_Report_Tab()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Role_Report_Tab);
        }
        public static IWebElement Click_Role_Tenants_Tab()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Role_Tenants_Tab);
        }
        public static IWebElement iframe_Maintain_User()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Maintain_User);
        }
        public static IWebElement iframe_Role_Maintenance_PopUp()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Role_Maintenance_PopUp);
        }
        public static IWebElement iframe_Role_Maintenance()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Role_Maintenance);
        }
        public static IWebElement iframe_Hotel_Dashboard()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Hotel_Dashboard);
        }
        public static IWebElement Dashboard_Hotel_RadioButton()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Dashboard_Hotel_RadioButton);
        }
        public static IWebElement Dashboard_Portfolio_RadioButton()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Dashboard_Portfolio_RadioButton);
        }
        public static IWebElement Hotel_Dashboard_Summary()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Hotel_Dashboard_Summary);
        }
        public static IWebElement Hotel_Dashboard_Detail()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Hotel_Dashboard_Detail);
        }
        public static IWebElement Hotel_Dashboard_ADR_Radio_button()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Hotel_Dashboard_ADR_Radio_button);
        }
        public static IWebElement Hotel_Dashboard_Room_Revenue_Radio_button()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Hotel_Dashboard_Room_Revenue_Radio_button);
        }
        public static IWebElement Hotel_Dashboard_Room_Sold_button()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Hotel_Dashboard_Room_Sold_button);
        }
        
        public static IWebElement iframe_Agent_Dashboard()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Agent_Dashboard);
        }
        public static IWebElement Click_Dashboard_Update_Button()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Dashboard_Update_Button);
        }
        public static IWebElement Enter_Dashboard_Pickup_Start()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Dashboard_Pickup_Start);
        }
        public static IWebElement Enter_Dashboard_Pickup_End()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Dashboard_Pickup_End);
        }
        public static IWebElement Click_Dashboard_Excel_Icon()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Dashboard_Excel_Icon);
        }
        public static IWebElement iframe_Monthly_Pickup()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Monthly_Pickup);
        }
        public static IWebElement Click_Dashboard_Currency_DDL()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Dashboard_Currency_DDL);
        }
        public static IWebElement Click_Dashboard_Hotel_OR_Portfolio_DDL()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Dashboard_Hotel_OR_Portfolio_DDL);
        }
        public static IWebElement Click_Dashboard_Business_DDL()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Dashboard_Business_DDL);
        }
        public static IWebElement Dashboard_Enter_StartDate()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Dashboard_Enter_StartDate);
        }
        public static IWebElement Dashboard_Enter_EndDate()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Dashboard_Enter_EndDate);
        }
        public static IWebElement iframe_Company_Dashboard()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Company_Dashboard);
        }
        public static IWebElement CompanyDashboard_Enter_StartDate()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CompanyDashboard_Enter_StartDate);
        }
        public static IWebElement CompanyDashboard_Enter_EndDate()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CompanyDashboard_Enter_EndDate);
        }
        public static IWebElement Click_CompanyDashboard_Update_Button()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_CompanyDashboard_Update_Button);
        }
        public static IWebElement iframe_Market_Dashboard()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Market_Dashboard);
        }
        public static IWebElement iframe_Channel_Dashboard()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Channel_Dashboard);
        }
        public static IWebElement iframe_Room_Type_Dashboard()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Room_Type_Dashboard);
        }
        public static IWebElement iframe_Negotiated_Dashboard()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Negotiated_Dashboard);
        }
        public static IWebElement iframe_Pace_Dashboard()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Pace_Dashboard);
        }
        public static IWebElement Pace_Dashboard_StartDate()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Pace_Dashboard_StartDate);
        }
        public static IWebElement Pace_Dashboard_EndDate()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Pace_Dashboard_EndDate);
        }
        public static IWebElement Pace_Dashboard_Update_Button()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Pace_Dashboard_Update_Button);
        }
        public static IWebElement iframe_Channel_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Channel_Report);
        }
        public static IWebElement iframe_Channel_Trend_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Channel_Trend_Report);
        }
        public static IWebElement iframe_Daily_Channel_by_Room_Type_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Daily_Channel_by_Room_Type_Report);
        }
        public static IWebElement Data_Feed()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Data_Feed);
        }
        public static IWebElement PowerPoint()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.PowerPoint);
        }
        public static IWebElement MHTML()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MHTML);
        }
        public static IWebElement CSV()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CSV);
        }
        public static IWebElement XML()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.XML);
        }
    
    
        public static IWebElement UserPreference_GetHotel()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.UserPreference_GetHotel);
        }
        public static IWebElement UserPreference_GetBusinessUnit()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.UserPreference_GetBusinessUnit);
        }
        public static IWebElement UserPreference_GetCurrency()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.UserPreference_GetCurrency);
        }

        public static IWebElement Monthly_Pickup_Hotel_Value()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Monthly_Pickup_Hotel_Value);
        }
        public static IWebElement Monthly_Pickup_Currency_Value()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Monthly_Pickup_Currency_Value);
        }
        public static IWebElement Monthly_Pickup_Business_Unit_Value()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Monthly_Pickup_Business_Unit_Value);
        }
        public static IWebElement Hotel_Portfolio_Dropdown()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Hotel_Portfolio_Dropdown);
        }
        public static IWebElement Business_Dropdown()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Business_Dropdown);
        }
        public static IWebElement Currency_Dropdown()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Currency_Dropdown);
        }
        public static IWebElement Get_ReportName(string value)
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//div/div[contains(text(),'"+value+"')]");
        }
       
        public static IWebElement iframe_Business_Unit_Grouping()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Business_Unit_Grouping);
        }

        public static IWebElement Enter_Business_Unit_Grouping_Code()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Business_Unit_Grouping_Code);
        }

        public static IWebElement Enter_Business_Unit_Grouping_Name()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Business_Unit_Grouping_Name);
        }

        public static IWebElement Saved_Business_Unit_Grouping()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Saved_Business_Unit_Grouping);
        }

        public static IWebElement Click_Business_Unit_Grouping_TransferAllFrom_Button()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Business_Unit_Grouping_TransferAllFrom_Button);
        }
        public static IWebElement Click_Edit_Business_Unit_Grouping_button()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Edit_Business_Unit_Grouping_button);
        }

        public static IWebElement Delete_Business_Unit_Grouping_button()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Delete_Business_Unit_Grouping_button);
        }

        public static IWebElement iframe_Add_Business_Unit_Group()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Add_Business_Unit_Group);
        }
        public static IWebElement iframe_Room_Type_Mapping()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Room_Type_Mapping);
        }
        public static IWebElement iframe_Market_Mapping()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Market_Mapping);
        }
        public static IWebElement iframe_Channel_Mapping()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Channel_Mapping);
        }

        public static IWebElement Click_Room_Type_Code()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Room_Type_Code);
        }
        public static IWebElement Click_Room_Type_Name()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Room_Type_Name);
        }
        public static IWebElement Click_Rooms_Counted()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Rooms_Counted);
        }
        public static IWebElement Click_Rooms_Product()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Rooms_Product);
        }
        public static IWebElement Click_Business_Unit()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Business_Unit);
        }
        public static IWebElement Click_PMS_Market_Code()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_PMS_Market_Code);
        }
        public static IWebElement Click_revintel_Market_1()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_revintel_Market_1);
        }
        public static IWebElement Click_revintel_Market_2()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_revintel_Market_2);
        }
        public static IWebElement Click_PMS_Channel_Code()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_PMS_Channel_Code);
        }
        public static IWebElement Click_revintel_Channel_1()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_revintel_Channel_1);
        }
        public static IWebElement Click_revintel_Channel_2()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_revintel_Channel_2);
        }
        public static IWebElement Rainmaker_Hotel_Value()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Rainmaker_Hotel_Value);
        }
        public static IWebElement Rainmaker_Hotel_Dropdown()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Rainmaker_Hotel_Dropdown);
        }
        public static IWebElement Click_Business_Unit_Group_Sort()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Business_Unit_Group_Sort);
        }
        public static IWebElement Maintenance_Edit_testaccess()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Maintenance_Edit_testaccess);
        }
        public static IWebElement Enter_Room_Type_Name()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Room_Type_Name);
        }
        public static IWebElement Click_Filter_Icon_Room_Type_Name()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Filter_Icon_Room_Type_Name);
        }
        public static IWebElement Filter_with_statsWith()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Filter_with_statsWith);
        }
        public static IWebElement Enter_Market_Name()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Market_Name);
        }
        public static IWebElement Click_Filter_Icon_Market_Name()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Filter_Icon_Market_Name);
        }
        public static IWebElement Enter_Channel_Name()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Channel_Name);
        }
        public static IWebElement Click_Filter_Icon_Channel_Name()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Filter_Icon_Channel_Name);
        }

        public static IWebElement Click_RoomTypeAnalysis_ComparisonYear_DDM()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_RoomTypeAnalysis_ComparisonYear_DDM);
        }
        public static IWebElement Select_RoomTypeAnalysis_ComparisonYear1()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_RoomTypeAnalysis_ComparisonYear1);
        }
        public static IWebElement Select_RoomTypeAnalysis_ComparisonYear2()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_RoomTypeAnalysis_ComparisonYear2);
        }
        public static IWebElement Select_RoomTypeAnalysis_ComparisonYear3()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_RoomTypeAnalysis_ComparisonYear3);
        }


        public static IWebElement Click_Compose_Menu()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Compose_Menu);
        }
        public static IWebElement Click_Compose_new_report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Compose_new_report);
        }
        public static IWebElement Click_Compose_Create_New_Report_Close_Icon()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Compose_Create_New_Report_Close_Icon);
        }
        public static IWebElement Click_Compose_Create_New_Report_Cancel_button()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Compose_Create_New_Report_Cancel_button);
        }
        public static IWebElement iframe_Compose()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Compose);
        }
        public static IWebElement Click_Compose_FullscreenButton()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Compose_FullscreenButton);
        }
        public static IWebElement Click_Compose_NewReport_Create_button()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Compose_NewReport_Create_button);
        }
        public static IWebElement Compose_Users_Report()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Compose_Users_Report);
        }
        public static IWebElement Compose_Users_Report_HeaderName()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Compose_Users_Report_HeaderName);
        }
        public static IWebElement Compose_Users_Report_HeaderName_Edit()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Compose_Users_Report_HeaderName_Edit);
        }
        public static IWebElement Compose_Users_Report_HeaderName_Edit_CancelButton()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Compose_Users_Report_HeaderName_Edit_CancelButton);
        }
        public static IWebElement Compose_Users_Report_HeaderName_CloseButton()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Compose_Users_Report_HeaderName_CloseButton);
        }
        public static IWebElement Compose_Enter_NewReport_Name()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Compose_Enter_NewReport_Name);
        }
        public static IWebElement Compose_UserReport_Delete()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Compose_UserReport_Delete);
        }
        public static IWebElement Compose_UserReport_DeleteReport_Delete_Button()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Compose_UserReport_DeleteReport_Delete_Button);
        }
        public static IWebElement Compose_Rename_Button()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Compose_Rename_Button);
        }
        public static IWebElement Update_compose_report_Name()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Update_compose_report_Name);
        }

        public static IWebElement Enter_Start_Month()
        {
            ScanPage(Utility.Constants.ReportParameter);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Start_Month);
        }
        
    }

}
