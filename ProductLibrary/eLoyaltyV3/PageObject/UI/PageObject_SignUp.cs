using System.Reflection;
using BaseUtility.PageObject;
using eLoyaltyV3.Utility;
using OpenQA.Selenium;

namespace eLoyaltyV3.PageObject.UI
{
    public class PageObject_SignUp : Setup
    {


        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/
        public static string PageName = Constants.SignUp;

        public static IWebElement Click_SignIn()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementLinkText(ObjectRepository.Click_SignIn);
        }

        public static IWebElement DropDown_Salution()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignUp_DropDown_Salutation);
        }

        public static IWebElement Icon_Close()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SignUp_Icon_Close);
        }

        public static IWebElement Text_FirstName()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SignUp_Text_FirstName);
        }

        public static IWebElement Text_LastName()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SignUp_Text_LastName);
        }

        public static IWebElement Text_PreferredCardName()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SignUp_Text_PreferredCardName);
        }

        public static IWebElement Text_Email()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SignUp_Text_Email);
        }

        public static IWebElement Text_Password()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SignUp_Text_Password);
        }

        public static IWebElement Text_ConfirmPassword()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SignUp_Text_ConfirmPassword);
        }

        public static IWebElement CheckBox_TermsAndConditions()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SignUp_CheckBox_TermsAndConditions);
        }

        public static IWebElement Button_Join()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SignUp_Button_Join);
        }

        public static IWebElement Button_SignIn()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SignInButton_ActivationPage);
        }

        public static IWebElement Button_Accept()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignUp_TermsandCondition_Accept);
        }

        public static IWebElement Button_Close()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SignUp_TermsandCondition_Close);
        }


        public static IWebElement SignUp_DateOfBirth()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignUp_DateOfBirth);
        }

        public static IWebElement SignUp_Footer()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignUp_Footer);

        }
        public static IWebElement SignUp_Facebook_Link()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SignUp_Facebook_Link);

        }
        public static IWebElement SignUp_Twitter_Link()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SignUp_Twitter_Link);

        }

        public static IWebElement Facebook_UserName()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Facebook_UserName);

        }
        public static IWebElement Facebook_Password()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Facebook_Password);

        }
        public static IWebElement Facebook_Login()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Facebook_Login);

        }
        public static IWebElement Twitter_UserName()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Twitter_UserName);

        }
        public static IWebElement Twitter_Password()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Twitter_Password);

        }
        public static IWebElement Twitter_Login()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Twitter_Login);

        }

        public static IWebElement Allow_On_Twitter()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Allow_On_Twitter);

        }
        public static IWebElement SignUp_Date_Picker()
        {

            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SignUp_Date_Picker);
        }

        public static IWebElement Password_Eye_Ball()
        { 
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Password_Eye_Ball);
        }
        public static IWebElement ConfirmPassword_Eye_Ball()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ConfirmPassword_Eye_Ball);
        }
    }
}