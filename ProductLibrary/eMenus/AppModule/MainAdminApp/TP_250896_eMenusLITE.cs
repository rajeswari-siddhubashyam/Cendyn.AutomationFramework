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
        public static void TC_231048()
        {
            if (TestCaseId == Utility.Constants.TC_231048)
            {
                //Pre-Requisites
                string propertyAdmin_Username, password, propertyCorporate, propertyLite, categoryName, categoryDesc, menuName, menuDescription, choiceName,
                    choiceDescription, option1Name, option1Price, option2Name, option2price, menuNameAddOns,
                    menuDescriptionAddOns, add_On_Title, add_On1_Name, add_On1_Description,
                    add_On1_Price, add_On2_Name, add_On2_Description, add_On2_Price, num, updateText;
                Random no = new Random();
                num = no.Next().ToString();

                //Retrieve data from test Data
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyCorporate = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyCorporate");
                propertyLite = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyLITE");
                categoryName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "CategoryName"), num);
                categoryDesc = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "CategoryDesc"), num);
                menuName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuName"), num);
                menuDescription = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription"), num);
                choiceName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "ChoiceName"), num);
                choiceDescription = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "ChoiceDesciption"), num);
                option1Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Option1Name"), num);
                option1Price = TestData.ExcelData.TestDataReader.ReadData(1, "Option1Price");
                option2Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Option2Name"), num);
                option2price = TestData.ExcelData.TestDataReader.ReadData(1, "Option2Price");
                menuNameAddOns = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuNameAddOns"), num);
                menuDescriptionAddOns = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescriptionAddOns"), num);
                add_On_Title = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Title"), num);
                add_On1_Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Add_On1_Name"), num);
                add_On1_Description = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Add_On1_Description"), num);
                add_On1_Price = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On1_Price");
                add_On2_Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Add_On2_Name"), num);
                add_On2_Description = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Add_On2_Description"), num);
                add_On2_Price = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On2_Price");
                updateText = TestData.ExcelData.TestDataReader.ReadData(1, "updateText");

                //Login to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoPropertyLITE(propertyCorporate);

                //Navigate to Cendyn Admin 
                PropertyAdmin.Navigate_CendynAdmin();

                //Click Supplier tab
                CendynAdmin.Supplier_Tab();
                Logger.WriteDebugMessage("landed on supplier page");
                CendynAdmin.Click_category();
                Logger.WriteDebugMessage("Landed on Category page");

                //Add Category
                CendynAdmin.AddSingleCategory(categoryName);

                //Navigate to Property Admin
                CendynAdmin.NavigateToPropertyAdmin();

                // Select Property
                PropertyAdmin.SwitchProperty(propertyCorporate);

                //Navigate to Breaks Category
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                Helper.AddDelay(9000);

                //Update Category Desc
                PropertyAdmin.editCategoryDesc(categoryDesc);

                //Add Menu with the choices
                PropertyAdmin.Menu_WithChoices(menuName, menuDescription, choiceName, choiceDescription, option1Name, option1Price, option2Name, option2price);

                //Add Menu with Add on
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Menu_WithAddOn(menuNameAddOns, menuDescriptionAddOns, add_On_Title, add_On1_Name, add_On1_Description, add_On1_Price, add_On2_Name, add_On2_Description, add_On2_Price);

                //Publish
                PropertyAdmin.Publish_Changes();

                //Navigate to Cendyn Admin 
                PropertyAdmin.Navigate_CendynAdmin();

                //Click Supplier tab
                CendynAdmin.Supplier_Tab();
                Logger.WriteDebugMessage("landed on supplier page");
                CendynAdmin.Click_category();
                Logger.WriteDebugMessage("Landed on Category page");

                //Update Category Name 
                CendynAdmin.Edit_SingleCategory(categoryName, updateText);

                //Navigate to Property Admin
                CendynAdmin.NavigateToPropertyAdmin();

                //Navigate to Home Page and Select Property
                PropertyAdmin.SwitchProperty(propertyCorporate);

                //Navigate to Breaks Category
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                Helper.AddDelay(9000);

                //Update Category Desc
                PropertyAdmin.editCategoryDesc(categoryDesc + updateText);

                //Update Menu Item with Add Ons
                ElementHover(PageObject_PropertyAdmin.Hover_MenuName(menuNameAddOns));
                PropertyAdmin.Click_EditMenu_Button(menuNameAddOns);
                PropertyAdmin.EditMenuAddOns(menuNameAddOns + updateText, menuDescriptionAddOns + updateText, add_On_Title + updateText, add_On1_Name + updateText, add_On1_Description + updateText, add_On1_Price, add_On2_Name + updateText, add_On2_Description + updateText, add_On2_Price);

                //Update Menu Item with Choices
                ElementHover(PageObject_PropertyAdmin.Hover_MenuName(menuName));
                PropertyAdmin.Click_EditMenu_Button(menuName);
                PropertyAdmin.EditMenuChoices(menuName + updateText, menuDescription + updateText, choiceName + updateText, choiceDescription + updateText, option1Name + updateText, option1Price, option2Name + updateText, option2price);

                //Navigate to Lite Property 
                PropertyAdmin.SwitchProperty(propertyLite);

                //Navigate to Breaks Category
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                Helper.AddDelay(9000);

                //Confirm Items on page
                PropertyAdmin.Verify_LITE_SyncToLite(categoryName, categoryDesc, menuName, menuDescription, choiceName,
                    choiceDescription, option1Name, option2Name, menuNameAddOns,
                    menuDescriptionAddOns, add_On_Title, add_On1_Name, add_On1_Description,
                    add_On2_Name, add_On2_Description);
                //Confirm update not showing
                Helper.VerifyTextNOTOnPage(no + updateText);
                Logger.WriteInfoMessage("Updated value is not found on page.");

                //Verify Menu Filters did not sync
                PropertyAdmin.Verify_Menu_NoFilter(menuName);

                Logger.WriteDebugMessage("None of updated values sync to LITE property Web View without Publish");
                Helper.ExitFrame();

                //Navigate to PDF View
                PropertyAdmin.Click_Link_PDF_View();

                //Navigate to Breaks Category
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                Helper.AddDelay(9000);

                //Confirm Items on page
                PropertyAdmin.Verify_LITE_SyncToLite(categoryName, categoryDesc, menuName, menuDescription, choiceName,
                    choiceDescription, option1Name, option2Name, menuNameAddOns,
                    menuDescriptionAddOns, add_On_Title, add_On1_Name, add_On1_Description,
                    add_On2_Name, add_On2_Description);
                //Confirm update not showing
                Helper.VerifyTextNOTOnPage(no + updateText);
                Logger.WriteInfoMessage("Updated value is not found on page.");

                Logger.WriteDebugMessage("None of updated values sync to LITE property PDF View without Publish");

                //Navigate to Preview
                Helper.ExitFrame();
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.Click_MyMenu_Breaks();

                //Confirm Items on page
                PropertyAdmin.Verify_LITE_SyncToLite(categoryName, categoryDesc, menuName, menuDescription, choiceName,
                    choiceDescription, option1Name, option2Name, menuNameAddOns,
                    menuDescriptionAddOns, add_On_Title, add_On1_Name, add_On1_Description,
                    add_On2_Name, add_On2_Description);
                //Confirm update not showing
                Helper.VerifyTextNOTOnPage(no + updateText);
                Logger.WriteInfoMessage("Updated value is not found on page.");

                //Verify Menu Filters did not sync
                PropertyAdmin.Verify_Menu_NoFilter(menuName);

                Logger.WriteDebugMessage("None of updated values sync to LITE property Preview without Publish");

                Helper.CloseWindow();
                Helper.ControlToPreviousWindow();

                //Navigate to Published View

                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Published View window should get displayed");
                PropertyAdmin.Click_MyMenu_Breaks();

                //Confirm Items on page
                PropertyAdmin.Verify_LITE_SyncToLite(categoryName, categoryDesc, menuName, menuDescription, choiceName,
                    choiceDescription, option1Name, option2Name, menuNameAddOns,
                    menuDescriptionAddOns, add_On_Title, add_On1_Name, add_On1_Description,
                    add_On2_Name, add_On2_Description);

                //Confirm update not showing
                Helper.VerifyTextNOTOnPage(no + updateText);
                Logger.WriteInfoMessage("Updated value is not found on page.");

                //Verify Menu Filters did not sync
                PropertyAdmin.Verify_Menu_NoFilter(menuName);

                Logger.WriteDebugMessage("None of updated values sync to LITE property Published View without Publish");

                Helper.CloseWindow();
                Helper.ControlToPreviousWindow();

                //Navigate back to Corporate Property Web View
                PropertyAdmin.SwitchProperty(propertyCorporate);
                PropertyAdmin.Click_Link_Web_View();

                //Navigate to Breaks Category
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                Helper.AddDelay(9000);

                //Remove Added Data
                Helper.ExitFrame();
                PropertyAdmin.Delete_Menu(menuName + updateText);
                Helper.ExitFrame();
                PropertyAdmin.Delete_Menu(menuNameAddOns + updateText);
                Helper.ExitFrame();

                //Navigate Back to Cendyn Admin
                PropertyAdmin.Navigate_CendynAdmin();

                //Click Supplier tab
                CendynAdmin.Supplier_Tab();
                Logger.WriteDebugMessage("landed on supplier page");
                CendynAdmin.Click_category();
                Logger.WriteDebugMessage("Landed on Category page");

                //Delete Category
                CendynAdmin.DeleteCategory(categoryName + updateText);

                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name Corporate", propertyCorporate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name LITE", propertyLite);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Admin Username", propertyAdmin_Username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Category Name", categoryName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Category Descripton", categoryDesc);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name_Choices", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Description", menuDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Choice Name", choiceName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Choice Description", choiceDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_1 Name", option1Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_1 Price", option1Price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_2 Name", option2Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_2 Price", option2price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name_AddOns", menuNameAddOns);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Description_AddOns", menuDescriptionAddOns);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On Tile", add_On_Title);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 1 Name", add_On1_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 1 Description", add_On1_Description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add on 1 Price", add_On1_Price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 2 Name", add_On2_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 2 Description", add_On2_Description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add on 2 Price", add_On2_Price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Updated Value", updateText, true);
            }
        }
        public static void TC_232423()
        {
            if (TestCaseId == Utility.Constants.TC_232423)
            {
                //Pre-Requisites
                string propertyAdmin_Username, password, propertyCorporate, propertyLite, categoryName, categoryDesc, menuName, menuDescription, choiceName,
                    choiceDescription, option1Name, option1Price, option2Name, option2price, menuNameAddOns,
                    menuDescriptionAddOns, add_On_Title, add_On1_Name, add_On1_Description,
                    add_On1_Price, add_On2_Name, add_On2_Description, add_On2_Price, num, updateText;
                Random no = new Random();
                num = no.Next().ToString();

                //Retrieve data from test Data
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyCorporate = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyCorporate");
                propertyLite = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyLITE");
                categoryName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "CategoryName"), num);
                categoryDesc = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "CategoryDesc"), num);
                menuName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuName"), num);
                menuDescription = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription"), num);
                choiceName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "ChoiceName"), num);
                choiceDescription = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "ChoiceDesciption"), num);
                option1Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Option1Name"), num);
                option1Price = TestData.ExcelData.TestDataReader.ReadData(1, "Option1Price");
                option2Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Option2Name"), num);
                option2price = TestData.ExcelData.TestDataReader.ReadData(1, "Option2Price");
                menuNameAddOns = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuNameAddOns"), num);
                menuDescriptionAddOns = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescriptionAddOns"), num);
                add_On_Title = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Title"), num);
                add_On1_Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Add_On1_Name"), num);
                add_On1_Description = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Add_On1_Description"), num);
                add_On1_Price = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On1_Price");
                add_On2_Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Add_On2_Name"), num);
                add_On2_Description = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Add_On2_Description"), num);
                add_On2_Price = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On2_Price");
                updateText = TestData.ExcelData.TestDataReader.ReadData(1, "updateText");

                //Login to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoPropertyLITE(propertyCorporate);

                //Navigate to Cendyn Admin 
                PropertyAdmin.Navigate_CendynAdmin();

                //Click Supplier tab
                CendynAdmin.Supplier_Tab();
                Logger.WriteDebugMessage("landed on supplier page");
                CendynAdmin.Click_category();
                Logger.WriteDebugMessage("Landed on Category page");

                //Add Category
                CendynAdmin.AddSingleCategory(categoryName);

                //Navigate to Property Admin
                CendynAdmin.NavigateToPropertyAdmin();

                // Select Property
                PropertyAdmin.SwitchProperty(propertyCorporate);

                //Navigate to Breaks Category
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                Helper.AddDelay(9000);

                //Update Category Desc
                PropertyAdmin.editCategoryDesc(categoryDesc);

                //Add Menu with the choices
                PropertyAdmin.Menu_WithChoices(menuName, menuDescription, choiceName, choiceDescription, option1Name, option1Price, option2Name, option2price);

                //Add Menu with Add on
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Menu_WithAddOn(menuNameAddOns, menuDescriptionAddOns, add_On_Title, add_On1_Name, add_On1_Description, add_On1_Price, add_On2_Name, add_On2_Description, add_On2_Price);

                //Publish
                PropertyAdmin.Publish_Changes();

                //Navigate to Cendyn Admin 
                PropertyAdmin.Navigate_CendynAdmin();

                //Click Supplier tab
                CendynAdmin.Supplier_Tab();
                Logger.WriteDebugMessage("landed on supplier page");
                CendynAdmin.Click_category();
                Logger.WriteDebugMessage("Landed on Category page");

                //Update Category Name 
                CendynAdmin.Edit_SingleCategory(categoryName, updateText);

                //Navigate to Property Admin
                CendynAdmin.NavigateToPropertyAdmin();

                //Navigate to Home Page and Select Property
                PropertyAdmin.SwitchProperty(propertyCorporate);


                //Navigate to Breaks Category
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                Helper.AddDelay(9000);

                //Update Category Desc
                PropertyAdmin.editCategoryDesc(categoryDesc + updateText);

                //Update Menu Item with Choices
                ElementHover(PageObject_PropertyAdmin.Hover_MenuName(menuNameAddOns));
                PropertyAdmin.Click_EditMenu_Button(menuNameAddOns);
                PropertyAdmin.EditMenuAddOns(menuNameAddOns + updateText, menuDescriptionAddOns + updateText, add_On_Title + updateText, add_On1_Name + updateText, add_On1_Description + updateText, add_On1_Price, add_On2_Name + updateText, add_On2_Description + updateText, add_On2_Price);

                //Update Menu Item with Choices
                ElementHover(PageObject_PropertyAdmin.Hover_MenuName(menuName));
                PropertyAdmin.Click_EditMenu_Button(menuName);
                PropertyAdmin.EditMenuChoices(menuName + updateText, menuDescription + updateText, choiceName + updateText, choiceDescription + updateText, option1Name + updateText, option1Price, option2Name + updateText, option2price);

                //Cancel Publish
                PropertyAdmin.Click_Publish_Button();
                Logger.WriteDebugMessage("Changes are displaying on Overlay and Needs to Publish");
                PropertyAdmin.Click_Form_Cancel_Button();
                Logger.WriteInfoMessage("Publish was Cancelled.");

                //Navigate to Lite Property 
                PropertyAdmin.SwitchProperty(propertyLite);

                //Navigate to Breaks Category
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                Helper.AddDelay(9000);

                //Confirm Items on page
                PropertyAdmin.Verify_LITE_SyncToLite(categoryName, categoryDesc, menuName, menuDescription, choiceName,
                    choiceDescription, option1Name, option2Name, menuNameAddOns,
                    menuDescriptionAddOns, add_On_Title, add_On1_Name, add_On1_Description,
                    add_On2_Name, add_On2_Description);
                //Confirm update not showing
                Helper.VerifyTextNOTOnPage(no + updateText);
                Logger.WriteInfoMessage("Updated value is not found on page.");

                //Verify Menu Filters did not sync
                PropertyAdmin.Verify_Menu_NoFilter(menuName);

                Logger.WriteDebugMessage("None of updated values sync to LITE property Web View without Publish");
                Helper.ExitFrame();

                //Navigate to PDF View
                PropertyAdmin.Click_Link_PDF_View();

                //Navigate to Breaks Category
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                Helper.AddDelay(9000);

                //Confirm Items on page
                PropertyAdmin.Verify_LITE_SyncToLite(categoryName, categoryDesc, menuName, menuDescription, choiceName,
                    choiceDescription, option1Name, option2Name, menuNameAddOns,
                    menuDescriptionAddOns, add_On_Title, add_On1_Name, add_On1_Description,
                    add_On2_Name, add_On2_Description);
                //Confirm update not showing
                Helper.VerifyTextNOTOnPage(no + updateText);
                Logger.WriteInfoMessage("Updated value is not found on page.");

                Logger.WriteDebugMessage("None of updated values sync to LITE property PDF View without Publish");

                //Navigate to Preview
                Helper.ExitFrame();
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.Click_MyMenu_Breaks();

                //Confirm Items on page
                PropertyAdmin.Verify_LITE_SyncToLite(categoryName, categoryDesc, menuName, menuDescription, choiceName,
                    choiceDescription, option1Name, option2Name, menuNameAddOns,
                    menuDescriptionAddOns, add_On_Title, add_On1_Name, add_On1_Description,
                    add_On2_Name, add_On2_Description);
                //Confirm update not showing
                Helper.VerifyTextNOTOnPage(no + updateText);
                Logger.WriteInfoMessage("Updated value is not found on page.");

                //Verify Menu Filters did not sync
                PropertyAdmin.Verify_Menu_NoFilter(menuName);

                Logger.WriteDebugMessage("None of updated values sync to LITE property Preview without Publish");

                Helper.CloseWindow();
                Helper.ControlToPreviousWindow();

                //Navigate to Published View

                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Published View window should get displayed");
                PropertyAdmin.Click_MyMenu_Breaks();

                //Confirm Items on page
                PropertyAdmin.Verify_LITE_SyncToLite(categoryName, categoryDesc, menuName, menuDescription, choiceName,
                    choiceDescription, option1Name, option2Name, menuNameAddOns,
                    menuDescriptionAddOns, add_On_Title, add_On1_Name, add_On1_Description,
                    add_On2_Name, add_On2_Description);

                //Confirm update not showing
                Helper.VerifyTextNOTOnPage(no + updateText);
                Logger.WriteInfoMessage("Updated value is not found on page.");

                //Verify Menu Filters did not sync
                PropertyAdmin.Verify_Menu_NoFilter(menuName);

                Logger.WriteDebugMessage("None of updated values sync to LITE property Published View without Publish");

                Helper.CloseWindow();
                Helper.ControlToPreviousWindow();

                //Navigate back to Corporate Property Web View
                PropertyAdmin.SwitchProperty(propertyCorporate);
                PropertyAdmin.Click_Link_Web_View();

                //Navigate to Breaks Category
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                Helper.AddDelay(9000);

                //Remove Added Data
                Helper.ExitFrame();
                PropertyAdmin.Delete_Menu(menuName + updateText);
                Helper.ExitFrame();
                PropertyAdmin.Delete_Menu(menuNameAddOns + updateText);
                Helper.ExitFrame();

                //Navigate Back to Cendyn Admin
                PropertyAdmin.Navigate_CendynAdmin();

                //Click Supplier tab
                CendynAdmin.Supplier_Tab();
                Logger.WriteDebugMessage("landed on supplier page");
                CendynAdmin.Click_category();
                Logger.WriteDebugMessage("Landed on Category page");

                //Delete Category
                CendynAdmin.DeleteCategory(categoryName + updateText);

                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name Corporate", propertyCorporate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name LITE", propertyLite);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Admin Username", propertyAdmin_Username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Category Name", categoryName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Category Descripton", categoryDesc);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name_Choices", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Description", menuDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Choice Name", choiceName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Choice Description", choiceDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_1 Name", option1Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_1 Price", option1Price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_2 Name", option2Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_2 Price", option2price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name_AddOns", menuNameAddOns);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Description_AddOns", menuDescriptionAddOns);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On Tile", add_On_Title);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 1 Name", add_On1_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 1 Description", add_On1_Description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add on 1 Price", add_On1_Price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 2 Name", add_On2_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 2 Description", add_On2_Description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add on 2 Price", add_On2_Price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Updated Value", updateText, true);
            }
        }
        public static void TC_231050()
        {
            if (TestCaseId == Utility.Constants.TC_231050)
            {

                //Pre-Requisites
                string propertyAdmin_Username, password, propertyCorporate, propertyLite, categoryName, categoryDesc, menuName, menuDescription, choiceName,
                    choiceDescription, option1Name, option1Price, option2Name, option2price, menuNameAddOns,
                    menuDescriptionAddOns, add_On_Title, add_On1_Name, add_On1_Description,
                    add_On1_Price, add_On2_Name, add_On2_Description, add_On2_Price, num, updateText;
                Random no = new Random();
                num = no.Next().ToString();

                //Retrieve data from test Data
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyCorporate = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyCorporate");
                propertyLite = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyLITE");
                categoryName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "CategoryName"), num);
                categoryDesc = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "CategoryDesc"), num);
                menuName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuName"), num);
                menuDescription = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription"), num);
                choiceName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "ChoiceName"), num);
                choiceDescription = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "ChoiceDesciption"), num);
                option1Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Option1Name"), num);
                option1Price = TestData.ExcelData.TestDataReader.ReadData(1, "Option1Price");
                option2Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Option2Name"), num);
                option2price = TestData.ExcelData.TestDataReader.ReadData(1, "Option2Price");
                menuNameAddOns = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuNameAddOns"), num);
                menuDescriptionAddOns = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescriptionAddOns"), num);
                add_On_Title = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Title"), num);
                add_On1_Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Add_On1_Name"), num);
                add_On1_Description = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Add_On1_Description"), num);
                add_On1_Price = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On1_Price");
                add_On2_Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Add_On2_Name"), num);
                add_On2_Description = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Add_On2_Description"), num);
                add_On2_Price = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On2_Price");
                updateText = TestData.ExcelData.TestDataReader.ReadData(1, "updateText");
 
                //Login to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoPropertyLITE(propertyCorporate);

                //Navigate to Cendyn Admin 
                PropertyAdmin.Navigate_CendynAdmin();

                //Click Supplier tab
                CendynAdmin.Supplier_Tab();
                Logger.WriteDebugMessage("landed on supplier page");
                CendynAdmin.Click_category();
                Logger.WriteDebugMessage("Landed on Category page");

                //Add Category
                CendynAdmin.AddSingleCategory(categoryName);

                //Navigate to Property Admin
                CendynAdmin.NavigateToPropertyAdmin();

                // Select Property
                PropertyAdmin.SwitchProperty(propertyCorporate);

                //Navigate to Breaks Category
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                Helper.AddDelay(9000);

                //Update Category Desc
                PropertyAdmin.editCategoryDesc(categoryDesc);

                //Add Menu with the choices
                PropertyAdmin.Menu_WithChoices(menuName, menuDescription, choiceName, choiceDescription, option1Name, option1Price, option2Name, option2price);

                //Add Menu with Add on
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Menu_WithAddOn(menuNameAddOns, menuDescriptionAddOns, add_On_Title, add_On1_Name, add_On1_Description, add_On1_Price, add_On2_Name, add_On2_Description, add_On2_Price);

                //Publish
                PropertyAdmin.Publish_Changes();

                //Navigate to Cendyn Admin 
                PropertyAdmin.Navigate_CendynAdmin();

                //Click Supplier tab
                CendynAdmin.Supplier_Tab();
                Logger.WriteDebugMessage("landed on supplier page");
                CendynAdmin.Click_category();
                Logger.WriteDebugMessage("Landed on Category page");

                //Update Category Name 
                CendynAdmin.Edit_SingleCategory(categoryName, updateText);

                //Navigate to Property Admin
                CendynAdmin.NavigateToPropertyAdmin();

                //Navigate to Home Page and Select Property
                PropertyAdmin.SwitchProperty(propertyCorporate);


                //Navigate to Breaks Category
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                Helper.AddDelay(9000);

                //Update Category Desc
                PropertyAdmin.editCategoryDesc(categoryDesc + updateText);

                //Update Menu Item with Choices
                ElementHover(PageObject_PropertyAdmin.Hover_MenuName(menuNameAddOns));
                PropertyAdmin.Click_EditMenu_Button(menuNameAddOns);
                PropertyAdmin.EditMenuAddOns(menuNameAddOns + updateText, menuDescriptionAddOns + updateText, add_On_Title + updateText, add_On1_Name + updateText, add_On1_Description + updateText, add_On1_Price, add_On2_Name + updateText, add_On2_Description + updateText, add_On2_Price);

                //Update Menu Item with Choices
                ElementHover(PageObject_PropertyAdmin.Hover_MenuName(menuName));
                PropertyAdmin.Click_EditMenu_Button(menuName);
                PropertyAdmin.EditMenuChoices(menuName + updateText, menuDescription + updateText, choiceName + updateText, choiceDescription + updateText, option1Name + updateText, option1Price, option2Name + updateText, option2price);

                //Publish
                PropertyAdmin.Publish_Changes();

                //Navigate to Lite Property 
                PropertyAdmin.SwitchProperty(propertyLite);

                //Navigate to Breaks Category
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                Helper.AddDelay(9000);

                //Confirm Items on page
                PropertyAdmin.Verify_LITE_SyncToLite(categoryName + updateText, categoryDesc + updateText, menuName + updateText, menuDescription + updateText, choiceName + updateText,
                    choiceDescription + updateText, option1Name + updateText, option2Name + updateText, menuNameAddOns + updateText,
                    menuDescriptionAddOns + updateText, add_On_Title + updateText, add_On1_Name + updateText, add_On1_Description + updateText,
                    add_On2_Name + updateText, add_On2_Description + updateText);

                //Verify Menu Filters did sync
                PropertyAdmin.Verify_Menu_Filter(menuName);

                Logger.WriteDebugMessage("All of values sync to LITE property Web View with Publish");
                Helper.ExitFrame();

                //Navigate to PDF View
                PropertyAdmin.Click_Link_PDF_View();

                //Navigate to Breaks Category
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                Helper.AddDelay(9000);

                //Confirm Items on page
                PropertyAdmin.Verify_LITE_SyncToLite(categoryName + updateText, categoryDesc + updateText, menuName + updateText, menuDescription + updateText, choiceName + updateText,
                    choiceDescription + updateText, option1Name + updateText, option2Name + updateText, menuNameAddOns + updateText,
                    menuDescriptionAddOns + updateText, add_On_Title + updateText, add_On1_Name + updateText, add_On1_Description + updateText,
                    add_On2_Name + updateText, add_On2_Description + updateText);

                Logger.WriteDebugMessage("All of values sync to LITE property PDF View with Publish");

                //Navigate to Preview
                Helper.ExitFrame();
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.Click_MyMenu_Breaks();

                //Confirm Items on page
                PropertyAdmin.Verify_LITE_SyncToLite(categoryName + updateText, categoryDesc + updateText, menuName + updateText, menuDescription + updateText, choiceName + updateText,
                     choiceDescription + updateText, option1Name + updateText, option2Name + updateText, menuNameAddOns + updateText,
                     menuDescriptionAddOns + updateText, add_On_Title + updateText, add_On1_Name + updateText, add_On1_Description + updateText,
                     add_On2_Name + updateText, add_On2_Description + updateText);

                //Verify Menu Filters did sync
                PropertyAdmin.Verify_Menu_Filter(menuName);

                Logger.WriteDebugMessage("All of values sync to LITE property Preview with Publish");

                Helper.CloseWindow();
                Helper.ControlToPreviousWindow();

                //Navigate to Published View

                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Published View window should get displayed");
                PropertyAdmin.Click_MyMenu_Breaks();

                //Confirm Items on page
                PropertyAdmin.Verify_LITE_SyncToLite(categoryName + updateText, categoryDesc + updateText, menuName + updateText, menuDescription + updateText, choiceName + updateText,
                     choiceDescription + updateText, option1Name + updateText, option2Name + updateText, menuNameAddOns + updateText,
                     menuDescriptionAddOns + updateText, add_On_Title + updateText, add_On1_Name + updateText, add_On1_Description + updateText,
                     add_On2_Name + updateText, add_On2_Description + updateText);

                //Verify Menu Filters did sync
                PropertyAdmin.Verify_Menu_Filter(menuName);

                Logger.WriteDebugMessage("All of values sync to LITE property Published View with Publish");

                Helper.CloseWindow();
                Helper.ControlToPreviousWindow();

                //Navigate back to Corporate Property Web View
                PropertyAdmin.SwitchProperty(propertyCorporate);
                PropertyAdmin.Click_Link_Web_View();

                //Navigate to Breaks Category
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                Helper.AddDelay(9000);

                //Remove Added Data
                Helper.ExitFrame();
                PropertyAdmin.Delete_Menu(menuName + updateText);
                Helper.ExitFrame();
                PropertyAdmin.Delete_Menu(menuNameAddOns + updateText);
                Helper.ExitFrame();

                //Navigate Back to Cendyn Admin
                PropertyAdmin.Navigate_CendynAdmin();

                //Click Supplier tab
                CendynAdmin.Supplier_Tab();
                Logger.WriteDebugMessage("landed on supplier page");
                CendynAdmin.Click_category();
                Logger.WriteDebugMessage("Landed on Category page");

                //Delete Category
                CendynAdmin.DeleteCategory(categoryName + updateText);

                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name Corporate", propertyCorporate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name LITE", propertyLite);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Admin Username", propertyAdmin_Username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Category Name", categoryName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Category Descripton", categoryDesc);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name_Choices", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Description", menuDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Choice Name", choiceName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Choice Description", choiceDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_1 Name", option1Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_1 Price", option1Price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_2 Name", option2Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_2 Price", option2price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name_AddOns", menuNameAddOns);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Description_AddOns", menuDescriptionAddOns);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On Tile", add_On_Title);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 1 Name", add_On1_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 1 Description", add_On1_Description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add on 1 Price", add_On1_Price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 2 Name", add_On2_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 2 Description", add_On2_Description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add on 2 Price", add_On2_Price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Updated Value", updateText, true);
            }
        }
        public static void TC_231214()
        {
            if (TestCaseId == Utility.Constants.TC_231214)
            {
                //Pre-Requisite
                string propertyCorporate, propertyLite, shareMenu, settingsUnavailable, inheritedMessage, propertyUrl;

                //Retrieve data from Test data
                propertyCorporate = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyCorporate");
                propertyLite = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyLite");
                shareMenu = TestData.ExcelData.TestDataReader.ReadData(1, "ShareMenu");
                settingsUnavailable = TestData.ExcelData.TestDataReader.ReadData(1, "SettingsUnavailable_Message");
                inheritedMessage = TestData.ExcelData.TestDataReader.ReadData(1, "BasicSettings_inheritedMessage");
                propertyUrl = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyUrl");
                
                //Login to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to eMenus Lite 
                PropertyAdmin.Click_Navigation_eMenusLITE();
                Logger.WriteDebugMessage("eMenus Lite Product got Selected ");

                //Navigate to Cendyn Admin 
                PropertyAdmin.Navigate_CendynAdmin();

                // Verify Lite Property Basic Settings show as Inherited
                CendynAdmin.NavigatetoCendynProperty(propertyLite);
                CendynAdmin.Click_Property_BasicSettings_Tab();
                Logger.WriteDebugMessage("Landed on Basic Setting Page");
                VerifyTextOnPageAndHighLight(settingsUnavailable);
                VerifyTextOnPageAndHighLight(inheritedMessage);

                //Navigate to property admin
                Helper.OpenNewTab();
                Helper.ControlToNewWindow();
                Helper.Driver.Url = propertyUrl;
                Logger.WriteDebugMessage("Landed on Property admin page");


                //Select Property for property admin
                PropertyAdmin.Click_Select_PropertyDropdown();
                Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
                PropertyAdmin.Enter_Property_TextBox(propertyLite);
                Logger.WriteDebugMessage("Entered Property");
                PropertyAdmin.Select_Property_Dropdown(propertyLite);
                Logger.WriteDebugMessage(propertyCorporate + " Property got Selected");

                //Check basic setting for Share menu
                ControlToPreviousWindow();
                Logger.WriteDebugMessage("Switched back to Cendyn Admin");
                CendynAdmin.NavigatetoCendynProperty(propertyCorporate);
                CendynAdmin.Click_Property_BasicSettings_Tab();
                Logger.WriteDebugMessage("Landed on Basic Setting Page");
                CendynAdmin.Click_ShareMenu_NoButton();
                Logger.WriteDebugMessage("No button selected for share menu");
                PageDown();
                CendynAdmin.Click_BasicSettings_UpdateButton();
                Logger.WriteDebugMessage("No button selected for share menu and Setting should get updated");
                ControlToNextWindow();
                Logger.WriteDebugMessage("Switched back to Property Admin page of lite property");
                ReloadPage();
                if (IsWebElementRemoved(PageObject_CendynAdmin.Click_MyMenu_ShareTab()))
                    Assert.Fail("Share menu tab still present on the page");
                else
                    Logger.WriteDebugMessage("Share menu tab removed from the property admin");

                ControlToPreviousWindow();
                Logger.WriteDebugMessage("Switched back to Cendyn Admin page of Corporate property");
                CendynAdmin.Click_Property_BasicSettings_Tab();
                Logger.WriteDebugMessage("Landed on Basic Setting Page");
                CendynAdmin.Click_ShareMenu_YesButton();
                CendynAdmin.Click_BasicSettings_UpdateButton();
                Logger.WriteDebugMessage("Yes button selected for share menu and Setting should get updated");

                ControlToNextWindow();
                Logger.WriteDebugMessage("Switched back to Property Admin page of lite property");
                ReloadPage();
                ElementWait(PageObject_PropertyAdmin.Click_Select_PropertyDropdown(), 60);
                VerifyTextOnPageAndHighLight(shareMenu);
                Logger.WriteDebugMessage("Share menu tab displayed on the page of lite property");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Corporate Property Name", propertyCorporate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Lite Property Name", propertyLite);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Settings Unavailable Message", settingsUnavailable);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Settings Inherited Message", inheritedMessage, true);
            }
        }
        public static void TC_231215()
        {
            if (TestCaseId == Utility.Constants.TC_231215)
            {
                //Pre-Requisite
                string propertyCorporate, propertyLite, menuImage_Text, settingsUnavailable, inheritedMessage, propertyUrl;

                //Retrieve data from Test data
                propertyCorporate = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyCorporate");
                propertyLite = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyLite");
                menuImage_Text = TestData.ExcelData.TestDataReader.ReadData(1, "MenuImage_Text");
                settingsUnavailable = TestData.ExcelData.TestDataReader.ReadData(1, "SettingsUnavailable_Message");
                inheritedMessage = TestData.ExcelData.TestDataReader.ReadData(1, "AdvancedSettings_inherited_Message");
                propertyUrl = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyUrl");

                //Login to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to eMenus Lite 
                PropertyAdmin.Click_Navigation_eMenusLITE();
                Logger.WriteDebugMessage("eMenus Lite Product got Selected ");

                //Navigate to Cendyn Admin 
                PropertyAdmin.Navigate_CendynAdmin();

                // Verify Lite Property Basic Settings show as Inherited
                CendynAdmin.NavigatetoCendynProperty(propertyLite);
                CendynAdmin.Click_AdvancedSettings_Tab();
                Logger.WriteDebugMessage("Landed on Advanced Setting Page");
                VerifyTextOnPageAndHighLight(settingsUnavailable);
                VerifyTextOnPageAndHighLight(inheritedMessage);

                //Navigate to property admin
                Helper.OpenNewTab();
                Helper.ControlToNewWindow();
                Helper.Driver.Url = propertyUrl;
                Logger.WriteDebugMessage("Landed on Property admin page");

                //Select Property for property admin
                PropertyAdmin.Click_Select_PropertyDropdown();
                Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
                PropertyAdmin.Enter_Property_TextBox(propertyLite);
                Logger.WriteDebugMessage("Entered Property");
                PropertyAdmin.Select_Property_Dropdown(propertyLite);
                Logger.WriteDebugMessage(propertyLite + " Property got Selected");

                //Check advance settings for menu image as No
                ControlToPreviousWindow();
                PageUp();
                Logger.WriteDebugMessage("Switched back to Cendyn Admin");
                CendynAdmin.NavigatetoCendynProperty(propertyCorporate);
                CendynAdmin.Click_AdvancedSettings_Tab();
                CendynAdmin.Click_MenuImage_NoButton();
                Logger.WriteDebugMessage("Menu image button selected as No");
                Helper.ScrollToElement(PageObject_CendynAdmin.Click_AdvancedSettings_UpdateButton());
                CendynAdmin.Click_AdvancedSettings_UpdateButton();
                Logger.WriteDebugMessage("Menu image setting updated successfully on Corporate property");

                // Verify menu image field in Property admin 
                ControlToNextWindow();
                Logger.WriteDebugMessage("Switched back to Property Admin page of lite property");
                ReloadPage();
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_SpecialOffers();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                Logger.WriteDebugMessage("Navigated to Menu Page");
                PropertyAdmin.Click_MyMenu_AddNewMenu();
                ExitFrame();
                if (IsWebElementRemoved(PageObject_CendynAdmin.Click_AddNewMenu_UploadImageButton()))
                    Assert.Fail("Menu Image field displayed on the page ");
                else
                    Logger.WriteDebugMessage("Menu Image field removed from the page");

                //Check advance settings for menu image as Yes
                ControlToPreviousWindow();
                Logger.WriteDebugMessage("Switched back to Cendyn Admin page of Corporate property");
                CendynAdmin.Click_AdvancedSettings_Tab();
                CendynAdmin.Click_MenuImage_YesButton();
                Logger.WriteDebugMessage("Menu image button selected as Yes");
                Helper.ScrollToElement(PageObject_CendynAdmin.Click_AdvancedSettings_UpdateButton());
                CendynAdmin.Click_AdvancedSettings_UpdateButton();
                Logger.WriteDebugMessage("Menu image setting updated successfully");

                // Verify menu image field in Property admin 
                ControlToNextWindow();
                Logger.WriteDebugMessage("Switched back to Property Admin page of lite property");
                ReloadPage();
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_SpecialOffers();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                Logger.WriteDebugMessage("Navigated to Menu Page");
                PropertyAdmin.Click_MyMenu_AddNewMenu();
                ExitFrame();
                VerifyTextOnPageAndHighLight(menuImage_Text);
                Logger.WriteDebugMessage("Menu Image field displayed on the page");
                PropertyAdmin.Click_AddNewMenu_CancelButton();


                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Corporate Property Name", propertyCorporate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Lite Property Name", propertyLite);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Image Text", menuImage_Text);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Settings Unavailable Message", settingsUnavailable);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Settings Inherited Message", inheritedMessage, true);
            }
        }
        public static void TC_231216()
        {
            if (TestCaseId == Utility.Constants.TC_231216)
            {
                //Pre-Requisite
                string propertyCorporate, propertyLite, settingsUnavailable, inheritedMessage, imagePath, propertyUrl;

                //Retrieve data from Test data
                propertyCorporate = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyCorporate");
                propertyLite = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyLite");
                settingsUnavailable = TestData.ExcelData.TestDataReader.ReadData(1, "SettingsUnavailable_Message");
                inheritedMessage = TestData.ExcelData.TestDataReader.ReadData(1, "SupplierSettings_inheritedMessage");
                imagePath = String.Concat(ProjectPath, TestData.ExcelData.TestDataReader.ReadData(1, "ImagePath"));
                propertyUrl = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyUrl");

                //Login to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to eMenus Lite 
                PropertyAdmin.Click_Navigation_eMenusLITE();
                Logger.WriteDebugMessage("eMenus Lite Product got Selected ");

                //Navigate to Cendyn Admin 
                PropertyAdmin.Navigate_CendynAdminLite();

                // Verify Lite Property Supplier Settings show as Inherited
                CendynAdmin.NavigatetoCendynProperty(propertyLite);
                CendynAdmin.Supplier_Tab();
                CendynAdmin.Click_SupplierSettings_Tab();
                Logger.WriteDebugMessage("Landed on Supplier Settings Page");
                VerifyTextOnPageAndHighLight(settingsUnavailable);
                VerifyTextOnPageAndHighLight(inheritedMessage);

                //Navigate to property admin
                Helper.OpenNewTab();
                Helper.ControlToNewWindow();
                Helper.Driver.Url = propertyUrl;
                Logger.WriteDebugMessage("Landed on Property admin page");

                //Select Property for property admin
                PropertyAdmin.SwitchProperty(propertyLite);

                //Check Supplier settings for no logo
                ControlToPreviousWindow();
                PageUp();
                Logger.WriteDebugMessage("Switched back to Cendyn Admin");
                CendynAdmin.NavigatetoCendynProperty(propertyCorporate);
                CendynAdmin.Supplier_Tab();
                CendynAdmin.Click_SupplierSettings_Tab();
                Logger.WriteDebugMessage("Landed on Supplier Settings Page");
                CendynAdmin.Click_LogoImage_Delete();
                VerifyTextOnPage("Upload Logo Image...");
                Logger.WriteDebugMessage("Logo removed");
                CendynAdmin.Click_SupplierSettings_UpdateButton();
                Logger.WriteDebugMessage("Supplier setting updated successfully on Corporate property");

                // Verify menu image field in Property admin 
                ControlToNextWindow();
                Logger.WriteDebugMessage("Switched back to Property Admin page of lite property");
                ReloadPage();
                Helper.EnterFrame("frontendEditorIframe");
                if (IsWebElementRemoved(PageObject_PropertyAdmin.Property_Logo()))
                    Assert.Fail("Logo field displayed on the page ");
                else
                    Logger.WriteDebugMessage("Logo removed from the page");

                //Check advance settings for logo
                ControlToPreviousWindow();
                Logger.WriteDebugMessage("Switched back to Cendyn Admin page of Corporate property");
                CendynAdmin.Click_Logo_UploadButton();
                PropertyAdmin.UploadImage(imagePath);
                CendynAdmin.Click_SupplierSettings_UpdateButton();
                Helper.AddDelay(1000);
                VerifyTextOnPage("SiteTemplate/Property/FF/FFED04AD/Catering/Default/img/logo.png");
                Logger.WriteDebugMessage("Menu logo path shown");
                CendynAdmin.Click_SupplierSettings_UpdateButton();
                Logger.WriteDebugMessage("Supplier setting updated successfully on Corporate property");

                // Verify menu image field in Property admin 
                ControlToNextWindow();
                Logger.WriteDebugMessage("Switched back to Property Admin page of lite property");
                ReloadPage();
                Helper.EnterFrame("frontendEditorIframe");

                HighlightElement(PageObject_PropertyAdmin.Property_Logo());
                Logger.WriteDebugMessage("Logo displayed on the page");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Corporate Property Name", propertyCorporate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Lite Property Name", propertyLite);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Settings Unavailable Message", settingsUnavailable);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Settings Inherited Message", inheritedMessage, true);
            }
        }
        public static void TC_261318()
        {
            if (TestCaseId == Utility.Constants.TC_261318)
            {
                //Prerequisite
                string propertyCorporate, PropertySupplier, propertyLite, num, addedCategory;

                Random no = new Random();
                num = no.Next().ToString();

                //Retrieve data from Test data
                propertyCorporate = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyCorporate");
                PropertySupplier = TestData.ExcelData.TestDataReader.ReadData(1, "PropertySupplier");
                propertyLite = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyLite");
                addedCategory = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "addedCategory"), num);

                //Login to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to eMenus Lite 
                PropertyAdmin.Click_Navigation_eMenusLITE();
                Logger.WriteDebugMessage("eMenus Lite Product got Selected ");

                //Navigate to Cendyn Admin 
                PropertyAdmin.Navigate_CendynAdminLite();

                // Navigate to Supplier Categories for Corporate Property
                CendynAdmin.NavigatetoCendynProperty(propertyCorporate);
                CendynAdmin.Supplier_Tab();
                CendynAdmin.Click_category();
                AddDelay(5000);

                //Add Category TC_231219
                CendynAdmin.AddSingleCategory(addedCategory);

                //Make list of categories in Corporate property
                List<string> categories = CendynAdmin.GetListOfCategories();

                //Navigate to Supplier Categories for Lite Property
                CendynAdmin.NavigatetoCendynProperty(propertyLite);
                CendynAdmin.Supplier_Tab();
                CendynAdmin.Click_category();

                //Verify Categories are read only TC_231217
                foreach (var cat in categories)
                {
                    if (PageObject_CendynAdmin.Click_EditCategory_Button(cat).Enabled)
                        Assert.Fail();
                    else
                        Logger.WriteDebugMessage(cat + " category is read-only as expected");
                }

                //Navigate to Property Admin for Lite Property
                CendynAdmin.Click_Dropdown();
                CendynAdmin.Click_Property_Admin();
                AddDelay(5000);
                PropertyAdmin.SwitchProperty(propertyLite);

                //Verify unpublished added Category is not showing in Property Admin
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.VerifyCategoryNotPresent(addedCategory);
                ExitFrame();

                //Verify unpublished added Category is not showing in Preview
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.VerifyCategoryNotPresent(addedCategory);
                Helper.CloseWindow();
                Helper.ControlToPreviousWindow();

                //Verify unpublished added Category is not showing in Front End
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Front End should get displayed");
                PropertyAdmin.VerifyCategoryNotPresent(addedCategory);
                Helper.CloseWindow();
                Helper.ControlToPreviousWindow();

                //Switch to Corporate Property to Publish new category
                PropertyAdmin.SwitchProperty(PropertySupplier);
                AddDelay(5000);
                PropertyAdmin.Publish_Changes();

                //Switch Back to Lite
                PropertyAdmin.SwitchProperty(propertyLite);

                //Verify Inherited Categories are showing in Property Admin TC_231218
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.VerifyCategoryPresentFromList(categories);
                Helper.ExitFrame();

                //Verify Inherited Categories are showing in Preview
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.VerifyCategoryPresentFromList(categories);
                Helper.CloseWindow();
                Helper.ControlToPreviousWindow();

                //Verify Inherited Categories are showing in Front End TC_231220
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Published View window should get displayed");
                PropertyAdmin.VerifyCategoryPresentFromList(categories);
                Helper.CloseWindow();
                Helper.ControlToPreviousWindow();

                //Return to Cendyn Admin for Corporate Property and Remove Added Cateogies
                PropertyAdmin.Navigate_CendynAdmin();
                CendynAdmin.NavigatetoCendynProperty(propertyCorporate);
                CendynAdmin.Supplier_Tab();
                CendynAdmin.Click_category();
                AddDelay(5000);
                CendynAdmin.DeleteCategory(addedCategory);

                //Log Data
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Corporate Property Name", propertyCorporate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Corporate Supplier Name", PropertySupplier);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Lite Property Name", propertyLite);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Added Category", addedCategory, true);
            }
        }
        public static void TC_231219()
        {
            if (TestCaseId == Utility.Constants.TC_231219)
            {
                //Prerequisite
                string propertyLite, num, addedCategory;

                Random no = new Random();
                num = no.Next().ToString();

                //Retrieve data from Test data
                propertyLite = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyLite");
                addedCategory = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "addedCategory"), num);

                //Login to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to eMenus Lite 
                PropertyAdmin.Click_Navigation_eMenusLITE();
                Logger.WriteDebugMessage("eMenus Lite Product got Selected ");

                //Navigate to Cendyn Admin 
                PropertyAdmin.Navigate_CendynAdminLite();

                // Navigate to Supplier Categories for Lite Property
                CendynAdmin.NavigatetoCendynProperty(propertyLite);
                CendynAdmin.Supplier_Tab();
                CendynAdmin.Click_category();
                AddDelay(5000);

                //Add Category
                CendynAdmin.AddSingleCategory(addedCategory);

                //Navigate to Property Admin for Lite Supplier
                CendynAdmin.NavigateToPropertyAdmin();
                PropertyAdmin.SwitchProperty(propertyLite);

                //Verify Category is shown
                Helper.EnterFrame("frontendEditorIframe");
                Helper.VerifyElementOnPage(PageObject_PropertyAdmin.Click_MyMenu_MainCategory(addedCategory));
                Logger.WriteInfoMessage("New category " + addedCategory + " is shown on page.");
                Helper.ExitFrame();

                //Verify new Category is not shown before publish
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Front End should get displayed");
                PropertyAdmin.VerifyCategoryNotPresent(addedCategory);
                Helper.CloseWindow();
                Helper.ControlToPreviousWindow();

                //Publish
                PropertyAdmin.Publish_Changes();

                //Verify on Preview
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                Helper.VerifyElementOnPage(PageObject_PropertyAdmin.Click_MyMenu_MainCategory(addedCategory));
                Logger.WriteInfoMessage("New category " + addedCategory + " is shown on page.");
                Helper.CloseWindow();
                Helper.ControlToPreviousWindow();

                //Verify Inherited Categories are showing in Front End TC_231220
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Published View window should get displayed");
                Helper.VerifyElementOnPage(PageObject_PropertyAdmin.Click_MyMenu_MainCategory(addedCategory));
                Logger.WriteInfoMessage("New category " + addedCategory + " is shown on page.");
                Helper.CloseWindow();
                Helper.ControlToPreviousWindow();

                //Return to Cendyn Admin for LITE Property and Remove Added Categories
                PropertyAdmin.Navigate_CendynAdmin();
                CendynAdmin.NavigatetoCendynProperty(propertyLite);
                CendynAdmin.Supplier_Tab();
                CendynAdmin.Click_category();
                AddDelay(5000);
                CendynAdmin.DeleteCategory(addedCategory);

                //Log Data
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Lite Property Name", propertyLite);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Added Category", addedCategory, true);
            }
        }
        public static void TC_231473()
        {
            if (TestCaseId == Utility.Constants.TC_231473)
            {
                //Prerequisite
                string propertyCorporate, PropertySupplier, propertyLite, num,
                    addedCategory, corporateCategory, menuName, menuDescription, price, priceDescription,
                    disclaimer;

                Random no = new Random();
                num = no.Next().ToString();

                //Retrieve data from Test data
                propertyCorporate = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyCorporate");
                PropertySupplier = TestData.ExcelData.TestDataReader.ReadData(1, "PropertySupplier");
                propertyLite = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyLite");
                addedCategory = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "addedCategory"), num);
                menuName = String.Concat("Menu_", num);
                menuDescription = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");
                price = TestData.ExcelData.TestDataReader.ReadData(1, "Price");
                priceDescription = TestData.ExcelData.TestDataReader.ReadData(1, "PriceDescription");
                disclaimer = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Disclaimer"), num);

                //Login to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to eMenus Lite 
                PropertyAdmin.Click_Navigation_eMenusLITE();
                Logger.WriteDebugMessage("eMenus Lite Product got Selected ");

                //Navigate to Cendyn Admin 
                PropertyAdmin.Navigate_CendynAdminLite();

                // Navigate to Supplier Categories for Corporate Property
                CendynAdmin.NavigatetoCendynProperty(propertyCorporate);
                CendynAdmin.Supplier_Tab();
                CendynAdmin.Click_category();
                AddDelay(5000);

                //Make list of categories in Corporate property
                corporateCategory = PageObject_CendynAdmin.CategoryName(1).GetAttribute("value");
                Logger.WriteInfoMessage(corporateCategory + " is the corporate category that we will use to verify.");

                //Navigate to Property Admin for Corporate Property
                CendynAdmin.Click_Dropdown();
                CendynAdmin.Click_Property_Admin();
                AddDelay(5000);
                PropertyAdmin.SwitchProperty(PropertySupplier);

                //Select Corporate Category
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_MainCategory(corporateCategory);

                //Add Menu and publish
                PropertyAdmin.AddNewMenuWithPrice(menuName, menuDescription, price, priceDescription);
                Helper.ExitFrame();
                Logger.WriteInfoMessage("Menu items can be added to Corporate Supplier categories as expected.");
                PropertyAdmin.Publish_Changes();

                //Navigate to Cendyn Admin
                PropertyAdmin.Navigate_CendynAdminLite();

                // Navigate to Supplier Categories for Lite Property
                CendynAdmin.NavigatetoCendynProperty(propertyLite);
                CendynAdmin.Supplier_Tab();
                CendynAdmin.Click_category();
                AddDelay(5000);

                //Add Category
                CendynAdmin.AddSingleCategory(addedCategory);

                //Navigate to Property Admin for Lite Property
                CendynAdmin.NavigateToPropertyAdmin();
                PropertyAdmin.SwitchProperty(propertyLite);

                //Select Corporate Category
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_MainCategory(corporateCategory);

                //Verify no option to Add Menu item on Inherited Category
                Helper.ScrollDown(0, 400);
                if (IsWebElementRemoved(PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu()))
                    Assert.Fail("Add Menu Item button is present on inherited category when it should not be.");
                else
                    Logger.WriteDebugMessage("User not able to add menu items for inherited category as expected.");

                //Edit item to verify user can update price
                ElementHover(PageObject_PropertyAdmin.Hover_MenuName(menuName));
                PropertyAdmin.Click_EditMenu_Button(menuName);
                PropertyAdmin.EditMenuPrice(menuName, price + 5, priceDescription);

                //Verify Disclaimer can be edited
                PropertyAdmin.EditDisclaimer(disclaimer);

                //Verify disclaimer was edited
                Helper.EnterFrame("frontendEditorIframe");
                Helper.ScrollToElement(PageObject_PropertyAdmin.Click_Edit_Desclaimer());
                Helper.VerifyTextOnPageAndHighLight(disclaimer);
                Logger.WriteInfoMessage("Disclaimer was successfully updated by LITE property as expected.");
                Helper.ExitFrame();

                //Remove added menu item
                PropertyAdmin.SwitchProperty(PropertySupplier);
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_MainCategory(corporateCategory);
                Helper.ExitFrame();
                PropertyAdmin.Delete_Menu(menuName);
                Helper.ExitFrame();
                PropertyAdmin.Publish_Changes();


                //Return to Cendyn Admin for Corporate Property and Remove Added Category
                PropertyAdmin.Navigate_CendynAdmin();
                CendynAdmin.NavigatetoCendynProperty(propertyLite);
                CendynAdmin.Supplier_Tab();
                CendynAdmin.Click_category();
                AddDelay(5000);
                CendynAdmin.DeleteCategory(addedCategory);

                //Log test data in Test data file
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Corporate Property Name", propertyCorporate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Corporate Supplier Name", PropertySupplier);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Lite Property Name", propertyLite);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Added Category", addedCategory);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Description", menuDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Default Price", price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Default Price Description", priceDescription, true);

            }
        }
        public static void TC_233030()
        {
            if (TestCaseId == Utility.Constants.TC_233030)
            {
                //Prerequisite
                string propertyCorporate, PropertySupplier, propertyLite, num, menuName, menuDescription,
                    price, priceDescription, updatedPrice, updatedPriceDescription,
                    updatedPrice1, updatedPriceDescription1, updatedPriceLite, updatedPriceDescriptionLite;

                Random no = new Random();
                num = no.Next().ToString();

                //Retrieve data from Test data
                propertyCorporate = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyCorporate");
                PropertySupplier = TestData.ExcelData.TestDataReader.ReadData(1, "PropertySupplier");
                propertyLite = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyLite");
                menuName = String.Concat("Menu_", num);
                menuDescription = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");
                price = TestData.ExcelData.TestDataReader.ReadData(1, "Price");
                priceDescription = TestData.ExcelData.TestDataReader.ReadData(1, "PriceDescription");
                updatedPrice = TestData.ExcelData.TestDataReader.ReadData(1, "UpdatedPrice");
                updatedPriceDescription = TestData.ExcelData.TestDataReader.ReadData(1, "UpdatedPriceDescription");
                updatedPrice1 = TestData.ExcelData.TestDataReader.ReadData(1, "UpdatedPrice1");
                updatedPriceDescription1 = TestData.ExcelData.TestDataReader.ReadData(1, "UpdatedPriceDescription1");
                updatedPriceLite = TestData.ExcelData.TestDataReader.ReadData(1, "UpdatedPriceLite");
                updatedPriceDescriptionLite = TestData.ExcelData.TestDataReader.ReadData(1, "UpdatedPriceDescriptionLite");

                //Login to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to eMenus Lite 
                PropertyAdmin.Click_Navigation_eMenusLITE();
                Logger.WriteDebugMessage("eMenus Lite Product got Selected ");

                //Navigate to Corporate Property
                PropertyAdmin.SwitchProperty(PropertySupplier);

                //Navigate to Breaks and add menu item
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                PropertyAdmin.AddNewMenuWithPrice(menuName, menuDescription, price, priceDescription);
                PropertyAdmin.Publish_Changes();
                Logger.WriteInfoMessage(menuName + " menu item added with $" + price + " " + priceDescription + " added.");

                //THIS CHECKS FIRST PUBLISH
                //Navigate to Lite Property
                PropertyAdmin.SwitchProperty(propertyLite);

                //Verify new item shows with price and price description
                PropertyAdmin.BreaksVerify_MenuPrice_AcrossPages(menuName, price, priceDescription);
                Logger.WriteInfoMessage("Publish of menu item and price by corporate are showing on Lite property.");

                //Return to corporate property and update price & price description
                PropertyAdmin.SwitchProperty(PropertySupplier);
                PropertyAdmin.Click_Link_Web_View();
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                ElementHover(PageObject_PropertyAdmin.Hover_MenuName(menuName));
                PropertyAdmin.Click_EditMenu_Button(menuName);
                PropertyAdmin.EditMenuPrice(menuName, updatedPrice, updatedPriceDescription);
                PropertyAdmin.Publish_Changes();
                Logger.WriteInfoMessage(menuName + " menu item edited on corporate with $" + updatedPrice + " " + updatedPriceDescription);

                //THIS CHECKS SECOND PUBLISH FROM CORPORATE
                //Navigate to Lite Property
                PropertyAdmin.SwitchProperty(propertyLite);

                //Verify new item shows with price and price description
                PropertyAdmin.BreaksVerify_MenuPrice_AcrossPages(menuName, updatedPrice, updatedPriceDescription);
                Logger.WriteInfoMessage("Publish of prices by corporate are showing on Lite prior to Lite property override.");

                //UPDATE PRICE ON LITE PROPERTY
                //Navigate to Web View
                PropertyAdmin.Click_Link_Web_View();
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                ElementHover(PageObject_PropertyAdmin.Hover_MenuName(menuName));
                PropertyAdmin.Click_EditMenu_Button(menuName);
                PropertyAdmin.EditMenuPrice(menuName, updatedPriceLite, updatedPriceDescriptionLite);
                PropertyAdmin.Publish_Changes();
                Logger.WriteInfoMessage(menuName + " menu item edited on Lite with $" + updatedPriceLite + " " + updatedPriceDescriptionLite);

                //Verify new item shows with price and price description
                PropertyAdmin.BreaksVerify_MenuPrice_AcrossPages(menuName, updatedPriceLite, updatedPriceDescriptionLite);
                Logger.WriteInfoMessage("Corporate prices were overridden by Lite property.");

                //NAVIGATE BACK TO CORPORATE SUPPLIER AND UPDATE & PUBLISH CHANGES
                PropertyAdmin.SwitchProperty(PropertySupplier);
                PropertyAdmin.Click_Link_Web_View();
                //Navigate to Breaks and add menu item
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                ElementHover(PageObject_PropertyAdmin.Hover_MenuName(menuName));
                PropertyAdmin.Click_EditMenu_Button(menuName);
                PropertyAdmin.EditMenuPrice(menuName, updatedPrice1, updatedPriceDescription1);
                PropertyAdmin.Publish_Changes();
                Logger.WriteInfoMessage(menuName + " menu item edited on Corporate with $" + updatedPrice1 + " " + updatedPriceDescription1);

                //NAVIGATE TO LITE PROPERTY AND VERIFY NO IMPACT AFTER OVERRIDE
                PropertyAdmin.SwitchProperty(propertyLite);

                //Verify new item shows with price and price description
                PropertyAdmin.BreaksVerify_MenuPrice_AcrossPages(menuName, updatedPriceLite, updatedPriceDescriptionLite);
                Logger.WriteInfoMessage("Lite Property Prices are not impacted by Corporate property after overridden.");

                //Log test data in Test data file
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Corporate Property Name", propertyCorporate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Corporate Supplier Name", PropertySupplier);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Lite Property Name", propertyLite);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Description", menuDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Default Price", price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Default Price Description", priceDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Updated Price", updatedPrice);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Updated Price Description ", updatedPriceDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Updated Price 1", updatedPrice1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Updated Price Description 1", updatedPriceDescription1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Updated Price Lite", updatedPriceLite);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Default Price Description Lite", updatedPriceDescriptionLite, true);

            }
        }
        public static void TC_256953()
        {
            if (TestCaseId == Utility.Constants.TC_256953)
            {
                //Prerequisite
                string propertyCorporate, PropertySupplier, propertyLite, num, 
                    category, disclaimer, updatedDisclaimer, updatedDisclaimer1, updatedDisclaimerLite;

                Random no = new Random();
                num = no.Next().ToString();

                //Retrieve data from Test data
                propertyCorporate = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyCorporate");
                PropertySupplier = TestData.ExcelData.TestDataReader.ReadData(1, "PropertySupplier");
                propertyLite = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyLite");
                category = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Category"), num);
                disclaimer = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Disclaimer"), num);
                updatedDisclaimer = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "UpdatedDisclaimer"), num);
                updatedDisclaimer1 = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "UpdatedDisclaimer1"), num);
                updatedDisclaimerLite = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "UpdatedDisclaimerLite"), num);

                //Login to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to eMenus Lite 
                PropertyAdmin.Click_Navigation_eMenusLITE();

                Logger.WriteDebugMessage("eMenus Lite Product got Selected ");

                //Navigate to Corporate Property
                PropertyAdmin.SwitchProperty(PropertySupplier);

                //Navigate to Cendyn Admin 
                PropertyAdmin.Navigate_CendynAdmin();

                //Click Supplier tab
                CendynAdmin.Supplier_Tab();
                Logger.WriteDebugMessage("landed on supplier page");
                CendynAdmin.Click_category();
                Logger.WriteDebugMessage("Landed on Category page");

                //Add Category
                CendynAdmin.AddSingleCategory(category);

                //Navigate to Property Admin
                CendynAdmin.NavigateToPropertyAdmin();
                PropertyAdmin.SwitchProperty(PropertySupplier);

                //Navigate to new category and add disclaimer
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_MainCategory(category);
                Helper.ExitFrame();
                PropertyAdmin.EditDisclaimer(disclaimer);
                Logger.WriteInfoMessage(disclaimer + " added as Corporate disclaimer.");
                PropertyAdmin.Publish_Changes();

                //THIS CHECKS FIRST PUBLISH
                //Navigate to Lite Property
                PropertyAdmin.SwitchProperty(propertyLite);
                Helper.AddDelay(5000);

                //Verify new item shows with price and price description
                PropertyAdmin.Verify_Disclaimer_AcrossPages(category, disclaimer);
                Logger.WriteInfoMessage("Publish of disclaimer by corporate is showing on Lite property.");

                //Return to corporate property and update price & price description
                PropertyAdmin.SwitchProperty(PropertySupplier);
                PropertyAdmin.Click_Link_Web_View();
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_MainCategory(category);
                Helper.ExitFrame();
                PropertyAdmin.EditDisclaimer(updatedDisclaimer);
                PropertyAdmin.Publish_Changes();
                Logger.WriteInfoMessage(updatedDisclaimer + " is the new Corporate disclaimer.");

                //THIS CHECKS SECOND PUBLISH FROM CORPORATE
                //Navigate to Lite Property
                PropertyAdmin.SwitchProperty(propertyLite);

                //Verify new item shows with price and price description
                PropertyAdmin.Verify_Disclaimer_AcrossPages(category, updatedDisclaimer);
                Logger.WriteInfoMessage("Updates to Corporate disclaimer sync to lite property.");

                //UPDATE PRICE ON LITE PROPERTY
                //Navigate to Web View
                PropertyAdmin.Click_Link_Web_View();
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_MainCategory(category);
                Helper.ExitFrame();
                PropertyAdmin.EditDisclaimer(updatedDisclaimerLite);
                PropertyAdmin.Publish_Changes();
                Logger.WriteInfoMessage(updatedDisclaimerLite + " added as the LITE property disclaimer.");

                //Verify new item shows with price and price description
                PropertyAdmin.Verify_Disclaimer_AcrossPages(category, updatedDisclaimerLite);
                Logger.WriteInfoMessage("Corporate disclaimer was overridden by Lite property.");

                //NAVIGATE BACK TO CORPORATE SUPPLIER AND UPDATE & PUBLISH CHANGES
                PropertyAdmin.SwitchProperty(PropertySupplier);
                PropertyAdmin.Click_Link_Web_View();
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_MainCategory(category);
                Helper.ExitFrame();
                PropertyAdmin.EditDisclaimer(updatedDisclaimer1);
                PropertyAdmin.Publish_Changes();
                Logger.WriteInfoMessage(updatedDisclaimer1 + " is new disclaimer on Corporate property.");

                //NAVIGATE TO LITE PROPERTY AND VERIFY NO IMPACT AFTER OVERRIDE
                PropertyAdmin.SwitchProperty(propertyLite);

                //Verify new item shows with price and price description
                PropertyAdmin.Verify_Disclaimer_AcrossPages(category, updatedDisclaimerLite);
                Logger.WriteInfoMessage("Lite Property disclaimer is not impacted by Corporate property after overridden.");

                //Navigate Back to Cendyn Admin
                PropertyAdmin.Navigate_CendynAdmin();
                CendynAdmin.Cendyn_select_Property(propertyCorporate);

                //Click Supplier tab
                CendynAdmin.Supplier_Tab();
                Logger.WriteDebugMessage("landed on supplier page");
                CendynAdmin.Click_category();
                Logger.WriteDebugMessage("Landed on Category page");

                //Delete Category
                CendynAdmin.DeleteCategory(category);

                //Log test data in Test data file
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Corporate Property Name", propertyCorporate);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Corporate Supplier Name", PropertySupplier);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Lite Property Name", propertyLite);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Added Category", category);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Disclaimer", disclaimer);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Updated Disclaimer", updatedDisclaimer);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Updated Disclaimer 1", updatedDisclaimer1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Updated Disclaimer Lite", updatedDisclaimerLite, true);

            }
        }
        public static void TC_260414()
        {
            if (TestCaseId == Utility.Constants.TC_260414)
            {
                //Pre-requisites
                string propertyName, menuName, menuDescription, tagName, num;

                //Retrieve data from test data
                Random no = new Random();
                num = no.Next().ToString();
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertySupplier");
                menuName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuName"), num);
                menuDescription = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");
                tagName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "TagName"), num);


                //Login to Cendyn Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoPropertyLITE(propertyName);

                //Navigate to Settings
                PropertyAdmin.Click_MyMenu_Settings();
                Logger.WriteDebugMessage("Settings should get clicked");
                PropertyAdmin.Settings_MenuFilter_Tab();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Settings_MenuFilter_AddTag());
                Logger.WriteDebugMessage("Navigated on Menu Filter Page");

                //Add tag in Property Admin
                PropertyAdmin.Add_Tag(tagName);

                //Verify Added tag displayed in pop-up
                PropertyAdmin.Click_MyMenus();
                Logger.WriteDebugMessage("Navigated to my menu page");
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                Logger.WriteDebugMessage("Clicked on Breaks Menus");
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                Logger.WriteDebugMessage("Landed on Breaks page and Add New Menu button should get displayed");
                PropertyAdmin.Click_MyMenu_AddNewMenu();
                Logger.WriteDebugMessage("Add new menu modal should get displayed");
                Helper.ExitFrame();
                PropertyAdmin.AddNewMenu_MenuName(menuName);
                Helper.EnterFrame("cdescription_ifr");
                PropertyAdmin.AddNewMenu_AddChoice_Description("cdescription", menuDescription);
                Logger.WriteDebugMessage("Name and description should get entered");
                Helper.ExitFrame();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_AddNewMenu_AddedTag_Filter());
                Logger.WriteDebugMessage("Added tag should get displayed on filter section");
                PropertyAdmin.Click_AddNewMenu_AddedTag_Filter();
                Logger.WriteDebugMessage("Added tag should get selected");
                PropertyAdmin.Click_AddNewMenu_SaveButton();
                Helper.EnterFrame("frontendEditorIframe");
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Logger.WriteDebugMessage("Menu Got Added Successfully");
                Helper.ExitFrame();

                //Publish the Changes
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end and Verify the Added Tag
                PropertyAdmin.Click_PublishedView();
                ControlToNewWindow();
                Logger.WriteDebugMessage("Landed on eMenus Front-end");
                PropertyAdmin.Click_MyMenu_Breaks();
                Logger.WriteDebugMessage("Clicked on Breaks Menus");
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Logger.WriteDebugMessage("Navigated to Continental Breakfast Sub-menu and Added Menu is displaying");
                HomePage.HomePage_ActionStations_MenuInfoButton();
                Logger.WriteDebugMessage("Clicked on Menu Info button");
                if (tagName.Equals(PropertyAdmin.Get_Menu_TagName(tagName)))
                {
                    Logger.WriteDebugMessage("Added Tag is Displaying on Front-end Page");
                }
                else
                    Assert.Fail("Added tag is not Displaying on Front-end Page");

                //Click on settings and delete tag
                ControlToPreviousWindow();
                PropertyAdmin.Click_MyMenu_Settings();
                Logger.WriteDebugMessage("Settings should get clicked");
                PropertyAdmin.Settings_MenuFilter_Tab();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Settings_MenuFilter_AddTag());
                Logger.WriteDebugMessage("Navigated on Menu Filter Page");
                PropertyAdmin.Delete_Tag(tagName);

                //Verify added tag is deleted or not 
                PropertyAdmin.Click_MyMenus();
                Logger.WriteDebugMessage("My menu page should get displayed");
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                Logger.WriteDebugMessage("Clicked on Breaks Menus");
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                Logger.WriteDebugMessage("Landed on Continental Breakfast page and Add New Menu button should get displayed");
                PropertyAdmin.Click_MyMenu_AddNewMenu();
                Logger.WriteDebugMessage("Add new menu modal should get displayed");
                Helper.ExitFrame();
                Helper.ScrollToElement(PageObject_PropertyAdmin.Click_AddNewMenu_BottomSaveButton());
                if (Helper.IsElementRemoved(tagName))
                    Assert.Fail("Tag name displayed on the page");
                else
                    Logger.WriteDebugMessage("Added tag should get deleted and not displayed");


                //Verify the Tag on Front-end
                ControlToNextWindow();
                ReloadPage();
                Logger.WriteDebugMessage("Landed on eMenus Front-end");
                PropertyAdmin.Click_MyMenu_Breaks();
                Logger.WriteDebugMessage("Clicked on Breaks Menus");
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Logger.WriteDebugMessage("Navigated to Continental Breakfast Sub-menu and Added Menu is displaying");
                if (IsWebElementRemoved(PageObject.UI.PageObject_HomePage.HomePage_ActionStations_MenuInfoButton()))
                {
                    Logger.WriteDebugMessage("Added Tag is Removed from Front-end Page");
                }
                else
                    Assert.Fail("Added tag is not Removed from the Front-end Page");


                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Description", menuDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Tag Name", tagName, true);
            }
        }
        public static void TC_260420()
        {
            if (TestCaseId == Utility.Constants.TC_260420)
            {
                //Prerequisites
                string num, find, replace, propertyName, menuNameAddOns,
                menuDescriptionAddOns, add_On_Title, add_On1_Name, add_On1_Description,
                add_On1_Price, add_On2_Name, add_On2_Description, add_On2_Price, success, after;
                Random radno = new Random();
                //Retrieve data from test Data
                num = radno.Next().ToString();
                find = num;
                after = "_after";
                replace = num + after;

                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertySupplier");
                success = TestData.ExcelData.TestDataReader.ReadData(1, "FindReplace_SuccessMessage");
                menuNameAddOns = TestData.ExcelData.TestDataReader.ReadData(1, "MenuNameAddOns") + find;
                menuDescriptionAddOns = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescriptionAddOns") + find;
                add_On_Title = TestData.ExcelData.TestDataReader.ReadData(1, "Title") + find;
                add_On1_Name = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On1_Name") + find;
                add_On1_Description = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On1_Description") + find;
                add_On1_Price = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On1_Price");
                add_On2_Name = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On2_Name") + find;
                add_On2_Description = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On2_Description") + find;
                add_On2_Price = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On2_Price");

                //Navigate to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoPropertyLITE(propertyName);

                //Navigate to Menu
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                Logger.WriteDebugMessage("Breaks selected");
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                Logger.WriteDebugMessage("Navigated to Menu Page");

                //Add Menu with Add on
                PropertyAdmin.Menu_WithAddOn(menuNameAddOns, menuDescriptionAddOns, add_On_Title, add_On1_Name, add_On1_Description, add_On1_Price, add_On2_Name, add_On2_Description, add_On2_Price);

                //Perform Find and Replace
                PropertyAdmin.FindAndReplace(find, replace, success);
                Helper.AddDelay(5000);

                //Verify Find and Replace on Property Admin
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                Logger.WriteDebugMessage("Breaks selected");
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                Helper.ExitFrame();
                PropertyAdmin.VerifyFindAndReplace_PropertyAdmin(after, menuNameAddOns, menuDescriptionAddOns, add_On_Title, add_On1_Name, add_On1_Description, add_On2_Name, add_On2_Description);

                //Publish Changes
                PropertyAdmin.Publish_Changes();
                Helper.AddDelay(5000);

                //Navigate to Front-end and Verify the Added Menu with Choices
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigate to Home page");
                PropertyAdmin.Click_MyMenu_Breaks();
                Logger.WriteDebugMessage("Breaks selected");

                //Verify Find and Replace on Front End
                PropertyAdmin.VerifyFindAndReplace_FrontEnd(after, menuNameAddOns, menuDescriptionAddOns, add_On_Title, add_On1_Name, add_On1_Description, add_On2_Name, add_On2_Description);

                // Navigate to Back to Property Admin and Delete Newly Added Menu
                Helper.CloseCurrentTab();
                Logger.WriteDebugMessage("Landed on Property Admin Page");
                PropertyAdmin.Delete_Menu(menuNameAddOns + after);

                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuNameAddOns);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Description", menuDescriptionAddOns);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On Tile", add_On_Title);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 1 Name", add_On1_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 1 Description", add_On1_Description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add on 1 Price", add_On1_Price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 2 Name", add_On2_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 2 Description", add_On2_Description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add on 2 Price", add_On2_Price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Find", find);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Replace", replace);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Find & Replace Success Message", success, true);

            }
        }

        public static void TC_260415()
        {
            if (TestCaseId == Utility.Constants.TC_260415)
            {
                //Prerequisite
                string propertyName, menuName, menuDescription, price, priceDescription, num;

                Random radno = new Random();
                num = radno.Next().ToString();

                //Retrieve data from Database or test data file
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertySupplier");
                menuName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuName"), num);
                menuDescription = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");
                price = TestData.ExcelData.TestDataReader.ReadData(1, "Price");
                priceDescription = TestData.ExcelData.TestDataReader.ReadData(1, "PriceDescription");

                //Navigate to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoPropertyLITE(propertyName);

                //Navigate to My Menu Page and Add New Menu with No Price
                PropertyAdmin.Click_MyMenus();
                Logger.WriteDebugMessage("Navigated to My Menu Page");
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                Logger.WriteDebugMessage("Breaks selected");
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                PropertyAdmin.AddNewMenuWithPrice(menuName, menuDescription, price, priceDescription);

                //View Menu on PDF Mode
                //PropertyAdmin.Preview_PDF_View("Continental Breakfast", menuName);
                //PropertyAdmin.Preview_PDF_View_MainCategory()

                //Verify the Price for added Menu
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                Logger.WriteDebugMessage("Breaks selected");
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                if (Helper.IsWebElementRemoved(PageObject_PropertyAdmin.First_Menu_Price_Admin(menuName)))
                    Assert.Fail("Menu Price is Getting Displayed on Admin Page");
                else
                {
                    Logger.WriteDebugMessage("Menu Price is not Displaying on Admin Page");
                    VerifyTextOnPageAndHighLight(menuName);
                }
                Helper.ExitFrame();

                //Preview the changes and Verify the added Menu
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.Click_MyMenu_Breaks();
                Logger.WriteDebugMessage("Breaks selected");
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Logger.WriteDebugMessage("Added Menu got displayed on Preview Page");
                if (Helper.IsWebElementRemoved(PageObject_PropertyAdmin.First_Menu_Price_Preview(menuName)))
                    Assert.Fail("Menu Price is Getting Displayed on Preview Page");
                else
                {
                    Logger.WriteDebugMessage("Menu Price is not Displaying on Preview Page");
                    VerifyTextOnPageAndHighLight(menuName);
                }

                CloseCurrentTab();

                //Publish the changes
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end 
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigated to Front-end Site");


                //Navigate to Specific Menu
                PropertyAdmin.Click_MyMenu_Breaks();
                Logger.WriteDebugMessage("Breaks selected");
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Logger.WriteDebugMessage("Navigated to Breaks Menu and Added Menu is displaying");

                if (Helper.IsWebElementRemoved(PageObject_HomePage.First_Menu_Price_Frontend(menuName)))
                    Assert.Fail("Menu Price is Getting Displayed on Front-end Page");
                else
                {
                    Logger.WriteDebugMessage("Menu Price is not Displaying on Front-end Page");
                    VerifyTextOnPageAndHighLight(menuName);
                }

                // Return and delete menu item
                CloseCurrentTab();
                PropertyAdmin.Delete_Menu(menuName);

                //Log test data in Test data file
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Description", menuDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Default Price", price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Default Price Description", priceDescription, true);
            }
        }
        public static void TC_260417()
        {
            if (TestCaseId == Utility.Constants.TC_260417)
            {
                //Pre-Requisite
                string propertyName, menuName, menuDescription, price, priceDescription, menuprice, num;
                Random radno = new Random();
                num = radno.Next().ToString();

                //Retrieve data from Database or test data file
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertySupplier");
                menuName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuName"), num);
                menuDescription = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");
                price = TestData.ExcelData.TestDataReader.ReadData(1, "Price");
                priceDescription = TestData.ExcelData.TestDataReader.ReadData(1, "PriceDescription");

                //Navigate to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoPropertyLITE(propertyName);

                //Navigate to My Menu Page and Add New Menu with Dynamic Price
                PropertyAdmin.Click_MyMenus();
                Logger.WriteDebugMessage("Navigated to My Menu Page");
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                Logger.WriteDebugMessage("Breaks selected");
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                PropertyAdmin.AddNewMenuWithPrice(menuName, menuDescription, price, priceDescription);

                //Verify the Price for added Menu
                Helper.EnterFrame("frontendEditorIframe");
                menuprice = PropertyAdmin.Get_Admin_Menu_Price(menuName);
                if (menuprice.Contains(price))
                    Logger.WriteDebugMessage("Default Price is getting Displayed on Admin Page");
                else
                    Assert.Fail("Default Price is not getting Displayed ");
                Helper.ExitFrame();

                //Preview the changes and Verify the added Menu
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.Click_MyMenu_Breaks();
                Logger.WriteDebugMessage("Breaks selected");
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Logger.WriteDebugMessage("Added Menu got displayed on Preview Page");
                menuprice = PropertyAdmin.Get_Preview_Menu_Price(menuName);
                if (menuprice.Contains(price))
                    Logger.WriteDebugMessage("Default Price is getting Displayed on Admin Page");
                else
                    Assert.Fail("Default Price is not getting Displayed ");
                CloseCurrentTab();

                //Publish the changes
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end 
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigated to Front-end Site");

                //Navigate to Specific Menu
                PropertyAdmin.Click_MyMenu_Breaks();
                Logger.WriteDebugMessage("Breaks selected");
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Logger.WriteDebugMessage("Navigated to Breaks Menu and Added Menu is displaying");
                menuprice = HomePage.First_Menu_Price_Frontend(menuName);
                if (menuprice.Contains(price))
                    Logger.WriteDebugMessage("Default Price is getting Displayed on Admin Page");
                else
                    Assert.Fail("Default Price is not getting Displayed ");

                // Return and delete menu item
                CloseCurrentTab();
                PropertyAdmin.Delete_Menu(menuName);

                //Log test data in Test data file
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Description", menuDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Default Price", price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Default Price Description", priceDescription, true);

            }
        }
        public static void TC_260418()
        {
            if (TestCaseId == Utility.Constants.TC_260418)
            {
                //Prerequisites
                string propertyName, num, category, menuName, menuDescription, add_On_Title, add_On1_Name, add_On1_Description, add_On1_Price, add_On2_Name, add_On2_Description, add_On2_Price;
                Random no = new Random();
                num = no.Next().ToString();

                //Retrieve data from Database or test data file
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertySupplier");
                category = TestData.ExcelData.TestDataReader.ReadData(1, "Category");
                menuName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuName"), num);
                menuDescription = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");
                add_On_Title = TestData.ExcelData.TestDataReader.ReadData(1, "Title");
                add_On1_Name = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On1_Name");
                add_On1_Description = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On1_Description");
                add_On1_Price = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On1_Price");
                add_On2_Name = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On2_Name");
                add_On2_Description = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On2_Description");
                add_On2_Price = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On2_Price");

                //Navigate to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoPropertyLITE(propertyName);

                //Navigate to Menu
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                Logger.WriteDebugMessage("Breaks selected");
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                Logger.WriteDebugMessage("Navigated to Menu Page");

                //Add Menu with the choices
                PropertyAdmin.Menu_WithAddOn(menuName, menuDescription, add_On_Title, add_On1_Name, add_On1_Description, add_On1_Price, add_On2_Name, add_On2_Description, add_On2_Price);

                //View Menu on PDF Mode
                PropertyAdmin.Click_Link_PDF_View();
                Logger.WriteDebugMessage("PDF View is displayed");
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.VerifyMenu(category, null, menuName, add_On_Title, add_On1_Name, add_On2_Name);
                Helper.ExitFrame();

                //Preview the Changes on Preview Page
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.VerifyMenu(category, null, menuName, add_On_Title, add_On1_Name, add_On2_Name);
                Helper.CloseWindow();
                Helper.ControlToPreviousWindow();

                //Publish the changes
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end and Verify the Added Menu with Choices
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigate to Home page");
                PropertyAdmin.VerifyMenu(category, null, menuName, add_On_Title, add_On1_Name, add_On2_Name);
                Helper.CloseWindow();
                Helper.ControlToPreviousWindow();

                //Navigate to menu to delete
                PropertyAdmin.Click_MyMenus();
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_MainCategory(category);
                Helper.ExitFrame();
                PropertyAdmin.Delete_Menu(menuName);

                //Log test data into log file as well as extent report


                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Category Name", category);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Description", menuDescription); Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On Tile", add_On_Title);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 1 Name", add_On1_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 1 Description", add_On1_Description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add on 1 Price", add_On1_Price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 2 Name", add_On2_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 2 Description", add_On2_Description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add on 2 Price", add_On2_Price, true);
            }
        }
        public static void TC_260419()
        {
            if (TestCaseId == Utility.Constants.TC_260419)
            {
                //Pre-Requisites
                string propertyName, category, menuName, menuDescription, choiceName, choiceDescription, option1Name, option1Price, option2Name, option2price, num;
                Random no = new Random();
                num = no.Next().ToString();

                //Retrieve data from Database or test data file
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertySupplier");
                category = TestData.ExcelData.TestDataReader.ReadData(1, "Category");
                menuName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuName"), num);
                menuDescription = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");
                choiceName = TestData.ExcelData.TestDataReader.ReadData(1, "ChoiceName");
                choiceDescription = TestData.ExcelData.TestDataReader.ReadData(1, "ChoiceDesciption");
                option1Name = TestData.ExcelData.TestDataReader.ReadData(1, "Option1Name");
                option1Price = TestData.ExcelData.TestDataReader.ReadData(1, "Option1Price");
                option2Name = TestData.ExcelData.TestDataReader.ReadData(1, "Option2Name");
                option2price = TestData.ExcelData.TestDataReader.ReadData(1, "Option2Price");

                //Navigate to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoPropertyLITE(propertyName);

                //Navigate to Menu
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_Breaks();
                Logger.WriteDebugMessage("Breaks selected");
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                Logger.WriteDebugMessage("Navigated to Menu Page");

                //Add Menu with the choices
                PropertyAdmin.Menu_WithChoices(menuName, menuDescription, choiceName, choiceDescription, option1Name, option1Price, option2Name, option2price);

                //View Menu on PDF Mode
                PropertyAdmin.Click_Link_PDF_View();
                Logger.WriteDebugMessage("PDF View is displayed");
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.VerifyMenu(category, null, menuName, choiceName, option1Name, option2Name);
                Helper.ExitFrame();

                //Preview the Changes on Preview Page
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.VerifyMenu(category, null, menuName, choiceName, option1Name, option2Name);
                Helper.CloseWindow();
                Helper.ControlToPreviousWindow();

                //Publish the changes
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end and Verify the Added Menu with Choices
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigate to Home page");
                PropertyAdmin.VerifyMenu(category, null, menuName, choiceName, option1Name, option2Name);
                Helper.CloseWindow();
                Helper.ControlToPreviousWindow();

                //Navigate to menu to delete
                PropertyAdmin.Click_MyMenus();
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_MainCategory(category);
                Helper.ExitFrame();
                PropertyAdmin.Delete_Menu(menuName);

                //Log test data into log file as well as extent report


                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Category Name", category);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Description", menuDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Choice Name", choiceName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Choice Description", choiceDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_1 Name", option1Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_1 Price", option1Price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_2 Name", option2Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_2 Price", option2price, true);
            }
        }

        public static void TC_261125()
        {
            if (TestCaseId == Utility.Constants.TC_261125)
            {
                //Prerequisite
                string propertyName, category, menuName, menuDescription, price, priceDescription, num;

                Random radno = new Random();
                num = radno.Next().ToString();

                //Retrieve data from Database or test data file
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertySupplier");
                category = TestData.ExcelData.TestDataReader.ReadData(1, "Category");
                menuName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuName"), num);
                menuDescription = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");
                price = TestData.ExcelData.TestDataReader.ReadData(1, "Price");
                priceDescription = TestData.ExcelData.TestDataReader.ReadData(1, "PriceDescription");

                //Navigate to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoPropertyLITE(propertyName);

                //Navigate to My Menu Page and Add New Menu with No Price
                PropertyAdmin.Click_MyMenus();
                Logger.WriteDebugMessage("Navigated to My Menu Page");
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_MainCategory(category);
                Logger.WriteDebugMessage(category + " selected");
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                PropertyAdmin.AddNewMenuWithPrice(menuName, menuDescription, price, priceDescription);

                //Verify the Price for added Menu
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_MainCategory(category);
                Logger.WriteDebugMessage(category + " selected");
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                if (Helper.IsWebElementRemoved(PageObject_PropertyAdmin.First_Menu_Price_Admin(menuName)))
                    Assert.Fail("Menu Price is Getting Displayed on Admin Page");
                else
                {
                    Logger.WriteDebugMessage("Menu Price is not Displaying on Admin Page");
                    VerifyTextOnPageAndHighLight(menuName);
                }
                Helper.ExitFrame();

                //Preview the changes and Verify the added Menu
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.Click_MyMenu_MainCategory(category);
                Logger.WriteDebugMessage(category + " selected");
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Logger.WriteDebugMessage("Added Menu got displayed on Preview Page");
                if (Helper.IsWebElementRemoved(PageObject_PropertyAdmin.First_Menu_Price_Preview(menuName)))
                    Assert.Fail("Menu Price is Getting Displayed on Preview Page");
                else
                {
                    Logger.WriteDebugMessage("Menu Price is not Displaying on Preview Page");
                    VerifyTextOnPageAndHighLight(menuName);
                }

                CloseCurrentTab();

                //Publish the changes
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end 
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigated to Front-end Site");

                //Navigate to Specific Menu
                PropertyAdmin.Click_MyMenu_MainCategory(category);
                Logger.WriteDebugMessage(category + " selected");
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Logger.WriteDebugMessage("Navigated to Breaks Menu and Added Menu is displaying");

                if (Helper.IsWebElementRemoved(PageObject_HomePage.First_Menu_Price_Frontend(menuName)))
                    Assert.Fail("Menu Price is Getting Displayed on Front-end Page");
                else
                {
                    Logger.WriteDebugMessage("Menu Price is not Displaying on Front-end Page");
                    VerifyTextOnPageAndHighLight(menuName);
                }

                // Return and delete menu item
                CloseCurrentTab();
                PropertyAdmin.Delete_Menu(menuName);

                //Log test data in Test data file
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Description", menuDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Default Price", price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Default Price Description", priceDescription, true);
            }
        }
        public static void TC_261127()
        {
            if (TestCaseId == Utility.Constants.TC_261127)
            {
                //Pre-Requisite
                string propertyName, category, menuName, menuDescription, price, priceDescription, menuprice, num;
                Random radno = new Random();
                num = radno.Next().ToString();

                //Retrieve data from Database or test data file
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertySupplier");
                category = TestData.ExcelData.TestDataReader.ReadData(1, "Category");
                menuName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuName"), num);
                menuDescription = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");
                price = TestData.ExcelData.TestDataReader.ReadData(1, "Price");
                priceDescription = TestData.ExcelData.TestDataReader.ReadData(1, "PriceDescription");

                //Navigate to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoPropertyLITE(propertyName);

                //Navigate to My Menu Page and Add New Menu with Dynamic Price
                PropertyAdmin.Click_MyMenus();
                Logger.WriteDebugMessage("Navigated to My Menu Page");
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_MainCategory(category);
                Logger.WriteDebugMessage(category + " selected");
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                PropertyAdmin.AddNewMenuWithPrice(menuName, menuDescription, price, priceDescription);

                //Verify the Price for added Menu
                Helper.EnterFrame("frontendEditorIframe");
                menuprice = PropertyAdmin.Get_Admin_Menu_Price(menuName);
                if (menuprice.Contains(price))
                    Logger.WriteDebugMessage("Default Price is getting Displayed on Admin Page");
                else
                    Assert.Fail("Default Price is not getting Displayed ");
                Helper.ExitFrame();

                //Preview the changes and Verify the added Menu
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.Click_MyMenu_MainCategory(category);
                Logger.WriteDebugMessage(category + " selected");
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Logger.WriteDebugMessage("Added Menu got displayed on Preview Page");
                menuprice = PropertyAdmin.Get_Preview_Menu_Price(menuName);
                if (menuprice.Contains(price))
                    Logger.WriteDebugMessage("Default Price is getting Displayed on Admin Page");
                else
                    Assert.Fail("Default Price is not getting Displayed ");
                CloseCurrentTab();

                //Publish the changes
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end 
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigated to Front-end Site");

                //Navigate to Specific Menu
                PropertyAdmin.Click_MyMenu_MainCategory(category);
                Logger.WriteDebugMessage(category + " selected");
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Logger.WriteDebugMessage("Navigated to Breaks Menu and Added Menu is displaying");
                menuprice = HomePage.First_Menu_Price_Frontend(menuName);
                if (menuprice.Contains(price))
                    Logger.WriteDebugMessage("Default Price is getting Displayed on Admin Page");
                else
                    Assert.Fail("Default Price is not getting Displayed ");

                // Return and delete menu item
                CloseCurrentTab();
                PropertyAdmin.Delete_Menu(menuName);

                //Log test data in Test data file
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Category Name", category);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Description", menuDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Default Price", price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Default Price Description", priceDescription, true);

            }
        }
        public static void TC_261130()
        {
            if (TestCaseId == Utility.Constants.TC_261130)
            {
                //Prerequisites
                string propertyName, num, category, menuName, menuDescription, add_On_Title, add_On1_Name, add_On1_Description, add_On1_Price, add_On2_Name, add_On2_Description, add_On2_Price;
                Random no = new Random();
                num = no.Next().ToString();

                //Retrieve data from Database or test data file
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertySupplier");
                category = TestData.ExcelData.TestDataReader.ReadData(1, "Category");
                menuName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuName"), num);
                menuDescription = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");
                add_On_Title = TestData.ExcelData.TestDataReader.ReadData(1, "Title");
                add_On1_Name = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On1_Name");
                add_On1_Description = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On1_Description");
                add_On1_Price = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On1_Price");
                add_On2_Name = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On2_Name");
                add_On2_Description = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On2_Description");
                add_On2_Price = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On2_Price");

                //Navigate to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoPropertyLITE(propertyName);

                //Navigate to Menu
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_MainCategory(category);
                Logger.WriteDebugMessage(category + " selected");
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                Logger.WriteDebugMessage("Navigated to Menu Page");

                //Add Menu with the choices
                PropertyAdmin.Menu_WithAddOn(menuName, menuDescription, add_On_Title, add_On1_Name, add_On1_Description, add_On1_Price, add_On2_Name, add_On2_Description, add_On2_Price);

                //View Menu on PDF Mode
                PropertyAdmin.Click_Link_PDF_View();
                Logger.WriteDebugMessage("PDF View is displayed");
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.VerifyMenu(category, null, menuName, add_On_Title, add_On1_Name, add_On2_Name);
                Helper.ExitFrame();

                //Preview the Changes on Preview Page
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.VerifyMenu(category, null, menuName, add_On_Title, add_On1_Name, add_On2_Name);
                Helper.CloseWindow();
                Helper.ControlToPreviousWindow();

                //Publish the changes
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end and Verify the Added Menu with Choices
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigate to Home page");
                PropertyAdmin.VerifyMenu(category, null, menuName, add_On_Title, add_On1_Name, add_On2_Name);
                Helper.CloseWindow();
                Helper.ControlToPreviousWindow();

                //Navigate to menu to delete
                PropertyAdmin.Click_MyMenus();
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_MainCategory(category);
                Helper.ExitFrame();
                PropertyAdmin.Delete_Menu(menuName);

                //Log test data into log file as well as extent report


                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Category Name", category);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Description", menuDescription); Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On Tile", add_On_Title);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 1 Name", add_On1_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 1 Description", add_On1_Description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add on 1 Price", add_On1_Price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 2 Name", add_On2_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 2 Description", add_On2_Description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add on 2 Price", add_On2_Price, true);
            }
        }
        public static void TC_261131()
        {
            if (TestCaseId == Utility.Constants.TC_261131)
            {
                //prerequisites
                string propertyName, category, menuName, menuDescription, choiceName, choiceDescription, option1Name, option1Price, option2Name, option2price, num;
                Random no = new Random();
                num = no.Next().ToString();

                //Retrieve data from Database or test data file
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertySupplier");
                category = TestData.ExcelData.TestDataReader.ReadData(1, "Category");
                menuName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuName"), num);
                menuDescription = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");
                choiceName = TestData.ExcelData.TestDataReader.ReadData(1, "ChoiceName");
                choiceDescription = TestData.ExcelData.TestDataReader.ReadData(1, "ChoiceDesciption");
                option1Name = TestData.ExcelData.TestDataReader.ReadData(1, "Option1Name");
                option1Price = TestData.ExcelData.TestDataReader.ReadData(1, "Option1Price");
                option2Name = TestData.ExcelData.TestDataReader.ReadData(1, "Option2Name");
                option2price = TestData.ExcelData.TestDataReader.ReadData(1, "Option2Price");

                //Navigate to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoPropertyLITE(propertyName);

                //Navigate to Menu
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_MainCategory(category);
                Logger.WriteDebugMessage(category + " selected");
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                Logger.WriteDebugMessage("Navigated to Menu Page");

                //Add Menu with the choices
                PropertyAdmin.Menu_WithChoices(menuName, menuDescription, choiceName, choiceDescription, option1Name, option1Price, option2Name, option2price);

                //View Menu on PDF Mode
                PropertyAdmin.Click_Link_PDF_View();
                Logger.WriteDebugMessage("PDF View is displayed");
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.VerifyMenu(category, null, menuName, choiceName, option1Name, option2Name);
                Helper.ExitFrame();

                //Preview the Changes on Preview Page
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.VerifyMenu(category, null, menuName, choiceName, option1Name, option2Name);
                Helper.CloseWindow();
                Helper.ControlToPreviousWindow();

                //Publish the changes
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end and Verify the Added Menu with Choices
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigate to Home page");
                PropertyAdmin.VerifyMenu(category, null, menuName, choiceName, option1Name, option2Name);
                Helper.CloseWindow();
                Helper.ControlToPreviousWindow();

                //Navigate to menu to delete
                PropertyAdmin.Click_MyMenus();
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_MainCategory(category);
                Helper.ExitFrame();
                PropertyAdmin.Delete_Menu(menuName);

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Category Name", category);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Description", menuDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Choice Name", choiceName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Choice Description", choiceDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_1 Name", option1Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_1 Price", option1Price);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_2 Name", option2Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_2 Price", option2price, true);
            }
        }
        public static void TC_260422()
        {
            if (TestCaseId == Utility.Constants.TC_260422)
            {
                //Prerequisite
                string propertyName, propertyLite, category, glutenFreeMenu_Name, milkAvoidanceMenu_Name,
                        mostPopularMenu_Name, num;

                Random no = new Random();
                num = no.Next().ToString();

                //Retrieve data from Test data
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertySupplier");
                propertyLite = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyLite");
                category = TestData.ExcelData.TestDataReader.ReadData(1, "Category");
                glutenFreeMenu_Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "GlutenFreeMenu_Name"), num);
                milkAvoidanceMenu_Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MilkAvoidanceMenu_Name"), num);
                mostPopularMenu_Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MostPopularMenu_Name"), num);

                //Navigate to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoPropertyLITE(propertyName);

                //Verify Filters and Tags Needed (Prerequisite)
                PropertyAdmin.Click_MyMenu_Settings();
                PropertyAdmin.Settings_MenuFilter_Tab();

                if (!PageObject_PropertyAdmin.Click_Filter_GlutenFree().Selected)
                    PropertyAdmin.Click_Filter_GlutenFree();
                if (!PageObject_PropertyAdmin.Click_Filter_MilkAvoidance().Selected)
                    PropertyAdmin.Click_Filter_MilkAvoidance();
                PropertyAdmin.Add_Tag("Most Popular");


                //Navigate to Category and Add Menu Items
                PropertyAdmin.Click_MyMenus();
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_MainCategory(category);
                Logger.WriteDebugMessage(category + " selected");
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                Logger.WriteDebugMessage("Navigated to Menu Page");

                //Add Menu Item as Gluten Free
                PropertyAdmin.AddNewMenuWithGlutenFreeFilter(glutenFreeMenu_Name);

                //Add Menu with Milk Avoidance
                PropertyAdmin.AddNewMenuAsMilkAvoidance(milkAvoidanceMenu_Name);

                //Add Menu Item as Most Popular
                PropertyAdmin.AddNewMenuAsMostPopular(mostPopularMenu_Name);

                //Navigate to Front End and verify filters on Corporate property
                Helper.ExitFrame();
                PropertyAdmin.Publish_Changes();
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigate to Home page");
                HomePage.HomePage_Filter(category, glutenFreeMenu_Name, milkAvoidanceMenu_Name, mostPopularMenu_Name);
                Helper.CloseWindow();
                Helper.ControlToPreviousWindow();

                //Navigate to Front End and verify filters on Lite property
                PropertyAdmin.SwitchProperty(propertyLite);
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigate to Home page");
                HomePage.HomePage_Filter(category, glutenFreeMenu_Name, milkAvoidanceMenu_Name, mostPopularMenu_Name);
                Helper.CloseWindow();
                Helper.ControlToPreviousWindow();

                //Navigate to menu to delete
                PropertyAdmin.SwitchProperty(propertyName);
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_MainCategory(category);
                Helper.ExitFrame();
                PropertyAdmin.Delete_Menu(glutenFreeMenu_Name);
                Helper.ExitFrame();
                PropertyAdmin.Delete_Menu(milkAvoidanceMenu_Name);
                Helper.ExitFrame();
                PropertyAdmin.Delete_Menu(mostPopularMenu_Name);

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Lite", propertyLite);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Category Name", category);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Gluten Free Menu Name", glutenFreeMenu_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Milk Avoidance Menu Name", milkAvoidanceMenu_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Most Popular Menu Name", mostPopularMenu_Name, true);

            }
        }
        public static void TC_261133()
        {
            if (TestCaseId == Utility.Constants.TC_261133)
            {
                //Prerequisite
                string propertyName, propertyLite, category, glutenFreeMenu_Name, milkAvoidanceMenu_Name,
                        mostPopularMenu_Name, num;

                Random no = new Random();
                num = no.Next().ToString();

                //Retrieve data from Test data
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertySupplier");
                propertyLite = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyLite");
                category = TestData.ExcelData.TestDataReader.ReadData(1, "Category");
                glutenFreeMenu_Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "GlutenFreeMenu_Name"), num);
                milkAvoidanceMenu_Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MilkAvoidanceMenu_Name"), num);
                mostPopularMenu_Name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MostPopularMenu_Name"), num);

                //Navigate to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoPropertyLITE(propertyName);

                //Verify Filters and Tags Needed (Prerequisite)
                PropertyAdmin.Click_MyMenu_Settings();
                PropertyAdmin.Settings_MenuFilter_Tab();

                if (!PageObject_PropertyAdmin.Click_Filter_GlutenFree().Selected)
                    PropertyAdmin.Click_Filter_GlutenFree();
                if (!PageObject_PropertyAdmin.Click_Filter_MilkAvoidance().Selected)
                    PropertyAdmin.Click_Filter_MilkAvoidance();
                PropertyAdmin.Add_Tag("Most Popular");

                //Switch to Lite
                PropertyAdmin.SwitchProperty(propertyLite);

                //Navigate to Category and Add Menu Items
                PropertyAdmin.Click_MyMenus();
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_MainCategory(category);
                Logger.WriteDebugMessage(category + " selected");
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                Logger.WriteDebugMessage("Navigated to Menu Page");

                //Add Menu Item as Gluten Free
                PropertyAdmin.AddNewMenuWithGlutenFreeFilter(glutenFreeMenu_Name);

                //Add Menu with Milk Avoidance
                PropertyAdmin.AddNewMenuAsMilkAvoidance(milkAvoidanceMenu_Name);

                //Add Menu Item as Most Popular
                PropertyAdmin.AddNewMenuAsMostPopular(mostPopularMenu_Name);

                //Navigate to Front End and verify filters on Corporate property
                Helper.ExitFrame();
                PropertyAdmin.Publish_Changes();
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigate to Home page");
                HomePage.HomePage_Filter(category, glutenFreeMenu_Name, milkAvoidanceMenu_Name, mostPopularMenu_Name);
                Helper.CloseWindow();
                Helper.ControlToPreviousWindow();

                //Navigate to menu to delete
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_MainCategory(category);
                Helper.ExitFrame();
                PropertyAdmin.Delete_Menu(glutenFreeMenu_Name);
                Helper.ExitFrame();
                PropertyAdmin.Delete_Menu(milkAvoidanceMenu_Name);
                Helper.ExitFrame();
                PropertyAdmin.Delete_Menu(mostPopularMenu_Name);

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Lite", propertyLite);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Category Name", category);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Gluten Free Menu Name", glutenFreeMenu_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Milk Avoidance Menu Name", milkAvoidanceMenu_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Most Popular Menu Name", mostPopularMenu_Name, true);
            }

        }
        public static void TC_260421()
        {
            if (TestCaseId == Utility.Constants.TC_260421)
            {
                //Prerequisites
                string propertyName, menuname, search_ClientName, firstName, lastName, companyName, email, 
                    messageContent, num, menuName1, menuName2, menuName3, email2;

                //Retrieve data from test data
                Random radNum = new Random();
                num = radNum.Next().ToString();

                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertySupplier");
                menuname = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuName"), num);
                search_ClientName = TestData.ExcelData.TestDataReader.ReadData(1, "Search_ClientName");
                firstName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "First_Name"), num);
                lastName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Last_Name"), num);
                companyName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Company_Name"), num);
                email = String.Concat("Test_Share", num, "@cendyn17.com");
                email2 = String.Concat("Test_Share", num + 1, "@cendyn17.com");
                menuName1 = TestData.ExcelData.TestDataReader.ReadData(1, "First_MenuName");
                menuName2 = TestData.ExcelData.TestDataReader.ReadData(1, "Second_MenuName");
                menuName3 = TestData.ExcelData.TestDataReader.ReadData(1, "Third_MenuName");

                //Login to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoPropertyLITE(propertyName);

                //Navigate to Share Menu Page
                PropertyAdmin.Click_Link_Share();
                Helper.ElementWait(PageObject_PropertyAdmin.Enter_ShareMenu_Name(), 60);
                Logger.WriteDebugMessage("Landed on Share Menu Page");

                //Enter Details on Set Up and Navigate to Choose Menu Page
                PropertyAdmin.Enter_ShareMenu_Name(menuname);
                PropertyAdmin.Check_Pricing_Checkbox();
                Logger.WriteDebugMessage("All Details are entered into Set Up Page ");
                PropertyAdmin.Click_Continue_Button();

                //Entered Details for Choose Menu Page and Navigate to Send Page
                PropertyAdmin.Check_Menu_For_Pages(menuName1);
                PropertyAdmin.Check_Menu_For_Pages(menuName2);
                Logger.WriteDebugMessage("Selected Menu Items on Choose Menu Page");
                DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Continue_Button());
                PropertyAdmin.Click_Continue_Button();
                Helper.ElementWait(PageObject_PropertyAdmin.Click_Search_Client_Button(), 60);
                Logger.WriteDebugMessage("Navigated on Send email Page");

                //Select the Existing Client and Verify the Name is displaying on Message Content
                PropertyAdmin.Search_Existing_Client(search_ClientName, firstName, lastName, companyName, email);
                Logger.WriteDebugMessage("Client got Displayed on the page");
                EnterFrame("textAreaContent_ifr");
                messageContent = PropertyAdmin.Share_Message_Content();
                ExitFrame();
                if (messageContent.Contains(search_ClientName) || messageContent.Contains(firstName))
                    Logger.WriteDebugMessage(" Client Name is Present on the Message content");
                else
                    Assert.Fail("Client Name is not displayed on the message content");

                //Verify the Preview Functionality and Send Email to Client
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Preview_Button());
                Logger.WriteDebugMessage("Preview Button got displayed");
                PropertyAdmin.Click_Preview_Button();
                ControlToNextWindow();
                Logger.WriteDebugMessage("Navigated to Preview Page");
                HomePage.Added_CategoryDropDown(menuName1);
                Logger.WriteDebugMessage("Clicked on " + menuName1 + " Menu");
                HomePage.Added_CategoryDropDown(menuName2);
                Logger.WriteDebugMessage("Clicked on " + menuName2 + " Menu");
                if (IsWebElementRemoved(PageObject_HomePage.Added_CategoryDropDown(menuName3)))
                    Assert.Fail("Unselected menu item is showing.");
                CloseCurrentTab();
                ControlToNextWindow();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Send_Email());
                Logger.WriteDebugMessage("Send Button got displayed");
                PropertyAdmin.Click_Send_Email();
                Logger.WriteDebugMessage("Go To Activity Page button Overlay got Displayed");

                //Click on Goto Activity and Verify the Share Menu on the Activity Page
                PropertyAdmin.Click_GoToActivity_Button();
                Logger.WriteDebugMessage("Navigated to Activity Page");
                PropertyAdmin.Search_Menu_Filter(menuname);
                VerifyTextOnPageAndHighLight(menuname);
                Logger.WriteDebugMessage("Menu Name got Displayed");


                //Verify the Clone Functionality 
                PropertyAdmin.Click_Action_Button();
                Logger.WriteDebugMessage("Action Button got clicked");
                PropertyAdmin.Click_Clone_Link();
                Logger.WriteDebugMessage("Clone Confirmation Overlay got Displayed");
                PropertyAdmin.Click_Clone_Button();
                Logger.WriteDebugMessage("Navigated to Share Menu Page");
                PropertyAdmin.Enter_ShareMenu_Name(menuname + "_Clone");
                PropertyAdmin.Check_Format_Checkbox();
                Logger.WriteDebugMessage("All Details are entered into Clone Share Menu Page ");
                PropertyAdmin.Click_Continue_Button();

                //Entered Details for Choose Menu Page and Navigate to Send Page
                PropertyAdmin.Check_Menu_For_Pages(menuName3);
                Logger.WriteDebugMessage("Selected Menu Items on Choose Menu Page");
                PropertyAdmin.Click_Continue_Button();
                Helper.ElementWait(PageObject_PropertyAdmin.Click_Search_Client_Button(), 60);
                Logger.WriteDebugMessage("Navigated on Send email Page");

                //Add New Client and Search for the name in Message content
                
                PropertyAdmin.Add_New_Client(firstName, lastName, companyName, email2);
                Helper.EnterFrame("textAreaContent_ifr");
                messageContent = PropertyAdmin.Share_Message_Content();
                Helper.ExitFrame();
                if (messageContent.Contains(search_ClientName) || messageContent.Contains(firstName))
                    Logger.WriteDebugMessage(" Client Name is Present on the Message content");
                else
                    Assert.Fail("Client Name is not displayed on the message content");

                //Sent Email to Client and verify the Clone Menu on Activity Page
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Send_Email());
                Logger.WriteDebugMessage("Send button is displayed");
                PropertyAdmin.Click_Send_Email();
                Helper.ElementWait(PageObject_PropertyAdmin.Click_GoToActivity_Button(), 60);
                Logger.WriteDebugMessage("Menu Email Send Successfully and Go to Activity Overlay got Displayed");
                PropertyAdmin.Click_GoToActivity_Button();
                Logger.WriteDebugMessage("Navigated to Activity Page");
                PropertyAdmin.Search_Menu_Filter(menuname + "_Clone");
                VerifyTextOnPageAndHighLight(menuname + "_Clone");
                Logger.WriteDebugMessage("Menu Name got Displayed");

                //Navigate to CatchAll and Verify the email in catchAll
                Email.LogIntoCatchAll();
                Email.CatchAll_SearchEmailAndOpenLatestMessage(email2);
                ElementWait(PageObject_Email.Share_Menu_Email(), 60);
                Email.Click_Share_Menu_Link();
                ControlToNextWindow();
                Logger.WriteDebugMessage("Email got Displayed in CatchAll of Clone Share menu = " + menuname + "_Clone");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuname);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Search Client Name", search_ClientName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Share To First Name", firstName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Share To Last Name", lastName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Share To Company", companyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_First Menu Name", menuName1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Second Menu Name", menuName2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Thirt Menu Name", menuName3, true);
            }
        }
        public static void TC_261132()
        {
            if (TestCaseId == Utility.Constants.TC_261132)
            {     //Prerequisites
                string propertyName, menuname, search_ClientName, firstName, lastName, companyName, email,
                    messageContent, num, menuName1, menuName2, menuName3, email2;

                //Retrieve data from test data
                Random radNum = new Random();
                num = radNum.Next().ToString();

                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertySupplier");
                menuname = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuName"), num);
                search_ClientName = TestData.ExcelData.TestDataReader.ReadData(1, "Search_ClientName");
                firstName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "First_Name"), num);
                lastName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Last_Name"), num);
                companyName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Company_Name"), num);
                email = String.Concat("Test_Share", num, "@cendyn17.com");
                email2 = String.Concat("Test_Share", num + 1, "@cendyn17.com");
                menuName1 = TestData.ExcelData.TestDataReader.ReadData(1, "First_MenuName");
                menuName2 = TestData.ExcelData.TestDataReader.ReadData(1, "Second_MenuName");
                menuName3 = TestData.ExcelData.TestDataReader.ReadData(1, "Third_MenuName");
               
                //Login to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoPropertyLITE(propertyName);

                //Navigate to Share Menu Page
                PropertyAdmin.Click_Link_Share();
                Helper.ElementWait(PageObject_PropertyAdmin.Enter_ShareMenu_Name(), 60);
                Logger.WriteDebugMessage("Landed on Share Menu Page");

                //Enter Details on Set Up and Navigate to Choose Menu Page
                PropertyAdmin.Enter_ShareMenu_Name(menuname);
                PropertyAdmin.Check_Pricing_Checkbox();
                Logger.WriteDebugMessage("All Details are entered into Set Up Page ");
                PropertyAdmin.Click_Continue_Button();

                //Entered Details for Choose Menu Page and Navigate to Send Page
                PropertyAdmin.Check_Menu_For_Pages(menuName1);
                PropertyAdmin.Check_Menu_For_Pages(menuName2);
                Logger.WriteDebugMessage("Selected Menu Items on Choose Menu Page");
                DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Continue_Button());
                PropertyAdmin.Click_Continue_Button();
                Helper.ElementWait(PageObject_PropertyAdmin.Click_Search_Client_Button(), 60);
                Logger.WriteDebugMessage("Navigated on Send email Page");

                //Select the Existing Client and Verify the Name is displaying on Message Content
                PropertyAdmin.Search_Existing_Client(search_ClientName, firstName, lastName, companyName, email);
                Logger.WriteDebugMessage("Client got Displayed on the page");
                EnterFrame("textAreaContent_ifr");
                messageContent = PropertyAdmin.Share_Message_Content();
                ExitFrame();
                if (messageContent.Contains(search_ClientName) || messageContent.Contains(firstName))
                    Logger.WriteDebugMessage(" Client Name is Present on the Message content");
                else
                    Assert.Fail("Client Name is not displayed on the message content");

                //Verify the Preview Functionality and Send Email to Client
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Preview_Button());
                Logger.WriteDebugMessage("Preview Button got displayed");
                PropertyAdmin.Click_Preview_Button();
                ControlToNextWindow();
                Logger.WriteDebugMessage("Navigated to Preview Page");
                HomePage.Added_CategoryDropDown(menuName1);
                Logger.WriteDebugMessage("Clicked on " + menuName1 + " Menu");
                HomePage.Added_CategoryDropDown(menuName2);
                Logger.WriteDebugMessage("Clicked on " + menuName2 + " Menu");
                if (IsWebElementRemoved(PageObject_HomePage.Added_CategoryDropDown(menuName3)))
                    Assert.Fail("Unselected menu item is showing.");
                CloseCurrentTab();
                ControlToNextWindow();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Send_Email());
                Logger.WriteDebugMessage("Send Button got displayed");
                PropertyAdmin.Click_Send_Email();
                Logger.WriteDebugMessage("Go To Activity Page button Overlay got Displayed");

                //Click on Goto Activity and Verify the Share Menu on the Activity Page
                PropertyAdmin.Click_GoToActivity_Button();
                Logger.WriteDebugMessage("Navigated to Activity Page");
                PropertyAdmin.Search_Menu_Filter(menuname);
                VerifyTextOnPageAndHighLight(menuname);
                Logger.WriteDebugMessage("Menu Name got Displayed");


                //Verify the Clone Functionality 
                PropertyAdmin.Click_Action_Button();
                Logger.WriteDebugMessage("Action Button got clicked");
                PropertyAdmin.Click_Clone_Link();
                Logger.WriteDebugMessage("Clone Confirmation Overlay got Displayed");
                PropertyAdmin.Click_Clone_Button();
                Logger.WriteDebugMessage("Navigated to Share Menu Page");
                PropertyAdmin.Enter_ShareMenu_Name(menuname + "_Clone");
                PropertyAdmin.Check_Format_Checkbox();
                Logger.WriteDebugMessage("All Details are entered into Clone Share Menu Page ");
                PropertyAdmin.Click_Continue_Button();

                //Entered Details for Choose Menu Page and Navigate to Send Page
                PropertyAdmin.Check_Menu_For_Pages(menuName3);
                Logger.WriteDebugMessage("Selected Menu Items on Choose Menu Page");
                PropertyAdmin.Click_Continue_Button();
                Helper.ElementWait(PageObject_PropertyAdmin.Click_Search_Client_Button(), 60);
                Logger.WriteDebugMessage("Navigated on Send email Page");

                //Add New Client and Search for the name in Message content

                PropertyAdmin.Add_New_Client(firstName, lastName, companyName, email2);
                Helper.EnterFrame("textAreaContent_ifr");
                messageContent = PropertyAdmin.Share_Message_Content();
                Helper.ExitFrame();
                if (messageContent.Contains(search_ClientName) || messageContent.Contains(firstName))
                    Logger.WriteDebugMessage(" Client Name is Present on the Message content");
                else
                    Assert.Fail("Client Name is not displayed on the message content");

                //Sent Email to Client and verify the Clone Menu on Activity Page
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Send_Email());
                Logger.WriteDebugMessage("Send button is displayed");
                PropertyAdmin.Click_Send_Email();
                Helper.ElementWait(PageObject_PropertyAdmin.Click_GoToActivity_Button(), 60);
                Logger.WriteDebugMessage("Menu Email Send Successfully and Go to Activity Overlay got Displayed");
                PropertyAdmin.Click_GoToActivity_Button();
                Logger.WriteDebugMessage("Navigated to Activity Page");
                PropertyAdmin.Search_Menu_Filter(menuname + "_Clone");
                VerifyTextOnPageAndHighLight(menuname + "_Clone");
                Logger.WriteDebugMessage("Menu Name got Displayed");

                //Navigate to CatchAll and Verify the email in catchAll
                Email.LogIntoCatchAll();
                Email.CatchAll_SearchEmailAndOpenLatestMessage(email2);
                ElementWait(PageObject_Email.Share_Menu_Email(), 60);
                Email.Click_Share_Menu_Link();
                ControlToNextWindow();
                Logger.WriteDebugMessage("Email got Displayed in CatchAll of Clone Share menu = " + menuname + "_Clone");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuname);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Search Client Name", search_ClientName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Share To First Name", firstName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Share To Last Name", lastName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Share To Company", companyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_First Menu Name", menuName1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Second Menu Name", menuName2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Thirt Menu Name", menuName3, true);
            }
        }
        public static void TC_232406()
        {
            if (TestCaseId == Utility.Constants.TC_232406)
            {
                //Prerequisite   
                string propertyName, social_Media_Type, social_Media_Url, social_Media_Url_Edit, type_Vaidation, url_Validation, invalid_Url, invalid_Url_Validation;

                //Retrieve data from Test data
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                social_Media_Type = TestData.ExcelData.TestDataReader.ReadData(1, "Social_Media_Type");
                social_Media_Url = TestData.ExcelData.TestDataReader.ReadData(1, "Social_Media_Url");
                social_Media_Url_Edit = TestData.ExcelData.TestDataReader.ReadData(1, "Social_Media_Url_Edit");
                type_Vaidation = TestData.ExcelData.TestDataReader.ReadData(1, "Type_Vaidation");
                url_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "Url_Validation");
                invalid_Url = TestData.ExcelData.TestDataReader.ReadData(1, "Invalid_Url");
                invalid_Url_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "InValid_Url_Validation");

                //Login to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoPropertyLITE(propertyName);

                //Navigate to Social Media Tab
                PropertyAdmin.Click_MyMenu_Settings();
                ElementWait(PageObject_PropertyAdmin.Click_Social_Media_Tab(), 30);
                Logger.WriteDebugMessage("Navigate to Advance settings page");
                PropertyAdmin.Click_Social_Media_Tab();
                ElementWait(PageObject_PropertyAdmin.Click_Add_New_Social_Media(), 30);
                Logger.WriteDebugMessage("Navigate to Social Media Page");

                //Remove Social Used for this test case 
                if (Helper.VerifyTextOnPage(social_Media_Type))
                {
                    PropertyAdmin.Delete_Social_Media(social_Media_Type);
                }

                //Required Fields Validation for Social Media Overlay
                PropertyAdmin.Social_Media_Validation(social_Media_Type, type_Vaidation, url_Validation, invalid_Url, invalid_Url_Validation);

                //Add new Social Media
                PropertyAdmin.Add_New_Social_Media(social_Media_Type, social_Media_Url);

                //Navigate to My Menus and Verify the Added Social Media
                PropertyAdmin.Click_MyMenus();
                Logger.WriteDebugMessage("Navigated to My Menu Page");
                Helper.EnterFrame("frontendEditorIframe");
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Social_Media(social_Media_Type));
                Logger.WriteDebugMessage("Added Social Media is displaying on the Admin");
                PropertyAdmin.Click_Social_Media(social_Media_Type);
                Helper.ExitFrame();
                Helper.ControlToNextWindow();
                if (social_Media_Url.Equals(Helper.Driver.Url))
                    Logger.WriteDebugMessage("Navigated to = " + social_Media_Type + " Social Media");
                else
                    Assert.Fail("Navigated to incorrect URL");
                CloseCurrentTab();

                //Navigate to Front-end and Verify the Social Media
                PropertyAdmin.Click_PublishedView();
                ControlToNextWindow();
                Logger.WriteDebugMessage("Navigate to Front-end");
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Social_Media(social_Media_Type));
                Logger.WriteDebugMessage("Added Social Media is displaying on the Front-end");
                PropertyAdmin.Click_Social_Media(social_Media_Type);
                Helper.ControlToNextWindow();
                if (social_Media_Url.Equals(Helper.Driver.Url))
                    Logger.WriteDebugMessage("Navigated to = " + social_Media_Type + " Social Media");
                else
                    Assert.Fail("Navigated to incorrect URL");
                CloseCurrentTab();


                //Navigate back to Admin and Edit the Social Media
                PropertyAdmin.Click_MyMenu_Settings();
                ElementWait(PageObject_PropertyAdmin.Click_Social_Media_Tab(), 30);
                Logger.WriteDebugMessage("Navigate to Advance settings page");
                PropertyAdmin.Click_Social_Media_Tab();
                ElementWait(PageObject_PropertyAdmin.Click_Add_New_Social_Media(), 30);
                Logger.WriteDebugMessage("Navigate to Social Media Page");
                PropertyAdmin.Edit_Social_Media(social_Media_Type, social_Media_Url_Edit);

                //Navigate to My Menus and Verify the Edited Social Media
                PropertyAdmin.Click_MyMenus();
                Logger.WriteDebugMessage("Navigated to My Menu Page");
                Helper.EnterFrame("frontendEditorIframe");
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Social_Media(social_Media_Type));
                Logger.WriteDebugMessage("Added Social Media is displaying on the Admin");
                PropertyAdmin.Click_Social_Media(social_Media_Type);
                Helper.ExitFrame();
                Helper.ControlToNextWindow();
                if (social_Media_Url_Edit.Equals(Helper.Driver.Url))
                    Logger.WriteDebugMessage("Navigated to = " + social_Media_Type + " Social Media");
                else
                    Assert.Fail("Navigated to incorrect URL");
                CloseCurrentTab();

                //Navigate to Front-end and Verify the Edited Social Media
                ControlToNextWindow();
                Logger.WriteDebugMessage("Navigate to Front-end");
                Helper.ReloadPage();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Social_Media(social_Media_Type));
                Logger.WriteDebugMessage("Added Social Media is displaying on the Front-end");
                PropertyAdmin.Click_Social_Media(social_Media_Type);
                Helper.ControlToNextWindow();
                if (social_Media_Url_Edit.Equals(Helper.Driver.Url))
                    Logger.WriteDebugMessage("Navigated to = " + social_Media_Type + " Social Media");
                else
                    Assert.Fail("Navigated to incorrect URL");
                CloseCurrentTab();

                //Delete the Social Media and Verify the Social Media on Admin
                PropertyAdmin.Click_MyMenu_Settings();
                ElementWait(PageObject_PropertyAdmin.Click_Social_Media_Tab(), 30);
                Logger.WriteDebugMessage("Navigate to Advance settings page");
                PropertyAdmin.Click_Social_Media_Tab();
                ElementWait(PageObject_PropertyAdmin.Click_Add_New_Social_Media(), 30);
                Logger.WriteDebugMessage("Navigate to Social Media Page");
                PropertyAdmin.Delete_Social_Media(social_Media_Type);
                PropertyAdmin.Click_MyMenus();
                Helper.EnterFrame("frontendEditorIframe");
                PageDown();
                if (Helper.IsElementRemoved(social_Media_Type))
                    Assert.Fail(social_Media_Type + " Social Media is not get deleted");
                else
                    Logger.WriteDebugMessage(social_Media_Type + " Social Media got deleted successfully");
                Helper.ExitFrame();

                //Navigate to Front-end and Verify the Social Media
                ControlToNextWindow();
                Helper.ReloadPage();
                if (Helper.IsElementRemoved(social_Media_Type))
                    Assert.Fail(social_Media_Type + " Social Media is not get deleted");
                else
                    Logger.WriteDebugMessage(social_Media_Type + " Social Media got deleted successfully");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Social Media Type", social_Media_Type);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Social Media URL", social_Media_Url);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Social Media Edited URL", social_Media_Url_Edit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Social Media Type Validation", type_Vaidation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Social Media URL Validation", url_Validation, true);
            }
        } }
        }
 