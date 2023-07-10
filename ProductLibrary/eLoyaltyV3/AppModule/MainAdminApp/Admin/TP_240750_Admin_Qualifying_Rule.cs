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
using NUnit.Framework.Constraints;
using System.Security.Cryptography;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : eLoyaltyV3.Utility.Setup
    {
        public static void TC_122056()
        {
            if (TestCaseId == Constants.TC_122056)
                {
                    //pre-requiste
                    string description, minRevenue, parallelStay, marketCode1, marketCode2, marketCode3, sourceOfBusiness1, sourceOfBusiness2, sourceOfBusiness3, values, channelCode1, channelCode2, channelCode3;


                    //Retrive data from Test data file
                    description = TestData.ExcelData.TestDataReader.ReadData(1, "Description");
                    minRevenue = TestData.ExcelData.TestDataReader.ReadData(1, "MinimumRevenue");
                    parallelStay = TestData.ExcelData.TestDataReader.ReadData(1, "ParallelStay");
                    marketCode1 = TestData.ExcelData.TestDataReader.ReadData(1, "MarketCode");
                    marketCode2 = TestData.ExcelData.TestDataReader.ReadData(2, "MarketCode");
                    marketCode3 = TestData.ExcelData.TestDataReader.ReadData(3, "MarketCode");
                    channelCode1 = TestData.ExcelData.TestDataReader.ReadData(1, "ChannelCode");
                    channelCode2 = TestData.ExcelData.TestDataReader.ReadData(2, "ChannelCode");
                    channelCode3 = TestData.ExcelData.TestDataReader.ReadData(3, "ChannelCode");
                    sourceOfBusiness1 = TestData.ExcelData.TestDataReader.ReadData(1, "SourceOfBusiness");
                    sourceOfBusiness2 = TestData.ExcelData.TestDataReader.ReadData(2, "SourceOfBusiness");
                    sourceOfBusiness3 = TestData.ExcelData.TestDataReader.ReadData(3, "SourceOfBusiness");



                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    Admin.Click_Menu_LoyaltyRules();
                    Admin.Click_SubTab_QualifyingRules();
                    Logger.WriteDebugMessage("Landed on the Loyalty Rules Qualified Rule Page");

                    //Verify Rule Name filed is disable or not
                    if (PageObject_Admin.Loyalty_Rule_QualifyingRule_General_RuleName().Enabled)
                        Assert.Fail("Rule Name fields is Enables");
                    else
                        Logger.WriteInfoMessage("Rule Name filed is Enabled");

                    //Verify Minimum Revenue and Parallel Stay accept Negative value, special characters and text or not
                    for (int i = 1; i <= 3; i++)
                    {
                        values = TestData.ExcelData.TestDataReader.ReadData(i, "NotAllowedValue");
                        Admin.Enter_Loyalty_Rule_QualifyingRule_General_MinRevenue(values);
                        Admin.Enter_Loyalty_Rule_QualifyingRule_General_ParallelStay(values);
                        if (PageObject_Admin.Loyalty_Rule_QualifyingRule_General_MinRevenue().GetAttribute("innerHTML").Equals(values) && PageObject_Admin.Loyalty_Rule_QualifyingRule_General_ParallelStay().GetAttribute("innerHTML").Equals(values))
                            Assert.Fail("Minimum Revenue and Parallel Stay Field is accepting -ve value");
                        else
                            Logger.WriteInfoMessage("Minimum Revenue and Parallel Stay fileds is not accepting -ve value");
                    }

                    //Verify the Channel Code, Market Code and Source of business accepts multiple values
                    Admin.Select_Loyalty_Rule_QualifyingRule_General_MarketCode(marketCode1);
                    Admin.Select_Loyalty_Rule_QualifyingRule_General_MarketCode(marketCode2);
                    Admin.Select_Loyalty_Rule_QualifyingRule_General_SourceOfBusiness(sourceOfBusiness1);
                    Admin.Select_Loyalty_Rule_QualifyingRule_General_SourceOfBusiness(sourceOfBusiness2);
                    Admin.Select_Loyalty_Rule_QualifyingRule_General_ChannelCode(channelCode1);
                    Admin.Select_Loyalty_Rule_QualifyingRule_General_ChannelCode(channelCode2);
                    Logger.WriteDebugMessage("Multiple values got displayed on Fields");



                    //Update all the Field values for Qualifying Rule
                    Admin.Add_LoyaltyRule_QualifyingStay_Rule(description, minRevenue, parallelStay, channelCode3, marketCode3, sourceOfBusiness3);

                    Helper.ReloadPage();
                    Logger.WriteDebugMessage("Page got Refreshed");

                    //Verify the Entered values on the Page
                    VerifyTextOnPageAndHighLight(description);
                    VerifyTextOnPageAndHighLight(channelCode3);
                    VerifyTextOnPageAndHighLight(sourceOfBusiness3);
                    VerifyTextOnPageAndHighLight(marketCode3);
                    Logger.WriteDebugMessage("All the fields are displayed on the Page");

                    //UnSelect all the assigned Values
                    Admin.Select_Loyalty_Rule_QualifyingRule_General_MarketCode(marketCode1);
                    Admin.Select_Loyalty_Rule_QualifyingRule_General_MarketCode(marketCode2);
                    Admin.Select_Loyalty_Rule_QualifyingRule_General_MarketCode(marketCode3);
                    Admin.Select_Loyalty_Rule_QualifyingRule_General_SourceOfBusiness(sourceOfBusiness1);
                    Admin.Select_Loyalty_Rule_QualifyingRule_General_SourceOfBusiness(sourceOfBusiness2);
                    Admin.Select_Loyalty_Rule_QualifyingRule_General_SourceOfBusiness(sourceOfBusiness3);
                    Admin.Select_Loyalty_Rule_QualifyingRule_General_ChannelCode(channelCode1);
                    Admin.Select_Loyalty_Rule_QualifyingRule_General_ChannelCode(channelCode2);
                    Admin.Select_Loyalty_Rule_QualifyingRule_General_ChannelCode(channelCode3);
                    Admin.Enter_Loyalty_Rule_QualifyingRule_General_MinRevenue("0");
                    Admin.Enter_Loyalty_Rule_QualifyingRule_General_ParallelStay("0");
                    Admin.Click_Loyalty_Rule_QualifyingRule_General_SaveButton();
                    Logger.WriteDebugMessage("Qualified Stay Rule Save Confirmation Message got Displayed");
                    Admin.Click_Loyalty_Rule_QualifyingRule_General_SaveButton_Confirm();
                    Logger.WriteDebugMessage("Details are unselected succesfully");

                    //Log Test data into Log file and extend Report
                    Logger.LogTestData(TestPlanId, TestCaseId, "Desscription", description);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Minimum Revenue", minRevenue);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Parralel Stay", parallelStay);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Market Code 1", marketCode1);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Market Code 2", marketCode2);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Market Code 3", marketCode3);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Channel Code 1", channelCode1);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Channel Code 2", channelCode2);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Channel Code 3", channelCode3);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Source of Business 1", sourceOfBusiness1);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Source of Business 2", sourceOfBusiness2);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Source of Business 3", sourceOfBusiness3, true);

            }
        }

        public static void TC_209606()
        {
            
            if (TestCaseId == Constants.TC_209606)
            {
                //pre-requiste
                string description, minRevenue, parallelStay, marketCode,sourceOfBusiness, channelCode;
                Users data = new Users();

                //Retrive data from Test data file
                description = TestData.ExcelData.TestDataReader.ReadData(1, "Description");
                minRevenue = TestData.ExcelData.TestDataReader.ReadData(1, "MinimumRevenue");
                parallelStay = TestData.ExcelData.TestDataReader.ReadData(1, "ParallelStay");
                marketCode = TestData.ExcelData.TestDataReader.ReadData(1, "MarketCode");
                channelCode = TestData.ExcelData.TestDataReader.ReadData(1, "ChannelCode");
                sourceOfBusiness = TestData.ExcelData.TestDataReader.ReadData(1, "SourceOfBusiness");
                
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                Admin.Click_Menu_LoyaltyRules();
                Admin.Click_SubTab_QualifyingRules();
                Logger.WriteDebugMessage("Landed on the Loyalty Rules Qualified Rule Page");

                //Update all the Field values for Qualifying Rule
                Admin.Add_LoyaltyRule_QualifyingStay_Rule(description+"_Edit", minRevenue, parallelStay, channelCode, marketCode, sourceOfBusiness);
                Helper.ElementWait(PageObject_Admin.Loyalty_Rule_QualifyingRule_General_SaveButton(),240);
                Admin.Click_Loyalty_Rule_QualifyingRule_General_SaveButton();
                Admin.Click_Loyalty_Rule_QualifyingRule_General_SaveButton_Confirm();
                Helper.ReloadPage();
                Logger.WriteDebugMessage("Page got Refreshed");
                AddDelay(5000);

                //Verify the Entered values on the Page
                VerifyTextOnPageAndHighLight(description);
                VerifyTextOnPageAndHighLight(channelCode);
                VerifyTextOnPageAndHighLight(sourceOfBusiness);
                VerifyTextOnPageAndHighLight(marketCode);
                Logger.WriteDebugMessage("All the fields are displayed on the Page");

                //Verify the Logs in LoyaltyRuleInclExclMarketCodesLog

                Queries.GetRuleMarketCode(data, "1", marketCode);
                if (data.MarketCode == marketCode)
                    Logger.WriteInfoMessage("Market Code is updated on LoyaltyRuleInclExclMarketCodesLog table");
                else
                    Assert.Fail("Market Code is not uppdaed on LoyaltyRuleInclExclMarketCodesLog table");

                //UnSelect all the assigned Values
                Admin.Enter_Loyalty_Rule_QualifyingRule_General_Description(description);
                Admin.Select_Loyalty_Rule_QualifyingRule_General_MarketCode(marketCode);
                Admin.Select_Loyalty_Rule_QualifyingRule_General_SourceOfBusiness(sourceOfBusiness);
                Admin.Select_Loyalty_Rule_QualifyingRule_General_ChannelCode(channelCode);
                Admin.Enter_Loyalty_Rule_QualifyingRule_General_MinRevenue("0");
                Admin.Enter_Loyalty_Rule_QualifyingRule_General_ParallelStay("0");
                Admin.Click_Loyalty_Rule_QualifyingRule_General_SaveButton();
                Logger.WriteDebugMessage("Qualified Stay Rule Save Confirmation Message got Displayed");
                Admin.Click_Loyalty_Rule_QualifyingRule_General_SaveButton_Confirm();
                Logger.WriteDebugMessage("Details are unselected succesfully");

                //Verify the Logs in LoyaltyRuleLog table
                Queries.GetQualifiedRuleDetails(data, "Qualify Stay Rule");
              
                if ((data.RuleName == "Qualify Stay Rule") && (data.RuleDescription == description+ "_Edit") && (data.MinRevenue == minRevenue) && (data.ParallelStay == parallelStay) && (data.AllowConsecutiveStays == "True"))
                {
                    Logger.WriteInfoMessage("Log is getting generated for previously added values and not for the one which we have recently updated.");
                }
                else
                    Assert.Fail("Log is not getting generated for the previously added values");

                
                
                //Log Test data into Log file and extend Report
                Logger.LogTestData(TestPlanId, TestCaseId, "Desscription", description);
                Logger.LogTestData(TestPlanId, TestCaseId, "Minimum Revenue", minRevenue);
                Logger.LogTestData(TestPlanId, TestCaseId, "Parralel Stay", parallelStay);
                Logger.LogTestData(TestPlanId, TestCaseId, "Market Code", marketCode);
                Logger.LogTestData(TestPlanId, TestCaseId, "Channel Code", channelCode);
                Logger.LogTestData(TestPlanId, TestCaseId, "Source of Business", sourceOfBusiness, true);
                

            }
        }
        public static void TC_240753()
        {
            
            if (TestCaseId == Constants.TC_240753)
                {
                    //pre-requiste
                    string description, minRevenue, marketCode, ratecode, marketcombo, rateCombo, sourceOfBusiness, values, channelCode, hotel;
                    Users data = new Users();
                    Queries.IdentifyHotel(data);

                    //Retrive data from Test data file
                    description = TestData.ExcelData.TestDataReader.ReadData(1, "Description");
                    minRevenue = TestData.ExcelData.TestDataReader.ReadData(1, "MinimumRevenue");
                    marketcombo = TestData.ExcelData.TestDataReader.ReadData(1, "MarketCombo");
                    rateCombo = TestData.ExcelData.TestDataReader.ReadData(1, "RateCombo");
                    hotel = data.PropertyName;

                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    Admin.Click_Menu_LoyaltyRules();
                    Admin.Click_SubTab_QualifyingRules();
                    Logger.WriteDebugMessage("Landed on the Loyalty Rules Qualified Rule Page");

                    //Verify Rule Name filed is disable or not
                    if (PageObject_Admin.Loyalty_Rule_QualifyingRule_Night_RuleName().Enabled)
                        Assert.Fail("Rule Name fields is Enables");
                    else
                        Logger.WriteInfoMessage("Rule Name filed is Enabled");

                    //Verify Minimum Revenue and Parallel Stay accept Negative value, special characters and text or not
                    for (int i = 1; i <= 3; i++)
                    {
                        values = TestData.ExcelData.TestDataReader.ReadData(i, "NotAllowedValue");
                        Admin.Enter_Loyalty_Rule_QualifyingRule_Night_MinRevenue(values);
                        if (PageObject_Admin.Loyalty_Rule_QualifyingRule_General_MinRevenue().GetAttribute("innerHTML").Equals(values))
                            Assert.Fail("Minimum Revenue Field is accepting '" + values + "'  value");
                        else
                            Logger.WriteInfoMessage("Minimum Revenue and Parallel Stay fileds is not accepting '" + values + "' value");
                    }

                    //Verify the Channel Code, Market Code and Source of business accepts multiple values
                    for (int i = 1; i <= 2; i++)
                    {
                        marketCode = TestData.ExcelData.TestDataReader.ReadData(i, "MarketCode");
                        channelCode = TestData.ExcelData.TestDataReader.ReadData(i, "ChannelCode");
                        sourceOfBusiness = TestData.ExcelData.TestDataReader.ReadData(i, "SourceOfBusiness");
                        ratecode = TestData.ExcelData.TestDataReader.ReadData(i, "RateCode");
                        Admin.Select_Loyalty_Rule_QualifyingRule_Night_MarketCode(marketCode);
                        Admin.Select_Loyalty_Rule_QualifyingRule_Night_ChannelCode(channelCode);
                        Admin.Select_Loyalty_Rule_QualifyingRule_Night_RatesCodes(ratecode);
                        Admin.Select_Loyalty_Rule_QualifyingRule_Night_SourceOfBusiness(sourceOfBusiness);
                    }
                    Admin.Select_Loyalty_Rule_QualifyingRule_Night_MarketCombo(marketcombo);
                    Admin.Select_Loyalty_Rule_QualifyingRule_Night_Hotel_SelectAll();
                    Logger.WriteDebugMessage("Multiple values got displayed on Fields");

                    //Update all the Field values for Qualifying Night Rule
                    marketCode = TestData.ExcelData.TestDataReader.ReadData(3, "MarketCode");
                    channelCode = TestData.ExcelData.TestDataReader.ReadData(3, "ChannelCode");
                    sourceOfBusiness = TestData.ExcelData.TestDataReader.ReadData(3, "SourceOfBusiness");
                    ratecode = TestData.ExcelData.TestDataReader.ReadData(3, "RateCode");
                    Admin.Add_LoyaltyRule_QualifiedNight_Rule(description, minRevenue, marketCode, hotel, ratecode, marketcombo, rateCombo, sourceOfBusiness, channelCode);
                    Admin.Click_Loyalty_Rule_QualifyingRule_Night_SaveButton();
                    Admin.Click_Loyalty_Rule_QualifyingRule_Night_SaveButton_Confirm();
                    Helper.ReloadPage();
                    Logger.WriteDebugMessage("Page got Refreshed");

                    //Verify the Entered values on the Page
                    VerifyTextOnPageAndHighLight(description);
                    VerifyTextOnPageAndHighLight(marketCode);
                    VerifyTextOnPageAndHighLight(ratecode);
                    VerifyTextOnPageAndHighLight(marketcombo);
                    VerifyTextOnPageAndHighLight(rateCombo);
                    VerifyTextOnPageAndHighLight(sourceOfBusiness);
                    VerifyTextOnPageAndHighLight(channelCode);
                    Logger.WriteDebugMessage("All the fields are displayed on the Page");

                    //Verify the values in LoyaltyRuleInclExclMarketCodesLog, LoyaltyRuleInclExclMarketCodesRatesCombLog, LoyaltyRuleInclExclRatesLog and LoyaltyRuleInclExclHotelsLog table 
                    Queries.GetRuleMarketCode(data, "6", marketCode);
                    marketCode = TestData.ExcelData.TestDataReader.ReadData(3, "MarketCode");
                    if (data.MarketCode == marketCode)
                        Logger.WriteInfoMessage("Market Code is updated on LoyaltyRuleInclExclMarketCodesLog table");
                    else
                        Assert.Fail("Market Code is not uppdaed on LoyaltyRuleInclExclMarketCodesLog table");

                    Queries.GetRuleMarketRateCombo(data, "6");
                    if (data.MarketCombo == marketcombo && data.RateCombo == rateCombo)
                        Logger.WriteInfoMessage("Market combo and Rate Combo are updated on LoyaltyRuleInclExclMarketCodesRatesCombLog table");
                    else
                        Assert.Fail("Market Combo and Rate combo arre not uppdaed on LoyaltyRuleInclExclMarketCodesRatesCombLog table");
                    string ratecodes = "COACH AOVO 0000363700";
                    Queries.GetRuleRateCode(data, "6");
                    if (ratecodes.Contains(data.RateCode))
                        Logger.WriteInfoMessage("Rate Code is updated on LoyaltyRuleInclExclRatesLog table");
                    else
                        Assert.Fail("Rate Code is not uppdaed on LoyaltyRuleInclExclRatesLog table");

                    Queries.GetRuleProperty(data, "6", data.PropertyName);
                    if (data.MasterPropertyCode == data.PropertyCode)
                        Logger.WriteInfoMessage("Property Code is updated on LoyaltyRuleInclExclHotelsLog table");
                    else
                        Assert.Fail("Property Code is not uppdaed on LoyaltyRuleInclExclHotelsLog table");

                    //UnSelect all the assigned Values
                    for (int i = 1; i <= 3; i++)
                    {
                        marketCode = TestData.ExcelData.TestDataReader.ReadData(i, "MarketCode");
                        channelCode = TestData.ExcelData.TestDataReader.ReadData(i, "ChannelCode");
                        sourceOfBusiness = TestData.ExcelData.TestDataReader.ReadData(i, "SourceOfBusiness");
                        ratecode = TestData.ExcelData.TestDataReader.ReadData(i, "RateCode");
                        Admin.Select_Loyalty_Rule_QualifyingRule_Night_MarketCode(marketCode);
                        Admin.Select_Loyalty_Rule_QualifyingRule_Night_ChannelCode(channelCode);
                        Admin.Select_Loyalty_Rule_QualifyingRule_Night_RatesCodes(ratecode);
                        Admin.Select_Loyalty_Rule_QualifyingRule_Night_SourceOfBusiness(sourceOfBusiness);
                    }
                    Admin.Enter_Loyalty_Rule_QualifyingRule_Night_MinRevenue("0");
                    Admin.Select_Loyalty_Rule_QualifyingRule_Night_Hotel_DeselectAll();
                    Admin.Select_Loyalty_Rule_QualifyingRule_Night_MarketCombo("Select Market Code");
                    Admin.Select_Loyalty_Rule_QualifyingRule_Night_RateCombo("Select Rate Code");
                    Admin.Click_Loyalty_Rule_QualifyingRule_Night_SaveButton();
                    Logger.WriteDebugMessage("Qualified Night Rule Save Confirmation Message got Displayed");
                    Admin.Click_Loyalty_Rule_QualifyingRule_Night_SaveButton_Confirm();
                    Logger.WriteDebugMessage("Details are unselected succesfully");

                    //Log Test data into Log file and extend Report
                    Logger.LogTestData(TestPlanId, TestCaseId, "Desscription", description);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Minimum Revenue", minRevenue);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Market Code", marketCode);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Channel Code", channelCode);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Source of Business", sourceOfBusiness);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Rate Code", ratecode);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Market Combo", marketcombo, true);

            }
        }
        public static void TC_209605()
        {
            if (TestCaseId == Constants.TC_209605)
                {
                    //pre-requiste
                    string description, minRevenue, marketCode, ratecode, marketcombo, sourceOfBusiness, rateCombo, channelCode;
                    Users data = new Users();
                    Queries.IdentifyHotel(data);
                    //Retrive data from Test data file
                    description = TestData.ExcelData.TestDataReader.ReadData(1, "Description");
                    minRevenue = TestData.ExcelData.TestDataReader.ReadData(1, "MinimumRevenue");
                    marketcombo = TestData.ExcelData.TestDataReader.ReadData(1, "MarketCombo");
                    marketCode = TestData.ExcelData.TestDataReader.ReadData(1, "MarketCode");
                    channelCode = TestData.ExcelData.TestDataReader.ReadData(1, "ChannelCode");
                    sourceOfBusiness = TestData.ExcelData.TestDataReader.ReadData(1, "SourceOfBusiness");
                    ratecode = TestData.ExcelData.TestDataReader.ReadData(1, "RateCode");
                    rateCombo = TestData.ExcelData.TestDataReader.ReadData(1, "RateCombo");

                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    Admin.Click_Menu_LoyaltyRules();
                    Admin.Click_SubTab_QualifyingRules();
                    Logger.WriteDebugMessage("Landed on the Loyalty Rules Qualified Rule Page");

                    Admin.Add_LoyaltyRule_QualifiedNight_Rule(description + "_Edit", minRevenue, marketCode, data.PropertyName, ratecode, marketcombo, rateCombo, sourceOfBusiness, channelCode);
                    Helper.ReloadPage();
                    Helper.PageDown();
                    Logger.WriteDebugMessage("Page got Refreshed");

                    //Verify the Entered values on the Page
                    VerifyTextOnPageAndHighLight(description);
                    VerifyTextOnPageAndHighLight(channelCode);
                    VerifyTextOnPageAndHighLight(sourceOfBusiness);
                    VerifyTextOnPageAndHighLight(marketCode);
                    VerifyTextOnPageAndHighLight(rateCombo);
                    Logger.WriteDebugMessage("All the fields are displayed on the Page");

                    //UnSelect all the assigned Values
                    Admin.Enter_Loyalty_Rule_QualifyingRule_Night_Description(description);
                    Admin.Select_Loyalty_Rule_QualifyingRule_Night_MarketCode(marketCode);
                    Admin.Select_Loyalty_Rule_QualifyingRule_Night_SourceOfBusiness(sourceOfBusiness);
                    Admin.Select_Loyalty_Rule_QualifyingRule_Night_ChannelCode(channelCode);
                    Admin.Select_Loyalty_Rule_QualifyingRule_Night_RatesCodes(ratecode);
                    Admin.Enter_Loyalty_Rule_QualifyingRule_Night_MinRevenue("0");
                    Admin.Select_Loyalty_Rule_QualifyingRule_Night_Hotel_DeselectAll();
                    Admin.Select_Loyalty_Rule_QualifyingRule_Night_MarketCombo("Select Market Code");
                    Admin.Select_Loyalty_Rule_QualifyingRule_Night_RateCombo("Select Rate Code");
                    Logger.WriteDebugMessage("All the Details are unselected properly");
                    Admin.Click_Loyalty_Rule_QualifyingRule_Night_SaveButton();
                    Logger.WriteDebugMessage("Qualified Night Rule Save Confirmation Message got Displayed");
                    Admin.Click_Loyalty_Rule_QualifyingRule_Night_SaveButton_Confirm();
                    Logger.WriteDebugMessage("Details are unselected succesfully");

                    //Verify the Logs in LoyaltyRuleLog table
                    Queries.GetQualifiedNIghtRuleDetails(data, "Qualified Night Rule");

                    if ((data.RuleName == "Qualified Night Rule") && (data.RuleDescription == description + "_Edit") && (data.MinRevenue == minRevenue))
                    {
                        Logger.WriteInfoMessage("Log is getting generated for previously added values and not for the one which we have recently updated.");
                    }
                    else
                        Assert.Fail("Log is not getting generated for the previously added values");

                    //Log Test data into Log file and extend Report
                    Logger.LogTestData(TestPlanId, TestCaseId, "Desscription", description);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Minimum Revenue", minRevenue);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Rate Code", ratecode);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Market Code", marketCode);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Channel Code", channelCode);
                    Logger.LogTestData(TestPlanId, TestCaseId, "Source of Business", sourceOfBusiness, true);


                }
        }
    }
}