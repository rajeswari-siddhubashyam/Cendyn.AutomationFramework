using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eInsight.PageObject.UI;
using OpenQA.Selenium;
using BaseUtility.Utility;
using InfoMessageLogger;
using SqlWarehouse;
using Common;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using DocumentFormat.OpenXml.Bibliography;
using SeleniumExtras.WaitHelpers;
using System.Xml.Linq;
using OpenQA.Selenium.Interactions;
using System.Threading;
using System.Drawing;
using OpenQA.Selenium.Interactions.Internal;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json.Linq;
using eInsight.Utility;
using System.Web;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Office.Interop.Word;
using DocumentFormat.OpenXml.Drawing.Charts;
using RazorEngine.Compilation.ImpromptuInterface.InvokeExt;

namespace eInsight.AppModule.UI
{
    class CreateCampaign : Helper
    {
        public static void CreateCampaign_Button_Save()
        {
            ElementClick(PageObject_CreateCampaign.CreateCampaign_Button_Save());
        }
        public static void CreateCampaign_Button_SaveandContinue()
        {
            AddDelay(3500);
            ElementClick(PageObject_CreateCampaign.CreateCampaign_Button_SaveandContinue());
            //ElementClick(PageObject_CreateCampaign.CreateCampaign_TemplateAndTestingPage_SaveandContinue());
        }
        public static void CreateCampaign_StatyOnPage()
        {
            AddDelay(2000);
            ElementClick(PageObject_CreateCampaign.CreateCampaign_StatyOnPage());
        }
        
        public static void CreateCampaign_Button_Continue()
        {
            ElementClick(PageObject_CreateCampaign.CreateCampaign_Button_Continue());
        }
        public static void CreateCampaign_Button_SaveandContinue_Submit()
        {
            ElementClick(PageObject_CreateCampaign.CreateCampaign_Button_SaveandContinue_Submit());
        }
        public static void Click_Tab_Criteria()
        {
            ElementClick(PageObject_CreateCampaign.CreateCampaign_Link_CriteriaTab());
        }

        public static void ClickOnTotalColumnFirstRecordAndGenerateCount()
        {
            ScrollDown(300, 0);
            ElementClick(PageObject_CreateCampaign.TotalColumnArrow());
            IList<IWebElement> loader = PageObject_CreateCampaign.TotalColumnLoader();
            foreach (var item in loader)
            {
                string value = item.GetAttribute("style");
                while (String.IsNullOrEmpty(value))
                {
                    AddDelay(1000);
                    loader = PageObject_CreateCampaign.TotalColumnLoader();
                }
            }
            ElementClick(PageObject_CreateCampaign.GenerateCount());
            IList<IWebElement> loader1 = PageObject_CreateCampaign.TotalColumnLoader();
            foreach (var item in loader1)
            {
                string value = item.GetAttribute("style");
                while (String.IsNullOrEmpty(value))
                {
                    AddDelay(1000);
                    loader1 = PageObject_CreateCampaign.TotalColumnLoader();
                    value = item.GetAttribute("style");
                }
            }
        }

        public static void Click_CreateCampaign_ForecastAudience()
        {
            ScrollUpUsingJavaScript(Driver, 500);
            ElementClick(PageObject_CreateCampaign.Click_CreateCampaign_ForecastAudience());
        }
        public static void Click_Tab_Template()
        {
            ElementClick(PageObject_CreateCampaign.CreateCampaign_Link_TemplateTab());
            ElementWait(PageObject_ManageCampaign.Button_Campaign_BasicValidationReport(), 60);
        }
        public static void Click_Tab_Testing()
        {
            ElementClick(PageObject_CreateCampaign.CreateCampaign_Link_TestingTab());
        }
        //public static void Click_Button_ProceedOnTestingTab()
        //{
        //    ElementClick(PageObject_CreateCampaign.CreateCampaign_TemplateAndTestingPage_SaveandContinue());
        //}

        public static void Click_Tab_Approval()
        {
            ElementClick(PageObject_CreateCampaign.CreateCampaign_Link_ApprovalTab());
        }

        public static void SelectTime()
        {
            DateTime time = DateTime.Now;
            time = time.AddMinutes(5);
            string hour = time.ToString("hh");
            string min = time.ToString("mm");
            string ampm = time.ToString("tt");
            ScrollToElement(PageObject_CreateCampaign.DropDown_Schedule_Hours());
            ElementSelectFromDropDown(PageObject_CreateCampaign.DropDown_Schedule_Hours(), hour);
            AddDelay(3500);
            ElementSelectFromDropDown(PageObject_CreateCampaign.DropDown_Schedule_Minutes(), min);
            AddDelay(3500);
            ElementSelectFromDropDown(PageObject_CreateCampaign.DropDown_Schedule_TimeType(), ampm);
            Logger.WriteDebugMessage("Added scheule time." + time.ToString("hh")+ ":" + time.Minute.ToString() + " " + time.ToString("tt"));
        }

        public static void Click_Tab_Schedule()
        {
            ElementClick(PageObject_CreateCampaign.CreateCampaign_Link_ScheduleTab());
        }
        public static void Click_Link_AMResorts()
        {
            ElementClick(PageObject_CreateCampaign.Link_AMResorts());
        }

        public static void Click_Link_()
        {
            ElementClick(PageObject_CreateCampaign.Link_());
        }

        public static void Click_Link_CendynHotel()
        {
            ElementClick(PageObject_CreateCampaign.Link_CendynHotel());
        }

        public static void Click_Link_CendynHotelResort()
        {
            ElementClick(PageObject_CreateCampaign.Link_CendynHotelResort());
        }

        public static void EnterText_Text_Filter(string text)
        {
            ElementEnterText(PageObject_CreateCampaign.Text_Filter(), text);
        }
        public static void SelectFromName(string value)
        {
            /*
            AddDelay(1500);
            PageObject_CreateCampaign.CreateCampaign_EditTemplate_FromName().Click();
            AddDelay(1000);
            PageObject_CreateCampaign.CreateCampaign_EditTemplate_FromName().SendKeys(value);
            AddDelay(10000);
            PageObject_CreateCampaign.CreateCampaign_EditTemplate_FromName().SendKeys(Keys.Enter);
            AddDelay(3000);

            Logger.WriteInfoMessage("Selected FromName as - " + value);
            */

            var mySelectElm = Driver.FindElement(By.Id("from"));
            var mySelect = new SelectElement(mySelectElm);
            mySelect.SelectByValue(value);
            Logger.WriteInfoMessage("Selected FromName as - " + value);
        }
        public static void SelectReplyEmail(string value)
        {
            var mySelectElm = Driver.FindElement(By.Id("reply"));
            var mySelect = new SelectElement(mySelectElm);
            mySelect.SelectByValue(value);

            Logger.WriteInfoMessage("Selected ParentCompany as - " + value);
        }
        public static void Click_Button_TestingSendtoTest()
        {
            ElementClick(PageObject_CreateCampaign.Button_SendToTest());
            Navigatetoiframe(1);
            if (VerifyTextOnPage("This email address is in compliance with global spam laws"))
            {
                ManageCampaign.Click_CASLCheckBox();
                ScrollToElement(PageObject_ManageCampaign.Testcatchall_checkboxL());
                ManageCampaign.Testcatchall_checkbox();
                Logger.WriteDebugMessage("CASL is selected and sending send to test email.");
                ManageCampaign.Button_SendToTest();
            }
            Navigatetoiframe(0);
            //CreateCampaign_Button_Save();
            CreateCampaign_Button_SaveandContinue();
        }
        public static void Click_Button_SendforApproval()
        {
            Logger.WriteDebugMessage("Landed on Approval Page.");
            ElementClick(PageObject_CreateCampaign.Button_SendForApproval());
            AddDelay(8000);
            if (VerifyTextOnPage("An email has been sent requesting approval of this campaign."))
            {
                ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'Ok')]")));
            }
            ElementWait(PageObject_CreateCampaign.Button_Approve(), 60);
        }
        public static void Click_Button_Approve()
        {
            ElementWait(PageObject_CreateCampaign.Button_Approve(), 60);
            ElementClick(PageObject_CreateCampaign.Button_Approve());
            AddDelay(5000);
            ElementWait(PageObject_CreateCampaign.Button_Approve_Confirm(), 60);
            Logger.WriteDebugMessage("Confirming campaign to be approved.");
            ElementClick(PageObject_CreateCampaign.Button_Approve_Confirm());
        }
        public static void Click_Button_Disapprove()
        {
            ElementClick(PageObject_CreateCampaign.Button_Disapprove());
            ElementWait(PageObject_CreateCampaign.Button_Disapprove_Confirm(), 60);
            Logger.WriteDebugMessage("Confirming campaign to be disapproved.");
            ElementClick(PageObject_CreateCampaign.Button_Disapprove_Confirm());
        }
        private static void Click_Open_SubjectLineMapping()
        {
            ElementClick(PageObject_CreateCampaign.CreateCampaign_EditTemplate_LinkSubjectTag());
            Logger.WriteDebugMessage("Opened Subject Line Mapping IFrame.");
        }
        private static void Click_Link_SubjectLineMapping()
        {
            ElementClick(PageObject_CreateCampaign.CreateCampaign_EditTemplate_LinkSubjectTag_Map());
            Logger.WriteDebugMessage("Opened Subject Line Mapping IFrame.");
        }
        private static void Click_Close_SubjectLineMapping()
        {
            ElementClick(Driver.FindElement(By.XPath("//span[@title='Close']")));
            Logger.WriteDebugMessage("Closed Subject Line Mapping IFrame.");
        }

        public static void MapSubjectLine()
        {
            Click_Open_SubjectLineMapping();
            Navigatetoiframe(1);
            Click_Link_SubjectLineMapping();
            Navigatetoiframe(0);
            Click_Close_SubjectLineMapping();
        }



        public static void CampaignApprove(int ProjectID)
        {
            AddDelay(10000);
            Click_Button_Approve();
            AddDelay(10000);
            CampaignDetails data = new CampaignDetails();
            SqlWarehouseQuery.ReturnCampaignStatus(ProjectID, data);
            if (data.OldStatus == "Approved")
            {
                Logger.WriteDebugMessage("Checked in database and confirmed that campaign is Approved.");
            }
        }
        public static void CampaignDisapprove(int ProjectID)
        {
            Click_Button_Disapprove();
            AddDelay(8000);
            CampaignDetails data = new CampaignDetails();
            SqlWarehouseQuery.ReturnCampaignStatus(ProjectID, data);
            if (data.OldStatus == "Disapproved")
            {
                Logger.WriteDebugMessage("Checked in database and confirmed that campaign is disapproved.");
            }
        }        
        public static void CampaignScheduleandComplete(string emailType = null)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollBy(0,-1000)", "");
            ElementClick(PageObject_CreateCampaign.Button_Campaign_ScheduleandCompleteCampaign());
            AddDelay(10000);
            if (!String.IsNullOrEmpty(emailType))
            {
                if (VerifyTextOnPage("The following campaign settings are enabled"))
                {
                    //ElementClick(Driver.FindElement(By.XPath("//*[@id='fullwrap_new']/div[10]/div[11]/button[1]")));
                    ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'Ok')]")));
                }
            }
            AddDelay(8000);
            if (VerifyTextOnPage("This campaign will be sent automatically on the scheduled date(s)."))
            {
                Logger.WriteDebugMessage("Scheduling a campaign.");
                //ElementClick(Driver.FindElement(By.XPath("//*[@id='fullwrap_new']/div[10]/div[11]/button[1]")));
                ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'Ok')]")));
                if (Driver.Url.Contains("ManageCampaigns"))
                {
                    Logger.WriteDebugMessage("Campaign Scheduled.");
                }
            }
        }
        public static void CampaignUpdateSchedule()
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollBy(0,-1000)", "");
            ElementClick(PageObject_CreateCampaign.ManageCampaign_EditSchedule_UpdateSchedule());
            if (VerifyTextOnPage("Are you sure you wish to update schedule of the campaign?"))
            {
                Logger.WriteDebugMessage("Updating Schedule time and Activating campaign.");
                ElementClick(Driver.FindElement(By.XPath("//div[@id='warnUpdateSchedule']//following::span[contains(text(), 'Ok')]")));
                if (Driver.Url.Contains("ManageCampaigns"))
                {
                    Logger.WriteDebugMessage("Campaign Scheduled.");
                }
            }
        }

        public static void ChangeTemplate(string templateName)
        {
            ScrollDownUsingJavaScript(Driver, 105);
            ElementClick(Driver.FindElement(By.Id("changeTemplate")));
            AddDelay(5000);
            if (VerifyTextOnPage("Changing the template will delete all content from the campaign."))
            {
                switch(templateName)
                {
                    case "CuteEditor":
                    case "BeeFreeEditor":
                        Logger.WriteInfoMessage("Changing Template for " + templateName);
                        Logger.WriteDebugMessage("Landed on Confirmation Prompt to change template - Changing the template will delete all content from the campaign.");
                        ElementClick(Driver.FindElement(By.XPath("//span[contains(text(), 'Ok')]")));
                        break;
                    case "GrapeJSEditor":
                        Logger.WriteInfoMessage("Changing Template for " + templateName);
                        Logger.WriteDebugMessage("Landed on Confirmation Prompt to change template - Changing the template will delete all content from the campaign.");
                        ElementClick(Driver.FindElement(By.XPath("(//span[contains(text(), 'Ok')])[2]")));
                        break;
                }
            }
            AddDelay(8000);

            if (VerifyTextOnPage("Search"))
            {
                Logger.WriteDebugMessage("Landed on Template Page.");
            }
            else
            {
                Assert.Fail("Did not land on Template Page.");
            }
        }
        public static void GetTemplale(string templateName)
        {
            switch(templateName)
            {
                case "CuteEditor":
                    SelectListViewAndFilterTemplate("Starts With", "Legacy HTML");
                    ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", Driver.FindElement(By.XPath("//table[@id='templateGrid_content_table']/descendant::span[contains(.,'Code (Legacy)')]/ancestor::td//preceding-sibling::td[2]/descendant::input")));
                    Logger.WriteDebugMessage("Selected Legacy HTML - Cute Editor Template");
                    CreateCampaign.CreateCampaign_Template_Button_SaveAndContinue();
                    ScrollDownUsingJavaScript(Driver, 200);
                    Driver.SwitchTo().ParentFrame();
                    ElementWait(Driver.FindElement(By.Id("subject")), 60);
                    ScrollDownUsingJavaScript(Driver, 200);
                    if (IsElementPresent(By.XPath("(//td[@class='CuteEditorFrameContainer'])[2]")))
                    {
                        Logger.WriteDebugMessage("Legacy HTML - Cute Editor Template was populated.");
                    }
                    break;
                case "BeeFreeEditor":
                    SelectListViewAndFilterTemplate("contains", "Legacy Drag");
                    ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", Driver.FindElement(By.XPath("//table[@id='templateGrid_content_table']/descendant::span[contains(.,'Drag & Drop (Legacy)')]/ancestor::td//preceding-sibling::td[2]/descendant::input")));
                    Logger.WriteDebugMessage("Selected Legacy Drag & Drop - BeeFree Editor Template");
                    CreateCampaign.CreateCampaign_Template_Button_SaveAndContinue();
                    ScrollDownUsingJavaScript(Driver, 200);
                    Driver.SwitchTo().ParentFrame();
                    ElementWait(Driver.FindElement(By.Id("subject")), 60);
                    AddDelay(8000);
                    if (IsElementPresent(By.XPath("//div[@id='iframeBeeEditor']")))
                    {
                        Logger.WriteDebugMessage("Legacy Drag & Drop Editor Template was populated.");
                    }
                    break;
                case "GrapeJSEditor":
                    SelectListViewAndFilterTemplate("contains", "Studio");
                    ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", Driver.FindElement(By.XPath("//table[@id='templateGrid_content_table']/descendant::span[text()='Studio']/ancestor::td//preceding-sibling::td[2]/descendant::input")));
                    Logger.WriteDebugMessage("Selected Studio Templates");
                    ScrollDownUsingJavaScript(Driver, -1000);
                    CreateCampaign.CreateCampaign_Template_Button_SaveAndContinue();
                    ScrollDownUsingJavaScript(Driver, 400);
                    Helper.AddDelay(5000);
                    Driver.SwitchTo().ParentFrame();
                    ElementWait(Driver.FindElement(By.Id("subject")), 60);
                    AddDelay(15000);
                    if (IsElementPresent(By.XPath("//div[@id='grapejs-plugin']")))
                    {
                        Logger.WriteDebugMessage(" Studio Template was populated.");
                    }
                    break;
            }
        }

        public static void AddSubjectinEditTemplate(string subjectName)
        {
            DynamicScroll(Driver, PageObject_CreateCampaign.CreateCampaign_EditTemplate_Subject());
            ManageCampaign.EnterCampaignSubject(subjectName);
        }


        public static void SelectListViewAndFilterTemplate(string filterOption, string filterText)
        {
            
            ManageCampaign.ClickOnListViewOfTemplates();
            ManageCampaign.SearchTemplatesBasedOnName(filterOption, filterText);
        }

        public static void CreateCampaign_Template_Button_SaveAndContinue()
        {
            ElementClick(PageObject_CreateCampaign.CreateCampaign_Templates_SaveAndContinue());
            AddDelay(15000);
        }

        /*Added below Methods - 01June2023 -Sridhar
        Create Campaign Flow */
        /*Create Campaign flow Elements Methods
         Created 6Feb2023 Sridhar */

        #region

        public static void CreateCampaign_AudienceSearch()
        {
            ElementWait(PageObject_CreateCampaign.CreateCampaign_AudienceSearch(), 60);
            ElementClick(PageObject_CreateCampaign.CreateCampaign_AudienceSearch());
        }
        public static void CreateCampaign_AudienceSearch_Add()
        {
            ElementWait(PageObject_CreateCampaign.CreateCampaign_AudienceSearch_Add(), 60);
            ElementClick(PageObject_CreateCampaign.CreateCampaign_AudienceSearch_Add());
        }
        public static void PreSearchCampaign_New(string companyName)
        {   
            ScrollDownUsingJavaScript(Driver, -1000);
            Profile.SelectSubClient(companyName);
        }
        public static void CreateCampaign_PropertyList()
        {
            ElementClick(PageObject_CreateCampaign.CreateCampaign_PropertyList());
            AddDelay(1000);
        }
        public static void CreateCampaign_CampaignName()
        {
            ElementClick(PageObject_CreateCampaign.CreateCampaign_CampaignName());
            AddDelay(1000);
        }
        public static void CreateCampaign_Create()
        {
            ElementWait(PageObject_CreateCampaign.CreateCampaign_Create(), 60);
            ElementClick(PageObject_CreateCampaign.CreateCampaign_Create());
            AddDelay(1000);
        }
        public static void CreateCampaign_Templates_EmailType()
        {
            ElementWait(PageObject_CreateCampaign.CreateCampaign_Templates_EmailType(), 60);
            ElementClick(PageObject_CreateCampaign.CreateCampaign_Templates_EmailType());
        }
        public static void CreateCampaign_Templates_FromName()
        {
            ElementWait(PageObject_CreateCampaign.CreateCampaign_Templates_FromName(), 60);
            ElementClick(PageObject_CreateCampaign.CreateCampaign_Templates_FromName());
        }
        public static void CreateCampaign_Templates_ReplyEmail()
        {
            ElementWait(PageObject_CreateCampaign.CreateCampaign_Templates_ReplyEmail(), 60);
            ElementClick(PageObject_CreateCampaign.CreateCampaign_Templates_ReplyEmail());
        }
        public static void CreateCampaign_Templates_subject()
        {
            ElementWait(PageObject_CreateCampaign.CreateCampaign_Templates_subject(), 60);
            ElementClick(PageObject_CreateCampaign.CreateCampaign_Templates_subject());
        }
        public static void CreateCampaign_Create_SubMail()
        {
            ElementWait(PageObject_CreateCampaign.CreateCampaign_Create_SubMail(), 60);
            ElementClick(PageObject_CreateCampaign.CreateCampaign_Create_SubMail());
        }
        //li[@class='active-result'][text()='NU Hotel']
        public static string CreateCampaign_CriteriaToTestingTab(int ProjectID,string EToEFlowName, string EmailType, string FromName, string ReplyEmail, string subject)
        {
            string CampaignName = GetRandomAlphaNumericString(0,1);
            try
            {
                CreateCampaign_Create();                
                ElementWait(PageObject_CreateCampaign.CreateCampaign_PropertyList(), 60);
                ElementEnterText(PageObject_CreateCampaign.CreateCampaign_CampaignName(), EToEFlowName + CampaignName);
                Logger.WriteInfoMessage("Entered Campaign Name as :"+ EToEFlowName + CampaignName);
                CreateCampaign_SelectPropertylyst("NU Hotel");
                CreateCampaign_AudienceSearchandAdd("test sms");

                Driver.SwitchTo().Frame("TemplateBuilder");
                ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", Driver.FindElement(By.XPath("(//div[@class='card__container']/div)[1]")));
                Logger.WriteDebugMessage("Template Selected in Template Tab");
                ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Save & Continue')]")));
                Logger.WriteDebugMessage("Clicked on 'Save and Continue' button");
                //Logger.WriteDebugMessage("Landed on Edit Template Tab");
                CreateCampaign_EditTemplate(EmailType, FromName, ReplyEmail, subject);
                AddDelay(5000);
                CreateCampaign.CreateCampaign_TestingTabProceedButton();
               // Logger.WriteDebugMessage("Landed on Testing Tab");
                //Driver.SwitchTo().DefaultContent();
                //((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", Driver.FindElement(By.XPath("//a[@id='save']")));
                //Logger.WriteDebugMessage("Clicked on 'Proceed' Button");
            }
            catch (Exception ex)
            {

            }
            return CampaignName;
        }

        public static void CreateCampaign_Criteria(string EToEFlowName)
        {
            
            try
            {
                CreateCampaign_Create();
                ElementWait(PageObject_CreateCampaign.CreateCampaign_PropertyList(), 60);
                ElementEnterText(PageObject_CreateCampaign.CreateCampaign_CampaignName(), EToEFlowName);
                Logger.WriteInfoMessage("Entered Campaign Name as :" + EToEFlowName);
            }
            catch (Exception ex)
            {

            }
            
        }
        public static void CreateCampaign_SubEmailCreate(string EToEFlowName)
        {

            try
            {
                CreateCampaign_Create_SubMail();
                Driver.SwitchTo().Frame("TemplateBuilder");
                ElementWait(PageObject_CreateCampaign.CreateCampaign_SubMailCampaignName(), 60);
                ElementEnterText(PageObject_CreateCampaign.CreateCampaign_SubMailCampaignName(), EToEFlowName);
                Logger.WriteInfoMessage("Entered Sub Email Campaign Name as :" + EToEFlowName);
            }
            catch (Exception ex)
            {

            }

        }

        public static void CreateCampaign_SelectPropertylyst(string propertyListName)
        {
            try
            {               
                ElementWait(PageObject_CreateCampaign.CreateCampaign_PropertyList(), 60);
                ElementClick(PageObject_CreateCampaign.CreateCampaign_PropertyList());
                //ElementEnterText(PageObject_CreateCampaign.CreateCampaign_PropertyList(),"NU Hotel");
                Keyboard_KeyDown();
                Keyboard_KeyDown();                
                HoverOver(Driver.FindElement(By.XPath("//li[@class='active-result'][contains(text(),'"+ propertyListName + "')]")));
                Keyboard_Enter();                
                Logger.WriteInfoMessage("Selected Proerty List Name : "+ propertyListName);
                //Keyboard_SendKeys(Keys.Tab);

            }
            catch (Exception ex)
            {

            }
        }
        public static void CreateCampaign_AudienceSearchandAdd(string AudienceSearchSelectName)
        {
            try
            {
                CreateCampaign_AudienceSearch();
                Driver.SwitchTo().Frame("Audience");
                ScrollDownUsingJavaScript(Driver, 500);
                ElementClick(Driver.FindElement(By.XPath("//span[text()='"+ AudienceSearchSelectName + "']//preceding-sibling::label")));
                AddDelay(10000);
                Driver.SwitchTo().DefaultContent();
                ScrollUpUsingJavaScript(Driver, -105);
                ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", Driver.FindElement(By.XPath("//button[@class='btn btn-primary action-criteria-save-continue']")));
                Logger.WriteInfoMessage("Selected Audince Search as : " + AudienceSearchSelectName);
                Logger.WriteInfoMessage("Clicked on 'Save and Continue' Button");
            }
            catch (Exception ex)
            {

            }
        }
        public static void CreateCampaign_EditTemplate(string EmailType, string FromName, string ReplyEmail, string subject)
        {
            try
            {
                ElementWait(Driver.FindElement(By.XPath("//a[contains(text(), 'Save & Continue')]")), 120);
                AddDelay(2000);
                ElementSelectFromDropDown(PageObject_CreateCampaign.CreateCampaign_Templates_EmailType(), EmailType);
                ElementSelectFromDropDown(PageObject_CreateCampaign.CreateCampaign_Templates_FromName(), FromName);
                ElementSelectFromDropDown(PageObject_CreateCampaign.CreateCampaign_Templates_ReplyEmail(), ReplyEmail);
                ElementEnterText(PageObject_CreateCampaign.CreateCampaign_Templates_subject(), subject);
                ScrollUpUsingJavaScript(Driver, -105);
                ElementClick(Driver.FindElement(By.XPath("//a[contains(text(), 'Save & Continue')]")));

            }
            catch (Exception ex)
            {

            }
        }
        public static void CreateCampaign_CampainSetting(string ResrvationTyp)
        {
            try
            {
                Driver.SwitchTo().DefaultContent();
                ScrollDownUsingJavaScript(Driver, 250);
                ElementWait(PageObject_CreateCampaign.CreateCampaign_CampainSetting(), 60);
                ElementClick(PageObject_CreateCampaign.CreateCampaign_CampainSetting());
                ElementSelectFromDropDown(PageObject_CreateCampaign.CreateCampaign_ReservationEvent(), ResrvationTyp);
                ElementSelected(PageObject_CreateCampaign.CreateCampaign_ReservationEvent_EmailReservation());
                ElementSelected(PageObject_CreateCampaign.CreateCampaign_ReservationEvent_include_unsubscribed());
                ElementSelected(PageObject_CreateCampaign.CreateCampaign_ReservationEvent_include_bounced());
                ElementSelected(PageObject_CreateCampaign.CreateCampaign_ReservationEvent_include_nonconsent());
            }
            catch (Exception ex)
            {

            }
        }
        public static void CreateCampaign_DataSource(string dataSource)
        {
            try
            {                
                ElementWait(PageObject_CreateCampaign.CreateCampaign_DataSource(), 60);
                ElementClick(PageObject_CreateCampaign.CreateCampaign_DataSource());
                ScrollDownUsingJavaScript(Driver, 500);
                ElementClick(Driver.FindElement(By.XPath("//li[contains(text(),'"+ dataSource + "')]")));

            }
            catch (Exception ex)
            {

            }
        }
        public static void CreateCampaign_ForecastTargetAudience()
        {
            try
            {
                ElementClick(Driver.FindElement(By.XPath("//button[@class='btn btn-success action-show-statistics']")));

            }
            catch (Exception ex)
            {

            }
        }
        public static void CreateCampaign_CriteriaTabSaveandContinueButton()
        {
            try
            {
                ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", Driver.FindElement(By.XPath("//button[@class='btn btn-primary action-criteria-save-continue']")));
                Logger.WriteInfoMessage("Clicked on 'Save and Continue' Button");
            }
            catch (Exception ex)
            {

            }
        }
        /*Temple Select and Click Save and Continue*/
        public static void CreateCampaign_TemplateTabSelectandSaveandContinueButton(int templateindex)
        {
            try
            {
                ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", Driver.FindElement(By.XPath("(//div[@class='card__container']/div)['"+ templateindex + "']")));
                Logger.WriteDebugMessage("Template Selected in Template Tab");
                ElementClick(Driver.FindElement(By.XPath("//button[contains(text(), 'Save & Continue')]")));
                Logger.WriteDebugMessage("Clicked on 'Save and Continue' button");
            }
            catch (Exception ex)
            {

            }
        }

        /*Temple Select and Click Save and Continue*/
        public static void CreateCampaign_TestingTabProceedButton()
        {
            try
            {
                
                Logger.WriteDebugMessage("Landed on Testing Tab");
                AddDelay(5000);
                Driver.SwitchTo().ParentFrame();
                ElementWait(Driver.FindElement(By.XPath("//a[@id='save']")), 60);
                ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", Driver.FindElement(By.XPath("//a[@id='save']")));
                Logger.WriteDebugMessage("Clicked on 'Proceed' Button");
            }
            catch (Exception ex)
            {

            }
        }
        /*Verifying After Completing All Campaign Creation Process done*/
        public static void CreateCampaign_VerifyCreatedorNot(string CampaignRanName,int index )
        {
            try
            {
                ElementWait(Driver.FindElement(By.XPath("(//span[contains(text(), 'Scheduled Active')])['" + index + "']")), 60);
                
                if (VerifyTextOnPage(CampaignRanName))
                {
                    Logger.WriteDebugMessage("New Campaign Created Successfully : " + CampaignRanName);
                }
                else
                {
                    Assert.Fail("New Campaign Not Created : " + CampaignRanName);
                }
                ElementClick(Driver.FindElement(By.XPath("(//span[contains(text(), 'Scheduled Active')])['"+ index + "']")));
                ElementWait(PageObject_ManageCampaign.ManageCampaign_EditSchedule_InactivateSchedule(), 60);
                IsElementVisible(PageObject_ManageCampaign.ManageCampaign_EditSchedule_InactivateSchedule());
            }
            catch (Exception ex)
            {

            }
        }
        /*Select Transactional/Marketing In Campaign Page by Passing Index and value*/
        public static void CreateCampaign_SelectDropdownValueInManageCampaingPage(string Value, int xpathindex)
        {
            try
            {
                
                var cList = Driver.FindElement(By.XPath("(//select[contains(@id,'campaign-type') and @class='form-control'])[" + xpathindex +"]"));
                //(//select[@id='campaign-type-dropdown' and @class='form-control'])
                var selectElement = new SelectElement(cList);
                selectElement.SelectByText(Value);
                Logger.WriteDebugMessage("Selected drop down value  on CampaingPage is : " + Value);//Transactional - In Testing
            }
            catch (Exception ex)
            {


            }
        }


        #endregion
    }
}
