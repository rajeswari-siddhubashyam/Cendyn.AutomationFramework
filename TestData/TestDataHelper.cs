using TestData.ExcelData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestData
{
    public class TestDataHelper
    {
        //ProjectName	TestDataType	CaseType	PlanID	CaseID	GroupNo	IsEnable	KeyName	KeyValue
        #region Instance Variable
        private static List<DataCollection> _dataCollections;
        #endregion

        #region Properties
        //public static List<DataCollection> TestDaata { get { return PopulateTestData(); } }
        #endregion

        #region Common Test Data
        private static void InitilizeCollection()
        {
            _dataCollections = new List<DataCollection>();
        }

        public static void AddRecord(string projectName, string testDataType, string caseType, string planID, string caseID, string groupNo, string isEnable, string keyName, string keyValue)
        {
            var v_TestDataType = testDataType;
            var v_CaseType = caseType;
            var v_PlanId = planID;
            var v_CaseId = caseID;
            var v_RowNumber = Convert.ToInt32(groupNo);
            var v_IsEnable = (isEnable == "TRUE") ? true : false;
            var v_ColName = keyName;

            if (projectName != "ALL")
            {
                DataCollection previous_Record = _dataCollections.Where(r => r.ProjectName == "ALL"
                                           && r.TestDataType == v_TestDataType
                                           && r.CaseType == v_CaseType
                                           && r.PlanId == v_PlanId
                                           && r.CaseId == v_CaseId
                                           && r.RowNumber == v_RowNumber
                                           && r.IsEnable == v_IsEnable
                                           && r.ColName == v_ColName).FirstOrDefault();
                _dataCollections.Remove(previous_Record);
            }

            DataCollection record = new DataCollection
            {
                ProjectName = projectName,
                TestDataType = v_TestDataType,
                CaseType = v_CaseType,
                PlanId = v_PlanId,
                CaseId = v_CaseId,
                RowNumber = v_RowNumber,
                IsEnable = v_IsEnable,
                ColName = v_ColName,
                ColValue = keyValue
            };
            _dataCollections.Add(record);
        }

        public static void AddTestData_ClientConfig(string clientName, string adminUrl, string adminUserName, string frontEndUrl, string kioskUrl = "", string masterPropertyCode = "", string mySettingsFrontendEmail = "")
        {
            //AddRecord("ALL", "ALL", "NA", "0", "0", "1", "TRUE", "Password", "Cendyn123$");

            if (!string.IsNullOrEmpty(adminUrl))
                AddRecord(clientName, "Admin", "NA", "0", "0", "1", "TRUE", "Url", adminUrl);

            if (!string.IsNullOrEmpty(adminUserName))
                AddRecord(clientName, "Admin", "NA", "0", "0", "1", "TRUE", "Username", adminUserName);

            if (!string.IsNullOrEmpty(masterPropertyCode))
                AddRecord(clientName, "CRMAPI", "NA", "0", "0", "1", "TRUE", "MasterPropertyCode", masterPropertyCode);

            if (!string.IsNullOrEmpty(mySettingsFrontendEmail))
                AddRecord(clientName, "FrontEnd", "NA", "0", "0", "1", "TRUE", "MySettingsFrontendEmail", mySettingsFrontendEmail);

            if (!string.IsNullOrEmpty(frontEndUrl))
                AddRecord(clientName, "FrontEnd", "NA", "0", "0", "1", "TRUE", "Url", frontEndUrl);

            if (!string.IsNullOrEmpty(kioskUrl))
                AddRecord(clientName, "Kiosk", "NA", "0", "0", "1", "TRUE", "Url", kioskUrl);
        }

        public static void AddTestData_ClientUP(string clientName, string adminUrl, string adminUserName, string frontEndUrl, string kioskUrl = "", string masterPropertyCode = "", string mySettingsFrontendEmail = "")
        {
            //AddRecord("ALL", "ALL", "NA", "0", "0", "1", "TRUE", "Password", "Cendyn123$");

            if (!string.IsNullOrEmpty(adminUrl))
                AddRecord(clientName, "Admin", "NA", "0", "0", "1", "TRUE", "Url", adminUrl);

            if (!string.IsNullOrEmpty(adminUserName))
                AddRecord(clientName, "Admin", "NA", "0", "0", "1", "TRUE", "Username", adminUserName);

            if (!string.IsNullOrEmpty(masterPropertyCode))
                AddRecord(clientName, "CRMAPI", "NA", "0", "0", "1", "TRUE", "MasterPropertyCode", masterPropertyCode);

            if (!string.IsNullOrEmpty(mySettingsFrontendEmail))
                AddRecord(clientName, "FrontEnd", "NA", "0", "0", "1", "TRUE", "MySettingsFrontendEmail", mySettingsFrontendEmail);

            if (!string.IsNullOrEmpty(frontEndUrl))
                AddRecord(clientName, "FrontEnd", "NA", "0", "0", "1", "TRUE", "Url", frontEndUrl);

            if (!string.IsNullOrEmpty(kioskUrl))
                AddRecord(clientName, "Kiosk", "NA", "0", "0", "1", "TRUE", "Url", kioskUrl);
        }

        #endregion

        #region Public Methods
        public static void PopulateTestData(eProduct product, string clientName)
        {
            InitilizeCollection();
            CommonTestData.AddCommonTestData();
            if (eProduct.eLoyalty == product)
                eLoyaltyV3.AddELoyaltyData(clientName);
            if (eProduct.eMenus == product)
                eMenus.AddeMenusData(clientName);
            if (eProduct.RevIntel == product)
                RevIntel.AddeMenusData(clientName);
            if (eProduct.ePlanner == product)
                ePlanner.AddeMenusData(clientName);
            if (eProduct.eMenusLite == product)
                eMenusLite.AddeMenusData(clientName);
            if (eProduct.AMR_Agent == product)
                AMR_Agent.AddAMRAgentData(clientName);
            if (eProduct.MarketingAuto == product)
                MarketingAuto.AddMAData(clientName);
            if (eProduct.CHCAuto == product)
                CHCAuto.AddCHCData(clientName);
            if (eProduct.CHC_Config == product)
                CHC_Config.AddCHC_ConfigData(clientName);
            if (eProduct.CMS == product)
                CMS.AddMAData(clientName);
            if (eProduct.CHC_UP == product)
                CHC_Unified_Profile.AddUPData(clientName);
        }

        public static List<DataCollection> GetTestData(eProduct product, string clientName, string testDataType, string caseType, string caseID, string groupNo)
        {
            PopulateTestData(product, clientName);
            int rowNum = Convert.ToInt32(groupNo);

            List<DataCollection> filteredData = new List<DataCollection>();
            if (!caseID.StartsWith("TC_"))
            {
                filteredData = _dataCollections.Where(td => td.IsEnable = true
                                           && (td.ProjectName == "ALL" || td.ProjectName == clientName)
                                           && (td.TestDataType == "ALL" || td.TestDataType == testDataType)
                                           && td.CaseType == caseType && td.CaseId == caseID && td.RowNumber == rowNum).ToList();
            }
            else
            {
                filteredData = _dataCollections.Where(td => td.IsEnable = true
                                           && (td.ProjectName == "ALL" || td.ProjectName == clientName)
                                           && (td.TestDataType == "ALL" || td.TestDataType == testDataType)
                                           && td.CaseType == caseType && td.CaseId == caseID).ToList();
            }
            return filteredData;
        }
        #endregion
    }
}
