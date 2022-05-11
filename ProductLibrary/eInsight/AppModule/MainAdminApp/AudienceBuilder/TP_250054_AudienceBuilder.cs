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
        //static string CompanyName = SqlWarehouseQuery.ReturnCompanyName("", "CompanyName", TestPlanId);
        //static string clientName = SqlWarehouseQuery.ReturnCompanyName("", "clientName", TestPlanId);
        static string dynamicCriteriaJSON = "";
        static string email = "";

        #region[TP_250054]

        public static void TC_238356()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();

            audienceName = SqlWarehouseQuery.ReturnCompanyName(TestCaseId, "AudienceName");

            Navigation.MenuNavigation("AudienceBuilder");

            SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastSaved", 1, 1, audienceName);
            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);

            AudienceBuilder.Click_ABGrid_LastSaved();
            Logger.WriteDebugMessage("Clicked on Saved Tab.");

            ElementClick(Driver.FindElement(By.Id("btnActions")));
            Logger.WriteDebugMessage("Clicked on Actions Button");
            ElementClick(Driver.FindElement(By.Id("btnEdit")));
            Logger.WriteDebugMessage("Clicked on Actions Button");

            AddDelay(20000);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            ((IJavaScriptExecutor)Driver).ExecuteScript("scroll(0,-5000)");
            if (VerifyTextOnPage("You do not have permission to modify criteria."))
            {
                Logger.WriteDebugMessage("Verified prompt is displaying: You do not have permission to modify criteria.");
            }
            else
            {
                Assert.Fail("Couldn't find prompt message: You do not have permission to modify criteria.");
            }
        }
        public static void TC_238749()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();

            //Profile.SelectClient(CompanyName);
            Profile.SelectSubClient(clientName);
            Logger.WriteDebugMessage("Selected Company " + CompanyName);

            Navigation.MenuNavigation("AudienceBuilder");
            ScrollDown();
            if (Driver.FindElement(By.XPath("//button[@id='btnPublished']")).GetAttribute("class").Contains("active"))
            {
                ElementClick(Driver.FindElement(By.XPath("//button[@id='btnSaved']")));
                Logger.WriteDebugMessage("Landed on Saved - Audience List.");

                SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastPublished", 1, 0, "");
                ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), builderData.AudienceName);
                AudienceBuilder.Click_SearchButton();
                Logger.WriteDebugMessage("Searched for the Audiennce: " + builderData.AudienceName);
                AddDelay(20000);

                ElementClick(Driver.FindElement(By.XPath("//button[@id='btnPublished']")));
                Logger.WriteDebugMessage("Landed on Published - Audience List.");
            }
        }
        public static void TC_240347()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            audienceName = SqlWarehouseQuery.ReturnCompanyName("NA", "AudienceName", "TP_240125") + TestPlanId;
            dynamicCriteriaJSON = SqlWarehouseQuery.ReturnDescriptionValue("NA", "AudienceName", "TP_240125");
            email = LegacyTestData.CommonFrontendEmail;
            SqlWarehouseQuery.createAudience(CompanyName, builderData, audienceName, dynamicCriteriaJSON, email);

            if (builderData.AudienceDetailID == "1")
            {
                Logger.WriteInfoMessage("Audience Name " + audienceName + " already exist.");
            }
            else
            {
                Logger.WriteInfoMessage("Created a new Audience Name " + audienceName + " " + builderData.AudienceDetailID);
            }

            //Profile.SelectClient(CompanyName);
            Profile.SelectSubClient(clientName);

            Navigation.MenuNavigation("AudienceBuilder");


            Logger.WriteInfoMessage("Testing with LastPublished Search Criteria");
            #region[AudienceName]
            /* Test with Last Published*/

            SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastPublished", 1, 0);

            Logger.WriteDebugMessage("Landed on LastPublished Grid Table.");
            Logger.WriteInfoMessage("Searching for LastPublished Audience with Audience Name search Criteria");

            /* Search By - AudienceName and Search Expression: Equals */

            AudienceBuilder.Audience_SearchBy("Audience Name");
            AudienceBuilder.Audience_SearchByExpression("equals");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), builderData.AudienceName);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + builderData.AudienceName);
            AddDelay(20000);

            ScrollDown();

            if (VerifyTextOnPage(builderData.AudienceName))
            {
                Logger.WriteDebugMessage("Displayed " + builderData.AudienceName + " on the grid.");
            }


            ReloadPage();
            AddDelay(20000);

            /* Search By - AudienceName and Search Expression: Contains */

            Logger.WriteDebugMessage("Reloaded the page and back on Audience Grid Table.");
            Logger.WriteInfoMessage("Searching for LastPublished Audience with Audience Name search Criteria");
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            AudienceBuilder.Audience_SearchBy("Audience Name");
            AudienceBuilder.Audience_SearchByExpression("contains");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), builderData.AudienceName);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + builderData.AudienceName);
            AddDelay(20000);

            ScrollDown();

            if (VerifyTextOnPage(builderData.AudienceName))
            {
                Logger.WriteDebugMessage("Displayed " + builderData.AudienceName + " on the grid.");
            }

            ReloadPage();
            AddDelay(20000);

            /* Search By - AudienceName and Search Expression: Begins With */

            Logger.WriteDebugMessage("Reloaded the page and back on Audience Grid Table.");
            Logger.WriteInfoMessage("Searching for LastPublished Audience with Audience Name search Criteria");
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            AudienceBuilder.Audience_SearchBy("Audience Name");
            AudienceBuilder.Audience_SearchByExpression("startwith");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), builderData.AudienceName);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + builderData.AudienceName);
            AddDelay(20000);

            ScrollDown();

            if (VerifyTextOnPage(builderData.AudienceName))
            {
                Logger.WriteDebugMessage("Displayed " + builderData.AudienceName + " on the grid.");
            }

            ReloadPage();
            AddDelay(20000);

            /* Search By - AudienceName and Search Expression: End With */

            Logger.WriteDebugMessage("Reloaded the page and back on Audience Grid Table.");
            Logger.WriteInfoMessage("Searching for LastPublished Audience with Audience Name search Criteria");
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            AudienceBuilder.Audience_SearchBy("Audience Name");
            AudienceBuilder.Audience_SearchByExpression("endwith");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), builderData.AudienceName);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + builderData.AudienceName);
            AddDelay(20000);

            ScrollDown();

            if (VerifyTextOnPage(builderData.AudienceName))
            {
                Logger.WriteDebugMessage("Displayed " + builderData.AudienceName + " on the grid.");
            }

            ReloadPage();
            AddDelay(20000);
            #endregion[AudienceName]
            #region[Description]
            /* Description */
            /* Search By - Description and Search Expression: Equals */
            Logger.WriteDebugMessage("Reloaded the page and back on Audience Grid Table.");
            Logger.WriteInfoMessage("Searching for LastPublished Audience with Audience Description search Criteria and Expression as Equals");
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            AudienceBuilder.Audience_SearchBy("Description");
            AudienceBuilder.Audience_SearchByExpression("equals");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), builderData.AudienceDescription);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + builderData.AudienceDescription + "for AudienceName :" + builderData.AudienceName);
            AddDelay(20000);

            ScrollDown();
            ElementClick(Driver.FindElement(By.XPath("//td[contains(text(), '" + builderData.AudienceName + "')]")));
            if (VerifyTextOnPage(builderData.AudienceDescription))
            {
                Logger.WriteDebugMessage("Displayed " + builderData.AudienceDescription + " on the grid.");
            }


            ReloadPage();
            AddDelay(20000);

            /* Search By - Description and Search Expression: Contains */

            Logger.WriteDebugMessage("Reloaded the page and back on Audience Grid Table.");
            Logger.WriteInfoMessage("Searching for LastPublished Audience with Audience Description search Criteria and Expression as Contains");
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            AudienceBuilder.Audience_SearchBy("Description");
            AudienceBuilder.Audience_SearchByExpression("contains");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), builderData.AudienceDescription);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + builderData.AudienceDescription + "for AudienceName :" + builderData.AudienceName);
            AddDelay(20000);

            ScrollDown();
            ElementClick(Driver.FindElement(By.XPath("//td[contains(text(), '" + builderData.AudienceName + "')]")));
            if (VerifyTextOnPage(builderData.AudienceDescription))
            {
                Logger.WriteDebugMessage("Displayed " + builderData.AudienceDescription + " on the grid.");
            }

            ReloadPage();
            AddDelay(20000);

            /* Search By - Description and Search Expression: Begins With */
            Logger.WriteDebugMessage("Reloaded the page and back on Audience Grid Table.");
            Logger.WriteInfoMessage("Searching for LastPublished Audience with Audience Description search Criteria and Expression as Begins With");
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            AudienceBuilder.Audience_SearchBy("Description");
            AudienceBuilder.Audience_SearchByExpression("startwith");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), builderData.AudienceDescription);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + builderData.AudienceDescription);
            AddDelay(20000);

            ScrollDown();
            ElementClick(Driver.FindElement(By.XPath("//td[contains(text(), '" + builderData.AudienceName + "')]")));
            if (VerifyTextOnPage(builderData.AudienceDescription))
            {
                Logger.WriteDebugMessage("Displayed " + builderData.AudienceDescription + " on the grid.");
            }

            ReloadPage();
            AddDelay(20000);

            /* Search By - Description and Search Expression: Ends With */
            Logger.WriteDebugMessage("Reloaded the page and back on Audience Grid Table.");
            Logger.WriteInfoMessage("Searching for LastPublished Audience with Audience Description search Criteria and Expression as Ends With");
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            AudienceBuilder.Audience_SearchBy("Description");
            AudienceBuilder.Audience_SearchByExpression("endwith");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), builderData.AudienceDescription);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + builderData.AudienceDescription);
            AddDelay(20000);

            ScrollDown();
            ElementClick(Driver.FindElement(By.XPath("//td[contains(text(), '" + builderData.AudienceName + "')]")));
            if (VerifyTextOnPage(builderData.AudienceDescription))
            {
                Logger.WriteDebugMessage("Displayed " + builderData.AudienceDescription + " on the grid.");
            }

            ReloadPage();
            AddDelay(20000);
            #endregion[Description]
            #region[CreatedBy]
            /* Created By */
            /* Search By - Created By and Search Expression: Equals */
            Logger.WriteDebugMessage("Reloaded the page and back on Audience Grid Table.");
            Logger.WriteInfoMessage("Searching for LastPublished Audience with Audience Created By search Criteria and Expression as Equals");
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            AudienceBuilder.Audience_SearchBy("Created By");
            AudienceBuilder.Audience_SearchByExpression("equals");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), builderData.InsertedByUser);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + builderData.InsertedByUser);
            AddDelay(20000);

            ScrollDown();
            if (VerifyTextOnPage(builderData.InsertedByUser))
            {
                Logger.WriteDebugMessage("Displayed " + builderData.InsertedByUser + " on the grid.");
            }

            ReloadPage();
            AddDelay(20000);

            /* Search By - Created By and Search Expression: Contains */
            Logger.WriteDebugMessage("Reloaded the page and back on Audience Grid Table.");
            Logger.WriteInfoMessage("Searching for LastPublished Audience with Audience Created By search Criteria and Expression as Contains");
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            AudienceBuilder.Audience_SearchBy("Created By");
            AudienceBuilder.Audience_SearchByExpression("contains");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), builderData.InsertedByUser);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + builderData.InsertedByUser);
            AddDelay(20000);

            ScrollDown();

            if (VerifyTextOnPage(builderData.InsertedByUser))
            {
                Logger.WriteDebugMessage("Displayed " + builderData.InsertedByUser + " on the grid.");
            }

            ReloadPage();
            AddDelay(20000);
            /* Search By - Created By and Search Expression: Begins With */
            Logger.WriteDebugMessage("Reloaded the page and back on Audience Grid Table.");
            Logger.WriteInfoMessage("Searching for LastPublished Audience with Audience Created By search Criteria and Expression as Begins With");
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            AudienceBuilder.Audience_SearchBy("Created By");
            AudienceBuilder.Audience_SearchByExpression("startwith");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), builderData.InsertedByUser);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + builderData.InsertedByUser);
            AddDelay(20000);

            ScrollDown();

            if (VerifyTextOnPage(builderData.InsertedByUser))
            {
                Logger.WriteDebugMessage("Displayed " + builderData.InsertedByUser + " on the grid.");
            }

            ReloadPage();
            AddDelay(20000);

            /* Search By - Created By and Search Expression: Ends With */
            Logger.WriteDebugMessage("Reloaded the page and back on Audience Grid Table.");
            Logger.WriteInfoMessage("Searching for LastPublished Audience with Audience Created By search Criteria and Expression as Ends With");
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            AudienceBuilder.Audience_SearchBy("Created By");
            AudienceBuilder.Audience_SearchByExpression("endwith");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), builderData.InsertedByUser);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + builderData.InsertedByUser);
            AddDelay(20000);

            ScrollDown();

            if (VerifyTextOnPage(builderData.InsertedByUser))
            {
                Logger.WriteDebugMessage("Displayed " + builderData.InsertedByUser + " on the grid.");
            }

            ReloadPage();
            AddDelay(20000);
            #endregion[CreatedBy]
            #region[ModifiedBy]
            /* Modified By */
            /* Search By - Modified By and Search Expression: Equals */
            Logger.WriteDebugMessage("Reloaded the page and back on Audience Grid Table.");
            Logger.WriteInfoMessage("Searching for LastPublished Audience with Audience Modified By search Criteria and Expression as Equals");
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            AudienceBuilder.Audience_SearchBy("Modified By");
            AudienceBuilder.Audience_SearchByExpression("equals");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), builderData.UpdatedBy);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + builderData.UpdatedBy);
            AddDelay(20000);

            ScrollDown();
            if (VerifyTextOnPage(builderData.UpdatedBy))
            {
                Logger.WriteDebugMessage("Displayed " + builderData.UpdatedBy + " on the grid.");
            }

            ReloadPage();
            AddDelay(20000);

            /* Search By - Modified By and Search Expression: Contains */
            Logger.WriteDebugMessage("Reloaded the page and back on Audience Grid Table.");
            Logger.WriteInfoMessage("Searching for LastPublished Audience with Audience Modified By search Criteria and Expression as Equals");
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            AudienceBuilder.Audience_SearchBy("Modified By");
            AudienceBuilder.Audience_SearchByExpression("contains");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), builderData.UpdatedBy);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + builderData.UpdatedBy);
            AddDelay(20000);

            ScrollDown();

            if (VerifyTextOnPage(builderData.UpdatedBy))
            {
                Logger.WriteDebugMessage("Displayed " + builderData.UpdatedBy + " on the grid.");
            }

            ReloadPage();
            AddDelay(20000);

            /* Search By - Modified By and Search Expression: Begins With */
            Logger.WriteDebugMessage("Reloaded the page and back on Audience Grid Table.");
            Logger.WriteInfoMessage("Searching for LastPublished Audience with Audience Modified By search Criteria and Expression as Begins With");
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            AudienceBuilder.Audience_SearchBy("Modified By");
            AudienceBuilder.Audience_SearchByExpression("startwith");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), builderData.UpdatedBy);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + builderData.UpdatedBy);
            AddDelay(20000);

            ScrollDown();

            if (VerifyTextOnPage(builderData.UpdatedBy))
            {
                Logger.WriteDebugMessage("Displayed " + builderData.UpdatedBy + " on the grid.");
            }

            ReloadPage();
            AddDelay(20000);
            /* Search By - Modified By and Search Expression: Ends With */
            Logger.WriteDebugMessage("Reloaded the page and back on Audience Grid Table.");
            Logger.WriteInfoMessage("Searching for LastPublished Audience with Audience Modified By search Criteria and Expression as Begins With");
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            AudienceBuilder.Audience_SearchBy("Modified By");
            AudienceBuilder.Audience_SearchByExpression("endwith");

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), builderData.UpdatedBy);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + builderData.UpdatedBy);
            AddDelay(20000);

            ScrollDown();

            if (VerifyTextOnPage(builderData.UpdatedBy))
            {
                Logger.WriteDebugMessage("Displayed " + builderData.UpdatedBy + " on the grid.");
            }

            ReloadPage();
            AddDelay(20000);
            #endregion[ModifiedBy]
            #region[Tags]
            /*Tags with SearchExpression Equals*/
            Logger.WriteDebugMessage("Reloaded the page and back on Audience Grid Table.");
            Logger.WriteInfoMessage("Searching for LastPublished Audience with Audience Modified By search Criteria and Expression as Begins With");
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            AudienceBuilder.Audience_SearchBy("Tags");
            AudienceBuilder.Audience_SearchByExpression("equals");

            AudienceBuilder.AB_Search_EnterTextTags(audienceName);
            ElementClick(Driver.FindElement(By.XPath("//h2[contains(text(), 'Audience List')]")));
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce having specific tags added in Search Filter.");
            AddDelay(20000);

            ScrollDown();
            if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]"))))
            {
                Logger.WriteDebugMessage("Displayed " + audienceName + " on the grid.");
            }
            else
            {
                Assert.Fail("Cannot find tags equals to " + audienceName);
            }

            ReloadPage();
            AddDelay(20000);
            /*Tags with SearchExpression Contains*/
            Logger.WriteDebugMessage("Reloaded the page and back on Audience Grid Table.");
            Logger.WriteInfoMessage("Searching for LastPublished Audience with Audience Modified By search Criteria and Expression as Begins With");
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            AudienceBuilder.Audience_SearchBy("Tags");
            AudienceBuilder.Audience_SearchByExpression("contains");

            AudienceBuilder.AB_Search_EnterTextTags(audienceName);
            ElementClick(Driver.FindElement(By.XPath("//h2[contains(text(), 'Audience List')]")));
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce having specific tags added in Search Filter.");
            AddDelay(20000);

            ScrollDown();

            if (IsElementVisible(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + TestPlanId + "')]"))))
            {
                Logger.WriteDebugMessage("Displayed " + TestPlanId + " on the grid.");
            }
            else
            {
                Assert.Fail("Cannot find tags contains to " + TestPlanId);
            }
            ReloadPage();
            AddDelay(20000);
            #endregion[Tags]
            #region[Property]
            /* Property(s) with Seach Filter Equals */
            string propertyName = "";
            if (testCategory == "QA")
            {
                propertyName = "Ocean Properties Ltd - OPAL - Delray Sands Resort on Highland Beach";
            }
            else
            {
                propertyName = "Hotel Origami Miami Beach";
            }
            
            Logger.WriteDebugMessage("Reloaded the page and back on Audience Grid Table.");
            Logger.WriteInfoMessage("Searching for LastPublished Audience with Audience Modified By search Criteria and Expression as Begins With");
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            AudienceBuilder.Audience_SearchBy("Property(s)");
            AudienceBuilder.Audience_SearchByExpression("equals");

            AudienceBuilder.AB_Search_EnterProperties(propertyName);
            ElementClick(Driver.FindElement(By.XPath("//h2[contains(text(), 'Audience List')]")));
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce having specific tags added in Search Filter.");
            AddDelay(20000);

            ScrollDown();

            if (VerifyTextOnPage(propertyName))
            {
                Logger.WriteDebugMessage("Displayed "+ propertyName + " on the grid.");
            }
            else
            {
                Assert.Fail("Cannot find Property Equals to " + builderData.PropertyName);
            }
            ReloadPage();
            AddDelay(20000);
            /* Property(s) with Seach Filter Contains */
            Logger.WriteDebugMessage("Reloaded the page and back on Audience Grid Table.");
            Logger.WriteInfoMessage("Searching for LastPublished Audience with Audience Modified By search Criteria and Expression as Begins With");
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            AudienceBuilder.Audience_SearchBy("Property(s)");
            AudienceBuilder.Audience_SearchByExpression("contains");

            if (testCategory == "QA")
            {
                AudienceBuilder.AB_Search_EnterProperties("Delray Sands Resort on Highland Beach");
            }
            else
            {
                AudienceBuilder.AB_Search_EnterProperties("Origami Miami Beach");
            }
            
            ElementClick(Driver.FindElement(By.XPath("//h2[contains(text(), 'Audience List')]")));
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce having specific tags added in Search Filter.");
            AddDelay(20000);

            ScrollDown();
            if (VerifyTextOnPage(propertyName))
            {
                Logger.WriteDebugMessage("Displayed "+ propertyName +" on the grid.");
            }
            else
            {
                Assert.Fail("Cannot find Property contains to Edgewater Beach Hotel");
            }

            ReloadPage();
            AddDelay(20000);
            #endregion[Property]
        }
        public static void TC_240407()
        {
            string audienceName = SqlWarehouseQuery.ReturnCompanyName("NA", "AudienceName", "TP_240125") + TestPlanId;
            string dynamicCriteriaJSON = SqlWarehouseQuery.ReturnDescriptionValue("NA", "AudienceName", "TP_240125");
            string email = LegacyTestData.CommonFrontendEmail;
            AudienceBuilderData builderData = new AudienceBuilderData();
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

            ClientdbConnection userData = new ClientdbConnection();

            SqlWarehouseQuery.GetAssignedCompanyFromUser(userData, LegacyTestData.CommonFrontendEmail);

            Logger.WriteInfoMessage(LegacyTestData.CommonFrontendEmail + " have access " + userData.CompanyName);

            Navigation.MenuNavigation("AudienceBuilder");

            SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastPublished", 1, 1, audienceName);

            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            Logger.WriteDebugMessage("Landed on Details.");

            string[] eachAudienceProp = Regex.Split(builderData.AudiencePropertyName, ",");
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            AddDelay(25000);
            Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//iFrame[contains(@src, '/legacy/criteria/preview.html')]")));
            foreach (string audienceProperty in eachAudienceProp)
            {
                string eachaudienceProperty = audienceProperty.Trim().ToString();
                //ScrollToElement(Driver.FindElement(By.XPath("//*[contains(text(),'" + audienceProperty + "')]")));
                ScrollToElement(Driver.FindElement(By.XPath("(//span[@class='project-property-pool']//*[contains(text(),'"+ eachaudienceProperty + "')])[1]")));
                Logger.WriteDebugMessage("Found PropertyName " + eachaudienceProperty + " for Audiuence Name - " + audienceName);
                //RemoveHighlightElement(Driver.FindElement(By.XPath("(//span[@class='project-property-pool']//*[contains(text(),'" + audienceProperty + "')])[1]")));
            }
        }
        public static void TC_240408()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            String values;
            //Profile.SelectClient(CompanyName);
            Profile.SelectSubClient(clientName);

            //Logger.WriteDebugMessage("Selected Company " + CompanyName);

            Navigation.MenuNavigation("AudienceBuilder");

            SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastSaved", 1, 0);
            ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), builderData.AudienceName);
            AudienceBuilder.Click_ABGrid_LastSaved();
            AudienceBuilder.Click_SearchButton();
            Logger.WriteDebugMessage("Searched for the Audiennce: " + builderData.AudienceName);

            Logger.WriteDebugMessage("Clicked on Saved Tab.");

            ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
            Logger.WriteDebugMessage("Expanded Audience to check on other details.");

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(0);
            AddDelay(25000);
            Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//div[@id='criteriaPreviewContainer1']/iFrame[contains(@src, '/legacy/criteria/preview.html')]")));
            string[] eachAudienceProp = Regex.Split(builderData.AudiencePropertyName, ",");
            foreach (string audienceProperty in eachAudienceProp)
            {
                string eachaudienceProperty = audienceProperty.Trim().ToString();
                //ScrollToElement(Driver.FindElement(By.XPath("//*[contains(text(),'" + audienceProperty + "')]")));
                if (IsElementPresent(By.XPath("//*[contains(text(), '"+ eachaudienceProperty + "')]")))
                {
                    Logger.WriteDebugMessage("Found PropertyName " + eachaudienceProperty + " for Audiuence Name - " + builderData.AudienceName);
                }
                else
                {
                    Assert.Fail("Could find Property - " + eachaudienceProperty);
                }
                
                //RemoveHighlightElement(Driver.FindElement(By.XPath("(//span[@class='project-property-pool']//*[contains(text(),'" + audienceProperty + "')])[1]")));
            }
        }
        public static void TC_240431()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            audienceName = SqlWarehouseQuery.ReturnCompanyName("NA", "AudienceName", "TP_240125") + TestPlanId;
            dynamicCriteriaJSON = SqlWarehouseQuery.ReturnDescriptionValue("NA", "AudienceName", "TP_240125");
            email = LegacyTestData.CommonFrontendEmail;
            SqlWarehouseQuery.createAudience(CompanyName, builderData, audienceName, dynamicCriteriaJSON, email);

            if (builderData.AudienceDetailID == "1")
            {
                Logger.WriteInfoMessage("Audience Name " + audienceName + " already exist.");
            }
            else
            {
                Logger.WriteInfoMessage("Created a new Audience Name " + audienceName + " " + builderData.AudienceDetailID);
            }

            //Profile.SelectClient(CompanyName);
            Profile.SelectSubClient(clientName);
            // Logger.WriteDebugMessage("Selected Company " + CompanyName);

            Navigation.MenuNavigation("AudienceBuilder");

            AudienceBuilder.Click_ABGrid_LastSaved();
            Logger.WriteDebugMessage("Clicked on Saved Tab.");

            if (PageObject_AudienceBuilder.AB_Grid_LastSaved().GetAttribute("class").Contains("active"))
            {
                Logger.WriteDebugMessage("Landed on LastSaved Grid Table.");
                Logger.WriteInfoMessage("Searching for LastSaved Audience");

                ElementEnterText(Driver.FindElement(By.XPath("(//input[@id='fldValue'])[1]")), audienceName);
                AudienceBuilder.Click_SearchButton();
                Logger.WriteDebugMessage("Searched for the Audiennce: " + audienceName);
                AddDelay(20000);

                ElementClick(Driver.FindElement(By.Id("btnActions")));
                Logger.WriteDebugMessage("Clicked on Actions Button");
                ElementClick(Driver.FindElement(By.Id("btnEdit")));
                Logger.WriteDebugMessage("Clicked on Actions Button");

                AddDelay(20000);
                Driver.SwitchTo().DefaultContent();
                Driver.SwitchTo().Frame(0);
                if (VerifyTextOnPage("You do not have permission to modify criteria."))
                {
                    Logger.WriteDebugMessage("I do not have permission to modify and save and publish audience.");
                }
                else
                {
                    ElementWait(Driver.FindElement(By.XPath("//button[contains(text(), 'Save & Publish')]")), 120);
                    ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Save')]")));
                    Logger.WriteDebugMessage("Clicked on Savebutton.");
                    AddDelay(20000);
                }
                
                ElementClick(Driver.FindElement(By.XPath("//*[@id='titleHeader']/div/a/i")));
                Driver.SwitchTo().DefaultContent();
                Driver.SwitchTo().Frame(0);

                SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastPublished", 1, 1, audienceName);

                ScrollDown();

                AudienceBuilder.Click_ABGrid_LastPublished();
                Logger.WriteDebugMessage("Clicked on Published Tab.");

                var longdate_createdDate = Convert.ToDateTime(builderData.InsertedOn).ToString("M/d/yyyy hh:mm:ss tt");
                var longdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy hh:mm:ss tt");
                var shortdate_createdDate = Convert.ToDateTime(builderData.InsertedOn).ToString("M/d/yyyy hh:mm tt");
                var shortdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy hh:mm tt");
                ElementClick(Driver.FindElement(By.XPath("//div[@class='card-body']/following::*[contains(text(), '" + audienceName + "')]")));
                if (VerifyTextOnPage(shortdate_createdDate) && VerifyTextOnPage(shortdate_updateDate))
                {
                    
                    Logger.WriteDebugMessage("Checked last saved details for \n" + " AudienceName: " + builderData.AudienceName + "\n UpdatedDate: " + shortdate_createdDate + "\n UpdatedBy: " + shortdate_updateDate);
                }
                else
                {
                    Assert.Fail("Did not find one of the data.");
                }

                ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
                if (VerifyTextOnPage(shortdate_updateDate))
                {
                    Logger.WriteDebugMessage("Checked : \n" + "\n SavedDate: " + shortdate_updateDate + "\n ");
                }
                else
                {
                    Assert.Fail("Did not find one of the data.");
                }

            }
        }
        public static void TC_240432()
        {
            AudienceBuilderData builderData = new AudienceBuilderData();
            audienceName = SqlWarehouseQuery.ReturnCompanyName("NA", "AudienceName", "TP_240125") + TestPlanId;
            dynamicCriteriaJSON = SqlWarehouseQuery.ReturnDescriptionValue("NA", "AudienceName", "TP_240125");
            email = LegacyTestData.CommonFrontendEmail;
            SqlWarehouseQuery.createAudience(CompanyName, builderData, audienceName, dynamicCriteriaJSON, email);

            if (builderData.AudienceDetailID == "1")
            {
                Logger.WriteInfoMessage("Audience Name " + audienceName + " already exist.");
            }
            else
            {
                Logger.WriteInfoMessage("Created a new Audience Name " + audienceName + " " + builderData.AudienceDetailID);
            }

            //Profile.SelectClient(CompanyName);
            Profile.SelectSubClient(clientName);
            Logger.WriteDebugMessage("Selected Company " + CompanyName);

            Navigation.MenuNavigation("AudienceBuilder");
            AudienceBuilder.Click_ABGrid_LastSaved();

            if (PageObject_AudienceBuilder.AB_Grid_LastSaved().GetAttribute("class").Contains("active"))
            {
                Logger.WriteDebugMessage("Landed on Saved Tab");
                Logger.WriteInfoMessage("Searching for Last Saved Audience");

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
                ElementWait(Driver.FindElement(By.XPath("//button[contains(text(), 'Save & Publish')]")), 120);
                ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
                ElementClick(Driver.FindElement(By.XPath("(//input[@type='text'])[3]")));
                Driver.FindElement(By.XPath("(//input[@type='text'])[3]")).SendKeys(Keys.Enter);
                Logger.WriteDebugMessage("Added Property List.");
                ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Save')]")));
                Logger.WriteDebugMessage("Clicked on Save button.");

                ElementClick(Driver.FindElement(By.XPath("//*[@id='titleHeader']/div/a/i")));
                Driver.SwitchTo().DefaultContent();
                Driver.SwitchTo().Frame(0);

                SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastPublished", 1, 1, audienceName);

                var longdate_createdDate = Convert.ToDateTime(builderData.InsertedOn).ToString("M/d/yyyy hh:mm:ss tt");
                var longdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy hh:mm:ss tt");
                var shortdate_createdDate = Convert.ToDateTime(builderData.InsertedOn).ToString("M/d/yyyy hh:mm tt");
                var shortdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy hh:mm tt");

                ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
                ElementClick(Driver.FindElement(By.XPath("(//button[@id='btnSaved'])[1]")));

                string getLastSavedinPublished = Driver.FindElement(By.XPath("//*[@id='summaryContent']/div/div[2]/div[3]/div/div/div/div[1]")).Text;
                string getLastPublishedinPublished = Driver.FindElement(By.XPath("//*[@id='summaryContent']/div/div[2]/div[4]/div/div/div/div[1]")).Text;

                if (getLastPublishedinPublished == shortdate_updateDate)
                {
                    Logger.WriteDebugMessage("Checked : \n" + "\n LastPublishedDate: " + shortdate_updateDate);
                }
                else
                {
                    Assert.Fail("Did not find one of the data.");
                }

                /*240432*/
                Logger.WriteInfoMessage("Starting TC_240432");
                ElementClick(Driver.FindElement(By.XPath("//*[contains(text(), 'Manage Audiences')]")));
                Logger.WriteDebugMessage("Landed on Manage Audience");

                AudienceBuilder.Click_ABGrid_LastPublished();
                Logger.WriteDebugMessage("Landed on Published Tab");

                AddDelay(20000);

                ElementClick(Driver.FindElement(By.Id("btnActions")));
                Logger.WriteDebugMessage("Clicked on Actions Button");
                ElementClick(Driver.FindElement(By.Id("btnEdit")));
                Logger.WriteDebugMessage("Clicked on Edit Button");

                AddDelay(20000);
                if(IsElementPresent(By.XPath("//button[contains(text(), 'Edit')]")))
                {
                    Logger.WriteDebugMessage("Landed on Edit/Cancel Page to edit published audience. ");
                    ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Edit')]")));
                }
                
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

                ElementClick(Driver.FindElement(By.XPath("//*[@id='titleHeader']/div/a/i")));
                Driver.SwitchTo().DefaultContent();
                Driver.SwitchTo().Frame(0);

                SqlWarehouseQuery.GetAudienceDetails(builderData, CompanyName, "LastPublished", 1, 1, audienceName);

                longdate_createdDate = Convert.ToDateTime(builderData.InsertedOn).ToString("M/d/yyyy hh:mm:ss tt");
                longdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy hh:mm:ss tt");
                shortdate_createdDate = Convert.ToDateTime(builderData.InsertedOn).ToString("M/d/yyyy hh:mm tt");
                shortdate_updateDate = Convert.ToDateTime(builderData.UpdatedOn).ToString("M/d/yyyy hh:mm tt");

                ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Details')]")));
                ElementClick(Driver.FindElement(By.XPath("(//button[@id='btnPublished'])[1]")));

                getLastSavedinPublished = Driver.FindElement(By.XPath("//*[@id='summaryContent']/div/div[2]/div[3]/div/div/div/div[1]")).Text;
                getLastPublishedinPublished = Driver.FindElement(By.XPath("//*[@id='summaryContent']/div/div[2]/div[4]/div/div/div/div[1]")).Text;
                if (VerifyTextOnPage("Audience counts are ready. Refresh the page?"))
                {
                    ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Yes')]")));
                }
                if (getLastPublishedinPublished == shortdate_updateDate)
                {
                    Logger.WriteDebugMessage("Checked : \n" + "\n LastPublishedDate: " + shortdate_updateDate);
                }
                else
                {
                    Assert.Fail("Did not find one of the data.");
                }

            }
        }
        #endregion[TP_250054]

    }
}
