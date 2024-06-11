//using System;
//using System.Linq;
//using System.Collections.Generic;
//using System.Globalization;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int H = int.Parse(datas[0]);
//        int W = int.Parse(datas[1]);
//        char[,] ans = new char[H, W];
//        for (int i = 0; i < H; i++)
//        {
//            for (int j = 0; j < W; j++)
//            {
//                ans[i, j] = '_';
//            }
//        }

//        datas = Console.ReadLine().Split(' ');
//        int N = int.Parse(datas[0]);
//        int M = int.Parse(datas[1]);

//        char[,] pattern = new char[N, M];
//        for (int i = 0; i < N; i++)
//        {
//            string data = Console.ReadLine();
//            for (int j = 0; j < M; j++)
//            {
//                pattern[i, j] = data[j];
//            }
//        }

//        int Q = int.Parse(Console.ReadLine());
//        int[,] change = new int[Q, 2];
//        for (int i = 0; i < Q; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            change[i, 0] = int.Parse(datas[0]) - 1;
//            change[i, 1] = int.Parse(datas[1]) - 1;
//        }

//        //Q回の反転
//        for (int q = 0; q < Q; q++)
//        {
//            int x = change[q, 0];
//            int y = change[q, 1];
//            for (int i = y; i < y + N; i++)
//            {
//                for (int j = x; j < x + M; j++)
//                {
//                    //反転なら
//                    if (pattern[i - change[q, 1], j - change[q, 0]] == '#')
//                    {
//                        if (ans[i, j] == '_')
//                        {
//                            ans[i, j] = '#';
//                        }
//                        else if (ans[i, j] == '#')
//                        {
//                            ans[i, j] = '_';
//                        }
//                    }
//                }
//            }
//        }

//        for (int i = 0; i < H; i++)
//        {
//            for (int j = 0; j < W; j++)
//            {
//                Console.Write(ans[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//}


