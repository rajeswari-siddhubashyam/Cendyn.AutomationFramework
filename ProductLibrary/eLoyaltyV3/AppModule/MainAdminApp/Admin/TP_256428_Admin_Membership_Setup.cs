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
using AventStack.ExtentReports.Model;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region TP_256428 - Admin - Membership_Setup
        private static void TC_255553()
        {
            if (TestCaseId == Constants.TC_255553)
            {
                //pre-requiste
                string membershipLevel_Name, membershipCode, memberLevel_Order, membershipLevel_Name_validation_message, membershipCode_validation_message, memberLevel_Order_validation_message;
                Random ranno = new Random();

                //Retrieve data from database
                membershipLevel_Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Name"), ranno.Next().ToString().Substring(0, 3));
                membershipCode = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Code"),ranno.Next().ToString().Substring(0, 3));
                memberLevel_Order = ranno.Next().ToString().Substring(0, 3);
                membershipLevel_Name_validation_message = TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Name_Validation");
                membershipCode_validation_message = TestData.ExcelData.TestDataReader.ReadData(1, "MembershipCode_Validation");
                memberLevel_Order_validation_message = TestData.ExcelData.TestDataReader.ReadData(1, "MemberLevel_Order_Validation");

                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Helper.ElementWait(PageObject_Admin.Click_MembershipSetup_Tab(), 120);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Click on Membership Setup tab and Member level sub tab
                Admin.Click_MembershipSetup_Tab();
                Helper.ElementWait(PageObject_Admin.Click_MemberLevel_SubTab(), 120);
                Logger.WriteDebugMessage("Clicked on Membership Setup tab");
                Admin.Click_MemberLevel_SubTab();
                Logger.WriteInfoMessage("Clicked on Membership Level tab");

                //Verify the Required Field Validation
                Admin.RequiredField_AddMembershipLevel(membershipLevel_Name, membershipCode, memberLevel_Order, membershipLevel_Name_validation_message, membershipCode_validation_message, memberLevel_Order_validation_message);

                //Delete Added Membership Level
                Admin.Delete_MembershipLevel(membershipLevel_Name);

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Name", membershipLevel_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Code", membershipCode);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "member Level Order", memberLevel_Order);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "MemberLevelName_ValidationMessage", membershipLevel_Name_validation_message);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "MemberLevelCode_ValidationMessage", membershipCode_validation_message);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "MemberLevelOrder_ValidationMessage", memberLevel_Order_validation_message, true);

            }
        }
        private static void TC_255554()
        {
            if (TestCaseId == Constants.TC_255554)
            {
                //pre-requiste
                string membershipLevel_Name, membershipCode, memberLevel_Order, processByService;
                Random ranno = new Random();

                //Retrive data from database
                membershipLevel_Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Name"), ranno.Next().ToString().Substring(0, 3));
                membershipCode = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Code"), ranno.Next().ToString().Substring(0, 3));
                memberLevel_Order = ranno.Next().ToString().Substring(0, 3);
                processByService = TestData.ExcelData.TestDataReader.ReadData(1, "Process_By_Service");

                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Helper.ElementWait(PageObject_Admin.Click_MembershipSetup_Tab(), 120);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Click on Membership Setup tab and Member level sub tab
                Admin.Click_MembershipSetup_Tab();
                Helper.ElementWait(PageObject_Admin.Click_MemberLevel_SubTab(), 120);
                Logger.WriteDebugMessage("Clicked on Membership Setup tab");
                Admin.Click_MemberLevel_SubTab();
                Logger.WriteInfoMessage("Clicked on Membership Level tab");

                //Verify the Add Membership Level Functinality
                Admin.AddMembershipLevel(membershipLevel_Name, membershipCode, memberLevel_Order, processByService);

                //Delete Added Membership Level
                Admin.Delete_MembershipLevel(membershipLevel_Name);

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Name", membershipLevel_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Code", membershipCode);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Order", memberLevel_Order);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level ProcessByService", processByService, true);

            }
        }
        private static void TC_255556()
        {
            if (TestCaseId == Constants.TC_255556)
            {
                //pre-requiste
                string membershipLevel_Name, membershipCode, memberLevel_Order, processByService;
                Random ranno = new Random();

                //Retrive data from database
                membershipLevel_Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Name"), ranno.Next().ToString().Substring(0, 3));
                membershipCode = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Code"), ranno.Next().ToString().Substring(0, 3));
                memberLevel_Order = ranno.Next().ToString().Substring(0, 3);
                processByService = TestData.ExcelData.TestDataReader.ReadData(1, "Process_By_Service");

                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Helper.ElementWait(PageObject_Admin.Click_MembershipSetup_Tab(), 120);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Click on Membership Setup tab and Member level sub tab
                Admin.Click_MembershipSetup_Tab();
                Helper.ElementWait(PageObject_Admin.Click_MemberLevel_SubTab(), 120);
                Logger.WriteDebugMessage("Clicked on Membership Setup tab");
                Admin.Click_MemberLevel_SubTab();
                Logger.WriteInfoMessage("Clicked on Membership Level tab");

                //Verify the Cancel Buttonn Functinality
                Admin.MembershipSetup_AddMemershipLevel_Button();
                Logger.WriteDebugMessage("Clicked on Add Membership level button and Overlay got open");
                Admin.AddMemershipLevel_MembershipLevel(membershipLevel_Name);
                Admin.AddMemershipLevel_MembershipCode(membershipCode);
                Admin.AddMemershipLevel_LevelOrder(memberLevel_Order);
                Admin.AddMemershipLevel_CanBeProcessedByService_DDM(processByService);
                Logger.WriteDebugMessage("All the Details are entered correctly");
                Admin.Click_AddMemershipLevel_CancelButton();
                if (IsElementRemoved(membershipLevel_Name))
                    Assert.Fail("Membership Level got added Succesfully Even if clicked on Cancel button");
                else
                    Logger.WriteDebugMessage("Membership Level does not added after clicking on Cancel button");


                // Verify the Cross button Functinality
                Admin.MembershipSetup_AddMemershipLevel_Button();
                Logger.WriteDebugMessage("Clicked on Add Membership level button and Overlay got open");
                Admin.AddMemershipLevel_MembershipLevel(membershipLevel_Name);
                Admin.AddMemershipLevel_MembershipCode(membershipCode);
                Admin.AddMemershipLevel_LevelOrder(memberLevel_Order);
                Admin.AddMemershipLevel_CanBeProcessedByService_DDM(processByService);
                Logger.WriteDebugMessage("All the Details are entered correctly");
                Admin.Click_AddMemershipLevel_Close();
                if (IsElementRemoved(membershipLevel_Name))
                    Assert.Fail("Membership Level got added Succesfully Even if clicked on cross icon of Pop-up");
                else
                    Logger.WriteDebugMessage("Membership Level does not added after clicking on cross icon of pop-up");

                //Add Membership Level Functinality
                Admin.AddMembershipLevel(membershipLevel_Name, membershipCode, memberLevel_Order, processByService);

                //Delete Added Membership Level
                Admin.Delete_MembershipLevel(membershipLevel_Name);

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Name", membershipLevel_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Code", membershipCode);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Order", memberLevel_Order);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level ProcessByService", processByService, true);
            }
        }
        private static void TC_255563()
        {
            if (TestCaseId == Constants.TC_255563)
            {
                //pre-requiste
                string membershipLevel_Name, membershipCode, memberLevel_Order, processByService;
                Random ranno = new Random();
                Users data = new Users();

                //Retrive data from database
                membershipLevel_Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Name"), ranno.Next().ToString().Substring(0, 3));
                membershipCode = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Code"), ranno.Next().ToString().Substring(0, 3));
                memberLevel_Order = ranno.Next().ToString().Substring(0, 3);
                processByService = TestData.ExcelData.TestDataReader.ReadData(1, "Process_By_Service");

                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Helper.ElementWait(PageObject_Admin.Click_MembershipSetup_Tab(), 120);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Click on Membership Setup tab and Member level sub tab
                Admin.Click_MembershipSetup_Tab();
                Helper.ElementWait(PageObject_Admin.Click_MemberLevel_SubTab(), 120);
                Logger.WriteDebugMessage("Clicked on Membership Setup tab");
                Admin.Click_MemberLevel_SubTab();
                Logger.WriteInfoMessage("Clicked on Membership Level tab");

                //Verify the Add Membership Level Functinality
                Admin.AddMembershipLevel(membershipLevel_Name, membershipCode, memberLevel_Order, processByService);


                //Verify the Cancel Button Functionality of Delete Overlay
                Helper.VerifyTextOnPageAndHighLight(membershipLevel_Name);
                Admin.Click_AddMemershipLevel_DeleteButton(membershipLevel_Name);
                Helper.ElementWait(PageObject_Admin.Click_DeleteMemershipLevel_CancelButton(), 120);
                Logger.WriteDebugMessage("Clicked on Delete button for " + membershipLevel_Name + " and Delete Overlay got displayed");
                Admin.Click_DeleteMemershipLevel_CancelButton();
                Helper.AddDelay(5000);
                if (Helper.IsElementRemoved(membershipLevel_Name))
                    Logger.WriteDebugMessage("Membership Level not get Deleted as Clicked on Cancel button");
                else
                    Assert.Fail("Membership Level got Deleted even if clicked on Deleted button");


                //Delete Added Membership Level
                Admin.Delete_MembershipLevel(membershipLevel_Name);

                //Verify the Status for Membership Level in Database
                Queries.GetMembershipStatus(data, membershipLevel_Name);
                if (data.Active == "False")
                    Logger.WriteInfoMessage("Membership status for Member level = " + membershipLevel_Name + " in database is inactive");
                else
                    Assert.Fail("Membership status for Member level = " + membershipLevel_Name + " in database is Active");

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Name", membershipLevel_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Code", membershipCode);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Order", memberLevel_Order);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level ProcessByService", processByService, true);

            }
        }
        public static void TC_255557()
        {
            if (TestCaseId == Constants.TC_255557)
            {
                //Pre-requisite
                string memberLevelName, memberLevelCode, memberLevelOrder, service, error_LevelOrder1, error_LevelOrder2, errorMessage_MemberLevel, errorMessage_MemberCode, field = null;
                Random ranno = new Random();

                //Assign Values to variables
                memberLevelName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MemberLevelName"), ranno.Next().ToString().Substring(0, 3));
                memberLevelCode = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MemberLevelCode"), ranno.Next().ToString().Substring(0, 3));
                memberLevelOrder = ranno.Next().ToString().Substring(0, 3);
                error_LevelOrder1 = TestData.ExcelData.TestDataReader.ReadData(1, "Error_LevelOrder1");
                error_LevelOrder2 = TestData.ExcelData.TestDataReader.ReadData(1, "Error_LevelOrder2");
                errorMessage_MemberLevel = TestData.ExcelData.TestDataReader.ReadData(1, "ErrorMessage_MemberLevel");
                errorMessage_MemberCode = TestData.ExcelData.TestDataReader.ReadData(1, "ErrorMessage_MemberCode");

                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Click on Membership Setup tab and Member level sub tab
                Admin.Click_MembershipSetup_Tab();
                Logger.WriteDebugMessage("Clicked on Membership Setup tab");
                Admin.Click_MemberLevel_SubTab();
                Admin.MembershipSetup_AddMemershipLevel_Button();
                Logger.WriteDebugMessage("Add Member Level button clicked");

                //Click on Add membership level and Validate Membership Level field
                Admin.Click_AddMemershipLevel_SaveButton();
                VerifyTextOnPageAndHighLight(errorMessage_MemberLevel);
                Logger.WriteDebugMessage("Validation message for Membership Level textbox got displayed");
                Admin.AddMemershipLevel_MembershipCode(memberLevelCode);
                for (int i = 1; i < 5; i++)
                {
                    field = TestData.ExcelData.TestDataReader.ReadData(i, "Field");
                    Admin.AddMemershipLevel_MembershipLevel(memberLevelName + field);
                    Admin.AddMemershipLevel_LevelOrder(memberLevelOrder);
                    Logger.WriteDebugMessage((memberLevelName + field) + " = Entered into Membership Name Field");
                    Admin.Click_AddMemershipLevel_SaveButton();
                    AddDelay(3000);
                    Admin.Enter_MembershipLevel_Filter(memberLevelName);
                    Logger.WriteDebugMessage((memberLevelName + field) + " = Scenario for Membership Level name Validated successfuly");
                    Admin.Click_AddMemershipLevel_EditeButton(memberLevelName + field);
                }
                Admin.AddMemershipLevel_MembershipLevel("                ");
                Admin.AddMemershipLevel_LevelOrder(memberLevelOrder);
                Logger.WriteDebugMessage("Blank Space entered into Membership Level Name field");
                Admin.Click_AddMemershipLevel_SaveButton();
                VerifyTextOnPageAndHighLight(errorMessage_MemberLevel);
                Logger.WriteDebugMessage(errorMessage_MemberLevel + " - error message displaying on the page");
                Admin.Click_AddMemershipLevel_CancelButton();
                Admin.Delete_MembershipLevel(memberLevelName + field);


                // Validate Membership Code field
                for (int i = 1; i < 5; i++)
                {
                    field = TestData.ExcelData.TestDataReader.ReadData(i, "Field");
                    Admin.MembershipSetup_AddMemershipLevel_Button();
                    Admin.AddMemershipLevel_MembershipLevel(memberLevelName);
                    Admin.AddMemershipLevel_MembershipCode(memberLevelCode + field);
                    Admin.AddMemershipLevel_LevelOrder(memberLevelOrder);
                    Logger.WriteDebugMessage((memberLevelCode + field) + " = Membership Level Entered");
                    Admin.Click_AddMemershipLevel_SaveButton();
                    AddDelay(3000);
                    Admin.Enter_MembershipLevel_Filter(memberLevelName);
                    Logger.WriteDebugMessage((memberLevelCode + field) + " = Scenario for Membership Code Validated successfuly");
                    Helper.VerifyTextOnPageAndHighLight(memberLevelName);
                    Admin.Click_AddMemershipLevel_DeleteButton(memberLevelName);
                    Logger.WriteDebugMessage("Delete Membership Level confirmation pop up displayed");
                    Admin.Click_DeleteMemershipLevel_SubmitButton();
                }
                Admin.MembershipSetup_AddMemershipLevel_Button();
                Admin.AddMemershipLevel_MembershipLevel(memberLevelName);
                Admin.AddMemershipLevel_MembershipCode("          ");
                Admin.AddMemershipLevel_LevelOrder(memberLevelOrder);
                Logger.WriteDebugMessage("Blank Space entered into Membership Code field");
                Admin.Click_AddMemershipLevel_SaveButton();
                VerifyTextOnPageAndHighLight(errorMessage_MemberCode);
                Logger.WriteDebugMessage(errorMessage_MemberCode + " - error message displaying on the page");
                Admin.Click_AddMemershipLevel_CancelButton();


                // Validate Level order field
                Admin.MembershipSetup_AddMemershipLevel_Button();
                Admin.AddMemershipLevel_MembershipCode(memberLevelCode);
                for (int i = 2; i < 4; i++)
                {
                    field = TestData.ExcelData.TestDataReader.ReadData(i, "Field");
                    Admin.AddMemershipLevel_MembershipLevel(memberLevelName);
                    Admin.AddMemershipLevel_LevelOrder(memberLevelOrder + field);
                    Logger.WriteDebugMessage((memberLevelOrder + field) + " = Membership Level Order Entered");
                    Admin.Click_AddMemershipLevel_SaveButton();
                    AddDelay(3000);
                    Logger.WriteDebugMessage((memberLevelOrder + field) + " = Scenario for Membership Order Validated successfuly");
                    Admin.Enter_MembershipLevel_Filter(memberLevelName);
                    Admin.Click_AddMemershipLevel_EditeButton(memberLevelName);
                }
                field = TestData.ExcelData.TestDataReader.ReadData(4, "Field");
                Admin.AddMemershipLevel_MembershipLevel(memberLevelName);
                Admin.AddMemershipLevel_LevelOrder(field);
                Logger.WriteDebugMessage(field + " = Entered into Membership Level Order Field");
                Admin.Click_AddMemershipLevel_SaveButton();
                VerifyTextOnPageAndHighLight(error_LevelOrder1);
                Logger.WriteDebugMessage(error_LevelOrder1 + " = Error message displaying on the page");

                field = TestData.ExcelData.TestDataReader.ReadData(5, "Field");
                Admin.AddMemershipLevel_MembershipLevel(memberLevelName);
                Admin.AddMemershipLevel_LevelOrder(field);
                Logger.WriteDebugMessage(field + " = Entered into Membership Level Order Field");
                Admin.Click_AddMemershipLevel_SaveButton();
                VerifyTextOnPageAndHighLight(error_LevelOrder2);
                Logger.WriteDebugMessage(error_LevelOrder1 + " = Error message displaying on the page");
                Admin.Click_AddMemershipLevel_CancelButton();
                Admin.Click_AddMemershipLevel_DeleteButton(memberLevelName);
                Logger.WriteDebugMessage("Delete Membership Level confirmation pop up displayed");
                Admin.Click_DeleteMemershipLevel_SubmitButton();

                // Validate 'Can be processed by Service' field
                Admin.MembershipSetup_AddMemershipLevel_Button();
                Admin.AddMemershipLevel_MembershipCode(memberLevelCode);
                for (int i = 1; i < 3; i++)
                {
                    service = TestData.ExcelData.TestDataReader.ReadData(i, "Service");
                    Admin.AddMemershipLevel_MembershipLevel(memberLevelName);
                    Admin.AddMemershipLevel_LevelOrder(memberLevelOrder);
                    Admin.AddMemershipLevel_CanBeProcessedByService_DDM(service);
                    Logger.WriteDebugMessage(service + " = Can be Processed by Service Value got Entered");
                    Admin.Click_AddMemershipLevel_SaveButton();
                    AddDelay(3000);
                    Logger.WriteDebugMessage("Membership level Saved Successfully with Processed by Serice = " + service);
                    Admin.Enter_MembershipLevel_Filter(memberLevelName);
                    Admin.Click_AddMemershipLevel_EditeButton(memberLevelName);
                }
                Admin.Click_AddMemershipLevel_CancelButton();
                Admin.Click_AddMemershipLevel_DeleteButton(memberLevelName);
                Logger.WriteDebugMessage("Delete Membership Level confirmation pop up displayed");
                Admin.Click_DeleteMemershipLevel_SubmitButton();


                //Log test data into log file and extent report
                Logger.LogTestData(TestPlanId, TestCaseId, "Member Level Name", memberLevelName);
                Logger.LogTestData(TestPlanId, TestCaseId, "Member Level Code", memberLevelCode);
                Logger.LogTestData(TestPlanId, TestCaseId, "member Level Order", memberLevelOrder);
                Logger.LogTestData(TestPlanId, TestCaseId, "ErrorMessage_MemberLevel", errorMessage_MemberLevel);
                Logger.LogTestData(TestPlanId, TestCaseId, "ErrorMessage_MemberCode", errorMessage_MemberCode);
                Logger.LogTestData(TestPlanId, TestCaseId, "Error_LevelOrder1", error_LevelOrder1);
                Logger.LogTestData(TestPlanId, TestCaseId, "Error_LevelOrder2", error_LevelOrder2, true);

            }
        }
        public static void TC_255559()
        {
            if (TestCaseId == Constants.TC_255559)
            {
                //Pre-requisite
                string memberLevelName, memberLevelName_Duplicate, memberLevelCode, memberLevelCode_Duplicate, memberLevelOrder_Duplicate, memberLevelOrder, service, validationMessage_MemberLevel, validationMessage_Code, validationMessage_LevelOrder;
                Random no = new Random();
                Users data = new Users();
                Queries.GetActiveMembershipLevel(data);
                //Assign Values to variables
                memberLevelName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MemberLevelName"), no.Next().ToString().Substring(0, 3));
                memberLevelName_Duplicate = data.MembershipLevelName;
                memberLevelCode = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MemberLevelCode"), no.Next().ToString().Substring(0, 3));
                memberLevelCode_Duplicate = data.MembershipCode;
                memberLevelOrder = no.Next().ToString().Substring(0, 3);
                memberLevelOrder_Duplicate = data.LevelOrder;
                service = TestData.ExcelData.TestDataReader.ReadData(1, "Service");
                validationMessage_MemberLevel = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage_MemberLevel");
                validationMessage_Code = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage_Code");
                validationMessage_LevelOrder = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage_LevelOrder");

                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Click on Membership Setup tab and Member level sub tab
                Admin.Click_MembershipSetup_Tab();
                Logger.WriteDebugMessage("Clicked on Membership Setup tab");
                Admin.Click_MemberLevel_SubTab();
                Admin.MembershipSetup_AddMemershipLevel_Button();
                Logger.WriteDebugMessage("Add Member Level button clicked");

                //Enter values in all fields and enter duplicate value in Membership Level field
                Admin.AddMemershipLevel_MembershipLevel(memberLevelName_Duplicate);
                Admin.AddMemershipLevel_MembershipCode(memberLevelCode);
                Admin.AddMemershipLevel_LevelOrder(memberLevelOrder);
                Admin.AddMemershipLevel_CanBeProcessedByService_DDM(service);
                Logger.WriteDebugMessage("Mandatory fields entered with duplicate Member level");
                Admin.Click_AddMemershipLevel_SaveButton();
                VerifyTextOnPageAndHighLight(validationMessage_MemberLevel);
                Logger.WriteDebugMessage(validationMessage_MemberLevel + " - Validation message displayed on the page for Member Level");

                //Enter values in all fields and enter duplicate value in Membership Code field
                Admin.AddMemershipLevel_MembershipLevel(memberLevelName);
                Admin.AddMemershipLevel_MembershipCode(memberLevelCode_Duplicate);
                Logger.WriteDebugMessage("Mandatory fields entered with duplicate Membership Code");
                Admin.Click_AddMemershipLevel_SaveButton();
                VerifyTextOnPageAndHighLight(validationMessage_Code);
                Logger.WriteDebugMessage(validationMessage_Code + " - Validation message displayed on the page for Membership code");

                //Enter values in all fields and enter duplicate value in Level order field
                Admin.AddMemershipLevel_MembershipCode(memberLevelCode);
                Admin.AddMemershipLevel_LevelOrder(memberLevelOrder_Duplicate);
                Logger.WriteDebugMessage("Mandatory fields entered with duplicate Level Order");
                Admin.Click_AddMemershipLevel_SaveButton();
                VerifyTextOnPageAndHighLight(validationMessage_LevelOrder);
                Logger.WriteDebugMessage(validationMessage_LevelOrder + " - Validation message displayed on the page for Level Order");
                AddDelay(3000);
                Admin.AddMemershipLevel_MembershipLevel(memberLevelName);
                Admin.AddMemershipLevel_LevelOrder(memberLevelOrder);
                Logger.WriteDebugMessage("All Mandatory fields entered");
                Admin.Click_AddMemershipLevel_SaveButton();
                AddDelay(3000);
                Admin.Enter_MembershipLevel_Filter(memberLevelName);
                VerifyTextOnPageAndHighLight(memberLevelName);
                Logger.WriteDebugMessage("Membership Level Saved Successfully");


                //Click on Edit for any existing level & try adding duplicate fields
                Admin.Click_AddMemershipLevel_EditeButton(memberLevelName);
                Logger.WriteDebugMessage("Clicked on Edit buttonn for = " + memberLevelName);
                Admin.AddMemershipLevel_MembershipLevel(memberLevelName_Duplicate);
                Admin.AddMemershipLevel_LevelOrder(memberLevelOrder);
                Logger.WriteDebugMessage("Mandatory fields entered with duplicate Member level");
                Admin.Click_AddMemershipLevel_SaveButton();
                VerifyTextOnPageAndHighLight(validationMessage_MemberLevel);
                Logger.WriteDebugMessage(validationMessage_MemberLevel + " - Validation message displayed on the page for Member Level on Edit mode");

                Admin.AddMemershipLevel_MembershipLevel(memberLevelName);
                Admin.AddMemershipLevel_LevelOrder(memberLevelOrder_Duplicate);
                Logger.WriteDebugMessage("Mandatory fields entered with duplicate Level Order");
                Admin.Click_AddMemershipLevel_SaveButton();
                VerifyTextOnPageAndHighLight(validationMessage_LevelOrder);
                Logger.WriteDebugMessage(validationMessage_LevelOrder + " - Validation message displayed on the page for Level Order on Edit mode");
                Admin.Click_AddMemershipLevel_CancelButton();

                //Delete Membership Level
                Admin.Delete_MembershipLevel(memberLevelName);

                //Log test data into log file and extent report
                Logger.LogTestData(TestPlanId, TestCaseId, "Member Level Name", memberLevelName);
                Logger.LogTestData(TestPlanId, TestCaseId, "Member Level Code", memberLevelCode);
                Logger.LogTestData(TestPlanId, TestCaseId, "member Level Order", memberLevelOrder);
                Logger.LogTestData(TestPlanId, TestCaseId, "MemberLevelName_Duplicate", memberLevelName_Duplicate);
                Logger.LogTestData(TestPlanId, TestCaseId, "MemberLevelCode_Duplicate", memberLevelCode_Duplicate);
                Logger.LogTestData(TestPlanId, TestCaseId, "MemberLevelOrder_Duplicate", memberLevelOrder_Duplicate);
                Logger.LogTestData(TestPlanId, TestCaseId, "ValidationMessage_MemberLevel", validationMessage_MemberLevel);
                Logger.LogTestData(TestPlanId, TestCaseId, "ValidationMessage_Code", validationMessage_Code);
                Logger.LogTestData(TestPlanId, TestCaseId, "ValidationMessage_LevelOrder", validationMessage_LevelOrder, true);
            }
        }
        public static void TC_255575()
        {
            if (TestCaseId == Constants.TC_255575)
            {
                //Pre-requisite
                string memberLevelName, ruleType = null, defaultRule = null, monthlPeriod, monthlPeriodValidation, qualifiedNight, qualifiedNightValidation, stayProperties, stayPropertiesValidation, qualifiedStay, qualifiedStayValidation, checkOutStay, checkOutStayValidation, points, pointsValidation, revenue, revenueValidation, negativeValidation;
                int levelCount, i;
                Users data = new Users();

                Queries.GetActiveMembershipLevelwithCount(data);

                //Assign Values to variables
                memberLevelName = data.MembershipLevelName;
                monthlPeriodValidation = TestData.ExcelData.TestDataReader.ReadData(1, "MonthPeriod_Validation");
                qualifiedNightValidation = TestData.ExcelData.TestDataReader.ReadData(1, "QualifiedNight_Validation");
                stayPropertiesValidation = TestData.ExcelData.TestDataReader.ReadData(1, "StayProperties_Validation");
                qualifiedStayValidation = TestData.ExcelData.TestDataReader.ReadData(1, "QualifiedStay_Validation");
                checkOutStayValidation = TestData.ExcelData.TestDataReader.ReadData(1, "CheckedOutStay_Validation");
                pointsValidation = TestData.ExcelData.TestDataReader.ReadData(1, "Points_Validation");
                revenueValidation = TestData.ExcelData.TestDataReader.ReadData(1, "Revenue_Validation");


                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Click on Membership Level tab and Captured all Active Level
                Admin.Click_MembershipSetup_Tab();
                Logger.WriteDebugMessage("Clicked on Membership Setup tab");
                Admin.Click_MemberLevel_SubTab();
                Admin.Select_MembershipLevel_Entries("All");
                levelCount = Int32.Parse(data.LevelCount);
                string[] levelArray = new string[levelCount+1];
                for (i = 0; i < levelCount; i++)
                {
                    levelArray[i] = PageObject_Admin.Get_MembershipLevel_Name("" + (i + 1) + "").GetAttribute("innerHTML");
                }
                PageDown();
                Logger.WriteDebugMessage("All membership levels captured");


                //Navigate Member level Rule sub tab
                Admin.Click_Memberlevelrule_Tab();
                Logger.WriteDebugMessage("Clicked on Member Level Rule Tab and Landed on Member Level Rule Page");

                //Click on Add Member Level Rule
                Admin.Click_AddRule_Button();
                Logger.WriteDebugMessage("Landed on Add Member Level Rule overlay");


                //Verify New Rule Level, Rule Type and Default Rule
                //Member Level
                PageObject_Admin.Select_MemberLevel_Dropdown().Click();
                Logger.WriteDebugMessage("Clicked on Member Level Dropdown on Member Level Rule tab");
                for (i = 0; i < levelCount; i++)
                {
                    if (levelArray[i].Equals(PageObject_Admin.Get_MemberLevel_Name("" + (i + 2) + "").GetAttribute("innerHTML")))
                        Logger.WriteInfoMessage(levelArray[i] + " Present in Member Level Dropdown");
                    else
                        Assert.Fail(levelArray[i] + " is not present in Member level Dropdown");
                }

                //Rule Type
                PageObject_Admin.Select_RuleType_Dropdown().Click();
                Logger.WriteDebugMessage("Clicked on Rule Type Dropdown on Member Level Rule tab");
                for (i = 0; i < 2; i++)
                {
                    ruleType = TestData.ExcelData.TestDataReader.ReadData(i, "RuleType");
                    if (ruleType.Equals(PageObject_Admin.Get_Rule_Type("" + (i + 2) + "").GetAttribute("innerHTML")))
                        Logger.WriteInfoMessage(ruleType + " Present in Rule Type Dropdown on Member Level Rule Overlay");
                    else
                        Assert.Fail(ruleType + " is not present in Rule Type Drop Down");
                }

                //Stay Type
                if (PageObject_Admin.Select_StayType_Dropdown().Enabled)
                    Assert.Fail("Stay Type Dropdown is not Disable");
                else
                    Logger.WriteInfoMessage("Stay Type Dropdown is Disable");

                //Default Rule
                PageObject_Admin.Select_DefaultRule_Dropdown().Click();
                Logger.WriteDebugMessage("Clicked on Default Rule dropdown on Member Level Rule tab");
                for (i = 0; i < 2; i++)
                {
                    defaultRule = TestData.ExcelData.TestDataReader.ReadData(i, "DefaultRule");
                    if (defaultRule.Equals(PageObject_Admin.Get_Default_Rule("" + (i + 1) + "").GetAttribute("innerHTML")))
                        Logger.WriteInfoMessage(defaultRule + " Present in Default Rule Dropdown on Member Level Rule Overlay");
                    else
                        Assert.Fail(defaultRule + " is not present in Default Rule Drop Down");
                }

                //Validate Month Period field
                Admin.Select_MemberLevel_Dropdown(memberLevelName);
                Admin.Select_RuleType_Dropdown(ruleType);
                Admin.Select_DefaultRule_Dropdown(defaultRule);
                for (i = 1; i <= 5; i++)
                {
                    monthlPeriod = TestData.ExcelData.TestDataReader.ReadData(i, "MonthPeriod");
                    Admin.Enter_MonthPeriod_TextBox(monthlPeriod);
                    Logger.WriteDebugMessage("All Details with Month Period as = " + monthlPeriod + " Entered");
                    if (i < 5)
                    {
                        Admin.Click_MembershipLevelSave_Button();
                        VerifyTextOnPageAndHighLight(monthlPeriodValidation);
                        Logger.WriteDebugMessage("Validation Message for Month Period got displayed");
                    }
                }

                //Validate Qualifying Nights
                for (i = 1; i <= 5; i++)
                {
                    qualifiedNight = TestData.ExcelData.TestDataReader.ReadData(i, "QualifiedNight");
                    Admin.Enter_QualifyingNight_TextBox(qualifiedNight);
                    Logger.WriteDebugMessage("All Details with Qualifying Night as = " + qualifiedNight + " Entered");
                    if (i < 5)
                    {

                        Admin.Click_MembershipLevelSave_Button();
                        if (i == 4)
                        {
                            negativeValidation = TestData.ExcelData.TestDataReader.ReadData(1, "QualifiedNight_Negative_Validation");
                            VerifyTextOnPageAndHighLight(negativeValidation);
                        }
                        else
                            VerifyTextOnPageAndHighLight(qualifiedNightValidation);
                        Logger.WriteDebugMessage("Validation Message for Qualifying Night got displayed");
                    }
                }

                //Validate Stay Properties
                for (i = 1; i <= 5; i++)
                {
                    stayProperties = TestData.ExcelData.TestDataReader.ReadData(i, "StayProperties");
                    Admin.Enter_StayProperties_TextBox(stayProperties);
                    Logger.WriteDebugMessage("All Details with Stay Properties as = " + stayProperties + " Entered");
                    if (i < 5)
                    {
                        Admin.Click_MembershipLevelSave_Button();
                        if (i == 4)
                        {
                            negativeValidation = TestData.ExcelData.TestDataReader.ReadData(1, "StayProperties_Negative_Validation");
                            VerifyTextOnPageAndHighLight(negativeValidation);
                        }
                        else
                            VerifyTextOnPageAndHighLight(stayPropertiesValidation);
                        Logger.WriteDebugMessage("Validation Message for Stay Properties got displayed");
                    }
                }

                //Validate Qualified Stay
                for (i = 1; i <= 5; i++)
                {
                    qualifiedStay = TestData.ExcelData.TestDataReader.ReadData(i, "QualifiedStay");
                    Admin.Enter_QualifiedStay_TextBox(qualifiedStay);
                    Logger.WriteDebugMessage("All Details with Qualified Stay as = " + qualifiedStay + " Entered");
                    if (i < 5)
                    {
                        Admin.Click_MembershipLevelSave_Button();
                        if (i == 4)
                        {
                            negativeValidation = TestData.ExcelData.TestDataReader.ReadData(1, "QualifiedStay_Negative_Validation");
                            VerifyTextOnPageAndHighLight(negativeValidation);
                        }
                        else
                            VerifyTextOnPageAndHighLight(qualifiedStayValidation);
                        Logger.WriteDebugMessage("Validation Message for Qualified Stay got displayed");
                    }
                }

                //Validate CheckOut Stay
                for (i = 1; i <= 5; i++)
                {
                    checkOutStay = TestData.ExcelData.TestDataReader.ReadData(i, "CheckOutStay");
                    Admin.Enter_CheckedOutStay_TextBox(checkOutStay);
                    Logger.WriteDebugMessage("All Details with Check Out Stay as = " + checkOutStay + " Entered");
                    if (i < 5)
                    {
                        Admin.Click_MembershipLevelSave_Button();
                        if (i == 4)
                        {
                            negativeValidation = TestData.ExcelData.TestDataReader.ReadData(1, "CheckOutStay_Negative_Validation");
                            VerifyTextOnPageAndHighLight(negativeValidation);
                        }
                        else
                            VerifyTextOnPageAndHighLight(checkOutStayValidation);
                        Logger.WriteDebugMessage("Validation Message for Check Out Stay got displayed");
                    }
                }

                //Validate Points
                for (i = 1; i <= 5; i++)
                {
                    points = TestData.ExcelData.TestDataReader.ReadData(i, "Points");
                    Admin.Enter_Points_TextBox(points);
                    Logger.WriteDebugMessage("All Details with Points as = " + points + " Entered");
                    if (i < 5)
                    {
                        Admin.Click_MembershipLevelSave_Button();
                        if (i == 4)
                        {
                            negativeValidation = TestData.ExcelData.TestDataReader.ReadData(1, "Points_Negative_Validation");
                            VerifyTextOnPageAndHighLight(negativeValidation);
                        }
                        else
                            VerifyTextOnPageAndHighLight(pointsValidation);
                        Logger.WriteDebugMessage("Validation Message for Points got displayed");
                    }
                }

                //Validate Revenue
                for (i = 1; i <= 5; i++)
                {
                    revenue = TestData.ExcelData.TestDataReader.ReadData(i, "Revenue");
                    Admin.Enter_Revenue_TextBox(revenue);
                    Logger.WriteDebugMessage("All Details with Revenue as = " + revenue + " Entered");
                    if (i < 5)
                    {

                        Admin.Click_MembershipLevelSave_Button();
                        if (i == 4)
                        {
                            negativeValidation = TestData.ExcelData.TestDataReader.ReadData(1, "Revenue_Negative_Validation");
                            VerifyTextOnPageAndHighLight(negativeValidation);
                        }
                        else
                            VerifyTextOnPageAndHighLight(revenueValidation);
                        Logger.WriteDebugMessage("Validation Message for Revenue got displayed");
                    }
                }

                //Verify the field validation for Edit Member Level Rule
                Admin.Click_MembershipLevelCancel_Button();
                Logger.WriteDebugMessage("Clicked on Cancel button for Add member Level Rule Overlay and Member Level Rule page got displayed");
                Admin.Click_Edit_MembershipLevelRule();
                Logger.WriteDebugMessage("Clicked on Edit button and Edit Memberlevel Rule box got opened");
                //Verify New Rule Level, Rule Type and Default Rule
                //Member Level
                PageObject_Admin.Select_MemberLevel_Dropdown().Click();
                Logger.WriteDebugMessage("Clicked on Member Level Dropdown on Member Level Rule tab");
                for (i = 0; i < levelCount; i++)
                {
                    if (levelArray[i].Equals(PageObject_Admin.Get_MemberLevel_Name("" + (i + 2) + "").GetAttribute("innerHTML")))
                        Logger.WriteInfoMessage(levelArray[i] + " Present in Member Level Dropdown");
                    else
                        Assert.Fail(levelArray[i] + " is not present in Member level Dropdown");
                }
                Logger.WriteDebugMessage("Member Levels present on Add Member level rule tab");

                //Rule Type
                PageObject_Admin.Select_RuleType_Dropdown().Click();
                Logger.WriteDebugMessage("Clicked on Rule Type Dropdown on Member Level Rule tab");
                for (i = 0; i < 2; i++)
                {
                    ruleType = TestData.ExcelData.TestDataReader.ReadData(i, "RuleType");
                    if (ruleType.Equals(PageObject_Admin.Get_Rule_Type("" + (i + 2) + "").GetAttribute("innerHTML")))
                        Logger.WriteInfoMessage(ruleType + " Present in Rule Type Dropdown on Member Level Rule Overlay");
                    else
                        Assert.Fail(ruleType + " is not present in Rule Type Drop Down");
                }
                Logger.WriteDebugMessage("Rule Type present on Add Member level rule tab");

                //Stay Type
                if (PageObject_Admin.Select_StayType_Dropdown().Enabled)
                    Assert.Fail("Stay Type Dropdown is not Disable");
                else
                    Logger.WriteInfoMessage("Stay Type Dropdown is Disable");

                //Default Rule
                PageObject_Admin.Select_DefaultRule_Dropdown().Click();
                Logger.WriteDebugMessage("Clicked on Default Rule dropdown on Member Level Rule tab");
                for (i = 0; i < 2; i++)
                {
                    defaultRule = TestData.ExcelData.TestDataReader.ReadData(i, "DefaultRule");
                    if (defaultRule.Equals(PageObject_Admin.Get_Default_Rule("" + (i + 1) + "").GetAttribute("innerHTML")))
                        Logger.WriteInfoMessage(defaultRule + " Present in Default Rule Dropdown on Member Level Rule Overlay");
                    else
                        Assert.Fail(defaultRule + " is not present in Default Rule Drop Down");
                }
                Logger.WriteDebugMessage("Default Rule present on Add Member level rule tab");

                //Validate Month Period field
                Admin.Select_MemberLevel_Dropdown(memberLevelName);
                Admin.Select_RuleType_Dropdown(ruleType);
                Admin.Select_DefaultRule_Dropdown(defaultRule);
                for (i = 1; i <= 5; i++)
                {
                    monthlPeriod = TestData.ExcelData.TestDataReader.ReadData(i, "MonthPeriod");
                    Admin.Enter_MonthPeriod_TextBox(monthlPeriod);
                    Logger.WriteDebugMessage("All Details with Month Period as = " + monthlPeriod + " Entered");
                    if (i < 5)
                    {
                        Admin.Click_MembershipLevelSave_Button();
                        VerifyTextOnPageAndHighLight(monthlPeriodValidation);
                        Logger.WriteDebugMessage("Validation Message for Month Period got displayed");
                    }
                }

                //Validate Qualifying Nights
                for (i = 1; i <= 5; i++)
                {
                    qualifiedNight = TestData.ExcelData.TestDataReader.ReadData(i, "QualifiedNight");
                    Admin.Enter_QualifyingNight_TextBox(qualifiedNight);
                    Logger.WriteDebugMessage("All Details with Qualifying Night as = " + qualifiedNight + " Entered");
                    if (i < 5)
                    {

                        Admin.Click_MembershipLevelSave_Button();
                        if (i == 4)
                        {
                            negativeValidation = TestData.ExcelData.TestDataReader.ReadData(1, "QualifiedNight_Negative_Validation");
                            VerifyTextOnPageAndHighLight(negativeValidation);
                        }
                        else
                            VerifyTextOnPageAndHighLight(qualifiedNightValidation);
                        Logger.WriteDebugMessage("Validation Message for Qualifying Night got displayed");
                    }
                }

                //Validate Stay Properties
                for (i = 1; i <= 5; i++)
                {
                    stayProperties = TestData.ExcelData.TestDataReader.ReadData(i, "StayProperties");
                    Admin.Enter_StayProperties_TextBox(stayProperties);
                    Logger.WriteDebugMessage("All Details with Stay Properties as = " + stayProperties + " Entered");
                    if (i < 5)
                    {
                        Admin.Click_MembershipLevelSave_Button();
                        if (i == 4)
                        {
                            negativeValidation = TestData.ExcelData.TestDataReader.ReadData(1, "StayProperties_Negative_Validation");
                            VerifyTextOnPageAndHighLight(negativeValidation);
                        }
                        else
                            VerifyTextOnPageAndHighLight(stayPropertiesValidation);
                        Logger.WriteDebugMessage("Validation Message for Stay Properties got displayed");
                    }
                }

                //Validate Qualified Stay
                for (i = 1; i <= 5; i++)
                {
                    qualifiedStay = TestData.ExcelData.TestDataReader.ReadData(i, "QualifiedStay");
                    Admin.Enter_QualifiedStay_TextBox(qualifiedStay);
                    Logger.WriteDebugMessage("All Details with Qualified Stay as = " + qualifiedStay + " Entered");
                    if (i < 5)
                    {
                        Admin.Click_MembershipLevelSave_Button();
                        if (i == 4)
                        {
                            negativeValidation = TestData.ExcelData.TestDataReader.ReadData(1, "QualifiedStay_Negative_Validation");
                            VerifyTextOnPageAndHighLight(negativeValidation);
                        }
                        else
                            VerifyTextOnPageAndHighLight(qualifiedStayValidation);
                        Logger.WriteDebugMessage("Validation Message for Qualified Stay got displayed");
                    }
                }

                //Validate CheckOut Stay
                for (i = 1; i <= 5; i++)
                {
                    checkOutStay = TestData.ExcelData.TestDataReader.ReadData(i, "CheckOutStay");
                    Admin.Enter_CheckedOutStay_TextBox(checkOutStay);
                    Logger.WriteDebugMessage("All Details with Check Out Stay as = " + checkOutStay + " Entered");
                    if (i < 5)
                    {
                        Admin.Click_MembershipLevelSave_Button();
                        if (i == 4)
                        {
                            negativeValidation = TestData.ExcelData.TestDataReader.ReadData(1, "CheckOutStay_Negative_Validation");
                            VerifyTextOnPageAndHighLight(negativeValidation);
                        }
                        else
                            VerifyTextOnPageAndHighLight(checkOutStayValidation);
                        Logger.WriteDebugMessage("Validation Message for Check Out Stay got displayed");
                    }
                }

                //Validate Points
                for (i = 1; i <= 5; i++)
                {
                    points = TestData.ExcelData.TestDataReader.ReadData(i, "Points");
                    Admin.Enter_Points_TextBox(points);
                    Logger.WriteDebugMessage("All Details with Points as = " + points + " Entered");
                    if (i < 5)
                    {
                        Admin.Click_MembershipLevelSave_Button();
                        if (i == 4)
                        {
                            negativeValidation = TestData.ExcelData.TestDataReader.ReadData(1, "Points_Negative_Validation");
                            VerifyTextOnPageAndHighLight(negativeValidation);
                        }
                        else
                            VerifyTextOnPageAndHighLight(pointsValidation);
                        Logger.WriteDebugMessage("Validation Message for Points got displayed");
                    }
                }

                //Validate Revenue
                for (i = 1; i <= 5; i++)
                {
                    revenue = TestData.ExcelData.TestDataReader.ReadData(i, "Revenue");
                    Admin.Enter_Revenue_TextBox(revenue);
                    Logger.WriteDebugMessage("All Details with Revenue as = " + revenue + " Entered");
                    if (i < 5)
                    {
                        Admin.Click_MembershipLevelSave_Button();
                        if (i == 4)
                        {
                            negativeValidation = TestData.ExcelData.TestDataReader.ReadData(1, "Revenue_Negative_Validation");
                            VerifyTextOnPageAndHighLight(negativeValidation);
                        }
                        else
                            VerifyTextOnPageAndHighLight(revenueValidation);
                        Logger.WriteDebugMessage("Validation Message for Revenue got displayed");
                    }
                }
                Admin.Click_MembershipLevelCancel_Button();
                Logger.WriteDebugMessage("Clicked on Cancel button for Add member Level Rule Overlay and Member Level Rule page got displayed");

                //Log test data into log file and extent report
                for (i = 0; i < levelCount; i++)
                    Logger.LogTestData(TestPlanId, TestCaseId, i + " = Member Level", levelArray[i]);
                Logger.LogTestData(TestPlanId, TestCaseId, "Month Period Validation", monthlPeriodValidation);
                Logger.LogTestData(TestPlanId, TestCaseId, "Qualified Night Validation", qualifiedNightValidation);
                Logger.LogTestData(TestPlanId, TestCaseId, "Stay Properties Validation", stayPropertiesValidation);
                Logger.LogTestData(TestPlanId, TestCaseId, "Qualified Stay Validation", qualifiedStayValidation);
                Logger.LogTestData(TestPlanId, TestCaseId, "Checked out Stay Validation", checkOutStayValidation);
                Logger.LogTestData(TestPlanId, TestCaseId, "Points Validation", pointsValidation);
                Logger.LogTestData(TestPlanId, TestCaseId, "Revenue Validation", revenueValidation, true);

            }
        }

        public static void TC_255561()
        {
            if (TestCaseId == Constants.TC_255561)
            {
                //Pre-requisite
                string membershipLevel_Name, membershipCode, memberLevel_Order, processByService;
                int levelCount;
                Random ranno = new Random();
                Users data = new Users();
                
                //Retrive data from database
                membershipLevel_Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Name"), ranno.Next().ToString().Substring(0, 3));
                membershipCode = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Code"), ranno.Next().ToString().Substring(0, 2));
                memberLevel_Order = ranno.Next().ToString().Substring(0, 3);
                processByService = TestData.ExcelData.TestDataReader.ReadData(1, "Process_By_Service");

                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Click on Membership Setup tab 
                Admin.Click_MembershipSetup_Tab();
                Logger.WriteDebugMessage("Clicked on Membership Setup tab");

                //Add Membership Level 
                Admin.AddMembershipLevel(membershipLevel_Name, membershipCode, memberLevel_Order, processByService);

                ReloadPage();
                Queries.GetActiveMembershipLevelwithCount(data);
                Admin.Select_MembershipLevel_Entries("All");
                levelCount = Int32.Parse(data.LevelCount);
                string[] levelArray = new string[levelCount];
                string[] levelorderArray = new string[levelCount];
                for (int i = 0; i < levelCount; i++)
                {
                    levelArray[i] = PageObject_Admin.Get_MembershipLevel_Name("" + (i + 1) + "").GetAttribute("innerHTML");
                    levelorderArray[i] = PageObject_Admin.Get_MembershipLevel_Order("" + (i + 1) + "").GetAttribute("innerHTML");
                }
                PageDown();
                Logger.WriteDebugMessage("All membership levels captured");
                

                // Navigate to Home page and verify all membership levels
                Admin.Click_Menu_Home();
                Logger.WriteDebugMessage("Home tab clicked");
                Admin.SelectMemberType("Loyalty");
                Logger.WriteDebugMessage("Member type selected as Loyalty");
                Admin.SelectMemberStatus("Active");
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Result Displayed on Member Search");
                Admin.Click_Icon_View(ProjectName);
                ElementWait(PageObject_Admin.Tab_MemberAwards(), 160);
                Logger.WriteDebugMessage("Member information page should displayed");
                ElementClick(PageObject_Admin.Value_Information_MemberLevel());
                Admin.Click_Dropdown_MemberStatus();
                Logger.WriteDebugMessage("Drop-down displaying on the screen");
                for (int i = 0; i < levelCount; i++)
                {
                    string level_Array = levelArray[i];
                    string level_MemberInformation = PageObject_Admin.Get_MemberInformation_MemberLevel("" + (i + 1) + "").GetAttribute("innerHTML");
                    for(int j=1;j<levelCount;j++)
                    { 
                        if (levelArray[j].Contains(level_MemberInformation))
                        Logger.WriteInfoMessage(level_MemberInformation + "= Level matched");
                    }
                    
                }
                Logger.WriteDebugMessage("All member levels are found on Mmber Information page");
                // Navigate to Loyalty rules tab and verify all membership levels
                Helper.ReloadPage();
                Admin.Click_Menu_LoyaltyRules();
                ElementWait(PageObject_Admin.SubTab_PointsEarningRules(), 120);
                Logger.WriteDebugMessage("Loyalty rules tab clicked");
                Admin.Click_SubTab_PointsEarningRules();
                Logger.WriteDebugMessage("Points Earning Rules tab get clicked");
                Admin.Click_PointsEarningRules_Button_AddRule();
                Logger.WriteDebugMessage("Loyalty Rules overlay should displayed");
                Admin.Click_PointsEarningRules_Dropdown_IncludeMemberLevel();
                for (int i = 0; i < levelCount; i++)
                {
                    string level_Array = levelArray[i];
                    VerifyTextOnPageAndHighLight(level_Array);
                }
                Logger.WriteDebugMessage("Membership levels displaying on the page");
                Admin.Click_PointsEarningRules_Button_Cancel();

                Admin.Click_LoyaltyRules_AwardEarningRules();
                Logger.WriteDebugMessage("Award Earning Rules tab clicked");
                Admin.Click_AwardEarningRules_AddRuleButton();
                Logger.WriteDebugMessage("Add Rule overlay should get displayed");
                Admin.Click_AwardEarningRules_AddRule_IncludeMemberLevel();
                for (int i = 0; i < levelCount; i++)
                {
                    string level_Array = levelArray[i];
                    VerifyTextOnPageAndHighLight(level_Array);
                }
                Logger.WriteDebugMessage("Membership levels displaying on the page");
                Admin.Click_AwardEarningRules_AddRule_CancelButton();

                //Admin.Click_Memberlevelrule_Tab();
                //Logger.WriteDebugMessage("Member level rule tab clicked");
                //Admin.Click_MemberLevelRule_AddRuleButton();
                //Logger.WriteDebugMessage("Add rule overlay should get displayed");
                //Admin.Click_MemberLevelRule_AddRuleButton_NewLevel();
                //for (int i = 0; i < levelCount; i++)
                //{
                //    VerifyTextOnPageAndHighLight(levelArray[i]);
                //}
                //Logger.WriteDebugMessage("Membership levels displaying on the page");
                //Admin.Click_MemberLevelRule_AddRuleButton_CancelButton();

                // Navigate to Loyalty Award tab and verify membership levels 
                Admin.Click_LoyaltyAwards();
                Logger.WriteDebugMessage("Loyalty award tab clicked");
                Admin.Click_LoyaltyAwards_Button_Add();
                Logger.WriteDebugMessage("Add button clicked");
                Admin.Dropdown_AwardType("Nights Based");
                Admin.Click_LoyaltyAwards_Dropdown_MemberLevel();
                for (int i = 0; i < levelCount; i++)
                {
                    string level_Array = levelArray[i];
                    VerifyTextOnPageAndHighLight(level_Array);
                }
                Logger.WriteDebugMessage("Membership levels displaying on the page");
                Admin.Click_MemberAwards_Icon_Close();

                // Navigate to Loyalty Setup tab and verify all membership levels
                Admin.Click_Menu_LoyaltySetup();
                Logger.WriteDebugMessage("Loyalty setup tab clicked");
                Admin.Click_SubTab_Offers();
                Logger.WriteDebugMessage("Offers tab clicked");
                Admin.Click_LoyaltySetUp_Offers_Button_AddOffers();
                Logger.WriteDebugMessage("Add offers button clicked");
                PageDown();
                Admin.Click_LoyaltySetUp_Offers_Dropdown_MemberLevel();
                for (int i = 0; i < levelCount; i++)
                {
                    string level_Array = levelArray[i];
                    VerifyTextOnPageAndHighLight(level_Array);
                }
                Logger.WriteDebugMessage("Membership levels displaying on the page");
                Admin.Click_LoyaltySetUp_Offers_Dropdown_MemberLevel();

                // Navigate to portal and validate membership level
                Admin.Click_Menu_Home();
                Logger.WriteDebugMessage("Home tab clicked");
                Admin.SelectEmailStatus("Confirmed");
                Admin.SelectMemberStatus("Active");
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Result Displayed on Member Search");
                string memberLevel = PageObject_Admin.Get_Admin_MemberLevel().GetAttribute("innerHTML");
                Admin.Click_Icon_View(ProjectName);
                ElementWait(PageObject_Admin.Tab_MemberAwards(), 120);
                Logger.WriteDebugMessage("Member information page should displayed");

                //Update Member level to New member level
                Admin.SelectLevel(membershipLevel_Name);
                try
                {
                    Admin.Click_Member_Level_Email_Yes_Button();
                }
                catch (Exception)
                {
                    Logger.WriteDebugMessage("Member Level confirmation Overlay is not displaying");
                }
                Logger.WriteDebugMessage("Member Level = " + membershipLevel_Name + " got selected");

                Admin.Click_MemberInformation_Value_MemberPortal();
                AddDelay(30000);
                ControlToNewWindow();
                Driver.Manage().Window.Maximize();
                ScrollToText(membershipLevel_Name);
                VerifyTextOnPageAndHighLight(membershipLevel_Name);
                Logger.WriteDebugMessage(membershipLevel_Name + " = Membership level displaying on the portal ");
                Helper.ControlToPreviousWindow();

                //Update Member level to Old Member level
                Admin.SelectLevel(memberLevel);
                try
                {
                    Admin.Click_Member_Level_Email_Yes_Button();
                }
                catch (Exception)
                {
                    Logger.WriteDebugMessage("Member Level confirmation Overlay is not displaying");
                }
                Logger.WriteDebugMessage("Old Member Level got selected");
                // Verify membership levels in db
                for (int i = 0; i < levelCount; i++)
                {
                    Queries.GetActiveMembershipLevelByLevelOrder(data, levelorderArray[i]);

                    if (levelArray[i].Equals(data.MembershipLevelName))
                        Logger.WriteInfoMessage(levelArray[i] + "= Present in database");
                    else
                        Assert.Fail(levelArray[i] + "= is not Present in database");
                }

                //Delete Added Membership Level
                Admin.Click_MembershipSetup_Tab();
                Logger.WriteDebugMessage("Clicked on Membership Setup tab");
                Admin.Delete_MembershipLevel(membershipLevel_Name);

                //Log test data into log file and extent report
                for (int i = 0; i < levelCount; i++)
                {
                    if (i == (levelCount - 1))
                    {
                        Logger.LogTestData(TestPlanId, TestCaseId, "Level" + i + "", levelArray[i], true);
                        break;
                    }
                    else
                        Logger.LogTestData(TestPlanId, TestCaseId, "Level" + i + "", levelArray[i]);
                }
            }
        }
        public static void TC_255562()
        {
            if (TestCaseId == Constants.TC_255562)
            {
                //pre-requiste
                string membershipLevel_Name, membershipCode, memberLevel_Order, processByService, membershipLevel_Validation, order_Validation, processByServiceEdit;
                Random ranno = new Random();

                //Retrive data from database
                membershipLevel_Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Name"), ranno.Next().ToString().Substring(0, 3));
                membershipCode = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Code"),ranno.Next().ToString().Substring(0, 3));
                memberLevel_Order = ranno.Next().ToString().Substring(0, 3);
                processByService = TestData.ExcelData.TestDataReader.ReadData(1, "Process_By_Service");
                processByServiceEdit = TestData.ExcelData.TestDataReader.ReadData(1, "Process_By_Service_Edit");
                membershipLevel_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Name_Validation");
                order_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "MemberLevel_Order_Validation");

                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Helper.ElementWait(PageObject_Admin.Click_MembershipSetup_Tab(), 120);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Click on Membership Setup tab and Member level sub tab
                Admin.Click_MembershipSetup_Tab();
                Helper.ElementWait(PageObject_Admin.Click_MemberLevel_SubTab(), 120);
                Logger.WriteDebugMessage("Clicked on Membership Setup tab");
                Admin.Click_MemberLevel_SubTab();
                Logger.WriteInfoMessage("Clicked on Membership Level tab");

                //Verify the Add Membership Level functionality
                Admin.AddMembershipLevel(membershipLevel_Name, membershipCode, memberLevel_Order, processByService);


                //Verify Edit Mebership level with Required Fields validation
                Admin.RequiredFieldsOnEditMembershipOverlay(membershipLevel_Name, membershipLevel_Validation, order_Validation);

                //Verify Cancel and Close button functionality on Edit MembershipLevel
                Admin.Click_AddMemershipLevel_EditeButton(membershipLevel_Name);
                Logger.WriteDebugMessage("Edit Membership Level Overlay got displayed");
                Admin.AddMemershipLevel_MembershipLevel(membershipLevel_Name+"_Edit");
                Admin.AddMemershipLevel_LevelOrder(ranno.Next().ToString().Substring(0, 2));
                Logger.WriteDebugMessage("Updated MemberShip Level name and Level Order");
                Admin.Click_AddMemershipLevel_CancelButton();
                if (Helper.IsElementRemoved(membershipLevel_Name + "Edit"))
                    Assert.Fail("Member level got updated even after clickin on Cancel button");
                else
                    Logger.WriteDebugMessage("Member level not get update and Landed on Membership Level tab Page");
                Admin.Click_AddMemershipLevel_EditeButton(membershipLevel_Name);
                Logger.WriteDebugMessage("Edit Membership Level Overlay got displayed");
                Admin.AddMemershipLevel_MembershipLevel(membershipLevel_Name + "_Edit");
                Admin.AddMemershipLevel_LevelOrder(ranno.Next().ToString().Substring(0, 2));
                Logger.WriteDebugMessage("Updated MemberShip Level name and Level Order");
                Admin.Click_AddMemershipLevel_Close();
                if (Helper.IsElementRemoved(membershipLevel_Name + "Edit"))
                    Assert.Fail("Member level got updated even after clickin on Cancel button");
                else
                    Logger.WriteDebugMessage("Member level not get update and Landed on Membership Level tab Page");

                //Edit Membership Level 
                Admin.EditMembershipLevel(membershipLevel_Name, ranno.Next().ToString().Substring(0, 2), processByServiceEdit);

                //Delete Added Membership Level
                Admin.Delete_MembershipLevel(membershipLevel_Name+ "_Edit");

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Name", membershipLevel_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Code", membershipCode);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Order", memberLevel_Order);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level ProcessByService", processByService, true);
            }
        }

        public static void TC_255564()
        {
            if (TestCaseId == Constants.TC_255564)
            {
                //pre-requiste
                string  delete_Validation;
                Users data = new Users();
                Queries.GetActiveMembershipLevel(data);

                //Retrive data
                delete_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "Delete_Validation");

                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Helper.ElementWait(PageObject_Admin.Click_MembershipSetup_Tab(), 120);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Click on Membership Setup tab and Member level sub tab
                Admin.Click_MembershipSetup_Tab();
                Helper.ElementWait(PageObject_Admin.Click_MemberLevel_SubTab(), 120);
                Logger.WriteDebugMessage("Clicked on Membership Setup tab");
                Admin.Click_MemberLevel_SubTab();
                Logger.WriteInfoMessage("Clicked on Membership Level tab");

                //Try to delete 'Membership level' which is allocated to member
                Admin.Enter_MembershipLevel_Filter(data.MembershipLevelName);
                Admin.Click_AddMemershipLevel_DeleteButton(data.MembershipLevelName);
                Logger.WriteDebugMessage("Clicked on Delete button for = " + data.MembershipLevelName + " Member level and Delete Overlay got displayed");
                Admin.Click_DeleteMemershipLevel_SubmitButton();
                Helper.VerifyTextOnPageAndHighLight(delete_Validation);
                if (Helper.IsElementRemoved(data.MembershipLevelName))
                    Logger.WriteDebugMessage("Validation message of Member Level got displayed and Membership level is not got deleted");
                else
                    Assert.Fail("Membership Level allocated to any user got deleted ");

                //Log test data in log file
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Name", data.MembershipLevelName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Delete Validation Message", delete_Validation, true);

            }
        }
               
        private static void TC_255573()
        {
            if (TestCaseId == Constants.TC_255573)
            {
                //pre-requiste
                string membershipLevel_Name, membershipCode, memberLevel_Order, processByService, rule_Type, default_Rule, month_Period, no_Of_QNights, no_Of_StayProp, no_Of_QualStays, no_Of_CheckedOutStays, points, revenue;
                Random ranno = new Random();

                //Retrive test data 
                membershipLevel_Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Name"), ranno.Next().ToString().Substring(0, 3));
                membershipCode = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Code"),ranno.Next().ToString().Substring(0, 3));
                memberLevel_Order = ranno.Next().ToString().Substring(0, 3);
                processByService = TestData.ExcelData.TestDataReader.ReadData(1, "Process_By_Service");
                rule_Type = TestData.ExcelData.TestDataReader.ReadData(1, "Rule_Type");
                default_Rule = TestData.ExcelData.TestDataReader.ReadData(1, "Default_Rule");
                month_Period = TestData.ExcelData.TestDataReader.ReadData(1, "Month_Period");
                no_Of_QNights = TestData.ExcelData.TestDataReader.ReadData(1, "No_Of_QNights");
                no_Of_StayProp = TestData.ExcelData.TestDataReader.ReadData(1, "No_Of_StayProp");
                no_Of_QualStays = TestData.ExcelData.TestDataReader.ReadData(1, "No_Of_QualStays");
                no_Of_CheckedOutStays = TestData.ExcelData.TestDataReader.ReadData(1, "No_Of_CheckedOutStays");
                points = TestData.ExcelData.TestDataReader.ReadData(1, "Points");
                revenue = TestData.ExcelData.TestDataReader.ReadData(1, "Revenue");

                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Helper.ElementWait(PageObject_Admin.Click_MembershipSetup_Tab(), 120);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Click on Membership Setup tab and Member level sub tab
                Admin.Click_MembershipSetup_Tab();
                Helper.ElementWait(PageObject_Admin.Click_MemberLevel_SubTab(), 120);
                Logger.WriteDebugMessage("Clicked on Membership Setup tab");
                Admin.Click_MemberLevel_SubTab();
                Logger.WriteInfoMessage("Clicked on Membership Level tab");

                //Verify the Add Membership Level Functinality
                Admin.AddMembershipLevel(membershipLevel_Name, membershipCode, memberLevel_Order, processByService);

                //Click on Member Level Rule tab 
                Helper.ReloadPage();
                Admin.Click_MemberLevel_SubTab();
                Admin.Click_Memberlevelrule_Tab();
                Logger.WriteInfoMessage("Clicked on Membership Level Rule tab");

                //Verify Cancel button on Add Membership Level Rule Functinality
                Admin.AddMembershipRuleCancel(membershipLevel_Name, rule_Type, default_Rule, month_Period, no_Of_QNights, no_Of_StayProp, no_Of_QualStays, no_Of_CheckedOutStays, points, revenue);

                //Click on Member Level Rule tab 
                Helper.ReloadPage();
                Admin.Click_MemberLevel_SubTab();
                Admin.Click_Memberlevelrule_Tab();
                Logger.WriteInfoMessage("Clicked on Membership Level Rule tab");

                //Verify the Add Membership Level Rule Functinality
                Admin.AddMembershipRule(membershipLevel_Name, rule_Type, default_Rule, month_Period, no_Of_QNights, no_Of_StayProp, no_Of_QualStays, no_Of_CheckedOutStays, points, revenue);

                //Delete Membership Level Rule
                Admin.Click_DeleteMemberLevelRule_Button();
                Logger.WriteDebugMessage("Membership Level Rule delete pop up is displayed");
                Admin.Click_DeleteMemershipLevelRule_SubmitButton();
                Logger.WriteDebugMessage("Membership Level Rule Deleted successfully");

                //Click on Member Level tab 
                Helper.ReloadPage();
                Admin.Click_MemberLevel_SubTab();
                Logger.WriteDebugMessage("Navigated to Member Level tab");

                //Delete Added Membership Level
                Admin.Delete_MembershipLevel(membershipLevel_Name);

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Name", membershipLevel_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Code", membershipCode);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Order", memberLevel_Order);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level ProcessByService", processByService);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Rule Type", rule_Type);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Default Rule", default_Rule);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Month Period", month_Period);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Number Of Qualified Nights", no_Of_QNights);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Number of Stay Properties", no_Of_StayProp);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Number of Qualified Stays", no_Of_QualStays);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Number of Checked Out Stays", no_Of_CheckedOutStays);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Points", points);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Revenue", revenue, true);

            }
        }

        private static void TC_255574()
        {
            if (TestCaseId == Constants.TC_255574)
            {
                //pre-requiste
                string membershipLevel_Name, membershipCode, memberLevel_Order, processByService, rule_Type, default_Rule, month_Period, no_Of_QNights, no_Of_StayProp, no_Of_QualStays, no_Of_CheckedOutStays, points, revenue;
                Random ranno = new Random();

                //Retrive test data 
                membershipLevel_Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Name"), ranno.Next().ToString().Substring(0, 3));
                membershipCode = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Code"), ranno.Next().ToString().Substring(0, 1));
                memberLevel_Order = ranno.Next().ToString().Substring(0, 3);
                processByService = TestData.ExcelData.TestDataReader.ReadData(1, "Process_By_Service");
                rule_Type = TestData.ExcelData.TestDataReader.ReadData(1, "Rule_Type");
                default_Rule = TestData.ExcelData.TestDataReader.ReadData(1, "Default_Rule");
                month_Period = TestData.ExcelData.TestDataReader.ReadData(1, "Month_Period");
                no_Of_QNights = TestData.ExcelData.TestDataReader.ReadData(1, "No_Of_QNights");
                no_Of_StayProp = TestData.ExcelData.TestDataReader.ReadData(1, "No_Of_StayProp");
                no_Of_QualStays = TestData.ExcelData.TestDataReader.ReadData(1, "No_Of_QualStays");
                no_Of_CheckedOutStays = TestData.ExcelData.TestDataReader.ReadData(1, "No_Of_CheckedOutStays");
                points = TestData.ExcelData.TestDataReader.ReadData(1, "Points");
                revenue = TestData.ExcelData.TestDataReader.ReadData(1, "Revenue");

                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Helper.ElementWait(PageObject_Admin.Click_MembershipSetup_Tab(), 120);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Click on Membership Setup tab and Member level sub tab
                Admin.Click_MembershipSetup_Tab();
                Helper.ElementWait(PageObject_Admin.Click_MemberLevel_SubTab(), 120);
                Logger.WriteDebugMessage("Clicked on Membership Setup tab");
                Admin.Click_MemberLevel_SubTab();
                Logger.WriteInfoMessage("Clicked on Membership Level tab");

                //Verify the Add Membership Level Functinality
                Admin.AddMembershipLevel(membershipLevel_Name, membershipCode, memberLevel_Order, processByService);

                //Click on Member Level Rule tab 
                Helper.ReloadPage();
                Admin.Click_MemberLevel_SubTab();
                Admin.Click_Memberlevelrule_Tab();
                Logger.WriteInfoMessage("Clicked on Membership Level Rule tab");

                //Verify the Add Membership Level Rule Functinality
                Admin.AddMembershipRuleRequiredFields(membershipLevel_Name, rule_Type, default_Rule, month_Period);

                //Delete Membership Level Rule
                Admin.Click_DeleteMemberLevelRule_Button();
                Logger.WriteDebugMessage("Membership Level Rule delete pop up is displayed");
                Admin.Click_DeleteMemershipLevelRule_SubmitButton();
                Logger.WriteDebugMessage("Membership Level Rule Deleted successfully");

                //Click on Member Level tab 
                Helper.ReloadPage();
                Admin.Click_MemberLevel_SubTab();
                Logger.WriteDebugMessage("Navigated to Member Level tab");

                //Delete Added Membership Level
                Admin.Delete_MembershipLevel(membershipLevel_Name);

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Name", membershipLevel_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Code", membershipCode);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Order", memberLevel_Order);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level ProcessByService", processByService);
                //Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Name", membershipLevel_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Rule Type", rule_Type);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Default Rule", default_Rule);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Month Period", month_Period, true);
               
            }
        }

        private static void TC_255578()
        {
            if (TestCaseId == Constants.TC_255578)
            {
                //pre-requiste
                string membershipLevel_Name, membershipCode, memberLevel_Order, processByService, rule_Type, default_Rule, month_Period, no_Of_QNights, no_Of_StayProp, no_Of_QualStays, no_Of_CheckedOutStays, points, revenue;
                Random ranno = new Random();

                //Retrive test data 
                membershipLevel_Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Name"), ranno.Next().ToString().Substring(0, 3));
                membershipCode = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Code"), ranno.Next().ToString().Substring(0, 1));
                memberLevel_Order = ranno.Next().ToString().Substring(0, 3);
                processByService = TestData.ExcelData.TestDataReader.ReadData(1, "Process_By_Service");
                rule_Type = TestData.ExcelData.TestDataReader.ReadData(1, "Rule_Type");
                default_Rule = TestData.ExcelData.TestDataReader.ReadData(1, "Default_Rule");
                month_Period = TestData.ExcelData.TestDataReader.ReadData(1, "Month_Period");
                
                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Helper.ElementWait(PageObject_Admin.Click_MembershipSetup_Tab(), 120);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Click on Membership Setup tab and Member level sub tab
                Admin.Click_MembershipSetup_Tab();
                Helper.ElementWait(PageObject_Admin.Click_MemberLevel_SubTab(), 120);
                Logger.WriteDebugMessage("Clicked on Membership Setup tab");
                Admin.Click_MemberLevel_SubTab();
                Logger.WriteInfoMessage("Clicked on Membership Level tab");

                //Verify the Add Membership Level Functinality
                Admin.AddMembershipLevel(membershipLevel_Name, membershipCode, memberLevel_Order, processByService);

                //Click on Member Level Rule tab 
                Helper.ReloadPage();
                Admin.Click_MemberLevel_SubTab();
                Admin.Click_Memberlevelrule_Tab();
                Logger.WriteInfoMessage("Clicked on Membership Level Rule tab");

                //Verify the Add Membership Level Rule Functinality
                Admin.AddMembershipRuleRequiredFields(membershipLevel_Name, rule_Type, default_Rule, month_Period);

                //Delete Cancel Membership Level Rule
                Admin.Click_DeleteMemberLevelRule_Button();
                Logger.WriteDebugMessage("Membership Level Rule delete pop up is displayed");
                Admin.Click_DeleteMemershipLevelRule_CancelButton();
                Logger.WriteDebugMessage("Membership Level Rule is not deleted");

                //Delete Membership Level Rule
                Admin.Click_DeleteMemberLevelRule_Button();
                Logger.WriteDebugMessage("Membership Level Rule delete pop up is displayed");
                Admin.Click_DeleteMemershipLevelRule_SubmitButton();
                Logger.WriteDebugMessage("Membership Level Rule Deleted successfully");

                //Click on Member Level tab 
                Helper.ReloadPage();
                Admin.Click_MemberLevel_SubTab();
                Logger.WriteDebugMessage("Navigated to Member Level tab");

                //Delete Added Membership Level
                Admin.Delete_MembershipLevel(membershipLevel_Name);

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Name", membershipLevel_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Code", membershipCode);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Order", memberLevel_Order);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level ProcessByService", processByService);
                //Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Name", membershipLevel_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Rule Type", rule_Type);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Default Rule", default_Rule);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Month Period", month_Period, true);

            }
        }

        private static void TC_255572()
        {
            if (TestCaseId == Constants.TC_255572)
            {
                //pre-requiste
                string membershipCode, memberLevel_Order, processByService, membershipLevel_Name, rule_Type, month_Period, membershipLevel_Name_validation_message, rule_Type_validation_message, month_Period_validation_message;
                Random ranno = new Random();

                //Retrive data from database

                membershipLevel_Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Name"), ranno.Next().ToString().Substring(0, 3));
                membershipCode = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Code"), ranno.Next().ToString().Substring(0, 3));
                memberLevel_Order = ranno.Next().ToString().Substring(0, 3);
                processByService = TestData.ExcelData.TestDataReader.ReadData(1, "Process_By_Service");

                //membershipLevel_Name = TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Name");
                rule_Type = TestData.ExcelData.TestDataReader.ReadData(1, "Rule_Type");
                month_Period = TestData.ExcelData.TestDataReader.ReadData(1, "Month_Period");
                //memberLevel_Order = ranno.Next().ToString().Substring(0, 2);
                membershipLevel_Name_validation_message = TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Name_Validation");
                rule_Type_validation_message = TestData.ExcelData.TestDataReader.ReadData(1, "Rule_Type_validation_message");
                month_Period_validation_message = TestData.ExcelData.TestDataReader.ReadData(1, "Month_Period_validation_message");

                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Helper.ElementWait(PageObject_Admin.Click_MembershipSetup_Tab(), 120);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Click on Membership Setup tab and Member level sub tab
                Admin.Click_MembershipSetup_Tab();
                Helper.ElementWait(PageObject_Admin.Click_MemberLevel_SubTab(), 120);
                Logger.WriteDebugMessage("Clicked on Membership Setup tab");
                Admin.Click_MemberLevel_SubTab();
                Logger.WriteInfoMessage("Clicked on Membership Level tab");

                //Verify the Add Membership Level Functinality
                 Admin.AddMembershipLevel(membershipLevel_Name, membershipCode, memberLevel_Order, processByService);

                //Click on Member Level Rule tab 
                Helper.ReloadPage();
                Admin.Click_MemberLevel_SubTab();
                Admin.Click_Memberlevelrule_Tab();
                Logger.WriteInfoMessage("Clicked on Membership Level Rule tab");

                //Verify the Required Field Validation
                Admin.AddMembershipLevelRuleWithoutRequiredFields(membershipLevel_Name, rule_Type, month_Period, membershipLevel_Name_validation_message, rule_Type_validation_message, month_Period_validation_message);

                //Delete Membership Level Rule
                Admin.Click_DeleteMemberLevelRule_Button();
                Logger.WriteDebugMessage("Membership Level Rule delete pop up is displayed");
                Admin.Click_DeleteMemershipLevelRule_SubmitButton();
                Logger.WriteDebugMessage("Membership Level Rule Deleted successfully");

                //Click on Member Level tab 
                Helper.ReloadPage();
                Admin.Click_MemberLevel_SubTab();
                Logger.WriteDebugMessage("Navigated to Member Level tab");

                //Delete Added Membership Level
                Admin.Delete_MembershipLevel(membershipLevel_Name);

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Name", membershipLevel_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Code", membershipCode);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Order", memberLevel_Order);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level ProcessByService", processByService);
                //Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Name", membershipLevel_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Rule Type", rule_Type);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Month Period", month_Period);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "MemberLevelName_ValidationMessage", membershipLevel_Name_validation_message);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "RuleType_Validation", rule_Type_validation_message);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "MonthPeriod_Validation", month_Period_validation_message, true);

            }
        }

        private static void TC_255576()
        {
            if (TestCaseId == Constants.TC_255576)
            {
                //pre-requiste
                string membershipLevel_Name, membershipCode, memberLevel_Order, processByService, rule_Type, default_Rule, month_Period, no_Of_QNights, no_Of_StayProp, no_Of_QualStays, no_Of_CheckedOutStays, points, revenue;
                Random ranno = new Random();

                //Retrive test data 
                membershipLevel_Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Name"), ranno.Next().ToString().Substring(0, 3));
                membershipCode = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Code"), ranno.Next().ToString().Substring(0, 3));
                memberLevel_Order = ranno.Next().ToString().Substring(0, 3);
                processByService = TestData.ExcelData.TestDataReader.ReadData(1, "Process_By_Service");
                rule_Type = TestData.ExcelData.TestDataReader.ReadData(1, "Rule_Type");
                default_Rule = TestData.ExcelData.TestDataReader.ReadData(1, "Default_Rule");
                month_Period = TestData.ExcelData.TestDataReader.ReadData(1, "Month_Period");
                no_Of_QNights = TestData.ExcelData.TestDataReader.ReadData(1, "No_Of_QNights");
                no_Of_StayProp = TestData.ExcelData.TestDataReader.ReadData(1, "No_Of_StayProp");
                no_Of_QualStays = TestData.ExcelData.TestDataReader.ReadData(1, "No_Of_QualStays");
                no_Of_CheckedOutStays = TestData.ExcelData.TestDataReader.ReadData(1, "No_Of_CheckedOutStays");
                points = TestData.ExcelData.TestDataReader.ReadData(1, "Points");
                revenue = TestData.ExcelData.TestDataReader.ReadData(1, "Revenue");

                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Helper.ElementWait(PageObject_Admin.Click_MembershipSetup_Tab(), 120);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Click on Membership Setup tab and Member level sub tab
                Admin.Click_MembershipSetup_Tab();
                Helper.ElementWait(PageObject_Admin.Click_MemberLevel_SubTab(), 120);
                Logger.WriteDebugMessage("Clicked on Membership Setup tab");
                Admin.Click_MemberLevel_SubTab();
                Logger.WriteInfoMessage("Clicked on Membership Level tab");

                //Verify the Add Membership Level Functinality
                Admin.AddMembershipLevel(membershipLevel_Name, membershipCode, memberLevel_Order, processByService);
                                
                //Click on Member Level Rule tab 
                Helper.ReloadPage();
                Admin.Click_MemberLevel_SubTab();
                Admin.Click_Memberlevelrule_Tab();
                Logger.WriteInfoMessage("Clicked on Membership Level Rule tab");

                //Verify the Add Membership Level Rule Functinality
                Admin.AddMembershipRule(membershipLevel_Name, rule_Type, default_Rule, month_Period, no_Of_QNights, no_Of_StayProp, no_Of_QualStays, no_Of_CheckedOutStays, points, revenue);

                //Click on Member Level Rule tab 
                Helper.ReloadPage();
                Admin.Click_MemberLevel_SubTab();
                Admin.Click_Memberlevelrule_Tab();
                Logger.WriteInfoMessage("Clicked on Membership Level Rule tab");

                //Verify the Add Membership Level Rule Functinality
                Admin.AddMembershipRule(membershipLevel_Name, rule_Type, default_Rule, month_Period, no_Of_QNights, no_Of_StayProp, no_Of_QualStays, no_Of_CheckedOutStays, points, revenue);


                //Delete Membership Level Rule
                Admin.Click_DeleteMemberLevelRule_Button();
                Logger.WriteDebugMessage("Membership Level Rule delete pop up is displayed");
                Admin.Click_DeleteMemershipLevelRule_SubmitButton();
                Logger.WriteDebugMessage("Membership Level Rule Deleted successfully");

                //Delete Membership Level Rule
                Admin.Click_DeleteMemberLevelRule_Button();
                Logger.WriteDebugMessage("Membership Level Rule delete pop up is displayed");
                Admin.Click_DeleteMemershipLevelRule_SubmitButton();
                Logger.WriteDebugMessage("Membership Level Rule Deleted successfully");

                //Click on Member Level tab 
                Helper.ReloadPage();
                Admin.Click_MemberLevel_SubTab();
                Logger.WriteDebugMessage("Navigated to Member Level tab");

                //Delete Added Membership Level
                Admin.Delete_MembershipLevel(membershipLevel_Name);

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Name", membershipLevel_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Code", membershipCode);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Order", memberLevel_Order);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level ProcessByService", processByService);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Rule Type", rule_Type);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Default Rule", default_Rule);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Month Period", month_Period);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Number Of Qualified Nights", no_Of_QNights);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Number of Stay Properties", no_Of_StayProp);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Number of Qualified Stays", no_Of_QualStays);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Number of Checked Out Stays", no_Of_CheckedOutStays);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Points", points);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Revenue", revenue, true);

            }
        }

        private static void TC_255577()
        {
            if (TestCaseId == Constants.TC_255577)
            {
                //pre-requiste
                string membershipLevel_Name, membershipLevel_Name_Edit, membershipCode_Edit, memberLevel_Order_Edit, membershipCode, memberLevel_Order, processByService, rule_Type, default_Rule, month_Period, no_Of_QNights, no_Of_StayProp, no_Of_QualStays, no_Of_CheckedOutStays, points, revenue, rule_Type_Edit, default_Rule_Edit, month_Period_Edit, no_Of_QNights_Edit, no_Of_StayProp_Edit, no_Of_QualStays_Edit, no_Of_CheckedOutStays_Edit, points_Edit, revenue_Edit;
                Random ranno = new Random();

                //Retrive test data 
                membershipLevel_Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Name"), ranno.Next().ToString().Substring(0, 3));
                membershipCode = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Code"), ranno.Next().ToString().Substring(0, 3));
                memberLevel_Order = ranno.Next().ToString().Substring(0, 3);
                processByService = TestData.ExcelData.TestDataReader.ReadData(1, "Process_By_Service");
                rule_Type = TestData.ExcelData.TestDataReader.ReadData(1, "Rule_Type");
                default_Rule = TestData.ExcelData.TestDataReader.ReadData(1, "Default_Rule");
                month_Period = TestData.ExcelData.TestDataReader.ReadData(1, "Month_Period");
                no_Of_QNights = TestData.ExcelData.TestDataReader.ReadData(1, "No_Of_QNights");
                no_Of_StayProp = TestData.ExcelData.TestDataReader.ReadData(1, "No_Of_StayProp");
                no_Of_QualStays = TestData.ExcelData.TestDataReader.ReadData(1, "No_Of_QualStays");
                no_Of_CheckedOutStays = TestData.ExcelData.TestDataReader.ReadData(1, "No_Of_CheckedOutStays");
                points = TestData.ExcelData.TestDataReader.ReadData(1, "Points");
                revenue = TestData.ExcelData.TestDataReader.ReadData(1, "Revenue");
                membershipLevel_Name_Edit = TestData.ExcelData.TestDataReader.ReadData(1, "MembershipLevel_Name_Edit");
                membershipCode_Edit = TestData.ExcelData.TestDataReader.ReadData(1, "MembershipCode_Edit");
                memberLevel_Order_Edit = ranno.Next().ToString().Substring(0, 3);

                rule_Type_Edit = TestData.ExcelData.TestDataReader.ReadData(1, "Rule_Type_Edit");
                default_Rule_Edit = TestData.ExcelData.TestDataReader.ReadData(1, "Default_Rule_Edit");
                month_Period_Edit = TestData.ExcelData.TestDataReader.ReadData(1, "Month_Period_Edit");
                no_Of_QNights_Edit = TestData.ExcelData.TestDataReader.ReadData(1, "Month_Period_Edit");
                no_Of_StayProp_Edit = TestData.ExcelData.TestDataReader.ReadData(1, "No_Of_StayProp_Edit");
                no_Of_QualStays_Edit = TestData.ExcelData.TestDataReader.ReadData(1, "No_Of_QualStays_Edit");
                no_Of_CheckedOutStays_Edit = TestData.ExcelData.TestDataReader.ReadData(1, "No_Of_CheckedOutStays_Edit");
                points_Edit = TestData.ExcelData.TestDataReader.ReadData(1, "Points_Edit");
                revenue_Edit = TestData.ExcelData.TestDataReader.ReadData(1, "Revenue_Edit");

                // Navigate to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Helper.ElementWait(PageObject_Admin.Click_MembershipSetup_Tab(), 120);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Click on Membership Setup tab and Member level sub tab
                Admin.Click_MembershipSetup_Tab();
                Helper.ElementWait(PageObject_Admin.Click_MemberLevel_SubTab(), 120);
                Logger.WriteDebugMessage("Clicked on Membership Setup tab");
                Admin.Click_MemberLevel_SubTab();
                Logger.WriteInfoMessage("Clicked on Membership Level tab");

                //Verify the Add Membership Level Functinality
                Admin.AddMembershipLevel(membershipLevel_Name, membershipCode, memberLevel_Order, processByService);

                Admin.AddMembershipLevelForEdit(membershipLevel_Name+"_Edit", membershipCode+ "_Edit", memberLevel_Order_Edit, processByService);

                //Click on Member Level Rule tab 
                Helper.ReloadPage();
                Admin.Click_MemberLevel_SubTab();
                Admin.Click_Memberlevelrule_Tab();
                Logger.WriteInfoMessage("Clicked on Membership Level Rule tab");

                //Verify the Add Membership Level Rule Functinality
                Admin.AddMembershipRule(membershipLevel_Name, rule_Type, default_Rule, month_Period, no_Of_QNights, no_Of_StayProp, no_Of_QualStays, no_Of_CheckedOutStays, points, revenue);
                                
                //Edit Membership Level Rule
                Admin.Click_EditMemberLevelRule_Button();
                Logger.WriteDebugMessage("Membership Level Rule edit pop up is displayed");
                Admin.EditMembershipRule(membershipLevel_Name, rule_Type_Edit, default_Rule_Edit, month_Period_Edit, no_Of_QNights_Edit, no_Of_StayProp_Edit, no_Of_QualStays_Edit, no_Of_CheckedOutStays_Edit, points_Edit, revenue_Edit);
                
                //Delete Membership Level Rule
                Admin.Click_DeleteMemberLevelRule_Button();
                Logger.WriteDebugMessage("Membership Level Rule delete pop up is displayed");
                Admin.Click_DeleteMemershipLevelRule_SubmitButton();
                Logger.WriteDebugMessage("Membership Level Rule Deleted successfully");

                //Click on Member Level tab 
                Helper.ReloadPage();
                Admin.Click_MemberLevel_SubTab();
                Logger.WriteDebugMessage("Navigated to Member Level tab");

                //Delete Added Membership Level
                Admin.Delete_MembershipLevel(membershipLevel_Name+"_Edit");

                //Delete Added Membership Level
                Admin.Delete_MembershipLevel(membershipLevel_Name);

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Name", membershipLevel_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Code", membershipCode);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Order", memberLevel_Order);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level ProcessByService", processByService);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Rule Type", rule_Type);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Default Rule", default_Rule);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Month Period", month_Period);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Number Of Qualified Nights", no_Of_QNights);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Number of Stay Properties", no_Of_StayProp);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Number of Qualified Stays", no_Of_QualStays);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Number of Checked Out Stays", no_Of_CheckedOutStays);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Points", points);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Revenue", revenue);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level", membershipLevel_Name_Edit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Code2", membershipCode_Edit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Member Level Order Edit", memberLevel_Order_Edit);

                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Rule Type Edit", rule_Type_Edit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Default Rule Edit", default_Rule_Edit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Month Period Edit", month_Period_Edit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Number Of Qualified Nights Edit", no_Of_QNights_Edit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Number of Stay Properties Edit", no_Of_StayProp_Edit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Number of Qualified Stays Edit", no_Of_QualStays_Edit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Number of Checked Out Stays Edit", no_Of_CheckedOutStays_Edit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Points Edit", points_Edit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Revenue Edit", revenue_Edit,true);



            }
        }

        #endregion TP_256428 - Admin - Membership_Setup

    }
}
