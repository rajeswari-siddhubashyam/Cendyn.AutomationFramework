using Common;
using InfoMessageLogger.ReportGeneration;
using OpenQA.Selenium;
using System;
using System.IO;
using System.Threading;

namespace InfoMessageLogger
{
    /// <summary>
    /// Method to get the path for the working directory
    /// </summary>
    /// <returns></returns>
    public class CaptureImage
    {
        /// <summary>
        /// Code to Capture screenshot at run time for pass and fail test script
        /// </summary>
        /// <param name="filename">Filename to save the Screenshot</param>
        public static void TakeScreenShot(string filename, string screenshotPath)
        {
            try
            {
                //Updated screenshot path 
                string path = String.Concat(Constants.ReportPath, ExtentedReport.Systime + "\\");

                //string path = screenshotPath;
                Thread.Sleep(1000);
                Directory.CreateDirectory(path);
                Thread.Sleep(1000);
                ITakesScreenshot screenshothandler = CommonMethod.Driver as ITakesScreenshot;
                if (screenshothandler != null)
                {
                    Screenshot screenshot = screenshothandler.GetScreenshot();
                    //screenshot.SaveAsFile(
                    //(string.Format("{0}\\{1}{2}{3}{4}", path, filename, " ", Time.GetTimestamp(), ".Jpeg")),
                    //ImageFormat.Jpeg);
                }
            }
            catch (Exception ex)
            {
                Logger.WriteErrorMessage("Error in Takescreenshot code", ex.InnerException);
            }
        }
    }
}
