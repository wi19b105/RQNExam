Feature: SpecFlowFeature1
	Entwicklung eines Taschenrechner Projekts für trigonometrische Funktionen

@mytag
Scenario: sin(pi)
	Given the number is pi
	And I choose sinus
	When the calculator calculates
	Then the result should be 0

	Scenario: cosinus(pi)
	Given the number is pi
	And I choose cosinus
	When the calculator calculates
	Then the result should be -1

	Scenario:  tangens(pi)
	Given the number is pi
	And I choose tangens
	When the calculator calculates
	Then the result should be 0