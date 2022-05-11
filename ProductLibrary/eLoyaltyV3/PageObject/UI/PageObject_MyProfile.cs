using System.Reflection;
using BaseUtility.PageObject;
using eLoyaltyV3.Utility;
using OpenQA.Selenium;

namespace eLoyaltyV3.PageObject.UI
{
    public class PageObject_MyProfile : Setup
    {


        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/
        public static string PageName = Constants.MyProfile;

        public static IWebElement Link_MyPersonalProfile_MyProfile()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Link_MyPersonalProfile_MyProfile);
        }

        public static IWebElement Link_MyPersonalProfile_YourPreferences()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Link_MyPersonalProfile_YourPreferences);
        }

        public static IWebElement Text_MembershipNumber()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Text_MembershipNumber);
        }

        public static IWebElement Text_MembershipType()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Text_MembershipType);
        }

        public static IWebElement DropDown_Title()
        {
            if(ProjectName.Equals("Bartell"))
            {

                ScanPage(Constants.MyProfile);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementId("Questions_5__AnswerValueInt");
            }
            else
            {
                ScanPage(Constants.MyProfile);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_DropDown_Title);
            }            
        }

        public static IWebElement Text_FirstName()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Text_FirstName);
        }

        public static IWebElement Text_LastName()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Text_LastName);
        }

        public static IWebElement Text_CardName()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.MyProfile_Text_CardName);
        }

        public static IWebElement DropDown_Gender()
        {
            if(ProjectName.Equals("Bartell"))
            {
                ScanPage(Constants.MyProfile);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementId("Questions_4__AnswerValueInt");
            }
            else
            {
                ScanPage(Constants.MyProfile);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_DropDown_Gender);
            }
            
        }

        public static IWebElement DropDown_Nationality()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_DropDown_Nationality);
        }

        public static IWebElement DropDown_DateOfBirth()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_DropDown_DateOfBirth);
        }

        public static IWebElement DropDown_Month()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_DropDown_Month);
        }

        public static IWebElement DropDown_Year()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_DropDown_Year);
        }

        public static IWebElement Text_CompanyName()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Text_CompanyName);
        }

        public static IWebElement Text_MobilePhoneNumber()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Text_MobilePhoneNumber);
        }

        public static IWebElement Text_HomePhoneNumber()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Text_HomePhoneNumber);
        }

        public static IWebElement Text_OfficePhoneNumber()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Text_OfficePhoneNumber);
        }

        public static IWebElement Text_FaxPhoneNumber()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Text_FaxPhoneNumber);
        }

        public static IWebElement Text_Address1()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Text_Address1);
        }

        public static IWebElement Text_Address2()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Text_Address2);
        }

        public static IWebElement Text_City()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Text_City);
        }

        public static IWebElement DropDown_StateProvince()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_DropDown_StateProvince);
        }

        public static IWebElement DropDown_CanadaProvince()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId("Provincelist");
        }

        public static IWebElement DropDown_Country()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_DropDown_Country);
        }

        public static IWebElement Text_Zip()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Text_Zip);
        }

        public static IWebElement Text_ZipExtension()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Text_ZipExtension);
        }

        public static IWebElement DropDown_PreferredLanguage()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_DropDown_PreferredLanguage);
        }

        public static IWebElement DropDown_RecommendedBy()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_DropDown_RecommendedBy);
        }

        public static IWebElement Button_Next()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.MyProfile_Button_Next);
        }

        public static IWebElement Link_FraserSuites()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Link_FraserSuites);
        }

        public static IWebElement Link_FraserPlace()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Link_FraserPlace);
        }

        public static IWebElement Link_FraserResidence()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Link_FraserResidence);
        }

        public static IWebElement Link_Modena()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Link_Modena);
        }

        public static IWebElement Link_Malmaison()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Link_Malmaison);
        }

        public static IWebElement Link_Capri()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Link_Capri);
        }

        public static IWebElement Link_HotelDuVin()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Link_HotelDuVin);
        }

        public static IWebElement Link_TermsAndCondition()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Link_TermsAndCondition);
        }

        public static IWebElement Link_FrequentlyAskedQuestions()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Link_FrequentlyAskedQuestions);
        }

        public static IWebElement Link_ContactUs()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Link_ContactUs);
        }

        public static IWebElement Link_TermsOfUse()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Link_TermsOfUse);
        }

        public static IWebElement Link_PrivacyPolicy()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Link_PrivacyPolicy);
        }

        public static IWebElement Link_BestRateGuarantee()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Link_BestRateGuarantee);
        }

        public static IWebElement Icon_Close()
        {            
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_Icon_Close);
        }

        public static IWebElement FAQ_Icon_Close()
        {
            ScanPage(Constants.MyProfile);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyProfile_FAQ_Icon_Close);
        }
    }
}