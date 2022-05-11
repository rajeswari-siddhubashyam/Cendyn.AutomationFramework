using BaseUtility.Utility;
using eMenus.AppModule.Admin;
using eMenus.AppModule.UI;
using eMenus.PageObject.Admin;
using eMenus.PageObject.UI;
using InfoMessageLogger;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using TestData;


namespace eMenus.AppModule.MainAdminApp
{
    public partial class MainAdminApp : eMenus.Utility.Setup
    {
        public static void TC_278080()
        {
            //Login to Cendyn Admin
            PropertyAdmin.PropertyAdmin_SSOProd("qacendyn@cendyn17.com", "Cendyn123$");

            //Navigate to Home Page and Select Property
            PropertyAdmin.Click_Navigation_eMenusLITE();
            Logger.WriteDebugMessage("eMenus Lite Product got Selected ");
            PropertyAdmin.Click_Select_PropertyDropdown();
            Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
            PropertyAdmin.Enter_Property_TextBox("Cendyn - Hotel Origami Chicago");
            Logger.WriteDebugMessage("Entered Property");
            PropertyAdmin.Select_Property_Dropdown("Cendyn - Hotel Origami Chicago");
            Logger.WriteDebugMessage(" Property got Selected");

            VerifyTextOnPageAndHighLight("My Menus");

            //Log test data into log file as well as extent report

            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end User-name", "qacendyn@cendyn17.com");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end Password", "Cendyn123$");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", "Cendyn - Hotel Origami Chicago");
        }
        public static void TC_278081()
        {
            //Login to Cendyn Admin
            PropertyAdmin.PropertyAdmin_SSOProd("qacendyn@cendyn17.com", "Cendyn123$");

            //Navigate to Home Page and Select Property
            PropertyAdmin.Click_Navigation_eMenusLITE();
            Logger.WriteDebugMessage("eMenus Lite Product got Selected ");
            PropertyAdmin.Click_Select_PropertyDropdown();
            Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
            PropertyAdmin.Enter_Property_TextBox("Cendyn - Hotel Origami Chicago");
            Logger.WriteDebugMessage("Entered Property");
            PropertyAdmin.Select_Property_Dropdown("Cendyn - Hotel Origami Chicago");
            Logger.WriteDebugMessage(" Property got Selected");

            //PropertyAdmin.Click_Main_Navigation_Dropdown();
            PropertyAdmin.Navigate_CendynAdmin();

            VerifyTextOnPageAndHighLight("Supplier");

            //Log test data into log file as well as extent report
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end User-name", "qacendyn@cendyn17.com");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end Password", "Cendyn123$");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", "Cendyn - Hotel Origami Chicago");
        }
        public static void TC_278082()
        {
            //Login to Cendyn Admin
            PropertyAdmin.PropertyAdmin_SSOProd("qacendyn@cendyn17.com", "Cendyn123$");

            //Navigate to Home Page and Select Property
            PropertyAdmin.Click_Navigation_eMenusLITE();
            Logger.WriteDebugMessage("eMenus Lite Product got Selected ");
            PropertyAdmin.Click_Select_PropertyDropdown();
            Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
            PropertyAdmin.Enter_Property_TextBox("Cendyn - Hotel Origami Chicago");
            Logger.WriteDebugMessage("Entered Property");
            PropertyAdmin.Select_Property_Dropdown("Cendyn - Hotel Origami Chicago");
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
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", "Cendyn - Hotel Origami Chicago");
        }
        public static void TC_278083()
        {
            //Login to Cendyn Admin
            PropertyAdmin.PropertyAdmin_SSOProd("qacendyn@cendyn17.com", "Cendyn123$");

            //Navigate to Home Page and Select Property
            PropertyAdmin.Click_Navigation_eMenusLITE();
            Logger.WriteDebugMessage("eMenus Product got Selected ");
            PropertyAdmin.Click_Select_PropertyDropdown();
            Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
            PropertyAdmin.Enter_Property_TextBox("Cendyn - Hotel Origami Chicago");
            Logger.WriteDebugMessage("Entered Property");
            PropertyAdmin.Select_Property_Dropdown("Cendyn - Hotel Origami Chicago");
            Logger.WriteDebugMessage(" Property got Selected");

            //Navigate to PDF view
            PropertyAdmin.Click_Link_PDF_View();
            Logger.WriteDebugMessage("Navigated to PDF view");

            //Log test data into log file as well as extent report
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end User-name", "qacendyn@cendyn17.com");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end Password", "Cendyn123$");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", "Cendyn - Hotel Origami Chicago");
        }
        public static void TC_278084()
        {
            //Login to Cendyn Admin
            PropertyAdmin.PropertyAdmin_SSOProd("qacendyn@cendyn17.com", "Cendyn123$");

            //Navigate to Home Page and Select Property
            PropertyAdmin.Click_Navigation_eMenusLITE();
            Logger.WriteDebugMessage("eMenus Lite Product got Selected ");
            PropertyAdmin.Click_Select_PropertyDropdown();
            Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
            PropertyAdmin.Enter_Property_TextBox("Cendyn - Hotel Origami Chicago");
            Logger.WriteDebugMessage("Entered Property");
            PropertyAdmin.Select_Property_Dropdown("Cendyn - Hotel Origami Chicago");
            Logger.WriteDebugMessage(" Property got Selected");

            //Navigate to Category
            Helper.EnterFrame("frontendEditorIframe");
            HomePage.HomePage_Breakfast();
            Logger.WriteDebugMessage("Navigated to Breakfast");
            VerifyTextOnPageAndHighLight("Breakfast");
            HomePage.HomePage_Break();
            Logger.WriteDebugMessage("Navigated to Break");
            VerifyTextOnPageAndHighLight("Break");

            //Log test data into log file as well as extent report
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end User-name", "qacendyn@cendyn17.com");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end Password", "Cendyn123$");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", "Cendyn - Hotel Origami Chicago");
        }
        public static void TC_278085()
        {
            //Login to Cendyn Admin
            PropertyAdmin.PropertyAdmin_SSOProd("qacendyn@cendyn17.com", "Cendyn123$");

            //Navigate to Home Page and Select Property
            PropertyAdmin.Click_Navigation_eMenusLITE();
            Logger.WriteDebugMessage("eMenus Lite Product got Selected ");
            PropertyAdmin.Click_Select_PropertyDropdown();
            Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
            PropertyAdmin.Enter_Property_TextBox("Cendyn - Hotel Origami Chicago");
            Logger.WriteDebugMessage("Entered Property");
            PropertyAdmin.Select_Property_Dropdown("Cendyn - Hotel Origami Chicago");
            Logger.WriteDebugMessage(" Property got Selected");

            //Navigate to Preview 
            PropertyAdmin.Click_MyMenu_PreviewButton();
            Logger.WriteDebugMessage("Clicked Preview button");
            CloseCurrentTab();
            CloseCurrentTab();
            Logger.WriteDebugMessage("Preview");


            //Log test data into log file as well as extent report
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end User-name", "qacendyn@cendyn17.com");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end Password", "Cendyn123$");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", "Cendyn - Hotel Origami Chicago");
        }
        public static void TC_278086()
        {
            //Login to Cendyn Admin
            PropertyAdmin.PropertyAdmin_SSOProd("qacendyn@cendyn17.com", "Cendyn123$");

            //Navigate to Home Page and Select Property
            PropertyAdmin.Click_Navigation_eMenusLITE();
            Logger.WriteDebugMessage("eMenus Product got Selected ");
            PropertyAdmin.Click_Select_PropertyDropdown();
            Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
            PropertyAdmin.Enter_Property_TextBox("Cendyn - Hotel Origami Chicago");
            Logger.WriteDebugMessage("Entered Property");
            PropertyAdmin.Select_Property_Dropdown("Cendyn - Hotel Origami Chicago");
            Logger.WriteDebugMessage(" Property got Selected");

            //Navigate to Publish view 
            PropertyAdmin.Click_PublishedView();
            Logger.WriteDebugMessage("Clicked Publish view button");
            CloseCurrentTab();
            CloseCurrentTab();
            Logger.WriteDebugMessage("Publish view");


            //Log test data into log file as well as extent report
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end User-name", "qacendyn@cendyn17.com");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end Password", "Cendyn123$");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", "Cendyn - Hotel Origami Chicago");
        }
        public static void TC_278087()
        {
            Driver.Navigate().GoToUrl("https://litecendynorigamichicago.menusaccess.com/");
            Logger.WriteDebugMessage("Navigated to Origami front end");
            HomePage.HomePage_Breakfast();
            VerifyTextOnPageAndHighLight("Breakfast");
            Logger.WriteDebugMessage("Breakfast");
            HomePage.HomePage_Break();
            VerifyTextOnPageAndHighLight("Break");
            Logger.WriteDebugMessage("Break");
        }
        public static void TC_278088()
        {
            Driver.Navigate().GoToUrl("https://litecendynorigamichicago.menusaccess.com/");
            Logger.WriteDebugMessage("Navigated to Origami front end");
            HomePage.Click_PrintIcon();
            CloseCurrentTab();
            Logger.WriteDebugMessage("Print PDF");
        }
    }
}
