Feature: Purchas
	User should be able to make a purchase successfully

	Background: User is on the login page
		Given navigate to the login page
		When enters valid credentials
		  | UserName      | Password     |
		  | standard_user | secret_sauce |
		And click on login button
		Then user should be in "inventory.html" page
		
Scenario: Verify that user can buy a product
	And user select a random product 
	And user add the product to the chart
	And navigate to cart page
	And click on checkout button
	And enter "Eyüp Sabri" first name and "ALKAN" last name and "54100" postal code
	Then overview the purchase
	And click on finish button
	Then user should be in "checkout-complete.html" page

	  
	
	
	