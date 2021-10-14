using System;
using System.Linq;

namespace ArraysAndMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("-------------Arrays!-------------\n");
            
            string[] cars = new string[4];
            string[] cars2 = new string[5] { "car1", "car2", "car3", "car4", "car5" };

            int[] coolNumbers = new int[] { 1, 2, 3, 4 };
            int[] coolNumbers2 = { 1, 2, 3, 4, 5 };

            char[] coolChars;
            char[] coolChars2 = { 'A', 'B', 'C', 'D', 'E' };

            Console.WriteLine(cars2.Length);
            cars2[0] = "car100000000000000000000";

            Array.Sort(cars2);

            foreach (string c in cars2)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine(coolNumbers2.Max());  // returns the largest value
            Console.WriteLine(coolNumbers2.Min());  // returns the smallest value
            Console.WriteLine(coolNumbers2.Sum());  // returns the sum of elements

            Console.WriteLine("\n-------------Matrices-------------\n");

            int[,] coolNumbers3 = new int[3,2]; //New Matrice
            
            
            coolNumbers3[0, 0] = 777; //Line 1 - Column 1
            coolNumbers3[0, 1] = 778; //Line 1 - Column 2

            coolNumbers3[1, 0] = 779; //Line 2 - Column 1
            coolNumbers3[1, 1] = 780; //Line 2 - Column 2

            coolNumbers3[2, 0] = 781; //Line 3 - Column 1
            coolNumbers3[2, 1] = 782; //Line 3 - Column 2

            string text = "";
            for (int line = 0; line < 3; line++)
            {
                for (int column = 0; column < 2; column++)
                {
                    text += coolNumbers3[line, column] + "|";
                }
                Console.WriteLine(text);
                text = "";
            }



        }
    }
}
