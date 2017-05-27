Feature: PuttingTamagotchiToBed
	As a Tamagotchi owner
	I want to put my Tamagotchi to bed
	So that I can refill it's energy

@puttingTamagotchiToBed
Scenario: PuttingTamagotchiToBed
	Given I have a Tamagotchi
	When I put it to bed
	Then it's tiredness is decreased
