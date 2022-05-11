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
        private static string longdate_createdDate = "";
        private static string longdate_updateDate = "";
        private static string shortdate_createdDate = "";
        private static string shortdate_updateDate = "";
        
        private static void Prerequisite_TP242047(AudienceBuilderData builderData)
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
            /*End of Pre-requisite*/
        }
        #region[TP_242047]
        public static void TC_240153()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            string CompanyName = SqlWarehouseQuery.ReturnCompanyName("NA", "CompanyName", "TP_250054");
            string clientName = SqlWarehouseQuery.ReturnCompanyName("NA", "clientName", "TP_250054");
            Prerequisite_TP242047(builderData);

            //Profile.SelectClient(companyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_SearchButton();
            AudienceBuilder.Click_ABGrid_LastSaved();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            Logger.WriteDebugMessage("Clicked on detail button for audience : " + audienceName);
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastSaved", 1, 1, audienceName);
            Logger.WriteInfoMessage(audienceName + " was last saved on " + builderData.UpdatedOn);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Edit')]")));
            Logger.WriteDebugMessage("Clicked on edit button for audience : " + audienceName);
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("//*[@id='titleHeader']/div/a/i")));
            Logger.WriteDebugMessage("Clicked on close 'X' icon for audience : " + audienceName);

            SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastSaved", 1, 1, audienceName);

            string longdate_createdDate = Convert.ToDateTime(builderData.InsertedOn).ToString("M/d/yyyy hh:mm:ss tt");
            string longdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy hh:mm:ss tt");
            string shortdate_createdDate = Convert.ToDateTime(builderData.InsertedOn).ToString("M/d/yyyy hh:mm tt");
            string shortdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy hh:mm tt");

            if (VerifyTextOnPage(shortdate_updateDate))
            {
                Logger.WriteInfoMessage("Last Date Time saved was " + shortdate_updateDate + " for Audience " + audienceName);
            }
            else
            {
                Assert.Fail(shortdate_updateDate + " could not be found on page.");
            }
        }
        public static void TC_240154()
        {
            var quotes = '"';

            AudienceBuilderData builderData = new AudienceBuilderData();
            string CompanyName = SqlWarehouseQuery.ReturnCompanyName("NA", "CompanyName", "TP_250054");
            string clientName = SqlWarehouseQuery.ReturnCompanyName("NA", "clientName", "TP_250054");
            Prerequisite_TP242047(builderData);

            //Profile.SelectClient(companyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_SearchButton();
            AudienceBuilder.Click_ABGrid_LastSaved();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            Logger.WriteDebugMessage("Clicked on detail button for audience : " + audienceName);
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Edit')]")));
            Logger.WriteDebugMessage("Clicked on edit button for audience : " + audienceName);
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
            Driver.FindElement(By.XPath("(//input[@type='text'])[3]")).SendKeys(Keys.Enter);
            Logger.WriteDebugMessage("Added Property List.");

            ElementClick(Driver.FindElement(By.XPath("//*[@id='titleHeader']/div/a/i")));
            Logger.WriteDebugMessage("Clicked on close 'X' icon for audience : " + audienceName);
            if (VerifyTextOnPage("If you close your Audience now, your changes will be lost."))
            {
                Logger.WriteDebugMessage("Landed on Unsaved Changes. Received Prompt message - " + quotes + "If you close your Audience now, your changes will be lost." + quotes);
                ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Leave Page')]")));
            }

            Logger.WriteDebugMessage("Landed on Manage Audience.");

            SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastPublished", 1, 1, audienceName);

            longdate_createdDate = Convert.ToDateTime(builderData.InsertedOn).ToString("M/d/yyyy hh:mm:ss tt");
            longdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy hh:mm:ss tt");
            shortdate_createdDate = Convert.ToDateTime(builderData.InsertedOn).ToString("M/d/yyyy");
            shortdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy");

            Logger.WriteInfoMessage("Last Date Time saved was " + shortdate_updateDate + " for Audience " + audienceName);
        }
        public static void TC_240155()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            string CompanyName = SqlWarehouseQuery.ReturnCompanyName("NA", "CompanyName", "TP_250054");
            string clientName = SqlWarehouseQuery.ReturnCompanyName("NA", "clientName", "TP_250054");
            Prerequisite_TP242047(builderData);

            //Profile.SelectClient(companyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_SearchButton();
            AudienceBuilder.Click_ABGrid_LastSaved();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            Logger.WriteDebugMessage("Clicked on detail button for audience : " + audienceName);
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Edit')]")));
            Logger.WriteDebugMessage("Clicked on edit button for audience : " + audienceName);
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
            Driver.FindElement(By.XPath("(//input[@type='text'])[3]")).SendKeys(Keys.Enter);
            Logger.WriteDebugMessage("Added Property List.");

            ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Details')]")));
            ElementClick(Driver.FindElement(By.XPath("//*[@id='titleHeader']/div/a/i")));
            Logger.WriteDebugMessage("Clicked on close 'X' icon for audience : " + audienceName);

            //ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Leave Page')]")));
            //Logger.WriteDebugMessage("Landed on Manage Audience.");
            //ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Stay On Page')]")));
            //Logger.WriteDebugMessage("Clicked on Stay On Page button.");

            Logger.WriteInfoMessage("Landed back on Edit Audience Page");
        }
        public static void TC_240156()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            string CompanyName = SqlWarehouseQuery.ReturnCompanyName("NA", "CompanyName", "TP_250054");
            string clientName = SqlWarehouseQuery.ReturnCompanyName("NA", "clientName", "TP_250054");
            Prerequisite_TP242047(builderData);

            //Profile.SelectClient(companyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_SearchButton();
            AudienceBuilder.Click_ABGrid_LastSaved();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            Logger.WriteDebugMessage("Clicked on detail button for audience : " + audienceName);
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Edit')]")));
            Logger.WriteDebugMessage("Clicked on edit button for audience : " + audienceName);
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
            Driver.FindElement(By.XPath("(//input[@type='text'])[3]")).SendKeys(Keys.Enter);
            Logger.WriteDebugMessage("Added Property List.");

            ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Details')]")));
            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Save')]")));
            Logger.WriteDebugMessage("Clicked on Save button. And Landed on Confirm Save Prompt.");
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("//*[@id='titleHeader']/div/a/i")));
            Logger.WriteDebugMessage("Clicked on close 'X' icon for audience : " + audienceName);

            ElementWait(Driver.FindElement(By.XPath("//button[contains(text(), 'Edit')]")), 240);
            if (IsElementPresent(By.XPath("//button[contains(text(), 'Edit')]")))
            {
                Logger.WriteDebugMessage("Landed on Details Page for AudienceName - " + audienceName);
                SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastSaved", 1, 1, audienceName);

                longdate_createdDate = Convert.ToDateTime(builderData.InsertedOn).ToString("M/d/yyyy hh:mm:ss tt");
                longdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy hh:mm:ss tt");
                shortdate_createdDate = Convert.ToDateTime(builderData.InsertedOn).ToString("M/d/yyyy hh:mm tt");
                shortdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy hh:mm tt");

                if (VerifyTextOnPage(shortdate_updateDate))
                {
                    Logger.WriteDebugMessage("Audience was saved successfully");
                }
                else
                {
                    Assert.Fail("Audience was not saved successfully");
                }
            }
            else
            {
                Assert.Fail("Did not land on Details Page for AudienceName - " + audienceName);
            }
        }
        public static void TC_240157()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            string CompanyName = SqlWarehouseQuery.ReturnCompanyName("NA", "CompanyName", "TP_250054");
            string clientName = SqlWarehouseQuery.ReturnCompanyName("NA", "clientName", "TP_250054");
            Prerequisite_TP242047(builderData);

            //Profile.SelectClient(companyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_SearchButton();
            AudienceBuilder.Click_ABGrid_LastSaved();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            Logger.WriteDebugMessage("Clicked on detail button for audience : " + audienceName);
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Edit')]")));
            Logger.WriteDebugMessage("Clicked on edit button for audience : " + audienceName);
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
            Driver.FindElement(By.XPath("(//input[@type='text'])[3]")).SendKeys(Keys.Enter);
            Logger.WriteDebugMessage("Added Property List.");
            ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Details')]")));

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Save & Publish')]")));
            Logger.WriteDebugMessage("Clicked on Save button. And Landed on Confirm Save and Publish Prompt.");
            ElementClick(Driver.FindElement(By.XPath("(//button[contains(text(), 'Publish')])[2]")));
            Logger.WriteDebugMessage("Clicked on Publish Button");
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("//*[@id='titleHeader']/div/a/i")));
            Logger.WriteDebugMessage("Clicked on close 'X' icon for audience : " + audienceName);


            SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastPublished", 1, 1, audienceName);

            longdate_createdDate = Convert.ToDateTime(builderData.InsertedOn).ToString("M/d/yyyy hh:mm:ss tt");
            longdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy hh:mm:ss tt");
            shortdate_createdDate = Convert.ToDateTime(builderData.InsertedOn).ToString("M/d/yyyy hh:mm tt");
            shortdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy hh:mm tt");

            if (VerifyTextOnPage(shortdate_updateDate))
            {
                Logger.WriteDebugMessage("Audience was saved and published successfully at " + shortdate_updateDate);
            }
            else
            {
                Assert.Fail("Audience was not saved successfully");

            }
        }
        public static void TC_240144()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            string CompanyName = SqlWarehouseQuery.ReturnCompanyName("NA", "CompanyName", "TP_250054");
            string clientName = SqlWarehouseQuery.ReturnCompanyName("NA", "clientName", "TP_250054");
            Prerequisite_TP242047(builderData);

            //Profile.SelectClient(companyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            Logger.WriteDebugMessage("Clicked on detail button for audience : " + audienceName);
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Edit')]")));
            Logger.WriteDebugMessage("Clicked on edit button for audience : " + audienceName);
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("//*[@id='titleHeader']/div/a/i")));
            Logger.WriteDebugMessage("Clicked on close 'X' icon for audience : " + audienceName);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'customerDetails')]")));
            if (Driver.FindElement(By.XPath("//a[contains(@href, 'customerDetails')]")).GetAttribute("class").Contains("active"))
            {
                if (VerifyTextOnPage("Customer Details"))
                {
                    HighlightElement(Driver.FindElement(By.XPath("//h2[contains(text(), 'Customer Details')]")));
                    Logger.WriteDebugMessage("Landed on Customer Details");
                }
                else
                {
                    Assert.Fail("Could not find Customer Details as Page Title.");
                }
            }
            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Edit')]")));
            Logger.WriteDebugMessage("Clicked on edit button for audience : " + audienceName);
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("//*[@id='titleHeader']/div/a/i")));
            Logger.WriteDebugMessage("Clicked on close 'X' icon for audience : " + audienceName);
            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'associatedCampaigns')]")));
            if (Driver.FindElement(By.XPath("//a[contains(@href, 'associatedCampaigns')]")).GetAttribute("class").Contains("active"))
            {
                getPageTitle = Driver.FindElement(By.XPath("//h2[contains(text(), 'Associated Campaigns')]")).Text;
                if (getPageTitle == "Associated Campaigns")
                {
                    HighlightElement(Driver.FindElement(By.XPath("//h2[contains(text(), 'Associated Campaigns')]")));
                    Logger.WriteDebugMessage("Found Page Title as Associated Campaigns");
                }
                else
                {
                    Assert.Fail("Could not find Customer Details as Page Title.");
                }
            }
            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Edit')]")));
            Logger.WriteDebugMessage("Clicked on edit button for audience : " + audienceName);
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("//*[@id='titleHeader']/div/a/i")));
            Logger.WriteDebugMessage("Clicked on close 'X' icon for audience : " + audienceName);

            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")));
            if (Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")).GetAttribute("class").Contains("active"))
            {
                getPageTitle = Driver.FindElement(By.XPath("//h2[contains(text(), 'History')]")).Text;
                if (getPageTitle == "History")
                {
                    HighlightElement(Driver.FindElement(By.XPath("//h2[contains(text(), 'History')]")));
                    Logger.WriteDebugMessage("Found Page Title as History");
                }
                else
                {
                    Assert.Fail("Could not find History as Page Title.");
                }
            }
        }
        public static void TC_240145()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            string CompanyName = SqlWarehouseQuery.ReturnCompanyName("NA", "CompanyName", "TP_250054");
            string clientName = SqlWarehouseQuery.ReturnCompanyName("NA", "clientName", "TP_250054");
            Prerequisite_TP242047(builderData);

            //Profile.SelectClient(companyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
            AddDelay(20000);

            string originalAudience = SqlWarehouseQuery.GetAudienceCriteria(audienceName, CompanyName, "LastPublished", "getSpecificCriteria");
            Logger.WriteInfoMessage("Last Published JSON version is " + originalAudience);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            Logger.WriteDebugMessage("Clicked on detail button for audience : " + audienceName);
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Edit')]")));
            Logger.WriteDebugMessage("Clicked on edit button for audience : " + audienceName);
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
            Logger.WriteDebugMessage("Clicked on close 'X' icon for audience : " + audienceName);

            SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastSaved", 1, 1, audienceName);

            longdate_createdDate = Convert.ToDateTime(builderData.InsertedOn).ToString("M/d/yyyy hh:mm:ss tt");
            longdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy hh:mm:ss tt");
            shortdate_createdDate = Convert.ToDateTime(builderData.InsertedOn).ToString("M/d/yyyy hh:mm tt");
            shortdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy hh:mm tt");

            if (VerifyTextOnPage(shortdate_updateDate))
            {
                Logger.WriteDebugMessage("Audience was updated. Saved Audience Date - " + shortdate_createdDate);
                string originalAudience1 = SqlWarehouseQuery.GetAudienceCriteria(audienceName, CompanyName, "LastPublished", "getSpecificCriteria");
                string AudienceSaved = SqlWarehouseQuery.GetAudienceCriteria(audienceName, CompanyName, "LastSaved", "getSpecificCriteria");
                if (originalAudience == originalAudience1)
                {
                    Logger.WriteInfoMessage("Last Published version was not affected after saving the audience.");
                    Logger.WriteInfoMessage("Rechecked Published Audience - " + originalAudience1);
                    Logger.WriteInfoMessage("Saved Audience - " + AudienceSaved);
                }
            }
            else
            {
                Assert.Fail("Audience name was not updated correctly.");
            }
        }
        public static void TC_240146()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            string CompanyName = SqlWarehouseQuery.ReturnCompanyName("NA", "CompanyName", "TP_250054");
            string clientName = SqlWarehouseQuery.ReturnCompanyName("NA", "clientName", "TP_250054");
            Prerequisite_TP242047(builderData);

            //Profile.SelectClient(companyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_ABGrid_LastSaved();
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
            AddDelay(20000);

            string originalAudience = SqlWarehouseQuery.GetAudienceCriteria(audienceName, CompanyName, "LastSaved", "getSpecificCriteria");
            Logger.WriteInfoMessage("Last Saved JSON version is " + originalAudience);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            Logger.WriteDebugMessage("Clicked on detail button for audience : " + audienceName);
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Edit')]")));
            Logger.WriteDebugMessage("Clicked on edit button for audience : " + audienceName);
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
            ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
            Driver.FindElement(By.XPath("(//input[@type='text'])[3]")).SendKeys(Keys.Enter);
            Logger.WriteDebugMessage("Added Property List.");

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ElementWait(Driver.FindElement(By.XPath("//button[contains(text(), 'Save & Publish')]")), 120);
            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Save & Publish')]")));
            Logger.WriteDebugMessage("Clicked on Save and Publish button.");
            ElementClick(Driver.FindElement(By.XPath("(//button[contains(text(), 'Publish')])[2]")));
            Logger.WriteDebugMessage("Clicked on Publish Button");
            AddDelay(25000);

            ElementClick(Driver.FindElement(By.XPath("//*[@id='titleHeader']/div/a/i")));
            Logger.WriteDebugMessage("Clicked on close 'X' icon for audience : " + audienceName);

            SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastPublished", 1, 1, audienceName);

            longdate_createdDate = Convert.ToDateTime(builderData.InsertedOn).ToString("M/d/yyyy hh:mm:ss tt");
            longdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy hh:mm:ss tt");
            shortdate_createdDate = Convert.ToDateTime(builderData.InsertedOn).ToString("M/d/yyyy hh:mm tt");
            shortdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy hh:mm tt");

            if (VerifyTextOnPage(shortdate_updateDate))
            {
                Logger.WriteDebugMessage("Audience was updated. Published Audience Date - " + shortdate_createdDate);
                string AudienceSaved = SqlWarehouseQuery.GetAudienceCriteria(audienceName, CompanyName, "LastSaved", "getSpecificCriteria");
                string AudiencePublished = SqlWarehouseQuery.GetAudienceCriteria(audienceName, CompanyName, "LastPublished", "getSpecificCriteria");
                if (AudienceSaved == AudiencePublished)
                {
                    Logger.WriteInfoMessage("Saved and Published version was same after Audience was Published.");
                    Logger.WriteInfoMessage("Saved Audience - " + AudienceSaved);
                    Logger.WriteInfoMessage("Published Audience - " + AudiencePublished);
                }
            }
            else
            {
                Assert.Fail("Audience name was not updated correctly.");
            }
        }
        public static void TC_240847()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            string CompanyName = "";
            string clientName = "";
            if (testCategory == "QA")
            {
                CompanyName = SqlWarehouseQuery.ReturnCompanyName("NA", "CompanyName", "TP_250054");
                clientName = SqlWarehouseQuery.ReturnCompanyName("NA", "clientName", "TP_250054");
            }
            if (testCategory == "POC")
            {
                CompanyName = "Hotel Origami";
                clientName = "Hotel Origami";
            }
            
            Prerequisite_TP242047(builderData);

            //Profile.SelectClient(companyName);
            //            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            Logger.WriteDebugMessage("Clicked on detail button for audience : " + audienceName);
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Edit')]")));
            Logger.WriteDebugMessage("Clicked on edit button for audience : " + audienceName);
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            if (VerifyTextOnPage("You do not have permission to modify criteria."))
            {
                Logger.WriteDebugMessage(LegacyTestData.CommonFrontendEmail + " does not have access to all properties in Edit Audience.");
            }
            else
            {
                Assert.Fail("Permission message did not show for email - " + LegacyTestData.CommonFrontendEmail);
            }
        }
        #endregion[TP_242047]

    }
}
