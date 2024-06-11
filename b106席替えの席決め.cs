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
//        int N = int.Parse(datas[2]);

//        int[] numbers = new int[N];
//        for (int i = 0; i < N; i++)
//        {
//            numbers[i] = int.Parse(Console.ReadLine());
//        }
//        //席番号を決める
//        int[,] seats = new int[H, W];
//        for (int i = 0; i < H; i++)
//        {
//            for (int j = 0; j < W; j++)
//            {
//                seats[i, j] = i * W + j + 1;
//            }
//        }

//        int[,] students = new int[H, W];
//        for (int k = 0; k < N; k++)
//        {
//            for (int i = 0; i < H; i++)
//            {
//                for (int j = 0; j < W; j++)
//                {
//                    //席番号の所に座る
//                    if (seats[i, j] == numbers[k])
//                    {
//                        students[i, j] = k + 1;
//                    }
//                }
//            }
//        }
//        //先頭側に詰めていく
//        for (int j = 0; j < W; j++)
//        {
//            for (int i = 0; i < H; i++)
//            {
//                if (students[i, j] != 0)
//                {
//                    continue;
//                }
//                for (int i2 = 1; i + i2 < H; i2++)
//                {
//                    if (students[i + i2, j] != 0)
//                    {
//                        students[i, j] = students[i + i2, j];
//                        students[i + i2, j] = 0;
//                        break;
//                    }
//                }
//            }
//        }

//        for (int i = 0; i < H; i++)
//        {
//            for (int j = 0; j < W; j++)
//            {
//                Console.Write(students[i, j]);
//                if (j != W - 1)
//                {
//                    Console.Write(" ");
//                }
//            }
//            Console.WriteLine();
//        }
//    }
//}

