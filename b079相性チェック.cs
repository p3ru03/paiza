//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        string[] datas = Console.ReadLine().Split(' ');
//        string s = datas[0];
//        string t = datas[1];

//        string[] A = { s + t, t + s };

//        string alpha = "abcdefghijklmnopqrstuvwxyz";
//        int max = 0;

//        for (int n = 0; n < A.Length; n++)
//        {
//            var list = new List<int>();
//            //文字列を数値に変換
//            for (int i = 0; i < A[n].Length; i++)
//            {
//                for (int j = 0; j < alpha.Length; j++)
//                {
//                    if (A[n][i] == alpha[j])
//                    {
//                        list.Add(j + 1);
//                    }
//                }
//            }

//            var listcopy = new List<int>();
//            do
//            {
//                for (int i = 0; i < list.Count - 1; i++)
//                {
//                    if (list[i] + list[i + 1] > 101)
//                    {
//                        listcopy.Add(list[i] + list[i + 1] - 101);
//                    }
//                    else
//                    {
//                        listcopy.Add(list[i] + list[i + 1]);
//                    }
//                }
//                list = new List<int>(listcopy);
//                listcopy.Clear();

//            } while (list.Count != 1);

//            if (list[0] > max)
//            {
//                max = list[0];
//            }
//        }
//        Console.WriteLine(max);
//    }
//}

