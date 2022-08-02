using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHC.Entity
{
    public class Profile_DB
    {
        public string ExternalProfileId1 { set; get; }
        public string ExternalResID1 { set; get; }
        public string CMData { set; get; }
        public string CMOptOut { set; get; }
        public string IsPrimary { set; get; }
        public string ProfileId { set; get; }        
        public string SourceCreateUser { set; get; }       
        public string DateInserted { set; get; }
        public string DateUpdated { set; get; }
        public string Salutation { set; get; }
        public string FirstName { set; get; }
        public string MiddleName { set; get; }
        public string FamiliarName { set; get; }
        public string LastName { set; get; }
        public string Suffix { set; get; }
        public string PrimaryLanguage { set; get; }
        public string GenderCode { set; get; }
        public string Nationality { set; get; }
        public string JobTitle { set; get; }       
        public string Address1 { set; get; }
        public string Address2 { set; get; }
        public string City { set; get; }
        public string StateProvince { set; get; }
        public string PostalCode { set; get; }
        public string CountryCode { set; get; }
        public string MarketSegmentCode { set; get; }
        public string AddressLanguage { set; get; }
        public string CustomerMembershipID { set; get; }
        public string VIPID { set; get; }
        public string VIPCode { set; get; }
        public string Reservationid { set; get; }
        public string PropertyAccountId { set; get; }

        public Dictionary<string, int> AttributeNames_Values { set; get; }
    }    
}




















