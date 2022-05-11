using CMS.AppModule.UI;
using CMS.Entity;
using CMS.Utility;
using BaseUtility.Utility;
using Queries = CMS.Utility.Queries;
using System.Collections.Generic;
using InfoMessageLogger;
using TestData;
using OpenQA.Selenium;

namespace CMS.AppModule.MainAdminApp
{
    public partial class MainAdminApp : CMS.Utility.Setup
    {
        #region[TP_000000]
        public static void TC_000001()
        {
            if (TestCaseId == Constants.TC_000001)
            {

                

                //Navigate to Marketing Automation and log in as valid user
                Helper.WaitForAjaxControls(30);
                SignIn.LoginWithValidCredentials(Constants.FrontEndEmail, Constants.CommonPassword);
                Helper.WaitForAjaxControls(50);

                
            }
        }
        #endregion
    }
}
