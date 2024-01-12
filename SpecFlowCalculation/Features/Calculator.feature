Feature: Calculator
!
creating same feature step as CalFeature using class and do calculation by individual method for each
**

@mytag 
Scenario: Add two numbers
	Given the first number is 100
	And the second number is 120
	When the two numbers are added
	Then the result should be

#Scenario: Subtracting the two numbers
	Given the first number 67 and the second number 54
	When subtracting two numbers
	Then result of the subtract

#Scenario: Multiple the above outputs
	When get outputs of add
	Then result of multiply

	Given multiply output as Dividend and 3 as the Divisor 
	Then result of division

# in same Scenario only we can use ScenarioContext. that's why we commented the Scenario for Sub and Multiply
# ScenarioContext is a storage. using the key we can reuse the value inside the scenario later

Scenario: Cumulative sum
	Given the numbers are
	| N1 |
	| 45 |
	| 56 |
	| 67 |
	| 01 |
	| 50 |
	| 99 |
	| 81 |
	| 80 |
	| 12 |
	Then cumulative result

