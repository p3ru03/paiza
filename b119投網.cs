//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int H = int.Parse(datas[0]);
//        int W = int.Parse(datas[1]);

//        int[,] fishes = new int[H, W];
//        for (int i = 0; i < H; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            for (int j = 0; j < W; j++)
//            {
//                fishes[i, j] = int.Parse(datas[j]);
//            }
//        }

//        datas = Console.ReadLine().Split(' ');
//        int R = int.Parse(datas[0]);
//        int C = int.Parse(datas[1]);

//        char[,] net = new char[R, C];
//        for (int i = 0; i < R; i++)
//        {
//            string data = Console.ReadLine();
//            for (int j = 0; j < C; j++)
//            {
//                net[i, j] = data[j];
//            }
//        }

//        int answer = 0;

//        for (int i = 0; i < H; i++)
//        {
//            for (int j = 0; j < W; j++)
//            {
//                //網がはみ出したらダメ
//                if (i + R > H || j + C > W)
//                {
//                    continue;
//                }
//                int max = 0;
//                //(i,j)に網の左上を合わせる
//                for (int i2 = 0; i2 < R; i2++)
//                {
//                    for (int j2 = 0; j2 < C; j2++)
//                    {

//                        if (net[i2, j2] == '#')
//                        {
//                            max += fishes[i + i2, j + j2];
//                        }
//                    }
//                }
//                if (max > answer)
//                {
//                    answer = max;
//                }
//            }
//        }

//        Console.WriteLine(answer);
//    }
//}

