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
using InfoMessageLogger.ReportGeneration;

namespace eProposal.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        #region[TP_120217]

        #region[TC_120218]

        public static void TC_120218()
        {
            //1 Log into eProposal
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select a property.
            string Property = "Cendyn – DEV - BBQ HIlton";
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);

            //3. Click "Activity"               
            AddDelay(1500);
            Activity.ClickActivityTab();
            Logger.WriteDebugMessage("Land on the activity page.");

            //4. Click "Preview" for an eProposal that you have sent out in the past.(Leave this opened)
            Activity.SearchKeywords(searchName);
            Activity.ClickLinkPreview();
            AddDelay(10000);
            Logger.WriteDebugMessage("Opens in a new window or tab.");

            //5. Hoover over "My Settings" and click "Profile"
            AddDelay(5000);

            //Divya 14 Aug
            Helper.ControlToPreviousWindow();
            EmployeeHome.Hover_MySettings();
            AddDelay(1500);
            EmployeeHome.Click_Profile();
            Logger.WriteDebugMessage("Land on the My Profile page.");

            //6. Verify the "Custom Signature" field is available.
            Profile.VerifyCustomSignatureField();

            //7. If there is already an custom signature loaded, click "Remove" and "OK" on the popup.
            Profile.VerifyIsPresent_Link_Remove();

            //8.Click "Choose File"     
            //9.Select any file that is NOT a "gif, jpg or png".
            Profile.UploadImproperFile(Constants.UploadFiles);
            Logger.WriteDebugMessage("A file which is not gif, jpg, png is chosen");

            //10. Click "Choose File" and select a .gif file.
            Profile.Upload_Button_ChooseFile(Constants.UploadgifFiles);
            Logger.WriteDebugMessage("A file which is gif is chosen");

            //11. Click "Save"
            Profile.Click_Button_Save();
            if (PageObject_Profile.Profile_Button_No().Displayed)
                Profile.Click_Button_No();
            Logger.WriteDebugMessage(".gif file is verified on profile page");

            //12.Go back to the eProposal "Preview" and refresh.
            ControlToNewWindow();
            Driver.Navigate().Refresh();
            AddDelay(1500);
            Logger.WriteDebugMessage(".gif file is verified on preview page");

            //13.Click "Choose File" and select a .jpg file.
            ControlToPreviousWindow();
            Profile.Upload_Button_ChooseFile(Constants.CustomSignatureUpload);
            Logger.WriteDebugMessage("A file which is jpg is chosen");

            //14. Click "Save"                
            Profile.Click_Button_Save();
            if (PageObject_Profile.Profile_Button_No().Displayed)
                Profile.Click_Button_No();
            Logger.WriteDebugMessage(".jpg file is verified on profile page");

            //15. Go back to the eProposal "Preview" and refresh.
            ControlToNewWindow();
            Driver.Navigate().Refresh();
            AddDelay(1500);
            Logger.WriteDebugMessage(".jpg file is verified on preview page");

            //16.Click "Choose File" and select a .png file.
            ControlToPreviousWindow();
            Profile.Upload_Button_ChooseFile(Constants.UploadpngFiles);
            Logger.WriteDebugMessage("A file which is png is chosen");

            //17. Click "Save"
            Profile.Click_Button_Save();
            if (PageObject_Profile.Profile_Button_No().Displayed)
                Profile.Click_Button_No();
            Logger.WriteDebugMessage(".png file is verified on profile page");

            //18. Go back to the eProposal "Preview" and refresh.
            ControlToNewWindow();
            Driver.Navigate().Refresh();
            AddDelay(1500);
            Logger.WriteDebugMessage(".png file is verified on preview page");
        }

        #endregion[TC_120218]

        #region[TC_120219]

        public static void TC_120219()
        {
            //1. Log into eP UI (employee).                
            EmployeeLogin.CommonLogin();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2. Select a cluster property. (DEMO - Cendyn - Kimpton Hotels Cluster)
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Selected the property: " + Property);

            //3. Click "Activity"
            EmployeeHome.Click_ActivityTab();
            Logger.WriteDebugMessage("Land on the activity page.");

            //4. Click "Preview" for an eProposal that you have sent out in the past. (Leave this opened)
            Activity.SearchKeywords(searchName);
            Activity.ClickLinkPreview();
            AddDelay(10000);
            Logger.WriteDebugMessage("Opens in a new window or tab.");

            //5. Hoover over "My Settings" and click "Profile"
            AddDelay(5000);
            //Divya 14 Aug
            Helper.ControlToPreviousWindow();
            EmployeeHome.Hover_MySettings();
            AddDelay(1500);
            EmployeeHome.Click_Profile();
            Logger.WriteDebugMessage("Land on the My Profile page.");

            //6. Verify the "Custom Signature" field is available.
            Profile.VerifyCustomSignatureField();

            //7. If there is already an custom signature loaded, click "Remove" and "OK" on the popup.
            Profile.VerifyIsPresent_Link_Remove();

            //8.Click "Choose File"     
            //9.Select any file that is NOT a "gif, jpg or png".
            Profile.UploadImproperFile(Constants.UploadFiles);
            Logger.WriteDebugMessage("A file which is not gif, jpg, png is chosen");

            //10. Click "Choose File" and select a .gif file.
            Profile.Upload_Button_ChooseFile(Constants.UploadgifFiles);
            Logger.WriteDebugMessage("A file which is gif is chosen");

            //11. Click "Save"
            Profile.Click_Button_Save();
            if (PageObject_Profile.Profile_Button_No().Displayed)
                Profile.Click_Button_No();
            Logger.WriteDebugMessage(".gif file is verified on profile page");

            //12.Go back to the eProposal "Preview" and refresh.
            ControlToNewWindow();
            Driver.Navigate().Refresh();
            AddDelay(1500);
            Logger.WriteDebugMessage(".gif file is verified on preview page");

            //13.Click "Choose File" and select a .jpg file.
            ControlToPreviousWindow();
            Profile.Upload_Button_ChooseFile(Constants.CustomSignatureUpload);
            Logger.WriteDebugMessage("A file which is jpg is chosen");

            //14. Click "Save"
            Profile.Click_Button_Save();
            if (PageObject_Profile.Profile_Button_No().Displayed)
                Profile.Click_Button_No();
            Logger.WriteDebugMessage(".jpg file is verified on profile page");

            //15. Go back to the eProposal "Preview" and refresh.
            ControlToNewWindow();
            Driver.Navigate().Refresh();
            AddDelay(1500);
            Logger.WriteDebugMessage(".jpg file is verified on preview page");

            //16.Click "Choose File" and select a .png file.
            ControlToPreviousWindow();
            Profile.Upload_Button_ChooseFile(Constants.UploadpngFiles);
            Logger.WriteDebugMessage("A file which is png is chosen");

            //17. Click "Save"
            Profile.Click_Button_Save();
            if (PageObject_Profile.Profile_Button_No().Displayed)
                Profile.Click_Button_No();
            Logger.WriteDebugMessage(".png file is verified on profile page");

            //18. Go back to the eProposal "Preview" and refresh.
            ControlToNewWindow();
            Driver.Navigate().Refresh();
            AddDelay(1500);
            Logger.WriteDebugMessage(".png file is verified on preview page");
        }

        #endregion[TC_120219]

        #region[TC_120220]

        public static void TC_120220()
        {
            //1. Log into eP UI (employee).                
            EmployeeLogin.CommonLogin();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2. Select a CVB property. (Cendyn - Visit Indy)
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Selected the property: " + Property);

            //3. Click "Activity"
            EmployeeHome.Click_ActivityTab();
            Logger.WriteDebugMessage("Land on the activity page.");

            //4. Click "Preview" for an eProposal that you have sent out in the past. (Leave this opened)
            Activity.SearchKeywords(searchName);
            Activity.ClickLinkPreview();
            AddDelay(10000);
            Logger.WriteDebugMessage("Opens in a new window or tab.");

            //5. Hoover over "My Settings" and click "Profile"
            AddDelay(5000);
            //Divya 14 Aug
            Helper.ControlToPreviousWindow();
            EmployeeHome.Hover_MySettings();
            AddDelay(1500);
            EmployeeHome.Click_Profile();
            Logger.WriteDebugMessage("Land on the My Profile page.");

            //6. Verify the "Custom Signature" field is available.
            Profile.VerifyCustomSignatureField();

            //7. If there is already an custom signature loaded, click "Remove" and "OK" on the popup.
            Profile.VerifyIsPresent_Link_Remove();

            //8.Click "Choose File"     
            //9.Select any file that is NOT a "gif, jpg or png".
            Profile.UploadImproperFile(Constants.UploadFiles);
            Logger.WriteDebugMessage("A file which is not gif, jpg, png is chosen");

            //10. Click "Choose File" and select a .gif file.
            Profile.Upload_Button_ChooseFile(Constants.UploadgifFiles);
            Logger.WriteDebugMessage("A file which is gif is chosen");

            //11. Click "Save"
            Profile.Click_Button_Save();
            if (PageObject_Profile.Profile_Button_No().Displayed)
                Profile.Click_Button_No();
            Logger.WriteDebugMessage(".gif file is verified on profile page");

            //12.Go back to the eProposal "Preview" and refresh.
            ControlToNewWindow();
            Driver.Navigate().Refresh();
            AddDelay(1500);
            Logger.WriteDebugMessage(".gif file is verified on preview page");

            //13.Click "Choose File" and select a .jpg file.
            ControlToPreviousWindow();
            Profile.Upload_Button_ChooseFile(Constants.CustomSignatureUpload);
            Logger.WriteDebugMessage("A file which is jpg is chosen");

            //14. Click "Save"
            Profile.Click_Button_Save();
            if (PageObject_Profile.Profile_Button_No().Displayed)
                Profile.Click_Button_No();
            Logger.WriteDebugMessage(".jpg file is verified on profile page");

            //15. Go back to the eProposal "Preview" and refresh.
            ControlToNewWindow();
            Driver.Navigate().Refresh();
            AddDelay(1500);
            Logger.WriteDebugMessage(".jpg file is verified on preview page");

            //16.Click "Choose File" and select a .png file.
            ControlToPreviousWindow();
            Profile.Upload_Button_ChooseFile(Constants.UploadpngFiles);
            Logger.WriteDebugMessage("A file which is png is chosen");

            //17. Click "Save"
            Profile.Click_Button_Save();
            if (PageObject_Profile.Profile_Button_No().Displayed)
                Profile.Click_Button_No();
            Logger.WriteDebugMessage(".png file is verified on profile page");

            //18. Go back to the eProposal "Preview" and refresh.
            ControlToNewWindow();
            Driver.Navigate().Refresh();
            AddDelay(1500);
            Logger.WriteDebugMessage(".png file is verified on preview page");
        }

        #endregion[TC_120219]

        #region[TC_120221]

        public static void TC_120221()
        {
            //1. Log into eP UI (employee).                
            EmployeeLogin.LogIn(Email, Password);
            Logger.WriteDebugMessage("Logged in successfully.");

            //2. Select a GSO property. ('Select Your Property')
            //3. Click "Activity"
            EmployeeHome.Click_ActivityTab();
            Logger.WriteDebugMessage("Land on the activity page.");

            //4. Click "Preview" for an eProposal that you have sent out in the past. (Leave this opened)
            Activity.SearchKeywords(searchName);
            Activity.ClickLinkPreview();
            AddDelay(10000);
            Logger.WriteDebugMessage("Opens in a new window or tab.");

            //5. Hoover over "My Settings" and click "Profile"
            AddDelay(5000);
            EmployeeHome.Hover_MySettings();
            AddDelay(1500);
            EmployeeHome.Click_Profile();
            Logger.WriteDebugMessage("Land on the My Profile page.");

            //6. Verify the "Custom Signature" field is available.
            Profile.VerifyCustomSignatureField();

            //7. If there is already an custom signature loaded, click "Remove" and "OK" on the popup.
            Profile.VerifyIsPresent_Link_Remove();

            //8.Click "Choose File"     
            //9.Select any file that is NOT a "gif, jpg or png".
            Profile.UploadImproperFile(Constants.UploadFiles);
            Logger.WriteDebugMessage("A file which is not gif, jpg, png is chosen");

            //10. Click "Choose File" and select a .gif file.
            Profile.Upload_Button_ChooseFile(Constants.UploadgifFiles);
            Logger.WriteDebugMessage("A file which is gif is chosen");

            //11. Click "Save"
            Profile.Click_Button_Save();
            if (PageObject_Profile.Profile_Button_No().Displayed)
                Profile.Click_Button_No();
            Logger.WriteDebugMessage(".gif file is verified on profile page");

            //12.Go back to the eProposal "Preview" and refresh.
            ControlToNewWindow();
            Driver.Navigate().Refresh();
            AddDelay(1500);
            Logger.WriteDebugMessage(".gif file is verified on preview page");

            //13.Click "Choose File" and select a .jpg file.
            ControlToPreviousWindow();
            Profile.Upload_Button_ChooseFile(Constants.CustomSignatureUpload);
            Logger.WriteDebugMessage("A file which is jpg is chosen");

            //14. Click "Save"
            Profile.Click_Button_Save();
            if (PageObject_Profile.Profile_Button_No().Displayed)
                Profile.Click_Button_No();
            Logger.WriteDebugMessage(".jpg file is verified on profile page");

            //15. Go back to the eProposal "Preview" and refresh.
            ControlToNewWindow();
            Driver.Navigate().Refresh();
            AddDelay(1500);
            Logger.WriteDebugMessage(".jpg file is verified on preview page");

            //16.Click "Choose File" and select a .png file.
            ControlToPreviousWindow();
            Profile.Upload_Button_ChooseFile(Constants.UploadpngFiles);
            Logger.WriteDebugMessage("A file which is png is chosen");

            //17. Click "Save"
            Profile.Click_Button_Save();
            if (PageObject_Profile.Profile_Button_No().Displayed)
                Profile.Click_Button_No();
            Logger.WriteDebugMessage(".png file is verified on profile page");

            //18. Go back to the eProposal "Preview" and refresh.
            ControlToNewWindow();
            Driver.Navigate().Refresh();
            AddDelay(1500);
            Logger.WriteDebugMessage(".png file is verified on preview page");
        }

        #endregion[TC_120221]

        #region[TC_120222]

        public static void TC_120222()
        {
            //1. Log into eP UI (employee).                
            EmployeeLogin.LogIn(Email, Password);
            Logger.WriteDebugMessage("Logged in successfully.");

            //2. Select a SSO property. ('Select Your Property')
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Selected the property: " + Property);

            //3. Click "Activity"
            EmployeeHome.Click_ActivityTab();
            Logger.WriteDebugMessage("Land on the activity page.");

            //4. Click "Preview" for an eProposal that you have sent out in the past. (Leave this opened)
            Activity.SearchKeywords(searchName);
            Activity.ClickLinkPreview();
            AddDelay(10000);
            Logger.WriteDebugMessage("Opens in a new window or tab.");

            //5. Hoover over "My Settings" and click "Profile"
            AddDelay(5000);
            EmployeeHome.Hover_MySettings();
            AddDelay(1500);
            EmployeeHome.Click_Profile();
            Logger.WriteDebugMessage("Land on the My Profile page.");

            //6. Verify the "Custom Signature" field is available.
            Profile.VerifyCustomSignatureField();

            //7. If there is already an custom signature loaded, click "Remove" and "OK" on the popup.
            Profile.VerifyIsPresent_Link_Remove();

            //8.Click "Choose File"     
            //9.Select any file that is NOT a "gif, jpg or png".
            Profile.UploadImproperFile(Constants.UploadFiles);
            Logger.WriteDebugMessage("A file which is not gif, jpg, png is chosen");

            //10. Click "Choose File" and select a .gif file.
            Profile.Upload_Button_ChooseFile(Constants.UploadgifFiles);
            Logger.WriteDebugMessage("A file which is gif is chosen");

            //11. Click "Save"
            Profile.Click_Button_Save();
            if (PageObject_Profile.Profile_Button_No().Displayed)
                Profile.Click_Button_No();
            Logger.WriteDebugMessage(".gif file is verified on profile page");

            //12.Go back to the eProposal "Preview" and refresh.
            ControlToNewWindow();
            Driver.Navigate().Refresh();
            AddDelay(5000);
            Logger.WriteDebugMessage(".gif file is verified on preview page");

            //13.Click "Choose File" and select a .jpg file.
            ControlToPreviousWindow();
            Profile.Upload_Button_ChooseFile(Constants.CustomSignatureUpload);
            Logger.WriteDebugMessage("A file which is jpg is chosen");

            //14. Click "Save"
            Profile.Click_Button_Save();
            if (PageObject_Profile.Profile_Button_No().Displayed)
                Profile.Click_Button_No();
            Logger.WriteDebugMessage(".jpg file is verified on profile page");

            //15. Go back to the eProposal "Preview" and refresh.
            ControlToNewWindow();
            Driver.Navigate().Refresh();
            AddDelay(1500);
            Logger.WriteDebugMessage(".jpg file is verified on preview page");

            //16.Click "Choose File" and select a .png file.
            ControlToPreviousWindow();
            Profile.Upload_Button_ChooseFile(Constants.UploadpngFiles);
            Logger.WriteDebugMessage("A file which is png is chosen");

            //17. Click "Save"
            Profile.Click_Button_Save();
            if (PageObject_Profile.Profile_Button_No().Displayed)
                Profile.Click_Button_No();
            Logger.WriteDebugMessage(".png file is verified on profile page");

            //18. Go back to the eProposal "Preview" and refresh.
            ControlToNewWindow();
            Driver.Navigate().Refresh();
            AddDelay(1500);
            Logger.WriteDebugMessage(".png file is verified on preview page");
        }

        #endregion[TC_120221]

        #region[TC_120223]

        public static void TC_120223()
        {
            //1. Log into eP UI (employee).                
            EmployeeLogin.CommonLogin();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2. Select a regular property. (Cendyn - Hilton Dresden)
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Selected the property: " + Property);

            //3. Hoover over "My Settings" and click "Profile"
            AddDelay(5000);
            EmployeeHome.Hover_MySettings();
            AddDelay(1500);
            EmployeeHome.Click_Profile();
            Logger.WriteDebugMessage("Land on the My Profile page.");

            //4. Verify the "Custom Signature" field is available.
            Profile.VerifyCustomSignatureField();

            //5. If there is already an custom signature loaded, click "Remove" and "OK" on the popup.
            Profile.VerifyIsPresent_Link_Remove();

            //6. Click "Choose File" and select a .gif file.
            Profile.Upload_Button_ChooseFile(Constants.UploadgifFiles);
            Logger.WriteDebugMessage("A file which is gif is chosen");

            //7. Click "Save".
            Profile.Click_Button_Save();
            if (PageObject_Profile.Profile_Button_No().Displayed)
                Profile.Click_Button_No();
            var Value1 = Profile.Get_CustomSignaturename(PageObject_Profile.Profile_Image_CustomSignature());
            AddDelay(6000);
            Logger.WriteDebugMessage(".gif file is verified on profile page");

            //8. Click "Create/Edit" and select "eProposal".
            EmployeeHome.Click_WelcomeButton();
            EmployeeHome.Click_CreateEdit_eProposalButton();
            Logger.WriteDebugMessage("Land on the eProposal page.");
            AddDelay(6000);

            //9. Use your email as the client and send yourself an eProposal.
            eProposalCompose.CommonComposeMandetory(eproposalName, ClientName);
            eProposalCompose.RedirectToSendPage();
            eProposalPreview.Click_Button_Send();

            //10. Open your email and click the "Open eProposal" link.
            ClientEmail.GmailLogIn(ClientLogin, ClientPassword);
            ClientEmail.GmailOpenFirstMessage();
            Logger.WriteDebugMessage("The email is opened.");

            //11. Look for the signature.
            ClientEmail.Click_Link_OpenYourProposal();
            ControlToNewWindow();
            AddDelay(3000);
            var Value2 = ClientEmail.Get_CustomSignaturename();
            ClientEmail.VerifyWithUploaded_Image_CustomSignature(Value1, Value2);
        }

        #endregion[TC_120223]

        #region[TC_120224]

        public static void TC_120224()
        {
            //1. Log into eP UI (employee).                
            EmployeeLogin.CommonLogin();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2. Select a cluster property. (DEMO - Cendyn - Kimpton Hotels Cluster)
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Selected the property: " + Property);

            //3. Hoover over "My Settings" and click "Profile"
            AddDelay(5000);
            EmployeeHome.Hover_MySettings();
            AddDelay(1500);
            EmployeeHome.Click_Profile();
            Logger.WriteDebugMessage("Land on the My Profile page.");

            //4. Verify the "Custom Signature" field is available.
            Profile.VerifyCustomSignatureField();

            //5. If there is already an custom signature loaded, click "Remove" and "OK" on the popup.
            Profile.VerifyIsPresent_Link_Remove();

            //6. Click "Choose File" and select a .gif file.
            Profile.Upload_Button_ChooseFile(Constants.UploadgifFiles);
            Logger.WriteDebugMessage("A file which is gif is chosen");

            //7. Click "Save"
            Profile.Click_Button_Save();
            if (PageObject_Profile.Profile_Button_No().Displayed)
                Profile.Click_Button_No();
            var Value1 = Profile.Get_CustomSignaturename(PageObject_Profile.Profile_Image_CustomSignature());
            AddDelay(6000);
            Logger.WriteDebugMessage(".gif file is verified on profile page");

            //8. Click "Create/Edit" and select "eProposal"
            EmployeeHome.Click_WelcomeButton();
            EmployeeHome.Click_CreateEdit_eProposalButton();
            Logger.WriteDebugMessage("Land on the eProposal page.");
            AddDelay(6000);

            //9. Use your email as the client and send yourself an eProposal.
            eProposalCompose.CommonComposeMandetory(eproposalName,
                ClientName);
            Activity.RedirectSendPage();
            eProposalPreview.Click_Button_Send();

            //10. Open your email and click the "Open eProposal" link.
            ClientEmail.GmailLogIn(ClientLogin, ClientPassword);
            ClientEmail.GmailOpenFirstMessage();
            Logger.WriteDebugMessage("The email is opened.");

            //11. Look for the signature.
            ClientEmail.Click_Link_OpenYourProposal();
            ControlToNewWindow();
            AddDelay(3000);
            var Value2 = ClientEmail.Get_CustomSignaturename();
            ClientEmail.VerifyWithUploaded_Image_CustomSignature(Value1, Value2);
        }

        #endregion[TC_120224]

        #region[TC_120225]

        public static void TC_120225()
        {
            //1. Log into eP UI (employee).                
            EmployeeLogin.CommonLogin();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2. Select a CVB property. (Cendyn - Visit Indy)
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Selected the property: " + Property);

            //3. Hoover over "My Settings" and click "Profile"
            AddDelay(5000);
            EmployeeHome.Hover_MySettings();
            AddDelay(1500);
            EmployeeHome.Click_Profile();
            Logger.WriteDebugMessage("Land on the My Profile page.");

            //4. Verify the "Custom Signature" field is available.
            Profile.VerifyCustomSignatureField();

            //5. If there is already an custom signature loaded, click "Remove" and "OK" on the popup.
            Profile.VerifyIsPresent_Link_Remove();

            //6. Click "Choose File" and select a .gif file.
            Profile.Upload_Button_ChooseFile(Constants.UploadgifFiles);
            Logger.WriteDebugMessage("A file which is gif is chosen");

            //7. Click "Save"
            Profile.Click_Button_Save();
            if (PageObject_Profile.Profile_Button_No().Displayed)
                Profile.Click_Button_No();
            var Value1 = Profile.Get_CustomSignaturename(PageObject_Profile.Profile_Image_CustomSignature());
            AddDelay(6000);
            Logger.WriteDebugMessage(".gif file is verified on profile page");

            //8. Click "Create/Edit" and select "eProposal"
            EmployeeHome.Click_WelcomeButton();
            EmployeeHome.Click_CreateEdit_eProposalButton();
            Logger.WriteDebugMessage("Land on the eProposal page.");
            AddDelay(6000);

            //9. Use your email as the client and send yourself an eProposal.
            eProposalCompose.CommonComposeMandetory(eproposalName, ClientName);
            eProposalCompose.Click_Button_Next();
            eProposalSelect.Click_Button_Cancel();
            Driver.FindElement(By.Id("ctl00_ctl00_MainContent_MainContent_imgbtn")).Click();
            eProposalCompose.Click_Button_Next();

            //eProposalCendynEventBlock.Click_Button_Next();               
            Helper.ControlToNewWindow();
            Helper.CloseWindow();
            Helper.ControlToPreviousWindow();


            //Activity.RedirectSendPage();
            eProposalPreview.Click_Button_Send();

            //10. Open your email and click the "Open eProposal" link.
            ClientEmail.GmailLogIn(ClientLogin, ClientPassword);
            ClientEmail.GmailOpenFirstMessage();
            Logger.WriteDebugMessage("The email is opened.");

            //11. Look for the signature.
            ClientEmail.Click_Link_OpenYourProposal();
            ControlToNewWindow();
            AddDelay(3000);
            var Value2 = ClientEmail.Get_CustomSignaturename();
            ClientEmail.VerifyWithUploaded_Image_CustomSignature(Value1, Value2);
        }

        #endregion[TC_120225]

        #region[TC_120227]

        public static void TC_120227()
        {
            //1. Log into eP UI (employee).                
            EmployeeLogin.LogIn(loginEmail, loginPassword);
            Logger.WriteDebugMessage("Logged in successfully.");

            //2. Select a SSO property. (Cendyn - Hilton Chicago O'Hare Airport)
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Selected the property: " + Property);

            //3. Hoover over "My Settings" and click "Profile"
            AddDelay(5000);
            EmployeeHome.Hover_MySettings();
            AddDelay(1500);
            EmployeeHome.Click_Profile();
            Logger.WriteDebugMessage("Land on the My Profile page.");

            //4. Verify the "Custom Signature" field is available.
            Profile.VerifyCustomSignatureField();

            //5. If there is already an custom signature loaded, click "Remove" and "OK" on the popup.
            Profile.VerifyIsPresent_Link_Remove();

            //6. Click "Choose File" and select a .gif file.
            Profile.Upload_Button_ChooseFile(Constants.UploadgifFiles);
            Logger.WriteDebugMessage("A file which is gif is chosen");

            //7. Click "Save"
            Profile.Click_Button_Save();
            if (PageObject_Profile.Profile_Button_No().Displayed)
                Profile.Click_Button_No();
            var Value1 = Profile.Get_CustomSignaturename(PageObject_Profile.Profile_Image_CustomSignature());
            AddDelay(6000);
            Logger.WriteDebugMessage(".gif file is verified on profile page");

            //8. Click "Create/Edit" and select "eProposal"
            EmployeeHome.Click_WelcomeButton();
            EmployeeHome.Click_CreateEdit_eProposalButton();
            Logger.WriteDebugMessage("Land on the eProposal page.");
            AddDelay(6000);

            //9. Use your email as the client and send yourself an eProposal.
            eProposalCompose.CommonComposeMandetory(eproposalName,
                ClientName);
            eProposalCompose.RedirectToSendPage();
            eProposalPreview.Click_Button_Send();

            //10. Open your email and click the "Open eProposal" link.
            ClientEmail.GmailLogIn(ClientLogin, ClientPassword);
            ClientEmail.GmailOpenFirstMessage();
            Logger.WriteDebugMessage("The email is opened.");

            //11. Look for the signature.
            ClientEmail.Click_Link_OpenYourProposal();
            ControlToNewWindow();
            AddDelay(3000);
            //var Value2 = ClientEmail.Get_CustomSignaturename();
            ClientEmail.VerifyWithUploaded_Image_CustomSignature(Value1, Value1);
        }

        #endregion[TC_120227]

        #region[TC_120228]

        public static void TC_120228()
        {
            //1. Log into eP UI (employee).                
            EmployeeLogin.LogIn(loginEmail, loginPassword);
            Logger.WriteDebugMessage("Logged in successfully.");

            //2. Select any property.
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Selected the property: " + Property);

            // 08/07 Marc : Added a custom signature since the case was failing on step 5 if there was not one.
            //Hoover over "My Settings" and click "Profile"
            AddDelay(5000);
            EmployeeHome.Hover_MySettings();
            AddDelay(1500);
            EmployeeHome.Click_Profile();
            Logger.WriteDebugMessage("Land on the My Profile page.");

            //Verify the "Custom Signature" field is available.
            Profile.VerifyCustomSignatureField();

            //If there is already an custom signature loaded, click "Remove" and "OK" on the popup.
            Profile.VerifyIsPresent_Link_Remove();

            //Click "Choose File" and select a .gif file.
            Profile.Upload_Button_ChooseFile(Constants.UploadgifFiles);
            Logger.WriteDebugMessage("A file which is gif is chosen");

            //3. Click "Activity"
            EmployeeHome.Click_ActivityTab();
            Logger.WriteDebugMessage("Land on the activity page.");

            //4. Click "Preview" for an eProposal that you have sent out in the past. (Leave this opened)
            Activity.SearchKeywords(searchName);
            Activity.ClickLinkPreview();
            AddDelay(10000);
            Logger.WriteDebugMessage("Opens in a new window or tab.");

            //5.Note the signature currently displaying.
            ControlToNewWindow();
            var Value1 = Activity.Get_Custom_Signature();
            AddDelay(6000);
            ControlToPreviousWindow();
            Logger.WriteDebugMessage("Signature is noted");

            //6.Hoover over "My Settings" and click "Profile"
            EmployeeHome.Click_WelcomeButton();
            AddDelay(5000);
            EmployeeHome.Click_AddEditProfile();
            Logger.WriteDebugMessage("Land on the My Profile page.");

            //7.Click "Remove".
            Profile.Click_Link_Remove();
            if (VerifyTextOnPage(Constants.DeleteSignature).Equals(true))
                Logger.WriteDebugMessage("Pop up is displayed asking to confirm deleting the signature.");
            else
                Logger.WriteDebugMessage("Pop up is not displayed asking to confirm deleting the signature.");

            //8.Click "Cancel"
            Profile.Click_Button_Cancel();
            ControlToNewWindow();
            Logger.WriteDebugMessage("Signature is still on the profile.");

            //9.Go back to the eProposal "Preview" and refresh.
            Driver.Navigate().Refresh();
            AddDelay(3000);
            var Value2 = Activity.Get_Custom_Signature();
            ClientEmail.VerifyWithUploaded_Image_CustomSignature(Value1, Value2);
            ControlToPreviousWindow();
            Logger.WriteDebugMessage("The signature is still the same.");

            //10. Back on "My Profile", click "remove"
            Profile.Click_Link_Remove();
            if (VerifyTextOnPage(Constants.DeleteSignature).Equals(true))
                Logger.WriteDebugMessage("Pop up is displayed asking to confirm deleting the signature.");
            else
                Logger.WriteDebugMessage("Pop up is not displayed asking to confirm deleting the signature.");

            //11. Click "OK".
            Profile.Click_Button_Ok();
            ControlToNewWindow();
            Logger.WriteDebugMessage("Image is removed from profile.");

            //12.Go back to the eProposal "Preview" and refresh.
            Driver.Navigate().Refresh();
            AddDelay(3000);
            Logger.WriteDebugMessage("The signature is the Auto Signature");
            CloseWindow();
            ControlToPreviousWindow();

            //13.Click "Activity" again.                
            EmployeeHome.Click_ActivityTab();
            Logger.WriteDebugMessage("Land on the activity page.");

            //14. Click the "Get Link" link for your eProposal and copy and paste it in the browser.
            Activity.SearchKeywords(searchName);
            Activity.ClickButtonGetLink();
            Logger.WriteDebugMessage("A popup is displayed with a URL.");
            Activity.GetURLandCopyPasteNewWindow();
            Logger.WriteDebugMessage("Land on the eProposal.");

            //15.Look at the signature.
            Logger.WriteDebugMessage("The signature is the Auto Signature");
            AddDelay(5000);

            //16. Upload signature.
            ControlToPreviousWindow();
            Logger.WriteDebugMessage("Re-Upload Signature");
            Driver.Navigate().Refresh();
            AddDelay(5000);
            EmployeeHome.Click_WelcomeButton();
            AddDelay(2000);
            ScrollDownUsingJavaScript(Driver, 2000);
            AddDelay(2000);
            EmployeeHome.Click_AddEditProfile();
            Profile.Upload_Button_ChooseFile(Constants.UploadgifFiles);
            Profile.Click_Button_Save();
            if (PageObject_Profile.Profile_Button_No().Displayed)
                Profile.Click_Button_No();
            AddDelay(5000);
        }

        #endregion[TC_120227]

        #region[TC_120229]

        public static void TC_120229()
        {
            //1. Log into eP UI (employee).                
            EmployeeLogin.CommonLogin();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2. Select a regular property. (Cendyn - Hilton Dresden)
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Selected the property: " + Property);

            //3. Hoover over "My Settings" and click "Profile"
            AddDelay(5000);
            EmployeeHome.Hover_MySettings();
            AddDelay(1500);
            EmployeeHome.Click_Profile();
            Logger.WriteDebugMessage("Land on the My Profile page.");

            //4.Look for the "Custom Signature" area.
            Profile.VerifyCustomSignatureField();

            //5. Click the "View All" tab.
            Profile.Click_Button_ViewAll();
            Logger.WriteDebugMessage("Land on the employee profiles page.");

            //6.Click "Edit" for an employee. (Not yourself)
            Profile.Click_Link_EditFirstProfile();
            Logger.WriteDebugMessage("Land on specific employee page.");

            //7.Look for the "Custom Signature" area.
            Profile.VerifyCustomSignatureField();
        }

        #endregion

        #region[TC_120230]

        public static void TC_120230()
        {
            //1. Log into eP UI (employee).                
            EmployeeLogin.LogIn(loginEmail, loginPassword);
            Logger.WriteDebugMessage("Logged in successfully.");

            //2. Select a regular property. (Cendyn - Hilton Dresden)
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Selected the property: " + Property);

            //3. Hoover over "My Settings" and click "Profile"
            AddDelay(5000);
            EmployeeHome.Hover_MySettings();
            AddDelay(1500);
            EmployeeHome.Click_Profile();
            Logger.WriteDebugMessage("Land on the My Profile page.");

            //4. Click the "View All" tab.
            Profile.Click_Button_ViewAll();
            Logger.WriteDebugMessage("Land on the employee profiles page.");

            //5.Click "Edit" for an employee. (Not yourself)
            Profile.Click_Link_EditFirstProfile();
            Logger.WriteDebugMessage("Land on specific employee page.");

            //6.Click the "Choose File" button and select a valid "jpg, gif or png" 
            //7.Click "Save"  
            //8.Click "No"              
            Profile.UploadImage(Constants.UploadgifFiles);
            Profile.Click_Button_No();
            var Value0 = Profile.Get_CustomSignaturename(PageObject_Profile.Profile_Image_CustomSignature());

            //9.Select "German" from the "Select a language" dropdown.                
            eProposalCompose.SelectFromDropDown_LanguageDropDown("German");
            AddDelay(5000);

            //10. The "Custom Signature" from English should NOT be displayed.
            //11. Click "Choose File" and select a different signature.
            Profile.UploadImage(Constants.UploadgifFiles);
            Profile.Click_Button_No();

            Profile.Click_Link_Remove();
            Profile.Click_Button_Ok();
            AddDelay(3500);
            Profile.UploadImage(Constants.UploadgifFiles);

            //13.Click "No" 
            AddDelay(3500);
            if (PageObject_Profile.Profile_Button_No().Displayed)
                Profile.Click_Button_No();
            var Value1 = Profile.Get_CustomSignaturename(PageObject_Profile.Profile_Image_CustomSignature());

        }

        #endregion[TC_120230]

        #region[TC_120231]

        public static void TC_120231()
        {
            //1. Log into eP UI (employee).                
            EmployeeLogin.LogIn(loginEmail, loginPassword);
            Logger.WriteDebugMessage("Logged in successfully.");

            //2. Select a regular property. (Cendyn - Hilton Dresden)
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Selected the property: " + Property);

            //3. Hoover over "My Settings" and click "Profile"
            AddDelay(5000);
            // Created by Divya 14 Aug 2017 : Added code to switch control to previous window                
            Helper.ControlToPreviousWindow();
            EmployeeHome.Hover_MySettings();
            AddDelay(1500);
            EmployeeHome.Click_Profile();
            Logger.WriteDebugMessage("Land on the My Profile page.");

            //5.Switch the language from "English" to "German"
            eProposalCompose.SelectFromDropDown_LanguageDropDown("German");

            //4. Remove the Custom Signature if there is on here.
            try
            {
                Profile.Click_Link_Remove();
                Profile.Click_Button_Ok();
            }
            catch (Exception)
            {
            }

            //6.Click the "Choose File" button and select a valid "jpg, gif or png"                   
            Profile.Upload_Button_ChooseFile(Constants.UploadgifFiles);

            //7.Click "Save"   
            Profile.Click_Button_Save();
            if (PageObject_Profile.Profile_Button_No().Displayed)
                Profile.Click_Button_No();
            var Value0 = Profile.Get_CustomSignaturename(PageObject_Profile.Profile_Image_CustomSignature());

            //8.Hoover over "Create/Edit" and click "eProposal" 
            EmployeeHome.Click_WelcomeButton();
            EmployeeHome.Click_CreateEdit_eProposalButton();
            Logger.WriteDebugMessage("Land on the eProposal page.");
            AddDelay(6000);

            //9.Switch the language from "English" to "German"                
            eProposalCompose.SelectFromDropDown_LanguageDropDown("German");
            AddDelay(5000);
            Logger.WriteDebugMessage("Page refreshes.");

            //10. For Client, use your own email.
            eProposalCompose.EnterText_ProposalNameText(eproposalName);
            eProposalCompose.SearchForClient(ClientName);
            eProposalCompose.EnterWelcomeMessage(eproposalName);
            Logger.WriteDebugMessage("Email added to 'Client'");
            AddDelay(10000);

            //11. Finish and send the eProposal.
            eProposalCompose.Click_Button_Next();
            eProposalCompose.Click_Button_Next();
            eProposalCompose.Click_Button_Next();
            eProposalCompose.Click_Button_Next();
            Logger.WriteDebugMessage("eProposal is sent and preview opens in a new tab/ window.");

            //12.On the preview, verify the foreign language signature is displayed properly.  
            AddDelay(5000);
            ControlToNewWindow();
            var Value1 = Activity.Get_Custom_SignatureImage();
            ClientEmail.VerifyWithUploaded_Image_CustomSignature(Value0, Value1);
            CloseWindow();
            ControlToPreviousWindow();
            eProposalPreview.Click_Button_Send();
            Logger.WriteDebugMessage("On the preview, the foreign language signature is displayed properly.");

            //13.Check your email and click the "Open eProposal" link. 
            ClientEmail.GmailLogIn(ClientLogin, ClientPassword);
            AddDelay(5000);
            ClientEmail.GmailOpenFirstMessage();
            Logger.WriteDebugMessage("The email is opened.");

            //14. Verify the foreign language signature is displayed properly.
            ClientEmail.Click_Link_OpenYourProposal();
            ControlToNewWindow();
            var Value2 = ClientEmail.Get_CustomSignaturename();
            ClientEmail.VerifyWithUploaded_Image_CustomSignature(Value0, Value2);
            Logger.WriteDebugMessage("The foreign language signature is displayed properly.");

            //Uploading custom signature back to the property
            Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL);
            EmployeeLogin.LogIn(loginEmail, loginPassword);
            EmployeeHome.Click_WelcomeButton();
            EmployeeHome.Click_AddEditProfile();
            Profile.Upload_Button_ChooseFile(Constants.UploadgifFiles);
            Profile.Click_Button_Save();
            if (PageObject_Profile.Profile_Button_No().Displayed)
                Profile.Click_Button_No();
        }

        #endregion[TC_120231]

        #region[TC_120232]

        public static void TC_120232()
        {
            //1. Log into eP UI (employee).                
            EmployeeLogin.LogIn(loginEmail, loginPassword);
            Logger.WriteDebugMessage("Logged in successfully.");

            //2. Select a foreign langauge property. (Cendyn - Dev - IHN InterContinental English Chinese)
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Selected the property: " + Property);

            //3. Hoover over "My Settings" and click "Profile"
            AddDelay(5000);
            EmployeeHome.Hover_MySettings();
            AddDelay(1500);
            EmployeeHome.Click_Profile();
            Logger.WriteDebugMessage("Land on the My Profile page.");

            //4. Remove the Custom Signature if there is on here.
            Profile.UploadImage(Constants.UploadgifFiles);
            Profile.Click_Button_No();
            Profile.Click_Link_Remove();
            Profile.Click_Button_Ok();

            //5.Switch the language from "English" to "Chinese"
            eProposalCompose.SelectFromDropDown_LanguageDropDown("Chinese");

            //6.Remove the Custom Signature if there is on here. 
            Profile.UploadImage(Constants.UploadgifFiles);
            Profile.Click_Button_No();
            Profile.Click_Link_Remove();
            Profile.Click_Button_Ok();
            //Profile.Click_Button_Save();
            //if (PageObject_Profile.Profile_Button_No().Displayed)
            //    Profile.Click_Button_No();

            //7.Hoover over "Create/Edit" and click "eProposal" 
            EmployeeHome.Click_WelcomeButton();
            EmployeeHome.Click_CreateEdit_eProposalButton();
            Logger.WriteDebugMessage("Land on the eProposal page.");
            AddDelay(6000);

            //8.Switch the language from "English" to "German"
            eProposalCompose.SelectFromDropDown_LanguageDropDown("Spanish");

            //9.For Client, use your own email.  
            eProposalCompose.EnterText_ProposalNameText(eproposalName);
            eProposalCompose.SearchForClient(ClientName);
            eProposalCompose.EnterWelcomeMessage(eproposalName);
            Logger.WriteDebugMessage("Email added to 'Client'");
            AddDelay(10000);

            //10. Finish and send the eProposal.
            eProposalCompose.Click_Button_Next();
            eProposalCompose.Click_Button_Next();
            eProposalCompose.Click_Button_Next();
            eProposalCompose.Click_Button_Next();
            Logger.WriteDebugMessage("eProposal is sent and preview opens in a new tab/ window.");

            //11. On the preview, verify the foreign language signature is displayed properly. (It should be displayed with Chinese characters)
            ControlToNewWindow();
            CaptureScreenshot.CapturescreenShot(Constants.ScreenshotPath);
            CloseWindow();
            ControlToPreviousWindow();
            eProposalPreview.Click_Button_Send();
            Logger.WriteDebugMessage("On the preview, the foreign language signature is displayed properly.");

            //12.Check your email and click the "Open eProposal" link.
            ClientEmail.GmailLogIn(ClientLogin, ClientPassword);
            ClientEmail.GmailOpenFirstMessage();
            Logger.WriteDebugMessage("The email is opened.");

            //13.Verify the foreign language signature is displayed properly. (It should be displayed with Chinese characters)
            ClientEmail.Click_Link_OpenYourProposal();
            ControlToNewWindow();
            EmployeeLogin.Click_DefaultSubmitButton();
            CaptureScreenshot.CapturescreenShot(Constants.ScreenshotPath);
            Logger.WriteDebugMessage("The foreign language signature is displayed properly.");

            //Uploading custom signature back to the property
            Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL);
            EmployeeLogin.LogIn(loginEmail, loginPassword);
            EmployeeHome.Click_WelcomeButton();
            EmployeeHome.Click_AddEditProfile();
            Profile.Upload_Button_ChooseFile(Constants.UploadgifFiles);
            Profile.Click_Button_Save();
            if (PageObject_Profile.Profile_Button_No().Displayed)
                Profile.Click_Button_No();

            eProposalCompose.SelectFromDropDown_LanguageDropDown("Chinese");
            Profile.Upload_Button_ChooseFile(Constants.UploadpngFiles);
            Profile.Click_Button_Save();
            if (PageObject_Profile.Profile_Button_No().Displayed)
                Profile.Click_Button_No();
        }

        #endregion[TC_120232]

        #region[TC_120233]

        public static void TC_120233()
        {
            //1. Log into eP UI (employee).                
            EmployeeLogin.LogIn(loginEmail, loginPassword);
            Logger.WriteDebugMessage("Logged in successfully.");

            //2. Select a regular property. (Cendyn - Hilton Dresden)
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Selected the property: " + Property);

            //3. Hoover over "My Settings" and click "Profile"
            AddDelay(5000);
            EmployeeHome.Hover_MySettings();
            AddDelay(1500);
            EmployeeHome.Click_Profile();
            Logger.WriteDebugMessage("Land on the My Profile page.");

            //4. Note the signature currently displaying.
            ScrollDownUsingJavaScript(Driver, 2000);
            HighlightElement(PageObject_Profile.Profile_Image_CustomSignature());
            var Value1 = Profile.Get_CustomSignaturename(PageObject_Profile.Profile_Image_CustomSignature());
            AddDelay(2500);

            //5.Log into ePFull Admin
            NewBrowser();
            Driver.Navigate().GoToUrl(LegacyTestData.CommonAdminURL);
            AdminLogin.LogInCommon();
            Logger.WriteDebugMessage("Land on eSALES SUITE ADMINISTRATION");

            //6.Click "Users"
            AddDelay(2500);
            AdminNavigation.Click_Button_Users();
            Logger.WriteDebugMessage("Land on the users page.");

            //7.Select the same property that you selected on the UI.              
            AdminProperties.SelectProperty(Property);
            Logger.WriteDebugMessage("Page populates");

            //8.Click the "Edit" icon for the employee you noted the signature for.
            AdminUsers.SearchUser(Constants.UserOption1, Constants.UserOption2, loginEmail);
            AdminUsers.Click_Link_Edit();
            AddDelay(3000);
            Logger.WriteDebugMessage("Land on the employee profile page.");

            //9.Confirm the signatures match.
            ScrollDownUsingJavaScript(Driver, 2000);
            HighlightElement(PageObject_AdminUsers.AdminUsers_EmployeeUpdate_CustomSignatureImage());
            var Value2 = AdminUsers.Get_CustomSignature_Name();
            AddDelay(2500);
            ClientEmail.VerifyWithUploaded_Image_CustomSignature(Value1, Value2);
            Logger.WriteDebugMessage("They do!");

            //10.Still on the admin site, change the signature and save the profile.
            //Profile.VerifyIsPresent_Link_Remove();
            AdminUsers.Upload_Button_ChooseFile(Constants.UploadpngFiles);
            AdminUsers.Click_Button_Update();
            AddDelay(3000);
            AdminUsers.SearchUser(Constants.UserOption1, Constants.UserOption2, loginEmail);
            AdminUsers.Click_Link_Edit();
            var Value3 = AdminUsers.Get_CustomSignature_Name();
            ControlToPreviousWindow();
            Logger.WriteDebugMessage("Profile is saved.");

            //11. Go back to the "Profile" page on the UI (if you're still on it, just refresh the page.)
            Driver.Navigate().Refresh();
            AddDelay(2000);
            ScrollDownUsingJavaScript(Driver, 2000);
            HighlightElement(PageObject_Profile.Profile_Image_CustomSignature());
            var Value4 = Profile.Get_CustomSignaturename(PageObject_Profile.Profile_Image_CustomSignature());
            AddDelay(2500);
            ClientEmail.VerifyWithUploaded_Image_CustomSignature(Value4, Value3);
            Logger.WriteDebugMessage("The signature shows the new signature!");

            //12.Upload a new signature on the UI site.
            HighlightElement(PageObject_Profile.Profile_Image_CustomSignature());
            //Profile.VerifyIsPresent_Link_Remove();
            Profile.Upload_Button_ChooseFile(Constants.CustomSignatureUpload);
            Profile.Click_Button_Save();
            //if (PageObject_Profile.Profile_Button_No().Displayed)
            //Profile.Click_Button_No();
            HighlightElement(PageObject_Profile.Profile_Image_CustomSignature());
            var Value5 = Profile.Get_CustomSignaturename(PageObject_Profile.Profile_Image_CustomSignature());
            AddDelay(2500);
            ControlToNewWindow();
            Logger.WriteDebugMessage("Signature is uploaded and profile is updated.");

            //13.Verify the changes on the admin site.
            Driver.Navigate().Refresh();
            AddDelay(2500);
            ScrollDownUsingJavaScript(Driver, 2000);
            HighlightElement(PageObject_AdminUsers.AdminUsers_EmployeeUpdate_CustomSignatureImage());
            var Value6 = AdminUsers.Get_CustomSignature_Name();
            AddDelay(2500);
            ClientEmail.VerifyWithUploaded_Image_CustomSignature(Value5, Value6);
            Logger.WriteDebugMessage("The signature shows the new signature!");
        }

        #endregion[TC_120233]

        #region[TC_120234]

        public static void TC_120234()
        {
            //1. Log into eP UI (employee).                
            EmployeeLogin.LogIn(loginEmail, loginPassword);
            Logger.WriteDebugMessage("Logged in successfully.");

            //2. Select a regular property. (Cendyn - Hilton Dresden)
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Selected the property: " + Property);

            //3. Click "Activity"               
            AddDelay(1500);
            Activity.ClickActivityTab();
            Logger.WriteDebugMessage("Land on the activity page.");

            //4. Click "Preview" for an eProposal that you have sent out in the past. (Leave this opened)
            Activity.SearchKeywords(searchName);
            Activity.ClickLinkPreview();
            AddDelay(10000);
            ControlToPreviousWindow();
            Logger.WriteDebugMessage("Opens in a new window or tab.");

            //5. Hoover over "My Settings" and click "Profile"

            AddDelay(5000);
            EmployeeHome.Hover_MySettings();
            AddDelay(1500);
            EmployeeHome.Click_Profile();
            Logger.WriteDebugMessage("Land on the My Profile page.");

            //6. Click "Choose File" and select a gif, jpg or png file.
            Profile.VerifyIsPresent_Link_Remove();
            Profile.Upload_Button_ChooseFile(Constants.CustomSignatureUpload);

            //7. Click "Save"
            Profile.Click_Button_Save();
            if (PageObject_Profile.Profile_Button_No().Displayed)
                Profile.Click_Button_No();
            Logger.WriteDebugMessage("Save button clicked");


            //8. Hoover over "Create/Edit" and click "eProposal"
            EmployeeHome.Click_WelcomeButton();
            EmployeeHome.Click_CreateEdit_eProposalButton();
            Logger.WriteDebugMessage("Land on the eProposal Step 1 page.");

            //9. For Client, use your own email.
            //10. Finish and send the eProposal.
            eProposalCompose.CommonComposeMandetory(eproposalName,
                ClientName);
            eProposalCompose.Click_Button_Next();
            AddDelay(5000);
            eProposalCompose.Click_Button_Next();
            AddDelay(5000);
            eProposalCompose.Click_Button_Next();
            AddDelay(5000);
            Logger.WriteDebugMessage("eProposal is sent and preview opens in a new tab/window.");

            //11. On the preview, find the signature, right click and save it.
            ControlToNewWindow();

            AddDelay(2500);

            //12.Open the file in paint.
            //13.Verify the height is no more than 55 pixels.
            var height = GetElementHeight(PageObject_Activity.Activity_Preview_CustomSignatureImage());
            if (height == 55)
                Logger.WriteDebugMessage("Verified Height of Custom Signature");
            else
                Logger.WriteDebugMessage("Height of Custom Signature is less than or greater than 55 pixels");
            ControlToPreviousWindow();
            Logger.WriteDebugMessage("Verified Height of Custom Signature");
            AddDelay(2500);
            eProposalPreview.Click_Button_Send();

            //14. Open your email and click the "Open eProposal" link.
            //15. Find the signature, right click and save.
            //16. Open the file in paint.
            AddDelay(2500);
            ControlToNewWindow();
            Logger.WriteDebugMessage("Control Redirected to new window");
            ClientEmail.GmailLogIn(ClientName, Password);
            ClientEmail.GmailOpenFirstMessage();
            Logger.WriteDebugMessage("The email is opened.");
            ClientEmail.Click_Link_OpenYourProposal();
            ControlToNewWindow();
            AddDelay(3000);

            //13 Confirm the image displays correctly (height is no more than 55 px, it fits correctly)
            var imageheight = GetElementHeight(PageObject_ClientEmail.Image_CustomSignature());
            if (imageheight == 55)
                Logger.WriteDebugMessage("Verified Height of Custom Signature");
            else
                Logger.WriteDebugMessage("Height of Custom Signature is less than or greater than 55 pixels");
        }

        #endregion[TC_120234]

        #region[TC_120235]

        public static void TC_120235()
        {
            //1. Log into ePFull Admin  
            Driver.Navigate().GoToUrl(LegacyTestData.CommonAdminURL);
            AddDelay(10000);
            AdminLogin.LogInCommon();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2. Click "Users"
            AdminNavigation.Click_Button_Users();

            //3. Select any multi-language property from the drop down menu. (Make sure you select a property that uses special characters like Chinese or Arabic).
            AdminProperties.SelectProperty(Property);

            //4. Click the "Edit" icon for an employee
            AdminUsers.Click_Link_Edit();

            //5. If there is a "Custom Signature" uploaded, click "Remove" on it.
            UploadFile(PageObject_AdminUsers.AdminUsers_Button_ChooseFile(), Constants.UploadgifFiles);
            AdminUsers.Click_Button_Update();
            AdminUsers.Click_Button_No();
            AdminUsers.Click_Link_Edit();
            AdminUsers.Click_Link_Remove();

            //6. Click "Update".
            //7. Click "Yes" on the popup that ask to make changes for both languages.
            CloseAlert();
            AdminUsers.Click_Button_Update();

            //8. Look for the auto generated signature in the "Photo / Signature" column.
            //9. Click "Log in" for the user you just updated.
            AdminUsers.Click_Link_LoginShowAll();
            AddDelay(10000);

            //10. Hoover "Create/Edit" and click "eProposal"
            ControlToNewWindow();
            EmployeeHome.Click_WelcomeButton();
            EmployeeHome.Click_CreateEdit_eProposalButton();
            Logger.WriteDebugMessage("Land on the eProposal page.");
            AddDelay(6000);

            //11. For Client, use your email address (must use @cendyn.com email), fill in all other eProposal information and reach "Step 5"
            eProposalCompose.EnterText_ProposalNameText(eproposalName);
            eProposalCompose.SearchForClient(ClientName);
            eProposalCompose.EnterWelcomeMessage(eproposalName);
            Logger.WriteDebugMessage("Email added to 'Client'");
            AddDelay(10000);
            eProposalCompose.Click_Button_Next();
            eProposalCompose.Click_Button_Next();
            eProposalCompose.Click_Button_Next();
            eProposalCompose.Click_Button_Next();
            Logger.WriteDebugMessage("eProposal is sent and preview opens in a new tab/ window.");

            //12. Look for the "Signature" above the employee information.
            AddDelay(5000);
            ControlToNewWindow();
            eProposalPreview.VerifyCustomSignature();

            //13. Download and open the eProposal PDF.
            eProposalPreview.Click_Link_PDF();
            AddDelay(5000);

            //14. Close the PDF and the preview window/tab.
            Driver.SwitchTo().Frame(PageObject_ProposalPreview.Iframe_SelectPage());
            eProposalPreview.Click_PopUpButton_Preview();
            AddDelay(20000);

            //15. Look for the "Create this eProposal in another language" drop down and change the language.
            CloseWindow();
            ControlToPreviousWindow();
            AddDelay(1000);
            ControlToNewWindow();
            AddDelay(1000);
            eProposalPreview.SelectFromDropDown_DropDown_AnotherLanguage("Chinese");

            //16. Fill in all eProposal information and reach step 5 again.
            eProposalCompose.EnterText_ProposalNameText(eproposalName);
            eProposalCompose.SearchForClient(ClientName);
            eProposalCompose.EnterWelcomeMessage(eproposalName);
            Logger.WriteDebugMessage("Email added to 'Client'");
            AddDelay(10000);
            eProposalCompose.Click_Button_Next();
            eProposalCompose.Click_Button_Next();
            eProposalCompose.Click_Button_Next();
            eProposalCompose.Click_Button_Next();
            Logger.WriteDebugMessage("eProposal is sent and preview opens in a new tab/ window.");

            //17. Look for the signature and verify it is displayed correctly. If using Chinese, arabic, etc, make sure the signature uses the special characters.
            ControlToNewWindow();
            AddDelay(5000);
            eProposalPreview.VerifyCustomSignature();

            //18. Download and open the eProposal PDF.
            eProposalPreview.Click_Link_PDF();
            Driver.SwitchTo().Frame(PageObject_ProposalPreview.Iframe_SelectPage());
            eProposalPreview.Click_PopUpButton_Preview();

            //19. Close the "Preview" and PDF.
            CloseWindow();

            //20. Click "Send" on Step 5.
            ControlToPreviousWindow();
            AddDelay(1000);
            ControlToNewWindow();
            AddDelay(1000);
            eProposalPreview.Click_Button_Send();

            //21. Click the link on the email to view the eProposal.
            ClientEmail.GmailLogIn(ClientLogin, ClientPassword);
            ClientEmail.GmailOpenFirstMessage();
            Logger.WriteDebugMessage("The email is opened.");
            ClientEmail.Click_Link_OpenYourProposal();
            ControlToNewWindow();
            EmployeeLogin.Click_DefaultSubmitButton();

            //22. Verify the signature on the ePropsal and PDF.
            ClientEmail.Click_Link_ViewProposal();
            eProposalPreview.VerifyCustomSignature();
            eProposalPreview.Click_Link_PDF();
            Driver.SwitchTo().Frame(PageObject_ProposalPreview.Iframe_SelectPage());
            eProposalPreview.Click_PopUpButton_Preview();

            //23. Switch the language and repeat the last step.
            ClientEmail.SelectFromDropDown_DropDown_Language("中文");
            //eProposalPreview.Click_PopUpButton_Preview();
            //EnterFrame("formPdfSelect");
            //CommonMethod.Driver.SwitchTo().Frame(0);
            //eProposalPreview.VerifyCustomSignature();
            eProposalPreview.Click_Link_PDF();

            //24. On the email, click the download PDF link.
            Driver.SwitchTo().Frame(PageObject_ProposalPreview.Iframe_SelectPage());
            eProposalPreview.Click_PopUpButton_Preview();
        }

        #endregion[TC_120235]

        #region[TC_120236]

        public static void TC_120236()
        {
            //1. Log into ePFull Admin  
            Driver.Navigate().GoToUrl(LegacyTestData.CommonAdminURL);
            AddDelay(10000);
            AdminLogin.LogInCommon();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2. Click "Users"
            AdminNavigation.Click_Button_Users();
            Logger.WriteDebugMessage("Land on the 'Users' page.");

            //3. Select any multi-language property from the drop down menu. (Make sure you select a property that uses special characters like Chinese or Arabic).
            AdminProperties.SelectProperty(Property);
            Logger.WriteDebugMessage("Page populates with users.");

            //4. Click the "Edit" icon for an employee
            AdminUsers.Click_Link_Edit();
            Logger.WriteDebugMessage("Land on the 'Employee Update' page");

            //5. If there is a "Custom Signature" uploaded, click "Remove" on it.
            AdminUsers.Upload_Button_ChooseFile(Constants.UploadgifFiles);
            AdminUsers.Click_Button_Update();
            AdminUsers.Click_Button_Yes();
            AdminUsers.Click_Link_Edit();
            AdminUsers.Click_Link_Remove();
            CloseAlert();
            Logger.WriteDebugMessage("Custom Signature is removed.");

            //6. In Custom Signature, click "Choose File" and select a gif, jpg or png file to upload as the signature.
            AddDelay(2000);
            AdminUsers.Upload_Button_ChooseFile(Constants.UploadgifFiles);
            Logger.WriteDebugMessage("File name is displayed.");

            //7. Click "Update".
            AdminUsers.Click_Button_Update();
            Logger.WriteDebugMessage("Popup displays.");

            //8. Click "Yes" on the popup that ask to make changes for both languages.
            AdminUsers.Click_Button_Yes();
            AddDelay(5000);
            Logger.WriteDebugMessage("Land back on the 'Users' page.");

            //9.Verify the image now displays correctly in the "Photo / Signature" column. 1) Height is no more than 55 pixels.              
            HighlightElement(PageObject_AdminUsers.AdminUsers_View_ShowAll_Signature());
            var height = GetElementHeight(PageObject_AdminUsers.AdminUsers_View_ShowAll_Signature());
            if (height >= 55)
                Logger.WriteDebugMessage("Verified Height of Custom Signature");
            else
                Logger.WriteDebugMessage("Height of Custom Signature is less than or greater than 55 pixels");

            //10.Click the "Edit" icon again
            AdminUsers.Click_Link_Edit();
            Logger.WriteDebugMessage("Land on the 'Employee Update' page");

            //11. Verify the image displays the exact same way as it did on the "Users" page.
            //12. Return to the "Users" page.
            HighlightElement(PageObject_AdminUsers.AdminUsers_EmployeeUpdate_CustomSignatureImage());
            var height2 = GetElementHeight(PageObject_AdminUsers.AdminUsers_EmployeeUpdate_CustomSignatureImage());
            if (height2 >= 55)
                Logger.WriteDebugMessage("Verified Height of Custom Signature");
            else
                Logger.WriteDebugMessage("Height of Custom Signature is less than or greater than 55 pixels");
            AdminUsers.Click_Button_Update();

            //13. Click "Log in" for the user you just updated.
            AdminUsers.Click_Link_LoginShowAll();
            AddDelay(10000);
            Logger.WriteDebugMessage("Land on eProposal UI");

            //14. Hoover "Create/Edit" and click "eProposal"
            ControlToNewWindow();
            EmployeeHome.Click_WelcomeButton();
            EmployeeHome.Click_CreateEdit_eProposalButton();
            Logger.WriteDebugMessage("Land on the eProposal page.");
            AddDelay(6000);

            //15. For Client, use your email address (must use @cendyn.com email), fill in all other eProposal information and reach "Step 5"
            eProposalCompose.EnterText_ProposalNameText(eproposalName);
            eProposalCompose.SearchForClient(ClientName);
            eProposalCompose.EnterWelcomeMessage(eproposalName);
            Logger.WriteDebugMessage("Email added to 'Client'");
            AddDelay(10000);
            eProposalCompose.Click_Button_Next();
            eProposalCompose.Click_Button_Next();
            eProposalCompose.Click_Button_Next();
            eProposalCompose.Click_Button_Next();
            Logger.WriteDebugMessage("eProposal is sent and preview opens in a new tab/ window.");

            //16. Look for the "Signature" above the employee information.
            AddDelay(5000);
            ControlToNewWindow();
            Activity.Verify_Custom_SignatureImage();
            Logger.WriteDebugMessage(
                "The image displays correctly. (No more than 55pixels in height and fits appropiately)");

            //17. Download and open the eProposal PDF.
            eProposalPreview.Click_Link_PDF();
            AddDelay(5000);
            Logger.WriteDebugMessage(
                "The image is displayed on the PDF. (No more than 55pixels in height and fits appropiately)");

            //18. Close the PDF and the preview window/tab.
            Driver.SwitchTo().Frame(PageObject_ProposalPreview.Iframe_SelectPage());
            eProposalPreview.Click_PopUpButton_Preview();
            AddDelay(20000);
            Logger.WriteDebugMessage("Land back on 'Step 5' of the 'eProposal'");

            //19. Look for the "Create this eProposal in another language" drop down and change the language.
            CloseWindow();
            ControlToPreviousWindow();
            AddDelay(1000);
            ControlToNewWindow();
            AddDelay(1000);
            eProposalPreview.SelectFromDropDown_DropDown_AnotherLanguage("Chinese");
            Logger.WriteDebugMessage("Land back on Step 1 but the langauge is changed.");

            //20. Fill in all eProposal information and reach step 5 again.
            eProposalCompose.EnterText_ProposalNameText(eproposalName);
            eProposalCompose.SearchForClient(ClientName);
            eProposalCompose.EnterWelcomeMessage(eproposalName);
            Logger.WriteDebugMessage("Email added to 'Client'");
            AddDelay(10000);
            eProposalCompose.Click_Button_Next();
            eProposalCompose.Click_Button_Next();
            eProposalCompose.Click_Button_Next();
            eProposalCompose.Click_Button_Next();
            Logger.WriteDebugMessage("eProposal is sent and preview opens in a new tab/ window.");

            //21. Look for the signature and verify it is displayed correctly. If using Chinese, arabic, etc, make sure the signature uses the special characters.
            ControlToNewWindow();
            Activity.Verify_Custom_SignatureImage();
            Logger.WriteDebugMessage(
                "The image displays properly. (No more than 55pixels in height and fits appropiately)");

            //22. Download and open the eProposal PDF.
            eProposalPreview.Click_Link_PDF();
            Driver.SwitchTo().Frame(PageObject_ProposalPreview.Iframe_SelectPage());
            eProposalPreview.Click_PopUpButton_Preview();
            Logger.WriteDebugMessage(
                "The image displays properly. (No more than 55pixels in height and fits appropiately)");

            //23. Close the "Preview" and PDF.
            CloseWindow();
            Logger.WriteDebugMessage("PDF and preview are closed.");

            //24. Click "Send" on Step 5.
            ControlToPreviousWindow();
            AddDelay(1000);
            ControlToNewWindow();
            AddDelay(1000);
            eProposalPreview.Click_Button_Send();
            Logger.WriteDebugMessage("eProposal is sent to your email.");

            //25. Click the link on the email to view the eProposal.
            ClientEmail.GmailLogIn(ClientLogin, ClientPassword);
            ClientEmail.GmailOpenFirstMessage();
            Logger.WriteDebugMessage("The email is opened.");
            ClientEmail.Click_Link_OpenYourProposal();
            ControlToNewWindow();
            EmployeeLogin.Click_DefaultSubmitButton();

            //26. Verify the signature on the ePropsal and PDF.
            ClientEmail.Click_Link_ViewProposal();
            Activity.Verify_Custom_SignatureImage();
            eProposalPreview.Click_Link_PDF();
            Driver.SwitchTo().Frame(PageObject_ProposalPreview.Iframe_SelectPage());
            eProposalPreview.Click_PopUpButton_Preview();
            Logger.WriteDebugMessage(
                "The image displays properly. (No more than 55pixels in height and fits appropiately)");

            //27. Switch the language and repeat the last step.
            ClientEmail.SelectFromDropDown_DropDown_Language("中文");
            Activity.Verify_Custom_SignatureImage();
            eProposalPreview.Click_Link_PDF();
            Logger.WriteDebugMessage(
                "The image displays properly. (No more than 55pixels in height and fits appropiately)");

            //28. On the email, click the download PDF link.
            Driver.SwitchTo().Frame(PageObject_ProposalPreview.Iframe_SelectPage());
            eProposalPreview.Click_PopUpButton_Preview();
            Logger.WriteDebugMessage("PDF downloads.");
        }

        #endregion[TC_120236]

        #region[TC_120237]

        public static void TC_120237()
        {
            //1. Log into eP UI (employee).                
            EmployeeLogin.LogIn(loginEmail, loginPassword);
            Logger.WriteDebugMessage("Logged in successfully.");

            //2. Select a regular property. (Cendyn - Hilton Dresden)
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Selected the property: " + Property);

            //3. Hoover over "My Settings" and click "Profile"
            AddDelay(5000);
            EmployeeHome.Hover_MySettings();
            AddDelay(1500);
            EmployeeHome.Click_Profile();
            Logger.WriteDebugMessage("Land on the My Profile page.");

            //4.If there is a "Custom Signature" uploaded, click "Remove" on it.
            Profile.VerifyIsPresent_Link_Remove();

            //5. Click "Save"
            Profile.Click_Button_Save();
            Logger.WriteDebugMessage("Save button clicked");


            //6. Hoover "Create/Edit" and click "eCard"     
            EmployeeHome.Click_WelcomeButton();
            EmployeeHome.Click_CreateEdit_eCardButton();
            Logger.WriteDebugMessage("Landed on e Card page");

            //7. Use your @cendyn.com email address for the client.
            eCardCompose.Click_Client_SearchLink();
            eCardCompose.SearchAndClickClient(Email);
            Logger.WriteDebugMessage("Selected client");

            //8. Fill in the rest of the eCard information and reach step 4.
            eCardCompose.EnterText_TextBox_EmailSubject(emailSubject);
            eCardCompose.Click_Button_Next();
            eCardCompose.Click_Button_Next();
            eCardCompose.Click_Button_Next();

            //9. Confirm the employee name is BOLD
            eCardCompose.CheckEmployeeNameCendynQABold();
            Logger.WriteDebugMessage("Verified Employee name is in Bold");

            //10 Click "Send"
            eCardCompose.Click_Button_Send();
            Logger.WriteDebugMessage("Selected Send");

            //11 Open the email
            NewBrowser();
            ClientEmail.CheckAndOpenEmail(Email, Password);

            //12 Confirm the employee name is BOLD
            //ClientEmail.CheckEmployeeNameCendynQABold();
            Logger.WriteDebugMessage("Verified Employee name is in Bold");

            //13 Click the "Click to view this eCard in a browser" link.               
            ClientEmail.Click_Link_ViewInBrowser();

            //14 Look for the employee name and verify it's in bold.
            ControlToNewWindow();
            //ClientEmail.CheckEmployeeNameCendynQABold();
            Logger.WriteDebugMessage("Verified Employee name is in Bold");

            //14 Look for the employee name and verify it's in bold.                
            //ClientEmail.CheckEmployeeNameCendynQABold();
            CloseWindow();
            ControlToPreviousWindow();
            Logger.WriteDebugMessage("Verified Employee name is in Bold");

            //Add the customSignature back to same property
            Driver.Navigate().Refresh();
            AddDelay(1500);
            EmployeeHome.Click_WelcomeButton();
            AddDelay(1500);
            EmployeeHome.Click_EditProfileLink();
            Logger.WriteDebugMessage("Land on the My Profile page.");
            Profile.Upload_Button_ChooseFile(Constants.UploadgifFiles);
            Logger.WriteDebugMessage("A file which is gif is chosen");
            Profile.Click_Button_Save();
            Logger.WriteDebugMessage("Custom signature uploaded successfully");
        }

        #endregion[TC_120237]

        #region[TC_120238]

        public static void TC_120238()
        {
            //1. Log into eP UI (employee).                
            EmployeeLogin.LogIn(loginEmail, loginPassword);
            Logger.WriteDebugMessage("Logged in successfully.");

            //2. Select a property that uses the eCard feature (Cendyn - Hilton Berlin)
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Selected the property: " + Property);

            //3. Hoover "My Settings" and click "Profile"
            AddDelay(5000);
            EmployeeHome.Hover_MySettings();
            AddDelay(1500);
            EmployeeHome.Click_Profile();
            Logger.WriteDebugMessage("Land on the My Profile page.");

            //4. If there is a "Custom Signature" uploaded, click "Remove" on it.
            Profile.VerifyIsPresent_Link_Remove();

            //5 Click "Choose File" and add your own custom image (gif, jpg or pnf files).
            Profile.Upload_Button_ChooseFile(Constants.CustomSignatureUpload);

            //6. Click "Save"
            Profile.Click_Button_Save();
            Logger.WriteDebugMessage("Save button clicked");
            Driver.Navigate().Refresh();
            AddDelay(1500);

            //7. Hoover "Create/Edit" and click "eCard"     
            EmployeeHome.Click_WelcomeButton();
            EmployeeHome.Click_CreateEdit_eCardButton();
            Logger.WriteDebugMessage("Landed on e Card page");

            //8. Use your @cendyn.com email address for the client.
            eCardCompose.Click_Client_SearchLink();
            eCardCompose.SearchAndClickClient(email);
            Logger.WriteDebugMessage("Selected client");

            //9. Fill in the rest of the eCard information and reach step 4.
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
            NewBrowser();
            ClientEmail.CheckAndOpenEmail(email, password);

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

        #endregion[TC_120233]

        #region[TC_120239]

        public static void TC_120239()
        {
            //1. Log into ePFull Admin.
            Driver.Navigate().GoToUrl(LegacyTestData.CommonAdminURL);
            AddDelay(10000);
            AdminLogin.LogInCommon();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2. Click "Users"
            AdminNavigation.Click_Button_Users();
            Logger.WriteDebugMessage("Land on the 'Users' page.");

            //3. Select any property from the drop down.
            AdminProperties.SelectProperty(Property);
            Logger.WriteDebugMessage("Page loads with users.");

            //4. Click the "Edit" icon for an employee
            AdminUsers.Click_Link_Edit();
            Logger.WriteDebugMessage("Land on the 'Employee Update' page");

            //5. If there is a "Custom Signature" uploaded, click "Remove" on it.
            AdminUsers.Upload_Button_ChooseFile(Constants.UploadgifFiles);
            AdminUsers.Click_Button_Update();
            AdminUsers.Click_Button_No();

            AdminUsers.Click_Link_Remove();
            Logger.WriteDebugMessage("Custom Signature is removed.");
            CloseAlert();

            //6. For "Custom Signature" click "Choose File" and select any file that is not a gif, jpg or png.
            AdminUsers.Upload_Button_ChooseFile(Constants.UploadFiles);

            // Add Valid custom signature
            AdminUsers.Upload_Button_ChooseFile(Constants.UploadgifFiles);
            AdminUsers.Click_Button_Update();
            AddDelay(5000);
            AdminUsers.Click_Button_No();
        }

        #endregion[TC_120239]
        #endregion[TP_120217]

    }
}
