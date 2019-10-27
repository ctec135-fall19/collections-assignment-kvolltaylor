/*

Author: Katrina Voll-Taylor
Date: 28 October 2019
CTEC 135: Microsoft Software Development with C#
Module 5, Programming Assignment 4, Problem 3

    Prob 3: Dictionaries
        
        * Put all your code in main. 
        * Dictionary use
            - declare a dictionary and initialization it to create 3 entries: 
              (1, "one"), (2, "two"), and (3, "three"). Use a combination of initialization syntax, Add() and [] in your initialization code.
            - add an additional entry: (99, "ninety-nine")
            - show use of enumerator to see all entries. Print both the key and value
            - reassign the value of 99 to "99" using indexing notation
            - print the new value using indexing notation
            - remove the 2 item and enumerate over the whole dictionary to show
              it's gone

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input: creation of dictionary with 4 items
            // Process: traverse dictionary items
            //          change dictionary item value
            //          remove dictionary entry
            // Output: print key/value pairs of dictionary items
            //         print value of changed item
            //         print key/value pairs of dictionary items after
            //              removing an item

            // declare dictionary
            Dictionary<int, string> numberDictionary = new Dictionary<int, string>();

            // intialize entries in dictionary
            numberDictionary.Add(1, "one");
            numberDictionary[2] = "two";
            numberDictionary.Add(3, "three");

            // add additional item to dictionary
            numberDictionary.Add(99, "ninety-nine");

            // traversal: print out each key and value of dictionary
            // using KeyValuePair structure
            Console.WriteLine("Key Value pairs of all entries:");
            Console.WriteLine(new string('-', 35) + "\n");
            foreach (KeyValuePair<int,string> kvp in numberDictionary)
            {
                Console.WriteLine("Key: {0}\t Value: {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine(new string('_', 75) + "\n");

            // reassign the value of 99 to "99" using indexing notation
            numberDictionary[99] = "99";

            // print the new value
            Console.WriteLine("New value of 99:");
            Console.WriteLine(new string('-', 20) + "\n");
            // print key information
            foreach (KeyValuePair<int, string> kvp in numberDictionary)
            {
                if (kvp.Key == 99)
                {
                    Console.Write("Key: {0}\t ", kvp.Key);
                }
            }
            // print new value of numberDictionary[99] using indexing notation
            Console.WriteLine("Value: " + numberDictionary[99] + "\n");
            Console.WriteLine(new string('_', 75) + "\n");

            // remove item with 2 key
            numberDictionary.Remove(2);

            // traversal: print out each key and value of dictionary after removing 2
            // using KeyValuePair structure
            Console.WriteLine("Key Value pairs of all entries after removing item 2:");
            Console.WriteLine(new string('-', 55) + "\n");
            foreach (KeyValuePair<int, string> kvp in numberDictionary)
            {
                Console.WriteLine("Key: {0}\t Value: {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine(new string('_', 75) + "\n");

        }
    }
}
