Feature: LogOut Feature
	Logout Feature for SwagLabs After User Log-in

	Background: 
		Given navigate to the login page
	
	@smoke
	Scenario: User should be able logout
		When enter <UserName> and <Password> credentials
		And click on login button
		Then user should be in "inventory.html" page
		When click on hamburger menu
		And click on logout button
		Then user should be in login "https://www.saucedemo.com/" page
		Examples: 
		  | UserName                | Password     |
		  | standard_user           | secret_sauce |
		  | problem_user            | secret_sauce |
		  | performance_glitch_user | secret_sauce |
	
	@smoke
	Scenario Outline: Verify that after logout user can not reach the inventory page 
		When enter <UserName> and <Password> credentials
		And click on login button
		Then user should be in "inventory.html" page
		When click on hamburger menu
		And click on logout button
		And navigate back
		Then user should see <ErrorMessage> error message
		Examples: 
		  | UserName                | Password     | ErrorMessage                                                                |
		  | standard_user           | secret_sauce | Epic sadface: You can only access '/inventory.html' when you are logged in. |
		  | problem_user            | secret_sauce | Epic sadface: You can only access '/inventory.html' when you are logged in. |
		  | performance_glitch_user | secret_sauce | Epic sadface: You can only access '/inventory.html' when you are logged in. |
   
