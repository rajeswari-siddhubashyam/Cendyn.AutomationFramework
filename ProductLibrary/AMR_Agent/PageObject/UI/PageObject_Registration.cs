using AMR_Agent.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace AMR_Agent.PageObject.UI
{
    class PageObject_Registration : Setup
    {
        /*
        / These methods will return the element on the page by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
        */

        public static IWebElement RegisterEmail()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterEmail);
        }
        public static IWebElement RegisterConfirmEmail()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterConfirmEmail);
        }
        public static IWebElement RegisterPassword()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterPassword);
        }
        public static IWebElement RegisterConfirmPassword()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterConfirmPassword);
        }
        public static IWebElement RegisterSecurityQuestion()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterSecurityQuestion);
        }
        public static IWebElement RegisterSecurityAnswer()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterSecurityAnswer);
        }

        public static IWebElement RegisterCountry()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterCountry);
        }
        public static IWebElement RegisterLanguage()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterLanguage);
        }
        public static IWebElement RegisterTitle()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterTitle);
        }
        public static IWebElement RegisterFirstName()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterFirstName);
        }
        public static IWebElement RegisterLastName()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterLastName);
        }
        public static IWebElement RegisterBirthdayMonth()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterBirthdayMonth);
        }
        public static IWebElement RegisterBirthdayDay()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterBirthdayDay);
        }
        public static IWebElement RegisterAddress1()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterAddress1);
        }
        public static IWebElement RegisterAddress2()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterAddress2);
        }
        public static IWebElement RegisterCity()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterCity);
        }
        public static IWebElement RegisterState()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterState);
        }
        public static IWebElement RegisterProvince()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterProvince);
        }
        public static IWebElement RegisterZip()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterZip);
        }
        public static IWebElement RegisterWorkPhonePrefix()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterWorkPhonePrefix);
        }
        public static IWebElement RegisterWorkPhoneAreaCode()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterWorkPhoneAreaCode);
        }
        public static IWebElement RegisterWorkPhoneFirst3()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterWorkPhoneFirst3);
        }
        public static IWebElement RegisterWorkPhoneLast4()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterWorkPhoneLast4);
        }
        public static IWebElement RegisterWorkExtension()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterWorkExtension);
        }
        public static IWebElement RegisterHomePhonePrefix()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterHomePhonePrefix);
        }
        public static IWebElement RegisterHomePhoneAreaCode()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterHomePhoneAreaCode);
        }
        public static IWebElement RegisterHomePhoneFirst3()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterHomePhoneFirst3);
        }
        public static IWebElement RegisterHomePhoneLast4()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterHomePhoneLast4);
        }
        public static IWebElement RegisterMobilePhonePrefix()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterMobilePhonePrefix);
        }
        public static IWebElement RegisterMobilePhoneAreaCode()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterMobilePhoneAreaCode);
        }
        public static IWebElement RegisterMobilePhoneFirst3()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterMobilePhoneFirst3);
        }
        public static IWebElement RegisterMobilePhoneLast4()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterMobilePhoneLast4);
        }
        public static IWebElement RegisterFaxPhonePrefix()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterFaxPhonePrefix);
        }
        public static IWebElement RegisterFaxPhoneAreaCode()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterFaxPhoneAreaCode);
        }
        public static IWebElement RegisterFaxPhoneFirst3()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterFaxPhoneFirst3);
        }
        public static IWebElement RegisterFaxPhoneLast4()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterFaxPhoneLast4);
        }
        public static IWebElement RegisterIATA()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterIATA);
        }
        public static IWebElement RegisterARC()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterARC);
        }
        public static IWebElement RegisterCLIA()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterCLIA);
        }
        public static IWebElement RegisterTRU()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterTRU);
        }
        public static IWebElement RegisterACTA()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterACTA);
        }
        public static IWebElement RegisterTIDS()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterTIDS);
        }
        public static IWebElement RegisterTICO()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterTICO);
        }
        public static IWebElement RegisterABTA()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterABTA);
        }
        public static IWebElement RegisterATOL()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterATOL);
        }
        public static IWebElement RegisterRetailAgency()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterRetailAgency);
        }
        public static IWebElement RegisterRemoteHomeBased()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterRemoteHomeBased);
        }
        public static IWebElement RegisterTourOperatorWholesaler()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterTourOperatorWholesaler);
        }
        public static IWebElement RegisterMeetingPlanner()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterMeetingPlanner);
        }
        public static IWebElement RegisterDestinationWeddingSpecialist()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterDestinationWeddingSpecialist);
        }
        public static IWebElement RegisterAffiliation()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterAffiliation);
        }
        public static IWebElement RegisterRegisterButton()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementXPath(ObjectRepository.RegisterRegisterButton);
        }
        public static IWebElement RegisterCancel()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementId(ObjectRepository.RegisterCancel);
        }
        public static IWebElement RegisterRegistrationCompleteButton()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementClassName(ObjectRepository.RegisterRegistrationCompleteButton);
        }
        public static IWebElement RegisterRegistrationEnrollMe()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementXPath(ObjectRepository.Register_RegistrationEnroll_Me);
        }
        public static IWebElement Register_RegistrationAccept()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementXPath(ObjectRepository.Register_RegistrationAccept);
        }
        public static IWebElement RegisterconfirmationPopup()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementXPath("//span[contains(text(),'Yes, I want to use this address')]");
        }
        public static IWebElement Register_AddressSuggestionPopup_ClickYes()
        {
            ScanPage(Constants.ModuleRegistration);
            return PageAction.Find_ElementXPath(ObjectRepository.Register_AddressSuggestionPopup_ClickYes);
        }
    }

}
