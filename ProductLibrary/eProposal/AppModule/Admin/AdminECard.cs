using System;
using System.IO;
using System.Reflection;
using AutoItX3Lib;
using BaseUtility.Utility;
using eProposal.PageObject.Admin;
using OpenQA.Selenium;


namespace eProposal.AppModule.Admin
{
    internal class AdminECard : Helper
    {
        public static void Click_Button_PopUpUpload()
        {
            Helper.ElementClickUsingJavascript(PageObject_AdmineCard.AdmineCard_Button_PopUpUpload());
            AddDelay(5000);
        }

        public static void Click_Button_UploadImage()
        {
            Helper.ScrollToElement(PageObject_AdmineCard.AdmineCard_Button_UploadImage());
            Helper.ElementClickUsingJavascript(PageObject_AdmineCard.AdmineCard_Button_UploadImage());
            AddDelay(5000);
        }

        public static void Click_Button_UploadLogo()
        {
            Helper.ElementClickUsingJavascript(PageObject_AdmineCard.AdmineCard_Button_UploadLogo());
            AddDelay(5000);
        }

        public static void Click_Button_Addnew()
        {
            Helper.ElementClickUsingJavascript(PageObject_AdmineCard.AdmineCard_Button_Addnew());
            AddDelay(5000);
        }

        public static void Click_Link_FooterLinks()
        {
            Helper.ElementClick(PageObject_AdmineCard.AdmineCard_Link_FooterLinks());
            AddDelay(5000);
        }

        public static void Click_Link_AddMediaLink()
        {
            Helper.ElementClick(PageObject_AdmineCard.AdmineCard_Link_AddMediaLink());
            AddDelay(2000);
        }

        public static void Click_Button_Save()
        {
            Helper.ScrollToElement(PageObject_AdmineCard.AdmineCard_Button_Save());
            Helper.ElementClick(PageObject_AdmineCard.AdmineCard_Button_Save());
            AddDelay(2000);
        }

        public static void Click_Button_UploadMediaFiles()
        {
            Helper.ElementClick(PageObject_AdmineCard.AdmineCard_Button_UploadMediaFiles());
            AddDelay(2000);
        }

        public static void Click_Button_Browse()
        {
            Helper.ElementClick(PageObject_AdmineCard.AdmineCard_Button_Browse());
            AddDelay(2000);
        }

        public static void Click_Link_GeneratedLinks()
        {
            Helper.ElementClick(PageObject_AdmineCard.AdmineCard_Link_GeneratedLinks());
            AddDelay(2000);
            Helper.ControlToNewWindow();
            Helper.CloseWindow();
            Helper.ControlToPreviousWindow();
        }

        public static void Click_Button_UploadButton()
        {
            Helper.ElementClick(PageObject_AdmineCard.AdmineCard_Button_UploadButton());
            AddDelay(2000);
        }

        public static void Click_Button_CancelButton()
        {
            Helper.ElementClick(PageObject_AdmineCard.AdmineCard_Button_CancelButton());
            AddDelay(2000);
        }

        public static void Click_Button_ChooseFile()
        {
            Helper.ElementClick(PageObject_AdmineCard.AdmineCard_Button_ChooseFile());
            AddDelay(5000);
        }

        public static void Click_Image_Preview()
        {
            Helper.ElementClick(PageObject_AdmineCard.AdmineCard_Image_Preview());
            AddDelay(5000);
        }

        public static void Enter_Text_LinkName(string linkname)
        {
            var name = string.Concat(linkname, DateTime.Now.ToShortDateString());
            Helper.ElementEnterText(PageObject_AdmineCard.AdmineCard_Input_LinkName(), name);
            AddDelay(2000);
        }

        public static void Enter_Text_SkinName(string SkinName)
        {
            Helper.ElementEnterText(PageObject_AdmineCard.AdmineCard_Text_SkinName(), SkinName);
            AddDelay(5000);
        }

        public static void Upload_Button_ChooseFile(string Location)
        {
            UploadFile(PageObject_AdmineCard.AdmineCard_Button_ChooseFile(), Location);
            AddDelay(5000);
        }

        public static void UploadImage(string fileLocation, string browser)
        {
            Helper.EnterFrame("iframe_upload");
            AddDelay(3000);
            Click_Button_ChooseFile();
            AddDelay(3000);
            //CommonMethod.Driver.FindElement(By.Id("UploadFile")).Click();
            if (browser.Equals("Chrome"))
            {
                AutoItX3 autoIt = new AutoItX3();
                //autoit.WinActivate("Open");
                AddDelay(5000);
                autoIt.Send(fileLocation);
                AddDelay(1500);
                autoIt.Send("{ENTER}");
            }
            else
            {
                var autoit = new AutoItX3();
                autoit.WinActivate("File Upload");
                AddDelay(3500);
                autoit.Send(fileLocation);
                AddDelay(1500);
                autoit.Send("{ENTER}");
            }
            Click_Button_UploadButton();
            AddDelay(2500);
        }

        /// <summary>
        ///     Method to enter link name and click save button.
        /// </summary>
        public static void EnterLinkName(string name)
        {
            Enter_Text_LinkName(name);
            Click_Button_Save();
        }

        /// <summary>
        ///     Method to attach files.
        /// </summary>
        public static void UploadFiles(string fileLocation, string browser, IWebElement elementId = null)
        {
            string RootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            AddDelay(2500);
            if (elementId !=null)
            {
                Click_Button_UploadMediaFiles();
            }
            Helper.EnterFrame("iframe_upload");
            IWebElement uploadfile = Driver.FindElement(By.Id("UploadFile"));
            uploadfile.SendKeys(fileLocation);
            ElementClick(Driver.FindElement(By.Id("btnUploadLogoOK")));
        }
    }
}