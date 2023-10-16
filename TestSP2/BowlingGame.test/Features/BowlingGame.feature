Feature: BowlingGame

A short summary of the feature

@BowlingGame
Scenario: New Game
	Given A fresh game of bowling
	When Player has not yet rolled
	Then The score is 0

@BowlingGame
Scenario: Game of 1's
	Given A fresh game of bowling
	When Player rolls 20 1's
	Then The score is 20


@BowlingGame
Scenario: Player gets a spare
	Given A fresh game of bowling
	When Player rolls 3 7 2
	Then The score is 14

@BowlingGame
Scenario: Player gets a strike
	Given A fresh game of bowling
	When Player rolls 10 2 2
	Then The score is 18

@BowlingGame
Scenario: Player gets a perfect game
	Given A fresh game of bowling
	When Player rolls strikes only
	Then The score is 300