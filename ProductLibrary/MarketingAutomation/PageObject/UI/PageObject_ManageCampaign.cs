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

        public static IList<IWebElement> Campaign_Cards_Title()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Manage_Campaign_Cards_Title);
        }
        public static IList<IWebElement> Campaign_Cards_Audience_Name()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Manage_Campaign_Cards_Audience_Name);
        }

        public static IList<IWebElement> Campaign_Cards_Subtitle_Name()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Manage_Campaign_Cards_Subtitle_Name);
        }

        public static IList<IWebElement> Campaign_Cards_Status()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Manage_Campaign_Cards_Status);
        }
        public static IList<IWebElement> Campaign_Cards_Avatar()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Manage_Campaign_Cards_Avatar);
        }

        public static IList<IWebElement> Campaign_Cards_Update_Date()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Manage_Campaign_Cards_Update_Date);
        }

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
        public static IWebElement Manage_Campaign_Sort_Button()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Manage_Campaign_Sort_Button);
        }
        public static IWebElement Manage_Campaign_Sort_Clear()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Manage_Campaign_Sort_Clear);
        }
        public static IWebElement Manage_Campaign_Sort_Apply()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Manage_Campaign_Sort_Apply);
        }
        public static IList<IWebElement> Manage_Campaign_Sort_DropDown_Arrows()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Manage_Campaign_Sort_DropDown_Arrows);
        }

        public static string Manage_Campaign_List_View_Loader()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return ObjectRepository.Manage_Campaign_List_View_Loader;
        }

        public static IWebElement Campaign_Card_Campaign_Ellipse_Clone()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Card_Campaign_Ellipse_Clone);
        }

        public static IWebElement Click_ManageCampaign_cardView_StatusArrow()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_ManageCampaign_cardView_StatusArrow);
        }
        public static IWebElement Check_ManageCampaign_cardView_Status_RequestApprove_button()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Check_ManageCampaign_cardView_Status_RequestApprove_button);
        }
        public static IWebElement Check_ManageCampaign_cardView_Status_SelfApprove_button()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Check_ManageCampaign_cardView_Status_SelfApprove_button);
        }
        public static IWebElement Check_ManageCampaign_cardView_Status_Schedule_button()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Check_ManageCampaign_cardView_Status_Schedule_button);
        }
        public static IWebElement Manage_Campaign_Cards_Status()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Manage_Campaign_Cards_Status);
        }
        public static IWebElement Scheduled_Active_Edit_Button()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Scheduled_Active_Edit_Button);
        }
        public static IWebElement Scheduled_Active_Deactivate_Button()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Scheduled_Active_Deactivate_Button);
        }
        public static IWebElement Scheduled_InActive_Activate_Button()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Scheduled_InActive_Activate_Button);
        }
        public static IWebElement Click_ManageCampaign_ListView_StatusArrow()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_ManageCampaign_ListView_StatusArrow);
        }
        public static IWebElement Approved_Campaign_details_Approvedby_Field()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Approved_Campaign_details_Approvedby_Field);
        }
        public static IWebElement Approved_Campaign_details_ApprovedOn_Field()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Approved_Campaign_details_ApprovedOn_Field);
        }
        public static IWebElement ListView_Campaign_Status()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.ListView_Campaign_Status);
        }
        public static IWebElement Approved_Campaign_details_ApprovedOn_Field_Value()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Approved_Campaign_details_ApprovedOn_Field_Value);
        }
        public static IWebElement Approved_Campaign_details_Approvedby_Field_Value()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Approved_Campaign_details_Approvedby_Field_Value);
        }
        public static IWebElement Click_On_Code_Editor()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_On_Code_Editor);
        }
        public static IWebElement Click_On_Code_Editor_Save_Button()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_On_Code_Editor_Save_Button);
        }
        public static IWebElement Enter_CSS_Code()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_CSS_Code);
        }
        public static IWebElement Click_CSS()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_CSS);
        }
        public static IWebElement Enter_HTML_Code()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_HTML_Code);
        }

        public static IWebElement View_Campaign_Summary_Tab()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.View_Campaign_Summary_Tab);
        }
        public static IWebElement View_Campaign_Summary_General_Text()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.View_Campaign_Summary_General_Text);
        }
        public static IWebElement View_Campaign_Design_Tab()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.View_Campaign_Design_Tab);
        }
        public static IWebElement View_Campaign_Design_General_Text()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.View_Campaign_Design_General_Text);
        }
        public static IWebElement View_Campaign_Audience_Tab()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.View_Campaign_Audience_Tab);
        }
        public static IWebElement View_Campaign_Audience_Criteria_Text()
        {
            ScanPage(Constants.ManageCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.View_Campaign_Audience_Criteria_Text);
        }
    }
}
