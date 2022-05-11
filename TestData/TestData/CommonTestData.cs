namespace TestData
{
    public class CommonTestData
    {
        public static void AddCommonTestData()
        {
            AddTestData_Common();
            AddTestData_CatchAll();
            AddTestData_Controller();
            AddTestData_CRMAPI();
            AddTestData_Gmail();
            AddTestData_Kiosk();
            AddTestData_All();
        }

        #region Common Test Data
        private static void AddTestData_Common()
        {
            TestDataHelper.AddRecord("ALL", "ALL", "NA", "0", "0", "1", "TRUE", "Password", "Cendyn123$");
        }

        private static void AddTestData_CatchAll()
        {
            TestDataHelper.AddRecord("ALL", "Catchall", "NA", "0", "0", "1", "TRUE", "Username", "catchall@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "Catchall", "NA", "0", "0", "1", "TRUE", "Password", "Cendyn1234$");
        }

        private static void AddTestData_Controller()
        {
            TestDataHelper.AddRecord("ALL", "Controller", "NA", "0", "0", "1", "TRUE", "Browser", "Chrome");
        }

        private static void AddTestData_CRMAPI()
        {
            TestDataHelper.AddRecord("ALL", "CRMAPI", "NA", "0", "0", "1", "TRUE", "Url", "https://crmapiqa.cendyn.com/");
            TestDataHelper.AddRecord("ALL", "CRMAPI", "NA", "0", "0", "1", "TRUE", "Username", "LOYALTY");
            TestDataHelper.AddRecord("ALL", "CRMAPI", "NA", "0", "0", "1", "TRUE", "Password", "LOY#912765");
        }

        private static void AddTestData_Gmail()
        {
            TestDataHelper.AddRecord("ALL", "Gmail", "NA", "0", "0", "1", "TRUE", "Username", "cendynautomationqa@gmail.com");
            TestDataHelper.AddRecord("ALL", "Gmail", "NA", "0", "0", "1", "TRUE", "SignUpFirstName", "John");
            TestDataHelper.AddRecord("ALL", "Gmail", "NA", "0", "0", "1", "TRUE", "SignUpLastName", "Doe");
        }

        private static void AddTestData_Kiosk()
        {

        }

        private static void AddTestData_All()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "NA", "0", "0", "1", "TRUE", "Username", "qaAuto@cendyn17.com");
        }   
        #endregion
    }
}
