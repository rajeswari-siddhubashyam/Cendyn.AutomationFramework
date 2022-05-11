using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHC_Unified_Profile.Entity
{
    class Reservation_DB
    {
        public int ExternalResID1 { set; get; }        
        public string ConfirmationNum { set; get; }
        public string Reservationid { set; get; }
        public string ResArriveDate { set; get; }
        public string ResDepartDate { set; get; }
        public string NumRooms { set; get; }
        public string NumAdults { set; get; }
        public string NumChildren { set; get; }
        public string TotalRoomNights { set; get; }
        public string TotalTax { set; get; }
        public string TotalRevenue { set; get; }
        public string TotalRoomRevenue { set; get; }
        public string TotalFees { set; get; }
        public string TotalOtherRevenue { set; get; }
        public string StayDate { set; get; }
        public string SourceRoomType { set; get; }
        public string SourceRateType { set; get; }
        public string CurrencyCode { set; get; }
        public string DailyRate { set; get; }
        public string MarketCode { set; get; }
        public string ResSourceCode { set; get; }
        public string ChannelCode { set; get; }
        public string DateInserted { set; get; }
        public string DateUpdated { set; get; }
        public string DiscountAmount { set; get; }
        public string DiscountCode { set; get; }
        public string DiscountPercent { set; get; }
        public string DiscountReasonCode { set; get; }
        public string ApplyTax { set; get; }
        public string GuaranteedByCode { set; get; }
        public string MethodOfPayment { set; get; }
        public string RateConfidential { set; get; }
        public string IsNotRefundable { set; get; }
        public string CompanyCode { set; get; }
        public string CompanyName { set; get; }
        public string TravelAgentCode { set; get; }
        public string TravelAgentName { set; get; }

    }
}

