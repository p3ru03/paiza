//using System;
//using System.Linq;
//using System.Collections.Generic;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int H = int.Parse(datas[0]);
//        int W = int.Parse(datas[1]);
//        int N = int.Parse(datas[2]);

//        int[,] particle = new int[N, 2];
//        int max = int.MaxValue;
//        for (int i = 0; i < N; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            particle[i, 0] = int.Parse(datas[1]);
//            particle[i, 1] = int.Parse(datas[0]);
//        }

//        int[,] map = new int[H + 2, W + 2];
//        for (int i = 0; i < H + 2; i++)
//        {
//            for (int j = 0; j < W + 2; j++)
//            {
//                if (i == 0 || i == H + 1 || j == 0 || j == W + 1)
//                {
//                    map[i, j] = max;
//                }
//            }
//        }

//        for (int n = 0; n < N; n++)
//        {
//            int x = particle[n, 1];
//            int y = particle[n, 0];

//            Set(y, x, map);
//        }

//        for (int i = 1; i < H + 1; i++)
//        {
//            for (int j = 1; j < W + 1; j++)
//            {
//                Console.Write(map[i, j]);
//                if (j != W)
//                {
//                    Console.Write(" ");
//                }
//            }
//            Console.WriteLine();
//        }
//    }
//    static void Set(int y, int x, int[,] map)
//    {

//        if (map[y, x] > map[y - 1, x])
//        {
//            y--;
//            Set(y, x, map);
//        }
//        else if (map[y, x] > map[y, x + 1])
//        {
//            x++;
//            Set(y, x, map);
//        }
//        else if (map[y, x] > map[y + 1, x])
//        {
//            y++;
//            Set(y, x, map);
//        }
//        else if (map[y, x] > map[y, x - 1])
//        {
//            x--;
//            Set(y, x, map);
//        }
//        else
//        {
//            map[y, x]++;
//        }
//    }
//}
