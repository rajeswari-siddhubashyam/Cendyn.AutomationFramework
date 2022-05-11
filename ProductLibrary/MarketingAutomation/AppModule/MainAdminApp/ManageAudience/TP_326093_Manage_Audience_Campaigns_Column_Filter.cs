using MarketingAutomation.AppModule.UI;
using MarketingAutomation.Entity;
using MarketingAutomation.Utility;
using BaseUtility.Utility;
using Queries = MarketingAutomation.Utility.Queries;
using System.Collections.Generic;
using InfoMessageLogger;
using TestData;
using OpenQA.Selenium;
using System;
using NUnit.Framework;
using MarketingAutomation.PageObject.UI;

namespace MarketingAutomation.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region[TP_326093]

        public static void TC_326096()
        {
            if (TestCaseId == Constants.TC_326096)
            {
                //Variables declaration and object creation
                string filterOption;

                //Read the data
                filterOption = TestData.ExcelData.TestDataReader.ReadData(1, "filterOption");
                //Step1: Navigate to Marketing Automation and log in as a valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //Expected: User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Step2: Click on audience
                Navigation.ClickOnSidebarAudience();
                Logger.WriteDebugMessage("Manage Audience page should displayed");

                //Switch to List view to see the campaign count of the listed template
                ManageCampaign.List_View();
                ManageCampaign.WaitToHideLoaderListView();
                //Step3: Click on View details > Campaigns
                ManageTemplate.VerifyCampaignCountAndClickOnNameToLandOnSummary();
                ManageAudience.VerifyAudienceCampaignTab();
                Logger.WriteDebugMessage("Manage Audience page should displayed");

                // Click on Campaign Tab > Summary.
                ManageAudience.ClickOnCampaignTabAndVerifyColumnHeader();
                Logger.WriteDebugMessage("Campaign Tab with column should get open.");

                string idToFilter = ManageTemplate.GetTheColumnValueBasedOnName("ID");

                //Click on ID column > Icon 
                //Step4: Validate Filter/Search for ID column
                ManageTemplate.ClickOnFilterIconAndVerifyFilterOptionsDropDownValue("ID", filterOption);
                Logger.WriteDebugMessage("Search By Tab should get open with option as below:- Contains.Equals.");
                CreateCampaign.Campaign_Click_Clear();
                ManageCampaign.WaitToHideLoaderListView();
                var act = filterOption.Split(',');
                foreach (var item in act)
                {
                    ManageTemplate.EnterColumnFilterValueBasedOnName("ID", item, idToFilter);
                    CreateCampaign.Campaign_Click_Filter_Apply_Button();
                    if (PageObject_ManageTemplate.Clear_Filters_Button_No_Result_NoElement() != null)
                        Assert.Fail("System is not displaying search result based on filter selection");
                    else
                        ManageCampaign.VerifyCampaignInfoOnPageByProvidingNameListView(null, null, idToFilter, null, null);
                    Logger.WriteDebugMessage($"System is displaying search result based on filter selection {item}, {idToFilter}");
                    ManageTemplate.ClickOnColumnFilterIconeBasedOnName("ID");
                    CreateCampaign.Campaign_Click_Clear();
                    ManageCampaign.WaitToHideLoaderListView();
                    idToFilter = ManageTemplate.GetTheColumnValueBasedOnName("ID");
                }
            }
        }

        public static void TC_326097()
        {
            if (TestCaseId == Constants.TC_326097)
            {
                //Variables declaration and object creation
                string filterOption;

                //Read the data
                filterOption = TestData.ExcelData.TestDataReader.ReadData(1, "filterOption");

                //Step1: Navigate to Marketing Automation and log in as a valid user.
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //Expected: User should land on Marketing Automation.
                Navigation.Verify_LandsOnMAPage();

                //Step2: Click on audience
                Navigation.ClickOnSidebarAudience();
                Logger.WriteDebugMessage("Manage Audience page should displayed");

                //Switch to List view to see the campaign count of the listed template
                ManageCampaign.List_View();
                ManageCampaign.WaitToHideLoaderListView();
                //Click on View Detail > Ellipse.
                ManageTemplate.VerifyCampaignCountAndClickOnNameToLandOnSummary();
                ManageAudience.VerifyAudienceCampaignTab();
                Logger.WriteDebugMessage("User should land on Template Summary.");

                //Step3: Click on View details > Campaigns
                ManageAudience.ClickOnCampaignTabAndVerifyColumnHeader();
                Logger.WriteDebugMessage("Campaign tab should get displayed.");

                //Step4: Validate Filter/Search for Name column
                ManageTemplate.ClickOnFilterIconAndVerifyFilterOptionsDropDownValue("Name", filterOption);
                Logger.WriteDebugMessage("Expected Result:- User should able to - Start With. End With. Contains. Equals.");
                PageObject_ManageTemplate.Filter_Text().Click();
                CreateCampaign.Campaign_Click_Clear();
                string nameToFilter = ManageTemplate.GetTheColumnValueBasedOnName("NAME");
                var act = filterOption.Split(',');
                foreach (var item in act)
                {
                    ManageTemplate.EnterColumnFilterValueBasedOnName("Name", item, nameToFilter);
                    CreateCampaign.Campaign_Click_Filter_Apply_Button();
                    if (PageObject_ManageTemplate.Clear_Filters_Button_No_Result_NoElement() != null)
                        Assert.Fail("System is not displaying search result based on filter selection");
                    else
                        ManageCampaign.VerifyCampaignInfoOnPageByProvidingNameListView(nameToFilter, null, null, null, null);
                    Logger.WriteDebugMessage($"System is displaying search result based on filter selection {item}, {nameToFilter}");
                    ManageTemplate.ClickOnColumnFilterIconeBasedOnName("Name");
                    CreateCampaign.Campaign_Click_Clear();
                    ManageCampaign.WaitToHideLoaderListView();
                    nameToFilter = ManageTemplate.GetTheColumnValueBasedOnName("NAME");
                }
            }
        }

        public static void TC_326098()
        {
            if (TestCaseId == Constants.TC_326098)
            {

                //Variables declaration and object creation
                string filterOption;

                //Read the data
                filterOption = TestData.ExcelData.TestDataReader.ReadData(1, "filterOption");

                //Step1: Navigate to Marketing Automation and log in as a valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //Expected: User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Step2: Click on audience
                Navigation.ClickOnSidebarAudience();
                Logger.WriteDebugMessage("Manage Audience page should displayed");


                //Switch to List view to see the campaign count of the listed template
                ManageCampaign.List_View();
                ManageCampaign.WaitToHideLoaderListView();

                // Click on View Detail > Ellipse.
                ManageTemplate.VerifyCampaignCountAndClickOnNameToLandOnSummary();
                ManageAudience.VerifyAudienceCampaignTab();
                Logger.WriteDebugMessage("User should land on Template Summary.");

                //Step3: Click on View details > Campaigns 
                ManageAudience.ClickOnCampaignTabAndVerifyColumnHeader();
                Logger.WriteDebugMessage("Campaign tab should get displayed.");

                //Step4: Validate Filter/Search for Status column
                ManageTemplate.ClickOnFilterIconAndVerifyFilterOptionsDropDownValue("Status", filterOption);
                Logger.WriteDebugMessage("Expected result: User should able to Search by look up selection"+
                                            "Only available status that appear in the table");
                PageObject_ManageTemplate.Filter_Text().Click();
                CreateCampaign.Campaign_Click_Clear();
                string statusToFilter = ManageTemplate.GetTheColumnValueBasedOnName("STATUS");
                var act = filterOption.Split(',');
                foreach (var item in act)
                {
                    ManageTemplate.EnterColumnFilterValueBasedOnName("Status", item, statusToFilter);
                    CreateCampaign.Campaign_Click_Filter_Apply_Button();
                    if (PageObject_ManageTemplate.Clear_Filters_Button_No_Result_NoElement() != null)
                        Assert.Fail("System is not displaying search result based on filter selection");
                    else
                        ManageCampaign.VerifyCampaignInfoOnPageByProvidingNameListView(null, null, null, statusToFilter, null);
                    Logger.WriteDebugMessage($"System is displaying search result based on filter selection {item}, {statusToFilter}");
                    ManageTemplate.ClickOnColumnFilterIconeBasedOnName("Status");
                    CreateCampaign.Campaign_Click_Clear();
                    ManageCampaign.WaitToHideLoaderListView();
                    statusToFilter = ManageTemplate.GetTheColumnValueBasedOnName("STATUS");
                }
            }
        }

        public static void TC_326100()
        {
            if (TestCaseId == Constants.TC_326100)
            {

                //Variables declaration and object creation
                string filterOption;

                //Read the data
                filterOption = TestData.ExcelData.TestDataReader.ReadData(1, "filterOption");

                //Step1: Navigate to Marketing Automation and log in as a valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //Expected: User lands on Marketing Automation
                Navigation.Verify_LandsOnMAPage();

                //Step2: Click on audience
                Navigation.ClickOnSidebarAudience();
                Logger.WriteDebugMessage("Manage Audience page should displayed");


                //Switch to List view to see the campaign count of the listed template
                ManageCampaign.List_View();
                ManageCampaign.WaitToHideLoaderListView();

                // Click on View Detail > Ellipse.
                ManageTemplate.VerifyCampaignCountAndClickOnNameToLandOnSummary();
                ManageAudience.VerifyAudienceCampaignTab();
                Logger.WriteDebugMessage("User should land on Template Summary.");

                //Step3: Click on View details > Campaigns 
                ManageAudience.ClickOnCampaignTabAndVerifyColumnHeader();
                Logger.WriteDebugMessage("Campaign tab should get displayed.");

                //Step4: Validate Filter/Search for Updated On column
                ManageTemplate.ClickOnFilterIconAndVerifyFilterOptionsDropDownValue("Update On", filterOption);
                Logger.WriteDebugMessage("Expected result: User should able to Search by Date  Equals Date Between Date");
                PageObject_ManageTemplate.Filter_Text().Click();
                CreateCampaign.Campaign_Click_Clear();
                string date = ManageTemplate.GetTheColumnValueBasedOnName("UPDATE ON");
                var dateToFilter = Convert.ToDateTime(date).ToString("MMM dd, yyyy");
                var act = filterOption.Split(',');
                foreach (var item in act)
                {
                    if (item.ToLower().Trim().Equals("between"))
                    {
                        var previousWeekDate = Convert.ToDateTime(date).AddDays(-7).ToString("MMM dd, yyyy");
                        dateToFilter = previousWeekDate + " - " + dateToFilter;
                    }
                    ManageTemplate.EnterColumnFilterValueBasedOnName("Update On", item, dateToFilter);
                    CreateCampaign.Campaign_Click_Filter_Apply_Button();
                    if (PageObject_ManageTemplate.Clear_Filters_Button_No_Result_NoElement() != null)
                        Assert.Fail("System is not displaying search result based on filter selection");
                    else
                        ManageTemplate.VerifyDateFilterResultForEqualAndBetweenType(item, date);
                    Logger.WriteDebugMessage($"System is displaying search result based on filter selection {item}, {date}");
                    ManageTemplate.ClickOnColumnFilterIconeBasedOnName("Update On");
                    CreateCampaign.Campaign_Click_Clear();
                    ManageCampaign.WaitToHideLoaderListView();
                    date = ManageTemplate.GetTheColumnValueBasedOnName("UPDATE ON");
                    dateToFilter = Convert.ToDateTime(date).ToString("MMM dd, yyyy");
                }
            }
        }

        #endregion[TP_326093]
    }
}
