Feature: Login Feature
	Login Feature for SwagLabs https://www.saucedemo.com/

	Background: Reach to the login page
		Given navigate to the login page

	####################################################################################################################
		
	Scenario Outline: Login feature with valid users credentials
		When enter <UserName> and <Password> credentials
		And click on login button
		Then user should be in "inventory.html" page
		Examples: 
			| UserName                | Password     |
			| standard_user           | secret_sauce |
			| problem_user            | secret_sauce |
			| performance_glitch_user | secret_sauce |
    
	####################################################################################################################

	Scenario Outline: Login feature with invalid users credentials
		When enter <UserName> and <Password> credentials
		And click on login button
		Then user should see <ErrorMessage> error message
		Examples: 
		  | UserName                | Password     | ErrorMessage                                                              |
		  | standard_user           |              | Epic sadface: Password is required                                        |
		  |                         | secret_sauce | Epic sadface: Username is required                                        |
		  | standard_user           | random_pass  | Epic sadface: Username and password do not match any user in this service |
		  | problem_user            | random_pass  | Epic sadface: Username and password do not match any user in this service |
		  | performance_glitch_user | random_pass  | Epic sadface: Username and password do not match any user in this service |
		  |                         |              | Epic sadface: Username is required                                        |
    