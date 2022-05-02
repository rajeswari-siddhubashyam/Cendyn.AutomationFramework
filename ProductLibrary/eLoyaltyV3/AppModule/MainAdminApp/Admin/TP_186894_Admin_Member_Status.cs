using eLoyaltyV3.AppModule.UI;
using Constants = eLoyaltyV3.Utility.Constants;
using eLoyaltyV3.Entity;
using BaseUtility.Utility;
using InfoMessageLogger;
using Queries = eLoyaltyV3.Utility.Queries;
using eLoyaltyV3.PageObject.Admin;
using TestData;
using NUnit.Framework;
using System;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region TP_186894 - Admin Member Status
        public static void TC_111604()
        {
            if (TestCaseId == Constants.TC_111604)
            {
                //Pre-requisites
                Users data = new Users();

                //1. URL and Credential is available in Test Plan Run description 
                //2.Data Requirement: Active profile who has points
                string status = TestData.ExcelData.TestDataReader.ReadData(1, "Status");
                string updateToStatus = TestData.ExcelData.TestDataReader.ReadData(1, "UpdateToStatus");
                Queries.GetDataPerStatus(status, data, ProjectName);
                string email = data.eMail;

                //3. Login into Admin     
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //4.Search for a Active Profile
                Admin.EnterEmail(email);
                Admin.EnterMemberNumber(data.Membership);
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Search result gets displayed");

                //5.Click on view icon in the search result row
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("User landed on Profile page");
                Logger.LogTestData(TestPlanId, TestCaseId, "Active Email", data.eMail, true);

                //6.Verify the member status is active
                Helper.ScrollDown();
                string email_updated = Admin.GetValueEmailAddress(ProjectName);
                string presentStatus = PageObject_Admin.Value_MemberStatus().GetAttribute("innerHTML");
                if (presentStatus.Equals("Active"))
                {
                    Logger.WriteDebugMessage("Status should be active");
                }
                else
                {
                    Assert.Fail("Status for the user is NOT be active");
                }

                //6.Check for the expiration date in DB.
                Queries.GetExpirationDate(email, data);
                string expirationdate = data.ExpirationDate;
                Logger.WriteDebugMessage("Make a note of Expiration date for Active Status.");

                //7.Verify the member has points
                string points = data.Balance;
                if (!points.Equals("0"))
                    Logger.WriteDebugMessage("Member has points");
                else if (ProjectName.Equals("SH"))
                    Logger.WriteDebugMessage("SH Don't support member Points");
                else
                    Assert.Fail("Member do NOT have points");

                //8.Click on the status link and update the status to Inactive
                Admin.SelectStatus(updateToStatus);
                string updatedstatus = PageObject_Admin.Value_MemberStatus().GetAttribute("innerHTML");
                if (updatedstatus.Equals(updateToStatus))
                    Logger.WriteDebugMessage("Status gets updated to inactive");
                else
                    Assert.Fail("Status is NOT updated to inactive");

                //9.Verify the points gets reset to 0
                //10.Verify Points, Nights, Active Awards & Stays
                //11.Verify the Log in table MemberStatusLog
                Helper.ReloadPage();
                Admin.EnterEmail(email_updated);
                Admin.EnterMemberNumber(data.Membership);
                Admin.Click_Button_MemberSearch();
                Admin.Click_Icon_View(ProjectName);
                Helper.PageDown();
                Queries.GetExpirationDate(email_updated, data);
                string currentDate = Queries.GetServerDate();
                Admin.VerifyMemberStatusLog(email_updated, updateToStatus, ProjectDetails.CommonAdminEmail, currentDate, ProjectName);
                Logger.WriteDebugMessage("Status , updated by and insert date should display correctly");

                //12.Check for the Expiration date in DB for Member Status 'Inactive'.             
                string updatedexpirationdate = data.ExpirationDate;
                if (ProjectName != "SH")
                {
                    if (updatedexpirationdate.Equals(expirationdate))
                        Logger.WriteDebugMessage("Expiration date should remain as it is & should NOT get updated as status is changed to Inactive");
                    else
                        Assert.Fail("Expiration Date gets updated after status change");

                }
            }
        }

        public static void TC_111605()
        {
            if (TestCaseId == Constants.TC_111605)
            {
                // Pre-requisites
                Users data = new Users();

                //1. URL and Credential is available in Test Plan Run description 
                //2.Data Requirement: Active profile who has points
                string status = TestData.ExcelData.TestDataReader.ReadData(1, "Status");
                string updateToStatus = TestData.ExcelData.TestDataReader.ReadData(1, "UpdateToStatus");
                Queries.GetDataPerStatus(status, data, ProjectName);
                string email = data.eMail;

                //3. Login into Admin     
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //4.Search for a Active Profile
                Admin.EnterEmail(email);
                Admin.EnterMemberNumber(data.Membership);
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Search result gets displayed");

                //5.Click on view icon in the search result row
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("User landed on Profile page");
                Logger.LogTestData(TestPlanId, TestCaseId, "Member Email", data.eMail);
                Logger.LogTestData(TestPlanId, TestCaseId, "Current Status", status);
                Logger.LogTestData(TestPlanId, TestCaseId, "Updated Status", updateToStatus, true);

                //6.Verify the member status is active
                string email_updated = Admin.GetValueEmailAddress(ProjectName);
                ElementWait(PageObject_Admin.Value_MemberStatus(), 180);
                string presentStatus = PageObject_Admin.Value_MemberStatus().GetAttribute("innerHTML");
                if (presentStatus.Equals("Active"))
                {
                    Logger.WriteDebugMessage("Status should be active");
                }
                else
                {
                    Assert.Fail("Status for the user is NOT be active");
                }

                //7.Verify the member has points
                string points = data.Balance;
                if (!points.Equals("0"))
                    Logger.WriteDebugMessage("Member has points");
                else
                    Assert.Fail("Member do NOT have points");

                //8.Click on the status link and update the status to deactivate
                Admin.SelectStatus(updateToStatus);
                string updatedstatus = PageObject_Admin.Value_MemberStatus().GetAttribute("innerHTML");
                if (updatedstatus.Equals(updateToStatus))
                    Logger.WriteDebugMessage("Status gets updated to Deactivate");
                else
                    Assert.Fail("Status is NOT updated to Deactivate");

                //9.Verify the points gets reset to 0
                Helper.ReloadPage();
                Admin.EnterEmail(email);
                Admin.EnterMemberNumber(data.Membership);
                Admin.Click_Button_MemberSearch();
                Admin.Click_Icon_View(ProjectName);
                string updatedpoints = PageObject_Admin.MemberInformation_Value_PointsBalance().GetAttribute("innerHTML");
                if (updatedpoints.Contains("0"))
                    Logger.WriteDebugMessage("Points should get reset to 0 refresh the screen after updating the status");
                else
                    Assert.Fail("Points is NOT getting reset to 0");

                //11.Verify the Log in table MemberStatusLog
                string currentDate = Queries.GetServerDate();
                Admin.VerifyMemberStatusLog(email_updated, updateToStatus, ProjectDetails.CommonAdminEmail, currentDate, ProjectName);
                Logger.WriteDebugMessage("Status , updated by and insert date should display correctly");
            }
        }

        public static void TC_111606()
        {
            if (TestCaseId == Constants.TC_111606)
            {
                Users data = new Users();
                //1. URL and Credential is available in Test Plan Run description 
                //2. Data Requirement: Deactivated Profile
                string status = TestData.ExcelData.TestDataReader.ReadData(1, "Status");
                string updateToStatus = TestData.ExcelData.TestDataReader.ReadData(1, "UpdateToStatus");
                string UpdateToStatusNew = TestData.ExcelData.TestDataReader.ReadData(1, "UpdateToStatusNew");
                Queries.GetDataPerStatus(status, data, ProjectName);
                string email = data.eMail;

                //3. Login into Admin     
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("User landed on home page");

                //4.Search for a Deactivated Profile
                Admin.EnterEmail(email);
                Admin.EnterMemberNumber(data.Membership);
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Search result gets displayed");

                //5.Click on view icon in the search result row
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("User landed on Profile page");
                Logger.LogTestData(TestPlanId, TestCaseId, "Member Email", data.eMail);
                Logger.LogTestData(TestPlanId, TestCaseId, "Current Status", status);
                Logger.LogTestData(TestPlanId, TestCaseId, "Updated Status", updateToStatus, true);

                //6.Verify the member status is Deactivate
                string email_updated = Admin.GetValueEmailAddress(ProjectName);
                string presentStatus = PageObject_Admin.Value_MemberStatus().GetAttribute("innerHTML");
                if (presentStatus.Equals("Deactivated"))
                {
                    Logger.WriteDebugMessage("Status should be Deactivated");
                }
                else
                {
                    Assert.Fail("Status for the user is NOT be Deactivated");
                }

                //7.Verify the member has 0 points
                string points = data.Balance;
                if (points.Equals("0"))
                    Logger.WriteDebugMessage("Member has '0' points");
                else
                    Assert.Fail("Member do NOT have '0' points");

                //8.Click on the status link and update the status to Inactive
                Admin.SelectStatus(updateToStatus);
                string updatedstatus = PageObject_Admin.Value_MemberStatus().GetAttribute("innerHTML");
                if (updatedstatus.Equals(updateToStatus))
                    Logger.WriteDebugMessage("Status gets updated to Inactive");
                else
                    Assert.Fail("Status is NOT updated to Inactive");


                //9.Verify the points remains as 0
                //10.Verify the Log in table MemberStatusLog  
                Helper.ReloadPage();
                Admin.EnterEmail(email);
                Admin.EnterMemberNumber(data.Membership);
                Admin.Click_Button_MemberSearch();
                Admin.Click_Icon_View(ProjectName);
                string currentDate = Queries.GetServerDate();
                Admin.VerifyMemberStatusLog(email_updated, updateToStatus, ProjectDetails.CommonAdminEmail, currentDate, ProjectName);
                Logger.WriteDebugMessage("Status , updated by and insert date should display correctly");

                //11.Repeat the process to verify that admin will be able to update the status from Deactivated to Activated for another profile
                Queries.GetDataPerStatus(status, data, ProjectName);
                string email1 = data.eMail;
                Helper.ReloadPage();
                Admin.EnterEmail(email1);
                Admin.EnterMemberNumber(data.Membership);
                Admin.Click_Button_MemberSearch();
                Admin.Click_Icon_View(ProjectName);
                Admin.SelectStatus(UpdateToStatusNew);
                string currentStatus = PageObject_Admin.Value_MemberStatus().GetAttribute("innerHTML");
                if (currentStatus.Equals("Active"))
                {
                    Logger.WriteDebugMessage("Status should be Active");
                }
                else
                {
                    Assert.Fail("Status for the user is NOT be Active");
                }

                Logger.WriteDebugMessage("Admin should be able to update the status from Deactivated to Activated");
                Admin.VerifyMemberStatusLog(email1, UpdateToStatusNew, ProjectDetails.CommonAdminEmail, DateTime.Today.ToString("MM/dd/yyyy"), ProjectName);
                Logger.WriteDebugMessage("Status , updated by and insert date should display correctly");
            }
        }

        public static void TC_111607()
        {
            if (TestCaseId == Constants.TC_111607)
            {
                Users data = new Users();
                //1. URL and Credential is available in Test Plan Run description 
                //2.Data Requirement: Active profile who has points
                string status = TestData.ExcelData.TestDataReader.ReadData(1, "Status");
                string updateToStatus = TestData.ExcelData.TestDataReader.ReadData(1, "UpdateToStatus");
                Queries.GetDataPerStatus(status, data, ProjectName);
                string email = data.eMail;

                //3. Login into Admin     
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                AddDelay(1500);

                //4.Search for a Active Profile
                Admin.EnterEmail(email);
                Admin.EnterMemberNumber(data.Membership);
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Search result gets displayed");
                Logger.LogTestData(TestPlanId, TestCaseId, "Member Email", data.eMail);
                Logger.LogTestData(TestPlanId, TestCaseId, "Current Status", status);
                Logger.LogTestData(TestPlanId, TestCaseId, "Updated Status", updateToStatus, true);

                //5.Click on view icon in the search result row
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("User landed on Profile page");

                //6.Verify the member status is active
                string email_updated = Admin.GetValueEmailAddress(ProjectName);
                string presentStatus = PageObject_Admin.Value_MemberStatus().GetAttribute("innerHTML");
                if (presentStatus.Equals("Inactive"))
                {
                    Logger.WriteDebugMessage("Status should be Inactive");
                }
                else
                {
                    Assert.Fail("Status for the user is NOT be Inactive");
                }

                //7.Verify the member has points
                string points = data.Balance;
                if (points.Equals("0"))
                    Logger.WriteDebugMessage("Member has points");
                else
                    Assert.Fail("Member do NOT have points");

                //8.Click on the status link and update the status to deactivate
                Admin.SelectStatus(updateToStatus);
                string updatedstatus = PageObject_Admin.Value_MemberStatus().GetAttribute("innerHTML");
                if (updatedstatus.Equals(updateToStatus))
                    Logger.WriteDebugMessage("Status gets updated to Deactivate");
                else
                    Assert.Fail("Status is NOT updated to Deactivate");

                //11.Verify the Log in table MemberStatusLog
                Helper.ReloadPage();
                Admin.EnterEmail(email);
                Admin.EnterMemberNumber(data.Membership);
                Admin.Click_Button_MemberSearch();
                Admin.Click_Icon_View(ProjectName);
                string currentDate = Queries.GetServerDate();
                Admin.VerifyMemberStatusLog(email_updated, updateToStatus, ProjectDetails.CommonAdminEmail,currentDate, ProjectName);
                Logger.WriteDebugMessage("Status , updated by and insert date should display correctly");
            }
        }

        public static void TC_189003()
        {
            if (TestCaseId == Constants.TC_189003)
            {
                Users data = new Users();
                Users activeUser = new Users();
                //1. URL and Credential is available in Test Plan Run description 
                //2.Data Requirement: Active profile who has points
                string status = TestData.ExcelData.TestDataReader.ReadData(1, "Status");
                string updateToStatus = TestData.ExcelData.TestDataReader.ReadData(1, "UpdateToStatus");
                string updateToStatus1 = TestData.ExcelData.TestDataReader.ReadData(1, "UpdateToStatus1");
                string status1 = TestData.ExcelData.TestDataReader.ReadData(1, "Status1");

                Queries.GetDataPerStatus(status, data, ProjectName);

                string email = data.eMail;

                //3. Login into Admin     
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                AddDelay(1500);

                //4.Search for a Active Profile
                Queries.GetActiveMemberEmail(activeUser);
                Admin.EnterEmail(activeUser.MemberEmail);
                Logger.WriteDebugMessage("Email address is entered");
                Admin.Click_Button_MemberSearch();
                AddDelay(1000);
                Logger.WriteDebugMessage("Member Result found on the page");
                Admin.Click_Icon_View(ProjectName);
                AddDelay(1000);
                Logger.WriteDebugMessage("Search result gets displayed");
                Logger.LogTestData(TestPlanId, TestCaseId, "Member Email", data.eMail);
                Logger.LogTestData(TestPlanId, TestCaseId, "Current Status", status);
                Logger.LogTestData(TestPlanId, TestCaseId, "Updated Status", updateToStatus, true);

                //6.Click on the status link and update the status to active and Inactive
                // Admin.SelectMemberStatus(updateToStatus);
                Admin.SelectStatus(updateToStatus);
                AddDelay(15000);

                //Click on Admin Updates tab
                Admin.Click_Tab_AdminUpdates();
                Logger.WriteDebugMessage("Navigated to Admin Update Tab");
                Helper.ScrollToElement(PageObject_Admin.AdminUpdates_Icon_View1());
                Helper.PageDown();
                Admin.Click_AdminUpdates_Icon_View1();
                VerifyTextOnPageAndHighLight(updateToStatus);
                Logger.WriteDebugMessage("Membership Status get updated successfully");

                Admin.Click_AdminUpdates_Button_Close();
                Helper.PageUp();

                Admin.SelectStatus(status1);
                AddDelay(15000);
                //Click on Admin Updates tab
                Admin.Click_Tab_AdminUpdates();
                Logger.WriteDebugMessage("Navigated to Admin Update Tab");
                Helper.ScrollToElement(PageObject_Admin.AdminUpdates_Icon_View1()); 
                Helper.PageDown();
                Admin.Click_AdminUpdates_Icon_View1();
                VerifyTextOnPageAndHighLight(status1);
                Logger.WriteDebugMessage("Membership Status get updated successfully");

                Logger.WriteDebugMessage("Test case pass successfully");


            }
        }

        #endregion TP_186894
    }
}
