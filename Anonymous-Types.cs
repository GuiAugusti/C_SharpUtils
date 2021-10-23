using System;

namespace Anonymous
{
    //In C#, an anonymous type is a type (class) without any name that can
    //contain public read-only properties only.
    //It cannot contain other members, such as fields, methods, events, etc.

    //The properties of anonymous types are read-only and cannot be initialized with a null,
    //anonymous function, or a pointer type. The properties can be accessed using dot (.) notation,
    //same as object properties. However, you cannot change the values of properties as they are read-only.

    class Program
    {
        static void Main(string[] args)
        {
            var student = new { id = 1, firstName = "James", lastName = "Bond" }; // Anonymous TYPE
            // student.id = 100; error: anonymous type properties are READ-ONLY
            Console.WriteLine(student.id);

            //An anonymous types property can include another anonymous type:
            var student2 = new { id = 1, firstName = "James", lastName = "Bond", address = new { Id = 1, City = "London", Country = "UK" } };
            Console.WriteLine(student2.address.City);

            // You can create an array of anonymous types also:
            var students = new[]
            {
                new { Id = 1, FirstName = "James", LastName = "Bond" },
                new { Id = 2, FirstName = "Steve", LastName = "Jobs" },
                new { Id = 3, FirstName = "Bill", LastName = "Gates" }
            };
            Console.WriteLine(students[0].FirstName + " " + students[0].LastName);

        }
    }
}
