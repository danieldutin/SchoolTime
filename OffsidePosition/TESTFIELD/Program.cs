//using System;

//namespace TESTFIELD
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int goalKeeper = 100;
//            int lastPlayer = 100;

//            bool offSide = false;

//            for (int i = 0; i < teams.Rank; i++)
//            {
//                for (int j = 0; j < teams.Length / teams.Rank; j++)
//                {
//                    if (i < 1 && teams[i, j] < lastPlayer)
//                    {
//                        if (teams[i, j] < goalKeeper)
//                        {
//                            lastPlayer = goalKeeper;
//                            goalKeeper = teams[i, j];
//                            continue;
//                        }

//                        lastPlayer = teams[i, j];
//                    }
//                    if (i > 0 && teams[i, j] < lastPlayer)
//                    {
//                        offSide = true;
//                        break;
//                    }
//                    else
//                    {
//                        offSide = false;
//                    }

//                }
//                if (offSide)
//                {
//                    break;
//                }

//            }

//            return offSide;

//        }
//    }
//}
//}
