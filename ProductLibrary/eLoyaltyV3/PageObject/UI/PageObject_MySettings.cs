using System.Reflection;
using BaseUtility.PageObject;
using eLoyaltyV3.Utility;
using OpenQA.Selenium;

namespace eLoyaltyV3.PageObject.UI
{
    class PageObject_MySettings : Setup
    {
        private static string PageName = Constants.MySettings;

        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/
        public static IWebElement MySettings_NewEmailAddress()
        {
            ScanPage(Constants.MySettings);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.MySettings_NewEmailAddress);
        }

        public static IWebElement MySettings_Password()
        {
            ScanPage(Constants.MySettings);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.MySettings_Password);
        }

        public static IWebElement MySettings_UpdateUser(string ProjectName = null)
        {
            if (ProjectName.Equals("AMR"))
            {
                ScanPage(Constants.MySettings);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//input[@value='Change Email']");

            }
            else
            {
                ScanPage(Constants.MySettings);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath(ObjectRepository.MySettings_UpdateUser);
            }
        }

        public static IWebElement MySettings_UpdateLogin()
        {
            ScanPage(Constants.MySettings);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MySettings_UpdateLogin);
        }

        public static IWebElement MySettings_CurrentPassword()
        {
            ScanPage(Constants.MySettings);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.MySettings_CurrentPassword);
        }

        public static IWebElement MySettings_NewPassword()
        {
            ScanPage(Constants.MySettings);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.MySettings_NewPassword);
        }

        public static IWebElement MySettings_ConfirmPassword()
        {
            ScanPage(Constants.MySettings);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.MySettings_ConfirmPassword);
        }

        public static IWebElement MySettings_UpdatePassword(string Projectname)
        {
            if (ProjectName.Equals("HotelIcon")|| ProjectName.Equals("PublicHotel")|| ProjectName.Equals("Fraser") || ProjectName.Equals("WoodLoch"))
            {
                ScanPage(Constants.MySettings);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//input[@value='Update Password']");
            }
            if (ProjectName.Equals("IndependentCollection"))
            {
                ScanPage(Constants.MySettings);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//input[@value='Update User']");
            }
            if (ProjectName.Equals("MyPlace") || ProjectName.Equals("AdareManor") || (ProjectName.Equals("Sarova")))
            {
                ScanPage(Constants.MySettings);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//form[@id='UpdatePasswordForm']//input[@id='next-button']");
            }
            if (ProjectName.Equals("AMR"))
            {
                ScanPage(Constants.MySettings);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath("//input[@value='Change Password']");
            }
            else
            {
                ScanPage(Constants.MySettings);
                CurrentPageName = PageName;
                CurrentElementName = MethodBase.GetCurrentMethod().Name;
                return PageAction.Find_ElementXPath(ObjectRepository.MySettings_UpdatePassword);
            }
        }

        public static IWebElement MySettings_CurrentEmailAddress()
        {
            ScanPage(Constants.MySettings);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MySettings_CurrentEmailAddress);
        }


        public static IWebElement MySettings_PasswordUpdationConformationPopup()
        {
            ScanPage(Constants.MySettings);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MySettings_PasswordUpdationConformationPopup);
        }

        public static IWebElement MySettings_EmailUpdationConformationPopup()
        {
            ScanPage(Constants.MySettings);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MySettings_EmailUpdationConformationPopup);

        }
    }
}
