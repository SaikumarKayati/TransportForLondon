using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFL_Libraries.TFL.Core
{
    public class Drivers
    {
        public static WebDriver driver { get;set; }
        public WebDriver StartDriver()
        {
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                ReportManager.eTest.Pass("Chrome browser is opened successfully");
            }
            catch (Exception ex)
            {
                ReportManager.eTest.Fail(ex.StackTrace);
                throw ex;
            }
            return driver;
        }
    }
}
