using System;
using System.Collections.Generic;

namespace QueuesAreEpic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3 };

            Queue<int> myQueue = new Queue<int>(); // New Queue!
            myQueue.Enqueue(1); 
            myQueue.Enqueue(2); // Adding elements to a Queue!
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            
 
            foreach (int i in myQueue)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"Total elements: {myQueue.Count}\n"); // Returns the number os elements contained in the Queue!
          

            Console.WriteLine("The Peek is: "  + myQueue.Peek()); // returns the first item from a queue collection without removing it


            while (myQueue.Count > 0)
            {
                Console.WriteLine(myQueue.Dequeue()); // Returns an item from the beginning of the queue and removes it from the queue.
            }
            Console.WriteLine($"Total of elements:{myQueue.Count}\n");

            myQueue.Contains(2); //true
            myQueue.Contains(10); //false

            myQueue.Clear();

        }


    }

}
