//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        int N = int.Parse(datas[0]);
//        int c = int.Parse(datas[1]);

//        int[] times = new int[N];
//        for (int i = 0; i < N; i++)
//        {
//            times[i] = int.Parse(Console.ReadLine());
//        }

//        var list = new List<int>();
//        for (int i = 0; i < N; i++)
//        {
//            for (int j = i + 1; j < N; j++)
//            {
//                if (times[j] - times[j - 1] <= c)
//                {
//                    list.Add(times[j] - times[i] + c);
//                }
//                //遮断が途切れたらiを更新
//                else
//                {
//                    break;
//                }
//            }
//        }

//        int max = c;
//        for (int i = 0; i < list.Count; i++)
//        {
//            if (list[i] > max)
//            {
//                max = list[i];
//            }
//        }
//        Console.WriteLine(max);
//    }
//}

