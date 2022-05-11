using BaseUtility.PageObject;
using eMenus.Utility;
using OpenQA.Selenium;
using System.Reflection;

namespace eMenus.PageObject.UI
{
    public class PageObject_SignUp : Setup
    {
        public static string PageName = Utility.Constants.SignUp;

        #region[SignUp]
        public static IWebElement Link_CreateAccount()
        {
            ScanPage(Utility.Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SignUp_CreateAccount);
        }

        public static IWebElement TextBox_FirstName()
        {
            ScanPage(Utility.Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignUp_FirstName);
        }

        public static IWebElement TextBox_LastName()
        {
            ScanPage(Utility.Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignUp_LastName);
        }
        public static IWebElement TextBox_Phone()
        {
            ScanPage(Utility.Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignUp_Phone);
        }
        public static IWebElement TextBox_Email()
        {
            ScanPage(Utility.Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignUp_Email);
        }
        public static IWebElement TextBox_Password()
        {
            ScanPage(Utility.Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignUp_Password);
        }
        public static IWebElement TextBox_Confirm_Password()
        {
            ScanPage(Utility.Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignUp_Confirm_Password);
        }
        public static IWebElement Button_SignUp()
        {
            ScanPage(Utility.Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SignUp_Button);
        }
        public static IWebElement FirstName_Validation()
        {
            ScanPage(Utility.Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.FirstName_Validation);
        }
        public static IWebElement LastName_Validation()
        {
            ScanPage(Utility.Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.LastName_Validation);
        }
        public static IWebElement Phone_Validation()
        {
            ScanPage(Utility.Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Phone_Validation);
        }
        public static IWebElement Email_Validation()
        {
            ScanPage(Utility.Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Email_Validation);
        }
        public static IWebElement Password_Validation()
        {
            ScanPage(Utility.Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Password_Validation);
        }
        public static IWebElement ConfirmPassword_Validation()
        {
            ScanPage(Utility.Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ConfirmPassword_Validation);
        }
        public static IWebElement Existing_Email_Validation()
        {
            ScanPage(Utility.Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Existing_Email_Validation);
        }
        
        public static IWebElement Create_Success_SignIn_Link()
        {
            ScanPage(Utility.Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateSuccess_Signin);
        }
        public static IWebElement catchaAll_GetStarted()
        {
            ScanPage(Utility.Constants.CatchAll);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.catchaAll_GetStarted);
        }
        #endregion[SignUp]
    }
}
