Feature: 1-2RegisterUserAccountAndLogIn
	Register a user account and login

@registerTests
Scenario: 001Register successfully
	Given Fill effective username
	And Fill effective password
	When press register button
	Then register successfully information should be displayed

@registerTests
Scenario: 001Register unsuccessfully
	Given Fill fatal username
	And Fill fatal password
	When press register button
	Then register unsuccessfully information should be displayed

@loginTests
Scenario: 002login successfully
	Given Fill effective registered username
	And Fill effective registered passwork
	When press login button
	Then username  should be displayed on the system