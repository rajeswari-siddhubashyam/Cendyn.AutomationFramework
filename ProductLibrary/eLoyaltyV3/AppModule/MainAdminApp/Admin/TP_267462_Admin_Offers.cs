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
using TestData;
using Queries = eLoyaltyV3.Utility.Queries;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region TP_109684 - Admin - Offers
        private static void TC_109684()
        {
            if (TestCaseId == Constants.TC_109684)
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


                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Navigate to Loyalty Setup -> Offer tab
                Admin.Click_Menu_LoyaltySetup();
                Admin.Click_SubTab_Offers();
                Logger.WriteDebugMessage("Offers sub tab get clicked");
                Admin.Click_LoyaltySetUp_Offers_Button_AddOffers();
                Logger.WriteDebugMessage("Offers editor page should get open");
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                Logger.WriteDebugMessage("Validation messages should get displayed for All Fields");

                //Enter all mandatory field except for Image data and click on save 
                Admin.AddORUpdateOffers(title, visibilityStartDate, visibilityEndDate, data.MembershipLevel, visibilityStartDate, visibilityEndDate, shortdescription);
                Helper.DynamicScroll(Driver,PageObject_Admin.LoyaltySetUp_Offers_Button_AddAnotherPromotion());
                Admin.Click_LoyaltySetUp_Offers_Button_AddAnotherPromotion();
                VerifyTextOnPageAndHighLight(imageValidation);
                Logger.WriteDebugMessage(imageValidation + " = Validation message should get displayed");

                //Enter all mandatory field except for title 
                Admin.UploadImage(imagePath);
                AddDelay(5000);
                Admin.AddPromotion(promotionCode, buttonName, data.PropertyName, promotionDescription, ProjectName);
                Admin.Click_LoyaltySetUp_Offers_Button_ConfirmPromotion();
                Logger.WriteDebugMessage("Promotion is added successfully");
                Helper.ElementClearText(PageObject_Admin.LoyaltySetUp_Offers_Text_Title());
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                VerifyTextOnPageAndHighLight(titleVaidation);
                Logger.WriteDebugMessage(titleVaidation + " = Validation message should get displayed");

                //Enter all mandatory field except for Visibility Start  dates and click on save
                Admin.LoyaltySetUp_Offers_Text_Title(title);
                Helper.ElementClearText(PageObject_Admin.LoyaltySetUp_Offers_Text_VisibilityStart());
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                VerifyTextOnPageAndHighLight(visibilityStartValidation);
                Logger.WriteDebugMessage(visibilityStartValidation + " = Validation message should get displayed");

                //Enter all mandatory field except for Visibility End Date and click on save
                Admin.LoyaltySetUp_Offers_Text_VisibilityStart(visibilityStartDate);
                Helper.ElementClearText(PageObject_Admin.LoyaltySetUp_Offers_Text_VisibilityEnd());
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                VerifyTextOnPageAndHighLight(visibilityEndValidation);
                Logger.WriteDebugMessage(visibilityEndValidation + " = Validation message should get displayed");

                //Enter all mandatory field except for Promotion Start Date and click on save
                Admin.LoyaltySetUp_Offers_Text_VisibilityEnd(visibilityEndDate);
                Helper.ElementClearText(PageObject_Admin.LoyaltySetUp_Offers_Text_PromotionStart());
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                VerifyTextOnPageAndHighLight(promotionStartValidation);
                Logger.WriteDebugMessage(promotionStartValidation + " = Validation message should get displayed");

                //Enter all mandatory field  and Promotion Start date   with white space and click on save
                Admin.LoyaltySetUp_Offers_Text_PromotionStart("    ");
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                VerifyTextOnPageAndHighLight(promotionStartValidation);
                Logger.WriteDebugMessage(promotionStartValidation + " = Validation message should get displayed");

                //Enter all mandatory field except for Promotion End Date and click on save
                Admin.LoyaltySetUp_Offers_Text_PromotionStart(visibilityStartDate);
                Helper.ElementClearText(PageObject_Admin.LoyaltySetUp_Offers_Text_PromotionEnd());
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                VerifyTextOnPageAndHighLight(promotionEndValidation);
                Logger.WriteDebugMessage(promotionEndValidation + " = Validation message should get displayed");

                //Enter all mandatory field  and Promotion End date   with white space and click on save
                Admin.LoyaltySetUp_Offers_Text_PromotionEnd("    ");
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                VerifyTextOnPageAndHighLight(promotionEndValidation);
                Logger.WriteDebugMessage(promotionEndValidation + " = Validation message should get displayed");

                //Enter all mandatory field except for MemberLevel and click on save
                Admin.LoyaltySetUp_Offers_Text_PromotionEnd(visibilityEndDate);
                Admin.LoyaltySetUp_Offers_DeSelectMemberLevelALL();
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                VerifyTextOnPageAndHighLight(memberLevelValidation);
                Logger.WriteDebugMessage(memberLevelValidation + " = Validation message should get displayed");

                //Enter all mandatory field except for Short Description and click on save
                Admin.LoyaltySetUp_Offers_SelectMemberLevel(data.MembershipLevel);
                Helper.EnterFrame(ObjectRepository.Admin_LoyaltySetUp_IFrame_ShortDescription);
                Helper.ElementClearText(PageObject_Admin.LoyaltySetUp_Offers_Text_Description());
                Helper.ExitFrame();
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                VerifyTextOnPageAndHighLight(shortDescriptionValidation);
                Logger.WriteDebugMessage(shortDescriptionValidation + " = Validation message should get displayed");

                //Click on Add Promotion 
                
                Admin.Click_LoyaltySetUp_Offers_Button_AddAnotherPromotion();
                VerifyTextOnPageAndHighLight(shortDescriptionValidation);
                Logger.WriteDebugMessage(shortDescriptionValidation + " = Validation message should get displayed");

                //enter the  Short description and click on Add Promotion 
                Admin.LoyaltySetUp_Offers_Text_ShortDescription(shortdescription);
                Admin.Click_LoyaltySetUp_Offers_Button_AddAnotherPromotion();
                Logger.WriteDebugMessage("Add Promotion overlay should get displayed");

                //Click on Save button and validate validation message
                Admin.Click_LoyaltySetUp_Offers_Button_SavePromotion();
                Logger.WriteDebugMessage("All Validation messages displaying on the page");

                //Enter all mandatory field except for hotel Code  and click on save
                Admin.LoyaltySetUp_Offers_Text_PromotionCode("  ");
                Admin.LoyaltySetUp_Offers_Text_ButtonText(buttonName);
                Admin.LoyaltySetUp_Offers_Dropdown_HotelSelection(data.PropertyName, ProjectName);
                Admin.LoyaltySetUp_Offers_Text_PromotionDescription(promotionDescription);
                Admin.Click_LoyaltySetUp_Offers_Button_SavePromotion();
                VerifyTextOnPageAndHighLight(promotionCodeValidation);
                Logger.WriteDebugMessage(promotionCodeValidation + " = Validation message should get displayed");

                //Enter all mandatory field except for Description and click on save
                Admin.LoyaltySetUp_Offers_Text_PromotionCode(promotionCode);
                Admin.LoyaltySetUp_Offers_Text_PromotionDescription("  ");
                Admin.Click_LoyaltySetUp_Offers_Button_SavePromotion();
                VerifyTextOnPageAndHighLight(descriptionValidation);
                Logger.WriteDebugMessage(descriptionValidation + " = Validation message should get displayed");


                //Enter all mandatory field except for Button text  and click on save
                Admin.LoyaltySetUp_Offers_Text_PromotionDescription(promotionDescription);
                Admin.LoyaltySetUp_Offers_Text_ButtonText("  ");
                Admin.Click_LoyaltySetUp_Offers_Button_SavePromotion();
                VerifyTextOnPageAndHighLight(buttonTextValidation);
                Logger.WriteDebugMessage(buttonTextValidation + " = Validation message should get displayed");



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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Button Text Validation", buttonTextValidation,true);
            }
        }

        private static void TC_109686()
        {
            if (TestCaseId == Constants.TC_109686)
            {
                //pre-requiste
                string imagePath, frontend_URL,title, visibilityStartDate, visibilityEndDate, promotionDescription, promotionCode, buttonName, shortdescription;
                Random ranno = new Random();
                Users data = new Users();
                Utility.Queries.GetMemberLevel(data, 2);
                Utility.Queries.IdentifyHotel(data);
                Queries.GetActiveMemberEmail(data);

                //Retrive data from test data
                imagePath = String.Concat(ProjectPath, TestData.ExcelData.TestDataReader.ReadData(1, "ImagePath"));
                title = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Title"), ranno.Next().ToString());
                visibilityStartDate = TestData.ExcelData.TestDataReader.ReadData(1, "VisibilityStartDate");
                visibilityEndDate = TestData.ExcelData.TestDataReader.ReadData(1, "VisibilityEndDate");
                promotionDescription = MakeUnique("Promotion");
                promotionCode = ranno.Next().ToString().Substring(0,5);
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
                Admin.Click_LoyaltySetUp_Offers_Button_AddOffers();
                Logger.WriteDebugMessage("Offers editor page should get open");

                //Enter all mandatory field except for Image data and click on save 
                Admin.AddORUpdateOffers(title+"$", visibilityStartDate, visibilityEndDate, data.MembershipLevel, visibilityStartDate, visibilityEndDate, shortdescription+"*");
                Admin.LoyaltySetUp_Offers_SelectMemberLevelALL();
                Admin.UploadImage(imagePath);
                AddDelay(5000);
                Logger.WriteDebugMessage("Details are entered succesfully on Add offer overlay");
                Admin.AddPromotion(promotionCode+"#", buttonName+"@", data.PropertyName, promotionDescription+"&", ProjectName);
                Admin.Click_LoyaltySetUp_Offers_Button_ConfirmPromotion();
                Logger.WriteDebugMessage("Promotion is added successfully");
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                Logger.WriteDebugMessage("Offers saved successfully");

                // Navigate to Frontend and check added Offer
                OpenNewTab();
                ControlToNewWindow();
                Driver.Url = frontend_URL;
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Navigation.Click_Link_SpecialOffer();
                Logger.WriteDebugMessage("Navigated to Offers tab");
                ScrollToText(title+"$");
                VerifyTextOnPageAndHighLight(title+"$");
                VerifyTextOnPageAndHighLight(shortdescription + "*");
                Navigation.Click_SpecialOffers_Readmore(title+"$");
                VerifyTextOnPageAndHighLight(promotionDescription+"&");
                Logger.WriteDebugMessage("Details displaying on the Frontend as Admin");



                //Log Test data into Log file and extend Report

                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Image Path", imagePath);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Title", title+"$");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Visibility Start Date", visibilityStartDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Visibility End Date", visibilityEndDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Promotion Description", promotionDescription+"&");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Promotion Code", promotionCode+"#");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Button Name", buttonName+"@");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Short Description", shortdescription+"*",true);
            }
        }

        private static void TC_109688()
        {
            if (TestCaseId == Constants.TC_109688)
            {
                //pre-requiste
                string imagePath, title, visibilityStartDate, visibilityEndDate, promotionDescription, promotionCode, buttonName, shortdescription;
                Random ranno = new Random();
                Users data = new Users();
                Utility.Queries.GetMemberLevel(data, 2);
                Utility.Queries.IdentifyHotel(data);

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
                Admin.Click_LoyaltySetUp_Offers_Button_AddOffers();
                Logger.WriteDebugMessage("Offers editor page should get open");

                //Enter all mandatory and click on save 
                Admin.AddORUpdateOffers(title, visibilityStartDate, visibilityEndDate, data.MembershipLevel, visibilityStartDate, visibilityEndDate, shortdescription);
                Admin.UploadImage(imagePath);
                AddDelay(5000);
                Logger.WriteDebugMessage("Details are entered on the page");
                Admin.AddPromotion(promotionCode, buttonName, data.PropertyName, promotionDescription, ProjectName);
                Admin.Click_LoyaltySetUp_Offers_Button_ConfirmPromotion();
                Logger.WriteDebugMessage("Promotion is added successfully");
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                if(PageObject_Admin.LoyaltySetUp_Offers_Button_Save().Displayed)
                {
                    Admin.Click_LoyaltySetUp_Offers_Button_Cancel();
                }
                else
                    Logger.WriteDebugMessage("Added offer saved successfully");

                Admin.LoyaltySetUp_Offers_Text_Filter(title);
                AddDelay(5000);
                VerifyTextOnPageAndHighLight(title);
                Logger.WriteDebugMessage(title+"= Offers saved successfully");

                // Edit recently added offer and verify details entered while adding
                Admin.Click_LoyaltySetUp_Offers_Icon_Edit();
                Logger.WriteDebugMessage("Edit button clicked");
                PageDown();
                VerifyTextOnPageAndHighLight(promotionCode);
                VerifyTextOnPageAndHighLight(buttonName);
                Logger.WriteDebugMessage("All details same as details entered while adding");

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Image Path", imagePath);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Title", title);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Visibility Start Date", visibilityStartDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Visibility End Date", visibilityEndDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Promotion Description", promotionDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Promotion Code", promotionCode);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Button Name", buttonName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Short Description", shortdescription,true);
            }
        }
        private static void TC_109689()
        {
            if (TestCaseId == Constants.TC_109689)
            {
                //pre-requiste
                string imagePath, title, visibilityStartDate, visibilityEndDate, shortdescription, cancelButton_Validation;
                Random ranno = new Random();
                Users data = new Users();
                Queries.GetMemberLevel(data, 2);
                

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
                Admin.Click_LoyaltySetUp_Offers_Button_AddOffers();
                Logger.WriteDebugMessage("Offers editor page should get open");

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
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Cancel Button Validation", cancelButton_Validation,true);
            }
        }
        private static void TC_109750()
        {
            if (TestCaseId == Constants.TC_109750)
            {
                //pre-requiste
                string imagePath, title, visibilityStartDate, visibilityEndDate, shortdescription, visibilityStartDate_Greater, visibilityDate_Validation, promotionDate_Validation;
                Random ranno = new Random();
                Users data = new Users();
                Queries.GetMemberLevel(data, 2);
                Queries.IdentifyHotel(data);
                

                //Retrive data from test data
                imagePath = String.Concat(ProjectPath, TestData.ExcelData.TestDataReader.ReadData(1, "ImagePath"));
                title = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Title"), ranno.Next().ToString());
                visibilityStartDate = TestData.ExcelData.TestDataReader.ReadData(1, "VisibilityStartDate");
                visibilityEndDate = TestData.ExcelData.TestDataReader.ReadData(1, "VisibilityEndDate");
                shortdescription = TestData.ExcelData.TestDataReader.ReadData(1, "ShortDescription");
                visibilityStartDate_Greater = TestData.ExcelData.TestDataReader.ReadData(1, "VisibilityStartDate_Greater");
                visibilityDate_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "VisibilityDate_Validation");
                promotionDate_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "PromotionDate_Validation");


                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Navigate to Loyalty Setup -> Offer tab
                Admin.Click_Menu_LoyaltySetup();
                Logger.WriteDebugMessage("Loyalty Setup tab get clicked");
                Admin.Click_SubTab_Offers();
                Logger.WriteDebugMessage("Offers sub tab get clicked");
                Admin.Click_LoyaltySetUp_Offers_Button_AddOffers();
                Logger.WriteDebugMessage("Offers editor page should get open");

                //Enter Visibility Period start date > Visibility Period End date using copy paste  

                Admin.AddORUpdateOffers(title, visibilityStartDate_Greater, visibilityEndDate, data.MembershipLevel, visibilityStartDate, visibilityEndDate, shortdescription);
                Admin.UploadImage(imagePath);
                AddDelay(10000);
                Admin.Click_LoyaltySetUp_Offers_Button_AddAnotherPromotion();
                VerifyTextOnPageAndHighLight(visibilityDate_Validation);
                Logger.WriteDebugMessage(visibilityDate_Validation + " = Validation message displayed");

                //Update Correct Visibility Start and End Date
                Admin.LoyaltySetUp_Offers_Text_VisibilityStart(visibilityStartDate);
                Admin.LoyaltySetUp_Offers_Text_VisibilityEnd(visibilityEndDate);

                //Enter Promotion Period start date > Promotion Period End date using copy paste  
                Admin.LoyaltySetUp_Offers_Text_PromotionStart(visibilityStartDate_Greater);
                Admin.LoyaltySetUp_Offers_Text_PromotionEnd(visibilityEndDate);
                Admin.Click_LoyaltySetUp_Offers_Button_AddAnotherPromotion();
                VerifyTextOnPageAndHighLight(promotionDate_Validation);
                Logger.WriteDebugMessage(promotionDate_Validation + " = Validation message displayed");

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Image Path", imagePath);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Title", title);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Visibility Start Date", visibilityStartDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Visibility End Date", visibilityEndDate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Short Description", shortdescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Greater Date", visibilityStartDate_Greater);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Visibility Date Validation", visibilityDate_Validation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Promotion Date Validation", promotionDate_Validation,true);
            }
        }
        private static void TC_110850()
        {
            if (TestCaseId == Constants.TC_110850)
            {
                //Pre-requisite
                string title,buttonName, hotel, promotionDescription;
                Users data = new Users();
                Queries.GetMemberLevel(data, 2);
                Queries.IdentifyHotel(data);
                Queries.GetActiveMemberEmail(data);
                Random ranno = new Random();

                //Retrieve data
                hotel = data.PropertyName;
                promotionDescription = MakeUnique("Promotion");
                buttonName = String.Concat("Button_", ranno.Next().ToString().Substring(0,4));

                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("User landed on home page");


                //Navigate to Loyalty Setup -> Offer tab
                Admin.Click_Menu_LoyaltySetup();
                Logger.WriteDebugMessage("Loyalty Setup tab get clicked");
                Admin.Click_SubTab_Offers();
                Logger.WriteDebugMessage("Offers sub tab get clicked");

                //Click on edit icon of an Offer
                Helper.ScrollToElement(PageObject_Admin.LoyaltySetUp_Offers_Icon_Edit());
                Admin.Click_LoyaltySetUp_Offers_Icon_Edit();
                title = Helper.Getdata(PageObject_Admin.LoyaltySetUp_Offers_Text_Title());
                Logger.WriteDebugMessage("User landed on  Offer Editor page");

                //Click on  edit icon against one of the Promos grid  and Capture the Promo  code
            //    Helper.ScrollToElement(PageObject_Admin.LoyaltySetUp_Offers_Button_EditPromotion());
                Admin.Click_LoyaltySetUp_Offers_Button_EditPromotion();
                string promotionCode = Helper.Getdata(PageObject_Admin.LoyaltySetUp_Offers_Text_PromotionCode());
                Logger.WriteDebugMessage(promotionCode + "= Offer Promo captured");
                Admin.Click_LoyaltySetUp_Offers_Button_CancelPromotion();
                Logger.WriteDebugMessage("Landed on Edit Promotion Page");

                //Click on Add Promotion 
                Admin.AddPromotion(promotionCode, buttonName, hotel, promotionDescription, ProjectName);
                Logger.WriteDebugMessage("Promotion is added successfully");

                //Click on Save in Offer Editor page 
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                if (PageObject_Admin.LoyaltySetUp_Offers_Button_Save().Displayed)
                {
                    Admin.Click_LoyaltySetUp_Offers_Button_Cancel();
                }
                Logger.WriteDebugMessage("Edited offer saved successfully");

                //Click on Edit icon of the same offer
                Admin.LoyaltySetUp_Offers_Text_Filter(title);
                AddDelay(10000);
                VerifyTextOnPageAndHighLight(title);
                Logger.WriteDebugMessage("Searched Offer got displayed");
                Admin.Click_LoyaltySetUp_Offers_Icon_Edit();
                Logger.WriteDebugMessage("Offer edit button clicked");

                //11.Duplicated Promo code should get  displayed 
                VerifyTextOnPageAndHighLight(promotionCode);
                PageDown();
                Logger.WriteDebugMessage("Promo code gets displayed ");

                //Navigate to frontend and verify the details present on offers page
                OpenNewTab();
                ControlToNewWindow();
                Driver.Url = ProjectDetails.CommonFrontendURL;
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Navigation.Click_Link_SpecialOffer();
                Logger.WriteDebugMessage("Navigated to Offers tab");
                PageDown();
                VerifyTextOnPageAndHighLight(title);
                Navigation.Click_SpecialOffers_Readmore(title);
                ScrollToText(promotionDescription);
                VerifyTextOnPageAndHighLight(promotionDescription);
                Logger.WriteDebugMessage("Details displaying on the Frontend as Admin");

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Title", title);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Hotel", hotel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Promotion Description", promotionDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Button Name", buttonName,true);
            }
        }
        private static void TC_109685()
        {
            if (TestCaseId == Constants.TC_109685)
            {
                //pre-requiste
                string imagePath, title, visibilityStartDate, visibilityEndDate, promotionDescription, promotionCode, buttonName, shortdescription, shortdescription_CharLimit,
                    title_CharLimit, promoDescription_CharLimit, promoCode_CharLimit, buttonText_CharLimit, shortdescription_CharLimitValidation,promoDescription_CharLimitValidation;
                Random ranno = new Random();
                Users data = new Users();
                Utility.Queries.GetMemberLevel(data, 2);
                Utility.Queries.IdentifyHotel(data);

                //Retrive data from test data
                imagePath = String.Concat(ProjectPath, TestData.ExcelData.TestDataReader.ReadData(1, "ImagePath"));
                title = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Title"), ranno.Next().ToString());
                visibilityStartDate = TestData.ExcelData.TestDataReader.ReadData(1, "VisibilityStartDate");
                visibilityEndDate = TestData.ExcelData.TestDataReader.ReadData(1, "VisibilityEndDate");
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
                Admin.Click_LoyaltySetUp_Offers_Button_AddOffers();
                Logger.WriteDebugMessage("Offers editor page should get open");

                //Validate char limit for short description
                Admin.UploadImage(imagePath);
                AddDelay(5000);
                Admin.AddORUpdateOffers(title, visibilityStartDate, visibilityEndDate, data.MembershipLevel, visibilityStartDate, visibilityEndDate, shortdescription_CharLimit);
                Helper.DynamicScroll(Driver, PageObject_Admin.LoyaltySetUp_Offers_Button_AddAnotherPromotion());
                Admin.Click_LoyaltySetUp_Offers_Button_AddAnotherPromotion();
                VerifyTextOnPageAndHighLight(shortdescription_CharLimitValidation);
                Logger.WriteDebugMessage(shortdescription_CharLimitValidation+"= Validation message displayed");

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
                Admin.AddPromotion(promoCode_CharLimit, buttonName, data.PropertyName, promotionDescription, ProjectName);
                Admin.Click_LoyaltySetUp_Offers_Button_SavePromotionCancel();
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
      
        #endregion TP_109684 - Admin - Offers
    }
}
