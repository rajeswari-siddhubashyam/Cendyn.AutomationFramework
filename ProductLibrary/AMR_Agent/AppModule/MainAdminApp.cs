using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMR_Agent.AppModule.UI;
using AMR_Agent.PageObject.UI;
using AMR_Agent.Utility;
using InfoMessageLogger;
using NUnit.Framework;

namespace AMR_Agent.AppModule.MainAdminApp
{
    public partial class MainAdminApp : AMR_Agent.Utility.Setup
    {
        private static string StoredContent { get; set; }
        private static string bookingNum { get; set; }
        public static string BookingMadeWith = "";
        public static string BookingNumber = "";
        public static string Firstname = "";
        public static string Lastname = "";
        public static string DateBooked = "";
        public static string Arrival = "";
        public static string departure = "";
        public static string BrandName = "";
        public static string ResortName = "";
        public static string BookedEnteredByAgent = "";
        public static string DepartureGateway = "";
        public static string UpdateSubmitBookingMatch = "";
        public static string ResortId = "";

        public static void GotoAdminSite()
        {
            Driver.Navigate().GoToUrl(Constants.Common_AdminURL);
        }

        public static void GotoFrontEndSite()
        {
            Driver.Navigate().GoToUrl(Constants.Common_FrontendURL);
        }

        public static void AcceptConsenttoCookies()
        {
            EnterFrame("defaultpreferencemanager");
            Login.ClickAgreeandProceed();
            Login.ClickClose();
        }
        public static void ConfirmRegistration()
        {
            try
            {
                PageObject_Registration.RegisterRegistrationEnrollMe().Click();
                PageObject_Registration.Register_RegistrationAccept().Click();
            }
            catch (Exception e)
            {

            }

        }
        public static void ValidLogin()
        {
            AddDelay(5000);
            //Enter the login email and password.
            Login.EnterEmail(Constants.Common_FrontEndEmail);
            Login.EnterPassword(Constants.Common_FrontEndPass);

            //Click "Sign In"
            PageObject_Login.LoginSignIn().Click();
            AddDelay(10000);
            Driver.Navigate().GoToUrl(Constants.Common_FrontendURL);
            Logger.WriteInfoMessage("Clicked the 'Sign In' button'");
            if (!PageObject_AMRAgentsNav.AMRAgentsLogOff().Displayed)
            {
                Logger.WriteFatalMessage("Did not log in sucessfully.");
                Assert.Fail();
            }

        }

        public static void ParameterizedLogin(string email, string password)
        {
            //Enter the login email and password.
            AddDelay(5000);
            Login.EnterEmail(email);
            Login.EnterPassword(password);
            Logger.WriteDebugMessage("User name and Password entered");

            //Click "Sign In"
            PageObject_Login.LoginSignIn().Click();
            AddDelay(10000);
            Driver.Navigate().GoToUrl(Constants.Common_FrontendURL);
            Logger.WriteInfoMessage("Clicked the 'Sign In' button'");
            if (!PageObject_AMRAgentsNav.AMRAgentsLogOff().Displayed)
            {
                Logger.WriteFatalMessage("Did not log in sucessfully.");
                Assert.Fail();
            }

        }

        public static void ValidAdminLogin()
        {

            //Enter the login email and password.
            PageObject_AdminLogin.AdminLoginEmail().SendKeys(Constants.Common_AdminEmail);
            AddDelay(2000);
            PageObject_AdminLogin.AdminLoginPassword().SendKeys(Constants.Common_AdminPassword);
            AddDelay(2000);

            //Click "Sign In"
            PageObject_AdminLogin.AdminLoginSignIn().Click();
            AddDelay(10000);
        }
        public static void TP_38860()
        {
            if (TestCaseId == Constants.TC_37501) TC_37501();
            else if (TestCaseId == Constants.TC_37502) TC_37502();
            else if (TestCaseId == Constants.TC_37504) TC_37504();
            else if (TestCaseId == Constants.TC_37509) TC_37509();
            else if (TestCaseId == Constants.TC_37514) TC_37514();
            else if (TestCaseId == Constants.TC_37515) TC_37515();
            else if (TestCaseId == Constants.TC_37516) TC_37516();
            else if (TestCaseId == Constants.TC_37519) TC_37519();
            else if (TestCaseId == Constants.TC_42271) TC_42271();
        }
        public static void TP_38859()
        {
            if (TestCaseId == Constants.TC_27838) TC_27838();
            else if (TestCaseId == Constants.TC_37518) TC_37518();
            else if (TestCaseId == Constants.TC_37539) TC_37539();
            else if (TestCaseId == Constants.TC_37548) TC_37548();
            else if (TestCaseId == Constants.TC_37550) TC_37550();
            else if (TestCaseId == Constants.TC_37553) TC_37553();
            else if (TestCaseId == Constants.TC_37604) TC_37604();
            else if (TestCaseId == Constants.TC_37609) TC_37609();
            else if (TestCaseId == Constants.TC_37513) TC_37513();
            else if (TestCaseId == Constants.TC_37522) TC_37522();
            else if (TestCaseId == Constants.TC_37649) TC_37649();

        }
        public static void TP_273216()
        {
            if (TestCaseId == Constants.TC_281327) TC_281327();
        }

    }
}
