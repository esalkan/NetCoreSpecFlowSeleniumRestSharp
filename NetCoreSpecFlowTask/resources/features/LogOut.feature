# @author esalkan
# @vcard https://esalkan.com
# @project MeDirect - Skill Assessment
# @type Web & Api Automation 
# @repo https://github.com/esalkan/AutomationNetCoreSpecFlowSelenium.git

Feature: LogOut Feature
	User should be able to logout successfully after login to the application

	####################################################################################################################
	
	Background: 
		Given navigate to the login page
	
	####################################################################################################################
		
	@smoke
	@logOut
	@regression_1
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
	
	####################################################################################################################

	@smoke
	@regression_1
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