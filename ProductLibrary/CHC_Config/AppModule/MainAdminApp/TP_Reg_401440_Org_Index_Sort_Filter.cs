using CHC_Config.AppModule.UI;
using CHC_Config.Entity;
using CHC_Config.Utility;
using BaseUtility.Utility;
using Queries = CHC_Config.Utility.Queries;
using System.Collections.Generic;
using InfoMessageLogger;
using TestData;
using OpenQA.Selenium;
using System.Threading;
using CHC.PageObject.UI;

namespace CHC_Config.AppModule.MainAdminApp
{
    class TP_Reg_401440_Org_Index_Sort_Filter : CHC_Config.Utility.Setup
    {
        #region[TP_422702]
        public static void TC_326760()
        {
            if (TestCaseId == Constants.TC_326760)
            {
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Property ID", "Equal", "329");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Property", "Equal", "Property Hotel23");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Property", "Not Equal", "Property Hotel23");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Property", "Starts With", "p");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Property", "Ends With", "3");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Property", "Contains", "perty");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();                                

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Brand", "Equal", "Cendyn Property Brand");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Brand", "Not Equal", "Cendyn Property Brand");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Brand", "Stars With", "C");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Brand", "Ends With", "d");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Brand", "Contains", "perty");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Chain", "Equal", "Cendyn Property Chain");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Chain", "Not Equal", "Cendyn Property Chain");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Chain", "Stars With", "c");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Chain", "Ends With", "n");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Chain", "Contains", "operty");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();

                CreateUser.ClickonFilterbutton();
                CreateUser.Enter_FilterValues("Status", "Is", "Live");
                CreateUser.UserIndex_Clickon_Filter_Apply_button();
            }
        }

        public static void TC_326761()
        {
            if (TestCaseId == Constants.TC_326761)
            {
                SignIn.EnterEmailAddress(Constants.FrontEndEmail);
                SignIn.EnterPassword(Constants.CommonPassword);
                SignIn.ClickOnSignInButton();
                WaitTillBrowserLoad();
                Navigation.Click_Configurations_App();
                WaitTillBrowserLoad();

                CreateUser.ClickonSortbutton();
                CreateUser.Enter_SortValues("Order By", "Property ID");
                CreateUser.Enter_SortValues("Direction", "Least - Most");
                CreateUser.UserIndex_Clickon_Sort_Apply_button();

                CreateUser.ClickonSortbutton();
                CreateUser.Enter_SortValues("Order By", "Property ID");
                CreateUser.Enter_SortValues("Direction", "Most - Least");
                CreateUser.UserIndex_Clickon_Sort_Apply_button();

                //CreateUser.ClickonSortbutton();
                //CreateUser.Enter_SortValues("Order By", "Property");
                //CreateUser.Enter_SortValues("Direction", "A - Z");
                //CreateUser.UserIndex_Clickon_Sort_Apply_button();

                //CreateUser.ClickonSortbutton();
                //CreateUser.Enter_SortValues("Order By", "Property");
                //CreateUser.Enter_SortValues("Direction", "Z - A");
                //CreateUser.UserIndex_Clickon_Sort_Apply_button();

                CreateUser.ClickonSortbutton();
                CreateUser.Enter_SortValues("Order By", "Brand");
                CreateUser.Enter_SortValues("Direction", "A - Z");
                CreateUser.UserIndex_Clickon_Sort_Apply_button();

                CreateUser.ClickonSortbutton();
                CreateUser.Enter_SortValues("Order By", "Brand");
                CreateUser.Enter_SortValues("Direction", "Z - A");
                CreateUser.UserIndex_Clickon_Sort_Apply_button();

                CreateUser.ClickonSortbutton();
                CreateUser.Enter_SortValues("Order By", "Chain");
                CreateUser.Enter_SortValues("Direction", "A - Z");
                CreateUser.UserIndex_Clickon_Sort_Apply_button();

                CreateUser.ClickonSortbutton();
                CreateUser.Enter_SortValues("Order By", "Chain");
                CreateUser.Enter_SortValues("Direction", "Z - A");
                CreateUser.UserIndex_Clickon_Sort_Apply_button();
                
            }
        }
        #endregion[TP_422702]

    }
}