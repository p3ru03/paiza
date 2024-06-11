//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');

//        int N = int.Parse(datas[0]);

//        int H = int.Parse(datas[1]);
//        int W = int.Parse(datas[2]);

//        int P = int.Parse(datas[3]);
//        int Q = int.Parse(datas[4]);

//        int[,] reserved = new int[N, 2];

//        int[,] distances = new int[H, W];

//        for (int i = 0; i < N; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            for (int j = 0; j < 2; j++)
//            {
//                reserved[i, j] = int.Parse(datas[j]);
//            }
//        }

//        for (int i = 0; i < H; i++)
//        {
//            for (int j = 0; j < W; j++)
//            {
//                distances[i, j] = Math.Abs(i - P) + Math.Abs(j - Q);
//            }
//        }

//        int min = 1000;

//        for (int i = 0; i < H; i++)
//        {
//            for (int j = 0; j < W; j++)
//            {
//                for (int x = 0; x < N; x++)
//                {
//                    //予約されていたら
//                    if (i == reserved[x, 0] && j == reserved[x, 1])
//                    {
//                        distances[i, j] = 1000;
//                    }
                   
//                }
//                if (distances[i, j] < min)
//                {
//                    min = distances[i, j];
//                }

//            }
//        }
//        //全予約の場合
//        if(min == 1000)
//        {
//            min = 0;
//        }

//        for (int i = 0; i < H; i++)
//        {
//            for (int j = 0; j < W; j++)
//            {
//                if (distances[i, j] == min)
//                {
//                    Console.WriteLine(i + " " + j);
//                }

//            }
//        }

//    }
//}

