using BaseUtility.Utility;
using eLoyaltyV3.PageObject.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace eLoyaltyV3.AppModule.UI
{
    class Redeem
    {
        public static void Click_Button_Redeem()
        {
            //Helper.ElementClickUsingJavascript(PageObject_Redeem.Navigation_Link_Redeem());
            PageObject_Redeem.Navigation_Link_Redeem().Click();
        }
        public static void Click_Redeem_Button_Frontend()
        {

            PageObject_Redeem.Redeem_Button_Frontend().Click();
        }
        public static void Redeem_Button_Frontend2()
        {

            PageObject_Redeem.Redeem_Button_Frontend2().Click();
        }

        public static void Click_Ok_Button_On_EGift()
        {
            PageObject_Redeem.Ok_Button_On_EGift().Click();
        }

        public static void Select_AwardImage()
        {
            PageObject_Redeem.Select_AwardImage().Click();
        }

        public static void Click_Redeem_eGiftCart()
        {
            PageObject_Redeem.Click_Redeem_eGiftCart().Click();
        }

        public static void Click_Conform_eGiftCart()
        {
            PageObject_Redeem.Click_Conform_eGiftCart().Click();
        }
        public static void Click_Close_eGiftCart()
        {
            PageObject_Redeem.Click_Close_eGiftCart().Click();
        }

        public static void Click_Redeem_CancelButton()
        {
            Helper.ElementWait(PageObject_Redeem.Click_Redeem_CancelButton(), 120);
            PageObject_Redeem.Click_Redeem_CancelButton().Click();
        }
        public static void Click_RequestSubmitted_OkButton()
        {
            Helper.ElementWait(PageObject_Redeem.Click_RequestSubmitted_OkButton(), 120);
            PageObject_Redeem.Click_RequestSubmitted_OkButton().Click();
        }
        public static void Click_RedeemeGift_Award(string name)
        {
            Helper.ElementWait(PageObject_Redeem.Click_RedeemeGift_Award(name), 120);
            PageObject_Redeem.Click_RedeemeGift_Award(name).Click();
        }
        public static void Click_Redeem_Button_ForAward(string redeemProductName)
        {
            Helper.Driver.FindElement(By.XPath("//*[contains(text(),'" + redeemProductName + "')]/parent::*/descendant::button[contains(translate(., 'ABCDEFGHIJKLMNOPQRSTUVWXYZ', 'abcdefghijklmnopqrstuvwxyz'),'redeem')]")).Click();
        }
        public static void Click_Redeem_Ok()
        {
            PageObject_Redeem.Click_Redeem_Ok().Click();
        }
        public static void Click_Redeem_Cancel()
        {
            PageObject_Redeem.Click_Redeem_Cancel().Click();
        }

    }
}
