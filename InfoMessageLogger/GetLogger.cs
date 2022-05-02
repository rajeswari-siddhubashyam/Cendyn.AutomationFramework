using Common;
using log4net;
using log4net.Appender;
using log4net.Core;
using log4net.Layout;
using log4net.Repository.Hierarchy;
using System;
using System.IO;

namespace InfoMessageLogger
{
    public class GetLogger : CommonMethod
    {
        /// <summary>
        /// All configuration settings related to logging
        /// Not using web.config
        /// </summary>
        public static void GetLog(string filename, string LoggerFile)
        {
            //ColorAppender();
            Hierarchy hierarchy = (Hierarchy)LogManager.GetRepository();
            PatternLayout patternLayout = new PatternLayout { ConversionPattern = "%d ::%-5p::[%c{1}]:: %m%n" };
            patternLayout.ActivateOptions();

            //Updated Logger path with TP and TC
            var loggerPath = LoggerFile + ProjectName + "\\" + TestPlanId + "\\" + TestCaseId + "\\";
            var output = filename;
            //var pathAndFile = loggerPath + ProjectName + "\\" + TestPlanId + "\\" + TestCaseId + ".log";
            var pathAndFile = loggerPath + TestCaseId + ".log";
            //Delete log file if it already exists.
            if (File.Exists(pathAndFile))
            {

                File.Delete(pathAndFile);

                Time.AddDelay(1000);
            }

            //var roller = new RollingFileAppender { AppendToFile = true };            
            //Appendtofile is updated to false as logger need to be generated for everyexecution
            var roller = new RollingFileAppender { AppendToFile = false };
            GetTimestamp();
            //Logging file path
            roller.File = loggerPath + output + ".log";
            roller.Layout = patternLayout;

            //To take Infinite backups
            roller.MaxSizeRollBackups = -1;

            //Generate log file per hour
            roller.DatePattern = ".dd-MM-yyyy-HH";

            // To fix the file size
            roller.MaximumFileSize = "500KB";

            //To get backup by Date
            roller.RollingStyle = RollingFileAppender.RollingMode.Size;

            roller.StaticLogFileName = true;
            roller.ActivateOptions();
            hierarchy.Root.AddAppender(roller);
            var memory = new MemoryAppender();
            memory.ActivateOptions();
            hierarchy.Root.AddAppender(memory);
            hierarchy.Root.Level = Level.All;
            hierarchy.Configured = true;
        }

        /// <summary>
        /// To get a current date and time
        /// </summary>
        /// <returns>exact current date and time</returns>
        public static String GetTimestamp()
        {
            return DateTime.Now.ToString("dd-MM-yyyyy-HHmmssffff");
        }
    }
}
