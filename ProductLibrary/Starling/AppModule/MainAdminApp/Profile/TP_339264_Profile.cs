using CHC.AppModule.UI;
using CHC.Entity;
using CHC.Utility;
using BaseUtility.Utility;
using Queries = CHC.Utility.Queries;
using System.Collections.Generic;
using InfoMessageLogger;
using TestData;
using OpenQA.Selenium;
using System.Threading;
using CHC.PageObject.UI;

namespace CHC.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region[TP_339264]
        public static void TC_339266()
        {
            if (TestCaseId == Constants.TC_339266)
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

        public static void TC_339267()
        {
            if (TestCaseId == Constants.TC_339267)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();

                //Step2 - Verify all accessing applications to admin user in Home page
                Logger.WriteDebugMessage("User lands on CHC Home page & verify the Applications");
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

                //Step5 - Enter email in Search filter & click on Search icon
                Profile_DB ProfileTable = new Profile_DB();
                Logger.WriteDebugMessage("User getting the emailid from DB");
                CHC.Utility.Queries.GetEmail(ProfileTable);               

                Profiles.Enter_txt_on_Filter_by_Email(ProfileTable.CMData);
                //Logger.WriteDebugMessage("User entered the emailid on Search by email text box");
                Profiles.VerifyFilterforemailfield(ProfileTable.CMData);

                Profiles.ClickonProfilerecord();
                Logger.WriteDebugMessage("User clicked on Profile id URl on table");
                Helper.WaitForAjaxControls(30);
               
                Home.ClickUserLogout();
                Helper.WaitForAjaxControls(30);

                SignIn.VerifySignout();
                Logger.WriteDebugMessage("User should Navigates to CHC Signin page");
            }
        }

        public static void TC_339268()
        {
            if (TestCaseId == Constants.TC_339268)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Helper.WaitForAjaxControls(30);

                //Step2 - Verify all accessing applications to admin user in Home page
                Logger.WriteDebugMessage("User lands on CHC Home page");
                Home.VerifyApplications();
                Helper.WaitForAjaxControls(30);

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

                //Step5 - Verify the Filter button
                Profiles.ClickonFilterbutton();
                Logger.WriteDebugMessage("User should view the Filter Popup");

                Profiles.VerifyApply_ClearPopuponfilter();

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
                Logger.WriteDebugMessage("User should Navigates to CHC Signin page");
            }
        }

        public static void TC_339269()
        {
            if (TestCaseId == Constants.TC_339269)
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

                //Step5 - Verify the Sort button
                Profiles.ClickonSortbutton();
                Logger.WriteDebugMessage("User should view the Sort Popup & Clear and Apply buttons");

                Profiles.VerifyApply_ClearPopuponSort();

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
                Logger.WriteDebugMessage("User should Navigates to CHC Signin page");
            }
        }

        public static void TC_339271()
        {
            if (TestCaseId == Constants.TC_339271)
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

                Profiles.ClickonApplauncher();
                Logger.WriteDebugMessage("User Should view the Applications on App launcher");
                
                Profiles.VerifyApplicationsonapplauncher();

                Driver.Navigate().Back();

                //Click on Logout
                Home.ClickUserLogout();                

                SignIn.VerifySignout();
                Logger.WriteDebugMessage("User should Navigates to CHC Signin page");
            }
        }

        public static void TC_339272()
        {
            if (TestCaseId == Constants.TC_339272)
            {

                Helper.WaitForAjaxControls(30);
                SignIn.EnterEmailAddress_Test(Constants.FrontEndEmail_Test);
                SignIn.EnterPassword_Test(Constants.CommonPassword_Test);
                SignIn.ClickOnSignInButton();
                Helper.WaitForAjaxControls(50);
                Logger.WriteDebugMessage("User lands on CHC Home page");

                ////Click on Logout
                Home.ClickUserLogout();                

                SignIn.VerifySignout();
                Logger.WriteDebugMessage("User should Navigates to CHC Signin page");
            }
        }

        public static void TC_341590()
        {
            if (TestCaseId == Constants.TC_341590)
            {
                Helper.WaitForAjaxControls(30);
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Helper.WaitForAjaxControls(50);
                Logger.WriteDebugMessage("User lands on CHC Home page");

                Home.VerifyApplications();
                
                Home.ClickOnStarlingApp();
                Logger.WriteDebugMessage("User should view the Org selector");

                Home.VerifyPopup();                

                Home.ClickOnChooseOnPopup();
                Logger.WriteDebugMessage("User should view the list of Orgs");

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                //Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                //Step5 - Verify the Filter button

                Reservation_DB reservation = new Reservation_DB();
                CHC.Utility.Queries.GetReservation(reservation);

                Profiles.ClickonFilterbutton();
                Logger.WriteDebugMessage("User should view the Filter Popup");

                Profiles.Enter_txt_on_ProfileidfieldFilter_Contains(reservation.ExternalResID1.ToString());
                Profiles.Verifyprofileid(reservation.ExternalResID1.ToString());

                string prodileId = Profiles.ClickonProfilerecordonprofilestable();
                Profiles.VerifyViewprofileName(prodileId);
                Logger.WriteDebugMessage("Profileid matches");

                Home.ClickUserLogout();

                SignIn.VerifySignout();
                Logger.WriteDebugMessage("User should Navigates to CHC Signin page");
            }
        }

        public static void TC_341591()
        {
            if (TestCaseId == Constants.TC_341591)
            {
                Helper.WaitForAjaxControls(30);
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Helper.WaitForAjaxControls(50);
                Logger.WriteDebugMessage("User lands on CHC Home page");

                Home.VerifyApplications();

                Home.ClickOnStarlingApp();
                Logger.WriteDebugMessage("User should view the Org selector");

                Home.VerifyPopup();

                Home.ClickOnChooseOnPopup();
                Logger.WriteDebugMessage("User should view the list of Orgs");

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                //Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Profiles.ClickonFilterbutton();               

                Reservation_DB reservation  = new Reservation_DB();
                CHC.Utility.Queries.GetReservation(reservation);

                Profiles.Enter_txt_on_ProfileidfieldFilter_Contains(reservation.ExternalResID1.ToString());
                Profiles.Verifyprofileid(reservation.ExternalResID1.ToString());               

                Profiles.ClickonProfilerecord();
                Logger.WriteDebugMessage("User should Navigates to View Profile page");

                Profiles.VerifyViewprofileName(reservation.ExternalResID1.ToString());
              
                Profiles.Clickonreservationstab();
                Logger.WriteDebugMessage("User should Navigates to Profile related Reservations page");

                Home.ClickUserLogout();

                SignIn.VerifySignout();
                Logger.WriteDebugMessage("User should Navigates to CHC Signin page");
            }
        }

        public static void TC_341592()
        {
            if (TestCaseId == Constants.TC_341592)
            {
                Helper.WaitForAjaxControls(30);
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Helper.WaitForAjaxControls(50);
                Logger.WriteDebugMessage("User lands on CHC Home page");

                Home.VerifyApplications();                

                Home.ClickOnStarlingApp();
                Logger.WriteDebugMessage("User should view the Org selector");

                Home.VerifyPopup();

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

                Profiles.ClickonFilterbutton();
                Helper.WaitForAjaxControls(20);

                Reservation_DB reservation = new Reservation_DB();
                CHC.Utility.Queries.GetReservation(reservation);
                    
                Profiles.Enter_txt_on_ProfileidfieldFilter_Contains(reservation.ExternalResID1.ToString());                
                Profiles.Verifyprofileid(reservation.ExternalResID1.ToString());                            

                Profiles.ClickonProfilerecord();
                Logger.WriteDebugMessage("User navigates to View Profile page");

                Profiles.VerifyViewprofileName(reservation.ExternalResID1.ToString());                
                Helper.WaitForAjaxControls(20);

                Profiles.Clickonreservationstab();
                Logger.WriteDebugMessage("User should navigates to Reservations index page");
                Helper.WaitForAjaxControls(20);

                Profiles.Verifytestpresentonreservations();
                Helper.WaitForAjaxControls(20);

                string Reservationid = Profiles.Clickonreservationrecordontable();
                Helper.WaitForAjaxControls(20);

                Profiles.VerifyViewreservationid(Reservationid);
                Logger.WriteDebugMessage("User should navigates to View Reservation page");

                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        #endregion[TP_339264]

        #region[TP_344217]

        public static void TC_344018()
        {
            if (TestCaseId == Constants.TC_344018)
            {                
                    //Step1 - Navigate to CHC and log in as a valid Admin user
                    SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                    SignIn.EnterPassword(Constants.CommonPassword);
                    SignIn.ClickOnSignInButton();
                    Logger.WriteDebugMessage("User lands on CHC Home page");
                    //Step2 - Verify all accessing applications to admin user in Home page
                    Home.VerifyApplications();

                    //Step3 - Click on Starling App
                    Home.ClickOnStarlingApp();

                    //Step4 - Verify the Org selector popup
                    Logger.WriteDebugMessage("User should view the Org selector");
                    Home.VerifyPopup();

                    //Click on Choose button
                    Home.ClickOnChooseOnPopup();

                    //Step5  Verify the Accounts listed & Select the Org
                    Home.VerifyAccounts();
                    Home.ClickExpandIcons();
                    string accountName = "Kirigami Hotels (Chain)";
                    Home.Click_Accounts(accountName);
                    Home.VerifyAccountPage(accountName);
                    Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                    Logger.WriteDebugMessage("User is landed on Starling application");

                Reservation_DB reservation = new Reservation_DB();
                    CHC.Utility.Queries.GetReservation(reservation);

                    Profiles.ClickonFilterbutton();

                    Profiles.Enter_txt_on_ProfileidfieldFilter_Contains(reservation.ExternalResID1.ToString());
                    Profiles.Verifyprofileid(reservation.ExternalResID1.ToString());

                    Profiles.ClickonProfilerecord();

                    Profile_DB profile = new Profile_DB();
                    CHC.Utility.Queries.GetPersonalDetails(profile, reservation.ExternalResID1.ToString());
                    Profiles.VerifyDBValuesInProfilePage_PersonalDetails(profile);

                    //Click on Logout
                    Home.ClickUserLogout();

                    SignIn.VerifySignout();
                }
            }

        public static void TC_344019()
        {
            if (TestCaseId == Constants.TC_344019)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();
                
                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
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

                Reservation_DB reservation = new Reservation_DB();
                CHC.Utility.Queries.GetReservation(reservation);

                Profiles.ClickonFilterbutton();

                Profiles.Enter_txt_on_ProfileidfieldFilter_Contains(reservation.ExternalResID1.ToString());
                Profiles.Verifyprofileid(reservation.ExternalResID1.ToString());

                Profiles.ClickonProfilerecord();

                Profile_DB profile = new Profile_DB();
                CHC.Utility.Queries.GetAddressDetails(profile, reservation.ExternalResID1.ToString());
                Profiles.VerifyDBValuesInProfilePage_AddressDetails(profile);

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        public static void TC_344020()
        {
            if (TestCaseId == Constants.TC_344020)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();
                Logger.WriteDebugMessage("User should view the list of Org's");

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();

                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);

                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Reservation_DB reservation = new Reservation_DB();
                CHC.Utility.Queries.GetReservation(reservation);

                Profiles.ClickonFilterbutton();

                Profiles.Enter_txt_on_ProfileidfieldFilter_Contains(reservation.ExternalResID1.ToString());
                Profiles.Verifyprofileid(reservation.ExternalResID1.ToString());

                Profiles.ClickonProfilerecord();

                Profile_DB profile = new Profile_DB();
                CHC.Utility.Queries.GetProfiles(profile, reservation.ExternalResID1.ToString());
                Profiles.VerifyDBValuesInProfilePage(profile);

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        public static void TC_344024()
        {
            if (TestCaseId == Constants.TC_344024)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();
                Logger.WriteDebugMessage("User should view the list of Org's");

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();

                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);

                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Reservation_DB reservation = new Reservation_DB();
                CHC.Utility.Queries.GetReservation(reservation);

                Profiles.ClickonFilterbutton();

                Profiles.Enter_txt_on_ProfileidfieldFilter_Contains(reservation.ExternalResID1.ToString());
                Profiles.Verifyprofileid(reservation.ExternalResID1.ToString());

                Profiles.ClickonProfilerecord();

                Profile_DB profile = new Profile_DB();
                CHC.Utility.Queries.GetProfiles(profile, reservation.ExternalResID1.ToString());
                Profiles.VerifyDBValuesInProfilePage(profile);

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        public static void TC_343794()
        {
            if (TestCaseId == Constants.TC_343794)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();
                Logger.WriteDebugMessage("User should view the list of Org's");

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();

                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);

                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Reservation_DB reservation = new Reservation_DB();
                CHC.Utility.Queries.GetReservation(reservation);

                Profiles.ClickonFilterbutton();

                Profiles.Enter_txt_on_ProfileidfieldFilter_Contains(reservation.ExternalResID1.ToString());
                Profiles.Verifyprofileid(reservation.ExternalResID1.ToString());

                Profiles.ClickonProfilerecord();

                Profile_DB profile = new Profile_DB();
                CHC.Utility.Queries.GetProfiles(profile, reservation.ExternalResID1.ToString());
                Profiles.VerifyDBValuesInProfilePage(profile);

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        #endregion[TP_344217]

        #region[TP_345743]

        public static void TC_345744()
        {
            if (TestCaseId == Constants.TC_345744)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Reservation_DB reservation = new Reservation_DB();
                CHC.Utility.Queries.GetReservation(reservation);

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Profile id","Starts With","2");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Profile id", "Ends With", "6");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Profile id", "Contains", "509");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Profile id", "Equal", "250908126");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Profile id", "Not Equal", "250908126");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());                

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        public static void TC_345746()
        {
            if (TestCaseId == Constants.TC_345746)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Name", "Starts With", "s");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Name", "Ends With", "n");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Name", "Contains", "ky");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Name", "Equal", "Sky Osborn");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Name", "Not Equal", "Sky Osborn");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        public static void TC_345747()
        {
            if (TestCaseId == Constants.TC_345747)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Email", "Starts With", "k");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Email", "Ends With", "m");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Email", "Contains", "l4@");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Email", "Equal", "krol4@cendyn17.com");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Email", "Not Equal", "krol4@cendyn17.com");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        public static void TC_345748()
        {
            if (TestCaseId == Constants.TC_345748)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Country", "Starts With", "U");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());                

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Country", "Equal", "US");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());
                

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        public static void TC_345749()
        {
            if (TestCaseId == Constants.TC_345749)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Date", "Greater Than", "Feb 08, 2022");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Date", "Less Than", "Feb 08, 2022");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Date", "Less Than or Equal", "Feb 08, 2022");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Date", "Equal", "Feb 08, 2022");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Date", "Not Equal", "Feb 08, 2022");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Date", "Greater Than or Equal", "Feb 08, 2022");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        public static void TC_348626()
        {
            if (TestCaseId == Constants.TC_348626)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Source", "Is", "PMS");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        public static void TC_348628()
        {
            if (TestCaseId == Constants.TC_348628)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Profile Id", "Equal", "250908126");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Name", "Equal", "Sky Osborn");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Email", "Equal", "krol4@cendyn17.com");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Country", "Equal", "US");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Date", "Equal", "Feb 08, 2022");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Source", "Equal", "PMS");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        #endregion[TP_345743]

        #region[TP_345770]

        public static void TC_345772()
        {
            if (TestCaseId == Constants.TC_345772)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Reservation_DB reservation = new Reservation_DB();
                CHC.Utility.Queries.GetReservation(reservation);

                Profiles.ClickonFilterbutton();

                Profiles.Enter_txt_on_ProfileidfieldFilter_Contains(reservation.ExternalResID1.ToString());
                Profiles.Verifyprofileid(reservation.ExternalResID1.ToString());

                Profiles.ClickonProfilerecord();

                Profiles.View_ContactDetails();

                Profile_DB profile = new Profile_DB();
                CHC.Utility.Queries.GetCMData(profile);
                Profiles.VerifyDBValuesInContactDetailsPage(profile);

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        #endregion[TP_345770]

        #region[TP_348876]       

        public static void TC_311423()
        {
            if (TestCaseId == Constants.TC_311423)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Profiles.Clickon_OrgSwitcher();

                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName1 = "Kirigami Hotels (Chain)";
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Home.Click_Accounts(accountName1);

                Profiles.Clickon_OrgSwitcher();

                Home.VerifyAccountPage(accountName1);                

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        public static void TC_348878()
        {
            if (TestCaseId == Constants.TC_348878)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Profiles.ClickonSortbutton();

                Profiles.Enter_SortValues("Order By", "Profile Id");
                Profiles.Enter_SortValues("Direction", "A - Z");
                Profiles.Clickon_ApplyonSort();

                Profiles.Enter_SortValues("Order By", "Profile Id");
                Profiles.Enter_SortValues("Direction", "Z - A");
                Profiles.Clickon_ApplyonSort();

                Profiles.Enter_SortValues("Order By", "Name");
                Profiles.Enter_SortValues("Direction", "A - Z");
                Profiles.Clickon_ApplyonSort();

                Profiles.Enter_SortValues("Order By", "Name");
                Profiles.Enter_SortValues("Direction", "Z - A");
                Profiles.Clickon_ApplyonSort();

                Profiles.Enter_SortValues("Order By", "Email");
                Profiles.Enter_SortValues("Direction", "A - Z");
                Profiles.Clickon_ApplyonSort();

                Profiles.Enter_SortValues("Order By", "Email");
                Profiles.Enter_SortValues("Direction", "Z -A");
                Profiles.Clickon_ApplyonSort();

                Profiles.Enter_SortValues("Order By", "Country");
                Profiles.Enter_SortValues("Direction", "A - Z");
                Profiles.Clickon_ApplyonSort();

                Profiles.Enter_SortValues("Order By", "Country");
                Profiles.Enter_SortValues("Direction", "Z - A");
                Profiles.Clickon_ApplyonSort();

                Profiles.Enter_SortValues("Order By", "Date");
                Profiles.Enter_SortValues("Direction", "Old - New");
                Profiles.Clickon_ApplyonSort();

                Profiles.Enter_SortValues("Order By", "Date");
                Profiles.Enter_SortValues("Direction", "New - Old");
                Profiles.Clickon_ApplyonSort();

                Profiles.Enter_SortValues("Order By", "Source");
                Profiles.Enter_SortValues("Direction", "A - Z");
                Profiles.Clickon_ApplyonSort();

                Profiles.Enter_SortValues("Order By", "Source");
                Profiles.Enter_SortValues("Direction", "Z - A");
                Profiles.Clickon_ApplyonSort();

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        public static void TC_348879()
        {
            if (TestCaseId == Constants.TC_348879)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Reservation_DB reservation = new Reservation_DB();
                CHC.Utility.Queries.GetReservation(reservation);

                Profiles.ClickonFilterbutton();
                Logger.WriteDebugMessage("User should view the Filter Popup");

                Profiles.Enter_txt_on_ProfileidfieldFilter_Contains(reservation.ExternalResID1.ToString());                            

                Profiles.Clickonreservationstab();

                Profiles.ClickonSortbutton();

                Profiles.Enter_SortValues("Order By", "Property Id");
                Profiles.Enter_SortValues("Direction", "Least - Most");
                Profiles.Clickon_ApplyonSort();

                Profiles.Enter_SortValues("Order By", "Property Id");
                Profiles.Enter_SortValues("Direction", "Most - Least");
                Profiles.Clickon_ApplyonSort();

                Profiles.Enter_SortValues("Order By", "Reservation Id");
                Profiles.Enter_SortValues("Direction", "A - Z");
                Profiles.Clickon_ApplyonSort();

                Profiles.Enter_SortValues("Order By", "Reservation Id");
                Profiles.Enter_SortValues("Direction", "Z - A");
                Profiles.Clickon_ApplyonSort();

                Profiles.Enter_SortValues("Order By", "Check In");
                Profiles.Enter_SortValues("Direction", "Old - New");
                Profiles.Clickon_ApplyonSort();

                Profiles.Enter_SortValues("Order By", "Check In");
                Profiles.Enter_SortValues("Direction", "New - Old");
                Profiles.Clickon_ApplyonSort();

                Profiles.Enter_SortValues("Order By", "Check Out");
                Profiles.Enter_SortValues("Direction", "New - Old");
                Profiles.Clickon_ApplyonSort();

                Profiles.Enter_SortValues("Order By", "Check Out");
                Profiles.Enter_SortValues("Direction", "New - Old");
                Profiles.Clickon_ApplyonSort();                

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        public static void TC_348880()
        {
            if (TestCaseId == Constants.TC_348880)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Profiles.Clickon_Homebutton();

                Home.VerifyAccounts();

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        public static void TC_348881()
        {
            if (TestCaseId == Constants.TC_348881)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Profiles.Clickon_HelpLink();

                Profiles.VerifyHelpPage();

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        public static void TC_348882()
        {
            if (TestCaseId == Constants.TC_348882)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Reservation_DB reservation = new Reservation_DB();
                CHC.Utility.Queries.GetReservation(reservation);

                Reservations.Enter_txt_on_Filter_ReservationID_On_searchbox(reservation);

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        public static void TC_348885()
        {
            if (TestCaseId == Constants.TC_348885)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Reservation_DB reservation = new Reservation_DB();
                CHC.Utility.Queries.GetReservation(reservation);

                Profiles.ClickonFilterbutton();

                Profiles.Enter_txt_on_ProfileidfieldFilter_Contains(reservation.ExternalResID1.ToString());
                Profiles.Verifyprofileid(reservation.ExternalResID1.ToString());

                Profiles.ClickonProfilerecord();

                Profiles.Clickonreservationstab();

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Property Id","Equal", "142");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        public static void TC_348886()
        {
            if (TestCaseId == Constants.TC_348886)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Reservation_DB reservation = new Reservation_DB();
                CHC.Utility.Queries.GetReservation(reservation);

                Profiles.ClickonFilterbutton();

                Profiles.Enter_txt_on_ProfileidfieldFilter_Contains(reservation.ExternalResID1.ToString());
                Profiles.Verifyprofileid(reservation.ExternalResID1.ToString());

                Profiles.ClickonProfilerecord();

                Profiles.Clickonreservationstab();

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Property Name", "Starts With", "o");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Property Name", "Ends With", "F");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Property Name", "Contains", "oo");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Property Name", "Equal", "Foo");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Property Name", "Not Equal", "Foo");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        public static void TC_348887()
        {
            if (TestCaseId == Constants.TC_348887)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Reservation_DB reservation = new Reservation_DB();
                CHC.Utility.Queries.GetReservation(reservation);

                Profiles.ClickonFilterbutton();

                Profiles.Enter_txt_on_ProfileidfieldFilter_Contains(reservation.ExternalResID1.ToString());
                Profiles.Verifyprofileid(reservation.ExternalResID1.ToString());

                Profiles.ClickonProfilerecord();

                Profiles.Clickonreservationstab();

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Reservation Id", "Starts With", "G");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Reservation Id", "Ends With", "5");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Reservation Id", "Contains", "B00");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Reservation Id", "Equal", "GB0005");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Reservation Id", "Not Equal", "GB0005");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        public static void TC_348888()
        {
            if (TestCaseId == Constants.TC_348888)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Reservation_DB reservation = new Reservation_DB();
                CHC.Utility.Queries.GetReservation(reservation);

                Profiles.ClickonFilterbutton();

                Profiles.Enter_txt_on_ProfileidfieldFilter_Contains(reservation.ExternalResID1.ToString());
                Profiles.Verifyprofileid(reservation.ExternalResID1.ToString());

                Profiles.ClickonProfilerecord();

                Profiles.Clickonreservationstab();

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Status", "Is", "Reserved");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        public static void TC_348889()
        {
            if (TestCaseId == Constants.TC_348889)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Reservation_DB reservation = new Reservation_DB();
                CHC.Utility.Queries.GetReservation(reservation);

                Profiles.ClickonFilterbutton();

                Profiles.Enter_txt_on_ProfileidfieldFilter_Contains(reservation.ExternalResID1.ToString());
                Profiles.Verifyprofileid(reservation.ExternalResID1.ToString());

                Profiles.ClickonProfilerecord();

                Profiles.Clickonreservationstab();

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Check In", "Equal", "Feb 01, 2022");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Check In", "Less Than or Equal", "Feb 01, 2022");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Check In", "Greater Than or Equal", "Feb 01, 2022");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Check In", "Greater Than", "Feb 01, 2022");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Check In", "Not Equal", "Feb 01, 2022");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Check In", "Less Than", "Feb 01, 2022");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        public static void TC_348890()
        {
            if (TestCaseId == Constants.TC_348890)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Reservation_DB reservation = new Reservation_DB();
                CHC.Utility.Queries.GetReservation(reservation);

                Profiles.ClickonFilterbutton();

                Profiles.Enter_txt_on_ProfileidfieldFilter_Contains(reservation.ExternalResID1.ToString());
                Profiles.Verifyprofileid(reservation.ExternalResID1.ToString());

                Profiles.ClickonProfilerecord();

                Profiles.Clickonreservationstab();

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Check Out", "Equal", "Feb 02, 2022");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Check Out", "Less Than or Equal", "Feb 02, 2022");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Check Out", "Greater Than or Equal", "Feb 02, 2022");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Check Out", "Greater Than", "Feb 02, 2022");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Check Out", "Not Equal", "Feb 02, 2022");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                Profiles.ClickonFilterbutton();
                Profiles.Enter_FilterValues("Check Out", "Less Than", "Feb 02, 2022");
                Profiles.ElementClick(PageObject_Profiles.VerifyApplybuttononfilter());

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        #endregion[TP_348876]

        #region[TP_352298]

        public static void TC_314420()
        {
            if (TestCaseId == Constants.TC_314420)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Reservation_DB reservation = new Reservation_DB();
                CHC.Utility.Queries.GetReservation(reservation);

                Profiles.ClickonFilterbutton();

                Profiles.Enter_txt_on_ProfileidfieldFilter_Contains(reservation.ExternalResID1.ToString());
                Profiles.Verifyprofileid(reservation.ExternalResID1.ToString());

                Profiles.ClickonProfilerecord();

                Profiles.Clickonreservationstab();

                Profiles.Clickonreservationrecordontable();

                Profile_DB profile = new Profile_DB();
                CHC.Utility.Queries.GetMainResDetails(profile, reservation);
                CHC.Utility.Queries.GetMainResDetails_Room(profile, reservation);
                Profiles.VerifyDBValuesInReservationsPage_MainResDetails(reservation);
                Profiles.VerifyDBValuesInReservationsPage_MainResDetails_Room(reservation);

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        public static void TC_314421()
        {
            if (TestCaseId == Constants.TC_314421)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Reservation_DB reservation = new Reservation_DB();
                CHC.Utility.Queries.GetReservation(reservation);

                Profiles.ClickonFilterbutton();

                Profiles.Enter_txt_on_ProfileidfieldFilter_Contains(reservation.ExternalResID1.ToString());
                Profiles.Verifyprofileid(reservation.ExternalResID1.ToString());

                Profiles.ClickonProfilerecord();

                Profiles.Clickonreservationstab();

                Profiles.Clickonreservationrecordontable();

                Profile_DB profile = new Profile_DB();
                CHC.Utility.Queries.GetMainResDetails(profile, reservation);
                Profiles.VerifyDBValuesInReservationsPage_MainResDetails(reservation);
                Profiles.VerifyDBValuesInReservationsPage_MainResDetails_Room(reservation);

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        public static void TC_314422()
        {
            if (TestCaseId == Constants.TC_314422)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Reservation_DB reservation = new Reservation_DB();
                CHC.Utility.Queries.GetReservation(reservation);

                Profiles.ClickonFilterbutton();

                Profiles.Enter_txt_on_ProfileidfieldFilter_Contains(reservation.ExternalResID1.ToString());                

                Profiles.ClickonProfilerecord();

                Profiles.Clickonreservationstab();

                Profiles.Clickonreservationrecordontable();

                Profile_DB profile = new Profile_DB();
                CHC.Utility.Queries.GetStayDetails(profile, reservation);
                Profiles.VerifyDBValuesInReservationsPage_StayDetails(reservation);                

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        public static void TC_314423()
        {
            if (TestCaseId == Constants.TC_314423)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Reservation_DB reservation = new Reservation_DB();
                CHC.Utility.Queries.GetReservation(reservation);

                Profiles.ClickonFilterbutton();

                Profiles.Enter_txt_on_ProfileidfieldFilter_Contains(reservation.ExternalResID1.ToString());

                Profiles.ClickonProfilerecord();

                Profiles.Clickonreservationstab();

                Profiles.Clickonreservationrecordontable();

                Profile_DB profile = new Profile_DB();
                CHC.Utility.Queries.GetMainResDetails(profile, reservation);
                Profiles.VerifyDBValuesInReservationsPage_StayDetails(reservation);

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        public static void TC_314424()
        {
            if (TestCaseId == Constants.TC_314424)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Reservation_DB reservation = new Reservation_DB();
                CHC.Utility.Queries.GetReservation(reservation);

                Profiles.ClickonFilterbutton();

                Profiles.Enter_txt_on_ProfileidfieldFilter_Contains(reservation.ExternalResID1.ToString());

                Profiles.ClickonProfilerecord();

                Profiles.Clickonreservationstab();

                Profiles.Clickonreservationrecordontable();

                Profile_DB profile = new Profile_DB();
                CHC.Utility.Queries.GetMainResDetails(profile, reservation);
                Profiles.VerifyDBValuesInReservationsPage_StayDetails(reservation);

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        public static void TC_314425()
        {
            if (TestCaseId == Constants.TC_314425)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Reservation_DB reservation = new Reservation_DB();
                CHC.Utility.Queries.GetReservation(reservation);

                Profiles.ClickonFilterbutton();

                Profiles.Enter_txt_on_ProfileidfieldFilter_Contains(reservation.ExternalResID1.ToString());

                Profiles.ClickonProfilerecord();

                Profiles.Clickonreservationstab();

                Profiles.Clickonreservationrecordontable();

                Profile_DB profile = new Profile_DB();
                CHC.Utility.Queries.GetRevenueDetails(profile, reservation);
                Profiles.VerifyDBValuesInReservationsPage_RevenueDetails(reservation);

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        public static void TC_314426()
        {
            if (TestCaseId == Constants.TC_314426)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Reservation_DB reservation = new Reservation_DB();
                CHC.Utility.Queries.GetReservation(reservation);

                Profiles.ClickonFilterbutton();

                Profiles.Enter_txt_on_ProfileidfieldFilter_Contains(reservation.ExternalResID1.ToString());

                Profiles.ClickonProfilerecord();

                Profiles.Clickonreservationstab();

                Profiles.Clickonreservationrecordontable();

                Profile_DB profile = new Profile_DB();
                CHC.Utility.Queries.GetPoliciesDetails(profile, reservation);
                Profiles.VerifyDBValuesInReservationsPage_PoliciesDetails(reservation);

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        public static void TC_314427()
        {
            if (TestCaseId == Constants.TC_314427)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                Logger.WriteDebugMessage("User lands on CHC Home page");
                //Step2 - Verify all accessing applications to admin user in Home page
                Home.VerifyApplications();

                //Step3 - Click on Starling App
                Home.ClickOnStarlingApp();

                //Step4 - Verify the Org selector popup
                Logger.WriteDebugMessage("User should view the Org selector");
                Home.VerifyPopup();

                //Click on Choose button
                Home.ClickOnChooseOnPopup();

                //Step5  Verify the Accounts listed & Select the Org
                Home.VerifyAccounts();
                Home.ClickExpandIcons();
                string accountName = "Kirigami Hotels (Chain)";
                Home.Click_Accounts(accountName);
                Home.VerifyAccountPage(accountName);
                Logger.WriteDebugMessage("User Selected the Kirigami Hotels (Chain) Organization");
                Logger.WriteDebugMessage("User is landed on Starling application");

                Reservation_DB reservation = new Reservation_DB();
                CHC.Utility.Queries.GetReservation(reservation);

                Profiles.ClickonFilterbutton();

                Profiles.Enter_txt_on_ProfileidfieldFilter_Contains(reservation.ExternalResID1.ToString());

                Profiles.ClickonProfilerecord();

                Profiles.Clickonreservationstab();

                Profiles.Clickonreservationrecordontable();

                Profile_DB profile = new Profile_DB();
                CHC.Utility.Queries.GetAssociatedProfileDetails(profile, reservation);
                Profiles.VerifyDBValuesInReservationsPage_AssociatedProfileDetails(reservation);

                //Click on Logout
                Home.ClickUserLogout();

                SignIn.VerifySignout();
            }
        }

        #endregion[TP_352298]
    }
}