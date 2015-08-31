Feature: Login feature
  As a user of web site
  I want to login using different credential combinations
  So that I should be logged in or receive different kinds of 'login incorrect' messages

  Scenario: Regular login with correct credentials
    Given I am on the "https://mmss.bpmonline.com/NuiLogin.aspx" website
    When I enter "Kozhina Masha" into username field
    And I enter "VZKO4xq4" into password field
    And I press submit button
    Then I should be navigated to master page