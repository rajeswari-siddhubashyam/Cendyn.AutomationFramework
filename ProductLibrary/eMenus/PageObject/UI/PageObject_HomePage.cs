using System.Reflection;
using BaseUtility.PageObject;
using eMenus.Utility;
using OpenQA.Selenium;

namespace eMenus.PageObject.UI
{
    class PageObject_HomePage : Setup
    {
        public static string PageName = Utility.Constants.HomePage;
        public static IWebElement Click_HotelOrogami_Logo()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_HotelOrogami_Logo);
        }
        public static IWebElement Click_HomePage_Filter()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_HomePage_Filter);
        }
        public static IWebElement HomePage_ClearFilter()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.HomePage_ClearFilter);
        }
        public static IWebElement HomePage_ApplyFilter()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.HomePage_ApplyFilter);
        }
        public static IWebElement HomePage_Search()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.HomePage_Search);
        }
        public static IWebElement HomePage_FilterBy_GlutenFree()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.HomePage_FilterBy_GlutenFree);
        }
        public static IWebElement HomePage_FilterBy_Egg()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.HomePage_FilterBy_Egg);
        }
        public static IWebElement HomePage_FilterBy_Milk()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.HomePage_FilterBy_Milk);
        }
        public static IWebElement HomePage_FilterBy_MostPopular()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.HomePage_FilterBy_MostPopular);
        }
        public static IWebElement HomePage_DinnerDropdown()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.HomePage_DinnerDropdown);
        }
        public static IWebElement HomePage_Select_DinnerTable()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.HomePage_Select_DinnerTable);
        }
        public static IWebElement HomePage_DinnerTable_MenuInfoButton()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.HomePage_DinnerTable_MenuInfoButton);
        }
        public static IWebElement HomePage_BreakfastDropdown()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.HomePage_BreakfastDropdown);
        }
        public static IWebElement HomePage_Select_BreakfastBuffet()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.HomePage_Select_BreakfastBuffet);
        }
        
        public static IWebElement HomePage_Select_ContinentalBreakfast()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.HomePage_Select_ContinentalBreakfast);
        }
        public static IWebElement HomePage_BreakfastBuffet_MenuInfoButton()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.HomePage_BreakfastBuffet_MenuInfoButton);
        }
        public static IWebElement HomePage_ReceptionDropdown()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.HomePage_ReceptionDropdown);
        }
        public static IWebElement HomePage_Select_ActionStations()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.HomePage_Select_ActionStations);
        }
        public static IWebElement HomePage_ActionStations_MenuInfoButton()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.HomePage_ActionStations_MenuInfoButton);
        }
        public static IWebElement Click_HomePage_MoreButton()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_HomePage_MoreButton);
        }
        public static IWebElement HomePage_FilterBy_Favorite()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.HomePage_FilterBy_Favorite);
        }
        public static IWebElement Click_HomePage_LessButton()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_HomePage_LessButton);
        }
        public static IWebElement GlutenFree_MenuName()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.GlutenFree_MenuName);
        }
        public static IWebElement Egg_MenuName()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Egg_MenuName);
        }
        public static IWebElement MostPopular_MenuName()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MostPopular_MenuName);
        }
        public static IWebElement Get_Continental_brkfast_MenuPrice(string menuname)
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//div[contains(text(),'"+ menuname+ "')]//following::div[1]");
        }
        public static IWebElement Select_Event_date()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Select_Event_date);
        }
        public static IWebElement First_Menu_Price_Frontend(string menuname)
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//*[@id='Content']//div[contains(text(),'" + menuname + "')]//following-sibling::div[@class='price']");
        }
        public static IWebElement Added_CategoryDropDown(string categoryName)
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("(//*[@id='Wrapper']//a[contains(text(),'" + categoryName + "')])[1]");
        }
        public static IWebElement Click_Category_Sub_Menu(string categoryName)
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("//a[contains(text(),'" + categoryName + "')]");
        }
        public static IWebElement Click_Category_Menu()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath("/html/body/div[2]/div/div[2]/div/div[1]/a[last()]");
        }
        public static IWebElement Click_Link_Home()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Link_Home);
        }
        public static IWebElement Click_PrintIcon()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_PrintIcon);
        }
        public static IWebElement HomePage_Breakfast()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.HomePage_Breakfast);
        }
        public static IWebElement HomePage_Break()
        {
            ScanPage(Utility.Constants.HomePage);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.HomePage_Break);
        }
    }
}
