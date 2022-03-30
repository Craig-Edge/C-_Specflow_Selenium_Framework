Feature: SandboxPOC1
	Simple feature file for testing out interaction in the Sandbox environment

@Sandbox_POC
Scenario: Interact with dropdowns on the Dashboard
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
	