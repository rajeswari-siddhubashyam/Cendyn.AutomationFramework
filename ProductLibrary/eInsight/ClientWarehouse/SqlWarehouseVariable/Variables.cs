using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlWarehouse
{
    public class ClientdbConnection
    {
        public string ServerName { get; set; }
        public string DatabasName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConnectonString { get; set; }
        public string ParentCompanyName { get; set; }
        public string CompanyName { get; set; }
    }

    public class CampaignDetails : ProfileCustData
    {
        public string OldStatus { get; set; }
        public string ParentCompanyID { get; set; }
        public string ChildCampaignID { get; set; }
        public string CompanyName { get; set; }
        public string ChildCompanyName { get; set; }
        public string CompanyID { get; set; }
        public string ParentCompanyName { get; set; }
        public string CampaignName { get; set; }
        public string DateSubmitted { get; set; }
        public string ModifiedOn { get; set; }
        public string LastUpdated { get; set; }
        public string ParentProjectID { get; set; }
        public string Subject { get; set; }
        public string eventtype { get; set; }
        public string by { get; set; }
        public string campaignStatus { get; set; }
        public string extractStatus { get; set; }
        public string ParentProjectIDs { get; set; }
        public string ResendSaveCheck { get; set; }
        public string RequestDate { get; set; }
        public string EventType { get; set; }
    }
    //public class IsFubctionalEnables
    //{
    //    public string 
    //}
    public class ProfileCustData : UserStayData
    {
        public string GroupID { get; set; }
        public string PrimaryCustomer { get; set; }
        public string CustomerIDs { get; set; }
        public string Salutation { get; set; }
        public string Title { get; set; }
        public string ShortTitle { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string GenderCode { get; set; }
        public string Languages { get; set; }
        public string CompanyName { get; set; }
        public string PropertyCode { get; set; }
        public string PropertyName { get; set; }
        public string InsertDate { get; set; }
        public string UpdateDate { get; set; }
        public string SourceName { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneExt { get; set; }
        public string MobilePhone { get; set; }
        public string WorkPhone { get; set; }
        public string HomePhone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string AddressStatus { get; set; }
        public string EmailStatus { get; set; }
        public string City { get; set; }
        public string StateProvinceCode { get; set; }
        public string ZipCode { get; set; }
        public string CountryCode { get; set; }
        public string Company { get; set; }
        public string Lang_LanguageID { get; set; }
        public string Token { get; set; }
        public string SourceGuestID { get; set; }
        public string monetary { get; set; }
        public string recency { get; set; }
        public string frequency { get; set; }
        public string total_stay_nights { get; set; }
        public string birthday { get; set; }
        public string nextLevel { get; set; }
        public string membershipLevel { get; set; }
        public string brandCode { get; set; }
        public string zipCode { get; set; }
        public string guestFirstName { get; set; }
        public string confirmationNumber { get; set; }

        public string memberLevel { get; set; }
    }

    public class Users : ProfileCustData
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string ParentProjectID { get; set; }
        public string ChildProjectID { get; set; }
        public string CampaignName { get; set; }
        public string Subject { get; set; }
        public string SendDate { get; set; }
        public string OpenYN { get; set; }
        public string ClickYN { get; set; }
        public string ClickLinksCount { get; set; }
        public string BouncedYN { get; set; }
        public string BounceReason { get; set; }
        public string fromEmail { get; set; }
        public string fromName { get; set; }
    }

    public class UserStayData
    {
        public string CustomerID { get; set; }
        public string ArrivalDate { get; set; }
        public string SourceStayID { get; set; }
        public string CampaignSubject { get; set; }
        public string ReservationNumber { get; set; }
        public string ReservationStatus { get; set; }
        public string AcknowledgementNum { get; set; }
        public string Channel { get; set; }
        public string InvBlockCode { get; set; }
        public string TaxType { get; set; }
        public string ClientType { get; set; }
        public string MarketSeg { get; set; }
        public string MarketSubSeg { get; set; }
        public string CurrencyCode { get; set; }
        public string PackageCode { get; set; }
        public string IATA { get; set; }
        public string DepartureDate { get; set; }
        public string RateCategory { get; set; }
        public string MemberShipID { get; set; }
        public string SourceOfBusiness { get; set; }
        public string RTC { get; set; }
        public string MP { get; set; }
        public string Quantity { get; set; }
        public string RatePackage { get; set; }
        public string RemainingBalance { get; set; }
        public string GroupName { get; set; }
        public string PK_Reservations { get; set; }
        public string SubReservationNumber { get; set; }
        public string ResAgent { get; set; }
        public string BookingEngConfNum { get; set; }
        public string RateType { get; set; }
        public string TotalPackageRate { get; set; }
        public string RoomCode { get; set; }
        public string DepositPolicy { get; set; }
        public string MemberShipLevel { get; set; }
        public string CentralReservation { get; set; }
        public string TotalPackageRateWithTax { get; set; }
        public string AverageDailyRevenueWithTax { get; set; }
        public string CancellationNum { get; set; }
        public string CheckOutTime { get; set; }
        public string RoomTypeCode { get; set; }
        public string CXLPolicy { get; set; }
        public string StayNights { get; set; }
        public string NumRooms { get; set; }
        public string CheckInTime { get; set; }
        public string TotalPersons { get; set; }
        public string GroupResortFees { get; set; }
        public string RoomNights { get; set; }
        public string CancelByDate { get; set; }
        public string ResCreationDate { get; set; }
        public string TotalResortFees { get; set; }
        public string NumChildren { get; set; }
        public string NumAdults { get; set; }
        public string AverageDailyRevenue { get; set; }
        public string OtherRevenue { get; set; }
        public string Deposit { get; set; }
        public string RoomRevenue { get; set; }
        public string Tax { get; set; }
        public string AverageDailyRate { get; set; }
        public string TotalRevenue { get; set; }
        public string TotalRevenueWithTax { get; set; }
        public string CancelDate { get; set; }
        public string Total { get; set; }
        public string IATADes { get; set; }
        public string CurrencySymbol { get; set; }
        public string CurrencyType { get; set; }
        public string RoomRevenueStayWithTax_10pct { get; set; }
        public string RoomRevenueStayWithTax_90Pct { get; set; }
        public string NonMember_RoomRevenueStayWithTax_12Months { get; set; }
        public string NonMember_RoomRevenueStayWithTax_12Months_10pct { get; set; }
        public string NonMember_RoomRevenueStayWithTax_12Months_90pct { get; set; }
        public string legNumbers { get; set; }
        public string stayPoints { get; set; }
        public string stayAverageTax { get; set; }
        public string StayRateAmount_Prop { get; set; }
        public string StayRateAmount_Corp { get; set; }
        public string PropertyName { get; set; }
        public string StayRateAmountConvertedUSD { get; set; }
        public string Monetory { get; set; }

    }

    public class ResendCampaignData
    {
        public string CustomerID { get; set; }
        public string PrimaryCustomer { get; set; }
        public string ReservationNumber { get; set; }
        public string EmailAddress { get; set; }
        public string CampaignName { get; set; }
        public string CampaignSubject { get; set; }
        public string ParentProjectID { get; set; }
        public string PropertyName { get; set; }
    }

    public class AnnonymizedData
    {
        public string ID { get; set; }
        public string Prefix { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string CellPhone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string StateProvinceCode { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string IsUsed { get; set; }
    }
    public class CampaignReportDetails : ProfileCustData
    {
        public string CompanyID { get; set; }
        public string CampaignName { get; set; }
        public string Subject { get; set; }
        public string SendDate { get; set; }
        public string SendCount { get; set; }
        public string DeliverCount { get; set; }
        public string OpenCount { get; set; }
        public string UniqueOpenCount { get; set; }
        public string ClickCount { get; set; }
        public string NetClickCount { get; set; }
        public string ParentProjectID { get; set; }
        public string ChildProjectID { get; set; }
        public string DateRange { get; set; }
        public string ParentCompanyName { get; set; }
        public string ReservationNumber { get; set; }
        public string Email { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
    public class UserPreference
    {
        public string user_id { get; set; }
        public string region { get; set; }
        public string language { get; set; }
        public string inserttime { get; set; }
        public string updatetime { get; set; }
        public string CurrencyCode{ get; set; }
        public string ParentCompanyID { get; set; }
    }
    public class AudienceBuilderData : CampaignDetails
    {
        public string AudienceName { get; set; }
        public string AudienceID { get; set; }
        public string AudienceIDs { get; set; }
        public string AudienceDetailID { get; set; }
        public string AudiencePublishDetailID { get; set; }
        public string AudienceDescription { get; set; }
        public string InsertedByUser { get; set; }
        public string UpdatedOn { get; set; }
        public string InsertedOn { get; set; }
        public string IsActive { get; set; }
        public string AudiencePropertyName { get; set; }
        public string UpdatedBy { get; set; }
        public string ActivityType { get; set; }
        public string Tags { get; set; }
        public string AudienceUpdatedByUserID { get; set; }
        public string AudienceUpdatedOn { get; set; }
        public string AudienceJSON { get; set; }
        public string CountBounced { get; set; }
        public string CountFlagged { get; set; }
        public string CountNonConsent { get; set; }
        public string CountNull { get; set; }
        public string CountTotal { get; set; }
        public string CountUnique { get; set; }
        public string CountUnsubscribed { get; set; }
        public string CountValid { get; set; }
        public string CountInvalid { get; set; }
        //public string ProjectName { get; set; }
    }

    public class TemplateEditor
    {
        public string templateName { get; set; }
        public string UpdateDate { get; set; }
    }
}
