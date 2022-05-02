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
    class PageObject_ManageTemplate : Setup
    {
        public static string PageName = Utility.Constants.ManageTemplate;
        public static IWebElement Column_Filter_Options_Arrow()
        {
            ScanPage(Constants.ManageTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Manage_Template_Column_Filter_Options_Arrow);
        }

        public static IList<IWebElement> Filter_Options_List()
        {
            ScanPage(Constants.ManageTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Manage_Template_Filter_Options_List);
        }
        
        public static IWebElement Filter_Input()
        {
            ScanPage(Constants.ManageTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Manage_Template_Filter_Input);
        }
        public static IWebElement Filter_Text()
        {
            ScanPage(Constants.ManageTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Manage_Template_Filter_Text);
        }

        public static IWebElement Clear_Filters_Button_No_Result()
        {
            ScanPage(Constants.ManageTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Manage_Template_Clear_Filters_No_Result);
        }

        public static IWebElement Clear_Filters_Button_No_Result_NoElement()
        {
            IWebElement ele = null; 
            ScanPage(Constants.ManageTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            try
            {
                ele = Driver.FindElement(By.XPath(ObjectRepository.Manage_Template_Clear_Filters_No_Result));
            }
            catch (Exception) { }
            return ele;
        }

        public static IWebElement Template_List_View_Details()
        {
            ScanPage(Constants.ManageTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Manage_Template_List_View_Details);
        }
        public static IWebElement Template_Filter_Input_Dates()
        {
            ScanPage(Constants.ManageTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Manage_Template_Filter_Input_Dates);
        }
    }
}
