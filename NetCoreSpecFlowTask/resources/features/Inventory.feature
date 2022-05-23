Feature: Inventories
	User Should be able to see the list of products in the inventory page

	Background: User is on the login page
		Given navigate to the login page
		When enters valid credentials
		  | UserName      | Password     |
		  | standard_user | secret_sauce |
		And click on login button
		Then user should be in "inventory.html" page
	
	Scenario: Verify that user see products in inventory page
		Then verify that user see following products on inventory page
			| ProductName                       |
			| Sauce Labs Backpack               |
			| Sauce Labs Bike Light             |
			| Sauce Labs Bolt T-Shirt           |
			| Sauce Labs Fleece Jacket          |
			| Sauce Labs Onesie                 |
			| Test.allTheThings() T-Shirt (Red) |
    
				  

