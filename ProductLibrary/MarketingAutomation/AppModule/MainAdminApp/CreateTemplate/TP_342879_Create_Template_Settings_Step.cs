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
        #region[TP_342879]

        public static void TC_335991()
        {
            if (TestCaseId == Constants.TC_335991)
            {
                //Variables declaration and object creation
                string name, description;
                Template data = new Template();

                //Read the data
                name = TestData.ExcelData.TestDataReader.ReadData(1, "name");
                description = TestData.ExcelData.TestDataReader.ReadData(2, "description");

                //Step1: Navigate to Marketing Automation and log in as a valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //Expected: User should land on Marketing Automation.
                Navigation.Verify_LandsOnMAPage();

                //Step2: Click on Template from side navigation
                Navigation.ClickOnSidebarTemplates();
                Logger.WriteDebugMessage("User lands on Manage Template page");

                //Step3: Click on create template
                CreateTemplate.ClickOnCreateTemplate();
                Logger.WriteDebugMessage("User lands on Setting page");

                //Step4: Enter Template Name
                name = name + Helper.GetRandomNumber(2);
                CreateTemplate.EnterTemplateName(name);
                Logger.WriteDebugMessage("Template name should display");


                //Step5: Select any Tags from dropdown
                CreateTemplate.SelectAnyTemplateTagFromList();
                Logger.WriteDebugMessage("Tags should be selected");

                //Step6: Enter Description
                description = description + Helper.GetRandomNumber(2);
                CreateTemplate.EnterTemplateDesc(description);
                Logger.WriteDebugMessage("Description should display");

                //Step7: Enable View in Browser link
                CreateTemplate.EnableOrDisableViewInBrowserLinkUsingFlag(1);
                Logger.WriteDebugMessage("View in Browser link should enable");

                //Step8: Enable Unsubscribe link
                CreateTemplate.EnableOrDisableUnsubsribeLinkUsingFlag(1);
                Logger.WriteDebugMessage("Unsubscribe link should enable");

                //Step9: Click on Save & Continue
                CreateTemplate.ClickOnSaveAndContinue();
                Assert.IsTrue(Helper.IsElementDisplayed(PageObject_CreateTemplate.Create_Template_Design_Elements()), "User does not land on Design page");
                Logger.WriteDebugMessage("User lands on Design page");

                //Step 10: Click on Finish
                //New Template should be created
                //this is not implemented in the application

                //Step11: Verify Unsubscribe and BrowserLink field in TemplateVersion table when View in Browser 
                //and Unsubscribe link on Setting page is enabled
                CreateTemplate.VerifyUnsubscribeAndBrowserLinkValue(data, name, 1, 1);
                Logger.WriteInfoMessage(" Verify the fields in TemplateVersion table Unsubscribe should set to 1 BrowserLink should set to 1");
                }
            }

        public static void TC_335994()
        {
            if (TestCaseId == Constants.TC_335994)
            {
                //Variables declaration and object creation
                string name, description;
                Template data = new Template();

                //Read the data
                name = TestData.ExcelData.TestDataReader.ReadData(1, "name");
                description = TestData.ExcelData.TestDataReader.ReadData(2, "description");

                //Step1: Navigate to Marketing Automation and log in as a valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //Expected: User should land on Marketing Automation.
                Navigation.Verify_LandsOnMAPage();

                //Step2: Click on Template from side navigation
                Navigation.ClickOnSidebarTemplates();
                Logger.WriteDebugMessage("User lands on Manage Template page");

                //Step3: Click on create template
                CreateTemplate.ClickOnCreateTemplate();
                Logger.WriteDebugMessage("User lands on Setting page");

                //Step4: Enter Template Name
                name = name + Helper.GetRandomNumber(2);
                CreateTemplate.EnterTemplateName(name);
                Logger.WriteDebugMessage("Template name should display");


                //Step5: Select any Tags from dropdown
                CreateTemplate.SelectAnyTemplateTagFromList();
                Logger.WriteDebugMessage("Tags should be selected");

                //Step6: Enter Description
                description = description + Helper.GetRandomNumber(2);
                CreateTemplate.EnterTemplateDesc(description);
                Logger.WriteDebugMessage("Description should display");

                //Step7: Disable View in Browser link
                CreateTemplate.EnableOrDisableViewInBrowserLinkUsingFlag(0);
                Logger.WriteDebugMessage("View in Browser link should Disable ");

                //Step8: Disable Unsubscribe link
                CreateTemplate.EnableOrDisableUnsubsribeLinkUsingFlag(0);
                Logger.WriteDebugMessage("Unsubscribe link should Disable");

                //Step9: Click on Save & Continue
                CreateTemplate.ClickOnSaveAndContinue();
                Assert.IsTrue(Helper.IsElementDisplayed(PageObject_CreateTemplate.Create_Template_Design_Elements()), "User does not land on Design page");
                Logger.WriteDebugMessage("User lands on Design page");

                //Step 10: Click on Finish
                //New Template should be created
                //this is not implemented in the application

                //Step11: Verify Unsubscribe and BrowserLink field in TemplateVersion table when View in Browser
                //and Unsubscribe link on Setting page is Disabled
                CreateTemplate.VerifyUnsubscribeAndBrowserLinkValue(data, name, 0, 0);
                Logger.WriteInfoMessage(" Verify the fields in TemplateVersion table Unsubscribe should set to 0 BrowserLink should set to 0");
            }
        }
        #endregion[TP_342879]
    }
}