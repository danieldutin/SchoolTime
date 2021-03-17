using System;

namespace OffsidePosition
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] teams = new int[2, 11];

            OffsidePosition(teams);
            
        }


        static bool OffsidePosition(int[,] teams)
        {
            if (OffSideTeamOne(teams)||OffSideTeamTwo(teams))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        static bool OffSideTeamOne(int[,] teamOne)
        {
            int goalKeeper = 100;
            int lastPlayer = 100;

            bool offSide = false;

            for (int i = 0; i < teamOne.Rank; i++)
            {
                for (int j = 0; j < teamOne.Length / teamOne.Rank; j++)
                {
                    if (i < 1 && teamOne[i, j] < lastPlayer)
                    {
                        if (teamOne[i, j] < goalKeeper)
                        {
                            lastPlayer = goalKeeper;
                            goalKeeper = teamOne[i, j];
                            continue;
                        }

                        lastPlayer = teamOne[i, j];
                    }
                    if (i > 0 && teamOne[i, j] < lastPlayer)
                    {
                        offSide = true;
                        break;
                    }
                    else
                    {
                        offSide = false;
                    }

                }
                if (offSide)
                {
                    break;
                }

            }

            return offSide;
        }

        static bool OffSideTeamTwo(int[,] teamTwo)
        {
            int goalKeeper = 0;
            int lastPlayer = 0;

            bool offSide = false;

            for (int i = teamTwo.Rank - 1; i <= 0; i--)
            {
                for (int j = teamTwo.Length - 1/ teamTwo.Rank; j <=0 / teamTwo.Rank; j--)
                {
                    if (i < 1 && teamTwo[i, j] > lastPlayer)
                    {
                        if (teamTwo[i, j] > goalKeeper)
                        {
                            lastPlayer = goalKeeper;
                            goalKeeper = teamTwo[i, j];
                            continue;
                        }

                        lastPlayer = teamTwo[i, j];
                    }
                    if (i > 0 && teamTwo[i, j] < lastPlayer)
                    {
                        offSide = true;
                        break;
                    }
                    else
                    {
                        offSide = false;
                    }

                }
                if (offSide)
                {
                    break;
                }

            }

            return offSide;
        }
    }

   
}
