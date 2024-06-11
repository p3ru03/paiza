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

//        int[,] display1 = new int[2 * H, 2 * W];
//        int[,] display2 = new int[2 * H, 2 * W];
//        int[,] answer = new int[2 * H - 1, 2 * W - 1];


//        for (int i = 0; i < H; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            for (int j = 0; j < W; j++)
//            {
//                display1[2 * i, 2 * j] = int.Parse(datas[j]);
//                display1[2 * i, 2 * j + 1] = int.Parse(datas[j]);
//                display1[2 * i + 1, 2 * j] = int.Parse(datas[j]);
//                display1[2 * i + 1, 2 * j + 1] = int.Parse(datas[j]);
//            }
//        }

//        for (int i = 0; i < H; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            for (int j = 0; j < W; j++)
//            {
//                display2[2 * i, 2 * j] = int.Parse(datas[j]);
//                display2[2 * i, 2 * j + 1] = int.Parse(datas[j]);
//                display2[2 * i + 1, 2 * j] = int.Parse(datas[j]);
//                display2[2 * i + 1, 2 * j + 1] = int.Parse(datas[j]);
//            }
//        }

//        for (int i = 0; i < 2 * H - 1; i++)
//        {
//            for (int j = 0; j < 2 * W - 1; j++)
//            {
//                answer[i, j] = (display1[i + 1, j + 1] + display2[i, j]) / 2;
//                Console.Write(answer[i, j]);
//                if (j != 2 * W - 2)
//                {
//                    Console.Write(' ');
//                }
//            }
//            Console.WriteLine();
//        }

//    }
//}

