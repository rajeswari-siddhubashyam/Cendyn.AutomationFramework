using System.Reflection;
using eNgage.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eNgage.PageObject.UI
{
    public class PageObject_SignUp : Setup
    {

        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/
        private static string PageName = Constants.SignUp;

        public static IWebElement SignUp_FirstName()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignUp_FirstName);
        }
        public static IWebElement SignUp_LastName()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignUp_LastName);
        }
        public static IWebElement SignUp_Email()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignUp_Email);
        }
        public static IWebElement SignUp_Password()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignUp_Password);
        }
        public static IWebElement SignUp_ConfirmPassword()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignUp_ConfirmPassword);
        }
        public static IWebElement CreateAccount()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Login_RegisterAccount);
        }
        public static IWebElement SignUp_PasswordResetQuestion()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignUp_PasswordResetQuestion);
        }
        public static IWebElement SignUp_PasswordResetAnswer()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignUp_PasswordResetAnswer);
        }
        public static IWebElement SignUp_Register()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SignUp_Register);
        }


    }
}