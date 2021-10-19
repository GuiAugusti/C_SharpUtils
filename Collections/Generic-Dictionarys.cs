using System;
using System.Collections.Generic;

namespace Dictionarys
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> d = new Dictionary<int,string>();
            
            d.Add(1, "Hello1"); // adding a key/ value using the Add() method
            d.Add(2, "Hello2"); // adding a key/ value using the Add() method

            foreach (KeyValuePair<int, string> kvp in d)
            {
                Console.WriteLine($"Key: {kvp.Key} | Value: {kvp.Value}");
            }

            Console.WriteLine(d[2]);
            Console.WriteLine(d[1]);

            if (d.ContainsKey(1))
            {
                Console.WriteLine(d[1]);
            }

            string result;
            if (d.TryGetValue(1, out result))
            {
                Console.WriteLine(result);
            }

            d[1] = "Good Bye"; // update value of key 1

            if (!d.ContainsKey(4))
            {
                d[4] = "Good Night";
            }

            if (d.ContainsKey(4))
            {
                d.Remove(4);
            }

            d.Clear();

        }


    }
    
}
