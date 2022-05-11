using System.Reflection;
using BaseUtility.PageObject;
using eLoyaltyV3.Utility;
using OpenQA.Selenium;

namespace eLoyaltyV3.PageObject.UI
{
    class PageObject_SpecialOffers : Setup
    {
        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/
        public static string PageName = Constants.SpecialOffers;

        public static IWebElement Text_Exclusive()
        {
            ScanPage(Constants.SpecialOffers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SpecialOffers_Text_Exclusive);
        }
        public static IWebElement Specialoffers_Button(string Specialofferes_promotioncode)
        {
            return PageAction.Find_ElementXPath("//*[@id='exclusi']//button[@data-promotioncode ='"+ Specialofferes_promotioncode + "']");
        }
        public static IWebElement Specialoffers_Readmore(string Specialofferes_offername)
        {
            return PageAction.Find_ElementXPath("//*[@id='exclusi']//*[contains(text(),'" + Specialofferes_offername + "')]//following::a");
        }
        public static IWebElement Specialoffers_LastButton()
        {
            ScanPage(Constants.SpecialOffers);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Specialoffers_LastButton);
        }
        
        
    }
}
