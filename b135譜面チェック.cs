//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        int N = int.Parse(Console.ReadLine());
//        var ans = new List<int>();

//        for (int n = 0; n < N; n++)
//        {
//            string[] datas = Console.ReadLine().Split(' ');
//            int M = int.Parse(datas[0]);
//            string[] key = new string[M];
//            string checker = null;
//            for (int m = 0; m < M; m++)
//            {
//                key[m] = datas[m + 1];
//                checker += key[m];
//            }

//            int outcount = 0;
//            int okline = 1;
//            //両側の鍵盤を使う場合
//            if (checker.Contains("L") && checker.Contains("R"))
//            {
//                okline = 0;
//            }

//            //上下の鍵盤     
//            if ((checker.Contains("La") && checker.Contains("Lb")) || (checker.Contains("Ra") && checker.Contains("Rb")))
//            {
//                outcount++;
//                if (outcount > okline)
//                {
//                    ans.Add(n + 1);
//                    continue;
//                }
//            }

//            //両端の鍵盤
//            if ((checker.Contains("La_1") && checker.Contains("La_6")) || (checker.Contains("Ra_1") && checker.Contains("Ra_6"))
//                || (checker.Contains("Lb_1") && checker.Contains("Lb_6")) || (checker.Contains("Rb_1") && checker.Contains("Rb_6")))
//            {
//                outcount++;
//                if (outcount > okline)
//                {
//                    ans.Add(n + 1);
//                    continue;
//                }
//            }
//        }

//        foreach (var i in ans)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}