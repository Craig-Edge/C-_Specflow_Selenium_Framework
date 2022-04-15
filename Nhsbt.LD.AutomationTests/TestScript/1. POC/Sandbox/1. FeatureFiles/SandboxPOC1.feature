Feature: SandboxPOC1
	Simple feature file for testing out interaction in the Sandbox environment

@Sandbox_POC
Scenario: Interact with dropdowns on the Dashboard Page
	Given I navigate to the dashoard of the Sandbox environment	
	And I expand the More Filters section
	When I click the "dropdown" dropdown
	| dropdown                |
	| product                 |
	| geography               |
	| publicily referenceable |
	| status                  |
	| industry                |
	| category                |
	| type                    |
	| marquee customer        |
	| partner                 |
	| competitor              |
	And I select each option from the "publicly referenceable" dropdown
	| option      |
	| Yes         |
	| No          |
	| Potentially |
	| - All -     |
	
@Sandbox_POC
Scenario: Interact with the Side Nav icons 
	Given I navigate to the dashoard of the Sandbox environment	
	When I click the "home" nav button
	And I click the "dashboard" nav button
	And I click the "products & services" nav button
	And I click the "partners" nav button
	And I click the "contacts" nav button
	And I click the "activities" nav button
	And I click the "reports" nav button
	And I click the "administration" nav button

@Sandbox_POC
Scenario: Enter Json data into field
	Given I navigate to the dashoard of the Sandbox environment	
	When I click the "partners" nav button
	And I enter the data from a Json file
	Then the data entered is present in the field

@Sandbox_POC
	Scenario: Enter excel data into field
	Given I navigate to the dashoard of the Sandbox environment	
	When I click the "partners" nav button
	And I load excel data into the scenario context dictionary
	And I enter the data from a excel file
	Then the data entered is present in the field


	