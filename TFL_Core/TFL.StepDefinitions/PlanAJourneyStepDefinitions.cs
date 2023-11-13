using System;
using System.Runtime.Intrinsics.X86;
using TechTalk.SpecFlow;
using TFL_Libraries.TFL.Core;
using TFL_Libraries.TFL.Pages;

namespace TFL_Tests.TFL.StepDefinitions
{
    [Binding]
    public class PlanAJourneyStepDefinitions : BaseTest
    {
        [Given(@"I can see the PlanAJourney layout")]
        public void GivenICanSeeThePlanAJourneyLayout()
        {
            try
            {
                GetPage<HomePage>().VerifyPlanAJourney();
            }
            catch (Exception ex)
            {
                ReportManager.eTest.Fail(ex.StackTrace);
                throw ex;
            }
        }

        [Given(@"I entered valid the From and To locations")]
        public void GivenIEnteredValidTheFromAndToLocations(string fromLocation, string toLocation)
        {
            try
            {
                GetPage<HomePage>().EnterFromAndToLocations( fromLocation, toLocation);
            }
            catch (Exception ex)
            {
                ReportManager.eTest.Fail(ex.StackTrace);
                throw ex;
            }
        }


        [Given(@"I enter from location as ""([^""]*)"" and to location ""([^""]*)""")]
        [When(@"I enter from location as ""([^""]*)"" and to location ""([^""]*)""")]
        public void GivenIEnterFromLocationAsAndToLocation(string fromLocation, string toLocation)
        {
            try
            {
                GetPage<HomePage>().EnterFromAndToLocations( fromLocation,  toLocation);
            }
            catch (Exception ex)
            {
                ReportManager.eTest.Fail(ex.StackTrace);
                throw ex;
            }
        }


        [When(@"I clicked on PlanMyJourney")]
        [Given(@"I clicked on PlanMyJourney")]
        public void WhenIClickedOnPlanMyJourney()
        {
            try
            {
                GetPage<HomePage>().ClickOnPlanForJourney();
            }
            catch (Exception ex)
            {
                ReportManager.eTest.Fail(ex.StackTrace);
                throw ex;
            }
        }

        [Then(@"I can see the output in JourneyResultPage")]
        [Given(@"I can see the output in JourneyResultPage")]
        public void ThenICanSeeTheOutputInJourneyResultPage()
        {
            try
            {
                GetPage<JourneyResultsPage>().VerifyTheJourneyResults();
            }
            catch (Exception ex)
            {
                ReportManager.eTest.Fail(ex.StackTrace);
                throw ex;
            }
        }

        [Then(@"I can see the error message for both From and To locations")]
        public void ThenICanSeeTheErrorMessageForBothFromAndToLocations()
        {
            try
            {
                GetPage<HomePage>().VerifyTheErrorMessages();
            }
            catch (Exception ex)
            {
                ReportManager.eTest.Fail(ex.StackTrace);
                throw ex;
            }
        }
        [Given(@"I entered from location as ""([^""]*)"" and to location as ""([^""]*)""")]
        public void GivenIEnteredRightFromLocationAndInvalidToLocation(string fromLocation, string toLocation)
        {
            try
            {
                GetPage<HomePage>().EnterInvalidLocations( fromLocation,  toLocation);
            }
            catch (Exception ex)
            {
                ReportManager.eTest.Fail(ex.StackTrace);
                throw ex;
            }
        }

        [Then(@"I can see no journey found")]
        [Given(@"I can see no journey found")]
        public void ThenICanSeeNoJourneyFound()
        {
            try
            {
                GetPage<JourneyResultsPage>().VerifyJourneyError();
            }
            catch (Exception ex)
            {
                ReportManager.eTest.Fail(ex.StackTrace);
                throw ex;
            }
        }
        [Given(@"I select the Arrival Time")]
        public void GivenISelectTheArrivalTime()
        {
            try
            {
                GetPage<HomePage>().ArrivalTimeJourney();
            }
            catch (Exception ex)
            {
                ReportManager.eTest.Fail(ex.StackTrace);
                throw ex;
            }
        }

        [When(@"I Amend the journey in the results")]
        public void WhenIAmendTheJourneyInTheResults()
        {
            try
            {
                GetPage<JourneyResultsPage>().AmendJourney();
            }
            catch (Exception ex)
            {
                ReportManager.eTest.Fail(ex.StackTrace);
                throw ex;
            }
        }

        [Then(@"I can see the journey is Amended")]
        public void ThenICanSeeTheJourneyIsAmended()
        {
            try
            {
                GetPage<JourneyResultsPage>().VerifyAmendJourney();
            }
            catch (Exception ex)
            {
                ReportManager.eTest.Fail(ex.StackTrace);
                throw ex;
            }
        }
        [When(@"I return to HomePage")]
        public void WhenIReturnToHomePage()
        {
            try
            {
                GetPage<JourneyResultsPage>().ClickOnPlanAJourney();
            }
            catch (Exception ex)
            {
                ReportManager.eTest.Fail(ex.StackTrace);
                throw ex;
            }
        }

        [Then(@"I can see the recent journies")]
        public void ThenICanSeeTheRecentJournies()
        {
            try
            {
                GetPage<HomePage>().VerifyTheRecentJournies();
            }
            catch (Exception ex)
            {
                ReportManager.eTest.Fail(ex.StackTrace);
                throw ex;
            }
        }
       


    }
}
