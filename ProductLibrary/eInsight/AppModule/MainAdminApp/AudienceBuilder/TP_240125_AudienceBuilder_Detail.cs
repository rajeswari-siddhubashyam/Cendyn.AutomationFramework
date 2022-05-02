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

namespace eInsight.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        private static void AudiencePreReq_TP240125(AudienceBuilderData builderData)
        {
            /*Pre-Requisite */
            //string CompanyName = SqlWarehouseQuery.ReturnCompanyName("", "CompanyName", TestPlanId);
            audienceName = SqlWarehouseQuery.ReturnCompanyName("NA", "AudienceName", TestPlanId) + TestPlanId;
            string dynamicCriteriaJSON = SqlWarehouseQuery.ReturnDescriptionValue("NA", "AudienceName", TestPlanId);

            SqlWarehouseQuery.createAudience(CompanyName, builderData, audienceName, dynamicCriteriaJSON, LegacyTestData.CommonFrontendEmail);

            if (builderData.AudienceDetailID == "1")
            {
                Logger.WriteInfoMessage("Audience Name " + audienceName + " already exist.");
            }
            else
            {
                Logger.WriteInfoMessage("Created a new Audience Name " + audienceName);
            }
        }
        public static void TC_240127()
        {
            //Previous used AudienceName - April 12 Audience1
            AudienceBuilderData builderData = new AudienceBuilderData();
            
            AudiencePreReq_TP240125(builderData);
            SqlWarehouseQuery.UpdateAudience(CompanyName, audienceName, "1", "AudienceStatus");
            //Profile.SelectClient(CompanyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");
            
            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_SearchButton();
            AudienceBuilder.Click_ABGrid_LastSaved();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            if (VerifyTextOnPage("Audience Details for " + audienceName))
            {
                Logger.WriteDebugMessage("Found Page Title As - " + "Audience Details for " + audienceName);
            }
            else
            {
                Assert.Fail("Audience Details for " + audienceName + " could not found.");
            }
        }
        public static void TC_240128()
        {
            //Previous used AudienceName - April 12 Audience1
            AudienceBuilderData builderData = new AudienceBuilderData();
            AudiencePreReq_TP240125(builderData);
            SqlWarehouseQuery.UpdateAudience(CompanyName, audienceName, "1", "AudienceStatus");
            //Profile.SelectClient(CompanyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");

            AudienceBuilder.Audience_SearchByExpression("contains");
            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), "Lorem ipsum dolor sit");
            AudienceBuilder.Click_ABGrid_LastSaved();
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce which comtains AudienceName as  " + "Lorem ipsum dolor sit");
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            AudienceBuilder.HoverOverMouse(audienceName);
        }
        public static void TC_240129()
        {
            //Previous used AudienceName - April 12 Audience1
            AudienceBuilderData builderData = new AudienceBuilderData();
            AudiencePreReq_TP240125(builderData);
            SqlWarehouseQuery.UpdateAudience(CompanyName, audienceName, "1", "AudienceStatus");
            //Profile.SelectClient(CompanyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_ABGrid_LastSaved();
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            if (Driver.FindElement(By.XPath("//a[contains(@href, 'summary')]")).GetAttribute("class").Contains("active"))
            {
                getPageTitle = Driver.FindElement(By.XPath("//h2[contains(text(), 'Summary')]")).Text;
                if (getPageTitle == "Summary")
                {
                    HighlightElement(Driver.FindElement(By.XPath("//h2[contains(text(), 'Summary')]")));
                    Logger.WriteDebugMessage("Found Page Title as Summary");
                }
                else
                {
                    Assert.Fail("Could not find Summary as Page Title.");
                }
            }
            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'customerDetails')]")));
            if (Driver.FindElement(By.XPath("//a[contains(@href, 'customerDetails')]")).GetAttribute("class").Contains("active"))
            {
                if (VerifyTextOnPage("Customer Details"))
                {
                    HighlightElement(Driver.FindElement(By.XPath("//h2[contains(text(), 'Customer Details')]")));
                    Logger.WriteDebugMessage("Found Page Title as Customer Details");
                }
                else
                {
                    Assert.Fail("Could not find Customer Details as Page Title.");
                }
            }
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
            else
            {
                Assert.Fail("Didn't Land on the specific page.");
            }
        }

        public static void TC_240133()
        {
            //Previous used AudienceName - April 12 Audience1
            AudienceBuilderData builderData = new AudienceBuilderData();
            
            AudiencePreReq_TP240125(builderData);
            SqlWarehouseQuery.UpdateAudience(CompanyName, audienceName, "1", "AudienceStatus");
            //Profile.SelectClient(CompanyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_ABGrid_LastSaved();
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
            AddDelay(20000);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            if (Driver.FindElement(By.XPath("//a[contains(@href, 'summary')]")).GetAttribute("class").Contains("active"))
            {
                getPageTitle = Driver.FindElement(By.XPath("//h2[contains(text(), 'Summary')]")).Text;
                if (getPageTitle == "Summary")
                {
                    HighlightElement(Driver.FindElement(By.XPath("//*[contains(text(), 'Manage Audiences')]")));
                    Logger.WriteDebugMessage("Found Name Back to Manage Audience after Landing on " + getPageTitle);
                    ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Manage Audiences')]")));
                    Driver.SwitchTo().DefaultContent();
                    Driver.SwitchTo().Frame(0);
                    ElementWait(Driver.FindElement(By.Id("selectField")), 120);
                    Logger.WriteDebugMessage("Landed on Manage Audience.");
                }
                else
                {
                    Assert.Fail("Could not find Summary as Page Title.");
                }
            }

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'customerDetails')]")));
            if (Driver.FindElement(By.XPath("//a[contains(@href, 'customerDetails')]")).GetAttribute("class").Contains("active"))
            {
                if (VerifyTextOnPage("Customer Details"))
                {
                    HighlightElement(Driver.FindElement(By.XPath("//*[contains(text(), 'Manage Audiences')]")));
                    Logger.WriteDebugMessage("Found Name Back to Manage Audience after Landing on Customer Details");
                    ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Manage Audiences')]")));
                    Driver.SwitchTo().DefaultContent();
                    Driver.SwitchTo().Frame(0);
                    ElementWait(Driver.FindElement(By.Id("selectField")), 120);
                    Logger.WriteDebugMessage("Landed on Manage Audience.");
                }
                else
                {
                    Assert.Fail("Could not find Customer Details as Page Title.");
                }
            }

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'associatedCampaigns')]")));
            if (Driver.FindElement(By.XPath("//a[contains(@href, 'associatedCampaigns')]")).GetAttribute("class").Contains("active"))
            {
                getPageTitle = Driver.FindElement(By.XPath("//h2[contains(text(), 'Associated Campaigns')]")).Text;
                if (getPageTitle == "Associated Campaigns")
                {
                    HighlightElement(Driver.FindElement(By.XPath("//*[contains(text(), 'Manage Audiences')]")));
                    Logger.WriteDebugMessage("Found Name Back to Manage Audience after Landing on " + getPageTitle);
                    ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Manage Audiences')]")));
                    Driver.SwitchTo().DefaultContent();
                    Driver.SwitchTo().Frame(0);
                    ElementWait(Driver.FindElement(By.Id("selectField")), 120);
                    Logger.WriteDebugMessage("Landed on Manage Audience.");
                }
                else
                {
                    Assert.Fail("Could not find Customer Details as Page Title.");
                }
            }

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);

            ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")));
            if (Driver.FindElement(By.XPath("//a[contains(@href, 'history')]")).GetAttribute("class").Contains("active"))
            {
                getPageTitle = Driver.FindElement(By.XPath("//h2[contains(text(), 'History')]")).Text;
                if (getPageTitle == "History")
                {
                    HighlightElement(Driver.FindElement(By.XPath("//*[contains(text(), 'Manage Audiences')]")));
                    Logger.WriteDebugMessage("Found Name Back to Manage Audience after Landing on " + getPageTitle);
                    ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Manage Audiences')]")));
                    Driver.SwitchTo().DefaultContent();
                    Driver.SwitchTo().Frame(0);
                    ElementWait(Driver.FindElement(By.Id("selectField")), 120);
                    Logger.WriteDebugMessage("Landed on Manage Audience.");
                }
                else
                {
                    Assert.Fail("Could not find History as Page Title.");
                }
            }
            else
            {
                Assert.Fail("Didn't Land on the specific page.");
            }
        }

    }
}
