using System;


namespace TestData
{
    class CHC_Unified_Profile
    {
        public static void AddUPData(string clientName)
        {
            AddTestData_ClientUP(clientName);
            AddTestData_Frontend(clientName);
        }

        private static void AddTestData_ClientUP(string clientName)
        {
            if (clientName == "CHC_UP_AutoQA")
            {
                TestDataHelper.AddTestData_ClientConfig(clientName, "", "", "https://qa.gocendyn.com/", "", "", "");
            }
            if (clientName == "CHC_UP_AutoDemo")
            {
                TestDataHelper.AddTestData_ClientConfig(clientName, "", "", "https://demo.gocendyn.com/", "", "", "");
            }
            else if (clientName == "CHC_UP_AutoDEV")
            {
                TestDataHelper.AddTestData_ClientConfig(clientName, "", "", "https://dev.gocendyn.com/", "", "", "");
            }

        }

        #region Add Test Data

        private static void AddTestData_Frontend(string clientName)
        {
            AddTestData_TestPlan_356196(clientName);
        }

        private static void AddTestData_TestPlan_356196(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_339264", "TC_339266", "1", "TRUE", "allenv", "BothEnv");

            if (clientName == "CHC_UP_AutoQA")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_356196", "TC_340278", "1", "TRUE", "email", "testuser10@cendyn17.com");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_356196", "TC_340278", "2", "TRUE", "password", "Cendyn123$");
            }
            if (clientName == "CHC_UP_AutoDemo")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_356196", "TC_340276", "1", "TRUE", "email", "chc_demo@cendyn.com");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_356196", "TC_340276", "2", "TRUE", "password", "@Sc@A6Ffs#mrY#eX");
            }
            else if (clientName == "CHC_UP_AutoDEV")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_356196", "TC_340276", "1", "TRUE", "email", "testuser10@cendyn17.com");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_356196", "TC_340276", "2", "TRUE", "password", "Cendyn123$");
            }

        }
        #endregion
    }
}
