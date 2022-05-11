using System;
using eInsight.Utility;
using eInsight.AppModule.UI;
using Common;
using Constants = eInsight.Utility.Constants;
using InfoMessageLogger;
using BaseUtility.Utility;
using TestData;
using SqlWarehouse;
using OpenQA.Selenium;
using NUnit.Framework;
using eInsight.AppModule.UI;
using eInsight.PageObject.UI;
using System.Text.RegularExpressions;
using BaseUtility.Utility.Hotmail;
using System.Collections.Generic;

namespace eInsight.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {

        private static void Prerequisite_TP_276287(AudienceBuilderData builderData)
        {
            /*Pre - requisite */
            audienceName = "QATest_" + TestPlanId;
            string dynamicCriteriaJSON = SqlWarehouseQuery.ReturnDescriptionValue("NA", "AudienceName", "TP_240125");
            string email = LegacyTestData.CommonFrontendEmail;

            SqlWarehouseQuery.createAudience(CompanyName, builderData, audienceName, dynamicCriteriaJSON, email);
            if (builderData.AudienceDetailID == "1")
            {
                Logger.WriteInfoMessage("Audience Name " + audienceName + " already exist.");
            }
            else
            {
                Logger.WriteInfoMessage("Created a new Audience Name " + audienceName + " " + builderData.AudienceDetailID);
            }
            SqlWarehouseQuery.publishAudience(CompanyName, builderData, audienceName, email);
            if (string.IsNullOrEmpty(builderData.AudiencePublishDetailID))
            {
                Logger.WriteInfoMessage("Couldn't Publish Audience - " + audienceName);
                Assert.Fail("Unable to publish Audience " + audienceName);
            }
            else
            {
                Logger.WriteInfoMessage("Published Audience " + audienceName + ". Pulished AudienceID is  " + builderData.AudiencePublishDetailID);
            }
            /*End of Pre-requisite*/
        }

        public static void TC_276301()
        {
            //Checking for Home Page
            if (testCategory == "EU01_PostDeployment")
                Profile.SelectSubClient(clientNameByTestCase);
            else
                Profile.SelectSubClient("Hotel Origami");

            if (Driver.Url.Contains("home.mvc"))
            {
                if (IsElementPresent(By.XPath("//span[contains(text(),'All Activity')]")))
                {
                    Logger.WriteDebugMessage("Landed on Home Page successfully.");
                }
                //Checking for Profile Page
                ElementClickNoLog(Driver.FindElement(By.XPath("//a[contains(@href, 'Profile.mvc/Profile')]")));
                ElementWait(Driver.FindElement((By.Id("q"))), 60);
                if (IsElementPresent(By.Id("q")))
                {
                    Logger.WriteDebugMessage("Landed on Profile Page successfully.");
                }
                else
                {
                    Assert.Fail("Did not land on Profile Page.");
                }
                if (testCategory != "EU01_PostDeployment")
                {
                    //Checking for PriorityQ Reservation Page
                    ElementClickNoLog(Driver.FindElement(By.XPath("//a[contains(@href, '/Profile.mvc/Reservation/Reservation')]")));
                    AddDelay(8000);
                    Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//iframe[@name='Reservation']")));
                    if (IsElementVisible(PageObject_PriorityQ.PriorityQ_Reset()))
                    {
                        Logger.WriteDebugMessage("Landed on PriorityQ (Reservation) Page successfully.");
                    }
                    else
                    {
                        Assert.Fail("Did not land on PriorityQ (Reservation) Page.");
                    }
                    Driver.SwitchTo().ParentFrame();
                }
                //Checking for Audience Builder Page
                ElementClickNoLog(Driver.FindElement(By.XPath("//a[contains(@href, '/Project.mvc/Project/Audience')]")));
                AddDelay(20000);
                Driver.SwitchTo().Frame(0);
                ElementWait(Driver.FindElement(By.Id("selectField")), 60);
                if (IsElementPresent(By.Id("selectField")))
                {
                    Logger.WriteDebugMessage("Landed on Audience Builder Page successfully.");
                }
                else
                {
                    Assert.Fail("Did not land on Audience Builder Page.");
                }

                //Checking for Create Campaign Page
                Driver.SwitchTo().ParentFrame();
                ElementClickNoLog(Driver.FindElement(By.XPath("//a[@id='campaignsNav']")));
                ElementClickNoLog(Driver.FindElement(By.XPath("//a[@id='campaignsNav']//following::a[contains(@href, '/Project.mvc/Project/Create')]")));
                if (VerifyTextOnPage("Who will this campaign be sent for?"))
                {
                    Logger.WriteDebugMessage("Landed on Create Campaign Page successfully.");
                }
                else
                {
                    Assert.Fail("Did not land on Create Campaign Page.");
                }

                //Checking for Manage Campaign Page
                ElementClickNoLog(Driver.FindElement(By.XPath("//a[@id='campaignsNav']")));
                ElementClickNoLog(Driver.FindElement(By.XPath("//a[@id='campaignsNav']//following::a[contains(@href, '/Project.mvc/Project/ManageCampaigns')]")));
                AddDelay(20000);
                if (Driver.Url.Contains("Project.mvc/Project/ManageCampaigns"))
                {
                    Logger.WriteDebugMessage("Landed on Manage Campaign Page successfully.");
                }
                else
                {
                    Assert.Fail("Did not land on Manage Campaign Page.");
                }
                if (testCategory == "EU02_PostDeployment")
                {

                    //Checking for Templates Page
                    ElementClickNoLog(Driver.FindElement(By.XPath("//a[@id='campaignsNav']")));
                    ElementClickNoLog(Driver.FindElement(By.XPath("//a[@id='campaignsNav']//following::a[contains(@href, '/Project.mvc/Project/TemplateBuilder')]")));
                    AddDelay(20000);
                    if (Driver.Url.Contains("Project.mvc/Project/TemplateBuilder"))
                    {
                        Logger.WriteDebugMessage("Landed on Templates Page successfully.");
                    }
                    else
                    {
                        Assert.Fail("Did not land on Manage Campaign Page.");
                    } 
                }

                //Checking for Calender Page
                ElementClickNoLog(Driver.FindElement(By.XPath("//a[contains(@href, '/Calendar.mvc/Calendar')]")));
                if (IsElementPresent(By.Id("chkShowTransactional")))
                {
                    Logger.WriteDebugMessage("Landed on Calender Page successfully.");
                }
                else
                {
                    Assert.Fail("Did not land on Calender Page.");
                }

                //Checking for eGallery Page
                ElementClickNoLog(Driver.FindElement(By.Id("eGalleryMenuBttn")));
                if (testCategory == "EU01_PostDeployment")
                {
                    ElementEnterText(Driver.FindElement(By.Id("navFilterTextBox")), clientNameByTestCase);
                    AddDelay(5000);
                    ElementClickNoLog(Driver.FindElement(By.XPath("(//a[contains(text(), 'Jumeirah Nanjing OXI')])[1]")));
                }

                else
                {
                    ElementEnterText(Driver.FindElement(By.Id("navFilterTextBox")), "Origami");
                    AddDelay(5000);
                    ElementClickNoLog(Driver.FindElement(By.XPath("(//a[contains(text(), 'Hotel Origami')])[1]")));
                }
                ControlToNewWindow();
                AddDelay(25000);
                Driver.SwitchTo().Frame("eGalleryiFrame");
                if (IsElementPresent(By.XPath("//a[contains(text(), 'Recycle Bin')]")))
                {
                    Logger.WriteDebugMessage("Landed on eGallery Page successfully for Hotel Origami.");
                }
                else
                {
                    Assert.Fail("Did not land on eGallery Page Page.");
                }
                Driver.SwitchTo().ParentFrame();
                CloseCurrentTab();
                ControlToPreviousWindow();
                ElementClickNoLog(Driver.FindElement(By.Id("eGalleryMenuBttn")));

                //Checking for eReports Page
                if(testCategory== "EU01_PostDeployment")
                {
                    ElementClickNoLog(Driver.FindElement(By.XPath("//a[@id='reportsToggle']/span[2]")));
                    ScrollToElement(Driver.FindElement(By.XPath("//table[@class='innerNavFlyDownInnerTable']//*[contains(text(), 'Jumeirah Nanjing OXI')]")));
                    ElementClickNoLog(Driver.FindElement(By.XPath("//table[@class='innerNavFlyDownInnerTable']//*[contains(text(), 'Jumeirah Nanjing OXI')]")));
                    ControlToNewWindow();
                    AddDelay(25000);
                    if (VerifyTextOnPage("Hello. Welcome to eInsight Reports"))
                    {
                        Logger.WriteDebugMessage("Landed on eReports Page successfully .");
                    }
                    else
                    {
                        Assert.Fail("Did not land on eReports Page Page.");
                    }
                    CloseCurrentTab();
                    ControlToPreviousWindow();
                    ElementClickNoLog(Driver.FindElement(By.XPath("//a[@id='reportsToggle']/span[2]")));
                }
                else
                {
                    ElementClickNoLog(Driver.FindElement(By.XPath("//a[@id='reportsToggle']/span[2]")));
                    ScrollToElement(Driver.FindElement(By.XPath("(//table[@class='innerNavFlyDownInnerTable']//*[contains(text(), 'Hotel Origami')])[2]")));
                    ElementClickNoLog(Driver.FindElement(By.XPath("(//table[@class='innerNavFlyDownInnerTable']//*[contains(text(), 'Hotel Origami')])[2]")));
                    ControlToNewWindow();
                    AddDelay(35000);
                    if (IsElementDisplayed(Driver.FindElement(By.XPath("//div[contains(text(),'eInsight Reports')]"))))
                    {
                        Logger.WriteDebugMessage("Landed on eReports Page successfully .");
                    }
                    else
                    {
                        Assert.Fail("Did not land on eReports Page Page.");
                    }
                    CloseCurrentTab();
                    ControlToPreviousWindow();
                    ElementClickNoLog(Driver.FindElement(By.XPath("//a[@id='reportsToggle']/span[2]")));
                }
                //Checking for Survey Page
                ElementClickNoLog(Driver.FindElement(By.XPath("//a[contains(@href, '/Survey.mvc/Survey')]")));
                AddDelay(20000);
                if (IsElementPresent(By.XPath("//a[contains(text(), 'Reports')]")))
                {
                    Logger.WriteDebugMessage("Landed on Survey Page successfully.");
                }
                else
                {
                    Assert.Fail("Did not land on Survey Page Page.");
                }
            }
            else
            {
                Assert.Fail("Did not land on Home Page.");
            }
        }

        public static void TC_261909()
        {
            //#region[Prerequisite]

            //#endregion[Prerequisite]
            Users tagValues = new Users();
            string audienceName;
            Profile.SelectSubClient(clientNameByTestCase);
            if (testCategory == "EU02_PostDeployment")
                audienceName = "QA Testing 1";
            else
                audienceName = "QA Testing";
            Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL + "Project.mvc/Project/Create");
            Logger.WriteDebugMessage("Landed on Create Campaign - Property Selection Page");

            ElementClick(Driver.FindElement(By.XPath("//a[contains(text(), 'Hotel Origami')]")));
            ElementWait(Driver.FindElement(By.XPath("//div[contains(@onclick, 'CreateCampaign') and contains(text(), 'Create')]")), 25);
            ElementClick(Driver.FindElement(By.XPath("//div[contains(@onclick, 'CreateCampaign') and contains(text(), 'Create')]")));
            #region[CriteriaPageSteps]
            AddDelay(10000);
            ElementWait(Driver.FindElement(By.XPath("(//button[contains(text(), 'Save')])[2]")), 120);
            if (IsElementVisible(Driver.FindElement(By.XPath("(//button[contains(text(), 'Save')])[2]"))))
            {
                Logger.WriteDebugMessage("Landed on Create Campaign - Criteria Selection Page");
            }
            else
            {
                Assert.Fail("Did not land on Criteria Page.");
            }
            ElementWait(Driver.FindElement(By.XPath("//span[contains(text(), 'Audience Search')]")), 60);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Campaign Settings')]")));

            ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'Include Unsubscribed')]")));
            ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'Include Bounced')]")));
            ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'Include Non-Consent')]")));
            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Campaign Settings')]")));

            ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'Audience Search')]")));
            Logger.WriteDebugMessage("Landed on Create Campaign - Audience Search Tab");

            ScrollDownUsingJavaScript(Driver, 300);

            IWebElement frameElement = Driver.FindElement(By.Name("Audience"));
            Logger.WriteInfoMessage("Switching into the iFrame." + frameElement);
            Driver.SwitchTo().Frame(frameElement);
            AddDelay(1000);


            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_SearchButton();

            if (testCategory == "EU02_PostDeployment")
                ElementClick(Driver.FindElement(By.XPath("//label[@for = '55']")));
            else
                ElementClick(Driver.FindElement(By.XPath("//label[@for = '75']")));

            Driver.SwitchTo().ParentFrame();
            string subjectName = "Cendyn QA Testing - " + TestCaseId + "(do not touch)";
            ScrollDownUsingJavaScript(Driver, -1000);

            ElementEnterText(Driver.FindElement(By.Id("project_name")), subjectName);
            ElementClick(PageObject_CreateCampaign.CreateCampaign_CriteriaPage_Save());
            ManageCampaign.CriteriaPage_ForcastTargetAudience(0);
            ElementClick(PageObject_CreateCampaign.CreateCampaign_CriteriaPage_SaveandContinue());
            #endregion[CriteriaPageSteps]
            #region[TemplateSelection]
            AddDelay(15000);
            Driver.SwitchTo().Frame(Driver.FindElement(By.XPath(iFrameTemplateBuilder)));
            CreateCampaign.GetTemplale("GrapeJSEditor");
            Driver.SwitchTo().ParentFrame();
            #endregion[TemplateSelection]
            #region[EditTemplateSection]
            string getURL = Driver.Url;
            var newProjectID = Regex.Match(getURL, "#(.*)&ProjectTitle").Groups[1].Value;
            newProjectID = newProjectID.Replace("ProjectId=", "");
            subjectName = subjectName + " - " + newProjectID;
            Logger.WriteDebugMessage("New Campaign " + subjectName + " is created with AudienceName " + audienceName + " with ProjectID - " + newProjectID);

            CreateCampaign.AddSubjectinEditTemplate(subjectName);
            ScrollDownUsingJavaScript(Driver, -1000);
            CreateCampaign.CreateCampaign_Button_SaveandContinue();
            #endregion[EditTemplateSection]
            #region[TestingTab]
            ElementWait(PageObject_ManageCampaign.Button_Campaign_BasicValidationReport(), 180);
            Logger.WriteDebugMessage("Landed on Testing Tab.");
            CreateCampaign.CreateCampaign_Button_SaveandContinue();
            ElementWait(Driver.FindElement(By.XPath("//*[@id='SendToTestEmails" + newProjectID + "']")), 60);
            Logger.WriteDebugMessage("Landed on Approval Tab.");
            #endregion[TestingTab]
            #region[ApprovalTab]
            ElementWait(PageObject_CreateCampaign.Button_SendForApproval(), 30);
            CreateCampaign.Click_Button_SendforApproval();
            CreateCampaign.CampaignApprove(Int32.Parse(newProjectID));
            CreateCampaign.CreateCampaign_Button_Continue();
            ElementWait(PageObject_CreateCampaign.CreateCampaign_Link_ScheduleTab(), 60);
            Logger.WriteDebugMessage("Landed on Schedule Page");
            #endregion[ApprovalTab]
            #region[ScheduleTab]
            CreateCampaign.SelectTime();
            ScrollUpUsingJavaScript(Driver, -500);
            CreateCampaign.CampaignScheduleandComplete("Schedule");
            AddDelay(420000);
            #endregion[ScheduleTab]
            #region[CheckEmailTab]
            OpenNewTab();
            ControlToNewWindow();
            SqlWarehouseQuery.GetPersonalizedTagValue(tagValues, clientNameByTestCase, 0, "", newProjectID, "");
            if (!tagValues.CustomerIDs.Equals("5371205"))
                tagValues.CustomerIDs = "5371205";
            SqlWarehouseQuery.GetPersonalizedTagValue(tagValues, clientNameByTestCase, 1, "", newProjectID, tagValues.CustomerIDs);
            Login.AutoAcc_login(tagValues.Subject, 1, 1, LegacyTestData.CommonCatchallURL, 1);
            Hotmail.SearchEmailAndOpenLatestEmail(subjectName, 0);
            if (VerifyTextOnPage(subjectName))
            {
                Logger.WriteDebugMessage(subjectName + " campaign found after scheduling.");
            }

            #endregion[CheckEmailTab]

            #region[PostRequirement]
            ControlToPreviousWindow();
            ManageCampaign.PreSearchCampaign_New("Hotel Origami", "ProjectID", newProjectID, iFrameManageCampaign);
            ManageCampaign.ManageCampaign_EllipseButton("Details");
            ScrollDownUsingJavaScript(Driver, -1000);
            ManageCampaign.CampaignDetails_PerformActonsItems("Delete");
            #endregion[PostRequirement]
        }
        public static void TC_276316()
        {
            string projectID;
            if (testCategory== "EU02_PostDeployment")
                projectID = "89505254";
            else
                projectID = "40302785";
            Profile.SelectSubClient("Hotel Origami");

            Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL + "Project.mvc/Project/Edit?projectId=" + projectID);
            AddDelay(10000);

            ElementWait(Driver.FindElement(By.XPath("//button[contains(text(), 'Campaign Settings')]")), 60);
            if (IsElementVisible(Driver.FindElement(By.XPath("//button[contains(text(), 'Campaign Settings')]"))))
            {
                ElementClick(Driver.FindElement(By.XPath("//a[@href='#template']")));
                Logger.WriteDebugMessage("Landed on Edit Template Page. ProjectID - " + projectID);
            }
            else
            {
                Assert.Fail("Did not land on Edit Template Page.");
            }
            AddDelay(25000);
            string getURL = Driver.Url;
            var newProjectID = Regex.Match(getURL, "#(.*)&ProjectTitle").Groups[1].Value;
            newProjectID = newProjectID.Replace("ProjectId=", "");
            string subjectName = "Campaign - " + TestCaseId + " - " + "(do not touch)";
            ScrollDownUsingJavaScript(Driver, 100);

            ElementEnterText(Driver.FindElement(By.Id("subject")), subjectName);
            AddDelay(25000);
            ScrollUpUsingJavaScript(Driver, 1000);
            CreateCampaign.CreateCampaign_Button_Save();
            //if (VerifyTextOnPage("Save the empty template?"))
            //{
            //    ElementClick(Driver.FindElement(By.XPath("//a[@onclick='continueSaveEmptyTemplate()']")));
            //}
            AddDelay(25000);
            string typesofTemplate = "CuteEditor,BeeFreeEditor,GrapeJSEditor";
            string[] eachTemplate = Regex.Split(typesofTemplate, ",");
            foreach (string template in eachTemplate)
            {
                IList<IWebElement> ele = null;
                ele = Helper.Driver.FindElements(By.XPath("//div[contains(.,'Please wait, saving campaign')]/parent::div[@role='dialog']"));
                foreach (var item in ele)
                {
                    while (!item.GetAttribute("style").Contains("none"))
                    {
                        AddDelay(5000);
                    }
                    ele = Helper.Driver.FindElements(By.XPath("//div[contains(.,'Please wait, saving campaign')]/parent::div[@role='dialog']"));
                }
                CreateCampaign.ChangeTemplate(template);
                Driver.SwitchTo().Frame(Driver.FindElement(By.XPath(iFrameTemplateBuilder)));
                CreateCampaign.GetTemplale(template);
                Driver.SwitchTo().ParentFrame();
                ElementEnterText(Driver.FindElement(By.Id("subject")), subjectName);
            }
            ScrollDownUsingJavaScript(Driver, -1000);
            CreateCampaign.CreateCampaign_Button_Save();
            //ElementWait(PageObject_CreateCampaign.CreateCampaign_Button_SaveandContinue(), 60);
            //CreateCampaign.CreateCampaign_Button_SaveandContinue();



            //ElementWait(PageObject_ManageCampaign.Button_Campaign_BasicValidationReport(), 60);
            //Logger.WriteDebugMessage("Landed on Testing Tab.");
            //CreateCampaign.CreateCampaign_Button_SaveandContinue();
            //ElementWait(Driver.FindElement(By.XPath("//*[@id='SendToTestEmails" + projectID + "']")), 60);
            //Logger.WriteDebugMessage("Landed on Approval Tab.");
            //CreateCampaign.Click_Button_SendforApproval();
            //CreateCampaign.CampaignApprove(Convert.ToInt32(projectID));

            //CreateCampaign.CreateCampaign_Button_Continue();
            //ElementWait(PageObject_CreateCampaign.CreateCampaign_Link_ScheduleTab(), 60);
            //Logger.WriteDebugMessage("Landed on Schedule Page");
            //CreateCampaign.SelectTime();
            //((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollBy(0,-500)", "");
            //((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollBy(0,-500)", "");
            //CreateCampaign.CampaignScheduleandComplete("Schedule");
            //Logger.WriteDebugMessage("Campaign has scheduled.");
            //AddDelay(600000);
        }
        public static void TC_284072()
        {
            //change to the Hotel Origami
            Profile.SelectSubClient(clientName);
            string projectID = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "ProjectID");
            Users pData = new Users();

            SqlWarehouseQuery.UpdateProjectStatus(Convert.ToInt32(projectID), "NewEmailCampaign");
            Logger.WriteInfoMessage("Change campaign status to Draft.");

            Navigation.MenuNavigation("ManageCampaign");
            Logger.WriteDebugMessage("Navigated to Manage Campaign for ProjectID - " + projectID);

            SqlWarehouseQuery.GetPersonalizedTagValue(pData, CompanyName, 0, "", projectID, "");
            Logger.WriteInfoMessage("Found CustomerID - " + pData.CustomerIDs + " and Reservation Number - " + pData.ReservationNumber);
            SqlWarehouseQuery.GetPersonalizedTagValue(pData, CompanyName, 1, "", projectID, pData.CustomerIDs);
            AddDelay(25000);
            ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign);
            ManageCampaign.ManageCampaign_EllipseButton("Details");
            ManageCampaign.CampaignDetails_TabActions("Audience", projectID, "CustomerDetails");
            ManageCampaign.SearchCustomer("Reservation", pData.ReservationNumber);
            /* Preview */
            Logger.WriteInfoMessage("Started Preview");
            ManageCampaign.CustomerDetailEllipse_PreviewQuickSend("Preview");
            ManageCampaign.VerifyPersonalizeData(pData, 3, CompanyName, pData.CustomerIDs, "Preview", Int32.Parse(projectID), "Close");
            Logger.WriteInfoMessage("View in Browser is only available in QuickSend and Scheduling. Switching to Quick Send");

            /* Nagivate Back to inital frame*/
            Driver.SwitchTo().ParentFrame();
            Driver.SwitchTo().Frame(Driver.FindElement(By.XPath(iFrameManageCampaign)));

            /* Quick Send */

            Logger.WriteInfoMessage("Started Quick Send");

            //42164904-1 | 1/1/2020 - 1/3/2020
            DateTime Date = DateTime.Parse(pData.ArrivalDate);
            string arrivalDate = Date.ToString("M/d/yyyy");
            Date = DateTime.Parse(pData.DepartureDate);
            string depatureDate = Date.ToString("M/d/yyyy");
            string resxPath = pData.ReservationNumber + " | " + arrivalDate + " - " + depatureDate;
            ManageCampaign.CustomerDetailEllipse_PreviewQuickSend("QuickSend");
            ManageCampaign.Customer_Send_QuickSend(pData.CustomerIDs, pData.ReservationNumber, resxPath);
            //ManageCampaign.CASL_QuickSendVerification(pData.CustomerIDs, 1, pData.Email,pData.ReservationNumber, resxPath);
            OpenNewTab();
            ControlToNewWindow();
            Login.AutoAcc_login(projectID, 2, 0, LegacyTestData.CommonCatchallURL, 0);
            ManageCampaign.VerifyPersonalizeData(pData, 3, CompanyName, pData.CustomerIDs, "Schedule", Int32.Parse(projectID));
            ManageCampaign.ViewinBrowser(Int32.Parse(projectID));
            ControlToNewWindow();
            ManageCampaign.VerifyPersonalizeData(pData, 3, CompanyName, pData.CustomerIDs, "Schedule", Int32.Parse(projectID));
            CloseCurrentTab();
            ControlToNewWindow();
            Hotmail.OutlookSignOut();
            CloseCurrentTab();
            ControlToPreviousWindow();
            /* Scheduling */
            Logger.WriteInfoMessage("\nContinuing by Scheduling Campaign\n");
            Navigation.MenuNavigation("ManageCampaign");
            AddDelay(25000);
            Driver.SwitchTo().ParentFrame();
            ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign);
            //ManageCampaign.PreSearchCampaign(1, Int32.Parse(projectID), CompanyName, clientName);
            ManageCampaign.ManageCampaign_EllipseButton("Edit");
            AddDelay(25000);
            CreateCampaign.CreateCampaign_Button_SaveandContinue();
            AddDelay(25000);
            ElementWait(PageObject_ManageCampaign.Button_Campaign_BasicValidationReport(), 180);
            Logger.WriteDebugMessage("Landed on Testing Tab.");
            CreateCampaign.CreateCampaign_Button_SaveandContinue();
            ElementWait(Driver.FindElement(By.XPath("//*[@id='SendToTestEmails" + projectID + "']")), 60);
            Logger.WriteDebugMessage("Landed on Approval Tab.");
            CreateCampaign.Click_Button_SendforApproval();
            CreateCampaign.CampaignApprove(Int32.Parse(projectID));
            CreateCampaign.CreateCampaign_Button_Continue();
            ElementWait(PageObject_CreateCampaign.CreateCampaign_Link_ScheduleTab(), 60);
            Logger.WriteDebugMessage("Landed on Schedule Page");
            DateTime myDateTime = DateTime.Now;
            string scheduleTime = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            CreateCampaign.SelectTime();
            CreateCampaign.CampaignScheduleandComplete("Schedule");
            AddDelay(450000);

            /*Query to Check if Email was sent*/

            string checkifEmailSent = SqlWarehouseQuery.CheckDeliveredCampaign(CompanyName, pData.Email);

            if (checkifEmailSent == "Email sent")
            {
                Logger.WriteInfoMessage("Email delivered for " + pData.Email);
            }
            else
            {
                Assert.Fail("Email was not delivered for " + pData.Email);
            }

            /*End of Query to Check if Email was sent*/

            /* Continue to Resend */
            CampaignDetails data = new CampaignDetails();
            SqlWarehouseQuery.GetCampaignDetails(data, CompanyName, projectID);
            Navigation.MenuNavigation("Profile");
            Profile.SelectSubClient(CompanyName);
            Logger.WriteInfoMessage("Fetched data" + data.CampaignName + ",\n " + pData.CustomerIDs + ",\n " + pData.Email + ",\n " + pData.ReservationNumber);
            PageLoadWait(120, "Profile.mvc/Profile");
            ElementWait(PageObject_Profile.Profile_SearchGuestsSearch(), 120);
            Profile.SelectSearchGuestsSearchBy("Reservation #");
            Profile.InsertTextSearchGuestsSearchFor(pData.ReservationNumber);
            Logger.WriteDebugMessage("Searching for an customer for a reservation number : " + pData.ReservationNumber + " on profile search page.");
            
            ElementWait(PageObject_Profile.Profile_Grid_ReservationNumber(pData.ReservationNumber), 120);

            Profile.OpenandSendResend(pData.ReservationNumber, data.CampaignName, "", "Profile", pData.ParentProjectID);
            AddDelay(15000);
            if (data.CampaignSubject.Contains("#EMAIL#"))
            {
                data.CampaignSubject = data.CampaignSubject.Replace("#EMAIL#, ", "");
            }
            OpenNewTab();
            ControlToNewWindow();
            Login.AutoAcc_login(data.CampaignSubject, 2, 0, LegacyTestData.CommonCatchallURL, 1);

            ManageCampaign.VerifyPersonalizeData(pData, 3, CompanyName, pData.CustomerIDs, "Schedule", Int32.Parse(projectID));
            ManageCampaign.ViewinBrowser(Int32.Parse(projectID));
            ControlToNewWindow();
            ManageCampaign.VerifyPersonalizeData(pData, 3, CompanyName, pData.CustomerIDs, "Schedule", Int32.Parse(projectID));
        }

    }
}
