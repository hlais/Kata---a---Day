﻿<a href=https://github.com/hlais/Kata---a---Day><b>Back to README</b><a>

Day #120: 

* <b>Difficulty:</b>6 kyu
* <b>Solution Class:</b> [Surrounding Primes for a value](SurroundingPrimesForValue.cs)
* <b>Solved:</b> Tuesday, May 29<sup>th</sup>, 2018

We need a function prime_bef_aft() that gives the largest prime below a certain given value n,

befPrime or bef_prime (depending on the language),

and the smallest prime larger than this value,

aftPrime/aft_prime (depending on the language).

The result should be output in a list like the following:

PrimeBefAft == {befPrime, aftPrime}
If n is a prime number it will give two primes, n will not be included in the result.

Let's see some cases:

PrimeBefAft(100) --> {97, 101}

PrimeBefAft(97) --> {89, 101}

PrimeBefAft(101) --> {97, 103}
