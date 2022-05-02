using System;
using RevIntel.Utility;
using RevIntel.AppModule.UI;
using Common;
using Constants = RevIntel.Utility.Constants;
using InfoMessageLogger;
using BaseUtility.Utility;
using TestData;
using OpenQA.Selenium;
using NUnit.Framework;
using RevIntel.PageObject.UI;
using System.Text.RegularExpressions;
using Navigation = RevIntel.AppModule.UI.Navigation;
using GlobalParam = RevIntel.Utility.GlobalParameter;

namespace RevIntel.AppModule.MainAdminApp
{
    public partial class MainAdminApp
    {
        
        #region[TP_274136]
        public static void TC_269916()
        {
            Login.Login_SelectCLient();
            

            Navigation.Forecast_and_Budget();
            Navigation.Pace_Forecast_Report();

            ExchangeRate.NavigatetoPaceForecastReport();
            ExchangeRate.ChangeStartMonth_DateInput();
            //ExchangeRate.ChangeDateAsOfInput();
            ExchangeRate.Click_ViewAnalysis();
            AddDelay(60000);

            ExchangeRate.Identify_Forecast_TotalSoldRevenue();
            ExchangeRate.Identify_Budget_TotalSoldRevenue();
        }
        public static void TC_269917()
        {
            Login.Login_SelectCLient();


            Navigation.Forecast_and_Budget();
            Navigation.Pace_Forecast_Report();

            ExchangeRate.NavigatetoPaceForecastReport();
            ExchangeRate.ChangeStartMonth_DateInput();
            //ExchangeRate.ChangeDateAsOfInput();
            ExchangeRate.Click_ViewAnalysis();
            AddDelay(60000);

            ExchangeRate.Identify_Forecast_ToVarience();
        }
        public static void TC_269918()
        {
            Login.Login_SelectCLient();


            Navigation.Forecast_and_Budget();
            Navigation.Pace_Forecast_Report();

            ExchangeRate.NavigatetoPaceForecastReport();
            ExchangeRate.ChangeStartMonth_DateInput();
            //ExchangeRate.ChangeDateAsOfInput();
            ExchangeRate.Click_ViewAnalysis();
            AddDelay(60000);

            ExchangeRate.Identify_Budget_ToVarience();
        }
        public static void TC_269919()
        {
            Login.Login_SelectCLient();


            Navigation.Forecast_and_Budget();
            Navigation.Pace_Forecast_Report();

            ExchangeRate.NavigatetoPaceForecastReport();
            ExchangeRate.ChangeStartMonth_DateInput();
            ExchangeRate.ChangeDateAsOfInput();
            ExchangeRate.Click_ViewAnalysis();
            AddDelay(60000);

            ExchangeRate.Identify_ADR_SubTotal();
            ExchangeRate.Identify_ADR_TotalADROccupied();
        }
        public static void TC_269925()
        {
            string pickupStart = "5/6/2021";
            string pickupEnd = "5/7/2021";
            string startDate = "Jan 2021";
            string endDate = "Dec 2021";
            //Enter Email address and password
            Login.Login_SelectCLient();
            
            Helper.EnterFrameByxPath(PageObject_ReportParameter.iframe_Monthly_Pickup());

            ReportParameter.Monthly_PickupStart(pickupStart);
            ReportParameter.Monthly_PickupEnd(pickupEnd);
            Logger.WriteDebugMessage("Enter Pick start as = " + pickupStart);
            Logger.WriteDebugMessage("Enter Pick end as = " + pickupEnd);

            Helper.ElementClearText(PageObject_ReportParameter.Monthly_Start());
            Helper.ElementClearText(PageObject_ReportParameter.Monthly_End());
            ReportParameter.Pace_Dashboard_StartDate(startDate);
            ReportParameter.Pace_Dashboard_EndDate(endDate);
            Logger.WriteDebugMessage("Enter start date as = " + startDate);
            Logger.WriteDebugMessage("Enter enddate as = " + endDate);
            ReportParameter.Pace_Dashboard_Update_Button();
            AddDelay(20000);

            ExchangeRate.Identify_Budget_TotalRevenue_Portal();
            ExchangeRate.Identify_Forcast_TotalRevenue_Portal();

        }
        #endregion[TP_274136]

    }
}
