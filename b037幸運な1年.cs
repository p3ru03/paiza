//using System;
//using System.Linq;
//using System.Collections.Generic;
//using System.Globalization;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int M = int.Parse(datas[0]);
//        int D = int.Parse(datas[1]);
//        //10の位と1の位に分ける
//        int M10 = M / 10;
//        int M1 = M % 10;
//        int D10 = D / 10;
//        int D1 = D % 10;

//        int[] a = new int[4];
//        datas = Console.ReadLine().Split(' ');
//        for (int i = 0; i < 4; i++)
//        {
//            a[i] = int.Parse(datas[i]);
//        }
//        int[] b = new int[4];
//        datas = Console.ReadLine().Split(' ');
//        for (int i = 0; i < 4; i++)
//        {
//            b[i] = int.Parse(datas[i]);
//        }
//        int[] m = new int[4];
//        datas = Console.ReadLine().Split(' ');
//        for (int i = 0; i < 4; i++)
//        {
//            m[i] = int.Parse(datas[i]);
//        }

//        int ans = 0;
//        int[] numbers = new int[4];
//        int[] copy = new int[4];
//        do
//        {
//            ans++;
//            //カードの数字を決める
//            for (int i = 0; i < 4; i++)
//            {
//                copy[i] = (a[i] * numbers[i] + b[i]) % m[i];
//                numbers[i] = copy[i] % 10;
//            }
//            //日付にできるかのチェック
//            int count = 0;
//            count += Check(M10, numbers);
//            count += Check(M1, numbers);
//            count += Check(D10, numbers);
//            count += Check(D1, numbers);
//            if (count == 4)
//            {
//                break;
//            }
//            //元に戻す
//            for (int i = 0; i < 4; i++)
//            {
//                numbers[i] = copy[i];
//            }
//        } while (true);

//        Console.WriteLine(ans);
//    }
//    static int Check(int checker, int[] numbers)
//    {
//        for (int i = 0; i < 4; i++)
//        {
//            if (numbers[i] == checker)
//            {
//                numbers[i] = -1;
//                return 1;
//            }
//        }
//        return 0;
//    }
//}