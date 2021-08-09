using System;
namespace Delegates

{
    class Program
    {
        public delegate void MathLib(float x, float y);
        static MathLib mathLib;

        static void Main(string[] args)
        {
            SetMethods();
            mathLib(10f, 10f);
        }

        static void SetMethods()
        {
            mathLib += Add;
            mathLib += Sub;
            mathLib += Mult;
        }

        static void Add(float x, float y)
        {
            Console.WriteLine(x + y);
        }

        static void Sub(float x, float y)
        {
            Console.WriteLine(x - y);
        }

        static void Mult(float x, float y)
        {
            Console.WriteLine(x * y);
        }


    }
}
