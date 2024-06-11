//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int N = int.Parse(datas[0]);
//        int M = int.Parse(datas[1]);

//        int[,] players = new int[N, 3];
//        for (int i = 0; i < N; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            for (int j = 0; j < 3; j++)
//            {
//                players[i, j] = int.Parse(datas[j]);
//            }
//        }

//        string[,] deck = new string[M, 4];
//        for (int m = 0; m < M; m++)
//        {
//            datas = Console.ReadLine().Split(' ');

//            for (int i = 0; i < N; i++)
//            {
//                for (int j = 0; j < 3; j++)
//                {
//                    if (datas[0] == "a")
//                    {
//                        if (players[i, j] == 1 || int.Parse(datas[j + 1]) == 1)
//                        {
//                            players[i, j] = 1;
//                        }
//                        else
//                        {
//                            players[i, j] = 0;
//                        }
//                    }
//                    else if (datas[0] == "b")
//                    {
//                        if (players[i, j] == 0 || int.Parse(datas[j + 1]) == 0)
//                        {
//                            players[i, j] = 0;
//                        }
//                        else
//                        {
//                            players[i, j] = 1;
//                        }
//                    }
//                    else if (datas[0] == "c")
//                    {
//                        if (players[i, j] != int.Parse(datas[j + 1]))
//                        {
//                            players[i, j] = 1;
//                        }
//                        else
//                        {
//                            players[i, j] = 0;
//                        }
//                    }
//                }

//            }
//        }

//        int[] results = new int[N];
//        int max = 0;
//        for (int i = 0; i < N; i++)
//        {
//            results[i] = 4 * players[i, 0] + 2 * players[i, 1] + players[i, 2];
//            if (results[i] > max)
//            {
//                max = results[i];
//            }
//        }

//        for (int i = 0; i < N; i++)
//        {
//            if (results[i] == max)
//            {
//                Console.WriteLine(i+1);
//            }
//        }
//    }
//}

