using AventStack.ExtentReports.Model;
using BaseUtility.Utility;
using eMenus.AppModule.Admin;
using eMenus.AppModule.UI;
using eMenus.Entity;
using eMenus.PageObject.Admin;
using eMenus.PageObject.UI;
using InfoMessageLogger;
using NUnit.Framework;
using System;
using System.Drawing.Printing;
using TestData;
using Queries = eMenus.Utility.Queries;

namespace eMenus.AppModule.MainAdminApp
{
    public partial class MainAdminApp : eMenus.Utility.Setup
    {
        public static void TC_278095()
        {
            //Login to Cendyn Admin
            //PropertyAdmin.PropertyAdmin_SSOProd("qacendyn@cendyn17.com", "Cendyn123$");
            PropertyAdmin.PropertyAdmin_Non2Factor();

            //Navigate to Home Page and Select Property
            PropertyAdmin.Click_Navigation_ePlanner();
            Logger.WriteDebugMessage("ePlanner Product got Selected ");
            PropertyAdmin.Click_Select_PropertyDropdown();
            Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
            PropertyAdmin.Enter_Property_TextBox("Hotel Origami");
            Logger.WriteDebugMessage("Entered Property");
            PropertyAdmin.Select_Property_Dropdown("Hotel Origami");
            Logger.WriteDebugMessage(" Property got Selected");

            VerifyTextOnPageAndHighLight("My Planner");

            //Log test data into log file as well as extent report

            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end User-name", "qacendyn@cendyn17.com");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front-end Password", "Cendyn123$");
            Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", "Hotel Origami");
        }
        public static void TC_278096()
        {
            //Login to Cendyn Admin
            PropertyAdmin.PropertyAdmin_Non2Factor();

            //Navigate to Home Page and Select Property
            PropertyAdmin.Click_Navigation_ePlanner();
            Logger.WriteDebugMessage("ePlanner Product got Selected ");
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
        public static void TC_278097()
        {
            //Login to Cendyn Admin
            PropertyAdmin.PropertyAdmin_Non2Factor();

            //Navigate to Home Page and Select Property
            PropertyAdmin.Click_Navigation_ePlanner();
            Logger.WriteDebugMessage("ePlanner Product got Selected ");
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

        }
        public static void TC_278099()
        {
            //Login to Cendyn Admin
            PropertyAdmin.PropertyAdmin_Non2Factor();

            //Navigate to Home Page and Select Property
            PropertyAdmin.Click_Navigation_ePlanner();
            Logger.WriteDebugMessage("ePlanner Product got Selected ");
            PropertyAdmin.Click_Select_PropertyDropdown();
            Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
            PropertyAdmin.Enter_Property_TextBox("Hotel Origami");
            Logger.WriteDebugMessage("Entered Property");
            PropertyAdmin.Select_Property_Dropdown("Hotel Origami");
            Logger.WriteDebugMessage(" Property got Selected");

            //Navigate to Category
            EnterFrame("frontendEditorIframe");
            PropertyAdmin.Click_Menu_FoodAndBeverages();
            Logger.WriteDebugMessage("Clicked on Food and Beverages");
            PropertyAdmin.Click_Category_Sub_Menu("Banquet Curfews");
            VerifyTextOnPageAndHighLight("Banquet Curfews");
            Logger.WriteDebugMessage("Banquet Curfews");

            PropertyAdmin.Click_Category_Sub_Menu("Bars");
            VerifyTextOnPageAndHighLight("Bars");
            Logger.WriteDebugMessage("Bars");

        }
        public static void TC_278100()
        {
            //Login to Cendyn Admin
            PropertyAdmin.PropertyAdmin_Non2Factor();

            //Navigate to Home Page and Select Property
            PropertyAdmin.Click_Navigation_ePlanner();
            Logger.WriteDebugMessage("ePlanner Product got Selected ");
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

        }
        public static void TC_278101()
        {
            //Login to Cendyn Admin
            PropertyAdmin.PropertyAdmin_Non2Factor();

            //Navigate to Home Page and Select Property
            PropertyAdmin.Click_Navigation_ePlanner();
            Logger.WriteDebugMessage("ePlanner Product got Selected ");
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

        }
        public static void TC_278094()
        {
            Driver.Navigate().GoToUrl("https://eplcendynorigami.eplanneraccess.com/");
            Logger.WriteDebugMessage("Navigated to Origami front end");


            //Navigate to Category
            PropertyAdmin.Click_Menu_FoodAndBeverages();
            Logger.WriteDebugMessage("Clicked on Food and Beverages");
            PropertyAdmin.Click_Category_Sub_Menu("Banquet Curfews");
            VerifyTextOnPageAndHighLight("Banquet Curfews");
            Logger.WriteDebugMessage("Banquet Curfews");

            PropertyAdmin.Click_Category_Sub_Menu("Bars");
            VerifyTextOnPageAndHighLight("Bars");
            Logger.WriteDebugMessage("Bars");

        }
        public static void TC_195393()
        {
            Driver.Navigate().GoToUrl("https://eplcendynorigami.eplanneraccess.com/");
            Logger.WriteDebugMessage("Navigated to Origami front end");

            //search title
            ePlannerHomePage.Home_SearchBox("Bell Services");
            Logger.WriteDebugMessage("Title entered");
            Helper.Keyboard_Enter();
            VerifyTextOnPageAndHighLight("Bell Services");
            Logger.WriteDebugMessage("Search successful");

            //search description
            ePlannerHomePage.Home_SearchBox("department");
            Logger.WriteDebugMessage("Description entered");
            Helper.Keyboard_Enter();
            VerifyTextOnPageAndHighLight("department");
            Logger.WriteDebugMessage("Search successful");

            //Clear test data and verify search for invalid test data
            ePlannerHomePage.Home_SearcBoxClear();

            ePlannerHomePage.Home_SearchBox("Test&#");
            Logger.WriteDebugMessage("Search text entered");
            Helper.Keyboard_Enter();

            VerifyTextOnPageAndHighLight("You have entered invalid characters such as " + @"""&#""" + ", " + @"""<>""" + ". Please re-enter.");
            Logger.WriteDebugMessage("You have entered invalid characters such as " + @"""&#""" + ", " + @"""<>""" + ". Please re-enter.");

            //Clear test data and verify search for invalid test data
            ePlannerHomePage.Home_SearcBoxClear();

            ePlannerHomePage.Home_SearchBox("12");
            Logger.WriteDebugMessage("Search text entered");
            Helper.Keyboard_Enter();

            VerifyTextOnPageAndHighLight("Your search was too vague. Please be more specific.");
            Logger.WriteDebugMessage("Your search was too vague. Please be more specific.");


        }

    }
}
