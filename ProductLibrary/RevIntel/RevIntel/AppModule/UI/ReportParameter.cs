using BaseUtility.Utility;
using RevIntel.PageObject.UI;
using InfoMessageLogger;
using NUnit.Framework;
using System;
using System.IO;


namespace RevIntel.AppModule.UI
{
    class ReportParameter
    {
        public static void Select_Hotel()
        {
            Helper.ElementClick(PageObject_ReportParameter.Select_Hotel());
        }
        public static void Select_Hotel_DDL()
        {
            Helper.ElementClick(PageObject_ReportParameter.Select_Hotel_DDL());
        }
        public static void Select_Hotel_value()
        {
            Helper.ElementClick(PageObject_ReportParameter.Select_Hotel_value());
        }

        public static void Portfolio_RadioButton()
        {
            Helper.ElementWait(PageObject_ReportParameter.Portfolio_RadioButton(), 240);
            Helper.ElementClick(PageObject_ReportParameter.Portfolio_RadioButton());
        }

        public static void Click_HotelorPortfolio_DDL()
        {
            Helper.ElementClick(PageObject_ReportParameter.HotelorPortfolio_DDL());
        }
        public static void HotelorPortfolio_Dropdown_Arrow()
        {
            Helper.ElementClick(PageObject_ReportParameter.HotelorPortfolio_Dropdown_Arrow());
        }

        public static void Enter_StartDate(string str)
        {
            Helper.ElementWait(PageObject_ReportParameter.Text_StartDate(), 240);
            Helper.ElementEnterText(PageObject_ReportParameter.Text_StartDate(), str);
        }

        public static void Enter_EndDate(string str)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.Text_EndDate(), str);
        }
        public static void Select_SourceMarket_DDL()
        {
            Helper.ElementClick(PageObject_ReportParameter.Select_SourceMarket_DDL());
        }

        public static void Select_SourceMarket_value()
        {
            Helper.ElementClick(PageObject_ReportParameter.Select_SourceMarket_value());
        }
        public static void Select_RoomProduct_DDL()
        {
            Helper.ElementClick(PageObject_ReportParameter.Select_RoomProduct_DDL());
        }
        public static void Select_RoomProduct_value()
        {
            Helper.ElementClick(PageObject_ReportParameter.Select_RoomProduct_value());
        }
        public static void Click_Save()
        {
            Helper.ElementClick(PageObject_ReportParameter.Button_Save());
        }
        public static void Click_View_Analysis()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_View_Analysis());
        }
        public static void Export_Menu()
        {
            Helper.ElementWait(PageObject_ReportParameter.Export_Menu(), 500);
            Helper.ElementClickUsingJavascript(PageObject_ReportParameter.Export_Menu());
        }
        public static void Excel()
        {
            Helper.ElementClickUsingJavascript(PageObject_ReportParameter.Excel());
        }
        public static void Word()
        {
            Helper.ElementClick(PageObject_ReportParameter.Word());
        }
        public static void PDF()
        {
            Helper.ElementClick(PageObject_ReportParameter.PDF());
        }
        public static void TIFF()
        {
            Helper.ElementClick(PageObject_ReportParameter.TIFF());
        }
        public static void Parameter_market()
        {
            Helper.ElementClick(PageObject_ReportParameter.Parameter_market());
        }
        public static void Parameter_market_Direct()
        {
            Helper.ElementClick(PageObject_ReportParameter.Parameter_market_Direct());
        }
        public static void Parameter_Channel()
        {
            Helper.ElementClick(PageObject_ReportParameter.Parameter_Channel());
        }
        public static void Parameter_channel_Hotel_Direct()
        {
            Helper.ElementClick(PageObject_ReportParameter.Parameter_channel_Hotel_Direct());
        }


        public static void Select_Portfolio_RadioButton(string startDate, string enddate)
        {
            ReportParameter.Portfolio_RadioButton();
            Logger.WriteDebugMessage("Portfolio radio button selected");
            ReportParameter.Click_HotelorPortfolio_DDL();
            Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
            Business_Source.Company_Summary_Portfolio();
            Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
            ReportParameter.Enter_StartDate(startDate);
            Logger.WriteDebugMessage("Enter start date as = " + startDate);
            ReportParameter.Enter_EndDate(enddate);
            Logger.WriteDebugMessage("Enter enddate as = " + enddate);
            ReportParameter.Click_View_Analysis();
            Logger.WriteDebugMessage("Report generated");
        }

        public static void Select_Hotel_RadioButton(string value)
        {
            ReportParameter.Select_Hotel();
            Logger.WriteDebugMessage(value + "selected as hotel");

        }
        public static void Enter_startDate_EndDate(string startDate, string enddate)
        {
            ReportParameter.Enter_StartDate(startDate);
            Logger.WriteDebugMessage("Enter start date as = " + startDate);
            ReportParameter.Enter_EndDate(enddate);
            Logger.WriteDebugMessage("Enter enddate as = " + enddate);
            ReportParameter.Click_View_Analysis();
            Helper.AddDelay(40000);
            Logger.WriteDebugMessage("Report generated");
        }


        public static string VerifyFileFormate(String path)
        {
            var files = new DirectoryInfo(path).GetFiles("*.*");
            String latestFile = "";
            DateTime lastupdate = DateTime.MinValue;
            foreach (FileInfo file in files)
            {
                if (file.LastWriteTime > lastupdate)
                {
                    lastupdate = file.LastWriteTime;
                    latestFile = file.Name;
                }
            }

            if (latestFile.Contains(".xlsx"))
            {
                Logger.WriteDebugMessage("The template downloaded in the csv file format.");
                long size = latestFile.Length;
                Logger.WriteInfoMessage($"File Size in Bytes: {size}");
            }
            else if (latestFile.Contains(".xls"))
            {
                Logger.WriteDebugMessage("The template downloaded in the .xls file format.");
                long size = latestFile.Length;
                Console.WriteLine($"File Size in Bytes: {size}");
            }
            else
            {
                Assert.Fail("The template is not  in the csv file format.");
            }
            return latestFile;
        }

        public static string Dashboard_VerifyFileFormate(String path)
        {
            var files = new DirectoryInfo(path).GetFiles("*.*");
            String latestFile = "";
            DateTime lastupdate = DateTime.MinValue;
            foreach (FileInfo file in files)
            {
                if (file.LastWriteTime > lastupdate)
                {
                    lastupdate = file.LastWriteTime;
                    latestFile = file.Name;
                }
            }

            if (latestFile.Contains(".xls"))
            {
                Logger.WriteDebugMessage("The template downloaded in the .xls file format.");
                long size = latestFile.Length;
                Console.WriteLine("File Size in Bytes: {0}", size);
            }
            else
            {
                Assert.Fail("The template is not  in the .xls file format.");
            }
            return latestFile;
        }


        public static void iframe_Parent_Company_Analysis()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Parent_Company_Analysis());
        }
        public static void Parent_Company_Analysis_Close()
        {
            Helper.ElementClick(PageObject_ReportParameter.Parent_Company_Analysis_Close());
        }
        public static void Paremeter_Memberships()
        {
            Helper.ElementClick(PageObject_ReportParameter.Paremeter_Memberships());
        }
        public static void Paremeter_Memberships_value()
        {
            Helper.ElementClick(PageObject_ReportParameter.Paremeter_Memberships_value());
        }
        public static void Parent_Travel_Agent_Analysis_Close()
        {
            Helper.ElementClick(PageObject_ReportParameter.Parent_Travel_Agent_Analysis_Close());
        }
        public static void Parameter_Agent()
        {
            Helper.ElementClick(PageObject_ReportParameter.Parameter_Agent());
        }
        public static void Parameter_Agent_Enter(string value)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.Parameter_Agent_Enter(), value);
        }
        public static void Parameter_Agent_value()
        {
            Helper.ElementClick(PageObject_ReportParameter.Parameter_Agent_value());
        }
        public static void iframe_Parent_Travel_Agent_Analysis()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Parent_Travel_Agent_Analysis());
        }
        public static void iframe_Company_Period_Summary()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Company_Period_Summary());
        }
        public static void Company_Period_Summary_Close()
        {
            Helper.ElementClick(PageObject_ReportParameter.Company_Period_Summary_Close());
        }
        public static void Agent_Period_Summary_Close()
        {
            Helper.ElementClick(PageObject_ReportParameter.Agent_Period_Summary_Close());
        }
        public static void iframe_Agent_Period_Summary()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Agent_Period_Summary());
        }
        public static void iframe_Agent_Trend_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Agent_Trend_Report());
        }
        public static void Agent_Trend_Report_Close()
        {
            Helper.ElementClick(PageObject_ReportParameter.Agent_Trend_Report_Close());
        }
        public static void Compare_Start_Date(string value)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.Compare_Start_Date(), value);
        }
        public static void Compare_End_Date(string value)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.Compare_End_Date(), value);
        }
        public static void iframe_Company_Trend_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Company_Trend_Report());
        }

        public static void iframe_Portfolio()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Portfolio());
        }
        public static void Portfolio_DDL()
        {
            Helper.ElementClick(PageObject_ReportParameter.Portfolio_DDL());
        }

        public static void Portfolio_DDL_value(string value)
        {
            Helper.ElementClick(PageObject_ReportParameter.Portfolio_DDL_value(value));
        }

        public static void iframe_Agent_By_Hotel()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Agent_By_Hotel());
        }

        public static void Memberships_value_MemberOnly()
        {
            Helper.ElementClick(PageObject_ReportParameter.Memberships_value_MemberOnly());
        }

        public static void iframe_channel_By_Hotel()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_channel_By_Hotel());
        }

        public static void Portfolio_reports_filters()
        {
            Helper.VerifyTextOnPageAndHighLight("Market:");
            Logger.WriteDebugMessage("Market Parameter displayed");
            Helper.VerifyTextOnPageAndHighLight("Channel:");
            Logger.WriteDebugMessage("Channel Parameter displayed");
            Helper.VerifyTextOnPageAndHighLight("Source Market:");
            Logger.WriteDebugMessage("Source Market Parameter displayed");
            Helper.VerifyTextOnPageAndHighLight("Room Product:");
            Logger.WriteDebugMessage("Room Product Parameter displayed");
            Helper.VerifyTextOnPageAndHighLight("Membership:");
            Logger.WriteDebugMessage("Memberships Parameter displayed");
        }

        public static void Hotel_Selection_DDL()
        {
            string portfolio = PageObject_ReportParameter.Portfolio_Selection_DDL().GetAttribute("innerHTML");
            if (portfolio.Contains("Hotel"))
                Assert.Fail("Text Found");
            else
                Logger.WriteDebugMessage("Hotel name selections not displayed");
        }

        public static void Required_Field_Validation()
        {
            ReportParameter.Click_View_Analysis();
            Logger.WriteDebugMessage("validation message displayed for required field");
        }

        public static void Report_Excel_Format()
        {
            ReportParameter.Export_Menu();
            Logger.WriteDebugMessage("Export drop down menu displayed");
            ReportParameter.Excel();
            Helper.AddDelay(30000);
            Logger.WriteDebugMessage("Report exported in excel format");
            Helper.ExitFrame();
        }

        public static void iframe_company_By_Hotel()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_company_By_Hotel());
        }
        public static void Parameter_market_Corporate()
        {
            Helper.ElementClick(PageObject_ReportParameter.Parameter_market_Corporate());
        }
        public static void iframe_Market_By_Hotel_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Market_By_Hotel_Report());
        }

        public static void Portfolio_report_startdate_enddate(string Portfolio_value, string startDate, string enddate)
        {
            
            ReportParameter.Click_HotelorPortfolio_DDL();
            Logger.WriteDebugMessage("No List of hotel get displayed when check Protfolio radio button");
            ReportParameter.Portfolio_DDL_value(Portfolio_value);
            Logger.WriteDebugMessage("One&Only All -CT,SG,RR,RM,TP,PL,WV,NG selected as Portfolio");
            ReportParameter.Enter_StartDate(startDate);
            ReportParameter.Enter_EndDate(enddate);
            Logger.WriteDebugMessage("Enter start date as = " + startDate);
            Logger.WriteDebugMessage("Enter enddate as = " + enddate);
        }

        public static void iframe_Province_and_State_By_Hotel()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Province_and_State_By_Hotel());
        }

        public static void iframe_Room_Type_By_Hotel()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Room_Type_By_Hotel());
        }

        public static void iframe_Source_Market_By_Hotel()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Source_Market_By_Hotel());
        }

        public static void Click_expand_sign()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_expand_sign());
        }

        public static void Click_collapse_sign()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_collapse_sign());
        }

        public static void Click_Source_Market_By_Hotel_expand_sign()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Source_Market_By_Hotel_expand_sign());
            Helper.ElementWait(PageObject_ReportParameter.Click_Source_Market_By_Hotel_expand_sign(), 10000);
        }

        public static void Click_Source_Market_By_Hotel_collapse_sign()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Source_Market_By_Hotel_collapse_sign());
            Helper.ElementWait(PageObject_ReportParameter.Click_Source_Market_By_Hotel_collapse_sign(), 10000);
        }

        public static void iframe_Pace_report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Pace_report());
            Helper.ElementWait(PageObject_ReportParameter.iframe_Pace_report(), 10000);
        }

        public static void Enter_As_Of_Date(string value)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.Enter_As_Of_Date(), value);
        }

        public static void Select_Portfolio_value()
        {
            Helper.ElementClick(PageObject_ReportParameter.Select_Portfolio_value());
        }

        public static void iframe_Pace_Trend()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Pace_Trend());
        }
        public static void Enter_Pace_Trend_Start_Month(string value)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.Enter_Pace_Trend_Start_Month(), value);
        }
        public static void iframe_Daily_Pace_and_Pickup_Analysis()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Daily_Pace_and_Pickup_Analysis());
        }
        public static void iframe_Pace_and_Pickup_Analysis()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Pace_and_Pickup_Analysis());
        }
        public static void IFrame_Agent_Analysis()
        {
            Helper.ElementClick(PageObject_ReportParameter.IFrame_Agent_Analysis());
        }

        public static void Booking_Trends_reports_filters()
        {
            Helper.VerifyTextOnPageAndHighLight("Market:");
            Logger.WriteDebugMessage("Market Parameter displayed");
            Helper.VerifyTextOnPageAndHighLight("Channel:");
            Logger.WriteDebugMessage("Channel Parameter displayed");
            Helper.VerifyTextOnPageAndHighLight("Room Product:");
            Logger.WriteDebugMessage("Room Product Parameter displayed");
            Helper.VerifyTextOnPageAndHighLight("Rate Code:");
            Logger.WriteDebugMessage("Rate Code: Parameter displayed");
        }

        public static void Parameter_Rate_code_DDL()
        {
            Helper.ElementClick(PageObject_ReportParameter.Parameter_Rate_code_DDL());
        }

        public static void Parmeter_Rate_code_value()
        {
            Helper.ElementClick(PageObject_ReportParameter.Parmeter_Rate_code_value());
        }

        public static void iframe_Rate_Code_Pace_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Rate_Code_Pace_Report());
        }

        public static void iframe_Channel_By_Room_Type_Pace()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Channel_By_Room_Type_Pace());
        }

        public static void iframe_Channel_Pace_Analysis()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Channel_Pace_Analysis());
        }

        public static void iframe_Pickup_By_Day()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Pickup_By_Day());
        }
        public static void Pickup_startDate(string value)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.Pickup_startDate(), value);
        }
        public static void Pickup_enddate(string value)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.Pickup_enddate(), value);
        }
        public static void PaceReport_Expand()
        {
            Helper.ElementClick(PageObject_ReportParameter.PaceReport_Expand());
        }
        public static void PaceReport_Collapse()
        {
            Helper.ElementClick(PageObject_ReportParameter.PaceReport_Collapse());
        }
        public static void Monthly_PickupStart(string value)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.Monthly_PickupStart(), value);
        }
        public static void Monthly_PickupEnd(string value)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.Monthly_PickupEnd(), value);
        }
        public static void Monthly_Start(string startDate)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.Monthly_Start(), startDate);
        }
        public static void Monthly_End(string enddate)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.Monthly_End(), enddate);
        }
        public static void iframe_Annual_Pickup_by_Day()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Annual_Pickup_by_Day());
        }
        public static void Annual_Pickup_by_Day_filter()
        {
            Helper.VerifyTextOnPageAndHighLight("Market:");
            Logger.WriteDebugMessage("Parameter Market is displayed");
            Helper.VerifyTextOnPageAndHighLight("Channel:");
            Logger.WriteDebugMessage("Parameter Market is displayed");
        }
        public static void iframe_Lenght_of_stay_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Lenght_of_stay_Report());
        }
        public static void iframe_Rooms_Lead_Time()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Rooms_Lead_Time());
        }
        public static void iframe_Pickup_By_Day_Detailed()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Pickup_By_Day_Detailed());
        }
        public static void iframe_Production_Patterns()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Production_Patterns());
        }
        public static void iframe_High_Occupancy_Night_By_Day()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_High_Occupancy_Night_By_Day());
        }
        public static void iframe_Sold_Out_Night_Analysis()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Sold_Out_Night_Analysis());
        }
        public static void iframe_Cancellation_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Cancellation_Report());
        }
        public static void Monthly_Pickup_Excel()
        {
            Helper.ElementClick(PageObject_ReportParameter.Monthly_Pickup_Excel());
        }
        public static void Market_Report_Expand_Level()
        {
            Helper.ElementClick(PageObject_ReportParameter.Market_Report_Expand_Level());
        }

        public static void iframe_Market_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Market_Report());
        }

        public static void iframe_Market_Performance()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Market_Performance());
        }

        public static void iframe_Market_Trend_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Market_Trend_Report());
        }

        public static void iframe_Market_Segment_by_Day()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Market_Segment_by_Day());
        }
        public static void iframe_Market_Segment_by_Day_Summary()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Market_Segment_by_Day_Summary());
        }
        public static void iframe_Annual_Market_Analysis_by_Month()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Annual_Market_Analysis_by_Month());
        }

        public static void iframe_Rate_Code_Analysis()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Rate_Code_Analysis());
        }
        public static void iframe_Market_Analysis_by_Year()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Market_Analysis_by_Year());
        }
        public static void iframe_Monthly_Market_Segment_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Monthly_Market_Segment_Report());
        }
        public static void iframe_Rate_Code_Trend_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Rate_Code_Trend_Report());
        }
        public static void iframe_Pace_and_Forecast_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Pace_and_Forecast_Report());
        }
        public static void iframe_Source_Market_Analysis_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Source_Market_Analysis_Report());
        }
        public static void iframe_Source_Market_Trend_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Source_Market_Trend_Report());
        }
        public static void iframe_Province_and_State_Analysis_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Province_and_State_Analysis_Report());
        }
        public static void iframe_United_States_Trend_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_United_States_Trend_Report());
        }
        public static void iframe_Room_Type_Analysis_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Room_Type_Analysis_Report());
        }
        public static void iframe_Room_Type_and_Up_Grade_Statistics_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Room_Type_and_Up_Grade_Statistics_Report());
        }

        public static void iframe_Booked_Room_Materialization_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Booked_Room_Materialization_Report());
        }

        public static void iframe_Detailed_Room_Type_Availability_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Detailed_Room_Type_Availability_Report());
        }
        public static void iframe_Annual_Trends_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Annual_Trends_Report());
        }
        public static void iframe_Daily_Analysis_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Daily_Analysis_Report());
        }
        public static void iframe_Monthly_Summary_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Monthly_Summary_Report());
        }
        public static void Click_Currency_Dropdown()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Currency_Dropdown());
        }
        public static void Select_Currency_Value()
        {
            Helper.ElementClick(PageObject_ReportParameter.Select_Currency_Value());
        }
        public static void Click_Business_Unit_Dropdown()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Business_Unit_Dropdown());
        }
        public static void Select_Business_Unit_Value()
        {
            Helper.ElementClick(PageObject_ReportParameter.Select_Business_Unit_Value());
        }
        public static void iframe_Day_of_Week_Statistics_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Day_of_Week_Statistics_Report());
        }
        public static void iframe_Day_of_Week_Analysis_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Day_of_Week_Analysis_Report());
        }
        public static void iframe_Daily_Analysis_PerPerson_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Daily_Analysis_PerPerson_Report());
        }
        public static void iframe_OTB_Comparison_by_Segment_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_OTB_Comparison_by_Segment_Report());
        }
        public static void iframe_Daily_Pick_Up_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Daily_Pick_Up_Report());
        }
        public static void iframe_Revenue_By_Room_Product_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Revenue_By_Room_Product_Report());
        }
        public static void iframe_Pickup_by_Market_Segment_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Pickup_by_Market_Segment_Report());
        }
        public static void iframe_OTB_Comparison_for_All_Segments_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_OTB_Comparison_for_All_Segments_Report());
        }
        public static void iframe_OTB_vs_Budget_by_Segment_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_OTB_vs_Budget_by_Segment_Report());
        }
        public static void iframe_OTB_vs_Forecast_by_Segment_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_OTB_vs_Forecast_by_Segment_Report());
        }
        public static void Select_Currency_Business_value(string Business_Unit, string Currency)
        {
            ReportParameter.Click_Business_Unit_Dropdown();
            ReportParameter.Select_Business_Unit_Value();
            Logger.WriteDebugMessage(Business_Unit + "is selected as Business Unit");
            ReportParameter.Click_Currency_Dropdown();
            ReportParameter.Select_Currency_Value();
            Logger.WriteDebugMessage(Currency + "is selected as Currency");
        }
        public static void iframe_Room_Type_Booked_vs_Occupied()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Room_Type_Booked_vs_Occupied());
        }

        public static void iframe_Access_Log()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Access_Log());
        }

        public static void iframe_Parent_Company()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Parent_Company());
        }

        public static void Click_Add_New_Parent_Company()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Add_New_Parent_Company());
        }
        public static void Click_Add_New_Parent_Company_Save_Button()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Add_New_Parent_Company_Save_Button());
        }
        public static void Enter_Parent_Company_Name(string value)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.Enter_Parent_Company_Name(), value);
        }
        public static void Click_Parent_Company_Name_Edit_Link()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Parent_Company_Name_Edit_Link());
        }
        public static void Click_Add_New_Parent_Company_Close_Button()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Add_New_Parent_Company_Close_Button());
        }
        public static void iframe_Add_Parent_Company_PopUp()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Add_Parent_Company_PopUp());
        }
        public static void iframe_User_Access_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_User_Access_Report());
        }
        public static void iframe_Best_Available_Rate_Contribution_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Best_Available_Rate_Contribution_Report());
        }
        public static void iframe_Total_Revenue_Analysis_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Total_Revenue_Analysis_Report());
        }
        public static void iframe_User_Maintenance()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_User_Maintenance());
        }
        public static void Click_User_Maintenance_Edit_Link()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_User_Maintenance_Edit_Link());
        }
        public static void Click_User_Role_Test_Role()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_User_Role_Test_Role());
        }
        public static void Click_Role_Maintenance()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Role_Maintenance());
        }
        public static void Click_Role_Maintenance_Edit_Link_for_Test_Custom()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Role_Maintenance_Edit_Link_for_Test_Custom());
        }
        public static void Click_Role_Report_Tab()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Role_Report_Tab());
        }
        public static void Click_Role_Tenants_Tab()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Role_Tenants_Tab());
        }
        public static void iframe_Maintain_User()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Maintain_User());
        }
        public static void iframe_Role_Maintenance_PopUp()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Role_Maintenance_PopUp());
        }
        public static void iframe_Role_Maintenance()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Role_Maintenance());
        }

        public static string VerifyPdfFileFormate(String path)
        {
            var files = new DirectoryInfo(path).GetFiles("*.*");
            String latestFile = "";
            DateTime lastupdate = DateTime.MinValue;
            foreach (FileInfo file in files)
            {
                if (file.LastWriteTime > lastupdate)
                {
                    lastupdate = file.LastWriteTime;
                    latestFile = file.Name;
                }
            }

            if (latestFile.Contains(".pdf"))
            {
                Logger.WriteDebugMessage("The template should be downloaded in the Pdf file format.");
                long size = latestFile.Length;
                Logger.WriteInfoMessage("File Size in Bytes:", size);
            }
            else
                Assert.Fail("The template is not  in the pdf file format.");

            return latestFile;
        }


        public static string VerifyTIFFileFormate(String path)
        {
            var files = new DirectoryInfo(path).GetFiles("*.*");
            String latestFile = "";
            DateTime lastupdate = DateTime.MinValue;
            foreach (FileInfo file in files)
            {
                if (file.LastWriteTime > lastupdate)
                {
                    lastupdate = file.LastWriteTime;
                    latestFile = file.Name;
                }
            }
            if (latestFile.Contains(".TIF"))
            {
                Logger.WriteDebugMessage("The template should be downloaded in the .TIF file format.");
                long size = latestFile.Length;
                Console.WriteLine("File Size in Bytes:", size);
            }
            else
                Assert.Fail("The template is not  in the .TIF file format.");


            return latestFile;
        }
        public static void UserPreference_GetHotel()
        {
            Helper.ElementClick(PageObject_ReportParameter.UserPreference_GetHotel());
        }
        public static void UserPreference_GetBusinessUnit()
        {
            Helper.ElementClick(PageObject_ReportParameter.UserPreference_GetBusinessUnit());
        }
        public static void UserPreference_GetCurrency()
        {
            Helper.ElementClick(PageObject_ReportParameter.UserPreference_GetCurrency());
        }

    

         

        public static string VerifyWordFileFormate(String path)
        {
            var files = new DirectoryInfo(path).GetFiles("*.*");
            String latestFile = "";
            DateTime lastupdate = DateTime.MinValue;
            foreach (FileInfo file in files)
            {
                if (file.LastWriteTime > lastupdate)
                {
                    lastupdate = file.LastWriteTime;
                    latestFile = file.Name;
                }
            }

            if (latestFile.Contains(".docx"))
            {
                Logger.WriteDebugMessage("The template should be downloaded in the .docx file format.");
                long size = latestFile.Length;
                Logger.WriteInfoMessage("File Size in Bytes:", size);
            }
            else
                Assert.Fail("The template is not  in the .docx file format.");


            return latestFile;
        }

        public static string VerifyPowerPointFormate(String path)
        {
            var files = new DirectoryInfo(path).GetFiles("*.*");
            String latestFile = "";
            DateTime lastupdate = DateTime.MinValue;
            foreach (FileInfo file in files)
            {
                if (file.LastWriteTime > lastupdate)
                {
                    lastupdate = file.LastWriteTime;
                    latestFile = file.Name;
                }
            }

            if (latestFile.Contains(".pptx"))
            {
                Logger.WriteDebugMessage("The template downloaded in the .pptx file format.");
                long size = latestFile.Length;
                Logger.WriteInfoMessage("File Size in Bytes:", size);
            }
            else
                Assert.Fail("The template is not  in the .pptx file format.");
            return latestFile;
        }

        public static string VerifymhtmlFormate(String path)
        {
            var files = new DirectoryInfo(path).GetFiles("*.*");
            String latestFile = "";
            DateTime lastupdate = DateTime.MinValue;
            foreach (FileInfo file in files)
            {
                if (file.LastWriteTime > lastupdate)
                {
                    lastupdate = file.LastWriteTime;
                    latestFile = file.Name;
                }
            }

            if (latestFile.Contains(".mhtml"))
            {
                Logger.WriteDebugMessage("The template downloaded in the .mhtml file format.");
                long size = latestFile.Length;
                Logger.WriteInfoMessage("File Size in Bytes: ", size);
            }
            else
                Assert.Fail("The template is not  in the .mhtml file format.");


            return latestFile;
        }

        public static string VerifyCSVFormate(String path)
        {
            var files = new DirectoryInfo(path).GetFiles("*.*");
            String latestFile = "";
            DateTime lastupdate = DateTime.MinValue;
            foreach (FileInfo file in files)
            {
                if (file.LastWriteTime > lastupdate)
                {
                    lastupdate = file.LastWriteTime;
                    latestFile = file.Name;
                }
            }

            if (latestFile.Contains(".csv"))
            {
                Logger.WriteDebugMessage("The template downloaded in the .csv file format.");
                long size = latestFile.Length;
                Logger.WriteInfoMessage("File Size in Bytes:", size);
            }
            else
                Assert.Fail("The template is not  in the .csv file format.");


            return latestFile;
        }

        public static string VerifyXMLFormate(String path)
        {
            var files = new DirectoryInfo(path).GetFiles("*.*");
            String latestFile = "";
            DateTime lastupdate = DateTime.MinValue;
            foreach (FileInfo file in files)
            {
                if (file.LastWriteTime > lastupdate)
                {
                    lastupdate = file.LastWriteTime;
                    latestFile = file.Name;
                }
            }

            if (latestFile.Contains(".xml"))
            {
                Logger.WriteDebugMessage("The template downloaded in the .xml file format.");
                long size = latestFile.Length;
                Logger.WriteInfoMessage("File Size in Bytes:", size);
            }
            else
                Assert.Fail("The template is not  in the .xml file format.");


            return latestFile;
        }

        public static string VerifyDataFeedFormate(String path)
        {
            var files = new DirectoryInfo(path).GetFiles("*.*");
            String latestFile = "";
            DateTime lastupdate = DateTime.MinValue;
            foreach (FileInfo file in files)
            {
                if (file.LastWriteTime > lastupdate)
                {
                    lastupdate = file.LastWriteTime;
                    latestFile = file.Name;
                }
            }

            if (latestFile.Contains(".atomsvc"))
            {
                Logger.WriteDebugMessage("The template downloaded in the .atomsvc file format.");
                long size = latestFile.Length;
                Logger.WriteInfoMessage("File Size in Bytes:", size);
            }
            else
                Assert.Fail("The template is not  in the .atomsvc file format.");


            return latestFile;
        }

        public static void iframe_Hotel_Dashboard()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Hotel_Dashboard());
        }
        public static void Dashboard_Hotel_RadioButton()
        {
            Helper.ElementClick(PageObject_ReportParameter.Dashboard_Hotel_RadioButton());
        }
        public static void Dashboard_Portfolio_RadioButton()
        {
            Helper.ElementClick(PageObject_ReportParameter.Dashboard_Portfolio_RadioButton());
        }
        public static void Hotel_Dashboard_Summary()
        {
            Helper.ElementClick(PageObject_ReportParameter.Hotel_Dashboard_Summary());
        }
        public static void Hotel_Dashboard_Detail()
        {
            Helper.ElementClick(PageObject_ReportParameter.Hotel_Dashboard_Detail());
        }
        public static void Hotel_Dashboard_ADR_Radio_button()
        {
            Helper.ElementClick(PageObject_ReportParameter.Hotel_Dashboard_ADR_Radio_button());
        }
        public static void Hotel_Dashboard_Room_Revenue_Radio_button()
        {
            Helper.ElementClick(PageObject_ReportParameter.Hotel_Dashboard_Room_Revenue_Radio_button());
        }
        public static void Hotel_Dashboard_Room_Sold_button()
        {
            Helper.ElementClick(PageObject_ReportParameter.Hotel_Dashboard_Room_Sold_button());
        }
        
        public static void iframe_Agent_Dashboard()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Agent_Dashboard());
        }
        public static void Click_Dashboard_Update_Button()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Dashboard_Update_Button());
        }
        public static void Enter_Dashboard_Pickup_Start(string value)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.Enter_Dashboard_Pickup_Start(),value);
        }
        public static void Enter_Dashboard_Pickup_End(string value)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.Enter_Dashboard_Pickup_End(),value);
        }
        public static void Click_Dashboard_Excel_Icon()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Dashboard_Excel_Icon());
        }
        public static void iframe_Monthly_Pickup()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Monthly_Pickup());
        }
        public static void Click_Dashboard_Currency_DDL()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Dashboard_Currency_DDL());
        }
        public static void Click_Dashboard_Hotel_OR_Portfolio_DDL()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Dashboard_Hotel_OR_Portfolio_DDL());
        }
        public static void Click_Dashboard_Business_DDL()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Dashboard_Business_DDL());
        }
        public static void Dashboard_Enter_StartDate(string value)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.Dashboard_Enter_StartDate(),value);
        }
        public static void Dashboard_Enter_EndDate(string value)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.Dashboard_Enter_EndDate(),value);
        }
        public static void iframe_Company_Dashboard()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Company_Dashboard());
        }
        public static void CompanyDashboard_Enter_StartDate(string value)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.CompanyDashboard_Enter_StartDate(), value);
        }
        public static void CompanyDashboard_Enter_EndDate(string value)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.CompanyDashboard_Enter_EndDate(), value);
        }
        public static void Click_CompanyDashboard_Update_Button()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_CompanyDashboard_Update_Button());
        }
        public static void iframe_Market_Dashboard()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Market_Dashboard());
        }
        public static void iframe_Channel_Dashboard()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Channel_Dashboard());
        }
        public static void iframe_Room_Type_Dashboard()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Room_Type_Dashboard());
        }
        public static void iframe_Negotiated_Dashboard()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Negotiated_Dashboard());
        }
        public static void iframe_Pace_Dashboard()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Pace_Dashboard());
        }
        public static void Pace_Dashboard_StartDate(string value)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.Pace_Dashboard_StartDate(),value);
        }
        public static void Pace_Dashboard_EndDate(string value)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.Pace_Dashboard_EndDate(),value);
        }
        public static void Pace_Dashboard_Update_Button()
        {
            Helper.ElementClick(PageObject_ReportParameter.Pace_Dashboard_Update_Button());
        }
        public static void iframe_Channel_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Channel_Report());
        }
        public static void iframe_Channel_Trend_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Channel_Trend_Report());
        }
        public static void iframe_Daily_Channel_by_Room_Type_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Daily_Channel_by_Room_Type_Report());
        }
        public static void PowerPoint()
        {
            Helper.ElementClick(PageObject_ReportParameter.PowerPoint());
        }
        public static void MHTML()
        {
            Helper.ElementClick(PageObject_ReportParameter.MHTML());
        }
        public static void CSV()
        {
            Helper.ElementClick(PageObject_ReportParameter.CSV());
        }
        public static void XML()
        {
            Helper.ElementClick(PageObject_ReportParameter.XML());
        }
        public static void Data_Feed()
        {
            Helper.ElementClick(PageObject_ReportParameter.Data_Feed());
        }
        public static string Get_Hotel_Portfolio_Dropdown_Value()
        {
           return PageObject_ReportParameter.Hotel_Portfolio_Dropdown().GetAttribute("value");
        }
        public static string Get_Business_Dropdown_Value()
        {
            return PageObject_ReportParameter.Business_Dropdown().GetAttribute("value");
        }
        public static string Get_Currency_Dropdown_Value()
        {
            return PageObject_ReportParameter.Currency_Dropdown().GetAttribute("value");
        }

        public static void VerifyUserPreferences(string hotel, string businessUnit, string currency)
        {
            if (hotel.Equals(ReportParameter.Get_Hotel_Portfolio_Dropdown_Value()))
                Logger.WriteInfoMessage("Hotel Name from User Preference Page is equal to Value on Report");
            else
                Assert.Fail("Hotel name from user preferences Page is not equal to Values on Report");
            if (businessUnit.Equals(ReportParameter.Get_Business_Dropdown_Value()))
                Logger.WriteInfoMessage("Business Unit Name from User Preference Page is equal to Value on Report");
            else
                Assert.Fail("Business Unit name from user preferences Page is not equal to Values on Report");
            if (currency.Equals(ReportParameter.Get_Currency_Dropdown_Value()))
                Logger.WriteDebugMessage("Currency Name from User Preference Page is equal to Value on Report");
            else
                Assert.Fail("Currency name from user preferences Page is not equal to Values on Report");
        }
        public static string Get_Report_Name(string value)
        {
            return PageObject_ReportParameter.Get_ReportName(value).GetAttribute("innerHTML");
        }
        public static string iframe_Business_Unit_Grouping(string value)
        {
            return PageObject_ReportParameter.Get_ReportName(value).GetAttribute("innerHTML");
        }
        
        public static void iframe_Business_Unit_Grouping()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Business_Unit_Grouping());
        }

        public static void Enter_Business_Unit_Grouping_Code(string value)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.Enter_Business_Unit_Grouping_Code(),value);
        }

        public static void Enter_Business_Unit_Grouping_Name(string value)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.Enter_Business_Unit_Grouping_Name(), value);
        }

        public static void Saved_Business_Unit_Grouping()
        {
            Helper.ElementClick(PageObject_ReportParameter.Saved_Business_Unit_Grouping());
        }

        public static void Click_Business_Unit_Grouping_TransferAllFrom_Button()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Business_Unit_Grouping_TransferAllFrom_Button());
        }

        public static void Click_Edit_Business_Unit_Grouping_button()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Edit_Business_Unit_Grouping_button());
        }

        public static void Delete_Business_Unit_Grouping_button()
        {
            Helper.ElementClick(PageObject_ReportParameter.Delete_Business_Unit_Grouping_button());
        }

        public static void iframe_Add_Business_Unit_Group()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Add_Business_Unit_Group());
        }
        public static void iframe_Room_Type_Mapping()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Room_Type_Mapping());
        }
        public static void iframe_Market_Mapping()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Market_Mapping());
        }
        public static void iframe_Channel_Mapping()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Channel_Mapping());
        }
        public static void Click_Room_Type_Code()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Room_Type_Code());
        }
        public static void Click_Room_Type_Name()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Room_Type_Name());
        }
        public static void Click_Rooms_Counted()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Rooms_Counted());
        }
        public static void Click_Rooms_Product()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Rooms_Product());
        }
        public static void Click_Business_Unit()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Business_Unit());
        }
        public static void Click_PMS_Market_Code()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_PMS_Market_Code());
        }
        public static void Click_revintel_Market_1()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_revintel_Market_1());
        }
        public static void Click_revintel_Market_2()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_revintel_Market_2());
        }
        public static void Click_PMS_Channel_Code()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_PMS_Channel_Code());
        }
        public static void Click_revintel_Channel_1()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_revintel_Channel_1());
        }
        public static void Click_revintel_Channel_2()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_revintel_Channel_2());
        }
        public static void Rainmaker_Hotel_Dropdown()
        {
            Helper.ElementClick(PageObject_ReportParameter.Rainmaker_Hotel_Dropdown());
        }
        public static void Rainmaker_Hotel_Value()
        {
            Helper.ElementClick(PageObject_ReportParameter.Rainmaker_Hotel_Value());
        }
        public static void Click_Business_Unit_Group_Sort()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Business_Unit_Group_Sort());
        }
        public static void Maintenance_Edit_testaccess()
        {
            Helper.ElementClick(PageObject_ReportParameter.Maintenance_Edit_testaccess());
        }
        public static void Click_Filter_Icon_Room_Type_Name()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Filter_Icon_Room_Type_Name());
        }
        public static void Enter_Room_Type_Name(string values)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.Enter_Room_Type_Name(),values);
        }
        public static void Filter_with_statsWith()
        {
            Helper.ElementClick(PageObject_ReportParameter.Filter_with_statsWith());
        }
        public static void Enter_Market_Name(string values)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.Enter_Market_Name(),values);
        }
        public static void Click_Filter_Icon_Market_Name()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Filter_Icon_Market_Name());
        }
        public static void Enter_Channel_Name(string values)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.Enter_Channel_Name(),values);
        }
        public static void Click_Filter_Icon_Channel_Name()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Filter_Icon_Channel_Name());
        }
        public static void Click_RoomTypeAnalysis_ComparisonYear_DDM()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_RoomTypeAnalysis_ComparisonYear_DDM());
        }
        public static void Select_RoomTypeAnalysis_ComparisonYear1()
        {
            Helper.ElementClick(PageObject_ReportParameter.Select_RoomTypeAnalysis_ComparisonYear1());
        }
        public static void Select_RoomTypeAnalysis_ComparisonYear2()
        {
            Helper.ElementClick(PageObject_ReportParameter.Select_RoomTypeAnalysis_ComparisonYear2());
        }
        public static void Select_RoomTypeAnalysis_ComparisonYear3()
        {
            Helper.ElementClick(PageObject_ReportParameter.Select_RoomTypeAnalysis_ComparisonYear3());
        }
       

        public static void Click_Compose_Menu()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Compose_Menu());
        }
        public static void Click_Compose_new_report()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Compose_new_report());
        }
        public static void Click_Compose_Create_New_Report_Close_Icon()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Compose_Create_New_Report_Close_Icon());
        }
        public static void Click_Compose_Create_New_Report_Cancel_button()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Compose_Create_New_Report_Cancel_button());
        }
        public static void iframe_Compose()
        {
            Helper.ElementClick(PageObject_ReportParameter.iframe_Compose());
        }
        public static void Click_Compose_FullscreenButton()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Compose_FullscreenButton());
        }
        public static void Click_Compose_NewReport_Create_button()
        {
            Helper.ElementClick(PageObject_ReportParameter.Click_Compose_NewReport_Create_button());
        }
        public static void Compose_Users_Report()
        {
            Helper.ElementClick(PageObject_ReportParameter.Compose_Users_Report());
        }
        public static void Compose_Users_Report_HeaderName()
        {
            Helper.ElementClick(PageObject_ReportParameter.Compose_Users_Report_HeaderName());
        }
        public static void Compose_Users_Report_HeaderName_Edit()
        {
            Helper.ElementClick(PageObject_ReportParameter.Compose_Users_Report_HeaderName_Edit());
        }
        public static void Compose_Users_Report_HeaderName_Edit_CancelButton()
        {
            Helper.ElementClick(PageObject_ReportParameter.Compose_Users_Report_HeaderName_Edit_CancelButton());
        }
        public static void Compose_Users_Report_HeaderName_CloseButton()
        {
            Helper.ElementClick(PageObject_ReportParameter.Compose_Users_Report_HeaderName_CloseButton());
        }
        public static void Compose_Enter_NewReport_Name(string value)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.Compose_Enter_NewReport_Name(),value);
        }
        public static void Compose_UserReport_Delete()
        {
            Helper.ElementClick(PageObject_ReportParameter.Compose_UserReport_Delete());
        }
        public static void Compose_UserReport_DeleteReport_Delete_Button()
        {
            Helper.ElementClick(PageObject_ReportParameter.Compose_UserReport_DeleteReport_Delete_Button());
        }
        public static void Compose_Rename_Button()
        {
            Helper.ElementClick(PageObject_ReportParameter.Compose_Rename_Button());
        }
        public static void Update_compose_report_Name(string value)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.Update_compose_report_Name(), value);
        }

        
        public static void Enter_Start_Month(string value)
        {
            Helper.ElementEnterText(PageObject_ReportParameter.Enter_Start_Month(), value);
        }

        public static void Check_Rename_Button_Disable()
        {

            if (PageObject_ReportParameter.Compose_Rename_Button().Displayed)
            {
                Compose_Rename_Button();
                Logger.WriteDebugMessage("Rename button is in disabled  mode ");
            }
            else
                Assert.Fail("Rename button is in Eabled  mode ");
        }

        public static void Compose_Create_Report_button_Disable()
        {

            if (PageObject_ReportParameter.Click_Compose_NewReport_Create_button().Displayed)
            {
                Click_Compose_NewReport_Create_button();
                Logger.WriteDebugMessage("Create button is in disabled  mode ");
            }
            else
                Assert.Fail("Create button is in Eabled  mode ");
        }
    }    
}