Feature: InputManagerTests
	Scenarios to test out the varios helper methods in the InputManager helper class

@input_manager
Scenario: Navigate to HTML form on W3 schools, enter data and click submit
	Given I have navigated to the W3 schools hompage
	And I have navigated to the html forms practice page
	When I enter "Craig" into the "Gordon" Field
	When I enter "lastName" into the "Last Name" Field
	And I click the "Submit" button
	Then The data will be successfully submitted