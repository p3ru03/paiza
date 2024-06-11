//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        int N = int.Parse(Console.ReadLine());
//        int[] A = new int[N];
//        for (int i = 0; i < N; i++)
//        {
//            A[i] = int.Parse(Console.ReadLine());
//        }
//        int[] ans = new int[N];
//        var list = new List<int>();

//        list.Add(A[0]);

//        //N-1個の挿入
//        for (int i = 1; i < N; i++)
//        {
//            for (int x = 0; x < list.Count(); x++)
//            {
//                if (list[x] <= A[i])
//                {
//                    list.Insert(x, A[i]);
//                    ans[i] = x;
//                    break;
//                }
//                else if (x == list.Count() - 1)
//                {
//                    list.Add(A[i]);
//                    ans[i] = list.Count() - 1;
//                    break;
//                }

//            }

//            //変動
//            for (int x = 1; x < list.Count(); x++)
//            {
//                if (list[x - 1] == list[x])
//                {
//                    list[x - 1] = 2 * list[x];
//                    list.RemoveAt(x);
//                    x = 0;
//                }
//            }

//        }

//        foreach (var i in ans)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}