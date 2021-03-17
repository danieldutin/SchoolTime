using System;


namespace Final
{


    class Program
    {

        static void Main(string[] args)

        {
            var input = Console.ReadLine().Split(' '); // user input for the dimentions of the wall

            int columns = 0;// pre-set values for the dimentionst that im going to use to parse the input to integer
            int rows = 0;

            try//validation for the input type.
            {
                rows = int.Parse(input[0]);
                columns = int.Parse(input[1]);

            }
            catch (Exception)
            {
                Console.WriteLine("Dimentionst must inclusde only real numbars separated by space");
                return;
            }

            //below : validation for the range of th e input - odd numbers between 1to100;
            if (rows < 1 || rows > 100 || rows % 2 != 0 || columns < 1 || columns > 100 || columns % 2 != 0)
            {
                Console.WriteLine("Dimentions must be odd numbers in the range between 1to100");
                return;
            }


            int[,] brickLayer1 = new int[rows, columns];//2d array to store the input for the bricks
            int[] brickLayer2 = new int[rows * columns];//1d array for the secont brick layer 
            int[] locationsofhalfbrick = new int[rows * columns];//1d array to use to transfer data from the 2d array for easiar manipulations

            for (int i = 0; i < rows; i++)// nested for loops to capture and apply to the array all the user input for the first layer of bricks
            {

                var currentRow = Console.ReadLine().Split(' ');
                if (currentRow.Length != columns)// validation if the column number responds to the dimentions from the input
                {
                    Console.WriteLine("Not Enough data for column provided");
                    return;
                }
                int currentHalfBrick = 0;// variable to store each half of brick from the first layer

                for (int j = 0; j < currentRow.Length; j++)
                {

                    try//validation for input type
                    {
                        currentHalfBrick = int.Parse(currentRow[j]);

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Each brick half must be real number");
                        return;

                    }
                    brickLayer1[i, j] = currentHalfBrick;// setting the array values for each item

                }

            }


            //below im going to represent the 2d array from the first layer to a 1d array that i can use for generating coordinate grid with exact location for each hald brick. I thing that for the next step i will need to be able to work with classes and being familiar with OOP. Unfortunately i am not there yet on my qualification. After the working code, there are many coments with all different approches that i have tried.But i feel like i still need to learn more to be able to grasp the concept for multidimentional arrays and etc.


            int current = 0;
            int rowCounter = 0;
            while (current < rows * columns)
            {
                // below im transfering data from 2d array to 1d with for loops and counter variables to indicate the transition between rows
                for (int j = 0; j < columns; j++)
                {
                    if (current < columns / rows)
                    {
                        locationsofhalfbrick[current] = brickLayer1[rowCounter, j];
                    }
                    else if (current >= columns / rows)
                    {
                        locationsofhalfbrick[current] = brickLayer1[rowCounter, j];
                    }

                    current++;
                    ;
                }
                ++rowCounter;

            }
            current = 0;
            rowCounter = 0;

            //below i am going to add the data from locationshalfbrick[] to bricklayer2[] starting from the last item in locationshalfbrick[]

            for (int i = (rows * columns) - 1; i > -1; i--)
            {

                for (int j = current; j < rows * columns; j++)
                {
                    if (current < rows * columns)
                    {
                        brickLayer2[j] = locationsofhalfbrick[i];
                        current++;
                        break;
                    }


                }


            }
            Console.WriteLine();

            // below i am just going to list the data from brricklayer2

            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < columns; j++)
                {
                    if (rowCounter > 0)
                    {
                        Console.Write($"{brickLayer2[j + columns]} ");
                    }
                    else
                    {
                        Console.Write($"{brickLayer2[j]} ");
                    }

                }

                Console.WriteLine();

                for (int p = 0; p < columns; p++)
                {
                    Console.Write("---");
                }
                rowCounter++;
                Console.WriteLine();
            }

            // after line 158 in comments are all different approaches that i have tried before
            //in the same repository in GitHub, i have the full working app which i did with the help
            //of friend of mine who was giding me trhu the concept of OOP
        }
    }
}



//for (int i = 0; i < rows; i++)
//{


//    for (int j = 0; j < rows*columns; j++)
//    {
//        if (colCounter > 1 && j < columns)
//        {
//            if (brickLayer2[j] == brickLayer2[prevIndexCounter-colCounter])
//            {

//                Console.Write($"|{brickLayer2[j]}");
//                rowCounter++;
//                prevIndexCounter++;
//                continue;
//            }
//            else
//            {
//                Console.Write($" {brickLayer2[j]}");
//                rowCounter++;
//                prevIndexCounter++;
//                continue;
//            }
//        }
//        else if (j > columns - 1)
//        {
//            if (brickLayer2[j] == brickLayer2[j - colCounter])
//            {

//                Console.Write($"|{brickLayer2[j]}");
//                rowCounter++;
//                prevIndexCounter++;
//                continue;
//            }
//            else
//            {
//                Console.Write($" {brickLayer2[j]}");
//                rowCounter++;
//                prevIndexCounter++;
//                continue;
//            }
//        }
//        Console.Write($"{brickLayer2[j]} ");
//        rowCounter++;
//        prevIndexCounter++;
//    }

//    Console.WriteLine();

//    rowCounter = 0;
//    colCounter++;



//}


//for (int k = rows - 1; k > -1; k--)
//{



//    //for (int p = columns - 1; p > -1; p--)
//    //{

//    //    if (brickLayer1[k, p] == brickLayer1[(rowCounter - 1), (current - 1)])
//    //    {
//    //        Console.Write("|");
//    //        Console.Write($"{brickLayer1[k, p]} ");
//    //    }
//    //    else
//    //    {
//    //        Console.Write($"{brickLayer1[k, p]} ");
//    //    }
//    //    rowCounter++;
//    //}
//    //current++;

//    //Console.WriteLine();
//}

//int counter = rows - 1;
//for (int i = counter; i > -1; i--)
//{
//    for (int j = columns -1; j > -1; j--)
//    {
//        brickLayer2[j] = brickLayer1[i, j];
//    }
//    counter--;
//    if (counter == (rows -1))
//    {
//        break;
//    }
//}

//for (int p = 0; p < columns; p++)
//{
//    if (colCounter > 1)
//    {
//        if (brickLayer2[(rowCounter * p)] == brickLayer2[(p / rowCounter)])
//        {
//            Console.Write("---");
//            continue;
//        }
//        else
//        {
//            Console.Write("*");

//            continue;
//        }

//    }
//    Console.Write(" * ");

//}
//Console.WriteLine();
//Dictionary<Array, Array> brickLocations = new Dictionary<Array, Array>();//int z = 0;

//for (int v = 0; v < rows; v++)
//{
//    for (int b = 0; b < columns; b++)
//    {


//        for (int p = 0; p < rows; p++)
//        {


//            for (int z = 0; z < columns; z++)
//            {

//                var currentRow = brickLayer2[v, b];
//                int id = int.Parse(currentRow);
//                if (currentRow == 0 && )
//                {
//                    brickLayer2[v, b] = brickLayer1[p, z];
//                }
//                else if (currentRow > 0)
//                {

//                        brickLayer2[v, b] = currentRow;
//                    break;

//                }
//            }
//        }
//    }

//}

//while(current < rows)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        int halfBrickSLOT = Array.Find(brickLayer2, a => a == null);
//        int halfbrick = Array.IndexOf(brickLayer2, halfBrickSLOT, current);

//        if ((current+1)%2 ==0)
//        {
//            brickLayer2[halfbrick] = locationsofhalfbrick[current];
//            continue;

//        }
//        else 
//        {
//            brickLayer2[halfBrickSLOT] = locationsofhalfbrick[current];
//        }








//        // Console.Write($"{brickLayer2[i, j]} ");
//        current++;
//    }
//    current++;
//    ++rowCounter;
//}
//rowCounter = 0;
//current = 0;


//for (int i = 0; i < rows * columns; i++)
//{
//    Console.Write($"{brickLayer2[i]} ");
//    if (i == (columns/rows)-1)
//    {
//        Console.WriteLine();
//    }
//}

//while (current < rows * columns)
//{

//    for (int j = 0; j < columns; j++)
//    {
//        Console.Write($"{brickLayer2[current]} ");
//        current++;
//        ;
//    }
//    ++rowCounter;
//    Console.WriteLine();
//}

//foreach (var item in brickLayer2)
//{
//    brickLayer2[item] = 0;
//}

//id = brickLayer1[i, j];
//if (id!=null|| )
//{

//}
//brickLayer2[i,j] = id;
//foreach (int item in brickLayer2)
//{
//    if (item < (rows/columns)-1)
//    {
//        if (item == (item -1))
//        {
//            Console.Write($"|{item}");
//        }
//        else
//        {
//            Console.Write($"*{item}");
//        }
//        prevIndexCounter++;
//    }

//    Console.WriteLine();

//    for (int i = 0; i < (brickLayer2.Length)/prevIndexCounter; i++)
//    {
//        if (prevIndexCounter>1)
//        {
//            if (item == item / prevIndexCounter)
//            {
//                Console.Write("---");
//            }
//            else
//            {
//                Console.Write("***");
//            }
//        }

//    }

//    Console.WriteLine();

//    if (item >= (rows/columns)-1)
//    {
//        if (item == (item - 1))
//        {
//            Console.Write($"|{item}");
//        }
//        else
//        {
//            Console.Write($"*{item}");
//        }
//        prevIndexCounter++;
//    }
//}