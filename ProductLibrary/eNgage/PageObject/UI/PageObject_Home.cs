using System.Reflection;
using eNgage.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace eNgage.PageObject.UI
{
    public class PageObject_Home : Setup
    {


        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/
        private static string PageName = Constants.Home;

        public static IWebElement Nav_Home()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementLinkText(ObjectRepository.Home_Main);
        }
        public static IList<IWebElement> Dashboard_Tiles()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return Driver.FindElements(By.ClassName(ObjectRepository.Dashboard_Tiles));
            //return PageAction.Find_ElementClassName(ObjectRepository.Dashboard_Tiles);
        }
        public static IWebElement Dashboard_FirstTile()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return Driver.FindElement(By.ClassName(ObjectRepository.Dashboard_Tiles));
        }
        public static IWebElement Home_Date()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return Driver.FindElement(By.Id(ObjectRepository.Home_Date));
            //return PageAction.Find_ElementId(ObjectRepository.Home_Date);
        }
        public static IWebElement Home_Calendar_Table()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return Driver.FindElement(By.ClassName(ObjectRepository.Home_Calendar_Table));
            //return PageAction.Find_ElementClassName(ObjectRepository.Home_Calendar_Table);
        }
        public static IWebElement Home_Calendar_Prev_Month()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return Home_Calendar_Table().FindElement(By.ClassName(ObjectRepository.Home_Calendar_Prev_Month));
        }
        public static IWebElement Nav_OtherTabs()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementClassName(ObjectRepository.Home_Hamburger_button);
        }
        public static IWebElement Home_HeaderContainer()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementClassName(ObjectRepository.Home_HeaderContainer);
        }
        public static IWebElement Home_SelectedHotel()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return Home_HeaderContainer().FindElement(By.TagName(ObjectRepository.Home_SelectedHotel));
        }
        public static IList<IWebElement> Home_Hotels_List()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return Home_HeaderContainer().FindElements(By.CssSelector(ObjectRepository.Home_Hotels_List));
        }
        public static IList<IWebElement> Home_Hotels_Active_List()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return Home_HeaderContainer().FindElements(By.CssSelector(ObjectRepository.Home_Hotels_Active_List));
        }
        public static string Home_DashboardTile_Res_Count()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return Dashboard_FirstTile().FindElement(By.CssSelector(ObjectRepository.Home_DashboardTile_Res_count)).Text;
        }
        public static string Home_DashboardTile_Count(IWebElement element)
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return element.FindElement(By.CssSelector(ObjectRepository.Home_DashboardTile_Res_count)).Text;
        }
        public static IWebElement Home_Search_hotel()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return Home_HeaderContainer().FindElement(By.CssSelector(ObjectRepository.Home_Search_hotel));
        }
        public static IWebElement Home_LastUpdated()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_LastUpdated);
        }
        public static IWebElement Home_Refresh()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Refresh);
        }
        public static IWebElement Home_Departures()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Departures);
        }
        public static string Home_DashboardTile_ProgressBar_Width(IWebElement element)
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return element.FindElement(By.CssSelector(ObjectRepository.Home_DashboardTile_ProgressBar_Width)).GetCssValue("width");
        }
        public static string Home_DashboardTile_ProgressPercentage(IWebElement element)
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return element.FindElement(By.CssSelector(ObjectRepository.Home_DashboardTile_ProgressPercentage)).Text;
        }
        public static string Home_DashboardTile_Text(IWebElement element)
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return element.FindElement(By.CssSelector(ObjectRepository.Home_DashboardTile_Text)).Text;
        }
        public static IWebElement Home_DashboardTile_Icon(IWebElement element)
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return element.FindElement(By.CssSelector(ObjectRepository.Home_DashboardTile_Icon));
        }

    }
}