using BaseUtility.Utility;
using eProposal.AppModule.UI;
using InfoMessageLogger;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProposal.AppModule.MainAdminApp
{
    public partial class MainAdminApp : Helper
    {
        #region[TP_278103]

        #region[TC_278105]

        public static void TC_278105()
        {
            //1 Log into eProposal
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select a property.
            string Property = "Cendyn – DEV - BBQ HIlton";
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);

            //3 Validate login
            VerifyTextOnPageAndHighLight("Say Thank You!");

        }

        #endregion[TC_278105]

        #region[TC_278106]

        public static void TC_278106()
        {
            //1 Log into eProposal
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select a property.
            string Property = "Cendyn – DEV - BBQ HIlton";
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);
            AddDelay(3000);

            //Logout
            ElementClick(Driver.FindElement(By.XPath("/html/body/div[1]/form/div[4]/header/div/div[2]/div/a/span[1]/span")));
            ElementClick(Driver.FindElement(By.XPath("/html/body/div[1]/form/div[4]/header/div/div[2]/div/ul/li[7]/a/span[2]")));
            Logger.WriteDebugMessage("Logged out successfully");

        }

        #endregion[TC_278106]

        #region[TC_278107]

        public static void TC_278107()
        {
            //1 Log into eProposal
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select a property.
            string Property = "Cendyn – DEV - BBQ HIlton";
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);

            //3 Navigate to Create/Edit eProposal
            ElementClick(Driver.FindElement(By.XPath("/html/body/div[1]/form/div[5]/div/div[1]/ul/li[2]/a")));
            ElementClick(Driver.FindElement(By.XPath("/html/body/div[1]/form/div[5]/div/div[1]/ul/li[2]/ul/li[1]/a")));
            VerifyTextOnPageAndHighLight("Create New eProposal");
            Logger.WriteDebugMessage("Create New eProposal");

        }

        #endregion[TC_278107]

        #region[TC_278108]

        public static void TC_278108()
        {
            //1 Log into eProposal
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select a property.
            string Property = "Cendyn – DEV - BBQ HIlton";
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);

            //3 Navigate to Create/Edit eCard
            ElementClick(Driver.FindElement(By.XPath("/html/body/div[1]/form/div[5]/div/div[1]/ul/li[2]/a")));
            ElementClick(Driver.FindElement(By.XPath("/html/body/div[1]/form/div[5]/div/div[1]/ul/li[2]/ul/li[2]/a")));
            VerifyTextOnPageAndHighLight("Create New eCard");
            Logger.WriteDebugMessage("Create New eCard");

        }

        #endregion[TC_278108]

        #region[TC_278109]

        public static void TC_278109()
        {
            //1 Log into eProposal
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select a property.
            string Property = "Cendyn – DEV - BBQ HIlton";
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);

            //3 Navigate to Create/Edit Video
            ElementClick(Driver.FindElement(By.XPath("/html/body/div[1]/form/div[5]/div/div[1]/ul/li[2]/a")));
            ElementClick(Driver.FindElement(By.XPath("/html/body/div[1]/form/div[5]/div/div[1]/ul/li[2]/ul/li[3]/a")));
            VerifyTextOnPageAndHighLight("Personalize your eProposal with a video");
            Logger.WriteDebugMessage("Personalize your eProposal with a video");


        }

        #endregion[TC_278109]

        #region[TC_278110]

        public static void TC_278110()
        {
            //1 Log into eProposal
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select a property.
            string Property = "Cendyn – DEV - BBQ HIlton";
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);

            //3 Navigate to Clients
            ElementClick(Driver.FindElement(By.XPath("/html/body/div[1]/form/div[5]/div/div[1]/ul/li[4]/a")));
            VerifyTextOnPageAndHighLight("Clients");
            Logger.WriteDebugMessage("Clients");

        }

        #endregion[TC_278110]

        #region[TC_99106]
        public static void TC_99106()
        {
            //1 Log into eProposal
            EmployeeLogin.CommonLogin_SSO();
            Logger.WriteDebugMessage("Logged in successfully.");

            //2 Select a property.
            string Property = "Cendyn – DEV - BBQ HIlton";
            EmployeeHome.SelectProperty(Property);
            Logger.WriteDebugMessage("Test property selected: " + Property);

            //3.Click "Create/Edit -> eProposal"
            EmployeeHome.Click_CreateEdit_eProposalButton();
            AddDelay(6000);
            Logger.WriteDebugMessage("Land on the Compose page.");

            //4.Enter any small message in the "Message Closing" text box.
            //eProposalCompose.EnterText_MessageClosingText("Testing Closing Message");
            //Logger.WriteDebugMessage("Message is entered.");

            //5.Finish filling out the eProposal and reach "Step 5". Use your email as the "Client".
            eProposalCompose.CommonComposeMandetory("TesteProposal", "mnagrani@cendyn17.com");
            Logger.WriteDebugMessage("Room Block");
            eProposalCompose.Click_Button_Next();
            Logger.WriteDebugMessage("Event Block");
            AddDelay(2500);
            eProposalCompose.Click_Button_Next();
            Logger.WriteDebugMessage("Select");
            AddDelay(2500);
            eProposalCompose.Click_Button_Next();
            Logger.WriteDebugMessage("Review And Send");
            AddDelay(2500);
            ControlToNewWindow();

            //6.On the eProposal, verify the From Name you entered is displayed above the employee signature.
            if (VerifyTextOnPage("Cendynautomation") && VerifyTextOnPage("Qa"))
            {
                Logger.WriteDebugMessage("Found From Name.");
            }
            else
            {
                Assert.Fail("From Name not found.");
            }
        }
        #endregion[TC_99106]

        #endregion[TP_278103]

    }
}
