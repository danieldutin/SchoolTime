using System;

namespace RefractorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());
            double pyramidVolume = (lenght + width + heigth)/3;
            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {pyramidVolume:f2}");

        }
    }
}
