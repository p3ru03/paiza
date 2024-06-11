//using System;
//using System.Linq;
//using System.Collections.Generic;
//using System.Globalization;
//class Program
//{
//    static void Main()
//    {
//        int N = int.Parse(Console.ReadLine());

//        string[,] table = new string[N, 2];
//        for (int i = 0; i < N; i++)
//        {
//            string[] datas = Console.ReadLine().Split(' ');
//            table[i, 0] = datas[0];
//            table[i, 1] = datas[1];
//        }

//        bool isLunch = false;
//        int time_h = 10;
//        int time_m = 0;
//        string time_zero = "0";
//        for (int i = 0; i < N; i++)
//        {
//            //お昼
//            if (!isLunch)
//            {
//                int check_h = time_h;
//                int check_m = time_m + int.Parse(table[i, 1]);

//                Cal(ref check_h, ref check_m);
//                //12:01以降なら
//                if (check_h >= 12 && check_m > 0)
//                {
//                    isLunch = true;
//                    time_m += 50;
//                    Cal(ref time_h, ref time_m);
//                }
//            }

//            if (time_m / 10 == 0)
//            {
//                Console.Write(time_h + ":" + time_zero + time_m + " - ");
//            }
//            else
//            {
//                Console.Write(time_h + ":" + time_m + " - ");
//            }

//            //発表
//            time_m += int.Parse(table[i, 1]);
//            Cal(ref time_h, ref time_m);

//            if (time_m / 10 == 0)
//            {
//                Console.Write(time_h + ":" + time_zero + time_m + " " + table[i, 0]);
//            }
//            else
//            {
//                Console.Write(time_h + ":" + time_m + " " + table[i, 0]);
//            }

//            //休憩
//            time_m += 10;
//            Cal(ref time_h, ref time_m);

//            Console.WriteLine();
//        }
//    }
//    static void Cal(ref int hour, ref int minute)
//    {
//        if (minute >= 60)
//        {
//            hour += minute / 60;
//            minute %= 60;
//        }
//    }

//}


