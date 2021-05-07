Feature: 5AddtitionalInfoInProfile
	Adding addtitional information for user

@addingInfo
Scenario: 005Adding addtitional information for exists user
	Given Login successfully and go to profile page
	And Fill all fields in addtitional info module
	When Press the save button
	Then Save successfully information shoud be displayed