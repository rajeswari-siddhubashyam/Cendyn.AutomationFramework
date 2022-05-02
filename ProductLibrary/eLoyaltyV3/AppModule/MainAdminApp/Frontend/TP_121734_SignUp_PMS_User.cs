using System;
using eLoyaltyV3.Utility;
using eLoyaltyV3.AppModule.UI;
using System.Text.RegularExpressions;
using NUnit.Framework;
using Common;
using eLoyaltyV3.Entity;
using InfoMessageLogger;
using Constants = eLoyaltyV3.Utility.Constants;
using TestData;

namespace eLoyaltyV3.AppModule.MainAdminApp
{
    public partial class MainAdminApp : eLoyaltyV3.Utility.Setup
    {
        #region TP_121734 - Sign Up PMS User
        public static void TC_119748()
        {
            UserSignUpCRMAPI data = new UserSignUpCRMAPI();
            string DCStayStatus = "R";
            //1 Identify a Profile in PMS source who has Reserved stay status record and Register for that User in Loyalty Portal via CRMAPI

            string checkStayStatus = Queries.ReturnStayStatus(DCStayStatus);
            if (checkStayStatus == "Record does not exist in table.")
            {
                Logger.WriteInfoMessage("Customer Record with Stay Status as " + DCStayStatus + " does not exist Customer Stay Record");
                Assert.Ignore();
            }
            else
            {
                SignUp.CustomerSignUpAPIData(ProjectName, DCStayStatus, Constants.TC_119748, data);
                DateTime currentTime = DateTime.Now;
                DateTime x25MinsLater = currentTime.AddMinutes(25);

                Logger.WriteInfoMessage("Execution on Hold in order to have ETL to move data for MyStays Purpose. Holding time 25 minutes. Hold will be removed at " + x25MinsLater.ToString("MM/dd/yyy HH:mm:ss,fff"));
                Time.AddDelay(600000);
                Logger.WriteInfoMessage("Execution Hold is off and continuing execution.");

                Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);

                if (ProjectName != "AdareManor")
                {
                    //9 Log in using credentials
                    if (ProjectName.Equals("HotelIcon"))
                    {
                        Navigation.Click_Button_SignIn();
                    }
                    SignIn.LogIn(data.email, CommomPassword, ProjectName);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    //10 Verify Member Since date is todays date.
                    if (!ProjectName.Equals("NYLO"))
                        if (!ProjectName.Equals("Loews"))
                        {
                            Navigation.VerifyMemberSinceToday(ProjectName);
                            Logger.WriteDebugMessage("Member since date is todays date.");
                        }

                    //11 Verify the Stay is displayed on the members page.
                    Users resData = new Users();
                    Queries.ReturnStayValueFromColumnByEmail(data.email, DCStayStatus, resData);
                    Navigation.Click_Link_MyStays();                                       
                    string[] getResNum = Regex.Split(resData.ReservationNumber, ",");
                    foreach (string resNum in getResNum)
                    {
                        MyStays.UpcomingStays_VerifyConfirmationNumberDisplays(resNum, ProjectName, getResNum.Length);
                        Logger.WriteDebugMessage("The stay is displayed!");
                    }

                }
            }
        }

        public static void TC_119749()
        {
            UserSignUpCRMAPI data = new UserSignUpCRMAPI();
            string DCStayStatus = "I";

            string checkStayStatus = Queries.ReturnStayStatus(DCStayStatus);
            if (checkStayStatus == "Record does not exist in table.")
            {
                Logger.WriteInfoMessage("Customer Record with Stay Status as " + DCStayStatus + " does not exist Customer Stay Record");
                Assert.Ignore();
            }
            else
            {
                SignUp.CustomerSignUpAPIData(ProjectName, DCStayStatus, Constants.TC_119749, data);
                DateTime currentTime = DateTime.Now;
                DateTime x25MinsLater = currentTime.AddMinutes(25);

                Logger.WriteInfoMessage("Execution on Hold in order to have ETL to move data for MyStays Purpose. Holding time 25 minutes. Hold will be removed at " + x25MinsLater.ToString("MM/dd/yyy HH:mm:ss,fff"));
                Time.AddDelay(600000);
                Logger.WriteInfoMessage("Execution Hold is off and continuing execution.");

                Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);

                if (ProjectName != "AdareManor")
                {
                    //11.Log in using credentials
                    SignIn.LogIn(data.email, ProjectDetails.CommonFrontendPassword, ProjectName);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    //12.Verify Member Since date is todays date.
                    if (!ProjectName.Equals("NYLO"))
                        if (!ProjectName.Equals("Loews"))
                        {
                            Navigation.VerifyMemberSinceToday(ProjectName);
                            Logger.WriteDebugMessage("Member since date is todays date.");
                        }

                    //13 Verify the Stay is displayed on the members page.
                    Users resData = new Users();
                    Queries.ReturnStayValueFromColumnByEmail(data.email, DCStayStatus, resData);
                    Navigation.Click_Link_MyStays();                 
                    string[] getResNum = Regex.Split(resData.ReservationNumber, ",");
                    foreach (string resNum in getResNum)
                    {
                        MyStays.UpcomingStays_VerifyConfirmationNumberDisplays(resNum, ProjectName, getResNum.Length);
                        Logger.WriteDebugMessage("The stay is displayed!");
                    }

                }
            }
        }

        public static void TC_119750()
        {
            if (TestCaseId == Constants.TC_119750)
            {
                UserSignUpCRMAPI data = new UserSignUpCRMAPI();
                string DCStayStatus = "C";

                string checkStayStatus = Queries.ReturnStayStatus(DCStayStatus);
                if (checkStayStatus == "Record does not exist in table.")
                {
                    Logger.WriteInfoMessage("Customer Record with Stay Status as " + DCStayStatus + " does not exist Customer Stay Record");
                    Assert.Ignore();
                }
                else
                {
                    SignUp.CustomerSignUpAPIData(ProjectName, DCStayStatus, Constants.TC_119750, data);
                    DateTime currentTime = DateTime.Now;
                    DateTime x25MinsLater = currentTime.AddMinutes(25);

                    Logger.WriteInfoMessage("Execution on Hold in order to have ETL to move data for MyStays Purpose. Holding time 25 minutes. Hold will be removed at " + x25MinsLater.ToString("MM/dd/yyy HH:mm:ss,fff"));
                    Time.AddDelay(600000);
                    Logger.WriteInfoMessage("Execution Hold is off and continuing execution.");

                    Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);

                    if (ProjectName != "AdareManor")
                    {
                        //11.Log in using credentials
                        SignIn.LogIn(data.email, ProjectDetails.CommonFrontendPassword, ProjectName);
                        Logger.WriteDebugMessage("Logged in successfully.");

                        //12.Verify Member Since date is todays date.
                        if (!ProjectName.Equals("NYLO"))
                            if (!ProjectName.Equals("Loews"))
                            {
                                //Navigation.VerifyMemberSinceToday();
                                Logger.WriteDebugMessage("Member since date is todays date.");
                            }

                        //13.Verify the Stay is displayed on the members page.
                        Users resData = new Users();
                        Queries.ReturnStayValueFromColumnByEmail(data.email, DCStayStatus, resData);
                         Navigation.Click_Link_MyStays();               
                        string[] getResNum = Regex.Split(resData.ReservationNumber, ",");
                        foreach (string resNum in getResNum)
                        {
                            MyStays.UpcomingStays_VerifyConfirmationNumberDisplays(resNum, ProjectName, getResNum.Length);
                            Logger.WriteDebugMessage("The stay is displayed!");
                        }
                    }
                }
            }
        }

        public static void TC_119751()
        {
            UserSignUpCRMAPI data = new UserSignUpCRMAPI();
            string DCStayStatus = "N";
            string checkStayStatus = Queries.ReturnStayStatus(DCStayStatus);
            if (checkStayStatus == "Record does not exist in table.")
            {
                Logger.WriteInfoMessage("Customer Record with Stay Status as " + DCStayStatus + " does not exist Customer Stay Record");
                Assert.Ignore();
            }
            else
            {
                SignUp.CustomerSignUpAPIData(ProjectName, DCStayStatus, Constants.TC_119751, data);
                DateTime currentTime = DateTime.Now;
                DateTime x25MinsLater = currentTime.AddMinutes(25);

                Logger.WriteInfoMessage("Execution on Hold in order to have ETL to move data for MyStays Purpose. Holding time 25 minutes. Hold will be removed at " + x25MinsLater.ToString("MM/dd/yyy HH:mm:ss,fff"));
                Time.AddDelay(600000);
                Logger.WriteInfoMessage("Execution Hold is off and continuing execution.");

                Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);

                if (ProjectName != "AdareManor")
                {
                    //11.Log in using credentials
                    SignIn.LogIn(data.email, ProjectDetails.CommonFrontendPassword, ProjectName);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    //12.Verify Member Since date is todays date.
                    if (!ProjectName.Equals("NYLO"))
                        if (!ProjectName.Equals("Loews"))
                        {
                            Navigation.VerifyMemberSinceToday(ProjectName);
                            Logger.WriteDebugMessage("Member since date is todays date.");
                        }

                    //13.Verify the Stay is displayed on the members page.
                    Users resData = new Users();
                    Queries.ReturnStayValueFromColumnByEmail(data.email, DCStayStatus, resData);
                     Navigation.Click_Link_MyStays();          
                    string[] getResNum = Regex.Split(resData.ReservationNumber, ",");
                    foreach (string resNum in getResNum)
                    {
                        MyStays.UpcomingStays_VerifyConfirmationNumberDisplays(resNum, ProjectName, getResNum.Length);
                        Logger.WriteDebugMessage("The stay is displayed!");
                    }
                }
            }

        }

        public static void TC_119752()
        {
            UserSignUpCRMAPI data = new UserSignUpCRMAPI();
            string DCStayStatus = "SameNameAndEmail";
            //1 Identify a Profile in PMS source who has Reserved stay status record
            Queries.ReturnGuestEmailInPMSSameNameAndEmail_Test(data);

            if (data.email == null)
            {
                Assert.Fail("Could not find any stay record for PMS Record.");
            }
            else
            {
                SignUp.CustomerSignUpAPIData(ProjectName, DCStayStatus, Constants.TC_119752, data);
                DateTime currentTime = DateTime.Now;
                DateTime x25MinsLater = currentTime.AddMinutes(25);

                Logger.WriteInfoMessage("Execution on Hold in order to have ETL to move data for MyStays Purpose. Holding time 25 minutes. Hold will be removed at " + x25MinsLater.ToString("MM/dd/yyy HH:mm:ss,fff"));
                Time.AddDelay(600000);
                Logger.WriteInfoMessage("Execution Hold is off and continuing execution.");

                Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);

                if (ProjectName != "AdareManor")
                {
                    //9 Log in using credentials
                    Logger.WriteInfoMessage("Found un-registered guest email address - " + data.email + " with a stay ");
                    SignIn.LogIn(data.email, ProjectDetails.CommonFrontendPassword, ProjectName);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    //10 Verify Member Since date is todays date.
                    if (!ProjectName.Equals("NYLO"))
                        if (!ProjectName.Equals("Loews"))
                        {
                            Navigation.VerifyMemberSinceToday(ProjectName);
                            Logger.WriteDebugMessage("Member since date is todays date.");
                        }

                    //11 Verify the Stay is displayed on the members page.
                    Users resData = new Users();
                    Queries.ReturnStayValueFromColumnByEmail(data.email, "", resData);                   
                    Navigation.Click_Link_MyStays();                   
                    string[] getResNum = Regex.Split(resData.ReservationNumber, ",");
                    foreach (string resNum in getResNum)
                    {
                        MyStays.UpcomingStays_VerifyConfirmationNumberDisplays(resNum, ProjectName, getResNum.Length);
                        ScrollDownUsingJavaScript(Driver, 700);
                        Logger.WriteDebugMessage("The stay is displayed!");
                    }

                }
            }

        }

        public static void TC_119753()
        {
            UserSignUpCRMAPI data = new UserSignUpCRMAPI();
            string DCStayStatus = "SameEmailDifferentName";
            //1 Identify a Profile in PMS source who has Reserved stay status record
            Queries.ReturnGuestEmailInPMSSameEmailDifferentName_Test(data);

            if (data.email == null)
            {
                Assert.Fail("Could not find any stay record for PMS Data Source.");
            }
            else
            {
                SignUp.CustomerSignUpAPIData(ProjectName, DCStayStatus, Constants.TC_119754, data);
                DateTime currentTime = DateTime.Now;
                DateTime x25MinsLater = currentTime.AddMinutes(25);

                Logger.WriteInfoMessage("Execution on Hold in order to have ETL to move data for MyStays Purpose. Holding time 25 minutes. Hold will be removed at " + x25MinsLater.ToString("MM/dd/yyy HH:mm:ss,fff"));
                Time.AddDelay(600000);
                Logger.WriteInfoMessage("Execution Hold is off and continuing execution.");

                Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);

                if (ProjectName != "AdareManor")
                {
                    //9 Log in using credentials
                    Logger.WriteInfoMessage("Found un-registered guest email address - " + data.email + " with a stay ");
                    SignIn.LogIn(data.email, ProjectDetails.CommonFrontendPassword, ProjectName);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    //10 Verify Member Since date is todays date.
                    if (!ProjectName.Equals("NYLO"))
                        if (!ProjectName.Equals("Loews"))
                        {
                            Navigation.VerifyMemberSinceToday(ProjectName);
                            Logger.WriteDebugMessage("Member since date is todays date.");
                        }

                    //11 Verify the Stay is displayed on the members page.
                    Users resData = new Users();
                    Queries.ReturnStayValueFromColumnByEmail(data.email, "", resData);                
                        Navigation.Click_Link_MyStays();                    
                    string[] getResNum = Regex.Split(resData.ReservationNumber, ",");
                    foreach (string resNum in getResNum)
                    {
                        MyStays.UpcomingStays_VerifyConfirmationNumberDisplays(resNum, ProjectName, getResNum.Length);
                        ScrollDownUsingJavaScript(Driver, 600);
                        Logger.WriteDebugMessage("The stay is displayed!");
                    }
                }
            }
        }

        public static void TC_119754()
        {
            UserSignUpCRMAPI data = new UserSignUpCRMAPI();
            string DCStayStatus = "SameEmailDifferentName";

            //1 Identify a Profile in PMS source who has Reserved stay status record
            Queries.ReturnGuestEmailInPMSameEmailDifferentName_Test(data);

            if (customerID == null)
            {
                Assert.Fail("Could not find any stay record for PMS Data Source.");
            }
            else
            {
                SignUp.CustomerSignUpAPIData(ProjectName, DCStayStatus, Constants.TC_119754, data);
                DateTime currentTime = DateTime.Now;
                DateTime x25MinsLater = currentTime.AddMinutes(25);

                Logger.WriteInfoMessage("Execution on Hold in order to have ETL to move data for MyStays Purpose. Holding time 25 minutes. Hold will be removed at " + x25MinsLater.ToString("MM/dd/yyy HH:mm:ss,fff"));
                Time.AddDelay(600000);
                Logger.WriteInfoMessage("Execution Hold is off and continuing execution.");

                Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);

                if (ProjectName != "AdareManor")
                {
                    //9 Log in using credentials
                    Logger.WriteInfoMessage("Found un-registered guest email - " + data.email + " with a stay ");
                    SignIn.LogIn(data.email, ProjectDetails.CommonFrontendPassword, ProjectName);
                    Logger.WriteDebugMessage("Logged in successfully.");

                    //10 Verify Member Since date is todays date.
                    if (!ProjectName.Equals("NYLO"))
                        if (!ProjectName.Equals("Loews"))
                        {
                            Navigation.VerifyMemberSinceToday(ProjectName);
                            
                        }

                    //11 Verify the Stay is displayed on the members page.
                    //Run SP to start ETL
                    try { Queries.Start_ETL(); AddDelay(6000); } catch (Exception) { AddDelay(300000); }
                    Users resData = new Users();
                    Queries.ReturnStayValueFromColumnByEmail(data.email, "", resData);                
                        Navigation.Click_Link_MyStays();                    
                    string[] getResNum = Regex.Split(resData.ReservationNumber, ",");
                    foreach (string resNum in getResNum)
                    {
                        MyStays.VerifyConfirmationNumberNotDisplays(resNum, ProjectName, getResNum.Length);
                        Logger.WriteDebugMessage("Stay should not get displayed!");
                    }
                }
            }
        }

        #endregion TP_121734
    }
}
