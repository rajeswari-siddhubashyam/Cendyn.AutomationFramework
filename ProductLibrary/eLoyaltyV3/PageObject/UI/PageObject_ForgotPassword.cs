using System.Reflection;
using BaseUtility.PageObject;
using eLoyaltyV3.Utility;
using OpenQA.Selenium;

namespace eLoyaltyV3.PageObject.UI
{
    public class PageObject_ForgotPassword : Setup
    {
        private static string PageName = Constants.ForgotPassword;

        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/

        public static IWebElement ForgotPassword_LinkText()
        {
            if (ProjectName.Equals("IndependentCollection"))
            {
                ScanPage(Constants.SignIn);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//a[contains(text(),'Forgot Password')]");
            }
            else
            {
                ScanPage(Constants.ForgotPassword);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementId(ObjectRepository.ForgotPassword_LinkText);
            }
            
        }

        public static IWebElement ForgotPassword_Email()
        {
            ScanPage(Constants.ForgotPassword);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ForgotPassword_Email);
        }

        public static IWebElement ForgotPassword_Recover()
        {
            ScanPage(Constants.ForgotPassword);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ForgotPassword_Recover);
        }

        public static IWebElement ForgotPassword_Recovery()
        {
            ScanPage(Constants.ForgotPassword);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ForgotPassword_Recovery);
        }

        public static IWebElement ForgotPassword_Cancel()
        {
            ScanPage(Constants.ForgotPassword);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ForgotPassword_Cancel);
        }

        public static IWebElement Button_Accept()
        {
            ScanPage(Constants.SignUp);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ForgotPassword_TermsandCondition_Accept);
        }

        public static IWebElement ForgotPassword_Back()
        {
            ScanPage(Constants.ForgotPassword);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ForgotPassword_Back);
        }

        public static IWebElement NewPassword()
        {
            ScanPage(Constants.ForgotPassword);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ForgotPassword_NewPassword);
        }

        public static IWebElement NewPasswordConfirm()
        {
            ScanPage(Constants.ForgotPassword);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ForgotPassword_NewPasswordConfirm);
        }

    }
}