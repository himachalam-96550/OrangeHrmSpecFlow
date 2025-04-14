Feature: Admin module feature

Scenario: Validate The admim modul seaarch user by name
Given     User login with valid username and password to the application
When     Navigates to the admin module and search with name 
Then    Validate the user with all details in the grid