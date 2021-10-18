using System;
using System.Collections;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push(0);
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4.5f);
            myStack.Push(5);
            myStack.Push(6);

            foreach (var i in myStack)
            {
                Console.WriteLine($"| {i} |");
            }

            myStack.Pop(); // Returns and removes the peek of the stack!
            Console.WriteLine($"\nPeak of the stack: {myStack.Peek()}"); // Peek = Top of the stack!
            Console.WriteLine(myStack.Count); // Returns the stack lenght!
            Console.WriteLine(myStack.Contains(1)); // Checks if a specific element is inside the Stack! 
            myStack.Clear(); // Remove all the elements of a stack!
        }
    }

}
