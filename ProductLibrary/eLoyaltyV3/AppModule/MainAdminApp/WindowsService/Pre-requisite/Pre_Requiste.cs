using System;
using System.Data;
using System.Globalization;
using System.Threading;
using eLoyaltyV3.AppModule.UI;
using eLoyaltyV3.Entity;
using eLoyaltyV3.Utility;
using InfoMessageLogger;
using TestData;
using Queries = eLoyaltyV3.Utility.Queries;



namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region Service Automation Pre-Requisite

        public static void TC_CreateUser_UpdateRegistrationDate()
        {
            if (TestCaseId == Constants.TC_CreateUser_UpdateRegistrationDate)
            {
                //Pre-requisites
                #region[Pre-requisites]
                Random ranNum = new Random();
                Users data = new Users();
                string FilePath, Filename, FullPath, Firstname, Lastname, DOB, Membershiplevel, ResgistrationDate, RefrealCode, Language, Worksheetname = "eLoyalty Member Template", regdate, expDate;

                string[] email = new string[35];
                string[] membershipid = new string[35];
                DateTime dateTime = DateTime.Today;
                regdate = DateTime.Today.AddYears(-2).ToString("yyyy-MM-dd");
                expDate = DateTime.Today.AddYears(+2).ToString("yyyy-MM-dd");
                #endregion[Pre-requisites]

                //Log into Admin.

                #region[Registeruser and Update Registration Date]
                Logger.WriteDebugMessage("Landed on Admin Login Page.");
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //Click on MemberbatchUpload tab
                Admin.Admin_MemberBatchUpload_Tab();
                AddDelay(2500);
                Logger.WriteDebugMessage("Landed on the Member batch upload page");

                //Download the batch Upload Template
                Admin.BatchUpload_DownloadTemplete();
                Logger.WriteDebugMessage("Downloaded the template");

                //Declare the File path and retrieve the latest file
                FilePath = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
                Filename = Admin.VerifyFileFormate(FilePath);
                FullPath = TestData.ExcelData.ExcelDataReader.GetNewestFile((FilePath));

                //Retrieved the data from Excel
                Firstname = TestData.ExcelData.TestDataReader.ReadData(1, "Firstname");
                Lastname = TestData.ExcelData.TestDataReader.ReadData(1, "Lastname");
                DOB = TestData.ExcelData.TestDataReader.ReadData(1, "DOB");
                Membershiplevel = TestData.ExcelData.TestDataReader.ReadData(1, "Membershiplevel");
                ResgistrationDate = DateTime.Now.AddDays(-60).ToString("MM/dd/yyyy");
                RefrealCode = TestData.ExcelData.TestDataReader.ReadData(1, "RefrealCode");
                Language = TestData.ExcelData.TestDataReader.ReadData(1, "Language");

                for (int i = 1; i < 32; i++)
                {
                    membershipid[i] = ranNum.Next().ToString();
                    email[i] = TestData.ExcelData.TestDataReader.ReadData(i, "Email");
                }


                //Insert the data into Downloaded excel file
                TestData.ExcelData.ExcelDataReader eat = new TestData.ExcelData.ExcelDataReader(FullPath);
                for (int i = 1; i <= 31; i++)
                {
                    eat.SetCellData(Worksheetname, "First Name", i + 1, Firstname);
                    eat.SetCellData(Worksheetname, "Last Name", i + 1, Lastname);
                    eat.SetCellData(Worksheetname, "Email", i + 1, email[i]);
                    eat.SetCellData(Worksheetname, "DOB (MM/dd/yyyy)", i + 1, DOB);
                    eat.SetCellData(Worksheetname, "MembershipID", i + 1, membershipid[i]);
                    eat.SetCellData(Worksheetname, "Membership Level", i + 1, Membershiplevel);
                    eat.SetCellData(Worksheetname, "Registration Date (MM/dd/yyyy)", i + 1, ResgistrationDate);
                    eat.SetCellData(Worksheetname, "Referral Code", i + 1, RefrealCode);
                    eat.SetCellData(Worksheetname, "Language", i + 1, Language);
                }
                //Upload the Updated Excel File
                Admin.BatchUpdate_UploadTemplete();
                Logger.WriteDebugMessage("Upload Dialog is opened");
                Admin.BatchUpload_UploadFile(FullPath);
                Logger.WriteDebugMessage("Batch Registration is completed successfully");

                //Filter the Updated file and verify the updated data
                Admin.VerifyUploadedDetails(Filename);
                Logger.WriteDebugMessage("Uploaded Result is displayed on the Page");
                AddDelay(120000);

                //Update Registration Date for the created user
                for (int i = 1; i < 32; i++)
                {
                    Queries.GetProfileIdByMemberEmail(data, email[i]);
                    Queries.UpdateRegistrationDate(data.ProfileId, regdate, expDate);
                    Logger.WriteInfoMessage("Updated Registration date for email : " + email[i]);
                }

                #endregion[Registeruser and Update Registration Date]



            }
        }
        public static void TC_UpdateQualifyingRuleFor_1to12()
        {
            if (TestCaseId == "TC_UpdateQualifyingRuleFor_1to12")
            {
                //Pre-requisite[Variable Declaration]
                Users data = new Users();
                string rulename, marketCode, sob, channelcode, marketCodeCombo, rateCodeCombo, hotels, FilePath, worksheetname, ratecode;
                int ruleid, paralleStay, allowConsecutiveStays, minRevenue, marketcodeInclude, sOBInclude, channelCodesInclude, market_RateComboInclude, hotelsInclude, rateCodeInclude;
                string[] marketCodeArr, channelcodeArr, hotelsArr, ratecodeArr, sobArr;

                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Rules_Setup";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);

                //Update Stay Rule
                rulename = tt.GetCellData(worksheetname, 1, 7);
                Queries.GetRuleByName(data, rulename);
                ruleid = Convert.ToInt32(data.RuleId);
                paralleStay = Convert.ToInt32(tt.GetCellData(worksheetname, 2, 7));
                allowConsecutiveStays = Convert.ToInt32(tt.GetCellData(worksheetname, 3, 7));
                minRevenue = Convert.ToInt32(tt.GetCellData(worksheetname, 4, 7));
                marketCode = tt.GetCellData(worksheetname, 5, 7);
                marketCodeArr = marketCode.Split(',');
                marketcodeInclude = Convert.ToInt32(tt.GetCellData(worksheetname, 6, 7));
                sob = tt.GetCellData(worksheetname, 7, 7);
                sobArr = sob.Split(',');
                sOBInclude = Convert.ToInt32(tt.GetCellData(worksheetname, 8, 7));
                channelcode = tt.GetCellData(worksheetname, 9, 7);
                channelcodeArr = channelcode.Split(',');
                channelCodesInclude = Convert.ToInt32(tt.GetCellData(worksheetname, 10, 7));

                //Insert Qualifying Stay Rule
                Queries.UpdateLoyaltyRule(data, allowConsecutiveStays, minRevenue, rulename);
                Queries.UpdatePropertySettings(data, paralleStay);
                foreach (string channel in channelcodeArr)
                    Queries.InsertChannelCode(data, ruleid, channel, channelCodesInclude);
                foreach (string markeC in marketCodeArr)
                    Queries.InsertMarketCode(data, ruleid, markeC, marketcodeInclude);
                foreach (string SOB in sobArr)
                    Queries.InsertSOB(data, ruleid, SOB, sOBInclude);

                //Update Night Rule
                rulename = tt.GetCellData(worksheetname, 1, 12);
                Queries.GetRuleByName(data, rulename);
                ruleid = Convert.ToInt32(data.RuleId);
                marketCodeCombo = tt.GetCellData(worksheetname, 2, 12);
                rateCodeCombo = tt.GetCellData(worksheetname, 3, 12);
                market_RateComboInclude = Convert.ToInt32(tt.GetCellData(worksheetname, 4, 12));
                hotels = tt.GetCellData(worksheetname, 5, 12);
                Queries.GetMasterPropertyCode(data, hotels);
                hotelsArr = data.PropertyCode.Split(',');
                hotelsInclude = Convert.ToInt32(tt.GetCellData(worksheetname, 6, 12));
                minRevenue = Convert.ToInt32(tt.GetCellData(worksheetname, 7, 12));
                marketCode = tt.GetCellData(worksheetname, 8, 12);
                marketCodeArr = marketCode.Split(',');
                marketcodeInclude = Convert.ToInt32(tt.GetCellData(worksheetname, 9, 12));
                sob = tt.GetCellData(worksheetname, 10, 12);
                sobArr = sob.Split(',');
                sOBInclude = Convert.ToInt32(tt.GetCellData(worksheetname, 11, 12));
                channelcode = tt.GetCellData(worksheetname, 12, 12);
                channelcodeArr = channelcode.Split(',');
                channelCodesInclude = Convert.ToInt32(tt.GetCellData(worksheetname, 13, 12));
                ratecode = tt.GetCellData(worksheetname, 14, 12);
                ratecodeArr = ratecode.Split(',');
                rateCodeInclude = Convert.ToInt32(tt.GetCellData(worksheetname, 15, 12));

                //Insert Night Rule
                Queries.UpdateLoyaltyRule(data, 0, minRevenue, rulename);
                foreach (string channel in channelcodeArr)
                    Queries.InsertChannelCode(data, ruleid, channel, channelCodesInclude);
                foreach (string markeC in marketCodeArr)
                    Queries.InsertMarketCode(data, ruleid, markeC, marketcodeInclude);
                foreach (string SOB in sobArr)
                    Queries.InsertSOB(data, ruleid, SOB, sOBInclude);
                foreach (string hot in hotelsArr)
                    Queries.InsertHotels(data, ruleid, hot, hotelsInclude);
                foreach (string rate in ratecodeArr)
                    Queries.InsertRateCode(data, ruleid, rate, rateCodeInclude);
                Queries.InsertMarketRateCombo(data, ruleid, marketCodeCombo, rateCodeCombo, market_RateComboInclude);
                Logger.WriteInfoMessage("Qualifying Stay Rule and Qualifying Night Rule is Updated");

            }
        }
        public static void TC_UpdateQualifyingRuleFor_13to29()
        {
            if (TestCaseId == "TC_UpdateQualifyingRuleFor_13to29")
            {
                //Pre-requisite[Variable Declaration]
                Users data = new Users();
                string rulename, marketCode, sob, channelcode, marketCodeCombo, rateCodeCombo, hotels, FilePath, worksheetname, ratecode, propertycode;
                int ruleid, paralleStay, allowConsecutiveStays, minRevenue, marketcodeInclude, sOBInclude, channelCodesInclude, market_RateComboInclude, hotelsInclude, rateCodeInclude;
                string[] marketCodeArr, channelcodeArr, hotelsArr, ratecodeArr, sobArr;


                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Rules_Setup";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);

                //Update Stay Rule
                rulename = tt.GetCellData(worksheetname, 1, 8);
                Queries.DeleteRules(data, rulename);
                Queries.GetRuleByName(data, rulename);
                ruleid = Convert.ToInt32(data.RuleId);
                paralleStay = Convert.ToInt32(tt.GetCellData(worksheetname, 2, 8));
                allowConsecutiveStays = Convert.ToInt32(tt.GetCellData(worksheetname, 3, 8));
                minRevenue = Convert.ToInt32(tt.GetCellData(worksheetname, 4, 8));
                marketCode = tt.GetCellData(worksheetname, 5, 8);
                marketCodeArr = marketCode.Split(',');
                marketcodeInclude = Convert.ToInt32(tt.GetCellData(worksheetname, 6, 8));
                sob = tt.GetCellData(worksheetname, 7, 8);
                sobArr = sob.Split(',');
                sOBInclude = Convert.ToInt32(tt.GetCellData(worksheetname, 8, 8));
                channelcode = tt.GetCellData(worksheetname, 9, 8);
                channelcodeArr = channelcode.Split(',');
                channelCodesInclude = Convert.ToInt32(tt.GetCellData(worksheetname, 10, 8));

                //Insert Qualifying Stay Rule
                Queries.UpdateLoyaltyRule(data, allowConsecutiveStays, minRevenue, rulename);
                Queries.UpdatePropertySettings(data, paralleStay);
                foreach (string channel in channelcodeArr)
                    Queries.InsertChannelCode(data, ruleid, channel, channelCodesInclude);
                foreach (string markeC in marketCodeArr)
                    Queries.InsertMarketCode(data, ruleid, markeC, marketcodeInclude);
                foreach (string SOB in sobArr)
                    Queries.InsertSOB(data, ruleid, SOB, sOBInclude);

                //Update Night Rule
                rulename = tt.GetCellData(worksheetname, 1, 13);
                Queries.DeleteRules(data, rulename);
                Queries.GetRuleByName(data, rulename);
                ruleid = Convert.ToInt32(data.RuleId);
                marketCodeCombo = tt.GetCellData(worksheetname, 2, 13);
                rateCodeCombo = tt.GetCellData(worksheetname, 3, 13);
                market_RateComboInclude = Convert.ToInt32(tt.GetCellData(worksheetname, 4, 13));
                hotels = tt.GetCellData(worksheetname, 5, 13);
                Queries.GetAllMasterPropertyCode(data);
                propertycode = data.PropertyCode;
                Queries.GetAllMasterPropertyCode(data, propertycode);
                propertycode = propertycode + "," + data.PropertyCode;
                hotelsArr = propertycode.Split(',');
                hotelsInclude = Convert.ToInt32(tt.GetCellData(worksheetname, 6, 13));
                minRevenue = Convert.ToInt32(tt.GetCellData(worksheetname, 7, 13));
                marketCode = tt.GetCellData(worksheetname, 8, 13);
                marketCodeArr = marketCode.Split(',');
                marketcodeInclude = Convert.ToInt32(tt.GetCellData(worksheetname, 9, 13));
                sob = tt.GetCellData(worksheetname, 10, 13);
                sobArr = sob.Split(',');
                sOBInclude = Convert.ToInt32(tt.GetCellData(worksheetname, 11, 13));
                channelcode = tt.GetCellData(worksheetname, 12, 13);
                channelcodeArr = channelcode.Split(',');
                channelCodesInclude = Convert.ToInt32(tt.GetCellData(worksheetname, 13, 13));
                ratecode = tt.GetCellData(worksheetname, 14, 13);
                ratecodeArr = ratecode.Split(',');
                rateCodeInclude = Convert.ToInt32(tt.GetCellData(worksheetname, 15, 13));

                //Insert Night
                Queries.UpdateLoyaltyRule(data, 0, minRevenue, rulename);
                foreach (string channel in channelcodeArr)
                    Queries.InsertChannelCode(data, ruleid, channel, channelCodesInclude);
                foreach (string markeC in marketCodeArr)
                    Queries.InsertMarketCode(data, ruleid, markeC, marketcodeInclude);
                foreach (string SOB in sobArr)
                    Queries.InsertSOB(data, ruleid, SOB, sOBInclude);
                foreach (string hot in hotelsArr)
                    Queries.InsertHotels(data, ruleid, hot, hotelsInclude);
                foreach (string rate in ratecodeArr)
                    Queries.InsertRateCode(data, ruleid, rate, rateCodeInclude);
                Queries.InsertMarketRateCombo(data, ruleid, marketCodeCombo, rateCodeCombo, market_RateComboInclude);
                Logger.WriteInfoMessage("Qualifying Stay Rule and Qualifying Night Rule is Updated");

            }
        }
        public static void TC_InsertRule()
        {
            if (TestCaseId == Constants.TC_InsertRule)
            {
                Users data = new Users();
                //Pre-requisite[Variable Declaration]
                string rulename, displayName, description, dateType, startDate, endDate, revenueType, ruleType, channel, marketCode, rateCode, roomTypeCode, sourceofBusiness, FilePath, worksheetname, MarketRateCombo;
                int calculatedUnitTypeId, fixedPoints, calculateUnit, CalculationType, minRevenue, minStay, maxStay, priority;
                decimal roomRevenue, fnBRevenue, otherRevenue, pointsPerNight;
                string[] marketCodeArr = new string[] { };
                string[] channelcodeArr = new string[] { };
                string[] ratecodeArr = new string[] { };
                string[] sobArr = new string[] { };
                string[] roomTypeCodeArr = new string[] { };
                string[] comboArr = new string[] { };

                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Rules_Setup";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);

                // Retrive Data from Excel for Rule 
                for (int i = 18; i <= 22; i++)
                {
                    rulename = displayName = description = tt.GetCellData(worksheetname, 1, i);
                    dateType = tt.GetCellData(worksheetname, 2, i);
                    startDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 3, i))).ToString("yyyy-MM-dd");
                    endDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 4, i))).ToString("yyyy-MM-dd");
                    pointsPerNight = Convert.ToDecimal(tt.GetCellData(worksheetname, 5, i));
                    try
                    {
                        fixedPoints = Convert.ToInt32(tt.GetCellData(worksheetname, 5, i));
                    }
                    catch (Exception)
                    {

                        fixedPoints = 0;
                    }
                    try
                    {
                        calculateUnit = Convert.ToInt32(tt.GetCellData(worksheetname, 6, i));
                    }
                    catch (Exception)
                    {

                        calculateUnit = 0;
                    }
                    revenueType = tt.GetCellData(worksheetname, 7, i);
                    marketCode = tt.GetCellData(worksheetname, 8, i);
                    if (marketCode != null)
                        marketCodeArr = marketCode.Split(',');
                    else
                        marketCodeArr = new string[] { };
                    rateCode = tt.GetCellData(worksheetname, 9, i);
                    if (rateCode != null)
                        ratecodeArr = rateCode.Split(',');
                    else
                        ratecodeArr = new string[] { };
                    roomTypeCode = tt.GetCellData(worksheetname, 10, i);
                    if (roomTypeCode != null)
                        roomTypeCodeArr = roomTypeCode.Split(',');
                    else
                        roomTypeCodeArr = new string[] { };
                    sourceofBusiness = tt.GetCellData(worksheetname, 11, i);
                    if (sourceofBusiness != null)
                        sobArr = sourceofBusiness.Split(',');
                    else
                        sobArr = new string[] { };
                    channel = tt.GetCellData(worksheetname, 12, i);
                    if (channel != null)
                        channelcodeArr = channel.Split(',');
                    else
                        channelcodeArr = new string[] { };
                    MarketRateCombo = tt.GetCellData(worksheetname, 13, i);
                    if (MarketRateCombo != null)
                        comboArr = MarketRateCombo.Split('&');
                    else
                        comboArr = new string[] { };
                    try
                    {
                        minStay = Convert.ToInt32(tt.GetCellData(worksheetname, 14, i));
                    }
                    catch (Exception)
                    {

                        minStay = 0;
                    }
                    try
                    {
                        maxStay = Convert.ToInt32(tt.GetCellData(worksheetname, 15, i));
                    }
                    catch (Exception)
                    {

                        maxStay = 0;
                    }
                    try
                    {
                        minRevenue = Convert.ToInt32(tt.GetCellData(worksheetname, 16, i));
                    }
                    catch (Exception)
                    {

                        minRevenue=0;
                    }
                    try
                    {
                        roomRevenue = Convert.ToDecimal(tt.GetCellData(worksheetname, 17, i));
                    }
                    catch (Exception)
                    {
                        roomRevenue = 0;
                    }
                    try
                    {
                        fnBRevenue = Convert.ToDecimal(tt.GetCellData(worksheetname, 18, i));
                    }
                    catch (Exception)
                    {

                        fnBRevenue = 0;
                    }
                    try
                    {
                        otherRevenue = Convert.ToDecimal(tt.GetCellData(worksheetname, 19, i));
                    }
                    catch (Exception)
                    {

                        otherRevenue = 0;
                    }

                    ruleType = tt.GetCellData(worksheetname, 20, i);
                    try
                    {
                        CalculationType = Convert.ToInt32(tt.GetCellData(worksheetname, 21, i));
                    }
                    catch (Exception)
                    {

                        CalculationType = 0;
                    }
                    try
                    {
                        calculatedUnitTypeId = Convert.ToInt32(tt.GetCellData(worksheetname, 22, i));
                    }
                    catch (Exception)
                    {

                        calculatedUnitTypeId = 0;
                    }
                    try
                    {
                        priority = Convert.ToInt32(tt.GetCellData(worksheetname, 23, i));
                    }
                    catch (Exception)
                    {

                        priority = 0;
                    }

                    Admin.InsertLoyaltyRule(rulename, displayName, description, dateType, startDate, endDate, priority, calculatedUnitTypeId, fixedPoints, calculateUnit, CalculationType, revenueType, roomRevenue, fnBRevenue, otherRevenue, pointsPerNight, minRevenue, minStay, maxStay, ruleType);
                    AddDelay(30000);
                    Queries.GetRuleByName(data, rulename);

                    foreach (string market in marketCodeArr)
                        Queries.InsertMarketCode(data, Convert.ToInt32(data.RuleId), market, 1);
                    foreach (string rate in ratecodeArr)
                        Queries.InsertRateCode(data, Convert.ToInt32(data.RuleId), rate, 1);
                    foreach (string room in roomTypeCodeArr)
                        Queries.InsertRoomType(data, Convert.ToInt32(data.RuleId), room, 1);
                    foreach (string s in sobArr)
                        Queries.InsertSOB(data, Convert.ToInt32(data.RuleId), s, 1);
                    foreach (string chan in channelcodeArr)
                        Queries.InsertChannelCode(data, Convert.ToInt32(data.RuleId), chan, 1);
                    if (comboArr.Length >1)
                    {
                        if (MarketRateCombo != null)
                            Queries.InsertMarketRateCombo(data, Convert.ToInt32(data.RuleId), comboArr[0], comboArr[1], 1);
                    }
                    else
                    {
                        if (MarketRateCombo != null)
                            Queries.InsertMarketRateCombo(data, Convert.ToInt32(data.RuleId), comboArr[0], comboArr[0], 1);
                    }
                    
                }

            }
        }
        public static void TC_InsertStay01_12()
        {
            if (TestCaseId == Constants.TC_InsertStay01_12)
            {
                #region[Pre-requisites]

                //Pre-requisites [Variable Declaration]
                Users data = new Users();
                string arrivalDate, departureDate, resCreationDate, resultid, FilePath, worksheetname, stayStatus, roomRevenue, otherRevenue, marketCode, rateCode, roomCode, sourceOfBusiness, channelCode, propertyName;
                string[] email = new string[35];
                string[] resnNo = new string[35];

                // Retrive Data from Excel for email and Reservation No
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                for (int i = 1; i < 19; i++)
                {
                    email[i] = tt.GetCellData(worksheetname, 3, i + 1);
                    resnNo[i] = tt.GetCellData(worksheetname, 4, i + 1);
                }

                #endregion[Pre-requisites]

                #region[InsertStayNight]
                //Insert Stay and Night for Scenario 1 to 12
                for (int i = 1; i < 19; i++)
                {
                    //Get Customer id
                    Queries.GetCustomerIdByMemberEmail(data, email[i]);

                    //Retrive Values from Excel 
                    arrivalDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 9, i + 1))).ToString("yyyy-MM-dd");
                    departureDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 10, i + 1))).ToString("yyyy-MM-dd");
                    resCreationDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 16, i + 1))).ToString("yyyy-MM-dd");
                    stayStatus = tt.GetCellData(worksheetname, 6, i + 1);
                    roomRevenue = tt.GetCellData(worksheetname, 7, i + 1);
                    otherRevenue = tt.GetCellData(worksheetname, 8, i + 1);
                    marketCode = tt.GetCellData(worksheetname, 11, i + 1);
                    rateCode = tt.GetCellData(worksheetname, 12, i + 1);
                    roomCode = tt.GetCellData(worksheetname, 13, i + 1);
                    sourceOfBusiness = tt.GetCellData(worksheetname, 14, i + 1);
                    channelCode = tt.GetCellData(worksheetname, 15, i + 1);
                    propertyName = tt.GetCellData(worksheetname, 17, i + 1);

                    //Get Propert code and Cendyn Property ID by Property Name
                    Queries.GetProertyDetailsByName(data, propertyName);

                    //Insert Stay
                    resultid = Admin.InsertStay(Convert.ToInt32(data.CustomerID), data.PropertyCode, resnNo[i], arrivalDate, departureDate, "", data.SourceGuestId, data.PropertyId,
                        stayStatus, 1, 1, 1, 0, 1, marketCode, marketCode, otherRevenue, roomCode, roomRevenue, resCreationDate, null, sourceOfBusiness, "", rateCode, channelCode);

                    //Insert Night
                    Admin.InsertNight(Convert.ToInt32(resultid), Convert.ToInt32(data.CustomerID), data.PropertyCode, resnNo[i], arrivalDate, Convert.ToInt32(roomRevenue), 1, Convert.ToInt32(roomRevenue), rateCode);

                    //Run SP to start ETL
                    try { Queries.Start_ETL(); AddDelay(6000); } catch (Exception) { AddDelay(300000); }

                    //Run Service to process points 
                    Queries.ExecuteSPsToUpdatePointsAfterStatusChanged();

                }
                #endregion[InsertStayNight]
            }
        }
        public static void TC_InsertStay13_30()
        {
            if (TestCaseId == Constants.TC_InsertStay13_30)
            {

                #region[Pre-requisites]

                //Pre-requisites [Variable Declaration]
                Users data = new Users();
                string arrivalDate, departureDate, resCreationDate, resultid, FilePath, worksheetname, stayStatus, roomRevenue, otherRevenue, marketCode, rateCode, roomCode, sourceOfBusiness, channelCode, propertyName;
                string[] email = new string[37];
                string[] resnNo = new string[37];

                // Retrive Data from Excel for email and Reservation No
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                for (int i = 20; i < 37; i++)
                {
                    email[i] = tt.GetCellData(worksheetname, 3, i + 1);
                    resnNo[i] = tt.GetCellData(worksheetname, 4, i + 1);
                }
                #endregion[Pre-requisites]

                #region[InsertStayNight]
                //Insert Stay and Night for Scenario 13 to 30
                for (int i = 20; i < 37; i++)
                {
                    //Get Customer id
                    Queries.GetCustomerIdByMemberEmail(data, email[i]);

                    //Retrive Values from Excel 
                    arrivalDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 9, i + 1))).ToString("yyyy-MM-dd");
                    departureDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 10, i + 1))).ToString("yyyy-MM-dd");
                    resCreationDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 16, i + 1))).ToString("yyyy-MM-dd");
                    stayStatus = tt.GetCellData(worksheetname, 6, i + 1);
                    roomRevenue = tt.GetCellData(worksheetname, 7, i + 1);
                    otherRevenue = tt.GetCellData(worksheetname, 8, i + 1);
                    marketCode = tt.GetCellData(worksheetname, 11, i + 1);
                    rateCode = tt.GetCellData(worksheetname, 12, i + 1);
                    roomCode = tt.GetCellData(worksheetname, 13, i + 1);
                    sourceOfBusiness = tt.GetCellData(worksheetname, 14, i + 1);
                    channelCode = tt.GetCellData(worksheetname, 15, i + 1);
                    propertyName = tt.GetCellData(worksheetname, 17, i + 1);

                    //Get Propert code and Cendyn Property ID by Property Name
                    Queries.GetProertyDetailsByName(data, propertyName);

                    //Insert Stay
                    resultid = Admin.InsertStay(Convert.ToInt32(data.CustomerID), data.PropertyCode, resnNo[i], arrivalDate, departureDate, "", data.SourceGuestId, data.PropertyId, stayStatus, 1, 1, 1, 0, 1, marketCode, marketCode, otherRevenue, roomCode, roomRevenue, resCreationDate, null, sourceOfBusiness, "", rateCode, channelCode);

                    //Insert Night
                    Admin.InsertNight(Convert.ToInt32(resultid), Convert.ToInt32(data.CustomerID), data.PropertyCode, resnNo[i], arrivalDate, Convert.ToDecimal(roomRevenue), 1, Convert.ToDecimal(roomRevenue), rateCode);

                    //Run SP to start ETL
                    try { Queries.Start_ETL(); AddDelay(6000); } catch (Exception) { AddDelay(300000); }

                    //Run Service to process points 
                    Queries.ExecuteSPsToUpdatePointsAfterStatusChanged();


                }
                #endregion[InsertStayNight]

            }
        }

        #endregion Service Automation Pre-Requisite 

        #region Service Automation Pre-Requisite part-2
        public static void TC_InactiveRules1_4()
        {
            if (TestCaseId == Constants.TC_InactiveRules1_4)
            {
                Users data = new Users();
                //Pre-requisite[Variable Declaration]
                string rulename, FilePath, worksheetname;


                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Rules_Setup";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);

                // Retrive Data from Excel for Rule 
                for (int i = 18; i < 22; i++)
                {
                    rulename = tt.GetCellData(worksheetname, 1, i);

                    Admin.TC_InactiveRules1_4(data, rulename, 0);


                }

            }
        }



        public static void InsertStay21_29()
        {
            #region[Pre-requisites]

            //Pre-requisites [Variable Declaration]
            Users data = new Users();
            string stayDate, rate_Code, arrivalDate, departureDate, resCreationDate, resultid, FilePath, worksheetname,
                stayStatus, roomRevenue, otherRevenue, rateCode, marketCode, roomCode, sourceOfBusiness, channelCode,
                propertyName;
            decimal nightRate;
            string[] email = new string[37];
            string[] resnNo = new string[37];
            // Retrive Data from Excel for email and Reservation No
            FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
            worksheetname = "Nightly_Points_Rule_Scenario";
            TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
            for (int i = 1; i < 37; i++)
            {
                email[i] = tt.GetCellData(worksheetname, 3, i + 1);
                resnNo[i] = tt.GetCellData(worksheetname, 4, i + 1);
            }
            #endregion[Pre-requisites]

            #region[InsertStayNight]
            //Insert Stay and Night for Scenario 1 to 12
            for (int i = 1; i < 37; i++)
            {
                //Get Customer id
                Queries.GetCustomerIdByMemberEmail(data, email[i]);

                //Retrive Values from Excel 
                arrivalDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 12, i + 1))).ToString("yyyy-MM-dd");
                departureDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 13, i + 1))).ToString("yyyy-MM-dd");
                resCreationDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 19, i + 1))).ToString("yyyy-MM-dd");
                stayStatus = tt.GetCellData(worksheetname, 9, i + 1);
                roomRevenue = tt.GetCellData(worksheetname, 10, i + 1);
                otherRevenue = tt.GetCellData(worksheetname, 11, i + 1);
                marketCode = tt.GetCellData(worksheetname, 14, i + 1);
                rateCode = tt.GetCellData(worksheetname, 15, i + 1);
                roomCode = tt.GetCellData(worksheetname, 16, i + 1);
                sourceOfBusiness = tt.GetCellData(worksheetname, 17, i + 1);
                channelCode = tt.GetCellData(worksheetname, 18, i + 1);
                propertyName = tt.GetCellData(worksheetname, 21, i + 1);

                //Get Propert code and Cendyn Property ID by Property Name
                Queries.GetProertyDetailsByName(data, propertyName);

                //Insert Stay
                resultid = Admin.InsertStay(Convert.ToInt32(data.CustomerID), data.PropertyCode, resnNo[i], arrivalDate, departureDate, "", data.SourceGuestId, data.PropertyId, stayStatus, 3, 3, 1, 0, 1, marketCode, marketCode, otherRevenue, roomCode, roomRevenue, resCreationDate, null, sourceOfBusiness, "", rateCode, channelCode);

                for (int j = i; j < i + 3; j++)
                {
                    //Retrive Values from Excel 
                    stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, j + 2))).ToString("yyyy-MM-dd");
                    rate_Code = tt.GetCellData(worksheetname, 7, j + 2);
                    nightRate = Convert.ToDecimal(tt.GetCellData(worksheetname, 6, j + 2));
                    //Insert Night
                    Admin.InsertNight(Convert.ToInt32(resultid), Convert.ToInt32(data.CustomerID), data.PropertyCode, resnNo[i], stayDate, nightRate, 1, nightRate, rate_Code);
                }
                i = i + 3;
                #endregion[InsertStayNight]
            }
        }


        public static void InsertStay30_32()
        {

            #region[Pre-requisites]

            //Pre-requisites [Variable Declaration]
            Users data = new Users();
            string stayDate, rate_Code, arrivalDate, departureDate, resCreationDate, resultid, FilePath, worksheetname,
                stayStatus, roomRevenue, otherRevenue, rateCode, marketCode, roomCode, sourceOfBusiness, channelCode,
                propertyName;
            decimal nightRate;
            string[] email = new string[64];
            string[] resnNo = new string[64];

            // Retrive Data from Excel for email and Reservation No
            FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
            worksheetname = "Nightly_Points_Rule_Scenario";
            TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
            for (int i = 37; i < 64; i++)
            {
                email[i] = tt.GetCellData(worksheetname, 3, i + 1);
                resnNo[i] = tt.GetCellData(worksheetname, 4, i + 1);
            }
            #endregion[Pre-requisites]

            #region[InsertStayNight]
            //Insert Stay and Night for Scenario 1 to 12
            for (int i = 37; i < 64; i++)
            {
                //Get Customer id
                Queries.GetCustomerIdByMemberEmail(data, email[i]);

                //Retrive Values from Excel 
                arrivalDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 12, i + 1))).ToString("yyyy-MM-dd");
                departureDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 13, i + 1))).ToString("yyyy-MM-dd");
                resCreationDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 19, i + 1))).ToString("yyyy-MM-dd");
                stayStatus = tt.GetCellData(worksheetname, 9, i + 1);
                roomRevenue = tt.GetCellData(worksheetname, 10, i + 1);
                otherRevenue = tt.GetCellData(worksheetname, 11, i + 1);
                marketCode = tt.GetCellData(worksheetname, 14, i + 1);
                rateCode = tt.GetCellData(worksheetname, 15, i + 1);
                roomCode = tt.GetCellData(worksheetname, 16, i + 1);
                sourceOfBusiness = tt.GetCellData(worksheetname, 17, i + 1);
                channelCode = tt.GetCellData(worksheetname, 18, i + 1);
                propertyName = tt.GetCellData(worksheetname, 21, i + 1);

                //Get Propert code and Cendyn Property ID by Property Name
                Queries.GetProertyDetailsByName(data, propertyName);

                //Insert Stay
                resultid = Admin.InsertStay(Convert.ToInt32(data.CustomerID), data.PropertyCode, resnNo[i], arrivalDate, departureDate, "", data.SourceGuestId, data.PropertyId, stayStatus, 3, 3, 1, 0, 1, marketCode, marketCode, otherRevenue, roomCode, roomRevenue, resCreationDate, null, sourceOfBusiness, "", rateCode, channelCode);

                for (int j = i; j < i + 2; j++)
                {
                    //Retrive Values from Excel 
                    stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, j + 2))).ToString("yyyy-MM-dd");
                    rate_Code = tt.GetCellData(worksheetname, 7, j + 2);
                    nightRate = Convert.ToDecimal(tt.GetCellData(worksheetname, 6, j + 2));
                    //Insert Night
                    Admin.InsertNight(Convert.ToInt32(resultid), Convert.ToInt32(data.CustomerID), data.PropertyCode, resnNo[i], stayDate, nightRate, 1, nightRate, rate_Code);
                }
                i = i + 8;
            }
            #endregion[InsertStayNight]

        }

        public static void InsertStayFor33And35()
        {
            #region[Pre-requisites]

            //Pre-requisites [Variable Declaration]
            Users data = new Users();
            string stayDate, rate_Code, arrivalDate, departureDate, resCreationDate, resultid, FilePath, worksheetname,
                stayStatus, roomRevenue, otherRevenue, rateCode, marketCode, roomCode, sourceOfBusiness, channelCode,
                propertyName;
            decimal nightRate;
            string[] email = new string[84];
            string[] resnNo = new string[84];

            // Retrive Data from Excel for email and Reservation No
            FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
            worksheetname = "Nightly_Points_Rule_Scenario";
            TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
            for (int i = 64; i < 84; i++)
            {
                email[i] = tt.GetCellData(worksheetname, 3, i + 1);
                resnNo[i] = tt.GetCellData(worksheetname, 4, i + 1);
            }
            #endregion[Pre-requisites]

            #region[InsertStayNight]
            //Insert Stay and Night for Scenario 1 to 12
            for (int i = 64; i < 84; i++)
            {
                //Get Customer id
                Queries.GetCustomerIdByMemberEmail(data, email[i]);

                //Retrive Values from Excel 
                arrivalDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 12, i + 1))).ToString("yyyy-MM-dd");
                departureDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 13, i + 1))).ToString("yyyy-MM-dd");
                resCreationDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 19, i + 1))).ToString("yyyy-MM-dd");
                stayStatus = tt.GetCellData(worksheetname, 9, i + 1);
                roomRevenue = tt.GetCellData(worksheetname, 10, i + 1);
                otherRevenue = tt.GetCellData(worksheetname, 11, i + 1);
                marketCode = tt.GetCellData(worksheetname, 14, i + 1);
                rateCode = tt.GetCellData(worksheetname, 15, i + 1);
                roomCode = tt.GetCellData(worksheetname, 16, i + 1);
                sourceOfBusiness = tt.GetCellData(worksheetname, 17, i + 1);
                channelCode = tt.GetCellData(worksheetname, 18, i + 1);
                propertyName = tt.GetCellData(worksheetname, 21, i + 1);

                //Get Propert code and Cendyn Property ID by Property Name
                Queries.GetProertyDetailsByName(data, propertyName);

                //Insert Stay
                resultid = Admin.InsertStay(Convert.ToInt32(data.CustomerID), data.PropertyCode, resnNo[i], arrivalDate, departureDate, "", data.SourceGuestId, data.PropertyId, stayStatus, 3, 3, 1, 0, 1, marketCode, marketCode, otherRevenue, roomCode, roomRevenue, resCreationDate, null, sourceOfBusiness, "", rateCode, channelCode);

                for (int j = i; j < i + 2; j++)
                {
                    //Retrive Values from Excel 
                    stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, j + 2))).ToString("yyyy-MM-dd");
                    rate_Code = tt.GetCellData(worksheetname, 7, j + 2);
                    nightRate = Convert.ToDecimal(tt.GetCellData(worksheetname, 6, j + 2));
                    //Insert Night
                    Admin.InsertNight(Convert.ToInt32(resultid), Convert.ToInt32(data.CustomerID), data.PropertyCode, resnNo[i], stayDate, nightRate, 1, nightRate, rate_Code);
                }
                i = i + 9;
            }
            #endregion[InsertStayNight]

        }

        public static void InsertStayFor34()
        {

            #region[Pre-requisites]

            //Pre-requisites [Variable Declaration]
            Users data = new Users();
            string stayDate, rate_Code, arrivalDate, departureDate, resCreationDate, resultid, FilePath, worksheetname,
                stayStatus, roomRevenue, otherRevenue, rateCode, marketCode, roomCode, sourceOfBusiness, channelCode,
                propertyName;
            decimal nightRate;
            string[] email = new string[91];
            string[] resnNo = new string[91];

            // Retrive Data from Excel for email and Reservation No
            FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
            worksheetname = "Nightly_Points_Rule_Scenario";
            TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
            for (int i = 84; i < 91; i++)
            {
                email[i] = tt.GetCellData(worksheetname, 3, i + 1);
                resnNo[i] = tt.GetCellData(worksheetname, 4, i + 1);
            }
            #endregion[Pre-requisites]

            #region[InsertStayNight]
            //Insert Stay and Night for Scenario 1 to 12
            for (int i = 84; i < 91; i++)
            {
                //Get Customer id
                Queries.GetCustomerIdByMemberEmail(data, email[i]);

                //Retrive Values from Excel 
                arrivalDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 12, i + 1))).ToString("yyyy-MM-dd");
                departureDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 13, i + 1))).ToString("yyyy-MM-dd");
                resCreationDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 19, i + 1))).ToString("yyyy-MM-dd");
                stayStatus = tt.GetCellData(worksheetname, 9, i + 1);
                roomRevenue = tt.GetCellData(worksheetname, 10, i + 1);
                otherRevenue = tt.GetCellData(worksheetname, 11, i + 1);
                marketCode = tt.GetCellData(worksheetname, 14, i + 1);
                rateCode = tt.GetCellData(worksheetname, 15, i + 1);
                roomCode = tt.GetCellData(worksheetname, 16, i + 1);
                sourceOfBusiness = tt.GetCellData(worksheetname, 17, i + 1);
                channelCode = tt.GetCellData(worksheetname, 18, i + 1);
                propertyName = tt.GetCellData(worksheetname, 21, i + 1);

                //Get Propert code and Cendyn Property ID by Property Name
                Queries.GetProertyDetailsByName(data, propertyName);

                //Insert Stay
                resultid = Admin.InsertStay(Convert.ToInt32(data.CustomerID), data.PropertyCode, resnNo[i], arrivalDate, departureDate, "", data.SourceGuestId, data.PropertyId, stayStatus, 3, 3, 1, 0, 1, marketCode, marketCode, otherRevenue, roomCode, roomRevenue, resCreationDate, null, sourceOfBusiness, "", rateCode, channelCode);

                for (int j = i; j < i + 2; j++)
                {
                    //Retrive Values from Excel 
                    stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, j + 2))).ToString("yyyy-MM-dd");
                    rate_Code = tt.GetCellData(worksheetname, 7, j + 2);
                    nightRate = Convert.ToDecimal(tt.GetCellData(worksheetname, 6, j + 2));
                    //Insert Night
                    Admin.InsertNight(Convert.ToInt32(resultid), Convert.ToInt32(data.CustomerID), data.PropertyCode, resnNo[i], stayDate, nightRate, 1, nightRate, rate_Code);
                }
                i = i + 6;
            }
            #endregion[InsertStayNight]

        }

        public static void InsertStayFor36()
        {

            #region[Pre-requisites]

            //Pre-requisites [Variable Declaration]
            Users data = new Users();
            string stayDate, rate_Code, arrivalDate, departureDate, resCreationDate, resultid, FilePath, worksheetname,
                stayStatus, roomRevenue, otherRevenue, rateCode, marketCode, roomCode, sourceOfBusiness, channelCode,
                propertyName;
            decimal nightRate;
            string[] email = new string[101];
            string[] resnNo = new string[101];

            // Retrive Data from Excel for email and Reservation No
            FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
            worksheetname = "Nightly_Points_Rule_Scenario";
            TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
            for (int i = 91; i < 101; i++)
            {
                email[i] = tt.GetCellData(worksheetname, 3, i + 1);
                resnNo[i] = tt.GetCellData(worksheetname, 4, i + 1);
            }
            #endregion[Pre-requisites]

            #region[InsertStayNight]
            //Insert Stay and Night for Scenario 36
            for (int i = 91; i < 101; i++)
            {
                //Get Customer id
                Queries.GetCustomerIdByMemberEmail(data, email[i]);

                //Retrive Values from Excel 
                arrivalDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 12, i + 1))).ToString("yyyy-MM-dd");
                departureDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 13, i + 1))).ToString("yyyy-MM-dd");
                resCreationDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 19, i + 1))).ToString("yyyy-MM-dd");
                stayStatus = tt.GetCellData(worksheetname, 9, i + 1);
                roomRevenue = tt.GetCellData(worksheetname, 10, i + 1);
                otherRevenue = tt.GetCellData(worksheetname, 11, i + 1);
                marketCode = tt.GetCellData(worksheetname, 14, i + 1);
                rateCode = tt.GetCellData(worksheetname, 15, i + 1);
                roomCode = tt.GetCellData(worksheetname, 16, i + 1);
                sourceOfBusiness = tt.GetCellData(worksheetname, 17, i + 1);
                channelCode = tt.GetCellData(worksheetname, 18, i + 1);
                propertyName = tt.GetCellData(worksheetname, 21, i + 1);

                //Get Propert code and Cendyn Property ID by Property Name
                Queries.GetProertyDetailsByName(data, propertyName);

                //Insert Stay
                resultid = Admin.InsertStay(Convert.ToInt32(data.CustomerID), data.PropertyCode, resnNo[i], arrivalDate, departureDate, "", data.SourceGuestId, data.PropertyId, stayStatus, 3, 3, 1, 0, 1, marketCode, marketCode, otherRevenue, roomCode, roomRevenue, resCreationDate, null, sourceOfBusiness, "", rateCode, channelCode);

                for (int j = i; j < i + 2; j++)
                {
                    //Retrive Values from Excel 
                    stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, j + 2))).ToString("yyyy-MM-dd");
                    rate_Code = tt.GetCellData(worksheetname, 7, j + 2);
                    nightRate = Convert.ToDecimal(tt.GetCellData(worksheetname, 6, j + 2));
                    //Insert Night
                    Admin.InsertNight(Convert.ToInt32(resultid), Convert.ToInt32(data.CustomerID), data.PropertyCode, resnNo[i], stayDate, nightRate, 1, nightRate, rate_Code);
                }
                i = i + 9;
            }
            #endregion[InsertStayNight]

        }

        public static void InsertStayFor37()
        {

            #region[Pre-requisites]

            //Pre-requisites [Variable Declaration]
            Users data = new Users();
            string stayDate, rate_Code, arrivalDate, departureDate, resCreationDate, resultid, FilePath, worksheetname,
                stayStatus, roomRevenue, otherRevenue, rateCode, marketCode, roomCode, sourceOfBusiness, channelCode,
                propertyName;
            decimal nightRate;
            string[] email = new string[110];
            string[] resnNo = new string[110];

            // Retrive Data from Excel for email and Reservation No
            FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
            worksheetname = "Nightly_Points_Rule_Scenario";
            TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
            for (int i = 102; i < 110; i++)
            {
                email[i] = tt.GetCellData(worksheetname, 3, i + 1);
                resnNo[i] = tt.GetCellData(worksheetname, 4, i + 1);
            }
            #endregion[Pre-requisites]

            #region[InsertStayNight]
            //Insert Stay and Night for Scenario 36
            for (int i = 102; i < 110; i++)
            {
                //Get Customer id
                Queries.GetCustomerIdByMemberEmail(data, email[i]);

                //Retrive Values from Excel 
                arrivalDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 12, i + 1))).ToString("yyyy-MM-dd");
                departureDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 13, i + 1))).ToString("yyyy-MM-dd");
                resCreationDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 19, i + 1))).ToString("yyyy-MM-dd");
                stayStatus = tt.GetCellData(worksheetname, 9, i + 1);
                roomRevenue = tt.GetCellData(worksheetname, 10, i + 1);
                otherRevenue = tt.GetCellData(worksheetname, 11, i + 1);
                marketCode = tt.GetCellData(worksheetname, 14, i + 1);
                rateCode = tt.GetCellData(worksheetname, 15, i + 1);
                roomCode = tt.GetCellData(worksheetname, 16, i + 1);
                sourceOfBusiness = tt.GetCellData(worksheetname, 17, i + 1);
                channelCode = tt.GetCellData(worksheetname, 18, i + 1);
                propertyName = tt.GetCellData(worksheetname, 21, i + 1);

                //Get Propert code and Cendyn Property ID by Property Name
                Queries.GetProertyDetailsByName(data, propertyName);

                //Insert Stay
                resultid = Admin.InsertStay(Convert.ToInt32(data.CustomerID), data.PropertyCode, resnNo[i], arrivalDate, departureDate, "", data.SourceGuestId, data.PropertyId, stayStatus, 3, 3, 1, 0, 1, marketCode, marketCode, otherRevenue, roomCode, roomRevenue, resCreationDate, null, sourceOfBusiness, "", rateCode, channelCode);

                for (int j = i; j < i + 2; j++)
                {
                    //Retrive Values from Excel 
                    stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, j + 2))).ToString("yyyy-MM-dd");
                    rate_Code = tt.GetCellData(worksheetname, 7, j + 2);
                    nightRate = Convert.ToDecimal(tt.GetCellData(worksheetname, 6, j + 2));
                    //Insert Night
                    Admin.InsertNight(Convert.ToInt32(resultid), Convert.ToInt32(data.CustomerID), data.PropertyCode, resnNo[i], stayDate, nightRate, 1, nightRate, rate_Code);
                }
                i = i + 7;
            }
            #endregion[InsertStayNight]
        }

        public static void InsertStayFor38()
        {

            #region[Pre-requisites]

            //Pre-requisites [Variable Declaration]
            Users data = new Users();
            string stayDate, rate_Code, arrivalDate, departureDate, resCreationDate, resultid, FilePath, worksheetname,
                stayStatus, roomRevenue, otherRevenue, rateCode, marketCode, roomCode, sourceOfBusiness, channelCode,
                propertyName;
            decimal nightRate;
            string[] email = new string[133];
            string[] resnNo = new string[133];

            // Retrive Data from Excel for email and Reservation No
            FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
            worksheetname = "Nightly_Points_Rule_Scenario";
            TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
            for (int i = 110; i < 133; i++)
            {
                email[i] = tt.GetCellData(worksheetname, 3, i + 1);
                resnNo[i] = tt.GetCellData(worksheetname, 4, i + 1);
            }
            #endregion[Pre-requisites]

            #region[InsertStayNight]
            //Insert Stay and Night for Scenario 36
            for (int i = 110; i < 133; i++)
            {
                //Get Customer id
                Queries.GetCustomerIdByMemberEmail(data, email[i]);

                //Retrive Values from Excel 
                arrivalDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 12, i + 1))).ToString("yyyy-MM-dd");
                departureDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 13, i + 1))).ToString("yyyy-MM-dd");
                resCreationDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 19, i + 1))).ToString("yyyy-MM-dd");
                stayStatus = tt.GetCellData(worksheetname, 9, i + 1);
                roomRevenue = tt.GetCellData(worksheetname, 10, i + 1);
                otherRevenue = tt.GetCellData(worksheetname, 11, i + 1);
                marketCode = tt.GetCellData(worksheetname, 14, i + 1);
                rateCode = tt.GetCellData(worksheetname, 15, i + 1);
                roomCode = tt.GetCellData(worksheetname, 16, i + 1);
                sourceOfBusiness = tt.GetCellData(worksheetname, 17, i + 1);
                channelCode = tt.GetCellData(worksheetname, 18, i + 1);
                propertyName = tt.GetCellData(worksheetname, 21, i + 1);

                //Get Propert code and Cendyn Property ID by Property Name
                Queries.GetProertyDetailsByName(data, propertyName);

                //Insert Stay
                resultid = Admin.InsertStay(Convert.ToInt32(data.CustomerID), data.PropertyCode, resnNo[i], arrivalDate, departureDate, "", data.SourceGuestId, data.PropertyId, stayStatus, 3, 3, 1, 0, 1, marketCode, marketCode, otherRevenue, roomCode, roomRevenue, resCreationDate, null, sourceOfBusiness, "", rateCode, channelCode);

                for (int j = i; j < i + 5; j++)
                {
                    //Retrive Values from Excel 
                    stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, j + 2))).ToString("yyyy-MM-dd");
                    rate_Code = tt.GetCellData(worksheetname, 7, j + 2);
                    nightRate = Convert.ToDecimal(tt.GetCellData(worksheetname, 6, j + 2));
                    //Insert Night
                    Admin.InsertNight(Convert.ToInt32(resultid), Convert.ToInt32(data.CustomerID), data.PropertyCode, resnNo[i], stayDate, nightRate, 1, nightRate, rate_Code);
                }
                i = i + 22;
            }
            #endregion[InsertStayNight]

        }

        public static void InsertStayFor39()
        {

            #region[Pre-requisites]

            //Pre-requisites [Variable Declaration]
            Users data = new Users();
            string stayDate, rate_Code, arrivalDate, departureDate, resCreationDate, resultid, FilePath, worksheetname,
                stayStatus, roomRevenue, otherRevenue, rateCode, marketCode, roomCode, sourceOfBusiness, channelCode,
                propertyName;
            decimal nightRate;
            string[] email = new string[172];
            string[] resnNo = new string[172];

            // Retrive Data from Excel for email and Reservation No
            FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
            worksheetname = "Nightly_Points_Rule_Scenario";
            TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
            for (int i = 134; i < 172; i++)
            {
                email[i] = tt.GetCellData(worksheetname, 3, i + 1);
                resnNo[i] = tt.GetCellData(worksheetname, 4, i + 1);
            }
            #endregion[Pre-requisites]

            #region[InsertStayNight]
            //Insert Stay and Night for Scenario 36
            for (int i = 134; i < 172; i++)
            {
                //Get Customer id
                Queries.GetCustomerIdByMemberEmail(data, email[i]);

                //Retrive Values from Excel 
                arrivalDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 12, i + 1))).ToString("yyyy-MM-dd");
                departureDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 13, i + 1))).ToString("yyyy-MM-dd");
                resCreationDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 19, i + 1))).ToString("yyyy-MM-dd");
                stayStatus = tt.GetCellData(worksheetname, 9, i + 1);
                roomRevenue = tt.GetCellData(worksheetname, 10, i + 1);
                otherRevenue = tt.GetCellData(worksheetname, 11, i + 1);
                marketCode = tt.GetCellData(worksheetname, 14, i + 1);
                rateCode = tt.GetCellData(worksheetname, 15, i + 1);
                roomCode = tt.GetCellData(worksheetname, 16, i + 1);
                sourceOfBusiness = tt.GetCellData(worksheetname, 17, i + 1);
                channelCode = tt.GetCellData(worksheetname, 18, i + 1);
                propertyName = tt.GetCellData(worksheetname, 21, i + 1);

                //Get Propert code and Cendyn Property ID by Property Name
                Queries.GetProertyDetailsByName(data, propertyName);

                //Insert Stay
                resultid = Admin.InsertStay(Convert.ToInt32(data.CustomerID), data.PropertyCode, resnNo[i], arrivalDate, departureDate, "", data.SourceGuestId, data.PropertyId, stayStatus, 3, 3, 1, 0, 1, marketCode, marketCode, otherRevenue, roomCode, roomRevenue, resCreationDate, null, sourceOfBusiness, "", rateCode, channelCode);
                int count = 0;
                for (int j = i; j < i + 2; j++)
                {
                    count = count + 1;
                    //Retrive Values from Excel 
                    stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, j + 2))).ToString("yyyy-MM-dd");
                    rate_Code = tt.GetCellData(worksheetname, 7, j + 2);
                    nightRate = Convert.ToDecimal(tt.GetCellData(worksheetname, 6, j + 2));
                    //Insert Night
                    Admin.InsertNight(Convert.ToInt32(resultid), Convert.ToInt32(data.CustomerID), data.PropertyCode, resnNo[i], stayDate, nightRate, 1, nightRate, rate_Code);
                    if (resnNo[i].Contains("_1") && count == 2)
                    {
                        stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, j + 3))).ToString("yyyy-MM-dd");
                        rate_Code = tt.GetCellData(worksheetname, 7, j + 3);
                        nightRate = Convert.ToDecimal(tt.GetCellData(worksheetname, 6, j + 3));
                        //Insert Night
                        Admin.InsertNight(Convert.ToInt32(resultid), Convert.ToInt32(data.CustomerID), data.PropertyCode, resnNo[i], stayDate, nightRate, 1, nightRate, rate_Code);
                    }
                }
                if (resnNo[i].Contains("_2"))
                    i = i + 35;
                else if (resnNo[i].Contains("_1") && count == 2)
                    i = i + 3;
                else
                    i = i + 2;
            }
            #endregion[InsertStayNight]
        }

        public static void InsertStayFor40()
        {
            #region[Pre-requisites]

            //Pre-requisites [Variable Declaration]
            Users data = new Users();
            string stayDate, rate_Code, arrivalDate, departureDate, resCreationDate, resultid, FilePath, worksheetname,
            stayStatus, roomRevenue, otherRevenue, rateCode, marketCode, roomCode, sourceOfBusiness, channelCode,
            propertyName, nightRate_Null;
            decimal nightRate;
            string[] email = new string[193];
            string[] resnNo = new string[193];

            // Retrive Data from Excel for email and Reservation No
            FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
            worksheetname = "Nightly_Points_Rule_Scenario";
            TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
            for (int i = 172; i < 193; i++)
            {
                email[i] = tt.GetCellData(worksheetname, 3, i + 1);
                resnNo[i] = tt.GetCellData(worksheetname, 4, i + 1);
            }
            #endregion[Pre-requisites]
            #region[InsertStayNight]
            //Insert Stay and Night for Scenario 36
            for (int i = 172; i < 193; i++)
            {
                //Get Customer id
                Queries.GetCustomerIdByMemberEmail(data, email[i]);
                //Retrive Values from Excel 
                arrivalDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 12, i + 1))).ToString("yyyy-MM-dd");
                departureDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 13, i + 1))).ToString("yyyy-MM-dd");
                resCreationDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 19, i + 1))).ToString("yyyy-MM-dd");
                stayStatus = tt.GetCellData(worksheetname, 9, i + 1);
                roomRevenue = tt.GetCellData(worksheetname, 10, i + 1);
                otherRevenue = tt.GetCellData(worksheetname, 11, i + 1);
                marketCode = tt.GetCellData(worksheetname, 14, i + 1);
                rateCode = tt.GetCellData(worksheetname, 15, i + 1);
                roomCode = tt.GetCellData(worksheetname, 16, i + 1);
                sourceOfBusiness = tt.GetCellData(worksheetname, 17, i + 1);
                channelCode = tt.GetCellData(worksheetname, 18, i + 1);
                propertyName = tt.GetCellData(worksheetname, 21, i + 1);

                //Get Propert code and Cendyn Property ID by Property Name
                Queries.GetProertyDetailsByName(data, propertyName);

                //Insert Stay
                resultid = Admin.InsertStay(Convert.ToInt32(data.CustomerID), data.PropertyCode, resnNo[i], arrivalDate, departureDate, "", data.SourceGuestId, data.PropertyId, stayStatus, 3, 3, 1, 0, 1, marketCode, marketCode, otherRevenue, roomCode, roomRevenue, resCreationDate, null, sourceOfBusiness, "", rateCode, channelCode);
                int count = 0;
                for (int j = i; j < i + 6; j++)
                {
                    //Retrive Values from Excel 
                    count = count + 1;
                    stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, j + 2))).ToString("yyyy-MM-dd");
                    rate_Code = tt.GetCellData(worksheetname, 7, j + 2);
                    nightRate = Convert.ToDecimal(tt.GetCellData(worksheetname, 6, j + 2));
                    //Insert Night
                    Admin.InsertNight(Convert.ToInt32(resultid), Convert.ToInt32(data.CustomerID), data.PropertyCode, resnNo[i], stayDate, nightRate, 1, nightRate, rate_Code);
                    if (count == 6)
                    {
                        nightRate_Null = tt.GetCellData(worksheetname, 6, j + 9).ToLower();
                        if (nightRate_Null.Contains("null"))
                            nightRate_Null = null;
                        //get RateId value
                        Queries.GetStayRateIDByMemberEmailAndStayDate(data, email[i], stayDate, resnNo[i]);
                        Queries.UpdateNightRateWithNullRate(Convert.ToInt32(data.RateID), rate_Code, nightRate_Null, null, null);
                    }
                }
                i = i + 20;
            }
            #endregion[InsertStayNight]
        }

        public static void InsertStayFor41And42()
        {
            #region[Pre-requisites]

            //Pre-requisites [Variable Declaration]
            Users data = new Users();
            string stayDate, rate_Code, arrivalDate, departureDate, resCreationDate, resultid, FilePath, worksheetname,
                stayStatus, roomRevenue, otherRevenue, rateCode, marketCode, roomCode, sourceOfBusiness, channelCode,
                propertyName;
            decimal nightRate;
            string[] email = new string[205];
            string[] resnNo = new string[205];

            // Retrive Data from Excel for email and Reservation No
            FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
            worksheetname = "Nightly_Points_Rule_Scenario";
            TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
            for (int i = 193; i < 205; i++)
            {
                email[i] = tt.GetCellData(worksheetname, 3, i + 1);
                resnNo[i] = tt.GetCellData(worksheetname, 4, i + 1);
            }
            #endregion[Pre-requisites]

            #region[InsertStayNight]
            //Insert Stay and Night for Scenario 1 to 12
            for (int i = 193; i < 205; i++)
            {
                //Get Customer id
                Queries.GetCustomerIdByMemberEmail(data, email[i]);

                //Retrive Values from Excel 
                arrivalDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 12, i + 1))).ToString("yyyy-MM-dd");
                departureDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 13, i + 1))).ToString("yyyy-MM-dd");
                resCreationDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 19, i + 1))).ToString("yyyy-MM-dd");
                stayStatus = tt.GetCellData(worksheetname, 9, i + 1);
                roomRevenue = tt.GetCellData(worksheetname, 10, i + 1);
                otherRevenue = tt.GetCellData(worksheetname, 11, i + 1);
                marketCode = tt.GetCellData(worksheetname, 14, i + 1);
                rateCode = tt.GetCellData(worksheetname, 15, i + 1);
                roomCode = tt.GetCellData(worksheetname, 16, i + 1);
                sourceOfBusiness = tt.GetCellData(worksheetname, 17, i + 1);
                channelCode = tt.GetCellData(worksheetname, 18, i + 1);
                propertyName = tt.GetCellData(worksheetname, 21, i + 1);

                //Get Propert code and Cendyn Property ID by Property Name
                Queries.GetProertyDetailsByName(data, propertyName);

                //Insert Stay
                resultid = Admin.InsertStay(Convert.ToInt32(data.CustomerID), data.PropertyCode, resnNo[i], arrivalDate, departureDate, "", data.SourceGuestId, data.PropertyId, stayStatus, 3, 3, 1, 0, 1, marketCode, marketCode, otherRevenue, roomCode, roomRevenue, resCreationDate, null, sourceOfBusiness, "", rateCode, channelCode);

                for (int j = i; j < i + 2; j++)
                {
                    //Retrive Values from Excel 
                    stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, j + 2))).ToString("yyyy-MM-dd");
                    rate_Code = tt.GetCellData(worksheetname, 7, j + 2);
                    nightRate = Convert.ToDecimal(tt.GetCellData(worksheetname, 6, j + 2));
                    //Insert Night
                    Admin.InsertNight(Convert.ToInt32(resultid), Convert.ToInt32(data.CustomerID), data.PropertyCode, resnNo[i], stayDate, nightRate, 1, nightRate, rate_Code);
                }
                i = i + 5;
            }
            #endregion[InsertStayNight]
        }


        public static void TC_InsertStay21_42()
        {
            if (TestCaseId == Constants.TC_InsertStay21_42)
            {
                InsertStay21_29();
                InsertStay30_32();
                InsertStayFor33And35();
                InsertStayFor34();
                InsertStayFor36();
                InsertStayFor37();
                InsertStayFor38();
                InsertStayFor39();
                InsertStayFor40();
                InsertStayFor41And42();
                try { Queries.Start_ETL(); AddDelay(6000); } catch (Exception) { AddDelay(300000); }
                InsertAnotherStayFor41And42();
                try { Queries.Start_ETL(); AddDelay(6000); } catch (Exception) { AddDelay(300000); }
                Queries.ExecuteSPsToUpdatePointsAfterStatusChanged();
            }
        }

        public static void InsertAnotherStayFor41And42()
        {
            #region[Pre-requisites]

            //Pre-requisites [Variable Declaration]
            Users data = new Users();
            string stayDate, rate_Code, arrivalDate, departureDate, resCreationDate, resultid, FilePath, worksheetname,
                stayStatus, roomRevenue, otherRevenue, rateCode, marketCode, roomCode, sourceOfBusiness, channelCode,
                propertyName;
            decimal nightRate;
            string[] email = new string[205];
            string[] resnNo = new string[205];

            // Retrive Data from Excel for email and Reservation No
            FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
            worksheetname = "Nightly_Points_Rule_Scenario";
            TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
            for (int i = 193; i < 205; i++)
            {
                email[i] = tt.GetCellData(worksheetname, 3, i + 1);
                resnNo[i] = tt.GetCellData(worksheetname, 4, i + 1);
            }
            #endregion[Pre-requisites]

            #region[InsertStayNight]
            //Insert Stay and Night for Scenario 1 to 12
            for (int i = 193; i < 205; i++)
            {
                //Get Customer id
                Queries.GetCustomerIdByMemberEmail(data, email[i]);

                //Retrive Values from Excel 
                arrivalDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 12, i + 1))).ToString("yyyy-MM-dd");
                departureDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 13, i + 1))).ToString("yyyy-MM-dd");
                resCreationDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 19, i + 1))).ToString("yyyy-MM-dd");
                stayStatus = tt.GetCellData(worksheetname, 9, i + 1);
                roomRevenue = tt.GetCellData(worksheetname, 10, i + 1);
                otherRevenue = tt.GetCellData(worksheetname, 11, i + 1);
                marketCode = tt.GetCellData(worksheetname, 14, i + 1);
                rateCode = tt.GetCellData(worksheetname, 15, i + 1);
                roomCode = tt.GetCellData(worksheetname, 16, i + 1);
                sourceOfBusiness = tt.GetCellData(worksheetname, 17, i + 1);
                channelCode = tt.GetCellData(worksheetname, 18, i + 1);
                propertyName = tt.GetCellData(worksheetname, 21, i + 1);

                //Get Propert code and Cendyn Property ID by Property Name
                Queries.GetProertyDetailsByName(data, propertyName);

                //Insert Stay
                resultid = Admin.InsertStay(Convert.ToInt32(data.CustomerID), data.PropertyCode, resnNo[i], arrivalDate, departureDate, "", data.SourceGuestId, data.PropertyId, stayStatus, 3, 3, 1, 0, 1, marketCode, marketCode, otherRevenue, roomCode, roomRevenue, resCreationDate, null, sourceOfBusiness, "", rateCode, channelCode);

                for (int j = i; j < i + 2; j++)
                {
                    //Retrive Values from Excel 
                    stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, j + 5))).ToString("yyyy-MM-dd");
                    rate_Code = tt.GetCellData(worksheetname, 7, j + 5);
                    nightRate = Convert.ToDecimal(tt.GetCellData(worksheetname, 6, j + 5));
                    //Insert Night
                    Admin.InsertNight(Convert.ToInt32(resultid), Convert.ToInt32(data.CustomerID), data.PropertyCode, resnNo[i], stayDate, nightRate, 1, nightRate, rate_Code);
                }
                i = i + 5;
            }
            #endregion[InsertStayNight]
        }
        #endregion Service Automation Pre-Requisite part-2
        #region[Service_Preconditions]
        public static void TC_Restore_DB()
        {
            Queries.Restore_DB();
        }
        public static void TC_Backup_DB()
        {
            Users data = new Users();
            Queries.BackUp_DB(data);
        }
        #endregion[Service_Preconditions]
    }
}
