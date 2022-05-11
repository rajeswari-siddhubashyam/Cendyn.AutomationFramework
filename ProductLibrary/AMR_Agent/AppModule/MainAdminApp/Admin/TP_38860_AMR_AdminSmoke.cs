using System;
using AMR.AppModule.Admin.Home.ManageProfiles.EditProfile;
using AMR_Agent.AppModule.Admin;
using AMR_Agent.AppModule.UI;
using AMR_Agent.PageObject.UI;
using AMR_Agent.Utility;
using eLoyaltyV3.AppModule.UI;
using InfoMessageLogger;
using NUnit.Framework;

namespace AMR_Agent.AppModule.MainAdminApp
{
    public partial class MainAdminApp : AMR_Agent.Utility.Setup
    {
        public static void TC_37501()
        {
            if (TestCaseId == Constants.TC_37501)
            {

                string SearchUser, Password, Firstname, Lastname;
                SearchUser = TestData.ExcelData.TestDataReader.ReadData(1, "SearchUser");
                Password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                Firstname = TestData.ExcelData.TestDataReader.ReadData(1, "Firstname");
                Lastname = TestData.ExcelData.TestDataReader.ReadData(1, "Lastname");

                //1.Navigate to url https://adminportal.amragents.com/ ​​
                //2.Login using Prod - eInsight credential

                AddDelay(2500);
                ValidAdminLogin();
                Logger.WriteDebugMessage("user should be logged in the application  and navigate to Admin dashboard ");

                //3.Click on Manage Profile > validated
                AdminManageHome.ClickManageProfile();
                AddDelay(5000);
                AdminManageProfile.ClickValidateProfile();
                Logger.WriteDebugMessage("user able to click on Manage Profile and navigate to Manage Profile Page ");

                //4. Enter Test  in Search  and click on Search icon                
                //4.1 Click on Edit profile link in Actions Column on Profile manage page                 
                AdminManageProfile.EnterSearch(SearchUser);
                AddDelay(1500);
                AdminManageProfile.ClickEditProfile();
                AddDelay(1500);
                Logger.WriteDebugMessage("User able to search the profile and able to click on edit button ");

                //5.Update the agent name 
                string firstname = Firstname + "Edit";
                AdminEditProfile.EnterFirstname(firstname);
                AddDelay(2500);
                string lastname = Lastname + "Edit";
                AdminEditProfile.EnterLastname(lastname);
                Logger.WriteDebugMessage("Agent name should be updated ");

                //6.Click on Update profile under Edit profile page 
                AdminEditProfile.ClickUpdate();
                Logger.WriteDebugMessage("User able  to click on update button and User landed on Validated Profile tab ​");
                VerifyTextOnPage(Constants.ProfileUpdateConfirmation);
                AdminEditProfile.ClickOkButton();

                //7.Login to Loyalty portal https://amrewards.amragents.com/ and login as agent updated in step 4 and Password as Amr$1234
                OpenNewTab();
                Driver.Navigate().GoToUrl(Constants.Common_FrontendURL);
                AddDelay(8000);
                HandleUnSafeWindows();
                ParameterizedLogin(SearchUser, Password);
                AddDelay(1500);
                Logger.WriteDebugMessage("user able to log in in loyalty application ");

                //8.Click on AMRewards link
                AMRAgentNav.ClickAMRAgentsAMRewards();
                Logger.WriteDebugMessage(" Updated name should display below the image");
                var alert = PageObject_AMRewards.AMRRewardsEnrollMeCheckbox().Displayed;
                if (alert.Equals(true))
                {
                    AMRRewards.AcceptPopup();
                    PageObject_AMRAgentsNav.AMRAgentsMyRedemptions().Click();
                }

                //Make sure the W9 warning popup is displayed.
                if (IsElementDisplayed(PageObject_UpdateProfile.UpdateProfileW9WarningPopupButton()))
                {
                    if (PageObject_UpdateProfile.UpdateProfileW9WarningPopupText().Text ==
                        Constants.UpdateProfileW9Warning)
                    {
                        HighlightElement(PageObject_UpdateProfile.UpdateProfileW9WarningPopupText());
                        Logger.WriteDebugMessage("The W9 warning message displayed properly!");
                    }
                }

                //9.Click on Update profile link
                AMRAgentNav.ClickAMRAgentsUpdateProfile();
                VerifyTextOnPage(firstname);
                VerifyTextOnPage(lastname);
                Logger.WriteDebugMessage("Updated name should display  First and Last Name field ​​");

            }
        }
        public static void TC_37502()
        {
            if (TestCaseId == Constants.TC_37502)
            {
                string SearchUser, Password, NewPassword;
                SearchUser = TestData.ExcelData.TestDataReader.ReadData(1, "SearchUser");
                Password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                NewPassword = TestData.ExcelData.TestDataReader.ReadData(1, "NewPassword");

                AddDelay(2500);
                ValidAdminLogin();
                Logger.WriteDebugMessage("user should be logged in the application  and navigate to Admin dashboard ");

                //2.Click on Manage Profile > validated
                AdminManageHome.ClickManageProfile();
                AddDelay(5000);
                AdminManageProfile.ClickValidateProfile();
                Logger.WriteDebugMessage("user able to click on Manage Profile and navigate to Manage Profile Page ");

                //3.Enter Test  in Search  and click on Search icon
                AdminManageProfile.EnterSearch(SearchUser);
                AddDelay(1500);
                AdminManageProfile.ClickIconResetPassword();
                AddDelay(1500);
                Logger.WriteDebugMessage("User able to click on Password reset link and reset password confirmation  pop up should be alerted");

                //4.Click OK Reset on Password confirmation pop up 
                string password = NewPassword + "$";
                AdminManageProfile.EnterNewPassword(password);
                Logger.WriteDebugMessage("User able to add the password in Enter password text box");
                AdminManageProfile.ClickResetConfirmationButton();
                Logger.WriteDebugMessage("Reset Password confirmation button should be clickable and Password reset confirmation message should be display .");

                //5.Login to Loyalty portal https://amrewards.amragents.com/ and login as agent updated in step 4 and Password as Amr$1234
                OpenNewTab();
                Driver.Navigate().GoToUrl(Constants.Common_FrontendURL);
                AddDelay(8000);
                HandleUnSafeWindows();
                ParameterizedLogin(SearchUser, password);
                AddDelay(1500);
                Logger.WriteDebugMessage("user able to log in in loyalty application ");

                //6&7. Password reset confirmation should be sent to Webmail.Cendyn.com ​​
                OpenNewTab();
                Email.LogIntoCatchAll();
                Logger.WriteDebugMessage("User should be Logged in Catchall Account");
                Email.CatchAll_SearchEmailAndOpenLatestMessage(SearchUser);
                Logger.WriteDebugMessage("Password reset email displaying");

                ////4. Enter Test  in Search  and click on Search icon                
                ////4.1 Click on Edit profile link in Actions Column on Profile manage page                 
                //AdminManageProfile.EnterSearch(SearchUser);
                //AddDelay(1500);
                //AdminManageProfile.ClickEditProfile();
                //AddDelay(1500);
                //Logger.WriteDebugMessage("User able to search the profile and able to reset the password ");

                ////5.Update the agent name 
                //string firstname = MakeUnique(Firstname);
                //AdminEditProfile.EnterFirstname(firstname);
                //AddDelay(2500);
                //string lastname = MakeUnique(Lastname);
                //AdminEditProfile.EnterLastname(lastname);
                //Logger.WriteDebugMessage("Agent name should be updated ");

                ////6.Click on Update profile under Edit profile page 
                //AdminEditProfile.ClickUpdate();
                //Logger.WriteDebugMessage("User able  to click on update button and User landed on Validated Profile tab ​");
                //VerifyTextOnPage(Constants.ProfileUpdateConfirmation);
                //AdminEditProfile.ClickOkButton();

                ////7.Login to Loyalty portal https://amrewards.amragents.com/ and login as agent updated in step 4 and Password as Amr$1234
                //OpenNewTab();
                //Driver.Navigate().GoToUrl(TestData.Common_FrontendURL);
                //AddDelay(8000);
                //HandleUnSafeWindows();
                //ParameterizedLogin(SearchUser, Password);
                //AddDelay(1500);
                //Logger.WriteDebugMessage("user able to log in in loyalty application ");

                ////8.Click on AMRewards link

                //Logger.WriteDebugMessage(" Updated name should display below the image");
                //var alert = PageObject_AMRewards.AMRRewardsEnrollMeCheckbox().Displayed;
                //if (alert.Equals(true))
                //{
                //    AMRRewards.AcceptPopup();
                //    PageObject_AMRAgentsNav.AMRAgentsMyRedemptions().Click();
                //}
                //AMRAgentNav.ClickAMRAgentsAMRewards();
                ////Make sure the W9 warning popup is displayed.
                //if (IsElementDisplayed(PageObject_UpdateProfile.UpdateProfileW9WarningPopupButton()))
                //{
                //    if (PageObject_UpdateProfile.UpdateProfileW9WarningPopupText().Text ==
                //        Constants.UpdateProfileW9Warning)
                //    {
                //        HighlightElement(PageObject_UpdateProfile.UpdateProfileW9WarningPopupText());
                //        Logger.WriteDebugMessage("The W9 warning message displayed properly!");
                //    }
                //}

                ////9.Click on Update profile link
                //AMRAgentNav.ClickAMRAgentsUpdateProfile();
                //VerifyTextOnPage(firstname);
                //VerifyTextOnPage(lastname);
                //Logger.WriteDebugMessage("Updated name should display  First and Last Name field ​​");

            }
        }
        public static void TC_37504()
        {
            if (TestCaseId == Constants.TC_37504)
            {
                string SearchUser, Password, NewPassword;
                SearchUser = TestData.ExcelData.TestDataReader.ReadData(1, "SearchUser");
                Password = TestData.ExcelData.TestDataReader.ReadData(1, "Password");
                NewPassword = TestData.ExcelData.TestDataReader.ReadData(1, "NewPassword");

                //1.Navigate to url https://adminportal.amragents.com/ ​​
                //2.Login using Prod - eInsight credential              
                AddDelay(2500);
                ValidAdminLogin();
                Logger.WriteDebugMessage("user should be logged in the application  and navigate to Admin dashboard");

                //3.Click on Manage Profile 
                AdminManageHome.ClickManageProfile();
                AddDelay(5000);
                AdminManageProfile.ClickValidateProfile();
                Logger.WriteDebugMessage("user able to click on Manage Profile and navigate to Manage Profile Page ");

                //4.Click on star icon or Password reset link in Actions Column on Profile manage page 
                AdminManageProfile.EnterSearch(SearchUser);
                AddDelay(1500);
                AdminManageProfile.ClickIconResetPassword();
                AddDelay(1500);
                Logger.WriteDebugMessage("User able to click on Password reset link and reset password confirmation  pop up should be alerted");

                //5.Enter the new password in Enter password text box
                string password = NewPassword + "$";
                AdminManageProfile.EnterNewPassword(password);
                Logger.WriteDebugMessage("User able to add the password in Enter password text box");

                //6.Click on Reset Password confirmation button 
                AdminManageProfile.ClickResetConfirmationButton();
                Logger.WriteDebugMessage("Reset Password confirmation button should be clicable and Password reset confirmation message should be display .");

                //7.Password reset confirmation should be sent to Webmail.Cendyn.com ​
                Logger.WriteDebugMessage("Password reset confirmation mail should be sent to Webmail.Cendyn.com ​");

                //8.Login to Loyalty portal https://amrewards.amragents.com/ and login as agent with new passowrd
                Driver.Navigate().GoToUrl(Constants.Common_FrontendURL);
                AddDelay(2500);
                HandleUnSafeWindows();
                ParameterizedLogin(SearchUser, password);
                Logger.WriteDebugMessage("User should able to successfully log in with new password");
            }
        }
        public static void TC_37509()
        {
            if (TestCaseId == Constants.TC_37509)
            {
                string SearchUser;
                SearchUser = TestData.ExcelData.TestDataReader.ReadData(1, "SearchUser");
                //1.Navigate to url https://adminportal.amragents.com/ ​​
                //2.Login using Prod - eInsight credential              
                AddDelay(2500);
                HandleUnSafeWindows();
                ValidAdminLogin();
                Logger.WriteDebugMessage("user should be logged in the application  and navigate to Admin dashboard");

                //3.Click on Manage Booking > under review 
                AdminManageHome.ClickManageBookings();
                AddDelay(5000);
                AdminManageBookings.ClickPendingValidationTab();
                Logger.WriteDebugMessage("user able to click on Manage Booking and navigate to Manage Booking Page on under review tab");

                //4.Identify Test booking  by filtering  the Booking# start with Prod ​
                AdminManageBookings.EnterSearch(SearchUser);
                AddDelay(5000);
                string bookingnumber = AdminManageBookings.GetBookingNumber();
                Logger.WriteDebugMessage("user should be successfully filtered");

                //5.Click on delete icon link 
                AdminManageBookings.ClickPendingValidationDeleteIcon();
                Logger.WriteDebugMessage("Deletion confirmation popup display");

                //6. Click  Ok in confirmation popup
                AdminManageBookings.ClickPendingValidationButtonDelete();
                Logger.WriteDebugMessage("Booking should be successfully deleted ");

                //7.Search for Deleted Booking in Under Review tab ​
                AdminManageBookings.EnterSearch(bookingnumber);
                AddDelay(5000);
                Logger.WriteDebugMessage("The delete Booking Number should no display in Under Review tab    ​");
            }
        }
        public static void TC_37514()
        {
            if (TestCaseId == Constants.TC_37514)
            {
                string SearchUser;
                SearchUser = TestData.ExcelData.TestDataReader.ReadData(1, "SearchUser");

                //1.Navigate to url https://adminportal.amragents.com/ ​​
                //2.Login using Prod - eInsight credential              
                AddDelay(2500);
                ValidAdminLogin();
                Logger.WriteDebugMessage("user should be logged in the application  and navigate to Admin dashboard");

                //3.Click on Manage Profile 
                AdminManageHome.ClickManageProfile();
                AddDelay(5000);
                AdminManageProfile.ClickValidateProfile();
                Logger.WriteDebugMessage("user able to click on Manage Profile and navigate to Manage Profile Page");

                //4.Click on Inactivated profile icon  in Actions Column on Validated Profile page 
                AdminManageProfile.EnterSearch(SearchUser);
                AddDelay(5000);
                AdminManageProfile.ClickIconInActivateProfile();
                AddDelay(1500);
                VerifyTextOnPage(Constants.InActiveProfileConfirmation(SearchUser));
                Logger.WriteDebugMessage("user should be successfully filtered");

                //5.Click on Close button on Inactivated profile confirmation 
                AdminManageProfile.ClickResetCloseButton();
                Logger.WriteDebugMessage("Pop up should be disappear after click on Close button and profile should be removed from the list and moved to inactivated profile list ");
            }
        }
        public static void TC_37515()
        {
            if (TestCaseId == Constants.TC_37515)
            {
                string SearchUser;
                SearchUser = TestData.ExcelData.TestDataReader.ReadData(1, "SearchUser");
                //1.Navigate to url https://adminportal.amragents.com/ ​​
                //2.Login using Prod - eInsight credential              
                AddDelay(2500);
                ValidAdminLogin();
                Logger.WriteDebugMessage("user should be logged in the application  and navigate to Admin dashboard");

                //3.Click on Manage Profile 
                AdminManageHome.ClickManageProfile();
                AddDelay(5000);
                Logger.WriteDebugMessage("user able to click on Manage Profile and navigate to Manage Profile Page");

                //4.Click on Inactivated Profiles tab 
                AdminManageProfile.ClickInActivatedProfilesTab();
                Logger.WriteDebugMessage("User able to click on inactivated profiles tab and inactivated profiles list should display ");

                //5.Click on Reactivate profile in Actions Column on Manage profile Page under inactivated profile 
                AdminManageProfile.EnterInActivatedProfileSearch(SearchUser);
                AddDelay(5000);
                Logger.WriteDebugMessage("Profile searched");
                AdminManageProfile.ClickIconReactivateProfile();
                AddDelay(1500);
                VerifyTextOnPage(Constants.ReactiveProfileConfirmation(SearchUser));
                Logger.WriteDebugMessage("User able to click on Reactivate profile link and Reactivate profile pop up should be alerted");

                //5.Click on Close button on Reactivate profile confirmation 
                AdminManageProfile.ClickResetCloseButton();
                Logger.WriteDebugMessage("PopPop up should be disappear after click on Close button and profile should be removed from the list and moved to Activated profile list ");
            }
        }
        public static void TC_37516()
        {
            if (TestCaseId == Constants.TC_37516)
            {
                string SearchUser;
                SearchUser = TestData.ExcelData.TestDataReader.ReadData(1, "SearchUser");

                //1.Navigate to url https://adminportal.amragents.com/ ​​
                //2.Login using Prod - eInsight credential              
                AddDelay(2500);
                ValidAdminLogin();
                Logger.WriteDebugMessage("user should be logged in the application  and navigate to Admin dashboard");

                //3.Click on Manage Profile 
                AdminManageHome.ClickManageProfile();
                AddDelay(5000);
                Logger.WriteDebugMessage("user able to click on Manage Profile and navigate to Manage Profile Page");

                //4.Click on Validated Profiles tab 
                AdminManageProfile.ClickValidateProfile();
                Logger.WriteDebugMessage("User able to click on Validated profiles tab and Validated profiles list should display ");

                //5.Click on view profile icon in action column  
                AdminManageProfile.EnterSearch(SearchUser);
                AddDelay(5000);
                AdminManageProfile.ClickIconValidateProfileViewProfile();
                AddDelay(3500);
                Logger.WriteDebugMessage("View/EditProfile -> View Profile tab gets  opened ");

                //6.Close the  View/Edit Profile tab
                AdminManageProfile.ClickIconViewProfileClose();
                Logger.WriteDebugMessage("User Landed on Validated tab ");

                //7.Click on Non Validated tab 
                AdminManageProfile.ClickNonValidatedProfilesTab();
                Logger.WriteDebugMessage("User able to navigate to the list screen of Non Validated tab ");

                //8.Click on Edit profile icon in validated profile 
                AdminManageProfile.EnterNonValidatedSearch(SearchUser);
                AddDelay(5000);
                AdminManageProfile.ClickIconNonValidatedProfileEditProfile();
                AddDelay(5000);
                Logger.WriteDebugMessage("View/Edit Profile -> Edit Profile tab gets  opened ");

                //9.Close the  View/Edit Profile tab
                AdminManageProfile.ClickIconViewProfileClose();
                Logger.WriteDebugMessage("User Landed on Non Validated tab ");

                //10.Click on Non Validated tab ​
                AdminManageProfile.ClickNonValidatedProfilesTab();
                Logger.WriteDebugMessage("User able to navigate to the list screen of Non Validated tab ");

                //11.Click on Point history icon in action column 
                AdminManageProfile.EnterNonValidatedSearch(SearchUser);
                AddDelay(5000);
                AdminManageProfile.ClickIconNonValidatedProfileViewProfile();
                AddDelay(3000);
                Logger.WriteDebugMessage("View Profile page open");
                AdminManageProfile.ClickNonValidatedProfileTabPointsHistory();
                AddDelay(1500);
                Logger.WriteDebugMessage("View/Edit Profile -> Point History tab gets  opened ");

                //12.Close the  View/Edit Profile tab
                AdminManageProfile.ClickIconViewProfileClose();
                Logger.WriteDebugMessage("User Landed on Inactivated Profile tab ");

            }
        }
        public static void TC_37519()
        {
            if (TestCaseId == Constants.TC_37519)
            {
                //1.Navigate to url https://adminportal.amragents.com/ ​​
                //2.Login using Prod - eInsight credential
                Driver.Navigate().GoToUrl(Constants.Common_FrontendURL);
                HandleUnSafeWindows();
                PageObject_Login.LoginRegisterNow().Click();
                string email = Registration.EmailNow();
                Registration.DefaultRegistration(email);
                ScrollToElement(PageObject_Registration.RegisterRegisterButton());
                AddDelay(15000);
                PageObject_Registration.RegisterRegisterButton().Click();
                AddDelay(8000);
                WaittillElementDisplay(PageObject_Registration.RegisterRegistrationCompleteButton());
                AddDelay(5000);
                Driver.Navigate().GoToUrl(Constants.Common_AdminURL);
                AddDelay(2500);
                ValidAdminLogin();
                Logger.WriteDebugMessage("user should be logged in the application  and navigate to Admin dashboard");

                //3.Click on Manage Profile 
                AdminManageHome.ClickManageProfile();
                AddDelay(5000);
                Logger.WriteDebugMessage("user able to click on Manage Profile and navigate to Manage Profile Page");

                //4.Click on Validated Profiles tab 
                AdminManageProfile.ClickValidateProfile();
                Logger.WriteDebugMessage("User able to click on activated profiles tab and activated profiles list should display ");

                //5.Verify that agent profile not have any Booking by clicking on Manage booking
                AdminManageHome.ClickManageBookings();
                AdminManageBookings.EnterSearch(email);
                AddDelay(5000);
                string bookingnumber = AdminManageBookings.GetBookingNumber();
                if (bookingnumber.Equals("Enter a value to search"))
                {
                    Logger.WriteDebugMessage(email + " don NOT contains any booking");
                }
                Logger.WriteDebugMessage("Navigate to manage booking for verifying the bookings associated with agent ");

                //6.Click on Delete profile in Actions Column on Manage profile Page under activated profile 
                AdminManageHome.ClickManageProfile();
                AddDelay(2500);
                AdminManageProfile.ClickValidateProfile();
                AddDelay(2500);
                AdminManageProfile.EnterSearch(email);
                AddDelay(5000);
                AdminManageProfile.ClickValidatedProfileIconDelete(email);
                AddDelay(5000);
                VerifyTextOnPage(Constants.ProfileDeleteWarning(email));
                Logger.WriteDebugMessage("User able to click on delete profile link and Delete profile confirmation pop up should be alerted ");

                //7.Click on Confirm deletion button 
                AdminManageProfile.ClickValidatedProfileButtonDeleteConfirm();
                AddDelay(5000);
                VerifyTextOnPage(Constants.ProfileDeleteConfirmation);
                Logger.WriteDebugMessage("user able to click on Confirm deletion button and should be alerted by pop up that profile is deleted and profile should be successfully deleted ");
                AddDelay(5000);
                AdminManageProfile.ClickButtonClose();
                Logger.WriteDebugMessage("Profile deleted successfully");
            }
        }
        public static void TC_42271()
        {
            if (TestCaseId == Constants.TC_42271)
            {
                string SearchUser, email;
                SearchUser = TestData.ExcelData.TestDataReader.ReadData(1, "SearchUser");
               // email = TestData.ExcelData.TestDataReader.ReadData(1, "Email");
                HandleUnSafeWindows();
                //1.Login to Adminportal                
                AddDelay(2500);
                ValidAdminLogin();
                Logger.WriteDebugMessage("user should be logged in the application  and navigate to Admin dashboard");

                //2.Navigate to Manage Redemption followed by the selection of AMRewards Received
                AdminManageHome.ClickManageRedemptions();
                AddDelay(5000);
                Logger.WriteDebugMessage("User should be able to access Manage Redemption");

                //3.click on edit icon for Romantic Continental Breakfast in Bed or Romantic Dinner or Spa Treatment - $100 Value rewards
                AdminManageRedemptions.ClickAMRRewardsReceivedTab();
                AddDelay(5000);
                AdminManageRedemptions.Enter_AMRRewardsReceived_Search(SearchUser);
                AddDelay(5000);
                AdminManageRedemptions.ClickAMRRewardsReceivedIconEditRedemptions();
                AddDelay(5000);
                Logger.WriteDebugMessage("Edit Redemption window gets opened");

                //4.Capture Agents Name , Certificate No and Expiration date of the reward
                string AgentName = AdminManageRedemptions.GetFirstname();
                string CertificateNo = AdminManageRedemptions.GetCertificateNumber();
                string Expirationdate = AdminManageRedemptions.GetExpirationDate();
                string AgentEmail = AdminManageRedemptions.GetEmail();
                Logger.WriteDebugMessage("Detail captured");

                //5.Click on Click on Resend certificate button
                AdminManageRedemptions.ClickButtonResendCerificate();
                Logger.WriteDebugMessage("A popup appears with an option to enter new email address gets displayed");

                //6.Enter your email address and click on Send button
                AdminManageRedemptions.ClickRadioButtonOther();
                AddDelay(1500);
                AdminManageRedemptions.EnterCustomerEmail(AgentEmail);
                AddDelay(3500);
                AdminManageRedemptions.ClickButtonSend();
                VerifyTextOnPage(Constants.CertificateConfirmation);
                AddDelay(3500);
                AdminManageRedemptions.ClickButtonOk();
                Logger.WriteDebugMessage("Confirmation popup 'Certificate has been sent' should display");

                //7.Login to Webmail and validate the email sent to the agent
                OpenNewTab();
                Email.LogIntoCatchAll();
                Logger.WriteDebugMessage("User should be Logged in Catchall Account");
                Email.CatchAll_SearchEmailAndOpenLatestMessage(AgentEmail);
                Logger.WriteDebugMessage("A) AMRewards Certificate mail should be sent to agent without any certificate B) The mail should consist of a button to generate the certificate.C) To address should be agents email (domain name may not match with Agent email in QA, will be @Cendyn17.com / @Cendyn.com)");

                //8.Click on  the button in the received mail verify the below details in the certificate generated: 1.Certificate No 2.Expiration date 3.Agent Name                
                PageDown();
                AdminManageRedemptions.ClickButtonViewandPrint();
                ControlToNewWindow();
                HandleUnSafeWindows();
                VerifyTextOnPage(CertificateNo);
                VerifyTextOnPage(Expirationdate);
                Logger.WriteDebugMessage("The details in the certificate should match with details captured in step4");
            }
        }
    }
}