using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CHC_Config.Utility
{
    class ObjectRepository
    {
        #region[SignIn]
        public static string SignIn_Email { get; set; }
        public static string SignIn_Password { get; set; }
        public static string SignIn_Email_Testuser { get; set; }
        public static string SignIn_Password_Testuser { get; set; }
        public static string SignIn_Submit { get; set; }
        #endregion[SignIn]

        #region[Home]
        //public static string Navigation_Configuration_App { get; set; }
        public static string Navigation_Marketing_Automation_App { get; set; }
        public static string Navigation_GetCardBody_App { get; set; }
        public static string Navigation_Starling_App { get; set; }
        public static string Navigation_Unified_Profile_App { get; set; }
        public static string Home_Applications { get; set; }
        public static string Home_PopupChoose { get; set; }
        public static string Home_PopupCancel { get; set; }
        public static string UserAccountMouseover { get; set; }
        public static string User_Logout { get; set; }
        public static string ExpandableIcon { get; set; }
        public static string Accounts { get; set; }
        public static string AccountPageName { get; set; }
        #endregion[Home]

        #region[Navigation]
        public static string Navigation_Configuration_App { get; set; }
        #endregion[Navigation]

        #region[OrgIndex]
        public static string OrgIndex_table { get; set; }
        public static string OrgIndex_th_td { get; set; }
        public static string Filter_PropertyName { get; set; }
        public static string Filter_PropertyName_Search { get; set; }
        public static string SearchResults_Row { get; set; }
        public static string SearchResults_PropertyName { get; set; }
        public static string SearchResults_Brand { get; set; }
        public static string SearchResults_Chain { get; set; }
        public static string OrgIndex_loading { get; set; }
        public static string Create_List { get; set; }
        public static string Filter_Button { get; set; }
        public static string Filter_Options { get; set; }
        public static string Filter_Options_Select { get; set; }
        public static string Filter_Options_Text { get; set; }
        public static string Filter_Applybutton { get; set; }
        public static string Filter_Clearbutton { get; set; }
        #endregion[OrgIndex]

        #region[Dashboard]
        public static string PropertyDashboard_Org { get; set; }
        public static string PropertyDashboard_header { get; set; }
        public static string BrandDashboard_Org { get; set; }
        public static string BrandDashboard_header { get; set; }
        public static string ChainDashboard_Org { get; set; }
        public static string ChainDashboard_header { get; set; }
        public static string Dashboard_Property_Name { get; set; }
        public static string Dashboard_Brand_Name { get; set; }
        public static string Dashboard_Chain_Name { get; set; }
        public static string Dashboard_navTabs { get; set; }
        public static string Dashboard_GeneralTab { get; set; }
        public static string Dashboard_BrandTab { get; set; }
        public static string Dashboard_General_Localization_div { get; set; }
        public static string ChainDashboard_Localization { get; set; }
        public static string ChainDashboard_Phone { get; set; }
        public static string ChainDashboard_Link { get; set; }
        public static string Dashboard_ColumnName { get; set; }
        public static string Dashboard_ColumnValue { get; set; }
        public static string ChainDashboard_Basic_details_div { get; set; }
        public static string ChainDashboard_address { get; set; }
        public static string Dashboard_status { get; set; }
        public static string ChainDashboard_property_details { get; set; }
        public static string BrandDashboard_property_details { get; set; }
        public static string PropertyDashboard_property_details { get; set; }
        public static string Dashboard_sideColumnName { get; set; }
        public static string Dashboard_sideColumnValue { get; set; }
        public static string ChainDashboard_Link_image { get; set; }
        public static string Dashboard_Brand_header { get; set; }
        public static string Dashboard_Brand_div { get; set; }
        public static string Dashboard_Brandtable_Names { get; set; }
        public static string Dashboard_Brandtable_Row { get; set; }
        public static string Dashboard_Brandtable_DateAdded { get; set; }
        public static string Dashboard_Prop_header { get; set; }
        public static string Dashboard_Prop_div { get; set; }
        public static string Dashboard_loading { get; set; }
        public static string Dashboard_PropTab { get; set; }
   
        public static string Dashboard_Proptable_Row { get; set; }
        public static string Dashboard_Prop_Names { get; set; }
        public static string ChainDashboard_FirstBrand { get; set; }
        public static string ChainDashboard_FirstProperty { get; set; }

        public static string PropertyDashboard_Metadata { get; set; }
        public static string PropertyDashboard_AdvancedConfig { get; set; }
        public static string PropertyDashboard_Facilities { get; set; }
        public static string PropertyDashboard_Rooms { get; set; }
        public static string PropertyDashboard_Beds { get; set; }
        public static string PropertyDashboard_ColumnName { get; set; }
        public static string PropertyDashboard_ColumnValue { get; set; }
        
        #endregion[Dashboard]

        #region[Create]
        public static string Create_Button { get; set; }
        public static string create_cancel { get; set; }
        public static string createPage_header { get; set; }
        public static string Manage_Property { get; set; }
        public static string Manage_Brand { get; set; }
        public static string Edit_Details { get; set; }
        public static string input_chain { get; set; }
        public static string input_brand { get; set; }
        public static string input_property { get; set; }

        #endregion[Create]

        #region[CreateUser]

        public static string User_Tab_Leftnav { get; set; }
        public static string User_Create_User_Button { get; set; }
        public static string User_Popup_Proceed { get; set; }
        public static string User_Popup_Cancel { get; set; }
        public static string User_Popup_Enter_Email { get; set; }
        public static string User_Popup_Enter_Email_Error { get; set; }
        public static string User_Create_User_FirstName { get; set; }
        public static string User_Create_User_LastName { get; set; }
        public static string User_Create_User_Email { get; set; }
        public static string User_Create_User_JobTitle { get; set; }
        public static string User_Create_User_FirstName_ErrorMsg { get; set; }
        public static string User_Create_User_LastName_ErrorMsg { get; set; }
        public static string User_Create_User_Continue_Button { get; set; }
        public static string User_Create_User_AssignOrg { get; set; }
        public static string User_Create_User_Select_All { get; set; }
        public static string User_Create_User_AssignApp { get; set; }
        public static string User_Create_User_AssignRoles { get; set; }                           
        #endregion[CreateUser]

        public static ObjectRepository ReadElement(string location, string nodeModule)
        {

            ObjectRepository obj = new ObjectRepository();
            XDocument doc = XDocument.Load(location);
            var query = doc.Descendants(nodeModule).Elements().ToDictionary(x => x.Attribute("key").Value, x => x.Value);

            foreach (KeyValuePair<string, string> pair in query)
            {
                #region[Login]
                if (nodeModule == Constants.SignIn)
                {
                    if (pair.Key == "SignIn_Email")
                        SignIn_Email = pair.Value;
                    else if (pair.Key == "SignIn_Password")
                        SignIn_Password = pair.Value;
                    if (pair.Key == "SignIn_Email_Testuser")
                        SignIn_Email_Testuser = pair.Value;
                    else if (pair.Key == "SignIn_Password_Testuser")
                        SignIn_Password_Testuser = pair.Value;
                    else if (pair.Key == "SignIn_Submit")
                        SignIn_Submit = pair.Value;
                }
                #endregion[Login]

                #region[Home]
                if (nodeModule == Constants.Home)
                {
                    //if (pair.Key == "Navigation_Configuration_App")
                    //    Navigation_Configuration_App = pair.Value;
                    //else 
                    if (pair.Key == "Navigation_Marketing_Automation_App")
                        Navigation_Marketing_Automation_App = pair.Value;
                    else if (pair.Key == "Navigation_Starling_App")
                        Navigation_Starling_App = pair.Value;
                    else if (pair.Key == "Navigation_Unified_Profile_App")
                        Navigation_Unified_Profile_App = pair.Value;
                    else if (pair.Key == "Home_Applications")
                        Home_Applications = pair.Value;
                    else if (pair.Key == "Home_PopupChoose")
                        Home_PopupChoose = pair.Value;
                    else if (pair.Key == "Home_PopupCancel")
                        Home_PopupCancel = pair.Value;
                    else if (pair.Key == "UserAccountMouseover")
                        UserAccountMouseover = pair.Value;
                    else if (pair.Key == "User_Logout")
                        User_Logout = pair.Value;
                    else if (pair.Key == "ExpandableIcon")
                        ExpandableIcon = pair.Value;
                    else if (pair.Key == "Accounts")
                        Accounts = pair.Value;
                    else if (pair.Key == "AccountPageName")
                        AccountPageName = pair.Value;
                }
                #endregion[Home] 

                #region[Navigation]
                if (nodeModule == Constants.Navigation)
                {
                    if (pair.Key == "Navigation_Configuration_App")
                        Navigation_Configuration_App = pair.Value;                    
                }
                #endregion[Navigation] 

                #region[OrgIndex]
                if (nodeModule == Constants.OrgIndex)
                {
                    if (pair.Key == "OrgIndex_table")
                        OrgIndex_table = pair.Value;
                    else if (pair.Key == "OrgIndex_th_td")
                        OrgIndex_th_td = pair.Value;
                    else if (pair.Key == "Filter_PropertyName")
                        Filter_PropertyName = pair.Value;
                    else if (pair.Key == "Filter_PropertyName_Search")
                        Filter_PropertyName_Search = pair.Value;
                    else if (pair.Key == "SearchResults_Row")
                        SearchResults_Row = pair.Value;
                    else if (pair.Key == "SearchResults_PropertyName")
                        SearchResults_PropertyName = pair.Value;
                    else if (pair.Key == "SearchResults_Brand")
                        SearchResults_Brand = pair.Value;
                    else if (pair.Key == "SearchResults_Chain")
                        SearchResults_Chain = pair.Value;
                    else if (pair.Key == "OrgIndex_loading")
                        OrgIndex_loading = pair.Value;
                    else if (pair.Key == "Create_List")
                        Create_List = pair.Value;
                    else if (pair.Key == "Filter_Button")
                        Filter_Button = pair.Value;
                    else if (pair.Key == "Filter_Options")
                        Filter_Options = pair.Value;
                    else if (pair.Key == "Filter_Options_Select")
                        Filter_Options_Select = pair.Value;
                    else if (pair.Key == "Filter_Options_Text")
                        Filter_Options_Text = pair.Value;
                    else if (pair.Key == "Filter_Applybutton")
                        Filter_Applybutton = pair.Value;
                    else if (pair.Key == "Filter_Clearbutton")
                        Filter_Clearbutton = pair.Value;
                }
                #endregion[OrgIndex]

                #region[Dashboard]
                if (nodeModule == Constants.PropertyDashboard)
                {
                    if (pair.Key == "PropertyDashboard_Org")
                        PropertyDashboard_Org = pair.Value;
                    else if (pair.Key == "PropertyDashboard_header")
                        PropertyDashboard_header = pair.Value;
                    else if (pair.Key == "Dashboard_Property_Name")
                        Dashboard_Property_Name = pair.Value;
                    else if (pair.Key == "Dashboard_Brand_Name")
                        Dashboard_Brand_Name = pair.Value;
                    else if (pair.Key == "Dashboard_Chain_Name")
                        Dashboard_Chain_Name = pair.Value;
                    else if (pair.Key == "BrandDashboard_Org")
                        BrandDashboard_Org = pair.Value;
                    else if (pair.Key == "BrandDashboard_header")
                        BrandDashboard_header = pair.Value;
                    else if (pair.Key == "ChainDashboard_Org")
                        ChainDashboard_Org = pair.Value;
                    else if (pair.Key == "ChainDashboard_header")
                        ChainDashboard_header = pair.Value;
                    else if (pair.Key == "Dashboard_navTabs")
                        Dashboard_navTabs = pair.Value;
                    else if (pair.Key == "Dashboard_GeneralTab")
                        Dashboard_GeneralTab = pair.Value;
                    else if (pair.Key == "Dashboard_BrandTab")
                        Dashboard_BrandTab = pair.Value;
                    else if (pair.Key == "Dashboard_General_Localization_div")
                        Dashboard_General_Localization_div = pair.Value;
                    else if (pair.Key == "ChainDashboard_Localization")
                        ChainDashboard_Localization = pair.Value;
                    else if (pair.Key == "ChainDashboard_Phone")
                        ChainDashboard_Phone = pair.Value;
                    else if (pair.Key == "ChainDashboard_Link")
                        ChainDashboard_Link = pair.Value;
                    else if (pair.Key == "Dashboard_ColumnName")
                        Dashboard_ColumnName = pair.Value;
                    else if (pair.Key == "Dashboard_ColumnValue")
                        Dashboard_ColumnValue = pair.Value;
                    else if (pair.Key == "ChainDashboard_Basic_details_div")
                        ChainDashboard_Basic_details_div = pair.Value;
                    else if (pair.Key == "ChainDashboard_address")
                        ChainDashboard_address = pair.Value;
                    else if (pair.Key == "Dashboard_status")
                        Dashboard_status = pair.Value;
                    else if (pair.Key == "ChainDashboard_property_details")
                        ChainDashboard_property_details = pair.Value;
                    else if (pair.Key == "BrandDashboard_property_details")
                        BrandDashboard_property_details = pair.Value;
                    else if (pair.Key == "Dashboard_sideColumnName")
                        Dashboard_sideColumnName = pair.Value;
                    else if (pair.Key == "Dashboard_sideColumnValue")
                        Dashboard_sideColumnValue = pair.Value;
                    else if (pair.Key == "ChainDashboard_Link_image")
                        ChainDashboard_Link_image = pair.Value;
                    else if (pair.Key == "Dashboard_Brand_header")
                        Dashboard_Brand_header = pair.Value;
                    else if (pair.Key == "Dashboard_Brand_div")
                        Dashboard_Brand_div = pair.Value;
                    else if (pair.Key == "Dashboard_Brandtable_Names")
                        Dashboard_Brandtable_Names = pair.Value;
                    else if (pair.Key == "Dashboard_Brandtable_Row")
                        Dashboard_Brandtable_Row = pair.Value;
                    else if (pair.Key == "Dashboard_Brandtable_DateAdded")
                        Dashboard_Brandtable_DateAdded = pair.Value;
                    else if (pair.Key == "Dashboard_Prop_header")
                        Dashboard_Prop_header = pair.Value;
                    else if (pair.Key == "Dashboard_Prop_div")
                        Dashboard_Prop_div = pair.Value;
                    else if (pair.Key == "Dashboard_loading")
                        Dashboard_loading = pair.Value;
                    else if (pair.Key == "Dashboard_PropTab")
                        Dashboard_PropTab = pair.Value;
                    else if (pair.Key == "Dashboard_Proptable_Row")
                        Dashboard_Proptable_Row = pair.Value;
                    else if (pair.Key == "Dashboard_Prop_Names")
                        Dashboard_Prop_Names = pair.Value;
                    else if (pair.Key == "ChainDashboard_FirstBrand")
                        ChainDashboard_FirstBrand = pair.Value;
                    else if (pair.Key == "ChainDashboard_FirstProperty")
                        ChainDashboard_FirstProperty = pair.Value;
                    else if (pair.Key == "PropertyDashboard_property_details")
                        PropertyDashboard_property_details = pair.Value;
                    else if (pair.Key == "PropertyDashboard_Metadata")
                        PropertyDashboard_Metadata = pair.Value;
                    else if (pair.Key == "PropertyDashboard_AdvancedConfig")
                        PropertyDashboard_AdvancedConfig = pair.Value;
                    else if (pair.Key == "PropertyDashboard_Facilities")
                        PropertyDashboard_Facilities = pair.Value;
                    else if (pair.Key == "PropertyDashboard_Rooms")
                        PropertyDashboard_Rooms = pair.Value;
                    else if (pair.Key == "PropertyDashboard_Beds")
                        PropertyDashboard_Beds = pair.Value;                    
                    else if (pair.Key == "PropertyDashboard_ColumnName")
                        PropertyDashboard_ColumnName = pair.Value;
                    else if (pair.Key == "PropertyDashboard_ColumnValue")
                        PropertyDashboard_ColumnValue = pair.Value;
                }
                #endregion[Dashboard]

                #region[Create]
                if (nodeModule == Constants.Create)
                {
                    if (pair.Key == "Create_Button")
                        Create_Button = pair.Value;
                    else if (pair.Key == "create_cancel")
                        create_cancel = pair.Value;
                    else if (pair.Key == "createPage_header")
                        createPage_header = pair.Value;
                    else if (pair.Key == "Manage_Property")
                        Manage_Property = pair.Value;
                    else if (pair.Key == "Manage_Brand")
                        Manage_Brand = pair.Value;
                    else if (pair.Key == "Edit_Details")
                        Edit_Details = pair.Value;
                    else if (pair.Key == "input_chain")
                        input_chain = pair.Value;
                    else if (pair.Key == "input_brand")
                        input_brand = pair.Value;
                    else if (pair.Key == "input_property")
                        input_property = pair.Value;
                }
                #endregion[Create]

                #region[CreateUser]
                if (nodeModule == Constants.CreateUser)
                {
                    if (pair.Key == "User_Tab_Leftnav")
                        User_Tab_Leftnav = pair.Value;
                    else if (pair.Key == "User_Create_User_Button")
                        User_Create_User_Button = pair.Value;
                    else if (pair.Key == "User_Popup_Proceed")
                        User_Popup_Proceed = pair.Value;
                    else if (pair.Key == "User_Popup_Cancel")
                        User_Popup_Cancel = pair.Value;
                    else if (pair.Key == "User_Popup_Enter_Email")
                        User_Popup_Enter_Email = pair.Value;
                    else if (pair.Key == "User_Popup_Enter_Email_Error")
                        User_Popup_Enter_Email_Error = pair.Value;
                    else if (pair.Key == "User_Create_User_FirstName")
                        User_Create_User_FirstName = pair.Value;
                    else if (pair.Key == "User_Create_User_LastName")
                        User_Create_User_LastName = pair.Value;
                    else if (pair.Key == "User_Create_User_Email")
                        User_Create_User_Email = pair.Value;
                    else if (pair.Key == "User_Create_User_JobTitle")
                        User_Create_User_JobTitle = pair.Value;
                    else if (pair.Key == "User_Create_User_FirstName_ErrorMsg")
                        User_Create_User_FirstName_ErrorMsg = pair.Value;
                    else if (pair.Key == "User_Create_User_LastName_ErrorMsg")
                        User_Create_User_LastName_ErrorMsg = pair.Value;
                    else if (pair.Key == "User_Create_User_Continue_Button")
                        User_Create_User_Continue_Button = pair.Value;
                    else if (pair.Key == "User_Create_User_AssignOrg")
                        User_Create_User_AssignOrg = pair.Value;
                    else if (pair.Key == "User_Create_User_Select_All")
                        User_Create_User_Select_All = pair.Value;
                    else if (pair.Key == "User_Create_User_AssignApp")
                        User_Create_User_AssignApp = pair.Value;
                    else if (pair.Key == "User_Create_User_AssignRoles")
                        User_Create_User_AssignRoles = pair.Value;                    
                }
                #endregion[CreateUser]
            }
            return obj;
            
        }
    }
}
