using System;

namespace magicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            
            int magicNumber = int.Parse(Console.ReadLine());
            int count = 0;
           
            bool magicComboFound = false;

            for (int i = begin; i <= end; i++)
            {
                for (int j = begin; j <= end; j++)
                {


                    count++;
                    if (i + j == magicNumber)
                    {

                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {magicNumber})");
                        magicComboFound = true;
                        break;

                    }
                    


                }
                if (magicComboFound)
                {
                    break;
                }

            }

            if (!magicComboFound)
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
            }
                
            

            




        }
    }
}
