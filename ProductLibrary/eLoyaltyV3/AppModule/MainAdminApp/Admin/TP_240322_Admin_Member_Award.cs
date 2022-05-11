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
    public partial class MainAdminApp : eLoyaltyV3.Utility.Setup
    {
        public static void TC_116979()
        {
            if (TestCaseId == Constants.TC_116979)
            {
                //Navigate to login page
                Users data = new Users();
                Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
                Logger.WriteDebugMessage("user landed on login page");

                //Log into Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Search for an user whose status = Issued 
                string awardstatus = TestData.ExcelData.TestDataReader.ReadData(1, "AwardStatus").Trim();
                Queries.GetEmailWithAward(data, awardstatus);
                Admin.EnterEmail(data.MemberEmail);
                Admin.Click_Button_MemberSearch();
                Helper.ElementWait(PageObject_Admin.Admin_Button_ViewMember(ProjectName), 300);
                Logger.WriteDebugMessage("Search result gets displayed");

                //Click on view followed by click on My award tab
                Admin.Click_Icon_View(ProjectName);
                Helper.ElementWait(PageObject_Admin.Tab_MemberAwards(), 300);
                Admin.Click_Tab_MemberAwards();
                Logger.WriteDebugMessage("Member awrad tab should clicked");

                //Filter with status "Sent via email"
                Admin.MemberAwards_Text_Filter(data.VoucherNumber);
                ElementWait(PageObject_Admin.Admin_MemberAward_PreviousButton(), 5000);
                VerifyTextOnPageAndHighLight(data.VoucherNumber);
                Logger.WriteDebugMessage("Voucher Number should get displayed");

                //Click on Member portal
                Admin.Click_MemberInformation_Value_MemberPortal();
                AddDelay(20000);
                Logger.WriteDebugMessage("User landed on My Stay  page  in new  same guest portal window");

                //Maximize the  guest portal window 
                ControlToNewWindow();
                Driver.Manage().Window.Maximize();
                Logger.WriteDebugMessage("Guest portal window gets Maximize");

                //Click on My award tab
                Navigation.Click_Link_MyAward();
                AddDelay(5000);
                Helper.ElementWait(PageObject_Navigation.MyAwards_Text_Filter(), 5000);
                Logger.WriteDebugMessage("My award tab should clicked");

                //Search for Award name
                Navigation.MyAwards_Text_Filter(data.VoucherNumber);
                Helper.DynamicScrollToText(Helper.Driver, data.VoucherNumber);
                VerifyTextOnPageAndHighLight(data.VoucherNumber);
                Logger.WriteDebugMessage("Voucher Number should get displayed");
            }
        }
        public static void TC_116403()
        {
            if (TestCaseId == Constants.TC_116403)
            {
                Users data = new Users();
                //1.Navigate to Admin Login page
                Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
                Logger.WriteDebugMessage("User landed on Admin Login Page");
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("User logged in succesfully");
                //2.Identify the email id having Status Redeemed
                string awardstatus = TestData.ExcelData.TestDataReader.ReadData(1, "AwardStatus").Trim();
                Queries.GetEmailWithAward(data, awardstatus);
                //3.Enter Email in Member Search and Click on View button
                Admin.EnterEmail(data.MemberEmail);
                Logger.WriteDebugMessage("Email with Award status as Redeemed is Entered");
                Admin.Click_Button_MemberSearch();
                Helper.ElementWait(PageObject_Admin.Admin_Button_ViewMember(ProjectName), 300);
                Logger.WriteDebugMessage("Member result displayed.");
                Admin.Click_Icon_View(ProjectName);
                Helper.ElementWait(PageObject_Admin.Tab_MemberAwards(), 300);
                Logger.WriteDebugMessage("Landed on Member Information Page");

                //Click on Member Award Page
                Helper.ScrollDown();
                Logger.WriteDebugMessage("Member Award tab is displaying with Awards");

                // Search the Award id
                Admin.Click_Tab_MemberAwards();
                Admin.MemberAwards_Text_Filter(data.VoucherNumber);
                AddDelay(6000);
                ElementWait(PageObject_Admin.Admin_MemberAward_PreviousButton(), 360);
                VerifyTextOnPageAndHighLight(data.VoucherNumber);
                Logger.WriteDebugMessage("Award Identified on Admin");

                // Navigate to Front end
                Admin.Click_MemberInformation_Value_MemberPortal();
                AddDelay(20000);
                Logger.WriteDebugMessage("Navigated to Portal");

                //Control to new Window and maximize the page 
                ControlToNewWindow();
                Driver.Manage().Window.Maximize();
                Helper.PageDown();


                //Click on My Award Page
                Navigation.Click_Link_MyAward();
                Helper.ElementWait(PageObject_Navigation.MyAwards_Text_Filter(), 300);
                Logger.WriteDebugMessage("Landed on My Award Page");

                // Search for Identified Award
                Navigation.MyAwards_Text_Filter(data.VoucherNumber);
                Helper.DynamicScrollToText(Helper.Driver, data.VoucherNumber);
                Logger.WriteDebugMessage("Award filtered on the page");
                VerifyTextOnPageAndHighLight(data.VoucherNumber);
                Logger.WriteDebugMessage("Award Identified on Frontend");

                //Log test data into Log file
                Logger.LogTestData(TestPlanId, TestCaseId, "Award Status", awardstatus);
                Logger.LogTestData(TestPlanId, TestCaseId, "User Email", data.MemberEmail);
                Logger.LogTestData(TestPlanId, TestCaseId, "Voucher Number", data.VoucherNumber, true);

            }
        }
        public static void TC_116980()
        {
            if (TestCaseId == Constants.TC_116980)
            {
                string awardstatus, frontendstatus;
                Users data = new Users();
                //1.Navigate to Admin Login page
                Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
                Logger.WriteDebugMessage("User landed on Admin Login Page");
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("User logged in succesfully");
                //2.Identify the email id having Status Redeemed
                awardstatus = TestData.ExcelData.TestDataReader.ReadData(1, "AwardStatus").Trim();
                frontendstatus = TestData.ExcelData.TestDataReader.ReadData(1, "FrontEndStatus").Trim();
                Queries.GetEmailWithAward(data, awardstatus);

                //3.Enter Email in Member Search and Click on View button
                Admin.EnterEmail(data.MemberEmail);
                Admin.EnterMemberNumber(data.MemberShipId);
                Logger.WriteDebugMessage("Email with Award status as Redeemed is Entered");
                Admin.Click_Button_MemberSearch();
                Helper.ElementWait(PageObject_Admin.Admin_Button_ViewMember(ProjectName), 300);
                Logger.WriteDebugMessage("Member result displayed.");
                Admin.Click_Icon_View(ProjectName);
                Helper.ElementWait(PageObject_Admin.Tab_MemberAwards(), 300);
                Logger.WriteDebugMessage("Landed on Member Information Page");

                //Click on Member Award Page
                Helper.ScrollDown();
                Logger.WriteDebugMessage("Member Award tab is displaying with Awards");

                // Search the Award id
                Admin.Click_Tab_MemberAwards();
                Admin.MemberAwards_Text_Filter(data.VoucherNumber);
                AddDelay(10000);
                ElementWait(PageObject_Admin.Admin_MemberAward_PreviousButton(), 360);
                VerifyTextOnPageAndHighLight(data.VoucherNumber);
                Logger.WriteDebugMessage("Award Identified on Admin");

                // Navigate to Front end
                Admin.Click_MemberInformation_Value_MemberPortal();
                AddDelay(20000);
                Logger.WriteDebugMessage("Navigated to Portal");

                //Control to new Window and maximize the page 
                ControlToNewWindow();
                Driver.Manage().Window.Maximize();
                Helper.PageDown();


                //Click on My Award Page
                Navigation.Click_Link_MyAward();
                Helper.ElementWait(PageObject_Navigation.MyAwards_Text_Filter(), 300);
                Logger.WriteDebugMessage("Landed on My Award Page");

                // Search for Identified Award
                Navigation.MyAwards_Text_Filter(data.VoucherNumber);
                Helper.DynamicScrollToText(Helper.Driver, data.VoucherNumber);
                Logger.WriteDebugMessage("Award filtered on the page");
                VerifyTextOnPageAndHighLight(data.VoucherNumber);
                VerifyTextOnPageAndHighLight(frontendstatus);

                Logger.WriteDebugMessage("Award Identified on Frontend");

                //Log test data into Log file
                Logger.LogTestData(TestPlanId, TestCaseId, "Award Status", awardstatus);
                Logger.LogTestData(TestPlanId, TestCaseId, "Frontend Award Status", frontendstatus);
                Logger.LogTestData(TestPlanId, TestCaseId, "User Email", data.MemberEmail);
                Logger.LogTestData(TestPlanId, TestCaseId, "Voucher Number", data.VoucherNumber, true);

            }
        }
        public static void TC_116978()
        {
            if (TestCaseId == Constants.TC_116978)
            {
                string awardstatus, adminstatus;
                Users data = new Users();
                //1.Navigate to Admin Login page
                Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
                Logger.WriteDebugMessage("User landed on Admin Login Page");
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("User logged in succesfully");
                //2.Identify the email id having Status Redeemed
                awardstatus = TestData.ExcelData.TestDataReader.ReadData(1, "AwardStatus").Trim();
                adminstatus = TestData.ExcelData.TestDataReader.ReadData(1, "FrontEndStatus").Trim();
                Queries.GetMemberwithEgiftAward(data, awardstatus);

                //3.Enter Email in Member Search and Click on View button
                Admin.EnterEmail(data.MemberEmail);
                Admin.EnterMemberNumber(data.MemberShipId);
                Logger.WriteDebugMessage("Email with Award status as Redeemed is Entered");
                Admin.Click_Button_MemberSearch();
                Helper.ElementWait(PageObject_Admin.Admin_Button_ViewMember(ProjectName), 300);
                Logger.WriteDebugMessage("Member result displayed.");
                Admin.Click_Icon_View(ProjectName);
                Helper.ElementWait(PageObject_Admin.Tab_MemberAwards(), 300);
                Logger.WriteDebugMessage("Landed on Member Information Page");

                //Click on Member Award Page
                Helper.ScrollDown();
                Logger.WriteDebugMessage("Member Award tab is displaying with Awards");

                // Search the Award id
                Admin.Click_Tab_MemberAwards();
                Admin.MemberAwards_Text_Filter(data.VoucherNumber);
                AddDelay(6000);
                ElementWait(PageObject_Admin.Admin_MemberAward_PreviousButton(), 360);
                VerifyTextOnPageAndHighLight(data.VoucherNumber);
                VerifyTextOnPageAndHighLight(adminstatus);
                Logger.WriteDebugMessage("Award Identified on Admin");

                // Navigate to Front end
                Admin.Click_MemberInformation_Value_MemberPortal();
                AddDelay(20000);
                Logger.WriteDebugMessage("Navigated to Portal");

                //Control to new Window and maximize the page 
                ControlToNewWindow();
                Driver.Manage().Window.Maximize();
                Helper.PageDown();


                //Click on My Award Page
                Navigation.Click_Link_MyAward();
                
                if (Helper.IsElementDisplayed(PageObject_Navigation.MyAwards_Text_Filter()))
                {
                    Helper.ElementWait(PageObject_Navigation.MyAwards_Text_Filter(), 300);
                    Logger.WriteDebugMessage("Landed on My Award Page");

                    // Search for Identified Award
                    Navigation.MyAwards_Text_Filter(data.VoucherNumber);
                    Logger.WriteDebugMessage("Award filtered on the page");
                    VerifyTextOnPageAndHighLight("No data available");
                }          

                Logger.WriteDebugMessage("Ordered Status Award are not displaying on Frontend");

                //Log test data into Log file
                Logger.LogTestData(TestPlanId, TestCaseId, "Award Status", awardstatus);
                Logger.LogTestData(TestPlanId, TestCaseId, "Admin Award Status", adminstatus);
                Logger.LogTestData(TestPlanId, TestCaseId, "User Email", data.MemberEmail);
                Logger.LogTestData(TestPlanId, TestCaseId, "Voucher Number", data.VoucherNumber, true);

            }
        }
        public static void TC_116401()
        {
            if (TestCaseId == Constants.TC_116401)
            {
                string awardstatus, displayStatus;
                Users data = new Users();

                //1.Navigate to Admin Login page
                Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
                Logger.WriteDebugMessage("User landed on Admin Login Page");
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("User logged in succesfully");
                //2.Identify the email id having Status Redeemed
                awardstatus = TestData.ExcelData.TestDataReader.ReadData(1, "AwardStatus").Trim();
                displayStatus = TestData.ExcelData.TestDataReader.ReadData(1, "DisplayStatus").Trim();
                Queries.GetMemberwithNonEgiftAward(data, awardstatus);

                //3.Enter Email in Member Search and Click on View button
                Admin.EnterEmail(data.MemberEmail);
                Admin.EnterMemberNumber(data.MemberShipId);
                Logger.WriteDebugMessage("Email with Award status as Redeemed is Entered");
                Admin.Click_Button_MemberSearch();
                Helper.ElementWait(PageObject_Admin.Admin_Button_ViewMember(ProjectName), 300);
                Logger.WriteDebugMessage("Member result displayed.");
                Admin.Click_Icon_View(ProjectName);
                Helper.ElementWait(PageObject_Admin.Tab_MemberAwards(), 300);
                Logger.WriteDebugMessage("Landed on Member Information Page");

                //Click on Member Award Page
                Helper.ScrollDown();
                Logger.WriteDebugMessage("Member Award tab is displaying with Awards");

                // Search the Award id
                Admin.Click_Tab_MemberAwards();
                Admin.MemberAwards_Text_Filter(data.VoucherNumber);
                AddDelay(6000);
                ElementWait(PageObject_Admin.Admin_MemberAward_PreviousButton(), 360);
                VerifyTextOnPageAndHighLight(data.VoucherNumber);
                VerifyTextOnPageAndHighLight(displayStatus);
                Logger.WriteDebugMessage("Award Identified on Admin");

                // Navigate to Front end
                Admin.Click_MemberInformation_Value_MemberPortal();
                AddDelay(20000);
                Logger.WriteDebugMessage("Navigated to Portal");

                //Control to new Window and maximize the page 
                ControlToNewWindow();
                Driver.Manage().Window.Maximize();
                Helper.PageDown();


                //Click on My Award Page
                Navigation.Click_Link_MyAward();
                Helper.ElementWait(PageObject_Navigation.MyAwards_Text_Filter(), 300);
                Logger.WriteDebugMessage("Landed on My Award Page");

                // Search for Identified Award
                Navigation.MyAwards_Text_Filter(data.VoucherNumber);
                Logger.WriteDebugMessage("Award filtered on the page");
                Helper.ClickTextOnPage(data.AwardName);
                VerifyTextOnPageAndHighLight(data.VoucherNumber);
                VerifyTextOnPageAndHighLight(displayStatus);

                Logger.WriteDebugMessage("Expired Status Award are displaying on Frontend");

                //Log test data into Log file
                Logger.LogTestData(TestPlanId, TestCaseId, "Award Status", awardstatus);
                Logger.LogTestData(TestPlanId, TestCaseId, "Award Display Status", displayStatus);
                Logger.LogTestData(TestPlanId, TestCaseId, "User Email", data.MemberEmail);
                Logger.LogTestData(TestPlanId, TestCaseId, "Voucher Number", data.VoucherNumber, true);

            }
        }
        public static void TC_116402()
        {
            if (TestCaseId == Constants.TC_116402)
            {
                string awardstatus, displayStatus;
                Users data = new Users();

                //1.Navigate to Admin Login page
                Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
                Logger.WriteDebugMessage("User landed on Admin Login Page");
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("User logged in succesfully");
                //2.Identify the email id having Status Redeemed
                awardstatus = TestData.ExcelData.TestDataReader.ReadData(1, "AwardStatus").Trim();
                displayStatus = TestData.ExcelData.TestDataReader.ReadData(1, "DisplayStatus").Trim();
                Queries.GetEmailWithAward(data, awardstatus);

                //3.Enter Email in Member Search and Click on View button
                Admin.EnterEmail(data.MemberEmail);
                Admin.EnterMemberNumber(data.MemberShipId);
                Logger.WriteDebugMessage("Email with Award status as Redeemed is Entered");
                Admin.Click_Button_MemberSearch();
                //Helper.ElementWait(PageObject_Admin.Admin_Button_ViewMember(ProjectName), 300);
                Logger.WriteDebugMessage("Member result displayed.");
                Admin.Click_Icon_View(ProjectName);
                Helper.ElementWait(PageObject_Admin.Tab_MemberAwards(), 300);
                Logger.WriteDebugMessage("Landed on Member Information Page");

                //Click on Member Award Page
                Helper.ScrollDown();
                Logger.WriteDebugMessage("Member Award tab is displaying with Awards");

                // Search the Award id
                Admin.Click_Tab_MemberAwards();
                Admin.MemberAwards_Text_Filter(data.VoucherNumber);
                AddDelay(10000);
                ElementWait(PageObject_Admin.Admin_MemberAward_PreviousButton(), 360);
                VerifyTextOnPageAndHighLight(data.VoucherNumber);
                VerifyTextOnPageAndHighLight(displayStatus);
                Logger.WriteDebugMessage("Award Identified on Admin");

                // Navigate to Front end
                Admin.Click_MemberInformation_Value_MemberPortal();
                AddDelay(20000);
                Logger.WriteDebugMessage("Navigated to Portal");

                //Control to new Window and maximize the page 
                ControlToNewWindow();
                Driver.Manage().Window.Maximize();
                Helper.PageDown();


                //Click on My Award Page
                Navigation.Click_Link_MyAward();
                Helper.ElementWait(PageObject_Navigation.MyAwards_Text_Filter(), 300);
                Logger.WriteDebugMessage("Landed on My Award Page");

                // Search for Identified Award
                Navigation.MyAwards_Text_Filter(data.VoucherNumber);
                Logger.WriteDebugMessage("Award filtered on the page");
                VerifyTextOnPageAndHighLight("No data available");
                Logger.WriteDebugMessage("Issues Status Award are not displaying on Frontend");

                //Log test data into Log file
                Logger.LogTestData(TestPlanId, TestCaseId, "Award Status", awardstatus);
                Logger.LogTestData(TestPlanId, TestCaseId, "Award Display Status", displayStatus);
                Logger.LogTestData(TestPlanId, TestCaseId, "User Email", data.MemberEmail);
                Logger.LogTestData(TestPlanId, TestCaseId, "Voucher Number", data.VoucherNumber, true);

            }
        }
        public static void TC_116404()
        {
            if (TestCaseId == Constants.TC_116404)
            {
                string awardstatus, displayStatus;
                Users data = new Users();

                //1.Navigate to Admin Login page
                Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
                Logger.WriteDebugMessage("User landed on Admin Login Page");
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("User logged in succesfully");
                //2.Identify the email id having Status Redeemed
                awardstatus = TestData.ExcelData.TestDataReader.ReadData(1, "AwardStatus").Trim();
                displayStatus = TestData.ExcelData.TestDataReader.ReadData(1, "DisplayStatus").Trim();
                Queries.GetEmailWithAward(data, awardstatus);

                //3.Enter Email in Member Search and Click on View button
                Admin.EnterEmail(data.MemberEmail);
                Admin.EnterMemberNumber(data.MemberShipId);
                Logger.WriteDebugMessage("Email with Award status as Redeemed is Entered");
                Admin.Click_Button_MemberSearch();
                Helper.ElementWait(PageObject_Admin.Admin_Button_ViewMember(ProjectName), 300);
                Logger.WriteDebugMessage("Member result displayed.");
                Admin.Click_Icon_View(ProjectName);
                Helper.ElementWait(PageObject_Admin.Tab_MemberAwards(), 300);
                Logger.WriteDebugMessage("Landed on Member Information Page");

                //Click on Member Award Page
                Helper.ScrollDown();
                Logger.WriteDebugMessage("Member Award tab is displaying with Awards");

                // Search the Award id
                Admin.Click_Tab_MemberAwards();
                Admin.MemberAwards_Text_Filter(data.VoucherNumber);
                AddDelay(7000);
                ElementWait(PageObject_Admin.Admin_MemberAward_PreviousButton(), 360);
                VerifyTextOnPageAndHighLight(data.VoucherNumber);
                VerifyTextOnPageAndHighLight(displayStatus);
                Logger.WriteDebugMessage("Award Identified on Admin");

                // Navigate to Front end
                Admin.Click_MemberInformation_Value_MemberPortal();
                AddDelay(20000);
                Logger.WriteDebugMessage("Navigated to Portal");

                //Control to new Window and maximize the page 
                ControlToNewWindow();
                Driver.Manage().Window.Maximize();
                Helper.PageDown();


                //Click on My Award Page
                Navigation.Click_Link_MyAward();
                Helper.ElementWait(PageObject_Navigation.MyAwards_Text_Filter(), 300);
                Logger.WriteDebugMessage("Landed on My Award Page");

                // Search for Identified Award
                Navigation.MyAwards_Text_Filter(data.VoucherNumber);
                Logger.WriteDebugMessage("Award filtered on the page");
                VerifyTextOnPageAndHighLight(data.VoucherNumber);
                VerifyTextOnPageAndHighLight(displayStatus);
                Logger.WriteDebugMessage("Issues Status Award are not displaying on Frontend");

                //Log test data into Log file
                Logger.LogTestData(TestPlanId, TestCaseId, "Award Status", awardstatus);
                Logger.LogTestData(TestPlanId, TestCaseId, "Award Display Status", displayStatus);
                Logger.LogTestData(TestPlanId, TestCaseId, "User Email", data.MemberEmail);
                Logger.LogTestData(TestPlanId, TestCaseId, "Voucher Number", data.VoucherNumber, true);

            }
        }
        public static void TC_264758()
        {
            if (TestCaseId == Constants.TC_264758)
            {
                string adminmsg, frontendmsg;
                Users data = new Users();

                //1.Navigate to Admin Login page
                Driver.Navigate().GoToUrl(ProjectDetails.CommonAdminURL);
                Logger.WriteDebugMessage("User landed on Admin Login Page");
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("User logged in succesfully");
                //2.Identify the email id having Status Redeemed
                adminmsg = TestData.ExcelData.TestDataReader.ReadData(1, "AdminNoAward").Trim();
                frontendmsg = TestData.ExcelData.TestDataReader.ReadData(1, "FrontendNoAward").Trim();
                Queries.GetEmailWithNoAward(data);

                //3.Enter Email in Member Search and Click on View button
                Admin.EnterEmail(data.MemberEmail);
                Admin.EnterMemberNumber(data.MemberShipId);
                Logger.WriteDebugMessage("Email with Award status as Redeemed is Entered");
                Admin.Click_Button_MemberSearch();
                Helper.ElementWait(PageObject_Admin.Admin_Button_ViewMember(ProjectName), 300);
                Logger.WriteDebugMessage("Member result displayed.");
                Admin.Click_Icon_View(ProjectName);
                Helper.ElementWait(PageObject_Admin.Tab_MemberAwards(), 300);
                Logger.WriteDebugMessage("Landed on Member Information Page");

                //Click on Member Award Page
                Helper.ScrollDown();
                Logger.WriteDebugMessage("Member Award tab is displaying with Awards");

                // Search the Award id
                Admin.Click_Tab_MemberAwards();
                VerifyTextOnPageAndHighLight(adminmsg);
                Logger.WriteDebugMessage("Award are not displaying on Admin Page");

                // Navigate to Front end
                Admin.Click_MemberInformation_Value_MemberPortal();
                AddDelay(20000);
                Logger.WriteDebugMessage("Navigated to Portal");

                //Control to new Window and maximize the page 
                ControlToNewWindow();
                Driver.Manage().Window.Maximize();
                Helper.PageDown();
                Logger.WriteDebugMessage("Succesfully login and Landed on Overview Page");

                //Click on My Award Page
                Navigation.Click_Link_MyAward();
                AddDelay(20000);
                if (Helper.IsElementDisplayed(PageObject_Navigation.MyAwards_Text_Filter()))
                    Assert.Fail("Awards are getting displayed");
                else
                {
                    Helper.DynamicScroll(Helper.Driver, PageObject_Admin.Tab_Redemptions());
                    Logger.WriteDebugMessage("Landed on My Award Page and Awards are not getting displayed");
                }

                //Log test data into Log file
                Logger.LogTestData(TestPlanId, TestCaseId, "Admin Award Message", adminmsg);
                Logger.LogTestData(TestPlanId, TestCaseId, "FrontEnd Award Message", frontendmsg);
                Logger.LogTestData(TestPlanId, TestCaseId, "User Email", data.MemberEmail, true);


            }
        }
        public static void TC_130237()
        {
            if (TestCaseId == Constants.TC_130237)
            {
                //Pre-requisite
                string awardStatus;
                Users data = new Users();

                //Retrive data from test data file
                awardStatus = TestData.ExcelData.TestDataReader.ReadData(1, "AwardStatus").Trim();
                Queries.GetMemberwithNonEgiftAward(data, awardStatus);
                
                //Login to frontend with valid Credentials
                Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
                Logger.WriteDebugMessage("Landed on Loyalty Frontend ");
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                ElementWait(PageObject_Navigation.Link_MyAward(), 120);
                Logger.WriteDebugMessage("Logged in succesfully with Valid Credentials");

                //Navigate to My Award and Verify the Award Page
                Navigation.Click_Link_MyAward();
                Navigation.MyAwards_Text_Filter(data.VoucherNumber);
                Logger.WriteDebugMessage("Award filtered on the page");
                Helper.ClickTextOnPage(data.AwardName);
                VerifyTextOnPageAndHighLight("Issued");
                VerifyTextOnPageAndHighLight("Expiration");
                VerifyTextOnPageAndHighLight("Status");
                VerifyTextOnPageAndHighLight("Voucher");
                VerifyTextOnPageAndHighLight(data.VoucherNumber);
                Logger.WriteDebugMessage("Award got displayed on the page");

            }
        }
       
    }
}
