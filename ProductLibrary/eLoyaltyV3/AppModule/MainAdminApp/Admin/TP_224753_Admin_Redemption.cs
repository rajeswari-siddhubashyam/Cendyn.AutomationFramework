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
        #region TP_224753 - Admin - Redemption 
                
        private static void TC_146564()
        {
            if (TestCaseId == Constants.TC_146564)
            {
                // Pre-requisites
                string validationMessage;
                Users data = new Users();
                /// Queries.GetMemberEmailWithSufficientBalance(data,"100");
                Queries.GetMemberEmailWithBalanceToMatchAwardBalance(data, "=");

                //Retrive data from Test Data 
                validationMessage = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage");

                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Navigation.Click_Link_Redeem();
                Logger.WriteDebugMessage("Navigated to Redeem tab");

                //Capture Member Total points, Redemption product name & points

                string awardName = PageObject_Redeem.Get_RedeemProductName(data.ProductName).GetAttribute("innerHTML");
                Helper.ScrollToElement(PageObject_Redeem.Get_RedeemProductName(data.ProductName));
                string productPoints = PageObject_Redeem.Get_RedeemProductPoints(data.ProductName).GetAttribute("innerHTML");
                Helper.ScrollToElement(PageObject_Redeem.Get_RedeemProductPoints(data.ProductName));
                Logger.WriteDebugMessage($"Award name{awardName} and points {productPoints} are captured");
                string points = PageObject_Redeem.Get_TotalPoints().GetAttribute("innerHTML");
                Helper.ScrollToElement(PageObject_Redeem.Get_TotalPoints());
                if (Convert.ToInt32(points) == (Convert.ToInt32(Convert.ToDecimal(data.PointsRemaining))))
                    Logger.WriteDebugMessage(points + "Points are captured");
                else
                    Assert.Fail("Points are not equal to ", data.PointsRemaining);

                //Click Redeem Button and click on cancel button
                Redeem.Click_Redeem_Button_ForAward(data.ProductName);
                Logger.WriteDebugMessage("Click Redeem in front end");
                Redeem.Click_Redeem_Cancel();
                Logger.WriteDebugMessage("Cancel button clicked");

                //Verify Points after Cancelation 

                string pointsAfterCancelRedeem = PageObject_Redeem.Get_TotalPoints().GetAttribute("innerHTML");
                VerifyTextOnPageAndHighLight(pointsAfterCancelRedeem);
                if (points.Equals(pointsAfterCancelRedeem))
                    Logger.WriteDebugMessage(points + "= Points are same after clicking on cancel button");
                else
                    Assert.Fail("Points are not same after clicking on cancel button");


                //Verfiy Cancel Award in Portal My Award tab

                Navigation.Click_Link_MyAward();
                Logger.WriteDebugMessage("Awards tab should clicked");
                ScrollDown();
                Queries.GetAwardNameAndPoint(data, data.ProductName);
                if (Helper.IsElementDisplayed(PageObject_Navigation.MyAwards_Text_Filter()))
                {
                    Navigation.MyAwards_Text_Filter(data.AwardName);
                    if (VerifyTextOnPageAndHighLightAndReturn(validationMessage))
                        Logger.WriteDebugMessage("Validation message should displays");
                    else
                        Logger.WriteDebugMessage("Similar Award already displays");
                }
                Logger.WriteDebugMessage("Canceled Status Award NOT displays on Frontend");

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Validation Message", validationMessage, true);

            }
        }
        private static void TC_149354()
        {
            if (TestCaseId == Constants.TC_149354)
            {
                // Pre-requisites
                string adminUrl;
                Users data = new Users();
                Queries.GetActiveMemberEmail(data);
                Queries.GetMemberAwardWithExipiredDate(data);

                //Retrive data from database
                adminUrl = TestData.ExcelData.TestDataReader.ReadData(1, "AdminUrl");

                //Login to Frontend
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);

                //Navigate to Admin
                OpenNewTab();
                ControlToNewWindow();
                Driver.Url = adminUrl;
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Navigate to Redeem Tab and note down redemption whose End date is Past
                Admin.Click_Menu_Redeem();
                Logger.WriteDebugMessage("Redeem tab should get clicked");
                Admin.Redeem_FilterSearch(data.AwardName);
                Logger.WriteDebugMessage("Award name filtered");
                string awardName = PageObject_Admin.Get_RedeemptionName().GetAttribute("innerHTML");

                //Navigate to portal and verify redemption name
                ControlToPreviousWindow();
                Navigation.Click_Link_Redeem();
                Logger.WriteDebugMessage("Navigated to Redeem tab");

                if (IsElementRemoved(awardName))
                    Assert.Fail(awardName+"= Award name displaying on the page");
                else
                    PageDown();
                    Logger.WriteDebugMessage(awardName+"= Award name not displaying on the page");
                
                

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Admin Url", adminUrl, true);

            }
        }
        private static void TC_146567()
        {
            if (TestCaseId == Constants.TC_146567)
            {
                // Pre-requisites
                string validationMessage;
                Users data = new Users();
                //Queries.GetMemberEmailWithZeroBalance(data, "0");
                Queries.GetMemberEmailWithBalanceToMatchAwardBalance(data, "<");

                //Retrive data from database
                validationMessage = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage");

                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Navigation.Click_Link_Redeem();
                Logger.WriteDebugMessage("Navigated to Redeem tab");

                //Capture Member Total points, Redemption product name & points

                string awardName = PageObject_Redeem.Get_RedeemProductName(data.ProductName).GetAttribute("innerHTML");
                Helper.ScrollToElement(PageObject_Redeem.Get_RedeemProductName(data.ProductName));
                string productPoints = PageObject_Redeem.Get_RedeemProductPoints(data.ProductName).GetAttribute("innerHTML");
                Helper.ScrollToElement(PageObject_Redeem.Get_RedeemProductPoints(data.ProductName));
                Logger.WriteDebugMessage($"Award name{awardName} and points {productPoints} are captured");
                string points = PageObject_Redeem.Get_TotalPoints().GetAttribute("innerHTML");
                Helper.ScrollToElement(PageObject_Redeem.Get_TotalPoints());
                if (Convert.ToInt32(points) == (Convert.ToInt32(Convert.ToDecimal(data.PointsRemaining))))
                    Logger.WriteDebugMessage(points + "Points are captured");
                else
                    Assert.Fail("Points are not equal to ", data.PointsRemaining);

                //Search for Redeem Product & Click Redeem Button and Ok

                Redeem.Click_Redeem_Button_ForAward(data.ProductName);
                Logger.WriteDebugMessage("Click Redeem in front end");
                Redeem.Click_Redeem_Ok();
                Logger.WriteDebugMessage("Click Ok in Pop up");

                //Validating error message
                VerifyTextOnPageAndHighLight(validationMessage);
                Logger.WriteDebugMessage("Validate error message");

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Validation Message", validationMessage, true);

            }
        }
        private static void TC_146568()
        {
            if (TestCaseId == Constants.TC_146568)
            {
                // Pre-requisites
                string adminUrl, date;
                Users data = new Users();
                //Queries.GetMemberEmailWithSufficientBalance(data, "100");
                Queries.GetMemberEmailWithBalanceToMatchAwardBalance(data, ">");

                //Retrive data from database
                adminUrl = TestData.ExcelData.TestDataReader.ReadData(1, "AdminUrl");

                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Navigation.Click_Link_Redeem();
                Logger.WriteDebugMessage("Navigated to Redeem tab");

                //Capture Member Total points, Redemption product name & points

                string awardName = PageObject_Redeem.Get_RedeemProductName(data.ProductName).GetAttribute("innerHTML");
                Helper.ScrollToElement(PageObject_Redeem.Get_RedeemProductName(data.ProductName));
                string productPoints = PageObject_Redeem.Get_RedeemProductPoints(data.ProductName).GetAttribute("innerHTML");
                Helper.ScrollToElement(PageObject_Redeem.Get_RedeemProductPoints(data.ProductName));
                Logger.WriteDebugMessage($"Award name{awardName} and points {productPoints} are captured");
                string points = PageObject_Redeem.Get_TotalPoints().GetAttribute("innerHTML");
                Helper.ScrollToElement(PageObject_Redeem.Get_TotalPoints());
                if (Convert.ToInt32(points) == (Convert.ToInt32(Convert.ToDecimal(data.PointsRemaining))))
                    Logger.WriteDebugMessage(points + "Points are captured");
                else
                    Assert.Fail("Points are not equal to ", data.PointsRemaining);

                //Search for Redeem Product & Click Redeem Button and Ok

                Redeem.Click_Redeem_Button_ForAward(data.ProductName);
                Logger.WriteDebugMessage("Click Redeem in front end");
                Redeem.Click_Redeem_Ok();
                Logger.WriteDebugMessage("Click Ok in Pop up");
                Redeem.Click_RequestSubmitted_OkButton();
                Logger.WriteDebugMessage("Redeem button clicked");
                string points_AfterRedemption = PageObject_Redeem.Get_TotalPoints().GetAttribute("innerHTML");
                if (points.Equals(points_AfterRedemption))
                    Assert.Fail("Points are not deducted");
                else
                {
                    VerifyTextOnPageAndHighLight(points_AfterRedemption);
                    Logger.WriteDebugMessage("Points deducted");
                }

                // Again Click on Redeem button for same award
                string points2 = PageObject_Redeem.Get_TotalPoints().GetAttribute("innerHTML");
                VerifyTextOnPageAndHighLight(points2);
                Redeem.Click_Redeem_Button_ForAward(data.ProductName);
                Logger.WriteDebugMessage("Click Redeem in front end");
                Redeem.Click_Redeem_Ok();
                Logger.WriteDebugMessage("Click Ok in Pop up");
                Redeem.Click_RequestSubmitted_OkButton();
                Logger.WriteDebugMessage("Redeem button clicked");
                string points_AfterRedemption2 = PageObject_Redeem.Get_TotalPoints().GetAttribute("innerHTML");
                if (points.Equals(points_AfterRedemption2))
                    Assert.Fail("Points are not deducted");
                else
                {
                    VerifyTextOnPageAndHighLight(points_AfterRedemption);
                    Logger.WriteDebugMessage("Points deducted");
                }

                //Verfiy Redeemed Award in Portal My Award tab

                Navigation.Click_Link_MyAward();
                Logger.WriteDebugMessage("Awards tab should clicked");
                ScrollDown();
                Queries.GetAwardNameAndPoint(data, data.ProductName);
                Navigation.MyAwards_Text_Filter(data.AwardName);
                VerifyTextOnPageAndHighLight(data.AwardName);
                Logger.WriteDebugMessage("Awards displays with Issued status");


            }
        }
        private static void TC_146563()
        {
            if (TestCaseId == Constants.TC_146563)
            {
                // Pre-requisites
                string adminUrl;
                Users data = new Users();
                // Queries.GetMemberEmailWithSufficientBalance(data, "100");
                Queries.GetMemberEmailWithBalanceToMatchAwardBalance(data, ">");

                //Retrive data from database
                adminUrl = TestData.ExcelData.TestDataReader.ReadData(1, "AdminUrl");

                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Navigation.Click_Link_Redeem();
                Logger.WriteDebugMessage("Navigated to Redeem tab");
                //Capture Member Total points, Redemption product name & points

                string awardName = PageObject_Redeem.Get_RedeemProductName(data.ProductName).GetAttribute("innerHTML");
                Helper.ScrollToElement(PageObject_Redeem.Get_RedeemProductName(data.ProductName));
                string productPoints = PageObject_Redeem.Get_RedeemProductPoints(data.ProductName).GetAttribute("innerHTML");
                Helper.ScrollToElement(PageObject_Redeem.Get_RedeemProductPoints(data.ProductName));
                Logger.WriteDebugMessage($"Award name{awardName} and points {productPoints} are captured");
                string points = PageObject_Redeem.Get_TotalPoints().GetAttribute("innerHTML");
                Helper.ScrollToElement(PageObject_Redeem.Get_TotalPoints());
                if (Convert.ToInt32(points) == (Convert.ToInt32(Convert.ToDecimal(data.PointsRemaining))))
                    Logger.WriteDebugMessage(points + "Points are captured");
                else
                    Assert.Fail("Points are not equal to ", data.PointsRemaining);

                //Search for Redeem Product & Click Redeem Button and Ok

                Redeem.Click_Redeem_Button_ForAward(data.ProductName);
                Logger.WriteDebugMessage("Click Redeem in front end");
                Redeem.Click_Redeem_Ok();
                Logger.WriteDebugMessage("Click Ok in Pop up");
                Redeem.Click_RequestSubmitted_OkButton();
                Logger.WriteDebugMessage("Redeem button clicked");
                string points_AfterRedemption = PageObject_Redeem.Get_TotalPoints().GetAttribute("innerHTML");
                if (points.Equals(points_AfterRedemption))
                    Assert.Fail("Points are not deducted");
                else
                {
                    VerifyTextOnPageAndHighLight(points_AfterRedemption);
                    Logger.WriteDebugMessage("Points deducted");
                }

                //Navigate to Admin and search for Redeemed award name
                OpenNewTab();
                ControlToNewWindow();
                Driver.Url = adminUrl;
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                //Admin.Click_Menu_Redeem();
                //Admin.Redeem_FilterSearch(awardName);
                //string admin_AwardLink = PageObject_Admin.Get_AwardLinkName().GetAttribute("innerHTML");

                //Navigate to Admin Home
                Admin.Click_Menu_Home();

                //Enter the captured email exactly on the email search .
                Admin.EnterEmail(data.MemberEmail);
                Logger.WriteDebugMessage("User able to enter email address.");

                //Click on search
                Admin.Click_Button_MemberSearch();
                VerifyTextOnPage(data.MemberEmail);
                Logger.WriteDebugMessage("Member found.");
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Navigated to Member Information tab.");
                VerifyTextOnPageAndHighLight(points_AfterRedemption);

                //Get Award Name of Redeemed Product from Database
                Queries.GetAwardNameAndPoint(data, data.ProductName);

                //Validate record in My Awards
                Helper.PageDown();
                VerifyTextOnPageAndHighLight(data.AwardName);
                VerifyTextOnPageAndHighLight("Sent via Email");
                Logger.WriteDebugMessage("My Awards details.");

                //Validate record in Points History
                Admin.Click_Tab_PointsHistory();
                VerifyTextOnPageAndHighLight(data.AwardName);
                Logger.WriteDebugMessage("Points History details.");

                //Navigate to catch all and verify email
                Email.LogIntoCatchAll();
                Email.CatchAll_SearchEmailAndOpenLatestMessage(data.MemberEmail);
                VerifyTextOnPageAndHighLight("Points Award Email");
                Logger.WriteDebugMessage("Email Subject verified");

                // Navigate to front-end
                ControlToPreviousWindow();
                Navigation.Click_Link_MyAward();
                Logger.WriteDebugMessage("Awards tab should clicked");
                Navigation.MyAwards_Text_Filter(data.AwardName);
                PageDown();
                VerifyTextOnPageAndHighLight(data.AwardName);
                Logger.WriteDebugMessage("Award displays with Issued status");


            }
        }
        private static void TC_149352()
        {
            if (TestCaseId == Constants.TC_149352)
            {
                // Pre-requisites
                string adminUrl;

                ////Get Product Name & Award Name
                Users data_1 = new Users();
                Queries.GetMemberEmailWithBalanceToMatchAwardBalance(data_1, ">");
                Queries.GetAwardNameAndPoint(data_1, data_1.ProductName);

                Users data = new Users();
                Queries.GetActiveMemberEmailMEMBER(data);

                Users data1 = new Users();
                Queries.GetActiveMemberEmailPREFERRED(data1);


                //Navigate to front end and login with Club Member
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("Logged in successfully with Club Member.");

                //Retrive data from database
                adminUrl = TestData.ExcelData.TestDataReader.ReadData(1, "AdminUrl");

                //Navigate to Admin 
                OpenNewTab();
                ControlToNewWindow();
                Driver.Url = adminUrl;
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Navigate to Loyalty Awards
                Admin.Click_Menu_LoyaltyAwards();
                Admin.Search_LoyaltyAwards(data_1.AwardName);
                Admin.Click_LoyaltyAwards_Icon_Edit();
                Logger.WriteDebugMessage("Loyalty award popup should get display");

                //Edit Award Name and Member Level
                Admin.EditMemberLevel("$100 Room - Voucher - Automation Test - One member level", "Club Member");
                Logger.WriteDebugMessage("Member Level Updated Correctly");
                Admin.Click_LoyaltyAwards_Button_Save();
                             
                //Navigate to portal and verify redemption name
                ControlToPreviousWindow();
                Navigation.Click_Link_Redeem();
                Logger.WriteDebugMessage("Navigated to Redeem tab");
                string admin_RedemptionName = PageObject_Redeem.Get_RedeemProductName(data_1.ProductName).GetAttribute("innerHTML");

                if (IsElementRemoved(admin_RedemptionName))
                {
                    VerifyTextOnPageAndHighLight(admin_RedemptionName);
                    Logger.WriteDebugMessage(admin_RedemptionName + "= Award name displaying on the page");
                }
                                       
                else
                    Assert.Fail(admin_RedemptionName + "= Award name is not displaying on the page");
                                
                //Front end logout
                Navigation.ClickSignOut(ProjectName);

                //Login with Preferred Club Member
                LoginCredentials(data1.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("Logged in successfully with Preferred Club Member.");
                Navigation.Click_Link_Redeem();
                Logger.WriteDebugMessage("Navigated to Redeem tab");

                if (IsElementRemoved(admin_RedemptionName))
                {
                    VerifyTextOnPageAndHighLight(admin_RedemptionName);
                    Assert.Fail(admin_RedemptionName + "= Award name is displaying on the page");
                    
                }

                else
                    Logger.WriteDebugMessage(admin_RedemptionName + "= Award name is not displaying on the page");

            }
        }
        private static void TC_149351()
        {
            if (TestCaseId == Constants.TC_149351)
            {
                // Pre-requisites
                string adminUrl;

                ////Get Product Name & Award Name
                Users data_1 = new Users();
                Queries.GetMemberEmailWithBalanceToMatchAwardBalance(data_1, ">");
                Queries.GetAwardNameAndPoint(data_1, data_1.ProductName);

                Users data = new Users();
                Queries.GetActiveMemberEmailMEMBER(data);

                Users data1 = new Users();
                Queries.GetActiveMemberEmailPREFERRED(data1);

                Users data2 = new Users();
                Queries.GetActiveMemberEmailPL(data2);

                //Navigate to front end and login with Club Member
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("Logged in successfully with Club Member.");

                //Retrive data from database
                adminUrl = TestData.ExcelData.TestDataReader.ReadData(1, "AdminUrl");

                //Navigate to Admin 
                OpenNewTab();
                ControlToNewWindow();
                Driver.Url = adminUrl;
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Navigate to Loyalty Awards
                Admin.Click_Menu_LoyaltyAwards();
                Admin.Search_LoyaltyAwards(data_1.AwardName);
                Admin.Click_LoyaltyAwards_Icon_Edit();
                Logger.WriteDebugMessage("Loyalty award popup should get display");

                //Edit Award Name and Member Level
                Admin.EditMultipleMemberLevel("$100 Room - Voucher - Automation Test - multiple member level", "Club Member" , "Preferred Club Member");
                Logger.WriteDebugMessage("Member Level Updated Correctly");
                Admin.Click_LoyaltyAwards_Button_Save();
                
                //Navigate to portal and verify redemption name

                ControlToPreviousWindow();
                Navigation.Click_Link_Redeem();
                Logger.WriteDebugMessage("Navigated to Redeem tab");
                string admin_RedemptionName = PageObject_Redeem.Get_RedeemProductName(data_1.ProductName).GetAttribute("innerHTML");                
                if (IsElementRemoved(admin_RedemptionName))
                {
                    VerifyTextOnPageAndHighLight(admin_RedemptionName);
                    Logger.WriteDebugMessage(admin_RedemptionName + "= Award name displaying on the page");
                }

                else
                    Assert.Fail(admin_RedemptionName + "= Award name is not displaying on the page");

                //Front end logout
                Navigation.ClickSignOut(ProjectName);

                //Navigate to front end and login with Preferred Club Member
                LoginCredentials(data1.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("Logged in successfully with Preferred Club Member.");
                Navigation.Click_Link_Redeem();
                Logger.WriteDebugMessage("Navigated to Redeem tab");

                if (IsElementRemoved(admin_RedemptionName))
                {
                    VerifyTextOnPageAndHighLight(admin_RedemptionName);
                    Logger.WriteDebugMessage(admin_RedemptionName + "= Award name displaying on the page");
                }

                else
                    Assert.Fail(admin_RedemptionName + "= Award name is not displaying on the page");

                //Front end logout
                Navigation.ClickSignOut(ProjectName);

                //Navigate to front end and login with Platinum Member
                LoginCredentials(data2.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("Logged in successfully with Platinum Member.");
                Navigation.Click_Link_Redeem();
                Logger.WriteDebugMessage("Navigated to Redeem tab");

                if (IsElementRemoved(admin_RedemptionName))
                {
                    VerifyTextOnPageAndHighLight(admin_RedemptionName);
                    Assert.Fail(admin_RedemptionName + "= Award name is displaying on the page");

                }

                else
                    Logger.WriteDebugMessage(admin_RedemptionName + "= Award name is not displaying on the page");


            }
        }
        private static void TC_149349()
        {
            if (TestCaseId == Constants.TC_149349)
            {
                // Pre-requisites
                string adminUrl;

                ////Get Product Name & Award Name
                Users data_1 = new Users();
                Queries.GetMemberEmailWithBalanceToMatchAwardBalance(data_1, ">");
                Queries.GetAwardNameAndPoint(data_1, data_1.ProductName);

                Users data = new Users();
                Queries.GetActiveMemberEmailMEMBER(data);

                Users data1 = new Users();
                Queries.GetActiveMemberEmailPREFERRED(data1);

                Users data2 = new Users();
                Queries.GetActiveMemberEmailPL(data2);

                Users data3 = new Users();
                Queries.GetActiveMemberEmailELITE(data3);

               

                //Navigate to front end and login with Club Member
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("Logged in successfully with Club Member.");

                //Retrive data from database
                adminUrl = TestData.ExcelData.TestDataReader.ReadData(1, "AdminUrl");

                //Navigate to Admin 
                OpenNewTab();
                ControlToNewWindow();
                Driver.Url = adminUrl;
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Navigate to Loyalty Awards
                Admin.Click_Menu_LoyaltyAwards();
                Admin.Search_LoyaltyAwards(data_1.AwardName);
                Admin.Click_LoyaltyAwards_Icon_Edit();
                Logger.WriteDebugMessage("Loyalty award popup should get display");

                //Edit Award Name and Member Level
                Admin.EditAllMemberLevel("$100 Room - Voucher - Automation Test - All member level");
                Logger.WriteDebugMessage("Member Level Updated Correctly");
                Admin.Click_LoyaltyAwards_Button_Save();
               
                //Navigate to portal and verify redemption name
                //Capture Member Total points, Redemption product name & points
                ControlToPreviousWindow();
                Navigation.Click_Link_Redeem();
                string admin_RedemptionName = PageObject_Redeem.Get_RedeemProductName(data_1.ProductName).GetAttribute("innerHTML");
                
                //Navigation.Click_Link_Redeem();
                Logger.WriteDebugMessage("Navigated to Redeem tab");

                if (IsElementRemoved(admin_RedemptionName))
                {
                    VerifyTextOnPageAndHighLight(admin_RedemptionName);
                    Logger.WriteDebugMessage(admin_RedemptionName + "= Award name displaying on the page");
                }

                else
                    Assert.Fail(admin_RedemptionName + "= Award name is not displaying on the page");

                //Front end logout
                Navigation.ClickSignOut(ProjectName);

                //Navigate to front end and login with Preferred Club Member
                LoginCredentials(data1.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("Logged in successfully with Preferred Club Member.");
                Navigation.Click_Link_Redeem();
                Logger.WriteDebugMessage("Navigated to Redeem tab");

                if (IsElementRemoved(admin_RedemptionName))
                {
                    VerifyTextOnPageAndHighLight(admin_RedemptionName);
                    Logger.WriteDebugMessage(admin_RedemptionName + "= Award name displaying on the page");
                }

                else
                    Assert.Fail(admin_RedemptionName + "= Award name is not displaying on the page");

                //Front end logout
                Navigation.ClickSignOut(ProjectName);

                //Navigate to front end and login with Platinum Member
                LoginCredentials(data2.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("Logged in successfully with Platinum Club Member.");
                Navigation.Click_Link_Redeem();
                Logger.WriteDebugMessage("Navigated to Redeem tab");

                if (IsElementRemoved(admin_RedemptionName))
                {
                    VerifyTextOnPageAndHighLight(admin_RedemptionName);
                    Logger.WriteDebugMessage(admin_RedemptionName + "= Award name displaying on the page");
                }

                else
                    Assert.Fail(admin_RedemptionName + "= Award name is not displaying on the page");

                //Front end logout
                Navigation.ClickSignOut(ProjectName);

                //Navigate to front end and login with Elite Member
                LoginCredentials(data3.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);
                Logger.WriteDebugMessage("Logged in successfully with Elite Member.");
                Navigation.Click_Link_Redeem();
                Logger.WriteDebugMessage("Navigated to Redeem tab");

                if (IsElementRemoved(admin_RedemptionName))
                {
                    VerifyTextOnPageAndHighLight(admin_RedemptionName);
                    Logger.WriteDebugMessage(admin_RedemptionName + "= Award name displaying on the page");
                }

                else
                    Assert.Fail(admin_RedemptionName + "= Award name is not displaying on the page");
                                
            }
        }
        private static void TC_149357()
        {
            if (TestCaseId == Constants.TC_149357)
            {
                // Pre-requisites
                string adminUrl, status;
                Users data = new Users();
                // Queries.GetMemberEmailWithSufficientBalance(data, "100");
                Queries.GetMemberEmailWithBalanceToMatchAwardBalance(data, ">");

                //Retrive data from database
                adminUrl = TestData.ExcelData.TestDataReader.ReadData(1, "AdminUrl");
                status = TestData.ExcelData.TestDataReader.ReadData(1, "Status");

                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);


                //Navigate to redeem
                Navigation.Click_Link_Redeem();

                //Capture Member Total points, Redemption product name & points

                string awardName = PageObject_Redeem.Get_RedeemProductName(data.ProductName).GetAttribute("innerHTML");
                Helper.ScrollToElement(PageObject_Redeem.Get_RedeemProductName(data.ProductName));
                string productPoints = PageObject_Redeem.Get_RedeemProductPoints(data.ProductName).GetAttribute("innerHTML");
                Helper.ScrollToElement(PageObject_Redeem.Get_RedeemProductPoints(data.ProductName));
                Logger.WriteDebugMessage($"Award name{awardName} and points {productPoints} are captured");
                string points = PageObject_Redeem.Get_TotalPoints().GetAttribute("innerHTML");
                Helper.ScrollToElement(PageObject_Redeem.Get_TotalPoints());
                if (Convert.ToInt32(points) == (Convert.ToInt32(Convert.ToDecimal(data.PointsRemaining))))
                    Logger.WriteDebugMessage(points + "Points are captured");
                else
                    Assert.Fail("Points are not equal to ", data.PointsRemaining);

                //Search for Redeem Product & Click Redeem Button and Ok

                Redeem.Click_Redeem_Button_ForAward(data.ProductName);
                Logger.WriteDebugMessage("Click Redeem in front end");
                Redeem.Click_Redeem_Ok();
                Logger.WriteDebugMessage("Click Ok in Pop up");
                Redeem.Click_RequestSubmitted_OkButton();
                Logger.WriteDebugMessage("Redeem button clicked");
                string points_AfterRedemption = PageObject_Redeem.Get_TotalPoints().GetAttribute("innerHTML");
                if (points.Equals(points_AfterRedemption))
                    Assert.Fail("Points are not deducted");
                else
                {
                    VerifyTextOnPageAndHighLight(points_AfterRedemption);
                    Logger.WriteDebugMessage("Points deducted");
                }
                //Verfiy Redeemed Award in Portal My Award tab

                Navigation.Click_Link_MyAward();
                Logger.WriteDebugMessage("Awards tab should clicked");
                ScrollDown();
                Queries.GetAwardNameAndPoint(data, data.ProductName);
                Navigation.MyAwards_Text_Filter(data.AwardName);
                VerifyTextOnPageAndHighLight(data.AwardName);
                Logger.WriteDebugMessage("Award displayed with Issued status");

                //Navigate to Admin, search for Redeemed award name and change the status to Canceled
                OpenNewTab();
                ControlToNewWindow();
                Driver.Url = adminUrl;
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Admin.EnterEmail(data.MemberEmail);
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Member get displayed");
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Navigated to member information tab");
                Admin.Click_Tab_MemberAwards();
                Logger.WriteDebugMessage("Member awards tab clicked");
                Admin.MemberAwards_Text_Filter("Sent via email");
                Helper.ElementWait(PageObject_Admin.Click_MemberAwardStatus(), 240);
                Admin.Click_MemberAwardStatus();
                Admin.Dropdown_AdminMemberStatus("Canceled");
                Logger.WriteDebugMessage("Status selected as Canceled");
                Admin.Click_ExpirationDateSubmit();
                Logger.WriteDebugMessage("Status changed as Canceled");
                               
                // Navigate to front-end
                ControlToPreviousWindow();
                Navigation.Click_Link_MyAward();
                Logger.WriteDebugMessage("Awards tab should clicked");
                Navigation.MyAwards_Text_Filter(data.AwardName);
                PageDown();
                VerifyTextOnPageAndHighLight(data.AwardName);
                Logger.WriteDebugMessage("Validation message should displayed");
                Navigation.Click_Link_Redeem();
                VerifyTextOnPageAndHighLight(points);
               
                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Admin Url", adminUrl);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Status", status, true);

            }
        }
        private static void TC_124627()
        {
            if (TestCaseId == Constants.TC_124627)
            {
                // Pre-requisites
                string validationMessage, adminUrl;
                Users data = new Users();
                validationMessage = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage");

                Queries.GetMemberEmailWithBalanceToMatchAwardBalance(data, "<");

                //Login to front end with Member identified above
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);

                //Navigate to redeem
                Navigation.Click_Link_Redeem();

                //Capture Member Total points, Redemption product name & points

                string awardName = PageObject_Redeem.Get_RedeemProductName(data.ProductName).GetAttribute("innerHTML");
                Helper.ScrollToElement(PageObject_Redeem.Get_RedeemProductName(data.ProductName));
                string productPoints = PageObject_Redeem.Get_RedeemProductPoints(data.ProductName).GetAttribute("innerHTML");
                Helper.ScrollToElement(PageObject_Redeem.Get_RedeemProductPoints(data.ProductName));
                Logger.WriteDebugMessage($"Award name{awardName} and points {productPoints} are captured");
                string points = PageObject_Redeem.Get_TotalPoints().GetAttribute("innerHTML");
                Helper.ScrollToElement(PageObject_Redeem.Get_TotalPoints());
                if (Convert.ToInt32(points) == (Convert.ToInt32(Convert.ToDecimal(data.PointsRemaining))))
                    Logger.WriteDebugMessage(points + "Points are captured");
                else
                    Assert.Fail("Points are not equal to ", data.PointsRemaining);

                //Search for Redeem Product & Click Redeem Button and Ok

                Redeem.Click_Redeem_Button_ForAward(data.ProductName);
                Logger.WriteDebugMessage("Click Redeem in front end");
                Redeem.Click_Redeem_Ok();
                Logger.WriteDebugMessage("Click Ok in Pop up");

                //Validating error message
                VerifyTextOnPageAndHighLight(validationMessage);
                Logger.WriteDebugMessage("Validate error message");

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Validation Message", validationMessage, true);

            }
        }
        private static void TC_124625()
        {
            if (TestCaseId == Constants.TC_124625)
            {
                // Pre-requisites
                //string validationMessage, adminUrl;
                Users data = new Users();
                Queries.GetMemberEmailWithBalanceToMatchAwardBalance(data, "=");

                //Login to front end with Member identified above
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);

                //Navigate to redeem
                Navigation.Click_Link_Redeem();

                //Capture Member Total points, Redemption product name & points

                string awardName = PageObject_Redeem.Get_RedeemProductName(data.ProductName).GetAttribute("innerHTML");
                Helper.ScrollToElement(PageObject_Redeem.Get_RedeemProductName(data.ProductName));
                string productPoints = PageObject_Redeem.Get_RedeemProductPoints(data.ProductName).GetAttribute("innerHTML");
                Helper.ScrollToElement(PageObject_Redeem.Get_RedeemProductPoints(data.ProductName));
                Logger.WriteDebugMessage($"Award name{awardName} and points {productPoints} are captured");
                string points = PageObject_Redeem.Get_TotalPoints().GetAttribute("innerHTML");
                Helper.ScrollToElement(PageObject_Redeem.Get_TotalPoints());
                if (Convert.ToInt32(points) == (Convert.ToInt32(Convert.ToDecimal(data.PointsRemaining))))
                    Logger.WriteDebugMessage(points + "Points are captured");
                else
                    Assert.Fail("Points are not equal to ",data.PointsRemaining);

                //Search for Redeem Product & Click Redeem Button and Ok

                Redeem.Click_Redeem_Button_ForAward(data.ProductName);
                Logger.WriteDebugMessage("Click Redeem in front end");
                Redeem.Click_Redeem_Ok();
                Logger.WriteDebugMessage("Click Ok in Pop up");
                Redeem.Click_RequestSubmitted_OkButton();
                Logger.WriteDebugMessage("Redeem button clicked");
                string points_AfterRedemption = PageObject_Redeem.Get_TotalPoints().GetAttribute("innerHTML");
                if (points.Equals(points_AfterRedemption))
                    Assert.Fail("Points are not deducted");
                else
                {
                    Helper.ScrollToElement(PageObject_Redeem.Get_TotalPoints());
                    if (points_AfterRedemption.Equals("0"))
                        Logger.WriteDebugMessage(points_AfterRedemption + "Points after redemption are captured");
                    else
                        Assert.Fail("Points are not equal to 0");
                }
                //Verfiy Redeemed Award in Portal My Award tab

                Navigation.Click_Link_MyAward();
                Logger.WriteDebugMessage("Awards tab should clicked");
                ScrollDown();
                Queries.GetAwardNameAndPoint(data, data.ProductName);
                Navigation.MyAwards_Text_Filter(data.AwardName);
                VerifyTextOnPageAndHighLight(data.AwardName);
                Logger.WriteDebugMessage("Award displayed with Issued status");
            }
        }
        private static void TC_124626()
        {
            if (TestCaseId == Constants.TC_124626)
            {
                // Pre-requisites
                //string adminUrl;
                Users data = new Users();

                Queries.GetMemberEmailWithBalanceToMatchAwardBalance(data, ">");

                //Login to front end with Member identified above
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);

                //Navigate to redeem
                Navigation.Click_Link_Redeem();

                //Capture Member Total points, Redemption product name & points

                string awardName = PageObject_Redeem.Get_RedeemProductName(data.ProductName).GetAttribute("innerHTML");
                Helper.ScrollToElement(PageObject_Redeem.Get_RedeemProductName(data.ProductName));
                string productPoints = PageObject_Redeem.Get_RedeemProductPoints(data.ProductName).GetAttribute("innerHTML");
                Helper.ScrollToElement(PageObject_Redeem.Get_RedeemProductPoints(data.ProductName));
                Logger.WriteDebugMessage($"Award name{awardName} and points {productPoints} are captured");
                string points = PageObject_Redeem.Get_TotalPoints().GetAttribute("innerHTML");
                Helper.ScrollToElement(PageObject_Redeem.Get_TotalPoints());
                if (Convert.ToInt32(points) == (Convert.ToInt32(Convert.ToDecimal(data.PointsRemaining))))
                    Logger.WriteDebugMessage(points + "Points are captured");
                else
                    Assert.Fail("Points are not equal to ", data.PointsRemaining);

                //Search for Redeem Product & Click Redeem Button and Ok

                Redeem.Click_Redeem_Button_ForAward(data.ProductName);
                Logger.WriteDebugMessage("Click Redeem in front end");
                Redeem.Click_Redeem_Ok();
                Logger.WriteDebugMessage("Click Ok in Pop up");
                Redeem.Click_RequestSubmitted_OkButton();
                Logger.WriteDebugMessage("Redeem button clicked");
                string points_AfterRedemption = PageObject_Redeem.Get_TotalPoints().GetAttribute("innerHTML");
                if (points.Equals(points_AfterRedemption))
                    Assert.Fail("Points are not deducted");
                else
                {
                    VerifyTextOnPageAndHighLight(points_AfterRedemption);
                    Logger.WriteDebugMessage("Points deducted");
                }

                //Verfiy Redeemed Award in Portal My Award tab

                Navigation.Click_Link_MyAward();
                Logger.WriteDebugMessage("Awards tab should clicked");
                ScrollDown();
                Queries.GetAwardNameAndPoint(data, data.ProductName);
                Navigation.MyAwards_Text_Filter(data.AwardName);
                VerifyTextOnPageAndHighLight(data.AwardName);
                Logger.WriteDebugMessage("Award displayed with Issued status");
            }
        }
        private static void TC_175101()
        {
            if (TestCaseId == Constants.TC_175101)
            {
                // Pre-requisites
                string validationText, adminUrl;
                Users data = new Users();
                // Queries.GetMemberEmailWithMoreThan100Balance(data, "100");
                Queries.GetMemberEmailWithBalanceToMatchAwardBalance(data, ">");

                //Retrieve data
                validationText = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationText");
                adminUrl = TestData.ExcelData.TestDataReader.ReadData(1, "AdminUrl");

                //Login to front end with Member identified above
                LoginCredentials(data.MemberEmail, ProjectDetails.CommonFrontendPassword, ProjectName);

                //Navigate to redeem
                Navigation.Click_Link_Redeem();

                //Capture Member Total points, Redemption product name & points

                string awardName = PageObject_Redeem.Get_RedeemProductName(data.ProductName).GetAttribute("innerHTML");
                Helper.ScrollToElement(PageObject_Redeem.Get_RedeemProductName(data.ProductName));
                string productPoints = PageObject_Redeem.Get_RedeemProductPoints(data.ProductName).GetAttribute("innerHTML");
                Helper.ScrollToElement(PageObject_Redeem.Get_RedeemProductPoints(data.ProductName));
                Logger.WriteDebugMessage($"Award name{awardName} and points {productPoints} are captured");
                string points = PageObject_Redeem.Get_TotalPoints().GetAttribute("innerHTML");
                Helper.ScrollToElement(PageObject_Redeem.Get_TotalPoints());
                if (Convert.ToInt32(points) == (Convert.ToInt32(Convert.ToDecimal(data.PointsRemaining))))
                    Logger.WriteDebugMessage(points + "Points are captured");
                else
                    Assert.Fail("Points are not equal to ", data.PointsRemaining);

                //Search for Redeem Product & Click Redeem Button and Ok

                Redeem.Click_Redeem_Button_ForAward(data.ProductName);
                Logger.WriteDebugMessage("Click Redeem in front end");
                Redeem.Click_Redeem_Ok();
                Logger.WriteDebugMessage("Click Ok in Pop up");
                Redeem.Click_RequestSubmitted_OkButton();
                Logger.WriteDebugMessage("Redeem button clicked");
                string points_AfterRedemption = PageObject_Redeem.Get_TotalPoints().GetAttribute("innerHTML");
                if (points.Equals(points_AfterRedemption))
                    Assert.Fail("Points are not deducted");
                else
                {
                    VerifyTextOnPageAndHighLight(points_AfterRedemption);
                    Logger.WriteDebugMessage("Points deducted");
                }
                //Verfiy Redeemed Award in Portal My Award tab

                Navigation.Click_Link_MyAward();
                Logger.WriteDebugMessage("Awards tab should clicked");
                ScrollDown();
                Queries.GetAwardNameAndPoint(data, data.ProductName);
                Navigation.MyAwards_Text_Filter(data.AwardName);
                VerifyTextOnPageAndHighLight(data.AwardName);
                Logger.WriteDebugMessage("Award displayed with Issued status");


                ////Navigate to Admin
                ControlToNewWindow();
                Driver.Url = adminUrl;
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                Admin.Click_Menu_Home();
                Admin.EnterEmail(data.MemberEmail);
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Member should get displayed");
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("User should get landed on Member Information page");
                string balance = Admin.BalancePoints();
                if (balance.Contains(points_AfterRedemption))
                    Logger.WriteDebugMessage("Points deducted in Admin");
                else
                    Assert.Fail("Points are not deducted in admin");

                //Users data1 = new Users();
                //Queries.GetMemberEmailWithMoreThan100Balance(data1, "100");
                Queries.GetMemberBalance(data, data.MemberEmail);
                if (points_AfterRedemption.Contains(data.Balance))
                    Logger.WriteDebugMessage("Points deducted in db");
                else
                    Assert.Fail("Points are not deducted in db");

                // Validate Redemption email
                OpenNewTab();
                ControlToNewWindow();
                Email.LogIntoCatchAll();
                Email.CatchAll_SearchEmailAndOpenLatestMessage(data.MemberEmail);
                VerifyTextOnPageAndHighLight(validationText);
                Logger.WriteDebugMessage("Redemption email should get received");

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Admin Url", adminUrl);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "Validation Text", validationText, true);
            }
        }



        #endregion TP_224753 - Admin - Redemption

    }
}
