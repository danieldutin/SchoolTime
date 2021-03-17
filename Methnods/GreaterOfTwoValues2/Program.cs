using System;
using System.Linq;

namespace GreaterOfTwoValues2
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();

            string first = Console.ReadLine().ToLower();
            string second = Console.ReadLine().ToLower();


            if (type == "int")
            {
                Console.WriteLine(Intechecker(int.Parse(first), int.Parse(second)));
            }
            else if (type == "char")
            {
                Console.WriteLine(Charchecker(first[0], second[0]));
            }
            else
            {
                Console.WriteLine(StringChecker(first, second));
            }
        }

        static int Intechecker(int a, int b)
        {
            if (a>b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static char Charchecker(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }

        }
        static string StringChecker(string a, string b)
        {
            int sumOne=0;
            int sumTwo=0;
            char[] test1 = a.ToArray();
            char[] test2 = b.ToArray();

            for (int i = 0; i < test1.Length; i++)
            {
                sumOne += a[i];
            }

            for (int i = 0; i < test2.Length; i++)
            {
                sumTwo += b[i];
            }
            string stringBigger = "";
            if (sumOne>sumTwo)
            {
               return stringBigger = a;
            }
            else
            {
                return stringBigger = b;
            }

        }

    }

}
