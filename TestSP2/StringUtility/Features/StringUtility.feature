Feature: StringUtility

A Utility to reverse, capitalize and lowercase a string.

@StringUtility
Scenario: Reverse String
	Given The input string BDD sp2
	When The string is reversed
	Then The contents of the input string is reversed

@StringUtility
Scenario: Capitalize String
	Given The input string BDD sp2
	When The string is capitalized
	Then The contents of the input string is capitalized

@StringUtility
Scenario: Lowercase String
	Given The input string BDD sp2
	When The string is lowercased
	Then The contents of the input string is lowercased