using System;
using System.Collections;
using System.Collections.Generic;



namespace brick2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            int M = 0;

            int[][] layerOne = new int[N][];
            
            while (N == 0)
            {
                N = int.Parse(Console.ReadLine());
                if (N <= 0 || N > 100)
                {
                    Console.WriteLine("Wrong input!Please use real numbers only in the interval between 1 and 100");
                    N = 0;
                    continue;
                }
                else if (N%2!=0)
                {
                    Console.WriteLine("Please use only odd numbers");
                    N = 0;
                    continue;
                }
                Console.WriteLine($"Number {N} is accepted for number of rows");
            }
            while (M == 0)
            {
                M = int.Parse(Console.ReadLine());
                if (M <= 0 || M > 100)
                {
                    Console.WriteLine("Wrong input!Please use real numbers only in the interval between 1 and 100");
                    M = 0;
                    continue;
                }
                else if (M % 2 != 0)
                {
                    Console.WriteLine("Please use only odd numbers");
                    M = 0;
                    continue;
                }
                Console.WriteLine($"Number {M} is accepted for number of colums");
            }
            layerOne[0] = new int[M];
            for (int i = 1; i < M+1; i++)
            {
                layerOne[i] = new int[M];
            }



            for (int j = 0; j < N; j++)
            {
                for (int k = 0; k < M; k++)
                {

                }
            }



            //for (int i = 1; i < N; i++)
            //{
            //    layerOne[i] = Console.ReadLine();
            //}

            //for (int j = 0; j < N; j++)
            //{

            //}

            //var brickLayer = new List<string>();
            //var brickLayer2 = new List<string>();

            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = 0; j < M; j++)
            //    {
                    
            //            brickLayer.Add(Console.ReadLine());
                    
            //    }
            //}
            


            //brickLayer.ForEach(Console.Write);


        }
    }
}
