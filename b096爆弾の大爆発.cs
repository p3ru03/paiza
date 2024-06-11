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

//        char[,] bombs = new char[H, W];
//        for (int i = 0; i < H; i++)
//        {
//            string data = Console.ReadLine();
//            for (int j = 0; j < W; j++)
//            {
//                bombs[i, j] = data[j];
//            }
//        }

//        for (int i = 0; i < H; i++)
//        {
//            for (int j = 0; j < W; j++)
//            {
//                if (bombs[i, j] == '#')
//                {
//                    //i行目を爆発
//                    for (int j2 = 0; j2 < W; j2++)
//                    {
//                        if (bombs[i, j2] == '.')
//                        {
//                            bombs[i, j2] = 'x';
//                        }
//                    }
//                    //j列目を爆発
//                    for (int i2 = 0; i2 < H; i2++)
//                    {
//                        if (bombs[i2, j] == '.')
//                        {
//                            bombs[i2, j] = 'x';
//                        }
//                    }
//                }
//            }
//        }

//        int answer = 0;
//        for (int i = 0; i < H; i++)
//        {
//            for (int j = 0; j < W; j++)
//            {
//                if (bombs[i, j] == '#' || bombs[i, j] == 'x')
//                {
//                    answer++;
//                }
//            }
//        }

//        Console.WriteLine(answer);
//    }
//}

