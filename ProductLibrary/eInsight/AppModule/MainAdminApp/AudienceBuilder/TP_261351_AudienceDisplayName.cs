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
using System;
using System.Text.RegularExpressions;

namespace eInsight.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        
        
        #region[TP_261351]
        public static void TC_261391()
        {
            string audienceName = "";
            if (testCategory == "QA")
            {
                audienceName = "Test Customer Details";
            }
            else if (testCategory == "POC")
            {
                audienceName = "POC Audience";
            }
            
            projectID = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "ProjectID");

            Users pData = new Users();
            
            SqlWarehouseQuery.UpdateProjectStatus(Convert.ToInt32(projectID));
            Logger.WriteInfoMessage("Change campaign status to Draft.");

            Navigation.MenuNavigation("ManageCampaign");
            Logger.WriteDebugMessage("Navigating to Manage Campaign.");

            ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign);
            ManageCampaign.ManageCampaign_EllipseButton("Edit");
            AddDelay(10000);
            ElementWait(PageObject_CreateCampaign.CreateCampaign_Button_SaveandContinue(), 120);
            CreateCampaign.CreateCampaign_Button_SaveandContinue();
            ElementWait(PageObject_ManageCampaign.Button_Campaign_BasicValidationReport(), 60);
            Logger.WriteDebugMessage("Landed on Testing Tab.");
            CreateCampaign.CreateCampaign_Button_SaveandContinue();
            ElementWait(Driver.FindElement(By.XPath("//*[@id='SendToTestEmails" + projectID + "']")), 60);
            Logger.WriteDebugMessage("Landed on Approval Tab.");

            if (IsElementVisible(PageObject_CreateCampaign.CreateCampaign_AudienceName_ApprovalPage(audienceName)))
            {
                Logger.WriteDebugMessage("Found AudienceName - "+ audienceName + " exist on the Page.");
                ((IJavaScriptExecutor)Driver).ExecuteScript("scroll(0,-1000)");

                ElementClick(PageObject_CreateCampaign.CreateCampaign_AudienceName_ApprovalPage(audienceName));

                ControlToNewWindow();
                AddDelay(20000);
                Driver.SwitchTo().DefaultContent();
                Driver.SwitchTo().Frame(0);
                ElementWait(PageObject_AudienceBuilder.AB_Grid_EditAudience(), 60);
                if (VerifyTextOnPage("Audience Details for " + audienceName))
                {
                    Logger.WriteDebugMessage("Landed on Audience Details Page for audience - " + audienceName);
                }
                else
                {
                    Assert.Fail("AudienceName - " + audienceName + " did not found on the Audience Detail Page.");
                }

                CloseCurrentTab();
                ControlToPreviousWindow();

                CreateCampaign.Click_Button_SendforApproval();
                CreateCampaign.CampaignApprove(Int32.Parse(projectID));
                CreateCampaign.CreateCampaign_Button_Continue();
                ElementWait(PageObject_CreateCampaign.CreateCampaign_Link_ScheduleTab(), 60);
                Logger.WriteDebugMessage("Landed on Schedule Page");
                if (IsElementVisible(PageObject_CreateCampaign.CreateCampaign_AudienceName_SchedulePage(audienceName)))
                {
                    Logger.WriteDebugMessage("Found AudienceName - " + audienceName + " exist on the Page.");

                    ElementClick(PageObject_CreateCampaign.CreateCampaign_AudienceName_SchedulePage(audienceName));

                    ControlToNewWindow();
                    AddDelay(20000);
                    Driver.SwitchTo().DefaultContent();
                    Driver.SwitchTo().Frame(0);
                    ElementWait(PageObject_AudienceBuilder.AB_Grid_EditAudience(), 60);
                    if (VerifyTextOnPage("Audience Details for " +audienceName))
                    {
                        Logger.WriteDebugMessage("Landed on Audience Details Page for audience - " + audienceName);
                    }
                    else
                    {
                        Assert.Fail("AudienceName - " + audienceName + " did not found on the Audience Detail Page.");
                    }
                }
                else
                {
                    Assert.Fail("AudienceName - " + audienceName + " did not found on the Schedule Page.");
                }

            }
            else
            {
                Assert.Fail("AudienceName - " + audienceName +  " did not found on the Approval Page.");
            }
        }
        public static void TC_261396()
        {
            string audienceName = "";
            if (testCategory == "QA")
            {
                audienceName = "Test Customer Details";
            }
            else if (testCategory == "POC")
            {
                audienceName = "POC Audience";
            }

            projectID = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "ProjectID");

            Navigation.MenuNavigation("ManageCampaign");
            AddDelay(8000);
            Logger.WriteDebugMessage("Landed on Manage Campaign Page for Property: " + CompanyName);
            ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", projectID, iFrameManageCampaign);

            //Clone the Campaign
            ManageCampaign.ManageCampaign_EllipseButton("Clone");
            AddDelay(15000);
            ElementWait(PageObject_CreateCampaign.CreateCampaign_Button_SaveandContinue(), 60);
            string getURL = Driver.Url;
            var newProjectID = Regex.Match(getURL, "#(.*)&ProjectTitle").Groups[1].Value;
            newProjectID = newProjectID.Replace("ProjectId=", "");
            string subjectName = "ProjectId=" + newProjectID;
            DynamicScroll(Driver, PageObject_CreateCampaign.CreateCampaign_EditTemplate_Subject());
            ManageCampaign.EnterCampaignSubject(subjectName);
            DynamicScroll(Driver, PageObject_CreateCampaign.CreateCampaign_Button_Save());
            ElementClick(PageObject_CreateCampaign.CreateCampaign_Button_Save());
            Logger.WriteDebugMessage("Landed on Cloned Campaign - Edit Campaign. New ProjectID - " + newProjectID);
            ScrollDownUsingJavaScript(Driver, -1000);
            CreateCampaign.CreateCampaign_Button_SaveandContinue();
            ElementWait(PageObject_ManageCampaign.Button_Campaign_BasicValidationReport(), 60);
            Logger.WriteDebugMessage("Landed on Testing Tab.");
            CreateCampaign.CreateCampaign_Button_SaveandContinue();
            ElementWait(Driver.FindElement(By.XPath("//*[@id='SendToTestEmails" + newProjectID + "']")), 60);
            Logger.WriteDebugMessage("Landed on Approval Tab.");
            if (!(IsElementPresent(By.XPath("//dd[contains(text(), 'Audience')]"))))
            {
                Logger.WriteDebugMessage("AudienceName field does not exist on the Page for old campaign.");
                ((IJavaScriptExecutor)Driver).ExecuteScript("scroll(0,-1000)");

                CreateCampaign.Click_Button_SendforApproval();
                CreateCampaign.CampaignApprove(Int32.Parse(projectID));
                CreateCampaign.CreateCampaign_Button_Continue();
                ElementWait(PageObject_CreateCampaign.CreateCampaign_Link_ScheduleTab(), 60);
                Logger.WriteDebugMessage("Landed on Schedule Page");
                if (!(IsElementPresent(By.XPath("//*[contains(text(), '"+audienceName+"')]"))))
                {
                    Logger.WriteDebugMessage("AudienceName field does not exist on the Page for old campaign");
                }
                else
                {
                    Assert.Fail("AudienceName - " + audienceName + " did not found on the Schedule Page.");
                }

            }
            else
            {
                Assert.Fail("AudienceName - " + audienceName + " did not found on the Approval Page.");
            }
            
            Driver.SwitchTo().DefaultContent();
            Navigation.MenuNavigation("ManageCampaign");
            //AddDelay(8000);
            //Logger.WriteDebugMessage("Landed on Manage Campaign Page for Property: " + companyName);
            //ManageCampaign.PreSearchCampaign(1, Convert.ToInt32(projectID), companyName, clientName);

            //ControlToPreviousWindow();
            AddDelay(20000);
            ManageCampaign.PreSearchCampaign_New(CompanyName, "ProjectID", newProjectID, iFrameManageCampaign);
            ManageCampaign.ManageCampaign_EllipseButton("Details");
            ManageCampaign.CampaignDetails_PerformActonsItems("Delete");
            ((IJavaScriptExecutor)Driver).ExecuteScript("location.reload(true);");
        }
        #endregion[TP_261351]

    }
}
