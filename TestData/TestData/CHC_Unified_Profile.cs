using System;


namespace TestData
{
    class CHC_Unified_Profile
    {
        public static void AddCHCData(string clientName)
        {

            AddTestData_ClientConfig(clientName);
            AddTestData_Frontend(clientName);
        }

        private static void AddTestData_ClientConfig(string clientName)
        {
            //if (clientName == "CHCAuto_UP_QA")
            //{
            //    TestDataHelper.AddTestData_ClientConfig(clientName, "", "", "https://qa.gocendyn.com/", "", "", "");
            //}
            //else if (clientName == "CHCAuto_UP_DEV")
            //{
            //    TestDataHelper.AddTestData_ClientConfig(clientName, "", "", "https://dev.gocendyn.com/", "", "", "");
            //}
            if (clientName == "CHCAutoQA")
            {
                TestDataHelper.AddTestData_ClientConfig(clientName, "", "", "https://qa.gocendyn.com/", "", "", "");
            }
            else if (clientName == "CHCAutoDEV")
            {
                TestDataHelper.AddTestData_ClientConfig(clientName, "", "", "https://dev.gocendyn.com/", "", "", "");
            }

        }

        #region Add Test Data

        private static void AddTestData_Frontend(string clientName)
        {
            AddTestData_TestPlan_339264(clientName);
        }

        private static void AddTestData_TestPlan_339264(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_339264", "TC_339266", "1", "TRUE", "allenv", "BothEnv");

            if (clientName == "CHCAutoQA")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_339264", "TC_339266", "1", "TRUE", "email", "testuser10@cendyn17.com");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_339264", "TC_339266", "2", "TRUE", "password", "Cendyn123$");

            }
            else if (clientName == "CHCAutoDEV")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_339264", "TC_339266", "1", "TRUE", "email", "testuser10@cendyn17.com");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_339264", "TC_339266", "2", "TRUE", "password", "Cendyn123$");
            }

        }
        #endregion
    }
}
