using System.Reflection;
using eInsight.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eInsight.PageObject.UI
{
    public class PageObject_Navigation : Setup
    {



        private static string PageName = Constants.Navigation;

        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/
        
        public static IWebElement UserProfileIcon()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.UserProfileIcon);
        }

        public static IWebElement AdminLink()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.AdminLink);
        }
        public static IWebElement SettingsLink()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SettingsLink);
        }

        public static IWebElement MyPreferenceLink()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.MyPreferenceLink);
        }
        public static IWebElement Home()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Home);
        }

        public static IWebElement Profile()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Profile);
        }
        public static IWebElement Audiences()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Audiences);
        }

        public static IWebElement CreateCampaign()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_CreateCampaign);
        }

        public static IWebElement ManageCampaign()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_ManageCampaign);
        }

        public static IWebElement Calendar()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Calendar);
        }

        public static IWebElement eGallery()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_eGallery);
        }

        public static IWebElement Reports()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Reports);
        }

        public static IWebElement Survey()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Survey);
        }


        public static IWebElement Link_Monitoring()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_Monitoring);
        }

        public static IWebElement Link_Settings()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_Settings);
        }

        public static IWebElement Link_Admin()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_Admin);
        }

        public static IWebElement Link_MainMenu()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_MainMenu);
        }

        public static IWebElement Link_Help()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_Help);
        }

        public static IWebElement Link_LogOut()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_LogOut);
        }

        public static IWebElement Link_ProductList_Show()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_ProductList_Show);
        }

        public static IWebElement Link_ProductList_eInsight()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_ProductList_eInsight);
        }

        public static IWebElement Link_ProductList_eConcierge()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_ProductList_eConcierge);
        }

        public static IWebElement Link_ProductList_eSurvey()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_ProductList_eSurvey);
        }

        public static IWebElement Link_ProductList_Loyalty()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_ProductList_Loyalty);
        }

        public static IWebElement Link_ProductList_eInsightReports()
        {
            ScanPage(Constants.Navigation);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Navigation_Link_ProductList_eInsightReports);
        }
    }
}