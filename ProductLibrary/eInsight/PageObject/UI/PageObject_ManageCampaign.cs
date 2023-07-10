using System.Reflection;
using eInsight.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eInsight.PageObject.UI
{
    public class PageObject_ManageCampaign : Setup
    {


        private static string PageName = Constants.ManageCampaign;

        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/

        public static IWebElement ManageCampaign_AllTab()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_AllTab);
        }

        public static IWebElement ManageCampaign_DraftTab()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_DraftTab);
        }

        public static IWebElement ManageCampaign_DeliverabilityTab()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_DeliverabilityTab);
        }

        public static IWebElement ManageCampaign_AwaitingApprovalTab()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_AwaitingApprovalTab);
        }

        public static IWebElement ManageCampaign_ApprovedTab()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_ApprovedTab);
        }

        public static IWebElement ManageCampaign_RecurringTab()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_RecurringTab);
        }

        public static IWebElement ManageCampaign_ScheduledTab()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_ScheduledTab);
        }

        public static IWebElement ManageCampaign_DisapprovedTab()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_DisapprovedTab);
        }

        public static IWebElement ManageCampaign_SearchTab()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_SearchTab);
        }

        public static IWebElement ManageCampaign_Search_SearchFieldDDM()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_Search_SearchFieldDDM);
        }

        public static IWebElement ManageCampaign_Search_ConditionDDM()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_Search_ConditionDDM);
        }

        public static IWebElement ManageCampaign_Search_Input()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_Search_Input);
        }

        public static IWebElement ManageCampaign_Search_SearchDateDDM()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_Search_SearchDateDDM);
        }

        public static IWebElement ManageCampaign_Search_BetweenFirst()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_Search_BetweenFirst);
        }

        public static IWebElement ManageCampaign_Search_BetweenSecond()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_Search_BetweenSecond);
        }

        public static IWebElement ManageCampaign_Search_SearchButton()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_Search_SearchButton);
        }

        public static IWebElement ManageCampaign_Search_PreviewLink()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Search_PreviewLink);
        }

        public static IWebElement ManageCampaign_Search_CriteriaLink()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Search_CriteriaLink);
        }

        public static IWebElement ManageCampaign_Search_CustomerDetails()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Search_CustomerDetails);
        }

        public static IWebElement ManageCampaign_Search_DynamicContentLink()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Search_DynamicContentLink);
        }

        public static IWebElement ManageCampaign_Search_HistoryLink()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Search_HistoryLink);
        }

        public static IWebElement ManageCampaign_Search_ReportsLink()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Search_ReportsLink);
        }

        public static IWebElement ManageCampaign_Search_MultiLanguageLink()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Search_MultiLanguageLink);
        }

        public static IWebElement ManageCampaign_Clone()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_Clone);
        }


        public static IWebElement ManageCampaign_Search_PreviewClose()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Search_PreviewClose);
        }


        public static IWebElement ManageCampaign_Search_CriteriaClose()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Search_CriteriaClose);
        }


        public static IWebElement ManageCampaign_Search_CustomerDetailsClose()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Search_CustomerDetailsClose);
        }


        public static IWebElement ManageCampaign_Search_DynamicContentClose()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Search_DynamicContentClose);
        }


        public static IWebElement ManageCampaign_Search_HistoryClose()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Search_HistoryClose);
        }


        public static IWebElement ManageCampaign_Search_ReportsClose()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Search_ReportsClose);
        }


        public static IWebElement ManageCampaign_MultiLanguageClose()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_MultiLanguageClose);
        }

        public static IWebElement ManageCampaign_ClientDDM()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_ClientDDM);
        }

        public static IWebElement ManageCampaign_CompanyDDM()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_CompanyDDM);
        }


        public static IWebElement Tab_Sent()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Tab_Sent);
        }

        public static IWebElement Tab_Disapproved()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Tab_Disapproved);
        }

        public static IWebElement Button_First()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Button_First);
        }

        public static IWebElement Button_Previous()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Button_Previous);
        }

        public static IWebElement Button_Next()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Button_Next);
        }

        public static IWebElement Button_Last()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Button_Last);
        }

        public static IWebElement Button_Help()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Button_Help);
        }

        public static IWebElement Link_FirstCampaign_Preview()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Link_FirstCampaign_Preview);
        }

        public static IWebElement Link_FirstCampaign_Criteria()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Link_FirstCampaign_Criteria);
        }

        public static IWebElement Link_FirstCampaign_CustomerDetails()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Link_FirstCampaign_CustomerDetails);
        }

        public static IWebElement Link_FirstCampaign_DynamicContent()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Link_FirstCampaign_DynamicContent);
        }

        public static IWebElement Link_FirstCampaign_History()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Link_FirstCampaign_History);
        }

        public static IWebElement Link_FirstCampaign_Reports()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Link_FirstCampaign_Reports);
        }

        public static IWebElement Link_FirstCampaign_MultiLanguage()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Link_FirstCampaign_MultiLanguage);
        }

        public static IWebElement Link_FirstCampaign_ApprovalDashboard()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Link_FirstCampaign_ApprovalDashboard);
        }

        public static IWebElement Button_Campaign_BasicValidationReport()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Button_Campaign_BasicValidationReport);
        }

        public static IWebElement Button_Campaign_ScheduleCampaign()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_Button_Campaign_ScheduleCampaign);
        }
        
        public static IWebElement Button_FirstCampaign_AdvancedDeliverability()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Button_FirstCampaign_AdvancedDeliverability);
        }

        public static IWebElement Button_FirstCampaign_SendToTestEmails()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Button_FirstCampaign_SendToTestEmails);
        }

        public static IWebElement Button_FirstCampaign_RequestResponsive()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Button_FirstCampaign_RequestResponsive);
        }

        public static IWebElement Button_FirstCampaign_SendForTranslation()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Button_FirstCampaign_SendForTranslation);
        }

        public static IWebElement Button_FirstCampaign_DeleteCampaign()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Button_FirstCampaign_DeleteCampaign);
        }

        public static IWebElement Button_FirstCampaign_Edit()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Button_FirstCampaign_Edit);
        }

        public static IWebElement Button_ContinueDraft()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_ContinueDraft);
        }

        public static IWebElement Button_FirstCampaign_ProceedForApproval()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Button_FirstCampaign_ProceedForApproval);
        }

        public static IWebElement Button_FirstCampaign_SaveAsTemplate()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Button_FirstCampaign_SaveAsTemplate);
        }

        public static IWebElement Button_FirstCampaign_SaveAsResent()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Button_FirstCampaign_SaveAsResent);
        }

        public static IWebElement Button_FirstCampaign_Clone()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Button_FirstCampaign_Clone);
        }

        public static IWebElement Link_FirstCampaign_Status()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Link_FirstCampaign_Status);
        }

        public static IWebElement Button_ViewCampaignRecipients()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_Button_CDetails_ViewCampaignRecipients);
        }
        public static IWebElement DDM_SearchBy()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_DDM_SearchBy);
        }
        public static IWebElement DDM_SearchExpression()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_DDM_SearchExpression);
        }
        public static IWebElement TextValue_SearchValue()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_DDM_SearchValue);
        }
        public static IWebElement Click_Searchbutton()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_CustomerDetailsVRD_ClickSearch);
        }
        public static IWebElement CheckBox_CASL()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.CASL_checkbox);
        }
        public static IWebElement Testcatchall_checkboxL()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Testcatchall_checkbox);
        }
        public static IWebElement Button_SendToTest()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.SubmitSendToTestEmail);
        }
        public static IWebElement QuickSend_EmailtoSelf()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.QuickSend_EmailtoSelf);
        }
        public static IWebElement ManageCampaign_EditSchedule()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_EditSchedule);
        }
        public static IWebElement ManageCampaign_EditSchedule_Confirm()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_EditSchedule_Confirm);
        }

        public static IWebElement ManageCampaign_EditCampaign(string projectID)
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_EditCampaign.Replace("#ProjectID#", projectID));
        }
        public static IWebElement ManageCampaign_ScheduleCampaign()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_ScheduleCampaign);
        }
        public static IWebElement ManageCampaign_EditSchedule_InactivateSchedule()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_Button_Campaign_InactivateSchedule);
        }
        public static IWebElement ManageCampaign_EditSchedule_InactivateScheduleConfirm()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Button_Campaign_InactivateScheduleConfirm);
        }
        public static IWebElement ManageCampaign_EditSchedule_ActivateSchedule()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_Button_Campaign_ActivateSchedule);
        }
        public static IWebElement ManageCampaign_EditSchedule_ActivateScheduleConfirm()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_Button_Campaign_ActivateScheduleConfirm);
        }
        public static IWebElement Select_GroupSeedList(string groupName)
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ManageCampaign_SendToTest_GroupSeedList.Replace("GroupName", groupName));
        }
        public static IWebElement ManageCampaign_QuickSend_ReservationSelect()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.ManageCampaign_QuickSend_ReservationSelect);
        }
        /*New OR for Manage Campaign Redesign*/

        public static IWebElement ManageCampaign_SearchProjectID()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProjectID_Search);
        }
        public static IWebElement ProjectStatus_Search()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProjectStatus_Search);
        }
        public static IWebElement ProjectStatus_TextSearch()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProjectStatus_TextSearch);
        }
        
        public static IWebElement ManageCampaign_SearchProjectIDExpression()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProjectID_SearchExpression);
        }

        public static IWebElement ManageCampaign_SearchProjectIDText()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProjectID_TextSearch);
        }

        public static IWebElement ManageCampaign_SearchProjectIDTexts()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProjectID_TextSearchs);
        }

        public static IWebElement ManageCampaign_SearchProjectID_Filter()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProjectID_TextSearch_Filter);
        }
        public static IWebElement ManageCampaign_SearchProjectID_Filters()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProjectID_TextSearch_Filters);
        }
        public static IWebElement ManageCampaign_CustomerDetails_Testing(string projectID)
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProjectID_CampaignDetails_Testing.Replace("#ProjetID#", projectID));
        }
        public static IWebElement ManageCampaign_CustomerDetails_Testing_Advanced()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
             return PageAction.Find_ElementXPath(ObjectRepository.ProjectID_CampaignDetails_Testing_Advanced);
        }
        public static IWebElement ManageCampaign_CustomerDetails_Testing_Advanced_InboxPreview()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProjectID_CampaignDetails_Testing_Advanced_InboxPreview);
        }
        public static IWebElement ManageCampaign_CustomerDetails_Testing_Advanced_InboxForecaster()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProjectID_CampaignDetails_Testing_Advanced_InboxForecaster);
        }

        public static IWebElement ProjectID_CampaignDetails_Actions()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ProjectID_CampaignDetails_Actions);
        }
        public static IWebElement CampaignDetails_Actions_Edit()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CampaignDetails_Actions_Edit);
        }
        public static IWebElement CampaignDetails_Actions_Clone()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CampaignDetails_Actions_Clone);
        }
        public static IWebElement CampaignDetails_Actions_Delete()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CampaignDetails_Actions_Delete);
        }
        public static IWebElement CampaignDetails_Actions_SaveAsResend()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CampaignDetails_Actions_SaveAsResend);
        }
        public static IWebElement CampaignDetails_Actions_SaveAsTemplate()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CampaignDetails_Actions_SaveAsTemplate);
        }
    }
}