using System.Reflection;
using eInsight.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eInsight.PageObject.UI
{
    public class PageObject_PriorityQ : Setup
    {
        private static string PageName = Constants.PriorityQ;

        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/

        public static IWebElement PriorityQ_SearchFor()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.PriorityQ_SearchFor);
        }

        public static IWebElement PriorityQ_Reset()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.PriorityQ_Reset);
        }
        public static IWebElement PriorityQ_Submit()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.PriorityQ_Submit);
        }
        public static IWebElement PriorityQ_Filter()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.PriorityQ_Filter);
        }
        public static IWebElement PriorityQ_EnterEmailAddress()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.PriorityQ_ToEmail);
        }
        public static IWebElement PriorityQ_CampaignContainer()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementClassName(ObjectRepository.PriorityQ_CampaignContainer);
        }
        public static IWebElement PriorityQ_CampaignContainer_Filter()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.PriorityQ_CampaignContainer_filter);
        }
        public static IWebElement PriorityQ_SendtoTest()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.PriorityQ_SendtoTest);
        }
        public static IWebElement PriorityQ_SendtoTestButton()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.PriorityQ_SendtoTestButton);
        }

        public static IWebElement PriorityQ_SendEmail_Cancel()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.PriorityQ_SendEmail_Cancel);
        }
        //public static IWebElement PriorityQ_SendEmail_Modal_Cancel()
        //{
        //    ScanPage(PageName);
        //    CurrentPageName = PageName;
        //    CurrentElementName = MethodBase.GetCurrentMethod().Name;
        //    return PageAction.Find_ElementXPath(ObjectRepository.PriorityQ_SendEmail_Modal_Cancel);
        //}
        public static IWebElement PriorityQ_SendEmail_Prompt_Cancel()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.PriorityQ_SendEmail_Prompt_Cancel);
        }

    }
}
