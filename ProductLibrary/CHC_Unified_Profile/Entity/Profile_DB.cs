using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHC_Unified_Profile.Entity
{
    public class Profile_DB
    {
        public string ExternalProfileId1 { set; get; }
        public string CMData { set; get; }
        public string CMOptOut { set; get; }
        public string ProfileId { set; get; }
        public string SourceCreateUser { set; get; }
        public string DateInserted { set; get; }
        public string DateUpdated { set; get; }

        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Suffix { set; get; }
        
        public string PrimaryLanguage { set; get; }
        public string GenderCode { set; get; }
        public string Nationality { set; get; }
       
        public string Address1 { set; get; }
        public string Address2 { set; get; }
        public string City { set; get; }
        public string StateProvince { set; get; }
        public string PostalCode { set; get; }
        public string CountryCode { set; get; }
        public string IsPrimary { set; get; }
        public string AddressLanguage { set; get; }        
       
        public string Reservationid { set; get; }
        public string ExternalResID1 { set; get; }
        public string ConfirmationNum { set; get; }
        public string CancellationCode { set; get; }
        public string RateCode { set; get; }
        public string ChannelCode { set; get; }
        public string RoomTypeCode { set; get; }
        public string TotalRoomRevenue { set; get; }
        public string TotalFBRevenue { set; get; }
        public string TotalOtherRevenue { set; get; }
        public string MarketCodeCategory { set; get; }

        public Dictionary<string, int> AttributeNames_Values { set; get; }
    }
}
