using Common;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Net;

namespace InfoMessageLogger.ReportGeneration
{
    /// <summary>
    /// Code to create Extent Extent and set properties that are required
    /// </summary>
    public class ExtentedReport
    {
        //Assigning the variable the Report generation time. : DN
        public static string Systime = Time.GetTimestamp();

        public class ExtentManager : CommonMethod
        {
            private static ExtentReports extent;

            public static ExtentReports GetInstance(string reportPath, string title)
            {
                string hostname = Dns.GetHostName();
                OperatingSystem os = Environment.OSVersion;

                var path = reportPath + ProjectName + "\\" + TestPlanId + "\\" + TestCaseId + "\\";
                try
                {
                    string Reportname = String.Concat(path, TestCaseId, "_", Systime, ".html");
                    var htmlReporter = new ExtentHtmlReporter(Reportname);
                    //_extent = new ExtentReports(Reportname + ".html", false);
                    extent = new ExtentReports();
                    extent.AttachReporter(htmlReporter);
                    extent.AddSystemInfo("Browser Type", BrowserType);
                    extent.AddSystemInfo("HostName", hostname);
                    extent.AddSystemInfo("Operating System", os.ToString());
                    htmlReporter.Configuration().ChartVisibilityOnOpen = true;
                    htmlReporter.Configuration().DocumentTitle = TestCaseId;
                    htmlReporter.Configuration().ReportName = "Project" + TestCaseId;
                }
                catch (Exception ex)
                {
                    Logger.WriteErrorMessage("Failed", ex);
                }
                return extent;
            }
        }
    }
}
