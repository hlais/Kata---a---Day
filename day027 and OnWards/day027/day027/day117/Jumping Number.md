<a href=https://github.com/hlais/Kata---a---Day><b>Back to README</b><a>

Day #116: 

* <b>Difficulty:</b>7 kyu
* <b>Solution Class:</b> [Jumping Number](Jumping%20Number.cs)
* <b>Solved:</b> Saturday, May 26<sup>th</sup>, 2018

Definition
Jumping number is the number that All adjacent digits in it differ by 1.

Task
Given a number, Find if it is Jumping or not .
Notes
Number passed is always Positive .

Return the result as String .

The difference between ‘9’ and ‘0’ is not considered as 1 .

All single digit numbers are considered as Jumping numbers.

Input >> Output Examples
1- jumpingNumber(9) ==> return "Jumping!!"
Explanation:
It's single-digit number
2- jumpingNumber(79) ==> return "Not!!"
Explanation:
Adjacent digits don't differ by 1
3- jumpingNumber(23) ==> return "Jumping!!"
Explanation:
Adjacent digits differ by 1
4- jumpingNumber(556847) ==> return "Not!!"
Explanation:
Adjacent digits don't differ by 1
5- jumpingNumber(4343456) ==> return "Jumping!!"
Explanation:
Adjacent digits differ by 1
6- jumpingNumber(89098) ==> return "Not!!"
Explanation:
Adjacent digits don't differ by 1
7- jumpingNumber(32) ==> return "Jumping!!"
Explanation:
Adjacent digits differ by 1
