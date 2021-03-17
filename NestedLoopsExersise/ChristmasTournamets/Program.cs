using System;

namespace ChristmasTournamets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
           
            int globalWins = 0;
            int globalLoses = 0;
            int windays = 0;
            int losedays = 0;
            double raisedMoney = 0;
            double allMoney = 0;


            for (int i = 1; i <= days; i++)
            {
                int losesForDay = 0;
                int winsForDay = 0;
                bool finnish = true;
                
                while (finnish)
                {
                    
                    string command = Console.ReadLine();
                    if (command == "Finish")
                    {
                        finnish = false;
                        continue;
                    }
                    string outcome = Console.ReadLine();
                    if (outcome == "win")
                    {
                        winsForDay++;
                        raisedMoney += 20;
                    }
                    else if (outcome == "lose")
                    {
                        losesForDay++;
                    }
                    finnish = true;
                   
                    
                }
                
                if(winsForDay > losesForDay)
                {
                    raisedMoney += raisedMoney * 0.10;
                    windays++;
                }
                if (winsForDay<losesForDay)
                {
                    losedays++;
                }
                allMoney += raisedMoney;
                globalWins += winsForDay;
                globalLoses += losesForDay;
                raisedMoney = 0;


            }
            if (windays>losedays)
            {
                allMoney += allMoney * 0.20;
            }
            if (globalWins > globalLoses)
            {
                Console.WriteLine($"You won the tournament! Total raised money: {allMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {allMoney:f2}");
            }




        }
    }
}
