# @author esalkan
# @vcard https://esalkan.com
# @project MeDirect - Skill Assessment
# @type Web & Api Automation 
# @repo https://github.com/esalkan/AutomationNetCoreSpecFlowSelenium.git

Feature: SingleProductDetails
	Controlling single product details which are shown in the inventory page.
	
	####################################################################################################################
	
	Background: User is on the login page
		Given navigate to the login page
		When enters valid credentials
		  | UserName      | Password     |
		  | standard_user | secret_sauce |
		And click on login button
		Then user should be in "inventory.html" page
	
	####################################################################################################################
			
	@smoke
	@regression_1
	Scenario Outline: Verify that product details are right in single product page
		And user navigate single product <Product> page
		Then verify <Product> name and <Description> description and <Price> price
		Examples: 
		  | Product                           | Description                                                                                                                                                            | Price |
		  | Sauce Labs Backpack               | carry.allTheThings() with the sleek, streamlined Sly Pack that melds uncompromising style with unequaled laptop and tablet protection.                                 | 29.99 |
		  | Sauce Labs Bike Light             | A red light isn't the desired state in testing but it sure helps when riding your bike at night. Water-resistant with 3 lighting modes, 1 AAA battery included.        | 9.99  |
		  | Sauce Labs Bolt T-Shirt           | Get your testing superhero on with the Sauce Labs bolt T-shirt. From American Apparel, 100% ringspun combed cotton, heather gray with red bolt.                        | 15.99 |
		  | Sauce Labs Bolt T-Shirt           | Get your testing superhero on with the Sauce Labs bolt T-shirt. From American Apparel, 100% ringspun combed cotton, heather gray with red bolt.                        | 15.99 |
		  | Sauce Labs Fleece Jacket          | It's not every day that you come across a midweight quarter-zip fleece jacket capable of handling everything from a relaxing day outdoors to a busy day at the office. | 49.99 |
		  | Sauce Labs Onesie                 | Rib snap infant onesie for the junior automation engineer in development. Reinforced 3-snap bottom closure, two-needle hemmed sleeved and bottom won't unravel.        | 7.99  |
		  | Test.allTheThings() T-Shirt (Red) | This classic Sauce Labs t-shirt is perfect to wear when cozying up to your keyboard to automate a few tests. Super-soft and comfy ringspun combed cotton.              | 15.99 |