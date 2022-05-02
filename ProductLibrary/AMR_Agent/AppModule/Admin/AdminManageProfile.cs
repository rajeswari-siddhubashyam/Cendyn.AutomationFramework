using AMR_Agent.PageObject.UI;
using BaseUtility.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace AMR_Agent.AppModule.Admin
{ 
    class AdminManageProfile
    {
        public static void ClickValidateProfile()
        {
            Helper.ElementClick(PageObject_AdminManageProfiles.AdminManageProfilesValidatedProfilesTab());
        }

        public static void ClickInActivatedProfilesTab()
        {
            Helper.ElementClick(PageObject_AdminManageProfiles.AdminManageProfiles_InActivatedProfiles_Tab());
        }

        public static void ClickNonValidatedProfilesTab()
        {
            Helper.ElementClick(PageObject_AdminManageProfiles.AdminManageProfiles_NonValidatedProfiles_Tab());
        }

        public static void EnterSearch(string text)
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementEnterText(PageObject_AdminManageProfiles.AdminManageProfilesSearch(), text);
            Helper.AddDelay(5000);
            action.SendKeys(Keys.Enter).Build().Perform();
            Helper.AddDelay(15000);
        }

        public static void ClickEditProfile()
        {
            Helper.ElementClick(PageObject_AdminManageProfiles.AdminManageProfilesEditProfile());
        }

        public static void ClickIconResetPassword()
        {
            Helper.ElementClick(PageObject_AdminManageProfiles.AdminManageProfilesIconResetPassword());
        }

        public static void ClickResetButton()
        {
            Helper.ElementClick(PageObject_AdminManageProfiles.AdminManageProfilesResetPasswordResetButton());
        }

        public static void ClickResetConfirmationButton()
        {
            Helper.ElementClick(PageObject_AdminManageProfiles.AdminManageProfilesResetPasswordConfirmationButton());
        }

        public static void ClickResetCancelButton()
        {
            Helper.ElementClick(PageObject_AdminManageProfiles.AdminManageProfilesResetPasswordCancelButton());
        }

        public static void ClickResetCloseButton()
        {
            Helper.ElementClick(PageObject_AdminManageProfiles.AdminManageProfiles_ResetPassword_CloseButton());
        }

        public static void ClickResetCloseIcon()
        {
            Helper.ElementClick(PageObject_AdminManageProfiles.AdminManageProfiles_ResetPassword_CloseIcon());
        }

        public static void ClickIconInActivateProfile()
        {
            Helper.ElementClick(PageObject_AdminManageProfiles.AdminManageProfiles_Icon_InActivateProfile());
        }

        public static void EnterNewPassword(string text)
        {           
            Helper.ElementEnterText(PageObject_AdminManageProfiles.AdminManageProfiles_ResetPassword_NewPassword(), text);
         ;
        }

        public static void EnterInActivatedProfileSearch(string text)
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementEnterText(PageObject_AdminManageProfiles.AdminManageProfiles_InActivatedProfiles_Search(), text);
            Helper.AddDelay(5000);
            action.SendKeys(Keys.Enter).Build().Perform();
            Helper.AddDelay(15000);
        }

        public static void ClickIconReactivateProfile()
        {
            Helper.ElementClick(PageObject_AdminManageProfiles.AdminManageProfiles_Icon_ReactivateProfile());
        }

        public static void ClickIconValidateProfileViewProfile()
        {
            Helper.ElementClick(PageObject_AdminManageProfiles.AdminManageProfiles_ValidatedProfile_Icon_ViewProfile());
        }

        public static void ClickIconViewProfileClose()
        {
            Helper.ElementClick(PageObject_AdminManageProfiles.AdminManageProfiles_ViewProfile_Icon_Close());
        }

        public static void ClickIconInActivatedProfileViewProfile()
        {
            Helper.ElementClick(PageObject_AdminManageProfiles.AdminManageProfiles_InActivatedProfile_Icon_ViewProfile());
        }

        public static void ClickIconInActivatedProfileEditProfile()
        {
            Helper.ElementClick(PageObject_AdminManageProfiles.AdminManageProfiles_InActivatedProfile_Icon_EditProfile());
        }

        public static void EnterNonValidatedSearch(string text)
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementEnterText(PageObject_AdminManageProfiles.AdminManageProfiles_NonValidatedProfiles_Search(), text);
            Helper.AddDelay(5000);
            action.SendKeys(Keys.Enter).Build().Perform();
            Helper.AddDelay(15000);
        }

        public static void ClickIconNonValidatedProfileEditProfile()
        {
            Helper.ElementClick(PageObject_AdminManageProfiles.AdminManageProfiles_NonValidatedProfiles_Icon_EditProfile());
        }

        public static void ClickIconNonValidatedProfileViewProfile()
        {
            Helper.ElementClick(PageObject_AdminManageProfiles.AdminManageProfiles_NonValidatedProfiles_Icon_ViewProfile());
        }

        public static void ClickNonValidatedProfileTabPointsHistory()
        {
            Helper.ElementClick(PageObject_AdminManageProfiles.AdminManageProfiles_NonValidatedProfiles_Tab_PointsHistory());
        }

        public static void ClickValidatedProfileIconDelete(string email)
        {
            Helper.ElementClick(PageObject_AdminManageProfiles.AdminManageProfiles_ValidatedProfile_Icon_Delete(email));
        }

        public static void ClickValidatedProfileButtonDeleteConfirm()
        {
            Helper.ElementClick(PageObject_AdminManageProfiles.AdminManageProfiles_ValidatedProfile_Button_DeleteConfirm());
        }

        public static void ClickValidatedProfileButtonDeleteCancel()
        {
            Helper.ElementClick(PageObject_AdminManageProfiles.AdminManageProfiles_ValidatedProfile_Button_DeleteCancel());
        }

        public static void ClickButtonClose()
        {
            Helper.ElementClick(PageObject_AdminManageProfiles.AdminManageProfiles_ValidatedProfile_Button_Close());
        }

    }
}
