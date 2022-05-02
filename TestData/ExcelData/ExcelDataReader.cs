//using AutoItX3Lib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using InfoMessageLogger;
using System.Data;
using ExcelDataReader;
using Common;
using AutoItX3Lib;
using TestData;

namespace TestData.ExcelData
{

    public class ExcelDataReader
    {
        Excel.Application xlApp = null;
        Excel.Workbooks workbooks = null;
        Excel.Workbook workbook = null;
        Hashtable sheets;
        public string xlFilePath;

        public ExcelDataReader(string xlFilePath)
        {
            this.xlFilePath = xlFilePath;
        }

        public void OpenExcel()
        {
            xlApp = new Excel.Application();
            workbooks = xlApp.Workbooks;
            workbook = workbooks.Open(xlFilePath);
            sheets = new Hashtable();
            int count = 1;
            // Storing worksheet names in Hashtable.
            foreach (Excel.Worksheet sheet in workbook.Sheets)
            {
                sheets[count] = sheet.Name;
                count++;
            }

        }
        public void CloseExcel()
        {
            workbook.Close(false, xlFilePath, null); // Close the connection to workbook
            Marshal.FinalReleaseComObject(workbook); // Release unmanaged object references.
            workbook = null;

            workbooks.Close();
            Marshal.FinalReleaseComObject(workbooks);
            workbooks = null;

            xlApp.Quit();
            Marshal.FinalReleaseComObject(xlApp);
            xlApp = null;
        }

        public static string GetNewestFile(string directory)
        {
            string pattern = "*.xlsx";

            var dirInfo = new DirectoryInfo(directory);

            var file = (from f in dirInfo.GetFiles(pattern)
                        orderby f.LastWriteTime descending
                        select f).First();
            string fullath = directory + "\\" + file;
            return fullath;
        }

        public static string Dashboard_GetNewestFile(string directory)
        {
            string pattern = "*.xls";

            var dirInfo = new DirectoryInfo(directory);

            var file = (from f in dirInfo.GetFiles(pattern)
                        orderby f.LastWriteTime descending
                        select f).First();
            string fullath = directory + "\\" + file;
            return fullath;
        }

        public static void uploadfile(string FilePath)
        {
            AutoItX3 AutoIt = new AutoItX3();
            AutoIt.WinActivate("Open");
            CommonMethod.AddDelay(2000);
            AutoIt.Send(FilePath);
            CommonMethod.AddDelay(3000);
            AutoIt.Send("{ENTER}");
            CommonMethod.AddDelay(5000);
            // AutoIt.WinActivate("Open");
        }

        public static void deleteFile(string path)
        {
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                File.Delete(file);
                Console.WriteLine($"{file} is deleted.");
            }
        }

        public bool SetCellData(string sheetName, string colName, int rowNumber, string value)
        {
            OpenExcel();

            int sheetValue = 0;
            int colNumber = 0;

            try
            {
                if (sheets.ContainsValue(sheetName))
                {
                    foreach (DictionaryEntry sheet in sheets)
                    {
                        if (sheet.Value.Equals(sheetName))
                        {
                            sheetValue = (int)sheet.Key;
                        }
                    }

                    Excel.Worksheet worksheet = null;
                    worksheet = workbook.Worksheets[sheetValue] as Excel.Worksheet;
                    Excel.Range range = worksheet.UsedRange;

                    for (int i = 1; i <= range.Columns.Count; i++)
                    {
                        string colNameValue = Convert.ToString((range.Cells[1, i] as Excel.Range).Value2);
                        if (colNameValue.ToLower() == colName.ToLower())
                        {
                            colNumber = i;
                            break;
                        }
                    }

                    range.Cells[rowNumber, colNumber] = value;

                    workbook.Save();
                    Marshal.FinalReleaseComObject(worksheet);
                    worksheet = null;

                    CloseExcel();
                }
            }
            catch (Exception ex)
            {
                Logger.WriteFatalMessage(ex);
                return false;
            }
            return true;
        }
        public string GetCellData(string sheetName, int colNumber, int rowNumber)
        {
            OpenExcel();



            string value = string.Empty;
            int sheetValue = 0;



            if (sheets.ContainsValue(sheetName))
            {
                foreach (DictionaryEntry sheet in sheets)
                {
                    if (sheet.Value.Equals(sheetName))
                    {
                        sheetValue = (int)sheet.Key;
                    }
                }
                Excel.Worksheet worksheet = null;
                worksheet = workbook.Worksheets[sheetValue] as Excel.Worksheet;
                Excel.Range range = worksheet.UsedRange;



                value = Convert.ToString((range.Cells[rowNumber, colNumber] as Excel.Range).Value2);
                Marshal.FinalReleaseComObject(worksheet);
                worksheet = null;
            }
            CloseExcel();
            return value;
        }
        public static string Name { get; set; }
        public static string browsertype { get; set; }

        public static Dictionary<string, string> KeyValuePair { get { return TestData_KeyValuePair; } }
        static List<DataCollection> datacol = new List<DataCollection>();
        static Dictionary<string, string> TestData_KeyValuePair = new Dictionary<string, string>();

        //POC excel
        static string defCaseId = "0";
        static string defGroupNo = "1";


        /// <summary>
        /// Read and parse data from Excel
        /// </summary>
        /// <param name="filepath">Path where the SpreadSheet is placed.</param>
        /// <param name="sheetName">Sheet name from which the test data need to be parsed</param>
        /// <returns></returns>
        public static DataTable ExcelToDataTable(string filePath, string sheetName)
        {
            FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            System.Data.DataSet result = excelReader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });
            DataTableCollection table = result.Tables;
            DataTable resultTable = table[sheetName];
            return resultTable;
        }

        #region POC Excel
        /// <summary>
        /// POC Excel
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="sheetName"></param>
        /// <returns></returns>
        public static DataTable ExcelToDataTable(string filePath, string sheetName, string clientName, string testDataType, string caseType, string caseID, string groupNo)
        {
            string filter = string.Empty;
#pragma warning disable SG0018 // Path traversal
            FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
#pragma warning restore SG0018 // Path traversal
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            System.Data.DataSet result = excelReader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });
            filter = "IsEnable = True and (ProjectName = 'ALL' OR ProjectName = '" + clientName + "') and (TestDataType = 'ALL' OR TestDataType = '" + testDataType + "') and CaseType = '" + caseType + "' and CaseID = '" + caseID + "'";
            if (!caseID.StartsWith("TC_"))
                filter += " and GroupNo ='" + groupNo + "'";

            DataTableCollection table = result.Tables;
            DataTable resultTable = table[sheetName];
            DataView dv = new DataView(resultTable);
            dv.RowFilter = filter;
            if (dv != null && dv.Table.Rows.Count > 0)
                resultTable = dv.ToTable();
            return resultTable;
        }

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
        /// To check wether data is present
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
        /// Storing data in C# collection
        /// </summary>
        /// <param name="sheetName">Sheet name from which the test data need to be parsed.</param>
        public static void PopulateInCollection(string filePath, string sheetName)
        {

            string localPath = new Uri(filePath).LocalPath;

            DataTable table = ExcelToDataTable(localPath, sheetName);
            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    DataCollection dttable = new DataCollection()
                    {
                        RowNumber = row,
                        ColName = table.Columns[col].ColumnName,
                        ColValue = table.Rows[row - 1][col].ToString()
                    };
                    datacol.Add(dttable);
                }
            }
        }

        public static bool VerifySheet(string filePath, string sheetName)
        {
            List<string> sheets = GetSheetNames(filePath);
            foreach (string sheet in sheets)
            {
                if (sheets.Contains(sheetName))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
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
                Logger.WriteInfoMessage("Row data not found!!" +ex);
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

        public static List<string> GetSheetNames(string FileName)
        {
            List<string> SheetNames = new List<string>();

            Excel.Application xlApp = null;
            Excel.Workbooks xlWorkBooks = null;
            Excel.Workbook xlWorkBook = null;
            Excel.Worksheet xlWorkSheet = null;
            Excel.Sheets xlWorkSheets = null;

            xlApp = new Excel.Application();
            xlApp.DisplayAlerts = false;
            xlWorkBooks = xlApp.Workbooks;
            xlWorkBook = xlWorkBooks.Open(FileName);

            xlApp.Visible = false;
            xlWorkSheets = xlWorkBook.Sheets;

            for (int x = 1; x <= xlWorkSheets.Count; x++)
            {
                xlWorkSheet = (Excel.Worksheet)xlWorkSheets[x];
                SheetNames.Add(xlWorkSheet.Name);
                Marshal.FinalReleaseComObject(xlWorkSheet);
                xlWorkSheet = null;
            }

            xlWorkBook.Close();
            xlApp.Quit();

            return SheetNames;
        }
    }
    
}
