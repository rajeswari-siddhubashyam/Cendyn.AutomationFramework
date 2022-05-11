using BaseUtility.PageObject;
using Common;
using eLoyaltyV3.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Constants = eLoyaltyV3.Utility.Constants;

namespace eLoyaltyV3.PageObject.UI
{
    class PageObject_SignIn : Setup
    {
        public static string PageName = Utility.Constants.SignIn;

        public static IWebElement Button_LogIn2()
        {
            ScanPage(Utility.Constants.SignIn);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SignIn_Button_LogIn2);
        }

        public static IWebElement Text_Email()
        {
            ScanPage(Utility.Constants.SignIn);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SignIn_Text_Email);
        }
        public static IWebElement Text_Password()
        {
            ScanPage(Utility.Constants.SignIn);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SignIn_Text_Password);
        }
        public static IWebElement Link_ForgotYourLogin()
        {
            if (ProjectName.Equals("IndependentCollection"))
            {
                ScanPage(Constants.SignIn);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//a[contains(text(),'Forgot your Password?')]");
            }
            else
            {
                ScanPage(Constants.SignIn);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath(ObjectRepository.SignIn_Link_ForgotYourLogin);
            }
        }
        public static IWebElement Button_NextLogin()
        {
            if (ProjectName.Equals("IndependentCollection"))
            {
                ScanPage(Constants.SignIn);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath(ObjectRepository.SignIn_Email_Next_Button);

            }
            else
            {
                ScanPage(Constants.SignIn);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementId(ObjectRepository.Login_SSO);
            }

        }
        public static IWebElement SignIn_Email_Error_Message()
        {
            ScanPage(Constants.SignIn);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SignIn_Email_Error_Message);

        }
        public static IWebElement TFE_SignIn_iFrame()
        {
            ScanPage(Constants.SignIn);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.TFE_SignIn_iFrame);
        }
    }
}
