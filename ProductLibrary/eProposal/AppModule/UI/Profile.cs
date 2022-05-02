using System;
using AutoItX3Lib;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using eProposal.Utility;
using System.Collections.Generic;
using Common;
using BaseUtility.Utility;
using eProposal.PageObject.UI;
using InfoMessageLogger;
using eProposalConstants = eProposal.Utility.Constants;

namespace eProposal.AppModule.UI
{
    internal class Profile
    {
        public static void Click_Link_ContinueToeProposal()
        {
            Helper.ElementClick(PageObject_Profile.Profile_Link_ContinueToeProposal());
        }


        public static void Click_Link_EditFirstProfile()
        {
            Helper.ElementClick(PageObject_Profile.Profile_Link_EditFirstProfile());
        }

        public static void Click_Button_ChooseFile()
        {
            Helper.ElementClick(PageObject_Profile.Profile_Button_ChooseFile());
        }


        public static void Click_Button_ViewAll()
        {
            Helper.ElementClick(PageObject_Profile.Profile_Button_ViewAll());
        }

        public static void Click_Button_No()
        {
            Helper.ElementClick(PageObject_Profile.Profile_Button_No());
        }

        public static void Upload_Button_ChooseFile(string location)
        {
            Helper.UploadFile(PageObject_Profile.Profile_Button_ChooseFile(), location);
        }

        public static void Click_Button_Save()
        {
            Helper.ElementClick(PageObject_Profile.Profile_Button_Save());
        }

        public static void Click_Link_Remove()
        {
            Helper.ElementClick(PageObject_Profile.Profile_Link_Remove());
        }

        public static void Click_Button_Ok()
        {
            Helper.ElementClick(PageObject_Profile.Profile_Button_Ok());
        }

        public static void Click_Button_Cancel()
        {
            Helper.ElementClick(PageObject_Profile.Profile_Button_Cancel());
        }

        public static string Get_CustomSignaturename(IWebElement element)
        {
            var CustomSignatureSRC = element.GetAttribute("src");
            var CustomSignatureSplit = CustomSignatureSRC.Split('=');
            var CustomSignatureInitial = CustomSignatureSplit[0];
            return CustomSignatureInitial;
        }

        /// <summary>
        ///     Method to get the height of CustomSignature field.
        /// </summary>
        public static void VerifyHeight_Image_CustomSignature()
        {
            Helper.EnterFrame("ctl00_ctl00_MainContent_MainContent_ifmContent");
            Time.AddDelay(2500);
            Helper.HighlightElement(PageObject_eCardCompose.Image_CustomSignatureImage());
            var height = Helper.GetElementHeight(PageObject_eCardCompose.Image_CustomSignatureImage());
            if (height >= 55)
                Logger.WriteDebugMessage("Verified Height of Custom Signature");
            else
                Logger.WriteDebugMessage("Height of Custom Signature is less than or greater than 55 pixels");
            Helper.ExitFrame();
        }

        /// <summary>
        ///     Method to verify whether custom signature field is present or not.
        /// </summary>
        public static void VerifyCustomSignatureField()
        {
            Time.ScrollDownUsingJavaScript(CommonMethod.Driver, 2500);
            Time.AddDelay(2500);
            var status = Helper.VerifyTextOnPage(eProposalConstants.CustomSignature);
            if (status.Equals(true))
                Logger.WriteInfoMessage("It is!Present");
            else
                Assert.Fail("Custom Signature field is NOT available.");
        }

        /// <summary>
        ///     Method to verify Remove Link is present or not.
        /// </summary>
        public static void VerifyIsPresent_Link_Remove()
        {
            Upload_Button_ChooseFile(eProposalConstants.UploadgifFiles);
            Click_Button_Save();
            if (PageObject_Profile.Profile_Button_No().Displayed)
                Click_Button_No();
            Time.AddDelay(1500);
            var image = PageObject_Profile.Profile_Link_Remove().GetAttribute("innerHTML");
            if (image.Equals("Remove"))
            {
                Click_Link_Remove();
                Click_Button_Ok();
            }
            else
            {
                Logger.WriteInfoMessage("Remove button is NOT peresent");
            }
        }

        /// <summary>
        ///     If there is already an custom signature loaded, click "Remove" and "OK" on the popup.
        /// </summary>
        public static void VerifyCustomSignatureLoaded()
        {
            var image = Helper.VerifyElementOnPage(PageObject_Profile.Profile_Image_CustomSignature());
            if (image.Equals(true))
            {
                Click_Link_Remove();
                Click_Button_Ok();
            }
            else
            {
                Upload_Button_ChooseFile(eProposalConstants.ImageUpload);
            }
        }

        /// <summary>
        /// Method to upload Improper file format.
        /// </summary>
        public static void UploadImproperFile(string location)
        {
            Helper.UploadFile(PageObject_Profile.Profile_Button_ChooseFile(), location);
            var text = Helper.VerifyTextOnPage(eProposalConstants.ImproperFileValidationMessage);
            if (text.Equals(true))
                Logger.WriteInfoMessage("Error message stating 'Please select a valid image.' is displayed.");
            else
                Logger.WriteInfoMessage("Error message stating 'Please select a valid image.' is NOT displayed.");
        }

        /// <summary>
        ///     Compare two string values, and fails if they ARE equal
        /// </summary>
        public static void VerifyNotEqualWithUploaded_Image_CustomSignature(string Value_0, string Value_1)
        {
            if (Value_0 == Value_1)
                Assert.Fail("Custom Signature matches On English and german language profile page");
            else
                Logger.WriteDebugMessage(
                    "Custom Signature does not matches On English and german language profile page");
        }

        /// <summary>
        ///     Method to attach files and save it.
        ///     08/07 Marc : Commented out the "Open" method since it was failing the cases when uploading an image to an employee
        /// </summary>
        public static void UploadImage(string fileLocation)
        {
            var autoit = new AutoItX3();
            Click_Button_ChooseFile();
            Time.AddDelay(5000);
            //autoit.WinActivate("Open");
            Time.AddDelay(1500);
            autoit.Send(fileLocation);
            Time.AddDelay(3000);
            autoit.Send("{ENTER}");
            Time.AddDelay(5000);

            var ac = new Actions(CommonMethod.Driver);
            ac.SendKeys(Keys.Tab);
            Time.AddDelay(3000);
            ac.SendKeys(Keys.Enter).Build().Perform();
            Time.AddDelay(3000);
        }

        /// <summary>
        /// This method will check if the user has a signature uploaded and if so, will remove it. 
        /// </summary>
        public static void CheckAndRemoveSignature()
        {
            try
            {
                if (Helper.VerifyElementOnPage(PageObject_Profile.Profile_Link_Remove()))
                {
                    Click_Link_Remove();
                    Click_Button_Ok();
                    Logger.WriteInfoMessage("Removed 'Custom Signature'");
                }
                else
                    Logger.WriteInfoMessage("There is no signature to remove.");
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage("Unable to remove the employee's signature" + e);
                throw;
            }
            
        }



    
    }

    

}