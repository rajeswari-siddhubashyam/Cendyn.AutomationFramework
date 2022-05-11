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
        #region[TP_261306]
        public static void TC_261051()
        {
            string audienceName = "";
            if (testCategory == "QA")
            {
                audienceName = "Am Test Audience 1";
            }
            if (testCategory == "POC")
            {
                audienceName = "Deactivate Audience";
            }
            

            //Profile.SelectClient(CompanyName);
            Profile.SelectSubClient(clientNameByTestCase);
            /*Pre-Requisite*/
            SqlWarehouseQuery.UpdateAudience(companyNameByTestCase, audienceName, "1", "AudienceStatus");

            Navigation.MenuNavigation("AudienceBuilder");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
            ElementWait(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")), 120);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            Logger.WriteDebugMessage("Clicked on detail button for audience : " + audienceName);
            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            if (Driver.FindElement(By.XPath("//a[contains(@href, 'summary')]")).GetAttribute("class").Contains("active"))
            {
                ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'associatedCampaigns')]")));
                Logger.WriteDebugMessage("Landed on Associated Campaign. Found All ProjectIDs.");

                ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Back to Manage Audiences')]")));
                Driver.SwitchTo().DefaultContent();
                Driver.SwitchTo().Frame(0);

                AudienceBuilder.DeactivateAudience(audienceName, "Deactivate");
            }
            else
            {
                Assert.Fail("Did not land on Details Page.");
            }

            /*Post-Requisite*/
            SqlWarehouseQuery.UpdateAudience(companyNameByTestCase, audienceName, "1", "AudienceStatus");
        }
        public static void TC_261310()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            Prerequisite_TC247216(builderData);

            SqlWarehouseQuery.UpdateAudience(companyNameByTestCase, audienceName, "1", "AudienceStatus");

            ////Profile.SelectClient(CompanyName);
            //Profile.SelectSubClient(companyNameByTestCase);

            //Driver.Navigate().GoToUrl(LegacyTestData.CommonFrontendURL + "Project.mvc/Project/Audience");
            //AddDelay(20000);
            //Driver.SwitchTo().Frame(0);
            //ElementWait(Driver.FindElement(By.Id("selectField")), 120);

            //ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            //AudienceBuilder.Click_SearchButton();
            //Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
            if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]"))))
            {
                ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
                Logger.WriteDebugMessage("Clicked on detail button for audience : " + audienceName);
                ElementWait(Driver.FindElement(By.XPath("//a[contains(@href, 'summary')]")), 60);
                if (Driver.FindElement(By.XPath("//a[contains(@href, 'summary')]")).GetAttribute("class").Contains("active"))
                {
                    ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'associatedCampaigns')]")));
                    Logger.WriteDebugMessage("Landed on Associated Campaign. No projects found.");

                    ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Back to Manage Audiences')]")));
                    Driver.SwitchTo().DefaultContent();
                    Driver.SwitchTo().Frame(0);
                    AddDelay(15000);
                    AudienceBuilder.DeactivateAudience(audienceName, "Deactivate");
                }
                else
                {
                    Assert.Fail("Did not land on Details Page.");
                }
            }
            else
            {
                Assert.Fail("Audience Name did not displayed on Audience Search Grid.");
            }

            /*Post-Requisite*/
            SqlWarehouseQuery.UpdateAudience(companyNameByTestCase, audienceName, "1", "AudienceStatus");
        }
        public static void TC_261312()
        {
            audienceName = "QAAutomation_TC_261312";
            
            /*Pre-Requisite*/
            SqlWarehouseQuery.UpdateAudience(companyNameByTestCase, audienceName, "1", "AudienceStatus");

            //Profile.SelectClient(CompanyName);
            Profile.SelectSubClient(clientNameByTestCase);

            Navigation.MenuNavigation("AudienceBuilder");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);

            if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]"))))
            {
                ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
                Logger.WriteDebugMessage("Clicked on detail button for audience : " + audienceName);
                ElementWait(Driver.FindElement(By.XPath("//a[contains(@href, 'summary')]")), 60);
                if (Driver.FindElement(By.XPath("//a[contains(@href, 'summary')]")).GetAttribute("class").Contains("active"))
                {
                    ElementClick(Driver.FindElement(By.XPath("//a[contains(@href, 'associatedCampaigns')]")));
                    Logger.WriteDebugMessage("Landed on Associated Campaign. No projects found.");

                    ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Back to Manage Audiences')]")));
                    Driver.SwitchTo().DefaultContent();
                    Driver.SwitchTo().Frame(0);

                    AudienceBuilder.DeactivateAudience(audienceName, "Deactivate");
                }
                else
                {
                    Assert.Fail("Did not land on Details Page.");
                }
            }
            else
            {
                Assert.Fail("Audience Name did not displayed on Audience Search Grid.");
            }

            /*Post-Requisite*/
            SqlWarehouseQuery.UpdateAudience(companyNameByTestCase, audienceName, "1", "AudienceStatus");
        }
        #endregion[TP_261306]

    }
}
