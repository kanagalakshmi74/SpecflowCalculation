Feature: CalFeature

A short summary of the feature

@tag
Scenario: Adding the two numbers
	Given the first number 67 and second number 54
	When adding two numbers
	Then result of the addition 121

Scenario: Subtracting the two numbers
	Given the first number 67 and second number 54
	When substracting two numbers
	Then result of the subtract 13

Scenario: Multiplyin the two outputs
	Given the numbers 121, 13
	When Multiply two numbers
	Then result of the multiply 1573

Scenario: Division
	Given multiply output 1573 as Dividend subtract output 54 as the Divisor 
	When dividing
	Then result of the division 29.12