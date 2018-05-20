<a href=https://github.com/hlais/Kata---a---Day><b>Back to README</b><a>

Day #111: 

* <b>Difficulty:</b>6 kyu
* <b>Solution Class:</b> [Valid Braces](Valid%20Braces.cs)
* <b>Solved:</b> Sunday, May 20<sup>th</sup>, 2018

Write a function that takes a string of braces, and determines if the order of the braces is valid. It should return true if the string is valid, and false if it's invalid.

This Kata is similar to the Valid Parentheses Kata, but introduces new characters: brackets [], and curly braces {}. Thanks to @arnedag for the idea!

All input strings will be nonempty, and will only consist of parentheses, brackets and curly braces: ()[]{}.

What is considered Valid?
A string of braces is considered valid if all braces are matched with the correct brace.

Examples
"(){}[]"   =>  True
"([{}])"   =>  True
"(}"       =>  False
"[(])"     =>  False
"[({})](]" =>  False
