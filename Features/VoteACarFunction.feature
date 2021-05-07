Feature: 3-4VoteACarFunction
	Choose and Vote a car

@votetest
Scenario: 003Choose Lamborghini Diablo and vote
	Given go to Popular Model Page
	And choose Lamborghini Diablo and comments
	When press vote
	Then vote successfully should be displayed

@commenttest
Scenario: 004After vote and Comment
	Given go to Popular Model Page
	And choose Lamborghini Diablo
	When browse the comments
	Then comment message should be display in the table