using System;
using System.Data;
using eLoyaltyV3.AppModule.UI;
using eLoyaltyV3.Entity;
using eLoyaltyV3.Utility;
using InfoMessageLogger;
using NUnit.Framework;
using TestData;
using Queries = eLoyaltyV3.Utility.Queries;


namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region Service Automation Scenario_Validation

        public static void TC_276900()
        {
            if (TestCaseId == Constants.TC_276900)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true;
                int sum = 0;

                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 2);
                reservationNo = tt.GetCellData(worksheetname, 4, 2);

                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 2));
                }
                string[] ruleName = new string[5]{"P_Rule_1", "P_Rule_2" , "P_Rule_3" , "P_Rule_4", "P_Rule_5"};
                string[] ExcelRuleName = new string [5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0": data.TransactionPoints;                   
                    
                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 2, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 2, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 2, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 2, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 2, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 2, sum.ToString());
                    Assert.Fail("Scenarion : Profile with 1 stay Fail");
                }
                #endregion[Rule Verification New]  
            }
        }
        public static void TC_276901()
        {
            if (TestCaseId == Constants.TC_276901)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true; 
                bool stayone = true, staytwo = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 3);
                #region[1st Stay]
                reservationNo = tt.GetCellData(worksheetname, 4, 3);              
                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 3));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 3, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 3, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 3, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 3, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 3, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 3, sum.ToString());
                    stayone = false;
                }
                #endregion[Rule Verification New]  
                #endregion[1st Stay]

                #region[2nd Stay]
                sum = 0;
                reservationNo = tt.GetCellData(worksheetname, 4, 4);
                //created variable to get expected points from excel sheet
                int[] ruleExpPt1 = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt1[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 4));
                }
                string[] ruleName1 = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName1 = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName1[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult1 = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName1[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt1[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName1[i], 4, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName1[i]} = {data.TransactionPoints}");
                        RuleResult1[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName1[i], 4, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult1[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult1[0] && RuleResult1[1] && RuleResult1[2] && RuleResult1[3] && RuleResult1[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 4, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 4, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 4, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 4, sum.ToString());
                    staytwo = false;
                }
                #endregion[Rule Verification New] 
                #endregion[2nd Stay]
                if (!(stayone && staytwo))
                Assert.Fail("Scenario : Profile with 2 stay Fail");
            }
        }

        public static void TC_276902()
        {
            if (TestCaseId == Constants.TC_276902)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true;
                bool stay1 = true, stay2 = true, stay3 = true, stay4 = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 5);

                #region[1st Stay]
                reservationNo = tt.GetCellData(worksheetname, 4, 5);
                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 5));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 5, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 5, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 5, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 5, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 5, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 5, sum.ToString());
                    stay1 = false;
                }
                #endregion[Rule Verification New]
                #endregion[1st Stay]
                #region[2nd Stay]
                reservationNo = tt.GetCellData(worksheetname, 4, 6);
                sum = 0;
                //created variable to get expected points from excel sheet
                int[] ruleExpPt1 = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt1[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 6));
                }
                string[] ruleName1 = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName1 = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName1[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult1 = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName1[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt1[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName1[i], 6, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName1[i]} = {data.TransactionPoints}");
                        RuleResult1[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName1[i], 6, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult1[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult1[0] && RuleResult1[1] && RuleResult1[2] && RuleResult1[3] && RuleResult1[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 6, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 6, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 6, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 6, sum.ToString());
                    stay2 = false;
                }
                #endregion[Rule Verification New]
                #endregion[2nd Stay]
                #region[3rd Stay]
                reservationNo = tt.GetCellData(worksheetname, 4, 7);      
                sum = 0;
                //created variable to get expected points from excel sheet
                int[] ruleExpPt2 = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt2[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 7));
                }
                string[] ruleName2 = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName2 = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName2[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult2 = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName2[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt2[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName2[i], 7, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName2[i]} = {data.TransactionPoints}");
                        RuleResult2[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName2[i], 7, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult2[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult2[0] && RuleResult2[1] && RuleResult2[2] && RuleResult2[3] && RuleResult2[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 7, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 7, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 7, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 7, sum.ToString());
                    stay3 = false;
                }
                #endregion[Rule Verification New]
                #endregion[3rd Stay]
                #region[4th Stay]
                reservationNo = tt.GetCellData(worksheetname, 4, 8);
                sum = 0;
                //created variable to get expected points from excel sheet
                int[] ruleExpPt3 = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt3[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 8));
                }
                string[] ruleName3 = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName3 = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName3[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult3 = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName3[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt3[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName3[i], 8, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName3[i]} = {data.TransactionPoints}");
                        RuleResult3[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName3[i], 8, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult3[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult3[0] && RuleResult3[1] && RuleResult3[2] && RuleResult3[3] && RuleResult3[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 8, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 8, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 8, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 8, sum.ToString());
                    stay4 = false;
                }
                #endregion[Rule Verification New]
                #endregion[4th Stay]           

                if (!(stay1 && stay2 && stay3 && stay4))
                    Assert.Fail("Scenario : Profile with 4 stay Fail");
            }
        }
        public static void TC_276903()
        {
            if (TestCaseId == Constants.TC_276903)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true, stay1 = true, stay2 = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 9);

                #region[1st Stay]
                reservationNo = tt.GetCellData(worksheetname, 4, 9);

                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 9));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 9, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 9, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 9, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 9, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 9, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 9, sum.ToString());
                    stay1 = false;
                }
                #endregion[Rule Verification New]

                #endregion[1st Stay]
                #region[2nd Stay]
                reservationNo = tt.GetCellData(worksheetname, 4, 10);
                rule1 = true; rule2 = true; rule3 = true; rule4 = true; rule5 = true;
                sum = 0;
                //created variable to get expected points from excel sheet
                int[] ruleExpPt1 = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt1[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 10));
                }
                string[] ruleName1 = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName1 = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName1[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult1 = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName1[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt1[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName1[i], 10, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName1[i]} = {data.TransactionPoints}");
                        RuleResult1[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName1[i], 10, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult1[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult1[0] && RuleResult1[1] && RuleResult1[2] && RuleResult1[3] && RuleResult1[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 10, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 10, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 10, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 10, sum.ToString());
                    stay2 = false;
                }
                #endregion[Rule Verification New]

                #endregion[2nd Stay]
                if (!(stay1 && stay2))
                    Assert.Fail("Scenarion : Consecutive Stay Fail");
            }
        }
        public static void TC_276904()
        {
            if (TestCaseId == Constants.TC_276904)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true, 
                bool stay1 = true, stay2 = true, stay3 = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 11);

                #region[1st Stay]
                reservationNo = tt.GetCellData(worksheetname, 4, 11);

                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 11));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 11, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 11, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 11, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 11, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 11, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 11, sum.ToString());
                    stay1 = false;
                }
                #endregion[Rule Verification New]
                #endregion[1st Stay]
                #region[2nd Stay]
                reservationNo = tt.GetCellData(worksheetname, 4, 12);
                //rule1 = true; rule2 = true; rule3 = true; rule4 = true; rule5 = true;
                sum = 0;
                //created variable to get expected points from excel sheet
                int[] ruleExpPt1 = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt1[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 12));
                }
                string[] ruleName1 = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName1 = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName1[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult1 = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName1[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt1[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName1[i], 12, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName1[i]} = {data.TransactionPoints}");
                        RuleResult1[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName1[i], 12, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult1[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult1[0] && RuleResult1[1] && RuleResult1[2] && RuleResult1[3] && RuleResult1[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 12, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 12, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 12, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 12, sum.ToString());
                    stay2 = false;
                }
                #endregion[Rule Verification New]
                #endregion[2nd Stay]
                #region[3rd Stay]
                reservationNo = tt.GetCellData(worksheetname, 4, 13);
                //rule1 = true; rule2 = true; rule3 = true; rule4 = true; rule5 = true;
                sum = 0;
                //created variable to get expected points from excel sheet
                int[] ruleExpPt2 = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt2[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 13));
                }
                string[] ruleName2 = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName2 = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName2[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult2 = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName2[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt2[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName2[i], 13, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName2[i]} = {data.TransactionPoints}");
                        RuleResult2[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName2[i], 13, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult2[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult2[0] && RuleResult2[1] && RuleResult2[2] && RuleResult2[3] && RuleResult2[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 13, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 13, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 13, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 13, sum.ToString());
                    stay3 = false;
                }
                #endregion[Rule Verification New]
                #endregion[3rd Stay]
                if (!(stay1 && stay2 && stay3))
                    Assert.Fail("Scenarion : Parallel Stay Fail");

            }
        }
        public static void TC_276905()
        {
            if (TestCaseId == Constants.TC_276905)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 14);
                reservationNo = tt.GetCellData(worksheetname, 4, 14);

                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 14));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 14, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 14, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 14, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 14, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 14, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 14, sum.ToString());
                    Assert.Fail("Scenario : Min Revenue Scenario Fail");
                }
                #endregion[Rule Verification New]  
            }
        }
        public static void TC_276906()
        {
            if (TestCaseId == Constants.TC_276906)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 15);
                reservationNo = tt.GetCellData(worksheetname, 4, 15);

                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 15));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 15, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 15, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 15, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 15, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 15, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 15, sum.ToString());
                    Assert.Fail("Scenario : Profile with Market Code Fail");
                }
                #endregion[Rule Verification New]  
            }
        }
        public static void TC_276907()
        {
            if (TestCaseId == Constants.TC_276907)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 16);
                reservationNo = tt.GetCellData(worksheetname, 4, 16);

                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 16));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 16, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 16, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 16, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 16, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 16, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 16, sum.ToString());
                    Assert.Fail("Scenario : Profile with Source Of Business Fail");
                }
                #endregion[Rule Verification New]  
            }
        }
        public static void TC_276908()
        {
            if (TestCaseId == Constants.TC_276908)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 17);
                reservationNo = tt.GetCellData(worksheetname, 4, 17);

                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 17));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 17, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 17, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 17, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 17, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 17, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 17, sum.ToString());
                    Assert.Fail("Scenario : Profile with Channel Code Fail");
                }
                #endregion[Rule Verification New]  
            }
        }
        public static void TC_276909()
        {
            if (TestCaseId == Constants.TC_276909)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 18);
                reservationNo = tt.GetCellData(worksheetname, 4, 18);

                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 18));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 18, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 18, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 18, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 18, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 18, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 18, sum.ToString());
                    Assert.Fail("Scenarion : Qualify Stay/Night_Hotel Fail");
                }
                #endregion[Rule Verification New]  
            }
        }
        public static void TC_276910()
        {
            if (TestCaseId == Constants.TC_276910)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 19);
                reservationNo = tt.GetCellData(worksheetname, 4, 19);

                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 19));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 19, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 19, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 19, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 19, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 19, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 19, sum.ToString());
                    Assert.Fail("Scenarion : Points are NOT earned as Expected");
                }
                #endregion[Rule Verification New]  
            }
        }
        public static void TC_276911()
        {
            if (TestCaseId == Constants.TC_276911)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 20);
                reservationNo = tt.GetCellData(worksheetname, 4, 20);

                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 20));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 20, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 20, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 20, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 20, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 20, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 20, sum.ToString());
                    Assert.Fail("Scenarion : Points are NOT earned as Expected");
                }
                #endregion[Rule Verification New]  
            }
        }
        public static void TC_276912()
        {
            if (TestCaseId == Constants.TC_276912)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 21);
                reservationNo = tt.GetCellData(worksheetname, 4, 21);

                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 21));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 21, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 21, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 21, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 21, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 21, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 21, sum.ToString());
                    Assert.Fail("Scenarion : Points are NOT earned as Expected");
                }
                #endregion[Rule Verification New]  
            }
        }
        public static void TC_276913()
        {
            if (TestCaseId == Constants.TC_276913)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 22);
                reservationNo = tt.GetCellData(worksheetname, 4, 22);

                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 22));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 22, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 22, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 22, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 22, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 22, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 22, sum.ToString());
                    Assert.Fail("Scenarion : Points are NOT earned as Expected");
                }
                #endregion[Rule Verification New]  
            }
        }
        public static void TC_276914()
        {
            if (TestCaseId == Constants.TC_276914)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 23);
                reservationNo = tt.GetCellData(worksheetname, 4, 23);

                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 23));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 23, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 23, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 23, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 23, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 23, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 23, sum.ToString());
                    Assert.Fail("Scenarion : Points are NOT earned as Expected");
                }
                #endregion[Rule Verification New]  
            }
        }
        public static void TC_276915()
        {
            if (TestCaseId == Constants.TC_276915)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 24);
                reservationNo = tt.GetCellData(worksheetname, 4, 24);

                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 24));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 24, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 24, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 24, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 24, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 24, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 24, sum.ToString());
                    Assert.Fail("Scenarion : Points are NOT earned as Expected");
                }
                #endregion[Rule Verification New]  
            }
        }
        public static void TC_276916()
        {
            if (TestCaseId == Constants.TC_276916)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 25);
                reservationNo = tt.GetCellData(worksheetname, 4, 25);

                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 25));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 25, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 25, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 25, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 25, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 25, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 25, sum.ToString());
                    Assert.Fail("Scenarion : Profile with decimal room revenue Fail");
                }
                #endregion[Rule Verification New]  
            }
        }
        public static void TC_276917()
        {
            if (TestCaseId == Constants.TC_276917)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 26);
                reservationNo = tt.GetCellData(worksheetname, 4, 26);

                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 26));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 26, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 26, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 26, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 26, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 26, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 26, sum.ToString());
                    Assert.Fail("Scenarion : Points are NOT earned as Expected");
                }
                #endregion[Rule Verification New]  
            }
        }
        public static void TC_276919()
        {
            if (TestCaseId == Constants.TC_276919)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 27);
                reservationNo = tt.GetCellData(worksheetname, 4, 27);

                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 27));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 27, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 27, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 27, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 27, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 27, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 27, sum.ToString());
                    Assert.Fail("Scenario : Points are NOT earned as Expected");
                }
                #endregion[Rule Verification New]  
            }

        }
        public static void TC_276920()
        {
            if (TestCaseId == Constants.TC_276920)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 28);
                reservationNo = tt.GetCellData(worksheetname, 4, 28);

                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 28));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 28, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 28, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 28, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 28, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 28, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 28, sum.ToString());
                    Assert.Fail("Scenarion : Points are NOT earned as Expected");
                }
                #endregion[Rule Verification New]  
            }
        }
        public static void TC_276921()
        {
            if (TestCaseId == Constants.TC_276921)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 29);
                reservationNo = tt.GetCellData(worksheetname, 4, 29);

                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 29));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 29, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 29, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 29, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 29, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 29, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 29, sum.ToString());
                    Assert.Fail("Scenarion : Points are NOT earned as Expected");
                }
                #endregion[Rule Verification New]  
            }
        }
        public static void TC_276922()
        {
            if (TestCaseId == Constants.TC_276922)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 30);
                reservationNo = tt.GetCellData(worksheetname, 4, 30);
                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 30));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 30, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 30, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 30, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 30, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 30, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 30, sum.ToString());
                    Assert.Fail("Scenarion : Points are NOT earned as Expected");
                }
                #endregion[Rule Verification New]  
            }
        }
        public static void TC_276923()
        {
            if (TestCaseId == Constants.TC_276923)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 31);
                reservationNo = tt.GetCellData(worksheetname, 4, 31);

                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 31));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 31, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 31, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 31, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 31, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 31, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 31, sum.ToString());
                    Assert.Fail("Scenarion : Points are NOT earned as Expected");
                }
                #endregion[Rule Verification New]
            }
        }
        public static void TC_276924()
        {
            if (TestCaseId == Constants.TC_276924)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 32);
                reservationNo = tt.GetCellData(worksheetname, 4, 32);

                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 32));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 32, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 32, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 32, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 32, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 32, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 32, sum.ToString());
                    Assert.Fail("Scenarion : Points are NOT earned as Expected");
                }
                #endregion[Rule Verification New]
            }
        }
        public static void TC_276925()
        {
            if (TestCaseId == Constants.TC_276925)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 33);
                reservationNo = tt.GetCellData(worksheetname, 4, 33);

                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 33));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 33, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 33, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 33, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 33, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 33, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 33, sum.ToString());
                    Assert.Fail("Scenarion : Points are NOT earned as Expected");
                }
                #endregion[Rule Verification New]
            }
        }
        public static void TC_276926()
        {
            if (TestCaseId == Constants.TC_276926)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 34);
                reservationNo = tt.GetCellData(worksheetname, 4, 34);

                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 34));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 34, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 34, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 34, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 34, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 34, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 34, sum.ToString());
                    Assert.Fail("Scenarion : Points are NOT earned as Expected");
                }
                #endregion[Rule Verification New]
            }
        }
        public static void TC_276927()
        {
            if (TestCaseId == Constants.TC_276927)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 35);
                reservationNo = tt.GetCellData(worksheetname, 4, 35);

                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 35));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 35, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 35, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 35, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 35, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 35, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 35, sum.ToString());
                    Assert.Fail("Scenarion : Points are NOT earned as Expected");
                }
                #endregion[Rule Verification New]
            }
        }
        public static void TC_276928()
        {
            if (TestCaseId == Constants.TC_276928)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 36);
                reservationNo = tt.GetCellData(worksheetname, 4, 36);

                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 36));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 36, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 36, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 36, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 36, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 36, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 36, sum.ToString());
                    Assert.Fail("Scenarion : Points are NOT earned as Expected");
                }
                #endregion[Rule Verification New]
            }
        }
        public static void TC_276929()
        {
            if (TestCaseId == Constants.TC_276929)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, reservationNo;
                //bool rule1 = true, rule2 = true, rule3 = true, rule4 = true, rule5 = true;
                int sum = 0;
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Criteria_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 37);
                reservationNo = tt.GetCellData(worksheetname, 4, 37);

                //created variable to get expected points from excel sheet
                int[] ruleExpPt = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ruleExpPt[i] = Convert.ToInt32(tt.GetCellData(worksheetname, i + 27, 37));
                }
                string[] ruleName = new string[5] { "P_Rule_1", "P_Rule_2", "P_Rule_3", "P_Rule_4", "P_Rule_5" };
                string[] ExcelRuleName = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    ExcelRuleName[i] = Convert.ToString(tt.GetCellData(worksheetname, i + 18, 1));
                }
                bool[] RuleResult = new bool[5];

                //Loop for Rules data read & write in excel sheet 
                #region[Point Earning Rule Data]
                for (int i = 0; i < 5; i++)
                {
                    Queries.GetRuleByName(data, ruleName[i]);
                    Queries.VerifyStayTransaction(data, email, data.RuleId, reservationNo);
                    data.TransactionPoints = String.IsNullOrEmpty(data.TransactionPoints) ? "0" : data.TransactionPoints;

                    if (Convert.ToInt32(data.TransactionPoints) == ruleExpPt[i])
                    {
                        tt.SetCellData(worksheetname, ExcelRuleName[i], 37, data.TransactionPoints);
                        sum = sum + Convert.ToInt32(data.TransactionPoints);
                        Logger.WriteInfoMessage($"Points are earned by Rule {ruleName[i]} = {data.TransactionPoints}");
                        RuleResult[i] = true;
                    }
                    else
                    {
                        {
                            tt.SetCellData(worksheetname, ExcelRuleName[i], 37, data.TransactionPoints);
                            sum = sum + Convert.ToInt32(data.TransactionPoints);
                        }
                        RuleResult[i] = false;
                    }
                }
                #endregion[Point Earning Rule Data]
                #region[Rule Verification New]
                if (RuleResult[0] && RuleResult[1] && RuleResult[2] && RuleResult[3] && RuleResult[4])
                {
                    Logger.WriteInfoMessage("Points are earned as Expected");
                    tt.SetCellData(worksheetname, "Result", 37, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 37, sum.ToString());
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 37, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 37, sum.ToString());
                    Assert.Fail("Scenarion : Points are NOT earned as Expected");
                }
                #endregion[Rule Verification New]
            }
        }
        #endregion Service Automation Scenario_Validation

        #region Service Automation Scenario_Validation - part2

        public static void TC_294921()
        {
            if (TestCaseId == Constants.TC_294921)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, stayDate;
                bool rule5 = true, stay1 = true, stay2 = true, stay3 = true;
                int expectedStay1Point, expectedStay2Point, expectedStay3Point;
                
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Nightly_Points_Rule_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 3);

                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 3))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 3));


                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate,data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 3, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 3, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 3, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 3, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 3, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 3, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 3, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 4))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 4));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 4, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 4, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 4, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 4, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 4, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 4, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 4, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #region[3rd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 5))).ToString("yyyy-MM-dd");
                expectedStay3Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 5));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay3Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 5, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 5, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 5, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 5, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 5, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 5, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 5, data.PointsRemaining);
                    stay3 = false;
                }
                #endregion[Rule Verification]
                #endregion[3rd Night]
                if (!(stay1 && stay2 && stay3))
                    Assert.Fail("Scenario: Checked In & Departure date past - Failed");

            }
        }

        public static void TC_294922()
        {
            if (TestCaseId == Constants.TC_294922)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, stayDate;
                bool rule5 = true, stay1 = true, stay2 = true, stay3 = true;
                int expectedStay1Point, expectedStay2Point, expectedStay3Point;

                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Nightly_Points_Rule_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 7);

                #region[1st Stay]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 7))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 7));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 7, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 7, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 7, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 7, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 7, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 7, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 7, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Stay]
                #region[2nd Stay]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 8))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 8));

                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 8, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 8, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 8, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 8, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 8, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 8, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 8, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Stay]
                #region[3rd Stay]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 9))).ToString("yyyy-MM-dd");
                expectedStay3Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 9));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay3Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 9, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 9, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 9, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 9, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 9, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 9, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 9, data.PointsRemaining);
                    stay3 = false;
                }
                #endregion[Rule Verification]
                #endregion[3rd Stay]
                if (!(stay1 && stay2 && stay3))
                    Assert.Fail("Scenario: Checked In & Departure date today - Failed");

            }
        }

        public static void TC_294923()
        {
            if (TestCaseId == Constants.TC_294923)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, stayDate;
                bool rule5 = true, stay1 = true, stay2 = true, stay3 = true;
                int expectedStay1Point, expectedStay2Point, expectedStay3Point;

                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Nightly_Points_Rule_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 11);

                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 11))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 11));


                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 11, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 11, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 11, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 11, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 11, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 11, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 11, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 12))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 12));

                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 12, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 12, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 12, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 12, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 12, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 12, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 12, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #region[3rd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 13))).ToString("yyyy-MM-dd");
                expectedStay3Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 13));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay3Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 13, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 13, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 13, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 13, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 13, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 13, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 13, data.PointsRemaining);
                    stay3 = false;
                }
                #endregion[Rule Verification]
                #endregion[3rd Night]
                if (!(stay1 && stay2 && stay3))
                    Assert.Fail("Scenario: Checked In & Departure date future - Failed");

            }
        }

        public static void TC_294924()
        {
            if (TestCaseId == Constants.TC_294924)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, stayDate;
                bool rule5 = true, stay1 = true, stay2 = true, stay3 = true;
                int expectedStay1Point, expectedStay2Point, expectedStay3Point;

                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Nightly_Points_Rule_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 15);

                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 15))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 15));

                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 15, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 15, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 15, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 15, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 15, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 15, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 15, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 16))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 16));

                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 16, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 16, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 16, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 16, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 16, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 16, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 16, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #region[3rd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 17))).ToString("yyyy-MM-dd");
                expectedStay3Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 17));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay3Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 17, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 17, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 17, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 17, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 17, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 17, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 17, data.PointsRemaining);
                    stay3 = false;
                }
                #endregion[Rule Verification]
                #endregion[3rd Night]
                if (!(stay1 && stay2 && stay3))
                    Assert.Fail("Scenario: Checked Out & Departure date past - Failed");
            }
        }

        public static void TC_294925()
        {
            if (TestCaseId == Constants.TC_294925)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, stayDate;
                bool rule5 = true, stay1 = true, stay2 = true, stay3 = true;
                int expectedStay1Point, expectedStay2Point, expectedStay3Point;

                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Nightly_Points_Rule_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 19);

                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 19))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 19));


                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 19, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 19, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 19, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 19, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 19, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 19, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 19, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 20))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 20));

                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 20, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 20, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 20, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 20, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 20, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 20, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 20, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #region[3rd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 21))).ToString("yyyy-MM-dd");
                expectedStay3Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 21));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay3Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 21, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 21, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 21, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 21, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 21, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 21, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 21, data.PointsRemaining);
                    stay3 = false;
                }
                #endregion[Rule Verification]
                #endregion[3rd Night]
                if (!(stay1 && stay2 && stay3))
                    Assert.Fail("Scenario: Checked Out & Departure date today - Failed");
            }
        }

        public static void TC_294926()
        {
            if (TestCaseId == Constants.TC_294926)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, stayDate;
                bool rule5 = true, stay1 = true, stay2 = true, stay3 = true;
                int  expectedStay1Point, expectedStay2Point, expectedStay3Point;

                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Nightly_Points_Rule_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 23);

                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 23))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 23));


                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 23, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 23, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 23, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 23, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 23, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 23, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 23, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 24))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 24));

                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 24, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 24, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 24, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 24, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 24, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 24, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 24, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #region[3rd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 25))).ToString("yyyy-MM-dd");
                expectedStay3Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 25));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay3Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 25, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 25, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 25, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 25, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 25, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 25, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 25, data.PointsRemaining);
                    stay3 = false;
                }
                #endregion[Rule Verification]
                #endregion[3rd Night]
                if (!(stay1 && stay2 && stay3))
                    Assert.Fail("Scenario: Checked Out & Departure date future (Next day) - Failed");

            }
        }

        public static void TC_294927()
        {
            if (TestCaseId == Constants.TC_294927)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, stayDate;
                bool rule5 = true, stay1 = true, stay2 = true, stay3 = true;
                int  expectedStay1Point, expectedStay2Point, expectedStay3Point;

                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Nightly_Points_Rule_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 27);

                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 27))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 27));

                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 27, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 27, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 27, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 27, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 27, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 27, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 27, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 28))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 28));

                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 28, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 28, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 28, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 28, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 28, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 28, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 28, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #region[3rd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 29))).ToString("yyyy-MM-dd");
                expectedStay3Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 29));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay3Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 29, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 29, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 29, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 29, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 29, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 29, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 29, data.PointsRemaining);
                    stay3 = false;
                }
                #endregion[Rule Verification]
                #endregion[3rd Night]
                if (!(stay1 && stay2 && stay3))
                    Assert.Fail("Scenario: Stay Status Reserved - Failed");

            }
        }


        public static void TC_294928()
        {
            if (TestCaseId == Constants.TC_294928)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, stayDate;
                bool rule5 = true, stay1 = true, stay2 = true, stay3 = true;
                int expectedStay1Point, expectedStay2Point, expectedStay3Point;

                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Nightly_Points_Rule_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 31);

                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 31))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 31));

                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 31, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 31, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 31, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 31, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 31, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 31, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 31, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 32))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 32));

                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 32, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 32, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 32, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 32, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 32, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 32, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 32, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #region[3rd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 33))).ToString("yyyy-MM-dd");
                expectedStay3Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 33));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay3Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 33, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 33, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 33, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 33, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 33, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 33, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 33, data.PointsRemaining);
                    stay3 = false;
                }
                #endregion[Rule Verification]
                #endregion[3rd Night]
                if (!(stay1 && stay2 && stay3))
                    Assert.Fail("Scenario: Stay Status No Show - Failed");

            }
        }

        public static void TC_294929()
        {
            if (TestCaseId == Constants.TC_294929)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, stayDate;
                bool rule5 = true, stay1 = true, stay2 = true, stay3 = true;
                int expectedStay1Point, expectedStay2Point, expectedStay3Point;

                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Nightly_Points_Rule_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 35);

                #region[1st Stay]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 35))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 35));


                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 35, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 35, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 35, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 35, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 35, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 35, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 35, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 36))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 36));

                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 36, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 36, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 36, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 36, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 36, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 36, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 36, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #region[3rd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 37))).ToString("yyyy-MM-dd");
                expectedStay3Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 37));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay3Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 37, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 37, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 37, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 37, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 37, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 37, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 37, data.PointsRemaining);
                    stay3 = false;
                }
                #endregion[Rule Verification]
                #endregion[3rd Night]
                if (!(stay1 && stay2 && stay3))
                    Assert.Fail("Scenario: Stay Status Canceled - Failed");

            }
        }

        public static void TC_294930()
        {
            if (TestCaseId == Constants.TC_294930)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, stayDate;
                bool rule5 = true, stay1 = true, stay2 = true, updateNight1 = true, updateNight2 = true, checkoutNight1 = true, checkoutNight2 = true;
                int expectedStay1Point, expectedStay2Point;
                
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Nightly_Points_Rule_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 39);

                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 39))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 39));

                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 39, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 39, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 39, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 39, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 39, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 39, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 39, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 40))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 40));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 40, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 40, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 40, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 40, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 40, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 40, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 40, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]

                #region[UpdateNightRateAndVerifyPoint]
                Admin.UpdateNightRateForServiceTestingPhaseTwo(FilePath, worksheetname, 42);
                //To update the point before start verification
                try { Queries.Start_ETL(); AddDelay(60000); } catch (Exception) { AddDelay(300000); }
                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 42))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 42));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 42, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 42, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 42, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 42, "Pass");
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 42, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 42, data.PointsRemaining);
                    updateNight1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                Admin.UpdateNightRateForServiceTestingPhaseTwo(FilePath, worksheetname, 43);
                //To update the point before start verification
                try { Queries.Start_ETL(); AddDelay(60000); } catch (Exception) { AddDelay(300000); }
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 43))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 43));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 43, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 43, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 43, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 43, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 43, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 43, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 43, data.PointsRemaining);
                    updateNight2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #endregion[UpdateNightRateAndverifyPoints]
                #region[UpdateStayStatusAndVerifyPoint]
                Admin.UpdateStayStatusForServiceTestingPhaseTwo(FilePath, worksheetname, 44);
                //To update the point before start verification
                try { Queries.Start_ETL(); AddDelay(20000); } catch (Exception) { AddDelay(300000); }
                Queries.ExecuteSPsToUpdatePointsAfterStatusChanged();
                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 45))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 45));

                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 45, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 45, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 45, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 45, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 45, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 45, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 45, data.PointsRemaining);
                    checkoutNight1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 46))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 46));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 46, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 46, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 46, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 46, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 46, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 46, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 46, data.PointsRemaining);
                    checkoutNight2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #endregion[UpdateStayStatusAndverifyPoints]
                if (!(stay1 && stay2 && updateNight1 && updateNight2 && checkoutNight1 && checkoutNight2))
                    Assert.Fail("Scenario: Fill in Gap Points when Nightly rate got increased - Failed");
            }
        }

        public static void TC_294931()
        {
            if (TestCaseId == Constants.TC_294931)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, stayDate;
                bool rule5 = true, stay1 = true, stay2 = true, updateNight1 = true, updateNight2 = true, checkoutNight1 = true, checkoutNight2 = true; 
                int  expectedStay1Point, expectedStay2Point;
                

                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Nightly_Points_Rule_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 48);

                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 48))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 48));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 48, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 48, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 48, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 48, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 48, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 48, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 48, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 49))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 49));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 49, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 49, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 49, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 49, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 49, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 49, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 49, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #region[UpdateNightRateAndVerifyPoint]
                Admin.UpdateNightRateForServiceTestingPhaseTwo(FilePath, worksheetname, 51);
                //To update the point before start verification
                try { Queries.Start_ETL(); } catch (Exception) { AddDelay(300000); }
                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 51))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 51));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 51, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 51, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 51, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 51, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 51, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 51, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 51, data.PointsRemaining);
                    updateNight1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                Admin.UpdateNightRateForServiceTestingPhaseTwo(FilePath, worksheetname, 52);
                //To update the point before start verification
                try { Queries.Start_ETL();} catch (Exception) { AddDelay(300000); }
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 52))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 52));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 52, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 52, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 52, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 52, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 52, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 52, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 52, data.PointsRemaining);
                    updateNight2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #endregion[UpdateNightRateAndverifyPoints]
                #region[UpdateStayStatusAndVerifyPoint]
                Admin.UpdateStayStatusForServiceTestingPhaseTwo(FilePath, worksheetname, 53);
                //To update the point before start verification
                try { Queries.Start_ETL(); AddDelay(120000); } catch (Exception) { AddDelay(300000); }
                Queries.ExecuteSPsToUpdatePointsAfterStatusChanged();
                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 54))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 54));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 54, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 54, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 54, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 54, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 54, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 54, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 54, data.PointsRemaining);
                    checkoutNight1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 55))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 55));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 55, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 55, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 55, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 55, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 55, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 55, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 55, data.PointsRemaining);
                    checkoutNight2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #endregion[UpdateStayStatusAndverifyPoints]
                if (!(stay1 && stay2 && updateNight1 && updateNight2 && checkoutNight1 && checkoutNight2))
                    Assert.Fail("Scenario: Difference is same when compared to points in last night - Failed");
            }
        }

        public static void TC_294932()
        {
            if (TestCaseId == Constants.TC_294932)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, stayDate;
                bool rule5 = true, stay1 = true, stay2 = true, updateNight1 = true, updateNight2 = true, checkoutNight1 = true, checkoutNight2 = true; 
                int  expectedStay1Point, expectedStay2Point;
                
                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Nightly_Points_Rule_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 57);

                #region[1st Stay]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 57))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 57));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 57, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 57, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 57, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 57, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 57, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 57, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 57, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Stay]
                #region[2nd Stay]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 58))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 58));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 58, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 58, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 58, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 58, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 58, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 58, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 58, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Stay]
                #region[UpdateNightRateAndVerifyPoint]
                Admin.UpdateNightRateForServiceTestingPhaseTwo(FilePath, worksheetname, 60);
                //To update the point before start verification
                //added in try catch because sometime the job is already running from a request by Schedule
                try { Queries.Start_ETL(); AddDelay(120000); } catch (Exception) { AddDelay(300000); }
                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 60))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 60));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 60, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 60, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 60, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 60, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 60, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 60, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 60, data.PointsRemaining);
                    updateNight1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                Admin.UpdateNightRateForServiceTestingPhaseTwo(FilePath, worksheetname, 61);
                //To update the point before start verification
                //added in try catch because sometime the job is already running from a request by Schedule
                try { Queries.Start_ETL(); AddDelay(120000); } catch (Exception) { AddDelay(300000); }
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 61))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 61));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 61, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 61, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 61, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 61, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 61, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 61, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 61, data.PointsRemaining);
                    updateNight2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #endregion[UpdateNightRateAndverifyPoints]
                #region[UpdateStayStatusAndVerifyPoint]
                Admin.UpdateStayStatusForServiceTestingPhaseTwo(FilePath, worksheetname, 62);
                //To update the point before start verification
                //added in try catch because sometime the job is already running from a request by Schedule
                try { Queries.Start_ETL(); AddDelay(120000); } catch (Exception) { AddDelay(300000); }
                Queries.ExecuteSPsToUpdatePointsAfterStatusChanged();
                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 63))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 63));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 63, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 63, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 63, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 63, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 63, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 63, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 63, data.PointsRemaining);
                    checkoutNight1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 64))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 64));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 64, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 64, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 64, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 64, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 64, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 64, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 64, data.PointsRemaining);
                    checkoutNight2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #endregion[UpdateStayStatusAndverifyPoints]
                if (!(stay1 && stay2 && updateNight1 && updateNight2 && checkoutNight1 && checkoutNight2))
                    Assert.Fail("Scenario: Difference is leSB when compared to points in last night  - Failed");


            }
        }

        public static void TC_294933()
        {
            if (TestCaseId == Constants.TC_294933)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, stayDate;
                bool rule5 = true, stay1 = true, stay2 = true, updateNight1 = true, updateNight2 = true, checkoutNight1 = true, checkoutNight2 = true; 
                int expectedStay1Point, expectedStay2Point;

                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Nightly_Points_Rule_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 66);

                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 66))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 66));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 66, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 66, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 66, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 66, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 66, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 66, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 66, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 67))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 67));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 67, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 67, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 67, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 67, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 67, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 67, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 67, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #region[RedeemPointsAndVerifyPoitns]
                Admin.RedeemPointsForServiceTestingPhaseTwo(FilePath, worksheetname, 68);
                try { Queries.Start_ETL(); AddDelay(60000); } catch (Exception) { AddDelay(300000); }
                #endregion[RedeemPointsAndVerifyPoitns]
                #region[UpdateNightRateAndVerifyPoint]
                Admin.UpdateNightRateForServiceTestingPhaseTwo(FilePath, worksheetname, 70);
                //To update the point before start verification
                //added in try catch because sometime the job is already running from a request by Schedule
                try { Queries.Start_ETL(); AddDelay(120000); } catch (Exception) { AddDelay(300000); }
                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 70))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 70));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 70, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 70, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 70, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 70, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 70, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 70, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 70, data.PointsRemaining);
                    updateNight1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                Admin.UpdateNightRateForServiceTestingPhaseTwo(FilePath, worksheetname, 71);
                //To update the point before start verification
                //added in try catch because sometime the job is already running from a request by Schedule
                try { Queries.Start_ETL(); AddDelay(120000); } catch (Exception) { AddDelay(300000); }
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 71))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 71));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 71, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 71, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 71, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 71, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 71, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 71, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 71, data.PointsRemaining);
                    updateNight2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #endregion[UpdateNightRateAndverifyPoints]
                #region[UpdateStayStatusAndVerifyPoint]
                Admin.UpdateStayStatusForServiceTestingPhaseTwo(FilePath, worksheetname, 72);
                //To update the point before start verification
                //added in try catch because sometime the job is already running from a request by Schedule
                try { Queries.Start_ETL(); AddDelay(120000); } catch (Exception) { AddDelay(300000); }
                Queries.ExecuteSPsToUpdatePointsAfterStatusChanged();
                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 73))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 73));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 73, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 73, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 73, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 73, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 73, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 73, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 73, data.PointsRemaining);
                    checkoutNight1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 74))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 74));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 74, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 74, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 74, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 74, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 74, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 74, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 74, data.PointsRemaining);
                    checkoutNight2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #endregion[UpdateStayStatusAndverifyPoints]
                if (!(stay1 && stay2 && updateNight1 && updateNight2 && checkoutNight1 && checkoutNight2))
                    Assert.Fail("Scenario: Difference is more when compared to points in last night - Failed");
            }
        }

        public static void TC_294935()
        {
            if (TestCaseId == Constants.TC_294935)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, stayDate;
                bool rule5 = true, stay1 = true, stay2 = true, updateNight1 = true, updateNight2 = true, checkoutNight1 = true, checkoutNight2 = true; 
                int expectedStay1Point, expectedStay2Point;

                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Nightly_Points_Rule_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 76);

                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 76))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 76));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 76, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 76, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 76, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 76, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 76, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 76, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 76, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 77))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 77));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 77, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 77, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 77, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 77, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 77, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 77, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 77, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #region[RedeemPointsAndVerifyPoitns]
                Admin.RedeemPointsForServiceTestingPhaseTwo(FilePath, worksheetname, 78);
                try { Queries.Start_ETL(); AddDelay(60000); } catch (Exception) { AddDelay(300000); }
                #endregion[RedeemPointsAndVerifyPoitns]
                #region[UpdateNightRateAndVerifyPoint]
                Admin.UpdateNightRateForServiceTestingPhaseTwo(FilePath, worksheetname, 80);
                //To update the point before start verification
                //added in try catch because sometime the job is already running from a request by Schedule
                try { Queries.Start_ETL(); AddDelay(120000); } catch (Exception) { AddDelay(300000); }
                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 80))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 80));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 80, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 80, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 80, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 80, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 80, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 80, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 80, data.PointsRemaining);
                    updateNight1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                Admin.UpdateNightRateForServiceTestingPhaseTwo(FilePath, worksheetname, 81);
                //To update the point before start verification
                //added in try catch because sometime the job is already running from a request by Schedule
                try { Queries.Start_ETL(); AddDelay(120000); } catch (Exception) { AddDelay(300000); }
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 81))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 81));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 81, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 81, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 81, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 81, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 81, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 81, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 81, data.PointsRemaining);
                    updateNight2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #endregion[UpdateNightRateAndverifyPoints]
                #region[UpdateStayStatusAndVerifyPoint]
                Admin.UpdateStayStatusForServiceTestingPhaseTwo(FilePath, worksheetname, 82);
                //To update the point before start verification
                //added in try catch because sometime the job is already running from a request by Schedule
                try { Queries.Start_ETL(); AddDelay(120000); } catch (Exception) { AddDelay(300000); }
                //Update the point in the DB 
                Queries.ExecuteSPsToUpdatePointsAfterStatusChanged();
                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 83))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 83));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 83, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 83, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 83, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 83, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 83, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 83, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 83, data.PointsRemaining);
                    checkoutNight1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 84))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 84));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 84, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 84, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 84, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 84, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 84, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 84, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 84, data.PointsRemaining);
                    checkoutNight2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #endregion[UpdateStayStatusAndverifyPoints]
                if (!(stay1 && stay2 && updateNight1 && updateNight2 && checkoutNight1 && checkoutNight2))
                    Assert.Fail("Scenario: Member redeems points before checkout and nightly rate got increased - Failed");

            }
        }

        public static void TC_294934()
        {
            if (TestCaseId == Constants.TC_294934)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, stayDate;
                bool rule5 = true, stay1 = true, stay2 = true, checkoutNight1 = true, checkoutNight2 = true; ;
                int expectedStay1Point, expectedStay2Point;

                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Nightly_Points_Rule_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 86);

                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 86))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 86));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 86, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 86, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 86, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 86, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 86, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 86, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 86, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 87))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 87));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 87, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 87, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 87, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 87, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 87, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 87, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 87, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #region[RedeemPointsAndVerifyPoitns]
                Admin.RedeemPointsForServiceTestingPhaseTwo(FilePath, worksheetname, 88);
                try { Queries.Start_ETL(); AddDelay(60000); } catch (Exception) { AddDelay(300000); }
                #endregion[RedeemPointsAndVerifyPoitns]
                #region[UpdateStayStatusAndVerifyPoint]
                Admin.UpdateStayStatusForServiceTestingPhaseTwo(FilePath, worksheetname, 89);
                //To update the point before start verification
                //added in try catch because sometime the job is already running from a request by Schedule
                try { Queries.Start_ETL(); AddDelay(120000); } catch (Exception) { AddDelay(300000); }
                //Update the point in the DB 
                Queries.ExecuteSPsToUpdatePointsAfterStatusChanged();
                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 90))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 90));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 90, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 90, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 90, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 90, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 90, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 90, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 90, data.PointsRemaining);
                    checkoutNight1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 91))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 91));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 91, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 91, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 91, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 91, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 91, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 91, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 91, data.PointsRemaining);
                    checkoutNight2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #endregion[UpdateStayStatusAndverifyPoints]
                if (!(stay1 && stay2 && checkoutNight1 && checkoutNight2))
                    Assert.Fail("Scenario: Member redeems points before checkout - Failed");
            }
        }

        public static void TC_294936()
        {
            if (TestCaseId == Constants.TC_294936)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, stayDate;
                bool rule5 = true, stay1 = true, stay2 = true, updateNight1 = true, updateNight2 = true, checkoutNight1 = true, checkoutNight2 = true; 
                int expectedStay1Point, expectedStay2Point;

                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Nightly_Points_Rule_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 93);

                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 93))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 93));


                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 93, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 93, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 93, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 93, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 93, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 93, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 93, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 94))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 94));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 94, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 94, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 94, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 94, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 94, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 94, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 94, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #region[RedeemPointsAndVerifyPoitns]
                Admin.RedeemPointsForServiceTestingPhaseTwo(FilePath, worksheetname, 95);
                try { Queries.Start_ETL(); AddDelay(60000); } catch (Exception) { AddDelay(300000); }
                #endregion[RedeemPointsAndVerifyPoitns]
                #region[UpdateStayStatusAndVerifyPoint]
                Admin.UpdateStayStatusForServiceTestingPhaseTwo(FilePath, worksheetname, 96);
                //To update the point before start verification
                //added in try catch because sometime the job is already running from a request by Schedule
                try { Queries.Start_ETL(); AddDelay(120000); } catch (Exception) { AddDelay(300000); }
                Queries.ExecuteSPsToUpdatePointsAfterStatusChanged();
                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 97))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 97));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 97, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 97, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 97, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 97, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 97, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 97, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 97, data.PointsRemaining);
                    checkoutNight1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 98))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 98));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 98, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 98, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 98, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 98, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 98, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 98, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 98, data.PointsRemaining);
                    checkoutNight2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #endregion[UpdateStayStatusAndverifyPoints]
                #region[UpdateNightRateAndVerifyPoint]
                Admin.UpdateNightRateForServiceTestingPhaseTwo(FilePath, worksheetname, 100);
                //To update the point before start verification
                //added in try catch because sometime the job is already running from a request by Schedule
                try { Queries.Start_ETL(); AddDelay(120000); } catch (Exception) { AddDelay(300000); }
                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 100))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 100));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 100, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 100, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 100, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 100, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 100, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 100, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 100, data.PointsRemaining);
                    updateNight1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                Admin.UpdateNightRateForServiceTestingPhaseTwo(FilePath, worksheetname, 101);
                //To update the point before start verification
                //added in try catch because sometime the job is already running from a request by Schedule
                try { Queries.Start_ETL(); AddDelay(120000); } catch (Exception) { AddDelay(300000); }
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 101))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 101));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 101, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 101, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 101, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 101, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 101, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 101, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 101, data.PointsRemaining);
                    updateNight2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #endregion[UpdateNightRateAndverifyPoints]
                if (!(stay1 && stay2 && checkoutNight1 && checkoutNight2 && updateNight1 && updateNight2))
                    Assert.Fail("Scenario: Member redeems points before checkout and nightly rate got decreased after checkout - Failed");
            }
        }

        public static void TC_294937()
        {
            if (TestCaseId == Constants.TC_294937)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, stayDate, worksheetname1, departureDate;
                bool rule5 = true, stay1 = true, stay2 = true, day1Night1 = true, day1Night2 = true, day2Night1 = true, day2Night2 = true;
                int  expectedStay1Point, expectedStay2Point;

                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Nightly_Points_Rule_Scenario";
                worksheetname1 = "Rules_Setup";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 104);

                //TransactionCloseDelayHours' is set as 24 in Propertysetting table, gap analysis will only happen 24 hours after the departure date
                Queries.SetupTransactionCloseDelayHours("TransactionCloseDelayHours", "24");
                

                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 104))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 104));

                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 104, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 104, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 104, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 104, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 104, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 104, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 104, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 105))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 105));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 105, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 105, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 105, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 105, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 105, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 105, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 105, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #region[UpdateStayStatusAndVerifyDay1Points]
                Admin.UpdateStayStatusForServiceTestingPhaseTwo(FilePath, worksheetname, 106);
                //To update the point before start verification
                try { Queries.Start_ETL(); AddDelay(120000); } catch (Exception) { AddDelay(300000); }
                
                Queries.ExecuteSPsToUpdatePointsAfterStatusChanged();
                #region[Day1 1st Night]
                rule5 = true;
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 107))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 107));

                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 107, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 107, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 107, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 107, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 107, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 107, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 107, data.PointsRemaining);
                    day1Night1 = false;
                }
                #endregion[Rule Verification]
                #endregion[Day1 1st Night]
                #region[Day1 2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 108))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 108));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 108, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 108, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 108, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 108, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 108, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 108, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 108, data.PointsRemaining);
                    day1Night2 = false;
                }
                #endregion[Rule Verification]
                #endregion[Day1 2nd Night]
                #endregion[UpdateStayStatusAndVerifyDay1Points]

                #region[SimulateDateAndVerifyDay2Points]
                Admin.SimulateDateForSpecificData(FilePath, worksheetname, 103, worksheetname1, 22);
                departureDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 13, 103))).ToString("yyyy-MM-dd");
                Queries.ExecuteSPsToUpdatePointsAfterDateSimulate(departureDate);
                Admin.SimulateDateForSpecificData24Hours(FilePath, worksheetname, 103, worksheetname1, 22);
                departureDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 6, 103))).ToString("yyyy-MM-dd");
                Queries.ExecuteSPsToUpdatePointsAfterDateSimulate(departureDate);
                #region[Day2 1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 109))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 109));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 109, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 109, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 109, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 109, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 109, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 109, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 109, data.PointsRemaining);
                    day1Night1 = false;
                }
                #endregion[Rule Verification]
                #endregion[Day2 1st Night]
                #region[Day2 2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 110))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 110));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 110, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 110, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 110, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 110, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 110, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 110, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 110, data.PointsRemaining);
                    day1Night2 = false;
                }
                #endregion[Rule Verification]
                #endregion[Day2 2nd Night]
                #endregion[SimulateDateAndVerifyDay2Points]
                //TransactionCloseDelayHours' is set as 0 in Propertysetting table
                Queries.SetupTransactionCloseDelayHours("TransactionCloseDelayHours", "0");
                if (!(stay1 && stay2 && day1Night1 && day1Night2 && day2Night1 && day2Night2))
                    Assert.Fail("scenario: Fill in Gap happens after 24 hours - failed");
            }
        }

        public static void TC_294938()
        {
            if (TestCaseId == Constants.TC_294938)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, stayDate, worksheetname1, departureDate;
                bool rule5 = true, stay1 = true, stay2 = true, stay3 = true, stay4 = true, stay5 = true;
                int expectedStay1Point, expectedStay2Point, expectedStay3Point, expectedStay4Point, expectedStay5Point;

                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Nightly_Points_Rule_Scenario";
                worksheetname1 = "Rules_Setup";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 112);

                #region[Day1-1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 112))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 112));

                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 112, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 112, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 112, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 112, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 112, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 112, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 112, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[Day1- 1st Night]
                #region[Day1- 2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 113))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 113));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 113, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 113, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 113, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 113, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 113, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 113, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 113, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[Day1- 2nd Night]
                #region[Day1- 3rd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 114))).ToString("yyyy-MM-dd");
                expectedStay3Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 114));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay3Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 114, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 114, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 114, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 114, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 114, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 114, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 114, data.PointsRemaining);
                    stay3 = false;
                }
                #endregion[Rule Verification]
                #endregion[Day1- 3rd Night]
                #region[Day1- 4th Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 115))).ToString("yyyy-MM-dd");
                expectedStay4Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 115));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay4Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 115, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 115, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 115, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 115, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 115, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 115, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 115, data.PointsRemaining);
                    stay4 = false;
                }
                #endregion[Rule Verification]
                #endregion[Day1- 4th Night]
                #region[Day1- 5th Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 116))).ToString("yyyy-MM-dd");
                expectedStay5Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 116));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay5Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 116, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 116, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 116, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 116, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 116, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 116, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 116, data.PointsRemaining);
                    stay5 = false;
                }
                #endregion[Rule Verification]
                #endregion[Day1- 5th Night]
                #region[Update Rate Code to eligible and verify points]
                Admin.UpdateNightRateForServiceTestingPhaseTwo(FilePath, worksheetname, 121);
                Admin.UpdateNightRateForServiceTestingPhaseTwo(FilePath, worksheetname, 122);
                try { Queries.Start_ETL(); AddDelay(120000); } catch (Exception) { AddDelay(300000); }
                #region[Day1-1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 118))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 118));

                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 118, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 118, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 118, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 118, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 118, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 118, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 118, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[Day1- 1st Night]
                #region[Day1- 2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 119))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 119));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 119, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 119, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 119, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 119, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 119, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 119, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 119, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[Day1- 2nd Night]
                #region[Day1- 3rd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 120))).ToString("yyyy-MM-dd");
                expectedStay3Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 120));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay3Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 120, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 120, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 120, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 120, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 120, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 120, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 120, data.PointsRemaining);
                    stay3 = false;
                }
                #endregion[Rule Verification]
                #endregion[Day1- 3rd Night]
                #region[Day1- 4th Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 121))).ToString("yyyy-MM-dd");
                expectedStay4Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 121));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay4Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 121, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 121, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 121, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 121, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 121, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 121, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 121, data.PointsRemaining);
                    stay4 = false;
                }
                #endregion[Rule Verification]
                #endregion[Day1- 4th Night]
                #region[Day1- 5th Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 122))).ToString("yyyy-MM-dd");
                expectedStay5Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 122));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay5Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 122, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 122, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 122, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 122, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 122, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 122, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 122, data.PointsRemaining);
                    stay5 = false;
                }
                #endregion[Rule Verification]
                #endregion[Day1- 5th Night]
                #endregion[Update Rate Code to eligible and verify points]
                
                #region[Day2- 1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 123))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 123));

                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 123, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 123, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 123, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 123, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 123, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 123, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 123, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[Day2- 1st Night]
                #region[Day2- 2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 124))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 124));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 124, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 124, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 124, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 124, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 124, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 124, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 124, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[Day2- 2nd Night]
                #region[Day2- 3rd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 125))).ToString("yyyy-MM-dd");
                expectedStay3Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 125));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay3Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 125, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 125, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 125, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 125, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 125, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 125, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 125, data.PointsRemaining);
                    stay3 = false;
                }
                #endregion[Rule Verification]
                #endregion[Day2- 3rd Night]
                #region[Day2- 4th Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 126))).ToString("yyyy-MM-dd");
                expectedStay4Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 126));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay4Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 126, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 126, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 126, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 126, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 126, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 126, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 126, data.PointsRemaining);
                    stay4 = false;
                }
                #endregion[Rule Verification]
                #endregion[Day2- 4th Night]
                #region[Day2- 5th Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 127))).ToString("yyyy-MM-dd");
                expectedStay5Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 127));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay5Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 127, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 127, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 127, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 127, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 127, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 127, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 127, data.PointsRemaining);
                    stay5 = false;
                }
                #endregion[Rule Verification]
                #endregion[Day2- 5th Night]
                
                #region[UpdateStayStatusAndVerifyDay2PointAndCallSimulateSP]
                Admin.UpdateStayStatusForServiceTestingPhaseTwo(FilePath, worksheetname, 128);
                //To update the point before start verification
                //added in try catch because sometime the job is already running from a request by Schedule
                try { Queries.Start_ETL(); AddDelay(120000); } catch (Exception) { AddDelay(300000); }
                Queries.ExecuteSPsToUpdatePointsAfterStatusChanged();
                Admin.SimulateDateForSpecificData(FilePath, worksheetname, 111, worksheetname1, 22);
                departureDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 13, 111))).ToString("yyyy-MM-dd");
                Queries.ExecuteSPsToUpdatePointsAfterDateSimulate(departureDate);
                #region[Day2- 1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 129))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 129));

                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 129, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 129, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 129, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 129, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 129, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 129, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 129, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[Day2- 1st Night]
                #region[Day2- 2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 130))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 130));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 130, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 130, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 130, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 130, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 130, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 130, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 130, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[Day2- 2nd Night]
                #region[Day2- 3rd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 131))).ToString("yyyy-MM-dd");
                expectedStay3Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 131));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay3Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 131, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 131, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 131, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 131, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 131, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 131, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 131, data.PointsRemaining);
                    stay3 = false;
                }
                #endregion[Rule Verification]
                #endregion[Day2- 3rd Night]
                #region[Day2- 4th Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 132))).ToString("yyyy-MM-dd");
                expectedStay4Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 132));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay4Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 132, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 132, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 132, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 132, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 132, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 132, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 132, data.PointsRemaining);
                    stay4 = false;
                }
                #endregion[Rule Verification]
                #endregion[Day2- 4th Night]
                #region[Day2- 5th Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 133))).ToString("yyyy-MM-dd");
                expectedStay5Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 133));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay5Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 133, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 133, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 133, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 133, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 133, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 133, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 133, data.PointsRemaining);
                    stay5 = false;
                }
                #endregion[Rule Verification]
                #endregion[Day2- 5th Night]
                #endregion[UpdateStayStatusAndVerifyDay2PointAndCallSimulateSP]
                if (!(stay1 && stay2 && stay3 && stay4 && stay5))
                    Assert.Fail("Scenario: Rate Code got Updated from Ineligible to Eligible[departure date as tomorrow with 5 nights] - Failed");
            }
        }

        public static void TC_294939()
        {
            if (TestCaseId == Constants.TC_294939)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, stayDate, worksheetname1, departureDate;
                bool rule5 = true, stay1 = true, stay2 = true, stay3 = true; ;
                int expectedStay1Night1Point, expectedStay1Night2Point, expectedStay2Night1Point, expectedStay2Night2Point, expectedStay2Night3Point, expectedStay3Night1Point, expectedStay3Night2Point;

                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Nightly_Points_Rule_Scenario";
                worksheetname1 = "Rules_Setup";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 136);

                #region[1st Stay]
                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 136))).ToString("yyyy-MM-dd");
                expectedStay1Night1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 136));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Night1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 136, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 136, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 136, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 136, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 136, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 136, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 136, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 137))).ToString("yyyy-MM-dd");
                expectedStay1Night2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 137));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Night2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 137, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 137, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 137, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 137, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 137, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 137, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 137, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #endregion[1st Stay]
                #region[2nd Stay]
                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 139))).ToString("yyyy-MM-dd");
                expectedStay2Night1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 139));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Night1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 139, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 139, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 139, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 139, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 139, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 139, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 139, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 140))).ToString("yyyy-MM-dd");
                expectedStay2Night2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 140));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Night2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 140, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 140, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 140, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 140, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 140, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 140, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 140, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #region[3rd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 141))).ToString("yyyy-MM-dd");
                expectedStay2Night3Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 141));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Night3Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 141, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 141, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 141, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 141, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 141, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 141, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 141, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[3rd Night]
                #endregion[2nd Stay]
                #region[3rd Stay]
                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 143))).ToString("yyyy-MM-dd");
                expectedStay3Night1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 143));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay3Night1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 143, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 143, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 143, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 143, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 143, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 143, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 143, data.PointsRemaining);
                    stay3 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]

                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 144))).ToString("yyyy-MM-dd");
                expectedStay3Night2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 144));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay3Night2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 144, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 144, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 144, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 144, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 144, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 144, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 144, data.PointsRemaining);
                    stay3 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #endregion[3rd Stay]
                #region[Update Market Sub Segment to ineligible for all 3 stays and verify points]
                Admin.UpdateMarketSubSegmentForSpecificData(FilePath, worksheetname, 146);
                Admin.UpdateMarketSubSegmentForSpecificData(FilePath, worksheetname, 149);
                Admin.UpdateMarketSubSegmentForSpecificData(FilePath, worksheetname, 153);
                try { Queries.Start_ETL(); AddDelay(120000); } catch (Exception) { AddDelay(300000); }

                #region[1st Stay]
                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 147))).ToString("yyyy-MM-dd");
                expectedStay1Night1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 147));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Night1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 147, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 147, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 147, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 147, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 147, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 147, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 147, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 148))).ToString("yyyy-MM-dd");
                expectedStay1Night2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 148));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Night2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 148, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 148, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 148, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 148, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 148, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 148, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 148, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #endregion[1st Stay]
                #region[2nd Stay]
                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 150))).ToString("yyyy-MM-dd");
                expectedStay2Night1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 150));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Night1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 150, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 150, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 150, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 150, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 150, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 150, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 150, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 151))).ToString("yyyy-MM-dd");
                expectedStay2Night2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 151));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Night2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 151, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 151, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 151, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 151, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 151, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 151, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 151, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #region[3rd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 152))).ToString("yyyy-MM-dd");
                expectedStay2Night3Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 152));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Night3Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 152, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 152, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 152, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 152, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 152, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 152, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 152, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[3rd Night]
                #endregion[2nd Stay]
                #region[3rd Stay]
                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 154))).ToString("yyyy-MM-dd");
                expectedStay3Night1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 154));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay3Night1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 154, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 154, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 154, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 154, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 154, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 154, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 154, data.PointsRemaining);
                    stay3 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 155))).ToString("yyyy-MM-dd");
                expectedStay3Night2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 155));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay3Night2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 155, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 155, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 155, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 155, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 155, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 155, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 155, data.PointsRemaining);
                    stay3 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #endregion[3rd Stay]
                #endregion[Update Market Sub Segment to ineligible for all 3 stays and verify points]
                #region[UpdateStayStatusAndVerifyPoints]
                Admin.UpdateStayStatusForServiceTestingPhaseTwo(FilePath, worksheetname, 157);
                //To update the point before start verification
                //added in try catch because sometime the job is already running from a request by Schedule
                try { Queries.Start_ETL(); AddDelay(120000); } catch (Exception) { AddDelay(300000); }
                Queries.ExecuteSPsToUpdatePointsAfterStatusChanged();
                #region[1st Stay]
                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 158))).ToString("yyyy-MM-dd");
                expectedStay1Night1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 158));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Night1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 158, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 158, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 158, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 158, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 158, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 158, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 158, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 159))).ToString("yyyy-MM-dd");
                expectedStay1Night2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 159));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Night2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 159, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 159, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 159, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 159, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 159, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 159, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 159, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #endregion[1st Stay]
                
                #region[Day-2]
                #region[2nd Stay]
                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 163))).ToString("yyyy-MM-dd");
                expectedStay2Night1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 163));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Night1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 163, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 163, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 163, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 163, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 163, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 163, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 163, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 164))).ToString("yyyy-MM-dd");
                expectedStay2Night2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 164));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Night2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 164, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 164, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 164, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 164, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 164, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 164, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 164, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #region[3rd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 165))).ToString("yyyy-MM-dd");
                expectedStay2Night3Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 165));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Night3Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 165, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 165, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 165, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 165, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 165, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 165, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 165, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[3rd Night]
                #endregion[2nd Stay]
                #region[3rd Stay]
                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 167))).ToString("yyyy-MM-dd");
                expectedStay3Night1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 167));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay3Night1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 167, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 167, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 167, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 167, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 167, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 167, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 167, data.PointsRemaining);
                    stay3 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 168))).ToString("yyyy-MM-dd");
                expectedStay3Night2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 168));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay3Night2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 168, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 168, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 168, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 168, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 168, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 168, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 168, data.PointsRemaining);
                    stay3 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #endregion[3rd Stay]
                #endregion[Day-2]
                #endregion[UpdateStayStatusAndVerifyPoints]
                #region[UpdateStayStatusAndVerifyPointsForStay3-Day-2]
                Admin.UpdateStayStatusForServiceTestingPhaseTwo(FilePath, worksheetname, 170);
                //To update the point before start verification
                //added in try catch because sometime the job is already running from a request by Schedule
                try { Queries.Start_ETL(); AddDelay(120000); } catch (Exception) { AddDelay(300000); }
                Admin.SimulateDateForSpecificData(FilePath, worksheetname, 170, worksheetname1, 22);
                departureDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 13, 170))).ToString("yyyy-MM-dd");
                Queries.ExecuteSPsToUpdatePointsAfterDateSimulate(departureDate);
                #region[3rd Stay]
                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 171))).ToString("yyyy-MM-dd");
                expectedStay3Night1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 171));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay3Night1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 171, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 171, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 171, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 171, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 171, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 171, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 171, data.PointsRemaining);
                    stay3 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 172))).ToString("yyyy-MM-dd");
                expectedStay3Night2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 172));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay3Night2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 172, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 172, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 172, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 172, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 172, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 172, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 172, data.PointsRemaining);
                    stay3 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #endregion[3rd Stay]
                #endregion[UpdateStayStatusAndVerifyPointsForStay3-Day-2]
                if (!(stay1 && stay2 && stay3))
                    Assert.Fail("Scenario: Market Sub Segment got updated and becomes ineligible - Failed");
            }
        }

        public static void TC_294940()
        {
            if (TestCaseId == Constants.TC_294940)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, stayDate;
                bool rule5 = true, stay1 = true, stay2 = true, stay3 = true, stay4 = true, stay5 = true, stay6 = true;
                int expectedStay1Point, expectedStay2Point, expectedStay3Point, expectedStay4Point, expectedStay5Point, expectedStay6Point; ;

                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Nightly_Points_Rule_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 174);

                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 181))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 181));

                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 181, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 181, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 181, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 181, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 181, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 181, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 181, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 182))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 182));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 182, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 182, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 182, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 182, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 182, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 182, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 182, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #region[3rd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 183))).ToString("yyyy-MM-dd");
                expectedStay3Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 183));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay3Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 183, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 183, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 183, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 183, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 183, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 183, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 183, data.PointsRemaining);
                    stay3 = false;
                }
                #endregion[Rule Verification]
                #endregion[3rd Night]
                #region[4th Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 184))).ToString("yyyy-MM-dd");
                expectedStay4Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 184));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay4Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 184, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 184, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 184, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 184, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 184, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 184, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 184, data.PointsRemaining);
                    stay4 = false;
                }
                #endregion[Rule Verification]
                #endregion[4th Night]
                #region[5th Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 185))).ToString("yyyy-MM-dd");
                expectedStay5Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 185));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay5Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 185, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 185, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 185, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 185, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 185, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 185, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 185, data.PointsRemaining);
                    stay5 = false;
                }
                #endregion[Rule Verification]
                #endregion[5th Night]
                #region[6th Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 186))).ToString("yyyy-MM-dd");
                expectedStay6Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 186));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay6Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 186, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 186, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 186, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 186, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 186, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 186, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 186, data.PointsRemaining);
                    stay6 = false;
                }
                #endregion[Rule Verification]
                #endregion[6th Night]
                #region[UpdateStayStatusAndVerifyPoint]
                Admin.UpdateStayStatusForServiceTestingPhaseTwo(FilePath, worksheetname, 187);
                //To update the point before start verification
                //added in try catch because sometime the job is already running from a request by Schedule
                try { Queries.Start_ETL(); AddDelay(120000); } catch (Exception) { AddDelay(300000); }
                Queries.ExecuteSPsToUpdatePointsAfterStatusChanged();
                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 188))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 188));

                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 188, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 188, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 188, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 188, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 188, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 188, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 188, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 189))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 189));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 189, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 189, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 189, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 189, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 189, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 189, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 189, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #region[3rd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 190))).ToString("yyyy-MM-dd");
                expectedStay3Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 190));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay3Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 190, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 190, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 190, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 190, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 190, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 190, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 190, data.PointsRemaining);
                    stay3 = false;
                }
                #endregion[Rule Verification]
                #endregion[3rd Night]
                #region[4th Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 191))).ToString("yyyy-MM-dd");
                expectedStay4Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 191));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay4Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 191, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 191, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 191, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 191, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 191, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 191, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 191, data.PointsRemaining);
                    stay4 = false;
                }
                #endregion[Rule Verification]
                #endregion[4th Night]
                #region[5th Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 192))).ToString("yyyy-MM-dd");
                expectedStay5Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 192));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay5Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 192, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 192, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 192, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 192, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 192, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 192, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 192, data.PointsRemaining);
                    stay5 = false;
                }
                #endregion[Rule Verification]
                #endregion[5th Night]
                #region[6th Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 193))).ToString("yyyy-MM-dd");
                expectedStay6Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 193));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay6Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 193, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 193, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 193, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 193, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 193, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 193, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 193, data.PointsRemaining);
                    stay6 = false;
                }
                #endregion[Rule Verification]
                #endregion[6th Night]
                #endregion[UpdateStayStatusAndVerifyPoint]
                 if (!(stay1 && stay2 && stay3 && stay4 && stay5 && stay6))
                    Assert.Fail("Scenario: Validate Points when one or more rates in AccountTransactionRates are null [Departure date as Today in Checked in status]Scenarion - Failed");            }
        }

        public static void TC_294941()
        {
            if (TestCaseId == Constants.TC_294941)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, stayDate;
                bool rule5 = true, stay1 = true, stay2 = true, stay1_1 = true, stay2_1 = true;
                int  expectedStay1Point, expectedStay2Point;

                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Nightly_Points_Rule_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 195);

                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 195))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 195));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 195, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 195, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 195, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]
                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 195, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 195, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 195, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 195, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 196))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 196));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 196, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 196, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 196, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 196, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 196, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 196, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 196, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #region[Another 1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 198))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 198));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 198, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 198, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 198, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]
                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 198, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 198, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 198, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 198, data.PointsRemaining);
                    stay1_1 = false;
                }
                #endregion[Rule Verification]
                #endregion[Another 1st Night]
                #region[Another 2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 199))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 199));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 199, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 199, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 199, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 199, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 199, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 199, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 199, data.PointsRemaining);
                    stay2_1 = false;
                }
                #endregion[Rule Verification]
                #endregion[Another 2nd Night]
                if (!(stay1 && stay2 && stay1_1 && stay2_1))
                    Assert.Fail("Scenario: Checked In Stay with duplicate Reservation# - Failed");

            }
        }

        public static void TC_294942()
        {
            if (TestCaseId == Constants.TC_294942)
            {
                Users data = new Users();
                string FilePath, worksheetname, email, stayDate;
                bool rule5 = true, stay1 = true, stay2 = true, stay1_1 = true, stay2_1 = true; ;
                int expectedStay1Point, expectedStay2Point;

                //Retrive Data from excel File
                FilePath = ProjectPath + @"\TestData\Points_Earning_Rule_Service_TestData" + ProjectName + ".xlsx";
                worksheetname = "Nightly_Points_Rule_Scenario";
                TestData.ExcelData.ExcelDataReader tt = new TestData.ExcelData.ExcelDataReader(FilePath);
                email = tt.GetCellData(worksheetname, 3, 201);

                #region[1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 201))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 201));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 201, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 201, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 201, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 201, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 201, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 201, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 201, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[1st Night]
                #region[2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 202))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 202));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 202, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 202, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 202, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 202, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 202, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 202, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 202, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                #region[Another 1st Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 204))).ToString("yyyy-MM-dd");
                expectedStay1Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 204));
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay1Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 204, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 204, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 204, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 204, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 204, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 204, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 204, data.PointsRemaining);
                    stay1 = false;
                }
                #endregion[Rule Verification]
                #endregion[Another 1st Night]
                #region[Another 2nd Night]
                stayDate = Admin.FromExcelSerialDate(Convert.ToInt32(tt.GetCellData(worksheetname, 5, 205))).ToString("yyyy-MM-dd");
                expectedStay2Point = Convert.ToInt32(tt.GetCellData(worksheetname, 23, 205));
                rule5 = true;
                #region[Point Earning Rule 5]
                Queries.GetRuleByName(data, "P_Rule_5");
                Queries.VerifyStayTransactionPerNight(data, email, stayDate, data.RuleId);
                if (Convert.ToInt32(data.PointsRemaining) == expectedStay2Point)
                {
                    tt.SetCellData(worksheetname, "Rule_5", 205, data.PointsRemaining);
                    Logger.WriteInfoMessage("Points are earned by Rule 5 = Point Test Rule 5");
                }
                else
                {
                    if (data.PointsRemaining == null)
                        tt.SetCellData(worksheetname, "Rule_5", 205, "0");
                    else
                    {
                        tt.SetCellData(worksheetname, "Rule_5", 205, data.PointsRemaining);
                    }
                    rule5 = false;
                }
                #endregion[Point Earning Rule 5]

                #region[Rule Verification]
                if (rule5)
                {
                    Logger.WriteInfoMessage("Points are assinged by Rule 5");
                    tt.SetCellData(worksheetname, "Result", 205, "Pass");
                    tt.SetCellData(worksheetname, "Actual_Points", 205, data.PointsRemaining);
                }
                else
                {
                    tt.SetCellData(worksheetname, "Result", 205, "Fail");
                    tt.SetCellData(worksheetname, "Actual_Points", 205, data.PointsRemaining);
                    stay2 = false;
                }
                #endregion[Rule Verification]
                #endregion[2nd Night]
                if (!(stay1 && stay2 && stay1_1 && stay2_1))
                    Assert.Fail("Scenario: Checked Out Stay with duplicate Reservation# - Failed");

            }
        } 
        #endregion[Service Automation Scenario_Validation - part2]

    }

}

