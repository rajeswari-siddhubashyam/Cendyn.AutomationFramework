using System;
using eLoyaltyV3.PageObject.UI;
using eLoyaltyV3.AppModule.UI;
using System.Collections.Generic;
using NUnit.Framework;
using eLoyaltyV3.Entity;
using InfoMessageLogger;
using TestData;
using eLoyaltyV3.PageObject.Admin;
using BaseUtility.Utility;
using Queries = eLoyaltyV3.Utility.Queries;
using Constants = eLoyaltyV3.Utility.Constants;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : eLoyaltyV3.Utility.Setup
    {
        #region TP_207379 - Admin Offers
        public static void TC_109687()
        {
            if (TestCaseId == Constants.TC_109687)
            {
                // Pre-requisites
                string title, visibilityStartDate, visibilityEndDate, promotionDescription, promotionValidation, promotionCode, buttonName, shortdescription,imagePath, title_Edit, visiblityStartDate_Edit, visiblityEndDate_Edit, shortDescription_edit;
                Users data = new Users();
                Random ran_number = new Random();

                //Assign Values to variables
                title = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Title"), ran_number.Next().ToString());
                visibilityStartDate = TestData.ExcelData.TestDataReader.ReadData(1, "VisibilityStartDate");
                visibilityEndDate = TestData.ExcelData.TestDataReader.ReadData(1, "VisibilityEndDate");
                promotionDescription = MakeUnique("Promotion");
                promotionValidation = TestData.ExcelData.TestDataReader.ReadData(1, "PromotionValidation");
                promotionCode = ran_number.Next().ToString();
                buttonName = String.Concat("Button_", promotionCode);
                shortdescription = TestData.ExcelData.TestDataReader.ReadData(1, "ShortDescription");
                imagePath = String.Concat(ProjectPath,TestData.ExcelData.TestDataReader.ReadData(1, "ImagePath"));
                title_Edit = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Title_Edit"), ran_number.Next().ToString());
                visiblityStartDate_Edit = TestData.ExcelData.TestDataReader.ReadData(1, "VisibilityStartDate_Edit");
                visiblityEndDate_Edit = TestData.ExcelData.TestDataReader.ReadData(1, "VisibilityEndDate_Edit");
                shortDescription_edit = TestData.ExcelData.TestDataReader.ReadData(1, "ShortDescription_Edit");

                //Retrieve Member Level as well as Hotel Name
                Queries.GetMemberLevel(data, 1);
                Queries.IdentifyHotel(data);

                // Login to Admin with valid Credentials
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("User landed on home page");
                AddDelay(1500);

                //Navigate to Loyalty Setup -> Offer tab
                Admin.Click_Menu_LoyaltySetup();
                AddDelay(1500);
                Admin.Click_SubTab_Offers();
                Logger.WriteDebugMessage("user landed on offer list screen");

                //Click on Add Offer
                Admin.Click_LoyaltySetUp_Offers_Button_AddOffers();
                Logger.WriteDebugMessage("User landed on Add offer page");

                //Without Entering any details click on Save Button
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                Logger.WriteDebugMessage("Warning messages for Mandatory fileds are displayed on the screen");
                
                //Enter all the fields and click on Save
                Admin.AddORUpdateOffers(title, visibilityStartDate, visibilityEndDate, data.MembershipLevel, visibilityStartDate, visibilityEndDate, shortdescription);

                //Upload Image
                Admin.UploadImage(imagePath);
                AddDelay(8000);
                Logger.WriteDebugMessage("Entered all Mandatory fields on Add Offer Page");
         
                //Enter Save button and Verify the Promotion details are mandatory
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                VerifyTextOnPageAndHighLight(promotionValidation);
                Logger.WriteDebugMessage("Warning for Promotion as Mandatory field is displayed");

                //Enter Promotion Details
                Admin.AddPromotion(promotionCode, buttonName, data.PropertyName, promotionDescription, ProjectName);
                Admin.Click_LoyaltySetUp_Offers_Button_ConfirmPromotion();
                Logger.WriteDebugMessage("Promotion is added successfully");
                AddDelay(2500);
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                AddDelay(3000);
                VerifyTextOnPage("Save successful.");
                try
                {
                    Admin.Click_LoyaltySetUp_Offers_Button_Cancel();
                    Logger.WriteDebugMessage("User should land on the Offer grid page and newly added offer should get displayed");
                }
                catch (Exception)
                {
                    Logger.WriteDebugMessage("User should land on the Offer grid page and newly added offer should get displayed");
                }


                //Verify the added Offer
                Admin.LoyaltySetUp_Offers_Text_Filter(title);
                AddDelay(1500);
                VerifyTextOnPageAndHighLight(title);
                Logger.WriteDebugMessage("Offer got added successfully");

                //Edit the offer
                Admin.Click_LoyaltySetUp_Offers_Icon_Edit();
                Logger.WriteDebugMessage("Offer Opened for Edit");
                Queries.GetMemberLevel(data, 2);
                Admin.AddORUpdateOffers(title_Edit, visiblityStartDate_Edit, visiblityEndDate_Edit, data.MembershipLevel, visiblityStartDate_Edit, visiblityEndDate_Edit, shortDescription_edit);
                Logger.WriteDebugMessage("Offer Information is edited on the Add Offer Page");
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                AddDelay(3000);
                VerifyTextOnPage("Save successful.");
                try
                {
                    Admin.Click_LoyaltySetUp_Offers_Button_Cancel();
                    Logger.WriteDebugMessage("User should land on the Offer grid page and newly added offer should get displayed");
                }
                catch (Exception)
                {
                    Logger.WriteDebugMessage("User should land on the Offer grid page and newly added offer should get displayed");
                }

                //Verify the edited offer on Offer Page
                Admin.LoyaltySetUp_Offers_Text_Filter(title_Edit);
                AddDelay(1500);
                VerifyTextOnPageAndHighLight(title_Edit);
                VerifyTextOnPage(visiblityStartDate_Edit);
                VerifyTextOnPage(visiblityEndDate_Edit);
                Logger.WriteDebugMessage("Details entered while Editing offer should display");
            }
        }

      //public static void TC_109739()
      //  {
      //      if (TestCaseId == Constants.TC_109739)
      //      {
      //          Users data = new Users();
      //          //Pre - Requisite: 
      //          //Edit or create Existing offer with following criteria
      //          //Member Level: Crystal
      //          //Promotion Period: currently active (today should fall between Start and End date)
      //          //Hotel Selection: any one
      //          //Title ANY
      //          //Offer code: Any unique value
      //          //Button Text: Book Now
      //          //Short Description: any with Unique identifier so that it is easy to locate the offer
      //          //Description: Any description with bullets
      //          //Image : any
      //          //Terms & Condition: Any description with links
      //          AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
      //          AddDelay(2500);
      //          string awardtitle = TestData.ExcelData.TestDataReader.ReadData(1, "Title");
      //          string promotionCode = TestData.ExcelData.TestDataReader.ReadData(1, "PromotionCode");
      //          string button = TestData.ExcelData.TestDataReader.ReadData(1, "ButtonText");
      //          Admin.Click_Menu_LoyaltySetup();
      //          AddDelay(1500);
      //          Admin.Click_SubTab_Offers();
      //          string title = awardtitle;
      //          Admin.LoyaltySetUp_Offers_Text_Filter(title);
      //          AddDelay(1500);
      //          string visibilityStartDate = DateTime.Now.ToString("MM/dd/yyyy");
      //          string visibilityEndDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
      //          Queries.GetMemberLevel(data, 1);
      //          string level = data.Membershiplevel;
      //          string promotionDescription = MakeUnique("Promotion");
      //          Queries.IdentifyHotel(data);
      //          string hotel = data.PropertyName;
      //          Admin.Click_LoyaltySetUp_Offers_Icon_Edit();
      //          Admin.AddORUpdateOffers(title, visibilityStartDate, visibilityEndDate, level, visibilityStartDate, visibilityEndDate, "Test");
      //          Admin.LoyaltySetUp_Offers_SelectMemberLevelALL();
      //          Admin.Click_LoyaltySetUp_Offers_Button_EditPromotion();
      //          Admin.UpdatePromotion(promotionCode, button, hotel, promotionDescription, ProjectName);
      //          Admin.Click_LoyaltySetUp_Offers_Button_Save();
      //          VerifyTextOnPage("Save successful.");

      //          //1.URL and Credential is available in Test Plan description
      //          //2.Data Requirement: Login credential for Member in Crystal, Sapphire, Diamond and Platinum
      //          //3.Sign to frontend as Crystal member
      //          Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
      //          Queries.GetDataAsPerMemberLevel(level, data);
      //          string email = data.eMail;
      //          SignIn.LogIn(email, ProjectDetails.CommonFrontendPassword, ProjectName);
      //          Logger.WriteDebugMessage("user landed on home page");
      //          AddDelay(5000);

      //          //4.Navigate to Exclusive offer
      //          Navigation.Click_Link_Exclusive();
      //          Logger.WriteDebugMessage("user landed on Exclusive offer page");

      //          //5.Verify Crystal member will be able to view the offer that was created / updated as in pre-requisite                
      //          VerifyTextOnPage(title.ToUpper());
      //          Logger.WriteDebugMessage("offer should be visible to Crystal member");
      //          Navigation.ClickSignOut(ProjectName);

      //          //6.Verify the same offer gets displayed before you sign in under the Exclusive offer ​​
      //          Navigation.Click_Link_LoginExclusives();
      //          AddDelay(2500);
      //          VerifyTextOnPageAndHighLight(title);
      //          Logger.WriteDebugMessage("Offer gets displayed before you sign in under the Exclusive offer , but Book now and share offer , won't be available ​");

      //          //7.Sign to frontend as Sapphire member and verify the offer availability in Exclusive offer page
      //          Navigation.Click_Link_SignIn();
      //          Queries.GetMemberLevel(data, 2);
      //          string level1 = data.Membershiplevel;
      //          Queries.GetDataAsPerMemberLevel(level1, data);
      //          string email1 = data.eMail;
      //          SignIn.LogIn(email1, ProjectDetails.CommonFrontendPassword, ProjectName);
      //          AddDelay(5000);
      //          VerifyTextOnPage(title);
      //          Logger.WriteDebugMessage("Offer should be visible to Sapphire member");
      //          AddDelay(5000);
      //          Navigation.ClickSignOut(ProjectName);

      //          //8.Verify the same offer gets displayed before you sign in under the Exclusive offer ​​
      //          Navigation.Click_Link_LoginExclusives();
      //          AddDelay(2500);
      //          VerifyTextOnPageAndHighLight(title);
      //          Logger.WriteDebugMessage("Offer gets displayed before you sign in under the Exclusive offer , but Book now and share offer , won't be available ​");

      //          //9.Sign to frontend as diamond member and verify the offer availability in Exclusive offer page
      //          Navigation.Click_Link_SignIn();
      //          Queries.GetMemberLevel(data, 3);
      //          string level2 = data.Membershiplevel;
      //          Queries.GetDataAsPerMemberLevel(level2, data);
      //          string email2 = data.eMail;
      //          SignIn.LogIn(email2, ProjectDetails.CommonFrontendPassword, ProjectName);
      //          AddDelay(5000);
      //          VerifyTextOnPage(title);
      //          Logger.WriteDebugMessage("Offer should be visible to Diamond member");
      //          AddDelay(5000);
      //          Navigation.ClickSignOut(ProjectName);

      //          //8.Verify the same offer gets displayed before you sign in under the Exclusive offer ​​
      //          Navigation.Click_Link_LoginExclusives();
      //          AddDelay(2500);
      //          VerifyTextOnPageAndHighLight(title);
      //          Logger.WriteDebugMessage("Offer gets displayed before you sign in under the Exclusive offer , but Book now and share offer , won't be available ");

      //          if (ProjectName.Equals("Fraser"))
      //          {
      //              //9.Sign to frontend as Platinum member and verify the offer availability in Exclusive offer page
      //              Navigation.Click_Link_SignIn();
      //              Queries.GetMemberLevel(data, 4);
      //              string level3 = data.Membershiplevel;
      //              Queries.GetDataAsPerMemberLevel(level3, data);
      //              string email3 = data.eMail;
      //              SignIn.LogIn(email3, ProjectDetails.CommonFrontendPassword, ProjectName);
      //              AddDelay(5000);
      //              VerifyTextOnPage(title);
      //              Logger.WriteDebugMessage("Offer should be visible to platinum member");
      //              AddDelay(5000);
      //              Navigation.ClickSignOut(ProjectName);

      //              //8.Verify the same offer gets displayed before you sign in under the Exclusive offer ​​
      //              Navigation.Click_Link_LoginExclusives();
      //              AddDelay(2500);
      //              VerifyTextOnPageAndHighLight(title);
      //              Logger.WriteDebugMessage("Offer gets displayed before you sign in under the Exclusive offer , but Book now and share offer , won't be available ");
      //          }
      //      }
      //  }

        public static void TC_109741()
        {
            if (TestCaseId == Constants.TC_109741)
            {
                Users data = new Users();

                //Pre - Requisite: 
                //Edit or create Existing offer with following criteria
                //Member Level: Crystal
                //Promotion Period: currently active (today should fall between Start and End date)
                //Hotel Selection: any one
                //Title ANY
                //Offer code: Any unique value
                //Button Text: Book Now
                //Short Description: any with Unique identifier so that it is easy to locate the offer
                //Description: Any description with bullets
                //Image : any
                //Terms & Condition: Any description with links
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                AddDelay(2500);
                string awardtitle = TestData.ExcelData.TestDataReader.ReadData(1, "Title");
                string promotionCode = TestData.ExcelData.TestDataReader.ReadData(1, "PromotionCode");
                string button = TestData.ExcelData.TestDataReader.ReadData(1, "ButtonText");
                Admin.Click_Menu_LoyaltySetup();
                AddDelay(1500);
                Admin.Click_SubTab_Offers();
                string title = MakeUnique(awardtitle);
                Admin.LoyaltySetUp_Offers_Text_Filter(awardtitle);
                AddDelay(1500);
                string visibilityStartDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                string visibilityEndDate = DateTime.Now.AddDays(2).ToString("MM/dd/yyyy");
                Queries.GetMemberLevel(data, 1);
                string level = data.Membershiplevel;
                string promotionDescription = MakeUnique("Promotion");
                Queries.IdentifyHotel(data);
                string hotel = data.PropertyName;
                Admin.Click_LoyaltySetUp_Offers_Icon_Edit();
                Admin.AddORUpdateOffers(title, visibilityStartDate, visibilityEndDate, level, visibilityStartDate, visibilityEndDate, "Test");
                Admin.LoyaltySetUp_Offers_SelectMemberLevelALL();
                Admin.Click_LoyaltySetUp_Offers_Button_EditPromotion();
                Admin.UpdatePromotion(promotionCode, button, hotel, promotionDescription, ProjectName);
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                VerifyTextOnPage("Save successful.");

                //1.URL and Credential is available in Test Plan description
                //2.Data Requirement: Login credential for Member in Crystal, Sapphire, Diamond and Platinum
                //3.Sign to frontend as Crystal member
                Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
                Queries.GetDataAsPerMemberLevel(level, data);
                string email = data.eMail;
                SignIn.LogIn(email, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("user landed on home page");
                AddDelay(5000);

                //4.Navigate to Exclusive offer
                Navigation.Click_Link_Exclusive();
                Logger.WriteDebugMessage("user landed on Exclusive offer page");

                //5.Verify Crystal member will be able to view the offer that was created / updated as in pre-requisite                
                VerifyTextNOTOnPage(title);
                Logger.WriteDebugMessage("offer should be visible to Crystal member");
                Navigation.ClickSignOut(ProjectName);

                //6.Verify the same offer gets displayed before you sign in under the Exclusive offer ​​
                Navigation.Click_Link_LoginExclusives();
                AddDelay(2500);
                VerifyTextNOTOnPage(title);
                Logger.WriteDebugMessage("Offer gets displayed before you sign in under the Exclusive offer , but Book now and share offer , won't be available ​");

                //7.Sign to frontend as Sapphire member and verify the offer availability in Exclusive offer page
                Navigation.Click_Link_SignIn();
                Queries.GetMemberLevel(data, 2);
                string level1 = data.Membershiplevel;
                Queries.GetDataAsPerMemberLevel(level1, data);
                string email1 = data.eMail;
                SignIn.LogIn(email1, ProjectDetails.CommonFrontendPassword, ProjectName);
                AddDelay(5000);
                VerifyTextNOTOnPage(title);
                Logger.WriteDebugMessage("Offer should be visible to Sapphire member");
                AddDelay(5000);
                Navigation.ClickSignOut(ProjectName);

                //8.Verify the same offer gets displayed before you sign in under the Exclusive offer ​​
                Navigation.Click_Link_LoginExclusives();
                AddDelay(2500);
                VerifyTextNOTOnPage(title);
                Logger.WriteDebugMessage("Offer gets displayed before you sign in under the Exclusive offer , but Book now and share offer , won't be available ​");

                //9.Sign to frontend as diamond member and verify the offer availability in Exclusive offer page
                Navigation.Click_Link_SignIn();
                Queries.GetMemberLevel(data, 3);
                string level2 = data.Membershiplevel;
                Queries.GetDataAsPerMemberLevel(level2, data);
                string email2 = data.eMail;
                SignIn.LogIn(email2, ProjectDetails.CommonFrontendPassword, ProjectName);
                AddDelay(5000);
                VerifyTextNOTOnPage(title);
                Logger.WriteDebugMessage("Offer should be visible to Diamond member");
                AddDelay(5000);
                Navigation.ClickSignOut(ProjectName);

                //8.Verify the same offer gets displayed before you sign in under the Exclusive offer ​​
                Navigation.Click_Link_LoginExclusives();
                AddDelay(2500);
                VerifyTextNOTOnPage(title);
                Logger.WriteDebugMessage("Offer gets displayed before you sign in under the Exclusive offer , but Book now and share offer , won't be available ");

                if (ProjectName.Equals("Fraser"))
                {
                    //9.Sign to frontend as Platinum member and verify the offer availability in Exclusive offer page
                    Navigation.Click_Link_SignIn();
                    Queries.GetMemberLevel(data, 4);
                    string level3 = data.Membershiplevel;
                    Queries.GetDataAsPerMemberLevel(level3, data);
                    string email3 = data.eMail;
                    SignIn.LogIn(email3, ProjectDetails.CommonFrontendPassword, ProjectName);
                    AddDelay(5000);
                    VerifyTextNOTOnPage(title);
                    Logger.WriteDebugMessage("Offer should be visible to platinum member");
                    AddDelay(5000);
                    Navigation.ClickSignOut(ProjectName);

                    //8.Verify the same offer gets displayed before you sign in under the Exclusive offer ​​
                    Navigation.Click_Link_LoginExclusives();
                    AddDelay(2500);
                    VerifyTextNOTOnPage(title);
                    Logger.WriteDebugMessage("Offer gets displayed before you sign in under the Exclusive offer , but Book now and share offer , won't be available ");
                }
            }
        }

        //public static void TC_110850()
        //{
        //    if (TestCaseId == Constants.TC_110850)
        //    {
        //        //1.URL and Credential is available in Test Plan description
        //        //2.Navigate to admin login page
        //        //3.Sign in using valid credential
        //        Users data = new Users();
        //        AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
        //        Logger.WriteDebugMessage("User landed on home page");
        //        AddDelay(1500);
        //        string awardtitle = TestData.ExcelData.TestDataReader.ReadData(1, "Title");
                

        //        //4.Navigate to Loyalty Setup -> Offer tab
        //        Admin.Click_Menu_LoyaltySetup();
        //        AddDelay(1500);
        //        Admin.Click_SubTab_Offers();
        //        Logger.WriteDebugMessage("user landed on offer list screen");

        //        //5.Click on edit icon of an Offer
        //        Admin.LoyaltySetUp_Offers_Text_Filter(awardtitle);
        //        AddDelay(1500);
        //        Admin.Click_LoyaltySetUp_Offers_Icon_Edit();
        //        AddDelay(1500);
        //        Logger.WriteDebugMessage("User landed on  Offer Editor page");

        //        //6.Click on  edit icon against one of the Promos grid  
        //        string title = Helper.Getdata(PageObject_Admin.LoyaltySetUp_Offers_Text_Title());
        //        Admin.Click_LoyaltySetUp_Offers_Button_EditPromotion();
        //        Logger.WriteDebugMessage(" Edit Promo window gets opened ");

        //        //.Capture the Promo  code
        //        string Promotioncode = Helper.Getdata(PageObject_Admin.LoyaltySetUp_Offers_Text_PromotionCode());
        //        string ButtonText = Helper.Getdata(PageObject_Admin.LoyaltySetUp_Offers_Text_ButtonText());
        //        Queries.IdentifyHotel(data);
        //        string hotel = data.PropertyName;
        //        string promotionDescription = MakeUnique("Promotion");
        //        Logger.WriteDebugMessage("Offer Promo captured");
        //        Admin.Click_LoyaltySetUp_Offers_Button_CancelPromotion();

        //        //8.click on Add Promotion 
        //        Logger.WriteDebugMessage("Set up Promo popup gets displayed ");
        //        Admin.AddPromotion(Promotioncode, ButtonText, hotel, promotionDescription, ProjectName);
        //        AddDelay(5000);
        //        Logger.WriteDebugMessage("Enter the Promo code as captured in step 3  along with all other mandatory fields  and click on Save in Promo Set up ");

        //        //9.Click on Save in Offer Editor page 
        //        Admin.Click_LoyaltySetUp_Offers_Button_Save();
        //        Logger.WriteDebugMessage("Offer  gets saved successfully ");

        //        //10.Click on Edit icon of the same offer  and navigate to Set up Promo popup by clicking on edit icon in Promotion grid 
        //        Admin.LoyaltySetUp_Offers_Text_Filter(title);
        //        AddDelay(5000);
        //        Admin.Click_LoyaltySetUp_Offers_Button_EditPromotion();
        //        Logger.WriteDebugMessage("Set up Promo  popup gets displayed ");

        //        //11.Duplicated Promo code should get  displayed 
        //        VerifyTextOnPageAndHighLight(Promotioncode);
        //        Logger.WriteDebugMessage("Promo code gets displayed ");
        //    }
        //}

        public static void TC_110855()
        {
            if (TestCaseId == Constants.TC_110855)
            {
                Users data = new Users();
                //Pre - Requisite: 
                //Edit or create Existing offer with following criteria
                //Member Level: Crystal
                //Language Selection: English
                //Title: ANY For example: HJ0126 - 12:40 initial with date and time
                //Promotion Period: currently active (today should fall between Start and End date)
                //Visibility Period : Start date greater than Promo and end date same as promo  end date
                //Short Description: Any with Unique identifier so that it is easy to locate the offer
                //Image: any
                //Multiple Promotion
                //Hotel Selection: multiple for promo1; offer code as OFF1  Button Text: Book Now
                //Hotel  Selection : single for  Promo2; offer code as OFF1  Button Text: Book Now
                //Hotel Selction: :all for Promo 3; offer code as OFF1  Button Text: Book Now
                //Description: Any description with bullets
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                AddDelay(2500);
                string awardtitle = TestData.ExcelData.TestDataReader.ReadData(1, "Title");
                string promotionCode = TestData.ExcelData.TestDataReader.ReadData(1, "PromotionCode");
                string button = TestData.ExcelData.TestDataReader.ReadData(1, "ButtonText");
                Admin.Click_Menu_LoyaltySetup();
                AddDelay(1500);
                Admin.Click_SubTab_Offers();
                Admin.Click_LoyaltySetUp_Offers_Button_AddOffers();
                string title = MakeUnique(awardtitle);
                string visibilityStartDate = DateTime.Now.ToString("MM/dd/yyyy");
                string visibilityEndDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                Queries.GetMemberLevel(data, 1);
                string level = data.Membershiplevel;
                string promotionDescription = MakeUnique("Promotion");
                Queries.IdentifyHotel(data);
                string hotel = data.PropertyName;
                string startDate = DateTime.Now.ToString("MM/dd/yyyy");
                string endDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                Admin.AddORUpdateOffers(title, visibilityStartDate, visibilityEndDate, level, startDate, endDate, "Test");
                Admin.UploadImage(Constants.ImagePath);
                string promotioncode1 = promotionCode;
                string promotioncode2 = MakeUnique(promotionCode);
                string promotioncode3 = MakeUnique(promotionCode);
                Admin.AddPromotion(promotioncode1, button, hotel, promotionDescription, ProjectName);
                Admin.Click_LoyaltySetUp_Offers_Button_ConfirmPromotion();
                Admin.AddPromotion(promotioncode2, button, hotel, promotionDescription, ProjectName);
                Admin.AddPromotion(promotioncode3, button, hotel, promotionDescription, ProjectName);
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                VerifyTextOnPage("Save successful.");

                //1.URL and Credential is available in Test Plan description
                //2.Data Requirement: Login credential for Member in Crystal, Sapphire, Diamond and Platinum
                //3.Sign to frontend as Crystal member
                Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
                Queries.GetDataAsPerMemberLevel(level, data);
                string email = data.eMail;
                SignIn.LogIn(email, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("user landed on home page");
                AddDelay(5000);

                //4.Navigate to Exclusive offer
                Navigation.Click_Link_Exclusive();
                Logger.WriteDebugMessage("user landed on Exclusive offer page");

                //5.Verify Crystal member will be able to view the offer that was created / updated as in pre-requisite
                VerifyTextOnPage(title);
                Logger.WriteDebugMessage("offer should be visible to Crystal member");

                //6.Hotel detail should not get displayed in drop down                 
                Exclusives.Click_Text_ReadMore();
                PageDown();
                AddDelay(2500);
                Logger.WriteDebugMessage("hotel detail should not get  displayed in drop down ");

                //6.Click on Book now for Promo1  after selection of  hotel 
                Exclusives.Click_Button_BookNow();
                ControlToNewWindow();
                Logger.WriteDebugMessage("User landed on property specific client page Hotel name display in synxis page offer code display against promo / Discount code section");
            }
        }

        public static void TC_116222()
        {
            if (TestCaseId == Constants.TC_116222)
            {
                //1.Launch the application
                //2.Enter valid credentials and click on sign in button 
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                AddDelay(2500);
                Logger.WriteDebugMessage(" User should be logged in successfully");

                string awardtitle = TestData.ExcelData.TestDataReader.ReadData(1, "Title");
                //3.Click on Loyalty Setup tab
                Admin.Click_Menu_LoyaltySetup();
                AddDelay(1500);
                Logger.WriteDebugMessage("User should be landed on Loyalty setup section ");

                //4.Click on Offer tab from the Loyalty Setup section
                Admin.Click_SubTab_Offers();
                Logger.WriteDebugMessage("User should be landed on 'Offer'  page");

                //5.Click on edit button for any offer which is present in offer grid
                Admin.LoyaltySetUp_Offers_Text_Filter(awardtitle);
                AddDelay(1500);
                Admin.Click_LoyaltySetUp_Offers_Icon_Edit();
                Logger.WriteDebugMessage("User landed on  Offer Editor page");

                //6.Edit some changes in the fields and click on save button
                string title = MakeUnique(awardtitle);
                string visibilityStartDate = DateTime.Now.ToString("MM/dd/yyyy");
                string visibilityEndDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                Queries.GetMemberLevel(data, 2);
                string level = data.Membershiplevel;
                Admin.AddORUpdateOffers(title, visibilityStartDate, visibilityEndDate, level, visibilityStartDate, visibilityEndDate, "Test");
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                VerifyTextOnPage("Save successful.");
                Logger.WriteDebugMessage("Edited data should be displayed in promotion grid");

                //7.Launch front-end application ( fraserguestloyaltyqa.cendyn )
                //8.Click on sign in link from the header
                //9.Enter valid credentials and click on sign in button
                Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
                SignIn.LogIn(ProjectDetails.CommonFrontendEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("User should be logged ion successfully");
                AddDelay(5000);

                //10.Navigate to Exclusive offer
                Navigation.Click_Link_Exclusive();
                Logger.WriteDebugMessage("user landed on Exclusive offer page");
                VerifyTextOnPage(title);
                Logger.WriteDebugMessage("Edited promotion in admin should be displayed in the offers section");
            }
        }

        public static void TC_118019()
        {
            if (TestCaseId == Constants.TC_118019)
            {
                //1.URL and Credential is available in Test plan description
                //2.Login to  admin 
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("User landed on home page");
                AddDelay(1500);
                string awardtitle = TestData.ExcelData.TestDataReader.ReadData(1, "Title");
                string promotionCode = TestData.ExcelData.TestDataReader.ReadData(1, "PromotionCode");
                string button = TestData.ExcelData.TestDataReader.ReadData(1, "ButtonText");

                //3.Click on Loyalty Setup tab
                Admin.Click_Menu_LoyaltySetup();
                AddDelay(1500);
                Logger.WriteDebugMessage("User should be landed on Loyalty setup section ");

                //4.Click on Offer tab from the Loyalty Setup section
                Admin.Click_SubTab_Offers();
                Logger.WriteDebugMessage("User should be landed on 'Offer' page");

                //5.Click on "Add Offer" button from offer page
                Admin.Click_LoyaltySetUp_Offers_Button_AddOffers();
                Logger.WriteDebugMessage("User landed on Add offer page");

                //6.Add all mandatory fields in Offer page 
                string title = MakeUnique(awardtitle);
                string visibilityStartDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                string visibilityEndDate = DateTime.Now.AddDays(2).ToString("MM/dd/yyyy");
                Queries.GetMemberLevel(data, 2);
                Queries.IdentifyHotel(data);
                string promotionDescription = MakeUnique("Promotion");
                Admin.AddORUpdateOffers(title, visibilityStartDate, visibilityEndDate, data.Membershiplevel, visibilityStartDate, visibilityEndDate, "Test");
                Admin.UploadImage(Constants.ImagePath);
                Logger.WriteDebugMessage("Mandatory fields added ");

                //7.Click on "Add promotion" button i.e present on Add Offer page
                //8.Enter valid details in all required fields and click on Save button
                promotionCode = MakeUnique(promotionCode);
                Admin.AddPromotion(promotionCode, button, data.PropertyName, promotionDescription, ProjectName);
                Admin.Click_LoyaltySetUp_Offers_Button_ConfirmPromotion();
                Logger.WriteDebugMessage(" Added promotion should be displayed on Add Offer's page Promos grid ");

                //9.Click on Add Promotion again and  add one more promotion by entering all mandatory field value
                string promotionCode1 = MakeUnique(promotionCode);
                Admin.AddPromotion(promotionCode1, button, data.PropertyName, promotionDescription, ProjectName);
                //Admin.Click_LoyaltySetUp_Offers_Button_ConfirmPromotion();
                Logger.WriteDebugMessage(" Added promotion should be displayed on Add Offer's page Promos grid ");

                //10.Click on Delete Icon  for one of the Promo                 
                Admin.Click_LoyaltySetUp_Offers_Button_DeletePromotion();
                Logger.WriteDebugMessage(" Confirmation popup gets displayed ");

                //11.Click No in confirmation popup 
                Admin.Click_LoyaltySetUp_Offers_Button_DeleteNo();
                Logger.WriteDebugMessage("popup gets closed ");

                //12.Clock on delete icon again 
                Admin.Click_LoyaltySetUp_Offers_Button_DeletePromotion();
                Logger.WriteDebugMessage(" Confirmation popup gets displayed ");

                //13.Click on Close icon 
                Admin.Click_LoyaltySetUp_Offers_Icon_PromotionDeleteClose();
                Logger.WriteDebugMessage("Confirmation popup gets closed ");

                //14.Click on Delete  icon again
                Admin.Click_LoyaltySetUp_Offers_Button_DeletePromotion();
                Logger.WriteDebugMessage(" Confirmation popup gets displayed ");

                //15.Click Yes
                VerifyTextOnPage("Are you sure you want to remove this promotion?");
                Admin.Click_LoyaltySetUp_Offers_Button_DeleteYes();
                Logger.WriteDebugMessage("Delete Promotion should not get  displayed in grid when only one promotion gets displayed delete icon should not be available");

            }
        }
        #endregion TP_207379             
    }
}
