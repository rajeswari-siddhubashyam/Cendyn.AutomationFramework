using BaseUtility.Utility;
using eMenus.AppModule.Admin;
using eMenus.AppModule.UI;
using eMenus.Entity;
using eMenus.PageObject.Admin;
using InfoMessageLogger;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestData;
using Queries = eMenus.Utility.Queries;

namespace eMenus.AppModule.MainAdminApp
{
    public partial class MainAdminApp : eMenus.Utility.Setup
    {
        // This test case will validate user is able to search with content from item title.
        public static void TC_232759()
        {
            if (TestCaseId == Utility.Constants.TC_232759)
            {
                //Pre-Requisites
                string propertyAdmin_Username, password, propertyName, sub_MenuName, title, description, verificationText;
                Random no = new Random();
                //Retrieve data from TestData File
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                sub_MenuName = TestData.ExcelData.TestDataReader.ReadData(1, "Sub_MenuName");
                title = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Title"), no.Next().ToString());
                description = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");
                verificationText = TestData.ExcelData.TestDataReader.ReadData(1, "VerificationText");

                //Login to Property Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.ePlanner_NavigatetoProperty(propertyName);

                //Navigate to Specific Menu
                EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);

                //Add New Item
                PropertyAdmin.AddItem_Title_Description(title, description);

                //Publish the changes
                PropertyAdmin.Publish_Changes();
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();

                //Navigate to Front-end and verify search for Item title
                Logger.WriteDebugMessage("Navigate to Front-end page");
                ePlannerHomePage.Home_SearchBox(title);
                Logger.WriteDebugMessage("Title entered");
                Helper.Keyboard_Enter();
                VerifyTextOnPageAndHighLight(verificationText);
                VerifyTextOnPageAndHighLight(title);
                Logger.WriteDebugMessage("Search successful");

                ePlannerHomePage.Home_SearchBox(title);
                Logger.WriteDebugMessage("Title entered");
                Helper.Keyboard_Enter();
                VerifyTextOnPageAndHighLight(verificationText);
                VerifyTextOnPageAndHighLight(title);
                Logger.WriteDebugMessage("Search successful");

                Helper.CloseCurrentTab();

                //Delete item
                PropertyAdmin.Delete_Item(title);

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_PropertyName", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", "Food & Beverages");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Sub Menu Name", sub_MenuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Title", title);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_MenuDescription", description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_VerficationText", verificationText, true);

            }
        }

        // This test case will validate user is able to search with content from item description.
        public static void TC_232761()
        {
            if (TestCaseId == Utility.Constants.TC_232761)
            {
                //Pre-Requisites
                string propertyAdmin_Username, password, propertyName, sub_MenuName, title, description, verificationText;
                Random no = new Random();
                //Retrieve data from TestData File
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                sub_MenuName = TestData.ExcelData.TestDataReader.ReadData(1, "Sub_MenuName");
                title = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Title"), no.Next().ToString());
                description = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");
                verificationText = TestData.ExcelData.TestDataReader.ReadData(1, "VerificationText");


                //Login to Property Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.ePlanner_NavigatetoProperty(propertyName);

                //Navigate to Specific Menu
                EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);

                //Add New Item
                PropertyAdmin.AddItem_Title_Description(title, description);

                //Publish the changes
                PropertyAdmin.Publish_Changes();
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();

                //Navigate to Front-end and verify search for Item description
                Logger.WriteDebugMessage("Navigate to Front-end page");
                ePlannerHomePage.Home_SearchBox(description);
                Logger.WriteDebugMessage("Item Description entered");
                Helper.Keyboard_Enter();
                VerifyTextOnPageAndHighLight(verificationText);
                VerifyTextOnPageAndHighLight(description);
                Logger.WriteDebugMessage("Search successful");

                ePlannerHomePage.Home_SearchBox(description);
                Logger.WriteDebugMessage("Item Description entered");
                Helper.Keyboard_Enter();
                VerifyTextOnPageAndHighLight(verificationText);
                VerifyTextOnPageAndHighLight(description);
                Logger.WriteDebugMessage("Search successful");


                Helper.CloseCurrentTab();

                //Delete item
                PropertyAdmin.Delete_Item(title);

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_PropertyName", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", "Food & Beverages");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Sub Menu Name", sub_MenuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Title", title);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_MenuDescription", description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_VerficationText", verificationText, true);
            }

        }

        // This test case will validate user is able to search Home page content in letter.
        public static void TC_232763()
        {
            if (TestCaseId == Utility.Constants.TC_232763)
            {
                //Pre-Requisites
                string propertyAdmin_Username, password, propertyName,verificationText, updateContent;
                Random no = new Random();
                //Retrieve data from TestData File
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                verificationText = TestData.ExcelData.TestDataReader.ReadData(1, "VerificationText");
                updateContent = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "UpdateContent"), no.Next().ToString());

                //Login to Property Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.ePlanner_NavigatetoProperty(propertyName);

                //Update Home category content
                EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_MyPlanner_Edit();
                
                Helper.ExitFrame();
                Helper.EnterFrame("HomeLetter_ifr");
                //string content = PageObject_PropertyAdmin.Click_Category_editor().GetAttribute("innerHTML");

                PropertyAdmin.Enter_Category_editor(updateContent);
                Helper.ExitFrame();
                Logger.WriteDebugMessage("Updating Home category content");
                PropertyAdmin.Click_Category_editor_save();
                Logger.WriteDebugMessage("Home category content is updated successfully");

                //Publish the changes
                PropertyAdmin.Publish_Changes();
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();

                //Navigate to Front-end and verify search for Home category content
                Logger.WriteDebugMessage("Navigate to Front-end page");
                ePlannerHomePage.Home_SearchBox(updateContent);
                Logger.WriteDebugMessage("Home letter contain entered");
                Helper.Keyboard_Enter();
                VerifyTextOnPageAndHighLight(verificationText);
                VerifyTextOnPageAndHighLight(updateContent);
                Logger.WriteDebugMessage("Search successful");

                ePlannerHomePage.Home_SearchBox(updateContent);
                Logger.WriteDebugMessage("Home letter contain entered");
                Helper.Keyboard_Enter();
                VerifyTextOnPageAndHighLight(verificationText);
                VerifyTextOnPageAndHighLight(updateContent);

                Helper.CloseCurrentTab();

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_PropertyName", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_VerficationText", verificationText);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_UpdateContent", updateContent, true);
            }
        }

        // This test case will validate when user enter a content with combination of "&#","<>" and "<" then user will get a validation message verbiage as 'You have entered invalid characters such as "&#", "<>". Please re-enter.' 
        public static void TC_232764()
        {
            if (TestCaseId == Utility.Constants.TC_232764)
            {
                //Pre-Requisites
                string searchInput1, searchInput2, validationMessage;
                //Retrieve data from TestData File
                validationMessage = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage");
                searchInput1 = TestData.ExcelData.TestDataReader.ReadData(1, "SearchInput1");
                searchInput2 = TestData.ExcelData.TestDataReader.ReadData(1, "SearchInput2");

               
                //Navigate to Front-end and verify search for first invalid test data
                Driver.Url = "https://1445-qa.eplanneraccess.com/Menu?hid=1445";
                Logger.WriteDebugMessage("Navigate to Front-end page");
                ePlannerHomePage.Home_SearchBox(searchInput1);
                Logger.WriteDebugMessage("Search text entered");
                Helper.Keyboard_Enter();

                VerifyTextOnPageAndHighLight(validationMessage);
                Logger.WriteDebugMessage("Validation message");


                //Clear first test data and verify search for second invalid test data
                ePlannerHomePage.Home_SearcBoxClear();

                ePlannerHomePage.Home_SearchBox(searchInput2);
                Logger.WriteDebugMessage("Search text entered");
                Helper.Keyboard_Enter();

                VerifyTextOnPageAndHighLight(validationMessage);
                Logger.WriteDebugMessage("Validation message");

                //Navigate to Internal search and verify search for first invalid test data
                ePlannerHomePage.Home_SearcBoxClear();
                ePlannerHomePage.Home_SearchBox("Test");
                Helper.Keyboard_Enter();

                ePlannerHomePage.Home_SearchBox(searchInput1);
                Logger.WriteDebugMessage("Search text entered");
                Helper.Keyboard_Enter();
               
                VerifyTextOnPageAndHighLight(validationMessage);
                Logger.WriteDebugMessage("Validation message");

                //Clear first test data and verify search for second invalid test data
                ePlannerHomePage.Home_SearcBoxClear();

                ePlannerHomePage.Home_SearchBox(searchInput2);
                Logger.WriteDebugMessage("Search text entered");
                Helper.Keyboard_Enter();

                VerifyTextOnPageAndHighLight(validationMessage);
                Logger.WriteDebugMessage("Validation message");

                        

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_SearchInput1", searchInput1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_SearchInput2", searchInput2, true);
            }
        }

        //This test case will Validate when user enters less than 4 characters in search field, then user will get a validation message verbiage as 'Your search was too vague. Please be more specific.' 
        public static void TC_232795()
        {
            if (TestCaseId == Utility.Constants.TC_232795)
            {

                //Pre-Requisites
                string searchContent1, searchContent2, validationMessage;
                //Retrieve data from TestData File
                validationMessage = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage");
                searchContent1 = TestData.ExcelData.TestDataReader.ReadData(1, "SearchContent1");
                searchContent2 = TestData.ExcelData.TestDataReader.ReadData(1, "SearchContent2");

                
                //Navigate to Front-end and verify search for first inavalid test data
                Driver.Url = "https://1445-qa.eplanneraccess.com/Menu?hid=1445";
                Logger.WriteDebugMessage("Navigate to Front-end page");
                ePlannerHomePage.Home_SearchBox(searchContent1);
                Logger.WriteDebugMessage("Search text entered");
                Helper.Keyboard_Enter();

                
                VerifyTextOnPageAndHighLight(validationMessage);
                Logger.WriteDebugMessage("Validation message");

                //Clear first test data and verify search for second invalid test data
                ePlannerHomePage.Home_SearcBoxClear();

                ePlannerHomePage.Home_SearchBox(searchContent2);
                Logger.WriteDebugMessage("Search text entered");
                Helper.Keyboard_Enter();

                VerifyTextOnPageAndHighLight(validationMessage);
                Logger.WriteDebugMessage("Validation message");

                //Navigate to Internal search and verify search for first invalid test data
                ePlannerHomePage.Home_SearcBoxClear();
                ePlannerHomePage.Home_SearchBox("Test");
                Helper.Keyboard_Enter();

                ePlannerHomePage.Home_SearchBox(searchContent1);
                Logger.WriteDebugMessage("Search text entered");
                Helper.Keyboard_Enter();

                VerifyTextOnPageAndHighLight(validationMessage);
                Logger.WriteDebugMessage("Validation message");

                //Clear first test data and verify search for second invalid test data
                ePlannerHomePage.Home_SearcBoxClear();

                ePlannerHomePage.Home_SearchBox(searchContent2);
                Logger.WriteDebugMessage("Search text entered");
                Helper.Keyboard_Enter();

                VerifyTextOnPageAndHighLight(validationMessage);
                Logger.WriteDebugMessage("Validation message");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_SearchInput1", searchContent1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_SearchInput2", searchContent2, true);
            }
        }

        // This test case will validate that search result is not displayed when user search with category description and disclaimer' 
        public static void TC_232975()
        {
            if (TestCaseId == Utility.Constants.TC_232975)
            {
                //Pre-Requisites
                string propertyAdmin_Username, password, propertyName, sub_MenuName, disclaimer, verificationText, categoryDecsription;
                Random ranno = new Random();
                //Retrieve data from TestData File
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                sub_MenuName = TestData.ExcelData.TestDataReader.ReadData(1, "Sub_MenuName");
                disclaimer = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Disclaimer"), ranno.Next().ToString());
                verificationText = TestData.ExcelData.TestDataReader.ReadData(1, "VerificationText");
                categoryDecsription = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "CategoryDecsription"), ranno.Next().ToString());

                //Login to Property Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.ePlanner_NavigatetoProperty(propertyName);

                //Navigate to Specific Menu
                EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);

                //Add Category description and declaimer 
                PropertyAdmin.Click_Category_Decsription();
                ExitFrame();
                EnterFrame("description_ifr");
                Logger.WriteDebugMessage("Clicked on Category description edit button");
                PropertyAdmin.Enter_Category_Description(categoryDecsription);
                Logger.WriteDebugMessage("Category description added");
                ExitFrame();
                PropertyAdmin.Click_CategoryDescription_SaveButton();
                Logger.WriteDebugMessage("Added description saved");

                EnterFrame("frontendEditorIframe");
                ScrollToElement(PageObject_PropertyAdmin.Click_Edit_Desclaimer());
                PropertyAdmin.Click_Edit_Desclaimer();
                Logger.WriteDebugMessage("Clicked on declaimer edit button");
                ExitFrame();
                EnterFrame("disclaimer_ifr");
                PropertyAdmin.Enter_Desclaimer_Description(disclaimer);
                Logger.WriteDebugMessage("Disclaimer description added");
                ExitFrame();
                PropertyAdmin.Click_Desclaimer_SaveButton();
                Logger.WriteDebugMessage("Clicked on save button");


                //Publish the changes
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end and Verify description and declaimer displaying on the page or not
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigate to Front-end page");

                // Check on Home category
                ePlannerHomePage.Home_SearchBox(categoryDecsription);
                Logger.WriteDebugMessage("Category Description entered");
                Helper.Keyboard_Enter();
                VerifyTextOnPageAndHighLight("0 result found");
                Logger.WriteDebugMessage(categoryDecsription + "- Not displaying on the page");
                PropertyAdmin.Click_Fronend_HomeCategory();

                ePlannerHomePage.Home_SearchBox(disclaimer);
                Logger.WriteDebugMessage("Disclaimer entered");
                Helper.Keyboard_Enter();
                VerifyTextOnPageAndHighLight("0 result found");
                Logger.WriteDebugMessage(disclaimer + "- Not displaying on the page");

                // Check on Food and Beverages category
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);

                ePlannerHomePage.Home_SearchBox(categoryDecsription);
                Logger.WriteDebugMessage("Category Description entered");
                Helper.Keyboard_Enter();
                VerifyTextOnPageAndHighLight(verificationText);
                Logger.WriteDebugMessage(categoryDecsription + "- Not displaying on the page");

                ePlannerHomePage.Home_SearchBox(disclaimer);
                Logger.WriteDebugMessage("Disclaimer entered");
                Helper.Keyboard_Enter();
                VerifyTextOnPageAndHighLight(verificationText);
                Logger.WriteDebugMessage(disclaimer + "- Not displaying on the page");
                Helper.CloseCurrentTab();



                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_PropertyName", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", "Food & Beverages");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Sub Menu Name", sub_MenuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_CategoryDescription", categoryDecsription);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Desclaimer", disclaimer, true);
            }
        }
        public static void TC_232765()
        {
            if (TestCaseId == Utility.Constants.TC_232765)
            {
                Users data = new Users();
                
                //Pre-Requisites
                string propertyAdmin_Username, password, propertyName, cendynUrl, sub_MenuName, homeLetter, homeNoLetter, manager_Name, name;

                //Query
                Queries.GetActiveManagerContact(data);

                               
                //Retrieve data from TestData File
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                cendynUrl = TestData.ExcelData.TestDataReader.ReadData(1, "CendynUrl");
                sub_MenuName = TestData.ExcelData.TestDataReader.ReadData(1, "Sub_MenuName");
                homeLetter = TestData.ExcelData.TestDataReader.ReadData(1, "HomeLetter");
                homeNoLetter = TestData.ExcelData.TestDataReader.ReadData(1, "HomeNoLetter");
                manager_Name = TestData.ExcelData.TestDataReader.ReadData(1, "Manager_Name");

                //Login to Property Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.ePlanner_NavigatetoProperty(propertyName);

                //Navigate to property admin
                Helper.OpenNewTab();
                Helper.ControlToNewWindow();
                Helper.Driver.Url = cendynUrl;
                Logger.WriteDebugMessage("Landed on Cendyn admin page");


                //Select Property for cendyn admin
                CendynAdmin.ePlanner_NavigatetoProperty_CendynAdmin(propertyName);

                // Set category type as Regular
                CendynAdmin.Supplier_Tab();
                Logger.WriteDebugMessage("Clicked on Supplier tab");
                CendynAdmin.Click_category();
                Logger.WriteDebugMessage("Clicked on Category tab");
                CendynAdmin.Click_Supplier_Category_InformationEdit();
                PageDown();
                CendynAdmin.Click_EditCategory_SaveButton();
                Logger.WriteDebugMessage("Clicked on Information edit and category type selected as Regular");

                //Navigate to Information category on property admin
                ControlToPreviousWindow();
                ReloadPage();
                EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_Category_Information();
                Logger.WriteDebugMessage("Clicked on Information category on property admin");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);
                Logger.WriteDebugMessage("Clicked on Information sub-category on property admin");
                PageDown();
                PageDown();
                //name = PageObject_PropertyAdmin.ManagerProfile_Name().GetAttribute("innerHTML");
                if (Helper.VerifyTextNOTOnPage(data.name))
                    Logger.WriteDebugMessage("Manager name not displaying on the page for Category type as Home No Letter");
                else
                    Assert.Fail("Manager name displaying on the page for Category type as Home No Letter");

                // Set category type as Home No Letter
                ControlToNextWindow();
                CendynAdmin.Supplier_Tab();
                Logger.WriteDebugMessage("Clicked on Supplier tab");
                CendynAdmin.Click_category();
                Logger.WriteDebugMessage("Clicked on Category tab");
                CendynAdmin.Click_Supplier_Category_HomeEdit();
                PageDown();
                CendynAdmin.Select_CategoryType_Dropdown(homeNoLetter);
                CendynAdmin.Click_EditCategory_SaveButton();
                Logger.WriteDebugMessage("Clicked on Home edit and category type selected as Home No Letter");

                //Navigate to Home category on property admin
                ControlToPreviousWindow();
                ReloadPage();
                EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_Category_Home();
                PageDown();
                Logger.WriteDebugMessage("Clicked on Home category on property admin");
                //name = PageObject_PropertyAdmin.ManagerProfile_Name().GetAttribute("innerHTML");
                //if (name.Equals(manager_Name))
                if (Helper.VerifyTextNOTOnPage(data.name))
                    Logger.WriteDebugMessage("Manager name not displaying on the page for Category type as Home No Letter");
                else
                    Assert.Fail("Manager name displaying on the page for Category type as Home No Letter");


                // Set category type as Home letter
                ControlToNextWindow();
                CendynAdmin.Supplier_Tab();
                Logger.WriteDebugMessage("Clicked on Supplier tab");
                CendynAdmin.Click_category();
                Logger.WriteDebugMessage("Clicked on Category tab");
                CendynAdmin.Click_Supplier_Category_HomeEdit();
                PageDown();
                CendynAdmin.Select_CategoryType_Dropdown(homeLetter);
                CendynAdmin.Click_EditCategory_SaveButton();
                Logger.WriteDebugMessage("Clicked on Home edit and category type selected as Home Letter");

                //Navigate to Home category on property admin
                ControlToPreviousWindow();
                ReloadPage();
                EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_Category_Home();
                PageDown();
                Logger.WriteDebugMessage("Clicked on Home category on property admin");
                name = PageObject_PropertyAdmin.ManagerProfile_Name().GetAttribute("innerHTML");
                if (name.Equals(data.name))
                    Logger.WriteDebugMessage("Manager name displayed on the page for Category type as Home Letter");
                else
                    Assert.Fail("Manager name not displaying on the page for Category type as Home Letter");


                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_PropertyName", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Category Name", "Home");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Category Name2", "Information");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Sub Menu Name", sub_MenuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Category Type 1", "Regular");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Category Type 2", homeNoLetter);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Category Type 3", homeLetter);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Manager Name", manager_Name, true);
            }
        }
    }
}