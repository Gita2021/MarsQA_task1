Feature: Profile Page
         As a seller I want to add my details in profile.
		 I am also able to view my profile details

@mytag
Scenario: I am able to add my Language details
	Given I am logged in at "http://localhost:5000" as user "gitanjali2021@outlook.co.nz" with password "Welcome123"
	And I am at the Profile page
	When I click on Add New button
	And I Add <Language> and <Language Level> on Languages tab
	And I click on Add button
	Then Validate that Language is added

	Examples:
		| Language | Language Level   |
		| English  | Fluent           |
		| Irish    | Native/Bilingual |
		| French   | Conversational   |
		| Spanish  | Basic            |

@mytag
Scenario:I am able to add my skill details
	Given I am logged in at "http://localhost:5000" as user "gitanjali2021@outlook.co.nz" with password "Welcome123"
	And I am at the Profile page
	And I click on Skills tab
	When I click on Add New button
	And I Add <Skill> and <Skill Level> on Skills tab
	And I click on Add button
	Then Validate that Skill is added

	Examples:
		| Skill | Skill Level |
		| C     | Beginner    |
		| Java  | Expert      |

Scenario:I am able to enter Description
	Given I am logged in at "http://localhost:5000" as user "gitanjali2021@outlook.co.nz" with password "Welcome123"
	And I click on Description editter
	When I add the Description in description box
	And I click the save button
	Then the description should be saved and displayed under Description
	And success message is displayed

