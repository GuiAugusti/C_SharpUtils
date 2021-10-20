using System;
using System.Collections;

namespace BitArrays
{
    // BitArray manages a compact array of bit values, which are represented as Booleans,
    // where true indicates that the bit is on (1) and false indicates the bit is off (0).

    class Program
    {
        static void Main(string[] args)
        {
            //creating two  bit arrays of size 5
            BitArray arr1 = new BitArray(5);
            BitArray arr2 = new BitArray(5);

            // By default, non defined elements are FALSE!
            arr1[0] = true;
            arr1[1] = false;
            arr1[2] = true;
            arr1[3] = false;
            arr1[4] = true;
         // arr1[5] = false; returns a error, since index 5 is out of range!

            foreach (bool b in arr1)
            {
                Console.WriteLine(b);
            }

            arr1.Set(1, true); // Sets the value of a element
            arr1.Get(1); // Gets the value of a element
        }

    }
}
