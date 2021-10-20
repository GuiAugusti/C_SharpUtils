using System;
using System.Collections;
using System.Collections.Generic;

namespace HashTables
{
    /*
 * The Hashtable is a non - generic collection that stores 
 * key-value pairs, similar to generic Dictionary<TKey, TValue> collection.
 * It optimizes lookups by computing the hash code of each key and stores it in a different bucket internally and 
 * then matches the hash code of the specified key at the time of accessing values.
 */

 /*Hashtable stores key-value pairs.
 * Comes under System.Collection namespace.
 * Implements IDictionary interface.
 * Keys must be unique and cannot be null.
 * Values can be null or duplicate.
 * Values can be accessed by passing associated key in the indexer e.g.myHashtable[key]
 *  Elements are stored as DictionaryEntry objects.
 */

    class Program
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable(); // Creating a new HashTable

            h.Add(1,2);
            h.Add(2, 3);
          //h.Add(1,4);   Duplicated KEY  == ERROR
            h.Add("aa",3);
            h.Add(1.4f,"cool");

            var cities = new Hashtable() {  // Creating a hashset using the default constructor
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            string citiesOfUK = (string)cities["UK"]; // Adding elements
            string citiesOfUSA = (string)cities["USA"];


            foreach (DictionaryEntry kvp in h) // Printing the Key / Value
            {
                Console.WriteLine(kvp.Key + "|" + kvp.Value);
            }

            Console.WriteLine(cities["UK"]); // Printing the corresponding KEY value

            cities["UK"] = "Liverpool, Bristol"; // Updating values
            cities.Remove("UK"); // Removing elements
            cities.Clear();

            Dictionary<int, string> dict = new Dictionary<int, string>();
            Hashtable ht = new Hashtable(dict); // Passing all the elements of a dict to a new Hashset




        }
    }
}
