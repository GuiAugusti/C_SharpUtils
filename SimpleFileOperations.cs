using System;
using System.IO;
using System.Threading;

namespace FilesAreEpic
{
    class Program
    {
        static void Main(string[] args)
        {

            if (File.Exists("sav.dat")) // Checks if a specific file exists!
            {
                Console.WriteLine("sav.dat Found!\n\n");
            }
            else
            {
                Console.WriteLine("sav.dat not found, creating file...");
                File.Create("sav.dat"); // Creates a file!
                Console.WriteLine("sav.dat successfully created!\n\n");
            }


            while (true)
            {
                Console.WriteLine("1 - Append text to sav.dat\n2 - Read sav.dat\n3 - Clear sav.dat\n4 - Cryptography\n\n");
                switch (Console.ReadLine())
                {
                    case "1":
                        AppendToFile();
                        break;

                    case "2":
                        ReadFile();
                        break;

                    case "3":
                        ClearFile();
                        break;

                    case "4":
                        Security();
                        break;
                }
            }

            static void AppendToFile()
            {
                Console.Clear();
                Console.WriteLine("\nYour text:");
                File.AppendAllText("sav.dat", Console.ReadLine()); // Write content to a specified file!
                Console.WriteLine("\nDone! Try reading your file!");
                Console.ReadLine();
                Console.Clear();
            }

            static void ReadFile()
            {
                Console.Clear();
                Console.WriteLine("sav.dat contents:");
                Console.WriteLine("||" + File.ReadAllText("sav.dat") + "||"); // Read all the contents of a file
                Console.ReadLine();
                Console.Clear();
            }

            static void ClearFile()
            {
                File.WriteAllText("sav.dat", ""); // Creates a file with content, or replaces a file with the same name
                Console.Clear();
                Console.WriteLine("Succesffully deleted all contents in sav.dat");
                Console.ReadLine();
                Console.Clear();
            }

            static void Security()
            {
                Console.Clear();
                Console.WriteLine("1 - Encrypt file\n2 - Decrypt file\n\n");
                switch (Console.ReadLine())
                {
                    case "1":
                        File.Encrypt("sav.dat");
                        Console.WriteLine("File Encrypted!");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "2":
                        File.Decrypt("sav.dat");
                        Console.WriteLine("File Decrypted");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }
    }  
}
