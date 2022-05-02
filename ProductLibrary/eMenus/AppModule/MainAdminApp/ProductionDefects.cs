using System;
using Automation.Base.Utility;
using BaseUtility.Utility;
using eMenus.AppModule.Admin;
using eMenus.PageObject.Admin;
using eMenus.Utility;
using InfoMessageLogger;
using MongoDB.Bson.Serialization.Options;
using NUnit.Framework;
using OpenQA.Selenium;
using TestData;

namespace eMenus.AppModule.MainAdminApp
{
    public partial class MainAdminApp : eMenus.Utility.Setup
    {
        public static void D_233380()
        {
            if (TestCaseId == Utility.Constants.D_233380)
            {
                //Pre-requisites
                string propertyAdmin_Username, password, propertyName, menuItem_Name, error_Message, menuname = "        ";

                //Retrieve data from test data
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                menuItem_Name = TestData.ExcelData.TestDataReader.ReadData(1, "MenuName");
                error_Message = TestData.ExcelData.TestDataReader.ReadData(1, "Error_Message");

                //Login to Admin 
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoProperty(propertyName);

                //Navigate to Share Menu Page
                PropertyAdmin.Click_Link_Share();
                Helper.ElementWait(PageObject_PropertyAdmin.Enter_ShareMenu_Name(), 60);
                Logger.WriteDebugMessage("Landed on Share Menu Page");

                //Verify share menu with blank space
                PropertyAdmin.Enter_ShareMenu_Name(menuname);
                PropertyAdmin.Click_Continue_Button();

                if (PageObject_PropertyAdmin.Check_Menu_For_Pages(menuItem_Name).Displayed)
                    Assert.Fail("User allowed to share menu with blank space");
                else
                {
                    VerifyTextOnPageAndHighLight(error_Message);
                    Logger.WriteDebugMessage("User not allowed to share menu with blank space");
                }


                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Error Message", error_Message, true);

            }
        }
        public static void D_234734()
        {
            if (TestCaseId == Utility.Constants.D_234734)
            {
                //Pre-requisites
                string propertyAdmin_Username, password, propertyName, menuName, choiceName, option1Name, option2Name, option3Name, choiceName2, edit = "_Edit";

                //Retrieve data from test data
                Random radNum = new Random();
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                menuName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuName"), radNum.Next().ToString());
                choiceName = TestData.ExcelData.TestDataReader.ReadData(1, "ChoiceName");
                choiceName2 = TestData.ExcelData.TestDataReader.ReadData(1, "ChoiceName2");
                option1Name = TestData.ExcelData.TestDataReader.ReadData(1, "Option1Name");
                option2Name = TestData.ExcelData.TestDataReader.ReadData(1, "Option2Name");
                option3Name = TestData.ExcelData.TestDataReader.ReadData(1, "Option3Name");


                //Login to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoProperty(propertyName);

                //Navigate to Menu
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Breakfast drop-down should get clicked");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                Logger.WriteDebugMessage("Navigated to Menu Page");

                //Add Menu name
                PropertyAdmin.Click_MyMenu_AddNewMenu();
                Logger.WriteDebugMessage("Add new menu modal should get displayed");
                Helper.ExitFrame();
                PropertyAdmin.AddNewMenu_MenuName(menuName);

                //Add First Choice
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_AddNewMenu_AddChoiceButton());
                PropertyAdmin.Click_AddNewMenu_AddChoiceButton();
                PropertyAdmin.AddNewMenu_AddChoice_Name(choiceName);
                string desId = PropertyAdmin.GetFrameId("2");
                Logger.WriteDebugMessage("Name should get added");

                //Add First and Second Options
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_AddNewMenu_NewOptionButton());
                PropertyAdmin.Click_AddNewMenu_NewOptionButton();
                desId = PropertyAdmin.GetFrameId("3");
                Helper.EnterFrame(desId);
                PropertyAdmin.AddNewMenu_AddChoice_Option(desId.Substring(0, 16), option1Name);
                Helper.ExitFrame();
                Logger.WriteDebugMessage(option1Name + "- Name of First choice Option");

                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_AddNewMenu_NewOptionButton2());
                PropertyAdmin.Click_AddNewMenu_NewOptionButton2();
                desId = PropertyAdmin.GetFrameId("4");
                Helper.EnterFrame(desId);
                PropertyAdmin.AddNewMenu_AddChoice_Option(desId.Substring(0, 16), option2Name);
                Helper.ExitFrame();
                Logger.WriteDebugMessage(option2Name + "- Name of Second choice Option");

                //Add Second Choice and click on 'Choice Move Up' button
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_AddNewMenu_AddChoiceButton2());
                PropertyAdmin.Click_AddNewMenu_AddChoiceButton2();
                PropertyAdmin.AddNewMenu_AddChoice2_Name(choiceName2);
                Logger.WriteDebugMessage("Name should get added");
                PropertyAdmin.Click_AddNewMenu2_NewOptionButton();
                PropertyAdmin.Click_ChoiceMoveUp_Button();

                // Edit upper choice
                try
                {
                    desId = PropertyAdmin.GetFrameId("3");
                    Helper.EnterFrame(desId);
                    PropertyAdmin.AddNewMenu_AddChoice_Option(desId.Substring(0, 16), option3Name);
                    VerifyTextOnPageAndHighLight(option3Name);
                    Helper.ExitFrame();
                    Logger.WriteDebugMessage(option3Name + "- Name of First upper Option Edited");
                }
                catch (Exception e)
                {
                    Assert.Fail(option1Name + edit + "- First upper option not edited", e);
                }


                // Edit choices on the lower option
                try
                {
                    desId = PropertyAdmin.GetFrameId("5");
                    Helper.EnterFrame(desId);
                    PropertyAdmin.AddNewMenu_AddChoice_Option(desId.Substring(0, 16), option1Name + edit);
                    VerifyTextOnPageAndHighLight(option1Name + edit);
                    Helper.ExitFrame();
                    Logger.WriteDebugMessage(option1Name + edit + "- Name of First lower Option Edited");
                }
                catch (Exception e)
                {
                    Assert.Fail(option1Name + edit + "- First lower option not edited", e);
                }

                try
                {
                    desId = PropertyAdmin.GetFrameId("6");
                    Helper.EnterFrame(desId);
                    PropertyAdmin.AddNewMenu_AddChoice_Option(desId.Substring(0, 16), option2Name + edit);
                    VerifyTextOnPageAndHighLight(option2Name + edit);
                    Helper.ExitFrame();
                    Logger.WriteDebugMessage(option2Name + edit + "- Name of Second lower Option Edited");
                }
                catch (Exception e)
                {
                    Assert.Fail(option1Name + edit + "- Second lower option not edited", e);
                }

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Admin Username", propertyAdmin_Username);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Choice Name", choiceName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Second Choice Name", choiceName2);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_1 Name", option1Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_2 Name", option2Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_3 Name", option3Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_1 Edited Name", option1Name + edit);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Option_2 Edited Name", option2Name + edit, true);
            }
        }

        public static void D_248778()
        {
            if (TestCaseId == Utility.Constants.D_248778)
            {
                //Pre-requisites
                string frontendUrl, signInText, userNameText;

                //Retrieve data from test data
                frontendUrl = TestData.ExcelData.TestDataReader.ReadData(1, "FrontendUrl");
                signInText = TestData.ExcelData.TestDataReader.ReadData(1, "SignInText");
                userNameText = TestData.ExcelData.TestDataReader.ReadData(1, "UserNameText");

                             
                //Navigate to Frontend
                Helper.Driver.Url = frontendUrl;
                Logger.WriteDebugMessage("Navigated to Front end URL");


                //Select language and verify Sign In Pop-up
                PropertyAdmin.Click_GlobeIcon();
                Logger.WriteDebugMessage("Globe Icon clicked");
                PropertyAdmin.Click_Globe_CloseIcon();
                Logger.WriteDebugMessage("Close icon clicked");
                if (IsElementRemoved(signInText) && IsElementRemoved(userNameText))
                    Assert.Fail("Sign In Pop-up displayed on the page");
                else
                    Logger.WriteDebugMessage("Sign In Pop-up not displaying on the page");

                PropertyAdmin.Click_GlobeIcon();
                Logger.WriteDebugMessage("Globe Icon clicked");
                PropertyAdmin.Click_Globe_FrançaisLanguage();
                Logger.WriteDebugMessage("Francais language selected");
                if (IsElementRemoved(signInText) && IsElementRemoved(userNameText))
                    Assert.Fail("Sign In Pop-up displayed on the page");
                else
                    Logger.WriteDebugMessage("Sign In Pop-up not displaying on the page");

                PropertyAdmin.Click_GlobeIcon();
                Logger.WriteDebugMessage("Globe Icon clicked");
                PropertyAdmin.Click_Globe_EnglishLanguage();
                Logger.WriteDebugMessage("English language selected");
                if (IsElementRemoved(signInText) && IsElementRemoved(userNameText))
                    Assert.Fail("Sign In Pop-up displayed on the page");
                else
                    Logger.WriteDebugMessage("Sign In Pop-up not displaying on the page");


                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Front end URL", frontendUrl);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Sign In Verification Text", signInText);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Username Verification Text", userNameText, true);
            }
        }

        public static void D_250928()
        {
            if (TestCaseId == Utility.Constants.D_250928)
            {
                //Pre-requisites
                string propertyAdmin_Username, password, propertyName, supplierName, text;

                //Retrieve data from test data
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                supplierName = TestData.ExcelData.TestDataReader.ReadData(1, "SupplierName");
                text = TestData.ExcelData.TestDataReader.ReadData(1, "Text");

                //Login to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoProperty(propertyName);
                               
                //Verify admin site from
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakMenu();
                Logger.WriteDebugMessage("Clicked on Break Menus");
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                PropertyAdmin.BreakMenu_EditIcon();
                Logger.WriteDebugMessage("Edit menu modal should get displayed");
                Helper.ExitFrame();
                ScrollToElement(PageObject_PropertyAdmin.Click_New_Add_On());

                //select filter
                PropertyAdmin.Click_Filter_GlutenFree();
                Logger.WriteDebugMessage("Gluten Free Filters were added.");

                //Save the Details 
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_AddNewMenu_BottomSaveButton());
                PropertyAdmin.Click_AddNewMenu_BottomSaveButton();
             
                //publish
                PropertyAdmin.Publish_Changes();

               
                //Select Cendyn Admin
                PropertyAdmin.Navigate_CendynAdmin();

                //Delete all category and clone from 'Hotel Origami' property
                CendynAdmin.Supplier_Tab();
                Logger.WriteDebugMessage("Clicked on Supplier tab");
                CendynAdmin.Click_category();
                Logger.WriteDebugMessage("Clicked on Category tab");
                CendynAdmin.Select_Supplier_DDM(supplierName);
                Logger.WriteDebugMessage(supplierName + "- Supplier name entered");
                for (int i = 1; i < 15; i++)
                {
                    if (IsWebElementRemoved(PageObject_CendynAdmin.Click_Category_DeleteCategoryButton()))
                    {
                        CendynAdmin.Click_Category_DeleteCategoryButton();
                        Logger.WriteDebugMessage("Delete Category Confirmation Overlay got Displayed");
                        CendynAdmin.Click_Delete_Category_Confrmation();
                        Logger.WriteDebugMessage("Category got Deleted Successfully");
                    }
                    else
                    {
                        Logger.WriteDebugMessage("No category present on the page");
                        break;
                    }
                }

                //Clone category
                CendynAdmin.Click_Category_CloneCategoryButton();
                Logger.WriteDebugMessage("Clicked on Clone category button");
                CendynAdmin.Enter_CloneCategory_FromSupplier(propertyName);
                CendynAdmin.Click_CloneCategory_SaveButton();
                Driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/div[2]/div/div[4]/div/div[4]/div/div/div[1]/button/span")).Click();
                Logger.WriteDebugMessage("Saved successfully");


                ////Navigate to Property Admin
                //CendynAdmin.NavigateToPropertyAdmin();
                            

                ////Verify admin site to
                //PropertyAdmin.Click_Select_PropertyDropdown();
                //Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
                //PropertyAdmin.Enter_Property_TextBox(supplierName);
                //Logger.WriteDebugMessage("Entered Property");
                //PropertyAdmin.Select_Property_Dropdown(supplierName);
                //Logger.WriteDebugMessage(supplierName + " Property got Selected");
                //Helper.EnterFrame("frontendEditorIframe");
                //ScrollToElement(PageObject_PropertyAdmin.Click_MyMenu_BreakMenu());
                //PropertyAdmin.Click_MyMenu_BreakMenu();
                //Logger.WriteDebugMessage("Clicked on Break Menus");
                //ScrollToText(text);
                //Helper.ExitFrame();
                //Logger.WriteDebugMessage("Gluten Free text present on the page");

                ////uncheck filter
                //PropertyAdmin.Click_Select_PropertyDropdown();
                //Logger.WriteDebugMessage("Clicked on Select Property Drop-down");
                //PropertyAdmin.Enter_Property_TextBox(propertyName);
                //Logger.WriteDebugMessage("Entered Property");
                //PropertyAdmin.Select_Property_Dropdown(propertyName);
                //Logger.WriteDebugMessage(propertyName + " Property got Selected");

                ////Verify admin site from
                //Helper.EnterFrame("frontendEditorIframe");
                //PropertyAdmin.Click_MyMenu_BreakMenu();
                //Logger.WriteDebugMessage("Clicked on Break Menus");
                //Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                //PropertyAdmin.BreakMenu_EditIcon();
                //Logger.WriteDebugMessage("Edit menu modal should get displayed");
                //Helper.ExitFrame();
                //ScrollToElement(PageObject_PropertyAdmin.Click_New_Add_On());

             
                //PropertyAdmin.Click_Filter_GlutenFree();
                //Logger.WriteDebugMessage("Filters were added.");

                ////Save the Details 
                //Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_AddNewMenu_BottomSaveButton());
                //PropertyAdmin.Click_AddNewMenu_BottomSaveButton();
               
                ////publish changes
                //PropertyAdmin.Publish_Changes();


                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Supplier Name", supplierName, true);

            }
        }

        public static void D_261817()
        {
            if (TestCaseId == Utility.Constants.D_261817)
            {
                //Pre-requisites
                string propertyAdmin_Username, password, propertyName, menuName, menuDescription, add_On_Title, add_On1_Name, add_On2_Name;

                //Retrieve data from test data
                Random radNum = new Random();
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                menuName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuName"), radNum.Next().ToString());
                menuDescription = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");
                add_On_Title = TestData.ExcelData.TestDataReader.ReadData(1, "Title");
                add_On1_Name = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On1_Name");
                add_On2_Name = TestData.ExcelData.TestDataReader.ReadData(1, "Add_On2_Name");

                //Login to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoProperty(propertyName);

                //Navigate to Menu
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Breakfast drop-down should get clicked");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                Logger.WriteDebugMessage("Navigated to Menu Page");

                //Add Menu name and description
                PropertyAdmin.Click_MyMenu_AddNewMenu();
                Logger.WriteDebugMessage("Add new menu modal should get displayed");
                Helper.ExitFrame();
                PropertyAdmin.AddNewMenu_MenuName(menuName);
                Helper.EnterFrame("cdescription_ifr");
                PropertyAdmin.AddNewMenu_AddChoice_Description("cdescription", menuDescription);
                Logger.WriteDebugMessage("Name and description should get added");
                Helper.ExitFrame();

                //Enter Add On Title
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Enter_Add_On_Title());
                PropertyAdmin.Enter_Add_On_Title(add_On_Title);

                //Add 1st and 2nd Add On 
                PropertyAdmin.Click_New_Add_On();
                Logger.WriteDebugMessage("Clicked on Add New Add on button");
                string desId = PropertyAdmin.GetFrameId("2");
                Helper.EnterFrame(desId);
                PropertyAdmin.AddNewMenu_AddChoice_Description(desId.Substring(0, 14), add_On1_Name);
                Helper.ExitFrame();
                Logger.WriteDebugMessage("Name should get added for 1st Add on");

                PropertyAdmin.Click_New_Add_On();
                Logger.WriteDebugMessage("Clicked on Add New Add on button");
                desId = PropertyAdmin.GetFrameId("4");
                Helper.EnterFrame(desId);
                PropertyAdmin.AddNewMenu_AddChoice_Description(desId.Substring(0, 14), add_On2_Name);
                Helper.ExitFrame();
                Logger.WriteDebugMessage("Name should get added for 2nd Add on");


                //Save the Details and Verify the Details on Property Admin
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_AddNewMenu_BottomSaveButton());
                PropertyAdmin.Click_AddNewMenu_BottomSaveButton();
                Helper.EnterFrame("frontendEditorIframe");
                Helper.ElementWait(PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu(), 60);
                Helper.VerifyTextOnPageAndHighLight(menuName);
                Helper.VerifyTextOnPageAndHighLight(add_On_Title);
                Helper.VerifyTextOnPageAndHighLight(add_On1_Name);
                Helper.VerifyTextOnPageAndHighLight(add_On2_Name);
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Logger.WriteDebugMessage("Menu Added Successfully");

                //Re-order added Add ons
                PropertyAdmin.Click_MyMenu_EditButton(menuName);
                Helper.ExitFrame();
                PropertyAdmin.Click_AddOnMoveDown_Button();
                Logger.WriteDebugMessage("Clicked on 'Add On Move Down' button");
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_AddNewMenu_BottomSaveButton());
                PropertyAdmin.Click_AddNewMenu_BottomSaveButton();
                Helper.EnterFrame("frontendEditorIframe");
                Helper.ElementWait(PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu(), 60);
                string addOnText = PageObject_PropertyAdmin.Get_AddOn1_Text(menuName).GetAttribute("innerHTML");
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                if (addOnText.Equals(add_On1_Name))
                    Logger.WriteDebugMessage("Reordering of add-on items saved successfully");
                else
                    Assert.Fail("Reordering of add-on items did not saved");

                // Delete added Menu
                //Helper.EnterFrame("frontendEditorIframe");
                Helper.HoverOverText(menuName);
                PropertyAdmin.Click_MyMenu_DeleteMenu(menuName);
                ExitFrame();
                PropertyAdmin.Click_MyMenu_DeleteMenu_Confirm();
                Logger.WriteDebugMessage("Menu deleted successfully");
                

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Description", menuDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On Tile", add_On_Title);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 1 Name", add_On1_Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Add On 2 Name", add_On2_Name, true);
            }
        }

        public static void D_260067()
        {
            if (TestCaseId == Utility.Constants.D_260067)
            {
                //Pre-requisites
                string propertyAdmin_Username, password, propertyName, menuName, menuDescription, choiceName, option1Name, option2Name, validationMessage;

                //Retrieve data from test data
                Random radNum = new Random();
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                menuName = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "MenuName"), radNum.Next().ToString());
                menuDescription = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");
                choiceName = TestData.ExcelData.TestDataReader.ReadData(1, "ChoiceName");
                option1Name = TestData.ExcelData.TestDataReader.ReadData(1, "Option1Name");
                option2Name = TestData.ExcelData.TestDataReader.ReadData(1, "Option2Name");
                validationMessage = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage");

                //Login to Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.NavigatetoProperty(propertyName);

                //Navigate to Menu
                Helper.EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyMenu_BreakfastDropdown();
                Logger.WriteDebugMessage("Breakfast drop-down should get clicked");
                PropertyAdmin.MyMenu_BreakfastDropdown_ContinentalBreakfast();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_MyMenu_AddNewMenu());
                Logger.WriteDebugMessage("Navigated to Menu Page");

                //Add Menu name
                PropertyAdmin.Click_MyMenu_AddNewMenu();
                Logger.WriteDebugMessage("Add new menu modal should get displayed");
                Helper.ExitFrame();
                PropertyAdmin.AddNewMenu_MenuName(menuName);
                Helper.EnterFrame("cdescription_ifr");
                PropertyAdmin.AddNewMenu_AddChoice_Description("cdescription", menuDescription);
                Logger.WriteDebugMessage("Name and description should get added");
                Helper.ExitFrame();

                //Add First Choice
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_AddNewMenu_AddChoiceButton());
                PropertyAdmin.Click_AddNewMenu_AddChoiceButton();
                PropertyAdmin.AddNewMenu_AddChoice_Name(choiceName);
                string desId = PropertyAdmin.GetFrameId("2");
                Logger.WriteDebugMessage("Name should get added");

                //Add First and Second Options
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_AddNewMenu_NewOptionButton());
                PropertyAdmin.Click_AddNewMenu_NewOptionButton();
                desId = PropertyAdmin.GetFrameId("3");
                Helper.EnterFrame(desId);
                PropertyAdmin.AddNewMenu_AddChoice_Option(desId.Substring(0, 16), option1Name);
                Helper.ExitFrame();
                Logger.WriteDebugMessage(option1Name + "- Name of First choice Option");

                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_AddNewMenu_NewOptionButton2());
                PropertyAdmin.Click_AddNewMenu_NewOptionButton2();
                desId = PropertyAdmin.GetFrameId("4");
                Helper.EnterFrame(desId);
                PropertyAdmin.AddNewMenu_AddChoice_Option(desId.Substring(0, 16), option2Name);
                Helper.ExitFrame();
                Logger.WriteDebugMessage(option2Name + "- Name of Second choice Option");
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_AddNewMenu_BottomSaveButton());
                PropertyAdmin.Click_AddNewMenu_BottomSaveButton();
                Logger.WriteDebugMessage("Saved successfully");

                // Delete one option and validate error message
                Helper.EnterFrame("frontendEditorIframe");
                Helper.DynamicScrollToText(Helper.Driver, menuName);
                Helper.HoverOverText(menuName);
                Logger.WriteDebugMessage(menuName + "Hover over menu item");
                PropertyAdmin.Click_EditMenu_Button(menuName);
                ExitFrame();
                ScrollToElement(PageObject_PropertyAdmin.Click_Option_DeleteButton());
                PropertyAdmin.Click_Option_DeleteButton();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_AddNewMenu_BottomSaveButton());
                PropertyAdmin.Click_AddNewMenu_BottomSaveButton();
                VerifyTextOnPageAndHighLight(validationMessage);
                Logger.WriteDebugMessage(validationMessage + " - Error message should get displayed");
                PropertyAdmin.Click_AddNewMenu_CancelButton();

                //ElementWait(PageObject_PropertyAdmin.Click_MyMenu_DeleteMenu(menuName), 20);

                // Delete added Menu
                Helper.EnterFrame("frontendEditorIframe");
                Helper.HoverOverText(menuName);
                PropertyAdmin.Click_MyMenu_DeleteMenu(menuName);
                ExitFrame();
                PropertyAdmin.Click_MyMenu_DeleteMenu_Confirm();
                Logger.WriteDebugMessage("Menu deleted successfully");


                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property Name", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", menuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Description Name", menuDescription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_First Choice Name", choiceName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_First Option Name", option1Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Second Option Name", option2Name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Validation Message", validationMessage, true);
            }
        }





    }

}
