using System.Reflection;
using BaseUtility.PageObject;
using eLoyaltyV3.Utility;
using OpenQA.Selenium;

namespace eLoyaltyV3.PageObject.UI
{
    class PageObject_CRMAPI : Setup
    {
        public static string PageName = Constants.CRMAPI;

        public static IWebElement CRMAPI_btnprimary()
        {
            ScanPage(Constants.CRMAPI);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementLinkText(ObjectRepository.CRMAPI_btnprimary);
        }

        public static IWebElement CRMAPI_LoyaltyVersion_1()
        {
            ScanPage(Constants.CRMAPI);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CRMAPI_LoyaltyVersion_1);
        }
        public static IWebElement CRMAPI_LoyaltyVersion_2()
        {
            ScanPage(Constants.CRMAPI);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CRMAPI_LoyaltyVersion_2);
        }
        public static IWebElement CRMAPI_LoyaltyVersion_3()
        {
            ScanPage(Constants.CRMAPI);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CRMAPI_LoyaltyVersion_3);
        }

        public static IWebElement CRMAPI_LoyaltyV3Credentials()
        {
            ScanPage(Constants.CRMAPI);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.APICredentials);
        }
        public static IWebElement CRMAPI_btnExplore()
        {
            ScanPage(Constants.CRMAPI);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.CRMAPI_btnExplore);
        }

        public static IWebElement CRMAPI_AccountApi()
        {
            ScanPage(Constants.CRMAPI);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementLinkText(ObjectRepository.CRMAPI_ParentAccList);
        }
        public static IWebElement CRMAPI_AccountLogin()
        {
            ScanPage(Constants.CRMAPI);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementPartialLinkText(ObjectRepository.CRMAPI_AccountLogin);
        }
        public static IWebElement CRMAPI_AccountLogin_Authentication()
        {
            ScanPage(Constants.CRMAPI);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CRMAPI_AccountLogin_Authentication);
        }

        public static IWebElement CRMAPI_AccountLogin_MasterPropertyCode()
        {
            ScanPage(Constants.CRMAPI);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CRMAPI_AccountLogin_MasterPropertyCode);
        }
        public static IWebElement CRMAPI_AccountLogin_SubmitButton()
        {
            ScanPage(Constants.CRMAPI);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CRMAPI_AccountLogin_SubmitButton);
        }
        public static IWebElement CRMAPI_AccountRegister()
        {
            ScanPage(Constants.CRMAPI);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementPartialLinkText(ObjectRepository.CRMAPI_AccountRegister);
        }

        public static IWebElement CRMAPI_AccountRegister_RegisterAcc()
        {
            ScanPage(Constants.CRMAPI);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CRMAPI_AccountRegister_RegisterAcc);
        }
        public static IWebElement CRMAPI_AccountRegister_MasterPropertyCode()
        {
            ScanPage(Constants.CRMAPI);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CRMAPI_AccountRegister_MasterPropertyCode);
        }
        public static IWebElement CRMAPI_AccountRegister_RegisterButton()
        {
            ScanPage(Constants.CRMAPI);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CRMAPI_AccountRegister_RegisterButton);
        }
    }
}
