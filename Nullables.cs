// Main

Person person = new Person("Nicolas", 18);

person.SayName();
person.CheckPiercings();

class Person
{
    public string name;
    public int age;
    int? piercings;

    public Person(string name, int age, int? piercings = null)
    {
        this.name = name;
        this.age = age;
        this.piercings = piercings;
    }

    public void SayName()
    {
        Console.WriteLine($"Hello, my name is {name}");
    }

    public void CheckPiercings()
    {
        if (piercings != null)
        {
            Console.WriteLine($"I have {piercings} piercings");
        }
    }

}
