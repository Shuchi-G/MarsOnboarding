Feature: Language

As a Mars Portal User,
I want to add, delete and Edit language feature.
So that the people seeking for the languages can look at what details I hold.

@Language
Scenario: Delete existing languages
	Given Language Tab is selected in Profile Page/
	When I click on Cross icon buttons
	Then Existing languages deleted with delete message
