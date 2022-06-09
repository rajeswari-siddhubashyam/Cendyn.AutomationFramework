
namespace TestData
{
    public class AMR_Agent
    {
        #region Add Test Data
        public static void AddAMRAgentData(string clientName)
        {
            AddTestData_ClientConfig(clientName);
            AddTestData_Admin(clientName);
            AddTestData_FrontEnd(clientName);
            AddTestData_PostDeployment(clientName);
        }

        private static void AddTestData_ClientConfig(string clientName)
        {
            TestDataHelper.AddTestData_ClientConfig("AMR_Agent", "https://traveladminloyaltyprogram.qaeloyaltyadmin.com/", "rjoshi@delaplex.in", "https://travelagentloyaltyprogram.qaeloyaltyadmin.com/", "", "", "");
            TestDataHelper.AddTestData_ClientConfig("AMR_Agent_Production", "https://traveladminloyaltyprogram.cendyn.com/", "CendynAutomation@cendyn.com", "https://amrewards.amragents.com/", "", "", "");

        }

        private static void AddTestData_Admin(string clientName)
        {
            AddTestData_Admin_TC_37501();
            AddTestData_Admin_TC_37502();
            AddTestData_Admin_TC_37504();
            AddTestData_Admin_TC_37509();
            AddTestData_Admin_TC_37514();
            AddTestData_Admin_TC_37515();
            AddTestData_Admin_TC_37516();
            AddTestData_Admin_TC_37519();
            AddTestData_Admin_TC_42271();

        }

        private static void AddTestData_FrontEnd(string clientName)
        {
            AddTestData_FrontEnd_TC_27838();
            AddTestData_FrontEnd_TC_37513();
            AddTestData_FrontEnd_TC_37518();
            AddTestData_FrontEnd_TC_37522();
            AddTestData_FrontEnd_TC_37539();
            AddTestData_FrontEnd_TC_37548();
            AddTestData_FrontEnd_TC_37550();
            AddTestData_FrontEnd_TC_37553();
            AddTestData_FrontEnd_TC_37604();
            AddTestData_FrontEnd_TC_37609();
            AddTestData_FrontEnd_TC_37649();

        }
        private static void AddTestData_PostDeployment(string clientName)
        {
            AddTestData_Admin_TC_281327();
        }

        #endregion

        #region TP_38860
        public static void AddTestData_Admin_TC_37501()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_38860", "TC_37501", "1", "TRUE", "SearchUser", "potter001@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_38860", "TC_37501", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_38860", "TC_37501", "1", "TRUE", "Firstname", "Harry");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_38860", "TC_37501", "1", "TRUE", "Lastname", "Potter");
        }
        public static void AddTestData_Admin_TC_37502()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_38860", "TC_37502", "1", "TRUE", "SearchUser", "harry203@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_38860", "TC_37502", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_38860", "TC_37502", "1", "TRUE", "NewPassword", "Amr$1234");
        }
        public static void AddTestData_Admin_TC_37504()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_38860", "TC_37504", "1", "TRUE", "SearchUser", "rucha110@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_38860", "TC_37504", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_38860", "TC_37504", "1", "TRUE", "NewPassword", "Cendyn1234$");
        }
        public static void AddTestData_Admin_TC_37509()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_38860", "TC_37509", "1", "TRUE", "SearchUser", "@cendyn17.com");
        }
        public static void AddTestData_Admin_TC_37514()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_38860", "TC_37514", "1", "TRUE", "SearchUser", "potter001@cendyn17.com");
        }
        public static void AddTestData_Admin_TC_37515()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_38860", "TC_37515", "1", "TRUE", "SearchUser", "potter001@cendyn17.com");
        }
        public static void AddTestData_Admin_TC_37516()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_38860", "TC_37516", "1", "TRUE", "SearchUser", "@cendyn17.com");
        }
        public static void AddTestData_Admin_TC_37519()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_38860", "TC_37519", "1", "TRUE", "SearchUser", "ruchitest107@cendyn17.com");
        }
        public static void AddTestData_Admin_TC_42271()
        {
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_38860", "TC_42271", "1", "TRUE", "SearchUser", "Romantic");
            TestDataHelper.AddRecord("ALL", "Admin", "TestCase", "TP_38860", "TC_42271", "1", "TRUE", "Email", "Testrucha101@cendyn17.com");
        }
        #endregion TP_38860



        #region TP_38859
        public static void AddTestData_FrontEnd_TC_27838()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_27838", "1", "TRUE", "IATA", "10672071");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_27838", "1", "TRUE", "CLIA", "307403");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_27838", "1", "TRUE", "ARC", "5512216");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_27838", "1", "TRUE", "TRU", "52440544");
        }
        public static void AddTestData_FrontEnd_TC_37513()
        {
            // TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37513", "1", "TRUE", "Country", "Canada");
            //TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37513", "1", "TRUE", "Providence", "Ontario");
            // TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37513", "1", "TRUE", "Address", "25 Sheppard Ave W");
            // TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37513", "1", "TRUE", "City", "North York");
            //TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37513", "1", "TRUE", "Zip", "M2N 6S6");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37513", "1", "TRUE", "Country", "Canada");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37513", "1", "TRUE", "Providence", "Ontario");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37513", "1", "TRUE", "Address", "City Hall 100 Queen St W");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37513", "1", "TRUE", "City", "Toranto");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37513", "1", "TRUE", "Zip", "M5H 2N1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37513", "1", "TRUE", "IATA", "10672071");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37513", "1", "TRUE", "CLIA", "307403");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37513", "1", "TRUE", "ARC", "5512216");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37513", "1", "TRUE", "TRU", "52440544");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37513", "1", "TRUE", "TIDS", "52440544");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37513", "1", "TRUE", "TICO", "52440544");
        }
        public static void AddTestData_FrontEnd_TC_37518()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37518", "1", "TRUE", "Email", "cendynmarcqa@gmail.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37518", "1", "TRUE", "ConfirmEmail", "cendynmarcqa@gmail.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37518", "1", "TRUE", "NewPassword", "Cendyn1234%");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37518", "1", "TRUE", "ConfirmNewPassword", "Cendyn1234%");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37518", "1", "TRUE", "RecoveryQuestion", "What was your childhood nickname?");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37518", "1", "TRUE", "RecoveryAnswer", "Rocko");
        }
        public static void AddTestData_FrontEnd_TC_37522()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37522", "1", "TRUE", "EmailAddress", "ruchitest_100@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37522", "1", "TRUE", "NewPassword", "Cendyn123$");
        }
        public static void AddTestData_FrontEnd_TC_37539()
        {
            
        }
        public static void AddTestData_FrontEnd_TC_37548()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37548", "1", "TRUE", "BookingType", "Individual");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37548", "1", "TRUE", "RoomNum", "1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37548", "1", "TRUE", "BookingMadeWith", "Other");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37548", "1", "TRUE", "BookingNumber", "2813308004");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37548", "1", "TRUE", "GuestFirstName", "Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37548", "1", "TRUE", "GuestLastName", "UnderReview");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37548", "1", "TRUE", "DateBookedMonth", "June");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37548", "1", "TRUE", "DateBookedDay", "5");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37548", "1", "TRUE", "DateBookedYear", "2017");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37548", "1", "TRUE", "TravelStartMonth", "Oct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37548", "1", "TRUE", "TravelStartDay", "10");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37548", "1", "TRUE", "TravelStartYear", "2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37548", "1", "TRUE", "TravelEndMonth", "Nov");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37548", "1", "TRUE", "TravelEndDay", "1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37548", "1", "TRUE", "TravelEndYear", "2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37548", "1", "TRUE", "Brand", "Dream Resorts");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37548", "1", "TRUE", "Resort", "Dreams Playa Bonita Panama");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37548", "1", "TRUE", "DepartureGateway", "Akron");
        }
        public static void AddTestData_FrontEnd_TC_37550()
        {
           
        }
        public static void AddTestData_FrontEnd_TC_37553()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37553", "1", "TRUE", "BookingType", "Individual");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37553", "1", "TRUE", "RoomNum", "1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37553", "1", "TRUE", "BookingMadeWith", "Other");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37553", "1", "TRUE", "BookingNumber", "2813308004");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37553", "1", "TRUE", "GuestFirstName", "Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37553", "1", "TRUE", "GuestLastName", "UnderReview");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37553", "1", "TRUE", "DateBookedMonth", "June");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37553", "1", "TRUE", "DateBookedDay", "5");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37553", "1", "TRUE", "DateBookedYear", "2017");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37553", "1", "TRUE", "TravelStartMonth", "Oct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37553", "1", "TRUE", "TravelStartDay", "10");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37553", "1", "TRUE", "TravelStartYear", "2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37553", "1", "TRUE", "TravelEndMonth", "Nov");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37553", "1", "TRUE", "TravelEndDay", "1");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37553", "1", "TRUE", "TravelEndYear", "2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37553", "1", "TRUE", "Brand", "Dream Resorts");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37553", "1", "TRUE", "Resort", "Dreams Dominicus La Romana");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37553", "1", "TRUE", "DepartureGateway", "Akron");
        }
        public static void AddTestData_FrontEnd_TC_37604()
        {
            
        }
        public static void AddTestData_FrontEnd_TC_37609()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37609", "1", "TRUE", "Country", "United States");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37609", "1", "TRUE", "Providence", "Florida");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37609", "1", "TRUE", "Address", "980 N Federal Hwy ste 300");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37609", "1", "TRUE", "City", "Boca Raton");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37609", "1", "TRUE", "Zip", "33432");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37609", "1", "TRUE", "IATA", "10672071");
        }
        public static void AddTestData_FrontEnd_TC_37649()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37649", "1", "TRUE", "Country", "United States");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37649", "1", "TRUE", "Providence", "Florida");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37649", "1", "TRUE", "Address", "980 N Federal Hwy ste 300");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37649", "1", "TRUE", "City", "Boca Raton");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37649", "1", "TRUE", "Zip", "33432");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_38859", "TC_37649", "1", "TRUE", "IATA", "10672071");
        }
        #endregion TP_38859


        #region TP_273216
        public static void AddTestData_Admin_TC_281327()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_273216", "TC_281327", "1", "TRUE", "Country", "United States");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_273216", "TC_281327", "1", "TRUE", "Providence", "Florida");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_273216", "TC_281327", "1", "TRUE", "Address", "980 N Federal Hwy ste 300");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_273216", "TC_281327", "1", "TRUE", "City", "Boca Raton");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_273216", "TC_281327", "1", "TRUE", "Zip", "33432");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_273216", "TC_281327", "1", "TRUE", "IATA", "10672071");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_273216", "TC_281327", "1", "TRUE", "RecoveryQuestion", "What was your childhood nickname?");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_273216", "TC_281327", "1", "TRUE", "RecoveryAnswer", "Rocko");
        }
        #endregion TP_273216
















        //    #region[Common]
        //    public static string Common_BrowserType { get; set; }
        //    public static string Common_AdminURL { get; set; }
        //    public static string Common_PostDeploymentAdminURL { get; set; }
        //    public static string Common_FrontendURL { get; set; }
        //    public static string Common_PostDeploymentFrontendURL { get; set; }
        //    public static string Common_AdminEmail { get; set; }
        //    public static string Common_PostDeploymentAdminEmail { get; set; }
        //    public static string Common_AdminPassword { get; set; }
        //    public static string Common_FrontEndEmail { get; set; }
        //    public static string Common_FrontEndPass { get; set; }
        //    public static string Common_Registration_Email { get; set; }
        //    public static string Common_Registration_ConfirmEmail { get; set; }
        //    public static string Common_Registration_Password { get; set; }
        //    public static string Common_Registration_ConfirmPassword { get; set; }
        //    public static string Common_Registration_SecurityQuestion { get; set; }
        //    public static string Common_Registration_SecurityAnswer { get; set; }
        //    public static string Common_Registration_Country { get; set; }
        //    public static string Common_Registration_Language { get; set; }
        //    public static string Common_Registration_Title { get; set; }
        //    public static string Common_Registration_FirstName { get; set; }
        //    public static string Common_Registration_LastName { get; set; }
        //    public static string Common_Registration_BirthdayMonth { get; set; }
        //    public static string Common_Registration_BirthdayDay { get; set; }
        //    public static string Common_Registration_Address1 { get; set; }
        //    public static string Common_Registration_Address2 { get; set; }
        //    public static string Common_Registration_City { get; set; }
        //    public static string Common_Registration_State { get; set; }
        //    public static string Common_Registration_Zip { get; set; }
        //    public static string Common_Registration_WorkPhonePrefix { get; set; }
        //    public static string Common_Registration_WorkPhoneAreaCode { get; set; }
        //    public static string Common_Registration_WorkPhoneFirstThree { get; set; }
        //    public static string Common_Registration_WorkPhoneLastFour { get; set; }
        //    public static string Common_Registration_WorkPhoneExtension { get; set; }
        //    public static string Common_Registration_HomePhonePrefix { get; set; }
        //    public static string Common_Registration_HomePhoneAreaCode { get; set; }
        //    public static string Common_Registration_HomePhoneFirstThree { get; set; }
        //    public static string Common_Registration_HomePhoneLastFour { get; set; }
        //    public static string Common_Registration_MobilePhonePrefix { get; set; }
        //    public static string Common_Registration_MobilePhoneAreaCode { get; set; }
        //    public static string Common_Registration_MobilePhoneFirstThree { get; set; }
        //    public static string Common_Registration_MobilePhoneLastFour { get; set; }
        //    public static string Common_Registration_FaxPhonePrefix { get; set; }
        //    public static string Common_Registration_FaxPhoneAreaCode { get; set; }
        //    public static string Common_Registration_FaxPhoneFirstThree { get; set; }
        //    public static string Common_Registration_FaxPhoneLastFour { get; set; }
        //    public static string Common_Registration_IATA { get; set; }
        //    public static string Common_Registration_ARC { get; set; }
        //    public static string Common_Registration_CLIA { get; set; }
        //    public static string Common_Registration_TRU { get; set; }
        //    public static string Common_Registration_ACTA { get; set; }
        //    public static string Common_Registration_TIDS { get; set; }
        //    public static string Common_Registration_TICO { get; set; }
        //    public static string Common_Registration_ABTA { get; set; }
        //    public static string Common_Registration_ATOL { get; set; }
        //    public static string Common_Registration_RetailAgency { get; set; }
        //    public static string Common_Registration_RemoteHomeBased { get; set; }
        //    public static string Common_Registration_TourOperatorWholesaler { get; set; }
        //    public static string Common_Registration_MeetingPlanner { get; set; }
        //    public static string Common_Registration_DestinationWeddingSpecialist { get; set; }
        //    public static string Common_Registration_Affiliation { get; set; }
        //    #endregion[Common]

        //    #region[TP_38859]

        //    #region[TC_27838]

        //    public static string TC_27838_IATA { get; set; }
        //    public static string TC_27838_CLIA { get; set; }
        //    public static string TC_27838_ARC { get; set; }
        //    public static string TC_27838_TRU { get; set; }

        //    #endregion[TC_27838]

        //    #region[TC_37518]
        //    public static string TC_37518_Email { get; set; }
        //    public static string TC_37518_ConfirmEmail { get; set; }
        //    public static string TC_37518_NewPassword { get; set; }
        //    public static string TC_37518_ConfirmNewPassword { get; set; }
        //    public static string TC_37518_RecoveryQuestion { get; set; }
        //    public static string TC_37518_RecoveryAnswer { get; set; }
        //    #endregion[TC_37518]

        //    #region[TC_37548]
        //    public static string TC_37548_BookingType { get; set; }
        //    public static string TC_37548_RoomNum { get; set; }
        //    public static string TC_37548_BookingMadeWith { get; set; }
        //    public static string TC_37548_BookingNumber { get; set; }
        //    public static string TC_37548_GuestFirstName { get; set; }
        //    public static string TC_37548_GuestLastName { get; set; }
        //    public static string TC_37548_DateBookedMonth { get; set; }
        //    public static string TC_37548_DateBookedDay { get; set; }
        //    public static string TC_37548_DateBookedYear { get; set; }
        //    public static string TC_37548_TravelStartMonth { get; set; }
        //    public static string TC_37548_TravelStartDay { get; set; }
        //    public static string TC_37548_TravelStartYear { get; set; }
        //    public static string TC_37548_TravelEndMonth { get; set; }
        //    public static string TC_37548_TravelEndDay { get; set; }
        //    public static string TC_37548_TravelEndYear { get; set; }
        //    public static string TC_37548_Brand { get; set; }
        //    public static string TC_37548_Resort { get; set; }
        //    public static string TC_37548_DepartureGateway { get; set; }
        //    #endregion[TC_37548]

        //    #region[TC_37553]
        //    public static string TC_37553_BookingType { get; set; }
        //    public static string TC_37553_RoomNum { get; set; }
        //    public static string TC_37553_BookingMadeWith { get; set; }
        //    public static string TC_37553_BookingNumber { get; set; }
        //    public static string TC_37553_GuestFirstName { get; set; }
        //    public static string TC_37553_GuestLastName { get; set; }
        //    public static string TC_37553_DateBookedMonth { get; set; }
        //    public static string TC_37553_DateBookedDay { get; set; }
        //    public static string TC_37553_DateBookedYear { get; set; }
        //    public static string TC_37553_TravelStartMonth { get; set; }
        //    public static string TC_37553_TravelStartDay { get; set; }
        //    public static string TC_37553_TravelStartYear { get; set; }
        //    public static string TC_37553_TravelEndMonth { get; set; }
        //    public static string TC_37553_TravelEndDay { get; set; }
        //    public static string TC_37553_TravelEndYear { get; set; }
        //    public static string TC_37553_Brand { get; set; }
        //    public static string TC_37553_Resort { get; set; }
        //    public static string TC_37553_DepartureGateway { get; set; }
        //    #endregion[TC_37553]

        //    #region[TC_37513]
        //    public static string TC_37513_Country { get; set; }
        //    public static string TC_37513_Providence { get; set; }
        //    public static string TC_37513_Address { get; set; }
        //    public static string TC_37513_City { get; set; }
        //    public static string TC_37513_Zip { get; set; }
        //    public static string TC_37513_IATA { get; set; }
        //    public static string TC_37513_CLIA { get; set; }
        //    public static string TC_37513_ARC { get; set; }
        //    public static string TC_37513_TRU { get; set; }
        //    public static string TC_37513_TIDS { get; set; }
        //    public static string TC_37513_TICO { get; set; }
        //    #endregion[TC_37513]

        //    #region[TC_37522]
        //    public static string TC_37522_EmailAddress { get; set; }
        //    public static string TC_37522_NewPassword { get; set; }

        //    #endregion[TC_37522]   

        //    #region[TC_37609]
        //    public static string TC_37609_Country { get; set; }
        //    public static string TC_37609_Providence { get; set; }
        //    public static string TC_37609_Address { get; set; }
        //    public static string TC_37609_City { get; set; }
        //    public static string TC_37609_Zip { get; set; }
        //    public static string TC_37609_IATA { get; set; }
        //    #endregion[TC_37609]

        //    #region[TC_37649]
        //    public static string TC_37649_Country { get; set; }
        //    public static string TC_37649_Providence { get; set; }
        //    public static string TC_37649_Address { get; set; }
        //    public static string TC_37649_City { get; set; }
        //    public static string TC_37649_Zip { get; set; }
        //    public static string TC_37649_IATA { get; set; }
        //    public static string TC_37649_RecoveryQuestion { get; set; }
        //    public static string TC_37649_RecoveryAnswer { get; set; }
        //    #endregion[TC_37649]


        //    #endregion[TP_38859]

        //    #region[TP_38860]

        //    #region[TC_37501]
        //    public static string TC_37501_SearchUser { get; set; }
        //    public static string TC_37501_Password { get; set; }
        //    public static string TC_37501_Firstname { get; set; }
        //    public static string TC_37501_Lastname { get; set; }

        //    #endregion[TC_37501]   

        //    #region[TC_37502]
        //    public static string TC_37502_SearchUser { get; set; }
        //    public static string TC_37502_Password { get; set; }
        //    public static string TC_37502_NewPassword { get; set; }

        //    #endregion[TC_37502]   

        //    #region[TC_37504]
        //    public static string TC_37504_SearchUser { get; set; }
        //    public static string TC_37504_Password { get; set; }
        //    public static string TC_37504_NewPassword { get; set; }

        //    #endregion[TC_37504]   

        //    #region[TC_37509]
        //    public static string TC_37509_SearchUser { get; set; }

        //    #endregion[TC_37509]   

        //    #region[TC_37514]
        //    public static string TC_37514_SearchUser { get; set; }

        //    #endregion[TC_37514]   

        //    #region[TC_37515]
        //    public static string TC_37515_SearchUser { get; set; }

        //    #endregion[TC_37515]   

        //    #region[TC_37516]
        //    public static string TC_37516_SearchUser { get; set; }

        //    #endregion[TC_37516]   

        //    #region[TC_42270]
        //    public static string TC_42270_SearchUser { get; set; }

        //    #endregion[TC_42270]   

        //    #region[TC_42271]
        //    public static string TC_42271_SearchUser { get; set; }
        //    public static string TC_42271_Email { get; set; }

        //    #endregion[TC_42271]   
        //    #endregion[TP_38860]

        //    /// <summary>
        //    /// This method will assign all string values from the test xml file.
        //    /// </summary>
        //    /// <param name=testCase>Test Case ID</param>
        //    public static AMR_Agent ReadData(string testCase)
        //    {
        //        AMR_Agent obj = new AMR_Agent();
        //        XDocument doc = XDocument.Load(TestDataFile);
        //        var query = doc.Descendants(testCase).Elements()
        //            .ToDictionary(x => x.Attribute("key").Value,
        //                x => x.Value);

        //        foreach (KeyValuePair<string, string> pair in query)
        //        {
        //            #region[Common]

        //            if (testCase == Constants.ModuleCommon)
        //            {
        //                if (pair.Key == "Common_BrowserType")
        //                {
        //                    Common_BrowserType = pair.Value;
        //                }
        //                else if (pair.Key == "Common_AdminURL")
        //                {
        //                    Common_AdminURL = pair.Value;
        //                }
        //                else if (pair.Key == "Common_PostDeploymentAdminURL")
        //                {
        //                    Common_PostDeploymentAdminURL = pair.Value;
        //                }
        //                else if (pair.Key == "Common_FrontendURL")
        //                {
        //                    Common_FrontendURL = pair.Value;
        //                }
        //                else if (pair.Key == "Common_PostDeploymentFrontendURL")
        //                {
        //                    Common_PostDeploymentFrontendURL = pair.Value;
        //                }
        //                else if (pair.Key == "Common_AdminEmail")
        //                {
        //                    Common_AdminEmail = pair.Value;
        //                }
        //                else if (pair.Key == "Common_PostDeploymentAdminEmail")
        //                {
        //                    Common_PostDeploymentAdminEmail = pair.Value;
        //                }
        //                else if (pair.Key == "Common_AdminPassword")
        //                {
        //                    Common_AdminPassword = pair.Value;
        //                }
        //                else if (pair.Key == "Common_FrontEndEmail")
        //                {
        //                    Common_FrontEndEmail = pair.Value;
        //                }
        //                else if (pair.Key == "Common_FrontEndPass")
        //                {
        //                    Common_FrontEndPass = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_Email")
        //                {
        //                    Common_Registration_Email = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_ConfirmEmail")
        //                {
        //                    Common_Registration_ConfirmEmail = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_Password")
        //                {
        //                    Common_Registration_Password = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_ConfirmPassword")
        //                {
        //                    Common_Registration_ConfirmPassword = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_SecurityQuestion")
        //                {
        //                    Common_Registration_SecurityQuestion = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_SecurityAnswer")
        //                {
        //                    Common_Registration_SecurityAnswer = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_Country")
        //                {
        //                    Common_Registration_Country = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_Language")
        //                {
        //                    Common_Registration_Language = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_Title")
        //                {
        //                    Common_Registration_Title = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_FirstName")
        //                {
        //                    Common_Registration_FirstName = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_LastName")
        //                {
        //                    Common_Registration_LastName = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_BirthdayMonth")
        //                {
        //                    Common_Registration_BirthdayMonth = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_BirthdayDay")
        //                {
        //                    Common_Registration_BirthdayDay = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_Address1")
        //                {
        //                    Common_Registration_Address1 = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_Address2")
        //                {
        //                    Common_Registration_Address2 = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_City")
        //                {
        //                    Common_Registration_City = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_State")
        //                {
        //                    Common_Registration_State = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_Zip")
        //                {
        //                    Common_Registration_Zip = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_WorkPhonePrefix")
        //                {
        //                    Common_Registration_WorkPhonePrefix = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_WorkPhoneAreaCode")
        //                {
        //                    Common_Registration_WorkPhoneAreaCode = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_WorkPhoneFirstThree")
        //                {
        //                    Common_Registration_WorkPhoneFirstThree = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_WorkPhoneLastFour")
        //                {
        //                    Common_Registration_WorkPhoneLastFour = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_WorkPhoneExtension")
        //                {
        //                    Common_Registration_WorkPhoneExtension = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_HomePhonePrefix")
        //                {
        //                    Common_Registration_HomePhonePrefix = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_HomePhoneAreaCode")
        //                {
        //                    Common_Registration_HomePhoneAreaCode = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_HomePhoneFirstThree")
        //                {
        //                    Common_Registration_HomePhoneFirstThree = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_HomePhoneLastFour")
        //                {
        //                    Common_Registration_HomePhoneLastFour = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_MobilePhonePrefix")
        //                {
        //                    Common_Registration_MobilePhonePrefix = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_MobilePhoneAreaCode")
        //                {
        //                    Common_Registration_MobilePhoneAreaCode = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_MobilePhoneFirstThree")
        //                {
        //                    Common_Registration_MobilePhoneFirstThree = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_MobilePhoneLastFour")
        //                {
        //                    Common_Registration_MobilePhoneLastFour = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_FaxPhonePrefix")
        //                {
        //                    Common_Registration_FaxPhonePrefix = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_FaxPhoneAreaCode")
        //                {
        //                    Common_Registration_FaxPhoneAreaCode = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_FaxPhoneFirstThree")
        //                {
        //                    Common_Registration_FaxPhoneFirstThree = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_FaxPhoneLastFour")
        //                {
        //                    Common_Registration_FaxPhoneLastFour = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_IATA")
        //                {
        //                    Common_Registration_IATA = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_ARC")
        //                {
        //                    Common_Registration_ARC = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_CLIA")
        //                {
        //                    Common_Registration_CLIA = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_TRU")
        //                {
        //                    Common_Registration_TRU = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_ACTA")
        //                {
        //                    Common_Registration_ACTA = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_TIDS")
        //                {
        //                    Common_Registration_TIDS = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_TICO")
        //                {
        //                    Common_Registration_TICO = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_ABTA")
        //                {
        //                    Common_Registration_ABTA = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_ATOL")
        //                {
        //                    Common_Registration_ATOL = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_RetailAgency")
        //                {
        //                    Common_Registration_RetailAgency = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_RemoteHomeBased")
        //                {
        //                    Common_Registration_RemoteHomeBased = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_TourOperatorWholesaler")
        //                {
        //                    Common_Registration_TourOperatorWholesaler = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_MeetingPlanner")
        //                {
        //                    Common_Registration_MeetingPlanner = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_DestinationWeddingSpecialist")
        //                {
        //                    Common_Registration_DestinationWeddingSpecialist = pair.Value;
        //                }
        //                else if (pair.Key == "Common_Registration_Affiliation")
        //                {
        //                    Common_Registration_Affiliation = pair.Value;
        //                }

        //            }

        //            #endregion[Common]

        //            #region[TP_38859]                

        //            #region[TC_27838]

        //            else if (testCase == Constants.TC_27838)
        //            {
        //                if (pair.Key == "TC_27838_IATA")
        //                {
        //                    TC_27838_IATA = pair.Value;
        //                }
        //                else if (pair.Key == "TC_27838_CLIA")
        //                {
        //                    TC_27838_CLIA = pair.Value;
        //                }
        //                else if (pair.Key == "TC_27838_ARC")
        //                {
        //                    TC_27838_ARC = pair.Value;
        //                }
        //                else if (pair.Key == "TC_27838_TRU")
        //                {
        //                    TC_27838_TRU = pair.Value;
        //                }
        //            }
        //            #endregion[TC_27838]

        //            #region[TC_37518]

        //            else if (testCase == Constants.TC_37518)
        //            {
        //                if (pair.Key == "TC_37518_Email")
        //                {
        //                    TC_37518_Email = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37518_ConfirmEmail")
        //                {
        //                    TC_37518_ConfirmEmail = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37518_NewPassword")
        //                {
        //                    TC_37518_NewPassword = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37518_ConfirmNewPassword")
        //                {
        //                    TC_37518_ConfirmNewPassword = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37518_RecoveryQuestion")
        //                {
        //                    TC_37518_RecoveryQuestion = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37518_RecoveryAnswer")
        //                {
        //                    TC_37518_RecoveryAnswer = pair.Value;
        //                }
        //            }
        //            #endregion[TC_37518]

        //            #region[TC_37548]

        //            else if (testCase == Constants.TC_37548)
        //            {
        //                if (pair.Key == "TC_37548_BookingType")
        //                {
        //                    TC_37548_BookingType = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37548_RoomNum")
        //                {
        //                    TC_37548_RoomNum = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37548_BookingMadeWith")
        //                {
        //                    TC_37548_BookingMadeWith = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37548_BookingNumber")
        //                {
        //                    TC_37548_BookingNumber = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37548_GuestFirstName")
        //                {
        //                    TC_37548_GuestFirstName = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37548_GuestLastName")
        //                {
        //                    TC_37548_GuestLastName = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37548_DateBookedMonth")
        //                {
        //                    TC_37548_DateBookedMonth = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37548_DateBookedDay")
        //                {
        //                    TC_37548_DateBookedDay = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37548_DateBookedYear")
        //                {
        //                    TC_37548_DateBookedYear = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37548_TravelStartMonth")
        //                {
        //                    TC_37548_TravelStartMonth = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37548_TravelStartDay")
        //                {
        //                    TC_37548_TravelStartDay = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37548_TravelStartYear")
        //                {
        //                    TC_37548_TravelStartYear = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37548_TravelEndMonth")
        //                {
        //                    TC_37548_TravelEndMonth = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37548_TravelEndDay")
        //                {
        //                    TC_37548_TravelEndDay = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37548_TravelEndYear")
        //                {
        //                    TC_37548_TravelEndYear = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37548_Brand")
        //                {
        //                    TC_37548_Brand = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37548_Resort")
        //                {
        //                    TC_37548_Resort = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37548_DepartureGateway")
        //                {
        //                    TC_37548_DepartureGateway = pair.Value;
        //                }
        //            }

        //            #endregion[TC_37548]

        //            #region[TC_37553]

        //            else if (testCase == Constants.TC_37553)
        //            {
        //                if (pair.Key == "TC_37553_BookingType")
        //                {
        //                    TC_37553_BookingType = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37553_RoomNum")
        //                {
        //                    TC_37553_RoomNum = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37553_BookingMadeWith")
        //                {
        //                    TC_37553_BookingMadeWith = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37553_BookingNumber")
        //                {
        //                    TC_37553_BookingNumber = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37553_GuestFirstName")
        //                {
        //                    TC_37553_GuestFirstName = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37553_GuestLastName")
        //                {
        //                    TC_37553_GuestLastName = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37553_DateBookedMonth")
        //                {
        //                    TC_37553_DateBookedMonth = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37553_DateBookedDay")
        //                {
        //                    TC_37553_DateBookedDay = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37553_DateBookedYear")
        //                {
        //                    TC_37553_DateBookedYear = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37553_TravelStartMonth")
        //                {
        //                    TC_37553_TravelStartMonth = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37553_TravelStartDay")
        //                {
        //                    TC_37553_TravelStartDay = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37553_TravelStartYear")
        //                {
        //                    TC_37553_TravelStartYear = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37553_TravelEndMonth")
        //                {
        //                    TC_37553_TravelEndMonth = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37553_TravelEndDay")
        //                {
        //                    TC_37553_TravelEndDay = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37553_TravelEndYear")
        //                {
        //                    TC_37553_TravelEndYear = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37553_Brand")
        //                {
        //                    TC_37553_Brand = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37553_Resort")
        //                {
        //                    TC_37553_Resort = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37553_DepartureGateway")
        //                {
        //                    TC_37553_DepartureGateway = pair.Value;
        //                }
        //            }

        //            #endregion[TC_37553]

        //            #region[TC_37513]

        //            else if (testCase == Constants.TC_37513)
        //            {
        //                if (pair.Key == "TC_37513_IATA")
        //                {
        //                    TC_37513_IATA = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37513_CLIA")
        //                {
        //                    TC_37513_CLIA = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37513_ARC")
        //                {
        //                    TC_37513_ARC = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37513_TRU")
        //                {
        //                    TC_37513_TRU = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37513_Country")
        //                {
        //                    TC_37513_Country = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37513_TIDS")
        //                {
        //                    TC_37513_TIDS = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37513_TICO")
        //                {
        //                    TC_37513_TICO = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37513_Providence")
        //                {
        //                    TC_37513_Providence = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37513_Address")
        //                {
        //                    TC_37513_Address = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37513_City")
        //                {
        //                    TC_37513_City = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37513_Zip")
        //                {
        //                    TC_37513_Zip = pair.Value;
        //                }
        //            }
        //            #endregion[TC_37513]

        //            #region[TC_37522]

        //            else if (testCase == Constants.TC_37522)
        //            {
        //                if (pair.Key == "TC_37522_EmailAddress")
        //                {
        //                    TC_37522_EmailAddress = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37522_NewPassword")
        //                {
        //                    TC_37522_NewPassword = pair.Value;
        //                }
        //            }
        //            #endregion[TC_37522]

        //            #region[TC_37609]

        //            else if (testCase == Constants.TC_37609)
        //            {
        //                if (pair.Key == "TC_37609_IATA")
        //                {
        //                    TC_37609_IATA = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37609_Country")
        //                {
        //                    TC_37609_Country = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37609_Providence")
        //                {
        //                    TC_37609_Providence = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37609_Address")
        //                {
        //                    TC_37609_Address = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37609_City")
        //                {
        //                    TC_37609_City = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37609_Zip")
        //                {
        //                    TC_37609_Zip = pair.Value;
        //                }
        //            }
        //            #endregion[TC_37609]

        //            #region[TC_37649]

        //            else if (testCase == Constants.TC_37649)
        //            {
        //                if (pair.Key == "TC_37649_IATA")
        //                {
        //                    TC_37649_IATA = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37649_Country")
        //                {
        //                    TC_37649_Country = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37649_Providence")
        //                {
        //                    TC_37649_Providence = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37649_Address")
        //                {
        //                    TC_37649_Address = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37649_City")
        //                {
        //                    TC_37649_City = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37649_Zip")
        //                {
        //                    TC_37649_Zip = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37649_RecoveryQuestion")
        //                {
        //                    TC_37649_RecoveryQuestion = pair.Value;
        //                }
        //                else if (pair.Key == "TC_37649_RecoveryAnswer")
        //                {
        //                    TC_37649_RecoveryAnswer = pair.Value;
        //                }
        //            }
        //            #endregion[TC_37649]

        //            #endregion[TP_38859]

        //            #region[TP_38860]                

        //            #region[TC_37501]

        //            else if (testCase == Constants.TC_37501)
        //            {
        //                if (pair.Key == "TC_37501_SearchUser")
        //                    TC_37501_SearchUser = pair.Value;
        //                else if (pair.Key == "TC_37501_Password")
        //                    TC_37501_Password = pair.Value;
        //                else if (pair.Key == "TC_37501_Firstname")
        //                    TC_37501_Firstname = pair.Value;
        //                else if (pair.Key == "TC_37501_Lastname")
        //                    TC_37501_Lastname = pair.Value;
        //            }
        //            #endregion[TC_37501]               

        //            #region[TC_37502]

        //            else if (testCase == Constants.TC_37502)
        //            {
        //                if (pair.Key == "TC_37502_SearchUser")
        //                    TC_37502_SearchUser = pair.Value;
        //                else if (pair.Key == "TC_37502_Password")
        //                    TC_37502_Password = pair.Value;
        //                else if (pair.Key == "TC_37502_NewPassword")
        //                    TC_37502_NewPassword = pair.Value;
        //            }
        //            #endregion[TC_37502]               

        //            #region[TC_37504]

        //            else if (testCase == Constants.TC_37504)
        //            {
        //                if (pair.Key == "TC_37504_SearchUser")
        //                    TC_37504_SearchUser = pair.Value;
        //                else if (pair.Key == "TC_37504_Password")
        //                    TC_37504_Password = pair.Value;
        //                else if (pair.Key == "TC_37504_NewPassword")
        //                    TC_37504_NewPassword = pair.Value;
        //            }
        //            #endregion[TC_37504]               

        //            #region[TC_37509]

        //            else if (testCase == Constants.TC_37509)
        //            {
        //                if (pair.Key == "TC_37509_SearchUser")
        //                    TC_37509_SearchUser = pair.Value;
        //            }
        //            #endregion[TC_37509]               

        //            #region[TC_37514]

        //            else if (testCase == Constants.TC_37514)
        //            {
        //                if (pair.Key == "TC_37514_SearchUser")
        //                    TC_37514_SearchUser = pair.Value;
        //            }
        //            #endregion[TC_37514]               

        //            #region[TC_37515]

        //            else if (testCase == Constants.TC_37515)
        //            {
        //                if (pair.Key == "TC_37515_SearchUser")
        //                    TC_37515_SearchUser = pair.Value;
        //            }
        //            #endregion[TC_37515]               

        //            #region[TC_37516]

        //            else if (testCase == Constants.TC_37516)
        //            {
        //                if (pair.Key == "TC_37516_SearchUser")
        //                    TC_37516_SearchUser = pair.Value;
        //            }
        //            #endregion[TC_37516]               

        //            #region[TC_42271]

        //            else if (testCase == Constants.TC_42271)
        //            {
        //                if (pair.Key == "TC_42271_SearchUser")
        //                    TC_42271_SearchUser = pair.Value;
        //                else if (pair.Key == "TC_42271_Email")
        //                    TC_42271_Email = pair.Value;
        //            }
        //            #endregion[TC_42271]               

        //            #endregion[TP_38860]
        //        }

        //        return obj;
        //    }
    }

}

