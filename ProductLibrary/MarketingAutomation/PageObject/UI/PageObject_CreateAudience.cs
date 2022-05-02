using BaseUtility.PageObject;
using MarketingAutomation.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace MarketingAutomation.PageObject.UI
{
    class PageObject_CreateAudience : Setup
    {
        public static string PageName = Utility.Constants.CreateAudience;

        public static IWebElement Audience_Breadcrumb()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Audience_Breadcrumb);
        }

        public static IWebElement Audience_Create_Button()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Audience_Create_Button);
        }
        public static IList<IWebElement> Audience_Cards()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Audience_Cards);
        }
        public static IWebElement Click_Audience_Name()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Audience_Name);
        }
        public static IWebElement Verify_CriteriaTab_AudiencePage()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Verify_CriteriaTab_AudiencePage);
        }

        public static IWebElement Get_Audience_Name()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_Audience_Name);
        }

        public static IWebElement Get_Audience_Status()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Get_Audience_Status);
        }
        public static IWebElement Get_Audience_Tag()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Get_Audience_Tag);
        }
        public static IWebElement Get_Audience_UpdatedDate()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Get_Audience_UpdatedDate);
        }
        public static IWebElement Click_ManageAudience_CampaignTab()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_ManageAudience_CampaignTab);
        }

        public static IWebElement Audience_Details_Campaign_Tab()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Audience_Details_Campaign_Tab);
        }

        public static IList<IWebElement> AudienceOrSegmentButton()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.AudienceOrSegmentButton);
        }

        public static IWebElement AudienceHeaderTitle()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.HeaderTitle);
        }

        public static IWebElement AudienceCreateButton()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Create_Button);
        }

        public static IWebElement Create_Audience_Button()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Create_Audience_Button);
        }
        public static IWebElement Create_Segment_Button()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Create_Segment_Button);
        }
        

        public static IWebElement Create_Audience_Name()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Create_Audience_Name);
        }

        public static IWebElement Create_Audience_Tag_input()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Create_Audience_Tag_input);
        }

        public static IList<IWebElement> Create_Audience_Tag_List()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Create_Audience_Tag_List);
        }

        public static IWebElement Create_Audience_Description()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Create_Audience_Description);
        }

        public static IList<IWebElement> Audience_Cards_Title()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Audience_Cards_Title);
        }
        public static IList<IWebElement> Audience_Cards_Status()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Audience_Cards_Status);
        }
        public static IList<IWebElement> Segment_Cards()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Segment_Cards);
        }

        public static IWebElement Create_Segment_Name()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Create_Segment_Name);
        }

        public static IWebElement Create_Segment_Tag_input()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Create_Segment_Tag_input);
        }

        public static IList<IWebElement> Create_Segment_Tag_List()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Create_Segment_Tag_List);
        }

        public static IWebElement Create_Segment_Description()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Create_Segment_Description);
        }

        public static IWebElement Create_Segment_Domain_Arrow()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Create_Segment_Domain_Arrow);
        }

        public static IList<IWebElement> Create_Segment_DomainOrField_List()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Create_Segment_DomainOrField_List);
        }
        public static IList<IWebElement> Segment_Cards_Status()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Segment_Cards_Status);
        }

        public static IWebElement Create_Segment_AddRow()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Create_Segment_AddRow);
        }
        public static IWebElement Create_Segment_Save()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Create_Segment_Save);
        }

        public static IWebElement Create_Segment_Field_Arrow()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Create_Segment_Field_Arrow);
        }
        public static IWebElement Create_Segment_Operation_Arrow()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Create_Segment_Operation_Arrow);
        }

        public static IWebElement Create_Segment_Finish()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Create_Segment_Finish);
        }

        public static IList<IWebElement> Segment_Cards_Title()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Segment_Cards_Title);
        }
        
        public static IWebElement Create_Segment_CriteriaValue()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Create_Segment_CriteriaValue);
        }
        public static IWebElement Segment_Creation_MSG()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Segment_Creation_MSG);
        }

        public static IList<IWebElement> Audience_Summary_Tabs()
        {
            ScanPage(Constants.CreateAudience);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Audience_Summary_Tabs);
        }
    }
}
