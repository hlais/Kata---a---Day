<a href=https://github.com/hlais/Kata---a---Day><b>Back to README</b><a>

Day #152: 

* <b>Difficulty:</b> 6 kyu
* <b>Solution Class:</b> [Make the Deadfish swim](DeadFish.cs)
* <b>Solved:</b> Sunday, July 15<sup>th</sup>, 2018

Details:

Write a simple parser that will parse and run Deadfish.

Deadfish has 4 commands, each 1 character long:

i increments the value (initially 0)
d decrements the value
s squares the value
o outputs the value into the return array
Invalid characters should be ignored.

Deadfish.Parse("iiisdoso")  ==>  new int[] {8, 64}
