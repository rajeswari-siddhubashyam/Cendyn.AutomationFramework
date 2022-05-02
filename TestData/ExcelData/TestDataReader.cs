using System;
using System.Collections.Generic;
using System.Linq;
using InfoMessageLogger;
using System.Data;
using Common;

namespace TestData.ExcelData
{
    public class TestDataReader 
    {
        public static string Name { get; set; }
        public static string browsertype { get; set; }
        public static Dictionary<string, string> KeyValuePair { get { return TestData_KeyValuePair; } }
        static List<DataCollection> datacol = new List<DataCollection>();
        static Dictionary<string, string> TestData_KeyValuePair = new Dictionary<string, string>();
        //POC excel
        static string defCaseId = "0";
        static string defGroupNo = "1";

        #region POC Excel

        /// <summary>
        /// POC excel
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="sheetName"></param>
        /// <param name="clientName"></param>
        /// <param name="testDataType"></param>
        /// <param name="caseType"></param>
        /// <param name="caseId"></param>
        /// <param name="groupNo"></param>        
        public static void PopulateInCollectionExcel(eProduct product, string clientName, string testDataType, string caseType, string caseId, string groupNo)
        {
            List<DataCollection> testRecords = TestDataHelper.GetTestData(product, clientName, testDataType, caseType, caseId, groupNo);
            foreach (DataCollection item in testRecords)
            {
                datacol.Add(item);
                if (!TestData_KeyValuePair.ContainsKey(item.CaseId + '_' + item.ColName))
                    TestData_KeyValuePair.Add(item.CaseId + '_' + item.ColName, item.ColValue);
            }
        }

        #endregion POC Excel
        /// <summary>
        /// Method to Close Excel sheet.
        /// </summary>
        public static void closeExcel()
        {
            datacol.Clear();
        }

        /// <summary>
        /// To check weather data is present
        /// </summary>
        public static bool openExcel()
        {
            if (datacol.Count == 0)
            {
                return true;
            }
            else
                return false;

        }

        /// <summary>
        /// Read testing data from Excel sheet 
        /// </summary>
        public static string ReadData(int rowNumber, String columnName)
        {
            try
            {
                String data = (datacol.Where(x => x.ColName == columnName && x.RowNumber == rowNumber).Select(y => y.ColValue)).FirstOrDefault();
                return (data != null) ? data.ToString() : "";
            }
            catch (Exception ex)
            {
                Logger.WriteInfoMessage("Row data not found!!" + ex);
                return null;
            }
        }

        public static void ProjectDetails(eProduct product, string projectName, Enum clientName, Enum testDataType, Enum caseType)
        {

            PopulateInCollectionExcel(product, CommonMethod.GetEnumDescription(clientName), CommonMethod.GetEnumDescription(testDataType), CommonMethod.GetEnumDescription(caseType), defCaseId, defGroupNo);

            browsertype = (datacol.Where(x => x.ColName == Constants.Browser && (x.ProjectName == "ALL" || x.ProjectName == projectName)).Select(y => y.ColValue)).FirstOrDefault();

        }

      
        public static void GetProjectDetails(eProduct product, Enum clientName, Enum caseType)
        {
             
            PopulateInCollectionExcel(product, CommonMethod.GetEnumDescription(clientName), CommonMethod.GetEnumDescription(Enums.TestDataType.FrontEnd), CommonMethod.GetEnumDescription(caseType), defCaseId, defGroupNo);
            PopulateInCollectionExcel(product, CommonMethod.GetEnumDescription(clientName), CommonMethod.GetEnumDescription(Enums.TestDataType.Admin), CommonMethod.GetEnumDescription(caseType), defCaseId, defGroupNo);
            PopulateInCollectionExcel(product, CommonMethod.GetEnumDescription(clientName), CommonMethod.GetEnumDescription(Enums.TestDataType.Kiosk), CommonMethod.GetEnumDescription(caseType), defCaseId, defGroupNo);

            TestData.ProjectDetails.CommonFrontendURL = (datacol.Where(x => x.ProjectName == CommonMethod.GetEnumDescription(clientName) && x.ColName == Constants.Url && x.TestDataType == CommonMethod.GetEnumDescription(Enums.TestDataType.FrontEnd)).Select(y => y.ColValue)).FirstOrDefault();
            if (string.IsNullOrEmpty(TestData.ProjectDetails.CommonFrontendURL))
                TestData.ProjectDetails.CommonFrontendURL = (datacol.Where(x => x.ProjectName == CommonMethod.GetEnumDescription(Enums.ClientName.All) && x.ColName == Constants.Url && x.TestDataType == CommonMethod.GetEnumDescription(Enums.TestDataType.FrontEnd)).Select(y => y.ColValue)).FirstOrDefault();

            TestData.ProjectDetails.CommonFrontendEmail = (datacol.Where(x => x.ProjectName == CommonMethod.GetEnumDescription(clientName) && x.ColName == Constants.Username && x.TestDataType == CommonMethod.GetEnumDescription(Enums.TestDataType.FrontEnd)).Select(y => y.ColValue)).FirstOrDefault();
            if (string.IsNullOrEmpty(TestData.ProjectDetails.CommonFrontendEmail))
                TestData.ProjectDetails.CommonFrontendEmail = (datacol.Where(x => x.ProjectName == CommonMethod.GetEnumDescription(Enums.ClientName.All) && x.ColName == Constants.Username && x.TestDataType == CommonMethod.GetEnumDescription(Enums.TestDataType.FrontEnd)).Select(y => y.ColValue)).FirstOrDefault();

            TestData.ProjectDetails.CommonFrontendPassword = (datacol.Where(x => x.ProjectName == CommonMethod.GetEnumDescription(clientName) && x.ColName == Constants.Password && x.TestDataType == CommonMethod.GetEnumDescription(Enums.TestDataType.FrontEnd)).Select(y => y.ColValue)).FirstOrDefault();
            if (string.IsNullOrEmpty(TestData.ProjectDetails.CommonFrontendPassword))
                TestData.ProjectDetails.CommonFrontendPassword = (datacol.Where(x => x.ProjectName == CommonMethod.GetEnumDescription(Enums.ClientName.All) && x.ColName == Constants.Password && x.TestDataType == CommonMethod.GetEnumDescription(Enums.TestDataType.All)).Select(y => y.ColValue)).FirstOrDefault();

            TestData.ProjectDetails.CommonAdminURL = (datacol.Where(x => x.ProjectName == CommonMethod.GetEnumDescription(clientName) && x.ColName == Constants.Url && x.TestDataType == CommonMethod.GetEnumDescription(Enums.TestDataType.Admin)).Select(y => y.ColValue)).FirstOrDefault();
            if (string.IsNullOrEmpty(TestData.ProjectDetails.CommonAdminURL))
                TestData.ProjectDetails.CommonAdminURL = (datacol.Where(x => x.ProjectName == CommonMethod.GetEnumDescription(Enums.ClientName.All) && x.ColName == Constants.Url && x.TestDataType == CommonMethod.GetEnumDescription(Enums.TestDataType.Admin)).Select(y => y.ColValue)).FirstOrDefault();

            TestData.ProjectDetails.CommonAdminEmail = (datacol.Where(x => x.ProjectName == CommonMethod.GetEnumDescription(clientName) && x.ColName == Constants.Username && x.TestDataType == CommonMethod.GetEnumDescription(Enums.TestDataType.Admin)).Select(y => y.ColValue)).FirstOrDefault();
            if (string.IsNullOrEmpty(TestData.ProjectDetails.CommonAdminEmail))
                TestData.ProjectDetails.CommonAdminEmail = (datacol.Where(x => x.ProjectName == CommonMethod.GetEnumDescription(Enums.ClientName.All) && x.ColName == Constants.Username && x.TestDataType == CommonMethod.GetEnumDescription(Enums.TestDataType.Admin)).Select(y => y.ColValue)).FirstOrDefault();

            TestData.ProjectDetails.CommonAdminPassword = (datacol.Where(x => x.ProjectName == CommonMethod.GetEnumDescription(clientName) && x.ColName == Constants.Password && x.TestDataType == CommonMethod.GetEnumDescription(Enums.TestDataType.Admin)).Select(y => y.ColValue)).FirstOrDefault();
            if (string.IsNullOrEmpty(TestData.ProjectDetails.CommonAdminPassword))
                TestData.ProjectDetails.CommonAdminPassword = (datacol.Where(x => x.ProjectName == CommonMethod.GetEnumDescription(Enums.ClientName.All) && x.ColName == Constants.Password && x.TestDataType == CommonMethod.GetEnumDescription(Enums.TestDataType.All)).Select(y => y.ColValue)).FirstOrDefault();

            TestData.ProjectDetails.CommonKioskSignUpURL = (datacol.Where(x => x.ProjectName == CommonMethod.GetEnumDescription(clientName) && x.ColName == Constants.Url && x.TestDataType == CommonMethod.GetEnumDescription(Enums.TestDataType.Kiosk)).Select(y => y.ColValue)).FirstOrDefault();
            if (string.IsNullOrEmpty(TestData.ProjectDetails.CommonKioskSignUpURL))
                TestData.ProjectDetails.CommonKioskSignUpURL = (datacol.Where(x => x.ProjectName == CommonMethod.GetEnumDescription(Enums.ClientName.All) && x.ColName == Constants.Url && x.TestDataType == CommonMethod.GetEnumDescription(Enums.TestDataType.All)).Select(y => y.ColValue)).FirstOrDefault();
            

        }
    }
}
