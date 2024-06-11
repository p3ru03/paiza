//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string n = Console.ReadLine();
//        //桁数
//        int digit = n.Length;
//        int N = int.Parse(n);

//        int now = 0;

//        char[,] answer = new char[digit, 9];

//        for (int i = 0; i < digit; i++)
//        {
//            //i桁目の数字
//            now = int.Parse(n[i].ToString());
//            int count = 0;
//            for (int i2 = i / 3 * 3; i2 < i / 3 * 3 + 3; i2++)
//            {
//                for (int j = i % 3 * 3; j < i % 3 * 3 + 3; j++)
//                {
//                    answer[i2, j] = '.';
//                    if (count < now)
//                    {
//                        answer[i2, j] = '#';
//                        count++;
//                    }
//                }
//            }
//        }

//        for (int i = 0; i < digit; i++)
//        {
//            for (int j = 0; j < 9; j++)
//            {
//                Console.Write(answer[i, j]);
//            }
//            Console.WriteLine();
//        }

//    }
//}

