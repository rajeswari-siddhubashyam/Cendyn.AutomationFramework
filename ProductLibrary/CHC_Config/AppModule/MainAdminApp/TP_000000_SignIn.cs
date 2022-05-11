using CHC_Config.AppModule.UI;
using CHC_Config.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHC_Config.AppModule.MainAdminApp
{
    public partial class MainAdminApp : CHC_Config.Utility.Setup
    {
        #region[TP_000000]
        public static void TC_000000()
        {
            if (TestCaseId == Constants.TC_000000)
            {
                //Step1 - Navigate to CHC and log in as a valid Admin user
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
            }
        }
        #endregion[TP_000000]
    }
}
