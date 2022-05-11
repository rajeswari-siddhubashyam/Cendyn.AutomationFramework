using System;
using System.Globalization;
using System.Linq;
using Common;
using BaseUtility.Utility;
using eProposal.PageObject.UI;
using OpenQA.Selenium;
using eProposal.Utility;
using InfoMessageLogger;
using eProposalConstants = eProposal.Utility.Constants;

namespace eProposal.AppModule.UI
{
    internal class eProposalView
    {
        public static void Click_Link_Navigation_Honors()
        {
            Helper.ElementClick(PageObject_ProposalView.Link_Navigation_Honors());
        }

        public static void VerifyHiltonRebranding()
        {
            //Check the nav title.
            try
            {
                //Make sure the old navigation is not displayed.
                if (!Helper.VerifyTextOnPage(eProposalConstants.OldHiltonHonors))
                    Logger.WriteInfoMessage(
                        "The Old Hilton Honors branding navigation is NOT displayed on the Proposal.");

                //Make sure the new navigation is displayed.
                if (Helper.VerifyTextOnPage(eProposalConstants.NewHiltonHonors))
                    Logger.WriteInfoMessage("The new Hilton Honors branding navigation was found on the Proposal.");
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage("The new Hilton Honors branding navigation was not found on the Proposal.");
                Logger.WriteFatalMessage(e);
                throw;
            }

            //Verify the new Hilton Honors logo is displayed in the footer.
            try
            {
                if (CommonMethod.Driver.FindElement(By.XPath("//img[@width='241']")).Displayed)
                    Logger.WriteInfoMessage("The new Hilton Honors branding logo was found on the Proposal.");
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("The new Hilton Honors branding logo was not found on the Proposal.");
                throw;
            }
        }

        /// <summary>
        /// This method will open the contract and sign it as the client.
        /// </summary>
        /// <param name="signature"></param>
        public static void OpenAndSignContractAsClient(string signature)
        {
            try
            {
                Helper.OpenPopUpWindow(CommonMethod.Driver.FindElement(By.XPath("//a[contains(.,'click here')]")));
                Time.AddDelay(3500);
                Helper.EnterFrame("frSigning");
                CommonMethod.Driver
                    .FindElement(By.XPath("//button[contains(@class,'jsbtnGetStarted btn btn-success btn-sm')]"))
                    .Click();
                Time.AddDelay(2500);
                CommonMethod.Driver.FindElement(By.XPath("//input[@data-container-id='location1']")).SendKeys(signature);
                Time.AddDelay(1000);
                CommonMethod.Driver
                    .FindElement(By.XPath("//button[@class='btn btn-success vertical-align-top submit-documents']"))
                    .Click();
                //Wait for the contract window to auto close
                Time.AddDelay(10000);
                //Switch back to the main window.
                CommonMethod.Driver.SwitchTo().Window(CommonMethod.UIWindow);
            }
            catch (Exception e)
            {
                {
                    Logger.WriteFatalMessage("Unable to sign the contract as the client. \n" + e);
                    throw;
                }
            }

        }



    }
}