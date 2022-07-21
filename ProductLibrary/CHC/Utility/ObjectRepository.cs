using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CHC.Utility
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

        #region[Navigation]
        public static string Navigation_Configuration_App { get; set; }
        public static string Navigation_Marketing_Automation_App { get; set; }
        public static string Navigation_GetCardBody_App { get; set; }
        public static string Navigation_Starling_App { get; set; }
        public static string Navigation_Unified_Profile_App { get; set; }
        #endregion[Navigation]

        #region[Navigation]
        public static string Home_Applications { get; set; }
        public static string Home_PopupChoose { get; set; }
        public static string Home_PopupCancel { get; set; }
        public static string UserAccountMouseover { get; set; }
        public static string User_Logout { get; set; }
        public static string ExpandableIcon { get; set; }
        public static string Accounts { get; set; }
        public static string AccountPageName { get; set; }
        
        #endregion[Navigation]

        #region[Profiles]
        public static string Filter_By_Email { get; set; }
        public static string Search_Icon { get; set; }
        public static string Filter_Button { get; set; }  
        public static string Filter_Applybutton { get; set; }
        public static string Filter_Clearbutton { get; set; }
        public static string Sort_Applybutton { get; set; }
        public static string Sort_Clearbutton { get; set; }
        public static string Sort_Button { get; set; }
        public static string Profileidfield_ContainsFilter { get; set; }
        public static string table { get; set; }
        public static string View_Profile { get; set; }
        public static string ProfileIdRecordontable { get; set; }
        public static string ViewProfileName { get; set; }
        public static string Reservations_Tab { get; set; }
        public static string Verifyreservationdetail { get; set; }
        public static string Reservationrecordontable { get; set; }
        public static string View_Profilerecordon_Viewpage { get; set; }
        public static string Clickonfirstrecord { get; set; }
        public static string Clickonfistrecordsecondontable { get; set; }
        public static string Applauncher { get; set; }
        public static string Verifyviewreservationrecord { get; set; }
        public static string Applauncher_Applications { get; set; }
        public static string ContactDetails { get; set; }        
        public static string Home_Button { get; set; }
        public static string Help_Link { get; set; }
        public static string HelpMouseOver { get; set; }
        public static string Help_ScheduleMeeting { get; set; }
        public static string Org_Swithcer_Top_Nav { get; set; }
        public static string Org_Swithcer_Select { get; set; }
        public static string Manage_Campaign_Filter_DropDown_FilterOptions { get; set; }
        public static string Manage_Campaign_Filter_Status_DropDown_Arrow { get; set; }
        public static string Manage_Campaign_Filter_Status_DropDown_Input { get; set; }
        public static string Manage_Campaign_Filter_Status_DropDown_Options { get; set; }
        public static string Manage_Campaign_Filter_UpdatedOn_Input { get; set; }
        public static string Manage_Campaign_Filter_ID_Text { get; set; }
        public static string Home_Text_Homepage { get; set; }
        public static string Data_Inspection { get; set; }
        public static string Data_Inspection_Raw_Profiles { get; set; }
        #endregion[Profiles]     

        #region[Reservations] 
        public static string ReservationID_Search { get; set; }
        #endregion[Reservations]
    
        public static ObjectRepository ReadElement  (string location, string nodeModule)
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
                    if (pair.Key == "Navigation_Configuration_App")
                        Navigation_Configuration_App = pair.Value;
                    else if (pair.Key == "Navigation_Marketing_Automation_App")
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

                #region[Profiles]
                if (nodeModule == Constants.Profiles)
                {
                    if (pair.Key == "Filter_By_Email")
                        Filter_By_Email = pair.Value;
                    if (pair.Key == "Search_Icon")
                        Search_Icon = pair.Value;
                    if (pair.Key == "Filter_Button")
                        Filter_Button = pair.Value;
                    if (pair.Key == "Sort_Button")
                        Sort_Button = pair.Value;
                    if (pair.Key == "table")
                        table = pair.Value;
                    if (pair.Key == "View_Profile")
                        View_Profile = pair.Value;
                    if (pair.Key == "Filter_Applybutton")
                        Filter_Applybutton = pair.Value;
                    if (pair.Key == "Filter_Clearbutton")
                        Filter_Clearbutton = pair.Value;
                    if (pair.Key == "Sort_Applybutton")
                        Sort_Applybutton = pair.Value;
                    if (pair.Key == "Sort_Clearbutton")
                        Sort_Clearbutton = pair.Value;
                    if (pair.Key == "Profileidfield_ContainsFilter")
                        Profileidfield_ContainsFilter = pair.Value;
                    if (pair.Key == "ProfileIdRecordontable")
                        ProfileIdRecordontable = pair.Value;
                    if (pair.Key == "ViewProfileName")
                        ViewProfileName = pair.Value;
                    if (pair.Key == "View_Profilerecordon_Viewpage")
                        View_Profilerecordon_Viewpage = pair.Value;
                    if (pair.Key == "Reservations_Tab")
                        Reservations_Tab = pair.Value;
                    if (pair.Key == "Verifyreservationdetail")
                        Verifyreservationdetail = pair.Value;
                    if (pair.Key == "Reservationrecordontable")
                        Reservationrecordontable = pair.Value;
                    if (pair.Key == "Clickonfirstrecord")
                        Clickonfirstrecord = pair.Value;
                    if (pair.Key == "Clickonfistrecordsecondontable")
                        Clickonfistrecordsecondontable = pair.Value;
                    if (pair.Key == "Verifyviewreservationrecord")
                        Verifyviewreservationrecord = pair.Value;
                    else if (pair.Key == "Applauncher")
                        Applauncher = pair.Value;
                    else if (pair.Key == "Applauncher_Applications")
                        Applauncher_Applications = pair.Value;
                    else if (pair.Key == "ContactDetails")
                        ContactDetails = pair.Value;
                    else if (pair.Key == "Home_Button")
                        Home_Button = pair.Value;
                    else if (pair.Key == "Help_Link")
                        Help_Link = pair.Value;
                    else if (pair.Key == "HelpMouseOver")
                        HelpMouseOver = pair.Value;
                    else if (pair.Key == "Help_ScheduleMeeting")
                        Help_ScheduleMeeting = pair.Value;
                    else if (pair.Key == "Org_Swithcer_Top_Nav")
                        Org_Swithcer_Top_Nav = pair.Value;
                    else if (pair.Key == "Org_Swithcer_Select")
                        Org_Swithcer_Select = pair.Value;
                    else if (pair.Key == "Manage_Campaign_Filter_DropDown_FilterOptions")
                        Manage_Campaign_Filter_DropDown_FilterOptions = pair.Value;
                    else if (pair.Key == "Manage_Campaign_Filter_Status_DropDown_Arrow")
                        Manage_Campaign_Filter_Status_DropDown_Arrow = pair.Value;
                    else if (pair.Key == "Manage_Campaign_Filter_Status_DropDown_Input")
                        Manage_Campaign_Filter_Status_DropDown_Input = pair.Value;
                    else if (pair.Key == "Manage_Campaign_Filter_Status_DropDown_Options")
                        Manage_Campaign_Filter_Status_DropDown_Options = pair.Value;
                    else if (pair.Key == "Manage_Campaign_Filter_UpdatedOn_Input")
                        Manage_Campaign_Filter_UpdatedOn_Input = pair.Value;
                    else if (pair.Key == "Manage_Campaign_Filter_ID_Text")
                        Manage_Campaign_Filter_ID_Text = pair.Value;
                    else if (pair.Key == "Home_Text_Homepage")
                        Home_Text_Homepage = pair.Value;
                    else if (pair.Key == "Data_Inspection")
                        Data_Inspection = pair.Value;
                    else if (pair.Key == "Data_Inspection_Raw_Profiles")
                        Data_Inspection_Raw_Profiles = pair.Value;
                }
                #endregion[Profiles] 

                #region[Reservations]
                if (nodeModule == Constants.Reservations)
                {
                    if (pair.Key == "ReservationID_Search")
                        ReservationID_Search = pair.Value;
                }
                #endregion[Reservations]
            }

            return obj;
            }
        }
    }

