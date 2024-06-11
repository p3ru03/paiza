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
//        //糖度
//        int[,] brixes = new int[H, W];
//        int[] half = new int[H];
//        bool isNo = false;
//        for (int i = 0; i < H; i++)
//        {
//            datas = Console.ReadLine().Split(' ');
//            for (int j = 0; j < W; j++)
//            {
//                brixes[i, j] = int.Parse(datas[j]);
//                half[i] += int.Parse(datas[j]);
//            }
//            //そもそも二等分できないとき
//            if (half[i] % 2 != 0)
//            {
//                isNo = true;
//            }
//            half[i] /= 2;
//        }

//        char[,] answer = new char[H, W];

//        for (int i = 0; i < H; i++)
//        {
//            char AorB = 'A';
//            int check = 0;
//            for (int j = 0; j < W; j++)
//            {
//                answer[i, j] = AorB;
//                check += brixes[i, j];
//                if (check == half[i])
//                {
//                    AorB = 'B';
//                }
//            }
//            if (AorB == 'A')
//            {
//                isNo = true;
//            }
//        }

//        if (isNo)
//        {
//            Console.WriteLine("No");
//        }
//        else
//        {
//            Console.WriteLine("Yes");
//            for (int i = 0; i < H; i++)
//            {
//                for (int j = 0; j < W; j++)
//                {
//                    Console.Write(answer[i, j]);
//                }
//                Console.WriteLine();
//            }
//        }

//    }
//}

