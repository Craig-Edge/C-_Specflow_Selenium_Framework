Feature: Forgot password feature
	Simple calculator for adding two numbers

@mynewtag
Scenario: User has forgotten password
	Given I Navigate to the "facebook" homepage
	#below step demonstrates dependency injection
	And I accept all recommended cookies 
	When I click the "forgot password" link
	Then I land on the "Find your account page"
	And I enter my username