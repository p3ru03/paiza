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

//        char[,] map = new char[H + 2, W + 2];
//        int rope = 0;
//        for (int i = 1; i < H + 1; i++)
//        {
//            string data = Console.ReadLine();
//            for (int j = 1; j < W + 1; j++)
//            {
//                map[i, j] = data[j - 1];
//                if (map[i, j] == '#')
//                {
//                    rope++;
//                }
//            }
//        }
//        //1個囲むのに4個必要
//        rope *= 4;

//        for (int i = 1; i < H + 1; i++)
//        {
//            for (int j = 1; j < W + 1; j++)
//            {
//                //隣に花壇があればロープを減らす
//                if (map[i, j] == '#')
//                {
//                    if (map[i - 1, j] == '#')
//                    {
//                        rope--;
//                    }
//                    if (map[i + 1, j] == '#')
//                    {
//                        rope--;
//                    }
//                    if (map[i, j - 1] == '#')
//                    {
//                        rope--;
//                    }
//                    if (map[i, j + 1] == '#')
//                    {
//                        rope--;
//                    }
//                }
//            }
//        }

//        Console.WriteLine(rope);
//    }
//}

