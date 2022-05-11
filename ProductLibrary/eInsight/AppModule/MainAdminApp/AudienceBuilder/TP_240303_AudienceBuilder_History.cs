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
        private static void AudiencePreReq_TP240303(AudienceBuilderData builderData)
        {

            /*Pre-requisite*/
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
        #region[TP_240303]
        public static void TC_240334()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            
            audienceName = SqlWarehouseQuery.ReturnCompanyName("TC_240334", "AudienceName");

            //Profile.SelectClient(CompanyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")));
            if (Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")).GetAttribute("class").Contains("active"))
            {
                AddDelay(20000);
                AudienceBuilder.SelectHistoryPageEntry("10");
                AudienceBuilder.SelectHistoryPageEntry("20");
                AudienceBuilder.SelectHistoryPageEntry("50");
                AudienceBuilder.SelectHistoryPageEntry("100");
                AudienceBuilder.SelectHistoryPageEntry("500");
            }
        }
        public static void TC_240335()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            
            audienceName = SqlWarehouseQuery.ReturnCompanyName("TC_240334", "AudienceName");

            //Profile.SelectClient(CompanyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")));
            if (Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")).GetAttribute("class").Contains("active"))
            {
                AddDelay(20000);

                ElementClick(Driver.FindElement(By.XPath("//*[@id='tableAudienceHistory_paginate']/ul/li[6]/a")));
                Logger.WriteDebugMessage("Clicked on Next Button");

                ElementClick(Driver.FindElement(By.XPath("//*[@id='tableAudienceHistory_paginate']/ul/li[7]/a")));
                Logger.WriteDebugMessage("Clicked on Last Button");

                ElementClick(Driver.FindElement(By.XPath("//*[@id='tableAudienceHistory_paginate']/ul/li[2]/a")));
                Logger.WriteDebugMessage("Clicked on Previous Button");

                ElementClick(Driver.FindElement(By.XPath("//*[@id='tableAudienceHistory_paginate']/ul/li[1]/a")));
                Logger.WriteDebugMessage("Clicked on First Button");
            }
        }
        public static void TC_240336()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            AudienceBuilderData historyData = new AudienceBuilderData();
            
            audienceName = SqlWarehouseQuery.ReturnCompanyName("TC_240336", "AudienceName");
            string audienceID = SqlWarehouseQuery.ReturnCompanyName("TC_240336", "AudienceID");
            SqlWarehouseQuery.UpdateAudience(CompanyName, audienceName, "0", "AudienceName", audienceID);


            string newAudience = audienceName + "1";
            //Profile.SelectClient(CompanyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");
            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteInfoMessage("Starting to Test - Update Audience Name and Save Audience.");
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.Id("btnActions")));
            Logger.WriteDebugMessage("Clicked on Actions Button");
            ElementClick(Driver.FindElement(By.Id("btnEdit")));
            Logger.WriteDebugMessage("Clicked on Edit Button");

            if (VerifyTextOnPage("Editing will override the last saved audience."))
            {
                ElementClick(Driver.FindElement(By.XPath("//*[@id='audienceEditConfirmModal']/div/div/div[3]/button[2]")));
            }

            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            AudienceBuilder.EditAudienceName(newAudience);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Save')]")));
            Logger.WriteDebugMessage("Clicked on Save button. And Landed on Confirm Save Prompt.");
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("(//button[contains(text(), 'Save')])[3]")));
            Logger.WriteDebugMessage("Confirmed to Save Audience Name.");

            ElementClick(Driver.FindElement(By.XPath("//*[@id='titleHeader']/div/a/i")));
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            AudienceBuilder.Click_ABGrid_LastSaved();
            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), newAudience);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched updated Audience:" + newAudience);
            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")));

            SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastSaved", 1, 1, newAudience);

            if (Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")).GetAttribute("class").Contains("active"))
            {
                SqlWarehouseQuery.AudienceHistoryLog(historyData, CompanyName, newAudience);
                var longdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy hh:mm:ss tt");
                var verifyDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy");
                if ((VerifyTextOnPage(historyData.ActivityType)) && (VerifyTextOnPage(builderData.UpdatedBy)) && (VerifyTextOnPage(verifyDate)))
                {
                    Logger.WriteInfoMessage("This log is regarding Updating Audience Name and Saving Audience.");
                    Logger.WriteDebugMessage("Found Activity Log for AudienceName - " + newAudience + "\n ActivityType:" + historyData.ActivityType + "\n Updated Audience Log:\n" + "User: " + builderData.UpdatedBy + "\n Updated DateTime:" + longdate_updateDate);
                }
                else
                {
                    Assert.Fail("Couldn't find Updated Audience Log:\n" + "User: " + builderData.UpdatedBy + "\n Updated DateTime:" + longdate_updateDate);
                }
            }
            Logger.WriteInfoMessage("Ended Test - Update Audience Name and Save Audience.");
            Logger.WriteInfoMessage("Staring to Test - Update Audience Name and Save and Publish Audience.");
            ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Back to Manage Audiences')]")));

            /*Save & Publish - Audience Name*/
            Driver.Navigate().Refresh();
            Driver.SwitchTo().Frame(0);
            ElementWait(Driver.FindElement(By.Id("selectField")), 120);
            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), newAudience);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + newAudience);
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.Id("btnActions")));
            Logger.WriteDebugMessage("Clicked on Actions Button");
            ElementClick(Driver.FindElement(By.Id("btnEdit")));
            Logger.WriteDebugMessage("Clicked on Edit Button");

            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            AudienceBuilder.EditAudienceName(audienceName);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Save & Publish')]")));
            Logger.WriteDebugMessage("Clicked on Save and Publish button.");
            ElementClick(Driver.FindElement(By.XPath("(//button[contains(text(), 'Publish')])[2]")));
            Logger.WriteDebugMessage("Clicked on Publish Button");

            ElementClick(Driver.FindElement(By.XPath("//*[@id='titleHeader']/div/a/i")));
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched updated Audience:" + audienceName);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            AddDelay(20000);
            if (VerifyTextOnPage("Audience counts are ready. Refresh the page?"))
            {
                ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Yes')]")));
            }

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")));

            SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastPublished", 1, 1, audienceName);

            if (Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")).GetAttribute("class").Contains("active"))
            {
                SqlWarehouseQuery.AudienceHistoryLog(historyData, CompanyName, audienceName);
                var longdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy hh:mm:ss tt");
                var verifyDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy");
                if ((VerifyTextOnPage(historyData.ActivityType)) && (VerifyTextOnPage(builderData.UpdatedBy)) && (VerifyTextOnPage(verifyDate)))
                {
                    Logger.WriteInfoMessage("This log is regarding Updating Audience Name and Save and Publish Audience.");
                    Logger.WriteDebugMessage("Found Activity Log for AudienceName - " + audienceName + "\n ActivityType:" + historyData.ActivityType + "Updated Audience Log:\n" + "User: " + builderData.UpdatedBy + "\n Updated DateTime:" + longdate_updateDate);
                    Logger.WriteDebugMessage("Found Activity Log for AudienceName - " + newAudience + "\n ActivityType Audience Name Updated: " + "\n Updated Audience Log:\n" + "User: " + builderData.UpdatedBy + "\n Updated DateTime:" + longdate_updateDate);
                }
                else
                {
                    Assert.Fail("Couldn't find Updated Audience Log:\n" + "User: " + builderData.UpdatedBy + "\n Updated DateTime:" + longdate_updateDate);
                }
            }
            ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Back to Manage Audiences')]")));

            /*Audience with no saving*/
            Logger.WriteInfoMessage("Ended Test - Update Audience Name and Save and Publish Audience.");
            Logger.WriteInfoMessage("Staring to Test - Update Audience Name and Cancel Audience Update.");
            Driver.Navigate().Refresh();
            Driver.SwitchTo().Frame(0);
            ElementWait(Driver.FindElement(By.Id("selectField")), 120);
            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.Id("btnActions")));
            Logger.WriteDebugMessage("Clicked on Actions Button");
            ElementClick(Driver.FindElement(By.Id("btnEdit")));
            Logger.WriteDebugMessage("Clicked on Edit Button");

            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            AudienceBuilder.EditAudienceName(newAudience);

            //ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Save & Publish')]")));
            //Logger.WriteDebugMessage("Clicked on Save and Publish button.");
            //ElementClick(Driver.FindElement(By.XPath("(//button[contains(text(), 'Publish')])[2]")));
            //Logger.WriteDebugMessage("Clicked on Publish Button");

            ElementClick(Driver.FindElement(By.XPath("//*[@id='titleHeader']/div/a/i")));
            Logger.WriteDebugMessage("Clicked on Closed button (Cancelling Audience Name change). Leaving Edit Audience Page.");
            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Leave Page')]")));
            Logger.WriteDebugMessage("Landed on Manage Audience.");
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")));

            SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastPublished", 1, 1, audienceName);

            if (Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")).GetAttribute("class").Contains("active"))
            {
                SqlWarehouseQuery.AudienceHistoryLog(historyData, CompanyName, audienceName);
                var longdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy hh:mm:ss tt");
                var verifyDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy");
                if ((VerifyTextOnPage(historyData.ActivityType)) && (VerifyTextOnPage(builderData.UpdatedBy)) && (VerifyTextOnPage(verifyDate)))
                {
                    Logger.WriteInfoMessage("This log is regarding Updating Audience Name and Cancel Audience.");
                    Logger.WriteDebugMessage("Found Activity Log for previous Activity for AudienceName " + audienceName + "\n ActivityType:" + historyData.ActivityType + "Updated Audience Log:\n" + "User: " + builderData.UpdatedBy + "\n Updated DateTime:" + longdate_updateDate);
                }
                else
                {
                    Assert.Fail("Couldn't find Updated Audience Log:\n" + "User: " + builderData.UpdatedBy + "\n Updated DateTime:" + longdate_updateDate);
                }
            }
            ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Back to Manage Audiences')]")));
            /*Edited Property List*/
            /*Edited Property List - Saved*/
            Logger.WriteInfoMessage("Ended Test - Update Audience Name and Cancel Audience Update");
            Logger.WriteInfoMessage("Staring to Test - Update PropertyList and Save Audience.");
            Driver.Navigate().Refresh();
            Driver.SwitchTo().Frame(0);
            newAudience = audienceName + "2";
            ElementWait(Driver.FindElement(By.Id("selectField")), 120);
            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), newAudience);
            AudienceBuilder.Click_SearchButton();
            AudienceBuilder.Click_ABGrid_LastSaved();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + newAudience);
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.Id("btnActions")));
            Logger.WriteDebugMessage("Clicked on Actions Button");
            ElementClick(Driver.FindElement(By.Id("btnEdit")));
            Logger.WriteDebugMessage("Clicked on Edit Button");

            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
            Driver.FindElement(By.XPath("(//input[@type='text'])[3]")).SendKeys(Keys.Enter);
            Logger.WriteDebugMessage("Added Property List.");

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Save')]")));
            Logger.WriteDebugMessage("Clicked on Save button.");
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("//*[@id='titleHeader']/div/a/i")));
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")));

            SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastSaved", 1, 1, newAudience);

            if (Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")).GetAttribute("class").Contains("active"))
            {
                AddDelay(20000);
                SqlWarehouseQuery.AudienceHistoryLog(historyData, CompanyName, newAudience);
                var longdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy hh:mm:ss tt");
                var verifyDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy");
                if ((VerifyTextOnPage(historyData.ActivityType)) && (VerifyTextOnPage(builderData.UpdatedBy)))// && (VerifyTextOnPage(verifyDate)))
                {
                    Logger.WriteInfoMessage("This log is regarding Update PropertyList and Save Audience.");
                    Logger.WriteDebugMessage("Found Activity Log for AudienceName - " + newAudience + "\n ActivityType:" + historyData.ActivityType + "Updated Audience Log:\n" + "User: " + builderData.UpdatedBy + "\n Updated DateTime:" + longdate_updateDate);
                }
                else
                {
                    Assert.Fail("Couldn't find Updated Audience Log:\n" + "User: " + builderData.UpdatedBy + "\n Updated DateTime:" + longdate_updateDate);
                }
            }
            ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Back to Manage Audiences')]")));

            /*Edited Property List - Save and Publish*/
            Logger.WriteInfoMessage("Ended Test - Update PropertyList and Save Audience.");
            Logger.WriteInfoMessage("Staring to Test - Update PropertyList and Save and Publish Audience.");
            Driver.Navigate().Refresh();
            Driver.SwitchTo().Frame(0);
            ElementWait(Driver.FindElement(By.Id("selectField")), 120);
            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), newAudience);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + newAudience);
            AddDelay(20000);

            AudienceBuilder.Click_ABGrid_LastSaved();

            ElementClick(Driver.FindElement(By.Id("btnActions")));
            Logger.WriteDebugMessage("Clicked on Actions Button");
            ElementClick(Driver.FindElement(By.Id("btnEdit")));
            Logger.WriteDebugMessage("Clicked on Edit Button");

            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
            Driver.FindElement(By.XPath("(//input[@type='text'])[3]")).SendKeys(Keys.Enter);
            Logger.WriteDebugMessage("Added Property List.");

            ElementWait(Driver.FindElement(By.XPath("//button[contains(text(), 'Save & Publish')]")), 120);
            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Save & Publish')]")));
            Logger.WriteDebugMessage("Clicked on Save and Publish button.");

            ElementClick(Driver.FindElement(By.XPath("(//button[contains(text(), 'Publish')])[2]")));
            Logger.WriteDebugMessage("Clicked on Publish Button");

            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("//*[@id='titleHeader']/div/a/i")));
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            AddDelay(20000);

            if (VerifyTextOnPage("Audience counts are ready. Refresh the page?"))
            {
                ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Yes')]")));
            }

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")));

            SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastPublished", 1, 1, newAudience);

            if (Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")).GetAttribute("class").Contains("active"))
            {
                AddDelay(20000);
                SqlWarehouseQuery.AudienceHistoryLog(historyData, CompanyName, newAudience);
                var longdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy hh:mm:ss tt");
                var verifyDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy");
                if ((VerifyTextOnPage(historyData.ActivityType)) && (VerifyTextOnPage(builderData.UpdatedBy)) && (VerifyTextOnPage(verifyDate)))
                {
                    Logger.WriteInfoMessage("This log is regarding Update PropertyList and Save and Publish Audience.");
                    Logger.WriteDebugMessage("Found Activity Log for AudienceName - " + newAudience + "\n ActivityType:" + historyData.ActivityType + "Updated Audience Log:\n" + "User: " + builderData.UpdatedBy + "\n Updated DateTime:" + longdate_updateDate);
                    Logger.WriteDebugMessage("Found Activity Log for AudienceName - " + newAudience + "\n ActivityType: Edited Property List" + "Updated Audience Log:\n" + "User: " + builderData.UpdatedBy + "\n Updated DateTime:" + longdate_updateDate);
                }
                else
                {
                    Assert.Fail("Couldn't find Updated Audience Log:\n" + "User: " + builderData.UpdatedBy + "\n Updated DateTime:" + longdate_updateDate);
                }
            }
            ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Back to Manage Audiences')]")));
            /*Edited Property List - No Save*/
            Logger.WriteInfoMessage("Ended Test - Update PropertyList and Save and Publish Audience.");
            Logger.WriteInfoMessage("Staring to Test - Update PropertyList and Cancel Update Audience.");
            Driver.Navigate().Refresh();
            AddDelay(20000);
            Driver.SwitchTo().Frame(0);
            ElementWait(Driver.FindElement(By.Id("selectField")), 120);
            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), newAudience);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + newAudience);
            AddDelay(20000);

            AudienceBuilder.Click_ABGrid_LastSaved();

            ElementClick(Driver.FindElement(By.Id("btnActions")));
            Logger.WriteDebugMessage("Clicked on Actions Button");
            ElementClick(Driver.FindElement(By.Id("btnEdit")));
            Logger.WriteDebugMessage("Clicked on Edit Button");

            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
            Driver.FindElement(By.XPath("(//input[@type='text'])[3]")).SendKeys(Keys.Enter);
            Logger.WriteDebugMessage("Added Property List.");

            //ElementWait(Driver.FindElement(By.XPath("//button[contains(text(), 'Save & Publish')]")), 120);
            //ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Save & Publish')]")));
            //Logger.WriteDebugMessage("Clicked on Save and Publish button.");

            //ElementClick(Driver.FindElement(By.XPath("(//button[contains(text(), 'Publish')])[2]")));
            //Logger.WriteDebugMessage("Clicked on Publish Button");

            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("//*[@id='titleHeader']/div/a/i")));
            Logger.WriteDebugMessage("Clicked on Closed button (Cancelling Audience Name change). Leaving Edit Audience Page.");
            if(VerifyTextOnPage("If you close your Audience now"))
            {
                ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Leave Page')]")));
            }
            //ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Leave Page')]")));
            Logger.WriteDebugMessage("Landed on Manage Audience.");
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")));

            SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastPublished", 1, 1, newAudience);

            if (Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")).GetAttribute("class").Contains("active"))
            {
                AddDelay(20000);
                SqlWarehouseQuery.AudienceHistoryLog(historyData, CompanyName, newAudience);
                var longdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy hh:mm:ss tt");
                var verifyDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy");
                if ((VerifyTextOnPage(historyData.ActivityType)) && (VerifyTextOnPage(builderData.UpdatedBy)) && (VerifyTextOnPage(verifyDate)))
                {
                    Logger.WriteInfoMessage("This log is regarding Update PropertyList and Cancel Update Audience.");
                    Logger.WriteDebugMessage("Found previous Activity for AudienceName -" + newAudience + "\n ActivityType:" + historyData.ActivityType + "Updated Audience Log:\n" + "User: " + builderData.UpdatedBy + "\n Updated DateTime:" + longdate_updateDate);
                }
                else
                {
                    Assert.Fail("Couldn't find Updated Audience Log:\n" + "User: " + builderData.UpdatedBy + "\n Updated DateTime:" + longdate_updateDate);
                }
            }
            ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Back to Manage Audiences')]")));

            /*Edited Tags List*/
            /*Edited Tags List - Saved*/
            /*
            Driver.Navigate().Refresh();
            Driver.SwitchTo().Frame(0);
            newAudience = audienceName + "3";
            ElementWait(Driver.FindElement(By.Id("selectField")), 120);
            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), newAudience);
            AudienceBuilder.Click_SearchButton();
            AudienceBuilder.Click_ABGrid_LastSaved();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + newAudience);
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.Id("btnActions")));
            Logger.WriteDebugMessage("Clicked on Actions Button");
            ElementClick(Driver.FindElement(By.Id("btnEdit")));
            Logger.WriteDebugMessage("Clicked on Edit Button");

            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[2]")));
            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[2]")));
            Driver.FindElement(By.XPath("(//input[@type='text'])[2]")).SendKeys(Keys.ArrowDown);
            Driver.FindElement(By.XPath("(//input[@type='text'])[2]")).SendKeys(Keys.Enter);
            Logger.WriteDebugMessage("Added Tags from List.");

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Save')]")));
            Logger.WriteDebugMessage("Clicked on Save button.");
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("//*[@id='titleHeader']/div/a/i")));
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")));

            SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastSaved", 1, 1, newAudience);

            if (Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")).GetAttribute("class").Contains("active"))
            {
                SqlWarehouseQuery.AudienceHistoryLog(historyData, CompanyName, newAudience);
                var longdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy h:mm:ss tt");
                if ((VerifyTextOnPage(historyData.ActivityType)) && (VerifyTextOnPage(builderData.UpdatedBy)) && (VerifyTextOnPage(longdate_updateDate)))
                {
                    Logger.WriteDebugMessage("Found ActivityType:" + historyData.ActivityType + "Updated Audience Log:\n" + "User: " + builderData.UpdatedBy + "\n Updated DateTime:" + longdate_updateDate);
                }
                else
                {
                    Assert.Fail("Couldn't find Updated Audience Log:\n" + "User: " + builderData.UpdatedBy + "\n Updated DateTime:" + longdate_updateDate);
                }
            }
            ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Back to Manage Audiences')]")));
            */

            /*Edited Tags List - Save and Publish*/
            /*
            Driver.Navigate().Refresh();
            Driver.SwitchTo().Frame(0);
            ElementWait(Driver.FindElement(By.Id("selectField")), 120);
            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), newAudience);
            AudienceBuilder.Click_SearchButton();
            AudienceBuilder.Click_ABGrid_LastSaved();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + newAudience);
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.Id("btnActions")));
            Logger.WriteDebugMessage("Clicked on Actions Button");
            ElementClick(Driver.FindElement(By.Id("btnEdit")));
            Logger.WriteDebugMessage("Clicked on Edit Button");

            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[2]")));
            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[2]")));
            Driver.FindElement(By.XPath("(//input[@type='text'])[2]")).SendKeys(Keys.ArrowDown);
            Driver.FindElement(By.XPath("(//input[@type='text'])[2]")).SendKeys(Keys.Enter);
            Logger.WriteDebugMessage("Added Tags from List.");

            ElementWait(Driver.FindElement(By.XPath("//button[contains(text(), 'Save & Publish')]")), 120);
            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Save & Publish')]")));
            Logger.WriteDebugMessage("Clicked on Save and Publish button.");

            ElementClick(Driver.FindElement(By.XPath("(//button[contains(text(), 'Publish')])[2]")));
            Logger.WriteDebugMessage("Clicked on Publish Button");

            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("//*[@id='titleHeader']/div/a/i")));
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")));

            SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastPublished", 1, 1, newAudience);

            if (Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")).GetAttribute("class").Contains("active"))
            {
                SqlWarehouseQuery.AudienceHistoryLog(historyData, CompanyName, newAudience);
                var longdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy h:mm:ss tt");
                if ((VerifyTextOnPage(historyData.ActivityType)) && (VerifyTextOnPage(builderData.UpdatedBy)) && (VerifyTextOnPage(longdate_updateDate)))
                {
                    Logger.WriteDebugMessage("Found ActivityType:" + historyData.ActivityType + "Updated Audience Log:\n" + "User: " + builderData.UpdatedBy + "\n Updated DateTime:" + longdate_updateDate);
                }
                else
                {
                    Assert.Fail("Couldn't find Updated Audience Log:\n" + "User: " + builderData.UpdatedBy + "\n Updated DateTime:" + longdate_updateDate);
                }
            }
            ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Back to Manage Audiences')]")));
            */

            /*Edited Property List - No Save*/
            /*
            Driver.Navigate().Refresh();
            Driver.SwitchTo().Frame(0);
            ElementWait(Driver.FindElement(By.Id("selectField")), 120);
            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), newAudience);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + newAudience);
            AddDelay(20000);

            AudienceBuilder.Click_ABGrid_LastSaved();

            ElementClick(Driver.FindElement(By.Id("btnActions")));
            Logger.WriteDebugMessage("Clicked on Actions Button");
            ElementClick(Driver.FindElement(By.Id("btnEdit")));
            Logger.WriteDebugMessage("Clicked on Edit Button");

            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[2]")));
            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[2]")));
            Driver.FindElement(By.XPath("(//input[@type='text'])[2]")).SendKeys(Keys.ArrowDown);
            Driver.FindElement(By.XPath("(//input[@type='text'])[2]")).SendKeys(Keys.Enter);
            Logger.WriteDebugMessage("Added Tags from List.");

            //ElementWait(Driver.FindElement(By.XPath("//button[contains(text(), 'Save & Publish')]")), 120);
            //ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Save & Publish')]")));
            //Logger.WriteDebugMessage("Clicked on Save and Publish button.");

            //ElementClick(Driver.FindElement(By.XPath("(//button[contains(text(), 'Publish')])[2]")));
            //Logger.WriteDebugMessage("Clicked on Publish Button");

            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("//*[@id='titleHeader']/div/a/i")));
            Logger.WriteDebugMessage("Clicked on Closed button (Cancelling Audience Name change). Leaving Edit Audience Page.");
            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Leave Page')]")));
            Logger.WriteDebugMessage("Landed on Manage Audience.");
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")));

            SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastPublished", 1, 1, newAudience);

            if (Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")).GetAttribute("class").Contains("active"))
            {
                SqlWarehouseQuery.AudienceHistoryLog(historyData, CompanyName, newAudience);
                var longdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy h:mm:ss tt");
                if ((VerifyTextOnPage(historyData.ActivityType)) && (VerifyTextOnPage(builderData.UpdatedBy)) && (VerifyTextOnPage(longdate_updateDate)))
                {
                    Logger.WriteDebugMessage("Found ActivityType:" + historyData.ActivityType + "Updated Audience Log:\n" + "User: " + builderData.UpdatedBy + "\n Updated DateTime:" + longdate_updateDate);
                }
                else
                {
                    Assert.Fail("Couldn't find Updated Audience Log:\n" + "User: " + builderData.UpdatedBy + "\n Updated DateTime:" + longdate_updateDate);
                }
            }
            ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Back to Manage Audiences')]")));
            */
            /*Edited Description List*/
            /*Edited Description List - Saved*/
            /*
            Driver.Navigate().Refresh();
            Driver.SwitchTo().Frame(0);
            newAudience = audienceName + "4";
            ElementWait(Driver.FindElement(By.Id("selectField")), 120);
            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), newAudience);
            AudienceBuilder.Click_SearchButton();
            AudienceBuilder.Click_ABGrid_LastSaved();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + newAudience);
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.Id("btnActions")));
            Logger.WriteDebugMessage("Clicked on Actions Button");
            ElementClick(Driver.FindElement(By.Id("btnEdit")));
            Logger.WriteDebugMessage("Clicked on Edit Button");

            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            ElementClick(Driver.FindElement(By.Id("helptext")));
            ElementEnterText(Driver.FindElement(By.Id("helptext")), "Test1");
            Logger.WriteDebugMessage("Added Description - " + "Test1");

            ElementWait(Driver.FindElement(By.XPath("//button[contains(text(), 'Save & Publish')]")), 120);
            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Save & Publish')]")));
            Logger.WriteDebugMessage("Clicked on Save and Publish button.");

            ElementClick(Driver.FindElement(By.XPath("(//button[contains(text(), 'Publish')])[2]")));
            Logger.WriteDebugMessage("Clicked on Publish Button");
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("//*[@id='titleHeader']/div/a/i")));
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")));

            SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastSaved", 1, 1, newAudience);

            if (Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")).GetAttribute("class").Contains("active"))
            {
                SqlWarehouseQuery.AudienceHistoryLog(historyData, CompanyName, newAudience);
                var longdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy h:mm:ss tt");
                if ((VerifyTextOnPage(historyData.ActivityType)) && (VerifyTextOnPage(builderData.UpdatedBy)) && (VerifyTextOnPage(longdate_updateDate)))
                {
                    Logger.WriteDebugMessage("Found ActivityType:" + historyData.ActivityType + "Updated Audience Log:\n" + "User: " + builderData.UpdatedBy + "\n Updated DateTime:" + longdate_updateDate);
                }
                else
                {
                    Assert.Fail("Couldn't find Updated Audience Log:\n" + "User: " + builderData.UpdatedBy + "\n Updated DateTime:" + longdate_updateDate);
                }
            }
            ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Back to Manage Audiences')]")));
            */
            /*Edited Tags List - Save and Publish*/
        }
        public static void TC_240337()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            
            audienceName = SqlWarehouseQuery.ReturnCompanyName("TC_240334", "AudienceName");

            //Profile.SelectClient(CompanyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.Id("btnActions")));
            Logger.WriteDebugMessage("Clicked on Actions Button");
            ElementClick(Driver.FindElement(By.Id("btnEdit")));
            Logger.WriteDebugMessage("Clicked on Edit Button");

            //if (IsElementVisible(Driver.FindElement(By.XPath("//button[contains(text(), 'Edit')]"))))
            //{
            //    Logger.WriteDebugMessage("Landed on Edit/Cancel Page to edit published audience. ");
            //    ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Edit')]")));
            //}

            AddDelay(20000);
            try { 
                ElementClick(Driver.FindElement(By.XPath("//*[@id='audienceEditConfirmModal']//button[contains(text(),'Edit')]")));
            }
            catch (Exception)
            {
                Logger.WriteInfoMessage("Edit Confirmation overlay is not displaying");
            }
            

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
            Driver.FindElement(By.XPath("(//input[@type='text'])[3]")).SendKeys(Keys.Enter);
            Logger.WriteDebugMessage("Added Property List.");

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Save')]")));
            Logger.WriteDebugMessage("Clicked on Save button.");
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("//*[@id='titleHeader']/div/a/i")));
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")));

            SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastSaved", 1, 1, audienceName);

            if (Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")).GetAttribute("class").Contains("active"))
            {
                var longdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy hh:mm:ss tt");
                var verifyDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy");
                if ((VerifyTextOnPage(builderData.UpdatedBy)) && (VerifyTextOnPage(verifyDate)))
                {
                    Logger.WriteDebugMessage("Found Updated Audience Log:\n" + "User: " + builderData.UpdatedBy + "\n Updated DateTime:" + longdate_updateDate);
                }
                else
                {
                    Assert.Fail("Couldn't find Updated Audience Log:\n" + "User: " + builderData.UpdatedBy + "\n Updated DateTime:" + longdate_updateDate);
                }
            }

            Driver.SwitchTo().DefaultContent();
            Login.AccLogout();
            LegacyTestData.CommonFrontendEmail = "jshah@cendyn.com";
            Login.ReLogin();
            Logger.WriteDebugMessage("Logged in as - " + LegacyTestData.CommonFrontendEmail);

            //Profile.SelectClient(CompanyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
            AddDelay(20000);
            AudienceBuilder.Click_ABGrid_LastSaved();
            ElementClick(Driver.FindElement(By.Id("btnActions")));
            Logger.WriteDebugMessage("Clicked on Actions Button");
            ElementClick(Driver.FindElement(By.Id("btnEdit")));
            Logger.WriteDebugMessage("Clicked on Edit Button");

            AddDelay(20000);
            try
            {
                ElementClick(Driver.FindElement(By.XPath("//*[@id='audienceEditConfirmModal']//button[contains(text(),'Edit')]")));
            }
            catch (Exception)
            {
                Logger.WriteInfoMessage("Edit Confirmation overlay is not displaying");
            }
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
            Driver.FindElement(By.XPath("(//input[@type='text'])[3]")).SendKeys(Keys.Enter);
            Logger.WriteDebugMessage("Added Property List.");

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Save')]")));
            Logger.WriteDebugMessage("Clicked on Save button.");
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("//*[@id='titleHeader']/div/a/i")));
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("(//button[contains(text(), 'Saved')])[1]")));
            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")));

            SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastSaved", 1, 1, audienceName);

            if (Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")).GetAttribute("class").Contains("active"))
            {
                var longdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy hh:mm:ss tt");
                var verifyDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy");
                if ((VerifyTextOnPage(builderData.UpdatedBy)) && (VerifyTextOnPage(verifyDate)))
                {
                    Logger.WriteDebugMessage("Found Updated Audience Log:\n" + "User: " + builderData.UpdatedBy + "\n Updated DateTime:" + longdate_updateDate);
                }
                else
                {
                    Assert.Fail("Couldn't find Updated Audience Log:\n" + "User: " + builderData.UpdatedBy + "\n Updated DateTime:" + longdate_updateDate);
                }
            }
        }
        public static void TC_240897()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            
            audienceName = SqlWarehouseQuery.ReturnCompanyName("TC_240334", "AudienceName");

            ////Profile.SelectClient(CompanyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")));
            if (Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")).GetAttribute("class").Contains("active"))
            {
                ElementClick(Driver.FindElement(By.XPath("//*[@id='tableAudienceHistory']/thead/tr/th[1]")));
                Logger.WriteDebugMessage("Sorted Activity Column in Ascending Order");

                ElementClick(Driver.FindElement(By.XPath("//*[@id='tableAudienceHistory']/thead/tr/th[1]")));
                Logger.WriteDebugMessage("Sorted Activity Column in Descending Order");

                ElementClick(Driver.FindElement(By.XPath("//*[@id='tableAudienceHistory']/thead/tr/th[2]")));
                Logger.WriteDebugMessage("Sorted User Column in Ascending Order");

                ElementClick(Driver.FindElement(By.XPath("//*[@id='tableAudienceHistory']/thead/tr/th[2]")));
                Logger.WriteDebugMessage("Sorted User Column in Descending Order");

                ElementClick(Driver.FindElement(By.XPath("//*[@id='tableAudienceHistory']/thead/tr/th[3]")));
                Logger.WriteDebugMessage("Sorted DateTime Column in Ascending Order");

                ElementClick(Driver.FindElement(By.XPath("//*[@id='tableAudienceHistory']/thead/tr/th[3]")));
                Logger.WriteDebugMessage("Sorted DateTime Column in Descending Order");
            }
        }
        #endregion[TP_240303]

    }
}
