using AMR_Agent.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace AMR_Agent.PageObject.Admin
{
    class PageObject_ManageRedemptions : Setup
    {
        /*
        / These methods will return the element on the page by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
        */

        public static IWebElement AdminManageRedemptionsRedemptionsPending()
        {
            ScanPage(Constants.ModuleAdminManageRedemptions);
            return PageAction.Find_ElementId(ObjectRepository.AdminManageRedemptions_RedemptionsPending);
        }

        public static IWebElement AdminManageRedemptionsAMRRewardsReceived()
        {
            ScanPage(Constants.ModuleAdminManageRedemptions);
            return PageAction.Find_ElementId(ObjectRepository.AdminManageRedemptions_AMRRewardsReceived);
        }

        public static IWebElement AdminManageRedemptionsBookingBonus()
        {
            ScanPage(Constants.ModuleAdminManageRedemptions);
            return PageAction.Find_ElementId(ObjectRepository.AdminManageRedemptions_BookingBonus);
        }

        public static IWebElement AdminManageAMRRewardsApproved()
        {
            ScanPage(Constants.ModuleAdminManageRedemptions);
            return PageAction.Find_ElementId(ObjectRepository.AdminManageRedemptions_AMRRewardsApproved);
        }

        public static IWebElement AdminManageAMRRewardsReceivedSearch()
        {
            ScanPage(Constants.ModuleAdminManageRedemptions);
            return PageAction.Find_ElementId(ObjectRepository.AdminManageRedemptions_AMRRewardsReceived_Search);
        }

        public static IWebElement AdminManageRedemptionsAMRRewardsReceivedEditRedemption()
        {
            ScanPage(Constants.ModuleAdminManageRedemptions);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageRedemptions_AMRRewardsReceived_EditRedemption);
        }

        public static IWebElement AdminManageRedemptionsAMRRewardsReceivedTextboxFirstname()
        {
            ScanPage(Constants.ModuleAdminManageRedemptions);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageRedemptions_AMRRewardsReceived_Textbox_Firstname);
        }

        public static IWebElement AdminManageRedemptionsAMRRewardsReceivedTextboxCertificateNo()
        {
            ScanPage(Constants.ModuleAdminManageRedemptions);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageRedemptions_AMRRewardsReceived_Textbox_CertificateNo);
        }

        public static IWebElement AdminManageRedemptionsAMRRewardsReceivedTextboxExpirationDate()
        {
            ScanPage(Constants.ModuleAdminManageRedemptions);
            return PageAction.Find_ElementId(ObjectRepository.AdminManageRedemptions_AMRRewardsReceived_Textbox_ExpirationDate);
        }
        public static IWebElement AdminManageRedemptions_AMRRewardsReceived_Textbox_Email()
        {
            ScanPage(Constants.ModuleAdminManageRedemptions);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageRedemptions_AMRRewardsReceived_Textbox_Email);
        }

        public static IWebElement AdminManageRedemptionsAMRRewardsReceivedButtonResendCertificate()
        {
            ScanPage(Constants.ModuleAdminManageRedemptions);
            return PageAction.Find_ElementId(ObjectRepository.AdminManageRedemptions_AMRRewardsReceived_Button_ResendCertificate);
        }

        public static IWebElement AdminManageRedemptionsAMRRewardsReceivedRadioButtonOther()
        {
            ScanPage(Constants.ModuleAdminManageRedemptions);
            return PageAction.Find_ElementId(ObjectRepository.AdminManageRedemptions_AMRRewardsReceived_RadioButton_Other);
        }

        public static IWebElement AdminManageRedemptionsAMRRewardsReceivedTextboxCustomEmail()
        {
            ScanPage(Constants.ModuleAdminManageRedemptions);
            return PageAction.Find_ElementId(ObjectRepository.AdminManageRedemptions_AMRRewardsReceived_Textbox_CustomEmail);
        }

        public static IWebElement AdminManageRedemptionsAMRRewardsReceivedButtonSend()
        {
            ScanPage(Constants.ModuleAdminManageRedemptions);
            return PageAction.Find_ElementId(ObjectRepository.AdminManageRedemptions_AMRRewardsReceived_Button_Send);
        }

        public static IWebElement AdminManageRedemptionsAMRRewardsReceivedButtonCancel()
        {
            ScanPage(Constants.ModuleAdminManageRedemptions);
            return PageAction.Find_ElementId(ObjectRepository.AdminManageRedemptions_AMRRewardsReceived_Button_Cancel);
        }

        public static IWebElement AdminManageRedemptionsAMRRewardsReceivedButtonOk()
        {
            ScanPage(Constants.ModuleAdminManageRedemptions);
            return PageAction.Find_ElementId(ObjectRepository.AdminManageRedemptions_AMRRewardsReceived_Button_Ok);
        }

        public static IWebElement AdminManageRedemptionsAMRRewardsReceivedMailButtonViewandPrint()
        {
            ScanPage(Constants.ModuleAdminManageRedemptions);
            return PageAction.Find_ElementXPath(ObjectRepository.AdminManageRedemptions_AMRRewardsReceived_Mail_Button_ViewandPrint);
        }

    }
}
