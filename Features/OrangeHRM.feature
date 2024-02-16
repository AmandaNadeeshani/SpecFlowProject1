Feature: Platform login

A short summary of the feature

@tag1
Scenario Outline: Platform login
	Given open the browser
	When Enter the orangeHRM URL
	Then search with <username> and <password>
	Examples:
	| username | password |
	| admin1   | admin123 |
	| admin    | admin123 |
