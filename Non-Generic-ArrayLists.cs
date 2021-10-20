using System;
using System.Collections;

namespace ArrayLists
{
    //An ArrayList can be used to add unknown data where you don't know the types and the size of the data.
    // ArrayList class implements the IList

    class Program
    {
        static void Main(string[] args)
        {
            var a = new ArrayList();
            
            a.Add(1);
            a.Add("Bill");
            a.Add(" ");
            a.Add(true);
            a.Add(4.5f);
            a.Add(null);

            var arlist2 = new ArrayList() // Initializer
            {
                2, "Steve", " ", true, 4.5, null
            };

            // Use the AddRange(ICollection c) method to add an entire Array, HashTable, SortedList, ArrayList, BitArray, Queue, and Stack in the ArrayList.
            int[] arr = new int[] {1,2,3,4,5};
            a.AddRange(arr);

            // READING
            Console.WriteLine(a[0]);
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
            int XX = (int) a[0];
            string YY = (string)a[2];

            // UPDATING
            a[0] = "Steve";
            a[1] = 22;

            // INSERTING
            a.Insert(0, 2222); // Index,value
            a.InsertRange(0,arr);

            // Removing

            a.Remove(null); // Removes first occurance of null
            a.RemoveAt(0); //Removes element at index 4
            a.RemoveRange(0, 5); // Removes all elements starting from the 1st item

            // Contains

            a.Contains(1); // true
            a.Contains(2); // true
        }
    }
}
