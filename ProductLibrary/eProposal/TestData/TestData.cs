using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace eProposal.Utility
{
    public class LegacyTestData : Setup
    {
        //Assign the XML value to a string

        #region[Common]

        public static string CommonBrowserType { get; set; }
        public static string CommonAdminURL { get; set; }
        public static string CommonFrontendURLQA { get; set; }
        public static string CommonFrontendURL { get; set; }
        public static string CommonEmployeeEmail { get; set; }
        public static string CommonEmployeePassword { get; set; }
        public static string CommonEmail { get; set; }
        public static string CommonPassword { get; set; }
        public static string CommonAdminEmail { get; set; }
        public static string CommonAdminPassword { get; set; }
        public static string CommonDemoURL { get; set; }
        public static string CommonDemoEmail { get; set; }
        public static string CommonDemoPassword { get; set; }
        public static string CommonCatchallURL { get; set; }
        public static string CommonCatchallUserName { get; set; }
        public static string CommonCatchallPassword { get; set; }
        public static string LambdaExecution { get; set; }
        public static string LambdaUserName { get; set; }
        public static string LambdaAccessKey { get; set; }
        public static string LambdaHub { get; set; }
        public static string LambdaBuild { get; set; }
        public static string LambdaTunnel { get; set; }


        #region[Compose]

        public static string Compose_LanguageSelection { get; set; }
        public static string Compose_Name { get; set; }
        public static string Compose_EmployeeName { get; set; }
        public static string Compose_ClientName { get; set; }
        public static string Compose_AddClient_FirstName { get; set; }
        public static string Compose_AddClient_LastName { get; set; }
        public static string Compose_AddClient_Company { get; set; }
        public static string Compose_AddClient_Email { get; set; }
        public static string Compose_AddClient_Phone { get; set; }
        public static string Compose_AddClient_Address { get; set; }
        public static string Compose_AddClient_City { get; set; }
        public static string Compose_AddClient_State { get; set; }
        public static string Compose_AddClient_Zip { get; set; }
        public static string Compose_AddClient_Country { get; set; }
        public static string Compose_CC { get; set; }
        public static string Compose_BCC { get; set; }
        public static string Compose_EventMonth { get; set; }
        public static string Compose_EventDay { get; set; }
        public static string Compose_EventYear { get; set; }
        public static string Compose_ExpirationMonth { get; set; }
        public static string Compose_ExpirationDay { get; set; }
        public static string Compose_ExpirationYear { get; set; }
        public static string Compose_Module { get; set; }
        public static string Compose_WelcomeMessage { get; set; }
        public static string Compose_MessageClosing { get; set; }
        public static string Compose_SeniorStaffMessage { get; set; }
        public static string Compose_ClientLogoLocation { get; set; }

        #endregion[Compose]

        #region[CendynRoomBlock]

        public static string CendynRoomBlock_Intro { get; set; }
        public static string CendynRoomBlock_Category { get; set; }
        public static string CendynRoomBlock_RoomType1_Name { get; set; }
        public static string CendynRoomBlock_RoomType1_Qty { get; set; }
        public static string CendynRoomBlock_RoomType1_Rate { get; set; }
        public static string CendynRoomBlock_RoomType2_Name { get; set; }
        public static string CendynRoomBlock_RoomType2_Qty { get; set; }
        public static string CendynRoomBlock_RoomType2_Rate { get; set; }
        public static string CendynRoomBlock_RoomType3_Name { get; set; }
        public static string CendynRoomBlock_RoomType3_Qty { get; set; }
        public static string CendynRoomBlock_RoomType3_Rate { get; set; }
        public static string CendynRoomBlock_NewCategory_Name { get; set; }
        public static string CendynRoomBlock_NewCategory_Type { get; set; }
        public static string CendynRoomBlock_NewCategory_Qty { get; set; }
        public static string CendynRoomBlock_NewCategory_Rate { get; set; }
        public static string CendynRoomBlock_AdditionalOptions_Name { get; set; }
        public static string CendynRoomBlock_AdditionalOptions_Category { get; set; }
        public static string CendynRoomBlock_AdditionalOptions_Rate1 { get; set; }
        public static string CendynRoomBlock_AdditionalOptions_Comments1 { get; set; }
        public static string CendynRoomBlock_AdditionalOptions_Rate2 { get; set; }
        public static string CendynRoomBlock_AdditionalOptions_Comments2 { get; set; }
        public static string CendynRoomBlock_AdditionalOptions_Rate3 { get; set; }
        public static string CendynRoomBlock_AdditionalOptions_Comments3 { get; set; }
        public static string CendynRoomBlock_RoomBlockComments { get; set; }

        #endregion[CendynRoomBlock]

        #region[CendynEventBlock]

        public static string CendynEventBlock_StartTime { get; set; }
        public static string CendynEventBlock_EndTime { get; set; }
        public static string CendynEventBlock_Name { get; set; }
        public static string CendynEventBlock_Room { get; set; }
        public static string CendynEventBlock_Type { get; set; }
        public static string CendynEventBlock_RentalFee { get; set; }
        public static string CendynEventBlock_Guests { get; set; }
        public static string CendynEventBlock_Setup { get; set; }
        public static string CendynEventBlock_Event1_Comments { get; set; }
        public static string CendynEventBlock_EventBlockComments { get; set; }
        public static string CendynEventBlock_EstimatedCosts { get; set; }
        public static string CendynEventBlock_EstimatedCosts_PricePerItem { get; set; }
        public static string CendynEventBlock_EstimatedCosts_NumberOfItems { get; set; }
        public static string CendynEventBlock_EstimatedCosts_NumberOfDays { get; set; }
        public static string CendynEventBlock_AdditionalCosts_Item { get; set; }
        public static string CendynEventBlock_AdditionalCosts_Amount { get; set; }

        #endregion[CendynEventBlock]

        #region[Select]

        public static string Select_UploadFileLocation_1 { get; set; }
        public static string Select_UploadFileLocation_2 { get; set; }
        public static string Select_UploadFileLocation_3 { get; set; }
        public static string Select_UploadFileLocation_4 { get; set; }
        public static string Select_UploadFileLocation_5 { get; set; }
        public static string Select_UploadFileLocation_6 { get; set; }

        #endregion[Select]

        #endregion[/Common]

        /// <summary>
        /// This method will assign all string values from the test xml file.
        /// </summary>
        /// <param name=testCase>Test Case ID</param>
        public static LegacyTestData ReadData(string testCase)
        {
            LegacyTestData obj = new LegacyTestData();
            XDocument doc = XDocument.Load(TestDataFile);
            var query = doc.Descendants(testCase).Elements()
                .ToDictionary(x => x.Attribute("key").Value,
                    x => x.Value);

            foreach (KeyValuePair<string, string> pair in query)
            {
                #region[Common]

                if (testCase == Constants.ModuleCommon)
                    if (pair.Key == "CommonBrowserType")
                        CommonBrowserType = pair.Value;
                    else if (pair.Key == "CommonAdminURL")
                        CommonAdminURL = pair.Value;
                    else if (pair.Key == "CommonFrontendURL")
                        CommonFrontendURL = pair.Value;
                    else if (pair.Key == "CommonFrontendURLQA")
                        CommonFrontendURLQA = pair.Value;
                    else if (pair.Key == "CommonEmployeeEmail")
                        CommonEmployeeEmail = pair.Value;
                    else if (pair.Key == "CommonEmployeePassword")
                        CommonEmployeePassword = pair.Value;
                    else if (pair.Key == "CommonEmail")
                        CommonEmail = pair.Value;
                    else if (pair.Key == "CommonPassword")
                        CommonPassword = pair.Value;
                    else if (pair.Key == "CommonAdminEmail")
                        CommonAdminEmail = pair.Value;
                    else if (pair.Key == "CommonAdminPassword")
                        CommonAdminPassword = pair.Value;
                    else if (pair.Key == "CommonDemoURL")
                        CommonDemoURL = pair.Value;
                    else if (pair.Key == "CommonDemoEmail")
                        CommonDemoEmail = pair.Value;
                    else if (pair.Key == "CommonDemoPassword")
                        CommonDemoPassword = pair.Value;
                    else if (pair.Key == "CommonCatchallURL")
                        CommonCatchallURL = pair.Value;
                    else if (pair.Key == "CommonCatchallUserName")
                        CommonCatchallUserName = pair.Value;
                    else if (pair.Key == "CommonCatchallPassword")
                        CommonCatchallPassword = pair.Value;
                    else if (pair.Key == "Compose_LanguageSelection")
                        Compose_LanguageSelection = pair.Value;
                    else if (pair.Key == "Compose_Name")
                        Compose_Name = pair.Value;
                    else if (pair.Key == "Compose_EmployeeName")
                        Compose_EmployeeName = pair.Value;
                    else if (pair.Key == "Compose_ClientName")
                        Compose_ClientName = pair.Value;
                    else if (pair.Key == "Compose_AddClient_FirstName")
                        Compose_AddClient_FirstName = pair.Value;
                    else if (pair.Key == "Compose_AddClient_LastName")
                        Compose_AddClient_LastName = pair.Value;
                    else if (pair.Key == "Compose_AddClient_Company")
                        Compose_AddClient_Company = pair.Value;
                    else if (pair.Key == "Compose_AddClient_Email")
                        Compose_AddClient_Email = pair.Value;
                    else if (pair.Key == "Compose_AddClient_Phone")
                        Compose_AddClient_Phone = pair.Value;
                    else if (pair.Key == "Compose_AddClient_Address")
                        Compose_AddClient_Address = pair.Value;
                    else if (pair.Key == "Compose_AddClient_City")
                        Compose_AddClient_City = pair.Value;
                    else if (pair.Key == "Compose_AddClient_State")
                        Compose_AddClient_State = pair.Value;
                    else if (pair.Key == "Compose_AddClient_Zip")
                        Compose_AddClient_Zip = pair.Value;
                    else if (pair.Key == "Compose_AddClient_Country")
                        Compose_AddClient_Country = pair.Value;
                    else if (pair.Key == "Compose_CC")
                        Compose_CC = pair.Value;
                    else if (pair.Key == "Compose_BCC")
                        Compose_BCC = pair.Value;
                    else if (pair.Key == "Compose_EventMonth")
                        Compose_EventMonth = pair.Value;
                    else if (pair.Key == "Compose_EventDay")
                        Compose_EventDay = pair.Value;
                    else if (pair.Key == "Compose_EventYear")
                        Compose_EventYear = pair.Value;
                    else if (pair.Key == "Compose_ExpirationMonth")
                        Compose_ExpirationMonth = pair.Value;
                    else if (pair.Key == "Compose_ExpirationDay")
                        Compose_ExpirationDay = pair.Value;
                    else if (pair.Key == "Compose_ExpirationYear")
                        Compose_ExpirationYear = pair.Value;
                    else if (pair.Key == "Compose_Module")
                        Compose_Module = pair.Value;
                    else if (pair.Key == "Compose_WelcomeMessage")
                        Compose_WelcomeMessage = pair.Value;
                    else if (pair.Key == "Compose_MessageClosing")
                        Compose_MessageClosing = pair.Value;
                    else if (pair.Key == "Compose_SeniorStaffMessage")
                        Compose_SeniorStaffMessage = pair.Value;
                    else if (pair.Key == "Compose_ClientLogoLocation")
                        Compose_ClientLogoLocation = pair.Value;
                    else if (pair.Key == "CendynRoomBlock_Intro")
                        CendynRoomBlock_Intro = pair.Value;
                    else if (pair.Key == "CendynRoomBlock_Category")
                        CendynRoomBlock_Category = pair.Value;
                    else if (pair.Key == "CendynRoomBlock_RoomType1_Name")
                        CendynRoomBlock_RoomType1_Name = pair.Value;
                    else if (pair.Key == "CendynRoomBlock_RoomType1_Qty")
                        CendynRoomBlock_RoomType1_Qty = pair.Value;
                    else if (pair.Key == "CendynRoomBlock_RoomType1_Rate")
                        CendynRoomBlock_RoomType1_Rate = pair.Value;
                    else if (pair.Key == "CendynRoomBlock_RoomType2_Name")
                        CendynRoomBlock_RoomType2_Name = pair.Value;
                    else if (pair.Key == "CendynRoomBlock_RoomType2_Qty")
                        CendynRoomBlock_RoomType2_Qty = pair.Value;
                    else if (pair.Key == "CendynRoomBlock_RoomType2_Rate")
                        CendynRoomBlock_RoomType2_Rate = pair.Value;
                    else if (pair.Key == "CendynRoomBlock_RoomType3_Name")
                        CendynRoomBlock_RoomType3_Name = pair.Value;
                    else if (pair.Key == "CendynRoomBlock_RoomType3_Qty")
                        CendynRoomBlock_RoomType3_Qty = pair.Value;
                    else if (pair.Key == "CendynRoomBlock_RoomType3_Rate")
                        CendynRoomBlock_RoomType3_Rate = pair.Value;
                    else if (pair.Key == "CendynRoomBlock_NewCategory_Name")
                        CendynRoomBlock_NewCategory_Name = pair.Value;
                    else if (pair.Key == "CendynRoomBlock_NewCategory_Type")
                        CendynRoomBlock_NewCategory_Type = pair.Value;
                    else if (pair.Key == "CendynRoomBlock_NewCategory_Qty")
                        CendynRoomBlock_NewCategory_Qty = pair.Value;
                    else if (pair.Key == "CendynRoomBlock_NewCategory_Rate")
                        CendynRoomBlock_NewCategory_Rate = pair.Value;
                    else if (pair.Key == "CendynRoomBlock_AdditionalOptions_Name")
                        CendynRoomBlock_AdditionalOptions_Name = pair.Value;
                    else if (pair.Key == "CendynRoomBlock_AdditionalOptions_Category")
                        CendynRoomBlock_AdditionalOptions_Category = pair.Value;
                    else if (pair.Key == "CendynRoomBlock_AdditionalOptions_Rate1")
                        CendynRoomBlock_AdditionalOptions_Rate1 = pair.Value;
                    else if (pair.Key == "CendynRoomBlock_AdditionalOptions_Comments1")
                        CendynRoomBlock_AdditionalOptions_Comments1 = pair.Value;
                    else if (pair.Key == "CendynRoomBlock_AdditionalOptions_Rate2")
                        CendynRoomBlock_AdditionalOptions_Rate2 = pair.Value;
                    else if (pair.Key == "CendynRoomBlock_AdditionalOptions_Comments2")
                        CendynRoomBlock_AdditionalOptions_Comments2 = pair.Value;
                    else if (pair.Key == "CendynRoomBlock_AdditionalOptions_Rate3")
                        CendynRoomBlock_AdditionalOptions_Rate3 = pair.Value;
                    else if (pair.Key == "CendynRoomBlock_AdditionalOptions_Comments3")
                        CendynRoomBlock_AdditionalOptions_Comments3 = pair.Value;
                    else if (pair.Key == "CendynRoomBlock_RoomBlockComments")
                        CendynRoomBlock_RoomBlockComments = pair.Value;
                    else if (pair.Key == "CendynEventBlock_StartTime")
                        CendynEventBlock_StartTime = pair.Value;
                    else if (pair.Key == "CendynEventBlock_EndTime")
                        CendynEventBlock_EndTime = pair.Value;
                    else if (pair.Key == "CendynEventBlock_Name")
                        CendynEventBlock_Name = pair.Value;
                    else if (pair.Key == "CendynEventBlock_Room")
                        CendynEventBlock_Room = pair.Value;
                    else if (pair.Key == "CendynEventBlock_Type")
                        CendynEventBlock_Type = pair.Value;
                    else if (pair.Key == "CendynEventBlock_RentalFee")
                        CendynEventBlock_RentalFee = pair.Value;
                    else if (pair.Key == "CendynEventBlock_Guests")
                        CendynEventBlock_Guests = pair.Value;
                    else if (pair.Key == "CendynEventBlock_Setup")
                        CendynEventBlock_Setup = pair.Value;
                    else if (pair.Key == "CendynEventBlock_Event1_Comments")
                        CendynEventBlock_Event1_Comments = pair.Value;
                    else if (pair.Key == "CendynEventBlock_EventBlockComments")
                        CendynEventBlock_EventBlockComments = pair.Value;
                    else if (pair.Key == "CendynEventBlock_EstimatedCosts")
                        CendynEventBlock_EstimatedCosts = pair.Value;
                    else if (pair.Key == "CendynEventBlock_EstimatedCosts_PricePerItem")
                        CendynEventBlock_EstimatedCosts_PricePerItem = pair.Value;
                    else if (pair.Key == "CendynEventBlock_EstimatedCosts_NumberOfItems")
                        CendynEventBlock_EstimatedCosts_NumberOfItems = pair.Value;
                    else if (pair.Key == "CendynEventBlock_EstimatedCosts_NumberOfDays")
                        CendynEventBlock_EstimatedCosts_NumberOfDays = pair.Value;
                    else if (pair.Key == "CendynEventBlock_AdditionalCosts_Item")
                        CendynEventBlock_AdditionalCosts_Item = pair.Value;
                    else if (pair.Key == "CendynEventBlock_AdditionalCosts_Amount")
                        CendynEventBlock_AdditionalCosts_Amount = pair.Value;
                    else if (pair.Key == "Select_UploadFileLocation_1")
                        Select_UploadFileLocation_1 = pair.Value;
                    else if (pair.Key == "Select_UploadFileLocation_2")
                        Select_UploadFileLocation_2 = pair.Value;
                    else if (pair.Key == "Select_UploadFileLocation_3")
                        Select_UploadFileLocation_3 = pair.Value;
                    else if (pair.Key == "Select_UploadFileLocation_4")
                        Select_UploadFileLocation_4 = pair.Value;
                    else if (pair.Key == "Select_UploadFileLocation_5")
                        Select_UploadFileLocation_5 = pair.Value;
                    else if (pair.Key == "Select_UploadFileLocation_6")
                        Select_UploadFileLocation_6 = pair.Value;
                    else if (pair.Key == "LambdaUserName")
                    {
                        LambdaUserName = pair.Value;
                    }
                    else if (pair.Key == "LambdaAccessKey")
                    {
                        LambdaAccessKey = pair.Value;
                    }
                    else if (pair.Key == "LambdaHub")
                    {
                        LambdaHub = pair.Value;
                    }
                    else if (pair.Key == "LambdaBuild")
                    {
                        LambdaBuild = pair.Value;
                    }
                    else if (pair.Key == "LambdaTunnel")
                    {
                        LambdaTunnel = pair.Value;
                    }
                    else if (pair.Key == "LambdaExecution")
                    {
                        LambdaExecution = pair.Value;
                    }

                #endregion[Common]
            }
            return obj;
        }


    }
}