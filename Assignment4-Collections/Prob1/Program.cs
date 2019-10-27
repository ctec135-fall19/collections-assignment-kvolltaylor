/*

Author: Katrina Voll-Taylor
Date: 28 October 2019
CTEC 135: Microsoft Software Development with C#
Module 5, Programming Assignment 4, Problem 1

    Prob 1 - Arrays and Lists: 
        Put all your code in main. 

        Regions
            * Simple array:
                - create an array of int of size 5
                - use a for loop to initialize it to the numbers 11 - 15
                - use a foreach loop to print out the values in the array
            * List<T>
                - create a list of int
                - use a for loop to initialize the list to the numbers 21 - 25
                - use a foreach loop to print out the values in the list
                - update the values in the list to 31 - 35 using indexing
                - repeat the print using a for loop and indexing

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Simple array
            Console.WriteLine("Region 1: Simple array");
            Console.WriteLine(new string('-', 25) + "\n");

            // declare array
            int[] simpleArray = new int[5];

            // initialize array
            for (int i = 0; i < simpleArray.Length; i++)
            {
                simpleArray[i] = i + 11;

            }

            // print out value of each element in array
            foreach (int element in simpleArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            #endregion

            Console.WriteLine(new string('_', 25) + "\n\n");

            #region List<T>
            Console.WriteLine("Region 2: List<T>");
            Console.WriteLine(new string('-', 25) + "\n");

            // declare list of ints
            // list is declared containing 5 elements
            List<int> intList = new List<int>(new int[5]);

            // initialize list
            for (int i = 0; i < intList.Count; i++)
            {
                intList[i] = i + 21;

            }

            // print out value of each element in array
            Console.WriteLine("Initial values of elements in list:");
            foreach (int element in intList)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            // update values using indexing
            // could also be done line by line using:
            // intList[0] = 31; intList[1] = 32; etc...
            for (int i = 0; i < intList.Count; i++)
            {
                intList[i] = i + 31;

            }

            // print out updated value of each element in array
            Console.WriteLine("Updated values of elements in list:");
            foreach (int element in intList)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            #endregion

        }
    }
}
