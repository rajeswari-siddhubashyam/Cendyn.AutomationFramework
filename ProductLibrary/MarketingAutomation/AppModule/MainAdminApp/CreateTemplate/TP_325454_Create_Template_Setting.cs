using MarketingAutomation.AppModule.UI;
using MarketingAutomation.Entity;
using MarketingAutomation.Utility;
using BaseUtility.Utility;
using InfoMessageLogger;
using NUnit.Framework;
using MarketingAutomation.PageObject.UI;
using OpenQA.Selenium;

namespace MarketingAutomation.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region[TP_325454]

        public static void TC_325458()
        {
            if (TestCaseId == Constants.TC_325458)
            {
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

                //Step4: Validate Name 
                CreateTemplate.Template_Create_Template_Name_Input();
                CreateTemplate.Create_Template_Name_red();
                Logger.WriteDebugMessage("Name Filed Displayed with red* ");

                //Step5: Validate Tags Field
                CreateTemplate.Template_Create_Template_Tag_Input_expansion();
                Logger.WriteDebugMessage("Tags field displayed");

                //Step6: Enter Description
                CreateTemplate.Template_Create_Template_desc_Input();
                Logger.WriteDebugMessage("Description field displayed");
                Helper.PageDown();

                //Step7: Enable View in Browser link
                CreateTemplate.EnableOrDisableViewInBrowserLinkUsingFlag(0);
                Logger.WriteDebugMessage("View in Browser link displayed");

                //Step8: Enable Unsubscribe link
                CreateTemplate.EnableOrDisableUnsubsribeLinkUsingFlag(0);
                Logger.WriteDebugMessage("Unsubscribe link displayed");
            }
        }

        public static void TC_325790()
        {
            if (TestCaseId == Constants.TC_325790)
            {
                //Variables declaration and object creation
                string name,html,CSS;
                Template data = new Template();

                //Read the data
                //name = TestData.ExcelData.TestDataReader.ReadData(1, "name");
                name = "Auto";
                html = "<div class=\"gjs - row\"> </ div > < div id = \"iguq\" > Automation testing verification </ div >";
                CSS = "* {box - sizing: border - box;}body {margin: 0;}.gjs - row{display: table;padding - top:10px;padding - right:10px;padding - bottom:10px;padding - left:10px;width: 100 %;}@media(max - width: 100 %){# iguq{padding: 10px;}}";

                //Step1: Navigate to Marketing Automation and log in as a valid user
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);

                //Expected: User should land on Marketing Automation.
                //Navigation.Verify_LandsOnMAPage();

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

                //Step9: Click on Save & Continue
                CreateTemplate.ClickOnSaveAndContinue();
                Assert.IsTrue(Helper.IsElementDisplayed(PageObject_CreateTemplate.Create_Template_Design_Elements()), "User does not land on Design page");
                Logger.WriteDebugMessage("User lands on Design page");

                
                ManageCampaign.Click_On_Code_Editor();
                IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
                js.ExecuteScript("arguments[0].innerText = 'Automation testing verification'", Driver.FindElement(By.XPath("//pre[@class=' CodeMirror-line ']/span")));
                //js.ExecuteScript("arguments[0].innerText = 'Automation testing'", Driver.FindElement(By.XPath("//pre[@class='CodeMirror-cursor']/span")));
                //ManageCampaign.Click_CSS();
                //IJavaScriptExecutor jj = (IJavaScriptExecutor)Driver;
                //jj.ExecuteScript("arguments[0].innerText = '* {box - sizing: border - box;}body {margin: 0;}.gjs - row{display: table;padding - top:10px;padding - right:10px;padding - bottom:10px;padding - left:10px;width: 100 %;}@media(max - width: 100 %){# iguq{padding: 10px;}}'", Driver.FindElement(By.XPath("//pre[@class=' CodeMirror -line ']/span")));
                ////Driver.FindElement(By.XPath("//*[@id="code - edit"]/div/div/div[3]/button[2]")).Click();
                //Helper.ScrollDown();
                ManageCampaign.Click_On_Code_Editor_Save_Button();

            }
    #endregion[TP_325454]
}
    }
}