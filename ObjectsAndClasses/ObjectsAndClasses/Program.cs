using System;

namespace ObjectsAndClasses
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Dog rufus = new Dog
            {
               Age = 5,
               Name = "Rufus",
               Breed = "Corgi"
            };

            Console.WriteLine($"{rufus.Name} is a {rufus.Breed} and is {rufus.Age} years old");
            rufus.Bark();
        }
    }
}
