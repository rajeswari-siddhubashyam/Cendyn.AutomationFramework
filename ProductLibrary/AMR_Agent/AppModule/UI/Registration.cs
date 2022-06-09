using System;
using AMR_Agent.PageObject.Admin;
using AMR_Agent.PageObject.UI;
using AMR_Agent.Utility;
using BaseUtility.Utility;
using InfoMessageLogger;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AMR_Agent.AppModule.UI
{
    public class Registration : Utility.Setup
    {

        public static string RegEmail { get; set; }
        public static string RegCountry { get; set; }
        public static string RegLanguage { get; set; }
        public static string RegTitle { get; set; }
        public static string RegFirstName { get; set; }
        public static string RegLastName { get; set; }
        public static string RegBirthdayMonth { get; set; }
        public static string RegBirthdayDay { get; set; }
        public static string RegAddress1 { get; set; }
        public static string RegAddress2 { get; set; }
        public static string RegCity { get; set; }
        public static string RegStateProvince { get; set; }
        public static string RegZip { get; set; }
        public static string RegWorkPrefix { get; set; }
        public static string RegWorkAreaCode { get; set; }
        public static string RegWorkFirst3 { get; set; }
        public static string RegWorkLast4 { get; set; }
        public static string RegWorkExtension { get; set; }
        public static string RegHomePrefix { get; set; }
        public static string RegHomeAreaCode { get; set; }
        public static string RegHomeFirst3 { get; set; }
        public static string RegHomeLast4 { get; set; }
        public static string RegMobilePrefix { get; set; }
        public static string RegMobileAreaCode { get; set; }
        public static string RegMobileFirst3 { get; set; }
        public static string RegMobileLast4 { get; set; }
        public static string RegFaxPrefix { get; set; }
        public static string RegFaxAreaCode { get; set; }
        public static string RegFaxFirst3 { get; set; }
        public static string RegFaxLast4 { get; set; }
        public static string RegIATA { get; set; }
        public static string RegARC { get; set; }
        public static string RegCLIA { get; set; }
        public static string RegTRU { get; set; }
        public static string RegACTA { get; set; }
        public static string RegTIDS { get; set; }
        public static string RegTICO { get; set; }
        public static string RegABTA { get; set; }
        public static string RegATOL { get; set; }
        public static string RegRetailAgency { get; set; }
        public static string RegRemoteHomeBased { get; set; }
        public static string RegTourOperatorWholesaler { get; set; }
        public static string RegMeetingPlanner { get; set; }
        public static string RegDestinationWeddingSpecialist { get; set; }
        public static string RegAffiliation { get; set; }

        public static void DefaultEmailPassSecurity(string email)
        {
            //RegEmail = EmailNow();

            ElementEnterText(PageObject_Registration.RegisterEmail(), email);

            ElementEnterText(PageObject_Registration.RegisterConfirmEmail(), email);

            ElementEnterText(PageObject_Registration.RegisterPassword(), Constants.Common_Registration_Password);

            ElementEnterText(PageObject_Registration.RegisterConfirmPassword(), Constants.Common_Registration_ConfirmPassword);

            ElementSelectFromDropDown(PageObject_Registration.RegisterSecurityQuestion(), Constants.Common_Registration_SecurityQuestion);

            ElementEnterText(PageObject_Registration.RegisterSecurityAnswer(), Constants.Common_Registration_SecurityAnswer);

            Logger.WriteDebugMessage("Email,Password and security question entered");

        }

        public static void DefaultPersonalInformation()
        {
            ScrollToElement(PageObject_Registration.RegisterCountry());
            ElementSelectFromDropDown(PageObject_Registration.RegisterCountry(), Constants.Common_Registration_Country);
            //ElementSelectFromDropDown(PageObject_Registration.RegisterCountry(), TestData.Common_Registration_Country);

            //ElementSelectFromDropDown(PageObject_Registration.RegisterLanguage(), TestData.Common_Registration_Language);
            ElementSelectFromDropDown(PageObject_Registration.RegisterLanguage(), Constants.Common_Registration_Language);

            ElementSelectFromDropDown(PageObject_Registration.RegisterTitle(), Constants.Common_Registration_Title);

            ElementEnterText(PageObject_Registration.RegisterFirstName(), Constants.Common_Registration_FirstName);

            ElementEnterText(PageObject_Registration.RegisterLastName(), Constants.Common_Registration_LastName);

            ElementSelectFromDropDown(PageObject_Registration.RegisterBirthdayMonth(), Constants.Common_Registration_BirthdayMonth);

            ElementSelectFromDropDown(PageObject_Registration.RegisterBirthdayDay(), Constants.Common_Registration_BirthdayDay);

            ElementEnterText(PageObject_Registration.RegisterAddress1(), Constants.Common_Registration_Address1);

            ElementEnterText(PageObject_Registration.RegisterAddress2(), Constants.Common_Registration_Address2);

            ElementEnterText(PageObject_Registration.RegisterCity(), Constants.Common_Registration_City);

            ElementSelectFromDropDown(PageObject_Registration.RegisterState(), Constants.Common_Registration_State);

            ElementEnterText(PageObject_Registration.RegisterZip(), Constants.Common_Registration_Zip);

            ElementEnterText(PageObject_Registration.RegisterWorkPhonePrefix(), Constants.Common_Registration_WorkPhonePrefix);

            ElementEnterText(PageObject_Registration.RegisterWorkPhoneAreaCode(), Constants.Common_Registration_WorkPhoneAreaCode);
            AddDelay(100);
            ElementEnterText(PageObject_Registration.RegisterWorkPhoneFirst3(), Constants.Common_Registration_WorkPhoneFirstThree);

            ElementEnterText(PageObject_Registration.RegisterWorkPhoneLast4(), Constants.Common_Registration_WorkPhoneLastFour);

            ElementEnterText(PageObject_Registration.RegisterWorkExtension(), Constants.Common_Registration_WorkPhoneExtension);

            ElementEnterText(PageObject_Registration.RegisterHomePhonePrefix(), Constants.Common_Registration_HomePhonePrefix);

            ElementEnterText(PageObject_Registration.RegisterHomePhoneAreaCode(), Constants.Common_Registration_HomePhoneAreaCode);

            ElementEnterText(PageObject_Registration.RegisterHomePhoneFirst3(), Constants.Common_Registration_HomePhoneFirstThree);

            ElementEnterText(PageObject_Registration.RegisterHomePhoneLast4(), Constants.Common_Registration_HomePhoneLastFour);

            ElementEnterText(PageObject_Registration.RegisterMobilePhonePrefix(), Constants.Common_Registration_MobilePhonePrefix);

            ElementEnterText(PageObject_Registration.RegisterMobilePhoneAreaCode(), Constants.Common_Registration_MobilePhoneAreaCode);

            ElementEnterText(PageObject_Registration.RegisterMobilePhoneFirst3(), Constants.Common_Registration_MobilePhoneFirstThree);

            ElementEnterText(PageObject_Registration.RegisterMobilePhoneLast4(), Constants.Common_Registration_MobilePhoneLastFour);

            ElementEnterText(PageObject_Registration.RegisterFaxPhonePrefix(), Constants.Common_Registration_FaxPhonePrefix);

            ElementEnterText(PageObject_Registration.RegisterFaxPhoneAreaCode(), Constants.Common_Registration_FaxPhoneAreaCode);

            ElementEnterText(PageObject_Registration.RegisterFaxPhoneFirst3(), Constants.Common_Registration_FaxPhoneFirstThree);

            ElementEnterText(PageObject_Registration.RegisterFaxPhoneLast4(), Constants.Common_Registration_FaxPhoneLastFour);

            while (PageObject_Registration.RegisterWorkPhoneAreaCode().GetAttribute("value") == "")
            {
                ElementEnterText(PageObject_Registration.RegisterWorkPhoneAreaCode(), Constants.Common_Registration_WorkPhoneAreaCode);
                AddDelay(100);
            }

            while (PageObject_Registration.RegisterWorkPhoneFirst3().GetAttribute("value") == "")
            {
                ElementEnterText(PageObject_Registration.RegisterWorkPhoneFirst3(), Constants.Common_Registration_WorkPhoneFirstThree);

            }

            while (PageObject_Registration.RegisterWorkPhoneLast4().GetAttribute("value") == "")
            {
                ElementEnterText(PageObject_Registration.RegisterWorkPhoneLast4(), Constants.Common_Registration_WorkPhoneLastFour);

            }
            Logger.WriteDebugMessage("Personal details entered");
        }

        public static void DefaultAffliationCodes()
        {
            ElementEnterText(PageObject_Registration.RegisterIATA(), Constants.Common_Registration_IATA);

            ElementEnterText(PageObject_Registration.RegisterARC(), Constants.Common_Registration_ARC);

            ElementEnterText(PageObject_Registration.RegisterCLIA(), Constants.Common_Registration_CLIA);

            ElementEnterText(PageObject_Registration.RegisterTRU(), Constants.Common_Registration_TRU);

            /*
            ElementEnterText(PageObject_Registration.RegisterACTA(), TestData.Common_Registration_ACTA);
            
            ElementEnterText(PageObject_Registration.RegisterTIDS(), TestData.Common_Registration_TIDS);
            
            ElementEnterText(PageObject_Registration.RegisterTICO(), TestData.Common_Registration_TICO);
            
            ElementEnterText(PageObject_Registration.RegisterABTA(), TestData.Common_Registration_ABTA);
            
            ElementEnterText(PageObject_Registration.RegisterATOL(), TestData.Common_Registration_ATOL);
             */

        }

        public static void DefaultAgentType()
        {

            if (Constants.Common_Registration_RetailAgency == "Yes")
            {
                MakeSureIsChecked(PageObject_Registration.RegisterRetailAgency());
                AddDelay(500);

            }

            if (Constants.Common_Registration_RemoteHomeBased == "Yes")
            {
                MakeSureIsChecked(PageObject_Registration.RegisterRemoteHomeBased());
                AddDelay(500);
            }

            if (Constants.Common_Registration_TourOperatorWholesaler == "Yes")
            {
                MakeSureIsChecked(PageObject_Registration.RegisterTourOperatorWholesaler());
                AddDelay(500);
            }

            if (Constants.Common_Registration_MeetingPlanner == "Yes")
            {
                MakeSureIsChecked(PageObject_Registration.RegisterMeetingPlanner());
                AddDelay(500);
            }

            if (Constants.Common_Registration_DestinationWeddingSpecialist == "Yes")
            {
                MakeSureIsChecked(PageObject_Registration.RegisterDestinationWeddingSpecialist());
                AddDelay(500);
            }


            PageObject_Registration.RegisterAffiliation().SendKeys(Constants.Common_Registration_Affiliation);
            AddDelay(500);
            Logger.WriteDebugMessage("Agent type entered");

        }

        /* This method will fill in all the Registration fields using the values from the XML document. */
        public static void DefaultRegistration(string email1)
        {
            Registration.DefaultEmailPassSecurity(email1);
            DefaultPersonalInformation();
            DefaultAffliationCodes();
            DefaultAgentType();

        }

        public static void DefaultPersonalInformationSelectCountry(string country, string state, string address, string city, string zip)
        {
            AddDelay(500);
            ScrollToElement(PageObject_Registration.RegisterCountry());
            AddDelay(1500);
            ElementSelectFromDropDown(PageObject_Registration.RegisterCountry(), country);
            ElementSelectFromDropDown(PageObject_Registration.RegisterLanguage(), Constants.Common_Registration_Language);
            PageObject_Registration.RegisterTitle().SendKeys(Constants.Common_Registration_Title);
            AddDelay(750);
            PageObject_Registration.RegisterFirstName().SendKeys(Constants.Common_Registration_FirstName);
            AddDelay(750);
            PageObject_Registration.RegisterLastName().SendKeys(Constants.Common_Registration_LastName);
            AddDelay(750);
            PageObject_Registration.RegisterBirthdayMonth().SendKeys(Constants.Common_Registration_BirthdayMonth);
            AddDelay(750);
            ElementSelectFromDropDown(PageObject_Registration.RegisterBirthdayDay(), Constants.Common_Registration_BirthdayDay);
            Logger.WriteDebugMessage("Entered Personal Details");
            //ElementSelectFromDropDown(PageObject_Registration.RegisterBirthdayDay(), TestData.Common_Registration_BirthdayDay);
            AddDelay(750);
            PageObject_Registration.RegisterAddress1().SendKeys(address);
            AddDelay(750);
            PageObject_Registration.RegisterCity().SendKeys(city);
            AddDelay(1750);
            if (country == "Canada")
            {
                PageObject_Registration.RegisterProvince().SendKeys(state);
                AddDelay(750);
            }
            else
                ElementSelectFromDropDown(PageObject_Registration.RegisterState(), state);
            PageObject_Registration.RegisterZip().SendKeys(zip);
            //AddDelay(20000);
            //try
            //{
            //    if (PageObject_Registration.Register_AddressSuggestionPopup_ClickYes().Displayed)
            //    {
            //        Logger.WriteDebugMessage("Address suggestion pop up displayed");
            //        PageObject_Registration.Register_AddressSuggestionPopup_ClickYes().Click();
            //        Logger.WriteDebugMessage("Clicked on 'Yes, I want to use this address' ");
            //    }
            //}
            //catch
            //{
            //    PageObject_Registration.RegisterProvince().SendKeys(state);
            //    Logger.WriteDebugMessage("Address suggestion pop up not displayed on the page");
            //}
            PageObject_Registration.RegisterWorkPhonePrefix().Click();
            AddDelay(750);
            //if (IsElementVisible(PageObject_Registration.RegisterconfirmationPopup()).Equals(true))
            //{
            //    PageObject_Registration.RegisterconfirmationPopup().Click();
            //}
            Logger.WriteDebugMessage("Entered Address Details");
            if (country == "Canada")
            {
                Driver.FindElement(By.XPath("(//button[@type='button'])[3]")).Click();
            }
            PageObject_Registration.RegisterWorkPhonePrefix().SendKeys(Constants.Common_Registration_WorkPhonePrefix);
            AddDelay(1000);
            PageObject_Registration.RegisterWorkPhoneAreaCode().SendKeys(Constants.Common_Registration_WorkPhoneAreaCode);
            AddDelay(100);
            PageObject_Registration.RegisterWorkPhoneFirst3().SendKeys(Constants.Common_Registration_WorkPhoneFirstThree);
            AddDelay(1000);
            PageObject_Registration.RegisterWorkPhoneLast4().SendKeys(Constants.Common_Registration_WorkPhoneLastFour);
            AddDelay(1000);
            PageObject_Registration.RegisterWorkExtension().SendKeys(Constants.Common_Registration_WorkPhoneExtension);
            AddDelay(1000);
            PageObject_Registration.RegisterHomePhonePrefix().SendKeys(Constants.Common_Registration_HomePhonePrefix);
            AddDelay(1000);
            PageObject_Registration.RegisterHomePhoneAreaCode().SendKeys(Constants.Common_Registration_HomePhoneAreaCode);
            AddDelay(1000);
            PageObject_Registration.RegisterHomePhoneFirst3().SendKeys(Constants.Common_Registration_HomePhoneFirstThree);
            AddDelay(1000);
            PageObject_Registration.RegisterHomePhoneLast4().SendKeys(Constants.Common_Registration_HomePhoneLastFour);
            AddDelay(1000);
            PageObject_Registration.RegisterMobilePhonePrefix().SendKeys(Constants.Common_Registration_MobilePhonePrefix);
            AddDelay(1000);
            PageObject_Registration.RegisterMobilePhoneAreaCode().SendKeys(Constants.Common_Registration_MobilePhoneAreaCode);
            AddDelay(1000);
            PageObject_Registration.RegisterMobilePhoneFirst3().SendKeys(Constants.Common_Registration_MobilePhoneFirstThree);
            AddDelay(1000);
            PageObject_Registration.RegisterMobilePhoneLast4().SendKeys(Constants.Common_Registration_MobilePhoneLastFour);
            AddDelay(1000);
            PageObject_Registration.RegisterFaxPhonePrefix().SendKeys(Constants.Common_Registration_FaxPhonePrefix);
            AddDelay(1000);
            PageObject_Registration.RegisterFaxPhoneAreaCode().SendKeys(Constants.Common_Registration_FaxPhoneAreaCode);
            AddDelay(1000);
            PageObject_Registration.RegisterFaxPhoneFirst3().SendKeys(Constants.Common_Registration_FaxPhoneFirstThree);
            AddDelay(1000);
            PageObject_Registration.RegisterFaxPhoneLast4().SendKeys(Constants.Common_Registration_FaxPhoneLastFour);
            AddDelay(1000);
            while (PageObject_Registration.RegisterWorkPhoneAreaCode().GetAttribute("value") == "")
            {
                PageObject_Registration.RegisterWorkPhoneAreaCode().SendKeys(Constants.Common_Registration_WorkPhoneAreaCode);
                AddDelay(100);
            }

            while (PageObject_Registration.RegisterWorkPhoneFirst3().GetAttribute("value") == "")
            {
                PageObject_Registration.RegisterWorkPhoneFirst3().SendKeys(Constants.Common_Registration_WorkPhoneFirstThree);
                AddDelay(1000);
            }

            while (PageObject_Registration.RegisterWorkPhoneLast4().GetAttribute("value") == "")
            {
                PageObject_Registration.RegisterWorkPhoneLast4().SendKeys(Constants.Common_Registration_WorkPhoneLastFour);
                AddDelay(1000);
            }
            Logger.WriteDebugMessage("Entered Contact Details");
        }

        /* This method will fill in all the registration fields for a Canadian user  */
        public static void DefaultRegistrationCanada()
        {

            RegEmail = EmailNow();

            AddDelay(1500);
            ElementEnterText(PageObject_Registration.RegisterEmail(), RegEmail);
            AddDelay(750);
            ElementEnterText(PageObject_Registration.RegisterConfirmEmail(), RegEmail);
            AddDelay(750);
            ElementEnterText(PageObject_Registration.RegisterPassword(), Constants.Common_Registration_Password);
            AddDelay(750);
            ElementEnterText(PageObject_Registration.RegisterConfirmPassword(), Constants.Common_Registration_ConfirmPassword);
            AddDelay(750);
            ElementSelectFromDropDown(PageObject_Registration.RegisterSecurityQuestion(), Constants.Common_Registration_SecurityQuestion);
            AddDelay(750);
            ElementEnterText(PageObject_Registration.RegisterSecurityAnswer(), Constants.Common_Registration_SecurityAnswer);
            AddDelay(750);
            ScrollToElement(PageObject_Registration.RegisterCountry());
            ElementSelectFromDropDown(PageObject_Registration.RegisterCountry(), "Canada");
            AddDelay(750);
            ElementSelectFromDropDown(PageObject_Registration.RegisterLanguage(), Constants.Common_Registration_Language);
            AddDelay(750);
            ElementSelectFromDropDown(PageObject_Registration.RegisterTitle(), Constants.Common_Registration_Title);
            AddDelay(750);
            ElementEnterText(PageObject_Registration.RegisterFirstName(), Constants.Common_Registration_FirstName);
            AddDelay(750);
            ElementEnterText(PageObject_Registration.RegisterLastName(), Constants.Common_Registration_LastName);
            AddDelay(750);
            ElementSelectFromDropDown(PageObject_Registration.RegisterBirthdayMonth(), Constants.Common_Registration_BirthdayMonth);
            AddDelay(750);
            ElementSelectFromDropDown(PageObject_Registration.RegisterBirthdayDay(), Constants.Common_Registration_BirthdayDay);
            AddDelay(750);
            ElementEnterText(PageObject_Registration.RegisterAddress1(), "25 Sheppard Ave West");
            AddDelay(750);
            ElementEnterText(PageObject_Registration.RegisterAddress2(), "Suite 300");
            AddDelay(750);
            ElementEnterText(PageObject_Registration.RegisterCity(), "Toronto");
            AddDelay(750);
            ElementEnterText(PageObject_Registration.RegisterProvince(), "Ontario");
            AddDelay(750);
            ElementEnterText(PageObject_Registration.RegisterZip(), "M2N 6S6");
            AddDelay(750);
            ElementEnterText(PageObject_Registration.RegisterWorkPhonePrefix(), Constants.Common_Registration_WorkPhonePrefix);
            AddDelay(1000);
            ElementEnterText(PageObject_Registration.RegisterWorkPhoneAreaCode(), Constants.Common_Registration_WorkPhoneAreaCode);
            AddDelay(100);
            ElementEnterText(PageObject_Registration.RegisterWorkPhoneFirst3(), Constants.Common_Registration_WorkPhoneFirstThree);
            AddDelay(1000);
            ElementEnterText(PageObject_Registration.RegisterWorkPhoneLast4(), Constants.Common_Registration_WorkPhoneLastFour);
            AddDelay(1000);
            ElementEnterText(PageObject_Registration.RegisterWorkExtension(), Constants.Common_Registration_WorkPhoneExtension);
            AddDelay(1000);
            ElementEnterText(PageObject_Registration.RegisterHomePhonePrefix(), Constants.Common_Registration_HomePhonePrefix);
            AddDelay(1000);
            ElementEnterText(PageObject_Registration.RegisterHomePhoneAreaCode(), Constants.Common_Registration_HomePhoneAreaCode);
            AddDelay(1000);
            ElementEnterText(PageObject_Registration.RegisterHomePhoneFirst3(), Constants.Common_Registration_HomePhoneFirstThree);
            AddDelay(1000);
            ElementEnterText(PageObject_Registration.RegisterHomePhoneLast4(), Constants.Common_Registration_HomePhoneLastFour);
            AddDelay(1000);
            ElementEnterText(PageObject_Registration.RegisterMobilePhonePrefix(), Constants.Common_Registration_MobilePhonePrefix);
            AddDelay(1000);
            ElementEnterText(PageObject_Registration.RegisterMobilePhoneAreaCode(), Constants.Common_Registration_MobilePhoneAreaCode);
            AddDelay(1000);
            ElementEnterText(PageObject_Registration.RegisterMobilePhoneFirst3(), Constants.Common_Registration_MobilePhoneFirstThree);
            AddDelay(1000);
            ElementEnterText(PageObject_Registration.RegisterMobilePhoneLast4(), Constants.Common_Registration_MobilePhoneLastFour);
            AddDelay(1000);
            ElementEnterText(PageObject_Registration.RegisterFaxPhonePrefix(), Constants.Common_Registration_FaxPhonePrefix);
            AddDelay(1000);
            ElementEnterText(PageObject_Registration.RegisterFaxPhoneAreaCode(), Constants.Common_Registration_FaxPhoneAreaCode);
            AddDelay(1000);
            ElementEnterText(PageObject_Registration.RegisterFaxPhoneFirst3(), Constants.Common_Registration_FaxPhoneFirstThree);
            AddDelay(1000);
            ElementEnterText(PageObject_Registration.RegisterFaxPhoneLast4(), Constants.Common_Registration_FaxPhoneLastFour);
            AddDelay(1000);
            ElementEnterText(PageObject_Registration.RegisterIATA(), Constants.Common_Registration_IATA);
            AddDelay(750);
            ElementEnterText(PageObject_Registration.RegisterARC(), Constants.Common_Registration_ARC);
            AddDelay(750);
            ElementEnterText(PageObject_Registration.RegisterCLIA(), Constants.Common_Registration_CLIA);
            AddDelay(750);
            ElementEnterText(PageObject_Registration.RegisterTRU(), Constants.Common_Registration_TRU);
            AddDelay(750);
            ElementEnterText(PageObject_Registration.RegisterACTA(), Constants.Common_Registration_ACTA);
            AddDelay(750);
            ElementEnterText(PageObject_Registration.RegisterTIDS(), Constants.Common_Registration_TIDS);
            AddDelay(750);
            ElementEnterText(PageObject_Registration.RegisterTICO(), Constants.Common_Registration_TICO);
            AddDelay(750);
            ElementEnterText(PageObject_Registration.RegisterABTA(), Constants.Common_Registration_ABTA);
            AddDelay(750);
            ElementEnterText(PageObject_Registration.RegisterATOL(), Constants.Common_Registration_ATOL);
            AddDelay(750);

            if (Constants.Common_Registration_RetailAgency == "Yes")
            {
                MakeSureIsChecked(PageObject_Registration.RegisterRetailAgency());
                AddDelay(500);

            }

            if (Constants.Common_Registration_RemoteHomeBased == "Yes")
            {
                MakeSureIsChecked(PageObject_Registration.RegisterRemoteHomeBased());
                AddDelay(500);
            }

            if (Constants.Common_Registration_TourOperatorWholesaler == "Yes")
            {
                MakeSureIsChecked(PageObject_Registration.RegisterTourOperatorWholesaler());
                AddDelay(500);
            }

            if (Constants.Common_Registration_MeetingPlanner == "Yes")
            {
                MakeSureIsChecked(PageObject_Registration.RegisterMeetingPlanner());
                AddDelay(500);
            }

            if (Constants.Common_Registration_DestinationWeddingSpecialist == "Yes")
            {
                MakeSureIsChecked(PageObject_Registration.RegisterDestinationWeddingSpecialist());
                AddDelay(500);
            }


            PageObject_Registration.RegisterAffiliation().SendKeys(Constants.Common_Registration_Affiliation);
            AddDelay(500);

        }

        public static void ReassignAffiliations()
        {
            Constants.Common_Registration_IATA = PageObject_Registration.RegisterIATA().Text;
            Constants.Common_Registration_ARC = PageObject_Registration.RegisterARC().Text;
            Constants.Common_Registration_CLIA = PageObject_Registration.RegisterCLIA().Text;
            Constants.Common_Registration_TRU = PageObject_Registration.RegisterTRU().Text;
            Constants.Common_Registration_ACTA = PageObject_Registration.RegisterACTA().Text;
            Constants.Common_Registration_TIDS = PageObject_Registration.RegisterTIDS().Text;
            Constants.Common_Registration_TICO = PageObject_Registration.RegisterTICO().Text;
            Constants.Common_Registration_ABTA = PageObject_Registration.RegisterABTA().Text;
            Constants.Common_Registration_ATOL = PageObject_Registration.RegisterATOL().Text;

        }

        /* This method adds the date and time to an email to make it unique */
        public static string EmailNow()
        {
            string email = MakeCatchAllUnique(Constants.Common_Registration_Email);
            RegEmail = email;
            //thisDay = DateTime.Now;
            //string[] splitEmail = TestData.Common_Registration_Email.Split('@');
            //string email = splitEmail[0] + "+" + thisDay.ToString(@"yyyy-MM-dd") + "_" + thisDay.Hour + "-" + thisDay.Minute + "@" + splitEmail[1];
            return email;
        }

        public static void GetRegValues()
        {

            RegEmail = PageObject_Registration.RegisterEmail().GetAttribute("value");
            RegCountry = PageObject_Registration.RegisterCountry().GetAttribute("value");
            RegLanguage = PageObject_Registration.RegisterLanguage().GetAttribute("value");
            RegTitle = PageObject_Registration.RegisterTitle().GetAttribute("value");
            RegFirstName = PageObject_Registration.RegisterFirstName().GetAttribute("value");
            RegLastName = PageObject_Registration.RegisterLastName().GetAttribute("value");
            RegBirthdayMonth = PageObject_Registration.RegisterBirthdayMonth().GetAttribute("value");
            RegBirthdayDay = PageObject_Registration.RegisterBirthdayDay().GetAttribute("value");
            RegAddress1 = PageObject_Registration.RegisterAddress1().GetAttribute("value");
            RegAddress2 = PageObject_Registration.RegisterAddress2().GetAttribute("value");
            RegCity = PageObject_Registration.RegisterCity().GetAttribute("value");
            if (PageObject_Registration.RegisterCountry().GetAttribute("value") == "United States")
            {
                RegStateProvince = PageObject_Registration.RegisterState().GetAttribute("value");
            }
            else if (PageObject_Registration.RegisterCountry().GetAttribute("value") == "Canada")
            {
                RegStateProvince = PageObject_Registration.RegisterProvince().GetAttribute("value");
            }
            RegZip = PageObject_Registration.RegisterZip().GetAttribute("value");
            RegWorkPrefix = PageObject_Registration.RegisterWorkPhonePrefix().GetAttribute("value");
            RegWorkAreaCode = PageObject_Registration.RegisterWorkPhoneAreaCode().GetAttribute("value");
            RegWorkFirst3 = PageObject_Registration.RegisterWorkPhoneFirst3().GetAttribute("value");
            RegWorkLast4 = PageObject_Registration.RegisterWorkPhoneLast4().GetAttribute("value");
            RegWorkExtension = PageObject_Registration.RegisterWorkExtension().GetAttribute("value");
            RegHomePrefix = PageObject_Registration.RegisterHomePhonePrefix().GetAttribute("value");
            RegHomeAreaCode = PageObject_Registration.RegisterHomePhoneAreaCode().GetAttribute("value");
            RegHomeFirst3 = PageObject_Registration.RegisterHomePhoneFirst3().GetAttribute("value");
            RegHomeLast4 = PageObject_Registration.RegisterHomePhoneLast4().GetAttribute("value");
            RegMobilePrefix = PageObject_Registration.RegisterMobilePhonePrefix().GetAttribute("value");
            RegMobileAreaCode = PageObject_Registration.RegisterMobilePhoneAreaCode().GetAttribute("value");
            RegMobileFirst3 = PageObject_Registration.RegisterMobilePhoneFirst3().GetAttribute("value");
            RegMobileLast4 = PageObject_Registration.RegisterMobilePhoneLast4().GetAttribute("value");
            RegFaxPrefix = PageObject_Registration.RegisterFaxPhonePrefix().GetAttribute("value");
            RegFaxAreaCode = PageObject_Registration.RegisterFaxPhoneAreaCode().GetAttribute("value");
            RegFaxFirst3 = PageObject_Registration.RegisterFaxPhoneFirst3().GetAttribute("value");
            RegFaxLast4 = PageObject_Registration.RegisterFaxPhoneLast4().GetAttribute("value");
            RegIATA = PageObject_Registration.RegisterIATA().GetAttribute("value");
            RegARC = PageObject_Registration.RegisterARC().GetAttribute("value");
            RegCLIA = PageObject_Registration.RegisterCLIA().GetAttribute("value");
            RegTRU = PageObject_Registration.RegisterTRU().GetAttribute("value");
            RegACTA = PageObject_Registration.RegisterACTA().GetAttribute("value");
            RegTIDS = PageObject_Registration.RegisterTIDS().GetAttribute("value");
            RegTICO = PageObject_Registration.RegisterTICO().GetAttribute("value");
            RegABTA = PageObject_Registration.RegisterABTA().GetAttribute("value");
            RegATOL = PageObject_Registration.RegisterATOL().GetAttribute("value");

            if (PageObject_Registration.RegisterRetailAgency().Selected)
            {
                RegRetailAgency = "Yes";
            }
            else
                RegRetailAgency = "No";

            if (PageObject_Registration.RegisterRemoteHomeBased().Selected)
            {
                RegRemoteHomeBased = "Yes";
            }
            else
                RegRemoteHomeBased = "No";

            if (PageObject_Registration.RegisterTourOperatorWholesaler().Selected)
            {
                RegTourOperatorWholesaler = "Yes";
            }
            else
                RegTourOperatorWholesaler = "No";

            if (PageObject_Registration.RegisterMeetingPlanner().Selected)
            {
                RegMeetingPlanner = "Yes";
            }
            else
                RegMeetingPlanner = "No";

            if (PageObject_Registration.RegisterDestinationWeddingSpecialist().Selected)
            {
                RegDestinationWeddingSpecialist = "Yes";
            }
            else
                RegDestinationWeddingSpecialist = "No";

            RegAffiliation = PageObject_Registration.RegisterAffiliation().GetAttribute("value");

            Logger.WriteInfoMessage("All Registration values are stored.");

        }

        public static void EnterIATA(string IATA)
        {
            AddDelay(1000);
            PageObject_Registration.RegisterIATA().SendKeys(IATA);
            AddDelay(1000);
            Logger.WriteInfoMessage("Entered the IATA code: " + IATA);
        }

        public static void EnterCLIA(string CLIA)
        {
            AddDelay(1000);
            PageObject_Registration.RegisterCLIA().SendKeys(CLIA);
            AddDelay(1000);
            Logger.WriteInfoMessage("Entered the CLIA code: " + CLIA);
        }

        public static void EnterARC(string ARC)
        {
            AddDelay(1000);
            PageObject_Registration.RegisterARC().SendKeys(ARC);
            AddDelay(1000);
            Logger.WriteInfoMessage("Entered the ARC code: " + ARC);
        }

        public static void EnterTRU(string TRU)
        {
            AddDelay(1000);
            PageObject_Registration.RegisterTRU().SendKeys(TRU);
            AddDelay(1000);
            Logger.WriteInfoMessage("Entered the TRU code: " + TRU);
        }

        public static void EnterTIDS(string TIDS)
        {
            AddDelay(1000);
            PageObject_Registration.RegisterTIDS().SendKeys(TIDS);
            AddDelay(1000);
            Logger.WriteInfoMessage("Entered the TIDS code: " + TIDS);
        }

        public static void EnterTICO(string TICO)
        {
            AddDelay(1000);
            PageObject_Registration.RegisterTICO().SendKeys(TICO);
            AddDelay(1000);
            Logger.WriteInfoMessage("Entered the TICO code: " + TICO);
        }

        public static void ConfirmSuccessfulRegistration()
        {
            //Click "Register"
            ScrollToElement(PageObject_Registration.RegisterRegisterButton());
            AddDelay(15000);
            PageObject_Registration.RegisterRegisterButton().Click();
            Logger.WriteDebugMessage("Clicked 'Register'.");
            AddDelay(10000);

            //Click "OK"
            WaittillElementDisplay(PageObject_Registration.RegisterRegistrationCompleteButton());
            if(TestPlanId == "TP_273216")
                Driver.Navigate().GoToUrl(Constants.Common_PostDeploymentFrontendURL);
            else
                Driver.Navigate().GoToUrl(Constants.Common_FrontendURL);
            Logger.WriteDebugMessage("Registered successfully.");

            //Added by Divya : 21 August 2017 : Added AcceptPopup()
            //Click the "Enroll Me" checkbox and click "Accept"
            // 09/14 Marc : Added the try catch. This method was failing others.
            try
            {
                var alert = PageObject_AMRewards.AMRRewardsEnrollMeCheckbox().Displayed;
                if (alert.Equals(true))
                {
                    AMRRewards.AcceptPopup();
                }
            }
            catch (Exception)
            {

            }

            //Click "Update Profile"
            PageObject_AMRAgentsNav.AMRAgentsUpdateProfile().Click();
            PageDown();
            Logger.WriteDebugMessage("Clicked 'Update Profile'.");
            AddDelay(5000);

            //Verify the "AMRewards" menu
            if (IsElementVisible(PageObject_AMRAgentsNav.AMRAgentsAMRewards()))
            {
                Logger.WriteDebugMessage("AMR Rewards was found on the page.");
            }
            else
            {
                Logger.WriteFatalMessage("AMR Rewards was not found on the page.");
                Assert.Fail();
            }

            //Click "Cancel"
            ScrollToElement(PageObject_UpdateProfile.UpdateProfileCancel());
            PageObject_UpdateProfile.UpdateProfileCancel().Click();
            Logger.WriteDebugMessage("Clicked the 'Cancel' button and landed on the AMR Rewards home page");

            AddDelay(5000);
            //Click "AMRewards"
            PageObject_AMRAgentsNav.AMRAgentsAMRewards().Click();
            Logger.WriteDebugMessage("Clicked the 'AMR Rewards' link.");

            //Editted by Divya : 21 August 2017 : Commented the Accept popup Method
            //Click the "Enroll Me" checkbox and click "Accept"
            var alert1 = PageObject_AMRewards.AMRRewardsEnrollMeCheckbox().Displayed;
            if (alert1.Equals(true))
            {
                AMRRewards.AcceptPopup();
            }

            if (!PageObject_AMRewards.AMRRewardsPopupAccept().Displayed)
            {
                Logger.WriteDebugMessage("Clicked the 'Enroll Me' checkbox.");
            }
            else
            {
                Logger.WriteFatalMessage("The 'Welcome to Loyallty' program' popup is still displayed after accepting.");
                Assert.Fail();
            }

            //Click "Log Off" and make sure we landed on the login screen.
            PageObject_AMRAgentsNav.AMRAgentsLogOff().Click();
            if (IsElementVisible(PageObject_Login.LoginEmail()))
            {
                Logger.WriteDebugMessage("Landed on the login page.");
            }
            else
            {
                Logger.WriteFatalMessage("Did not log out after clicking 'Log Out'.");
                Assert.Fail();
            }
        }

        public static void ConfirmRegistrationOnAdmin()
        {
            //Goto the admin site
            Driver.Navigate().GoToUrl(Constants.Common_AdminURL);
            AddDelay(1000);
            HandleUnSafeWindows();
            Logger.WriteInfoMessage("Landed on the Admin login page.");

            try
            {
                if (!Driver.FindElement(By.Id("logoutForm")).Displayed)
                {

                }
            }
            catch (Exception)
            {

                //Log in to Admin
                //Enter the login email and password.
                AddDelay(5000);
                PageObject_AdminLogin.AdminLoginEmail().SendKeys(Constants.Common_AdminEmail);
                AddDelay(2000);
                PageObject_AdminLogin.AdminLoginPassword().SendKeys(Constants.Common_AdminPassword);
                AddDelay(2000);
                Logger.WriteDebugMessage("Admin Email and Password entered");

                //Click "Sign In"
                PageObject_AdminLogin.AdminLoginSignIn().Click();
                AddDelay(10000);
                Logger.WriteDebugMessage("Logged into admin successfully.");
            }
            //Navigate to the "Edit Profile"

            PageObject_AdminHome.AdminHomeManageProfile().Click();
            AddDelay(10000);
            PageObject_AdminManageProfiles.AdminManageProfilesValidatedProfilesTab().Click();
            Logger.WriteInfoMessage("Clicked Validated Profiles");
            AddDelay(7500);
            PageObject_AdminValidatedProfiles.AdminValidatedProfilesSearch().SendKeys(RegEmail);
            AddDelay(1000);
            PageObject_AdminValidatedProfiles.AdminValidatedProfilesSearch().SendKeys(Keys.Enter);
            Logger.WriteInfoMessage("Searching for " + RegEmail);
            AddDelay(5000);
            PageObject_AdminValidatedProfiles.AdminValidatedProfilesEditProfile(RegEmail).Click();
            AddDelay(2500);
            PageDown();
            Logger.WriteDebugMessage("Landed on the 'Update Profile' page.");

        }
        public static void ConfirmRegistrationOnProdAdmin()
        {
            //Goto the admin site
            Driver.Navigate().GoToUrl(Constants.Common_PostDeploymentAdminURL);
            AddDelay(1000);
            Logger.WriteInfoMessage("Landed on the Admin login page.");

            try
            {
                if (!Driver.FindElement(OpenQA.Selenium.By.Id("logoutForm")).Displayed)
                {

                }
            }
            catch (Exception)
            {

                //Log in to Admin
                //Enter the login email and password.
                AddDelay(5000);
                PageObject_AdminLogin.AdminLoginEmail().SendKeys(Constants.Common_PostDeploymentAdminEmail);
                AddDelay(2000);
                PageObject_AdminLogin.AdminLoginPassword().SendKeys(Constants.Common_AdminPassword);
                AddDelay(2000);

                //Click "Sign In"
                PageObject_AdminLogin.AdminLoginSignIn().Click();
                AddDelay(10000);
                Logger.WriteDebugMessage("Logged into admin successfully.");
            }
            //Navigate to the "Edit Profile"
            PageObject_AdminHome.AdminHomeManageProfile().Click();
            AddDelay(10000);
            PageObject_AdminManageProfiles.AdminManageProfilesValidatedProfilesTab().Click();
            Logger.WriteInfoMessage("Clicked Validated Profiles");
            AddDelay(7500);
            PageObject_AdminValidatedProfiles.AdminValidatedProfilesSearch().SendKeys(RegEmail);
            AddDelay(1000);
            PageObject_AdminValidatedProfiles.AdminValidatedProfilesSearch().SendKeys(Keys.Enter);
            Logger.WriteInfoMessage("Searching for " + RegEmail);
            AddDelay(5000);
            PageObject_AdminValidatedProfiles.AdminValidatedProfilesEditProfile(RegEmail).Click();
            AddDelay(2500);
            Logger.WriteDebugMessage("Landed on the 'Update Profile' page.");
        }


    }
}
