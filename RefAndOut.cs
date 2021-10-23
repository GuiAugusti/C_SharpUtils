using System;

namespace RefAndOut
{
    class Program
    {
        /*The passing of value through ref parameter is useful when 
         * the called method also need to change the value of passed parameter.*/

        /*The declaring of parameter through out parameter 
         * is useful when a method return multiple values.*/


        static void Main(string[] args)
        {
            int i = 0; // It is necessary to initialize the parameters before passing then!

            Plus100(i); // Without REF
            Console.WriteLine(i); // The value of "I" stays the same!

            RefPlus100(ref i); // With REF
            Console.WriteLine(i); // The value of "I" is now 100!




            int x; // It is not necessary to initialize the parameters

            Plus1000(out x);
            Console.WriteLine(x); // The value of X is now 1000!
        }

        static void Plus100(int value)
        {
            value += 100;
        }
        static void RefPlus100(ref int value)
        {
            // no need to initialize the parameters here
            value += 100;
        }

        static void Plus1000(out int value2)
        {
            value2 = 0; // Need to initialize the parameters before using them!
            value2 += 1000;
        }
    }  
}
