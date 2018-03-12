<a href=https://github.com/hlais/Kata---a---Day><b>Back to README</b><a>

Day #62: 

* <b>Difficulty:</b> 5 kyu
* <b>Solution Class:</b> [Anagrams](Anagrams.cs)
* <b>Solved:</b> Monday, March 12<sup>th</sup>, 2018

<b>Description:</b>

What is an anagram? Well, two words are anagrams of each other if they both contain the same letters. For example:

'abba' & 'baab' == true

'abba' & 'bbaa' == true

'abba' & 'abbba' == false
Write a function that will find all the anagrams of a word from a list. You will be given two inputs a word and an array with words. You should return an array of all the anagrams or an empty array if there are none. For example:

Kata.Anagrams("abba", new List<string> {"aabb", "abcd", "bbaa", "dada"}) => new List<string> {"aabb", "bbaa"}

Kata.Anagrams("racer", new List<string> {"crazer", "carer", "racar", "caers", "racer"}) => new List<string> {"carer", "racer"}

Kata.Anagrams("laser", new List<string> {"lazing", "lazy", "lacer"}) => new List<string>()
