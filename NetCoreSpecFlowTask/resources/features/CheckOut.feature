Feature: Checkout Feature
    Background: User is on the login page
        Given navigate to the login page
        When enters valid credentials
          | UserName      | Password     |
          | standard_user | secret_sauce |
        And click on login button
        Then user should be in "inventory.html" page

    Scenario: All Fields Empty Error Message
        And user select a random product 
        And user add the product to the chart
        And navigate to cart page
        And click on checkout button
        Then user should be in "checkout-step-one.html" page
        And click on continue button
        Then user should see the error message "Error: First Name is required"

    Scenario: Last Name Error Message
        And user select a random product 
        And user add the product to the chart
        And navigate to cart page
        And click on checkout button
        Then user should be in "checkout-step-one.html" page
        And enter first name "Eyüp Sabri"
        And click on continue button
        Then user should see the error message "Error: Last Name is required"

    Scenario: Postal Code Error Message
        And user select a random product 
        And user add the product to the chart
        And navigate to cart page
        And click on checkout button
        Then user should be in "checkout-step-one.html" page
        And enter first name "Eyüp Sabri" 
        And enter last name "ALKAN"
        And click on continue button
        Then user should see the error message "Error: Postal Code is required"
