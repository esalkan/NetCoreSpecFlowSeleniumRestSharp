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
		Then user should see "Epic sadface: Username and password do not match any user in this service" error message
		Examples: 
			| UserName      | Password     |
			| standard_user | sauce_secret |
			| user_standard | secret_sauce |

	####################################################################################################################
  
	Scenario: Login feature with locked out user credentials
		When enter <UserName> and <Password> credentials
		And click on login button
		Then user should see "Epic sadface: Sorry, this user has been locked out." error message
		Examples: 
		  | UserName        | Password     |
		  | locked_out_user | secret_sauce |
	
	####################################################################################################################

	Scenario: Login feature with valid username and empty password credentials
		When enter <UserName> and <Password> credentials
		And click on login button
		Then user should see "Epic sadface: Password is required" error message
		Examples: 
		  | UserName                | Password |
		  | standard_user           |          |
		  | problem_user            |          |
		  | performance_glitch_user |          |
    
	####################################################################################################################

	Scenario: Login feature with empty username and valid password
		When enter <UserName> and <Password> credentials
		And click on login button
		Then user should see "Epic sadface: Username is required" error message
		Examples: 
		  | UserName | Password     |
		  |          | sauce_secret |
