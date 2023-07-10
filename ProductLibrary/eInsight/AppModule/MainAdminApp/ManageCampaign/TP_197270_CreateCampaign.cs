using System;
using eInsight.Utility;
using eInsight.AppModule.UI;
using Common;
using Constants = eInsight.Utility.Constants;
using InfoMessageLogger;
using BaseUtility.Utility;
using BaseUtility.Utility.Hotmail;
using TestData;
using SqlWarehouse;
using OpenQA.Selenium;
using NUnit.Framework;
using eInsight.AppModule.UI;
using eInsight.PageObject.UI;
using System.Text.RegularExpressions;
using DocumentFormat.OpenXml.Wordprocessing;

namespace eInsight.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        #region[TP_197270]
        public static void TC_508833()
        {
            Logger.WriteInfoMessage("Starting Test Case ID - 508833 - End to End flow for Primary Email marketing Campaign creation");
            CampaignDetails details = new CampaignDetails();

            projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", TestPlanId);

            CampaignDetails data = new CampaignDetails();
            SqlWarehouseQuery.ReturnCampaignStatus(Convert.ToInt32(projectID), data);
            CreateCampaign.PreSearchCampaign_New(CompanyName);
            Navigation.MenuNavigation("Create");
            if (Driver.Url.Contains("Create"))
            {
                string campaignName=CreateCampaign.CreateCampaign_CriteriaToTestingTab(Convert.ToInt32(projectID), "MarketingTestEtoEFlow_", "Marketing", "Independent Collection (IndependentCollection@contact-client.com)", "Cendynqatest (cendynautomation@cendyn.com)", "EndToEndCreateCampaignFlow"); 

                ElementWait(PageObject_CreateCampaign.Button_SendForApproval(), 60);
                IsElementVisible(PageObject_CreateCampaign.Button_SendForApproval());
                CreateCampaign.Click_Button_SendforApproval();
                CreateCampaign.CampaignApprove(Convert.ToInt32(projectID));
                IsElementVisible(PageObject_CreateCampaign.CreateCampaign_Button_Continue());
                CreateCampaign.CreateCampaign_Button_Continue();
                ElementWait(PageObject_CreateCampaign.CreateCampaign_Link_ScheduleTab(), 60);
                Logger.WriteDebugMessage("Landed on Schedule Page");
                CreateCampaign.SelectTime();
                ScrollUpUsingJavaScript(Driver, -500);
                CreateCampaign.CampaignScheduleandComplete("Schedule");
                AddDelay(5000);
                Driver.SwitchTo().Frame("ManageCampaign");                
                if (VerifyTextOnPage("MarketingTestEtoEFlow_"+campaignName))
                {
                    Logger.WriteDebugMessage("New Campaign Created Successfully : MarketingTestEtoEFlow_" + campaignName);
                }
                else
                {
                    Assert.Fail("New Campaign Not Created : MarketingTestEtoEFlow_" + campaignName);
                }                
                ElementClick(Driver.FindElement(By.XPath("(//span[contains(text(), 'Scheduled Active')])[1]")));
                ElementWait(PageObject_ManageCampaign.ManageCampaign_EditSchedule_InactivateSchedule(), 60);
                IsElementVisible(PageObject_ManageCampaign.ManageCampaign_EditSchedule_InactivateSchedule());
                OpenNewTab();
                ControlToNewWindow();
                Login.AutoAccount_logins("catchall@cendyn17.com", "Autom4tion12346$", 1, 0, LegacyTestData.CommonCatchallURL, "MarketingTestEtoEFlow_" + campaignName, 0);
                if (VerifyTextOnPage("MarketingTestEtoEFlow_" + campaignName))
                {
                    Logger.WriteDebugMessage("Send to Test Email received");
                }
                else
                {
                    Assert.Fail("Send to test email was not received.");
                }
            }
        }

        public static void TC_508834()
        {
            Logger.WriteInfoMessage("Starting Test Case ID - 508834 - End to End flow for Primary Email Transactional Campaign creation");
            CampaignDetails details = new CampaignDetails();

            projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", TestPlanId);

            CampaignDetails data = new CampaignDetails();
            SqlWarehouseQuery.ReturnCampaignStatus(Convert.ToInt32(projectID), data);
            CreateCampaign.PreSearchCampaign_New(CompanyName);
            Navigation.MenuNavigation("Create");
            if (Driver.Url.Contains("Create"))
            {
                string CampaignRanName = GetRandomAlphaNumericString(0,1);
                CreateCampaign.CreateCampaign_Criteria( "TransactionalEtoEFlow_"+ CampaignRanName);
                CreateCampaign.CreateCampaign_SelectPropertylyst("Capitol Hill Hotel");
                CreateCampaign.CreateCampaign_CampainSetting("New Reservation");
                ScrollDownUsingJavaScript(Driver, 500);
                CreateCampaign.CreateCampaign_DataSource("QA_Reg");
                ScrollUpUsingJavaScript(Driver, 500);
                ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", Driver.FindElement(By.XPath("//button[@class='btn btn-primary action-criteria-save']")));
                Logger.WriteInfoMessage("Clicked on 'Save' Button");
                CreateCampaign.CreateCampaign_ForecastTargetAudience();

                if (IsElementVisible(PageObject_CreateCampaign.CreateCampaign_ForecastTargetAudienceTotalCount()))
                {                       
                    ElementWait(PageObject_CreateCampaign.CreateCampaign_ForecastTargetAudienceTotalCount(), 120);
                    Logger.WriteDebugMessage("Forecast Target Audience Total Count is DisPlayed");

                }
                else
                {
                    Assert.Fail("Forecast Target Audience Not Total Count is DisPlayed");
                }
                CreateCampaign.CreateCampaign_CriteriaTabSaveandContinueButton();
                Driver.SwitchTo().Frame("TemplateBuilder");
                CreateCampaign.CreateCampaign_TemplateTabSelectandSaveandContinueButton(1);
                CreateCampaign.CreateCampaign_EditTemplate("Transactional", "Independent Collection (IndependentCollection@contact-client.com)", "Cendynqatest (cendynautomation@cendyn.com)", "EndToEndCreateCampaignFlow");
                CreateCampaign.CreateCampaign_TestingTabProceedButton();
                ElementWait(PageObject_CreateCampaign.Button_SendForApproval(), 60);
                IsElementVisible(PageObject_CreateCampaign.Button_SendForApproval());
                CreateCampaign.Click_Button_SendforApproval();
                CreateCampaign.CampaignApprove(Convert.ToInt32(projectID));
                IsElementVisible(PageObject_CreateCampaign.CreateCampaign_Button_Continue());
                CreateCampaign.CreateCampaign_Button_Continue();
                ElementWait(PageObject_CreateCampaign.CreateCampaign_Link_ScheduleTab(), 60);
                Logger.WriteDebugMessage("Landed on Schedule Page");
                CreateCampaign.SelectTime();
                ScrollUpUsingJavaScript(Driver, -500);
                CreateCampaign.CampaignScheduleandComplete("Schedule");
                Driver.SwitchTo().Frame("ManageCampaign");
                CreateCampaign.CreateCampaign_SelectDropdownValueInManageCampaingPage("Transactional - In Testing", 2);
                CreateCampaign.CreateCampaign_VerifyCreatedorNot("TransactionalEtoEFlow_" + CampaignRanName,1);
                OpenNewTab();
                ControlToNewWindow();
                Login.AutoAccount_logins("catchall@cendyn17.com", "Autom4tion12346$", 1, 0, LegacyTestData.CommonCatchallURL, "TransactionalEtoEFlow_" + CampaignRanName, 0);
                if (VerifyTextOnPage("TransactionalEtoEFlow_" + CampaignRanName))
                {
                    Logger.WriteDebugMessage("Send to Test Email received");
                }
                else
                {
                    Assert.Fail("Send to test email was not received.");
                }

            }
        }

        public static void TC_508836()
        {
            Logger.WriteInfoMessage("Starting Test Case ID - 508836 - Automate Sub Email Campaign Flow - End to End");
            CampaignDetails details = new CampaignDetails();

            projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", TestPlanId);

            CampaignDetails data = new CampaignDetails();
            SqlWarehouseQuery.ReturnCampaignStatus(Convert.ToInt32(projectID), data);
            CreateCampaign.PreSearchCampaign_New(CompanyName);
            Navigation.MenuNavigation("Create");
            if (Driver.Url.Contains("Create"))
            {
                string CampaignRanName = GetRandomAlphaNumericString(0,1);
                CreateCampaign.CreateCampaign_SubEmailCreate("SubEmailEtoEFlow_" + CampaignRanName);
                CreateCampaign.CreateCampaign_TemplateTabSelectandSaveandContinueButton(1);
                CreateCampaign.CreateCampaign_EditTemplate("Marketing", "Independent Collection (IndependentCollection@contact-client.com)", "Cendynqatest (cendynautomation@cendyn.com)", "EndToEndCreateCampaignFlow");
                CreateCampaign.CreateCampaign_TestingTabProceedButton();
                ElementWait(PageObject_CreateCampaign.Button_SendForApproval(), 60);
                IsElementVisible(PageObject_CreateCampaign.Button_SendForApproval());
                CreateCampaign.Click_Button_SendforApproval();
                CreateCampaign.CampaignApprove(Convert.ToInt32(projectID));
                IsElementVisible(PageObject_CreateCampaign.CreateCampaign_Button_Continue());
                CreateCampaign.CreateCampaign_Button_Continue();
                Driver.SwitchTo().Frame("ManageCampaign");
                CreateCampaign.CreateCampaign_SelectDropdownValueInManageCampaingPage("Email", 1);
                CreateCampaign.CreateCampaign_SelectDropdownValueInManageCampaingPage("Sub", 3);
                CreateCampaign.CreateCampaign_VerifyCreatedorNot("SubEmailEtoEFlow_" + CampaignRanName, 1);
                OpenNewTab();
                ControlToNewWindow();
                Login.AutoAccount_logins("catchall@cendyn17.com", "Autom4tion12346$", 1, 0, LegacyTestData.CommonCatchallURL, "SubEmailEtoEFlow_" + CampaignRanName, 0);
                if (VerifyTextOnPage("SubEmailEtoEFlow_" + CampaignRanName))
                {
                    Logger.WriteDebugMessage("Send to Test Email received");
                }
                else
                {
                    Assert.Fail("Send to test email was not received.");
                }

            }
        }
        public static void TC_128427()
        {
            projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", TestPlanId);

            Users SData = new Users();

            if (Driver.Url.Contains("home.mvc"))
            {
                Logger.WriteDebugMessage("Logged in to eInsight with UserName - " + LegacyTestData.CommonFrontendEmail + " and Password " + LegacyTestData.CommonFrontendPassword + ". Landed on eInsight Home Page.");
                //SqlWarehouseQuery.VerifyCampaignData(SData, CompanyName, "1", 0);
                SqlWarehouseQuery.GetPersonalizedTagValue(SData, CompanyName, 0, "", projectID, "");
                SqlWarehouseQuery.GetPersonalizedTagValue(SData, CompanyName, 1, "", projectID, SData.CustomerIDs);
                Navigation.MenuNavigation("ManageCampaign");
                Logger.WriteDebugMessage("Landed on Manage Campaign");
                AddDelay(8000);
                ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign);
                ManageCampaign.ManageCampaign_EllipseButton("Details");
                ManageCampaign.CampaignDetails_TabActions("Audience", projectID, "CustomerDetails");
                ManageCampaign.SearchCustomer("Email", SData.Email);
                ManageCampaign.CustomerDetailEllipse_PreviewQuickSend("QuickSend");

                //ElementClick(Driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Preview'])[2]/following::span[1]")));

                DateTime Date = DateTime.Parse(SData.ArrivalDate);
                string arrivalDate = Date.ToString("M/d/yyyy");
                Date = DateTime.Parse(SData.DepartureDate);
                string depatureDate = Date.ToString("M/d/yyyy");
                string resxPath = SData.ReservationNumber + " | " + arrivalDate + " - " + depatureDate;
                //ManageCampaign.CASL_QuickSendVerification(SData.Custom    erIDs, 0, "", SData.ReservationNumber, resxPath);
                ManageCampaign.Customer_Send_QuickSend(SData.CustomerIDs, SData.ReservationNumber, resxPath);
                OpenNewTab();
                ControlToNewWindow();
                Login.AutoAcc_logins(SData.Subject, 2, 0, LegacyTestData.CommonCatchallURL, 1);

                if (VerifyTextOnPage(SData.Subject) == true)
                {
                    Logger.WriteDebugMessage("Received Quick Send Email.");
                }
                else
                {
                    Assert.Fail("Quick Send Email was not received.");
                }
            }
        }
        public static void TC_197271()
        {
            projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", TestPlanId);

            Users SData = new Users();
            Logger.WriteDebugMessage("Logged in to eInsight with UserName - " + LegacyTestData.CommonFrontendEmail + " and Password " + LegacyTestData.CommonFrontendPassword + ". Landed on eInsight Home Page.");
            SqlWarehouseQuery.GetPersonalizedTagValue(SData, CompanyName, 0, "", projectID, "");
            SqlWarehouseQuery.GetPersonalizedTagValue(SData, CompanyName, 1, "", projectID, SData.CustomerIDs);
            Navigation.MenuNavigation("ManageCampaign");
            Logger.WriteDebugMessage("Landed on Manage Campaign Page");
            //ManageCampaign.SearchCampaign(SData.CustomerIDs, SData.Email, 1, Convert.ToInt32(projectID) , 1);
            ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign);
            ManageCampaign.ManageCampaign_EllipseButton("Details");
            ManageCampaign.CampaignDetails_TabActions("Audience", projectID, "CustomerDetails");
            ManageCampaign.SearchCustomer("Email", SData.Email);
            ManageCampaign.CustomerDetailEllipse_PreviewQuickSend("Preview");
            ManageCampaign.VerifyPersonalizeData(SData, 1, CompanyName, "", "", 40012875);
        }
        /* Verify DC returns proper data*/
        public static void TC_197272()
        {
            projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", TestPlanId);

            Users SData = new Users();
            Logger.WriteDebugMessage("Logged in to eInsight with UserName - " + LegacyTestData.CommonFrontendEmail + " and Password " + LegacyTestData.CommonFrontendPassword + ". Landed on eInsight Home Page.");
            SqlWarehouseQuery.GetPersonalizedTagValue(SData, CompanyName, 0, "", projectID, "");
            SqlWarehouseQuery.GetPersonalizedTagValue(SData, CompanyName, 1, "", projectID, SData.CustomerIDs);
            Navigation.MenuNavigation("ManageCampaign");
            Logger.WriteDebugMessage("Landed on Manage Campaign Page");
            //ManageCampaign.SearchCampaign(SData.CustomerIDs, SData.ReservationNumber, 2, 40012875, 1);
            ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign);
            ManageCampaign.ManageCampaign_EllipseButton("Details");
            ManageCampaign.CampaignDetails_TabActions("Audience", projectID, "CustomerDetails");
            ManageCampaign.SearchCustomer("Email", SData.Email);
            ManageCampaign.CustomerDetailEllipse_PreviewQuickSend("Preview");
            ManageCampaign.VerifyPersonalizeData(SData, 2, CompanyName, "", "", 0);
        }
        public static void TC_197274()
        {
            projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", TestPlanId);

            Users SData = new Users();
            Logger.WriteDebugMessage("Logged in to eInsight with UserName - " + LegacyTestData.CommonFrontendEmail + " and Password " + LegacyTestData.CommonFrontendPassword + ". Landed on eInsight Home Page.");
            SqlWarehouseQuery.GetPersonalizedTagValue(SData, CompanyName, 0, "", projectID, "");
            SqlWarehouseQuery.GetPersonalizedTagValue(SData, CompanyName, 1, "", projectID, SData.CustomerIDs);
            Navigation.MenuNavigation("ManageCampaign");
            Logger.WriteDebugMessage("Landed on Manage Campaign Page");
            CampaignDetails data = new CampaignDetails();
            SqlWarehouseQuery.ReturnCampaignStatus(Convert.ToInt32(projectID), data);
           // AddDelay(2000);
            ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign);
            string loader2 = "//div[@class='e-spinner-pane e-spin-show']";
            Helper.FindLoaderAndWaitTillHide(loader2);
            ManageCampaign.ManageCampaign_EllipseButton("Details");
            ManageCampaign.SendToTestEmail(SData.ParentProjectID, 0);
            SqlWarehouseQuery.GetCustomerDataForSendTest(SData, CompanyName);
            OpenNewTab();
            ControlToNewWindow();
            Login.AutoAccount_logins("catchall@cendyn17.com", "Autom4tion12346$", 1, 0, LegacyTestData.CommonCatchallURL, "testcatchall@cendyn17.com", 0);
            if (VerifyTextOnPage(SData.Subject))
            {
                Logger.WriteDebugMessage("Send to Test Email received");
            }
            else
            {
                Assert.Fail("Send to test email was not received.");
            }
            /*
            ManageCampaign.PreSearchCampaign(1, projectID, data.ParentCompanyName, data.CompanyName);
            ManageCampaign.SendToTestEmail(SData.ParentProjectID, 0);
            
            SqlWarehouseQuery.GetCustomerDataForSendTest(SData, CompanyName);
            OpenNewTab();
            ControlToNewWindow();
            Login.AutoAcc_login(SData.Subject, 2, 0, LegacyTestData.CommonCatchallURL);
            if (VerifyTextOnPage(SData.Subject))
            {
                Logger.WriteDebugMessage("Send to Test Email received");
            }
            else
            {
                Assert.Fail("Send to test email was not received.");
            }
            Hotmail.OutlookSignOut();
            */
        }
        public static void TC_197275()
        {
            Users SData = new Users();
            projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", TestPlanId);
            Logger.WriteDebugMessage("Logged in to eInsight with UserName - " + LegacyTestData.CommonFrontendEmail + " and Password " + LegacyTestData.CommonFrontendPassword + ". Landed on eInsight Home Page.");
            SqlWarehouseQuery.GetPersonalizedTagValue(SData, CompanyName, 0, "", projectID, "");
            SqlWarehouseQuery.GetPersonalizedTagValue(SData, CompanyName, 1, "", projectID, SData.CustomerIDs);
            //SqlWarehouseQuery.GetCustomerIDSendTest(SData, CompanyName);
            Navigation.MenuNavigation("ManageCampaign");
            Logger.WriteDebugMessage("Landed on Manage Campaign Page for Property: " + CompanyName);
            //ManageCampaign.SearchCampaign(SData.CustomerIDs, SData.ReservationNumber, 0, projectID, 1);
            ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign);
            ManageCampaign.ManageCampaign_EllipseButton("Details");
            ManageCampaign.CampaignDetails_TabActions("Audience", projectID, "CustomerDetails");
            ManageCampaign.SearchCustomer("Email", SData.Email);
            if (VerifyTextOnPage(SData.Email))
            {
                Logger.WriteDebugMessage("Search for Customer Email " + SData.Email + " which is  displayed in the Customer Detail as per criteria added");
            }
        }
        public static void TC_197276()
        {
            projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", TestPlanId);

            Users SData = new Users();
            Logger.WriteDebugMessage("Logged in to eInsight with UserName - " + LegacyTestData.CommonFrontendEmail + " and Password " + LegacyTestData.CommonFrontendPassword + ". Landed on eInsight Home Page.");
            //SqlWarehouseQuery.VerifyCampaignData(SData, CompanyName, "1", 0);
            SqlWarehouseQuery.GetPersonalizedTagValue(SData, CompanyName, 0, "", projectID, "");
            SqlWarehouseQuery.GetPersonalizedTagValue(SData, CompanyName, 1, "", projectID, SData.CustomerIDs);
            Navigation.MenuNavigation("ManageCampaign");
            Logger.WriteDebugMessage("Landed on Manage Campaign Page");
            ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign);
            ManageCampaign.ManageCampaign_EllipseButton("Details");
            ManageCampaign.CampaignDetails_TabActions("Audience", projectID, "CustomerDetails");
            ManageCampaign.SearchCustomer("Email", SData.Email);
            ManageCampaign.CustomerDetailEllipse_PreviewQuickSend("QuickSend");

            //ElementClick(Driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Preview'])[2]/following::span[1]")));

            DateTime Date = DateTime.Parse(SData.ArrivalDate);
            string arrivalDate = Date.ToString("M/d/yyyy");
            Date = DateTime.Parse(SData.DepartureDate);
            string depatureDate = Date.ToString("M/d/yyyy");
            string resxPath = SData.ReservationNumber + " | " + arrivalDate + " - " + depatureDate;
            //ManageCampaign.CASL_QuickSendVerification(SData.CustomerIDs, 0, "", SData.ReservationNumber, resxPath);
            ManageCampaign.Customer_Send_QuickSend(SData.CustomerIDs, SData.ReservationNumber, resxPath);
            OpenNewTab();
            Login.AutoAccount_logins("catchall@cendyn17.com", "Autom4tion12346$", 1, 0, LegacyTestData.CommonCatchallURL, "testcatchall@cendyn17.com", 0);
            if (VerifyTextOnPage(SData.Subject) == true)
            {
                Logger.WriteDebugMessage("Received Quick Send Email.");
            }
            else
            {
                Assert.Fail("Quick Send Email was not received.");
            }
        }
        public static void TC_198274()
        {
            Users SData = new Users();
            projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", TestPlanId);
            Logger.WriteDebugMessage("Logged in to eInsight with UserName - " + LegacyTestData.CommonFrontendEmail + " and Password " + LegacyTestData.CommonFrontendPassword + ". Landed on eInsight Home Page.");
            //SqlWarehouseQuery.VerifyCampaignData(SData, CompanyName, "1", 0);
            SqlWarehouseQuery.GetPersonalizedTagValue(SData, CompanyName, 0, "", projectID.ToString(), "");
            SqlWarehouseQuery.GetPersonalizedTagValue(SData, CompanyName, 1, "", projectID.ToString(), SData.CustomerIDs);

            Navigation.MenuNavigation("ManageCampaign");
            
            AddDelay(20000);
            ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID.ToString(), iFrameManageCampaign);

            ManageCampaign.ManageCampaign_EllipseButton("Details");

            ManageCampaign.CampaignDetails_TabActions("Preview", projectID.ToString());

            if (VerifyTextOnPage("#CUSTOMERID#") && VerifyTextOnPage("#FIRSTNAME#") && VerifyTextOnPage("#LASTNAME#") && VerifyTextOnPage("#EMAIL#") && VerifyTextOnPage("#STAYARRIVALDATE#") && VerifyTextOnPage("#STAYID#"))
            {
                Logger.WriteDebugMessage("All personalization tags are displays as per expected.");
            }
            else
            {
                Assert.Fail("One of the personalization tags were not displayed.");
            }
        }
        public static void TC_198275()
        {
            Users SData = new Users();
            projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", TestPlanId);
            Logger.WriteDebugMessage("Logged in to eInsight with UserName - " + LegacyTestData.CommonFrontendEmail + " and Password " + LegacyTestData.CommonFrontendPassword + ". Landed on eInsight Home Page.");
            //SqlWarehouseQuery.GetCustomerIDSendTest(SData, CompanyName);
            SqlWarehouseQuery.GetPersonalizedTagValue(SData, CompanyName, 0, "", projectID, "");
            SqlWarehouseQuery.GetPersonalizedTagValue(SData, CompanyName, 1, "", projectID, SData.CustomerIDs);
            Navigation.MenuNavigation("ManageCampaign");
            Logger.WriteDebugMessage("Landed on Manage Campaign Page");
            CampaignDetails data = new CampaignDetails();
            SqlWarehouseQuery.ReturnCampaignStatus(Convert.ToInt32(projectID), data);
            if (data.OldStatus != "Draft")
            {
                SqlWarehouseQuery.UpdateProjectStatus(Convert.ToInt32(projectID));
            }
            //ManageCampaign.PreSearchCampaign(1, projectID, data.ParentCompanyName, data.CompanyName);
            ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign);
            ManageCampaign.ManageCampaign_EllipseButton("Edit");
            AddDelay(1000);
            //ManageCampaign.ManageCampaign_EditCampaign(Convert.ToInt32(projectID));
            ElementWait(PageObject_CreateCampaign.CreateCampaign_Button_Save(), 60);
            if (IsElementVisible(PageObject_CreateCampaign.CreateCampaign_Button_ChangeTemplate()))
            {
                AddDelay(1000);
                Logger.WriteDebugMessage("Landed on Edit Template Tab.");
                CreateCampaign.CreateCampaign_Button_SaveandContinue();
                ElementWait(PageObject_ManageCampaign.Button_Campaign_BasicValidationReport(), 120);
                Logger.WriteDebugMessage("Landed on Testing Tab.");
                CreateCampaign.Click_Button_TestingSendtoTest();
            }
            else
            {
                Assert.Fail("Did not land on Testing Page.");
            }
            AddDelay(2500);
            OpenNewTab();
            ControlToNewWindow();
            Login.AutoAccount_logins("catchall@cendyn17.com", "Autom4tion12346$", 1, 0, LegacyTestData.CommonCatchallURL, "testcatchall@cendyn17.com", 0);

            if (VerifyTextOnPage(SData.Subject) == true)
            {
                Logger.WriteDebugMessage("Received Send to Test Email.");
            }
            else
            {
                Assert.Fail("Quick Send to Test Email was not received.");
            }

        }
        public static void TC_198276()
        {
            Users SData = new Users();
            projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", TestPlanId);

            Logger.WriteDebugMessage("Logged in to eInsight with UserName - " + LegacyTestData.CommonFrontendEmail + " and Password " + LegacyTestData.CommonFrontendPassword + ". Landed on eInsight Home Page.");
            //SqlWarehouseQuery.GetCustomerIDSendTest(SData, CompanyName);
            SqlWarehouseQuery.GetPersonalizedTagValue(SData, CompanyName, 0, "", projectID, "");
            SqlWarehouseQuery.GetPersonalizedTagValue(SData, CompanyName, 1, "", projectID, SData.CustomerIDs);
            Navigation.MenuNavigation("ManageCampaign");
            Logger.WriteDebugMessage("Landed on Manage Campaign Page");
            CampaignDetails data = new CampaignDetails();
            SqlWarehouseQuery.ReturnCampaignStatus(Convert.ToInt32(projectID), data);
            ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign);
            ManageCampaign.ManageCampaign_EllipseButton("Edit");
            AddDelay(10000);
            //ManageCampaign.ManageCampaign_EditCampaign(projectID);
            if (IsElementVisible(PageObject_CreateCampaign.CreateCampaign_Button_ChangeTemplate()))
            {
                Logger.WriteDebugMessage("Landed on Edit Template Tab.");
                CreateCampaign.CreateCampaign_Button_SaveandContinue();
                ElementWait(PageObject_ManageCampaign.Button_Campaign_BasicValidationReport(), 120);
                Logger.WriteDebugMessage("Landed on Testing Tab.");
                CreateCampaign.Click_Button_TestingSendtoTest();
                ElementWait(Driver.FindElement(By.XPath("//*[@id='SendToTestEmails" + projectID + "']")), 60);
                Logger.WriteDebugMessage("Landed on Approval Tab.");
                CreateCampaign.Click_Button_SendforApproval();
                CreateCampaign.CampaignDisapprove(Convert.ToInt32(projectID));
            }
            else
            {
                Assert.Fail("Did not land on edit template page.");
            }
        }
        public static void TC_198277()
        {
            Users SData = new Users();
            projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", TestPlanId);
            Logger.WriteDebugMessage("Logged in to eInsight with UserName - " + LegacyTestData.CommonFrontendEmail + " and Password " + LegacyTestData.CommonFrontendPassword + ". Landed on eInsight Home Page.");
            //SqlWarehouseQuery.GetCustomerIDSendTest(SData, CompanyName);
            SqlWarehouseQuery.GetPersonalizedTagValue(SData, CompanyName, 0, "", projectID, "");
            SqlWarehouseQuery.GetPersonalizedTagValue(SData, CompanyName, 1, "", projectID, SData.CustomerIDs);
            Navigation.MenuNavigation("ManageCampaign");
            Logger.WriteDebugMessage("Landed on Manage Campaign Page for Property: " + CompanyName);
            CampaignDetails data = new CampaignDetails();
            SqlWarehouseQuery.ReturnCampaignStatus(Convert.ToInt32(projectID), data);
            ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign);
            ManageCampaign.ManageCampaign_EllipseButton("Edit");
            ElementWait(PageObject_CreateCampaign.CreateCampaign_Button_ChangeTemplate(), 120);
            Logger.WriteDebugMessage("Landed on Edit Template Tab.");
            CreateCampaign.CreateCampaign_Button_SaveandContinue();
            ElementWait(PageObject_ManageCampaign.Button_Campaign_BasicValidationReport(), 60);
            Logger.WriteDebugMessage("Landed on Testing Tab.");
            CreateCampaign.CreateCampaign_Button_SaveandContinue();
            ElementWait(Driver.FindElement(By.XPath("//*[@id='SendToTestEmails" + projectID + "']")), 60);
            Logger.WriteDebugMessage("Landed on Approval Tab.");
            CreateCampaign.Click_Button_SendforApproval();
            CreateCampaign.CampaignApprove(Convert.ToInt32(projectID));
        }
        public static void TC_198278()
        {
            Users SData = new Users();
            string projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", TestPlanId);

            Logger.WriteDebugMessage("Logged in to eInsight with UserName - " + LegacyTestData.CommonFrontendEmail + " and Password " + LegacyTestData.CommonFrontendPassword + ". Landed on eInsight Home Page.");

            CampaignDetails data = new CampaignDetails();
            SqlWarehouseQuery.ReturnCampaignStatus(Convert.ToInt32(projectID), data);
            if (data.OldStatus != "Approved")
            {
                SqlWarehouseQuery.UpdateProjectStatus(Convert.ToInt32(projectID), "ApprovedEmailCampaign");
                SqlWarehouseQuery.GetPersonalizedTagValue(SData, CompanyName, 0, "", projectID, "");
                SqlWarehouseQuery.GetPersonalizedTagValue(SData, CompanyName, 1, "", projectID, SData.CustomerIDs);
                Navigation.MenuNavigation("ManageCampaign");
                AddDelay(10000);
                Logger.WriteDebugMessage("Landed on Manage Campaign");
                ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign);
                ManageCampaign.ManageCampaign_EllipseButton("Edit");
                ElementWait(PageObject_CreateCampaign.CreateCampaign_Button_ChangeTemplate(), 120);
                Logger.WriteDebugMessage("Landed on Edit Template Tab.");
                CreateCampaign.CreateCampaign_Button_SaveandContinue();
                ElementWait(PageObject_ManageCampaign.Button_Campaign_BasicValidationReport(), 60);
                Logger.WriteDebugMessage("Landed on Testing Tab.");
                CreateCampaign.CreateCampaign_Button_SaveandContinue();
                ElementWait(Driver.FindElement(By.XPath("//*[@id='SendToTestEmails" + projectID + "']")), 60);
                Logger.WriteDebugMessage("Landed on Approval Tab.");
                CreateCampaign.Click_Button_SendforApproval();
                CreateCampaign.CampaignApprove(Convert.ToInt32(projectID));
                ManageCampaign.ManageCampaign_ScheduleCampaign();
                AddDelay(8000);
                CreateCampaign.SelectTime();
                CreateCampaign.CampaignScheduleandComplete();

            }
            else
            {
                //SqlWarehouseQuery.GetCustomerIDSendTest(SData, CompanyName);
                SqlWarehouseQuery.GetPersonalizedTagValue(SData, CompanyName, 0, "", projectID, "");
                SqlWarehouseQuery.GetPersonalizedTagValue(SData, CompanyName, 1, "", projectID, SData.CustomerIDs);
                Navigation.MenuNavigation("ManageCampaign");
                AddDelay(10000);
                Logger.WriteDebugMessage("Landed on Manage Campaign");
                ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign);
                ManageCampaign.ManageCampaign_EllipseButton("Edit");
                AddDelay(10000);
                Driver.SwitchTo().ParentFrame();
                ManageCampaign.ManageCampaign_ScheduleCampaign();
                AddDelay(8000);
                CreateCampaign.SelectTime();
                CreateCampaign.CampaignScheduleandComplete("Schedule");
                AddDelay(300000);
            }

        }
        public static void TC_198279()
        {
            Users SData = new Users();
            CampaignDetails data = new CampaignDetails();
            projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", TestPlanId);
            SqlWarehouseQuery.ReturnCampaignStatus(Convert.ToInt32(projectID), data);
            if (data.OldStatus != "Scheduled")
            {
                Assert.Fail("Campaign was not successfully scheduled in Test Case # 198278");
            }
            else
            {
                Logger.WriteDebugMessage("Logged in to eInsight with UserName - " + LegacyTestData.CommonFrontendEmail + " and Password " + LegacyTestData.CommonFrontendPassword + ". Landed on eInsight Home Page.");

                Navigation.MenuNavigation("ManageCampaign");
                Logger.WriteDebugMessage("Landed on Manage Campaign Page.");
                
                SqlWarehouseQuery.ReturnCampaignStatus(Convert.ToInt32(projectID), data);
                ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign);
                //ScrollToElement(Driver.FindElement(By.XPath("//*[@id='closeImgTag" + projectID + "']")));
                ManageCampaign.ManageCampaign_InactivateSchedule();
                ElementClick(PageObject_ManageCampaign.ManageCampaign_SearchProjectID());
                //ElementEnterText(PageObject_ManageCampaign.ManageCampaign_SearchProjectIDTexts(), projectID);
                ElementClick(PageObject_ManageCampaign.ManageCampaign_SearchProjectID_Filters());
                AddDelay(2000);
                ElementClick(Driver.FindElement(By.XPath("(//a[contains(text(),'Drafts')])[1]")));
                ElementClick(Driver.FindElement(By.XPath("(//a[contains(text(),'All')])[1]")));
                int ScheduleStatus = SqlWarehouseQuery.ReturnCampaignScheduleStatus(Convert.ToInt32(projectID));
                if (ScheduleStatus == 0)
                {
                    IWebElement elem = Driver.FindElement(By.XPath("//span[contains(text(), 'Scheduled Inactive')]"));
                    ScrollToElement(elem);
                    HighlightElement(elem);
                    Logger.WriteDebugMessage("Campaign is inactivated.");
                }
                else
                {
                    Assert.Fail("Campaign was not deactivated.");
                }
            }
        }
        public static void TC_198280()
        {
            try
            {
                Users SData = new Users();
                projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", TestPlanId);
                Logger.WriteDebugMessage("Logged in to eInsight with UserName - " + LegacyTestData.CommonFrontendEmail + " and Password " + LegacyTestData.CommonFrontendPassword + ". Landed on eInsight Home Page.");

                Navigation.MenuNavigation("ManageCampaign");
                Logger.WriteDebugMessage("Landed on Manage Campaign Page for Property: " + CompanyName);
                CampaignDetails data = new CampaignDetails();
                SqlWarehouseQuery.ReturnCampaignStatus(Convert.ToInt32(projectID), data);
                ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign);
                //ManageCampaign.StatusFilterByName("Scheduled Inactive", 6);
                ManageCampaign.ManageCampaign_ActivateSchedule();
                ElementClick(PageObject_ManageCampaign.ManageCampaign_SearchProjectID());
                //ElementEnterText(PageObject_ManageCampaign.ManageCampaign_SearchProjectIDTexts(), projectID);
                ElementClick(PageObject_ManageCampaign.ManageCampaign_SearchProjectID_Filters());
                AddDelay(2000);
                ElementClick(Driver.FindElement(By.XPath("(//a[contains(text(),'Drafts')])[1]")));
                ElementClick(Driver.FindElement(By.XPath("(//a[contains(text(),'All')])[1]")));
                int ScheduleStatus = SqlWarehouseQuery.ReturnCampaignScheduleStatus(Convert.ToInt32(projectID));
                ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign);
                if (ScheduleStatus == 1)
                {
                    ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign);
                    IWebElement elem = Driver.FindElement(By.XPath("//span[contains(text(), 'Scheduled Active')]"));
                    ScrollToElement(elem);
                    HighlightElement(elem);
                    Logger.WriteDebugMessage("Campaign is Activated.");
                }
                else
                {
                    Assert.Fail("Campaign was not activated.");
                }
            } catch(Exception e)
            {

            }
        }
        public static void TC_236459()
        {
            /*
                Independent Collection:40004529
                Minor: 40004744
                Omni Hotels & Resorts: 40004745
                */

            string projectIDs = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "projectIDs");
            Logger.WriteDebugMessage("Logged in to eInsight with UserName - " + LegacyTestData.CommonFrontendEmail + " and Password " + LegacyTestData.CommonFrontendPassword + ". Landed on eInsight Home Page.");
            string[] getprojectIds = Regex.Split(projectIDs, ",");
            foreach (string pIDs in getprojectIds)
            {
                string projectID = pIDs;
                Logger.WriteInfoMessage("Executing for ProjectID: " + projectID + ". And updating Campaign status to Draft.");
                SqlWarehouseQuery.UpdateProjectStatus(Convert.ToInt32(projectID));

                Users tagValues = new Users();
                //TestCase to execute and check the personalization tags
                ClientdbConnection name = new ClientdbConnection();
                SqlWarehouseQuery.GetCompanyName(Int32.Parse(pIDs), name);

                SqlWarehouseQuery.GetPersonalizedTagValue(tagValues, name.CompanyName, 0, "", pIDs.ToString(), "");
                Logger.WriteInfoMessage("Computing for CustomerIds: " + tagValues.CustomerIDs);
                string[] geteachCustomerIds = Regex.Split(tagValues.CustomerIDs, ",");
                foreach (string custID in geteachCustomerIds)
                {
                    Navigation.MenuNavigation("ManageCampaign");

                    Logger.WriteDebugMessage("Landed on Manage Campaign Page for Property: " + name.ParentCompanyName + " - " + name.CompanyName);

                    Logger.WriteInfoMessage("Starting for CustomerID: " + custID);
                    SqlWarehouseQuery.GetPersonalizedTagValue(tagValues, name.CompanyName, 1, "", projectID.ToString(), custID);
                    ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign);
                    ManageCampaign.ManageCampaign_EllipseButton("Details");
                    ManageCampaign.CampaignDetails_TabActions("Audience", projectID, "CustomerDetails");
                    ManageCampaign.SearchCustomer("Reservation", tagValues.ReservationNumber);
                    ManageCampaign.CustomerDetailEllipse_PreviewQuickSend("Preview");
                    AddDelay(10000);
                    ManageCampaign.VerifyPersonalizeData(tagValues, 3, name.CompanyName, custID, "Preview", Int32.Parse(pIDs));
                    Logger.WriteInfoMessage("\nContinuing with Quick send\n");
                    DateTime Date = DateTime.Parse(tagValues.ArrivalDate);
                    string arrivalDate = Date.ToString("M/d/yyyy");
                    Date = DateTime.Parse(tagValues.DepartureDate);
                    string depatureDate = Date.ToString("M/d/yyyy");
                    string resxPath = tagValues.ReservationNumber + " | " + arrivalDate + " - " + depatureDate;
                    //ManageCampaign.CASL_QuickSendVerification(SData.CustomerIDs, 0, "", SData.ReservationNumber, resxPath);
                    ManageCampaign.Customer_Send_QuickSend(tagValues.CustomerIDs, tagValues.ReservationNumber, resxPath);
                    OpenNewTab();
                    ControlToNewWindow();
                    Login.AutoAcc_login(tagValues.Email, 2, 0, LegacyTestData.CommonCatchallURL, 0);
                    ManageCampaign.VerifyPersonalizeData(tagValues, 3, name.CompanyName, custID, "Schedule", Int32.Parse(pIDs));

                    Hotmail.OutlookSignOut();
                    CloseCurrentTab();
                    ControlToPreviousWindow();

                    /* Add Campaign Status and Extract Status */

                }
                Logger.WriteInfoMessage("\nContinuing by Scheduling Campaign\n");
                Navigation.MenuNavigation("ManageCampaign");
                ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign);

                //CampaignDetails data = new CampaignDetails();
                //SqlWarehouseQuery.ReturnCampaignStatus(projectID, data);
                //ManageCampaign.PreSearchCampaign(1, projectID, data.CompanyName);

                ManageCampaign.ManageCampaign_EllipseButton("Edit");
                CreateCampaign.CreateCampaign_Button_Save();
                ElementWait(PageObject_ManageCampaign.Button_Campaign_BasicValidationReport(), 60);
                Logger.WriteDebugMessage("Landed on Testing Tab.");
                CreateCampaign.CreateCampaign_Button_Save();
                ElementWait(Driver.FindElement(By.XPath("//*[@id='SendToTestEmails" + projectID + "']")), 60);
                Logger.WriteDebugMessage("Landed on Approval Tab.");
                CreateCampaign.Click_Button_SendforApproval();
                CreateCampaign.CampaignApprove(Convert.ToInt32(projectID));
                CreateCampaign.CreateCampaign_Button_SaveandContinue();
                ElementWait(PageObject_CreateCampaign.CreateCampaign_Link_ScheduleTab(), 60);
                Logger.WriteDebugMessage("Landed on Schedule Page");
                CreateCampaign.SelectTime();
                CreateCampaign.CampaignScheduleandComplete();
            }
        }
        //if (TestCaseId == Constants.TC_236460)
        //{
        //    int projectID = 40004551;

        //    SqlWarehouseQuery.UpdateProjectStatus(projectID);

        //    Users tagValues = new Users();
        //    //TestCase to execute and check the personalization tags
        //    ElementWait(Driver.FindElement(By.XPath("//*[@id='MarketingCampaignsReport']/img")), 60);
        //    Logger.WriteDebugMessage("Logged in to eInsight with UserName - " + LegacyTestData.CommonFrontendEmail + " and Password " + LegacyTestData.CommonFrontendPassword + ". Landed on eInsight Home Page.");
        //    CompanyName = "Independent Collection";
        //    Navigation.MenuNavigation("ManageCampaign");
        //    Logger.WriteDebugMessage("Landed on Manage Campaign Page for Property: " + CompanyName);
        //    SqlWarehouseQuery.GetPersonalizedTagValue(tagValues, CompanyName, 0, "", projectID.ToString(), "");
        //    Logger.WriteInfoMessage("Computing for CustomerIds: " + tagValues.CustomerIDs);
        //    string[] geteachCustomerIds = Regex.Split(tagValues.CustomerIDs, ",");
        //    foreach (string custID in geteachCustomerIds)
        //    {
        //        Logger.WriteInfoMessage("Staring for CustomerID: " + custID);
        //        SqlWarehouseQuery.GetPersonalizedTagValue(tagValues, CompanyName, 1, "", projectID.ToString(), custID);
        //       ManageCampaign.SearchCampaign(custID, tagValues.Email, 2, projectID, 0);
        //        AddDelay(10000);
        //        ManageCampaign.VerifyPersonalizeData(tagValues, 3, CompanyName, custID, "Stays");
        //        Logger.WriteInfoMessage("\nContinuing with Quick send\n");
        //        Navigatetoiframe(0);
        //        ManageCampaign.CASL_QuickSendVerification(custID, 1);
        //        OpenNewTab();
        //        ControlToNewWindow();
        //        Login.AutoAcc_login(tagValues.Email, 2);
        //        ManageCampaign.VerifyPersonalizeData(tagValues, 3, CompanyName, custID, "Stays");
        //        Hotmail.OutlookSignOut();
        //        CloseCurrentTab();
        //        ControlToPreviousWindow();
        //        Logger.WriteInfoMessage("\nContinuing by Scheduling Campaign\n");
        //        Navigation.MenuNavigation("ManageCampaign");
        //        ManageCampaign.PreSearchCampaign(1, projectID, "Independent Collection");

        //        //CampaignDetails data = new CampaignDetails();
        //        //SqlWarehouseQuery.ReturnCampaignStatus(projectID, data);
        //        //ManageCampaign.PreSearchCampaign(1, projectID, data.CompanyName);

        //        ManageCampaign.ManageCampaign_EditCampaign(projectID);
        //        CreateCampaign.CreateCampaign_Button_Save();
        //        ElementWait(PageObject_ManageCampaign.Button_Campaign_BasicValidationReport(), 60);
        //        Logger.WriteDebugMessage("Landed on Testing Tab.");
        //        CreateCampaign.CreateCampaign_Button_Save();
        //        ElementWait(Driver.FindElement(By.XPath("//*[@id='SendToTestEmails" + projectID + "']")), 60);
        //        Logger.WriteDebugMessage("Landed on Approval Tab.");
        //        CreateCampaign.Click_Button_SendforApproval();
        //        CreateCampaign.CampaignApprove(projectID);
        //        CreateCampaign.CreateCampaign_Button_SaveandContinue();
        //        ElementWait(PageObject_CreateCampaign.CreateCampaign_Link_ScheduleTab(), 60);
        //        Logger.WriteDebugMessage("Landed on Schedule Page");
        //        CreateCampaign.SelectTime();
        //        CreateCampaign.CampaignScheduleandComplete();
        //        AddDelay(420000);
        //        /* Add Campaign Status and Extract Status */
        //        Login.AutoAcc_login(tagValues.Email, 1);
        //        ManageCampaign.VerifyPersonalizeData(tagValues, 3, CompanyName, custID, "Stays");

        //        SqlWarehouseQuery.UpdateProjectStatus(projectID);

        //    }

        //}
        public static void TC_255907()
        {
            Logger.WriteInfoMessage("Starting Test Case ID - 255907 - Clone Campaign");
            CampaignDetails details = new CampaignDetails();
            //SqlWarehouseQuery.GetCampaignforClone(details);

            projectID = SqlWarehouseQuery.ReturnCompanyName("NA", "ProjectID", TestPlanId);
            
            CampaignDetails data = new CampaignDetails();
            SqlWarehouseQuery.ReturnCampaignStatus(Convert.ToInt32(projectID), data);

            Navigation.MenuNavigation("ManageCampaign");
            if (Driver.Url.Contains("ManageCampaigns"))
            {
                //Logger.WriteDebugMessage("Campaign Scheduled.");

                AddDelay(2500);
                //Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL + "Project.mvc/Project/View?projectId=" + details.ParentProjectID);
                //ManageCampaign.PreSearchCampaign(1, Convert.ToInt32(details.ParentProjectID), details.ParentCompanyName, details.CompanyName);
                ManageCampaign.PreSearchCampaign_New(data.CompanyName, "ProjectID", projectID, iFrameManageCampaign);
                //Logger.WriteDebugMessage("Navigated to Manage Campaign for ProjectID - " + details.ParentProjectID);

                //HighlightElement(Driver.FindElement(By.XPath("//a[@id='clone']")));
                //Logger.WriteDebugMessage("Clicking on Clone button.");
                //IWebElement SearchElement = Driver.FindElement(By.XPath("//a[@id='clone']"));
                //IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
                //js.ExecuteScript("arguments[0].click();", SearchElement);
                ManageCampaign.ManageCampaign_EllipseButton("Clone");
                AddDelay(9000);

                if (IsElementVisible(PageObject_CreateCampaign.CreateCampaign_Button_SaveandContinue()))
                {
                    string getURL = Driver.Url;
                    var newProjectID = Regex.Match(getURL, "#(.*)&ProjectTitle").Groups[1].Value;
                    newProjectID = newProjectID.Replace("ProjectId=", "");
                    string subjectName = "ProjectId=" + newProjectID;
                    Logger.WriteDebugMessage("Landed on Cloned Campaign - Edit Campaign. New ProjectID - " + newProjectID);

                    DynamicScroll(Driver, PageObject_CreateCampaign.CreateCampaign_EditTemplate_Subject());
                    ManageCampaign.EnterCampaignSubject(subjectName);

                    ScrollDownUsingJavaScript(Driver, -1500);
                    
                    CreateCampaign.CreateCampaign_Button_SaveandContinue();

                    Navigation.MenuNavigation("ManageCampaign");
                    Driver.SwitchTo().ParentFrame();
                    ManageCampaign.PreSearchCampaign_New(data.CompanyName, "ProjectID", newProjectID, iFrameManageCampaign);

                    Logger.WriteDebugMessage("Cloned Campaign located for ProjectID - " + newProjectID);
                    AddDelay(2000);

                    Logger.WriteInfoMessage("Starting Test Case ID - 255908 - Delete Campaign");

                    ManageCampaign.ManageCampaign_EllipseButton("Details");
                    ScrollDownUsingJavaScript(Driver, -1000);
                    ManageCampaign.CampaignDetails_PerformActonsItems("Delete");
                    Driver.Navigate().Refresh();
                    AddDelay(3000); // Change -- Added delay
                    Driver.SwitchTo().ParentFrame();
                    ManageCampaign.ManageCampaign_SearchProjectIDOnly(CompanyName, "ProjectID", newProjectID, iFrameManageCampaign);

                    if (!IsElementPresent(By.XPath("//span[contains(text(), 'ID')]//following::*[contains(text(), '" + newProjectID + "')]")))
                    {
                        Logger.WriteDebugMessage("ProjectID - " + newProjectID + " new ProjectID is deleted.");
                    }
                }

                /*              
                //Profile.SelectClient(details.ParentCompanyName);
                Profile.SelectSubClient(details.CompanyName);

                ManageCampaign.ClickSearchTab();
                if (IsElementPresent((By.Id("newsearch")))) //ElementClick(Driver.FindElement(By.Id("newsearch")));
                {
                    ElementClick(Driver.FindElement(By.Id("newsearch")));
                }
                ElementWait(PageObject_ManageCampaign.ManageCampaign_Search_SearchButton(), 60);
                ManageCampaign.SelectSearchField("Campaign Name");
                ManageCampaign.InsertInput(details.CampaignName + " - Clone");
                ManageCampaign.ClickSearchButton();
                AddDelay(50000);
                ScrollToElement(Driver.FindElement(By.XPath("//*[contains(text(), '" + details.CampaignName + "')]")));
                ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollBy(0,-500)", "");
                Logger.WriteDebugMessage("Cloned Campaign located for " + details.CampaignName);
                AddDelay(20000);

                Logger.WriteInfoMessage("Starting Test Case ID - 255908 - Delete Campaign");
                HighlightElement(Driver.FindElement(By.XPath("//a[contains(text(), 'Delete Campaign')]")));
                Logger.WriteDebugMessage("CLicking on Delete Button");
                ElementClick(Driver.FindElement(By.XPath("//a[contains(text(), 'Delete Campaign')]")));
                Logger.WriteDebugMessage("Confirming to delete campaign.");
                ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'Ok')]")));
                AddDelay(35000);
                ((IJavaScriptExecutor)Driver).ExecuteScript("location.reload(true);");

                Navigation.MenuNavigation("ManageCampaign");
                Logger.WriteDebugMessage("Landed on Manage Campaign. Searching for " + details.CampaignName + " - Clone");
                AddDelay(10000);
                //Profile.SelectClient(details.ParentCompanyName);
                Profile.SelectSubClient(details.CompanyName);

                ManageCampaign.ClickSearchTab();
                if (IsElementPresent((By.Id("newsearch")))) //ElementClick(Driver.FindElement(By.Id("newsearch")));
                {
                    ElementClick(Driver.FindElement(By.Id("newsearch")));
                }
                ElementWait(PageObject_ManageCampaign.ManageCampaign_Search_SearchButton(), 60);
                ManageCampaign.SelectSearchField("Campaign Name");
                ManageCampaign.InsertInput(details.CampaignName + " - Clone");
                ManageCampaign.ClickSearchButton();
                AddDelay(25000);
                var quote = '"';
                if (VerifyTextOnPage("No campaigns match this criteria."))
                {
                    Logger.WriteDebugMessage(" Found text " + quote + "No campaigns match this criteria" + quote + ".Campaign was deleted Succesfully.");
                }
            }
            else
            {
                Assert.Fail("Did not land on the page.");
            }*/
            }
            //if (TestCaseId == Constants.TC_236460)
            //{
            //    int projectID = 40004551;

            //    SqlWarehouseQuery.UpdateProjectStatus(projectID);

            //    Users tagValues = new Users();
            //    //TestCase to execute and check the personalization tags
            //    ElementWait(Driver.FindElement(By.XPath("//*[@id='MarketingCampaignsReport']/img")), 60);
            //    Logger.WriteDebugMessage("Logged in to eInsight with UserName - " + LegacyTestData.CommonFrontendEmail + " and Password " + LegacyTestData.CommonFrontendPassword + ". Landed on eInsight Home Page.");
            //    CompanyName = "Independent Collection";
            //    Navigation.MenuNavigation("ManageCampaign");
            //    Logger.WriteDebugMessage("Landed on Manage Campaign Page for Property: " + CompanyName);
            //    SqlWarehouseQuery.GetPersonalizedTagValue(tagValues, CompanyName, 0, "", projectID.ToString(), "");
            //    Logger.WriteInfoMessage("Computing for CustomerIds: " + tagValues.CustomerIDs);
            //    string[] geteachCustomerIds = Regex.Split(tagValues.CustomerIDs, ",");
            //    foreach (string custID in geteachCustomerIds)
            //    {
            //        Logger.WriteInfoMessage("Staring for CustomerID: " + custID);
            //        SqlWarehouseQuery.GetPersonalizedTagValue(tagValues, CompanyName, 1, "", projectID.ToString(), custID);
            //       ManageCampaign.SearchCampaign(custID, tagValues.Email, 2, projectID, 0);
            //        AddDelay(10000);
            //        ManageCampaign.VerifyPersonalizeData(tagValues, 3, CompanyName, custID, "Stays");
            //        Logger.WriteInfoMessage("\nContinuing with Quick send\n");
            //        Navigatetoiframe(0);
            //        ManageCampaign.CASL_QuickSendVerification(custID, 1);
            //        OpenNewTab();
            //        ControlToNewWindow();
            //        Login.AutoAcc_login(tagValues.Email, 2);
            //        ManageCampaign.VerifyPersonalizeData(tagValues, 3, CompanyName, custID, "Stays");
            //        Hotmail.OutlookSignOut();
            //        CloseCurrentTab();
            //        ControlToPreviousWindow();
            //        Logger.WriteInfoMessage("\nContinuing by Scheduling Campaign\n");
            //        Navigation.MenuNavigation("ManageCampaign");
            //        ManageCampaign.PreSearchCampaign(1, projectID, "Independent Collection");

            //        //CampaignDetails data = new CampaignDetails();
            //        //SqlWarehouseQuery.ReturnCampaignStatus(projectID, data);
            //        //ManageCampaign.PreSearchCampaign(1, projectID, data.CompanyName);

            //        ManageCampaign.ManageCampaign_EditCampaign(projectID);
            //        CreateCampaign.CreateCampaign_Button_Save();
            //        ElementWait(PageObject_ManageCampaign.Button_Campaign_BasicValidationReport(), 60);
            //        Logger.WriteDebugMessage("Landed on Testing Tab.");
            //        CreateCampaign.CreateCampaign_Button_Save();
            //        ElementWait(Driver.FindElement(By.XPath("//*[@id='SendToTestEmails" + projectID + "']")), 60);
            //        Logger.WriteDebugMessage("Landed on Approval Tab.");
            //        CreateCampaign.Click_Button_SendforApproval();
            //        CreateCampaign.CampaignApprove(projectID);
            //        CreateCampaign.CreateCampaign_Button_SaveandContinue();
            //        ElementWait(PageObject_CreateCampaign.CreateCampaign_Link_ScheduleTab(), 60);
            //        Logger.WriteDebugMessage("Landed on Schedule Page");
            //        CreateCampaign.SelectTime();
            //        CreateCampaign.CampaignScheduleandComplete();
            //        AddDelay(420000);
            //        /* Add Campaign Status and Extract Status */
            //        Login.AutoAcc_login(tagValues.Email, 1);
            //        ManageCampaign.VerifyPersonalizeData(tagValues, 3, CompanyName, custID, "Stays");

            //        SqlWarehouseQuery.UpdateProjectStatus(projectID);

            //    }

            //}
        }
        #endregion[TP_197270]

    }
}

