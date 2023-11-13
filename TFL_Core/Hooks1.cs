using TechTalk.SpecFlow;
using TFL_Libraries.TFL.Core;
using TFL_Libraries.TFL.Pages;

namespace TFL_Tests
{
    [Binding]
    public sealed class Hooks1
    {
        static string directoryLocation { get; set; }
        static BasePage basePage;

        [BeforeFeature]
        public static void BeforeFeature()
        {
            directoryLocation = ReportManager.CreateReport();
        }
        [BeforeScenario]
        public static void BeforeScenario()
        {
            var scenarioName = ScenarioContext.Current.ScenarioInfo.Title;
            ReportManager.eTest = null;
            ReportManager.eTest = ReportManager.eReports.CreateTest(scenarioName);
            Drivers drivers = new Drivers();
            var Driver = drivers.StartDriver();
            BasePage basePage = new BasePage(Driver);
            basePage.NavigateToUrl("https://tfl.gov.uk/");
        }
        [AfterScenario]
        public static void AfterScenario()
        {
            basePage = new BasePage(Drivers.driver);
            basePage.TakeScreenShot(directoryLocation +"\\"+ DateTime.Now.ToString("MMddyyyyhhmmss"));
            Drivers.driver.Quit();
        }
        [AfterFeature]
        public static void AfterFeature()
        {
            ReportManager.eReports.Flush();
        }
    }
}