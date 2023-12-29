Feature: Language

As a Mars Portal User,
I want to add, delete and Edit language feature.
So that the people seeking for the languages can look at what details I hold.

@language
Scenario: Delete existing languages
	Given Language Tab is selected in Profile Page/
	When I click on Cross icon buttons
	Then Existing languages deleted with delete message


	Scenario Outline: Add new languages with valid input
	Given Language Tab is selected in Profile Page/
	When I click on Add New buttons
	When I give input '<language>','<level>' of language
	Then New languages should be added with add message

	Examples: 
		| language                                         | level          |
	| English                                          | Fluent         |
	| Hindi                                            | Native         |
	| Spaqwserdfggtt1234567890Spaqwserdfggtt1234567890 | Conversational |
	| J@#$%^CV                                         | Basic          |