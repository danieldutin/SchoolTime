using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int bestSequenceSize = 0;
            int bestSequenceNumber = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int current = array[i];
                int isLongestCounter = 1;
                

                for (int j = i + 1; j < array.Length; j++)
                {
                    int rightNumber = array[j];

                    if ( current == rightNumber)
                    {
                        isLongestCounter += 1;
                    }
                    else
                    {
                        break;
                    }
                }

                if (isLongestCounter>bestSequenceSize)
                {
                    bestSequenceSize = isLongestCounter;
                    bestSequenceNumber = current;
                }
            }

            for (int i = 0; i < bestSequenceSize; i++)
            {
                Console.Write($"{bestSequenceNumber} ");
            }

            Console.WriteLine();
        }
    }
}
