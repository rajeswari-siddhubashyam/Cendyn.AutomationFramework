using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace eNgage.Utility
{
    class ObjectRepository
    {
        #region[UI]

        #region[Login]
        public static string Login_Email { get; set; }
        public static string Login_Password { get; set; }
        public static string Login_Submit { get; set; }
        public static string Login_ForgotPassword { get; set; }
        public static string Login_Text_ForgotPassword_Email { get; set; }
        public static string Login_Button_ForgotPassword_Submit { get; set; }
        public static string Login_LandingPage { get; set; }
        public static string Login_RegisterAccount { get; set; }
        #endregion[Login]

        #region[SignUp]
        public static string SignUp_FirstName { get; set; }
        public static string SignUp_LastName { get; set; }
        public static string SignUp_Email { get; set; }
        public static string SignUp_Password { get; set; }
        public static string SignUp_ConfirmPassword { get; set; }
        public static string SignUp_PasswordResetQuestion { get; set; }
        public static string SignUp_PasswordResetAnswer { get; set; }
        public static string SignUp_Register { get; set; }
        #endregion[SignUp]

        #region[Profile]
        public static string Profile_page { get; set; }
        public static string Profile_Frame { get; set; }
        #endregion[Profile]

        #region[Home]
        public static string Home_Main { get; set; }
        public static string Dashboard_Tiles { get; set; }
        public static string Home_Date { get; set; }
        public static string Home_Calendar_Table { get; set; }
        public static string Home_Calendar_Prev_Month { get; set; }
        public static string Home_Hamburger_button { get; set; }
        public static string Home_HeaderContainer { get; set; }
        public static string Home_SelectedHotel { get; set; }
        public static string Home_Hotels_List { get; set; }
        public static string Home_DashboardTile_Res_count { get; set; }
        public static string Home_Search_hotel { get; set; }
        public static string Home_Hotels_Active_List { get; set; }
        public static string Home_LastUpdated { get; set; }
        public static string Home_Refresh { get; set; }
        public static string Home_Departures { get; set; }
        public static string Home_DashboardTile_ProgressPercentage { get; set; }
        public static string Home_DashboardTile_ProgressBar_Width { get; set; }
        public static string Home_DashboardTile_Text { get; set; }
        public static string Home_DashboardTile_Icon { get; set; }
        #endregion[Home]

        #region[Search]
        public static string Search_page { get; set; }
        public static string Search_Results { get; set; }
        public static string Search_Div { get; set; }
        public static string Search_Select { get; set; }
        public static string Search_Input { get; set; }
        public static string Search_submit { get; set; }
        public static string Search_Type_button { get; set; }
        public static string Search_Type_button_values { get; set; }

        #endregion[Search]

        #region[Summary]
        public static string Summary_page { get; set; }
        #endregion[Summary]

        #region[Prompts]
        public static string Prompts_Container { get; set; }
        public static string Prompts_Data { get; set; }
        public static string Prompts_Div { get; set; }
        public static string Prompts_Div2 { get; set; }
        public static string Prompts_Responses { get; set; }
        public static string Prompts_inputText { get; set; }
        public static string Prompts_Text { get; set; }
        public static string Prompts_submit { get; set; }

        public static string Prompts_loader { get; set; }

        #endregion[Prompts]

        #region[History]
        public static string History_page { get; set; }
        public static string History_Container { get; set; }
        public static string History_Results_Table { get; set; }
        #endregion[History]

        #region[Admin]
        public static string Admin_page { get; set; }
        public static string Admin_Container { get; set; }
        public static string Admin_Tiles { get; set; }
        #endregion[Admin]

        #region[Reporting]
        public static string Reporting_page { get; set; }
        public static string Reporting_Container { get; set; }
        public static string Reporting_Results_Table { get; set; }
        #endregion[Reporting]

        #region[Preferences]
        public static string Preferences_page { get; set; }
        public static string Preferences_div { get; set; }
        public static string Preferences_SelectElements { get; set; }
        public static string Preferences_checkbox { get; set; }
        public static string Preferences_save { get; set; }
        public static string Preferences_SavedText { get; set; }

        #endregion[Preferences]
        #endregion[UI]

        public static ObjectRepository ReadElement(string location, string nodeModule)
        {
            ObjectRepository obj = new ObjectRepository();
            XDocument doc = XDocument.Load(location);
            var query = doc.Descendants(nodeModule).Elements()
                .ToDictionary(x => x.Attribute("key").Value,
                    x => x.Value);

            foreach (KeyValuePair<string, string> pair in query)
            {
                #region[Login]

                if (nodeModule == Constants.Login)
                {
                    if (pair.Key == "Login_Email")
                        Login_Email = pair.Value;
                    else if (pair.Key == "Login_Password")
                        Login_Password = pair.Value;
                    else if (pair.Key == "Login_Submit")
                        Login_Submit = pair.Value;
                    else if (pair.Key == "Login_ForgotPassword")
                        Login_ForgotPassword = pair.Value;
                    else if (pair.Key == "Login_Text_ForgotPassword_Email")
                        Login_Text_ForgotPassword_Email = pair.Value;
                    else if (pair.Key == "Login_Button_ForgotPassword_Submit")
                        Login_Button_ForgotPassword_Submit = pair.Value;
                    else if (pair.Key == "Login_LandingPage")
                        Login_LandingPage = pair.Value;
                    else if (pair.Key == "Login_RegisterAccount")
                        Login_RegisterAccount = pair.Value;
                }

                #endregion[Login]

                #region[SignUp]

                if (nodeModule == Constants.SignUp)
                {
                    if (pair.Key == "SignUp_FirstName")
                        SignUp_FirstName = pair.Value;
                    else if (pair.Key == "SignUp_LastName")
                        SignUp_LastName = pair.Value;
                    else if (pair.Key == "SignUp_Email")
                        SignUp_Email = pair.Value;
                    else if (pair.Key == "SignUp_Password")
                        SignUp_Password = pair.Value;
                    else if (pair.Key == "SignUp_ConfirmPassword")
                        SignUp_ConfirmPassword = pair.Value;
                    else if (pair.Key == "SignUp_PasswordResetQuestion")
                        SignUp_PasswordResetQuestion = pair.Value;
                    else if (pair.Key == "SignUp_PasswordResetAnswer")
                        SignUp_PasswordResetAnswer = pair.Value;
                    else if (pair.Key == "SignUp_Register")
                        SignUp_Register = pair.Value;
                }

                #endregion[SignUp]

                #region[Home]
                if (nodeModule == Constants.Home)
                {
                    if (pair.Key == "Home_Main")
                        Home_Main = pair.Value;
                    else if (pair.Key == "Dashboard_Tiles")
                        Dashboard_Tiles = pair.Value;
                    else if (pair.Key == "Home_Date")
                        Home_Date = pair.Value;
                    else if (pair.Key == "Home_Calendar_Table")
                        Home_Calendar_Table = pair.Value;
                    else if (pair.Key == "Home_Calendar_Prev_Month")
                        Home_Calendar_Prev_Month = pair.Value;
                    else if (pair.Key == "Home_Hamburger_button")
                        Home_Hamburger_button = pair.Value;
                    else if (pair.Key == "Home_HeaderContainer")
                        Home_HeaderContainer = pair.Value;
                    else if (pair.Key == "Home_SelectedHotel")
                        Home_SelectedHotel = pair.Value;
                    else if (pair.Key == "Home_Hotels_List")
                        Home_Hotels_List = pair.Value;
                    else if (pair.Key == "Home_DashboardTile_Res_count")
                        Home_DashboardTile_Res_count = pair.Value;
                    else if (pair.Key == "Home_Search_hotel")
                        Home_Search_hotel = pair.Value;
                    else if (pair.Key == "Home_Hotels_Active_List")
                        Home_Hotels_Active_List = pair.Value;
                    else if (pair.Key == "Home_LastUpdated")
                        Home_LastUpdated = pair.Value;
                    else if (pair.Key == "Home_Refresh")
                        Home_Refresh = pair.Value;
                    else if (pair.Key == "Home_Departures")
                        Home_Departures = pair.Value;
                    else if (pair.Key == "Home_DashboardTile_ProgressPercentage")
                        Home_DashboardTile_ProgressPercentage = pair.Value;
                    else if (pair.Key == "Home_DashboardTile_ProgressBar_Width")
                        Home_DashboardTile_ProgressBar_Width = pair.Value;
                    else if (pair.Key == "Home_DashboardTile_Text")
                        Home_DashboardTile_Text = pair.Value;
                    else if (pair.Key == "Home_DashboardTile_Icon")
                        Home_DashboardTile_Icon = pair.Value;
                }
                #endregion[Home]

                #region[Search]
                if (nodeModule == Constants.Search)
                {
                    if (pair.Key == "Search_page")
                        Search_page = pair.Value;
                    else if (pair.Key == "Search_Results")
                        Search_Results = pair.Value;
                    else if (pair.Key == "Search_Div")
                        Search_Div = pair.Value;
                    else if (pair.Key == "Search_Select")
                        Search_Select = pair.Value;
                    else if (pair.Key == "Search_Input")
                        Search_Input = pair.Value;
                    else if (pair.Key == "Search_submit")
                        Search_submit = pair.Value;
                    else if (pair.Key == "Search_Type_button")
                        Search_Type_button = pair.Value;
                    else if (pair.Key == "Search_Type_button_values")
                        Search_Type_button_values = pair.Value;

                }
                #endregion[Search]
                #region[Prompts]
                if (nodeModule == Constants.Prompts)
                {
                    if (pair.Key == "Prompts_Container")
                        Prompts_Container = pair.Value;
                    else if (pair.Key == "Prompts_Data")
                        Prompts_Data = pair.Value;
                    else if (pair.Key == "Prompts_Div")
                        Prompts_Div = pair.Value;
                    else if (pair.Key == "Prompts_Div2")
                        Prompts_Div2 = pair.Value;
                    else if (pair.Key == "Prompts_Responses")
                        Prompts_Responses = pair.Value;
                    else if (pair.Key == "Prompts_Text")
                        Prompts_Text = pair.Value;
                    else if (pair.Key == "Prompts_inputText")
                        Prompts_inputText = pair.Value;
                    else if (pair.Key == "Prompts_submit")
                            Prompts_submit = pair.Value;
                    else if (pair.Key == "Prompts_loader")
                        Prompts_loader = pair.Value;
                }
                #endregion[Prompts]

                #region[Summary]
                if (nodeModule == Constants.Summary)
                {
                    if (pair.Key == "Summary_page")
                        Summary_page = pair.Value;

                }
                #endregion[Summary]

                #region[Profile]
                if (nodeModule == Constants.Profile)
                {
                    if (pair.Key == "Profile_page")
                        Profile_page = pair.Value;
                    else if (pair.Key == "Profile_Frame")
                        Profile_Frame = pair.Value;
                }
                #endregion[Profile]
                #region[History]
                if (nodeModule == Constants.History)
                {
                    if (pair.Key == "History_page")
                        History_page = pair.Value;
                    else if (pair.Key == "History_Container")
                        History_Container = pair.Value;
                    else if (pair.Key == "History_Results_Table")
                        History_Results_Table = pair.Value;

                }
                #endregion[History]

                #region[Admin]
                if (nodeModule == Constants.Admin)
                {
                    if (pair.Key == "Admin_page")
                        Admin_page = pair.Value;
                    else if (pair.Key == "Admin_Container")
                        Admin_Container = pair.Value;
                    else if (pair.Key == "Admin_Tiles")
                        Admin_Tiles = pair.Value;
                }
                #endregion[Admin]

                #region[Reporting]
                if (nodeModule == Constants.Reporting)
                {
                    if (pair.Key == "Reporting_page")
                        Reporting_page = pair.Value;
                    else if (pair.Key == "Reporting_Container")
                        Reporting_Container = pair.Value;
                    else if (pair.Key == "Reporting_Results_Table")
                        Reporting_Results_Table = pair.Value;
                }
                #endregion[Reporting]
                #region[Preferences]
                if (nodeModule == Constants.Preferences)
                {
                    if (pair.Key == "Preferences_page")
                        Preferences_page = pair.Value;
                    else if (pair.Key == "Preferences_save")
                        Preferences_save = pair.Value;
                    else if (pair.Key == "Preferences_div")
                        Preferences_div = pair.Value;
                    else if (pair.Key == "Preferences_SelectElements")
                        Preferences_SelectElements = pair.Value;
                    else if (pair.Key == "Preferences_checkbox")
                        Preferences_checkbox = pair.Value;
                    else if (pair.Key == "Preferences_SavedText")
                        Preferences_SavedText = pair.Value;
                }
                #endregion[Preferences]
            }
            return obj;
        }
    }
}
