using System;
using System.Collections.Generic;


namespace anotherTry
{
    class Program
    {
        // declaring constant variables for the borders
        public const String SingleSolidBorder = "*";// between bricks horizontaly
        public const String SingleLightBorder = "|";// between brick half horizontaly (ex. *1|1*2|2*)
        public const String SolidBorder = "***";// between bricks verticaly
        public const String LightBorder = "---";// between brick halfs verticaly

        static void topAndNextLayer(int[,]bricks, int currentRow, int cols)
        {
            foreach (bool top in new bool[] {true, false})
            {
                for (int i = 0; i < currentRow; i++)
                {
                    if (top)
                    {
                        Console.Write(SingleSolidBorder);
                        // If the half-brick above this one is with the same id, then put the 'light border'
                        if (currentRow != 0 && bricks[currentRow, i] == bricks[currentRow - 1, i])
                        {
                            Console.Write(LightBorder);
                        }
                        else // else put the 'solid border'
                        {
                            Console.Write(SolidBorder);
                        }
                    }
                    else // middle side
                    {
                        // If the half-brick before this one is with the same id, then put the 'light border'
                        if (i != 0 && bricks[currentRow, i] == bricks[currentRow, i - 1])
                        {
                            Console.Write(SingleLightBorder);
                        }
                        else // else put the 'solid border'
                        {
                            Console.Write(SingleSolidBorder);
                        }

                        Console.Write($"{bricks[currentRow, i],3}");
                    }

                    // If this is on the last column, then close the gap
                    if (i == cols - 1)
                        Console.Write(SingleSolidBorder);
                }

                Console.WriteLine();    

            }
        }
        static void Main(string[] args)
        {
            
            var dimentions = Console.ReadLine().Split(" ");// the variable that im going to use to store the input for dimentions of the wall

            if (dimentions.Length!=2)// validation for wall dimentions to be 2d.
            {
                Console.WriteLine("Invalid columns and rows count provided");
                return;
            }
            int cols;// for the columns of the first layer of bricks
            int rows;// for the rows of the first layer of bricks

            try // validation for the input if its in corect type
            {
                cols = int.Parse(dimentions[1]);
                rows = int.Parse(dimentions[0]);
            }
            catch (Exception)
            {
                Console.WriteLine("Dimentions input should consist 2 numbers separated by space");
                return;
            }

            // below : validations for the input if its in the valid range of numbers.(odds between 1to100)
            if (rows < 1 || rows > 100 || cols < 1 || cols > 100)
            {
                Console.WriteLine("Columns and rows should be positive even numbers less than or equal to 100");
                return;
            }
            if (rows % 2 != 0 || cols % 2 != 0)
            {
                Console.WriteLine("Rows and columns should be even numbers");
                return;
            }


        }
    }
}
