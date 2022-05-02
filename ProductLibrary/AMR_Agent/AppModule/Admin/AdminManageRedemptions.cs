using AMR_Agent.PageObject.Admin;
using BaseUtility.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace AMR_Agent.AppModule.Admin
{
    class AdminManageRedemptions : Utility.Setup
    {
        public static void ClickAMRRewardsReceivedTab()
        {
            Helper.ElementClick(PageObject_ManageRedemptions.AdminManageRedemptionsAMRRewardsReceived());
        }

        public static void ClickRedemptionsPendingTab()
        {
            Helper.ElementClick(PageObject_ManageRedemptions.AdminManageRedemptionsRedemptionsPending());
        }

        public static void ClickAMRRewardsApprovedTab()
        {
            Helper.ElementClick(PageObject_ManageRedemptions.AdminManageAMRRewardsApproved());
        }

        public static void ClickBookingBonusTab()
        {
            Helper.ElementClick(PageObject_ManageRedemptions.AdminManageRedemptionsBookingBonus());
        }

        public static void Enter_AMRRewardsReceived_Search(string text)
        {
            Actions action = new Actions(Helper.Driver);
            Helper.ElementEnterText(PageObject_ManageRedemptions.AdminManageAMRRewardsReceivedSearch(), text);
            Helper.AddDelay(5000);
            action.SendKeys(Keys.Enter).Build().Perform();
            Helper.AddDelay(15000);
        }

        public static void ClickAMRRewardsReceivedIconEditRedemptions()
        {
            Helper.ElementClick(PageObject_ManageRedemptions.AdminManageRedemptionsAMRRewardsReceivedEditRedemption());
        }

        public static string GetFirstname()
        {
            string name = PageObject_ManageRedemptions.AdminManageRedemptionsAMRRewardsReceivedTextboxFirstname().GetAttribute("innerHTML");
            return name;
        }

        public static string GetCertificateNumber()
        {
            string cerficateNumber = PageObject_ManageRedemptions.AdminManageRedemptionsAMRRewardsReceivedTextboxCertificateNo().GetAttribute("innerHTML");
            return cerficateNumber;
        }

        public static string GetExpirationDate()
        {
            string ExpirationDate = PageObject_ManageRedemptions.AdminManageRedemptionsAMRRewardsReceivedTextboxExpirationDate().GetAttribute("value");
            return ExpirationDate;
        }
        public static string GetEmail()
        {
            string Email = PageObject_ManageRedemptions.AdminManageRedemptions_AMRRewardsReceived_Textbox_Email().Text;
            return Email;
        }

        public static void ClickButtonResendCerificate()
        {
            Helper.ElementClick(PageObject_ManageRedemptions.AdminManageRedemptionsAMRRewardsReceivedButtonResendCertificate());
        }

        public static void ClickRadioButtonOther()
        {
            Helper.ElementClick(PageObject_ManageRedemptions.AdminManageRedemptionsAMRRewardsReceivedRadioButtonOther());
        }

        public static void ClickButtonSend()
        {
            Helper.ElementClick(PageObject_ManageRedemptions.AdminManageRedemptionsAMRRewardsReceivedButtonSend());
        }

        public static void EnterCustomerEmail(string text)
        {           
            Helper.ElementEnterText(PageObject_ManageRedemptions.AdminManageRedemptionsAMRRewardsReceivedTextboxCustomEmail(), text);            
        }

        public static void ClickButtonCancel()
        {
            Helper.ElementClick(PageObject_ManageRedemptions.AdminManageRedemptionsAMRRewardsReceivedButtonCancel());
        }

        public static void ClickButtonOk()
        {
            Helper.ElementClick(PageObject_ManageRedemptions.AdminManageRedemptionsAMRRewardsReceivedButtonOk());
        }

        public static void ClickButtonViewandPrint()
        {
            Helper.ElementClick(PageObject_ManageRedemptions.AdminManageRedemptionsAMRRewardsReceivedMailButtonViewandPrint());
        }
    }
}
