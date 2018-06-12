﻿<a href=https://github.com/hlais/Kata---a---Day><b>Back to README</b><a>

Day #131: 

* <b>Difficulty:</b> 6 kyu
* <b>Solution Class:</b> [Rectangle Into Square](Rectangle%20Into%20Squares.cs)
* <b>Solved:</b> Tuesday, June 12<sup>th</sup>, 2018

Details:

The drawing below gives an idea of how to cut a given "true" rectangle into squares ("true" rectangle meaning that the two dimensions are different).

alternative text

Can you translate this drawing into an algorithm?

You will be given two dimensions

a positive integer length (parameter named lng)
a positive integer width (parameter named wdth)
You will return an array or a string (depending on the language; Shell bash and Fortran return a string) with the size of each of the squares.

  sqInRect(5, 3) should return a List<int> {3, 2, 1, 1}
  sqInRect(3, 5) should return a List<int> {3, 2, 1, 1}
Notes:
lng == wdth as a starting case would be an entirely different problem and the drawing is planned to be interpreted with lng != wdth. (See kata, Square into Squares. Protect trees! http://www.codewars.com/kata/54eb33e5bc1a25440d000891 for this problem). When the initial parameters are so that lng == wdth, the solution [lng] would be the most obvious but not in the spirit of this kata so, in that case, return None/nil/null/Nothing. Return {} with C++. In that case the returned structure of C will have its sz component equal to 0. Return the string "nil" with Bash and Fortran.

You can see more examples in "RUN SAMPLE TESTS".
