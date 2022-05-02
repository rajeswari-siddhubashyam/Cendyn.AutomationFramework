using System;
using eProposal.Utility;
using eProposal.AppModule.UI;
using Common;
using Constants = eProposal.Utility.Constants;
using InfoMessageLogger;
using BaseUtility.Utility;
using TestData;
using SqlWarehouse;
using OpenQA.Selenium;
using NUnit.Framework;
using eProposal.AppModule.UI;
using eProposal.AppModule.Admin;
using eProposal.PageObject.UI;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Interactions;

namespace eProposal.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        #region[TP_84293]
        #region[TC_120442]

        public static void TC_120442()
        {
            //1 Log into eProposal
            //EmployeeLogin.CommonLogin();
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select test property and assign the property type
            EmployeeHome.SelectProperty(propertyName);
            PropertyType = Constants.PropertyType_Regular;
            AddDelay(8000);
            Logger.WriteDebugMessage("Selected the property: " + propertyName);

            //3 Navigate to the eProposal Compose page.
            EmployeeHome.Click_CreateEdit_eProposalButton();
            Logger.WriteDebugMessage("Landed on the ePropsal Compose page.");

            //4 Fill in all required fields. 
            eProposalCompose.CommonRequiredFields();
            Logger.WriteDebugMessage("All required fields are entered.");

            //13 Confirm the room and event block pages start with the "Event Date".
            eProposalCompose.ValidateEventDatesOnRoomAndEventBlock();
            Logger.WriteDebugMessage("The room and event block pages are displaying the event dates correctly!");
        }

        #endregion[TC_120442]

        #region[TC_120443]

        public static void TC_120443()
        {
            //Pre-Reqs: Make sure the property has the "Use My Favorite Settings" turn on from admin.
            PreReqs.TC_120443(propertyName);
            Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL);
            //1 Log into eProposal
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select test property and assign the property type
            EmployeeHome.SelectProperty(propertyName);
            PropertyType = Constants.PropertyType_Regular;
            Logger.WriteDebugMessage("Selected the property: " + propertyName);

            //3 Navigate to the eProposal Compose page.
            EmployeeHome.Click_CreateEdit_eProposalButton();
            Logger.WriteDebugMessage("Landed on the ePropsal Compose page.");

            //4 Fill in all required fields. 
            eProposalCompose.CommonRequiredFields3();
            eProposalCompose.SelectExpirationDate2_3(0);
            Logger.WriteDebugMessage("All required fields are entered.");

            //5 Enter and make note of the Welcome Message
            eProposalCompose.EnterWelcomeMessage(MakeUnique("Welcome Message"));
            var welcomeMessage = eProposalCompose.GetWelcomeMessage();
            eProposalCompose.Click_Button_Next();

            //6 Reach the Room Block page.
            if (Project.IsStep2Select())
                eProposalSelect.Click_Button_Next();
            Logger.WriteDebugMessage("Landed on the Room Block page.");

            //7 Enter a room block intro and make note of it
            eProposalCendynRoomBlock.EnterRoomBlockIntroText(MakeUnique("Room Block Introduction"));
            var roomIntroMessage = eProposalCendynRoomBlock.GetRoomBlockIntro();

            //8 Enter a room block Welcome Message and make note of it.
            eProposalCendynRoomBlock.EnterRoomBlockComments(MakeUnique("Room Block Comments"));
            var roomBlockMessage = eProposalCendynRoomBlock.GetRoomBlockComments();

            //9 Reach the "Event Block" 
            eProposalCendynRoomBlock.Click_Button_Next();
            Logger.WriteDebugMessage("Landed on the Event Block page.");

            //10 Enter an event block message and make note of it.
            eProposalCendynEventBlock.EnterEventBlockComments(MakeUnique("Event Block Comments"));
            var eventBlockMessage = eProposalCendynEventBlock.GetEventBlockComments();

            //11 Reach step 5
            if (Project.IsThisStep4(Constants.EVENTBLOCK))
            {
                eProposalCendynEventBlock.Click_Button_Next();
            }
            else
            {
                eProposalCendynEventBlock.Click_Button_Next();
                eProposalSelect.Click_Button_Next();
            }
            Logger.WriteDebugMessage("eProposal preview is opened in a new window or tab.");

            //12 Close the preview popup.
            eProposalPreview.ClosePreview();
            Logger.WriteDebugMessage("Closed the eProposal preview.");

            //13 Click "Save as My Favorite"
            eProposalPreview.Select_CheckBox_SaveAsMyFavorite();
            Logger.WriteDebugMessage("Selected Save As My Favorite");
            eProposalPreview.Click_Button_Send();

            //14 Navigate back to the "eProposal -> Compose" page.
            EmployeeHome.Click_WelcomeButton();
            EmployeeHome.Click_CreateEdit_eProposalButton();
            Logger.WriteDebugMessage("Landed on the ePropsal Compose page.");

            //15 Fill in all required fields
            eProposalCompose.CommonRequiredFields3();
            eProposalCompose.SelectExpirationDate2_3(0);
            Logger.WriteDebugMessage("All required fields are entered.");

            //16 Select "Use my Favorite Settings"
            eProposalCompose.Select_CheckBox_UseMyFavoriteSettings();
            Logger.WriteDebugMessage("Selected the Use My Favorite Settings checkbox.");

            //17 Verify the "Welcome Message" comments display and match the comments of the previous eProposal.
            eProposalCompose.ValidateWelcomeMessageComments(welcomeMessage);
            eProposalCompose.Click_Button_Next();
            //Long delay is due to issue with ePFull taking a long time to load when using My Favorite Setting
            AddDelay(60000);
            Logger.WriteDebugMessage("The Welcome Message comments matched the saved text.");

            //18 Verify the "Room Block Introduction" comments display and match the comments of the previous eProposal.
            if (Project.IsStep2Select())
                eProposalCompose.Click_Button_Next();
            //eProposalCendynRoomBlock.ValidateRoomBlockIntroductionComments(roomIntroMessage);
            //Logger.WriteDebugMessage("The Room Block Introduction comments matched the saved text.");

            //19 Verify the "Room Block Comments" comments display and match the comments of the previous eProposal.
            AddDelay(10000);
            eProposalCendynRoomBlock.ValidateRoomBlockComments(roomBlockMessage);
            Logger.WriteDebugMessage("The Room Block Comments comments matched the saved text.");
            eProposalCendynRoomBlock.Click_Button_Next();

            //20 Verify the "Event Block Comments" comments display and match the comments of the previous eProposal.
            eProposalCendynEventBlock.ValidateEventBlockComments(eventBlockMessage);
            Logger.WriteDebugMessage("The Event Block comments matched the saved text.");
        }

        #endregion[TC_120443]

        #region[TC_120446]

        public static void TC_120446()
        {
            //1 Log into eProposal
            //EmployeeLogin.CommonLogin();
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select test property and assign the property type
            EmployeeHome.SelectProperty(propertyName);
            PropertyType = Constants.PropertyType_Regular;
            Logger.WriteDebugMessage("Selected the property: " + propertyName);

            //3 Navigate to the "Settings -> Stored Content" page.
            EmployeeHome.Click_Link_UpdateMySettings();
            Settings.Click_Tab_StoredContent();
            Logger.WriteDebugMessage("Landed on the Stored Content page.");

            //Check if the property has stored content for the Welcome Message
            if (Settings_StoredContent.IsThereStoredContent())
            {
                //4 Make note of each title and content.
                //Get the total number of stored content
                var totalContent = Settings_StoredContent.CountContent();

                var contentTitle = new string[totalContent];
                var contentContent = new string[totalContent];

                for (var i = 0; i < totalContent; i++)
                {
                    contentTitle[i] = Settings_StoredContent.GetContentTitle(i + 1);
                    contentContent[i] = Settings_StoredContent.GetContent(i + 1);
                }

                Logger.WriteDebugMessage("Content and title are noted.");

                //5 Click "Create/Edit -> eProposal"
                EmployeeHome.Click_WelcomeButton();
                EmployeeHome.Click_CreateEdit_eProposalButton();
                Logger.WriteDebugMessage("Land on the Compose page.");

                //6 Click the blue url's beneath the "Welcome Message" and verify they match the stored content.
                for (var i = 0; i < totalContent; i++)
                    eProposalCompose.ValidateStoredContent(i + 1, contentTitle[i], contentContent[i]);

                Logger.WriteDebugMessage(
                    "Each text displays the content in the Welcome Message that was previously noted.");
            }
            else
            {
                Logger.WriteDebugMessage("There is no stored content for this property: " +
                                         propertyName);
            }
        }

        #endregion[TC_120446]

        #region[TC_120447]

        public static void TC_120447()
        {
            //Pre-reqs: Turn on the Room on Welcome setting from Admin
            PreReqs.TC_120447(propertyName);

            //1 Log into eProposal
            Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL);
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select test property and assign the property type
            EmployeeHome.SelectProperty(propertyName);
            PropertyType = Constants.PropertyType_Regular;
            Logger.WriteDebugMessage("Selected the property: " + propertyName);

            //3 Navigate to the eProposal Compose page.
            EmployeeHome.Click_CreateEdit_eProposalButton();
            Logger.WriteDebugMessage("Landed on the ePropsal Compose page.");

            //4 Make sure the "Include your offer at the bottom of the welcome letter." is displayed and is selected.
            eProposalCompose.VerifyRoomOnWelcomeSettingOn();
            eProposalCompose.VerifyRoomOnWelcomeSelectedOn();
        }

        #endregion[TC_120447]

        #region[TC_120454]

        public static void TC_120454()
        {
            //1 Log in an eP Full.
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select a single-language property from the drop down.
            EmployeeHome.SelectProperty(singleLanguageProperty);
            Logger.WriteDebugMessage("Single language property selected: " +
                                     singleLanguageProperty);

            //3 Click "Create/Edit -> eProposal".
            EmployeeHome.Click_CreateEdit_eProposalButton();
            Logger.WriteDebugMessage("Land on the eProposal Compose page.");

            //4 Verify the language is displayed as a label.
            eProposalCompose.VerifySingleLanguageLabel();
            Logger.WriteDebugMessage("The language is displayed as a label.");

            //5 Hoover over the "Language" "tooltip" icon.
            eProposalCompose.VerifySingleLanguageToolTip();
            Logger.WriteDebugMessage("'This module is only available in one language' message is displayed.");
        }

        #endregion[TC_120454]

        #region[TC_123287]

        public static void TC_123287()
        {
            //1 Log into eProposal
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select test property and assign the property type
            EmployeeHome.SelectProperty(propertyName);
            PropertyType = Constants.PropertyType_Regular;
            Logger.WriteDebugMessage("Selected the property: " + propertyName);

            //Obtain the employee name
            EmployeeHome.GetEmployeeFirstName();

        }

        #endregion[TC_123287]

        #region[TC_84289]
        public static void TC_84289()
        {
            //1 Log into eProposal through the employee login page.
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select any property from the property drop down.
            string Property = "Cendyn – DEV - BBQ HIlton";
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);

            //3.Click "Create/Edit -> eProposal"
            EmployeeHome.Click_CreateEdit_eProposalButton();
            AddDelay(6000);
            Logger.WriteDebugMessage("Land on the Compose page.");

            //4.Fill in all required eProposal information on this step but do NOT click "Next"
            eProposalCompose.CommonRequiredFields2();
            Logger.WriteDebugMessage("Information is filled in.");

            //5.Change the "Proposal Expires On" to a date BEFORE the current date.
            //eProposalCompose.SelectProposalExpiresBeforeCurrentDate();

            //6.Change the "Proposal Expires On" to a date AFTER the "Event Date" date.
            //eProposalCompose.SelectDateAftereventdate();
            AddDelay(2500);

            //7.Without correcting the date, click "Next".
            ScrollUpUsingJavaScript(Driver, 2500);
            AddDelay(1500);
            eProposalCompose.Click_Button_Next();
            eProposalCompose.VerifyExpirationError();

            //8.Select a date BEFORE the "Event Date".
            eProposalCompose.SelectExpirationDate2_2(0);
            Logger.WriteDebugMessage("Date is selected and displayed. The error message is removed.");

            //9.Click "Next"
            eProposalCompose.Click_Button_Next();
            Logger.WriteDebugMessage("Land on the next step.");
        }

        #endregion[TC_84289]

        #region[TC_84277]
        public static void TC_84277()
        {
            //1 Log into eProposal through the employee login page.
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select any property from the property drop down.
            EmployeeHome.SelectProperty(propertyName);
            Logger.WriteDebugMessage("Selected the property: " + propertyName);

            //3.Click "Create/Edit -> eProposal"
            EmployeeHome.Click_CreateEdit_eProposalButton();
            AddDelay(6000);
            Logger.WriteDebugMessage("Land on the Compose page.");

            //4.Fill in all required eProposal information on this step but do NOT click "Next"
            eProposalCompose.CommonRequiredFields();
            Logger.WriteDebugMessage("Information is filled in.");

            //5. Change the "Event Date" to a date before the current date.
            eProposalCompose.SelectEventDate2(1);

            //6.Change the "Event Date" to a date BEFORE the "Proposal Expires On" date.
            eProposalCompose.SelectExpirationDate2(1);
            Logger.WriteDebugMessage("The expiration date is set to after the event date.");
            AddDelay(2500);

            //7.Without correcting the date, click "Next".
            ScrollUpUsingJavaScript(Driver, 2500);
            AddDelay(1500);
            eProposalCompose.Click_Button_Next();
            eProposalCompose.VerifyExpirationError();

            //8.Select an expiration date BEFORE the "Event Date".
            eProposalCompose.EnterText_ProposalNameText(CommonMethod.TestCaseId + " - " + DateTime.Now.ToString(@"MMdd") + " " + thisDay.Hour + thisDay.Minute + "(2)");
            ScrollUpUsingJavaScript(Driver, -2500);
            eProposalCompose.SelectEventDate2(0);
            eProposalCompose.SelectExpirationDate2(0);
            Logger.WriteDebugMessage("Date is selected and displayed. The error message is removed.");

            //9.Click "Next"
            //10. Confirm the room and event block pages start with the "Event Date".
            eProposalCompose.Click_Button_Next();
            Logger.WriteDebugMessage("Land on the next step.");
        }

        #endregion[TC_84277]

        #region[TC_84288]
        public static void TC_84288()
        {
            //1 Log into eProposal through the employee login page.
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select any property from the property drop down.
            string Property = "Cendyn – DEV - BBQ HIlton";
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);

            //3.Click "Create/Edit -> eProposal"
            EmployeeHome.Click_CreateEdit_eProposalButton();
            AddDelay(6000);
            Logger.WriteDebugMessage("Land on the Compose page.");

            //4. Click the "Add Client's Logo" link.
            eProposalCompose.Click_UploadLogoLink();
            Logger.WriteDebugMessage("Popup displays to 'Choose File', 'Upload' and 'Cancel'.");

            //5. Click "Choose File" and select a valid image file.
            eProposalCompose.UploadClientLogo();
            Logger.WriteDebugMessage("File is attached.");

            //6.Click "Upload"
            eProposalCompose.Click_Button_Upload();
            Logger.WriteDebugMessage("File is uploaded, re-sized and is now displayed on the page.");

            //7.Finish filling out the eProposal and reach "Step 5". Use your email as the "Client".
            eProposalCompose.CommonComposeMandetory(eproposalName, ClientName);
            eProposalCompose.Click_Button_Next();
            AddDelay(2500);
            eProposalCompose.Click_Button_Next();
            AddDelay(2500);
            eProposalCompose.Click_Button_Next();
            AddDelay(2500);
            ControlToNewWindow();

            //8. Verify the logo displays above the "Welcome Letter".
            eProposalCompose.ClientLogoIsDisplayed();
            CloseWindow();
            ControlToPreviousWindow();

            //9.Click "Send"
            eProposalPreview.Click_Button_Send();
            Logger.WriteDebugMessage("eProposal is emailed to the 'Client'.");

            //10.Open the email and click the "Open eProposal" link.
            Login.AutoAcc_login("", 1, 0);
            Logger.WriteDebugMessage("The email is opened.");
            ClientEmail.Click_Link_OpenYourProposal();
            ControlToNewWindow();
            AddDelay(3000);

            //11. Verify the logo displays above the "Welcome Letter".
            eProposalCompose.ClientLogoIsDisplayed();
        }

        #endregion[TC_84288]

        #region[TC_84287]
        public static void TC_84287()
        {
            //1 Log into eProposal through the employee login page.
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select any property from the property drop down.
            string Property = "Cendyn – DEV - BBQ HIlton";
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);

            //3.Click "Create/Edit -> eProposal"
            EmployeeHome.Click_CreateEdit_eProposalButton();
            AddDelay(6000);
            Logger.WriteDebugMessage("Land on the Compose page.");

            //4.Enter any small message in the "Message Closing" text box.
            eProposalCompose.EnterText_MessageClosingText(MessageClosing);
            Logger.WriteDebugMessage("Message is entered.");

            //5.Finish filling out the eProposal and reach "Step 5". Use your email as the "Client".
            eProposalCompose.CommonComposeMandetory(eproposalName, ClientName);
            eProposalCompose.Click_Button_Next();
            AddDelay(2500);
            eProposalCompose.Click_Button_Next();
            AddDelay(2500);
            eProposalCompose.Click_Button_Next();
            AddDelay(2500);
            ControlToNewWindow();

            //6.On the eProposal, verify the "Closing Message" you entered is displayed above the employee signature.
            eProposalCompose.VerifyClosingMessageIsDiplayed();
            CloseWindow();
            ControlToPreviousWindow();

            //7.Click "Send"
            eProposalPreview.Click_Button_Send();
            Logger.WriteDebugMessage("eProposal is emailed to the 'Client'.");

            //8.Open the email and click the "Open eProposal" link.
            Login.AutoAcc_login(Constants.TC_84287, 1, 0);
            Logger.WriteDebugMessage("The email is opened.");
            ClientEmail.Click_Link_OpenYourProposal();
            ControlToNewWindow();
            AddDelay(3000);

            //9. On the eProposal, verify the "Closing Message" you entered is displayed above the employee signature.
            eProposalCompose.VerifyClosingMessageIsDiplayed();

        }

        #endregion[TC_84277]           

        #region[TC_84274]

        public static void TC_84274()
        {
            //1 Log into eProposal through the employee login page.
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select any property from the property drop down.
            EmployeeHome.SelectProperty(propertyName);
            Logger.WriteDebugMessage("Selected the property: " + propertyName);

            //3.Click "Create/Edit -> eProposal"
            EmployeeHome.Click_CreateEdit_eProposalButton();
            AddDelay(6000);
            Logger.WriteDebugMessage("Land on the Compose page.");

            //4.Enter any small message in the "Message Closing" text box.
            eProposalCompose.EnterText_MessageClosingText("Test message closing");
            Logger.WriteDebugMessage("Message is entered.");

            //5.Finish filling out the eProposal and reach "Step 5". Use your email as the "Client".
            eProposalCompose.CommonRequiredFields();
            eProposalCompose.SelectExpirationDate2(0);
            eProposalCompose.EnterText_ProposalNameText("");
            eProposalCompose.Click_Button_Next();
            string getErrorMessageLable = Driver.FindElement(By.Id("ctl00_ctl00_MainContent_MainContent_vsCreateProposal")).Text;
            string requiredMessage = "eProposal Name is required";
            bool isTrue = getErrorMessageLable.Contains(requiredMessage);
            if (isTrue.Equals(true))
            {
                Logger.WriteDebugMessage("eProposal Name cannot be blank.");
            }
            else
            {
                Assert.Fail("Blank eProposal Name was allowed.");
            }
            eProposalCompose.EnterText_ProposalNameText("Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium.");
            Logger.WriteDebugMessage("Entered 250 character in eProposal Name textbox. And Clicking on Next Button.");
            eProposalCompose.Click_Button_Next();
            if (VerifyTextOnPage("Select the pages you would like to include with your proposal:"))
            {
                Logger.WriteDebugMessage("Landed on Second Page after entering 250 characters of Proposal Name");
            }
            else
            {
                Assert.Fail("Did not land on Second Page after entering 250 characters of Proposal Name");
            }

        }
        #endregion[TC_84274]

        #region[TC_84272]
        public static void TC_84272()
        {
            //1 Log into eProposal through the employee login page.
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select any property from the property drop down.
            EmployeeHome.SelectProperty(propertyName);
            Logger.WriteDebugMessage("Selected the property: " + propertyName);

            //3.Click "Create/Edit -> eProposal"
            EmployeeHome.Click_CreateEdit_eProposalButton();
            AddDelay(6000);
            Logger.WriteDebugMessage("Land on the Compose page.");

            //4.Enter any small message in the "Message Closing" text box.
            eProposalCompose.EnterText_MessageClosingText("Test message closing");
            Logger.WriteDebugMessage("Message is entered.");

            //5.Finish filling out the eProposal and reach "Step 5". Use your email as the "Client".
            //eProposalCompose.CommonComposeMandetory(eproposalName, ClientName);
            eProposalCompose.CommonRequiredFields();
            eProposalCompose.SelectExpirationDate2(0);
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollBy(0,500)", "");
            Logger.WriteDebugMessage("Current Language is English");
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollBy(0,-1000)", "");
            string languageDropdown = "//select[@name='ctl00$ctl00$MainContent$MainContent$ddPropertyLanguages']";
            string selectlanguage = languageDropdown + "/option[contains(text(),'Chinese')]";
            AddDelay(1500);
            //Driver.FindElement(By.XPath(languageDropdown)).Click();
            //AddDelay(1000);
            //Driver.FindElement(By.XPath(selectlanguage)).Click();
            //((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollBy(0,800)", "");
            //Logger.WriteDebugMessage("Current Language is Chinese");

        }
        #endregion[TC_84272]

        #region[TC_84276]
        public static void TC_84276()
        {
            //1 Log into eProposal through the employee login page.
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select any property from the property drop down.
            string Property = "Cendyn – DEV - BBQ HIlton";
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);

            //3.Click "Create/Edit -> eProposal"
            EmployeeHome.Click_CreateEdit_eProposalButton();
            AddDelay(6000);
            Logger.WriteDebugMessage("Land on the Compose page.");

            //4.Enter any small message in the "Message Closing" text box.
            eProposalCompose.EnterText_MessageClosingText("Testing Closing Message");
            Logger.WriteDebugMessage("Message is entered.");

            //5.Finish filling out the eProposal and reach "Step 5". Use your email as the "Client".
            eProposalCompose.CommonRequiredFields2();
            eProposalCompose.SearchForClient(LegacyTestData.CommonEmployeeEmail);
            eProposalCompose.SelectExpirationDate2_2(0);
            Logger.WriteDebugMessage("All required fields are entered.");
            ElementEnterText(Driver.FindElement(By.Id("ctl00_ctl00_MainContent_MainContent_txtBccClient")), "catchall@cendyn17.com");
            Logger.WriteDebugMessage("Added write BCC email address");
            eProposalCompose.Click_Button_Next();
            AddDelay(2500);
            eProposalCompose.Click_Button_Next();
            AddDelay(2500);
            eProposalCompose.Click_Button_Next();
            AddDelay(2500);
            eProposalCompose.Click_Button_Next();
            AddDelay(2500);
            ControlToNewWindow();

            //6.On the eProposal, verify the "Closing Message" you entered is displayed above the employee signature.
            eProposalCompose.VerifyClosingMessageIsDiplayed();
            CloseWindow();
            ControlToPreviousWindow();

            //7.Click "Send"
            eProposalPreview.Click_Button_Send();
            Logger.WriteDebugMessage("eProposal is emailed to the 'Client'.");

            //8.Open the email and click the "Open eProposal" link.
            Helper.OpenNewTab();
            ControlToNewWindow();
            Login.AutoAcc_login(Constants.TC_84276, 1, 0);
            Logger.WriteDebugMessage("The email is opened.");
            ControlToNewWindow();
            AddDelay(3000);
            Login.AccountLogout();
            AddDelay(5000);
            Helper.OpenNewTab();
            ControlToNewWindow();
            Login.AutoAcc_login(Constants.TC_84276, 2, 0);
            Logger.WriteDebugMessage("The email is opened in BCC account");

            ControlToNewWindow();
            AddDelay(3000);

        }
        #endregion[84276]

        #region[TC_84275]
        public static void TC_84275()
        {
            //1 Log into eProposal through the employee login page.
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select any property from the property drop down.
            EmployeeHome.SelectProperty(propertyName);
            Logger.WriteDebugMessage("Selected the property: " + propertyName);

            //3.Click "Create/Edit -> eProposal"
            EmployeeHome.Click_CreateEdit_eProposalButton();
            AddDelay(6000);
            Logger.WriteDebugMessage("Land on the Compose page.");

            //4.Enter any small message in the "Message Closing" text box.
            eProposalCompose.EnterText_MessageClosingText("Testing Closing Message");
            Logger.WriteDebugMessage("Message is entered.");

            //5.Finish filling out the eProposal and reach "Step 5". Use your email as the "Client".
            eProposalCompose.CommonComposeMandetory(eproposalName, ClientName);
            eProposalCompose.Click_Button_Next();
            AddDelay(2500);
            eProposalCompose.Click_Button_Next();
            AddDelay(2500);
            eProposalCompose.Click_Button_Next();
            AddDelay(2500);
            ControlToNewWindow();

            //6.On the eProposal, verify the From Name you entered is displayed above the employee signature.
            if (VerifyTextOnPage("Cendyn") && VerifyTextOnPage("Automation"))
            {
                Logger.WriteDebugMessage("Found From Name.");
            }
            else
            {
                Assert.Fail("From Name not found.");
            }
        }
        #endregion[TC_84275]

        #region[TC_84273]
        public static void TC_84273()
        {
            //1 Log into eProposal through the employee login page.
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select any property from the property drop down.
            EmployeeHome.SelectProperty(propertyName);
            Logger.WriteDebugMessage("Selected the property: " + propertyName);

            //3.Click "Create/Edit -> eProposal"
            EmployeeHome.Click_CreateEdit_eProposalButton();
            AddDelay(6000);
            Logger.WriteDebugMessage("Land on the Compose page.");

            string selCurrentProposal = "//select[@id='ctl00_ctl00_MainContent_MainContent_cboSelCurrentProposal']";
            string proposalDropDown = selCurrentProposal + "/option[3]";
            ElementClick(Driver.FindElement(By.XPath(selCurrentProposal)));
            ElementClick(Driver.FindElement(By.XPath(proposalDropDown)));
            string selecteddropdpwn = Driver.FindElement(By.XPath(proposalDropDown)).Text;
            Logger.WriteDebugMessage("Select option as " + selecteddropdpwn);
            proposalDropDown = selCurrentProposal + "/option[1]";
            ElementClick(Driver.FindElement(By.XPath(proposalDropDown)));
            selecteddropdpwn = Driver.FindElement(By.XPath(proposalDropDown)).Text;
            Logger.WriteDebugMessage("Select option as " + selecteddropdpwn);
        }
        #endregion[TC_84273]
        #endregion[TP_84293]

    }
}
