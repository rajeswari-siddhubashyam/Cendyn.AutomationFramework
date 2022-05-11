using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseUtility.Utility;
using InfoMessageLogger;
using NUnit.Framework;
using RevIntel.PageObject.UI;
using OpenQA.Selenium;

namespace RevIntel.AppModule.UI
{
    class ReportScheduler : Helper
    {
        public static void Click_BookingTrends()
        {
            ElementClick(PageObject_ReportScheduler.Click_BookingTrends());
        }
        public static void Click_BookingTrends_ChannelPaceAnalysis()
        {
            ElementClick(PageObject_ReportScheduler.Click_BookingTrends_ChannelPaceAnalysis());
        }
        public static void Click_BookingTrends_PickUpByDayDetailed()
        {
            ElementClick(PageObject_ReportScheduler.Click_BookingTrends_PickUpByDayDetailed());
        }
        public static void Click_BookingTrends_PaceReport()
        {
            ElementClick(PageObject_ReportScheduler.Click_BookingTrends_PaceReport());
        }
        public static void Enter_ChannelPaceAnalysis_RelativeStartDate(string value)
        {
            ElementEnterText(PageObject_ReportScheduler.Enter_ChannelPaceAnalysis_RelativeStartDate(), value);
        }
        public static void Enter_ChannelPaceAnalysis_RelativeEndDate(string value)
        {
            ElementEnterText(PageObject_ReportScheduler.Enter_ChannelPaceAnalysis_RelativeEndDate(), value);
        }
        public static void Enter_ChannelPaceAnalysis_StartDate(string value)
        {
            ElementEnterText(PageObject_ReportScheduler.Enter_ChannelPaceAnalysis_StartDate(), value);
        }
        public static void Enter_ChannelPaceAnalysis_EndDate(string value)
        {
            ElementEnterText(PageObject_ReportScheduler.Enter_ChannelPaceAnalysis_EndDate(), value);
        }
        public static void Enter_PickUpByDayDetailed_RelativeStartDate()
        {
            ElementClick(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeStartDate());
        }
        public static void Enter_PickUpByDayDetailed_RelativeEndDate()
        {
            ElementClick(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeEndDate());
        }
        public static void Enter_PickUpByDayDetailed_RelativePickupStartDate()
        {
            ElementClick(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativePickupStartDate());
        }
        public static void Enter_PickUpByDayDetailed_RelativePickupEndDate()
        {
            ElementClick(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativePickupEndDate());
        }
        public static void Enter_PickUpByDayDetailed_StartDate(string value)
        {
            ElementEnterText(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_StartDate(), value);
        }
        public static void Enter_PickUpByDayDetailed_EndDate(string value)
        {
            ElementEnterText(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_EndDate(), value);
        }
        public static void Enter_PickUpByDayDetailed_PickupStartDate(string value)
        {
            ElementEnterText(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_PickupStartDate(), value);
        }
        public static void Enter_PickUpByDayDetailed_PickupEndDate(string value)
        {
            ElementEnterText(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_PickupEndDate(), value);
        }


        public static void Click_BusinessSource()
        {
            ElementClick(PageObject_ReportScheduler.Click_BusinessSource());
        }
        public static void Click_BusinessSource_RoomTypeAnalysis()
        {
            ElementClick(PageObject_ReportScheduler.Click_BusinessSource_RoomTypeAnalysis());
        }
        public static void Click_BusinessSource_MarketReport()
        {
            ElementClick(PageObject_ReportScheduler.Click_BusinessSource_MarketReport());
        }
        public static void Enter_ReportDescription(string value)
        {
            ElementEnterText(PageObject_ReportScheduler.Enter_ReportDescription(), value);
        }
        public static void Click_Tuesday()
        {
            ElementClick(PageObject_ReportScheduler.Click_Tuesday());
        }
        public static void Click_Wednesday()
        {
            ElementClick(PageObject_ReportScheduler.Click_Wednesday());
        }
        public static void Click_Thursday()
        {
            ElementClick(PageObject_ReportScheduler.Click_Thursday());
        }
        public static void Click_Friday()
        {
            ElementClick(PageObject_ReportScheduler.Click_Friday());
        }
        public static void Enter_StartTimeHours(string value)
        {
            ElementEnterText(PageObject_ReportScheduler.Enter_StartTimeHours(), value);
        }
        public static void Enter_StartTimeMinutes(string value)
        {
            ElementEnterText(PageObject_ReportScheduler.Enter_StartTimeMinutes(), value);
        }
        public static void Enter_OnCalendarDays(string value)
        {
            ElementEnterText(PageObject_ReportScheduler.Enter_OnCalendarDays(), value);
        }
        public static void Enter_RendorFormat()
        {
            ElementClick(PageObject_ReportScheduler.Enter_RendorFormat());
        }
        public static void Enter_EmailTo(string value)
        {
            ElementEnterText(PageObject_ReportScheduler.Enter_EmailTo(), value);
        }
        public static void Enter_EmailSubject(string value)
        {
            ElementEnterText(PageObject_ReportScheduler.Enter_EmailSubject(), value);
        }
        public static void Enter_RelativeStartDateOffset(string value)
        {
            ElementEnterText(PageObject_ReportScheduler.Enter_RelativeStartDateOffset(), value);
        }
        public static void Enter_RelativeEndDateOffset(string value)
        {
            ElementEnterText(PageObject_ReportScheduler.Enter_RelativeEndDateOffset(), value);
        }
        public static void Click_RoomTypeAnalysis_SaveButton()
        {
            DynamicScroll(Driver, PageObject_ReportScheduler.Click_RoomTypeAnalysis_SaveButton());
            ElementClick(PageObject_ReportScheduler.Click_RoomTypeAnalysis_SaveButton());
        }
        public static void Enter_AsOfDate(string value)
        {
            ElementEnterText(PageObject_ReportScheduler.Enter_AsOfDate(), value);
        }
        public static void Enter_RelativeAsOfDate(string value)
        {
            ElementEnterText(PageObject_ReportScheduler.Enter_RelativeAsOfDate(), value);
        }







        public static void Click_CurrentDate_RelativeSatrtDate()
        {
            ElementClick(PageObject_ReportScheduler.Click_CurrentDate_RelativeSatrtDate());
        }
        public static void Click_CurrentDate_RelativeEndDate()
        {
            ElementClick(PageObject_ReportScheduler.Click_CurrentDate_RelativeEndDate());
        }
        public static void Click_CurrentDate_RelativePickupSatrtDate()
        {
            ElementClick(PageObject_ReportScheduler.Click_CurrentDate_RelativePickupSatrtDate());
        }
        public static void Click_CurrentDate_RelativePickupEndDate()
        {
            ElementClick(PageObject_ReportScheduler.Click_CurrentDate_RelativePickupEndDate());
        }
        public static void Click_SelectDate_RelativeStartDate()
        {
            ElementClick(PageObject_ReportScheduler.Click_SelectDate_RelativeStartDate());
        }
        public static void Click_SelectDate_RelativeEndDate()
        {
            ElementClick(PageObject_ReportScheduler.Click_SelectDate_RelativeEndDate());
        }
        public static void Click_SelectDate_RelativePickupStartDate()
        {
            ElementClick(PageObject_ReportScheduler.Click_SelectDate_RelativePickupStartDate());
        }
        public static void Click_SelectDate_RelativePickupEndDate()
        {
            ElementClick(PageObject_ReportScheduler.Click_SelectDate_RelativePickupEndDate());
        }

        public static void Select_CurrentDate_RelativeStartDate()
        {
            Enter_PickUpByDayDetailed_RelativeStartDate();
            Click_CurrentDate_RelativeSatrtDate();
        }
        public static void Select_CurrentDate_RelativeEndDate()
        {
            Enter_PickUpByDayDetailed_RelativeEndDate();
            Click_CurrentDate_RelativeEndDate();
        }
        public static void Select_CurrentDate_RelativePickupStartDate()
        {
            Enter_PickUpByDayDetailed_RelativePickupStartDate();
            Click_CurrentDate_RelativePickupSatrtDate();
        }
        public static void Select_CurrentDate_RelativePickupEndDate()
        {
            Enter_PickUpByDayDetailed_RelativePickupEndDate();
            Click_CurrentDate_RelativePickupEndDate();
        }
        public static void Select_SelectDate_RelativeStartDate()
        {
            Enter_PickUpByDayDetailed_RelativeStartDate();
            Click_SelectDate_RelativeStartDate();
        }
        public static void Select_SelectDate_RelativeEndDate()
        {
            Enter_PickUpByDayDetailed_RelativeEndDate();
            Click_SelectDate_RelativeEndDate();
        }
        public static void Select_SelectDate_RelativePickupStartDate()
        {
            Enter_PickUpByDayDetailed_RelativePickupStartDate();
            Click_SelectDate_RelativePickupStartDate();
        }
        public static void Select_SelectDate_RelativePickupEndDate()
        {
            Enter_PickUpByDayDetailed_RelativePickupEndDate();
            Click_SelectDate_RelativePickupEndDate();
        }
        public static void Click_ReportType_Excel()
        {
            ElementClick(PageObject_ReportScheduler.Click_ReportType_Excel());
        }




        public static void Check_RelativeDatesDisabled()
        {
            string relativeStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeStartDate().GetAttribute("class");
            if (relativeStartDate.Contains("Disabled"))
                Logger.WriteDebugMessage("Relative start date and offset is disabled for Pickup by day detailed");
            else
                Assert.Fail("Relative start date is enabled for Pickup by day detailed");
            string relativeEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeEndDate().GetAttribute("class");
            if (relativeEndDate.Contains("Disabled"))
                Logger.WriteDebugMessage("Relative end date and offset is disabled for Pickup by day detailed");
            else
                Assert.Fail("Relative end date is enabled for Pickup by day detailed");
            string relativePickupStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativePickupStartDate().GetAttribute("class");
            if (relativePickupStartDate.Contains("Disabled"))
                Logger.WriteDebugMessage("Relative pickup start date and offset is disabled for Pickup by day detailed");
            else
                Assert.Fail("Relative pickup start date is enabled for Pickup by day detailed");
            AddDelay(20000);
            string relativePickupEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativePickupEndDate().GetAttribute("class");
            if (relativePickupEndDate.Contains("Disabled"))
                Logger.WriteDebugMessage("Relative pickup end date and offset is disabled for Pickup by day detailed");
            else
                Assert.Fail("Relative pickup end is enabled for Pickup by day detailed");
        }
        public static void Clear_AbsoluteDates()
        {
            ReportScheduler.Enter_PickUpByDayDetailed_StartDate("");
            ReportScheduler.Enter_PickUpByDayDetailed_EndDate("");
            ReportScheduler.Enter_PickUpByDayDetailed_PickupStartDate("");
            ReportScheduler.Enter_PickUpByDayDetailed_PickupEndDate("");
            Logger.WriteDebugMessage("Absolute dates has cleared for Pickup by day detailed");

            string relativeStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeStartDate().GetAttribute("class");
            if (relativeStartDate.Contains("Disabled"))
                Assert.Fail("Relative start date is Disabled for Pickup by day detailed");
            else
                Logger.WriteDebugMessage("Relative start date is enabled for Pickup by day detailed");
            Logger.WriteDebugMessage("Relative start date offset is disabled for Pickup by day detailed");
            string relativeEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeEndDate().GetAttribute("class");
            if (relativeEndDate.Contains("Disabled"))
                Assert.Fail("Relative end date is Disabled for Pickup by day detailed");
            else
                Logger.WriteDebugMessage("Relative end date is enabled for Pickup by day detailed");
            Logger.WriteDebugMessage("Relative end date offset is disabled for Pickup by day detailed");
            string relativePickupStartDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativePickupStartDate().GetAttribute("class");
            if (relativePickupStartDate.Contains("Disabled"))
                Assert.Fail("Relative pickup start date is Disabled for Pickup by day detailed");
            else
                Logger.WriteDebugMessage("Relative pickup start date is enabled for Pickup by day detailed");
            Logger.WriteDebugMessage("Relative pickup start date offset is disabled for Pickup by day detailed");

            AddDelay(15000);
            string relativePickupEndDate = PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativePickupEndDate().GetAttribute("class");
            if (relativePickupEndDate.Contains("Disabled"))
                Assert.Fail("Relative pickup end is Disabled for Pickup by day detailed");
            else
                Logger.WriteDebugMessage("Relative pickup end date is enabled for Pickup by day detailed");
            Logger.WriteDebugMessage("Relative pickup end date offset is disabled for Pickup by day detailed");
        }
        public static void AddSchedule(string description, string hours, string minutes, string email, string subject, string startDate, string endDate)
        {
            Enter_ReportDescription(description);
            //VerifyTextOnPageAndHighLight("Day");
            Enter_StartTimeHours(hours);
            Enter_StartTimeMinutes(minutes);
            VerifyTextOnPageAndHighLight("Time Zone");
            Click_Tuesday();
            Enter_StartTimeMinutes("00");
            Click_Wednesday();
            Click_Thursday();
            Click_Friday();
            //Enter_RendorFormat();
            //Click_ReportType_Excel();
            Logger.WriteDebugMessage("Details are entered like description,Time,Report Type and weekdays");
            Enter_EmailTo(email);
            Enter_EmailSubject(subject);
            Logger.WriteDebugMessage("Email and Subject entered");
            ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeStartDate());
            Enter_PickUpByDayDetailed_StartDate(startDate);
            Enter_PickUpByDayDetailed_EndDate(endDate);
            Enter_AsOfDate(startDate);
            Logger.WriteDebugMessage("Start and End date entered");
            Click_RoomTypeAnalysis_SaveButton();
            AddDelay(60000);
            Logger.WriteDebugMessage("Saved successfully");
        }
        public static void AddScheduleMonth(string description, string hours, string minutes, string email, string subject, string startDate, string endDate)
        {
            Enter_ReportDescription(description);
            Click_Month();
            VerifyTextOnPageAndHighLight("Month");
            //Click_OnCalendarDays();
            //AddDelay(30000);
            Enter_OnCalendarDays("10");
            Enter_StartTimeHours(hours);
            Enter_StartTimeMinutes(minutes);
            //Click_Tuesday();
            Enter_StartTimeMinutes("00");
            //Click_Wednesday();
            //Click_Thursday();
            //Click_Friday();
            //Enter_RendorFormat();
            //Click_ReportType_Excel();
            Logger.WriteDebugMessage("Details are entered like description,Time,Report Type and weekdays");
            Enter_EmailTo(email);
            Enter_EmailSubject(subject);
            Logger.WriteDebugMessage("Email and Subject entered");
            ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeStartDate());
            Enter_PickUpByDayDetailed_StartDate(startDate);
            Enter_PickUpByDayDetailed_EndDate(endDate);
            Enter_AsOfDate(startDate);
            Logger.WriteDebugMessage("Start and End date entered");
            Click_RoomTypeAnalysis_SaveButton();
            AddDelay(60000);
            Logger.WriteDebugMessage("Saved successfully");
        }
        public static void AddScheduleOnce(string description, string hours, string minutes, string email, string subject, string startDate, string endDate)
        {
            Enter_ReportDescription(description);
            Click_Once();
            Enter_StartTimeHours(hours);
            Enter_StartTimeMinutes(minutes);
            //Click_Tuesday();
            Enter_StartTimeMinutes("00");
            //Click_Wednesday();
            //Click_Thursday();
            //Click_Friday();
            //Enter_RendorFormat();
            //Click_ReportType_Excel();
            Logger.WriteDebugMessage("Details are entered like description,Time,Report Type and weekdays");
            Enter_EmailTo(email);
            Enter_EmailSubject(subject);
            Logger.WriteDebugMessage("Email and Subject entered");
            ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeStartDate());
            Enter_PickUpByDayDetailed_StartDate(startDate);
            Enter_PickUpByDayDetailed_EndDate(endDate);
            Enter_AsOfDate(startDate);
            Logger.WriteDebugMessage("Start and End date entered");
            Click_RoomTypeAnalysis_SaveButton();
            AddDelay(60000);
            Logger.WriteDebugMessage("Saved successfully");
        }

        public static void Click_SaveSchedule_OkButton()
        {
            ElementClick(PageObject_ReportScheduler.Click_SaveSchedule_OkButton());
        }
        public static void Click_ManageReportSchedule_EditButton()
        {
            ElementClick(PageObject_ReportScheduler.Click_ManageReportSchedule_EditButton());
        }
        public static void Click_RelativeAsOfDate()
        {
            ElementClick(PageObject_ReportScheduler.Enter_RelativeAsOfDate());
        }
        public static void Click_RelativeAsOfDate_Currentmonth()
        {
            ElementClick(PageObject_ReportScheduler.Click_RelativeAsOfDate_Currentmonth());
        }
        public static void Select_RelativeAsOfDate_CurrentMonth()
        {
            Click_RelativeAsOfDate();
            Click_RelativeAsOfDate_Currentmonth();
        }
        public static void Select_RelativeAsOfDate_Blank()
        {
            Click_RelativeAsOfDate();
            Select_Blank_RelativeAsOfDate();
        }

        public static void Click_RelativeAsOfDate_Offset(string value)
        {
            ElementEnterText(PageObject_ReportScheduler.Click_RelativeAsOfDate_Offset(), value);
        }
        public static void Enter_RelativePickUpStartDateOffset(string value)
        {
            ElementEnterText(PageObject_ReportScheduler.Enter_RelativePickUpStartDateOffset(), value);
        }
        public static void Enter_RelativePickUpEndDateOffset(string value)
        {
            ElementEnterText(PageObject_ReportScheduler.Enter_RelativePickUpEndDateOffset(), value);
        }
        public static void Click_ManageReportSchedule_DeleteButton()
        {
            ElementClick(PageObject_ReportScheduler.Click_ManageReportSchedule_DeleteButton());
        }
        public static void Click_Month()
        {
            ElementClick(PageObject_ReportScheduler.Click_Month());
        }
        public static void Click_Once()
        {
            ElementClick(PageObject_ReportScheduler.Click_Once());
        }
        public static void Click_OnCalendarDays()
        {
            ElementClick(PageObject_ReportScheduler.Click_OnCalendarDays());
        }
        public static void Click_Quick_RelativeDate()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_RelativeDate());
        }
        public static void Click_Quick_RelativeDateToday()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_RelativeDateToday());
        }
        public static void Click_Quick_RelativePickupDate()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_RelativePickupDate());
        }
        public static void Click_Quick_RelativePickupDateToday()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_RelativePickupDateToday());
        }
        public static void Click_Quick_AbsoluteDate()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_AbsoluteDate());
        }
        public static void Click_Quick_AbsoluteDateToday()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_AbsoluteDateToday());
        }
        public static void Click_Quick_AbsolutePickupDate()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_AbsolutePickupDate());
        }
        public static void Click_Quick_AbsolutePickupDateToday()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_AbsolutePickupDateToday());
        }
        public static void Click_Quick_AbsoluteDateYesterday()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_AbsoluteDateYesterday());
        }
        public static void Click_Quick_AbsoluteDateMTM()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_AbsoluteDateMTM());
        }
        public static void Click_Quick_AbsoluteDateYTD()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_AbsoluteDateYTD());
        }
        public static void Click_Quick_AbsoluteDateLastMonth()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_AbsoluteDateLastMonth());
        }
        public static void Click_Quick_AbsoluteDateThisMonth()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_AbsoluteDateThisMonth());
        }
        public static void Click_Quick_AbsoluteDateNextMonth()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_AbsoluteDateNextMonth());
        }
        public static void Click_Quick_AbsoluteDateLastYear()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_AbsoluteDateLastYear());
        }
        public static void Click_Quick_AbsoluteDateThisYear()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_AbsoluteDateThisYear());
        }
        public static void Click_Quick_AbsoluteDateEndOfYear()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_AbsoluteDateEndOfYear());
        }
        public static void Click_Quick_AbsolutePickupDateYesterday()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_AbsolutePickupDateYesterday());
        }
        public static void Click_Quick_AbsolutePickupDateMTM()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_AbsolutePickupDateMTM());
        }
        public static void Click_Quick_AbsolutePickupDateYTD()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_AbsolutePickupDateYTD());
        }
        public static void Click_Quick_AbsolutePickupDateLastMonth()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_AbsolutePickupDateLastMonth());
        }
        public static void Click_Quick_AbsolutePickupDateThisMonth()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_AbsolutePickupDateThisMonth());
        }
        public static void Click_Quick_AbsolutePickupDateNextMonth()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_AbsolutePickupDateNextMonth());
        }
        public static void Click_Quick_AbsolutePickupDateLastYear()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_AbsolutePickupDateLastYear());
        }
        public static void Click_Quick_AbsolutePickupDateThisYear()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_AbsolutePickupDateThisYear());
        }
        public static void Click_Quick_AbsolutePickupDateEndOfYear()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_AbsolutePickupDateEndOfYear());
        }
        public static void Click_Quick_RelativeDateYesteraday()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_RelativeDateYesteraday());
        }
        public static void Click_Quick_RelativeDateLastMonth()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_RelativeDateLastMonth());
        }
        public static void Click_Quick_RelativeDateThisMonth()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_RelativeDateThisMonth());
        }
        public static void Click_Quick_RelativeDateNextMonth()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_RelativeDateNextMonth());
        }
        public static void Click_Quick_RelativeDateLastYear()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_RelativeDateLastYear());
        }
        public static void Click_Quick_RelativeDateThisYear()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_RelativeDateThisYear());
        }
        public static void Click_Quick_RelativePickupDateYesteraday()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_RelativePickupDateYesteraday());
        }
        public static void Click_Quick_RelativePickupDateLastMonth()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_RelativePickupDateLastMonth());
        }
        public static void Click_Quick_RelativePickupDateThisMonth()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_RelativePickupDateThisMonth());
        }
        public static void Click_Quick_RelativePickupDateNextMonth()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_RelativePickupDateNextMonth());
        }
        public static void Click_Quick_RelativePickupDateLastYear()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_RelativePickupDateLastYear());
        }
        public static void Click_Quick_RelativePickupDateThisYear()
        {
            ElementClick(PageObject_ReportScheduler.Click_Quick_RelativePickupDateThisYear());
        }
        public static void Click_Portfolio()
        {
            ElementClick(PageObject_ReportScheduler.Click_Portfolio());
        }
        public static void Click_BookingTrends_AgentByHotel()
        {
            ElementClick(PageObject_ReportScheduler.Click_BookingTrends_AgentByHotel());
        }
        public static void Click_SelectType()
        {
            ElementClick(PageObject_ReportScheduler.Click_SelectType());
        }
        public static void ReportScheduler_GetHotel()
        {
            ElementClick(PageObject_ReportScheduler.ReportScheduler_GetHotel());
        }
        public static void ReportScheduler_GetBusinessUnit()
        {
            ElementClick(PageObject_ReportScheduler.ReportScheduler_GetBusinessUnit());
        }
        public static void ReportScheduler_GetCurrency()
        {
            ElementClick(PageObject_ReportScheduler.ReportScheduler_GetCurrency());
        }
        public static void Select_Blank_RelativeAsOfDate()
        {
            ElementClick(PageObject_ReportScheduler.Select_Blank_RelativeAsOfDate());
        }



        public static void Click_ReportParameter_Market()
        {
            ElementClick(PageObject_ReportScheduler.Click_ReportParameter_Market());
        }
        public static void Click_Market_MarketReport()
        {
            ElementClick(PageObject_ReportScheduler.Click_Market_MarketReport());
        }
        public static void Click_ReportType(string value)
        {
            ElementClick(PageObject_ReportScheduler.Click_ReportType(value));
        }
        public static void Click_SelectType_Hotel()
        {
            ElementClick(PageObject_ReportScheduler.Click_SelectType_Hotel());
        }
        public static void Select_SelectType_Portfolio()
        {
            ElementClick(PageObject_ReportScheduler.Select_SelectType_Portfolio());
            Logger.WriteDebugMessage("Hotel Type - 'Portfolio' selected.");
        }
        public static void Click_InvalidSelection_OkButton()
        {
            ElementClick(PageObject_ReportScheduler.Click_InvalidSelection_OkButton());
        }
        public static void AddSchedule_WithReportType(string description, string hours, string minutes, string email, string subject, string startDate, string endDate, string reportTpe)
        {
            Enter_ReportDescription(description);
            //VerifyTextOnPageAndHighLight("Day");
            Enter_StartTimeHours(hours);
            Enter_StartTimeMinutes(minutes);
            VerifyTextOnPageAndHighLight("Time Zone");
            Click_Tuesday();
            Enter_StartTimeMinutes("00");
            Click_Wednesday();
            Click_Thursday();
            Click_Friday();
            Enter_RendorFormat();
            Click_ReportType(reportTpe);
            Logger.WriteDebugMessage("Details are entered like description,Time,Report Type and weekdays");
            Enter_EmailTo(email);
            Enter_EmailSubject(subject);
            Logger.WriteDebugMessage("Email and Subject entered");
            ScrollToElement(PageObject_ReportScheduler.Enter_PickUpByDayDetailed_RelativeStartDate());
            Enter_PickUpByDayDetailed_StartDate(startDate);
            Enter_PickUpByDayDetailed_EndDate(endDate);
            //Enter_AsOfDate(startDate);
            Logger.WriteDebugMessage("Start and End date entered");
            Click_RoomTypeAnalysis_SaveButton();
            AddDelay(120000);
            Logger.WriteDebugMessage("Saved successfully");
        }
        public static void Click_InvalidSelection_OkButton(string frame)
        {
            ElementClick(PageObject_ReportScheduler.Click_InvalidSelection_OkButton(frame));
        }
        public static void Select_SelectType_Hotel()
        {
            ElementClick(PageObject_ReportScheduler.Select_SelectType_Hotel());
        }
        public static void Click_HotelOrPortfolio()
        {
            ElementClick(PageObject_ReportScheduler.Click_HotelOrPortfolio());
        }
        public static void Select_HotelName(string value)
        {
            ElementClick(PageObject_ReportScheduler.Select_HotelName(value));
        }

        public static void SelectAbsoluteQuickDaySelection(string dayValue)
        {
            Click_Quick_AbsoluteDate();
            Logger.WriteDebugMessage("Quick Absolute date is clicked");
            string elem = "//div[@id='RcmQuickStaticStartDate_detached']//a[@class='rmLink']//span[contains(text(), '" + dayValue + "')]";
            ElementClick(Driver.FindElement(By.XPath(elem)));
            Logger.WriteDebugMessage("Clicked on " + dayValue + " Absolute Start Date");
        }
        public static void SelectAbsolutePickUpDaySelection(string dayValue)
        {
            Click_Quick_AbsolutePickupDate();
            Logger.WriteDebugMessage("Quick Absolute date is clicked");
            string elem = "//div[@id='RcmQuickStaticPickupStartDate_detached']//a[@class='rmLink']//span[contains(text(), '" + dayValue + "')]";
            ElementClick(Driver.FindElement(By.XPath(elem)));
            Logger.WriteDebugMessage("Clicked on " + dayValue + " Absolute Start Date");
        }

        public static void SelectRelativeQuickDaySelection(string dayValue)
        {
            Click_Quick_RelativeDate();
            Logger.WriteDebugMessage("Quick Relative date is clicked");
            string elem = "//div[@id='RcmQuickStartDate_detached']//a[@class='rmLink']//span[contains(text(), '"+ dayValue +"')]";
            ElementClick(Driver.FindElement(By.XPath(elem)));
            Logger.WriteDebugMessage("Clicked on " + dayValue + " Absolute Start Date");
        }
        public static void SelectRelativePickUpSelection(string dayValue)
        {
            Click_Quick_RelativePickupDate();
            Logger.WriteDebugMessage("Quick Relative Pick Up date is clicked");
            string elem = "//div[@id='RcmQuickPickupStartDate_detached']//a[@class='rmLink']//span[contains(text(), '"+ dayValue +"')]";
            ElementClick(Driver.FindElement(By.XPath(elem)));
            Logger.WriteDebugMessage("Clicked on " + dayValue + " Absolute Start Date");
        }

        public static void CompareAbsoluteQuickStartEndDate(string dayValue)
        {
            string setDate = "";
            string getStartDate = "";
            string getEndDate = "";
            switch (dayValue)
            {
                case "Yesterday":
                    setDate = DateTime.Now.AddDays(-1).ToString("M/d/yyyy");
                    getStartDate = Driver.FindElement(By.XPath("//input[@id='DeliveryConfigPanelBar_i4_StartDt_dateInput']")).Text;
                    getEndDate = Driver.FindElement(By.XPath("//input[@id='DeliveryConfigPanelBar_i4_EndDt_dateInput']")).Text;

                    if (VerifyTextOnPage(setDate))
                    {
                        Logger.WriteDebugMessage("Absolute Start Date and End Date " + setDate + " matched with quick selected day - " + dayValue);
                    }
                    else
                    {
                        Assert.Fail("Absolute Start Date and End Date " + setDate + " did not matched with quick selected day - " + dayValue);
                    }
                    break;
                case "Today":
                    setDate = DateTime.Now.ToString("M/d/yyyy");
                    getStartDate = Driver.FindElement(By.XPath("//input[@id='DeliveryConfigPanelBar_i4_StartDt_dateInput']")).Text;
                    getEndDate = Driver.FindElement(By.XPath("//input[@id='DeliveryConfigPanelBar_i4_EndDt_dateInput']")).Text;

                    if (VerifyTextOnPage(setDate))
                    {
                        Logger.WriteDebugMessage("Absolute Start Date and End Date " + setDate + " matched with quick selected day - " + dayValue);
                    }
                    else
                    {
                        Assert.Fail("Absolute Start Date and End Date " + setDate + " did not matched with quick selected day - " + dayValue);
                    }
                    break;
                case "MTD":
                    DateTime now = DateTime.Now;
                    var startDate = new DateTime(now.Year, now.Month, 1);
                    string startDate_MTD = startDate.AddMonths(0).AddDays(0).ToString("M/d/yyyy");
                    string endDate = DateTime.Now.ToString("M/d/yyyy");
                    getStartDate = Driver.FindElement(By.XPath("//input[@id='DeliveryConfigPanelBar_i4_StartDt_dateInput']")).Text;
                    getEndDate = Driver.FindElement(By.XPath("//input[@id='DeliveryConfigPanelBar_i4_EndDt_dateInput']")).Text;

                    if (VerifyTextOnPage(startDate_MTD) && VerifyTextOnPage(endDate))
                    {
                        Logger.WriteDebugMessage("Absolute Start Date " + startDate_MTD + " and End Date " + endDate + " matched with quick selected day - " + dayValue);
                    }
                    else
                    {
                        Assert.Fail("Absolute Start Date " + startDate_MTD + " and End Date " + endDate + " did not matched with quick selected day - " + dayValue);
                    }
                    break;
                case "YTD":
                    now = DateTime.Now;
                    startDate = new DateTime(now.Year, 1, 1);
                    string startDate_YTD = startDate.AddMonths(0).AddDays(0).ToString("M/d/yyyy");
                    endDate = DateTime.Now.ToString("M/d/yyyy");
                    getStartDate = Driver.FindElement(By.XPath("//input[@id='DeliveryConfigPanelBar_i4_StartDt_dateInput']")).Text;
                    getEndDate = Driver.FindElement(By.XPath("//input[@id='DeliveryConfigPanelBar_i4_EndDt_dateInput']")).Text;

                    if (VerifyTextOnPage(startDate_YTD) && VerifyTextOnPage(endDate))
                    {
                        Logger.WriteDebugMessage("Absolute Start Date " + startDate_YTD + " and End Date " + endDate + " matched with quick selected day - " + dayValue);
                    }
                    else
                    {
                        Assert.Fail("Absolute Start Date " + startDate_YTD + " and End Date " + endDate + " did not matched with quick selected day - " + dayValue);
                    }
                    break;
                case "Last month":
                    now = DateTime.Now;
                    var month = new DateTime(now.Year, now.Month, 1);
                    string lastMonth_first = month.AddMonths(-1).ToString("M/d/yyyy");
                    string lastMonth_last = month.AddDays(-1).ToString("M/d/yyyy");

                    getStartDate = Driver.FindElement(By.XPath("//input[@id='DeliveryConfigPanelBar_i4_StartDt_dateInput']")).Text;
                    getEndDate = Driver.FindElement(By.XPath("//input[@id='DeliveryConfigPanelBar_i4_EndDt_dateInput']")).Text;

                    if (VerifyTextOnPage(lastMonth_first) && VerifyTextOnPage(lastMonth_last))
                    {
                        Logger.WriteDebugMessage("Absolute Start Date " + lastMonth_first + " and End Date " + lastMonth_last + " matched with quick selected day - " + dayValue);
                    }
                    else
                    {
                        Assert.Fail("Absolute Start Date " + lastMonth_first + " and End Date " + lastMonth_last + " did not matched with quick selected day - " + dayValue);
                    }
                    break;
                case "This month":
                    now = DateTime.Now;
                    month = new DateTime(now.Year, now.Month, 1);
                    lastMonth_first = month.AddMonths(0).ToString("M/d/yyyy");
                    lastMonth_last = month.AddMonths(1).AddDays(-1).ToString("M/d/yyyy");

                    getStartDate = Driver.FindElement(By.XPath("//input[@id='DeliveryConfigPanelBar_i4_StartDt_dateInput']")).Text;
                    getEndDate = Driver.FindElement(By.XPath("//input[@id='DeliveryConfigPanelBar_i4_EndDt_dateInput']")).Text;

                    if (VerifyTextOnPage(lastMonth_first) && VerifyTextOnPage(lastMonth_last))
                    {
                        Logger.WriteDebugMessage("Absolute Start Date " + lastMonth_first + " and End Date " + lastMonth_last + " matched with quick selected day - " + dayValue);
                    }
                    else
                    {
                        Assert.Fail("Absolute Start Date " + lastMonth_first + " and End Date " + lastMonth_last + " did not matched with quick selected day - " + dayValue);
                    }
                    break;
                case "Next month":
                    now = DateTime.Now;
                    month = new DateTime(now.Year, now.Month, 1);
                    lastMonth_first = month.AddMonths(1).ToString("M/d/yyyy");
                    lastMonth_last = month.AddMonths(2).AddDays(-1).ToString("M/d/yyyy");

                    getStartDate = Driver.FindElement(By.XPath("//input[@id='DeliveryConfigPanelBar_i4_StartDt_dateInput']")).Text;
                    getEndDate = Driver.FindElement(By.XPath("//input[@id='DeliveryConfigPanelBar_i4_EndDt_dateInput']")).Text;

                    if (VerifyTextOnPage(lastMonth_first) && VerifyTextOnPage(lastMonth_last))
                    {
                        Logger.WriteDebugMessage("Absolute Start Date " + lastMonth_first + " and End Date " + lastMonth_last + " matched with quick selected day - " + dayValue);
                    }
                    else
                    {
                        Assert.Fail("Absolute Start Date " + lastMonth_first + " and End Date " + lastMonth_last + " did not matched with quick selected day - " + dayValue);
                    }
                    break;
                case "Last year":
                    int year = DateTime.Now.Year;
                    DateTime firstDay = new DateTime(year, 1, 1);
                    firstDay = firstDay.AddYears(-1);
                    DateTime lastDay = firstDay.AddYears(1).AddTicks(-1);

                    string firstDayofYear = firstDay.ToString("M/d/yyyy");
                    string lastDayofYear = lastDay.ToString("M/d/yyyy");

                    getStartDate = Driver.FindElement(By.XPath("//input[@id='DeliveryConfigPanelBar_i4_StartDt_dateInput']")).Text;
                    getEndDate = Driver.FindElement(By.XPath("//input[@id='DeliveryConfigPanelBar_i4_EndDt_dateInput']")).Text;

                    if (VerifyTextOnPage(firstDayofYear) && VerifyTextOnPage(lastDayofYear))
                    {
                        Logger.WriteDebugMessage("Absolute Start Date " + firstDayofYear + " and End Date " + lastDayofYear + " matched with quick selected day - " + dayValue);
                    }
                    else
                    {
                        Assert.Fail("Absolute Start Date " + firstDayofYear + " and End Date " + lastDayofYear + " did not matched with quick selected day - " + dayValue);
                    }
                    break;
                case "This year":
                    year = DateTime.Now.Year;
                    firstDay = new DateTime(year, 1, 1);
                    firstDay = firstDay.AddYears(0);
                    lastDay = firstDay.AddYears(1).AddTicks(-1);

                    firstDayofYear = firstDay.ToString("M/d/yyyy");
                    lastDayofYear = lastDay.ToString("M/d/yyyy");

                    getStartDate = Driver.FindElement(By.XPath("//input[@id='DeliveryConfigPanelBar_i4_StartDt_dateInput']")).Text;
                    getEndDate = Driver.FindElement(By.XPath("//input[@id='DeliveryConfigPanelBar_i4_EndDt_dateInput']")).Text;

                    if (VerifyTextOnPage(firstDayofYear) && VerifyTextOnPage(lastDayofYear))
                    {
                        Logger.WriteDebugMessage("Absolute Start Date " + firstDayofYear + " and End Date " + lastDayofYear + " matched with quick selected day - " + dayValue);
                    }
                    else
                    {
                        Assert.Fail("Absolute Start Date " + firstDayofYear + " and End Date " + lastDayofYear + " did not matched with quick selected day - " + dayValue);
                    }
                    break;
                case "Date to end of year":
                    setDate = DateTime.Now.ToString("M/d/yyyy");
                    year = DateTime.Now.Year;
                    firstDay = new DateTime(year, 1, 1);
                    lastDay = firstDay.AddYears(1).AddTicks(-1);

                    lastDayofYear = lastDay.ToString("M/d/yyyy");

                    getStartDate = Driver.FindElement(By.XPath("//input[@id='DeliveryConfigPanelBar_i4_StartDt_dateInput']")).Text;
                    getEndDate = Driver.FindElement(By.XPath("//input[@id='DeliveryConfigPanelBar_i4_EndDt_dateInput']")).Text;

                    if (VerifyTextOnPage(setDate) && VerifyTextOnPage(lastDayofYear))
                    {
                        Logger.WriteDebugMessage("Absolute Start Date and End Date matched with quick selected day - " + dayValue);
                    }
                    else
                    {
                        Assert.Fail("Absolute Start Date " + setDate + " and End Date " + lastDayofYear + " did not matched with quick selected day - " + dayValue);
                    }
                    break;
            }
        }

        public static void ComparePickUpStartEndDate(string dayValue)
        {
            string setDate = "";
            string getStartDate = Driver.FindElement(By.XPath("//input[@id='DeliveryConfigPanelBar_i4_PickupStartDt_dateInput']")).Text;
            string getEndDate = Driver.FindElement(By.XPath("//input[@id='DeliveryConfigPanelBar_i4_PickupEndDt_dateInput']")).Text;
            switch (dayValue)
            {
                case "Yesterday":
                    setDate = DateTime.Now.AddDays(-1).ToString("M/d/yyyy");
                    
                    if (VerifyTextOnPage(setDate))
                    {
                        Logger.WriteDebugMessage("Pick Up Start Date and End Date " + setDate + " matched with quick selected day - " + dayValue);
                    }
                    else
                    {
                        Assert.Fail("Pick Up Start Date and End Date " + setDate + " did not matched with quick selected day - " + dayValue);
                    }
                    break;
                case "Today":
                    setDate = DateTime.Now.ToString("M/d/yyyy");
                    
                    if (VerifyTextOnPage(setDate))
                    {
                        Logger.WriteDebugMessage("Pick Up Start Date and End Date " + setDate + " matched with quick selected day - " + dayValue);
                    }
                    else
                    {
                        Assert.Fail("Pick Up Start Date and End Date " + setDate + " did not matched with quick selected day - " + dayValue);
                    }
                    break;
                case "MTD":
                    DateTime now = DateTime.Now;
                    var startDate = new DateTime(now.Year, now.Month, 1);
                    string startDate_MTD = startDate.AddMonths(0).AddDays(0).ToString("M/d/yyyy");
                    string endDate = DateTime.Now.ToString("M/d/yyyy");
                    
                    if (VerifyTextOnPage(startDate_MTD) && VerifyTextOnPage(endDate))
                    {
                        Logger.WriteDebugMessage("Pick Up Start Date " + startDate_MTD + " and End Date " + endDate + " matched with quick selected day - " + dayValue);
                    }
                    else
                    {
                        Assert.Fail("Pick Up Start Date " + startDate_MTD + " and End Date " + endDate + " did not matched with quick selected day - " + dayValue);
                    }
                    break;
                case "YTD":
                    now = DateTime.Now;
                    startDate = new DateTime(now.Year, 1, 1);
                    string startDate_YTD = startDate.AddMonths(0).AddDays(0).ToString("M/d/yyyy");
                    endDate = DateTime.Now.ToString("M/d/yyyy");
                    
                    if (VerifyTextOnPage(startDate_YTD) && VerifyTextOnPage(endDate))
                    {
                        Logger.WriteDebugMessage("Pick Up Start Date " + startDate_YTD + " and End Date " + endDate + " matched with quick selected day - " + dayValue);
                    }
                    else
                    {
                        Assert.Fail("Pick Up Start Date " + startDate_YTD + " and End Date " + endDate + " did not matched with quick selected day - " + dayValue);
                    }
                    break;
                case "Last month":
                    now = DateTime.Now;
                    var month = new DateTime(now.Year, now.Month, 1);
                    string lastMonth_first = month.AddMonths(-1).ToString("M/d/yyyy");
                    string lastMonth_last = month.AddDays(-1).ToString("M/d/yyyy");

                    if (VerifyTextOnPage(lastMonth_first) && VerifyTextOnPage(lastMonth_last))
                    {
                        Logger.WriteDebugMessage("Pick Up Start Date " + lastMonth_first + " and End Date " + lastMonth_last + " matched with quick selected day - " + dayValue);
                    }
                    else
                    {
                        Assert.Fail("Pick Up Start Date " + lastMonth_first + " and End Date " + lastMonth_last + " did not matched with quick selected day - " + dayValue);
                    }
                    break;
                case "This month":
                    now = DateTime.Now;
                    month = new DateTime(now.Year, now.Month, 1);
                    lastMonth_first = month.AddMonths(0).ToString("M/d/yyyy");
                    lastMonth_last = month.AddMonths(1).AddDays(-1).ToString("M/d/yyyy");

                    if (VerifyTextOnPage(lastMonth_first) && VerifyTextOnPage(lastMonth_last))
                    {
                        Logger.WriteDebugMessage("Pick Up Start Date " + lastMonth_first + " and End Date " + lastMonth_last + " matched with quick selected day - " + dayValue);
                    }
                    else
                    {
                        Assert.Fail("Pick Up Start Date " + lastMonth_first + " and End Date " + lastMonth_last + " did not matched with quick selected day - " + dayValue);
                    }
                    break;
                case "Next month":
                    now = DateTime.Now;
                    month = new DateTime(now.Year, now.Month, 1);
                    lastMonth_first = month.AddMonths(1).ToString("M/d/yyyy");
                    lastMonth_last = month.AddMonths(2).AddDays(-1).ToString("M/d/yyyy");

                    if (VerifyTextOnPage(lastMonth_first) && VerifyTextOnPage(lastMonth_last))
                    {
                        Logger.WriteDebugMessage("Pick Up Start Date " + lastMonth_first + " and End Date " + lastMonth_last + " matched with quick selected day - " + dayValue);
                    }
                    else
                    {
                        Assert.Fail("Pick Up Start Date " + lastMonth_first + " and End Date " + lastMonth_last + " did not matched with quick selected day - " + dayValue);
                    }
                    break;
                case "Last year":
                    int year = DateTime.Now.Year;
                    DateTime firstDay = new DateTime(year, 1, 1);
                    firstDay = firstDay.AddYears(-1);
                    DateTime lastDay = firstDay.AddYears(1).AddTicks(-1);

                    string firstDayofYear = firstDay.ToString("M/d/yyyy");
                    string lastDayofYear = lastDay.ToString("M/d/yyyy");

                    if (VerifyTextOnPage(firstDayofYear) && VerifyTextOnPage(lastDayofYear))
                    {
                        Logger.WriteDebugMessage("Pick Up Start Date " + firstDayofYear + " and End Date " + lastDayofYear + " matched with quick selected day - " + dayValue);
                    }
                    else
                    {
                        Assert.Fail("Pick Up Start Date " + firstDayofYear + " and End Date " + lastDayofYear + " did not matched with quick selected day - " + dayValue);
                    }
                    break;
                case "This year":
                    year = DateTime.Now.Year;
                    firstDay = new DateTime(year, 1, 1);
                    firstDay = firstDay.AddYears(0);
                    lastDay = firstDay.AddYears(1).AddTicks(-1);

                    firstDayofYear = firstDay.ToString("M/d/yyyy");
                    lastDayofYear = lastDay.ToString("M/d/yyyy");

                    if (VerifyTextOnPage(firstDayofYear) && VerifyTextOnPage(lastDayofYear))
                    {
                        Logger.WriteDebugMessage("Pick Up Start Date " + firstDayofYear + " and End Date " + lastDayofYear + " matched with quick selected day - " + dayValue);
                    }
                    else
                    {
                        Assert.Fail("Pick Up Start Date " + firstDayofYear + " and End Date " + lastDayofYear + " did not matched with quick selected day - " + dayValue);
                    }
                    break;
                case "Date to end of year":
                    setDate = DateTime.Now.ToString("M/d/yyyy");
                    year = DateTime.Now.Year;
                    firstDay = new DateTime(year, 1, 1);
                    lastDay = firstDay.AddYears(1).AddTicks(-1);

                    lastDayofYear = lastDay.ToString("M/d/yyyy");

                    if (VerifyTextOnPage(setDate) && VerifyTextOnPage(lastDayofYear))
                    {
                        Logger.WriteDebugMessage("Pick Up Start Date and End Date matched with quick selected day - " + dayValue);
                    }
                    else
                    {
                        Assert.Fail("Pick Up Start Date " + setDate + " and End Date " + lastDayofYear + " did not matched with quick selected day - " + dayValue);
                    }
                    break;
            }
        }

        public static void CompareRelativeStartEndDate(string dayValue)
        {
            string relativeStartDate = Driver.FindElement(By.XPath("//div[@id='DeliveryConfigPanelBar_i4_PeriodOptionStartDate']//span[@class='rddlFakeInput']")).Text;
            string relativeEndDate = Driver.FindElement(By.XPath("(//div[@id='DeliveryConfigPanelBar_i4_PeriodOptionEndDate_DropDown']//ul[@class='rddlList']//following::li[contains(@class, 'rddlItemSelected')])[1]")).Text;

            switch(dayValue)
            {
                case "Yesterday":
                    break;
                case "Today":
                    break;
                case "MTD":
                    break;
                case "YTD":
                    break;
                case "Last month":
                    break;
                case "This month":
                    break;
                case "Next month":
                    break;
                case "Last year":
                    break;
                case "This year":
                    break;
                case "Date to end of year":
                    break;
            }
        }
    }
}
