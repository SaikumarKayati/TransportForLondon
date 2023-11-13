using AventStack.ExtentReports.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TFL_Libraries.TFL.Core;

namespace TFL_Libraries.TFL.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(WebDriver Driver) : base(Driver)
        {
        }
        
        By from = By.Id("InputFrom");
        By to = By.Id("InputTo");
        By planMyJourney = By.Id("plan-journey-button");
        By changeTime = By.XPath("//a[text()='change time']");
        By arriving = By.Id("arriving");
        By header = By.XPath("//div[text()='Plan a journey']");
        By acceptCookies = By.XPath("//strong[text()='Accept all cookies']");
        By manageCookies = By.XPath("//strong[text()='Manage cookies']");
        By functionalityCookies = By.Id("CybotCookiebotDialogBodyLevelButtonPreferences");
        By performanceCookies = By.Id("CybotCookiebotDialogBodyLevelButtonStatistics");
        By advertisingCookies = By.Id("CybotCookiebotDialogBodyLevelButtonMarketing");
        By saveCookieSettings = By.XPath("//strong[text()='Save cookie settings']");
        By selectpartnersDatacookies = By.ClassName("cb-iab-link");
        By Selectfeatures = By.Id("cb-features");
        By selectUsePreciseLocation= By.XPath("//html/body/div[1]/div[3]/div[3]/div[2]/div[2]/div[2]/div[1]/label");
        By selectactivelyScanDevice = By.XPath("/html/body/div[1]/div[3]/div[3]/div[2]/div[2]/div[3]/div[1]/label");
        By fromError = By.Id("InputFrom-error");
        By toError = By.Id("InputTo-error");
        By recentJourney = By.XPath("//div[@id='recent-journeys']/div/a");
        By myJournies = By.XPath("(//a[text()='My Journeys'])[1]");

        public void VerifyPlanAJourney()
        {
            WaitAndClick(acceptCookies, "Accepted all cookies");
            var planAJourney = WaitAndGetElement(header, "Plan A Journey is display in HomePage");
            Assert.IsTrue(planAJourney.Displayed, "Plan A Journey is not displayed on the HomePage");
        }

        public void EnterFromAndToLocations(string fromLocation, string toLocation)
        {
            WaitAndEnter(from, fromLocation, "Entered "+fromLocation+" in From Location in HomePage");
            By fromSuggestion = By.XPath("(//strong[text()='"+ fromLocation + "'])[1]");
            WaitAndClick(fromSuggestion, "Clicked on the first From suggestion");
            WaitAndEnter(to, toLocation, "Entered "+toLocation+" in To Location in HomePage");
            Thread.Sleep(2000);
            By toSuggestion = By.XPath("(//strong[text()='"+toLocation+"'])[1]");
            WaitAndClick(toSuggestion, "Clicked on the first To suggestion");
        }
        public void ClickOnPlanForJourney()
        {
            WaitAndClick(planMyJourney, "Clicked on PlanMyJourney in HomePage");
        }
        public void VerifyTheErrorMessages()
        {
            var fError = WaitAndGetElement(fromError, "From Error message is displayed in HomePage");
            var tError = WaitAndGetElement(toError, "To Error message is displayed in HomePage");
            Assert.IsTrue(fError.Text.Equals("The From field is required."), "From Error is not displayed");
            Assert.IsTrue(tError.Text.Equals("The To field is required."), "To Error message is not displayed");
        }
        public void EnterInvalidLocations(string fromLocation, string toLocation)
        {
            WaitAndEnter(from, fromLocation, "Entered "+fromLocation+" in From Location in HomePage");
            By fromSuggestion = By.XPath("(//strong[text()='" + fromLocation + "'])[1]");
            WaitAndClick(fromSuggestion, "Clicked on the first From suggestion");
            WaitAndEnter(to, toLocation, "Entered "+toLocation+" in To Location in HomePage");
            Thread.Sleep(2000);
        
        }
        public void ArrivalTimeJourney()
        {
            WaitAndClick(changeTime, "Clicked on Change Time link in HomePage");
            WaitAndClick(arriving, "Clicked on Arriving Option in HomePage");
        }

        public void VerifyTheRecentJournies()
        {
            Thread.Sleep(1000);
            var rJourney = WaitAndGetElement(recentJourney, "Recent Journey from and to is displayed in HomePage");
            Assert.IsTrue(rJourney.Text.Contains("South Kensington"), "From location is present in the recent journies");
            Assert.IsTrue(rJourney.Text.Contains("East Ham"), "To location is present in the recent journies");
        }
    }
}
