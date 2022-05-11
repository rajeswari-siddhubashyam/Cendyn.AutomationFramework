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
using eProposal.PageObject.UI;
using System.Text.RegularExpressions;

namespace eProposal.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        #region[TP_89339]

        private static string videoLink = "https://www.youtube.com/watch?v=6rSlbv8hDew";
        private static string videoName = "Motivational";
        private static string folder = "Videos";

        #region[TC_87928]

        public static void TC_87928()
        {

            OpenNewTab();
            ControlToNewWindow();
            Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL);
            //1 Log into eProposal
            EmployeeLogin.CommonDemoLogin();
            Logger.WriteDebugMessage("Logged in successfully.");
            AddDelay(8000);
            if (IsElementVisible(Driver.FindElement(By.XPath("//img[@alt='Product Nav Dropdown']"))))
            {
                ElementClick(Driver.FindElement(By.XPath("(//span[contains(text(), 'eProposal')])[2]")));
                AddDelay(30000);
                Driver.SwitchTo().Frame(1);
                if (IsElementPresent(By.XPath("//a[contains(text(),'Agree and Proceed')]")))
                {
                    ElementClick(Driver.FindElement(By.XPath("//a[contains(text(),'Agree and Proceed')]")));
                    if (IsElementPresent(By.XPath("//a[contains(text(),'Close')]")))
                    {
                        ElementClick(Driver.FindElement(By.XPath("//a[contains(text(),'Close')]")));
                    }

                }
                Driver.SwitchTo().ParentFrame();
            }

            //2 Select test property and assign the property type
            //EmployeeHome.Demo_SelectProperty(TestData.TC_87928_PropertyName);
            //PropertyType = Constants.PropertyType_Regular;
            //Logger.WriteDebugMessage("Selected the property: " + TestData.TC_87928_PropertyName);

            //3 Navigate to the eProposal Facetime page.
            EmployeeHome.Click_CreateEdit_eFacetimeButton();
            ControlToNewWindow();
            Driver.Manage().Window.Maximize();
            Logger.WriteDebugMessage("Landed on the eFacetime page.");

            //4 Click any folder.
            AddDelay(1500);
            Driver.SwitchTo().Frame(0);
            eFaceTime.Click_Link_Folder1();
            Logger.WriteDebugMessage("Videos inside the folder are displayed.");

            //5.Click "Preview" for any video.
            eFaceTime.Click_Link_Preview();
            Logger.WriteDebugMessage("A popup is displayed. ");

            //7. Click "Delete Video".
            eFaceTime.Click_Link_Delete();
            CloseAlert();
            ExitFrame();
            Logger.WriteDebugMessage("The URL in the popup displays 'eft - dev.vidcomdev.com'.");
        }
        #endregion[TC_87928]

        #region[TC_89354]

        public static void TC_89354()
        {
            OpenNewTab();
            ControlToNewWindow();
            Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL);
            //1 Log into eProposal
            EmployeeLogin.CommonDemoLogin();
            Logger.WriteDebugMessage("Logged in successfully.");
            AddDelay(8000);
            if (IsElementVisible(Driver.FindElement(By.XPath("//img[@alt='Product Nav Dropdown']"))))
            {
                ElementClick(Driver.FindElement(By.XPath("(//span[contains(text(), 'eProposal')])[2]")));
                AddDelay(30000);
                Driver.SwitchTo().Frame(1);
                if (IsElementPresent(By.XPath("//a[contains(text(),'Agree and Proceed')]")))
                {
                    ElementClick(Driver.FindElement(By.XPath("//a[contains(text(),'Agree and Proceed')]")));
                    if (IsElementPresent(By.XPath("//a[contains(text(),'Close')]")))
                    {
                        ElementClick(Driver.FindElement(By.XPath("//a[contains(text(),'Close')]")));
                    }

                }
                Driver.SwitchTo().ParentFrame();
            }

            //2 Select test property and assign the property type
            //EmployeeHome.SelectProperty(TestData.TC_89354_PropertyName);
            //PropertyType = Constants.PropertyType_Regular;
            //Logger.WriteDebugMessage("Selected the property: " + TestData.TC_89354_PropertyName);

            //3. Click the "Create/Edit a FaceTime Video" link in the side nav.
            EmployeeHome.Click_CreateEdit_eFacetimeButton();
            ControlToNewWindow();
            Driver.Manage().Window.Maximize();
            Logger.WriteDebugMessage("Landed on the eFacetime page.");

            //4. Click "Add Video"
            AddDelay(1500);
            Driver.SwitchTo().Frame(0);
            eFaceTime.Click_Button_AddVideo();
            Logger.WriteDebugMessage("Add Video popup is displayed.");

            //5. Upload a video.
            eFaceTime.AddVideo(videoName, folder, videoLink);
            Logger.WriteDebugMessage("Video is attached.");

            //7. Close the "eFacetime" popup.
            CloseWindow();
            ControlToPreviousWindow();
            Logger.WriteDebugMessage("Popup is closed.");

            //8. Click "Create/Edit -> eProposal"
            EmployeeHome.Click_CreateEdit_eProposalButton();
            Logger.WriteDebugMessage("Land on the eProposal Step 1 page.");

            //9. Fill in all required fields and eProposal information and reach the "Select" step.
            eProposalCompose.CommonRequiredFields();
            eProposalCompose.Click_Button_Next();

            //10. Click "Select a Video"
            eProposalSelect.Click_Link_SelectVideo();
            ControlToNewWindow();
            Driver.Manage().Window.Maximize();
            Logger.WriteDebugMessage("Landed on the eFacetime page.");

            //11. Select your video and click "Select" 
            AddDelay(1500);
            Driver.SwitchTo().Frame(0);
            eFaceTime.Click_Link_Folder1();
            eFaceTime.Click_Link_Select1();
            AddDelay(5000);
            Logger.WriteDebugMessage("'Video Selected' message is displayed. ");

            //12.Click "Attach Your Video" 
            ExitFrame();
            eFaceTime.Click_Button_AttachYourVideo();
            Logger.WriteDebugMessage("The popup is closed and 'View Your Video' is now displayed.");

            //13.Click "View Your Video"
            ControlToPreviousWindow();
            eProposalSelect.Click_Link_ViewYourVideo();
            ControlToNewWindow();
            Driver.Manage().Window.Maximize();
            Logger.WriteDebugMessage("The video is displayed in a popup.");

            //14.Verify the URL includes "eft-dev.vidcomdev.com" 
            eProposalSelect.VerifyAttachedVideoURL();
            Logger.WriteDebugMessage("It does!");

            //15.Close the popup.
            CloseWindow();
            Logger.WriteDebugMessage("Popup is closed. ");


        }
        #endregion[TC_89354]

        #region[TC_90245]
        public static void TC_90245()
        {
            OpenNewTab();
            ControlToNewWindow();
            Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL);
            //1 Log into eProposal
            EmployeeLogin.CommonDemoLogin();
            Logger.WriteDebugMessage("Logged in successfully.");
            AddDelay(8000);
            if (IsElementVisible(Driver.FindElement(By.XPath("//img[@alt='Product Nav Dropdown']"))))
            {
                ElementClick(Driver.FindElement(By.XPath("(//span[contains(text(), 'eProposal')])[2]")));
                AddDelay(30000);
                Driver.SwitchTo().Frame(1);
                if (IsElementPresent(By.XPath("//a[contains(text(),'Agree and Proceed')]")))
                {
                    ElementClick(Driver.FindElement(By.XPath("//a[contains(text(),'Agree and Proceed')]")));
                    if (IsElementPresent(By.XPath("//a[contains(text(),'Close')]")))
                    {
                        ElementClick(Driver.FindElement(By.XPath("//a[contains(text(),'Close')]")));
                    }

                }
                Driver.SwitchTo().ParentFrame();
            }


            //2 Select the property that uses eFaceTime.
            //EmployeeHome.SelectProperty(TestData.TC_90245_PropertyName);
            //PropertyType = Constants.PropertyType_Regular;
            //Logger.WriteDebugMessage("Selected the property: " + TestData.TC_90245_PropertyName);

            //3. Click "Create/Edit -> eFaceTime".
            EmployeeHome.Click_CreateEdit_eFacetimeButton();
            ControlToNewWindow();
            Driver.Manage().Window.Maximize();
            Logger.WriteDebugMessage("eFaceTime popup is displayed.");

            //4. Click "Add Video"
            AddDelay(1500);
            Driver.SwitchTo().Frame(0);
            eFaceTime.Click_Button_AddVideo();
            Logger.WriteDebugMessage("Add Video popup is displayed.");

            //5. Give the video a name.
            eFaceTime.Enter_YourVideoName(videoName);
            Logger.WriteDebugMessage("The name is entered.");

            //6. Select a folder.
            eFaceTime.Select_Folder(folder);
            Logger.WriteDebugMessage("The folder is selected.");

            //7. Click "Upload Video"
            eFaceTime.Click_Button_UploadVideo();
            Logger.WriteDebugMessage("Upload Video window is displayed.");

            //8. Click "Select Video(s)"
            OpenPopUpWindow(PageObject_eFaceTime.eFaceTime_Button_SelectVideos());
            AddDelay(3000);
            Logger.WriteDebugMessage("Drag Files Here pop up is displayed.");

            //9. Select a video.
            //ControlToNewWindow();
            //UploadFile(PageObject_eFaceTime.eFaceTime_Button_ChooseFile(), Constants.UploadVideo);
            eFaceTime.UploadVideo();
            AddDelay(25000);
            Driver.SwitchTo().Window(UIWindow);
            Logger.WriteDebugMessage("Popup closes and a message is displayed 'Uploaded 1 file.The video files are encoding and will be available in approximately X minutes.'");

            ////11.Click "Ok"
            //AddDelay(1500);
            //eFaceTime.Click_Button_OkButton();
            //Logger.WriteDebugMessage("Popup closes.");

            //12. Close the "eFacetime" popup.
            CloseWindow();
            ControlToPreviousWindow();
            Logger.WriteDebugMessage("Popup is closed.");

            //13. Wait the time you were told to wait then click the "Create/Edit -> eFaceTime" button again.
            EmployeeHome.Click_CreateEdit_eFacetimeButton();
            Logger.WriteDebugMessage("eFaceTime popup is displayed.");

        }
        #endregion[TC_90245]

        #region[TC_90246]
        public static void TC_90246()
        {
            OpenNewTab();
            ControlToNewWindow();
            Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL);
            //1 Log into eProposal
            EmployeeLogin.CommonDemoLogin();
            Logger.WriteDebugMessage("Logged in successfully.");
            AddDelay(8000);
            if (IsElementVisible(Driver.FindElement(By.XPath("//img[@alt='Product Nav Dropdown']"))))
            {
                ElementClick(Driver.FindElement(By.XPath("(//span[contains(text(), 'eProposal')])[2]")));
                AddDelay(30000);
                Driver.SwitchTo().Frame(1);
                if (IsElementPresent(By.XPath("//a[contains(text(),'Agree and Proceed')]")))
                {
                    ElementClick(Driver.FindElement(By.XPath("//a[contains(text(),'Agree and Proceed')]")));
                    if (IsElementPresent(By.XPath("//a[contains(text(),'Close')]")))
                    {
                        ElementClick(Driver.FindElement(By.XPath("//a[contains(text(),'Close')]")));
                    }

                }
                Driver.SwitchTo().ParentFrame();
            }

            //2 Select the property that uses eFaceTime.
            //EmployeeHome.SelectProperty(TestData.TC_90246_PropertyName);
            //PropertyType = Constants.PropertyType_Regular;
            //Logger.WriteDebugMessage("Selected the property: " + TestData.TC_90246_PropertyName);

            //3. Click "Create/Edit -> eFaceTime".
            EmployeeHome.Click_CreateEdit_eFacetimeButton();
            ControlToNewWindow();
            Driver.Manage().Window.Maximize();
            Logger.WriteDebugMessage("eFaceTime popup is displayed.");

            //4. Click "Add Video"
            AddDelay(1500);
            Driver.SwitchTo().Frame(0);
            eFaceTime.Click_Button_AddVideo();
            Logger.WriteDebugMessage("Add Video popup is displayed.");

            //5. Give the video a name.
            eFaceTime.Enter_YourVideoName(videoName);
            Logger.WriteDebugMessage("The name is entered.");

            //6. Select a folder.
            eFaceTime.Select_Folder(folder);
            Logger.WriteDebugMessage("The folder is selected.");

            //7. Click "Upload Video"
            eFaceTime.Click_Button_UploadVideo();
            Logger.WriteDebugMessage("Upload Video window is displayed.");

            //8. Click "Select Video(s)"
            OpenPopUpWindow(PageObject_eFaceTime.eFaceTime_Button_SelectVideos());
            AddDelay(3000);
            Logger.WriteDebugMessage("Drag Files Here pop up is displayed.");

            //9. Select multiple videos.
            //UploadFile(PageObject_eFaceTime.eFaceTime_Button_ChooseFile(), Constants.UploadVideo);
            eFaceTime.UploadVideo();
            AddDelay(25000);
            Driver.SwitchTo().Window(UIWindow);
            Logger.WriteDebugMessage("Popup closes and a message is displayed 'Uploaded 1 file.The video files are encoding and will be available in approximately X minutes.'");

            ////11.Click "Ok"
            //AddDelay(1500);
            //ControlToNewWindow();
            //Driver.SwitchTo().Frame(2);
            //eFaceTime.Click_Button_OkButton();
            //Logger.WriteDebugMessage("Popup closes.");

            //12. Close the "eFacetime" popup.
            CloseWindow();
            ControlToPreviousWindow();
            Logger.WriteDebugMessage("Popup is closed.");

            //13. Wait the time you were told to wait then click the "Create/Edit -> eFaceTime" button again.
            EmployeeHome.Click_CreateEdit_eFacetimeButton();
            Logger.WriteDebugMessage("eFaceTime popup is displayed.");

        }
        #endregion[TC_90246]

        #endregion[TP_89339]

    }
}
