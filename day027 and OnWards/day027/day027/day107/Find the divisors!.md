﻿<a href=https://github.com/hlais/Kata---a---Day><b>Back to README</b><a>

Day #107: 

* <b>Difficulty:</b>6 kyu
* <b>Solution Class:</b> [Find the divisors!](Find%20the%20divisors.cs)
* <b>Solved:</b> Sunday, May 13<sup>th</sup>, 2018

Create a function named divisors/Divisors that takes an integer and returns an array with all of the integer's divisors(except for 1 and the number itself). If the number is prime return the string '(integer) is prime' (null in C#) (use Either String a in Haskell and Result<Vec<u32>, String> in Rust).

Example:
Kata.Divisors(12) => new int[] {2, 3, 4, 6};
Kata.Divisors(25) => new int[] {5};
Kata.Divisors(13) => null;
You can assume that you will only get positive integers as inputs.
