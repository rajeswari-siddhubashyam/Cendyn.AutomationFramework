using System;

namespace TestData

{
    class CMS
    {
        public static void AddMAData(string clientName)
        {

            AddTestData_ClientConfig(clientName);
            AddTestData_Frontend(clientName);
        }



        private static void AddTestData_ClientConfig(string clientName)
        {
            if (clientName == "CMSQA")
            {
                TestDataHelper.AddTestData_ClientConfig(clientName, "", "", "https://qa.gocendyn.com/login", "", "", "");
            }
            else if (clientName == "CMSDEV")
            {
                TestDataHelper.AddTestData_ClientConfig(clientName, "", "", "https://dev.gocendyn.com/login", "", "", "");
            }
        }

        private static void AddTestData_Frontend(string clientName)
        {
            AddTestData_TestPlan_TP_000000(clientName);
    
        }

        private static void AddTestData_TestPlan_TP_000000(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_000000", "TC_000001", "1", "TRUE", "allenv", "BothEnv");

            if (clientName == "CMSQA")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_000000", "TC_000001", "1", "TRUE", "username", "YAYQA@cendyn17.com");


            }
            else if (clientName == "CMSDEV")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_000000", "TC_000001", "1", "TRUE", "username", "YAYDEV@cendyn17.com");
            }

        }
    }
}
