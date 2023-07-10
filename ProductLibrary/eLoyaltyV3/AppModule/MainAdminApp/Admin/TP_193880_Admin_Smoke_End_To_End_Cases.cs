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
using BaseUtility.PageObject;
using eLoyaltyV3.Utility;
using OpenQA.Selenium;
using System.Linq.Expressions;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region TP_193880 - Admin - SmokeEndToEndCases
        public static void TC_194035()
        {
            if (TestCaseId == Constants.TC_194035)
            {
                Users data = new Users();

                //Pre-requisites:
                //1.Log into Admin.
                //2.Navigate to Loyalty Rules
                //3.Click on Points Earning Rules Tab
                string startDate, endDate, name, displayName, description, basedOn, ruleType, priority1, qualifyNights, pointsEarned, per, calculatedOn, revenueType, pointExpiryMonth, memberlevel, ruleName, priority, ruleNameFuture;
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                Admin.Click_Menu_LoyaltyRules();
                Logger.WriteDebugMessage("Landed on the Loyalty Rules page");
                Admin.Click_SubTab_PointsEarningRules();
                Logger.WriteDebugMessage("Users Landed on Points Earning Rules Page");

                //1.Click on Add Rule 
                Admin.Click_PointsEarningRules_Button_AddRule();
                Logger.WriteDebugMessage("Loyalty rule popup should get displayed ");

                //2.Verify all the fields of rule data 
                //VerifyTextOnPage();

                //3.Enter valid data on Rule Tab Fields and click on cancel button
                startDate = DateTime.Now.ToString("MM/dd/yyyy");
                endDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                name = TestData.ExcelData.TestDataReader.ReadData(1, "Name");
                displayName = TestData.ExcelData.TestDataReader.ReadData(1, "DisplayName");
                description = TestData.ExcelData.TestDataReader.ReadData(1, "Description");
                basedOn = TestData.ExcelData.TestDataReader.ReadData(1, "BasedOn");
                ruleType = TestData.ExcelData.TestDataReader.ReadData(1, "RuleType");
                priority1 = TestData.ExcelData.TestDataReader.ReadData(1, "Priority");
                qualifyNights = TestData.ExcelData.TestDataReader.ReadData(1, "For");
                pointsEarned = TestData.ExcelData.TestDataReader.ReadData(1, "PointsEarned");
                per = TestData.ExcelData.TestDataReader.ReadData(1, "Per");
                calculatedOn = TestData.ExcelData.TestDataReader.ReadData(1, "CalculatedOn");
                revenueType = TestData.ExcelData.TestDataReader.ReadData(1, "RevenueType");
                pointExpiryMonth = TestData.ExcelData.TestDataReader.ReadData(1, "PointExpiryMonth");

                Logger.LogTestData(TestPlanId, TestCaseId, "Start Date", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, "End Date", endDate);
                Logger.LogTestData(TestPlanId, TestCaseId, "Name", name);
                Logger.LogTestData(TestPlanId, TestCaseId, "Display Name", displayName);
                Logger.LogTestData(TestPlanId, TestCaseId, "Description", description);
                Logger.LogTestData(TestPlanId, TestCaseId, "Based On", basedOn);
                Logger.LogTestData(TestPlanId, TestCaseId, "Rule Type", ruleType);
                Logger.LogTestData(TestPlanId, TestCaseId, "Priority", priority1);
                Logger.LogTestData(TestPlanId, TestCaseId, "Quality Night", qualifyNights);
                Logger.LogTestData(TestPlanId, TestCaseId, "Points Earned", pointsEarned);
                Logger.LogTestData(TestPlanId, TestCaseId, "Per", per);
                Logger.LogTestData(TestPlanId, TestCaseId, "Calculated On", calculatedOn);
                Logger.LogTestData(TestPlanId, TestCaseId, "Revenue Type", revenueType);
                Logger.LogTestData(TestPlanId, TestCaseId, "Point Expiry", pointExpiryMonth);

                ruleName = MakeUnique(name);
                Queries.GetMemberLevel(data, 1);
                memberlevel = data.MembershipLevel;

                priority = String.Concat(DateTime.Now.Millisecond, DateTime.Now.Hour);
                ruleNameFuture = MakeUnique(name);
                Admin.PointsEarningRule_AddRule(ruleName, displayName, description,
                    basedOn, startDate, endDate, ruleType, priority, qualifyNights,
                    pointsEarned, per, calculatedOn, revenueType, pointExpiryMonth,
                    memberlevel, ProjectName);
                Logger.WriteDebugMessage("user should be able to Enter all the fields");
                Admin.Click_PointsEarningRules_Button_Cancel();
                Logger.WriteDebugMessage("Popup should close and data is not save");

                //4.Click on Add Rule
                Admin.Click_PointsEarningRules_Button_AddRule();
                Logger.WriteDebugMessage("Loyalty rule popup should get displayed ");

                //5.Enter Valid data on Rule tab fields 
                //6.Validate that start date is future date and click on save
                string startDateFuture = DateTime.Now.ToString("MM/dd/yyyy");
                string endDateFuture = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                Admin.PointsEarningRule_AddRule(ruleNameFuture, displayName, description,
                    basedOn, startDateFuture, endDateFuture, ruleType, priority, qualifyNights,
                    pointsEarned, per, calculatedOn, revenueType, pointExpiryMonth,
                    memberlevel, ProjectName);
                Logger.WriteDebugMessage("user should be able to Enter all the fields");
                Admin.Click_PointsEarningRules_Button_Save();
                VerifyTextOnPage("Save successful.");
                Logger.WriteDebugMessage("Data should be entered successfully");

                // Added this method for now as defect is marked medium priority
                Admin.Click_SubTab_PointsEarningRules();
                //7.Search for Rule created at step 4
                //Admin.Click_SubTab_PointsEarningRules();
                Admin.Enter_PointsEarningRules_Text_Filter(ruleNameFuture);
                AddDelay(2500);
                VerifyTextOnPageAndHighLight(ruleNameFuture);
                Logger.WriteDebugMessage("Rule should be found");

                //8.Click on Edit Icon
                Admin.Click_PointsEarningRules_Icon_Edit();
                Logger.WriteDebugMessage("Loyalty rule popup should get displayed ");

                //9.Edit all field data and click on save
                string ruleNameEditted = MakeUnique(name);
                string priorityEditted = string.Concat(DateTime.Now.Millisecond, DateTime.Now.Hour);
                Admin.PointsEarningRule_UpdateRule(ruleNameEditted, displayName, description, priorityEditted, pointsEarned, per);
                Logger.WriteDebugMessage("user should be able to Edit all field data");
                Admin.Click_PointsEarningRules_Button_Save();
                AddDelay(3000);
                Admin.Click_SubTab_PointsEarningRules();
                Logger.WriteDebugMessage("Updated data should be save successfully");

                // Added this method for now as defect is marked medium priority
                Admin.Click_SubTab_PointsEarningRules();
                //10.Search for the rule with updated data
                Admin.Enter_PointsEarningRules_Text_Filter(ruleNameEditted);
                AddDelay(2500);
                VerifyTextOnPageAndHighLight(ruleNameEditted);
                Logger.WriteDebugMessage("Updated rule should be found");

                //11.Click on Edit Icon
                Admin.Click_PointsEarningRules_Icon_Edit();
                Logger.WriteDebugMessage("Field value should get updated.");

                //12.Update the end date to past date and click on save
                string startDatePast = DateTime.Now.AddDays(-2).ToString("MM/dd/yyyy");
                string endDatePast = DateTime.Now.AddDays(-1).ToString("MM/dd/yyyy");
                Admin.Enter_PointsEarningRules_Text_StartDate(startDatePast);
                Admin.Enter_PointsEarningRules_Text_EndDate(endDatePast);
                Admin.Click_PointsEarningRules_Button_Save();
                Logger.WriteDebugMessage("Rule should be save with updated end date and rule should be inactive");
                Logger.LogTestData(TestPlanId, TestCaseId, "Past Start Date", startDatePast);
                Logger.LogTestData(TestPlanId, TestCaseId, "Past End Date", endDatePast, true);
                //13.Search for the above rule        
                //Admin.Click_SubTab_PointsEarningRules();    
                Admin.Click_SubTab_PointsEarningRules();
                Admin.Enter_PointsEarningRules_Text_Filter(ruleNameEditted);
                AddDelay(2500);
                VerifyTextOnPageAndHighLight(ruleNameEditted);
                VerifyTextOnPageAndHighLight("Inactive");
                Logger.WriteDebugMessage("Rule should get Inactive");

                //14.Click on edit icon of above inactive rule
                Admin.Click_PointsEarningRules_Icon_Edit();
                Logger.WriteDebugMessage("User should no be able to edit the inactive rule");
            }
        }

        public static void TC_194195()
        {
            if (TestCaseId == Constants.TC_194195)
                {
                    Users data = new Users();
                    string emailName;
                    //Pre-requisites:
                    //1.Log into Admin.
                    //2.Navigate to Loyalty Awards

                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    Admin.Click_LoyaltyAwards();
                    Logger.WriteDebugMessage("Users Landed on Loyalty Awards Page");

                    //1.Click on Add Rule 
                    Admin.Click_LoyaltyAwards_Button_Add();
                    Logger.WriteDebugMessage("Loyalty Awards popup should get display");

                    //2.Enter valid data on Rule Tab Fields and click on cancel button
                    string startDate = DateTime.Now.ToString("MM/dd/yyyy");
                    string endDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                    string awardName1 = TestData.ExcelData.TestDataReader.ReadData(1, "AwardName");
                    string daysActive = TestData.ExcelData.TestDataReader.ReadData(1, "DaysActive");
                    string advanceDeliveryDays = TestData.ExcelData.TestDataReader.ReadData(1, "AdvanceDeliveryDays");
                    if (ProjectName.Equals("HotelOrigami"))
                        emailName = TestData.ExcelData.TestDataReader.ReadData(1, "OrigamiEmailName");
                    else
                        emailName = TestData.ExcelData.TestDataReader.ReadData(1, "EmailName");
                    string awardName = MakeUnique(awardName1);
                    Queries.GetMemberLevel(data, 1);
                    string level = data.MembershipLevel;
                    if (ProjectName.Equals("Bartell"))
                    {
                        string award = Admin.AssignAwardType(ProjectName, "Night Based");
                    }

                    string awardType = Admin.AssignAwardType(ProjectName, "Birthday");
                    //string code = string.Concat(DateTime.Now.Millisecond, DateTime.Now.Hour);                    
                    Random rnd = new Random();
                    string code = rnd.Next(1000, 10000).ToString();
                    Admin.AddAward(awardName, code, startDate, endDate, awardType);
                    Admin.AddbirthdayAward(daysActive, advanceDeliveryDays, level, emailName);
                    Admin.Click_LoyaltyAwards_Button_Cancel();
                    Logger.WriteDebugMessage("Popup should close and data is not save");

                    //3.Click on Add button
                    Admin.Click_LoyaltyAwards_Button_Add();
                    Logger.WriteDebugMessage("Loyalty Awards popup should get display ");

                    //4.Enter valid data on Loyalty Awards popup fields with Award Type Birthday based 
                    string awardType1 = TestData.ExcelData.TestDataReader.ReadData(1, "AwardType");
                    Admin.Dropdown_AwardType(awardType1);
                    VerifyTextOnPage("Days Active:");
                    VerifyTextOnPage("Advance Delivery Days:");
                    VerifyTextOnPage("Min. Qualified Stay:");
                    VerifyTextOnPage("Member Level:");
                    VerifyTextOnPage("Email Name:");
                    Logger.WriteDebugMessage("Below fields should be populated after selecting award type:-Days active,advanced delivery days,Min.Qualified Stays,Select member level,Email name");

                    //5.Enter details and click on save
                    Admin.AddAward(awardName, code, startDate, endDate, awardType);
                    Admin.AddbirthdayAward(daysActive, advanceDeliveryDays, level, emailName);
                    Logger.WriteDebugMessage("All Details are added Correctly");
                    Admin.Click_LoyaltyAwards_Button_Save();
                    VerifyTextOnPage("Save Succesful.");
                    AddDelay(5000);
                    Logger.WriteDebugMessage("Popup should be closed and award should be created");

                    //6.Search for award created
                    Admin.LoyaltyAwards_Text_Filter(awardName);
                    AddDelay(1500);
                    Logger.WriteDebugMessage("Award should be found");

                    //7.Click on edit icon
                    Admin.Click_LoyaltyAwards_Icon_Edit();
                    Logger.WriteDebugMessage("Loyalty award popup should get display");

                    //8.Try and update award code value
                    string value = PageObject_Admin.Admin_LoyaltyAwards_Text_AwardCode().GetAttribute("disabled");
                    if (value.Equals("true"))
                        Logger.WriteDebugMessage("User should not be able to update award code");
                    else
                        Assert.Fail("Value is Editable");


                    //9.Edited the existing data for all fields and click on save 
                    string awardNameUpdated = MakeUnique(awardName1);
                    Admin.EditAward(awardNameUpdated, startDate, endDate, awardType);
                    Logger.WriteDebugMessage("Award Name Updated Correctly");
                    Admin.Click_LoyaltyAwards_Button_Save();
                    Logger.WriteDebugMessage("Data should be saved successfully");
                    VerifyTextOnPage("Save Succesful.");

                    //10.Search for the award updated data
                    Admin.LoyaltyAwards_Text_Filter(awardNameUpdated);
                    AddDelay(1500);
                    Logger.WriteDebugMessage("Award should be found");

                    //11.Click on edit icon
                    Admin.Click_LoyaltyAwards_Icon_Edit();
                    Logger.WriteDebugMessage("Loyalty award popup should get display");

                    //12.Edit the end date of Award as past date and click on Save
                    string startdateUpdated = DateTime.Now.AddDays(-2).ToString("MM/dd/yyyy");
                    string enddateUpdated = DateTime.Now.AddDays(-1).ToString("MM/dd/yyyy");

                    Admin.EditAward(awardNameUpdated, startdateUpdated, enddateUpdated, awardType);
                    VerifyTextOnPage("Past Dates are selected.");
                    Admin.Click_LoyaltyAwards_Button_Save();
                    VerifyTextOnPage("The end date must be greater than today's date.");
                    Logger.WriteDebugMessage("Unable to save the Award with past date");

                    //[Ashish]: Commented the code as Admin is unable to Enter the past date for the award
                    ////13.Search for the award updated data
                    //Admin.LoyaltyAwards_Text_Filter(awardNameUpdated);
                    //AddDelay(1500);
                    //Logger.WriteDebugMessage("Award should be found");

                    ////14.Click on Edit icon
                    //Admin.Click_LoyaltyAwards_Icon_Edit();
                    //Logger.WriteDebugMessage("Loyalty award popup should get display");

                    //15.Try and update data for award added
                    string value1 = PageObject_Admin.Admin_LoyaltyAwards_Text_AwardCode().GetAttribute("disabled");
                    if (value1.Equals("true"))
                        Logger.WriteInfoMessage("Value is NOT Editable");
                    else
                        Assert.Fail("Value is Editable");
                    Logger.WriteDebugMessage("User should be able to update all the field Except for Award Code");
                    Admin.Click_LoyaltyAwards_Button_Cancel();

                    // Switch the award status off
                    Admin.LoyaltyAwards_Text_Filter(awardNameUpdated);
                    AddDelay(5000);
                    Logger.WriteDebugMessage("Award should be found");
                    Admin.Click_LoyaltyAwards_Icon_Edit();
                    AddDelay(5000);
                    Logger.WriteDebugMessage("Loyalty award popup should get display");
                    Admin.Click_Admin_AwardStatusSwitch();
                    AddDelay(5000);
                    Logger.WriteDebugMessage("Award Status button got switch off");
                    Admin.Click_LoyaltyAwards_Button_Save();
                    AddDelay(5000);
                    Logger.WriteDebugMessage("Award Status get switch off");
                    Admin.LoyaltyAwards_Text_Filter(awardNameUpdated);
                    AddDelay(5000);
                    Logger.WriteDebugMessage("Award should be found");

            }         
        }

        public static void TC_194218()
        {
            if (TestCaseId == Constants.TC_194218)
            {
                //Pre-requisites:
                //1.Log into Admin.
                //2.Navigate to Loyalty Setup
                //3.Click on Transaction Reason
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                Admin.Click_Menu_LoyaltySetup();
                Logger.WriteDebugMessage("Landed on the Loyalty Setup page");
                Admin.Click_SubTab_TransactionReason();
                Logger.WriteDebugMessage("Users Landed on Transaction Reasons Page");

                //1.Verify the columns of the  Transaction Reasons grid
                VerifyTextOnPage("Code");
                VerifyTextOnPage("Reason Name");
                VerifyTextOnPage("Edit");
                Logger.WriteDebugMessage("Transaction Reason grid should be displayed following columns:-Code,Reason name,Edit");

                //2.Click on Add reason Button
                Admin.Click_TransactionReason_Button_AddReason();
                Logger.WriteDebugMessage("Add Reason pop should get display");

                //3.Enter all the fields and Click on Save
                string code = DateTime.Now.Millisecond.ToString();
                string reason1 = TestData.ExcelData.TestDataReader.ReadData(1, "Reason");
                string reason = MakeUnique(reason1);
                Admin.AddLoyaltyTransactionReason(code, reason);
                Logger.WriteDebugMessage("user should be able to Enter all the fields");
                Admin.Click_TransactionReason_Button_Save();
                AddDelay(5000);
                VerifyTextOnPage("Save successful.");
                Logger.WriteDebugMessage("Reason should get saved successfully.");

                //4.Click on edit icon of any one of  the transaction reason
                Admin.TransactionReason_Text_Filter(reason);
                AddDelay(500);
                Admin.Click_TransactionReason_Icon_Edit();
                Logger.WriteDebugMessage("Loyalty Transaction Reason popup should get display");

                //5.Edited the existing data for all fields and click on save 
                string code1 = DateTime.Now.Millisecond.ToString();
                string reason2 = MakeUnique(reason1);
                Admin.AddLoyaltyTransactionReason(code1, reason2);
                Logger.WriteDebugMessage("user should be able to Edited the existing data");
                Admin.Click_TransactionReason_Button_Save();
                AddDelay(5000);
                Logger.WriteDebugMessage("Data should be saved successfully");

                //6.Validate that the added transaction reason is available in Member Information -> MemberTransaction -> Add Transaction 
                Admin.Click_Menu_Home();
                string searchUser = TestData.ExcelData.TestDataReader.ReadData(1, "SearchUser");
                Admin.EnterEmail(searchUser);
                Admin.SelectMemberStatus("Active");
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Admin.Click_Icon_View(ProjectName);
                AddDelay(15000);
                Logger.WriteDebugMessage("Used redirected to Dashboards page");
                if (!ProjectName.Equals("HotelIcon"))
                {
                    Admin.Click_Tab_MemberTransactions();
                    AddDelay(500);
                    Admin.Click_Button_AddTransaction();
                    Logger.WriteDebugMessage("Add transaction pop is displayed");
                    List<string> values = Admin.GetTransactionReason();
                    foreach (string item in values)
                    {
                        if (item.Contains(reason))
                        {
                            Logger.WriteDebugMessage("Transaction reason should be displayed in Member Information -> MemberTransaction -> Add Transaction ");
                        }
                    }
                }
            }
        }

        public static void TC_194219()
        {
            if (TestCaseId == Constants.TC_194219)
            {
                //Pre-requisites:
                //1.Log into Admin.
                //2.Navigate to Loyalty Setup
                //3.Click on Transaction Reason
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                Admin.Click_Menu_LoyaltySetup();
                Logger.WriteDebugMessage("Landed on the Loyalty Setup page");
                Admin.Click_SubTab_SignUpSources();
                Logger.WriteDebugMessage("Users Landed on Sign Up Source Page");

                //1.Verify the columns of the Sign Up Sources grid
                VerifyTextOnPage("Source Code");
                VerifyTextOnPage("Source Name");
                VerifyTextOnPage("Edit");
                Logger.WriteDebugMessage("Popup should close and Source should be created");

                //2.Click on edit icon of the created Sign Up Sources
                string searchUser = TestData.ExcelData.TestDataReader.ReadData(1, "SearchUser");
                Admin.SignUpSource_Text_Filter(searchUser);
                AddDelay(500);
                Admin.Click_SignUpSource_Icon_Edit();
                AddDelay(1500);
                Logger.WriteDebugMessage("Loyalty Sign Up Sources popup should get display");

                //3.Edited the existing data for all fields and click on save
                string signUpSourceCode = TestData.ExcelData.TestDataReader.ReadData(1, "SignUpSourceCode");
                string signUpSource = TestData.ExcelData.TestDataReader.ReadData(1, "SignUpSource");
                Random randonSignUpCode = new Random();
                string signUpcode = randonSignUpCode.Next(0, 26).ToString();
                string signUpsourcename = MakeUnique(signUpSource);
                Admin.AddLoyaltySignUpSource(signUpcode, signUpsourcename);
                Logger.WriteDebugMessage("user should be able to Edited the existing data");
                Admin.Click_SignUpSource_Button_Save();
                AddDelay(500);
                Logger.WriteDebugMessage("Data should be saved successfully");
                Admin.SignUpSource_Text_Filter(signUpcode);
                AddDelay(500);
                Logger.WriteDebugMessage("Data Updated Successfully");
            }
        }

        public static void TC_194221()
        {
            if (TestCaseId == Constants.TC_194221)
            {
                //Pre-requisites:
                //1.Log into Admin.
                //2.Navigate to Loyalty Setup
                //3.Click on Transaction Reason
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                Admin.Click_Menu_LoyaltySetup();
                Logger.WriteDebugMessage("Landed on the Loyalty Setup page");
                Admin.Click_SubTab_TermsAndConditions();
                Logger.WriteDebugMessage("Users Landed on Terms and Condition Page");

                //1.Click on Add Terms & Condition button
                Admin.Click_TermsAndCondition_Button_AddTermsAndCondition();
                Logger.WriteDebugMessage("Loyalty terms & condition popup should get display");

                //2.Enter valid data on the fields and click on cancel
                string title = TestData.ExcelData.TestDataReader.ReadData(1, "Title");
                string description = TestData.ExcelData.TestDataReader.ReadData(1, "Description");
                Admin.AddTermsAndCondition(title, description);
                Logger.WriteDebugMessage("user should be able to Enter valid data on the fields");
                Admin.Click_TermsAndCondition_Button_Cancel();

                //3.Click on Add Terms & Condition button
                Admin.Click_TermsAndCondition_Button_AddTermsAndCondition();
                Logger.WriteDebugMessage("Loyalty terms & condition popup should get display");

                //4.Enter valid data on the fields and click on save
                string title1 = MakeUnique(title);
                string description1 = Constants.TermsAndCondition_Description;
                Admin.AddTermsAndCondition(title1, description1);
                Logger.WriteDebugMessage("user should be able to Enter valid data on the fields");
                Admin.Click_TermsAndCondition_Button_Save();
                Logger.WriteDebugMessage("Popup should close and terms & condition should be created");
                AddDelay(5000);

                //5.Searched for terms & condition created
                Admin.TermsAndCondition_Text_Filter(title1);
                Logger.WriteDebugMessage("Terms & condition should be found");

                //6.Click on edit icon 
                Admin.Click_TermsAndCondition_Icon_Edit();
                Logger.WriteDebugMessage("Loyalty terms & condition popup should get display");

                //7.Edited existing data on all the fields and click on save
                string title_edit = MakeUnique(title1);
                string description_edit = Constants.TermsAndCondition_Description;
                Admin.AddTermsAndCondition(title_edit, description_edit);
                Logger.WriteDebugMessage("user should be able to Edit existing data on the fields");
                Admin.Click_TermsAndCondition_Button_Save();
                Logger.WriteDebugMessage("Loyalty terms & condition should be updated successfully");

                //5.Searched for updated terms & condition 
                Helper.ReloadPage();
                AddDelay(500);
                Admin.Click_SubTab_TermsAndConditions();
                Admin.TermsAndCondition_Text_Filter(title_edit);
                Logger.WriteDebugMessage("Terms & condition should be found");

                //6.Click on remove icon
                PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_TermsAndCondition_Icon_Delete).Click();
                Logger.WriteDebugMessage("Confirmation message should be displayed");
                VerifyTextOnPage("Are you sure you want to remove this term/condition?");
                Logger.WriteDebugMessage("Confirmation message should be displayed");

                //7.Click on No
                Admin.Click_TermsAndCondition_Button_No();
                Logger.WriteDebugMessage("Terms & condition should not be removed");

                //8.Click on remove icon 
                PageAction.Find_ElementXPath(ObjectRepository.Admin_LoyaltySetUp_TermsAndCondition_Icon_Delete).Click();
                VerifyTextOnPage("Are you sure you want to remove this term/condition?");
                Logger.WriteDebugMessage("Confirmation message should be displayed");

                //9.Click on yes
                Admin.Click_TermsAndCondition_Button_Yes();
                Helper.ReloadPage();
                AddDelay(500);
                Admin.Click_SubTab_TermsAndConditions();
                Admin.TermsAndCondition_Text_Filter(title_edit);
                Logger.WriteDebugMessage("Terms & condition should be removed");
            }
        }

        public static void TC_194222()
        {
            if (TestCaseId == Constants.TC_194222)
            {
                //Pre-requisites:
                //1.Log into Admin.
                //2.Navigate to Loyalty Setup
                //3.Click on Offers
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("User landed on home page");
                AddDelay(1500);
                string Title = TestData.ExcelData.TestDataReader.ReadData(1, "Title");
                string PromotionCode = TestData.ExcelData.TestDataReader.ReadData(1, "PromotionCode");
                string ButtonText = TestData.ExcelData.TestDataReader.ReadData(1, "ButtonText");
                string updatedTitle = TestData.ExcelData.TestDataReader.ReadData(1, "UpdateTitle");


                Admin.Click_Menu_LoyaltySetup();
                AddDelay(1500);
                Admin.Click_SubTab_Offers();
                Logger.WriteDebugMessage("user landed on offer list screen");

                //1.Click on Add Offer
                Admin.Click_LoyaltySetUp_Offers_Button_AddOffers();
                Logger.WriteDebugMessage("Offer editor page should be displayed");

                //2.Enter valid data on all the fields and click on add another promotion
                //3.Enter valid data on all the fields of setup promo popup and click on cancel
                string title = MakeUnique(Title);
                string visibilityStartDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                string visibilityEndDate = DateTime.Now.AddDays(2).ToString("MM/dd/yyyy");
                Queries.GetMemberLevel(data, 2);
                string level = data.Membershiplevel;
                Queries.IdentifyHotel(data);
                string hotel = data.PropertyName;
                string promotionDescription = MakeUnique("Promotion");
                Admin.AddORUpdateOffers(title, visibilityStartDate, visibilityEndDate, level, visibilityStartDate, visibilityEndDate, "Test");
                Admin.UploadImage(Constants.ImagePath);
                Admin.AddPromotion(PromotionCode, ButtonText, hotel, promotionDescription, ProjectName);
                Admin.Click_LoyaltySetUp_Offers_Button_CancelPromotion();
                Logger.WriteDebugMessage("Setup promo popup should close and promotion not added");

                //4.Again click on add another promotion 
                //5.Enter valid data on all the fields and click on save 
                Admin.AddPromotion(PromotionCode, ButtonText, hotel, promotionDescription, ProjectName);
                Admin.Click_LoyaltySetUp_Offers_Button_SavePromotion();
                Logger.WriteDebugMessage("Confirmation message should be displayed - 'Saving promotion will also save the offer.Are you sure you want to save ?? ''");

                //6.Click on No
                Admin.Click_LoyaltySetUp_Offers_Button_SavePromotionCancel();
                Logger.WriteDebugMessage("Promotion and offer should not be saved and setup promo popup should be displayed");

                //7.Then, click on save button of the Setup Promo popup
                Admin.Click_LoyaltySetUp_Offers_Button_SavePromotion();
                Logger.WriteDebugMessage("Confirmation message should be displayed - 'Saving promotion will also save the offer.Are you sure you want to save ?? '");

                //8.Click on Yes
                Admin.Click_LoyaltySetUp_Offers_Button_ConfirmPromotion();
                Logger.WriteDebugMessage("Promotion should be added successfully​");

                //9.Click on Save
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                Logger.WriteDebugMessage("Offer should be added successfully");

                //9.Searched for offer created
                Admin.LoyaltySetUp_Offers_Text_Filter(title);
                AddDelay(5000);
                Logger.WriteDebugMessage("Offer should be found");

                //10.Click on edit icon
                Admin.Click_LoyaltySetUp_Offers_Icon_Edit();
                Logger.WriteDebugMessage("Offer editor popup should be displayed");

                //11.Edited existing data on all the fields and click on save
                //12.Edited offer end date to past data and click on save
                string titleUpdated = MakeUnique(updatedTitle);
                string visibilityStartDatePast = DateTime.Now.AddDays(-1).ToString("MM/dd/yyyy");
                string visibilityEndDatePast = DateTime.Now.AddDays(-2).ToString("MM/dd/yyyy");
                Queries.GetMemberLevel(data, 2);
                Admin.AddORUpdateOffers(titleUpdated, visibilityStartDatePast, visibilityEndDatePast, data.Membershiplevel, visibilityStartDate, visibilityEndDate, "Test");
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
                Logger.WriteDebugMessage("Offer should be updated successfully");

                //13.Searched for updated offer
                Admin.LoyaltySetUp_Offers_Text_Filter(titleUpdated);
                AddDelay(5000);
                Logger.WriteDebugMessage("Offer should be found");
            }
        }

        public static void TC_194231()
        {
            if (TestCaseId == Constants.TC_194231)
                {
                    string Filter, EmailName, Subject;
                    //Pre-requisites:
                    //1.Log into Admin.
                    //2.Navigate to Email Setup
                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    Admin.Click_Menu_EmailSetuUp();
                    AddDelay(10000);
                    Logger.WriteDebugMessage("Landed on the Email Setup page");

                    //1.Click on edit icon
                    Filter = TestData.ExcelData.TestDataReader.ReadData(1, "Filter");
                    Admin.EmailSetUp_Text_Filter(Filter);
                    AddDelay(2500);

                    Admin.Click_EmailSetUp_Icon_Edit();
                    Logger.WriteDebugMessage("Email setup page should be displayed");

                    //2.Edited existing data on the fields and click on cancel
                    string emailName = Helper.Getdata(PageObject_Admin.Admin_EmailSetUp_Text_EmailName());
                    string emailSubject = Helper.Getdata(PageObject_Admin.Admin_EmailSetUp_Text_EmailSubject());

                    EmailName = TestData.ExcelData.TestDataReader.ReadData(1, "EmailName");
                    Subject = TestData.ExcelData.TestDataReader.ReadData(1, "Subject");
                    Admin.AddEmailSetUp(EmailName, Subject);
                    Admin.Click_EmailSetUp_Button_Cancel();
                    Admin.EmailSetUp_Text_Filter(EmailName);
                    VerifyTextOnPage("No matching records found");
                    AddDelay(2500);
                    Logger.WriteDebugMessage("Emails setup page should close and email should not be updated");

                    //3.Click on edit icon
                    Admin.EmailSetUp_Text_Filter(Filter);
                    AddDelay(2500);
                    Admin.Click_EmailSetUp_Icon_Edit();
                    Logger.WriteDebugMessage("Email setup page should be displayed");

                    //4.Edited existing data on the fields and click on save
                    Admin.AddEmailSetUp(EmailName, Subject);
                    if (ProjectName.Equals("MyPlace"))
                        Admin.EmailSetUp_Text_EmailContent("Test email welcome content");
                    Admin.Click_EmailSetUp_Button_Save();
                    VerifyTextOnPage("Save Successfull");
                    Logger.WriteDebugMessage("Emails setup popup should close and email should be updated");

                    //5.Revert back all changes made at step 4
                    Admin.EmailSetUp_Text_Filter(Filter);
                    AddDelay(2500);
                    Admin.Click_EmailSetUp_Icon_Edit();
                    Admin.AddEmailSetUp(emailName, emailSubject);
                    Admin.Click_EmailSetUp_Button_Save();
                    Logger.WriteDebugMessage("Email data should be reverted successfully");
            }            
        }

        public static void TC_194235()
        {
            if (TestCaseId == Constants.TC_194235)
            {
                Users data = new Users();

                //Pre-requisites:
                //1.Log into Admin.
                //2.Navigate to Email Setup
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                Admin.Click_Menu_ManualMerge();
                Logger.WriteDebugMessage("Landed on the Manual Merge page");

                //1.Search active member from search member tab of the manual merge
                Queries.GetDataPerStatus_DCustomer("Active", 1, data);
                string email1 = data.eMail;
                Queries.GetDataPerStatus_DCustomer("Active", 1, data, email1);
                string email2 = data.eMail;
                Admin.ManualMerge_Text_Email(email1);
                Admin.Click_ManualMerge_Button_SearchMember();
                AddDelay(5000);
                Logger.LogTestData(TestPlanId, TestCaseId, "1st Active Email", email1);
                Logger.LogTestData(TestPlanId, TestCaseId, "2nd Active Email", email2, true);
                //2.Select more than 1 active member from the member result
                Admin.Click_ManualMerge_Icon_Select1();
                Admin.Click_ManualMerge_Button_ClearSearch();
                AddDelay(2500);
                Admin.ManualMerge_Text_Email(email2);
                Admin.Click_ManualMerge_Button_SearchMember();
                AddDelay(5000);
                Admin.Click_ManualMerge_Icon_Select1();
                Logger.WriteDebugMessage("ReviewReview button should be displayed and manual merge tab should be activated");

                //3.Click on review button
                Admin.Click_ManualMerge_Button_Review();
                Logger.WriteDebugMessage("Member information should be displayed of selected member with account winner radio button");

                //4.Select any one account for account winner member

                Admin.Click_ManualMerge_RadioButton_AccountWinner1();

                if (!(PageObject_Admin.Admin_ManualMerge_RadioButton_AccountWinner1().Selected))
                {
                    Assert.Fail("Member information of account winner is NOT highlighted");
                }
                else
                {
                    Logger.WriteDebugMessage("Member information of account winner should be highlighted");
                }


                //5.Click on cancel 
                Admin.Click_ManualMerge_Button_Cancel();
                VerifyTextOnPageAndHighLight("Search Member");
                Logger.WriteDebugMessage("Selected members should not be merged and user landed on the search member page");

                //6.Repeat steps 1 to 4
                Admin.ManualMerge_Text_Email(email1);
                Admin.Click_ManualMerge_Button_SearchMember();
                AddDelay(5000);
                Admin.Click_ManualMerge_Icon_Select1();
                Admin.Click_ManualMerge_Button_ClearSearch();
                AddDelay(2500);
                Admin.ManualMerge_Text_Email(email2);
                Admin.Click_ManualMerge_Button_SearchMember();
                AddDelay(5000);
                Admin.Click_ManualMerge_Icon_Select1();
                Admin.Click_ManualMerge_Button_Review();
                Admin.Click_ManualMerge_RadioButton_AccountWinner1();
                Logger.WriteDebugMessage("Member information of account winner should be highlighted");

                //7.Click on merge
                Admin.Click_ManualMerge_Button_Merge();
                Logger.WriteDebugMessage("Member merge review page should be displayed");

                //8.Validate information of merge accounts which is displayed under the account winner                       
                Queries.ReturnProfileData(email1, data);
                VerifyTextOnPageAndHighLight(data.firstName);
                VerifyTextOnPageAndHighLight(data.lastName);
                VerifyTextOnPageAndHighLight(data.Membership);
                Logger.WriteDebugMessage("All data should match successfully");

                //9.Click on Back
                Admin.Click_ManualMerge_Button_Back();
                Logger.WriteDebugMessage("User landed on the member merge page");

                //10.Click on merge button of the member merge page
                Admin.Click_ManualMerge_Button_Merge();
                Logger.WriteDebugMessage("Member merge review page should be displayed");

                //11.Validate information of merge accounts which is displayed under the account winner              
                Queries.ReturnProfileData(email1, data);
                VerifyTextOnPageAndHighLight(data.firstName);
                VerifyTextOnPageAndHighLight(data.lastName);
                VerifyTextOnPageAndHighLight(data.Membership);
                Logger.WriteDebugMessage("All data should match successfully");

                //12.Click on merge
                Admin.Click_ManualMergeReview_Button_Merge();
                VerifyTextOnPageAndHighLight("Once confirmed this merge cannot be undone. Please confirm to continue.");
                Logger.WriteDebugMessage("Member accounts should be merged");
                Admin.Click_ManualMerge_Button_Confirm();
                Logger.WriteDebugMessage("Member merged successfully");
            }
        }

        public static void TC_194240()
        {
            if (TestCaseId == Constants.TC_194240)
            {
                Users data = new Users();

                //Pre-requisites:
                //1.Log into Admin.
                //2.Navigate to Email Setup
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                Admin.Click_Menu_ManualMerge();
                Logger.WriteDebugMessage("Landed on the Manual Merge page");

                //1.Search active member from search member tab of the manual merge
                Queries.GetDataPerStatus_DCustomer("InActive", 1, data);
                string email1 = data.eMail;
                string id = data.ID;
                Queries.GetDataPerStatus_DCustomer("InActive", 1, data, email1);
                //Queries.GetNonActiveUser(data);
                string email2 = data.eMail;
                Admin.ManualMerge_Text_Email(email1);
                Admin.Click_ManualMerge_Button_SearchMember();
                AddDelay(5000);
                Logger.LogTestData(TestPlanId, TestCaseId, "Inactive Email 1", email1);
                Logger.LogTestData(TestPlanId, TestCaseId, "Inactive Email 2", email2, true);
                //2.Select more than 1 active member from the member result
                Admin.Click_ManualMerge_Icon_Select1(id);
                Admin.Click_ManualMerge_Button_ClearSearch();
                AddDelay(2500);
                Admin.ManualMerge_Text_Email(email2);
                Admin.Click_ManualMerge_Button_SearchMember();
                AddDelay(5000);
                Admin.Click_ManualMerge_Icon_Select1();
                Logger.WriteDebugMessage("ReviewReview button should be displayed and manual merge tab should be activated");

                //3.Click on review button
                Admin.Click_ManualMerge_Button_Review();
                Logger.WriteDebugMessage("Member information should be displayed of selected member with account winner radio button");

                //4.Select any one account for account winner member

                Admin.Click_ManualMerge_RadioButton_AccountWinner1();

                if (!(PageObject_Admin.Admin_ManualMerge_RadioButton_AccountWinner1().Selected))
                {
                    Assert.Fail("Member information of account winner is NOT highlighted");
                }
                else
                {
                    Logger.WriteDebugMessage("Member information of account winner should be highlighted");
                }


                //5.Click on cancel 
                Admin.Click_ManualMerge_Button_Cancel();
                VerifyTextOnPageAndHighLight("Search Member");
                Logger.WriteDebugMessage("Selected members should not be merged and user landed on the search member page");

                //6.Repeat steps 1 to 4
                Admin.ManualMerge_Text_Email(email1);
                Admin.Click_ManualMerge_Button_SearchMember();
                AddDelay(5000);
                Admin.Click_ManualMerge_Icon_Select1(id);
                Admin.Click_ManualMerge_Button_ClearSearch();
                AddDelay(2500);
                Admin.ManualMerge_Text_Email(email2);
                Admin.Click_ManualMerge_Button_SearchMember();
                AddDelay(5000);
                Admin.Click_ManualMerge_Icon_Select1();
                Admin.Click_ManualMerge_Button_Review();
                Admin.Click_ManualMerge_RadioButton_AccountWinner1();
                Logger.WriteDebugMessage("Member information of account winner should be highlighted");

                //7.Click on merge
                Admin.Click_ManualMerge_Button_Merge();
                Logger.WriteDebugMessage("Member merge review page should be displayed");

                //8.Validate information of merge accounts which is displayed under the account winner                 
                Helper.PageDown();
                Queries.ReturnProfileData(email1, data);
                VerifyTextOnPageAndHighLight(data.firstName);
                VerifyTextOnPageAndHighLight(data.lastName);
                VerifyTextOnPageAndHighLight(data.Membership);
                Logger.WriteDebugMessage("All data should match successfully");

                //9.Click on Back
                Admin.Click_ManualMerge_Button_Back();
                Logger.WriteDebugMessage("User landed on the member merge page");

                //10.Click on merge button of the member merge page
                Admin.Click_ManualMerge_Button_Merge();
                Logger.WriteDebugMessage("Member merge review page should be displayed");

                //11.Validate information of merge accounts which is displayed under the account winner                 
                Helper.PageDown();
                Queries.ReturnProfileData(email1, data);
                VerifyTextOnPage(data.firstName);
                VerifyTextOnPage(data.lastName);
                VerifyTextOnPage(data.Membership);
                Logger.WriteDebugMessage("All data should match successfully");

                //12.Click on merge
                Admin.Click_ManualMergeReview_Button_Merge();
                VerifyTextOnPageAndHighLight("Once confirmed this merge cannot be undone. Please confirm to continue.");
                Logger.WriteDebugMessage("Member accounts should be merged");
                Admin.Click_ManualMerge_Button_Confirm();
                Logger.WriteDebugMessage("Member merged successfully");
            }
        }

        public static void TC_194242()
        {

             if (TestCaseId == Constants.TC_194242)
                {
                    //Pre-requisites:
                    Users data = new Users();
                    //1.Log into Admin.
                    //2.Navigate to Email Setup
                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    Admin.Click_Menu_Users();
                    AddDelay(2500);
                    Logger.WriteDebugMessage("Landed on the Users page");

                    //1.Click on Add users button
                    Admin.Click_Users_Button_AddUsers();
                    Logger.WriteDebugMessage("User setup popup should be displayed");

                    //2.Enter valid data on all the fields and click on save
                    string userLogin = TestData.ExcelData.TestDataReader.ReadData(1, "UserLogin");
                    string UserFirstname = TestData.ExcelData.TestDataReader.ReadData(1, "UserFirstname");
                    string UserLastname = TestData.ExcelData.TestDataReader.ReadData(1, "UserLastname");
                    string UserTitle = TestData.ExcelData.TestDataReader.ReadData(1, "UserTitle");
                    string UserPermission = TestData.ExcelData.TestDataReader.ReadData(1, "UserPermission");
                    string email = MakeCatchAllUnique(userLogin);
                    Queries.IdentifyHotel(data);
                    string Propertyname = data.PropertyName;
                    Admin.AddUsers(UserFirstname, UserLastname, UserTitle, UserPermission, email, Propertyname);
                    Logger.WriteDebugMessage("User should be able to entre valid data on all the fields");
                    Logger.LogTestData(TestPlanId, TestCaseId, "User Login", userLogin);
                    Logger.LogTestData(TestPlanId, TestCaseId, "User First Name", UserFirstname);
                    Logger.LogTestData(TestPlanId, TestCaseId, "User Last Name", UserLastname);
                    Logger.LogTestData(TestPlanId, TestCaseId, "User Title", UserTitle);
                    Logger.LogTestData(TestPlanId, TestCaseId, "User Permission", UserPermission);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Email", email, true);
                    Admin.Click_Users_Button_Save();
                    Admin.Users_Text_Search(email);
                    Logger.WriteDebugMessage("User should be created successfully");

                    //3.Go to catchall and login with valid credentials                
                    Helper.OpenNewTab();
                    Hotmail.NavigateToOutLookLogin();                
                    Hotmail.SearchEmailAndOpenLatestEmail(email + " Password", "Topresults");
                    Logger.WriteDebugMessage("Catchall mailbox should be opened");

                    //4.Check the user invite email
                    VerifyTextOnPageAndHighLight(email);
                    Logger.WriteDebugMessage("Email should be received");
             }            

        }

        public static void TC_141476()
        {
            if (TestCaseId == Constants.TC_141476)
                {
                    Users data = new Users();
                    string PastExpMonth = TestData.ExcelData.TestDataReader.ReadData(1, "PastExpMonth");
                    string PastExpDay = TestData.ExcelData.TestDataReader.ReadData(1, "PastExpDay");
                    string PastExpYear = TestData.ExcelData.TestDataReader.ReadData(1, "PastExpYear");
                    string FutureExpMonth = TestData.ExcelData.TestDataReader.ReadData(1, "FutureExpMonth");
                    string FutureExpday = TestData.ExcelData.TestDataReader.ReadData(1, "FutureExpDay");
                    string FutureExpYear = TestData.ExcelData.TestDataReader.ReadData(1, "FutureExpYear");
                    string PresentExpYear = TestData.ExcelData.TestDataReader.ReadData(1, "PresentExpYear");
                    string AwardSts = TestData.ExcelData.TestDataReader.ReadData(1, "AwardSts");

                    Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                    Logger.WriteDebugMessage("Landed on Admin Login Page");
                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully.");
                    Queries.GetMemberwithNonEgiftAward(data, AwardSts);
                    Admin.EnterMemberNumber(data.MemberShipId);
                    Logger.WriteDebugMessage("Member Ship Id is entered");
                    Admin.Click_Button_MemberSearch();
                    AddDelay(10000);
                    Logger.WriteDebugMessage("Member Result found on the page");
                    Admin.Click_Icon_View(ProjectName);
                    AddDelay(15000);
                    Logger.WriteDebugMessage("Landed on member Information page");
                    //Click on Member Award
                    Admin.Click_Tab_MemberAwards();
                    Logger.WriteDebugMessage("Admin Award Page Should be Displayed");
                    // Filter the award
                    Admin.MemberAwards_Text_Filter(data.VoucherNumber);
                    Logger.WriteDebugMessage(" Award got filtered");
                    //2. Click on Exp date for any Perk
                    Admin.Click_ExpirationDate();
                    Logger.WriteDebugMessage("Expiration Date' option should be displayed ");

                    // Commenting below code as User is not able to update the Previous expiration date
                    //3. Try to select Exp. date after Issue date in Far Future from 'Select Expiration Date' option and click on right symbol icon
                    //Admin.Dropdown_ExpMonth(PastExpMonth);
                    //Admin.Dropdown_ExpDay(PastExpMonth);
                    //Admin.Dropdown_ExpYear(PastExpYear);
                    //Logger.WriteDebugMessage("Try to select Exp. date after Issue date in Far Future from 'Select Expiration Date' option and click on right symbol icon");
                    //Admin.Click_ExpirationDateSubmit();
                    //Helper.ValitionMessage(Constants.PastDateExpirationValidationMessage);
                    //Logger.WriteDebugMessage("Past expiration date should not be selected");

                    //4. Select valid Exp. date in future and click on right symbol icon.
                    Admin.Dropdown_ExpMonth(FutureExpMonth);
                    Admin.Dropdown_ExpDay(FutureExpday);
                    Admin.Dropdown_ExpYear(FutureExpYear);
                    Logger.WriteDebugMessage("User should  be allowed to select Exp date in far future ");
                    Admin.Click_ExpirationDateSubmit();
                    Logger.WriteDebugMessage("Exp. date should get saved successfully");
                    Helper.AddDelay(2000);
                    //////5. Verify that user is able to select Issued status for an Perk whose Expiry date is in Future
                    for (int i = 1; i <= 3; i++)
                    {

                        string AwardStatus = TestData.ExcelData.TestDataReader.ReadData(i, "AwardStatus");
                        if (AwardStatus.Equals("Expired"))
                        {
                            Admin.Click_MemberAwardStatus();
                            Helper.AddDelay(2000);
                            Admin.Dropdown_AdminMemberStatus("Issued");
                            Admin.Click_ExpirationDateSubmit();
                        }
                        Admin.Click_MemberAwardStatus();
                        if (!(IsElementPresent(By.XPath("//table[@id='perksMember001']/tbody/tr[@class='odd']/td[6]/a"))))
                        {
                            Admin.Click_MemberAwardStatus();
                        }
                        Admin.Dropdown_AdminMemberStatus(AwardStatus);
                        Logger.WriteDebugMessage("User should be able to select Status" + AwardStatus);
                        //ElementClick(Driver.FindElement(By.XPath("(//button[@type='submit' and @class='btn btn-primary btn-sm editable-submit'])[2]")));
                        Admin.Click_ExpirationDateSubmit();
                        if (AwardStatus.Equals("Issued"))
                        {
                            Admin.Click_AdminSendResend();
                            Logger.WriteDebugMessage("User should be able to select Sent Via Email Status");
                            Admin.click_ResendAwardEmail_Close();
                        }
            }
                    Logger.WriteDebugMessage("Updated Status for Award");
            }
        }
        public static void TC_222075()
        {
            try
            {
                if (TestCaseId == Constants.TC_222075)
                {
                    //Pre-requisites:
                    Users data = new Users();
                    //Log into Admin.
                    Logger.WriteDebugMessage("Loanded on Admin Login Page.");
                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    Admin.Click_Menu_Users();
                    Logger.WriteDebugMessage("Landed on the Users page");

                    //1.Click on Add users button
                    Admin.Click_Users_Button_AddUsers();
                    Logger.WriteDebugMessage("User setup popup should be displayed");

                    //2.Enter valid data on all the fields and click on save
                    string userLogin = TestData.ExcelData.TestDataReader.ReadData(1, "UserUserLogin");
                    string UserFirstname = TestData.ExcelData.TestDataReader.ReadData(1, "UserFirstname");
                    string UserLastname = TestData.ExcelData.TestDataReader.ReadData(1, "UserLastname");
                    string UserTitle = TestData.ExcelData.TestDataReader.ReadData(1, "UserTitle");
                    string UserPermission = TestData.ExcelData.TestDataReader.ReadData(1, "UserPermission");
                    string email = MakeCatchAllUnique(userLogin);
                    Queries.IdentifyHotel(data);
                    string Propertyname = data.PropertyName;
                    Admin.AddUsers(UserFirstname, UserLastname, UserTitle, UserPermission, email, Propertyname);
                    Logger.WriteDebugMessage("All the Details are Entered Succesfully");
                    Admin.Click_Icon_Button_Close();
                    Logger.WriteDebugMessage("User landed on User table display page");
                    Admin.Click_Users_Button_AddUsers();
                    Logger.WriteDebugMessage("Add User Popup is displayed");
                    Admin.AddUsers(UserFirstname, UserLastname, UserTitle, UserPermission, email, Propertyname);
                    Logger.LogTestData(TestPlanId, TestCaseId, "User Login", userLogin);
                    Logger.LogTestData(TestPlanId, TestCaseId, "User First Name", UserFirstname);
                    Logger.LogTestData(TestPlanId, TestCaseId, "User Last Name", UserLastname);
                    Logger.LogTestData(TestPlanId, TestCaseId, "User Title", UserTitle);
                    Logger.LogTestData(TestPlanId, TestCaseId, "User Permission", UserPermission);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Email", email, true);
                    Logger.WriteDebugMessage("All the Details are Entered Succesfully");

                    //6 to verify password is auto generated
                    string value = PageObject_Admin.Admin_Users_Text_Password().GetAttribute("disabled");
                    if (value.Equals("true"))
                        Logger.WriteDebugMessage("Password should be auto generated in the  creation process");
                    else
                        Assert.Fail("Value is Editable");

                    //7 click save
                    Admin.Click_Users_Button_Save();
                    Logger.WriteDebugMessage("User added succefully ");
                    Admin.Users_Text_Search(email);
                    VerifyTextOnPageAndHighLight(email);
                    Logger.WriteDebugMessage("User should be created successfully");

                    //Verify the email in catchall and Update Password.
                    Helper.OpenNewTab();
                    Hotmail.NavigateToOutLookLogin();
                    //Email.CatchAll_SearchEmailAndOpenLatestMessage(email); // Searched for the email
                    Hotmail.SearchEmailAndOpenLatestEmail(email, "Topresults");
                    Email.ForgotPasswordEmail_Check();
                    Logger.WriteDebugMessage("Password recovery email should have appeared.");

                    //5. Click on the link to change the password
                    Email.ActivationForgotPassword_CLick(ProjectName);
                    //Helper.ControlToNewWindow();
                    //ControlToNewWindow();
                    //CloseWindow();
                    ControlToNewWindow();

                    Logger.WriteDebugMessage("User should be landed on password reset page");

                    //6.Enter new password in "New Password" and "Confirm new password" field.
                    //7.Click "Reset Password.
                    ForgotPassword.AdminForgotPassword(ProjectDetails.CommonAdminPassword, Constants.ForgotPassword_PassRecoverySuccess);
                    Logger.WriteDebugMessage("Password Updated succesfully");

                    //Login With Newly Created data
                    AdminLoginCredentials(email, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Login succesfully");

                }
            } catch (Exception e)
            { 
            }

        }

        public static void TC_222092()
        {
            if (TestCaseId == Constants.TC_222092)
                {
                    Logger.WriteDebugMessage("User landed on login page");

                    //Click on Forgot password link
                    Admin.ForgotPassword_LinkText();
                    if (Driver.Url.Contains("PasswordRecovery"))
                    {
                        Logger.WriteDebugMessage("Landed on the Password Recovery page.");
                    }
                    else
                    {
                        Assert.Fail("Does not landed on Admin Forgot password page");
                    }

                    //Enter the wrong Email
                    string invalidEmail = TestData.ExcelData.TestDataReader.ReadData(1, "InvalidEmail").Trim();
                    string invalidPassword = TestData.ExcelData.TestDataReader.ReadData(1, "InvalidPassword").Trim();
                    Admin.UpdateEmail1(invalidEmail);
                    Logger.WriteDebugMessage("Invalid Email address error message is displayed");

                    //Enter a registered email as click on submit
                    string adminEmail = TestData.ExcelData.TestDataReader.ReadData(1, "AdminEmail").Trim();
                    Logger.LogTestData(TestPlanId, TestCaseId, "InValid Email", invalidEmail);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Invalid Pasword", invalidPassword);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Admin Email", adminEmail, true);

                    Admin.UpdateEmail1(adminEmail);
                    Logger.WriteDebugMessage("Confirmation msg regarding  password reset is sent  to  entered email address ");

                    //Verify the application triggered forget password email and email is available in catchall
                    //Logged into Hotmail Account
                    Email.LogIntoCatchAll();
                    //Searched for the email
                    //Email.CatchAll_SearchEmailAndOpenLatestMessage(adminEmail);
                    Time.AddDelay(10000);
                    Helper.ReloadPage();
                    Hotmail.CheckOutLook();
                    //Email.CatchAll_SearchEmailAndOpenLatestMessage(adminEmail);
                    Hotmail.SearchEmail(adminEmail);                
                    try
                    {
                    if (IsElementPresent(By.XPath("//div[@id='groupHeaderAll results']/parent::div/div[2]")))
                    {
                        ElementWait(Driver.FindElement(By.XPath("//div[@id='groupHeaderAll results']/parent::div/div[2]")), 240);
                        ElementClick(Driver.FindElement(By.XPath("//div[@id='groupHeaderAll results']/parent::div/div[2]")));
                    }
                    else
                    {
                        ElementClick(Driver.FindElement(By.XPath("//div[@class='S2NDX']")));
                    }
                    }
                    catch (NoSuchElementException)
                    {
                        ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][3]")));

                    }
                    catch (Exception)
                    {
                        ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][1]")));

                    }

                    Email.ForgotPasswordEmail_Check();

                    //click on the link to change the password
                    Email.ActivationForgotPassword_CLick(ProjectName);
                    Helper.ControlToNewWindow();
                    Logger.WriteDebugMessage("user landed on password reset page");

                    //Enter Password and Confirm password 
                    Random randomNumber = new Random();
                    string ranumber = String.Concat("Cendyn", randomNumber.Next().ToString(), "$");
                    if (Driver.Url.Contains("PasswordRecoveryConfirm"))
                    {
                        Logger.WriteDebugMessage("Landed on Reset Password Page.");
                        Admin.ResetPassword(ranumber);
                        Logger.WriteDebugMessage("Message confirming that password fields are not matching should display");
                    }

                    //Enter wrong Username and password
                    string invalidMessage = TestData.ExcelData.TestDataReader.ReadData(1, "InvalidMessage").Trim();
                    AdminLoginCredentials(invalidEmail, invalidPassword);
                    VerifyTextOnPageAndHighLight(invalidMessage);
                    Logger.WriteDebugMessage("Login with invalid credentials");

                    //Enter  correct user name and password
                    AdminLoginCredentials(adminEmail, ranumber);
                    Logger.WriteDebugMessage("Login with valid credentials");
                    string title = Driver.Title;
                    if (title.Contains("Dashboard"))
                    {
                        Logger.WriteDebugMessage("Login Successfully");
                    }
                    else
                    {
                        Logger.WriteDebugMessage("Invalid login");
                    }
            }            
        }
        public static void TC_209620()
        {
            Logger.WriteDebugMessage("Landed on Admin Login page");

                //Pre-requisites
                Users data = new Users();
                string username, invalidpassword, IncorrectPasswordError;
                // Login to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Login successful with valid data");

                //Navigate to Users tab ans identify the Admin lockout Attempt

                Admin.Click_Menu_Users();
                Logger.WriteDebugMessage("Landed on Users tab");
                Admin.Click_Menu_UsersSetting();
                Logger.WriteDebugMessage("Landed on Users setting tab");
                string admin_lockout_attempt_errormessage = TestData.ExcelData.TestDataReader.ReadData(1, "AdminLockoutAttempt").Trim();
                VerifyTextOnPageAndHighLight(admin_lockout_attempt_errormessage);
                //verify the Admin Lock counter in database
                Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
                Queries.GetAdminLockOutAttempt(data);
                int lockcounter = Int16.Parse(data.Configurationvalue);
                Logger.LogTestData(TestPlanId, TestCaseId, "Lock Counter", lockcounter.ToString(), true);
                //Login to admin with Invalid Password
                //username = TestData.ExcelData.TestDataReader.ReadData(1, "Username").Trim();
                Queries.GetActiveAdminMemberEmail(data);
                invalidpassword = TestData.ExcelData.TestDataReader.ReadData(1, "InvalidPassword").Trim();
                IncorrectPasswordError = TestData.ExcelData.TestDataReader.ReadData(1, "IncorrectPasswordError").Trim();
                for (int i = 1; i <= lockcounter; i++)
                {
                    AdminLoginCredentials(data.MemberEmail, invalidpassword);
                    Logger.WriteDebugMessage("Entered invalid username and password :" + i + "time");
                    Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
                }

                //Navigate to catchAll for Reset your password email
                Email.LogIntoCatchAll();
                //Email.CatchAll_SearchEmailAndOpenLatestMessage(data.MemberEmail + " password"); // Searched for the email
                Hotmail.SearchEmailAndOpenLatestEmail(data.MemberEmail + " Password", "Topresults");
                ControlToNewWindow();
                Email.ForgotPasswordEmail_Check();
                Logger.WriteDebugMessage("Password recovery email should have appeared.");

                //Click on the link to change the password
                Email.ActivationForgotPassword_CLick(ProjectName);
                SwitchToSpecificWindow("Reset Password - eLoyalty Admin");

                Logger.WriteDebugMessage("User should be landed on password reset page");

                //Enter new password in "New Password" and "Confirm new password" field.
                //Click "Reset Password.

                Random ranNum = new Random();
                string newpassword = String.Concat("Cendyn", ranNum.Next().ToString());
                ForgotPassword.AdminForgotPassword(newpassword, Constants.ForgotPassword_PassRecoverySuccess);
                Logger.WriteDebugMessage("Password Updated successfully");

                //Login to admin with correctid and Password
                AdminLoginCredentials(data.MemberEmail, newpassword);
                string title = Driver.Title;
                if (title.Contains("Dashboard"))
                {
                    Logger.WriteDebugMessage("Login Successfully");
                }
                else
                {
                    Logger.WriteDebugMessage("Invliad login");
                }
            
        }

        public static void TC_218599()
        {
            if (TestCaseId == Constants.TC_218599)
            {
                //Pre-requisites
                Users data = new Users();
                Random ranNum = new Random();
                string FilePath, Filename, FullPath, Firstname, Lastname, email, DOB, Membershiplevel, ResgistrationDate, RefrealCode, Language, ConfirmPassword, VerficationText, Worksheetname = "eLoyalty Member Template";

                //Log into Admin.
                Logger.WriteDebugMessage("Landed on Admin Login Page.");
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Click on MemberbatchUpload tab
                Admin.Admin_MemberBatchUpload_Tab();
                AddDelay(2500);
                Logger.WriteDebugMessage("Landed on the Member batch upload page");

                //Download the batch Upload Template
                Admin.BatchUpload_DownloadTemplete();
                Logger.WriteDebugMessage("Downloaded the template");

                //Declare the File path and retrieve the latest file
                FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                Filename = Admin.VerifyFileFormate(FilePath);
                FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                //Retrieved the data from Excel
                Firstname = TestData.ExcelData.TestDataReader.ReadData(1, "FirstName").Trim();
                Lastname = TestData.ExcelData.TestDataReader.ReadData(1, "LastName").Trim();
                email = String.Concat("QATest", ranNum.Next().ToString(), "@cendyn17.com");
                DOB = TestData.ExcelData.TestDataReader.ReadData(1, "DOB").Trim();
                Membershiplevel = TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel").Trim();
                ResgistrationDate = TestData.ExcelData.TestDataReader.ReadData(1, "RegistrationDate");
                RefrealCode = TestData.ExcelData.TestDataReader.ReadData(1, "ReferralCode");
                Language = TestData.ExcelData.TestDataReader.ReadData(1, "Language");
                Logger.LogTestData(TestPlanId, TestCaseId, "First Name", Firstname);
                Logger.LogTestData(TestPlanId, TestCaseId, "Last Name", Lastname);
                Logger.LogTestData(TestPlanId, TestCaseId, "DOB", DOB);
                Logger.LogTestData(TestPlanId, TestCaseId, "Membership Level", Membershiplevel);
                Logger.LogTestData(TestPlanId, TestCaseId, "Registration Date", ResgistrationDate);
                Logger.LogTestData(TestPlanId, TestCaseId, "Referal Code", RefrealCode);
                Logger.LogTestData(TestPlanId, TestCaseId, "Language", Language, true);


                //Insert the data into Downloaded excel file
                TestData.ExcelData.ExcelDataReader eat = new TestData.ExcelData.ExcelDataReader(FullPath);
                eat.SetCellData(Worksheetname, "First Name", 2, Firstname);
                eat.SetCellData(Worksheetname, "Last Name", 2, Lastname);
                eat.SetCellData(Worksheetname, "Email", 2, email);
                eat.SetCellData(Worksheetname, "DOB (MM/dd/yyyy)", 2, DOB);
                eat.SetCellData(Worksheetname, "Membership Level", 2, Membershiplevel);
                eat.SetCellData(Worksheetname, "Registration Date (MM/dd/yyyy)", 2, ResgistrationDate);
                eat.SetCellData(Worksheetname, "Referral Code", 2, RefrealCode);
                eat.SetCellData(Worksheetname, "Language", 2, Language);

                //Upload the Updated Excel File
                Admin.BatchUpdate_UploadTemplete();
                Logger.WriteDebugMessage("Upload Dialog is opened");
                Admin.BatchUpload_UploadFile(FullPath);
                Logger.WriteDebugMessage("Batch Registration is completed successfully");

                //Filter the Updated file and verify the updated data
                Admin.VerifyUploadedDetails(Filename);

                VerifyTextOnPageAndHighLight(email);
                Logger.WriteDebugMessage("Uploaded Result is displayed on the Page");

                //Verify the Email in catchall after successful upload the registration file
                Email.LogIntoCatchAll();
                Email.CatchAll_SearchEmailAndOpenLatestMessage(email);
                Logger.WriteDebugMessage("Catchall mailbox should be opened");

                //Click on activation email link
                Email.ActivationEmail_ClickLink(ProjectName);
                Logger.WriteDebugMessage("Activation email link should get clicked");

                //Reset new password and login with valid credentials
                ConfirmPassword = TestData.ExcelData.TestDataReader.ReadData(1, "ConfirmPassword");
                VerficationText = TestData.ExcelData.TestDataReader.ReadData(1, "VerficationText");
                ControlToNewWindow();
                ForgotPassword.ForgotPasswordNew(ConfirmPassword, Constants.ForgotPassword_PassRecoverySuccess, 0);
                LoginCredentials(email, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("User should login with new credentials");
                VerifyTextOnPageAndHighLight(VerficationText);
                Logger.WriteDebugMessage("Verification text should get highlighted");

            }
        }
        public static void TC_218604()
        {
            if (TestCaseId == Constants.TC_218604)
            {
                //Pre-requisites
                Users data = new Users();
                Random ranNum = new Random();
                string FilePath, Filename, FullPath, Firstname, Lastname, Email, DOB, Membershiplevel, Worksheetname = "eLoyalty Member Template";

                //Log into Admin.
                Logger.WriteDebugMessage("Loanded on Admin Login Page.");
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Click on MemberbatchUpload tab
                Admin.MemberBatchUpload_Tab();
                AddDelay(2500);
                Logger.WriteDebugMessage("Landed on the Member batch upload page");

                //Download the batch Upload Template
                Admin.BatchUpload_DownloadTemplete();
                Logger.WriteDebugMessage("Downloaded the template");

                // Declare the File path and retrive the latest file
                FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                Filename = Admin.VerifyFileFormate(FilePath);
                FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                // Retrived the data from Excel
                Firstname = TestData.ExcelData.TestDataReader.ReadData(1, "FirstName").Trim();
                Lastname = TestData.ExcelData.TestDataReader.ReadData(1, "LastName").Trim();
                Email = String.Concat("QATest", ranNum.Next().ToString(), "@cendyn17.com");
                DOB = TestData.ExcelData.TestDataReader.ReadData(1, "DOB").Trim();
                Membershiplevel = TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel").Trim();
                Logger.LogTestData(TestPlanId, TestCaseId, "First Name", Firstname);
                Logger.LogTestData(TestPlanId, TestCaseId, "Last Name", Lastname);
                Logger.LogTestData(TestPlanId, TestCaseId, "DOB", DOB);
                Logger.LogTestData(TestPlanId, TestCaseId, "Membership Level", Membershiplevel, true);


                // Insert the data into Dowlnlated excel file
                TestData.ExcelData.ExcelDataReader eat = new TestData.ExcelData.ExcelDataReader(FullPath);
                eat.SetCellData(Worksheetname, "First Name", 2, Firstname);
                eat.SetCellData(Worksheetname, "Last Name", 2, Lastname);
                eat.SetCellData(Worksheetname, "Email", 2, Email);
                eat.SetCellData(Worksheetname, "DOB (MM/dd/yyyy)", 2, DOB);
                eat.SetCellData(Worksheetname, "Membership Level", 2, Membershiplevel);

                //Upload the Updated Excel File
                Admin.BatchUpdate_UploadTemplete();
                Logger.WriteDebugMessage("Upload Dialog is opened");
                Admin.BatchUpload_UploadFile(FullPath);
                Logger.WriteDebugMessage("Batch Registration is completed succesfully");

                // Filter the Updated file and verify the updated data
                Admin.VerifyUploadedDetails(Filename);
                VerifyTextOnPageAndHighLight(Email);
                Logger.WriteDebugMessage("Uploaded Result is displayed on the Page");
            }
        }

        public static void TC_189006()
        {
            try
            {
                if (TestCaseId == Constants.TC_189006)
                {
                    Users data = new Users();
                    //User has logged in to Guest Loyalty Admin  with valid credentials                                            
                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully.");
                    Queries.GetActiveMemberEmail(data);
                    Admin.EnterEmail(data.MemberEmail);

                    //On Member Search page, search for member
                    Admin.Click_Button_MemberSearch();
                    Logger.WriteDebugMessage("Member should get displayed under Member result table");

                    //Click on view icon to see member information page
                    Admin.Click_Icon_View(ProjectName);
                    Logger.WriteDebugMessage("User should get landed on Member Information page");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Active Email", data.MemberEmail, true);
                    //Click on Activation email
                    Admin.SendActivationEmail();
                    Logger.WriteDebugMessage("Activation email sent succesfully");

                    //Go to catchall.Check for the Activation email
                    Helper.OpenNewTab();
                    Email.LogIntoCatchAll();
                    Email.CatchAll_SearchEmailAndOpenLatestMessage(data.MemberEmail);
                    Driver.Manage().Window.Maximize();
                    Email.ActivationEmail_Check(ProjectName);
                    ControlToNewWindow();
                    CloseWindow();

                    //Click on Welcome email
                    ControlToPreviousWindow();
                    Admin.SendWelcomeEmail();
                    Logger.WriteDebugMessage("Welcome email sent succesfully");

                    //Go to catchall and Check for the Welcome email
                    
                    Helper.OpenNewTab();
                    Hotmail.NavigateToOutLook();
                    Hotmail.CheckActiveWindow();
                    Email.CatchAll_SearchEmailAndOpenLatestMessage(data.MemberEmail);
                    Driver.Manage().Window.Maximize();
                    Email.WelcomeEmail_Check(ProjectName);
                    ControlToNewWindow();
                    CloseWindow();

                    //Create unique Email id
                    Random ranNum = new Random();
                    string uniqueemail = String.Concat("QA", ranNum.Next().ToString(), "@cendyn17.com");
                    //Click on Member login
                    ControlToPreviousWindow();
                    Admin.SendResetLogin(uniqueemail);
                    Logger.WriteDebugMessage("Reset email sent succesfully");

                    //Go to catchall.Check for the Password Recovery email
                    Helper.OpenNewTab();
                    Hotmail.NavigateToOutLook();
                    Hotmail.CheckActiveWindow();
                    Hotmail.SearchEmailAndOpenLatestEmail(uniqueemail + " Password", "Topresults");                   
                    Driver.Manage().Window.Maximize();
                    Email.ForgotPasswordEmail_Check();
                    Logger.WriteDebugMessage("The reset email was received.");

                }
            }catch(Exception e)
            {

            }
        }

        public static void TC_227232()
        {
            if (TestCaseId == Constants.TC_227232)
            {
                //Pre-requisites:
                Users data = new Users();
                string FirstName, LastName, DOB, MembershipLevel, RefrealCode, Language, SheetName, TodayDate, FilePath, LatestFileName, FullPath;

                //Retrieved data
                FirstName = TestData.ExcelData.TestDataReader.ReadData(1, "FirstName");
                LastName = TestData.ExcelData.TestDataReader.ReadData(1, "LastName");
                DOB = TestData.ExcelData.TestDataReader.ReadData(1, "DOB");
                MembershipLevel = TestData.ExcelData.TestDataReader.ReadData(1, "MemberShipLevel");
                RefrealCode = TestData.ExcelData.TestDataReader.ReadData(1, "ReferralCode");
                Language = TestData.ExcelData.TestDataReader.ReadData(1, "Language");
                SheetName = TestData.ExcelData.TestDataReader.ReadData(1, "SheetName");
                TodayDate = DateTime.Now.ToString("MM/dd/yyyy");

                //.Login with Valid Admin Credentials
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                Queries.GetDataAsPerMemberLevel("Member", data);
                Admin.EnterEmail(data.MemberEmail);
                Logger.WriteDebugMessage("Email address is entered");
                Admin.Click_Button_MemberSearch();
                AddDelay(10000);
                Logger.WriteDebugMessage("Member Result found on the page");
                Admin.Click_Icon_View(ProjectName);
                AddDelay(15000);
                VerifyTextOnPageAndHighLight(data.MemberShipId);
                Logger.WriteDebugMessage("Landed on member Information page");
                Logger.LogTestData(TestPlanId, TestCaseId, "First Name", FirstName);
                Logger.LogTestData(TestPlanId, TestCaseId, "Last Name", LastName);
                Logger.LogTestData(TestPlanId, TestCaseId, "DOB", DOB);
                Logger.LogTestData(TestPlanId, TestCaseId, "Membership Level", MembershipLevel);
                Logger.LogTestData(TestPlanId, TestCaseId, "Referal Code", RefrealCode);
                Logger.LogTestData(TestPlanId, TestCaseId, "Language", Language);
                Logger.LogTestData(TestPlanId, TestCaseId, "Sheet Name", SheetName, true);
                //2.Click on 'Update Members'
                Admin.MemberBatchUpload_Tab();
                Logger.WriteDebugMessage("Landed on the Member batch upload page");
                Admin.Click_MemberBatchUpdate();
                //download template
                Admin.BatchUpdate_DownloadTemplete();
                Logger.WriteDebugMessage("Template should get downloaded");
                AddDelay(5000);
                //To write data in excel file
                FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                LatestFileName = Admin.VerifyFileFormate(FilePath);
                FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));
                TestData.ExcelData.ExcelDataReader ex = new TestData.ExcelData.ExcelDataReader(FullPath);
                ex.SetCellData(SheetName, "First Name", 2, FirstName);
                ex.SetCellData(SheetName, "Last Name", 2, LastName);
                ex.SetCellData(SheetName, "DOB (MM/dd/yyyy)", 2, DOB);
                ex.SetCellData(SheetName, "MembershipID", 2, data.MemberShipId);
                ex.SetCellData(SheetName, "Membership Level", 2, MembershipLevel);
                ex.SetCellData(SheetName, "Referral Code", 2, RefrealCode);
                ex.SetCellData(SheetName, "Language", 2, Language);
                Logger.WriteDebugMessage("User should be able to enter all the fields");
                //3.Select File saved recently,  select "Notify Members for Member Level Updates" toggle button and click on Upload
                Admin.BatchUpdate_UpdateTemplete();
                Logger.WriteDebugMessage("User should be able to see file upload Popup");
                Admin.BatchUpdate_UploadFile(FullPath);
                Logger.WriteDebugMessage("Batch Registration is completed successfully");
                //4.Click on 'Refresh' button from Member Batch Updates Log dashboard.
                //5.Identify recently uploaded filerecord in log & Verify the logs generated after successful Upload of the File
                ///6.Click on details
                Admin.VerifyUpdatedDetails(LatestFileName);
                //click on close button on Popup
                Admin.Click_CloseButton_OnMemberBatchUpdateDetailsPopup();


                //7.Navigate to Member Search Tab & search for recently updated member through batch update.
                //8.Click on view.
                Admin.Click_MemberSearchTab();
                Admin.EnterEmail(data.MemberEmail);
                Logger.WriteDebugMessage("Email address is entered");
                Admin.Click_Button_MemberSearch();
                AddDelay(10000);
                Logger.WriteDebugMessage("Member Result found on the page");
                Admin.Click_Icon_View(ProjectName);
                AddDelay(15000);
                Logger.WriteDebugMessage("Landed on member Information page");

                //9.Verify updated fields are reflecting correctly on member information 
                VerifyTextOnPageAndHighLight(MembershipLevel);
                VerifyTextOnPageAndHighLight(data.MemberShipId);
                VerifyTextOnPageAndHighLight(FirstName);
                VerifyTextOnPageAndHighLight(LastName);
                Logger.WriteDebugMessage("Updated data should reflect in Admin Member Information");
                //10.Navigate to Admin Updates Tab
                Admin.Click_Tab_AdminUpdates();
                Helper.PageDown();
                VerifyTextOnPageAndHighLight("Update FirstName");
                VerifyTextOnPageAndHighLight("Update LastName");
                VerifyTextOnPageAndHighLight("Update DOB");
                VerifyTextOnPageAndHighLight("Update Referral Code");
                VerifyTextOnPageAndHighLight("Update Level");
                Logger.WriteDebugMessage("Admin update log should get generated");

                //11.Login to front-end >> Navigate to Profile table
                Admin.Click_MemberInformation_Value_MemberPortal();
                AddDelay(15000);
                ControlToNewWindow();
                Driver.Manage().Window.Maximize();
                Logger.WriteDebugMessage("User landed on guest portal window");
                Navigation.Click_Link_MyProfile(ProjectName);
                AddDelay(5000);
                Logger.WriteDebugMessage("User to land on the Profile page.");
                Helper.PageDown();
                Logger.WriteDebugMessage("Updated data should reflect in Front-end Profile");
            }
        }
        public static void TC_221131()
        {
            if (TestCaseId == Constants.TC_221131)
            {
                //Pre-requisites:
                string firstName, lastName;
                Users activeuser = new Users();

                // Login to Admin with valid Credentials
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Landed on Admin Member Search Page");

                //Search for Active User and Navigate to Member Information Page
                Queries.GetActiveMemberEmail(activeuser);
                Admin.EnterEmail(activeuser.MemberEmail);
                Logger.WriteDebugMessage("Entered active user in email text box");
                Admin.Click_Button_MemberSearch();
                AddDelay(10000);
                Logger.WriteDebugMessage("Member Result found on the page");
                Admin.Click_Icon_View(ProjectName);
                AddDelay(15000);
                Logger.LogTestData(TestPlanId, TestCaseId, "Active Email", activeuser.MemberEmail);
                Logger.WriteDebugMessage("Landed on member information Page");

                //Try Different combination of First Name and last name
                for (int i = 1; i < 8; i++)
                {
                    // Retrieve data from test data file
                    firstName = TestData.ExcelData.TestDataReader.ReadData(i, "FirstName");
                    lastName = TestData.ExcelData.TestDataReader.ReadData(i, "LastName");
                    Logger.LogTestData(TestPlanId, TestCaseId, "First Name" + i, firstName);
                    if (i == 7)
                        Logger.LogTestData(TestPlanId, TestCaseId, "Last Name" + i, lastName, true);
                    else
                        Logger.LogTestData(TestPlanId, TestCaseId, "Last Name" + i, lastName);
                    //Edit First Name and Last Name
                    Admin.EnterFirst_name(firstName);
                    AddDelay(3000);
                    Admin.EnterLast_name(lastName);

                    //verify Entered first name and last name
                    VerifyTextOnPageAndHighLight(firstName);
                    AddDelay(3000);
                    VerifyTextOnPageAndHighLight(lastName);
                    Logger.WriteDebugMessage(firstName + " and " + lastName + " Found on Page");
                    RemoveHighLight(firstName);
                    RemoveHighLight(lastName);

                }
            }
        }
        public static void TC_194749()
        {
            if (TestCaseId == Constants.TC_194749)
                {
                    //Pre-requisites:
                    Users activeUser = new Users();
                    Users inactiveUser = new Users();
                    string Home_Tab, Home_MemberSearch_SubTab, Home_MemberInformation_SubTab, MemberBatchUpload_Tab, BatchRegistration_SubTab, BatchUpdate_SubTab,
                        LoyaltyRule_Tab, LoyaltyAward_Tab, LoyaltyeGifts_Tabs, LoyaltyeSetup_Tab, LoyaltyEmailSetup_Tab, ManualMerge_Tab, SearchMember_SubTab, MemberMerge_SubTab,
                        Users_Tab, Redeem_Tab, ContentManagment_Tab, LoyaltyMapping_Tab, LoyaltyRules_SubTabs, MemberInformation_SubTabs, LoyaltyeGifts_SubTabs, LoyaltyeSetup_SubTabs,
                        Users_SubTabs, LoyaltyMapping_SubTab, Roles_SubTab, UserLog_SubTabs;
                    int delay = 15000;

                    //Retrieved data
                    Home_Tab = TestData.ExcelData.TestDataReader.ReadData(1, "Home_Tab");
                    Home_MemberSearch_SubTab = TestData.ExcelData.TestDataReader.ReadData(1, "Home_MemberSearch_SubTab");
                    Home_MemberInformation_SubTab = TestData.ExcelData.TestDataReader.ReadData(1, "Home_MemberInformation_SubTab");
                    MemberBatchUpload_Tab = TestData.ExcelData.TestDataReader.ReadData(1, "MemberBatchUpload_Tab");
                    BatchRegistration_SubTab = TestData.ExcelData.TestDataReader.ReadData(1, "BatchRegistration_SubTab");
                    BatchUpdate_SubTab = TestData.ExcelData.TestDataReader.ReadData(1, "BatchUpdate_SubTab");
                    LoyaltyRule_Tab = TestData.ExcelData.TestDataReader.ReadData(1, "LoyaltyRule_Tab");
                    LoyaltyAward_Tab = TestData.ExcelData.TestDataReader.ReadData(1, "LoyaltyAward_Tab");
                    LoyaltyeGifts_Tabs = TestData.ExcelData.TestDataReader.ReadData(1, "LoyaltyeGifts_Tabs");
                    LoyaltyeSetup_Tab = TestData.ExcelData.TestDataReader.ReadData(1, "LoyaltyeSetup_Tab");
                    LoyaltyEmailSetup_Tab = TestData.ExcelData.TestDataReader.ReadData(1, "LoyaltyEmailSetup_Tab");
                    ManualMerge_Tab = TestData.ExcelData.TestDataReader.ReadData(1, "ManualMerge_Tab");
                    SearchMember_SubTab = TestData.ExcelData.TestDataReader.ReadData(1, "SearchMember_SubTab");
                    MemberMerge_SubTab = TestData.ExcelData.TestDataReader.ReadData(1, "MemberMerge_SubTab");
                    Users_Tab = TestData.ExcelData.TestDataReader.ReadData(1, "Users_Tab");
                    Redeem_Tab = TestData.ExcelData.TestDataReader.ReadData(1, "Redeem_Tab");
                    ContentManagment_Tab = TestData.ExcelData.TestDataReader.ReadData(1, "ContentManagment_Tab");
                    LoyaltyMapping_Tab = TestData.ExcelData.TestDataReader.ReadData(1, "LoyaltyMapping_Tab");
                    Roles_SubTab = TestData.ExcelData.TestDataReader.ReadData(1, "Roles_SubTab");
                    UserLog_SubTabs = TestData.ExcelData.TestDataReader.ReadData(1, "UserLog_SubTab");

                    //Login with Valid Admin Credentials
                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully");

                    //Verify Home click and validate
                    Admin.Click_Menu_Home();
                    VerifyTextOnPageAndHighLight(Home_Tab);
                    Logger.WriteDebugMessage(Home_Tab + " Element Found on Page");
                    RemoveHighLight(Home_Tab);

                    // Verify Member search click and validate
                    Admin.Click_MemberSearchTab();
                    VerifyTextOnPageAndHighLight(Home_MemberSearch_SubTab);
                    Logger.WriteDebugMessage(Home_MemberSearch_SubTab + " Element Found on Page");
                    RemoveHighLight(Home_MemberSearch_SubTab);

                    // Verify Member Information tab click and validate
                    Queries.GetActiveMemberEmail(activeUser);
                    Admin.EnterEmail(activeUser.MemberEmail);
                    Logger.WriteDebugMessage("Email address is entered");
                    Admin.Click_Button_MemberSearch();
                    AddDelay(delay);
                    Logger.WriteDebugMessage("Member Result found on the page");
                    Admin.Click_Icon_View(ProjectName);
                    AddDelay(delay);
                    Admin.Admin_MemberInformation_Tab();
                    VerifyTextOnPageAndHighLight(Home_MemberInformation_SubTab);
                    Logger.WriteDebugMessage(Home_MemberInformation_SubTab + " Element Found on Page");
                    RemoveHighLight(Home_MemberInformation_SubTab);

                    // Verify Sub-tabs on member Information page
                    for (int i = 1; i <= 6; i++)
                    {
                        MemberInformation_SubTabs = TestData.ExcelData.TestDataReader.ReadData(i, "MemberInformation_SubTabs");
                        Admin.Admin_Subtab_CommonMethod(MemberInformation_SubTabs);
                        AddDelay(delay);
                        ScrollDown();
                        VerifyTextOnPageAndHighLight(MemberInformation_SubTabs);
                        Logger.WriteDebugMessage(MemberInformation_SubTabs + " Element Found on Page");
                        RemoveHighLight(MemberInformation_SubTabs);

                    }

                    //Verify Member Batch Update click and validate
                    Admin.MemberBatchUpload_Tab();
                    VerifyTextOnPageAndHighLight(MemberBatchUpload_Tab);
                    Logger.WriteDebugMessage(MemberBatchUpload_Tab + " Element Found on Page");
                    RemoveHighLight(MemberBatchUpload_Tab);

                    // Verify Member Batch Registration click and validate
                    Admin.Admin_MemberBatchUpload_BtachRegistration_SubTab();
                    VerifyTextOnPageAndHighLight(BatchRegistration_SubTab);
                    Logger.WriteDebugMessage(BatchRegistration_SubTab + " Element Found on Page");
                    RemoveHighLight(BatchRegistration_SubTab);

                    // Verify Member Batch Update click and validate
                    Admin.Click_MemberBatchUpdate();
                    VerifyTextOnPageAndHighLight(BatchUpdate_SubTab);
                    Logger.WriteDebugMessage(BatchUpdate_SubTab + " Element Found on Page");
                    RemoveHighLight(BatchUpdate_SubTab);

                    //Verify Loyalty Rules clicked and validate
                    Admin.Click_Menu_LoyaltyRules();
                    AddDelay(delay);
                    VerifyTextOnPageAndHighLight(LoyaltyRule_Tab);
                    Logger.WriteDebugMessage(LoyaltyRule_Tab + " Element Found on Page");
                    RemoveHighLight(LoyaltyRule_Tab);

                    //Verify sub-tabs on Loyalty Rule Page
                    for (int i = 1; i < 4; i++)
                    {
                        LoyaltyRules_SubTabs = TestData.ExcelData.TestDataReader.ReadData(i, "LoyaltyRules_SubTabs");
                        Admin.Admin_Subtab_CommonMethod(LoyaltyRules_SubTabs);
                        AddDelay(delay);
                        VerifyTextOnPageAndHighLight(LoyaltyRules_SubTabs);
                        Logger.WriteDebugMessage(LoyaltyRules_SubTabs + " Element Found on Page");
                        RemoveHighLight(LoyaltyRules_SubTabs);
                    }

                    //Verify Loyalty award click and validate
                    Admin.Click_Menu_LoyaltyAwards();
                    AddDelay(delay);
                    VerifyTextOnPageAndHighLight(LoyaltyAward_Tab);
                    Logger.WriteDebugMessage(LoyaltyAward_Tab + " Element Found on Page");
                    RemoveHighLight(LoyaltyAward_Tab);

                    //Verify Loyalty eGifts click and validate
                    Admin.Click_LoyaltyeGift();
                    AddDelay(delay);
                    VerifyTextOnPageAndHighLight(LoyaltyeGifts_Tabs);
                    Logger.WriteDebugMessage(LoyaltyeGifts_Tabs + " Element Found on Page");
                    RemoveHighLight(LoyaltyeGifts_Tabs);

                    //Verify sub-tabs on Loyalty EGift Page
                    for (int i = 1; i <= 3; i++)
                    {
                        LoyaltyeGifts_SubTabs = TestData.ExcelData.TestDataReader.ReadData(i, "LoyaltyeGifts_SubTabs");
                        Admin.Admin_Subtab_CommonMethod(LoyaltyeGifts_SubTabs);
                        AddDelay(delay);
                        VerifyTextOnPageAndHighLight(LoyaltyeGifts_SubTabs);
                        Logger.WriteDebugMessage(LoyaltyeGifts_SubTabs + " Element Found on Page");
                        RemoveHighLight(LoyaltyeGifts_SubTabs);
                    }

                    //Verify Loyalty Setup click and validate
                    Admin.Click_Menu_LoyaltySetup();
                    AddDelay(delay);
                    VerifyTextOnPageAndHighLight(LoyaltyeSetup_Tab);
                    Logger.WriteDebugMessage(LoyaltyeSetup_Tab + " Element Found on Page");
                    RemoveHighLight(LoyaltyeSetup_Tab);

                    //Verify sub-tabs on Loyalty Setup Page
                    for (int i = 1; i <= 10; i++)
                    {
                        LoyaltyeSetup_SubTabs = TestData.ExcelData.TestDataReader.ReadData(i, "LoyaltyeSetup_SubTabs");
                        Admin.Admin_Subtab_CommonMethod(LoyaltyeSetup_SubTabs);
                        AddDelay(delay);
                        VerifyTextOnPageAndHighLight(LoyaltyeSetup_SubTabs);
                        Logger.WriteDebugMessage(LoyaltyeSetup_SubTabs + " Element Found on Page");
                        RemoveHighLight(LoyaltyeSetup_SubTabs);
                    }

                    //Verify Email Setup click and validate
                    Admin.Click_Menu_EmailSetuUp();
                    AddDelay(delay);
                    VerifyTextOnPageAndHighLight(LoyaltyEmailSetup_Tab);
                    Logger.WriteDebugMessage(LoyaltyEmailSetup_Tab + " Element Found on Page");
                    RemoveHighLight(LoyaltyEmailSetup_Tab);

                    //Verify Manual Merge click and validate
                    Admin.Click_Menu_ManualMerge();
                    AddDelay(delay);
                    VerifyTextOnPageAndHighLight(ManualMerge_Tab);
                    Logger.WriteDebugMessage(ManualMerge_Tab + " Element Found on Page");
                    RemoveHighLight(ManualMerge_Tab);

                    Queries.GetDataPerStatus_DCustomer("Active", 1, activeUser);
                    Queries.GetDataPerStatus_DCustomer("Inactive", 1, inactiveUser, activeUser.eMail);
                    Admin.Click_ManualMerge_Button_SearchMember();
                    VerifyTextOnPageAndHighLight(SearchMember_SubTab);
                    Admin.ManualMerge_Text_Email(activeUser.eMail);
                    Admin.Click_ManualMerge_Button_SearchMember();
                    Admin.Click_ManualMerge_Icon_Select1();
                    Logger.WriteDebugMessage("First member got Selected");
                    Admin.Click_ManualMerge_Button_ClearSearch();
                    Admin.ManualMerge_Text_Email(inactiveUser.eMail);
                    Admin.Click_ManualMerge_Button_SearchMember();
                    Admin.Click_ManualMerge_Icon_Select1();
                    Logger.WriteDebugMessage("Second member got Selected");
                    Admin.Admin_ManualMerge_MemberMerge_SubTab();
                    VerifyTextOnPageAndHighLight(MemberMerge_SubTab);
                    Logger.WriteDebugMessage(MemberMerge_SubTab + " Element Found on Page");
                    RemoveHighLight(MemberMerge_SubTab);

                    //Verify Users click and validate
                    Admin.Click_Menu_Users();
                    AddDelay(delay);
                    VerifyTextOnPageAndHighLight(Users_Tab);
                    Logger.WriteDebugMessage(Users_Tab + " Element Found on Page");
                    RemoveHighLight(Users_Tab);

                    //Verify sub-tabs on Users Page
                    for (int i = 1; i <= 4; i++)
                    {
                        Users_SubTabs = TestData.ExcelData.TestDataReader.ReadData(i, "Users_SubTabs");
                        Admin.Admin_Subtab_CommonMethod(Users_SubTabs);
                        AddDelay(delay);
                        if (Users_SubTabs.Equals("Roles"))
                        {
                            VerifyTextOnPageAndHighLight(Roles_SubTab);
                            Logger.WriteDebugMessage(Roles_SubTab + " Element Found on Page");
                            RemoveHighLight(Roles_SubTab);
                        }
                        else if (Users_SubTabs.Equals("User Log"))
                        {
                            VerifyTextOnPageAndHighLight(UserLog_SubTabs);
                            Logger.WriteDebugMessage(UserLog_SubTabs + " Element Found on Page");
                            RemoveHighLight(UserLog_SubTabs);
                        }
                        else
                        {
                            VerifyTextOnPageAndHighLight(Users_SubTabs);
                            Logger.WriteDebugMessage(Users_SubTabs + " Element Found on Page");
                            RemoveHighLight(Users_SubTabs);
                        }
                    }

                    //Verify Redeem click and validate
                    Admin.Click_Menu_Redeem();
                    AddDelay(delay);
                    VerifyTextOnPageAndHighLight(Redeem_Tab);
                    Logger.WriteDebugMessage(Redeem_Tab + " Element Found on Page");
                    RemoveHighLight(Redeem_Tab);

                    //Verify Content Management click and validate
                    Admin.Admin_Menu_ContentManagment_Tab();
                    AddDelay(delay);
                    VerifyTextOnPageAndHighLight(ContentManagment_Tab);
                    Logger.WriteDebugMessage(ContentManagment_Tab + " Element Found on Page");
                    RemoveHighLight(ContentManagment_Tab);

                    //Verify loyalty Mapping click and validate
                    Admin.Admin_Menu_LoyaltyMapping_Tab();
                    AddDelay(18000);
                    Helper.WaitTillPageLoadbyXpath("//*[contains(text(),'" + LoyaltyMapping_Tab + "')]", 7);
                    VerifyTextOnPageAndHighLight(LoyaltyMapping_Tab);
                    Logger.WriteDebugMessage(LoyaltyMapping_Tab + " Element Found on Page");
                    RemoveHighLight(LoyaltyMapping_Tab);

                    // Verify Sub-tabs on Loyalty Mapping Page
                    for (int i = 1; i <= 4; i++)
                    {
                        LoyaltyMapping_SubTab = TestData.ExcelData.TestDataReader.ReadData(i, "LoyaltyMapping_SubTab");
                        Admin.Admin_Subtab_CommonMethod(LoyaltyMapping_SubTab);
                        AddDelay(delay);
                        VerifyTextOnPageAndHighLight(LoyaltyMapping_SubTab);
                        Logger.WriteDebugMessage(LoyaltyMapping_SubTab + " Element Found on Page");
                        RemoveHighLight(LoyaltyMapping_SubTab);
                    }
                }
        }
        public static void TC_242619()
        {
            if (TestCaseId == Constants.TC_242619)
            {
                //Pre-requisites:
                string title, description, edited_description, validationMessage, iFrameId;
                Random no = new Random();

                //Retrieved data
                title = TestData.ExcelData.TestDataReader.ReadData(1, "Title") + no.Next().ToString();
                description = TestData.ExcelData.TestDataReader.ReadData(1, "Description");
                edited_description = TestData.ExcelData.TestDataReader.ReadData(1, "Edited_Description");
                validationMessage = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage");
                iFrameId = TestData.ExcelData.TestDataReader.ReadData(1, "iFrameId");

                //Login with Valid Admin Credentials
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in to Admin successfully.");

                //Click on Loyalty Setup tab
                Admin.Click_Menu_LoyaltySetup();
                Logger.WriteDebugMessage("Landed on Loyalty Setup page");

                //Click on Terms and Conditions
                Admin.Click_SubTab_TermsAndConditions();
                Logger.WriteDebugMessage("Landed on Terms And Condition page");

                //Click on Add and Enter details in required field and Click on Save
                Admin.Click_TermsAndCondition_Button_AddTermsAndCondition();
                Logger.WriteDebugMessage("Terms & Condition pop-up gets open");
                Admin.TermsAndCondition_Text_Title(title);
                Admin.Enter_Admin_LoyaltySetUp_TermsAndCondition_Description(description, iFrameId);
                Logger.WriteDebugMessage("Title and Description are entered");
                Admin.Click_TermsAndCondition_Button_Save();
                AddDelay(5000);
                Logger.WriteDebugMessage("Save Successful message should get displayed");

                //Verify the entered term and condition on Page
                Admin.TermsAndCondition_Text_Filter(title);
                VerifyTextOnPageAndHighLight(title);
                Logger.WriteDebugMessage("Title name get displayed on the page");

                //Edit recently added Terms and Condition
                Admin.Click_TermsAndCondition_Icon_Edit();
                Logger.WriteDebugMessage("Edit button get clicked");
                Admin.Enter_Admin_LoyaltySetUp_TermsAndCondition_Description(edited_description, iFrameId);
                Logger.WriteDebugMessage("Description get Edited");
                Admin.Click_TermsAndCondition_Button_Save();
                AddDelay(5000);
                VerifyTextOnPageAndHighLight(edited_description);
                Logger.WriteDebugMessage("Edited Description get Reflected in grid");

                //Delete the recently edited Terms & Condition
                Admin.Click_TermsAndCondition_Icon_Delete();
                Logger.WriteDebugMessage("Confirmation pop up for Delete should get displayed");
                Admin.Click_TermsAndCondition_Button_No();
                Logger.WriteDebugMessage("No button get clicked on pop-up");
                Admin.Click_TermsAndCondition_Icon_Delete();
                Logger.WriteDebugMessage("Confirmation pop up for Delete should get displayed");
                Admin.Click_TermsAndCondition_Button_Yes();
                Logger.WriteDebugMessage("Terms and Condition get deleted successfully");

                //Search for Deleted item
                Admin.TermsAndCondition_Text_Filter(title);
                VerifyTextOnPageAndHighLight(validationMessage);
                Logger.WriteDebugMessage("Selected T&C should get deleted");
            }
        }
        public static void TC_239389()
        {
            if (TestCaseId == Constants.TC_239389)
            {
                ////Pre-requisite
                Users data = new Users();
                string activationEmailLink, forgotPasswordLink;
                Queries.GetActiveMemberEmail(data);

                // Navigate to Admin and Search for Active User
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Admin.EnterEmail(data.MemberEmail);
                Admin.EnterMemberNumber(data.MemberShipId);
                Logger.WriteDebugMessage("Entered active user in email text box");
                Admin.Click_Button_MemberSearch();
                AddDelay(10000);
                Logger.WriteDebugMessage("Member Result found on the page");
                Admin.Click_Icon_View(ProjectName);
                AddDelay(15000);
                Logger.LogTestData(TestPlanId, TestCaseId, "Active Email", data.MemberEmail, true);
                Logger.WriteDebugMessage("Landed on member information Page");

                //Click on Send Activation email link.
                Admin.SendActivationEmail();
                Logger.WriteDebugMessage("Activation Email sent to Catchall");

                // Go to catchall and Check the Activation email received
                Email.LogIntoCatchAll();
                Email.CatchAll_SearchEmailAndOpenLatestMessage(data.MemberEmail);
                Helper.ScrollToElement(PageObject_Admin.Activation_Email_Link_Button());
                Logger.WriteDebugMessage("Catchall mailbox should be opened");
                Helper.ElementHover(PageObject_Admin.Activation_Email_Link_Button());

                // Hover over the Activate account button and Observe the URL populating at the bottom
                activationEmailLink = PageObject_Admin.Activation_Email_Link_Button().Text;
                if (!((activationEmailLink.Contains("@cendyn17.com")) || (activationEmailLink.Equals(data.MemberEmail))))
                {
                    Logger.WriteDebugMessage("URL should not contain the Customer Personal Information and user-name should be crypted");
                }
                else
                {
                    Assert.Fail("URL contain the Customer Personal Information and user-name should be encrypted");
                }

                //Scenario : Forgot Password
                Helper.ControlToPreviousWindow();
                Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
                SignIn.Click_Link_ForgotYourLogin(ProjectName);
                AddDelay(3000);
                Logger.WriteDebugMessage("user landed on forget password page");

                // Enter an email and click on Recover button.
                ForgotPassword.UpdateEmail(data.MemberEmail, "", 1);
                Logger.WriteDebugMessage("Forget Password Confirmation Message should be displays.");
                AddDelay(7000);

                // Check catchall for the recovery email.
                Hotmail.NavigateToWebmail();
                Hotmail.ClickOutLook();
                Hotmail.CheckActiveWindow();
                Email.CatchAll_SearchEmailAndOpenLatestMessage(data.MemberEmail); // Searched for the email
                Helper.ScrollToElement(PageObject_Admin.ForgotPassword_Email_Link());
                Email.ForgotPasswordEmail_Check();
                AddDelay(5000);

                Helper.ElementHover(PageObject_Admin.ForgotPassword_Email_Link());
                Logger.WriteDebugMessage("Password recovery email should have appeared.");

                //Hover over the Forgot Password button and Observe the URL populating at the bottom 
                forgotPasswordLink = PageObject_Admin.ForgotPassword_Email_Link().Text;
                if ((!((forgotPasswordLink.Contains("@cendyn17.com")) || (forgotPasswordLink.Equals(data.MemberEmail)))))
                {
                    Logger.WriteDebugMessage("URL should not contain the Customer Personal Information and username should be encrypted");
                }
                else
                {
                    Assert.Fail("URL contain the Customer Personal Information and username should be encrypted");
                }
            }

        }
        public static void TC_208722()
        {
            if (TestCaseId == Constants.TC_208722)
            {
                //Pre-requisite
                Users data = new Users();
                string status, awardName, validationMsg, errorMsg_1, errorMsg_2, orderedText, orderedBalance, updatedOrderedBalance,
                   balance, comment, code, awardType, pointValue, memberLevelText, emailText, couponName, marketingPartner, catalog, cardAmount, awardexpMonth, startDate, endDate;
                Queries.GetMemberAwardName(data);
                Random rno = new Random();
                string randomNumber = rno.Next().ToString();
                //Retrieved data
                validationMsg = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMsg");
                errorMsg_1 = TestData.ExcelData.TestDataReader.ReadData(1, "ErrorMsg_1");
                errorMsg_2 = TestData.ExcelData.TestDataReader.ReadData(1, "ErrorMsg_2");
                orderedText = TestData.ExcelData.TestDataReader.ReadData(1, "OrderedText");

                startDate = DateTime.Now.ToString("MM/dd/yyyy");
                endDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                awardName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "AwardName"), randomNumber.ToString());
                code = Helper.GetRandomAlphaNumericString(3,0);
                awardType = TestData.ExcelData.TestDataReader.ReadData(1, "AwardType");
                pointValue = TestData.ExcelData.TestDataReader.ReadData(1, "PointValue");
                memberLevelText = TestData.ExcelData.TestDataReader.ReadData(1, "MemberLevelText");
                emailText = TestData.ExcelData.TestDataReader.ReadData(1, "EmailText");
                couponName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "CouponName"), randomNumber.ToString());
                marketingPartner = TestData.ExcelData.TestDataReader.ReadData(1, "MarketingPartner");
                cardAmount = TestData.ExcelData.TestDataReader.ReadData(1, "CardAmount");
                catalog = TestData.ExcelData.TestDataReader.ReadData(1, "Catalog");
                awardexpMonth = TestData.ExcelData.TestDataReader.ReadData(1, "AwardExpMonth");
                balance = TestData.ExcelData.TestDataReader.ReadData(1, "Balance");
                comment = TestData.ExcelData.TestDataReader.ReadData(1, "Comment");

                //Navigate to Admin and login with valid credentials
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("user landed on " + Driver.Title + "page");

                //Check the Account balance under Loyalty eGifts
                Admin.Click_LoyaltyeGift();
                Admin.Click_LoyaltyeGift_AccountBalance();
                orderedBalance = Admin.LoyaltyeGift_RemainingBalance();
                Logger.WriteDebugMessage("Ordered balanced captured");


                //Assign Loyalty Award to eGift by adding eGift
                if (data.MemberEmail == null || data.AwardName == null)
                {
                    Queries.GetActiveMemberEmail(data, ProjectName);

                    //Click on Loyalty Award >> Click on Add Award
                    Admin.Click_Menu_LoyaltyAwards();
                    ElementWait(PageObject_Admin.Admin_Button_Awards_Add(), 20);
                    Admin.Click_Button_Awards_Add();
                    Logger.WriteDebugMessage("Add Award Popup should be displayed");

                    //Create an active point based award, as manual and check eGift checkbox
                    Admin.AddAward(awardName, code, startDate, endDate, awardType);
                    Admin.Click_Admin_Use_As_EGift();
                    ElementWait(PageObject_Admin.Admin_Text_PointsCost(), 20);
                    Admin.AddPointBasedAward(pointValue, memberLevelText, emailText, awardexpMonth);
                    Admin.Click_Admin_AutomatedSwitch();
                    Logger.WriteDebugMessage("All data should be get updated successfully");

                    //click on save button
                    Admin.Click_LoyaltyAwards_Button_Save();
                    VerifyTextOnPage("Save Successfull");
                    ElementWait(PageObject_Admin.Admin_LoyaltyAwards_Text_Filter(), 50);
                    Admin.LoyaltyAwards_Text_Filter(awardName);
                    Logger.WriteDebugMessage("Points based award should be added");

                    //Click on Loyalty eGift > Click on Add eGift
                    Admin.Click_Menu_LoyaltyeGifts();
                    ElementWait(PageObject_Admin.Admin_LoyaltyeGifts_Button_AddeGift(), 50);
                    Helper.ScrollToElement(PageObject_Admin.Admin_LoyaltyeGifts_Button_AddeGift());
                    Admin.Click_Admin_LoyaltyeGifts_Button_AddeGift();
                    Logger.WriteDebugMessage("Loyalty Add eGift popup should be displayed");

                    //Add an eGift of amount $5 and link recently created award.
                    Admin.Add_LoyaltyeGifts(couponName, marketingPartner, awardName, catalog, cardAmount);
                    Logger.WriteDebugMessage("Loyalty eGift should be added successfully");

                    //click on Add button
                    Admin.Admin_LoyaltyeGifts_Button_Add();
                    VerifyTextOnPage("Saved Successfully");

                    //Select an active user and click on View button
                    Admin.Click_Menu_Home();
                    Admin.EnterEmail(data.MemberEmail);
                    Logger.WriteDebugMessage("Entered active member");
                    Admin.Click_Button_MemberSearch();
                    Logger.WriteDebugMessage("Active member is displaying on the Member Search Page");
                    Admin.Click_Icon_View(ProjectName);
                    Logger.WriteDebugMessage("User should get landed on Member Information page");

                    //Click on Member Awards > Click on Add award
                    Admin.Click_Tab_MemberAwards();
                    Helper.ScrollToElement(PageObject_Admin.Click_AddAward());
                    Admin.Click_AddAward();
                    Admin.AddMemberAward(awardName, comment);
                    Admin.MemberAwards_Text_Filter(awardName);
                    VerifyTextOnPageAndHighLight(orderedText);
                    Logger.WriteDebugMessage("Member award having eGift displayed on the page");
                }
                else
                {
                    //Search for user
                    Admin.Click_Menu_Home();
                    Admin.EnterEmail(data.MemberEmail);
                    Logger.WriteDebugMessage("Entered active user in email text box");
                    Admin.Click_Button_MemberSearch();
                    AddDelay(10000);
                    Logger.WriteDebugMessage("Member Result found on the page");
                    Admin.Click_Icon_View(ProjectName);
                    AddDelay(15000);
                    Logger.WriteDebugMessage("Landed on member information Page");

                    //Search Member Award having eGift Associated with it
                    Admin.Click_Tab_MemberAwards();
                    AddDelay(30000);
                    Admin.MemberAwards_Text_Filter(data.AwardName);
                    AddDelay(30000);
                    VerifyTextOnPageAndHighLight(orderedText);
                    Logger.WriteDebugMessage("Member award having eGift displayed on the page");
                }

                //Verify if Admin is able to change the Award status from Ordered to any
                for (int i = 1; i <= 5; i++)
                {
                    Admin.Click_MemberAwardStatus();
                    status = TestData.ExcelData.TestDataReader.ReadData(i, "Status");
                    Admin.Dropdown_SelectStatus(status);
                    Admin.SelectStatusCheck();
                    if (status.Equals("Issued") || status.Equals("Expired") || status.Equals("Canceled"))
                    {
                        VerifyTextOnPageAndHighLight(errorMsg_1);
                        Logger.WriteDebugMessage(errorMsg_1 + " Error message got caputured");
                    }
                    else
                    {
                        VerifyTextOnPageAndHighLight(errorMsg_2);
                        Logger.WriteDebugMessage(errorMsg_2 + " Error message got caputured");
                    }
                    Admin.DeleteSelectedStatus();
                }

                //Verify Award should not get display in Portal
                Admin.Click_MemberInformation_Value_MemberPortal();
                AddDelay(30000);
                ControlToNewWindow();
                Driver.Manage().Window.Maximize();
                Navigation.Click_Link_MyAward();
                Logger.WriteDebugMessage("User landed on My Award page");
                Navigation.MyAwards_Text_Filter(data.AwardName);
                VerifyTextOnPageAndHighLight(validationMsg);
                Logger.WriteDebugMessage("Award should not displayed on the page");

                //Verify Order Balance under Loyalty gGifts >>Account balance
                ControlToPreviousWindow();
                Admin.Click_LoyaltyeGift();
                AddDelay(15000);
                Admin.Click_LoyaltyeGift_AccountBalance();
                updatedOrderedBalance = Admin.LoyaltyeGift_RemainingBalance();
                Logger.WriteDebugMessage("Updated order balance get displayed");
                if (orderedBalance == updatedOrderedBalance)
                {
                    VerifyTextOnPageAndHighLight(orderedBalance);
                    Logger.WriteDebugMessage("Ordered balance not updated");
                }
                else
                {
                    VerifyTextOnPageAndHighLight(updatedOrderedBalance);
                    Logger.WriteDebugMessage("Ordered Balance Updated");
                }
                if (data.MemberEmail == null || data.AwardName == null)
                {
                    Admin.Click_Menu_LoyaltyAwards();
                    ElementWait(PageObject_Admin.Admin_Button_Awards_Add(), 20);
                    Admin.LoyaltyAwards_Text_Filter(awardName);
                    AddDelay(5000);
                    Logger.WriteDebugMessage("Award should be found");
                    Admin.Click_LoyaltyAwards_Icon_Edit();
                    AddDelay(5000);
                    Logger.WriteDebugMessage("Loyalty award popup should get display");
                    Admin.Click_Admin_AwardStatusSwitch();
                    AddDelay(5000);
                    Logger.WriteDebugMessage("Award Status button got switch off");
                    Admin.Click_LoyaltyAwards_Button_Save();
                    AddDelay(5000);
                    Logger.WriteDebugMessage("Award Status get switch off");
                    Admin.LoyaltyAwards_Text_Filter(awardName);
                    AddDelay(5000);
                    Logger.WriteDebugMessage("Award should be found");
                }
            }
        }
        public static void TC_116201()
        {
            if (TestCaseId == Constants.TC_116201)
            {
                //Pre-requisite
                string title, visibilityStartDate, visibilityEndDate, promotionDescription, promotionCode, buttonName, shortdescription, imagePath;
                Users data = new Users();
                Random ran_number = new Random();

                //Assign Values to variables
                title = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Title"), ran_number.Next().ToString());
                visibilityStartDate = TestData.ExcelData.TestDataReader.ReadData(1, "VisibilityStartDate");
                visibilityEndDate = TestData.ExcelData.TestDataReader.ReadData(1, "VisibilityEndDate");
                promotionDescription = MakeUnique("Promotion");
                promotionCode = ran_number.Next().ToString();
                buttonName = String.Concat("BUTTON_", promotionCode);
                shortdescription = TestData.ExcelData.TestDataReader.ReadData(1, "ShortDescription");
                imagePath = String.Concat(ProjectPath, TestData.ExcelData.TestDataReader.ReadData(1, "ImagePath"));

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
                if (!(PageObject_Admin.SubTab_Offers().Displayed))
                {
                    Assert.Fail("Loyalty Setup Page is not Loaded");
                }
                Admin.Click_SubTab_Offers();
                Logger.WriteDebugMessage("user landed on offer list screen");
                if (!(PageObject_Admin.LoyaltySetUp_Offers_Button_AddOffers().Displayed))
                {
                    Assert.Fail("Add offer Page is not Loaded");
                }
                //Click on Add Offer
                Admin.Click_LoyaltySetUp_Offers_Button_AddOffers();
                Logger.WriteDebugMessage("User landed on Add offer page");

                //Enter all the fields and click on Save
                Admin.AddORUpdateOffers(title, visibilityStartDate, visibilityEndDate, data.MembershipLevel, visibilityStartDate, visibilityEndDate, shortdescription);

                //Upload Image
                Admin.UploadImage(imagePath);
                AddDelay(8000);
                Logger.WriteDebugMessage("Entered all Mandatory fields on Add Offer Page");

                //Enter Promotion Details
                Admin.AddPromotion(promotionCode, buttonName, data.PropertyName, promotionDescription, ProjectName);
                Admin.Click_LoyaltySetUp_Offers_Button_ConfirmPromotion();
                Logger.WriteDebugMessage("Promotion is added successfully");
                Admin.Click_LoyaltySetUp_Offers_Button_Save();
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
                VerifyTextOnPageAndHighLight(title);
                Logger.WriteDebugMessage("Offer got added successfully");

                //Navigate to Member Search and Search for an Active User

                Admin.Click_Menu_Home();
                Logger.WriteDebugMessage("Navigate to Member Search Page");
                if (!(PageObject_Admin.Textbox_Email().Displayed))
                {
                    Assert.Fail("Member Search page is not loaded succesfully");
                }
                Queries.GetActiveMemberEmailUsingMembershipLevel(data, data.MembershipCode, ProjectName);
                Admin.EnterEmail(data.MemberEmail);
                Admin.EnterMemberNumber(data.MemberShipId);
                Logger.WriteDebugMessage("Entered Active Member email " + data.MemberEmail);
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Member details is dispaying");
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Member Information Page is displaying");

                //Navigate to member portal by clicking on Member Login

                Admin.Click_MemberInformation_Value_MemberPortal();
                AddDelay(8000);
                ControlToNewWindow();
                AddDelay(8000);
                Driver.Manage().Window.Maximize();
                if (!(PageObject_Navigation.Link_SpecialOffer().Displayed))
                {
                    Assert.Fail("Member Front End page is not loaded");
                }
                //Navigate to Offer page

                Navigation.Click_Link_SpecialOffer();
                Logger.WriteDebugMessage("Member Offer Page is getting displayed");
                PageDown();
                if (!(PageObject_SpecialOffers.Specialoffers_Readmore(title).Displayed))
                {
                    Assert.Fail("Member Offer Page is not Loaded");
                }
                //Click on Ready more icon for the added offer

                Navigation.Click_SpecialOffers_Readmore(title);

                ScrollToElement(PageObject_SpecialOffers.Specialoffers_Button(promotionCode));
                Logger.WriteDebugMessage("Member Offer Page is getting displayed");


                Navigation.Click_SpecialOffers_Button(promotionCode);
                AddDelay(10000);
                ControlToNewWindow();
                if ((Driver.Url).Contains(promotionCode))
                    Logger.WriteDebugMessage("Navigated to Promotion Page");
                else
                    Assert.Fail("Promotion Page is not getting displayed");

            }
        }
        public static void TC_226427()
        {
            if (TestCaseId == Constants.TC_226427)
            {
                //Pre-requisite
                string memberLevel1, memberLevel2, memberLevel3, validationMessage, textMessage, yesText, noText, memberLevelCode3;
                Users data = new Users();

                //Assign Values to variables
                validationMessage = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage");
                textMessage = TestData.ExcelData.TestDataReader.ReadData(1, "TextMessage");
                yesText = TestData.ExcelData.TestDataReader.ReadData(1, "YesText");
                noText = TestData.ExcelData.TestDataReader.ReadData(1, "NoText");
                Logger.LogTestData(TestPlanId, TestCaseId, "Validation Message", validationMessage);
                Logger.LogTestData(TestPlanId, TestCaseId, "Overlay Message", textMessage);

                // Navigate to Admin and Search for User
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Queries.GetMemberLevel(data, 1);
                memberLevel1 = data.MembershipLevel;
                if (memberLevel1.Equals("Club Member"))
                {
                    memberLevel1 = "MEMBER";
                }

                Logger.LogTestData(TestPlanId, TestCaseId, "First Member Level", memberLevel1);
                Queries.GetDataAsPerMemberLevel(memberLevel1, data);
                Admin.EnterEmail(data.MemberEmail);
                Logger.LogTestData(TestPlanId, TestCaseId, "First Member Email", data.MemberEmail);
                Logger.WriteDebugMessage("User entered in email text box");
                Admin.Click_Button_MemberSearch();
                //ElementWait(PageObject_Admin.Admin_Button_ViewMember(ProjectName), 60);
                Logger.WriteDebugMessage("Member Result found on the page");
                Admin.Click_Icon_View(ProjectName);
                ElementWait(PageObject_Admin.Value_Information_MemberLevel(), 60);
                Logger.WriteDebugMessage("Landed on member information Page");

                // Click on Member Level, update member level & Verify the Overlay
                Queries.GetMemberLevel(data, 2);
                memberLevel2 = data.MembershipLevel;
                Logger.LogTestData(TestPlanId, TestCaseId, "Second Member Level", memberLevel2);
                Admin.SelectLevel(memberLevel2);
                ElementWait(PageObject_Admin.Click_Member_Level_Email_No_Button(), 120);
                VerifyTextOnPageAndHighLight(textMessage);
                VerifyTextOnPageAndHighLight(yesText);
                VerifyTextOnPageAndHighLight(noText);
                Logger.WriteDebugMessage("Member Level Email send overlay Displayed");

                // Click on 'x' close button on the overlay 
                Admin.MemberLevel_CrossButton();
                Logger.WriteDebugMessage("Verified cross button by clicking on it");

                //Login to catchall, Search for Member level upgrade email 
                Helper.OpenNewTab();
                Email.LogIntoCatchAll();
                Hotmail.OutLookSearchEmail(data.MemberEmail + " " + "Upgrade");
                VerifyTextOnPage(validationMessage);
                Logger.WriteDebugMessage("Email should not be triggered");

                // Search for Another Active user and Update Member Level
                Helper.ControlToPreviousWindow();
                ElementWait(PageObject_Admin.Menu_Home(), 30);
                Admin.Click_Menu_Home();
                Logger.WriteDebugMessage("Landed back on Member Search Page");
                Queries.GetMemberLevel(data, 1);
                memberLevel1 = data.MembershipLevel;
                if (memberLevel1.Equals("Club Member"))
                {
                    memberLevel1 = "MEMBER";
                }

                Queries.GetDataAsPerMemberLevel(memberLevel1, data);
                Admin.EnterEmail(data.MemberEmail);
                Logger.LogTestData(TestPlanId, TestCaseId, "Second Member Email", data.MemberEmail);
                Logger.WriteDebugMessage("User entered in email text box");
                Admin.Click_Button_MemberSearch();
                //ElementWait(PageObject_Admin.Admin_Button_ViewMember(ProjectName), 36);
                Logger.WriteDebugMessage("Member Result found on the page");
                Admin.Click_Icon_View(ProjectName);
                ElementWait(PageObject_Admin.Value_Information_MemberLevel(), 80);
                Logger.WriteDebugMessage("Landed on member information Page");


                // Click on Member Level, update member level & Click on No 
                Queries.GetMemberLevel(data, 2);
                memberLevel2 = data.MembershipLevel;
                Admin.SelectLevel(memberLevel2);
                ElementWait(PageObject_Admin.Click_Member_Level_Email_No_Button(), 60);
                Logger.WriteDebugMessage(memberLevel2 + " Member Level got Selected and Overlay got displayed");
                Admin.Click_Member_Level_Email_No_Button();
                Logger.WriteDebugMessage("Clicked on No button on Member Level Email Send Overlay");

                //Login to catchall, Search for Member level upgrade email 
                Helper.ControlToNewWindow();
                Hotmail.OutLookSearchEmail(data.MemberEmail + " " + "Upgrade");
                VerifyTextOnPage(validationMessage);
                Logger.WriteDebugMessage("Email should not be triggered");

                // Click on Member Level, update member level & Click on Yes 
                Helper.ControlToPreviousWindow();
                Queries.GetMemberLevel(data, 3);
                memberLevel3 = data.MembershipLevel;
                memberLevelCode3 = data.MembershipCode;
                Admin.SelectLevel(memberLevel3);
                ElementWait(PageObject_Admin.Click_Member_Level_Email_No_Button(), 60);
                Logger.WriteDebugMessage(memberLevel3 + " Member Level got Selected and Overlay got displayed");
                Admin.Click_Member_Level_Email_Yes_Button();
                Logger.WriteDebugMessage("Clicked on Yes button on Member Level Email Send Overlay");

                //Login to catchall, Search for Member level upgrade email 
                Helper.ControlToNewWindow();
                Hotmail.OutLookSearchEmail(data.MemberEmail + " " + "Upgrade");
                Hotmail.OpenLatestEmail();
                //Email.CatchAll_SearchEmailAndOpenLatestMessage(data.MemberEmail + " " + "Upgrade");
                Logger.WriteDebugMessage("Catchall mailbox should be opened");

                //Search for Client admin notification
                VerifyTextOnPageAndHighLight(data.MemberEmail);
                Logger.WriteDebugMessage("User got notification for level up-gradation");

                //Navigate back to admin site and Click on Admin Updates tab
                Helper.ControlToPreviousWindow();
                Admin.Click_Tab_AdminUpdates();
                Logger.WriteDebugMessage("Navigated to Admin Update Tab");
                Helper.ScrollToElement(PageObject_Admin.AdminUpdates_Icon_View1());
                Admin.Click_AdminUpdates_Icon_View1();
                VerifyTextOnPageAndHighLight(memberLevelCode3);
                Logger.WriteDebugMessage("Membership level get updated successfully");
                Logger.LogTestData(TestPlanId, TestCaseId, "Third Member Level", memberLevel3, true);
            }
        
        }

        public static void TC_237408()
        {
            if (TestCaseId == Constants.TC_237408)
            {
                //Pre-requisite
                Users data = new Users();
                Users logs = new Users();
                Random random = new Random();

                // Navigate to Admin and Search for Active User
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Queries.GetActiveMemberEmail(data);
                Admin.EnterEmail(data.MemberEmail);
                Logger.WriteDebugMessage("User entered in email text box");
                Admin.Click_Button_MemberSearch();
                ElementWait(PageObject_Admin.Admin_Button_ViewMember(ProjectName), 60);
                Logger.WriteDebugMessage("Member Result found on the page");
                Admin.Click_Icon_View(ProjectName);
                ElementWait(PageObject_Admin.Value_Information_MemberLevel(), 60);
                Logger.WriteDebugMessage("Landed on member information Page");

                // Click on Reset link, Change the Member email & click on Update
                VerifyTextOnPageAndHighLight(data.MemberEmail);
                string updateEmail = String.Concat("QATest", random.Next().ToString(), "@cendyn17.com");
                Admin.SendResetLogin(updateEmail);
                AddDelay(10000);
                VerifyTextOnPage("Reset successful.");
                VerifyTextOnPageAndHighLight(updateEmail);
                Logger.WriteDebugMessage("'Reset successful' message is displayed.");

                // Validate changes in Admin update tab
                Admin.Click_Tab_AdminUpdates();
                Helper.ScrollToElement(PageObject_Admin.AdminUpdates_Icon_View1());
                Admin.Click_AdminUpdates_Icon_View1();
                VerifyTextOnPageAndHighLight(updateEmail);
                Logger.WriteDebugMessage("User should see Reset Login log with details in Admin tab");
                Admin.Admin_Update_View_Overlay_Close();
                //Log test data
                Logger.LogTestData(TestPlanId, TestCaseId, "Member Email Before Update", data.MemberEmail);
                Logger.LogTestData(TestPlanId, TestCaseId, "Member Email after Update", updateEmail);
                Logger.LogTestData(TestPlanId, TestCaseId, "Profile Id", data.ProfileId, true);

                //Validate changes in Loyalty_AdminChange_Log table
                Queries.GetUpdatedEmail(logs, data.ProfileId);
                string NewEmail = logs.New;
                if (NewEmail.Contains(updateEmail))
                {
                    Logger.WriteDebugMessage(" Email id Update Changes reflected in db for Updated Email");
                }
                else
                {
                    Assert.Fail("Changes are not reflected in db");
                }

                //Update back old Email address
                Admin.SendResetLogin(data.MemberEmail);
                AddDelay(10000);
                VerifyTextOnPage("Reset successful.");
                VerifyTextOnPageAndHighLight(data.MemberEmail);
                Logger.WriteDebugMessage("'Reset back to Old email address.");

            }
        }

        public static void TC_226431()
        {
            if (TestCaseId == Constants.TC_226431)
                {
                    //Pre-requisite
                    string memberLevel3, memberLevel2, memberLevel1, validationMessage;
                    Users data = new Users();

                    //Assign Values to variables

                    validationMessage = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage");

                    // Navigate to Admin and Search for User
                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Queries.GetMemberLevel(data, 3);
                    memberLevel3 = data.MembershipLevel;
                    Logger.LogTestData(TestPlanId, TestCaseId, "Third Member Level", memberLevel3);
                    if (memberLevel3.Equals("Elite Club Member"))
                    {
                        memberLevel3 = "ELITE";
                    }
                    Queries.GetDataAsPerMemberLevel(memberLevel3, data);
                    Admin.EnterEmail(data.MemberEmail);
                    Logger.WriteDebugMessage("User entered in email text box");
                    Admin.Click_Button_MemberSearch();
                    //ElementWait(PageObject_Admin.Admin_Button_ViewMember(ProjectName), 180);
                    Logger.WriteDebugMessage("Member Result found on the page");
                    Admin.Click_Icon_View(ProjectName);
                    ElementWait(PageObject_Admin.Value_Information_MemberLevel(), 60);
                    Logger.WriteDebugMessage("Landed on member information Page");

                    // Click on Member Level, downgrade member level
                    Queries.GetMemberLevel(data, 2);
                    memberLevel2 = data.MembershipLevel;
                    Admin.SelectLevel(memberLevel2);
                    AddDelay(15000);


                    //Verify the Send Member Level Downgrade Overlay is getting Displayed or not
                    Admin.VerifyMemberLevelEmailOverlay();

                    //Login to catchall, Search for Member level Notification and downgraded email 
                    Helper.OpenNewTab();
                    Email.LogIntoCatchAll();
                    //Email.CatchAll_SearchEmailAndOpenLatestMessage(data.MemberEmail + " " + "Notification");
                    //Helper.ControlToNewWindow();
                    Hotmail.OutLookSearchEmail(data.MemberEmail + " " + "Notification");
                    Hotmail.OpenLatestEmailSingleClick();
                    VerifyTextOnPageAndHighLight(data.MemberEmail);
                    Logger.WriteDebugMessage("Catchall mailbox should be opened");
                    //Helper.ControlToNewWindow();
                    Hotmail.OutLookSearchEmail(data.MemberEmail + " " + "Downgrade");
                    VerifyTextOnPage(validationMessage);
                    Logger.WriteDebugMessage("Email should not be triggered");
                    
                    // Click on Member Level, downgrade member level
                    Helper.ControlToPreviousWindow();
                    Queries.GetMemberLevel(data, 1);
                    memberLevel1 = data.MembershipLevel;
                    Admin.SelectLevel(memberLevel1);
                    AddDelay(15000);

                    //Verify the Send Member Level Downgrade Overlay is getting Displayed or not
                    Admin.VerifyMemberLevelEmailOverlay();

                    //Navigate to catchall, Search for Member level Notification and downgraded email 
                    Helper.ControlToNewWindow();
                    //Email.CatchAll_SearchEmailAndOpenLatestMessage(data.MemberEmail + " " + "Notification");
                    Hotmail.OutLookSearchEmail(data.MemberEmail + " " + "Notification");
                    Hotmail.OpenLatestEmailSingleClick();
                    VerifyTextOnPageAndHighLight(data.MemberEmail);
                    Logger.WriteDebugMessage("Catchall mailbox should be opened");
                    //Helper.CloseCurrentTab();
                    //Helper.ControlToNewWindow();
                    Hotmail.OutLookSearchEmail(data.MemberEmail + " " + "Downgrade");
                    VerifyTextOnPage(validationMessage);
                    Logger.WriteDebugMessage("Email should not be triggered");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Second Member Level", memberLevel2);
                    Logger.LogTestData(TestPlanId, TestCaseId, "First Member Level1", memberLevel1);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Member Email", data.MemberEmail, true);

            }
        }
        public static void TC_272803()
        {
            try
            {
                if (TestCaseId == Constants.TC_272803)
                {
                    //Pre-requisite
                    string lableValue, bookEndDate, joinEnddate, minRevVal, minRoomRevVal, minFnBRevVal, minOtherRevVal, minNightVal, minStayVal, maxStaysVal, marCodesVal, rateCodeVal, hotelsVal, roomtypesVal, sobVal, channelCodesVal, bookdateVal, joinDateVal, marcomboVal, ratecomboVal, bookdateValidation, joindateValidation;
                    Users data = new Users();

                    //Assign Values to variables
                    minRevVal = TestData.ExcelData.TestDataReader.ReadData(1, "MinRevenueVal");
                    minRoomRevVal = TestData.ExcelData.TestDataReader.ReadData(1, "MinRoomRevenueVal");
                    minFnBRevVal = TestData.ExcelData.TestDataReader.ReadData(1, "MinFnBRevenueVal");
                    minOtherRevVal = TestData.ExcelData.TestDataReader.ReadData(1, "MinOtherRevenueVal");
                    minNightVal = TestData.ExcelData.TestDataReader.ReadData(1, "MinNightVal");
                    minStayVal = TestData.ExcelData.TestDataReader.ReadData(1, "MinStayVal");
                    maxStaysVal = TestData.ExcelData.TestDataReader.ReadData(1, "MaxStayVal");
                    marCodesVal = TestData.ExcelData.TestDataReader.ReadData(1, "MarketCodeVal");
                    rateCodeVal = TestData.ExcelData.TestDataReader.ReadData(1, "RateCodeVal");
                    hotelsVal = TestData.ExcelData.TestDataReader.ReadData(1, "HotelsVal");
                    roomtypesVal = TestData.ExcelData.TestDataReader.ReadData(1, "RoomTypesVal");
                    sobVal = TestData.ExcelData.TestDataReader.ReadData(1, "SourceOfBusinessVal");
                    channelCodesVal = TestData.ExcelData.TestDataReader.ReadData(1, "ChannelCodesVal");
                    bookdateVal = DateTime.Now.ToString("MM/dd/yyyy");
                    bookEndDate = DateTime.Now.AddDays(2).ToString("MM/dd/yyyy");
                    joinDateVal = DateTime.Now.ToString("MM/dd/yyyy");
                    joinEnddate = DateTime.Now.AddDays(2).ToString("MM/dd/yyyy");
                    marcomboVal = TestData.ExcelData.TestDataReader.ReadData(1, "MarketComboVal");
                    ratecomboVal = TestData.ExcelData.TestDataReader.ReadData(1, "RateComboVal");
                    bookdateValidation = TestData.ExcelData.TestDataReader.ReadData(1, "BookingDateValidation");
                    joindateValidation = TestData.ExcelData.TestDataReader.ReadData(1, "JoinDateValidation");
                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully.");


                    //Navigate to Loyalty Rule ->Award Earning Rule - >Rule Restriction tab
                    Admin.Click_Menu_LoyaltyRules();
                    Logger.WriteDebugMessage("Landed on the Loyalty Rules page");
                    Admin.Click_LoyaltyRules_AwardEarningRules();
                    Logger.WriteDebugMessage("Navigated to Award Earning Rule Tab");
                    Admin.Click_AwardEarningRules_AddRuleButton();
                    Logger.WriteDebugMessage("Landed on Add Rule Overlay of Award Earning Rule");
                    Admin.Click_LoyaltyRules_PointsEarningRule_RuleRestriction();
                    Logger.WriteDebugMessage("Landed on Rule Restriction Tab");

                    //Verify the End date < start date functinality.
                    Admin.Select_Rule_Restrict_BookingDate(bookEndDate);
                    Admin.Select_Rule_Restrict_BookingEndDate(bookdateVal);
                    Admin.Select_Rule_Restrict_JoinDate(joinEnddate);
                    Admin.Select_Rule_Restrict_JoinEndDate(joinDateVal);
                    Logger.WriteDebugMessage("Booking date and Join date entered");
                    Admin.Click_Rule_Restrict_SaveButton();
                    VerifyTextOnPageAndHighLight(bookdateValidation);
                    VerifyTextOnPageAndHighLight(joindateValidation);
                    Logger.WriteDebugMessage("Validation message for End date less than join date is displayed");

                    //Verify the Labels present on the Rule Restriction tab
                    for (int i = 1; i <= 15; i++)
                    {
                        lableValue = TestData.ExcelData.TestDataReader.ReadData(i, "LabelValue");
                        VerifyTextOnPageAndHighLight(lableValue);
                    }
                    Logger.WriteDebugMessage("All the Fields lables are present on Rule Restriction Page");

                    //Select Values on the fields
                    Admin.AddRuleRestriction(minRevVal, minRoomRevVal, minFnBRevVal, minOtherRevVal, minNightVal, minStayVal, maxStaysVal, marCodesVal, rateCodeVal, hotelsVal, roomtypesVal, sobVal, channelCodesVal, bookdateVal, bookEndDate, joinDateVal, joinEnddate, marcomboVal, ratecomboVal);
                    Logger.WriteDebugMessage("Entered all details succesfully on Rule Restriction tab");

                    if (PageObject_Admin.Enter_Rule_Restrict_MinRevenue().Text != "0" && PageObject_Admin.Enter_Rule_Restrict_MinRoomRevenue().Text != "0.00" && PageObject_Admin.Enter_Rule_Restrict_MinFandBRevenue().Text != "0.00" && PageObject_Admin.Enter_Rule_Restrict_MinotherRevenue().Text != "0.00" && PageObject_Admin.Enter_Rule_Restrict_MinNight().Text != "0" && PageObject_Admin.Enter_Rule_Restrict_MinStay().Text != "0" && PageObject_Admin.Enter_Rule_Restrict_MaxStay().Text != "0" && PageObject_Admin.Click_Rule_Restrict_MarketCode().GetAttribute("title") != "Nothing Selected" && PageObject_Admin.Click_Rule_Restrict_RateCode().GetAttribute("title") != "Nothing Selected" &&
                      PageObject_Admin.Click_Rule_Restrict_Hotel().GetAttribute("title") != "Nothing Selected" && PageObject_Admin.Click_Rule_Restrict_RoomType().GetAttribute("title") != "Nothing Selected" && PageObject_Admin.Click_Rule_Restrict_SourceOfBusiness().GetAttribute("title") != "Nothing Selected" && PageObject_Admin.Click_Rule_Restrict_ChannelCode().GetAttribute("title") != "Nothing Selected" && PageObject_Admin.Click_Rule_Restrict_MarketCombo().GetAttribute("title") != "Nothing Selected" &&
                      PageObject_Admin.Click_Rule_Restrict_RateCombo().GetAttribute("title") != "Nothing Selected" && PageObject_Admin.Click_Rule_Restrict_SaveButton().Displayed && PageObject_Admin.Click_Rule_Restrict_CancelButton().Displayed)
                    {
                        Logger.WriteDebugMessage("All the Fileds are having Values and Save and Cancel Button is present on the Rule Restriction Tab");
                        Admin.Click_Rule_Restrict_CancelButton();
                        Logger.WriteDebugMessage("Clicked on cancel button on Rule Restriction tab");
                    }
                    else
                        Assert.Fail("All the Fileds are not having Values");

                    //Navigate to Loyalty Rule ->Point Earning Rule - >Rule Restriction tab
                    Admin.Click_Menu_LoyaltyRules();
                    Logger.WriteDebugMessage("Landed on the Loyalty Rules page");
                    Admin.Click_SubTab_PointsEarningRules();
                    Logger.WriteDebugMessage("Navigated to Points Earning Rule Tab");
                    Admin.Click_PointsEarningRules_Button_AddRule();
                    Logger.WriteDebugMessage("Landed on Add Rule Overlay of Points Earning Rule");
                    Admin.Click_LoyaltyRules_PointsEarningRule_RuleRestriction();
                    Logger.WriteDebugMessage("Landed on Rule Restriction Tab");


                    //Verify the Labels present on the Rule Restriction tab
                    for (int i = 1; i <= 15; i++)
                    {
                        lableValue = TestData.ExcelData.TestDataReader.ReadData(i, "LabelValue");
                        VerifyTextOnPageAndHighLight(lableValue);
                    }
                    Logger.WriteDebugMessage("All the Fields lables are present on Rule Restriction Page");

                    //Select Values on the fields
                    Admin.AddRuleRestriction(minRevVal, minRoomRevVal, minFnBRevVal, minOtherRevVal, minNightVal, minStayVal, maxStaysVal, marCodesVal, rateCodeVal, hotelsVal, roomtypesVal, sobVal, channelCodesVal, bookdateVal, bookEndDate, joinDateVal, joinEnddate, marcomboVal, ratecomboVal);
                    Logger.WriteDebugMessage("Entered all details succesfully on Rule Restriction tab");

                    if (PageObject_Admin.Enter_Rule_Restrict_MinRevenue().Text != "0" && PageObject_Admin.Enter_Rule_Restrict_MinRoomRevenue().Text != "0.00" && PageObject_Admin.Enter_Rule_Restrict_MinFandBRevenue().Text != "0.00" && PageObject_Admin.Enter_Rule_Restrict_MinotherRevenue().Text != "0.00" && PageObject_Admin.Enter_Rule_Restrict_MinNight().Text != "0" && PageObject_Admin.Enter_Rule_Restrict_MinStay().Text != "0" && PageObject_Admin.Enter_Rule_Restrict_MaxStay().Text != "0" && PageObject_Admin.Click_Rule_Restrict_MarketCode().GetAttribute("title") != "Nothing Selected" && PageObject_Admin.Click_Rule_Restrict_RateCode().GetAttribute("title") != "Nothing Selected" &&
                      PageObject_Admin.Click_Rule_Restrict_Hotel().GetAttribute("title") != "Nothing Selected" && PageObject_Admin.Click_Rule_Restrict_RoomType().GetAttribute("title") != "Nothing Selected" && PageObject_Admin.Click_Rule_Restrict_SourceOfBusiness().GetAttribute("title") != "Nothing Selected" && PageObject_Admin.Click_Rule_Restrict_ChannelCode().GetAttribute("title") != "Nothing Selected" && PageObject_Admin.Click_Rule_Restrict_MarketCombo().GetAttribute("title") != "Nothing Selected" &&
                      PageObject_Admin.Click_Rule_Restrict_RateCombo().GetAttribute("title") != "Nothing Selected" && PageObject_Admin.Click_Rule_Restrict_SaveButton().Displayed && PageObject_Admin.Click_Rule_Restrict_CancelButton().Displayed)
                    {
                        Logger.WriteDebugMessage("All the Fileds are having Values and Save and Cancel Button is present on the Rule Restriction Tab");
                    }
                    else
                        Assert.Fail("All the Fileds are not having Values");

                    // Log test data into log file
                    Logger.LogTestData(TestPlanId, TestCaseId, "Minimum Revenue", minRevVal);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Minimum Room Revenue", minRoomRevVal);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Minimum F&B Revenue", minFnBRevVal);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Minimum Other Revenue", minOtherRevVal);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Minimum Night", minNightVal);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Minimum Stay", minStayVal);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Maximum Stay", maxStaysVal);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Market Codes", marCodesVal);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Rate Codes", rateCodeVal);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Hotel", hotelsVal);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Room Type", roomtypesVal);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Source of Business", sobVal);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Channel Codes", channelCodesVal);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Booking date", bookdateVal);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Booking End date", bookEndDate);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Join Date", joinDateVal);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Join End Date", joinEnddate);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Market Combo", marcomboVal);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Rate Combo", ratecomboVal, true);

                }
            }catch(Exception e)
            {

            }
        }
        #endregion TP_193880 
    }

}


