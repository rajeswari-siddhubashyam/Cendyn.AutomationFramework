using System;





namespace TestData
{
    class MarketingAuto


    {
   
        public static void AddMAData(string clientName)
        {
            
            AddTestData_ClientConfig(clientName);
            AddTestData_Frontend(clientName);
        }

 

        private static void AddTestData_ClientConfig(string clientName)
        {
            if (clientName == "MarketingAutoQA")
            {
                TestDataHelper.AddTestData_ClientConfig(clientName, "", "", "https://qa.gocendyn.com/login", "", "", "");
            }
            else if (clientName == "MarketingAutoDEV")
            {
                TestDataHelper.AddTestData_ClientConfig(clientName, "", "", "https://dev.gocendyn.com/login", "", "", "");
            }
        }
        #region Add Test Data

        private static void AddTestData_Frontend(string clientName)
        {
                AddTestData_TestPlan_292592(clientName);
                AddTestData_TestPlan_294395(clientName);
                AddTestData_TestPlan_296600(clientName);
                AddTestData_TestPlan_297077(clientName);
                AddTestData_TestPlan_313306(clientName);
                AddTestData_TestPlan_309532(clientName);
                AddTestData_TestPlan_330881(clientName);
                AddTestData_TestPlan_320503(clientName);
                AddTestData_TestPlan_333578(clientName);
                AddTestData_TestPlan_332222(clientName);
                AddTestData_TestPlan_333579(clientName);
                AddTestData_TestPlan_313012(clientName);
                AddTestData_TestPlan_339970(clientName);
                AddTestData_TestPlan_342879(clientName);
                AddTestData_TestPlan_326093(clientName);
                AddTestData_TestPlan_346036(clientName);
                AddTestData_TestPlan_346034(clientName);
                AddTestData_TestPlan_325454(clientName);
                AddTestData_TestPlan_348873(clientName);
                AddTestData_TestPlan_357992(clientName);
        }


            
        private static void AddTestData_TestPlan_292592(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292592", "TC_292525", "1", "TRUE", "allenv", "BothEnv");

            if (clientName == "MarketingAutoQA")
            {
                 //TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292592", "TC_292525", "1", "TRUE", "email", "mnagrani@cendyn.com");
                 //TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292592", "TC_292525", "2", "TRUE", "password", "123Delaplex123");

            }
            else if (clientName == "MarketingAutoDEV")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292592", "TC_292525", "1", "TRUE", "username", "YAYDEV@cendyn17.com");
            }

        }

        private static void AddTestData_TestPlan_294395(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_294395", "TC_293201", "1", "TRUE", "allenv", "BothEnv");

            if (clientName == "MarketingAutoQA")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_294395", "TC_293201", "1", "TRUE", "campaignName", "Campaign Name 123 !@#");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_294395", "TC_293201", "2", "TRUE", "subject", "Subject 123 !#$%");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_294395", "TC_293201", "3", "TRUE", "subjectText", "Make your subject lines relevant, engaging, and tailored for the selected audience.");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_294395", "TC_293201", "4", "TRUE", "tipText", "Use an easily recognizable “friendly-from” name and select the sender email address for this campaign. Select the email address that should receive replies to this email. ");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_294395", "TC_293202", "1", "TRUE", "campaignName", "Test Campaign Name");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_294395", "TC_293202", "2", "TRUE", "campaignFieldError", "Campaign Name cannot be empty.");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_294395", "TC_293202", "3", "TRUE", "subject", "Test Subject");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_294395", "TC_293202", "4", "TRUE", "subjectFieldError", "Subject cannot be empty.");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_294395", "TC_293202", "5", "TRUE", "formFieldError", "From Name/Email cannot be empty.");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_294395", "TC_293202", "6", "TRUE", "formFieldErrorLimit", "Campaign Name must not exceed 250 characters.");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_294395", "TC_293202", "7", "TRUE", "subjectFieldErrorLimit", "Subject must not exceed 100 characters.");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_294395", "TC_293203", "1", "TRUE", "campaignName", "Test Campaign Name");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_294395", "TC_293203", "2", "TRUE", "subject", "Test Subject");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_294395", "TC_293204", "1", "TRUE", "campaignName", "Test Campaign Name");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_294395", "TC_293204", "2", "TRUE", "subject", "Test Subject");
            }
            else if (clientName == "MarketingAutoDEV")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_294395", "TC_293201", "1", "TRUE", "username", "YAYDEV@cendyn17.com");
            }
        }

        private static void AddTestData_TestPlan_296600(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294729", "1", "TRUE", "allenv", "BothEnv");

            if (clientName == "MarketingAutoQA")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294729", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294729", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294730", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294730", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294733", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294733", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294734", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294734", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_303959", "1", "TRUE", "campaignName", "Test Campaign Delete - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_303959", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294731", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294731", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294727", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294727", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_298413", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_298413", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294732", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294732", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_295387", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_295387", "2", "TRUE", "subject", "Test Subject - Automation");
            }
            else if (clientName == "MarketingAutoDEV")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294729", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294729", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294730", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294730", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294733", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294733", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294734", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294734", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_303959", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_303959", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294731", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294731", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294727", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294727", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_298413", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_298413", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294732", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_294732", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_295387", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_296600", "TC_295387", "2", "TRUE", "subject", "Test Subject - Automation");
            }
        }

        private static void AddTestData_TestPlan_297077(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_297077", "TC_297079", "1", "TRUE", "allenv", "BothEnv");

            if (clientName == "MarketingAutoQA")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_297077", "TC_297079", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_297077", "TC_297079", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_297077", "TC_297080", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_297077", "TC_297080", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_297077", "TC_297081", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_297077", "TC_297081", "2", "TRUE", "subject", "Test Subject - Automation");
            }
            else if (clientName == "MarketingAutoDEV")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_297077", "TC_297079", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_297077", "TC_297079", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_297077", "TC_297080", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_297077", "TC_297080", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_297077", "TC_297081", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_297077", "TC_297081", "2", "TRUE", "subject", "Test Subject - Automation");
            }
        }

        private static void AddTestData_TestPlan_313306(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313308", "1", "TRUE", "allenv", "BothEnv");

            if (clientName == "MarketingAutoQA")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313308", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313308", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313309", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313309", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313310", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313310", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313315", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313315", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313311", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313311", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313312", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313312", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313313", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313313", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313314", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313314", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313307", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313307", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313316", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313316", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313317", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313317", "2", "TRUE", "subject", "Test Subject - Automation");

            }
            else if (clientName == "MarketingAutoDEV")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313308", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313308", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313309", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313309", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313310", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313310", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313315", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313315", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313311", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313311", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313312", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313312", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313313", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313313", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313314", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313314", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313307", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313307", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313316", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313316", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313317", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313306", "TC_313317", "2", "TRUE", "subject", "Test Subject - Automation");                
            }
        }

        private static void AddTestData_TestPlan_309532(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309801", "1", "TRUE", "allenv", "BothEnv");

            if (clientName == "MarketingAutoQA")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309801", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309801", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309802", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309802", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309802", "3", "TRUE", "marketingSendDDM", "Once, Daily, Weekly, Monthly,  Hourly, X-Minute");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309803", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309803", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309804", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309804", "2", "TRUE", "subject", "Test Subject - Automation");TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309804", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309804", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309805", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309805", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309806", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309806", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309811", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309811", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309812", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309812", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309809", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309809", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309810", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309810", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309811", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309811", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309811", "3", "TRUE", "hours", "1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309816", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309816", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309816", "3", "TRUE", "x_minutes", "10, 15, 30, 45");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309817", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309817", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309817", "3", "TRUE", "timeZone", "India Standard Time (IST)");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309817", "4", "TRUE", "anothertimeZone", "Acre Time (ACT)");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309819", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309819", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309819", "3", "TRUE", "timeZone", "India Standard Time (IST)");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309819", "4", "TRUE", "anothertimeZone", "Acre Time (ACT)");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309821", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309821", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309821", "3", "TRUE", "timeZone", "India Standard Time (IST)");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309821", "4", "TRUE", "anothertimeZone", "Acre Time (ACT)");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309825", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309825", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309825", "3", "TRUE", "timeZone", "India Standard Time (IST)");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309825", "4", "TRUE", "anothertimeZone", "Acre Time (ACT)");

            }
            else if (clientName == "MarketingAutoDEV")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309801", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309801", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309802", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309802", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309802", "3", "TRUE", "marketingSendDDM", "Once, Daily, Weekly, Monthly, Yearly, Hourly, x - Minutes");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309803", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309803", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309804", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309804", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309805", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309805", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309806", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309806", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309811", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309811", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309812", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309812", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309809", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309809", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309810", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309810", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309811", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309811", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309811", "3", "TRUE", "hours", "1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309816", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309816", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309816", "3", "TRUE", "x_minutes", "10, 15, 30, 45");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309817", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309817", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309817", "3", "TRUE", "timeZone", "India Standard Time (IST)");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309817", "4", "TRUE", "anothertimeZone", "Acre Time (ACT)");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309819", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309819", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309819", "3", "TRUE", "timeZone", "India Standard Time (IST)");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309819", "4", "TRUE", "anothertimeZone", "Acre Time (ACT)");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309821", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309821", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309821", "3", "TRUE", "timeZone", "India Standard Time (IST)");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309821", "4", "TRUE", "anothertimeZone", "Acre Time (ACT)");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309825", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309825", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309825", "3", "TRUE", "timeZone", "India Standard Time (IST)");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_309532", "TC_309825", "4", "TRUE", "anothertimeZone", "Acre Time (ACT)");
            }
        }

        private static void AddTestData_TestPlan_330881(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_330881", "TC_297079", "1", "TRUE", "allenv", "BothEnv");

            if (clientName == "MarketingAutoQA")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_330881", "TC_307250", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_330881", "TC_307250", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_330881", "TC_307251", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_330881", "TC_307251", "2", "TRUE", "subject", "Test Subject - Automation");

            }
            else if (clientName == "MarketingAutoDEV")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_330881", "TC_307250", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_330881", "TC_307250", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_330881", "TC_307251", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_330881", "TC_307251", "2", "TRUE", "subject", "Test Subject - Automation");

            }
        }

        private static void AddTestData_TestPlan_320503(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_320503", "TC_320504", "1", "TRUE", "allenv", "BothEnv");

            if (clientName == "MarketingAutoQA")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_320503", "TC_320504", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_320503", "TC_320504", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_320503", "TC_320510", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_320503", "TC_320510", "2", "TRUE", "subject", "Test Subject - Automation");

            }
            else if (clientName == "MarketingAutoDEV")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_320503", "TC_320504", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_320503", "TC_320504", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_320503", "TC_320510", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_320503", "TC_320510", "2", "TRUE", "subject", "Test Subject - Automation");

            }
        }

        private static void AddTestData_TestPlan_333578(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333578", "TC_333251", "1", "TRUE", "allenv", "BothEnv");

            if (clientName == "MarketingAutoQA")
            {
            
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333578", "TC_333251", "1", "TRUE", "templateName", "Test Template - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333578", "TC_333251", "2", "TRUE", "tag", "Discount");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333578", "TC_333251", "3", "TRUE", "description", "Template Test Description");
            }
            else if (clientName == "MarketingAutoDEV")
            {
                
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333578", "TC_333251", "1", "TRUE", "templateName", "Test Template - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333578", "TC_333251", "2", "TRUE", "tag", "Discount");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333578", "TC_333251", "3", "TRUE", "description", "Template Test Description");
            }

        }
        private static void AddTestData_TestPlan_333579(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333579", "TC_333143", "1", "TRUE", "allenv", "BothEnv");

            if (clientName == "MarketingAutoQA")
            {

                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333579", "TC_333143", "1", "TRUE", "email", "MarketingManagerQA@cendyn17.com");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333579", "TC_333143", "2", "TRUE", "password", "MarketingManager$123");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333579", "TC_333159", "1", "TRUE", "email", "CRMAnalystQA@cendyn17.com");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333579", "TC_333159", "2", "TRUE", "password", "CRMAnalyst$123");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333579", "TC_333163", "1", "TRUE", "email", "DesignerQA@cendyn17.com");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333579", "TC_333163", "2", "TRUE", "password", "Designer$123");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333579", "TC_333170", "1", "TRUE", "email", "MarketingCoordinatorQA@cendyn17.com");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333579", "TC_333170", "2", "TRUE", "password", "MarketingCoordinator$123");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333579", "TC_333179", "1", "TRUE", "email", "AdminQA@cendyn17.com");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333579", "TC_333179", "2", "TRUE", "password", "Admin$123");
            }
            else if (clientName == "MarketingAutoDEV")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333579", "TC_333143", "1", "TRUE", "email", "MarketingManagerQA@cendyn17.com");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333579", "TC_333143", "2", "TRUE", "password", "MarketingManager$123");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333579", "TC_333159", "1", "TRUE", "email", "CRMAnalystQA@cendyn17.com");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333579", "TC_333159", "2", "TRUE", "password", "CRMAnalyst$123");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333579", "TC_333163", "1", "TRUE", "email", "DesignerQA@cendyn17.com");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333579", "TC_333163", "2", "TRUE", "password", "Designer$123");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333579", "TC_333170", "1", "TRUE", "email", "MarketingCoordinatorQA@cendyn17.com");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333579", "TC_333170", "2", "TRUE", "password", "MarketingCoordinator$123");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333579", "TC_333179", "1", "TRUE", "email", "AdminQA@cendyn17.com");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_333579", "TC_333179", "2", "TRUE", "password", "Admin$123");
            }

        }

        private static void AddTestData_TestPlan_332222(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_332222", "TC_333349", "1", "TRUE", "allenv", "BothEnv");

            if (clientName == "MarketingAutoQA")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_332222", "TC_333349", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_332222", "TC_333349", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_332222", "TC_333350", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_332222", "TC_333350", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_332222", "TC_333351", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_332222", "TC_333351", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313012", "TC_333356", "1", "TRUE", "suffixClone", "Clone");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313012", "TC_333356", "2", "TRUE", "filterNameValue", "Equal");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313012", "TC_333369", "1", "TRUE", "suffixClone", "Clone");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313012", "TC_335948", "1", "TRUE", "TemplateHeaderColumn", "NAME, TAGS, STATUS, CAMPAIGNS, UPDATED BY, UPDATED ON");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313012", "TC_335946", "1", "TRUE", "TemplateHeaderColumn", "ID,NAME, STATUS, UPDATED BY, UPDATED ON");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313012", "TC_335957", "1", "TRUE", "TemplateHeaderColumn", "ID,NAME, STATUS, UPDATED BY, UPDATED ON");

            }
            else if (clientName == "MarketingAutoDEV")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_332222", "TC_333349", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_332222", "TC_333349", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_332222", "TC_333350", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_332222", "TC_333350", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_332222", "TC_333351", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_332222", "TC_333351", "2", "TRUE", "subject", "Test Subject - Automation");
            }
        }

        private static void AddTestData_TestPlan_313012(String clientName)
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313012", "TC_293201", "1", "TRUE", "allenv", "BothEnv");

            if (clientName == "MarketingAutoQA")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313012", "TC_325735", "1", "TRUE", "suffixClone", "Clone");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313012", "TC_313016", "1", "TRUE", "suffixClone", "Clone");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313012", "TC_313016", "2", "TRUE", "filterNameValue", "Equal");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313012", "TC_313016", "3", "TRUE", "filterName", "Name");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313012", "TC_325734", "1", "TRUE", "suffixClone", "Clone");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313012", "TC_325734", "2", "TRUE", "filterNameValue", "Equal");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_313012", "TC_325734", "3", "TRUE", "filterName", "Name");

            }
            else if (clientName == "MarketingAutoDEV")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_294395", "TC_293201", "1", "TRUE", "username", "YAYDEV@cendyn17.com");
            }

        }

        private static void AddTestData_TestPlan_339970(String clientName)
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_339970", "TC_330363", "1", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_339970", "TC_330364", "1", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_339970", "TC_330365", "1", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_339970", "TC_330366", "1", "TRUE", "allenv", "BothEnv");

            if (clientName == "MarketingAutoQA")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_339970", "TC_330363", "1", "TRUE", "filterOption", "Equal, Contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_339970", "TC_330364", "1", "TRUE", "filterOption", "starts with, ends with, equal, contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_339970", "TC_330365", "1", "TRUE", "filterOption", "contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_339970", "TC_330366", "1", "TRUE", "filterOption", "equal, between");
            }
            else if (clientName == "MarketingAutoDEV")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_339970", "TC_330363", "1", "TRUE", "filterOption", "Equal, Contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_339970", "TC_330364", "1", "TRUE", "filterOption", "starts with, ends with, equal, contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_339970", "TC_330365", "1", "TRUE", "filterOption", "contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_339970", "TC_330366", "1", "TRUE", "filterOption", "equal, between");
            }

        }

        private static void AddTestData_TestPlan_342879(String clientName)
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_342879", "TC_335991", "1", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_342879", "TC_335994", "1", "TRUE", "allenv", "BothEnv");
            
            

            if (clientName == "MarketingAutoQA")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_342879", "TC_335991", "1", "TRUE", "name", "QA Automation Template");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_342879", "TC_335991", "2", "TRUE", "description", "QA Automation Template description");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_342879", "TC_335994", "1", "TRUE", "name", "QA Automation Template");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_342879", "TC_335994", "2", "TRUE", "description", "QA Automation Template description");
            }
            else if (clientName == "MarketingAutoDEV")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_342879", "TC_335991", "1", "TRUE", "name", "QA Automation Template");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_342879", "TC_335991", "2", "TRUE", "description", "QA Automation Template description");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_342879", "TC_335994", "1", "TRUE", "name", "QA Automation Template");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_342879", "TC_335994", "2", "TRUE", "description", "QA Automation Template description");
            }

        }

        private static void AddTestData_TestPlan_326093(String clientName)
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_326093", "TC_326096", "1", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_326093", "TC_326097", "1", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_326093", "TC_326098", "1", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_326093", "TC_326100", "1", "TRUE", "allenv", "BothEnv");

            if (clientName == "MarketingAutoQA")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_326093", "TC_326096", "1", "TRUE", "filterOption", "equal, contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_326093", "TC_326097", "1", "TRUE", "filterOption", "starts with, ends with, equal, contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_326093", "TC_326098", "1", "TRUE", "filterOption", "contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_326093", "TC_326100", "1", "TRUE", "filterOption", "equal, between");
            }
            else if (clientName == "MarketingAutoDEV")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_326093", "TC_326096", "1", "TRUE", "filterOption", "starts with, ends with, equal, contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_326093", "TC_326097", "1", "TRUE", "filterOption", "starts with, ends with, equal, contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_326093", "TC_326098", "1", "TRUE", "filterOption", "contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_326093", "TC_326100", "1", "TRUE", "filterOption", "equal, between");
            }

        }

        private static void AddTestData_TestPlan_325454(String clientName)
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_325454", "TC_325458", "1", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_325454", "TC_325790", "1", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_325454", "TC_325792", "1", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_325454", "TC_325804", "1", "TRUE", "allenv", "BothEnv");

            if (clientName == "MarketingAutoQA")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_325454", "TC_325458", "1", "TRUE", "filterOption", "equal, contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_325454", "TC_325790", "1", "TRUE", "filterOption", "starts with, ends with, equal, contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_325454", "TC_325792", "1", "TRUE", "filterOption", "contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_326093", "TC_325804", "1", "TRUE", "filterOption", "contains");
            }
            else if (clientName == "MarketingAutoDEV")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_325454", "TC_325458", "1", "TRUE", "filterOption", "starts with, ends with, equal, contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_325454", "TC_325790", "1", "TRUE", "filterOption", "starts with, ends with, equal, contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_325454", "TC_325792", "1", "TRUE", "filterOption", "contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_325454", "TC_325804", "1", "TRUE", "filterOption", "equal, between");
            }

        }
        
        private static void AddTestData_TestPlan_346036(String clientName)
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_324356", "1", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_324331", "1", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_324332", "1", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_324343", "1", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_324344", "1", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_346039", "1", "TRUE", "allenv", "BothEnv");


            if (clientName == "MarketingAutoQA")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_324356", "1", "TRUE", "filterOption", "equal, contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_324331", "1", "TRUE", "filterOption", "starts with, ends with, equal, contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_324332", "1", "TRUE", "filterOption", "contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_324343", "1", "TRUE", "filterOption", "equal, between");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_324344", "1", "TRUE", "filterOption", "contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_346039", "1", "TRUE", "filterOption", "equal, between");

                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_324356", "1", "TRUE", "CampaignName", "QA Automation API Campaign - TC-324356");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_324331", "1", "TRUE", "CampaignName", "QA Automation API Campaign - TC-324331");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_324332", "1", "TRUE", "CampaignName", "QA Automation API Campaign - TC-324332");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_324343", "1", "TRUE", "CampaignName", "QA Automation API Campaign - TC-324343");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_324344", "1", "TRUE", "CampaignName", "QA Automation API Campaign - TC-324344");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_346039", "1", "TRUE", "CampaignName", "QA Automation API Campaign - TC-346039");
            }
            else if (clientName == "MarketingAutoDEV")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_324356", "1", "TRUE", "filterOption", "equal, contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_324331", "1", "TRUE", "filterOption", "starts with, ends with, equal, contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_324332", "1", "TRUE", "filterOption", "contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_324343", "1", "TRUE", "filterOption", "equal, between");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_324344", "1", "TRUE", "filterOption", "contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_346039", "1", "TRUE", "filterOption", "equal, between");

                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_324356", "1", "TRUE", "CampaignName", "QA Automation API Campaign - TC-324356");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_324331", "1", "TRUE", "CampaignName", "QA Automation API Campaign - TC-324331");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_324332", "1", "TRUE", "CampaignName", "QA Automation API Campaign - TC-324332");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_324343", "1", "TRUE", "CampaignName", "QA Automation API Campaign - TC-324343");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_324344", "1", "TRUE", "CampaignName", "QA Automation API Campaign - TC-324344");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346036", "TC_346039", "1", "TRUE", "CampaignName", "QA Automation API Campaign - TC-346039");
            }
        

        }

        private static void AddTestData_TestPlan_346034(String clientName)
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346051", "1", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346055", "1", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346056", "1", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346057", "1", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346058", "1", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346059", "1", "TRUE", "allenv", "BothEnv");


            if (clientName == "MarketingAutoQA")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346051", "1", "TRUE", "filterOption", "equal, contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346055", "1", "TRUE", "filterOption", "starts with, ends with, equal, contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346056", "1", "TRUE", "filterOption", "contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346057", "1", "TRUE", "filterOption", "equal, between");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346058", "1", "TRUE", "filterOption", "contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346059", "1", "TRUE", "filterOption", "equal, between");

                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346051", "1", "TRUE", "CampaignName", "QA Automation API Campaign - TC-346051");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346055", "1", "TRUE", "CampaignName", "QA Automation API Campaign - TC-346055");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346056", "1", "TRUE", "CampaignName", "QA Automation API Campaign - TC-346056");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346057", "1", "TRUE", "CampaignName", "QA Automation API Campaign - TC-346057");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346058", "1", "TRUE", "CampaignName", "QA Automation API Campaign - TC-346058");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346059", "1", "TRUE", "CampaignName", "QA Automation API Campaign - TC-346059");
            }
            else if (clientName == "MarketingAutoDEV")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346051", "1", "TRUE", "filterOption", "equal, contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346055", "1", "TRUE", "filterOption", "starts with, ends with, equal, contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346056", "1", "TRUE", "filterOption", "contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346057", "1", "TRUE", "filterOption", "equal, between");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346058", "1", "TRUE", "filterOption", "contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346039", "1", "TRUE", "filterOption", "equal, between");

                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346051", "1", "TRUE", "CampaignName", "QA Automation API Campaign - TC-346051");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346055", "1", "TRUE", "CampaignName", "QA Automation API Campaign - TC-346055");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346056", "1", "TRUE", "CampaignName", "QA Automation API Campaign - TC-346056");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346057", "1", "TRUE", "CampaignName", "QA Automation API Campaign - TC-346057");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346058", "1", "TRUE", "CampaignName", "QA Automation API Campaign - TC-346058");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_346034", "TC_346059", "1", "TRUE", "CampaignName", "QA Automation API Campaign - TC-346059");
            }

        }

        private static void AddTestData_TestPlan_348873(String clientName)
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_348873", "TC_344498", "1", "TRUE", "allenv", "BothEnv");
            if (clientName == "MarketingAutoQA")
            {
                //In the scenario all expected values mentioned in the string
                //FirstName: John, LastName: Bob, PropertyName: Hotel Origami, Arrival date: 01 - 28 - 2022(Today+1 so one will be in the string), Confirmation: TC344498 - 1,
                // Departure Date: 01 - 30 - 2022, Num of Adults: 2, Num of Children: 0,  Type of Room: Ocean Front, Total Amount: 0.0
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_348873", "TC_344498", "1", "TRUE", "emailTitle", "QA Automation Campaign Description");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_348873", "TC_344498", "2", "TRUE", "scenario1", "John, Bob, Hotel Origami, TC344498-1, 2, 0, Ocean Front, 0.0,  Today+1, Today+3");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_348873", "TC_344498", "3", "TRUE", "email", "TC344498-1@cendyn17.com, TC344498-1");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_348873", "TC_344498", "4", "TRUE", "scenario2", "Adam, Allan, Hotel Origami, TC344498-2, 2, 0, Ocean Front, 0.0,  Today+1, Today+3");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_348873", "TC_344498", "5", "TRUE", "email", "TC344498-2@cendyn17.com, TC344498-2");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_348873", "TC_344498", "6", "TRUE", "scenario3", "Tr#$%evor, Berry, Hotel Origami, TC344498-6, 1, 1, Ocean Front, 59.678,  Today+1, Today+3");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_348873", "TC_344498", "7", "TRUE", "email", "TC344498-6@cendyn17.com, TC344498-6");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_348873", "TC_344498", "8", "TRUE", "scenario4", "Stephen, Blake, Hotel Origami, TC344498-7, 1, 1, Ocean Front,59.678,  Today+29, Today+30");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_348873", "TC_344498", "9", "TRUE", "email", "TC344498-7@cendyn17.com, TC344498-7");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_348873", "TC_344498", "10", "TRUE", "scenario5", "Sebastian, Davidson, Hotel Origami,  TC344498-10-01, 5, 1, Ocean Front,10.0,  Today+1, Today+4");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_348873", "TC_344498", "11", "TRUE", "email", "TC344498-10@cendyn17.com,TC344498-10-01");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_348873", "TC_344498", "12", "TRUE", "scenario6", "Sebastian, Davidson, Hotel Origami,  TC344498-10-02, 5, 1, Ocean Front,10.0,  Today+1, Today+4");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_348873", "TC_344498", "13", "TRUE", "email", "TC344498-10@cendyn17.com, TC344498-10-02");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_348873", "TC_344498", "14", "TRUE", "email", "TC344498-3@cendyn17.com, TC344498-3");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_348873", "TC_344498", "15", "TRUE", "email", "TC344498-4@cendyn17.com, TC344498-4");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_348873", "TC_344498", "16", "TRUE", "email", "TC344498-8@cendyn17.com, TC344498-8");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_348873", "TC_344498", "17", "TRUE", "yahooEmail", "testuser0108@yahoo.com");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_348873", "TC_344498", "18", "TRUE", "yahooPassword", "Cendyn123$");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_348873", "TC_344498", "19", "TRUE", "email", "TC344498-9@cendyn17.com, TC344498-9");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_348873", "TC_344498", "20", "TRUE", "scenario9", "William, Clarkson, Hotel Origami,  TC344498-9, 5, 1, Ocean Front, 10.0,  Today+1, Today+4");
            }
            else if (clientName == "MarketingAutoDEV")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_325454", "TC_325458", "1", "TRUE", "filterOption", "starts with, ends with, equal, contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_325454", "TC_325790", "1", "TRUE", "filterOption", "starts with, ends with, equal, contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_325454", "TC_325792", "1", "TRUE", "filterOption", "contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_325454", "TC_325804", "1", "TRUE", "filterOption", "equal, between");
            }

        }

        private static void AddTestData_TestPlan_357992(String clientName)
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_333249", "1", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357987", "2", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357988", "3", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357993", "4", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357994", "5", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357995", "6", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357996", "7", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_359105", "8", "TRUE", "allenv", "BothEnv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357997", "9", "TRUE", "allenv", "BothEnv");
            if (clientName == "MarketingAutoQA")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_333249", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_333249", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_333249", "3", "TRUE", "cards", "One-Time, Auto Response, Custom");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_333249", "4", "TRUE", "sendDDM", "Weekly");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_333249", "5", "TRUE", "defaultsendDDM", "Once");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_333249", "6", "TRUE", "rejectComments", "This is reject comment");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_333249", "7", "TRUE", "rejectText", "Your request was rejected on");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357987", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357987", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357987", "3", "TRUE", "cards", "Confirmation, Updates, Cancellation, Pre-stay, Post-stay, Custom");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357987", "4", "TRUE", "defaultsendDDM", "Immediately");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357987", "5", "TRUE", "rejectComments", "This is reject comment");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357987", "6", "TRUE", "rejectText", "Your request was rejected on");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357988", "1", "TRUE", "audienceName", "AutomationAudienceName");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357988", "2", "TRUE", "segmentName", "AutomationSegment");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357988", "3", "TRUE", "domain", "Profile");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357988", "4", "TRUE", "field", "First Name");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357988", "5", "TRUE", "operation", "Contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357988", "6", "TRUE", "criteriavalue", "John");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357993", "1", "TRUE", "editURL", "https://marketingqa.gocendyn.com/campaigns/build-campaign/");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357993", "2", "TRUE", "cloneURL", "https://marketingqa.gocendyn.com/campaigns/build-campaign/settings/cloneFrom=");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357993", "3", "TRUE", "suffixClone", "Clone");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357993", "4", "TRUE", "filterNameValue", "Equal");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357993", "5", "TRUE", "filterName", "Name");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357994", "1", "TRUE", "filterOption", "starts with, ends with, equal, contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357994", "2", "TRUE", "sortOption", "most - least, least - most");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357995", "1", "TRUE", "filterOption", "starts with, ends with, equal, contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357995", "2", "TRUE", "sortOption", "z - a, a - z");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357996", "1", "TRUE", "filterOption", "starts with, ends with, equal, contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357996", "2", "TRUE", "sortOption", "z - a, a - z");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_359105", "1", "TRUE", "segmentName", "AutomationSegmentTest");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357997", "1", "TRUE", "emailTitle", "QA Automation Campaign Description");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357997", "2", "TRUE", "scenario1", "John, Bob, Hotel Origami, TC357997, 2, 0, Ocean Front, 0.0,  Today+28, Today+29");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357997", "3", "TRUE", "email", "TC357997@cendyn17.com, TC357997");

            }
            else if (clientName == "MarketingAutoDEV")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_333249", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_333249", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_333249", "3", "TRUE", "cards", "One-Time, Auto Response, Custom");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_333249", "4", "TRUE", "sendDDM", "Weekly");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_333249", "5", "TRUE", "defaultsendDDM", "Once");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357987", "1", "TRUE", "campaignName", "Test Campaign - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357987", "2", "TRUE", "subject", "Test Subject - Automation");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357987", "3", "TRUE", "cards", "Confirmation, Updates, Cancellation, Pre-stay, Post-stay, Custom");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357987", "4", "TRUE", "defaultsendDDM", "Immediately");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357988", "1", "TRUE", "audienceName", "AutomationAudienceName");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357988", "2", "TRUE", "segmentName", "AutomationSegment");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357988", "3", "TRUE", "domain", "Profile");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357988", "4", "TRUE", "field", "First Name");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357988", "5", "TRUE", "operation", "Contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357988", "6", "TRUE", "criteriavalue", "John");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357993", "1", "TRUE", "editURL", "https://marketingdev.gocendyn.com/campaigns/build-campaign/");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357993", "2", "TRUE", "cloneURL", "https://marketingdev.gocendyn.com/campaigns/build-campaign/settings/cloneFrom=");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357993", "3", "TRUE", "suffixClone", "Clone");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357993", "4", "TRUE", "filterNameValue", "Equal");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357993", "5", "TRUE", "filterName", "Name");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357994", "1", "TRUE", "filterOption", "starts with, ends with, equal, contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357994", "2", "TRUE", "sortOption", "most - least, least - most");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357995", "1", "TRUE", "filterOption", "starts with, ends with, equal, contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357995", "2", "TRUE", "sortOption", "z - a, a - z");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357996", "1", "TRUE", "filterOption", "starts with, ends with, equal, contains");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357996", "2", "TRUE", "sortOption", "z - a, a - z");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_359105", "1", "TRUE", "segmentName", "AutomationSegmentTest");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357997", "1", "TRUE", "emailTitle", "QA Automation Campaign Description");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357997", "2", "TRUE", "scenario1", "John, Bob, Hotel Origami, TC357997, 2, 0, Ocean Front, 0.0,  Today+28, Today+29");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_357992", "TC_357997", "3", "TRUE", "email", "TC357997@cendyn17.com, TC357997");
            }

        }

        #endregion Add Test Data
    }
}