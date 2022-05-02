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

namespace eInsight.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        #region[TP_124907]
        public static void TC_102002()
        {
            string projectIDs = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "projectIDs");
            //ElementWait(Driver.FindElement(By.XPath("//*[@id='MarketingCampaignsReport']/img")), 60);
            string[] getprojectIds = Regex.Split(projectIDs, ",");
            foreach (string pIDs in getprojectIds)
            {
                int projectID = Int32.Parse(pIDs);
                Logger.WriteInfoMessage("Executing for ProjectID: " + projectID + ". And updating Campaign status to Draft.");
                SqlWarehouseQuery.UpdateProjectStatus(projectID);

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
                    ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", pIDs, iFrameManageCampaign);
                    //ManageCampaign.SearchCampaign(custID, tagValues.ReservationNumber, 2, projectID, 1);
                    AddDelay(10000);
                    ManageCampaign.ManageCampaign_EllipseButton("Details");
                    ManageCampaign.CampaignDetails_TabActions("Audience", projectID.ToString(), "CustomerDetails");
                    ManageCampaign.SearchCustomer("Email", tagValues.Email);
                    ManageCampaign.CustomerDetailEllipse_PreviewQuickSend("Preview");
                    ManageCampaign.VerifyPersonalizeData(tagValues, 3, name.CompanyName, custID, "Preview", Int32.Parse(pIDs), "Close");
                    Logger.WriteInfoMessage("\nContinuing with Quick send\n");
                    Driver.SwitchTo().Frame(Driver.FindElement(By.XPath(iFrameManageCampaign)));
                    DateTime Date = DateTime.Parse(tagValues.ArrivalDate);
                    string arrivalDate = Date.ToString("M/d/yyyy");
                    Date = DateTime.Parse(tagValues.DepartureDate);
                    string depatureDate = Date.ToString("M/d/yyyy");
                    string resxPath = tagValues.ReservationNumber + " | " + arrivalDate + " - " + depatureDate;
                    ManageCampaign.CustomerDetailEllipse_PreviewQuickSend("QuickSend");
                    ManageCampaign.Customer_Send_QuickSend(custID, tagValues.ReservationNumber, resxPath);
                    
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
                ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollBy(0,-500)", "");
                ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollBy(0,-500)", "");
                ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", pIDs, iFrameManageCampaign);

                //CampaignDetails data = new CampaignDetails();
                //SqlWarehouseQuery.ReturnCampaignStatus(projectID, data);
                //ManageCampaign.PreSearchCampaign(1, projectID, data.CompanyName);

                ManageCampaign.ManageCampaign_EllipseButton("Edit");
                AddDelay(15000);
                CreateCampaign.CreateCampaign_Button_SaveandContinue();
                ElementWait(PageObject_ManageCampaign.Button_Campaign_BasicValidationReport(), 60);
                Logger.WriteDebugMessage("Landed on Testing Tab.");
                CreateCampaign.CreateCampaign_Button_SaveandContinue();
                ElementWait(Driver.FindElement(By.XPath("//*[@id='SendToTestEmails" + projectID + "']")), 60);
                Logger.WriteDebugMessage("Landed on Approval Tab.");
                CreateCampaign.Click_Button_SendforApproval();
                CreateCampaign.CampaignApprove(projectID);
                CreateCampaign.CreateCampaign_Button_Continue();
                ElementWait(PageObject_CreateCampaign.CreateCampaign_Link_ScheduleTab(), 60);
                Logger.WriteDebugMessage("Landed on Schedule Page");
                CreateCampaign.SelectTime();
                ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollBy(0,-500)", "");
                ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollBy(0,-500)", "");
                CreateCampaign.CampaignScheduleandComplete("Schedule");
                Logger.WriteDebugMessage("Campaign has scheduled.");
                AddDelay(600000);
                ManageCampaign.PreSearchCampaign_New(name.CompanyName, "ProjectID", pIDs, iFrameManageCampaign);
                ManageCampaign.ManageCampaign_EllipseButton("Details");
                ManageCampaign.CampaignDetails_PerformActonsItems("SaveAsResend");
               
                AddDelay(60000);
                //Resend Campaign
                ResendCampaignData stayData = new ResendCampaignData();

                SqlWarehouseQuery.GetReservationNumber(name.CompanyName, stayData, "SendCampaign", projectIDs);
                Driver.SwitchTo().ParentFrame();
                Navigation.MenuNavigation("Profile");
                PageLoadWait(120, "Profile.mvc/Profile");
                Profile.SelectSubClient(name.CompanyName);

                Logger.WriteInfoMessage("Fetched data" + stayData.CampaignName + ",\n " + stayData.CustomerID + ",\n " + stayData.EmailAddress + ",\n " + stayData.ReservationNumber);
                PageLoadWait(120, "Profile.mvc/Profile");
                ElementWait(Driver.FindElement(By.XPath("//input[@id='search']")), 120);
                ElementWait(PageObject_Profile.Profile_SearchGuestsSearch(), 120);
                Profile.SelectSearchGuestsSearchBy("Reservation #");
                Profile.InsertTextSearchGuestsSearchFor(stayData.ReservationNumber);
                Logger.WriteDebugMessage("Searching for an customer for a reservation number : " + stayData.ReservationNumber + " on profile search page.");
                ElementWait(Driver.FindElement(By.XPath("//a[contains(text(), '" + stayData.ReservationNumber + "')]")), 120);

                Profile.OpenandSendResend(stayData.ReservationNumber, stayData.CampaignName, "", "Profile", stayData.ParentProjectID);
                AddDelay(15000);
                OpenNewTab();
                ControlToNewWindow();
                Login.AutoAcc_login(stayData.EmailAddress, 2, 0, LegacyTestData.CommonCatchallURL, 0);

                if (VerifyTextOnPage(stayData.EmailAddress))
                {
                    Logger.WriteDebugMessage("Found EmailAddress " + stayData.EmailAddress + " in the body content of the email." );
                }
                else
                {
                    Assert.Fail("Could not locate EmailAddress " + stayData.EmailAddress + " in the body content of the email.");
                }
            }
        }
        public static void TC_73959()
        {
            ResendCampaignData campaigndata = new ResendCampaignData();
            SqlWarehouseQuery.GetCampaignName(campaigndata);

            if (String.IsNullOrEmpty(campaigndata.CampaignSubject))
            {
                Assert.Fail("No Campaign was scheduled within last three days.");
            }
            else
            {
                Login.AutoAcc_login(campaigndata.CampaignSubject, 1, 0, LegacyTestData.CommonCatchallURL, 0);
                ElementClick(Driver.FindElement(By.XPath("//a[contains(text(),'View this email with images.')]")));
            }
        }
        public static void TC_131671()
        {
            string projectID = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "ProjectID");
            CampaignDetails details = new CampaignDetails();
            SqlWarehouseQuery.GetCampaignDetailsforPreviewForecaster(details, "Forecaster", Convert.ToInt32(projectID), companyNameByTestCase);

            //Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL + "Project.mvc/Project/View?projectId=" + details.ParentProjectID);
            Navigation.MenuNavigation("ManageCampaign");
            
            AddDelay(20000);
            ManageCampaign.PreSearchCampaign_New(details.CompanyName, "ProjectID", details.ParentProjectID, iFrameManageCampaign);
            ManageCampaign.ManageCampaign_EllipseButton("Details");
            ManageCampaign.CampaignDetails_TestingAdvancedTab(details.ParentProjectID);
            ManageCampaign.Request_InboxPrevieworForcaster("Forecaster", details.CampaignSubject);

            ManageCampaign.LaunchPreviewForCaster("Forecaster", details.Subject);

            AddDelay(60000);
            Driver.SwitchTo().ParentFrame();
            ControlToNewWindow();
            if (Driver.Url.Contains("CreateSelectedInboxInformantReport"))
            {
                if (VerifyTextOnPage(details.ParentProjectID) && VerifyTextOnPage(details.Subject))
                {
                    Logger.WriteDebugMessage("Landed on Inbox Forecast Report. Found ProjectID - " + details.ParentProjectID + " and  Subject - " + details.Subject);
                }
                else
                {
                    Assert.Fail("Didn't found ProjectID - " + details.ParentProjectID + " and Subject - " + details.Subject);
                }
            }
            else
            {
                Assert.Fail("Waited to load the page for 2 minutes. However did not land on Inbox Forecast Report.");
            }

            /*
            ElementClick(Driver.FindElement(By.Id("advancedDeliverability" + details.ParentProjectID)));
            AddDelay(60000);
            ControlToNewWindow();
            if (Driver.Url.Contains("CreateSelectedInboxInformantReport"))
            {
                if (VerifyTextOnPage(details.ParentProjectID) && VerifyTextOnPage(details.Subject))
                {
                    Logger.WriteDebugMessage("Landed on Inbox Forecast Report. Found ProjectID - " + details.ParentProjectID + " and  Subject - " + details.Subject);
                }
                else
                {
                    Assert.Fail("Didn't found ProjectID - " + details.ParentProjectID + " and Subject - " + details.Subject);
                }
            }
            else
            {
                Assert.Fail("Waited to load the page for 2 minutes. However did not land on Inbox Forecast Report.");
            }
            */
        }
        public static void TC_124537()
        {
            string projectID = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "ProjectID");
            CampaignDetails details = new CampaignDetails();
            SqlWarehouseQuery.GetCampaignDetailsforPreviewForecaster(details, "Preview", Convert.ToInt32(projectID), companyNameByTestCase);

            //Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL + "Project.mvc/Project/View?projectId=" + details.ParentProjectID);
            Navigation.MenuNavigation("ManageCampaign");

            AddDelay(20000);
            ManageCampaign.PreSearchCampaign_New(details.CompanyName, "ProjectID", details.ParentProjectID, iFrameManageCampaign);
            ManageCampaign.ManageCampaign_EllipseButton("Details");
            ManageCampaign.CampaignDetails_TestingAdvancedTab(details.ParentProjectID);
            ManageCampaign.Request_InboxPrevieworForcaster("Preview", details.CampaignSubject);

            /*Start from here*/

            ManageCampaign.LaunchPreviewForCaster("Preview", details.Subject);

            AddDelay(60000);
            Driver.SwitchTo().ParentFrame();
            ControlToNewWindow();
            if (Driver.Url.Contains("CreateSelectedInboxPreviewReport"))
            {
                if (VerifyTextOnPage(details.ParentProjectID) && VerifyTextOnPage(details.Subject) && VerifyTextOnPage(details.CampaignName))
                {
                    Logger.WriteDebugMessage("Landed on Inbox Preview Report. Found ProjectID - " + details.ParentProjectID + " ,Subject - " + details.Subject + " and CampaignName - " + details.CampaignName);
                    ManageCampaign.PreviewReportCheck();
                }
                else
                {
                    Assert.Fail("Didn't found ProjectID - " + details.ParentProjectID + " and Subject - " + details.Subject);
                }
            }
            else
            {
                Assert.Fail("Waited to load the page for 2 minutes. However did not land on Inbox Forecast Report.");
            }
            /*
            Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL + "Project.mvc/Project/View?projectId=" + details.ParentProjectID);
            Logger.WriteDebugMessage("Navigated to Manage Campaign for ProjectID - " + details.ParentProjectID);
            Logger.WriteInfoMessage("Clicking on Request Inbox Preview.");
            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'RequestIP') and contains(@projectid, '" + details.ParentProjectID + "')]")));
            Logger.WriteDebugMessage("Landed on Confirming to request.");
            ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'Ok')]")));
            Logger.WriteInfoMessage("Holding short to generate Preview report for 5 minutes.");
            AddDelay(360000);
            ReloadPage();
            Logger.WriteInfoMessage("Page Reloaded. Clicking on Inbox Preview.");
            ElementClick(Driver.FindElement(By.Id("inboxPreview" + details.ParentProjectID)));
            AddDelay(60000);
            ControlToNewWindow();
            if (Driver.Url.Contains("CreateSelectedInboxPreviewReport"))
            {
                if (VerifyTextOnPage(details.ParentProjectID) && VerifyTextOnPage(details.Subject) && VerifyTextOnPage(details.CampaignName))
                {
                    Logger.WriteDebugMessage("Landed on Inbox Preview Report. Found ProjectID - " + details.ParentProjectID + " ,Subject - " + details.Subject + " and CampaignName - " + details.CampaignName);
                    ManageCampaign.PreviewReportCheck();
                }
                else
                {
                    Assert.Fail("Didn't found ProjectID - " + details.ParentProjectID + " and Subject - " + details.Subject);
                }
            }
            else
            {
                Assert.Fail("Waited to load the page for 2 minutes. However did not land on Inbox Forecast Report.");
            }
        }
        */
            #endregion[TP_124907]
        }
    }
}
