using System;
using eLoyaltyV3.AppModule.UI;
using System.Collections.Generic;
using NUnit.Framework;
using TestData;
using eLoyaltyV3.Entity;
using BaseUtility.Utility;
using eLoyaltyV3.PageObject.Admin;
using InfoMessageLogger;
using Queries = eLoyaltyV3.Utility.Queries;
using Constants = eLoyaltyV3.Utility.Constants;
using System.Runtime.InteropServices;
using OpenQA.Selenium;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : eLoyaltyV3.Utility.Setup
    {
        public static void TC_114486()
        {
            if (TestCaseId == Constants.TC_114486)
            {
                //pre-requiste
                string name, basedOn, startDate, endDate, priority, ruleType, For, pointsEarned, per, calculatedOn, pointExpiryMonth, randomnumber, fieldOnOverlay, revenueType;
                Users data = new Users();
                Random ran = new Random();
                randomnumber = ran.Next().ToString();
                Queries.GetMemberLevel(data, 1);

                //Retrive data from Test data file
                name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Name"), randomnumber);
                basedOn = TestData.ExcelData.TestDataReader.ReadData(1, "BasedOn");
                startDate = DateTime.Now.AddDays(-2).ToString("MM/dd/yyyy");
                endDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                priority = String.Concat(DateTime.Now.Millisecond, DateTime.Now.Minute);
                ruleType = TestData.ExcelData.TestDataReader.ReadData(1, "RuleType");
                For = TestData.ExcelData.TestDataReader.ReadData(1, "For");
                pointsEarned = TestData.ExcelData.TestDataReader.ReadData(1, "PointsEarned");
                per = TestData.ExcelData.TestDataReader.ReadData(1, "Per");
                calculatedOn = TestData.ExcelData.TestDataReader.ReadData(1, "CalculatedOn");
                pointExpiryMonth = TestData.ExcelData.TestDataReader.ReadData(1, "PointExpiryMonth");
                revenueType = TestData.ExcelData.TestDataReader.ReadData(1, "RevenueType");

                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                Admin.Click_Menu_LoyaltyRules();
                Logger.WriteDebugMessage("Landed on the Loyalty Rules page");
                Admin.Click_SubTab_PointsEarningRules();
                Logger.WriteDebugMessage("Users Landed on Points Earning Rules Page");

                //Verify the mandaroty Fields on Add Overlay
                Admin.Click_PointsEarningRules_Button_AddRule();
                Logger.WriteDebugMessage("Loyalty rule popup should get displayed ");
                for(int i=1; i<=12;i++)
                {
                    fieldOnOverlay = TestData.ExcelData.TestDataReader.ReadData(i, "FiledOnOverlay");
                    VerifyTextOnPageAndHighLight(fieldOnOverlay);
                }
                Logger.WriteDebugMessage("All the Mandatory Fileds are displayed with *");
                
                //Add New Points Earning Rule
                Admin.PointsEarningRule_AddRule(name, "", "",
                    basedOn, startDate, endDate, ruleType, priority, For,
                    pointsEarned, per, calculatedOn, revenueType, pointExpiryMonth,
                    data.MembershipLevel, ProjectName);
                Logger.WriteDebugMessage("user should be able to Enter all the fields");
                Admin.Click_PointsEarningRules_Button_Save();
                ElementWait(PageObject_Admin.PointsEarningRules_Text_Filter(), 240);
                Logger.WriteDebugMessage("Data should be entered successfully");

                //Verify the Rule on Points Earning tab
                Admin.Enter_PointsEarningRules_Text_Filter(name);
                AddDelay(2500);
                VerifyTextOnPageAndHighLight(name);
                Logger.WriteDebugMessage("Rule got Displayed on the Page");

                ///Update the Rule with Past date, so that it will not impact on Testing
                Admin.Click_PointsEarningRules_Icon_Edit();
                Logger.WriteDebugMessage("Loyalty rule popup should get displayed ");
                Admin.Enter_PointsEarningRules_Text_EndDate(DateTime.Now.AddDays(-1).ToString("MM/dd/yyyy"));
                Logger.WriteDebugMessage("Updated Rule End Date");
                Admin.Click_PointsEarningRules_Button_Save();
                ElementWait(PageObject_Admin.PointsEarningRules_Text_Filter(), 240);
                Logger.WriteDebugMessage("Data should be updated successfully");
                Admin.Enter_PointsEarningRules_Text_Filter(name);
                AddDelay(2500);
                VerifyTextOnPageAndHighLight("Inactive");
                Logger.WriteDebugMessage("Rule got Displayed on the Page");


                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, "Name", name);
                Logger.LogTestData(TestPlanId, TestCaseId, "Based On", basedOn);
                Logger.LogTestData(TestPlanId, TestCaseId, "Start Date", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, "End Date", endDate);
                Logger.LogTestData(TestPlanId, TestCaseId, "Rule Type", ruleType);
                Logger.LogTestData(TestPlanId, TestCaseId, "Priority", priority);
                Logger.LogTestData(TestPlanId, TestCaseId, "For", For);
                Logger.LogTestData(TestPlanId, TestCaseId, "Points Earned", pointsEarned);
                Logger.LogTestData(TestPlanId, TestCaseId, "Per", per);
                Logger.LogTestData(TestPlanId, TestCaseId, "Calculated On", calculatedOn);
                Logger.LogTestData(TestPlanId, TestCaseId, "Point Expiry", pointExpiryMonth, true);

            }

        }

        public static void TC_114488()
        {
            if (TestCaseId == Constants.TC_114488)
            {
                //pre-requiste
                string name, basedOn, startDate, endDate, priority, ruleType, For, pointsEarned, per, calculatedOn, pointExpiryMonth, displayName, description, revenueType, nameValidation;
                Users data = new Users();
                Queries.GetLoyaltyRules(data, "1","Points");
                Queries.GetMemberLevel(data, 1);

                //Retrive data from Test data file
                name = data.RuleName;
                displayName = TestData.ExcelData.TestDataReader.ReadData(1, "DisplayName");
                description = TestData.ExcelData.TestDataReader.ReadData(1, "Description");
                basedOn = TestData.ExcelData.TestDataReader.ReadData(1, "BasedOn");
                startDate = DateTime.Now.AddDays(-2).ToString("MM/dd/yyyy");
                endDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                priority = String.Concat(DateTime.Now.Millisecond, DateTime.Now.Minute);
                ruleType = TestData.ExcelData.TestDataReader.ReadData(1, "RuleType");
                For = TestData.ExcelData.TestDataReader.ReadData(1, "For");
                pointsEarned = TestData.ExcelData.TestDataReader.ReadData(1, "PointsEarned");
                per = TestData.ExcelData.TestDataReader.ReadData(1, "Per");
                calculatedOn = TestData.ExcelData.TestDataReader.ReadData(1, "CalculatedOn");
                pointExpiryMonth = TestData.ExcelData.TestDataReader.ReadData(1, "PointExpiryMonth");
                revenueType = TestData.ExcelData.TestDataReader.ReadData(1, "RevenueType");
                nameValidation = TestData.ExcelData.TestDataReader.ReadData(1, "NameValidation");

                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                Admin.Click_Menu_LoyaltyRules();
                Logger.WriteDebugMessage("Landed on the Loyalty Rules page");
                Admin.Click_SubTab_PointsEarningRules();
                Logger.WriteDebugMessage("Users Landed on Points Earning Rules Page");

                //Verify the Already existing Rule
                Admin.Enter_PointsEarningRules_Text_Filter(name);
                AddDelay(2500);
                VerifyTextOnPageAndHighLight(name);
                Logger.WriteDebugMessage("Rule got Displayed on the Page");

                //Add New Points Earning Rule with Already Used Name
                Admin.Click_PointsEarningRules_Button_AddRule();
                Logger.WriteDebugMessage("Loyalty rule popup should get displayed ");
                Admin.PointsEarningRule_AddRule(name, displayName, description,
                    basedOn, startDate, endDate, ruleType, priority, For,
                    pointsEarned, per, calculatedOn, revenueType, pointExpiryMonth,
                    data.MembershipLevel, ProjectName);
                Logger.WriteDebugMessage("user should be able to Enter all the fields");
                Admin.Click_PointsEarningRules_Button_Save();
                ElementWait(Driver.FindElement(By.XPath("(//*[contains(text(),'"+nameValidation+"')])[2]")), 240);
                VerifyTextOnPageAndHighLight(nameValidation);
                Logger.WriteDebugMessage("Validation Message for Duplicate Name got displayed");

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, "Already Present Rule Name", name);
                Logger.LogTestData(TestPlanId, TestCaseId, "Display Name", displayName);
                Logger.LogTestData(TestPlanId, TestCaseId, "Description", description);
                Logger.LogTestData(TestPlanId, TestCaseId, "Based On", basedOn);
                Logger.LogTestData(TestPlanId, TestCaseId, "Start Date", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, "End Date", endDate);
                Logger.LogTestData(TestPlanId, TestCaseId, "Rule Type", ruleType);
                Logger.LogTestData(TestPlanId, TestCaseId, "Priority", priority);
                Logger.LogTestData(TestPlanId, TestCaseId, "For", For);
                Logger.LogTestData(TestPlanId, TestCaseId, "Points Earned", pointsEarned);
                Logger.LogTestData(TestPlanId, TestCaseId, "Per", per);
                Logger.LogTestData(TestPlanId, TestCaseId, "Calculated On", calculatedOn);
                Logger.LogTestData(TestPlanId, TestCaseId, "Point Expiry", pointExpiryMonth);
                Logger.LogTestData(TestPlanId, TestCaseId, "Name Validation Message", nameValidation, true);

            }
        }
        public static void TC_114489()
        {
            if (TestCaseId == Constants.TC_114489)
            {
                //pre-requiste
                Users data = new Users();
                Random ran = new Random();
                string name, basedOn, startDate, endDate, priority, ruleType, For, pointsEarned, per, calculatedOn, pointExpiryMonth, displayName, description, revenueType, priorityValidation,randomNumber;
                randomNumber = ran.Next().ToString();
                Queries.GetLoyaltyRules(data, "1","Points");
                Queries.GetMemberLevel(data, 1);

                //Retrive data from Test data file
                name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Name"), randomNumber); 
                displayName = TestData.ExcelData.TestDataReader.ReadData(1, "DisplayName");
                description = TestData.ExcelData.TestDataReader.ReadData(1, "Description");
                basedOn = TestData.ExcelData.TestDataReader.ReadData(1, "BasedOn");
                startDate = DateTime.Now.AddDays(-2).ToString("MM/dd/yyyy");
                endDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                priority = data.Priority;
                ruleType = TestData.ExcelData.TestDataReader.ReadData(1, "RuleType");
                For = TestData.ExcelData.TestDataReader.ReadData(1, "For");
                pointsEarned = TestData.ExcelData.TestDataReader.ReadData(1, "PointsEarned");
                per = TestData.ExcelData.TestDataReader.ReadData(1, "Per");
                calculatedOn = TestData.ExcelData.TestDataReader.ReadData(1, "CalculatedOn");
                pointExpiryMonth = TestData.ExcelData.TestDataReader.ReadData(1, "PointExpiryMonth");
                revenueType = TestData.ExcelData.TestDataReader.ReadData(1, "RevenueType");
                priorityValidation = TestData.ExcelData.TestDataReader.ReadData(1, "PriorityValidation");

                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                
                //Navigte to Points earning rule
                Admin.Click_Menu_LoyaltyRules();
                Logger.WriteDebugMessage("Landed on the Loyalty Rules page");
                Admin.Click_SubTab_PointsEarningRules();
                Logger.WriteDebugMessage("Users Landed on Points Earning Rules Page");

                //Verify the Already existing Rule
                Admin.Enter_PointsEarningRules_Text_Filter(data.RuleName);
                AddDelay(2500);
                VerifyTextOnPageAndHighLight(data.RuleName);
                VerifyTextOnPageAndHighLight(priority);
                Logger.WriteDebugMessage("Rule got Displayed on the Page");

                //Add New Points Earning Rule with Already Used Priority of active rule and verify the Validation message
                Admin.Click_PointsEarningRules_Button_AddRule();
                Logger.WriteDebugMessage("Loyalty rule popup should get displayed ");
                Admin.PointsEarningRule_AddRule(name, displayName, description,
                    basedOn, startDate, endDate, ruleType, priority, For,
                    pointsEarned, per, calculatedOn, revenueType, pointExpiryMonth,
                    data.MembershipLevel, ProjectName);
                Logger.WriteDebugMessage("user should be able to Enter all the fields with Priority of existing Active Rule");
                Admin.Click_PointsEarningRules_Button_Save();
                ElementWait(Driver.FindElement(By.XPath("(//*[contains(text(),'"+priorityValidation+"')])[2]")), 240);
                VerifyTextOnPageAndHighLight(priorityValidation);
                Logger.WriteDebugMessage("Validation Message for Duplicate Priority got displayed");
                Admin.Click_PointsEarningRules_Button_Cancel();
                Logger.WriteDebugMessage("Clicked on Canceled button for Add Points earning Rule");

                //Add New Points Earning Rule with Already Used Priority of Inactive rule
                Queries.GetLoyaltyRules(data, "0", "Points");
                Admin.Enter_PointsEarningRules_Text_Filter(data.RuleName);
                AddDelay(2500);
                VerifyTextOnPageAndHighLight(data.RuleName);
                VerifyTextOnPageAndHighLight("Inactive");
                Logger.WriteDebugMessage("Rule got Displayed on the Page");
                
                //Add rule with same Priority
                Admin.Click_PointsEarningRules_Button_AddRule();
                Logger.WriteDebugMessage("Loyalty rule popup should get displayed ");
                Admin.PointsEarningRule_AddRule(name, displayName, description,
                    basedOn, startDate, endDate, ruleType, data.Priority, For,
                    pointsEarned, per, calculatedOn, revenueType, pointExpiryMonth,
                    data.MembershipLevel, ProjectName);
                Logger.WriteDebugMessage("user should be able to Enter all the fields with Priority of existing Inactive Rule");
                Admin.Click_PointsEarningRules_Button_Save();
                
                //Verify the added Rule
                Admin.Enter_PointsEarningRules_Text_Filter(name);
                AddDelay(2500);
                VerifyTextOnPageAndHighLight(name);
                VerifyTextOnPageAndHighLight("Active");
                VerifyTextOnPageAndHighLight(data.Priority);
                Logger.WriteDebugMessage("Rule got Displayed on the Page");


                //Inactive the Rule
                Admin.Click_PointsEarningRules_Icon_Edit();
                Logger.WriteDebugMessage("Loyalty rule popup should get displayed ");
                Admin.Enter_PointsEarningRules_Text_StartDate(DateTime.Now.AddDays(-3).ToString("MM/dd/yyyy"));
                Admin.Enter_PointsEarningRules_Text_EndDate(DateTime.Now.AddDays(-1).ToString("MM/dd/yyyy"));
                Logger.WriteDebugMessage("Updated Rule start and End Date");
                Admin.Click_PointsEarningRules_Button_Save();
                ElementWait(PageObject_Admin.PointsEarningRules_Text_Filter(), 240);
                Logger.WriteDebugMessage("Data should be updated successfully");
                Admin.Enter_PointsEarningRules_Text_Filter(name);
                AddDelay(2500);
                VerifyTextOnPageAndHighLight("Inactive");
                Logger.WriteDebugMessage("Rule got Displayed on the Page");

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, "Already Present Rule Name", name);
                Logger.LogTestData(TestPlanId, TestCaseId, "Display Name", displayName);
                Logger.LogTestData(TestPlanId, TestCaseId, "Description", description);
                Logger.LogTestData(TestPlanId, TestCaseId, "Based On", basedOn);
                Logger.LogTestData(TestPlanId, TestCaseId, "Start Date", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, "End Date", endDate);
                Logger.LogTestData(TestPlanId, TestCaseId, "Rule Type", ruleType);
                Logger.LogTestData(TestPlanId, TestCaseId, "Priority", data.Priority);
                Logger.LogTestData(TestPlanId, TestCaseId, "For", For);
                Logger.LogTestData(TestPlanId, TestCaseId, "Points Earned", pointsEarned);
                Logger.LogTestData(TestPlanId, TestCaseId, "Per", per);
                Logger.LogTestData(TestPlanId, TestCaseId, "Calculated On", calculatedOn);
                Logger.LogTestData(TestPlanId, TestCaseId, "Point Expiry", pointExpiryMonth);
                Logger.LogTestData(TestPlanId, TestCaseId, "Name Validation Message", priorityValidation, true);

            }
        }

        public static void TC_114490()
        {
            if (TestCaseId == Constants.TC_114490)
            {
                //pre-requiste
                Users data = new Users();
                Random ran = new Random();
                string name, basedOn, startDate, endDate, priority, ruleType, For, pointsEarned, per, calculatedOn, pointExpiryMonth, displayName, description, revenueType, datevalidation,  randomNumber;
                randomNumber = ran.Next().ToString();
                Queries.GetMemberLevel(data, 1);

                //Retrive data from Test data file
                name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Name"), randomNumber);
                displayName = TestData.ExcelData.TestDataReader.ReadData(1, "DisplayName");
                description = TestData.ExcelData.TestDataReader.ReadData(1, "Description");
                basedOn = TestData.ExcelData.TestDataReader.ReadData(1, "BasedOn");
                startDate = DateTime.Now.ToString("MM/dd/yyyy");
                endDate = DateTime.Now.AddDays(-12).ToString("MM/dd/yyyy");
                priority = String.Concat(DateTime.Now.Millisecond, DateTime.Now.Minute);
                ruleType = TestData.ExcelData.TestDataReader.ReadData(1, "RuleType");
                For = TestData.ExcelData.TestDataReader.ReadData(1, "For");
                pointsEarned = TestData.ExcelData.TestDataReader.ReadData(1, "PointsEarned");
                per = TestData.ExcelData.TestDataReader.ReadData(1, "Per");
                calculatedOn = TestData.ExcelData.TestDataReader.ReadData(1, "CalculatedOn");
                pointExpiryMonth = TestData.ExcelData.TestDataReader.ReadData(1, "PointExpiryMonth");
                revenueType = TestData.ExcelData.TestDataReader.ReadData(1, "RevenueType");
                datevalidation = TestData.ExcelData.TestDataReader.ReadData(1, "DateValidation");
                
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                Admin.Click_Menu_LoyaltyRules();
                Logger.WriteDebugMessage("Landed on the Loyalty Rules page");
                Admin.Click_SubTab_PointsEarningRules();
                Logger.WriteDebugMessage("Users Landed on Points Earning Rules Page");

                
                //Add New Points Earning Rule with Start date > End Date
                Admin.Click_PointsEarningRules_Button_AddRule();
                Logger.WriteDebugMessage("Loyalty rule popup should get displayed ");
                Admin.PointsEarningRule_AddRule(name, displayName, description,
                    basedOn, startDate, endDate, ruleType, priority, For,
                    pointsEarned, per, calculatedOn, revenueType, pointExpiryMonth,
                    data.MembershipLevel, ProjectName);
                Logger.WriteDebugMessage("user should be able to Enter all the fields");
                Admin.Click_PointsEarningRules_Button_Save();
                ElementWait(Driver.FindElement(By.XPath("(//*[contains(text(),'" + datevalidation + "')])[2]")), 240);
                Logger.WriteDebugMessage("Validation Message start date Less than End date got displayed");


                //Start date = end date Scenario
                Admin.Enter_PointsEarningRules_Text_EndDate(DateTime.Now.ToString("MM/dd/yyyy"));
                Logger.WriteDebugMessage("Updated End date as todays date");
                Admin.Click_PointsEarningRules_Button_Save();
                Admin.Enter_PointsEarningRules_Text_Filter(name);
                AddDelay(2500);
                VerifyTextOnPageAndHighLight(name);
                VerifyTextOnPageAndHighLight("Active");
                Logger.WriteDebugMessage("Rule got Displayed on the Page");

                //Verify Start date < end date
                Admin.Click_PointsEarningRules_Icon_Edit();
                Logger.WriteDebugMessage("Clicked on Edit button and Loyalty rule popup should get displayed ");
                Admin.Enter_PointsEarningRules_Text_EndDate(DateTime.Now.AddDays(+12).ToString("MM/dd/yyyy"));
                Logger.WriteDebugMessage("Updated End date as todays date plus 12 days");
                Admin.Click_PointsEarningRules_Button_Save();
                Admin.Enter_PointsEarningRules_Text_Filter(name);
                AddDelay(2500);
                VerifyTextOnPageAndHighLight(name);
                VerifyTextOnPageAndHighLight("Active");
                Logger.WriteDebugMessage("Rule got Displayed on the Page");

                //Inactive the Rule
                Admin.Click_PointsEarningRules_Icon_Edit();
                Logger.WriteDebugMessage("Loyalty rule popup should get displayed ");
                Admin.Enter_PointsEarningRules_Text_StartDate(DateTime.Now.AddDays(-3).ToString("MM/dd/yyyy"));
                Admin.Enter_PointsEarningRules_Text_EndDate(DateTime.Now.AddDays(-1).ToString("MM/dd/yyyy"));
                Logger.WriteDebugMessage("Updated Rule start and End Date");
                Admin.Click_PointsEarningRules_Button_Save();
                ElementWait(PageObject_Admin.PointsEarningRules_Text_Filter(), 240);
                Logger.WriteDebugMessage("Data should be updated successfully");
                Admin.Enter_PointsEarningRules_Text_Filter(name);
                AddDelay(2500);
                VerifyTextOnPageAndHighLight("Inactive");
                Logger.WriteDebugMessage("Rule got Displayed on the Page");

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, "Already Present Rule Name", name);
                Logger.LogTestData(TestPlanId, TestCaseId, "Display Name", displayName);
                Logger.LogTestData(TestPlanId, TestCaseId, "Description", description);
                Logger.LogTestData(TestPlanId, TestCaseId, "Based On", basedOn);
                Logger.LogTestData(TestPlanId, TestCaseId, "Start Date", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, "End Date", endDate);
                Logger.LogTestData(TestPlanId, TestCaseId, "Rule Type", ruleType);
                Logger.LogTestData(TestPlanId, TestCaseId, "Priority", data.Priority);
                Logger.LogTestData(TestPlanId, TestCaseId, "For", For);
                Logger.LogTestData(TestPlanId, TestCaseId, "Points Earned", pointsEarned);
                Logger.LogTestData(TestPlanId, TestCaseId, "Per", per);
                Logger.LogTestData(TestPlanId, TestCaseId, "Calculated On", calculatedOn);
                Logger.LogTestData(TestPlanId, TestCaseId, "Point Expiry", pointExpiryMonth);
                Logger.LogTestData(TestPlanId, TestCaseId, "Name Validation Message", datevalidation, true);

            }
        }

        public static void TC_224606()
        {
            if (TestCaseId == Constants.TC_224606)
            {
                //pre-requiste
                string name, basedOn, startDate, endDate, priority, ruleType, For, pointsEarned, per, calculatedOn, pointExpiryMonth, displayName, description, revenueType, randomNumber;
                Users data = new Users();
                Random ran = new Random();
                randomNumber = ran.Next().ToString();
                Queries.GetMemberLevel(data, 1);

                //Retrive data from Test data file
                name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Name"), randomNumber) ;
                displayName = TestData.ExcelData.TestDataReader.ReadData(1, "DisplayName");
                description = TestData.ExcelData.TestDataReader.ReadData(1, "Description");
                basedOn = TestData.ExcelData.TestDataReader.ReadData(1, "BasedOn");
                startDate = DateTime.Now.AddDays(-2).ToString("MM/dd/yyyy");
                endDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                priority = String.Concat(DateTime.Now.Millisecond, DateTime.Now.Minute);
                ruleType = TestData.ExcelData.TestDataReader.ReadData(1, "RuleType");
                For = TestData.ExcelData.TestDataReader.ReadData(1, "For");
                pointsEarned = TestData.ExcelData.TestDataReader.ReadData(1, "PointsEarned");
                per = TestData.ExcelData.TestDataReader.ReadData(1, "Per");
                calculatedOn = TestData.ExcelData.TestDataReader.ReadData(1, "CalculatedOn");
                pointExpiryMonth = TestData.ExcelData.TestDataReader.ReadData(1, "PointExpiryMonth");
                revenueType = TestData.ExcelData.TestDataReader.ReadData(1, "RevenueType");
                
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                Admin.Click_Menu_LoyaltyRules();
                Logger.WriteDebugMessage("Landed on the Loyalty Rules page");
                Admin.Click_SubTab_PointsEarningRules();
                Logger.WriteDebugMessage("Users Landed on Points Earning Rules Page");

                //Add New Points Earning Rule with Already Used Name
                Admin.Click_PointsEarningRules_Button_AddRule();
                Logger.WriteDebugMessage("Loyalty rule popup should get displayed ");
                Admin.PointsEarningRule_AddRule(name, displayName, description,
                    basedOn, startDate, endDate, ruleType, priority, For,
                    pointsEarned, per, calculatedOn, revenueType, pointExpiryMonth,
                    data.MembershipLevel, ProjectName);
                Logger.WriteDebugMessage("user should be able to Enter all the fields");
                Admin.Click_LoyaltyRules_PointsEarningRule_RuleRestriction();
                Logger.WriteDebugMessage("Clicked on Rule Restriction tab");
                Helper.DynamicScroll(Driver, PageObject_Admin.PointsEarningRules_Button_Save());
                if (Admin.Click_LoyaltyRules_PointsEarningRule_RuleRestriction_ChannelCodeValue() == "Nothing Selected")
                    Logger.WriteDebugMessage("Channel code is blank");
                Admin.Click_PointsEarningRules_Button_Save();
                Admin.Enter_PointsEarningRules_Text_Filter(name);
                AddDelay(2500);
                VerifyTextOnPageAndHighLight(name);
                Logger.WriteDebugMessage("Rule got Displayed on the Page");

                Queries.GetRuleByName(data, name);
                Queries.GetRulewithChannelCode(data, data.RuleId);
                if (data.RuleIncluded == null)
                    Logger.WriteDebugMessage("Rule does not present on LoyaltyRuleInclExclChannelCodes table");
                else
                    Assert.Fail("Rule got present on LoyaltyRuleInclExclChannelCodes table");

                //Inactive the Rule
                Admin.Click_PointsEarningRules_Icon_Edit();
                Logger.WriteDebugMessage("Loyalty rule popup should get displayed ");
                Admin.Enter_PointsEarningRules_Text_StartDate(DateTime.Now.AddDays(-3).ToString("MM/dd/yyyy"));
                Admin.Enter_PointsEarningRules_Text_EndDate(DateTime.Now.AddDays(-1).ToString("MM/dd/yyyy"));
                Logger.WriteDebugMessage("Updated Rule start and End Date");
                Admin.Click_PointsEarningRules_Button_Save();
                ElementWait(PageObject_Admin.PointsEarningRules_Text_Filter(), 240);
                Logger.WriteDebugMessage("Data should be updated successfully");
                Admin.Enter_PointsEarningRules_Text_Filter(name);
                AddDelay(2500);
                VerifyTextOnPageAndHighLight("Inactive");
                Logger.WriteDebugMessage("Rule got Displayed on the Page");

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, "Already Present Rule Name", name);
                Logger.LogTestData(TestPlanId, TestCaseId, "Display Name", displayName);
                Logger.LogTestData(TestPlanId, TestCaseId, "Description", description);
                Logger.LogTestData(TestPlanId, TestCaseId, "Based On", basedOn);
                Logger.LogTestData(TestPlanId, TestCaseId, "Start Date", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, "End Date", endDate);
                Logger.LogTestData(TestPlanId, TestCaseId, "Rule Type", ruleType);
                Logger.LogTestData(TestPlanId, TestCaseId, "Priority", priority);
                Logger.LogTestData(TestPlanId, TestCaseId, "For", For);
                Logger.LogTestData(TestPlanId, TestCaseId, "Points Earned", pointsEarned);
                Logger.LogTestData(TestPlanId, TestCaseId, "Per", per);
                Logger.LogTestData(TestPlanId, TestCaseId, "Calculated On", calculatedOn);
                Logger.LogTestData(TestPlanId, TestCaseId, "Point Expiry", pointExpiryMonth, true);
                

            }
        }
        public static void TC_188991()
        {
            if (TestCaseId == Constants.TC_188991)
            {
                //pre-requiste
                string name, basedOn, startDate, endDate, priority, ruleType, For, pointsEarned, per, calculatedOn, pointExpiryMonth, displayName, description, revenueType, calculatedOnValidation;
                Users data = new Users();
                Queries.GetMemberLevel(data, 1);
                Random ran = new Random();

                //Retrive data from Test data file
                name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Name"), ran.Next().ToString());
                displayName = TestData.ExcelData.TestDataReader.ReadData(1, "DisplayName");
                description = TestData.ExcelData.TestDataReader.ReadData(1, "Description");
                basedOn = TestData.ExcelData.TestDataReader.ReadData(1, "BasedOn");
                startDate = DateTime.Now.AddDays(-2).ToString("MM/dd/yyyy");
                endDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                priority = String.Concat(DateTime.Now.Millisecond, DateTime.Now.Minute);
                ruleType = TestData.ExcelData.TestDataReader.ReadData(1, "RuleType");
                For = TestData.ExcelData.TestDataReader.ReadData(1, "For");
                pointsEarned = TestData.ExcelData.TestDataReader.ReadData(1, "PointsEarned");
                per = TestData.ExcelData.TestDataReader.ReadData(1, "Per");
                calculatedOn = TestData.ExcelData.TestDataReader.ReadData(1, "CalculatedOn");
                pointExpiryMonth = TestData.ExcelData.TestDataReader.ReadData(1, "PointExpiryMonth");
                revenueType = TestData.ExcelData.TestDataReader.ReadData(1, "RevenueType");
                calculatedOnValidation = TestData.ExcelData.TestDataReader.ReadData(1, "CalculatedOnValidation");

                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                Admin.Click_Menu_LoyaltyRules();
                Logger.WriteDebugMessage("Landed on the Loyalty Rules page");
                Admin.Click_SubTab_PointsEarningRules();
                Logger.WriteDebugMessage("Users Landed on Points Earning Rules Page");

             
                //Add New Points Earning Rule and verify the Validation Messagge when Calculated on is Revenue
                Admin.Click_PointsEarningRules_Button_AddRule();
                Logger.WriteDebugMessage("Loyalty rule popup should get displayed ");
                Admin.PointsEarningRule_AddRule(name, displayName, description,
                    basedOn, startDate, endDate, ruleType, priority, For,
                    pointsEarned, per, calculatedOn, "Please Select", pointExpiryMonth,
                    data.MembershipLevel, ProjectName);
                Logger.WriteDebugMessage("user should be able to Enter all the fields");
                Admin.Click_PointsEarningRules_Button_Save();
                ElementWait(Driver.FindElement(By.XPath("//*[contains(text(),'" + calculatedOnValidation + "')]")), 240);
                VerifyTextOnPageAndHighLight(calculatedOnValidation);
                Logger.WriteDebugMessage("Validation Message for Duplicate Name got displayed");

                //Verify the Validation does not appear when Stay
                Admin.Select_PointsEarningRules_Dropdown_CalculatedOn("Stay/Night");
                Logger.WriteDebugMessage("Updated Calculated on Field as Stay");
                Admin.Click_PointsEarningRules_Button_Save();
                ElementWait(PageObject_Admin.PointsEarningRules_Text_Filter(), 240);
                Logger.WriteDebugMessage("Data should be updated successfully");
                Admin.Enter_PointsEarningRules_Text_Filter(name);
                AddDelay(2500);
                VerifyTextOnPageAndHighLight(name);
                Logger.WriteDebugMessage("Rule got Displayed on the Page");

                //Inactive the Rule
                Admin.Click_PointsEarningRules_Icon_Edit();
                Logger.WriteDebugMessage("Loyalty rule popup should get displayed ");
                Admin.Enter_PointsEarningRules_Text_StartDate(DateTime.Now.AddDays(-3).ToString("MM/dd/yyyy"));
                Admin.Enter_PointsEarningRules_Text_EndDate(DateTime.Now.AddDays(-1).ToString("MM/dd/yyyy"));
                Logger.WriteDebugMessage("Updated Rule start and End Date");
                Admin.Click_PointsEarningRules_Button_Save();
                ElementWait(PageObject_Admin.PointsEarningRules_Text_Filter(), 240);
                Logger.WriteDebugMessage("Data should be updated successfully");
                Admin.Enter_PointsEarningRules_Text_Filter(name);
                AddDelay(2500);
                VerifyTextOnPageAndHighLight("Inactive");
                Logger.WriteDebugMessage("Rule got Displayed on the Page");

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, "Already Present Rule Name", name);
                Logger.LogTestData(TestPlanId, TestCaseId, "Display Name", displayName);
                Logger.LogTestData(TestPlanId, TestCaseId, "Description", description);
                Logger.LogTestData(TestPlanId, TestCaseId, "Based On", basedOn);
                Logger.LogTestData(TestPlanId, TestCaseId, "Start Date", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, "End Date", endDate);
                Logger.LogTestData(TestPlanId, TestCaseId, "Rule Type", ruleType);
                Logger.LogTestData(TestPlanId, TestCaseId, "Priority", priority);
                Logger.LogTestData(TestPlanId, TestCaseId, "For", For);
                Logger.LogTestData(TestPlanId, TestCaseId, "Points Earned", pointsEarned);
                Logger.LogTestData(TestPlanId, TestCaseId, "Per", per);
                Logger.LogTestData(TestPlanId, TestCaseId, "Calculated On", calculatedOn);
                Logger.LogTestData(TestPlanId, TestCaseId, "Point Expiry", pointExpiryMonth);
                Logger.LogTestData(TestPlanId, TestCaseId, "Name Validation Message", calculatedOnValidation, true);

            }
        }
        public static void TC_113457()
        {
            if (TestCaseId == Constants.TC_113457)
            {
                //pre-requiste
                string name, basedOn, startDate, endDate, priority, ruleType, For, pointsEarned, per, calculatedOn, pointExpiryMonth, displayName, description, revenueType, titleValidation;
                Users data = new Users();
                Queries.GetMemberLevel(data, 1);
                Random ran = new Random();

                //Retrive data from Test data file
                name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Name"), ran.Next().ToString());
                displayName = TestData.ExcelData.TestDataReader.ReadData(1, "DisplayName");
                description = TestData.ExcelData.TestDataReader.ReadData(1, "Description");
                basedOn = TestData.ExcelData.TestDataReader.ReadData(1, "BasedOn");
                startDate = DateTime.Now.AddDays(-2).ToString("MM/dd/yyyy");
                endDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                priority = String.Concat(DateTime.Now.Millisecond, DateTime.Now.Minute);
                ruleType = TestData.ExcelData.TestDataReader.ReadData(1, "RuleType");
                For = TestData.ExcelData.TestDataReader.ReadData(1, "For");
                pointsEarned = TestData.ExcelData.TestDataReader.ReadData(1, "PointsEarned");
                per = TestData.ExcelData.TestDataReader.ReadData(1, "Per");
                calculatedOn = TestData.ExcelData.TestDataReader.ReadData(1, "CalculatedOn");
                pointExpiryMonth = TestData.ExcelData.TestDataReader.ReadData(1, "PointExpiryMonth");
                revenueType = TestData.ExcelData.TestDataReader.ReadData(1, "RevenueType");
                titleValidation = TestData.ExcelData.TestDataReader.ReadData(1, "TitleValidation");

                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                Admin.Click_Menu_LoyaltyRules();
                Logger.WriteDebugMessage("Landed on the Loyalty Rules page");
                Admin.Click_SubTab_PointsEarningRules();
                Logger.WriteDebugMessage("Users Landed on Points Earning Rules Page");

                //Add New Points Earning Rule and click on save
                Admin.Click_PointsEarningRules_Button_AddRule();
                Logger.WriteDebugMessage("Loyalty rule popup should get displayed ");
                Admin.PointsEarningRule_AddRule(name, displayName, description,
                    basedOn, startDate, endDate, ruleType, priority, For,
                    pointsEarned, per, calculatedOn, revenueType, pointExpiryMonth,
                    data.MembershipLevel, ProjectName);
                Logger.WriteDebugMessage("user should be able to Enter all the fields");
                Admin.Click_PointsEarningRules_Button_Save();
                Logger.WriteDebugMessage("Saved Successfully");

                //Navigated back to Loyalty Rule tab and select any existing rule 
                Queries.GetLoyaltyRules(data, "1", "Awards");
                Admin.Enter_PointsEarningRules_Text_Filter(data.RuleName);
                string gridName = PageObject_Admin.Get_PointsEarningRule_GridName().GetAttribute("innerHTML");
                Logger.WriteDebugMessage("Existing Rule got displaying on Grid");
                Admin.Click_PointsEarningRules_Icon_Edit();
                Logger.WriteDebugMessage("Edit Overlay got Displayed");
                Admin.Enter_PointsEarningRules_Text_Name(name);
                Logger.WriteDebugMessage("User should be able to edit title");
                Admin.Click_PointsEarningRules_Button_Save();
                VerifyTextOnPageAndHighLight(titleValidation);
                Logger.WriteDebugMessage(titleValidation + "= Validation message displaying on the page");

                //Close the Overlay
                Admin.Enter_PointsEarningRules_Text_Name(gridName);
                Logger.WriteDebugMessage("Name update as before");
                Admin.Click_PointsEarningRules_Button_Cancel();
                ElementWait(PageObject_Admin.PointsEarningRules_Text_Filter(), 240);
                Logger.WriteDebugMessage("Overlay got  closed");

                //Update the Rule with Past date, so that it will not impact on Testing
                Admin.Enter_PointsEarningRules_Text_Filter(name);
                Logger.WriteDebugMessage("Added Award got displayed");
                Admin.Click_PointsEarningRules_Icon_Edit();
                Logger.WriteDebugMessage("Loyalty rule popup should get displayed ");
                Admin.Enter_PointsEarningRules_Text_EndDate(DateTime.Now.AddDays(-1).ToString("MM/dd/yyyy"));
                Logger.WriteDebugMessage("Updated Rule End Date");
                Admin.Click_PointsEarningRules_Button_Save();
                ElementWait(PageObject_Admin.PointsEarningRules_Text_Filter(), 240);
                Logger.WriteDebugMessage("Data should be updated successfully");
                Admin.Enter_PointsEarningRules_Text_Filter(name);
                AddDelay(2500);
                VerifyTextOnPageAndHighLight("Inactive");
                Logger.WriteDebugMessage("Rule got Displayed on the Page and Status is Inactive now");


                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, "Already Present Rule Name", name);
                Logger.LogTestData(TestPlanId, TestCaseId, "Display Name", displayName);
                Logger.LogTestData(TestPlanId, TestCaseId, "Description", description);
                Logger.LogTestData(TestPlanId, TestCaseId, "Based On", basedOn);
                Logger.LogTestData(TestPlanId, TestCaseId, "Start Date", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, "End Date", endDate);
                Logger.LogTestData(TestPlanId, TestCaseId, "Rule Type", ruleType);
                Logger.LogTestData(TestPlanId, TestCaseId, "Priority", priority);
                Logger.LogTestData(TestPlanId, TestCaseId, "For", For);
                Logger.LogTestData(TestPlanId, TestCaseId, "Points Earned", pointsEarned);
                Logger.LogTestData(TestPlanId, TestCaseId, "Per", per);
                Logger.LogTestData(TestPlanId, TestCaseId, "Calculated On", calculatedOn);
                Logger.LogTestData(TestPlanId, TestCaseId, "Point Expiry", pointExpiryMonth);
                Logger.LogTestData(TestPlanId, TestCaseId, "Revenue Type", revenueType);
                Logger.LogTestData(TestPlanId, TestCaseId, "Title Validation Message", titleValidation, true);

            }
        }
        public static void TC_116140()
        {
            if (TestCaseId == Constants.TC_116140)
            {
                //pre-requiste
                string name, basedOn, startDate, endDate, priority, ruleType, For, pointsEarned, per, calculatedOn, pointExpiryMonth, displayName, description, revenueType, priorityValidation;
                Users data = new Users();
                Queries.GetMemberLevel(data, 1);
                Random ran = new Random();

                //Retrive data from Test data file
                name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Name"), ran.Next().ToString());
                displayName = TestData.ExcelData.TestDataReader.ReadData(1, "DisplayName");
                description = TestData.ExcelData.TestDataReader.ReadData(1, "Description");
                basedOn = TestData.ExcelData.TestDataReader.ReadData(1, "BasedOn");
                startDate = DateTime.Now.AddDays(-2).ToString("MM/dd/yyyy");
                endDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                priority = String.Concat(DateTime.Now.Millisecond, DateTime.Now.Minute).Substring(0, 1);
                ruleType = TestData.ExcelData.TestDataReader.ReadData(1, "RuleType");
                For = TestData.ExcelData.TestDataReader.ReadData(1, "For");
                pointsEarned = TestData.ExcelData.TestDataReader.ReadData(1, "PointsEarned");
                per = TestData.ExcelData.TestDataReader.ReadData(1, "Per");
                calculatedOn = TestData.ExcelData.TestDataReader.ReadData(1, "CalculatedOn");
                pointExpiryMonth = TestData.ExcelData.TestDataReader.ReadData(1, "PointExpiryMonth");
                revenueType = TestData.ExcelData.TestDataReader.ReadData(1, "RevenueType");
                priorityValidation = TestData.ExcelData.TestDataReader.ReadData(1, "PriorityValidation");

                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                Admin.Click_Menu_LoyaltyRules();
                Logger.WriteDebugMessage("Landed on the Loyalty Rules page");
                Admin.Click_SubTab_PointsEarningRules();
                Logger.WriteDebugMessage("Users Landed on Points Earning Rules Page");

                //Add New Points Earning Rule and click on save
                Admin.Click_PointsEarningRules_Button_AddRule();
                Logger.WriteDebugMessage("Loyalty rule popup should get displayed ");
                Admin.PointsEarningRule_AddRule(name, displayName, description,
                    basedOn, startDate, endDate, ruleType, priority, For,
                    pointsEarned, per, calculatedOn, revenueType, pointExpiryMonth,
                    data.MembershipLevel, ProjectName);
                Logger.WriteDebugMessage("user should be able to Enter all the fields");
                Admin.Click_PointsEarningRules_Button_Save();
                Helper.ElementWait(PageObject_Admin.PointsEarningRules_Text_Filter(), 240);
                Logger.WriteDebugMessage("Saved Successfully");

                //Navigated back to Loyalty Rule tab, select any existing rule
                Queries.GetLoyaltyRules(data, "1", "Points");
                Admin.Enter_PointsEarningRules_Text_Filter(data.RuleName);
                string gridPriority = PageObject_Admin.Get_PointsEarningRule_GridPriority().GetAttribute("innerHTML");
                Logger.WriteDebugMessage("Existing Rule got dispayed on the grid");
                Admin.Click_PointsEarningRules_Icon_Edit();
                Logger.WriteDebugMessage("Edit Overlay got displayed on the Page");
                Admin.Enter_PointsEarningRules_Text_Priority(priority);
                Logger.WriteDebugMessage("User should be able to edit priority");
                Admin.Click_PointsEarningRules_Button_Save();
                VerifyTextOnPageAndHighLight(priorityValidation);
                Logger.WriteDebugMessage(priorityValidation + "= Validation message displaying on the page");

                //Update priority to as it was before 
                Admin.Enter_PointsEarningRules_Text_Priority(gridPriority);
                Logger.WriteDebugMessage("Priority updated as before");
                Admin.Click_PointsEarningRules_Button_Save();
                Helper.ElementWait(PageObject_Admin.PointsEarningRules_Text_Filter(), 240);
                Logger.WriteDebugMessage("Saved successfully");

                ///Update the Rule with Past date, so that it will not impact on Testing
                Admin.Enter_PointsEarningRules_Text_Filter(name);
                Logger.WriteDebugMessage("Added Rule got displayed on the Page");
                Admin.Click_PointsEarningRules_Icon_Edit();
                Logger.WriteDebugMessage("Loyalty rule popup should get displayed ");
                Admin.Enter_PointsEarningRules_Text_EndDate(DateTime.Now.AddDays(-1).ToString("MM/dd/yyyy"));
                Logger.WriteDebugMessage("Updated Rule End Date");
                Admin.Click_PointsEarningRules_Button_Save();
                ElementWait(PageObject_Admin.PointsEarningRules_Text_Filter(), 240);
                Logger.WriteDebugMessage("Data should be updated successfully");
                Admin.Enter_PointsEarningRules_Text_Filter(name);
                AddDelay(2500);
                VerifyTextOnPageAndHighLight("Inactive");
                Logger.WriteDebugMessage("Rule got Displayed on the Page and Status is Inactive now");

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, "Already Present Rule Name", name);
                Logger.LogTestData(TestPlanId, TestCaseId, "Display Name", displayName);
                Logger.LogTestData(TestPlanId, TestCaseId, "Description", description);
                Logger.LogTestData(TestPlanId, TestCaseId, "Based On", basedOn);
                Logger.LogTestData(TestPlanId, TestCaseId, "Start Date", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, "End Date", endDate);
                Logger.LogTestData(TestPlanId, TestCaseId, "Rule Type", ruleType);
                Logger.LogTestData(TestPlanId, TestCaseId, "Priority", priority);
                Logger.LogTestData(TestPlanId, TestCaseId, "For", For);
                Logger.LogTestData(TestPlanId, TestCaseId, "Points Earned", pointsEarned);
                Logger.LogTestData(TestPlanId, TestCaseId, "Per", per);
                Logger.LogTestData(TestPlanId, TestCaseId, "Calculated On", calculatedOn);
                Logger.LogTestData(TestPlanId, TestCaseId, "Point Expiry", pointExpiryMonth);
                Logger.LogTestData(TestPlanId, TestCaseId, "Revenue Type", revenueType);
                Logger.LogTestData(TestPlanId, TestCaseId, "Priority Validation Message", priorityValidation, true);

            }
        }
       
        public static void TC_113454()
        {
            if (TestCaseId == Constants.TC_113454)
            {
                //Pre-requites
                string name, basedOn, startDate, endDate, inactiveStartDate, status, inactiveEndDate, priority, ruleType, For, pointsEarned, per, calculatedOn, pointExpiryMonth, displayName, description, revenueType;
                Users data = new Users();
                Queries.GetMemberLevel(data, 1);
                Queries.GetLoyaltyRules(data, "1", "Points");
                Random ran = new Random();

                //Retrieve data from Test data file
                name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Name"), ran.Next().ToString());
                displayName = TestData.ExcelData.TestDataReader.ReadData(1, "DisplayName");
                description = TestData.ExcelData.TestDataReader.ReadData(1, "Description");
                basedOn = TestData.ExcelData.TestDataReader.ReadData(1, "BasedOn");
                startDate = DateTime.Now.AddDays(-2).ToString("MM/dd/yyyy");
                endDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                inactiveStartDate = DateTime.Now.AddDays(-4).ToString("MM/dd/yyyy");
                inactiveEndDate = DateTime.Now.AddDays(-3).ToString("MM/dd/yyyy");
                priority = String.Concat(DateTime.Now.Millisecond, DateTime.Now.Minute);
                ruleType = TestData.ExcelData.TestDataReader.ReadData(1, "RuleType");
                For = TestData.ExcelData.TestDataReader.ReadData(1, "For");
                pointsEarned = TestData.ExcelData.TestDataReader.ReadData(1, "PointsEarned");
                per = TestData.ExcelData.TestDataReader.ReadData(1, "Per");
                calculatedOn = TestData.ExcelData.TestDataReader.ReadData(1, "CalculatedOn");
                pointExpiryMonth = TestData.ExcelData.TestDataReader.ReadData(1, "PointExpiryMonth");
                revenueType = TestData.ExcelData.TestDataReader.ReadData(1, "RevenueType");
                status = TestData.ExcelData.TestDataReader.ReadData(1, "Status");

                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                Admin.Click_Menu_LoyaltyRules();
                Logger.WriteDebugMessage("Landed on the Loyalty Rules page");
                Admin.Click_SubTab_PointsEarningRules();
                Logger.WriteDebugMessage("Users Landed on Points Earning Rules Page");


                //Add Any Rule
                Admin.Click_PointsEarningRules_Button_AddRule();
                Logger.WriteDebugMessage("Loyalty rule popup should get displayed ");
                Admin.PointsEarningRule_AddRule(name, displayName, description,
                    basedOn, startDate, endDate, ruleType, priority, For,
                    pointsEarned, per, calculatedOn, revenueType, pointExpiryMonth,
                    data.MembershipLevel, ProjectName);
                Logger.WriteDebugMessage("user should be able to Enter all the fields");
                Admin.Click_PointsEarningRules_Button_Save();
                Logger.WriteDebugMessage("Validation Message start date Less than End date got displayed");

                // Select any existing rule whose status is Active and update name and display name
                Admin.Enter_PointsEarningRules_Text_Filter(name);
                Logger.WriteDebugMessage("Existing Rule got displayed on the grid");
                Admin.Click_PointsEarningRules_Icon_Edit();
                Logger.WriteDebugMessage("Edit Rule overlay got displayed");
                Admin.Enter_PointsEarningRules_Text_Name(name+"_Edit");
                Admin.Enter_PointsEarningRules_Text_DisplayName(displayName + "_Edit");
                Logger.WriteDebugMessage("User should be able to edit Name and Display name");
                Admin.Click_PointsEarningRules_Button_Save();
                if (PageObject_Admin.PointsEarningRules_Button_Save().Displayed)
                    Assert.Fail("Changes are not saved");
                else
                    Logger.WriteDebugMessage("Changes are saved successfully");
                
                //Update the Existing Rule
                Admin.Enter_PointsEarningRules_Text_Filter(name + "_Edit");
                Logger.WriteDebugMessage("Rule got Displayed on the Page");
                Admin.Click_PointsEarningRules_Icon_Edit();
                Logger.WriteDebugMessage("Name and display name updated");

                //Retrive another test data
                Queries.GetMemberLevel(data, 2);
                basedOn = TestData.ExcelData.TestDataReader.ReadData(2, "BasedOn");
                ruleType = TestData.ExcelData.TestDataReader.ReadData(2, "RuleType");
                For = TestData.ExcelData.TestDataReader.ReadData(2, "For");
                pointsEarned = TestData.ExcelData.TestDataReader.ReadData(2, "PointsEarned");
                per = TestData.ExcelData.TestDataReader.ReadData(2, "Per");
                calculatedOn = TestData.ExcelData.TestDataReader.ReadData(2, "CalculatedOn");
                pointExpiryMonth = TestData.ExcelData.TestDataReader.ReadData(2, "PointExpiryMonth");
                revenueType = TestData.ExcelData.TestDataReader.ReadData(2, "RevenueType");
                
                //Verify User is able to update Description/Priority/For/Points Earned/Per?/Based On/Points Expiry Month/Points Expiry Month/Include Member Level
                Admin.PointsEarningRule_AddRule(name + "_Edit", displayName + "_Edit", description + "_Edit",
                    basedOn, startDate, endDate, ruleType, priority, For,
                    pointsEarned, per, calculatedOn, revenueType, pointExpiryMonth,
                    data.MembershipLevel, ProjectName);
                Logger.WriteDebugMessage("user should be able to Enter all the fields");
                Admin.Click_PointsEarningRules_Button_Save();
                Logger.WriteDebugMessage("Saved Successfully");

                //Verify the User is able to modify the date (Start date and End date) such that rule becomes inactive
                Admin.Enter_PointsEarningRules_Text_Filter(name + "_Edit");
                Admin.Click_PointsEarningRules_Icon_Edit();
                Logger.WriteDebugMessage("Details updated successfully");
                Admin.Enter_PointsEarningRules_Text_StartDate(inactiveStartDate);
                Admin.Enter_PointsEarningRules_Text_EndDate(inactiveEndDate);
                Logger.WriteDebugMessage("Start date and End date selected as past date");
                Admin.Click_PointsEarningRules_Button_Save();
                Logger.WriteDebugMessage("Saved Successfully");
                Admin.Enter_PointsEarningRules_Text_Filter(name + "_Edit");
                VerifyTextOnPageAndHighLight(status);
                Logger.WriteDebugMessage(status + "= Status updated as Inactive");

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, "Already Present Rule Name", name);
                Logger.LogTestData(TestPlanId, TestCaseId, "Display Name", displayName);
                Logger.LogTestData(TestPlanId, TestCaseId, "Description", description);
                Logger.LogTestData(TestPlanId, TestCaseId, "Based On", basedOn);
                Logger.LogTestData(TestPlanId, TestCaseId, "Start Date", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, "End Date", endDate);
                Logger.LogTestData(TestPlanId, TestCaseId, "Rule Type", ruleType);
                Logger.LogTestData(TestPlanId, TestCaseId, "Priority", priority);
                Logger.LogTestData(TestPlanId, TestCaseId, "For", For);
                Logger.LogTestData(TestPlanId, TestCaseId, "Points Earned", pointsEarned);
                Logger.LogTestData(TestPlanId, TestCaseId, "Per", per);
                Logger.LogTestData(TestPlanId, TestCaseId, "Calculated On", calculatedOn);
                Logger.LogTestData(TestPlanId, TestCaseId, "Point Expiry", pointExpiryMonth);
                Logger.LogTestData(TestPlanId, TestCaseId, "Revenue Type", revenueType);
                Logger.LogTestData(TestPlanId, TestCaseId, "Status", status, true);

            }
        }
        public static void TC_116328()
        {
            if (TestCaseId == Constants.TC_116328)
            {
                //Pre-requites
                string name, basedOn, startDate, endDate, status, priority, ruleType, For, pointsEarned, per, calculatedOn, pointExpiryMonth, displayName, description, revenueType;
                Users data = new Users();
                Queries.GetMemberLevel(data, 1);
                Random ran = new Random();

                //Retrieve data from Test data file
                name = String.Concat(TestData.ExcelData.TestDataReader.ReadData(1, "Name"), ran.Next().ToString());
                displayName = TestData.ExcelData.TestDataReader.ReadData(1, "DisplayName");
                description = TestData.ExcelData.TestDataReader.ReadData(1, "Description");
                basedOn = TestData.ExcelData.TestDataReader.ReadData(1, "BasedOn");
                startDate = DateTime.Now.AddDays(3).ToString("MM/dd/yyyy");
                endDate = DateTime.Now.AddDays(4).ToString("MM/dd/yyyy");
                priority = String.Concat(DateTime.Now.Millisecond, DateTime.Now.Minute);
                ruleType = TestData.ExcelData.TestDataReader.ReadData(1, "RuleType");
                For = TestData.ExcelData.TestDataReader.ReadData(1, "For");
                pointsEarned = TestData.ExcelData.TestDataReader.ReadData(1, "PointsEarned");
                per = TestData.ExcelData.TestDataReader.ReadData(1, "Per");
                calculatedOn = TestData.ExcelData.TestDataReader.ReadData(1, "CalculatedOn");
                pointExpiryMonth = TestData.ExcelData.TestDataReader.ReadData(1, "PointExpiryMonth");
                revenueType = TestData.ExcelData.TestDataReader.ReadData(1, "RevenueType");
                status = TestData.ExcelData.TestDataReader.ReadData(1, "Status");

                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                Admin.Click_Menu_LoyaltyRules();
                Logger.WriteDebugMessage("Landed on the Loyalty Rules page");
                Admin.Click_SubTab_PointsEarningRules();
                Logger.WriteDebugMessage("Users Landed on Points Earning Rules Page");

                //Add Any Rule
                Admin.Click_PointsEarningRules_Button_AddRule();
                Logger.WriteDebugMessage("Loyalty rule popup should get displayed ");
                Admin.PointsEarningRule_AddRule(name, displayName, description,
                    basedOn, startDate, endDate, ruleType, priority, For,
                    pointsEarned, per, calculatedOn, revenueType, pointExpiryMonth,
                    data.MembershipLevel, ProjectName);
                Logger.WriteDebugMessage("user should be able to Enter all the fields");
                Admin.Click_PointsEarningRules_Button_Save();
                Logger.WriteDebugMessage("Rule got added successfully");

                // Select any existing rule whose status is Scheduled and update name and display name
                Admin.Enter_PointsEarningRules_Text_Filter(name);
                VerifyTextOnPageAndHighLight("Scheduled");
                Logger.WriteDebugMessage("Schedule Rule got displayed on the Page");
                Admin.Click_PointsEarningRules_Icon_Edit();
                Logger.WriteDebugMessage("Edit Overlay got displayed");
                Admin.Enter_PointsEarningRules_Text_Name(name+"_edit");
                Admin.Enter_PointsEarningRules_Text_DisplayName(displayName + "_edit");
                Logger.WriteDebugMessage("User should be able to edit Name and Display name");
                Admin.Click_PointsEarningRules_Button_Save();
                if (PageObject_Admin.PointsEarningRules_Button_Save().Displayed)
                    Assert.Fail("Changes are not saved");
                else
                    Logger.WriteDebugMessage("Changes are saved successfully");

                Admin.Enter_PointsEarningRules_Text_Filter(name + "_edit");
                Logger.WriteDebugMessage("Edited Rule got displayed on the Page");
                Admin.Click_PointsEarningRules_Icon_Edit();
                Logger.WriteDebugMessage("Name and display name updated");

                //Verify User is able to update Description/Priority/For/Points Earned/Per?/Based On/Points Expiry Month/Points Expiry Month/Include Member Level
                Queries.GetMemberLevel(data, 2);
                basedOn = TestData.ExcelData.TestDataReader.ReadData(2, "BasedOn");
                ruleType = TestData.ExcelData.TestDataReader.ReadData(2, "RuleType");
                For = TestData.ExcelData.TestDataReader.ReadData(2, "For");
                pointsEarned = TestData.ExcelData.TestDataReader.ReadData(2, "PointsEarned");
                per = TestData.ExcelData.TestDataReader.ReadData(2, "Per");
                calculatedOn = TestData.ExcelData.TestDataReader.ReadData(2, "CalculatedOn");
                pointExpiryMonth = TestData.ExcelData.TestDataReader.ReadData(2, "PointExpiryMonth");
                revenueType = TestData.ExcelData.TestDataReader.ReadData(2, "RevenueType");
                startDate = DateTime.Now.AddDays(-2).ToString("MM/dd/yyyy"); ;
                endDate = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy"); ;

                Admin.PointsEarningRule_AddRule(name+"_EditName", displayName + "_EditName", description + "_EditName",
                    basedOn, startDate, endDate, ruleType, priority, For,
                    pointsEarned, per, calculatedOn, revenueType, pointExpiryMonth,
                    data.MembershipLevel, ProjectName);
                Logger.WriteDebugMessage("user should be able to Enter all the fields");
                Admin.Click_PointsEarningRules_Button_Save();
                Logger.WriteDebugMessage("Saved Successfully");

                //Verify the User is able to modify the date (Start date and End date) such that rule becomes inactive
                Admin.Enter_PointsEarningRules_Text_Filter(name + "_EditName");
                VerifyTextOnPageAndHighLight(status);
                Logger.WriteDebugMessage("Edited Rule got Displayed on the Page");
                Admin.Click_PointsEarningRules_Icon_Edit();
                Logger.WriteDebugMessage("Edit Overlay got displayed");
                startDate = DateTime.Now.AddDays(-2).ToString("MM/dd/yyyy"); ;
                endDate = DateTime.Now.AddDays(-1).ToString("MM/dd/yyyy"); ;
                Admin.Enter_PointsEarningRules_Text_StartDate(startDate);
                Admin.Enter_PointsEarningRules_Text_EndDate(endDate);
                Logger.WriteDebugMessage("Start date and End date selected as present date");
                Admin.Click_PointsEarningRules_Button_Save();
                Logger.WriteDebugMessage("Saved Successfully");
                Admin.Enter_PointsEarningRules_Text_Filter(name);
                VerifyTextOnPageAndHighLight("Inactive");
                Logger.WriteDebugMessage(status + "= Status updated as Active");

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, "Already Present Rule Name", name);
                Logger.LogTestData(TestPlanId, TestCaseId, "Display Name", displayName);
                Logger.LogTestData(TestPlanId, TestCaseId, "Description", description);
                Logger.LogTestData(TestPlanId, TestCaseId, "Based On", basedOn);
                Logger.LogTestData(TestPlanId, TestCaseId, "Start Date", startDate);
                Logger.LogTestData(TestPlanId, TestCaseId, "End Date", endDate);
                Logger.LogTestData(TestPlanId, TestCaseId, "Rule Type", ruleType);
                Logger.LogTestData(TestPlanId, TestCaseId, "Priority", priority);
                Logger.LogTestData(TestPlanId, TestCaseId, "For", For);
                Logger.LogTestData(TestPlanId, TestCaseId, "Points Earned", pointsEarned);
                Logger.LogTestData(TestPlanId, TestCaseId, "Per", per);
                Logger.LogTestData(TestPlanId, TestCaseId, "Calculated On", calculatedOn);
                Logger.LogTestData(TestPlanId, TestCaseId, "Point Expiry", pointExpiryMonth);
                Logger.LogTestData(TestPlanId, TestCaseId, "Revenue Type", revenueType);
                Logger.LogTestData(TestPlanId, TestCaseId, "Status", status, true);

            }
        }
        public static void TC_116329()
        {
            if (TestCaseId == Constants.TC_116329)
            {

                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                Admin.Click_Menu_LoyaltyRules();
                Logger.WriteDebugMessage("Landed on the Loyalty Rules page");
                Admin.Click_SubTab_PointsEarningRules();
                Logger.WriteDebugMessage("Users Landed on Points Earning Rules Page");

                // Select any existing rule whose status is Inactive and verify 
                Admin.Enter_PointsEarningRules_Text_Filter("Inactive");
                VerifyTextOnPageAndHighLight("Inactive");
               Logger.WriteDebugMessage("Rule Got Displayed on the Page");
                Admin.Click_PointsEarningRules_Icon_Edit();
                Logger.WriteDebugMessage("Edit button clicked");
                if (PageObject_Admin.PointsEarningRules_Text_Name().Enabled && PageObject_Admin.PointsEarningRules_Text_DisplayName().Enabled && PageObject_Admin.PointsEarningRules_Text_Description().Enabled && PageObject_Admin.PointsEarningRules_Text_StartDate().Enabled && PageObject_Admin.PointsEarningRules_Text_EndDate().Enabled)
                    Assert.Fail("Rule Fields are enabled and editable");
                else
                    Logger.WriteDebugMessage("Name field is disabled");
               }
        }
        public static void TC_219503()
        {
            if (TestCaseId == Constants.TC_219503)
            {
                //Pre-requites
                string priority, oldpriority, validationMessage;
                Users data = new Users();
               
                //Retrieve data from Test data file
                priority = String.Concat(DateTime.Now.Millisecond, DateTime.Now.Minute);
                validationMessage = TestData.ExcelData.TestDataReader.ReadData(1, "ValidationMessage");
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                Admin.Click_Menu_LoyaltyRules();
                Logger.WriteDebugMessage("Landed on the Loyalty Rules page");
                Admin.Click_SubTab_PointsEarningRules();
                Logger.WriteDebugMessage("Users Landed on Points Earning Rules Page");

                //Update Priority for Active Rule with existing inactive rule Priority
                Queries.GetLoyaltyRules(data, "0", "Points");
                Admin.Enter_PointsEarningRules_Text_Filter(data.RuleName);
                VerifyTextOnPageAndHighLight(data.RuleName);
                VerifyTextOnPageAndHighLight(data.Priority);
                oldpriority = data.Priority;
                Logger.WriteDebugMessage("Inactive Rule with Priority got displayed");

                // Select any existing rule whose status is Active and Verify User is able to update Priority
                Queries.GetLoyaltyRules(data, "1", "Points");
                Admin.Enter_PointsEarningRules_Text_Filter(data.RuleName);
                string gridName = PageObject_Admin.Get_PointsEarningRule_GridName().GetAttribute("innerHTML");
                Logger.WriteDebugMessage("Active Rule got Displayed on the grid");
                Admin.Click_PointsEarningRules_Icon_Edit();
                Logger.WriteDebugMessage("Edit Overlay got displayed on the Page");
                Admin.Enter_PointsEarningRules_Text_Priority(oldpriority);
                Logger.WriteDebugMessage("Priority updated");
                Admin.Click_PointsEarningRules_Button_Save();
                ElementWait(PageObject_Admin.PointsEarningRules_Text_Filter(), 240);
                Logger.WriteDebugMessage("Validation Message does not displayed and Rule got Saved");
               
                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, "Priority", priority);
                Logger.LogTestData(TestPlanId, TestCaseId, "Old Priority", oldpriority, true);

            }
        }
        public static void TC_220672()
        {
            if (TestCaseId == Constants.TC_220672)
            {
                //Pre-requites
                string priority, priority1;
                Users data = new Users();
                Queries.GetMemberLevel(data, 1);
                Queries.GetLoyaltyRules(data, "1", "Points");
                Random ran = new Random();

                //Retrieve data from Test data file
                priority = String.Concat(DateTime.Now.Millisecond, DateTime.Now.Minute);
                priority1 = String.Concat(DateTime.Now.Millisecond, DateTime.Now.Millisecond);

                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                Admin.Click_Menu_LoyaltyRules();
                Logger.WriteDebugMessage("Landed on the Loyalty Rules page");
                Admin.Click_SubTab_PointsEarningRules();
                Logger.WriteDebugMessage("Users Landed on Points Earning Rules Page");

                // Verify user is able to edit Priority value of any active/schedule/expired priority rule
                Admin.Enter_PointsEarningRules_Text_Filter(data.RuleName);
                string gridName = PageObject_Admin.Get_PointsEarningRule_GridName().GetAttribute("innerHTML");
                Logger.WriteDebugMessage("Rule got Displayed on the Page");
                Admin.Click_PointsEarningRules_Icon_Edit();
                Logger.WriteDebugMessage("Edit Overlay got Displayed");
                Admin.Enter_PointsEarningRules_Text_Priority(priority);
                Logger.WriteDebugMessage("Priority updated");
                Admin.Click_PointsEarningRules_Button_Save();
                if (PageObject_Admin.PointsEarningRules_Button_Save().Displayed)
                    Assert.Fail("Changes are not saved");
                else
                { 
                    Admin.Enter_PointsEarningRules_Text_Filter(gridName);
                    VerifyTextOnPageAndHighLight(priority);
                    Logger.WriteDebugMessage("Priority updated and displayed on grid");
                }

                // For Scheduled rule
                Admin.Enter_PointsEarningRules_Text_Filter("Scheduled");
                string gridName1 = PageObject_Admin.Get_PointsEarningRule_GridName().GetAttribute("innerHTML");
                Logger.WriteDebugMessage("Schedule rule got displayed");
                Admin.Click_PointsEarningRules_Icon_Edit();
                Logger.WriteDebugMessage("Edit Overlay got diaplyed");
                Admin.Enter_PointsEarningRules_Text_Priority(priority1);
                Logger.WriteDebugMessage("Priority updated");
                Admin.Click_PointsEarningRules_Button_Save();
                if (PageObject_Admin.PointsEarningRules_Button_Save().Displayed)
                    Assert.Fail("Changes are not saved");
                else
                {
                    Admin.Enter_PointsEarningRules_Text_Filter(gridName1);
                    VerifyTextOnPageAndHighLight(priority1);
                    Logger.WriteDebugMessage("Priority updated and displayed on grid");

                }


                //For Inactive rule
                Admin.Enter_PointsEarningRules_Text_Filter("Inactive");
                Admin.Click_PointsEarningRules_Icon_Edit();
                Logger.WriteDebugMessage("Edit button clicked");
                if (PageObject_Admin.PointsEarningRules_Text_Priority().Enabled)
                    Assert.Fail("Priority field is enabled");
                else
                    Logger.WriteDebugMessage("Priority field is disabled");

                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, "Priority", priority);
                Logger.LogTestData(TestPlanId, TestCaseId, "Priority 2", priority1, true);

            }
        }
    }
}