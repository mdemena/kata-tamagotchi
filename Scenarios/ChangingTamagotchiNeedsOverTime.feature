Feature: ChangingTamagotchiNeedsOverTime
	As a Tamagotchi owner
	I want my Tamagotchi's needs to change over time
	So that I have to look after it carefully

@changingTamagotchiNeedsOverTime
Scenario: ChangingTamagotchiNeedsOverTime
	Given I have a Tamagotchi
	When time passes
	Then it's tiredness is increased
	And it's hungriness is increased
	And it's happiness is decreased
