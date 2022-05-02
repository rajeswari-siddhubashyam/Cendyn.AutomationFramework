

using System;
using AMR_Agent.AppModule.UI;
using AMR_Agent.PageObject.Admin;
using BaseUtility.Utility;
using InfoMessageLogger;

namespace AMR.AppModule.Admin.Home.ManageProfiles.EditProfile
{
    class AdminEditProfile : Setup
    {
        public static string UpdateEmail { get; set; }
        public static string UpdateCountry { get; set; }
        public static string UpdateLanguage { get; set; }
        public static string UpdateTitle { get; set; }
        public static string UpdateFirstName { get; set; }
        public static string UpdateLastName { get; set; }
        public static string UpdateBirthdayMonth { get; set; }
        public static string UpdateBirthdayDay { get; set; }
        public static string UpdateAddress1 { get; set; }
        public static string UpdateAddress2 { get; set; }
        public static string UpdateCity { get; set; }
        public static string UpdateStateProvince { get; set; }
        public static string UpdateZip { get; set; }
        public static string UpdateWorkPrefix { get; set; }
        public static string UpdateWorkAreaCode { get; set; }
        public static string UpdateWorkFirst3 { get; set; }
        public static string UpdateWorkLast4 { get; set; }
        public static string UpdateWorkExtension { get; set; }
        public static string UpdateHomePrefix { get; set; }
        public static string UpdateHomeAreaCode { get; set; }
        public static string UpdateHomeFirst3 { get; set; }
        public static string UpdateHomeLast4 { get; set; }
        public static string UpdateMobilePrefix { get; set; }
        public static string UpdateMobileAreaCode { get; set; }
        public static string UpdateMobileFirst3 { get; set; }
        public static string UpdateMobileLast4 { get; set; }
        public static string UpdateFaxPrefix { get; set; }
        public static string UpdateFaxAreaCode { get; set; }
        public static string UpdateFaxFirst3 { get; set; }
        public static string UpdateFaxLast4 { get; set; }
        public static string UpdateIATA { get; set; }
        public static string UpdateARC { get; set; }
        public static string UpdateCLIA { get; set; }
        public static string UpdateTRU { get; set; }
        public static string UpdateACTA { get; set; }
        public static string UpdateTIDS { get; set; }
        public static string UpdateTICO { get; set; }
        public static string UpdateABTA { get; set; }
        public static string UpdateATOL { get; set; }
        public static string UpdateRetailAgency { get; set; }
        public static string UpdateRemoteHomeBased { get; set; }
        public static string UpdateTourOperatorWholesaler { get; set; }
        public static string UpdateMeetingPlanner { get; set; }
        public static string UpdateDestinationWeddingSpecialist { get; set; }
        public static string UpdateAffiliation { get; set; }

        public static void EnterFirstname(string text)
        {
            Helper.ElementEnterText(PageObject_AdminEditProfile.AdminEditProfileFirstName(), text);            
            Helper.AddDelay(1500);
        }

        public static void EnterLastname(string text)
        {
            Helper.ElementEnterText(PageObject_AdminEditProfile.AdminEditProfileLastName(), text);
            Helper.AddDelay(1500);
        }

        public static void ClickUpdate()
        {
            Helper.ElementClick(PageObject_AdminEditProfile.AdminEditProfileAdminEditProfileButton());
        }

        public static void ClickOkButton()
        {
            Helper.ElementClick(PageObject_AdminEditProfile.AdminEditProfileOKButton());
        }

        /// <summary>
        /// This method will compare the entered registration data on the frontend to what displays on the backend.
        /// </summary>
        public static void ValidateRegistrationInformation()
        {
            GetEditProfileValues();
            Helper.ScrollToElement(PageObject_AdminEditProfile.AdminEditProfileCountry());
            try
            {
                if (UpdateEmail ==
                    Registration.RegEmail)
                    Logger.WriteInfoMessage("The registered Email is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegEmail + "\nBut found: " +
                                        UpdateEmail);


                if (UpdateCountry == Registration.RegCountry)
                    Logger.WriteInfoMessage("The registered RegCountry is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegCountry + "\nBut found: " +
                                        UpdateCountry);

                if (UpdateLanguage ==
                    Registration.RegLanguage)
                    Logger.WriteInfoMessage("The registered Language is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegLanguage + "\nBut found: " +
                                        UpdateLanguage);

                if (UpdateFirstName ==
                    Registration.RegFirstName)
                    Logger.WriteInfoMessage("The registered First Name is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegFirstName + "\nBut found: " +
                                        UpdateFirstName);

                if (UpdateLastName ==
                    Registration.RegLastName)
                    Logger.WriteInfoMessage("The registered Last is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegLastName + "\nBut found: " +
                                        UpdateLastName);

                if (UpdateBirthdayMonth ==
                    Registration.RegBirthdayMonth)
                    Logger.WriteInfoMessage("The registered Birthday Month is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegBirthdayMonth + "\nBut found: " +
                                        UpdateBirthdayMonth);

                if (UpdateBirthdayDay ==
                    Registration.RegBirthdayDay)
                    Logger.WriteInfoMessage("The registered Birthday Day is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegBirthdayDay + "\nBut found: " +
                                        UpdateBirthdayDay);

                if (UpdateAddress1 ==
                    Registration.RegAddress1)
                    Logger.WriteInfoMessage("The registered Address 1 is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegAddress1 + "\nBut found: " +
                                        UpdateAddress1);

                if (UpdateAddress2 ==
                    Registration.RegAddress2)
                    Logger.WriteInfoMessage("The registered Address 2 is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegAddress2 + "\nBut found: " +
                                        UpdateAddress2);

                if (UpdateCity == Registration.RegCity)
                    Logger.WriteInfoMessage("The registered City is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegCity + "\nBut found: " +
                                        UpdateCity);

                if (UpdateCountry == "United States")
                {
                    if (UpdateStateProvince ==
                        Registration.RegStateProvince)
                        Logger.WriteInfoMessage("The registered State is displaying correctly on the Admin site.");
                    else
                        throw new Exception("\nWas looking for: " + Registration.RegStateProvince + "\nBut found: " +
                                            UpdateStateProvince);
                }

                if (UpdateCountry == "Canada")
                {
                    if (UpdateStateProvince ==
                        Registration.RegStateProvince)
                        Logger.WriteInfoMessage("The registered Province is displaying correctly on the Admin site.");
                    else
                        throw new Exception("\nWas looking for: " + Registration.RegStateProvince + "\nBut found: " +
                                            UpdateCountry);
                }

                if (UpdateZip == Registration.RegZip)
                    Logger.WriteInfoMessage("The registered Zip is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegZip + "\nBut found: " +
                                        UpdateZip);

                if (UpdateWorkPrefix ==
                    Registration.RegWorkPrefix)
                    Logger.WriteInfoMessage(
                        "The registered Work Phone Prefix is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegWorkPrefix + "\nBut found: " +
                                        UpdateWorkPrefix);

                if (UpdateWorkAreaCode ==
                    Registration.RegWorkAreaCode)
                    Logger.WriteInfoMessage("The registered Work Phone Area is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegWorkAreaCode + "\nBut found: " +
                                        UpdateWorkAreaCode);

                if (UpdateWorkFirst3 ==
                    Registration.RegWorkFirst3)
                    Logger.WriteInfoMessage(
                        "The registered Work Phone First 3 is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegWorkFirst3 + "\nBut found: " +
                                        UpdateWorkFirst3);

                if (UpdateWorkLast4 ==
                    Registration.RegWorkLast4)
                    Logger.WriteInfoMessage(
                        "The registered Work Phone Last 4 is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegWorkLast4 + "\nBut found: " +
                                        UpdateWorkLast4);

                if (UpdateWorkExtension ==
                    Registration.RegWorkExtension)
                    Logger.WriteInfoMessage(
                        "The registered Work Phone Extension is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegWorkExtension + "\nBut found: " +
                                        UpdateWorkExtension);

                if (UpdateHomePrefix ==
                    Registration.RegHomePrefix)
                    Logger.WriteInfoMessage(
                        "The registered Home Phone Prefix is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegHomePrefix + "\nBut found: " +
                                        UpdateHomePrefix);

                if (UpdateHomeAreaCode ==
                    Registration.RegHomeAreaCode)
                    Logger.WriteInfoMessage("The registered Home Phone Area is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegHomeAreaCode + "\nBut found: " +
                                        UpdateHomeAreaCode);

                if (UpdateHomeFirst3 ==
                    Registration.RegHomeFirst3)
                    Logger.WriteInfoMessage(
                        "The registered Home Phone First 3 is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegHomeFirst3 + "\nBut found: " +
                                        UpdateHomeFirst3);

                if (UpdateHomeLast4 ==
                    Registration.RegHomeLast4)
                    Logger.WriteInfoMessage(
                        "The registered Home Phone Last 4 is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegHomeLast4 + "\nBut found: " +
                                        UpdateHomeLast4);

                if (UpdateMobilePrefix ==
                    Registration.RegMobilePrefix)
                    Logger.WriteInfoMessage(
                        "The registered Mobile Phone Prefix is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegMobilePrefix + "\nBut found: " +
                                        UpdateMobilePrefix);

                if (UpdateMobileAreaCode ==
                    Registration.RegMobileAreaCode)
                    Logger.WriteInfoMessage(
                        "The registered Mobile Phone Area is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegMobileAreaCode + "\nBut found: " +
                                        UpdateMobileAreaCode);

                if (UpdateMobileFirst3 ==
                    Registration.RegMobileFirst3)
                    Logger.WriteInfoMessage(
                        "The registered Mobile Phone First 3 is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegMobileFirst3 + "\nBut found: " +
                                        UpdateMobileFirst3);

                if (UpdateMobileLast4 ==
                    Registration.RegMobileLast4)
                    Logger.WriteInfoMessage(
                        "The registered Mobile Phone Last 4 is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegMobileLast4 + "\nBut found: " +
                                        UpdateMobileLast4);

                if (UpdateFaxPrefix ==
                    Registration.RegFaxPrefix)
                    Logger.WriteInfoMessage("The registered Fax Phone Prefix is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegFaxPrefix + "\nBut found: " +
                                        UpdateFaxPrefix);

                if (UpdateFaxAreaCode ==
                    Registration.RegFaxAreaCode)
                    Logger.WriteInfoMessage("The registered Fax Phone Area is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegFaxAreaCode + "\nBut found: " +
                                        UpdateFaxAreaCode);

                if (UpdateFaxFirst3 ==
                    Registration.RegFaxFirst3)
                    Logger.WriteInfoMessage(
                        "The registered Fax Phone First 3 is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegFaxFirst3 + "\nBut found: " +
                                        UpdateFaxFirst3);

                if (UpdateFaxLast4 ==
                    Registration.RegFaxLast4)
                    Logger.WriteInfoMessage("The registered Fax Phone Last 4 is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegFaxLast4 + "\nBut found: " +
                                        UpdateFaxLast4);

                if (UpdateFaxLast4 ==
                    Registration.RegFaxLast4)
                    Logger.WriteInfoMessage("The registered Fax Phone Last 4 is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegFaxLast4 + "\nBut found: " +
                                        UpdateFaxLast4);

                if (UpdateIATA == Registration.RegIATA)
                    Logger.WriteInfoMessage("The registered IATA is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegIATA + "\nBut found: " +
                                        UpdateIATA);

                if (UpdateARC == Registration.RegARC)
                    Logger.WriteInfoMessage("The registered ARC is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegARC + "\nBut found: " +
                                        UpdateARC);

                if (UpdateCLIA == Registration.RegCLIA)
                    Logger.WriteInfoMessage("The registered CLIA is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegCLIA + "\nBut found: " +
                                        UpdateCLIA);

                if (UpdateTRU == Registration.RegTRU)
                    Logger.WriteInfoMessage("The registered TRU is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegTRU + "\nBut found: " +
                                        UpdateTRU);

                if (UpdateACTA == Registration.RegACTA)
                    Logger.WriteInfoMessage("The registered ACTA is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegACTA + "\nBut found: " +
                                        UpdateACTA);

                if (UpdateTIDS == Registration.RegTIDS)
                    Logger.WriteInfoMessage("The registered TIDS is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegTIDS + "\nBut found: " +
                                        UpdateTIDS);

                if (UpdateTICO == Registration.RegTICO)
                    Logger.WriteInfoMessage("The registered TICO is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegTICO + "\nBut found: " +
                                        UpdateTICO);

                if (UpdateABTA == Registration.RegABTA)
                    Logger.WriteInfoMessage("The registered ABTA is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegABTA + "\nBut found: " +
                                        UpdateABTA);

                if (UpdateATOL == Registration.RegATOL)
                    Logger.WriteInfoMessage("The registered ATOL is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegATOL + "\nBut found: " +
                                        UpdateATOL);

                //Need to verify the "Agent Types" when IDs are fixed
                if (Registration.RegRetailAgency == "Yes")
                {
                    if (UpdateRetailAgency == "Yes")
                        Logger.WriteInfoMessage("Retail Agency is displaying correctly on the Admin site.");
                    else
                        throw new Exception(
                            "Retail Agency was selected on the registration but was not selected on the Admin site.");
                }
                if (Registration.RegRemoteHomeBased == "Yes")
                {
                    if (UpdateRemoteHomeBased == "Yes")
                        Logger.WriteInfoMessage("Remote Home Based is displaying correctly on the Admin site.");
                    else
                        throw new Exception(
                            "Remote Home Based was selected on the registration but was not selected on the Admin site.");
                }
                if (Registration.RegTourOperatorWholesaler == "Yes")
                {
                    if (UpdateTourOperatorWholesaler == "Yes")
                        Logger.WriteInfoMessage("The Tour Operator Wholesaler is displaying correctly on the Admin site.");
                    else
                        throw new Exception(
                            "Tour Operator Wholesaler was selected on the registration but was not selected on the Admin site.");
                }
                if (Registration.RegMeetingPlanner == "Yes")
                {
                    if (UpdateMeetingPlanner == "Yes")
                        Logger.WriteInfoMessage("The Meeting Planner is displaying correctly on the Admin site.");
                    else
                        throw new Exception(
                            "Meeting Planner was selected on the registration but was not selected on the Admin site.");
                }
                if (Registration.RegDestinationWeddingSpecialist == "Yes")
                {
                    if (UpdateDestinationWeddingSpecialist == "Yes")
                        Logger.WriteInfoMessage("The Destination Wedding Specialist is displaying correctly on the Admin site.");
                    else
                        throw new Exception(
                            "Destination Wedding Specialist was selected on the registration but was not selected on the Admin site.");
                }

                //Check if an affiliation was used.
                if (UpdateAffiliation == Registration.RegAffiliation)
                    Logger.WriteInfoMessage("The registered ATOL is displaying correctly on the Admin site.");
                else
                    throw new Exception("\nWas looking for: " + Registration.RegAffiliation + "\nBut found: " +
                                        UpdateAffiliation);
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage(e);
                throw;
            }
            Logger.WriteDebugMessage("All information on the Edit Profile page matches what was registered!");
        }

        public static void GetEditProfileValues()
        {
            Time.AddDelay(5000);
            //PageObject_AdminEditProfile.AdminEditProfileEmail().Clear();
            UpdateEmail = PageObject_AdminEditProfile.AdminEditProfileEmail().GetAttribute("value");
            UpdateCountry = PageObject_AdminEditProfile.AdminEditProfileCountry().GetAttribute("value");
            UpdateLanguage = PageObject_AdminEditProfile.AdminEditProfileLanguage().GetAttribute("value");
            UpdateTitle = PageObject_AdminEditProfile.AdminEditProfileTitle().GetAttribute("value");
            UpdateFirstName = PageObject_AdminEditProfile.AdminEditProfileFirstName().GetAttribute("value");
            UpdateLastName = PageObject_AdminEditProfile.AdminEditProfileLastName().GetAttribute("value");
            UpdateBirthdayMonth = PageObject_AdminEditProfile.AdminEditProfileBirthdayMonth().GetAttribute("value");
            UpdateBirthdayDay = PageObject_AdminEditProfile.AdminEditProfileBirthdayDay().GetAttribute("value");
            UpdateAddress1 = PageObject_AdminEditProfile.AdminEditProfileAddress1().GetAttribute("value");
            UpdateAddress2 = PageObject_AdminEditProfile.AdminEditProfileAddress2().GetAttribute("value");
            UpdateCity = PageObject_AdminEditProfile.AdminEditProfileCity().GetAttribute("value");
            if (PageObject_AdminEditProfile.AdminEditProfileCountry().GetAttribute("value") == "United States")
            {
                UpdateStateProvince = PageObject_AdminEditProfile.AdminEditProfileState().GetAttribute("value");
            }
            else if (PageObject_AdminEditProfile.AdminEditProfileCountry().GetAttribute("value") == "Canada")
            {
                UpdateStateProvince = PageObject_AdminEditProfile.AdminEditProfileProvince().GetAttribute("value");
            }
            UpdateZip = PageObject_AdminEditProfile.AdminEditProfileZip().GetAttribute("value");
            UpdateWorkPrefix = PageObject_AdminEditProfile.AdminEditProfileWorkPhonePrefix().GetAttribute("value");
            UpdateWorkAreaCode = PageObject_AdminEditProfile.AdminEditProfileWorkPhoneAreaCode().GetAttribute("value");
            UpdateWorkFirst3 = PageObject_AdminEditProfile.AdminEditProfileWorkPhoneFirst3().GetAttribute("value");
            UpdateWorkLast4 = PageObject_AdminEditProfile.AdminEditProfileWorkPhoneLast4().GetAttribute("value");
            UpdateWorkExtension = PageObject_AdminEditProfile.AdminEditProfileWorkExtension().GetAttribute("value");
            UpdateHomePrefix = PageObject_AdminEditProfile.AdminEditProfileHomePhonePrefix().GetAttribute("value");
            UpdateHomeAreaCode = PageObject_AdminEditProfile.AdminEditProfileHomePhoneAreaCode().GetAttribute("value");
            UpdateHomeFirst3 = PageObject_AdminEditProfile.AdminEditProfileHomePhoneFirst3().GetAttribute("value");
            UpdateHomeLast4 = PageObject_AdminEditProfile.AdminEditProfileHomePhoneLast4().GetAttribute("value");
            UpdateMobilePrefix = PageObject_AdminEditProfile.AdminEditProfileMobilePhonePrefix().GetAttribute("value");
            UpdateMobileAreaCode = PageObject_AdminEditProfile.AdminEditProfileMobilePhoneAreaCode().GetAttribute("value");
            UpdateMobileFirst3 = PageObject_AdminEditProfile.AdminEditProfileMobilePhoneFirst3().GetAttribute("value");
            UpdateMobileLast4 = PageObject_AdminEditProfile.AdminEditProfileMobilePhoneLast4().GetAttribute("value");
            UpdateFaxPrefix = PageObject_AdminEditProfile.AdminEditProfileFaxPhonePrefix().GetAttribute("value");
            UpdateFaxAreaCode = PageObject_AdminEditProfile.AdminEditProfileFaxPhoneAreaCode().GetAttribute("value");
            UpdateFaxFirst3 = PageObject_AdminEditProfile.AdminEditProfileFaxPhoneFirst3().GetAttribute("value");
            UpdateFaxLast4 = PageObject_AdminEditProfile.AdminEditProfileFaxPhoneLast4().GetAttribute("value");
            UpdateIATA = PageObject_AdminEditProfile.AdminEditProfileIATA().GetAttribute("value");
            UpdateARC = PageObject_AdminEditProfile.AdminEditProfileARC().GetAttribute("value");
            UpdateCLIA = PageObject_AdminEditProfile.AdminEditProfileCLIA().GetAttribute("value");
            UpdateTRU = PageObject_AdminEditProfile.AdminEditProfileTRU().GetAttribute("value");
            UpdateACTA = PageObject_AdminEditProfile.AdminEditProfileACTA().GetAttribute("value");
            UpdateTIDS = PageObject_AdminEditProfile.AdminEditProfileTIDS().GetAttribute("value");
            UpdateTICO = PageObject_AdminEditProfile.AdminEditProfileTICO().GetAttribute("value");
            UpdateABTA = PageObject_AdminEditProfile.AdminEditProfileABTA().GetAttribute("value");
            UpdateATOL = PageObject_AdminEditProfile.AdminEditProfileATOL().GetAttribute("value");

            if (PageObject_AdminEditProfile.AdminEditProfileRetailAgency().Selected)
            {
                UpdateRetailAgency = "Yes";
            }
            else
                UpdateRetailAgency = "No";

            //WAITING FOR AGENT TYPE IDS TO BE STATIC
            if (PageObject_AdminEditProfile.AdminEditProfileRemoteHomeBased().Selected)
            {
                UpdateRemoteHomeBased = "Yes";
            }
            else
                UpdateRemoteHomeBased = "No";

            if (PageObject_AdminEditProfile.AdminEditProfileTourOperatorWholesaler().Selected)
            {
                UpdateTourOperatorWholesaler = "Yes";
            }
            else
                UpdateTourOperatorWholesaler = "No";

            if (PageObject_AdminEditProfile.AdminEditProfileMeetingPlanner().Selected)
            {
                UpdateMeetingPlanner = "Yes";
            }
            else
                UpdateMeetingPlanner = "No";

            if (PageObject_AdminEditProfile.AdminEditProfileDestinationWeddingSpecialist().Selected)
            {
                UpdateDestinationWeddingSpecialist = "Yes";
            }
            else
                UpdateDestinationWeddingSpecialist = "No";

            UpdateAffiliation = PageObject_AdminEditProfile.AdminEditProfileAffiliation().GetAttribute("value");

            Logger.WriteInfoMessage("All Edit Profile values are stored.");
        }
    }
}
