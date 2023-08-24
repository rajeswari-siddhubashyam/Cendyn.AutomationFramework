using eLoyaltyV3.AppModule.UI;
using eLoyaltyV3.Entity;
using InfoMessageLogger;
using eLoyaltyV3.PageObject.Admin;
using TestData;
using NUnit.Framework;
using System;
using Queries = eLoyaltyV3.Utility.Queries;
using Constants = eLoyaltyV3.Utility.Constants;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region TP_186906 - Admin Member Reset
        public static void TC_115262()
        {
            if (TestCaseId == Constants.TC_115262)
            {
                Users data = new Users();
                Random randum = new Random();
                Queries.GetActiveMemberEmail(data);

                //1. Login to Admin              
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //2.Search for a member and click the "View" icon.
                Admin.EnterEmail(data.MemberEmail);
                Admin.Click_Button_MemberSearch();
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Land on the 'Member Information' tab.");
                Logger.LogTestData(TestPlanId, TestCaseId, "Active Email", data.MemberEmail);

                //3.Click the "Member Login: Resend" link.
                //4.Change the member's email and click "Update".
                string updateEmail = String.Concat("QATest", randum.Next().ToString(), "@cendyn17.com");
                Admin.SendResetLogin(updateEmail); 
                AddDelay(60000);
                VerifyTextOnPage("Reset successful.");
                Logger.WriteDebugMessage("'Reset successful' message is displayed.");
                Logger.LogTestData(TestPlanId, TestCaseId, "Updated Email", updateEmail);

                //5.Verify the member "Email" label is updated to reflect the changed email.
                VerifyTextOnPageAndHighLight(updateEmail);
                Logger.WriteDebugMessage("The 'Email' label displays the updated email address.");

                if (!((ProjectName.Equals("ALH") || ProjectName.Equals("AquaAston"))))
                {
                    //6.Verify User should not be able to login using old email 
                    Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
                    Logger.WriteDebugMessage("User should be Landed on frontEnd Portal ");
                    if (ProjectName.Equals("HotelIcon"))
                    {
                        Navigation.Click_Button_SignIn();
                    }
                    LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                    Logger.WriteDebugMessage("User should not be able to login to portal using old email ");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Invalid Login", data.MemberEmail);

                    //7.Verify user should be able to login using updated email 
                    LoginCredentials(updateEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                    Logger.WriteDebugMessage("User should be able to login to portal using  updated login");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Valid Login", updateEmail, true);
                }

            }
        }

        public static void TC_115265()
        {
            if (TestCaseId == Constants.TC_115265)
            {
                string searchEmail = "testdivya";
                Users data = new Users();

                //1. Login to Admin              
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //2.Search for a member and click the "View" icon.
                if (ProjectName.Equals("AquaAston"))
                {
                    Admin.SelectMemberStatus("Active");
                }
                else
                {
                    Admin.EnterEmail(searchEmail);
                }
                string value = String.Concat(searchEmail, "@", "cendyn17.com");
                Admin.Click_Button_MemberSearch();
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Land on the 'Member Information' tab.");
                Logger.LogTestData(TestPlanId, TestCaseId, "Test Data", searchEmail);
                Logger.LogTestData(TestPlanId, TestCaseId, "Email", value, true);

                //3.Click the "Member Login: Resend" link.
                //4.Change the member's email and click "Update".
                string updateEmail = MakeCatchAllUnique(value);
                Admin.SendResetLogin(updateEmail);

                VerifyTextOnPage("Reset successful.");
                Logger.WriteDebugMessage("'Reset successful' message is displayed.");

                //5.Click the "Activation Email Resend" link.
                Admin.Click_MemberInformation_Value_ActivationEmail();
                string value1 = Getdata(PageObject_Admin.MemberInformation_ActivationEmail_UserLogin());
                if (value1.Equals(updateEmail))
                {
                    Logger.WriteDebugMessage("The updated email address is displayed in the popup.");
                }
                else
                {
                    Assert.Fail("The updated email address is NOT displayed in the popup");
                }


            }
        }

        public static void TC_115266()
        {
            if (TestCaseId == Constants.TC_115266)
                {
                    string searchEmail = "testdivya";
                    Users data = new Users();

                    //1. Login to Admin              
                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    //2.Search for a member and click the "View" icon.
                    if (ProjectName.Equals("SandyLane") || ProjectName.Equals("AquaAston"))
                    {
                        Admin.SelectMemberStatus("Active");
                    }
                    else
                    {
                        Admin.EnterEmail(searchEmail);
                    }
                    string value = String.Concat(searchEmail, "@", "Cendyn17.com");
                    Admin.Click_Button_MemberSearch();
                    Admin.Click_Icon_View(ProjectName);
                    Logger.WriteDebugMessage("Land on the 'Member Information' tab.");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Test Data", searchEmail);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Email", value, true);

                    //3.Click the "Member Login: Resend" link.
                    //4.Change the member's email and click "Update".
                    string updateEmail = MakeCatchAllUnique(value);
                    Admin.SendResetLogin(updateEmail);
                    AddDelay(60000);
                    VerifyTextOnPage("Reset successful.");
                    Logger.WriteDebugMessage("'Reset successful' message is displayed.");
                    AddDelay(30000);
                    //5.Click the "Welcome Email Resend" link.
                    if (!(ProjectName.Equals("EHPC") || (ProjectName.Equals("Sacher"))))
                    {
                        Admin.Click_MemberInformation_Value_WelcomeEmail();
                        string value1 = Getdata(PageObject_Admin.MemberInformation_WelcomeEmail_UserLogin());
                        if (value1.Equals(updateEmail))
                        {
                            Logger.WriteDebugMessage("The updated email address is displayed in the popup.");
                        }
                        else
                        {
                            Assert.Fail("The updated email address is NOT displayed in the popup");
                        }
                    }
             }
        }

        public static void TC_115267()
        {
            if (TestCaseId == Constants.TC_115267)
            {
                //1. Login to Admin 
                Users data = new Users();
                string alreadyExistEmail = TestData.ExcelData.TestDataReader.ReadData(1, "AlreadyExistEmail");
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                Queries.GetActiveMemberEmail(data);

                //2.Search for a member and click the "View" icon.
                if (ProjectName.Equals("SandyLane") || ProjectName.Equals("AquaAston"))
                {
                    Admin.SelectMemberStatus("Active");
                }
                else
                {
                    Admin.EnterEmail(data.MemberEmail);
                }
                Admin.Click_Button_MemberSearch();
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Land on the 'Member Information' tab.");
                Logger.LogTestData(TestPlanId, TestCaseId, "Active Email", data.MemberEmail);
                Logger.LogTestData(TestPlanId, TestCaseId, "Already Existing Email", alreadyExistEmail, true);

                //3.Click the "Member Login: Resend" link.
                //4.Change the member's email to an email address of another member and click "Update".             
                Admin.SendResetLogin(alreadyExistEmail);
                VerifyTextOnPage("This email address is already associated with another account.");
                Logger.WriteDebugMessage("'This email address is already associated with another account.' message is displayed and the email is not saved/updated.");
            }
        }

        #endregion
    }
}
