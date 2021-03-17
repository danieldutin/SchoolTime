using System;

namespace lorryinsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            double lorryPrice = double.Parse(Console.ReadLine());
            double newTarrif = 0;
            double lorrysAge = double.Parse(Console.ReadLine());
            double insurancePrice = 0;
            double tarrifNumber = 0;
            if (lorrysAge <= 3)
            {
                
                    tarrifNumber = 0.021;
               
                insurancePrice += ((Math.Abs(tarrifNumber - (tarrifNumber * 0.45))));
                newTarrif = insurancePrice * (lorryPrice + (lorryPrice * 0.02));
            }
            if (lorrysAge<= 10 && lorrysAge > 3)
            {
                if (lorryPrice <= 30000)
                {
                    tarrifNumber = 0.026;
                }
                else
                {
                    tarrifNumber = 0.023;
                }
                insurancePrice += ((Math.Abs(tarrifNumber - (tarrifNumber * 0.45))));
                newTarrif = insurancePrice * (lorryPrice + (lorryPrice*0.02));
            }
            
            if (lorrysAge >10)
            {
                if (lorryPrice <= 30000)
                {
                    tarrifNumber = 0.029;
                }
                else
                {
                    tarrifNumber = 0.026;
                }
                insurancePrice += ((Math.Abs(tarrifNumber - (tarrifNumber * 0.45))));
                newTarrif = insurancePrice * (lorryPrice + (lorryPrice * 0.02));
            }


            Console.WriteLine($"Your insurance price is: {newTarrif:f2}");

        }
    }
}
