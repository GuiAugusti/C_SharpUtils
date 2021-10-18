using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------------------------------------------------------------------------

            List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(2); // ADDs elements to a List!
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);

            List<string> myList2 = new List<string>();
            myList2.Add(null); // nulls are allowed for reference type list
            myList2.Add("Hello Word!");

            // -------------------------------------------------------------------------------------------------

            //adding elements using collection-initializer syntax
            var bigCities = new List<string>()
            {
                 "New York",
                 "London",
                 "Mumbai",
                 "Chicago"
            };

            // -------------------------------------------------------------------------------------------------

            // add elements of custom classes using the collection-initializer
            var students = new List<Student>() 
            {
                new Student(){ Id = 1, Name="Bill"},
                new Student(){ Id = 2, Name="Steve"},
                new Student(){ Id = 3, Name="Ram"},
                new Student(){ Id = 4, Name="Abdul"}
            };

            // -------------------------------------------------------------------------------------------------
            string[] cities = new string[3] { "Mumbai", "London", "New York" };

            var popularCities = new List<string>();

            // adding an array in a List
            popularCities.AddRange(cities);

            var favouriteCities = new List<string>();

            // adding a List 
            favouriteCities.AddRange(popularCities);

            // -------------------------------------------------------------------------------------------------

            List<int> numbers = new List<int>() { 1, 2, 5, 7, 8, 10 };
            Console.WriteLine(numbers[0]); // prints 1
            Console.WriteLine(numbers[1]); // prints 2
            Console.WriteLine(numbers[2]); // prints 5
            Console.WriteLine(numbers[3]); // prints 7

            // Using Foreach
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            // Using For
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(i);       
            }

            // using foreach LINQ method
            numbers.ForEach(num => Console.WriteLine(num + ", ")); //prints 1, 2, 5, 7, 8, 10

            // -------------------------------------------------------------------------------------------------

            var numbers2 = new List<int>() { 10, 20, 30, 40 };
            int[] myArray = new int[] { 1, 2, 3, 4, 5 };

            numbers2.Insert(1, 11);// inserts 11 at 1st index: after 10.
            numbers2.InsertRange(0,myArray); // Inserts elements of another collection at the specified index.


            foreach (var num in numbers2)
                Console.WriteLine(num);

            // --------------------------------------------------------------------------------------------------

            var numbers3 = new List<int>() { 10, 20, 30, 40, 10 };
            numbers3.Remove(10); // removes the first 10 from a list
            numbers3.RemoveAt(2); //removes the 3rd element (index starts from 0)
            numbers3.RemoveRange(0,3); // Removes all the elements that match the supplied predicate function.


            // -------------------------------------------------------------------------------------------------


            var numbers4 = new List<int>() { 10, 20, 30, 40 };
            numbers.Contains(10); // returns true
            numbers.Contains(11); // returns false
            numbers.Contains(20); // returns true


            // -------------------------------------------------------------------------------------------------

            var numbers5 = new List<int>() { 10, 20, 30, 40 };

            Console.WriteLine(numbers5.BinarySearch(20)); // Search the element and returns an index of the element.

            numbers5.Clear(); // Removes all the elements from a List<T>.

            numbers5.Sort(); // Sorts all the elements.

            numbers5.TrimExcess(); // Sets the capacity to the actual number of elements.




            // TRUE FOR ALL

            List<string> dinosaurs = new List<string>();

            dinosaurs.Add("Compsognathus");
            dinosaurs.Add("Amargasaurus");
            dinosaurs.Add("Oviraptor");
            dinosaurs.Add("Velociraptor");
            dinosaurs.Add("Deinonychus");
            dinosaurs.Add("Dilophosaurus");
            dinosaurs.Add("Gallimimus");
            dinosaurs.Add("Triceratops");

            Console.WriteLine("\nTrueForAll(EndsWithSaurus): {0}",
            dinosaurs.TrueForAll(EndsWithSaurus));

            Console.WriteLine("\nFind(EndsWithSaurus): {0}",
                dinosaurs.Find(EndsWithSaurus));

            Console.WriteLine("\nFindLast(EndsWithSaurus): {0}",
                dinosaurs.FindLast(EndsWithSaurus));

            Console.WriteLine("\nFindAll(EndsWithSaurus):");
            
            List<string> sublist = dinosaurs.FindAll(EndsWithSaurus);

            foreach (string dinosaur in sublist)
            {
                Console.WriteLine(dinosaur);
            }










        }

        // Search predicate returns true if a string ends in "saurus".
        private static bool EndsWithSaurus(String s)
        {
            return s.ToLower().EndsWith("saurus");
        }









        class Student
        {
            public int Id;
            public string Name;
        }
    }

}
