<a href=https://github.com/hlais/Kata---a---Day><b>Back to README</b><a>

Day #121: 

* <b>Difficulty:</b>7 kyu
* <b>Solution Class:</b> [Fizz Buzz](Fizz%20Buzz.cs)
* <b>Solved:</b> Wenesday, May 30<sup>th</sup>, 2018

Return an array containing the numbers from 1 to N, where N is the parametered value. N will never be less than 1 (in C#, N might be less then 1).

C# ONLY: If N is smaller then or equal to 0, throw an ArgumentOutOfRangeException!
Replace certain values however if any of the following conditions are met:

If the value is a multiple of 3: use the value 'Fizz' instead
If the value is a multiple of 5: use the value 'Buzz' instead
If the value is a multiple of 3 & 5: use the value 'FizzBuzz' instead
C# method calling example:

string[] result = FizzBuzz.GetFizzBuzzArray(3); // => [ "1", "2", "Fizz" ]
