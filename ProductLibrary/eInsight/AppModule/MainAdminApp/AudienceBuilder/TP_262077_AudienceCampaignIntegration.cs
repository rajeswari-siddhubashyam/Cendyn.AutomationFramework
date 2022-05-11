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
        public static void Prerequisute_TP262077(AudienceBuilderData builderdata)
        {
            /*Pre-requisite*/
            string audienceName = SqlWarehouseQuery.ReturnCompanyName("NA", "AudienceName", "TP_240125") + TestPlanId;
            dynamicCriteriaJSON = SqlWarehouseQuery.ReturnDescriptionValue("NA", "AudienceName", "TP_240125");
            string email = LegacyTestData.CommonFrontendEmail;

            SqlWarehouseQuery.createAudience(CompanyName, builderdata, audienceName, dynamicCriteriaJSON, email);

            if (builderdata.AudienceDetailID == "1")
            {
                Logger.WriteInfoMessage("Audience Name " + audienceName + " already exist.");
            }
            else
            {
                Logger.WriteInfoMessage("Created a new Audience Name " + audienceName + " " + builderdata.AudienceDetailID);
            }

            //SqlWarehouseQuery.publishAudience(CompanyName, data, audienceName, email);
            //if (string.IsNullOrEmpty(data.AudiencePublishDetailID))
            //{
            //    Logger.WriteInfoMessage("Couldn't Publish Audience - " + audienceName);
            //    Assert.Fail("Unable to publish Audience " + audienceName);
            //}
            //else
            //{
            //    Logger.WriteInfoMessage("Published Audience " + audienceName + ". Pulished AudienceID is  " + data.AudiencePublishDetailID);
            //}
            /*End of Pre-requisite*/

            //SqlWarehouseQuery.GetAudiencePublishedName(CompanyName, "LastPublished", 1);
        }
        #region[TP_262077]
        public static void TC_262084()
        {
            AudienceBuilderData builderdata = new AudienceBuilderData();
            Prerequisite_TP242047(builderdata);
            Profile.SelectSubClient(clientName);
            Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL + "Project.mvc/Project/Create");
            Logger.WriteDebugMessage("Landed on Create Campaign - Property Selection Page");

            ElementClick(Driver.FindElement(By.XPath("//a[contains(text(), '"+ clientName +"')]")));
            
            if (IsElementPresent(By.XPath("//h2[contains(text(), 'Select Campaign Type')]")))
            {
                ElementClick(Driver.FindElement(By.XPath("//div[contains(@onclick, 'isSubProject=0') and contains(text(), 'Create')]")));
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
            ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'Audience Search')]")));
            Logger.WriteDebugMessage("Landed on Create Campaign - Audience Search Tab");
            //Driver.SwitchTo().Frame(3);
            IWebElement frameElement = Driver.FindElement(By.Name("Audience"));
            Logger.WriteInfoMessage("Switching into the iFrame." + frameElement);
            Driver.SwitchTo().Frame(frameElement);
            AddDelay(1000);
            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_SearchButton();
            ScrollToElement(Driver.FindElement(By.XPath("(//span[contains(text(), '" + audienceName + "')]//following::*[contains(text(), 'Details')])[1]")));
            HighlightElement(Driver.FindElement(By.XPath("//span[contains(text(), '" + audienceName + "')]")));
            Logger.WriteDebugMessage("Clicking on Details button for AudienceName - " + audienceName);
            ElementClick(Driver.FindElement(By.XPath("(//span[contains(text(), '" + audienceName + "')]//following::*[contains(text(), 'Details')])[1]")));
            Logger.WriteDebugMessage("Landed on Audience Details for AudienceName - " + audienceName);
            AddDelay(8000);
            //Driver.SwitchTo().DefaultContent();
            //Driver.SwitchTo().Frame(3);
            ElementWait(Driver.FindElement(By.XPath("//button[contains(text(), 'Edit')]")), 120);
            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Edit')]")));

            ElementWait(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")), 120);
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
            //Driver.SwitchTo().DefaultContent();
            //frameElement = Driver.FindElement(By.Name("Audience"));
            ElementWait(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")), 120);
            ScrollToElement(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")));
            HighlightElement(Driver.FindElement(By.XPath("//button[@id='btnSearch']//following::*[contains(text(), '" + audienceName + "')]")));
            if (IsElementVisible(Driver.FindElement(By.XPath("//button[@id='btnSearch']//following::*[contains(text(), '" + audienceName + "')]"))))
            {
                Logger.WriteDebugMessage("Audience - " + audienceName + " is available on Criteria Page and is on the Top of the Audience Builder Search Grid.");
            }
            else
            {
                Assert.Fail("Audience - " + audienceName + " is not available on Criteria Page and is not on the Top of the Audience Builder Searcg Grid."); ;
            }
        }
        #endregion[TP_262077]

    }
}
