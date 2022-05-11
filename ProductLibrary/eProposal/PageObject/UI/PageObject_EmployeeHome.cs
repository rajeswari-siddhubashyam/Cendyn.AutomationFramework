using System.Reflection;
using eProposal.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eProposal.PageObject.UI
{
    public class PageObject_EmployeeHome : Setup
    {
        private static readonly string PageName = Constants.EmployeeHome;

        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/

        public static IWebElement EmployeeHome_MySettings()
        {
            ScanPage(Constants.EmployeeHome);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.EmployeeHome_MySettings);
        }

        public static IWebElement EmployeeHome_MySettings_Demo()
        {
            ScanPage(Constants.EmployeeHome);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.EmployeeHome_MySettings_Demo);
        }
        public static IWebElement EmployeeHome_MySettings_Click_Demo()
        {
            ScanPage(Constants.EmployeeHome);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.EmployeeHome_MySettings_Click_Demo);
        }
        public static IWebElement EmployeeHome_MySettings_New()
        {
            ScanPage(Constants.EmployeeHome);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.EmployeeHome_MySettings_New);
        }
        public static IWebElement EmployeeHome_MySettings_Click_New()
        {
            ScanPage(Constants.EmployeeHome);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.EmployeeHome_MySettings_Click_New);
        }
        public static IWebElement EmployeeHome_Profile()
        {
            ScanPage(Constants.EmployeeHome);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.EmployeeHome_Profile);
        }

        public static IWebElement EmployeeHome_AddEditProfile()
        {
            ScanPage(Constants.EmployeeHome);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.EmployeeHome_AddEditProfile);
        }

        public static IWebElement Link_UpdateMySettings()
        {
            ScanPage(Constants.EmployeeHome);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.EmployeeHome_Link_UpdateMySettings);
        }


        public static IWebElement CreateEditButton()
        {
            ScanPage(Constants.EmployeeHome);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.EmployeeHome_CreateEditButton);
        }

        public static IWebElement ActivityTab()
        {
            ScanPage(Constants.EmployeeHome);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.EmployeeHome_ActivityTab);
        }


        public static IWebElement CreateEdit_eProposalButton()
        {
            ScanPage(Constants.EmployeeHome);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.EmployeeHome_CreateEdit_eProposalButton);
        }

        public static IWebElement CreateEdit_eCardButton()
        {
            ScanPage(Constants.EmployeeHome);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.EmployeeHome_CreateEdit_eCardButton);
        }

        public static IWebElement PropertyDropDown_Button()
        {
            ScanPage(Constants.EmployeeHome);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.EmployeeHome_PropertyDropDown_Button);
        }

        public static IWebElement PropertyDropDown_Text()
        {
            ScanPage(Constants.EmployeeHome);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.EmployeeHome_PropertyDropDown_Text);
        }

        public static IWebElement WelcomeButton()
        {
            ScanPage(Constants.EmployeeHome);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.EmployeeHome_WelcomeButton);
        }

        public static IWebElement ViewAllLink()
        {
            ScanPage(Constants.EmployeeHome);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.EmployeeHome_ViewAllLink);
        }

        public static IWebElement HelpLink()
        {
            ScanPage(Constants.EmployeeHome);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.EmployeeHome_HelpLink);
        }

        public static IWebElement EditProfileLink()
        {
            ScanPage(Constants.EmployeeHome);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.EmployeeHome_EditProfileLink);
        }

        public static IWebElement ClientsButton()
        {
            ScanPage(Constants.EmployeeHome);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.EmployeeHome_ClientsButton);
        }

        public static IWebElement ReportsButton()
        {
            ScanPage(Constants.EmployeeHome);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.EmployeeHome_ReportsButton);
        }

        public static IWebElement CreateEdit_eProposalButton2()
        {
            ScanPage(Constants.EmployeeHome);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.EmployeeHome_CreateEdit_eProposalButton2);
        }

        public static IWebElement CreateEdit_eFacetimeButton()
        {
            ScanPage(Constants.EmployeeHome);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.EmployeeHome_CreateEdit_eFacetimeButton);
        }
    }
}