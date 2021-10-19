using System;
using System.Collections.Generic;

namespace SortedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> myStdL = new SortedList<int, string>();

            myStdL.Add(1, "Hello1");
            myStdL.Add(3, "Hello2"); // Adding elements to our SortedList
            myStdL.Add(2, "Hello3"); // SortedLists can't have duplicated keys, but they can have duplicated values!
            myStdL.Add(5, "Hello4");
            myStdL.Add(4, null);
            myStdL.Add(6, "Hello1");

            foreach (KeyValuePair<int, string> kvp in myStdL) // Foreach loop
            {
                Console.WriteLine($"Key = {kvp.Key} | Value = {kvp.Value}");
            }

            Console.WriteLine(myStdL[1]); // Accessing SortedList ([1] is the KEY, not index!)
            Console.WriteLine(myStdL[3]); // Accessing SortedList ([3] is the KEY, not index!)

            myStdL[2] = "TWO"; //updates value
            myStdL[10] = "Four"; //adds a new key-value if a key does not exists

            if (!myStdL.ContainsKey(200)) // Checks is if a specific key exists in the SortedList!
            {
                myStdL[200] = "Hello200";
            }

            string result;
            if (myStdL.TryGetValue(200, out result))  // Checks is if a specific key exists in the SortedList!
            {
                Console.WriteLine("Key: {0}, Value: {1}", 200, result);
            }

            for (int i = 0; i < myStdL.Count; i++) // For Loop
            {
                Console.WriteLine("key: {0}, value: {1}", myStdL.Keys[i], myStdL.Values[i]);
            }

            myStdL.Remove(1); // Removes key 1 pair!
            myStdL.Remove(69); //removes key 69 pair, no error if not exists!
            myStdL.RemoveAt(0); // Removes the element of INDEX 0 (Assorted Index)


            //Creating a SortedList of string keys, string values 
            //using collection-initializer syntax
            SortedList<string, string> cities = new SortedList<string, string>() {
                {"London", "UK"},
                {"New York", "USA"},
                { "Mumbai", "India"},
                {"Johannesburg", "South Africa"}
            };

        }


    }

}
