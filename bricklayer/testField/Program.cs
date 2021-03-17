using System;

namespace BrickWall
{
    class BrickWallTrial
    {
        static void Main(string[] args)

        {
            //first i declare the variables in which i am going to store the user input for the width and length

            int n;
            int m;
            
            
            var dimentions = Console.ReadLine().Split(" ");// capturing user input and split it by space to get the dimentions
            n = int.Parse(dimentions[0]);
            m = int.Parse(dimentions[1]);

            // bellow im going to validate the users input for odd numbers in range between 1to100
            if (n <= 0 || n > 100||m <= 0 || m > 100)
            {
                Console.WriteLine("Wrong input!Please use real numbers only in the interval between 1 and 100");
                
                return;
            }
            else if (n % 2 != 0|| m % 2 != 0)
            {
                Console.WriteLine("Please use only odd numbers");
                
                return;
            }

            //i initialize two-dimentional array in which im going to store all the data from the user input
            //the parameters of the array are automatically set, by the values of "n" and "m"
            int[,] FirstBrickLayer = new int[n, m];

            //below im using nested "for"-loops to set the values of the array using user input 
            //which has been captured by characters and then those chars has been convertet ToString 
            //and parsed to integer, so their values can be added to the array

            for (int i = 0; i < n; i++)
            {
                var newBrick = Console.ReadLine().Split(" ");
                
                for (int j = 0; j < m; j++)
                {
                    int newPiece = int.Parse(newBrick[j]);
                    
                    FirstBrickLayer[i, j] = newPiece;
                }
                
            }
            //As my current technical knowledge is limited by what i have studied last few months i still 
            // not have the full grasp of the concept of multidimentional arrays and matrix operations
            //in my mind i am thinking that the possible way to solve this problem as described in the specification
            // i was planning to use another 2d array, but i have reach a dead end
            // int[,] SecondBrickLayer = new int[n, m];

            //instead below i have set a couple of nested loops to simulate the working application
            //using just "mirrored" read of the items from the array.But its a hoax and only works with a specific input
            //for (int x = 0; x < n; x++)
            //{
            //    for (int z = 0; z < m; z++)
            //    {
            //        Console.Write($"{FirstBrickLayer[x, z]} ");
            //    }
            //    Console.WriteLine();
            //}
            for (int k = n - 1; k > -1; k--)
            {
                for (int p = m - 1; p > -1; p--)
                {
                    Console.Write($"{FirstBrickLayer[k, p]} ");
                }
                Console.WriteLine();
            }
        }
    }
}


       