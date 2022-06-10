#region Using

#endregion
namespace Common
{
    public class Constants
    {
        #region Excel Field Name
        public static string ProjectName = "ProjectName";
        public static string ControllerColumnName = "Y/N";
        public static string Url = "Url";
        public static string Username = "Username";
        public static string Password = "Password";
        public static string Selection = "Selection";
        public static string Browser = "Browser";

        //Excel
        public static string KeyName = "KeyName";
        public static string KeyValue = "KeyValue";
        #endregion Excel Field Name

        #region Folder Locations

        public static string RootPath;//= Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
        public static string GetProjectName;// = System.Reflection.Assembly.GetCallingAssembly().GetName().Name;
                                            //public static string RootPath1 = Path.GetPathRoot(Environment.CurrentDirectory);

        public static string actualPath;// = CommonMethod.GetProjectPath("1");
        public static string image_ActualPath;// =CommonMethod.GetProjectPath("0");

        public static string ObjectRepofile;// = String.Concat(RootPath, ConfigurationManager.AppSettings["ObjectRepofile"]);

        public static string ScreenshotPath;// = String.Concat(actualPath, ConfigurationManager.AppSettings["ScreenshotPath"]);

        public static string ReportPath;// = String.Concat(actualPath, ConfigurationManager.AppSettings["ReportPath"]);

        public static string LogFilePath;// = String.Concat(actualPath, ConfigurationManager.AppSettings["LoggerFile"]);

        public static string ImagePath;// = String.Concat(image_ActualPath, ConfigurationManager.AppSettings["ImagePath"]);
        public static string Project_Path;
        #endregion Folder Locations

        //#region[Test Plans]
        //public static string TP_121746 = "TP_121746";

        //#endregion[Test Plans]
        //#region[Test Cases]
        //public static string TC_109687 = "TC_109687";

        //public static string TC_119819 = "TC_119819";
        //#endregion[Test Cases]

        #region Browsers

        public static string FireFox = "Mozilla";
        public static string Chrome = "Chrome";
        public static string IE = "IE";

        #endregion Browsers

        #region ObjectRepository UI Module Names
        public static string ModuleCommon = "Common";
        //public static string ModuleCommon = "Common";
        //public static string Admin = "Admin";
        //public static string SignIn = "SignIn";
        //public static string TopNavigation = "TopNavigation";
        //public static string Footer = "Footer";
        //public static string SignUp = "SignUp";
        //public static string SideNavigation = "SideNavigation";
        //public static string MySettings = "MySettings";
        public static string Navigation = "Navigation";
        public static string SignIn = "SignIn";
        public static string CreateCampaign = "CreateCampaign";
        public static string ManageCampaign = "ManageCampaign";
        public static string CreateTemplate = "CreateTemplate";
        public static string CreateAudience = "CreateAudience";
        public static string ManageTemplate = "ManageTemplate";
        public static string Configuration_App = "Configuration_App";
        public static string Marketing_Automation_App = "Configuration_App";
        public static string Starling_App = "Starling_App";
        public static string Unified_Profile_App = "Unified_Profie_App";
        public static string Email = "Email";
        //public static string ForgotPassword = "ForgotPassword";
        //public static string Kiosk = "Kiosk";
        //public static string MyStays = "MyStays";
        //public static string Admin_Navigations = "Admin_Navigations";
        //public static string Admin_MemberTransaction = "Admin_MemberTransaction";
        //public static string MyAccount_Summary = "MyAccount_Summary";
        //public static string ContactUs = "ContactUs";
        public static string Home = "Home";
        public static string CreateUser = "CreateUser";
        public static string Profiles = "Profiles";
        public static string Reservations = "Reservations";
        #endregion ObjectRepository UI Module Names

        #region[CommonData]
        public static string CommonEmail_Demo = "chc_demo@cendyn.com";
        public static string CommonPassword = "Cendyn123$";
        public static string CommonPassword_Demo = "@Sc@A6Ffs#mrY#eX";
        public static string CatchAllEmail = "catchall@cendyn17.com";
        public static string CatchAllPassword = "Cendyn1234$";
        #endregion[CommonData]
    }
}
