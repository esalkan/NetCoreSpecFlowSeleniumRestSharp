Feature: Login
	Login Feature for SwagLabs https://www.saucedemo.com/

@wip
Scenario: Login with valid credentials
	Given navigate to the login page
	And enter valid credentials
	| UserName      | Password     |
	| standard_user | secret_sauce |
	And click on login button
	Then user should be in inventory page