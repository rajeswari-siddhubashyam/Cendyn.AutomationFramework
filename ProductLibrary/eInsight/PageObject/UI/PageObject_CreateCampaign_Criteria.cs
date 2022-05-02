using System.Reflection;
using eInsight.Utility;
using BaseUtility.PageObject;
using OpenQA.Selenium;

namespace eInsight.PageObject.UI
{
    public class PageObject_CreateCampaign_Criteria : Setup
    {


        /*
		/ These methods will return the element on the pages by passing in the page module and the name of the function which is used to reference the element on the Objectrespository class. The function name will match the Objectrespository string name. 
		*/


        public static string PageName = Constants.CreateCampaign_Criteria;

        public static IWebElement Text_CampaignName()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_Text_CampaignName);
        }

        public static IWebElement Text_Brand()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_Text_Brand);
        }

        public static IWebElement Button_Brand_RemoveFirstBrand()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_Button_Brand_RemoveFirstBrand);
        }

        public static IWebElement Button_Save()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_Button_Save);
        }

        //public static IWebElement Button_SaveAndContinue()
        //{
        //    ScanPage(Constants.CreateCampaign_Criteria);
        //    CurrentPageName = PageName;
        //    CurrentElementName = MethodBase.GetCurrentMethod().Name;
        //    return PageAction.Find_ElementId(ObjectRepository.CreateCampaign_Criteria_Button_SaveAndContinue);
        //}

        public static IWebElement Button_Clear()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_Button_Clear);
        }

        public static IWebElement Text_PropertyList()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_Text_PropertyList);
        }

        public static IWebElement Button_PropertyList_RemoveFirstPropertyList()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_Button_PropertyList_RemoveFirstPropertyList);
        }

        public static IWebElement Text_SeedList()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_Text_SeedList);
        }

        public static IWebElement Button_SeedList_RemoveFirstSeedList()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_Button_SeedList_RemoveFirstSeedList);
        }

        public static IWebElement Button_ForecastTargetAudience()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_Button_ForecastTargetAudience);
        }

        public static IWebElement Button_NewSegment_Top()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_Button_NewSegment_Top);
        }

        public static IWebElement Button_NewSegment_Bottom()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_Button_NewSegment_Bottom);
        }

        public static IWebElement Button_TransactionalSettings_HideShow()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_Button_TransactionalSettings_HideShow);
        }

        public static IWebElement DropDown_TransactionalSettings_ReservationEvent()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_DropDown_TransactionalSettings_ReservationEvent);
        }

        public static IWebElement CheckBox_TransactionalSettings_EmailType_FirstResult()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_CheckBox_TransactionalSettings_EmailType_Email);
        }

        public static IWebElement CheckBox_TransactionalSettings_EmailType_SecondResult()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_CheckBox_TransactionalSettings_EmailType_RESERVATIONEMAIL);
        }

        public static IWebElement CheckBox_TransactionalSettings_UseFirstAvailableSelectedEmailType()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_CheckBox_TransactionalSettings_UseFirstAvailableSelectedEmailType);
        }

        public static IWebElement CheckBox_TransactionalSettings_IncludeUnsubscribe()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_CheckBox_TransactionalSettings_IncludeUnsubscribe);
        }

        public static IWebElement Button_CollapseAll()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_Button_CollapseAll);
        }

        public static IWebElement Button_ExpandAll()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_Button_ExpandAll);
        }

        public static IWebElement Text_Segment_SegmentDescription()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_Text_Segment_SegmentDescription);
        }

        public static IWebElement DropDown_Segment_Include()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_DropDown_Segment_Include);
        }

        public static IWebElement DropDown_Segment_AndOrNandNor()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_DropDown_Segment_AndOrNandNor);
        }

        public static IWebElement Button_Segment_CollapseExpand()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_Button_Segment_CollapseExpand);
        }

        public static IWebElement Button_Segment_Close()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_Button_Segment_Close);
        }

        public static IWebElement Button_Segment_First_SelectAll()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_Button_Segment_First_SelectAll);
        }

        public static IWebElement Button_Segment_First_Clone()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_Button_Segment_First_Clone);
        }

        public static IWebElement Button_Segment_First_Remove()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_Button_Segment_First_Remove);
        }

        public static IWebElement Text_Segment_DataSource()
        {
            ScanPage(Constants.CreateCampaign_Criteria);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Criteria_Text_Segment_DataSource);
        }



        
    }
}