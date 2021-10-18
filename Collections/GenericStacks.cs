using System;
using System.Collections.Generic;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(0);
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            myStack.Push(6);

            foreach (var i in myStack)
            {
                Console.WriteLine($"| {i} |");
            }

            myStack.Pop(); // Returns and removes the peek of the stack!
            Console.WriteLine($"\nPeak of the stack: {myStack.Peek()}"); // Peek = Top of the stack!
            Console.WriteLine(myStack.Count); // Return the stack lenght!
            Console.WriteLine(myStack.Contains(1)); // Checks if a specific element is inside the Stack! 
            myStack.Clear(); // Remove all the elements of a stack!

            int[] myArray = new int[] { 1, 2, 3, 4 };
            Stack<int> myStack2 = new Stack<int>(myArray); // Array to Stack!
            foreach (int i in myStack2)
            {
                Console.WriteLine(i);
            }


        }
    }

}
