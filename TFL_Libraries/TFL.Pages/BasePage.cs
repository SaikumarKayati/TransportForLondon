using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFL_Libraries.TFL.Core;

namespace TFL_Libraries.TFL.Pages
{
    public class BasePage
    {
        protected WebDriver driver;
        public BasePage(WebDriver Driver)
        {
            driver=Driver;
        }
        public void WaitAndClick(By locator, string message)
        {
            for (int i = 1; i <= 10; i++)
            {
                IWebElement element = null;
                try
                {
                    element = driver.FindElement(locator);
                    if (element.Enabled)
                    {
                        element.Click();
                        ReportManager.eTest.Pass(message);
                        break;
                    }
                }
                catch
                {
                    Thread.Sleep(1000);
                }
            }
        }
        public void WaitAndEnter(By locator, string input, string message)
        {
            for (int i = 1; i <= 10; i++)
            {
                IWebElement element = null;
                try
                {
                    element = driver.FindElement(locator);
                    if (element.Enabled)
                    {
                        element.SendKeys(input);
                        ReportManager.eTest.Pass(message);
                        break;
                    }
                }
                catch
                {
                    Thread.Sleep(1000);
                }
            }
        }
        public IWebElement WaitAndGetElement(By locator, string message)
        {
            IWebElement element = null;
            for (int i = 1; i <= 10; i++)
            {
                try
                {
                    element = driver.FindElement(locator);
                    if (element.Enabled)
                    {
                        ReportManager.eTest.Pass(message);
                        break;
                    }
                }
                catch
                {
                    Thread.Sleep(1000);
                }
            }
            return element;
        }
        public void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public void TakeScreenShot(string location)
        {
            var screenshot = driver as ITakesScreenshot;
            var screen=screenshot.GetScreenshot();
            screen.SaveAsFile(location);
            ReportManager.eTest.AddScreenCaptureFromPath(location);
        }

    }
}
