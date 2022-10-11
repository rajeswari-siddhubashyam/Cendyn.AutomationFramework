using BaseUtility.PageObject;
using CHC_Config.Utility;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Reflection;
using NUnit.Framework;

namespace CHC_Config.PageObject.UI
{
    class PageObject_CreateUser : Setup
    {
        public static string PageName = CHC_Config.Utility.Constants.CreateUser;
        public static IWebElement Users_Tab()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Tab_Leftnav);
        }

        public static IWebElement Userdashboard_Property_filter_enter_value()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Userdashboard_Filter_Enter_value);
        }

        public static IWebElement Userdashboard_Property_filter_Apply_button()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Userdashboard_Filter_Apply_Button);
        }
        
        public static IWebElement Organizations_Tab()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Config_Organization);
        }
        
        public static IWebElement UserDashboard_Propertytab_ID_filter()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.UserDashboard_Proeprty_tab_PropertyId_filter);
        }

        public static IWebElement UserDashboard_Propertytab_Name_filter()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.UserDashboard_Proeprty_tab_PropertyName_filter);
        }

        public static IWebElement UserDashboard_Chaintab_ID_filter()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.UserDashboard_Chain_tab_ChainId_filter);
        }

        public static IWebElement UserDashboard_Chaintab_Name_filter()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.UserDashboard_Chain_tab_ChainName_filter);
        }

        public static IWebElement UserDashboard_Brandtab_ID_filter()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.UserDashboard_Brand_tab_BrandId_filter);
        }

        public static IWebElement UserDashboard_Brandtab_Name_filter()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.UserDashboard_Brand_tab_BrandName_filter);
        }

        public static IList<IWebElement> CreateUser_Org_Accounts()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Org_Accounts);
        }

        public static IWebElement Craete_User_Button()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_Button);
        }

        public static IWebElement Create_User_Proceed_Button()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Popup_Proceed);
        }

        public static IWebElement Create_User_Cancel_Button()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Popup_Cancel);
        }

        public static IWebElement Create_User_Email()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Popup_Enter_Email);
        }

        public static IWebElement Create_User_Email_Error()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Popup_Enter_Email_Error);
        }

        public static IWebElement Create_User_FirstName()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_FirstName);
        }

        public static IWebElement Create_User_LastName()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_LastName);
        }

        public static IWebElement Create_User_Email_Disabled()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_Email);
        }

        public static IWebElement Create_User_JobTitle()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_JobTitle);
        }

        public static IWebElement Create_User_FirstName_Error_Msg()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_FirstName_ErrorMsg);
        }

        public static IWebElement Create_User_LastName_Error_Msg()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_LastName_ErrorMsg);
        }

        public static IWebElement Create_User_Continue_Button()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_Continue_Button);
        }

        public static IWebElement Create_User_AssignOrg()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Org_Accounts);
        }

        public static IWebElement Create_User_Select_All()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_Select_All);
        }

        public static IWebElement Create_User_AssignApp()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_CreateUser_AssignApp);
        }

        public static IWebElement Create_User_AssignRoles()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_AssignRoles);
        }

        public static IWebElement Create_User_AssignRoles_Starling_Readonly()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_Roles_Starling_Readonly);
        }

        public static IWebElement Verify_Indexpage_Title()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Index);
        }

        public static IWebElement Txt_User_searchbox()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_Search);
        }

        public static IWebElement Create_User_Index_Search_Icon()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_Clickon_Searchicon);
        }

        public static IWebElement CreateUser_Filter()
        {
            ScanPage(Constants.OrgIndex);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Filter_Button);
        }

        public static IWebElement Txt_Profileidfieldcontainsfilter()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Profileidfield_ContainsFilter);
        }

        public static IWebElement Clear_Filter()
        {
            ScanPage(Constants.OrgIndex);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Filter_Clearbutton);
        }

        public static IList<IWebElement> AllColumns_OnTable()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementsXPath(ObjectRepository.Table_Allcolumns);
        }

        public static IWebElement CreateUser_Btn_Sort()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateUser_Sort);
        }

        public static IWebElement Lnk_clickonProfilerecord()
        {
            ScanPage(Constants.Profiles);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Clickonfirstrecord);
        }

        public static IWebElement Lnk_clickon_Applybutton()
        {
            ScanPage(Constants.OrgIndex);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Filter_Applybutton);
        }

        public static IWebElement User_Dashboard_Property_tab()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Dashboard_Properties_tab);
        }

        public static IWebElement User_Dashboard_Chain_tab()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Dashboard_Chain_tab);
        }

        public static IWebElement User_Dashboard_Brandy_tab()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Dashboard_Brand_tab);
        }

        public static IWebElement User_Dashboard_Apps_Roles_tab()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Dashboard_Applications_Roles_tab);
        }

        public static IWebElement CreateUser_Dashboard_History_tab()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Dashboard_History_tab);
        }

        public static IWebElement Txt_Proeprty_ChecktextonUser_Dashboard()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateUser_Dashboard_propertytab);
        }

        public static IWebElement Txt_Chainid_ChecktextonUser_Dashboard()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Verify_ChainId);
        }

        public static IWebElement Txt_Brandid_ChecktextonUser_Dashboard()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Verify_BrandId);
        }

        public static IWebElement Txt_Apps_Roles_ChecktextonUser_Dashboard()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Verify_Application_Roles);
        }

        public static IWebElement UserDashboard_Historytab()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.CreateUser_History_Tab);
        }

        public static IWebElement CreateUser_Clickon_Chaintab()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Dashboard_Chain_tab);
        }

        public static IWebElement CreateUser_Clickon_Brandtab()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Dashboard_Brand_tab);
        }

        public static IWebElement CreateUser_Clickon_Historytab()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Dashboard_History_tab);
        }

        public static IWebElement CreateUser_Clickon_App_Rolestab()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Dashboard_Applications_Roles_tab);
        }

        public static IWebElement CreateUser_Dashboard_Rolestab_Home()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Verify_Application_Roles);
        }

        public static IWebElement CreateUser_History_Created()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Verify_History_ProfileCreated);
        }

        public static IWebElement CreateUser_History_Updated()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Verify_History_ProfileUpdated);
        }

        public static IWebElement Lnx_UserIndex_Moredetails()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.UserIndex_Moredetails);
        }

        public static IWebElement Lnx_UserIndex_Moredetails_Edit()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.UserIndex_Moredetails_Edit);
        }

        public static IWebElement Txt_Edit_User()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Edit_User);
        }

        public static IWebElement btn_Userdashboard_Edit_User()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.UserDashboard_EditUser_Button);
        }
        

        public static IWebElement Txt_Edit_User_Access_Role_tab()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.Edit_User_Access_Roles);
        }

        public static IWebElement UserDashboard_EditUser_tab()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.UserDashboard_EditUser);
        }

        public static IWebElement EditUser_Assign_Org()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.User_Create_User_AssignOrg12);
        }

        public static IWebElement UserIndex_Sort_Apply_button()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.UserIndex_Sort_Applybutton);
        }

        public static IWebElement UserIndex_Filter_Apply_button()
        {
            ScanPage(Constants.CreateUser);
            CurrentPageName = PageName;
            CurrentElementName = MethodBase.GetCurrentMethod().Name;
            return PageAction.Find_ElementXPath(ObjectRepository.UserIndex_Filter_Applybutton);
        }

    }

}


