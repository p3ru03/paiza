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

//        char[,] table = new char[H, W];
//        int a = 0;
//        int b = 0;
//        int c = 0;

//        //正方形になるようにチェックする
//        int check1 = 0;
//        int check2 = 0;

//        for (int n = 0; n < N; n++)
//        {
//            //プレイヤー1
//            datas = Console.ReadLine().Split(' ');
//            for (int i = int.Parse(datas[1]); i < H; i++)
//            {
//                for (int j = int.Parse(datas[0]); j < W; j++)
//                {
//                    if (table[i, j] == 'b')
//                    {
//                        table[i, j] = 'c';
//                    }
//                    else if (table[i, j] == 'c')
//                    {
//                        table[i, j] = 'b';
//                    }
//                    else
//                    {
//                        table[i, j] = 'a';
//                    }
//                    check2++;
//                    if (check2 == int.Parse(datas[2]))
//                    {
//                        check2 = 0;
//                        break;
//                    }
//                }
//                check2 = 0;
//                check1++;
//                if (check1 == int.Parse(datas[2]))
//                {
//                    check1 = 0;
//                    break;
//                }
//            }
//            check1 = 0;
//            //プレイヤー2
//            datas = Console.ReadLine().Split(' ');
//            for (int i = int.Parse(datas[1]); i < H; i++)
//            {
//                for (int j = int.Parse(datas[0]); j < W; j++)
//                {
//                    if (table[i, j] == 'a')
//                    {
//                        table[i, j] = 'c';
//                    }
//                    else if (table[i, j] == 'c')
//                    {
//                        table[i, j] = 'a';
//                    }
//                    else
//                    {
//                        table[i, j] = 'b';
//                    }
//                    check2++;
//                    if (check2 == int.Parse(datas[2]))
//                    {
//                        check2 = 0;
//                        break;
//                    }
//                }
//                check2 = 0;
//                check1++;
//                if (check1 == int.Parse(datas[2]))
//                {
//                    check1 = 0;
//                    break;
//                }
//            }
//            check1 = 0;
//            //プレイヤー3
//            datas = Console.ReadLine().Split(' ');
//            for (int i = int.Parse(datas[1]); i < H; i++)
//            {
//                for (int j = int.Parse(datas[0]); j < W; j++)
//                {
//                    if (table[i, j] == 'a')
//                    {
//                        table[i, j] = 'b';
//                    }
//                    else if (table[i, j] == 'b')
//                    {
//                        table[i, j] = 'a';
//                    }
//                    else
//                    {
//                        table[i, j] = 'c';
//                    }
//                    check2++;
//                    if (check2 == int.Parse(datas[2]))
//                    {
//                        check2 = 0;
//                        break;
//                    }
//                }
//                check2 = 0;
//                check1++;
//                if (check1 == int.Parse(datas[2]))
//                {
//                    check1 = 0;
//                    break;
//                }
//            }
//            check1 = 0;
//        }

//        //数える
//        for (int i = 0; i < H; i++)
//        {
//            for (int j = 0; j < W; j++)
//            {
//                if (table[i, j] == 'a')
//                {
//                    a++;
//                }
//                else if (table[i, j] == 'b')
//                {
//                    b++;
//                }
//                else if (table[i, j] == 'c')
//                {
//                    c++;
//                }
//            }
//        }
//        Console.WriteLine(a + " " + b + " " + c);
//    }
//}

