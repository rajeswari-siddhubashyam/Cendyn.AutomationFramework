using BaseUtility.Utility;
using eMenus.AppModule.Admin;
using eMenus.AppModule.UI;
using eMenus.Entity;
using eMenus.PageObject.Admin;
using eMenus.PageObject.UI;
using InfoMessageLogger;
using NUnit.Framework;
using System;
using TestData;
using Queries = eMenus.Utility.Queries;

namespace eMenus.AppModule.MainAdminApp
{
    public partial class MainAdminApp : eMenus.Utility.Setup
    {
        public static void TC_278050()
        {

            //Login to Cendyn Admin
            //PropertyAdmin.PropertyAdmin_SSOProd("qacendyn@cendyn17.com", "Cendyn123$");
            PropertyAdmin.PropertyAdmin_Non2Factor();

            //Navigate to Home Page and Select Property
            PropertyAdmin.Click_Navigation_eMenus();
            Logger.WriteDebugMessage("eMenus Product got Selected ");
            PropertyAdmin.Click_Select_PropertyDropdown();
            Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
            PropertyAdmin.Enter_Property_TextBox("Hotel Origami");
            Logger.WriteDebugMessage("Entered Property");
            PropertyAdmin.Select_Property_Dropdown("Hotel Origami");
            Logger.WriteDebugMessage(" Property got Selected");

            VerifyTextOnPageAndHighLight("My Menus");

            //Log test data into log file as well as extent report

            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end User-name", "qacendyn@cendyn17.com");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end Password", "Cendyn123$");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", "Hotel Origami");
            
        }
        public static void TC_278051()
        {
            //Login to Cendyn Admin
            PropertyAdmin.PropertyAdmin_Non2Factor();

            //Navigate to Home Page and Select Property
            PropertyAdmin.Click_Navigation_eMenus();
            Logger.WriteDebugMessage("eMenus Product got Selected ");
            PropertyAdmin.Click_Select_PropertyDropdown();
            Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
            PropertyAdmin.Enter_Property_TextBox("Hotel Origami");
            Logger.WriteDebugMessage("Entered Property");
            PropertyAdmin.Select_Property_Dropdown("Hotel Origami");
            Logger.WriteDebugMessage(" Property got Selected");

            //PropertyAdmin.Click_Main_Navigation_Dropdown();
            PropertyAdmin.Navigate_CendynAdmin();

            VerifyTextOnPageAndHighLight("Supplier");

            //Log test data into log file as well as extent report
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end User-name", "qacendyn@cendyn17.com");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end Password", "Cendyn123$");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", "Hotel Origami");
        }
        public static void TC_278052()
        {
            //Login to Cendyn Admin
            PropertyAdmin.PropertyAdmin_Non2Factor();

            //Navigate to Home Page and Select Property
            PropertyAdmin.Click_Navigation_eMenus();
            Logger.WriteDebugMessage("eMenus Product got Selected ");
            PropertyAdmin.Click_Select_PropertyDropdown();
            Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
            PropertyAdmin.Enter_Property_TextBox("Hotel Origami");
            Logger.WriteDebugMessage("Entered Property");
            PropertyAdmin.Select_Property_Dropdown("Hotel Origami");
            Logger.WriteDebugMessage(" Property got Selected");

            //Logout
            PropertyAdmin.Click_Settings_Dropdown();
            Logger.WriteDebugMessage("Clicked on Setting Drop-down");
            PropertyAdmin.Click_Log_Out();
            Logger.WriteDebugMessage("Logout successfully");

            VerifyTextOnPageAndHighLight("Sign In");


            //Log test data into log file as well as extent report
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end User-name", "qacendyn@cendyn17.com");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end Password", "Cendyn123$");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", "Hotel Origami");
        }
        public static void TC_278054()
        {
            //Login to Cendyn Admin
            PropertyAdmin.PropertyAdmin_Non2Factor();

            //Navigate to Home Page and Select Property
            PropertyAdmin.Click_Navigation_eMenus();
            Logger.WriteDebugMessage("eMenus Product got Selected ");
            PropertyAdmin.Click_Select_PropertyDropdown();
            Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
            PropertyAdmin.Enter_Property_TextBox("Hotel Origami");
            Logger.WriteDebugMessage("Entered Property");
            PropertyAdmin.Select_Property_Dropdown("Hotel Origami");
            Logger.WriteDebugMessage(" Property got Selected");

            //Navigate to PDF view
            PropertyAdmin.Click_Link_PDF_View();
            Logger.WriteDebugMessage("Navigated to PDF view");

            //Log test data into log file as well as extent report
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end User-name", "qacendyn@cendyn17.com");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end Password", "Cendyn123$");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", "Hotel Origami");
        }
        public static void TC_278055()
        {
            //Login to Cendyn Admin
            PropertyAdmin.PropertyAdmin_Non2Factor();

            //Navigate to Home Page and Select Property
            PropertyAdmin.Click_Navigation_eMenus();
            Logger.WriteDebugMessage("eMenus Product got Selected ");
            PropertyAdmin.Click_Select_PropertyDropdown();
            Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
            PropertyAdmin.Enter_Property_TextBox("Hotel Origami");
            Logger.WriteDebugMessage("Entered Property");
            PropertyAdmin.Select_Property_Dropdown("Hotel Origami");
            Logger.WriteDebugMessage(" Property got Selected");

            //Navigate to Category
            Helper.EnterFrame("frontendEditorIframe");
            PropertyAdmin.Click_MyMenu_BreakfastDropdown();
            PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
            Logger.WriteDebugMessage("Navigated to Continental Breakfast");
            VerifyTextOnPageAndHighLight("Continental Breakfast");
            PropertyAdmin.Click_MyMenu_BreakMenu();
            ScrollToText("Continental Breakfast");
            Logger.WriteDebugMessage("Navigated to Break");
            VerifyTextOnPageAndHighLight("Breaks");

            //Log test data into log file as well as extent report
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end User-name", "qacendyn@cendyn17.com");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end Password", "Cendyn123$");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", "Hotel Origami");
        }
        public static void TC_278056()
        {
            //Login to Cendyn Admin
            PropertyAdmin.PropertyAdmin_Non2Factor();

            //Navigate to Home Page and Select Property
            PropertyAdmin.Click_Navigation_eMenus();
            Logger.WriteDebugMessage("eMenus Product got Selected ");
            PropertyAdmin.Click_Select_PropertyDropdown();
            Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
            PropertyAdmin.Enter_Property_TextBox("Hotel Origami");
            Logger.WriteDebugMessage("Entered Property");
            PropertyAdmin.Select_Property_Dropdown("Hotel Origami");
            Logger.WriteDebugMessage(" Property got Selected");

            //Navigate to Preview 
            PropertyAdmin.Click_MyMenu_PreviewButton();
            Logger.WriteDebugMessage("Clicked Preview button");
            CloseCurrentTab();
            //CloseCurrentTab();
            Logger.WriteDebugMessage("Preview");


            //Log test data into log file as well as extent report
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end User-name", "qacendyn@cendyn17.com");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end Password", "Cendyn123$");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", "Hotel Origami");
        }
        public static void TC_278057()
        {
            //Login to Cendyn Admin
            PropertyAdmin.PropertyAdmin_Non2Factor();

            //Navigate to Home Page and Select Property
            PropertyAdmin.Click_Navigation_eMenus();
            Logger.WriteDebugMessage("eMenus Product got Selected ");
            PropertyAdmin.Click_Select_PropertyDropdown();
            Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
            PropertyAdmin.Enter_Property_TextBox("Hotel Origami");
            Logger.WriteDebugMessage("Entered Property");
            PropertyAdmin.Select_Property_Dropdown("Hotel Origami");
            Logger.WriteDebugMessage(" Property got Selected");

            //Navigate to Publish view 
            PropertyAdmin.Click_PublishedView();
            Logger.WriteDebugMessage("Clicked Publish view button");
            CloseCurrentTab();
            //CloseCurrentTab();
            Logger.WriteDebugMessage("Publish view");


            //Log test data into log file as well as extent report
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end User-name", "qacendyn@cendyn17.com");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end Password", "Cendyn123$");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", "Hotel Origami");
        }
        public static void TC_278058()
        {
            Driver.Navigate().GoToUrl("https://cendynorigami.menusaccess.com/");
            Logger.WriteDebugMessage("Navigated to Origami front end");
            HomePage.HomePage_BreakfastDropdown();
            HomePage.HomePage_Select_ContinentalBreakfast();
            VerifyTextOnPageAndHighLight("Continental Breakfast");
            Logger.WriteDebugMessage("Continental Breakfast");
            HomePage.HomePage_BreakfastDropdown();
            HomePage.HomePage_Select_BreakfastBuffet();
            VerifyTextOnPageAndHighLight("Breakfast Buffet");
            Logger.WriteDebugMessage("Breakfast Buffet");
        }
        public static void TC_278059()
        {
            Driver.Navigate().GoToUrl("https://cendynorigami.menusaccess.com/");
            Logger.WriteDebugMessage("Navigated to Origami front end");
            HomePage.Click_PrintIcon();
            CloseCurrentTab();
            Logger.WriteDebugMessage("Print PDF");

        }
    }

}
