//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int H = int.Parse(datas[0]);
//        int W = int.Parse(datas[1]);

//        int[,] table = new int[H, W];
//        for (int i = 0; i < 2; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            for (int j = 0; j < 2; j++)
//            {
//                table[i, j] = int.Parse(datas[j]);
//            }
//        }

//        for (int i = 0; i < 2; i++)
//        {
//            for (int j = 2; j < W; j++)
//            {
//                table[i, j] = table[i, j - 1] + table[i, 1] - table[i, 0];
//            }
//        }

//        for (int i = 2; i < H; i++)
//        {
//            for (int j = 0; j < W; j++)
//            {
//                table[i, j] = table[i - 1, j] + table[1, j] - table[0, j];
//            }
//        }

//        for (int i = 0; i < H; i++)
//        {
//            for (int j = 0; j < W; j++)
//            {
//                Console.Write(table[i, j]);
//                if (j != W - 1)
//                {
//                    Console.Write(" ");
//                }
//            }
//            Console.WriteLine();
//        }
//    }
//}