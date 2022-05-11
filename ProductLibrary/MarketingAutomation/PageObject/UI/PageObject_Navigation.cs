using BaseUtility.PageObject;
using MarketingAutomation.Utility;
using OpenQA.Selenium;
using System.Reflection;
using System.Collections.Generic;

namespace MarketingAutomation.PageObject.UI
{
    class PageObject_Navigation: Setup
    {
        public static string PageName = Utility.Constants.Navigation;

        public static IWebElement Button_Campaigns()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Button_Campaigns);

        }
        public static IWebElement Button_Campaigns_Sidebar()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Button_Campaigns_Sidebar);

        }
        public static IWebElement Text_SideNavMAutomation()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_text_MAutomation);

        }

        public static string Text_SideNavMAutomationXpath()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return ObjectRepository.Navigation_text_MAutomation;

        }
        public static IWebElement Button_Templates_Sidebar()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Button_Templates);
        }
        
        //-TODOPK: Remove it later
        public static IWebElement Button_Audience_Sidebar()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Button_Audiences);

        }
        public static IWebElement To_MAutomation_FromCH()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_To_MAutomation_FromCHC);

        }
        public static IList<IWebElement> GetNumberOfNavigatorLinks()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.TotalNavigatingNavbar);
        }
    }
}
