Feature: Cart
    Cart page functionality
    
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
    @regression_2
    Scenario: Checkout Product
        And user select a random product 
        And user add the product to the chart
        And navigate to cart page
        And click on checkout button
        And enter "Eyüp Sabri" first name and "ALKAN" last name and "54100" postal code
        Then user should be in "checkout-step-one.html" page
    ####################################################################################################################
        
    @smoke
    @regression_2
    Scenario: Remove Item
        And user select a random product 
        And user add the product to the chart
        And navigate to cart page
        When user click remove the product 
        Then user should no longer see item in cart