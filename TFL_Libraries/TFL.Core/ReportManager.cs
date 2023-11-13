using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFL_Libraries.TFL.Core
{
    public class ReportManager
    {
        public static ExtentReports eReports;
        public static ExtentTest eTest;
        public static string CreateReport()
        {
            eReports=new ExtentReports();
            var dateTime = DateTime.Now.ToString("_MMddyyyyhhmmtt");
            string directory = @"C:\TestAutomation\TFL_Automation\Execution_Reports\Report" + dateTime;
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            var directoryPath = directory + "\\" + dateTime;
            var htmlReport = new ExtentHtmlReporter(directoryPath + ".html");
            eReports.AttachReporter(htmlReport);
            return directory;
        }

    }
}
