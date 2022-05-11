using BaseUtility.PageObject;
using MarketingAutomation.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace MarketingAutomation.PageObject.UI
{
    class PageObject_CreateTemplate : Setup
    {
        public static string PageName = Utility.Constants.CreateTemplate;

        public static IWebElement CreateTemplate_Button()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Template_Button_CreateTemplate);
        }
        
        public static IList<IWebElement> GetNumberOfCardsAvailableInPage()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Template_Create_Confirm_grid3x3_Card);
            
        }
        public static IWebElement Create_Template_Name()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Template_Create_Template_Name_Input);
        }
        public static IWebElement Create_Template_SaveAndContinue()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Template_Create_Template_SaveAndContinue_Button);
        }
        public static IWebElement Create_Template_Tag()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Template_Create_Template_Tag_Input);
        }
        public static IWebElement Create_Template_Desc()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Template_Create_Template_desc_Input);
        }
        public static IList<IWebElement> SelectionOTabVerify()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsID(ObjectRepository.SelectionOTabVerify);
        }
        public static IWebElement Create_Confirm_Every_Tag_Arrow()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Template_Create_Confirm_Tag_Arrow);
        }
        public static IList<IWebElement> Create_Confirm_Tag_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Template_Create_Confirm_Tag_List);
        }
        public static IList<IWebElement> GetListOfSelected()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Template_Create_Verify_Selected);
        }
        public static IList<IWebElement> SelectionOfSwitchTabs()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsID(ObjectRepository.Template_switchViewBtn_Verification);
        }
        public static IWebElement SelctionOfListButton() {

            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Template_switchViewBtn_Verification_List_OptionSelected);
        }
        public static IWebElement Template_Grid_Cards_Breadcrumb() {

            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Template_Grid_Cards_Breadcrumb);
        }

        public static IList<IWebElement> Template_Grid_Cards_Image_List()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Template_Grid_Cards_Image);
        }

        public static IList<IWebElement> Template_Grid_Cards_Title_List()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Template_Grid_Cards_Title);
        }
        public static IList<IWebElement> Template_Grid_Cards_Status_List()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Template_Grid_Cards_Status);
        }
        public static IList<IWebElement> Template_Grid_Cards_Tags_Lists()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Template_Grid_Cards_Tags_List);
        }

        public static IList<IWebElement> Template_Grid_Cards_Tags_More_Count_List()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Template_Grid_Cards_Tags_More_Count);
        } 
        
        public static IList<IWebElement> Template_Grid_Cards_Editor_List()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Template_Grid_Cards_Editor);
        }
        public static IList<IWebElement> Template_Grid_Cards_Update_Date_List()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Template_Grid_Cards_Update_Date);
        }
        public static IWebElement Template_Create_Share_Template_Text()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Template_Create_Share_Template_Text);
        }

        public static IWebElement Template_Create_Share_Template_On_Btn()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Template_Create_Share_Template_On);
        }
        public static IWebElement Template_Create_Share_Template_Off_Btn()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Template_Create_Share_Template_Off);
        }
        public static IWebElement Template_Create_Cancel_Button()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Template_Create_Cancel_Button);
        }
        public static IWebElement Template_Create_Prev_Button()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Template_Create_Prev_Button);
        }
        public static IWebElement Template_Grid_Cards_Tooltip_Text()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Template_Grid_Cards_Tooltip);
        }

        public static IWebElement Template_Create_Name_Error_Msg()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Template_Create_Name_Error);
        }

        public static IWebElement Template_Grid_Header_Name()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Template_Grid_Header_Name);
        }
        public static IWebElement Template_Grid_Header_Tags()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Template_Grid_Header_Tags);
        }
        public static IWebElement Template_Grid_Header_Status()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Template_Grid_Header_Status);
        }
        public static IWebElement Template_Grid_Header_Camapigns()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Template_Grid_Header_Camapigns);
        }
        public static IWebElement Template_Grid_Header_Updated_By()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Template_Grid_Header_Updated_By);
        }
        public static IWebElement Template_Grid_Header_Updated_On()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Template_Grid_Header_Updated_On);
        }
        public static IWebElement Click_TemplatePage_Ellipses_ViewDetails_SummaryTab()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_TemplatePage_Ellipses_ViewDetails_SummaryTab);
        }
        public static IWebElement Click_TemplatePage_Ellipses_ViewDetails()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_TemplatePage_Ellipses_ViewDetails);
        }
        public static IWebElement Click_TemplatePage_Ellipses()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_TemplatePage_Ellipses);
        }
        public static IWebElement Click_TemplatePage_SummaryTab()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_TemplatePage_SummaryTab);
        }
        public static IWebElement Click_ListView_FirstTemplate()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_ListView_FirstTemplate);
        }

        public static IList<IWebElement> TemplatePage_Ellipses_List()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Click_TemplatePage_Ellipses);
        }

        public static IList<IWebElement> TemplatePage_Ellipses_ViewDetails()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Click_TemplatePage_Ellipses_ViewDetails);
        }

        public static IWebElement Create_Template_View_In_Browser_Link()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Template_Create_Template_View_In_Browser_Link);
        }
        public static IWebElement Create_Template_Unsubsribe_Link()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Template_Create_Template_Unsubsribe_Link);
        }

        public static IWebElement Create_Template_Design_Elements()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Template_Create_Template_Design_Elements);
        }

        public static IWebElement Template_Create_Template_Tag_Input_expansion()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Template_Create_Template_Tag_Input_expansion);
        }
        public static IWebElement Template_Create_Template_desc_Input()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Template_Create_Template_desc_Input);
        }
        public static IWebElement Create_Template_Name_red()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Create_Template_Name_red);
        }
        public static IWebElement Template_Create_Template_Name_Input()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Template_Create_Template_Name_Input);
        }
        public static IWebElement Create_Template_DesignPage_SelectElement()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Create_Template_DesignPage_SelectElement);
        }
        public static IWebElement Create_Template_DesignPage_body()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Create_Template_DesignPage_body);
        }
        public static IWebElement iframe_Create_Template_DesignPage_body()
        {
            ScanPage(Constants.CreateTemplate);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.iframe_Create_Template_DesignPage_body);
        }
        
    }
    
}
