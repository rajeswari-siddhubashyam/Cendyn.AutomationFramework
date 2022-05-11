using System;
using System.IO;
using System.Reflection;
using Common;
using BaseUtility.Utility;
using eProposal.PageObject.UI;
using OpenQA.Selenium;

namespace eProposal.AppModule.UI
{
    class eFaceTime : Helper
    {
        public static void Click_Link_Folder1()
        {
            AddDelay(500);
            Helper.ElementClick(PageObject_eFaceTime.eFaceTime_Link_Folder1());            
        }

        public static void Click_Link_Preview()
        {
            AddDelay(500);
            Helper.ElementClick(PageObject_eFaceTime.eFaceTime_Link_Preview());
        }

        public static void Click_Link_Delete()
        {
            AddDelay(500);
            Helper.ElementClick(PageObject_eFaceTime.eFaceTime_Link_Delete());
        }

        public static void Click_Button_AddVideo()
        {
            AddDelay(500);
            Helper.ElementClick(PageObject_eFaceTime.eFaceTime_Button_AddVideo());
        }

        public static void Enter_YourVideoName(string text)
        {
            Helper.ElementEnterText(PageObject_eFaceTime.eFaceTime_Text_NameYourVideo(), text);
        }

        public static void Select_Folder(string text)
        {
            Helper.ElementSelectFromDropDown(PageObject_eFaceTime.eFaceTime_Dropdown_SelectFolder(), text);
        }

        public static void Click_Button_YouTubeLink()
        {
            AddDelay(500);
            Helper.ElementClick(PageObject_eFaceTime.eFaceTime_Button_YouTubeLink());
        }

        public static void Enter_Pastelink(string text)
        {
            Helper.ElementEnterText(PageObject_eFaceTime.eFaceTime_Text_PasteLink(), text);
        }

        public static void Click_Button_SubmitLink()
        {
            AddDelay(500);
            Helper.ElementClick(PageObject_eFaceTime.eFaceTime_Button_SubmitLink());
        }

        public static void Click_Button_OkButton()
        {
            AddDelay(500);
            Helper.ElementClick(PageObject_eFaceTime.eFaceTime_Button_OkButton());
        }

        public static void Click_Button_ChooseFile()
        {
            AddDelay(500);
            Helper.ElementClick(PageObject_eFaceTime.eFaceTime_Button_ChooseFile());
        }

        public static void Click_Link_Select1()
        {
            AddDelay(500);
            Helper.ElementClick(PageObject_eFaceTime.eFaceTime_Link_Select());
        }

        public static void Click_Button_UploadVideo()
        {
            AddDelay(500);
            Helper.ElementClick(PageObject_eFaceTime.eFaceTime_Button_UploadVideo());
        }

        public static void Click_Button_SelectVideos()
        {
            AddDelay(500);
            Helper.ElementClick(PageObject_eFaceTime.eFaceTime_Button_SelectVideos());
        }

        public static void Click_Button_AttachYourVideo()
        {
            AddDelay(500);
            Helper.ElementClick(PageObject_eFaceTime.eFaceTime_Button_AttachYourVideo());
        }

        /// <summary>
        /// Method to Add Video to folder
        /// </summary>
        public static void AddVideo(string videoname,string folder,string videoLink)
        {
            Enter_YourVideoName(videoname);
            Select_Folder(folder);
            Click_Button_YouTubeLink();
            Enter_Pastelink(videoLink);
            Click_Button_SubmitLink();
            Click_Button_OkButton();
        }
        public static void UploadVideo()
        {
            string RootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            string filelocation = @"\UploadFiles\SampleVideo.mp4";
            string location = RootPath + filelocation;
            location = location.Replace("file:\\", "");
            IWebElement uploadfile = PageObject_eFaceTime.eFaceTime_Button_ChooseFile();
            uploadfile.SendKeys(location);
        }

    }
}
