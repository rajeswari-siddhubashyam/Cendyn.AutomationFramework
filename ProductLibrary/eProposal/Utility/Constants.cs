using BaseUtility.Utility;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace eProposal.Utility
{
    public class Constants : Common.Constants
    {
        //Project
        public static string ProjectName = "ePFull";

        public static string TestProjectName = "ePFull_Test";

        //Project Text Values
        public static string OldHiltonHonors = "Hilton HHonors";

        public static string NewHiltonHonors = "Honors";
        public static string COMPOSE = "COMPOSE";
        public static string ROOMBLOCK = "ROOM BLOCK";
        public static string EVENTBLOCK = "EVENT";
        public static string SELECT = "SELECT";
        public static string ReviewAndSend = "REVIEW & SEND";
        public static string UserOption1 = "Email";
        public static string UserOption2 = "Equals";

        //This string contains 400 characters. Every 50 characters there is a counter.
        public static string LongString = "THISISTHELONGESTCHAREVER!THISISTHELONGESTCHAREVE50THISISTHELONGESTCHAREVER!THISISTHELONGESTCHAREV100THISISTHELONGESTCHAREVER!THISISTHELONGESTCHAREV150THISISTHELONGESTCHAREVER!THISISTHELONGESTCHAREV200THISISTHELONGESTCHAREVER!THISISTHELONGESTCHAREV250THISISTHELONGESTCHAREVER!THISISTHELONGESTCHAREV300THISISTHELONGESTCHAREVER!THISISTHELONGESTCHAREV350THISISTHELONGESTCHAREVER!THISISTHELONGESTCHAREV400";
        public static string Preview_Text = "This information is disabled in preview mode.";
        public static string Resend_Text = "Are you sure you want to resend the eProposal?";
        public static string Resend_Confirmation = "The eProposal has been resent";
        public static string ExpirationBeforeToday = " Expiration date cannot occur before today.";
        public static string ExpirationAfterEventDate = "Expiration date cannot occur after the event date.";
        public static string AdminPageTitle = " eSales Suite Administration";
        public static string PropertyType_Regular = "PropertyType_Regular";
        public static string ImproperFileValidationMessage = "Please select a valid image.";
        public static string CustomSignature = "Custom Signature:";
        public static string RemoveIcon = "Remove";
        public static string DeleteSignature = "Are you sure you want to delete this signature?";
        public static string eProposalExpirationMessage = "The expiration date cannot occur after event date";


        //Report Generation Keyword

        #region[ReportGeneration Keyword]

        public static string Keywordfail = "FAIL";

        #endregion[ReportGeneration Keyword]

        #region[Domain]

        public static string Domain_Gmail = "@gmail.com";

        #endregion

        #region[Test Plans]
        public static string TP_112907 = "TP_112907";
        public static string TP_84916 = "TP_84916";
        public static string TP_120480 = "TP_120480";
        public static string TP_89339 = "TP_89339";
        public static string TP_84293 = "TP_84293";
        public static string TP_120256 = "TP_120256";
        public static string TP_120217 = "TP_120217";
        public static string TP_120241 = "TP_120241";
        public static string TP_120245 = "TP_120245";
        public static string TP_120251 = "TP_120251";
        public static string TP_84921 = "TP_84921";
        public static string TP_84922 = "TP_84922";
        public static string TP_120205 = "TP_120205";
        public static string TP_278103 = "TP_278103";
        #endregion[Test Plans]

        #region[Test Cases]
        public static string TC_EPFULL_TEST = "TC_EPFULL_TEST";
        public static string TC_112919 = "TC_112919";
        public static string TC_120550 = "TC_120550";
        public static string TC_120549 = "TC_120549";
        public static string TC_120548 = "TC_120548";
        public static string TC_120554 = "TC_120554";
        public static string TC_120482 = "TC_120482";
        public static string TC_120483 = "TC_120483";
        public static string TC_120484 = "TC_120484";
        public static string TC_120485 = "TC_120485";
        public static string TC_120486 = "TC_120486";
        public static string TC_120487 = "TC_120487";
        public static string TC_120488 = "TC_120488";
        public static string TC_120489 = "TC_120489";
        public static string TC_120490 = "TC_120490";
        public static string TC_120491 = "TC_120491";
        public static string TC_120492 = "TC_120492";
        public static string TC_120442 = "TC_120442";
        public static string TC_120443 = "TC_120443";
        public static string TC_120446 = "TC_120446";
        public static string TC_120447 = "TC_120447";
        public static string TC_120454 = "TC_120454";
        public static string TC_123287 = "TC_123287";
        public static string TC_120257 = "TC_120257";
        public static string TC_120258 = "TC_120258";
        public static string TC_120259 = "TC_120259";
        public static string TC_120260 = "TC_120260";
        public static string TC_120261 = "TC_120261";
        public static string TC_120262 = "TC_120262";
        public static string TC_120263 = "TC_120263";
        public static string TC_120218 = "TC_120218";
        public static string TC_120219 = "TC_120219";
        public static string TC_120220 = "TC_120220";
        public static string TC_120221 = "TC_120221";
        public static string TC_120222 = "TC_120222";
        public static string TC_120223 = "TC_120223";
        public static string TC_120224 = "TC_120224";
        public static string TC_120225 = "TC_120225";
        public static string TC_120227 = "TC_120227";
        public static string TC_120228 = "TC_120228";
        public static string TC_120229 = "TC_120229";
        public static string TC_120230 = "TC_120230";
        public static string TC_120231 = "TC_120231";
        public static string TC_120232 = "TC_120232";
        public static string TC_120233 = "TC_120233";
        public static string TC_120234 = "TC_120234";
        public static string TC_120235 = "TC_120235";
        public static string TC_120236 = "TC_120236";
        public static string TC_120237 = "TC_120237";
        public static string TC_120238 = "TC_120238";
        public static string TC_120239 = "TC_120239";
        public static string TC_120242 = "TC_120242";
        public static string TC_120246 = "TC_120246";
        public static string TC_120252 = "TC_120252";
        public static string TC_61367 = "TC_61367";
        public static string TC_61368 = "TC_61368";
        public static string TC_120206 = "TC_120206";
        public static string TC_84289 = "TC_84289";
        public static string TC_84288 = "TC_84288";
        public static string TC_84287 = "TC_84287";
        public static string TC_84277 = "TC_84277";
        public static string TC_87928 = "TC_87928";
        public static string TC_89354 = "TC_89354";
        public static string TC_90245 = "TC_90245";
        public static string TC_90246 = "TC_90246";
        public static string TC_84274 = "TC_84274";
        public static string TC_84272 = "TC_84272";
        public static string TC_84276 = "TC_84276";
        public static string TC_84275 = "TC_84275";
        public static string TC_84273 = "TC_84273";
        public static string TC_87922 = "TC_87922";
        public static string TC_87920 = "TC_87920";
        public static string TC_87921 = "TC_87921";
        public static string TC_87918 = "TC_87918";
        public static string TC_84290 = "TC_84290";
        public static string TC_84285 = "TC_84285";

        public static string TC_278105 = "TC_278105";
        public static string TC_278106 = "TC_278106";
        public static string TC_278107 = "TC_278107";
        public static string TC_278108 = "TC_278108";
        public static string TC_278109 = "TC_278109";
        public static string TC_278110 = "TC_278110";
        public static string TC_99106 = "TC_99106"; 

        #endregion[Test Cases]

        //ObjectRepository UI Module Names

        #region[ObjectRepository UI Module Names]
        public static string ModuleCommon = "Common";
        public static string EmployeeLogin = "EmployeeLogin";
        public static string EmployeeHome = "EmployeeHome";
        public static string ProposalCompose = "ProposalCompose";
        public static string ProposalCendynRoomBlock = "ProposalCendynRoomBlock";
        public static string ProposalCendynEventBlock = "ProposalCendynEventBlock";
        public static string ProposalSelect = "ProposalSelect";
        public static string ProposalView = "ProposalView";
        public static string ProposalPreview = "ProposalPreview";
        public static string ClientEmail = "ClientEmail";
        public static string Clients = "Clients";
        public static string CardCompose = "CardCompose";
        public static string eCardCompose = "eCardCompose";
        public static string eFaceTime = "eFaceTime";
        public static string Activity = "Activity";
        public static string Settings = "Settings";
        public static string Settings_StoredContent = "Settings_StoredContent";
        public static string Profile = "Profile";
        public static string CardSkin = "CardSkin";
        public static string Reports = "Reports";
        public static string CardAttachmentAndLink = "CardAttachmentAndLink";
        public static string CardReviewAndSend = "CardReviewAndSend";
        public static string AdminECard_Skins = "AdminECard_Skins";
        #endregion[ObjectRepository UI Module Names]

        //ObjectRepository Admin Module Names

        #region[ObjectRepository Admin Module Names]

        public static string AdminLogin = "AdminLogin";
        public static string AdminNavigation = "AdminNavigation";
        public static string AdminClients = "AdminClients";
        public static string AdminClients_Search = "AdminClients_Search";
        public static string AdminProperties = "AdminProperties";
        public static string AdmineCard = "AdmineCard";
        public static string AdminProperties_UpdateProperty_Features = "AdminProperties_UpdateProperty_Features";
        public static string AdminProperties_AddNewLanguage = "AdminProperties_AddNewLanguage";
        public static string AdminUsers = "AdminUsers";
        public static string AdminProperties_UpdateProperty_RoomBlock = "AdminProperties_UpdateProperty_RoomBlock";
        public static string AdminProperties_UpdateProperty_Actions = "AdminProperties_UpdateProperty_Actions";
        public static string AdminEProposal = "AdminEProposal";
        public static string AdminEProposal_SetupModuleSettings = "AdminEProposal_SetupModuleSettings";
        public static string AdminECard_FooterLinks = "AdminECard_FooterLinks";

        #endregion[ObjectRepository Admin Module Names]

        //Report Generation Keyword

        #region[Browsers]

        public static string FireFox = "Mozilla";
        public static string Chrome = "Chrome";
        public static string IE = "IE";

        #endregion[Browsers]

        //Folder Locations

        #region[Folder Locations]

        public static string RootPath = Helper.GetProjectPath();

        public static string PathRooth = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);

        public static string TestResultsXML = String.Concat(RootPath, ConfigurationManager.AppSettings["TestResultsXML"]);

        public static string ScreenshotPath = string.Concat(RootPath, ConfigurationManager.AppSettings["ScreenshotPath"]);

        public static string ReportScreenshotPath = string.Concat(RootPath, ConfigurationManager.AppSettings["ReportScreenshotPath"]);

        public static string ReportPath = string.Concat(RootPath, ConfigurationManager.AppSettings["ReportPath"]);

        public static string ObjectRepofile = string.Concat(PathRooth, ConfigurationManager.AppSettings["ObjectRepofile"]);

        public static string LogFilePath = string.Concat(RootPath, ConfigurationManager.AppSettings["LoggerFile"]);

        public static string ChromeDriver = string.Concat(RootPath, Convert.ToString(ConfigurationManager.AppSettings["ChromeDriver"]));

        public static string IeDriver = string.Concat(RootPath, Convert.ToString(ConfigurationManager.AppSettings["IEDriver"]));

        public static string UploadFiles = string.Concat(RootPath, Convert.ToString(ConfigurationManager.AppSettings["UploadFiles"]));

        public static string UploadVideo = string.Concat(RootPath, Convert.ToString(ConfigurationManager.AppSettings["UploadVideo"]));

        public static string ImageUpload = string.Concat(RootPath, ConfigurationManager.AppSettings["ImageUpload"]);
        public static string LogoUpload = string.Concat(RootPath, ConfigurationManager.AppSettings["LogoUpload"]);

        public static string CustomSignatureUpload = string.Concat(RootPath, ConfigurationManager.AppSettings["CustomSignatureUpload"]);

        public static string UploadpngFiles = string.Concat(RootPath, ConfigurationManager.AppSettings["UploadpngFiles"]);

        public static string UploadgifFiles = string.Concat(RootPath, ConfigurationManager.AppSettings["UploadgifFiles"]);

        #endregion[Folder Locations]
    }
}
