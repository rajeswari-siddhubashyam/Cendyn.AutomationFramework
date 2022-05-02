using BaseUtility.PageObject;
using CHC.Utility;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Reflection;

namespace CHC.PageObject.UI
{
    class PageObject_ManageCampaign : Setup
    {
        public static string PageName = Utility.Constants.ManageCampaign;


        public static IList<IWebElement> Campaign_Filter_DropDown_FilterOptions()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Manage_Campaign_Filter_DropDown_FilterOptions);
        }

        public static IWebElement Campaign_Filter_Status_DropDown_Arrow()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Manage_Campaign_Filter_Status_DropDown_Arrow);
        }
        public static IWebElement Campaign_Filter_Status_DropDown_Input()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Manage_Campaign_Filter_Status_DropDown_Input);
        }

        public static IWebElement Campaign_Filter_UpdatedOn_Input()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Manage_Campaign_Filter_UpdatedOn_Input);
        }

        public static IList<IWebElement> Campaign_Filter_Status_DropDown_Options()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Manage_Campaign_Filter_Status_DropDown_Options);
        }
        public static IWebElement Campaign_Filter_ID_Text()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Manage_Campaign_Filter_ID_Text);
        }
       
    }
}
