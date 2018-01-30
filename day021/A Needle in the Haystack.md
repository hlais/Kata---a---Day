<a href=https://github.com/hlais/Kata---a---Day><b>Back to README</b><a>

Day #21: 

Difficulty: 8 kyu

Solved: Tuesday , January 30th, 2018

Description:
Can you find the needle in the haystack?

Write a function findNeedle() that takes an array full of junk but containing one "needle"

After your function finds the needle it should return a message (as a string) that says:

"found the needle at position " plus the index it found the needle

So

find_needle(['hay', 'junk', 'hay', 'hay', 'moreJunk', 'needle', 'randomJunk'])
find_needle(['hay', 'junk', 'hay', 'hay', 'moreJunk', 'needle', 'randomJunk'])
findNeedle(['hay', 'junk', 'hay', 'hay', 'moreJunk', 'needle', 'randomJunk'])
findNeedle(new Object[] {"hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk"})
find_needle(["hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk"])
should return

'found the needle at position 5'
'found the needle at position 5'
'found the needle at position 5'
"found the needle at position 5"
"found the needle at position 5"
