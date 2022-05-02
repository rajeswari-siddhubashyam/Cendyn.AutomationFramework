using System;
using eLoyaltyV3.AppModule.UI;
using eLoyaltyV3.Entity;
using InfoMessageLogger;
using eLoyaltyV3.PageObject.Admin;
using Queries = eLoyaltyV3.Utility.Queries;
using Constants = eLoyaltyV3.Utility.Constants;
using BaseUtility.Utility;
using TestData;
using NUnit.Framework;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region TP_186921 - Admin Member Search Stay
        public static void TC_146642()
        {
            if (TestCaseId == Constants.TC_146642)
            {
                //Prerequisites:
                Users data = new Users();
                string departureFrom, departureTo, firstname, status, lastname, Property, ratecode;

                //retrive data from test data file
                departureFrom = TestData.ExcelData.TestDataReader.ReadData(1, "DepartureFrom");
                departureTo = TestData.ExcelData.TestDataReader.ReadData(1, "DepartureTo");
                firstname = TestData.ExcelData.TestDataReader.ReadData(1, "Firstname");
                status = TestData.ExcelData.TestDataReader.ReadData(1, "Status");
                Queries.ReturnMemberSearchAsPerDate(data, departureFrom, departureTo, firstname, " ");
                firstname = data.firstName;
                lastname = data.lastName;
                Property = data.PropertyCode;
                ratecode = data.RateType;

                //1. User has logged in to Guest Profile application with valid credentials.
                //2. User should be on Home >> Member Search >> Member Information >> Member Stays
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                Admin.SelectMemberStatus(status);
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Member is displayed.");
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Land on the 'Member Information'.");
                Admin.Click_Tab_MemberStay();
                Logger.WriteDebugMessage("Land on the Member Stay.");

                //1.Navigate to search stay
                Admin.Click_MemberstayButton_SearchStay();
                Logger.WriteDebugMessage("Dynamic fields appeared in  member stay.");

                //2.Enter First name, Last name, Property, Departure from and departure to in the search fields
                Admin.Enter_Text_Firstname(firstname);
                Admin.Enter_Text_Lastname(lastname);
                Admin.SelectProperty(ProjectName);
                Admin.Enter_Text_DepartureFrom(departureFrom);
                Admin.Enter_Text_DepartureTo(departureTo);
                Admin.Click_MemberstayButton_Search();
                Logger.WriteDebugMessage("First name, Last name, Departure from, departure to and property  should entered.");
                Logger.LogTestData(TestPlanId, TestCaseId, "First Name of User", firstname);
                Logger.LogTestData(TestPlanId, TestCaseId, "Last Name of User", lastname);
                Logger.LogTestData(TestPlanId, TestCaseId, "Property Name", Property);
                Logger.LogTestData(TestPlanId, TestCaseId, "Status", status);
                Logger.LogTestData(TestPlanId, TestCaseId, "Departure From", departureFrom);
                Logger.LogTestData(TestPlanId, TestCaseId, "Departure To", departureTo, true);

                //3.Verify First name, Last name, Property, Departure from and Departure to are match with database.
                VerifyTextOnPageAndHighLight(firstname);
                VerifyTextOnPageAndHighLight(lastname);
                VerifyTextOnPage(departureFrom);
                VerifyTextOnPage(departureTo);
                VerifyTextOnPage(ratecode);
                Logger.WriteDebugMessage("Searched stay displaying on the grid");

                // Verify in db
                Queries.GetStayAsPerFirstName(data, firstname);
                if (data.firstName.Equals(firstname))
                {
                    Logger.WriteDebugMessage("First Name, Last name, Property, Departure to and departure from should match with DB");
                }
                else
                    Assert.Fail("Data not matched with db");
            }
        }

        public static void TC_147010()
        {
            if (TestCaseId == Constants.TC_147010)
            {

                Users data = new Users();
                Queries.GetActiveMemberEmail(data);
                //1.Login to Admin              
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
                Driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(120));
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //2.Search for a profile who has stay 
                Admin.EnterEmail(data.MemberEmail);
                Admin.SelectMemberStatus("Active");
                Admin.Click_Button_MemberSearch();
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Profile gets displayed ");
                Logger.LogTestData(TestPlanId, TestCaseId, "Active Email", data.MemberEmail);

                //3.Navigate to Member Stay
                Admin.Click_Tab_MemberStay();
                Logger.WriteDebugMessage("Member stay tab gets displayed ");

                //4.click on search stay   
                Admin.Click_MemberstayButton_SearchStay();
                Logger.WriteDebugMessage("User landed on Stay search page ");

                //5.Enter a property and departure date as a month before today and click on search 
                
                Queries.ReturnSignUpPMSCustomerWithStay(data);
                string firstname = data.firstName;
                string lastname = data.lastName;
                
                Admin.Enter_Text_Firstname(firstname);
                Admin.Enter_Text_Lastname(lastname);
                Admin.Click_MemberstayButton_Search();
                ElementWait(PageObject_Admin.Admin_MemberStay_Checkbox_Select(), 500);
                Logger.WriteDebugMessage("Details entered successfully and  search result gets displayed ");
                Logger.LogTestData(TestPlanId, TestCaseId, "First Name of User", firstname);
                Logger.LogTestData(TestPlanId, TestCaseId, "Last Name of User", lastname);
                // OLD CODE//
                //var previousDate = DateTime.Now.AddMonths(-1);
                //string date = previousDate.ToString("MM/dd/yyyy");
                //Users data1 = new Users();
                //Queries.IdentifyHotel(data1);
                //Admin.SelectProperty(data1.PropertyName);
                //Admin.Enter_Text_DepartureFrom(date);
                //Logger.LogTestData(TestPlanId, TestCaseId, "Property Name", data1.PropertyName, true);

                //6.Click on Membershipid  column  to display all  stay that belongs to member 
                DynamicScroll(Driver, PageObject_Admin.Admin_MemberStay_Tab_MemberID());
                Admin.Click_Tab_MemberID();
                Logger.WriteDebugMessage("Record should get displayed. ");

                //7.Select the  stay that belongs to a member 
                bool value = PageObject_Admin.Admin_MemberStay_Checkbox_Select().Displayed;
                if (value.Equals(true))
                {
                    Logger.WriteDebugMessage("user should be able to select the stay ");
                }
            }
        }

        public static void TC_147013()
        {
            if (TestCaseId == Constants.TC_147013)
            {
                Users data = new Users();
                //1.Login to Admin        
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
                Driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(120));
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //2.Search for a profile who has stay 
                Queries.GetActiveMemberEmail(data);
                Admin.EnterEmail(data.MemberEmail);
                Admin.Click_Button_MemberSearch();
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Profile gets displayed ");
                Logger.LogTestData(TestPlanId, TestCaseId, TestCaseId+ "_Active Email", data.MemberEmail);

                //3.Navigate to Member Stay
                Admin.Click_Tab_MemberStay();
                Logger.WriteDebugMessage("Member stay tab gets displayed ");

                //4.click on search stay    
                Admin.Click_MemberstayButton_SearchStay();
                Logger.WriteDebugMessage("User landed on Stay search page ");

                //5.Enter a property and departure date as a month before today and click on search 
                //Queries.GetDate_PreviousMonth(data);
                Queries.Return_ReservationNumberOfPMSUser(data);
                DateTime previous_date = DateTime.Now.AddYears(-5);
                string pDate = previous_date.ToShortDateString();
                Queries.IdentifyHotel(data);
                //Admin.SelectProperty(data.PropertyName);
                Admin.Enter_Text_DepartureFrom(pDate);
                Admin.Enter_ReservationNumber(data.ReservationNumber);
                Admin.Click_MemberstayButton_Search();
                Logger.WriteDebugMessage("Details entered successfully and  search result gets displayed ");
                Logger.LogTestData(TestPlanId, TestCaseId, "Property Name", data.PropertyName, true);

                //6.Click on Membershipid  column  to display all  stay that belongs to member 
                DynamicScroll(Driver, PageObject_Admin.Admin_MemberStay_Tab_MemberID());
                Admin.Click_Tab_MemberID();
                Admin.Click_Tab_MemberID();
                Logger.WriteDebugMessage("Record should  get displayed. ");

                //7.Select the  stay that  doesn't belongs to a member  and departure date is greater than  join date 
                string DepartureFrom = PageObject_Admin.Admin_MemberStay_Data_Arrival( ProjectName).GetAttribute("innerHTML");
                Admin.Click_CheckBox_Select();
                Logger.WriteDebugMessage("user should be able to Select the  stay  ");
                Admin.Click_MemberStay_Button_Save();
                Logger.WriteDebugMessage("user should  be able to select the stay  and click on save ");

                //8.Wait for 10 minutes for the Service to  process the transaction
                AddDelay(300000);
                Logger.WriteDebugMessage("Once processed , record should be added  in Account transaction rule log table ");

                //9.Verify service processed the assigned stay and award points 
                Admin.Click_Button_Back();
                VerifyTextOnPage(DepartureFrom);
                Logger.WriteDebugMessage("Stay  received points/Awards");

                //Login to admin, search for same member and click on View
                Helper.ReloadPage();
                Admin.EnterEmail(data.MemberEmail);
                Admin.Click_Button_MemberSearch();
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Profile gets displayed ");

                //Navigate to Points History & Verify that log has been generated for recently received points through Stay
                Admin.Click_Tab_PointsHistory();
                Logger.WriteDebugMessage("Point history tab get clicked");
                Helper.ScrollDown();

            }
        }

        public static void TC_221383()
        {
            if (TestCaseId == Constants.TC_221383)
            {
                Users data = new Users();
                //Prerequisites:
                //1.Log into admin portal
                Queries.ReturnReservationNumber(data);
                string reservationNumber = data.ReservationNumber;
                string status, searchEmail, departureFrom, departureTo;
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //2.Search for a member.
                searchEmail = TestData.ExcelData.TestDataReader.ReadData(1, "SearchEmail");
                status = TestData.ExcelData.TestDataReader.ReadData(1, "Status");
                departureFrom = TestData.ExcelData.TestDataReader.ReadData(1, "DepartureFrom");
                departureTo = TestData.ExcelData.TestDataReader.ReadData(1, "DepartureTo");
                Admin.EnterEmail(searchEmail);
                Admin.SelectMemberStatus(status);
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Member is displayed.");
                Logger.LogTestData(TestPlanId, TestCaseId, "Email", searchEmail);
                Logger.LogTestData(TestPlanId, TestCaseId, "Status", status);
                Logger.LogTestData(TestPlanId, TestCaseId, "Departure From", departureFrom);
                Logger.LogTestData(TestPlanId, TestCaseId, "Departure To", departureTo);

                //3.Click the "View" icon.
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Land on the 'Member Information'.");

                //4.Click the "Stays" tab.
                Admin.Click_Tab_MemberStay();
                Logger.WriteDebugMessage("Land on the Member Stay.");

                //5.Click the "Search Stay" button.
                Admin.Click_MemberstayButton_SearchStay();
                Logger.WriteDebugMessage("Search section is displayed.");

                //6.Select a property and click "Search".
                Queries.IdentifyHotel(data);
                Admin.SelectProperty(data.PropertyName);
                Admin.Click_MemberstayButton_Search();
                Logger.LogTestData(TestPlanId, TestCaseId, "Property Name", data.PropertyName, true);
                VerifyTextOnPage(data.PropertyName);
                Logger.WriteDebugMessage("Only search results that match the selected Property are displayed.");
                Admin.Click_Button_Back();

                //7. Click the "Search Stay" button.
                Admin.Click_MemberstayButton_SearchStay();
                Logger.WriteDebugMessage("Search section is displayed.");

                //8. Select a Departure From date and click "Search".
                Admin.Enter_Text_DepartureFrom(departureFrom);
                Admin.Click_MemberstayButton_Search();
                AddDelay(10000);
               // ElementWait(PageObject_Admin.Admin_MemberStay_Checkbox_Select(), 500);
                VerifyTextOnPage(departureFrom);
                Logger.WriteDebugMessage("Only search results that either land ON or AFTER the selected date are displayed.");
                Admin.Click_Button_Back();

                //9.Click the "Search Stay" button.
                Admin.Click_MemberstayButton_SearchStay();
                Logger.WriteDebugMessage("Search section is displayed.");

                //10.Select a Departure On date and click "Search".
                Admin.Enter_Text_DepartureTo(departureTo);
                Admin.Click_MemberstayButton_Search();
                AddDelay(10000);
                //ElementWait(PageObject_Admin.Admin_MemberStay_Checkbox_Select(), 400);
                VerifyTextOnPage(departureTo);
                Logger.WriteDebugMessage("Only search results that either land ON or BEFORE the selected date are displayed.");
                Admin.Click_Button_Back();

                //11.Click the "Search Stay" button.
                Admin.Click_MemberstayButton_SearchStay();
                Logger.WriteDebugMessage("Search section is displayed.");

                //12.Select a Departure Before and a Departure On date and click "Search".             
                Admin.Enter_Text_DepartureTo(departureTo);
                Admin.Enter_Text_DepartureFrom(departureFrom);
                Admin.Click_MemberstayButton_Search();
                AddDelay(10000);
                //ElementWait(PageObject_Admin.Admin_MemberStay_Checkbox_Select(), 600);
                VerifyTextOnPage(departureTo);
                VerifyTextOnPage(departureFrom);
                Logger.WriteDebugMessage("Only search results that either land ON or BETWEEN the selected dates are displayed.");
                Admin.Click_Button_Back();

                //13.Use the above query, find the reservation number and search record using the reservation number
                if (!ProjectName.Equals("Virgin"))
                {
                    Admin.Click_MemberstayButton_SearchStay();
                    Logger.WriteDebugMessage("Search section is displayed.");

                    Admin.Enter_Text_ReservationNumber(reservationNumber);
                    Admin.Click_MemberstayButton_Search();
                    VerifyTextOnPage(reservationNumber);
                    Logger.WriteDebugMessage("The result should display if the reservation number matches.");
                }
            }
        }

        public static void TC_221400()
        {
            if (TestCaseId == Constants.TC_221400)
            {
                Users data = new Users();
                string firstname, apostrophe, numeric, specialCharacter, status;
                status = TestData.ExcelData.TestDataReader.ReadData(1, "Status");
                apostrophe = TestData.ExcelData.TestDataReader.ReadData(1, "Apostrophe");
                numeric = TestData.ExcelData.TestDataReader.ReadData(1, "Numeric");
                specialCharacter = TestData.ExcelData.TestDataReader.ReadData(1, "SpecialCharacter");

                //1. Login to Admin
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //2.Search for a  active profile 
                Admin.SelectMemberStatus(status);
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Member is displayed.");

                //3.Navigate to MemberStay -> Search stay 
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Land on the 'Member Information'.");
                Logger.LogTestData(TestPlanId, TestCaseId, "Status", status);
                Admin.Click_Tab_MemberStay();
                Admin.Click_MemberstayButton_SearchStay();
                Logger.WriteDebugMessage("Land on the Member Stay.");

                //4.With out entering any value click on search 
                Admin.Click_MemberstayButton_Search();
                VerifyTextOnPage("No member data available");
                Logger.WriteDebugMessage("Result set should be null");

                //5.Enter Apostrophe name
                Queries.ReturnMemberSearchAsPerFirstname(data, apostrophe);
                firstname = data.firstName;
                Admin.Enter_Text_Firstname(firstname);
                Logger.WriteDebugMessage("Apostrophe name  should entered.");
                Logger.LogTestData(TestPlanId, TestCaseId, "First Name", firstname);

                //6.Click search
                Admin.Click_MemberstayButton_Search();
                ElementWait(PageObject_Admin.Admin_MemberStay_Checkbox_Select(), 100);
                Logger.WriteDebugMessage("Result  should displayed in member stays table.");

                //7.Enter First name and Last Name with Special character in the  field.
                Queries.ReturnMemberSearchAsPerFirstname(data, specialCharacter);
                firstname = data.firstName;
                lastName = data.lastName;
                Admin.Enter_Text_Firstname(firstname);
                Admin.Enter_Text_Lastname(lastName);
                Logger.WriteDebugMessage("First name and Lastname withSpecial character should entered");
                Logger.LogTestData(TestPlanId, TestCaseId, "Last Name", lastName, true);

                //8.Click search
                Admin.Click_MemberstayButton_Search();
                AddDelay(10000);
                //ElementWait(PageObject_Admin.Admin_MemberStay_Checkbox_Select(), 500);
                Logger.WriteDebugMessage("Result should display.");

                //9.Enter  First name with Numbers
                Queries.ReturnMemberSearchAsPerFirstname(data, numeric);
                firstname = data.firstName;
                Admin.Enter_Text_Firstname(firstname);
                Logger.WriteDebugMessage("First name with numbers entered.");

                //10.Click Search
                Admin.Click_MemberstayButton_Search();
              //  ElementWait(PageObject_Admin.Admin_MemberStay_Checkbox_Select(), 500);
                Logger.WriteDebugMessage("Result should display.");
            }
        }

        public static void TC_221412()
        {
            if (TestCaseId == Constants.TC_221412)
            {
                Users data = new Users();
                //1.Login to Admin               
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                Queries.ReturnDCustomerStayData(data);

                //2.Search for a profile who has stay 
                Admin.EnterEmail(data.eMail);
                Admin.Click_Button_MemberSearch();
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Profile gets displayed ");
                Logger.LogTestData(TestPlanId, TestCaseId, "Email with Stay Data", data.eMail, true);

                //3.Navigate to Member Stay  and capture a stay that display  in the tab 
                Admin.Click_Tab_MemberStay();
                string reservationnumber = PageObject_Admin.Admin_MemberStay_Data_ReservationNumber().GetAttribute("innerHTML");
                string DepartureFrom = Admin.GetValueFromMemberStayTablesByProvidingColumnNameofTheFirstRow("Arrival");
                string DepartureTo = Admin.GetValueFromMemberStayTablesByProvidingColumnNameofTheFirstRow("Departure");
                Logger.WriteDebugMessage("Stay detail that belongs to profiled customer gets captured ");

                //4.click on search stay 
                Admin.Click_MemberstayButton_SearchStay();
                Logger.WriteDebugMessage("Search stay page gets displayed ");

                //5.Enter the same property and departure date as it is captured in previous step  and click on search 
                // 6.In Filter text enter the reservation number captured in step 3
                Admin.Enter_Text_DepartureFrom(DepartureFrom);
                Admin.Enter_Text_DepartureTo(DepartureTo);
                Admin.Click_MemberstayButton_Search();
                ElementWait(PageObject_Admin.Admin_MemberStay_Checkbox_Select(), 500);
                Logger.WriteDebugMessage("Details entered successfully and  search result gets displayed ");
                Logger.WriteDebugMessage("Record should get displayed. ");

                //7.Enter Invalid data
                string invaliddata = "??";
                Queries.ReturnMemberSearchAsPerFirstname(data, invaliddata);
                Admin.Enter_Text_Firstname(data.firstName);
                Logger.WriteDebugMessage("First name with numbers entered.");

                //8.Click search
                Admin.Click_MemberstayButton_Search();

                //9.Verify the result should match  with database
                VerifyTextOnPage(firstName);
                Logger.WriteDebugMessage("The Result should match with Database");
            }
        }
        /*Test Cases are moved fromm V3 to Gloabl
        //V3
        public static void TC_146636()

        {
            if (TestCaseId == Constants.TC_146636)
            {
                Users data = new Users();
                Queries.GetActiveMemberEmail(data);
                //Prerequisites:
                //1.Log into admin portal
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //2.Search for a member.
                Admin.EnterEmail(data.MemberEmail);
                Admin.SelectMemberStatus(TestData.TC_146636_Status);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Member is displayed.");

                //3.Click the "View" icon.
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Land on the 'Member Information'.");

                //4.Click the "Stays" tab.
                Admin.Click_Tab_MemberStay();
                Logger.WriteDebugMessage("Land on the Member Stay.");

                //5.Click the "Search Stay" button.
                Admin.Click_MemberstayButton_SearchStay();
                Logger.WriteDebugMessage("Search section is displayed.");

                //6.Select a property and click "Search".
                Admin.SelectProperty(ProjectName);
                Admin.Click_MemberstayButton_Search();
                AddDelay(1500);
                VerifyTextOnPage(ProjectName);
                Logger.WriteDebugMessage("Only search results that match the selected Property are displayed.");
            }
        }

        public static void TC_146637()
        {
            if (TestCaseId == Constants.TC_146637)
            {
                Users data = new Users();
                Queries.GetActiveMemberEmail(data);
                //Prerequisites:
                //1.Log into admin portal
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //2.Search for a member.
                Admin.EnterEmail(data.MemberEmail);
                Admin.SelectMemberStatus(TestData.TC_146637_Status);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Member is displayed.");

                //3.Click the "View" icon.
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Land on the 'Member Information'.");

                //4.Click the "Stays" tab.
                Admin.Click_Tab_MemberStay();
                Logger.WriteDebugMessage("Land on the Member Stay.");

                //5.Click the "Search Stay" button.
                Admin.Click_MemberstayButton_SearchStay();
                Logger.WriteDebugMessage("Search section is displayed.");

                //6.Select a Departure From date and click "Search".
                Admin.Enter_Text_DepartureFrom(TestData.TC_146637_DepartureFrom);
                Admin.Click_MemberstayButton_Search();
                AddDelay(1500);
                VerifyTextOnPage(TestData.TC_146637_DepartureFrom);
                Logger.WriteDebugMessage(
                    "Only search results that either land ON or AFTER the selected date are displayed.");
            }
        }

        public static void TC_146638()
        {
            if (TestCaseId == Constants.TC_146638)
            {
                Users data = new Users();
                Queries.GetActiveMemberEmail(data);

                //Prerequisites:
                //1.Log into admin portal
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //2.Search for a member.
                Admin.EnterEmail(data.MemberEmail);
                Admin.SelectMemberStatus(TestData.TC_146638_Status);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Member is displayed.");

                //3.Click the "View" icon.
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Land on the 'Member Information'.");

                //4.Click the "Stays" tab.
                Admin.Click_Tab_MemberStay();
                Logger.WriteDebugMessage("Land on the Member Stay.");

                //5.Click the "Search Stay" button.
                Admin.Click_MemberstayButton_SearchStay();
                Logger.WriteDebugMessage("Search section is displayed.");

                //6.Select a Departure On date and click "Search".
                Admin.Enter_Text_DepartureTo(TestData.TC_146638_DepartureTo);
                Admin.Click_MemberstayButton_Search();
                AddDelay(1500);
                VerifyTextOnPage(TestData.TC_146638_DepartureTo);
                Logger.WriteDebugMessage(
                    "Only search results that either land ON or BEFORE the selected date are displayed.");
            }
        }

        public static void TC_146639()
        {
            if (TestCaseId == Constants.TC_146639)
            {
                Users data = new Users();
                //Prerequisites:
                //1.Log into admin portal
                Queries.ReturnMemberSearchAsPerDate(data, TestData.TC_146639_DepartureFrom,
                    TestData.TC_146639_DepartureTo,
                    " ", " ");
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //2.Search for a member.
                Admin.EnterEmail("test");
                Admin.SelectMemberStatus(TestData.TC_146639_Status);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Member is displayed.");

                //3.Click the "View" icon.
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Land on the 'Member Information'.");

                //4.Click the "Stays" tab.
                Admin.Click_Tab_MemberStay();
                Logger.WriteDebugMessage("Land on the Member Stay.");

                //5.Click the "Search Stay" button.
                Admin.Click_MemberstayButton_SearchStay();
                Logger.WriteDebugMessage("Search section is displayed.");

                //6.Select a Departure Before and a Departure On date and click "Search".
                //string deparatureFrom = TestData.TC_146639_DepartureFrom.ToString();
                // DateTime.ParseExact(TestData.TC_146639_DepartureFrom, "yyyy-MM-dd", CultureInfo.InvariantCulture)
                //.ToString("dd/MM/yyyy");
                //deparatureFrom =  TestData.ExcelData.TestDataReader.ReadData(1, "DepartureFrom".ToString();
                //deparatureFrom = deparatureFrom 
                //string deparatureFrom = DateTime.ParseExact(TestData.TC_146639_DepartureFrom, "yyyy-MM-dd", CultureInfo.InvariantCulture).ToString("dd/MM/yyyy");
                //string deparatureTo = DateTime.ParseExact(TestData.TC_146639_DepartureTo, "yyyy-MM-dd", CultureInfo.InvariantCulture).ToString("dd/MM/yyyy");
                Admin.Enter_Text_DepartureTo(TestData.TC_146639_DepartureTo);
                Admin.Enter_Text_DepartureFrom(TestData.TC_146639_DepartureFrom);
                Admin.Click_MemberstayButton_Search();
                AddDelay(1500);
                VerifyTextOnPage(TestData.TC_146639_DepartureTo);
                VerifyTextOnPage(TestData.TC_146639_DepartureFrom);
                Logger.WriteDebugMessage(
                    "Only search results that either land ON or BETWEEN the selected dates are displayed.");
            }
        }


        public static void TC_146643()
        {
            if (TestCaseId == Constants.TC_146643)
            {
                Users data = new Users();
                //Prerequisites:
                //1. User has logged in to Guest Profile application with valid credentials.
                //2. User should be on Home >> Member Search >> Member Information >> Member Stays
                Queries.ReturnMemberSearchAsPerFirstname(data, TestData.TC_146643_Firstname);
                string firstname = data.firstName;
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                Admin.SelectMemberStatus(TestData.TC_146643_Status);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Member is displayed.");
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Land on the 'Member Information'.");
                Admin.Click_Tab_MemberStay();
                Logger.WriteDebugMessage("Land on the Member Stay.");

                //1.Navigate to search stay
                Admin.Click_MemberstayButton_SearchStay();
                AddDelay(5000);
                Logger.WriteDebugMessage("Dynamic fields appeared in  member stay.");

                //2.EnterEnter Apostrophe name
                Admin.Enter_Text_Firstname(firstname);
                Logger.WriteDebugMessage("Apostrophe name  should entered.");

                //3.Click search
                Admin.Click_MemberstayButton_Search();
                AddDelay(5000);
                Logger.WriteDebugMessage("Result  should displayed in member stays table.");

                //4.Verify the result should match  with database
                VerifyTextOnPage(firstname);
                Logger.WriteDebugMessage("The Result should match with Database");
            }
        }

        public static void TC_146644()
        {
            if (TestCaseId == Constants.TC_146644)
            {
                Users data = new Users();
                //Prerequisites:
                //1. User has logged in to Guest Profile application with valid credentials.
                //2. User should be on Home >> Member Search >> Member Information >> Member Stays
                Queries.ReturnMemberSearchAsPerFirstname(data, TestData.TC_146644_Firstname);
                string firstname = data.firstName;
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                Admin.SelectMemberStatus(TestData.TC_146644_Status);
                Admin.Click_Button_MemberSearch();
                AddDelay(10000);
                Logger.WriteDebugMessage("Member is displayed.");
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Land on the 'Member Information'.");
                Admin.Click_Tab_MemberStay();
                Logger.WriteDebugMessage("Land on the Member Stay.");

                //1.Navigate to search stay
                Admin.Click_MemberstayButton_SearchStay();
                AddDelay(5000);
                Logger.WriteDebugMessage("Dynamic fields appeared in  member stay.");

                //2.EnterEnter Apostrophe name
                Admin.Enter_Text_Firstname(firstname);
                Logger.WriteDebugMessage("Apostrophe name  should entered.");

                //3.Click search
                Admin.Click_MemberstayButton_Search();
                AddDelay(5000);
                Logger.WriteDebugMessage("Result  should displayed in member stays table.");

                //4.Verify the result should match  with database
                VerifyTextOnPage(firstname);
                Logger.WriteDebugMessage("The Result should match with Database");
            }
        }

        public static void TC_146645()
        {
            if (TestCaseId == Constants.TC_146645)
            {
                Users data = new Users();
                //Prerequisites:
                //1. User has logged in to Guest Profile application with valid credentials.
                //2. User should be on Home >> Member Search >> Member Information >> Member Stays
                Queries.ReturnMemberSearchAsPerFirstname(data, TestData.TC_146645_Firstname);
                string firstname = data.firstName;
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                Admin.SelectMemberStatus(TestData.TC_146645_Status);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Member is displayed.");
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Land on the 'Member Information'.");
                Admin.Click_Tab_MemberStay();
                Logger.WriteDebugMessage("Land on the Member Stay.");

                //1.Navigate to search stay
                Admin.Click_MemberstayButton_SearchStay();
                AddDelay(5000);
                Logger.WriteDebugMessage("Dynamic fields appeared in  member stay.");

                //2.Enter  First name with Numbers
                Admin.Enter_Text_Firstname(firstname);
                Logger.WriteDebugMessage("First name with numbers entered.");

                //3.Click search
                Admin.Click_MemberstayButton_Search();
                AddDelay(5000);
                Logger.WriteDebugMessage("Result  should displayed in member stays table.");

                //4.Verify the result should match  with database
                VerifyTextOnPage(firstname);
                Logger.WriteDebugMessage("The Result should match with Database");
            }
        }

        public static void TC_146646()
        {
            if (TestCaseId == Constants.TC_146646)
            {
                Users data = new Users();
                //Prerequisites:
                //1. User has logged in to Guest Profile application with valid credentials.
                //2. User should be on Home >> Member Search >> Member Information >> Member Stays
                Queries.ReturnMemberSearchAsPerFirstname(data, TestData.TC_146646_Firstname);
                string firstname = data.firstName;
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                Admin.SelectMemberStatus(TestData.TC_146645_Status);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Member is displayed.");
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Land on the 'Member Information'.");
                Admin.Click_Tab_MemberStay();
                Logger.WriteDebugMessage("Land on the Member Stay.");

                //1.Navigate to search stay
                Admin.Click_MemberstayButton_SearchStay();
                AddDelay(5000);
                Logger.WriteDebugMessage("Dynamic fields appeared in  member stay.");

                //2.Enter  First name with Numbers
                Admin.Enter_Text_Firstname(firstName);
                Logger.WriteDebugMessage("First name with numbers entered.");

                //3.Click search
                Admin.Click_MemberstayButton_Search();
                AddDelay(5000);
                Logger.WriteDebugMessage("Result  should displayed in member stays table.");

                //4.Verify the result should match  with database
                VerifyTextOnPage(firstName);
                Logger.WriteDebugMessage("The Result should match with Database");
            }
        }

        public static void TC_147007()
        {
            if (TestCaseId == Constants.TC_147007)
            {
                //1.Login to Admin
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                Users data = new Users();
                Queries.GetActiveMemberEmail(data);

                //2.Search for a  active profile
                Admin.EnterEmail(data.MemberEmail);
                Admin.SelectMemberStatus(TestData.TC_147007_Status);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Active profile gets displayed ");

                //3.Navigate to MemberStay -> Search stay 
                Admin.Click_Tab_MemberStay();
                Admin.Click_MemberstayButton_SearchStay();
                AddDelay(5000);
                Logger.WriteDebugMessage("Search stay page gets displayed ");

                //4.With out entering any value click on search 
                Admin.Click_MemberstayButton_Search();
                AddDelay(5000);
                VerifyTextOnPage("No member data available");
                Logger.WriteDebugMessage("Result set should be null");
            }
        }

        public static void TC_147008()
        {
            if (TestCaseId == Constants.TC_147008)
            {
                Users data = new Users();
                //1.Login to Admin               
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                Queries.ReturnDCustomerStayData(data);
                string email = data.eMail;

                //2.Search for a profile who has stay 
                Admin.EnterEmail(email);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Profile gets displayed ");

                //3.Navigate to Member Stay  and capture a stay that display  in the tab 
                Admin.Click_Tab_MemberStay();
                string reservationnumber =
                    PageObject_Admin.Admin_MemberStay_Data_ReservationNumber().GetAttribute("innerHTML");
                string DepartureFrom = PageObject_Admin.Admin_MemberStay_Data_Arrival().GetAttribute("innerHTML");
                string DepartureTo = PageObject_Admin.Admin_MemberStay_Data_Departure().GetAttribute("innerHTML");
                string hotel = PageObject_Admin.Admin_MemberStay_Data_Hotel().GetAttribute("innerHTML");
                Logger.WriteDebugMessage("Stay detail that belongs to profiled customer gets captured ");

                //4.click on search stay 
                Admin.Click_MemberstayButton_SearchStay();
                AddDelay(5000);
                Logger.WriteDebugMessage("Search stay page gets displayed ");

                //5.Enter the same property and departure date as it is captured in previous step  and click on search 
                Admin.SelectProperty(hotel);
                if (!(ProjectName.Equals("AdareManor") || ProjectName.Equals("PublicHotel")))
                {
                    Admin.Enter_Text_ReservationNumber(reservationnumber);
                }

                Admin.Enter_Text_DepartureFrom(DepartureFrom);
                Admin.Enter_Text_DepartureTo(DepartureTo);
                Admin.Click_MemberstayButton_Search();
                Logger.WriteDebugMessage("Details entered successfully and  search result gets displayed ");

                //6.In Filter text enter the reservation number captured in step 3 
                VerifyTextOnPage("No member data available, please update search.");
                Logger.WriteDebugMessage("Record should not get displayed. ");
            }
        }
        public static void TC_149105()
        {
            if (TestCaseId == Constants.TC_149105)
            {
                Users data = new Users();
                //Prerequisites:
                //1. User has logged in to Guest Profile application with valid credentials.
                //2. User should be on Home >> Member Search >> Member Information >> Member Stays
                Queries.ReturnReservationNumber(data);
                string reservationNumber = data.ReservationNumber;
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);

                //1.Log in using valid credentials
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Admin user landed in member search page");

                //2.Identify the profile
                Admin.EnterEmail(data.eMail);
                Admin.SelectMemberStatus("Active");
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Profile identified.");

                //3.Click View icon
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Admin user landed in member information page");

                //4.Click member stays tab.Click Search stay
                Admin.Click_Tab_MemberStay();
                Logger.WriteDebugMessage("Land on the Member Stay.");

                //5.Use the above query, find the reservation number
                VerifyTextOnPage(reservationNumber);
                Logger.WriteDebugMessage("The result should display   if the reservation number matches.");

            }
        }
        */
        #endregion TP_186921        
    }
}
