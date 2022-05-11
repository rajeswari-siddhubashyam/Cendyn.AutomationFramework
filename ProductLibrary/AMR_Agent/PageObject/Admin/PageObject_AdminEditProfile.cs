using AMR_Agent.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace AMR_Agent.PageObject.Admin
{
    class PageObject_AdminEditProfile : Utility.Setup
    {
        /*
        / These methods will return the element on the page by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
        */

        public static IWebElement AdminEditProfileEmail()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileEmail);
        }
        public static IWebElement AdminEditProfileCountry()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileCountry);
        }
        public static IWebElement AdminEditProfileLanguage()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileLanguage);
        }
        public static IWebElement AdminEditProfileTitle()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileTitle);
        }
        public static IWebElement AdminEditProfileFirstName()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileFirstName);
        }
        public static IWebElement AdminEditProfileLastName()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileLastName);
        }
        public static IWebElement AdminEditProfileBirthdayMonth()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileBirthdayMonth);
        }
        public static IWebElement AdminEditProfileBirthdayDay()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileBirthdayDay);
        }
        public static IWebElement AdminEditProfileAddress1()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileAddress1);
        }
        public static IWebElement AdminEditProfileAddress2()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileAddress2);
        }
        public static IWebElement AdminEditProfileCity()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileCity);
        }
        public static IWebElement AdminEditProfileState()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileState);
        }

        public static IWebElement AdminEditProfileProvince()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileProvince);
        }
        public static IWebElement AdminEditProfileZip()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileZip);
        }
        public static IWebElement AdminEditProfileWorkPhonePrefix()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileWorkPhonePrefix);
        }
        public static IWebElement AdminEditProfileWorkPhoneAreaCode()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileWorkPhoneAreaCode);
        }
        public static IWebElement AdminEditProfileWorkPhoneFirst3()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileWorkPhoneFirst3);
        }
        public static IWebElement AdminEditProfileWorkPhoneLast4()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileWorkPhoneLast4);
        }
        public static IWebElement AdminEditProfileWorkExtension()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileWorkExtension);
        }
        public static IWebElement AdminEditProfileHomePhonePrefix()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileHomePhonePrefix);
        }
        public static IWebElement AdminEditProfileHomePhoneAreaCode()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileHomePhoneAreaCode);
        }
        public static IWebElement AdminEditProfileHomePhoneFirst3()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileHomePhoneFirst3);
        }
        public static IWebElement AdminEditProfileHomePhoneLast4()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileHomePhoneLast4);
        }
        public static IWebElement AdminEditProfileMobilePhonePrefix()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileMobilePhonePrefix);
        }
        public static IWebElement AdminEditProfileMobilePhoneAreaCode()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileMobilePhoneAreaCode);
        }
        public static IWebElement AdminEditProfileMobilePhoneFirst3()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileMobilePhoneFirst3);
        }
        public static IWebElement AdminEditProfileMobilePhoneLast4()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileMobilePhoneLast4);
        }
        public static IWebElement AdminEditProfileFaxPhonePrefix()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileFaxPhonePrefix);
        }
        public static IWebElement AdminEditProfileFaxPhoneAreaCode()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileFaxPhoneAreaCode);
        }
        public static IWebElement AdminEditProfileFaxPhoneFirst3()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileFaxPhoneFirst3);
        }
        public static IWebElement AdminEditProfileFaxPhoneLast4()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileFaxPhoneLast4);
        }
        public static IWebElement AdminEditProfileIATA()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileIATA);
        }
        public static IWebElement AdminEditProfileARC()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileARC);
        }
        public static IWebElement AdminEditProfileCLIA()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileCLIA);
        }
        public static IWebElement AdminEditProfileTRU()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileTRU);
        }
        public static IWebElement AdminEditProfileACTA()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileACTA);
        }
        public static IWebElement AdminEditProfileTIDS()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileTIDS);
        }
        public static IWebElement AdminEditProfileTICO()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileTICO);
        }
        public static IWebElement AdminEditProfileABTA()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileABTA);
        }
        public static IWebElement AdminEditProfileATOL()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileATOL);
        }
        public static IWebElement AdminEditProfileRetailAgency()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileRetailAgency);
        }
        public static IWebElement AdminEditProfileRemoteHomeBased()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileRemoteHomeBased);
        }
        public static IWebElement AdminEditProfileTourOperatorWholesaler()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileTourOperatorWholesaler);
        }
        public static IWebElement AdminEditProfileMeetingPlanner()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileMeetingPlanner);
        }
        public static IWebElement AdminEditProfileDestinationWeddingSpecialist()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileDestinationWeddingSpecialist);
        }
        public static IWebElement AdminEditProfileAffiliation()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileAffiliation);
        }
        public static IWebElement AdminEditProfileAdminEditProfileButton()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileAdminEditProfileButton);
        }
        public static IWebElement AdminEditProfileCancel()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileCancel);
        }
        public static IWebElement AdminEditProfileMergeProfile()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileMergeProfile);
        }
        public static IWebElement AdminEditProfileUploadPhoto()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileUploadPhoto);
        }
        public static IWebElement AdminEditProfileUploadAgencyLogo()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileUploadAgencyLogo);
        }
        public static IWebElement AdminEditProfileW9()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileW9);
        }
        public static IWebElement AdminEditProfileUpdateCompleteButton()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementId(ObjectRepository.AdminEditProfileUpdateCompleteButton);
        }

        public static IWebElement AdminEditProfileOKButton()
        {
            ScanPage(Constants.ModuleAdminEditProfile);
            return PageAction.Find_ElementXPath("/html/body/div[26]/div[3]/div/button/span");
        }

    }
}
