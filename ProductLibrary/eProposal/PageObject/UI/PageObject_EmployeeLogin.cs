using System.Reflection;
using eProposal.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eProposal.PageObject.UI
{
    public class PageObject_EmployeeLogin : Setup
    {
        private static readonly string PageName = Constants.EmployeeLogin;


        public static IWebElement DefaultSubmitButton()
        {
            ScanPage(Constants.EmployeeLogin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.EmployeeLogin_DefaultSubmitButton);
        }

        public static IWebElement EmailText()
        {
            ScanPage(Constants.EmployeeLogin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.EmployeeLogin_EmailText);
        }

        public static IWebElement LoginButtonNextStep()
        {
            ScanPage(Constants.EmployeeLogin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.EmployeeLogin_LoginButtonNextStep);
        }

        public static IWebElement PasswordText()
        {
            ScanPage(Constants.EmployeeLogin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.EmployeeLogin_PasswordText);
        }

        public static IWebElement SubmitButton()
        {
            ScanPage(Constants.EmployeeLogin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.EmployeeLogin_SubmitButton);
        }

        public static IWebElement ForgotPasswordLink()
        {
            ScanPage(Constants.EmployeeLogin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.EmployeeLogin_ForgotPasswordLink);
        }

        public static IWebElement ForgotPasswordEmailText()
        {
            ScanPage(Constants.EmployeeLogin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.EmployeeLogin_ForgotPasswordEmailText);
        }

        public static IWebElement ForgotPasswordSubmitButton()
        {
            ScanPage(Constants.EmployeeLogin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.EmployeeLogin_ForgotPasswordSubmitButton);
        }

        public static IWebElement ForgotPasswordLoginLink()
        {
            ScanPage(Constants.EmployeeLogin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.EmployeeLogin_ForgotPasswordLoginLink);
        }
        public static IWebElement SSOLogin_Email()
        {
            ScanPage(Constants.EmployeeLogin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SSOLogin_Email);
        }
        public static IWebElement SSOLogin_Password()
        {
            ScanPage(Constants.EmployeeLogin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SSOLogin_Password);
        }
        public static IWebElement SSOLogin_Next()
        {
            ScanPage(Constants.EmployeeLogin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SSOLogin_Next);
        }
        public static IWebElement SSOLogin_Submit()
        {
            ScanPage(Constants.EmployeeLogin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SSOLogin_Submit);
        }
        public static IWebElement SSOLogin_VerificationCode()
        {
            ScanPage(Constants.EmployeeLogin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.SSOLogin_VerificationCode);
        }
        public static IWebElement SSOLogin_Login()
        {
            ScanPage(Constants.EmployeeLogin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SSOLogin_Login);
        }
        public static IWebElement Login_IFrame_AgreeProceed()
        {
            ScanPage(Constants.EmployeeLogin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Login_IFrame_AgreeProceed);
        }
        public static IWebElement Login_IFrame_AgreeProceed_Close()
        {
            ScanPage(Constants.EmployeeLogin);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Login_IFrame_AgreeProceed_Close);
        }
    }
}