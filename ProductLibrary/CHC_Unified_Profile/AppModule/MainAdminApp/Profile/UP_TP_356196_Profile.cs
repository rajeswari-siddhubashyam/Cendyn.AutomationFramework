using CHC_Unified_Profile.AppModule.UI;
using CHC_Unified_Profile.Entity;
using CHC_Unified_Profile.Utility;
using BaseUtility.Utility;
using Queries = CHC_Unified_Profile.Utility.Queries;
using System.Collections.Generic;
using InfoMessageLogger;
using TestData;

using OpenQA.Selenium;
using System.Threading;
using CHC_Unified_Profile.PageObject.UI;
using BaseUtility.Utility.Hotmail;

namespace CHC_Unified_Profile.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region[TP_356196]

        public static void TC_340276()
        {
            if (TestCaseId == Constants.TC_340276)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();

                //Step2 - Verify all accessing applications to the user in Home page
                Logger.WriteDebugMessage("User lands on CHC Home page");
                Home.VerifyApplications();

                //Step3 - Click on Unified Porfile App
                Navigation.Click_Starling_App();
                Logger.WriteDebugMessage("User should view the Org selector");

                //Step4 - Verify the Org selector popup
                //Home.VerifyPopup();

                //////Click on Choose button
                //Home.ClickOnChooseOnPopup();
                //Logger.WriteDebugMessage("User should view the list of Orgs");

                ////Step5  Verify the Accounts listed & Select the Org
                //Home.VerifyAccounts();
                //Home.ClickExpandIcons();
                //string accountName = "Kirigami Hotels (Chain)";
                //Home.Click_Accounts(accountName);
                //Home.VerifyAccountPage(accountName);
                //Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Unified Porfile index page");

                //Click on Logout                
                Home.ClickUserLogout();

                SignIn.VerifySignout();
                Logger.WriteDebugMessage("User should Navigates to CHC Signin page");
            }
        }

        public static void TC_340278()
        {
            if (TestCaseId == Constants.TC_340278)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();

                //Step2 - Verify all accessing applications to the user in Home page
                Logger.WriteDebugMessage("User lands on CHC Home page");
                Home.VerifyApplications();

                //Step3 - Click on Unified Porfile App
                Navigation.Click_Starling_App();
                Logger.WriteDebugMessage("User should view the Org selector");

                //Step4 - Verify the Org selector popup
                //Home.VerifyPopup();

                ////Click on Choose button
                //Home.ClickOnChooseOnPopup();
                //Logger.WriteDebugMessage("User should view the list of Orgs");

                ////Step5  Verify the Accounts listed & Select the Org
                ////Home.VerifyAccounts();
                ////Home.ClickExpandIcons();
                //string accountName = "Kirigami Hotels (Chain)";
                //Home.Click_Accounts(accountName);
                ////Home.VerifyAccountPage(accountName);
                //Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Unified Porfile index page");

                Profile.ClickonProfilerecord();

                Profile.VerifytestpresentonViewProfile();

                //Click on Logout                
                Home.ClickUserLogout();

                SignIn.VerifySignout();
                Logger.WriteDebugMessage("User should Navigates to CHC Signin page");
            }
        }

        public static void TC_340284()
        {
            if (TestCaseId == Constants.TC_340284)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();

                //Step2 - Verify all accessing applications to admin user in Home page
                Logger.WriteDebugMessage("User lands on CHC Home page");
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();
                Logger.WriteDebugMessage("User should view the Org selector");

                //Step4 - Verify the Org selector popup
                //Home.VerifyPopup();

                ////Click on Choose button
                //Home.ClickOnChooseOnPopup();
                //Logger.WriteDebugMessage("User should view the list of Orgs");

                ////Step5  Verify the Accounts listed & Select the Org
                //Home.VerifyAccounts();
                //Home.ClickExpandIcons();
                //string accountName = "Kirigami Hotels (Chain)";
                //Home.Click_Accounts(accountName);
                //Home.VerifyAccountPage(accountName);
                //Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Profile.ClickonFilterbutton();

                Profile_DB profile = new Profile_DB();
                Queries.GetProfile(profile);

                //Profile.Enter_FilterValues("Profile Id", "Equal", "1375");
                Profile.Enter_txt_on_ProfileidfieldFilter_Contains(profile.ProfileId.ToString());

                Profile.Clickon_Apply_Button_on_Filter();

                Profile.ClickonProfilerecord();

                Queries.GetProfile_Main(profile);
                Profile.VerifyDBValuesInUnifiedProfile_MainSection(profile);
                Queries.GetProfiles_Phone(profile);
                Profile.VerifyDBValuesInUnifiedProfile_MainSection_Phone(profile);

                //Click on Logout                
                Home.ClickUserLogout();

                SignIn.VerifySignout();
                Logger.WriteDebugMessage("User should Navigates to CHC Signin page");
            }
        }

        public static void TC_340283()
        {
            if (TestCaseId == Constants.TC_340283)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();

                //Step2 - Verify all accessing applications to admin user in Home page
                Logger.WriteDebugMessage("User lands on CHC Home page");
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();
                Logger.WriteDebugMessage("User should view the Org selector");

                //Step4 - Verify the Org selector popup
                //Home.VerifyPopup();

                ////Click on Choose button
                //Home.ClickOnChooseOnPopup();
                //Logger.WriteDebugMessage("User should view the list of Orgs");

                ////Step5  Verify the Accounts listed & Select the Org
                //Home.VerifyAccounts();
                //Home.ClickExpandIcons();
                //string accountName = "Kirigami Hotels (Chain)";
                //Home.Click_Accounts(accountName);
                //Home.VerifyAccountPage(accountName);
                //Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Profile.ClickonFilterbutton();

                Profile_DB profile = new Profile_DB();
                Queries.GetProfile(profile);

                //Profile.Enter_FilterValues("Profile Id", "Equal", "1375");
                Profile.Enter_txt_on_ProfileidfieldFilter_Contains(profile.ProfileId.ToString());

                Profile.Clickon_Apply_Button_on_Filter();

                Profile.ClickonProfilerecord();

                //Profile.ClickOn_ViewProfile_ContactDetailsTab();

                Queries.GetProfiles_PersonalDetails(profile);
                Profile.VerifyDBValuesInUnifiedProfile_PersonalDetailsSection(profile);

                //Click on Logout                
                Home.ClickUserLogout();

                SignIn.VerifySignout();
                Logger.WriteDebugMessage("User should Navigates to CHC Signin page");
            }
        }

        public static void TC_340280()
        {
            if (TestCaseId == Constants.TC_340280)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();

                //Step2 - Verify all accessing applications to admin user in Home page
                Logger.WriteDebugMessage("User lands on CHC Home page");
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();
                Logger.WriteDebugMessage("User should view the Org selector");

                //Step4 - Verify the Org selector popup
                //Home.VerifyPopup();

                ////Click on Choose button
                //Home.ClickOnChooseOnPopup();
                //Logger.WriteDebugMessage("User should view the list of Orgs");

                ////Step5  Verify the Accounts listed & Select the Org
                //Home.VerifyAccounts();
                //Home.ClickExpandIcons();
                //string accountName = "Kirigami Hotels (Chain)";
                //Home.Click_Accounts(accountName);
                //Home.VerifyAccountPage(accountName);
                //Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");
               
                Profile.ClickonFilterbutton();

                Profile_DB profile = new Profile_DB();
                Queries.GetProfile(profile);

                //Profile.Enter_FilterValues("Profile Id", "Equal", "1375");
                Profile.Enter_txt_on_ProfileidfieldFilter_Contains(profile.ProfileId.ToString());

                Profile.Clickon_Apply_Button_on_Filter();

                Profile.ClickonProfilerecord();

                Profile.ClickOn_ViewProfile_ContactDetailsTab();

                //Profile_DB profile = new Profile_DB();
                Queries.ViewContactDetails_Email(profile);
                Profile.VerifyDBValuesInUnifiedProfile_ContactDetails_EmailSection(profile);

                //Click on Logout                
                Home.ClickUserLogout();

                SignIn.VerifySignout();
                Logger.WriteDebugMessage("User should Navigates to CHC Signin page");
            }
        }

        public static void TC_340291()
        {
            if (TestCaseId == Constants.TC_340291)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();

                //Step2 - Verify all accessing applications to admin user in Home page
                Logger.WriteDebugMessage("User lands on CHC Home page");
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();
                Logger.WriteDebugMessage("User should view the Org selector");

                //Step4 - Verify the Org selector popup
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();
                Logger.WriteDebugMessage("User should view the list of Orgs");

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                //Click on Logout                
                Home.ClickUserLogout();

                SignIn.VerifySignout();
                Logger.WriteDebugMessage("User should Navigates to CHC Signin page");
            }
        }

        public static void TC_340281()
        {
            if (TestCaseId == Constants.TC_340281)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();

                //Step2 - Verify all accessing applications to admin user in Home page
                Logger.WriteDebugMessage("User lands on CHC Home page");
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();
                Logger.WriteDebugMessage("User should view the Org selector");

                ////Step4 - Verify the Org selector popup
                //Home.VerifyPopup();

                ////Click on Choose button
                //Home.ClickOnChooseOnPopup();
                //Logger.WriteDebugMessage("User should view the list of Orgs");

                ////Step5  Verify the Accounts listed & Select the Org
                //Home.VerifyAccounts();
                //Home.ClickExpandIcons();
                //string accountName = "Kirigami Hotels (Chain)";
                //Home.Click_Accounts(accountName);
                //Home.VerifyAccountPage(accountName);
                //Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Profile.ClickonFilterbutton();

                Profile_DB profile = new Profile_DB();
                Queries.GetProfile(profile);

                //Profile.Enter_FilterValues("Profile Id", "Equal", "1375");
                Profile.Enter_txt_on_ProfileidfieldFilter_Contains(profile.ProfileId.ToString());

                Profile.Clickon_Apply_Button_on_Filter();

                Profile.ClickonProfilerecord();

                Profile.Clickonreservationstab();

                //Click on Logout                
                Home.ClickUserLogout();

                SignIn.VerifySignout();
                Logger.WriteDebugMessage("User should Navigates to CHC Signin page");
            }
        }

        #endregion[TP_356196]

        #region[TP_356194]        

        public static void TC_326178()
        {
            if (TestCaseId == Constants.TC_326178)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();

                //Step2 - Verify all accessing applications to the user in Home page
                Logger.WriteDebugMessage("User lands on CHC Home page");
                Home.VerifyApplications();

                //Step3 - Click on Unified Porfile App
                Navigation.Click_Starling_App();
                Logger.WriteDebugMessage("User should view the Org selector");

                //Verify the Org selector popup
                //Home.VerifyPopup();

                //////Click on Choose button
                //Home.ClickOnChooseOnPopup();
                //Logger.WriteDebugMessage("User should view the list of Orgs");

                ////Verify the Accounts listed & Select the Org
                ////Home.VerifyAccounts();
                ////Home.ClickExpandIcons();
                //string accountName = "Kirigami Hotels (Chain)";
                //Home.Click_Accounts(accountName);
                ////Home.VerifyAccountPage(accountName);
                //Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Unified Porfile application");

                ////Step - Verify List of profiles with DB values
                //List<Profile_DB> profilelist = new List<Profile_DB>();
                //Queries.GetListfrom_Profiletable(profilelist);
                //Profile.VerifyTableData(profilelist);

                Profile_DB profile = new Profile_DB();
                Queries.GetProfile(profile);

                Profile.ClickonFilterbutton();
                Profile.Enter_txt_on_ProfileidfieldFilter_Contains(profile.ProfileId.ToString());
                Profile.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                //Profile.ClickonProfilerecordSecondonprofiletable();
                Profile.ClickonProfilerecordonprofilestable();

                //string prodileId = Profile.ClickonProfilerecordonprofilestable();
                Profile.ValitionMessage("View Profile: Mabel Catherson");

                Profile.ClickOn_ViewProfile_ContactDetailsTab();

                Queries.ViewContactDetails_Email(profile);
                Profile.VerifyDBValuesInUnifiedProfile_ContactDetails_EmailSection(profile);

                Queries.ViewContactDetails_Phone(profile);
                Profile.VerifyDBValuesInUnifiedProfile_ContactDetails_PhoneSection(profile);

                //Queries.ViewContactDetails_Fax(profile);
                //Profile.VerifyDBValuesInUnifiedProfile_ContactDetails_FaxSection(profile);

                Queries.ViewContactDetails_Address(profile);
                Profile.VerifyDBValuesInUnifiedProfile_ContactDetails_AddressSection(profile);

                //Click on Logout                
                Home.ClickUserLogout();

                SignIn.VerifySignout();
                Logger.WriteDebugMessage("User should Navigates to CHC Signin page");
            }
        }

        #endregion[TP_356194]

        #region[TP_358861]
        public static void TC_312067()
        {
            if (TestCaseId == Constants.TC_312067)
            {
                Profile.ClickonNeedhelp();

                Profile.ClickonForgot();

                string email = "testlogin3@cendyn17.com";
                Profile.EnterRecovery_Email(email);

                Profile.Clickon_ResetviaEmail();

                Profile.Clickon_BacktoSignin();

                //Step1 - Navigate to CHC and log in as a valid Admin user
                Hotmail.LogIntoCatchAllAndOpenFirstMessageByEmail("noreply@okta.com", "https://outlook.office365.com/");

                Profile.Enter_ResetPassword();
                ControlToNewWindow();
                Profile.Enter_NewPassword("Cendyn123$");

                Profile.Enter_ConfirmationPassword("Cendyn123$");

                Profile.Clickon_ResetPasswordbutton();

                ////Click on Logout                
                //Home.ClickUserLogout();

                //SignIn.VerifySignout();
                //Logger.WriteDebugMessage("User should Navigates to CHC Signin page");
            }
        }

        public static void TC_312069()
        {
            if (TestCaseId == Constants.TC_312069)
            {
                //Step1 - 
                SignIn.EnterEmailAddress(Constants.FrontEndEmail_Unlock);
                SignIn.EnterPassword(Constants.CommonPassword_Unlock);
                SignIn.ClickOnSignInButton();

                SignIn.EnterPassword(Constants.CommonPassword_Unlock);
                SignIn.ClickOnSignInButton();

                SignIn.EnterPassword(Constants.CommonPassword_Unlock);
                SignIn.ClickOnSignInButton();

                SignIn.EnterPassword(Constants.CommonPassword_Unlock);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("After 4 unsuccessful attempts, it redirects to unlock account workflow");

                string email = "testlogin@cendyn17.com";
                Profile.Enter_Unlock_Username(email);
                Logger.WriteDebugMessage("User entered unlock email " + email + " ");

                Profile.Clickon_Unlock_SendEmail();
                Logger.WriteDebugMessage("User clicked on Send email button ");

                //Step2
                Hotmail.LogIntoCatchAllAndOpenFirstMessageByEmail("noreply@test-account.dev", "https://outlook.office365.com/");
                Logger.WriteDebugMessage("User navigates to Outlook and varify unlocked email");

                //Step3
                Profile.Clickon_Outlook_Unlock_Account();
                Logger.WriteDebugMessage("User clicked on Unlock_Account link");

                ControlToNewWindow();
                Logger.WriteDebugMessage("User navigates to new window ");

                Profile.ValitionMessage("Account successfully unlocked!");
                Logger.WriteDebugMessage("User successfully unlocked the email");

                //Step4
                string email1 = "@@@@testlogin@cendyn17.com";
                Profile.Enter_Unlock_Username(email1);
                Logger.WriteDebugMessage("User entered invalid email " + email1 + " ");
                Profile.Clickon_ResetviaEmail();
                Logger.WriteDebugMessage("User clicked on Send Email button ");

                //Step5
                Profile.Clickon_ResetviaEmail();
                Logger.WriteDebugMessage("User cliecked on Send Email button without entered email");

                //Step6
                Hotmail.LogIntoCatchAllAndOpenFirstMessageByEmail("noreply@okta.com", "https://outlook.office365.com/");
                Profile.Clickon_Outlook_Unlock_Account();
                Logger.WriteDebugMessage("User navigates to Outlook and clicked on Unloack_Account link");

                //Step7
                Profile.Clickon_BacktoSignin();

                //SignIn.VerifySignout();
                //Logger.WriteDebugMessage("User should Navigates to CHC Signin page");
            }
        }

        public static void TC_312070()
        {
            if (TestCaseId == Constants.TC_312070)
            {
                Profile.ClickonNeedhelp();

                //Step1
                Profile.Clickon_SignIn_Unlock_Account();

                //Step2
                string email = "testlogin3@cendyn17.com";
                Profile.EnterRecovery_Email(email);

                Profile.Clickon_ResetviaEmail();

                //Profile.Clickon_BacktoSignin();

                //Step1 - Navigate to CHC and log in as a valid Admin user
                Hotmail.LogIntoCatchAllAndOpenFirstMessageByEmail("noreply@test-account.dev", "https://outlook.office365.com/");

                Hotmail.SearchEmailBySubject("your account is not locked");

                //Step3
                string email1 = "@testlogin3@cendyn17.com";
                Profile.EnterRecovery_Email(email1);

                Profile.Clickon_ResetviaEmail();

                Profile.Clickon_BacktoSignin();

                Profile.ClickonNeedhelp();

                Profile.Clickon_SignIn_Unlock_Account();

                //Step4
                Profile.Clickon_ResetviaEmail();

                Profile.Verify_EmailBlank_Validation("This field cannot be left blank");

                //Step5
                Profile.Clickon_BacktoSignin();

                Profile.Verify_SigiIN_Text("Sign In");

                ////Click on Logout                
                //Home.ClickUserLogout();

                SignIn.VerifySignout();
                //Logger.WriteDebugMessage("User should Navigates to CHC Signin page");
            }
        }

        #endregion[TP_358861]

        #region[TP_369438]

        public static void TC_332462()
        {
            if (TestCaseId == Constants.TC_332462)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();

                //Step2 - Verify all accessing applications to the user in Home page
                Logger.WriteDebugMessage("User lands on CHC Home page");
                Home.VerifyApplications();

                //Step3 - Click on Unified Porfile App
                Navigation.Click_Starling_App();
                Logger.WriteDebugMessage("User should view the Org selector");

                ////Step4 - Verify the Org selector popup
                //Home.VerifyPopup();

                //////Click on Choose button
                //Home.ClickOnChooseOnPopup();
                //Logger.WriteDebugMessage("User should view the list of Orgs");

                ////Step5  Verify the Accounts listed & Select the Org
                ////Home.VerifyAccounts();
                ////Home.ClickExpandIcons();
                //string accountName = "Kirigami Hotels (Chain)";
                //Home.Click_Accounts(accountName);
                //Home.VerifyAccountPage(accountName);
                //Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling index page");

                Profile_DB profile = new Profile_DB();
                Queries.Get_Profile1(profile);

                //Step5 - Search a profile in filter
                Profile.ClickonFilterbutton();
                Profile.Enter_txt_on_ProfileidfieldFilter_Contains(profile.ProfileId.ToString());
                Profile.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                //Step6 - User clicked on profile in a table                
                Profile.ClickonProfilerecordonprofilestable();

                //Step7 - User clicked on Reservation tab in View profile page
                Profile.Clickonreservationstab();

                //Step8 - Verify List of profiles with DB values
                List<Profile_DB> profilelist = new List<Profile_DB>();
                //Queries.GetListfrom_Profiletable(profilelist);
                //Profile.VerifyTableData(profilelist);

                Queries.GetListfrom_Reservationtable(profilelist);
                Profile.Verify_Res_TableData(profilelist);

                Profile.Verify_TableHeaders();
                
                //Step12 - User clicked on ellipsis on the table row & click on ellipsis
                Profile.Click_OnEllipse_OnRes_table();

                Queries.Get_Reservation_Popover_Details(profile);
                Profile.VerifyDBValuesInUnifiedProfile_Ellipse(profile);

                //Click on Logout                
                Home.ClickUserLogout();

                SignIn.VerifySignout();
                Logger.WriteDebugMessage("User should Navigates to CHC Signin page");
            }
        }

        #endregion[TP_369438]
    }
}


