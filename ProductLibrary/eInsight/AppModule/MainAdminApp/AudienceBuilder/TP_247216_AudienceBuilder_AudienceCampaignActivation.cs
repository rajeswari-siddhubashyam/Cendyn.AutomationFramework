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
        public static void Prerequisite_TC247216(AudienceBuilderData builderData)
        {
            if (string.IsNullOrEmpty(CompanyName))
            {
                CompanyName = companyNameByTestCase;
            }
            if (string.IsNullOrEmpty(clientName))
            {
                clientName = clientNameByTestCase;
            }
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
            //Profile.SelectClient(CompanyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
        }
        #region[TP_247216]
        public static void TC_245853()
        {
        }
        public static void TC_245854()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            
            SqlWarehouseQuery.UpdateAudience(CompanyName, audienceName, "1", "AudienceStatus");
            Prerequisite_TC247216(builderData);
            AudienceBuilder.DeactivateAudience(audienceName, "Deactivate");
            

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_SearchButton();
            if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]"))))
            {
                Assert.Fail("Deactivated audience " + audienceName + " was found.");
            }
            else
            {
                Logger.WriteDebugMessage("Deactivated Audience was not found.");
                AudienceBuilder.Click_Checkbox_ShowInactive();
                AudienceBuilder.Click_SearchButton();
                if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]"))))
                {
                    Logger.WriteDebugMessage("Deactivated Audience was found after clicking on Show inactive audience checkbox.");
                    AudienceBuilder.DeactivateAudience(audienceName, "Activate");
                    ((IJavaScriptExecutor)Driver).ExecuteScript("location.reload(true);");
                    ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
                    AudienceBuilder.Click_SearchButton();
                    if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]"))))
                    {
                        ElementClick(Driver.FindElement(By.XPath("//td[contains(text(), '" + audienceName + "')]")));
                        if (IsElementVisible(Driver.FindElement(By.XPath("//td[contains(text(), 'Status')]//following::span[contains(text(), 'Active')]"))))
                        {
                            Logger.WriteDebugMessage("Activated audience " + audienceName + " was found.");
                        }
                    }
                    else
                    {
                        Assert.Fail("Activated audience " + audienceName + " was not found after activating audience.");
                    }
                    ((IJavaScriptExecutor)Driver).ExecuteScript("location.reload(true);");
                    ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
                    AudienceBuilder.Click_Checkbox_ShowInactive();
                    AudienceBuilder.Click_SearchButton();
                    if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]"))))
                    {
                        ElementClick(Driver.FindElement(By.XPath("//td[contains(text(), '" + audienceName + "')]")));
                        if (IsElementVisible(Driver.FindElement(By.XPath("//td[contains(text(), 'Status')]//following::span[contains(text(), 'Active')]"))))
                        {
                            Logger.WriteDebugMessage("Activated audience " + audienceName + " was found after enabling inactive checkbox.");
                        }
                    }
                }
                else
                {
                    Assert.Fail("Deactivated Audience " + audienceName + " was not found after clicking on Show inactive audience checkbox.");
                }
            }

            /*Post-Requisite*/
            SqlWarehouseQuery.UpdateAudience(CompanyName, audienceName, "1", "AudienceStatus");
        }
        public static void TC_245855()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            
            SqlWarehouseQuery.UpdateAudience(CompanyName, audienceName, "1", "AudienceStatus");
            Prerequisite_TC247216(builderData);
            AudienceBuilder.DeactivateAudience(audienceName, "Cancel");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            Logger.WriteDebugMessage("Entered Audience Name - " + audienceName);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Clicked on Search button");
            if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]"))))
            {
                Logger.WriteDebugMessage("Activated audience " + audienceName + " was found.");
            }
            else
            {
                Assert.Fail("Activated audience " + audienceName + " was not found.");
            }
            
            ((IJavaScriptExecutor)Driver).ExecuteScript("location.reload(true);");
            ((IJavaScriptExecutor)Driver).ExecuteScript("location.reload(true);");
            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            Logger.WriteDebugMessage("Entered Audience Name - " + audienceName);
            ElementClick(Driver.FindElement(By.Id("checkboxShowInactiveAudiences")));
            Logger.WriteDebugMessage("Clicked on Show inactive audience.");
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Clicked on Search button");
            if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]"))))
            {
                Logger.WriteDebugMessage("Activated audience " + audienceName + " was found after activating audience.");
            }
            else
            {
                Assert.Fail("Activated audience " + audienceName + " was not found after activating audience.");
            }

        }
        public static void TC_245857()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            
            Prerequisite_TC247216(builderData);

            Logger.WriteInfoMessage("******Pre-Requiste******");
            SqlWarehouseQuery.UpdateAudience(CompanyName, audienceName, "0", "AudienceStatus");
            Logger.WriteInfoMessage("Audience " + audienceName + " is deactivated.");

            ((IJavaScriptExecutor)Driver).ExecuteScript("location.reload(true);");
            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            Logger.WriteDebugMessage("Entered Audience Name - " + audienceName);
            ElementClick(Driver.FindElement(By.Id("checkboxShowInactiveAudiences")));
            Logger.WriteDebugMessage("Clicked on Show inactive audience.");
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Clicked on Search button");
            AudienceBuilder.DeactivateAudience(audienceName, "Activate");


            if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]"))))
            {
                Logger.WriteDebugMessage("Activated audience " + audienceName + " was found.");
            }
            else
            {
                Assert.Fail("Activated audience " + audienceName + " was not found.");
            }
                    ((IJavaScriptExecutor)Driver).ExecuteScript("location.reload(true);");
            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            Logger.WriteDebugMessage("Entered Audience Name - " + audienceName);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Clicked on Search button");
            if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]"))))
            {
                Logger.WriteDebugMessage("Activated audience " + audienceName + " was found.");
            }
            else
            {
                Assert.Fail("Activated audience " + audienceName + " was not found.");
            }
            ElementClick(Driver.FindElement(By.Id("checkboxShowInactiveAudiences")));
            Logger.WriteDebugMessage("Clicked on Show inactive audience.");
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Clicked on Search button");
            if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]"))))
            {
                Logger.WriteDebugMessage("Activated audience " + audienceName + " was found after activating audience.");
            }
            else
            {
                Assert.Fail("Activated audience " + audienceName + " was not found after activating audience.");
            }
        }
        public static void TC_245858()
        {
        }
        #endregion[TP_247216]

    }
}
