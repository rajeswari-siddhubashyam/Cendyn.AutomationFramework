
using BaseUtility.PageObject;
using RevIntel.Utility;
using OpenQA.Selenium;
using System.Reflection;
using System;

namespace RevIntel.PageObject.UI
{
    class PageObject_BusinessSource : Setup
    {
        public static string PageName = Utility.Constants.BusinessSource;

        public static IWebElement iframe_AgentSummary()
        {
            ScanPage(Utility.Constants.BusinessSource);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_AgentSummary);
        }
        
        public static IWebElement Click_AgentRoomTypeAnalysis()
        {
            ScanPage(Utility.Constants.BusinessSource);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_AgentRoomTypeAnalysis);
        }
        public static IWebElement iframe_Agent_Room_Type_Analysis()
        {
            ScanPage(Utility.Constants.BusinessSource);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Agent_Room_Type_Analysis);
        }
        public static IWebElement BookingStartDate()
        {
            ScanPage(Utility.Constants.BusinessSource);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.BookingStartDate);
        }
        public static IWebElement BookingEndDate()
        {
            ScanPage(Utility.Constants.BusinessSource);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.BookingEndDate);
        }
        public static IWebElement Click_Annual_Agent_Analysis_by_Month()
        {
            ScanPage(Utility.Constants.BusinessSource);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Annual_Agent_Analysis_by_Month);
        }
        public static IWebElement iframe_Annual_Agent_Analysis_by_Month()
        {
            ScanPage(Utility.Constants.BusinessSource);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Annual_Agent_Analysis_by_Month);
        }
        public static IWebElement Year_DDL()
        {
            ScanPage(Utility.Constants.BusinessSource);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Year_DDL);
        }
        public static IWebElement Year_value()
        {
            ScanPage(Utility.Constants.BusinessSource);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Year_value);
        }
        public static IWebElement Click_Company_Analysis()
        {
            ScanPage(Utility.Constants.BusinessSource);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Company_Analysis);
        }
        public static IWebElement iframe_Company_Analysis()
        {
            ScanPage(Utility.Constants.BusinessSource);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Company_Analysis);
        }
        public static IWebElement kerner_Portfolio()
        {
            ScanPage(Utility.Constants.BusinessSource);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.kerner_Portfolio);
        }
        public static IWebElement Click_Annual_Company_Analysis_by_Month()
        {
            ScanPage(Utility.Constants.BusinessSource);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Annual_Company_Analysis_by_Month);
        }
        public static IWebElement iframe_Annual_Company_Analysis_by_Month()
        {
            ScanPage(Utility.Constants.BusinessSource);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Annual_Company_Analysis_by_Month);
        }
        public static IWebElement Annual_Company_Analysis_by_Month_CompanyDDL()
        {
            ScanPage(Utility.Constants.BusinessSource);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Annual_Company_Analysis_by_Month_CompanyDDL);
        }
        public static IWebElement Annual_Company_Analysis_by_Month_Company_Select()
        {
            ScanPage(Utility.Constants.BusinessSource);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Annual_Company_Analysis_by_Month_Company_Select);
        }
        public static IWebElement Company_Summary_Portfolio()
        {
            ScanPage(Utility.Constants.BusinessSource);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Company_Summary_Portfolio);
        }
        public static IWebElement Click_Company_Summary()
        {
            ScanPage(Utility.Constants.BusinessSource);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Company_Summary);
        }
        public static IWebElement iframe_Company_Summary()
        {
            ScanPage(Utility.Constants.BusinessSource);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Company_Summary);
        }
      
    }
}
