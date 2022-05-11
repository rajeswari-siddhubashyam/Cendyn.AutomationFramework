using System.Reflection;
using eInsight.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eInsight.PageObject.UI
{
    public class PageObject_Home : Setup
    {


        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/
        private static string PageName = Constants.Home;
        public static IWebElement Home_Vertical_Nav_Profile()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Vertical_Nav_Profile);
        }

        public static IWebElement Tab_AtAGlance_AllActivity()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Tab_AtAGlance_AllActivity);
        }

        public static IWebElement Tab_AtAGlance_Created()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Tab_AtAGlance_Created);
        }

        public static IWebElement Tab_AtAGlance_CriteriaChanged()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Tab_AtAGlance_CriteriaChanged);
        }

        public static IWebElement Tab_AtAGlance_TemplateChanged()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Tab_AtAGlance_TemplateChanged);
        }

        public static IWebElement Tab_AtAGlance_SentToTestEmailsHistory()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Tab_AtAGlance_SentToTestEmailsHistory);
        }

        public static IWebElement Tab_AtAGlance_DeliveryReportRequested()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Tab_AtAGlance_DeliveryReportRequested);
        }

        public static IWebElement Tab_AtAGlance_DeliveryReportReceived()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Tab_AtAGlance_DeliveryReportReceived);
        }

        public static IWebElement Tab_AtAGlance_ProceedForApproval()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Tab_AtAGlance_ProceedForApproval);
        }

        public static IWebElement Tab_AtAGlance_ApprovalRequested()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Tab_AtAGlance_ApprovalRequested);
        }

        public static IWebElement Tab_AtAGlance_Approved()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Tab_AtAGlance_Approved);
        }

        public static IWebElement Tab_AtAGlance_Disapproved()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Tab_AtAGlance_Disapproved);
        }

        public static IWebElement Tab_AtAGlance_Scheduled()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Tab_AtAGlance_Scheduled);
        }

        public static IWebElement Tab_AtAGlance_Rescheduled()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Tab_AtAGlance_Rescheduled);
        }

        public static IWebElement Tab_AtAGlance_ScheduleDeactivated()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Tab_AtAGlance_ScheduleDeactivated);
        }

        public static IWebElement Tab_AtAGlance_Sent()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Tab_AtAGlance_Sent);
        }

        public static IWebElement Tab_AtAGlance_Cancelled()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Tab_AtAGlance_Cancelled);
        }

        public static IWebElement Tab_AtAGlance_Previous()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Tab_AtAGlance_Previous);
        }

        public static IWebElement Tab_AtAGlance_Next()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Tab_AtAGlance_Next);
        }

        public static IWebElement Link_AtAGlance_GoToTab_Menu()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Link_AtAGlance_GoToTab_Menu);
        }

        public static IWebElement Link_AtAGlance_GoToTab_Created()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Link_AtAGlance_GoToTab_Created);
        }

        public static IWebElement Link_AtAGlance_GoToTab_CriteriaChanged()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Link_AtAGlance_GoToTab_CriteriaChanged);
        }

        public static IWebElement Link_AtAGlance_GoToTab_TemplateChanged()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Link_AtAGlance_GoToTab_TemplateChanged);
        }

        public static IWebElement Link_AtAGlance_GoToTab_SentToTestEmailsHistory()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Link_AtAGlance_GoToTab_SentToTestEmailsHistory);
        }

        public static IWebElement Link_AtAGlance_GoToTab_DeliveryReportRequested()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Link_AtAGlance_GoToTab_DeliveryReportRequested);
        }

        public static IWebElement Link_AtAGlance_GoToTab_DeliveryReportReceived()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Link_AtAGlance_GoToTab_DeliveryReportReceived);
        }

        public static IWebElement Link_AtAGlance_GoToTab_ProceedForApproval()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Link_AtAGlance_GoToTab_ProceedForApproval);
        }

        public static IWebElement Link_AtAGlance_GoToTab_ApprovalRequested()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Link_AtAGlance_GoToTab_ApprovalRequested);
        }

        public static IWebElement Link_AtAGlance_GoToTab_Approved()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Link_AtAGlance_GoToTab_Approved);
        }

        public static IWebElement Link_AtAGlance_GoToTab_Disapproved()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Link_AtAGlance_GoToTab_Disapproved);
        }

        public static IWebElement Link_AtAGlance_GoToTab_Scheduled()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Link_AtAGlance_GoToTab_Scheduled);
        }

        public static IWebElement Link_AtAGlance_GoToTab_Rescheduled()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Link_AtAGlance_GoToTab_Rescheduled);
        }

        public static IWebElement Link_AtAGlance_GoToTab_ScheduleDeactivated()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Link_AtAGlance_GoToTab_ScheduleDeactivated);
        }

        public static IWebElement Link_AtAGlance_GoToTab_Sent()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Link_AtAGlance_GoToTab_Sent);
        }

        public static IWebElement Link_AtAGlance_GoToTab_Cancelled()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Link_AtAGlance_GoToTab_Cancelled);
        }

        public static IWebElement Link_AtAGlance_Campaign_1()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Link_AtAGlance_Campaign_1);
        }

        public static IWebElement Link_AtAGlance_Campaign_2()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Link_AtAGlance_Campaign_2);
        }

        public static IWebElement Link_AtAGlance_Campaign_3()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Link_AtAGlance_Campaign_3);
        }

        public static IWebElement Link_AtAGlance_ViewAllActivity()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Link_AtAGlance_ViewAllActivity);
        }

        public static IWebElement Tab_RecentCampaigns()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Tab_RecentCampaigns);
        }

        public static IWebElement Tab_Dashboard()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Tab_Dashboard);
        }

        public static IWebElement Click_DropDown_DateRange_Marketing()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Home_RecentlySentCampaign_DateRange_Marketing);
        }
        public static IWebElement Click_DropDown_DateRange_Trigger()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Home_RecentlySentCampaign_DateRange_Trigger);
        }
        public static IWebElement Click_DropDown_DateRange_Transactional()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Home_RecentlySentCampaign_DateRange_Transactionals);
        }
        public static IWebElement DropDown_RecentlySentCampaigns_SelectClient()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_DropDown_RecentlySentCampaigns_SelectClient);
        }

        public static IWebElement DropDown_RecentlySentCampaigns_SelectCompany()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_DropDown_RecentlySentCampaigns_SelectCompany);
        }

        public static IWebElement Tab_RecentlySentCampaigns_Email()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Tab_RecentlySentCampaigns_Email);
        }

        public static IWebElement Tab_RecentlySentCampaigns_RealTime()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Tab_RecentlySentCampaigns_RealTime);
        }

        public static IWebElement Tab_RecentlySentCampaigns_TextMessage()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Tab_RecentlySentCampaigns_TextMessage);
        }

        public static IWebElement Tab_RecentlySentCampaigns_KeywordTextMessage()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Tab_RecentlySentCampaigns_KeywordTextMessage);
        }

        public static IWebElement Tab_RecentlySentCampaigns_TextMessageResponses()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Tab_RecentlySentCampaigns_TextMessageResponses);
        }

        public static IWebElement DropDown_RecentlySentCampaigns_ShowLast()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_DropDown_RecentlySentCampaigns_ShowLast);
        }

        public static IWebElement Button_RecentlySentCampaigns_CalendarFrom()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Button_RecentlySentCampaigns_CalendarFrom);
        }

        public static IWebElement Button_RecentlySentCampaigns_CalendarThrough()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Button_RecentlySentCampaigns_CalendarThrough);
        }

        public static IWebElement Button_RecentlySentCampaigns_Merge()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Button_RecentlySentCampaigns_Merge);
        }

        public static IWebElement Button_RecentlySentCampaigns_FirstPage()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Button_RecentlySentCampaigns_FirstPage);
        }

        public static IWebElement Button_RecentlySentCampaigns_PreviousPage()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Button_RecentlySentCampaigns_PreviousPage);
        }

        public static IWebElement Button_RecentlySentCampaigns_NextPage()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Button_RecentlySentCampaigns_NextPage);
        }

        public static IWebElement Button_RecentlySentCampaigns_LastPage()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Button_RecentlySentCampaigns_LastPage);
        }

        public static IWebElement Text_RecentlySentCampaigns_PageNumber()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Text_RecentlySentCampaigns_PageNumber);
        }

        public static IWebElement DropDown_RecentlySentCampaigns_DisplayResultsNumber()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_DropDown_RecentlySentCampaigns_DisplayResultsNumber);
        }

        public static IWebElement Button_RecentlySentCampaigns_ExcelReport()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Button_RecentlySentCampaigns_ExcelReport);
        }

        public static IWebElement Link_AtAGlance_GoToTab_AllActivity()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Link_AtAGlance_GoToTab_AllActivity);
        }

        public static IWebElement Home_Option_DatatableLength_Marketing()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Option_DatatableLength_Marketing);
        }
        public static IWebElement Home_Option_DatatableLength_Trigger()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_Option_DatatableLength_Trigger);
        }
        public static IWebElement Home_Option_DatatableLength_Transactional()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository. Home_Option_DatatableLength_Transactional);
        }

        public static IWebElement Home_RecentlySentCampaign_DateRange_Trigger_NoResult()
        {
            ScanPage(Constants.Home);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Home_RecentlySentCampaign_DateRange_Trigger_NoResult);
        }
    }
}