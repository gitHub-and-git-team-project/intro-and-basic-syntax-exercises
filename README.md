﻿# programming-fundamentals
GitHub practise as part of a Software Technologies activity


### Problem 1.              
Debit Card Number

Write a program, which receives **4****integers** on the
console and **prints them** in **4-digit debit card format**. See the
examples below for the appropriate formatting.

#### Examples

 

**Input**

 

**Output**

 

12

433

1

5331

 

0012
  0433 0001 5331

 

9182

4221

12

3

 

9182
  4221 0012 0003

 

812

321

123

22

 

0812
  0321 0123 0022
  
  Problem 03. Miles to Kilometers
  ===============================
Write a program, which converts miles to kilometers. Format the output to the 2nd decimal place.
Note: 1 mile == 1.60934 kilometers

| input         | output         
| ------------- |:-------------:|
| 60            | 96.56         |
| 1             | 1.61          |
| 52.1113       | 83.86         |




 Problem 04. Beverage Labels
 ===========================
Write a program, which reads a food product **name**, **volume**, **energy content****per 100ml** and **sugar content per 100ml**. Calculate the **energy** and **sugar content**
for the **given volume** and print them
on the console in the following format:

·        
Name – as per the input

·        
Volume – **integer**, **suffixed** by “**ml**” (e.g. “**220ml**”)

·        
Energy content – **integer**, **suffixed** by “**kcal**” (e.g. “**500kcal**”)

·        
Sugar content – **real number**, **suffixed** by “**g**” (e.g. “**30g**”) 


#### Examples

 

|**Input**		|	**Output**		|
|-----------------------|-------------------------------|
|Nuka-Cola		|220ml Nuka-Cola:		|
|220			|660kcal,  154g sugars		|
|300			|				|
|70			|				|

 

|**Input**		|	**Output**		|
|-----------------------|-------------------------------|
|Ice Cold Nuka-Cola	|250ml Ice Cold Nuka-Cola:	|
|250			|875kcal, 162.5g sugars		|
|350			|				|
|65			|				|



|**Input**		|	**Output**		|
|-----------------------|-------------------------------|
|Nuka-Cola Quantum	|350ml Nuka-Cola Quantum:	|
|350			|2100kcal, 490g sugars		|
|600			|				|
|140			|				|



  
###  Problem 5 Character stars

Write a program, which displays information about a video game character. You will receive their name, current health, maximum health, current energy and maximum energy on separate lines. The current values will always be valid (equal or lower than their respective max values). Print them in the format as per the examples.

 

**Input**

 

**Output**

 

** **

 

**Input**

 

**Output**

 

Mayro

5

10

9

10

 

Name: Mayro

Health: ||||||.....|

Energy: ||||||||||.|

 

Bauser

10

10

10

10

 

Name: Bauser

Health: ||||||||||||

Energy: ||||||||||||

 

 

**Input**

 

**Output**

 

** **

 

**Input**

 

**Output**

 

Loogi

8

20

2

14

 

Name: Loogi

Health: |||||||||............|

Energy: |||............|

 

Toad

0

5

0

10

 

Name: Toad

Health: |.....|

Energy: |..........|

#### Hints

·        
You can print a character **multiple** times, using new string(character,
count).
