using System;

namespace IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            int numberFour = int.Parse(Console.ReadLine());

            long result = ((numberOne+numberTwo)/numberThree)*numberFour;

            Console.WriteLine(result);

        }
    }
}
