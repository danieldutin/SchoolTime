namespace ConsoleApp1
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    namespace BricksFun
    {
        class Brick
        {
            public int id = -1; // name of brick(ex 1 1)

            
            public int x1 = -1;
            public int y1 = -1;

           
            public int x2 = -1;
            public int y2 = -1;
        }

        class Program
        {
            static int GetIndexByXY(int x, int y, int width)
            {
                return width * x + y; // https://stackoverflow.com/questions/2151084/map-a-2d-array-onto-a-1d-array
            }

            static bool MyPredicate(Brick brick, int id)
            {
                return brick != null && brick.id == id;
            }

            static void Main(string[] args)
            {
                var dimention = Console.ReadLine().Split(' ');
                if (dimention.Length != 2)
                {
                    Console.WriteLine("Wrong input data");
                    return;
                }

                int rows = int.Parse(dimention[0]);
                int columns = int.Parse(dimention[1]);

                Brick[] grid = new Brick[rows * columns];

                for (int i = 0; i < rows; ++i)
                {
                    var currentRow = Console.ReadLine().Split(' ');
                    if (currentRow.Length != columns)
                    {
                        Console.WriteLine("Invalid columns count");
                        return;
                    }

                    for (int j = 0; j < currentRow.Length; ++j)
                    {
                        int id = int.Parse(currentRow[j]);

                        Brick brick = Array.Find(grid, a => a != null && a.id == id);
                        if (brick == null)
                        {
                            brick = new Brick();
                            brick.id = id;
                            brick.x1 = i;
                            brick.y1 = j;
                        }
                        else
                        {
                            brick.x2 = i;
                            brick.y2 = j;
                        }

                        int index = GetIndexByXY(i, j, currentRow.Length);
                        grid[index] = brick;
                    }
                }
                Brick[] grid2 = new Brick[rows * columns];

               
                
            }

        }
    }
}
