Feature: BetwayFavourit
	In order to add favourites in Betway
	As a us
	I want to able to add favourite
@betwayfavourite
Scenario: add favourite
	Given I navigate to Betway
	And I loged in to betway
	When I click on favourites
	Then I checked favourites are empty
	When I click on home
	And I add favourites
	Then the game is added to the favourites
