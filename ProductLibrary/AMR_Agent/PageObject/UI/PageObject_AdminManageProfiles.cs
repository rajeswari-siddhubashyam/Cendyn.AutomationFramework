using AMR_Agent.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace AMR_Agent.PageObject.UI
{
    class PageObject_AdminManageProfiles : Setup
    {
        /*
        / These methods will return the element on the page by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
        */

        public static IWebElement AdminManageProfilesValidatedProfilesTab()
        {
            ScanPage(Constants.ModuleAdminManageProfiles);
            return PageAction.Find_ElementId(ObjectRepository.AdminManageProfiles_ValidatedProfiles_Tab);
        }

        public static IWebElement AdminManageProfiles_InActivatedProfiles_Tab()
        {
            ScanPage(Constants.ModuleAdminManageProfiles);
            return PageAction.Find_ElementId(ObjectRepository.AdminManageProfiles_InActivatedProfiles_Tab);
        }

        public static IWebElement AdminManageProfiles_NonValidatedProfiles_Tab()
        {
            ScanPage(Constants.ModuleAdminManageProfiles);
            return PageAction.Find_ElementId(ObjectRepository.AdminManageProfiles_NonValidatedProfiles_Tab);
        }
        
        public static IWebElement AdminManageProfilesSearch()
        {
            ScanPage(Constants.ModuleAdminManageProfiles);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageProfilesSearch);
        }

        public static IWebElement AdminManageProfilesEditProfile()
        {
            ScanPage(Constants.ModuleAdminManageProfiles);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageProfiles_EditProfile);
        }

        public static IWebElement AdminManageProfilesIconResetPassword()
        {
            ScanPage(Constants.ModuleAdminManageProfiles);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageProfiles_Icon_ResetPassword);
        }

        public static IWebElement AdminManageProfilesResetPasswordCancelButton()
        {
            ScanPage(Constants.ModuleAdminManageProfiles);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageProfiles_ResetPassword_CancelButton);
        }

        public static IWebElement AdminManageProfilesResetPasswordConfirmationButton()
        {
            ScanPage(Constants.ModuleAdminManageProfiles);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageProfiles_ResetPassword_ConfirmationButton);
        }

        public static IWebElement AdminManageProfilesResetPasswordResetButton()
        {
            ScanPage(Constants.ModuleAdminManageProfiles);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageProfiles_ResetPassword_ResetButton);
        }
                
        public static IWebElement AdminManageProfiles_ResetPassword_NewPassword()
        {
            ScanPage(Constants.ModuleAdminManageProfiles);
            return PageAction.Find_ElementId(ObjectRepository.AdminManageProfiles_ResetPassword_NewPassword);
        }

        public static IWebElement AdminManageProfiles_ResetPassword_CloseButton()
        {
            ScanPage(Constants.ModuleAdminManageProfiles);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageProfiles_ResetPassword_CloseButton);
        }

        public static IWebElement AdminManageProfiles_ResetPassword_CloseIcon()
        {
            ScanPage(Constants.ModuleAdminManageProfiles);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageProfiles_ResetPassword_CloseIcon);
        }

        public static IWebElement AdminManageProfiles_Icon_InActivateProfile()
        {
            ScanPage(Constants.ModuleAdminManageProfiles);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageProfiles_Icon_InActivateProfile);
        }

        public static IWebElement AdminManageProfiles_InActivatedProfiles_Search()
        {
            ScanPage(Constants.ModuleAdminManageProfiles);
            return PageAction.Find_ElementId(ObjectRepository.AdminManageProfiles_InActivatedProfiles_Search);
        }

        public static IWebElement AdminManageProfiles_Icon_ReactivateProfile()
        {
            ScanPage(Constants.ModuleAdminManageProfiles);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageProfiles_Icon_ReactivateProfile);
        }

        public static IWebElement AdminManageProfiles_ValidatedProfile_Icon_ViewProfile()
        {
            ScanPage(Constants.ModuleAdminManageProfiles);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageProfiles_ValidatedProfile_Icon_ViewProfile);
        }

        public static IWebElement AdminManageProfiles_ViewProfile_Icon_Close()
        {
            ScanPage(Constants.ModuleAdminManageProfiles);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageProfiles_ViewProfile_Icon_Close);
        }

        public static IWebElement AdminManageProfiles_InActivatedProfile_Icon_ViewProfile()
        {
            ScanPage(Constants.ModuleAdminManageProfiles);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageProfiles_InActivatedProfile_Icon_ViewProfile);
        }

        public static IWebElement AdminManageProfiles_NonValidatedProfiles_Icon_EditProfile()
        {
            ScanPage(Constants.ModuleAdminManageProfiles);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageProfiles_NonValidatedProfiles_Icon_EditProfile);
        }
        
        public static IWebElement AdminManageProfiles_InActivatedProfile_Icon_EditProfile()
        {
            ScanPage(Constants.ModuleAdminManageProfiles);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageProfiles_InActivatedProfile_Icon_EditProfile);
        }

        public static IWebElement AdminManageProfiles_NonValidatedProfiles_Search()
        {
            ScanPage(Constants.ModuleAdminManageProfiles);
            return PageAction.Find_ElementId(ObjectRepository.AdminManageProfiles_NonValidatedProfiles_Search);
        }

        public static IWebElement AdminManageProfiles_NonValidatedProfiles_Icon_ViewProfile()
        {
            ScanPage(Constants.ModuleAdminManageProfiles);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageProfiles_NonValidatedProfiles_Icon_ViewProfile);
        }

        public static IWebElement AdminManageProfiles_NonValidatedProfiles_Tab_PointsHistory()
        {
            ScanPage(Constants.ModuleAdminManageProfiles);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageProfiles_NonValidatedProfiles_Tab_PointsHistory);
        }

        public static IWebElement AdminManageProfiles_ValidatedProfile_Icon_Delete(string email)
        {
            ScanPage(Constants.ModuleAdminManageProfiles);
            return PageAction.Find_ElementXPath("(//a[contains(text(),'"+email+"')]//following::div[@title='Delete profile']/span)[1]");
        }

        public static IWebElement AdminManageProfiles_ValidatedProfile_Button_DeleteConfirm()
        {
            ScanPage(Constants.ModuleAdminManageProfiles);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageProfiles_ValidatedProfile_Button_DeleteConfirm);
        }

        public static IWebElement AdminManageProfiles_ValidatedProfile_Button_DeleteCancel()
        {
            ScanPage(Constants.ModuleAdminManageProfiles);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageProfiles_ValidatedProfile_Button_DeleteCancel);
        }

        public static IWebElement AdminManageProfiles_ValidatedProfile_Button_Close()
        {
            ScanPage(Constants.ModuleAdminManageProfiles);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageProfiles_ValidatedProfile_Button_Close);
        }


    }
}
