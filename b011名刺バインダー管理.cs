//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int n = int.Parse(datas[0]);
//        int m = int.Parse(datas[1]);

//        int ans = 0;
//        int page = (m - 1) / n + 1;
//        //端からの距離を考えて整理したらこうなった
//        if (page % 2 == 1)
//        {
//            ans = 2 * n * page + 1 - m;
//        }
//        else
//        {
//            ans = n * (page - 2) + 1 + n * page - m;
//        }
//        Console.WriteLine(ans);
//    }
//}