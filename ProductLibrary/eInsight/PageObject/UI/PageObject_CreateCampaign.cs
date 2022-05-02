using System.Reflection;
using eInsight.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace eInsight.PageObject.UI
{
    public class PageObject_CreateCampaign : Setup
    {


        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/


        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/

        public static string PageName = Constants.CreateCampaign;

        public static IWebElement CreateCampaign_Button_Save()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.CreateCampaign_Button_Save);
        }
        public static IWebElement CreateCampaign_CriteriaPage_Save()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_CriteriaPage_Save);
        }
        public static IWebElement CreateCampaign_CriteriaPage_SaveandContinue()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_CriteriaPage_SaveandContinue);
        }
        public static IWebElement CreateCampaign_Button_SaveandContinue()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.CreateCampaign_Button_SaveAndContinue);
        }
        public static IWebElement CreateCampaign_Button_Continue()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.CreateCampaign_Button_Continue);
        }

        public static IWebElement CreateCampaign_Button_SaveandContinue_Submit()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.CreateCampaign_Button_SaveAndContinue_Submit);
        }
        
        public static IWebElement CreateCampaign_Link_CriteriaTab()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Link_CriteriaTab);
        }
        public static IWebElement TotalColumnArrow()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Link_CriteriaTab_TotalArrow);
        }
        public static IList<IWebElement> TotalColumnLoader()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return Driver.FindElements(By.XPath(ObjectRepository.CreateCampaign_Link_CriteriaTab_Loader));
        }
        public static IWebElement GenerateCount()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Link_CriteriaTab_Generate);
        }
        public static IWebElement Click_CreateCampaign_ForecastAudience()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_CriteriaTab_ForecastTargetAudience);
        }
        public static IWebElement CreateCampaign_Link_TemplateTab()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Link_TemplateTab);
        }
        public static IWebElement CreateCampaign_Button_ChangeTemplate()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.CreateCampaign_Button_ChangeTemplate);
        }
        public static IWebElement CreateCampaign_Link_TestingTab()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Link_TestingTab);
        }
        public static IWebElement CreateCampaign_Link_ApprovalTab()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Link_ApprovalTab);
        }
        public static IWebElement CreateCampaign_Link_ScheduleTab()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Link_ScheduleTab);
        }

        public static IWebElement Link_AMResorts()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Link_AMResorts);
        }

        public static IWebElement Link_()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Link_);
        }

        public static IWebElement Text_Filter()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Text_Filter);
        }

        public static IWebElement Link_CendynHotel()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Link_CendynHotel);
        }

        public static IWebElement Link_CendynHotelResort()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Link_CendynHotelResort);
        }

        /*Testing Tab*/
        public static IWebElement Button_SendToTest()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.CreateCampaign_Button_TestingSendtoTest);
        }

        /*Approval Tab*/
        public static IWebElement Button_SendForApproval()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.CreateCampaign_Testing_SendForApproval);
        }
        public static IWebElement Button_Approve()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.CreateCampaign_Link_Campaign_Approve);
        }
        public static IWebElement Button_Approve_Confirm()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Link_Campaign_ApproveConfirmation);
        }
        public static IWebElement Button_Disapprove()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.CreateCampaign_Link_Campaign_Disapprove);
        }
        public static IWebElement Button_Disapprove_Confirm()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Link_Campaign_DisapproveConfirmation);
        }

        /*Schedule Campaign*/
        public static IWebElement DropDown_Schedule_Hours()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.CreateCampaign_DropDown_Schedule_Hours);
        }
        public static IWebElement DropDown_Schedule_Minutes()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.CreateCampaign_DropDown_Schedule_Minutes);
        }
        public static IWebElement DropDown_Schedule_TimeType()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.CreateCampaign_DropDown_Schedule_TimeType);
        }
        public static IWebElement Button_Campaign_ScheduleandCompleteCampaign()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Button_Campaign_ScheduleandCompleteCampaign);
        }
        public static IWebElement ManageCampaign_EditSchedule_UpdateSchedule()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Button_Campaign_UpdateSchedule);
        }
        public static IWebElement CreateCampaign_EditTemplate_Subject()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.CreateCampaign_EditTemplate_Subject);
        }
        public static IWebElement CreateCampaign_EditTemplate_LinkSubjectTag()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.CreateCampaign_EditTemplate_LinkSubjectTag);
        }
        public static IWebElement CreateCampaign_EditTemplate_LinkSubjectTag_Map()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.CreateCampaign_EditTemplate_LinkSubjectTag_Map);
        }
        public static IWebElement CreateCampaign_EditTemplate_FromName()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.CreateCampaign_EditTemplate_FromName);
        }
        public static IWebElement CreateCampaign_EditTemplate_ReplyEmail()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.CreateCampaign_EditTemplate_ReplyEmail);
        }
        public static IWebElement CreateCampaign_AudienceName_ApprovalPage(string audienceName)
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_AudienceName_ApprovalPage.Replace("#AudienceName#", audienceName));
        }
        public static IWebElement CreateCampaign_AudienceName_SchedulePage(string audienceName)
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_AudienceName_SchedulePage.Replace("#AudienceName#", audienceName));
        }

        public static IWebElement CreateCampaign_Templates_ListView()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.CreateCampaign_Templates_ListView_Btn);
        }
        public static string CreateCampaign_Templates_ListView_Loader()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return ObjectRepository.CreateCampaign_Templates_ListView_Loader;
        }

        public static IWebElement CreateCampaign_Templates_Name_FilterIcon()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Templates_ListView_NameFilterIcon);
        }

        public static IWebElement CreateCampaign_Templates_SelectOption()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Templates_ListView_FilterSelection);
        }
        public static IWebElement CreateCampaign_Templates_ListView_FilterBtn()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.CreateCampaign_Templates_ListView_Filter_Btn);
        }
        public static IWebElement CreateCampaign_Templates_ListView_Input_Filter()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.CreateCampaign_Templates_ListView_Input_Filter_Txt);
        }

        public static IWebElement CreateCampaign_Templates_SaveAndContinue()
        {
            ScanPage(PageName);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.CreateCampaign_Templates_SaveAndContinue_Btn);
        }
    }
}