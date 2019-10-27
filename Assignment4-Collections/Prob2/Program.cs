/*

Author: Katrina Voll-Taylor
Date: 28 October 2019
CTEC 135: Microsoft Software Development with C#
Module 5, Programming Assignment 4, Problem 2

    Prob 2: Stacks and Queues
        Put all your code in main.
        
        Regions
            * Stack
                - declare and initialize a stack with the numbers 1 - 5 using 
                  initialization syntax.
                - demonstrate use of the enumerator to print out the members in 
                  the stack, i.e. write a foreach loop
                - print a peek at the top member in the stack
                - write a loop that pops the elements off of the stack and prints each
            * Queue
                - declare a queue
                - initialize the queue with the numbers 1-5 using a for loop.
                - demonstrate use of the enumerator to print out the members in the 
                  queue, i.e. write a foreach loop
                - print a peek at the top member in the stack
                - write a loop that dequeues the elements from the stack and prints 
                  each

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Stack
            // Input: create a stack of 5 ints
            // Process: push members onto stack;
            //          look at top member in stack;
            //          pop elements off stack;
            // Output: print intital member values, top member, and popped off elements

            Console.WriteLine("Region 1: Stack");
            Console.WriteLine(new string('-', 50) + "\n");

            // declare stack
            Stack<int> intStack = new Stack<int>();

            // intialize stack
            // if, as in this case, you know the size of stack you
            // want to begin with, can also be done using:
            // for (int i = 0; i < 5; i++) { intStack.Push(i + 1);}
            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);
            intStack.Push(4);
            intStack.Push(5);

            // traversal: print out value of each member in stack
            Console.WriteLine("Value of each member in stack using enumerator:");
            foreach (int i in intStack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // peek at top member in the stack
            Console.WriteLine("Peek at value of top member in stack:");
            Console.WriteLine(intStack.Peek() + "\n");

            // pop off each element and print it
            // create a variable to contain size of original stack
            int intStackSize = intStack.Count;
            Console.WriteLine("Pop each element off stack:");
            for (int i = 0; i < intStackSize; i++)
            {
                //call the name property to print out as you pop elements off
                Console.WriteLine(intStack.Pop());
            }
            Console.WriteLine();
            #endregion

            Console.WriteLine(new string('_', 50) + "\n\n");

            #region Queue
            // Input: create a queue of 5 ints
            // Process: enqueue members into queue;
            //          look at top member in queue;
            //          dequeue elements off queue;
            // Output: print intital member values, top member, and dequeued elements

            Console.WriteLine("Region 2: Queue");
            Console.WriteLine(new string('-', 50) + "\n");

            // declare queue
            Queue<int> intQueue = new Queue<int>(new int[5]);

            // initialize queue
            for (int i = 0; i < intQueue.Count; i++)
            {
                // remove default 0 null value from queue generated in
                // the declaration when the queue's capacity was specified
                intQueue.Dequeue();
                // add number value to queue
                intQueue.Enqueue(i + 1);

            }

            // traversal: print out value of each member in queue
            Console.WriteLine("Value of each member in queue using enumerator:");
            foreach (int i in intQueue)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // peek at top member in the queue
            Console.WriteLine("Peek at value of top member in queue:");
            Console.WriteLine(intQueue.Peek() + "\n");

            // dequeue each element and print it
            // create a variable to contain size of original queue
            int intQueueSize = intQueue.Count;
            Console.WriteLine("Dequeue each element off stack:");
            for (int i = 0; i < intQueueSize; i++)
            {
                //call the name property to print out as you pop elements off
                Console.WriteLine(intQueue.Dequeue());
            }
            Console.WriteLine();

            #endregion

        }
    }
}
