using System;
using eNgage.Utility;
using eNgage.AppModule.UI;
using Common;
using Constants = eNgage.Utility.Constants;
using InfoMessageLogger;
using BaseUtility.Utility;
using TestData;
using OpenQA.Selenium;
using NUnit.Framework;
using eNgage.AppModule.UI;
using eNgage.PageObject.UI;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using SqlWarehouse;
using System.Linq;

namespace eNgage.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        #region[TP_242772]
        public static void TC_242784()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            List<PromptsRules> p = new List<PromptsRules>();

            if (LegacyTestData.FrontEndURL != null && LegacyTestData.ClientName != null)
            {
                ConnectionStringVar = ConnectionString3.Replace("PromptOrigami_QA", "Prompt" + LegacyTestData.ClientName + "_QA");
            }
            else
                ConnectionStringVar = ConnectionString3;

            PageObject_Search.Nav_Search().Click();
            SelectElement searchDropDown = new SelectElement(PageObject_Search.Search_Select());
            searchDropDown.SelectByValue("Profile");
            Search.ClearInputValues();
            IList<String> InputElements = new List<String>
                {
                    searchDropDown.SelectedOption.GetAttribute("value"),
                    "Profile",
                    profileID
                };

            Search.searchBy(Driver, InputElements);
            AddDelay(500);
            Search.VerifyIDSearchResults(Driver, profileID, profileID);
            Search.clickFromSearchResults(Driver);
            Prompts.checkPromptsLoad(Driver, wait);

            p = SqlWarehouseQuery.GetPromptRules();

            string promptDB = Prompts.FindRule("Welcome Rule", p);
            string promptUI = Prompts.GetDisplayPrompt("welcome");
            Prompts.VerifyPromptMatch(promptDB, promptUI);
        }
        public static void TC_242805()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            List<PromptsRules> p = new List<PromptsRules>();

            if (LegacyTestData.FrontEndURL != null && LegacyTestData.ClientName != null)
            {
                ConnectionStringVar = ConnectionString3.Replace("PromptOrigami_QA", "Prompt" + LegacyTestData.ClientName + "_QA");
            }
            else
                ConnectionStringVar = ConnectionString3;

            PageObject_Search.Nav_Search().Click();
            SelectElement searchDropDown = new SelectElement(PageObject_Search.Search_Select());
            searchDropDown.SelectByValue("Profile");
            Search.ClearInputValues();
            IList<String> InputElements = new List<String>
                {
                    searchDropDown.SelectedOption.GetAttribute("value"),
                    "Profile",
                    profileID
                };

            Search.searchBy(Driver, InputElements);
            AddDelay(500);
            Search.VerifyIDSearchResults(Driver, profileID, profileID);
            Search.clickFromSearchResults(Driver);
            Prompts.checkPromptsLoad(Driver, wait);

            p = SqlWarehouseQuery.GetPromptRules();

            string promptDB = Prompts.FindRule("Welcome back", p);
            string promptUI = Prompts.GetDisplayPrompt("welcome");
            Prompts.VerifyPromptMatch(promptDB, promptUI);
        }
        public static void TC_242789()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            List<PromptsRules> p = new List<PromptsRules>();

            if (LegacyTestData.FrontEndURL != null && LegacyTestData.ClientName != null)
            {
                ConnectionStringVar = ConnectionString3.Replace("PromptOrigami_QA", "Prompt" + LegacyTestData.ClientName + "_QA");
            }
            else
                ConnectionStringVar = ConnectionString3;

            PageObject_Search.Nav_Search().Click();
            SelectElement searchDropDown = new SelectElement(PageObject_Search.Search_Select());
            searchDropDown.SelectByValue("Profile");
            Search.ClearInputValues();
            IList<String> InputElements = new List<String>
                {
                    searchDropDown.SelectedOption.GetAttribute("value"),
                    "Profile",
                    profileID
                };

            Search.searchBy(Driver, InputElements);
            AddDelay(500);
            Search.VerifyIDSearchResults(Driver, profileID, profileID);
            Search.clickFromSearchResults(Driver);
            Prompts.checkPromptsLoad(Driver, wait);

            p = SqlWarehouseQuery.GetPromptRules();

            string promptDB = Prompts.FindRule("Email Collection", p);
            string promptUI = Prompts.GetDisplayPrompt("email");
            Prompts.VerifyPromptMatch(promptDB, promptUI);
        }
        public static void TC_242812()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            List<PromptsRules> p = new List<PromptsRules>();

            if (LegacyTestData.FrontEndURL != null && LegacyTestData.ClientName != null)
            {
                ConnectionStringVar = ConnectionString3.Replace("PromptOrigami_QA", "Prompt" + LegacyTestData.ClientName + "_QA");
            }
            else
                ConnectionStringVar = ConnectionString3;

            PageObject_Search.Nav_Search().Click();
            SelectElement searchDropDown = new SelectElement(PageObject_Search.Search_Select());
            searchDropDown.SelectByValue("Profile");
            Search.ClearInputValues();
            IList<String> InputElements = new List<String>
                {
                    searchDropDown.SelectedOption.GetAttribute("value"),
                    "Profile",
                    profileID
                };

            Search.searchBy(Driver, InputElements);
            AddDelay(500);
            Search.VerifyIDSearchResults(Driver, profileID, profileID);
            string profileEmail = Search.getEmailFromSearch(Driver, profileID);
            Search.clickFromSearchResults(Driver);
            Prompts.checkPromptsLoad(Driver, wait);

            p = SqlWarehouseQuery.GetPromptRules();

            string promptDB = Prompts.FindRule("Email Verification", p);
            string promptUI = Prompts.GetDisplayPrompt("email");
            Prompts.VerifyPromptMatch(promptDB, promptUI, profileEmail);
            string testemail = SqlWarehouseQuery.ReturnGetTestDataValue(TestCaseId, "Email"); ;//"test123@cendyn17.com";
                                                             //check text box 
            IWebElement promptDiv = Prompts.GetDisplayPromptDiv("email");
            Prompts.enterEmail(promptDiv, testemail);
            AddDelay(500);
            Dictionary<string, string> ResponseFromDb = SqlWarehouseQuery.GetPromptResponses(ProjectName);
            string sourceProfileID = ResponseFromDb.Keys.ElementAt(0);
            PromptsResponses responsefromDB = SqlWarehouseQuery.GetPromptSavedResponse(ProjectName, sourceProfileID);

            Prompts.VerifyPromptsResponseSavedDB(testemail, responsefromDB);
        }
        public static void TC_243245()
        {
            if (LegacyTestData.FrontEndURL != null && LegacyTestData.ClientName != null)
            {
                ConnectionStringVar = ConnectionString3.Replace("PromptOrigami_QA", "Prompt" + LegacyTestData.ClientName + "_QA");
            }
            else
                ConnectionStringVar = ConnectionString3;

            PageObject_Search.Nav_Search().Click();
            SelectElement searchDropDown = new SelectElement(PageObject_Search.Search_Select());
            searchDropDown.SelectByValue("Profile");
            Search.ClearInputValues();
            //SqlWarehouseQuery.get
            IList<String> InputElements = new List<String>
                {
                    searchDropDown.SelectedOption.GetAttribute("value"),
                    "Profile",
                    profileID
                };

            Search.searchBy(Driver, InputElements);
            AddDelay(500);
            Search.VerifyIDSearchResults(Driver, profileID, profileID);
            Search.clickFromSearchResults(Driver);
            //Prompts.checkPromptsLoad(Driver, wait);
            Helper.ElementWait(PageObject_Prompts.Prompts_Container(),180);
            string ResponseClicked = Prompts.addPromptsResponse(Driver);
            Dictionary<string, string> ResponseFromDb = SqlWarehouseQuery.GetPromptResponses(ProjectName);

            PageObject_Search.Nav_Search().Click();
            searchDropDown.SelectByValue("Profile");
            Search.ClearInputValues();
            Search.searchBy(Driver, InputElements);
            Search.clickFromSearchResults(Driver);
            Prompts.checkSavedResponse(profileID, ResponseClicked, ResponseFromDb);
        }
        #endregion[TP_242772]

    }
}
