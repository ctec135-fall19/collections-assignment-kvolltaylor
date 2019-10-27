/*

Author: Katrina Voll-Taylor
Date: 28 October 2019
CTEC 135: Microsoft Software Development with C#
Module 5, Programming Assignment 4, Problem 4

    Prob 4: Linked Lists
        * Put all your code in main.
        * LinkedList use
            - Demonstrate use of constructor taking an IEnumerable object. 
              Create a string array having the first 5-10 words of your favorite 
              nursery rhyme. Use it as the argument when constructing the LinkedList 
              object.
            - Print out the rhyme on a single line.
            - The traditional way to walk a linked list is to start at the head, 
              process the node, then set the node variable to the next node in the list.
              Create a node variable and walk the list to print out the values. 
              The line printed should be the same as the one above.
            - Remove a word from the middle of the list. Print the list on a single line
              to demonstrate this
            - Add the word back in and print the list again to demonstrate.

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class Program
    {
        static void Main(string[] args)
        {

            // Input: a string array of words to a Nursery Rhyme line
            // Process: turn array into a linked list
            //          remove word from middle
            //          add word back to middle
            // Output: print results of each step in process


            // create string array 
            string[] motherHubbard = {"Old", "Mother", "Hubbard", "went", "to", "her",
                "cupboard"};

            // create the link list
            LinkedList<string> oldMotherHubbard = new LinkedList<string>(motherHubbard);

            #region print contents of original linked list
            Console.WriteLine("LinkedList: First verse of Old Mother Hubbard");
            Console.WriteLine(new string('-', 50) + "\n");

            // make sure node is pointed at first node in the list
            LinkedListNode<string> node = oldMotherHubbard.First;

            // use while loop to traverse through the list from node to node
            while (node != null)
            {
                Console.Write("{0} ", node.Value);
                // walk through the nodes using while loop going Next, Next, Next
                node = node.Next;
            }
            Console.WriteLine("\n\n");
            #endregion

            Console.WriteLine(new string('_', 75) + "\n");

            #region remove one word from the middle of linked list and print again
            // remove word from middle of linked list
            oldMotherHubbard.Remove("Hubbard");

            Console.WriteLine("LinkedList: Hubbard removed from Old Mother Hubbard");
            Console.WriteLine(new string('-', 50) + "\n");

            // make sure node is pointed at first node in the list
            LinkedListNode<string> node2 = oldMotherHubbard.First;

            // use while loop to traverse through the list from node to node
            while (node2 != null)
            {
                Console.Write("{0} ", node2.Value);
                // walk through the nodes using while loop going Next, Next, Next
                node2 = node2.Next;
            }
            Console.WriteLine("\n\n");
            #endregion

            Console.WriteLine(new string('_', 75) + "\n");

            #region add word back into linked list and print again
            // find the node containing Mother then add Hubbard after it
            oldMotherHubbard.AddAfter(oldMotherHubbard.Find("Mother"), "Hubbard");

            Console.WriteLine("LinkedList: Hubbard added back to Old Mother Hubbard");
            Console.WriteLine(new string('-', 50) + "\n");

            // make sure node is pointed at first node in the list
            LinkedListNode<string> node3 = oldMotherHubbard.First;

            // use while loop to traverse through the list from node to node
            while (node3 != null)
            {
                Console.Write("{0} ", node3.Value);
                // walk through the nodes using while loop going Next, Next, Next
                node3 = node3.Next;
            }
            Console.WriteLine("\n\n");

            #endregion

        }
    }
}
