using System;
using eProposal.Utility;
using Common;
using BaseUtility.Utility;
using eProposal.PageObject.Admin;
using InfoMessageLogger;

namespace eProposal.AppModule.Admin
{
    internal class AdminLogin : Helper
    {
        public static void Click_Button_LogIn()
        {
            Helper.ElementClick(PageObject_AdminLogin.Button_LogIn());
        }

        public static void EnterText_Text_UserName(string text)
        {
            Helper.ElementEnterText(PageObject_AdminLogin.Text_UserName(), text);
        }

        public static void EnterText_Text_Password(string text)
        {
            Helper.ElementEnterText(PageObject_AdminLogin.Text_Password(), text);
        }

        /// <summary>
        ///     This method will log into ePFull Admin with the common credentials
        /// </summary>
        public static void LogInCommon()
        {
            EnterText_Text_UserName("development");
            EnterText_Text_Password("pxLb3MLhUQ");
            Click_Button_LogIn();
            AddDelay(2000);
            try
            {
                if (PageObject_AdminNavigation.Button_Properties().Displayed)
                    Logger.WriteInfoMessage("Logged into ePFull Admin successfully.");
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("Did not log in successfully.");
                throw;
            }
        }
    }
}