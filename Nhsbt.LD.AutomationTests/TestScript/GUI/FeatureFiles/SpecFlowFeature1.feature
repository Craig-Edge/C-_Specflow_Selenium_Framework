Feature: Forgot password feature
	A demo feature file which shows the facebook forgot password page

@mynewtag
Scenario: User has forgotten password
	Given I Navigate to the "facebook" homepage
	#below step demonstrates dependency injection
	And I accept all recommended cookies 
	When I click the "forgot password" link
	Then I land on the "Find your account page"
	And I enter my username

@mynewtag
Scenario: User has forgotten password again
	Given I Navigate to the "facebook" homepage	
	And I accept all recommended cookies 
	When I click the "forgot password" link
	Then I land on the "Find your account page"
	And I enter my username poorly