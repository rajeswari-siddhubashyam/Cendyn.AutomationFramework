using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseUtility.Utility;
using eLoyaltyV3.AppModule.UI;
using eLoyaltyV3.Entity;
using eLoyaltyV3.PageObject.Admin;
using eLoyaltyV3.Utility;
using InfoMessageLogger;
using NUnit.Framework;
using OpenQA.Selenium;
using TestData;
using Queries = eLoyaltyV3.Utility.Queries;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region TP_109659 - Admin - Offers - Update Offers
        private static void TC_109696()
        {
            if (TestCaseId == Constants.TC_109696)
            {
                //pre-requiste
                string titleVaidation, visibilityStartValidation, visibilityEndValidation, memberLevelValidation, promotionStartValidation, promotionEndValidation,
                    shortDescriptionValidation, imageValidation, addPromoionValidation, imagePath,
                    title, visibilityStartDate, visibilityEndDate, promotionDescription, promotionValidation, promotionCode, buttonName, shortdescription,
                    promotionCodeValidation, buttonTextValidation, descriptionValidation, hotelValidation;
                Random ranno = new Random();
                Users data = new Users();
                Queries.GetMemberLevel(data, 2);
                Queries.IdentifyHotel(data);
                Queries.GetActiveLoyaltyOffer(data);

                //Retrive data from test data
                titleVaidation = TestData.ExcelData.TestDataReader.ReadData(1, "TitleVaidation");
                visibilityStartValidation = TestData.ExcelData.TestDataReader.ReadData(1, "VisibilityStartValidation");
                visibilityEndValidation = TestData.ExcelData.TestDataReader.ReadData(1, "VisibilityEndValidation");
                memberLevelValidation = TestData.ExcelData.TestDataReader.ReadData(1, "MemberLevelValidation");
                promotionStartValidation = TestData.ExcelData.TestDataReader.ReadData(1, "PromotionStartValidation");
                promotionEndValidation = TestData.ExcelData.TestDataReader.ReadData(1, "PromotionEndValidation");
                shortDescriptionValidation = TestData.ExcelData.TestDataReader.ReadData(1, "ShortDescriptionValidation");
                imageValidation = TestData.ExcelData.TestDataReader.ReadData(1, "ImageValidation");
                addPromoionValidation = TestData.ExcelData.TestDataReader.ReadData(1, "AddPromoionValidation");
                imagePath = String.Concat(ProjectPath, TestData.ExcelData.TestDataReader.ReadData(1, "ImagePath"));
                title = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Title"), ranno.Next().ToString());
                visibilityStartDate = TestData.ExcelData.TestDataReader.ReadData(1, "VisibilityStartDate");
                visibilityEndDate = TestData.ExcelData.TestDataReader.ReadData(1, "VisibilityEndDate");
                promotionDescription = MakeUnique("Promotion");
                promotionCode = ranno.Next().ToString();
                buttonName = String.Concat("Button_", ranno.Next().ToString().Substring(0, 4));
                shortdescription = TestData.ExcelData.TestDataReader.ReadData(1, "ShortDescription");
                promotionCodeValidation = TestData.ExcelData.TestDataReader.ReadData(1, "PromotionCodeValidation");
                buttonTextValidation = TestData.ExcelData.TestDataReader.ReadData(1, "ButtonTextValidation");
                descriptionValidation = TestData.ExcelData.TestDataReader.ReadData(1, "DescriptionValidation");
                hotelValidation = TestData.ExcelData.TestDataReader.ReadData(1, "HotelValidation");

                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Navigate to Loyalty Setup -> Offer tab
                Admin.Click_Menu_LoyaltySetup();
                Admin.Click_SubTab_Offers();
                Logger.WriteDebugMessage("Offers sub tab get clicked");
                Admin.LoyaltySetUp_Offers_Text_Filter(data.OfferTitle);
                AddDelay(1500);
                Logger.WriteDebugMessage(data.OfferTitle + " = got displayed on the page");
                Admin.Click_LoyaltySetUp_Offers_Icon_Edit();
                Logger.WriteDebugMessage("Offer Edit Page got displayed");

                //Verify the Mandatory fields on the Edit Overlay and Add Promotion Overlay
                VerifyTextOnPageAndHighLight("Title: ");
                VerifyTextOnPageAndHighLight("Visibility Start: ");
                VerifyTextOnPageAndHighLight("Visibility End: ");
                VerifyTextOnPageAndHighLight("Member Level: ");
                VerifyTextOnPageAndHighLight("Promotion Start: ");
                VerifyTextOnPageAndHighLight("Promotion End: ");
                VerifyTextOnPageAndHighLight("Short Description: ");
                VerifyTextOnPageAndHighLight("Image: ");
                Logger.WriteDebugMessage("All Mandatory Fields are displayed on the Edit Offer Overlay");
                PageDown();
                Admin.Click_LoyaltySetUp_Offers_Button_AddAnotherPromotion();
                VerifyTextOnPageAndHighLight("Promotion Code: ");
                VerifyTextOnPageAndHighLight("Button Text: ");
                VerifyTextOnPageAndHighLight("Hotel Selection: ");
                VerifyTextOnPageAndHighLight("Description: ");
                Logger.WriteDebugMessage("All Mandatory Fields are displayed on Add Promotion Overlay");
                Admin.Click_LoyaltySetUp_Offers_Button_CancelPromotion();

                //Enter all mandatory field except for Promotion dates and click on save
                Helper.ElementClearText(PageObject_Admin.LoyaltySetUp_Offers_Text_PromotionStart());
                Helper.ElementClearText(PageObject_Admin.LoyaltySetUp_Offers_Text_PromotionEnd());
                Logger.WriteDebugMessage("Promotion Start date and End date are kept Blank");
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                VerifyTextOnPageAndHighLight(promotionStartValidation);
                VerifyTextOnPageAndHighLight(promotionEndValidation);
                Logger.WriteDebugMessage("Validation Message for Promotion start and end date got displayed");

                //Enter all mandatory field except for Short Description  and click on save
                Admin.LoyaltySetUp_Offers_Text_PromotionStart(visibilityStartDate);
                Admin.LoyaltySetUp_Offers_Text_PromotionEnd(visibilityEndDate);
                Admin.LoyaltySetUp_Offers_Text_ShortDescription("");
                Logger.WriteDebugMessage("Short Description filed is Empty");
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                AddDelay(10000);
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                VerifyTextOnPageAndHighLight(shortDescriptionValidation);
                Logger.WriteDebugMessage("Validation Message for short description got displayed");

                //Enter all mandatory field and Short Description  with whitespace and click on save
                Admin.LoyaltySetUp_Offers_Text_ShortDescription("   ");
                Logger.WriteDebugMessage("Short Description fielded with  White Space");
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                VerifyTextOnPageAndHighLight(shortDescriptionValidation);
                Logger.WriteDebugMessage("Validation Message for short description got displayed");


                //Enter all mandatory field except for Visibility Period dates and click on save
                Admin.LoyaltySetUp_Offers_Text_ShortDescription(shortdescription);
                Helper.ElementClearText(PageObject_Admin.LoyaltySetUp_Offers_Text_VisibilityStart());
                Helper.ElementClearText(PageObject_Admin.LoyaltySetUp_Offers_Text_VisibilityEnd());
                //Admin.LoyaltySetUp_Offers_Text_VisibilityStart("");
                ///Admin.LoyaltySetUp_Offers_Text_VisibilityEnd("");
                Logger.WriteDebugMessage("Visibility dates fields are Empty");
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                VerifyTextOnPageAndHighLight(visibilityStartValidation);
                VerifyTextOnPageAndHighLight(visibilityEndValidation);
                Logger.WriteDebugMessage("Validation Message for Visibility dates got displayed");

                //Enter all mandatory field except for MemberLevel and click on save
                Admin.LoyaltySetUp_Offers_Text_VisibilityStart(visibilityStartDate);
                Admin.LoyaltySetUp_Offers_Text_VisibilityEnd(visibilityEndDate);
                Admin.LoyaltySetUp_Offers_DeSelectMemberLevelALL();
                Logger.WriteDebugMessage("Deselected all Member Level");
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                VerifyTextOnPageAndHighLight(memberLevelValidation);
                Logger.WriteDebugMessage("Validation Message for member Level got displayed");


                //Click on Add Promotion and Verify the Validation
                PageDown();
                Admin.Click_LoyaltySetUp_Offers_Button_AddAnotherPromotion();
                VerifyTextOnPageAndHighLight(memberLevelValidation);
                Logger.WriteDebugMessage("Validation Message for member Level got displayed");
                Admin.LoyaltySetUp_Offers_SelectMemberLevel(data.MembershipLevel);
                Logger.WriteDebugMessage("Member Ship Level got selected");

                //Enter all mandatory field except for Hotel code and click on save
                Admin.Click_LoyaltySetUp_Offers_Button_Cancel();
                Admin.Click_LoyaltySetUp_Offers_Icon_Edit();
                Logger.WriteDebugMessage("Offer Edit Page got displayed");
                Admin.Click_LoyaltySetUp_Offers_Button_AddAnotherPromotion();
                //Admin.Enter_LoyaltySetUp_Promotion_Filter(promotionCode);
                Admin.LoyaltySetUp_Offers_Text_PromotionCode(promotionCode);
                Admin.LoyaltySetUp_Offers_Text_ButtonText(buttonName);
                //Admin.LoyaltySetUp_Offers_Text_PromotionDescription(promotionDescription);
                Logger.WriteDebugMessage("Entered All Details for Promotion except Hotel");
                Admin.Click_LoyaltySetUp_Offers_Button_SavePromotion();
                VerifyTextOnPageAndHighLight(hotelValidation);
                Logger.WriteDebugMessage("Validation Message for Hotel got displayed");


                //Enter all mandatory field except for Description and click on save
                Admin.LoyaltySetUp_Offers_Dropdown_HotelSelection(data.PropertyName, ProjectName);
                Admin.LoyaltySetUp_Offers_Text_PromotionDescription("");
                Logger.WriteDebugMessage("All Details are added except Description");
                Admin.Click_LoyaltySetUp_Offers_Button_SavePromotion();
                VerifyTextOnPageAndHighLight(descriptionValidation);
                Logger.WriteDebugMessage("Validation Message for Description got displayed");

                //Enter all mandatory field and Description with whitespace and click on save
                Admin.LoyaltySetUp_Offers_Text_PromotionDescription("   ");
                Logger.WriteDebugMessage("Entered white space in Description field");
                Admin.Click_LoyaltySetUp_Offers_Button_SavePromotion();
                VerifyTextOnPageAndHighLight(descriptionValidation);
                Logger.WriteDebugMessage("Validation Message for description got displayed");

                //Enter all mandatory field except for Offer Code and click on save
                Helper.ElementClearText(Driver.FindElement(By.XPath("(//input[@id='promotionCode'])")));
                Admin.LoyaltySetUp_Offers_Text_PromotionDescription(promotionDescription);
                Admin.LoyaltySetUp_Offers_Text_PromotionCode("");
                Admin.Click_LoyaltySetUp_Offers_Button_SavePromotion();
                VerifyTextOnPageAndHighLight(promotionCodeValidation);
                Logger.WriteDebugMessage("Validation Message for Promotion Code got displayed");

                //Enter all mandatory field except for  Button text  and click on save
                Admin.LoyaltySetUp_Offers_Text_PromotionCode(promotionCode);
                Helper.ElementClearText(PageObject_Admin.LoyaltySetUp_Offers_Text_ButtonText());
                Admin.LoyaltySetUp_Offers_Text_ButtonText("");
                Logger.WriteDebugMessage("Button Text value is empty");
                Admin.Click_LoyaltySetUp_Offers_Button_SavePromotion();
                VerifyTextOnPageAndHighLight(buttonTextValidation);
                Logger.WriteDebugMessage("Validation Message for Button text got displayed");

                //Enter all mandatory field and Button text    with whitespace and click on save
                Admin.LoyaltySetUp_Offers_Text_ButtonText("  ");
                Logger.WriteDebugMessage("Entered white spance in Button text field");
                Admin.Click_LoyaltySetUp_Offers_Button_SavePromotion();
                VerifyTextOnPageAndHighLight(buttonTextValidation);
                Logger.WriteDebugMessage("Validation Message for Button text got displayed");


                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Title Validation Message", titleVaidation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Visibility Start Validation", visibilityStartValidation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Visibility End Validation", visibilityEndValidation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Validation", memberLevelValidation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Promotion Start Validation", promotionStartValidation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Promotion End Validation", promotionEndValidation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Short Description Validation", shortDescriptionValidation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Image Validation", imageValidation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Add PromoionValidation", addPromoionValidation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Image Path", imagePath);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Title", title);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Visibility Start Date", visibilityStartDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Visibility End Date", visibilityEndDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Promotion Description", promotionDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Promotion Code", promotionCode);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Button Name", buttonName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Short Description", shortdescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Promotion Code Validation", promotionCodeValidation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Description Validation", descriptionValidation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Button Text Validation", buttonTextValidation, true);
            }
        }

        private static void TC_109698()
        {
            if (TestCaseId == Constants.TC_109698)
            {
                //pre-requiste
                string frontend_URL, title, visibilityStartDate, visibilityEndDate, promotionDescription, promotionCode, buttonName, shortdescription;
                Random ranno = new Random();
                Users data = new Users();
                Queries.GetMemberLevel(data, 2);
                Queries.IdentifyHotel(data);
                Queries.GetActiveMemberEmail(data);
                Queries.GetActiveLoyaltyOffer(data);

                //Retrive data from test data
                title = data.OfferTitle;
                visibilityStartDate = TestData.ExcelData.TestDataReader.ReadData(1, "VisibilityStartDate");
                visibilityEndDate = TestData.ExcelData.TestDataReader.ReadData(1, "VisibilityEndDate");
                promotionDescription = MakeUnique("Promotion");
                promotionCode = ranno.Next().ToString().Substring(0, 5);
                buttonName = String.Concat("Button_", ranno.Next().ToString().Substring(0, 4));
                shortdescription = TestData.ExcelData.TestDataReader.ReadData(1, "ShortDescription");
                frontend_URL = TestData.ExcelData.TestDataReader.ReadData(1, "Frontend_URL");


                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Navigate to Loyalty Setup -> Offer tab
                Admin.Click_Menu_LoyaltySetup();
                Logger.WriteDebugMessage("Loyalty Setup tab get clicked");
                Admin.Click_SubTab_Offers();
                Logger.WriteDebugMessage("Offers sub tab get clicked");
                Admin.LoyaltySetUp_Offers_Text_Filter(data.OfferTitle);
                AddDelay(1500);
                Logger.WriteDebugMessage(data.OfferTitle + " = got displayed on the page");
                Admin.Click_LoyaltySetUp_Offers_Icon_Edit();
                Logger.WriteDebugMessage("Offer Edit Page got displayed");

                //Enter all mandatory field except for Image data and click on save 
                Admin.LoyaltySetUp_Offers_Text_Title(title + "$");
                Admin.LoyaltySetUp_Offers_Text_ShortDescription(shortdescription + "*");
                Admin.LoyaltySetUp_Offers_SelectMemberLevelALL();
                Logger.WriteDebugMessage("Details are entered succesfully on Add offer overlay");
                Admin.AddPromotion(promotionCode + "#", buttonName + "@", data.PropertyName, promotionDescription + "&", ProjectName);
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                Logger.WriteDebugMessage("Offers saved successfully");

                // Navigate to Frontend and check added Offer
                OpenNewTab();
                ControlToNewWindow();
                Driver.Url = frontend_URL;
                LoginCredentials(data.MemberEmail, "Cendyn123$", ProjectName);
                Navigation.Click_Link_SpecialOffer();
                Logger.WriteDebugMessage("Navigated to Offers tab");
                PageDown();
                VerifyTextOnPageAndHighLight(title + "$");
                VerifyTextOnPageAndHighLight(shortdescription + "*");
                Logger.WriteDebugMessage("Offer Got Displayed on the Frontend");
                Navigation.Click_SpecialOffers_Readmore(title + "$");
                VerifyTextOnPageAndHighLight(promotionDescription + "&");
                Logger.WriteDebugMessage("Details displaying on the Frontend as Admin");



                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Title", title + "$");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Visibility Start Date", visibilityStartDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Visibility End Date", visibilityEndDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Promotion Description", promotionDescription + "&");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Promotion Code", promotionCode + "#");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Button Name", buttonName + "@");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Short Description", shortdescription + "*", true);
            }
        }

        public static void TC_109699()
        {
            if (TestCaseId == Constants.TC_109699)
            {
                //1.URL and Credential is available in Test plan description
                //2.Data Requirement: none
                //3.Navigate to admin login page
                //4.Sign in using valid credential
                Users data = new Users();
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("User landed on home page");
                AddDelay(1500);
                Queries.GetActiveLoyaltyOffer(data);
                string offertitle = data.OfferTitle;

                //5.Navigate to Loyalty Setup -> Offer tab
                Admin.Click_Menu_LoyaltySetup();
                AddDelay(1500);
                Admin.Click_SubTab_Offers();
                Logger.WriteDebugMessage("user landed on offer list screen");

                //6.Click on edit icon of an Offer
                Admin.LoyaltySetUp_Offers_Text_Filter(offertitle);
                AddDelay(1500);
                Logger.WriteDebugMessage(data.OfferTitle + " = got displayed on the page");
                Admin.Click_LoyaltySetUp_Offers_Icon_Edit();
                Logger.WriteDebugMessage("Offer Edit Page got displayed");


                //7.Enter all the fields and click on Save
                string title = MakeUnique(offertitle);
                string visibilityStartDate = DateTime.Now.ToString("MM/dd/yyyy");
                string visibilityEndDate = DateTime.Now.AddYears(2).ToString("MM/dd/yyyy");
                Queries.GetMemberLevel(data, 2);
                string level = data.MembershipLevel;
                Admin.AddORUpdateOffers(title, visibilityStartDate, visibilityEndDate, level, visibilityStartDate, visibilityEndDate, "Test");
                Admin.LoyaltySetUp_Offers_SelectMemberLevelALL();
                Logger.WriteDebugMessage("All the details are entered succesfullly");
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                VerifyTextOnPage("Save successful.");
                Logger.WriteDebugMessage("User should land on the Offer grid page and newly added offer should get displayed");

                //8.Click on edit
                try
                {
                    Admin.Click_LoyaltySetUp_Offers_Button_Cancel();
                }
                catch (Exception e)
                {
                    Logger.WriteDebugMessage("Offer got updated succesfully");
                }
                Admin.LoyaltySetUp_Offers_Text_Filter(title);
                AddDelay(1500);
                Logger.WriteDebugMessage("Updated offer got displayed on the page");
                Admin.Click_LoyaltySetUp_Offers_Icon_Edit();
                VerifyTextOnPageAndHighLight(level);
                Logger.WriteDebugMessage("Details entered while adding offer should display");
            }
        }
        private static void TC_109700()
        {
            if (TestCaseId == Constants.TC_109700)
            {
                //pre-requiste
                string imagePath, title, visibilityStartDate, visibilityEndDate, promotionDescription, promotionCode, buttonName, shortdescription;
                Random ranno = new Random();
                Users data = new Users();
                Queries.GetMemberLevel(data, 2);
                Queries.IdentifyHotel(data);
                Queries.GetActiveLoyaltyOffer(data);

                //Retrive data from test data
                imagePath = String.Concat(ProjectPath, TestData.ExcelData.TestDataReader.ReadData(1, "ImagePath"));
                title = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Title"), ranno.Next().ToString());
                visibilityStartDate = TestData.ExcelData.TestDataReader.ReadData(1, "VisibilityStartDate");
                visibilityEndDate = TestData.ExcelData.TestDataReader.ReadData(1, "VisibilityEndDate");
                promotionDescription = MakeUnique("Promotion");
                promotionCode = ranno.Next().ToString().Substring(0, 5);
                buttonName = String.Concat("Button_", ranno.Next().ToString().Substring(0, 4));
                shortdescription = TestData.ExcelData.TestDataReader.ReadData(1, "ShortDescription");


                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Navigate to Loyalty Setup -> Offer tab
                Admin.Click_Menu_LoyaltySetup();
                Logger.WriteDebugMessage("Loyalty Setup tab get clicked");
                Admin.Click_SubTab_Offers();
                Logger.WriteDebugMessage("Offers sub tab get clicked");
                Admin.LoyaltySetUp_Offers_Text_Filter(data.OfferTitle);
                AddDelay(1500);
                Logger.WriteDebugMessage(data.OfferTitle + " = got displayed on the page");
                Helper.ScrollToElement(PageObject_Admin.LoyaltySetUp_Offers_Icon_Edit());
                Admin.Click_LoyaltySetUp_Offers_Icon_Edit();
                Logger.WriteDebugMessage("Offer Edit Page got displayed");

                //Enter all mandatory and click on save 
                Admin.AddORUpdateOffers(title, visibilityStartDate, visibilityEndDate, data.MembershipLevel, visibilityStartDate, visibilityEndDate, shortdescription);
                
                //Admin.UploadImage(imagePath);
                Admin.LoyaltySetUp_Offers_SelectMemberLevelALL();
                AddDelay(5000);
                Logger.WriteDebugMessage("Details are entered on the page");
                Admin.AddPromotion(promotionCode, buttonName, data.PropertyName, promotionDescription, ProjectName);
                PageDown();
                Logger.WriteDebugMessage("Promotion is added successfully");
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                if (PageObject_Admin.LoyaltySetUp_Offers_Button_Save().Displayed)
                {
                    Admin.Click_LoyaltySetUp_Offers_Button_Cancel();
                }
                else
                    Logger.WriteDebugMessage("Added offer saved successfully");

                Admin.LoyaltySetUp_Offers_Text_Filter(title);
                AddDelay(5000);
                VerifyTextOnPageAndHighLight(title);
                Logger.WriteDebugMessage(title + "= Offers saved successfully");

                // Edit recently added offer and verify details entered while adding
                Admin.Click_LoyaltySetUp_Offers_Icon_Edit();
                Logger.WriteDebugMessage("Edit button clicked");
                PageDown();
                Admin.Enter_LoyaltySetUp_Promotion_Filter(promotionCode);
                VerifyTextOnPageAndHighLight(promotionCode);
                VerifyTextOnPageAndHighLight(buttonName);
                Logger.WriteDebugMessage("All details same as details entered while adding");

                //Delete Promo code
                Admin.Click_LoyaltySetUp_Offers_Button_DeletePromotion();
                Admin.Click_LoyaltySetUp_Offers_Button_DeleteYes();

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Image Path", imagePath);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Title", title);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Visibility Start Date", visibilityStartDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Visibility End Date", visibilityEndDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Promotion Description", promotionDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Promotion Code", promotionCode);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Button Name", buttonName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Short Description", shortdescription, true);
            }
        }
        private static void TC_109701()
        {
            if (TestCaseId == Constants.TC_109701)
            {
                //pre-requiste
                string imagePath, title, visibilityStartDate, visibilityEndDate, shortdescription, cancelButton_Validation;
                Random ranno = new Random();
                Users data = new Users();
                Queries.GetMemberLevel(data, 2);
                Queries.GetActiveLoyaltyOffer(data);

                //Retrive data from database
                imagePath = String.Concat(ProjectPath, TestData.ExcelData.TestDataReader.ReadData(1, "ImagePath"));
                title = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Title"), ranno.Next().ToString());
                visibilityStartDate = TestData.ExcelData.TestDataReader.ReadData(1, "VisibilityStartDate");
                visibilityEndDate = TestData.ExcelData.TestDataReader.ReadData(1, "VisibilityEndDate");
                shortdescription = TestData.ExcelData.TestDataReader.ReadData(1, "ShortDescription");
                cancelButton_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "CancelButton_Validation");


                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Navigate to Loyalty Setup -> Offer tab
                Admin.Click_Menu_LoyaltySetup();
                Logger.WriteDebugMessage("Loyalty Setup tab get clicked");
                Admin.Click_SubTab_Offers();
                Logger.WriteDebugMessage("Offers sub tab get clicked");
                Admin.LoyaltySetUp_Offers_Text_Filter(data.OfferTitle);
                AddDelay(1500);
                Logger.WriteDebugMessage(data.OfferTitle + " = got displayed on the page");
                Helper.ScrollToElement(PageObject_Admin.LoyaltySetUp_Offers_Icon_Edit());
                Admin.Click_LoyaltySetUp_Offers_Icon_Edit();
                Logger.WriteDebugMessage("Offer Edit Page got displayed");

                //Enter all mandatory field and click on cancel
                Admin.AddORUpdateOffers(title, visibilityStartDate, visibilityEndDate, data.MembershipLevel, visibilityStartDate, visibilityEndDate, shortdescription);
                Admin.UploadImage(imagePath);
                AddDelay(6000);
                Logger.WriteDebugMessage("All Details are entred correctly on Add Offer Page");
                Admin.Click_LoyaltySetUp_Offers_Button_Cancel();
                Logger.WriteDebugMessage("Cancel button clicked");
                Admin.LoyaltySetUp_Offers_Text_Filter(title);
                AddDelay(10000);
                if (PageObject_Admin.LoyaltySetUp_Offers_Icon_Edit().Displayed)
                    Assert.Fail("Offers displaying on the page");
                else
                {
                    VerifyTextOnPageAndHighLight(cancelButton_Validation);
                    Logger.WriteDebugMessage(cancelButton_Validation + "= Offers Canceled successfully");
                }


                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Image Path", imagePath);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Title", title);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Visibility Start Date", visibilityStartDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Visibility End Date", visibilityEndDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Short Description", shortdescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Cancel Button Validation", cancelButton_Validation, true);
            }
        }

        private static void TC_109697()
        {
            if (TestCaseId == Constants.TC_109697)
            {
                //pre-requiste
                string title, visibilityStartDate, visibilityEndDate, promotionDescription, promotionCode, buttonName, shortdescription, shortdescription_CharLimit,
                    title_CharLimit, promoDescription_CharLimit, promoCode_CharLimit, buttonText_CharLimit, shortdescription_CharLimitValidation, promoDescription_CharLimitValidation;
                Random ranno = new Random();
                Users data = new Users();
                Queries.GetMemberLevel(data, 2);
                Queries.IdentifyHotel(data);
                Queries.GetActiveLoyaltyOffer(data);

                //Retrive data from test data
                title = data.OfferTitle;
                promotionDescription = MakeUnique("Promotion");
                promotionCode = ranno.Next().ToString().Substring(0, 5);
                buttonName = String.Concat("Button_", ranno.Next().ToString().Substring(0, 4));
                shortdescription = TestData.ExcelData.TestDataReader.ReadData(1, "ShortDescription");
                shortdescription_CharLimit = TestData.ExcelData.TestDataReader.ReadData(1, "Shortdescription_CharLimit");
                title_CharLimit = TestData.ExcelData.TestDataReader.ReadData(1, "Title_CharLimit");
                promoDescription_CharLimit = TestData.ExcelData.TestDataReader.ReadData(1, "PromoDescription_CharLimit");
                promoCode_CharLimit = TestData.ExcelData.TestDataReader.ReadData(1, "PromoCode_CharLimit");
                buttonText_CharLimit = TestData.ExcelData.TestDataReader.ReadData(1, "ButtonText_CharLimit");
                shortdescription_CharLimitValidation = TestData.ExcelData.TestDataReader.ReadData(1, "Shortdescription_CharLimitValidation");
                promoDescription_CharLimitValidation = TestData.ExcelData.TestDataReader.ReadData(1, "PromoDescription_CharLimitValidation");


                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Navigate to Loyalty Setup -> Offer tab
                Admin.Click_Menu_LoyaltySetup();
                Admin.Click_SubTab_Offers();
                Logger.WriteDebugMessage("Offers sub tab get clicked");
                Admin.LoyaltySetUp_Offers_Text_Filter(data.OfferTitle);
                AddDelay(1500);
                Logger.WriteDebugMessage(data.OfferTitle + " = got displayed on the page");
                Admin.Click_LoyaltySetUp_Offers_Icon_Edit();
                Logger.WriteDebugMessage("Offer Edit Page got displayed");

                //Validate char limit for short description
                Admin.LoyaltySetUp_Offers_Text_ShortDescription(shortdescription_CharLimit);
                PageDown();
                Admin.Click_LoyaltySetUp_Offers_Button_AddAnotherPromotion();
                VerifyTextOnPageAndHighLight(shortdescription_CharLimitValidation);
                Logger.WriteDebugMessage(shortdescription_CharLimitValidation + "= Validation message displayed");

                // Validate char limit for Title
                Admin.LoyaltySetUp_Offers_Text_ShortDescription(shortdescription);
                Admin.LoyaltySetUp_Offers_Text_Title(title_CharLimit);
                string titlecount = PageObject_Admin.LoyaltySetUp_Offers_Text_Title().GetAttribute("maxlength");
                if (titlecount.Equals("200"))
                    Logger.WriteDebugMessage("Title character length not exceeded to more than 200");
                else
                    Assert.Fail("Title character length exceeded more than 200");


                // Validate char limit for Promo code
                Admin.LoyaltySetUp_Offers_Text_Title(title);
                PageDown();
                Admin.Click_LoyaltySetUp_Offers_Button_AddAnotherPromotion();
                Helper.ElementClick(Driver.FindElement(By.XPath("(//*[@id='offersTable']//following::button[contains(text(),'Edit')])[36]")));
                Admin.LoyaltySetUp_Offers_Text_PromotionCode(promoCode_CharLimit);
                Admin.LoyaltySetUp_Offers_Text_ButtonText(buttonName);
                Admin.LoyaltySetUp_Offers_Dropdown_HotelSelection(data.PropertyName, ProjectName);
                Admin.LoyaltySetUp_Offers_Text_PromotionDescription(promotionDescription);
                Logger.WriteDebugMessage("Entered All Details for Promotion");
                string promoCodecount = PageObject_Admin.LoyaltySetUp_Offers_Text_PromotionCode().GetAttribute("maxlength");
                if (promoCodecount.Equals("25"))
                    Logger.WriteDebugMessage("Verified Promo Code character length not exceeded to more than 25");
                else
                    Assert.Fail("Promo Code character length exceeded more than 25");

                // Validate Button text char limit
                Admin.LoyaltySetUp_Offers_Text_PromotionCode(promotionCode);
                Admin.LoyaltySetUp_Offers_Text_ButtonText(buttonText_CharLimit);
                Logger.WriteDebugMessage("Entered All Details for Promotion");
                string buttonTextcount = PageObject_Admin.LoyaltySetUp_Offers_Text_ButtonText().GetAttribute("maxlength");
                if (buttonTextcount.Equals("200"))
                    Logger.WriteDebugMessage("Verified Button Text character length not exceeded to more than 200");
                else
                    Assert.Fail("Button Text character length exceeded more than 200");

                //Validate Promo Description char limit
                Admin.LoyaltySetUp_Offers_Text_ButtonText(buttonName);
                Admin.LoyaltySetUp_Offers_Text_PromotionDescription(promoDescription_CharLimit);
                Admin.Click_LoyaltySetUp_Offers_Button_SavePromotion();
                VerifyTextOnPageAndHighLight(promoDescription_CharLimitValidation);
                Logger.WriteDebugMessage(promoDescription_CharLimitValidation + "= Validation message displayed");

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Existing Offer", data.OfferTitle);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Promotion Description", promotionDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Promotion Code", promotionCode);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Button Name", buttonName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Short Description", shortdescription, true);
            }
        }
        private static void TC_109665()
        {
            if (TestCaseId == Constants.TC_109665)
            {
                //pre-requiste
                Users data = new Users();
                Queries.GetMemberLevel(data, 2);
                Queries.GetActiveLoyaltyOffer(data);

                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Navigate to Loyalty Setup -> Offer tab
                Admin.Click_Menu_LoyaltySetup();
                Logger.WriteDebugMessage("Loyalty Setup tab get clicked");
                Admin.Click_SubTab_Offers();
                Logger.WriteDebugMessage("Offers sub tab get clicked");

                //Filter by Offer Name
                Admin.LoyaltySetUp_Offers_Text_Filter(data.OfferTitle);
                AddDelay(1500);
                Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Icon_Edit(), 240);
                VerifyTextOnPageAndHighLight(data.OfferTitle);
                Logger.WriteDebugMessage(data.OfferTitle + " = got displayed on the page");

                //Filter by  Member Level data 
                Admin.LoyaltySetUp_Offers_Text_Filter(data.MembershipLevel);
                AddDelay(1500);
                Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Icon_Edit(), 240);
                VerifyTextOnPageAndHighLight(data.MembershipLevel);
                Logger.WriteDebugMessage(data.MembershipLevel + " = got displayed on the page");

                //Filter by  Member Level data partial Name
                Admin.LoyaltySetUp_Offers_Text_Filter(data.MembershipLevel.Substring(0, 5));
                AddDelay(1500);
                Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Icon_Edit(), 240);
                VerifyTextOnPageAndHighLight(data.MembershipLevel);
                Logger.WriteDebugMessage(data.MembershipLevel + " = got displayed on the page");

                //Filter by  Start Date 
                Admin.LoyaltySetUp_Offers_Text_Filter(data.OfferStartDate.Substring(0, 9));
                AddDelay(1500);
                Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Icon_Edit(), 240);
                VerifyTextOnPageAndHighLight(data.OfferStartDate.Substring(0, 9));
                Logger.WriteDebugMessage("Offer got displayed on the page");

                Admin.LoyaltySetUp_Offers_Text_Filter(data.OfferStartDate.Substring(5, 4));
                AddDelay(1500);
                Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Icon_Edit(), 240);
                VerifyTextOnPageAndHighLight(data.OfferStartDate.Substring(5, 4));
                Logger.WriteDebugMessage("Active Offer got displayed on the page");

                //Filter by  End  Date 
                Admin.LoyaltySetUp_Offers_Text_Filter(data.OfferEndDate.Substring(0, 9));
                AddDelay(1500);
                Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Icon_Edit(), 240);
                VerifyTextOnPageAndHighLight(data.OfferEndDate.Substring(0, 9));
                Logger.WriteDebugMessage("Offer got displayed on the page");

                Admin.LoyaltySetUp_Offers_Text_Filter(data.OfferEndDate.Substring(5, 4));
                AddDelay(1500);
                Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Icon_Edit(), 240);
                VerifyTextOnPageAndHighLight(data.OfferEndDate.Substring(5, 4));
                Logger.WriteDebugMessage("Active Offer got displayed on the page");

                //Filter by State Active, InActive, Scheduled
                Admin.LoyaltySetUp_Offers_Text_Filter("Active");
                AddDelay(1500);
                Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Icon_Edit(), 240);
                VerifyTextOnPageAndHighLight("Active");
                Logger.WriteDebugMessage("Active Offer got displayed on the page");

                Admin.LoyaltySetUp_Offers_Text_Filter("Active".Substring(0, 4));
                AddDelay(1500);
                Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Icon_Edit(), 240);
                VerifyTextOnPageAndHighLight("Active".Substring(0, 4));
                Logger.WriteDebugMessage("Active Offer got displayed on the page");

                Admin.LoyaltySetUp_Offers_Text_Filter("Inactive");
                AddDelay(1500);
                Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Icon_Edit(), 240);
                VerifyTextOnPageAndHighLight("Inactive");
                Logger.WriteDebugMessage("Inactive Offer got displayed on the page");

                Admin.LoyaltySetUp_Offers_Text_Filter("Inactive".Substring(0, 4));
                AddDelay(1500);
                Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Icon_Edit(), 240);
                VerifyTextOnPageAndHighLight("Inactive".Substring(0, 4));
                Logger.WriteDebugMessage("Inactive Offer got displayed on the page");

                Admin.LoyaltySetUp_Offers_Text_Filter("Scheduled");
                AddDelay(1500);
                Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Icon_Edit(), 240);
                VerifyTextOnPageAndHighLight("Scheduled");
                Logger.WriteDebugMessage("Scheduled Offer got displayed on the page");

                Admin.LoyaltySetUp_Offers_Text_Filter("Scheduled".Substring(0, 4));
                AddDelay(1500);
                Helper.ElementWait(PageObject_Admin.LoyaltySetUp_Offers_Icon_Edit(), 240);
                VerifyTextOnPageAndHighLight("Scheduled".Substring(0, 4));
                Logger.WriteDebugMessage("Scheduled Offer got displayed on the page");
            }
        }
        private static void TC_109666()
        {
            if (TestCaseId == Constants.TC_109666)
            {
                //pre-requiste
                string paginationValue;

                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Navigate to Loyalty Setup -> Offer tab
                Admin.Click_Menu_LoyaltySetup();
                Logger.WriteDebugMessage("Loyalty Setup tab get clicked");
                Admin.Click_SubTab_Offers();
                Logger.WriteDebugMessage("Offers sub tab get clicked");

                //Verify Entries drop down is displayed with total of 5 selections as below:
                Admin.Click_Admin_LoyaltySetUp_Offers_Pagination_Dropdown();
                for (int i = 5; i <= 20; i += 5)
                {
                    paginationValue = TestData.ExcelData.TestDataReader.ReadData(i, "PaginationValue");
                    if (Admin.Get_Admin_LoyaltySetUp_Offers_Pagination_Dropdown(i).Equals(paginationValue))
                        Logger.WriteInfoMessage(i + " Value found on Pagination dropdown");
                    else
                        Assert.Fail(i + "th value is not displayed on the Page");
                }
                if (Admin.Get_Admin_LoyaltySetUp_Offers_Pagination_Dropdown(-1).Equals("All"))
                    Logger.WriteDebugMessage("All the values are displayed on Pagination Dropdown");

                //Select all Entries dropdown and verify the values
                for (int i = 5; i <= 20; i += 5)
                {
                    Admin.Click_Admin_LoyaltySetUp_Offers_Pagination_Dropdown(i);
                    Helper.DynamicScroll(Driver, PageObject_Admin.Admin_LoyaltySetUp_Offers_Pagination_Dropdown());
                    Logger.WriteDebugMessage(i + " Value got selected");
                    Helper.DynamicScroll(Helper.Driver, PageObject_Admin.Admin_LoyaltySetUp_Offers_Pagination_Next_Button());
                    VerifyTextOnPageAndHighLight("Showing 1 To " + i);
                    Logger.WriteDebugMessage(" Values are displaying on the page");
                    if (i > 5)
                    {
                        Admin.Click_Admin_LoyaltySetUp_Offers_Pagination_Next_Button();
                        VerifyTextOnPageAndHighLight("Showing " + (i + 1) + " To " + (i + i));
                        Logger.WriteDebugMessage("Clicked on Next button");
                        Admin.Click_Admin_LoyaltySetUp_Offers_Pagination_Prev_Button();
                        VerifyTextOnPageAndHighLight("Showing 1 To " + i);
                        Logger.WriteDebugMessage("Clicked on Previous button");

                    }
                }
                Admin.Click_Admin_LoyaltySetUp_Offers_Pagination_Dropdown(-1);
                Helper.DynamicScroll(Driver, PageObject_Admin.Admin_LoyaltySetUp_Offers_Pagination_Dropdown());
                Logger.WriteDebugMessage("All Value got selected");
                if (Helper.IsElementEditable(PageObject_Admin.Admin_LoyaltySetUp_Offers_Pagination_Next_Button()))
                    Assert.Fail("All Offers are not displayed");
                else
                {
                    VerifyTextOnPageAndHighLight("Showing 1 To ");
                    Logger.WriteDebugMessage("All Offers are got selected");
                }

            }
        }
        private static void TC_109667()
        {
            if (TestCaseId == Constants.TC_109667)
            {
                //pre-requiste
                Users data = new Users();
                //pre-requiste
                string imagePath, title, visibilityStartDate, visibilityEndDate, promotionDescription, promotionCode, buttonName, shortdescription;
                Random ranno = new Random();
                Queries.GetMemberLevel(data, 2);
                Queries.IdentifyHotel(data);
                if (data.MembershipLevel.Equals("Preferred Club Member"))
                    data.MembershipLevel = "PREFERRED";
                Queries.GetDataAsPerMemberLevel(data.MembershipLevel,data);

                //Retrive data from test data
                imagePath = String.Concat(ProjectPath, TestData.ExcelData.TestDataReader.ReadData(1, "ImagePath"));
                title = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Title"), ranno.Next().ToString());
                visibilityStartDate = TestData.ExcelData.TestDataReader.ReadData(1, "VisibilityStartDate");
                visibilityEndDate = TestData.ExcelData.TestDataReader.ReadData(1, "VisibilityEndDate");
                promotionDescription = MakeUnique("Promotion");
                promotionCode = String.Concat("Code_",ranno.Next().ToString().Substring(0, 5));
                buttonName = String.Concat("Button_", ranno.Next().ToString().Substring(0, 4));
                shortdescription = TestData.ExcelData.TestDataReader.ReadData(1, "ShortDescription");

                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Navigate to Loyalty Setup -> Offer tab
                Admin.Click_Menu_LoyaltySetup();
                Logger.WriteDebugMessage("Loyalty Setup tab get clicked");
                Admin.Click_SubTab_Offers();
                Logger.WriteDebugMessage("Offers sub tab get clicked");

                //Verify the status when offer start date is in future date
                Queries.GetScheduledLoyaltyOffer(data);
                if (data.OfferTitle == null)
                {
                    Admin.Click_LoyaltySetUp_Offers_Button_AddOffers();
                    Logger.WriteDebugMessage("Offers editor page should get open");
                    Admin.AddORUpdateOffers(title, visibilityStartDate, visibilityEndDate, data.MembershipLevel, visibilityStartDate, visibilityEndDate, shortdescription);
                    Admin.UploadImage(imagePath);
                    AddDelay(5000);
                    Logger.WriteDebugMessage("Details are entered on the page");
                    Admin.AddPromotion(promotionCode, buttonName, data.PropertyName, promotionDescription, ProjectName);
                    Admin.Click_LoyaltySetUp_Offers_Button_ConfirmPromotion();
                    Logger.WriteDebugMessage("Promotion is added successfully");
                    Admin.Click_LoyaltySetUp_Offers_Button_Save();
                    if (PageObject_Admin.LoyaltySetUp_Offers_Button_Save().Displayed)
                    {
                        Admin.Click_LoyaltySetUp_Offers_Button_Cancel();
                    }
                    Logger.WriteDebugMessage("Added offer saved successfully");
                    Admin.LoyaltySetUp_Offers_Text_Filter(title);
                    AddDelay(1500);
                    VerifyTextOnPageAndHighLight("Scheduled");
                    Logger.WriteDebugMessage(title + " = Scheduled Offer got displayed on the page");
                }
                else
                {
                    Admin.LoyaltySetUp_Offers_Text_Filter(data.OfferTitle);
                    AddDelay(1500);
                    VerifyTextOnPageAndHighLight("Scheduled");
                    Logger.WriteDebugMessage(data.OfferTitle + " = Scheduled Offer got displayed on the page");

                }

                //Verify the status when offer start date is less than today and End Date is greater than today
                Queries.GetActiveLoyaltyOffer(data);
                Admin.LoyaltySetUp_Offers_Text_Filter(data.OfferTitle);
                AddDelay(5500);
                    VerifyTextOnPageAndHighLight("Active");
                Logger.WriteDebugMessage(data.OfferTitle + " = Active Offer got displayed on the page");

                //Verify the status when offer End Date is less than today
                Queries.GetInactiveLoyaltyOffer(data);
                Admin.LoyaltySetUp_Offers_Text_Filter(data.OfferTitle);
                AddDelay(1500);
                VerifyTextOnPageAndHighLight("Inactive");
                Logger.WriteDebugMessage(data.OfferTitle + " = Inactive Offer got displayed on the page");

                //Login as member in frontend and navigate to Exclusive offer page
                //Verify the Active Offer got displayed on the Page
                Driver.Url = ProjectDetails.CommonFrontendURL;
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Navigation.Click_Link_SpecialOffer();
                Logger.WriteDebugMessage("Navigated to Offers tab");
                PageDown();
                Queries.GetActiveLoyaltyOffer(data);
                if(Helper.IsElementRemoved(data.OfferTitle))
                {
                    VerifyTextOnPageAndHighLight(data.OfferTitle);
                    DynamicScrollToText(Driver, data.OfferTitle);
                    Logger.WriteDebugMessage("Active Offer got displayed on the Page");
                        
                }
                else
                {
                    Assert.Fail("Active Offer is not getting displayed on the page");
                }

                //Verify the Inactive Offer got displayed on the Page
                Queries.GetInactiveLoyaltyOffer(data);
                if (Helper.IsElementRemoved(data.OfferTitle))
                    Assert.Fail("Inactive Offer got displayed on the page");
                else
                    Logger.WriteInfoMessage("Inactive Offer is not getting displayed on the page");

                //Verify the Schedule Offer got displayed on the Page
                Queries.GetScheduledLoyaltyOffer(data);
                if (Helper.IsElementRemoved(data.OfferTitle))
                    Assert.Fail("Scheduled Offer got displayed on the page");
                else
                    Logger.WriteInfoMessage("Scheduled Offer is not getting displayed on the page");


            }
        }
        #endregion TP_109659 - Admin - Offers - Update Offers
    }
}
