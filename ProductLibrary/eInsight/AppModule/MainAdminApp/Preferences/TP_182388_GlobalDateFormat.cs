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

namespace eInsight.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        #region[TP_182388]
        public static void TC_180170()
        {
            Profile.SelectSubClient(CompanyName);
            Logger.WriteDebugMessage("Selected Company " + CompanyName);

            UserPreference prefdata = new UserPreference();
            SqlWarehouseQuery.GetUserPreference(prefdata, LegacyTestData.CommonFrontendEmail);

            if (String.IsNullOrEmpty(prefdata.user_id))
            {
                UserActions.Click_Button_UserrAction();
                Logger.WriteDebugMessage("Clicked on User Actions.");

                UserActions.Click_Button_UserrAction_MyPreference();
                Logger.WriteDebugMessage("Clicked on My Preferences");

                UserActions.GetSelectedElementValue();

                UserActions.Click_Button_UserrAction_SavePreference();

                AddDelay(8000);

                Logger.WriteInfoMessage("Able to save same preference.");
            }
            else
            {
                Logger.WriteDebugMessage("Saved user region preferences exist in this was as this feature was used previously by this user.");
            }
        }
        public static void TC_180171()
        {
            Profile.SelectSubClient(CompanyName);
            Logger.WriteDebugMessage("Selected Company " + CompanyName);


            Preferences.ValidateDateFormat(CompanyName, clientName);
        }
        public static void TC_180173()
        {
            Profile.SelectSubClient(CompanyName);
            Logger.WriteDebugMessage("Selected Company " + CompanyName);

            UserPreference prefdata = new UserPreference();
            SqlWarehouseQuery.GetUserPreference(prefdata, LegacyTestData.CommonFrontendEmail);

            if (String.IsNullOrEmpty(prefdata.user_id))
            {
                Assert.Fail("User preference was not saved from previous changed preference.");
            }
            else
            {
                Logger.WriteDebugMessage("Saved user region preferences exist in this was as this feature was used previously by this user.");

                UserActions.Click_Button_UserrAction();
                Logger.WriteDebugMessage("Clicked on User Actions.");

                UserActions.Click_Button_UserrAction_MyPreference();
                Logger.WriteDebugMessage("Clicked on My Preferences");

                UserActions.SelectRegion("India (English)");
                Logger.WriteDebugMessage("Preference Saved as - India (English)");

                UserActions.Click_Button_UserrAction_SavePreference();
                AddDelay(15000);
                var longdate = DateTime.Now.ToString("dd-MM-yyyy");
                if (VerifyTextOnPage(longdate))
                {
                    Logger.WriteDebugMessage(longdate + " exist on the page.");
                }
                else
                {
                    Assert.Fail("Did not find " + longdate + " on the page.");
                }
            }
        }
        public static void TC_253876()
        {
            Profile.SelectSubClient(CompanyName);
            regionSelection = SqlWarehouseQuery.ReturnCompanyName("NA", "regionSelection", TestPlanId);
            string[] eachRegion2 = Regex.Split(regionSelection, ",");
            foreach (string region in eachRegion2)
            {
                UserActions.SelectPreferredRegion(region);

                string activityTabs = "All,Created,CriteriaChanged,TemplateChanged,SendToTestEmailsRequested,DeliverabilityReportRequested,ProceedForApprovalRequested,ApprovalRequested,Approved,Disapproved,Scheduled,Rescheduled,CampaignScheduleDeactivated,SendHistory,Cancelled";
                string[] activityTab = Regex.Split(activityTabs, ",");
                foreach (string eachTab in activityTab)
                {
                    Preferences.ViewAllActivityDateCheck(region, CompanyName, eachTab);
                }
            }
        }
        public static void TC_253877()
        {
            Profile.SelectSubClient(CompanyName);
            regionSelection = SqlWarehouseQuery.ReturnCompanyName("NA", "regionSelection", TestPlanId);
            string[] eachRegion = Regex.Split(regionSelection, ",");
            foreach (string region in eachRegion)
            {
                Preferences.ProfileDateCheck(region, CompanyName);
            }
        }
        public static void TC_253878()
        {
            Navigation.MenuNavigation("ManageCampaign");
            regionSelection = SqlWarehouseQuery.ReturnCompanyName("NA", "regionSelection", TestPlanId);
            string[] eachRegion1 = Regex.Split(regionSelection, ",");
            foreach (string region in eachRegion1)
            {
                Preferences.ManageCampaignDateCheck(region, CompanyName);
            }
        }
        public static void TC_276644()
        {
            AudienceBuilderData audData = new AudienceBuilderData();
            SqlWarehouseQuery.GetAudienceDetails(audData, companyNameByTestCase, "LastPublished", 1, 0);
            //SqlWarehouseQuery.GetAudienceDetails(audData, companyNameByTestCase, "LastSaved", 1, 1, audData.AudienceName);
            string audienceName = audData.AudienceName;
            Profile.SelectSubClient(companyNameByTestCase);
            regionSelection = SqlWarehouseQuery.ReturnCompanyName("NA", "regionSelection", TestPlanId);
            string[] eachRegion2 = Regex.Split(regionSelection, ",");
            foreach (string region in eachRegion2)
            {
                UserActions.SelectPreferredRegion(region);

                Navigation.MenuNavigation("AudienceBuilder");

                ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
                AudienceBuilder.Click_SearchButton();
                AudienceBuilder.Click_ABGrid_LastPublished();

                if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]"))))
                {
                    #region[AudienceSearchGrid]
                    Logger.WriteInfoMessage("Searching on Audience Builder Home page.");
                    Logger.WriteDebugMessage("Found Audience Name: "+ audienceName);
                    ElementClick(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '"+ audienceName + "')]")));
                    Logger.WriteInfoMessage("Checking for Created on Date on the page.");
                    SqlWarehouseQuery.GetAudienceDetails(audData, companyNameByTestCase, "LastPublished", 1, 1, audienceName);
                    Preferences.VerifyDatePreferenceOnAudienceSearchGrid(region, audData.InsertedOn);
                    Logger.WriteInfoMessage("Checking for Modified on Date on the page.");
                    Preferences.VerifyDatePreferenceOnAudienceSearchGrid(region, audData.UpdatedOn);
                    #endregion[AudienceSearchGrid]
                    #region[AudienceDetail]
                    Logger.WriteInfoMessage("Landing on Audience Builder Detail page for " + audienceName);
                    ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
                    AddDelay(20000);

                    Driver.SwitchTo().DefaultContent();
                    Driver.SwitchTo().Frame(0);
                    
                    Logger.WriteInfoMessage("Checking for Created on Date on the page.");
                    Preferences.VerifyDatePreferenceOnAudienceSearchGrid(region, audData.InsertedOn);
                    Logger.WriteInfoMessage("Checking for Updated on Date on the page.");
                    Preferences.VerifyDatePreferenceOnAudienceSearchGrid(region, audData.UpdatedOn);
                    #endregion[AudienceDetail]
                    #region[AudienceHistory]
                    SqlWarehouseQuery.AudienceHistoryLog(audData, companyNameByTestCase, audienceName);
                    ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")));
                    if (Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")).GetAttribute("class").Contains("active"))
                    {
                        Logger.WriteDebugMessage("Landed on History Page.");
                        AddDelay(15000);
                        Preferences.VerifyDatePreferenceOnAudienceSearchGrid(region, audData.AudienceUpdatedOn);
                    }
                    else
                    {
                        Assert.Fail("Did not land on Audience History Page.");
                    }
                    #endregion[AudienceHistory]
                }
                else
                {
                    Assert.Fail("Audience Name was not found.");
                }
                Driver.SwitchTo().ParentFrame();
            }
        }
        public static void TC_275950()
        {
            string projectID = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "ProjectID"); ;
            CampaignDetails data = new CampaignDetails();
            regionSelection = SqlWarehouseQuery.ReturnCompanyName("NA", "regionSelection", TestPlanId);
            string[] eachRegion2 = Regex.Split(regionSelection, ",");
            foreach (string region in eachRegion2)
            {
                UserActions.SelectPreferredRegion(region);

                Navigation.MenuNavigation("ManageCampaign");
                AddDelay(20000);
                
                ManageCampaign.PreSearchCampaign_New(companyNameByTestCase, "ProjectID", projectID, iFrameManageCampaign);
                ManageCampaign.ManageCampaign_EllipseButton("Details");
                ManageCampaign.CampaignDetails_TabActions("History", projectID);
                
                Preferences.VerifyDatePreference_ManageCampaign_History(region, projectID, CompanyName);
            }
        }
        public static void TC_276675()
        {
            string projectID = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "ProjectID");
            regionSelection = SqlWarehouseQuery.ReturnCompanyName("NA", "regionSelection", TestPlanId);
            string[] eachRegion2 = Regex.Split(regionSelection, ",");
            foreach (string region in eachRegion2)
            {
                UserActions.SelectPreferredRegion(region);

                Navigation.MenuNavigation("ManageCampaign");
                AddDelay(20000);
                
                ManageCampaign.PreSearchCampaign_New(companyNameByTestCase, "ProjectID", projectID, iFrameManageCampaign);
                ManageCampaign.ManageCampaign_EllipseButton("Details");
                ManageCampaign.CampaignDetails_TestingAdvancedTab(projectID);
                if (VerifyTextOnPage("Inbox Preview"))
                {
                    CampaignDetails data = new CampaignDetails();
                    Logger.WriteInfoMessage("Checking date format for Inbox Preview.");
                    SqlWarehouseQuery.GetCampaignDetailsforPreviewForecaster(data, "Preview", Convert.ToInt32(projectID), companyNameByTestCase);
                    Preferences.VerifyDatePreferenceOnManageCampaign(region, data.RequestDate);
                    Logger.WriteInfoMessage("Checking date format for Inbox ForeCaster.");
                    SqlWarehouseQuery.GetCampaignDetailsforPreviewForecaster(data, "Forecaster", Convert.ToInt32(projectID), companyNameByTestCase);
                    Preferences.VerifyDatePreferenceOnManageCampaign(region, data.RequestDate);
                }
                else
                {
                    Assert.Fail("Audience Name was not found.");
                }
                Driver.SwitchTo().ParentFrame();
                ReloadPage();
            }
        }
        public static void TC_276683()
        {
        }
        public static void TC_281936()
        {
            string status = "";
            string activeInactive = "";
            Profile.SelectSubClient(CompanyName);
            regionSelection = SqlWarehouseQuery.ReturnCompanyName("NA", "regionSelection", TestPlanId);
            string[] eachRegion2 = Regex.Split(regionSelection, ",");
            foreach (string region in eachRegion2)
            {
                UserActions.SelectPreferredRegion(region);

                Navigation.MenuNavigation("ManageCampaign");
                AddDelay(20000);
                string projectStatus = "Approved,Scheduled Active";//Scheduled Inactive
                string[] pStatus = Regex.Split(projectStatus, ",");
                foreach (string eachStatus in pStatus)
                {
                    CampaignDetails data = new CampaignDetails();
                    if (eachStatus == "Scheduled Active")
                    {
                        status = "Scheduled";
                        activeInactive = "1";
                    }
                    if (eachStatus == "Scheduled Inactive")
                    {
                        status = "Scheduled";
                        activeInactive = "0";
                    }
                    else if (eachStatus == "Approved")
                    {
                        status = eachStatus;
                        activeInactive = "0";
                    }

                    SqlWarehouseQuery.GetCampaignDetails_Report(data, companyNameByTestCase, status, 0, Convert.ToInt32(activeInactive));
                    ManageCampaign.PreSearchCampaign_New(companyNameByTestCase, "ProjectID", data.ParentProjectID, iFrameManageCampaign);
                    Preferences.VerifyDateForManageCampaignPerProjectStatus(eachStatus, region, data);

                    Driver.SwitchTo().ParentFrame();
                    ReloadPage();
                }
            }
        }
        public static void TC_284361()
        {
            TemplateEditor tempbuilder = new TemplateEditor();
            regionSelection = SqlWarehouseQuery.ReturnCompanyName("NA", "regionSelection", TestPlanId);
            string[] eachRegion2 = Regex.Split(regionSelection, ",");
            foreach (string region in eachRegion2)
            {
                UserActions.SelectPreferredRegion(region);

                Navigation.MenuNavigation("TemplateBuilder");
                AddDelay(40000);
                Driver.SwitchTo().Frame(Driver.FindElement(By.XPath(iFrameTemplateBuilder)));
                SqlWarehouseQuery.GetTemplareDetails(tempbuilder);

                TemplateBuilder.Enter_TemplateName(tempbuilder.templateName);

                Preferences.VerifyDatePreference_TemplateBuilder(region, tempbuilder.UpdateDate);

                Driver.SwitchTo().ParentFrame();
            }
        }
        #endregion[TP_182388]

    }
}
