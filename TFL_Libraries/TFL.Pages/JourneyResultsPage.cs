using AventStack.ExtentReports.Gherkin.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using RazorEngine.Compilation.ImpromptuInterface.Optimization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFL_Libraries.TFL.Core;

namespace TFL_Libraries.TFL.Pages
{
    public class JourneyResultsPage : BasePage
    {
        public JourneyResultsPage(WebDriver Driver) : base(Driver)
        {
        }
        By editJourney = By.XPath("//a[@class='edit-journey']");
        By toLocation = By.Id("InputTo");
        By fromLocation = By.XPath("//span[text()='From:']");
        By updateJourney = By.Id("plan-journey-button");
        By results = By.XPath("//h2[text()='Cycling and other options']");
        By journeyError = By.XPath("//li[@class='field-validation-error']");
        By clearToLocation = By.XPath("//a[text()='Clear To location']");
        By toSuggestion = By.XPath("(//strong[contains(text(),'London Zoo')])[1]");
        By planAJourney = By.XPath("//ol//a[text()='Plan a journey']");
        By fromLocationResult= By.XPath("//span[text()='From:']/following-sibling::span/strong");
        By toLocationResult= By.XPath("//span[text()='To:']/following-sibling::span/strong");
        By leavingTimeResult = By.XPath("//*[@id=\"plan-a-journey\"]/div[1]/div[2]/strong");

        public void VerifyTheJourneyResults()
        {
            var journeyDetails = WaitAndGetElement(results, "Journey details is display in JourneyResultsPage");
            Assert.IsTrue(journeyDetails.Displayed, "Journey details is not displayed on the JourneyResultsPage");
            var flocation = WaitAndGetElement(fromLocationResult, "From Location is identified in the JourneyResultsPage");
            var tlocation = WaitAndGetElement(toLocationResult, "To Location is identified in the JourneyResultsPage");
            var tleaving = WaitAndGetElement(leavingTimeResult, "Leaving Time is identified in the JourneyResultsPage");
            ReportManager.eTest.Info("Identified from location as '" + flocation.Text + "' and to location as '" + tlocation.Text + "' and leaving time is '" + tleaving.Text + "' in the JourneyResultsPage");
        }
        public void VerifyJourneyError()
        {
            var jError = WaitAndGetElement(journeyError, "Journey Error message is display in JourneyResultsPage");
            Assert.IsTrue(jError.Text.Equals("Sorry, we can't find a journey matching your criteria"), "Error Message is not displayed in JourneyResultsPage");
        }
        public void AmendJourney()
        {
            WaitAndClick(editJourney, "Clicked on Edit Journey link in JourneyResultsPage");
            WaitAndClick(clearToLocation, "Clicked on X to clear the To Location in JourneyResultsPage");
            WaitAndEnter(toLocation, "London Zoo", "Entered London Zoo in To Location in JourneyResultsPage");
            WaitAndClick(toSuggestion, "Clicked on the first To suggetion");
            WaitAndClick(updateJourney, "Clicked on Update Journey in JourneyResultsPage");
            var flocation = WaitAndGetElement(fromLocationResult, "From Location is identified in the JourneyResultsPage");
            var tlocation = WaitAndGetElement(toLocationResult, "To Location is identified in the JourneyResultsPage");
            var tleaving = WaitAndGetElement(leavingTimeResult, "Leaving Time is identified in the JourneyResultsPage");
            ReportManager.eTest.Info("Identified from location as '" + flocation.Text + "' and to location as '" + tlocation.Text + "' and leaving time is '" + tleaving.Text + "' in the JourneyResultsPage");
        
        }
        public void VerifyAmendJourney()
        {
            var toLabel = WaitAndGetElement(toSuggestion, "Update To label is displayed in JourneyResultsPage");
            Assert.IsTrue(toLabel.Text.Contains("London Zoo"), "To Location is not updated");
        }
        public void ClickOnPlanAJourney()
        {
            WaitAndClick(planAJourney, "Clicked on Plan A Journey in JourneyResultsPage");
        }
    }
}
