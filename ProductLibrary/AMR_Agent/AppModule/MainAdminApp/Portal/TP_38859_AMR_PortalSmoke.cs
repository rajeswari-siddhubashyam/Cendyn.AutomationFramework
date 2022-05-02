using System;using AMR_Agent.AppModule.UI;
using AMR_Agent.PageObject.Admin;
using AMR_Agent.PageObject.UI;
using AMR_Agent.Utility;
using eLoyaltyV3.AppModule.UI;
using InfoMessageLogger;
using NUnit.Framework;

namespace AMR_Agent.AppModule.MainAdminApp
{
    public partial class MainAdminApp : AMR_Agent.Utility.Setup
    {

        public static void TC_27838()
        {
            if (TestCaseId == Constants.TC_27838)
            {
                string IATA, CLIA, ARC, TRU;
                IATA = TestData.ExcelData.TestDataReader.ReadData(1, "IATA");
                CLIA = TestData.ExcelData.TestDataReader.ReadData(1, "CLIA");
                ARC = TestData.ExcelData.TestDataReader.ReadData(1, "ARC");
                TRU = TestData.ExcelData.TestDataReader.ReadData(1, "TRU");
                //Click "Register"
                PageObject_Login.LoginRegisterNow().Click();
                Logger.WriteDebugMessage("Clicked the 'Register Now' button.");
                AddDelay(5000);

                //Fill in all default registration fields 
                string email1 = Registration.EmailNow();
                Registration.DefaultEmailPassSecurity(email1);
                Registration.DefaultPersonalInformation();
                AddDelay(1000);

                //Insert the IATA code
                Registration.EnterIATA(IATA);

                //Fill in the Agent Type fields.
                Registration.DefaultAgentType();

                //Confirm the successful registration using the IATA code
                Registration.ConfirmSuccessfulRegistration();
                Logger.WriteDebugMessage("Successfully created and confirmed a new registration using an IATA code.");

                //Click "Register"
                PageObject_Login.LoginRegisterNow().Click();
                Logger.WriteDebugMessage("Clicked the 'Register Now' button.");
                AddDelay(5000);

                //Fill in all default registration fields 
                string email2 = Registration.EmailNow();
                Registration.RegEmail = email2;
                Registration.DefaultEmailPassSecurity(email2);
                Registration.DefaultPersonalInformation();
                AddDelay(1000);

                //Insert the ARC code
                Registration.EnterARC(ARC);

                //Fill in the Agent Type fields.
                Registration.DefaultAgentType();

                //Confirm the successful registration using the ARC code
                Registration.ConfirmSuccessfulRegistration();
                Logger.WriteDebugMessage("Successfully created and confirmed a new registration using an ARC code.");

                //Click "Register"
                PageObject_Login.LoginRegisterNow().Click();
                Logger.WriteDebugMessage("Clicked the 'Register Now' button.");
                AddDelay(5000);

                //Fill in all default registration fields 
                string email3 = Registration.EmailNow();
                Registration.RegEmail = email3;
                Registration.DefaultEmailPassSecurity(email3);
                Registration.DefaultPersonalInformation();
                AddDelay(1000);

                //Insert the CLIA code
                Registration.EnterCLIA(CLIA);

                //Fill in the Agent Type fields.
                Registration.DefaultAgentType();

                //Confirm the successful registration using the CLIA code
                Registration.ConfirmSuccessfulRegistration();
                Logger.WriteDebugMessage("Successfully created and confirmed a new registration using an CLIA code.");

                //Click "Register"
                PageObject_Login.LoginRegisterNow().Click();
                Logger.WriteDebugMessage("Clicked the 'Register Now' button.");
                AddDelay(5000);

                //Fill in all default registration fields 
                string email4 = Registration.EmailNow();
                Registration.RegEmail = email4;
                Registration.DefaultEmailPassSecurity(email4);
                Registration.DefaultPersonalInformation();
                AddDelay(1000);

                //Insert the TRU code
                Registration.EnterTRU(TRU);

                //Fill in the Agent Type fields.
                Registration.DefaultAgentType();

                //Confirm the successful registration using the TRU code
                Registration.ConfirmSuccessfulRegistration();
                Logger.WriteDebugMessage("Successfully created and confirmed a new registration using an TRU code.");

            }
        }
        public static void TC_37513()
        {
            if (TestCaseId == Constants.TC_37513)
            {
                //Click "Register"
                string Country, Providence, Address, City, Zip, IATA, CLIA, ARC, TRU, TIDS, TICO;
                Country = TestData.ExcelData.TestDataReader.ReadData(1, "Country");
                Providence = TestData.ExcelData.TestDataReader.ReadData(1, "Providence");
                Address = TestData.ExcelData.TestDataReader.ReadData(1, "Address");
                City = TestData.ExcelData.TestDataReader.ReadData(1, "City");
                Zip = TestData.ExcelData.TestDataReader.ReadData(1, "Zip");
                IATA = TestData.ExcelData.TestDataReader.ReadData(1, "IATA");
                CLIA = TestData.ExcelData.TestDataReader.ReadData(1, "CLIA");
                ARC = TestData.ExcelData.TestDataReader.ReadData(1, "ARC");
                TRU = TestData.ExcelData.TestDataReader.ReadData(1, "TRU");
                TIDS = TestData.ExcelData.TestDataReader.ReadData(1, "TIDS");
                TICO = TestData.ExcelData.TestDataReader.ReadData(1, "TICO");
                PageObject_Login.LoginRegisterNow().Click();
                Logger.WriteDebugMessage("Clicked the 'Register Now' button.");
                AddDelay(2500);

                //Fill in all default registration fields                 
                string email1 = Registration.EmailNow();
                Registration.DefaultEmailPassSecurity(email1);
                Registration.DefaultPersonalInformationSelectCountry(Country, Providence, Address, City, Zip);
                AddDelay(1000);

                //Insert the IATA code
                //Insert the CLIA code
                //Insert the TRU code
                //Insert the TIDS code
                //Insert the TICO code
                Registration.EnterIATA(Constants.Common_Registration_IATA);
                Registration.EnterTICO(TICO);
                //Registration.EnterIATA(TestData.Common_Registration_IATA);
                Registration.EnterTIDS(TIDS);
                Registration.EnterTRU(TRU);
                Registration.EnterCLIA(CLIA);
                //Registration.EnterIATA(IATA);

                //Fill in the Agent Type fields.
                Registration.DefaultAgentType();

                //Confirm the successful registration using the IATA code
                Registration.ConfirmSuccessfulRegistration();
                Logger.WriteDebugMessage("Successfully created and confirmed a new registration using an IATA code.");

                //Confirm the registered user displayed under validated profiles on admin.
                Registration.ConfirmRegistrationOnAdmin();
                Logger.WriteDebugMessage("Confirmed the registered user is validated on the admin site when selecting Canada and using an IATA code.");

                //Return to the frontend login page.
                //Driver.Navigate().GoToUrl(TestData.Common_FrontendURL);
                //AddDelay(1000);

                ////Click "Register"
                //PageObject_Login.LoginRegisterNow().Click();
                //Logger.WriteDebugMessage("Clicked the 'Register Now' button.");
                //AddDelay(2500);

                ////Fill in all default registration fields                
                //Registration.DefaultEmailPassSecurity();
                //string email2 = Registration.RegEmail;
                //Registration.DefaultPersonalInformationSelectCountry(Country, Providence, Address, City, Zip);
                //AddDelay(1000);

                ////Insert the ARC code
                //Registration.EnterARC(ARC);

                ////Fill in the Agent Type fields.
                //Registration.DefaultAgentType();

                ////Confirm the successful registration using the ARC code
                //Registration.ConfirmSuccessfulRegistration();
                //Logger.WriteDebugMessage("Successfully created and confirmed a new registration using an ARC code.");

                ////Confirm the registered user displayed under validated profiles on admin.
                //Registration.ConfirmRegistrationOnAdmin();
                //Logger.WriteDebugMessage("Confirmed the registered user is validated on the admin site when selecting Canada and using an ARC code.");

                ////Return to the frontend login page.
                //Driver.Navigate().GoToUrl(TestData.Common_FrontendURL);
                //AddDelay(1000);

                ////Click "Register"
                //PageObject_Login.LoginRegisterNow().Click();
                //Logger.WriteDebugMessage("Clicked the 'Register Now' button.");
                //AddDelay(2500);

                ////Fill in all default registration fields 
                //Registration.DefaultEmailPassSecurity();
                //Registration.DefaultPersonalInformationSelectCountry(Country, Providence, Address, City, Zip);
                //AddDelay(1000);

                ////Insert the CLIA code
                //Registration.EnterCLIA(CLIA);

                ////Fill in the Agent Type fields.
                //Registration.DefaultAgentType();

                ////Confirm the successful registration using the CLIA code
                //Registration.ConfirmSuccessfulRegistration();
                //Logger.WriteDebugMessage("Successfully created and confirmed a new registration using an CLIA code.");

                ////Confirm the registered user displayed under validated profiles on admin.
                //Registration.ConfirmRegistrationOnAdmin();
                //Logger.WriteDebugMessage("Confirmed the registered user is validated on the admin site when selecting Canada and using an CLIA code.");

                ////Return to the frontend login page.
                //Driver.Navigate().GoToUrl(TestData.Common_FrontendURL);
                //AddDelay(1000);

                ////Click "Register"
                //PageObject_Login.LoginRegisterNow().Click();
                //Logger.WriteDebugMessage("Clicked the 'Register Now' button.");
                //AddDelay(2500);

                ////Fill in all default registration fields 
                //Registration.DefaultEmailPassSecurity();
                //Registration.DefaultPersonalInformationSelectCountry(Country, Providence, Address, City, Zip);
                //AddDelay(1000);

                ////Insert the TRU code
                //Registration.EnterTRU(TRU);

                ////Fill in the Agent Type fields.
                //Registration.DefaultAgentType();

                ////Confirm the successful registration using the TRU code
                //Registration.ConfirmSuccessfulRegistration();
                //Logger.WriteDebugMessage("Successfully created and confirmed a new registration using an TRU code.");

                ////Confirm the registered user displayed under validated profiles on admin.
                //Registration.ConfirmRegistrationOnAdmin();
                //Logger.WriteDebugMessage("Confirmed the registered user is validated on the admin site when selecting Canada and using an TRU code.");

                ////Return to the frontend login page.
                //Driver.Navigate().GoToUrl(TestData.Common_FrontendURL);
                //AddDelay(1000);

                ////Click "Register"
                //PageObject_Login.LoginRegisterNow().Click();
                //Logger.WriteDebugMessage("Clicked the 'Register Now' button.");
                //AddDelay(2500);

                ////Fill in all default registration fields 
                //Registration.DefaultEmailPassSecurity();
                //Registration.DefaultPersonalInformationSelectCountry(Country, Providence, Address, City, Zip);
                //AddDelay(1000);

                ////Insert the TIDS code
                //Registration.EnterIATA(TestData.Common_Registration_IATA);
                //Registration.EnterTIDS(TIDS);

                ////Fill in the Agent Type fields.
                //Registration.DefaultAgentType();

                ////Confirm the successful registration using the TIDS code
                //Registration.ConfirmSuccessfulRegistration();
                //Logger.WriteDebugMessage("Successfully created and confirmed a new registration using an TIDS code.");

                ////Confirm the registered user displayed under validated profiles on admin.
                //Registration.ConfirmRegistrationOnAdmin();
                //Logger.WriteDebugMessage("Confirmed the registered user is validated on the admin site when selecting Canada and using an TIDS code.");

                ////Return to the frontend login page.
                //Driver.Navigate().GoToUrl(TestData.Common_FrontendURL);
                //AddDelay(5000);

                ////Click "Register"
                //PageObject_Login.LoginRegisterNow().Click();
                //Logger.WriteDebugMessage("Clicked the 'Register Now' button.");
                //AddDelay(2500);

                ////Fill in all default registration fields 
                //Registration.DefaultEmailPassSecurity();
                //Registration.DefaultPersonalInformationSelectCountry(Country, Providence, Address, City, Zip);
                //AddDelay(1000);

                ////Insert the TICO code
                //Registration.EnterIATA(TestData.Common_Registration_IATA);
                //Registration.EnterTICO(TICO);

                ////Fill in the Agent Type fields.
                //Registration.DefaultAgentType();

                ////Confirm the successful registration using the TICO code
                //Registration.ConfirmSuccessfulRegistration();
                //Logger.WriteDebugMessage("Successfully created and confirmed a new registration using an TICO code.");

                ////Confirm the registered user displayed under validated profiles on admin.
                //Registration.ConfirmRegistrationOnAdmin();
                //Logger.WriteDebugMessage("Confirmed the registered user is validated on the admin site when selecting Canada and using an TICO code.");

                //Verify thanks you email generated  and is available in webmail.cendyn.com: Login to Webmail.cendyn.com Search for agent email address
                Driver.Navigate().GoToUrl("https://outlook.office365.com/owa/?realm=cendyn17.com&exsvurl=1&ll-cc=1033&modurl=0");
                Hotmail.NavigateAndLogIntoCatchAll();
                AddDelay(2500);
                Hotmail.SearchEmailAndOpenLatestEmail(email1);
                AddDelay(2500);
                VerifyTextOnPage(Constants.WelcomeEmailSubject);
                AddDelay(2500);
                Logger.WriteDebugMessage("successfully  received email on webmail.cendyn.com and all details are same as that was register previous");

                //Driver.Navigate().GoToUrl("https://outlook.office365.com/owa/?realm=cendyn17.com&exsvurl=1&ll-cc=1033&modurl=0");
                //Hotmail.ClickOutLook();
                //AddDelay(2500);
                //Hotmail.SearchEmailAndOpenLatestEmail(email2);
                //AddDelay(2500);
                //VerifyTextOnPage(Constants.WelcomeEmailSubject);
                //AddDelay(2500);
                //Logger.WriteDebugMessage("successfully  received email on webmail.cendyn.com and all details are same as that was register previous");
            }
        }
        public static void TC_37518()
        {
            if (TestCaseId == Constants.TC_37518)
            {
                //Click "Forgot Pasword"
                string Email, ConfirmEmail, NewPassword, ConfirmNewPassword, RecoveryQuestion, RecoveryAnswer;
                Email = TestData.ExcelData.TestDataReader.ReadData(1, "Email");
                ConfirmEmail = TestData.ExcelData.TestDataReader.ReadData(1, "ConfirmEmail");
                NewPassword = TestData.ExcelData.TestDataReader.ReadData(1, "NewPassword");
                ConfirmNewPassword = TestData.ExcelData.TestDataReader.ReadData(1, "ConfirmNewPassword");
                RecoveryQuestion = TestData.ExcelData.TestDataReader.ReadData(1, "RecoveryQuestion");
                RecoveryAnswer = TestData.ExcelData.TestDataReader.ReadData(1, "RecoveryAnswer");
                PageObject_Login.LoginForgotPassword().Click();
                Logger.WriteDebugMessage("Clicked the 'Forgot Password' link.");
                AddDelay(5000);

                //Enter the email address

                PageObject_ForgotPassword.ForgotPasswordEmail().SendKeys(Email);
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
                StoredContent = ForgotPassword.GeneratePassword();

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
                PageObject_Login.LoginEmail().SendKeys(Email);
                AddDelay(2000);
                PageObject_Login.LoginPassword().SendKeys(StoredContent);
                AddDelay(2000);
                PageObject_Login.LoginSignIn().Click();
                AddDelay(5000);
                Driver.Navigate().GoToUrl(Constants.Common_FrontendURL);

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

            }
        }
        public static void TC_37522()
        {
            if (TestCaseId == Constants.TC_37522)
            {
                //1.Data Requirement: Agent email address  should be updated with tester mobile number.Note: Data can be conditioned in Agent Profile page by updating the mobile number
                //2.Navigate to the login page  of travel agent loyalty program 
                //3.Click on Forgot Password link
                string EmailAddress, NewPassword, URL;
                EmailAddress = TestData.ExcelData.TestDataReader.ReadData(1, "EmailAddress");
                NewPassword = TestData.ExcelData.TestDataReader.ReadData(1, "NewPassword");
                URL = "https://travelagentloyaltyprogram.qa.cendyn.com/";

                Login.ClickLoginForgotPassword();
                Logger.WriteDebugMessage("User landed on FORGOT YOUR PASSWORD screen");
                AddDelay(5000);

                //4.Enter the  registered email id
                ForgotPassword.EnterEmailAddress(EmailAddress);
                Logger.WriteDebugMessage("email id is enter successfully");

                //5.select the Reset method as "Send validation code to Email Address" and click on submit button
                ForgotPassword.ClickEmailVerificationCode();
                ForgotPassword.ClickSubmit();
                Logger.WriteDebugMessage("user successfully landed on AMResorts Agents - Password Recovery scrren");

                //6.Enter the 10 digit verification code details of  "Enter validation code received via text" "Confirm password" and click on submit button                         
                OpenNewTab();
                Driver.Navigate().GoToUrl("https://outlook.office365.com/owa/?realm=cendyn17.com&exsvurl=1&ll-cc=1033&modurl=0");
                Hotmail.NavigateAndLogIntoCatchAll();
                Hotmail.SearchEmailAndOpenLatestEmail(EmailAddress);
                AddDelay(2500);
                string code = ForgotPassword.GetVerificationCode();
                ControlToPreviousWindow();
                //string password = MakeUnique(NewPassword);
                Random ran = new Random();
                string password = NewPassword + ran.Next().ToString().Substring(0, 3);
                ForgotPassword.EnterVerificationCode(code);
                ForgotPassword.EnterNewPassword(password);
                ForgotPassword.EnterConfirmNewPassword(password);
                ForgotPassword.ClickRecoverySubmit();
                VerifyTextOnPage(Constants.PasswordResetConfirmation);
                Logger.WriteDebugMessage("Confirmation pop message should be displayed 'Password reset was successful' and login button are enabled on that screen");

                //7.click on login button
                //8.Enter id and new password
                ForgotPassword.ClickButtonLogin();
                AddDelay(5000);
                ParameterizedLogin(EmailAddress, password);
                AddDelay(5000);
                Logger.WriteDebugMessage("User successfully login to the application with new password");
            }
        }
        public static void TC_37539()
        {

            if (TestCaseId == Constants.TC_37539)
            {
                //Click "Register"
                PageObject_Login.LoginRegisterNow().Click();
                Logger.WriteDebugMessage("Clicked the 'Register Now' button.");
                AddDelay(2500);

                //Fill in all default registration fields.
                string email1 = Registration.EmailNow();
                Registration.DefaultRegistration(email1);
                PageObject_Registration.RegisterARC().Clear();
                PageObject_Registration.RegisterCLIA().Clear();
                PageObject_Registration.RegisterTRU().Clear();
                Logger.WriteDebugMessage("Entered in all registration information using the following information: ");
                Logger.WriteInfoMessage("RegCountry = United States");
                Logger.WriteInfoMessage("Agenty Type NOT as Tour Operator/Wholesaler");
                Logger.WriteInfoMessage("Affliation Code IATA = 67839085");

                //Click "Register"
                ScrollToElement(PageObject_Registration.RegisterRegisterButton());
                AddDelay(15000);
                PageObject_Registration.RegisterRegisterButton().Click();
                Logger.WriteDebugMessage("Clicked 'Register'.");
                AddDelay(2500);

                //Click "OK"

                WaittillElementDisplay(PageObject_Registration.RegisterRegistrationCompleteButton());
                Logger.WriteDebugMessage("Registered successfully.");
                AddDelay(15000);

                //Click "Update Profile.
                Driver.Navigate().GoToUrl(Constants.Common_FrontendURL);
                ConfirmRegistration();
                PageObject_AMRAgentsNav.AMRAgentsUpdateProfile().Click();
                Logger.WriteDebugMessage("Landed on the 'Update Profile' page.");
                AddDelay(5000);

                //Click "My Redemptions"
                PageObject_AMRAgentsNav.AMRAgentsMyRedemptions().Click();
                AddDelay(2500);

                //Added by Divya : 21 August 2017 : Commented the below code as he test cases failed due to this code.
                ////Click the "Enroll Me" checkbox and click "Accept"
                //AMRRewards.AcceptPopup();

                //if (!PageObject_AMRewards.AMRRewardsPopupAccept().Displayed)
                //{
                //    Logger.WriteDebugMessage("Clicked the 'Enroll Me' checkbox.");
                //}
                //else
                //{
                //    Logger.WriteFatalMessage(
                //        "The 'Welcome to Loyalty' program' popup is still displayed after accepting.");
                //    Assert.Fail();
                //}

                //AddDelay(1000);

                ////Click "My Redemptions" again.
                //PageObject_AMRAgentsNav.AMRAgentsMyRedemptions().Click();
                //AddDelay(2500);

                //Added by Divya : 21 August 2017 : Added AcceptPopup()
                //Click the "Enroll Me" checkbox and click "Accept"
                //var alert = PageObject_AMRewards.AMRRewardsEnrollMeCheckbox().Displayed;
                //if (alert.Equals(true))
                //{
                //    AMRRewards.AcceptPopup();
                //    PageObject_AMRAgentsNav.AMRAgentsMyRedemptions().Click();
                //}

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
                else
                {
                    Logger.WriteFatalMessage("The W9 warning popup did not display.");
                    Logger.WriteInfoMessage("Was looking for: " + Constants.UpdateProfileW9Warning);
                    Logger.WriteInfoMessage("But found: " +
                                            PageObject_UpdateProfile.UpdateProfileW9WarningPopupText().Text);
                    Assert.Fail();
                }

            }

        }
        public static void TC_37548()
        {
            if (TestCaseId == Constants.TC_37548)
            {
                //1.Open  the URl https://travelagentloyaltyprogram.qa.cendyn.com/
                //2.Login to Loyalty portal  using the  account credential 
                string BookingType, RoomNum, BookingMadeWith, BookingNumber, GuestFirstName, GuestLastName, DateBookedMonth, DateBookedDay, DateBookedYear, TravelStartMonth, TravelStartDay, TravelStartYear, TravelEndMonth, TravelEndYear,
                TravelEndDay, Brand, Resort, DepartureGateway;
                BookingType = TestData.ExcelData.TestDataReader.ReadData(1, "BookingType");
                RoomNum = TestData.ExcelData.TestDataReader.ReadData(1, "RoomNum");
                BookingMadeWith = TestData.ExcelData.TestDataReader.ReadData(1, "BookingMadeWith");
                BookingNumber = TestData.ExcelData.TestDataReader.ReadData(1, "BookingNumber");
                GuestFirstName = TestData.ExcelData.TestDataReader.ReadData(1, "GuestFirstName");
                GuestLastName = TestData.ExcelData.TestDataReader.ReadData(1, "GuestLastName");
                DateBookedMonth = TestData.ExcelData.TestDataReader.ReadData(1, "DateBookedMonth");
                DateBookedDay = TestData.ExcelData.TestDataReader.ReadData(1, "DateBookedDay");
                DateBookedYear = TestData.ExcelData.TestDataReader.ReadData(1, "DateBookedYear");
                TravelStartMonth = TestData.ExcelData.TestDataReader.ReadData(1, "TravelStartMonth");
                TravelStartDay = TestData.ExcelData.TestDataReader.ReadData(1, "TravelStartDay");
                TravelStartYear = TestData.ExcelData.TestDataReader.ReadData(1, "TravelStartYear");
                TravelEndMonth = TestData.ExcelData.TestDataReader.ReadData(1, "TravelEndMonth");
                TravelEndDay = TestData.ExcelData.TestDataReader.ReadData(1, "TravelEndDay");
                TravelEndYear = TestData.ExcelData.TestDataReader.ReadData(1, "TravelEndYear");
                Brand = TestData.ExcelData.TestDataReader.ReadData(1, "Brand");
                Resort = TestData.ExcelData.TestDataReader.ReadData(1, "Resort");
                DepartureGateway = TestData.ExcelData.TestDataReader.ReadData(1, "DepartureGateway");
                ValidLogin();
                Logger.WriteDebugMessage("Logged in successfully.");
                AddDelay(2000);

                //3.click on update profile link
                PageObject_AMRAgentsNav.AMRAgentsUpdateProfile().Click();
                Logger.WriteDebugMessage("Clicked on 'Update Profile'.");
                AddDelay(2000);

                //4.click on submit booking on agent profile screen page
                PageObject_AMRAgentsNav.AMRAgentsSubmitBooking().Click();
                Logger.WriteDebugMessage("Landed on the 'Submit Booking' page.");
                AddDelay(7500);

                //5.Click submit button without filling required fields
                ScrollToElement(PageObject_SubmitBooking.SubmitBookingSubmit());
                PageObject_SubmitBooking.SubmitBookingSubmit().Click();
                AddDelay(2500);
                //Verify the popup is displayed
                try
                {
                    PageObject_SubmitBooking.SubmitBookingPopupOKBtn().Click();
                    Logger.WriteDebugMessage("The 'Required Fields' popup was displayed and now closed.");
                    AddDelay(1000);
                }
                catch (Exception e)
                {
                    Logger.WriteFatalMessage("The 'Required Fields' popup did not display");
                    Logger.WriteFatalMessage(e);
                    Assert.Fail();
                }

                //6 .Fill all the required 
                bookingNum = SubmitBooking.BookingNumber();

                //Enter test information
                ScrollToElement(PageObject_SubmitBooking.SubmitBookingIndividualRadioButton());
                PageObject_SubmitBooking.SubmitBookingIndividualRadioButton().Click();
                AddDelay(2000);
                PageObject_SubmitBooking.SubmitBookingBookingMadeWith().SendKeys(BookingMadeWith);
                AddDelay(2000);
                PageObject_SubmitBooking.SubmitBookingBookingNumber().SendKeys(SubmitBooking.BookingNumber());
                AddDelay(2000);
                PageObject_SubmitBooking.SubmitBookingGuestFirstName().SendKeys(GuestFirstName);
                AddDelay(2000);
                PageObject_SubmitBooking.SubmitBookingGuestLastName().SendKeys(GuestLastName);

                //Fill in the date booked.
                PageObject_SubmitBooking.SubmitBookingDateBooked().Click();
                AddDelay(2500);
                AMRCalendar(DateBookedMonth, DateBookedDay, DateBookedYear);
                AddDelay(1000);

                //Fill in the Travel Start Date.
                PageObject_SubmitBooking.SubmitBookingTravelStartDate().Click();
                AddDelay(2500);
                AMRCalendar(TravelStartMonth, TravelStartDay, TravelStartYear);
                AddDelay(2500);

                //Fill in the Travel End Date booked.
                PageObject_SubmitBooking.SubmitBookingTravelEndDate().Click();
                AddDelay(2500);
                AMRCalendar(TravelEndMonth, TravelEndDay, TravelEndYear);
                AddDelay(2000);
                PageObject_SubmitBooking.SubmitBookingBrand().SendKeys(Brand);
                AddDelay(3500);
                ElementSelectFromDropDown(PageObject_SubmitBooking.SubmitBookingResort(), Resort);
                AddDelay(3500);
                ElementClick(PageObject_SubmitBooking.SubmitBookingDepartureGateway1());
                AddDelay(2000);
                ElementSelectFromDropDownDownAndClick(PageObject_SubmitBooking.SubmitBookingDepartureGateway1(), DepartureGateway);
                PageObject_SubmitBooking.SubmitBookingAddToBookingSummary().Click();
                AddDelay(5000);

                //Verify the add to booking popup
                try
                {
                    if (Driver.FindElement(OpenQA.Selenium.By.Id("theDialogaredFieldCentent")).Text == Constants.SubmitBookingAddToBookingPopupText)
                    {
                        Logger.WriteDebugMessage("The confirmation popup displayed the correct message.");
                        PageObject_SubmitBooking.SubmitBookingPopupOKBtn().Click();
                        AddDelay(1000);
                    }
                    else
                        throw new Exception("The popup message did not display the correct confirmation message.");
                }
                catch (Exception e)
                {
                    Logger.WriteInfoMessage("Was Looking for: " + Constants.SubmitBookingAddToBookingPopupText);
                    Logger.WriteInfoMessage("But found: " + Driver.FindElement(OpenQA.Selenium.By.Id("theDialogaredFieldCentent")).Text);
                    Logger.WriteFatalMessage(e);
                    throw;
                }

                //7.Click "Submit"
                ScrollToElement(PageObject_SubmitBooking.SubmitBookingSubmit());
                PageObject_SubmitBooking.SubmitBookingSubmit().Click();
                AddDelay(7000);

                //Verify the "Submit" popup
                try
                {
                    if (Driver.FindElement(OpenQA.Selenium.By.Id("theDialogSB")).Text == Constants.SubmitBookingSubmittedSuccessfully)
                    {
                        Logger.WriteDebugMessage("The confirmation popup displayed the correct message.");
                        Driver.FindElement(OpenQA.Selenium.By.Id("confimationBtnSB")).Click();
                        //PageObject_SubmitBooking.SubmitBookingSubmitPopupOKBtn().Click();
                        AddDelay(1000);
                        Logger.WriteDebugMessage("Popup states 'The booking was submitted successfully.'");
                    }
                    else
                        throw new Exception("The popup message did not display the correct confirmation message.");
                }
                catch (Exception e)
                {
                    string message = Driver.FindElement(OpenQA.Selenium.By.Id("theDialogSB")).Text;
                    Logger.WriteInfoMessage("Was Looking for: " + Constants.SubmitBookingSubmittedSuccessfully);
                    Logger.WriteInfoMessage("But found: " + message);
                    Logger.WriteFatalMessage(e);
                    throw;
                }


                //8.Verify the booking submitted disply in Account Summary -> Not Yet Travelled  tab
                ScrollToElement(PageObject_AMRAgentsNav.AMRAgentsAccountSummary());
                PageObject_AMRAgentsNav.AMRAgentsAccountSummary().Click();
                AddDelay(2000);

                //Click "Not Yet Traveled"
                PageObject_AccountSummary.AccountSummaryNotYetTraveledTab().Click();
                AddDelay(2000);

                //Verify the booking is displayed and the correct data is displayed.
                try
                {
                    if (Driver.PageSource.Contains(bookingNum))
                    {
                        Logger.WriteDebugMessage("The booking submited is displayed correctly on the 'Not Yet Traveled' tab.");
                    }
                    else
                        throw new Exception("The submitted booking was not found on the 'Not Yet Traveled' tab.");
                }
                catch (Exception e)
                {
                    Logger.WriteFatalMessage(e);
                }

                AddDelay(5000);

                //9.login to admin portal https://traveladminloyaltyprogram.qa.cendyn.com/
                GotoAdminSite();
                AddDelay(1000);
                HandleUnSafeWindows();
                Logger.WriteInfoMessage("Landed on the Admin login page.");

                //Log in to Admin
                ValidAdminLogin();
                Logger.WriteDebugMessage("Logged into admin successfully.");
                AddDelay(10000);

                //10.Navigate to Manage Bookings -> Not Yet Traveled
                PageObject_AdminHome.AdminHomeManageBookings().Click();
                AddDelay(15000);
                Logger.WriteDebugMessage("user landed on page of under review list of all booking category");

                //11.click on Not yet traveled tab and search a booking that was submit previous
                PageObject_ManageBookings.AdminManageBookingsNotYetTraveledTab().Click();
                AddDelay(10000);

                //Verify the booking is displayed and the correct data is displayed.
                try
                {
                    if (Driver.PageSource.Contains(bookingNum))
                    {
                        Logger.WriteDebugMessage("The booking submited is displayed correctly on the 'Not Yet Traveled' tab.");
                    }
                    else
                        throw new Exception("The submitted booking was not found on the 'Not Yet Traveled' tab.");
                }
                catch (Exception e)
                {
                    Logger.WriteFatalMessage(e);
                }


            }

        }
        public static void TC_37550()
        {
            if (TestCaseId == Constants.TC_37550)
            {
                //1.Open  the URl https://travelagentloyaltyprogram.qa.cendyn.com/
                //2.Login to Loyalty portal  using the account credential 
                ValidLogin();
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.click on AMR Rewards link
                PageObject_AMRAgentsNav.AMRAgentsAMRewards().Click();
                AddDelay(2500);
                Logger.WriteDebugMessage("Landed on the AMRewards page.");

                //4.click on account summary link
                //5.click on summary booking page
                PageObject_AMRAgentsNav.AMRAgentsAccountSummary().Click();
                AddDelay(7500);
                Logger.WriteDebugMessage("Landed on the Account Summary page.");

                //6.select /click on the  booking number on booking summary screen
                ScrollToElement(PageObject_AccountSummary.AccountSummarySummaryBookingsNotYetTraveledBookingNo());
                PageObject_AccountSummary.AccountSummarySummaryBookingsNotYetTraveledBookingNo().Click();
                AddDelay(5000);
                Logger.WriteDebugMessage("Clicked the booking number.");

                //7.Click the "Submit" button.
                PageObject_AccountSummary.AccountSummaryNotYetTraveledSubmitBtn().Click();
                AddDelay(7500);
                Logger.WriteDebugMessage("a confirmation popup should be displayed 'The booking was submitted successfully'");
                //Validate the popup message.
                try
                {
                    if (Driver.FindElement(OpenQA.Selenium.By.Id("theDialogSB")).Text == Constants.SubmitBookingSubmittedSuccessfully)
                    {
                        Logger.WriteDebugMessage("The confirmation popup displayed the correct message.");
                    }
                    else
                        throw new Exception("The popup message did not display the correct confirmation message.");
                }
                catch (Exception e)
                {
                    Logger.WriteFatalMessage(e);
                    throw;
                }



            }
        }
        public static void TC_37553()
        {
            if (TestCaseId == Constants.TC_37553)
            {
                //1.Open  the URl https://travelagentloyaltyprogram.qa.cendyn.com/
                //2.Login to Loyalty portal  using the account credential 
                string BookingType, RoomNum, BookingMadeWith, BookingNumber, GuestFirstName, GuestLastName, DateBookedMonth, DateBookedDay, DateBookedYear, TravelStartMonth, TravelStartDay, TravelStartYear, TravelEndMonth, TravelEndYear,
                TravelEndDay, Brand, Resort, DepartureGateway;
                BookingType = TestData.ExcelData.TestDataReader.ReadData(1, "BookingType");
                RoomNum = TestData.ExcelData.TestDataReader.ReadData(1, "RoomNum");
                BookingMadeWith = TestData.ExcelData.TestDataReader.ReadData(1, "BookingMadeWith");
                BookingNumber = TestData.ExcelData.TestDataReader.ReadData(1, "BookingNumber");
                GuestFirstName = TestData.ExcelData.TestDataReader.ReadData(1, "GuestFirstName");
                GuestLastName = TestData.ExcelData.TestDataReader.ReadData(1, "GuestLastName");
                DateBookedMonth = TestData.ExcelData.TestDataReader.ReadData(1, "DateBookedMonth");
                DateBookedDay = TestData.ExcelData.TestDataReader.ReadData(1, "DateBookedDay");
                DateBookedYear = TestData.ExcelData.TestDataReader.ReadData(1, "DateBookedYear");
                TravelStartMonth = TestData.ExcelData.TestDataReader.ReadData(1, "TravelStartMonth");
                TravelStartDay = TestData.ExcelData.TestDataReader.ReadData(1, "TravelStartDay");
                TravelStartYear = TestData.ExcelData.TestDataReader.ReadData(1, "TravelStartYear");
                TravelEndMonth = TestData.ExcelData.TestDataReader.ReadData(1, "TravelEndMonth");
                TravelEndDay = TestData.ExcelData.TestDataReader.ReadData(1, "TravelEndDay");
                TravelEndYear = TestData.ExcelData.TestDataReader.ReadData(1, "TravelEndYear");
                Brand = TestData.ExcelData.TestDataReader.ReadData(1, "Brand");
                Resort = TestData.ExcelData.TestDataReader.ReadData(1, "Resort");
                DepartureGateway = TestData.ExcelData.TestDataReader.ReadData(1, "DepartureGateway");
                ValidLogin();
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Click AMRewards
                PageObject_AMRAgentsNav.AMRAgentsAMRewards().Click();
                AddDelay(2500);
                Logger.WriteDebugMessage("Landed on the AMRewards page.");

                //4.Click "Submit Booking".
                PageObject_AMRAgentsNav.AMRAgentsSubmitBooking().Click();
                Logger.WriteDebugMessage("Landed on the 'Submit Booking' page.");
                AddDelay(7500);

                //5.Enter test information
                ScrollToElement(PageObject_SubmitBooking.SubmitBookingIndividualRadioButton());
                PageObject_SubmitBooking.SubmitBookingIndividualRadioButton().Click();
                AddDelay(2000);
                PageObject_SubmitBooking.SubmitBookingBookingMadeWith().SendKeys(BookingMadeWith);
                AddDelay(2000);
                PageObject_SubmitBooking.SubmitBookingBookingNumber().SendKeys(Constants.ExistingBookingNumber_TC37553);
                AddDelay(2000);
                PageObject_SubmitBooking.SubmitBookingGuestFirstName().SendKeys(GuestFirstName);
                AddDelay(2000);
                PageObject_SubmitBooking.SubmitBookingGuestLastName().SendKeys(GuestLastName);

                //Fill in the date booked.
                PageObject_SubmitBooking.SubmitBookingDateBooked().Click();
                AddDelay(2500);
                AMRCalendar(DateBookedMonth, DateBookedDay, DateBookedYear);
                AddDelay(1000);

                //Fill in the Travel Start Date.
                PageObject_SubmitBooking.SubmitBookingTravelStartDate().Click();
                AddDelay(2500);
                AMRCalendar(TravelStartMonth, TravelStartDay, TravelStartYear);
                AddDelay(2500);

                //Fill in the Travel End Date booked.
                PageObject_SubmitBooking.SubmitBookingTravelEndDate().Click();
                AddDelay(2500);
                AMRCalendar(TravelEndMonth, TravelEndDay, TravelEndYear);
                AddDelay(2000);
                PageObject_SubmitBooking.SubmitBookingBrand().SendKeys(Brand);
                AddDelay(3500);
                ElementSelectFromDropDown(PageObject_SubmitBooking.SubmitBookingResort(), Resort);
                AddDelay(3500);
                ElementClick(PageObject_SubmitBooking.SubmitBookingDepartureGateway1());
                AddDelay(2000);
                ElementSelectFromDropDownDownAndClick(PageObject_SubmitBooking.SubmitBookingDepartureGateway1(), DepartureGateway);
                AddDelay(2500);

                //Click "Add to Booking"
                PageObject_SubmitBooking.SubmitBookingAddToBookingSummary().Click();
                AddDelay(2000);
                PageObject_SubmitBooking.SubmitBookingPopupOKBtn().Click();
                AddDelay(1000);
                Logger.WriteDebugMessage("All entered and selected bind with the right data");

                //6.Click on submit button
                PageObject_SubmitBooking.SubmitBookingSubmit().Click();
                AddDelay(10000);
                Logger.WriteDebugMessage("confirmation pop up should be displayed 'Booking Number currently exists and is not eligible for reentry'");
            }

        }
        public static void TC_37604()
        {
            if (TestCaseId == Constants.TC_37604)
            {
                //1.Open the URl https://travelagentloyaltyprogram.qa.cendyn.com/
                //2.login with valid id and password (us/Canada) country
                ValidLogin();
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
                {
                    Logger.WriteInfoMessage("Did not land on the 'Points History' page.");
                    Logger.WriteInfoMessage("Was looking for: POINTS HISTORY");
                    Logger.WriteFatalMessage("But found: " + Driver.FindElement(OpenQA.Selenium.By.Id("point-history")).Text);
                    Assert.Fail();
                }

                //Go back to AMRewards
                PageObject_AMRAgentsNav.AMRAgentsAMRewards().Click();
                AddDelay(2500);
                Logger.WriteInfoMessage("Landed back on the AMRewards page.");

                //5.Click "Rules and Regulations"
                OpenPopUpWindow(PageObject_AMRewards.AMRewardsRulesAndRegulations());
                Logger.WriteDebugMessage("Rules and Regulations PDF is displayed or downloaded.");
                AddDelay(2500);
                ClosePopUpWindow();

                //6. Click "Total Points Available"
                PageObject_AMRewards.AMRewards_TotalPointsAvailable().Click();
                AddDelay(2500);

                if (ValidatePageURL(Constants.AMRewardsPointsAvailableURL_TC37604))
                    Logger.WriteDebugMessage("Landed on the Account Summary page.");
                else
                {
                    Logger.WriteFatalMessage("Did not land on the correct page.");
                    Assert.Fail();
                }

                //Go back to AMRewards
                PageObject_AMRAgentsNav.AMRAgentsAMRewards().Click();
                AddDelay(5000);
                Logger.WriteInfoMessage("Landed back on the AMRewards page.");

                //7. Click "Total Points Redeemed"
                PageObject_AMRewards.AMRewards_TotalPointsRedeemed().Click();
                AddDelay(2500);

                if (ValidatePageURL(Constants.AMRewardsPointsRedeemedURL_TC37604))
                    Logger.WriteDebugMessage("Landed on the Redemption Request page.");
                else
                {
                    Logger.WriteFatalMessage("Did not land on the correct page.");
                    Assert.Fail();
                }

                //Go back to AMRewards
                PageObject_AMRAgentsNav.AMRAgentsAMRewards().Click();
                AddDelay(5000);
                Logger.WriteInfoMessage("Landed back on the AMRewards page.");

                //8. Click "Total Points Redeemed"
                PageObject_AMRewards.AMRewards_TotalPointsExpiring().Click();
                AddDelay(2500);

                if (ValidatePageURL(Constants.AMRewardsPointsExpiringURL_TC37604))
                    Logger.WriteDebugMessage("Landed on the Points Received page.");
                else
                {
                    Logger.WriteFatalMessage("Did not land on the correct page.");
                    Assert.Fail();
                }



            }
        }
        public static void TC_37609()
        {
            if (TestCaseId == Constants.TC_37609)
            {
                //1.Open the URl https://travelagentloyaltyprogram.qa.cendyn.com/
                //2.Login with valid id and password (us/Canada) country
                string Country, Providence, Address, City, Zip, IATA;
                Country = TestData.ExcelData.TestDataReader.ReadData(1, "Country");
                Providence = TestData.ExcelData.TestDataReader.ReadData(1, "Providence");
                Address = TestData.ExcelData.TestDataReader.ReadData(1, "Address");
                City = TestData.ExcelData.TestDataReader.ReadData(1, "City");
                Zip = TestData.ExcelData.TestDataReader.ReadData(1, "Zip");
                IATA = TestData.ExcelData.TestDataReader.ReadData(1, "IATA");
                AddDelay(2000);
                PageObject_Login.LoginRegisterNow().Click();
                string email1 = Registration.EmailNow();
                Registration.DefaultEmailPassSecurity(email1);
                Registration.DefaultPersonalInformationSelectCountry(Country, Providence, Address, City, Zip);
                AddDelay(1000);
                Registration.EnterIATA(IATA);
                Registration.DefaultAgentType();
                Registration.ConfirmSuccessfulRegistration();
                Logger.WriteDebugMessage("Logged in successfully.");
                AddDelay(2000);
                Registration.ConfirmRegistrationOnAdmin();
                Driver.Navigate().GoToUrl(Constants.Common_FrontendURL);
                ParameterizedLogin(email1, Constants.CommonPassword());

                //3.Click on update profile  link
                PageObject_AMRAgentsNav.AMRAgentsUpdateProfile().Click();
                AddDelay(5000);
                Logger.WriteDebugMessage("user navigate to agent profile update screen");

                //4.click on link of Identification Number and Certification(Form W-9)_ click here to complte
                Logger.WriteDebugMessage(" IDENTIFICATION NUMBER AND CERTIFICATION screen page should be extended");

            }
        }
        public static void TC_37649()
        {
            if (TestCaseId == Constants.TC_37649)
            {
                //1.Open the URl https://travelagentloyaltyprogram.qa.cendyn.com/
                //2.Click on Register button 
                string Country, Providence, Address, City, Zip, IATA;
                Country = TestData.ExcelData.TestDataReader.ReadData(1, "Country");
                Providence = TestData.ExcelData.TestDataReader.ReadData(1, "Providence");
                Address = TestData.ExcelData.TestDataReader.ReadData(1, "Address");
                City = TestData.ExcelData.TestDataReader.ReadData(1, "City");
                Zip = TestData.ExcelData.TestDataReader.ReadData(1, "Zip");
                IATA = TestData.ExcelData.TestDataReader.ReadData(1, "IATA");

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

                //Confirm the successful registration using the IATA code
                Registration.ConfirmSuccessfulRegistration();
                Logger.WriteDebugMessage("Successfully created and confirmed a new registration using an IATA code.");

                //4.Click on Register button
                //5.Click on OK button   
                //6.After Registration when user first lands on the AMREWARDS page ,verfiy the welcome popup
                //7.Select the Check box and click on Accept button 
                Registration.ConfirmRegistrationOnAdmin();
                Logger.WriteDebugMessage("Confirmed the registered user is validated on the admin site when selecting Canada and using an IATA code.");

                //Verify thanks you email generated  and is available in webmail.cendyn.com: Login to Webmail.cendyn.com Search for agent email address
                Driver.Navigate().GoToUrl("https://outlook.office365.com/owa/?realm=cendyn17.com&exsvurl=1&ll-cc=1033&modurl=0");
                AddDelay(2500);
                Hotmail.NavigateAndLogIntoCatchAll();
                AddDelay(15000);
                Hotmail.SearchEmailAndOpenLatestEmail(email1);
                VerifyTextOnPage(Constants.WelcomeEmailSubject);
                AddDelay(2500);
                Logger.WriteDebugMessage("successfully  received email on webmail.cendyn.com and all details are correct");

            }
        }
    }
}
