Feature: PizzaOrder

A short summary of the feature

@tag1
Scenario: Calculate total amount for a pizza order
	Given the customer has selected two Farm House pizzas with price Rs.860
	When the customer checks the total amount
	Then the total amount should be Rs.1720