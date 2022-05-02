using System;
using eLoyaltyV3.Utility;
using eLoyaltyV3.PageObject.UI;
using eLoyaltyV3.AppModule.UI;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Globalization;
using NUnit.Framework;
using Common;
using OpenQA.Selenium;
using TestData.ExcelData;
using System.Net;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Constants = eLoyaltyV3.Utility.Constants;
using eLoyaltyV3.Entity;
using InfoMessageLogger;
using TestData;
using eLoyaltyV3.PageObject.Admin;
using BaseUtility.Utility;
using Queries = eLoyaltyV3.Utility.Queries;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region TP_186887 - Admin Member Level
        public static void TC_114355()
        {
            if (TestCaseId == Constants.TC_114355)
            {
                //Prerequisites:
                Users data = new Users();

                //1.DB details, url and credential is available in master test plan run description Member Level Criteria for Upgrade and renewal is available in US#102641.
                //2.Identify an active Crystal member ship
                string level1 = "", level3 = "", level2 = "";
                Queries.GetMemberLevel(data, 1);
                string MemberLevel1 = data.MembershipLevel;
                Queries.GetMemberLevel(data, 2);
                string MemberLevel2 = data.MembershipLevel;

                if (MemberLevel1.Equals("Loyal Member Level 1"))
                {
                    level1 = "Loyal_LVL1";
                    level2 = "Loyal_LVL2";
                }
                else if (MemberLevel1.Equals("Engage Explorer"))
                {
                    level1 = "EXPLORER";
                    level2 = "HIGHFLYERS";
                }
                else if (MemberLevel1.Equals("Club Member"))
                {
                    level1 = "MEMBER";
                    level2 = "PREFERRED";
                }
                else if (MemberLevel1.Equals("One"))
                {
                    level1 = "LevelOne";
                    level2 = "LevelTwo";
                }
                else
                {
                    level1 = MemberLevel1;
                    level2 = MemberLevel2;
                }
                Queries.GetDataAsPerMemberLevel(level1, data);

                /*// Added for FRASER
                level1 = "Crystal";
                level3 = "DIAMOND";*/
                Logger.WriteDebugMessage("Profile identified");
                Logger.LogTestData(TestPlanId, TestCaseId, "Member Level 1", level1);
                Logger.LogTestData(TestPlanId, TestCaseId, "Member Level 2", level2);

                //3.Capture the expiration date in memberships table
                string expirationdate = data.ExpirationDate;
                Logger.WriteDebugMessage("Expiration date captured");

                //4.  Login to Admin
                //4.1 Profile the member
                //4.2 Navigate to Member Information page by clicking on view icon
                //4.3 Update the member level to Sapphire
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                Admin.EnterEmail(data.MemberEmail);
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Member Search found");
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("User should be redirected to Dashborad page" + MemberLevel1);
                Logger.LogTestData(TestPlanId, TestCaseId, "Member Email for " + MemberLevel1, data.MemberEmail, true);
                email = Admin.GetValueEmailAddress(ProjectName);
                Admin.SelectLevel(MemberLevel2);
                Logger.WriteDebugMessage("Member Level got Upgrated");
                try
                {
                    Admin.Click_Member_Level_Email_Yes_Button();
                }
                catch (Exception)
                {
                    Logger.WriteDebugMessage("Member Level confirmation Overlay is not displaying");
                }
                string updateMemberLevel = Queries.ReturnMembership("MembershipLevel", email).ToLower();
                if (updateMemberLevel.Equals(level2.ToLower()))
                    Logger.WriteDebugMessage("Member level gets upgraded to " + MemberLevel2);
                else
                    Assert.Fail("Member Level is NOT updated to " + MemberLevel2);
                
                //5.Verify the expiration date
                Queries.GetExpirationDate(email, data);
                string updatedexpirationdate = data.ExpirationDate;
                Admin.VerifyExpirationDate(updatedexpirationdate, ProjectName);
                Logger.WriteDebugMessage("Should be today's date + 2 year");
            }
        }

        public static void TC_114356()
        {
            if (TestCaseId == Constants.TC_114356)
            {
                //Prerequisites:
                Users data = new Users();

                //1.DB details, url and credential is available in master test plan run description Member Level Criteria for Upgrade and renewal is available in US#102641.
                //2.Identify an active Crystal member ship
                string level1 = "", level3 = "";
                Queries.GetMemberLevel(data, 1);
                string MemberLevel1 = data.MembershipLevel;
                Queries.GetMemberLevel(data, 3);
                string MemberLevel3 = data.MembershipLevel;
                if (MemberLevel1.Equals("Club Member"))
                {
                    level1 = "MEMBER";
                    level3 = "ELITE";
                }
                else if (MemberLevel1.Equals("One"))
                {
                    level1 = "LevelOne";
                    level3 = "LevelThree";
                }
                else
                {
                    level1 = MemberLevel1;
                    level3 = MemberLevel3;
                }
                Queries.GetDataAsPerMemberLevel(level1, data);

                Logger.WriteDebugMessage("Profile identified");
                Logger.LogTestData(TestPlanId, TestCaseId, "Member Level 1", level1);
                Logger.LogTestData(TestPlanId, TestCaseId, "Member Level 3", level3);

                //3.Capture the expiration date in memberships table
                string expirationdate = data.ExpirationDate;
                Logger.WriteDebugMessage("Expiration date captured");

                //4.  Login to Admin
                //4.1 Profile the member
                //4.2 Navigate to Member Information page by clicking on view icon
                //4.3 Update the member level to Sapphire
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                Admin.EnterEmail(data.MemberEmail);
                Admin.Click_Button_MemberSearch();
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("User should be redirected to Dashborad page" + MemberLevel1);
                Logger.LogTestData(TestPlanId, TestCaseId, "Member Email", data.MemberEmail, true);
                string email = Admin.GetValueEmailAddress(ProjectName);
                Admin.SelectLevel(MemberLevel3);
                try
                {
                    Admin.Click_Member_Level_Email_Yes_Button();
                }
                catch (Exception)
                {
                    Logger.WriteDebugMessage("Membership Upgrade overlay is not displaying");
                }
                string updateMemberLevel = Queries.ReturnMembership("MembershipLevel", email).ToLower();
                if (updateMemberLevel.Equals(level3.ToLower()))
                    Logger.WriteDebugMessage("Member level gets upgraded to " + MemberLevel3);
                else
                    Assert.Fail("Member Level is NOT updated to " + MemberLevel3);
                Logger.WriteDebugMessage("Member level gets upgraded to Sapphire" + MemberLevel3);

                //5.Verify the expiration date
                Queries.GetExpirationDate(email, data);
                string updatedexpirationdate = data.ExpirationDate;
                Admin.VerifyExpirationDate(updatedexpirationdate, ProjectName);
                Logger.WriteDebugMessage("Should be today's date + 2 year");
            }
        }

        public static void TC_114357()
        {
            if (TestCaseId == Constants.TC_114357)
            {
                //Prerequisites:
                Users data = new Users();
                string MemberLevel2, MemberLevel4;
                
                //1.DB details, url and credential is available in master test plan run description Member Level Criteria for Upgrade and renewal is available in US#102641.
                //2.Identify an active Crystal member ship
                if (ProjectName.Equals("SandyLane"))
                {
                    Queries.GetMemberLevel(data, 1);
                    MemberLevel2 = data.Membershiplevel;
                    Queries.GetMemberLevel(data, 2);
                    MemberLevel4 = data.Membershiplevel;

                }
                else if (ProjectName.Equals("SH"))
                {
                    Queries.GetMemberLevel(data, 2);
                    MemberLevel2 = data.MembershipLevel;
                    Queries.GetMemberLevel(data, 3);
                    MemberLevel4 = data.MembershipLevel;

                }
                else
                {
                    Queries.GetMemberLevel(data, 2);
                    MemberLevel2 = data.Membershiplevel;
                    Queries.GetMemberLevel(data, 4);
                    MemberLevel4 = data.Membershiplevel;
                }

                Queries.GetDataAsPerMemberLevel(MemberLevel4, data);
                Logger.WriteDebugMessage("Profile identified");
                Logger.LogTestData(TestPlanId, TestCaseId, "Member Level 2", MemberLevel2);
                Logger.LogTestData(TestPlanId, TestCaseId, "Member Level 4", MemberLevel4);

                //3.Capture the expiration date in memberships table
                string expirationdate = data.ExpirationDate;
                Logger.WriteDebugMessage("Expiration date captured");

                //4.  Login to Admin
                //4.1 Profile the member
                //4.2 Navigate to Member Information page by clicking on view icon
                //4.3 Update the member level to Sapphire
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                Admin.EnterEmail(data.MemberEmail);
                Admin.Click_Button_MemberSearch();
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("User should be redirected to Dashborad page" + MemberLevel4);
                Logger.LogTestData(TestPlanId, TestCaseId, "Member Email", data.MemberEmail, true);
                string email = Admin.GetValueEmailAddress(ProjectName);
                Admin.SelectLevel(MemberLevel2);
                try
                {
                    Admin.Click_Member_Level_Email_Yes_Button();
                }
                catch (Exception)
                {
                    Logger.WriteDebugMessage("Membership Upgrade overlay is not displaying");
                }
                Logger.WriteDebugMessage("Member level gets upgraded to " + MemberLevel2);

                //5.Verify the expiration date
                Queries.GetExpirationDate(email, data);
                string updatedexpirationdate = data.ExpirationDate;
                Admin.VerifyExpirationDate(updatedexpirationdate, ProjectName);
                Logger.WriteDebugMessage("Expiration date should be set (after 12 Months) at the end of the month from the month of registration");
            }
        }

        public static void TC_114358()
        {
            if (TestCaseId == Constants.TC_114358)
            {
                //Prerequisites:
                Users data = new Users();
                string level1 = "", level3 = "";
                
                //1.DB details, url and credential is available in master test plan run description Member Level Criteria for Upgrade and renewal is available in US#102641.
                //2.Identify an active Crystal member ship
                Queries.GetMemberLevel(data, 1);
                string MemberLevel1 = data.MembershipLevel;
                Queries.GetMemberLevel(data, 3);
                string MemberLevel3 = data.MembershipLevel;

                if (MemberLevel1.Equals("Club Member"))
                {
                    level1 = "MEMBER";
                    level3 = "ELITE";
                }
                else if (MemberLevel1.Equals("One"))
                {
                    level1 = "LevelOne";
                    level3 = "LevelThree";
                }
                else
                {
                    level1 = MemberLevel1;
                    level3 = MemberLevel3;
                }
                Queries.GetDataAsPerMemberLevel(level1, data);

                Logger.WriteDebugMessage("Profile identified");
                Logger.LogTestData(TestPlanId, TestCaseId, "Member Level 1", level1);
                Logger.LogTestData(TestPlanId, TestCaseId, "Member Level 3", level3);

                //3.Capture the expiration date in memberships table
                string expirationdate = data.ExpirationDate;
                Logger.WriteDebugMessage("Expiration date captured");

                //4.  Login to Admin
                //4.1 Profile the member
                //4.2 Navigate to Member Information page by clicking on view icon
                //4.3 Update the member level to Sapphire
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                Admin.EnterEmail(data.MemberEmail);
                Admin.Click_Button_MemberSearch();
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("User should be redirected to Dashborad page");
                Logger.LogTestData(TestPlanId, TestCaseId, "Member Email", data.MemberEmail, true);
                string email = Admin.GetValueEmailAddress(ProjectName);
                Admin.SelectLevel(MemberLevel3);
                try
                {
                    Admin.Click_Member_Level_Email_Yes_Button();
                }
                catch (Exception)
                {
                    Logger.WriteDebugMessage("Membership Upgrade overlay is not displaying");
                }
                string updateMemberLevel = Queries.ReturnMembership("MembershipLevel", email).ToLower();
                if (updateMemberLevel.Equals(level3.ToLower()))
                    Logger.WriteDebugMessage("Member level gets upgraded to " + level3);
                else
                    Assert.Fail("Member Level is NOT updated to " + level3);

                //5.Verify the expiration date
                Queries.GetExpirationDate(email, data);
                string updatedexpirationdate = data.ExpirationDate;
                Admin.VerifyExpirationDate(updatedexpirationdate, ProjectName);
                Logger.WriteDebugMessage("Expiration date should be set (after 24 Months) at the end of the month from the month of registration");
            }
        }

        public static void TC_189002()
        {
            if (TestCaseId == Constants.TC_189002)
            {
                //Pre-requisite
                string memberLevel1, memberLevel2, memberLevel3, upgradeemail;
                Users data = new Users();

                upgradeemail = TestDataReader.ReadData(1, "upgradeemail");

                // Navigate to Admin and Search for User
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Queries.GetMemberLevel(data, 1);
                memberLevel1 = data.MembershipLevel;
                if (memberLevel1.Equals("Club Member"))
                {
                    memberLevel1 = "MEMBER";
                }
                Queries.GetDataAsPerMemberLevel(memberLevel1, data);
                Admin.EnterEmail(data.MemberEmail);
                Logger.WriteDebugMessage("User entered in email text box");
                Admin.Click_Button_MemberSearch();
                ElementWait(PageObject_Admin.Admin_Button_ViewMember(ProjectName), 60);
                Logger.WriteDebugMessage("Member Result found on the page");
                Admin.Click_Icon_View(ProjectName);
                ElementWait(PageObject_Admin.Value_Information_MemberLevel(), 60);
                Logger.WriteDebugMessage("Landed on member information Page");

                //Member Level 'Club Member' to 'Preffered'
                Queries.GetMemberLevel(data, 2);
                memberLevel2 = data.MembershipLevel;
                Admin.SelectLevel(memberLevel2);
                Logger.WriteDebugMessage("Send Level upgrade email to Member pop-up is displyed.");
                Admin.Click_Member_Level_Email_Yes_Button();
                Helper.VerifyTextOnPageAndHighLight(upgradeemail);

                AddDelay(5000);


                //Click on Admin Updates tab
                Admin.Click_Tab_AdminUpdates();
                Logger.WriteDebugMessage("Navigated to Admin Update Tab");
                Admin.Click_AdminUpdates_Icon_View1();
                VerifyTextOnPageAndHighLight(memberLevel2);
                Logger.WriteDebugMessage("Membership level get updated successfully");


                // Member Level 'Club Member' to 'Elite Club Member'
                Helper.ReloadPage();
                Queries.GetMemberLevel(data, 1);
                memberLevel1 = data.MembershipLevel;
                if (memberLevel1.Equals("Club Member"))
                {
                    memberLevel1 = "MEMBER";
                }
                Queries.GetDataAsPerMemberLevel(memberLevel1, data);
                Admin.EnterEmail(data.MemberEmail);
                Logger.WriteDebugMessage("User entered in email text box");
                Admin.Click_Button_MemberSearch();
                ElementWait(PageObject_Admin.Admin_Button_ViewMember(ProjectName), 60);
                Logger.WriteDebugMessage("Member Result found on the page");
                Admin.Click_Icon_View(ProjectName);
                ElementWait(PageObject_Admin.Value_Information_MemberLevel(), 60);
                Logger.WriteDebugMessage("Landed on member information Page");

                Queries.GetMemberLevel(data, 3);
                memberLevel3 = data.MembershipLevel;
                Admin.SelectLevel(memberLevel3);
                Admin.Click_Member_Level_Email_Yes_Button();
                AddDelay(5000);

                //Click on Admin Updates tab
                Admin.Click_Tab_AdminUpdates();
                Logger.WriteDebugMessage("Navigated to Admin Update Tab");
                Admin.Click_AdminUpdates_Icon_View1();
                VerifyTextOnPageAndHighLight(memberLevel3);
                Logger.WriteDebugMessage("Membership level get updated successfully");

                // Member Level 'Elite Club Member' to 'Club Member'
                Helper.ReloadPage();
                Queries.GetMemberLevel(data, 3);
                memberLevel3 = data.MembershipLevel;
                if (memberLevel3.Equals("Elite Club Member"))
                {
                    memberLevel3 = "ELITE";
                }
                Queries.GetDataAsPerMemberLevel(memberLevel3, data);
                Admin.EnterEmail(data.MemberEmail);
                Logger.WriteDebugMessage("User entered in email text box");
                Admin.Click_Button_MemberSearch();
                ElementWait(PageObject_Admin.Admin_Button_ViewMember(ProjectName), 60);
                Logger.WriteDebugMessage("Member Result found on the page");
                Admin.Click_Icon_View(ProjectName);
                ElementWait(PageObject_Admin.Value_Information_MemberLevel(), 60);
                Logger.WriteDebugMessage("Landed on member information Page");

                Queries.GetMemberLevel(data, 1);
                memberLevel1 = data.MembershipLevel;
                Admin.SelectLevel(memberLevel1);
                AddDelay(5000);

                // Click on Admin Updates tab
                Admin.Click_Tab_AdminUpdates();
                Logger.WriteDebugMessage("Navigated to Admin Update Tab");
                Admin.Click_AdminUpdates_Icon_View1();
                VerifyTextOnPageAndHighLight(memberLevel1);
                Logger.WriteDebugMessage("Membership level get updated successfully");

                //Test data
                Logger.LogTestData(TestPlanId, TestCaseId, "First Member Level", memberLevel1);
                Logger.LogTestData(TestPlanId, TestCaseId, "Second Member Level", memberLevel2);
                Logger.LogTestData(TestPlanId, TestCaseId, "Third Member Level", memberLevel3, true);
            }
        }

        #endregion TP_186887
    }
}
