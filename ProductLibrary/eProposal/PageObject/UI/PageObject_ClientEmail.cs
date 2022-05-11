using System.Reflection;
using eProposal.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eProposal.PageObject.UI
{
    public class PageObject_ClientEmail : Setup
    {
        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/

        public static string PageName = Constants.ClientEmail;

        public static IWebElement Dropdown_Language()
        {
            ScanPage(Constants.ClientEmail);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ClientEmail_Dropdown_Language);
        }

        public static IWebElement Link_ViewProposal()
        {
            ScanPage(Constants.ClientEmail);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ClientEmail_Link_ViewProposal);
        }

        public static IWebElement Frame_ReviewAndResend()
        {
            ScanPage(Constants.ClientEmail);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ClientEmail_Frame_ReviewAndResend);
        }


        public static IWebElement Image_CustomSignature()
        {
            ScanPage(Constants.ClientEmail);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ClientEmail_Image_CustomSignature);
        }

        public static IWebElement Text_EmployeeNameCendynQA()
        {
            ScanPage(Constants.ClientEmail);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ClientEmail_Text_EmployeeNameCendynQA);
        }

        public static IWebElement Link_ViewInBrowser()
        {
            ScanPage(Constants.ClientEmail);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ClientEmail_Link_ViewInBrowser);
        }

        public static IWebElement Link_OpenYourProposal()
        {
            ScanPage(Constants.ClientEmail);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ClientEmail_Link_OpenYourProposal);
        }

        public static IWebElement Link_DownloadPDF()
        {
            ScanPage(Constants.ClientEmail);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ClientEmail_Link_DownloadPDF);
        }

        public static IWebElement Link_TechnicalDifficulties()
        {
            ScanPage(Constants.ClientEmail);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ClientEmail_Link_TechnicalDifficulties);
        }

        public static IWebElement Link_EmployeeEmail()
        {
            ScanPage(Constants.ClientEmail);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ClientEmail_Link_EmployeeEmail);
        }

        public static IWebElement HiltonHeader()
        {
            ScanPage(Constants.ClientEmail);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ClientEmail_HiltonHeader);
        }

        public static IWebElement HiltonFooter()
        {
            ScanPage(Constants.ClientEmail);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ClientEmail_HiltonFooter);
        }

        public static IWebElement Link_Forward()
        {
            ScanPage(Constants.ClientEmail);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ClientEmail_Link_Forward);
        }

        public static IWebElement Text_FirstName()
        {
            ScanPage(Constants.ClientEmail);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ClientEmail_Text_FirstName);
        }

        public static IWebElement Text_LastName()
        {
            ScanPage(Constants.ClientEmail);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ClientEmail_Text_LastName);
        }

        public static IWebElement Text_Email()
        {
            ScanPage(Constants.ClientEmail);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ClientEmail_Text_Email);
        }

        public static IWebElement Link_Submit()
        {
            ScanPage(Constants.ClientEmail);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ClientEmail_Link_Submit);
        }
    }
}