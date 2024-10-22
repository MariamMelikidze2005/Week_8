using System;

namespace week9
{
    abstract class Person
    {
        public abstract string GetOccupation();
        
        
        public string Name { get; set; }
        public int Age { get; set; }


        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }


        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        public virtual void Describe()
        {
            Console.WriteLine("I am person");
        }

    }
}
