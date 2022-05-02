using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AMR_Agent.Utility
{
    public class ObjectRepository
    {
        #region[UI]

        #region[Login]
        public static string LoginEmail { get; set; }
        public static string LoginPassword { get; set; }
        public static string LoginSignIn { get; set; }
        public static string LoginForgotPassword { get; set; }
        public static string LoginRegisterNow { get; set; }
        public static string Login_AcceptConsentToCookies { get; set; }
        public static string Login_Close { get; set; }
        #endregion[Login]

        #region[Register]
        public static string RegisterEmail { get; set; }
        public static string RegisterConfirmEmail { get; set; }
        public static string RegisterPassword { get; set; }
        public static string RegisterConfirmPassword { get; set; }
        public static string RegisterSecurityQuestion { get; set; }
        public static string RegisterSecurityAnswer { get; set; }
        public static string RegisterCountry { get; set; }
        public static string RegisterLanguage { get; set; }
        public static string RegisterTitle { get; set; }
        public static string RegisterFirstName { get; set; }
        public static string RegisterLastName { get; set; }
        public static string RegisterBirthdayMonth { get; set; }
        public static string RegisterBirthdayDay { get; set; }
        public static string RegisterAddress1 { get; set; }
        public static string RegisterAddress2 { get; set; }
        public static string RegisterCity { get; set; }
        public static string RegisterState { get; set; }
        public static string RegisterProvince { get; set; }
        public static string RegisterZip { get; set; }
        public static string RegisterWorkPhonePrefix { get; set; }
        public static string RegisterWorkPhoneAreaCode { get; set; }
        public static string RegisterWorkPhoneFirst3 { get; set; }
        public static string RegisterWorkPhoneLast4 { get; set; }
        public static string RegisterWorkExtension { get; set; }
        public static string RegisterHomePhonePrefix { get; set; }
        public static string RegisterHomePhoneAreaCode { get; set; }
        public static string RegisterHomePhoneFirst3 { get; set; }
        public static string RegisterHomePhoneLast4 { get; set; }
        public static string RegisterMobilePhonePrefix { get; set; }
        public static string RegisterMobilePhoneAreaCode { get; set; }
        public static string RegisterMobilePhoneFirst3 { get; set; }
        public static string RegisterMobilePhoneLast4 { get; set; }
        public static string RegisterFaxPhonePrefix { get; set; }
        public static string RegisterFaxPhoneAreaCode { get; set; }
        public static string RegisterFaxPhoneFirst3 { get; set; }
        public static string RegisterFaxPhoneLast4 { get; set; }
        public static string RegisterIATA { get; set; }
        public static string RegisterARC { get; set; }
        public static string RegisterCLIA { get; set; }
        public static string RegisterTRU { get; set; }
        public static string RegisterACTA { get; set; }
        public static string RegisterTIDS { get; set; }
        public static string RegisterTICO { get; set; }
        public static string RegisterABTA { get; set; }
        public static string RegisterATOL { get; set; }
        public static string RegisterRetailAgency { get; set; }
        public static string RegisterRemoteHomeBased { get; set; }
        public static string RegisterTourOperatorWholesaler { get; set; }
        public static string RegisterMeetingPlanner { get; set; }
        public static string RegisterDestinationWeddingSpecialist { get; set; }
        public static string RegisterAffiliation { get; set; }
        public static string RegisterRegisterButton { get; set; }
        public static string RegisterCancel { get; set; }
        public static string RegisterRegistrationCompleteButton { get; set; }
        public static string Register_RegistrationEnroll_Me { get; set; }
        public static string Register_RegistrationAccept { get; set; }
        public static string Register_AddressSuggestionPopup_ClickYes { get; set; }
        #endregion[Register]

        #region[AMRAgents]
        public static string AMRAgentsHome { get; set; }
        public static string AMRAgentsBookNow { get; set; }
        public static string AMRAgentsGDSCodes { get; set; }
        public static string AMRAgentsAMRewards { get; set; }
        public static string AMRAgentsUpdateProfile { get; set; }
        public static string AMRAgentsLogOff { get; set; }
        public static string AMRAgentsAccountSummary { get; set; }
        public static string AMRAgentsMyRedemptions { get; set; }
        public static string AMRAgentsSubmitBooking { get; set; }
        #endregion[AMRAgents]

        #region[SubmitBooking]
        public static string SubmitBookingIndividualRadioButton { get; set; }
        public static string SubmitBookingGroupTypeRadioButton { get; set; }
        public static string SubmitBookingGroupTypeDropDown { get; set; }
        public static string SubmitBookingNumOfRooms { get; set; }
        public static string SubmitBookingSetGroupButton { get; set; }
        public static string SubmitBookingGroupName { get; set; }
        public static string SubmitBookingRoomNumber { get; set; }
        public static string SubmitBookingBookingMadeWith { get; set; }
        public static string SubmitBookingBookingNumber { get; set; }
        public static string SubmitBookingGuestFirstName { get; set; }
        public static string SubmitBookingGuestLastName { get; set; }
        public static string SubmitBookingDateBooked { get; set; }
        public static string SubmitBookingTravelStartDate { get; set; }
        public static string SubmitBookingTravelEndDate { get; set; }
        public static string SubmitBookingBrand { get; set; }
        public static string SubmitBookingResort { get; set; }
        public static string SubmitBookingDepartureGateway1 { get; set; }
        public static string SubmitBookingDepartureGateway { get; set; }
        public static string SubmitBookingAddToBookingSummary { get; set; }
        public static string SubmitBookingClear { get; set; }
        public static string SelectBooking { get; set; }
        public static string SubmitBookingSubmit { get; set; }
        public static string SubmitBookingPopupOKBtn { get; set; }
        public static string SubmitBookingSubmitPopupOKBtn { get; set; }
        public static string SubmitBookingDatePickerMonth { get; set; }
        public static string SubmitBookingDatePickerYear { get; set; }


        #endregion[SubmitBooking]

        #region[UpdateProfile]
        public static string UpdateProfileEmail { get; set; }
        public static string UpdateProfileConfirmEmail { get; set; }
        public static string UpdateProfileSecurityQuestion { get; set; }
        public static string UpdateProfileSecurityAnswer { get; set; }
        public static string UpdateProfileCountry { get; set; }
        public static string UpdateProfileLanguage { get; set; }
        public static string UpdateProfileTitle { get; set; }
        public static string UpdateProfileFirstName { get; set; }
        public static string UpdateProfileLastName { get; set; }
        public static string UpdateProfileBirthdayMonth { get; set; }
        public static string UpdateProfileBirthdayDay { get; set; }
        public static string UpdateProfileAddress1 { get; set; }
        public static string UpdateProfileAddress2 { get; set; }
        public static string UpdateProfileCity { get; set; }
        public static string UpdateProfileState { get; set; }
        public static string UpdateProfileProvince { get; set; }
        public static string UpdateProfileZip { get; set; }
        public static string UpdateProfileWorkPhonePrefix { get; set; }
        public static string UpdateProfileWorkPhoneAreaCode { get; set; }
        public static string UpdateProfileWorkPhoneFirst3 { get; set; }
        public static string UpdateProfileWorkPhoneLast4 { get; set; }
        public static string UpdateProfileWorkExtension { get; set; }
        public static string UpdateProfileHomePhonePrefix { get; set; }
        public static string UpdateProfileHomePhoneAreaCode { get; set; }
        public static string UpdateProfileHomePhoneFirst3 { get; set; }
        public static string UpdateProfileHomePhoneLast4 { get; set; }
        public static string UpdateProfileMobilePhonePrefix { get; set; }
        public static string UpdateProfileMobilePhoneAreaCode { get; set; }
        public static string UpdateProfileMobilePhoneFirst3 { get; set; }
        public static string UpdateProfileMobilePhoneLast4 { get; set; }
        public static string UpdateProfileFaxPhonePrefix { get; set; }
        public static string UpdateProfileFaxPhoneAreaCode { get; set; }
        public static string UpdateProfileFaxPhoneFirst3 { get; set; }
        public static string UpdateProfileFaxPhoneLast4 { get; set; }
        public static string UpdateProfileIATA { get; set; }
        public static string UpdateProfileARC { get; set; }
        public static string UpdateProfileCLIA { get; set; }
        public static string UpdateProfileTRU { get; set; }
        public static string UpdateProfileACTA { get; set; }
        public static string UpdateProfileTIDS { get; set; }
        public static string UpdateProfileTICO { get; set; }
        public static string UpdateProfileABTA { get; set; }
        public static string UpdateProfileATOL { get; set; }
        public static string UpdateProfileRetailAgency { get; set; }
        public static string UpdateProfileRemoteHomeBased { get; set; }
        public static string UpdateProfileTourOperatorWholesaler { get; set; }
        public static string UpdateProfileMeetingPlanner { get; set; }
        public static string UpdateProfileDestinationWeddingSpecialist { get; set; }
        public static string UpdateProfileAffiliation { get; set; }
        public static string UpdateProfileUpdateProfileButton { get; set; }
        public static string UpdateProfileCancel { get; set; }
        public static string UpdateProfileUpdateCompleteButton { get; set; }
        public static string UpdateProfileW9WarningPopupText { get; set; }
        public static string UpdateProfileW9WarningPopupButton { get; set; }
        #endregion[UpdateProfile]

        #region[AMRewards]
        public static string AMRRewardsEnrollMeCheckbox { get; set; }
        public static string AMRRewardsPopupAccept { get; set; }
        public static string AMRewardsPointsHistory { get; set; }
        public static string AMRewardsRulesAndRegulations { get; set; }
        public static string AMRewardsTotalPointsAvailable { get; set; }
        public static string AMRewardsTotalPointsRedeemed { get; set; }
        public static string AMRewardsTotalPointsExpiring { get; set; }

        #endregion[AMRewards]

        #region[ForgotPassword]
        public static string ForgotPasswordEmail { get; set; }
        public static string ForgotPasswordValidationMobile { get; set; }
        public static string ForgotPasswordValidationEmail { get; set; }
        public static string ForgotPasswordRecoveryQuestion { get; set; }
        public static string ForgotPasswordSubmit { get; set; }
        public static string ForgotPasswordCancel { get; set; }
        public static string ForgotPasswordRecoveryAnswer { get; set; }
        public static string ForgotPasswordNewPassword { get; set; }
        public static string ForgotPasswordNewPasswordConfirmation { get; set; }
        public static string ForgotPasswordRecoverySubmit { get; set; }
        public static string ForgotPasswordRecoveryCancel { get; set; }
        public static string ForgotPasswordLogin { get; set; }
        public static string ForgotPassword_EmailVerificationCode { get; set; }
        public static string ForgotPassword_RecoveryQuestion { get; set; }
        public static string ForgotPassword_VerificationCode { get; set; }
        public static string ForgotPassword_CatchAllMail_VerificationCode { get; set; }
        #endregion[ForgotPassword]

        #region[Account Summary]
        public static string AccountSummarySummaryBookingsTab { get; set; }
        public static string AccountSummaryPointsEarnedTab { get; set; }
        public static string AccountSummaryNotYetTraveledTable { get; set; }
        public static string AccountSummaryNotYetTraveledTab { get; set; }
        public static string AccountSummaryUnderReviewTab { get; set; }
        public static string AccountSummaryIneligibleTab { get; set; }
        public static string AccountSummaryNotYetTraveledFirstName { get; set; }
        public static string AccountSummarySummaryBookingsNotYetTraveledBookingNo { get; set; }
        public static string AccountSummarySummaryBookingsNotYetTraveledGuestFirstName { get; set; }
        public static string AccountSummarySummaryBookingsNotYetTraveledGuestLastName { get; set; }
        public static string AccountSummarySummaryBookingsNotYetTraveledResort { get; set; }
        public static string AccountSummarySummaryBookingsNotYetTraveledGuestArrivalDate { get; set; }
        public static string AccountSummarySummaryBookingsNotYetTraveledGuestDepartureDate { get; set; }
        public static string AccountSummaryNotYetTraveledSubmitBtn { get; set; }


        #endregion[Account Summary]

        #endregion[UI]

        #region[Admin]

        #region[AdminLogin]
        public static string AdminLoginEmail { get; set; }
        public static string AdminLoginPassword { get; set; }
        public static string AdminLoginForgotPassword { get; set; }
        public static string AdminLoginSignIn { get; set; }
        #endregion[AdminLogin]

        #region[AdminHome]
        public static string AdminHomeManageProfile { get; set; }
        public static string AdminHomeManageBookings { get; set; }
        public static string AdminHomeManageRedemptions { get; set; }
        #endregion[AdminHome]

        #region[AdminManageProfiles]
        public static string AdminManageProfiles_ValidatedProfiles_Tab { get; set; }
        public static string AdminManageProfiles_InActivatedProfiles_Tab { get; set; }
        public static string AdminManageProfiles_NonValidatedProfiles_Tab { get; set; }
        public static string AdminManageProfilesSearch { get; set; }
        public static string AdminManageProfiles_EditProfile { get; set; }
        public static string AdminManageProfiles_Icon_ResetPassword { get; set; }
        public static string AdminManageProfiles_ResetPassword_ResetButton { get; set; }
        public static string AdminManageProfiles_ResetPassword_ConfirmationButton { get; set; }
        public static string AdminManageProfiles_ResetPassword_CancelButton { get; set; }
        public static string AdminManageProfiles_ResetPassword_NewPassword { get; set; }
        public static string AdminManageProfiles_ResetPassword_CloseButton { get; set; }
        public static string AdminManageProfiles_ResetPassword_CloseIcon { get; set; }
        public static string AdminManageProfiles_Icon_InActivateProfile { get; set; }
        public static string AdminManageProfiles_InActivatedProfiles_Search { get; set; }
        public static string AdminManageProfiles_Icon_ReactivateProfile { get; set; }
        public static string AdminManageProfiles_ValidatedProfile_Icon_ViewProfile { get; set; }
        public static string AdminManageProfiles_ViewProfile_Icon_Close { get; set; }
        public static string AdminManageProfiles_InActivatedProfile_Icon_ViewProfile { get; set; }
        public static string AdminManageProfiles_InActivatedProfile_Icon_EditProfile { get; set; }
        public static string AdminManageProfiles_NonValidatedProfiles_Icon_EditProfile { get; set; }
        public static string AdminManageProfiles_NonValidatedProfiles_Search { get; set; }
        public static string AdminManageProfiles_NonValidatedProfiles_Icon_ViewProfile { get; set; }
        public static string AdminManageProfiles_NonValidatedProfiles_Tab_PointsHistory { get; set; }
        public static string AdminManageProfiles_ValidatedProfile_Icon_Delete { get; set; }
        public static string AdminManageProfiles_ValidatedProfile_Button_DeleteConfirm { get; set; }
        public static string AdminManageProfiles_ValidatedProfile_Button_DeleteCancel { get; set; }
        public static string AdminManageProfiles_ValidatedProfile_Button_Close { get; set; }
        #endregion[AdminManageProfiles]

        #region[AdminManageBookings]
        public static string AdminManageBookingsNotYetTraveledTab { get; set; }
        public static string AdminManageBookingsPendingValidationTab { get; set; }
        public static string AdminManageBookingsPointsEarnedTab { get; set; }
        public static string AdminManageBookingsIneligibleTab { get; set; }
        public static string AdminManageBookingsPendingValidationTabSearchbox { get; set; }
        public static string AdminManageBookings_PendingValidationTab_DeleteIcon { get; set; }
        public static string AdminManageBookings_PendingValidationTab_Button_Delete { get; set; }
        public static string AdminManageBookings_PendingValidationTab_Button_Cancel { get; set; }
        public static string AdminManageBookings_PendingValidationTab_Button_Close { get; set; }
        public static string AdminManageBookings_PendingValidationTab_Field_BookingNumber { get; set; }
        #endregion[AdminManageBookings]

        #region[AdminValidatedProfiles]
        public static string AdminValidatedProfilesEditProfile { get; set; }
        public static string AdminValidatedProfilesSearch { get; set; }
        #endregion[AdminValidatedProfiles]

        #region[AdminManageRedemptions]
        public static string AdminManageRedemptions_RedemptionsPending { get; set; }
        public static string AdminManageRedemptions_AMRRewardsApproved { get; set; }
        public static string AdminManageRedemptions_AMRRewardsReceived { get; set; }
        public static string AdminManageRedemptions_BookingBonus { get; set; }
        public static string AdminManageRedemptions_AMRRewardsReceived_Search { get; set; }
        public static string AdminManageRedemptions_AMRRewardsReceived_EditRedemption { get; set; }
        public static string AdminManageRedemptions_AMRRewardsReceived_Textbox_Firstname { get; set; }
        public static string AdminManageRedemptions_AMRRewardsReceived_Textbox_CertificateNo { get; set; }
        public static string AdminManageRedemptions_AMRRewardsReceived_Textbox_ExpirationDate { get; set; }
        public static string AdminManageRedemptions_AMRRewardsReceived_Button_ResendCertificate { get; set; }
        public static string AdminManageRedemptions_AMRRewardsReceived_RadioButton_Other { get; set; }
        public static string AdminManageRedemptions_AMRRewardsReceived_Textbox_CustomEmail { get; set; }
        public static string AdminManageRedemptions_AMRRewardsReceived_Button_Send { get; set; }
        public static string AdminManageRedemptions_AMRRewardsReceived_Button_Cancel { get; set; }
        public static string AdminManageRedemptions_AMRRewardsReceived_Button_Ok { get; set; }
        public static string AdminManageRedemptions_AMRRewardsReceived_Mail_Button_ViewandPrint { get; set; }
        public static string AdminManageRedemptions_AMRRewardsReceived_Textbox_Email { get; set; }
        #endregion[AdminManageRedemptions]

        #region[AdminEditProfile]
        public static string AdminEditProfileEmail { get; set; }
        public static string AdminEditProfileCountry { get; set; }
        public static string AdminEditProfileLanguage { get; set; }
        public static string AdminEditProfileTitle { get; set; }
        public static string AdminEditProfileFirstName { get; set; }
        public static string AdminEditProfileLastName { get; set; }
        public static string AdminEditProfileBirthdayMonth { get; set; }
        public static string AdminEditProfileBirthdayDay { get; set; }
        public static string AdminEditProfileAddress1 { get; set; }
        public static string AdminEditProfileAddress2 { get; set; }
        public static string AdminEditProfileCity { get; set; }
        public static string AdminEditProfileState { get; set; }
        public static string AdminEditProfileProvince { get; set; }
        public static string AdminEditProfileZip { get; set; }
        public static string AdminEditProfileWorkPhonePrefix { get; set; }
        public static string AdminEditProfileWorkPhoneAreaCode { get; set; }
        public static string AdminEditProfileWorkPhoneFirst3 { get; set; }
        public static string AdminEditProfileWorkPhoneLast4 { get; set; }
        public static string AdminEditProfileWorkExtension { get; set; }
        public static string AdminEditProfileHomePhonePrefix { get; set; }
        public static string AdminEditProfileHomePhoneAreaCode { get; set; }
        public static string AdminEditProfileHomePhoneFirst3 { get; set; }
        public static string AdminEditProfileHomePhoneLast4 { get; set; }
        public static string AdminEditProfileMobilePhonePrefix { get; set; }
        public static string AdminEditProfileMobilePhoneAreaCode { get; set; }
        public static string AdminEditProfileMobilePhoneFirst3 { get; set; }
        public static string AdminEditProfileMobilePhoneLast4 { get; set; }
        public static string AdminEditProfileFaxPhonePrefix { get; set; }
        public static string AdminEditProfileFaxPhoneAreaCode { get; set; }
        public static string AdminEditProfileFaxPhoneFirst3 { get; set; }
        public static string AdminEditProfileFaxPhoneLast4 { get; set; }
        public static string AdminEditProfileIATA { get; set; }
        public static string AdminEditProfileARC { get; set; }
        public static string AdminEditProfileCLIA { get; set; }
        public static string AdminEditProfileTRU { get; set; }
        public static string AdminEditProfileACTA { get; set; }
        public static string AdminEditProfileTIDS { get; set; }
        public static string AdminEditProfileTICO { get; set; }
        public static string AdminEditProfileABTA { get; set; }
        public static string AdminEditProfileATOL { get; set; }
        public static string AdminEditProfileRetailAgency { get; set; }
        public static string AdminEditProfileRemoteHomeBased { get; set; }
        public static string AdminEditProfileTourOperatorWholesaler { get; set; }
        public static string AdminEditProfileMeetingPlanner { get; set; }
        public static string AdminEditProfileDestinationWeddingSpecialist { get; set; }
        public static string AdminEditProfileAffiliation { get; set; }
        public static string AdminEditProfileAdminEditProfileButton { get; set; }
        public static string AdminEditProfileCancel { get; set; }
        public static string AdminEditProfileMergeProfile { get; set; }
        public static string AdminEditProfileUploadPhoto { get; set; }
        public static string AdminEditProfileUploadAgencyLogo { get; set; }
        public static string AdminEditProfileW9 { get; set; }
        public static string AdminEditProfileUpdateCompleteButton { get; set; }

        #endregion[AdminEditProfile]

        #endregion[Admin]

        public static ObjectRepository ReadElement(string location, string nodeModule)
        {
            ObjectRepository obj = new ObjectRepository();
            XDocument doc = XDocument.Load(location);
            var query = doc.Descendants(nodeModule).Elements().ToDictionary(x => x.Attribute("key").Value, x => x.Value);

             foreach (KeyValuePair<string, string> pair in query)
                {

                    #region[UI]

                    #region[Login]

                    if (nodeModule == Constants.ModuleLogin)
                    {
                        if (pair.Key == "Login_Email")
                        {
                            LoginEmail = pair.Value;
                        }
                        else if (pair.Key == "Login_Password")
                        {
                            LoginPassword = pair.Value;
                        }
                        else if (pair.Key == "Login_SignIn")
                        {
                            LoginSignIn = pair.Value;
                        }
                        else if (pair.Key == "Login_ForgotPassword")
                        {
                            LoginForgotPassword = pair.Value;
                        }
                        else if (pair.Key == "Login_RegisterNow")
                        {
                            LoginRegisterNow = pair.Value;
                        }
                        else if (pair.Key == "Login_AcceptConsentToCookies")
                        {
                            Login_AcceptConsentToCookies = pair.Value;
                        }
                        else if (pair.Key == "Login_Close")
                        {
                            Login_Close = pair.Value;
                        }
                    }
                    #endregion[Login]

                    #region[Register]

                    if (nodeModule == Constants.ModuleRegistration)
                    {
                        if (pair.Key == "Register_Email")
                        {
                            RegisterEmail = pair.Value;
                        }
                        else if (pair.Key == "Register_ConfirmEmail")
                        {
                            RegisterConfirmEmail = pair.Value;
                        }
                        else if (pair.Key == "Register_Password")
                        {
                            RegisterPassword = pair.Value;
                        }
                        else if (pair.Key == "Register_ConfirmPassword")
                        {
                            RegisterConfirmPassword = pair.Value;
                        }
                        else if (pair.Key == "Register_SecurityQuestion")
                        {
                            RegisterSecurityQuestion = pair.Value;
                        }
                        else if (pair.Key == "Register_SecurityAnswer")
                        {
                            RegisterSecurityAnswer = pair.Value;
                        }
                        else if (pair.Key == "Register_Country")
                        {
                            RegisterCountry = pair.Value;
                        }
                        else if (pair.Key == "Register_Language")
                        {
                            RegisterLanguage = pair.Value;
                        }
                        else if (pair.Key == "Register_Title")
                        {
                            RegisterTitle = pair.Value;
                        }
                        else if (pair.Key == "Register_FirstName")
                        {
                            RegisterFirstName = pair.Value;
                        }
                        else if (pair.Key == "Register_LastName")
                        {
                            RegisterLastName = pair.Value;
                        }
                        else if (pair.Key == "Register_BirthdayMonth")
                        {
                            RegisterBirthdayMonth = pair.Value;
                        }
                        else if (pair.Key == "Register_BirthdayDay")
                        {
                            RegisterBirthdayDay = pair.Value;
                        }
                        else if (pair.Key == "Register_Address1")
                        {
                            RegisterAddress1 = pair.Value;
                        }
                        else if (pair.Key == "Register_Address2")
                        {
                            RegisterAddress2 = pair.Value;
                        }
                        else if (pair.Key == "Register_City")
                        {
                            RegisterCity = pair.Value;
                        }
                        else if (pair.Key == "Register_State")
                        {
                            RegisterState = pair.Value;
                        }
                        else if (pair.Key == "Register_Province")
                        {
                            RegisterProvince = pair.Value;
                        }
                        else if (pair.Key == "Register_Zip")
                        {
                            RegisterZip = pair.Value;
                        }
                        else if (pair.Key == "Register_WorkPhonePrefix")
                        {
                            RegisterWorkPhonePrefix = pair.Value;
                        }
                        else if (pair.Key == "Register_WorkPhoneAreaCode")
                        {
                            RegisterWorkPhoneAreaCode = pair.Value;
                        }
                        else if (pair.Key == "Register_WorkPhoneFirst3")
                        {
                            RegisterWorkPhoneFirst3 = pair.Value;
                        }
                        else if (pair.Key == "Register_WorkPhoneLast4")
                        {
                            RegisterWorkPhoneLast4 = pair.Value;
                        }
                        else if (pair.Key == "Register_WorkExtension")
                        {
                            RegisterWorkExtension = pair.Value;
                        }
                        else if (pair.Key == "Register_HomePhonePrefix")
                        {
                            RegisterHomePhonePrefix = pair.Value;
                        }
                        else if (pair.Key == "Register_HomePhoneAreaCode")
                        {
                            RegisterHomePhoneAreaCode = pair.Value;
                        }
                        else if (pair.Key == "Register_HomePhoneFirst3")
                        {
                            RegisterHomePhoneFirst3 = pair.Value;
                        }
                        else if (pair.Key == "Register_HomePhoneLast4")
                        {
                            RegisterHomePhoneLast4 = pair.Value;
                        }
                        else if (pair.Key == "Register_MobilePhonePrefix")
                        {
                            RegisterMobilePhonePrefix = pair.Value;
                        }
                        else if (pair.Key == "Register_MobilePhoneAreaCode")
                        {
                            RegisterMobilePhoneAreaCode = pair.Value;
                        }
                        else if (pair.Key == "Register_MobilePhoneFirst3")
                        {
                            RegisterMobilePhoneFirst3 = pair.Value;
                        }
                        else if (pair.Key == "Register_MobilePhoneLast4")
                        {
                            RegisterMobilePhoneLast4 = pair.Value;
                        }
                        else if (pair.Key == "Register_FaxPhonePrefix")
                        {
                            RegisterFaxPhonePrefix = pair.Value;
                        }
                        else if (pair.Key == "Register_FaxPhoneAreaCode")
                        {
                            RegisterFaxPhoneAreaCode = pair.Value;
                        }
                        else if (pair.Key == "Register_FaxPhoneFirst3")
                        {
                            RegisterFaxPhoneFirst3 = pair.Value;
                        }
                        else if (pair.Key == "Register_FaxPhoneLast4")
                        {
                            RegisterFaxPhoneLast4 = pair.Value;
                        }
                        else if (pair.Key == "Register_IATA")
                        {
                            RegisterIATA = pair.Value;
                        }
                        else if (pair.Key == "Register_ARC")
                        {
                            RegisterARC = pair.Value;
                        }
                        else if (pair.Key == "Register_CLIA")
                        {
                            RegisterCLIA = pair.Value;
                        }
                        else if (pair.Key == "Register_TRU")
                        {
                            RegisterTRU = pair.Value;
                        }
                        else if (pair.Key == "Register_ACTA")
                        {
                            RegisterACTA = pair.Value;
                        }
                        else if (pair.Key == "Register_TIDS")
                        {
                            RegisterTIDS = pair.Value;
                        }
                        else if (pair.Key == "Register_TICO")
                        {
                            RegisterTICO = pair.Value;
                        }
                        else if (pair.Key == "Register_ABTA")
                        {
                            RegisterABTA = pair.Value;
                        }
                        else if (pair.Key == "Register_ATOL")
                        {
                            RegisterATOL = pair.Value;
                        }
                        else if (pair.Key == "Register_RetailAgency")
                        {
                            RegisterRetailAgency = pair.Value;
                        }
                        else if (pair.Key == "Register_RemoteHomeBased")
                        {
                            RegisterRemoteHomeBased = pair.Value;
                        }
                        else if (pair.Key == "Register_TourOperatorWholesaler")
                        {
                            RegisterTourOperatorWholesaler = pair.Value;
                        }
                        else if (pair.Key == "Register_MeetingPlanner")
                        {
                            RegisterMeetingPlanner = pair.Value;
                        }
                        else if (pair.Key == "Register_DestinationWeddingSpecialist")
                        {
                            RegisterDestinationWeddingSpecialist = pair.Value;
                        }
                        else if (pair.Key == "Register_Affiliation")
                        {
                            RegisterAffiliation = pair.Value;
                        }
                        else if (pair.Key == "Register_RegisterButton")
                        {
                            RegisterRegisterButton = pair.Value;
                        }
                        else if (pair.Key == "Register_Cancel")
                        {
                            RegisterCancel = pair.Value;
                        }
                        else if (pair.Key == "Register_RegistrationCompleteButton")
                        {
                            RegisterRegistrationCompleteButton = pair.Value;
                        }
                        else if (pair.Key == "Register_RegistrationEnroll_Me")
                        {
                            Register_RegistrationEnroll_Me = pair.Value;
                        }
                        else if (pair.Key == "Register_RegistrationAccept")
                        {
                            Register_RegistrationAccept = pair.Value;
                        }
                        else if (pair.Key == "Register_AddressSuggestionPopup_ClickYes")
                        {
                            Register_AddressSuggestionPopup_ClickYes = pair.Value;
                        }
                    }
                    #endregion[Register]

                    #region[AMRAgents]

                    if (nodeModule == Constants.ModuleAMRAgentsNav)
                    {
                        if (pair.Key == "AMRAgents_Home")
                        {
                            AMRAgentsHome = pair.Value;
                        }
                        else if (pair.Key == "AMRAgents_BookNow")
                        {
                            AMRAgentsBookNow = pair.Value;
                        }
                        else if (pair.Key == "AMRAgents_GDSCodes")
                        {
                            AMRAgentsGDSCodes = pair.Value;
                        }
                        else if (pair.Key == "AMRAgents_AMRewards")
                        {
                            AMRAgentsAMRewards = pair.Value;
                        }
                        else if (pair.Key == "AMRAgents_UpdateProfile")
                        {
                            AMRAgentsUpdateProfile = pair.Value;
                        }
                        else if (pair.Key == "AMRAgents_LogOff")
                        {
                            AMRAgentsLogOff = pair.Value;
                        }
                        else if (pair.Key == "AMRAgents_AccountSummary")
                        {
                            AMRAgentsAccountSummary = pair.Value;
                        }
                        else if (pair.Key == "AMRAgents_MyRedemptions")
                        {
                            AMRAgentsMyRedemptions = pair.Value;
                        }
                        else if (pair.Key == "AMRAgents_SubmitBooking")
                        {
                            AMRAgentsSubmitBooking = pair.Value;
                        }

                    }
                    #endregion[AMRAgents]

                    #region[UpdateProfile]

                    if (nodeModule == Constants.ModuleUpdateProfile)
                    {
                        if (pair.Key == "UpdateProfile_Email")
                        {
                            UpdateProfileEmail = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_ConfirmEmail")
                        {
                            UpdateProfileConfirmEmail = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_SecurityQuestion")
                        {
                            UpdateProfileSecurityQuestion = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_SecurityAnswer")
                        {
                            UpdateProfileSecurityAnswer = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_Country")
                        {
                            UpdateProfileCountry = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_Language")
                        {
                            UpdateProfileLanguage = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_Title")
                        {
                            UpdateProfileTitle = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_FirstName")
                        {
                            UpdateProfileFirstName = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_LastName")
                        {
                            UpdateProfileLastName = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_BirthdayMonth")
                        {
                            UpdateProfileBirthdayMonth = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_BirthdayDay")
                        {
                            UpdateProfileBirthdayDay = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_Address1")
                        {
                            UpdateProfileAddress1 = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_Address2")
                        {
                            UpdateProfileAddress2 = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_City")
                        {
                            UpdateProfileCity = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_State")
                        {
                            UpdateProfileState = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_Province")
                        {
                            UpdateProfileProvince = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_Zip")
                        {
                            UpdateProfileZip = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_WorkPhonePrefix")
                        {
                            UpdateProfileWorkPhonePrefix = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_WorkPhoneAreaCode")
                        {
                            UpdateProfileWorkPhoneAreaCode = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_WorkPhoneFirst3")
                        {
                            UpdateProfileWorkPhoneFirst3 = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_WorkPhoneLast4")
                        {
                            UpdateProfileWorkPhoneLast4 = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_WorkExtension")
                        {
                            UpdateProfileWorkExtension = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_HomePhonePrefix")
                        {
                            UpdateProfileHomePhonePrefix = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_HomePhoneAreaCode")
                        {
                            UpdateProfileHomePhoneAreaCode = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_HomePhoneFirst3")
                        {
                            UpdateProfileHomePhoneFirst3 = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_HomePhoneLast4")
                        {
                            UpdateProfileHomePhoneLast4 = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_MobilePhonePrefix")
                        {
                            UpdateProfileMobilePhonePrefix = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_MobilePhoneAreaCode")
                        {
                            UpdateProfileMobilePhoneAreaCode = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_MobilePhoneFirst3")
                        {
                            UpdateProfileMobilePhoneFirst3 = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_MobilePhoneLast4")
                        {
                            UpdateProfileMobilePhoneLast4 = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_FaxPhonePrefix")
                        {
                            UpdateProfileFaxPhonePrefix = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_FaxPhoneAreaCode")
                        {
                            UpdateProfileFaxPhoneAreaCode = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_FaxPhoneFirst3")
                        {
                            UpdateProfileFaxPhoneFirst3 = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_FaxPhoneLast4")
                        {
                            UpdateProfileFaxPhoneLast4 = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_IATA")
                        {
                            UpdateProfileIATA = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_ARC")
                        {
                            UpdateProfileARC = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_CLIA")
                        {
                            UpdateProfileCLIA = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_TRU")
                        {
                            UpdateProfileTRU = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_ACTA")
                        {
                            UpdateProfileACTA = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_TIDS")
                        {
                            UpdateProfileTIDS = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_TICO")
                        {
                            UpdateProfileTICO = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_ABTA")
                        {
                            UpdateProfileABTA = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_ATOL")
                        {
                            UpdateProfileATOL = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_RetailAgency")
                        {
                            UpdateProfileRetailAgency = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_RemoteHomeBased")
                        {
                            UpdateProfileRemoteHomeBased = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_TourOperatorWholesaler")
                        {
                            UpdateProfileTourOperatorWholesaler = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_MeetingPlanner")
                        {
                            UpdateProfileMeetingPlanner = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_DestinationWeddingSpecialist")
                        {
                            UpdateProfileDestinationWeddingSpecialist = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_Affiliation")
                        {
                            UpdateProfileAffiliation = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_UpdateProfileButton")
                        {
                            UpdateProfileUpdateProfileButton = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_Cancel")
                        {
                            UpdateProfileCancel = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfile_UpdateCompleteButton") 
                        {
                            UpdateProfileUpdateCompleteButton = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfileW9WarningPopupButton")
                        {
                            UpdateProfileW9WarningPopupButton = pair.Value;
                        }
                        else if (pair.Key == "UpdateProfileW9WarningPopupText")
                        {
                            UpdateProfileW9WarningPopupText = pair.Value;
                        }

                }
                    #endregion[UpdateProfile]

                    #region[AMRewards]

                    if (nodeModule == Constants.ModuleAMRewards)
                    {
                        if (pair.Key == "AMRRewards_EnrollMeCheckbox")
                        {
                            AMRRewardsEnrollMeCheckbox = pair.Value;
                        }
                        else if (pair.Key == "AMRRewards_PopupAccept")
                        {
                            AMRRewardsPopupAccept = pair.Value;
                        }
                        else if (pair.Key == "AMRewards_PointsHistory")
                        {
                            AMRewardsPointsHistory = pair.Value;
                        }
                        else if (pair.Key == "AMRewards_RulesAndRegulations")
                        {
                            AMRewardsRulesAndRegulations = pair.Value;
                        }
                        else if (pair.Key == "AMRewards_TotalPointsAvailable")
                        {
                            AMRewardsTotalPointsAvailable = pair.Value;
                        }
                        else if (pair.Key == "AMRewards_TotalPointsRedeemed")
                        {
                            AMRewardsTotalPointsRedeemed = pair.Value;
                        }
                        else if (pair.Key == "AMRewards_TotalPointsExpiring")
                        {
                            AMRewardsTotalPointsExpiring = pair.Value;
                        }

                    }

                    #endregion[AMRewards]

                    #region[Forgot Password]

                    if (nodeModule == Constants.ModuleForgotPassword)
                    {
                        if (pair.Key == "ForgotPassword_Email")
                        {
                            ForgotPasswordEmail = pair.Value;
                        }
                        else if (pair.Key == "ForgotPassword_ValidationMobile")
                        {
                            ForgotPasswordValidationMobile = pair.Value;
                        }
                        else if (pair.Key == "ForgotPassword_ValidationEmail")
                        {
                            ForgotPasswordValidationEmail = pair.Value;
                        }
                        else if (pair.Key == "ForgotPassword_RecoveryQuestion")
                        {
                            ForgotPasswordRecoveryQuestion = pair.Value;
                        }
                        else if (pair.Key == "ForgotPassword_Submit")
                        {
                            ForgotPasswordSubmit = pair.Value;
                        }
                        else if (pair.Key == "ForgotPassword_Cancel")
                        {
                            ForgotPasswordCancel = pair.Value;
                        }
                        else if (pair.Key == "ForgotPassword_RecoveryAnswer")
                        {
                            ForgotPasswordRecoveryAnswer = pair.Value;
                        }
                        else if (pair.Key == "ForgotPassword_NewPassword")
                        {
                            ForgotPasswordNewPassword = pair.Value;
                        }
                        else if (pair.Key == "ForgotPassword_NewPasswordConfirmation")
                        {
                            ForgotPasswordNewPasswordConfirmation = pair.Value;
                        }
                        else if (pair.Key == "ForgotPassword_RecoverySubmit")
                        {
                            ForgotPasswordRecoverySubmit = pair.Value;
                        }
                        else if (pair.Key == "ForgotPassword_RecoveryCancel")
                        {
                            ForgotPasswordRecoveryCancel = pair.Value;
                        }
                        else if (pair.Key == "ForgotPassword_Login")
                        {
                            ForgotPasswordLogin = pair.Value;
                        }
                        else if (pair.Key == "ForgotPassword_Email_VerificationCode")
                        {
                            ForgotPassword_EmailVerificationCode = pair.Value;
                        }
                        else if (pair.Key == "ForgotPassword_RecoveryQuestion")
                        {
                            ForgotPassword_RecoveryQuestion = pair.Value;
                        }
                        else if (pair.Key == "ForgotPassword_VerificationCode")
                        {
                            ForgotPassword_VerificationCode = pair.Value;
                        }
                        else if (pair.Key == "ForgotPassword_CatchAllMail_VerificationCode")
                        {
                            ForgotPassword_CatchAllMail_VerificationCode = pair.Value;
                        }


                    }
                    #endregion[Forgot Password]

                    #region[Submit Booking]

                    if (nodeModule == Constants.ModuleSubmitBooking)
                    {
                        if (pair.Key == "SubmitBooking_IndividualRadioButton")
                        {
                            SubmitBookingIndividualRadioButton = pair.Value;
                        }
                        else if (pair.Key == "SubmitBooking_GroupTypeRadioButton")
                        {
                            SubmitBookingGroupTypeRadioButton = pair.Value;
                        }
                        else if (pair.Key == "SubmitBooking_GroupTypeDropDown")
                        {
                            SubmitBookingGroupTypeDropDown = pair.Value;
                        }
                        else if (pair.Key == "SubmitBooking_NumOfRooms")
                        {
                            SubmitBookingNumOfRooms = pair.Value;
                        }
                        else if (pair.Key == "SubmitBooking_SetGroupButton")
                        {
                            SubmitBookingSetGroupButton = pair.Value;
                        }
                        else if (pair.Key == "SubmitBooking_GroupName")
                        {
                            SubmitBookingGroupName = pair.Value;
                        }
                        else if (pair.Key == "SubmitBooking_RoomNumber")
                        {
                            SubmitBookingRoomNumber = pair.Value;
                        }
                        else if (pair.Key == "SubmitBooking_BookingMadeWith")
                        {
                            SubmitBookingBookingMadeWith = pair.Value;
                        }
                        else if (pair.Key == "SubmitBooking_BookingNumber")
                        {
                            SubmitBookingBookingNumber = pair.Value;
                        }
                        else if (pair.Key == "SubmitBooking_GuestFirstName")
                        {
                            SubmitBookingGuestFirstName = pair.Value;
                        }
                        else if (pair.Key == "SubmitBooking_GuestLastName")
                        {
                            SubmitBookingGuestLastName = pair.Value;
                        }
                        else if (pair.Key == "SubmitBooking_DateBooked")
                        {
                            SubmitBookingDateBooked = pair.Value;
                        }
                        else if (pair.Key == "SubmitBooking_TravelStartDate")
                        {
                            SubmitBookingTravelStartDate = pair.Value;
                        }
                        else if (pair.Key == "SubmitBooking_TravelEndDate")
                        {
                            SubmitBookingTravelEndDate = pair.Value;
                        }
                        else if (pair.Key == "SubmitBooking_Brand")
                        {
                            SubmitBookingBrand = pair.Value;
                        }
                        else if (pair.Key == "SubmitBooking_Resort")
                        {
                            SubmitBookingResort = pair.Value;
                        }
                        else if (pair.Key == "SubmitBooking_DepartureGateway1")
                        {
                            SubmitBookingDepartureGateway1 = pair.Value;
                        }
                        else if (pair.Key == "SubmitBooking_DepartureGateway")
                        {
                            SubmitBookingDepartureGateway = pair.Value;
                        }
                        else if (pair.Key == "SubmitBooking_AddToBookingSummary")
                        {
                            SubmitBookingAddToBookingSummary = pair.Value;
                        }
                        else if (pair.Key == "SubmitBooking_Clear")
                        {
                            SubmitBookingClear = pair.Value;
                        }
                        else if (pair.Key == "SelectBooking")
                        {
                            SelectBooking = pair.Value;
                        }
                        else if (pair.Key == "SubmitBooking_Submit")
                        {
                            SubmitBookingSubmit = pair.Value;
                        }
                        else if (pair.Key == "SubmitBooking_PopupOKBtn")
                        {
                            SubmitBookingPopupOKBtn = pair.Value;
                        }
                        else if (pair.Key == "SubmitBookingSubmitPopupOKBtn")
                        {
                            SubmitBookingSubmitPopupOKBtn = pair.Value;
                        }

                        else if (pair.Key == "SubmitBooking_DatePickerMonth")
                        {
                            SubmitBookingDatePickerMonth = pair.Value;
                        }
                        else if (pair.Key == "SubmitBooking_DatePickerYear")
                        {
                            SubmitBookingDatePickerYear = pair.Value;
                        }

                    }
                    #endregion[Submit Booking]

                    #region[Account Summary]

                    if (nodeModule == Constants.ModuleAccountSummary)
                    {
                        if (pair.Key == "AccountSummary_SummaryBookingsTab")
                        {
                            AccountSummarySummaryBookingsTab = pair.Value;
                        }
                        else if (pair.Key == "AccountSummary_PointsEarnedTab")
                        {
                            AccountSummaryPointsEarnedTab = pair.Value;
                        }
                        else if (pair.Key == "AccountSummaryNotYetTraveledTable")
                        {
                            AccountSummaryNotYetTraveledTable = pair.Value;
                        }
                        else if (pair.Key == "AccountSummary_NotYetTraveledTab")
                        {
                            AccountSummaryNotYetTraveledTab = pair.Value;
                        }
                        else if (pair.Key == "AccountSummary_UnderReviewTab")
                        {
                            AccountSummaryUnderReviewTab = pair.Value;
                        }
                        else if (pair.Key == "AccountSummary_IneligibleTab")
                        {
                            AccountSummaryIneligibleTab = pair.Value;
                        }
                        else if (pair.Key == "AccountSummary_NotYetTraveled_FirstName")
                        {
                            AccountSummaryNotYetTraveledFirstName = pair.Value;
                        }
                        else if (pair.Key == "AccountSummary_SummaryBookings_NotYetTraveled_BookingNo")
                        {
                            AccountSummarySummaryBookingsNotYetTraveledBookingNo = pair.Value;
                        }
                        else if (pair.Key == "AccountSummary_SummaryBookings_NotYetTraveled_GuestFirstName")
                        {
                            AccountSummarySummaryBookingsNotYetTraveledGuestFirstName = pair.Value;
                        }
                        else if (pair.Key == "AccountSummary_SummaryBookings_NotYetTraveled_GuestLastName")
                        {
                            AccountSummarySummaryBookingsNotYetTraveledGuestLastName = pair.Value;
                        }
                        else if (pair.Key == "AccountSummary_SummaryBookings_NotYetTraveled_Resort")
                        {
                            AccountSummarySummaryBookingsNotYetTraveledResort = pair.Value;
                        }
                        else if (pair.Key == "AccountSummary_SummaryBookings_NotYetTraveled_GuestArrivalDate")
                        {
                            AccountSummarySummaryBookingsNotYetTraveledGuestArrivalDate = pair.Value;
                        }
                        else if (pair.Key == "AccountSummary_SummaryBookings_NotYetTraveled_GuestDepartureDate")
                        {
                            AccountSummarySummaryBookingsNotYetTraveledGuestDepartureDate = pair.Value;
                        }
                        else if (pair.Key == "AccountSummary_NotYetTraveled_SubmitBtn")
                        {
                            AccountSummaryNotYetTraveledSubmitBtn = pair.Value;
                        }


                    }

                    #endregion[Account Summary]

                    #endregion[UI]

                    #region[Admin]

                    #region[AdminLogin]
                    if (nodeModule == Constants.ModuleAdminLogin)
                    {
                        if (pair.Key == "AdminLogin_Email")
                        {
                            AdminLoginEmail = pair.Value;
                        }
                        else if (pair.Key == "AdminLogin_Password")
                        {
                            AdminLoginPassword = pair.Value;
                        }
                        else if (pair.Key == "AdminLogin_ForgotPassword")
                        {
                            AdminLoginForgotPassword = pair.Value;
                        }
                        else if (pair.Key == "AdminLogin_SignIn")
                        {
                            AdminLoginSignIn = pair.Value;
                        }

                    }
                    #endregion[AdminLogin]

                    #region[AdminHome]
                    if (nodeModule == Constants.ModuleAdminHome)
                    {
                        if (pair.Key == "AdminHome_ManageProfile")
                        {
                            AdminHomeManageProfile = pair.Value;
                        }
                        else if (pair.Key == "AdminHome_ManageBookings")
                        {
                            AdminHomeManageBookings = pair.Value;
                        }
                        else if (pair.Key == "AdminHome_ManageRedemptions")
                        {
                            AdminHomeManageRedemptions = pair.Value;
                        }

                    }
                    #endregion[AdminHome]

                    #region[AdminManageProfiles]
                    if (nodeModule == Constants.ModuleAdminManageProfiles)
                    {
                        if (pair.Key == "AdminManageProfiles_ValidatedProfiles_Tab")
                            AdminManageProfiles_ValidatedProfiles_Tab = pair.Value;
                        else if (pair.Key == "AdminManageProfiles_InActivatedProfiles_Tab")
                            AdminManageProfiles_InActivatedProfiles_Tab = pair.Value;
                        else if (pair.Key == "AdminManageProfiles_Search")
                            AdminManageProfilesSearch = pair.Value;
                        else if (pair.Key == "AdminManageProfiles_EditProfile")
                            AdminManageProfiles_EditProfile = pair.Value;
                        else if (pair.Key == "AdminManageProfiles_Icon_ResetPassword")
                            AdminManageProfiles_Icon_ResetPassword = pair.Value;
                        else if (pair.Key == "AdminManageProfiles_ResetPassword_ResetButton")
                            AdminManageProfiles_ResetPassword_ResetButton = pair.Value;
                        else if (pair.Key == "AdminManageProfiles_ResetPassword_ConfirmationButton")
                            AdminManageProfiles_ResetPassword_ConfirmationButton = pair.Value;
                        else if (pair.Key == "AdminManageProfiles_ResetPassword_CancelButton")
                            AdminManageProfiles_ResetPassword_CancelButton = pair.Value;
                        else if (pair.Key == "AdminManageProfiles_ResetPassword_NewPassword")
                            AdminManageProfiles_ResetPassword_NewPassword = pair.Value;
                        else if (pair.Key == "AdminManageProfiles_ResetPassword_CloseButton")
                            AdminManageProfiles_ResetPassword_CloseButton = pair.Value;
                        else if (pair.Key == "AdminManageProfiles_ResetPassword_CloseIcon")
                            AdminManageProfiles_ResetPassword_CloseIcon = pair.Value;
                        else if (pair.Key == "AdminManageProfiles_Icon_InActivateProfile")
                            AdminManageProfiles_Icon_InActivateProfile = pair.Value;
                        else if (pair.Key == "AdminManageProfiles_InActivatedProfiles_Search")
                            AdminManageProfiles_InActivatedProfiles_Search = pair.Value;
                        else if (pair.Key == "AdminManageProfiles_Icon_ReactivateProfile")
                            AdminManageProfiles_Icon_ReactivateProfile = pair.Value;
                        else if (pair.Key == "AdminManageProfiles_ValidatedProfile_Icon_ViewProfile")
                            AdminManageProfiles_ValidatedProfile_Icon_ViewProfile = pair.Value;
                        else if (pair.Key == "AdminManageProfiles_ViewProfile_Icon_Close")
                            AdminManageProfiles_ViewProfile_Icon_Close = pair.Value;
                        else if (pair.Key == "AdminManageProfiles_InActivatedProfile_Icon_ViewProfile")
                            AdminManageProfiles_InActivatedProfile_Icon_ViewProfile = pair.Value;
                        else if (pair.Key == "AdminManageProfiles_InActivatedProfile_Icon_EditProfile")
                            AdminManageProfiles_InActivatedProfile_Icon_EditProfile = pair.Value;
                        else if (pair.Key == "AdminManageProfiles_NonValidatedProfiles_Tab")
                            AdminManageProfiles_NonValidatedProfiles_Tab = pair.Value;
                        else if (pair.Key == "AdminManageProfiles_NonValidatedProfiles_Icon_EditProfile")
                            AdminManageProfiles_NonValidatedProfiles_Icon_EditProfile = pair.Value;
                        else if (pair.Key == "AdminManageProfiles_NonValidatedProfiles_Search")
                            AdminManageProfiles_NonValidatedProfiles_Search = pair.Value;
                        else if (pair.Key == "AdminManageProfiles_NonValidatedProfiles_Icon_ViewProfile")
                            AdminManageProfiles_NonValidatedProfiles_Icon_ViewProfile = pair.Value;
                        else if (pair.Key == "AdminManageProfiles_NonValidatedProfiles_Tab_PointsHistory")
                            AdminManageProfiles_NonValidatedProfiles_Tab_PointsHistory = pair.Value;
                        else if (pair.Key == "AdminManageProfiles_ValidatedProfile_Icon_Delete")
                            AdminManageProfiles_ValidatedProfile_Icon_Delete = pair.Value;
                        else if (pair.Key == "AdminManageProfiles_ValidatedProfile_Button_DeleteConfirm")
                            AdminManageProfiles_ValidatedProfile_Button_DeleteConfirm = pair.Value;
                        else if (pair.Key == "AdminManageProfiles_ValidatedProfile_Button_DeleteCancel")
                            AdminManageProfiles_ValidatedProfile_Button_DeleteCancel = pair.Value;
                        else if (pair.Key == "AdminManageProfiles_ValidatedProfile_Button_Close")
                            AdminManageProfiles_ValidatedProfile_Button_Close = pair.Value;
                    }
                    #endregion[AdminManageProfiles]

                    #region[AdminManageBookings]

                    if (nodeModule == Constants.ModuleAdminManageBookings)
                    {
                        if (pair.Key == "AdminManageBookings_NotYetTraveledTab")
                            AdminManageBookingsNotYetTraveledTab = pair.Value;
                        else if (pair.Key == "AdminManageBookings_PendingValidationTab")
                            AdminManageBookingsPendingValidationTab = pair.Value;
                        else if (pair.Key == "AdminManageBookings_PointsEarnedTab")
                            AdminManageBookingsPointsEarnedTab = pair.Value;
                        else if (pair.Key == "AdminManageBookings_IneligibleTab")
                            AdminManageBookingsIneligibleTab = pair.Value;
                        else if (pair.Key == "AdminManageBookings_PendingValidationTab_Searchbox")
                            AdminManageBookingsPendingValidationTabSearchbox = pair.Value;
                        else if (pair.Key == "AdminManageBookings_PendingValidationTab_DeleteIcon")
                            AdminManageBookings_PendingValidationTab_DeleteIcon = pair.Value;
                        else if (pair.Key == "AdminManageBookings_PendingValidationTab_Button_Delete")
                            AdminManageBookings_PendingValidationTab_Button_Delete = pair.Value;
                        else if (pair.Key == "AdminManageBookings_PendingValidationTab_Button_Cancel")
                            AdminManageBookings_PendingValidationTab_Button_Cancel = pair.Value;
                        else if (pair.Key == "AdminManageBookings_PendingValidationTab_Button_Close")
                            AdminManageBookings_PendingValidationTab_Button_Close = pair.Value;
                        else if (pair.Key == "AdminManageBookings_PendingValidationTab_Field_BookingNumber")
                            AdminManageBookings_PendingValidationTab_Field_BookingNumber = pair.Value;
                    }

                    #endregion[AdminManageBookings]

                    #region[AdminValidatedProfiles]
                    if (nodeModule == Constants.ModuleAdminValidatedProfiles)
                    {
                        if (pair.Key == "AdminValidatedProfilesEditProfile")
                        {
                            AdminValidatedProfilesEditProfile = pair.Value;
                        }
                        else if (pair.Key == "AdminValidatedProfiles_Search")
                        {
                            AdminValidatedProfilesSearch = pair.Value;
                        }



                    }
                    #endregion[AdminValidatedProfiles]

                    #region[ModuleAdminManageRedemptions]
                    if (nodeModule == Constants.ModuleAdminManageRedemptions)
                    {
                        if (pair.Key == "AdminManageRedemptions_RedemptionsPending")
                        {
                            AdminManageRedemptions_RedemptionsPending = pair.Value;
                        }
                        else if (pair.Key == "AdminManageRedemptions_AMRRewardsApproved")
                        {
                            AdminManageRedemptions_AMRRewardsApproved = pair.Value;
                        }
                        else if (pair.Key == "AdminManageRedemptions_AMRRewardsReceived")
                        {
                            AdminManageRedemptions_AMRRewardsReceived = pair.Value;
                        }
                        else if (pair.Key == "AdminManageRedemptions_BookingBonus")
                        {
                            AdminManageRedemptions_BookingBonus = pair.Value;
                        }
                        else if (pair.Key == "AdminManageRedemptions_AMRRewardsReceived_Search")
                        {
                            AdminManageRedemptions_AMRRewardsReceived_Search = pair.Value;
                        }
                        else if (pair.Key == "AdminManageRedemptions_AMRRewardsReceived_EditRedemption")
                        {
                            AdminManageRedemptions_AMRRewardsReceived_EditRedemption = pair.Value;
                        }
                        else if (pair.Key == "AdminManageRedemptions_AMRRewardsReceived_Textbox_Firstname")
                        {
                            AdminManageRedemptions_AMRRewardsReceived_Textbox_Firstname = pair.Value;
                        }
                        else if (pair.Key == "AdminManageRedemptions_AMRRewardsReceived_Textbox_CertificateNo")
                        {
                            AdminManageRedemptions_AMRRewardsReceived_Textbox_CertificateNo = pair.Value;
                        }
                        else if (pair.Key == "AdminManageRedemptions_AMRRewardsReceived_Textbox_ExpirationDate")
                        {
                            AdminManageRedemptions_AMRRewardsReceived_Textbox_ExpirationDate = pair.Value;
                        }
                        else if (pair.Key == "AdminManageRedemptions_AMRRewardsReceived_Button_ResendCertificate")
                        {
                            AdminManageRedemptions_AMRRewardsReceived_Button_ResendCertificate = pair.Value;
                        }
                        else if (pair.Key == "AdminManageRedemptions_AMRRewardsReceived_RadioButton_Other")
                        {
                            AdminManageRedemptions_AMRRewardsReceived_RadioButton_Other = pair.Value;
                        }
                        else if (pair.Key == "AdminManageRedemptions_AMRRewardsReceived_Textbox_CustomEmail")
                        {
                            AdminManageRedemptions_AMRRewardsReceived_Textbox_CustomEmail = pair.Value;
                        }
                        else if (pair.Key == "AdminManageRedemptions_AMRRewardsReceived_Button_Send")
                        {
                            AdminManageRedemptions_AMRRewardsReceived_Button_Send = pair.Value;
                        }
                        else if (pair.Key == "AdminManageRedemptions_AMRRewardsReceived_Button_Cancel")
                        {
                            AdminManageRedemptions_AMRRewardsReceived_Button_Cancel = pair.Value;
                        }
                        else if (pair.Key == "AdminManageRedemptions_AMRRewardsReceived_Button_Ok")
                        {
                            AdminManageRedemptions_AMRRewardsReceived_Button_Ok = pair.Value;
                        }
                        else if (pair.Key == "AdminManageRedemptions_AMRRewardsReceived_Mail_Button_ViewandPrint")
                        {
                            AdminManageRedemptions_AMRRewardsReceived_Mail_Button_ViewandPrint = pair.Value;
                        }
                        else if (pair.Key == "AdminManageRedemptions_AMRRewardsReceived_Textbox_Email")
                        {
                        AdminManageRedemptions_AMRRewardsReceived_Textbox_Email = pair.Value;
                        }
                }
                    #endregion[ModuleAdminManageRedemptions]

                    #region[AdminEditProfile]

                    if (nodeModule == Constants.ModuleAdminEditProfile)
                    {
                        if (pair.Key == "AdminEditProfile_Email")
                        {
                            AdminEditProfileEmail = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_Country")
                        {
                            AdminEditProfileCountry = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_Language")
                        {
                            AdminEditProfileLanguage = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_Title")
                        {
                            AdminEditProfileTitle = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_FirstName")
                        {
                            AdminEditProfileFirstName = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_LastName")
                        {
                            AdminEditProfileLastName = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_BirthdayMonth")
                        {
                            AdminEditProfileBirthdayMonth = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_BirthdayDay")
                        {
                            AdminEditProfileBirthdayDay = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_Address1")
                        {
                            AdminEditProfileAddress1 = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_Address2")
                        {
                            AdminEditProfileAddress2 = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_City")
                        {
                            AdminEditProfileCity = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_State")
                        {
                            AdminEditProfileState = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_Province")
                        {
                            AdminEditProfileProvince = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_Zip")
                        {
                            AdminEditProfileZip = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_WorkPhonePrefix")
                        {
                            AdminEditProfileWorkPhonePrefix = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_WorkPhoneAreaCode")
                        {
                            AdminEditProfileWorkPhoneAreaCode = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_WorkPhoneFirst3")
                        {
                            AdminEditProfileWorkPhoneFirst3 = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_WorkPhoneLast4")
                        {
                            AdminEditProfileWorkPhoneLast4 = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_WorkExtension")
                        {
                            AdminEditProfileWorkExtension = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_HomePhonePrefix")
                        {
                            AdminEditProfileHomePhonePrefix = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_HomePhoneAreaCode")
                        {
                            AdminEditProfileHomePhoneAreaCode = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_HomePhoneFirst3")
                        {
                            AdminEditProfileHomePhoneFirst3 = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_HomePhoneLast4")
                        {
                            AdminEditProfileHomePhoneLast4 = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_MobilePhonePrefix")
                        {
                            AdminEditProfileMobilePhonePrefix = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_MobilePhoneAreaCode")
                        {
                            AdminEditProfileMobilePhoneAreaCode = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_MobilePhoneFirst3")
                        {
                            AdminEditProfileMobilePhoneFirst3 = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_MobilePhoneLast4")
                        {
                            AdminEditProfileMobilePhoneLast4 = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_FaxPhonePrefix")
                        {
                            AdminEditProfileFaxPhonePrefix = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_FaxPhoneAreaCode")
                        {
                            AdminEditProfileFaxPhoneAreaCode = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_FaxPhoneFirst3")
                        {
                            AdminEditProfileFaxPhoneFirst3 = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_FaxPhoneLast4")
                        {
                            AdminEditProfileFaxPhoneLast4 = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_IATA")
                        {
                            AdminEditProfileIATA = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_ARC")
                        {
                            AdminEditProfileARC = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_CLIA")
                        {
                            AdminEditProfileCLIA = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_TRU")
                        {
                            AdminEditProfileTRU = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_ACTA")
                        {
                            AdminEditProfileACTA = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_TIDS")
                        {
                            AdminEditProfileTIDS = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_TICO")
                        {
                            AdminEditProfileTICO = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_ABTA")
                        {
                            AdminEditProfileABTA = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_ATOL")
                        {
                            AdminEditProfileATOL = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_RetailAgency")
                        {
                            AdminEditProfileRetailAgency = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_RemoteHomeBased")
                        {
                            AdminEditProfileRemoteHomeBased = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_TourOperatorWholesaler")
                        {
                            AdminEditProfileTourOperatorWholesaler = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_MeetingPlanner")
                        {
                            AdminEditProfileMeetingPlanner = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_DestinationWeddingSpecialist")
                        {
                            AdminEditProfileDestinationWeddingSpecialist = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_Affiliation")
                        {
                            AdminEditProfileAffiliation = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_AdminEditProfileButton")
                        {
                            AdminEditProfileAdminEditProfileButton = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_Cancel")
                        {
                            AdminEditProfileCancel = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_RegistrationCompleteButton")
                        {
                            AdminEditProfileUpdateCompleteButton = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_MergeProfile")
                        {
                            AdminEditProfileMergeProfile = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_UploadPhoto")
                        {
                            AdminEditProfileUploadPhoto = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_UploadAgencyLogo")
                        {
                            AdminEditProfileUploadAgencyLogo = pair.Value;
                        }
                        else if (pair.Key == "AdminEditProfile_W9")
                        {
                            AdminEditProfileW9 = pair.Value;
                        }

                    }

                    #endregion[AdminEditProfile]

                    #endregion[Admin]

                }
                return obj;
        }
    }
}
