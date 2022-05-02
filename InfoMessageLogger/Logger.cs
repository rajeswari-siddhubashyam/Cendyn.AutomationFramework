using Common;
using InfoMessageLogger.ReportGeneration;
using AventStack.ExtentReports;
using log4net;
using System;
using System.Collections.Generic;

namespace InfoMessageLogger
{
    public class Logger : CommonMethod
    {
        private static ILog log = LogManager.GetLogger(typeof(Logger));
        private static Dictionary<string, string> _testData = new Dictionary<string, string>();

        public static object LogStatus { get; private set; }

        /// <summary>
        /// A simple wrapper to start the log4net infrastructure. 
        /// This may be called at any time prior to using the logging mechanism 
        /// </summary>
        public static void StartLogger()
        {
            // start log4net
            log4net.Config.XmlConfigurator.Configure();
        }

        /// <summary>
        /// Method to print the Environment Details for the Test Execution.
        /// </summary>
        public static void Environmentdetails()
        {

            WriteInfoMessage(BrowserType + " is currently being used for testing.");
            WriteInfoMessage(UrlInfo + " is used for Testing");
            WriteInfoMessage("This is the login page." + Driver.Url);
            WriteInfoMessage("Execution started at:-" + Time.GetTimestamp());
        }

        /// <summary>
        /// Prints the Log info at the Start of Execution
        /// </summary>
        public static void StartExecution()
        {
            log.Info("Execution of " + System.Reflection.Assembly.GetCallingAssembly().GetName().Name + " Test cases");
        }

        /// <summary>
        /// Prints the Log info at the End of Execution
        /// </summary>
        public static void EndExecution()
        {
            log.Info("E.N.D");
            log4net.LogManager.Shutdown();
        }

        public static void StartLogger(string server, int threadId)
        {
            ThreadContext.Properties["LogServer"] = server;
            ThreadContext.Properties["LogThread"] = threadId.ToString();
            log4net.Config.XmlConfigurator.Configure();
        }

        //deletes all old files and parent folder
        public static void DeleteOldFolder()
        {
            CaptureScreenshot.CleanUpscreenShot(Constants.ScreenshotPath);
        }

        // Will be written for debugging-level calls
        public static void WriteDebugMessage(string message)
        {
            log.Debug(StepCount + ") " + message);
            var path = CaptureScreenshot.CapturescreenShot(StepCount.ToString());
            //MyExtentTest.Log(Status.Pass,MyExtentTest.AddScreenCaptureFromPath(path));
            //MyExtentTest.Log(Status.Pass,message);
            MyExtentTest.Pass(message).AddScreenCaptureFromPath(path);
            StepCount++;
            //Helper.AddDelay(1000);
            AddDelay(1000);
        }
        public static void LogTestData(string testplanid, string testcaseid, string key, string value, bool isLastTestData = false)
        {
            _testData.Add(key, value);
            if (isLastTestData)
            {
                var path = CaptureScreenshot.CapturescreenShot(StepCount.ToString());
                log.Debug("TestPlan :- " + testplanid + " Testcase :- " + testcaseid);
                MyExtentTest.Pass("TestPlan :- " + testplanid + " Testcase :- " + testcaseid).AddScreenCaptureFromPath(path);
                log.Debug("~~~~~~~~~~~~~~~~~~~~~~~~~~Test Data Used~~~~~~~~~~~~~~~~~~~~~~~~~~");
                MyExtentTest.Pass("~~~~~~~~~~~~~~~~~~~~~~~~~~Test Data Used~~~~~~~~~~~~~~~~~~~~~~~~~~").AddScreenCaptureFromPath(path);
                foreach (var item in _testData)
                {
                    log.Debug(" Value for : " + item.Key + " is : " + item.Value); 
                    MyExtentTest.Pass(" Value for : " + item.Key + " is : " + item.Value).AddScreenCaptureFromPath(path);
                }
                Time.AddDelay(1000);
                _testData = new Dictionary<string, string>();

            }
        }
        // needed for informational logging
        public static void WriteInfoMessage(string message)
        {
            log.Info(message);
            MyExtentTest.Log(Status.Info, message.ToString());
        }

        public static void WriteInfoMessage(string message,long value)
        {
            log.Info(message + value);
            MyExtentTest.Log(Status.Info, message.ToString());
        }


        // needed for warning Logging
        public static void WriteWarnMessage(object message)
        {
            log.Warn(message);
            MyExtentTest.Log(Status.Warning, message.ToString());
        }

        // Useanytime an error occurs
        // 08/07 Marc : Commented out the MyExtentTest because it throws an error when accessed.
        public static void WriteErrorMessage(object message, Exception ex)
        {
            log.Error(message, ex);
            MyExtentTest.Log(Status.Error, message.ToString());
        }

        // needed for Fatal Logging
        public static void WriteFatalMessage(object message)
        {
            log.Fatal(message);
            //CaptureScreenshot.CapturescreenShot(StepCount.ToString());
        }

    }
}
