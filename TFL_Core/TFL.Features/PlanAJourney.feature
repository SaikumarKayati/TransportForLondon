Feature: PlanAJourney

User can plan a journey and can change the at any point

@PlanAJourney
Scenario: Verify that user can plan the journey
	Given I can see the PlanAJourney layout
	#And I entered valid the From and To locations
	And I enter from location as "London Bridge" and to location "Croydon"
	When I clicked on PlanMyJourney
	Then I can see the output in JourneyResultPage

@PlanAJourney
Scenario: Verify that user cannot find the jouney without valid locations
	Given I can see the PlanAJourney layout
	And I entered from location as "Liverpool Street" and to location as "$$$"
	When I clicked on PlanMyJourney
	Then I can see no journey found

@PlanAJourney
Scenario: Verify that user cannot plan the journey without From and To locations
	Given I can see the PlanAJourney layout
	When I clicked on PlanMyJourney
	Then I can see the error message for both From and To locations

@PlanAJourney
Scenario: Verify that user can plan the journey based on ArrivalTime
	Given I can see the PlanAJourney layout
	And I select the Arrival Time
	And I enter from location as "Mile End" and to location "Stratford"
	When I clicked on PlanMyJourney
	Then I can see the output in JourneyResultPage

@PlanAJourney
Scenario: Verify that user can Amend the Journey at anytime
	Given I can see the PlanAJourney layout
	And I enter from location as "Vauxhall" and to location "Croydon"
	And I clicked on PlanMyJourney
	And I can see the output in JourneyResultPage
	When I Amend the journey in the results
	Then I can see the journey is Amended

@PlanAJourney
Scenario: Verify that user can see the recent journies
	Given I can see the PlanAJourney layout
	When I enter from location as "East Ham" and to location "Croydon"
	And I clicked on PlanMyJourney
	Then I can see the output in JourneyResultPage
	When I return to HomePage
	And I enter from location as "South Kensington" and to location "East Ham"
	And I clicked on PlanMyJourney
	And I return to HomePage
	Then I can see the recent journies




