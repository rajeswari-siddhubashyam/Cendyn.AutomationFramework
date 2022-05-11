using System;
using eProposal.Utility;
using eProposal.AppModule.UI;
using Common;
using Constants = eProposal.Utility.Constants;
using InfoMessageLogger;
using BaseUtility.Utility;
using TestData;
using SqlWarehouse;
using OpenQA.Selenium;
using NUnit.Framework;
using eProposal.AppModule.UI;
using eProposal.PageObject.UI;
using System.Text.RegularExpressions;

namespace eProposal.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {

        #region[TC_112919]

        public static void TC_112919()
        {
            //for (int i = 1; i <= 3; i++)
            //{
            //1 Log into ePFull
            EmployeeLogin.DemoLogIn(LegacyTestData.CommonDemoEmail, LegacyTestData.CommonDemoPassword);
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select a Hilton Property
            //EmployeeHome.SelectProperty(EmployeeHome.TC_112919Properties(i));
            EmployeeHome.SelectProperty(Hilton1);
            Logger.WriteDebugMessage("A Hilton property is selected.");

            //3 Click "Create/Edit -> eProposal"
            EmployeeHome.Click_CreateEdit_eProposalButton();
            Logger.WriteDebugMessage("Land on the eProposal Step 1 page.");

            //4 Begin creating an eProposal and navigate to the Select step. 

            //Compose
            eProposalCompose.CommonRequiredFields();
            eProposalCompose.Click_Button_Next();

            if (Project.IsStep2Select())
            {
                Logger.WriteDebugMessage("Land on the Select step..");

                //5 Verify the "Honors" navigation is correct.
                eProposalSelect.VerifyHiltonRebranding();
                eProposalSelect.Click_Link_CheckAll();
                Logger.WriteDebugMessage("The navigation is labeled Honors on the Select step.");
                eProposalSelect.Click_Button_Next();
                AddDelay(5000);

                //Room Block
                eProposalCendynRoomBlock.Click_Button_Next();
                AddDelay(5000);

                //6 Navigate to Step 5
                //Event Block
                eProposalCendynEventBlock.Click_Button_Next();
                AddDelay(5000);
                Logger.WriteDebugMessage("Preview is opened in a new page or tab.");
            }
            else
            {
                //Room Block
                eProposalCendynRoomBlock.Click_Button_Next();
                AddDelay(5000);

                //Event Block
                eProposalCendynEventBlock.Click_Button_Next();
                AddDelay(5000);
                Logger.WriteDebugMessage("Land on the Select step..");

                //5 Verify the "Honors" navigation is correct.
                eProposalSelect.VerifyHiltonRebranding();
                eProposalSelect.Click_Link_CheckAll();
                Logger.WriteDebugMessage("The navigation is labeled Honors on the Select step.");

                //6 Navigate to Step 5
                eProposalSelect.Click_Button_Next();
                AddDelay(5000);
                Logger.WriteDebugMessage("Preview is opened in a new page or tab.");
            }


            //7 + 8 Verify the "Honors" navigation is correct. | Verify the "Hilton Honors" footer logo is correct.
            eProposalView.VerifyHiltonRebranding();
            Logger.WriteDebugMessage("The navigation is labeled Honors on the proposal preview and the correct logo is displayed.");

            //9 Send the proposal.
            eProposalPreview.ClosePreview();
            eProposalPreview.Click_Button_Send();
            Logger.WriteDebugMessage("The proposal is sent to the client.");

            //10 Check the client email.
            ClientEmail.GmailLogIn(ClientLogin, ClientPassword);
            ClientEmail.GmailOpenFirstMessage();
            Logger.WriteDebugMessage("The email is opened.");

            //11 Verify the "Hilton" logos on the email header and footer are correct.
            ClientEmail.VerifyHiltonEmailBranding();
            Logger.WriteDebugMessage("The logos are correct on the email.");

            //12 Click the "Open Your Proposal" link.
            ClientEmail.Click_Link_OpenYourProposal();
            Logger.WriteDebugMessage("eProposal opens in a new window/tab.");

            //13 + 14 Verify the "Honors" navigation is correct. | Verify the "Hilton Honors" footer logo is correct.
            eProposalView.VerifyHiltonRebranding();
            Logger.WriteDebugMessage(
                "The navigation is labeled Honors on the proposal preview and the correct logo is displayed.");

            //Navigate back to ePFull
            //Driver.Navigate().GoToUrl(TestData.CommonFrontendURL);
            //}
        }

        #endregion[TC_112919]

    }
}
