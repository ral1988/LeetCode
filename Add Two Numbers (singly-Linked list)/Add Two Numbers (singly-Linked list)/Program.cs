//You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.
//
//You may assume the two numbers do not contain any leading zero, except the number 0 itself.
//
//Example:
//
//Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
//Output: 7 -> 0 -> 8
//Explanation: 342 + 465 = 807.

using System;

namespace Add_Two_Numbers__singly_Linked_list_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    internal class Node
    {
        internal int data;
        internal Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    internal class DNode 
    {  
        internal int data;  
        internal DNode prev;  
        internal DNode next;  
        public DNode(int d) {  
            data = d;  
            prev = null;  
            next = null;  
        }  
    }  

    internal class SingleLinkedList
    {
        internal Node head;
    }

    
    internal class DoubleLinkedList 
    {  
        internal DNode head;  
    }  

    internal void InsertFront (SingleLinkedList, singlyList, int data)
    {
        Node new_node = new Node(new_data);
        new_node.next = singlyList.head;
        singlyList.head = new_node;
    }

    internal void InsertFront(DoubleLinkedList doubleLinkedList, int data) {  
    DNode newNode = new DNode(data);  
    newNode.next = doubleLinkedList.head;  
    newNode.prev = null;  
    if (doubleLinkedList.head != null) {  
        doubleLinkedList.head.prev = newNode;  
    }  
    doubleLinkedList.head = newNode;  
    }  
}



