using AMR_Agent.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace AMR_Agent.PageObject.UI
{
    class PageObject_UpdateProfile : Setup
    {
        /*
        / These methods will return the element on the page by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
        */

        public static IWebElement UpdateProfileEmail()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileEmail);
        }
        public static IWebElement UpdateProfileConfirmEmail()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileConfirmEmail);
        }
        public static IWebElement UpdateProfileSecurityQuestion()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileSecurityQuestion);
        }
        public static IWebElement UpdateProfileSecurityAnswer()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileSecurityAnswer);
        }
        public static IWebElement UpdateProfileCountry()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileCountry);
        }
        public static IWebElement UpdateProfileLanguage()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileLanguage);
        }
        public static IWebElement UpdateProfileTitle()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileTitle);
        }
        public static IWebElement UpdateProfileFirstName()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileFirstName);
        }
        public static IWebElement UpdateProfileLastName()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileLastName);
        }
        public static IWebElement UpdateProfileBirthdayMonth()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileBirthdayMonth);
        }
        public static IWebElement UpdateProfileBirthdayDay()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileBirthdayDay);
        }
        public static IWebElement UpdateProfileAddress1()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileAddress1);
        }
        public static IWebElement UpdateProfileAddress2()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileAddress2);
        }
        public static IWebElement UpdateProfileCity()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileCity);
        }
        public static IWebElement UpdateProfileState()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileState);
        }
        public static IWebElement UpdateProfileProvince()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileProvince);
        }
        public static IWebElement UpdateProfileZip()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileZip);
        }
        public static IWebElement UpdateProfileWorkPhonePrefix()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileWorkPhonePrefix);
        }
        public static IWebElement UpdateProfileWorkPhoneAreaCode()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileWorkPhoneAreaCode);
        }
        public static IWebElement UpdateProfileWorkPhoneFirst3()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileWorkPhoneFirst3);
        }
        public static IWebElement UpdateProfileWorkPhoneLast4()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileWorkPhoneLast4);
        }
        public static IWebElement UpdateProfileWorkExtension()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileWorkExtension);
        }
        public static IWebElement UpdateProfileHomePhonePrefix()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileHomePhonePrefix);
        }
        public static IWebElement UpdateProfileHomePhoneAreaCode()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileHomePhoneAreaCode);
        }
        public static IWebElement UpdateProfileHomePhoneFirst3()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileHomePhoneFirst3);
        }
        public static IWebElement UpdateProfileHomePhoneLast4()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileHomePhoneLast4);
        }
        public static IWebElement UpdateProfileMobilePhonePrefix()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileMobilePhonePrefix);
        }
        public static IWebElement UpdateProfileMobilePhoneAreaCode()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileMobilePhoneAreaCode);
        }
        public static IWebElement UpdateProfileMobilePhoneFirst3()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileMobilePhoneFirst3);
        }
        public static IWebElement UpdateProfileMobilePhoneLast4()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileMobilePhoneLast4);
        }
        public static IWebElement UpdateProfileFaxPhonePrefix()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileFaxPhonePrefix);
        }
        public static IWebElement UpdateProfileFaxPhoneAreaCode()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileFaxPhoneAreaCode);
        }
        public static IWebElement UpdateProfileFaxPhoneFirst3()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileFaxPhoneFirst3);
        }
        public static IWebElement UpdateProfileFaxPhoneLast4()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileFaxPhoneLast4);
        }
        public static IWebElement UpdateProfileIATA()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileIATA);
        }
        public static IWebElement UpdateProfileARC()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileARC);
        }
        public static IWebElement UpdateProfileCLIA()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileCLIA);
        }
        public static IWebElement UpdateProfileTRU()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileTRU);
        }
        public static IWebElement UpdateProfileACTA()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileACTA);
        }
        public static IWebElement UpdateProfileTIDS()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileTIDS);
        }
        public static IWebElement UpdateProfileTICO()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileTICO);
        }
        public static IWebElement UpdateProfileABTA()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileABTA);
        }
        public static IWebElement UpdateProfileATOL()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileATOL);
        }
        public static IWebElement UpdateProfileRetailAgency()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileRetailAgency);
        }
        public static IWebElement UpdateProfileRemoteHomeBased()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileRemoteHomeBased);
        }
        public static IWebElement UpdateProfileTourOperatorWholesaler()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileTourOperatorWholesaler);
        }
        public static IWebElement UpdateProfileMeetingPlanner()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileMeetingPlanner);
        }
        public static IWebElement UpdateProfileDestinationWeddingSpecialist()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileDestinationWeddingSpecialist);
        }
        public static IWebElement UpdateProfileAffiliation()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileAffiliation);
        }
        public static IWebElement UpdateProfileUpdateProfileButton()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementId(ObjectRepository.UpdateProfileUpdateProfileButton);
        }
        public static IWebElement UpdateProfileCancel()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementClassName(ObjectRepository.UpdateProfileCancel);
        }
        public static IWebElement UpdateProfileUpdateCompleteButton()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementClassName(ObjectRepository.UpdateProfileUpdateCompleteButton);
        }
        public static IWebElement UpdateProfileW9WarningPopupText()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementXPath(ObjectRepository.UpdateProfileW9WarningPopupText);
        }
        public static IWebElement UpdateProfileW9WarningPopupButton()
        {
            ScanPage(Constants.ModuleUpdateProfile);
            return PageAction.Find_ElementXPath(ObjectRepository.UpdateProfileW9WarningPopupButton);
        }    

    }
}
