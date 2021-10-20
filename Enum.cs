using System;
using System.Collections;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Time timeNow = Time.Noon;
            Console.WriteLine(timeNow);
            
            int myNum = (int)Time.Morning;
            Console.WriteLine(myNum);

            switch (timeNow)
            {
                case Time.Afternoon:
                    Console.WriteLine("AFTERNOON!!!");
                    break;
                
                case Time.Noon:
                    Console.WriteLine("NOOOON!!");
                    break;
            }
        }
    }

    enum Time
    {
        Midnight, // 0
        Noon,      // 1
        Morning,  // 2
        Afternoon, //3
        Evening,   // 4
        Night       // 5
    }




}
