<a href=https://github.com/hlais/Kata---a---Day><b>Back to README</b><a>

Day #93: 

* <b>Difficulty:</b>6 kyu
* <b>Solution Class:</b> [Format Words Into Sentence.](Format%20words%20into%20a%20sentence.cs)
* <b>Solved:</b> Friday, April 20<sup>th</sup>, 2018


Complete the method so that it formats the words into a single comma separated value. The last word should be separated by the word 'and' instead of a comma. The method takes in an array of strings and returns a single formatted string. Empty string values should be ignored. Empty arrays or null/nil values being passed into the method should result in an empty string being returned.

Kata.FormatWords(new string[] {"ninja", "samurai", "ronin"}) => "ninja, samurai and ronin"
Kata.FormatWords(new string[] {"ninja", "", "ronin"}) => "ninja and ronin"
Kata.FormatWords(new string[] {}) => ""
