﻿<a href=https://github.com/hlais/Kata---a---Day><b>Back to README</b><a>

Day #25: 

* <b>Difficulty:</b> 7 kyu
* <b>Solution Class:</b> [Finding the middle of a string](Get%20the%20Middle%20Character.cs)
* <b>Solved:</b>  Saturday, February 3<sup>rd</sup>, 2018

<b>Description:</b>

You are going to be given a word. Your job is to return the middle character of the word. If the word's length is odd, return the middle character. If the word's length is even, return the middle 2 characters.

#Examples:

runBF("test\0") should return "es"

runBF("testing\0") should return "t"

runBF("middle\0") should return "dd"

runBF("A\0") should return "A"
#Input

A word (string) of length 0 < str < 200 For BF, all the input strings end with "\0". You do not need to test for this. This is only here to tell you that you do not need to worry about your solution timing out.

#Output

The middle character(s) of the word represented as a string.
