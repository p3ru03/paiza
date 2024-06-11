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

//        char[,] picture = new char[H + 2, W + 2];
//        string data;
//        for (int i = 1; i < H + 1; i++)
//        {
//            data = Console.ReadLine();
//            for (int j = 1; j < W + 1; j++)
//            {
//                picture[i, j] = data[j - 1];
//            }
//        }
//        data = Console.ReadLine();

//        char[,] changed = new char[H, W];

//        for (int n = 0; n < N; n++)
//        {
//            char operation = data[n];
//            char changedby = '.';
//            if (operation == 'D')
//            {
//                changedby = '#';
//            }

//            for (int i = 1; i < H + 1; i++)
//            {
//                for (int j = 1; j < W + 1; j++)
//                {
//                    if (picture[i - 1, j] == changedby)
//                    {
//                        changed[i - 1, j - 1] = changedby;
//                    }
//                    else if (picture[i + 1, j] == changedby)
//                    {
//                        changed[i - 1, j - 1] = changedby;
//                    }
//                    else if (picture[i, j - 1] == changedby)
//                    {
//                        changed[i - 1, j - 1] = changedby;
//                    }
//                    else if (picture[i, j + 1] == changedby)
//                    {
//                        changed[i - 1, j - 1] = changedby;
//                    }
//                    else
//                    {
//                        changed[i - 1, j - 1] = picture[i, j];
//                    }
//                }
//            }
//            //ここで戻さないといけない
//            for (int i = 1; i < H + 1; i++)
//            {
//                for (int j = 1; j < W + 1; j++)
//                {
//                    picture[i, j] = changed[i - 1, j - 1];
//                }
//            }
//        }

//        for (int i = 0; i < H; i++)
//        {
//            for (int j = 0; j < W; j++)
//            {
//                Console.Write(changed[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//}

