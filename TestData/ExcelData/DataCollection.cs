namespace TestData.ExcelData
{
    /// <summary>
    /// Custom Class for defining Excel sheet data
    /// </summary>
    public class DataCollection
    {
        public int RowNumber { get; set; }
        public string ColName { get; set; }
        public string ColValue { get; set; }

        //Excel
        public string TestDataType { get; set; }
        public string CaseType { get; set; }
        public string ProjectName { get; set; }
        public string PlanId { get; set; }
        public string CaseId { get; set; }
        public bool IsEnable { get; set; }

    }
}
