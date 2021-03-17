using System;
using System.Collections.Generic;
class BrickFun
{
    public const String SingleSolidBorder = "*";
    public const String SingleLightBorder = "|";
    public const String SolidBorder = "***";
    public const String LightBorder = "---";

    static void PrintTopAndMiddleOfRow(int[,] bricks, int currentRow, int columns)
    {
        foreach (bool top in new bool[] { true, false })
        {
            for (int i = 0; i < columns; ++i)
            {
                if (top) // top side
                {
                    // Top left always starts with a gap, so this will close it
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
                if (i == columns - 1)
                    Console.Write(SingleSolidBorder);
            }

            Console.WriteLine();
        }
    }

    static void PrintBricks(int[,] bricks, int rows, int columns)
    {
        Console.WriteLine();

        for (int i = 0; i < rows; ++i)
        {
            PrintTopAndMiddleOfRow(bricks, i, columns);
        }

        // Close the bottom side
        for (int i = 0; i < columns; ++i)
        {
            Console.Write(SingleSolidBorder);
            Console.Write(SolidBorder);
        }
        Console.WriteLine(SingleSolidBorder);
    }

    static int[,] CreateNextLayer(int[,] prevLayer, int rows, int columns)
    {
        var nextLayer = new int[rows, columns];

        int currentBrickId = 1; // start from brick with id 1
        for (int i = 0; i < rows; ++i)
        {
            for (int j = 0; j < columns; ++j)
            {
                // If there is already a brick on that possition
                // just skip it
                if (nextLayer[i, j] != 0)
                    continue;

                // Place the first half of the current brick
                nextLayer[i, j] = currentBrickId;

                if (j + 1 != columns && nextLayer[i, j + 1] == 0 && prevLayer[i, j] != prevLayer[i, j + 1])
                {
                    // Check if we can add the second half horizontally and add if we can
                    nextLayer[i, j + 1] = currentBrickId;
                }
                else if (i + 1 != rows && nextLayer[i + 1, j] == 0 && prevLayer[i, j] != prevLayer[i + 1, j])
                {
                    // Check if we can add the second half vertically and add if we can
                    nextLayer[i + 1, j] = currentBrickId;
                }
                else
                {
                    return null; // No solution
                }

                currentBrickId++;
            }
        }

        return nextLayer;
    }
    static void Main(string[] args)
    {
        var dimention = Console.ReadLine().Split(' ');
        if (dimention.Length != 2)
        {
            Console.WriteLine("Invalid columns and rows count provided");
            return;
        }

        int rows;
        int columns;

        try
        {
            rows = int.Parse(dimention[0]);
            columns = int.Parse(dimention[1]);
        }
        catch (Exception)
        {
            Console.WriteLine("Input should consist only of space separated numbers");
            return;
        }


        if (rows < 1 || rows > 100 || columns < 1 || columns > 100)
        {
            Console.WriteLine("Columns and rows should be positive even numbers less than or equal to 100");
            return;
        }

        if (rows % 2 != 0 || columns % 2 != 0)
        {
            Console.WriteLine("Rows and columns should be even numbers");
            return;
        }

        // Dictionary is used as a simple way to check how much each brick spans
        Dictionary<int, int> spanDict = new Dictionary<int, int>();

        var firstLayer = new int[rows, columns];
        for (int i = 0; i < rows; ++i)
        {
            var currentRowInput = Console.ReadLine().Split(' ');
            if (currentRowInput.Length != columns)
            {
                Console.WriteLine("Not enough data for column provided");
                return;
            }

            for (int j = 0; j < columns; ++j)
            {
                int id;
                try
                {
                    id = int.Parse(currentRowInput[j]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Input should consist only of space separated numbers");
                    return;
                }

                if (!spanDict.ContainsKey(id))
                {
                    spanDict[id] = 1;
                }
                else
                {
                    if (++spanDict[id] > 2)
                    {
                        Console.WriteLine("A brick spans on more than 2 rows or columns");
                        return;
                    }
                }

                firstLayer[i, j] = id;
            }
        }

        var secondLayer = CreateNextLayer(firstLayer, rows, columns);

        if (secondLayer != null)
            PrintBricks(secondLayer, rows, columns);
        else
            Console.WriteLine("-1 No solution exits");
    }
}


