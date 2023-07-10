using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BaseUtility.PageObject;
using BaseUtility.Utility;
using eLoyaltyV3.Utility;
using OpenQA.Selenium;

namespace eLoyaltyV3.PageObject.UI
{
    class PageObject_Redeem : Utility.Setup
    {


        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/
        public static string PageName = Constants.Reedem;

        public static IWebElement Button_Redeem()
        {
            ScanPage(Constants.Reedem);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Reedem_Button_Redeem);
        }

        public static IWebElement Navigation_Link_Redeem()
        {
            ScanPage(Constants.Reedem);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_Redeem);
        }

        public static IWebElement Redeem_Button_Frontend()
        {
            ScanPage(Constants.Reedem);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Redeem_Button_Frontend);
        }
        public static IWebElement Redeem_Button_Frontend2()
        {
            ScanPage(Constants.Reedem);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//h4[contains(text(),'egift')]//following::button[1]");
        }
        public static IWebElement Image_On_Redeem_Button_Frontend()
        {
            ScanPage(Constants.Reedem);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Image_On_Redeem_Button_Frontend);
        }

        public static IWebElement Ok_Button_On_EGift()
        {
            ScanPage(Constants.Reedem);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Ok_Button_On_EGift);
        }

        public static IWebElement Select_AwardImage()
        {
            ScanPage(Constants.Reedem);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_AwardImage);
        }

        public static IWebElement Click_Redeem_eGiftCart()
        {
            ScanPage(Constants.Reedem);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Redeem_eGiftCart);
        }

        public static IWebElement Click_Conform_eGiftCart()
        {
            ScanPage(Constants.Reedem);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Conform_eGiftCart);
        }

        public static IWebElement Click_Close_eGiftCart()
        {
            ScanPage(Constants.Reedem);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Close_eGiftCart);
        }

        public static IWebElement Lable_TotalPoints()
        {
            ScanPage(Constants.Reedem);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Lable_TotalPoints);
        }

        public static IWebElement Click_Redeem_CancelButton()
        {
            ScanPage(Constants.Reedem);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Redeem_CancelButton);
        }
        public static IWebElement Get_TotalPoints()
        {
            ScanPage(Constants.Reedem);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Get_TotalPoints);
        }

        public static IWebElement Get_RedeemedAwardName()
        {
            ScanPage(Constants.Reedem);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Get_RedeemedAwardName);
        }

        public static IWebElement Click_RequestSubmitted_OkButton()
        {
            ScanPage(Constants.Reedem);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_RequestSubmitted_OkButton);
        }
        public static IWebElement Click_RedeemeGift_Award(string name)
        {
            ScanPage(Constants.Reedem);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[contains(text(),'" + name + "')]//following::button[1]");
        }
        public static IWebElement Click_RedeemeGift_AwardNew()
        {
            ScanPage(Constants.Reedem);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("(//button[@class='btn btn-alternate btn-md redeemGiftBtn'])[1]");
        }

        public static IWebElement Get_RedeemProductName(string productName)
        {
            return Helper.Driver.FindElement(By.XPath("//*[contains(text(),'"+ productName + "')]"));
        }
        public static IWebElement Get_RedeemProductPoints(string productName)
        {
            return Helper.Driver.FindElement(By.XPath("//*[contains(text(),'"+productName+"')]/parent::*/descendant::div[@class='rewardPoints']"));
        }
        public static IWebElement Click_Redeem_Ok()
        {
            ScanPage(Constants.Reedem);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Redeem_Ok);
        }
        public static IWebElement Click_Redeem_Cancel()
        {
            ScanPage(Constants.Reedem);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Redeem_Cancel);
        }
    }
}
