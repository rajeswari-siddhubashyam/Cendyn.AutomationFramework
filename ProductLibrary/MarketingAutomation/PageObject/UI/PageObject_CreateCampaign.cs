using BaseUtility.PageObject;
using MarketingAutomation.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace MarketingAutomation.PageObject.UI
{
    class PageObject_CreateCampaign : Setup
    {
        public static string PageName = Utility.Constants.CreateCampaign;
        
        public static IWebElement CreateCampaign_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Button_CreateCampaign);
        }
        public static IWebElement Marketing_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Button_Marketing);
        }

        public static IWebElement Automated_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Button_Automated);
        }
        public static IWebElement ApplicationCards_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Button_ApplicationCards);
        }
        public static IList<IWebElement> ApplicationCards()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Button_ApplicationCards);
        }

        public static IWebElement Create_Wizard_Settings()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Wizard_Settings);
        }

        public static IWebElement Create_Wizard_Back_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Campaign_Create_Wizard_Back_Button);
        }

        public static IWebElement Create_Wizard_Audience()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Wizard_Audience);
        }

        public static IWebElement Create_Campaign_Name()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Campaign_Create_Campaign_Name_Input);
        }

        public static IWebElement Create_Campaign_Name_Error()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Campaign_Create_Campaign_Name_Error_Text);
        }

        public static IWebElement Create_Campaign_Subject()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Campaign_Create_Campaign_Subject_Input);
        }

        public static IWebElement Create_Campaign_Subject_Error()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Campaign_Create_Campaign_Subject_Error_Text);
        }

        public static IWebElement Create_Campaign_Subject_InLine_Txt()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Campaign_Subject_InLine_Text);
        }

        public static IWebElement Create_Campaign_From_Dropdown()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Campaign_From_Dropdown);
        }

        public static IWebElement Create_Campaign_From_Error_Text()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Campaign_From_Error_Text);
        }
        public static IWebElement Create_Campaign_Form_Search_Input()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Campaign_Form_Search_Input);
        }

        public static IList<IWebElement> Create_Campaign_Form_DropDownList()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Campaign_Form_DropDownList);
        }

        public static IWebElement Create_Campaign_Form_RemoveSelection()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Campaign_Form_RemoveSelection_Button);
        }
         public static IWebElement Create_Campaign_Reply_Dropdown()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Campaign_Reply_Dropdown);
        }
        public static IWebElement Create_Campaign_Reply_Search_Input()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Campaign_Reply_Search_Input);
        }

        public static IList<IWebElement> Create_Campaign_Reply_DropDownList()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Campaign_Reply_DropDownList);
        }

        public static IWebElement Create_Campaign_Reply_RemoveSelection()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Campaign_Reply_RemoveSelection_Button);
        }

        public static IWebElement Create_Campaign_Tip_Text()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Campaign_Tip_Text);
        }

        public static IWebElement Create_Campaign_SaveAndContinue()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Campaign_Create_Campaign_SaveAndContinue_Button);
        }

        public static IWebElement Create_Campaign_From_Dropdown_Input()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Campaign_From_Dropdown_Input);
        }

        public static IWebElement Create_Campaign_Reply_Dropdown_Input()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Campaign_Reply_Dropdown_Input);
        }
        
        public static IWebElement Create_Audience_Grid_button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Audience_Grid_button);
        }

        public static IWebElement Create_Audience_List_button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Audience_List_button);
        }

        public static IWebElement Create_Audience_Sort_button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Campaign_Create_Audience_Sort_button);
        }

        public static IList<IWebElement> Create_Audience_Sort_Options()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Audience_Sort_Options);
        }

        public static IWebElement Create_Audience_Card_Menu_Ellipses()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Campaign_Create_Audience_Card_Menu_Ellipses);
        }

        public static IList<IWebElement> Create_Audience_Card_Menu_Ellipses_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsID(ObjectRepository.Campaign_Create_Audience_Card_Menu_Ellipses);
        }

        public static IWebElement Create_Audience_Card_SelectAndContinue_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Audience_Card_SelectAndContinue_Button);
        }

        public static IWebElement Create_Audience_Card_Title()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Campaign_Create_Audience_Cards_Title);
        }

        public static IList<IWebElement> Create_Audience_Cards_Title_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsID(ObjectRepository.Campaign_Create_Audience_Cards_Title);
        }

        public static IWebElement Create_Audience_Cards_SubTitles()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Audience_Cards_SubTitles);
        }

        public static IList<IWebElement> Create_Audience_Cards_SubTitles_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Audience_Cards_SubTitles);
        }

        public static IWebElement Create_Audience_Card_ToolTip_Text()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Audience_Card_ToolTip_Text);
        }public static IWebElement Create_Audience_Cards_Truncated()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Audience_Cards_Truncated);
        }


        public static IWebElement Create_Audience_Cards_Tags()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Audience_Cards_Tag_List);
        }

        public static IWebElement Create_Audience_Cards_Tag_More_Count()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Audience_Cards_Tag_More_Count);
        }

        public static IList<IWebElement> Create_Audience_Cards_Tags_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Audience_Cards_Tag_List);
        }
        public static IList<IWebElement> Create_Audience_Cards_Tag_More_Count_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Audience_Cards_Tag_More_Count);
        }

        public static IList<IWebElement> Create_Audience_Cards_More_Tag_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Audience_Cards_More_Tag_List);
        }

        public static IWebElement Create_Audience_Cards_Users_Count()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Audience_Cards_Users_Count);
        }

        public static IList<IWebElement> Create_Audience_Cards_Users_Count_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Audience_Cards_Users_Count);
        }

        public static IWebElement Create_Audience_Cards_Email_Count()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Audience_Cards_Email_Count);
        }

        public static IList<IWebElement> Create_Audience_Cards_Email_Count_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Audience_Cards_Email_Count);
        }

        public static IWebElement Create_Audience_Cards_Dates()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Audience_Cards_Dates);
        }

        public static IList<IWebElement> Create_Audience_Cards_Dates_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Audience_Cards_Dates);
        }

        public static IWebElement Create_Audience_Previous_Page_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Audience_Previous_Page_Button);
        }

        public static IWebElement Create_Audience_Next_Page_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Audience_Next_Page_Button);
        }

        public static IList<IWebElement> Create_Audience_Paggination_Page_Numbers()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Audience_Paggination_Page_Numbers);
        }

        public static IWebElement Create_Audience_Preview_Audience_Name()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Audience_Preview_Audience_Name);
        }

        public static IWebElement Create_Audience_Preview_Audience_Description()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Audience_Preview_Audience_Description);
        }  
        public static IWebElement Create_Audience_Preview_Criteria_Text()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Audience_Preview_Criteria_Text);
        }

        public static IList<IWebElement> Create_Audience_Preview_Criteria_Text_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Audience_Preview_Criteria_Text);
        }

        public static IWebElement Create_Audience_Card_Border()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Audience_Card_Border);
        }

        public static string Create_Audience_Card_Border_Xpath()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return ObjectRepository.Campaign_Create_Audience_Card_Border;
        }

        public static IWebElement Create_Wizard_Settings_Checked()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Wizard_Settings_Checked);
        }

        public static IWebElement Create_Wizard_Audience_Checked()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Wizard_Audience_Checked);
        }

        public static IWebElement Create_Audience_Preview_Created_Date()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Audience_Preview_Created_Date);
        }


        public static IWebElement Create_Audience_Preview_Total_Count()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Audience_Preview_Total_Count);
        }

        public static IWebElement Create_Audience_Preview_Campaigns_Count()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Audience_Preview_Campaigns_Count);
        }
        public static string Create_Audience_Preview_Loader()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
           return ObjectRepository.Campaign_Create_Audience_Preview_Loader;
        }

        public static IList<IWebElement> Create_Audience_ListView_Column_Header_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Audience_ListView_Column_Header);
        } 
        
        public static IList<IWebElement> Create_Audience_ListView_Cell_Data_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Audience_ListView_Cell_Data);
        }

        public static IWebElement Create_Audience_ListView_Previous_Page_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Audience_ListView_Previous_Page_Button);
        } 
        
        public static IWebElement Create_Audience_ListView_Next_Page_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Audience_ListView_Next_Page_Button);
        }

        public static IList<IWebElement> Create_Audience_ListView_Page_Numbers()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Audience_ListView_Page_Numbers);
        }

        public static IWebElement Create_Design_New_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Design_New_Button);
        }

        public static IWebElement Create_Design_ListView_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Design_ListView_Button);
        }
        public static IWebElement Create_Design_GridView_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Design_GridView_Button);
        }
        public static IWebElement Create_Design_Card_Clone_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Design_Card_Clone_Button);
        }

        public static IList<IWebElement> Create_Design_Cards_Images_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Design_Cards_Images);
        }
        public static IList<IWebElement> Create_Design_Cards_Title_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Design_Cards_Title);
        }

        public static string Create_Design_Card_Border_Xpath()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return ObjectRepository.Campaign_Create_Design_Card_Border;
        }

        public static IWebElement Create_Design_Card_Border()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Design_Card_Border);
        }

        public static IList<IWebElement> Create_Design_Cards_Tag_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Design_Cards_Tag_List);
        }

        public static IList<IWebElement> Create_Design_Cards_Users_Name_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Design_Cards_Users_Name);
        }

        public static string Create_Design_Preview_Page_Loader()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return ObjectRepository.Campaign_Create_Design_Preview_Page_Loader;
        }

        public static IWebElement Create_Design_Preview_Edit_Text()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Design_Preview_Edit_Text);
        }

        public static IWebElement Create_Design_Preview_Edit_Design_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Design_Preview_Edit_Design_Button);
        }

        public static IWebElement Create_Design_Preview_Created_Date()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Design_Preview_Created_Date);
        }

        public static IWebElement Create_Design_Preview_Updated_Date()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Design_Preview_Updated_Date);
        } 
        
        public static IWebElement Create_Design_Preview_Campaign_Count()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Design_Preview_Campaign_Count);
        }
        public static IWebElement Create_Design_Preview_Tag_Count()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Design_Preview_Tag_Count);
        }

        public static IWebElement Create_Wizard_Design()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Wizard_Design);
        } 
        
        public static IWebElement Create_Wizard_Design_Checked()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Wizard_Design_Checked);
        }
        
        public static IWebElement Create_Design_Preview_Design_Title()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Design_Preview_Design_Title);
        }
        
        public static IWebElement Create_Design_Preview_ViewIn_Browser()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Design_Preview_ViewIn_Browser);
        }
        
        public static IWebElement Create_Design_List_Truncated()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Design_List_Truncated);
        }

        public static IWebElement Campaign_Create_Design_Click_SendMail()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Design_Click_SendMail);
        }
        public static IWebElement Campaign_Create_Design_SeedList_value()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Design_SeedList_value);
        }
        public static IWebElement Campaign_Create_Design_SeedList_DDL()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Design_SeedList_DDL);
        }
        public static IWebElement Campaign_Create_Design_SendTest_Send_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Design_SendTest_Send_Button);
        }
        public static IWebElement Recipients_Text_Box()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Recipients_Text_Box);
        }

        public static IWebElement Campaign_Create_Design_Enter_SeedList()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Design_Enter_SeedList);
        }

        public static IWebElement Enter_Recipients()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Enter_Recipients);
        }
        


        internal static IList<IWebElement> Create_Audience_List_Cards_Tag_List()
        {
            throw new NotImplementedException();
        }

        public static IWebElement Create_Confirm_Send_Input_ToEnter()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Send_Input_ToEnter);
        }

        public static IList<IWebElement> Create_Confirm_Send_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Confirm_Send_List);
        }

        public static IWebElement Create_Confirm_On_Input()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_On_Input);
        }
        public static IWebElement Create_Confirm_On_Picker_Icon()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_On_Picker_Icon);
        }

        public static IList<IWebElement> Create_Confirm_FutureDates()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Confirm_FutureDates);
        }

        public static IList<IWebElement> Create_Confirm_At_Time_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Confirm_At_Time_List);
        }

        public static IList<IWebElement> Create_Confirm_Time_Zone_Options_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Confirm_Time_Zone_Options_List);
        }

        public static IWebElement Create_Confirm_Time_Zone_Down_Arrow()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Time_Zone_Down_Arrow);
        }

        public static IWebElement Create_Confirm_Time_Zone_Search_Input()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Time_Zone_Search_Input);
        }
        public static IWebElement Create_Success_Text()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Success_Text);
        }

        public static IWebElement Create_Confirm_Every_Arrow()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Every_Arrow);
        }

        public static IWebElement Create_Confirm_Every_Search_Input()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Every_Search_Input);
        }

        public static IList<IWebElement> Create_Confirm_Every_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Confirm_Every_List);
        }
       

        public static IWebElement Create_Wizard_Confirm()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Wizard_Confirm);
        }

        public static IWebElement Create_Confirm_Self_Approve()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Self_Approve);
        }

        public static IWebElement Create_Confirm_Schedule_Text()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Schedule_Text);
        }

        public static IWebElement Create_Confirm_Send_Input()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Campaign_Create_Confirm_Send_Input);
        }

        public static IWebElement Create_Confirm_Days_From_Input()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Days_From_Input);
        }

        public static IWebElement Create_Confirm_Until_Input()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Until_Input);
        }
        public static IWebElement Create_Confirm_At_Time_Input()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_At_Time_Input);
        }
        public static IWebElement Create_Confirm_Start_On_Input()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Start_On_Input);
        }

        public static IWebElement Create_Confirm_Send_Input_DropDown()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Send_Input_DropDown);
        }
        public static IWebElement Create_Confirm_At_Time_Icon()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_At_Time_Icon);
        }

        public static IWebElement Create_Confirm_Time_Zone_Input()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Campaign_Create_Confirm_Time_Zone_Input);
        }
        public static IWebElement Create_Wizard_Confirm_Finish()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Campaign_Create_Wizard_Confirm_Finish);
        }
        public static IWebElement Create_Success_Manage_Campaigns_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Campaign_Create_Success_Manage_Campaigns_Button);
        }

        public static IWebElement Create_Success_Edit_Schedule_Link()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Success_Edit_Schedule_Link);
        }

        public static IWebElement Create_Success_Message()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Campaign_Create_Success_Message);
        }
        public static IWebElement Create_Confirm_Days_From_Picker_Icon()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Days_From_Picker_Icon);
        }
        public static IWebElement Create_Confirm_Until_Picker_Icon()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Until_Picker_Icon);
        }
        public static IWebElement Create_Confirm_Every_Input()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Campaign_Create_Confirm_Every_Input);
        }

        public static IWebElement Create_Confirm_Calendar_Next()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Calendar_Next);
        }
        public static IWebElement Create_Confirm_Calendar_Previous()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Calendar_Previous);
        }

        public static IWebElement Create_Confirm_Months_From_Input()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Months_From_Input);
        }

        public static IWebElement Create_Confirm_Months_From_Picker_Icon()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Months_From_Picker_Icon);
        }
        public static IWebElement Create_Confirm_Every_Monthly_Arrow()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Every_Arrow);
        }
        public static IWebElement Create_Confirm_Every_Search_Month_Input()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Every_Search_Month_Input);
        }

        public static IWebElement Create_Confirm_Every_Month_Input()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Campaign_Create_Confirm_Every_Month_Input);
        }

        public static IList<IWebElement> Create_Confirm_Every_Monthly_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Confirm_Every_Monthly_List);
        }

        public static IList<IWebElement> Create_Confirm_At_Time_Lists()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Confirm_At_Time_List);
        }
        public static IList<IWebElement> Create_Confirm_At_Time_Input_Lists()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Confirm_At_Time_Input);
        }

        public static IList<IWebElement> Create_Confirm_At_Time_Icon_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Confirm_At_Time_Icon);
        }

        public static IWebElement Create_Confirm_Every_Minute_Input()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Campaign_Create_Confirm_Every_Minute_Input);
        }

        public static IWebElement Create_Confirm_Every_Minute_Arrow()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Every_Minute_Arrow);
        }

        public static IWebElement Create_Confirm_Every_Minute_Search_Input()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Every_Minute_Search_Input);
        }

        public static IList<IWebElement> Create_Confirm_Every_Minute_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Confirm_Every_Minute_List);
        }

        public static IWebElement Create_Confirm_Minutes_From_Picker_Icon()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Minutes_From_Picker_Icon);
        }

      
        public static IWebElement Create_Confirm_Minutes_From_Input()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Minutes_From_Input);
        }

        public static IWebElement Create_Confirm_Every_Hourly_Input()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Campaign_Create_Confirm_Every_Hourly_Input);
        }
        public static IWebElement Create_Confirm_Every_Hourly_Arrow()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Every_Hourly_Arrow);
        }

        public static IWebElement Create_Confirm_Every_Hourly_Search_Input()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Every_Hourly_Search_Input);
        }

        public static IList<IWebElement> Create_Confirm_Every_Hourly_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Confirm_Every_Hourly_List);
        }
        public static IWebElement Create_Confirm_Weekly_From_Picker_Icon()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Weekly_From_Picker_Icon);
        }
        public static IWebElement Create_Confirm_Weekly_From_Input()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Weekly_From_Input);
        }
        public static IList<IWebElement> Create_Confirm_Weekly_Day()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Confirm_Weekly_Day);
        }

        public static IList<IWebElement> GetNumberOfCardsAvailableInPage()
        {                
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Confirm_grid3x3_Card);
        }
        
        
        public static IWebElement Confirm_AtTopIcon()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Confirm_Icon_AtTop);
        }
        public static IList<IWebElement> SelectionOTabVerify()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.SelectionOTabVerify);
        }
        public static IWebElement Create_Confirm_Todays_Dates()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Todays_Dates);
        }
        public static IWebElement Create_Confirm_Start_On_Picker_Icon()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Start_On_Picker_Icon);
        }
        public static IWebElement Create_Confirm_Hours_From_Picker_Icon()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Hours_From_Picker_Icon);
        }
        
        public static IWebElement Create_Confirm_Hours_From_Input()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Hours_From_Input);
        }

        public static IWebElement Create_Confirm_Hours_From_Clear_Icon()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Hours_From_Clear_Icon);
        }

        public static IWebElement Create_Confirm_Every_Hours_Input()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Campaign_Create_Confirm_Every_Hours_Input);
        }

        public static IWebElement Create_Confirm_Every_Hours_Arrow()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Every_Hours_Arrow);
        }

        public static IWebElement Create_Confirm_Every_Hours_Search_Input()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Create_Confirm_Every_Hours_Search_Input);
        }

        public static IList<IWebElement> Create_Confirm_Every_Hours_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Create_Confirm_Every_Hours_List);
        }
        public static IWebElement Campaign_Click_Filter()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Click_Filter);
        }
        public static IWebElement Campaign_Click_Filter_Name_ddL()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Click_Filter_Name_ddL);
        }
        public static IWebElement Campaign_Click_Filter_Name_ddL_Value()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Click_Filter_Name_ddL_Value);
        }
        public static IWebElement Campaign_Click_Filter_Name_Enter_CampaignName()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Click_Filter_Name_Enter_CampaignName);
        }
        public static IWebElement Campaign_Click_Filter_Apply_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Click_Filter_Apply_Button);
        }

        public static IWebElement Campaign_Filter_Enter_ID()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Filter_Enter_ID);
        }

        public static IWebElement Campaign_Click_Filter_ID_ddL()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Click_Filter_ID_ddL);
        }
        public static IWebElement Campaign_Click_Filter_Audience_DDl()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Click_Filter_Audience_DDl);
        }
        public static IWebElement Campaign_Click_Filter_Enter_Audience()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Click_Filter_Enter_Audience);
        }
        public static IWebElement Campaign_Click_Approval_SendRequest_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Click_Approval_SendRequest_Button);
        }
        public static IWebElement Campaign_Click_Approval_SendRequest_Approve_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Click_Approval_SendRequest_Approve_Button);
        }
        public static IWebElement Campaign_Click_Approval_SendRequest_Reject_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Click_Approval_SendRequest_Reject_Button);
        }
        public static IWebElement Campaign_Click_Approval_Click_SelfApprove_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Click_Approval_SendRequest_Reject_Button);
        }
        public static IWebElement Click_design_SelfApprove_Send_DDL()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_design_SelfApprove_Send_DDL);
        }

        public static IWebElement Click_design_SelfApprove_TimeZone_DDL()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_design_SelfApprove_TimeZone_DDL);
        }

        public static IWebElement Click_design_SelfApprove_On_Value()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_design_SelfApprove_On_Value);
        }
        public static IWebElement Click_design_SelfApprove_Enter_Send_Value()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Click_design_SelfApprove_Enter_Send_Value);
        }
        public static IWebElement RejectApproval__popUp_Reject_button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.RejectApproval__popUp_Reject_button);
        }
        public static IWebElement RejectApproval__popUp_Enter_text()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.RejectApproval__popUp_Enter_text);
        }
        public static IWebElement Logout_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Logout_Button);
        }

        public static IList<IWebElement> Create_Campaign_Card_Ellipses_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Card_Ellipses);
        }


        public static IList<IWebElement> Create_Campaign_Card_Titles_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Card_Titles);
        }
        
        public static IList<IWebElement> Create_Campaign_Card_IDs_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Card_Campaign_IDs);
        }

        public static IList<IWebElement> Create_Campaign_Card_Ellipse_Clone_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Card_Campaign_Ellipse_Clone);
        }

        public static IWebElement Create_Campaign_Filter()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Filter);
        }

        public static IWebElement Create_Campaign_Filter_Name()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Filter_Name);
        }

        public static IWebElement Create_Campaign_Filter_Name_Search_Text()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Filter_Name_Search_Text);
        }

        public static IWebElement Create_Campaign_Filter_Button_Apply()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Filter_Button_Apply);
        }
        public static IWebElement Create_Campaign_Filter_Name_Value()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Filter_Name_Value);
        }
        public static IList<IWebElement> Create_Campaign_Filter_Name_Value_List()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Filter_Name_Value_List);
        }
        public static IWebElement Create_Campaign_Automated_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Create_Campaign_Automated_Button);
        }

        public static IWebElement Campaign_Click_Filter_Clear_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Click_Filter_Clear_Button);
        }

        public static IWebElement Verify_Approval_Card_Title()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Verify_Approval_Card_Title);
        }

        public static IWebElement Verify_Approval_Card_Text()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Verify_Approval_Card_Text);
        }

        public static IWebElement Verify_Approval_Left_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Verify_Approval_Left_Button);
        }

        public static IWebElement Verify_Approval_Right_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Verify_Approval_Right_Button);
        }

        public static IWebElement Verify_DesignPage_ApprovalCard_Title()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Verify_DesignPage_ApprovalCard_Title);
        }

        public static IWebElement Verify_DesignPage_ApprovalCard_Text()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Verify_DesignPage_ApprovalCard_Text);
        }

        public static IWebElement Verify_DesignPage_ApprovalCard_SelfApprove_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Verify_DesignPage_ApprovalCard_SelfApprove_Button);
        }

        public static IWebElement Verify_DesignPage_ApprovalCard_SendRequest_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Verify_DesignPage_ApprovalCard_SendRequest_Button);
        }
        public static IList<IWebElement> Campaign_SendEmail_SeedLists()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_SendEmail_SeedLists);
        }
        public static IWebElement RejectApproval__popUp_Cancel_button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.RejectApproval__popUp_Cancel_button);
        }

        public static IWebElement Verify_SchedulePage_Schedule_Title()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Verify_SchedulePage_Schedule_Title);
        }

        public static IWebElement CreateCampaign_Audience_Selection()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateCampaign_Audience_Selection);
        }
        public static IWebElement Deactivate_Schedule_Dialog_Contains_Title()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Deactivate_Schedule_Dialog_Contains_Title);
        }
        public static IWebElement Deactivate_Schedule_Dialog_Contains_Text()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Deactivate_Schedule_Dialog_Contains_Text);
        }
        public static IWebElement Deactivate_Schedule_Dialog_Contains_Cancel()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Deactivate_Schedule_Dialog_Contains_Cancel);
        }
        public static IWebElement Deactivate_Schedule_Dialog_Contains_Deactivate()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Deactivate_Schedule_Dialog_Contains_Deactivate);
        }
        public static IWebElement Schedule_Campaign_details_Status()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Schedule_Campaign_details_Status);
        }
        public static IWebElement Schedule_Campaign_details_Send_Field()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Schedule_Campaign_details_Send_Field);
        }
        public static IWebElement Schedule_Campaign_details_ScheduledBy_Field()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Schedule_Campaign_details_ScheduledBy_Field);
        }
        public static IWebElement Schedule_Campaign_Activate_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Schedule_Campaign_Activate_Button);
        }
        public static IWebElement Activate_Schedule_Dialog_Contains_Activate_Button()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Activate_Schedule_Dialog_Contains_Activate_Button);
        }
        public static IList<IWebElement> Campaign_Card_Campaign_Ellipse_Edit()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Card_Campaign_Ellipse_Edit);
        }

        public static IList<IWebElement> Campaign_Card_Campaign_Ellipse_ViewDetails()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Campaign_Card_Campaign_Ellipse_ViewDetails);
        }
        public static IWebElement Campaign_Card_Campaign_Reject_Textarea()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementId(ObjectRepository.Campaign_Card_Campaign_Reject_textarea);
        }
        public static IWebElement Campaign_Card_Campaign_Reject_Comments()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Card_Campaign_Reject_Comments);
        }
        public static IWebElement Campaign_Card_Campaign_Reject_AutoMessage()
        {
            ScanPage(Constants.CreateCampaign);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Campaign_Card_Campaign_Reject_AutoMessage);
        }

    }
}
