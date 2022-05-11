
namespace TestData
{
    class RevIntel
    {
        public static void AddeMenusData(string clientName)
        {
            AddTestData_ClientConfig(clientName);
            AddTestData_Frontend(clientName);
        }
        private static void AddTestData_ClientConfig(string clientName)
        {
            TestDataHelper.AddTestData_ClientConfig("RevIntel", "", "Testautomation@cendyn17.com", "https://devrhbi.revintel.co/", "Testautomation@cendyn17.com", "", "");

        }
        #region Add Test Data
        private static void AddTestData_Frontend(string clientName)
        {
            AddTestData_SmokeTest_TC_251470();//Login and Log out is successful and URL is pointing to right database          
            AddTestData_SmokeTest_TC_252390();//Verify the default filter value and eyeball on calculated field in report
            AddTestData_SmokeTest_TC_252482();//Verify the Other Links
            AddTestData_SmokeTest_TC_252494();//Verify attempting to create a new user with exsiting email id or userid should fail
            AddTestData_SmokeTest_TC_252496();//Verify attempting to create a new portfolia with same name should fail
            AddTestData_SmokeTest_TC_252394();//Verify logged in user is able to navigate to all menu and generate random reports
            AddTestData_SmokeTest_TC_252401();//Verify user should be able to export the Pace report data in all format

            AddTestData_TestPlan_TC_252718();//Validate the Agent Analysis report (no filter)
            AddTestData_TestPlan_TC_252719();//Validate the Agent Summary report
            AddTestData_TestPlan_TC_252720();//Validate the Agent Room Type Analysis report
            AddTestData_TestPlan_TC_252721();//Validate the Annual Agent Analysis by Month report
            AddTestData_TestPlan_TC_252722();//Validate the Company Analysis report
            AddTestData_TestPlan_TC_252723();//Validate the Annual Company Analysis by Month report
            AddTestData_TestPlan_TC_252724();//Validate the Company Summary report
            AddTestData_TestPlan_TC_256851();//Validate the Agent Analysis report (one filter)
            AddTestData_TestPlan_TC_256852();//Validate the Agent Analysis report (multiple filter)
            AddTestData_TestPlan_TC_252725();//Validate the Parent Company Analysis report
            AddTestData_TestPlan_TC_252726();//Validate the Parent Travel Agent Analysis report
            AddTestData_TestPlan_TC_252727();//Validate the Agent Period Summary report
            AddTestData_TestPlan_TC_252728();//Company Period Summary report
            AddTestData_TestPlan_TC_252729();//Validate the Agent Trend Report
            AddTestData_TestPlan_TC_264418();//Validate the Company Trend Report

            AddTestData_TestPlan_TC_253349();//Validate the Portfolio Report
            AddTestData_TestPlan_TC_253350();//Validate the Agent By Hotel
            AddTestData_TestPlan_TC_253351();//Validate the Channel By Hotel Report
            AddTestData_TestPlan_TC_253352();//Validate the Company By Hotel
            AddTestData_TestPlan_TC_253353();//Validate the Market By Hotel Report
            AddTestData_TestPlan_TC_253354();//Validate the Province and State By Hotel
            AddTestData_TestPlan_TC_253355();//Validate the Room Type by Hotel
            AddTestData_TestPlan_TC_253356();//Validate the Source Market By Hotel

            AddTestData_TestPlan_TC_252597();//Validate Pace Report
            AddTestData_TestPlan_TC_252598();//Validate Pace Trend
            AddTestData_TestPlan_TC_252599();//Validate Daily Pace and Pickup Analysis
            AddTestData_TestPlan_TC_252600();//Validate Pace and Pickup Analysis
            AddTestData_TestPlan_TC_252601();//Validate Rate Code Pace Report
            AddTestData_TestPlan_TC_252602();//Validate Channel by Room Type Pace
            AddTestData_TestPlan_TC_252603();//Validate Channel Pace Analysis
            AddTestData_TestPlan_TC_252604();//Validate Pickup By Day
            AddTestData_TestPlan_TC_252643();//Validate Annual Pickup by Day
            AddTestData_TestPlan_TC_252644();//Validate Length of Stay Report
            AddTestData_TestPlan_TC_252645();//Validate Rooms Lead time
            AddTestData_TestPlan_TC_252605();//Validate Pickup by Day Detailed
            AddTestData_TestPlan_TC_252606();//Validate Monthly Pick up
            AddTestData_TestPlan_TC_252607();//Validate Production Pattern Report
            AddTestData_TestPlan_TC_252608();//Validate High Occupancy Night By Day Report
            AddTestData_TestPlan_TC_252609();//Validate Sold Out Night Analysis
            AddTestData_TestPlan_TC_252610();//Validate Cancellation Report

            AddTestData_TestPlan_TC_266463();//Validate Upon selecting Cancel user landed on Monthly Pickup page
            AddTestData_TestPlan_TC_266464();//Verify Change Password functionality will not be successful when Current password is incorrect
            AddTestData_TestPlan_TC_266466();//Verify Change Password functionality will not be successful when New and Confirm password are not matching
            AddTestData_TestPlan_TC_266467();//Verify Change Password functionality will not be successful when entered detail is not meeting the Password requirement criteria
            AddTestData_TestPlan_TC_266468();//Verify Change Password functionality will be successful when entered detail met Password requirements

            AddTestData_TestPlan_TC_252810();//Validate the Market-> Market Report
            AddTestData_TestPlan_TC_271064();// Verify only the help that belongs to the product gets displayed in suggestion when searched for a text
            AddTestData_TestPlan_TC_271065();// Verify the contact us functionality
            AddTestData_TestPlan_TC_271066();//Verify only the help that belongs to the product gets displayed in suggestion when searched for a text
            AddTestData_TestPlan_TC_252811();//Validate the Market-> Market Performance Report
            AddTestData_TestPlan_TC_252812();//Validate the Market->Market Trend Report
            AddTestData_TestPlan_TC_252813();//Validate the Market-> Market Segment by Day
            AddTestData_TestPlan_TC_252814();//Validate the Market-> Market Segment by Day Summary
            AddTestData_TestPlan_TC_252815();//Validate the Market-> Annual Market Analysis by Month
            AddTestData_TestPlan_TC_252816();//Validate the Market-> Rate Code Analysis Report
            AddTestData_TestPlan_TC_252817();//Validate the Market-> Market Analysis by Year
            AddTestData_TestPlan_TC_252818();//Validate the Market-> Monthly Market Segment Report
            AddTestData_TestPlan_TC_252819();//Validate the Market-> Rate Code Trend Report (RHBI)

            AddTestData_TestPlan_TC_252838();//Validate the Pace and Forecast Report and the Forecast Budget Upload

            AddTestData_TestPlan_TC_252841();// Validate the Source Market Analysis
            AddTestData_TestPlan_TC_252842();//Validate the Source Market Trend
            AddTestData_TestPlan_TC_252843();//Validate the Province and State Analysis
            AddTestData_TestPlan_TC_252844();//Validate the United States Trend (RHBI)

            AddTestData_TestPlan_TC_252847();// Validate the Room type Analysis
            AddTestData_TestPlan_TC_252848();// Validate the Room Type and Up Grade Statistics
            AddTestData_TestPlan_TC_252849();// Validate Booked Room Materialization
            AddTestData_TestPlan_TC_252850();// Validate the Detailed Room Type Availability

            AddTestData_TestPlan_TC_265412();
            AddTestData_TestPlan_TC_265413();
            AddTestData_TestPlan_TC_265421();
            AddTestData_TestPlan_TC_265422();
            AddTestData_TestPlan_TC_265418();
            AddTestData_TestPlan_TC_265361();
            AddTestData_TestPlan_TC_265367();
            AddTestData_TestPlan_TC_265368();
            AddTestData_TestPlan_TC_265380();
            AddTestData_TestPlan_TC_265385();
            AddTestData_TestPlan_TC_265386();
            AddTestData_TestPlan_TC_265396();
            AddTestData_TestPlan_TC_265397();
            AddTestData_TestPlan_TC_282043();
            AddTestData_TestPlan_TC_265431();
            AddTestData_TestPlan_TC_265427();
            AddTestData_TestPlan_TC_265426();
            AddTestData_TestPlan_TC_265424();
            AddTestData_TestPlan_TC_265415();

            AddTestData_TestPlan_TC_252852();//Validate the Annual Trends Analysis
            AddTestData_TestPlan_TC_252853();//Validate the Daily Analysis
            AddTestData_TestPlan_TC_252854();//Validate the Day of Week Statistics
            AddTestData_TestPlan_TC_252855();//Validate the Day of Week Analysis
            AddTestData_TestPlan_TC_252856();//Validate the Monthly Summary (RHBI)
            AddTestData_TestPlan_TC_252857();//Validate the Daily Analysis with per Data

            AddTestData_TestPlan_TC_253358();//Validate the OTB Comparison By Segment
            AddTestData_TestPlan_TC_253359();//Validate the Daily Pickup
            AddTestData_TestPlan_TC_253360();//Validate the Revenue by Room Product
            AddTestData_TestPlan_TC_253361();//Validate the Pickup by Market Segment
            AddTestData_TestPlan_TC_253362();//Validate the OTB Comparison for All Segments
            AddTestData_TestPlan_TC_253363();//Validate the OTB vs Budget by Segment
            AddTestData_TestPlan_TC_253364();//Validate the OTB vs Forecast by Segment
            AddTestData_TestPlan_TC_280393();//Validate the OTB vs Forecast by Segment

            AddTestData_TestPlan_TC_252870();//Verify the Access log
            AddTestData_TestPlan_TC_252871();//Verify the Corporate Portfolio
            AddTestData_TestPlan_TC_252877();//Verify attempting to create a new user with an existing email or userid should fail
            AddTestData_TestPlan_TC_252879();//No duplicate Parent name is allowed and a warning displays
            AddTestData_TestPlan_TC_252894();//Verify the user access report
            AddTestData_TestPlan_TC_252878();//A user with Property Admin role should only see a list of hotels that he/she was given access to

            AddTestData_TestPlan_TC_252860();//Validate the Best Available Rate Contribution
            AddTestData_TestPlan_TC_252861();//Validate the Total Revenue Analysis

            AddTestData_Post_Deployment_Test_TC_283456();
            AddTestData_Post_Deployment_Test_TC_283457();
            AddTestData_Post_Deployment_Test_TC_283458();
            AddTestData_Post_Deployment_Test_TC_283459();
            AddTestData_Post_Deployment_Test_TC_283460();
            AddTestData_Post_Deployment_Test_TC_283461();
            AddTestData_Post_Deployment_Test_TC_283468();
            AddTestData_Post_Deployment_Test_TC_283469();
            AddTestData_Post_Deployment_Test_TC_283470();
            AddTestData_Post_Deployment_Test_TC_283471();
            AddTestData_Post_Deployment_Test_TC_283472();
            AddTestData_Post_Deployment_Test_TC_283475();


            AddTestData_TestPlan_TC_252648();//Validate Monthly Pickup Report
            AddTestData_TestPlan_TC_252649();//Validate the Hotel->Hotel Dashboard
            AddTestData_TestPlan_TC_252650();//Validate the Business Source -> Agent Dashboard
            AddTestData_TestPlan_TC_252651();//Validate the Business Source -> Company Dashboard
            AddTestData_TestPlan_TC_252652();//Validate the Business Source -> Company Dashboard
            AddTestData_TestPlan_TC_252653();//Validate the Business Source -> Company Dashboard
            AddTestData_TestPlan_TC_252654();//Validate the Booking Trends -> Pace Dashboard
            AddTestData_TestPlan_TC_252655();//Validate the Channel -> Channel Dashboard
            AddTestData_TestPlan_TC_252656();//Validate the Room Type -> Room Type Dashboard

            AddTestData_TestPlan_TC_252831();//Validate the Channel Report
            AddTestData_TestPlan_TC_252832();//Validate the Channel Trend Report
            AddTestData_TestPlan_TC_252833();//Validate the Daily Channel by Room Type


            AddTestData_TestPlan_TC_265408();
            AddTestData_TestPlan_TC_265401();
            AddTestData_TestPlan_TC_265402();
            AddTestData_TestPlan_TC_265404();

            AddTestData_TestPlan_TC_252552();// Verify the Role Maintenance only lists the roles that are available to the Tenant you logged in as
            AddTestData_TestPlan_TC_252554();//Verify Subscription Support
            AddTestData_TestPlan_TC_254239();//Business Unit - Verify the addition deletion and modification of Business Unit group
            AddTestData_TestPlan_TC_253552();//Verify the Sorting and filter functonality
            AddTestData_TestPlan_TC_252553();//Verify logged in user have access only to those reports that are accessible for the Role you logged in as

            AddTestData_TestPlan_TC_265416();
            AddTestData_TestPlan_TC_265417();

            AddTestData_TestPlan_TC_279701();
            AddTestData_TestPlan_TC_279700();
            AddTestData_TestPlan_TC_279699();
            AddTestData_TestPlan_TC_279698();
            AddTestData_TestPlan_TC_279697();
            AddTestData_TestPlan_TC_279696();

            AddTestData_TestPlan_TC_290742();//Verify the Cancel and close icon functionality in Create New Report popup
            AddTestData_TestPlan_TC_290745();//Verify full screen functionality
            AddTestData_TestPlan_TC_290743();//Verify the Create Report fails when Report name is empty
            AddTestData_TestPlan_TC_290744();//Verify the Create Report fails when Report name is less than 3 characters
            AddTestData_TestPlan_TC_290751();//Verify the Cancel and close icon functionality in Rename Report popup
            AddTestData_TestPlan_TC_290739();//Verify the Create functionality
            AddTestData_TestPlan_TC_290752();//Verify the Rename functionality with out entering Report name
            AddTestData_TestPlan_TC_290753();//Verify the Rename functionality by entering report name less than 3 characters
            AddTestData_TestPlan_TC_290757();//Verify the Copy Report functionality
            AddTestData_TestPlan_TC_290754();//Verify the Rename functionality

            AddTestData_TestPlan_TC_269887();//Market Report when comparison year is 1 at hotel Level
            AddTestData_TestPlan_TC_269888();//Validate the Market->Market Report when comparison year is 2 at hotel Level
            AddTestData_TestPlan_TC_269889();//Validate the Market->Market Report when comparison year is 3 at hotel Level
            AddTestData_TestPlan_TC_269890();//Validate the Market->Market Report when comparison year is 1 at hotel Level and DOW filter
            AddTestData_TestPlan_TC_269891();//Validate the Market->Market Report when comparison year is 1 at Portfolio Level and  filter
            AddTestData_TestPlan_TC_269892();//Validate the Market->Market Report Current year data

            AddTestData_TestPlan_TC_279694();//Validate Pace and Forecast Report Current year data
            AddTestData_TestPlan_TC_279691();//Validate Pace and Forecast Report when comparison year is 3 at hotel Level
            AddTestData_TestPlan_TC_279690();//Validate Pace and Forecast Report when comparison year is 2 at hotel Level
            AddTestData_TestPlan_TC_279689();//Validate Pace and Forecast Report when comparison year is 1 at hotel Level
        }

            
        private static void AddTestData_TestPlan_TC_253360()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253360", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253360", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253360", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253360", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253360", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253360", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253360", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253360", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253360", "1", "TRUE", "startDate", "11/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253360", "1", "TRUE", "enddate", "11/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253360", "1", "TRUE", "As_Of_Date", "11/20/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253360", "1", "TRUE", "reportName", "Revenue By Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253360", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 11/01/2020 - 11/30/2020; As of: 11/20/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253360", "1", "TRUE", "parameter1", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253360", "1", "TRUE", "parameter1_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253360", "1", "TRUE", "Total_TTL", "29130");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253360", "1", "TRUE", "Hotel_Name_stay", "Hotel: Atlantis, The Palm for dates: 7/1/2020 - 7/31/2020; As of: 7/15/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253360", "1", "TRUE", "parameter2", "Room Product ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253360", "1", "TRUE", "parameter2_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253360", "1", "TRUE", "Total_ALL_Room_Left", "2798");
        }
        private static void AddTestData_TestPlan_TC_253359()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253359", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253359", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253359", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253359", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253359", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253359", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253359", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253359", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253359", "1", "TRUE", "startDate", "7/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253359", "1", "TRUE", "enddate", "7/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253359", "1", "TRUE", "As_Of_Date", "7/15/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253359", "1", "TRUE", "reportName", "Daily Pick Up Report");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253359", "1", "TRUE", "reportName_stay", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 07/01/2020 - 07/31/2020; As of: 07/15/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253359", "1", "TRUE", "parameter1", "Channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253359", "1", "TRUE", "parameter1_value", " Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253359", "1", "TRUE", "Total_Pickup_STLY", "387");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253359", "1", "TRUE", "Hotel_Name_stay", "Hotel: Atlantis, The Palm for dates: 7/1/2020 - 7/31/2020; As of: 7/15/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253359", "1", "TRUE", "parameter2", "Room Product ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253359", "1", "TRUE", "parameter2_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253359", "1", "TRUE", "Pickup", "3118");
        }
        private static void AddTestData_TestPlan_TC_253358()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253358", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253358", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253358", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253358", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253358", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253358", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253358", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253358", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253358", "1", "TRUE", "startDate", "10/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253358", "1", "TRUE", "enddate", "10/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253358", "1", "TRUE", "As_Of_Date", "11/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253358", "1", "TRUE", "reportName", "OTB Comparison by Segment");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253358", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 10/01/2020 - 10/31/2020; As of: 11/01/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253358", "1", "TRUE", "parameter1", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253358", "1", "TRUE", "parameter1_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253358", "1", "TRUE", "Total_DIR19", "4093");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253358", "1", "TRUE", "Hotel_Name_stay", "Hotel: Atlantis, The Palm for dates: 10/01/2020 - 10/31/2020; As of: 11/01/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253358", "1", "TRUE", "parameter2", "Room Product ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253358", "1", "TRUE", "parameter2_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253358", "1", "TRUE", "Total_19", "7936");
        }

        private static void AddTestData_SmokeTest_TC_251470()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_251470", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_251470", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_251470", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_251470", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_251470", "1", "TRUE", "environment", "QA");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_251470", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_251470", "2", "TRUE", "client", "D Rock");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_251470", "3", "TRUE", "client", "Benchmark Hospitality");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_251470", "1", "TRUE", "url", "https://devrhbi.revintel.co");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_251470", "2", "TRUE", "url", "https://devbi.revintel.co");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_251470", "3", "TRUE", "url", "https://devcloud.revintel.co");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_251470", "1", "TRUE", "revIntel_RHBI", "https://devrhbi.revintel.co/revintel.aspx");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_251470", "1", "TRUE", "revIntel_BI", "https://devbi.revintel.co/SSOLanding.aspx");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_251470", "1", "TRUE", "revIntel_Cloud", "https://devcloud.revintel.co/SSOLanding.aspx");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_251470", "1", "TRUE", "username", "rshende@delaplex.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_251470", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_251470", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_251470", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_251470", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_251470", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_251470", "2", "TRUE", "client", "Filament");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_251470", "3", "TRUE", "client", "Benchmark Hospitality");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_251470", "1", "TRUE", "url", "https://rhbi.revintel.co");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_251470", "2", "TRUE", "url", "https://bi.revintel.co");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_251470", "3", "TRUE", "url", "https://cloud.revintel.co");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_251470", "1", "TRUE", "revIntel_RHBI", "https://rhbi.revintel.co/revintel.aspx");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_251470", "1", "TRUE", "revIntel_BI", "https://bi.revintel.co/SSOLanding.aspx");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_251470", "1", "TRUE", "revIntel_Cloud", "https://cloud.revintel.co/SSOLanding.aspx");
        }

        private static void AddTestData_TestPlan_TC_252718()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252718", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252718", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252718", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252718", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252718", "1", "TRUE", "Portfolio", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252718", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252718", "1", "TRUE", "Currency", "USD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252718", "1", "TRUE", "hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252718", "1", "TRUE", "startDate", "1/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252718", "1", "TRUE", "enddate", "1/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252718", "1", "TRUE", "reportName", "Agent Analysis");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252718", "1", "TRUE", "PortfolioName_date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 01/01/2020 - 01/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252718", "1", "TRUE", "Difference_Revenue", "2490558.11374718");
        }
        private static void AddTestData_TestPlan_TC_256851()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256851", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256851", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256851", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256851", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256851", "1", "TRUE", "hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256851", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256851", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256851", "1", "TRUE", "Parameter", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256851", "1", "TRUE", "Parameter_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256851", "1", "TRUE", "startDate", "4/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256851", "1", "TRUE", "enddate", "4/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256851", "1", "TRUE", "reportName", "Agent Analysis");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256851", "1", "TRUE", "reportdate_Hotel", "Hotel: Atlantis, The Palm for dates: 04/01/2020 - 04/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256851", "1", "TRUE", "Total_Revenue", "846260.54882392");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_256851", "7", "TRUE", "Column", "Nbr Resv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_256851", "8", "TRUE", "Column", "Rooms Sold");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_256851", "9", "TRUE", "Column", "Mix%");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_256851", "10", "TRUE", "Column", "ADR");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_256851", "11", "TRUE", "Column", "Revenue");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_256851", "12", "TRUE", "Column", "Nbr Resv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_256851", "13", "TRUE", "Column", "Rooms Sold");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_256851", "14", "TRUE", "Column", "Mix %");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_256851", "15", "TRUE", "Column", "ADR");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_256851", "16", "TRUE", "Column", "Revenue");

        }

        private static void AddTestData_TestPlan_TC_256852()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256852", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256852", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256852", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256852", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256852", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256852", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256852", "1", "TRUE", "parameter1", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256852", "1", "TRUE", "parameter1_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256852", "1", "TRUE", "parameter2", "Channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256852", "1", "TRUE", "parameter2_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256852", "1", "TRUE", "hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256852", "1", "TRUE", "startDate", "1/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256852", "1", "TRUE", "enddate", "1/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256852", "1", "TRUE", "reportName", "Agent Analysis");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256852", "1", "TRUE", "reportdate_Hotel", "Hotel: Atlantis, The Palm for dates: 01/01/2020 - 01/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256852", "1", "TRUE", "Total_Revenue", "332030.7299111");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256852", "7", "TRUE", "Column", "Nbr Resv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256852", "8", "TRUE", "Column", "Rooms Sold");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256852", "9", "TRUE", "Column", "Mix%");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256852", "10", "TRUE", "Column", "ADR");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_256852", "11", "TRUE", "Column", "Revenue");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_256852", "12", "TRUE", "Column", "Nbr Resv");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_256852", "13", "TRUE", "Column", "Rooms Sold");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_256852", "14", "TRUE", "Column", "Mix %");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_256852", "15", "TRUE", "Column", "ADR");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_256852", "16", "TRUE", "Column", "Revenue");

        }
        private static void AddTestData_SmokeTest_TC_252390()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252390", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252390", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252390", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252390", "1", "TRUE", "environment", "Automation");
        }
        private static void AddTestData_SmokeTest_TC_252482()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252482", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252482", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252482", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252482", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252482", "1", "TRUE", "url", "https://devauto.revintel.co/revintel.aspx");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252482", "1", "TRUE", "url1", "https://help.cendyn.com/hc/en-us/categories/360004357731-revintel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252482", "1", "TRUE", "url2", "https://help.cendyn.com/hc/en-us/sections/360010838372-General-Use");
        }

        private static void AddTestData_SmokeTest_TC_252494()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252494", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252494", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252494", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252494", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252494", "1", "TRUE", "user_ID", "rshende");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252494", "1", "TRUE", "email", "rshende@delaplex.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252494", "1", "TRUE", "firstName", "ruchi");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252494", "1", "TRUE", "lastName", "shende");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252494", "1", "TRUE", "url", "https://devauto.revintel.co/revintel.aspx");
        }

        private static void AddTestData_SmokeTest_TC_252496()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252496", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252496", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252496", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252496", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252496", "1", "TRUE", "Portfolio_Name", "One & Only RM & TP");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252496", "1", "TRUE", "validation", "Portfolio One & Only RM & TP already exists!");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252496", "1", "TRUE", "url", "https://devauto.revintel.co/revintel.aspx");
        }
        private static void AddTestData_SmokeTest_TC_252394()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252394", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252394", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252394", "1", "TRUE", "Environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252394", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252394", "1", "TRUE", "startDate", "4/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252394", "1", "TRUE", "enddate", "4/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252394", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252394", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252394", "1", "TRUE", "url", "https://devauto.revintel.co/revintel.aspx");           
        }

        private static void AddTestData_SmokeTest_TC_252401()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252401", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252401", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252401", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252401", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251469", "TC_252401", "1", "TRUE", "url", "https://devauto.revintel.co/revintel.aspx");
        }

        private static void AddTestData_TestPlan_TC_252719()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252719", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252719", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252719", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252719", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252719", "1", "TRUE", "hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252719", "1", "TRUE", "Portfolio", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252719", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252719", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252719", "1", "TRUE", "startDate", "5/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252719", "1", "TRUE", "enddate", "5/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252719", "1", "TRUE", "Parameter1", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252719", "1", "TRUE", "Parameter1_Value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252719", "1", "TRUE", "Parameter2", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252719", "1", "TRUE", "Parameter2_Value", "Room");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252719", "1", "TRUE", "reportName", "Agent Summary");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252719", "1", "TRUE", "HotelName_Date", "Hotel: Atlantis, The Palm for dates: 05/01/2020 - 05/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252719", "1", "TRUE", "Portfolio_Name", "Agent Summary");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252719", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 05/01/2020 - 05/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252719", "1", "TRUE", "Hotel_Name", "Agent Summary");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252719", "1", "TRUE", "Hotel_Name_Date", "Hotel: Atlantis, The Palm for dates: 05/01/2020 - 05/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252719", "1", "TRUE", "Room_Sold", "242");


            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_252719", "4", "TRUE", "Column", "Rooms Sold");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_252719", "5", "TRUE", "Column", "Mix%");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_252719", "6", "TRUE", "Column", "ADR");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_252719", "7", "TRUE", "Column", "Room Revenue");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_252719", "8", "TRUE", "Column", "Food Revenue");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_252719", "9", "TRUE", "Column", "Other Revenue");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_252719", "10", "TRUE", "Column", "Rooms Sold");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_252719", "11", "TRUE", "Column", "Mix%");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_252719", "12", "TRUE", "Column", "ADR");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_252719", "13", "TRUE", "Column", "Room Revenue");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_252719", "15", "TRUE", "Food_Revenue", "Food Revenue");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_252719", "16", "TRUE", "Other_Revenue", "Other Revenue");
        }
        private static void AddTestData_TestPlan_TC_252720()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252720", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252720", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252720", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252720", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252720", "1", "TRUE", "hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252720", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252720", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252720", "1", "TRUE", "Portfolio", "One & Only All - CT, SG, RR, RM, TP, PL, WV, NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252720", "1", "TRUE", "startDate", "5/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252720", "1", "TRUE", "enddate", "5/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252720", "1", "TRUE", "parameter1", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252720", "1", "TRUE", "parameter1_Value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252720", "1", "TRUE", "booking_startDate", "1/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252720", "1", "TRUE", "booking_enddate", "4/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252720", "1", "TRUE", "reportName", "Agent Room Type Analysis");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252720", "1", "TRUE", "HotelName_Date", "Hotel: Atlantis, The Palm for dates: 05/01/2020 - 05/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252720", "1", "TRUE", "Revenue_Difference", "-5931109.29840062");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252720", "1", "TRUE", "PortolioName_date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 05/01/2020 - 05/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252720", "1", "TRUE", "Revenue_CurrentYear", "34841237.9527");
        }
        private static void AddTestData_TestPlan_TC_252721()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252721", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252721", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252721", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252721", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252721", "1", "TRUE", "Portfolio", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252721", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252721", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252721", "1", "TRUE", "Year", "2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252721", "1", "TRUE", "hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252721", "1", "TRUE", "Parameter", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252721", "1", "TRUE", "parameter_Value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252721", "1", "TRUE", "reportName", "Annual Agent Analysis by Month");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252721", "1", "TRUE", "reportdate_Hotel", "Hotel: Atlantis, The Palm for year: 2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252721", "1", "TRUE", "Total_Rooms", "302421");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252721", "1", "TRUE", "Report_PortfolioName_date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for year: 2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252721", "1", "TRUE", "Total_ADR", "496.5852");

        }
        private static void AddTestData_TestPlan_TC_252722()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252722", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252722", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252722", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252722", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252722", "1", "TRUE", "hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252722", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252722", "1", "TRUE", "startDate", "6/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252722", "1", "TRUE", "enddate", "6/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252722", "1", "TRUE", "Parameter1", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252722", "1", "TRUE", "Parameter1_Value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252722", "1", "TRUE", "Parameter2", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252722", "1", "TRUE", "Parameter2_Value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252722", "1", "TRUE", "reportName", "Company Analysis");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252722", "1", "TRUE", "Portfoliodate_Hotel", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 06/01/2020 - 06/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252722", "1", "TRUE", "nbr_Resv", "332");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252722", "1", "TRUE", "hotel_Name_Date", "Hotel: Atlantis, The Palm for dates: 06/01/2020 - 06/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252722", "1", "TRUE", "PriorYear_Revenue", "3298.51403232");
        }

        private static void AddTestData_TestPlan_TC_252723()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252723", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252723", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252723", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252723", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252723", "1", "TRUE", "hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252723", "1", "TRUE", "RoomProduct_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252723", "1", "TRUE", "reportName", "Annual Company Analysis by Month");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252723", "1", "TRUE", "reportdate_Hotel", "Hotel: Atlantis, The Palm for year: 2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252723", "1", "TRUE", "total_ADR", "170.401141262222");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252723", "1", "TRUE", "booking_startDate", "6/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252723", "1", "TRUE", "booking_enddate", "6/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252723", "1", "TRUE", "Portfolio_report_heading", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for year: 2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252723", "1", "TRUE", "Revenue", "608.1732176");


        }
        private static void AddTestData_TestPlan_TC_252724()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252724", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252724", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252724", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252724", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252724", "1", "TRUE", "reportName", "Company Summary");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252724", "1", "TRUE", "Portfoliodate_name", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 06/01/2020 - 06/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252724", "1", "TRUE", "startDate", "6/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252724", "1", "TRUE", "enddate", "6/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_252724", "1", "TRUE", "Room_Revenue", "23667.49305454");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252724", "1", "TRUE", "Hoteldate_name", "Hotel: Atlantis, The Palm for dates: 06/01/2020 - 06/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_251459", "TC_252724", "1", "TRUE", "other_Revenue", "2567.04716828");


        }

        private static void AddTestData_TestPlan_TC_252725()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252725", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252725", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252725", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252725", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252725", "1", "TRUE", "hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252725", "1", "TRUE", "startDate", "4/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252725", "1", "TRUE", "enddate", "4/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252725", "1", "TRUE", "reportName", "Parent Company Analysis");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252725", "1", "TRUE", "reportdate", "Hotel: Atlantis, The Palm for dates: 04/01/2020 - 04/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252725", "1", "TRUE", "Rooms_Sold", "-1814");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252725", "1", "TRUE", "reportName_Portfolio", "Parent Company Analysis");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252725", "1", "TRUE", "Portfolio_NameDate", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 04/01/2020 - 04/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252725", "1", "TRUE", "reportName_Hotel", "Parent Company Analysis");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252725", "1", "TRUE", "reportdate_Hotel", "Hotel: Atlantis, The Palm for dates: 04/01/2020 - 04/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252725", "1", "TRUE", "Nbr_Resv", "145");
        }

        private static void AddTestData_TestPlan_TC_252726()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252726", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252726", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252726", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252726", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252726", "1", "TRUE", "hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252726", "1", "TRUE", "startDate", "1/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252726", "1", "TRUE", "enddate", "1/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252726", "1", "TRUE", "Portfolio", "One & Only All - CT, SG, RR, RM, TP, PL, WV, NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252726", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252726", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252726", "1", "TRUE", "Parameter1", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252726", "1", "TRUE", "Parameter1_Value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252726", "1", "TRUE", "Parameter2", "channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252726", "1", "TRUE", "Parameter2_Value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252726", "1", "TRUE", "reportName", "Parent Travel Agent Analysis");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252726", "1", "TRUE", "reportdate", "Hotel: Atlantis, The Palm for dates: 01/01/2020 - 01/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252726", "1", "TRUE", "Rooms_Sold", "28181");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252726", "1", "TRUE", "reportName_Portfolio", "Parent Travel Agent Analysis");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252726", "1", "TRUE", "Portfolio_NameDate", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 01/01/2020 - 01/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252726", "1", "TRUE", "reportName_Hotel", "Parent Travel Agent Analysis");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252726", "1", "TRUE", "reportdate_Hotel", "Hotel: Atlantis, The Palm for dates: 01/01/2020 - 01/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252726", "1", "TRUE", "priorYear_ADR", "488.368639023178");
        }
        private static void AddTestData_TestPlan_TC_252728()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252728", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252728", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252728", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252728", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252728", "1", "TRUE", "hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252728", "1", "TRUE", "startDate", "2/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252728", "1", "TRUE", "enddate", "2/29/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252728", "1", "TRUE", "Portfolio", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252728", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252728", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252728", "1", "TRUE", "Parameter1", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252728", "1", "TRUE", "Parameter1_Value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252728", "1", "TRUE", "Parameter2", "Memberships");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252728", "1", "TRUE", "Parameter2_Value", "ALL");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252728", "1", "TRUE", "reportName", "Company Period Summary");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252728", "1", "TRUE", "reportdate", "Hotel: Atlantis, The Palm for dates: 02/01/2020 - 02/29/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252728", "1", "TRUE", "Rooms_Sold", "29");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252728", "1", "TRUE", "reportName_Portfolio", "Company Period Summary");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252728", "1", "TRUE", "Portfolio_NameDate", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 02/01/2020 - 02/29/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252728", "1", "TRUE", "reportName_Hotel", "Company Period Summary");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252728", "1", "TRUE", "reportdate_Hotel", "Hotel: Atlantis, The Palm for dates: 02/01/2020 - 02/29/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252728", "1", "TRUE", "currentYear_FoodRev", "2220.9082153");
        }

        private static void AddTestData_TestPlan_TC_252727()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252727", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252727", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252727", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252727", "1", "TRUE", "hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252727", "1", "TRUE", "startDate", "12/1/2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252727", "1", "TRUE", "enddate", "12/31/2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252727", "1", "TRUE", "Portfolio", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252727", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252727", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252727", "1", "TRUE", "Parameter1", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252727", "1", "TRUE", "Parameter1_Value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252727", "1", "TRUE", "Parameter2", "channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252727", "1", "TRUE", "Parameter2_Value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252727", "1", "TRUE", "reportName", "Agent Period Summary");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252727", "1", "TRUE", "reportdate", "Hotel: Atlantis, The Palm for dates: 12/01/2019 - 12/31/2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252727", "1", "TRUE", "Rooms_Sold", "12");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252727", "1", "TRUE", "reportName_Portfolio", "Agent Period Summary");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252727", "1", "TRUE", "Portfolio_NameDate", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 12/01/2019 - 12/31/2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252727", "1", "TRUE", "CurrentRoomSold_Portfolio", "8");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252727", "1", "TRUE", "reportName_Hotel", "Agent Period Summary");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252727", "1", "TRUE", "reportdate_Hotel", "Hotel: Atlantis, The Palm for dates: 12/01/2019 - 12/31/2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252727", "1", "TRUE", "currentYear_FoodRev", "2287.57929944");
        }

        private static void AddTestData_TestPlan_TC_252729()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "1", "TRUE", "hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "1", "TRUE", "environment", "Automation");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "1", "TRUE", "Portfolio", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "1", "TRUE", "Parameter1", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "1", "TRUE", "Parameter1_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "1", "TRUE", "Parameter2", "Channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "1", "TRUE", "Parameter2_value", "Hotel Direct");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "1", "TRUE", "startDate", "3/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "1", "TRUE", "enddate", "3/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "1", "TRUE", "Compare_startDate", "2/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "1", "TRUE", "Compare_enddate", "2/29/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "1", "TRUE", "reportName", "Agent Trend Report");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "1", "TRUE", "reportdate", "Hotel: Atlantis, The Palm for dates: 03/01/2020 - 03/31/2020 compared to: 02/01/2020 - 02/29/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "1", "TRUE", "Prior_ADR", "409.837828722963");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "1", "TRUE", "reportName_Portfolio", "Agent Trend Report");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "1", "TRUE", "Portfolio_NameDate", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 03/01/2020 - 03/31/2020 compared to: 02/01/2020 - 02/29/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "1", "TRUE", "Agent_Production", "Agent Production");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "1", "TRUE", "reportdate_Hotel", "Hotel: Atlantis, The Palm for dates: 03/01/2020 - 03/31/2020 compared to: 02/01/2020 - 02/29/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "1", "TRUE", "Compair_Revenue", "38960.28427786");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "6", "TRUE", "Column1", "Mix%");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "7", "TRUE", "Column", "Rooms");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "8", "TRUE", "Column", "ADR");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "9", "TRUE", "Column", "Revenue");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "11", "TRUE", "Column", "Mix%");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "12", "TRUE", "Column", "Rooms");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "13", "TRUE", "Column", "ADR");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "14", "TRUE", "Column", "Revenue");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "16", "TRUE", "Column", "Mix Pts");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "17", "TRUE", "Column", "Room %");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "18", "TRUE", "Column", "ADR %");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_252729", "19", "TRUE", "Column", "Rev %");

        }

        private static void AddTestData_TestPlan_TC_264418()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "1", "TRUE", "hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_264418", "1", "TRUE", "environment", "Automation");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "1", "TRUE", "Portfolio", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "1", "TRUE", "Parameter1", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "1", "TRUE", "Parameter1_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "1", "TRUE", "Parameter2", "Channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "1", "TRUE", "Parameter2_value", "Hotel Direct");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "1", "TRUE", "startDate", "5/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "1", "TRUE", "enddate", "5/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "1", "TRUE", "Compare_startDate", "3/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "1", "TRUE", "Compare_enddate", "3/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "1", "TRUE", "reportName", "Company Trend Report");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "1", "TRUE", "reportdate", "Hotel: Atlantis, The Palm for dates: 05/01/2020 - 05/31/2020 compared to: 03/01/2020 - 03/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "1", "TRUE", "Prior_ADR", "409.837828722963");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "1", "TRUE", "reportName_Portfolio", "Company Trend Report");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "1", "TRUE", "Portfolio_NameDate", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 05/01/2020 - 05/31/2020 compared to: 03/01/2020 - 03/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "1", "TRUE", "Company_Production", "Company Production");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "1", "TRUE", "Revenue", "4188.1602");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "5", "TRUE", "Column1", "Mix%");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "6", "TRUE", "Column1", "Mix%");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "7", "TRUE", "Column", "Rooms");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "8", "TRUE", "Column", "ADR");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "9", "TRUE", "Column", "Revenue");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "11", "TRUE", "Column", "Mix%");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "12", "TRUE", "Column", "Rooms");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "13", "TRUE", "Column", "ADR");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "14", "TRUE", "Column", "Revenue");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "16", "TRUE", "Column", "Mix Pts");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "17", "TRUE", "Column", "Room %");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "18", "TRUE", "Column", "ADR %");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252700", "TC_264418", "19", "TRUE", "Column", "Rev %");

        }

        private static void AddTestData_TestPlan_TC_253349()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253349", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253349", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253349", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253349", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253349", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253349", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253349", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253349", "1", "TRUE", "startDate", "7/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253349", "1", "TRUE", "enddate", "7/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253349", "1", "TRUE", "reportName", "Portfolio Report");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253349", "1", "TRUE", "reportName_stay", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 07/01/2020 - 07/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253349", "1", "TRUE", "parameter1", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253349", "1", "TRUE", "parameter1_value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253349", "1", "TRUE", "Budget_total_ADR", "291.711206642204");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253349", "1", "TRUE", "parameter2", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253349", "1", "TRUE", "parameter2_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253349", "1", "TRUE", "PriorYear_Total_Revenue", "169621.643312");

        }

        private static void AddTestData_TestPlan_TC_253350()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253350", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253350", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253350", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253350", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253350", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253350", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253350", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253350", "1", "TRUE", "startDate", "5/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253350", "1", "TRUE", "enddate", "5/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253350", "1", "TRUE", "reportName", "Agent By Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253350", "1", "TRUE", "reportName_stay", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 05/01/2020 - 05/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253350", "1", "TRUE", "parameter1", "channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253350", "1", "TRUE", "parameter1_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253350", "1", "TRUE", "total_Rooms", "62");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253350", "1", "TRUE", "parameter2", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253350", "1", "TRUE", "parameter2_value", "Room");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253350", "4", "TRUE", "Column", "Total");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253350", "5", "TRUE", "Column", "O&O Le Saint Geran");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253350", "6", "TRUE", "Column", "O&O Reethi Rah");

        }

        private static void AddTestData_TestPlan_TC_253351()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253351", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253351", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253351", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253351", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253351", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253351", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253351", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253351", "1", "TRUE", "startDate", "6/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253351", "1", "TRUE", "enddate", "6/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253351", "1", "TRUE", "reportName", "Channel By Hotel Report");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253351", "1", "TRUE", "reportName_stay", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 06/01/2020 - 06/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253351", "1", "TRUE", "parameter1", "channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253351", "1", "TRUE", "parameter1_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253351", "1", "TRUE", "total_Occ", "0.01071060762");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253351", "1", "TRUE", "parameter2", "Membership");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253351", "1", "TRUE", "parameter2_value", "All");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253351", "1", "TRUE", "total_Rooms", "2051");
        }

        private static void AddTestData_TestPlan_TC_253352()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253352", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253352", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253352", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253352", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253352", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253352", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253352", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253352", "1", "TRUE", "startDate", "8/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253352", "1", "TRUE", "enddate", "8/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253352", "1", "TRUE", "reportName", "Company By Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253352", "1", "TRUE", "reportName_stay", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 08/01/2020 - 08/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253352", "1", "TRUE", "parameter1", "Booking Start Date");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253352", "1", "TRUE", "parameter1_startdate", "7/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253352", "1", "TRUE", "parameter1_enddate", "7/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253352", "1", "TRUE", "total_ADR", "723.903122897576");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253352", "1", "TRUE", "parameter2", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253352", "1", "TRUE", "parameter2_value", "Corporate");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253352", "1", "TRUE", "total_Revenue", "4707.292264");
        }

        private static void AddTestData_TestPlan_TC_253353()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253353", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253353", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253353", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253353", "1", "TRUE", "Currency", "USD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253353", "1", "TRUE", "environment", "DEV");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253353", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253353", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253353", "1", "TRUE", "startDate", "4/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253353", "1", "TRUE", "enddate", "4/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253353", "1", "TRUE", "reportName", "Market By Hotel Report");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253353", "1", "TRUE", "reportName_stay", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 04/01/2020 - 04/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253353", "1", "TRUE", "parameter1", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253353", "1", "TRUE", "parameter1_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253353", "1", "TRUE", "total_Revenue", "698.05812");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253353", "1", "TRUE", "parameter2", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253353", "1", "TRUE", "parameter2_value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253353", "1", "TRUE", "total_ADR", "0");
        }

        private static void AddTestData_TestPlan_TC_253354()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253354", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253354", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253354", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253354", "1", "TRUE", "Currency", "USD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253354", "1", "TRUE", "environment", "DEV");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253354", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253354", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253354", "1", "TRUE", "startDate", "2/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253354", "1", "TRUE", "enddate", "2/29/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253354", "1", "TRUE", "reportName", "Province and State By Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253354", "1", "TRUE", "reportName_stay", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 02/01/2020 - 02/29/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253354", "1", "TRUE", "parameter1", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253354", "1", "TRUE", "parameter1_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253354", "1", "TRUE", "total_Room", "1846");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253354", "1", "TRUE", "parameter2", "Channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253354", "1", "TRUE", "parameter2_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253354", "1", "TRUE", "total_Revenue", "218084.9961");
        }

        private static void AddTestData_TestPlan_TC_253355()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253355", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253355", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253355", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253355", "1", "TRUE", "Currency", "USD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253355", "1", "TRUE", "environment", "DEV");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253355", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253355", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253355", "1", "TRUE", "startDate", "1/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253355", "1", "TRUE", "enddate", "1/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253355", "1", "TRUE", "reportName", "Room Type By Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253355", "1", "TRUE", "reportName_stay", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 01/01/2020 - 01/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253355", "1", "TRUE", "parameter1", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253355", "1", "TRUE", "parameter1_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253355", "1", "TRUE", "total_ADR", "1853.80548279392");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253355", "1", "TRUE", "parameter2", "Channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253355", "1", "TRUE", "parameter2_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253355", "1", "TRUE", "total_Revenue", "204793.491596");
        }

        private static void AddTestData_TestPlan_TC_253356()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253356", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253356", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253356", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253356", "1", "TRUE", "Currency", "USD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253356", "1", "TRUE", "environment", "DEV");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253356", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253356", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253356", "1", "TRUE", "startDate", "8/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253356", "1", "TRUE", "enddate", "8/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253356", "1", "TRUE", "reportName", "Source Market By Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253356", "1", "TRUE", "reportName_stay", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 08/01/2020 - 08/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253356", "1", "TRUE", "parameter1", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253356", "1", "TRUE", "parameter1_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253356", "1", "TRUE", "total_ADR", "640.538161808508");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253356", "1", "TRUE", "parameter2", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253356", "1", "TRUE", "parameter2_value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253348", "TC_253356", "1", "TRUE", "total_Revenue", "5746.42516");
        }

        private static void AddTestData_TestPlan_TC_252597()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252597", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252597", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252597", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252597", "1", "TRUE", "Currency", "USD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252597", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252597", "1", "TRUE", "hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252597", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252597", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252597", "1", "TRUE", "startDate", "7/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252597", "1", "TRUE", "enddate", "7/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252597", "1", "TRUE", "As_Of_Date", "8/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252597", "1", "TRUE", "reportName", "Pace Report");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252597", "1", "TRUE", "reportName_stay", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 07/01/2020 - 07/31/2020; As of: 08/01/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252597", "1", "TRUE", "parameter1", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252597", "1", "TRUE", "parameter1_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252597", "1", "TRUE", "total_ADR", "259.683442318841");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252597", "1", "TRUE", "Hotel_Name_stay", "Hotel: Atlantis, The Palm for dates: 07/01/2020 - 07/31/2020; As of: 08/01/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252597", "1", "TRUE", "parameter2", "Channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252597", "1", "TRUE", "parameter2_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252597", "1", "TRUE", "total_Revenue", "273.25324653372");
        }

        private static void AddTestData_TestPlan_TC_252598()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252598", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252598", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252598", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252598", "1", "TRUE", "Currency", "USD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252598", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252598", "1", "TRUE", "hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252598", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252598", "1", "TRUE", "As_Of_Date", "7/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252598", "1", "TRUE", "Start_Month", "June 2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252598", "1", "TRUE", "reportName", "Pace Trend");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252598", "1", "TRUE", "Hotel_Name_stay", "Hotel: Atlantis, The Palm for Month: June 2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252598", "1", "TRUE", "total_ADR", "361.658162923043");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252598", "1", "TRUE", "Portfolio_Name_stay", "Hotel: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for Month: June 2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252598", "1", "TRUE", "total_Revenue", "7702174.0109");
        }

        private static void AddTestData_TestPlan_TC_252599()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252599", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252599", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252599", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252599", "1", "TRUE", "Currency", "USD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252599", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252599", "1", "TRUE", "hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252599", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252599", "1", "TRUE", "As_Of_Date", "7/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252599", "1", "TRUE", "Start_Month", "June 2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252599", "1", "TRUE", "reportName", "Daily Pace and Pickup Analysis");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252599", "1", "TRUE", "Hotel_Name_stay", "Hotel: Atlantis, The Palm for month: June 2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252599", "1", "TRUE", "total_ADR", "218.00678395909");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252599", "1", "TRUE", "Portfolio_Name_stay", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for month: June 2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252599", "1", "TRUE", "total_Revenue", "7629576.9211");
        }

        private static void AddTestData_TestPlan_TC_252600()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252600", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252600", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252600", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252600", "1", "TRUE", "Currency", "USD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252600", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252600", "1", "TRUE", "hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252600", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252600", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252600", "1", "TRUE", "startDate", "7/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252600", "1", "TRUE", "enddate", "7/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252600", "1", "TRUE", "As_Of_Date", "8/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252600", "1", "TRUE", "reportName", "Pace and Pickup Analysis");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252600", "1", "TRUE", "Hotel_Name_stay", "Hotel: Atlantis, The Palm for period: 07/01/2020 - 07/31/2020; As of: 08/01/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252600", "1", "TRUE", "parameter1", "Channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252600", "1", "TRUE", "parameter1_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252600", "1", "TRUE", "OCC", "626.088341550523");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252600", "1", "TRUE", "Portfolio_Name_stay", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for period: 07/01/2020 - 07/31/2020; As of: 08/01/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252600", "1", "TRUE", "parameter2", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252600", "1", "TRUE", "parameter2_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252600", "1", "TRUE", "total_Revenue", "1952027.4482");
        }

        private static void AddTestData_TestPlan_TC_252601()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252601", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252601", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252601", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252601", "1", "TRUE", "Currency", "USD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252601", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252601", "1", "TRUE", "hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252601", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252601", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252601", "1", "TRUE", "startDate", "3/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252601", "1", "TRUE", "enddate", "3/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252601", "1", "TRUE", "As_Of_Date", "4/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252601", "1", "TRUE", "reportName", "Rate Code Pace Report");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252601", "1", "TRUE", "Hotel_Name_stay", "Hotel: Atlantis, The Palm for dates: 03/01/2020 - 03/31/2020; As of: 04/01/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252601", "1", "TRUE", "parameter1", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252601", "1", "TRUE", "parameter1_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252601", "1", "TRUE", "Rooms_sold", "8675");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252601", "1", "TRUE", "Portfolio_Name_stay", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 03/01/2020 - 03/31/2020; As of: 04/01/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252601", "1", "TRUE", "parameter2", "Channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252601", "1", "TRUE", "parameter2_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252601", "1", "TRUE", "total_Revenue", "3370981.144");
        }

        private static void AddTestData_TestPlan_TC_252602()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252602", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252602", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252602", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252602", "1", "TRUE", "Currency", "USD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252602", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252602", "1", "TRUE", "hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252602", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252602", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252602", "1", "TRUE", "startDate", "9/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252602", "1", "TRUE", "enddate", "9/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252602", "1", "TRUE", "As_Of_Date", "8/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252602", "1", "TRUE", "reportName", "Channel By Room Type Pace");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252602", "1", "TRUE", "Hotel_Name_stay", "Hotel: Atlantis, The Palm for dates: 09/01/2020 - 09/30/2020; As of: 08/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252602", "1", "TRUE", "parameter1", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252602", "1", "TRUE", "parameter1_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252602", "1", "TRUE", "Total_ADR", "486.206939319972");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252602", "1", "TRUE", "Portfolio_Name_stay", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 09/01/2020 - 09/30/2020; As of: 08/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252602", "1", "TRUE", "parameter2", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252602", "1", "TRUE", "parameter2_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252602", "1", "TRUE", "total_Rooms_sold", "5807");
        }

        private static void AddTestData_TestPlan_TC_252603()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252603", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252603", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252603", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252603", "1", "TRUE", "Currency", "USD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252603", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252603", "1", "TRUE", "hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252603", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252603", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252603", "1", "TRUE", "startDate", "2/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252603", "1", "TRUE", "enddate", "2/29/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252603", "1", "TRUE", "As_Of_Date", "3/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252603", "1", "TRUE", "reportName", "Channel Pace Analysis");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252603", "1", "TRUE", "Hotel_Name_stay", "Hotel: Atlantis, The Palm for dates: 02/01/2020 - 02/29/2020; As of: 03/01/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252603", "1", "TRUE", "parameter1", "channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252603", "1", "TRUE", "parameter1_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252603", "1", "TRUE", "Total_ADR", "1344.02617474057");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252603", "1", "TRUE", "Portfolio_Name_stay", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 02/01/2020 - 02/29/2020; As of: 03/01/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252603", "1", "TRUE", "parameter2", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252603", "1", "TRUE", "parameter2_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252603", "1", "TRUE", "total_Room_Sold", "4828");
        }

        private static void AddTestData_TestPlan_TC_252604()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252604", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252604", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252604", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252604", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252604", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252604", "1", "TRUE", "hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252604", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252604", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252604", "1", "TRUE", "startDate", "2/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252604", "1", "TRUE", "enddate", "2/29/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252604", "1", "TRUE", "Pickup_startDate", "2/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252604", "1", "TRUE", "Pickup_enddate", "2/15/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252604", "1", "TRUE", "reportName", "Pickup by Day");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252604", "1", "TRUE", "Hotel_Name_stay", "Hotel: Atlantis, The Palm for dates: 02/01/2020 - 02/29/2020 Pickup Between: 02/01/2020 - 02/15/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252604", "1", "TRUE", "parameter1", "channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252604", "1", "TRUE", "parameter1_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252604", "1", "TRUE", "Total_Pickup", "2440975.93357619");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252604", "1", "TRUE", "Portfolio_Name_stay", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 02/01/2020 - 02/29/2020 Pickup Between: 02/01/2020 - 02/15/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252604", "1", "TRUE", "parameter2", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252604", "1", "TRUE", "parameter2_value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252604", "1", "TRUE", "total_ADR_of_Rooms_Picked_Up", "496.052084684615");
        }

        private static void AddTestData_TestPlan_TC_252643()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252643", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252643", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252643", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252643", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252643", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252643", "1", "TRUE", "hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252643", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252643", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252643", "1", "TRUE", "reportName", "Annual Pickup by Day");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252643", "1", "TRUE", "Hotel_Name_stay", "Hotel: Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252643", "1", "TRUE", "parameter1", "channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252643", "1", "TRUE", "parameter1_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252643", "1", "TRUE", "Today_Budget_Dec2020", "42565");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252643", "1", "TRUE", "Portfolio_Name_stay", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252643", "1", "TRUE", "parameter2", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252643", "1", "TRUE", "parameter2_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252643", "1", "TRUE", "Today_Budget", "42565");
        }

        private static void AddTestData_TestPlan_TC_252644()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252644", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252644", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252644", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252644", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252644", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252644", "1", "TRUE", "hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252644", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252644", "1", "TRUE", "startDate", "1/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252644", "1", "TRUE", "enddate", "1/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252644", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252644", "1", "TRUE", "reportName", "Length of Stay Report");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252644", "1", "TRUE", "Hotel_Name_stay", "Hotel: Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252644", "1", "TRUE", "parameter1", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252644", "1", "TRUE", "parameter1_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252644", "1", "TRUE", "Today_Budget_Dec2020", "42565");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252644", "1", "TRUE", "Portfolio_Name_stay", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252644", "1", "TRUE", "parameter2", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252644", "1", "TRUE", "parameter2_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252644", "1", "TRUE", "Today_Budget", "685.534810166117");
        }

        private static void AddTestData_TestPlan_TC_252645()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252645", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252645", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252645", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252645", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252645", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252645", "1", "TRUE", "hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252645", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252645", "1", "TRUE", "startDate", "4/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252645", "1", "TRUE", "enddate", "4/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252645", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252645", "1", "TRUE", "reportName", "Rooms Lead Time");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252645", "1", "TRUE", "Hotel_Name_stay", "Hotel: Atlantis, The Palm for dates: 04/01/2020 - 04/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252645", "1", "TRUE", "parameter1", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252645", "1", "TRUE", "parameter1_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252645", "1", "TRUE", "Reservation_Detail", "Reservations made for arrivals between 04/01/2020 and 04/30/2020 had an average lead time of 26 days");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252645", "1", "TRUE", "Portfolio_Name_stay", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 04/01/2020 - 04/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252645", "1", "TRUE", "parameter2", "Channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252645", "1", "TRUE", "parameter2_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252645", "1", "TRUE", "Today_Budget", "42565");
        }
        private static void AddTestData_TestPlan_TC_252605()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252605", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252605", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252605", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252605", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252605", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252605", "1", "TRUE", "hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252605", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252605", "1", "TRUE", "startDate", "1/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252605", "1", "TRUE", "enddate", "1/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252605", "1", "TRUE", "test_Pickup_startDate", "10/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252605", "1", "TRUE", "Pickup_startDate", "1/15/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252605", "1", "TRUE", "Pickup_enddate", "1/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252605", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252605", "1", "TRUE", "reportName", "Pickup By Day Detailed");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252605", "1", "TRUE", "Hotel_Name_stay", "Hotel: Atlantis, The Palm for dates: 01/01/2020 - 01/31/2020 Pickup Between: 01/15/2020 - 01/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252605", "1", "TRUE", "parameter1", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252605", "1", "TRUE", "parameter1_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252605", "1", "TRUE", "Pickup_Total_Room", "584");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252605", "1", "TRUE", "Portfolio_Name_stay", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 01/01/2020 - 01/31/2020 Pickup Between: 01/15/2020 - 01/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252605", "1", "TRUE", "parameter2", "market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252605", "1", "TRUE", "parameter2_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252605", "1", "TRUE", "Start_total_ADR", "825.48715693718");
        }

        private static void AddTestData_TestPlan_TC_252606()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252606", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252606", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252606", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252606", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252606", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252606", "1", "TRUE", "hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252606", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252606", "1", "TRUE", "Pickup_startDate", "1/1/2020"); 
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252606", "1", "TRUE", "Pickup_enddate", "1/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252606", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252606", "1", "TRUE", "reportName", "Monthly Pickup and Budget Variance");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252606", "1", "TRUE", "Hotel_Name_stay", "Hotel: Atlantis, The Palm for dates: 01/01/2020 - 12/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252606", "1", "TRUE", "Portfolio_Name_stay", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 01/01/2020 - 12/31/2020");

        }

        private static void AddTestData_TestPlan_TC_252607()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252607", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252607", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252607", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252607", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252607", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252607", "1", "TRUE", "hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252607", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252607", "1", "TRUE", "startDate", "8/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252607", "1", "TRUE", "enddate", "8/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252607", "1", "TRUE", "BookingStartDate", "6/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252607", "1", "TRUE", "BookingEndDate", "6/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252607", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252607", "1", "TRUE", "reportName", "Production Patterns");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252607", "1", "TRUE", "Hotel_Name_stay", "Hotel: Atlantis, The Palm for dates: 08/01/2020 - 08/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252607", "1", "TRUE", "Current_Room", "59");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252607", "1", "TRUE", "Portfolio_Name_stay", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 08/01/2020 - 08/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252607", "1", "TRUE", "parameter2", "channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252607", "1", "TRUE", "parameter2_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252607", "1", "TRUE", "Prior_ADR", "361.875012863131");
        }
        private static void AddTestData_TestPlan_TC_252608()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252608", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252608", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252608", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252608", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252608", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252608", "1", "TRUE", "hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252608", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252608", "1", "TRUE", "startDate", "11/1/2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252608", "1", "TRUE", "enddate", "11/30/2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252608", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252608", "1", "TRUE", "reportName", "High Occupancy Night By Day");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252608", "1", "TRUE", "parameter1", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252608", "1", "TRUE", "parameter1_value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252608", "1", "TRUE", "Hotel_Name_stay", "Hotel: Atlantis, The Palm for dates: 11/01/2019 - 11/30/2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252608", "1", "TRUE", "Total_Revenue", "3945.71521333333");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252608", "1", "TRUE", "Portfolio_Name_stay", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 11/01/2019 - 11/30/2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252608", "1", "TRUE", "parameter2", "channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252608", "1", "TRUE", "parameter2_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252608", "1", "TRUE", "Food_Revenue", "488.293855706667");
        }

        private static void AddTestData_TestPlan_TC_252609()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252609", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252609", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252609", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252609", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252609", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252609", "1", "TRUE", "hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252609", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252609", "1", "TRUE", "startDate", "02/01/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252609", "1", "TRUE", "enddate", "02/29/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252609", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252609", "1", "TRUE", "reportName", "Sold Out Night Analysis");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252609", "1", "TRUE", "parameter1", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252609", "1", "TRUE", "parameter1_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252609", "1", "TRUE", "Hotel_Name_stay", "Hotel: Atlantis, The Palm for dates: 02/01/2020 - 02/29/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252609", "1", "TRUE", "Room_Sold_out_Night", "568");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252609", "1", "TRUE", "Portfolio_Name_stay", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 02/01/2020 - 02/29/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252609", "1", "TRUE", "parameter2", "channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252609", "1", "TRUE", "parameter2_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252609", "1", "TRUE", "total_Revenue", "610660.378574847");
        }

        private static void AddTestData_TestPlan_TC_252610()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252610", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252610", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252610", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252610", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252610", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252610", "1", "TRUE", "hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252610", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252610", "1", "TRUE", "startDate", "12/1/2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252610", "1", "TRUE", "enddate", "12/31/2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252610", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252610", "1", "TRUE", "reportName", "Cancellation Report");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252610", "1", "TRUE", "parameter1", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252610", "1", "TRUE", "parameter1_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252610", "1", "TRUE", "Hotel_Name_stay", "Hotel: Atlantis, The Palm for dates: 12/01/2019 - 12/31/2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252610", "1", "TRUE", "Room_Sold_out_Night", "594");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252610", "1", "TRUE", "Portfolio_Name_stay", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 12/01/2019 - 12/31/2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252610", "1", "TRUE", "parameter2", "channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252610", "1", "TRUE", "parameter2_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252578", "TC_252610", "1", "TRUE", "total_Revenue", "69564.9253640026");
        }

        private static void AddTestData_TestPlan_TC_266463()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266463", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266463", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266463", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266463", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266463", "1", "TRUE", "url", "https://devauto.revintel.co/revintel.aspx");
        }

        private static void AddTestData_TestPlan_TC_266464()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266464", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266464", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266464", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266464", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266464", "1", "TRUE", "Current_Password", "Cendyn111$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266464", "1", "TRUE", "New_Password", "Cendyn333$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266464", "1", "TRUE", "Confirm_Password", "Cendyn333$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266464", "1", "TRUE", "url", "https://devauto.revintel.co/revintel.aspx");
        }

        private static void AddTestData_TestPlan_TC_266466()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266466", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266466", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266466", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266466", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266466", "1", "TRUE", "Current_Password", "Cendyn222$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266466", "1", "TRUE", "New_Password", "Cendyn333$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266466", "1", "TRUE", "Confirm_Password", "Cendyn321$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266466", "1", "TRUE", "url", "https://devauto.revintel.co/revintel.aspx");
        }

        private static void AddTestData_TestPlan_TC_266467()
        {

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266467", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266467", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266467", "1", "TRUE", "client", "Kerzner");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266467", "1", "TRUE", "Current_Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266467", "1", "TRUE", "New_Password", "Cen13$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266467", "1", "TRUE", "Confirm_Password", "Cen13$");
            
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266467", "2", "TRUE", "Current_Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266467", "2", "TRUE", "New_Password", "CENdyn");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266467", "2", "TRUE", "Confirm_Password", "CENdyn");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266467", "3", "TRUE", "Current_Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266467", "3", "TRUE", "New_Password", "CENDYN876$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266467", "3", "TRUE", "Confirm_Password", "CENDYN876$");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266467", "4", "TRUE", "Current_Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266467", "4", "TRUE", "New_Password", "cendyn876$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266467", "4", "TRUE", "Confirm_Password", "cendyn876$");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266467", "5", "TRUE", "Current_Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266467", "5", "TRUE", "New_Password", "rshende@delaplex.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266467", "5", "TRUE", "Confirm_Password", "rshende@delaplex.com");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266467", "1", "TRUE", "url", "https://devauto.revintel.co/revintel.aspx");
        }

        private static void AddTestData_TestPlan_TC_266468()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266468", "1", "TRUE", "username", "rshende@delaplex.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266468", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266468", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266468", "1", "TRUE", "url", "https://devauto.revintel.co/revintel.aspx");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266468", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266468", "1", "TRUE", "New_Set_Password", "Cendyn111$");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266468", "1", "TRUE", "Current_Password_1", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266468", "1", "TRUE", "New_Password_1", "Cendyn111$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266468", "1", "TRUE", "Confirm_Password_1", "Cendyn111$");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266468", "2", "TRUE", "Current_Password", "Cendyn111$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266468", "2", "TRUE", "New_Password", "Cendyn222$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266468", "2", "TRUE", "Confirm_Password", "Cendyn222$");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266468", "3", "TRUE", "Current_Password", "Cendyn222$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266468", "3", "TRUE", "New_Password", "Cendyn333$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266468", "3", "TRUE", "Confirm_Password", "Cendyn333$");


            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266468", "4", "TRUE", "Current_Password", "Cendyn333$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266468", "4", "TRUE", "New_Password", "Cendyn444$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266468", "4", "TRUE", "Confirm_Password", "Cendyn444$");


            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266468", "5", "TRUE", "Current_Password", "Cendyn444$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266468", "5", "TRUE", "New_Password", "Cendyn555$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266468", "5", "TRUE", "Confirm_Password", "Cendyn555$");


            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266468", "6", "TRUE", "Current_Password", "Cendyn555$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266468", "6", "TRUE", "New_Password", "Cendyn666$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_266462", "TC_266468", "6", "TRUE", "Confirm_Password", "Cendyn666$");


            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TC_266462", "TC_266468", "7", "TRUE", "Current_Password", "Cendyn666$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TC_266462", "TC_266468", "7", "TRUE", "New_Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TC_266462", "TC_266468", "7", "TRUE", "Confirm_Password", "Cendyn123$");
        }

        private static void AddTestData_TestPlan_TC_252810()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252810", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252810", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252810", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252810", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252810", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252810", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252810", "1", "TRUE", "startDate", "09/01/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252810", "1", "TRUE", "enddate", "09/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252810", "1", "TRUE", "reportName", "Market Report");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252810", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252810", "1", "TRUE", "parameter1", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252810", "1", "TRUE", "parameter1_value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252810", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 09/01/2020 - 09/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252810", "1", "TRUE", "Current_Year_Room_Sold", "64");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252810", "1", "TRUE", "parameter2", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252810", "1", "TRUE", "parameter2_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252810", "1", "TRUE", "Comparison_Year_ADR", "472.122531687205");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252810", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
        }


        private static void AddTestData_TestPlan_TC_252811()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252811", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252811", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252811", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252811", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252811", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252811", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252811", "1", "TRUE", "startDate", "9/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252811", "1", "TRUE", "enddate", "9/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252811", "1", "TRUE", "Compare_Start_Date", "9/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252811", "1", "TRUE", "Compare_End_Date", "9/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252811", "1", "TRUE", "reportName", "Market Performance");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252811", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252811", "1", "TRUE", "parameter1", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252811", "1", "TRUE", "parameter1_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252811", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 09/01/2020 - 09/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252811", "1", "TRUE", "OTB_Revenue", "1679183.88441018");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252811", "1", "TRUE", "parameter2", "Channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252811", "1", "TRUE", "parameter2_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252811", "1", "TRUE", "Forecast_Total_Revenue", "4206113.33172916");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252811", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
        }

        private static void AddTestData_TestPlan_TC_252812()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252812", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252812", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252812", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252812", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252812", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252812", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252812", "1", "TRUE", "startDate", "9/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252812", "1", "TRUE", "enddate", "9/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252812", "1", "TRUE", "Compare_Start_Date", "9/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252812", "1", "TRUE", "Compare_End_Date", "9/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252812", "1", "TRUE", "reportName", "Market Trend Report");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252812", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252812", "1", "TRUE", "parameter1", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252812", "1", "TRUE", "parameter1_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252812", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 09/01/2020 - 09/30/2020 compared to: 09/01/2020 - 09/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252812", "1", "TRUE", "Subject_No_Rate", "305");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252812", "1", "TRUE", "parameter2", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252812", "1", "TRUE", "parameter2_value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252812", "1", "TRUE", "Third_Party_Website_Room", "18");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252812", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
        }

        private static void AddTestData_TestPlan_TC_252813()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252813", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252813", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252813", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252813", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252813", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252813", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252813", "1", "TRUE", "startDate", "5/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252813", "1", "TRUE", "enddate", "5/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252813", "1", "TRUE", "reportName", "Market Segment by Day");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252813", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252813", "1", "TRUE", "parameter1", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252813", "1", "TRUE", "parameter1_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252813", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 05/01/2020 - 05/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252813", "1", "TRUE", "Total_Room", "76");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252813", "1", "TRUE", "parameter2", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252813", "1", "TRUE", "parameter2_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252813", "1", "TRUE", "Total_Other_Revenue", "111");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252813", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
        }

        private static void AddTestData_TestPlan_TC_252814()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252814", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252814", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252814", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252814", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252814", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252814", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252814", "1", "TRUE", "startDate", "1/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252814", "1", "TRUE", "enddate", "1/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252814", "1", "TRUE", "reportName", "Market Segment by Day Summary");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252814", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252814", "1", "TRUE", "parameter1", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252814", "1", "TRUE", "parameter1_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252814", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 01/01/2020 - 01/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252814", "1", "TRUE", "Total_Room", "222");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252814", "1", "TRUE", "parameter2", "Channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252814", "1", "TRUE", "parameter2_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252814", "1", "TRUE", "Total_Other_Revenue", "78055.47051926");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252814", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
        }

        private static void AddTestData_TestPlan_TC_252815()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252815", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252815", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252815", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252815", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252815", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252815", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252815", "1", "TRUE", "reportName", "Annual Market Analysis by Month");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252815", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252815", "1", "TRUE", "parameter1", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252815", "1", "TRUE", "parameter1_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252815", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for year: 2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252815", "1", "TRUE", "Total_Jan", "5045");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252815", "1", "TRUE", "parameter2", "Channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252815", "1", "TRUE", "parameter2_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252815", "1", "TRUE", "Total_Feb", "3757");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252815", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
        }

        private static void AddTestData_TestPlan_TC_252816()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252816", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252816", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252816", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252816", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252816", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252816", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252816", "1", "TRUE", "startDate", "2/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252816", "1", "TRUE", "enddate", "2/29/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252816", "1", "TRUE", "reportName", "Rate Code Analysis");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252816", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252816", "1", "TRUE", "parameter1", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252816", "1", "TRUE", "parameter1_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252816", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 02/01/2020 - 02/29/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252816", "1", "TRUE", "Current_Year_Room_Sold", "4055");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252816", "1", "TRUE", "parameter2", "Channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252816", "1", "TRUE", "parameter2_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252816", "1", "TRUE", "Comparison_Year_Total_ADR", "858.408005097386");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252816", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
        }

        private static void AddTestData_TestPlan_TC_252817()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252817", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252817", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252817", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252817", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252817", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252817", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252817", "1", "TRUE", "startDate", "7/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252817", "1", "TRUE", "enddate", "7/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252817", "1", "TRUE", "reportName", "Market Analysis by Year");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252817", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252817", "1", "TRUE", "parameter1", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252817", "1", "TRUE", "parameter1_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252817", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 07/01/2020 - 07/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252817", "1", "TRUE", "Total_Revenue", "1387.853896");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252817", "1", "TRUE", "parameter2", "Channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252817", "1", "TRUE", "parameter2_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252817", "1", "TRUE", "Total_Rooms", "6767");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252817", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
        }

        private static void AddTestData_TestPlan_TC_252818()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252818", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252818", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252818", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252818", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252818", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252818", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252818", "1", "TRUE", "startDate", "6/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252818", "1", "TRUE", "enddate", "6/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252818", "1", "TRUE", "As_Of_Date", "6/10/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252818", "1", "TRUE", "reportName", "Monthly Market Segment Report");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252818", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252818", "1", "TRUE", "parameter1", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252818", "1", "TRUE", "parameter1_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252818", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 06/01/2020 - 06/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252818", "1", "TRUE", "Total_Occupied_Rooms", "351");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252818", "1", "TRUE", "parameter2", "Channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252818", "1", "TRUE", "parameter2_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252818", "1", "TRUE", "Budget_Occupied_Rooms", "42751");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252818", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
        }

        private static void AddTestData_TestPlan_TC_252819()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252819", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252819", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252819", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252819", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252819", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252819", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252819", "1", "TRUE", "startDate", "9/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252819", "1", "TRUE", "enddate", "9/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252819", "1", "TRUE", "Compare_Start_Date", "5/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252819", "1", "TRUE", "Compare_End_Date", "5/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252819", "1", "TRUE", "reportName", "Rate Code Trend Report");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252819", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252819", "1", "TRUE", "parameter1", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252817", "1", "TRUE", "parameter1_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252819", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 09/01/2020 - 09/30/2020 compared to: 05/01/2020 - 05/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252819", "1", "TRUE", "Subject_Room", "26");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252819", "1", "TRUE", "parameter2", "Channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252819", "1", "TRUE", "parameter2_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252819", "1", "TRUE", "Compare_ADR", "216.833185944266");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252770", "TC_252819", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
        }
        private static void AddTestData_TestPlan_TC_271064()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_274130", "TC_271064", "1", "TRUE", "Client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_274130", "TC_271064", "1", "TRUE", "SearchTest", "Revintel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_274130", "TC_271064", "2", "TRUE", "SearchTest", "Report");


        }
        private static void AddTestData_TestPlan_TC_271065()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_274130", "TC_271065", "1", "TRUE", "Client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_274130", "TC_271065", "1", "TRUE", "Name", "TestUser_");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_274130", "TC_271065", "1", "TRUE", "Subject", "Test_Subject_");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_274130", "TC_271065", "1", "TRUE", "Property", "Test_Property_");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_274130", "TC_271065", "1", "TRUE", "Service", "Revenue Services");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_274130", "TC_271065", "1", "TRUE", "Sub_Service", "Revintel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_274130", "TC_271065", "1", "TRUE", "Description", "Test_Description_");

        }
        private static void AddTestData_TestPlan_TC_271066()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_274130", "TC_271066", "1", "TRUE", "Client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_274130", "TC_271066", "1", "TRUE", "RandomText", "ABCDEF 12345%");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_274130", "TC_271066", "1", "TRUE", "Validation", "Try searching for something else.");

        }

        private static void AddTestData_TestPlan_TC_252838()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252834", "TC_252838", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252834", "TC_252838", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252834", "TC_252838", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252834", "TC_252838", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252834", "TC_252838", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252834", "TC_252838", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252834", "TC_252838", "1", "TRUE", "As_Of_Date", "6/10/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252834", "TC_252838", "1", "TRUE", "Start_Month", "June 2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252834", "TC_252838", "1", "TRUE", "reportName", "Pace and Forecast Report");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252834", "TC_252838", "1", "TRUE", "reportName_stay", "Hotel: Atlantis, The Palm for Months:");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252834", "TC_252838", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252834", "TC_252838", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 06/01/2020 - 06/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252834", "TC_252838", "1", "TRUE", "Total_Sold_ADR", "65.1727039390122");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252834", "TC_252838", "1", "TRUE", "Total_Occupied_Rooms", "27791");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252834", "TC_252838", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
        }

        private static void AddTestData_TestPlan_TC_252841()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252841", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252841", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252841", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252841", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252841", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252841", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252841", "1", "TRUE", "startDate", "9/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252841", "1", "TRUE", "enddate", "9/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252841", "1", "TRUE", "reportName", "Source Market Analysis");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252841", "1", "TRUE", "Total_Mix", "");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252841", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252841", "1", "TRUE", "parameter1", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252841", "1", "TRUE", "parameter1_value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252841", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 09/01/2020 - 09/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252841", "1", "TRUE", "Current_Year_Room_Sold", "64");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252841", "1", "TRUE", "parameter2", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252841", "1", "TRUE", "parameter2_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252841", "1", "TRUE", "Prior_Year_ADR", "472.122531687205");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252841", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
        }

        private static void AddTestData_TestPlan_TC_252842()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252842", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252842", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252842", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252842", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252842", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252842", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252842", "1", "TRUE", "startDate", "9/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252842", "1", "TRUE", "enddate", "9/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252842", "1", "TRUE", "Compare_Start_Date", "9/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252842", "1", "TRUE", "Compare_End_Date", "9/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252842", "1", "TRUE", "reportName", "Source Market Trend");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252842", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252842", "1", "TRUE", "parameter1", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252842", "1", "TRUE", "parameter1_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252842", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 09/01/2020 - 09/30/2020 compared to: 09/01/2020 - 09/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252842", "1", "TRUE", "Subject_Room", "24");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252842", "1", "TRUE", "parameter2", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252842", "1", "TRUE", "parameter2_value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252842", "1", "TRUE", "Compare_ADR", "476.965983975309");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252842", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
        }

        private static void AddTestData_TestPlan_TC_252843()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252843", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252843", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252843", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252843", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252843", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252843", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252843", "1", "TRUE", "startDate", "6/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252843", "1", "TRUE", "enddate", "6/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252843", "1", "TRUE", "reportName", "Province and State Analysis");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252843", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252843", "1", "TRUE", "parameter1", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252843", "1", "TRUE", "parameter1_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252843", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 06/01/2020 - 06/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252843", "1", "TRUE", "Current_Rooms_Sold", "239");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252843", "1", "TRUE", "Scenario2_parameter1", "Channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252843", "1", "TRUE", "_Scenario2_parameter1_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252843", "1", "TRUE", "Scenario2_parameter2", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252843", "1", "TRUE", "_Scenario2_parameter2_value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252843", "1", "TRUE", "Prior_Revenue", "125598.45724588");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252843", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
        }

        private static void AddTestData_TestPlan_TC_252844()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252844", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252844", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252844", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252844", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252844", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252844", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252844", "1", "TRUE", "startDate", "9/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252844", "1", "TRUE", "enddate", "9/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252844", "1", "TRUE", "Compare_Start_Date", "9/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252844", "1", "TRUE", "Compare_End_Date", "9/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252844", "1", "TRUE", "reportName", "United States Trend");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252844", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252844", "1", "TRUE", "parameter1", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252844", "1", "TRUE", "parameter1_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252844", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 09/01/2020 - 09/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252844", "1", "TRUE", "Subject_Room", "69");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252844", "1", "TRUE", "parameter2", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252844", "1", "TRUE", "parameter2_value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252844", "1", "TRUE", "Hotel_Stay", "Hotel: Atlantis, The Palm for dates: 09/01/2020 - 09/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252840", "TC_252844", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
        }

        private static void AddTestData_TestPlan_TC_252847()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252847", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252847", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252847", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252847", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252847", "1", "TRUE", "Business_Unit", "Hotel") ;
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252847", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252847", "1", "TRUE", "startDate", "6/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252847", "1", "TRUE", "enddate", "6/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252847", "1", "TRUE", "reportName", "Room Type Analysis");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252847", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252847", "1", "TRUE", "parameter1", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252847", "1", "TRUE", "parameter1_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252847", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 06/01/2020 - 06/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252847", "1", "TRUE", "Current_Year_Room_Sold", "317");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252847", "1", "TRUE", "parameter2", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252847", "1", "TRUE", "parameter2_value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252847", "1", "TRUE", "Prior_Revenue", "185496.57147126");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252847", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
        }

        private static void AddTestData_TestPlan_TC_252848()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252848", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252848", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252848", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252848", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252848", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252848", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252848", "1", "TRUE", "startDate", "5/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252848", "1", "TRUE", "enddate", "5/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252848", "1", "TRUE", "reportName", "Room Type and Up Grade Statistics");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252848", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252848", "1", "TRUE", "parameter1", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252848", "1", "TRUE", "parameter1_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252848", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 05/01/2020 - 05/31/2020\nHouse and Comps are excluded from this report.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252848", "1", "TRUE", "No_Rooms", "39");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252848", "1", "TRUE", "parameter2", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252848", "1", "TRUE", "parameter2_value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252848", "1", "TRUE", "Total_No_Rooms", "1548");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252848", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
        }

        private static void AddTestData_TestPlan_TC_252849()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252849", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252849", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252849", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252849", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252849", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252849", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252849", "1", "TRUE", "startDate", "2/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252849", "1", "TRUE", "enddate", "2/29/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252849", "1", "TRUE", "reportName", "Booked Room Materialization");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252849", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252849", "1", "TRUE", "parameter1", "Channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252849", "1", "TRUE", "parameter1_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252849", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 05/01/2020 - 05/31/2020\nHouse and Comps are excluded from this report.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252849", "1", "TRUE", "No_Rooms", "12132");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252849", "1", "TRUE", "parameter2", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252849", "1", "TRUE", "parameter2_value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252849", "1", "TRUE", "Total_No_Rooms", "354");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252849", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
        }

        private static void AddTestData_TestPlan_TC_252850()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252850", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252850", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252850", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252850", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252850", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252850", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252850", "1", "TRUE", "startDate", "1/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252850", "1", "TRUE", "enddate", "1/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252850", "1", "TRUE", "reportName", "Detailed Room Type Availability");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252850", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252850", "1", "TRUE", "parameter1", "Channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252850", "1", "TRUE", "parameter1_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252850", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 01/01/2020 - 01/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252850", "1", "TRUE", "Total", "613");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252850", "1", "TRUE", "parameter2", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252850", "1", "TRUE", "parameter2_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252850", "1", "TRUE", "Thr_Total", "722");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_252850", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
        }

        private static void AddTestData_TestPlan_TC_265412()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265412", "1", "TRUE", "UserName", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265412", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265412", "1", "TRUE", "Client", "Rosen");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265412", "1", "TRUE", "HotelPortfolio", "Rosen Centre");
        }
        private static void AddTestData_TestPlan_TC_265413()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265413", "1", "TRUE", "UserName", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265413", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265413", "1", "TRUE", "Client", "Rosen");
        }

        private static void AddTestData_TestPlan_TC_265421()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265421", "1", "TRUE", "UserName", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265421", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265421", "1", "TRUE", "Client", "Rosen");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265421", "1", "TRUE", "Description", "Automation Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265421", "1", "TRUE", "StartHours", "10");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265421", "1", "TRUE", "StartMinutes", "0");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265421", "1", "TRUE", "EmailTo", "sk001@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265421", "1", "TRUE", "EmailSubject", "Automation Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265421", "1", "TRUE", "Static_ValidationMessage", "As of Date cannot be greater than end date and cannot be beyond todays date");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265421", "1", "TRUE", "Relative_ValidationMessage", "As of Date cannot be greater than end date and cannot be beyond todays date.");
        }
        private static void AddTestData_TestPlan_TC_265422()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265422", "1", "TRUE", "UserName", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265422", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265422", "1", "TRUE", "Client", "Rosen");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265422", "1", "TRUE", "Description", "Automation Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265422", "1", "TRUE", "StartHours", "10");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265422", "1", "TRUE", "StartMinutes", "0");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265422", "1", "TRUE", "EmailTo", "sk001@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265422", "1", "TRUE", "EmailSubject", "Automation Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265422", "1", "TRUE", "Static_ValidationMessage", "End Date cannot be before Start Date.");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265422", "1", "TRUE", "Relative_ValidationMessage", "Invalid End Date.");
        }

        private static void AddTestData_TestPlan_TC_265418()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265418", "1", "TRUE", "UserName", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265418", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265418", "1", "TRUE", "Client", "Rosen");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265418", "1", "TRUE", "Description", "Automation Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265418", "1", "TRUE", "StartHours", "10");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265418", "1", "TRUE", "StartMinutes", "0");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265418", "1", "TRUE", "EmailTo", "sk001@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265418", "1", "TRUE", "EmailSubject", "Automation Test");
        }
        private static void AddTestData_TestPlan_TC_265361()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265361", "1", "TRUE", "UserName", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265361", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265361", "1", "TRUE", "Client", "Rosen");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265361", "1", "TRUE", "Description", "Automation Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265361", "1", "TRUE", "StartHours", "10");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265361", "1", "TRUE", "StartMinutes", "0");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265361", "1", "TRUE", "EmailTo", "sk001@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265361", "1", "TRUE", "EmailSubject", "Automation Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265361", "1", "TRUE", "HotelPortfolio", "Rosen Centre");
        }
        private static void AddTestData_TestPlan_TC_265367()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265367", "1", "TRUE", "UserName", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265367", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265367", "1", "TRUE", "Client", "Rosen");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265367", "1", "TRUE", "Description", "Automation Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265367", "1", "TRUE", "StartHours", "10");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265367", "1", "TRUE", "StartMinutes", "0");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265367", "1", "TRUE", "EmailTo", "sk001@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265367", "1", "TRUE", "EmailSubject", "Automation Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265367", "1", "TRUE", "HotelPortfolio", "Rosen Centre");
        }
        private static void AddTestData_TestPlan_TC_265368()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265368", "1", "TRUE", "UserName", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265368", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265368", "1", "TRUE", "Client", "Rosen");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265368", "1", "TRUE", "Description", "Automation Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265368", "1", "TRUE", "StartHours", "10");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265368", "1", "TRUE", "StartMinutes", "0");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265368", "1", "TRUE", "EmailTo", "sk001@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265368", "1", "TRUE", "EmailSubject", "Automation Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265368", "1", "TRUE", "HotelPortfolio", "Rosen Centre");
        }
        private static void AddTestData_TestPlan_TC_265380()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265380", "1", "TRUE", "UserName", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265380", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265380", "1", "TRUE", "Client", "Rosen");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265380", "1", "TRUE", "Description", "Automation Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265380", "1", "TRUE", "StartHours", "10");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265380", "1", "TRUE", "StartMinutes", "0");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265380", "1", "TRUE", "EmailTo", "sk001@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265380", "1", "TRUE", "EmailSubject", "Automation Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265380", "1", "TRUE", "HotelPortfolio", "Rosen Centre");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265380", "1", "TRUE", "TimeZone", "India Standard Time");
        }
        private static void AddTestData_TestPlan_TC_265385()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265385", "1", "TRUE", "UserName", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265385", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265385", "1", "TRUE", "Client", "Rosen");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265385", "1", "TRUE", "HotelPortfolio", "Rosen Centre");
        }
        private static void AddTestData_TestPlan_TC_265386()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265386", "1", "TRUE", "UserName", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265386", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265386", "1", "TRUE", "Client", "Rosen");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265386", "1", "TRUE", "HotelPortfolio", "Rosen Centre");
        }
        private static void AddTestData_TestPlan_TC_265396()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265396", "1", "TRUE", "UserName", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265396", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265396", "1", "TRUE", "Client", "Rosen");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265396", "1", "TRUE", "HotelPortfolio", "Rosen Centre");
        }
        private static void AddTestData_TestPlan_TC_265397()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265397", "1", "TRUE", "UserName", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265397", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265397", "1", "TRUE", "Client", "Rosen");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265397", "1", "TRUE", "HotelPortfolio", "Rosen Centre");
        }
        private static void AddTestData_TestPlan_TC_282043()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_282043", "1", "TRUE", "UserName", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_282043", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_282043", "1", "TRUE", "Client", "Rosen");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_282043", "1", "TRUE", "HotelPortfolio", "Rosen Centre");
        }
        private static void AddTestData_TestPlan_TC_265431()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265431", "1", "TRUE", "UserName", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265431", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265431", "1", "TRUE", "Client", "Rosen");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265431", "1", "TRUE", "HotelPortfolio", "Rosen Centre");
        }
        private static void AddTestData_TestPlan_TC_265427()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265427", "1", "TRUE", "UserName", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265427", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265427", "1", "TRUE", "Client", "Kerzner");
            
        }
        private static void AddTestData_TestPlan_TC_265426()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265426", "1", "TRUE", "UserName", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265426", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265426", "1", "TRUE", "Client", "Rosen");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265426", "1", "TRUE", "Description", "Automation Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265426", "1", "TRUE", "StartHours", "10");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265426", "1", "TRUE", "StartMinutes", "0");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265426", "1", "TRUE", "EmailTo", "sk001@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265426", "1", "TRUE", "EmailSubject", "Automation Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265426", "1", "TRUE", "HotelPortfolio", "Rosen Centre");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265426", "1", "TRUE", "TimeZone", "India Standard Time");
        }
        private static void AddTestData_TestPlan_TC_265424()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265424", "1", "TRUE", "UserName", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265424", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265424", "1", "TRUE", "Client", "Kerzner");

        }
        private static void AddTestData_TestPlan_TC_265415()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265415", "1", "TRUE", "UserName", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265415", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265415", "1", "TRUE", "Client", "Rosen");
        }
        private static void AddTestData_TestPlan_TC_252852()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252852", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252852", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252852", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252852", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252852", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252852", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252852", "1", "TRUE", "startDate", "11/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252852", "1", "TRUE", "enddate", "11/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252852", "1", "TRUE", "reportName", "Annual Trends");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252852", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252852", "1", "TRUE", "parameter1", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252852", "1", "TRUE", "parameter1_value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252852", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 11/01/2020 - 11/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252852", "1", "TRUE", "Total_2020", "74");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252852", "1", "TRUE", "parameter2", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252852", "1", "TRUE", "parameter2_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252852", "1", "TRUE", "Total_In_House_Reservation_2017", "116");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252852", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
        }

        private static void AddTestData_TestPlan_TC_252853()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252853", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252853", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252853", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252853", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252853", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252853", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252853", "1", "TRUE", "startDate", "10/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252853", "1", "TRUE", "enddate", "10/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252853", "1", "TRUE", "reportName", "Daily Analysis");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252853", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252853", "1", "TRUE", "parameter1", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252853", "1", "TRUE", "parameter1_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252853", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 10/01/2020 - 10/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252853", "1", "TRUE", "Total_Individual", "1287");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252853", "1", "TRUE", "parameter2", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252853", "1", "TRUE", "parameter2_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252853", "1", "TRUE", "Total_Vacant_Rooms", "45797");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252853", "1", "TRUE", "Column", "Occ %");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252853", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
        }

        private static void AddTestData_TestPlan_TC_252854()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252854", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252854", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252854", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252854", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252854", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252854", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252854", "1", "TRUE", "startDate", "8/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252854", "1", "TRUE", "enddate", "8/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252854", "1", "TRUE", "reportName", "Day of Week Statistics");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252854", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252854", "1", "TRUE", "parameter1", "Channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252854", "1", "TRUE", "parameter1_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252854", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 08/01/2020 - 08/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252854", "1", "TRUE", "No_Rooms", "600");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252854", "1", "TRUE", "parameter2", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252854", "1", "TRUE", "parameter2_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252854", "1", "TRUE", "Total_Room_Revenue", "2563868.59182404");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252854", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
        }

        private static void AddTestData_TestPlan_TC_252855()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252855", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252855", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252855", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252855", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252855", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252855", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252855", "1", "TRUE", "startDate", "5/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252855", "1", "TRUE", "enddate", "5/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252855", "1", "TRUE", "reportName", "Day of Week Analysis");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252855", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252855", "1", "TRUE", "parameter1", "Channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252855", "1", "TRUE", "parameter1_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252855", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 05/01/2020 - 05/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252855", "1", "TRUE", "Total_Room_CurrentYear", "3124");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252855", "1", "TRUE", "parameter2", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252855", "1", "TRUE", "parameter2_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252855", "1", "TRUE", "Total_Room_PriorYear", "12373");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252855", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
        }

        private static void AddTestData_TestPlan_TC_252856()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252856", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252856", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252856", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252856", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252856", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252856", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252856", "1", "TRUE", "startDate", "12/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252856", "1", "TRUE", "enddate", "12/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252856", "1", "TRUE", "reportName", "Monthly Summary");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252856", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252856", "1", "TRUE", "parameter1", "Channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252856", "1", "TRUE", "parameter1_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252856", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 12/01/2020 - 12/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252856", "1", "TRUE", "Total_Actuals_OTB_RevPAR", "290.493148548972");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252856", "1", "TRUE", "parameter2", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252856", "1", "TRUE", "parameter2_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252856", "1", "TRUE", "Total_Actuals_OTB_Room", "2118");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252856", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
        }

        private static void AddTestData_TestPlan_TC_252857()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252857", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252857", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252857", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252857", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252857", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252857", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252857", "1", "TRUE", "startDate", "10/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252857", "1", "TRUE", "enddate", "10/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252857", "1", "TRUE", "reportName", "Daily Analysis PerPerson");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252857", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252857", "1", "TRUE", "parameter1", "Channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252857", "1", "TRUE", "parameter1_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252857", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 10/01/2020 - 10/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252857", "1", "TRUE", "Total_Adults", "10780");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252857", "1", "TRUE", "parameter2", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252857", "1", "TRUE", "parameter2_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252857", "1", "TRUE", "Total_Occupied", "5960");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252857", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252857", "11", "TRUE", "Column", "Occ %");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252857", "12", "TRUE", "Column", "ADR");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252851", "TC_252857", "13", "TRUE", "Column", "RevPAR");
        }


        private static void AddTestData_TestPlan_TC_253361()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253361", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253361", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253361", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253361", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253361", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253361", "1", "TRUE", "hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253361", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253361", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253361", "1", "TRUE", "startDate", "2/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253361", "1", "TRUE", "enddate", "2/29/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253361", "1", "TRUE", "Pickup_startDate", "2/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253361", "1", "TRUE", "Pickup_enddate", "2/15/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253361", "1", "TRUE", "reportName", "Pickup by Market Segment");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253361", "1", "TRUE", "Hotel_Name_stay", "Hotel: Atlantis, The Palm for dates: 02/01/2020 - 02/29/2020 Pickup Between: 02/01/2020 - 02/15/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253361", "1", "TRUE", "parameter1", "channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253361", "1", "TRUE", "parameter1_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253361", "1", "TRUE", "Leisure_RMS", "2969");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253361", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 02/01/2020 - 02/29/2020 Pickup Between: 02/01/2020 - 02/15/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253361", "1", "TRUE", "parameter2", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253361", "1", "TRUE", "parameter2_value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253361", "1", "TRUE", "Direct_RMS", "404");
        }

        private static void AddTestData_TestPlan_TC_253362()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253362", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253362", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253362", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253362", "1", "TRUE", "Currency", "USD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253362", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253362", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253362", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253362", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253362", "1", "TRUE", "startDate", "11/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253362", "1", "TRUE", "enddate", "11/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253362", "1", "TRUE", "As_Of_Date", "11/15/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253362", "1", "TRUE", "reportName", "OTB Comparison for All Segments");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253362", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 11/01/2020 - 11/30/2020; As of: 11/15/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253362", "1", "TRUE", "parameter1", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253362", "1", "TRUE", "parameter1_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253362", "1", "TRUE", "Comparison_Year_ADR", "901.585760063336");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253362", "1", "TRUE", "Hotel_Name_stay", "Hotel: Atlantis, The Palm for dates: 7/1/2020 - 7/31/2020; As of: 7/15/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253362", "1", "TRUE", "parameter2", "Room Product ");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253362", "1", "TRUE", "parameter2_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253362", "1", "TRUE", "Current_Year_Budget_Room", "39617");
        }

       
        private static void AddTestData_TestPlan_TC_253363()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253363", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253363", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253363", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253363", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253363", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253363", "1", "TRUE", "hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253363", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253363", "1", "TRUE", "As_Of_Date", "1/1/2021");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253363", "1", "TRUE", "Start_Month", "December 2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253363", "1", "TRUE", "reportName", "OTB vs Budget by Segment");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253363", "1", "TRUE", "Hotel_Name_stay", "Hotel: Atlantis, The Palm for Month: June 2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253363", "1", "TRUE", "Total_Rmnts", "319.90833809262");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253363", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG For Dates Between Dec-2020 and May-2021");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253363", "1", "TRUE", "Total_ADR", "510.169519607847");
        }
        private static void AddTestData_TestPlan_TC_253364()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253364", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253364", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253364", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253364", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253364", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253364", "1", "TRUE", "hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253364", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253364", "1", "TRUE", "As_Of_Date", "1/1/2021");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253364", "1", "TRUE", "Start_Month", "December 2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253364", "1", "TRUE", "reportName", "OTB vs Forecast by Segment");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253364", "1", "TRUE", "Hotel_Name_stay", "Hotel: Atlantis, The Palm for Month: June 2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253364", "1", "TRUE", "Total_Rmnts", "2492");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253364", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253364", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG For Dates Between Dec-2020 and May-2021");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_253364", "1", "TRUE", "Third_Party_Website_ADR", "542.544580577042");
        }
        private static void AddTestData_TestPlan_TC_280393()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_280393", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_280393", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_280393", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_280393", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_280393", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_280393", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_280393", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_280393", "1", "TRUE", "startDate", "10/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_280393", "1", "TRUE", "enddate", "10/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_280393", "1", "TRUE", "As_Of_Date", "10/15/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_280393", "1", "TRUE", "reportName", "Room Type Booked vs Occupied");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_280393", "1", "TRUE", "Hotel_Name_stay", "Hotel: Atlantis, The Palm for Month: June 2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_280393", "1", "TRUE", "Total_Rmnts", "2492");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_280393", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_280393", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 10/01/2020 - 10/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_280393", "1", "TRUE", "Comparison_Year_ADR", "1072.1870538327");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_280393", "1", "TRUE", "Current_Year_Booked_RN", "5960");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_280393", "1", "TRUE", "currentyear", "Occ to Bkd %");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_280393", "1", "TRUE", "PriorYear", "Occ to Bkd %");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_280393", "1", "TRUE", "parameter1_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_280393", "1", "TRUE", "parameter2_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_280393", "1", "TRUE", "parameter1", "Channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_253357", "TC_280393", "1", "TRUE", "parameter2", "Room Product");
        }


        private static void AddTestData_TestPlan_TC_252870()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252870", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252870", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252870", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252870", "1", "TRUE", "environment", "UAT");
        }

        private static void AddTestData_TestPlan_TC_252871()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252871", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252871", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252871", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252871", "1", "TRUE", "environment", "UAT");
        }

        private static void AddTestData_TestPlan_TC_252877()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252877", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252877", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252877", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252877", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252877", "1", "TRUE", "user_ID", "k_rshende");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252877", "1", "TRUE", "user_email", "Rshende1@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252877", "1", "TRUE", "First_Name", "Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252877", "1", "TRUE", "Last_Name", "User");
        }

        private static void AddTestData_TestPlan_TC_252879()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252879", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252879", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252879", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252879", "1", "TRUE", "environment", "UAT");
        }

        private static void AddTestData_TestPlan_TC_252894()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252894", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252894", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252894", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252894", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252894", "1", "TRUE", "startDate", "11/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252894", "1", "TRUE", "enddate", "11/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252894", "1", "TRUE", "reportName", "User Access Report");
        }

        private static void AddTestData_TestPlan_TC_252878()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252878", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252878", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252878", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252864", "TC_252878", "1", "TRUE", "environment", "UAT");
        }
        

        private static void AddTestData_TestPlan_TC_252860()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252860", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252860", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252860", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252860", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252860", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252860", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252860", "1", "TRUE", "startDate", "10/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252860", "1", "TRUE", "enddate", "10/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252860", "1", "TRUE", "reportName", "Best Available Rate Contribution");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252860", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252860", "1", "TRUE", "parameter1", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252860", "1", "TRUE", "parameter1_value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252860", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 10/01/2020 - 10/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252860", "1", "TRUE", "Total_ADR_2019", "832.3523604");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252860", "1", "TRUE", "parameter2", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252860", "1", "TRUE", "parameter2_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252860", "1", "TRUE", "Total_Revenue_2020", "5571.17915");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252860", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
        }

        private static void AddTestData_TestPlan_TC_252861()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252861", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252861", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252861", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252861", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252861", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252861", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252861", "1", "TRUE", "startDate", "9/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252861", "1", "TRUE", "enddate", "9/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252861", "1", "TRUE", "reportName", "Total Revenue Analysis");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252861", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252861", "1", "TRUE", "parameter1", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252861", "1", "TRUE", "parameter1_value", "Room");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252861", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 09/01/2020 - 09/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252861", "1", "TRUE", "Total_Rooms", "1679183.88441018");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252861", "1", "TRUE", "parameter2", "Channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252861", "1", "TRUE", "parameter2_value", "Hotel Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252861", "1", "TRUE", "Total_Revenue", "0");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252858", "TC_252861", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
        }

        private static void AddTestData_TestPlan_TC_252649()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252649", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252649", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252649", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252649", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252649", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252649", "1", "TRUE", "hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252649", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252649", "1", "TRUE", "startDate", "10/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252649", "1", "TRUE", "enddate", "10/31/2020");

        }

        private static void AddTestData_TestPlan_TC_252648()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252648", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252648", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252648", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252648", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252648", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252648", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252648", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252648", "1", "TRUE", "startDate", "Jan 2021");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252648", "1", "TRUE", "enddate", "Dec 2021");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252648", "1", "TRUE", "Pickupstart", "1/1/2021");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252648", "1", "TRUE", "Pickupend", "1/31/2021");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252648", "1", "TRUE", "reportName", "Monthly Pickup and Budget Variance");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252648", "1", "TRUE", "Portfolio_Stay_dates", "Portfolio: 21C for dates: 01/01/2021 - 12/31/2021");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252648", "1", "TRUE", "Hotel_Stay_dates", "Hotel: Atlantis, The Palm for dates: 01/01/2021 - 12/31/2021");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252648", "1", "TRUE", "Total_Fcst_Var", "2017");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252648", "1", "TRUE", "Total_Bdgt_Var", "745.545314150313");
        }

        private static void AddTestData_TestPlan_TC_252650()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252650", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252650", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252650", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252650", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252650", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252650", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252650", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252650", "1", "TRUE", "startDate", "10/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252650", "1", "TRUE", "enddate", "10/31/2020");
        }

        private static void AddTestData_TestPlan_TC_252651()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252651", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252651", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252651", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252651", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252651", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252651", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252651", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252651", "1", "TRUE", "startDate", "10/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252651", "1", "TRUE", "enddate", "10/31/2020");
        }
        private static void AddTestData_TestPlan_TC_252652()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252652", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252652", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252652", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252652", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252652", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252652", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252652", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252652", "1", "TRUE", "startDate", "10/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252652", "1", "TRUE", "enddate", "10/31/2020");
        }
        private static void AddTestData_TestPlan_TC_252653()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252653", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252653", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252653", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252653", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252653", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252653", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252653", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252653", "1", "TRUE", "startDate", "10/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252653", "1", "TRUE", "enddate", "10/31/2020");
        }

        private static void AddTestData_TestPlan_TC_252654()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252654", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252654", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252654", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252654", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252654", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252654", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252654", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252654", "1", "TRUE", "startDate", "10/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252654", "1", "TRUE", "enddate", "10/31/2020");
        }

        private static void AddTestData_TestPlan_TC_252655()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252655", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252655", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252655", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252655", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252655", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252655", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252655", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252655", "1", "TRUE", "startDate", "10/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252655", "1", "TRUE", "enddate", "10/31/2020");
        }
        private static void AddTestData_TestPlan_TC_252656()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252656", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252656", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252656", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252656", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252656", "1", "TRUE", "environment", "UAT");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252656", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252656", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252656", "1", "TRUE", "startDate", "10/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_222636", "TC_252656", "1", "TRUE", "enddate", "10/31/2020");
        }

        private static void AddTestData_TestPlan_TC_252831()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252831", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252831", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252831", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252831", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252831", "1", "TRUE", "Hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252831", "1", "TRUE", "startDate", "12/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252831", "1", "TRUE", "enddate", "12/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252831", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252831", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252831", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252831", "1", "TRUE", "parameter1", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252831", "1", "TRUE", "parameter1_value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252831", "1", "TRUE", "parameter2", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252831", "1", "TRUE", "parameter2_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252831", "1", "TRUE", "reportName", "Channel Report");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252831", "1", "TRUE", "reportdate", "Hotel: Atlantis, The Palm for dates: 12/01/2020 - 12/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252831", "1", "TRUE", "Room_Night", "251");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252831", "1", "TRUE", "reportName_Portfolio", "Company Period Summary");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252831", "1", "TRUE", "Portfolio_NameDate", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 12/01/2020 - 12/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252831", "1", "TRUE", "reportName_Hotel", "Company Period Summary");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252831", "1", "TRUE", "reportdate_Hotel", "Hotel: Atlantis, The Palm for dates: 02/01/2020 - 02/29/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252831", "1", "TRUE", "Prior_Revenue", "1106078.93532314");
        }

        private static void AddTestData_TestPlan_TC_252832()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252832", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252832", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252832", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252832", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252832", "1", "TRUE", "Hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252832", "1", "TRUE", "Compare_Start_Date", "11/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252832", "1", "TRUE", "Compare_End_Date", "11/15/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252832", "1", "TRUE", "booking_startDate", "11/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252832", "1", "TRUE", "booking_enddate", "11/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252832", "1", "TRUE", "startDate", "11/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252832", "1", "TRUE", "enddate", "11/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252832", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252832", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252832", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252832", "1", "TRUE", "parameter1", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252832", "1", "TRUE", "parameter1_value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252832", "1", "TRUE", "parameter2", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252832", "1", "TRUE", "parameter2_value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252832", "1", "TRUE", "reportName", "Channel Trend Report");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252832", "1", "TRUE", "reportdate", "Hotel: Atlantis, The Palm for dates: 02/01/2020 - 02/29/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252832", "1", "TRUE", "Subject_Room", "548");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252832", "1", "TRUE", "reportName_Portfolio", "Company Period Summary");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252832", "1", "TRUE", "Portfolio_Name_Date", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 11/01/2020 - 11/30/2020 compared to: 11/01/2020 - 11/15/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252832", "1", "TRUE", "reportName_Hotel", "Company Period Summary");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252832", "1", "TRUE", "reportdate_Hotel", "Hotel: Atlantis, The Palm for dates: 11/01/2020 - 11/30/2020 compared to: 11/01/2020 - 11/15/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252832", "1", "TRUE", "Compare_ADR", "381.5539");
        }

        private static void AddTestData_TestPlan_TC_252833()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252833", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252833", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252833", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252833", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252833", "1", "TRUE", "Hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252833", "1", "TRUE", "startDate", "10/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252833", "1", "TRUE", "enddate", "10/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252833", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252833", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252833", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252833", "1", "TRUE", "Parameter1", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252833", "1", "TRUE", "Parameter1_Value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252833", "1", "TRUE", "Parameter2", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252833", "1", "TRUE", "Parameter2_Value", "Direct");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252833", "1", "TRUE", "reportName", "Daily Channel by Room Type");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252833", "1", "TRUE", "reportdate", "Hotel: Atlantis, The Palm for dates: 02/01/2020 - 02/29/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252833", "1", "TRUE", "Total_Room", "6");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252833", "1", "TRUE", "reportName_Portfolio", "Company Period Summary");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252833", "1", "TRUE", "Portfolio_NameDate", "Portfolio: One&Only All -CT,SG,RR,RM,TP,PL,WV,NG for dates: 10/01/2020 - 10/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252833", "1", "TRUE", "reportName_Hotel", "Company Period Summary");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252833", "1", "TRUE", "reportdate_Hotel", "Hotel: Atlantis, The Palm for dates: 02/01/2020 - 02/29/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252820", "TC_252833", "1", "TRUE", "Total_Revenue", "710.069438");
        }

        private static void AddTestData_Post_Deployment_Test_TC_283459()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283459", "1", "TRUE", "username", "rshende@cendyn.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283459", "1", "TRUE", "password", "Cendyn321$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283459", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283459", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283459", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283459", "2", "TRUE", "client", "Filament");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283459", "3", "TRUE", "client", "Benchmark Hospitality");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283459", "1", "TRUE", "url", "https://rhbi.revintel.co");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283459", "2", "TRUE", "url", "https://bi.revintel.co");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283459", "3", "TRUE", "url", "https://cloud.revintel.co");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283459", "1", "TRUE", "revIntel_RHBI", "https://rhbi.revintel.co/revintel.aspx");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283459", "1", "TRUE", "revIntel_BI", "https://bi.revintel.co/SSOLanding.aspx");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283459", "1", "TRUE", "revIntel_Cloud", "https://cloud.revintel.co/SSOLanding.aspx");
        }

        private static void AddTestData_Post_Deployment_Test_TC_283461()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283461", "1", "TRUE", "username", "rshende@cendyn.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283461", "1", "TRUE", "password", "Cendyn321$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283461", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283461", "1", "TRUE", "url", "https://rhbi.revintel.co/revintel.aspx");
        }

        private static void AddTestData_Post_Deployment_Test_TC_283475()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283475", "1", "TRUE", "username", "rshende@cendyn.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283475", "1", "TRUE", "password", "Cendyn321$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283475", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283475", "1", "TRUE", "url", "https://rhbi.revintel.co/revintel.aspx");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283475", "1", "TRUE", "url1", "https://help.cendyn.com/hc/en-us/categories/360004357731-revintel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283475", "1", "TRUE", "url2", "https://help.cendyn.com/hc/en-us/sections/360010838372-General-Use");
        }

        private static void AddTestData_Post_Deployment_Test_TC_283457()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283457", "1", "TRUE", "username", "rshende@cendyn.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283457", "1", "TRUE", "password", "Cendyn321$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283457", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283457", "1", "TRUE", "user_ID", "rshende");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283457", "1", "TRUE", "email", "rshende@delaplex.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283457", "1", "TRUE", "firstName", "ruchi");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283457", "1", "TRUE", "lastName", "shende");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283457", "1", "TRUE", "url", "https://rhbi.revintel.co/revintel.aspx");
        }

        private static void AddTestData_Post_Deployment_Test_TC_283456()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283456", "1", "TRUE", "username", "rshende@cendyn.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283456", "1", "TRUE", "password", "Cendyn321$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283456", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283456", "1", "TRUE", "Portfolio_Name", "One & Only RM & TP");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283456", "1", "TRUE", "validation", "Portfolio One & Only RM & TP already exists!");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283456", "1", "TRUE", "url", "https://rhbi.revintel.co/revintel.aspx");
        }

        private static void AddTestData_Post_Deployment_Test_TC_283460()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283460", "1", "TRUE", "username", "rshende@cendyn.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283460", "1", "TRUE", "password", "Cendyn321$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283460", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283460", "1", "TRUE", "startDate", "4/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283460", "1", "TRUE", "enddate", "4/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283460", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283460", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283460", "1", "TRUE", "url", "https://rhbi.revintel.co/revintel.aspx");
        }

        private static void AddTestData_Post_Deployment_Test_TC_283458()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283458", "1", "TRUE", "username", "rshende@cendyn.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283458", "1", "TRUE", "password", "Cendyn321$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283458", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283458", "1", "TRUE", "url", "https://rhbi.revintel.co/revintel.aspx");
        }

        private static void AddTestData_Post_Deployment_Test_TC_283468()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283468", "1", "TRUE", "username", "rshende@cendyn.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283468", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283468", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283468", "1", "TRUE", "url", "https://rhbi.revintel.co/revintel.aspx");
        }

        private static void AddTestData_Post_Deployment_Test_TC_283470()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283470", "1", "TRUE", "username", "rshende@cendyn.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283470", "1", "TRUE", "password", "Cendyn321$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283470", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283470", "1", "TRUE", "Current_Password", "Cendyn111$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283470", "1", "TRUE", "New_Password", "Cendyn333$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283470", "1", "TRUE", "Confirm_Password", "Cendyn333$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283470", "1", "TRUE", "url", "https://rhbi.revintel.co/revintel.aspx");
        }

        private static void AddTestData_Post_Deployment_Test_TC_283472()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283472", "1", "TRUE", "username", "rshende@cendyn.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283472", "1", "TRUE", "password", "Cendyn321$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283472", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283472", "1", "TRUE", "Current_Password", "Cendyn222$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283472", "1", "TRUE", "New_Password", "Cendyn333$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283472", "1", "TRUE", "Confirm_Password", "Cendyn321$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283472", "1", "TRUE", "url", "https://rhbi.revintel.co/revintel.aspx");
        }

        private static void AddTestData_Post_Deployment_Test_TC_283471()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283471", "1", "TRUE", "username", "rshende@cendyn.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283471", "1", "TRUE", "password", "Cendyn321$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283471", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283471", "1", "TRUE", "Current_Password_1", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283471", "1", "TRUE", "New_Password_1", "Cendyn666$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283471", "1", "TRUE", "Confirm_Password_1", "Cendyn666$");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283471", "2", "TRUE", "Current_Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283471", "2", "TRUE", "New_Password", "Cen13$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283471", "2", "TRUE", "Confirm_Password", "Cen13$");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283471", "3", "TRUE", "Current_Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283471", "3", "TRUE", "New_Password", "CENdyn");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283471", "3", "TRUE", "Confirm_Password", "CENdyn");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283471", "4", "TRUE", "Current_Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283471", "4", "TRUE", "New_Password", "CENDYN876$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283471", "4", "TRUE", "Confirm_Password", "CENDYN876$");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283471", "5", "TRUE", "Current_Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283471", "5", "TRUE", "New_Password", "cendyn876$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283471", "5", "TRUE", "Confirm_Password", "cendyn876$");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283471", "6", "TRUE", "Current_Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283471", "6", "TRUE", "New_Password", "rshende@delaplex.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283471", "6", "TRUE", "Confirm_Password", "rshende@delaplex.com");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283471", "1", "TRUE", "url", "https://rhbi.revintel.co/revintel.aspx");
        }

        private static void AddTestData_Post_Deployment_Test_TC_283469()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283469", "1", "TRUE", "username", "rshende@cendyn.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283469", "1", "TRUE", "password", "Cendyn321$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283469", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283469", "1", "TRUE", "url", "https://rhbi.revintel.co/revintel.aspx");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283469", "1", "TRUE", "New_Set_Password", "Cendyn111$");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283469", "1", "TRUE", "Current_Password_1", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283469", "1", "TRUE", "New_Password_1", "Cendyn111$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283469", "1", "TRUE", "Confirm_Password_1", "Cendyn111$");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283469", "2", "TRUE", "Current_Password", "Cendyn111$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283469", "2", "TRUE", "New_Password", "Cendyn222$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283469", "2", "TRUE", "Confirm_Password", "Cendyn222$");

            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283469", "3", "TRUE", "Current_Password", "Cendyn222$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283469", "3", "TRUE", "New_Password", "Cendyn333$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283469", "3", "TRUE", "Confirm_Password", "Cendyn333$");


            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283469", "4", "TRUE", "Current_Password", "Cendyn333$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283469", "4", "TRUE", "New_Password", "Cendyn444$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283469", "4", "TRUE", "Confirm_Password", "Cendyn444$");


            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283469", "5", "TRUE", "Current_Password", "Cendyn444$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283469", "5", "TRUE", "New_Password", "Cendyn555$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283469", "5", "TRUE", "Confirm_Password", "Cendyn555$");


            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283469", "6", "TRUE", "Current_Password", "Cendyn555$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283469", "6", "TRUE", "New_Password", "Cendyn666$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283469", "6", "TRUE", "Confirm_Password", "Cendyn666$");


            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283469", "7", "TRUE", "Current_Password", "Cendyn666$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283469", "7", "TRUE", "New_Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_278124", "TC_283469", "7", "TRUE", "Confirm_Password", "Cendyn123$");
        }

        private static void AddTestData_TestPlan_TC_265408()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265408", "1", "TRUE", "UserName", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265408", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265408", "1", "TRUE", "Client", "Rosen");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265408", "1", "TRUE", "Description", "Automation Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265408", "1", "TRUE", "StartHours", "10");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265408", "1", "TRUE", "StartMinutes", "01");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265408", "1", "TRUE", "EmailTo", "sk001@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265408", "1", "TRUE", "EmailSubject", "Automation Test");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265408", "1", "TRUE", "HotelPortfolio", "Rosen Centre");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265408", "1", "TRUE", "TimeZone", "India Standard Time");
        }
        private static void AddTestData_TestPlan_TC_265401()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265401", "1", "TRUE", "UserName", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265401", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265401", "1", "TRUE", "Client", "Sonesta");
        }
        private static void AddTestData_TestPlan_TC_265402()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265402", "1", "TRUE", "UserName", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265402", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265402", "1", "TRUE", "Client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265402", "1", "TRUE", "HotelListValue", "Hotel/Portfolio");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265402", "2", "TRUE", "HotelListValue", "Business Unit");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265402", "3", "TRUE", "HotelListValue", "Currency");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265402", "4", "TRUE", "HotelListValue", "Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265402", "5", "TRUE", "HotelListValue", "Channel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265402", "6", "TRUE", "HotelListValue", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265402", "7", "TRUE", "HotelListValue", "Room Product");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265402", "8", "TRUE", "HotelListValue", "Rate Code");

        }
        private static void AddTestData_TestPlan_TC_265404()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265404", "1", "TRUE", "UserName", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265404", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265404", "1", "TRUE", "Client", "Kerzner");
        }

        private static void AddTestData_TestPlan_TC_252552()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252523", "TC_252552", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252523", "TC_252552", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252523", "TC_252552", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252523", "TC_252552", "1", "TRUE", "client", "Kerzner");
        }

        private static void AddTestData_TestPlan_TC_252554()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252523", "TC_252554", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252523", "TC_252554", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252523", "TC_252554", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252523", "TC_252554", "1", "TRUE", "client", "Kerzner");
        }

        private static void AddTestData_TestPlan_TC_254239()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252523", "TC_254239", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252523", "TC_254239", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252523", "TC_254239", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252523", "TC_254239", "1", "TRUE", "client", "Kerzner");
        }

        private static void AddTestData_TestPlan_TC_253552()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252523", "TC_253552", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252523", "TC_253552", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252523", "TC_253552", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252523", "TC_253552", "1", "TRUE", "client", "Kerzner");
        }

        private static void AddTestData_TestPlan_TC_252553()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252523", "TC_252553", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252523", "TC_252553", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252523", "TC_252553", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252523", "TC_252553", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252523", "TC_252553", "1", "TRUE", "username2", "testaccess@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252523", "TC_252553", "1", "TRUE", "password2", "Cendyn123$");
        }

        private static void AddTestData_TestPlan_TC_265416()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265416", "1", "TRUE", "UserName", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265416", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265416", "1", "TRUE", "Client", "Rosen");
        }
        private static void AddTestData_TestPlan_TC_265417()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265417", "1", "TRUE", "UserName", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265417", "1", "TRUE", "Password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252734", "TC_265417", "1", "TRUE", "Client", "Rosen");
        }
        private static void AddTestData_TestPlan_TC_279701()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279701", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279701", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279701", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279701", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279701", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279701", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279701", "1", "TRUE", "startDate", "6/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279701", "1", "TRUE", "enddate", "6/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279701", "1", "TRUE", "reportName", "Room Type Analysis");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279701", "1", "TRUE", "Hotel", "Atlantis,The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279701", "1", "TRUE", "Current_Year", "1634915.9");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279701", "1", "TRUE", "PriorYears_1", "15101051.6");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279701", "1", "TRUE", "PriorYears_2", "14374923.6");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279701", "1", "TRUE", "PrioroYears_3", "13789584.7");
        }
        private static void AddTestData_TestPlan_TC_279700()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279700", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279700", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279700", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279700", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279700", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279700", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279700", "1", "TRUE", "startDate", "5/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279700", "1", "TRUE", "enddate", "5/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279700", "1", "TRUE", "startDate_PreviousYear", "5/1/2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279700", "1", "TRUE", "enddate_PreviousYear", "5/30/2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_279700", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_279700", "1", "TRUE", "parameter1", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_279700", "1", "TRUE", "parameter1_value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279700", "1", "TRUE", "reportName", "Room Type Analysis");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279700", "1", "TRUE", "Current_Year", "48384.6");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279700", "1", "TRUE", "PriorYears_1", "336924.5");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279700", "1", "TRUE", "Current_Year1", "336924.5");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279700", "1", "TRUE", "PriorPreviousYear", "505143.7");
        }

        private static void AddTestData_TestPlan_TC_279699()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279699", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279699", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279699", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279699", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279699", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279699", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279699", "1", "TRUE", "hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279699", "1", "TRUE", "startDate", "1/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279699", "1", "TRUE", "enddate", "1/31/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279699", "1", "TRUE", "startDate_PreviousYear", "1/1/2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279699", "1", "TRUE", "enddate_PreviousYear", "1/31/2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_279699", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_279699", "1", "TRUE", "parameter1", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_279699", "1", "TRUE", "parameter1_value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279699", "1", "TRUE", "reportName", "Room Type Analysis");
        }

        private static void AddTestData_TestPlan_TC_279698()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279698", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279698", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279698", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279698", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279698", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279698", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279698", "1", "TRUE", "hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279698", "1", "TRUE", "startDate", "4/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279698", "1", "TRUE", "enddate", "4/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279698", "1", "TRUE", "startDate_PreviousYear", "4/1/2017");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279698", "1", "TRUE", "enddate_PreviousYear", "4/30/2017");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_279698", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_279698", "1", "TRUE", "parameter1", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_279698", "1", "TRUE", "parameter1_value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279698", "1", "TRUE", "reportName", "Room Type Analysis");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279698", "1", "TRUE", "Mix_ComparisonYear", "0.023");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279698", "1", "TRUE", "Mix_CurrentYear", "0.023");
        }

        private static void AddTestData_TestPlan_TC_279697()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279697", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279697", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279697", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279697", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279697", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279697", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279697", "1", "TRUE", "hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279697", "1", "TRUE", "startDate", "4/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279697", "1", "TRUE", "enddate", "4/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279697", "1", "TRUE", "startDate_PreviousYear", "4/1/2018");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279697", "1", "TRUE", "enddate_PreviousYear", "4/30/2018");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_279697", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_279697", "1", "TRUE", "parameter1", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_279697", "1", "TRUE", "parameter1_value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279697", "1", "TRUE", "reportName", "Room Type Analysis");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279697", "1", "TRUE", "Mix_ComparisonYear", "0.904457364341085");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279697", "1", "TRUE", "Mix_CurrentYear", "0.904457364341085");
        }

        private static void AddTestData_TestPlan_TC_279696()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279696", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279696", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279696", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279696", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279696", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279696", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279696", "1", "TRUE", "Hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279696", "1", "TRUE", "startDate", "4/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279696", "1", "TRUE", "enddate", "4/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279696", "1", "TRUE", "startDate_PreviousYear", "4/1/2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279696", "1", "TRUE", "enddate_PreviousYear", "4/30/2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_279696", "1", "TRUE", "Portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_279696", "1", "TRUE", "parameter1", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_252846", "TC_279696", "1", "TRUE", "parameter1_value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292744", "TC_279696", "1", "TRUE", "reportName", "Room Type Analysis");
        }

        private static void AddTestData_TestPlan_TC_290742()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290742", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290742", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290742", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290742", "1", "TRUE", "environment", "Automation");
        }

        private static void AddTestData_TestPlan_TC_290745()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290745", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290745", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290745", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290745", "1", "TRUE", "environment", "Automation");
        }

        private static void AddTestData_TestPlan_TC_290743()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290743", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290743", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290743", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290743", "1", "TRUE", "environment", "Automation");
        }

        private static void AddTestData_TestPlan_TC_290751()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290751", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290751", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290751", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290751", "1", "TRUE", "environment", "Automation");
        }

        private static void AddTestData_TestPlan_TC_290752()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290752", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290752", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290752", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290752", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290752", "1", "TRUE", "validation", "Report Name must be at least three character long");           
        }

        private static void AddTestData_TestPlan_TC_290753()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290753", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290753", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290753", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290753", "1", "TRUE", "environment", "Automation");
        }

        private static void AddTestData_TestPlan_TC_290757()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290757", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290757", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290757", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290757", "1", "TRUE", "environment", "Automation");
        }

        private static void AddTestData_TestPlan_TC_290744()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290744", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290744", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290744", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290744", "1", "TRUE", "environment", "Automation");
        }

        private static void AddTestData_TestPlan_TC_290754()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290754", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290754", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290754", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290754", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290754", "1", "TRUE", "New_Report_Name", "Rename report pop up");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290754", "1", "TRUE", "validation1", "New user report saved!");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290754", "1", "TRUE", "New_Report_Name_Updated", "Rename report pop up - Updated");
        }

        private static void AddTestData_TestPlan_TC_290739()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290739", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290739", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290739", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290739", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290739", "1", "TRUE", "validation", "New user report saved!");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_290735", "TC_290739", "1", "TRUE", "Report_Name", "new Report");
        }

        private static void AddTestData_TestPlan_TC_269887()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269887", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269887", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269887", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269887", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269887", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269887", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269887", "1", "TRUE", "Hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269887", "1", "TRUE", "startDate", "4/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269887", "1", "TRUE", "enddate", "4/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269887", "1", "TRUE", "startDate_PreviousYear", "4/1/2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269887", "1", "TRUE", "enddate_PreviousYear", "4/30/2019");
        }

        private static void AddTestData_TestPlan_TC_269888()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269888", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269888", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269888", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269888", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269888", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269888", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269888", "1", "TRUE", "Hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269888", "1", "TRUE", "startDate", "4/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269888", "1", "TRUE", "enddate", "4/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269888", "1", "TRUE", "startDate_PreviousYear", "4/1/2018");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269888", "1", "TRUE", "enddate_PreviousYear", "4/30/2018");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269888", "1", "TRUE", "Mix_CurrentYear", "0.9");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269888", "1", "TRUE", "enddate_PreviousYear", "4/30/2018");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269888", "1", "TRUE", "Mix_CurrentYear", "0.9");
        }

        private static void AddTestData_TestPlan_TC_269889()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269889", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269889", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269889", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269889", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269889", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269889", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269889", "1", "TRUE", "hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269889", "1", "TRUE", "startDate", "6/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269889", "1", "TRUE", "enddate", "6/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269889", "1", "TRUE", "startDate_PreviousYear", "6/1/2017");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269889", "1", "TRUE", "enddate_PreviousYear", "6/30/2017");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269889", "1", "TRUE", "Mix_CurrentYear", "0.7");
            
        }

        private static void AddTestData_TestPlan_TC_269890()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269890", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269890", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269890", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269890", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269890", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269890", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269890", "1", "TRUE", "hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269890", "1", "TRUE", "startDate", "4/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269890", "1", "TRUE", "enddate", "4/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269890", "1", "TRUE", "startDate_PreviousYear", "4/1/2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269890", "1", "TRUE", "enddate_PreviousYear", "4/30/2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269890", "1", "TRUE", "parameter1", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269890", "1", "TRUE", "parameter1_value", "Africa");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269890", "1", "TRUE", "Mix_CurrentYear", "0.898148148148148");
            
        }

        private static void AddTestData_TestPlan_TC_269891()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269891", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269891", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269891", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269891", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269891", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269891", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269891", "1", "TRUE", "Hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269891", "1", "TRUE", "portfolio_value", "One&Only All -CT,SG,RR,RM,TP,PL,WV,NG");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269891", "1", "TRUE", "startDate", "4/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269891", "1", "TRUE", "enddate", "4/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269891", "1", "TRUE", "startDate_PreviousYear", "4/1/2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269891", "1", "TRUE", "enddate_PreviousYear", "4/30/2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269891", "1", "TRUE", "parameter1", "Source Market");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269891", "1", "TRUE", "parameter1_value", "Africa");
        }

        private static void AddTestData_TestPlan_TC_269892()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269892", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269892", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269892", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269892", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269892", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269892", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269892", "1", "TRUE", "hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269892", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269892", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269892", "1", "TRUE", "startDate", "6/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292758", "TC_269892", "1", "TRUE", "enddate", "6/30/2020");
        }

        private static void AddTestData_TestPlan_TC_279694()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279694", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279694", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279694", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279694", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279694", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279694", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279694", "1", "TRUE", "hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279694", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279694", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279694", "1", "TRUE", "StartMonth", "October 2021");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279694", "1", "TRUE", "As_Of_Date", "10/15/2021");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279694", "1", "TRUE", "StartMonth_PreviousYear", "October 2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279694", "1", "TRUE", "As_Of_Date_PreviousYear", "10/15/2020");
        }

        private static void AddTestData_TestPlan_TC_279691()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279691", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279691", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279691", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279691", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279691", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279691", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279691", "1", "TRUE", "hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279691", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279691", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279691", "1", "TRUE", "StartMonth", "6/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279691", "1", "TRUE", "As_Of_Date", "6/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279691", "1", "TRUE", "StartMonth_PreviousYear", "6/1/2017");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279691", "1", "TRUE", "As_Of_Date_PreviousYear", "6/30/2017");
        }

        private static void AddTestData_TestPlan_TC_279690()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279690", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279690", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279690", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279690", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279690", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279690", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279690", "1", "TRUE", "hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279690", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279690", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279690", "1", "TRUE", "Start_Month", "3/1/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279690", "1", "TRUE", "As_Of_Date", "3/30/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279690", "1", "TRUE", "StartMonth_PreviousYear", "3/1/2018");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279690", "1", "TRUE", "As_Of_Date_PreviousYear", "3/30/2018");
        }

        private static void AddTestData_TestPlan_TC_279689()
        {
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279689", "1", "TRUE", "username", "Testautomation@cendyn17.com");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279689", "1", "TRUE", "password", "Cendyn123$");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279689", "1", "TRUE", "client", "Kerzner");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279689", "1", "TRUE", "environment", "Automation");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279689", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279689", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279689", "1", "TRUE", "hotel", "Atlantis, The Palm");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279689", "1", "TRUE", "Business_Unit", "Hotel");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279689", "1", "TRUE", "Currency", "AUD");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279689", "1", "TRUE", "As_Of_Date", "1/15/2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279689", "1", "TRUE", "Start_Month", "January 2020");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279689", "1", "TRUE", "As_Of_Date_PreviousYear", "1/15/2019");
            TestDataHelper.AddRecord("ALL", "FrontEnd", "TestCase", "TP_292748", "TC_279689", "1", "TRUE", "Start_Month_PreviousYear", "January 2019");
        }

        #endregion Add Test Data
    }
}