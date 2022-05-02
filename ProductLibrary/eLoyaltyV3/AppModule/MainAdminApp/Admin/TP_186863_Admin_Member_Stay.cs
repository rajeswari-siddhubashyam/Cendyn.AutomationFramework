using eLoyaltyV3.AppModule.UI;
using Constants = eLoyaltyV3.Utility.Constants;
using eLoyaltyV3.Entity;
using BaseUtility.Utility;
using InfoMessageLogger;
using Queries = eLoyaltyV3.Utility.Queries;
using eLoyaltyV3.PageObject.Admin;
using TestData;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Utility.Setup
    {
        #region TP_186863 - Admin Member Stay
        public static void TC_124508()
        {
            if (TestCaseId == Constants.TC_124508)
            {
                Users data = new Users();
                //Prerequisites:
                //1.User has logged in to Guest Profile application with valid credentials.
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                Queries.ReturnEmail_WithStay(data);
                Admin.EnterEmail(data.eMail);
                Logger.WriteDebugMessage("Email Entered");
                Admin.Click_Button_MemberSearch();
                Logger.WriteDebugMessage("Result Displayed on Member Search");
                AddDelay(5000);
                Admin.Click_Icon_View(ProjectName);
                Logger.WriteDebugMessage("Land on the 'Member Information'.");
                Logger.LogTestData(TestPlanId, TestCaseId, "Email with Stay", data.eMail, true);
                Admin.Click_Tab_MemberStay();
                Logger.WriteDebugMessage("Land on the Member Stay.");
                AddDelay(20000);

                //1.Validate correct details displayed on Member Stays tab for following column headers.
                string Res = TestData.ExcelData.TestDataReader.ReadData(1, "Res");
                string StayStatus = TestData.ExcelData.TestDataReader.ReadData(1, "StayStatus");
                string Arrival = TestData.ExcelData.TestDataReader.ReadData(1, "Arrival");
                string Departure = TestData.ExcelData.TestDataReader.ReadData(1, "Departure");
                string Hotel = TestData.ExcelData.TestDataReader.ReadData(1, "Hotel");
                string Points = TestData.ExcelData.TestDataReader.ReadData(1, "Points");
                VerifyTextOnPageAndHighLight(Res);
                VerifyTextOnPageAndHighLight(StayStatus);
                VerifyTextOnPageAndHighLight(Arrival);
                VerifyTextOnPageAndHighLight(Departure);
                VerifyTextOnPageAndHighLight(Hotel);
                if (ProjectName != "SH")
                    VerifyTextOnPageAndHighLight(Points);
                Logger.WriteDebugMessage("Details for mentioned column header should be displayed correctly on Member Stays tab.");

                //2.Go to Database and run the below mentioned query:
                Queries.Return_DataAsPerEmail_Stay(data, data.eMail);
                string[] arrivaldate = data.ArrivalDate.Split('/');//DateTime.ParseExact(data.ArrivalDate, "yyyy-MM-dd", CultureInfo.InvariantCulture).ToString("dd/MM/yyyy");
                string[] departuredate = data.DepartureDate.Split('/');
                Admin.Enter_Text_Filter(arrivaldate[1]);
                AddDelay(20000);
                VerifyTextOnPageAndHighLight(arrivaldate[1]);
                Logger.WriteDebugMessage("Same result should be displayed in database as displaying on Member Stays page." + arrivaldate);
                Admin.Enter_Text_Filter(departuredate[1]);
                AddDelay(20000);
                VerifyTextOnPageAndHighLight(departuredate[1]);
                Logger.WriteDebugMessage("Same result should be displayed in database as displaying on Member Stays page." + departuredate);
            }
        }

        public static void TC_124511()
        {
            if (TestCaseId == Constants.TC_124511)
            {
                Users data = new Users();
                //Prerequisites:
                //1.User has logged in to Guest Loyalty application with valid credentials.
                //2.User has searched for any member from dashboard and any Member Information has been opened in View Mode
                //3.User should be on Member Stays Page
                //4.More than 30 Stays records should be present.
                Helper.ElementWait(PageObject_Admin.Admin_Text_UserName(), 60);
                AdminLoginCredentials(ProjectDetails.CommonAdminEmail, ProjectDetails.CommonAdminPassword);
                Logger.WriteDebugMessage("Logged in successfully.");
                Queries.ReturnEmail_WithMaximumMyStays(data);
                Admin.EnterEmail(data.MemberEmail);
                Admin.Click_Button_MemberSearch();
                AddDelay(10000);
                Admin.Click_Icon_View(ProjectName);
                AddDelay(15000);
                Helper.ElementWait(PageObject_Admin.Tab_MemberStay(), 20);
                Logger.WriteDebugMessage("Land on the 'Member Information'.");
                Logger.LogTestData(TestPlanId, TestCaseId, "Email with Maxium Stay", data.MemberEmail);
                Admin.Click_Tab_MemberStay();
                Logger.WriteDebugMessage("Land on the Member Stay.");

                //1.Verify Entries drop down is displayed with total of 5 selections as below:
                Admin.VerifyEntriesDropdown();
                Logger.WriteDebugMessage("Entries drop down should display 5 mentioned selections");
                AddDelay(10000);

                int runningNumber = 5;
                for (int i = 1; i < 5; i++)
                {
                    string noOfRecord = runningNumber.ToString();
                    Admin.SelectEntries(noOfRecord);
                    AddDelay(20000);
                    Logger.WriteDebugMessage("Only " + noOfRecord + " items should be displayed at a time in the grid and ");
                    if(i==4)
                        Logger.LogTestData(TestPlanId, TestCaseId, i+"No of Records", noOfRecord, true);
                    else
                        Logger.LogTestData(TestPlanId, TestCaseId, i+"No of Records", noOfRecord);
                    Admin.Click_Arrow_Next();
                    AddDelay(20000);
                    Admin.Click_Arrow_Previous(ProjectName);
                    AddDelay(20000);
                    Logger.WriteDebugMessage("'Next' and 'Previous' work with no issues.");

                    if (runningNumber == 15)
                    {
                        Admin.Click_Text_PageNumber("2");
                        AddDelay(20000);
                        Admin.Click_Arrow_Previous(ProjectName);
                        Logger.WriteDebugMessage("User should land directly on that number with the proper results displaying. ");
                    }
                    runningNumber = runningNumber + 5;
                }
            }
        }
        #endregion
    }
}
