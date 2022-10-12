using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestData
{
    class CHC_Config
    {
        public static void AddCHC_ConfigData(string clientName)
        {

            AddTestData_ClientConfig(clientName);
            AddTestData_Frontend(clientName);
        }

        public static void AddCHC_UPData(string clientName)
        {

            AddTestData_ClientUP(clientName);
            AddTestData_Frontend(clientName);
        }

        private static void AddTestData_ClientConfig(string clientName)
        {
            if (clientName == "CHC_ConfigQA")
            {
                //TestDataHelper.AddTestData_ClientConfig(clientName, "", "", "https://dev.gocendyn.com/", "", "", "");
                TestDataHelper.AddTestData_ClientConfig(clientName, "", "", "https://qa.gocendyn.com/", "", "", "");
            }
            else if (clientName == "CHC_ConfigDEV")
            {
                TestDataHelper.AddTestData_ClientConfig(clientName, "", "", "https://dev.gocendyn.com/", "", "", "");
            }
           /* else if (clientName == "CHC_ConfigDEMO")
            {
                TestDataHelper.AddTestData_ClientConfig(clientName, "", "", "https://demo.gocendyn.com/", "", "", "");
            }*/

        }

        private static void AddTestData_ClientUP(string clientName)
        {
            if (clientName == "CHC_UPQA")
            {
                TestDataHelper.AddTestData_ClientConfig(clientName, "", "", "https://qa.gocendyn.com/", "", "", "");
            }
            else if (clientName == "CHC_UPDEV")
            {
                TestDataHelper.AddTestData_ClientConfig(clientName, "", "", "https://dev.gocendyn.com/", "", "", "");
            }

        }

        #region Add Test Data

        private static void AddTestData_Frontend(string clientName)
        {
            AddTestData_TestPlan_TP_000000(clientName);
            AddTestData_TestPlan_TP_323199(clientName);
        }

        private static void AddTestData_TestPlan_TP_000000(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_000000", "TC_000000", "1", "TRUE", "allenv", "BothEnv");

            if (clientName == "CHC_ConfigQA")
            {
                 TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_000000", "TC_000000", "1", "TRUE", "email", "testuser10@cendyn17.com");
                 TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_000000", "TC_000000", "2", "TRUE", "password", "Cendyn321#");
            

            }
            else if (clientName == "CHC_ConfigDEV")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_000000", "TC_000000", "1", "TRUE", "email", "testuser10@cendyn17.com");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_000000", "TC_000000", "2", "TRUE", "password", "Cendyn321#");
            }
            /*else if (clientName == "CHC_ConfigDEMO")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_000000", "TC_000000", "1", "TRUE", "email", "testuser10@cendyn17.com");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_000000", "TC_000000", "2", "TRUE", "password", "Cendyn321$");
            }*/

        }
        private static void AddTestData_TestPlan_TP_323199(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_309589", "1", "TRUE", "allenv", "BothEnv");

            if (clientName == "CHC_ConfigQA")
            {
                //TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_309589", "1", "TRUE", "email", "testuser10@cendyn17.com");
                //TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_309589", "2", "TRUE", "password", "Cendyn123$");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_353241", "1", "TRUE", "header", "Property ID");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_353241", "2", "TRUE", "header", "Property");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_353241", "3", "TRUE", "header", "Brand");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_353241", "4", "TRUE", "header", "Chain");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_326759", "1", "TRUE", "search", "Hotel Origami Miami Downtown");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_326759", "2", "TRUE", "noRecords", "No records to display");

                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_309597", "1", "TRUE", "search", "Hotel Origami Miami Downtown");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_309597", "2", "TRUE", "property_dashboard", "Property Dashboard");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_309597", "3", "TRUE", "brand_dashboard", "Brand Dashboard");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_309597", "4", "TRUE", "chain_dashboard", "Chain Dashboard");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_309597", "5", "TRUE", "brand_name", "Hotel Origami & Resorts");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_309597", "6", "TRUE", "chain_name", "Origami Hotels");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_309602", "1", "TRUE", "create_property", "Create Property");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_309602", "2", "TRUE", "create_brand", "Create Brand");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_309602", "3", "TRUE", "create_chain", "Create Chain");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_314185", "1", "TRUE", "search", "Hotel Kanbina");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_314185", "4", "TRUE", "chain_dashboard", "Chain Dashboard");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_314185", "6", "TRUE", "chain_name", "Ikigai Hotels");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_314163", "1", "TRUE", "search", "Hotel Kanbina");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_314163", "4", "TRUE", "chain_dashboard", "Chain Dashboard");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_314163", "6", "TRUE", "chain_name", "Ikigai Hotels");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_314192", "1", "TRUE", "search", "Hotel Kanbina");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_314192", "4", "TRUE", "chain_dashboard", "Chain Dashboard");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_314192", "6", "TRUE", "chain_name", "Ikigai Hotels");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_314192", "3", "TRUE", "brand_dashboard", "Brand Dashboard");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_314190", "1", "TRUE", "search", "Hotel Kanbina");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_314190", "4", "TRUE", "chain_dashboard", "Chain Dashboard");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_314190", "6", "TRUE", "chain_name", "Ikigai Hotels");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_314190", "2", "TRUE", "property_dashboard", "Property Dashboard");
                //Brand Dashboard
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_349772", "TC_314618", "1", "TRUE", "search", "Hotel Kanbina");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_349772", "TC_314618", "3", "TRUE", "brand_dashboard", "Brand Dashboard");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_349772", "TC_314618", "5", "TRUE", "brand_name", "Wabi-Sabi Hotels");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_349772", "TC_314610", "1", "TRUE", "search", "Hotel Kanbina");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_349772", "TC_314610", "3", "TRUE", "brand_dashboard", "Brand Dashboard");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_349772", "TC_314610", "5", "TRUE", "brand_name", "Wabi-Sabi Hotels");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_349772", "TC_314590", "1", "TRUE", "search", "Hotel Kanbina");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_349772", "TC_314590", "3", "TRUE", "brand_dashboard", "Brand Dashboard");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_349772", "TC_314590", "5", "TRUE", "brand_name", "Wabi-Sabi Hotels");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_349772", "TC_349764", "1", "TRUE", "search", "Hotel Kanbina");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_349772", "TC_349764", "3", "TRUE", "brand_dashboard", "Brand Dashboard");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_349772", "TC_349764", "2", "TRUE", "edit_brand", "Edit Brand");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_349772", "TC_349764", "5", "TRUE", "brand_name", "Wabi-Sabi Hotels");

                //Property Dahsboard 
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_349775", "TC_314581", "1", "TRUE", "search", "Test QA Prop 1");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_349775", "TC_314581", "2", "TRUE", "property_dashboard", "Property Dashboard");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_349775", "TC_314581", "7", "TRUE", "property_name", "Test QA Prop 1");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_349775", "TC_314204", "1", "TRUE", "search", "Test QA Prop 1");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_349775", "TC_314204", "2", "TRUE", "property_dashboard", "Property Dashboard");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_349775", "TC_314204", "7", "TRUE", "property_name", "Test QA Prop 1");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_349775", "TC_314570", "1", "TRUE", "search", "Test QA Prop 1");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_349775", "TC_314570", "2", "TRUE", "property_dashboard", "Property Dashboard");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_349775", "TC_314570", "7", "TRUE", "property_name", "Test QA Prop 1");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_309602", "1", "TRUE", "create_property", "Create Property");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_349772", "TC_349765", "1", "TRUE", "search", "Test QA Prop 1");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_349772", "TC_349765", "2", "TRUE", "property_dashboard", "Property Dashboard");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_349772", "TC_349765", "3", "TRUE", "edit_property", "Edit Property");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_349772", "TC_349765", "5", "TRUE", "property_name", "Test QA Prop 1");

            }
            else if (clientName == "CHC_ConfigDEV")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_309589", "1", "TRUE", "email", "testuser10@cendyn17.com");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_309589", "2", "TRUE", "password", "Cendyn123$");
            }

        }

        private static void AddTestData_TestPlan_TP_356196(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_356196", "TC_340276", "1", "TRUE", "allenv", "BothEnv");

            if (clientName == "CHC_UPQA")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_356196", "TC_340276", "1", "TRUE", "email", "testuser10@cendyn17.com");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_356196", "TC_340276", "2", "TRUE", "password", "Cendyn123$");

                //TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_309602", "3", "TRUE", "create_chain", "Create Chain");
            }
            else if (clientName == "CHC_UPDEV")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_309589", "1", "TRUE", "email", "testuser10@cendyn17.com");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_309589", "2", "TRUE", "password", "Cendyn123$");
            }

        }

        private static void AddTestData_TestPlan_TP_334571(string clientName)
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_334571", "TC_334578", "1", "TRUE", "allenv", "BothEnv");

            if (clientName == "CHC_UPQA")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_334571", "TC_334578", "1", "TRUE", "email", "testuser10@cendyn17.com");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_334571", "TC_334578", "2", "TRUE", "password", "Cendyn123$");

                //TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_323199", "TC_309602", "3", "TRUE", "create_chain", "Create Chain");
            }
            else if (clientName == "CHC_UPDEV")
            {
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_334571", "TC_334578", "1", "TRUE", "email", "testuser10@cendyn17.com");
                TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_334571", "TC_334578", "2", "TRUE", "password", "Cendyn123$");
            }

        }
        #endregion
    }
}
