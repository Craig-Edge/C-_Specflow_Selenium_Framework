Feature: InputManagerTests
	Scenarios to test out the varios helper methods in the InputManager helper class

@input_manager
Scenario: Navigate to HTML form on W3 schools, enter data and click submit
	Given I have navigated to the W3 schools hompage
	#And I have accepted all cookies
	And I have navigated to the html forms practice page
	And I click the "Try it yourself" button
	When I enter "Craig" into the "First Name" Field
	When I enter "Gordon" into the "Last Name" Field
	And I click the "Submit" button
	Then The data will be successfully submitted