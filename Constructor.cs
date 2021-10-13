using System;

namespace SimpleConstructor
{
    class User
    {

        public string name;
        public readonly int id;

        public User(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        private void IDInfo()
        {
            Console.WriteLine("Hello " + name +  ", your ID is " + id);
        }




        static void Main(string[] args)
        {
            User user0 = new User("Crazy Dave", 1);
            User user1 = new User("Dr.Zombos", 2);
            user0.IDInfo(); user1.IDInfo();
        }
    }
}
