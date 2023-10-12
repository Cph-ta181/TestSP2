# TestSP2

## Reflections

### 1.1 Computer Mouse  
Identify the types of testing you would perform on a computer mouse, to make sure that it is of the higest quality.  

I would perform Unit Testing on each of the individual parts of the mouse (mouse1, mouse2, scroll wheel, sensor etc.) Then I would perform Tntegration Tests to make sure, that the individual parts of the mouse actually work together (movement of mouse while scrolling and clicking).  
Usability Testing could also be a great choice to ensure that the design works as intended and that the user can give feedback about improvements or things that just didn't work that well.  

Acceptance Testing helps identifying if the business requirements are met and are essential in making sure that the product is capable of performing the required tasks and thereby maintaining the higest quality.  

Furthermore, Performance Testing could also help ensuring the higesht quality of mouse by testing its durability but also its performance during high workloads. 

### 1.2 Catastrophic Failure  
Find a story where a software system defect had a bad outcome. Describe what happened. Can you find a test that would have prevented it?  

## Two Katas  
Complete the following using BDD.  

### String Unity  
Use BDD to create a string utility with the following methods:  
* Reverse string (aBc -> cBa)
* Capitalize string (aBC -> ABC)
* Lowercase string (aBc -> abc)

Don't use any built-in string utility – create your own. Remember, the exercise here is to
use BDD, not to deliver a working utility without tests. If there are no tests in the
solution, it won’t be accepted.  

### Bowling Game Kata  
Complete the Bowling Game Kata using BDD. The slides can be found here:  
http://butunclebob.com/files/downloads/Bowling%20Game%20Kata.ppt  

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
