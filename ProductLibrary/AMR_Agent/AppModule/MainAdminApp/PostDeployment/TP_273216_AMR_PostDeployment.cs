using System;
using AMR_Agent.AppModule.Admin;
using AMR_Agent.AppModule.UI;
using AMR_Agent.PageObject.UI;
using AMR_Agent.Utility;
using eLoyaltyV3.AppModule.UI;
using InfoMessageLogger;
using NUnit.Framework;
namespace AMR_Agent.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        public static void TC_281327()
        {
            if (TestCaseId == Constants.TC_281327)
            {
                //New User Registration

                //1.Open the URl 
                //2.Click on Register button 
                string Country, Providence, Address, City, Zip, IATA, RecoveryQuestion, RecoveryAnswer;
                
                Random Ran = new Random();
                Country = TestData.ExcelData.TestDataReader.ReadData(1, "Country");
                Providence = TestData.ExcelData.TestDataReader.ReadData(1, "Providence");
                Address = TestData.ExcelData.TestDataReader.ReadData(1, "Address");
                City = TestData.ExcelData.TestDataReader.ReadData(1, "City");
                Zip = TestData.ExcelData.TestDataReader.ReadData(1, "Zip");
                IATA = TestData.ExcelData.TestDataReader.ReadData(1, "IATA");
                RecoveryQuestion = TestData.ExcelData.TestDataReader.ReadData(1, "RecoveryQuestion");
                RecoveryAnswer = TestData.ExcelData.TestDataReader.ReadData(1, "RecoveryAnswer");

                PageObject_Login.LoginRegisterNow().Click();
                Logger.WriteDebugMessage("Clicked the 'Register Now' button.");
                AddDelay(2500);

                //3.Complete the registration form by keying in all the value including 1.Country of Residence 2.Agent Type 3.Affiliation Code
                string email1 = Registration.EmailNow();
                Registration.DefaultEmailPassSecurity(email1);
                Registration.DefaultPersonalInformationSelectCountry(Country, Providence, Address, City, Zip);
                AddDelay(1000);

                //Insert the IATA code
                Registration.EnterIATA(IATA);

                //Fill in the Agent Type fields.
                Registration.DefaultAgentType();
                Logger.WriteDebugMessage("Entered All Registration Details");
                //Confirm the successful registration using the IATA code
                Registration.ConfirmSuccessfulRegistration();
                Logger.WriteDebugMessage("Successfully created and confirmed a new registration using an IATA code.");

                //4.Click on Register button
                //5.Click on OK button   
                //6.After Registration when user first lands on the AMREWARDS page ,verfiy the welcome popup
                //7.Select the Check box and click on Accept button 
                Registration.ConfirmRegistrationOnProdAdmin();
                Logger.WriteDebugMessage("Confirmed the registered user is validated on the admin site when selecting Canada and using an IATA code.");

                //Verify thanks you email generated  and is available in webmail.cendyn.com: Login to Webmail.cendyn.com Search for agent email address
                Driver.Navigate().GoToUrl("https://outlook.office.com/mail/");
                AddDelay(2500);
                Hotmail.NavigateAndLogIntoCatchAll();
                AddDelay(15000);
                Hotmail.SearchEmailAndOpenLatestEmail(email1);
                VerifyTextOnPage(Constants.WelcomeEmailSubject);
                AddDelay(2500);
                Logger.WriteDebugMessage("successfully  received email on webmail.cendyn.com and all details are correct");

                //Verify all links after sign in.
                Driver.Navigate().GoToUrl(Constants.Common_PostDeploymentFrontendURL);
                Login.EnterEmail(email1);
                AddDelay(5000);
                Login.EnterPassword(Constants.Common_Registration_Password);

                //Click "Sign In"
                PageObject_Login.LoginSignIn().Click();
                AddDelay(3000);
                Driver.Navigate().GoToUrl(Constants.Common_PostDeploymentFrontendURL);
                Logger.WriteInfoMessage("Clicked the 'Sign In' button'");
                if (!PageObject_AMRAgentsNav.AMRAgentsLogOff().Displayed)
                {
                    Logger.WriteFatalMessage("Did not log in sucessfully.");
                    Assert.Fail();
                }

                Logger.WriteDebugMessage("Logged in successfully.");
                AddDelay(2000);

                //3.Click AMRewards
                PageObject_AMRAgentsNav.AMRAgentsAMRewards().Click();
                AddDelay(5000);
                Logger.WriteDebugMessage("Landed on the AMRewards page.");

                //4.Click "Points History"
                PageObject_AMRewards.AMRewards_PointsHistory().Click();
                AddDelay(2500);

                if (Driver.FindElement(OpenQA.Selenium.By.Id("point-history")).Text == "POINTS HISTORY")
                    Logger.WriteDebugMessage("Landed on the 'Points History' page.");
                else
                    Assert.Fail("Does not landed on 'Point History' Page'");

                //Go back to AMRewards
                PageObject_AMRAgentsNav.AMRAgentsAMRewards().Click();
                Logger.WriteInfoMessage("Landed back on the AMRewards page.");

                //5.Click "Rules and Regulations"
                OpenPopUpWindow(PageObject_AMRewards.AMRewardsRulesAndRegulations());
                Logger.WriteDebugMessage("Rules and Regulations PDF is displayed or downloaded.");
                AddDelay(2500);
                ClosePopUpWindow();

                //6. Click "Total Points Available"
                PageObject_AMRewards.AMRewards_TotalPointsAvailable().Click();
                AddDelay(2500);

                if (ValidatePageURL("https://amrewards.amragents.com/home.mvc/AccountSummary/Index"))
                {
                    ScrollDownUsingJavaScript(Driver, 600);
                    Logger.WriteDebugMessage("Landed on the Account Summary page.");
                }
                else
                    Assert.Fail("Did not land on the Account Summary page.");

                //Go back to AMRewards
                PageObject_AMRAgentsNav.AMRAgentsAMRewards().Click();
                Logger.WriteInfoMessage("Landed back on the AMRewards page.");

                //8. Click "Total Points Redeemed"
                PageObject_AMRewards.AMRewards_TotalPointsExpiring().Click();

                if (ValidatePageURL("https://amrewards.amragents.com/home.mvc/PointsHistory/Index"))
                {
                    ScrollDownUsingJavaScript(Driver, 600);
                    Logger.WriteDebugMessage("Landed on the Points Received page.");
                }
                else
                    Assert.Fail("Did not land on the Points Received page.");

                //Verify the forgot Password functinality
                ElementClick(PageObject_AMRAgentsNav.AMRAgentsLogOff());
                Logger.WriteDebugMessage("Landed on Sign In Page");

                //Click "Forgot Pasword"
                PageObject_Login.LoginForgotPassword().Click();
                Logger.WriteDebugMessage("Clicked the 'Forgot Password' link.");
                AddDelay(5000);

                //Enter the email address

                PageObject_ForgotPassword.ForgotPasswordEmail().SendKeys(email1);
                Logger.WriteDebugMessage("Email address is entered.");
                AddDelay(5000);

                //Select 'Ask me my recovery question' and click 'Submit'.
                PageObject_ForgotPassword.ForgotPasswordRecoveryQuestionRadioButton().Click();
                Logger.WriteDebugMessage("Selected the 'Security Question' radio button. ");
                AddDelay(1000);
                PageObject_ForgotPassword.ForgotPasswordSubmit().Click();
                AddDelay(2000);

                try
                {
                    //Verify the security question is displayed
                    if (VerifyTextOnPage(RecoveryQuestion))
                        Logger.WriteDebugMessage("Verified the security question is displayed.");
                    else
                        throw new Exception("The incorrect question is displayed.");
                }
                catch (Exception e)
                {
                    Logger.WriteFatalMessage(e);
                    Logger.WriteInfoMessage("Was Looking for: " + RecoveryQuestion);
                    Logger.WriteInfoMessage("But found: " + Driver.FindElement(OpenQA.Selenium.By.Id("question-label")).Text);
                    Assert.Fail();
                }

                //Generate a random password
                StoredContent = "Cendyn" + Ran.Next().ToString().Substring(0, 3);

                //Enter the security answer, password and confirm password.
                PageObject_ForgotPassword.ForgotPasswordRecoveryAnswer().SendKeys(RecoveryAnswer);
                Logger.WriteInfoMessage("Entered the recovery answer");
                AddDelay(2000);
                PageObject_ForgotPassword.ForgotPasswordNewPassword().SendKeys(StoredContent);
                Logger.WriteInfoMessage("Entered the password");
                AddDelay(2000);
                PageObject_ForgotPassword.ForgotPasswordNewPasswordConfirmation().SendKeys(StoredContent);
                Logger.WriteInfoMessage("Entered the password confirmation");
                AddDelay(2000);
                PageObject_ForgotPassword.ForgotPasswordRecoverySubmit().Click();
                Logger.WriteDebugMessage("Filled in the recovery answer, password, confirm password and clicked the 'Submit' button.");
                AddDelay(2500);

                //Click the "Log In" button.
                PageObject_ForgotPassword.ForgotPasswordLogin().Click();
                Logger.WriteDebugMessage("Clicked the 'Log In' button.");
                AddDelay(2000);

                //Login using the ID and the new password.
                PageObject_Login.LoginEmail().Clear();
                PageObject_Login.LoginEmail().SendKeys(email1);
                AddDelay(2000);
                PageObject_Login.LoginPassword().SendKeys(StoredContent);
                AddDelay(2000);
                PageObject_Login.LoginSignIn().Click();
                AddDelay(5000);

                //Verify logged in successfully.
                try
                {
                    if (PageObject_AMRAgentsNav.AMRAgentsLogOff().Displayed)
                        Logger.WriteDebugMessage("Logged in successfully using the new password.");
                    else
                        throw new Exception("Did not log in using the new password.");
                }
                catch (Exception e)
                {
                    Logger.WriteFatalMessage(e);
                    Assert.Fail();
                }

                //Navigate to Admin and Delete the added User
                Driver.Navigate().GoToUrl(Constants.Common_PostDeploymentAdminURL);
                Logger.WriteDebugMessage("User Landed on Admin dashboard Page");

                //3.Click on Manage Profile 
                AdminManageHome.ClickManageProfile();
                AddDelay(5000);
                Logger.WriteDebugMessage("user able to click on Manage Profile and navigate to Manage Profile Page");

                //4.Click on Validated Profiles tab 
                AdminManageProfile.ClickValidateProfile();
                Logger.WriteDebugMessage("User able to click on activated profiles tab and activated profiles list should display ");

                //5.Verify that agent profile not have any Booking by clicking on Manage booking
                AdminManageHome.ClickManageBookings();
                AdminManageBookings.EnterSearch(email1);
                AddDelay(5000);
                string bookingnumber = AdminManageBookings.GetBookingNumber();
                if (bookingnumber.Equals("Enter a value to search"))
                {
                    Logger.WriteDebugMessage(email1 + " don NOT contains any booking");
                }
                Logger.WriteDebugMessage("Navigate to manage booking for verifying the bookings associated with agent ");

                //6.Click on Delete profile in Actions Column on Manage profile Page under activated profile 
                AdminManageHome.ClickManageProfile();
                AddDelay(2500);
                AdminManageProfile.ClickValidateProfile();
                AddDelay(2500);
                AdminManageProfile.EnterSearch(email1);
                AddDelay(5000);
                AdminManageProfile.ClickValidatedProfileIconDelete(email1);
                AddDelay(5000);
                VerifyTextOnPage(Constants.ProfileDeleteWarning(email1));
                Logger.WriteDebugMessage("User able to click on delete profile link and Delete profile confirmation pop up should be alerted ");

                //7.Click on Confirm deletion button 
                AdminManageProfile.ClickValidatedProfileButtonDeleteConfirm();
                AddDelay(5000);
                VerifyTextOnPage(Constants.ProfileDeleteConfirmation);
                Logger.WriteDebugMessage("user able to click on Confirm deletion button and should be alerted by pop up that profile is deleted and profile should be successfully deleted ");
                AddDelay(5000);
                AdminManageProfile.ClickButtonClose();
            }
        }
    }
}
