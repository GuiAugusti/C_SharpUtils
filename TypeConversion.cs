using System;
using System.Collections;

namespace TypeConversion
{
    class Program
    {
        // Implicit type conversion − These conversions are performed by C# in a type-safe manner. 
        // For example, conversions from smaller to larger integral types and conversions from derived classes to base classes.

        // Explicit type conversion − These conversions are done explicitly by users using the pre-defined functions.
        // Explicit conversions require a cast operator.

        static void Main(string[] args)
        {
            // ------ Implicit Type Conversion: ------

            int i = 100;
            double d = i; // INT to Double
            Console.WriteLine(d.GetType() + " " + d);

            float f = 200;
            double d2 = f; // float to double
            Console.WriteLine(d2.GetType() + " " + d2);

            // ------ Explicit Type Conversion: ------

            double d3 = 3.4d;
            int i2 = (int)d3;     // double to INT
            Console.WriteLine(i2.GetType() + " " + i2);



            // ------ Others ------

            string s = "Hello Word!";
            char[] sChar = s.ToCharArray();  // String to CharArray to String again!
            sChar[sChar.Length -1] = '?';
            s = new string(sChar);
            Console.WriteLine(s);

            int i3 = 10;
            string i4 = i3.ToString(); // INT to String
            Console.WriteLine(i4 + 5);

            float f1 = 14.00f;
            string f2 = f1.ToString(); // Float to String (Same as above)
            Console.WriteLine(f2 + 5);


            // ------ Parse ------

            string zz = "100";
            int z = int.Parse(zz); // String to INT
            Console.WriteLine(z + 55);

            float ff = float.Parse(zz); // String to Float
            Console.WriteLine(z + 55.55);

            double dd = double.Parse(zz); // String to Double
            Console.WriteLine(dd + 55.55);

            // ------ Convert Class ------

            int u = 20;
            double uu = Convert.ToDouble(u); // INT to Double

            int x = 0;
            int xx = 1;
            Boolean b = Convert.ToBoolean(x); // INT to Boolean
            Boolean bb = Convert.ToBoolean(xx);
        }
    }
}
