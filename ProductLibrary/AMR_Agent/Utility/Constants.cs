using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMR_Agent.Utility
{
    public class Constants : Common.Constants
    {
        public static string Admin = "Admin";
        public static string ModuleAdminEditProfile = "ModuleAdminEditProfile";
        public static string ModuleAdminHome = "ModuleAdminHome";
        public static string ModuleAdminManageBookings = "ModuleAdminManageBookings";
        public static string ModuleAdminManageRedemptions = "ModuleAdminManageRedemptions";
        public static string ModuleAccountSummary = "ModuleAccountSummary";
        public static string ModuleAdminLogin = "ModuleAdminLogin";
        public static string ModuleAdminManageProfiles = "ModuleAdminManageProfiles";
        public static string ModuleAdminValidatedProfiles = "ModuleAdminValidatedProfiles";
        public static string ModuleAMRAgentsNav = "ModuleAMRAgentsNav";
        public static string ModuleAMRewards = "ModuleAMRewards";
        public static string ModuleForgotPassword = "ModuleForgotPassword";
        public static string ModuleLogin = "ModuleLogin";
        public static string ModuleRegistration = "ModuleRegistration";
        public static string ModuleSubmitBooking = "ModuleSubmitBooking";
        public static string ModuleUpdateProfile = "ModuleUpdateProfile";

        #region[Test Plan]
        public static string TP_38860 = "TP_38860";
        public static string TP_38859 = "TP_38859";
        public static string TP_273216 = "TP_273216";
        
        #endregion[Test Plan]
        #region[TestCase]
        public static string TC_37501 = "TC_37501";
        public static string TC_37502 = "TC_37502";
        public static string TC_37504 = "TC_37504";
        public static string TC_37509 = "TC_37509";
        public static string TC_37514 = "TC_37514";
        public static string TC_37515 = "TC_37515";
        public static string TC_37516 = "TC_37516";
        public static string TC_37519 = "TC_37519";
        public static string TC_42271 = "TC_42271";
        public static string TC_27838 = "TC_27838";
        public static string TC_37518 = "TC_37518";
        public static string TC_37539 = "TC_37539";
        public static string TC_37548 = "TC_37548";
        public static string TC_37550 = "TC_37550";
        public static string TC_37553 = "TC_37553";
        public static string TC_37604 = "TC_37604";
        public static string TC_37609 = "TC_37609";
        public static string TC_37513 = "TC_37513";
        public static string TC_37522 = "TC_37522";
        public static string TC_37649 = "TC_37649"; 
        public static string TC_281327 = "TC_281327";

        #endregion[TestCase]


        //Excel Sheet Names
        public static string TestData_AMRRegistration = "TestData_AMRRegistration";
        public static string TestData_AMRForgotPassword = "TestData_AMRForgotPassword";
        public static string TestData_SubmitBooking_TC37548 = "TestData_SubmitBooking_TC37548";
        public static string TestData_SummaryBooking_TC37550 = "TestData_SummaryBooking_TC37550";

        //Excel Column Names 
        #region[Registration]
        public static string RegisterEmail = "RegisterEmail";
        public static string RegisterConfirmEmail = "RegisterConfirmEmail";
        public static string RegisterPassword = "RegisterPassword";
        public static string RegisterConfirmPassword = "RegisterConfirmPassword";
        public static string RegisterSecurityQuestion = "RegisterSecurityQuestion";
        public static string RegisterSecurityAnswer = "RegisterSecurityAnswer";
        public static string RegisterCountry = "RegisterCountry";
        public static string RegisterLanguage = "RegisterLanguage";
        public static string RegisterTitle = "RegisterTitle";
        public static string RegisterFirstName = "RegisterFirstName";
        public static string RegisterLastName = "RegisterLastName";
        public static string RegisterBirthdayMonth = "RegisterBirthdayMonth";
        public static string RegisterBirthdayDay = "RegisterBirthdayDay";
        public static string RegisterAddress1 = "RegisterAddress1";
        public static string RegisterAddress2 = "RegisterAddress2";
        public static string RegisterCity = "RegisterCity";
        public static string RegisterState = "RegisterState";
        public static string RegisterZip = "RegisterZip";
        public static string RegisterWorkPhonePrefix = "RegisterWorkPhonePrefix";
        public static string RegisterWorkPhoneAreaCode = "RegisterWorkPhoneAreaCode";
        public static string RegisterWorkPhoneFirst3 = "RegisterWorkPhoneFirst3";
        public static string RegisterWorkPhoneLast4 = "RegisterWorkPhoneLast4";
        public static string RegisterWorkExtension = "RegisterWorkExtension";
        public static string RegisterHomePhonePrefix = "RegisterHomePhonePrefix";
        public static string RegisterHomePhoneAreaCode = "RegisterHomePhoneAreaCode";
        public static string RegisterHomePhoneFirst3 = "RegisterHomePhoneFirst3";
        public static string RegisterHomePhoneLast4 = "RegisterHomePhoneLast4";
        public static string RegisterMobilePhonePrefix = "RegisterMobilePhonePrefix";
        public static string RegisterMobilePhoneAreaCode = "RegisterMobilePhoneAreaCode";
        public static string RegisterMobilePhoneFirst3 = "RegisterMobilePhoneFirst3";
        public static string RegisterMobilePhoneLast4 = "RegisterMobilePhoneLast4";
        public static string RegisterFaxPhonePrefix = "RegisterFaxPhonePrefix";
        public static string RegisterFaxPhoneAreaCode = "RegisterFaxPhoneAreaCode";
        public static string RegisterFaxPhoneFirst3 = "RegisterFaxPhoneFirst3";
        public static string RegisterFaxPhoneLast4 = "RegisterFaxPhoneLast4";
        public static string RegisterIATA = "RegisterIATA";
        public static string RegisterARC = "RegisterARC";
        public static string RegisterCLIA = "RegisterCLIA";
        public static string RegisterTRU = "RegisterTRU";
        public static string RegisterACTA = "RegisterACTA";
        public static string RegisterTIDS = "RegisterTIDS";
        public static string RegisterTICO = "RegisterTICO";
        public static string RegisterABTA = "RegisterABTA";
        public static string RegisterATOL = "RegisterATOL";
        public static string RegisterRetailAgency = "RegisterRetailAgency";
        public static string RegisterRemoteHomeBased = "RegisterRemoteHomeBased";
        public static string RegisterTourOperatorWholesaler = "RegisterTourOperatorWholesaler";
        public static string RegisterMeetingPlanner = "RegisterMeetingPlanner";
        public static string RegisterDestinationWeddingSpecialist = "RegisterDestinationWeddingSpecialist";
        public static string RegisterAffiliation = "RegisterAffiliation";
        public static string RegisterRegisterButton = "RegisterRegisterButton";
        public static string RegisterCancel = "RegisterCancel";
        #endregion[Registration]

        #region[Forgot Password]
        public static string ForgotPasswordEmail = "ForgotPasswordEmail";
        public static string ForgotPasswordRecoveryAnswer = "ForgotPasswordRecoveryAnswer";
        public static string ForgotPasswordNewPassword = "ForgotPasswordNewPassword";
        public static string ForgotPasswordNewPasswordConfirmation = "ForgotPasswordNewPasswordConfirmation";
        public static string ForgotPasswordRecoveryQuestion = "ForgotPasswordRecoveryQuestion";
        public static string InActiveProfileConfirmation(string email)
        {
            return "The profile for Member id Email address" + email + "has been inactivated.";
        }

        public static string ReactiveProfileConfirmation(string email)
        {
            return "The profile for Member id Email address " + email + " has been activated.";
        }


        #endregion[Forgot Password]

        #region[Submit Booking TC37548]
        public static string BookingType = "BookingType";
        public static string GroupType = "GroupType";
        public static string RoomNum = "RoomNum";
        public static string BookingMadeWith = "BookingMadeWith";
        public static string BookingNumber = "BookingNumber";
        public static string GuestFirstName = "GuestFirstName";
        public static string GuestLastName = "GuestLastName";
        public static string DateBookedMonth = "DateBookedMonth";
        public static string DateBookedDay = "DateBookedDay";
        public static string DateBookedYear = "DateBookedYear";
        public static string TravelStartMonth = "TravelStartMonth";
        public static string TravelStartDay = "TravelStartDay";
        public static string TravelStartYear = "TravelStartYear";
        public static string TravelEndMonth = "TravelEndMonth";
        public static string TravelEndDay = "TravelEndDay";
        public static string TravelEndYear = "TravelEndYear";
        public static string Brand = "Brand";
        public static string Resort = "Resort";
        public static string DepartureGateway = "DepartureGateway";
        #endregion[Submit Booking TC37548]

        //Stored Information
        public static string UpdateProfileW9Warning =
            "Please complete the W-9 form located in the Update Profile section. Once completed, you may start redeeming! ";
        public static string SubmitBookingAddToBookingPopupText =
            "All booking information finished, you can submit your booking now by clicking SUBMIT button.";
        public static string SubmitBookingSubmittedSuccessfully = "The booking was submitted successfully.";
        public static string ExistingBookingNumber_TC37553 = "123";
        public static string ProfileUpdateConfirmation = "Profile updated successfully.";
        public static string ResetPasswordConfirmation = "Profile updated successfully.";
        public static string InvalidLoginConfirmation = "Invalid Username or Password Please Try Again.";
        public static string DeleteConfirmation = "You are about to delete booking";
        public static string ProfileDeleteWarning(string email)
        {
            return "Are you sure you want to delete" + email + "?";
        }
        public static string ProfileDeleteConfirmation = "Agent deleted.";
        public static string CertificateConfirmation = "Certificate has been resent";
        public static string PasswordResetConfirmation = "Password reset was successful";
        public static string WelcomeEmailSubject = "Welcome to AMRAgents!";


        //Urls to confirm
        //public static string AMRewardsPointsAvailableURL_TC37604 = "https://travelagentloyaltyprogram.qa.cendyn.com/home.mvc/AccountSummary/Index";
        public static string AMRewardsPointsAvailableURL_TC37604 = "https://travelagentloyaltyprogram.qaeloyaltyadmin.com/home.mvc/AccountSummary/Index";
        // public static string AMRewardsPointsRedeemedURL_TC37604 = "https://travelagentloyaltyprogram.qa.cendyn.com/home.mvc/RedemptionRequest/Index";
        public static string AMRewardsPointsRedeemedURL_TC37604 = "https://travelagentloyaltyprogram.qaeloyaltyadmin.com/home.mvc/RedemptionRequest/Index";
        //public static string AMRewardsPointsExpiringURL_TC37604 = "https://travelagentloyaltyprogram.qa.cendyn.com/home.mvc/PointsHistory/Index";
        public static string AMRewardsPointsExpiringURL_TC37604 = "https://travelagentloyaltyprogram.qaeloyaltyadmin.com/home.mvc/PointsHistory/Index";


        //Nunit Nodes to read data from Nunit.xml
        public static string BrowserNodeNunitXml = "AMRCredential/Browser/Browsertype";
        public static string AdminURL = "AMRCredential/Url/AdminURL";
        public static string FrontendURL = "AMRCredential/Url/FrontendURL";
        public static string AdminUserName = "AMRCredential/LoginCredential-Development/AdminUsername";
        public static string AdminPassword = "AMRCredential/LoginCredential-Development/AdminPassword";
        public static string LoginEmail = "AMRCredential/LoginCredential-Development/EmployeeEmail";
        public static string LoginPassword = "AMRCredential/LoginCredential-Development/EmployeePassword";

        //ReportGeneration Keyword
        public static string Keywordfail = "FAIL";

        //Folder Locations

        //public static string ScreenshotPath = String.Concat(TestDataLocation.actualPath, ConfigurationManager.AppSettings["ScreenshotPath"]);
        //public static string ReportScreenshotPath = String.Concat(TestDataLocation.actualPath, ConfigurationManager.AppSettings["ReportScreenshotPath"]);
        //public static string ReportPath = String.Concat(TestDataLocation.actualPath, ConfigurationManager.AppSettings["ReportPath"]);
        //public static string ObjectRepofile = String.Concat(TestDataLocation.actualPath, ConfigurationManager.AppSettings["ObjectRepofile"]);
        //public static string LoggerFile = String.Concat(TestDataLocation.actualPath, ConfigurationManager.AppSettings["LoggerFile"]);
        //public static string ChromeDriver = String.Concat(TestDataLocation.actualPath, Convert.ToString(ConfigurationManager.AppSettings["ChromeDriver"]));
        //public static string IeDriver = String.Concat(TestDataLocation.actualPath, Convert.ToString(ConfigurationManager.AppSettings["IEDriver"]));

        //Common
        public static string Common_AdminURL = "https://traveladminloyaltyprogram.qaeloyaltyadmin.com/";
        public static string Common_PostDeploymentAdminURL = "https://traveladminloyaltyprogram.cendyn.com/";
        public static string Common_FrontendURL = "https://travelagentloyaltyprogram.qaeloyaltyadmin.com/";
        public static string Common_PostDeploymentFrontendURL = "https://amrewards.amragents.com/";

        //Credential to Login to AMR sites
        public static string Common_AdminEmail = "rjoshi@delaplex.in";
        public static string Common_PostDeploymentAdminEmail = "CendynAutomation@cendyn.com";
        public static string Common_AdminPassword = "Cendyn123$";
       //public static string Common_FrontEndEmail = "ruchitest121@cendyn17.com";
        public static string Common_FrontEndEmail = "sendgrid003@cendyn17.com";
        public static string Common_FrontEndPass = "Cendyn123$";


        //Generic Registration Information
        public static string Common_Registration_Email = "AutoTest@cendyn17.com";
        public static string Common_Registration_ConfirmEmail = "AutoTest@cendyn17.com";
        public static string Common_Registration_Password = "Cendyn123$";
        public static string Common_Registration_ConfirmPassword = "Cendyn123$";
        public static string Common_Registration_SecurityQuestion = "What was your childhood nickname?";
        public static string Common_Registration_SecurityAnswer = "Rocko";
        public static string Common_Registration_Country = "United States";
        public static string Common_Registration_Language = "English";
        public static string Common_Registration_Title = "Mr";
        public static string Common_Registration_FirstName = "QA";
        public static string Common_Registration_LastName = "Testing";
        public static string Common_Registration_BirthdayMonth = "June";
        public static string Common_Registration_BirthdayDay = "28";
        public static string Common_Registration_Address1 = "980 N Federal Hwy";
        public static string Common_Registration_Address2 = "Ste 200";
        public static string Common_Registration_City = "Boca Raton";
        public static string Common_Registration_State = "Florida";
        public static string Common_Registration_Zip = "33432";
        public static string Common_Registration_WorkPhonePrefix = "1";
        public static string Common_Registration_WorkPhoneAreaCode = "954";
        public static string Common_Registration_WorkPhoneFirstThree = "638";
        public static string Common_Registration_WorkPhoneLastFour = "2023";
        public static string Common_Registration_WorkPhoneExtension = "8004";
        public static string Common_Registration_HomePhonePrefix = "2";
        public static string Common_Registration_HomePhoneAreaCode = "305";
        public static string Common_Registration_HomePhoneFirstThree = "123";
        public static string Common_Registration_HomePhoneLastFour = "4567";
        public static string Common_Registration_MobilePhonePrefix = "3";
        public static string Common_Registration_MobilePhoneAreaCode = "281";
        public static string Common_Registration_MobilePhoneFirstThree = "330";
        public static string Common_Registration_MobilePhoneLastFour = "8004";
        public static string Common_Registration_FaxPhonePrefix = "4";
        public static string Common_Registration_FaxPhoneAreaCode = "800";
        public static string Common_Registration_FaxPhoneFirstThree = "215";
        public static string Common_Registration_FaxPhoneLastFour = "6548";
        public static string Common_Registration_IATA = "67839085";
        public static string Common_Registration_ARC = "5512216";
        public static string Common_Registration_CLIA = "307403";
        public static string Common_Registration_TRU = "52440544";
        public static string Common_Registration_ACTA = "";
        public static string Common_Registration_TIDS = "10672071";
        public static string Common_Registration_TICO = "10674801";
        public static string Common_Registration_ABTA = "";
        public static string Common_Registration_ATOL = "";
        public static string Common_Registration_RetailAgency = "No";
        public static string Common_Registration_RemoteHomeBased = "Yes";
        public static string Common_Registration_TourOperatorWholesaler = "No";
        public static string Common_Registration_MeetingPlanner = "No";
        public static string Common_Registration_DestinationWeddingSpecialist = "No";
        public static string Common_Registration_Affiliation = "CCRA";

        public static string CommonPassword()
        {
            string password = "Cendyn123$";
            return password;

        }
    }
   
}
