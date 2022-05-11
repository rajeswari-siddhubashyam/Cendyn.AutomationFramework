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
        public static void TC_232780()
        {
            if (TestCaseId == Utility.Constants.TC_232780)
            {
                //Pre-Requisites
                string propertyAdmin_Username, password, propertyName, sub_MenuName, title, description;
                Random no = new Random();
                //Retrieve data from TestData File
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                sub_MenuName = TestData.ExcelData.TestDataReader.ReadData(1, "Sub_MenuName");
                title = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Title"), no.Next().ToString());
                description = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");

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

                //Navigate to Preview page and Verify the Added Item
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);
                VerifyTextOnPageAndHighLight(title);
                DynamicScrollToText(Helper.Driver, title);
                Logger.WriteDebugMessage("Added Item got Displayed on the Preview Page");
                Helper.CloseCurrentTab();

                //Publish the changes
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end and Verify the Added Item on the Front-end
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigate to Front-end page");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);
                VerifyTextOnPageAndHighLight(title);
                DynamicScrollToText(Helper.Driver, title);
                Logger.WriteDebugMessage("Added Item got Displayed on the Front-end Page");
                Helper.CloseCurrentTab();

                //Delete the added Item from Property Admin
                PropertyAdmin.Delete_Item(title);

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_PropertyName", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", "Food & Beverages");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Sub Menu Name", sub_MenuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Title", title);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_MenuDescription", description, true);


            }
        }
        public static void TC_232781()
        {
            if (TestCaseId == Utility.Constants.TC_232781)
            {
                //Pre-Requisites
                string propertyAdmin_Username, password, propertyName, sub_MenuName, title, description;
                Random no = new Random();
                //Retrieve data from TestData File
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                sub_MenuName = TestData.ExcelData.TestDataReader.ReadData(1, "Sub_MenuName");
                title = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Title"), no.Next().ToString());
                description = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");

                //Login to Property Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.ePlanner_NavigatetoProperty(propertyName);

                //Navigate to Specific Menu
                EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);

                //Add New Item with Image 
                PropertyAdmin.AddItem_Image_eGallery(title, description);

                //Navigate to Preview page and Verify the Added Item
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);
                VerifyTextOnPageAndHighLight(title);
                DynamicScrollToText(Helper.Driver, title);
                Logger.WriteDebugMessage("Added Item got Displayed on the Preview Page");
                if (PageObject_PropertyAdmin.Click_Item_Image(title).Displayed)
                {
                    PropertyAdmin.Click_Item_Image(title);
                    Logger.WriteDebugMessage("Image from eGallery got displayed on Preview page");
                }
                else
                    Assert.Fail("Image from eGallery is not getting displayed on Preview page");
                Helper.CloseCurrentTab();

                //Publish the changes
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end and Verify the Added Item on the Front-end
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigate to Front-end page");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);
                VerifyTextOnPageAndHighLight(title);
                DynamicScrollToText(Helper.Driver, title);
                Logger.WriteDebugMessage("Added Item got Displayed on the Front-end Page");
                if (PageObject_PropertyAdmin.Click_Item_Image(title).Displayed)
                {
                    PropertyAdmin.Click_Item_Image(title);
                    Logger.WriteDebugMessage("Image from eGallery got displayed on Preview page");
                }
                else
                    Assert.Fail("Image from eGallery is not getting displayed on Preview page");
                Helper.CloseCurrentTab();


                //Delete the added Item from Property Admin
                PropertyAdmin.Delete_Item(title);

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_PropertyName", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", "Food & Beverages");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Sub Menu Name", sub_MenuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Title", title);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_MenuDescription", description, true);


            }
        }
        public static void TC_232782()
        {
            if (TestCaseId == Utility.Constants.TC_232782)
            {
                //Pre-Requisites
                string propertyAdmin_Username, password, propertyName, sub_MenuName, title, description, imagePath;
                Random no = new Random();
                //Retrieve data from TestData File
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                sub_MenuName = TestData.ExcelData.TestDataReader.ReadData(1, "Sub_MenuName");
                title = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Title"), no.Next().ToString());
                description = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");
                imagePath = String.Concat(ProjectPath, TestData.ExcelData.TestDataReader.ReadData(1, "ImagePath"));

                //Login to Property Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.ePlanner_NavigatetoProperty(propertyName);

                //Navigate to Specific Menu
                EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);

                //Add New Item with Image 
                PropertyAdmin.AddItem_Image_Upload(title, description, imagePath);

                //Navigate to Preview page and Verify the Added Item
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);
                VerifyTextOnPageAndHighLight(title);
                DynamicScrollToText(Helper.Driver, title);
                Logger.WriteDebugMessage("Added Item got Displayed on the Preview Page");
                if (PageObject_PropertyAdmin.Click_Item_Image(title).Displayed)
                {
                    PropertyAdmin.Click_Item_Image(title);
                    Logger.WriteDebugMessage("Image from local drive got displayed on Preview page");
                }
                else
                    Assert.Fail("Image from local drive is not getting displayed on Preview page");
                Helper.CloseCurrentTab();

                //Publish the changes
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end and Verify the Added Item on the Front-end
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigate to Front-end page");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);
                VerifyTextOnPageAndHighLight(title);
                DynamicScrollToText(Helper.Driver, title);
                Logger.WriteDebugMessage("Added Item got Displayed on the Front-end Page");
                if (PageObject_PropertyAdmin.Click_Item_Image(title).Displayed)
                {
                    PropertyAdmin.Click_Item_Image(title);
                    Logger.WriteDebugMessage("Image from local drive got displayed on Preview page");
                }
                else
                    Assert.Fail("Image from eGallery is not local drive displayed on Preview page");
                Helper.CloseCurrentTab();


                //Delete the added Item from Property Admin
                PropertyAdmin.Delete_Item(title);

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_PropertyName", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", "Food & Beverages");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Sub Menu Name", sub_MenuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Title", title);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_MenuDescription", description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_ImagePath", imagePath, true);


            }
        }
        public static void TC_232783()
        {
            if (TestCaseId == Utility.Constants.TC_232783)
            {
                //Pre-Requisites
                string propertyAdmin_Username, password, propertyName, sub_MenuName, title, description, imagePath;
                Random no = new Random();
                //Retrieve data from TestData File
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                sub_MenuName = TestData.ExcelData.TestDataReader.ReadData(1, "Sub_MenuName");
                title = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Title"), no.Next().ToString());
                description = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");
                imagePath = String.Concat(ProjectPath, TestData.ExcelData.TestDataReader.ReadData(1, "ImagePath"));

                //Login to Property Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.ePlanner_NavigatetoProperty(propertyName);

                //Navigate to Specific Menu
                EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);

                //Add New Item with Image 
                PropertyAdmin.AddItem_File_Upload(title, description, imagePath);

                //Navigate to Preview page and Verify the Added Item
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);
                VerifyTextOnPageAndHighLight(title);
                DynamicScrollToText(Helper.Driver, title);
                Logger.WriteDebugMessage("Added Item got Displayed on the Preview Page");
                if (PageObject_PropertyAdmin.Click_Image_File().Displayed)
                {
                    PropertyAdmin.Click_Image_File();
                    ControlToNextWindow();
                    Logger.WriteDebugMessage("File from local drive got displayed on Preview page");
                    CloseCurrentTab();
                    ControlToNextWindow();
                }
                else
                    Assert.Fail("File from local drive is not getting displayed on Preview page");
                Helper.CloseCurrentTab();

                //Publish the changes
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end and Verify the Added Item on the Front-end
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigate to Front-end page");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);
                VerifyTextOnPageAndHighLight(title);
                DynamicScrollToText(Helper.Driver, title);
                Logger.WriteDebugMessage("Added Item got Displayed on the Front-end Page");
                if (PageObject_PropertyAdmin.Click_Image_File().Displayed)
                {
                    PropertyAdmin.Click_Image_File();
                    ControlToNextWindow();
                    Logger.WriteDebugMessage("File from local drive got displayed on Front-end page");
                    CloseCurrentTab();
                    ControlToNextWindow();
                }
                else
                    Assert.Fail("File from local drive is not getting displayed on Front-end page");
                Helper.CloseCurrentTab();


                //Delete the added Item from Property Admin
                PropertyAdmin.Delete_Item(title);

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_PropertyName", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", "Food & Beverages");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Sub Menu Name", sub_MenuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Title", title);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_MenuDescription", description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_FilePath", imagePath, true);


            }
        }
        public static void TC_232921()
        {
            if (TestCaseId == Utility.Constants.TC_232921)
            {
                //Pre-Requisites
                string propertyAdmin_Username, password, propertyName, sub_MenuName, title, description, edit = "_Edit", imagePath;
                Random no = new Random();

                //Retrieve data from TestData File
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                sub_MenuName = TestData.ExcelData.TestDataReader.ReadData(1, "Sub_MenuName");
                title = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Title"), no.Next().ToString());
                description = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");
                imagePath = String.Concat(ProjectPath, TestData.ExcelData.TestDataReader.ReadData(1, "ImagePath"));

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

                //Edit added item and click on cancel button
                Helper.EnterFrame("frontendEditorIframe");
                HoverOverText(title);
                PropertyAdmin.Click_Menu_EditButton();
                Helper.ExitFrame();
                Logger.WriteDebugMessage("Edit Item Overlay got Opened");
                PropertyAdmin.Enter_Text_Title(title + edit);
                Helper.EnterFrame("cdescription_ifr");
                PropertyAdmin.AddNewMenu_AddChoice_Description("cdescription", description + edit);
                Helper.ExitFrame();
                Logger.WriteDebugMessage("Edited Title and Description");
                PropertyAdmin.Click_AddItem_CancelButton();
                Logger.WriteDebugMessage("Canceled Editing the Item Details");
                Helper.EnterFrame("frontendEditorIframe");
                VerifyTextOnPageAndHighLight(title);
                VerifyTextOnPageAndHighLight(description);
                Logger.WriteDebugMessage(title + " and " + description + "-  values are not edited on the page after cancel the Edit");
                Helper.ExitFrame();

                //Edit added item and click on Save button
                Helper.EnterFrame("frontendEditorIframe");
                HoverOverText(title);
                PropertyAdmin.Click_Menu_EditButton();
                Helper.ExitFrame();
                Logger.WriteDebugMessage("Edit Item Overlay got Opened");
                PropertyAdmin.Enter_Text_Title(title + edit);
                Helper.EnterFrame("cdescription_ifr");
                PropertyAdmin.AddNewMenu_AddChoice_Description("cdescription", description + edit);
                Helper.ExitFrame();
                Logger.WriteDebugMessage("Title and Description are Edited");
                PropertyAdmin.Click_Button_Save();
                Helper.EnterFrame("frontendEditorIframe");
                VerifyTextOnPageAndHighLight(title + edit);
                VerifyTextOnPageAndHighLight(description + edit);
                Logger.WriteDebugMessage(title + edit + " and " + description + edit + "- Edited fields are displayed on the page");

                //Edit with Adding Gallery Image
                HoverOverText(title + edit);
                PropertyAdmin.Click_Menu_EditButton();
                Helper.ExitFrame();
                Logger.WriteDebugMessage("Edit Item Overlay got Opened");
                PropertyAdmin.Click_Button_UploadFromeGallery();
                Helper.ControlToNextWindow();
                Logger.WriteDebugMessage("Landed on eGallery");
                PropertyAdmin.Click_Image_eGallery();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Button_SelectImage());
                Logger.WriteDebugMessage("Image got Selected from eGallery");
                PropertyAdmin.Click_Button_SelectImage();
                Helper.ControlToPreviousWindow();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Button_UploadFromeGallery());
                Logger.WriteDebugMessage("Image got Successfully Updated in Add Item Overlay");
                PropertyAdmin.Click_Button_Save();

                //Edit by Uploading Image/file
                Helper.EnterFrame("frontendEditorIframe");
                HoverOverText(title + edit);
                PropertyAdmin.Click_Menu_EditButton();
                Helper.ExitFrame();
                Logger.WriteDebugMessage("Edit Item Overlay got Opened");
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Upload_Image());
                PropertyAdmin.Click_Select_File();
                PropertyAdmin.UploadImage(imagePath);
                Logger.WriteDebugMessage("File got Selected Successfully");
                PropertyAdmin.Click_Upload_File();
                Helper.DynamicScroll(Helper.Driver, PageObject_PropertyAdmin.Click_Button_UploadFromeGallery());
                Logger.WriteDebugMessage("Image Uploaded Successfully");
                PropertyAdmin.Click_Button_Save();

                //Verify the Changes on Preview Mode
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);
                VerifyTextOnPageAndHighLight(title + edit);
                DynamicScrollToText(Helper.Driver, title + edit);
                Logger.WriteDebugMessage("Added Item got Displayed on the Preview Page");
                if (PageObject_PropertyAdmin.Click_Item_Image(title + edit).Displayed)
                {
                    PropertyAdmin.Click_Item_Image(title + edit);
                    Logger.WriteDebugMessage("Image from local drive got displayed on Preview page");
                }
                else
                    Assert.Fail("Image from eGallery is not local drive displayed on Preview page");

                if (PageObject_PropertyAdmin.Click_Image_File().Displayed)
                {
                    PropertyAdmin.Click_Image_File();
                    ControlToNextWindow();
                    Logger.WriteDebugMessage("File from local drive got displayed on Preview page");
                    CloseCurrentTab();
                    ControlToNextWindow();
                }
                else
                    Assert.Fail("File from local drive is not getting displayed on Preview page");
                Helper.CloseCurrentTab();

                //Publish the changes
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end and Verify the Added Item on the Front-end
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigate to Front-end page");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);
                VerifyTextOnPageAndHighLight(title + edit);
                DynamicScrollToText(Helper.Driver, title + edit);
                Logger.WriteDebugMessage("Added Item got Displayed on the Front-end Page");
                if (PageObject_PropertyAdmin.Click_Item_Image(title + edit).Displayed)
                {
                    PropertyAdmin.Click_Item_Image(title + edit);
                    Logger.WriteDebugMessage("Image from local drive got displayed on Preview page");
                }
                else
                    Assert.Fail("Image from eGallery is not local drive displayed on Preview page");

                if (PageObject_PropertyAdmin.Click_Image_File().Displayed)
                {
                    PropertyAdmin.Click_Image_File();
                    ControlToNextWindow();
                    Logger.WriteDebugMessage("File from local drive got displayed on Front-end page");
                    CloseCurrentTab();
                    ControlToNextWindow();
                }
                else
                    Assert.Fail("File from local drive is not getting displayed on Front-end page");
                Helper.CloseCurrentTab();

                //Delete the added Item from Property Admin
                PropertyAdmin.Delete_Item(title + edit);

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_PropertyName", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", "Food & Beverages");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Sub Menu Name", sub_MenuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Title", title);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_MenuDescription", description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_FilePath", imagePath, true);
            }
        }
        public static void TC_232922()
        {
            if (TestCaseId == Utility.Constants.TC_232922)
            {
                //Pre-Requisites
                string propertyAdmin_Username, password, propertyName, sub_MenuName, title, description;
                Random no = new Random();
                //Retrieve data from TestData File
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                sub_MenuName = TestData.ExcelData.TestDataReader.ReadData(1, "Sub_MenuName");
                title = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Title"), no.Next().ToString());
                description = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");

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

                //Delete the added Item from Property Admin and Click on cancel button
                Helper.EnterFrame("frontendEditorIframe");
                Helper.DynamicScrollToText(Helper.Driver, title);
                Logger.WriteDebugMessage("Added Menu got displayed");
                Helper.HoverOverText(title);
                PropertyAdmin.Click_Icon_Delete();
                Logger.WriteDebugMessage("Clicked on Delete Icon for Item = " + title);
                Helper.ExitFrame();
                PropertyAdmin.Click_Item_Delete_Cancel();
                Helper.EnterFrame("frontendEditorIframe");
                if (Helper.IsElementRemoved(title))
                    Logger.WriteDebugMessage("Title = " + title + " is not get deleted and Present on the Property Admin");
                else
                    Assert.Fail("Title = " + title + " got deleted successfully after clicking on Cancel button on Delete Overlay");
                Helper.ExitFrame();


                //Delete the added Item from Property Admin
                Helper.EnterFrame("frontendEditorIframe");
                Helper.DynamicScrollToText(Helper.Driver, title);
                Logger.WriteDebugMessage("Added Menu got displayed");
                Helper.HoverOverText(title);
                PropertyAdmin.Click_Icon_Delete();
                Logger.WriteDebugMessage("Clicked on Delete Icon for Item = " + title);
                Helper.ExitFrame();
                PropertyAdmin.Click_Button_Delete();
                Helper.EnterFrame("frontendEditorIframe");
                if (Helper.IsElementRemoved(title))
                    Assert.Fail("Title = " + title + " is not got deleted");
                else
                    Logger.WriteDebugMessage("Title = " + title + " got deleted successfully");
                Helper.ExitFrame();

                //Navigate to Preview page and Verify item deleted or not
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);
                if (IsElementRemoved(title))
                    Assert.Fail(title + "- Title displaying on the page");
                else
                    Logger.WriteDebugMessage(title + "- Title not displaying on the page");
                Helper.CloseCurrentTab();

                //Publish the changes
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end and Verify item deleted or not on the Front-end
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigate to Front-end page");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);
                if (IsElementRemoved(title))
                    Assert.Fail(title + "- Title displaying on the page");
                else
                    Logger.WriteDebugMessage(title + "- Title not displaying on the page");
                Helper.CloseCurrentTab();

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_PropertyName", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", "Food & Beverages");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Sub Menu Name", sub_MenuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Title", title);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_MenuDescription", description, true);
            }
        }
        public static void TC_232784()
        {
            if (TestCaseId == Utility.Constants.TC_232784)
            {
                //Pre-Requisites
                string propertyAdmin_Username, password, propertyName, sub_MenuName, title, description;
                Random no = new Random();
                //Retrieve data from TestData File
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                sub_MenuName = TestData.ExcelData.TestDataReader.ReadData(1, "Sub_MenuName");
                title = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Title"), no.Next().ToString());
                description = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");

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

                //Navigate to Preview page and Verify item added or not
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);
                VerifyTextOnPageAndHighLight(title);
                DynamicScrollToText(Helper.Driver, title);
                Logger.WriteDebugMessage("Added Item got Displayed on the Preview Page");
                Helper.CloseCurrentTab();

                //Navigate to Front-end and Verify item added or not without publishing item
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigate to Front-end page");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);
                if (IsElementRemoved(title))
                    Assert.Fail(title + "- Title displayed on the page without publishing item");
                else
                    Logger.WriteDebugMessage(title + "- Title should not displayed on the page without publishing item");
                Helper.CloseCurrentTab();

                //Delete the added Item from Property Admin
                PropertyAdmin.Delete_Item(title);

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_PropertyName", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", "Food & Beverages");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Sub Menu Name", sub_MenuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Title", title);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_MenuDescription", description, true);
            }
        }
        public static void TC_232785()
        {
            if (TestCaseId == Utility.Constants.TC_232785)
            {
                //Pre-Requisites
                string propertyAdmin_Username, password, propertyName, sub_MenuName, title, description;
                Random no = new Random();
                //Retrieve data from TestData File
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                sub_MenuName = TestData.ExcelData.TestDataReader.ReadData(1, "Sub_MenuName");
                title = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Title"), no.Next().ToString());
                description = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription");

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

                //Navigate to Preview page and Verify item added or not
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);
                VerifyTextOnPageAndHighLight(title);
                DynamicScrollToText(Helper.Driver, title);
                Logger.WriteDebugMessage("Added Item got Displayed on the Preview Page");
                Helper.CloseCurrentTab();

                //Verify Item should not displayed in published view without publish
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigate to Front-end page");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);
                if (IsElementRemoved(title))
                    Assert.Fail(title + "- Title displayed on the page without publishing item");
                else
                    Logger.WriteDebugMessage(title + "- Title should not displayed on the page without publishing item");
                Helper.CloseCurrentTab();

                //Publish the changes
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end and Verify item displayed on the Front-end
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigate to Front-end page");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);
                VerifyTextOnPageAndHighLight(title);
                DynamicScrollToText(Helper.Driver, title);
                Logger.WriteDebugMessage("Added Item got Displayed on the Front end");
                Helper.CloseCurrentTab();

                //Delete the added Item from Property Admin
                PropertyAdmin.Delete_Item(title);

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_PropertyName", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", "Food & Beverages");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Sub Menu Name", sub_MenuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Title", title);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_MenuDescription", description, true);
            }
        }
        public static void TC_232923()
        {
            if (TestCaseId == Utility.Constants.TC_232923)
            {
                //Pre-Requisites
                string propertyAdmin_Username, password, propertyName, sub_MenuName, title1, title2, description1, description2;
                Random no = new Random();
                //Retrieve data from TestData File
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                sub_MenuName = TestData.ExcelData.TestDataReader.ReadData(1, "Sub_MenuName");
                title1 = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Title1"), no.Next().ToString());
                description1 = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription1");
                title2 = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Title2"), no.Next().ToString());
                description2 = TestData.ExcelData.TestDataReader.ReadData(1, "MenuDescription2");

                //Login to Property Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.ePlanner_NavigatetoProperty(propertyName);

                //Navigate to Specific Menu
                EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);

                //Add First Item
                PropertyAdmin.AddItem_Title_Description(title1, description1);

                //Add Second Item  
                EnterFrame("frontendEditorIframe");
                PropertyAdmin.AddItem_Title_Description(title2, description2);


                //Move the Top Item down and Verify On Property Admin Page
                EnterFrame("frontendEditorIframe");
                Helper.HoverOverText(title2);
                PropertyAdmin.Click_Menu_Item_Down();
                AddDelay(5000);
                if (PropertyAdmin.Get_First_Item_Title_PA().Contains(title1) && PropertyAdmin.Get_Second_Item_Title_PA().Contains(title2))
                    Logger.WriteDebugMessage("Item = " + title2 + " got moved to down and Item = " + title1 + " got moved Up on Property Admin Page");

                else
                    Assert.Fail("Item = " + title2 + " not get moved to down and Item = " + title1 + " not get moved Up on Property Admin Page");
                Helper.ExitFrame();

                //Navigate to Preview mode and Verify the Items on Preview Page
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);
                if (PropertyAdmin.Get_First_Item_Title_PM().Contains(title1) && PropertyAdmin.Get_Second_Item_Title_PM().Contains(title2))
                    Logger.WriteDebugMessage("Item = " + title2 + " got moved to down and Item = " + title1 + " got moved Up on Preview Page");

                else
                    Assert.Fail("Item = " + title2 + " not get moved to down and Item = " + title1 + " not get moved Up on Preview Page");
                Helper.CloseCurrentTab();

                //Publish the changes
                PropertyAdmin.Publish_Changes();

                //Click on Published view and verify the Item on Front-end
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);
                if (PropertyAdmin.Get_First_Item_Title_FE().Contains(title1) && PropertyAdmin.Get_Second_Item_Title_FE().Contains(title2))
                    Logger.WriteDebugMessage("Item = " + title2 + " got moved to down and Item = " + title1 + " got moved Up on Front-end Page");

                else
                    Assert.Fail("Item = " + title2 + " not get moved to down and Item = " + title1 + " not get moved Up on Front-end Page");
                Helper.CloseCurrentTab();

                //Move the bottom Item Up and Verify On Property Admin Page
                EnterFrame("frontendEditorIframe");
                Logger.WriteDebugMessage("Landed on Property Admin Page");
                Helper.HoverOverText(title2);
                PropertyAdmin.Click_Menu_Item_Up();
                AddDelay(5000);
                if (PropertyAdmin.Get_First_Item_Title_PA().Contains(title2) && PropertyAdmin.Get_Second_Item_Title_PA().Contains(title1))
                    Logger.WriteDebugMessage("Item = " + title1 + " got moved to down and Item = " + title2 + " got moved Up on Property Admin Page");

                else
                    Assert.Fail("Item = " + title1 + " not get moved to down and Item = " + title2 + " not get moved Up on Property Admin Page");
                Helper.ExitFrame();

                //Navigate to Preview mode and Verify the Items on Preview Page
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);
                if (PropertyAdmin.Get_First_Item_Title_PM().Contains(title2) && PropertyAdmin.Get_Second_Item_Title_PM().Contains(title1))
                    Logger.WriteDebugMessage("Item = " + title1 + " got moved to down and Item = " + title2 + " got moved Up on Preview Page");

                else
                    Assert.Fail("Item = " + title1 + " not get moved to down and Item = " + title2 + " not get moved Up on Preview Page");
                Helper.CloseCurrentTab();

                //Publish the changes
                PropertyAdmin.Publish_Changes();

                //Click on Published view and verify the Item on Front-end
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);
                if (PropertyAdmin.Get_First_Item_Title_FE().Contains(title2) && PropertyAdmin.Get_Second_Item_Title_FE().Contains(title1))
                    Logger.WriteDebugMessage("Item = " + title1 + " got moved to down and Item = " + title2 + " got moved Up on Front-end Page");

                else
                    Assert.Fail("Item = " + title1 + " not get moved to down and Item = " + title2 + " not get moved Up on Front-end Page");
                Helper.CloseCurrentTab();

                //Delete the added Items
                PropertyAdmin.Delete_Item(title2);
                PropertyAdmin.Delete_Item(title1);

            }
        }
        public static void TC_232925()
        {
            if (TestCaseId == Utility.Constants.TC_232925)
            {
                //Pre-Requisites
                string propertyAdmin_Username, password, propertyName, sub_MenuName, categoryDescription, emptyCategoryDescription = "";
                Random no = new Random();

                //Retrieve data from TestData File
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                sub_MenuName = TestData.ExcelData.TestDataReader.ReadData(1, "Sub_MenuName");
                categoryDescription = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Category_Description"), no.Next().ToString());

                //Login to Property Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.ePlanner_NavigatetoProperty(propertyName);

                //Navigate to Specific Menu
                EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);

                //Edit the Category Description and click on Cancel Button
                Logger.WriteDebugMessage("Landed on " + sub_MenuName + " Page on Property Admin");
                PropertyAdmin.Click_Link_Edit_Category(sub_MenuName);
                Logger.WriteDebugMessage("Edit Category Description Page got displayed");
                ExitFrame();
                EnterFrame("description_ifr");
                PropertyAdmin.Enter_Category_Description(categoryDescription);
                ExitFrame();
                Logger.WriteDebugMessage("Entered the Category Description");
                PropertyAdmin.Click_Button_Category_Description_Cancel();
                if (IsElementRemoved(categoryDescription))
                    Assert.Fail("Category Description got updated successfully even after clicking on Cancel button");
                else
                    Logger.WriteDebugMessage("Category Description is not got updated on Property Admin page");

                //Edit the Category with Description and Click on Save Button
                EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_Link_Edit_Category(sub_MenuName);
                Logger.WriteDebugMessage("Edit Category Description Page got displayed");
                ExitFrame();
                EnterFrame("description_ifr");
                PropertyAdmin.Enter_Category_Description(categoryDescription);
                ExitFrame();
                Logger.WriteDebugMessage("Entered the Category Description");
                PropertyAdmin.Click_Button_Category_Description_Save();
                EnterFrame("frontendEditorIframe");
                VerifyTextOnPageAndHighLight(categoryDescription);
                Logger.WriteDebugMessage("Category Description is got updated successfully on Property Admin page");
                ExitFrame();

                //Navigate to Preview Mode and Verify the Description
                PropertyAdmin.Click_MyMenu_PreviewButton();
                ControlToNextWindow();
                Logger.WriteDebugMessage("Landed on Preview Mode");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);
                Logger.WriteDebugMessage("Landed on " + sub_MenuName + " Page on Preview Page");
                VerifyTextOnPageAndHighLight(categoryDescription);
                Logger.WriteDebugMessage("Category Description is got updated successfully on Property Admin page");
                CloseCurrentTab();

                //Publish the changes
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end Page and Verify the Description
                PropertyAdmin.Click_PublishedView();
                ControlToNextWindow();
                Logger.WriteDebugMessage("Landed on Preview Mode");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);
                Logger.WriteDebugMessage("Landed on " + sub_MenuName + " Page on Preview Page");
                VerifyTextOnPageAndHighLight(categoryDescription);
                Logger.WriteDebugMessage("Category Description is got updated successfully on Property Admin page");
                CloseCurrentTab();

                //Update the Description with blank
                EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_Link_Edit_Category(sub_MenuName);
                Logger.WriteDebugMessage("Edit Category Description Page got displayed");
                ExitFrame();
                EnterFrame("description_ifr");
                PropertyAdmin.Enter_Category_Description(emptyCategoryDescription);
                ExitFrame();
                Logger.WriteDebugMessage("Entered the Category Description");
                PropertyAdmin.Click_Button_Category_Description_Save();
                if (IsElementRemoved(categoryDescription))
                    Assert.Fail("Category Description got not updated successfully with blank space");
                else
                    Logger.WriteDebugMessage("Category Description is got updated successfully with blank space");

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_PropertyName", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", "Food & Beverages");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Sub Menu Name", sub_MenuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_CategoryDescription", categoryDescription, true);


            }
        }
        public static void TC_232926()
        {
            if (TestCaseId == Utility.Constants.TC_232926)
            {
                //Pre-Requisites
                string propertyAdmin_Username, password, propertyName, sub_MenuName, title, description;
                Random no = new Random();

                //Retrieve data from TestData File
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                sub_MenuName = TestData.ExcelData.TestDataReader.ReadData(1, "Sub_MenuName");
                title = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Title"), no.Next().ToString());
                description = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Menu_Description"), no.Next().ToString());
                int ranNo = no.Next(1, 3);

                //Login to Property Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.ePlanner_NavigatetoProperty(propertyName);

                //Navigate to Specific Menu
                EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);

                //Upload Menu from eGallery
                Logger.WriteDebugMessage("Navigate to " + sub_MenuName + " Page");
                PropertyAdmin.Click_Here_for_eGallery();

                ControlToNextWindow();
                Logger.WriteDebugMessage("Navigate to Select Image from eGallary Page");
                PropertyAdmin.Select_Image_from_eGallery(ranNo.ToString());
                Logger.WriteDebugMessage("Image got Selected from eGallery");
                PropertyAdmin.Click_Button_SelectImage();
                Helper.ControlToPreviousWindow();
                Logger.WriteDebugMessage("Navigate Back to Property Admin Page");
                ExitFrame();

                //Verify the Added Images on Preview Page
                PropertyAdmin.Click_MyMenu_PreviewButton();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Preview window should get displayed");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);
                if (PageObject_PropertyAdmin.Verify_eGallery_Image().Displayed)
                {
                    Logger.WriteDebugMessage("Image from eGallery for Category got displayed on Preview page");
                }
                else
                    Assert.Fail("Image from eGallery for Category is not getting displayed on Preview page");
                Helper.CloseCurrentTab();

                //Publish the changes
                PropertyAdmin.Publish_Changes();

                //Navigate to Front-end and Verify the Added Item on the Front-end
                PropertyAdmin.Click_PublishedView();
                Helper.ControlToNewWindow();
                Logger.WriteDebugMessage("Navigate to Front-end page");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);
                if (PageObject_PropertyAdmin.Verify_eGallery_Image().Displayed)
                {
                    Logger.WriteDebugMessage("Image from eGallery for eGallery got displayed on Front-end page");
                }
                else
                    Assert.Fail("Image from eGallery for eGallery is not getting displayed on front-end page");
                Helper.CloseCurrentTab();

                //Log test data into log file as well as extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_PropertyName", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", "Food & Beverages");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Sub Menu Name", sub_MenuName, true);

            }
        }
        public static void TC_233769()
        {
            if (TestCaseId == Utility.Constants.TC_233769)
            {
                //Pre-Requisites
                string propertyAdmin_Username, password, propertyName, sub_MenuName, title, description, replaceTitle, overlay_Title, max_Char, special_Char, numeric_Value, category_Description, category_Disclaimer, validation_Message, replace_Confirmation, max_Char_Validation;
                Random no = new Random();

                //Retrieve data from TestData File
                propertyAdmin_Username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                propertyName = TestData.ExcelData.TestDataReader.ReadData(1, "PropertyName");
                sub_MenuName = TestData.ExcelData.TestDataReader.ReadData(1, "Sub_MenuName");
                title = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Title"), no.Next().ToString());
                description = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Menu_Description"), no.Next().ToString());
                replaceTitle = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "replaceTitle"), no.Next().ToString());
                overlay_Title = TestData.ExcelData.TestDataReader.ReadData(1, "OverlayTitle");
                max_Char = TestData.ExcelData.TestDataReader.ReadData(1, "Maximum_Char");
                special_Char = TestData.ExcelData.TestDataReader.ReadData(1, "Special_Char");
                numeric_Value = TestData.ExcelData.TestDataReader.ReadData(1, "Numeric_Char");
                category_Description = TestData.ExcelData.TestDataReader.ReadData(1, "Category_Description");
                category_Disclaimer = TestData.ExcelData.TestDataReader.ReadData(1, "Category_Disclaimer");
                validation_Message = TestData.ExcelData.TestDataReader.ReadData(1, "Validation_Message");
                replace_Confirmation = TestData.ExcelData.TestDataReader.ReadData(1, "Replace_Confirmation");
                max_Char_Validation = TestData.ExcelData.TestDataReader.ReadData(1, "max_Char_Validation");

                //Login to Property Admin
                PropertyAdmin.PropertyAdmin_Non2Factor();

                //Navigate to Home Page and Select Property
                PropertyAdmin.ePlanner_NavigatetoProperty(propertyName);

                //Navigate to Specific Menu
                EnterFrame("frontendEditorIframe");
                PropertyAdmin.Click_Menu_FoodAndBeverages();
                Logger.WriteDebugMessage("Clicked on Food and Beverages");
                PropertyAdmin.Click_Category_Sub_Menu(sub_MenuName);

                //Add Item with Description
                PropertyAdmin.AddItem_Title_Description(title, description);

                //Click on Find and Replace and Verify the Overlay got close clicking on Done Button
                PropertyAdmin.Click_Link_FindAndReplace();
                if (PageObject_PropertyAdmin.Enter_Find_TextBox().Displayed)
                { 
                    Logger.WriteDebugMessage("Find and Replace Overlay got Displayed");
                    PropertyAdmin.Click_Button_Done();
                    if (!PageObject_PropertyAdmin.Enter_Find_TextBox().Displayed)
                        Logger.WriteDebugMessage("Find and Replace overlay got closed");
                    else
                        Assert.Fail("Find and Replace Overlay not get closed");
                }
                else
                    Assert.Fail("Find and Replace Overlay not got displayed");

                //Verify the Title of Overlay and Character length of the text-box
                PropertyAdmin.Click_Link_FindAndReplace();
                if (PropertyAdmin.Get_AlertBox_Title().Contains(overlay_Title))
                    Logger.WriteDebugMessage("Title of the Pop-up is Find and Replace");
                else
                    Assert.Fail("Title of the pop-up is not equal to Find and Replace");
                
                //Verify the Maximum Character length of the text box
                PropertyAdmin.Enter_Find_TextBox(max_Char);
                PropertyAdmin.Enter_Replace_TextBox(max_Char);
                PropertyAdmin.Click_Button_Find();
                VerifyTextOnPageAndHighLight(max_Char_Validation);
                Logger.WriteDebugMessage("Maximum Character Length of the Find and Replace Text-box is less than 25 validation message got displayed");
                                                      

                //Verify the Special Character allowed for the text box
                PropertyAdmin.Enter_Find_TextBox(special_Char);
                PropertyAdmin.Enter_Replace_TextBox(special_Char);
                if (PageObject_PropertyAdmin.Enter_Find_TextBox().GetAttribute("value").Equals(special_Char) && PageObject_PropertyAdmin.Enter_Replace_TextBox().GetAttribute("value").Equals(special_Char))
                    Logger.WriteDebugMessage("Special Characters are allowed in the Text Box");
                else
                    Assert.Fail("Special Characters are not allowed in the Text Box");

                //Verify the Numeric Character allowed for the text box
                PropertyAdmin.Enter_Find_TextBox(numeric_Value);
                PropertyAdmin.Enter_Replace_TextBox(numeric_Value);
                if (PageObject_PropertyAdmin.Enter_Find_TextBox().GetAttribute("value").Equals(numeric_Value) && PageObject_PropertyAdmin.Enter_Replace_TextBox().GetAttribute("value").Equals(numeric_Value))
                    Logger.WriteDebugMessage("Numeric Value are allowed in the Text Box");
                else
                    Assert.Fail("Numeric Value are not allowed in the Text Box");
                PropertyAdmin.Click_Button_Done();

                //Verify the Button inActivity
                PropertyAdmin.Click_Link_FindAndReplace();
                if (PageObject_PropertyAdmin.Click_Button_Find().Enabled)
                    Assert.Fail("Find Button is Enable without entering value into Find Box");
                else
                    Logger.WriteDebugMessage("Find Button is disable until user  enter value into Find Box");
                
                //Verify text is not got updated
                PropertyAdmin.Enter_Find_TextBox(title);
                PropertyAdmin.Enter_Replace_TextBox(replaceTitle);
                Logger.WriteDebugMessage("Entered the Value on Find and Replace Textbox");
                PropertyAdmin.Click_Button_Done();
                EnterFrame("frontendEditorIframe");
                if (Helper.IsElementRemoved(replaceTitle))
                    Assert.Fail("Title got replaced without clicking on replace button");
                else
                    Logger.WriteDebugMessage("Title did not got replaced without clicking on replace button");
                ExitFrame();

                //Verify the findAll button inactivity
                PropertyAdmin.Click_Link_FindAndReplace();
                PropertyAdmin.Enter_Find_TextBox(title);
                PropertyAdmin.Enter_Replace_TextBox(replaceTitle);
                if (PageObject_PropertyAdmin.Click_Button_ReplaceAll().Enabled)
                    Assert.Fail("Replace All Button is Enable without Finding the text");
                else
                    Logger.WriteDebugMessage("Replace All Button is disable without Finding the text");
                PropertyAdmin.Click_Button_Done();

                //Enter the not matching details of Find and Verify the message
                PropertyAdmin.Click_Link_FindAndReplace();
                PropertyAdmin.Enter_Find_TextBox(TestCaseId);
                PropertyAdmin.Click_Button_Find();
                if (PropertyAdmin.Get_Validation_Message().Contains(validation_Message))
                {
                    Logger.WriteDebugMessage("Test is not found on Find and Replace Overlay");
                }
                else
                    Assert.Fail("Text not found validation message is not displayed");


                PropertyAdmin.Enter_Find_TextBox(category_Description);
                PropertyAdmin.Click_Button_Find();
                if (PropertyAdmin.Get_Validation_Message().Contains(validation_Message))
                {
                    Logger.WriteDebugMessage("Text is not found on Find and Replace Overlay");
                }
                else
                    Assert.Fail("Text not found validation message is not displayed");
                Logger.WriteDebugMessage("Category Description is not found on Find and Replace Overlay");
                
                PropertyAdmin.Enter_Find_TextBox(category_Disclaimer);
                PropertyAdmin.Click_Button_Find();
                if (PropertyAdmin.Get_Validation_Message().Contains(validation_Message))
                {
                    Logger.WriteDebugMessage("Text is not found on Find and Replace Overlay");
                }
                else
                    Assert.Fail("Text not found validation message is not displayed");
                Logger.WriteDebugMessage("Category Disclaimer is not found on Find and Replace Overlay");
                PropertyAdmin.Click_Button_Done();

                //Enter the Value in Find box and Replace it with another text
                PropertyAdmin.Click_Link_FindAndReplace();
                PropertyAdmin.Enter_Find_TextBox(title);
                PropertyAdmin.Enter_Replace_TextBox(replaceTitle);
                PropertyAdmin.Click_Button_Find();
                if (PageObject_PropertyAdmin.Click_Button_ReplaceAll().Enabled)
                {
                    Logger.WriteDebugMessage("Text found on the Page and Replace button got displayed");
                    PropertyAdmin.Click_Button_ReplaceAll();
                    if (PropertyAdmin.Get_Success_Validation_Message().Contains(replace_Confirmation))
                    {
                        Logger.WriteDebugMessage("Text replaced Confirmation message got displayed");
                    }
                    else
                        Assert.Fail("Text replaced Confirmation message not get displayed");
                    Logger.WriteDebugMessage("Text got Replaced Successfully");
                    PropertyAdmin.Click_Button_Done();
                    EnterFrame("frontendEditorIframe");
                    if (Helper.IsElementRemoved(replaceTitle) && (!Helper.IsElementRemoved(title)))
                    {
                        VerifyTextOnPageAndHighLight(replaceTitle);
                        Logger.WriteDebugMessage("Replaced text = " + replaceTitle + " found on the page");
                    }
                    else
                        Assert.Fail("Text is not replaced and still old text is displayed on the page");
                    ExitFrame();
                }
                else
                    Assert.Fail("Replace All Button is not Enabled");
                
                //Delete Added Title
                PropertyAdmin.Delete_Item(replaceTitle);

                //Log test data into log file and extent report
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_PropertyName", propertyName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Menu Name", "Food & Beverages");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Sub Menu Name", sub_MenuName);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Title Name", title);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Overlay Title Name", overlay_Title);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Description Name", description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Replace Title Name", replaceTitle);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Maximum Character", max_Char);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Maximum Character Error Message", max_Char_Validation);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Special Character", special_Char);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Numeric Values", numeric_Value);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Category Description", category_Description);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Category Disclaimer", category_Disclaimer);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Validation Message", validation_Message);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Replaced Confirmation", replace_Confirmation, true);

            }
        }
    }
}
