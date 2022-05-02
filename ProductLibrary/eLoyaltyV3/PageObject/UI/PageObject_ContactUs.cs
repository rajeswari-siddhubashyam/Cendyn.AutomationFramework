using System.Reflection;
using BaseUtility.PageObject;
using eLoyaltyV3.Utility;
using OpenQA.Selenium;

namespace eLoyaltyV3.PageObject.UI
{
    public class PageObject_ContactUs : Setup
    {


        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/


        public static string PageName = Constants.ContactUs;

        public static IWebElement Text_YourName()
        {
            ScanPage(Constants.ContactUs);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ContactUs_Text_YourName);
        }

        public static IWebElement Text_EmailAddress()
        {
            ScanPage(Constants.ContactUs);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ContactUs_Text_EmailAddress);
        }

        public static IWebElement Text_PhoneNumber()
        {
            ScanPage(Constants.ContactUs);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ContactUs_Text_PhoneNumber);
        }

        public static IWebElement Text_ICWorldMembershipNo()
        {
            ScanPage(Constants.ContactUs);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ContactUs_Text_IndependentCMembershipNo);
        }

        public static IWebElement DDM_Subject()
        {
            ScanPage(Constants.ContactUs);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ContactUs_DDM_Subject);
        }
        public static IWebElement DropDownSelect_Authentication_Subject()
        {
            ScanPage(Constants.ContactUs);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.DropDownSelect_Authentication_Subject);
        }

        public static IWebElement Text_Message()
        {
            ScanPage(Constants.ContactUs);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ContactUs_Text_Message);
        }

        public static IWebElement Button_Captcha()
        {
            ScanPage(Constants.ContactUs);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ContactUs_Button_Captcha);
        }

        public static IWebElement Button_Send()
        {
            ScanPage(Constants.ContactUs);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ContactUs_Button_Send);
        }
        
        public static IWebElement EnterText_Text_Confirmation_Number()
        {
            ScanPage(Constants.ContactUs);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.EnterText_Text_Confirmation_Number);
        }
        public static IWebElement Navigation_Link_Un_Authenticated_ContactUs()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_Un_Authenticated_ContactUs);
        }
        public static IWebElement ContactUs_Filedrag()
        {
            ScanPage(Constants.ContactUs);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId("filedrag");
        }
        public static IWebElement Select_Contact_US_File()
        {
            ScanPage(Constants.ContactUs);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_Contact_US_File);
        }
        public static IWebElement Get_Contact_us_Filename()
        {
            ScanPage(Constants.ContactUs);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='messages']/p");
        }
    }
}