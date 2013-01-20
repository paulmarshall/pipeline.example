Feature: List customers
	As a shop owner
	I want to retrieve a list of my customers
	So that I know who buys stuff from me

@SmokeTest
Scenario: Customer service available
	Given I have customers
	When I request a list of customers
	Then I should get a response back

Scenario: All customers
	Given I have customers
	When I request a list of customers
	Then I should be given a list of customers
