using System;
using System.Collections.Generic;
using BaseUtility.PageObject;
using MarketingAutomation.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace MarketingAutomation.PageObject.UI
{
    class PageObject_ManageCampaign : Setup
    {
        public static string PageName = Utility.Constants.ManageCampaign;

        public static IWebElement Card_View()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Card_View);
        }

        public static IWebElement List_View()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.List_View);
        }

        public static IWebElement Automated_Toggle_Button()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Automated_Toggle_Button);
        }

        public static IWebElement Marketing_Toggle_Button()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Marketing_Toggle_Button);
        }

        public static IWebElement Hover_ListView_CampaignName()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Hover_ListView_CampaignName);
        }
        
        public static IWebElement Hover_ListView_CampaignAudience()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Hover_ListView_CampaignAudience);

        }

        public static IWebElement Campaign_ID()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_ID);
        }
        public static IWebElement ManageCapaign_Audience_Name()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCapaign_Audience_Name);
        }
        public static IWebElement ManageCapaign_Update_By()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCapaign_Update_By);
        }

        public static IWebElement ManageCapaign_Updated_ON()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCapaign_Updated_ON);
        }
        public static IWebElement ManageCapaign_Status()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCapaign_Status);
        }
        public static IWebElement Click_Approved_from_listGrid()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Approved_from_listGrid);
        }
        
        public static IList<IWebElement> Campaign_Cards()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Cards);
        }
        
        public static IWebElement Click_ToVerifyLogout()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_ToVerifyLogout);
        }
        public static IWebElement VerifyLoggedinDashboard()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.VerifyLoggedinDashboard);
        }

        public static IWebElement Click_ManageCampaign_Ellipse()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_ManageCampaign_Ellipse);
        }
        public static IWebElement Click_ManageCampaign_Ellipse_Edit()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_ManageCampaign_Ellipse_Edit);
        }
        public static IWebElement Click_ManageCampaign_Ellipse_ViewDetails()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_ManageCampaign_Ellipse_ViewDetails);
        }
        public static IWebElement Click_ManageCampaign_Ellipse_ViewDetails_Subject()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_ManageCampaign_Ellipse_ViewDetails_Subject);
        }

        public static IWebElement CardView_Campaign_ID()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CardView_Campaign_ID);
        }
        public static IWebElement CardView_Campaign_Status()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CardView_Campaign_Status);
        }
    }
}