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
        private static void Prerequisite_TP261792(AudienceBuilderData builderData)
        {
            /*Pre - requisite */
            audienceName = SqlWarehouseQuery.ReturnCompanyName("NA", "AudienceName", "TP_240125") + TestPlanId;
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

        #region[TP_261792]
        public static void TC_261082()
        {
            AudienceBuilderData builderdata = new AudienceBuilderData();
            Prerequisite_TP261792(builderdata);

            Profile.SelectSubClient(clientName);

            Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL + "Project.mvc/Project/Create");
            Logger.WriteDebugMessage("Landed on Create Campaign - Property Selection Page");

            ElementClick(Driver.FindElement(By.XPath("//a[contains(text(), '" + clientName + "')]")));
            if (IsElementPresent(By.XPath("//h2[contains(text(), 'Select Campaign Type')]")))
            {
                ElementClick(Driver.FindElement(By.XPath("//div[contains(@onclick, 'isSubProject=0')]")));
                ElementWait(Driver.FindElement(By.XPath("//span[contains(text(), 'Audience Search')]")), 60);
            }
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
                //Driver.SwitchTo().Frame(3);

                ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Campaign Settings')]")));
                ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'RESERVATION')]")));

                ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'Use first available selected email source')]")));
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


                ElementClick(Driver.FindElement(By.XPath("//label[@for = '" + builderdata.AudienceID + "']")));

                Driver.SwitchTo().ParentFrame();
                string subjectName = "Campaign - " + TestCaseId + "(do not touch)";
                ScrollDownUsingJavaScript(Driver, -1000);

                ElementEnterText(Driver.FindElement(By.Id("project_name")), subjectName);
                ElementClick(PageObject_CreateCampaign.CreateCampaign_CriteriaPage_Save());
                AddDelay(8000);
                string getURL = Driver.Url;
                var newProjectID = Regex.Match(getURL, "#(.*)&ProjectTitle").Groups[1].Value;
                newProjectID = newProjectID.Replace("ProjectId=", "");

                Logger.WriteDebugMessage("New Campaign " + subjectName + " is created with AudienceName " + audienceName + " wit ProjectID - " + newProjectID);

                string dynamicCriteriaJSON = SqlWarehouseQuery.ReturnDescriptionValue("NA", "AudienceName", "TP_240125");
                string appDBJSON = SqlWarehouseQuery.ReturnProjectJSONfromAPPDB(CompanyName, newProjectID);

                string message = "Audience Created with JSON model \n" + dynamicCriteriaJSON;
                message = message + " is same with json added for campaign \n" + appDBJSON;

                Logger.WriteDebugMessage(message);

                Logger.WriteInfoMessage("Deleting the Campaign - " + newProjectID);
                Navigation.MenuNavigation("ManageCampaign");

                //ControlToPreviousWindow();
                ManageCampaign.PreSearchCampaign_New(clientName, "ProjectID", newProjectID, iFrameManageCampaign);
                ManageCampaign.ManageCampaign_EllipseButton("Details");
                ScrollDownUsingJavaScript(Driver, -1000);
                ManageCampaign.CampaignDetails_PerformActonsItems("Delete");
                ((IJavaScriptExecutor)Driver).ExecuteScript("location.reload(true);");            
        }
        public static void TC_262287()
        {
            AudienceBuilderData builderdata = new AudienceBuilderData();
            Prerequisite_TP261792(builderdata);

            Profile.SelectSubClient(clientName);

            Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL + "Project.mvc/Project/Create");
            Logger.WriteDebugMessage("Landed on Create Campaign - Property Selection Page");

            ElementClick(Driver.FindElement(By.XPath("//a[contains(text(), '" + clientName + "')]")));
            if (IsElementPresent(By.XPath("//h2[contains(text(), 'Select Campaign Type')]")))
            {
                ElementClick(Driver.FindElement(By.XPath("//div[contains(@onclick, 'isSubProject=0')]")));
                ElementWait(Driver.FindElement(By.XPath("//span[contains(text(), 'Audience Search')]")), 60);
            }
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

                //Driver.SwitchTo().Frame(3);

                ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Campaign Settings')]")));
                ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'RESERVATION')]")));

                ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'Use first available selected email source')]")));
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

                Logger.WriteInfoMessage("Editing Audience.");
                Logger.WriteDebugMessage("Clicking on Details button for AudienceName - " + audienceName);
                ElementClick(Driver.FindElement(By.XPath("(//span[contains(text(), '" + audienceName + "')]//following::*[contains(text(), 'Details')])[1]")));
                Logger.WriteDebugMessage("Landed on Audience Details for AudienceName - " + audienceName);
                AddDelay(8000);
                //Driver.SwitchTo().DefaultContent();
                //Driver.SwitchTo().Frame(3);
                ElementWait(Driver.FindElement(By.XPath("//button[contains(text(), 'Edit')]")), 120);
                ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Edit')]")));

                ElementWait(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")), 120);
                ScrollDownUsingJavaScript(Driver, -300);
                ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
                Driver.FindElement(By.XPath("(//input[@type='text'])[3]")).SendKeys(Keys.Enter);
                Logger.WriteDebugMessage("Added Property List.");
                ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Save & Publish')]")));
                Logger.WriteDebugMessage("Clicked on Save and Publish button.");
                ElementClick(Driver.FindElement(By.XPath("(//button[contains(text(), 'Publish')])[2]")));
                Logger.WriteDebugMessage("Clicked on Publish Button");
                ElementClick(Driver.FindElement(By.XPath("//*[@id='titleHeader']/div/a/i")));
                Logger.WriteDebugMessage("Clicked on close 'X' icon for audience : " + audienceName + ". Landed on Audience Details Page.");

                ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Back to Manage Audiences')]")));
                Logger.WriteDebugMessage("Clicked on Back to Manage Audiences. Landed on Criteria Page.");


                ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
                AudienceBuilder.Click_SearchButton();

                ElementClick(Driver.FindElement(By.XPath("//label[@for = '" + builderdata.AudienceID + "']")));


                Driver.SwitchTo().ParentFrame();
                string subjectName = "Campaign - " + TestCaseId + "(do not touch)";
                ScrollDownUsingJavaScript(Driver, -1000);

                ElementEnterText(Driver.FindElement(By.Id("project_name")), subjectName);
                ElementClick(PageObject_CreateCampaign.CreateCampaign_CriteriaPage_Save());
                AddDelay(8000);

                string getURL = Driver.Url;
                var newProjectID = Regex.Match(getURL, "#(.*)&ProjectTitle").Groups[1].Value;
                newProjectID = newProjectID.Replace("ProjectId=", "");

                Logger.WriteDebugMessage("New Campaign " + subjectName + " is created with AudienceName " + audienceName + " wit ProjectID - " + newProjectID);

                string dynamicCriteriaJSON = SqlWarehouseQuery.ReturnDescriptionValue("NA", "AudienceName", "TP_240125");
                string appDBJSON = SqlWarehouseQuery.ReturnProjectJSONfromAPPDB(CompanyName, newProjectID);

                string message = "Audience Created with JSON model \n" + dynamicCriteriaJSON;
                message = message + " is same with json added for campaign \n" + appDBJSON;

                Logger.WriteDebugMessage(message);

                Logger.WriteInfoMessage("Deleting the Campaign - " + newProjectID);
                Navigation.MenuNavigation("ManageCampaign");

                //ControlToPreviousWindow();
                ManageCampaign.PreSearchCampaign_New(clientName, "ProjectID", newProjectID, iFrameManageCampaign);
                ManageCampaign.ManageCampaign_EllipseButton("Details");
                ScrollDownUsingJavaScript(Driver, -1000);
                ManageCampaign.CampaignDetails_PerformActonsItems("Delete");
                ((IJavaScriptExecutor)Driver).ExecuteScript("location.reload(true);");
        }
        public static void TC_262285()
        {
            AudienceBuilderData builderdata = new AudienceBuilderData();
            Prerequisite_TP242047(builderdata);

            Profile.SelectSubClient(clientName);

            Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL + "Project.mvc/Project/Create");
            Logger.WriteDebugMessage("Landed on Create Campaign - Property Selection Page");

            ElementClick(Driver.FindElement(By.XPath("//a[contains(text(), '" + clientName + "')]")));
            if (IsElementPresent(By.XPath("//h2[contains(text(), 'Select Campaign Type')]")))
            {
                ElementClick(Driver.FindElement(By.XPath("//div[contains(@onclick, 'isSubProject=0')]")));
                ElementWait(Driver.FindElement(By.XPath("//span[contains(text(), 'Audience Search')]")), 60);
            }
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
                ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'Audience Search')]")));
                Logger.WriteDebugMessage("Landed on Create Campaign - Audience Search Tab");
                //Driver.SwitchTo().Frame(3);

                ScrollDownUsingJavaScript(Driver, 300);

                IWebElement frameElement = Driver.FindElement(By.Name("Audience"));
                Logger.WriteInfoMessage("Switching into the iFrame." + frameElement);
                Driver.SwitchTo().Frame(frameElement);
                AddDelay(1000);

                ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
                AudienceBuilder.Click_SearchButton();

                ElementClick(Driver.FindElement(By.XPath("//label[@for = '" + builderdata.AudienceID + "']")));

                Driver.SwitchTo().ParentFrame();
                string subjectName = "Campaign - " + TestCaseId + "(do not touch)";
                ElementEnterText(Driver.FindElement(By.Id("project_name")), subjectName);
                ElementClick(PageObject_CreateCampaign.CreateCampaign_CriteriaPage_Save());
                AddDelay(8000);
                string getURL = Driver.Url;
                var newProjectID = Regex.Match(getURL, "#(.*)&ProjectTitle").Groups[1].Value;
                newProjectID = newProjectID.Replace("ProjectId=", "");

                Logger.WriteDebugMessage("New Campaign " + subjectName + " is created with AudienceName " + audienceName + " with ProjectID - " + newProjectID);

                string dynamicCriteriaJSON = SqlWarehouseQuery.ReturnDescriptionValue("NA", "AudienceName", "TP_240125");
                string appDBJSON = SqlWarehouseQuery.ReturnProjectJSONfromAPPDB(CompanyName, newProjectID);

                string message = "Audience Created with JSON model \n" + dynamicCriteriaJSON;
                message = message + " is same with json added for campaign \n" + appDBJSON;

                Logger.WriteDebugMessage(message);

                Logger.WriteInfoMessage("Updating campaign settings.");
                ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Campaign Settings')]")));
                ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'RESERVATION')]")));

                ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'Use first available selected email source')]")));
                ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'Include Unsubscribed')]")));
                ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'Include Bounced')]")));
                ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'Include Non-Consent')]")));

                ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'Audience Search')]")));

                Logger.WriteDebugMessage("Modified Campaign settings and saving the campaign.");
                ScrollDownUsingJavaScript(Driver, -300);
                ElementClick(PageObject_CreateCampaign.CreateCampaign_Button_Save());

                dynamicCriteriaJSON = SqlWarehouseQuery.ReturnDescriptionValue("NA", "AudienceName", "TP_240125");
                appDBJSON = SqlWarehouseQuery.ReturnProjectJSONfromAPPDB(CompanyName, newProjectID);
                Logger.WriteDebugMessage("New Campaign " + subjectName + " is created with AudienceName " + audienceName + " wit ProjectID - " + newProjectID + " with modified Campaign Settings");

                message = "Audience Created with JSON model \n" + dynamicCriteriaJSON;
                message = message + " is same with json added for campaign \n" + appDBJSON;

                Logger.WriteDebugMessage(message);

                Logger.WriteInfoMessage("Deleting the Campaign - " + newProjectID);
                Navigation.MenuNavigation("ManageCampaign");
                AddDelay(20000);
                //ControlToPreviousWindow();
                ManageCampaign.PreSearchCampaign_New(clientName, "ProjectID", newProjectID, iFrameManageCampaign);
                ManageCampaign.ManageCampaign_EllipseButton("Details");
                ScrollDownUsingJavaScript(Driver, -1000);
                ManageCampaign.CampaignDetails_PerformActonsItems("Delete");
                ((IJavaScriptExecutor)Driver).ExecuteScript("location.reload(true);");
            

        }
        #endregion[TP_261792]

    }
}
