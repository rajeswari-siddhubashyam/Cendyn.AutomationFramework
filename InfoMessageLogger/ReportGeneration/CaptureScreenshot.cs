using Common;
using OpenQA.Selenium;
using System;
using System.IO;

namespace InfoMessageLogger.ReportGeneration
{
    public class CaptureScreenshot : CommonMethod
    {
        /// <summary>
        /// Code to take screenshot for Extent Extent
        /// </summary>
        /// <param name="filename">Filename to save the Screenshot</param>
        /// <returns>Filepath for the Screenshot.</returns>
        public static string CapturescreenShot(string filename)
        {
            string filePath = "";
            try
            {
                var path = ScreenShotPath + "\\" + ProjectName + "\\" + TestPlanId + "\\" + TestCaseId + "\\";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                System.Threading.Thread.Sleep(1000);
                var screenshothandler = Driver as ITakesScreenshot;
                if (screenshothandler != null)
                {
                    var screenshot = screenshothandler.GetScreenshot();
                    filePath = string.Format("{0}\\{1}{2}", path, filename, ".Jpeg");
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                        Time.AddDelay(1000);
                    }
                    screenshot.SaveAsFile(filePath, ScreenshotImageFormat.Jpeg);
                }
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage("Exception while taking screenshot", ex);
            }
            return filePath;
        }

        public static string CleanUpscreenShot(string filename)
        {
            string filePath = "";
            var path = ScreenShotPath + "\\" + ProjectName + "\\" + TestPlanId + "\\" + TestCaseId + "\\";
            try
            {
                if (Directory.Exists(path))
                {
                    System.IO.DirectoryInfo di = new DirectoryInfo(path);
                    foreach (FileInfo file in di.GetFiles())
                    {
                        if (file.Name.Contains(".log"))
                        {
                            //file.
                        }
                        else
                        {
                            file.Delete();
                        }
                        //Directory.Delete(path);
                    }
                    //Directory.Delete(path);
                }
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage("Exception while deleting screenshot folder", ex);
            }
            return filePath;
        }

        public static void DeleteUnwantedFolders()
        {
            var path = ScreenShotPath;
            try
            {
                if (Directory.Exists(path))
                {
                    System.IO.DirectoryInfo di = new DirectoryInfo(path);

                    foreach (string file in Directory.GetDirectories(path))
                    {
                        string date = DateTime.Now.ToString("MMM-dd-yyyy");
                        if (file.Contains(date))
                        {
                            Directory.Delete(file);
                        }
                        else
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage("Exception while deleting screenshot folder", ex);
            }
        }
    }
}
