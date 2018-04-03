﻿<a href=https://github.com/hlais/Kata---a---Day><b>Back to README</b><a>

Day #82: 

* <b>Difficulty:</b>7 kyu
* <b>Solution Class:</b> [Linked List to String](Linked%20List%20to%20String.cs)
* <b>Solved:</b> Sunday, April 1<sup>st</sup>, 2018

Convert a linked list to a string
Related Kata
Although this Kata is not part of an official Series, you may also want to try out Parse a linked list from a string if you enjoyed this Kata.

Preloaded
Preloaded for you is a class/struct Node (depending on the language) used to construct linked lists in this Kata:

public class Node {
  public int Data { get; private set; }
  public Node Next { get; private set; }

  public Node(int data, Node next = null) {
    Data = data;
    Next = next;
  }
}
Prerequisites
This Kata assumes that you are already familiar with the idea of a linked list. If you do not know what that is, you may want to read up on this article on Wikipedia. Specifically, the linked lists this Kata is referring to are singly linked lists, where the value of a specific node is stored in its data/$data/Data property, the reference to the next node is stored in its next/$next/Next/next_node property and the terminator for a list is null/NULL/None/nil/nullptr.

Additionally, this Kata assumes that you have basic knowledge of Object-Oriented Programming (or a similar concept) in the programming language you are undertaking. If you have not come across Object-Oriented Programming in your selected language, you may want to try out an online course or read up on some code examples of OOP in your selected language up to (but not necessarily including) Classical Inheritance.

Specifically, if you are attempting this Kata in PHP and haven't come across OOP, you may want to try out the first 4 Kata in this Series.

Task
Create a function stringify which accepts an argument list/$list and returns a string representation of the list. The string representation of the list starts with the value of the current Node, specified by its data/$data/Data property, followed by a whitespace character, an arrow and another whitespace character (" -> "), followed by the rest of the list. The end of the string representation of a list must always end with null/NULL/None/nil/nullptr (all caps or all lowercase depending on the language you are undertaking this Kata in). For example, given the following list:

new Node(1, new Node(2, new Node(3)))
... its string representation would be:

"1 -> 2 -> 3 -> null"
And given the following linked list:

new Node(0, new Node(1, new Node(4, new Node(9, new Node(16)))))
... its string representation would be:

"0 -> 1 -> 4 -> 9 -> 16 -> null"
Note that null/NULL/None/nil/nullptr itself is also considered a valid linked list. In that case, its string representation would simply be "null"/"NULL"/"None"/"nil"/"nullptr"/@"NULL" (again, depending on the language).

For the simplicity of this Kata, you may assume that any Node in this Kata may only contain non-negative integer values. For example, you will not encounter a Node whose data/$data/Data property is "Hello World".
