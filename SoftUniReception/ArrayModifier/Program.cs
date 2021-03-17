using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string[] command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                if (command[0] == "end")
                {
                    break;
                }
                MyMethod(command, myArr);
            }
            Console.WriteLine(string.Join(", ", myArr));

        }

        public static void MyMethod(string[] arrString, int[] arrInt)
        {
            if (arrString[0] == "swap")
            {
                int indexOne = int.Parse(arrString[1]);
                int indexTwo = int.Parse(arrString[2]);
                int last = arrInt[indexOne];
                arrInt[indexOne] = arrInt[indexTwo];
                arrInt[indexTwo] = last;

            }
            else if (arrString[0] == "multiply")
            {
                ArrayMultiplication(arrString, arrInt);
            }
            else if (arrString[0] == "decrease")
            {
                for (int i = 0; i < arrInt.Length; i++)
                {
                    arrInt[i] = arrInt[i] - 1;
                }
            }

        }
        public static void ArrayMultiplication(string[] arrString, int[] arrInt)
        {
            int indexOne = int.Parse(arrString[1]);
            int indexTwo = int.Parse(arrString[2]);
            int result = arrInt[indexOne] * arrInt[indexTwo];
            arrInt[indexOne] = result;
        }

    }
}
