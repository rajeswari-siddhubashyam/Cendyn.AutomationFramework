using System;
using eLoyaltyV3.AppModule.UI;
using System.Collections.Generic;
using NUnit.Framework;
using TestData;
using eLoyaltyV3.Entity;
using BaseUtility.Utility;
using eLoyaltyV3.PageObject.Admin;
using InfoMessageLogger;
using Queries = eLoyaltyV3.Utility.Queries;
using Constants = eLoyaltyV3.Utility.Constants;
using System.Runtime.InteropServices;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : eLoyaltyV3.Utility.Setup
    {
        public static void TC_217871()
        {
            if (TestCaseId == Constants.TC_217871)
            {
                //pre-requiste
                string referralCodeText, numberOfNightsText, memberLevelText, actionText, paginationValue, referralCode, qualifyingNight, stayType, NewLevel;


                //Retrive data from test data
                referralCodeText = TestData.ExcelData.TestDataReader.ReadData(1, "ReferralCodeText");
                numberOfNightsText = TestData.ExcelData.TestDataReader.ReadData(1, "NumberOfNightsText");
                memberLevelText = TestData.ExcelData.TestDataReader.ReadData(1, "MemberLevelText");
                actionText = TestData.ExcelData.TestDataReader.ReadData(1, "ActionText");
                referralCode = TestData.ExcelData.TestDataReader.ReadData(1, "ReferralCode");
                qualifyingNight = TestData.ExcelData.TestDataReader.ReadData(1, "QualifyingNight");
                stayType = TestData.ExcelData.TestDataReader.ReadData(1, "StayType");
                NewLevel = TestData.ExcelData.TestDataReader.ReadData(1, "NewLevel");


                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Navigate to Loyalty Rule > Member Level Rule
                Admin.Click_Menu_LoyaltyRules();
                Logger.WriteDebugMessage("Loyalty Rules tab get clicked");
                Admin.Click_LoyaltyRules_MemberLevelRules_Tab();
                Logger.WriteDebugMessage("Member Level Rules sub tab get clicked");

                //Verify fields available in Member level grid
                VerifyTextOnPageAndHighLight(referralCodeText);
                VerifyTextOnPageAndHighLight(numberOfNightsText);
                VerifyTextOnPageAndHighLight(memberLevelText);
                VerifyTextOnPageAndHighLight(actionText);

                //Verify user is able to see Add Rule button
                if (PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_AddRule().Displayed)
                    Logger.WriteDebugMessage("Add Rule button displayed on the page");
                else
                    Assert.Fail("Add Rule button not displaying on the page");

                //Verify the Pagination Dropdown value
                Admin.Click_LoyaltyRules_MemberLevelRules_PaginationDropdown();
                for (int i = 5; i <= 20; i += 5)
                {
                    paginationValue = TestData.ExcelData.TestDataReader.ReadData(i, "PaginationValue");
                    if (Admin.Get_LoyaltyRules_MemberLevelRules_PaginationDropdown(i).Equals(paginationValue))
                        Logger.WriteInfoMessage(i + " Value found on Pagination dropdown");
                }
                if (Admin.Get_LoyaltyRules_MemberLevelRules_PaginationDropdown(-1).Equals("All"))
                    Logger.WriteDebugMessage("All the values are displayed on Pagination Dropdown");

                //Click on Add Rule button and Verify the Fileds
                Admin.Click_LoyaltyRules_MemberLevelRules_AddRule();
                Logger.WriteDebugMessage("Add Member Level Rule Overlay got displayed");

                //Verify fields available on Add Member level Overlay
                VerifyTextOnPageAndHighLight(referralCode);
                VerifyTextOnPageAndHighLight(qualifyingNight);
                VerifyTextOnPageAndHighLight(stayType);
                VerifyTextOnPageAndHighLight(NewLevel);
                Logger.WriteDebugMessage("All the fields are present on Add Member Level Rule Overlay");

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Referral Code Text", referralCodeText);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Number Of Nights Text", numberOfNightsText);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Text", memberLevelText);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Action Text", actionText);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Referral Code ", referralCode);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Qualifying Nights Text", qualifyingNight);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Stay Type Text", stayType);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "New Level Text", NewLevel, true);

            }

        }

        public static void TC_217877()
        {
            if (TestCaseId == Constants.TC_217877)
            {
                //pre-requiste
                string referralCode, numberOfNights, stayType, validationMessage;
                Random ranNo = new Random();
                Users data = new Users();
                Queries.GetMemberLevel(data, 2);

                //Retrive data from test data
                referralCode = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "ReferralCode"), ranNo.Next().ToString());
                numberOfNights = TestData.ExcelData.TestDataReader.ReadData(1, "NumberOfNights");
                stayType = TestData.ExcelData.TestDataReader.ReadData(1, "StayType");
                validationMessage = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage");


                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                // Click on cancel after entering data in required fields
                Admin.Click_Menu_LoyaltyRules();
                Logger.WriteDebugMessage("Loyalty Rules tab clicked");
                Admin.Click_LoyaltyRules_MemberLevelRules_Tab();
                Logger.WriteDebugMessage("Member Level rules tab clicked");
                Admin.MemberLevelRules_AddRule(referralCode, numberOfNights, stayType, data.MembershipLevel);
                Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_CancelButton();
                Logger.WriteDebugMessage("Clicked on cancel button");
                Admin.Click_LoyaltyRules_MemberLevelRules_Filters(referralCode);
                VerifyTextOnPageAndHighLight(validationMessage);
                Logger.WriteDebugMessage(validationMessage + " = User should not able to see recently canceled rule");

                //Click on Add rule after Cancel, Previously entered value should not get display
                Admin.Click_LoyaltyRules_MemberLevelRules_AddRule();

                if ((!(Helper.GetText(PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_RefferalCode()).Equals(referralCode))))
                    Logger.WriteDebugMessage("All the fileds are empty");


                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Referral Code", referralCode);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Number Of Nights", numberOfNights);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Stay Type", stayType);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "New Level", data.MembershipLevel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Validation Message", validationMessage, true);
            }
        }

        public static void TC_217878()
        {
            if (TestCaseId == Constants.TC_217878)
            {
                //pre-requiste
                string referralCode, numberOfNights, stayType, referralCode_Edit, numberOfNights_Edit, stayType_Edit;
                Random ranNo = new Random();
                Users data = new Users();
                Queries.GetMemberLevel(data, 2);

                //Retrive data from test data
                referralCode = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "ReferralCode"), ranNo.Next().ToString());
                numberOfNights = TestData.ExcelData.TestDataReader.ReadData(1, "NumberOfNights");
                stayType = TestData.ExcelData.TestDataReader.ReadData(1, "StayType");
                referralCode_Edit = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "ReferralCode_Edit"), ranNo.Next().ToString());
                numberOfNights_Edit = TestData.ExcelData.TestDataReader.ReadData(1, "NumberOfNights_Edit");
                stayType_Edit = TestData.ExcelData.TestDataReader.ReadData(1, "StayType_Edit");


                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                // Click on Edit button for any added rule from Member level grid
                string level1 = data.MembershipLevel;
                Admin.Click_Menu_LoyaltyRules();
                Logger.WriteDebugMessage("Loyalty Rules tab clicked");
                Admin.Click_LoyaltyRules_MemberLevelRules_Tab();
                Logger.WriteDebugMessage("Member Level rules tab clicked");
                Admin.MemberLevelRules_AddRule(referralCode, numberOfNights, stayType, level1);
                Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_SaveButton();
                Logger.WriteDebugMessage("Clicked on save button and saved successfully");

                // Enter details for edit rule
                Queries.GetMemberLevel(data, 3);
                string level2 = data.MembershipLevel;
                Admin.Click_LoyaltyRules_MemberLevelRules_Filters(referralCode);
                Logger.WriteDebugMessage(referralCode + " got displayed on the page");
                Admin.MemberLevelRules_EditRule(referralCode_Edit, numberOfNights_Edit, stayType_Edit, level2);

                // Delete recently added member rule
                Admin.MemberLevelRules_DeleteRule(referralCode_Edit);

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Referral Code", referralCode);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Number Of Nights", numberOfNights);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Stay Type", stayType);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Level 1", level1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Edited Referral Code", referralCode_Edit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Edited Number Of Nights", numberOfNights_Edit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Edited Stay Type", stayType_Edit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Level 2", level2, true);
            }
        }
        public static void TC_217879()
        {
            if (TestCaseId == Constants.TC_217879)
            {
                //pre-requiste
                string referralCode, numberOfNights, stayType, validationMessage;
                Random ranNo = new Random();
                Users data = new Users();
                Queries.GetMemberLevel(data, 2);

                //Retrive data from test data
                referralCode = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "ReferralCode"), ranNo.Next().ToString());
                numberOfNights = TestData.ExcelData.TestDataReader.ReadData(1, "NumberOfNights");
                stayType = TestData.ExcelData.TestDataReader.ReadData(1, "StayType");


                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                // Validate delete functionality for member rule
                Admin.Click_Menu_LoyaltyRules();
                Logger.WriteDebugMessage("Loyalty Rules tab clicked");
                Admin.Click_LoyaltyRules_MemberLevelRules_Tab();
                Logger.WriteDebugMessage("Member Level rules tab clicked");
                Admin.MemberLevelRules_AddRule(referralCode, numberOfNights, stayType, data.MembershipLevel);
                Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_SaveButton();
                Logger.WriteDebugMessage("Clicked on save button and rule saved successfully");

                //Verify the Cancle button functinality on Delete Overlay
                Admin.Click_LoyaltyRules_MemberLevelRules_Filters(referralCode);
                Admin.Click_LoyaltyRules_MemberLevelRules_DeleteButton();
                Logger.WriteDebugMessage("Delete confirmation pop up get displayed");
                Admin.Click_LoyaltyRules_MemberLevelRules_DeleteCancle();
                if (Helper.IsElementRemoved(referralCode))
                    Logger.WriteDebugMessage("Member Level Rule got Displayed after clicking on Cancel button");
                else
                    Assert.Fail("Member level rule got deleted even after clicking on Cancel button");

                //Delete the added Member level rule 
                Admin.MemberLevelRules_DeleteRule(referralCode);


                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Referral Code", referralCode);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Number Of Nights", numberOfNights);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Stay Type", stayType);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "New Level", data.MembershipLevel, true);
            }
        }
        public static void TC_218238()
        {
            if (TestCaseId == Constants.TC_218238)
            {
                //pre-requiste
                string referralCode, numberOfNights, stayType, validationMessage;
                Random ranNo = new Random();
                Users data = new Users();
                Queries.GetMemberLevel(data, 2);

                //Retrive data from test data
                referralCode = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "ReferralCode"), ranNo.Next().ToString());
                numberOfNights = TestData.ExcelData.TestDataReader.ReadData(1, "NumberOfNights");
                stayType = TestData.ExcelData.TestDataReader.ReadData(1, "StayType");
                validationMessage = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage");


                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                // Add member rule 
                Admin.Click_Menu_LoyaltyRules();
                Logger.WriteDebugMessage("Loyalty Rules tab clicked");
                Admin.Click_LoyaltyRules_MemberLevelRules_Tab();
                Logger.WriteDebugMessage("Member Level rules tab clicked");
                Admin.MemberLevelRules_AddRule(referralCode, numberOfNights, stayType, data.MembershipLevel);
                Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_SaveButton();
                Logger.WriteDebugMessage("Clicked on save button and member rule saved successfully");

                // Try to add member rule with same Member level
                Admin.MemberLevelRules_AddRule(referralCode, numberOfNights, stayType, data.MembershipLevel);
                Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_SaveButton();
                VerifyTextOnPageAndHighLight(validationMessage);
                Logger.WriteDebugMessage(validationMessage + " = Validation message displayed");
                Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_CancelButton();

                // Delete recently added member rule
                Admin.MemberLevelRules_DeleteRule(referralCode);

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Referral Code", referralCode);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Number Of Nights", numberOfNights);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Stay Type", stayType);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "New Level", data.MembershipLevel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Validation Message", validationMessage, true);
            }
        }
        public static void TC_217874()
        {
            if (TestCaseId == Constants.TC_217874)
            {

                //pre-requiste
                string referralCode, numberOfNights, stayType, referralValidation, nightValidation, stayTypeValidation, newLevelValidation;
                Random ranNo = new Random();
                Users data = new Users();
                Queries.GetMemberLevel(data, 2);

                //Retrive data from test data
                referralCode = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "ReferralCode"), ranNo.Next().ToString());
                numberOfNights = TestData.ExcelData.TestDataReader.ReadData(1, "NumberOfNights");
                stayType = TestData.ExcelData.TestDataReader.ReadData(1, "StayType");
                referralValidation = TestData.ExcelData.TestDataReader.ReadData(1, "ReferralValidation");
                nightValidation = TestData.ExcelData.TestDataReader.ReadData(1, "NightValidation");
                stayTypeValidation = TestData.ExcelData.TestDataReader.ReadData(1, "StayValidation");
                newLevelValidation = TestData.ExcelData.TestDataReader.ReadData(1, "NewLevelValidation");
                
                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                // Add member rule 
                Admin.Click_Menu_LoyaltyRules();
                Logger.WriteDebugMessage("Loyalty Rules tab clicked");
                Admin.Click_LoyaltyRules_MemberLevelRules_Tab();
                Logger.WriteDebugMessage("Member Level rules tab clicked");

                //Verify the Required Filed Validation.
                Admin.Click_LoyaltyRules_MemberLevelRules_AddRule();
                Logger.WriteDebugMessage("Clicked on Add Rule button");
                Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_SaveButton();
                VerifyTextOnPageAndHighLight(referralValidation);
                Logger.WriteDebugMessage("Validation message for Referal code got Displayed");

                //Verify the Max Char Limit for Referal Code and Night Validation
                if (PageObject_Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_RefferalCode().GetAttribute("maxlength").Equals("30"))
                    Logger.WriteDebugMessage("Referral Code field can not exceeded to more than 30 character");
                else
                    Assert.Fail("Referral Code field can exceeded to more than 30 character");

                Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_RefferalCode(referralCode);
                Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_SaveButton();
                VerifyTextOnPageAndHighLight(nightValidation);
                Logger.WriteDebugMessage("Validation message for Qualifying Night got Displayed");

                Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_QualifyingNights(numberOfNights);
                Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_SaveButton();
                VerifyTextOnPageAndHighLight(stayTypeValidation);
                Logger.WriteDebugMessage("Validation message for Stay Type got Displayed");

                Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_StayType(stayType);
                Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_SaveButton();
                VerifyTextOnPageAndHighLight(newLevelValidation);
                Logger.WriteDebugMessage("Validation message for New Level got Displayed");
                Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_CancelButton();
                Logger.WriteDebugMessage("Landed on Member Level Rule Tab");

                //Add New member Level Rule
                Admin.MemberLevelRules_AddRule(referralCode, numberOfNights, stayType, data.MembershipLevel);
                Admin.Click_LoyaltyRules_MemberLevelRules_AddRule_SaveButton();
                VerifyTextOnPageAndHighLight(referralCode);
                Logger.WriteDebugMessage("Clicked on save button and member rule saved successfully");

                //Verify the details in Database
                Queries.GetMemberLevelRuleDetails(data, referralCode);
                if (data.ReferralCode.Equals(referralCode) && data.NightNumber.Equals(numberOfNights) && data.StayTypeId.Equals(1.ToString()) && data.MemberLevelId.Equals(2.ToString()))
                    Logger.WriteInfoMessage("Member Level Rule Details are added succesfullly in Database");
                else
                    Assert.Fail("Member Level Rule Details are not added in Database");
                
                //Delete Membership Level Rule
                Admin.MemberLevelRules_DeleteRule(referralCode);

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Referral Code", referralCode);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Number Of Nights", numberOfNights);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Stay Type", stayType);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "New Level", data.MembershipLevel);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Referral Validation", referralValidation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Night Validation", nightValidation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Stay Type Validation", stayTypeValidation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "New Level Validation", newLevelValidation, true);
                
            }
        }
    }
}