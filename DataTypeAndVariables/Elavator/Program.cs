using System;

namespace Elavator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPpl = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            bool noMorePeople = false;
            int nextCoursePpl = 0;
            int courseCounter = 1;

            int numberOfCourses = numberOfPpl / capacity;
            //while (!noMorePeople)
            //{
            //    nextCoursePpl -= capacity;
            //    if (nextCoursePpl < 1)
            //    {
            //        Console.WriteLine("All the persons fit inside in the elevator. Only one course is needed.");
            //        noMorePeople = true;
            //    }
            //    else
            //    {
            //        courseCounter++;
            //    }
            //}
            //if (numberOfPpl > capacity)
            //{
            //    nextCoursePpl = numberOfPpl - capacity;
            //    courseCounter++;
            //}
            //else if (true)
            //{

            //}
            //if (true)
            //{

            //}
        }
    }
}
