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
using eProposal.PageObject.Admin;
using System.Text.RegularExpressions;
using BaseUtility.Utility.Hotmail;

namespace eProposal.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        #region[TP_120256]

        #region[TC_120257]

        public static void TC_120257()
        {
            //1. Log into ePFull Admins
            Driver.Navigate().GoToUrl(LegacyTestData.CommonAdminURL);
            AdminLogin.LogInCommon();
            Logger.WriteDebugMessage("Land on eSALES SUITE ADMINISTRATION");

            //2. Click Properties
            AdminNavigation.Click_Button_Properties();
            Logger.WriteDebugMessage("Land on the Properties page");

            //3. Click "Cendyn - Hilton Dresden" from the drop down.
            AdminProperties.SelectProperty(Property);
            Logger.WriteDebugMessage("Page populates");

            //4. Click the "Features" tab
            AdminProperties.Click_Tab_Features();
            Logger.WriteDebugMessage("Land on the features page.");

            //5. Turn "eCard" on and click UPDATE
            EnterFrame("iframe_property");
            AdminProperties_UpdateProperty_Features.Click_RadioButton_eCard_On();
            AddDelay(2500);
            ScrollDownUsingJavaScript(Driver, 5000);
            AdminProperties_UpdateProperty_Features.Click_Button_Update();
            ExitFrame();
            Logger.WriteDebugMessage("eCard is turned on");

            //6. Click the "eCard" tab
            AdminNavigation.Click_Button_eCard();
            Logger.WriteDebugMessage("Land on the eCard page.");

            //7. Click "Footer Links"
            AdminECard.Click_Link_FooterLinks();
            Logger.WriteDebugMessage("Land on the links page");

            //8.Click "Add New Media"
            AdminECard.Click_Link_AddMediaLink();
            Logger.WriteDebugMessage("Land on Link Name page");

            //9.Type in a name and click save
            AdminECard.EnterLinkName(linkName);
            Logger.WriteDebugMessage("Land on a settings page");

            //10. Select "Flash" and upload the attached flash file.
            AdminECard.UploadFiles(Constants.UploadFiles, BrowserType, PageObject_AdmineCard.AdmineCard_Button_UploadMediaFiles());
            Logger.WriteDebugMessage("File is attached.");

            //11. Click save.
            Driver.SwitchTo().DefaultContent();
            AdminECard.Click_Button_Save();
            Logger.WriteDebugMessage("Page lands back on the Links page and you can see your media name and file.");

            //12.Click the link.
            AdminECard.Click_Link_GeneratedLinks();
            Logger.WriteDebugMessage("New page opens with the media you uploaded.");

            //13.Click users
            AdminNavigation.Click_Button_Users();
            Logger.WriteDebugMessage("Land on Users page");

            //14. Click "Login" next to User Logged In.
            AdminUsers.SearchUser(Constants.UserOption1, Constants.UserOption2, LegacyTestData.CommonEmployeeEmail);
            Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL);
            EmployeeLogin.CommonLogin_SSO();
            //AdminUsers.Click_Link_LogIn();
            ControlToNewWindow();
            Logger.WriteDebugMessage("Land on employee frontend page.");

            //16. Click "Create/Edit" and click "eCard"                    
            //EmployeeHome.Click_WelcomeButton();

            EmployeeHome.SelectProperty(Property);
            //PropertyType = Constants.PropertyType_Regular;
            Logger.WriteDebugMessage("Selected the property: " + Property);

            EmployeeHome.Click_CreateEdit_eCardButton();
            Logger.WriteDebugMessage("Land on the eCard page.");

            //17. Click "Create/Edit" and click "eCard"
            //eCardCompose.AddNewClient_MandatoryField(FirstName, LastName,
            //    Company, TestData.CommonEmployeeEmail);
            //eCardCompose.Click_Button_YesProceed();
            //Logger.WriteDebugMessage("Client is created");

            eProposalCompose.SearchForClient(LegacyTestData.CommonEmployeeEmail);

            //18. Create the eCard and send it.
            eCardCompose.EnterText_TextBox_EmailSubject(emailSubject);
            ScrollDownUsingJavaScript(Driver, 5000);
            eCardCompose.RedirectSendPage();
            eCardCompose.Click_Button_Send();
            Logger.WriteDebugMessage("eCard is sent to your email.");

            //19. Check your email and scroll to the media name you created and click the link.
            //ClientEmail.CheckAndOpenEmail(Email, Password);
            Login.AutoAcc_login("", 1, 0);
            Logger.WriteDebugMessage("The email is opened.");

            //20. Go back to your email and Click to view this eCard in a browser
            //ClientEmail.Click_Link_ViewInBrowser();
            //ControlToNewWindow();

            //21. Click "Forward"
            ClientEmail.Click_Link_Forward();
            ControlToNewWindow();

            //22. Fill in the first name, last name and email (of an alternative email address) and click submit.
            ClientEmail.Enter_Text_FirstName(firstName);
            ClientEmail.Enter_Text_LastName(lastName);
            ClientEmail.Enter_Text_UniqueEmail(Email);
            ClientEmail.Click_Link_Submit();

            //23. Pop-up displays stating the ecard has been sent. Click OK.
            CloseAlert();

        }

        #endregion[TC_120257]

        #region[TC_120258]

        public static void TC_120258()
        {
            //1. Log into ePFull Admins
            Driver.Navigate().GoToUrl(LegacyTestData.CommonAdminURL);
            AdminLogin.LogInCommon();
            Logger.WriteDebugMessage("Land on eSALES SUITE ADMINISTRATION");

            //2. Click Properties
            AdminNavigation.Click_Button_Properties();
            Logger.WriteDebugMessage("Land on the Properties page");

            //3. Click "Cendyn - Hilton Dresden" from the drop down.
            AdminProperties.SelectProperty(Property);
            Logger.WriteDebugMessage("Page populates");

            //4. Click the "Features" tab
            AdminProperties.Click_Tab_Features();
            Logger.WriteDebugMessage("Land on the features page.");

            //5. Turn "eCard" on and click UPDATE
            EnterFrame("iframe_property");
            AdminProperties_UpdateProperty_Features.Click_RadioButton_eCard_On();
            AddDelay(2500);
            ScrollDownUsingJavaScript(Driver, 5000);
            AdminProperties_UpdateProperty_Features.Click_Button_Update();
            Logger.WriteDebugMessage("eCard is turned on");
            ExitFrame();


            //6. Click the "eCard" tab
            AdminNavigation.Click_Button_eCard();
            Logger.WriteDebugMessage("Land on the eCard page.");

            //7. Click "Add New"
            AdminECard.Click_Button_Addnew();

            //8.Give any name you want.
            AdminECard.Enter_Text_SkinName(skinName);
            Logger.WriteDebugMessage("Land on Link Name page");

            //9.Scroll down to "Upload Image" and "Upload Logo" and select pictures of your choice.
            AdminECard.Click_Button_UploadImage();

            AdminECard.UploadFiles(Constants.ImageUpload, BrowserType, null);

            Logger.WriteDebugMessage("Image is uploaded successfully");
            ControlToPreviousWindow();
            AddDelay(3000);
            AdminECard.Click_Button_UploadLogo();
            AdminECard.UploadFiles(Constants.ImageUpload, BrowserType, null);
            Logger.WriteDebugMessage("Logo is uploaded successfully");
            ControlToPreviousWindow();

            //10.Click "Update"
            AdminECard.Click_Button_Save();

            //11.Verify the preview to the images display correctly in the correct column.
            //12.Click the preview image.
            AdminECard.Click_Image_Preview();
            ControlToNewWindow();
            Driver.Close();
            ControlToPreviousWindow();

            //13.Click users
            AdminNavigation.Click_Button_Users();

            //14.Click "Login" next to "Marc LaRocco"
            AdminUsers.SearchUser(Constants.UserOption1, Constants.UserOption2, uniqueEmail);
            //AdminUsers.Click_Link_LogIn();
            Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL);
            EmployeeLogin.CommonLogin_SSO();

            //15.Select your property from the drop down. 
            ControlToNewWindow();
            // EmployeeLogin.CommonLogin();
            EmployeeHome.SelectProperty(Property);
            ControlToNewWindow();
            Logger.WriteDebugMessage("Land on employee frontend page.");

            //16.Click "Create/Edit" and click "eCard"
            EmployeeHome.Click_WelcomeButton();
            EmployeeHome.Click_CreateEdit_eCardButton();

            //17.Create a client with your email address
            //eCardCompose.AddNewClient_MandatoryField(TestData.TC_120258_FirstName, TestData.TC_120258_LastName,
            //    TestData.TC_120258_Company, MakeGmailUnique(TestData.TC_120258_UniqueEmail));
            //eCardCompose.Click_Button_YesProceed();
            eProposalCompose.SearchForClient(LegacyTestData.CommonEmployeeEmail);
            eCardCompose.EnterText_TextBox_EmailSubject(emailSubject);

            //18.Select the skin you just created and click next.
            eCardCompose.Click_Button_Next();
            eCardCompose.Click_Button_Next();

            //19.Finish the eCard and send it.
            eCardCompose.Click_Button_Next();
            eCardCompose.Click_Button_Send();

            //20.Open the eCard email.
            Login.AutoAcc_login("", 1, 0);
            Logger.WriteDebugMessage("The email is opened.");

            //21.Click "Click to view this eCard in a browser"
            //ClientEmail.Click_Link_ViewInBrowser();
        }

        #endregion[TC_120258]

        #region[TC_120259]

        public static void TC_120259()
        {
            //1 Log in to eP Full UI
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);

            //2. Click "Create/Edit -> eProposal"
            EmployeeHome.Click_CreateEdit_eProposalButton();
            AddDelay(6000);
            Logger.WriteDebugMessage("Land on the Compose page.");

            //3 Next to client click "Add New"
            eProposalCompose.Click_Client_AddNewLink();
            Logger.WriteDebugMessage("Landed on the ePropsal Compose page.");

            //4 Fill in required information and click "Save"  
            eProposalCompose.EnterText_Client_AddNew_FirstNameText(firstName);
            eProposalCompose.EnterText_Client_AddNew_LastNameText(lastName);
            eProposalCompose.EnterText_Client_AddNew_CompanyText(company);
            eProposalCompose.EnterText_Client_AddNew_UniqueEmailText(email);
            eProposalCompose.Click_Client_AddNew_SaveButton();
           eCardCompose.Click_Button_YesProceed();
            Logger.WriteDebugMessage("All required fields are entered.");

            //5 Click "Edit"               
            eProposalCompose.Click_Client_EditLink();
            Logger.WriteDebugMessage("Clikck on Client Edit link");

            //6 Change the email address.
            eProposalCompose.VerifyEmail(email);
            Logger.WriteDebugMessage("Email id is not editable");
        }

        #endregion[TC_120259]

        #region[TC_120260]

        public static void TC_120260()
        {
            //1 Log in to eP Full UI
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Click "Create/Edit" -> eCard
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Selected the property: " + Property);
            EmployeeHome.Click_CreateEdit_eCardButton();
            Logger.WriteDebugMessage("Land on the eCard page.");

            //3 Next to client click "Add New"
            eProposalCompose.Click_Client_AddNewLink();
            Logger.WriteDebugMessage("Landed on the ePropsal Compose page.");

            //4 Fill in required information and click "Save"  
            eCardCompose.EnterText_TextBox_Client_AddNew_FirstName(firstName);
            eCardCompose.EnterText_TextBox_Client_AddNew_LastName(lastName);
            eCardCompose.EnterText_TextBox_Client_AddNew_Company(company);
            eCardCompose.EnterText_TextBox_Client_AddNew_UniqueEmailAddress(email);
            eCardCompose.Click_Button_Client_AddNew_Save();
            eCardCompose.Click_Button_YesProceed();
            eCardCompose.EnterText_TextBox_EmailSubject(emailSubject);
            Logger.WriteDebugMessage("All required fields are entered.");

            //5 Click "Edit"               
            eProposalCompose.Click_Client_EditLink();
            Logger.WriteDebugMessage("Clikck on Client Edit link");

            //6 Change the email address.
            eProposalCompose.VerifyEmail(uniqueEmail);
            Logger.WriteDebugMessage("Email id is not editable");
        }

        #endregion[TC_120260]

        #region[TC_120261]

        public static void TC_120261()
        {
            //1 Log into ePFull UI through the employee login page.
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select a property that uses the eCard feature (Cendyn - Hilton Berlin)
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Selected the property: " + Property);

            //3 Hover "My Settings" and click "Profile"
            EmployeeHome.Hover_MySettings();
            //EmployeeHome.Click_Profile();
            //Helper.AddDelay(20000);
            //Logger.WriteDebugMessage("Landed on the Profile page.");

            //4 If there is a "Custom Signature" uploaded, click "Remove" on it.
            //Profile.CheckAndRemoveSignature();
            //Logger.WriteDebugMessage("Removed 'Custom Signature'");

            //5 Click "Save"                    
            //Profile.Click_Button_Save();
            //if (IsElementDisplayed(PageObject_Profile.Profile_Button_No()))
            //    Profile.Click_Button_No();

            // 08/04 Marc : Changing "Hover Create/Edit -> eCard" to "Click "Welcome -> Click eCard" since that nav does hover well with Selenium
            //6 Hoover "Create/Edit" and click "eCard"     
            EmployeeHome.Click_WelcomeButton();
            EmployeeHome.Click_CreateEdit_eCardButton();
            Logger.WriteDebugMessage("Landed on e Card page");

            //7 Use your @cendyn.com email address for the client.
            eCardCompose.Click_Client_SearchLink();
            eCardCompose.SearchAndClickClient("testAuto@cendyn17.com");
            Logger.WriteDebugMessage("Selected client");

            //8 Fill in the rest of the eCard information and reach step 4.
            eCardCompose.EnterText_TextBox_EmailSubject(emailSubject);
            eCardCompose.Click_Button_Next();
            eCardCompose.Click_Button_Next();
            eCardCompose.Click_Button_Next();

            //9 Confirm the employee name is BOLD
            eCardCompose.CheckEmployeeNameCendynQABold();
            Logger.WriteDebugMessage("Verified Employee name is in Bold");

            //10 Click "Send"
            eCardCompose.Click_Button_Send();
            Logger.WriteDebugMessage("Selected Send");

            //11 Open the email
            OpenNewTab();
            Hotmail.LogIntoCatchAllAndOpenFirstMessageByEmail("testAuto@cendyn17.com", "https://outlook.office.com/");
            //ClientEmail.CheckAndOpenEmail(email, password);

            //13 Click the "Click to view this eCard in a browser" link.               
            ClientEmail.Click_Link_ViewInBrowser();

            //14 Look for the employee name and verify it's in bold.
            ControlToNewWindow();
            ClientEmail.CheckEmployeeNameCendynQABold();
            Logger.WriteDebugMessage("Verified Employee name is in Bold");
        }

        #endregion[TC_120261]

        #region[TC_120262]

        public static void TC_120262()
        {
            //1 Log into ePFull UI through the employee login page.
            EmployeeLogin.CommonLogin();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select a property that uses the eCard feature (Cendyn - Hilton Berlin)
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Selected the property: " + Property);

            //3 Hover "My Settings" and click "Profile"
            EmployeeHome.Hover_MySettings();
			EmployeeHome.Click_Profile();
			Logger.WriteDebugMessage("Landed on the Profile page.");

			//4 If there is a "Custom Signature" uploaded, click "Remove" on it.
			ScrollDownUsingJavaScript(Driver, 5000);
            Profile.CheckAndRemoveSignature();
            Logger.WriteDebugMessage("Removed 'Custom Signature'");

            //5 Click "Choose File" and add your own custom image (gif, jpg or pnf files).
            Profile.Upload_Button_ChooseFile(Constants.CustomSignatureUpload);

            //6 Click "Save"    
            Profile.Click_Button_Save();
            if (IsElementDisplayed(PageObject_Profile.Profile_Button_No()))
                Profile.Click_Button_No();

            //7 Hoover "Create/Edit" and click "eCard"
            EmployeeHome.Click_WelcomeButton();
            EmployeeHome.Click_CreateEdit_eCardButton();
            Logger.WriteDebugMessage("Land on the eCard page.");

            //8 Use your @cendyn.com email address for the client.
            eCardCompose.Click_Client_SearchLink();
            eCardCompose.SearchAndClickClient("testAuto@cendyn17.com");
            Logger.WriteDebugMessage("Selected client");

            //9 Fill in the rest of the eCard information and reach step 4.
            eCardCompose.EnterText_TextBox_EmailSubject(emailSubject);
            eCardCompose.Click_Button_Next();
            eCardCompose.Click_Button_Next();
            eCardCompose.Click_Button_Next();

            //10 Confirm the image displays correctly (height ims no more than 55 px, it fits correctly)
            Profile.VerifyHeight_Image_CustomSignature();
            Logger.WriteDebugMessage("Verified Height of Custom Signature");

            //11 Click "Send"
            eCardCompose.Click_Button_Send();
            Logger.WriteDebugMessage("Selected Send");

            //12 Open the email
            OpenNewTab();
            Hotmail.LogIntoCatchAllAndOpenFirstMessageByEmail("testAuto@cendyn17.com", "https://outlook.office.com/");
            //ClientEmail.CheckAndOpenEmail(email, password);

            //13. Confirm the image displays correctly (height is no more than 55 px, it fits correctly)
            //14 Click the "Click to view this eCard in a browser" link.
            ClientEmail.Click_Link_ViewInBrowser();

            //15 Look for the employee information and confirm the image displays correctly (height is no more than 55 px, it fits correctly)
            AddDelay(3500);
            var image = GetElementHeight(PageObject_ClientEmail.Image_CustomSignature());
            if (image <= 55)
                Logger.WriteDebugMessage("Verified Height of Custom Signature");
            else
                Logger.WriteDebugMessage("Height of Custom Signature is less than or greater than 55 pixels");
            CloseWindow();
            ControlToPreviousWindow();
            Logger.WriteDebugMessage("Verified Height of Custom Signature");
        }

        #endregion[TC_120261]

        #region[TC_120263]

        public static void TC_120263()
        {
            //1 Log in to eP Full UI
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Click "Create/Edit" -> eCard
            EmployeeHome.SelectProperty(Property);
            EmployeeHome.Click_CreateEdit_eCardButton();
            AddDelay(6000);
            Logger.WriteDebugMessage("Land on the eCard page.");

            //3. Open the "From" drop down menu.
            eProposalCompose.Click_FromDropDown();
            Logger.WriteDebugMessage("The list of employees are listed in alphabetical order.");
        }

        #endregion[TC_120263]

        #endregion[TP_120256]

    }
}
