using BaseUtility.PageObject;
using BaseUtility.Utility;
using InfoMessageLogger;
using NUnit.Framework;
using OpenQA.Selenium;
using RevIntel.AppModule.UI;
using RevIntel.PageObject.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using TestData;
using Navigation = RevIntel.AppModule.UI.Navigation;

namespace RevIntel.AppModule.MainAdminApp
{
    public partial class MainAdminApp : RevIntel.Utility.Setup
    {
        public static void TC_271062()
        {
            if (TestCaseId == Utility.Constants.TC_271062)
            {
                //Pre-Requisite
                string password, username, client;

                //Retrieve data from Database or testdata file
                username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                client = "Kerzner";
                    
                Logger.WriteInfoMessage("This test cases will Verify the Help tool is displaying in all authenticated page");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Automation Environment and Select Specific Client
                Navigation.Select_Client(client);
                Navigation.VerifyHelpIcon("Monthly Pick-up");

                //Navigate to Portal and Verify the Help Icon Present or not
                Navigation.Click_Link_Portal();
                Navigation.VerifyHelpIcon("Portal");

                //Navigate to Portfolio->Portfolio Report and Verify the Help Icon Present or not
                Navigation.Click_Menu_Portfolio();
                Logger.WriteDebugMessage("Portfolio Drop down displayed");
                Navigation.Click_Portfolio_Report();
                Navigation.VerifyHelpIcon("Portfolio Report");

                //Navigate to Hotel->Hotel Event Calender and Verify the Help Icon Present or not
                Navigation.Click_Menu_Hotel();
                Logger.WriteDebugMessage("Hotel Dropdown displayed");
                Navigation.Click_Hotel_Event_Calendar_Report();
                Navigation.VerifyHelpIcon("Hotel Event Calender");

                //Navigate to Business Source->Agent Analysis and Verify the Help Icon Present or not
                Navigation.BusinessSource();
                Logger.WriteDebugMessage("BusinessSource Dropdown displayed");
                Navigation.Click_AgentAnalysis_Report();
                Navigation.VerifyHelpIcon("Agent Analysis");

                //Navigate to Market->Market Report and Verify the Help Icon Present or not
                Navigation.Click_Menu_Market();
                Logger.WriteDebugMessage("market Dropdown displayed");
                Navigation.Click_Market_Report();
                Navigation.VerifyHelpIcon("Market Report");

                //Navigate to Booking Trends->Lenght of Stay Report and Verify the Help Icon Present or not
                Navigation.Click_Menu_Booking_Trends();
                Logger.WriteDebugMessage("Booking Trends Dropdown displayed");
                Navigation.Click_Length_of_Stay_Report();
                Navigation.VerifyHelpIcon("Lenght of Stay Report");


                //Navigate to Channel->Channel Report and Verify the Help Icon Present or not
                Navigation.Click_Menu_Channel();
                Helper.VerifyTextOnPage("channel Drop down Displayed");
                Navigation.Click_Channel_Report();
                Navigation.VerifyHelpIcon("Channel Report");

                //Navigate to Forecast and Budget->Pace and Forecast Report and Verify the Help Icon Present or not
                Navigation.Click_Menu_Forecast_and_Budget();
                Logger.WriteDebugMessage("Forecast and Budget Drop down displayed");
                Navigation.Click_Pace_and_Forecast_Report();
                Navigation.VerifyHelpIcon("Pace and Forecast Report");

                //Navigate to Adhoc->Stay Graph and Verify the Help Icon Present or not
                Navigation.Click_Hamburger_Icon();
                Navigation.Click_Menu_Adhoc_SingleClick();  
                //Navigation.Click_Menu_Adhoc();
                Logger.WriteDebugMessage("Adhoc menu drop down displayed");
                Navigation.Click_Stay_Graph_Report();
                Navigation.VerifyHelpIcon("Stay Graph");

                //Navigate to Room Type->Room Type analysis and Verify the Help Icon Present or not
                Navigation.Click_Hamburger_Icon();
                Logger.WriteDebugMessage("All reports under Hamburger_Icon dropdown Displayed");
                Navigation.Click_Menu_Room_Type();
                Logger.WriteDebugMessage("Geo source Drop down Displayed");
                Navigation.Click_Menu_Room_Type_Analysis();
                Navigation.VerifyHelpIcon("Room Type Analysis");

                //Log the test data in log file
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Login_Email", ProjectDetails.CommonAdminEmail);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Client", client, true);

            }
        }
        public static void TC_271063()
        {
            if (TestCaseId == Utility.Constants.TC_271063)
            {
                //Pre-Requisite
                string password, username, client;

                //Retrieve data from Database or testdata file
                username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                client = "Kerzner";
                
                Logger.WriteInfoMessage("This test cases will Verify by default more than top 3 suggestion gets displayed");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Automation Environment and Select Specific Client
                Navigation.Select_Client(client);
                Navigation.VerifyHelpIcon("Monthly Pick Up");
                Helper.EnterFrame("launcher");
                Navigation.Click_Help_Icon();
                Logger.WriteDebugMessage("Clicked on Help Icon");
                Helper.ExitFrame();
                EnterFrame("webWidget");
                //Verify the suggestions
                for(int i = 1;i<4; i++)
                {
                    if (Navigation.Verify_Help_Top_Suggestion(i.ToString()))
                    {
                        VerifyTextOnPageAndHighLight(Helper.GetText(PageObject_Navigation.Verify_Help_Top_Suggestion(i.ToString())));
                        Logger.WriteDebugMessage("Top Suggestion got displayed on the Help Icon");
                    }
                    else
                        Assert.Fail("Top Suggestions are not displaying on the Help Icon");
                }
                ExitFrame();

                //Log the test data in log file
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Login_Email", ProjectDetails.CommonAdminEmail);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Client", client, true);
            }
        }
        public static void TC_271064()
        {
            if (TestCaseId == Utility.Constants.TC_271064)
            {
                //Pre-Requisite
                string password, username, client, searchText1,searchText2;

                //Retrieve data from Database or testdata file
                username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                client = TestData.ExcelData.TestDataReader.ReadData(1, "Client"); ;
                searchText1 = TestData.ExcelData.TestDataReader.ReadData(1, "SearchTest");
                searchText2 = TestData.ExcelData.TestDataReader.ReadData(2, "SearchTest");

                Logger.WriteInfoMessage("This test cases will Verify only the help that belongs to the product gets displayed in suggestion when searched for a text");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Automation Environment and Select Specific Client
                Navigation.Select_Client(client);

                //Verify only the help that belongs to the product gets displayed in suggestion when searched for a text
                Helper.EnterFrame("launcher");
                Navigation.Click_Help_Icon();
                Logger.WriteDebugMessage("Clicked on Help Icon");
                Helper.ExitFrame();
                EnterFrame("webWidget");
                //Search for the 1st Text
                Navigation.Enter_Help_Text(searchText1);
                Logger.WriteDebugMessage("Entered Text in Text field");
                int noOfItems = Driver.FindElements(By.XPath("//a[contains(@href,'https://help.cendyn.com')]")).Count();
                for (int i = 1; i < noOfItems+1; i++)
                { 
                  if (Helper.GetText(PageObject_Navigation.Verify_Help_Top_Suggestion(i.ToString())).Contains(searchText1) || Helper.GetText(PageObject_Navigation.Verify_Help_Top_Suggestion(i.ToString())).Contains(searchText1.ToLower()))
                    {

                        VerifyTextOnPageAndHighLight(Helper.GetText(PageObject_Navigation.Verify_Help_Top_Suggestion(i.ToString())));
                        Logger.WriteDebugMessage("Suggestion got displayed on the Help Icon");
                    }

                    else
                        Assert.Fail("Suggestions are not displaying on the Help Icon");
                }

                //Search for the another Text
                Navigation.Enter_Help_Text(searchText2);
                Logger.WriteDebugMessage("Entered Text in Text field");
                noOfItems = Driver.FindElements(By.XPath("//a[contains(@href,'https://help.cendyn.com')]")).Count();
                for (int i = 1; i < noOfItems+1; i++)
                {
                    if (Helper.GetText(PageObject_Navigation.Verify_Help_Top_Suggestion(i.ToString())).Contains(searchText1) && Helper.GetText(PageObject_Navigation.Verify_Help_Top_Suggestion(i.ToString())).Contains(searchText2.ToLower()) || Helper.GetText(PageObject_Navigation.Verify_Help_Top_Suggestion(i.ToString())).Contains(searchText2))
                    {
                        VerifyTextOnPageAndHighLight(Helper.GetText(PageObject_Navigation.Verify_Help_Top_Suggestion(i.ToString())));
                        Logger.WriteDebugMessage("Suggestion got displayed on the Help Icon with Product");
                    }
                    else
                        Assert.Fail("Suggestions are not displaying on the Help Icon");
                }

                //Log the test data in log file
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Login_Email", ProjectDetails.CommonAdminEmail);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Searched Text 1",searchText1);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Searched Text 2", searchText2, true);
            }
        }
        public static void TC_271065()
        {
            if (TestCaseId == Utility.Constants.TC_271065)
            {
                //Pre-Requisite
                string password, username, client, randomText, name, subject, property, service, sub_services, description;
                Random ran = new Random();
                randomText = ran.Next().ToString();
                //Retrieve data from Database or testdata file
                username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                client = TestData.ExcelData.TestDataReader.ReadData(1, "Client");
                name = TestData.ExcelData.TestDataReader.ReadData(1, "Name")+ randomText;
                subject = TestData.ExcelData.TestDataReader.ReadData(1, "Subject")+ randomText;
                property = TestData.ExcelData.TestDataReader.ReadData(1, "Property")+ randomText;
                service = TestData.ExcelData.TestDataReader.ReadData(1, "Service");
                sub_services = TestData.ExcelData.TestDataReader.ReadData(1, "Sub_Service");
                description = TestData.ExcelData.TestDataReader.ReadData(1, "Description")+ randomText;
                
                Logger.WriteInfoMessage("This test cases will Verify Login and Log out is successful and URL is pointing to right database");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Automation Environment and Select Specific Client
                Navigation.Select_Client(client);

                //Verify only the help that belongs to the product gets displayed in suggestion when searched for a text
                Helper.EnterFrame("launcher");
                Navigation.Click_Help_Icon();
                Logger.WriteDebugMessage("Clicked on Help Icon");
                Helper.ExitFrame();
                
                //Click on Contact us and enter all the details
                EnterFrame("webWidget");
                Navigation.Sent_Contact_us_Email(name, ProjectDetails.CommonAdminEmail, subject,service,sub_services,property, description);
                ExitFrame();

                OpenNewTab();
                ControlToNewWindow();
                Email.LogIntoCatchAll();
                Time.AddDelay(10000);
                Helper.ReloadPage();
                Hotmail.CheckOutLook();
                Hotmail.SearchEmail(ProjectDetails.CommonAdminEmail);
                try
                
                {                 
                    ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][4]")));
                }
                catch (Exception ex)
                {
                    ElementClick(Driver.FindElement(By.XPath("//div[@role='region'][@tabindex='-1']//div[@data-convid][1]")));
                    Logger.WriteDebugMessage("Failed due to below error" + ex.Message);
                }
                Helper.PageDown();

                //Verify the data in Emails 
                VerifyTextOnPageAndHighLight(subject);
                Logger.WriteDebugMessage("Email Populated in CatchAll");

                //Log the test data in log file
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Name", name);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Email", ProjectDetails.CommonAdminEmail);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Subject", subject);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Service", service);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Sub Service", sub_services);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Property", property);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Description", description, true);
                
            }
        }
        public static void TC_271066()
        {
            if (TestCaseId == Utility.Constants.TC_271066)
            {
                //Pre-Requisite
                string password, username, client, randomText, validationMessage;

                //Retrieve data from Database or testdata file
                username = ProjectDetails.CommonAdminEmail;
                password = ProjectDetails.CommonAdminPassword;
                client = TestData.ExcelData.TestDataReader.ReadData(1, "Client");
                randomText = TestData.ExcelData.TestDataReader.ReadData(1, "RandomText");
                validationMessage = TestData.ExcelData.TestDataReader.ReadData(1, "Validation");

                Logger.WriteInfoMessage("This test cases will Verify Login and Log out is successful and URL is pointing to right database");

                //Enter Email address and password
                Login.Frontend_SignIn(username, password);

                //Select Automation Environment and Select Specific Client
                Navigation.Select_Client(client);

                //Verify only the help that belongs to the product gets displayed in suggestion when searched for a text
                Helper.EnterFrame("launcher");
                Navigation.Click_Help_Icon();
                Logger.WriteDebugMessage("Clicked on Help Icon");
                Helper.ExitFrame();
                EnterFrame("webWidget");
                //Search for the 1st Text
                Navigation.Enter_Help_Text(randomText);
                Logger.WriteDebugMessage("Entered " + randomText + " Text in Text field");

                try
                {
                    if (Driver.FindElement(By.XPath("//a[contains(@href,'https://help.cendyn.com')]")).Displayed)
                    {
                        int noOfItems = Driver.FindElements(By.XPath("//a[contains(@href,'https://help.cendyn.com')]")).Count();
                        for (int i = 1; i < noOfItems + 1; i++)
                        {
                            if (Helper.GetText(PageObject_Navigation.Verify_Help_Top_Suggestion(i.ToString())).Contains(randomText))
                                Assert.Fail("Random Value getting Searched");
                        }
                    }
                }
                catch (Exception)
                {
                    VerifyTextOnPageAndHighLight(validationMessage);
                }
                //---------------------------------------------------------
                Logger.WriteDebugMessage("Random Value is not getting Searched in Help and Search is Empty");

                //Log the test data in log file
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Login_Email", ProjectDetails.CommonAdminEmail);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Client", client);
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId + "_Validation Message", validationMessage, true);
                
            }
        }
    }
}
