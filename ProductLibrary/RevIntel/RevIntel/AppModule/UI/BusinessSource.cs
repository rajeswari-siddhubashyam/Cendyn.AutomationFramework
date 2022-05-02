using BaseUtility.Utility;
using RevIntel.PageObject.UI;
using System.Net.Http.Headers;

namespace RevIntel.AppModule.UI
{
    class Business_Source
    {
        public static void iframe_AgentSummary()
        {
            Helper.ElementClick(PageObject_BusinessSource.iframe_AgentSummary());
        }
      
        public static void Click_AgentRoomTypeAnalysis()
        {
            Helper.ElementClick(PageObject_BusinessSource.Click_AgentRoomTypeAnalysis());
        }
        public static void iframe_Agent_Room_Type_Analysis()
        {
            Helper.ElementClick(PageObject_BusinessSource.iframe_Agent_Room_Type_Analysis());
        }
        public static void BookingStartDate(string str)
        {
            Helper.ElementEnterText(PageObject_BusinessSource.BookingStartDate(), str);
        }
        public static void BookingEndDate(string str)
        {
            Helper.ElementEnterText(PageObject_BusinessSource.BookingEndDate(), str);
        }
        public static void Click_Annual_Agent_Analysis_by_Month()
        {
            Helper.ElementClick(PageObject_BusinessSource.Click_Annual_Agent_Analysis_by_Month());
        }
        public static void iframe_Annual_Agent_Analysis_by_Month()
        {
            Helper.ElementClick(PageObject_BusinessSource.iframe_Annual_Agent_Analysis_by_Month());
        }
        public static void Year_DDL()
        {
            Helper.ElementClick(PageObject_BusinessSource.Year_DDL());
        }
        public static void Year_value()
        {
            Helper.ElementClick(PageObject_BusinessSource.Year_value());
        }
        public static void Click_Company_Analysis()
        {
            Helper.ElementClick(PageObject_BusinessSource.Click_Company_Analysis());
        }
        public static void iframe_Company_Analysis()
        {
            Helper.ElementClick(PageObject_BusinessSource.iframe_Company_Analysis());
        }
        public static void kerner_Portfolio()
        {
            Helper.ElementClick(PageObject_BusinessSource.kerner_Portfolio());
        }
        public static void Click_Annual_Company_Analysis_by_Month()
        {
            Helper.ElementClick(PageObject_BusinessSource.Click_Annual_Company_Analysis_by_Month());
        }
        public static void iframe_Annual_Company_Analysis_by_Month()
        {
            Helper.ElementClick(PageObject_BusinessSource.iframe_Annual_Company_Analysis_by_Month());
        }
        public static void Annual_Company_Analysis_by_Month_CompanyDDL()
        {
            Helper.ElementClick(PageObject_BusinessSource.Annual_Company_Analysis_by_Month_CompanyDDL());
        }
        public static void Annual_Company_Analysis_by_Month_Company_Select()
        {
            Helper.ElementClick(PageObject_BusinessSource.Annual_Company_Analysis_by_Month_Company_Select());
        }
        public static void Click_Company_Summary()
        {
            Helper.ElementClick(PageObject_BusinessSource.Click_Company_Summary());
        }
        public static void iframe_Company_Summary()
        {
            Helper.ElementClick(PageObject_BusinessSource.iframe_Company_Summary());
        }
        public static void Company_Summary_Portfolio()
        {
            Helper.ElementClick(PageObject_BusinessSource.Company_Summary_Portfolio());
        }

    }
}
