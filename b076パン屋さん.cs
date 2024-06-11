//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int N = int.Parse(datas[0]);
//        int Q = int.Parse(datas[1]);

//        int[,] pans = new int[N, 2];
//        for (int i = 0; i < N; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            pans[i, 0] = int.Parse(datas[0]);
//            pans[i, 1] = int.Parse(datas[1]);
//        }

//        string[] q = new string[Q];
//        int[,] change = new int[Q, N];
//        for (int i = 0; i < Q; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            q[i] = datas[0];
//            for (int j = 0; j < N; j++)
//            {
//                change[i, j] = int.Parse(datas[j + 1]);
//            }
//        }

//        for (int i = 0; i < Q; i++)
//        {
//            //buy
//            if (q[i] == "buy")
//            {
//                int check = 0;
//                for (int j = 0; j < N; j++)
//                {
//                    int dif = pans[j, 1] - change[i, j];
//                    if (dif >= 0)
//                    {
//                        check++;
//                    }
//                }
//                //全部買えるなら
//                if (check == N)
//                {
//                    int sum = 0;
//                    for (int j = 0; j < N; j++)
//                    {
//                        int dif = pans[j, 1] - change[i, j];
//                        pans[j, 1] = dif;
//                        sum += change[i, j] * pans[j, 0];
//                    }
//                    Console.WriteLine(sum);
//                }
//                else
//                {
//                    Console.WriteLine(-1);
//                }
//            }
//            //bake
//            else
//            {
//                for (int j = 0; j < N; j++)
//                {
//                    pans[j, 1] += change[i, j];
//                }
//            }
//        }
//    }
//}