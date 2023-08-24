using System;
using InfoMessageLogger;
using BaseUtility.Utility;
using eLoyaltyV3.Utility;
using eLoyaltyV3.PageObject.Admin;
using eLoyaltyV3.AppModule.UI;
using TestData;
using OpenQA.Selenium;
using eLoyaltyV3.Entity;
using Queries = eLoyaltyV3.Utility.Queries;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : eLoyaltyV3.Utility.Setup
    {
        #region TP_171074 - Admin/MemberSearch
        public static void TC_113756()
        {
            if (TestCaseId == Constants.TC_113756)
            {
                //1 URL is available in master test plan run description:Login as Admin in backend
                //2.Navigate to member search.                
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Click on the member search icon.
                Admin.Click_Button_MemberSearch();
                VerifyTextOnPageAndHighLight(Constants.ValidationMessageNoMemberData);
                Logger.WriteDebugMessage("'No member data available please update search' message displayed.");
            }
        }
        public static void TC_113764()
        {
            if (TestCaseId == Constants.TC_113764)
            {
                //1 URL is available in master test plan run description:Login as Admin in backend
                //2.Navigate to member search.  
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Select member type as loyalty.Click on search
                Admin.SelectMemberType("Loyalty");
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Member result displayed.");

                //4.Verify Entries drop down is displayed with total of 4 selections as below: 5,10,15,20
                Admin.VerifyPaginationDropdown();
                Logger.WriteDebugMessage("Entries drop down should display 4 mentioned selections");

                //5.Select 5 from Entries dropdown
                Admin.SelectPagination("5");
                Logger.WriteDebugMessage("Only 5 items should be displayed at a time in the grid and");
                Logger.LogTestData(TestPlanId, TestCaseId, "1st No Of Records", "5");

                //6.Click on the "Next Page" button
                Admin.Click_Icon_Next();
                Logger.WriteDebugMessage("User should land on the next page with the proper results.");

                //7.Select 10 from Entries dropdown
                Admin.SelectPagination("10");
                Logger.WriteDebugMessage("Only 10 items should be displayed at a time in the grid and");
                Logger.LogTestData(TestPlanId, TestCaseId, "2nd No Of Records", "10");

                //8.Click on the "Next Page" button
                Admin.Click_Icon_Next();
                Logger.WriteDebugMessage("User should land on the next page with the proper results.");

                //9.Click on the "Previous Page" button
                Admin.Click_Icon_Previous();
                Logger.WriteDebugMessage("User should land back on the previous page with the proper results.");

                //10.Select 15 from Entries dropdown
                Admin.SelectPagination("15");
                Logger.WriteDebugMessage("Only 15 items should be displayed at a time in the grid and");
                Logger.LogTestData(TestPlanId, TestCaseId, "3rd No Of Records", "15");

                //11.Select 20 from Entries dropdown
                Admin.SelectPagination("20");
                Logger.WriteDebugMessage("Only 20 items should be displayed at a time in the grid and");
                Logger.LogTestData(TestPlanId, TestCaseId, "4ts No Of Records", "20", true);
            }
        }

        public static void TC_221090()
        {
            if (TestCaseId == Constants.TC_221090)
                {
                    //1 URL is available in master test plan run description:Login as Admin in backend
                    //2.Navigate to member search.  
                    //3.Check member search buttons are in default one.
                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    //3.Verify all fields are displayed.
                    VerifyTextOnPage("Member Type:");
                    VerifyTextOnPage("Member Number:");
                    VerifyTextOnPage("Last Name:");
                    VerifyTextOnPage("First Name:");
                    VerifyTextOnPage("Email:");
                    VerifyTextOnPage("Street:");
                    VerifyTextOnPage("City:");
                    VerifyTextOnPage("Zip:");
                    VerifyTextOnPage("Country");
                    VerifyTextOnPage("State");
                    VerifyTextOnPage("Award Name:");
                    VerifyTextOnPage("Award Number:");
                    VerifyTextOnPage("Card Name:");
                    VerifyTextOnPage("Company:");
                    VerifyTextOnPage("Phone:");
                    VerifyTextOnPage("Member Status:");
                    Logger.WriteDebugMessage("All fields found in member search page.");

                    //4.Select member type as loyalty .
                    Admin.SelectMemberType("Loyalty");
                    Logger.WriteDebugMessage("User is able to select loyalty from member type .");

                    //5.Click on search
                    Admin.Click_Button_MemberSearch();
                    Logger.WriteDebugMessage("Member result displayed.");

                    //6.Capture an email address from search result.
                    string email = PageObject_Admin.Value_Email().GetAttribute("innerHTML");
                    Logger.WriteDebugMessage("Email address captured from member result.");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Active Member", email);

                    //7.Clear the search criteria.
                    Admin.Click_Button_ClearSearch();
                    Logger.WriteDebugMessage("Search cleared.");

                    //8.Enter the captured email exactly on the email search .
                    Admin.EnterEmail(email);
                    Logger.WriteDebugMessage("User able to enter email address.");

                    //9.Click on search
                    Admin.Click_Button_MemberSearch();
                    VerifyTextOnPage(email);
                    Logger.WriteDebugMessage("Member found.");

                    //10.Enter partial character from captured email
                    string[] partialemail = email.Split('@');
                    Admin.EnterEmail(partialemail[0]);
                    Logger.WriteDebugMessage("User able to enter email address.");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Partial Email", partialemail[0]);

                    //11.Click on search
                    Admin.Click_Button_MemberSearch();
                    VerifyTextOnPage(email);
                    Logger.WriteDebugMessage("Member found and It should match with database.Query is available in Description");

                    //12.Clear the search criteria.
                    Admin.Click_Button_ClearSearch();
                    Logger.WriteDebugMessage("Search cleared.");

                    //13.Select member type as loyalty.Click on search
                    Admin.SelectMemberType("Loyalty");
                    Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                    Admin.Click_Button_MemberSearch();
                    Logger.WriteDebugMessage("Member result displayed.");

                    //14.Capture the firstname address from search result.
                    string firstname = PageObject_Admin.Value_FullName().GetAttribute("innerHTML");
                    string[] partialFirstname = firstname.Split(' ');
                    Logger.WriteDebugMessage("Firstname Captured.");

                    //15.Clear the search criteria.
                    Admin.Click_Button_ClearSearch();
                    Logger.WriteDebugMessage("Search cleared.");

                    //16.Enter the captured firstname exactly on the search.Click on Search.
                    Admin.EnterFirstname(partialFirstname[0]);
                    Logger.WriteDebugMessage("User is able to Entre First Name");
                    Admin.Click_Button_MemberSearch();
                    VerifyTextOnPage(partialFirstname[0]);
                    Logger.WriteDebugMessage("Member found.");

                    //17.Enter partial character from captured Firstname.Click on search               
                    Admin.EnterFirstname(partialFirstname[0]);
                    Logger.WriteDebugMessage("User is able to Entre Partial First Name");
                    Logger.LogTestData(TestPlanId, TestCaseId, "First Name", partialFirstname[0]);
                    Admin.Click_Button_MemberSearch();
                    VerifyTextOnPage(partialFirstname[0]);
                    Logger.WriteDebugMessage("Member found and It should match with database.Query is available in Description");

                    //18.Clear the search criteria.
                    Admin.Click_Button_ClearSearch();
                    Logger.WriteDebugMessage("Search cleared.");

                    //19.Select member type as loyalty.Click on search
                    Admin.EnterEmail(email);
                    Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                    Admin.Click_Button_MemberSearch();
                    Logger.WriteDebugMessage("Member result displayed.");

                    //20.Capture the Lastname address from search result.
                    string Lastname = PageObject_Admin.Value_FullName().GetAttribute("innerHTML");
                    string[] partialLastname = Lastname.Split(' ');
                    Logger.WriteDebugMessage("Lastname Captured.");

                    //21.Clear the search criteria.
                    Admin.Click_Button_ClearSearch();
                    Logger.WriteDebugMessage("Search cleared.");

                    //22.Enter the captured Lastname exactly on the search.Click on Search.
                    Admin.EnterLastname(partialLastname[1]);
                    Logger.WriteDebugMessage("User is able to Entre Last Name");
                    Admin.Click_Button_MemberSearch();
                    VerifyTextOnPage(partialLastname[1]);
                    Logger.WriteDebugMessage("Member found.");

                    //23.Enter partial character from captured Lastname.Click on search               
                    Admin.EnterLastname(partialLastname[1]);
                    Logger.WriteDebugMessage("User is able to Entre Partial Last Name");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Last Name", partialLastname[1]);
                    Admin.Click_Button_MemberSearch();
                    VerifyTextOnPage(partialLastname[1]);
                    Logger.WriteDebugMessage("Member found and It should match with database.Query is available in Description");

                    //24.Clear the search criteria.
                    Admin.Click_Button_ClearSearch();
                    Logger.WriteDebugMessage("Search cleared.");

                    //25.Select member type as loyalty.Click on search
                    Admin.SelectMemberType("Loyalty");
                    Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                    Admin.Click_Button_MemberSearch();
                    Logger.WriteDebugMessage("Member result displayed.");

                    //26.Capture the member Number from search result..
                    string membernumber = PageObject_Admin.Value_MemberNumber().GetAttribute("innerHTML");
                    char[] partialmembernumber = membernumber.ToCharArray();
                    Logger.WriteDebugMessage("Member found.Member number Captured.");

                    //27.Clear the search criteria.
                    Admin.Click_Button_ClearSearch();
                    Logger.WriteDebugMessage("Search cleared.");

                    //28.Enter the captured firstname exactly on the search.Click on Search.
                    Admin.EnterMemberNumber(membernumber);
                    Logger.WriteDebugMessage("User is able to Entre MemberNumber");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Member Ship Number", membernumber, true);
                    Admin.Click_Button_MemberSearch();
                    VerifyTextOnPage(membernumber);
                    Logger.WriteDebugMessage("Member found.");

                    //29.Enter partial character from captured member type.Click on search
                    string data1 = String.Concat(partialmembernumber[0].ToString(), partialmembernumber[1].ToString(), partialmembernumber[2].ToString());
                    Admin.EnterMemberNumber(data1);
                    Logger.WriteDebugMessage("User is able to Enter MemberNumber");
                    Admin.Click_Button_MemberSearch();
                    VerifyTextOnPage(data1);
                    Logger.WriteDebugMessage("Member found and It should match with database.Query is available in Description");


                    //30.Clear the search criteria.
                    Admin.Click_Button_ClearSearch();
                    Logger.WriteDebugMessage("Search cleared.");

                    //31.Select member type as loyalty.Click on search
                    Admin.SelectMemberType("Loyalty");
                    Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                    Admin.Click_Button_MemberSearch();
                    Logger.WriteDebugMessage("Member result displayed.");

                    //32.Capture the member Number from search result..
                    membernumber = PageObject_Admin.Value_MemberNumber().GetAttribute("innerHTML");
                    partialmembernumber = membernumber.ToCharArray();
                    Logger.WriteDebugMessage("Member found.Member number Captured.");

                    //33.Clear the search criteria.
                    Admin.Click_Button_ClearSearch();
                    Logger.WriteDebugMessage("Search cleared.");

                    //34.Enter the captured firstname exactly on the search.Click on Search.
                    Admin.EnterMemberNumber(membernumber);
                    Logger.WriteDebugMessage("user should be able to entre MemberNumber");
                    Admin.Click_Button_MemberSearch();
                    VerifyTextOnPage(membernumber);
                    Logger.WriteDebugMessage("Member found.");

                    //35.Enter partial character from captured member type.Click on search
                    data1 = String.Concat(partialmembernumber[0].ToString(), partialmembernumber[1].ToString(), partialmembernumber[2].ToString());
                    Admin.EnterMemberNumber(data1);
                    Logger.WriteDebugMessage("user should be able to entre MemberNumber");
                    Admin.Click_Button_MemberSearch();
                    VerifyTextOnPage(data1);
                    Logger.WriteDebugMessage("Member found and It should match with database.Query is available in Description");
            }
        }

        public static void TC_221277()
        {
            if (TestCaseId == Constants.TC_221277)
                {
                    Users data = new Users();
                    Queries.GetActiveMemberWithAddress(data);

                    //1 URL is available in master test plan run description:Login as Admin in backend
                    //2.Navigate to member search.                
                    Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                    AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    //3.Select member type as loyalty.Click on search
                    if (ProjectName.Equals("OmniHotels") || ProjectName.Equals("Almanac"))
                    {
                        Admin.EnterEmail(data.MemberEmail);
                        Logger.LogTestData(TestPlanId, TestCaseId, "Active Member", data.MemberEmail);
                    }
                    else
                        Admin.SelectMemberType("Loyalty");
                    Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                    Admin.Click_Button_MemberSearch();
                    Logger.WriteDebugMessage("Member result displayed.");

                    //4.Capture the street address from search result.                               
                    string Address = PageObject_Admin.Value_Address().GetAttribute("innerHTML");
                    if (Address.Equals(""))
                    {
                        Address = data.Address1;
                        if (!string.IsNullOrEmpty(data.Address2))
                            Address += ", " + data.Address2;
                        Address += ", " + data.City + ", ";
                        if (!string.IsNullOrEmpty(data.StateProvinceCode))
                            Address += data.StateProvinceCode + " ";
                        Address += data.ZipCode + " " + data.CountryCode;
                    }

                    string[] partialAddress = Address.Split(',');
                    Logger.WriteDebugMessage("Member found.Member number Captured.");

                    //5.Clear the search criteria.
                    Admin.Click_Button_ClearSearch();
                    Logger.WriteDebugMessage("Search cleared.");

                    //6.Enter the captured Address exactly on the search.Click on Search.
                    Admin.EnterStreet(Address);
                    Logger.WriteDebugMessage("User should be able to entre Address");
                    Admin.Click_Button_MemberSearch();
                    Logger.LogTestData(TestPlanId, TestCaseId, "Street Address", Address);
                    if (VerifyTextOnPage(Address))
                        Logger.WriteDebugMessage("Member found.");
                    else
                        Logger.WriteDebugMessage("Member not found.");

                    //7.Enter partial character from captured member type.Click on search
                    Admin.EnterStreet(partialAddress[1]);
                    Logger.WriteDebugMessage("Enter partial character from captured member type");
                    Admin.Click_Button_MemberSearch();
                    VerifyTextOnPage(partialAddress[1]);
                    Logger.WriteDebugMessage("Member found and It should match with database. Query is available in Description");

                    //8.Clear the search criteria.
                    Admin.Click_Button_ClearSearch();
                    Logger.WriteDebugMessage("Search cleared.");

                    //9.Select member type as loyalty.Click on search
                    if (ProjectName.Equals("OmniHotels"))
                        Admin.EnterEmail(data.MemberEmail);
                    else
                        Admin.SelectMemberType("Loyalty");
                    Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                    Admin.Click_Button_MemberSearch();
                    Logger.WriteDebugMessage("Member result displayed.");

                    //10.Capture the city name from search result.
                    char[] partialCity = data.City.ToCharArray();// City.ToCharArray();
                    Logger.WriteDebugMessage("Member found.Member number Captured.");

                    //11.Clear the search criteria.
                    Admin.Click_Button_ClearSearch();
                    Logger.WriteDebugMessage("Search cleared.");

                    //12.Enter the captured City exactly on the search.Click on Search.
                    Admin.EnterCity(data.City);
                    Logger.WriteDebugMessage("User should be able to Enter City");
                    Logger.LogTestData(TestPlanId, TestCaseId, "City", data.City);
                    Admin.Click_Button_MemberSearch();
                    VerifyTextOnPage(data.City);
                    Logger.WriteDebugMessage("Member found.");

                    //13.Enter partial character from captured member type.Click on search
                    string data1 = String.Concat(partialCity[0].ToString(), partialCity[1].ToString(), partialCity[2].ToString());
                    Admin.Click_Button_ClearSearch();
                    Admin.EnterCity(data1);
                    Logger.WriteDebugMessage("User should be able to Enter City");
                    Admin.Click_Button_MemberSearch();
                    VerifyTextOnPage(data1);
                    Logger.WriteDebugMessage("Member found and It should match with database.Query is available in Description");

                    //14.Clear the search criteria.
                    Admin.Click_Button_ClearSearch();
                    Logger.WriteDebugMessage("Search cleared.");

                    //15.Select member type as loyalty.Click on search
                    if (ProjectName.Equals("OmniHotels"))
                        Admin.EnterEmail(data.MemberEmail);
                    else
                        Admin.SelectMemberType("Loyalty");
                    Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                    Admin.Click_Button_MemberSearch();
                    Logger.WriteDebugMessage("Member result displayed.");

                    //16.Capture the zip code from search result
                    char[] PartialZip = data.ZipCode.ToCharArray();// Zip.ToCharArray();
                    Logger.WriteDebugMessage("Member found.Member number Captured.");

                    //17.Clear the search criteria.
                    Admin.Click_Button_ClearSearch();
                    Logger.WriteDebugMessage("Search cleared.");

                    //18.Enter the captured City exactly on the search.Click on Search.
                    Admin.EnterZip(data.ZipCode);
                    Logger.WriteDebugMessage("User should be able to Entre ZipCode ");

                    Logger.LogTestData(TestPlanId, TestCaseId, "Zip Code", data.ZipCode);
                    Admin.Click_Button_MemberSearch();
                    VerifyTextOnPage(data.ZipCode);
                    Logger.WriteDebugMessage("Member found.");

                    //19.Enter partial character from captured member type.Click on search
                    data1 = String.Concat(PartialZip[0].ToString(), PartialZip[1].ToString(), PartialZip[2].ToString());
                    Admin.EnterZip(data1);
                    Logger.WriteDebugMessage("User should be able to Entre partial ZipCode ");
                    Admin.Click_Button_MemberSearch();
                    VerifyTextOnPage(data1);
                    Logger.WriteDebugMessage("Member found and It should match with database.Query is available in Description");

                    //20.Clear the search criteria.
                    Admin.Click_Button_ClearSearch();
                    Logger.WriteDebugMessage("Search cleared.");

                    ////21.Select member type as loyalty.Click on search
                    //Admin.SelectMemberType("Loyalty");
                    // if (ProjectName.Equals("OmniHotels"))
                    //Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                    //Admin.Click_Button_MemberSearch();
                    //AddDelay(5000);
                    //Logger.WriteDebugMessage("Member result displayed.");

                    ////22.Capture the Cardname from search result.
                    //string Cardname = PageObject_Admin.Value_CardName().GetAttribute("innerHTML");
                    //Logger.WriteDebugMessage("Member found.Cardname Captured.");

                    ////23.Clear the search criteria.
                    //Admin.Click_Button_ClearSearch();
                    //AddDelay(5000);
                    //Logger.WriteDebugMessage("Search cleared.");

                    ////24.Enter the captured Cardname exactly on the search.Click on Search.
                    //Admin.EnterCardName(Cardname);
                    //AddDelay(5000);
                    //Admin.Click_Button_MemberSearch();
                    //AddDelay(5000);
                    //VerifyTextOnPage(Cardname);
                    //Logger.WriteDebugMessage("Member found.");

                    ////25.Enter partial character from captured Cardname .Click on search               
                    //Admin.EnterCardName(Cardname);
                    //AddDelay(5000);
                    //Admin.Click_Button_MemberSearch();
                    //AddDelay(5000);
                    //VerifyTextOnPage(Cardname);
                    //Logger.WriteDebugMessage("Member found and It should match with database.Query is available in Description");

                    ////26.Clear the search criteria.
                    //Admin.Click_Button_ClearSearch();
                    //AddDelay(5000);
                    //Logger.WriteDebugMessage("Search cleared.");

                    //27.Select member type as loyalty.Click on search
                    if (ProjectName.Equals("OmniHotels"))
                        Admin.EnterEmail(data.MemberEmail);
                    else
                        Admin.SelectMemberType("Loyalty");
                    Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                    Admin.Click_Button_MemberSearch();
                    Logger.WriteDebugMessage("Member result displayed.");

                    //28.Capture the mobile phone number from search result.
                    string cellphonenumber = Queries.ReturnMultipleRecordforSearch("CellPhoneNumber");
                    Logger.WriteDebugMessage("Member found.Member number Captured.");

                    //29.Clear the search criteria.
                    Admin.Click_Button_ClearSearch();
                    Logger.WriteDebugMessage("Search cleared.");

                    //30.Capture the mobile phone number from search result.
                    Admin.EnterPhone(cellphonenumber);
                    Logger.WriteDebugMessage("User should be able to Entre cellphonenumber ");
                    Logger.LogTestData(TestPlanId, TestCaseId, "Cell Number", cellphonenumber, true);
                    Admin.Click_Button_MemberSearch();
                    VerifyTextOnPage(cellphonenumber);
                    Logger.WriteDebugMessage("Member found.");
             }
        }
        public static void TC_221385()
        {
            if (TestCaseId == Constants.TC_221385)
            {
                Users data = new Users();
                Queries.GetActiveMemberEmail(data);
                char[] PartialCompany;

                //1 URL is available in master test plan run description:Login as Admin in backend
                //2.Navigate to member search.                
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Select member type as loyalty.Click on search
                if (ProjectName.Equals("OmniHotels"))
                    Admin.EnterEmail(data.MemberEmail);
                else
                    Admin.SelectMemberType("Loyalty");
                Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Member result displayed.");

                //4.Capture the member number and  company  from search result.
                string MemberNumber = Queries.ReturnMultipleRecordforSearch("LoyaltyMemberID");
                string Company = Queries.ReturnMultipleRecordforSearch("Company");
                char[] PartialMemberNumber = MemberNumber.ToCharArray();
                if (!Company.Equals(""))
                {
                    PartialCompany = Company.ToCharArray();
                }
                else
                {
                    Company = "test";
                    PartialCompany = Company.ToCharArray();
                }

                Logger.WriteDebugMessage("Member found.Member number Captured.");

                //5.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                Logger.WriteDebugMessage("Search cleared.");

                //6.Enter the captured member number  and company exactly on the search 
                Admin.EnterMemberNumber(MemberNumber);
                Logger.WriteDebugMessage("user should be able to entre MemberNumber.");
                Admin.EnterCompany(Company);
                Logger.WriteDebugMessage("user should be able to entre Company.");
                Admin.Click_Button_MemberSearch();
                VerifyTextOnPage(MemberNumber);
                VerifyTextOnPage(Company);
                Logger.WriteDebugMessage("Member found.");

                //7.Enter partial character from captured member type.Click on search
                string data0 = String.Concat(PartialMemberNumber[0].ToString(), PartialMemberNumber[1].ToString(), PartialMemberNumber[2].ToString());
                string data1 = String.Concat(PartialCompany[0].ToString(), PartialCompany[1].ToString(), PartialCompany[2].ToString());
                Admin.EnterMemberNumber(data0);
                Admin.EnterCompany(data1);
                Logger.WriteDebugMessage("user should be able to entre MemberNumber and Company Name.");
                Admin.Click_Button_MemberSearch();
                VerifyTextOnPage(data0);
                VerifyTextOnPage(data1);
                Logger.WriteDebugMessage("Member found and It should match with database.Query is available in Description");

                //8.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                Logger.WriteDebugMessage("Search cleared.");

                //9.Select member type as loyalty.Click on search
                if (ProjectName.Equals("OmniHotels"))
                    Admin.EnterEmail(data.MemberEmail);
                else
                    Admin.SelectMemberType("Loyalty");
                Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Member result displayed.");

                //10.Capture the First name and last name from search result.
                string firstname = Queries.ReturnMultipleRecordforSearch("MemberFirstName");
                string lastname = Queries.ReturnMultipleRecordforSearch("MemberLastName");
                char[] Partialfirstname = firstname.ToCharArray();
                char[] Partiallastname = lastname.ToCharArray();
                Logger.WriteDebugMessage("Member found.Member number Captured.");

                //11.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                Logger.WriteDebugMessage("Search cleared.");

                //12.Enter the captured First name and last name exactly on the search . 
                Admin.EnterFirstname(firstname);
                Admin.EnterLastname(lastname);
                Logger.WriteDebugMessage("Member should be able to entre firstname and lastname");
                Logger.LogTestData(TestPlanId, TestCaseId, "First Name", firstname);
                Logger.LogTestData(TestPlanId, TestCaseId, "Last Name", lastname, true);
                Admin.Click_Button_MemberSearch();
                VerifyTextOnPage(firstname);
                VerifyTextOnPage(lastname);
                Logger.WriteDebugMessage("Member found.");

                //13.Enter partial character from captured first name and last name . Click on search.
                data0 = String.Concat(Partialfirstname[0].ToString(), Partialfirstname[1].ToString(), Partialfirstname[2].ToString());
                data1 = String.Concat(Partiallastname[0].ToString(), Partiallastname[1].ToString(), Partiallastname[2].ToString());
                Admin.EnterFirstname(data0);
                Admin.EnterLastname(data1);
                Logger.WriteDebugMessage("Member found.Member number Captured.");
                Admin.Click_Button_MemberSearch();
                VerifyTextOnPage(data0);
                VerifyTextOnPage(data1);
                Logger.WriteDebugMessage("Member found and It should match with database.Query is available in Description");

                //14.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                Logger.WriteDebugMessage("Search cleared.");

                //15.Select member type as loyalty.Click on search
                if (ProjectName.Equals("OmniHotels"))
                    Admin.EnterEmail(data.MemberEmail);
                else
                    Admin.SelectMemberType("Loyalty");
                Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Member result displayed.");

                //16.Capture the member number and last name from search result.
                string membershipNumber = Queries.ReturnMultipleRecordforSearch("LoyaltyMemberID");
                lastname = Queries.ReturnMultipleRecordforSearch("MemberLastName");
                char[] PartialmembershipNumber = membershipNumber.ToCharArray();
                Partiallastname = lastname.ToCharArray();
                Logger.WriteDebugMessage("Member found.Member number Captured.");

                //17.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                Logger.WriteDebugMessage("Search cleared.");

                //18.Enter the captured mobile phone number exactly on the search .
                Admin.EnterMemberNumber(membershipNumber);
                Admin.EnterLastname(lastname);
                Logger.WriteDebugMessage("Member found.Member number Captured.");
                Admin.Click_Button_MemberSearch();
                VerifyTextOnPage(membershipNumber);
                VerifyTextOnPage(lastname);
                Logger.WriteDebugMessage("Member found.");

                //19.Enter partial character from captured member number and last name .Click on search.
                data0 = String.Concat(PartialmembershipNumber[0].ToString(), PartialmembershipNumber[1].ToString(), PartialmembershipNumber[2].ToString());
                data1 = String.Concat(Partiallastname[0].ToString(), Partiallastname[1].ToString(), Partiallastname[2].ToString());
                Admin.EnterMemberNumber(data0);
                Admin.EnterLastname(data1);
                Logger.WriteDebugMessage("Member found.Member number Captured.");
                Admin.Click_Button_MemberSearch();
                VerifyTextOnPage(data0);
                VerifyTextOnPage(data1);
                Logger.WriteDebugMessage("Member found and It should match with database.Query is available in Description");

                //20.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                Logger.WriteDebugMessage("Search cleared.");

                //21.Select member type as loyalty.Click on search
                if (ProjectName.Equals("OmniHotels"))
                    Admin.EnterEmail(data.MemberEmail);
                else
                    Admin.SelectMemberType("Loyalty");
                Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Member result displayed.");

                //22.Capture the first name and email from search result.
                firstname = Queries.ReturnMultipleRecordforSearch("MemberFirstName");
                string email = Queries.ReturnMultipleRecordforSearch("MemberEmail");
                Partialfirstname = firstname.ToCharArray();
                char[] Partialemail = email.ToCharArray();
                Logger.WriteDebugMessage("Member found.Member number Captured.");

                //23.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                Logger.WriteDebugMessage("Search cleared.");

                //24.Enter the captured first name and email number exactly on the search .
                Admin.EnterFirstname(firstname);
                Admin.EnterEmail(email);
                Logger.WriteDebugMessage("user should be able to entre Email and firstname");
                Admin.Click_Button_MemberSearch();
                VerifyTextOnPage(firstname);
                VerifyTextOnPage(email);
                Logger.WriteDebugMessage("Member found.");

                //25.Enter partial character from captured first name and email address.Click on search.
                data0 = String.Concat(Partialfirstname[0].ToString(), Partialfirstname[1].ToString(), Partialfirstname[2].ToString());
                data1 = String.Concat(Partialemail[0].ToString(), Partialemail[1].ToString(), Partialemail[2].ToString());
                Admin.EnterFirstname(data0);
                Admin.EnterEmail(data1);
                Logger.WriteDebugMessage("user should be able to entre Email and firstname");
                Admin.Click_Button_MemberSearch();
                VerifyTextOnPage(data0);
                VerifyTextOnPage(data1);
                Logger.WriteDebugMessage("Member found and It should match with database.Query is available in Description");

                //26.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                Logger.WriteDebugMessage("Search cleared.");

                //27.Select member type as loyalty.Click on search
                if (ProjectName.Equals("OmniHotels"))
                    Admin.EnterEmail(data.MemberEmail);
                else
                    Admin.SelectMemberType("Loyalty");
                Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Member result displayed.");

                //28.Capture the first name and mobile phone number from search result.
                firstname = Queries.ReturnMultipleRecordforSearch("MemberFirstName");
                string cellphonenumber = Queries.ReturnMultipleRecordforSearch("CellPhoneNumber");
                Partialfirstname = firstname.ToCharArray();
                char[] Partialcellphonenumber = cellphonenumber.ToCharArray();
                Logger.WriteDebugMessage("Member found.Member number Captured.");

                //29.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                Logger.WriteDebugMessage("Search cleared.");

                //32.Enter the captured first name and mobile phone number exactly on the search .
                Admin.EnterFirstname(firstname);
                Admin.EnterPhone(cellphonenumber);
                Logger.WriteDebugMessage("user should be able to entre Email and firstname");
                Admin.Click_Button_MemberSearch();
                VerifyTextOnPage(firstname);
                VerifyTextOnPage(cellphonenumber);
                Logger.WriteDebugMessage("Member found.");

                //33.Enter partial character from captured first name and mobile phone number.Click on search.
                data0 = String.Concat(Partialfirstname[0].ToString(), Partialfirstname[1].ToString(), Partialfirstname[2].ToString());
                data1 = String.Concat(Partialcellphonenumber[0].ToString(), Partialcellphonenumber[1].ToString(), Partialcellphonenumber[2].ToString());
                Admin.EnterFirstname(data0);
                Admin.EnterPhone(data1);
                Logger.WriteDebugMessage("user should be able to entre Email and firstname");
                Admin.Click_Button_MemberSearch();
                VerifyTextOnPage(data0);
                VerifyTextOnPage(data1);
                Logger.WriteDebugMessage("Member found and It should match with database.Query is available in Description");


                //34.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                Logger.WriteDebugMessage("Search cleared.");

                //35.Enter Data on serach fields. Click on clear search.
                string Membernumber = Queries.ReturnCommonDataForSearch("LoyaltyMemberID");
                string Firstname = Queries.ReturnCommonDataForSearch("MemberFirstName");
                string Lastname = Queries.ReturnCommonDataForSearch("MemberLastName");
                email = Queries.ReturnCommonDataForSearch("MemberEmail");
                string zip = Queries.ReturnCommonDataForSearch("ZipCode");
                string city = Queries.ReturnCommonDataForSearch("City");
                Admin.EnterMemberNumber(Membernumber);
                Admin.EnterFirstname(Firstname);
                Admin.EnterLastname(Lastname);
                Admin.EnterEmail(email);
                Admin.SelectCountry("United States", ProjectName);
                Admin.EnterZip(zip);
                Admin.EnterCity(city);
                Admin.Click_Button_MemberSearch();
                ValidateTextOnPage("Select One");
                Logger.WriteDebugMessage("The search criteria should be empty.Set back to default one.");

                //34.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                Logger.WriteDebugMessage("Search cleared.");

                //35.Select member type as loyalty.Click on search
                if (ProjectName.Equals("OmniHotels"))
                    Admin.EnterEmail(data.MemberEmail);
                else
                    Admin.SelectMemberType("Loyalty");
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Member result displayed.");

                //36.Enter filter for Member Level data For example Crystal/ CRY/ Mond
                string memberlevel = PageObject_Admin.Value_MemberLevel().GetAttribute("innerHTML");
                Admin.EnterFilter(memberlevel);
                Logger.WriteDebugMessage("All row which contains that character will get displayed");

                //37.Capture the data that display in title and Enter filter for title
                //38.Capture the data that display in Member number
                string membernumber = PageObject_Admin.Value_MemberNumber().GetAttribute("innerHTML");
                Admin.EnterFilter(membernumber);
                Logger.WriteDebugMessage("All row which contains that character will get displayed");

                //39.Capture the data that display in status and Enter filter for status for example: Act , Active, Tive
                string memberstatus = PageObject_Admin.Value_Status().GetAttribute("innerHTML");
                Admin.EnterFilter(memberstatus);
                Logger.WriteDebugMessage("All row which contains that character will get displayed");
            }
        }

        public static void TC_221395()
        {
            if (TestCaseId == Constants.TC_221395)
            {
                Users data = new Users();
                Queries.GetActiveMemberEmail(data);

                //1 URL is available in master test plan run description:Login as Admin in backend
                //2.Navigate to member search.                
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Select member type as loyalty.Click on search
                if (ProjectName.Equals("OmniHotels"))
                    Admin.EnterEmail(data.MemberEmail);
                else
                    Admin.SelectMemberType("Loyalty");
                Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Loyalty Member type members found .");

                //4.Select" select one" from member type dropdown .click on search
                Admin.SelectMemberType("Select One");
                Logger.WriteDebugMessage("user should be able to Select 'select one' from member type dropdown");
                Admin.Click_Button_MemberSearch();
                VerifyTextOnPage(Constants.ValidationMessageNoMemberData);
                Logger.WriteDebugMessage("'No member data available please update search' message displayed.");

                //5.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                Logger.WriteDebugMessage("Search cleared.");

                //6.Select "active" from member status dropdown.Click on search
                Admin.SelectMemberStatus("Active");
                Logger.WriteDebugMessage("user should be able to Select 'Active' from member status dropdown");
                Admin.Click_Button_MemberSearch();
                VerifyTextOnPage("Active");
                Logger.WriteDebugMessage("Active members only displayed.");

                //8.Select "Inactive" from member status dropdown.Click on search
                Admin.SelectMemberStatus("Inactive");
                Logger.WriteDebugMessage("user should be able to Select 'Inactive' from member status dropdown");
                Admin.Click_Button_MemberSearch();
                VerifyTextOnPage("Inactive");
                Logger.WriteDebugMessage("Inactive members only displayed.");

                //9.Select "Deactivate" from member status dropdown.Click on search
                Admin.SelectMemberStatus("Deactivated");
                Logger.WriteDebugMessage("user should be able to Select 'Deactivated' from member status dropdown");
                Admin.Click_Button_MemberSearch();
                VerifyTextOnPage("Deactivated");
                Logger.WriteDebugMessage("Deactivated members only displayed.");

                //10.select" select one" from award name dropdown. Click on search
                Admin.SelectMemberStatus("Select One");
                Admin.Click_Button_MemberSearch();
                ValidateTextOnPage(Constants.ValidationMessageNoMemberData);
                Logger.WriteDebugMessage("'No member data available please update search' message displayed.");

                //11.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                Logger.WriteDebugMessage("Search cleared.");

                //12.Select any one country from dropdown.Click on search
                Admin.SelectCountry("United States", ProjectName);
                Logger.WriteDebugMessage("user should be able to Select 'United States' from country dropdown");
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Loyalty Member type members found .");

                //13.Select" select one" from member type dropdown .click on search
                Admin.SelectCountry("Select One", ProjectName);
                Admin.Click_Button_MemberSearch();
                VerifyTextOnPage(Constants.ValidationMessageNoMemberData);
                Logger.WriteDebugMessage("'No member data available please update search' message displayed.");

                //14.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                Logger.WriteDebugMessage("Search cleared.");

                //15.Select any one country from dropdown.Click on search
                Admin.SelectCountry("United States", ProjectName);
                Logger.WriteDebugMessage("user should be able to Select 'United States' from country dropdown");
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Loyalty Member type members found .");

                //16.Select"state" from state dropdown.Click on search
                string state = Admin.AssignState(ProjectName);
                Admin.SelectState(state);
                Logger.WriteDebugMessage("user should be able to Select 'state' from State dropdown");
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Loyalty Member type members found .");

                //17.Select"select one" from country dropdown.  Click on search.
                Admin.SelectCountry("Select One", ProjectName);
                Admin.Click_Button_MemberSearch();
                string value = PageObject_Admin.Dropdown_State().GetAttribute("aria-expanded");
                if (value.Equals("false"))
                {
                    VerifyTextOnPage(Constants.ValidationMessageNoMemberData);
                    Logger.WriteDebugMessage("User could not select state.State should be disabled one.");
                }
                else
                {
                    Logger.WriteDebugMessage("User could select state.State is not disabled.");
                }
            }
        }

        /*

        //V3 Test cases are moved from V3 to Global
        public static void TC_113741()

        {
            if (TestCaseId == Constants.TC_113741)
            {
                Users data = new Users();
                Queries.GetActiveMemberEmail(data);

                //1 URL is available in master test plan run description:Login as Admin in backend
                //2.Navigate to member search.                
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Select member type as loyalty .
                if (ProjectName.Equals("SH") || ProjectName.Equals("WoodLoch"))
                    Admin.EnterEmail(data.MemberEmail);
                else
                    Admin.SelectMemberType("Loyalty");
                Logger.WriteDebugMessage("User is able to select loyalty from member type .");

                //4.Click on search
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Member result displayed.");

                //5.Capture an email address from search result.
                string email = PageObject_Admin.Value_Email().GetAttribute("innerHTML");
                Logger.WriteDebugMessage("Email address captured from member result.");

                //6.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Search cleared.");

                //7.Enter the captured email exactly on the email search .
                Admin.EnterEmail(email);
                AddDelay(5000);
                Logger.WriteDebugMessage("User able to enter email address.");

                //8.Click on search
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage(email);
                Logger.WriteDebugMessage("Member found.");

                //9.Enter partial character from captured email
                string[] partialemail = email.Split('@');
                Admin.EnterEmail(partialemail[0]);
                AddDelay(5000);
                Logger.WriteDebugMessage("User able to enter email address.");

                //10.Click on search
                Admin.Click_Button_MemberSearch();
                AddDelay(8000);
                VerifyTextOnPage(email);
                Logger.WriteDebugMessage(
                    "Member found and It should match with database.Query is available in Description");
            }
        }

        public static void TC_113742()

        {
            if (TestCaseId == Constants.TC_113742)
            {
                Users data = new Users();
                Queries.GetActiveMemberEmail(data);

                //1 URL is available in master test plan run description:Login as Admin in backend
                //2.Navigate to member search.                
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Select member type as loyalty.Click on search
                if (ProjectName.Equals("SH") || ProjectName.Equals("WoodLoch"))
                    Admin.EnterEmail(data.MemberEmail);
                else
                    Admin.SelectMemberType("Loyalty");
                Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Member result displayed.");

                //4.Capture the firstname address from search result.
                string firstname = PageObject_Admin.Value_FullName().GetAttribute("innerHTML");
                string[] partialFirstname = firstname.Split(' ');
                Logger.WriteDebugMessage("Firstname Captured.");

                //6.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Search cleared.");

                //7.Enter the captured firstname exactly on the search.Click on Search.
                Admin.EnterFirstname(partialFirstname[0]);
                AddDelay(5000);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage(firstname);
                Logger.WriteDebugMessage("Member found.");

                //9.Enter partial character from captured Firstname.Click on search               
                Admin.EnterFirstname(partialFirstname[0]);
                AddDelay(5000);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage(partialFirstname[0]);
                Logger.WriteDebugMessage(
                    "Member found and It should match with database.Query is available in Description");
            }
        }

        public static void TC_113743()
        {
            if (TestCaseId == Constants.TC_113743)
            {
                Users data = new Users();
                Queries.GetActiveMemberEmail(data);
                //1 URL is available in master test plan run description:Login as Admin in backend
                //2.Navigate to member search.                
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Select member type as loyalty.Click on search
                if (ProjectName.Equals("SH") || ProjectName.Equals("WoodLoch"))
                    Admin.EnterEmail(data.MemberEmail);
                else
                    Admin.SelectMemberType("Loyalty");
                Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Member result displayed.");

                //4.Capture the Lastname address from search result.
                string Lastname = PageObject_Admin.Value_FullName().GetAttribute("innerHTML");
                string[] partialLastname = Lastname.Split(' ');
                Logger.WriteDebugMessage("Firstname Captured.");

                //5.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Search cleared.");

                //6.Enter the captured Lastname exactly on the search.Click on Search.
                Admin.EnterLastname(lastName);
                AddDelay(5000);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage(Lastname);
                Logger.WriteDebugMessage("Member found.");

                //7.Enter partial character from captured Lastname.Click on search               
                Admin.EnterLastname(partialLastname[1]);
                AddDelay(5000);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage(partialLastname[1]);
                Logger.WriteDebugMessage(
                    "Member found and It should match with database.Query is available in Description");
            }
        }

        public static void TC_113744()
        {
            if (TestCaseId == Constants.TC_113744)
            {
                Users data = new Users();
                Queries.GetActiveMemberEmail(data);
                //1 URL is available in master test plan run description:Login as Admin in backend
                //2.Navigate to member search.                
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Select member type as loyalty.Click on search
                if (ProjectName.Equals("SH") || ProjectName.Equals("WoodLoch"))
                    Admin.EnterEmail(data.MemberEmail);
                else
                    Admin.SelectMemberType("Loyalty");
                Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Member result displayed.");

                //4.Capture the member Number from search result..
                string membernumber = PageObject_Admin.Value_MemberNumber().GetAttribute("innerHTML");
                char[] partialmembernumber = membernumber.ToCharArray();
                Logger.WriteDebugMessage("Member found.Member number Captured.");

                //5.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Search cleared.");

                //6.Enter the captured firstname exactly on the search.Click on Search.
                Admin.EnterMemberNumber(membernumber);
                AddDelay(5000);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage(membernumber);
                Logger.WriteDebugMessage("Member found.");

                //7.Enter partial character from captured member type.Click on search
                string data1 = String.Concat(partialmembernumber[0].ToString(),
                    partialmembernumber[1].ToString(), partialmembernumber[2].ToString());
                Admin.EnterMemberNumber(data1);
                AddDelay(5000);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage(data1);
                Logger.WriteDebugMessage(
                    "Member found and It should match with database.Query is available in Description");
            }
        }

        public static void TC_113745()
        {
            if (TestCaseId == Constants.TC_113745)
            {
                Users data = new Users();
                //Queries.GetActiveMemberEmail(data);
                //1 URL is available in master test plan run description:Login as Admin in backend
                //2.Navigate to member search.                
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Select member type as loyalty.Click on search
                if (ProjectName.Equals("SH") || ProjectName.Equals("WoodLoch"))
                    Admin.EnterEmail("test");
                else
                    Admin.SelectMemberType("Loyalty");
                Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Member result displayed.");

                //4.Capture the street address from search result.
                string Address = PageObject_Admin.Value_Address().GetAttribute("innerHTML");
                if (Address.Equals(""))
                {
                    Address = "Street Layout,Florida,USA";
                }

                string[] partialAddress = Address.Split(',');
                Logger.WriteDebugMessage("Member found.Member number Captured.");

                //5.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Search cleared.");

                //6.Enter the captured Address exactly on the search.Click on Search.
                Admin.EnterStreet(Address);
                AddDelay(5000);
                Admin.Click_Button_MemberSearch();

                AddDelay(5000);
                VerifyTextOnPage(Address);
                Logger.WriteDebugMessage("Member found.");

                //7.Enter partial character from captured member type.Click on search
                Admin.EnterStreet(partialAddress[1]);
                AddDelay(5000);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage(partialAddress[1]);
                Logger.WriteDebugMessage(
                    "Member found and It should match with database.Query is available in Description");
            }
        }

        public static void TC_113746()
        {
            if (TestCaseId == Constants.TC_113746)
            {
                Users data = new Users();
                Queries.GetActiveMemberEmail(data);

                //1 URL is available in master test plan run description:Login as Admin in backend
                //2.Navigate to member search.                
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Select member type as loyalty.Click on search
                if (ProjectName.Equals("SH") || ProjectName.Equals("WoodLoch"))
                    Admin.EnterEmail(data.MemberEmail);
                else
                    Admin.SelectMemberType("Loyalty");
                Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Member result displayed.");

                //4.Capture the city name from search result.
                string City = "Florida";
                char[] partialCity = City.ToCharArray();
                Logger.WriteDebugMessage("Member found.Member number Captured.");

                //5.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Search cleared.");

                //6.Enter the captured City exactly on the search.Click on Search.
                Admin.EnterCity(City);
                AddDelay(5000);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage(City);
                Logger.WriteDebugMessage("Member found.");

                //7.Enter partial character from captured member type.Click on search
                string data1 =
                    String.Concat(partialCity[0].ToString(), partialCity[1].ToString(), partialCity[2].ToString());
                Admin.Click_Button_ClearSearch();
                AddDelay(1500);
                Admin.EnterCity(data1);
                AddDelay(5000);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage(data1);
                Logger.WriteDebugMessage(
                    "Member found and It should match with database.Query is available in Description");
            }
        }

        public static void TC_113747()
        {
            if (TestCaseId == Constants.TC_113747)
            {
                Users data = new Users();
                Queries.GetActiveMemberEmail(data);
                //1 URL is available in master test plan run description:Login as Admin in backend
                //2.Navigate to member search.                
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Select member type as loyalty.Click on search
                if (ProjectName.Equals("SH") || ProjectName.Equals("WoodLoch"))
                    Admin.EnterEmail(data.MemberEmail);
                else
                    Admin.SelectMemberType("Loyalty");
                Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Member result displayed.");

                //4.Capture the zip code from search result.
                string Zip = "12365";
                char[] PartialZip = Zip.ToCharArray();
                Logger.WriteDebugMessage("Member found.Member number Captured.");

                //5.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Search cleared.");

                //6.Enter the captured City exactly on the search.Click on Search.
                Admin.EnterZip(Zip);
                AddDelay(5000);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage(Zip);
                Logger.WriteDebugMessage("Member found.");

                //7.Enter partial character from captured member type.Click on search
                string data1 =
                    String.Concat(PartialZip[0].ToString(), PartialZip[1].ToString(), PartialZip[2].ToString());
                Admin.EnterZip(data1);
                AddDelay(5000);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage(data1);
                Logger.WriteDebugMessage(
                    "Member found and It should match with database.Query is available in Description");
            }
        }

        public static void TC_113748()
        {
            if (TestCaseId == Constants.TC_113748)
            {
                Users data = new Users();
                Queries.GetActiveMemberEmail(data, ProjectName);

                char[] PartialCompany;
                //1 URL is available in master test plan run description:Login as Admin in backend
                //2.Navigate to member search.                
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Select member type as loyalty.Click on search
                if (ProjectName.Equals("SH") || ProjectName.Equals("WoodLoch"))
                    Admin.EnterEmail(data.MemberEmail);
                else
                    Admin.SelectMemberType("Loyalty");
                Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                Admin.Click_Button_MemberSearch();
                AddDelay(10000);
                Logger.WriteDebugMessage("Member result displayed.");

                //4.Capture the member number and  company  from search result.
                string MemberNumber = Queries.ReturnMultipleRecordforSearch("LoyaltyMemberID");
                string Company = Queries.ReturnMultipleRecordforSearch("Company");
                char[] PartialMemberNumber = MemberNumber.ToCharArray();
                if (!Company.Equals(""))
                {
                    PartialCompany = Company.ToCharArray();
                }
                else
                {
                    Company = "test";
                    PartialCompany = Company.ToCharArray();
                }

                Logger.WriteDebugMessage("Member found.Member number Captured.");

                //5.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Search cleared.");

                //6.Enter the captured member number  and company exactly on the search 
                Admin.EnterMemberNumber(MemberNumber);
                AddDelay(5000);
                if (!(ProjectName.Equals("SH") || ProjectName.Equals("AdareManor") || ProjectName.Equals("WoodLoch")))
                {
                    Admin.EnterCompany(Company);
                    AddDelay(5000);
                }

                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage(MemberNumber);
                if (!(ProjectName.Equals("SH") || ProjectName.Equals("AdareManor")))
                {
                    VerifyTextOnPage(Company);
                }

                Logger.WriteDebugMessage("Member found.");

                //7.Enter partial character from captured member type.Click on search
                string data0 = String.Concat(PartialMemberNumber[0].ToString(),
                    PartialMemberNumber[1].ToString(), PartialMemberNumber[2].ToString());
                string data1 = String.Concat(PartialCompany[0].ToString(),
                    PartialCompany[1].ToString(), PartialCompany[2].ToString());
                Admin.EnterMemberNumber(data0);
                AddDelay(5000);
                if (!(ProjectName.Equals("SH") || ProjectName.Equals("AdareManor") || ProjectName.Equals("WoodLoch")))
                    Admin.EnterCompany(data1);

                AddDelay(5000);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage(data0);
                if (!ProjectName.Equals("SH") || !ProjectName.Equals("AdareManor"))
                {
                    VerifyTextOnPage(data1);
                }

                Logger.WriteDebugMessage(
                    "Member found and It should match with database.Query is available in Description");
            }
        }

        public static void TC_113749()
        {
            if (TestCaseId == Constants.TC_113749)
            {
                Users data = new Users();
                Queries.GetActiveMemberEmail(data);
                //1 URL is available in master test plan run description:Login as Admin in backend
                //2.Navigate to member search.                
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Select member type as loyalty.Click on search
                if (ProjectName.Equals("SH") || ProjectName.Equals("WoodLoch"))
                    Admin.EnterEmail(data.MemberEmail);
                else
                    Admin.SelectMemberType("Loyalty");
                Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Member result displayed.");

                //4.Capture the Cardname from search result.
                string Cardname = PageObject_Admin.Value_CardName().GetAttribute("innerHTML");
                Logger.WriteDebugMessage("Member found.Cardname Captured.");

                //5.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Search cleared.");

                //6.Enter the captured Cardname exactly on the search.Click on Search.
                Admin.EnterCardName(Cardname);
                AddDelay(5000);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage(Cardname);
                Logger.WriteDebugMessage("Member found.");

                //7.Enter partial character from captured Cardname .Click on search               
                Admin.EnterCardName(Cardname);
                AddDelay(5000);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage(Cardname);
                Logger.WriteDebugMessage(
                    "Member found and It should match with database.Query is available in Description");
            }
        }

        public static void TC_113751()
        {
            if (TestCaseId == Constants.TC_113751)
            {
                Users data = new Users();
                Queries.GetActiveMemberEmail(data);

                //1 URL is available in master test plan run description:Login as Admin in backend
                //2.Navigate to member search.                
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Select member type as loyalty.Click on search
                if (ProjectName.Equals("SH") || ProjectName.Equals("WoodLoch"))
                    Admin.EnterEmail(data.MemberEmail);
                else
                    Admin.SelectMemberType("Loyalty");
                Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Member result displayed.");

                //4.Capture the mobile phone number from search result.
                string cellphonenumber = Queries.ReturnMultipleRecordforSearch("CellPhoneNumber");
                Logger.WriteDebugMessage("Member found.Member number Captured.");

                //5.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Search cleared.");

                //6.Capture the mobile phone number from search result.
                Admin.EnterPhone(cellphonenumber);
                AddDelay(5000);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage(cellphonenumber);
                Logger.WriteDebugMessage("Member found.");
            }
        }

        public static void TC_113752()
        {
            if (TestCaseId == Constants.TC_113752)
            {
                Users data = new Users();
                Queries.GetActiveMemberEmail(data);

                //1 URL is available in master test plan run description:Login as Admin in backend
                //2.Navigate to member search.                
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Select member type as loyalty.Click on search
                if (ProjectName.Equals("SH") || ProjectName.Equals("WoodLoch"))
                    Admin.EnterEmail(data.MemberEmail);
                else
                    Admin.SelectMemberType("Loyalty");
                Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Member result displayed.");

                //4.Capture the First name and last name from search result.
                string firstname = Queries.ReturnMultipleRecordforSearch("MemberFirstName");
                string lastname = Queries.ReturnMultipleRecordforSearch("MemberLastName");
                char[] Partialfirstname = firstname.ToCharArray();
                char[] Partiallastname = lastname.ToCharArray();
                Logger.WriteDebugMessage("Member found.Member number Captured.");

                //5.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Search cleared.");

                //6.Enter the captured First name and last name exactly on the search . 
                Admin.EnterFirstname(firstname);
                AddDelay(5000);
                Admin.EnterLastname(lastname);
                AddDelay(5000);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage(firstname);
                VerifyTextOnPage(lastname);
                Logger.WriteDebugMessage("Member found.");

                //7.Enter partial character from captured first name and last name . Click on search.
                string data0 = String.Concat(Partialfirstname[0].ToString(),
                    Partialfirstname[1].ToString(), Partialfirstname[2].ToString());
                string data1 = String.Concat(Partiallastname[0].ToString(),
                    Partiallastname[1].ToString(), Partiallastname[2].ToString());
                Admin.EnterFirstname(data0);
                AddDelay(5000);
                Admin.EnterLastname(data1);
                AddDelay(5000);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage(data0);
                VerifyTextOnPage(data1);
                Logger.WriteDebugMessage(
                    "Member found and It should match with database.Query is available in Description");
            }
        }

        public static void TC_113753()
        {
            if (TestCaseId == Constants.TC_113753)
            {
                Users data = new Users();
                Queries.GetActiveMemberEmail(data);

                //1 URL is available in master test plan run description:Login as Admin in backend
                //2.Navigate to member search.                
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Select member type as loyalty.Click on search
                if (ProjectName.Equals("SH") || ProjectName.Equals("WoodLoch"))
                    Admin.EnterEmail(data.MemberEmail);
                else
                    Admin.SelectMemberType("Loyalty");
                Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Member result displayed.");

                //4.Capture the member number and last name from search result.
                string membershipNumber = Queries.ReturnMultipleRecordforSearch("LoyaltyMemberID");
                string lastname = Queries.ReturnMultipleRecordforSearch("MemberLastName");
                char[] PartialmembershipNumber = membershipNumber.ToCharArray();
                char[] Partiallastname = lastname.ToCharArray();
                Logger.WriteDebugMessage("Member found.Member number Captured.");

                //5.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Search cleared.");

                //6.Enter the captured mobile phone number exactly on the search .
                Admin.EnterMemberNumber(membershipNumber);
                AddDelay(5000);
                Admin.EnterLastname(lastname);
                AddDelay(5000);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage(membershipNumber);
                VerifyTextOnPage(lastname);
                Logger.WriteDebugMessage("Member found.");

                //7.Enter partial character from captured member number and last name .Click on search.
                string data0 = String.Concat(PartialmembershipNumber[0].ToString(),
                    PartialmembershipNumber[1].ToString(), PartialmembershipNumber[2].ToString());
                string data1 = String.Concat(Partiallastname[0].ToString(),
                    Partiallastname[1].ToString(), Partiallastname[2].ToString());
                Admin.EnterMemberNumber(data0);
                AddDelay(5000);
                Admin.EnterLastname(data1);
                AddDelay(5000);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage(data0);
                VerifyTextOnPage(data1);
                Logger.WriteDebugMessage(
                    "Member found and It should match with database.Query is available in Description");
            }
        }

        public static void TC_113754()
        {
            if (TestCaseId == Constants.TC_113754)
            {
                Users data = new Users();
                Queries.GetActiveMemberEmail(data);

                //1 URL is available in master test plan run description:Login as Admin in backend
                //2.Navigate to member search.                
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Select member type as loyalty.Click on search
                if (ProjectName.Equals("SH") || ProjectName.Equals("WoodLoch"))
                    Admin.EnterEmail(data.MemberEmail);
                else
                    Admin.SelectMemberType("Loyalty");
                Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Member result displayed.");

                //4.Capture the first name and email from search result.
                string firstname = Queries.ReturnMultipleRecordforSearch("MemberFirstName");
                string email = Queries.ReturnMultipleRecordforSearch("MemberEmail");
                char[] Partialfirstname = firstname.ToCharArray();
                char[] Partialemail = email.ToCharArray();
                Logger.WriteDebugMessage("Member found.Member number Captured.");

                //5.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Search cleared.");

                //6.Enter the captured first name and email number exactly on the search .
                Admin.EnterFirstname(firstname);
                AddDelay(5000);
                Admin.EnterEmail(email);
                AddDelay(5000);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage(firstname);
                VerifyTextOnPage(email);
                Logger.WriteDebugMessage("Member found.");

                //7.Enter partial character from captured first name and email address.Click on search.
                string data0 = String.Concat(Partialfirstname[0].ToString(),
                    Partialfirstname[1].ToString(), Partialfirstname[2].ToString());
                string data1 =
                    String.Concat(Partialemail[0].ToString(),
                        Partialemail[1].ToString(), Partialemail[2].ToString());
                Admin.EnterFirstname(data0);
                AddDelay(5000);
                Admin.EnterEmail(data1);
                AddDelay(5000);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage(data0);
                VerifyTextOnPage(data1);
                Logger.WriteDebugMessage(
                    "Member found and It should match with database.Query is available in Description");
            }
        }

        public static void TC_113755()
        {
            if (TestCaseId == Constants.TC_113755)
            {
                Users data = new Users();
                Queries.GetActiveMemberEmail(data);

                //1 URL is available in master test plan run description:Login as Admin in backend
                //2.Navigate to member search.                
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Select member type as loyalty.Click on search
                if (ProjectName.Equals("SH") || ProjectName.Equals("WoodLoch"))
                    Admin.EnterEmail(data.MemberEmail);
                else
                    Admin.SelectMemberType("Loyalty");
                Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Member result displayed.");

                //4.Capture the first name and mobile phone number from search result.
                string firstname = Queries.ReturnMultipleRecordforSearch("MemberFirstName");
                string cellphonenumber = Queries.ReturnMultipleRecordforSearch("CellPhoneNumber");
                char[] Partialfirstname = firstname.ToCharArray();
                char[] Partialcellphonenumber = cellphonenumber.ToCharArray();
                Logger.WriteDebugMessage("Member found.Member number Captured.");

                //5.Clear the search criteria.
                Admin.Click_Button_ClearSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Search cleared.");

                //6.Enter the captured first name and mobile phone number exactly on the search .
                Admin.EnterFirstname(firstname);
                AddDelay(5000);
                Admin.EnterPhone(cellphonenumber);
                AddDelay(5000);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage(firstname);
                VerifyTextOnPage(cellphonenumber);
                Logger.WriteDebugMessage("Member found.");

                //7.Enter partial character from captured first name and mobile phone number.Click on search.
                string data0 = String.Concat(Partialfirstname[0].ToString(),
                    Partialfirstname[1].ToString(), Partialfirstname[2].ToString());
                string data1 = String.Concat(Partialcellphonenumber[0].ToString(),
                    Partialcellphonenumber[1].ToString(), Partialcellphonenumber[2].ToString());
                Admin.EnterFirstname(data0);
                AddDelay(5000);
                Admin.EnterPhone(data1);
                AddDelay(5000);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage(data0);
                VerifyTextOnPage(data1);
                Logger.WriteDebugMessage(
                    "Member found and It should match with database.Query is available in Description");
            }
        }

        public static void TC_113757()
        {
            if (TestCaseId == Constants.TC_113757)
            {
                //1 URL is available in master test plan run description:Login as Admin in backend
                //2.Navigate to member search.                
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Verify all fields are displayed.
                VerifyTextOnPage(TestData.TC_113757_MemberType);
                VerifyTextOnPage(TestData.TC_113757_MemberNumber);
                VerifyTextOnPage(TestData.TC_113757_Lastname);
                VerifyTextOnPage(TestData.TC_113757_Firstname);
                VerifyTextOnPage(TestData.TC_113757_Email);
                VerifyTextOnPage(TestData.TC_113757_Street);
                VerifyTextOnPage(TestData.TC_113757_City);
                VerifyTextOnPage(TestData.TC_113757_Zip);
                VerifyTextOnPage(TestData.TC_113757_Country);
                VerifyTextOnPage(TestData.TC_113757_State);
                VerifyTextOnPage(TestData.TC_113757_AwardName);
                VerifyTextOnPage(TestData.TC_113757_AwardNumber);
                VerifyTextOnPage(TestData.TC_113757_CardName);
                VerifyTextOnPage(TestData.TC_113757_Company);
                VerifyTextOnPage(TestData.TC_113757_Phone);
                VerifyTextOnPage(TestData.TC_113757_MemberStatus);
                Logger.WriteDebugMessage("All fields found in member search page.");
            }
        }

        public static void TC_113758()
        {
            if (TestCaseId == Constants.TC_113758)
            {
                Users data = new Users();
                Queries.GetActiveMemberEmail(data);

                //1 URL is available in master test plan run description:Login as Admin in backend
                //2.Navigate to member search.                
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Select member type as loyalty.Click on search
                if (ProjectName.Equals("SH") || ProjectName.Equals("WoodLoch"))
                    Admin.EnterEmail(data.MemberEmail);
                else
                    Admin.SelectMemberType("Loyalty");
                Logger.WriteDebugMessage("User is able to select loyalty from member type .");
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Loyalty Member type members found .");

                //4.Select" select one" from member type dropdown .click on search
                Admin.SelectMemberType("Select One");
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage(Constants.ValidationMessageNoMemberData);
                Logger.WriteDebugMessage("'No member data available please update search' message displayed.");
            }
        }

        public static void TC_113760()
        {
            if (TestCaseId == Constants.TC_113760)
            {
                //1 URL is available in master test plan run description:Login as Admin in backend
                //2.Navigate to member search.                
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Select "active" from member status dropdown.Click on search
                Admin.SelectMemberStatus("Active");
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage("Active");
                Logger.WriteDebugMessage("Active members only displayed.");

                //4.Select "active" from member status dropdown.Click on search
                Admin.SelectMemberStatus("Active");
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage("Active");
                Logger.WriteDebugMessage("Active members only displayed.");

                //5.Select "Inactive" from member status dropdown.Click on search
                Admin.SelectMemberStatus("Inactive");
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage("Inactive");
                Logger.WriteDebugMessage("Inactive members only displayed.");

                //6.Select "Deactivate" from member status dropdown.Click on search
                Admin.SelectMemberStatus("Deactivated");
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage("Deactivated");
                Logger.WriteDebugMessage("Deactivated members only displayed.");

                //7.select" select one" from award name dropdown. Click on search
                Admin.SelectMemberStatus("Select One");
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                ValidateTextOnPage(Constants.ValidationMessageNoMemberData);
                Logger.WriteDebugMessage("'No member data available please update search' message displayed.");
            }
        }

        public static void TC_113761()
        {
            if (TestCaseId == Constants.TC_113761)
            {
                //1 URL is available in master test plan run description:Login as Admin in backend
                //2.Navigate to member search.                
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Select any one country from dropdown.Click on search
                if (ProjectName.Equals("WoodLoch"))
                    Admin.SelectCountry("UNITED STATES", ProjectName);
                else
                    Admin.SelectCountry("United States", ProjectName);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Loyalty Member type members found .");

                //4.Select" select one" from member type dropdown .click on search
                Admin.SelectCountry("Select One", ProjectName);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                VerifyTextOnPage(Constants.ValidationMessageNoMemberData);
                Logger.WriteDebugMessage("'No member data available please update search' message displayed.");
            }
        }

        public static void TC_113762()
        {
            if (TestCaseId == Constants.TC_113762)
            {
                //1 URL is available in master test plan run description:Login as Admin in backend
                //2.Navigate to member search.                
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Select any one country from dropdown.Click on search
                if (ProjectName.Equals("WoodLoch"))
                    Admin.SelectCountry("UNITED STATES", ProjectName);
                else
                    Admin.SelectCountry("United States", ProjectName);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Loyalty Member type members found .");

                //4.Select"state" from state dropdown.Click on search
                string state = Admin.AssignState(ProjectName);
                Admin.SelectState(state);
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Loyalty Member type members found .");

                //5.Select"select one" from country dropdown.  Click on search.
                Admin.SelectCountry("Select One", ProjectName);
                Admin.Click_Button_MemberSearch();
                string value = PageObject_Admin.Dropdown_State().GetAttribute("Class");
                if (value.Contains("disabled"))
                {
                    AddDelay(5000);
                    VerifyTextOnPage(Constants.ValidationMessageNoMemberData);
                    Logger.WriteDebugMessage("User could not select state.State should be disabled one.");
                }
                else
                {
                    Logger.WriteDebugMessage("User could select state.State is not disabled.");
                }


            }
        }

        public static void TC_113763()
        {
            if (TestCaseId == Constants.TC_113763)
            {
                Users data = new Users();
                Queries.GetActiveMemberEmail(data);

                //1 URL is available in master test plan run description:Login as Admin in backend
                //2.Navigate to member search.                
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Select member type as loyalty.Click on search
                if (ProjectName.Equals("SH") || ProjectName.Equals("WoodLoch"))
                    Admin.EnterEmail(data.MemberEmail);
                else
                    Admin.SelectMemberType("Loyalty");
                Admin.Click_Button_MemberSearch();
                AddDelay(5000);
                Logger.WriteDebugMessage("Member result displayed.");

                //4.Enter filter for Member Level data For example Crystal/ CRY/ Mond
                string memberlevel = PageObject_Admin.Value_MemberLevel().GetAttribute("innerHTML");
                Admin.EnterFilter(memberlevel);
                AddDelay(10000);
                Logger.WriteDebugMessage("All row which contains that character will get displayed");

                //5.Capture the data that display in title and Enter filter for title

                //6.Capture the data that display in Member number
                string membernumber = PageObject_Admin.Value_MemberNumber().GetAttribute("innerHTML");
                Admin.EnterFilter(membernumber);
                AddDelay(10000);
                Logger.WriteDebugMessage("All row which contains that character will get displayed");

                //6.Capture the data that display in status and Enter filter for status for example: Act , Active, Tive
                string memberstatus = PageObject_Admin.Value_Status().GetAttribute("innerHTML");
                Admin.EnterFilter(memberstatus);
                AddDelay(10000);
                Logger.WriteDebugMessage("All row which contains that character will get displayed");
            }
        }

        public static void TC_114570()
        {
            if (TestCaseId == Constants.TC_114570)
            {
                //1 URL is available in master test plan run description:Login as Admin in backend
                //2.Navigate to member search.  
                //3.Check member search buttons are in default one.
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(TestData.CommonAdminEmail, TestData.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");

                //3.Enter Data on serach fields. Click on clear search.
                string Membernumber = Queries.ReturnCommonDataForSearch("LoyaltyMemberID");
                string Firstname = Queries.ReturnCommonDataForSearch("MemberFirstName");
                string Lastname = Queries.ReturnCommonDataForSearch("MemberLastName");
                string email = Queries.ReturnCommonDataForSearch("MemberEmail");
                string zip = Queries.ReturnCommonDataForSearch("ZipCode");
                string city = Queries.ReturnCommonDataForSearch("City");
                Admin.EnterMemberNumber(Membernumber);
                Admin.EnterFirstname(Firstname);
                Admin.EnterLastname(Lastname);
                Admin.EnterEmail(email);
                if (ProjectName.Equals("WoodLoch"))
                    Admin.SelectCountry("UNITED STATES", ProjectName);
                else
                    Admin.SelectCountry("United States", ProjectName);
                Admin.EnterZip(zip);
                Admin.EnterCity(city);
                Admin.Click_Button_MemberSearch();
                AddDelay(3000);
                ValidateTextOnPage("Select One");
                Logger.WriteDebugMessage("The search criteria should be empty.Set back to default one.");
            }
        }

        */
        #endregion TP_171074
    }
}
