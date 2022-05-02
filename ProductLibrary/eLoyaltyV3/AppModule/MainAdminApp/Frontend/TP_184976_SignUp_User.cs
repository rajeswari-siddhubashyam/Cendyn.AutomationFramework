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
        #region TP_184976 - Sign Up User
        public static void TC_184988()
        {
            UserSignUpCRMAPI data = new UserSignUpCRMAPI();
            double minutes = 10;
            int toMilliseconds = Convert.ToInt32(TimeSpan.FromMinutes(minutes).TotalMilliseconds);
            SignUp.SignUpDummyUser(data);

            /*
            DateTime currentTime = DateTime.Now;
            DateTime x25MinsLater = currentTime.AddMinutes(minutes);

            Logger.WriteInfoMessage("Execution on Hold in order to have ETL to move data for MyStays Purpose. Holding time " + minutes + " minutes. Hold will be removed at " + x25MinsLater.ToString("MM/dd/yyy HH:mm:ss,fff"));
            Time.AddDelay(toMilliseconds);
            Logger.WriteInfoMessage("Execution Hold is off and continuing execution after " + minutes + " minutes.");

            Driver.Navigate().GoToUrl(ProjectDetails.CommonFrontendURL);
            */
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
            }
        }

        #endregion TP_184976

    }
}
