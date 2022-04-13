Feature: TestWebsite
	Loading a website

@testwebsite
Scenario: Launching a website
	Given I navigate to the dashboard of the test environment
	When I click on Search button
	Then I enter "data" in Search box

	@testwebsite
Scenario: Launching a website again
	Given I navigate to the dashboard of the test environment
	When I click on Search button
	Then I enter data in Search box
	#Then I click on Total button



#	@testwebsite
#    Scenario Outline: Launching a website
#	Given I navigate to the dashboard of the test environment
#	When I click on Search button
#	Then I enter <data> in Search box
#	#Then I click on Total button
#
#	@source:Data.xlsx
#	Examples:
#	| data |