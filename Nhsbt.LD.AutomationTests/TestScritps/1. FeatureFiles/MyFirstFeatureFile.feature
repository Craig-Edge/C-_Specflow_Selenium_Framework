Feature: MyFirstFeatureFile
	Our first automation tests


Background: 

Given I navigate to the "Customer" page	

@smoke_tests
Scenario: Click the "Sort By" button and the "More Filters" button	
	When I click on the "Sort By" button
	And I click on the "More Filters" button
	Then the type label will be displayed

@smoke_tests
	Scenario: Navigate to the partners page and enter some data	
	When I click on the "Partners" nav button
	And I enter data into the "Search" field
	Then the search result text is correct

#@smoke
#Scenario: Click the "Sort By" button and the "More Filters" button again
#	When I click on the "button" button
#	| button       |
#	| Sort By      |
#	| More Filters |
#	Then the type label will be displayed
#
#@smoke_scenarioOutline
#Scenario Outline: Click the "Sort By" button and the "More Filters" button for a third time
#	When I click on the <button> button
#	Then the type label will be displayed
#
#	Examples: 
#
#	| scenario | button       | text   |
#	| sc1      | Sort By      | owehuc |
#	| sc2      | More Filters | woeihf |