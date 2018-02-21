<a href=https://github.com/hlais/Kata---a---Day><b>Back to README</b><a>

Day #42: 

* <b>Difficulty:</b> 6 kyu
* <b>Solution Class:</b> [Who Likes This](Likes.cs)
* <b>Solved:</b> Tuesday, February 2 <sup>th</sup>, 2018

<b>Description:</b>

You probably know the "like" system from Facebook and other pages. People can "like" blog posts, pictures or other items. We want to create the text that should be displayed next to such an item.

Implement a function likes :: [String] -> String, which must take in input array, containing the names of people who like an item. It must return the display text as shown in the examples:

Kata.Likes(new string[0]) => "no one likes this"
Kata.Likes(new string[] {"Peter"}) => "Peter likes this"
Kata.Likes(new string[] {"Jacob", "Alex"}) => "Jacob and Alex like this"
Kata.Likes(new string[] {"Max", "John", "Mark"}) => "Max, John and Mark like this"
Kata.Likes(new string[] {"Alex", "Jacob", "Mark", "Max"}) => "Alex, Jacob and 2 others like this"
For more than 4 names, the number in and 2 others simply increases.
