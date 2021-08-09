using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHelloWord.HelloWord();
            Sentences.SaySentence(1);
            Console.WriteLine(Products.CoolCandy.price);

        }
    }
    
    class SayHelloWord
    {
        static string myString = "===========\nHello_Word\n===========";

        static public string HelloWord()
        {
            Console.WriteLine(myString);
            return myString;
        }
    }

    class Sentences
    {
        static string[] sentences = {"Hi, how are you?","Good Morning!","Are you hungry?","Sup!"};

        public static void SaySentence(int userInput)
        {
            switch (userInput)
            {
                case 1:
                    Console.WriteLine(sentences[0]);
                    break;

                case 2:
                    Console.WriteLine(sentences[1]);
                    break;
            }
        }
    }

    class Products
    {   
        // Attributes
        public string product, ID;
        public float price;

        // Constructor
        Products(string ID, float price)
        {
            ID = this.ID;
            price = this.price;
        }

        public static Products CoolCandy = new Products("1A", 0.5f);
        
    }
}
