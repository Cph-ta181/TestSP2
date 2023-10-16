# TestSP2

## Reflections

### 1.1 Computer Mouse  
**Identify the types of testing you would perform on a computer mouse, to make sure that it is of the higest quality.**

Perform unit test on each individual component like each button, scroll wheel, and sensor.
Then a integration test to test if the components are working as expectet in conjunction.

### 1.2 Catastrophic Failure  
Find a story where a software system defect had a bad outcome. Describe what happened. Can you find a test that would have prevented it?  

## Two Katas  
### String Utility  
Use BDD to create a string utility with the following methods:  
* Reverse string (aBc -> cBa)
* Capitalize string (aBC -> ABC)
* Lowercase string (aBc -> abc)

[String utility implementation](https://github.com/Cph-ta181/TestSP2/blob/main/TestSP2/TestSP2/StringUtility.cs)\
[String utility feature](https://github.com/Cph-ta181/TestSP2/blob/main/TestSP2/StringUtility/Features/StringUtility.feature)\
[String utility stepdefinition](https://github.com/Cph-ta181/TestSP2/blob/main/TestSP2/StringUtility/StepDefinitions/StringUtilitySteps.cs)

### Bowling Game Kata  
[Bowling game implementation](https://github.com/Cph-ta181/TestSP2/blob/main/TestSP2/BowlingGame/Game.cs)\
[Bowling game feature](https://github.com/Cph-ta181/TestSP2/blob/main/TestSP2/BowlingGame.test/Features/BowlingGame.feature)\
[Bowling game stepdefinition](https://github.com/Cph-ta181/TestSP2/blob/main/TestSP2/BowlingGame.test/StepDefinitions/BowlingGameSteps.cs)

## Investigation Of Tools  

### JUnit 5  
Investigate JUnit 5.
* @tag\
&emsp;Bliver brugt til at gruppere test klasser/metoder der skal eksekveres i en given test plan.
* @Disabled\
&emsp;Disabled bliver brugt til at angive at en given test klasse/metode ikke skal eksekveres.
* @RepeatedTest\
&emsp;Repeated test bliver brugt til at annotere at en given metode er en test-skabelon
* @BeforeEach, @AfterEach\
&emsp;Before og after each bruges til at annotere metoder der enten skal køres lige før, eller lige efter hver enkelt test i den test klasse
* @BeforeAll, @AfterAll\
&emsp;Before/After all annotere metoder der skal køres enten først eller sidst i en test klasse
* @DisplayName\
&emsp;Display name giver et brugerdefineret navn til en given test klasse/metode i stedet for metodens/klassens navn.
* @Nested\
&emsp;Nested annotere at den givne klasse er nested inden i en anden test klasse og kan derfor dele setup med omsluttende klasse.
* assumeFalse, assumeTrue\
&emsp;Assumptions fungere meget som Assertions da de tjekker om en given variable opfylder en given condition. Forskellen er dog at en fejlet Assumption ikke leder til en fejlet test, men at testen i stedet bliver aborted.

### Mocking Frameworks  
#### Mockito vs. EasyMock
* What are their similarities?\
  Begge frameworks opfylder samme behov og har i stor stil de samme funktionaliteter.
* What are their differences?\
  Easymock har en mere consistent opbygning hvilket leder til mere ens-struktureret tests.
  Flere af de mere advancerede mocking funktionaliteter er besværligere i EasyMock og kræver generelt en del mere kode.
  I EasyMock skal et Mock replayes hver gang en Mock skal bruges.
  I Mockito kan man lave et partial mock ved at kalde .thenCallRealMethod() i en mock. I EasyMock er dette sværre da man opbygger et partial mock ved at definere hvilke metoder der skal mockes og hvilke der ikke skal.
* Which one would you prefer, if any, and why?\
  Da begge frameworks opfylder alle mocking behov er det ikke funktionaliteten der seperere dem. Generelt virker det dog som om at Mockito er lettere at bruge og der ud over er Mockito mere brugt og har derfor et større community hvor hjælp kan findes. Derfor ville jeg fortrække Mockito.
