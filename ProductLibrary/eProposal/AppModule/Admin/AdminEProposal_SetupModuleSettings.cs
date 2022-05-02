using System;
using System.Collections.Generic;
using System.IO;
using OpenQA.Selenium;
using BaseUtility.Utility;
using eProposal.PageObject.Admin;

namespace eProposal.AppModule.Admin
{
    internal class AdminEProposal_SetupModuleSettings : Helper
    {

        public static void Click_Button_SetupProposalPreview_Update()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Button_SetupProposalPreview_Update());
        }

        public static void Click_Link_InsertNewModuleSetting()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_InsertNewModuleSetting());
        }

        public static void Click_DropDown_Link()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.DropDown_Link());
        }

        public static void Click_Button_Search()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Button_Search());
        }

        public static void Click_Button_UpdateActive()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Button_UpdateActive());
        }

        public static void Click_Button_Delete_Module1()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Button_Delete_Module1());
        }

        public static void Click_Button_Delete_Module2()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Button_Delete_Module2());
        }

        public static void Click_Button_Delete_Module3()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Button_Delete_Module3());
        }

        public static void Click_Button_Delete_Module4()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Button_Delete_Module4());
        }

        public static void Click_Button_Delete_Module5()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Button_Delete_Module5());
        }

        public static void Click_Button_Delete_OK()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Button_Delete_OK());
        }

        public static void Click_Button_Delete_Cancel()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Button_Delete_Cancel());
        }

        public static void Click_Button_DisplayNameEdit_Module1()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Button_DisplayNameEdit_Module1());
        }

        public static void Click_Button_DisplayNameEdit_Module2()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Button_DisplayNameEdit_Module2());
        }

        public static void Click_Button_DisplayNameEdit_Module3()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Button_DisplayNameEdit_Module3());
        }

        public static void Click_Button_DisplayNameEdit_Module4()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Button_DisplayNameEdit_Module4());
        }

        public static void Click_Button_DisplayNameEdit_Module5()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Button_DisplayNameEdit_Module5());
        }

        public static void Click_Button_DisplayName_Save()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Button_DisplayName_Save());
        }

        public static void Click_Button_DisplayName_Cancel()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Button_DisplayName_Cancel());
        }

        public static void Click_Link_Preview_Module1()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_Preview_Module1());
        }

        public static void Click_Link_Preview_Module2()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_Preview_Module2());
        }

        public static void Click_Link_Preview_Module3()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_Preview_Module3());
        }

        public static void Click_Link_Preview_Module4()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_Preview_Module4());
        }

        public static void Click_Link_Preview_Module5()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_Preview_Module5());
        }

        public static void Click_Button_Javascript_Delete_Yes()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Button_Javascript_Delete_Yes());
        }

        public static void Click_Button_Javascript_Delete_Cancel()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Button_Javascript_Delete_Cancel());
        }

        public static void Click_Link_StyleSheet_Brand_Module1()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_StyleSheet_Brand_Module1());
        }

        public static void Click_Link_StyleSheet_Property_Module1()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_StyleSheet_Property_Module1());
        }

        public static void Click_Link_Javascript_Brand_Module1()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_Javascript_Brand_Module1());
        }

        public static void Click_Link_Javascript_Property_Module1()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_Javascript_Property_Module1());
        }

        public static void Click_Link_Javascript_Upload_Module1()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_Javascript_Upload_Module1());
        }

        public static void Click_Link_Javascript_Delete_Module1()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_Javascript_Delete_Module1());
        }

        public static void Click_Link_StyleSheet_Brand_Module2()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_StyleSheet_Brand_Module2());
        }

        public static void Click_Link_StyleSheet_Property_Module2()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_StyleSheet_Property_Module2());
        }

        public static void Click_Link_Javascript_Brand_Module2()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_Javascript_Brand_Module2());
        }

        public static void Click_Link_Javascript_Property_Module2()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_Javascript_Property_Module2());
        }

        public static void Click_Link_Javascript_Upload_Module2()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_Javascript_Upload_Module2());
        }

        public static void Click_Link_Javascript_Delete_Module2()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_Javascript_Delete_Module2());
        }

        public static void Click_Link_StyleSheet_Brand_Module3()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_StyleSheet_Brand_Module3());
        }

        public static void Click_Link_StyleSheet_Property_Module3()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_StyleSheet_Property_Module3());
        }

        public static void Click_Link_Javascript_Brand_Module3()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_Javascript_Brand_Module3());
        }

        public static void Click_Link_Javascript_Property_Module3()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_Javascript_Property_Module3());
        }

        public static void Click_Link_Javascript_Upload_Module3()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_Javascript_Upload_Module3());
        }

        public static void Click_Link_Javascript_Delete_Module3()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_Javascript_Delete_Module3());
        }

        public static void Click_Link_StyleSheet_Brand_Module4()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_StyleSheet_Brand_Module4());
        }

        public static void Click_Link_StyleSheet_Property_Module4()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_StyleSheet_Property_Module4());
        }

        public static void Click_Link_Javascript_Brand_Module4()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_Javascript_Brand_Module4());
        }

        public static void Click_Link_Javascript_Property_Module4()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_Javascript_Property_Module4());
        }

        public static void Click_Link_Javascript_Upload_Module4()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_Javascript_Upload_Module4());
        }

        public static void Click_Link_Javascript_Delete_Module4()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_Javascript_Delete_Module4());
        }

        public static void Click_Link_StyleSheet_Brand_Module5()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_StyleSheet_Brand_Module5());
        }

        public static void Click_Link_StyleSheet_Property_Module5()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_StyleSheet_Property_Module5());
        }

        public static void Click_Link_Javascript_Brand_Module5()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_Javascript_Brand_Module5());
        }

        public static void Click_Link_Javascript_Property_Module5()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_Javascript_Property_Module5());
        }

        public static void Click_Link_Javascript_Upload_Module5()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_Javascript_Upload_Module5());
        }

        public static void Click_Link_Javascript_Delete_Module5()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Link_Javascript_Delete_Module5());
        }

        public static void Click_Button_UpdatePropertyResources_Save()
        {
            ElementClick(PageObject_AdminEProposal_SetupModuleSettings.Button_UpdatePropertyResources_Save());
        }

        public static void EnterText_Text_SubDomain_Module1(string text)
        {
            ElementEnterText(PageObject_AdminEProposal_SetupModuleSettings.Text_SubDomain_Module1(), text);
        }

        public static void EnterText_Text_SubDomain_Module2(string text)
        {
            ElementEnterText(PageObject_AdminEProposal_SetupModuleSettings.Text_SubDomain_Module2(), text);
        }

        public static void EnterText_Text_SubDomain_Module3(string text)
        {
            ElementEnterText(PageObject_AdminEProposal_SetupModuleSettings.Text_SubDomain_Module3(), text);
        }

        public static void EnterText_Text_SubDomain_Module4(string text)
        {
            ElementEnterText(PageObject_AdminEProposal_SetupModuleSettings.Text_SubDomain_Module4(), text);
        }

        public static void EnterText_Text_SubDomain_Module5(string text)
        {
            ElementEnterText(PageObject_AdminEProposal_SetupModuleSettings.Text_SubDomain_Module5(), text);
        }

        public static void SelectFromDropDown_DropDown_ParentDomain_Module1(string text)
        {
            ElementSelectFromDropDown(
                PageObject_AdminEProposal_SetupModuleSettings.DropDown_ParentDomain_Module1(), text);
        }

        public static void SelectFromDropDown_DropDown_ParentDomain_Module2(string text)
        {
            ElementSelectFromDropDown(
                PageObject_AdminEProposal_SetupModuleSettings.DropDown_ParentDomain_Module2(), text);
        }

        public static void SelectFromDropDown_DropDown_ParentDomain_Module3(string text)
        {
            ElementSelectFromDropDown(
                PageObject_AdminEProposal_SetupModuleSettings.DropDown_ParentDomain_Module3(), text);
        }

        public static void SelectFromDropDown_DropDown_ParentDomain_Module4(string text)
        {
            ElementSelectFromDropDown(
                PageObject_AdminEProposal_SetupModuleSettings.DropDown_ParentDomain_Module4(), text);
        }

        public static void SelectFromDropDown_DropDown_ParentDomain_Module5(string text)
        {
            ElementSelectFromDropDown(
                PageObject_AdminEProposal_SetupModuleSettings.DropDown_ParentDomain_Module5(), text);
        }

        public static void SelectFromDropDown_DropDown_Module(string text)
        {
            ElementSelectFromDropDown(PageObject_AdminEProposal_SetupModuleSettings.DropDown_Module(), text);
        }

        public static void SelectFromDropDown_DropDown_Market(string text)
        {
            ElementSelectFromDropDown(PageObject_AdminEProposal_SetupModuleSettings.DropDown_Market(), text);
        }

        public static void SelectFromDropDown_DropDown_Theme(string text)
        {
            ElementSelectFromDropDown(PageObject_AdminEProposal_SetupModuleSettings.DropDown_Theme(), text);
        }

        public static void SelectFromDropDown_DropDown_Content(string text)
        {
            ElementSelectFromDropDown(PageObject_AdminEProposal_SetupModuleSettings.DropDown_Content(), text);
        }

        public static void SelectFromDropDown_DropDown_Link(string text)
        {
            ElementSelectFromDropDown(PageObject_AdminEProposal_SetupModuleSettings.DropDown_Link(), text);
        }

        public static void Select_CheckBox_Active_Module1()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Active_Module1());
        }

        public static void UnSelect_CheckBox_Active_Module1()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Active_Module1());
        }

        public static void Select_CheckBox_Active_Module2()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Active_Module2());
        }

        public static void UnSelect_CheckBox_Active_Module2()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Active_Module2());
        }

        public static void Select_CheckBox_Active_Module3()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Active_Module3());
        }

        public static void UnSelect_CheckBox_Active_Module3()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Active_Module3());
        }

        public static void Select_CheckBox_Active_Module4()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Active_Module4());
        }

        public static void UnSelect_CheckBox_Active_Module4()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Active_Module4());
        }

        public static void Select_CheckBox_Active_Module5()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Active_Module5());
        }

        public static void UnSelect_CheckBox_Active_Module5()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Active_Module5());
        }

        public static void Select_CheckBox_Language1_Module1()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language1_Module1());
        }

        public static void UnSelect_CheckBox_Language1_Module1()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language1_Module1());
        }

        public static void Select_CheckBox_Language2_Module1()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language2_Module1());
        }

        public static void UnSelect_CheckBox_Language2_Module1()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language2_Module1());
        }

        public static void Select_CheckBox_Language3_Module1()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language3_Module1());
        }

        public static void UnSelect_CheckBox_Language3_Module1()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language3_Module1());
        }

        public static void Select_CheckBox_Language4_Module1()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language4_Module1());
        }

        public static void UnSelect_CheckBox_Language4_Module1()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language4_Module1());
        }

        public static void Select_CheckBox_Language5_Module1()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language5_Module1());
        }

        public static void UnSelect_CheckBox_Language5_Module1()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language5_Module1());
        }

        public static void Select_CheckBox_Language1_Module2()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language1_Module2());
        }

        public static void UnSelect_CheckBox_Language1_Module2()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language1_Module2());
        }

        public static void Select_CheckBox_Language2_Module2()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language2_Module2());
        }

        public static void UnSelect_CheckBox_Language2_Module2()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language2_Module2());
        }

        public static void Select_CheckBox_Language3_Module2()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language3_Module2());
        }

        public static void UnSelect_CheckBox_Language3_Module2()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language3_Module2());
        }

        public static void Select_CheckBox_Language4_Module2()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language4_Module2());
        }

        public static void UnSelect_CheckBox_Language4_Module2()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language4_Module2());
        }

        public static void Select_CheckBox_Language5_Module2()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language5_Module2());
        }

        public static void UnSelect_CheckBox_Language5_Module2()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language5_Module2());
        }

        public static void Select_CheckBox_Language1_Module3()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language1_Module3());
        }

        public static void UnSelect_CheckBox_Language1_Module3()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language1_Module3());
        }

        public static void Select_CheckBox_Language2_Module3()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language2_Module3());
        }

        public static void UnSelect_CheckBox_Language2_Module3()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language2_Module3());
        }

        public static void Select_CheckBox_Language3_Module3()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language3_Module3());
        }

        public static void UnSelect_CheckBox_Language3_Module3()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language3_Module3());
        }

        public static void Select_CheckBox_Language4_Module3()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language4_Module3());
        }

        public static void UnSelect_CheckBox_Language4_Module3()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language4_Module3());
        }

        public static void Select_CheckBox_Language5_Module3()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language5_Module3());
        }

        public static void UnSelect_CheckBox_Language5_Module3()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language5_Module3());
        }

        public static void Select_CheckBox_Language1_Module4()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language1_Module4());
        }

        public static void UnSelect_CheckBox_Language1_Module4()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language1_Module4());
        }

        public static void Select_CheckBox_Language2_Module4()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language2_Module4());
        }

        public static void UnSelect_CheckBox_Language2_Module4()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language2_Module4());
        }

        public static void Select_CheckBox_Language3_Module4()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language3_Module4());
        }

        public static void UnSelect_CheckBox_Language3_Module4()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language3_Module4());
        }

        public static void Select_CheckBox_Language4_Module4()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language4_Module4());
        }

        public static void UnSelect_CheckBox_Language4_Module4()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language4_Module4());
        }

        public static void Select_CheckBox_Language5_Module4()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language5_Module4());
        }

        public static void UnSelect_CheckBox_Language5_Module4()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language5_Module4());
        }

        public static void Select_CheckBox_Language1_Module5()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language1_Module5());
        }

        public static void UnSelect_CheckBox_Language1_Module5()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language1_Module5());
        }

        public static void Select_CheckBox_Language2_Module5()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language2_Module5());
        }

        public static void UnSelect_CheckBox_Language2_Module5()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language2_Module5());
        }

        public static void Select_CheckBox_Language3_Module5()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language3_Module5());
        }

        public static void UnSelect_CheckBox_Language3_Module5()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language3_Module5());
        }

        public static void Select_CheckBox_Language4_Module5()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language4_Module5());
        }

        public static void UnSelect_CheckBox_Language4_Module5()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language4_Module5());
        }

        public static void Select_CheckBox_Language5_Module5()
        {
            ElementSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language5_Module5());
        }

        public static void UnSelect_CheckBox_Language5_Module5()
        {
            ElementNOTSelected(PageObject_AdminEProposal_SetupModuleSettings.CheckBox_Language5_Module5());
        }

        /// <summary>
        ///     This method will check which modules are "Active" and make note of their "DisplayName", 
        ///     if there is no display name, it will assign the "Module" name.
        ///     08/10 Marc : Re-wrote this entire method. Also moved it to the correct class.
        /// </summary>
        /// <returns>string of value</returns>
        public static List<String> Assign_DisplayNames()
        {
            string displayName = "";
            List<String> displayNames = new List<string>();
            //Count how many modules are active
            for (int i = 1; i <= 2; i++)
            {
                if (Driver.FindElement(By.XPath(
                        "//input[@id='ctl00_ctl00_MainContent_PageContent_ModuleSettingsGridView_ctl0" + (i + 1) + "_cbxActive']"))
                    .Selected)
                {
                    //Assign Display name to the array
                    //Check if the Display Name has a value, if not, assign the Module name.
                    if (Driver.FindElement(By.XPath(
                            "//span[@id='ctl00_ctl00_MainContent_PageContent_ModuleSettingsGridView_ctl0" + (i + 1) + "_lblDisplayName']"))
                        .Text.Equals(""))
                    {
                        displayName = Driver
                            .FindElement(By.XPath(
                                "//span[@id='ctl00_ctl00_MainContent_PageContent_ModuleSettingsGridView_ctl0" + (i + 1) + "_lblModDisplayName']"))
                            .Text;
                    }
                    else
                    {
                        displayName = Driver
                            .FindElement(By.XPath(
                                "//span[@id='ctl00_ctl00_MainContent_PageContent_ModuleSettingsGridView_ctl0" + (i + 1) +
                                "_lblDisplayName']"))
                            .Text;
                    }

                    displayNames.Add(displayName);
                }
            }

            return displayNames;
        }
    }
}