using System;

namespace SwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double oldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());

            double cleartime = distance * secondsPerMeter;
            double delay = Math.Floor(distance / 15.0) * 12.5;
            double ivansrelatime = cleartime + delay;


            if (ivansrelatime < oldRecord)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {ivansrelatime:f2} seconds.");
            }
            else
            {
                double timedifference = ivansrelatime - oldRecord;
                Console.WriteLine($"No, he failed! He was {timedifference:f2} seconds slower.");
            }
        }
    }
}
