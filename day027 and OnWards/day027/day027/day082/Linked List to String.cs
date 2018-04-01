using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWards7Kata
{
    class Linked_List_to_String
    {
        public static string Stringify(Node list)
        {
           
               return list == null ? "null" : $"{list.Data} -> { Stringify(list.Next)}";
            
        }
    }
    public class Node
    {
        public int Data { get; private set; }
        public Node Next { get; private set; }

        public Node(int data, Node next = null)
        {
            Data = data;
            Next = next;
        }
    }

}

