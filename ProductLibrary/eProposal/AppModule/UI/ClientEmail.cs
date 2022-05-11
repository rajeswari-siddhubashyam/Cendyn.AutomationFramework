using System;
using Common;
using BaseUtility.Utility;
using eProposal.PageObject.UI;
using NUnit.Framework;
using OpenQA.Selenium;
using InfoMessageLogger;
using BaseUtility.Utility.Gmail;

namespace eProposal.AppModule.UI
{
    internal class ClientEmail : Helper
    {
        public static void SelectFromDropDown_DropDown_Language(string text)
        {
            ElementSelectFromDropDown(PageObject_ClientEmail.Dropdown_Language(), text);
        }

        public static void Click_Link_ViewProposal()
        {
            ElementClick(PageObject_ClientEmail.Link_ViewProposal());
        }

        public static void Click_Link_Forward()
        {
            ElementClick(PageObject_ClientEmail.Link_Forward());
        }

        public static void Click_Link_Submit()
        {
            ElementClick(PageObject_ClientEmail.Link_Submit());
        }

        public static void Enter_Text_FirstName(string FirstName)
        {
            ElementEnterText(PageObject_ClientEmail.Text_FirstName(), FirstName);
        }

        public static void Enter_Text_LastName(string LastName)
        {
            ElementEnterText(PageObject_ClientEmail.Text_LastName(), LastName);
        }

        public static void Enter_Text_Email(string Email)
        {
            ElementEnterText(PageObject_ClientEmail.Text_Email(), Email);
        }

        public static void Enter_Text_UniqueEmail(string Email)
        {
            //var UniqueEmail = MakeGmailUnique(Email);
            ElementEnterText(PageObject_ClientEmail.Text_Email(), Email);
        }

        public static void Click_Link_ViewInBrowser()
        {
            ElementClick(PageObject_ClientEmail.Link_ViewInBrowser());
        }

        public static void Click_Link_OpenYourProposal()
        {
            OpenPopUpWindow(PageObject_ClientEmail.Link_OpenYourProposal());
            AddDelay(5000);
        }

        public static void Click_Link_DownloadPDF()
        {
            ElementClick(PageObject_ClientEmail.Link_DownloadPDF());
        }

        public static void Click_Link_TechnicalDifficulties()
        {
            ElementClick(PageObject_ClientEmail.Link_TechnicalDifficulties());
        }

        public static void Click_Link_EmployeeEmail()
        {
            ElementClick(PageObject_ClientEmail.Link_EmployeeEmail());
        }

        public static void GmailLogIn(string email, string password)
        {
            Gmail.NavigateToGmail();
            Gmail.LogIn(email, password);
        }

        public static void GmailOpenFirstMessage()
        {
            Gmail.OpenFirstEmail();
        }

        private static void VerifyHiltonEmailHeader()
        {
            try
            {
                if (PageObject_ClientEmail.HiltonHeader().Displayed)
                    Logger.WriteInfoMessage("The new Hilton branding Header was found on the client email.");
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage("The new Hilton branding Header was NOT found on the client email.");
                Logger.WriteFatalMessage(e);
                throw;
            }
        }

        private static void VerifyHiltonEmailFooter()
        {
            try
            {
                if (PageObject_ClientEmail.HiltonFooter().Displayed)
                    Logger.WriteInfoMessage("The new Hilton branding Footer was found on the client email.");
            }
            catch (Exception e)
            {
                Logger.WriteFatalMessage("The new Hilton branding Footer was NOT found on the client email.");
                Logger.WriteFatalMessage(e);
                throw;
            }
        }

        public static void VerifyHiltonEmailBranding()
        {
            VerifyHiltonEmailHeader();
            VerifyHiltonEmailFooter();
        }

        /// <summary>
        ///     Verify if the height is less than or equal to 55 Px
        /// </summary>
        public static void VerifyHeight_Image_CustomSignature()
        {
            var height = GetElementHeight(PageObject_ClientEmail.Image_CustomSignature());
            if (height <= 55)
                Logger.WriteDebugMessage("height is no more than 55 px, it fits correctly for Custom image");
            else
                Logger.WriteDebugMessage("height is more than 55 px, for Custom image");
        }

        /// <summary>
        ///     Get SRC of custom signature for verification.
        /// </summary>
        public static string Get_CustomSignaturename()
        {
            var CustomSignatureSRC = PageObject_ClientEmail.Image_CustomSignature().GetAttribute("src");
            var CustomSignatureSplit = CustomSignatureSRC.Split('=');
            var CustomSignatureInitial = CustomSignatureSplit[0];
            return CustomSignatureInitial;
        }

        /// <summary>
        ///     Compare and check uploaded image under Perview page and with image under recieved in Client email.
        /// </summary>
        public static void VerifyWithUploaded_Image_CustomSignature(string Value_1, string Value_2)
        {
            if (Value_1.Contains(Value_2))
                Logger.WriteDebugMessage("Image Signature matches with Custom Signature");
            else
                Assert.Fail("Image Signature does not matches withCustom Signature");
        }

        /// <summary>
        ///     This method is used to open and check email
        /// </summary>
        public static void CheckAndOpenEmail(string email, string pass)
        {
            AddDelay(10000);
            Gmail.NavigateToGmail();
            Gmail.LogIn(email, pass);
            Gmail.OpenFirstEmail();
            //  Gmail.GmailClickLinkByElement(PageObject_PasswordReset.PasswordReset_EmailLink());
        }

        /// <summary>
        ///     This method to get font-weight
        /// </summary>
        public string getFontWeight(IWebElement element)
        {
            //Output will return as 400 for font-weight : normal, and 700 for font-weight : bold
            return element.GetCssValue("font-weight");
        }

        /// <summary>
        ///     Check Employee Name CendynQA is in Bold
        /// </summary>
        public static void CheckEmployeeNameCendynQABold()
        {
            try
            {
                AddDelay(3000);
                var ActualFontWeight = PageObject_ClientEmail.Text_EmployeeNameCendynQA().GetCssValue("font-weight");
                var ExpextedFontWeight = "700";
                if (ActualFontWeight == ExpextedFontWeight)
                    Logger.WriteDebugMessage("Text is in Bold");
                else
                    Logger.WriteDebugMessage("Text is not in Bold");
                AddDelay(3000);
            }
            catch (Exception)
            {
                Logger.WriteFatalMessage("The employee signature on the eCard was NOT bold.");
            }
        }


    }
}