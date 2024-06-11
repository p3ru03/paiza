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

//        int[,] map = new int[N, N];

//        string answer = "wait";

//        for (int i = 0; i < N; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            for (int j = 0; j < N; j++)
//            {
//                map[i, j] = int.Parse(datas[j]);
//            }
//        }

//        for (int j = 0; j < N; j++)
//        {
//            for (int i = 0; i < N; i++)
//            {
//                if (map[i, j] >= M)
//                {
//                    break;
//                }
//                if (i == N - 1)
//                {
//                    if (answer == "wait")
//                    {
//                        answer = (j + 1).ToString();
//                    }
//                    else
//                    {
//                        answer += " " + (j + 1).ToString();
//                    }
//                }
//            }
//        }
//        Console.WriteLine(answer);
//    }
//}

