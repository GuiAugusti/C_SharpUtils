using System;
using System.Threading;

namespace Rainbow
{
    class Program 
    {
        static readonly string[] rainbow = new string[7] {
            " ######  \n #    #  \n # ##   \n #   #   \n #    # ^_^ \n\n",            // R
            " ######  \n #    #  \n ######  \n #    #  \n #    # ^0^ \n\n",       // A
            " ######  \n   ##    \n   ##    \n   ##    \n ###### O.O \n\n",        // I
            " #    #  \n ##   #  \n # #  #  \n #  # #  \n #   ## (U.U ) \n\n",          // N
            " ######  \n #     #  \n #####   \n #     #  \n ###### ;)  \n\n",    // B
            " ######  \n #    #  \n #    #  \n #    #  \n ###### ^-^ \n\n",       // O
            " #    #  \n #    #  \n # ## #  \n ##  ##  \n #    # l_l \n\n"                // W
        };
        static readonly string rainbow2 = "■■■■■■■■■■■■■■■■■\n*RAINBOOOOOOOOW* \n■■■■■■■■■■■■■■■■■\n";


        static readonly ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.DarkYellow, ConsoleColor.Yellow, ConsoleColor.Green, 
            ConsoleColor.Blue, ConsoleColor.DarkMagenta, ConsoleColor.Magenta };
        
        static void Main(string[] args)
        {
            int colorNow = 0;
            
            while (true)
            {
                for (int i = 0; i != rainbow2.Length; i++)
                {
                    Console.ForegroundColor = colors[colorNow];
                    Console.Write(rainbow2[i]);
                    Thread.Sleep(20);
                    if (colorNow != 6)
                    {
                        colorNow++;
                    }
                    else
                    {
                        colorNow = 0;
                    }
                    
                }
                Console.WriteLine("\n");
            }
        }
    }
}
