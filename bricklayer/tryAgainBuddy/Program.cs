using System;

namespace tryAgainBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char nInput = input[0];
            char mInput = input[1];
            int n = int.Parse(nInput.ToString());
            int m = int.Parse(mInput.ToString());
            int[,] FirstBrickLayer = new int[n, m];
            int[,] SecondBrickLayer = new int[n, m];
            string newBrick;
            int intConverter;
            int col;
            int row;    

            for (col = 0; col < n; col++)
            {
                newBrick = Console.ReadLine();
                for (row = 0; row < m; row++)
                {
                    char brickpeace = newBrick[row];
                    string converter = brickpeace.ToString();
                    intConverter = int.Parse(converter);
                    FirstBrickLayer[col, row] = intConverter;
                }
                newBrick = "";
            }
            for (int x = 0; x < n; x++)
            {
                for (int z = 0; z < m; z++)
                {
                    Console.Write($"{FirstBrickLayer[x, z]} ");
                }
                Console.WriteLine();
            }
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
